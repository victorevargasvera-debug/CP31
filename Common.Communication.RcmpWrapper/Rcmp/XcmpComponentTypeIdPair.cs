using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000064 RID: 100
	public class XcmpComponentTypeIdPair
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000167F4 File Offset: 0x000149F4
		public XcmpComponentTypeIdPair(ushort type, ushort id)
		{
			this.Type = type;
			this.ID = id;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00016818 File Offset: 0x00014A18
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000168C8 File Offset: 0x00014AC8
		internal ushort Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1528421902;
				short num2 = num;
				num = (short)626187790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1210187776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1192493057;
				if (num != 0)
				{
				}
				num = (short)565641216;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)838139905;
				if (num != 0)
				{
				}
				num = (short)1906376704;
				short num2 = num;
				num = (short)1809209944;
				short num3 = num;
				num = (short)297818712;
				switch (num3 == num)
				{
				}
				num = (short)437321728;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00016978 File Offset: 0x00014B78
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00016A24 File Offset: 0x00014C24
		internal ushort ID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)87479795;
				short num2 = num;
				num = (short)1958401523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)765526016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001062401;
				if (num != 0)
				{
				}
				num = (short)303497216;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1873131707;
				short num2 = num;
				num = (short)1505671355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)733872128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1321205761;
				if (num != 0)
				{
				}
				num = (short)1760362496;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040001D0 RID: 464
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort a;

		// Token: 0x040001D1 RID: 465
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort b;
	}
}
