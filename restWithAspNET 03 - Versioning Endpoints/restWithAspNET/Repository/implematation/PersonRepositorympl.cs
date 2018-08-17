using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using restWithAspNET.model;
using restWithAspNET.model.Context;

namespace restWithAspNET.Business.implematation
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private MYSQLContext _context;

        public PersonRepositoryImpl(MYSQLContext context) {
            _context = context;
        }


        public person Create(person person)
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

        public void Delete(long id)
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

        public List<person> findAll()
        {
            return _context.Persons.ToList();
        }

    
        public person findbyId(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.id.Equals(id));
        }

        public person Update(person person)
        {
            if (!Exists(person.id)) return new person();
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

        public bool Exists(long? id)
        {
            return _context.Persons.Any((p => p.id.Equals(id)));
        }
    }
}
