using System;
using System.Xml;
using Gibraltar.Agent;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001AD RID: 429
	internal class PublisherConfiguration
	{
		// Token: 0x06001340 RID: 4928 RVA: 0x000389F8 File Offset: 0x00036BF8
		internal PublisherConfiguration(global::Gibraltar.Agent.PublisherElement configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00038A08 File Offset: 0x00036C08
		internal PublisherConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			this.m_GibraltarNode = gibraltarNode;
			global::Gibraltar.Agent.PublisherElement publisherElement = new global::Gibraltar.Agent.PublisherElement();
			this.Initialize(publisherElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("publisher");
			if (xmlNode != null)
			{
				this.EnableAnonymousMode = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableAnonymousMode", publisherElement.EnableAnonymousMode);
				this.EnableDebugMode = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableDebugMode", publisherElement.EnableDebugMode);
				this.ForceSynchronous = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "forceSynchronous", publisherElement.ForceSynchronous);
				this.MaxQueueLength = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxQueueLength", publisherElement.MaxQueueLength);
				this.ProductName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "productName", publisherElement.ProductName);
				this.ApplicationName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "applicationName", publisherElement.ApplicationName);
				this.EnvironmentName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "environmentName", publisherElement.EnvironmentName);
				this.PromotionLevelName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "promotionLevelName", publisherElement.PromotionLevelName);
				string text = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "applicationType", publisherElement.ApplicationType);
				this.ApplicationDescription = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "applicationDescription", publisherElement.ApplicationDescription);
				string text2 = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "applicationVersion", null);
				if (string.IsNullOrEmpty(text2))
				{
					this.ApplicationVersion = null;
				}
				else
				{
					try
					{
						this.ApplicationVersion = new global::System.Version(text2);
					}
					catch
					{
						this.ApplicationVersion = null;
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					this.ApplicationType = global::Loupe.Extensibility.Data.ApplicationType.Unknown;
				}
				else
				{
					this.ApplicationType = global::Gibraltar.Monitor.PublisherConfiguration.ParseApplicationType(text);
				}
			}
			this.Sanitize();
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00038BA0 File Offset: 0x00036DA0
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x00038BA8 File Offset: 0x00036DA8
		public string ProductName { get; set; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x00038BB4 File Offset: 0x00036DB4
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x00038BBC File Offset: 0x00036DBC
		public string ApplicationDescription { get; set; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x00038BC8 File Offset: 0x00036DC8
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00038BD0 File Offset: 0x00036DD0
		public string ApplicationName { get; set; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x00038BDC File Offset: 0x00036DDC
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x00038BE4 File Offset: 0x00036DE4
		public string EnvironmentName { get; set; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00038BF0 File Offset: 0x00036DF0
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x00038BF8 File Offset: 0x00036DF8
		public string PromotionLevelName { get; set; }

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00038C04 File Offset: 0x00036E04
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00038C0C File Offset: 0x00036E0C
		public global::Loupe.Extensibility.Data.ApplicationType ApplicationType { get; set; }

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00038C18 File Offset: 0x00036E18
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00038C20 File Offset: 0x00036E20
		public global::System.Version ApplicationVersion { get; set; }

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00038C2C File Offset: 0x00036E2C
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x00038C34 File Offset: 0x00036E34
		public bool ForceSynchronous { get; set; }

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00038C40 File Offset: 0x00036E40
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00038C48 File Offset: 0x00036E48
		public int MaxQueueLength { get; set; }

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00038C54 File Offset: 0x00036E54
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x00038C5C File Offset: 0x00036E5C
		public bool EnableAnonymousMode { get; set; }

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00038C68 File Offset: 0x00036E68
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x00038C70 File Offset: 0x00036E70
		public bool EnableDebugMode { get; set; }

		// Token: 0x06001358 RID: 4952 RVA: 0x00038C7C File Offset: 0x00036E7C
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.PublisherElement publisherElement = new global::Gibraltar.Agent.PublisherElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("publisher");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "productName", this.ProductName ?? string.Empty, publisherElement.ProductName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "applicationName", this.ApplicationName ?? string.Empty, publisherElement.ApplicationName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "environmentName", this.EnvironmentName ?? string.Empty, publisherElement.EnvironmentName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "promotionLevelName", this.PromotionLevelName ?? string.Empty, publisherElement.PromotionLevelName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "applicationType", this.ApplicationType.ToString(), publisherElement.ApplicationType);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "applicationDescription", this.ApplicationDescription ?? string.Empty, publisherElement.ApplicationDescription);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "forceSynchronous", this.ForceSynchronous, publisherElement.ForceSynchronous);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxQueueLength", this.MaxQueueLength, publisherElement.MaxQueueLength);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableAnonymousMode", this.EnableAnonymousMode, publisherElement.EnableAnonymousMode);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableDebugMode", this.EnableDebugMode, publisherElement.EnableDebugMode);
			if (this.ApplicationVersion != null)
			{
				global::Gibraltar.Monitor.AgentConfiguration.WriteValue<global::System.Version>(xmlNode, "applicationVersion", this.ApplicationVersion, new global::System.Version(0, 0));
			}
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00038E18 File Offset: 0x00037018
		internal void Sanitize()
		{
			if (this.MaxQueueLength <= 0)
			{
				this.MaxQueueLength = 2000;
			}
			else if (this.MaxQueueLength > 50000)
			{
				this.MaxQueueLength = 2000;
			}
			if (string.IsNullOrEmpty(this.ProductName))
			{
				this.ProductName = null;
			}
			if (string.IsNullOrEmpty(this.ApplicationDescription))
			{
				this.ApplicationDescription = null;
			}
			if (string.IsNullOrEmpty(this.ApplicationName))
			{
				this.ApplicationName = null;
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00038EA8 File Offset: 0x000370A8
		private void Initialize(global::Gibraltar.Agent.PublisherElement configuration)
		{
			this.EnableAnonymousMode = configuration.EnableAnonymousMode;
			this.EnableDebugMode = configuration.EnableDebugMode;
			this.ForceSynchronous = configuration.ForceSynchronous;
			this.MaxQueueLength = configuration.MaxQueueLength;
			this.ProductName = configuration.ProductName;
			this.ApplicationName = configuration.ApplicationName;
			this.EnvironmentName = configuration.EnvironmentName;
			this.PromotionLevelName = configuration.PromotionLevelName;
			this.ApplicationDescription = configuration.ApplicationDescription;
			string applicationVersion = configuration.ApplicationVersion;
			if (string.IsNullOrEmpty(applicationVersion))
			{
				this.ApplicationVersion = null;
			}
			else
			{
				try
				{
					this.ApplicationVersion = new global::System.Version(applicationVersion);
				}
				catch
				{
					this.ApplicationVersion = null;
				}
			}
			string applicationType = configuration.ApplicationType;
			this.ApplicationType = global::Gibraltar.Monitor.PublisherConfiguration.ParseApplicationType(applicationType);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00038F84 File Offset: 0x00037184
		private static global::Loupe.Extensibility.Data.ApplicationType ParseApplicationType(string appTypeString)
		{
			global::Loupe.Extensibility.Data.ApplicationType result = global::Loupe.Extensibility.Data.ApplicationType.Unknown;
			if (!string.IsNullOrEmpty(appTypeString))
			{
				string a = appTypeString.ToUpper();
				if (!(a == "WINDOWS"))
				{
					if (!(a == "ASPNET"))
					{
						if (!(a == "SERVICE"))
						{
							if (!(a == "CONSOLE"))
							{
								if (a == "UNKNOWN")
								{
									result = global::Loupe.Extensibility.Data.ApplicationType.Unknown;
								}
							}
							else
							{
								result = global::Loupe.Extensibility.Data.ApplicationType.Console;
							}
						}
						else
						{
							result = global::Loupe.Extensibility.Data.ApplicationType.Service;
						}
					}
					else
					{
						result = global::Loupe.Extensibility.Data.ApplicationType.AspNet;
					}
				}
				else
				{
					result = global::Loupe.Extensibility.Data.ApplicationType.Windows;
				}
			}
			return result;
		}

		// Token: 0x04000666 RID: 1638
		private global::System.Xml.XmlNode m_GibraltarNode;
	}
}
