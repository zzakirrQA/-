using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВВедениеООП.Options;

namespace ВВедениеООП
{
    public class Message
    {
        public string Text { get; set; }
        public string SenderName { get; set; }
        public string SenderType { get; set; }

        public MessageType MessageType { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Message message &&
                   Text == message.Text &&
                   SenderName == message.SenderName &&
                   SenderType == message.SenderType &&
                   MessageType == message.MessageType;
        }

        public override string ToString()
        {
            return $"{SenderType} {SenderName}: {MessageType} {Text}";
        }
    }
}
