using System;
using System.Xml;
using Gibraltar.Agent;
using Gibraltar.Monitor;

namespace Gibraltar.Messaging
{
	// Token: 0x0200022A RID: 554
	internal class NetworkMessengerConfiguration : global::Gibraltar.Messaging.MessengerConfiguration
	{
		// Token: 0x06001BE2 RID: 7138 RVA: 0x00061D2C File Offset: 0x0005FF2C
		internal NetworkMessengerConfiguration(string name, global::Gibraltar.Agent.NetworkViewerElement configuration) : base(name, typeof(global::Gibraltar.Messaging.NetworkMessenger).AssemblyQualifiedName)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00061D4C File Offset: 0x0005FF4C
		internal NetworkMessengerConfiguration(string name, global::System.Xml.XmlNode gibraltarNode) : base(name, typeof(global::Gibraltar.Messaging.NetworkMessenger).AssemblyQualifiedName)
		{
			this.m_GibraltarNode = gibraltarNode;
			global::Gibraltar.Agent.NetworkViewerElement networkViewerElement = new global::Gibraltar.Agent.NetworkViewerElement();
			this.Initialize(networkViewerElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("networkViewer");
			if (xmlNode != null)
			{
				this.AllowLocalClients = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "allowLocalClients", networkViewerElement.AllowRemoteClients);
				this.AllowRemoteClients = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "allowRemoteClients", networkViewerElement.AllowRemoteClients);
				base.Enabled = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enabled", networkViewerElement.Enabled);
				base.MaxQueueLength = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxQueueLength", networkViewerElement.MaxQueueLength);
			}
			this.Sanitize();
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00061DFC File Offset: 0x0005FFFC
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x00061E04 File Offset: 0x00060004
		public bool AllowLocalClients { get; set; }

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00061E10 File Offset: 0x00060010
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00061E18 File Offset: 0x00060018
		public bool AllowRemoteClients { get; set; }

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00061E24 File Offset: 0x00060024
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.NetworkViewerElement networkViewerElement = new global::Gibraltar.Agent.NetworkViewerElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("sessionFile");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enabled", base.Enabled, networkViewerElement.Enabled);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxQueueLength", base.MaxQueueLength, networkViewerElement.MaxQueueLength);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "allowLocalClients", this.AllowLocalClients, networkViewerElement.AllowLocalClients);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "allowRemoteClients", this.AllowRemoteClients, networkViewerElement.AllowRemoteClients);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00061EC4 File Offset: 0x000600C4
		internal void Sanitize()
		{
			if (base.MaxQueueLength <= 0)
			{
				base.MaxQueueLength = 2000;
				return;
			}
			if (base.MaxQueueLength > 50000)
			{
				base.MaxQueueLength = 50000;
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00061EFC File Offset: 0x000600FC
		private void Initialize(global::Gibraltar.Agent.NetworkViewerElement configuration)
		{
			this.AllowLocalClients = configuration.AllowLocalClients;
			this.AllowRemoteClients = configuration.AllowRemoteClients;
			base.Enabled = configuration.Enabled;
			base.MaxQueueLength = configuration.MaxQueueLength;
		}

		// Token: 0x04000A12 RID: 2578
		private global::System.Xml.XmlNode m_GibraltarNode;
	}
}
