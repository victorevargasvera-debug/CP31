using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A1 RID: 161
	public abstract class SectionBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x00028DEC File Offset: 0x00026FEC
		internal SectionBase()
		{
			this._displayChars = new global::Infragistics.Windows.Editors.DisplayCharsCollection(this);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00028E07 File Offset: 0x00027007
		internal void InitSectionsCollection(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentNullException_69"));
			}
			this.sections = sections;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00028E23 File Offset: 0x00027023
		public global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return this.sections;
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00028E2C File Offset: 0x0002702C
		internal virtual void SetFilterToAllChars(global::Infragistics.Windows.Editors.FilterType filter)
		{
			for (int i = 0; i < this.DisplayChars.Count; i++)
			{
				this.DisplayChars[i].FilterType = filter;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00028E61 File Offset: 0x00027061
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.DisplayCharsCollection DisplayChars
		{
			get
			{
				return this._displayChars;
			}
		}

		// Token: 0x060008BC RID: 2236
		public abstract bool ValidateString(ref string str);

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00028E6C File Offset: 0x0002706C
		internal int Index
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection = this.Sections;
				int count = sectionsCollection.Count;
				if (this.index >= 0 && this.index < count && this == sectionsCollection[this.index])
				{
					return this.index;
				}
				this.index = sectionsCollection.IndexOf(this);
				return this.index;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00028EC2 File Offset: 0x000270C2
		public virtual global::Infragistics.Windows.Editors.SectionBase PreviousSection
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00028EE4 File Offset: 0x000270E4
		public virtual global::Infragistics.Windows.Editors.LiteralSection PreviousLiteralSection
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase previousSection = this.PreviousSection;
				if (previousSection == null)
				{
					return null;
				}
				if (previousSection is global::Infragistics.Windows.Editors.LiteralSection)
				{
					return (global::Infragistics.Windows.Editors.LiteralSection)previousSection;
				}
				return previousSection.PreviousLiteralSection;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00028F14 File Offset: 0x00027114
		public virtual global::Infragistics.Windows.Editors.SectionBase NextSection
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00028F48 File Offset: 0x00027148
		public virtual global::Infragistics.Windows.Editors.EditSectionBase PreviousEditSection
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase previousSection = this.PreviousSection;
				if (previousSection == null)
				{
					return null;
				}
				if (previousSection is global::Infragistics.Windows.Editors.EditSectionBase)
				{
					return (global::Infragistics.Windows.Editors.EditSectionBase)previousSection;
				}
				return previousSection.PreviousEditSection;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00028F76 File Offset: 0x00027176
		internal global::Infragistics.Windows.Editors.DisplayCharBase FirstDisplayChar
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00028F94 File Offset: 0x00027194
		internal global::Infragistics.Windows.Editors.DisplayCharBase LastDisplayChar
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00028FC0 File Offset: 0x000271C0
		public virtual global::Infragistics.Windows.Editors.EditSectionBase NextEditSection
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase nextSection = this.NextSection;
				if (nextSection == null)
				{
					return null;
				}
				if (nextSection is global::Infragistics.Windows.Editors.EditSectionBase)
				{
					return (global::Infragistics.Windows.Editors.EditSectionBase)nextSection;
				}
				return nextSection.NextEditSection;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00028FF0 File Offset: 0x000271F0
		public virtual global::Infragistics.Windows.Editors.LiteralSection NextLiteralSection
		{
			get
			{
				global::Infragistics.Windows.Editors.SectionBase nextSection = this.NextSection;
				if (nextSection == null)
				{
					return null;
				}
				if (nextSection is global::Infragistics.Windows.Editors.LiteralSection)
				{
					return (global::Infragistics.Windows.Editors.LiteralSection)nextSection;
				}
				return nextSection.NextLiteralSection;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0002901E File Offset: 0x0002721E
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEdit
		{
			get
			{
				return this.Sections.MaskedEditor;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0002902B File Offset: 0x0002722B
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Sections.MaskInfo;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00029038 File Offset: 0x00027238
		internal char DecimalSeperatorChar
		{
			get
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
				if (maskInfo != null)
				{
					return maskInfo.DecimalSeperatorChar;
				}
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar('.', null, false);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00029060 File Offset: 0x00027260
		internal char PlusSignChar
		{
			get
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
				if (maskInfo != null)
				{
					return maskInfo.PlusSignChar;
				}
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar('+', null, false);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00029088 File Offset: 0x00027288
		internal char MinusSignChar
		{
			get
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
				if (maskInfo != null)
				{
					return maskInfo.MinusSignChar;
				}
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar('-', null, false);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000290B0 File Offset: 0x000272B0
		internal bool IsAllSpaces()
		{
			foreach (global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase in this.DisplayChars)
			{
				if (' ' != displayCharBase.Char)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00029108 File Offset: 0x00027308
		internal char CommaChar
		{
			get
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = this.MaskInfo;
				if (maskInfo != null)
				{
					return maskInfo.CommaChar;
				}
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureChar(',', null, false);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00029130 File Offset: 0x00027330
		public string GetText()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals);
			if (text == null)
			{
				return "";
			}
			return text;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00029150 File Offset: 0x00027350
		internal virtual string GetText(global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayChars = this.DisplayChars;
			if (displayChars == null || displayChars.Count <= 0)
			{
				return null;
			}
			int count = displayChars.Count;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1 + count);
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = displayChars[i];
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

		// Token: 0x060008CF RID: 2255 RVA: 0x000291B8 File Offset: 0x000273B8
		internal virtual void InternalCopy(global::Infragistics.Windows.Editors.SectionBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_2"), "dest");
			}
			if (dest._displayChars == null || dest._displayChars.Count <= 0)
			{
				dest._displayChars = this._displayChars.InternalClone(dest);
			}
		}

		// Token: 0x060008D0 RID: 2256
		internal abstract global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections);

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00029215 File Offset: 0x00027415
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x0002921D File Offset: 0x0002741D
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00029226 File Offset: 0x00027426
		internal bool IsDateSection
		{
			get
			{
				return this is global::Infragistics.Windows.Editors.DaySection || this is global::Infragistics.Windows.Editors.MonthSection || this is global::Infragistics.Windows.Editors.YearSection;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00029243 File Offset: 0x00027443
		internal bool IsTimeSection
		{
			get
			{
				return this is global::Infragistics.Windows.Editors.SecondSection || this is global::Infragistics.Windows.Editors.MinuteSection || this is global::Infragistics.Windows.Editors.HourSection || this is global::Infragistics.Windows.Editors.AMPMSection;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00029268 File Offset: 0x00027468
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return this.Sections.Calendar;
			}
		}

		// Token: 0x04000350 RID: 848
		private global::Infragistics.Windows.Editors.SectionsCollection sections;

		// Token: 0x04000351 RID: 849
		private global::Infragistics.Windows.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x04000352 RID: 850
		private int index = -1;

		// Token: 0x04000353 RID: 851
		private bool isDateSeperatorSection;
	}
}
