using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel.EFCore.Domain
{
    public class Personnel
    {
        public int PersonnelID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool Gender { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
        public string FullName => $"{FirstName} {LastName}"; // Db'ye yansımayacak

        // Bire bir ilişki
        public PersonnelDetail PersonnelDetail { get; set; }

    }
}   
