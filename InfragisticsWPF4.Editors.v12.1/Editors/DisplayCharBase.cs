using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000076 RID: 118
	public abstract class DisplayCharBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x0001F46B File Offset: 0x0001D66B
		internal DisplayCharBase()
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001F47A File Offset: 0x0001D67A
		internal DisplayCharBase(global::Infragistics.Windows.Editors.SectionBase section)
		{
			this.Initialize(section);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001F490 File Offset: 0x0001D690
		internal void Initialize(global::Infragistics.Windows.Editors.SectionBase section)
		{
			this.section = section;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x0001F499 File Offset: 0x0001D699
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0001F4A1 File Offset: 0x0001D6A1
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0001F4AA File Offset: 0x0001D6AA
		internal global::Infragistics.Windows.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x0001F510 File Offset: 0x0001D710
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

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0001F57B File Offset: 0x0001D77B
		internal virtual bool IsEmpty
		{
			get
			{
				return '\0' == this.Char;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0001F588 File Offset: 0x0001D788
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
		internal bool DrawSelected
		{
			get
			{
				return this.IsSelected && this.MaskInfo.IsBeingEditedAndFocused;
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
		internal char Filter(char c)
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

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001F630 File Offset: 0x0001D830
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

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0001F694 File Offset: 0x0001D894
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

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
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

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0001F794 File Offset: 0x0001D994
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

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0001F7B6 File Offset: 0x0001D9B6
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0001F7BE File Offset: 0x0001D9BE
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

		// Token: 0x06000742 RID: 1858 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
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

		// Token: 0x06000743 RID: 1859 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		internal char GetChar(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
			if (maskInfo == null)
			{
				return this.Char;
			}
			return this.GetChar(maskMode, maskInfo.PromptChar, maskInfo.PadChar);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001F92C File Offset: 0x0001DB2C
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

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001F968 File Offset: 0x0001DB68
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001F9AC File Offset: 0x0001DBAC
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

		// Token: 0x06000747 RID: 1863 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
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

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0001FA26 File Offset: 0x0001DC26
		internal virtual bool DrawComma
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001FA2C File Offset: 0x0001DC2C
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001FA4B File Offset: 0x0001DC4B
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Section.MaskInfo;
			}
		}

		// Token: 0x0600074B RID: 1867
		public abstract bool MatchChar(char c);

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0001FA58 File Offset: 0x0001DC58
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0001FA60 File Offset: 0x0001DC60
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

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600074E RID: 1870
		public abstract bool IsEditable { get; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600074F RID: 1871
		// (set) Token: 0x06000750 RID: 1872
		public abstract char Char { get; set; }

		// Token: 0x06000751 RID: 1873 RVA: 0x0001FA69 File Offset: 0x0001DC69
		internal void EraseChar()
		{
			if (this.IsEditable)
			{
				this.Char = '\0';
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001FA7C File Offset: 0x0001DC7C
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

		// Token: 0x06000753 RID: 1875
		internal abstract global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section);

		// Token: 0x0400028D RID: 653
		private global::Infragistics.Windows.Editors.FilterType filterType;

		// Token: 0x0400028E RID: 654
		private global::Infragistics.Windows.Editors.DisplayCharIncludeMethod includeMethod;

		// Token: 0x0400028F RID: 655
		private global::Infragistics.Windows.Editors.SectionBase section;

		// Token: 0x04000290 RID: 656
		private bool required;

		// Token: 0x04000291 RID: 657
		private int index = -1;

		// Token: 0x04000292 RID: 658
		internal static string PROPERTY_CHAR = "Char";

		// Token: 0x04000293 RID: 659
		internal static string PROPERTY_DRAWSTRING = "DrawString";

		// Token: 0x04000294 RID: 660
		internal static string PROPERTY_VISIBILITY = "Visibility";

		// Token: 0x04000295 RID: 661
		internal static string PROPERTY_DRAWSELECTED = "DrawSelected";
	}
}
