using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class FileReader : IReader
    {
        private string filePath;

        public FileReader(string path)
        {
            this.filePath = path;                
        }

        public override string Read()
        {
            string text;
            using (StreamReader reader = new StreamReader(this.filePath))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        public override string ReadLine()
        {
            string text;
            using (StreamReader reader = new StreamReader(this.filePath))
            {
                text = reader.ReadLine();
            }

            return text;
        }
    }
}
