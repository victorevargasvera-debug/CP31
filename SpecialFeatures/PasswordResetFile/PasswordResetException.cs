using System;
using System.Runtime.Serialization;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.PasswordResetFile
{
	// Token: 0x020000A8 RID: 168
	[global::System.Serializable]
	public sealed class PasswordResetException : global::System.Exception
	{
		// Token: 0x06000B82 RID: 2946 RVA: 0x00002D72 File Offset: 0x00000F72
		public PasswordResetException(string message) : base(message)
		{
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002D7B File Offset: 0x00000F7B
		internal PasswordResetException(string message, string details) : this(message, details, null)
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002D86 File Offset: 0x00000F86
		internal PasswordResetException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000DEB6C File Offset: 0x000DCD6C
		internal PasswordResetException(string message, string details, global::System.Exception innerException)
		{
			int a_ = 19;
			base..ctor(message, innerException);
			this.Data.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕ﶗﶛ첟톡", a_), details);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002D90 File Offset: 0x00000F90
		internal PasswordResetException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
