using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Proxy
{
    public class CustomerRepositoryProxy : IRepository
    {
        // Atributos
        private IRepository _real;

        // Métodos
        public IList<Customer> GetAll()
        {
            if (_real == null) _real = new CustomerRepository();

            if (Session.CanGetAll)
            {
                return _real.GetAll();
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void Save(Customer customer)
        {
            if (_real == null) _real = new CustomerRepository();

            if (Session.CanSave)
            {
                _real.Save(customer);
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
