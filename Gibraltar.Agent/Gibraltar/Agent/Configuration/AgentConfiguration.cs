using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x0200003F RID: 63
	public sealed class AgentConfiguration
	{
		// Token: 0x0600037E RID: 894 RVA: 0x0000AF94 File Offset: 0x00009194
		public AgentConfiguration()
		{
			this.m_WrappedAgentConfiguration = new global::Gibraltar.Monitor.AgentConfiguration();
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public AgentConfiguration(string fileName)
		{
			if (string.IsNullOrEmpty(fileName))
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			if (!global::System.IO.File.Exists(fileName))
			{
				throw new global::System.IO.FileNotFoundException("The configuration file couldn't be found", fileName);
			}
			xmlDocument.Load(fileName);
			global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode("//gibraltar");
			if (xmlNode == null)
			{
				throw new global::System.IO.InvalidDataException("No gibraltar configuration section could be found in the provided XML file.");
			}
			this.m_WrappedAgentConfiguration = new global::Gibraltar.Monitor.AgentConfiguration(xmlNode);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000B028 File Offset: 0x00009228
		internal AgentConfiguration(global::Gibraltar.Monitor.AgentConfiguration wrappedConfiguration)
		{
			this.m_WrappedAgentConfiguration = wrappedConfiguration;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000B038 File Offset: 0x00009238
		public global::Gibraltar.Agent.Configuration.AutoSendConsentConfiguration AutoSendConsent
		{
			get
			{
				if (this.m_AutoSendConsent == null)
				{
					this.m_AutoSendConsent = new global::Gibraltar.Agent.Configuration.AutoSendConsentConfiguration(this.m_WrappedAgentConfiguration.AutoSendConsent);
				}
				return this.m_AutoSendConsent;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000B064 File Offset: 0x00009264
		public global::Gibraltar.Agent.Configuration.EmailConfiguration Email
		{
			get
			{
				if (this.m_Email == null)
				{
					this.m_Email = new global::Gibraltar.Agent.Configuration.EmailConfiguration(this.m_WrappedAgentConfiguration.Email);
				}
				return this.m_Email;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000B090 File Offset: 0x00009290
		public global::Gibraltar.Agent.Configuration.ListenerConfiguration Listener
		{
			get
			{
				if (this.m_Listener == null)
				{
					this.m_Listener = new global::Gibraltar.Agent.Configuration.ListenerConfiguration(this.m_WrappedAgentConfiguration.Listener);
				}
				return this.m_Listener;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000B0BC File Offset: 0x000092BC
		public global::Gibraltar.Agent.Configuration.SessionFileConfiguration SessionFile
		{
			get
			{
				if (this.m_SessionFile == null)
				{
					this.m_SessionFile = new global::Gibraltar.Agent.Configuration.SessionFileConfiguration(this.m_WrappedAgentConfiguration.SessionFile);
				}
				return this.m_SessionFile;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000B0E8 File Offset: 0x000092E8
		public global::Gibraltar.Agent.Configuration.PackagerConfiguration Packager
		{
			get
			{
				if (this.m_Packager == null)
				{
					this.m_Packager = new global::Gibraltar.Agent.Configuration.PackagerConfiguration(this.m_WrappedAgentConfiguration.Packager);
				}
				return this.m_Packager;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000B114 File Offset: 0x00009314
		public global::Gibraltar.Agent.Configuration.PublisherConfiguration Publisher
		{
			get
			{
				if (this.m_Publisher == null)
				{
					this.m_Publisher = new global::Gibraltar.Agent.Configuration.PublisherConfiguration(this.m_WrappedAgentConfiguration.Publisher);
				}
				return this.m_Publisher;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000B140 File Offset: 0x00009340
		public global::Gibraltar.Agent.Configuration.ServerConfiguration Server
		{
			get
			{
				if (this.m_Server == null)
				{
					this.m_Server = new global::Gibraltar.Agent.Configuration.ServerConfiguration(this.m_WrappedAgentConfiguration.Server);
				}
				return this.m_Server;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000B16C File Offset: 0x0000936C
		public global::Gibraltar.Agent.Configuration.ViewerConfiguration Viewer
		{
			get
			{
				if (this.m_Viewer == null)
				{
					this.m_Viewer = new global::Gibraltar.Agent.Configuration.ViewerConfiguration(this.m_WrappedAgentConfiguration.Viewer);
				}
				return this.m_Viewer;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000B198 File Offset: 0x00009398
		public global::Gibraltar.Agent.Configuration.NetworkViewerConfiguration NetworkViewer
		{
			get
			{
				if (this.m_Network == null)
				{
					this.m_Network = new global::Gibraltar.Agent.Configuration.NetworkViewerConfiguration(this.m_WrappedAgentConfiguration.NetworkViewer);
				}
				return this.m_Network;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				return this.m_WrappedAgentConfiguration.Properties;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public void Save(string fileName)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			global::System.Xml.XmlDeclaration newChild = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);
			global::System.Xml.XmlElement newChild2 = xmlDocument.CreateElement("gibraltar");
			xmlDocument.InsertBefore(newChild, xmlDocument.DocumentElement);
			xmlDocument.AppendChild(newChild2);
			global::System.Xml.XmlNode gibraltarNode = xmlDocument.SelectSingleNode("//gibraltar");
			this.m_WrappedAgentConfiguration.Save(gibraltarNode);
			global::System.IO.File.Delete(fileName);
			xmlDocument.Save(fileName);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000B244 File Offset: 0x00009444
		internal global::Gibraltar.Monitor.AgentConfiguration WrappedObject
		{
			get
			{
				return this.m_WrappedAgentConfiguration;
			}
		}

		// Token: 0x040000BF RID: 191
		private const string GibraltarNode = "gibraltar";

		// Token: 0x040000C0 RID: 192
		private const string XPathGibraltar = "//gibraltar";

		// Token: 0x040000C1 RID: 193
		private readonly global::Gibraltar.Monitor.AgentConfiguration m_WrappedAgentConfiguration;

		// Token: 0x040000C2 RID: 194
		private global::Gibraltar.Agent.Configuration.AutoSendConsentConfiguration m_AutoSendConsent;

		// Token: 0x040000C3 RID: 195
		private global::Gibraltar.Agent.Configuration.EmailConfiguration m_Email;

		// Token: 0x040000C4 RID: 196
		private global::Gibraltar.Agent.Configuration.PublisherConfiguration m_Publisher;

		// Token: 0x040000C5 RID: 197
		private global::Gibraltar.Agent.Configuration.ListenerConfiguration m_Listener;

		// Token: 0x040000C6 RID: 198
		private global::Gibraltar.Agent.Configuration.SessionFileConfiguration m_SessionFile;

		// Token: 0x040000C7 RID: 199
		private global::Gibraltar.Agent.Configuration.ServerConfiguration m_Server;

		// Token: 0x040000C8 RID: 200
		private global::Gibraltar.Agent.Configuration.ViewerConfiguration m_Viewer;

		// Token: 0x040000C9 RID: 201
		private global::Gibraltar.Agent.Configuration.PackagerConfiguration m_Packager;

		// Token: 0x040000CA RID: 202
		private global::Gibraltar.Agent.Configuration.NetworkViewerConfiguration m_Network;
	}
}
