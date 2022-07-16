using Modelos.Data;
using SistemasPlenario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class TelefonosController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public TelefonosController()
        {

        }
        public List<Telefono> CargarTel(int id)
        {
            return _db.Telefonos.Where(x => x.PersonaId == id).ToList();
        }
        public void GuardarTel(Telefono tel)
        {
            _db.Telefonos.Add(tel);
            _db.SaveChanges();
        }
        public bool EliminiarTel(int id)
        {
            var aux = _db.Telefonos.Find(id);
            if (aux != null)
            {
                _db.Telefonos.Remove(_db.Telefonos.Where(x => x.TelefonoId == id).FirstOrDefault());
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        public Telefono GetTel(int id)
        {
            return _db.Telefonos.Where(x => x.TelefonoId == id).FirstOrDefault();
        }
        public void update(Telefono tel)
        {
            _db.Telefonos.Update(tel);
            _db.SaveChanges();
        }
    }
}
