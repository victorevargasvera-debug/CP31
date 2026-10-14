using System;
using System.Xml;
using Gibraltar.Agent;

namespace Gibraltar.Monitor
{
	// Token: 0x02000184 RID: 388
	internal class AutoSendConsentConfiguration
	{
		// Token: 0x06001035 RID: 4149 RVA: 0x0002CE58 File Offset: 0x0002B058
		internal AutoSendConsentConfiguration(global::Gibraltar.Agent.AutoSendConsentElement configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0002CE68 File Offset: 0x0002B068
		internal AutoSendConsentConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			this.m_GibraltarNode = gibraltarNode;
			global::Gibraltar.Agent.AutoSendConsentElement autoSendConsentElement = new global::Gibraltar.Agent.AutoSendConsentElement();
			this.Initialize(autoSendConsentElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("autoSendConsent");
			if (xmlNode != null)
			{
				this.Enabled = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enabled", autoSendConsentElement.Enabled);
				this.ConsentDefault = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "consentDefault", autoSendConsentElement.ConsentDefault);
				this.PromptUserOnStartupLimit = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "promptUserOnStartupLimit", autoSendConsentElement.PromptUserOnStartupLimit);
				this.CompanyName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "companyName", autoSendConsentElement.CompanyName);
				this.ServiceName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "serviceName", autoSendConsentElement.ServiceName);
				this.PrivacyPolicyUrl = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "privacyPolicyUrl", autoSendConsentElement.PrivacyPolicyUrl);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0002CF30 File Offset: 0x0002B130
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x0002CF38 File Offset: 0x0002B138
		public bool Enabled { get; set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0002CF44 File Offset: 0x0002B144
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x0002CF4C File Offset: 0x0002B14C
		public bool ConsentDefault { get; set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0002CF58 File Offset: 0x0002B158
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x0002CF60 File Offset: 0x0002B160
		public int PromptUserOnStartupLimit { get; set; }

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0002CF6C File Offset: 0x0002B16C
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x0002CF74 File Offset: 0x0002B174
		public string CompanyName { get; set; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x0002CF80 File Offset: 0x0002B180
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x0002CF88 File Offset: 0x0002B188
		public string PrivacyPolicyUrl { get; set; }

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0002CF94 File Offset: 0x0002B194
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x0002CF9C File Offset: 0x0002B19C
		public string ServiceName { get; set; }

		// Token: 0x06001043 RID: 4163 RVA: 0x0002CFA8 File Offset: 0x0002B1A8
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.AutoSendConsentElement autoSendConsentElement = new global::Gibraltar.Agent.AutoSendConsentElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("autoSendConsent");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enabled", this.Enabled, autoSendConsentElement.Enabled);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "consentDefault", this.ConsentDefault, autoSendConsentElement.ConsentDefault);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "promptUserOnStartupLimit", this.PromptUserOnStartupLimit, autoSendConsentElement.PromptUserOnStartupLimit);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "companyName", this.CompanyName ?? string.Empty, autoSendConsentElement.CompanyName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "serviceName", this.ServiceName ?? string.Empty, autoSendConsentElement.ServiceName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "privacyPolicyUrl", this.PrivacyPolicyUrl ?? string.Empty, autoSendConsentElement.PrivacyPolicyUrl);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0002D098 File Offset: 0x0002B298
		internal void Sanitize()
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0002D09C File Offset: 0x0002B29C
		private void Initialize(global::Gibraltar.Agent.AutoSendConsentElement configuration)
		{
			this.Enabled = configuration.Enabled;
			this.ConsentDefault = configuration.ConsentDefault;
			this.PromptUserOnStartupLimit = configuration.PromptUserOnStartupLimit;
			this.CompanyName = configuration.CompanyName;
			this.ServiceName = configuration.ServiceName;
			this.PrivacyPolicyUrl = configuration.PrivacyPolicyUrl;
		}

		// Token: 0x04000575 RID: 1397
		private readonly global::System.Xml.XmlNode m_GibraltarNode;
	}
}
