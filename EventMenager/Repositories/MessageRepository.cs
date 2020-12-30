using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventMenager.Models;

namespace EventMenager.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly EventMenagerContext _context;
        public MessageRepository(EventMenagerContext context)
        {
            _context = context;
        }

        public void AddMessage(MessageModel message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
        }

        public MessageModel get(int messageId)
        => _context.Messages.FirstOrDefault(s => s.MessageId == messageId);

        public IQueryable<MessageModel> GetAll()
        => _context.Messages.Where(s => s.MessageId !=null);
    }
}
