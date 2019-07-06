using Rest.Domain.Ententies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Domain.Interfaces.Services
{
    public interface IPratoService
    {
        void Insert(Prato prato);
        void Update(int id, Prato prato);
        Prato GetOne(int id);
        void Delete(int id);
        IEnumerable<Prato> GetAll();
    }
}
