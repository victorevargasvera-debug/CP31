using System;
using System.Runtime.Serialization;

namespace NLog.Conditions
{
	// Token: 0x02000176 RID: 374
	[global::System.Serializable]
	public class ConditionEvaluationException : global::System.Exception
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x0002B2A8 File Offset: 0x000294A8
		public ConditionEvaluationException()
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0002B2B0 File Offset: 0x000294B0
		public ConditionEvaluationException(string message) : base(message)
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0002B2B9 File Offset: 0x000294B9
		public ConditionEvaluationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0002B2C3 File Offset: 0x000294C3
		protected ConditionEvaluationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
