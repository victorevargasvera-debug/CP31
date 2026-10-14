using System;
using System.ComponentModel;
using System.Reflection;

namespace NLog.Config
{
	// Token: 0x02000159 RID: 345
	public class AssemblyLoadingEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		// Token: 0x06000F30 RID: 3888 RVA: 0x00026A51 File Offset: 0x00024C51
		public AssemblyLoadingEventArgs(global::System.Reflection.Assembly assembly)
		{
			this.Assembly = assembly;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00026A60 File Offset: 0x00024C60
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00026A68 File Offset: 0x00024C68
		public global::System.Reflection.Assembly Assembly { get; private set; }
	}
}
