using System;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C8 RID: 1224
	public class FontFormatting : global::System.ICloneable
	{
		// Token: 0x06002E1D RID: 11805 RVA: 0x0008843C File Offset: 0x0008663C
		public FontFormatting()
		{
			this.FontHeight = -1;
			this.IsItalic = false;
			this.IsFontWeightModified = false;
			this.IsOutlineOn = false;
			this.IsShadowOn = false;
			this.IsStruckout = false;
			this.EscapementType = global::NPOI.SS.UserModel.FontSuperScript.None;
			this.UnderlineType = global::NPOI.SS.UserModel.FontUnderlineType.None;
			this.FontColorIndex = -1;
			this.IsFontStyleModified = false;
			this.IsFontOutlineModified = false;
			this.IsFontShadowModified = false;
			this.IsFontCancellationModified = false;
			this.IsEscapementTypeModified = false;
			this.IsUnderlineTypeModified = false;
			this.SetShort(0, 0);
			this.SetInt(104, 1);
			this.SetInt(108, 0);
			this.SetInt(112, int.MaxValue);
			this.SetShort(116, 1);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000884F8 File Offset: 0x000866F8
		public FontFormatting(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			for (int i = 0; i < this._rawData.Length; i++)
			{
				this._rawData[i] = (byte)in1.ReadByte();
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x0008853A File Offset: 0x0008673A
		private short GetShort(int offset)
		{
			return global::NPOI.Util.LittleEndian.GetShort(this._rawData, offset);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00088548 File Offset: 0x00086748
		private void SetShort(int offset, int value)
		{
			global::NPOI.Util.LittleEndian.PutShort(this._rawData, offset, (short)value);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00088558 File Offset: 0x00086758
		private int GetInt(int offset)
		{
			return global::NPOI.Util.LittleEndian.GetInt(this._rawData, offset);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00088566 File Offset: 0x00086766
		private void SetInt(int offset, int value)
		{
			global::NPOI.Util.LittleEndian.PutInt(this._rawData, offset, value);
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00088575 File Offset: 0x00086775
		public byte[] RawRecord
		{
			get
			{
				return this._rawData;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x0008857D File Offset: 0x0008677D
		public int DataLength
		{
			get
			{
				return 118;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x00088581 File Offset: 0x00086781
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0008858B File Offset: 0x0008678B
		public int FontHeight
		{
			get
			{
				return this.GetInt(64);
			}
			set
			{
				this.SetInt(64, value);
			}
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00088598 File Offset: 0x00086798
		private void SetFontOption(bool option, global::NPOI.Util.BitField field)
		{
			int num = this.GetInt(68);
			num = field.SetBoolean(num, option);
			this.SetInt(68, num);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000885C0 File Offset: 0x000867C0
		private bool GetFontOption(global::NPOI.Util.BitField field)
		{
			int @int = this.GetInt(68);
			return field.IsSet(@int);
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000885DD File Offset: 0x000867DD
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x000885EA File Offset: 0x000867EA
		public bool IsItalic
		{
			get
			{
				return this.GetFontOption(global::NPOI.HSSF.Record.CF.FontFormatting.posture);
			}
			set
			{
				this.SetFontOption(value, global::NPOI.HSSF.Record.CF.FontFormatting.posture);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000885F8 File Offset: 0x000867F8
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x00088605 File Offset: 0x00086805
		public bool IsOutlineOn
		{
			get
			{
				return this.GetFontOption(global::NPOI.HSSF.Record.CF.FontFormatting.outline);
			}
			set
			{
				this.SetFontOption(value, global::NPOI.HSSF.Record.CF.FontFormatting.outline);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00088613 File Offset: 0x00086813
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x00088620 File Offset: 0x00086820
		public bool IsShadowOn
		{
			get
			{
				return this.GetFontOption(global::NPOI.HSSF.Record.CF.FontFormatting.shadow);
			}
			set
			{
				this.SetFontOption(value, global::NPOI.HSSF.Record.CF.FontFormatting.shadow);
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x0008862E File Offset: 0x0008682E
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x0008863B File Offset: 0x0008683B
		public bool IsStruckout
		{
			get
			{
				return this.GetFontOption(global::NPOI.HSSF.Record.CF.FontFormatting.cancellation);
			}
			set
			{
				this.SetFontOption(value, global::NPOI.HSSF.Record.CF.FontFormatting.cancellation);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x00088649 File Offset: 0x00086849
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x00088654 File Offset: 0x00086854
		public short FontWeight
		{
			get
			{
				return this.GetShort(72);
			}
			set
			{
				short num = value;
				if (num < 100)
				{
					num = 100;
				}
				if (num > 1000)
				{
					num = 1000;
				}
				this.SetShort(72, (int)num);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x00088682 File Offset: 0x00086882
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x00088691 File Offset: 0x00086891
		public bool IsBold
		{
			get
			{
				return this.FontWeight == 700;
			}
			set
			{
				this.FontWeight = (value ? 700 : 400);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x000886A8 File Offset: 0x000868A8
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x000886B2 File Offset: 0x000868B2
		public global::NPOI.SS.UserModel.FontSuperScript EscapementType
		{
			get
			{
				return (global::NPOI.SS.UserModel.FontSuperScript)this.GetShort(74);
			}
			set
			{
				this.SetShort(74, (int)value);
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x000886BD File Offset: 0x000868BD
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x000886C8 File Offset: 0x000868C8
		public global::NPOI.SS.UserModel.FontUnderlineType UnderlineType
		{
			get
			{
				return (global::NPOI.SS.UserModel.FontUnderlineType)this.GetShort(76);
			}
			set
			{
				this.SetShort(76, (int)value);
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x000886D3 File Offset: 0x000868D3
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x000886DE File Offset: 0x000868DE
		public short FontColorIndex
		{
			get
			{
				return (short)this.GetInt(80);
			}
			set
			{
				this.SetInt(80, (int)value);
			}
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000886EC File Offset: 0x000868EC
		private bool GetOptionFlag(global::NPOI.Util.BitField field)
		{
			int @int = this.GetInt(88);
			return field.GetValue(@int) == 0;
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00088710 File Offset: 0x00086910
		private void SetOptionFlag(bool modified, global::NPOI.Util.BitField field)
		{
			int value = modified ? 0 : 1;
			int num = this.GetInt(88);
			num = field.SetValue(num, value);
			this.SetInt(88, num);
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x00088740 File Offset: 0x00086940
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x0008874D File Offset: 0x0008694D
		public bool IsFontStyleModified
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.FontFormatting.styleModified);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.FontFormatting.styleModified);
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x0008875B File Offset: 0x0008695B
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00088768 File Offset: 0x00086968
		public bool IsFontOutlineModified
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.FontFormatting.outlineModified);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.FontFormatting.outlineModified);
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x00088776 File Offset: 0x00086976
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00088783 File Offset: 0x00086983
		public bool IsFontShadowModified
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.FontFormatting.shadowModified);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.FontFormatting.shadowModified);
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00088791 File Offset: 0x00086991
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x0008879E File Offset: 0x0008699E
		public bool IsFontCancellationModified
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.FontFormatting.cancellationModified);
			}
			set
			{
				this.SetOptionFlag(value, global::NPOI.HSSF.Record.CF.FontFormatting.cancellationModified);
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000887AC File Offset: 0x000869AC
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x000887BC File Offset: 0x000869BC
		public bool IsEscapementTypeModified
		{
			get
			{
				return this.GetInt(92) == 0;
			}
			set
			{
				int value2 = value ? 0 : 1;
				this.SetInt(92, value2);
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x000887DA File Offset: 0x000869DA
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x000887E8 File Offset: 0x000869E8
		public bool IsUnderlineTypeModified
		{
			get
			{
				return this.GetInt(96) == 0;
			}
			set
			{
				int value2 = value ? 0 : 1;
				this.SetInt(96, value2);
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x00088806 File Offset: 0x00086A06
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x00088814 File Offset: 0x00086A14
		public bool IsFontWeightModified
		{
			get
			{
				return this.GetInt(100) == 0;
			}
			set
			{
				int value2 = value ? 0 : 1;
				this.SetInt(100, value2);
			}
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00088834 File Offset: 0x00086A34
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Font Formatting]\n");
			stringBuilder.Append("\t.font height = ").Append(this.FontHeight).Append(" twips\n");
			if (this.IsFontStyleModified)
			{
				stringBuilder.Append("\t.font posture = ").Append(this.IsItalic ? "Italic" : "Normal").Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.font posture = ]not modified]").Append("\n");
			}
			if (this.IsFontOutlineModified)
			{
				stringBuilder.Append("\t.font outline = ").Append(this.IsOutlineOn).Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.font outline Is not modified\n");
			}
			if (this.IsFontShadowModified)
			{
				stringBuilder.Append("\t.font shadow = ").Append(this.IsShadowOn).Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.font shadow Is not modified\n");
			}
			if (this.IsFontCancellationModified)
			{
				stringBuilder.Append("\t.font strikeout = ").Append(this.IsStruckout).Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.font strikeout Is not modified\n");
			}
			if (this.IsFontStyleModified)
			{
				stringBuilder.Append("\t.font weight = ").Append(this.FontWeight).Append((this.FontWeight == 400) ? "(Normal)" : ((this.FontWeight == 700) ? "(Bold)" : ("0x" + global::NPOI.Util.StringUtil.ToHexString(this.FontWeight)))).Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.font weight = ]not modified]").Append("\n");
			}
			if (this.IsEscapementTypeModified)
			{
				stringBuilder.Append("\t.escapement type = ").Append(this.EscapementType).Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.escapement type Is not modified\n");
			}
			if (this.IsUnderlineTypeModified)
			{
				stringBuilder.Append("\t.underline type = ").Append(this.UnderlineType).Append("\n");
			}
			else
			{
				stringBuilder.Append("\t.underline type Is not modified\n");
			}
			stringBuilder.Append("\t.color index = ").Append("0x" + global::NPOI.Util.StringUtil.ToHexString(this.FontColorIndex).ToUpper()).Append("\n");
			stringBuilder.Append("    [/Font Formatting]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00088AAC File Offset: 0x00086CAC
		public object Clone()
		{
			global::NPOI.HSSF.Record.CF.FontFormatting fontFormatting = new global::NPOI.HSSF.Record.CF.FontFormatting();
			global::System.Array.Copy(this._rawData, 0, fontFormatting._rawData, 0, this._rawData.Length);
			return fontFormatting;
		}

		// Token: 0x04001435 RID: 5173
		private byte[] _rawData = new byte[118];

		// Token: 0x04001436 RID: 5174
		private const int OFFSET_FONT_NAME = 0;

		// Token: 0x04001437 RID: 5175
		private const int OFFSET_FONT_HEIGHT = 64;

		// Token: 0x04001438 RID: 5176
		private const int OFFSET_FONT_OPTIONS = 68;

		// Token: 0x04001439 RID: 5177
		private const int OFFSET_FONT_WEIGHT = 72;

		// Token: 0x0400143A RID: 5178
		private const int OFFSET_ESCAPEMENT_TYPE = 74;

		// Token: 0x0400143B RID: 5179
		private const int OFFSET_UNDERLINE_TYPE = 76;

		// Token: 0x0400143C RID: 5180
		private const int OFFSET_FONT_COLOR_INDEX = 80;

		// Token: 0x0400143D RID: 5181
		private const int OFFSET_OPTION_FLAGS = 88;

		// Token: 0x0400143E RID: 5182
		private const int OFFSET_ESCAPEMENT_TYPE_MODIFIED = 92;

		// Token: 0x0400143F RID: 5183
		private const int OFFSET_UNDERLINE_TYPE_MODIFIED = 96;

		// Token: 0x04001440 RID: 5184
		private const int OFFSET_FONT_WEIGHT_MODIFIED = 100;

		// Token: 0x04001441 RID: 5185
		private const int OFFSET_NOT_USED1 = 104;

		// Token: 0x04001442 RID: 5186
		private const int OFFSET_NOT_USED2 = 108;

		// Token: 0x04001443 RID: 5187
		private const int OFFSET_NOT_USED3 = 112;

		// Token: 0x04001444 RID: 5188
		private const int OFFSET_FONT_FORMATING_END = 116;

		// Token: 0x04001445 RID: 5189
		private const int RAW_DATA_SIZE = 118;

		// Token: 0x04001446 RID: 5190
		public const int FONT_CELL_HEIGHT_PRESERVED = -1;

		// Token: 0x04001447 RID: 5191
		private static global::NPOI.Util.BitField posture = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001448 RID: 5192
		private static global::NPOI.Util.BitField outline = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001449 RID: 5193
		private static global::NPOI.Util.BitField shadow = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x0400144A RID: 5194
		private static global::NPOI.Util.BitField cancellation = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x0400144B RID: 5195
		private static global::NPOI.Util.BitField styleModified = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x0400144C RID: 5196
		private static global::NPOI.Util.BitField outlineModified = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x0400144D RID: 5197
		private static global::NPOI.Util.BitField shadowModified = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x0400144E RID: 5198
		private static global::NPOI.Util.BitField cancellationModified = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x0400144F RID: 5199
		private const short FONT_WEIGHT_NORMAL = 400;

		// Token: 0x04001450 RID: 5200
		private const short FONT_WEIGHT_BOLD = 700;
	}
}
