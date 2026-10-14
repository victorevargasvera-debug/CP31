using System;
using System.Xml;
using Gibraltar.Agent;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B4 RID: 436
	internal class ListenerConfiguration
	{
		// Token: 0x060013AB RID: 5035 RVA: 0x00039F2C File Offset: 0x0003812C
		internal ListenerConfiguration(global::Gibraltar.Agent.ListenerElement configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00039F3C File Offset: 0x0003813C
		internal ListenerConfiguration(global::System.Xml.XmlNode gibraltarNode)
		{
			this.m_GibraltarNode = gibraltarNode;
			global::Gibraltar.Agent.ListenerElement listenerElement = new global::Gibraltar.Agent.ListenerElement();
			this.Initialize(listenerElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("listener");
			if (xmlNode != null)
			{
				this.AutoTraceRegistration = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "autoTraceRegistration", listenerElement.AutoTraceRegistration);
				this.CatchUnhandledExceptions = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "catchUnhandledExceptions", listenerElement.CatchUnhandledExceptions);
				this.CatchApplicationExceptions = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "catchApplicationExceptions", listenerElement.CatchApplicationExceptions);
				this.ReportErrorsToUser = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "reportErrorsToUser", listenerElement.ReportErrorsToUser);
				this.EnableConsole = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableConsole", listenerElement.EnableConsole);
				this.EnableAssemblyEvents = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableAssemblyEvents", listenerElement.EnableAssemblyEvents);
				this.EnableAssemblyLoadFailureEvents = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableAssemblyLoadFailureEvents", listenerElement.EnableAssemblyLoadFailureEvents);
				this.EnableDiskPerformance = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableDiskPerformance", listenerElement.EnableDiskPerformance);
				this.EnableMemoryPerformance = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableMemoryPerformance", listenerElement.EnableMemoryPerformance);
				this.EnableNetworkEvents = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableNetworkEvents", listenerElement.EnableNetworkEvents);
				this.EnableNetworkPerformance = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableNetworkPerformance", listenerElement.EnableNetworkPerformance);
				this.EnablePowerEvents = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enablePowerEvents", listenerElement.EnablePowerEvents);
				this.EnableProcessPerformance = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableProcessPerformance", listenerElement.EnableProcessPerformance);
				this.EnableSystemPerformance = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableSystemPerformance", listenerElement.EnableSystemPerformance);
				this.EnableUserEvents = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableUserEvents", listenerElement.EnableUserEvents);
				this.EndSessionOnTraceClose = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "endSessionOnTraceClose", listenerElement.EndSessionOnTraceClose);
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0003A0EC File Offset: 0x000382EC
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x0003A0F4 File Offset: 0x000382F4
		public bool AutoTraceRegistration { get; set; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0003A100 File Offset: 0x00038300
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x0003A108 File Offset: 0x00038308
		public bool EnableConsole { get; set; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0003A114 File Offset: 0x00038314
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x0003A11C File Offset: 0x0003831C
		public bool EnableProcessPerformance { get; set; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x0003A128 File Offset: 0x00038328
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x0003A130 File Offset: 0x00038330
		public bool EnableDiskPerformance { get; set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0003A13C File Offset: 0x0003833C
		// (set) Token: 0x060013B6 RID: 5046 RVA: 0x0003A144 File Offset: 0x00038344
		public bool EnableMemoryPerformance { get; set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0003A150 File Offset: 0x00038350
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0003A158 File Offset: 0x00038358
		public bool EnableNetworkPerformance { get; set; }

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0003A164 File Offset: 0x00038364
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0003A16C File Offset: 0x0003836C
		public bool EnableSystemPerformance { get; set; }

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x0003A178 File Offset: 0x00038378
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x0003A180 File Offset: 0x00038380
		public bool EnableNetworkEvents { get; set; }

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0003A18C File Offset: 0x0003838C
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0003A194 File Offset: 0x00038394
		public bool EnablePowerEvents { get; set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x0003A1A0 File Offset: 0x000383A0
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0003A1A8 File Offset: 0x000383A8
		public bool EnableUserEvents { get; set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0003A1B4 File Offset: 0x000383B4
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x0003A1BC File Offset: 0x000383BC
		public bool EnableAssemblyEvents { get; set; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0003A1C8 File Offset: 0x000383C8
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x0003A1D0 File Offset: 0x000383D0
		public bool EnableAssemblyLoadFailureEvents { get; set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0003A1DC File Offset: 0x000383DC
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0003A1E4 File Offset: 0x000383E4
		public bool CatchUnhandledExceptions { get; set; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0003A1F0 File Offset: 0x000383F0
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0003A1F8 File Offset: 0x000383F8
		public bool CatchApplicationExceptions { get; set; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0003A204 File Offset: 0x00038404
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0003A20C File Offset: 0x0003840C
		public bool ReportErrorsToUser { get; set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0003A218 File Offset: 0x00038418
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0003A220 File Offset: 0x00038420
		public bool EndSessionOnTraceClose { get; set; }

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0003A22C File Offset: 0x0003842C
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0003A234 File Offset: 0x00038434
		public bool EnableCommandLine { get; set; }

		// Token: 0x060013CF RID: 5071 RVA: 0x0003A240 File Offset: 0x00038440
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.ListenerElement listenerElement = new global::Gibraltar.Agent.ListenerElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("listener");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "autoTraceRegistration", this.AutoTraceRegistration, listenerElement.AutoTraceRegistration);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "catchUnhandledExceptions", this.CatchUnhandledExceptions, listenerElement.CatchUnhandledExceptions);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "catchApplicationExceptions", this.CatchApplicationExceptions, listenerElement.CatchApplicationExceptions);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "reportErrorsToUser", this.ReportErrorsToUser, listenerElement.ReportErrorsToUser);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableCommandLine", this.EnableCommandLine, listenerElement.EnableCommandLine);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableConsole", this.EnableConsole, listenerElement.EnableConsole);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableAssemblyEvents", this.EnableAssemblyEvents, listenerElement.EnableAssemblyEvents);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableAssemblyLoadFailureEvents", this.EnableAssemblyLoadFailureEvents, listenerElement.EnableAssemblyLoadFailureEvents);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableDiskPerformance", this.EnableDiskPerformance, listenerElement.EnableDiskPerformance);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableMemoryPerformance", this.EnableMemoryPerformance, listenerElement.EnableMemoryPerformance);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableNetworkEvents", this.EnableNetworkEvents, listenerElement.EnableNetworkEvents);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableNetworkPerformance", this.EnableNetworkPerformance, listenerElement.EnableNetworkPerformance);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enablePowerEvents", this.EnablePowerEvents, listenerElement.EnablePowerEvents);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableProcessPerformance", this.EnableProcessPerformance, listenerElement.EnableProcessPerformance);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableSystemPerformance", this.EnableSystemPerformance, listenerElement.EnableSystemPerformance);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableUserEvents", this.EnableUserEvents, listenerElement.EnableUserEvents);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "endSessionOnTraceClose", this.EndSessionOnTraceClose, listenerElement.EndSessionOnTraceClose);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0003A408 File Offset: 0x00038608
		internal void Sanitize()
		{
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0003A40C File Offset: 0x0003860C
		private void Initialize(global::Gibraltar.Agent.ListenerElement configuration)
		{
			this.AutoTraceRegistration = configuration.AutoTraceRegistration;
			this.CatchUnhandledExceptions = configuration.CatchUnhandledExceptions;
			this.CatchApplicationExceptions = configuration.CatchApplicationExceptions;
			this.ReportErrorsToUser = configuration.ReportErrorsToUser;
			this.EnableCommandLine = configuration.EnableCommandLine;
			this.EnableConsole = configuration.EnableConsole;
			this.EnableAssemblyEvents = configuration.EnableAssemblyEvents;
			this.EnableAssemblyLoadFailureEvents = configuration.EnableAssemblyLoadFailureEvents;
			this.EnableDiskPerformance = configuration.EnableDiskPerformance;
			this.EnableMemoryPerformance = configuration.EnableMemoryPerformance;
			this.EnableNetworkEvents = configuration.EnableNetworkEvents;
			this.EnableNetworkPerformance = configuration.EnableNetworkPerformance;
			this.EnablePowerEvents = configuration.EnablePowerEvents;
			this.EnableProcessPerformance = configuration.EnableProcessPerformance;
			this.EnableSystemPerformance = configuration.EnableSystemPerformance;
			this.EnableUserEvents = configuration.EnableUserEvents;
			this.EndSessionOnTraceClose = configuration.EndSessionOnTraceClose;
		}

		// Token: 0x04000685 RID: 1669
		private readonly global::System.Xml.XmlNode m_GibraltarNode;
	}
}
