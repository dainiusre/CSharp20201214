using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210111_InterfacePVz
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public interface IFileWriter
    {
        string Extension { get; }
        void Write(string text);
    }

    public class TextWriter : IFileWriter
    {
        public string Name { get; }
        public string Extension 
        {
            get
            {
                return ".txt";
            }
        }

        public TextWriter(string name)
        {
            Name = name;
        }

        public void Write(string text)
        {
            File.WriteAllText(Name + Extension, text);
        }
    }
}
