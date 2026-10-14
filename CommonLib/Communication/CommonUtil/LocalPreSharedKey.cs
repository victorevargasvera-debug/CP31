using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004D RID: 77
	public class LocalPreSharedKey
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x000241E8 File Offset: 0x000223E8
		public LocalPreSharedKey()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000241FC File Offset: 0x000223FC
		public LocalPreSharedKey(string guid, string id, string key)
		{
			this.Guid = guid;
			this.Id = id;
			this.Key = key;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00024224 File Offset: 0x00022424
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000242D4 File Offset: 0x000224D4
		public string Guid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1998520320;
				short num2 = num;
				num = (short)214664646;
				short num3 = num;
				num = (short)544441798;
				switch (num3 == num)
				{
				}
				num = (short)295305217;
				if (num != 0)
				{
				}
				num = (short)837681152;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)277413888;
				short num2 = num;
				num = (short)566504125;
				short num3 = num;
				num = (short)1308764861;
				switch (num3 == num)
				{
				}
				num = (short)1178468352;
				if (num != 0)
				{
				}
				num = (short)753074177;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00024384 File Offset: 0x00022584
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00024434 File Offset: 0x00022634
		public string Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)889847808;
				short num2 = num;
				num = (short)1288862269;
				short num3 = num;
				num = (short)1299479101;
				switch (num3 == num)
				{
				}
				num = (short)1919221761;
				if (num != 0)
				{
				}
				num = (short)2058289152;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1418854400;
				short num2 = num;
				num = (short)1555575075;
				short num3 = num;
				num = (short)45953315;
				switch (num3 == num)
				{
				}
				num = (short)6946817;
				if (num != 0)
				{
				}
				num = (short)1746075648;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000244E4 File Offset: 0x000226E4
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00024590 File Offset: 0x00022790
		public string Key
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)733216768;
				short num2 = num;
				num = (short)1512439809;
				if (num != 0)
				{
				}
				num = (short)543699818;
				short num3 = num;
				num = (short)2042770282;
				switch (num3 == num)
				{
				}
				num = (short)24510464;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1866727424;
				short num2 = num;
				num = (short)1200947201;
				if (num != 0)
				{
				}
				num = (short)397582077;
				short num3 = num;
				num = (short)2107547389;
				switch (num3 == num)
				{
				}
				num = (short)1115684864;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040001DE RID: 478
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040001DF RID: 479
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040001E0 RID: 480
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
