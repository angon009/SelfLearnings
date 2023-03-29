using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern01
{
    public class WordFileCreator : IReadableFile
        //Concrete Strategy Class
    {
        public void CreateFile(string fileName)
        {
            Console.WriteLine($"'{fileName}.docs' file created.");
        }
    }
}
