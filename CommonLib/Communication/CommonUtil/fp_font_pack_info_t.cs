using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003D RID: 61
	[global::System.Serializable]
	public class fp_font_pack_info_t : global::Motorola.Common.Communication.CommonUtil.fp_any_pack_info_t
	{
		// Token: 0x06000165 RID: 357 RVA: 0x0001CA00 File Offset: 0x0001AC00
		public void GetDatafromRaw(byte[] raw, uint i)
		{
			short num = (short)1592918016;
			short num2 = num;
			num = (short)974507024;
			short num3 = num;
			num = (short)84266000;
			switch (num3 == num)
			{
			}
			num = (short)485359617;
			if (num != 0)
			{
			}
			num = (short)1357905920;
			if (num != 0)
			{
			}
			this.font_id = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.zoom_setting = raw[(int)i];
			i += 4U;
			this.font_height = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.blk_char_width = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.unicode_to_glyph_data_size = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.glyph_data_size = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.lang_font_id = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
			i += 4U;
			this.device_id = (uint)((int)raw[(int)(i + 3U)] << 24 | (int)raw[(int)(i + 2U)] << 16 | (int)raw[(int)(i + 1U)] << 8 | (int)raw[(int)i]);
		}

		// Token: 0x0400016F RID: 367
		public uint font_id;

		// Token: 0x04000170 RID: 368
		public byte zoom_setting;

		// Token: 0x04000171 RID: 369
		public uint font_height;

		// Token: 0x04000172 RID: 370
		public uint blk_char_width;

		// Token: 0x04000173 RID: 371
		public uint unicode_to_glyph_data_size;

		// Token: 0x04000174 RID: 372
		public uint glyph_data_size;

		// Token: 0x04000175 RID: 373
		public uint lang_font_id;

		// Token: 0x04000176 RID: 374
		public uint device_id;
	}
}
