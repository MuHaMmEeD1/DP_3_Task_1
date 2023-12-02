using DP_3_Task_1;

namespace Task1
{

    class Program
    {

        static void Main(string[] args)
        {
            FileDataSource fileDataSource = new("F1");
            EncryptionDecrator encryptionDecrator = new(fileDataSource);

            encryptionDecrator.readData();

        }
    }


}