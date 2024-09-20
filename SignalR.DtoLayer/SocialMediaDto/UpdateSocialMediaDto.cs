using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaID { get; set; }

        public int Title { get; set; }
        public int Url { get; set; }
        public int Icon { get; set; }
    }
}
