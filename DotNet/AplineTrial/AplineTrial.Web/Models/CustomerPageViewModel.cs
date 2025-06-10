namespace AplineTrial.Web.Models
{
	public class CustomerPageViewModel
	{
		public CustomerPageViewModel()
		{
			Customers = [];
		}

		public List<CustomerViewModel> Customers { get; set; }
	}
}
