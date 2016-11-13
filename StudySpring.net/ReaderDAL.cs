using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpring.net
{
    public class ReaderDAL : IReaderDAL
    {
        public string Title { get; set; }

        public string UserName { get; set; }

        public void GetArticle()
        {
            Console.WriteLine( UserName +"读取文章:" + Title);
        }
    }
}
