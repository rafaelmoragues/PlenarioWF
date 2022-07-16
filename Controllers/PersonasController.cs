using Microsoft.EntityFrameworkCore;
using Modelos.Data;
using SistemasPlenario.Models;

namespace Controllers
{
    public class PersonasController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        public PersonasController()
        {

        }
        public List<Persona> CargarPersonas()
        {
            return _db.Personas.ToList();
        }
        public void AgregarPersona(Persona p)
        {
            _db.Personas.Add(p);
            _db.SaveChanges();
        }
        public bool Borrar(int id)
        {

            if (ExistePersona(id))
            {
                _db.Personas.Remove(_db.Personas.Where(x => x.PersonaId == id).FirstOrDefault());
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        private bool ExistePersona(int id)
        {
            return _db.Personas.Any(x => x.PersonaId == id);
        }
        public Persona Buscar(string nombre)
        {
            Persona per = new Persona();
            per = _db.Personas.Where(x => x.Nombre == nombre).Include(y => y.Telefonos).FirstOrDefault();
            return per;
        }
    }
}