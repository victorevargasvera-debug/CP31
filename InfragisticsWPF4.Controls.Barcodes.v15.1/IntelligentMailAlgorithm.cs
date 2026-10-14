using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000012 RID: 18
	internal class IntelligentMailAlgorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x0600005B RID: 91 RVA: 0x000074EC File Offset: 0x000056EC
		private static global::System.Collections.Generic.Dictionary<int, int> GenerateImbTables(int n, int size)
		{
			global::System.Collections.Generic.Dictionary<int, int> dictionary = new global::System.Collections.Generic.Dictionary<int, int>();
			int num = 0;
			int num2 = size - 1;
			for (int i = 0; i < 8192; i++)
			{
				int num3 = 0;
				for (int j = 0; j < 13; j++)
				{
					num3 += (((i & 1 << j) != 0) ? 1 : 0);
				}
				if (num3 == n)
				{
					int num4 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ReverseInt(i) >> 3;
					if (num4 >= i)
					{
						if (num4 == i)
						{
							dictionary[num2] = i;
							num2--;
						}
						else
						{
							dictionary[num++] = i;
							dictionary[num++] = num4;
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0400005F RID: 95
		public const string ValidIntelligentMailChars = "0123456789";

		// Token: 0x04000060 RID: 96
		public const int VerticalClearZone = 2;

		// Token: 0x04000061 RID: 97
		internal static readonly global::System.Collections.Generic.Dictionary<int, int> Table2Of13 = global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.GenerateImbTables(2, 78);

		// Token: 0x04000062 RID: 98
		internal static readonly global::System.Collections.Generic.Dictionary<int, int> Table5Of13 = global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.GenerateImbTables(5, 1287);

		// Token: 0x04000063 RID: 99
		internal static readonly int[] AscChаr = new int[]
		{
			4,
			0,
			2,
			6,
			3,
			5,
			1,
			9,
			8,
			7,
			1,
			2,
			0,
			6,
			4,
			8,
			2,
			9,
			5,
			3,
			0,
			1,
			3,
			7,
			4,
			6,
			8,
			9,
			2,
			0,
			5,
			1,
			9,
			4,
			3,
			8,
			6,
			7,
			1,
			2,
			4,
			3,
			9,
			5,
			7,
			8,
			3,
			0,
			2,
			1,
			4,
			0,
			9,
			1,
			7,
			0,
			2,
			4,
			6,
			3,
			7,
			1,
			9,
			5,
			8
		};

		// Token: 0x04000064 RID: 100
		internal static readonly int[] DscChar = new int[]
		{
			7,
			1,
			9,
			5,
			8,
			0,
			2,
			4,
			6,
			3,
			5,
			8,
			9,
			7,
			3,
			0,
			6,
			1,
			7,
			4,
			6,
			8,
			9,
			2,
			5,
			1,
			7,
			5,
			4,
			3,
			8,
			7,
			6,
			0,
			2,
			5,
			4,
			9,
			3,
			0,
			1,
			6,
			8,
			2,
			0,
			4,
			5,
			9,
			6,
			7,
			5,
			2,
			6,
			3,
			8,
			5,
			1,
			9,
			8,
			7,
			4,
			0,
			2,
			6,
			3
		};

		// Token: 0x04000065 RID: 101
		internal static readonly int[] AscPos = new int[]
		{
			3,
			0,
			8,
			11,
			1,
			12,
			8,
			11,
			10,
			6,
			4,
			12,
			2,
			7,
			9,
			6,
			7,
			9,
			2,
			8,
			4,
			0,
			12,
			7,
			10,
			9,
			0,
			7,
			10,
			5,
			7,
			9,
			6,
			8,
			2,
			12,
			1,
			4,
			2,
			0,
			1,
			5,
			4,
			6,
			12,
			1,
			0,
			9,
			4,
			7,
			5,
			10,
			2,
			6,
			9,
			11,
			2,
			12,
			6,
			7,
			5,
			11,
			0,
			3,
			2
		};

		// Token: 0x04000066 RID: 102
		internal static readonly int[] DscPos = new int[]
		{
			2,
			10,
			12,
			5,
			9,
			1,
			5,
			4,
			3,
			9,
			11,
			5,
			10,
			1,
			6,
			3,
			4,
			1,
			10,
			0,
			2,
			11,
			8,
			6,
			1,
			12,
			3,
			8,
			6,
			4,
			4,
			11,
			0,
			6,
			1,
			9,
			11,
			5,
			3,
			7,
			3,
			10,
			7,
			11,
			8,
			2,
			10,
			3,
			5,
			8,
			0,
			3,
			12,
			11,
			8,
			4,
			5,
			1,
			3,
			0,
			7,
			12,
			9,
			8,
			10
		};
	}
}
