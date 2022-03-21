using System.ComponentModel.DataAnnotations;

namespace Service.EducationSecurityApi.Models
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}