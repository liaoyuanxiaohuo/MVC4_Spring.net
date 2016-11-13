using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySpring.net
{
    /// <summary>
    /// 读取文章的数据访问接口
    /// </summary>
    public interface IReaderDAL
    {
        /// <summary>
        /// 读取文章的方法
        /// </summary>
       void GetArticle();
    }
}
