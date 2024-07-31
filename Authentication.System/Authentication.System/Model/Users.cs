namespace Authentication.System.Model
{
    public class Users
    {
        public Users(Guid id, string name, string password, string token)
        {
            Id = id;
            Name = name;
            Password = password;
            Token = token;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
