using restWithAspNET.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restWithAspNET.services.implematation
{
     public interface IPersonService
    {
        persona Create(persona persona);
        persona findbyId(long id);
        List<persona> findAll();
        persona Update(persona persona);
        void Delete(long id);
    }
}
