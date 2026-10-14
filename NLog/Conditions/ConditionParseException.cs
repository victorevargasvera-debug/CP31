using System;
using System.Runtime.Serialization;

namespace NLog.Conditions
{
	// Token: 0x02000183 RID: 387
	[global::System.Serializable]
	public class ConditionParseException : global::System.Exception
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x0002B904 File Offset: 0x00029B04
		public ConditionParseException()
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0002B90C File Offset: 0x00029B0C
		public ConditionParseException(string message) : base(message)
		{
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0002B915 File Offset: 0x00029B15
		public ConditionParseException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002B91F File Offset: 0x00029B1F
		protected ConditionParseException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
