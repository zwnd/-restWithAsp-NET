using restWithAspNET.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restWithAspNET.services.implematation
{
     public interface IPersonService
    {
        person Create(person person);
        person findbyId(long id);
        List<person> findAll();
        person Update(person person);
        void Delete(long id);
    }
}
