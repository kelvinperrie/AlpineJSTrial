namespace AplineTrial.Web.Models
{
	public class CustomerViewModel
	{
		public CustomerViewModel()
		{
			Addresses = [];
			Contacts = [];
		}

		public required string BusinessName { get; set; }

		public required string IndustryDescription { get; set; }

		public string? Motto { get; set; }

		public List<CustomerAddressViewModel> Addresses { get; set; }

		public List<CustomerContactsViewModel> Contacts { get; set; }
	}
}
