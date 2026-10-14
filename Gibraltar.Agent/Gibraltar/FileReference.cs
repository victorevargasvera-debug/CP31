using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace Gibraltar
{
	// Token: 0x020000B3 RID: 179
	internal class FileReference
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x0600077B RID: 1915 RVA: 0x0000E050 File Offset: 0x0000C250
		// (remove) Token: 0x0600077C RID: 1916 RVA: 0x0000E08C File Offset: 0x0000C28C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600077D RID: 1917 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		internal FileReference(global::System.IO.FileInfo referencedFile)
		{
			if (referencedFile == null)
			{
				throw new global::System.ArgumentNullException("referencedFile");
			}
			this.Caption = referencedFile.Name;
			this.FileNamePath = referencedFile.FullName;
			this.LastWriteTime = referencedFile.LastWriteTime;
			this.Refresh();
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0000E11C File Offset: 0x0000C31C
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0000E124 File Offset: 0x0000C324
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			internal set
			{
				if (this.m_Caption != value)
				{
					this.m_Caption = value;
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Caption"));
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0000E150 File Offset: 0x0000C350
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0000E158 File Offset: 0x0000C358
		public string FileNamePath
		{
			get
			{
				return this.m_FileNamePath;
			}
			internal set
			{
				if (this.m_FileNamePath != value)
				{
					this.m_FileNamePath = value;
					this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("FileNamePath"));
				}
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0000E184 File Offset: 0x0000C384
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0000E18C File Offset: 0x0000C38C
		public byte[] Data
		{
			get
			{
				return this.m_Data;
			}
			private set
			{
				this.m_Data = value;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("Data"));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		public global::System.DateTime LastWriteTime
		{
			get
			{
				return this.m_LastWriteTime;
			}
			private set
			{
				this.m_LastWriteTime = value;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("LastWriteTime"));
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		internal void Refresh()
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.FileNamePath);
			if (this.m_CurrentFileInfo == null || fileInfo.LastWriteTime > this.m_CurrentFileInfo.LastWriteTime)
			{
				this.m_CurrentFileInfo = fileInfo;
				this.LastWriteTime = this.m_CurrentFileInfo.LastWriteTime;
				this.LoadData();
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0000E230 File Offset: 0x0000C430
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x0000E238 File Offset: 0x0000C438
		internal bool ItemFound { get; set; }

		// Token: 0x06000789 RID: 1929 RVA: 0x0000E244 File Offset: 0x0000C444
		protected void LoadData()
		{
			try
			{
				this.Data = global::System.IO.File.ReadAllBytes(this.FileNamePath);
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.TraceWarning("Unable to Load Data for File\r\nWhile attempting to load the data for '{0}' an exception was raised: {1}", new object[]
				{
					this.FileNamePath,
					ex.Message,
					ex
				});
				this.Data = null;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		protected void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs args)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, args);
			}
		}

		// Token: 0x04000170 RID: 368
		private global::System.IO.FileInfo m_CurrentFileInfo;

		// Token: 0x04000172 RID: 370
		private string m_Caption;

		// Token: 0x04000173 RID: 371
		private string m_FileNamePath;

		// Token: 0x04000174 RID: 372
		private global::System.DateTime m_LastWriteTime;

		// Token: 0x04000175 RID: 373
		private byte[] m_Data;
	}
}
