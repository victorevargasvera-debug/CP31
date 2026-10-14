using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000424 RID: 1060
	public class StyleRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060026E3 RID: 9955 RVA: 0x00074B3B File Offset: 0x00072D3B
		public StyleRecord()
		{
			this.field_1_xf_index = global::NPOI.HSSF.Record.StyleRecord.isBuiltinFlag.Set(0);
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x00074B54 File Offset: 0x00072D54
		public bool IsBuiltin
		{
			get
			{
				return global::NPOI.HSSF.Record.StyleRecord.isBuiltinFlag.IsSet(this.field_1_xf_index);
			}
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00074B68 File Offset: 0x00072D68
		public StyleRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_xf_index = (int)in1.ReadShort();
			if (this.IsBuiltin)
			{
				this.field_2_builtin_style = in1.ReadByte();
				this.field_3_outline_style_level = in1.ReadByte();
				return;
			}
			int num = (int)in1.ReadShort();
			if (in1.Remaining < 1)
			{
				if (num != 0)
				{
					throw new global::NPOI.Util.RecordFormatException("Ran out of data reading style record");
				}
				this.field_4_name = "";
				return;
			}
			else
			{
				this.field_3_stringHasMultibyte = (in1.ReadByte() != 0);
				if (this.field_3_stringHasMultibyte)
				{
					this.field_4_name = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, num);
					return;
				}
				this.field_4_name = global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, num);
				return;
			}
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00074C04 File Offset: 0x00072E04
		public void SetBuiltinStyle(int builtinStyleId)
		{
			this.field_1_xf_index = global::NPOI.HSSF.Record.StyleRecord.isBuiltinFlag.Set(this.field_1_xf_index);
			this.field_2_builtin_style = builtinStyleId;
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x00074C23 File Offset: 0x00072E23
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x00074C32 File Offset: 0x00072E32
		public short XFIndex
		{
			get
			{
				return (short)(this.field_1_xf_index & 8191);
			}
			set
			{
				this.field_1_xf_index = (int)this.SetField(this.field_1_xf_index, (int)value, 8191, 0);
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x00074C4D File Offset: 0x00072E4D
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x00074C55 File Offset: 0x00072E55
		public string Name
		{
			get
			{
				return this.field_4_name;
			}
			set
			{
				this.field_4_name = value;
				this.field_3_stringHasMultibyte = global::NPOI.Util.StringUtil.HasMultibyte(value);
				this.field_1_xf_index = global::NPOI.HSSF.Record.StyleRecord.isBuiltinFlag.Clear(this.field_1_xf_index);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x00074C80 File Offset: 0x00072E80
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x00074C88 File Offset: 0x00072E88
		public int OutlineStyleLevel
		{
			get
			{
				return this.field_3_outline_style_level;
			}
			set
			{
				this.field_3_outline_style_level = (value & 255);
			}
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00074C98 File Offset: 0x00072E98
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[STYLE]\n");
			stringBuilder.Append("    .xf_index_raw    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_1_xf_index)).Append("\n");
			stringBuilder.Append("        .type        = ").Append(this.IsBuiltin ? "built-in" : "user-defined").Append("\n");
			stringBuilder.Append("        .xf_index    = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.XFIndex)).Append("\n");
			if (this.IsBuiltin)
			{
				stringBuilder.Append("    .builtin_style   = ").Append(global::NPOI.Util.HexDump.ByteToHex(this.field_2_builtin_style)).Append("\n");
				stringBuilder.Append("    .outline_level   = ").Append(global::NPOI.Util.HexDump.ByteToHex(this.field_3_outline_style_level)).Append("\n");
			}
			else
			{
				stringBuilder.Append("    .name            = ").Append(this.Name).Append("\n");
			}
			stringBuilder.Append("[/STYLE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00074DBB File Offset: 0x00072FBB
		private short SetField(int fieldValue, int new_value, int mask, int ShiftLeft)
		{
			return (short)((fieldValue & ~mask) | (new_value << ShiftLeft & mask));
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00074DCC File Offset: 0x00072FCC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput o)
		{
			o.WriteShort(this.field_1_xf_index);
			if (this.IsBuiltin)
			{
				o.WriteByte(this.field_2_builtin_style);
				o.WriteByte(this.field_3_outline_style_level);
				return;
			}
			o.WriteShort(this.field_4_name.Length);
			o.WriteByte(this.field_3_stringHasMultibyte ? 1 : 0);
			if (this.field_3_stringHasMultibyte)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.Name, o);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.Name, o);
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x00074E4A File Offset: 0x0007304A
		protected override int DataSize
		{
			get
			{
				if (this.IsBuiltin)
				{
					return 4;
				}
				return 5 + this.field_4_name.Length * (this.field_3_stringHasMultibyte ? 2 : 1);
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00074E70 File Offset: 0x00073070
		public override short Sid
		{
			get
			{
				return 659;
			}
		}

		// Token: 0x04001042 RID: 4162
		public const short sid = 659;

		// Token: 0x04001043 RID: 4163
		private static global::NPOI.Util.BitField styleIndexMask = global::NPOI.Util.BitFieldFactory.GetInstance(4095);

		// Token: 0x04001044 RID: 4164
		private static global::NPOI.Util.BitField isBuiltinFlag = global::NPOI.Util.BitFieldFactory.GetInstance(32768);

		// Token: 0x04001045 RID: 4165
		private int field_1_xf_index;

		// Token: 0x04001046 RID: 4166
		private int field_2_builtin_style;

		// Token: 0x04001047 RID: 4167
		private int field_3_outline_style_level;

		// Token: 0x04001048 RID: 4168
		private bool field_3_stringHasMultibyte;

		// Token: 0x04001049 RID: 4169
		private string field_4_name;
	}
}
