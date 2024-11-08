namespace A_CHAT.Services
{
   
        public interface IServiceLettura<T>
        {
            IEnumerable<T> List();
            T? Details(int id);
        }
    }
 

