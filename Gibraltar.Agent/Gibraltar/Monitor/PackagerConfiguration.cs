using System;
using System.Xml;
using Gibraltar.Agent;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A6 RID: 422
	internal class PackagerConfiguration
	{
		// Token: 0x06001272 RID: 4722 RVA: 0x00035938 File Offset: 0x00033B38
		internal PackagerConfiguration(global::Gibraltar.Agent.PackagerElement configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00035948 File Offset: 0x00033B48
		internal PackagerConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.PackagerElement packagerElement = new global::Gibraltar.Agent.PackagerElement();
			this.Initialize(packagerElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("packager");
			if (xmlNode != null)
			{
				this.HotKey = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "hotKey", packagerElement.HotKey);
				this.AllowEmail = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "allowEmail", packagerElement.AllowEmail);
				this.AllowFile = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "allowFile", packagerElement.AllowFile);
				this.AllowRemovableMedia = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "allowRemovableMedia", packagerElement.AllowRemovableMedia);
				this.AllowServer = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "allowServer", packagerElement.AllowServer);
				this.ApplicationName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "applicationName", packagerElement.ApplicationName);
				this.DestinationEmailAddress = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "destinationEmailAddress", packagerElement.DestinationEmailAddress);
				this.FromEmailAddress = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "fromEmailAddress", packagerElement.FromEmailAddress);
				this.ProductName = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "productName", packagerElement.ProductName);
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00035A50 File Offset: 0x00033C50
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x00035A58 File Offset: 0x00033C58
		public string HotKey { get; set; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00035A64 File Offset: 0x00033C64
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00035A6C File Offset: 0x00033C6C
		public bool AllowFile { get; set; }

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00035A78 File Offset: 0x00033C78
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x00035A80 File Offset: 0x00033C80
		public bool AllowRemovableMedia { get; set; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00035A8C File Offset: 0x00033C8C
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x00035A94 File Offset: 0x00033C94
		public bool AllowServer { get; set; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00035AA0 File Offset: 0x00033CA0
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x00035AA8 File Offset: 0x00033CA8
		public bool AllowEmail { get; set; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00035AB4 File Offset: 0x00033CB4
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00035ABC File Offset: 0x00033CBC
		public string FromEmailAddress { get; set; }

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x00035AC8 File Offset: 0x00033CC8
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00035AD0 File Offset: 0x00033CD0
		public string DestinationEmailAddress { get; set; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x00035ADC File Offset: 0x00033CDC
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x00035AE4 File Offset: 0x00033CE4
		public string ProductName { get; set; }

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00035AF0 File Offset: 0x00033CF0
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00035AF8 File Offset: 0x00033CF8
		public string ApplicationName { get; set; }

		// Token: 0x06001286 RID: 4742 RVA: 0x00035B04 File Offset: 0x00033D04
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.PackagerElement packagerElement = new global::Gibraltar.Agent.PackagerElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("packager");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "hotKey", this.HotKey ?? string.Empty, packagerElement.HotKey);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "productName", this.ProductName ?? string.Empty, packagerElement.ProductName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "applicationName", this.ApplicationName ?? string.Empty, packagerElement.ApplicationName);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "allowEmail", this.AllowEmail, packagerElement.AllowEmail);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "allowFile", this.AllowFile, packagerElement.AllowFile);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "allowRemovableMedia", this.AllowRemovableMedia, packagerElement.AllowRemovableMedia);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "allowServer", this.AllowServer, packagerElement.AllowServer);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "destinationEmailAddress", this.DestinationEmailAddress ?? string.Empty, packagerElement.DestinationEmailAddress);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "fromEmailAddress", this.FromEmailAddress ?? string.Empty, packagerElement.FromEmailAddress);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00035C50 File Offset: 0x00033E50
		internal void Sanitize()
		{
			if (string.IsNullOrEmpty(this.HotKey))
			{
				this.HotKey = "Ctrl-Alt-F4";
			}
			if (string.IsNullOrEmpty(this.ProductName))
			{
				this.ProductName = null;
			}
			if (string.IsNullOrEmpty(this.ApplicationName))
			{
				this.ApplicationName = null;
			}
			if (string.IsNullOrEmpty(this.FromEmailAddress))
			{
				this.FromEmailAddress = null;
			}
			if (string.IsNullOrEmpty(this.DestinationEmailAddress))
			{
				this.DestinationEmailAddress = null;
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00035CD8 File Offset: 0x00033ED8
		private void Initialize(global::Gibraltar.Agent.PackagerElement configuration)
		{
			this.HotKey = configuration.HotKey;
			this.AllowEmail = configuration.AllowEmail;
			this.AllowFile = configuration.AllowFile;
			this.AllowRemovableMedia = configuration.AllowRemovableMedia;
			this.AllowServer = configuration.AllowServer;
			this.ApplicationName = configuration.ApplicationName;
			this.DestinationEmailAddress = configuration.DestinationEmailAddress;
			this.FromEmailAddress = configuration.FromEmailAddress;
			this.ProductName = configuration.ProductName;
		}

		// Token: 0x0400063F RID: 1599
		public const string DefaultHotKey = "Ctrl-Alt-F4";
	}
}
