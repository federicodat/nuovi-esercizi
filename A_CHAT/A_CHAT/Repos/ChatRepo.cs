using A_CHAT.Context;
using A_CHAT.Models;

namespace A_CHAT.Repos
{
    public class ChatRepo : IRepoLettura<Chat>, IRepoScrittura<Chat>
    {
        private readonly ChatContext _context;
        private readonly ILogger<UtenteRepo> _logger;

        public ChatRepo(ChatContext context, ILogger<UtenteRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

      

        private static ChatRepo? instance;

        public static ChatRepo GetInstance()
        {
            if (instance == null)
                instance = new ChatRepo();

            return instance;

            
        }
        private ChatRepo() { }


        //internal static object GetInstance()
        //{
        //    throw new NotImplementedException();
        //}

        public bool Create(Chat t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Chat? Get(int id)
        {
            throw new NotImplementedException();
        }

       

        public IEnumerable<Chat> GetAll()
        {
            return _context.Chats.ToList();
        }
        public bool Insert(Chat t)
        {
            bool risultato = false;

           
            {
                try
                {
                    _context.Chats.Add(t);
                    _context.SaveChanges();

                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato;
        }

        public bool Update(Chat t)
        {
            throw new NotImplementedException();
        }
    }
}
