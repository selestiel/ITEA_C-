using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9TaskA4
{
    class Program
    {
        static void Main(string[] args)
        {
            File A = new File("Sher", "TXT");
            File B = new File("Vile", "XML");
            File C = new File("Mask", "DOC");
            XMLHandler x = new XMLHandler();
            Console.WriteLine("XML");
            File xml = x.Create();
            x.Open(xml);
            x.Change(xml);
            x.Save(xml);
            DOCHandler d = new DOCHandler();
            Console.WriteLine("DOC");
            File doc = d.Create();
            d.Open(doc);
            d.Change(doc);
            d.Save(doc);
            TXTHandler t = new TXTHandler();
            Console.WriteLine("TXT");
            File txt = t.Create();
            t.Open(txt);
            t.Change(txt);
            t.Save(txt);

            Console.WriteLine();
            Console.ReadKey();


        }
    }
    class File
    {
        public string Format_Type { get; set; }
        public string name { get; set; }
        public enum state
        {
            Opened,
            Creating,
            Changing,
            Saved
        }
        public state Status { get; set; }
        public File(string n, string f)
        {
            name = n;
            Format_Type = f;
        }
        public override string ToString()
        {
            return string.Format("File name: {0}  format: {1} and status: {2}",name,Format_Type,Status);
        }
    }
    class AbstractHandler
    {
        public File Create()
        {
            File file = new File("","");
            return file;
        }
        public void Change(File file) { }
        public void Save(File file) { }
        public void Open(File file) { }
    }
    class XMLHandler: AbstractHandler
    {
        public File Create()
        {
            File file = new File("Somefile", "XML");
        
            if (file.Format_Type == "XML")
            {
                Console.WriteLine(file.Status = File.state.Creating);
            }
            return file;
        }
        public new void Change(File f)
        {
            if (f.Format_Type == "XML")
            {
                Console.WriteLine(f.Status = File.state.Changing);
            }
        }
        public new void Save(File f)
        {
            if (f.Format_Type == "XML")
            {
                Console.WriteLine(f.Status = File.state.Saved);
            }
        }
        public new void Open(File f)
        {
            if (f.Format_Type == "XML")
            {
                Console.WriteLine(f.Status = File.state.Opened);
            }
        }
    }
    class DOCHandler : AbstractHandler
    {
        public File Create()
        {
            File file = new File("Somefile", "DOC");

            if (file.Format_Type == "DOC")
            {
                Console.WriteLine(file.Status = File.state.Creating);
            }
            return file;
        }
        public new void Change(File d)
        {
            if (d.Format_Type == "DOC")
            {
                Console.WriteLine(d.Status = File.state.Changing);
            }
        }
        public new void Save(File d)
        {
            if (d.Format_Type == "DOC")
            {
                Console.WriteLine(d.Status = File.state.Saved);
            }
        }
        public new void Open(File d)
        {
            if (d.Format_Type == "DOC")
            {
                Console.WriteLine(d.Status = File.state.Opened);
            }
        }
    }
    class TXTHandler : AbstractHandler
    {
        public File Create()
        {
            File file = new File("Somefile", "TXT");

            if (file.Format_Type == "TXT")
            {
                Console.WriteLine(file.Status = File.state.Creating);
            }
            return file;
        }
        public new void Change(File t)
        {
            if (t.Format_Type == "TXT")
            {
                Console.WriteLine(t.Status = File.state.Changing);
            }
        }
        public new void Save(File t)
        {
            if (t.Format_Type == "TXT")
            {
                Console.WriteLine(t.Status = File.state.Saved);
            }
        }
        public new void Open(File t)
        {
            if (t.Format_Type == "TXT")
            {
                Console.WriteLine(t.Status = File.state.Opened);
            }
        }
    }
}
