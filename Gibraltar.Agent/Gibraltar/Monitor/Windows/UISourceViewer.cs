using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;
using Manoli.Utils.CSharpFormat;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001DD RID: 477
	internal class UISourceViewer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x14000074 RID: 116
		// (add) Token: 0x060016CE RID: 5838 RVA: 0x00049A48 File Offset: 0x00047C48
		// (remove) Token: 0x060016CF RID: 5839 RVA: 0x00049A84 File Offset: 0x00047C84
		public event global::System.EventHandler TitleChanged;

		// Token: 0x060016D0 RID: 5840 RVA: 0x00049AC0 File Offset: 0x00047CC0
		public UISourceViewer()
		{
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00049AE4 File Offset: 0x00047CE4
		[global::System.ComponentModel.Browsable(false)]
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00049AEC File Offset: 0x00047CEC
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00049AF4 File Offset: 0x00047CF4
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
				this.SetDisplaySourceCode(value);
			}
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00049B00 File Offset: 0x00047D00
		protected virtual string CalculateTitle(string sourceCodeFileNamePath, int lineNumber)
		{
			string result;
			if (string.IsNullOrEmpty(sourceCodeFileNamePath))
			{
				result = "Source Not Available";
			}
			else if (lineNumber > 0)
			{
				result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} ({1:N0})", new object[]
				{
					global::System.IO.Path.GetFileName(sourceCodeFileNamePath),
					lineNumber
				});
			}
			else
			{
				result = global::System.IO.Path.GetFileName(sourceCodeFileNamePath);
			}
			return result;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00049B64 File Offset: 0x00047D64
		protected virtual void OnTitleChanged()
		{
			global::System.EventHandler titleChanged = this.TitleChanged;
			if (titleChanged != null)
			{
				titleChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00049B90 File Offset: 0x00047D90
		protected override void OnVisibleChanged(global::System.EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (this.m_SourceStale && base.Visible)
			{
				this.RenderSourceCode();
			}
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00049BB8 File Offset: 0x00047DB8
		private static string FormatSourceCode(string fileNamePath)
		{
			string result;
			using (global::System.IO.StreamReader streamReader = global::System.IO.File.OpenText(fileNamePath))
			{
				string text = streamReader.ReadToEnd();
				string extension = global::System.IO.Path.GetExtension(fileNamePath);
				uint num = global::Loupe.Core.<PrivateImplementationDetails>.ComputeStringHash(extension);
				global::Manoli.Utils.CSharpFormat.SourceFormat sourceFormat;
				if (num <= 1426315967U)
				{
					if (num <= 1172930469U)
					{
						if (num != 754654932U)
						{
							if (num != 1172930469U)
							{
								goto IL_18D;
							}
							if (!(extension == ".vb"))
							{
								goto IL_18D;
							}
							sourceFormat = new global::Manoli.Utils.CSharpFormat.VisualBasicFormat();
							goto IL_194;
						}
						else if (!(extension == ".html"))
						{
							goto IL_18D;
						}
					}
					else if (num != 1293625206U)
					{
						if (num != 1426315967U)
						{
							goto IL_18D;
						}
						if (!(extension == ".cs"))
						{
							goto IL_18D;
						}
						sourceFormat = new global::Manoli.Utils.CSharpFormat.CSharpFormat();
						goto IL_194;
					}
					else
					{
						if (!(extension == ".js"))
						{
							goto IL_18D;
						}
						sourceFormat = new global::Manoli.Utils.CSharpFormat.JavaScriptFormat();
						goto IL_194;
					}
				}
				else if (num <= 2641099312U)
				{
					if (num != 1613467945U)
					{
						if (num != 2641099312U)
						{
							goto IL_18D;
						}
						if (!(extension == ".htm"))
						{
							goto IL_18D;
						}
					}
					else if (!(extension == ".aspx"))
					{
						goto IL_18D;
					}
				}
				else if (num != 3534858618U)
				{
					if (num != 3600314715U)
					{
						goto IL_18D;
					}
					if (!(extension == ".sql"))
					{
						goto IL_18D;
					}
					sourceFormat = new global::Manoli.Utils.CSharpFormat.TsqlFormat();
					goto IL_194;
				}
				else if (!(extension == ".xml"))
				{
					goto IL_18D;
				}
				sourceFormat = new global::Manoli.Utils.CSharpFormat.HtmlFormat();
				goto IL_194;
				IL_18D:
				sourceFormat = new global::Manoli.Utils.CSharpFormat.HtmlFormat();
				IL_194:
				try
				{
					sourceFormat.LineNumbers = true;
					sourceFormat.Alternate = true;
					sourceFormat.EmbedStyleSheet = true;
					result = sourceFormat.FormatCode(text);
				}
				catch
				{
					result = text;
				}
			}
			return result;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00049DD0 File Offset: 0x00047FD0
		private void SetDisplayTitle(string sourceCodeFileNamePath, int lineNumber)
		{
			string text = this.CalculateTitle(sourceCodeFileNamePath, lineNumber);
			if (text != this.m_Title)
			{
				this.m_Title = text;
				this.OnTitleChanged();
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00049E08 File Offset: 0x00048008
		private void SetDisplaySourceCode(global::Loupe.Extensibility.Data.ILogMessage logMessage)
		{
			if (this.m_LogMessage == logMessage)
			{
				return;
			}
			this.m_LogMessage = logMessage;
			string text = null;
			int lineNumber = 0;
			if (this.m_LogMessage != null && this.m_LogMessage.HasSourceLocation)
			{
				text = this.m_LogMessage.FileName;
				lineNumber = this.m_LogMessage.LineNumber;
			}
			if (!string.IsNullOrEmpty(text))
			{
				if (base.Visible)
				{
					this.RenderSourceCode();
				}
				else
				{
					this.m_SourceStale = true;
				}
			}
			else
			{
				this.m_CurrentSourceCodeFile = null;
				this.m_CurrentLineNumber = 0;
				this.lblNoSource.Visible = true;
				this.sourcePreview.Visible = false;
			}
			this.SetDisplayTitle(text, lineNumber);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00049EC0 File Offset: 0x000480C0
		private void RenderSourceCode()
		{
			this.m_SourceStale = false;
			string text = null;
			int num = 0;
			if (this.m_LogMessage != null && this.m_LogMessage.HasSourceLocation)
			{
				text = this.m_LogMessage.FileName;
				num = this.m_LogMessage.LineNumber;
			}
			if (!string.IsNullOrEmpty(text))
			{
				if (!text.Equals(this.m_CurrentSourceCodeFile))
				{
					string text2;
					if (!this.m_FormattedSource.TryGetValue(text, out text2) && global::System.IO.File.Exists(text))
					{
						text2 = global::Gibraltar.Monitor.Windows.UISourceViewer.FormatSourceCode(text);
						this.m_FormattedSource.Add(text, text2);
					}
					if (!string.IsNullOrEmpty(text2))
					{
						this.sourcePreview.DocumentText = text2;
						this.lblNoSource.Visible = false;
						this.sourcePreview.Visible = true;
					}
					else
					{
						this.lblNoSource.Visible = true;
						this.sourcePreview.Visible = false;
					}
					this.m_CurrentSourceCodeFile = text;
					this.m_CurrentLineNumber = 0;
				}
				if (this.sourcePreview.Visible && num > 0)
				{
					if (this.m_CurrentLineNumber != 0)
					{
						this.SetLineHighlight(this.m_CurrentLineNumber, false);
					}
					this.m_CurrentLineNumber = num;
					this.SetLineHighlight(this.m_CurrentLineNumber, true);
				}
			}
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00049FFC File Offset: 0x000481FC
		private void SetLineHighlight(int lineNumber, bool highlight)
		{
			string id = global::Gibraltar.Monitor.Windows.UISourceViewer.LineNumberToElementId(lineNumber);
			try
			{
				if (this.sourcePreview.Document != null)
				{
					global::System.Windows.Forms.HtmlElement elementById = this.sourcePreview.Document.GetElementById(id);
					if (elementById != null)
					{
						string text = elementById.GetAttribute("className");
						if (!string.IsNullOrEmpty(text) && text.StartsWith("alt"))
						{
							text = (highlight ? "alt-highlight" : "alt");
						}
						else
						{
							text = (highlight ? "highlight" : string.Empty);
						}
						elementById.SetAttribute("className", text);
						if (highlight)
						{
							int height = this.sourcePreview.ClientRectangle.Height;
							int height2 = elementById.OffsetRectangle.Height;
							int num = height - height2;
							global::System.Windows.Forms.HtmlElement htmlElement = null;
							if (num > 0 && height2 > 0)
							{
								int num2 = 2 * num / (3 * height2);
								string id2 = global::Gibraltar.Monitor.Windows.UISourceViewer.LineNumberToElementId((lineNumber > num2) ? (lineNumber - num2) : 1);
								htmlElement = this.sourcePreview.Document.GetElementById(id2);
							}
							if (htmlElement != null)
							{
								htmlElement.ScrollIntoView(true);
							}
							else
							{
								elementById.ScrollIntoView(false);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0004A16C File Offset: 0x0004836C
		private static string LineNumberToElementId(int lineNumber)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "line{0}", new object[]
			{
				lineNumber
			});
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0004A18C File Offset: 0x0004838C
		private void sourcePreview_DocumentCompleted(object sender, global::System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.m_CurrentLineNumber > 0)
			{
				this.SetLineHighlight(this.m_CurrentLineNumber, true);
			}
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0004A1A8 File Offset: 0x000483A8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0004A1D0 File Offset: 0x000483D0
		private void InitializeComponent()
		{
			this.sourcePreview = new global::System.Windows.Forms.WebBrowser();
			this.lblNoSource = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.sourcePreview.AllowWebBrowserDrop = false;
			this.sourcePreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.sourcePreview.IsWebBrowserContextMenuEnabled = false;
			this.sourcePreview.Location = new global::System.Drawing.Point(0, 0);
			this.sourcePreview.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.sourcePreview.Name = "sourcePreview";
			this.sourcePreview.ScriptErrorsSuppressed = true;
			this.sourcePreview.Size = new global::System.Drawing.Size(560, 342);
			this.sourcePreview.TabIndex = 0;
			this.sourcePreview.WebBrowserShortcutsEnabled = false;
			this.sourcePreview.DocumentCompleted += this.sourcePreview_DocumentCompleted;
			this.lblNoSource.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNoSource.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblNoSource.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNoSource.Location = new global::System.Drawing.Point(0, 0);
			this.lblNoSource.Name = "lblNoSource";
			this.lblNoSource.Size = new global::System.Drawing.Size(560, 342);
			this.lblNoSource.TabIndex = 1;
			this.lblNoSource.Text = "No Source Code Available";
			this.lblNoSource.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.lblNoSource);
			base.Controls.Add(this.sourcePreview);
			base.Name = "UISourceViewer";
			base.Size = new global::System.Drawing.Size(560, 342);
			base.ResumeLayout(false);
		}

		// Token: 0x040007B6 RID: 1974
		private readonly global::System.Collections.Generic.Dictionary<string, string> m_FormattedSource = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x040007B7 RID: 1975
		private string m_CurrentSourceCodeFile;

		// Token: 0x040007B8 RID: 1976
		private int m_CurrentLineNumber;

		// Token: 0x040007B9 RID: 1977
		private global::Loupe.Extensibility.Data.ILogMessage m_LogMessage;

		// Token: 0x040007BA RID: 1978
		private string m_Title;

		// Token: 0x040007BB RID: 1979
		private bool m_SourceStale;

		// Token: 0x040007BD RID: 1981
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007BE RID: 1982
		private global::System.Windows.Forms.WebBrowser sourcePreview;

		// Token: 0x040007BF RID: 1983
		private global::System.Windows.Forms.Label lblNoSource;
	}
}
