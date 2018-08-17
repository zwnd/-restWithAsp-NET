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


        person IPersonService.Create(person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
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

        List<person> IPersonService.findAll()
        {
            return _context.Persons.ToList();
        }

    
        person IPersonService.findbyId(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.id.Equals(id));
        }

        person IPersonService.Update(person person)
        {
            if (!Exist(person.id)) return new person();
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
