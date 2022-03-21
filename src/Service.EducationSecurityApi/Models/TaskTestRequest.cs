using System.ComponentModel.DataAnnotations;

namespace Service.EducationSecurityApi.Models
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}