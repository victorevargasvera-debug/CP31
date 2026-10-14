using System;
using System.Text;
using System.Xml;
using Gibraltar.Agent;

namespace Gibraltar.Monitor
{
	// Token: 0x0200018D RID: 397
	internal class EmailConfiguration
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x0002E10C File Offset: 0x0002C30C
		public EmailConfiguration(global::Gibraltar.Agent.EmailElement configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002E11C File Offset: 0x0002C31C
		public EmailConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.EmailElement emailElement = new global::Gibraltar.Agent.EmailElement();
			this.Initialize(emailElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("email");
			if (xmlNode != null)
			{
				this.Server = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "server", emailElement.Server);
				this.Port = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "port", emailElement.Port);
				this.UseSsl = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "useSsl", emailElement.UseSsl);
				this.User = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "user", emailElement.User);
				this.Password = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "password", emailElement.Password);
				this.MaxMessageSize = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxMessageSize", emailElement.MaxMessageSize);
				this.FromAddress = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "fromAddress", emailElement.FromAddress);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0002E1F4 File Offset: 0x0002C3F4
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		public string Server { get; set; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0002E208 File Offset: 0x0002C408
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x0002E210 File Offset: 0x0002C410
		public string User { get; set; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0002E21C File Offset: 0x0002C41C
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0002E224 File Offset: 0x0002C424
		public string Password { get; set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0002E230 File Offset: 0x0002C430
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0002E238 File Offset: 0x0002C438
		public int Port { get; set; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0002E244 File Offset: 0x0002C444
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x0002E24C File Offset: 0x0002C44C
		public bool UseSsl { get; set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0002E258 File Offset: 0x0002C458
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x0002E260 File Offset: 0x0002C460
		public int MaxMessageSize { get; set; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0002E26C File Offset: 0x0002C46C
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x0002E274 File Offset: 0x0002C474
		public string FromAddress { get; set; }

		// Token: 0x060010A5 RID: 4261 RVA: 0x0002E280 File Offset: 0x0002C480
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.EmailElement emailElement = new global::Gibraltar.Agent.EmailElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("email");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "server", this.Server ?? string.Empty, emailElement.Server);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "port", this.Port, emailElement.Port);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "useSsl", this.UseSsl, emailElement.UseSsl);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "user", this.User ?? string.Empty, emailElement.User);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "password", this.Password ?? string.Empty, emailElement.Password);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxMessageSize", this.MaxMessageSize, emailElement.MaxMessageSize);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "fromAddress", this.FromAddress, emailElement.FromAddress);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0002E388 File Offset: 0x0002C588
		public void Load(global::Gibraltar.Monitor.EmailConfiguration configuration)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			this.Initialize(configuration);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			stringBuilder.AppendLine("Mail Server Connection Configuration:");
			stringBuilder.AppendFormat("  Server: {0} Port: {1} Use SSL:{2}\r\n", this.Server, this.Port, this.UseSsl);
			if (!string.IsNullOrEmpty(this.Password))
			{
				stringBuilder.AppendFormat("  User: {0} Password: (Protected Value)\r\n", this.User);
			}
			stringBuilder.AppendFormat("  Maximum Message Size: {0}\r\n", this.MaxMessageSize);
			return stringBuilder.ToString();
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0002E434 File Offset: 0x0002C634
		public void Sanitize()
		{
			if (string.IsNullOrEmpty(this.Server))
			{
				this.Server = null;
			}
			if (string.IsNullOrEmpty(this.User))
			{
				this.User = null;
			}
			if (string.IsNullOrEmpty(this.Password))
			{
				this.Password = null;
			}
			if (this.MaxMessageSize <= 0)
			{
				this.MaxMessageSize = 10;
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		private void Initialize(global::Gibraltar.Agent.EmailElement configuration)
		{
			this.Server = configuration.Server;
			this.User = configuration.User;
			this.Password = configuration.Password;
			this.Port = configuration.Port;
			this.UseSsl = configuration.UseSsl;
			this.MaxMessageSize = configuration.MaxMessageSize;
			this.FromAddress = configuration.FromAddress;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0002E508 File Offset: 0x0002C708
		private void Initialize(global::Gibraltar.Monitor.EmailConfiguration configuration)
		{
			this.Server = configuration.Server;
			this.User = configuration.User;
			this.Password = configuration.Password;
			this.Port = configuration.Port;
			this.UseSsl = configuration.UseSsl;
			this.MaxMessageSize = configuration.MaxMessageSize;
			this.FromAddress = configuration.FromAddress;
		}
	}
}
