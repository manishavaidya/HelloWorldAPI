using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Model;
using HelloWorld.Repository.Contracts;

namespace HelloWorld.Repository.Implementations
{
    public class MessageRepository : IMessageRepository
    {
        public MessageRepository() { }

        

        /// <summary>
        /// Input 1: Returns "Hello World"
        /// Any other input : Returns an empty message
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HelloMessage GetMessage(int id)
        {
            try
            {
                var message = new HelloMessage() {
                    Id = 1,
                    Message = "Hello World"
                };
                return (id == 1) ? message: new HelloMessage();
            }
            catch (Exception ex){ throw new Exception(ex.Message); }
        }


        public int NewMessage(HelloMessage message)
        {
            //To implement adding a new message to the DB
            //throw new NotImplementedException();
            return message.Id;
        }

        public bool UpdateMessage(int Id)
        {
            //To Implement updating to DB and return true/false on update
            return true;
        }

        public bool DeleteMessage(int Id)
        {
            //To Implement deleting message from DB and return true/false on update
            return true;
        }
    }
}
