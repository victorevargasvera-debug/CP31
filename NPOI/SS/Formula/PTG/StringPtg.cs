using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000128 RID: 296
	public class StringPtg : global::NPOI.SS.Formula.PTG.ScalarConstantPtg
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x000196D0 File Offset: 0x000178D0
		public StringPtg(global::NPOI.Util.ILittleEndianInput in1)
		{
			int nChars = in1.ReadUByte();
			this.field_2_options = (byte)in1.ReadByte();
			this._is16bitUnicode = ((this.field_2_options & 1) > 0);
			if (this._is16bitUnicode)
			{
				this.field_3_string = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, nChars);
				return;
			}
			this.field_3_string = global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, nChars);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001972B File Offset: 0x0001792B
		public StringPtg(string value)
		{
			if (value.Length > 255)
			{
				throw new global::System.ArgumentException("String literals in formulas can't be bigger than 255 Chars ASCII");
			}
			this._is16bitUnicode = global::NPOI.Util.StringUtil.HasMultibyte(value);
			this.field_3_string = value;
			this.field_1_Length = value.Length;
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0001976A File Offset: 0x0001796A
		public string Value
		{
			get
			{
				return this.field_3_string;
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00019774 File Offset: 0x00017974
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(23 + base.PtgClass));
			out1.WriteByte(this.field_3_string.Length);
			out1.WriteByte(this._is16bitUnicode ? 1 : 0);
			if (this._is16bitUnicode)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.field_3_string, out1);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.field_3_string, out1);
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000197D4 File Offset: 0x000179D4
		public override int Size
		{
			get
			{
				return this.field_3_string.Length * (this._is16bitUnicode ? 2 : 1) + 3;
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000197F0 File Offset: 0x000179F0
		public override string ToFormulaString()
		{
			string text = this.field_3_string;
			int length = text.Length;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length + 4);
			stringBuilder.Append('"');
			for (int i = 0; i < length; i++)
			{
				char c = text[i];
				if (c == '"')
				{
					stringBuilder.Append('"');
				}
				stringBuilder.Append(c);
			}
			stringBuilder.Append('"');
			return stringBuilder.ToString();
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001985C File Offset: 0x00017A5C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name).Append(" [");
			stringBuilder.Append(this.field_3_string);
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040004EC RID: 1260
		public const byte sid = 23;

		// Token: 0x040004ED RID: 1261
		private static global::NPOI.Util.BitField fHighByte = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040004EE RID: 1262
		private const char FORMULA_DELIMITER = '"';

		// Token: 0x040004EF RID: 1263
		private int field_1_Length;

		// Token: 0x040004F0 RID: 1264
		private byte field_2_options;

		// Token: 0x040004F1 RID: 1265
		private bool _is16bitUnicode;

		// Token: 0x040004F2 RID: 1266
		private string field_3_string;
	}
}
