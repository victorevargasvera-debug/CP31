using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Windows.UI;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001E7 RID: 487
	internal class ExceptionListViewer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x0004F8EC File Offset: 0x0004DAEC
		public ExceptionListViewer()
		{
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
			this.exceptionListTable.RowCount = 0;
			this.exceptionListTable.HorizontalScroll.Maximum = 0;
			this.exceptionListTable.AutoScroll = true;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0004F944 File Offset: 0x0004DB44
		public void AddException(global::Gibraltar.Monitor.ExceptionDisplayRequest exception)
		{
			this.m_Exceptions.Add(exception);
			if (!this.m_DisplayDate && exception.Timestamp.Date < global::System.DateTimeOffset.Now.Date)
			{
				this.m_DisplayDate = true;
				try
				{
					this.exceptionListTable.SuspendLayout();
					this.exceptionListTable.Controls.Clear();
					this.exceptionListTable.RowCount = 0;
					using (global::System.Collections.Generic.List<global::Gibraltar.Monitor.ExceptionDisplayRequest>.Enumerator enumerator = this.m_Exceptions.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Gibraltar.Monitor.ExceptionDisplayRequest exception2 = enumerator.Current;
							this.DisplayException(exception2);
						}
						goto IL_BA;
					}
				}
				finally
				{
					this.exceptionListTable.ResumeLayout(true);
				}
			}
			this.DisplayException(exception);
			IL_BA:
			if (this.exceptionListTable.VerticalScroll.Visible)
			{
				global::System.Windows.Forms.Padding padding = this.exceptionListTable.Padding;
				this.exceptionListTable.Padding = new global::System.Windows.Forms.Padding(padding.Left, padding.Top, global::System.Windows.Forms.SystemInformation.VerticalScrollBarWidth, padding.Bottom);
				return;
			}
			global::System.Windows.Forms.Padding padding2 = this.exceptionListTable.Padding;
			this.exceptionListTable.Padding = new global::System.Windows.Forms.Padding(padding2.Left, padding2.Top, padding2.Left, padding2.Bottom);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0004FAAC File Offset: 0x0004DCAC
		public void Clear()
		{
			try
			{
				this.m_Exceptions.Clear();
				this.exceptionListTable.SuspendLayout();
				this.exceptionListTable.Controls.Clear();
				this.exceptionListTable.RowCount = 0;
			}
			finally
			{
				this.exceptionListTable.ResumeLayout();
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0004FB0C File Offset: 0x0004DD0C
		private void DisplayException(global::Gibraltar.Monitor.ExceptionDisplayRequest exception)
		{
			global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel = this.exceptionListTable;
			int rowCount = tableLayoutPanel.RowCount;
			tableLayoutPanel.RowCount = rowCount + 1;
			global::System.Windows.Forms.Label label = new global::System.Windows.Forms.Label();
			label.Text = ((exception.Timestamp.Date < global::System.DateTimeOffset.Now.Date) ? exception.Timestamp.ToString("G") : exception.Timestamp.ToString("T"));
			label.AutoSize = true;
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(label);
			global::System.Windows.Forms.Label label2 = new global::System.Windows.Forms.Label();
			label2.Text = exception.Exception.Message;
			label2.AutoSize = true;
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(label2);
			this.exceptionListTable.Controls.Add(label, 0, this.exceptionListTable.RowCount - 1);
			this.exceptionListTable.Controls.Add(label2, 1, this.exceptionListTable.RowCount - 1);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0004FC00 File Offset: 0x0004DE00
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0004FC28 File Offset: 0x0004DE28
		private void InitializeComponent()
		{
			this.exceptionListTable = new global::System.Windows.Forms.TableLayoutPanel();
			base.SuspendLayout();
			this.exceptionListTable.ColumnCount = 2;
			this.exceptionListTable.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.exceptionListTable.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.exceptionListTable.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.exceptionListTable.Location = new global::System.Drawing.Point(0, 0);
			this.exceptionListTable.Name = "exceptionListTable";
			this.exceptionListTable.RowCount = 2;
			this.exceptionListTable.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.exceptionListTable.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.exceptionListTable.Size = new global::System.Drawing.Size(335, 150);
			this.exceptionListTable.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.exceptionListTable);
			base.Name = "ExceptionListViewer";
			base.Size = new global::System.Drawing.Size(335, 150);
			base.ResumeLayout(false);
		}

		// Token: 0x04000833 RID: 2099
		private bool m_DisplayDate;

		// Token: 0x04000834 RID: 2100
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.ExceptionDisplayRequest> m_Exceptions = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.ExceptionDisplayRequest>();

		// Token: 0x04000835 RID: 2101
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000836 RID: 2102
		private global::System.Windows.Forms.TableLayoutPanel exceptionListTable;
	}
}
