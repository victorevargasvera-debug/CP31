using System;
using System.Runtime.Serialization;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000BA RID: 186
	[global::System.Serializable]
	public class ErrorException : global::System.Exception
	{
		// Token: 0x06000C13 RID: 3091 RVA: 0x00002E22 File Offset: 0x00001022
		internal ErrorException(long MessageId, string Message)
		{
			this._message = Message;
			this._messageId = MessageId;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00002E38 File Offset: 0x00001038
		internal ErrorException(string Message)
		{
			this._message = Message;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00002E47 File Offset: 0x00001047
		internal ErrorException(long MessageId)
		{
			this._messageId = MessageId;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000F7218 File Offset: 0x000F5418
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)87359488;
			short num2 = num;
			num = (short)1796098317;
			short num3 = num;
			num = (short)735594765;
			switch (num3 == num)
			{
			}
			num = (short)1539768320;
			if (num != 0)
			{
			}
			num = (short)318177281;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x040005C6 RID: 1478
		internal string _message;

		// Token: 0x040005C7 RID: 1479
		internal long _messageId;
	}
}
