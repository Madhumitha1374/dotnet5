using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MadhuWindowService
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer(); // name space(using System.Timers;)
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at " + DateTime.Now);
            checkIfFIleExists();
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 1000; //number in milisecinds
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            //WriteToFile("Service is stopped at " + DateTime.Now);
            checkIfFIleExists();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
           // WriteToFile("Service is recall at " + DateTime.Now);
            checkIfFIleExists();
        }

        public void checkIfFIleExists()
        {
            string path = "D:\\DotNetWorking\\Sagar";
                string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";

                if (File.Exists(path + "\\Maneesh.txt"))
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine("File exists" + DateTime.Now);
                        
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine("File does not exists" + DateTime.Now);
                    }
                }
        }
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }
    }
}

