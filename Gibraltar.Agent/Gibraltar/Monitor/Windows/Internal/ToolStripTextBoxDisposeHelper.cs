using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001E5 RID: 485
	internal sealed class ToolStripTextBoxDisposeHelper
	{
		// Token: 0x06001791 RID: 6033 RVA: 0x0004E228 File Offset: 0x0004C428
		public static void CreateToolStripDisposeHelpers(global::System.Windows.Forms.ToolStrip toolStrip)
		{
			foreach (object obj in toolStrip.Items)
			{
				global::System.Windows.Forms.ToolStripTextBox toolStripTextBox = ((global::System.Windows.Forms.ToolStripItem)obj) as global::System.Windows.Forms.ToolStripTextBox;
				if (toolStripTextBox != null)
				{
					new global::Gibraltar.Monitor.Windows.Internal.ToolStripTextBoxDisposeHelper(toolStripTextBox);
				}
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0004E298 File Offset: 0x0004C498
		public ToolStripTextBoxDisposeHelper(global::System.Windows.Forms.ToolStripTextBox textBox)
		{
			this.m_TextBox = textBox.TextBox;
			this.m_TextBox.VisibleChanged += this.textBox_VisibleChanged;
			this.m_TextBox.Disposed += this.textBox_Disposed;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0004E2EC File Offset: 0x0004C4EC
		private void textBox_Disposed(object sender, global::System.EventArgs e)
		{
			try
			{
				global::Microsoft.Win32.UserPreferenceChangedEventHandler value = (global::Microsoft.Win32.UserPreferenceChangedEventHandler)global::System.Delegate.CreateDelegate(typeof(global::Microsoft.Win32.UserPreferenceChangedEventHandler), this.m_TextBox, "OnUserPreferenceChanged");
				for (int i = 0; i < this.m_VisibleCount + 1; i++)
				{
					global::Microsoft.Win32.SystemEvents.UserPreferenceChanged -= value;
				}
			}
			catch (global::System.MissingMethodException)
			{
			}
			catch (global::System.MemberAccessException)
			{
				throw;
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0004E360 File Offset: 0x0004C560
		private void textBox_VisibleChanged(object sender, global::System.EventArgs e)
		{
			if (this.m_TextBox.Visible)
			{
				this.m_VisibleCount++;
				return;
			}
			this.m_VisibleCount--;
		}

		// Token: 0x04000816 RID: 2070
		private global::System.Windows.Forms.TextBox m_TextBox;

		// Token: 0x04000817 RID: 2071
		private int m_VisibleCount;
	}
}
