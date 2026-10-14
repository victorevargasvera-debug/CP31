using System;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
using DevAge.IO;
using DevAge.IO.IsolatedStorage;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200031D RID: 797
	internal class PositionRecorderIsolatedStorage : global::DevAge.IO.IsolatedStorage.IsolatedStorageSettingVersionBase
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x00082EF8 File Offset: 0x000810F8
		public PositionRecorderIsolatedStorage() : base(1)
		{
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x00082F10 File Offset: 0x00081110
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x00082F18 File Offset: 0x00081118
		public global::DevAge.Windows.Forms.RestoreFlags RestoreFlags
		{
			get
			{
				return this.m_RestoreFlags;
			}
			set
			{
				this.m_RestoreFlags = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00082F24 File Offset: 0x00081124
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x00082F2C File Offset: 0x0008112C
		public global::DevAge.Windows.Forms.SaveFlags SaveFlags
		{
			get
			{
				return this.m_SaveFlags;
			}
			set
			{
				this.m_SaveFlags = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x00082F38 File Offset: 0x00081138
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x00082F40 File Offset: 0x00081140
		public global::System.Drawing.Point Location
		{
			get
			{
				return this.m_Location;
			}
			set
			{
				this.m_Location = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x00082F4C File Offset: 0x0008114C
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x00082F54 File Offset: 0x00081154
		public global::System.Drawing.Size Size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x00082F60 File Offset: 0x00081160
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x00082F68 File Offset: 0x00081168
		public global::System.Windows.Forms.FormWindowState WindowState
		{
			get
			{
				return this.m_WindowState;
			}
			set
			{
				this.m_WindowState = value;
			}
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00082F74 File Offset: 0x00081174
		protected override void OnLoad(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File, int p_CurrentVersion)
		{
			if (p_CurrentVersion == this.Version)
			{
				int x = global::DevAge.IO.StreamPersistence.ReadInt32(p_File);
				int y = global::DevAge.IO.StreamPersistence.ReadInt32(p_File);
				int width = global::DevAge.IO.StreamPersistence.ReadInt32(p_File);
				int height = global::DevAge.IO.StreamPersistence.ReadInt32(p_File);
				int windowState = global::DevAge.IO.StreamPersistence.ReadInt32(p_File);
				this.m_Location.X = x;
				this.m_Location.Y = y;
				this.m_Size.Width = width;
				this.m_Size.Height = height;
				this.m_WindowState = (global::System.Windows.Forms.FormWindowState)windowState;
				return;
			}
			throw new global::DevAge.IO.InvalidDataException();
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00082FF4 File Offset: 0x000811F4
		protected override void OnSave(global::System.IO.IsolatedStorage.IsolatedStorageFileStream p_File)
		{
			base.OnSave(p_File);
			global::DevAge.IO.StreamPersistence.Write(p_File, this.m_Location.X);
			global::DevAge.IO.StreamPersistence.Write(p_File, this.m_Location.Y);
			global::DevAge.IO.StreamPersistence.Write(p_File, this.m_Size.Width);
			global::DevAge.IO.StreamPersistence.Write(p_File, this.m_Size.Height);
			global::DevAge.IO.StreamPersistence.Write(p_File, (int)this.m_WindowState);
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0008305C File Offset: 0x0008125C
		protected override void OnCreate()
		{
			this.m_Location = new global::System.Drawing.Point(int.MinValue, int.MinValue);
			this.m_Size = new global::System.Drawing.Size(int.MinValue, int.MinValue);
			this.m_WindowState = (global::System.Windows.Forms.FormWindowState)(-1);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00083090 File Offset: 0x00081290
		public virtual void Save(global::System.Windows.Forms.Control p_Control)
		{
			if (p_Control is global::System.Windows.Forms.Form)
			{
				global::System.Windows.Forms.Form form = (global::System.Windows.Forms.Form)p_Control;
				if ((this.m_SaveFlags & global::DevAge.Windows.Forms.SaveFlags.ActiveMDIMaximized) == global::DevAge.Windows.Forms.SaveFlags.ActiveMDIMaximized && form.IsMdiChild)
				{
					if (form.MdiParent.ActiveMdiChild != null && form.MdiParent.ActiveMdiChild.WindowState == global::System.Windows.Forms.FormWindowState.Maximized)
					{
						this.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
					}
					else
					{
						this.WindowState = form.WindowState;
					}
				}
				else
				{
					this.WindowState = form.WindowState;
				}
			}
			if (this.WindowState != global::System.Windows.Forms.FormWindowState.Minimized)
			{
				this.Location = p_Control.Location;
				this.Size = p_Control.Size;
			}
			this.Save();
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00083148 File Offset: 0x00081348
		public virtual void Load(global::System.Windows.Forms.Control p_Control)
		{
			this.Load();
			if ((this.RestoreFlags & global::DevAge.Windows.Forms.RestoreFlags.WindowState) == global::DevAge.Windows.Forms.RestoreFlags.WindowState && p_Control is global::System.Windows.Forms.Form && this.WindowState != (global::System.Windows.Forms.FormWindowState)(-1) && (this.WindowState != global::System.Windows.Forms.FormWindowState.Minimized || (this.RestoreFlags & global::DevAge.Windows.Forms.RestoreFlags.Minimized) == global::DevAge.Windows.Forms.RestoreFlags.Minimized))
			{
				((global::System.Windows.Forms.Form)p_Control).WindowState = this.WindowState;
			}
			if (p_Control is global::System.Windows.Forms.Form && ((global::System.Windows.Forms.Form)p_Control).WindowState == global::System.Windows.Forms.FormWindowState.Minimized)
			{
				return;
			}
			if ((this.RestoreFlags & global::DevAge.Windows.Forms.RestoreFlags.Location) == global::DevAge.Windows.Forms.RestoreFlags.Location && this.Location.X != -2147483648)
			{
				p_Control.Location = this.Location;
			}
			if ((this.RestoreFlags & global::DevAge.Windows.Forms.RestoreFlags.Size) == global::DevAge.Windows.Forms.RestoreFlags.Size && this.Size.Width != -2147483648)
			{
				p_Control.Size = this.Size;
			}
		}

		// Token: 0x04000D4A RID: 3402
		private global::System.Drawing.Point m_Location;

		// Token: 0x04000D4B RID: 3403
		private global::System.Drawing.Size m_Size;

		// Token: 0x04000D4C RID: 3404
		private global::System.Windows.Forms.FormWindowState m_WindowState;

		// Token: 0x04000D4D RID: 3405
		private global::DevAge.Windows.Forms.RestoreFlags m_RestoreFlags = global::DevAge.Windows.Forms.RestoreFlags.WindowState | global::DevAge.Windows.Forms.RestoreFlags.Size | global::DevAge.Windows.Forms.RestoreFlags.Location;

		// Token: 0x04000D4E RID: 3406
		private global::DevAge.Windows.Forms.SaveFlags m_SaveFlags = global::DevAge.Windows.Forms.SaveFlags.ActiveMDIMaximized;
	}
}
