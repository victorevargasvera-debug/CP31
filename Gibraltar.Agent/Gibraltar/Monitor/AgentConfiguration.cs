using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Xml;
using Gibraltar.Agent;
using Gibraltar.Messaging;

namespace Gibraltar.Monitor
{
	// Token: 0x02000182 RID: 386
	internal class AgentConfiguration
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
		public AgentConfiguration()
		{
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0002C4B0 File Offset: 0x0002A6B0
		public AgentConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			if (gibraltarNode == null)
			{
				throw new global::System.ArgumentNullException("gibraltarNode");
			}
			this.m_GibraltarNode = gibraltarNode;
			global::Gibraltar.Monitor.EmailConfiguration email = this.Email;
			global::Gibraltar.Monitor.PublisherConfiguration publisher = this.Publisher;
			global::Gibraltar.Monitor.ListenerConfiguration listener = this.Listener;
			global::Gibraltar.Messaging.FileMessengerConfiguration sessionFile = this.SessionFile;
			global::Gibraltar.Messaging.ViewerMessengerConfiguration viewer = this.Viewer;
			global::Gibraltar.Monitor.PackagerConfiguration packager = this.Packager;
			global::Gibraltar.Messaging.ServerConfiguration server = this.Server;
			global::Gibraltar.Messaging.NetworkMessengerConfiguration networkViewer = this.NetworkViewer;
			global::Gibraltar.Monitor.AutoSendConsentConfiguration autoSendConsent = this.AutoSendConsent;
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0002C520 File Offset: 0x0002A720
		public global::Gibraltar.Monitor.AutoSendConsentConfiguration AutoSendConsent
		{
			get
			{
				if (this.m_Consent == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Consent = new global::Gibraltar.Monitor.AutoSendConsentConfiguration(this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.AutoSendConsentElement autoSendConsentElement = null;
						try
						{
							autoSendConsentElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/autoSendConsent") as global::Gibraltar.Agent.AutoSendConsentElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Consent = ((autoSendConsentElement == null) ? new global::Gibraltar.Monitor.AutoSendConsentConfiguration(new global::Gibraltar.Agent.AutoSendConsentElement()) : new global::Gibraltar.Monitor.AutoSendConsentConfiguration(autoSendConsentElement));
					}
				}
				return this.m_Consent;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0002C5B4 File Offset: 0x0002A7B4
		public global::Gibraltar.Monitor.ListenerConfiguration Listener
		{
			get
			{
				if (this.m_Listener == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Listener = new global::Gibraltar.Monitor.ListenerConfiguration(this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.ListenerElement listenerElement = null;
						try
						{
							listenerElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/listener") as global::Gibraltar.Agent.ListenerElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Listener = ((listenerElement == null) ? new global::Gibraltar.Monitor.ListenerConfiguration(new global::Gibraltar.Agent.ListenerElement()) : new global::Gibraltar.Monitor.ListenerConfiguration(listenerElement));
					}
				}
				return this.m_Listener;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0002C648 File Offset: 0x0002A848
		public global::Gibraltar.Monitor.EmailConfiguration Email
		{
			get
			{
				if (this.m_Email == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Email = new global::Gibraltar.Monitor.EmailConfiguration(this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.EmailElement emailElement = null;
						try
						{
							emailElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/email") as global::Gibraltar.Agent.EmailElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Email = ((emailElement == null) ? new global::Gibraltar.Monitor.EmailConfiguration(new global::Gibraltar.Agent.EmailElement()) : new global::Gibraltar.Monitor.EmailConfiguration(emailElement));
					}
				}
				return this.m_Email;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0002C6DC File Offset: 0x0002A8DC
		public global::Gibraltar.Messaging.FileMessengerConfiguration SessionFile
		{
			get
			{
				if (this.m_Log == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Log = new global::Gibraltar.Messaging.FileMessengerConfiguration("log", this.m_GibraltarNode, this.Server);
					}
					else
					{
						global::Gibraltar.Agent.SessionFileElement sessionFileElement = null;
						try
						{
							sessionFileElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/sessionFile") as global::Gibraltar.Agent.SessionFileElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Log = ((sessionFileElement == null) ? new global::Gibraltar.Messaging.FileMessengerConfiguration("log", new global::Gibraltar.Agent.SessionFileElement(), this.Server) : new global::Gibraltar.Messaging.FileMessengerConfiguration("log", sessionFileElement, this.Server));
					}
				}
				return this.m_Log;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0002C790 File Offset: 0x0002A990
		public global::Gibraltar.Messaging.NetworkMessengerConfiguration NetworkViewer
		{
			get
			{
				if (this.m_Network == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Network = new global::Gibraltar.Messaging.NetworkMessengerConfiguration("networkViewer", this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.NetworkViewerElement networkViewerElement = null;
						try
						{
							networkViewerElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/networkViewer") as global::Gibraltar.Agent.NetworkViewerElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Network = ((networkViewerElement == null) ? new global::Gibraltar.Messaging.NetworkMessengerConfiguration("networkViewer", new global::Gibraltar.Agent.NetworkViewerElement()) : new global::Gibraltar.Messaging.NetworkMessengerConfiguration("networkViewer", networkViewerElement));
					}
				}
				return this.m_Network;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0002C830 File Offset: 0x0002AA30
		public global::Gibraltar.Monitor.PackagerConfiguration Packager
		{
			get
			{
				if (this.m_Packager == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Packager = new global::Gibraltar.Monitor.PackagerConfiguration(this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.PackagerElement packagerElement = null;
						try
						{
							packagerElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/packager") as global::Gibraltar.Agent.PackagerElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Packager = ((packagerElement == null) ? new global::Gibraltar.Monitor.PackagerConfiguration(new global::Gibraltar.Agent.PackagerElement()) : new global::Gibraltar.Monitor.PackagerConfiguration(packagerElement));
					}
				}
				return this.m_Packager;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
		public global::Gibraltar.Monitor.PublisherConfiguration Publisher
		{
			get
			{
				if (this.m_Publisher == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Publisher = new global::Gibraltar.Monitor.PublisherConfiguration(this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.PublisherElement publisherElement = null;
						try
						{
							publisherElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/publisher") as global::Gibraltar.Agent.PublisherElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Publisher = ((publisherElement == null) ? new global::Gibraltar.Monitor.PublisherConfiguration(new global::Gibraltar.Agent.PublisherElement()) : new global::Gibraltar.Monitor.PublisherConfiguration(publisherElement));
					}
				}
				return this.m_Publisher;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0002C958 File Offset: 0x0002AB58
		public global::Gibraltar.Messaging.ServerConfiguration Server
		{
			get
			{
				if (this.m_Server == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Server = new global::Gibraltar.Messaging.ServerConfiguration(this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.ServerElement serverElement = null;
						try
						{
							serverElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/server") as global::Gibraltar.Agent.ServerElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Server = ((serverElement == null) ? new global::Gibraltar.Messaging.ServerConfiguration(new global::Gibraltar.Agent.ServerElement()) : new global::Gibraltar.Messaging.ServerConfiguration(serverElement));
					}
				}
				return this.m_Server;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0002C9EC File Offset: 0x0002ABEC
		public global::Gibraltar.Messaging.ViewerMessengerConfiguration Viewer
		{
			get
			{
				if (this.m_Viewer == null)
				{
					if (this.m_GibraltarNode != null)
					{
						this.m_Viewer = new global::Gibraltar.Messaging.ViewerMessengerConfiguration("viewer", this.m_GibraltarNode);
					}
					else
					{
						global::Gibraltar.Agent.ViewerElement viewerElement = null;
						try
						{
							viewerElement = (global::System.Configuration.ConfigurationManager.GetSection("gibraltar/viewer") as global::Gibraltar.Agent.ViewerElement);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
						this.m_Viewer = ((viewerElement == null) ? new global::Gibraltar.Messaging.ViewerMessengerConfiguration("viewer", new global::Gibraltar.Agent.ViewerElement()) : new global::Gibraltar.Messaging.ViewerMessengerConfiguration("viewer", viewerElement));
					}
				}
				return this.m_Viewer;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				if (this.m_Properties == null)
				{
					this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>();
					if (this.m_GibraltarNode == null)
					{
						try
						{
							global::System.Collections.Specialized.NameValueCollection nameValueCollection = (global::System.Collections.Specialized.NameValueCollection)global::System.Configuration.ConfigurationManager.GetSection("gibraltar/properties");
							if (nameValueCollection != null)
							{
								for (int i = 0; i < nameValueCollection.Count; i++)
								{
									try
									{
										this.m_Properties.Add(nameValueCollection.GetKey(i), nameValueCollection[i]);
									}
									catch
									{
									}
								}
							}
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
					}
				}
				return this.m_Properties;
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			gibraltarNode.RemoveAll();
			if (this.Email != null)
			{
				this.Email.Save(gibraltarNode);
			}
			if (this.Listener != null)
			{
				this.Listener.Save(gibraltarNode);
			}
			if (this.Packager != null)
			{
				this.Packager.Save(gibraltarNode);
			}
			if (this.Publisher != null)
			{
				this.Publisher.Save(gibraltarNode);
			}
			if (this.SessionFile != null)
			{
				this.SessionFile.Save(gibraltarNode);
			}
			if (this.Viewer != null)
			{
				this.Viewer.Save(gibraltarNode);
			}
			if (this.Server != null)
			{
				this.Server.Save(gibraltarNode);
			}
			if (this.AutoSendConsent != null)
			{
				this.AutoSendConsent.Save(gibraltarNode);
			}
			if (this.NetworkViewer != null)
			{
				this.NetworkViewer.Save(gibraltarNode);
			}
			global::System.Collections.Generic.Dictionary<string, string> properties = this.m_Properties;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002CC2C File Offset: 0x0002AE2C
		internal void Sanitize()
		{
			this.Email.Sanitize();
			this.Listener.Sanitize();
			this.Packager.Sanitize();
			this.Publisher.Sanitize();
			this.SessionFile.Sanitize();
			this.Viewer.Sanitize();
			this.Server.Sanitize();
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0002CC8C File Offset: 0x0002AE8C
		internal static T ReadValue<T>(global::System.Xml.XmlNode node, string name, T defaultValue)
		{
			T result = defaultValue;
			global::System.Xml.XmlNode namedItem = node.Attributes.GetNamedItem(name);
			if (namedItem != null)
			{
				result = (T)((object)global::System.Convert.ChangeType(namedItem.Value, typeof(T)));
			}
			return result;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		internal static void WriteValue<T>(global::System.Xml.XmlNode node, string name, T value, T defaultValue)
		{
			if (global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(value, defaultValue))
			{
				return;
			}
			bool flag = typeof(T) == typeof(bool);
			global::System.Xml.XmlAttribute xmlAttribute = node.OwnerDocument.CreateAttribute(name);
			xmlAttribute.Value = (value.Equals(null) ? string.Empty : (flag ? value.ToString().ToLowerInvariant() : value.ToString()));
			node.Attributes.Append(xmlAttribute);
		}

		// Token: 0x04000567 RID: 1383
		private readonly global::System.Xml.XmlNode m_GibraltarNode;

		// Token: 0x04000568 RID: 1384
		private global::Gibraltar.Monitor.EmailConfiguration m_Email;

		// Token: 0x04000569 RID: 1385
		private global::Gibraltar.Monitor.PublisherConfiguration m_Publisher;

		// Token: 0x0400056A RID: 1386
		private global::Gibraltar.Monitor.ListenerConfiguration m_Listener;

		// Token: 0x0400056B RID: 1387
		private global::Gibraltar.Messaging.FileMessengerConfiguration m_Log;

		// Token: 0x0400056C RID: 1388
		private global::Gibraltar.Messaging.ViewerMessengerConfiguration m_Viewer;

		// Token: 0x0400056D RID: 1389
		private global::Gibraltar.Monitor.PackagerConfiguration m_Packager;

		// Token: 0x0400056E RID: 1390
		private global::Gibraltar.Messaging.ServerConfiguration m_Server;

		// Token: 0x0400056F RID: 1391
		private global::Gibraltar.Monitor.AutoSendConsentConfiguration m_Consent;

		// Token: 0x04000570 RID: 1392
		private global::Gibraltar.Messaging.NetworkMessengerConfiguration m_Network;

		// Token: 0x04000571 RID: 1393
		private global::System.Collections.Generic.Dictionary<string, string> m_Properties;
	}
}
