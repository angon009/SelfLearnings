using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern01
{
    public class FileCreatorContext
        //Context Class
    {
        private IReadableFile _readableFile; 
        public void SetStrategy(IReadableFile readableFile)
        {
            _readableFile = readableFile;
        }
        public void CreateFile(string fileName)
        {
            _readableFile.CreateFile(fileName);
        }
    }
}
