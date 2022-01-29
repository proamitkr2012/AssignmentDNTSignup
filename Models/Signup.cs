using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.ComponentModel.DataAnnotations;

using static AssignmentDNTSignup.Attributes.ValidationCheckbox;
using static AssignmentDNTSignup.Models.Signup;

namespace AssignmentDNTSignup.Models
{
	public class Signup
	{
		[Required(ErrorMessage = "Please Enter UserName")]
		public string? Username { get; set; }

		[Required(ErrorMessage = "Please Enter Password")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Please Enter Confirm Password")]
		[Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
		public string ConfirmPassword { get; set; }


		[RegularExpression("^[789]\\d{9}$", ErrorMessage = "Please Enter Correct Contact")]
		public string? Contact { get; set; }

		public string Country { get; set; }

		public string City { get; set; }

		[Required(ErrorMessage = "Please select Gender")]
		[Display(Name = "Gender")]
		public genderlist Gender { get; set; }

		[ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
		public bool  Terms { get; set; }

	

		public enum genderlist
		{
			 Male ,
			 Female	
		}

		public class CityList
		{
			
			public int StateId { get; set; }

			public int Id { get; set; }
			public string CityName { get; set; }
		}

		public class CountryList
		{
			public int Id { get; set; }
			public int StateId { get; set; }
			public string CountryName { get; set; }
		}
	}
}
