using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTS.Business
{
    public class Job
    {
        public static long GetNewJob(string mac)
        {
            using (JTSDataContext dc = new JTSDataContext())
            {
                // Hesaplanmamış ve atamadan sonra 1 saat geçmiş
                //var kosul1 = dc.jobs.Where(c => c.status == 0 && c.assign_date < DateTime.Now.AddHours(-1));

                // Hesaplanmış tüm N değerleri
                var hesaplanmisNDegerleri = dc.jobs.Where(c => c.status != 0).Select(c => c.n);

                var tarih = DateTime.Now.AddHours(-1);

                // Atama işleminden sonra henüz 1 saat geçmemiş N değerleri
                var henuzAtanmisNDegerleri = dc.jobs.Where(c => c.assign_date > tarih).Select(c => c.n);

                var N = (from c in dc.jobs
                         // Hesaplanmamış ve atamadan sonra 1 saat geçmiş
                         where c.status == 0 && c.assign_date < DateTime.Now.AddHours(-1)
                         && !hesaplanmisNDegerleri.Contains(c.n)
                         && !henuzAtanmisNDegerleri.Contains(c.n)
                         select c.n).FirstOrDefault();

                var n = (from c in dc.jobs
                         where c.status == 0 && c.assign_date < DateTime.Now.AddHours(-1)
                            && !dc.jobs.Any(k => (k.n == c.n && (k.status != 0 || k.assign_date >= DateTime.Now.AddHours(-1))))
                         select c.n).FirstOrDefault();

                if (n > 0)
                {
                    Job.AddJob(dc, mac, n);
                    return n;
                }

                n = (from c in dc.jobs
                     orderby c.n descending
                     select c.n).FirstOrDefault();

                if (n > 0)
                {
                    Job.AddJob(dc, mac, n + 2);
                    return n + 2;
                }

                Job.AddJob(dc, mac, 3);
                return 3;
            }
        }

        private static void AddJob(JTSDataContext dc, string mac, long n)
        {
            dc.jobs.InsertOnSubmit(new job
            {
                job_id = Guid.NewGuid(),
                mac = mac,
                n = n,
                assign_date = DateTime.Now,
                status = 0
            });

            dc.SubmitChanges();
        }

        public static void SaveResult(string mac, long n, bool isPrime)
        {
            using (JTSDataContext dc = new JTSDataContext())
            {
                var item = (from c in dc.jobs
                            where c.mac == mac && c.n == n && c.status == 0
                            orderby c.assign_date descending
                            select c).FirstOrDefault();

                if (item != null)
                {
                    item.status = isPrime ? (byte)1 : (byte)2;
                    item.complete_date = DateTime.Now;

                    dc.SubmitChanges();
                }
            }
        }

    }
}
