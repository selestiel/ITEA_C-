using System;

namespace L11TaskA2
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter train data acoordingly: destination name, train id, departure date");
            Console.WriteLine("Enter first train data: ");
            Train A = new Train(Convert.ToString(Console.ReadLine())
                , Convert.ToInt32(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter second train data: ");
            Train B = new Train(Convert.ToString(Console.ReadLine())
                , Convert.ToInt32(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter third train data: ");
            Train C = new Train(Convert.ToString(Console.ReadLine())
                , Convert.ToInt32(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter fourth train data: ");
            Train D = new Train(Convert.ToString(Console.ReadLine())
                , Convert.ToInt32(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine("Enter fifth train data: ");
            Train E = new Train(Convert.ToString(Console.ReadLine())
                , Convert.ToInt32(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
            Train[] trains = new Train[]
            {
                A,
                B,
                C,
                D,
                E
            };
            int a = 0;
            Train[] b_trains = new Train[trains.Length];
            for (int i = 0; i < trains.Length; i++)
            {
                if(a <= trains[i].GetId())
                {
                    a = trains[i].GetId();
                    b_trains[a] = trains[i];


                }
                
            }
            trains = b_trains;
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Trains Are: ID: {0} Dest: {1} Date: {2}"
                    ,trains[i].GetId(),trains[i].GetName(),trains[i].GetDate());
            }
    }
       
        struct Train
        {
            string dest_name { get; set; }
            int train_id { get; set; }
            DateTime dept_time { get; set; }

            public string GetName()
            {
                return dest_name;
            }
            public int GetId()
            {
                return train_id;
            }
            public DateTime GetDate()
            {
                return dept_time;
            }
            public Train(string dest, int id, DateTime deptime)
            {
                dest_name = dest;
                train_id = id;
                dept_time = deptime;
            }
           
            
        }
    }
}
