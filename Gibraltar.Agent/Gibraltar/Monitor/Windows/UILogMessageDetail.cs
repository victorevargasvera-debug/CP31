using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001DC RID: 476
	internal class UILogMessageDetail : global::System.Windows.Forms.UserControl
	{
		// Token: 0x14000073 RID: 115
		// (add) Token: 0x060016BE RID: 5822 RVA: 0x000493F8 File Offset: 0x000475F8
		// (remove) Token: 0x060016BF RID: 5823 RVA: 0x00049434 File Offset: 0x00047634
		public event global::System.EventHandler TitleChanged;

		// Token: 0x060016C0 RID: 5824 RVA: 0x00049470 File Offset: 0x00047670
		public UILogMessageDetail()
		{
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00049484 File Offset: 0x00047684
		[global::System.ComponentModel.Browsable(false)]
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x0004948C File Offset: 0x0004768C
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x00049494 File Offset: 0x00047694
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
				this.SetDisplayDetails(value);
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000494A0 File Offset: 0x000476A0
		protected virtual string CalculateTitle()
		{
			string result;
			if (this.m_LogMessage == null || string.IsNullOrEmpty(this.m_LogMessage.Details))
			{
				result = "No Details Available";
			}
			else
			{
				result = "Details";
			}
			return result;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000494E4 File Offset: 0x000476E4
		protected virtual void OnTitleChanged()
		{
			global::System.EventHandler titleChanged = this.TitleChanged;
			if (titleChanged != null)
			{
				titleChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00049510 File Offset: 0x00047710
		protected override void OnVisibleChanged(global::System.EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (this.m_DocumentStale)
			{
				this.RenderDocument();
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0004952C File Offset: 0x0004772C
		private void ActionCopy()
		{
			if (this.m_LogMessage != null)
			{
				global::System.Windows.Forms.Clipboard.Clear();
				global::System.Windows.Forms.Clipboard.SetText(this.m_LogMessage.Details);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00049550 File Offset: 0x00047750
		private void ActionSaveAs()
		{
			if (this.m_LogMessage != null)
			{
				using (global::System.Windows.Forms.SaveFileDialog saveFileDialog = new global::System.Windows.Forms.SaveFileDialog())
				{
					saveFileDialog.Filter = "Extensible Markup Language (XML)|*.xml|Any File|*.*";
					saveFileDialog.Title = "Save Log Message Details";
					saveFileDialog.FileName = "Detail.xml";
					if (saveFileDialog.ShowDialog() == global::System.Windows.Forms.DialogResult.OK)
					{
						global::System.IO.File.WriteAllText(saveFileDialog.FileName, this.m_LogMessage.Details);
					}
				}
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000495D4 File Offset: 0x000477D4
		private void SetDisplayTitle()
		{
			string text = this.CalculateTitle();
			if (text != this.m_Title)
			{
				this.m_Title = text;
				this.OnTitleChanged();
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0004960C File Offset: 0x0004780C
		private void SetDisplayDetails(global::Loupe.Extensibility.Data.ILogMessage logMessage)
		{
			if (this.m_LogMessage == logMessage)
			{
				return;
			}
			this.m_LogMessage = logMessage;
			string value = null;
			if (this.m_LogMessage != null)
			{
				value = this.m_LogMessage.Details;
			}
			if (!string.IsNullOrEmpty(value))
			{
				if (base.Visible)
				{
					this.RenderDocument();
				}
				else
				{
					this.m_DocumentStale = true;
				}
			}
			else
			{
				this.lblNoDetails.Visible = true;
				this.detailsView.Visible = false;
			}
			this.SetDisplayTitle();
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00049698 File Offset: 0x00047898
		private void RenderDocument()
		{
			this.m_DocumentStale = false;
			string text = null;
			if (this.m_LogMessage != null)
			{
				text = this.m_LogMessage.Details;
			}
			if (!string.IsNullOrEmpty(text))
			{
				try
				{
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
					{
						using (global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(memoryStream, null))
						{
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.LoadXml(text);
							xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
							xmlDocument.WriteContentTo(xmlTextWriter);
							xmlTextWriter.Flush();
							memoryStream.Flush();
							memoryStream.Position = 0L;
							string text2;
							using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(memoryStream))
							{
								text2 = streamReader.ReadToEnd();
							}
							text = text2;
						}
					}
				}
				catch (global::System.Exception ex)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Session Viewer.Log Message Detail", "Unable to pretty print XML, probably because source isn't a valid XML document.", "The Xml format routine threw an exception when attempting to reformat the xml details:\r\n{0}", new object[]
					{
						ex.Message
					});
				}
				this.detailsView.Text = text;
				this.lblNoDetails.Visible = false;
				this.detailsView.Visible = true;
				return;
			}
			this.lblNoDetails.Visible = true;
			this.detailsView.Visible = false;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000497F8 File Offset: 0x000479F8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00049820 File Offset: 0x00047A20
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Monitor.Windows.UILogMessageDetail));
			this.lblNoDetails = new global::System.Windows.Forms.Label();
			this.imagesCommandManager = new global::System.Windows.Forms.ImageList(this.components);
			this.detailsView = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.lblNoDetails.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNoDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblNoDetails.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNoDetails.Location = new global::System.Drawing.Point(0, 0);
			this.lblNoDetails.Name = "lblNoDetails";
			this.lblNoDetails.Size = new global::System.Drawing.Size(372, 210);
			this.lblNoDetails.TabIndex = 2;
			this.lblNoDetails.Text = "No Details Available";
			this.lblNoDetails.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.imagesCommandManager.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imagesCommandManager.ImageStream");
			this.imagesCommandManager.TransparentColor = global::System.Drawing.Color.Magenta;
			this.imagesCommandManager.Images.SetKeyName(0, "copy");
			this.imagesCommandManager.Images.SetKeyName(1, "save");
			this.detailsView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.detailsView.Location = new global::System.Drawing.Point(0, 0);
			this.detailsView.Multiline = true;
			this.detailsView.Name = "detailsView";
			this.detailsView.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.detailsView.Size = new global::System.Drawing.Size(372, 210);
			this.detailsView.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.detailsView);
			base.Controls.Add(this.lblNoDetails);
			base.Name = "UILogMessageDetail";
			base.Size = new global::System.Drawing.Size(372, 210);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007AD RID: 1965
		private global::Loupe.Extensibility.Data.ILogMessage m_LogMessage;

		// Token: 0x040007AE RID: 1966
		private string m_Title;

		// Token: 0x040007AF RID: 1967
		private bool m_DocumentStale;

		// Token: 0x040007B1 RID: 1969
		private const string FileDialogFilter = "Extensible Markup Language (XML)|*.xml|Any File|*.*";

		// Token: 0x040007B2 RID: 1970
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007B3 RID: 1971
		private global::System.Windows.Forms.Label lblNoDetails;

		// Token: 0x040007B4 RID: 1972
		private global::System.Windows.Forms.ImageList imagesCommandManager;

		// Token: 0x040007B5 RID: 1973
		private global::System.Windows.Forms.TextBox detailsView;
	}
}
