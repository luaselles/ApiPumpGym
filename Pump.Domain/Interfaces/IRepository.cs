using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pump.Domain.Entity;

namespace Pump.Domain.Interfaces
{
    public interface IRepository
    {
        // List<ElementoPumpEntity> GetElementos();
        ElementoPumpEntity? GetElementoId(int id);
        Boolean InsertElemento(ElementoPumpEntity model);
        Boolean DeleteElemento(ElementoPumpEntity model);
        Boolean DeleteElemento(int id);
        Boolean UpdateElemento(ElementoPumpEntity model);
    }
}