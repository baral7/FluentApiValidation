namespace FluentApiValidation.Model
{
    public class Address
    {
        public string AddressName {  get; set; }
        public ICollection<TemproraryAddress> Temprants { get; set; } = new List<TemproraryAddress>();
    }
    public class TemproraryAddress
    {
        public string TemproraryAddressName { get; set; }
    }
}
