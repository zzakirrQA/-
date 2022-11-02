using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП
{
    public class MultipleMessage
    {
        public List<string> Texts  { get; set; } 
        public string Name { get; set; }
        public MessageType MessageType { get; set; }

    }
}
