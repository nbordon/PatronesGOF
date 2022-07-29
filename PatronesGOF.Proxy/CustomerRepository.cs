using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Proxy
{
    public class CustomerRepository : IRepository
    {
        // Atributos
        IList<Customer> _customers;

        // Constructores
        public CustomerRepository()
        {
            _customers = new List<Customer>();
        }

        //Métodos
        public IList<Customer> GetAll()
        {
            return _customers;
        }

        public void Save(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
