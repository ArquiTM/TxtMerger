using System.IO;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"arquivoTres.txt");
            string[] reader1 = File.ReadAllLines(@"arquivoUm.txt");
            string[] reader2 = File.ReadAllLines(@"arquivoDois.txt");
            int count1 = 0;
            int count2 = 0;

            if (File.Exists(path))
                File.Delete(path);

            using (StreamWriter sw = File.CreateText(path))
            {
                do
                {
                    if (reader1.Length > count1)
                    {
                        sw.WriteLine(reader1[count1]);
                        count1++;
                    }
                    if (reader2.Length > count2)
                    {
                        sw.WriteLine(reader2[count2]);
                        count2++;
                    }
                }
                while (reader1.Length > count1 || reader2.Length > count2);
            }
        }
    }
}