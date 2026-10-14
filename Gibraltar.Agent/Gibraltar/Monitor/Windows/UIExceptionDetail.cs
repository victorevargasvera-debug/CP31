using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Gibraltar.Monitor.Internal;
using Gibraltar.Monitor.Windows.Internal;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001DA RID: 474
	internal class UIExceptionDetail : global::System.Windows.Forms.UserControl
	{
		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06001699 RID: 5785 RVA: 0x0004754C File Offset: 0x0004574C
		// (remove) Token: 0x0600169A RID: 5786 RVA: 0x00047588 File Offset: 0x00045788
		public event global::System.EventHandler TitleChanged;

		// Token: 0x0600169B RID: 5787 RVA: 0x000475C4 File Offset: 0x000457C4
		public UIExceptionDetail()
		{
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000475E4 File Offset: 0x000457E4
		protected virtual string CalculateTitle()
		{
			string result;
			if (this.m_ExceptionInfo == null)
			{
				result = "Exceptions";
			}
			else
			{
				int num = 0;
				for (global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo = this.m_ExceptionInfo; exceptionInfo != null; exceptionInfo = exceptionInfo.InnerException)
				{
					num++;
				}
				result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Exceptions ({0:N0})", new object[]
				{
					num
				});
			}
			return result;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00047648 File Offset: 0x00045848
		private void ActionCopyAll()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo = this.m_ExceptionInfo; exceptionInfo != null; exceptionInfo = exceptionInfo.InnerException)
			{
				if (!string.IsNullOrEmpty(exceptionInfo.Source))
				{
					stringBuilder.AppendFormat("{0}: {1}\r\n", exceptionInfo.Source, exceptionInfo.TypeName);
				}
				else
				{
					stringBuilder.AppendLine(exceptionInfo.TypeName);
				}
				if (!string.IsNullOrEmpty(exceptionInfo.Message))
				{
					stringBuilder.AppendLine(exceptionInfo.Message);
				}
				if (!string.IsNullOrEmpty(exceptionInfo.StackTrace))
				{
					stringBuilder.AppendLine(exceptionInfo.StackTrace);
				}
			}
			global::System.Windows.Forms.Clipboard.SetText(stringBuilder.ToString());
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x000476F4 File Offset: 0x000458F4
		private void SetDisplayTitle()
		{
			string text = this.CalculateTitle();
			if (text != this.m_Title)
			{
				this.m_Title = text;
				this.OnTitleChanged();
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0004772C File Offset: 0x0004592C
		private void SetDisplayExceptionMessage(global::Loupe.Extensibility.Data.IExceptionInfo exceptionInfo)
		{
			if (this.m_ExceptionInfo == exceptionInfo)
			{
				if (this.m_ExceptionInfo == null)
				{
					return;
				}
				global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IExceptionInfo> list = global::Gibraltar.Monitor.Internal.LogMessagePacket.ExceptionsList(this.m_ExceptionInfo);
				if (list.Count == this.m_ExceptionControls.Count)
				{
					int num = 0;
					foreach (global::Gibraltar.Monitor.Windows.Internal.UIException ex in this.m_ExceptionControls)
					{
						ex.DisplayException = list[num];
						ex.ExceptionIndex = list.Count - num;
						num++;
					}
					this.SetDisplayTitle();
					return;
				}
			}
			this.flowExceptions.SuspendLayout();
			if (this.m_ExceptionInfo != null)
			{
				foreach (global::Gibraltar.Monitor.Windows.Internal.UIException ex2 in this.m_ExceptionControls)
				{
					this.flowExceptions.Controls.Remove(ex2);
					ex2.CopyAll -= this.OnExceptionControlCopyAll;
					ex2.Dispose();
				}
				this.m_ExceptionControls.Clear();
				this.m_ExceptionInfo = null;
			}
			this.m_ExceptionInfo = exceptionInfo;
			if (this.m_ExceptionInfo != null)
			{
				global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IExceptionInfo> list2 = global::Gibraltar.Monitor.Internal.LogMessagePacket.ExceptionsList(this.m_ExceptionInfo);
				if (list2.Count > 0)
				{
					this.lblNoException.Visible = false;
					this.flowExceptions.Visible = true;
					for (int i = 0; i < list2.Count; i++)
					{
						global::Gibraltar.Monitor.Windows.Internal.UIException ex3 = new global::Gibraltar.Monitor.Windows.Internal.UIException();
						ex3.CopyAll += this.OnExceptionControlCopyAll;
						this.m_ExceptionControls.Add(ex3);
						this.flowExceptions.Controls.Add(ex3);
						ex3.DisplayException = list2[i];
						ex3.ExceptionIndex = list2.Count - i;
					}
					this.PropagateResize();
				}
				else
				{
					this.flowExceptions.Visible = false;
					this.lblNoException.Visible = true;
				}
			}
			else
			{
				this.flowExceptions.Visible = false;
				this.lblNoException.Visible = true;
			}
			this.flowExceptions.ResumeLayout(true);
			this.SetDisplayTitle();
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0004797C File Offset: 0x00045B7C
		private void OnExceptionControlCopyAll(object sender, global::System.EventArgs e)
		{
			this.ActionCopyAll();
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00047984 File Offset: 0x00045B84
		protected virtual void OnTitleChanged()
		{
			global::System.EventHandler titleChanged = this.TitleChanged;
			if (titleChanged != null)
			{
				titleChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000479B0 File Offset: 0x00045BB0
		private void PropagateResize()
		{
			int num = this.flowExceptions.Width - this.flowExceptions.Padding.Left - this.flowExceptions.Padding.Right;
			foreach (object obj in this.flowExceptions.Controls)
			{
				global::System.Windows.Forms.Control control = (global::System.Windows.Forms.Control)obj;
				control.Width = num - control.Left - control.Margin.Right;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00047A64 File Offset: 0x00045C64
		[global::System.ComponentModel.Browsable(false)]
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00047A6C File Offset: 0x00045C6C
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x00047A74 File Offset: 0x00045C74
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::Loupe.Extensibility.Data.IExceptionInfo ExceptionInfo
		{
			get
			{
				return this.m_ExceptionInfo;
			}
			set
			{
				this.SetDisplayExceptionMessage(value);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00047A80 File Offset: 0x00045C80
		private void flowExceptions_Resize(object sender, global::System.EventArgs e)
		{
			this.PropagateResize();
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00047A88 File Offset: 0x00045C88
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00047AB0 File Offset: 0x00045CB0
		private void InitializeComponent()
		{
			this.flowExceptions = new global::System.Windows.Forms.FlowLayoutPanel();
			this.lblNoException = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.flowExceptions.AutoScroll = true;
			this.flowExceptions.AutoSize = true;
			this.flowExceptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowExceptions.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowExceptions.Location = new global::System.Drawing.Point(0, 0);
			this.flowExceptions.Name = "flowExceptions";
			this.flowExceptions.Padding = new global::System.Windows.Forms.Padding(0, 0, 24, 0);
			this.flowExceptions.Size = new global::System.Drawing.Size(690, 230);
			this.flowExceptions.TabIndex = 0;
			this.flowExceptions.WrapContents = false;
			this.flowExceptions.Resize += this.flowExceptions_Resize;
			this.lblNoException.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNoException.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblNoException.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNoException.Location = new global::System.Drawing.Point(0, 0);
			this.lblNoException.Name = "lblNoException";
			this.lblNoException.Size = new global::System.Drawing.Size(690, 230);
			this.lblNoException.TabIndex = 0;
			this.lblNoException.Text = "No Exception Attached";
			this.lblNoException.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Controls.Add(this.lblNoException);
			base.Controls.Add(this.flowExceptions);
			base.Margin = new global::System.Windows.Forms.Padding(0);
			base.Name = "UIExceptionDetail";
			base.Size = new global::System.Drawing.Size(690, 230);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000787 RID: 1927
		private const string MenuKeyCopyStackTrace = "fnCopyStackTrace";

		// Token: 0x04000788 RID: 1928
		private const string MenuKeyCopyStackTraceDiv = "fnCopyStackTraceDiv";

		// Token: 0x04000789 RID: 1929
		private global::Loupe.Extensibility.Data.IExceptionInfo m_ExceptionInfo;

		// Token: 0x0400078A RID: 1930
		private string m_Title;

		// Token: 0x0400078B RID: 1931
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.UIException> m_ExceptionControls = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.Windows.Internal.UIException>();

		// Token: 0x0400078D RID: 1933
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400078E RID: 1934
		private global::System.Windows.Forms.FlowLayoutPanel flowExceptions;

		// Token: 0x0400078F RID: 1935
		private global::System.Windows.Forms.Label lblNoException;
	}
}
