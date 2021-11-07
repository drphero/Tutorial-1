using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleAppTDD
{
    public class Calculator
    {
        int result;
        public int Addition(int v1, int v2)
        {
            result = v1 + v2;
            WriteResult(result);
            return result;
        }

        public int Multiplication(int v1, int v2)
        {
            result = v1 * v2;
            WriteResult(result);
            return result;
        }

        public int Division(int v1, int v2)
        {
            if (v2 == 0)
            {
                return -9999;
            }
            else
            {
                result =  v1 / v2;
                WriteResult(result);
                return result;
            }
        }

        static async void WriteResult(int num)
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var file = Path.Combine(dir, "Results.txt");

            try
            {
                using (StreamWriter outputFile = new StreamWriter(file, true))
                {
                    await outputFile.WriteLineAsync(num.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(Environment.NewLine + e.Message);
            }
        }
    }
}