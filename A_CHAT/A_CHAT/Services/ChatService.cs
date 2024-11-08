using A_CHAT.Models;
using A_CHAT.Repos;
using System.Security.Cryptography;

namespace A_CHAT.Services
{
    public class ChatService :   IServiceLettura<Chat> , IServiceLettura<Utente>
    {  
        private readonly ChatRepo _repo;
        private readonly UtenteService _utenteService; // Aggiungi UtenteService
        //public ChatService(ChatRepo repo)
        //{
        //    _repo = repo;
        //}

       public ChatService(ChatRepo repo, UtenteService utenteService) // Iniettato qui
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        _utenteService = utenteService ?? throw new ArgumentNullException(nameof(utenteService));
    }
        public Chat? Details(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chat> List()
        {
            return _repo.GetAll();
        }

        public int idu = 0;
        string utento = "prova";
        public IEnumerable<ChatDTO> Lista()
        {

            List<ChatDTO> chatDTOs = new List<ChatDTO>();

         

            List<Chat> elenco = _repo.GetAll().ToList();
            foreach (Chat mes in elenco)
            {
                //idu = mes.UtenteRif;
                UtenteDTO? risultato = null;
                  risultato = _utenteService.CercaUPerId(mes.UtenteRif);
                

                ChatDTO chattemp = new ChatDTO()
                {
                    // Cerca l'utente associato tramite l'ID
                    
                

                    cod = mes.Codice,
                    mess = mes.Messaggio,
                    datm = mes.DatMes,                   
                    ute= risultato.usern




                }; 


                chatDTOs.Add(chattemp);
            }
            return chatDTOs;



        }

        IEnumerable<Utente> IServiceLettura<Utente>.List()
        {
            throw new NotImplementedException();
        }

        Utente? IServiceLettura<Utente>.Details(int id)
        {
            throw new NotImplementedException();
        }

        public bool InserisciMess(ChatDTO chDto)
        {

            Chat ms = new Chat()
            {
                Messaggio = chDto.mess,
                Codice = chDto.cod is not null ? chDto.cod : Guid.NewGuid().ToString(),
                 UtenteRif = 95
            };

            return ChatRepo.GetInstance().Insert(ms);

        }

        internal static object GetInstance()
        {
            throw new NotImplementedException();
        }
    }
}
