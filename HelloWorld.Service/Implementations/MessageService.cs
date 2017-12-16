using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Model;
using HelloWorld.Service.Contracts;
using HelloWorld.Repository.Contracts;
using HelloWorld.Repository.Implementations;

namespace HelloWorld.Service.Implementations
{
    public class MessageService : IMessageService
    {
        IMessageRepository _messageRepository;
        public MessageService() { }

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public HelloMessage GetMessage(int id)
        {
           return _messageRepository.GetMessage(id);
        }

        public int NewMessage(HelloMessage message)
        {
            return _messageRepository.NewMessage(message);            
        }

        public bool UpdateMessage(int Id)
        {
            return _messageRepository.UpdateMessage(Id);
        }
        
        public bool DeleteMessage(int Id)
        {
            return _messageRepository.DeleteMessage(Id);
        }
    }
}
