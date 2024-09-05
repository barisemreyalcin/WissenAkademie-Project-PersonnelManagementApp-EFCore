using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.EFCore.Domain
{
    public  class PersonnelDetail
    {
        public int PersonnelDetailID { get; set; }

        // Referans olacak alan
        public int PersonnelID { get; set; }

        // Class'ı temsil edecek kısım (Birebir ilişkiyi sağlayacak kısım)
        public Personnel Personnel { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
