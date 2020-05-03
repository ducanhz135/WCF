using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCateogory" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCateogory.svc or ServiceCateogory.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCateogory : IServiceCateogory
    {
        public bool Delete(int userCd)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public User Find(int userCd)
        {
            throw new NotImplementedException();
        }

        public List<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(string userName)
        {
            throw new NotImplementedException();
        }

        public bool Update(int userCd)
        {
            throw new NotImplementedException();
        }
    }
}
