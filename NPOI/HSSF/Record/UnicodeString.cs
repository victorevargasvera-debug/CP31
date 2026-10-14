using System;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Record.Cont;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A1 RID: 929
	public class UnicodeString : global::System.IComparable<global::NPOI.HSSF.Record.UnicodeString>
	{
		// Token: 0x06001FF6 RID: 8182 RVA: 0x0000253E File Offset: 0x0000073E
		private UnicodeString()
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000621EC File Offset: 0x000603EC
		public UnicodeString(string str)
		{
			this.String = str;
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000621FC File Offset: 0x000603FC
		public override int GetHashCode()
		{
			int num = 0;
			if (this.field_3_string != null)
			{
				num = this.field_3_string.GetHashCode();
			}
			return (int)this.field_1_charCount + num;
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00062228 File Offset: 0x00060428
		public override bool Equals(object o)
		{
			if (!(o is global::NPOI.HSSF.Record.UnicodeString))
			{
				return false;
			}
			global::NPOI.HSSF.Record.UnicodeString unicodeString = (global::NPOI.HSSF.Record.UnicodeString)o;
			if (this.field_1_charCount != unicodeString.field_1_charCount || this.field_2_optionflags != unicodeString.field_2_optionflags || !this.field_3_string.Equals(unicodeString.field_3_string))
			{
				return false;
			}
			if (this.field_4_format_runs == null)
			{
				return unicodeString.field_4_format_runs == null;
			}
			if (unicodeString.field_4_format_runs == null)
			{
				return false;
			}
			int count = this.field_4_format_runs.Count;
			if (count != unicodeString.field_4_format_runs.Count)
			{
				return false;
			}
			for (int i = 0; i < count; i++)
			{
				object obj = this.field_4_format_runs[i];
				global::NPOI.HSSF.Record.UnicodeString.FormatRun obj2 = unicodeString.field_4_format_runs[i];
				if (!obj.Equals(obj2))
				{
					return false;
				}
			}
			if (this.field_5_ext_rst == null)
			{
				return unicodeString.field_5_ext_rst == null;
			}
			return unicodeString.field_5_ext_rst != null && this.field_5_ext_rst.Equals(unicodeString.field_5_ext_rst);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0006230C File Offset: 0x0006050C
		public UnicodeString(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_charCount = in1.ReadShort();
			this.field_2_optionflags = (byte)in1.ReadByte();
			int num = 0;
			int num2 = 0;
			if (this.IsRichText)
			{
				num = (int)in1.ReadShort();
			}
			if (this.IsExtendedText)
			{
				num2 = in1.ReadInt();
			}
			bool flag = (this.field_2_optionflags & 1) == 0;
			int charCount = this.CharCount;
			this.field_3_string = (flag ? in1.ReadCompressedUnicode(charCount) : in1.ReadUnicodeLEString(charCount));
			if (this.IsRichText && num > 0)
			{
				this.field_4_format_runs = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.UnicodeString.FormatRun>(num);
				for (int i = 0; i < num; i++)
				{
					this.field_4_format_runs.Add(new global::NPOI.HSSF.Record.UnicodeString.FormatRun(in1));
				}
			}
			if (this.IsExtendedText && num2 > 0)
			{
				this.field_5_ext_rst = new global::NPOI.HSSF.Record.UnicodeString.ExtRst(new global::NPOI.HSSF.Record.Cont.ContinuableRecordInput(in1), num2);
				if (this.field_5_ext_rst.DataSize + 4 != num2)
				{
					global::NPOI.HSSF.Record.UnicodeString._logger.Log(5, "ExtRst was supposed to be " + num2.ToString() + " bytes long, but seems to actually be " + (this.field_5_ext_rst.DataSize + 4).ToString());
				}
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00062424 File Offset: 0x00060624
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x00062442 File Offset: 0x00060642
		public int CharCount
		{
			get
			{
				if (this.field_1_charCount < 0)
				{
					return (int)this.field_1_charCount + 65536;
				}
				return (int)this.field_1_charCount;
			}
			set
			{
				this.field_1_charCount = (short)value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0006244C File Offset: 0x0006064C
		public short CharCountShort
		{
			get
			{
				return this.field_1_charCount;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00062454 File Offset: 0x00060654
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0006245C File Offset: 0x0006065C
		public byte OptionFlags
		{
			get
			{
				return this.field_2_optionflags;
			}
			set
			{
				this.field_2_optionflags = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00062465 File Offset: 0x00060665
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00062470 File Offset: 0x00060670
		public string String
		{
			get
			{
				return this.field_3_string;
			}
			set
			{
				this.field_3_string = value;
				this.CharCount = (int)((short)this.field_3_string.Length);
				bool flag = false;
				int length = value.Length;
				for (int i = 0; i < length; i++)
				{
					if (value[i] > 'ÿ')
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.highByte.SetByte(this.field_2_optionflags);
					return;
				}
				this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.highByte.ClearByte(this.field_2_optionflags);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x000624ED File Offset: 0x000606ED
		public int FormatRunCount
		{
			get
			{
				if (this.field_4_format_runs != null)
				{
					return this.field_4_format_runs.Count;
				}
				return 0;
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00062504 File Offset: 0x00060704
		public global::NPOI.HSSF.Record.UnicodeString.FormatRun GetFormatRun(int index)
		{
			if (this.field_4_format_runs == null)
			{
				return null;
			}
			if (index < 0 || index >= this.field_4_format_runs.Count)
			{
				return null;
			}
			return this.field_4_format_runs[index];
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00062530 File Offset: 0x00060730
		private int FindFormatRunAt(int characterPos)
		{
			int count = this.field_4_format_runs.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun = this.field_4_format_runs[i];
				if ((int)formatRun._character == characterPos)
				{
					return i;
				}
				if ((int)formatRun._character > characterPos)
				{
					return -1;
				}
			}
			return -1;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0006257C File Offset: 0x0006077C
		public void AddFormatRun(global::NPOI.HSSF.Record.UnicodeString.FormatRun r)
		{
			if (this.field_4_format_runs == null)
			{
				this.field_4_format_runs = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.UnicodeString.FormatRun>();
			}
			int num = this.FindFormatRunAt((int)r._character);
			if (num != -1)
			{
				this.field_4_format_runs.RemoveAt(num);
			}
			this.field_4_format_runs.Add(r);
			this.field_4_format_runs.Sort();
			this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.richText.SetByte(this.field_2_optionflags);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000625E6 File Offset: 0x000607E6
		public global::System.Collections.Generic.List<global::NPOI.HSSF.Record.UnicodeString.FormatRun> FormatIterator()
		{
			if (this.field_4_format_runs != null)
			{
				return this.field_4_format_runs;
			}
			return null;
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000625F8 File Offset: 0x000607F8
		public void RemoveFormatRun(global::NPOI.HSSF.Record.UnicodeString.FormatRun r)
		{
			this.field_4_format_runs.Remove(r);
			if (this.field_4_format_runs.Count == 0)
			{
				this.field_4_format_runs = null;
				this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.richText.ClearByte(this.field_2_optionflags);
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00062631 File Offset: 0x00060831
		public void ClearFormatting()
		{
			this.field_4_format_runs = null;
			this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.richText.ClearByte(this.field_2_optionflags);
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x00062650 File Offset: 0x00060850
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x00062658 File Offset: 0x00060858
		public global::NPOI.HSSF.Record.UnicodeString.ExtRst ExtendedRst
		{
			get
			{
				return this.field_5_ext_rst;
			}
			set
			{
				if (value != null)
				{
					this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.extBit.SetByte(this.field_2_optionflags);
				}
				else
				{
					this.field_2_optionflags = global::NPOI.HSSF.Record.UnicodeString.extBit.ClearByte(this.field_2_optionflags);
				}
				this.field_5_ext_rst = value;
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00062694 File Offset: 0x00060894
		public void SwapFontUse(short oldFontIndex, short newFontIndex)
		{
			foreach (global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun in this.field_4_format_runs)
			{
				if (formatRun._fontIndex == oldFontIndex)
				{
					formatRun._fontIndex = newFontIndex;
				}
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000626F0 File Offset: 0x000608F0
		public override string ToString()
		{
			return this.String;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000626F8 File Offset: 0x000608F8
		public string GetDebugInfo()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[UNICODESTRING]\n");
			stringBuilder.Append("    .charcount       = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.CharCount)).Append("\n");
			stringBuilder.Append("    .optionflags     = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.OptionFlags)).Append("\n");
			stringBuilder.Append("    .string          = ").Append(this.String).Append("\n");
			if (this.field_4_format_runs != null)
			{
				for (int i = 0; i < this.field_4_format_runs.Count; i++)
				{
					global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun = this.field_4_format_runs[i];
					stringBuilder.Append("      .format_Run" + i.ToString() + "          = ").Append(formatRun.ToString()).Append("\n");
				}
			}
			if (this.field_5_ext_rst != null)
			{
				stringBuilder.Append("    .field_5_ext_rst          = ").Append("\n");
				stringBuilder.Append(this.field_5_ext_rst.ToString()).Append("\n");
			}
			stringBuilder.Append("[/UNICODESTRING]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00062830 File Offset: 0x00060A30
		public void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			int num = 0;
			int num2 = 0;
			if (this.IsRichText && this.field_4_format_runs != null)
			{
				num = this.field_4_format_runs.Count;
			}
			if (this.IsExtendedText && this.field_5_ext_rst != null)
			{
				num2 = 4 + this.field_5_ext_rst.DataSize;
			}
			out1.WriteString(this.field_3_string, num, num2);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					if (out1.AvailableSpace < 4)
					{
						out1.WriteContinue();
					}
					this.field_4_format_runs[i].Serialize(out1);
				}
			}
			if (num2 > 0)
			{
				this.field_5_ext_rst.Serialize(out1);
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000628CC File Offset: 0x00060ACC
		public int CompareTo(global::NPOI.HSSF.Record.UnicodeString str)
		{
			int num = string.Compare(this.String, str.String, global::System.StringComparison.CurrentCulture);
			if (num != 0)
			{
				return num;
			}
			if (this.field_4_format_runs == null)
			{
				if (str.field_4_format_runs != null)
				{
					return 1;
				}
				return 0;
			}
			else
			{
				if (str.field_4_format_runs == null)
				{
					return -1;
				}
				int count = this.field_4_format_runs.Count;
				if (count != str.field_4_format_runs.Count)
				{
					return count - str.field_4_format_runs.Count;
				}
				for (int i = 0; i < count; i++)
				{
					global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun = this.field_4_format_runs[i];
					global::NPOI.HSSF.Record.UnicodeString.FormatRun r = str.field_4_format_runs[i];
					num = formatRun.CompareTo(r);
					if (num != 0)
					{
						return num;
					}
				}
				if (this.field_5_ext_rst == null)
				{
					if (str.field_5_ext_rst != null)
					{
						return 1;
					}
					return 0;
				}
				else
				{
					if (str.field_5_ext_rst == null)
					{
						return -1;
					}
					return this.field_5_ext_rst.CompareTo(str.field_5_ext_rst);
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00062997 File Offset: 0x00060B97
		private bool IsRichText
		{
			get
			{
				return global::NPOI.HSSF.Record.UnicodeString.richText.IsSet((int)this.OptionFlags);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x000629A9 File Offset: 0x00060BA9
		private bool IsExtendedText
		{
			get
			{
				return global::NPOI.HSSF.Record.UnicodeString.extBit.IsSet((int)this.OptionFlags);
			}
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000629BC File Offset: 0x00060BBC
		public object Clone()
		{
			global::NPOI.HSSF.Record.UnicodeString unicodeString = new global::NPOI.HSSF.Record.UnicodeString();
			unicodeString.field_1_charCount = this.field_1_charCount;
			unicodeString.field_2_optionflags = this.field_2_optionflags;
			unicodeString.field_3_string = this.field_3_string;
			if (this.field_4_format_runs != null)
			{
				unicodeString.field_4_format_runs = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.UnicodeString.FormatRun>();
				foreach (global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun in this.field_4_format_runs)
				{
					unicodeString.field_4_format_runs.Add(new global::NPOI.HSSF.Record.UnicodeString.FormatRun(formatRun._character, formatRun._fontIndex));
				}
			}
			if (this.field_5_ext_rst != null)
			{
				unicodeString.field_5_ext_rst = this.field_5_ext_rst.Clone();
			}
			return unicodeString;
		}

		// Token: 0x04000C65 RID: 3173
		private static global::NPOI.Util.POILogger _logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.UnicodeString));

		// Token: 0x04000C66 RID: 3174
		private short field_1_charCount;

		// Token: 0x04000C67 RID: 3175
		private byte field_2_optionflags;

		// Token: 0x04000C68 RID: 3176
		private string field_3_string;

		// Token: 0x04000C69 RID: 3177
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.UnicodeString.FormatRun> field_4_format_runs;

		// Token: 0x04000C6A RID: 3178
		private global::NPOI.HSSF.Record.UnicodeString.ExtRst field_5_ext_rst;

		// Token: 0x04000C6B RID: 3179
		private static global::NPOI.Util.BitField highByte = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000C6C RID: 3180
		private static global::NPOI.Util.BitField extBit = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04000C6D RID: 3181
		private static global::NPOI.Util.BitField richText = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x02000608 RID: 1544
		public class FormatRun : global::System.IComparable<global::NPOI.HSSF.Record.UnicodeString.FormatRun>
		{
			// Token: 0x0600364C RID: 13900 RVA: 0x000A5ED2 File Offset: 0x000A40D2
			public FormatRun(short character, short fontIndex)
			{
				this._character = character;
				this._fontIndex = fontIndex;
			}

			// Token: 0x0600364D RID: 13901 RVA: 0x000A5EE8 File Offset: 0x000A40E8
			public FormatRun(global::NPOI.Util.ILittleEndianInput in1) : this(in1.ReadShort(), in1.ReadShort())
			{
			}

			// Token: 0x17000E14 RID: 3604
			// (get) Token: 0x0600364E RID: 13902 RVA: 0x000A5EFC File Offset: 0x000A40FC
			public short CharacterPos
			{
				get
				{
					return this._character;
				}
			}

			// Token: 0x17000E15 RID: 3605
			// (get) Token: 0x0600364F RID: 13903 RVA: 0x000A5F04 File Offset: 0x000A4104
			public short FontIndex
			{
				get
				{
					return this._fontIndex;
				}
			}

			// Token: 0x06003650 RID: 13904 RVA: 0x000A5F0C File Offset: 0x000A410C
			public override bool Equals(object o)
			{
				if (!(o is global::NPOI.HSSF.Record.UnicodeString.FormatRun))
				{
					return false;
				}
				global::NPOI.HSSF.Record.UnicodeString.FormatRun formatRun = (global::NPOI.HSSF.Record.UnicodeString.FormatRun)o;
				return this._character == formatRun._character && this._fontIndex == formatRun._fontIndex;
			}

			// Token: 0x06003651 RID: 13905 RVA: 0x000A342D File Offset: 0x000A162D
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06003652 RID: 13906 RVA: 0x000A5F48 File Offset: 0x000A4148
			public int CompareTo(global::NPOI.HSSF.Record.UnicodeString.FormatRun r)
			{
				if (this._character == r._character && this._fontIndex == r._fontIndex)
				{
					return 0;
				}
				if (this._character == r._character)
				{
					return (int)(this._fontIndex - r._fontIndex);
				}
				return (int)(this._character - r._character);
			}

			// Token: 0x06003653 RID: 13907 RVA: 0x000A5F9C File Offset: 0x000A419C
			public override string ToString()
			{
				return "character=" + this._character.ToString() + ",fontIndex=" + this._fontIndex.ToString();
			}

			// Token: 0x06003654 RID: 13908 RVA: 0x000A5FC3 File Offset: 0x000A41C3
			public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort((int)this._character);
				out1.WriteShort((int)this._fontIndex);
			}

			// Token: 0x04001A5A RID: 6746
			internal short _character;

			// Token: 0x04001A5B RID: 6747
			internal short _fontIndex;
		}

		// Token: 0x02000609 RID: 1545
		public class ExtRst : global::System.IComparable<global::NPOI.HSSF.Record.UnicodeString.ExtRst>
		{
			// Token: 0x06003655 RID: 13909 RVA: 0x000A5FDD File Offset: 0x000A41DD
			private void populateEmpty()
			{
				this.reserved = 1;
				this.phoneticText = "";
				this.phRuns = new global::NPOI.HSSF.Record.UnicodeString.PhRun[0];
				this.extraData = new byte[0];
			}

			// Token: 0x06003656 RID: 13910 RVA: 0x000A600C File Offset: 0x000A420C
			public override int GetHashCode()
			{
				int num = (int)this.reserved;
				num = 31 * num + (int)this.formattingFontIndex;
				num = 31 * num + (int)this.formattingOptions;
				num = 31 * num + this.numberOfRuns;
				num = 31 * num + this.phoneticText.GetHashCode();
				if (this.phRuns != null)
				{
					foreach (global::NPOI.HSSF.Record.UnicodeString.PhRun phRun in this.phRuns)
					{
						num = 31 * num + phRun.phoneticTextFirstCharacterOffset;
						num = 31 * num + phRun.realTextFirstCharacterOffset;
						num = 31 * num + phRun.realTextLength;
					}
				}
				return num;
			}

			// Token: 0x06003657 RID: 13911 RVA: 0x000A609B File Offset: 0x000A429B
			internal ExtRst()
			{
				this.populateEmpty();
			}

			// Token: 0x06003658 RID: 13912 RVA: 0x000A60AC File Offset: 0x000A42AC
			internal ExtRst(global::NPOI.Util.ILittleEndianInput in1, int expectedLength)
			{
				this.reserved = in1.ReadShort();
				if (this.reserved == -1)
				{
					this.populateEmpty();
					return;
				}
				if (this.reserved != 1)
				{
					global::NPOI.HSSF.Record.UnicodeString._logger.Log(5, "Warning - ExtRst has wrong magic marker, expecting 1 but found " + this.reserved.ToString() + " - ignoring");
					for (int i = 0; i < expectedLength - 2; i++)
					{
						in1.ReadByte();
					}
					this.populateEmpty();
					return;
				}
				int num = (int)in1.ReadShort();
				this.formattingFontIndex = in1.ReadShort();
				this.formattingOptions = in1.ReadShort();
				this.numberOfRuns = in1.ReadUShort();
				short num2 = in1.ReadShort();
				short num3 = in1.ReadShort();
				if (num2 == 0 && num3 > 0)
				{
					num3 = 0;
				}
				if (num2 != num3)
				{
					throw new global::System.InvalidOperationException("The two length fields of the Phonetic Text don't agree! " + num2.ToString() + " vs " + num3.ToString());
				}
				this.phoneticText = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, (int)num2);
				int num4 = num - 4 - 6 - 2 * this.phoneticText.Length;
				int num5 = num4 / 6;
				this.phRuns = new global::NPOI.HSSF.Record.UnicodeString.PhRun[num5];
				for (int j = 0; j < this.phRuns.Length; j++)
				{
					this.phRuns[j] = new global::NPOI.HSSF.Record.UnicodeString.PhRun(in1);
				}
				int num6 = num4 - num5 * 6;
				if (num6 < 0)
				{
					num6 = 0;
				}
				this.extraData = new byte[num6];
				for (int k = 0; k < this.extraData.Length; k++)
				{
					this.extraData[k] = (byte)in1.ReadByte();
				}
			}

			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x06003659 RID: 13913 RVA: 0x000A622A File Offset: 0x000A442A
			internal int DataSize
			{
				get
				{
					return 10 + 2 * this.phoneticText.Length + 6 * this.phRuns.Length + this.extraData.Length;
				}
			}

			// Token: 0x0600365A RID: 13914 RVA: 0x000A6250 File Offset: 0x000A4450
			internal void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
			{
				int dataSize = this.DataSize;
				out1.WriteContinueIfRequired(8);
				out1.WriteShort((int)this.reserved);
				out1.WriteShort(dataSize);
				out1.WriteShort((int)this.formattingFontIndex);
				out1.WriteShort((int)this.formattingOptions);
				out1.WriteContinueIfRequired(6);
				out1.WriteShort(this.numberOfRuns);
				out1.WriteShort(this.phoneticText.Length);
				out1.WriteShort(this.phoneticText.Length);
				out1.WriteContinueIfRequired(this.phoneticText.Length * 2);
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.phoneticText, out1);
				for (int i = 0; i < this.phRuns.Length; i++)
				{
					this.phRuns[i].Serialize(out1);
				}
				out1.Write(this.extraData);
			}

			// Token: 0x0600365B RID: 13915 RVA: 0x000A6318 File Offset: 0x000A4518
			public override bool Equals(object obj)
			{
				if (!(obj is global::NPOI.HSSF.Record.UnicodeString.ExtRst))
				{
					return false;
				}
				global::NPOI.HSSF.Record.UnicodeString.ExtRst o = (global::NPOI.HSSF.Record.UnicodeString.ExtRst)obj;
				return this.CompareTo(o) == 0;
			}

			// Token: 0x0600365C RID: 13916 RVA: 0x000A6340 File Offset: 0x000A4540
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600365D RID: 13917 RVA: 0x000A6348 File Offset: 0x000A4548
			public int CompareTo(global::NPOI.HSSF.Record.UnicodeString.ExtRst o)
			{
				int num = (int)(this.reserved - o.reserved);
				if (num != 0)
				{
					return num;
				}
				num = (int)(this.formattingFontIndex - o.formattingFontIndex);
				if (num != 0)
				{
					return num;
				}
				num = (int)(this.formattingOptions - o.formattingOptions);
				if (num != 0)
				{
					return num;
				}
				num = this.numberOfRuns - o.numberOfRuns;
				if (num != 0)
				{
					return num;
				}
				num = string.Compare(this.phoneticText, o.phoneticText, global::System.StringComparison.CurrentCulture);
				if (num != 0)
				{
					return num;
				}
				num = this.phRuns.Length - o.phRuns.Length;
				if (num != 0)
				{
					return num;
				}
				for (int i = 0; i < this.phRuns.Length; i++)
				{
					num = this.phRuns[i].phoneticTextFirstCharacterOffset - o.phRuns[i].phoneticTextFirstCharacterOffset;
					if (num != 0)
					{
						return num;
					}
					num = this.phRuns[i].realTextFirstCharacterOffset - o.phRuns[i].realTextFirstCharacterOffset;
					if (num != 0)
					{
						return num;
					}
					num = this.phRuns[i].realTextLength - o.phRuns[i].realTextLength;
					if (num != 0)
					{
						return num;
					}
				}
				return global::NPOI.Util.Arrays.HashCode(this.extraData) - global::NPOI.Util.Arrays.HashCode(o.extraData);
			}

			// Token: 0x0600365E RID: 13918 RVA: 0x000A6460 File Offset: 0x000A4660
			internal global::NPOI.HSSF.Record.UnicodeString.ExtRst Clone()
			{
				global::NPOI.HSSF.Record.UnicodeString.ExtRst extRst = new global::NPOI.HSSF.Record.UnicodeString.ExtRst();
				extRst.reserved = this.reserved;
				extRst.formattingFontIndex = this.formattingFontIndex;
				extRst.formattingOptions = this.formattingOptions;
				extRst.numberOfRuns = this.numberOfRuns;
				extRst.phoneticText = this.phoneticText;
				extRst.phRuns = new global::NPOI.HSSF.Record.UnicodeString.PhRun[this.phRuns.Length];
				for (int i = 0; i < extRst.phRuns.Length; i++)
				{
					extRst.phRuns[i] = new global::NPOI.HSSF.Record.UnicodeString.PhRun(this.phRuns[i].phoneticTextFirstCharacterOffset, this.phRuns[i].realTextFirstCharacterOffset, this.phRuns[i].realTextLength);
				}
				return extRst;
			}

			// Token: 0x17000E17 RID: 3607
			// (get) Token: 0x0600365F RID: 13919 RVA: 0x000A650A File Offset: 0x000A470A
			public short FormattingFontIndex
			{
				get
				{
					return this.formattingFontIndex;
				}
			}

			// Token: 0x17000E18 RID: 3608
			// (get) Token: 0x06003660 RID: 13920 RVA: 0x000A6512 File Offset: 0x000A4712
			public short FormattingOptions
			{
				get
				{
					return this.formattingOptions;
				}
			}

			// Token: 0x17000E19 RID: 3609
			// (get) Token: 0x06003661 RID: 13921 RVA: 0x000A651A File Offset: 0x000A471A
			public int NumberOfRuns
			{
				get
				{
					return this.numberOfRuns;
				}
			}

			// Token: 0x17000E1A RID: 3610
			// (get) Token: 0x06003662 RID: 13922 RVA: 0x000A6522 File Offset: 0x000A4722
			public string PhoneticText
			{
				get
				{
					return this.phoneticText;
				}
			}

			// Token: 0x17000E1B RID: 3611
			// (get) Token: 0x06003663 RID: 13923 RVA: 0x000A652A File Offset: 0x000A472A
			public global::NPOI.HSSF.Record.UnicodeString.PhRun[] PhRuns
			{
				get
				{
					return this.phRuns;
				}
			}

			// Token: 0x04001A5C RID: 6748
			private short reserved;

			// Token: 0x04001A5D RID: 6749
			private short formattingFontIndex;

			// Token: 0x04001A5E RID: 6750
			private short formattingOptions;

			// Token: 0x04001A5F RID: 6751
			private int numberOfRuns;

			// Token: 0x04001A60 RID: 6752
			private string phoneticText;

			// Token: 0x04001A61 RID: 6753
			private global::NPOI.HSSF.Record.UnicodeString.PhRun[] phRuns;

			// Token: 0x04001A62 RID: 6754
			private byte[] extraData;
		}

		// Token: 0x0200060A RID: 1546
		public class PhRun
		{
			// Token: 0x06003664 RID: 13924 RVA: 0x000A6532 File Offset: 0x000A4732
			public PhRun(int phoneticTextFirstCharacterOffset, int realTextFirstCharacterOffset, int realTextLength)
			{
				this.phoneticTextFirstCharacterOffset = phoneticTextFirstCharacterOffset;
				this.realTextFirstCharacterOffset = realTextFirstCharacterOffset;
				this.realTextLength = realTextLength;
			}

			// Token: 0x06003665 RID: 13925 RVA: 0x000A654F File Offset: 0x000A474F
			internal PhRun(global::NPOI.Util.ILittleEndianInput in1)
			{
				this.phoneticTextFirstCharacterOffset = in1.ReadUShort();
				this.realTextFirstCharacterOffset = in1.ReadUShort();
				this.realTextLength = in1.ReadUShort();
			}

			// Token: 0x06003666 RID: 13926 RVA: 0x000A657B File Offset: 0x000A477B
			internal void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
			{
				out1.WriteContinueIfRequired(6);
				out1.WriteShort(this.phoneticTextFirstCharacterOffset);
				out1.WriteShort(this.realTextFirstCharacterOffset);
				out1.WriteShort(this.realTextLength);
			}

			// Token: 0x04001A63 RID: 6755
			internal int phoneticTextFirstCharacterOffset;

			// Token: 0x04001A64 RID: 6756
			internal int realTextFirstCharacterOffset;

			// Token: 0x04001A65 RID: 6757
			internal int realTextLength;
		}
	}
}
