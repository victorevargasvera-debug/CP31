using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Windows;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Windows
{
	// Token: 0x02000014 RID: 20
	[global::System.ComponentModel.DefaultProperty("UnhandledExceptionBehavior")]
	[global::System.ComponentModel.DefaultEvent("MessageChanged")]
	public sealed class LiveLogViewer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600012F RID: 303 RVA: 0x0000511C File Offset: 0x0000331C
		// (remove) Token: 0x06000130 RID: 304 RVA: 0x00005158 File Offset: 0x00003358
		private event global::Gibraltar.Agent.Log.MessageFilterEventHandler m_MessageFilterEvent;

		// Token: 0x06000131 RID: 305 RVA: 0x00005194 File Offset: 0x00003394
		public LiveLogViewer()
		{
			this.InitializeComponent();
			this.internalLogViewer.MessageChanged += this.LiveLogViwer_MessageChange;
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000132 RID: 306 RVA: 0x000051C4 File Offset: 0x000033C4
		// (remove) Token: 0x06000133 RID: 307 RVA: 0x00005200 File Offset: 0x00003400
		public event global::Gibraltar.Agent.Windows.MessageChangedEventHandler MessageChanged;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000134 RID: 308 RVA: 0x0000523C File Offset: 0x0000343C
		// (remove) Token: 0x06000135 RID: 309 RVA: 0x000052A4 File Offset: 0x000034A4
		public event global::Gibraltar.Agent.Log.MessageFilterEventHandler MessageFilter
		{
			add
			{
				if (value == null)
				{
					return;
				}
				object messageEventLock = this.m_MessageEventLock;
				lock (messageEventLock)
				{
					if (this.m_MessageFilterEvent == null)
					{
						this.internalLogViewer.MessageFilter += this.LiveViewer_MessageFilterEvent;
					}
					this.m_MessageFilterEvent += value;
				}
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				object messageEventLock = this.m_MessageEventLock;
				lock (messageEventLock)
				{
					if (this.m_MessageFilterEvent != null)
					{
						this.m_MessageFilterEvent -= value;
						if (this.m_MessageFilterEvent == null)
						{
							this.internalLogViewer.MessageFilter -= this.LiveViewer_MessageFilterEvent;
						}
					}
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000531C File Offset: 0x0000351C
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000532C File Offset: 0x0000352C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether to retrieve buffered messages from before the creation of this instance.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool GetPriorMessages
		{
			get
			{
				return this.internalLogViewer.GetPriorMessages;
			}
			set
			{
				this.internalLogViewer.GetPriorMessages = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000533C File Offset: 0x0000353C
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000534C File Offset: 0x0000354C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies how many messages to buffer in the viewer.  Set to zero for unlimited buffer size.")]
		[global::System.ComponentModel.DefaultValue(10000)]
		public int MaxMessages
		{
			get
			{
				return this.internalLogViewer.MaxMessages;
			}
			set
			{
				this.internalLogViewer.MaxMessages = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000535C File Offset: 0x0000355C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0000536C File Offset: 0x0000356C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies the default value for the filter.  If not set, no messages will be filtered.")]
		[global::System.ComponentModel.DefaultValue(global::Gibraltar.Agent.LogMessageSeverity.Verbose)]
		public global::Gibraltar.Agent.LogMessageSeverity DefaultFilterLevel
		{
			get
			{
				return (global::Gibraltar.Agent.LogMessageSeverity)this.internalLogViewer.DefaultFilterLevel;
			}
			set
			{
				this.internalLogViewer.DefaultFilterLevel = (global::Loupe.Extensibility.Data.LogMessageSeverity)value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000537C File Offset: 0x0000357C
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000538C File Offset: 0x0000358C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("When false suppresses the display of verbose messages")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowVerboseMessages
		{
			get
			{
				return this.internalLogViewer.ShowVerboseMessages;
			}
			set
			{
				this.internalLogViewer.ShowVerboseMessages = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000539C File Offset: 0x0000359C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000053AC File Offset: 0x000035AC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the grid includes developer details about threads and calling method")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowDetailsInGrid
		{
			get
			{
				return this.internalLogViewer.ShowDetailsInGrid;
			}
			set
			{
				this.internalLogViewer.ShowDetailsInGrid = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000053BC File Offset: 0x000035BC
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000053CC File Offset: 0x000035CC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether tooltips include developer details about threads and calling method")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowDetailsInTooltips
		{
			get
			{
				return this.internalLogViewer.ShowDetailsInTooltips;
			}
			set
			{
				this.internalLogViewer.ShowDetailsInTooltips = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000053DC File Offset: 0x000035DC
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000053EC File Offset: 0x000035EC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the Show Details button should be visible in the toolbar")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowDetailsButton
		{
			get
			{
				return this.internalLogViewer.ShowDetailsButton;
			}
			set
			{
				this.internalLogViewer.ShowDetailsButton = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000053FC File Offset: 0x000035FC
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000540C File Offset: 0x0000360C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the Run button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool RunButtonTextVisible
		{
			get
			{
				return this.internalLogViewer.RunButtonTextVisible;
			}
			set
			{
				this.internalLogViewer.RunButtonTextVisible = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000541C File Offset: 0x0000361C
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000542C File Offset: 0x0000362C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Caption text for Run button")]
		[global::System.ComponentModel.DefaultValue("Click to Auto Refresh")]
		public string RunButtonText
		{
			get
			{
				return this.internalLogViewer.RunButtonText;
			}
			set
			{
				this.internalLogViewer.RunButtonText = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000543C File Offset: 0x0000363C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000544C File Offset: 0x0000364C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the Pause button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool PauseButtonTextVisible
		{
			get
			{
				return this.internalLogViewer.PauseButtonTextVisible;
			}
			set
			{
				this.internalLogViewer.PauseButtonTextVisible = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000545C File Offset: 0x0000365C
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000546C File Offset: 0x0000366C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Caption text for Pause button")]
		[global::System.ComponentModel.DefaultValue("Pause")]
		public string PauseButtonText
		{
			get
			{
				return this.internalLogViewer.PauseButtonText;
			}
			set
			{
				this.internalLogViewer.PauseButtonText = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000547C File Offset: 0x0000367C
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000548C File Offset: 0x0000368C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the Search button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool SearchButtonTextVisible
		{
			get
			{
				return this.internalLogViewer.SearchButtonTextVisible;
			}
			set
			{
				this.internalLogViewer.SearchButtonTextVisible = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000549C File Offset: 0x0000369C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000054AC File Offset: 0x000036AC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Caption text for Search button")]
		[global::System.ComponentModel.DefaultValue("Search")]
		public string SearchButtonText
		{
			get
			{
				return this.internalLogViewer.SearchButtonText;
			}
			set
			{
				this.internalLogViewer.SearchButtonText = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000054BC File Offset: 0x000036BC
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000054CC File Offset: 0x000036CC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the Reset Search button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ResetSearchButtonTextVisible
		{
			get
			{
				return this.internalLogViewer.ResetSearchButtonTextVisible;
			}
			set
			{
				this.internalLogViewer.ResetSearchButtonTextVisible = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000054DC File Offset: 0x000036DC
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000054EC File Offset: 0x000036EC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Caption text for Reset Search button")]
		[global::System.ComponentModel.DefaultValue("Reset")]
		public string ResetSearchButtonText
		{
			get
			{
				return this.internalLogViewer.ResetSearchButtonText;
			}
			set
			{
				this.internalLogViewer.ResetSearchButtonText = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000054FC File Offset: 0x000036FC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000550C File Offset: 0x0000370C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the Clear Search button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ClearMessagesButtonTextVisible
		{
			get
			{
				return this.internalLogViewer.ClearMessagesButtonTextVisible;
			}
			set
			{
				this.internalLogViewer.ClearMessagesButtonTextVisible = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000551C File Offset: 0x0000371C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000552C File Offset: 0x0000372C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Caption text for Clear Messages button")]
		[global::System.ComponentModel.DefaultValue("Clear")]
		public string ClearMessagesButtonText
		{
			get
			{
				return this.internalLogViewer.ClearMessagesButtonText;
			}
			set
			{
				this.internalLogViewer.ClearMessagesButtonText = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000553C File Offset: 0x0000373C
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000554C File Offset: 0x0000374C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Specifies whether the severity filter buttons should display message counts next to the icon")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowMessageCounters
		{
			get
			{
				return this.internalLogViewer.ShowMessageCounters;
			}
			set
			{
				this.internalLogViewer.ShowMessageCounters = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000555C File Offset: 0x0000375C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000556C File Offset: 0x0000376C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Allows each of the message severity filter buttons to toggle independently rather than act as a minimum severity setting.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnableIndependentSeverityFilters
		{
			get
			{
				return this.internalLogViewer.EnableIndependentSeverityFilters;
			}
			set
			{
				this.internalLogViewer.EnableIndependentSeverityFilters = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000557C File Offset: 0x0000377C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000558C File Offset: 0x0000378C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Enables selection of multiple rows or regions in the grid.  Use with ctrl-C to copy")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool EnableMultiSelection
		{
			get
			{
				return this.internalLogViewer.EnableMultiSelection;
			}
			set
			{
				this.internalLogViewer.EnableMultiSelection = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000559C File Offset: 0x0000379C
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000055AC File Offset: 0x000037AC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Loupe")]
		[global::System.ComponentModel.Description("Shows or hides the built-in toolbar")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ShowToolBar
		{
			get
			{
				return this.internalLogViewer.ShowToolBar;
			}
			set
			{
				this.internalLogViewer.ShowToolBar = value;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000055BC File Offset: 0x000037BC
		public void Clear()
		{
			this.internalLogViewer.Clear();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000055CC File Offset: 0x000037CC
		public void CopyAll()
		{
			this.internalLogViewer.CopyAll();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000055DC File Offset: 0x000037DC
		public void CopySelection()
		{
			this.internalLogViewer.CopySelection();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000055EC File Offset: 0x000037EC
		public void MoveFirst()
		{
			this.internalLogViewer.MoveFirst();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000055FC File Offset: 0x000037FC
		public void MoveLast()
		{
			this.internalLogViewer.MoveLast();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000560C File Offset: 0x0000380C
		public void SetAutoScroll(bool value)
		{
			this.internalLogViewer.SetAutoScroll(value);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000561C File Offset: 0x0000381C
		public void Save()
		{
			this.internalLogViewer.Save();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000562C File Offset: 0x0000382C
		public void SelectAll()
		{
			this.internalLogViewer.SelectAll();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000563C File Offset: 0x0000383C
		private void OnMessageChange(string newMessage)
		{
			if (this.MessageChanged != null)
			{
				this.MessageChanged(this, new global::Gibraltar.Agent.Windows.MessageChangedEventArgs(newMessage));
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000565C File Offset: 0x0000385C
		private void LiveLogViwer_MessageChange(object sender, global::Gibraltar.Monitor.Windows.MessageChangedEventArgs e)
		{
			if (e == null)
			{
				return;
			}
			this.OnMessageChange(e.Message);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005674 File Offset: 0x00003874
		private void LiveViewer_MessageFilterEvent(object sender, global::Gibraltar.Monitor.MessageFilterEventArgs e)
		{
			global::Gibraltar.Agent.Log.MessageFilterEventHandler messageFilterEvent = this.m_MessageFilterEvent;
			if (messageFilterEvent != null)
			{
				global::Gibraltar.Agent.LogMessageFilterEventArgs e2 = new global::Gibraltar.Agent.LogMessageFilterEventArgs(e);
				messageFilterEvent(this, e2);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000056A4 File Offset: 0x000038A4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000056CC File Offset: 0x000038CC
		private void InitializeComponent()
		{
			this.internalLogViewer = new global::Gibraltar.Monitor.Windows.LiveLogViewer();
			base.SuspendLayout();
			this.internalLogViewer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.internalLogViewer.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.internalLogViewer.Location = new global::System.Drawing.Point(0, 0);
			this.internalLogViewer.Name = "internalLogViewer";
			this.internalLogViewer.RunButtonTextVisible = false;
			this.internalLogViewer.ShowToolBar = true;
			this.internalLogViewer.Size = new global::System.Drawing.Size(726, 392);
			this.internalLogViewer.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.internalLogViewer);
			base.Name = "LiveLogViewer";
			base.Size = new global::System.Drawing.Size(726, 392);
			base.ResumeLayout(false);
		}

		// Token: 0x04000053 RID: 83
		public const int DefaultMaxMessages = 10000;

		// Token: 0x04000055 RID: 85
		private readonly object m_MessageEventLock = new object();

		// Token: 0x04000057 RID: 87
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000058 RID: 88
		private global::Gibraltar.Monitor.Windows.LiveLogViewer internalLogViewer;
	}
}
