using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kivetelkezeles_feladat
{
    class Class1
    {
        public static void BirkaImi()
        {
            StreamReader sr = null;
            if(!File.Exists(@"d:\helloka.txt"))
            {
                return;
            }
            try
            {
                sr = new StreamReader(@"d:\helloka.txt");
                sr.ReadLine();
            }
            catch (System.IO.DirectoryNotFoundException xcp)
            {
                Console.WriteLine(xcp.Message);
            }
            catch (System.Exception xcp)
            {
                Console.WriteLine("SE"+xcp.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }


    }
}
