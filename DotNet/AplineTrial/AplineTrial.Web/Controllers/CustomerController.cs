using AplineTrial.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplineTrial.Web.Controllers
{
	public class CustomerController : Controller
	{
        public List<CustomerViewModel> _customers = new List<CustomerViewModel>
                {
                    new CustomerViewModel { BusinessName = "AlleyCats Limited", IndustryDescription = "Loitering in alleys and being cool cats", Motto = "Roaming and whatever",
                        Addresses = {
                            new CustomerAddressViewModel { AddressLine1 = "22 Alfafa Street", Country = "Fiji" },
                            new CustomerAddressViewModel { AddressLine1 = "33 Ajama Road", AddressLine2="West Ajama", AddressLine3="Perth", Country = "Australia" }
                        },
                        Contacts =
                        {
                            new CustomerContactsViewModel { Name = "Top Cat" , Email = "topcat@coolcats.com"}
                        }
                    },
                    new CustomerViewModel { BusinessName = "Big Dog Co", IndustryDescription = "Barking at couriers", Motto = "",
                        Addresses = {
                            new CustomerAddressViewModel { AddressLine1 = "44 Baja Lane", AddressLine2 = "Los Angeles", AddressLine3 = "California", Country = "USA" }
                        },
                        Contacts =
                        {
                            new CustomerContactsViewModel { Name = "Big Barker" , Email = "wooooof@growls.com"},
                            new CustomerContactsViewModel { Name = "Little Fluffy" , Email = "yappy@dog.com"},
                            new CustomerContactsViewModel { Name = "Sausage Dog" , Email = "verylong@dog.com"}
                        }
                    },
                    new CustomerViewModel { BusinessName = "Canary and Sons", IndustryDescription = "Expert tweeters", Motto = "Something something bird food",
                        Addresses = {
                            new CustomerAddressViewModel { AddressLine1 = "12 Camden", AddressLine2 = "London", Country = "England" }
                        },
                        Contacts =
                        {
                            new CustomerContactsViewModel { Name = "Fritz Fluff" , Email = "big@tweet.com"}
                        }
                    },
                    new CustomerViewModel { BusinessName = "Doubtful Elk", IndustryDescription = "Just really large and doing large stuff", Motto = "We will squish you flat",
                        Addresses = {
                            new CustomerAddressViewModel { AddressLine1 = "44 Snowy place", AddressLine2 = "The wilderness", Country = "Canada" },
                            new CustomerAddressViewModel { AddressLine1 = "46 Snowy place", AddressLine2 = "The wilderness", Country = "Canada" }
                        },
                        Contacts =
                        {
                            new CustomerContactsViewModel { Name = "Big Horns" , Email = "elkguy@somewhere.co.nz"}
                        }
                    }
                };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerData()
		{
            Random r = new Random();
            int takeCount = r.Next(1, _customers.Count +1);

            var customersToReturn = _customers.Take(takeCount).ToList();

            var model = new CustomerPageViewModel
            {
                Customers = customersToReturn
            };
            return Json(model);
        }
	}
}
