using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpring.net
{
    public class ReaderService : IReaderService
    {
        /// <summary>
        /// 读者名字
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// 读取文章的数据访问类对象
        /// </summary>
        private IReaderDAL dal;


        public ReaderService()
        {
            IApplicationContext context = ContextRegistry.GetContext();
            dal = (IReaderDAL)context.GetObject("readerDal");
        }

        public void GetArticle()
        {
            dal.GetArticle();
        }


    }
}
