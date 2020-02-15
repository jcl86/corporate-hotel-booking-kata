namespace CorporateHotel.Domain
{
    public class Company
    {
        private readonly string name;
        public CompanyId Id { get; }

        public Company(string name)
        {
            Id = new CompanyId();
            this.name = name;
        }

        public override string ToString() => name;
    }
}
