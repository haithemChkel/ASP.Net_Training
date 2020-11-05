using PetaPoco;

namespace RentACar.Dto
{
    [TableName("AspNetUsers")]
    [PrimaryKey("Id")]
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
