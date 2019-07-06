using Rest.Domain.Ententies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Domain.Interfaces.Services
{
    public interface IRestauranteService
    {
        void Insert(Restaurante restaurante);
        void Update(int id, Restaurante restaurante);
        Restaurante GetOne(int id);
        void Delete(int id);
        IEnumerable<Restaurante> GetAll();
    }
}
