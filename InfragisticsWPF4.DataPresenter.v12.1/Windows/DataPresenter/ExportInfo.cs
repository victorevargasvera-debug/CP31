using System;
using System.Collections.Generic;
using System.IO;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000F2 RID: 242
	public class ExportInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0003A24C File Offset: 0x0003844C
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x0003A254 File Offset: 0x00038454
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0003A269 File Offset: 0x00038469
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0003A274 File Offset: 0x00038474
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0003A2C0 File Offset: 0x000384C0
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0003A2C8 File Offset: 0x000384C8
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

		// Token: 0x06000D4E RID: 3406 RVA: 0x0003A2DD File Offset: 0x000384DD
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

		// Token: 0x04000514 RID: 1300
		private string _exportType;

		// Token: 0x04000515 RID: 1301
		private string _fileName;

		// Token: 0x04000516 RID: 1302
		private string _fileNameWithoutPath;
	}
}
