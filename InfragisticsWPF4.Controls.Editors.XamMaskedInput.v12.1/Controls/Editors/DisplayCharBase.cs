using System;
using System.Globalization;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200000D RID: 13
	public abstract class DisplayCharBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003782 File Offset: 0x00001982
		internal DisplayCharBase()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003791 File Offset: 0x00001991
		internal DisplayCharBase(global::Infragistics.Controls.Editors.SectionBase section)
		{
			this.Initialize(section);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000037A7 File Offset: 0x000019A7
		internal void Initialize(global::Infragistics.Controls.Editors.SectionBase section)
		{
			this.section = section;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000037B0 File Offset: 0x000019B0
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000037B8 File Offset: 0x000019B8
		internal global::Infragistics.Controls.Editors.FilterType FilterType
		{
			get
			{
				return this.filterType;
			}
			set
			{
				this.filterType = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000037C1 File Offset: 0x000019C1
		internal global::Infragistics.Controls.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000037CC File Offset: 0x000019CC
		internal int Index
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				int count = displayChars.Count;
				if (this.index >= 0 && this.index < count && this == displayChars[this.index])
				{
					return this.index;
				}
				this.index = displayChars.IndexOf(this);
				return this.index;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003828 File Offset: 0x00001A28
		internal int OverallIndexInEdit
		{
			get
			{
				if (this.Section.Index < 0)
				{
					return -1;
				}
				if (this.Section.Index == 0)
				{
					return this.Index;
				}
				if (this.Section.PreviousSection == null)
				{
					return this.Index;
				}
				global::Infragistics.Controls.Editors.DisplayCharBase lastDisplayChar = this.Section.PreviousSection.LastDisplayChar;
				return ((lastDisplayChar != null) ? (lastDisplayChar.OverallIndexInEdit + 1) : 0) + this.Index;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003893 File Offset: 0x00001A93
		internal virtual bool IsEmpty
		{
			get
			{
				return '\0' == this.Char;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000038A0 File Offset: 0x00001AA0
		internal bool IsSelected
		{
			get
			{
				global::Infragistics.Controls.Editors.XamMaskedInput maskedEdit = this.MaskedEdit;
				global::Infragistics.Controls.Editors.EditInfo editInfo = (maskedEdit != null) ? maskedEdit.EditInfo : null;
				if (editInfo != null)
				{
					int overallIndexInEdit = this.OverallIndexInEdit;
					return overallIndexInEdit >= editInfo.SelectionStart && overallIndexInEdit < editInfo.SelectionStart + editInfo.SelectionLength;
				}
				return false;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000038E8 File Offset: 0x00001AE8
		internal char Filter(char c)
		{
			switch (this.filterType)
			{
			case global::Infragistics.Controls.Editors.FilterType.LowerCase:
				c = char.ToLower(c, global::System.Globalization.CultureInfo.CurrentCulture);
				break;
			case global::Infragistics.Controls.Editors.FilterType.UpperCase:
				c = char.ToUpper(c, global::System.Globalization.CultureInfo.CurrentCulture);
				break;
			}
			return c;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003930 File Offset: 0x00001B30
		internal global::Infragistics.Controls.Editors.DisplayCharBase PrevDisplayChar
		{
			get
			{
				if (this.Section == null)
				{
					return null;
				}
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				if (displayChars == null)
				{
					return null;
				}
				if (this.Index - 1 >= 0)
				{
					return displayChars[this.Index - 1];
				}
				if (this.Section.PreviousSection == null)
				{
					return null;
				}
				return this.Section.PreviousSection.LastDisplayChar;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003994 File Offset: 0x00001B94
		internal global::Infragistics.Controls.Editors.DisplayCharBase NextDisplayChar
		{
			get
			{
				if (this.Section == null)
				{
					return null;
				}
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				if (displayChars == null)
				{
					return null;
				}
				int num = this.Index;
				if (1 + num < displayChars.Count)
				{
					return displayChars[1 + num];
				}
				global::Infragistics.Controls.Editors.SectionBase nextSection = this.Section.NextSection;
				if (nextSection == null)
				{
					return null;
				}
				return nextSection.FirstDisplayChar;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000039F0 File Offset: 0x00001BF0
		internal global::Infragistics.Controls.Editors.DisplayCharBase NextEditableDisplayChar
		{
			get
			{
				if (this.Section == null)
				{
					return null;
				}
				global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				if (displayChars == null)
				{
					return null;
				}
				for (int i = 1 + this.Index; i < displayChars.Count; i++)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
					if (displayCharBase != null && displayCharBase.IsEditable)
					{
						return displayCharBase;
					}
				}
				if (this.Section.NextEditSection == null)
				{
					return null;
				}
				if (this.Section.NextEditSection.FirstDisplayChar.IsEditable)
				{
					return this.Section.NextEditSection.FirstDisplayChar;
				}
				return this.Section.NextEditSection.FirstDisplayChar.NextEditableDisplayChar;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003A94 File Offset: 0x00001C94
		internal global::Infragistics.Controls.Editors.DisplayCharBase NextFilledEditableDisplayChar
		{
			get
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = this;
				do
				{
					displayCharBase = displayCharBase.NextEditableDisplayChar;
				}
				while (displayCharBase != null && displayCharBase.IsEmpty);
				return displayCharBase;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003AB6 File Offset: 0x00001CB6
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003ABE File Offset: 0x00001CBE
		public global::Infragistics.Controls.Editors.DisplayCharIncludeMethod IncludeMethod
		{
			get
			{
				return this.includeMethod;
			}
			set
			{
				global::Infragistics.Controls.Editors.Primitives.Utils.ValidateEnum("IncludeMethod", typeof(global::Infragistics.Controls.Editors.DisplayCharIncludeMethod), value);
				this.includeMethod = value;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003AE4 File Offset: 0x00001CE4
		internal char GetChar(global::Infragistics.Controls.Editors.InputMaskMode maskMode, char promptChar, char padChar)
		{
			char @char = this.Char;
			switch (this.IncludeMethod)
			{
			case global::Infragistics.Controls.Editors.DisplayCharIncludeMethod.Always:
			{
				global::Infragistics.Controls.Editors.DisplayCharBase nextDisplayChar = this.NextDisplayChar;
				if (nextDisplayChar != null && nextDisplayChar.Section is global::Infragistics.Controls.Editors.FractionPart && this.Section != nextDisplayChar.Section)
				{
					global::Infragistics.Controls.Editors.FractionPart fractionPart = (global::Infragistics.Controls.Editors.FractionPart)nextDisplayChar.Section;
					bool flag = true;
					global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = fractionPart.DisplayChars;
					int i = 0;
					int count = displayChars.Count;
					while (i < count)
					{
						global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
						if (displayCharBase != null && displayCharBase.GetChar(maskMode, promptChar, padChar) != '\0')
						{
							flag = false;
							break;
						}
						i++;
					}
					if (flag)
					{
						return '\0';
					}
				}
				if (@char != '\0')
				{
					return @char;
				}
				break;
			}
			case global::Infragistics.Controls.Editors.DisplayCharIncludeMethod.Never:
				return '\0';
			}
			char c = '\0';
			switch (maskMode)
			{
			case global::Infragistics.Controls.Editors.InputMaskMode.Raw:
				if (this.IsEditable)
				{
					c = @char;
				}
				break;
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals:
				c = @char;
				break;
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludePromptChars:
				if (this.IsEditable)
				{
					c = @char;
					if (c == '\0')
					{
						c = promptChar;
					}
				}
				break;
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth:
				c = @char;
				if (c == '\0')
				{
					c = promptChar;
				}
				break;
			case global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiteralsWithPadding:
				c = @char;
				if (c == '\0')
				{
					c = padChar;
				}
				break;
			}
			return c;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003BF8 File Offset: 0x00001DF8
		internal char GetChar(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
			if (maskInfo == null)
			{
				return this.Char;
			}
			return this.GetChar(maskMode, maskInfo.PromptChar, maskInfo.PadChar);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C2C File Offset: 0x00001E2C
		internal virtual char GetDrawChar()
		{
			global::Infragistics.Controls.Editors.MaskInfo maskInfo = this.MaskInfo;
			if (maskInfo == null)
			{
				return this.Char;
			}
			if (maskInfo.IsBeingEditedAndFocused)
			{
				return this.GetChar(global::Infragistics.Controls.Editors.InputMaskMode.IncludeBoth);
			}
			return this.GetChar(maskInfo.DisplayMode);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003C68 File Offset: 0x00001E68
		public string DrawString
		{
			get
			{
				string text = this.GetDrawChar().ToString();
				if (this.DrawComma && this.MaskInfo != null)
				{
					text += this.MaskInfo.CommaChar;
				}
				return text;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003CAC File Offset: 0x00001EAC
		internal void NotifyPropertyChangedEvent(string propName)
		{
			base.RaisePropertyChangedEvent(propName);
			if (global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_CHAR == propName)
			{
				base.RaisePropertyChangedEvent(global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_VISIBILITY);
				base.RaisePropertyChangedEvent(global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_DRAWSTRING);
				if (this.section is global::Infragistics.Controls.Editors.FractionPart)
				{
					global::Infragistics.Controls.Editors.LiteralSection previousLiteralSection = this.section.PreviousLiteralSection;
					if (previousLiteralSection != null)
					{
						global::Infragistics.Controls.Editors.XamMaskedInput.NotifyPropertyOnDisplayCharacters(previousLiteralSection, global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_CHAR);
					}
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003D0A File Offset: 0x00001F0A
		internal virtual bool DrawComma
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003D10 File Offset: 0x00001F10
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedEdit
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase = this.section;
				if (sectionBase == null)
				{
					return null;
				}
				return sectionBase.MaskedEdit;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003D2F File Offset: 0x00001F2F
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Section.MaskInfo;
			}
		}

		// Token: 0x06000042 RID: 66
		public abstract bool MatchChar(char c);

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003D3C File Offset: 0x00001F3C
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00003D44 File Offset: 0x00001F44
		internal bool Required
		{
			get
			{
				return this.required;
			}
			set
			{
				this.required = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69
		public abstract bool IsEditable { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		public abstract char Char { get; set; }

		// Token: 0x06000048 RID: 72 RVA: 0x00003D4D File Offset: 0x00001F4D
		internal void EraseChar()
		{
			if (this.IsEditable)
			{
				this.Char = '\0';
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003D60 File Offset: 0x00001F60
		internal virtual void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_2"), "dest");
			}
			dest.filterType = this.filterType;
			dest.includeMethod = this.includeMethod;
			dest.required = this.required;
		}

		// Token: 0x0600004A RID: 74
		internal abstract global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section);

		// Token: 0x04000041 RID: 65
		private global::Infragistics.Controls.Editors.FilterType filterType;

		// Token: 0x04000042 RID: 66
		private global::Infragistics.Controls.Editors.DisplayCharIncludeMethod includeMethod;

		// Token: 0x04000043 RID: 67
		private global::Infragistics.Controls.Editors.SectionBase section;

		// Token: 0x04000044 RID: 68
		private bool required;

		// Token: 0x04000045 RID: 69
		private int index = -1;

		// Token: 0x04000046 RID: 70
		internal static string PROPERTY_CHAR = "Char";

		// Token: 0x04000047 RID: 71
		internal static string PROPERTY_DRAWSTRING = "DrawString";

		// Token: 0x04000048 RID: 72
		internal static string PROPERTY_VISIBILITY = "Visibility";

		// Token: 0x04000049 RID: 73
		internal static string PROPERTY_DRAWSELECTED = "DrawSelected";
	}
}
