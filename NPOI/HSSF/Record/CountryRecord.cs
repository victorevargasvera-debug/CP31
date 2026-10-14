using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003BE RID: 958
	public class CountryRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060021A6 RID: 8614 RVA: 0x0005FE49 File Offset: 0x0005E049
		public CountryRecord()
		{
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00066998 File Offset: 0x00064B98
		public CountryRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_default_country = in1.ReadShort();
			this.field_2_current_country = in1.ReadShort();
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000669B8 File Offset: 0x00064BB8
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x000669C0 File Offset: 0x00064BC0
		public short DefaultCountry
		{
			get
			{
				return this.field_1_default_country;
			}
			set
			{
				this.field_1_default_country = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000669C9 File Offset: 0x00064BC9
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x000669D1 File Offset: 0x00064BD1
		public short CurrentCountry
		{
			get
			{
				return this.field_2_current_country;
			}
			set
			{
				this.field_2_current_country = value;
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000669DC File Offset: 0x00064BDC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[COUNTRY]\n");
			stringBuilder.Append("    .defaultcountry  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.DefaultCountry)).Append("\n");
			stringBuilder.Append("    .currentcountry  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.CurrentCountry)).Append("\n");
			stringBuilder.Append("[/COUNTRY]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00066A57 File Offset: 0x00064C57
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.DefaultCountry);
			out1.WriteShort((int)this.CurrentCountry);
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00018498 File Offset: 0x00016698
		protected override int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00066A71 File Offset: 0x00064C71
		public override short Sid
		{
			get
			{
				return 140;
			}
		}

		// Token: 0x04000D35 RID: 3381
		public const short sid = 140;

		// Token: 0x04000D36 RID: 3382
		private short field_1_default_country;

		// Token: 0x04000D37 RID: 3383
		private short field_2_current_country;
	}
}
