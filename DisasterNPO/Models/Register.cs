using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace DisasterNPO.Models
{
	public class Register
	{
        public int Id { get; set; }
        public string RegEmail { get; set; } = null!;
		public string RegPassword { get; set; } = null!;
	}
}
