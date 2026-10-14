using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003AD RID: 941
	public class BookBoolRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002090 RID: 8336 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BookBoolRecord()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00063F96 File Offset: 0x00062196
		public BookBoolRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_save_link_values = in1.ReadShort();
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x00063FAA File Offset: 0x000621AA
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x00063FB2 File Offset: 0x000621B2
		public short SaveLinkValues
		{
			get
			{
				return this.field_1_save_link_values;
			}
			set
			{
				this.field_1_save_link_values = value;
			}
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00063FBC File Offset: 0x000621BC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BOOKBOOL]\n");
			stringBuilder.Append("    .savelinkvalues  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.SaveLinkValues)).Append("\n");
			stringBuilder.Append("[/BOOKBOOL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00064011 File Offset: 0x00062211
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_save_link_values);
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0006401F File Offset: 0x0006221F
		public override short Sid
		{
			get
			{
				return 218;
			}
		}

		// Token: 0x04000CB9 RID: 3257
		public const short sid = 218;

		// Token: 0x04000CBA RID: 3258
		private short field_1_save_link_values;
	}
}
