using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x020004FD RID: 1277
	public class Decimal
	{
		// Token: 0x06002FD9 RID: 12249 RVA: 0x00090E0C File Offset: 0x0008F00C
		public Decimal(byte[] data, int startOffset)
		{
			this.field_1_wReserved = global::NPOI.Util.LittleEndian.GetShort(data, startOffset);
			int num = startOffset + 2;
			this.field_2_scale = data[num];
			num++;
			this.field_3_sign = data[num];
			num++;
			this.field_4_hi32 = global::NPOI.Util.LittleEndian.GetInt(data, num);
			num += 4;
			this.field_5_lo64 = global::NPOI.Util.LittleEndian.GetLong(data, num);
			num += 8;
		}

		// Token: 0x0400156A RID: 5482
		public const int SIZE = 16;

		// Token: 0x0400156B RID: 5483
		private short field_1_wReserved;

		// Token: 0x0400156C RID: 5484
		private byte field_2_scale;

		// Token: 0x0400156D RID: 5485
		private byte field_3_sign;

		// Token: 0x0400156E RID: 5486
		private int field_4_hi32;

		// Token: 0x0400156F RID: 5487
		private long field_5_lo64;
	}
}
