using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000C8 RID: 200
	internal partial class FormUserPreferences : ApplicationSettingsBase, IDisposable
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00011FD8 File Offset: 0x000101D8
		public FormUserPreferences(Form mainWindow, bool preserveFormDefaults = false, string settingsKey = null) : base(mainWindow, settingsKey ?? mainWindow.GetType().Name)
		{
			this.m_MainWindow = mainWindow;
			this.RationalizeMainWindowSettings(preserveFormDefaults);
			this.ApplyMainWindowSettings();
			SystemEvents.DisplaySettingsChanging += this.SystemEvents_DisplaySettingsChanging;
			this.AttachEvents();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00012120 File Offset: 0x00010320
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00012130 File Offset: 0x00010330
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				SystemEvents.DisplaySettingsChanging -= this.SystemEvents_DisplaySettingsChanging;
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0001214C File Offset: 0x0001034C
		protected void ApplyMainWindowSettings()
		{
			if (this.m_MainWindow.InvokeRequired)
			{
				FormUserPreferences.ApplyUserDisplayPreferencesCallback method = new FormUserPreferences.ApplyUserDisplayPreferencesCallback(this.ApplyMainWindowSettings);
				try
				{
					this.m_MainWindow.Invoke(method);
					return;
				}
				catch (Exception obj)
				{
					GC.KeepAlive(obj);
					return;
				}
			}
			this.m_MainWindow.Location = new Point(this.MainWindowLeft, this.MainWindowTop);
			this.m_MainWindow.Size = new Size(this.MainWindowWidth, this.MainWindowHeight);
			if (this.MainWindowMaximized)
			{
				this.m_MainWindow.WindowState = FormWindowState.Maximized;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000121F4 File Offset: 0x000103F4
		protected virtual bool RationalizeMainWindowSettings(bool preserveFormDefaults)
		{
			bool result = false;
			bool flag = false;
			if (this.MainWindowWidth == 0 && this.MainWindowHeight == 0)
			{
				if (preserveFormDefaults)
				{
					this.MainWindowWidth = this.m_MainWindow.Width;
					this.MainWindowHeight = this.m_MainWindow.Height;
				}
				else
				{
					flag = true;
					this.MainWindowMaximized = true;
				}
			}
			int x = 0;
			int y = 0;
			if (this.MainWindowWidth > 0)
			{
				x = this.MainWindowLeft + this.MainWindowWidth / 2;
			}
			if (this.MainWindowHeight > 0)
			{
				y = this.MainWindowTop + this.MainWindowHeight / 2;
			}
			Screen screen = Screen.FromPoint(new Point(x, y));
			if (screen.WorkingArea.Height < this.MainWindowHeight)
			{
				result = true;
				this.MainWindowHeight = screen.WorkingArea.Height;
			}
			else if (flag)
			{
				this.MainWindowHeight = (int)(0.75 * (double)screen.WorkingArea.Height);
			}
			if (screen.WorkingArea.Width < this.MainWindowWidth)
			{
				result = true;
				this.MainWindowWidth = screen.WorkingArea.Width;
			}
			else if (flag)
			{
				this.MainWindowWidth = (int)(0.75 * (double)screen.WorkingArea.Width);
			}
			int num = screen.WorkingArea.Left + screen.WorkingArea.Width - this.MainWindowWidth;
			if (num < this.MainWindowLeft)
			{
				result = true;
				this.MainWindowLeft = num;
			}
			int num2 = screen.WorkingArea.Top + screen.WorkingArea.Height - this.MainWindowHeight;
			if (num2 < this.MainWindowTop)
			{
				result = true;
				this.MainWindowTop = num2;
			}
			Screen screen2 = Screen.FromPoint(new Point(this.MainWindowLeft, this.MainWindowTop));
			if (screen2.WorkingArea.Left > this.MainWindowLeft)
			{
				result = true;
				this.MainWindowLeft = screen2.WorkingArea.Left;
			}
			Screen screen3 = Screen.FromPoint(new Point(this.MainWindowLeft + this.MainWindowWidth, this.MainWindowTop));
			if (screen3.WorkingArea.Top > this.MainWindowTop)
			{
				result = true;
				this.MainWindowTop = screen3.WorkingArea.Top;
			}
			screen3 = Screen.FromPoint(new Point(this.MainWindowLeft, this.MainWindowTop));
			if (screen3.WorkingArea.Top > this.MainWindowTop)
			{
				result = true;
				this.MainWindowTop = screen3.WorkingArea.Top;
			}
			return result;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000124CC File Offset: 0x000106CC
		private void AttachEvents()
		{
			if (!this.m_EventsAttached)
			{
				this.m_EventsAttached = true;
				this.m_MainWindow.FormClosing += this.form_FormClosing;
				this.m_MainWindow.LocationChanged += this.form_LocationChanged;
				this.m_MainWindow.Resize += this.form_Resize;
				this.m_MainWindow.SizeChanged += this.form_SizeChanged;
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0001254C File Offset: 0x0001074C
		private void DetatchEvents()
		{
			SystemEvents.DisplaySettingsChanging -= this.SystemEvents_DisplaySettingsChanging;
			this.m_MainWindow.FormClosing -= this.form_FormClosing;
			this.m_MainWindow.LocationChanged -= this.form_LocationChanged;
			this.m_MainWindow.Resize -= this.form_Resize;
			this.m_MainWindow.SizeChanged -= this.form_SizeChanged;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000125CC File Offset: 0x000107CC
		private void SystemEvents_DisplaySettingsChanging(object sender, EventArgs e)
		{
			if (this.m_MainWindow.WindowState == FormWindowState.Normal && this.RationalizeMainWindowSettings(false))
			{
				this.ApplyMainWindowSettings();
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000125F0 File Offset: 0x000107F0
		private void form_FormClosing(object sender, FormClosingEventArgs e)
		{
			Trace.TraceInformation("Form {0} closing\r\nClose reason: {1}", new object[]
			{
				this.m_MainWindow.GetType().Name,
				e.CloseReason
			});
			if (e.CloseReason == CloseReason.UserClosing)
			{
				this.Save();
			}
			this.DetatchEvents();
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001264C File Offset: 0x0001084C
		private void form_LocationChanged(object sender, EventArgs e)
		{
			if (this.m_MainWindow.WindowState == FormWindowState.Normal)
			{
				this.MainWindowLeft = this.m_MainWindow.Left;
				this.MainWindowTop = this.m_MainWindow.Top;
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00012690 File Offset: 0x00010890
		private void form_SizeChanged(object sender, EventArgs e)
		{
			switch (this.m_MainWindow.WindowState)
			{
			case FormWindowState.Normal:
				this.MainWindowMaximized = false;
				this.MainWindowHeight = this.m_MainWindow.Height;
				this.MainWindowWidth = this.m_MainWindow.Width;
				return;
			case FormWindowState.Minimized:
				this.m_RecalulateDisplaySize = true;
				return;
			case FormWindowState.Maximized:
				this.MainWindowMaximized = true;
				this.m_RecalulateDisplaySize = true;
				return;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001270C File Offset: 0x0001090C
		private void form_Resize(object sender, EventArgs e)
		{
			if (this.m_MainWindow.WindowState == FormWindowState.Normal && this.m_RecalulateDisplaySize)
			{
				this.m_RecalulateDisplaySize = false;
				this.MainWindowMaximized = false;
				if (this.RationalizeMainWindowSettings(false))
				{
					this.ApplyMainWindowSettings();
				}
			}
		}

		// Token: 0x040001D3 RID: 467
		private readonly Form m_MainWindow;

		// Token: 0x040001D4 RID: 468
		private bool m_RecalulateDisplaySize;

		// Token: 0x040001D5 RID: 469
		private bool m_EventsAttached;

		// Token: 0x02000493 RID: 1171
		// (Invoke) Token: 0x06003310 RID: 13072
		private delegate void ApplyUserDisplayPreferencesCallback();
	}
}
