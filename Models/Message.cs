using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Messager.Models
{
    public class Message
    {
        public int id { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Recepient { get; set; }
        [DataType(DataType.Date)]
        public DateTime MsgDate { get; set; }
    }
}
