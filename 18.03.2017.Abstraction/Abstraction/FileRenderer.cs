using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class FileRenderer : IRenderer
    {
        private string filePath;

        public FileRenderer(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(object input)
        {
            using (var stream = new StreamWriter(filePath,true))
            {
                stream.Write(input);
            }
        }

        public void WriteLine(object input)
        {
            using (var stream = new StreamWriter(filePath,true))
            {
                stream.WriteLine(input);
            }
        }
    }
}
