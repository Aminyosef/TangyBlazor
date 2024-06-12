using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models
{
    public class SuccessModelDTO
    {
        public string Title { get; set; }
        public string StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public object Data {  get; set; }
    }
}
