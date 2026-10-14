using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007C RID: 124
	public abstract class DisplayCharBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x00020E67 File Offset: 0x0001F067
		internal DisplayCharBase()
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00020E76 File Offset: 0x0001F076
		internal DisplayCharBase(global::Infragistics.Windows.Editors.SectionBase section)
		{
			this.Initialize(section);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00020E8C File Offset: 0x0001F08C
		internal void Initialize(global::Infragistics.Windows.Editors.SectionBase section)
		{
			this.section = section;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00020E95 File Offset: 0x0001F095
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00020E9D File Offset: 0x0001F09D
		internal global::Infragistics.Windows.Editors.FilterType FilterType
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00020EA6 File Offset: 0x0001F0A6
		internal global::Infragistics.Windows.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		internal int Index
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				int count = displayChars.Count;
				if (this.index >= 0 && this.index < count && this == displayChars[this.index])
				{
					return this.index;
				}
				this.index = displayChars.IndexOf(this);
				return this.index;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00020F0C File Offset: 0x0001F10C
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
				global::Infragistics.Windows.Editors.DisplayCharBase lastDisplayChar = this.Section.PreviousSection.LastDisplayChar;
				return ((lastDisplayChar != null) ? (lastDisplayChar.OverallIndexInEdit + 1) : 0) + this.Index;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00020F77 File Offset: 0x0001F177
		internal virtual bool IsEmpty
		{
			get
			{
				return '\0' == this.Char;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00020F84 File Offset: 0x0001F184
		internal bool IsSelected
		{
			get
			{
				global::Infragistics.Windows.Editors.XamMaskedEditor maskedEdit = this.MaskedEdit;
				global::Infragistics.Windows.Editors.EditInfo editInfo = (maskedEdit != null) ? maskedEdit.EditInfo : null;
				if (editInfo != null)
				{
					int overallIndexInEdit = this.OverallIndexInEdit;
					return overallIndexInEdit >= editInfo.SelectionStart && overallIndexInEdit < editInfo.SelectionStart + editInfo.SelectionLength;
				}
				return false;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00020FCC File Offset: 0x0001F1CC
		internal bool DrawSelected
		{
			get
			{
				return this.IsSelected && this.MaskInfo.IsBeingEditedAndFocused;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00020FE4 File Offset: 0x0001F1E4
		internal virtual char Filter(char c)
		{
			switch (this.filterType)
			{
			case global::Infragistics.Windows.Editors.FilterType.LowerCase:
				c = char.ToLower(c, global::System.Globalization.CultureInfo.CurrentCulture);
				break;
			case global::Infragistics.Windows.Editors.FilterType.UpperCase:
				c = char.ToUpper(c, global::System.Globalization.CultureInfo.CurrentCulture);
				break;
			}
			return c;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0002102C File Offset: 0x0001F22C
		internal global::Infragistics.Windows.Editors.DisplayCharBase PrevDisplayChar
		{
			get
			{
				if (this.Section == null)
				{
					return null;
				}
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
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

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00021090 File Offset: 0x0001F290
		internal global::Infragistics.Windows.Editors.DisplayCharBase NextDisplayChar
		{
			get
			{
				if (this.Section == null)
				{
					return null;
				}
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				if (displayChars == null)
				{
					return null;
				}
				int num = this.Index;
				if (1 + num < displayChars.Count)
				{
					return displayChars[1 + num];
				}
				global::Infragistics.Windows.Editors.SectionBase nextSection = this.Section.NextSection;
				if (nextSection == null)
				{
					return null;
				}
				return nextSection.FirstDisplayChar;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000210EC File Offset: 0x0001F2EC
		internal global::Infragistics.Windows.Editors.DisplayCharBase NextLiteralChar
		{
			get
			{
				for (global::Infragistics.Windows.Editors.DisplayCharBase nextDisplayChar = this.NextDisplayChar; nextDisplayChar != null; nextDisplayChar = nextDisplayChar.NextDisplayChar)
				{
					if (!nextDisplayChar.IsEditable)
					{
						return nextDisplayChar;
					}
				}
				return null;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00021118 File Offset: 0x0001F318
		internal global::Infragistics.Windows.Editors.DisplayCharBase NextEditableDisplayChar
		{
			get
			{
				if (this.Section == null)
				{
					return null;
				}
				global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = this.Section.DisplayChars;
				if (displayChars == null)
				{
					return null;
				}
				for (int i = 1 + this.Index; i < displayChars.Count; i++)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000211BC File Offset: 0x0001F3BC
		internal global::Infragistics.Windows.Editors.DisplayCharBase NextFilledEditableDisplayChar
		{
			get
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = this;
				do
				{
					displayCharBase = displayCharBase.NextEditableDisplayChar;
				}
				while (displayCharBase != null && displayCharBase.IsEmpty);
				return displayCharBase;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000211DE File Offset: 0x0001F3DE
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000211E6 File Offset: 0x0001F3E6
		public global::Infragistics.Windows.Editors.DisplayCharIncludeMethod IncludeMethod
		{
			get
			{
				return this.includeMethod;
			}
			set
			{
				global::Infragistics.Windows.Editors.Utils.ValidateEnum("IncludeMethod", typeof(global::Infragistics.Windows.Editors.DisplayCharIncludeMethod), value);
				this.includeMethod = value;
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0002120C File Offset: 0x0001F40C
		internal char GetChar(global::Infragistics.Windows.Editors.MaskMode maskMode, char promptChar, char padChar)
		{
			char @char = this.Char;
			switch (this.IncludeMethod)
			{
			case global::Infragistics.Windows.Editors.DisplayCharIncludeMethod.Always:
			{
				global::Infragistics.Windows.Editors.DisplayCharBase nextDisplayChar = this.NextDisplayChar;
				if (nextDisplayChar != null && nextDisplayChar.Section is global::Infragistics.Windows.Editors.FractionPart && this.Section != nextDisplayChar.Section)
				{
					global::Infragistics.Windows.Editors.FractionPart fractionPart = (global::Infragistics.Windows.Editors.FractionPart)nextDisplayChar.Section;
					bool flag = true;
					global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = fractionPart.DisplayChars;
					int i = 0;
					int count = displayChars.Count;
					while (i < count)
					{
						global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
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
			case global::Infragistics.Windows.Editors.DisplayCharIncludeMethod.Never:
				return '\0';
			}
			char c = '\0';
			switch (maskMode)
			{
			case global::Infragistics.Windows.Editors.MaskMode.Raw:
				if (this.IsEditable)
				{
					c = @char;
				}
				break;
			case global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals:
				c = @char;
				break;
			case global::Infragistics.Windows.Editors.MaskMode.IncludePromptChars:
				if (this.IsEditable)
				{
					c = @char;
					if (c == '\0')
					{
						c = promptChar;
					}
				}
				break;
			case global::Infragistics.Windows.Editors.MaskMode.IncludeBoth:
				c = @char;
				if (c == '\0')
				{
					c = promptChar;
				}
				break;
			case global::Infragistics.Windows.Editors.MaskMode.IncludeLiteralsWithPadding:
				c = @char;
				if (c == '\0')
				{
					c = padChar;
				}
				break;
			}
			return c;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00021320 File Offset: 0x0001F520
		internal char GetChar(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			if (maskInfo == null)
			{
				return this.Char;
			}
			return this.GetChar(maskMode, maskInfo.PromptChar, maskInfo.PadChar);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00021354 File Offset: 0x0001F554
		internal virtual char GetDrawChar()
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			if (maskInfo == null)
			{
				return this.Char;
			}
			if (maskInfo.IsBeingEditedAndFocused)
			{
				return this.GetChar(global::Infragistics.Windows.Editors.MaskMode.IncludeBoth);
			}
			return this.GetChar(maskInfo.DisplayMode);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00021390 File Offset: 0x0001F590
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000213D4 File Offset: 0x0001F5D4
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				if (this.GetDrawChar() == '\0')
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000213F0 File Offset: 0x0001F5F0
		internal void NotifyPropertyChangedEvent(string propName)
		{
			base.RaisePropertyChangedEvent(propName);
			if (global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_CHAR == propName)
			{
				base.RaisePropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_VISIBILITY);
				base.RaisePropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_DRAWSTRING);
				if (this.section is global::Infragistics.Windows.Editors.FractionPart)
				{
					global::Infragistics.Windows.Editors.LiteralSection previousLiteralSection = this.section.PreviousLiteralSection;
					if (previousLiteralSection != null)
					{
						global::Infragistics.Windows.Editors.XamMaskedEditor.NotifyPropertyOnDisplayCharacters(previousLiteralSection, global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_CHAR);
					}
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0002144E File Offset: 0x0001F64E
		internal virtual bool DrawComma
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00021454 File Offset: 0x0001F654
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEdit
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase = this.section;
				if (sectionBase == null)
				{
					return null;
				}
				return sectionBase.MaskedEdit;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00021473 File Offset: 0x0001F673
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Section.MaskInfo;
			}
		}

		// Token: 0x060007AC RID: 1964
		public abstract bool MatchChar(char c);

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00021480 File Offset: 0x0001F680
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x00021488 File Offset: 0x0001F688
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007AF RID: 1967
		public abstract bool IsEditable { get; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007B0 RID: 1968
		// (set) Token: 0x060007B1 RID: 1969
		public abstract char Char { get; set; }

		// Token: 0x060007B2 RID: 1970 RVA: 0x00021491 File Offset: 0x0001F691
		internal void EraseChar()
		{
			if (this.IsEditable)
			{
				this.Char = '\0';
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000214A4 File Offset: 0x0001F6A4
		internal virtual void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_2"), "dest");
			}
			dest.filterType = this.filterType;
			dest.includeMethod = this.includeMethod;
			dest.required = this.required;
		}

		// Token: 0x060007B4 RID: 1972
		internal abstract global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section);

		// Token: 0x040002C0 RID: 704
		private global::Infragistics.Windows.Editors.FilterType filterType;

		// Token: 0x040002C1 RID: 705
		private global::Infragistics.Windows.Editors.DisplayCharIncludeMethod includeMethod;

		// Token: 0x040002C2 RID: 706
		private global::Infragistics.Windows.Editors.SectionBase section;

		// Token: 0x040002C3 RID: 707
		private bool required;

		// Token: 0x040002C4 RID: 708
		private int index = -1;

		// Token: 0x040002C5 RID: 709
		internal static string PROPERTY_CHAR = "Char";

		// Token: 0x040002C6 RID: 710
		internal static string PROPERTY_DRAWSTRING = "DrawString";

		// Token: 0x040002C7 RID: 711
		internal static string PROPERTY_VISIBILITY = "Visibility";

		// Token: 0x040002C8 RID: 712
		internal static string PROPERTY_DRAWSELECTED = "DrawSelected";
	}
}
