namespace CQRSSample.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}