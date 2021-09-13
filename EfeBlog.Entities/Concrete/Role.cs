using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Shared.Entities.Abstract;

namespace EfeBlog.Entities.Concrete
{
    public class Role:EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
