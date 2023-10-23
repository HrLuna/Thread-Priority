using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackThread
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" -Thread Starts- ");

            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A Process";
            threadA.Priority = ThreadPriority.Highest;

            Thread threadB = new Thread(MyThreadClass.Thread2);
            threadB.Name = "Thread B Process";
            threadB.Priority = ThreadPriority.Normal;

            Thread threadC = new Thread(MyThreadClass.Thread1);
            threadC.Name = "Thread C Process";
            threadC.Priority = ThreadPriority.AboveNormal;

            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D Process";
            threadD.Priority = ThreadPriority.BelowNormal;
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
            threadB.Join();
            threadD.Join();
            Console.WriteLine(" -End of Thread- ");
            label1.Text = " -End of Thread- ";

        }
    }
}
