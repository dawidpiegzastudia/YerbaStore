using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YerbaFrontEnd.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
        public string DisplayMessege { get; set; }
        public List<string> ErrorMessege { get; set; }
    }
}
