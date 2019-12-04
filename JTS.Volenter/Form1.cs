using JTS.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTS.Volenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var mac = "ABCDRF123";
            var address = new EndpointAddress("http://localhost:54572/JobService.svc");
            var binding = new BasicHttpBinding();
            var channel = ChannelFactory<IJobService>.CreateChannel(binding, address);
            var n = channel.GetNewJob(mac);


                
            channel.SaveJobResult(mac, n, true);
        }
    }
}
