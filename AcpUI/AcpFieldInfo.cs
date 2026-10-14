using System;

namespace AcpUI
{
	// Token: 0x02000047 RID: 71
	internal class AcpFieldInfo
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x000449CC File Offset: 0x00042BCC
		internal AcpFieldInfo(int A_0, int A_1, string A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000449F4 File Offset: 0x00042BF4
		internal int RecsetID
		{
			get
			{
				short num = (short)876950674;
				short num2 = num;
				num = (short)862139538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406140416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391263745;
				if (num != 0)
				{
				}
				num = (short)645857280;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00044AA4 File Offset: 0x00042CA4
		internal int SectionID
		{
			get
			{
				short num = (short)117363513;
				short num2 = num;
				num = (short)52876089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1962016768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1073872896;
				if (num != 0)
				{
				}
				num = (short)358875137;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00044B54 File Offset: 0x00042D54
		internal string FieldName
		{
			get
			{
				short num = (short)1535861573;
				short num2 = num;
				num = (short)1899127621;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573833216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)643563520;
				if (num != 0)
				{
				}
				num = (short)1558904833;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x0400024A RID: 586
		private int a;

		// Token: 0x0400024B RID: 587
		private int b;

		// Token: 0x0400024C RID: 588
		private string c;
	}
}
