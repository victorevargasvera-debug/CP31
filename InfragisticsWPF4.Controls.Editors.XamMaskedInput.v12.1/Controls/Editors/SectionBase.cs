using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000034 RID: 52
	public abstract class SectionBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0000BF6C File Offset: 0x0000A16C
		internal SectionBase()
		{
			this._displayChars = new global::Infragistics.Controls.Editors.DisplayCharsCollection(this);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000BF87 File Offset: 0x0000A187
		internal void InitSectionsCollection(global::Infragistics.Controls.Editors.SectionsCollection sections)
		{
			if (sections == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentNullException_69"));
			}
			this.sections = sections;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000BFA3 File Offset: 0x0000A1A3
		public global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				return this.sections;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000BFAC File Offset: 0x0000A1AC
		internal virtual void SetFilterToAllChars(global::Infragistics.Controls.Editors.FilterType filter)
		{
			for (int i = 0; i < this.DisplayChars.Count; i++)
			{
				this.DisplayChars[i].FilterType = filter;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000BFE1 File Offset: 0x0000A1E1
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000BFEC File Offset: 0x0000A1EC
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000C042 File Offset: 0x0000A242
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000C064 File Offset: 0x0000A264
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000C094 File Offset: 0x0000A294
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000C0F6 File Offset: 0x0000A2F6
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000C114 File Offset: 0x0000A314
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000C140 File Offset: 0x0000A340
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000C170 File Offset: 0x0000A370
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000C19E File Offset: 0x0000A39E
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedEdit
		{
			get
			{
				return this.Sections.MaskedInput;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000C1AB File Offset: 0x0000A3AB
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Sections.MaskInfo;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		internal char DecimalSeperatorChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('.', this.MaskInfo);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		internal char PlusSignChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('+', this.MaskInfo);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		internal char MinusSignChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('-', this.MaskInfo);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000C240 File Offset: 0x0000A440
		internal char CommaChar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(',', this.MaskInfo);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000C250 File Offset: 0x0000A450
		public string GetText()
		{
			string text = this.GetText(global::Infragistics.Controls.Editors.InputMaskMode.IncludeLiterals);
			if (text == null)
			{
				return "";
			}
			return text;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000C270 File Offset: 0x0000A470
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

		// Token: 0x060001B2 RID: 434 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		internal virtual void InternalCopy(global::Infragistics.Controls.Editors.SectionBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_2"), "dest");
			}
			if (dest._displayChars == null || dest._displayChars.Count <= 0)
			{
				dest._displayChars = this._displayChars.InternalClone(dest);
			}
		}

		// Token: 0x060001B3 RID: 435
		internal abstract global::Infragistics.Controls.Editors.SectionBase InternalClone(global::Infragistics.Controls.Editors.SectionsCollection sections);

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000C335 File Offset: 0x0000A535
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000C33D File Offset: 0x0000A53D
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000C346 File Offset: 0x0000A546
		internal bool IsDateSection
		{
			get
			{
				return this is global::Infragistics.Controls.Editors.DaySection || this is global::Infragistics.Controls.Editors.MonthSection || this is global::Infragistics.Controls.Editors.YearSection;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000C363 File Offset: 0x0000A563
		internal bool IsTimeSection
		{
			get
			{
				return this is global::Infragistics.Controls.Editors.SecondSection || this is global::Infragistics.Controls.Editors.MinuteSection || this is global::Infragistics.Controls.Editors.HourSection || this is global::Infragistics.Controls.Editors.AMPMSection;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000C388 File Offset: 0x0000A588
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return this.Sections.Calendar;
			}
		}

		// Token: 0x040000CC RID: 204
		private global::Infragistics.Controls.Editors.SectionsCollection sections;

		// Token: 0x040000CD RID: 205
		private global::Infragistics.Controls.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x040000CE RID: 206
		private int index = -1;

		// Token: 0x040000CF RID: 207
		private bool isDateSeperatorSection;
	}
}
