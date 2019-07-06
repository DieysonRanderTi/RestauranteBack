using Rest.Domain.Ententies;
using Rest.Domain.Interfaces.Repositorys;
using Rest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rest.Domain.Services
{
    public class PratoService : IPratoService
    {
        private readonly IPratoRepository _repository;

        public void Insert(Prato prato)
        {
            //validar aqui
            _repository.Insert(prato);
        }

        public void Update(int id, Prato prato)
        {
            Prato model = _repository.GetOne(id);
            if (model == null)
            {
                throw new Exception("Prato não encontrado");

            }
            model.NomePrato = prato.NomePrato;
            model.PrecoPrato = prato.PrecoPrato;
            model.IdRestaurante = prato.IdRestaurante;
            //validar aqui

            _repository.Update(id, model);
        }

        public Prato GetOne(int id)
        {
            var model = _repository.GetOne(id);

            if(model == null)
            throw new Exception("Prato não encontrado");

            return model;
        }

        public IEnumerable<Prato> GetAll()
        {
            return _repository.GetAll();
        }

        public void Delete(int id)
        {
            var model = _repository.GetOne(id);

            if (model == null)
            {
                throw new Exception("Prato não encontrado");
            }

            _repository.Delete(model);
        }
    }
 }

