using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001EB RID: 491
	internal class UIException : global::System.Windows.Forms.UserControl
	{
		// Token: 0x1400007B RID: 123
		// (add) Token: 0x0600180B RID: 6155 RVA: 0x00051774 File Offset: 0x0004F974
		// (remove) Token: 0x0600180C RID: 6156 RVA: 0x000517B0 File Offset: 0x0004F9B0
		public event global::System.EventHandler CopyAll;

		// Token: 0x0600180D RID: 6157 RVA: 0x000517EC File Offset: 0x0004F9EC
		public UIException()
		{
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
			this.m_RectangleWidth = this.panelLeft.Width;
			this.m_TypeMessageMarginWidth = this.txtTypeMessage.Margin.Left + this.txtTypeMessage.Margin.Right + this.m_RectangleWidth;
			this.m_StackTraceMarginWidth = this.lblStackTrace.Margin.Left + this.lblStackTrace.Margin.Right + this.m_RectangleWidth;
			base.SuspendLayout();
			this.txtTypeMessage.Text = string.Empty;
			this.lblStackTrace.Text = string.Empty;
			this.lblStackTrace.Links.Clear();
			base.ResumeLayout(true);
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x000518C8 File Offset: 0x0004FAC8
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x000518D0 File Offset: 0x0004FAD0
		[global::System.ComponentModel.Browsable(false)]
		public int ExceptionIndex
		{
			get
			{
				return this.m_ExceptionIndex;
			}
			set
			{
				if (value != this.m_ExceptionIndex)
				{
					this.m_ExceptionIndex = value;
					this.lblExceptionIndex.Text = value.ToString();
					this.lblExceptionIndex.Visible = (value != 0);
				}
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x00051908 File Offset: 0x0004FB08
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x00051910 File Offset: 0x0004FB10
		[global::System.ComponentModel.Browsable(false)]
		public global::Loupe.Extensibility.Data.IExceptionInfo DisplayException
		{
			get
			{
				return this.m_DisplayException;
			}
			set
			{
				if (value != this.m_DisplayException)
				{
					if (this.m_DisplayException != null)
					{
						this.lblStackTrace.Links.Clear();
					}
					this.m_DisplayException = value;
					base.SuspendLayout();
					if (value == null)
					{
						this.txtTypeMessage.Text = string.Empty;
						this.lblStackTrace.Text = string.Empty;
						this.ExceptionIndex = 0;
					}
					else
					{
						string text = value.Message ?? string.Empty;
						text = string.Join(global::Gibraltar.Monitor.Windows.Internal.UIException.LineBreak, text.Trim().Split(global::Gibraltar.Monitor.Windows.Internal.UIException.LineBreakTokens, global::System.StringSplitOptions.None));
						string text2 = string.Format(string.IsNullOrEmpty(value.Source) ? "{1}\r\n{2}" : "{0} : {1}\r\n{2}", value.Source, value.TypeName, text.Trim());
						string text3 = (this.m_DisplayException.StackTrace ?? string.Empty).TrimEnd(new char[0]);
						this.txtTypeMessage.Text = text2;
						this.lblStackTrace.Text = text3;
						this.ApplyStackTraceLinks(this.lblStackTrace.Links, text3);
					}
					base.ResumeLayout(true);
				}
				if (value != null)
				{
					foreach (object obj in this.lblStackTrace.Links)
					{
						global::System.Windows.Forms.LinkLabel.Link link = (global::System.Windows.Forms.LinkLabel.Link)obj;
						string text4 = link.LinkData as string;
						link.Enabled = (!string.IsNullOrEmpty(text4) && global::System.IO.File.Exists(text4));
					}
				}
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00051AC4 File Offset: 0x0004FCC4
		private void ActionCopy()
		{
			global::System.Windows.Forms.MethodInvoker copyDelegate = this.m_CopyDelegate;
			if (copyDelegate == null)
			{
				return;
			}
			copyDelegate();
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00051AEC File Offset: 0x0004FCEC
		private void ActionCopyMessage()
		{
			global::System.Windows.Forms.Clipboard.Clear();
			global::System.Windows.Forms.Clipboard.SetText(this.txtTypeMessage.Text);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00051B04 File Offset: 0x0004FD04
		private void ActionCopyStackTrace()
		{
			global::System.Windows.Forms.Clipboard.Clear();
			global::System.Windows.Forms.Clipboard.SetText(this.m_DisplayException.StackTrace);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00051B1C File Offset: 0x0004FD1C
		private void AssignCopyButton(global::System.Windows.Forms.Control target, global::System.Windows.Forms.MethodInvoker copyDelegate, bool supportCopyAll)
		{
			this.m_CopyDelegate = copyDelegate;
			target.SuspendLayout();
			this.btnCopy.Parent = target;
			this.btnCopy.Left = target.Width - this.btnCopy.Width - this.btnCopy.Margin.Right;
			this.btnCopy.Top = this.btnCopy.Margin.Top;
			this.btnCopy.Visible = true;
			if (supportCopyAll)
			{
				this.btnCopyAll.Parent = target;
				this.btnCopyAll.Left = this.btnCopy.Left - this.btnCopyAll.Width - this.btnCopyAll.Margin.Right;
				this.btnCopyAll.Top = this.btnCopy.Top;
				this.btnCopyAll.Visible = true;
			}
			else
			{
				this.btnCopyAll.Visible = false;
			}
			target.ResumeLayout();
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00051C24 File Offset: 0x0004FE24
		private bool CheckIfInControl(out global::System.Drawing.Point relativeLocation)
		{
			relativeLocation = base.PointToClient(global::System.Windows.Forms.Control.MousePosition);
			if (relativeLocation.Y < 0 || relativeLocation.Y > base.Height)
			{
				this.m_CopyDelegate = null;
				this.btnCopy.Visible = false;
				this.btnCopyAll.Visible = false;
				return false;
			}
			return true;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00051C88 File Offset: 0x0004FE88
		private void ClearCopyButton(global::System.Windows.Forms.Control target)
		{
			if (this.btnCopy.Parent == target)
			{
				this.m_CopyDelegate = null;
				this.btnCopy.Visible = false;
				this.btnCopyAll.Visible = false;
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00051CBC File Offset: 0x0004FEBC
		private void ApplyStackTraceLinks(global::System.Windows.Forms.LinkLabel.LinkCollection links, string stackTrace)
		{
			links.Clear();
			if (stackTrace == null)
			{
				return;
			}
			int length = stackTrace.Length;
			int num = 0;
			int startIndex;
			while (num < length && (startIndex = stackTrace.IndexOf("at ", num, global::System.StringComparison.Ordinal)) >= 0)
			{
				num = stackTrace.IndexOfAny(global::Gibraltar.Monitor.Windows.Internal.UIException.LineBreakChars, startIndex);
				if (num < 0)
				{
					num = length;
				}
				int num2 = stackTrace.IndexOf(") in ", startIndex, global::System.StringComparison.Ordinal);
				if (num2 < 0 || num2 >= num)
				{
					int num3 = stackTrace.IndexOf(") [", startIndex, global::System.StringComparison.Ordinal);
					if (num3 < 0 || num3 >= num)
					{
						continue;
					}
					num2 = stackTrace.IndexOf("] in ", num3, global::System.StringComparison.Ordinal);
					if (num2 < 0 || num2 >= num)
					{
						continue;
					}
				}
				num2 += 5;
				int num4 = stackTrace.LastIndexOf(":", num - 1, num - num2, global::System.StringComparison.Ordinal);
				if (num4 < 0 || num4 >= num)
				{
					num4 = num;
				}
				if (num4 > num2)
				{
					string linkData = stackTrace.Substring(num2, num4 - num2);
					global::System.Windows.Forms.LinkLabel.Link value = new global::System.Windows.Forms.LinkLabel.Link(num2, num4 - num2, linkData);
					try
					{
						links.Add(value);
					}
					catch (global::System.Exception ex)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, true, "Gibraltar.User Interface.Session Viewer", "Unable to add one or more links in a stack trace due to " + ex.GetBaseException().GetType(), "We will stop attempting to add in any more links.  There are presently {0} links in the collection.\r\nOriginal Stack Trace: \r\n {1}", new object[]
						{
							links.Count,
							stackTrace
						});
						try
						{
							links.Remove(value);
						}
						catch (global::System.Exception ex2)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, true, "Gibraltar.User Interface.Session Viewer", "Unable to clean up bad link in a stack trace due to " + ex2.GetBaseException().GetType(), "We were trying to remove the last link we added.  There are presently {0} links in the collection.\r\nOriginal Stack Trace: \r\n {1}", new object[]
							{
								links.Count,
								stackTrace
							});
						}
						break;
					}
					if (links.Count == 31)
					{
						break;
					}
				}
			}
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this.lblStackTrace);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00051EA0 File Offset: 0x000500A0
		private static void OpenFileViaShellExec(string fileNamePath)
		{
			try
			{
				if (global::System.IO.File.Exists(fileNamePath))
				{
					global::System.Diagnostics.Process.Start(fileNamePath);
				}
			}
			catch (global::System.Exception ex)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.User Interface.Session Viewer", "Unable to open source code file", "File: '{0}'\r\nException ({1}): {2}", new object[]
				{
					fileNamePath,
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00051F14 File Offset: 0x00050114
		private void lblStackTrace_LinkClicked(object sender, global::System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string text = e.Link.LinkData as string;
			if (!string.IsNullOrEmpty(text))
			{
				global::Gibraltar.Monitor.Windows.Internal.UIException.OpenFileViaShellExec(text);
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00051F48 File Offset: 0x00050148
		private static int NextIndexWithin(string match, string toSearch, int start, int end)
		{
			if (end < 0 || end > toSearch.Length)
			{
				end = toSearch.Length;
			}
			int length = match.Length;
			int num = end - length;
			if (start < 0 || start > num)
			{
				return -1;
			}
			if (length <= 0)
			{
				return start;
			}
			char c = match[0];
			int i;
			for (i = start; i <= num; i++)
			{
				if (toSearch[i] == c)
				{
					int num2 = 1;
					while (num2 < length && match[num2] == toSearch[i + num2])
					{
						num2++;
					}
					if (num2 >= length)
					{
						break;
					}
				}
			}
			if (i > num)
			{
				i = -1;
			}
			return i;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00051FF8 File Offset: 0x000501F8
		private void OnCopyAll()
		{
			global::System.EventHandler copyAll = this.CopyAll;
			if (copyAll != null)
			{
				copyAll(this, new global::System.EventArgs());
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00052024 File Offset: 0x00050224
		private void PerformResize()
		{
			int width = base.ClientSize.Width;
			if (width != this.m_CurrentWidth)
			{
				this.m_CurrentWidth = width;
				this.panelBottom.Width = width;
				int width2 = width - this.m_TypeMessageMarginWidth;
				global::System.Drawing.Size size = new global::System.Drawing.Size(width2, 0);
				this.txtTypeMessage.MaximumSize = size;
				this.txtTypeMessage.MinimumSize = size;
				int width3 = width - this.m_StackTraceMarginWidth;
				global::System.Drawing.Size size2 = new global::System.Drawing.Size(width3, 0);
				try
				{
					this.lblStackTrace.MaximumSize = size2;
					this.lblStackTrace.MinimumSize = size2;
				}
				catch (global::System.OverflowException ex)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, true, "Gibraltar.User Interface.Session Viewer", "Unable to adjust stack trace min/max size due to " + ex.GetBaseException().GetType(), "Original Stack Trace: \r\n {0}", new object[]
					{
						this.lblStackTrace.Text
					});
				}
				global::System.Drawing.SizeF sizeF = global::System.Windows.Forms.TextRenderer.MeasureText(this.txtTypeMessage.Text, this.txtTypeMessage.Font, this.txtTypeMessage.ClientRectangle.Size, global::System.Windows.Forms.TextFormatFlags.WordBreak);
				this.txtTypeMessage.Height = global::System.Convert.ToInt32(sizeF.Height);
				int height = this.txtTypeMessage.Height;
				int height2 = this.lblStackTrace.Height;
				global::System.Drawing.Size minimumSize = this.txtTypeMessage.MinimumSize;
				if (minimumSize.Height != height)
				{
					minimumSize = new global::System.Drawing.Size(minimumSize.Width, height);
					this.txtTypeMessage.MinimumSize = minimumSize;
					this.txtTypeMessage.Height = height;
				}
				int x = base.Padding.Left + this.lblStackTrace.Margin.Left + this.m_RectangleWidth;
				int num = this.txtTypeMessage.Location.Y + this.txtTypeMessage.Height;
				num += this.txtTypeMessage.Margin.Bottom + this.lblStackTrace.Margin.Top;
				global::System.Drawing.Point location = new global::System.Drawing.Point(x, num);
				this.lblStackTrace.Location = location;
				int num2 = num + this.lblStackTrace.Height;
				num2 += this.lblStackTrace.Margin.Bottom + base.Padding.Bottom;
				if (base.Height != num2)
				{
					base.Height = num2;
				}
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000522A4 File Offset: 0x000504A4
		private void UIException_Resize(object sender, global::System.EventArgs e)
		{
			this.PerformResize();
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000522AC File Offset: 0x000504AC
		private void TextChangedHandler(object sender, global::System.EventArgs e)
		{
			this.m_CurrentWidth = 0;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000522B8 File Offset: 0x000504B8
		private void UIException_MouseEnter(object sender, global::System.EventArgs e)
		{
			this.BackColor = global::System.Drawing.Color.GhostWhite;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000522C8 File Offset: 0x000504C8
		private void UIException_MouseLeave(object sender, global::System.EventArgs e)
		{
			this.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStackTrace.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Drawing.Point point;
			this.CheckIfInControl(out point);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00052300 File Offset: 0x00050500
		private void UIException_MouseMove(object sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			global::System.Drawing.Point point;
			if (this.CheckIfInControl(out point))
			{
				return;
			}
			if (point.Y < this.txtTypeMessage.Top + this.txtTypeMessage.Height)
			{
				this.AssignCopyButton(this.txtTypeMessage, new global::System.Windows.Forms.MethodInvoker(this.ActionCopyMessage), true);
				return;
			}
			this.AssignCopyButton(this.lblStackTrace, new global::System.Windows.Forms.MethodInvoker(this.ActionCopyStackTrace), false);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00052378 File Offset: 0x00050578
		private void StackTrace_MouseEnter(object sender, global::System.EventArgs e)
		{
			this.BackColor = global::System.Drawing.Color.GhostWhite;
			this.AssignCopyButton(this.lblStackTrace, new global::System.Windows.Forms.MethodInvoker(this.ActionCopyStackTrace), false);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000523A0 File Offset: 0x000505A0
		private void StackTrace_MouseLeave(object sender, global::System.EventArgs e)
		{
			this.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStackTrace.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Drawing.Point point;
			this.CheckIfInControl(out point);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000523D8 File Offset: 0x000505D8
		private void txtTypeMessage_MouseEnter(object sender, global::System.EventArgs e)
		{
			this.BackColor = global::System.Drawing.Color.GhostWhite;
			this.AssignCopyButton(this.txtTypeMessage, new global::System.Windows.Forms.MethodInvoker(this.ActionCopyMessage), true);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00052400 File Offset: 0x00050600
		private void txtTypeMessage_MouseLeave(object sender, global::System.EventArgs e)
		{
			this.BackColor = global::System.Drawing.Color.Transparent;
			global::System.Drawing.Point point;
			this.CheckIfInControl(out point);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00052428 File Offset: 0x00050628
		private void UIException_BackColorChanged(object sender, global::System.EventArgs e)
		{
			global::System.Drawing.Color color = this.BackColor;
			if (color == global::System.Drawing.Color.Transparent)
			{
				color = global::System.Drawing.SystemColors.Window;
			}
			this.txtTypeMessage.BackColor = color;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00052464 File Offset: 0x00050664
		private void lblStackTrace_MouseDoubleClick(object sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			string text = this.lblStackTrace.Text;
			if (string.IsNullOrEmpty(text))
			{
				text = string.Empty;
			}
			else
			{
				text += "\r\n";
			}
			global::System.Windows.Forms.Clipboard.SetText(text);
			this.lblStackTrace.BackColor = global::System.Drawing.SystemColors.Highlight;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000524BC File Offset: 0x000506BC
		private void btnCopy_Click(object sender, global::System.EventArgs e)
		{
			this.ActionCopy();
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000524C4 File Offset: 0x000506C4
		private void btnCopyAll_Click(object sender, global::System.EventArgs e)
		{
			this.OnCopyAll();
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000524CC File Offset: 0x000506CC
		private void btnCopy_MouseEnter(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Forms.Control control = sender as global::System.Windows.Forms.Control;
			if (control == null)
			{
				return;
			}
			control.Cursor = global::System.Windows.Forms.Cursors.Arrow;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000524F8 File Offset: 0x000506F8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00052520 File Offset: 0x00050720
		private void InitializeComponent()
		{
			this.lblStackTrace = new global::System.Windows.Forms.LinkLabel();
			this.txtTypeMessage = new global::System.Windows.Forms.TextBox();
			this.panelLeft = new global::System.Windows.Forms.Panel();
			this.lblExceptionIndex = new global::System.Windows.Forms.Label();
			this.panelBottom = new global::System.Windows.Forms.Panel();
			this.btnCopy = new global::System.Windows.Forms.Button();
			this.btnCopyAll = new global::System.Windows.Forms.Button();
			this.panelLeft.SuspendLayout();
			base.SuspendLayout();
			this.lblStackTrace.AutoSize = true;
			this.lblStackTrace.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStackTrace.Location = new global::System.Drawing.Point(24, 36);
			this.lblStackTrace.Margin = new global::System.Windows.Forms.Padding(12, 3, 3, 5);
			this.lblStackTrace.Name = "lblStackTrace";
			this.lblStackTrace.Size = new global::System.Drawing.Size(75, 13);
			this.lblStackTrace.TabIndex = 2;
			this.lblStackTrace.TabStop = true;
			this.lblStackTrace.Text = "<StackTrace>";
			this.lblStackTrace.UseMnemonic = false;
			this.lblStackTrace.LinkClicked += this.lblStackTrace_LinkClicked;
			this.lblStackTrace.TextChanged += this.TextChangedHandler;
			this.lblStackTrace.MouseDoubleClick += this.lblStackTrace_MouseDoubleClick;
			this.lblStackTrace.MouseEnter += this.StackTrace_MouseEnter;
			this.lblStackTrace.MouseLeave += this.StackTrace_MouseLeave;
			this.txtTypeMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtTypeMessage.BackColor = global::System.Drawing.SystemColors.Window;
			this.txtTypeMessage.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.txtTypeMessage.Location = new global::System.Drawing.Point(15, 3);
			this.txtTypeMessage.Multiline = true;
			this.txtTypeMessage.Name = "txtTypeMessage";
			this.txtTypeMessage.ReadOnly = true;
			this.txtTypeMessage.Size = new global::System.Drawing.Size(560, 27);
			this.txtTypeMessage.TabIndex = 0;
			this.txtTypeMessage.Text = "<Source> : <TypeName>\r\n<Message>";
			this.txtTypeMessage.TextChanged += this.TextChangedHandler;
			this.txtTypeMessage.MouseEnter += this.txtTypeMessage_MouseEnter;
			this.txtTypeMessage.MouseLeave += this.txtTypeMessage_MouseLeave;
			this.panelLeft.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panelLeft.BackColor = global::System.Drawing.Color.SteelBlue;
			this.panelLeft.Controls.Add(this.lblExceptionIndex);
			this.panelLeft.Location = new global::System.Drawing.Point(0, 0);
			this.panelLeft.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new global::System.Drawing.Size(12, 85);
			this.panelLeft.TabIndex = 4;
			this.lblExceptionIndex.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.lblExceptionIndex.AutoSize = true;
			this.lblExceptionIndex.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExceptionIndex.ForeColor = global::System.Drawing.Color.White;
			this.lblExceptionIndex.Location = new global::System.Drawing.Point(0, 36);
			this.lblExceptionIndex.Name = "lblExceptionIndex";
			this.lblExceptionIndex.Size = new global::System.Drawing.Size(13, 13);
			this.lblExceptionIndex.TabIndex = 0;
			this.lblExceptionIndex.Text = "0";
			this.panelBottom.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panelBottom.BackColor = global::System.Drawing.Color.SteelBlue;
			this.panelBottom.Location = new global::System.Drawing.Point(0, 84);
			this.panelBottom.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new global::System.Drawing.Size(578, 1);
			this.panelBottom.TabIndex = 5;
			this.btnCopy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCopy.AutoSize = true;
			this.btnCopy.FlatAppearance.BorderSize = 0;
			this.btnCopy.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCopy.Location = new global::System.Drawing.Point(537, 36);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new global::System.Drawing.Size(41, 23);
			this.btnCopy.TabIndex = 6;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Visible = false;
			this.btnCopy.Click += this.btnCopy_Click;
			this.btnCopy.MouseEnter += this.btnCopy_MouseEnter;
			this.btnCopyAll.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCopyAll.AutoSize = true;
			this.btnCopyAll.FlatAppearance.BorderSize = 0;
			this.btnCopyAll.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCopyAll.Location = new global::System.Drawing.Point(476, 36);
			this.btnCopyAll.Name = "btnCopyAll";
			this.btnCopyAll.Size = new global::System.Drawing.Size(55, 23);
			this.btnCopyAll.TabIndex = 7;
			this.btnCopyAll.Text = "Copy All";
			this.btnCopyAll.UseVisualStyleBackColor = true;
			this.btnCopyAll.Visible = false;
			this.btnCopyAll.Click += this.btnCopyAll_Click;
			this.btnCopyAll.MouseEnter += this.btnCopy_MouseEnter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Transparent;
			base.Controls.Add(this.btnCopyAll);
			base.Controls.Add(this.btnCopy);
			base.Controls.Add(this.panelBottom);
			base.Controls.Add(this.panelLeft);
			base.Controls.Add(this.txtTypeMessage);
			base.Controls.Add(this.lblStackTrace);
			base.Margin = new global::System.Windows.Forms.Padding(1, 0, 0, 0);
			this.MinimumSize = new global::System.Drawing.Size(500, 30);
			base.Name = "UIException";
			base.Size = new global::System.Drawing.Size(578, 86);
			base.BackColorChanged += this.UIException_BackColorChanged;
			base.MouseEnter += this.UIException_MouseEnter;
			base.MouseLeave += this.UIException_MouseLeave;
			base.MouseMove += this.UIException_MouseMove;
			base.Resize += this.UIException_Resize;
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000869 RID: 2153
		private const string LogCategory = "Gibraltar.User Interface.Session Viewer";

		// Token: 0x0400086A RID: 2154
		private static readonly string[] LineBreakTokens = new string[]
		{
			"\r\n",
			"\n\r",
			"\n",
			"\r"
		};

		// Token: 0x0400086B RID: 2155
		private static readonly char[] LineBreakChars = new char[]
		{
			'\r',
			'\n'
		};

		// Token: 0x0400086C RID: 2156
		private static readonly string LineBreak = "\r\n";

		// Token: 0x0400086D RID: 2157
		private global::Loupe.Extensibility.Data.IExceptionInfo m_DisplayException;

		// Token: 0x0400086E RID: 2158
		private int m_ExceptionIndex;

		// Token: 0x0400086F RID: 2159
		private int m_CurrentWidth;

		// Token: 0x04000870 RID: 2160
		private global::System.Windows.Forms.MethodInvoker m_CopyDelegate;

		// Token: 0x04000871 RID: 2161
		private readonly int m_RectangleWidth;

		// Token: 0x04000872 RID: 2162
		private readonly int m_TypeMessageMarginWidth;

		// Token: 0x04000873 RID: 2163
		private readonly int m_StackTraceMarginWidth;

		// Token: 0x04000875 RID: 2165
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000876 RID: 2166
		private global::System.Windows.Forms.TextBox txtTypeMessage;

		// Token: 0x04000877 RID: 2167
		private global::System.Windows.Forms.LinkLabel lblStackTrace;

		// Token: 0x04000878 RID: 2168
		private global::System.Windows.Forms.Panel panelLeft;

		// Token: 0x04000879 RID: 2169
		private global::System.Windows.Forms.Panel panelBottom;

		// Token: 0x0400087A RID: 2170
		private global::System.Windows.Forms.Label lblExceptionIndex;

		// Token: 0x0400087B RID: 2171
		private global::System.Windows.Forms.Button btnCopy;

		// Token: 0x0400087C RID: 2172
		private global::System.Windows.Forms.Button btnCopyAll;
	}
}
