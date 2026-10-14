using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001DB RID: 475
	internal class UILogMessage : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060016A9 RID: 5801 RVA: 0x00047CB0 File Offset: 0x00045EB0
		public UILogMessage()
		{
			this.InitializeComponent();
			this.lblCategoryName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.lblClassName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.lblLocation.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.lblMethodName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.lblThreadId.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.lblThreadName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.lblThreadType.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtCategoryName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtClassName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtDescription.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtLocation.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtMethodName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtThreadId.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtThreadName.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.txtThreadType.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
			this.m_ShowThreadInfo = true;
			this.m_ShowLocationInfo = true;
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00047DCC File Offset: 0x00045FCC
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x00047DD4 File Offset: 0x00045FD4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::Loupe.Extensibility.Data.ILogMessage LogMessage
		{
			get
			{
				return this.m_LogMessage;
			}
			set
			{
				this.SetDisplayLogMessage(value);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00047DE0 File Offset: 0x00045FE0
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x00047DE8 File Offset: 0x00045FE8
		[global::System.ComponentModel.Description("Indicates if thread information should be displayed")]
		[global::System.ComponentModel.DefaultValue("true")]
		public bool ShowThreadInfo
		{
			get
			{
				return this.m_ShowThreadInfo;
			}
			set
			{
				this.SetDisplayThreadInfo(value);
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00047DF4 File Offset: 0x00045FF4
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00047DFC File Offset: 0x00045FFC
		[global::System.ComponentModel.Description("Indicates if source code location information should be displayed")]
		[global::System.ComponentModel.DefaultValue("true")]
		public bool ShowLocationInfo
		{
			get
			{
				return this.m_ShowLocationInfo;
			}
			set
			{
				this.SetDisplayLocationInfo(value);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00047E08 File Offset: 0x00046008
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x00047E10 File Offset: 0x00046010
		[global::System.ComponentModel.Description("Indicates if the description text area should use a fixed width font and suppress line wrap")]
		[global::System.ComponentModel.DefaultValue("false")]
		public bool ShowDescriptionPreformatted
		{
			get
			{
				return this.m_ShowDescriptionPreformatted;
			}
			set
			{
				this.SetDisplayDescriptionPreformatted(value);
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00047E1C File Offset: 0x0004601C
		private void SetDisplayBackColor()
		{
			this.txtCategoryName.BackColor = this.BackColor;
			this.txtClassName.BackColor = this.BackColor;
			this.txtDescription.BackColor = this.BackColor;
			this.txtLocation.BackColor = this.BackColor;
			this.txtMethodName.BackColor = this.BackColor;
			this.txtThreadId.BackColor = this.BackColor;
			this.txtThreadName.BackColor = this.BackColor;
			this.txtThreadType.BackColor = this.BackColor;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00047EB8 File Offset: 0x000460B8
		private void SetDisplayLogMessage(global::Loupe.Extensibility.Data.ILogMessage logMessage)
		{
			if (this.m_LogMessage == logMessage && this.m_DesignerCleared)
			{
				return;
			}
			this.m_LogMessage = logMessage;
			if (this.m_LogMessage == null)
			{
				this.txtCategoryName.Text = string.Empty;
				this.txtClassName.Text = string.Empty;
				this.txtMethodName.Text = string.Empty;
				this.txtLocation.Text = string.Empty;
				this.locationPanel.Visible = false;
				this.txtLocation.Text = string.Empty;
				this.txtThreadId.Text = string.Empty;
				this.txtThreadName.Text = string.Empty;
				this.txtThreadType.Text = string.Empty;
				this.txtDescription.Lines = null;
			}
			else
			{
				string text = this.m_LogMessage.Caption;
				if (string.IsNullOrEmpty(text))
				{
					text = string.Empty;
				}
				else
				{
					text = text.Trim();
					if (!string.IsNullOrEmpty(this.m_LogMessage.Description))
					{
						char c = text[text.Length - 1];
						if (c != '.' && c != ':' && c != '-')
						{
							text += ":";
						}
					}
					text += "\r\n";
				}
				if (!string.IsNullOrEmpty(this.m_LogMessage.Description))
				{
					text += this.m_LogMessage.Description;
					char c2 = text[text.Length - 1];
					if (c2 != '\r' && c2 != '\n')
					{
						text += "\r\n";
					}
				}
				string[] lines = text.Split(global::Gibraltar.Monitor.Windows.UILogMessage.LineBreakTokens, global::System.StringSplitOptions.None);
				this.txtDescription.Lines = lines;
				this.txtCategoryName.Text = this.m_LogMessage.CategoryName;
				if (!this.m_LogMessage.HasMethodInfo)
				{
					this.txtClassName.Text = "(unknown)";
					this.txtMethodName.Text = "(unknown)";
					this.locationPanel.Visible = false;
				}
				else
				{
					this.txtClassName.Text = this.m_LogMessage.ClassName;
					this.txtMethodName.Text = this.m_LogMessage.MethodName;
				}
				if (!this.m_LogMessage.HasSourceLocation)
				{
					this.locationPanel.Visible = false;
				}
				else
				{
					this.locationPanel.Visible = this.m_ShowLocationInfo;
					if (this.m_LogMessage.LineNumber > 0)
					{
						this.txtLocation.Text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Line {0} of file '{1}'", new object[]
						{
							this.m_LogMessage.LineNumber,
							this.m_LogMessage.FileName
						});
					}
					else
					{
						this.txtLocation.Text = this.m_LogMessage.FileName;
					}
				}
				if (!this.m_LogMessage.HasThreadInfo)
				{
					this.txtThreadId.Text = "(unknown)";
					this.txtThreadName.Text = "(unknown)";
					this.txtThreadType.Text = "(unknown)";
				}
				else
				{
					this.txtThreadId.Text = this.m_LogMessage.ThreadId.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					this.txtThreadName.Text = this.m_LogMessage.ThreadName;
					string text2 = this.m_LogMessage.IsBackground ? "Background" : "Foreground";
					if (this.m_LogMessage.IsThreadPoolThread)
					{
						text2 += ", Pooled";
					}
					this.txtThreadType.Text = text2;
				}
			}
			this.m_DesignerCleared = true;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0004826C File Offset: 0x0004646C
		private void SetDisplayLocationInfo(bool visible)
		{
			if (visible == this.m_ShowLocationInfo)
			{
				return;
			}
			this.m_ShowLocationInfo = visible;
			this.locationPanel.Visible = this.m_ShowLocationInfo;
			this.mainLayoutPanel.RowStyles[global::Gibraltar.Monitor.Windows.UILogMessage.LocationRowIndex].Height = (float)(this.m_ShowLocationInfo ? this.txtLocation.Height : 0);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000482DC File Offset: 0x000464DC
		private void SetDisplayThreadInfo(bool visible)
		{
			if (visible == this.m_ShowThreadInfo)
			{
				return;
			}
			this.m_ShowThreadInfo = visible;
			this.threadPanel.Visible = this.m_ShowThreadInfo;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00048304 File Offset: 0x00046504
		private void SetDisplayDescriptionPreformatted(bool value)
		{
			if (value == this.m_ShowDescriptionPreformatted)
			{
				return;
			}
			this.m_ShowDescriptionPreformatted = value;
			if (this.m_ShowDescriptionPreformatted)
			{
				this.txtDescription.Font = global::Gibraltar.Windows.UI.FormTools.FixedWidthFont;
				this.txtDescription.WordWrap = false;
			}
			else
			{
				this.txtDescription.Font = global::Gibraltar.Windows.UI.FormTools.OSFont;
				this.txtDescription.WordWrap = true;
			}
			if (this.chkShowDescriptionPreformatted.Checked != value)
			{
				this.chkShowDescriptionPreformatted.Checked = value;
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00048390 File Offset: 0x00046590
		protected override void OnBackColorChanged(global::System.EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.SetDisplayBackColor();
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000483A0 File Offset: 0x000465A0
		private void txtLocation_Click(object sender, global::System.EventArgs e)
		{
			string text = string.Empty;
			try
			{
				text = this.m_LogMessage.FileName;
				if (global::System.IO.File.Exists(text))
				{
					global::System.Diagnostics.Process.Start(text);
				}
			}
			catch (global::System.Exception ex)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.User Interface.Session Viewer", "Unable to open source code file", "File: '{0}'\r\nException ({1}): {2}", new object[]
				{
					text,
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00048424 File Offset: 0x00046624
		private void UILogMessage_Resize(object sender, global::System.EventArgs e)
		{
			bool flag = base.Height > 300;
			this.mainLayoutPanel.RowStyles[this.mainLayoutPanel.RowCount - 1].Height = (float)(flag ? 20 : 0);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00048474 File Offset: 0x00046674
		private void chkShowDescriptionPreformatted_CheckedChanged(object sender, global::System.EventArgs e)
		{
			this.ShowDescriptionPreformatted = this.chkShowDescriptionPreformatted.Checked;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00048488 File Offset: 0x00046688
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000484B0 File Offset: 0x000466B0
		private void InitializeComponent()
		{
			this.mainLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.chkShowDescriptionPreformatted = new global::System.Windows.Forms.CheckBox();
			this.descriptionPanel = new global::System.Windows.Forms.Panel();
			this.txtDescription = new global::System.Windows.Forms.TextBox();
			this.callInfoPanel = new global::System.Windows.Forms.Panel();
			this.txtCategoryName = new global::System.Windows.Forms.TextBox();
			this.lblCategoryName = new global::System.Windows.Forms.Label();
			this.txtMethodName = new global::System.Windows.Forms.TextBox();
			this.txtClassName = new global::System.Windows.Forms.TextBox();
			this.lblMethodName = new global::System.Windows.Forms.Label();
			this.lblClassName = new global::System.Windows.Forms.Label();
			this.threadPanel = new global::System.Windows.Forms.Panel();
			this.txtThreadType = new global::System.Windows.Forms.TextBox();
			this.txtThreadId = new global::System.Windows.Forms.TextBox();
			this.txtThreadName = new global::System.Windows.Forms.TextBox();
			this.lblThreadType = new global::System.Windows.Forms.Label();
			this.lblThreadName = new global::System.Windows.Forms.Label();
			this.lblThreadId = new global::System.Windows.Forms.Label();
			this.locationPanel = new global::System.Windows.Forms.Panel();
			this.txtLocation = new global::System.Windows.Forms.TextBox();
			this.lblLocation = new global::System.Windows.Forms.Label();
			this.mainLayoutPanel.SuspendLayout();
			this.descriptionPanel.SuspendLayout();
			this.callInfoPanel.SuspendLayout();
			this.threadPanel.SuspendLayout();
			this.locationPanel.SuspendLayout();
			base.SuspendLayout();
			this.mainLayoutPanel.ColumnCount = 2;
			this.mainLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 70f));
			this.mainLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 30f));
			this.mainLayoutPanel.Controls.Add(this.chkShowDescriptionPreformatted, 0, 3);
			this.mainLayoutPanel.Controls.Add(this.descriptionPanel, 0, 2);
			this.mainLayoutPanel.Controls.Add(this.callInfoPanel, 0, 0);
			this.mainLayoutPanel.Controls.Add(this.threadPanel, 1, 0);
			this.mainLayoutPanel.Controls.Add(this.locationPanel, 0, 1);
			this.mainLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.mainLayoutPanel.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.mainLayoutPanel.Location = new global::System.Drawing.Point(0, 0);
			this.mainLayoutPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.mainLayoutPanel.Name = "mainLayoutPanel";
			this.mainLayoutPanel.RowCount = 4;
			this.mainLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 50f));
			this.mainLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 15f));
			this.mainLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.mainLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.mainLayoutPanel.Size = new global::System.Drawing.Size(742, 305);
			this.mainLayoutPanel.TabIndex = 0;
			this.chkShowDescriptionPreformatted.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.chkShowDescriptionPreformatted.AutoSize = true;
			this.mainLayoutPanel.SetColumnSpan(this.chkShowDescriptionPreformatted, 2);
			this.chkShowDescriptionPreformatted.Location = new global::System.Drawing.Point(3, 285);
			this.chkShowDescriptionPreformatted.Margin = new global::System.Windows.Forms.Padding(3, 0, 3, 3);
			this.chkShowDescriptionPreformatted.Name = "chkShowDescriptionPreformatted";
			this.chkShowDescriptionPreformatted.Size = new global::System.Drawing.Size(287, 17);
			this.chkShowDescriptionPreformatted.TabIndex = 5;
			this.chkShowDescriptionPreformatted.Text = "Show Description as Preformatted, fixed width text";
			this.chkShowDescriptionPreformatted.UseVisualStyleBackColor = true;
			this.chkShowDescriptionPreformatted.CheckedChanged += this.chkShowDescriptionPreformatted_CheckedChanged;
			this.mainLayoutPanel.SetColumnSpan(this.descriptionPanel, 2);
			this.descriptionPanel.Controls.Add(this.txtDescription);
			this.descriptionPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.descriptionPanel.Location = new global::System.Drawing.Point(0, 68);
			this.descriptionPanel.Margin = new global::System.Windows.Forms.Padding(0, 3, 0, 3);
			this.descriptionPanel.Name = "descriptionPanel";
			this.descriptionPanel.Size = new global::System.Drawing.Size(742, 214);
			this.descriptionPanel.TabIndex = 3;
			this.txtDescription.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Location = new global::System.Drawing.Point(0, 0);
			this.txtDescription.Margin = new global::System.Windows.Forms.Padding(0);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtDescription.Size = new global::System.Drawing.Size(742, 214);
			this.txtDescription.TabIndex = 1;
			this.txtDescription.Text = "<Description>";
			this.callInfoPanel.Controls.Add(this.txtCategoryName);
			this.callInfoPanel.Controls.Add(this.lblCategoryName);
			this.callInfoPanel.Controls.Add(this.txtMethodName);
			this.callInfoPanel.Controls.Add(this.txtClassName);
			this.callInfoPanel.Controls.Add(this.lblMethodName);
			this.callInfoPanel.Controls.Add(this.lblClassName);
			this.callInfoPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.callInfoPanel.Location = new global::System.Drawing.Point(0, 0);
			this.callInfoPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.callInfoPanel.Name = "callInfoPanel";
			this.callInfoPanel.Size = new global::System.Drawing.Size(519, 50);
			this.callInfoPanel.TabIndex = 1;
			this.txtCategoryName.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtCategoryName.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtCategoryName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtCategoryName.Location = new global::System.Drawing.Point(92, 3);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.ReadOnly = true;
			this.txtCategoryName.Size = new global::System.Drawing.Size(424, 15);
			this.txtCategoryName.TabIndex = 6;
			this.txtCategoryName.Text = "<Category Name>";
			this.lblCategoryName.AutoSize = true;
			this.lblCategoryName.Location = new global::System.Drawing.Point(3, 3);
			this.lblCategoryName.Margin = new global::System.Windows.Forms.Padding(3, 3, 3, 0);
			this.lblCategoryName.Name = "lblCategoryName";
			this.lblCategoryName.Size = new global::System.Drawing.Size(56, 13);
			this.lblCategoryName.TabIndex = 5;
			this.lblCategoryName.Text = "Category:";
			this.txtMethodName.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtMethodName.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtMethodName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtMethodName.Location = new global::System.Drawing.Point(92, 35);
			this.txtMethodName.Name = "txtMethodName";
			this.txtMethodName.ReadOnly = true;
			this.txtMethodName.Size = new global::System.Drawing.Size(424, 15);
			this.txtMethodName.TabIndex = 4;
			this.txtMethodName.Text = "<Method Name>";
			this.txtClassName.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtClassName.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtClassName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtClassName.Location = new global::System.Drawing.Point(92, 19);
			this.txtClassName.Name = "txtClassName";
			this.txtClassName.ReadOnly = true;
			this.txtClassName.Size = new global::System.Drawing.Size(424, 15);
			this.txtClassName.TabIndex = 3;
			this.txtClassName.Text = "<Class Name>";
			this.lblMethodName.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.lblMethodName.AutoSize = true;
			this.lblMethodName.Location = new global::System.Drawing.Point(3, 35);
			this.lblMethodName.Name = "lblMethodName";
			this.lblMethodName.Size = new global::System.Drawing.Size(83, 13);
			this.lblMethodName.TabIndex = 1;
			this.lblMethodName.Text = "Method Name:";
			this.lblClassName.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.lblClassName.AutoSize = true;
			this.lblClassName.Location = new global::System.Drawing.Point(3, 19);
			this.lblClassName.Name = "lblClassName";
			this.lblClassName.Size = new global::System.Drawing.Size(68, 13);
			this.lblClassName.TabIndex = 0;
			this.lblClassName.Text = "Class Name:";
			this.threadPanel.Controls.Add(this.txtThreadType);
			this.threadPanel.Controls.Add(this.txtThreadId);
			this.threadPanel.Controls.Add(this.txtThreadName);
			this.threadPanel.Controls.Add(this.lblThreadType);
			this.threadPanel.Controls.Add(this.lblThreadName);
			this.threadPanel.Controls.Add(this.lblThreadId);
			this.threadPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.threadPanel.Location = new global::System.Drawing.Point(519, 0);
			this.threadPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.threadPanel.Name = "threadPanel";
			this.threadPanel.Size = new global::System.Drawing.Size(223, 50);
			this.threadPanel.TabIndex = 2;
			this.txtThreadType.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtThreadType.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtThreadType.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtThreadType.Location = new global::System.Drawing.Point(78, 35);
			this.txtThreadType.Name = "txtThreadType";
			this.txtThreadType.ReadOnly = true;
			this.txtThreadType.Size = new global::System.Drawing.Size(142, 15);
			this.txtThreadType.TabIndex = 6;
			this.txtThreadType.Text = "<Thread Type>";
			this.txtThreadId.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtThreadId.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtThreadId.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtThreadId.Location = new global::System.Drawing.Point(78, 3);
			this.txtThreadId.Name = "txtThreadId";
			this.txtThreadId.ReadOnly = true;
			this.txtThreadId.Size = new global::System.Drawing.Size(142, 15);
			this.txtThreadId.TabIndex = 5;
			this.txtThreadId.Text = "<Thread Id>";
			this.txtThreadName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtThreadName.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtThreadName.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtThreadName.Location = new global::System.Drawing.Point(78, 19);
			this.txtThreadName.Name = "txtThreadName";
			this.txtThreadName.ReadOnly = true;
			this.txtThreadName.Size = new global::System.Drawing.Size(142, 15);
			this.txtThreadName.TabIndex = 4;
			this.txtThreadName.Text = "<Thread Name>";
			this.lblThreadType.AutoSize = true;
			this.lblThreadType.Location = new global::System.Drawing.Point(0, 35);
			this.lblThreadType.Name = "lblThreadType";
			this.lblThreadType.Size = new global::System.Drawing.Size(71, 13);
			this.lblThreadType.TabIndex = 3;
			this.lblThreadType.Text = "Thread Type:";
			this.lblThreadName.AutoSize = true;
			this.lblThreadName.Location = new global::System.Drawing.Point(0, 19);
			this.lblThreadName.Name = "lblThreadName";
			this.lblThreadName.Size = new global::System.Drawing.Size(77, 13);
			this.lblThreadName.TabIndex = 2;
			this.lblThreadName.Text = "Thread Name:";
			this.lblThreadId.AutoSize = true;
			this.lblThreadId.Location = new global::System.Drawing.Point(0, 3);
			this.lblThreadId.Name = "lblThreadId";
			this.lblThreadId.Size = new global::System.Drawing.Size(58, 13);
			this.lblThreadId.TabIndex = 1;
			this.lblThreadId.Text = "Thread Id:";
			this.mainLayoutPanel.SetColumnSpan(this.locationPanel, 2);
			this.locationPanel.Controls.Add(this.txtLocation);
			this.locationPanel.Controls.Add(this.lblLocation);
			this.locationPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.locationPanel.Location = new global::System.Drawing.Point(3, 50);
			this.locationPanel.Margin = new global::System.Windows.Forms.Padding(3, 0, 3, 0);
			this.locationPanel.Name = "locationPanel";
			this.locationPanel.Size = new global::System.Drawing.Size(736, 15);
			this.locationPanel.TabIndex = 4;
			this.txtLocation.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtLocation.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtLocation.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtLocation.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtLocation.ForeColor = global::System.Drawing.SystemColors.HotTrack;
			this.txtLocation.Location = new global::System.Drawing.Point(89, 0);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.ReadOnly = true;
			this.txtLocation.Size = new global::System.Drawing.Size(641, 15);
			this.txtLocation.TabIndex = 5;
			this.txtLocation.Text = "<Location>";
			this.txtLocation.Click += this.txtLocation_Click;
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new global::System.Drawing.Point(0, 0);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new global::System.Drawing.Size(54, 13);
			this.lblLocation.TabIndex = 2;
			this.lblLocation.Text = "Location:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Controls.Add(this.mainLayoutPanel);
			base.Margin = new global::System.Windows.Forms.Padding(0);
			base.Name = "UILogMessage";
			base.Size = new global::System.Drawing.Size(742, 305);
			base.Resize += this.UILogMessage_Resize;
			this.mainLayoutPanel.ResumeLayout(false);
			this.mainLayoutPanel.PerformLayout();
			this.descriptionPanel.ResumeLayout(false);
			this.descriptionPanel.PerformLayout();
			this.callInfoPanel.ResumeLayout(false);
			this.callInfoPanel.PerformLayout();
			this.threadPanel.ResumeLayout(false);
			this.threadPanel.PerformLayout();
			this.locationPanel.ResumeLayout(false);
			this.locationPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000790 RID: 1936
		private static readonly string[] LineBreakTokens = new string[]
		{
			"\r\n",
			"\n\r",
			"\n",
			"\r"
		};

		// Token: 0x04000791 RID: 1937
		private static int LocationRowIndex = 1;

		// Token: 0x04000792 RID: 1938
		private global::Loupe.Extensibility.Data.ILogMessage m_LogMessage;

		// Token: 0x04000793 RID: 1939
		private bool m_DesignerCleared;

		// Token: 0x04000794 RID: 1940
		private bool m_ShowThreadInfo;

		// Token: 0x04000795 RID: 1941
		private bool m_ShowLocationInfo;

		// Token: 0x04000796 RID: 1942
		private bool m_ShowDescriptionPreformatted;

		// Token: 0x04000797 RID: 1943
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000798 RID: 1944
		private global::System.Windows.Forms.TableLayoutPanel mainLayoutPanel;

		// Token: 0x04000799 RID: 1945
		private global::System.Windows.Forms.Panel callInfoPanel;

		// Token: 0x0400079A RID: 1946
		private global::System.Windows.Forms.TextBox txtClassName;

		// Token: 0x0400079B RID: 1947
		private global::System.Windows.Forms.Label lblLocation;

		// Token: 0x0400079C RID: 1948
		private global::System.Windows.Forms.Label lblMethodName;

		// Token: 0x0400079D RID: 1949
		private global::System.Windows.Forms.Label lblClassName;

		// Token: 0x0400079E RID: 1950
		private global::System.Windows.Forms.TextBox txtLocation;

		// Token: 0x0400079F RID: 1951
		private global::System.Windows.Forms.TextBox txtMethodName;

		// Token: 0x040007A0 RID: 1952
		private global::System.Windows.Forms.Panel threadPanel;

		// Token: 0x040007A1 RID: 1953
		private global::System.Windows.Forms.Label lblThreadName;

		// Token: 0x040007A2 RID: 1954
		private global::System.Windows.Forms.Label lblThreadId;

		// Token: 0x040007A3 RID: 1955
		private global::System.Windows.Forms.TextBox txtThreadType;

		// Token: 0x040007A4 RID: 1956
		private global::System.Windows.Forms.TextBox txtThreadId;

		// Token: 0x040007A5 RID: 1957
		private global::System.Windows.Forms.TextBox txtThreadName;

		// Token: 0x040007A6 RID: 1958
		private global::System.Windows.Forms.Label lblThreadType;

		// Token: 0x040007A7 RID: 1959
		private global::System.Windows.Forms.Panel descriptionPanel;

		// Token: 0x040007A8 RID: 1960
		private global::System.Windows.Forms.TextBox txtDescription;

		// Token: 0x040007A9 RID: 1961
		private global::System.Windows.Forms.Panel locationPanel;

		// Token: 0x040007AA RID: 1962
		private global::System.Windows.Forms.TextBox txtCategoryName;

		// Token: 0x040007AB RID: 1963
		private global::System.Windows.Forms.Label lblCategoryName;

		// Token: 0x040007AC RID: 1964
		private global::System.Windows.Forms.CheckBox chkShowDescriptionPreformatted;
	}
}
