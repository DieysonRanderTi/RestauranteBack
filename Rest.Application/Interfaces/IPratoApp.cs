using Rest.Domain.Ententies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Application.Interfaces
{
    public interface IPratoApp
    {
        void Insert(Prato prato);
        void Update(int id, Prato prato);
        Prato GetOne(int idPrato);
        IEnumerable<Prato> GetAll();
        void Delete(Prato prato);
    }
}
