using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_3_Task_1
{
    public class FileDataSource : DataSorce
    {
        private string? _fileName;

        public FileDataSource(string? fileName)
        {
            _fileName = fileName;
        }

        public void readData()
        {
            Console.WriteLine(_fileName);
        }

        public void writeData(string data)
        {
            _fileName = data;
        }
    }
}
