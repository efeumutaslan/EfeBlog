using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Entities.Concrete;
using EfeBlog.Shared.Data.Abstract;

namespace EfeBlog.Data.Abstract
{
    public interface ICommentRepository:IEntityRepository<Comment>
    {
    }
}
