using DemoAPI.Model;

namespace DemoAPI.Model.Interfaces
{
    public interface IRepositoryDipendenti
    {
        public List<Dipendenti> GetAll();

        public Dipendenti GetById(int id);

        public Dipendenti Add(Dipendenti dipendenti);

        public Dipendenti Update(Dipendenti dipendenti);
        public Dipendenti Remove(int id);
    }
}
