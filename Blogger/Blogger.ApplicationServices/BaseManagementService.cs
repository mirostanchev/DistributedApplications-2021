using Blogger.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices
{
    public abstract class BaseManagementService
    {
        protected readonly BloggerDbContext context;

        public BaseManagementService()
        {
            this.context = new BloggerDbContext();
        }
    }
}
