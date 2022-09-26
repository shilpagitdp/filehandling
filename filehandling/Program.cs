using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FileStream fs = new FileStream("C:\\Users\\shilpa.devanga\\Documents\\testing.txt", FileMode.OpenOrCreate) ;
            StreamWriter streamWriter = new StreamWriter(fs) ;
            streamWriter.WriteLine("hii!, this is the first line of the code writing inside the file..!");
            streamWriter.Close();
            fs.Close();
        }
    }
}
