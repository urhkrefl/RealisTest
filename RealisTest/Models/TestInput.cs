using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealisTest.Models

{
	public class TestInput
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;

		[Display(Name = "Inserted Date")]
		[DataType(DataType.Date)]
		public DateTime inputDate { get; set; }

		[Display(Name = "Inserted time")]
		[DataType(DataType.Time)]
		public DateTime inputTime { get; set; }

	}
}
