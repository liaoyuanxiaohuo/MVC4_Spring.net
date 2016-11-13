using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpring.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dddd");

            IReaderService service = new ReaderService();
            service.GetArticle();
        }
    }
}
