using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationSecurityApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationSecurityApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationSecurityApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationSecurityApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationSecurityApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}
