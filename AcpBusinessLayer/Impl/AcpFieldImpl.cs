using System;
using System.Runtime.CompilerServices;

namespace AcpBusinessLayer.Impl
{
	// Token: 0x02000060 RID: 96
	internal class AcpFieldImpl<TDBType> : global::AcpBusinessLayer.Impl.AcpFieldImplBase
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x0006F35C File Offset: 0x0006D55C
		internal AcpFieldImpl(string uiName) : base(uiName)
		{
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0006F370 File Offset: 0x0006D570
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0006F420 File Offset: 0x0006D620
		internal TDBType DefaultValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)833573655;
				short num2 = num;
				num = (short)434524951;
				switch (num2 == num)
				{
				}
				num = (short)1997078529;
				if (num != 0)
				{
				}
				num = (short)2047279104;
				short num3 = num;
				num = (short)2068316160;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)585962503;
				short num2 = num;
				num = (short)1371935751;
				switch (num2 == num)
				{
				}
				num = (short)1237647361;
				if (num != 0)
				{
				}
				num = (short)1363410944;
				short num3 = num;
				num = (short)1615331328;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000178 RID: 376
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private TDBType a;
	}
}
