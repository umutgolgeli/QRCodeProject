using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ContactDto
{
    public class CreateContactDto
    {
       
        public int Location { get; set; }
        public int Phone { get; set; }
        public int Mail { get; set; }
        public int FooterDescription { get; set; }
    }
}
