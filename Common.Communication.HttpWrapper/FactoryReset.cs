using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000030 RID: 48
	[global::System.Runtime.Serialization.DataContract]
	public class FactoryReset
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000B9EC File Offset: 0x00009BEC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.ReasonClass factoryReset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)310941454;
				short num2 = num;
				num = (short)831887118;
				switch (num2 == num)
				{
				}
				num = (short)1924399105;
				if (num != 0)
				{
				}
				num = (short)98172928;
				if (num != 0)
				{
				}
				num = (short)684130304;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1085371680;
				short num2 = num;
				num = (short)1288140064;
				switch (num2 == num)
				{
				}
				num = (short)1367343105;
				if (num != 0)
				{
				}
				num = (short)279838720;
				if (num != 0)
				{
				}
				num = (short)1402273792;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		public FactoryReset(global::Motorola.Common.Communication.ReasonClass reason)
		{
			this.factoryReset = reason;
		}

		// Token: 0x04000077 RID: 119
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.ReasonClass a;
	}
}
