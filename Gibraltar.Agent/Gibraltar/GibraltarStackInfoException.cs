using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Gibraltar
{
	// Token: 0x0200016B RID: 363
	[global::System.Serializable]
	internal class GibraltarStackInfoException : global::System.Exception
	{
		// Token: 0x06000EF7 RID: 3831 RVA: 0x0002691C File Offset: 0x00024B1C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public GibraltarStackInfoException() : base(new global::System.Diagnostics.StackTrace(1).ToString())
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00026930 File Offset: 0x00024B30
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public GibraltarStackInfoException(string message) : base((string.IsNullOrEmpty(message) ? string.Empty : (message + "\r\n")) + new global::System.Diagnostics.StackTrace(1))
		{
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00026964 File Offset: 0x00024B64
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public GibraltarStackInfoException(string message, global::System.Exception innerException) : base((string.IsNullOrEmpty(message) ? string.Empty : (message + "\r\n")) + new global::System.Diagnostics.StackTrace(1), innerException)
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00026998 File Offset: 0x00024B98
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public GibraltarStackInfoException(string message, global::System.Exception innerException, int skipFrames) : base((string.IsNullOrEmpty(message) ? string.Empty : (message + "\r\n")) + new global::System.Diagnostics.StackTrace(((skipFrames < 0) ? 0 : skipFrames) + 1), innerException)
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000269EC File Offset: 0x00024BEC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		protected GibraltarStackInfoException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000269F8 File Offset: 0x00024BF8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static global::Gibraltar.GibraltarStackInfoException GetThrownException(string message, global::System.Exception innerException)
		{
			try
			{
				throw new global::Gibraltar.GibraltarStackInfoException(message, innerException, 1);
			}
			catch (global::Gibraltar.GibraltarStackInfoException result)
			{
			}
			global::Gibraltar.GibraltarStackInfoException result;
			return result;
		}
	}
}
