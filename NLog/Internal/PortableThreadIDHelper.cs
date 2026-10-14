using System;
using System.Diagnostics;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x02000117 RID: 279
	internal class PortableThreadIDHelper : global::NLog.Internal.ThreadIDHelper
	{
		// Token: 0x06000D43 RID: 3395 RVA: 0x00020C75 File Offset: 0x0001EE75
		public PortableThreadIDHelper()
		{
			this._currentProcessId = global::System.Diagnostics.Process.GetCurrentProcess().Id;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00020C8D File Offset: 0x0001EE8D
		public override int CurrentProcessID
		{
			get
			{
				return this._currentProcessId;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00020C95 File Offset: 0x0001EE95
		public override string CurrentProcessName
		{
			get
			{
				this.GetProcessName();
				return this._currentProcessName;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00020CA3 File Offset: 0x0001EEA3
		public override string CurrentProcessBaseName
		{
			get
			{
				this.GetProcessName();
				return this._currentProcessBaseName;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00020CB4 File Offset: 0x0001EEB4
		private void GetProcessName()
		{
			if (this._currentProcessName == null)
			{
				try
				{
					this._currentProcessName = global::System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
				}
				catch (global::System.Exception exception)
				{
					if (exception.MustBeRethrown())
					{
						throw;
					}
					this._currentProcessName = "<unknown>";
				}
				this._currentProcessBaseName = global::System.IO.Path.GetFileNameWithoutExtension(this._currentProcessName);
			}
		}

		// Token: 0x040003A6 RID: 934
		private const string UnknownProcessName = "<unknown>";

		// Token: 0x040003A7 RID: 935
		private readonly int _currentProcessId;

		// Token: 0x040003A8 RID: 936
		private string _currentProcessName;

		// Token: 0x040003A9 RID: 937
		private string _currentProcessBaseName;
	}
}
