using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManager.Models
{
    public class CEO
    {
        public string Name { get; set; }
        public PictureBox Image { get; set; }
        public string Ngaysinh { get; set; }
        public string Quequan { get; set; }

        public CEO(string name, PictureBox image, string ngaysinh, string quequan)
        {
            Name = name;
            Image = image;
            Ngaysinh = ngaysinh;
            Quequan = quequan;
        }

        public CEO() { } // constructor rỗng phòng trường hợp cần
    }
}

