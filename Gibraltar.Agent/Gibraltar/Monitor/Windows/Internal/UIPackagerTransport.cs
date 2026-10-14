using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001F4 RID: 500
	internal class UIPackagerTransport : global::System.Windows.Forms.UserControl, global::Gibraltar.Windows.UI.IUIWizardInputPage, global::Gibraltar.Windows.UI.IUIWizardPage
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x0005590C File Offset: 0x00053B0C
		public UIPackagerTransport(global::Gibraltar.Monitor.PackagerConfiguration configuration, global::Gibraltar.Monitor.Windows.Internal.PackagerRequest request)
		{
			this.m_Configuration = configuration;
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
			if (!request.AllowEmail)
			{
				this.optSendToEmail.Visible = false;
				this.emailOptionsPanel.Visible = false;
			}
			else
			{
				if (!string.IsNullOrEmpty(this.m_Configuration.DestinationEmailAddress))
				{
					this.lblDestinationEmailAddress.Visible = false;
					this.txtEmailAddress.Visible = false;
					this.fromEmailOptionsPanel.Top = 0;
					this.emailOptionsPanel.Height = this.fromEmailOptionsPanel.Height;
					this.txtEmailAddress.Text = this.m_Configuration.DestinationEmailAddress;
				}
				if (!string.IsNullOrEmpty(this.m_Configuration.FromEmailAddress))
				{
					this.fromEmailOptionsPanel.Visible = false;
					this.emailOptionsPanel.Height = this.optSaveToFile.Height;
					this.txtFromEmailAddress.Text = this.m_Configuration.FromEmailAddress;
				}
			}
			if (!request.AllowFile)
			{
				this.optSaveToFile.Visible = false;
				this.fileOptionsPanel.Visible = false;
			}
			if (!request.AllowRemovableMedia)
			{
				this.optSaveToRemovableMedia.Visible = false;
				this.removableMediaOptionsPanel.Visible = false;
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x060018A6 RID: 6310 RVA: 0x00055A58 File Offset: 0x00053C58
		// (remove) Token: 0x060018A7 RID: 6311 RVA: 0x00055A94 File Offset: 0x00053C94
		public event global::System.EventHandler IsValidChanged;

		// Token: 0x060018A8 RID: 6312 RVA: 0x00055AD0 File Offset: 0x00053CD0
		public void Initialize(object requestData)
		{
			this.m_Request = (global::Gibraltar.Monitor.Windows.Internal.PackagerRequest)requestData;
			this.m_NextEnabled = false;
			this.InitializeDriveCombo();
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00055AEC File Offset: 0x00053CEC
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00055AF4 File Offset: 0x00053CF4
		public string Instructions
		{
			get
			{
				return this.m_Instructions;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00055AFC File Offset: 0x00053CFC
		public bool IsValid
		{
			get
			{
				return this.m_NextEnabled;
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00055B04 File Offset: 0x00053D04
		public bool Store()
		{
			if (this.optSaveToRemovableMedia.Checked)
			{
				this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.RemovableMedia;
				global::System.IO.DriveInfo driveInfo = (global::System.IO.DriveInfo)this.cboVolumeSelect.SelectedValue;
				this.m_Request.FileNamePath = driveInfo.RootDirectory.FullName;
			}
			else if (this.optSaveToFile.Checked)
			{
				this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.File;
				this.m_Request.FileNamePath = this.txtFileNamePath.Text;
			}
			else if (this.optSendToEmail.Checked)
			{
				this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Email;
				this.m_Request.DestinationEmailAddress = this.txtEmailAddress.Text;
				this.m_Request.FromEmailAddress = this.txtFromEmailAddress.Text;
			}
			return true;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00055BE0 File Offset: 0x00053DE0
		public void OnEnter()
		{
			if (this.m_Request.Transport == global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Server)
			{
				if (this.m_Request.AllowEmail)
				{
					this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Email;
				}
				else if (this.m_Request.AllowFile)
				{
					this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.File;
				}
				else
				{
					if (!this.m_Request.AllowRemovableMedia)
					{
						throw new global::System.InvalidOperationException("The server couldn't be contacted, no other communication method is allowed, and somehow we got to the package transport page.  huh.");
					}
					this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.RemovableMedia;
				}
			}
			int num = 0;
			string title = null;
			if (this.m_Request.AllowEmail)
			{
				num++;
				this.optSendToEmail.Visible = true;
				this.lblSendToEmail.Visible = true;
				this.emailOptionsPanel.Visible = true;
				title = this.lblSendToEmail.Text;
			}
			else
			{
				this.optSendToEmail.Visible = false;
				this.lblSendToEmail.Visible = false;
				this.emailOptionsPanel.Visible = false;
			}
			if (this.m_Request.AllowFile)
			{
				num++;
				this.optSaveToFile.Visible = true;
				this.lblSaveToFile.Visible = true;
				this.fileOptionsPanel.Visible = true;
				title = this.lblSaveToFile.Text;
			}
			else
			{
				this.optSaveToFile.Visible = false;
				this.lblSaveToFile.Visible = false;
				this.fileOptionsPanel.Visible = false;
			}
			if (this.m_Request.AllowRemovableMedia)
			{
				num++;
				this.optSaveToRemovableMedia.Visible = true;
				this.lblSaveToRemovableMedia.Visible = true;
				this.removableMediaOptionsPanel.Visible = true;
				title = this.lblSaveToRemovableMedia.Text;
			}
			else
			{
				this.optSaveToRemovableMedia.Visible = false;
				this.lblSaveToRemovableMedia.Visible = false;
				this.removableMediaOptionsPanel.Visible = false;
			}
			if (num == 1)
			{
				this.m_Title = title;
				this.m_Instructions = "Complete the following then click Next to package and send your information.";
				this.optSendToEmail.Visible = false;
				this.optSaveToFile.Visible = false;
				this.optSaveToRemovableMedia.Visible = false;
			}
			else
			{
				this.m_Title = "Where do you want to send this information?";
				this.m_Instructions = "Pick where you want to send this information from the list below then click Next to package and send your information.";
				this.lblSendToEmail.Visible = false;
				this.lblSaveToFile.Visible = false;
				this.lblSaveToRemovableMedia.Visible = false;
			}
			switch (this.m_Request.Transport)
			{
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.File:
				this.optSaveToFile.Checked = true;
				break;
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.RemovableMedia:
				this.optSaveToRemovableMedia.Checked = true;
				break;
			case global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Email:
				this.optSendToEmail.Checked = true;
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
			this.txtEmailAddress.Text = this.m_Request.DestinationEmailAddress;
			this.txtFileNamePath.Text = this.m_Request.FileNamePath;
			this.ValidateData();
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00055EC8 File Offset: 0x000540C8
		protected void OnIsValidChanged()
		{
			global::System.EventHandler isValidChanged = this.IsValidChanged;
			if (isValidChanged != null)
			{
				isValidChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00055EF4 File Offset: 0x000540F4
		private void ActionFileBrowse()
		{
			using (global::System.Windows.Forms.SaveFileDialog saveFileDialog = new global::System.Windows.Forms.SaveFileDialog())
			{
				saveFileDialog.Filter = "Package File(*.glp)|*.glp|All Files (*.*)|*.*";
				saveFileDialog.RestoreDirectory = true;
				if (!string.IsNullOrEmpty(this.txtFileNamePath.Text))
				{
					saveFileDialog.FileName = this.txtFileNamePath.Text;
				}
				if (saveFileDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
				{
					this.txtFileNamePath.Text = saveFileDialog.FileName;
					this.ValidateData();
				}
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00055F84 File Offset: 0x00054184
		private void ValidateData()
		{
			bool nextEnabled = true;
			if (!this.optSaveToRemovableMedia.Checked && !this.optSendToEmail.Checked && !this.optSaveToFile.Checked)
			{
				nextEnabled = false;
				this.txtEmailAddress.Enabled = false;
				this.txtFileNamePath.Enabled = false;
				this.cboVolumeSelect.Enabled = false;
				this.btnBrowse.Enabled = false;
			}
			else
			{
				bool enabled = false;
				bool enabled2 = false;
				bool enabled3 = false;
				if (this.optSaveToRemovableMedia.Checked)
				{
					enabled3 = true;
					if (this.cboVolumeSelect.SelectedValue == null)
					{
						nextEnabled = false;
					}
					else if (!global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.IsPathValid(((global::System.IO.DriveInfo)this.cboVolumeSelect.SelectedValue).RootDirectory.FullName))
					{
						nextEnabled = false;
						this.lblRemovableMediaNotValid.Visible = true;
					}
					else
					{
						this.lblRemovableMediaNotValid.Visible = false;
					}
				}
				else if (this.optSendToEmail.Checked)
				{
					enabled = true;
					if (string.IsNullOrEmpty(this.txtEmailAddress.Text))
					{
						nextEnabled = false;
					}
				}
				else if (this.optSaveToFile.Checked)
				{
					enabled2 = true;
					string text = (this.txtFileNamePath.Text ?? string.Empty).Trim();
					if (string.IsNullOrEmpty(text))
					{
						nextEnabled = false;
					}
					else
					{
						try
						{
							nextEnabled = global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.IsPathValid(global::System.IO.Path.GetDirectoryName(text));
						}
						catch
						{
							nextEnabled = false;
						}
					}
				}
				this.lblDestinationEmailAddress.Enabled = enabled;
				this.lblFromEmailAddress.Enabled = enabled;
				this.lblFromEmailAddressInstructions.Enabled = enabled;
				this.txtEmailAddress.Enabled = enabled;
				this.txtFromEmailAddress.Enabled = enabled;
				this.lblFileName.Enabled = enabled2;
				this.txtFileNamePath.Enabled = enabled2;
				this.btnBrowse.Enabled = enabled2;
				this.lblDrive.Enabled = enabled3;
				this.cboVolumeSelect.Enabled = enabled3;
				this.lblNoRemovableMedia.Enabled = enabled3;
				this.lblRemovableMediaNotValid.Enabled = enabled3;
				this.btnRefreshRemovableMedia.Enabled = enabled3;
			}
			this.SetNextEnabled(nextEnabled);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000561B0 File Offset: 0x000543B0
		private static bool IsPathValid(string fullPath)
		{
			bool result = true;
			string path = global::System.IO.Path.Combine(fullPath, global::System.Guid.NewGuid().ToString());
			try
			{
				global::System.IO.File.WriteAllText(path, "Gibraltar Packager Test File");
			}
			catch (global::System.Exception ex)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Packager", "Error while Validating Packager Input", "While verifying write access to the selected path, an exception was thrown.  The path will not be considered valid yet.\r\nPath: {0}\r\nException: {1}", new object[]
				{
					fullPath,
					ex.Message
				});
				result = false;
			}
			finally
			{
				try
				{
					global::System.IO.File.Delete(path);
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00056258 File Offset: 0x00054458
		private void SetNextEnabled(bool enabled)
		{
			if (enabled == this.m_NextEnabled)
			{
				return;
			}
			this.m_NextEnabled = enabled;
			this.OnIsValidChanged();
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00056274 File Offset: 0x00054474
		private void InitializeDriveCombo()
		{
			global::System.IO.DriveInfo[] array = null;
			if (this.m_Configuration.AllowRemovableMedia)
			{
				this.cboVolumeSelect.DisplayMember = "Caption";
				this.cboVolumeSelect.ValueMember = "DriveInfo";
				try
				{
					array = global::System.IO.DriveInfo.GetDrives();
				}
				catch (global::System.Exception exception)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent.Packager", "Unable to scan drive information", "An exception prevented scanning of available drives.  This may be a limitation of the runtime on this platform.  The packager will not be able to detect any removable media on this system.", new object[0]);
					array = null;
					this.m_Configuration.AllowRemovableMedia = false;
				}
			}
			if (array != null)
			{
				global::System.ComponentModel.BindingList<global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.SafeDriveInfo> bindingList = new global::System.ComponentModel.BindingList<global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.SafeDriveInfo>();
				foreach (global::System.IO.DriveInfo driveInfo in array)
				{
					try
					{
						if (driveInfo.DriveType == global::System.IO.DriveType.Removable || driveInfo.DriveType == global::System.IO.DriveType.Network)
						{
							global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.SafeDriveInfo item = new global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.SafeDriveInfo(driveInfo);
							bindingList.Add(item);
						}
					}
					catch
					{
					}
				}
				this.cboVolumeSelect.DataSource = bindingList;
				foreach (global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport.SafeDriveInfo safeDriveInfo in bindingList)
				{
					try
					{
						if (safeDriveInfo.DriveInfo.IsReady && this.cboVolumeSelect.SelectedItem == null)
						{
							this.cboVolumeSelect.SelectedItem = safeDriveInfo;
						}
					}
					catch
					{
					}
				}
				if (bindingList.Count == 0)
				{
					this.lblDrive.Visible = false;
					this.cboVolumeSelect.Visible = false;
					this.lblRemovableMediaNotValid.Visible = false;
					this.lblNoRemovableMedia.Location = this.lblDrive.Location;
					this.lblNoRemovableMedia.Visible = true;
					return;
				}
				this.lblNoRemovableMedia.Visible = false;
				this.lblDrive.Visible = true;
				this.cboVolumeSelect.Visible = true;
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00056474 File Offset: 0x00054674
		private void txtEmailAddress_TextChanged(object sender, global::System.EventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0005647C File Offset: 0x0005467C
		private void txtFileNamePath_TextChanged(object sender, global::System.EventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00056484 File Offset: 0x00054684
		private void cboVolumeSelect_SelectedValueChanged(object sender, global::System.EventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0005648C File Offset: 0x0005468C
		private void Option_Click(object sender, global::System.EventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00056494 File Offset: 0x00054694
		private void btnBrowse_Click(object sender, global::System.EventArgs e)
		{
			this.ActionFileBrowse();
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0005649C File Offset: 0x0005469C
		private void mainLayoutPanel_Resize(object sender, global::System.EventArgs e)
		{
			if (base.Visible)
			{
				int width = this.mainLayoutPanel.Width - this.mainLayoutPanel.Margin.Left - this.mainLayoutPanel.Margin.Right;
				if (this.emailOptionsPanel.Visible)
				{
					this.emailOptionsPanel.Width = width;
				}
				if (this.fileOptionsPanel.Visible)
				{
					this.fileOptionsPanel.Width = width;
				}
				if (this.removableMediaOptionsPanel.Visible)
				{
					this.removableMediaOptionsPanel.Width = width;
				}
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00056540 File Offset: 0x00054740
		private void btnRefreshRemovableMedia_Click(object sender, global::System.EventArgs e)
		{
			this.InitializeDriveCombo();
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00056548 File Offset: 0x00054748
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00056570 File Offset: 0x00054770
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.optSendToEmail = new global::System.Windows.Forms.RadioButton();
			this.optSaveToFile = new global::System.Windows.Forms.RadioButton();
			this.lblFileName = new global::System.Windows.Forms.Label();
			this.txtFileNamePath = new global::System.Windows.Forms.TextBox();
			this.btnBrowse = new global::System.Windows.Forms.Button();
			this.lblDestinationEmailAddress = new global::System.Windows.Forms.Label();
			this.txtEmailAddress = new global::System.Windows.Forms.TextBox();
			this.optSaveToRemovableMedia = new global::System.Windows.Forms.RadioButton();
			this.lblDrive = new global::System.Windows.Forms.Label();
			this.cboVolumeSelect = new global::System.Windows.Forms.ComboBox();
			this.mainLayoutPanel = new global::System.Windows.Forms.FlowLayoutPanel();
			this.lblSendToEmail = new global::System.Windows.Forms.Label();
			this.emailOptionsPanel = new global::System.Windows.Forms.Panel();
			this.fromEmailOptionsPanel = new global::System.Windows.Forms.Panel();
			this.lblFromEmailAddressInstructions = new global::System.Windows.Forms.Label();
			this.txtFromEmailAddress = new global::System.Windows.Forms.TextBox();
			this.lblFromEmailAddress = new global::System.Windows.Forms.Label();
			this.lblSaveToFile = new global::System.Windows.Forms.Label();
			this.fileOptionsPanel = new global::System.Windows.Forms.Panel();
			this.lblSaveToRemovableMedia = new global::System.Windows.Forms.Label();
			this.removableMediaOptionsPanel = new global::System.Windows.Forms.Panel();
			this.lblRemovableMediaNotValid = new global::System.Windows.Forms.Label();
			this.lblNoRemovableMedia = new global::System.Windows.Forms.Label();
			this.btnRefreshRemovableMedia = new global::System.Windows.Forms.Button();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.mainLayoutPanel.SuspendLayout();
			this.emailOptionsPanel.SuspendLayout();
			this.fromEmailOptionsPanel.SuspendLayout();
			this.fileOptionsPanel.SuspendLayout();
			this.removableMediaOptionsPanel.SuspendLayout();
			base.SuspendLayout();
			this.optSendToEmail.AutoSize = true;
			this.optSendToEmail.BackColor = global::System.Drawing.Color.Transparent;
			this.optSendToEmail.Location = new global::System.Drawing.Point(3, 16);
			this.optSendToEmail.Name = "optSendToEmail";
			this.optSendToEmail.Size = new global::System.Drawing.Size(95, 17);
			this.optSendToEmail.TabIndex = 0;
			this.optSendToEmail.TabStop = true;
			this.optSendToEmail.Text = "Send via Email";
			this.optSendToEmail.UseVisualStyleBackColor = false;
			this.optSendToEmail.Click += this.Option_Click;
			this.optSaveToFile.AutoSize = true;
			this.optSaveToFile.BackColor = global::System.Drawing.Color.Transparent;
			this.optSaveToFile.Location = new global::System.Drawing.Point(3, 134);
			this.optSaveToFile.Name = "optSaveToFile";
			this.optSaveToFile.Size = new global::System.Drawing.Size(81, 17);
			this.optSaveToFile.TabIndex = 1;
			this.optSaveToFile.TabStop = true;
			this.optSaveToFile.Text = "Save to File";
			this.optSaveToFile.UseVisualStyleBackColor = false;
			this.optSaveToFile.Click += this.Option_Click;
			this.lblFileName.AutoSize = true;
			this.lblFileName.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFileName.Location = new global::System.Drawing.Point(28, 4);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new global::System.Drawing.Size(57, 13);
			this.lblFileName.TabIndex = 2;
			this.lblFileName.Text = "File Name:";
			this.txtFileNamePath.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtFileNamePath.Location = new global::System.Drawing.Point(91, 0);
			this.txtFileNamePath.Name = "txtFileNamePath";
			this.txtFileNamePath.Size = new global::System.Drawing.Size(267, 20);
			this.txtFileNamePath.TabIndex = 3;
			this.toolTip.SetToolTip(this.txtFileNamePath, "The full file name and path to write the session information to");
			this.txtFileNamePath.TextChanged += this.txtFileNamePath_TextChanged;
			this.btnBrowse.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBrowse.Location = new global::System.Drawing.Point(364, 0);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new global::System.Drawing.Size(28, 20);
			this.btnBrowse.TabIndex = 4;
			this.btnBrowse.Text = "...";
			this.toolTip.SetToolTip(this.btnBrowse, "Browse your computer to select where to store the package");
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += this.btnBrowse_Click;
			this.lblDestinationEmailAddress.AutoSize = true;
			this.lblDestinationEmailAddress.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDestinationEmailAddress.Location = new global::System.Drawing.Point(28, 3);
			this.lblDestinationEmailAddress.Name = "lblDestinationEmailAddress";
			this.lblDestinationEmailAddress.Size = new global::System.Drawing.Size(51, 13);
			this.lblDestinationEmailAddress.TabIndex = 5;
			this.lblDestinationEmailAddress.Text = "Send To:";
			this.txtEmailAddress.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtEmailAddress.Location = new global::System.Drawing.Point(91, 0);
			this.txtEmailAddress.Name = "txtEmailAddress";
			this.txtEmailAddress.Size = new global::System.Drawing.Size(267, 20);
			this.txtEmailAddress.TabIndex = 6;
			this.toolTip.SetToolTip(this.txtEmailAddress, "Internet email address to send the session information to");
			this.txtEmailAddress.TextChanged += this.txtEmailAddress_TextChanged;
			this.optSaveToRemovableMedia.AutoSize = true;
			this.optSaveToRemovableMedia.BackColor = global::System.Drawing.Color.Transparent;
			this.optSaveToRemovableMedia.Location = new global::System.Drawing.Point(3, 213);
			this.optSaveToRemovableMedia.Name = "optSaveToRemovableMedia";
			this.optSaveToRemovableMedia.Size = new global::System.Drawing.Size(151, 17);
			this.optSaveToRemovableMedia.TabIndex = 7;
			this.optSaveToRemovableMedia.TabStop = true;
			this.optSaveToRemovableMedia.Text = "Save to Removable Media";
			this.optSaveToRemovableMedia.UseVisualStyleBackColor = false;
			this.optSaveToRemovableMedia.Click += this.Option_Click;
			this.lblDrive.AutoSize = true;
			this.lblDrive.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDrive.Location = new global::System.Drawing.Point(28, 6);
			this.lblDrive.Name = "lblDrive";
			this.lblDrive.Size = new global::System.Drawing.Size(39, 13);
			this.lblDrive.TabIndex = 8;
			this.lblDrive.Text = "Media:";
			this.cboVolumeSelect.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.cboVolumeSelect.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboVolumeSelect.FormattingEnabled = true;
			this.cboVolumeSelect.Location = new global::System.Drawing.Point(91, 3);
			this.cboVolumeSelect.Name = "cboVolumeSelect";
			this.cboVolumeSelect.Size = new global::System.Drawing.Size(267, 21);
			this.cboVolumeSelect.TabIndex = 9;
			this.toolTip.SetToolTip(this.cboVolumeSelect, "Select the removable media to save the package to.");
			this.cboVolumeSelect.SelectedValueChanged += this.cboVolumeSelect_SelectedValueChanged;
			this.mainLayoutPanel.Controls.Add(this.lblSendToEmail);
			this.mainLayoutPanel.Controls.Add(this.optSendToEmail);
			this.mainLayoutPanel.Controls.Add(this.emailOptionsPanel);
			this.mainLayoutPanel.Controls.Add(this.lblSaveToFile);
			this.mainLayoutPanel.Controls.Add(this.optSaveToFile);
			this.mainLayoutPanel.Controls.Add(this.fileOptionsPanel);
			this.mainLayoutPanel.Controls.Add(this.lblSaveToRemovableMedia);
			this.mainLayoutPanel.Controls.Add(this.optSaveToRemovableMedia);
			this.mainLayoutPanel.Controls.Add(this.removableMediaOptionsPanel);
			this.mainLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.mainLayoutPanel.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.mainLayoutPanel.Location = new global::System.Drawing.Point(0, 0);
			this.mainLayoutPanel.Name = "mainLayoutPanel";
			this.mainLayoutPanel.Size = new global::System.Drawing.Size(451, 262);
			this.mainLayoutPanel.TabIndex = 10;
			this.mainLayoutPanel.Resize += this.mainLayoutPanel_Resize;
			this.lblSendToEmail.AutoSize = true;
			this.lblSendToEmail.Location = new global::System.Drawing.Point(3, 0);
			this.lblSendToEmail.Name = "lblSendToEmail";
			this.lblSendToEmail.Size = new global::System.Drawing.Size(77, 13);
			this.lblSendToEmail.TabIndex = 12;
			this.lblSendToEmail.Text = "Send via Email";
			this.emailOptionsPanel.Controls.Add(this.fromEmailOptionsPanel);
			this.emailOptionsPanel.Controls.Add(this.txtEmailAddress);
			this.emailOptionsPanel.Controls.Add(this.lblDestinationEmailAddress);
			this.emailOptionsPanel.Location = new global::System.Drawing.Point(3, 39);
			this.emailOptionsPanel.Name = "emailOptionsPanel";
			this.emailOptionsPanel.Size = new global::System.Drawing.Size(398, 76);
			this.emailOptionsPanel.TabIndex = 11;
			this.fromEmailOptionsPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.fromEmailOptionsPanel.Controls.Add(this.lblFromEmailAddressInstructions);
			this.fromEmailOptionsPanel.Controls.Add(this.txtFromEmailAddress);
			this.fromEmailOptionsPanel.Controls.Add(this.lblFromEmailAddress);
			this.fromEmailOptionsPanel.Location = new global::System.Drawing.Point(0, 23);
			this.fromEmailOptionsPanel.Name = "fromEmailOptionsPanel";
			this.fromEmailOptionsPanel.Size = new global::System.Drawing.Size(398, 53);
			this.fromEmailOptionsPanel.TabIndex = 10;
			this.lblFromEmailAddressInstructions.AutoSize = true;
			this.lblFromEmailAddressInstructions.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFromEmailAddressInstructions.Location = new global::System.Drawing.Point(15, 7);
			this.lblFromEmailAddressInstructions.Name = "lblFromEmailAddressInstructions";
			this.lblFromEmailAddressInstructions.Size = new global::System.Drawing.Size(308, 13);
			this.lblFromEmailAddressInstructions.TabIndex = 9;
			this.lblFromEmailAddressInstructions.Text = "Address to direct responses to: (Optional.  Blank for anonymous)";
			this.txtFromEmailAddress.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtFromEmailAddress.Location = new global::System.Drawing.Point(91, 26);
			this.txtFromEmailAddress.Name = "txtFromEmailAddress";
			this.txtFromEmailAddress.Size = new global::System.Drawing.Size(267, 20);
			this.txtFromEmailAddress.TabIndex = 8;
			this.toolTip.SetToolTip(this.txtFromEmailAddress, "Optional.  Internet email address to use as the reply-to address.");
			this.lblFromEmailAddress.AutoSize = true;
			this.lblFromEmailAddress.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFromEmailAddress.Location = new global::System.Drawing.Point(28, 29);
			this.lblFromEmailAddress.Name = "lblFromEmailAddress";
			this.lblFromEmailAddress.Size = new global::System.Drawing.Size(53, 13);
			this.lblFromEmailAddress.TabIndex = 7;
			this.lblFromEmailAddress.Text = "Reply To:";
			this.lblSaveToFile.AutoSize = true;
			this.lblSaveToFile.Location = new global::System.Drawing.Point(3, 118);
			this.lblSaveToFile.Name = "lblSaveToFile";
			this.lblSaveToFile.Size = new global::System.Drawing.Size(63, 13);
			this.lblSaveToFile.TabIndex = 13;
			this.lblSaveToFile.Text = "Save to File";
			this.fileOptionsPanel.Controls.Add(this.txtFileNamePath);
			this.fileOptionsPanel.Controls.Add(this.lblFileName);
			this.fileOptionsPanel.Controls.Add(this.btnBrowse);
			this.fileOptionsPanel.Location = new global::System.Drawing.Point(3, 157);
			this.fileOptionsPanel.Name = "fileOptionsPanel";
			this.fileOptionsPanel.Size = new global::System.Drawing.Size(395, 37);
			this.fileOptionsPanel.TabIndex = 11;
			this.lblSaveToRemovableMedia.AutoSize = true;
			this.lblSaveToRemovableMedia.Location = new global::System.Drawing.Point(3, 197);
			this.lblSaveToRemovableMedia.Name = "lblSaveToRemovableMedia";
			this.lblSaveToRemovableMedia.Size = new global::System.Drawing.Size(137, 13);
			this.lblSaveToRemovableMedia.TabIndex = 14;
			this.lblSaveToRemovableMedia.Text = "Save To Removable Media";
			this.removableMediaOptionsPanel.Controls.Add(this.lblRemovableMediaNotValid);
			this.removableMediaOptionsPanel.Controls.Add(this.lblNoRemovableMedia);
			this.removableMediaOptionsPanel.Controls.Add(this.btnRefreshRemovableMedia);
			this.removableMediaOptionsPanel.Controls.Add(this.cboVolumeSelect);
			this.removableMediaOptionsPanel.Controls.Add(this.lblDrive);
			this.removableMediaOptionsPanel.Location = new global::System.Drawing.Point(407, 3);
			this.removableMediaOptionsPanel.Name = "removableMediaOptionsPanel";
			this.removableMediaOptionsPanel.Size = new global::System.Drawing.Size(395, 60);
			this.removableMediaOptionsPanel.TabIndex = 11;
			this.lblRemovableMediaNotValid.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lblRemovableMediaNotValid.Location = new global::System.Drawing.Point(88, 30);
			this.lblRemovableMediaNotValid.Name = "lblRemovableMediaNotValid";
			this.lblRemovableMediaNotValid.Size = new global::System.Drawing.Size(286, 29);
			this.lblRemovableMediaNotValid.TabIndex = 11;
			this.lblRemovableMediaNotValid.Text = "Unable to write to the selected media.  Make sure there is media in the drive and it isn't write protected.";
			this.lblRemovableMediaNotValid.Visible = false;
			this.lblNoRemovableMedia.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.lblNoRemovableMedia.Location = new global::System.Drawing.Point(31, 59);
			this.lblNoRemovableMedia.Name = "lblNoRemovableMedia";
			this.lblNoRemovableMedia.Size = new global::System.Drawing.Size(361, 29);
			this.lblNoRemovableMedia.TabIndex = 10;
			this.lblNoRemovableMedia.Text = "No removable media were detected.  Insert a USB memory strick or other removable media to use this option.";
			this.btnRefreshRemovableMedia.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRefreshRemovableMedia.Image = global::Gibraltar.Monitor.Windows.UIResources.RepeatHS;
			this.btnRefreshRemovableMedia.Location = new global::System.Drawing.Point(364, 3);
			this.btnRefreshRemovableMedia.Name = "btnRefreshRemovableMedia";
			this.btnRefreshRemovableMedia.Size = new global::System.Drawing.Size(28, 21);
			this.btnRefreshRemovableMedia.TabIndex = 11;
			this.toolTip.SetToolTip(this.btnRefreshRemovableMedia, "Refresh the list of removable media");
			this.btnRefreshRemovableMedia.UseVisualStyleBackColor = true;
			this.btnRefreshRemovableMedia.Click += this.btnRefreshRemovableMedia_Click;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.mainLayoutPanel);
			base.Name = "UIPackagerTransport";
			base.Size = new global::System.Drawing.Size(451, 262);
			this.mainLayoutPanel.ResumeLayout(false);
			this.mainLayoutPanel.PerformLayout();
			this.emailOptionsPanel.ResumeLayout(false);
			this.emailOptionsPanel.PerformLayout();
			this.fromEmailOptionsPanel.ResumeLayout(false);
			this.fromEmailOptionsPanel.PerformLayout();
			this.fileOptionsPanel.ResumeLayout(false);
			this.fileOptionsPanel.PerformLayout();
			this.removableMediaOptionsPanel.ResumeLayout(false);
			this.removableMediaOptionsPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0005749C File Offset: 0x0005569C
		string global::Gibraltar.Windows.UI.IUIWizardPage.get_Name()
		{
			return base.Name;
		}

		// Token: 0x040008CB RID: 2251
		private const string DefaultTitle = "Where do you want to send this information?";

		// Token: 0x040008CC RID: 2252
		private const string DefaultInstructions = "Pick where you want to send this information from the list below then click Next to package and send your information.";

		// Token: 0x040008CD RID: 2253
		private const string SingleOptionInstructions = "Complete the following then click Next to package and send your information.";

		// Token: 0x040008CE RID: 2254
		private readonly global::Gibraltar.Monitor.PackagerConfiguration m_Configuration;

		// Token: 0x040008CF RID: 2255
		private global::Gibraltar.Monitor.Windows.Internal.PackagerRequest m_Request;

		// Token: 0x040008D0 RID: 2256
		private bool m_NextEnabled;

		// Token: 0x040008D1 RID: 2257
		private string m_Title;

		// Token: 0x040008D2 RID: 2258
		private string m_Instructions;

		// Token: 0x040008D4 RID: 2260
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040008D5 RID: 2261
		private global::System.Windows.Forms.RadioButton optSendToEmail;

		// Token: 0x040008D6 RID: 2262
		private global::System.Windows.Forms.RadioButton optSaveToFile;

		// Token: 0x040008D7 RID: 2263
		private global::System.Windows.Forms.Label lblFileName;

		// Token: 0x040008D8 RID: 2264
		private global::System.Windows.Forms.TextBox txtFileNamePath;

		// Token: 0x040008D9 RID: 2265
		private global::System.Windows.Forms.Button btnBrowse;

		// Token: 0x040008DA RID: 2266
		private global::System.Windows.Forms.Label lblDestinationEmailAddress;

		// Token: 0x040008DB RID: 2267
		private global::System.Windows.Forms.TextBox txtEmailAddress;

		// Token: 0x040008DC RID: 2268
		private global::System.Windows.Forms.RadioButton optSaveToRemovableMedia;

		// Token: 0x040008DD RID: 2269
		private global::System.Windows.Forms.Label lblDrive;

		// Token: 0x040008DE RID: 2270
		private global::System.Windows.Forms.ComboBox cboVolumeSelect;

		// Token: 0x040008DF RID: 2271
		private global::System.Windows.Forms.FlowLayoutPanel mainLayoutPanel;

		// Token: 0x040008E0 RID: 2272
		private global::System.Windows.Forms.Panel emailOptionsPanel;

		// Token: 0x040008E1 RID: 2273
		private global::System.Windows.Forms.Panel fileOptionsPanel;

		// Token: 0x040008E2 RID: 2274
		private global::System.Windows.Forms.Panel removableMediaOptionsPanel;

		// Token: 0x040008E3 RID: 2275
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Forms.Label lblFromEmailAddressInstructions;

		// Token: 0x040008E5 RID: 2277
		private global::System.Windows.Forms.TextBox txtFromEmailAddress;

		// Token: 0x040008E6 RID: 2278
		private global::System.Windows.Forms.Label lblFromEmailAddress;

		// Token: 0x040008E7 RID: 2279
		private global::System.Windows.Forms.Panel fromEmailOptionsPanel;

		// Token: 0x040008E8 RID: 2280
		private global::System.Windows.Forms.Label lblNoRemovableMedia;

		// Token: 0x040008E9 RID: 2281
		private global::System.Windows.Forms.Button btnRefreshRemovableMedia;

		// Token: 0x040008EA RID: 2282
		private global::System.Windows.Forms.Label lblRemovableMediaNotValid;

		// Token: 0x040008EB RID: 2283
		private global::System.Windows.Forms.Label lblSendToEmail;

		// Token: 0x040008EC RID: 2284
		private global::System.Windows.Forms.Label lblSaveToFile;

		// Token: 0x040008ED RID: 2285
		private global::System.Windows.Forms.Label lblSaveToRemovableMedia;

		// Token: 0x020004B6 RID: 1206
		private sealed class SafeDriveInfo
		{
			// Token: 0x060033D9 RID: 13273 RVA: 0x000BB0B4 File Offset: 0x000B92B4
			public SafeDriveInfo(global::System.IO.DriveInfo driveInfo)
			{
				this.DriveInfo = driveInfo;
				if (this.DriveInfo.IsReady)
				{
					string arg;
					try
					{
						arg = this.DriveInfo.VolumeLabel;
					}
					catch (global::System.Exception exception)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Gibraltar.Agent.Packager", "Unable to read VolumeLabel", "An attempt to read the VolumeLabel of a drive threw an exception.", new object[0]);
						arg = string.Empty;
					}
					this.Caption = string.Format("{0}: {1} ({2:N0} free)", this.DriveInfo.Name, arg, this.DriveInfo.AvailableFreeSpace);
					return;
				}
				this.Caption = string.Format("{0}: {1}", this.DriveInfo.Name, this.DriveInfo.DriveType);
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x060033DA RID: 13274 RVA: 0x000BB180 File Offset: 0x000B9380
			// (set) Token: 0x060033DB RID: 13275 RVA: 0x000BB188 File Offset: 0x000B9388
			public global::System.IO.DriveInfo DriveInfo { get; private set; }

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x060033DC RID: 13276 RVA: 0x000BB194 File Offset: 0x000B9394
			// (set) Token: 0x060033DD RID: 13277 RVA: 0x000BB19C File Offset: 0x000B939C
			public string Caption { get; private set; }
		}
	}
}
