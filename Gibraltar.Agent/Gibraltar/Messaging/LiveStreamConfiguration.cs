using System;
using System.Text;
using System.Xml;
using Gibraltar.Agent;
using Gibraltar.Monitor;

namespace Gibraltar.Messaging
{
	// Token: 0x02000230 RID: 560
	internal class LiveStreamConfiguration
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00062854 File Offset: 0x00060A54
		public LiveStreamConfiguration(global::Gibraltar.Agent.LiveStreamElement configuration)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			this.Initialize(configuration);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00062874 File Offset: 0x00060A74
		public LiveStreamConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.LiveStreamElement liveStreamElement = new global::Gibraltar.Agent.LiveStreamElement();
			this.Initialize(liveStreamElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("liveStream");
			if (xmlNode != null)
			{
				this.Enabled = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enabled", liveStreamElement.Enabled);
				this.AgentPort = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "agentPort", liveStreamElement.AgentPort);
				this.ClientPort = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "clientPort", liveStreamElement.ClientPort);
				this.UseSsl = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "useSsl", liveStreamElement.UseSsl);
				this.CertificateName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "certificateName", liveStreamElement.CertificateName);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00062920 File Offset: 0x00060B20
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x00062928 File Offset: 0x00060B28
		public bool Enabled { get; set; }

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00062934 File Offset: 0x00060B34
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x0006293C File Offset: 0x00060B3C
		public int AgentPort { get; set; }

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00062948 File Offset: 0x00060B48
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00062950 File Offset: 0x00060B50
		public int ClientPort { get; set; }

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0006295C File Offset: 0x00060B5C
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00062964 File Offset: 0x00060B64
		public bool UseSsl { get; set; }

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x00062970 File Offset: 0x00060B70
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x00062978 File Offset: 0x00060B78
		public string CertificateName { get; set; }

		// Token: 0x06001C0F RID: 7183 RVA: 0x00062984 File Offset: 0x00060B84
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.LiveStreamElement liveStreamElement = new global::Gibraltar.Agent.LiveStreamElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("liveStream");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enabled", this.Enabled, liveStreamElement.Enabled);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "agentPort", this.AgentPort, liveStreamElement.AgentPort);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "clientPort", this.ClientPort, liveStreamElement.ClientPort);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "useSsl", this.UseSsl, liveStreamElement.UseSsl);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "certificateName", this.CertificateName, liveStreamElement.CertificateName);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00062A38 File Offset: 0x00060C38
		public void Load(global::Gibraltar.Messaging.LiveStreamConfiguration configuration)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			this.Initialize(configuration);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00062A54 File Offset: 0x00060C54
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			stringBuilder.AppendLine("Live Stream Configuration:");
			stringBuilder.AppendFormat("  Enabled: {0}\r\n", this.Enabled);
			stringBuilder.AppendFormat("  Agent Port: {0}\r\n", this.AgentPort);
			stringBuilder.AppendFormat("  Client Port: {0}\r\n", this.ClientPort);
			stringBuilder.AppendFormat("  Use SSL: {0}\r\n", this.UseSsl);
			stringBuilder.AppendFormat("  Certificate Name: {0}\r\n", this.CertificateName);
			return stringBuilder.ToString();
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00062AF0 File Offset: 0x00060CF0
		public void Sanitize()
		{
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00062AF4 File Offset: 0x00060CF4
		private void Initialize(global::Gibraltar.Agent.LiveStreamElement configuration)
		{
			this.Enabled = configuration.Enabled;
			this.AgentPort = configuration.AgentPort;
			this.ClientPort = configuration.ClientPort;
			this.UseSsl = configuration.UseSsl;
			this.CertificateName = configuration.CertificateName;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00062B44 File Offset: 0x00060D44
		private void Initialize(global::Gibraltar.Messaging.LiveStreamConfiguration configuration)
		{
			this.Enabled = configuration.Enabled;
			this.AgentPort = configuration.AgentPort;
			this.ClientPort = configuration.ClientPort;
			this.UseSsl = configuration.UseSsl;
			this.CertificateName = configuration.CertificateName;
		}
	}
}
