using System;
using System.IO;
using System.Security;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x02000132 RID: 306
	[global::System.Security.SecuritySafeCritical]
	internal class Win32ThreadIDHelper : global::NLog.Internal.ThreadIDHelper
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x000234B8 File Offset: 0x000216B8
		public Win32ThreadIDHelper()
		{
			this.currentProcessID = global::NLog.Internal.NativeMethods.GetCurrentProcessId();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(512);
			if (global::NLog.Internal.NativeMethods.GetModuleFileName(global::System.IntPtr.Zero, stringBuilder, stringBuilder.Capacity) == 0U)
			{
				throw new global::System.InvalidOperationException("Cannot determine program name.");
			}
			this.currentProcessName = stringBuilder.ToString();
			this.currentProcessBaseName = global::System.IO.Path.GetFileNameWithoutExtension(this.currentProcessName);
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0002351C File Offset: 0x0002171C
		public override int CurrentProcessID
		{
			get
			{
				return this.currentProcessID;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x00023524 File Offset: 0x00021724
		public override string CurrentProcessName
		{
			get
			{
				return this.currentProcessName;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0002352C File Offset: 0x0002172C
		public override string CurrentProcessBaseName
		{
			get
			{
				return this.currentProcessBaseName;
			}
		}

		// Token: 0x040003D8 RID: 984
		private readonly int currentProcessID;

		// Token: 0x040003D9 RID: 985
		private readonly string currentProcessName;

		// Token: 0x040003DA RID: 986
		private readonly string currentProcessBaseName;
	}
}
