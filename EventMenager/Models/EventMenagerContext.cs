using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMenager.Models
{
    public class EventMenagerContext : DbContext
    {
        public EventMenagerContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<MessageModel> Messages { get; set; }
    }
}
