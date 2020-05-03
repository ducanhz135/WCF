using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCateogory" in both code and config file together.
    [ServiceContract]
    public interface IServiceCateogory
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<User> FindAll();

        [OperationContract]
        User Find(int userCd);

        [OperationContract]
        bool Insert(string userName);

        [OperationContract]
        bool Update(int userCd);

        [OperationContract]
        bool Delete(int userCd);
    }
}
