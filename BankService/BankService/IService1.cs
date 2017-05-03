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
        List<Deposit> GetAllDeposits();
        [OperationContract]
         List<Rate> GetAllDepositsRates();

        [OperationContract]
        List<UserCalculator> GetInfoByUserEmail(string email);

       [OperationContract]
        List<string> GetEmailsByOperationType(string operationType);

        [OperationContract]
        List<Credit> GetAllCredits(string operationType);



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
        [DataMember]
        public List<UserCalculator> UserCalculations {get;set;}

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
    public class Credit
    {
        [DataMember]
        public int CreditID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Link { get; set; }
     

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




    [DataContract]
    public class UserCalculator
    {
        [DataMember]
        public int UserCalculatorID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string OperationName { get; set; }
        [DataMember]
        public DateTime Date { get; set; }       

        [DataMember]
        public User User { get; set; }
       
    }



}
