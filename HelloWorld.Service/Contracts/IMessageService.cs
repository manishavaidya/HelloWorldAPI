using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Model;

namespace HelloWorld.Service.Contracts
{
    public interface IMessageService
    {
        int NewMessage(HelloMessage message);

        HelloMessage GetMessage(int id);

        bool UpdateMessage(int Id);
        bool DeleteMessage(int Id);
    }
}
