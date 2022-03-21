using System.ComponentModel.DataAnnotations;

namespace Service.EducationSecurityApi.Models
{
	public class TaskTrueFalse
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public bool Value { get; set; }
	}
}