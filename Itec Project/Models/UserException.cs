using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itec_Project.Models
{
    public class UserException:Exception
    {
        public UserException(string message) : base(message) { }
    }
}
