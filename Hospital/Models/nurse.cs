using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
	public class nurse
	{
		[Key]
		[Required(ErrorMessage = "Id For Pation Is required and contain Numbers , char , signals")]

		public Guid Id { get; set; }

		public string pationName { get; set; }
		public string speciales { get; set; }
		public string Address { get; set; }
		public double Salary{  get; set; }
	}
}
