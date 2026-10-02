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

namespace ThreadPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "-Thread Starts-";
            lblStatus.Refresh();
            Console.WriteLine("-Thread Starts-");

            // Step 5: create four threads
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            // Step 6: set priorities
            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            // Start all threads
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            // Step 7: Join() makes the form wait until each thread ends
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            // Step 9: show end message
            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "-End of Thread-";

            lblStatus.Text = "-End of Thread-";
        }          
    }              
}              
                