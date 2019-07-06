using Rest.Domain.Ententies;
using Rest.Domain.Interfaces.Repositorys;
using Rest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Domain.Services
{
    public class RestauranteService : IRestauranteService
    {
        private IRestauranteRepository _repository;

        public RestauranteService(IRestauranteRepository repository)
        {
            _repository = repository;
        }

        public void Insert(Restaurante restaurante)
        {
            //validar aqui
            _repository.Insert(restaurante);
        }
        public void Update(int id, Restaurante restaurante)
        {
            Restaurante model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Restaurante não encontrado");

            model.NomeRestaurante = restaurante.NomeRestaurante;
            //validar aqui

            _repository.Update(id, model);
        }

        public Restaurante GetOne(int id)
        {
            var model = _repository.GetOne(id);
            if (model == null)
                throw new Exception("Restaurante não encontrado");

            return model;
        }

        public IEnumerable<Restaurante> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(int id)
        {
            var model = _repository.GetOne(id);

            if(model == null)
            {
                throw new Exception("Restasurante não encontrado");
            }

            _repository.Delete(model);
        }
    }
}
