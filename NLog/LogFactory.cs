using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NLog.Internal;

namespace NLog
{
	// Token: 0x0200000C RID: 12
	public class LogFactory<T> : global::NLog.LogFactory where T : global::NLog.Logger
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00002DD5 File Offset: 0x00000FD5
		public new T GetLogger(string name)
		{
			return (T)((object)base.GetLogger(name, typeof(T)));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public new T GetCurrentClassLogger()
		{
			string classFullName = global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(new global::System.Diagnostics.StackFrame(1, false));
			return this.GetLogger(classFullName);
		}
	}
}
