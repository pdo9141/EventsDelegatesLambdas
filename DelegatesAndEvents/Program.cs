using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

        static void Main(string[] args)
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //DoWork(del1);
            //DoWork(del2);

            //del1 += del2 + del3;
            //int finalHours = del1(10, WorkType.GenerateReports);
            //Console.WriteLine("finalHours: {0}", finalHours);

            var worker = new Worker();
            //worker.WorkPerformed += Worker_WorkPerformed;
            //worker.WorkCompleted += Worker_WorkCompleted;

            worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours worked:{0}, workType:{1}", e.Hours, e.WorkType.ToString());
            };
            
            worker.WorkCompleted += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Worker is done");
            };

            worker.DoWork(9, WorkType.Golf);

            Console.ReadLine();
        }
        
        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked:{0}, workType:{1}", e.Hours, e.WorkType.ToString());
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
