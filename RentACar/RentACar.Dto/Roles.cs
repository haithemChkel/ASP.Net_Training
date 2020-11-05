using PetaPoco;

namespace RentACar.Dto
{
    [TableName("AspNetRoles")]
    [PrimaryKey("Id")]
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
