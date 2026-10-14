using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003E RID: 62
	[global::System.Serializable]
	public class fp_lls_pack_info_t : global::Motorola.Common.Communication.CommonUtil.fp_any_pack_info_t
	{
		// Token: 0x06000167 RID: 359 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		public fp_lls_pack_info_t()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001CBF8 File Offset: 0x0001ADF8
		public fp_lls_pack_info_t(global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t packInfo)
		{
			this.pack_based_language = packInfo.pack_based_language;
			this.size_prompt_data = packInfo.size_prompt_data;
			this.size_decode_table = packInfo.size_decode_table;
			this.size_prompt_table = packInfo.size_prompt_table;
			this.size_prompt_string_ids_table = packInfo.size_prompt_string_ids_table;
			this.size_of_reserved_space = packInfo.size_of_reserved_space;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001CC54 File Offset: 0x0001AE54
		public void GetDatafromRaw(byte[] raw, uint i)
		{
			short num = (short)1172176896;
			short num2 = num;
			num = (short)44499529;
			short num3 = num;
			num = (short)1318781513;
			switch (num3 == num)
			{
			}
			num = (short)265617409;
			if (num != 0)
			{
			}
			num = (short)316801024;
			if (num != 0)
			{
			}
			this.pack_based_language = raw[(int)i];
			i += 4U;
			this.size_prompt_data = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.size_decode_table = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.size_prompt_table = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.size_prompt_string_ids_table = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.size_of_reserved_space = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		public byte[] GenerateRawData()
		{
			short num = (short)1773338624;
			short num2 = num;
			num = (short)134433876;
			short num3 = num;
			num = (short)2116570196;
			switch (num3 == num)
			{
			}
			num = (short)940834817;
			if (num != 0)
			{
			}
			num = (short)627900416;
			if (num != 0)
			{
			}
			byte[] array = new byte[24];
			int num4 = 0;
			array[num4] = this.pack_based_language;
			num4 += 4;
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.a(array, ref num4, this.size_prompt_data);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.a(array, ref num4, this.size_decode_table);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.a(array, ref num4, this.size_prompt_table);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.a(array, ref num4, this.size_prompt_string_ids_table);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.a(array, ref num4, this.size_of_reserved_space);
			return array;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001CED4 File Offset: 0x0001B0D4
		private static void a(byte[] A_0, ref int A_1, uint A_2)
		{
			short num = (short)623837184;
			short num2 = num;
			num = (short)66035415;
			short num3 = num;
			num = (short)1654103767;
			switch (num3 == num)
			{
			}
			num = (short)1618214912;
			if (num != 0)
			{
			}
			num = (short)652541953;
			if (num != 0)
			{
			}
			byte[] bytes = global::System.BitConverter.GetBytes(A_2);
			global::System.Array.Copy(bytes, 0, A_0, A_1, bytes.Length);
			A_1 += 4;
		}

		// Token: 0x04000177 RID: 375
		public const uint FP_LLS_PACK_INFO_SIZE = 24U;

		// Token: 0x04000178 RID: 376
		public byte pack_based_language;

		// Token: 0x04000179 RID: 377
		public uint size_prompt_data;

		// Token: 0x0400017A RID: 378
		public uint size_decode_table;

		// Token: 0x0400017B RID: 379
		public uint size_prompt_table;

		// Token: 0x0400017C RID: 380
		public uint size_prompt_string_ids_table;

		// Token: 0x0400017D RID: 381
		public uint size_of_reserved_space;
	}
}
