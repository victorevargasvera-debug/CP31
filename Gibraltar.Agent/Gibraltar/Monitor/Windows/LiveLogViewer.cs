using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Messaging;
using Gibraltar.Messaging.Net;
using Gibraltar.Monitor.Windows.Internal;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;
using SourceGrid;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001E1 RID: 481
	[global::System.ComponentModel.DefaultProperty("UnhandledExceptionBehavior")]
	[global::System.ComponentModel.DefaultEvent("MessageChanged")]
	internal class LiveLogViewer : global::System.Windows.Forms.UserControl, global::System.ComponentModel.IComponent, global::System.IDisposable
	{
		// Token: 0x14000075 RID: 117
		// (add) Token: 0x060016E5 RID: 5861 RVA: 0x0004A50C File Offset: 0x0004870C
		// (remove) Token: 0x060016E6 RID: 5862 RVA: 0x0004A548 File Offset: 0x00048748
		public event global::Gibraltar.Monitor.Listener.MessageFilterEventHandler MessageFilter;

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060016E7 RID: 5863 RVA: 0x0004A584 File Offset: 0x00048784
		// (remove) Token: 0x060016E8 RID: 5864 RVA: 0x0004A5C0 File Offset: 0x000487C0
		public event global::Gibraltar.Monitor.Windows.MessageChangedEventHandler MessageChanged;

		// Token: 0x060016E9 RID: 5865 RVA: 0x0004A5FC File Offset: 0x000487FC
		public LiveLogViewer() : this(false, true)
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0004A608 File Offset: 0x00048808
		public LiveLogViewer(bool internalGibraltar, bool inProcess) : this(internalGibraltar, inProcess, null)
		{
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0004A614 File Offset: 0x00048814
		public LiveLogViewer(bool internalGibraltar, bool inProcess, global::Gibraltar.Messaging.Net.IRemoteViewerConnection remoteConnection)
		{
			this.InitializeComponent();
			global::Gibraltar.Monitor.Windows.Internal.ToolStripTextBoxDisposeHelper.CreateToolStripDisposeHelpers(this.statusBarToolStrip);
			this.threadsViewSplitContainer.Panel2Collapsed = true;
			this.m_InternalGibraltar = internalGibraltar;
			this.m_InProcess = inProcess;
			this.m_RemoteConnection = remoteConnection;
			this.InitializeViewer();
			global::System.Windows.Forms.ToolStripProfessionalRenderer toolStripProfessionalRenderer = new global::System.Windows.Forms.ToolStripProfessionalRenderer();
			toolStripProfessionalRenderer.ColorTable.UseSystemColors = true;
			this.statusBarToolStrip.Renderer = toolStripProfessionalRenderer;
			this.InitializeFilter();
			this.ShowOrHideDetailColumns();
			this.ShowOrHideMessageDetail();
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0004A6D0 File Offset: 0x000488D0
		protected override void OnLoad(global::System.EventArgs e)
		{
			base.OnLoad(e);
			if (!this.m_OnLoadProcessed)
			{
				this.m_OnLoadProcessed = true;
				if (this._DesignMode)
				{
					return;
				}
				this.m_ViewerEnabled = true;
				this.downloadToolStripButton.Visible = (this.m_InternalGibraltar && this.m_InProcess);
				if (this.m_InProcess)
				{
					global::Gibraltar.Monitor.Log.IsLoggingActive(false);
					if (this.m_InternalGibraltar)
					{
						try
						{
							global::Gibraltar.Messaging.ViewerMessengerConfiguration viewer = global::Gibraltar.Monitor.Log.Configuration.Viewer;
							this.ApplyConfigurationSettings(viewer);
						}
						catch
						{
						}
					}
				}
				global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
				if (this.m_InProcess)
				{
					if (this.m_GetPriorMessages)
					{
						global::Loupe.Extensibility.Data.ILogMessage[] messageBuffer = global::Gibraltar.Messaging.MonitorMessenger.GetMessageBuffer(this);
						this.ProcessNewMessages(messageBuffer);
					}
					else
					{
						global::Gibraltar.Messaging.MonitorMessenger.Register(this);
					}
				}
				if (this.m_RemoteConnection != null)
				{
					this.m_RemoteConnection.PropertyChanged += this.RemoteConnection_PropertyChanged;
					if (this.m_GetPriorMessages && this.m_RemoteConnection.IsConnected)
					{
						global::Loupe.Extensibility.Data.ILogMessage[] messageBuffer2 = this.m_RemoteConnection.GetMessageBuffer();
						this.ProcessNewMessages(messageBuffer2);
					}
					this.m_RemoteConnection.MessageAvailable += this.RemoteConnection_MessageAvailable;
					this.m_RemoteConnection.Connect();
				}
				this.m_MessagesStarted = true;
				this.StartMessageDisplay();
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0004A82C File Offset: 0x00048A2C
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Guid SessionId
		{
			get
			{
				if (this.m_RemoteConnection == null)
				{
					return global::System.Guid.Empty;
				}
				return this.m_RemoteConnection.Id;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0004A84C File Offset: 0x00048A4C
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0004A854 File Offset: 0x00048A54
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether to retrieve buffered messages from before the creation of this instance or start fresh.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool GetPriorMessages
		{
			get
			{
				return this.m_GetPriorMessages;
			}
			set
			{
				if (this.m_InProcess && this.m_MessagesStarted && this.m_GetPriorMessages != value)
				{
					if (value)
					{
						global::Gibraltar.Messaging.MonitorMessenger.Unregister(this);
						object queueLock = this.m_QueueLock;
						lock (queueLock)
						{
							this.m_MessageQueue.Clear();
							this.m_PendingInQueue = false;
						}
						this.ActionClear();
						global::Loupe.Extensibility.Data.ILogMessage[] messageBuffer = global::Gibraltar.Messaging.MonitorMessenger.GetMessageBuffer(this);
						this.ProcessNewMessages(messageBuffer);
					}
					else
					{
						global::Gibraltar.Messaging.MonitorMessenger.Unregister(this);
						object queueLock = this.m_QueueLock;
						lock (queueLock)
						{
							this.m_MessageQueue.Clear();
							this.m_PendingInQueue = false;
						}
						this.ActionClear();
						global::Gibraltar.Messaging.MonitorMessenger.Register(this);
					}
				}
				this.m_GetPriorMessages = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0004A938 File Offset: 0x00048B38
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0004A948 File Offset: 0x00048B48
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies how many messages to buffer in the viewer.  Set to zero for unlimited buffer size.")]
		[global::System.ComponentModel.DefaultValue(10000)]
		public int MaxMessages
		{
			get
			{
				return this.m_GridViewer.MaxMessages;
			}
			set
			{
				this.m_GridViewer.MaxMessages = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0004A958 File Offset: 0x00048B58
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0004A960 File Offset: 0x00048B60
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies the default value for the filter.  If not set, no messages will be filtered.")]
		[global::System.ComponentModel.DefaultValue(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose)]
		public global::Loupe.Extensibility.Data.LogMessageSeverity DefaultFilterLevel
		{
			get
			{
				return this.m_DefaultFilterLevel;
			}
			set
			{
				if (this.m_DefaultFilterLevel == value)
				{
					return;
				}
				this.m_DefaultFilterLevel = value;
				this.InitializeFilter();
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0004A97C File Offset: 0x00048B7C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Loupe.Extensibility.Data.LogMessageSeverity FilterLevel
		{
			get
			{
				return this.m_FilterLevel;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0004A984 File Offset: 0x00048B84
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0004A98C File Offset: 0x00048B8C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("When false suppresses the display of verbose messages")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowVerboseMessages
		{
			get
			{
				return this.m_ShowVerboseMessages;
			}
			set
			{
				this.m_ShowVerboseMessages = value;
				this.VerboseToolStripButton.Visible = this.m_ShowVerboseMessages;
				this.VerboseToolStripButton.Checked = this.m_ShowVerboseMessages;
				this.VerboseToolStripButton.ToolTipText = string.Format("Click to {0} Verbose messages", this.VerboseToolStripButton.Checked ? "hide" : "show");
				if (this.m_GridViewer != null)
				{
					this.m_GridViewer.ShowVerboseMessages = this.m_ShowVerboseMessages;
					this.m_GridViewer.FilterMessages();
				}
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0004AA24 File Offset: 0x00048C24
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0004AA34 File Offset: 0x00048C34
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the grid includes developer details about threads and calling method")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowDetailsInGrid
		{
			get
			{
				return this.ShowDetailsToolStripButton.Checked;
			}
			set
			{
				this.ShowDetailsToolStripButton.Checked = value;
				this.ShowOrHideDetailColumns();
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0004AA48 File Offset: 0x00048C48
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x0004AA58 File Offset: 0x00048C58
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether tooltips include developer details about threads and calling method")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ShowDetailsInTooltips
		{
			get
			{
				return this.m_GridViewer.ShowDetailsInTooltips;
			}
			set
			{
				this.m_GridViewer.ShowDetailsInTooltips = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x0004AA68 File Offset: 0x00048C68
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x0004AA78 File Offset: 0x00048C78
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the Show Details button should be visible in the toolbar")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowDetailsButton
		{
			get
			{
				return this.ShowDetailsToolStripButton.Visible;
			}
			set
			{
				this.ShowDetailsToolStripButton.Visible = value;
				this.DetailsToolStripSeparator.Visible = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x0004AA94 File Offset: 0x00048C94
		[global::System.ComponentModel.Browsable(false)]
		public bool ThreadsViewEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0004AA98 File Offset: 0x00048C98
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x0004AAA8 File Offset: 0x00048CA8
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the Run button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool RunButtonTextVisible
		{
			get
			{
				return this.RunToolStripButton.DisplayStyle == global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				this.RunToolStripButton.DisplayStyle = (value ? global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText : global::System.Windows.Forms.ToolStripItemDisplayStyle.Image);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0004AAC4 File Offset: 0x00048CC4
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0004AAD4 File Offset: 0x00048CD4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Caption text for Run button")]
		[global::System.ComponentModel.DefaultValue("Click to Auto Refresh")]
		public string RunButtonText
		{
			get
			{
				return this.RunToolStripButton.Text;
			}
			set
			{
				this.RunToolStripButton.Text = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0004AAE4 File Offset: 0x00048CE4
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0004AAF4 File Offset: 0x00048CF4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the Pause button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool PauseButtonTextVisible
		{
			get
			{
				return this.PauseToolStripButton.DisplayStyle == global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				this.PauseToolStripButton.DisplayStyle = (value ? global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText : global::System.Windows.Forms.ToolStripItemDisplayStyle.Image);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0004AB10 File Offset: 0x00048D10
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x0004AB20 File Offset: 0x00048D20
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Caption text for Pause button")]
		[global::System.ComponentModel.DefaultValue("Pause")]
		public string PauseButtonText
		{
			get
			{
				return this.PauseToolStripButton.Text;
			}
			set
			{
				this.PauseToolStripButton.Text = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0004AB30 File Offset: 0x00048D30
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0004AB40 File Offset: 0x00048D40
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the Search button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool SearchButtonTextVisible
		{
			get
			{
				return this.SearchToolStripButton.DisplayStyle == global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				this.SearchToolStripButton.DisplayStyle = (value ? global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText : global::System.Windows.Forms.ToolStripItemDisplayStyle.Image);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0004AB5C File Offset: 0x00048D5C
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x0004AB6C File Offset: 0x00048D6C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Caption text for Search button")]
		[global::System.ComponentModel.DefaultValue("Search")]
		public string SearchButtonText
		{
			get
			{
				return this.SearchToolStripButton.Text;
			}
			set
			{
				this.SearchToolStripButton.Text = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0004AB7C File Offset: 0x00048D7C
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0004AB8C File Offset: 0x00048D8C
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the Reset Search button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ResetSearchButtonTextVisible
		{
			get
			{
				return this.ResetSearchToolStripButton.DisplayStyle == global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				this.ResetSearchToolStripButton.DisplayStyle = (value ? global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText : global::System.Windows.Forms.ToolStripItemDisplayStyle.Image);
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0004ABA8 File Offset: 0x00048DA8
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0004ABB8 File Offset: 0x00048DB8
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Caption text for Reset Search button")]
		[global::System.ComponentModel.DefaultValue("Reset")]
		public string ResetSearchButtonText
		{
			get
			{
				return this.ResetSearchToolStripButton.Text;
			}
			set
			{
				this.ResetSearchToolStripButton.Text = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0004ABD8 File Offset: 0x00048DD8
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the Clear Search button should display caption text next to the icon")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ClearMessagesButtonTextVisible
		{
			get
			{
				return this.ClearToolStripButton.DisplayStyle == global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				this.ClearToolStripButton.DisplayStyle = (value ? global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText : global::System.Windows.Forms.ToolStripItemDisplayStyle.Image);
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0004ABF4 File Offset: 0x00048DF4
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0004AC04 File Offset: 0x00048E04
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Caption text for Clear Messages button")]
		[global::System.ComponentModel.DefaultValue("Clear")]
		public string ClearMessagesButtonText
		{
			get
			{
				return this.ClearToolStripButton.Text;
			}
			set
			{
				this.ClearToolStripButton.Text = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x0004AC14 File Offset: 0x00048E14
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0004AC24 File Offset: 0x00048E24
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Specifies whether the severity filter buttons should display message counts next to the icon")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ShowMessageCounters
		{
			get
			{
				return this.ErrorToolStripButton.DisplayStyle == global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			}
			set
			{
				global::System.Windows.Forms.ToolStripItemDisplayStyle displayStyle = value ? global::System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText : global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
				this.CriticalToolStripButton.DisplayStyle = displayStyle;
				this.ErrorToolStripButton.DisplayStyle = displayStyle;
				this.WarningToolStripButton.DisplayStyle = displayStyle;
				this.InformationToolStripButton.DisplayStyle = displayStyle;
				this.VerboseToolStripButton.DisplayStyle = displayStyle;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0004AC80 File Offset: 0x00048E80
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x0004AC88 File Offset: 0x00048E88
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Causes each of the message severity filter buttons to operate independently")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnableIndependentSeverityFilters { get; set; }

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x0004AC94 File Offset: 0x00048E94
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0004ACA4 File Offset: 0x00048EA4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Enables selection of multiple rows or regions in the grid.  Use with ctrl-C to copy")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool EnableMultiSelection
		{
			get
			{
				return this.m_GridViewer.EnableMultiSelection;
			}
			set
			{
				this.m_GridViewer.EnableMultiSelection = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0004ACB4 File Offset: 0x00048EB4
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0004ACBC File Offset: 0x00048EBC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Gibraltar")]
		[global::System.ComponentModel.Description("Shows or hides the built-in toolbar")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ShowToolBar
		{
			get
			{
				return this.m_ShowToolBar;
			}
			set
			{
				this.SetShowToolBar(value);
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0004ACC8 File Offset: 0x00048EC8
		public void Clear()
		{
			this.ActionClear();
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0004ACD0 File Offset: 0x00048ED0
		public void CopyAll()
		{
			this.ActionCopyAll();
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0004ACD8 File Offset: 0x00048ED8
		public void CopySelection()
		{
			this.ActionCopySelection();
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0004ACE0 File Offset: 0x00048EE0
		public void MoveFirst()
		{
			this.ActionMoveFirst();
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0004ACE8 File Offset: 0x00048EE8
		public void MoveLast()
		{
			this.ActionMoveLast();
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0004ACF0 File Offset: 0x00048EF0
		public void SetAutoScroll(bool value)
		{
			this.ActionSetAutoScroll(value);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0004ACFC File Offset: 0x00048EFC
		public void Save()
		{
			this.ActionSave();
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0004AD04 File Offset: 0x00048F04
		public void SelectAll()
		{
			this.ActionSelectAll();
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0004AD0C File Offset: 0x00048F0C
		internal void QueueViewerMessage(global::Loupe.Extensibility.Data.ILogMessage newMessage)
		{
			object queueLock = this.m_QueueLock;
			lock (queueLock)
			{
				bool flag = this.m_MessageQueue.Count == 0;
				if (this.m_ShowVerboseMessages || newMessage.Severity < global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose)
				{
					this.m_MessageQueue.Enqueue(newMessage);
					this.m_PendingInQueue = true;
				}
				if (this.MaxMessages > 0 && this.m_MessageQueue.Count > this.MaxMessages)
				{
					this.m_MessageQueue.Dequeue();
				}
				if (this.Frozen)
				{
					this.UpdateViewStatus();
				}
				else if (flag && base.IsHandleCreated)
				{
					base.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.ActionPoll));
				}
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0004ADE8 File Offset: 0x00048FE8
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x0004ADF0 File Offset: 0x00048FF0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		protected global::Loupe.Extensibility.Data.ILogMessage DetailedLogMessage
		{
			get
			{
				return this.m_DetailedLogMessage;
			}
			set
			{
				if (value != this.m_DetailedLogMessage)
				{
					this.m_DetailedLogMessage = value;
					this.messageDetails.LogMessage = value;
				}
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0004AE14 File Offset: 0x00049014
		protected override void OnVisibleChanged(global::System.EventArgs e)
		{
			base.OnVisibleChanged(e);
			this.m_GridViewer.Visible = base.Visible;
			if (base.Visible)
			{
				this.m_GridViewer.PerformResize();
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0004AE54 File Offset: 0x00049054
		protected override void OnParentChanged(global::System.EventArgs e)
		{
			base.OnParentChanged(e);
			if (base.Parent == null)
			{
				this.UnregisterIdleEvent();
				return;
			}
			this.RegisterIdleEvent();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0004AE78 File Offset: 0x00049078
		private void ActionDisplayConnected(bool isConnected)
		{
			if (base.InvokeRequired)
			{
				global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionDisplayConnectedInvoker method = new global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionDisplayConnectedInvoker(this.ActionDisplayConnected);
				base.BeginInvoke(method, new object[]
				{
					isConnected
				});
				return;
			}
			this.m_RemoteConnected = isConnected;
			this.SaveToolStripButton.Enabled = this.m_RemoteConnected;
			this.UpdateViewStatus();
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0004AED8 File Offset: 0x000490D8
		private void ActionSave()
		{
			if (base.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionSave);
				base.BeginInvoke(method);
				return;
			}
			if (this.m_InProcess)
			{
				if (global::Gibraltar.Monitor.Windows.UIPackagerDialog.RaisePendingToFront())
				{
					return;
				}
				using (global::Gibraltar.Monitor.Windows.UIPackagerDialog uipackagerDialog = new global::Gibraltar.Monitor.Windows.UIPackagerDialog())
				{
					uipackagerDialog.Send();
					return;
				}
			}
			try
			{
				this.m_RemoteConnection.SendToServer(global::Gibraltar.Data.SessionCriteria.ActiveSession);
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.Monitor.Log.ReportException(0, exception, null, "Viewer.Network", true, false);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0004AF80 File Offset: 0x00049180
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x0004AF90 File Offset: 0x00049190
		private bool Frozen
		{
			get
			{
				return this.m_GridViewer.Frozen;
			}
			set
			{
				this.m_GridViewer.Frozen = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0004AFA0 File Offset: 0x000491A0
		private bool _DesignMode
		{
			get
			{
				return this.GetService(typeof(global::System.ComponentModel.Design.IDesignerHost)) != null || global::System.ComponentModel.LicenseManager.UsageMode == global::System.ComponentModel.LicenseUsageMode.Designtime;
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0004AFC4 File Offset: 0x000491C4
		private void UpdateViewStatus()
		{
			if (base.IsDisposed)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(this.UpdateViewStatus));
				return;
			}
			if (this.m_GridViewer == null)
			{
				this.ViewerStatusToolStripLabel.Text = string.Empty;
				return;
			}
			int messageCount = this.m_GridViewer.MessageCount;
			int visibleCount = this.m_GridViewer.VisibleCount;
			string text = (visibleCount == messageCount) ? string.Format("{0:g} messages", messageCount) : string.Format("{0:g} shown of {1:g} messages", visibleCount, messageCount);
			this.CriticalToolStripButton.Text = this.m_GridViewer.CriticalMessageCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			this.ErrorToolStripButton.Text = this.m_GridViewer.ErrorMessageCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			this.WarningToolStripButton.Text = this.m_GridViewer.WarningMessageCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			this.InformationToolStripButton.Text = this.m_GridViewer.InfoMessageCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			this.VerboseToolStripButton.Text = this.m_GridViewer.VerboseMessageCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			if (this.m_RemoteConnection != null && !this.m_RemoteConnection.IsConnected)
			{
				text = " (Disconnected)";
			}
			else if (this.Frozen && this.m_PendingInQueue)
			{
				text += string.Format(" (+{0} waiting)", this.m_MessageQueue.Count);
			}
			this.ViewerStatusToolStripLabel.Text = text;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0004B184 File Offset: 0x00049384
		private void InitializeFilter()
		{
			global::Loupe.Extensibility.Data.LogMessageSeverity defaultFilterLevel = this.DefaultFilterLevel;
			switch (defaultFilterLevel)
			{
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical);
				goto IL_63;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Error);
				goto IL_63;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning);
				goto IL_63;
			default:
				if (defaultFilterLevel == global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
				{
					this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Information);
					goto IL_63;
				}
				break;
			}
			this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose);
			IL_63:
			if (this.EnableIndependentSeverityFilters)
			{
				this.CriticalToolStripButton.ToolTipText = string.Format("Click to {0} Critical messages", this.CriticalToolStripButton.Checked ? "hide" : "show");
				this.ErrorToolStripButton.ToolTipText = string.Format("Click to {0} Error messages", this.ErrorToolStripButton.Checked ? "hide" : "show");
				this.WarningToolStripButton.ToolTipText = string.Format("Click to {0} Warning messages", this.WarningToolStripButton.Checked ? "hide" : "show");
				this.InformationToolStripButton.ToolTipText = string.Format("Click to {0} Information messages", this.InformationToolStripButton.Checked ? "hide" : "show");
				this.VerboseToolStripButton.ToolTipText = string.Format("Click to {0} Verbose messages", this.VerboseToolStripButton.Checked ? "hide" : "show");
			}
			this.m_InactiveSearchFont = this.SearchToolStripTextBox.Font;
			this.m_ActiveSearchFont = new global::System.Drawing.Font(this.m_InactiveSearchFont, global::System.Drawing.FontStyle.Regular);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0004B32C File Offset: 0x0004952C
		private void StartMessageDisplay()
		{
			if (this._DesignMode)
			{
				return;
			}
			this.RunToolStripButton.Visible = false;
			this.SearchToolStripButton.Visible = false;
			this.ResetSearchToolStripButton.Visible = false;
			this.RegisterIdleEvent();
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0004B374 File Offset: 0x00049574
		private void ShutdownViewer()
		{
			if (this.m_InProcess)
			{
				global::Gibraltar.Messaging.MonitorMessenger.Unregister(this);
			}
			this.UnregisterIdleEvent();
			if (this.m_RemoteConnection != null)
			{
				this.m_RemoteConnection.MessageAvailable -= this.RemoteConnection_MessageAvailable;
				this.m_RemoteConnection.PropertyChanged -= this.RemoteConnection_PropertyChanged;
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0004B3D8 File Offset: 0x000495D8
		private void SetShowToolBar(bool value)
		{
			if (this.m_ShowToolBar == value)
			{
				return;
			}
			this.m_ShowToolBar = value;
			this.statusBarToolStrip.Visible = this.m_ShowToolBar;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0004B400 File Offset: 0x00049600
		private void ActionClear()
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionClear);
				gridViewer.BeginInvoke(method);
				return;
			}
			this.m_GridViewer.Clear();
			this.DetailedLogMessage = null;
			this.ActionSetAutoScroll(true);
			this.UpdateViewStatus();
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0004B458 File Offset: 0x00049658
		private static void ActionWebpage()
		{
			try
			{
				global::Gibraltar.Monitor.Log.DisplayWebPage("check_for_updates.aspx");
			}
			catch
			{
				global::System.Windows.Forms.MessageBox.Show("Gibraltar Live Viewer", "Please check www.GibraltarSoftare.com for updates.");
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0004B49C File Offset: 0x0004969C
		private void ActionCopyAll()
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionCopyAll);
				gridViewer.BeginInvoke(method);
				return;
			}
			this.m_GridViewer.CopyAll();
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0004B4E0 File Offset: 0x000496E0
		private void ActionCopySelection()
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionCopySelection);
				gridViewer.BeginInvoke(method);
				return;
			}
			this.m_GridViewer.CopySelection();
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0004B524 File Offset: 0x00049724
		private void ActionMoveFirst()
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionMoveFirst);
				gridViewer.BeginInvoke(method);
				return;
			}
			this.ActionSetAutoScroll(false);
			this.m_GridViewer.MoveFirst();
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0004B570 File Offset: 0x00049770
		private void ActionMoveLast()
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionMoveLast);
				gridViewer.BeginInvoke(method);
				return;
			}
			this.m_GridViewer.MoveLast();
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0004B5B4 File Offset: 0x000497B4
		private void ActionPoll()
		{
			if (!this.m_PendingInQueue)
			{
				return;
			}
			if (base.IsDisposed)
			{
				return;
			}
			if (this.Frozen)
			{
				return;
			}
			try
			{
				global::Loupe.Extensibility.Data.ILogMessage[] newMessageArray = null;
				object queueLock = this.m_QueueLock;
				lock (queueLock)
				{
					if (!this.m_AutoScroll && this.MaxMessages > 0 && this.m_GridViewer.MessageCount >= this.MaxMessages)
					{
						this.Frozen = true;
						return;
					}
					this.m_PendingInQueue = false;
					if (this.m_MessageQueue.Count <= 0)
					{
						return;
					}
					newMessageArray = this.m_MessageQueue.ToArray();
					this.m_MessageQueue.Clear();
				}
				this.ProcessNewMessages(newMessageArray);
			}
			catch
			{
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0004B6A8 File Offset: 0x000498A8
		private void ActionSelectAll()
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::System.Windows.Forms.MethodInvoker method = new global::System.Windows.Forms.MethodInvoker(this.ActionSelectAll);
				gridViewer.BeginInvoke(method);
				return;
			}
			this.m_GridViewer.SelectAll();
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0004B6EC File Offset: 0x000498EC
		private void ActionSetAutoScroll(bool value)
		{
			if (this.m_GridViewer == null)
			{
				return;
			}
			if (base.InvokeRequired)
			{
				global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionSetAutoScrollDelegate method = new global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionSetAutoScrollDelegate(this.ActionSetAutoScroll);
				base.BeginInvoke(method, new object[]
				{
					value
				});
				return;
			}
			this.m_AutoScroll = value;
			if (this.m_AutoScroll)
			{
				if (this.m_GridViewer.Sorted)
				{
					this.m_GridViewer.RemoveSort();
				}
				this.m_GridViewer.MoveLast();
				this.m_GridViewer.Frozen = false;
				this.m_GridViewer.ClearSelection();
				this.OnResize(global::System.EventArgs.Empty);
				global::Loupe.Extensibility.Data.ILogMessage currentMessage = this.m_GridViewer.GetCurrentMessage();
				this.DetailedLogMessage = currentMessage;
			}
			this.m_GridViewer.AutoScrollMessages = value;
			this.PauseToolStripButton.Visible = this.m_AutoScroll;
			this.RunToolStripButton.Visible = !this.m_AutoScroll;
			if (base.IsHandleCreated && this.m_AutoScroll)
			{
				this.ActionPoll();
			}
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0004B7F4 File Offset: 0x000499F4
		private void ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity minSeverity)
		{
			global::System.Windows.Forms.Control gridViewer = this.m_GridViewer;
			if (gridViewer.InvokeRequired)
			{
				global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionSetMinSeverityDelegate method = new global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionSetMinSeverityDelegate(this.ActionSetMinSeverity);
				gridViewer.BeginInvoke(method, new object[]
				{
					minSeverity
				});
				return;
			}
			this.CriticalToolStripButton.Checked = (minSeverity >= global::Loupe.Extensibility.Data.LogMessageSeverity.Critical);
			this.ErrorToolStripButton.Checked = (minSeverity >= global::Loupe.Extensibility.Data.LogMessageSeverity.Error);
			this.WarningToolStripButton.Checked = (minSeverity >= global::Loupe.Extensibility.Data.LogMessageSeverity.Warning);
			this.InformationToolStripButton.Checked = (minSeverity >= global::Loupe.Extensibility.Data.LogMessageSeverity.Information);
			this.VerboseToolStripButton.Checked = (minSeverity >= global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose);
			this.m_GridViewer.ShowCriticalMessages = this.CriticalToolStripButton.Checked;
			this.m_GridViewer.ShowErrorMessages = this.ErrorToolStripButton.Checked;
			this.m_GridViewer.ShowWarningMessages = this.WarningToolStripButton.Checked;
			this.m_GridViewer.ShowInformationMessages = this.InformationToolStripButton.Checked;
			this.m_GridViewer.ShowVerboseMessages = this.VerboseToolStripButton.Checked;
			this.CriticalToolStripButton.ToolTipText = "Click to show only Critical severity (narrowest filter)";
			this.ErrorToolStripButton.ToolTipText = "Click to show only severity of Error and above";
			this.WarningToolStripButton.ToolTipText = "Click to show only severity of Warning and above";
			this.InformationToolStripButton.ToolTipText = "Click to show only severity of Information and above";
			this.VerboseToolStripButton.ToolTipText = "Click to show all messages (no filtering)";
			switch (minSeverity)
			{
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
				this.CriticalToolStripButton.ToolTipText = "Showing only Critical severity (narrowest filter)";
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				this.ErrorToolStripButton.ToolTipText = "Click to hide messages with severity of Error and below";
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
				this.WarningToolStripButton.ToolTipText = "Click to hide messages with severity of Warning and below";
				break;
			default:
				if (minSeverity != global::Loupe.Extensibility.Data.LogMessageSeverity.Information)
				{
					if (minSeverity == global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose)
					{
						this.VerboseToolStripButton.ToolTipText = "Click to hide messages with Verbose severity";
					}
				}
				else
				{
					this.InformationToolStripButton.ToolTipText = "Click to hide messages with severity of Information and below";
				}
				break;
			}
			this.m_FilterLevel = minSeverity;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0004B9EC File Offset: 0x00049BEC
		private void ActionSetSearchText(string searchText)
		{
			this.m_GridViewer.SearchText = searchText;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0004B9FC File Offset: 0x00049BFC
		private void OnMessageChange(string newMessage)
		{
			if (this.MessageChanged != null)
			{
				this.MessageChanged(this, new global::Gibraltar.Monitor.Windows.MessageChangedEventArgs(newMessage));
			}
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0004BA1C File Offset: 0x00049C1C
		private void ProcessNewMessages(global::Loupe.Extensibility.Data.ILogMessage[] newMessageArray)
		{
			if (newMessageArray == null)
			{
				return;
			}
			global::Loupe.Extensibility.Data.ILogMessage[] array = this.ClientFilterNewMessages(newMessageArray) ?? new global::Loupe.Extensibility.Data.ILogMessage[0];
			global::Loupe.Extensibility.Data.ILogMessage logMessage = null;
			for (int i = array.GetUpperBound(0); i >= 0; i--)
			{
				global::Loupe.Extensibility.Data.ILogMessage logMessage2 = array[i];
				if (logMessage2.Severity != global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose)
				{
					logMessage = logMessage2;
					break;
				}
			}
			if (this.m_GridViewer != null)
			{
				this.m_GridViewer.AddRange(array);
				if (this.m_AutoScroll)
				{
					global::Loupe.Extensibility.Data.ILogMessage currentMessage = this.m_GridViewer.GetCurrentMessage();
					this.DetailedLogMessage = currentMessage;
				}
			}
			if (logMessage != null)
			{
				this.OnMessageChange(logMessage.Caption);
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0004BAC8 File Offset: 0x00049CC8
		private global::Loupe.Extensibility.Data.ILogMessage[] ClientFilterNewMessages(global::Loupe.Extensibility.Data.ILogMessage[] newMessageArray)
		{
			if (newMessageArray == null || newMessageArray.Length == 0)
			{
				return newMessageArray;
			}
			global::Gibraltar.Monitor.Listener.MessageFilterEventHandler messageFilter = this.MessageFilter;
			if (messageFilter != null)
			{
				if (newMessageArray.Length <= 1)
				{
					global::Loupe.Extensibility.Data.ILogMessage message = newMessageArray[0];
					try
					{
						global::Gibraltar.Monitor.MessageFilterEventArgs messageFilterEventArgs = new global::Gibraltar.Monitor.MessageFilterEventArgs(message);
						messageFilter(this, messageFilterEventArgs);
						if (messageFilterEventArgs.Cancel)
						{
							return null;
						}
					}
					catch
					{
					}
					return newMessageArray;
				}
				global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.ILogMessage> list = new global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.ILogMessage>(newMessageArray.Length);
				foreach (global::Loupe.Extensibility.Data.ILogMessage logMessage in newMessageArray)
				{
					bool flag;
					try
					{
						global::Gibraltar.Monitor.MessageFilterEventArgs messageFilterEventArgs2 = new global::Gibraltar.Monitor.MessageFilterEventArgs(logMessage);
						messageFilter(this, messageFilterEventArgs2);
						flag = messageFilterEventArgs2.Cancel;
					}
					catch
					{
						flag = false;
					}
					if (!flag)
					{
						list.Add(logMessage);
					}
				}
				if (list.Count <= 0)
				{
					return null;
				}
				newMessageArray = list.ToArray();
			}
			return newMessageArray;
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0004BBCC File Offset: 0x00049DCC
		private void ApplyConfigurationSettings(global::Gibraltar.Messaging.ViewerMessengerConfiguration configuration)
		{
			if (configuration == null)
			{
				return;
			}
			this.m_ViewerEnabled = configuration.Enabled;
			this.ClearMessagesButtonText = configuration.ClearMessagesButtonText;
			this.ClearMessagesButtonTextVisible = configuration.ClearMessagesButtonTextVisible;
			this.DefaultFilterLevel = configuration.DefaultFilterLevel;
			this.EnableIndependentSeverityFilters = configuration.EnableIndependentSeverityFilters;
			this.EnableMultiSelection = configuration.EnableMultiSelection;
			this.ShowToolBar = configuration.ShowToolBar;
			this.ShowVerboseMessages = configuration.ShowVerboseMessages;
			this.MaxMessages = configuration.MaxMessages;
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

		// Token: 0x06001740 RID: 5952 RVA: 0x0004BCC8 File Offset: 0x00049EC8
		private void InitializeViewer()
		{
			this.UpdateViewStatus();
			global::Gibraltar.Monitor.Windows.Internal.GridViewer gridViewer = new global::Gibraltar.Monitor.Windows.Internal.GridViewer();
			this.m_GridViewer = gridViewer;
			if (this.m_InProcess)
			{
				this.m_GridViewer.ColumnVisible(global::Gibraltar.Monitor.Windows.LogMessageColumn.UserName, false);
			}
			this.messageDetailsSplitContainer.Panel1.Controls.Add(gridViewer);
			gridViewer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.messageDetails.LogMessage = null;
			this.m_GridViewer.EnableMultiSelection = true;
			this.m_GridViewer.UserInteraction += this.m_Viewer_UserInteraction;
			this.m_GridViewer.ViewChanged += this.m_Viewer_ViewChanged;
			this.m_GridViewer.FilterChanged += this.m_Viewer_FilterChanged;
			this.m_GridViewer.AutoScrollMessages = this.m_AutoScroll;
			this.m_GridViewer.Selection.SelectionChanged += new global::SourceGrid.RangeRegionChangedEventHandler(this.m_GridViewer_Selection_SelectionChanged);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0004BDAC File Offset: 0x00049FAC
		private void RefreshSearch()
		{
			try
			{
				this.Cursor = global::System.Windows.Forms.Cursors.WaitCursor;
				string text = this.SearchToolStripTextBox.Text;
				this.ActionSetSearchText(text);
				this.UpdateSearchBackColor();
			}
			finally
			{
				this.Cursor = global::System.Windows.Forms.Cursors.Default;
			}
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0004BE00 File Offset: 0x0004A000
		private void ClearSearch()
		{
			this.SearchToolStripTextBox.Font = this.m_InactiveSearchFont;
			this.SearchToolStripTextBox.ForeColor = global::System.Drawing.Color.Gray;
			this.SearchToolStripTextBox.Text = "Search Messages";
			this.ResetSearchToolStripButton.Visible = false;
			this.SearchToolStripButton.Visible = false;
			this.ActionSetSearchText(null);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0004BE64 File Offset: 0x0004A064
		private void UpdateSearchBackColor()
		{
			if (this.SearchToolStripTextBox.Text == this.m_GridViewer.SearchText && !string.IsNullOrEmpty(this.SearchToolStripTextBox.Text))
			{
				this.SearchToolStripTextBox.BackColor = global::System.Drawing.Color.Cornsilk;
			}
			else
			{
				this.SearchToolStripTextBox.BackColor = global::System.Drawing.Color.White;
			}
			this.m_GridViewer.UpdateGridBackColor();
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0004BEDC File Offset: 0x0004A0DC
		private void AsyncSessionConnect(object state)
		{
			try
			{
				((global::Gibraltar.Messaging.Net.IRemoteViewerConnection)state).Connect();
			}
			catch (global::System.Exception ex)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Unable to connect to session data stream", "While attempting to connect the session to the server to get the live stream an exception was thrown, and we are presumed not connected.\r\nException: {0}", new object[]
					{
						ex.Message
					});
				}
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0004BF40 File Offset: 0x0004A140
		private void RegisterIdleEvent()
		{
			if (this.m_IdleEventRegistered)
			{
				return;
			}
			this.m_IdleEventRegistered = true;
			if (this.m_ViewerEnabled)
			{
				global::System.Windows.Forms.Application.Idle += this.Application_Idle;
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0004BF74 File Offset: 0x0004A174
		private void UnregisterIdleEvent()
		{
			this.m_IdleEventRegistered = false;
			global::System.Windows.Forms.Application.Idle -= this.Application_Idle;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0004BF90 File Offset: 0x0004A190
		private void m_Viewer_ViewChanged(object sender, global::System.EventArgs e)
		{
			this.UpdateViewStatus();
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0004BF98 File Offset: 0x0004A198
		private void m_Viewer_FilterChanged(object sender, global::System.EventArgs e)
		{
			if (this.m_AutoScroll)
			{
				global::Loupe.Extensibility.Data.ILogMessage currentMessage = this.m_GridViewer.GetCurrentMessage();
				this.DetailedLogMessage = currentMessage;
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		private void m_Viewer_UserInteraction(object sender, global::System.EventArgs e)
		{
			this.ActionSetAutoScroll(false);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0004BFD4 File Offset: 0x0004A1D4
		private void m_GridViewer_Selection_SelectionChanged(object sender, global::System.EventArgs e)
		{
			global::Loupe.Extensibility.Data.ILogMessage selectedMessage = this.m_GridViewer.GetSelectedMessage();
			if (selectedMessage != null)
			{
				this.DetailedLogMessage = selectedMessage;
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0004C000 File Offset: 0x0004A200
		private void RemoteConnection_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Gibraltar.Messaging.Net.IRemoteViewerConnection remoteViewerConnection = (global::Gibraltar.Messaging.Net.IRemoteViewerConnection)sender;
			string propertyName = e.PropertyName;
			if (propertyName == "IsAvailable")
			{
				global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncSessionConnect), remoteViewerConnection);
				return;
			}
			if (!(propertyName == "IsConnected"))
			{
				return;
			}
			this.ActionDisplayConnected(remoteViewerConnection.IsConnected);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0004C060 File Offset: 0x0004A260
		private void RemoteConnection_MessageAvailable(object sender, global::Gibraltar.Messaging.Net.MessageAvailableEventArgs e)
		{
			this.QueueViewerMessage(e.Message);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0004C070 File Offset: 0x0004A270
		private void Application_Idle(object sender, global::System.EventArgs e)
		{
			this.ActionPoll();
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0004C078 File Offset: 0x0004A278
		private void RunToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ActionSetAutoScroll(true);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x0004C084 File Offset: 0x0004A284
		private void PauseToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ActionSetAutoScroll(false);
			this.Frozen = true;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0004C094 File Offset: 0x0004A294
		private void SaveToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ActionSave();
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0004C09C File Offset: 0x0004A29C
		private void CopyToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ActionCopyAll();
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
		private void ClearToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			if (global::System.Windows.Forms.MessageBox.Show("Clear all log messages?", "Clear Messages", global::System.Windows.Forms.MessageBoxButtons.OKCancel, global::System.Windows.Forms.MessageBoxIcon.Question) == global::System.Windows.Forms.DialogResult.OK)
			{
				this.ActionClear();
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0004C0C4 File Offset: 0x0004A2C4
		private void downloadToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			global::Gibraltar.Monitor.Windows.LiveLogViewer.ActionWebpage();
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0004C0CC File Offset: 0x0004A2CC
		private void MoveFirstToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ActionMoveFirst();
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0004C0D4 File Offset: 0x0004A2D4
		private void MoveLastToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ActionMoveLast();
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0004C0DC File Offset: 0x0004A2DC
		private void ShowDetailsToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Forms.ToolStripButton toolStripButton = (global::System.Windows.Forms.ToolStripButton)sender;
			this.ShowDetailsInGrid = toolStripButton.Checked;
			this.ShowOrHideDetailColumns();
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0004C108 File Offset: 0x0004A308
		private void ShowOrHideMessageDetail()
		{
			int num = this.messageDetailsSplitContainer.Panel2MinSize * 2;
			bool flag = this.messageDetailsSplitContainer.Height < num;
			if (flag == this.m_DetailsCollapsed)
			{
				return;
			}
			this.messageDetailsSplitContainer.Panel2Collapsed = flag;
			this.m_DetailsCollapsed = flag;
			if (flag && this.m_DetailsCollapsed && this.m_GridViewer.AutoScrollMessages)
			{
				this.ActionMoveLast();
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0004C180 File Offset: 0x0004A380
		private void ShowOrHideDetailColumns()
		{
			if (this.m_GridViewer != null)
			{
				this.m_GridViewer.ColumnVisible(global::Gibraltar.Monitor.Windows.LogMessageColumn.Thread, this.ShowDetailsInGrid);
				this.m_GridViewer.ColumnVisible(global::Gibraltar.Monitor.Windows.LogMessageColumn.Method, this.ShowDetailsInGrid);
			}
			this.ShowDetailsToolStripButton.Checked = this.ShowDetailsInGrid;
			if (this.m_GridViewer != null)
			{
				this.m_GridViewer.PerformResize();
			}
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0004C1E8 File Offset: 0x0004A3E8
		private void CriticalToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			if (this.EnableIndependentSeverityFilters)
			{
				this.m_GridViewer.ShowCriticalMessages = this.CriticalToolStripButton.Checked;
				this.CriticalToolStripButton.ToolTipText = string.Format("Click to {0} Error messages", this.CriticalToolStripButton.Checked ? "hide" : "show");
			}
			else
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Critical);
			}
			this.m_GridViewer.FilterMessages();
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0004C268 File Offset: 0x0004A468
		private void ErrorToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			if (this.EnableIndependentSeverityFilters)
			{
				this.m_GridViewer.ShowErrorMessages = this.ErrorToolStripButton.Checked;
				this.ErrorToolStripButton.ToolTipText = string.Format("Click to {0} Error messages", this.ErrorToolStripButton.Checked ? "hide" : "show");
			}
			else
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Error);
			}
			this.m_GridViewer.FilterMessages();
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0004C2E8 File Offset: 0x0004A4E8
		private void WarningToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			if (this.EnableIndependentSeverityFilters)
			{
				this.m_GridViewer.ShowWarningMessages = this.WarningToolStripButton.Checked;
				this.WarningToolStripButton.ToolTipText = string.Format("Click to {0} Warning messages", this.WarningToolStripButton.Checked ? "hide" : "show");
			}
			else if (this.WarningToolStripButton.Checked || this.InformationToolStripButton.Checked)
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning);
			}
			else
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Error);
			}
			this.m_GridViewer.FilterMessages();
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0004C394 File Offset: 0x0004A594
		private void InformationToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			if (this.EnableIndependentSeverityFilters)
			{
				this.m_GridViewer.ShowInformationMessages = this.InformationToolStripButton.Checked;
				this.InformationToolStripButton.ToolTipText = string.Format("Click to {0} Information messages", this.InformationToolStripButton.Checked ? "hide" : "show");
			}
			else if (this.InformationToolStripButton.Checked || this.VerboseToolStripButton.Checked)
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Information);
			}
			else
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning);
			}
			this.m_GridViewer.FilterMessages();
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0004C440 File Offset: 0x0004A640
		private void VerboseToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			if (this.EnableIndependentSeverityFilters)
			{
				this.m_GridViewer.ShowVerboseMessages = this.VerboseToolStripButton.Checked;
				this.VerboseToolStripButton.ToolTipText = string.Format("Click to {0} Verbose messages", this.VerboseToolStripButton.Checked ? "hide" : "show");
			}
			else if (this.VerboseToolStripButton.Checked)
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose);
			}
			else
			{
				this.ActionSetMinSeverity(global::Loupe.Extensibility.Data.LogMessageSeverity.Information);
			}
			this.m_GridViewer.FilterMessages();
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		private void CMViewer_ParentChanged(object sender, global::System.EventArgs e)
		{
			if (!this.m_AutoDocked && this.Dock == global::System.Windows.Forms.DockStyle.None && this.Anchor == (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left))
			{
				this.Dock = global::System.Windows.Forms.DockStyle.Fill;
				this.m_AutoDocked = true;
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0004C510 File Offset: 0x0004A710
		private void SearchToolStripTextBox_KeyDown(object sender, global::System.Windows.Forms.KeyEventArgs e)
		{
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0004C514 File Offset: 0x0004A714
		private void SearchToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.RefreshSearch();
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0004C51C File Offset: 0x0004A71C
		private void SearchToolStripTextBox_Enter(object sender, global::System.EventArgs e)
		{
			if (this.m_EnteringSearchText)
			{
				return;
			}
			try
			{
				this.m_EnteringSearchText = true;
				if (this.SearchToolStripTextBox.ForeColor != global::System.Drawing.Color.Black)
				{
					this.SearchToolStripTextBox.Font = this.m_ActiveSearchFont;
					this.SearchToolStripTextBox.ForeColor = global::System.Drawing.Color.Black;
					this.SearchToolStripTextBox.Text = "";
				}
			}
			finally
			{
				this.m_EnteringSearchText = false;
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
		private void SearchToolStripTextBox_Leave(object sender, global::System.EventArgs e)
		{
			if (this.m_EnteringSearchText)
			{
				return;
			}
			try
			{
				this.m_EnteringSearchText = true;
				if (string.IsNullOrEmpty(this.SearchToolStripTextBox.Text))
				{
					this.ResetSearchToolStripButton.Visible = false;
					this.ClearSearch();
				}
			}
			finally
			{
				this.m_EnteringSearchText = false;
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0004C610 File Offset: 0x0004A810
		private void ClearSearchToolStripButton_Click(object sender, global::System.EventArgs e)
		{
			this.ClearSearch();
			this.UpdateSearchBackColor();
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0004C620 File Offset: 0x0004A820
		private void SearchToolStripTextBox_TextChanged(object sender, global::System.EventArgs e)
		{
			if (this.m_EnteringSearchText)
			{
				return;
			}
			this.ResetSearchToolStripButton.Visible = !string.IsNullOrEmpty(this.SearchToolStripTextBox.Text);
			this.RefreshSearch();
			this.SearchToolStripTextBox.Focus();
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0004C660 File Offset: 0x0004A860
		private void messageDetailsSplitContainer_Resize(object sender, global::System.EventArgs e)
		{
			this.ShowOrHideMessageDetail();
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0004C668 File Offset: 0x0004A868
		private void threadsViewSplitContainer_Resize(object sender, global::System.EventArgs e)
		{
			int num = this.threadsViewSplitContainer.Panel2MinSize * 2;
			if (this.threadsViewSplitContainer.Width < num)
			{
				this.threadsViewSplitContainer.Panel2Collapsed = true;
				return;
			}
			this.threadsViewSplitContainer.Panel2Collapsed = !this.ThreadsViewEnabled;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			this.ShutdownViewer();
			base.Dispose(disposing);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0004C6E8 File Offset: 0x0004A8E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Monitor.Windows.LiveLogViewer));
			this.ToolStripContainer1 = new global::System.Windows.Forms.ToolStripContainer();
			this.threadsViewSplitContainer = new global::System.Windows.Forms.SplitContainer();
			this.messageDetailsSplitContainer = new global::System.Windows.Forms.SplitContainer();
			this.messageDetails = new global::Gibraltar.Monitor.Windows.Internal.UIMessageDetails();
			this.uiThreadTrackViewer1 = new global::Gibraltar.Monitor.Windows.Internal.UIThreadTrackViewer();
			this.statusBarToolStrip = new global::System.Windows.Forms.ToolStrip();
			this.RunToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.PauseToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.MoveFirstToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.MoveLastToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.SaveToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.CopyToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.downloadToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ShowDetailsToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ClearToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.DetailsToolStripSeparator = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.ViewerStatusToolStripLabel = new global::System.Windows.Forms.ToolStripLabel();
			this.CriticalToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ErrorToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.WarningToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.InformationToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.VerboseToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.SearchToolStripTextBox = new global::System.Windows.Forms.ToolStripTextBox();
			this.SearchToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ResetSearchToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripContainer1.ContentPanel.SuspendLayout();
			this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.ToolStripContainer1.SuspendLayout();
			this.threadsViewSplitContainer.Panel1.SuspendLayout();
			this.threadsViewSplitContainer.Panel2.SuspendLayout();
			this.threadsViewSplitContainer.SuspendLayout();
			this.messageDetailsSplitContainer.Panel2.SuspendLayout();
			this.messageDetailsSplitContainer.SuspendLayout();
			this.statusBarToolStrip.SuspendLayout();
			base.SuspendLayout();
			this.ToolStripContainer1.ContentPanel.Controls.Add(this.threadsViewSplitContainer);
			this.ToolStripContainer1.ContentPanel.Size = new global::System.Drawing.Size(964, 600);
			this.ToolStripContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ToolStripContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.ToolStripContainer1.Name = "ToolStripContainer1";
			this.ToolStripContainer1.Size = new global::System.Drawing.Size(964, 625);
			this.ToolStripContainer1.TabIndex = 3;
			this.ToolStripContainer1.Text = "ToolStripContainer1";
			this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.statusBarToolStrip);
			this.threadsViewSplitContainer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.threadsViewSplitContainer.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel2;
			this.threadsViewSplitContainer.Location = new global::System.Drawing.Point(0, 0);
			this.threadsViewSplitContainer.Name = "threadsViewSplitContainer";
			this.threadsViewSplitContainer.Panel1.Controls.Add(this.messageDetailsSplitContainer);
			this.threadsViewSplitContainer.Panel2.Controls.Add(this.uiThreadTrackViewer1);
			this.threadsViewSplitContainer.Size = new global::System.Drawing.Size(964, 600);
			this.threadsViewSplitContainer.SplitterDistance = 620;
			this.threadsViewSplitContainer.TabIndex = 0;
			this.threadsViewSplitContainer.Resize += this.threadsViewSplitContainer_Resize;
			this.messageDetailsSplitContainer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.messageDetailsSplitContainer.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel2;
			this.messageDetailsSplitContainer.Location = new global::System.Drawing.Point(0, 0);
			this.messageDetailsSplitContainer.Name = "messageDetailsSplitContainer";
			this.messageDetailsSplitContainer.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.messageDetailsSplitContainer.Panel1MinSize = 85;
			this.messageDetailsSplitContainer.Panel2.Controls.Add(this.messageDetails);
			this.messageDetailsSplitContainer.Panel2MinSize = 134;
			this.messageDetailsSplitContainer.Size = new global::System.Drawing.Size(620, 600);
			this.messageDetailsSplitContainer.SplitterDistance = 413;
			this.messageDetailsSplitContainer.TabIndex = 0;
			this.messageDetailsSplitContainer.Resize += this.messageDetailsSplitContainer_Resize;
			this.messageDetails.BackColor = global::System.Drawing.SystemColors.Window;
			this.messageDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.messageDetails.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.messageDetails.Location = new global::System.Drawing.Point(0, 0);
			this.messageDetails.Name = "messageDetails";
			this.messageDetails.ShowDescriptionPreformatted = false;
			this.messageDetails.Size = new global::System.Drawing.Size(620, 183);
			this.messageDetails.TabIndex = 0;
			this.uiThreadTrackViewer1.BackColor = global::System.Drawing.SystemColors.Window;
			this.uiThreadTrackViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.uiThreadTrackViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.uiThreadTrackViewer1.Name = "uiThreadTrackViewer1";
			this.uiThreadTrackViewer1.Size = new global::System.Drawing.Size(340, 600);
			this.uiThreadTrackViewer1.TabIndex = 0;
			this.statusBarToolStrip.Dock = global::System.Windows.Forms.DockStyle.None;
			this.statusBarToolStrip.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.statusBarToolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RunToolStripButton,
				this.PauseToolStripButton,
				this.ToolStripSeparator3,
				this.MoveFirstToolStripButton,
				this.MoveLastToolStripButton,
				this.ToolStripSeparator4,
				this.SaveToolStripButton,
				this.CopyToolStripButton,
				this.ToolStripSeparator1,
				this.downloadToolStripButton,
				this.ShowDetailsToolStripButton,
				this.ClearToolStripButton,
				this.DetailsToolStripSeparator,
				this.toolStripLabel1,
				this.ViewerStatusToolStripLabel,
				this.CriticalToolStripButton,
				this.ErrorToolStripButton,
				this.WarningToolStripButton,
				this.InformationToolStripButton,
				this.VerboseToolStripButton,
				this.SearchToolStripTextBox,
				this.SearchToolStripButton,
				this.ResetSearchToolStripButton
			});
			this.statusBarToolStrip.Location = new global::System.Drawing.Point(0, 0);
			this.statusBarToolStrip.Name = "statusBarToolStrip";
			this.statusBarToolStrip.Size = new global::System.Drawing.Size(964, 25);
			this.statusBarToolStrip.Stretch = true;
			this.statusBarToolStrip.TabIndex = 1;
			this.statusBarToolStrip.Text = "Status Bar Tools";
			this.RunToolStripButton.Checked = true;
			this.RunToolStripButton.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.RunToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Play;
			this.RunToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.RunToolStripButton.Name = "RunToolStripButton";
			this.RunToolStripButton.Size = new global::System.Drawing.Size(138, 22);
			this.RunToolStripButton.Text = "Click to Auto Refresh";
			this.RunToolStripButton.ToolTipText = "Automatically update and scroll the display to show that latest results";
			this.RunToolStripButton.Click += this.RunToolStripButton_Click;
			this.PauseToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PauseToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Pause;
			this.PauseToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.PauseToolStripButton.Name = "PauseToolStripButton";
			this.PauseToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.PauseToolStripButton.Text = "Pause";
			this.PauseToolStripButton.ToolTipText = "Click to freeze the display and analyze results without any updates.";
			this.PauseToolStripButton.Click += this.PauseToolStripButton_Click;
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.MoveFirstToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MoveFirstToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.FastReverse;
			this.MoveFirstToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.MoveFirstToolStripButton.Name = "MoveFirstToolStripButton";
			this.MoveFirstToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.MoveFirstToolStripButton.Text = "Move First";
			this.MoveFirstToolStripButton.ToolTipText = "Move to the first (oldest) result";
			this.MoveFirstToolStripButton.Click += this.MoveFirstToolStripButton_Click;
			this.MoveLastToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MoveLastToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.FastForward;
			this.MoveLastToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.MoveLastToolStripButton.Name = "MoveLastToolStripButton";
			this.MoveLastToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.MoveLastToolStripButton.Text = "Move Last";
			this.MoveLastToolStripButton.ToolTipText = "Move to the last (most current) record";
			this.MoveLastToolStripButton.Click += this.MoveLastToolStripButton_Click;
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			this.ToolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.SaveToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Save;
			this.SaveToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.SaveToolStripButton.Name = "SaveToolStripButton";
			this.SaveToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.SaveToolStripButton.Text = "Save";
			this.SaveToolStripButton.ToolTipText = "Package and Send session information to a file or via email";
			this.SaveToolStripButton.Click += this.SaveToolStripButton_Click;
			this.CopyToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CopyToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Copy;
			this.CopyToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.CopyToolStripButton.Name = "CopyToolStripButton";
			this.CopyToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.CopyToolStripButton.Text = "Copy";
			this.CopyToolStripButton.ToolTipText = "Copy the entire grid to the clipboard";
			this.CopyToolStripButton.Click += this.CopyToolStripButton_Click;
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.downloadToolStripButton.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.downloadToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.downloadToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Download;
			this.downloadToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.downloadToolStripButton.Name = "downloadToolStripButton";
			this.downloadToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.downloadToolStripButton.Text = "Go to the Gibraltar Software Webpage and check for updates";
			this.downloadToolStripButton.Click += this.downloadToolStripButton_Click;
			this.ShowDetailsToolStripButton.Checked = true;
			this.ShowDetailsToolStripButton.CheckOnClick = true;
			this.ShowDetailsToolStripButton.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.ShowDetailsToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ShowDetailsToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Code;
			this.ShowDetailsToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ShowDetailsToolStripButton.Name = "ShowDetailsToolStripButton";
			this.ShowDetailsToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.ShowDetailsToolStripButton.Text = "Show Details";
			this.ShowDetailsToolStripButton.ToolTipText = "Include details about the thread and call information like class, method, and source code location.";
			this.ShowDetailsToolStripButton.Click += this.ShowDetailsToolStripButton_Click;
			this.ClearToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ClearToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.DeleteMessages;
			this.ClearToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ClearToolStripButton.Name = "ClearToolStripButton";
			this.ClearToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.ClearToolStripButton.Text = "Clear";
			this.ClearToolStripButton.ToolTipText = "Clear all messages from the grid";
			this.ClearToolStripButton.Click += this.ClearToolStripButton_Click;
			this.DetailsToolStripSeparator.Name = "DetailsToolStripSeparator";
			this.DetailsToolStripSeparator.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new global::System.Drawing.Size(39, 22);
			this.toolStripLabel1.Text = "Show:";
			this.ViewerStatusToolStripLabel.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.ViewerStatusToolStripLabel.Name = "ViewerStatusToolStripLabel";
			this.ViewerStatusToolStripLabel.Size = new global::System.Drawing.Size(93, 22);
			this.ViewerStatusToolStripLabel.Text = "<Viewer Status>";
			this.CriticalToolStripButton.CheckOnClick = true;
			this.CriticalToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CriticalToolStripButton.Image");
			this.CriticalToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.CriticalToolStripButton.Name = "CriticalToolStripButton";
			this.CriticalToolStripButton.Size = new global::System.Drawing.Size(33, 22);
			this.CriticalToolStripButton.Text = "0";
			this.CriticalToolStripButton.ToolTipText = "Click to show only Critical severity (narrowest filter)";
			this.CriticalToolStripButton.Click += this.CriticalToolStripButton_Click;
			this.ErrorToolStripButton.CheckOnClick = true;
			this.ErrorToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ErrorToolStripButton.Image");
			this.ErrorToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ErrorToolStripButton.Name = "ErrorToolStripButton";
			this.ErrorToolStripButton.Size = new global::System.Drawing.Size(33, 22);
			this.ErrorToolStripButton.Text = "0";
			this.ErrorToolStripButton.ToolTipText = "Click to show only severity of Error and above";
			this.ErrorToolStripButton.Click += this.ErrorToolStripButton_Click;
			this.WarningToolStripButton.CheckOnClick = true;
			this.WarningToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WarningToolStripButton.Image");
			this.WarningToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.WarningToolStripButton.Name = "WarningToolStripButton";
			this.WarningToolStripButton.Size = new global::System.Drawing.Size(33, 22);
			this.WarningToolStripButton.Text = "0";
			this.WarningToolStripButton.ToolTipText = "Click to show only severity of Warning and above";
			this.WarningToolStripButton.Click += this.WarningToolStripButton_Click;
			this.InformationToolStripButton.CheckOnClick = true;
			this.InformationToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InformationToolStripButton.Image");
			this.InformationToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.InformationToolStripButton.Name = "InformationToolStripButton";
			this.InformationToolStripButton.Size = new global::System.Drawing.Size(33, 22);
			this.InformationToolStripButton.Text = "0";
			this.InformationToolStripButton.ToolTipText = "Click to show only severity of Information and above";
			this.InformationToolStripButton.Click += this.InformationToolStripButton_Click;
			this.VerboseToolStripButton.CheckOnClick = true;
			this.VerboseToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("VerboseToolStripButton.Image");
			this.VerboseToolStripButton.Name = "VerboseToolStripButton";
			this.VerboseToolStripButton.Size = new global::System.Drawing.Size(33, 22);
			this.VerboseToolStripButton.Text = "0";
			this.VerboseToolStripButton.ToolTipText = "Click to hide messages with Verbose severity";
			this.VerboseToolStripButton.Click += this.VerboseToolStripButton_Click;
			this.SearchToolStripTextBox.AcceptsReturn = true;
			this.SearchToolStripTextBox.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.Append;
			this.SearchToolStripTextBox.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.SearchToolStripTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.SearchToolStripTextBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SearchToolStripTextBox.ForeColor = global::System.Drawing.SystemColors.InactiveCaptionText;
			this.SearchToolStripTextBox.Margin = new global::System.Windows.Forms.Padding(6, 0, 1, 0);
			this.SearchToolStripTextBox.Name = "SearchToolStripTextBox";
			this.SearchToolStripTextBox.Size = new global::System.Drawing.Size(100, 25);
			this.SearchToolStripTextBox.Text = "Search Messages";
			this.SearchToolStripTextBox.Leave += this.SearchToolStripTextBox_Leave;
			this.SearchToolStripTextBox.KeyDown += this.SearchToolStripTextBox_KeyDown;
			this.SearchToolStripTextBox.Enter += this.SearchToolStripTextBox_Enter;
			this.SearchToolStripTextBox.TextChanged += this.SearchToolStripTextBox_TextChanged;
			this.SearchToolStripButton.Checked = true;
			this.SearchToolStripButton.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.SearchToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SearchToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.Search;
			this.SearchToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.SearchToolStripButton.Name = "SearchToolStripButton";
			this.SearchToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.SearchToolStripButton.Text = "Search";
			this.SearchToolStripButton.Visible = false;
			this.SearchToolStripButton.Click += this.SearchToolStripButton_Click;
			this.ResetSearchToolStripButton.Checked = true;
			this.ResetSearchToolStripButton.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.ResetSearchToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ResetSearchToolStripButton.Image = global::Gibraltar.Monitor.Windows.UIResources.CancelSearch;
			this.ResetSearchToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ResetSearchToolStripButton.Name = "ResetSearchToolStripButton";
			this.ResetSearchToolStripButton.Size = new global::System.Drawing.Size(23, 22);
			this.ResetSearchToolStripButton.Text = "Reset";
			this.ResetSearchToolStripButton.Click += this.ClearSearchToolStripButton_Click;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ToolStripContainer1);
			base.Name = "LiveLogViewer";
			base.Size = new global::System.Drawing.Size(964, 625);
			base.ParentChanged += this.CMViewer_ParentChanged;
			this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
			this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
			this.ToolStripContainer1.ResumeLayout(false);
			this.ToolStripContainer1.PerformLayout();
			this.threadsViewSplitContainer.Panel1.ResumeLayout(false);
			this.threadsViewSplitContainer.Panel2.ResumeLayout(false);
			this.threadsViewSplitContainer.ResumeLayout(false);
			this.messageDetailsSplitContainer.Panel2.ResumeLayout(false);
			this.messageDetailsSplitContainer.ResumeLayout(false);
			this.statusBarToolStrip.ResumeLayout(false);
			this.statusBarToolStrip.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040007CC RID: 1996
		public const int DefaultMaxMessages = 10000;

		// Token: 0x040007CD RID: 1997
		internal const string LogCategory = "Viewer.Network";

		// Token: 0x040007CE RID: 1998
		private const string GibraltarProductName = "Gibraltar";

		// Token: 0x040007CF RID: 1999
		private const string GibraltarApplicationName = "Application Monitor";

		// Token: 0x040007D0 RID: 2000
		private readonly global::System.Collections.Generic.Queue<global::Loupe.Extensibility.Data.ILogMessage> m_MessageQueue = new global::System.Collections.Generic.Queue<global::Loupe.Extensibility.Data.ILogMessage>();

		// Token: 0x040007D1 RID: 2001
		private volatile bool m_PendingInQueue;

		// Token: 0x040007D2 RID: 2002
		private readonly object m_QueueLock = new object();

		// Token: 0x040007D3 RID: 2003
		private readonly bool m_InProcess;

		// Token: 0x040007D4 RID: 2004
		private readonly bool m_InternalGibraltar;

		// Token: 0x040007D5 RID: 2005
		private readonly global::Gibraltar.Messaging.Net.IRemoteViewerConnection m_RemoteConnection;

		// Token: 0x040007D6 RID: 2006
		private global::Gibraltar.Monitor.Windows.Internal.ToolStripTextBoxDisposeHelper m_ToolStripTextBoxDisposeHelper;

		// Token: 0x040007D7 RID: 2007
		private global::System.Drawing.Font m_ActiveSearchFont;

		// Token: 0x040007D8 RID: 2008
		private bool m_AutoDocked;

		// Token: 0x040007D9 RID: 2009
		private bool m_EnteringSearchText;

		// Token: 0x040007DA RID: 2010
		private bool m_GetPriorMessages;

		// Token: 0x040007DB RID: 2011
		private bool m_MessagesStarted;

		// Token: 0x040007DC RID: 2012
		private bool m_ViewerEnabled;

		// Token: 0x040007DD RID: 2013
		private bool m_RemoteConnected;

		// Token: 0x040007DE RID: 2014
		private bool m_AutoScroll = true;

		// Token: 0x040007DF RID: 2015
		private bool m_DetailsCollapsed;

		// Token: 0x040007E0 RID: 2016
		private global::Loupe.Extensibility.Data.LogMessageSeverity m_DefaultFilterLevel = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;

		// Token: 0x040007E1 RID: 2017
		private global::Loupe.Extensibility.Data.LogMessageSeverity m_FilterLevel = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;

		// Token: 0x040007E2 RID: 2018
		private global::Gibraltar.Monitor.Windows.Internal.GridViewer m_GridViewer;

		// Token: 0x040007E3 RID: 2019
		private bool m_ShowToolBar;

		// Token: 0x040007E4 RID: 2020
		private bool m_ShowVerboseMessages = true;

		// Token: 0x040007E5 RID: 2021
		private global::System.Drawing.Font m_InactiveSearchFont;

		// Token: 0x040007E6 RID: 2022
		private global::Loupe.Extensibility.Data.ILogMessage m_DetailedLogMessage;

		// Token: 0x040007E7 RID: 2023
		private bool m_OnLoadProcessed;

		// Token: 0x040007E8 RID: 2024
		private bool m_IdleEventRegistered;

		// Token: 0x040007E9 RID: 2025
		private bool m_FirstMessages = true;

		// Token: 0x040007ED RID: 2029
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007EE RID: 2030
		internal global::System.Windows.Forms.ToolStripButton MoveFirstToolStripButton;

		// Token: 0x040007EF RID: 2031
		internal global::System.Windows.Forms.ToolStripButton MoveLastToolStripButton;

		// Token: 0x040007F0 RID: 2032
		internal global::System.Windows.Forms.ToolStripButton ClearToolStripButton;

		// Token: 0x040007F1 RID: 2033
		internal global::System.Windows.Forms.ToolStripContainer ToolStripContainer1;

		// Token: 0x040007F2 RID: 2034
		internal global::System.Windows.Forms.ToolStrip statusBarToolStrip;

		// Token: 0x040007F3 RID: 2035
		internal global::System.Windows.Forms.ToolStripButton RunToolStripButton;

		// Token: 0x040007F4 RID: 2036
		internal global::System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;

		// Token: 0x040007F5 RID: 2037
		internal global::System.Windows.Forms.ToolStripButton SaveToolStripButton;

		// Token: 0x040007F6 RID: 2038
		internal global::System.Windows.Forms.ToolStripButton CopyToolStripButton;

		// Token: 0x040007F7 RID: 2039
		internal global::System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;

		// Token: 0x040007F8 RID: 2040
		internal global::System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;

		// Token: 0x040007F9 RID: 2041
		private global::System.Windows.Forms.ToolStripLabel ViewerStatusToolStripLabel;

		// Token: 0x040007FA RID: 2042
		private global::System.Windows.Forms.ToolStripButton ShowDetailsToolStripButton;

		// Token: 0x040007FB RID: 2043
		private global::System.Windows.Forms.ToolStripButton PauseToolStripButton;

		// Token: 0x040007FC RID: 2044
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel1;

		// Token: 0x040007FD RID: 2045
		private global::System.Windows.Forms.ToolStripButton CriticalToolStripButton;

		// Token: 0x040007FE RID: 2046
		private global::System.Windows.Forms.ToolStripButton ErrorToolStripButton;

		// Token: 0x040007FF RID: 2047
		private global::System.Windows.Forms.ToolStripButton WarningToolStripButton;

		// Token: 0x04000800 RID: 2048
		private global::System.Windows.Forms.ToolStripButton InformationToolStripButton;

		// Token: 0x04000801 RID: 2049
		private global::System.Windows.Forms.ToolStripButton VerboseToolStripButton;

		// Token: 0x04000802 RID: 2050
		private global::System.Windows.Forms.ToolStripTextBox SearchToolStripTextBox;

		// Token: 0x04000803 RID: 2051
		private global::System.Windows.Forms.ToolStripButton SearchToolStripButton;

		// Token: 0x04000804 RID: 2052
		private global::System.Windows.Forms.ToolStripButton ResetSearchToolStripButton;

		// Token: 0x04000805 RID: 2053
		private global::System.Windows.Forms.ToolStripSeparator DetailsToolStripSeparator;

		// Token: 0x04000806 RID: 2054
		private global::System.Windows.Forms.ToolStripButton downloadToolStripButton;

		// Token: 0x04000807 RID: 2055
		private global::System.Windows.Forms.SplitContainer threadsViewSplitContainer;

		// Token: 0x04000808 RID: 2056
		private global::System.Windows.Forms.SplitContainer messageDetailsSplitContainer;

		// Token: 0x04000809 RID: 2057
		private global::Gibraltar.Monitor.Windows.Internal.UIMessageDetails messageDetails;

		// Token: 0x0400080A RID: 2058
		private global::Gibraltar.Monitor.Windows.Internal.UIThreadTrackViewer uiThreadTrackViewer1;

		// Token: 0x020004AB RID: 1195
		// (Invoke) Token: 0x06003397 RID: 13207
		private delegate void ActionSetAutoScrollDelegate(bool value);

		// Token: 0x020004AC RID: 1196
		// (Invoke) Token: 0x0600339B RID: 13211
		private delegate void ActionSetMinSeverityDelegate(global::Loupe.Extensibility.Data.LogMessageSeverity minSeverity);

		// Token: 0x020004AD RID: 1197
		// (Invoke) Token: 0x0600339F RID: 13215
		private delegate void ActionDisplayConnectedInvoker(bool isConnected);
	}
}
