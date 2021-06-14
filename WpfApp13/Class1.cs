using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WpfApp13
{
    class Class1
    {

        StreamWriter r = new StreamWriter("1.txt");
         
        
        
        
        FileStream f = new FileStream("1.json", FileMode.OpenOrCreate);

        
        StreamReader reader= new StreamReader("1.csv");
        
    }
}
