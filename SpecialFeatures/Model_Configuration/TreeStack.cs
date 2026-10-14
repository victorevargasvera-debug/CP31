using System;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000B7 RID: 183
	public class TreeStack
	{
		// Token: 0x06000C08 RID: 3080 RVA: 0x000F6568 File Offset: 0x000F4768
		internal bool IsEmpty()
		{
			while (this.b != 0)
			{
				short num = (short)1271652703;
				short num2 = num;
				num = (short)832299359;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2133000193;
					if (num != 0)
					{
					}
					num = (short)1159331840;
					short num3 = num;
					num = (short)2030829568;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00002DDC File Offset: 0x00000FDC
		internal TreeStack(int size)
		{
			this.a = new global::SpecialFeatures.Model_Configuration.ExpTreeNode[size];
			this.b = 0;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000F6620 File Offset: 0x000F4820
		internal void Push(global::SpecialFeatures.Model_Configuration.ExpTreeNode f)
		{
			short num = (short)2108806137;
			short num2 = num;
			num = (short)1489294329;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1425014784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1248657409;
			if (num != 0)
			{
			}
			num = (short)55836672;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Model_Configuration.ExpTreeNode[] array = this.a;
			int num4 = this.b;
			this.b = num4 + 1;
			array[num4] = f;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000F66E4 File Offset: 0x000F48E4
		internal global::SpecialFeatures.Model_Configuration.ExpTreeNode Pop()
		{
			while (this.b <= 0)
			{
				short num = (short)551419905;
				if (num != 0)
				{
				}
				num = (short)1389707297;
				short num2 = num;
				num = (short)1137983521;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1902182400;
					short num3 = num;
					num = (short)2118909952;
					if (num != 0)
					{
					}
					return null;
				}
				}
			}
			global::SpecialFeatures.Model_Configuration.ExpTreeNode[] array = this.a;
			int num4 = this.b - 1;
			this.b = num4;
			return array[num4];
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x000F67B4 File Offset: 0x000F49B4
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x000F6878 File Offset: 0x000F4A78
		public global::SpecialFeatures.Model_Configuration.ExpTreeNode Top
		{
			get
			{
				short num = (short)467795968;
				short num2 = num;
				num = (short)362802277;
				short num3 = num;
				num = (short)925887589;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2134179841;
					if (num != 0)
					{
					}
					num = (short)1161428992;
					if (num != 0)
					{
					}
					if (this.b <= 0)
					{
						return null;
					}
					break;
				}
				return this.a[this.b - 1];
			}
			set
			{
				short num = (short)1782317056;
				short num2 = num;
				num = (short)1044671552;
				short num3 = num;
				num = (short)720071744;
				switch (num3 == num)
				{
				}
				num = (short)847314944;
				if (num != 0)
				{
				}
				num = (short)1488519169;
				if (num != 0)
				{
				}
				this.a[this.b - 1] = value;
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000F6934 File Offset: 0x000F4B34
		internal void Clear()
		{
			short num = (short)445906944;
			short num2 = num;
			num = (short)634719886;
			short num3 = num;
			num = (short)1819086478;
			switch (num3 == num)
			{
			}
			num = (short)1650327553;
			if (num != 0)
			{
			}
			num = (short)2013855744;
			if (num != 0)
			{
			}
			this.b = 0;
		}

		// Token: 0x040005B8 RID: 1464
		private global::SpecialFeatures.Model_Configuration.ExpTreeNode[] a;

		// Token: 0x040005B9 RID: 1465
		private int b;
	}
}
