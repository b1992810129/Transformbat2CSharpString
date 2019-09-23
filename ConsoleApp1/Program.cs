using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Transformbat2CSharpString
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(args[0]);
            StreamWriter sw=new StreamWriter(Path.GetFileNameWithoutExtension(args[0])+"_.txt");
            while (sr.EndOfStream == false)
            {
                string str = sr.ReadLine().Replace("\\", "\\\\");
                str="\""+str.Replace("\"","\\\"") + "\\n\""+"+";
                sw.WriteLine(str);
            }
            sr.Close();
            sw.Close();
        }
    }
}
