using System;
using System.Text;
using NPOI.HSSF.Record.Cont;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003FA RID: 1018
	public class NameRecord : global::NPOI.HSSF.Record.Cont.ContinuableRecord
	{
		// Token: 0x060024C6 RID: 9414 RVA: 0x0006E720 File Offset: 0x0006C920
		public static bool IsFormula(int optValue)
		{
			return (optValue & 15) == 0;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0006E72C File Offset: 0x0006C92C
		public NameRecord()
		{
			this.field_13_name_definition = global::NPOI.SS.Formula.Formula.Create(global::NPOI.SS.Formula.PTG.Ptg.EMPTY_PTG_ARRAY);
			this.field_12_name_text = "";
			this.field_14_custom_menu_text = "";
			this.field_15_description_text = "";
			this.field_16_help_topic_text = "";
			this.field_17_status_bar_text = "";
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x0006E788 File Offset: 0x0006C988
		protected int DataSize
		{
			get
			{
				return 13 + this.NameRawSize + this.field_14_custom_menu_text.Length + this.field_15_description_text.Length + this.field_16_help_topic_text.Length + this.field_17_status_bar_text.Length + this.field_13_name_definition.EncodedSize;
			}
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0006E7DC File Offset: 0x0006C9DC
		public NameRecord(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			global::NPOI.Util.ILittleEndianInput littleEndianInput = new global::NPOI.Util.LittleEndianByteArrayInputStream(ris.ReadAllContinuedRemainder());
			this.field_1_option_flag = littleEndianInput.ReadShort();
			this.field_2_keyboard_shortcut = (byte)littleEndianInput.ReadByte();
			int nChars = littleEndianInput.ReadByte();
			int encodedTokenLen = (int)littleEndianInput.ReadShort();
			this.field_5_externSheetIndex_plus1 = littleEndianInput.ReadShort();
			this.field_6_sheetNumber = littleEndianInput.ReadUShort();
			int num = littleEndianInput.ReadUByte();
			int num2 = littleEndianInput.ReadUByte();
			int num3 = littleEndianInput.ReadUByte();
			int num4 = littleEndianInput.ReadUByte();
			this.field_11_nameIsMultibyte = (littleEndianInput.ReadByte() != 0);
			if (this.IsBuiltInName)
			{
				this.field_12_built_in_code = (byte)littleEndianInput.ReadByte();
			}
			else if (this.field_11_nameIsMultibyte)
			{
				this.field_12_name_text = global::NPOI.Util.StringUtil.ReadUnicodeLE(littleEndianInput, nChars);
			}
			else
			{
				this.field_12_name_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(littleEndianInput, nChars);
			}
			int totalEncodedLen = littleEndianInput.Available() - (num + num2 + num3 + num4);
			this.field_13_name_definition = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, littleEndianInput, totalEncodedLen);
			this.field_14_custom_menu_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(littleEndianInput, num);
			this.field_15_description_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(littleEndianInput, num2);
			this.field_16_help_topic_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(littleEndianInput, num3);
			this.field_17_status_bar_text = global::NPOI.Util.StringUtil.ReadCompressedUnicode(littleEndianInput, num4);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0006E8FC File Offset: 0x0006CAFC
		public NameRecord(byte builtin, int sheetNumber) : this()
		{
			this.field_12_built_in_code = builtin;
			this.OptionFlag = (this.field_1_option_flag | 32);
			this.field_6_sheetNumber = sheetNumber;
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0006E922 File Offset: 0x0006CB22
		public byte FnGroup
		{
			get
			{
				return (byte)((this.field_1_option_flag & 4032) >> 4);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0006E933 File Offset: 0x0006CB33
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0006E93B File Offset: 0x0006CB3B
		public short OptionFlag
		{
			get
			{
				return this.field_1_option_flag;
			}
			set
			{
				this.field_1_option_flag = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x0006E944 File Offset: 0x0006CB44
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0006E94C File Offset: 0x0006CB4C
		public byte KeyboardShortcut
		{
			get
			{
				return this.field_2_keyboard_shortcut;
			}
			set
			{
				this.field_2_keyboard_shortcut = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0006E955 File Offset: 0x0006CB55
		public byte NameTextLength
		{
			get
			{
				if (this.IsBuiltInName)
				{
					return 1;
				}
				return (byte)this.field_12_name_text.Length;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0006E970 File Offset: 0x0006CB70
		private int NameRawSize
		{
			get
			{
				if (this.IsBuiltInName)
				{
					return 1;
				}
				int length = this.field_12_name_text.Length;
				if (this.field_11_nameIsMultibyte)
				{
					return 2 * length;
				}
				return length;
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		public void SetFunction(bool function)
		{
			if (function)
			{
				this.field_1_option_flag |= 2;
				return;
			}
			this.field_1_option_flag &= -3;
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x0006E9C5 File Offset: 0x0006CBC5
		public bool HasFormula
		{
			get
			{
				return global::NPOI.HSSF.Record.NameRecord.IsFormula((int)this.field_1_option_flag) && this.field_13_name_definition.EncodedTokenSize > 0;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0006E9E4 File Offset: 0x0006CBE4
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0006E9F1 File Offset: 0x0006CBF1
		public bool IsHiddenName
		{
			get
			{
				return (this.field_1_option_flag & 1) != 0;
			}
			set
			{
				if (value)
				{
					this.field_1_option_flag |= 1;
					return;
				}
				this.field_1_option_flag &= -2;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0006EA16 File Offset: 0x0006CC16
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		public bool IsFunctionName
		{
			get
			{
				return (this.field_1_option_flag & 2) != 0;
			}
			set
			{
				if (value)
				{
					this.field_1_option_flag |= 2;
					return;
				}
				this.field_1_option_flag &= -3;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x0006EA23 File Offset: 0x0006CC23
		public bool IsCommandName
		{
			get
			{
				return (this.field_1_option_flag & 4) != 0;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x0006EA30 File Offset: 0x0006CC30
		public bool IsMacro
		{
			get
			{
				return (this.field_1_option_flag & 8) != 0;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x0006EA3D File Offset: 0x0006CC3D
		public bool IsComplexFunction
		{
			get
			{
				return (this.field_1_option_flag & 16) != 0;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x0006EA4B File Offset: 0x0006CC4B
		public bool IsBuiltInName
		{
			get
			{
				return (this.OptionFlag & 32) != 0;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x0006EA59 File Offset: 0x0006CC59
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x0006EA76 File Offset: 0x0006CC76
		public string NameText
		{
			get
			{
				if (!this.IsBuiltInName)
				{
					return this.field_12_name_text;
				}
				return this.TranslateBuiltInName(this.BuiltInName);
			}
			set
			{
				this.field_12_name_text = value;
				this.field_11_nameIsMultibyte = global::NPOI.Util.StringUtil.HasMultibyte(value);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x0006EA8B File Offset: 0x0006CC8B
		public byte BuiltInName
		{
			get
			{
				return this.field_12_built_in_code;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x0006EA93 File Offset: 0x0006CC93
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		public global::NPOI.SS.Formula.PTG.Ptg[] NameDefinition
		{
			get
			{
				return this.field_13_name_definition.Tokens;
			}
			set
			{
				this.field_13_name_definition = global::NPOI.SS.Formula.Formula.Create(value);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0006EAAE File Offset: 0x0006CCAE
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x0006EAB6 File Offset: 0x0006CCB6
		public string CustomMenuText
		{
			get
			{
				return this.field_14_custom_menu_text;
			}
			set
			{
				this.field_14_custom_menu_text = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x0006EABF File Offset: 0x0006CCBF
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x0006EAC7 File Offset: 0x0006CCC7
		public string DescriptionText
		{
			get
			{
				return this.field_15_description_text;
			}
			set
			{
				this.field_15_description_text = value;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x0006EAD8 File Offset: 0x0006CCD8
		public string HelpTopicText
		{
			get
			{
				return this.field_16_help_topic_text;
			}
			set
			{
				this.field_16_help_topic_text = value;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x0006EAE1 File Offset: 0x0006CCE1
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x0006EAE9 File Offset: 0x0006CCE9
		public string StatusBarText
		{
			get
			{
				return this.field_17_status_bar_text;
			}
			set
			{
				this.field_17_status_bar_text = value;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0006EAF2 File Offset: 0x0006CCF2
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x0006EAFA File Offset: 0x0006CCFA
		public int SheetNumber
		{
			get
			{
				return this.field_6_sheetNumber;
			}
			set
			{
				this.field_6_sheetNumber = value;
			}
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0006EB04 File Offset: 0x0006CD04
		protected override void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			int length = this.field_14_custom_menu_text.Length;
			int length2 = this.field_15_description_text.Length;
			int length3 = this.field_16_help_topic_text.Length;
			int length4 = this.field_17_status_bar_text.Length;
			out1.WriteShort((int)this.OptionFlag);
			out1.WriteByte((int)this.KeyboardShortcut);
			out1.WriteByte((int)this.NameTextLength);
			out1.WriteShort(this.field_13_name_definition.EncodedTokenSize);
			out1.WriteShort((int)this.field_5_externSheetIndex_plus1);
			out1.WriteShort(this.field_6_sheetNumber);
			out1.WriteByte(length);
			out1.WriteByte(length2);
			out1.WriteByte(length3);
			out1.WriteByte(length4);
			out1.WriteByte(this.field_11_nameIsMultibyte ? 1 : 0);
			if (this.IsBuiltInName)
			{
				out1.WriteByte((int)this.field_12_built_in_code);
			}
			else
			{
				string input = this.field_12_name_text;
				if (this.field_11_nameIsMultibyte)
				{
					global::NPOI.Util.StringUtil.PutUnicodeLE(input, out1);
				}
				else
				{
					global::NPOI.Util.StringUtil.PutCompressedUnicode(input, out1);
				}
			}
			this.field_13_name_definition.SerializeTokens(out1);
			this.field_13_name_definition.SerializeArrayConstantData(out1);
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.CustomMenuText, out1);
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.DescriptionText, out1);
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.HelpTopicText, out1);
			global::NPOI.Util.StringUtil.PutCompressedUnicode(this.StatusBarText, out1);
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x0006EC3C File Offset: 0x0006CE3C
		public int ExternSheetNumber
		{
			get
			{
				global::NPOI.SS.Formula.PTG.Ptg[] tokens = this.field_13_name_definition.Tokens;
				if (tokens.Length == 0)
				{
					return 0;
				}
				global::NPOI.SS.Formula.PTG.Ptg ptg = tokens[0];
				if (ptg.GetType() == typeof(global::NPOI.SS.Formula.PTG.Area3DPtg))
				{
					return ((global::NPOI.SS.Formula.PTG.Area3DPtg)ptg).ExternSheetIndex;
				}
				if (ptg.GetType() == typeof(global::NPOI.SS.Formula.PTG.Ref3DPtg))
				{
					return ((global::NPOI.SS.Formula.PTG.Ref3DPtg)ptg).ExternSheetIndex;
				}
				return 0;
			}
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0006ECA6 File Offset: 0x0006CEA6
		private global::NPOI.SS.Formula.PTG.Ptg CreateNewPtg()
		{
			return new global::NPOI.SS.Formula.PTG.Area3DPtg("A1:A1", 0);
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x0006ECB3 File Offset: 0x0006CEB3
		public override short Sid
		{
			get
			{
				return 24;
			}
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0006ECB8 File Offset: 0x0006CEB8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[NAME]\n");
			stringBuilder.Append("    .option flags         = ").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_option_flag)).Append("\n");
			stringBuilder.Append("    .keyboard shortcut    = ").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_keyboard_shortcut)).Append("\n");
			stringBuilder.Append("    .Length of the name   = ").Append(this.NameTextLength).Append("\n");
			stringBuilder.Append("    .extSheetIx(1-based, 0=Global)= ").Append(this.field_5_externSheetIndex_plus1).Append("\n");
			stringBuilder.Append("    .sheetTabIx           = ").Append(this.field_6_sheetNumber).Append("\n");
			stringBuilder.Append("    .Length of menu text (Char count)        = ").Append(this.field_14_custom_menu_text.Length).Append("\n");
			stringBuilder.Append("    .Length of description text (Char count) = ").Append(this.field_15_description_text.Length).Append("\n");
			stringBuilder.Append("    .Length of help topic text (Char count)  = ").Append(this.field_16_help_topic_text.Length).Append("\n");
			stringBuilder.Append("    .Length of status bar text (Char count)  = ").Append(this.field_17_status_bar_text.Length).Append("\n");
			stringBuilder.Append("    .Name (Unicode flag)  = ").Append(this.field_11_nameIsMultibyte).Append("\n");
			stringBuilder.Append("    .Name (Unicode text)  = ").Append(this.NameText).Append("\n");
			global::NPOI.SS.Formula.PTG.Ptg[] tokens = this.field_13_name_definition.Tokens;
			stringBuilder.AppendLine("    .Formula (nTokens=" + tokens.Length.ToString() + "):");
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in tokens)
			{
				stringBuilder.Append("       " + ptg.ToString()).Append(ptg.RVAType).Append("\n");
			}
			stringBuilder.Append("    .Menu text (Unicode string without Length field)        = ").Append(this.field_14_custom_menu_text).Append("\n");
			stringBuilder.Append("    .Description text (Unicode string without Length field) = ").Append(this.field_15_description_text).Append("\n");
			stringBuilder.Append("    .Help topic text (Unicode string without Length field)  = ").Append(this.field_16_help_topic_text).Append("\n");
			stringBuilder.Append("    .Status bar text (Unicode string without Length field)  = ").Append(this.field_17_status_bar_text).Append("\n");
			stringBuilder.Append("[/NAME]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0006EF64 File Offset: 0x0006D164
		protected string TranslateBuiltInName(byte name)
		{
			switch (name)
			{
			case 0:
				return "Consolidate_Area";
			case 1:
				return "Auto_Open";
			case 2:
				return "Auto_Close";
			case 3:
				return "Extract";
			case 4:
				return "Database";
			case 5:
				return "Criteria";
			case 6:
				return "Print_Area";
			case 7:
				return "Print_Titles";
			case 8:
				return "Recorder";
			case 9:
				return "Data_Form";
			case 10:
				return "Auto_Activate";
			case 11:
				return "Auto_Deactivate";
			case 12:
				return "Sheet_Title";
			case 13:
				return "_FilterDatabase";
			default:
				return "Unknown";
			}
		}

		// Token: 0x04000F6D RID: 3949
		public const short sid = 24;

		// Token: 0x04000F6E RID: 3950
		public const byte BUILTIN_CONSOLIDATE_AREA = 0;

		// Token: 0x04000F6F RID: 3951
		public const byte BUILTIN_AUTO_OPEN = 1;

		// Token: 0x04000F70 RID: 3952
		public const byte BUILTIN_AUTO_CLOSE = 2;

		// Token: 0x04000F71 RID: 3953
		public const byte BUILTIN_EXTRACT = 3;

		// Token: 0x04000F72 RID: 3954
		public const byte BUILTIN_DATABASE = 4;

		// Token: 0x04000F73 RID: 3955
		public const byte BUILTIN_CRITERIA = 5;

		// Token: 0x04000F74 RID: 3956
		public const byte BUILTIN_PRINT_AREA = 6;

		// Token: 0x04000F75 RID: 3957
		public const byte BUILTIN_PRINT_TITLE = 7;

		// Token: 0x04000F76 RID: 3958
		public const byte BUILTIN_RECORDER = 8;

		// Token: 0x04000F77 RID: 3959
		public const byte BUILTIN_DATA_FORM = 9;

		// Token: 0x04000F78 RID: 3960
		public const byte BUILTIN_AUTO_ACTIVATE = 10;

		// Token: 0x04000F79 RID: 3961
		public const byte BUILTIN_AUTO_DEACTIVATE = 11;

		// Token: 0x04000F7A RID: 3962
		public const byte BUILTIN_SHEET_TITLE = 12;

		// Token: 0x04000F7B RID: 3963
		public const byte BUILTIN_FILTER_DB = 13;

		// Token: 0x04000F7C RID: 3964
		private short field_1_option_flag;

		// Token: 0x04000F7D RID: 3965
		private byte field_2_keyboard_shortcut;

		// Token: 0x04000F7E RID: 3966
		private short field_5_externSheetIndex_plus1;

		// Token: 0x04000F7F RID: 3967
		private int field_6_sheetNumber;

		// Token: 0x04000F80 RID: 3968
		private bool field_11_nameIsMultibyte;

		// Token: 0x04000F81 RID: 3969
		private byte field_12_built_in_code;

		// Token: 0x04000F82 RID: 3970
		private string field_12_name_text;

		// Token: 0x04000F83 RID: 3971
		private global::NPOI.SS.Formula.Formula field_13_name_definition;

		// Token: 0x04000F84 RID: 3972
		private string field_14_custom_menu_text;

		// Token: 0x04000F85 RID: 3973
		private string field_15_description_text;

		// Token: 0x04000F86 RID: 3974
		private string field_16_help_topic_text;

		// Token: 0x04000F87 RID: 3975
		private string field_17_status_bar_text;

		// Token: 0x02000611 RID: 1553
		private enum Option : short
		{
			// Token: 0x04001A76 RID: 6774
			OPT_HIDDEN_NAME = 1,
			// Token: 0x04001A77 RID: 6775
			OPT_FUNCTION_NAME,
			// Token: 0x04001A78 RID: 6776
			OPT_COMMAND_NAME = 4,
			// Token: 0x04001A79 RID: 6777
			OPT_MACRO = 8,
			// Token: 0x04001A7A RID: 6778
			OPT_COMPLEX = 16,
			// Token: 0x04001A7B RID: 6779
			OPT_BUILTIN = 32,
			// Token: 0x04001A7C RID: 6780
			OPT_BINDATA = 4096
		}
	}
}
