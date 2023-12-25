using System.Text.Json.Serialization;

namespace Hospital.Models.Common
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountType
    {
        Admin = 1,
        Patient = 2
    }
}
