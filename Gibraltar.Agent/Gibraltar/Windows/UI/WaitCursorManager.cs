using System;
using System.Windows.Forms;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000CB RID: 203
	internal class WaitCursorManager : global::System.IDisposable
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x00012768 File Offset: 0x00010968
		public WaitCursorManager(global::System.Windows.Forms.Control currentControl)
		{
			this.m_CurrentForm = currentControl.FindForm();
			if (this.m_CurrentForm != null)
			{
				this.m_PreviousWaitCursor = this.m_CurrentForm.UseWaitCursor;
				this.m_CurrentForm.UseWaitCursor = true;
				global::System.Windows.Forms.Cursor.Current = global::System.Windows.Forms.Cursors.WaitCursor;
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000127C0 File Offset: 0x000109C0
		public void Dispose()
		{
			if (this.m_CurrentForm != null)
			{
				try
				{
					this.m_CurrentForm.UseWaitCursor = this.m_PreviousWaitCursor;
					this.m_CurrentForm = null;
					if (!this.m_PreviousWaitCursor)
					{
						global::System.Windows.Forms.Cursor.Current = global::System.Windows.Forms.Cursors.Default;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.Form m_CurrentForm;

		// Token: 0x040001D8 RID: 472
		private readonly bool m_PreviousWaitCursor;
	}
}
