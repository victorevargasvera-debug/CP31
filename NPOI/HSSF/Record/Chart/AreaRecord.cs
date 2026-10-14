using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200049C RID: 1180
	public class AreaRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002BDA RID: 11226 RVA: 0x000824AE File Offset: 0x000806AE
		public AreaRecord()
		{
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000824DA File Offset: 0x000806DA
		public AreaRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_formatFlags = in1.ReadShort();
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00082514 File Offset: 0x00080714
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AREA]\n");
			stringBuilder.Append("    .formatFlags          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatFlags)).Append(" (").Append(this.FormatFlags).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .stacked                  = ").Append(this.IsStacked).Append('\n');
			stringBuilder.Append("         .DisplayAsPercentage      = ").Append(this.IsDisplayAsPercentage).Append('\n');
			stringBuilder.Append("         .shadow                   = ").Append(this.IsShadow).Append('\n');
			stringBuilder.Append("[/AREA]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000825EE File Offset: 0x000807EE
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_formatFlags);
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x000825FC File Offset: 0x000807FC
		public override short Sid
		{
			get
			{
				return 4122;
			}
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00082603 File Offset: 0x00080803
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AreaRecord
			{
				field_1_formatFlags = this.field_1_formatFlags
			};
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x00082616 File Offset: 0x00080816
		// (set) Token: 0x06002BE2 RID: 11234 RVA: 0x0008261E File Offset: 0x0008081E
		public short FormatFlags
		{
			get
			{
				return this.field_1_formatFlags;
			}
			set
			{
				this.field_1_formatFlags = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x00082627 File Offset: 0x00080827
		// (set) Token: 0x06002BE4 RID: 11236 RVA: 0x0008263A File Offset: 0x0008083A
		public bool IsStacked
		{
			get
			{
				return this.stacked.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.stacked.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x00082654 File Offset: 0x00080854
		// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x00082667 File Offset: 0x00080867
		public bool IsDisplayAsPercentage
		{
			get
			{
				return this.DisplayAsPercentage.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.DisplayAsPercentage.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x00082681 File Offset: 0x00080881
		// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x00082694 File Offset: 0x00080894
		public bool IsShadow
		{
			get
			{
				return this.shadow.IsSet((int)this.field_1_formatFlags);
			}
			set
			{
				this.field_1_formatFlags = this.shadow.SetShortBoolean(this.field_1_formatFlags, value);
			}
		}

		// Token: 0x04001316 RID: 4886
		public const short sid = 4122;

		// Token: 0x04001317 RID: 4887
		private short field_1_formatFlags;

		// Token: 0x04001318 RID: 4888
		private global::NPOI.Util.BitField stacked = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001319 RID: 4889
		private global::NPOI.Util.BitField DisplayAsPercentage = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x0400131A RID: 4890
		private global::NPOI.Util.BitField shadow = global::NPOI.Util.BitFieldFactory.GetInstance(4);
	}
}
