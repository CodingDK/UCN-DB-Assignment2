using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;
using DAL;

namespace BLL {
    public class CustomerBLL {
        private IFDALEntity<Customer> dal = new CustomerDAL();

        public List<Customer> GetAll() {
            throw new NotImplementedException();
        }

        public Customer GetById(string id) {
            throw new NotImplementedException();
        }

        public void Create(Customer customer) {
            throw new NotImplementedException();
        }

        public void Edit(Customer customer) {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer) {
            throw new NotImplementedException();
        }
    }
}
