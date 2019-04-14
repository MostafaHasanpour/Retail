using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.Datas.EF.Commons
{
    public class BaseEfRepository
    {
        protected ApplicationDbContext _context;
        public BaseEfRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
