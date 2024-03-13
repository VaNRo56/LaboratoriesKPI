using System.Text;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть шлях до папки: ");
            string PapPath = Console.ReadLine();
            if (Directory.Exists(PapPath))
            {
                List<string> files = GetFilesPapka(PapPath);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }   
            else 
            {

                Console.WriteLine("Directory doesnt exist");

                }

            }
        static List<string> GetFilesPapka(string path)
        {
            List<string> filelist = new List<string>();
            try
            {
                string[] files = Directory.GetFiles(path);
                filelist.AddRange(files);

                string[] subfiles = Directory.GetDirectories(path);
                foreach(string subfile in subfiles)
                {
                    filelist.AddRange(GetFilesPapka(subfile));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return filelist;
        }
        }
    }