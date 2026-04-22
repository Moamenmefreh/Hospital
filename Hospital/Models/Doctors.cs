using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
	public class Doctors
	{
	[Key]
	[Required(ErrorMessage ="Id For Doctor Is required and contain Numbers , char , signals")]

		public Guid Id { get; set; }

		public string doctorName { get; set; }
		public string speciales { get; set; }
		public string Address { get; set; }
		public double Salary { get; set; }

	}
}
