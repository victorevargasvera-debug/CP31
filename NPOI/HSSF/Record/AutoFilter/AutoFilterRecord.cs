using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.AutoFilter
{
	// Token: 0x02000455 RID: 1109
	public class AutoFilterRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002902 RID: 10498 RVA: 0x0007BD9C File Offset: 0x00079F9C
		public AutoFilterRecord()
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0007BDBC File Offset: 0x00079FBC
		public AutoFilterRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_iEntry = in1.ReadShort();
			this.field_2_grbit = in1.ReadShort();
			this.field_3_doper1 = new global::NPOI.HSSF.Record.AutoFilter.DOPERRecord(in1);
			this.field_4_doper2 = new global::NPOI.HSSF.Record.AutoFilter.DOPERRecord(in1);
			if (this.field_3_doper1.DataType == global::NPOI.HSSF.Record.AutoFilter.DOPERType.String && this.field_3_doper1.LengthOfString > 0)
			{
				this.rgch1_multibyte = (in1.ReadByte() != 0);
				if (this.rgch1_multibyte)
				{
					this.field_5_rgch1 = in1.ReadUnicodeLEString((int)this.field_3_doper1.LengthOfString);
				}
				else
				{
					this.field_5_rgch1 = in1.ReadCompressedUnicode((int)this.field_3_doper1.LengthOfString);
				}
			}
			if (this.field_4_doper2.DataType == global::NPOI.HSSF.Record.AutoFilter.DOPERType.String && this.field_4_doper2.LengthOfString > 0)
			{
				this.rgch2_multibyte = (in1.ReadByte() != 0);
				if (this.rgch2_multibyte)
				{
					this.field_6_rgch2 = in1.ReadUnicodeLEString((int)this.field_4_doper2.LengthOfString);
					return;
				}
				this.field_6_rgch2 = in1.ReadCompressedUnicode((int)this.field_4_doper2.LengthOfString);
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x0007BEDA File Offset: 0x0007A0DA
		public override short Sid
		{
			get
			{
				return 158;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x0007BEE1 File Offset: 0x0007A0E1
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x0007BEE9 File Offset: 0x0007A0E9
		public short iEntry
		{
			get
			{
				return this.field_1_iEntry;
			}
			set
			{
				this.field_1_iEntry = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x0007BEF2 File Offset: 0x0007A0F2
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x0007BF04 File Offset: 0x0007A104
		public short wJoin
		{
			get
			{
				return global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord.wJoinFlag.GetShortValue(this.field_2_grbit);
			}
			set
			{
				this.field_2_grbit = global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord.wJoinFlag.SetShortValue(this.field_2_grbit, value);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x0007BF1D File Offset: 0x0007A11D
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x0007BF2F File Offset: 0x0007A12F
		public bool IsFirstConditionSimple
		{
			get
			{
				return global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord.fSimple1Flag.IsSet((int)this.field_2_grbit);
			}
			set
			{
				this.field_2_grbit = global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord.fSimple1Flag.SetShortBoolean(this.field_2_grbit, value);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x0007BF48 File Offset: 0x0007A148
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x0007BF5A File Offset: 0x0007A15A
		public bool IsSecondConditionSimple
		{
			get
			{
				return global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord.fSimple2Flag.IsSet((int)this.field_2_grbit);
			}
			set
			{
				this.field_2_grbit = global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord.fSimple2Flag.SetShortBoolean(this.field_2_grbit, value);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x0007BF73 File Offset: 0x0007A173
		public global::NPOI.HSSF.Record.AutoFilter.DOPERRecord Doper1
		{
			get
			{
				return this.field_3_doper1;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x0007BF7B File Offset: 0x0007A17B
		public global::NPOI.HSSF.Record.AutoFilter.DOPERRecord Doper2
		{
			get
			{
				return this.field_4_doper2;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x0007BF83 File Offset: 0x0007A183
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x0007BF8C File Offset: 0x0007A18C
		public string Doper1RGCH
		{
			get
			{
				return this.field_5_rgch1;
			}
			set
			{
				if (this.field_5_rgch1.Length > 252)
				{
					throw new global::System.ArgumentOutOfRangeException("The length of string must be less than or equal to 252");
				}
				this.field_5_rgch1 = value;
				this.field_3_doper1.DataType = global::NPOI.HSSF.Record.AutoFilter.DOPERType.String;
				this.field_3_doper1.LengthOfString = (byte)this.field_5_rgch1.Length;
				this.rgch1_multibyte = global::NPOI.Util.StringUtil.HasMultibyte(value);
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x0007BFEC File Offset: 0x0007A1EC
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x0007BFF4 File Offset: 0x0007A1F4
		public string Doper2RGCH
		{
			get
			{
				return this.field_6_rgch2;
			}
			set
			{
				if (this.field_6_rgch2.Length > 252)
				{
					throw new global::System.ArgumentOutOfRangeException("The length of string must be less than or equal to 252");
				}
				this.field_6_rgch2 = value;
				this.field_4_doper2.DataType = global::NPOI.HSSF.Record.AutoFilter.DOPERType.String;
				this.field_4_doper2.LengthOfString = (byte)this.field_6_rgch2.Length;
				this.rgch2_multibyte = global::NPOI.Util.StringUtil.HasMultibyte(value);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x0007C054 File Offset: 0x0007A254
		protected override int DataSize
		{
			get
			{
				int num = 24;
				if (this.field_3_doper1.LengthOfString > 0)
				{
					num += 1 + this.field_5_rgch1.Length;
				}
				if (this.field_4_doper2.LengthOfString > 0)
				{
					num += 1 + this.field_6_rgch2.Length;
				}
				return num;
			}
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0007C0A1 File Offset: 0x0007A2A1
		public override int Serialize(int offset, byte[] data)
		{
			return base.Serialize(offset, data);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x0007C0AC File Offset: 0x0007A2AC
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.AutoFilter.AutoFilterRecord
			{
				field_1_iEntry = this.field_1_iEntry,
				field_2_grbit = this.field_2_grbit,
				field_3_doper1 = this.field_3_doper1,
				field_4_doper2 = this.field_4_doper2,
				field_5_rgch1 = this.field_5_rgch1,
				field_6_rgch2 = this.field_6_rgch2
			};
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0007C108 File Offset: 0x0007A308
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_iEntry);
			out1.WriteShort((int)this.field_2_grbit);
			this.field_3_doper1.Serialize(out1);
			this.field_4_doper2.Serialize(out1);
			if (this.field_3_doper1.LengthOfString > 0)
			{
				out1.WriteByte(this.rgch1_multibyte ? 1 : 0);
				if (this.rgch1_multibyte)
				{
					global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_5_rgch1, out1);
				}
				else
				{
					global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_5_rgch1, out1);
				}
			}
			if (this.field_4_doper2.LengthOfString > 0)
			{
				out1.WriteByte(this.rgch2_multibyte ? 1 : 0);
				if (this.rgch2_multibyte)
				{
					global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_6_rgch2, out1);
					return;
				}
				global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_6_rgch2, out1);
			}
		}

		// Token: 0x04001199 RID: 4505
		public const short sid = 158;

		// Token: 0x0400119A RID: 4506
		private short field_1_iEntry;

		// Token: 0x0400119B RID: 4507
		private short field_2_grbit;

		// Token: 0x0400119C RID: 4508
		private static readonly global::NPOI.Util.BitField wJoinFlag = global::NPOI.Util.BitFieldFactory.GetInstance(3);

		// Token: 0x0400119D RID: 4509
		private static readonly global::NPOI.Util.BitField fSimple1Flag = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x0400119E RID: 4510
		private static readonly global::NPOI.Util.BitField fSimple2Flag = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x0400119F RID: 4511
		private static readonly global::NPOI.Util.BitField fTop10Flag = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040011A0 RID: 4512
		private static readonly global::NPOI.Util.BitField fTopFlag = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x040011A1 RID: 4513
		private static readonly global::NPOI.Util.BitField fPercentFlag = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x040011A2 RID: 4514
		private static readonly global::NPOI.Util.BitField wTop10Flag = global::NPOI.Util.BitFieldFactory.GetInstance(65408);

		// Token: 0x040011A3 RID: 4515
		private global::NPOI.HSSF.Record.AutoFilter.DOPERRecord field_3_doper1;

		// Token: 0x040011A4 RID: 4516
		private global::NPOI.HSSF.Record.AutoFilter.DOPERRecord field_4_doper2;

		// Token: 0x040011A5 RID: 4517
		private string field_5_rgch1 = string.Empty;

		// Token: 0x040011A6 RID: 4518
		private string field_6_rgch2 = string.Empty;

		// Token: 0x040011A7 RID: 4519
		private bool rgch1_multibyte;

		// Token: 0x040011A8 RID: 4520
		private bool rgch2_multibyte;
	}
}
