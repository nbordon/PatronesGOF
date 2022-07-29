using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesGOF.Proxy
{
    public interface IRepository
    {
        IList<Customer> GetAll();
        void Save(Customer customer);
    }
}
