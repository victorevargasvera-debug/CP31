using System;
using System.Xml;
using Gibraltar.Agent;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000241 RID: 577
	internal class ViewerMessengerConfiguration : global::Gibraltar.Messaging.MessengerConfiguration
	{
		// Token: 0x06001CF3 RID: 7411 RVA: 0x00066028 File Offset: 0x00064228
		internal ViewerMessengerConfiguration(string name, global::Gibraltar.Agent.ViewerElement configuration) : base(name, typeof(global::Gibraltar.Messaging.MonitorMessenger).AssemblyQualifiedName)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00066048 File Offset: 0x00064248
		internal ViewerMessengerConfiguration(string name, global::System.Xml.XmlNode gibraltarNode) : base(name, typeof(global::Gibraltar.Messaging.MonitorMessenger).AssemblyQualifiedName)
		{
			this.m_GibraltarNode = gibraltarNode;
			global::Gibraltar.Agent.ViewerElement viewerElement = new global::Gibraltar.Agent.ViewerElement();
			this.Initialize(viewerElement);
			global::System.Xml.XmlNode xmlNode = gibraltarNode.SelectSingleNode("viewer");
			if (xmlNode != null)
			{
				this.ClearMessagesButtonText = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "clearMessagesButtonText", viewerElement.ClearMessagesButtonText);
				this.ClearMessagesButtonTextVisible = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "clearMessagesButtonTextVisible", viewerElement.ClearMessagesButtonTextVisible);
				this.DefaultFilterLevel = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<global::Loupe.Extensibility.Data.LogMessageSeverity>(xmlNode, "defaultFilterLevel", viewerElement.DefaultFilterLevel);
				this.EnableIndependentSeverityFilters = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableIndependentSeverityFilters", viewerElement.EnableIndependentSeverityFilters);
				this.EnableMultiSelection = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enableMultiSelection", viewerElement.EnableMultiSelection);
				base.ForceSynchronous = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "forceSynchronous", viewerElement.ForceSynchronous);
				this.FormTitleText = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "formTitleText", viewerElement.FormTitleText);
				this.ShowToolBar = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "showToolBar", viewerElement.ShowToolBar);
				this.ShowVerboseMessages = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "showVerboseMessages", viewerElement.ShowVerboseMessages);
				this.HotKey = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "hotKey", viewerElement.HotKey);
				this.PauseButtonText = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "pauseButtonText", viewerElement.PauseButtonText);
				this.PauseButtonTextVisible = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "pauseButtonTextVisible", viewerElement.PauseButtonTextVisible);
				this.ResetSearchButtonText = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "resetSearchButtonText", viewerElement.ResetSearchButtonText);
				this.ResetSearchButtonTextVisible = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "resetSearchButtonTextVisible", viewerElement.ResetSearchButtonTextVisible);
				this.RunButtonText = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<string>(xmlNode, "runButtonText", viewerElement.RunButtonText);
				this.RunButtonTextVisible = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "runButtonTextVisible", viewerElement.RunButtonTextVisible);
				this.ShowDetailsButton = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "showDetailsButton", viewerElement.ShowDetailsButton);
				this.ShowDetailsInGrid = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "showDetailsInGrid", viewerElement.ShowDetailsInGrid);
				this.ShowDetailsInTooltips = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "showDetailsInTooltips", viewerElement.ShowDetailsInTooltips);
				this.ShowMessageCounters = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "showMessageCounters", viewerElement.ShowMessageCounters);
				base.Enabled = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "enabled", viewerElement.Enabled);
				base.ForceSynchronous = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<bool>(xmlNode, "forceSynchronous", viewerElement.ForceSynchronous);
				base.MaxQueueLength = global::Gibraltar.Monitor.AgentConfiguration.ReadValue<int>(xmlNode, "maxQueueLength", viewerElement.MaxQueueLength);
			}
			this.Sanitize();
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x000662AC File Offset: 0x000644AC
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x000662B4 File Offset: 0x000644B4
		public string HotKey { get; set; }

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x000662C0 File Offset: 0x000644C0
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x000662C8 File Offset: 0x000644C8
		public int MaxMessages { get; set; }

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x000662D4 File Offset: 0x000644D4
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x000662DC File Offset: 0x000644DC
		public bool ShowVerboseMessages { get; set; }

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x000662E8 File Offset: 0x000644E8
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x000662F0 File Offset: 0x000644F0
		public string FormTitleText { get; set; }

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x000662FC File Offset: 0x000644FC
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x00066304 File Offset: 0x00064504
		public global::Loupe.Extensibility.Data.LogMessageSeverity DefaultFilterLevel { get; set; }

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x00066310 File Offset: 0x00064510
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x00066318 File Offset: 0x00064518
		public bool EnableIndependentSeverityFilters { get; set; }

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00066324 File Offset: 0x00064524
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0006632C File Offset: 0x0006452C
		public bool ShowDetailsButton { get; set; }

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00066338 File Offset: 0x00064538
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x00066340 File Offset: 0x00064540
		public bool ShowDetailsInGrid { get; set; }

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0006634C File Offset: 0x0006454C
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x00066354 File Offset: 0x00064554
		public bool ShowDetailsInTooltips { get; set; }

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x00066360 File Offset: 0x00064560
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x00066368 File Offset: 0x00064568
		public bool ShowMessageCounters { get; set; }

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00066374 File Offset: 0x00064574
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0006637C File Offset: 0x0006457C
		public string RunButtonText { get; set; }

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00066388 File Offset: 0x00064588
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00066390 File Offset: 0x00064590
		public bool RunButtonTextVisible { get; set; }

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0006639C File Offset: 0x0006459C
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x000663A4 File Offset: 0x000645A4
		public string PauseButtonText { get; set; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000663B0 File Offset: 0x000645B0
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x000663B8 File Offset: 0x000645B8
		public bool PauseButtonTextVisible { get; set; }

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000663C4 File Offset: 0x000645C4
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x000663CC File Offset: 0x000645CC
		public string ResetSearchButtonText { get; set; }

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x000663D8 File Offset: 0x000645D8
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x000663E0 File Offset: 0x000645E0
		public bool ResetSearchButtonTextVisible { get; set; }

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x000663EC File Offset: 0x000645EC
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x000663F4 File Offset: 0x000645F4
		public string ClearMessagesButtonText { get; set; }

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00066400 File Offset: 0x00064600
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x00066408 File Offset: 0x00064608
		public bool ClearMessagesButtonTextVisible { get; set; }

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00066414 File Offset: 0x00064614
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0006641C File Offset: 0x0006461C
		public bool ShowToolBar { get; set; }

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00066428 File Offset: 0x00064628
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x00066430 File Offset: 0x00064630
		public bool EnableMultiSelection { get; set; }

		// Token: 0x06001D1D RID: 7453 RVA: 0x0006643C File Offset: 0x0006463C
		public void Save(global::System.Xml.XmlNode gibraltarNode)
		{
			global::Gibraltar.Agent.ViewerElement viewerElement = new global::Gibraltar.Agent.ViewerElement();
			global::System.Xml.XmlNode xmlNode = gibraltarNode.OwnerDocument.CreateElement("sessionFile");
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enabled", base.Enabled, viewerElement.Enabled);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "forceSynchronous", base.ForceSynchronous, viewerElement.ForceSynchronous);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxQueueLength", base.MaxQueueLength, viewerElement.MaxQueueLength);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "hotKey", this.HotKey ?? string.Empty, viewerElement.HotKey);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<int>(xmlNode, "maxMessages", this.MaxMessages, viewerElement.MaxMessages);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "clearMessagesButtonText", this.ClearMessagesButtonText ?? string.Empty, viewerElement.ClearMessagesButtonText);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "clearMessagesButtonTextVisible", this.ClearMessagesButtonTextVisible, viewerElement.ClearMessagesButtonTextVisible);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<global::Loupe.Extensibility.Data.LogMessageSeverity>(xmlNode, "defaultFilterLevel", this.DefaultFilterLevel, viewerElement.DefaultFilterLevel);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableIndependentSeverityFilters", this.EnableIndependentSeverityFilters, viewerElement.EnableIndependentSeverityFilters);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "enableMultiSelection", this.EnableMultiSelection, viewerElement.EnableMultiSelection);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "formTitleText", this.FormTitleText ?? string.Empty, viewerElement.FormTitleText);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "pauseButtonText", this.PauseButtonText ?? string.Empty, viewerElement.PauseButtonText);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "pauseButtonTextVisible", this.PauseButtonTextVisible, viewerElement.PauseButtonTextVisible);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "resetSearchButtonText", this.ResetSearchButtonText ?? string.Empty, viewerElement.ResetSearchButtonText);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "resetSearchButtonTextVisible", this.ResetSearchButtonTextVisible, viewerElement.ResetSearchButtonTextVisible);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<string>(xmlNode, "runButtonText", this.RunButtonText ?? string.Empty, viewerElement.RunButtonText);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "runButtonTextVisible", this.RunButtonTextVisible, viewerElement.RunButtonTextVisible);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "showToolBar", this.ShowToolBar, viewerElement.ShowToolBar);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "showVerboseMessages", this.ShowVerboseMessages, viewerElement.ShowVerboseMessages);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "showDetailsButton", this.ShowDetailsButton, viewerElement.ShowDetailsButton);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "showDetailsInGrid", this.ShowDetailsInGrid, viewerElement.ShowDetailsInGrid);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "showDetailsInTooltips", this.ShowDetailsInTooltips, viewerElement.ShowDetailsInTooltips);
			global::Gibraltar.Monitor.AgentConfiguration.WriteValue<bool>(xmlNode, "showMessageCounters", this.ShowMessageCounters, viewerElement.ShowMessageCounters);
			if (xmlNode.Attributes.Count > 0)
			{
				gibraltarNode.AppendChild(xmlNode);
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x000666D8 File Offset: 0x000648D8
		internal void Sanitize()
		{
			if (string.IsNullOrEmpty(this.HotKey))
			{
				this.HotKey = "Ctrl-Alt-F5";
			}
			if (this.MaxMessages <= 0)
			{
				this.MaxMessages = 10000;
			}
			if (string.IsNullOrEmpty(this.FormTitleText))
			{
				this.FormTitleText = "Gibraltar Live Log Viewer";
			}
			if (string.IsNullOrEmpty(this.PauseButtonText))
			{
				this.FormTitleText = "Pause";
			}
			if (string.IsNullOrEmpty(this.ResetSearchButtonText))
			{
				this.FormTitleText = "Reset";
			}
			if (string.IsNullOrEmpty(this.ClearMessagesButtonText))
			{
				this.FormTitleText = "Clear";
			}
			if (string.IsNullOrEmpty(this.RunButtonText))
			{
				this.FormTitleText = "Click to Auto Refresh";
			}
			if (base.MaxQueueLength <= 0)
			{
				base.MaxQueueLength = 2000;
			}
			if (base.MaxQueueLength > 50000)
			{
				base.MaxQueueLength = 50000;
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000667D4 File Offset: 0x000649D4
		private void Initialize(global::Gibraltar.Agent.ViewerElement configuration)
		{
			base.Enabled = configuration.Enabled;
			base.ForceSynchronous = configuration.ForceSynchronous;
			base.MaxQueueLength = configuration.MaxQueueLength;
			this.ClearMessagesButtonText = configuration.ClearMessagesButtonText;
			this.ClearMessagesButtonTextVisible = configuration.ClearMessagesButtonTextVisible;
			this.DefaultFilterLevel = configuration.DefaultFilterLevel;
			this.EnableIndependentSeverityFilters = configuration.EnableIndependentSeverityFilters;
			this.EnableMultiSelection = configuration.EnableMultiSelection;
			this.MaxMessages = configuration.MaxMessages;
			this.FormTitleText = configuration.FormTitleText;
			this.ShowToolBar = configuration.ShowToolBar;
			this.ShowVerboseMessages = configuration.ShowVerboseMessages;
			this.HotKey = configuration.HotKey;
			this.PauseButtonText = configuration.PauseButtonText;
			this.PauseButtonTextVisible = configuration.PauseButtonTextVisible;
			this.ResetSearchButtonText = configuration.ResetSearchButtonText;
			this.ResetSearchButtonTextVisible = configuration.ResetSearchButtonTextVisible;
			this.RunButtonText = configuration.RunButtonText;
			this.RunButtonTextVisible = configuration.RunButtonTextVisible;
			this.ShowDetailsButton = configuration.ShowDetailsButton;
			this.ShowDetailsInGrid = configuration.ShowDetailsInGrid;
			this.ShowDetailsInTooltips = configuration.ShowDetailsInTooltips;
			this.ShowMessageCounters = configuration.ShowMessageCounters;
		}

		// Token: 0x04000AB7 RID: 2743
		private global::System.Xml.XmlNode m_GibraltarNode;

		// Token: 0x04000AB8 RID: 2744
		public const string DefaultHotKey = "Ctrl-Alt-F5";
	}
}
