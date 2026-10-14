using System;
using System.Runtime.CompilerServices;

namespace AcpUI
{
	// Token: 0x02000051 RID: 81
	public struct HelpMapData
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00059A4C File Offset: 0x00057C4C
		public HelpMapData(string id, string url)
		{
			this.a = id;
			this.b = url;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00059A68 File Offset: 0x00057C68
		public string Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1328873473;
				if (num != 0)
				{
				}
				num = (short)136634971;
				short num2 = num;
				num = (short)1766711899;
				switch (num2 == num)
				{
				}
				num = (short)1160118272;
				short num3 = num;
				num = (short)1389953024;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00059B18 File Offset: 0x00057D18
		public string Url
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1441404119;
				short num2 = num;
				num = (short)407770327;
				switch (num2 == num)
				{
				}
				num = (short)134479873;
				if (num != 0)
				{
				}
				num = (short)1082327040;
				short num3 = num;
				num = (short)677576704;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x040002A0 RID: 672
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x040002A1 RID: 673
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;
	}
}
