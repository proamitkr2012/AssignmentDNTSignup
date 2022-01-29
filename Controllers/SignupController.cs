using AssignmentDNTSignup.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using NuGet.Packaging;

using static AssignmentDNTSignup.Models.Signup;

namespace AssignmentDNTSignup.Controllers
{
	public class SignupController : Controller
	{
		public IActionResult Signup()
		{
			//List<string> Countries = new List<string>() { "India", "Pakistan","Afganistan" };
			//@(new SelectList(@ViewBag.ListofCountry, "ID", "Name"))">  
		//List<SelectListItem> Countries  = new List<SelectListItem>
		//	{
		//	 new SelectListItem {Value = "Please select", Text = "Please select" },
		//	new SelectListItem { Value = "IN", Text = "India" },
		//		new SelectListItem { Value = "CA", Text = "Canada" },
		//		new SelectListItem { Value = "US", Text = "USA"  },
		//	};

		

			List<CountryList> objcountrymodel = new List<CountryList>();
			objcountrymodel = GetAllCountry();
			ViewBag.Countries = objcountrymodel;

			List<CityList> objcitymodel = new List<CityList>();
			objcitymodel = GetAllCity();
			ViewBag.City = objcitymodel;

			//foreach (var item in Countries)
			//{
			//	List<string> City = new List<string>();

			//	//List<string> IndiacityList = new List<string>() { "Pune", "Mumbai", "Nashik" };
			//	//List<string> CanadaCityList = new List<string>() {"ff","gg","hh" };

			//	if(item.Text == "India")
			//	{

			// 		    List<SelectListItem> IndiacityList = new List<SelectListItem>
			//    {
			//		new SelectListItem { Value = "",Text = "Please select one"},
			//	new SelectListItem { Value = "PU", Text = "Pune" },
			//	new SelectListItem { Value = "Mu", Text = "Mumbai" },
			//	new SelectListItem { Value = "Na", Text = "Nashik"  },
			//    };
			//		//City.Add(IndiacityList);


			//	}

			//	if (item.Text == "Canada")
			//	{
			//   	List<SelectListItem> CanadaCityList = new List<SelectListItem>
			//	{
			//	new SelectListItem { Value = "PU", Text = "ff" },
			//	new SelectListItem { Value = "Mu", Text = "gg" },
			//	new SelectListItem { Value = "Na", Text = "hh"  },
			//	};
			//	}
			//	if (item.Text == "Please select one")
			//	{

			//	//	City.AddRange(city);
			//	}

			//	ViewBag.City = City;
			//}
			return View();
		}


		[HttpPost]
		public JsonResult GetCityByStateId(int stateid)
		{
			//List<CityList> objcity = new List<CityList>();
			//objcity = GetAllCity().Where(m => m.StateId == stateid).ToList();
			//return Json(obgcity.Select(CityList => new SelectListItem() { Text = role.RoleName, Value = role.Id.ToString() }),
		//	return Json(objcity.Select(CityList => new SelectListItem() { Text = CityList.CityName,Value = CityList.StateId.ToString()}));
		//	SelectList obgcity = new SelectList(objcity, "Id", "CityName", 0);
			//TempData.Json(objcity);
		//	ViewBag.Json(obgcity);
			//return Json(obgcity);

			List<SelectListItem> objcity = new List<SelectListItem>();
			var clist= GetAllCity().Where(m => m.StateId == stateid).ToList();
            foreach (var item in clist)
            {

				objcity.Add(new SelectListItem
				{
					Value = item.Id.ToString(),
					Text = item.CityName
				});
			}
			return Json(objcity);
		}

		public List<CityList> GetAllCity()
		{
			List<CityList> objcity = new List<CityList>();
			objcity.Add(new CityList { Id = 1, StateId = 1, CityName = "City1-1" });
			objcity.Add(new CityList { Id = 2, StateId = 2, CityName = "City2-1" });
			objcity.Add(new CityList { Id = 3, StateId = 4, CityName = "City4-1" });
			objcity.Add(new CityList { Id = 4, StateId = 1, CityName = "City1-2" });
			objcity.Add(new CityList { Id = 5, StateId = 1, CityName = "City1-3" });
			objcity.Add(new CityList { Id = 6, StateId = 4, CityName = "City4-2" });
			return objcity;
		}
		public List<CountryList> GetAllCountry()
		{
			List<CountryList> objstate = new List<CountryList>();
			objstate.Add(new CountryList { Id = 0, CountryName = "Select Country" });
			objstate.Add(new CountryList { Id = 1, CountryName = "India" });
			objstate.Add(new CountryList { Id = 2, CountryName = "USA" });
			objstate.Add(new CountryList { Id = 3, CountryName = "Canada" });
			objstate.Add(new CountryList { Id = 4, CountryName = "UAE" });
			return objstate;
		}

		[HttpPost]
		public IActionResult Signup(Signup signupmodel)
		{

			if(ModelState.IsValid)
			{
				return RedirectToAction("Message");
			}
			return View();
		}

		public IActionResult Message()
		{
			return View();
		}
	}
}
