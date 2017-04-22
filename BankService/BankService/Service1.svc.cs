﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankService
{
    public class Service1 : IService1
    {
        public BankContext db = new BankContext();

       

        public string GetInfoByUserEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User LogIn(string email, string password)
        {
            User _user = db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
           
            #region Deposits
            //Deposit d1 = new Deposit
            //{
            //    Name = "Депозит Плюс срочный",
            //    Description = "самая выгодная процентная ставка,проценты ежемесячно,при этом часть процентов зачисляется на счет «Бонус Плюс»; возможность пополнять счет;возврат по окончании срока",
            //    Partial = "Нет",
            //    Type = "Ежемесячно"
            //};

            //Deposit d2 = new Deposit
            //{
            //    Name = "Депозит Плюс",
            //    Description = "проценты ежемесячно, при этом часть процентов зачисляется на счет «Бонус Плюс»;возможность пополнять счет",
            //    Partial = "Нет",
            //    Type = "Ежемесячно"
            //};
            //Deposit d3 = new Deposit
            //{
            //    Name = "Стандарт срочный",
            //    Description = "проценты ежемесячно;возможность пополнять счет;возврат по окончании срока",
            //    Partial = "Нет",
            //    Type = "Ежемесячно"
            //};
            //Deposit d4 = new Deposit
            //{
            //    Name = "Стандарт",
            //    Description = "проценты ежемесячно; возможность пополнять счет",
            //    Partial = "Нет",
            //    Type = "Ежемесячно"
            //};

            //db.Deposits.Add(d1);
            //db.Deposits.Add(d2);
            //db.Deposits.Add(d3);
            //db.Deposits.Add(d4);
            //db.SaveChanges();
            #endregion
            #region DepoRates
            //Rate r1 = new Rate { DepositID = 1, Name = "12 мес", Percents = 18 };
            //Rate r2 = new Rate { DepositID = 1, Name = "6 мес", Percents = 17 };
            //Rate r3 = new Rate { DepositID = 1, Name = "3 мес", Percents = 16 };

            //Rate r4 = new Rate { DepositID = 2, Name = "12 мес", Percents = 15 };
            //Rate r5 = new Rate { DepositID = 2, Name = "6 мес", Percents = 14 };
            //Rate r6 = new Rate { DepositID = 2, Name = "3 мес", Percents = 13 };

            //Rate r7 = new Rate { DepositID = 3, Name = "12 мес", Percents = 18 };
            //Rate r8 = new Rate { DepositID = 3, Name = "6 мес", Percents = 17};
            //Rate r9 = new Rate { DepositID = 3, Name = "3 мес", Percents = 16 };

            //Rate r10 = new Rate { DepositID = 4, Name = "12 мес", Percents = 15 };
            //Rate r11 = new Rate { DepositID = 4, Name = "6 мес", Percents = 14 };
            //Rate r12 = new Rate { DepositID = 4, Name = "3 мес", Percents = 13 };
            //Rate r13 = new Rate { DepositID = 4, Name = "1 мес", Percents = 12 };

            //db.Rates.Add(r1);
            //db.Rates.Add(r2);
            //db.Rates.Add(r3);
            //db.Rates.Add(r4);
            //db.Rates.Add(r5);
            //db.Rates.Add(r6);
            //db.Rates.Add(r7);
            //db.Rates.Add(r8);
            //db.Rates.Add(r9);
            //db.Rates.Add(r10);
            //db.Rates.Add(r11);
            //db.Rates.Add(r12);
            //db.Rates.Add(r13);
            //db.SaveChanges();

            #endregion

            return _user;
        }

        public string RegisterUser(User user)
        {
            User regUser = db.Users.FirstOrDefault(x => x.Email.ToUpper() == user.Email.ToUpper());
            if (regUser != null)
            {
                return "";
            }
            else
            {


                try
                {
                    // user = Manager.DecryptUser(user);
                    db.Users.Add(user);
                    db.SaveChanges();
                    return user.Name;
                }
                catch
                {
                    return "";
                }

            }


        }

        
    }
}
