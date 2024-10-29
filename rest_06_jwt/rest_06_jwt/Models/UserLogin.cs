using System.Text.Json.Serialization;

namespace rest_06_jwt.Models
{
    public class UserLogin
    {
       
        public string?  Username { get; set; }
        public string?  Password { get; set; }
        [JsonIgnore]
        public string?  UserType { get; set; }   //tipo admin o user
      
    }
}
