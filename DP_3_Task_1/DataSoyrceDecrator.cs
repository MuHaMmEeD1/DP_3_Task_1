using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_3_Task_1
{
    public class DataSoyrceDecrator : DataSorce
    {
        public DataSoyrceDecrator(DataSorce? wrappee)
        {
            this.wrappee = wrappee;
        }

        private DataSorce? wrappee { get; set; } 
        public virtual void readData()
        {
            Console.WriteLine("DataSoyrceDecrator");
            wrappee?.readData();
        } 

        public virtual void writeData(string data)
        {
            wrappee?.writeData(data);
        }
    }
}
