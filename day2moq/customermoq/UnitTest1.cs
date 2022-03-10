using NUnit.Framework;
using CustomerCommLib;
using Moq;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private CustomerComm1 _customer;
        private Mock<IMailSender> _mail;

        [SetUp]
        public void Setup()
        {
            _mail = new Mock<IMailSender>();
            _customer = new CustomerComm1(_mail.Object);
        }

        [Test]
        [TestCase("abc@gmail.com", "Hi bro")]
        [TestCase("example@gmail.com", "Message")]
        public void SendMailToCustomer_WhenCalled_SendsAMail(string email, string mssg)
        {
            _mail.Setup(fr => fr.SendMail(email, mssg)).Returns(true);

            var result = _customer.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}
