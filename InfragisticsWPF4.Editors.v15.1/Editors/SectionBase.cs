using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A8 RID: 168
	public abstract class SectionBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		internal SectionBase()
		{
			this._displayChars = new global::Infragistics.Windows.Editors.DisplayCharsCollection(this);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0002ADE3 File Offset: 0x00028FE3
		internal void InitSectionsCollection(global::Infragistics.Windows.Editors.SectionsCollection sections)
		{
			if (sections == null)
			{
				throw new global::System.ArgumentNullException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentNullException_69"));
			}
			this.sections = sections;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002ADFF File Offset: 0x00028FFF
		public global::Infragistics.Windows.Editors.SectionsCollection Sections
		{
			get
			{
				return this.sections;
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0002AE08 File Offset: 0x00029008
		internal virtual void SetFilterToAllChars(global::Infragistics.Windows.Editors.FilterType filter)
		{
			for (int i = 0; i < this.DisplayChars.Count; i++)
			{
				this.DisplayChars[i].FilterType = filter;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002AE3D File Offset: 0x0002903D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Editors.DisplayCharsCollection DisplayChars
		{
			get
			{
				return this._displayChars;
			}
		}

		// Token: 0x0600092A RID: 2346
		public abstract bool ValidateString(ref string str);

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0002AE48 File Offset: 0x00029048
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002AE9E File Offset: 0x0002909E
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

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0002AEC0 File Offset: 0x000290C0
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002AEF0 File Offset: 0x000290F0
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002AF24 File Offset: 0x00029124
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

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002AF52 File Offset: 0x00029152
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0002AF70 File Offset: 0x00029170
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002AF9C File Offset: 0x0002919C
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0002AFCC File Offset: 0x000291CC
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002AFFA File Offset: 0x000291FA
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEdit
		{
			get
			{
				return this.Sections.MaskedEditor;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0002B007 File Offset: 0x00029207
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.Sections.MaskInfo;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002B014 File Offset: 0x00029214
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002B03C File Offset: 0x0002923C
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002B064 File Offset: 0x00029264
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

		// Token: 0x06000939 RID: 2361 RVA: 0x0002B08C File Offset: 0x0002928C
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

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002B0E4 File Offset: 0x000292E4
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

		// Token: 0x0600093B RID: 2363 RVA: 0x0002B10C File Offset: 0x0002930C
		public string GetText()
		{
			string text = this.GetText(global::Infragistics.Windows.Editors.MaskMode.IncludeLiterals);
			if (text == null)
			{
				return "";
			}
			return text;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0002B12C File Offset: 0x0002932C
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

		// Token: 0x0600093D RID: 2365 RVA: 0x0002B194 File Offset: 0x00029394
		internal virtual void InternalCopy(global::Infragistics.Windows.Editors.SectionBase dest)
		{
			if (base.GetType() != dest.GetType())
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_2"), "dest");
			}
			dest.isDateSeperatorSection = this.isDateSeperatorSection;
			if (dest._displayChars == null || dest._displayChars.Count <= 0)
			{
				dest._displayChars = this._displayChars.InternalClone(dest);
			}
		}

		// Token: 0x0600093E RID: 2366
		internal abstract global::Infragistics.Windows.Editors.SectionBase InternalClone(global::Infragistics.Windows.Editors.SectionsCollection sections);

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002B1FD File Offset: 0x000293FD
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0002B205 File Offset: 0x00029405
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

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002B20E File Offset: 0x0002940E
		internal bool IsDateSection
		{
			get
			{
				return this is global::Infragistics.Windows.Editors.DaySection || this is global::Infragistics.Windows.Editors.MonthSection || this is global::Infragistics.Windows.Editors.YearSection;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0002B22B File Offset: 0x0002942B
		internal bool IsTimeSection
		{
			get
			{
				return this is global::Infragistics.Windows.Editors.SecondSection || this is global::Infragistics.Windows.Editors.MinuteSection || this is global::Infragistics.Windows.Editors.HourSection || this is global::Infragistics.Windows.Editors.AMPMSection;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0002B250 File Offset: 0x00029450
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return this.Sections.Calendar;
			}
		}

		// Token: 0x04000387 RID: 903
		private global::Infragistics.Windows.Editors.SectionsCollection sections;

		// Token: 0x04000388 RID: 904
		private global::Infragistics.Windows.Editors.DisplayCharsCollection _displayChars;

		// Token: 0x04000389 RID: 905
		private int index = -1;

		// Token: 0x0400038A RID: 906
		private bool isDateSeperatorSection;
	}
}
