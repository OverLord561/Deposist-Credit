using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        User LogIn(string name, string password);

        [OperationContract]
        string RegisterUser(User user);

        [OperationContract]
        string GetInfoByUserEmail(string email);

        

    }

    [DataContract]
    public class User
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SecondName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Telephone { get; set; }

    }


    [DataContract]
    public class Deposit
    {
        [DataMember]
        public int DepositID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Partial { get; set; }
        [DataMember]
        public List<Rate> Rates { get; set; }

    }

    [DataContract]
    public class Rate
    {
        [DataMember]
        public int RateID { get; set; }
        [DataMember]
        public int DepositID { get; set; }
        [DataMember]
        public Deposit Deposit { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Percents { get; set; }
    }



}
