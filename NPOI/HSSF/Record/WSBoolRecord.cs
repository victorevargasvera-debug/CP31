using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000442 RID: 1090
	public class WSBoolRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002870 RID: 10352 RVA: 0x0005FE49 File Offset: 0x0005E049
		public WSBoolRecord()
		{
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00079B54 File Offset: 0x00077D54
		public WSBoolRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			byte[] array = in1.ReadRemainder();
			this.field_1_wsbool = array[0];
			this.field_2_wsbool = array[1];
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x00079B80 File Offset: 0x00077D80
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x00079B88 File Offset: 0x00077D88
		public byte WSBool1
		{
			get
			{
				return this.field_1_wsbool;
			}
			set
			{
				this.field_1_wsbool = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x00079B91 File Offset: 0x00077D91
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x00079BA3 File Offset: 0x00077DA3
		public bool Autobreaks
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.autobreaks.IsSet((int)this.field_1_wsbool);
			}
			set
			{
				this.field_1_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.autobreaks.SetByteBoolean(this.field_1_wsbool, value);
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x00079BBC File Offset: 0x00077DBC
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x00079BCE File Offset: 0x00077DCE
		public bool Dialog
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.dialog.IsSet((int)this.field_1_wsbool);
			}
			set
			{
				this.field_1_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.dialog.SetByteBoolean(this.field_1_wsbool, value);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00079BE7 File Offset: 0x00077DE7
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00079BF9 File Offset: 0x00077DF9
		public bool RowSumsBelow
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.rowsumsbelow.IsSet((int)this.field_1_wsbool);
			}
			set
			{
				this.field_1_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.rowsumsbelow.SetByteBoolean(this.field_1_wsbool, value);
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x00079C12 File Offset: 0x00077E12
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00079C24 File Offset: 0x00077E24
		public bool RowSumsRight
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.rowsumsright.IsSet((int)this.field_1_wsbool);
			}
			set
			{
				this.field_1_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.rowsumsright.SetByteBoolean(this.field_1_wsbool, value);
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x00079C3D File Offset: 0x00077E3D
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00079C45 File Offset: 0x00077E45
		public byte WSBool2
		{
			get
			{
				return this.field_2_wsbool;
			}
			set
			{
				this.field_2_wsbool = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x00079C4E File Offset: 0x00077E4E
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x00079C60 File Offset: 0x00077E60
		public bool FitToPage
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.fittopage.IsSet((int)this.field_2_wsbool);
			}
			set
			{
				this.field_2_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.fittopage.SetByteBoolean(this.field_2_wsbool, value);
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x00079C79 File Offset: 0x00077E79
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x00079C8B File Offset: 0x00077E8B
		public bool DisplayGuts
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.Displayguts.IsSet((int)this.field_2_wsbool);
			}
			set
			{
				this.field_2_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.Displayguts.SetByteBoolean(this.field_2_wsbool, value);
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x00079CA4 File Offset: 0x00077EA4
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x00079CB6 File Offset: 0x00077EB6
		public bool AlternateExpression
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.alternateexpression.IsSet((int)this.field_2_wsbool);
			}
			set
			{
				this.field_2_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.alternateexpression.SetByteBoolean(this.field_2_wsbool, value);
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x00079CCF File Offset: 0x00077ECF
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x00079CE1 File Offset: 0x00077EE1
		public bool AlternateFormula
		{
			get
			{
				return global::NPOI.HSSF.Record.WSBoolRecord.alternateformula.IsSet((int)this.field_2_wsbool);
			}
			set
			{
				this.field_2_wsbool = global::NPOI.HSSF.Record.WSBoolRecord.alternateformula.SetByteBoolean(this.field_2_wsbool, value);
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00079CFC File Offset: 0x00077EFC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[WSBOOL]\n");
			stringBuilder.Append("    .wsbool1        = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.WSBool1)).Append("\n");
			stringBuilder.Append("        .autobreaks = ").Append(this.Autobreaks).Append("\n");
			stringBuilder.Append("        .dialog     = ").Append(this.Dialog).Append("\n");
			stringBuilder.Append("        .rowsumsbelw= ").Append(this.RowSumsBelow).Append("\n");
			stringBuilder.Append("        .rowsumsrigt= ").Append(this.RowSumsRight).Append("\n");
			stringBuilder.Append("    .wsbool2        = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.WSBool2)).Append("\n");
			stringBuilder.Append("        .fittopage  = ").Append(this.FitToPage).Append("\n");
			stringBuilder.Append("        .Displayguts= ").Append(this.DisplayGuts).Append("\n");
			stringBuilder.Append("        .alternateex= ").Append(this.AlternateExpression).Append("\n");
			stringBuilder.Append("        .alternatefo= ").Append(this.AlternateFormula).Append("\n");
			stringBuilder.Append("[/WSBOOL]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00079E7F File Offset: 0x0007807F
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.WSBool1);
			out1.WriteByte((int)this.WSBool2);
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x00079E99 File Offset: 0x00078099
		public override short Sid
		{
			get
			{
				return 129;
			}
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x00079EA0 File Offset: 0x000780A0
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.WSBoolRecord
			{
				field_1_wsbool = this.field_1_wsbool,
				field_2_wsbool = this.field_2_wsbool
			};
		}

		// Token: 0x0400112C RID: 4396
		public const short sid = 129;

		// Token: 0x0400112D RID: 4397
		private byte field_1_wsbool;

		// Token: 0x0400112E RID: 4398
		private byte field_2_wsbool;

		// Token: 0x0400112F RID: 4399
		private static global::NPOI.Util.BitField autobreaks = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001130 RID: 4400
		private static global::NPOI.Util.BitField dialog = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001131 RID: 4401
		private static global::NPOI.Util.BitField applystyles = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04001132 RID: 4402
		private static global::NPOI.Util.BitField rowsumsbelow = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x04001133 RID: 4403
		private static global::NPOI.Util.BitField rowsumsright = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x04001134 RID: 4404
		private static global::NPOI.Util.BitField fittopage = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001135 RID: 4405
		private static global::NPOI.Util.BitField Displayguts = global::NPOI.Util.BitFieldFactory.GetInstance(6);

		// Token: 0x04001136 RID: 4406
		private static global::NPOI.Util.BitField alternateexpression = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x04001137 RID: 4407
		private static global::NPOI.Util.BitField alternateformula = global::NPOI.Util.BitFieldFactory.GetInstance(128);
	}
}
