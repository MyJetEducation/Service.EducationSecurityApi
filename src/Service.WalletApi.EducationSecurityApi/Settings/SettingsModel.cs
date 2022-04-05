using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationSecurityApi.Settings
{
    public class SettingsModel
    {
        [YamlProperty("EducationSecurityApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("EducationSecurityApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("EducationSecurityApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("EducationSecurityApi.EnableApiTrace")]
        public bool EnableApiTrace { get; set; }

        [YamlProperty("EducationSecurityApi.MyNoSqlReaderHostPort")]
        public string MyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationSecurityApi.AuthMyNoSqlReaderHostPort")]
        public string AuthMyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationSecurityApi.SessionEncryptionKeyId")]
        public string SessionEncryptionKeyId { get; set; }

        [YamlProperty("EducationSecurityApi.MyNoSqlWriterUrl")]
        public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationSecurityApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
    }
}
