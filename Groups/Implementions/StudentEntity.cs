namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public StudentEntity(int id, string name, string email) : base(id, name, email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}