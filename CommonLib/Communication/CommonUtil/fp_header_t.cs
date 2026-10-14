using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000038 RID: 56
	[global::System.Serializable]
	public class fp_header_t
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0001B7CC File Offset: 0x000199CC
		public void GetHeaderfromRawData(byte[] raw)
		{
			short num = (short)120867309;
			short num2 = num;
			num = (short)765872621;
			switch (num2 == num)
			{
			}
			num = (short)2047475712;
			short num3 = num;
			num = (short)1442054145;
			if (num != 0)
			{
			}
			num = (short)1906180096;
			if (num != 0)
			{
			}
			uint num4 = 0U;
			this.checksum = (uint)((int)raw[(int)(num4 + 3U)] << 24 | (int)raw[(int)(num4 + 2U)] << 16 | (int)raw[(int)(num4 + 1U)] << 8 | (int)raw[(int)num4]);
			num4 += 4U;
			this.header_version = raw[(int)num4];
			this.pack_product_platform = raw[(int)(num4 + 1U)];
			this.pack_release_number = raw[(int)(num4 + 2U)];
			this.pack_revision_number = raw[(int)(num4 + 3U)];
			this.pack_sub_revision_num = raw[(int)(num4 + 4U)];
			this.pack_type = raw[(int)(num4 + 5U)];
			num4 += 8U;
			this.pack_size = (uint)((int)raw[(int)(num4 + 3U)] << 24 | (int)raw[(int)(num4 + 2U)] << 16 | (int)raw[(int)(num4 + 1U)] << 8 | (int)raw[(int)num4]);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001B904 File Offset: 0x00019B04
		public fp_header_t()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001B918 File Offset: 0x00019B18
		public fp_header_t(global::Motorola.Common.Communication.CommonUtil.fp_header_t fpHeader)
		{
			this.checksum = fpHeader.checksum;
			this.header_version = fpHeader.header_version;
			this.pack_product_platform = fpHeader.pack_product_platform;
			this.pack_release_number = fpHeader.pack_release_number;
			this.pack_revision_number = fpHeader.pack_revision_number;
			this.pack_sub_revision_num = fpHeader.pack_sub_revision_num;
			this.pack_type = fpHeader.pack_type;
			this.pack_size = fpHeader.pack_size;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001B98C File Offset: 0x00019B8C
		public byte[] GeneratellpHeaderData()
		{
			short num = (short)402569815;
			short num2 = num;
			num = (short)722909783;
			switch (num2 == num)
			{
			}
			num = (short)1367080960;
			short num3 = num;
			num = (short)11010049;
			if (num != 0)
			{
			}
			num = (short)167706624;
			if (num != 0)
			{
			}
			byte[] array = new byte[16];
			int num4 = 0;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.checksum);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.header_version);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.pack_product_platform);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.pack_release_number);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.pack_revision_number);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.pack_sub_revision_num);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.pack_type);
			num4 += 2;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.a(array, ref num4, this.pack_size);
			return array;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		private static void a(byte[] A_0, ref int A_1, byte A_2)
		{
			short num = (short)184262214;
			short num2 = num;
			num = (short)586980934;
			switch (num2 == num)
			{
			}
			num = (short)863961088;
			short num3 = num;
			num = (short)143851520;
			if (num != 0)
			{
			}
			num = (short)1280049153;
			if (num != 0)
			{
			}
			A_0[A_1] = A_2;
			A_1++;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001BB6C File Offset: 0x00019D6C
		private static void a(byte[] A_0, ref int A_1, uint A_2)
		{
			short num = (short)1073510232;
			short num2 = num;
			num = (short)1904047960;
			switch (num2 == num)
			{
			}
			num = (short)1468727296;
			short num3 = num;
			num = (short)2103508993;
			if (num != 0)
			{
			}
			num = (short)193200128;
			if (num != 0)
			{
			}
			byte[] bytes = global::System.BitConverter.GetBytes(A_2);
			global::System.Array.Copy(bytes, 0, A_0, A_1, bytes.Length);
			A_1 += 4;
		}

		// Token: 0x04000156 RID: 342
		public const uint FP_HEADER_SIZE = 16U;

		// Token: 0x04000157 RID: 343
		public uint checksum;

		// Token: 0x04000158 RID: 344
		public byte header_version;

		// Token: 0x04000159 RID: 345
		public byte pack_product_platform;

		// Token: 0x0400015A RID: 346
		public byte pack_release_number;

		// Token: 0x0400015B RID: 347
		public byte pack_revision_number;

		// Token: 0x0400015C RID: 348
		public byte pack_sub_revision_num;

		// Token: 0x0400015D RID: 349
		public byte pack_type;

		// Token: 0x0400015E RID: 350
		public uint pack_size;
	}
}
