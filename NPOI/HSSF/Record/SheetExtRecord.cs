using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A5 RID: 933
	public class SheetExtRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002031 RID: 8241 RVA: 0x00062FA0 File Offset: 0x000611A0
		public SheetExtRecord()
		{
			this.rt = 2146;
			this.IsAutoColor = true;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0006300C File Offset: 0x0006120C
		public SheetExtRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			if (this.rt != 2146)
			{
				throw new global::System.ArgumentException("frtHeader.rt must be equals 0x0862 in SheetExt record");
			}
			this.grbitFrt = in1.ReadShort();
			in1.ReadInt();
			in1.ReadInt();
			this.cb = in1.ReadInt();
			this.optionflag = in1.ReadShort();
			in1.ReadShort();
			if (this.cb == 40)
			{
				this.optionflag2 = in1.ReadShort();
				this.xclrType = in1.ReadInt();
				this.xclrValue = in1.ReadInt();
				this.numTint = in1.ReadLong();
				in1.ReadShort();
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x00063102 File Offset: 0x00061302
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x00063115 File Offset: 0x00061315
		public short TabColorIndex
		{
			get
			{
				return this.icvPlain.GetShortValue(this.optionflag);
			}
			set
			{
				this.optionflag = this.icvPlain.SetShortValue(this.optionflag, value);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0006312F File Offset: 0x0006132F
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0006313B File Offset: 0x0006133B
		public bool IsAutoColor
		{
			get
			{
				return this.TabColorIndex == 127;
			}
			set
			{
				if (value)
				{
					this.TabColorIndex = 127;
					return;
				}
				this.TabColorIndex = 8;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00063150 File Offset: 0x00061350
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x00063163 File Offset: 0x00061363
		public bool EvaluateConditionalFormatting
		{
			get
			{
				return this.fCondFmtCalc.IsSet((int)this.optionflag2);
			}
			set
			{
				this.optionflag2 = (short)this.fCondFmtCalc.SetBoolean((int)this.optionflag2, value);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0006317E File Offset: 0x0006137E
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00063194 File Offset: 0x00061394
		public bool IsSheetPublished
		{
			get
			{
				return !this.fNotPublished.IsSet((int)this.optionflag2);
			}
			set
			{
				this.optionflag2 = (short)this.fNotPublished.SetBoolean((int)this.optionflag2, !value);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x000631B2 File Offset: 0x000613B2
		protected override int DataSize
		{
			get
			{
				return 20 + ((this.cb == 40) ? 20 : 0);
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x000631C6 File Offset: 0x000613C6
		public override short Sid
		{
			get
			{
				return 2146;
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000631D0 File Offset: 0x000613D0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteInt(0);
			out1.WriteInt(0);
			this.cb = this.DataSize;
			out1.WriteInt(this.cb);
			out1.WriteShort((int)this.optionflag);
			out1.WriteShort(0);
			if (this.cb == 40)
			{
				out1.WriteShort((int)this.optionflag2);
				out1.WriteInt(this.xclrType);
				out1.WriteInt(this.xclrValue);
				out1.WriteLong(this.numTint);
				out1.WriteShort(0);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0006326F File Offset: 0x0006146F
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SHEETEXT]");
			stringBuilder.Append("[/SHEETEXT]");
			return stringBuilder.ToString();
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00063294 File Offset: 0x00061494
		public override object Clone()
		{
			global::NPOI.HSSF.Record.SheetExtRecord sheetExtRecord = new global::NPOI.HSSF.Record.SheetExtRecord();
			sheetExtRecord.rt = this.rt;
			sheetExtRecord.grbitFrt = this.grbitFrt;
			sheetExtRecord.cb = this.DataSize;
			sheetExtRecord.optionflag = this.optionflag;
			if (this.cb == 40)
			{
				sheetExtRecord.optionflag2 = this.optionflag2;
				sheetExtRecord.xclrType = this.xclrType;
				sheetExtRecord.xclrValue = this.xclrValue;
				sheetExtRecord.numTint = this.numTint;
			}
			return sheetExtRecord;
		}

		// Token: 0x04000C87 RID: 3207
		private short rt;

		// Token: 0x04000C88 RID: 3208
		private short grbitFrt;

		// Token: 0x04000C89 RID: 3209
		private int cb;

		// Token: 0x04000C8A RID: 3210
		private global::NPOI.Util.BitField icvPlain = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04000C8B RID: 3211
		private short optionflag = 255;

		// Token: 0x04000C8C RID: 3212
		private short optionflag2;

		// Token: 0x04000C8D RID: 3213
		private global::NPOI.Util.BitField icvPlain12 = global::NPOI.Util.BitFieldFactory.GetInstance(127);

		// Token: 0x04000C8E RID: 3214
		private global::NPOI.Util.BitField fCondFmtCalc = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x04000C8F RID: 3215
		private global::NPOI.Util.BitField fNotPublished = global::NPOI.Util.BitFieldFactory.GetInstance(256);

		// Token: 0x04000C90 RID: 3216
		private int xclrType;

		// Token: 0x04000C91 RID: 3217
		private int xclrValue;

		// Token: 0x04000C92 RID: 3218
		private long numTint;

		// Token: 0x04000C93 RID: 3219
		public const short sid = 2146;
	}
}
