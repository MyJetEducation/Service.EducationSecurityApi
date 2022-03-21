using System.ComponentModel.DataAnnotations;

namespace Service.EducationSecurityApi.Models
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}