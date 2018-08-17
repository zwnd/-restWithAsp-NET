using restWithAspNET.model;
using System.Collections.Generic;

namespace restWithAspNET.Business
{
    public interface IPersonBusiness
    {
        person Create(person person);
        person findbyId(long id);
        List<person> findAll();
        person Update(person person);
        void Delete(long id);
    }
}
