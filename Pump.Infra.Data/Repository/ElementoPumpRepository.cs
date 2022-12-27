using Pump.Domain.Entity;
using Pump.Domain.Interfaces;

namespace Pump.Infra.Data.Repository
{
    internal class ElementoPumpRepository : IRepository
    {
        protected readonly ElementoPumpDBContext _db;

        public ElementoPumpRepository(ElementoPumpDBContext db)
        {
            _db = db;
        }

        public bool DeleteElemento(ElementoPumpEntity model)
        {
            _db.Elemento.Remove(model);
            return _db.SaveChanges() > 0;
        }

        public bool DeleteElemento(int id)
        {
            var elementoDeletar = _db.Elemento.SingleOrDefault(x => x.Id == id);
            if(elementoDeletar != null)
            {
                return DeleteElemento(elementoDeletar);
            }
            return false;
        }

        public virtual ElementoPumpEntity? GetElementoId(int id)
        {
            var elementoRetorna = _db.Elemento.SingleOrDefault(x => x.Id == id);
            return elementoRetorna;
        }

        public bool InsertElemento(ElementoPumpEntity model)
        {
            _db.Add(model);
            return _db.SaveChanges() > 0;
        }

        public bool UpdateElemento(ElementoPumpEntity model)
        {
            _db.Elemento.Update(model);

            return _db.SaveChanges() > 0;
        }
    }
}