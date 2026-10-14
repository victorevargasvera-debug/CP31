using System;
using System.Xml;
using Gibraltar.Agent;
using Gibraltar.Monitor;

namespace Gibraltar.Messaging
{
	// Token: 0x02000234 RID: 564
	internal class FileMessengerConfiguration : global::Gibraltar.Messaging.MessengerConfiguration
	{
		// Token: 0x06001C53 RID: 7251 RVA: 0x00063A38 File Offset: 0x00061C38
		internal FileMessengerConfiguration(string name, global::Gibraltar.Agent.SessionFileElement configuration, global::Gibraltar.Messaging.ServerConfiguration server) : base(name, typeof(global::Gibraltar.Messaging.FileMessenger).AssemblyQualifiedName)
		{
			this.Server = server;
			this.Initialize(configuration);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00063A70 File Offset: 0x00061C70
		internal FileMessengerConfiguration(string name, global::System.Xml.XmlNode gibraltarNode, global::Gibraltar.Messaging.ServerConfiguration server) : base(name, typeof(global::Gibraltar.Messaging.FileMessenger).AssemblyQualifiedName)
		{
			this.m_GibraltarNode = gibraltarNode;
			this.Server = server;
			global::Gibraltar.Agent.SessionFileElement sessionFileElement = new global::Gibraltar.Agent.SessionFileElement();
			this.Initialize(sessionFileElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("sessionFile");
			if (xmlNode != null)
			{
				this.Folder = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "folder", sessionFileElement.Folder);
				this.AutoFlushInterval = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "autoFlushInterval", sessionFileElement.AutoFlushInterval);
				this.IndexUpdateInterval = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "indexUpdateInterval", sessionFileElement.IndexUpdateInterval);
				this.MaxFileSize = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxFileSize", sessionFileElement.MaxFileSize);
				this.EnableFilePruning = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableFilePruning", sessionFileElement.EnableFilePruning);
				this.MaxLocalDiskUsage = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxLocalDiskUsage", sessionFileElement.MaxLocalDiskUsage);
				this.MaxLocalFileAge = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxLocalFileAge", sessionFileElement.MaxLocalFileAge);
				this.MinimumFreeDisk = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "minimumFreeDisk", sessionFileElement.MinimumFreeDisk);
				base.Enabled = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enabled", sessionFileElement.Enabled);
				base.ForceSynchronous = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "forceSynchronous", sessionFileElement.ForceSynchronous);
				base.MaxQueueLength = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxQueueLength", sessionFileElement.MaxQueueLength);
			}
			this.Sanitize();
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00063BC8 File Offset: 0x00061DC8
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x00063BD0 File Offset: 0x00061DD0
		public int AutoFlushInterval { get; set; }

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00063BDC File Offset: 0x00061DDC
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x00063BE4 File Offset: 0x00061DE4
		public string Folder { get; set; }

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x00063BF0 File Offset: 0x00061DF0
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x00063BF8 File Offset: 0x00061DF8
		public int IndexUpdateInterval { get; set; }

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00063C04 File Offset: 0x00061E04
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x00063C0C File Offset: 0x00061E0C
		public int MaxFileSize { get; set; }

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00063C18 File Offset: 0x00061E18
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x00063C20 File Offset: 0x00061E20
		public int MaxFileDuration { get; set; }

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00063C2C File Offset: 0x00061E2C
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x00063C34 File Offset: 0x00061E34
		public bool EnableFilePruning { get; set; }

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00063C40 File Offset: 0x00061E40
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00063C48 File Offset: 0x00061E48
		public int MaxLocalDiskUsage { get; set; }

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00063C54 File Offset: 0x00061E54
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x00063C5C File Offset: 0x00061E5C
		public int MaxLocalFileAge { get; set; }

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00063C68 File Offset: 0x00061E68
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x00063C70 File Offset: 0x00061E70
		public int MinimumFreeDisk { get; set; }

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00063C7C File Offset: 0x00061E7C
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x00063C84 File Offset: 0x00061E84
		internal global::Gibraltar.Messaging.ServerConfiguration Server { get; private set; }

		// Token: 0x06001C69 RID: 7273 RVA: 0x00063C90 File Offset: 0x00061E90
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.SessionFileElement sessionFileElement = new global::Gibraltar.Agent.SessionFileElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("sessionFile");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enabled", base.Enabled, sessionFileElement.Enabled);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "forceSynchronous", base.ForceSynchronous, sessionFileElement.ForceSynchronous);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxQueueLength", base.MaxQueueLength, sessionFileElement.MaxQueueLength);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "folder", this.Folder ?? string.Empty, sessionFileElement.Folder);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableFilePruning", this.EnableFilePruning, sessionFileElement.EnableFilePruning);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxFileSize", this.MaxFileSize, sessionFileElement.MaxFileSize);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxLocalDiskUsage", this.MaxLocalDiskUsage, sessionFileElement.MaxLocalDiskUsage);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxLocalFileAge", this.MaxLocalFileAge, sessionFileElement.MaxLocalFileAge);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "minimumFreeDisk", this.MinimumFreeDisk, sessionFileElement.MinimumFreeDisk);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "autoFlushInterval", this.AutoFlushInterval, sessionFileElement.AutoFlushInterval);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "indexUpdateInterval", this.IndexUpdateInterval, sessionFileElement.IndexUpdateInterval);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00063DDC File Offset: 0x00061FDC
		internal void Sanitize()
		{
			if (string.IsNullOrEmpty(this.Folder))
			{
				this.Folder = null;
			}
			if (this.AutoFlushInterval <= 0)
			{
				this.AutoFlushInterval = 15;
			}
			if (this.IndexUpdateInterval <= 0)
			{
				this.IndexUpdateInterval = 15;
			}
			if (this.MaxFileDuration < 1)
			{
				this.MaxFileDuration = 1576800;
			}
			if (this.MaxFileSize <= 0)
			{
				this.MaxFileSize = 1024;
			}
			if (this.MaxLocalDiskUsage <= 0)
			{
				this.MaxLocalDiskUsage = 0;
			}
			else if (this.MaxLocalDiskUsage < this.MaxFileSize)
			{
				this.MaxFileSize = this.MaxLocalDiskUsage;
			}
			if (this.MaxLocalFileAge <= 0)
			{
				this.MaxLocalFileAge = 0;
			}
			if (this.MinimumFreeDisk <= 0)
			{
				this.MinimumFreeDisk = 50;
			}
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

		// Token: 0x06001C6B RID: 7275 RVA: 0x00063EEC File Offset: 0x000620EC
		private void Initialize(global::Gibraltar.Agent.SessionFileElement configuration)
		{
			this.Folder = configuration.Folder;
			this.AutoFlushInterval = configuration.AutoFlushInterval;
			this.IndexUpdateInterval = configuration.IndexUpdateInterval;
			this.MaxFileSize = configuration.MaxFileSize;
			this.MaxFileDuration = configuration.MaxFileDuration;
			this.EnableFilePruning = configuration.EnableFilePruning;
			this.MaxLocalDiskUsage = configuration.MaxLocalDiskUsage;
			this.MaxLocalFileAge = configuration.MaxLocalFileAge;
			this.MinimumFreeDisk = configuration.MinimumFreeDisk;
			base.Enabled = configuration.Enabled;
			base.ForceSynchronous = configuration.ForceSynchronous;
			base.MaxQueueLength = configuration.MaxQueueLength;
		}

		// Token: 0x04000A59 RID: 2649
		private global::System.Xml.XmlNode m_GibraltarNode;
	}
}
