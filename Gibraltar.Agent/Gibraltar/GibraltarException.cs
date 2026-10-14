using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Gibraltar
{
	// Token: 0x020000AB RID: 171
	[global::System.Serializable]
	internal class GibraltarException : global::System.Exception
	{
		// Token: 0x06000713 RID: 1811 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void BreakPoint()
		{
			if (global::Gibraltar.GibraltarException.s_BreakPointGibraltarExceptions && global::System.Diagnostics.Debugger.IsAttached)
			{
				global::System.Diagnostics.Debugger.Break();
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000CE18 File Offset: 0x0000B018
		public GibraltarException()
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000CE20 File Offset: 0x0000B020
		public GibraltarException(string message) : base(message)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000CE2C File Offset: 0x0000B02C
		public GibraltarException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000CE38 File Offset: 0x0000B038
		protected GibraltarException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000142 RID: 322
		private static bool s_BreakPointGibraltarExceptions;
	}
}
