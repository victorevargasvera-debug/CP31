using System;
using System.Collections.Generic;
using System.IO;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000110 RID: 272
	public class ExportInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0004AE78 File Offset: 0x00049078
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x0004AE80 File Offset: 0x00049080
		public string ExportType
		{
			get
			{
				return this._exportType;
			}
			set
			{
				this.SetField<string>(ref this._exportType, value, "ExportType");
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0004AE95 File Offset: 0x00049095
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x0004AEA0 File Offset: 0x000490A0
		public string FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				if (this.SetField<string>(ref this._fileName, value, "FileName"))
				{
					string fileNameWithoutPath = (value == null) ? null : value;
					try
					{
						fileNameWithoutPath = global::System.IO.Path.GetFileName(value);
					}
					catch (global::System.ArgumentException)
					{
					}
					this.FileNameWithoutPath = fileNameWithoutPath;
				}
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0004AEEC File Offset: 0x000490EC
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x0004AEF4 File Offset: 0x000490F4
		public string FileNameWithoutPath
		{
			get
			{
				return this._fileNameWithoutPath;
			}
			private set
			{
				this.SetField<string>(ref this._fileNameWithoutPath, value, "FileNameWithoutPath");
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0004AF09 File Offset: 0x00049109
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x0004AF11 File Offset: 0x00049111
		public string StatusMessage
		{
			get
			{
				return this._statusMessage;
			}
			set
			{
				this.SetField<string>(ref this._statusMessage, value, "StatusMessage");
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0004AF26 File Offset: 0x00049126
		private bool SetField<T>(ref T member, T value, string propertyName)
		{
			if (global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(member, value))
			{
				return false;
			}
			member = value;
			this.OnPropertyChanged(propertyName);
			return true;
		}

		// Token: 0x040006B2 RID: 1714
		private string _exportType;

		// Token: 0x040006B3 RID: 1715
		private string _fileName;

		// Token: 0x040006B4 RID: 1716
		private string _fileNameWithoutPath;

		// Token: 0x040006B5 RID: 1717
		private string _statusMessage;
	}
}
