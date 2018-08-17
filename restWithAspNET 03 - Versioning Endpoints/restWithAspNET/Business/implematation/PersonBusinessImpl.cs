using System.Collections.Generic;
using restWithAspNET.model;

namespace restWithAspNET.Business.implematation
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImpl(IPersonRepository repository) {
            _repository = repository;
        }


        person IPersonBusiness.Create(person person)
        {
           return _repository.Create(person);
        }

        void IPersonBusiness.Delete(long id)
        {
            _repository.Delete(id);
        }

        List<person> IPersonBusiness.findAll()
        {
            return _repository.findAll();
        }

    
        person IPersonBusiness.findbyId(long id)
        {
            return _repository.findbyId(id);
        }

        person IPersonBusiness.Update(person person)
        {
            return _repository.Update(person);
        }
    }
}
