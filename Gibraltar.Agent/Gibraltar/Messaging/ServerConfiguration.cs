using System;
using System.Xml;
using Gibraltar.Agent;
using Gibraltar.Monitor;
using Gibraltar.Server.Client;

namespace Gibraltar.Messaging
{
	// Token: 0x02000231 RID: 561
	internal class ServerConfiguration : global::Gibraltar.Server.Client.IServerConfiguration
	{
		// Token: 0x06001C15 RID: 7189 RVA: 0x00062B94 File Offset: 0x00060D94
		public ServerConfiguration()
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00062B9C File Offset: 0x00060D9C
		public ServerConfiguration(global::Gibraltar.Agent.ServerElement configuration)
		{
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			this.Initialize(configuration);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00062BBC File Offset: 0x00060DBC
		internal ServerConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.ServerElement serverElement = new global::Gibraltar.Agent.ServerElement();
			this.Initialize(serverElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("server");
			if (xmlNode != null)
			{
				this.Enabled = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enabled", serverElement.Enabled);
				this.AutoSendSessions = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "autoSendSessions", serverElement.AutoSendSessions);
				this.AutoSendOnError = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "autoSendOnError", serverElement.AutoSendOnError);
				this.SendAllApplications = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "sendAllApplications", serverElement.SendAllApplications);
				this.PurgeSentSessions = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "purgeSentSessions", serverElement.PurgeSentSessions);
				this.UseGibraltarService = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "useGibraltarService", serverElement.UseGibraltarService);
				this.CustomerName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "customerName", serverElement.CustomerName);
				this.Server = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "server", serverElement.Server);
				this.Port = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "port", serverElement.Port);
				this.UseSsl = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "useSsl", serverElement.UseSsl);
				this.ApplicationBaseDirectory = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "applicationBaseDirectory", serverElement.ApplicationBaseDirectory);
				this.Repository = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "repository", serverElement.Repository);
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x00062D08 File Offset: 0x00060F08
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00062D10 File Offset: 0x00060F10
		public bool Enabled { get; set; }

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00062D1C File Offset: 0x00060F1C
		// (set) Token: 0x06001C1B RID: 7195 RVA: 0x00062D24 File Offset: 0x00060F24
		public bool AutoSendSessions { get; set; }

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00062D30 File Offset: 0x00060F30
		// (set) Token: 0x06001C1D RID: 7197 RVA: 0x00062D38 File Offset: 0x00060F38
		public bool AutoSendOnError { get; set; }

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00062D44 File Offset: 0x00060F44
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x00062D4C File Offset: 0x00060F4C
		public bool SendAllApplications { get; set; }

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00062D58 File Offset: 0x00060F58
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x00062D60 File Offset: 0x00060F60
		public bool PurgeSentSessions { get; set; }

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00062D6C File Offset: 0x00060F6C
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x00062D74 File Offset: 0x00060F74
		public string CustomerName { get; set; }

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00062D80 File Offset: 0x00060F80
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00062D88 File Offset: 0x00060F88
		public bool UseGibraltarService { get; set; }

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00062D94 File Offset: 0x00060F94
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00062D9C File Offset: 0x00060F9C
		public bool UseSsl { get; set; }

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00062DA8 File Offset: 0x00060FA8
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00062DB0 File Offset: 0x00060FB0
		public string Server { get; set; }

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00062DBC File Offset: 0x00060FBC
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00062DC4 File Offset: 0x00060FC4
		public int Port { get; set; }

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00062DD0 File Offset: 0x00060FD0
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00062DD8 File Offset: 0x00060FD8
		public string ApplicationBaseDirectory { get; set; }

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00062DE4 File Offset: 0x00060FE4
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00062DEC File Offset: 0x00060FEC
		public string Repository { get; set; }

		// Token: 0x06001C30 RID: 7216 RVA: 0x00062DF8 File Offset: 0x00060FF8
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.ServerElement serverElement = new global::Gibraltar.Agent.ServerElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("server");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enabled", this.Enabled, serverElement.Enabled);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "autoSendSessions", this.AutoSendSessions, serverElement.AutoSendSessions);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "autoSendOnError", this.AutoSendOnError, serverElement.AutoSendOnError);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "sendAllApplications", this.SendAllApplications, serverElement.SendAllApplications);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "purgeSentSessions", this.PurgeSentSessions, serverElement.PurgeSentSessions);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "useGibraltarService", this.UseGibraltarService, serverElement.UseGibraltarService);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "customerName", this.CustomerName ?? string.Empty, serverElement.CustomerName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "server", this.Server ?? string.Empty, serverElement.Server);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "port", this.Port, serverElement.Port);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "useSsl", this.UseSsl, serverElement.UseSsl);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "applicationBaseDirectory", this.ApplicationBaseDirectory ?? string.Empty, serverElement.ApplicationBaseDirectory);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "repository", this.Repository ?? string.Empty, serverElement.Repository);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00062F80 File Offset: 0x00061180
		public void Load(global::Gibraltar.Messaging.ServerConfiguration configuration)
		{
			this.UseGibraltarService = configuration.UseGibraltarService;
			this.CustomerName = configuration.CustomerName;
			this.Server = configuration.Server;
			this.Port = configuration.Port;
			this.UseSsl = configuration.UseSsl;
			this.ApplicationBaseDirectory = configuration.ApplicationBaseDirectory;
			this.Repository = configuration.Repository;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00062FE8 File Offset: 0x000611E8
		public void Validate()
		{
			global::Gibraltar.Server.Client.HubConnection.ValidateConfiguration(this.UseGibraltarService, this.CustomerName, this.Server, this.Port, this.UseSsl, this.ApplicationBaseDirectory);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00063024 File Offset: 0x00061224
		internal void Sanitize()
		{
			if (string.IsNullOrEmpty(this.Server))
			{
				this.Server = null;
			}
			else
			{
				this.Server = this.Server.Trim();
				if (this.Server.StartsWith("https://", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.Server = this.Server.Substring(8);
				}
				else if (this.Server.StartsWith("http://", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.Server = this.Server.Substring(7);
				}
				if (this.Server.EndsWith("/", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.Server = this.Server.Substring(0, this.Server.Length - 1);
				}
			}
			if (string.IsNullOrEmpty(this.CustomerName))
			{
				this.CustomerName = null;
			}
			else
			{
				this.CustomerName = this.CustomerName.Trim();
			}
			if (string.IsNullOrEmpty(this.ApplicationBaseDirectory))
			{
				this.ApplicationBaseDirectory = null;
			}
			else
			{
				this.ApplicationBaseDirectory = this.ApplicationBaseDirectory.Trim();
				if (this.ApplicationBaseDirectory.StartsWith("/", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.ApplicationBaseDirectory = this.ApplicationBaseDirectory.Substring(1);
				}
				if (this.ApplicationBaseDirectory.EndsWith("/", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.ApplicationBaseDirectory = this.ApplicationBaseDirectory.Substring(0, this.ApplicationBaseDirectory.Length - 1);
				}
			}
			if (this.Port < 0)
			{
				this.Port = 0;
			}
			if ((this.UseGibraltarService && string.IsNullOrEmpty(this.CustomerName)) || (!this.UseGibraltarService && string.IsNullOrEmpty(this.Server)))
			{
				this.Enabled = false;
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000631F4 File Offset: 0x000613F4
		private void Initialize(global::Gibraltar.Agent.ServerElement configuration)
		{
			this.Enabled = configuration.Enabled;
			this.AutoSendSessions = configuration.AutoSendSessions;
			this.AutoSendOnError = configuration.AutoSendOnError;
			this.SendAllApplications = configuration.SendAllApplications;
			this.PurgeSentSessions = configuration.PurgeSentSessions;
			this.UseGibraltarService = configuration.UseGibraltarService;
			this.CustomerName = configuration.CustomerName;
			this.Server = configuration.Server;
			this.Port = configuration.Port;
			this.UseSsl = configuration.UseSsl;
			this.ApplicationBaseDirectory = configuration.ApplicationBaseDirectory;
			this.Repository = configuration.Repository;
		}
	}
}
