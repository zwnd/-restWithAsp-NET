using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using restWithAspNET.model;
using restWithAspNET.model.Context;

namespace restWithAspNET.services.implematation
{
    public class PersonServiceImpl : IPersonService
    {
        private MYSQLContext _context;

        public PersonServiceImpl(MYSQLContext context) {
            _context = context;
        }


        persona IPersonService.Create(persona persona)
        {
            try
            {
                _context.Add(persona);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return persona;
        }

        void IPersonService.Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.id.Equals(id));
            try
            {
                if(result !=null) _context.Persons.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        List<persona> IPersonService.findAll()
        {
            return _context.Persons.ToList();
        }

    
        persona IPersonService.findbyId(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.id.Equals(id));
        }

        persona IPersonService.Update(persona person)
        {
            if (!Exist(person.id)) return new persona();
            var result = _context.Persons.SingleOrDefault(p => p.id.Equals(person.id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        private bool Exist(long? id)
        {
            return _context.Persons.Any((p => p.id.Equals(id)));
        }
    }
}
