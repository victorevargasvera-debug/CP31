using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace NLog
{
	// Token: 0x0200001B RID: 27
	[global::System.Serializable]
	public class NLogConfigurationException : global::System.Exception
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00008874 File Offset: 0x00006A74
		public NLogConfigurationException()
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000887C File Offset: 0x00006A7C
		public NLogConfigurationException(string message) : base(message)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00008885 File Offset: 0x00006A85
		[global::JetBrains.Annotations.StringFormatMethod("message")]
		public NLogConfigurationException(string message, params object[] messageParameters) : base(string.Format(message, messageParameters))
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00008894 File Offset: 0x00006A94
		[global::JetBrains.Annotations.StringFormatMethod("message")]
		public NLogConfigurationException(global::System.Exception innerException, string message, params object[] messageParameters) : base(string.Format(message, messageParameters), innerException)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000088A4 File Offset: 0x00006AA4
		public NLogConfigurationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000088AE File Offset: 0x00006AAE
		protected NLogConfigurationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
