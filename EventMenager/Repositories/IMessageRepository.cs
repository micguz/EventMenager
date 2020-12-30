using EventMenager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Repositories
{
    public interface IMessageRepository
    {
        MessageModel get(int messageId);
        IQueryable<MessageModel> GetAll();
        void AddMessage(MessageModel message);
    }
}
