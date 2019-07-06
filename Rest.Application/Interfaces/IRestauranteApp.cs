using Rest.Domain.Ententies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Application.Interfaces
{
    interface IRestauranteApp
    {
        void Insert(Restaurante restaurante);
        void Update(int id, Restaurante restaurante);
        void Delete(Restaurante restaurante);
        Restaurante GetOne(int id);
        IEnumerable<Restaurante> GetAll();
    }
}
