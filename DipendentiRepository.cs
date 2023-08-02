using DemoAPI.Model;

namespace DemoAPI.Model
{
    public class DipendentiRepository
    {
        private ApplicationDbcontext dbcontext;

        public DipendentiRepository (ApplicationDbcontext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public List<Dipendenti> GetAll()
        {
            return dbcontext.Dipendenti.ToList();
        }

        public Dipendenti GetById(int id)
        {
            return dbcontext.Dipendenti.Where(c => c.Id == id).SingleOrDefault();
        }

        public Dipendenti Add(Dipendenti dipendenti)
        {
            var result = dbcontext.Dipendenti.Add(dipendenti);
            dbcontext.SaveChanges();
            return result.Entity;
        }

        public Dipendenti Update(Dipendenti dipendenti)
        {
            var result = dbcontext.Dipendenti.Update(dipendenti);
            dbcontext.SaveChanges();
            return result.Entity;
        }

        public Dipendenti Remove(int id)
        {
            var result = dbcontext.Dipendenti.Remove(GetById(id));
            dbcontext.SaveChanges();
            return result.Entity;
        }
    }
}
