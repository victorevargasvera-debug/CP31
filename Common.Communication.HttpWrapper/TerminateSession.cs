using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000037 RID: 55
	[global::System.Runtime.Serialization.DataContract]
	public class TerminateSession
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000CC0C File Offset: 0x0000AE0C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.ReasonClass terminateSession
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)390960605;
				short num2 = num;
				num = (short)802854365;
				switch (num2 == num)
				{
				}
				num = (short)1184104449;
				if (num != 0)
				{
				}
				num = (short)1125908480;
				if (num != 0)
				{
				}
				num = (short)371785728;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1426598414;
				short num2 = num;
				num = (short)1643588110;
				switch (num2 == num)
				{
				}
				num = (short)1431306241;
				if (num != 0)
				{
				}
				num = (short)480378880;
				if (num != 0)
				{
				}
				num = (short)1029046272;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000CD70 File Offset: 0x0000AF70
		public TerminateSession(global::Motorola.Common.Communication.ReasonClass reason)
		{
			this.terminateSession = reason;
		}

		// Token: 0x04000084 RID: 132
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.ReasonClass a;
	}
}
