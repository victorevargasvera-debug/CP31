using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000071 RID: 113
	public class SessionParameter
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0003600C File Offset: 0x0003420C
		public SessionParameter(ushort previousSessionID = 0, bool archiveSession = false, string psk = null)
		{
			this.PreviousSessionID = previousSessionID;
			this.ArchiveSession = archiveSession;
			this.Psk = psk;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00036034 File Offset: 0x00034234
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x000360E4 File Offset: 0x000342E4
		public ushort PreviousSessionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)441582213;
				short num2 = num;
				num = (short)631964293;
				switch (num2 == num)
				{
				}
				num = (short)417398785;
				if (num != 0)
				{
				}
				num = (short)1029439488;
				if (num != 0)
				{
				}
				num = (short)2003501056;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1019766248;
				short num2 = num;
				num = (short)1975674344;
				switch (num2 == num)
				{
				}
				num = (short)1646460929;
				if (num != 0)
				{
				}
				num = (short)241696768;
				if (num != 0)
				{
				}
				num = (short)1870004224;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00036194 File Offset: 0x00034394
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00036248 File Offset: 0x00034448
		public bool ArchiveSession
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1242098445;
				short num2 = num;
				num = (short)1916267277;
				switch (num2 == num)
				{
				}
				num = (short)394264577;
				if (num != 0)
				{
				}
				num = (short)1781006336;
				if (num != 0)
				{
				}
				num = (short)2085289984;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1952552288;
				short num2 = num;
				num = (short)1567004000;
				switch (num2 == num)
				{
				}
				num = (short)1952710656;
				if (num != 0)
				{
				}
				num = (short)523304961;
				if (num != 0)
				{
				}
				num = (short)143851520;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002FB RID: 763 RVA: 0x000362F8 File Offset: 0x000344F8
		// (set) Token: 0x060002FC RID: 764 RVA: 0x000363A8 File Offset: 0x000345A8
		public string Psk
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)322699265;
				if (num != 0)
				{
				}
				num = (short)638426686;
				short num2 = num;
				num = (short)773758526;
				switch (num2 == num)
				{
				}
				num = (short)147783680;
				if (num != 0)
				{
				}
				num = (short)1043136512;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)763796148;
				short num2 = num;
				num = (short)1193188020;
				switch (num2 == num)
				{
				}
				num = (short)2135621632;
				if (num != 0)
				{
				}
				num = (short)1805844481;
				if (num != 0)
				{
				}
				num = (short)1884618752;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x0400030E RID: 782
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort a;

		// Token: 0x0400030F RID: 783
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x04000310 RID: 784
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
