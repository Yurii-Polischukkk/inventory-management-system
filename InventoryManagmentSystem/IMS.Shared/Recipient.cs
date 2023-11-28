using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Shared
{
    public class Recipient
    {
        public int RecipientId { get; set; }
        [Required]
        public string? RecipientName { get; set; }

        public List<Tools> Tools { get; set; }
    }
}
