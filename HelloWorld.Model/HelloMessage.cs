using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class HelloMessage
    {
        public HelloMessage() { }

        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
