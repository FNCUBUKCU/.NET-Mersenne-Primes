using JTS.Business;
using JTS.Contracts;

namespace JTS.Service
{
    public class JobService : IJobService
    {
        public long GetNewJob(string mac)
        {
            return Job.GetNewJob(mac);
        }

        public void SaveJobResult(string mac, long n, bool isPrime)
        {
            Job.SaveResult(mac, n, isPrime);
        }
    }
}
