using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern01
{
    public interface IReadableFile
        //Abstract Strategy Class
    {
        public void CreateFile(string fileName);
    }
}
