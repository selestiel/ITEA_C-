using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11TaskC1
{
 

    class Program
    {
        struct alfa
        {
            static string fields
            {
                get
                {
                    return fields;
                }
                set
                {
                    fields = value;
                }
            }
        }
        static void Main(string[] args)
        {
            alfa ima;
        }
        public int[] array;
        public int this [int index] // INDEXATOR FOR PEREBIRANIE MASSIVA...........
            { 

            get
            {
                return array[index];
            }
        
            set
            {
                array[index] = value;
            }
        
            
        
        }
        enum fara
        {

        }
        
    }
}
