using A_CHAT.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace A_CHAT.Context
{
    public class ChatContext : DbContext
     
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options) { }

        public DbSet<Amministratore> Amministratori { get; set; }
        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Chat> Chats { get; set; }
        //public DbSet<Iscrizione> Iscrizioni { get; set; }
    }
}