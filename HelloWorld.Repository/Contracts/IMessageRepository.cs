using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Repository.Contracts
{
    public interface IMessageRepository
    {
        int NewMessage(HelloMessage message);

        HelloMessage GetMessage(int id);

        bool UpdateMessage(int Id);
        bool DeleteMessage(int Id);
    }
}
