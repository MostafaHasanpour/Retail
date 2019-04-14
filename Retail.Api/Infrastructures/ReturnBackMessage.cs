using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retail.Api.Infrastructures
{
    public class ReturnBackMessage
    {
        public ReturnBackMessage(string message)
        {
            this.Message = message;
        }
        public string Message { get; set; }
    }
}
