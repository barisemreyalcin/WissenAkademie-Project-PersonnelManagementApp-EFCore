using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personnel.EFCore.DAL;
using PersonnelDomain = Personnel.EFCore.Domain; 


namespace Personnel.EFCore.BAL
{
    public class PersonnelOperations
    {
        private readonly AppDbContext _dbContext;

        public PersonnelOperations()
        {
            _dbContext = new AppDbContext();
        }

        public List<PersonnelDomain.Personnel> GetPersonnels()
        {
            var personnels = _dbContext.Personnels.Include(p => p.PersonnelDetail).ToList(); // PersonnelDetails de gelsin diye
            return _dbContext.Personnels.ToList();
        }

        public PersonnelDomain.Personnel GetPersonnelById(int id)
        {
            return _dbContext.Personnels.Find(id);
        }

        public PersonnelDomain.Personnel CreatePersonnel(PersonnelDomain.Personnel personnel)
        {
            _dbContext.Personnels.Add(personnel);
            _dbContext.SaveChanges();
            return personnel;
        }

        public PersonnelDomain.Personnel GetPersonnelWithDetails(int id)
        {
            return _dbContext.Personnels.Include(p => p.PersonnelDetail).FirstOrDefault(p => p.PersonnelID == id);
        }


        public PersonnelDomain.Personnel UpdatePersonnel(PersonnelDomain.Personnel personnel)
        {
            _dbContext.Personnels.Attach(personnel);
            _dbContext.Entry(personnel).State = EntityState.Modified;

            if (personnel.PersonnelDetail != null)
            {
                _dbContext.Entry(personnel.PersonnelDetail).State = EntityState.Modified; 
            }

            _dbContext.SaveChanges();
            return personnel;
        }
        public void DeletePersonnel(int id)
        {
            var personnel = _dbContext.Personnels.Find(id);
            if (personnel != null)
            {
                _dbContext.Personnels.Remove(personnel);
                _dbContext.SaveChanges();
            }
        }
    }
}
