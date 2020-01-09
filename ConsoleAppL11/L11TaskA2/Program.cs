using System;

namespace L11TaskA2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter train data acoordingly: destination name, train id, departure date");
            Console.WriteLine("Enter first train data: ");
            Train[] trains = new Train[5];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Enter train ID");
                trains[i].train_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter train destination name");
                trains[i].dest_name = Console.ReadLine();
                Console.WriteLine("Enter train departure time");
                trains[i].dept_time = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();
            SortT(trains);
            Console.WriteLine();
            /*Console.WriteLine("Enter search min ID, and max ID(or just 0)");*/
            Console.WriteLine("Enter search ID");

            FindT(trains, Convert.ToInt32(Console.ReadLine()),/* Convert.ToInt32(Console.ReadLine())*/);
            

            Console.ReadKey();
        }
        public static void SortT(Train[] trains)
        {
            Train sub;
            bool iff = true;
            while (iff == true)
            {
                if (trains[0].train_id >= trains[1].train_id)
                {
                    sub = trains[0];
                    trains[0] = trains[1];
                    trains[1] = sub;

                }
                else if (trains[1].train_id >= trains[2].train_id)
                {
                    sub = trains[1];
                    trains[1] = trains[2];
                    trains[2] = sub;

                }
                else if (trains[2].train_id >= trains[3].train_id)
                {
                    sub = trains[2];
                    trains[2] = trains[3];
                    trains[3] = sub;

                }
                else if (trains[3].train_id >= trains[4].train_id)
                {
                    sub = trains[3];
                    trains[3] = trains[4];
                    trains[4] = sub;

                }
                else
                {
                    iff = false;
                }
                iff = false;
            }
        }
        public static void FindT(Train[] trains, int ID_S, int ID_N)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].train_id == ID_S/* && ID_N == 0*/)
                {
                    Console.WriteLine(@"Train Data is:  ID: {0}    DEST: {1}    DEPTIME: {2}"
                        , trains[i].train_id, trains[i].dest_name, trains[i].dept_time);
                }
                /*else if (trains[i].train_id == ID_S && ID_N != 0) 
                {
                    int j = i;
                    while(trains[j].train_id <= trains.Length)
                    {
                        j++;
                        Console.WriteLine(@"Train Data is:  ID: {0}    DEST: {1}    DEPTIME: {2}"
                            , trains[j].train_id, trains[j].dest_name, trains[j].dept_time);
                    }
                }*/
            }
        }
    }


    struct Train
    {
        public string dest_name { get; set; }
        public int train_id { get; set; }
        public DateTime dept_time { get; set; }


        public Train(string dest, int id, DateTime deptime)
        {
            dest_name = dest;
            train_id = id;
            dept_time = deptime;
        }


    }
}

