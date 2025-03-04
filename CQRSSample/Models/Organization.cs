namespace CQRSSample.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public OrganizationType OrganizationType { get; set; } 
        public required string Name { get; set; }
    }
    public enum OrganizationType
    {
        MainOrganization,
        SubOrganization
    }
}