using HelloWorld.Model;
using HelloWorld.Repository.Contracts;
using HelloWorld.Repository.Implementations;
using HelloWorld.Service.Contracts;
using HelloWorld.Service.Implementations;
using HelloWorldAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldTest
{
    [TestClass]
    public class TestHelloWorldController
    {
        private IMessageRepository messageRepository = new MessageRepository();
        private IMessageService messageService;

        public TestHelloWorldController() { 
            messageService = new MessageService(messageRepository);
        }


        /// <summary>
        /// This method tests the GetMessage(int id) of the HelloWorldController
        /// </summary>
        [TestMethod]
        public void GetMessage_ShouldReturnHelloWorld()
        {
            var controller = Create();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var test = GetTestHelloWorld();
            var result = controller.GetMessage(1);

            result.TryGetContentValue<string>(out string msg);
            Assert.AreEqual(test.Message, msg);
        }

        /// <summary>
        /// This method returns an empty string if GetMessage is passed with input that is not (1)
        /// </summary>
        [TestMethod]
        public void GetMessage_ShouldReturnEmpty()
        {
            var controller = Create();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var result = controller.GetMessage(5); 

            result.TryGetContentValue<string>(out string msg);
            Assert.AreEqual(string.Empty, msg);
        }

        /// <summary>
        /// Unit Test Method to return single object for HelloWorld class
        /// </summary>
        private HelloMessage GetTestHelloWorld()
        {
            var testHelloWorld = new HelloMessage() { Id = 1, Message = "Hello World" };
            return testHelloWorld;
        }

        /// <summary>
        /// Method to create and return the instace of controller
        /// </summary>
        private HelloWorldController Create() {
            return new HelloWorldController(messageService);
        }
    }
}
