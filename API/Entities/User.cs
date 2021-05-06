using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("user")]

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("passwordhash")]
        public byte[] PasswordHash { get; set; }
         [JsonProperty("passwordsalt")]
        public byte[] PasswordSalt { get; set; }
    }
}