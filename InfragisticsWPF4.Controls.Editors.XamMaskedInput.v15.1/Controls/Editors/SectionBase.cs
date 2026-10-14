using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000033 RID: 51
	public abstract class SectionBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0000BD0C File Offset: 0x00009F0C
		internal SectionBase()
		{
			this._displayChars = new global::Infragistics.Controls.Editors.DisplayCharsCollection(this);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000BD27 File Offset: 0x00009F27
		internal void InitSectionsCollection(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			if (sections == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentNullException_69"));
			}
			this.sections = sections;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000BD43 File Offset: 0x00009F43
		public global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				return this.sections;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000BD4C File Offset: 0x00009F4C
		internal virtual void SetFilterToAllChars(global::Infragistics.Controls.Editors.FilterType filter)
		{
			for (int i = 0; i < this.DisplayChars.Count; i++)
			{
				this.DisplayChars[i].FilterType = filter;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000BD81 File Offset: 0x00009F81
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Controls.Editors.DisplayCharsCollection DisplayChars
		{
			get
			{
				return this._displayChars;
			}
		}

		// Token: 0x0600019F RID: 415
		public abstract bool ValidateString(ref string str);

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000BD8C File Offset: 0x00009F8C
		internal int Index
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection = this.Sections;
				int count = sectionsCollection.Count;
				if (this.index >= 0 && this.index < count && this == sectionsCollection[this.index])
				{
					return this.index;
				}
				this.index = sectionsCollection.IndexOf(this);
				return this.index;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000BDE2 File Offset: 0x00009FE2
		public virtual global::Infragistics.Controls.Editors.SectionBase PreviousSection
		{
			get
			{
				if (this.Index <= 0)
				{
					return null;
				}
				return this.Sections[this.Index - 1];
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000BE04 File Offset: 0x0000A004
		public virtual global::Infragistics.Controls.Editors.LiteralSection PreviousLiteralSection
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase previousSection = this.PreviousSection;
				if (previousSection == null)
				{
					return null;
				}
				if (previousSection is global::Infragistics.Controls.Editors.LiteralSection)
				{
					return (global::Infragistics.Controls.Editors.LiteralSection)previousSection;
				}
				return previousSection.PreviousLiteralSection;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000BE34 File Offset: 0x0000A034
		public virtual global::Infragistics.Controls.Editors.SectionBase NextSection
		{
			get
			{
				int num = this.Index;
				if (1 + num < this.Sections.Count)
				{
					return this.Sections[1 + num];
				}
				return null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000BE68 File Offset: 0x0000A068
		public virtual global::Infragistics.Controls.Editors.EditSectionBase PreviousEditSection
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase previousSection = this.PreviousSection;
				if (previousSection == null)
				{
					return null;
				}
				if (previousSection is global::Infragistics.Controls.Editors.EditSectionBase)
				{
					return (global::Infragistics.Controls.Editors.EditSectionBase)previousSection;
				}
				return previousSection.PreviousEditSection;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000BE96 File Offset: 0x0000A096
		internal global::Infragistics.Controls.Editors.DisplayCharBase FirstDisplayChar
		{
			get
			{
				if (this.DisplayChars.Count <= 0)
				{
					return null;
				}
				return this.DisplayChars[0];
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		internal global::Infragistics.Controls.Editors.DisplayCharBase LastDisplayChar
		{
			get
			{
				if (this.DisplayChars.Count <= 0)
				{
					return null;
				}
				return this.DisplayChars[this.DisplayChars.Count - 1];
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public virtual global::Infragistics.Controls.Editors.EditSectionBase NextEditSection
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase nextSection = this.NextSection;
				if (nextSection == null)
				{
					return null;
				}
				if (nextSection is global::Infragistics.Controls.Editors.EditSectionBase)
				{
					return (global::Infragistics.Controls.Editors.EditSectionBase)nextSection;
				}
				return nextSection.NextEditSection;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000BF10 File Offset: 0x0000A110
		public virtual global::Infragistics.Controls.Editors.LiteralSection NextLiteralSection
		{
			get
			{
				global::Infragistics.Controls.Editors.SectionBase nextSection = this.NextSection;
				if (nextSection == null)
				{
					return null;
				}
				if (nextSection is global::Infragistics.Controls.Editors.LiteralSection)
				{
					return (global::Infragistics.Controls.Editors.LiteralSection)nextSection;
				}
				return nextSection.NextLiteralSection;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000BF3E File Offset: 0x0000A13E
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedEdit
		{
			get
			{
				return this.Sections.MaskedInput;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000BF4B File Offset: 0x0000A14B
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Sections.MaskInfo;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000BF58 File Offset: 0x0000A158
		internal char DecimalSeperatorChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('.', this.MaskInfo);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000BF67 File Offset: 0x0000A167
		internal char PlusSignChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('+', this.MaskInfo);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000BF76 File Offset: 0x0000A176
		internal char MinusSignChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('-', this.MaskInfo);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000BF88 File Offset: 0x0000A188
		internal bool IsAllSpaces()
		{
			foreach (global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase in this.DisplayChars)
			{
				if (' ' != displayCharBase.Char)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		internal char CommaChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(',', this.MaskInfo);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		public string GetText()
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals);
			if (text == null)
			{
				return "";
			}
			return text;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000C010 File Offset: 0x0000A210
		internal virtual string GetText(global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayChars = this.DisplayChars;
			if (displayChars == null || displayChars.Count <= 0)
			{
				return null;
			}
			int count = displayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1 + count);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = displayChars[i];
				if (displayCharBase != null)
				{
					char @char = displayCharBase.GetChar(maskMode);
					if (@char != '\0')
					{
						stringBuilder.Append(@char);
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000C078 File Offset: 0x0000A278
		internal virtual void InternalCopy(global::Infragistics.Controls.Editors.SectionBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_2"), "dest");
			}
			dest.isDateSeperatorSection = this.isDateSeperatorSection;
			if (dest._displayChars == null || dest._displayChars.Count <= 0)
			{
				dest._displayChars = this._displayChars.InternalClone(dest);
			}
		}

		// Token: 0x060001B3 RID: 435
		internal abstract global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections);

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000C0E9 File Offset: 0x0000A2E9
		internal bool IsDateTimeSeperatorSection
		{
			get
			{
				return this.isDateSeperatorSection;
			}
			set
			{
				this.isDateSeperatorSection = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000C0F2 File Offset: 0x0000A2F2
		internal bool IsDateSection
		{
			get
			{
				return this is global::Infragistics.Controls.Editors.DaySection || this is global::Infragistics.Controls.Editors.MonthSection || this is global::Infragistics.Controls.Editors.YearSection;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000C10F File Offset: 0x0000A30F
		internal bool IsTimeSection
		{
			get
			{
				return this is global::Infragistics.Controls.Editors.SecondSection || this is global::Infragistics.Controls.Editors.MinuteSection || this is global::Infragistics.Controls.Editors.HourSection || this is global::Infragistics.Controls.Editors.AMPMSection;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000C134 File Offset: 0x0000A334
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return this.Sections.Calendar;
			}
		}

		// Token: 0x040000D0 RID: 208
		private global::Infragistics.Controls.Editors.SectionsCollection sections;

		// Token: 0x040000D1 RID: 209
		private global::Infragistics.Controls.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x040000D2 RID: 210
		private int index = -1;

		// Token: 0x040000D3 RID: 211
		private bool isDateSeperatorSection;
	}
}
