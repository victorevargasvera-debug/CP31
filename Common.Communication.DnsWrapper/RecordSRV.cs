using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class RecordSRV : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005158 File Offset: 0x00003358
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00005208 File Offset: 0x00003408
		public ushort Priority
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)267833436;
				short num2 = num;
				num = (short)76468316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1456209920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163512321;
				if (num != 0)
				{
				}
				num = (short)1033502720;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1413604125;
				short num2 = num;
				num = (short)1786700573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769144320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432354817;
				if (num != 0)
				{
				}
				num = (short)709492736;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000052BC File Offset: 0x000034BC
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005370 File Offset: 0x00003570
		public ushort Weight
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1509090140;
				short num2 = num;
				num = (short)1126294364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458293248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1197473793;
				if (num != 0)
				{
				}
				num = (short)1937244160;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)569857255;
				short num2 = num;
				num = (short)1584747751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277689856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)664862721;
				if (num != 0)
				{
				}
				num = (short)963837952;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005420 File Offset: 0x00003620
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000054CC File Offset: 0x000036CC
		public ushort Port
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1156138841;
				short num2 = num;
				num = (short)1049642841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570504704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)773652480;
				if (num != 0)
				{
				}
				num = (short)982253569;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1545116907;
				short num2 = num;
				num = (short)1846975723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)480182272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969684481;
				if (num != 0)
				{
				}
				num = (short)843710464;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000557C File Offset: 0x0000377C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000562C File Offset: 0x0000382C
		public string Target
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1670808786;
				short num2 = num;
				num = (short)1982104786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546570240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)580190209;
				if (num != 0)
				{
				}
				num = (short)746127360;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1438335487;
				short num2 = num;
				num = (short)1450852863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207894016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)111673345;
				if (num != 0)
				{
				}
				num = (short)1323040768;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000056DC File Offset: 0x000038DC
		public override void Serialize(global::System.IO.Stream stream)
		{
			short num = (short)2054373348;
			short num2 = num;
			num = (short)1726037988;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1638465536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)562167808;
			if (num != 0)
			{
			}
			num = (short)542900225;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort a;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort b;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort c;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;
	}
}
