using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_3_Task_1
{
    public class CompressionDecorator : DataSoyrceDecrator
    {
        public CompressionDecorator(DataSorce? wrappee) : base(wrappee)
        {
        }

        public override void readData()
        {
            Console.WriteLine("CompressionDecorator");
            base.readData();
        }

        public override void writeData(string data)
        {
            base.writeData(data);
        }

    }
}
