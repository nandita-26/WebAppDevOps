using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm1
    {
        IMailSender _mailSender;

        public CustomerComm1()
        {
        }

        public CustomerComm1(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            //Actual logic goes here

            //define message and mail address

            _mailSender.SendMail("cust123@abc.com", "Some Message");

            return true;
        }
    }

}
