using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003B RID: 59
	[global::System.Serializable]
	public class fp_language_pack_info_t : global::Motorola.Common.Communication.CommonUtil.fp_any_pack_info_t
	{
		// Token: 0x06000162 RID: 354 RVA: 0x0001C860 File Offset: 0x0001AA60
		public void GetDatafromRaw(byte[] raw, uint i)
		{
			short num = (short)626982912;
			short num2 = num;
			num = (short)1945706392;
			short num3 = num;
			num = (short)1172184984;
			switch (num3 == num)
			{
			}
			num = (short)1689518081;
			if (num != 0)
			{
			}
			num = (short)1704132608;
			if (num != 0)
			{
			}
			this.language_id = raw[(int)i];
			i += 4U;
			this.size_prompt_data = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.size_decode_table = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.size_prompt_table = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.checksum = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.lang_font_id = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
		}

		// Token: 0x04000168 RID: 360
		public byte language_id;

		// Token: 0x04000169 RID: 361
		public uint size_prompt_data;

		// Token: 0x0400016A RID: 362
		public uint size_decode_table;

		// Token: 0x0400016B RID: 363
		public uint size_prompt_table;

		// Token: 0x0400016C RID: 364
		public uint checksum;

		// Token: 0x0400016D RID: 365
		public uint lang_font_id;
	}
}
