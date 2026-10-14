using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B7 RID: 183
	public class SectionsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.SectionBase>
	{
		// Token: 0x06000A0F RID: 2575 RVA: 0x0002EB44 File Offset: 0x0002CD44
		internal SectionsCollection() : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Editors.SectionBase>())
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002EB51 File Offset: 0x0002CD51
		internal void Initialize(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			this.maskInfo = maskInfo;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002EB5A File Offset: 0x0002CD5A
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.maskInfo;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002EB62 File Offset: 0x0002CD62
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEditor
		{
			get
			{
				return this.maskInfo.MaskEditor;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002EB6F File Offset: 0x0002CD6F
		internal void Add(global::Infragistics.Windows.Editors.SectionBase section)
		{
			base.Items.Add(section);
			section.InitSectionsCollection(this);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002EB84 File Offset: 0x0002CD84
		private void CopyCharacterValues(global::Infragistics.Windows.Editors.DisplayCharsCollection dest, global::Infragistics.Windows.Editors.DisplayCharsCollection src)
		{
			for (int i = 0; i < src.Count; i++)
			{
				global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = dest[i];
				if (displayCharBase.IsEditable)
				{
					displayCharBase.Char = src[i].Char;
				}
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002EBC4 File Offset: 0x0002CDC4
		internal global::Infragistics.Windows.Editors.SectionsCollection Clone(global::Infragistics.Windows.Editors.MaskInfo maskInfo, bool copyDisplayCharacterValues)
		{
			global::Infragistics.Windows.Editors.SectionsCollection sectionsCollection = new global::Infragistics.Windows.Editors.SectionsCollection();
			sectionsCollection.Initialize(maskInfo);
			foreach (global::Infragistics.Windows.Editors.SectionBase sectionBase in this)
			{
				global::Infragistics.Windows.Editors.SectionBase sectionBase2 = sectionBase.InternalClone(sectionsCollection);
				sectionsCollection.Add(sectionBase2);
				if (copyDisplayCharacterValues)
				{
					this.CopyCharacterValues(sectionBase2.DisplayChars, sectionBase.DisplayChars);
				}
			}
			return sectionsCollection;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0002EC38 File Offset: 0x0002CE38
		internal global::System.Collections.IEnumerable AllDisplayCharacters
		{
			get
			{
				return new global::Infragistics.Windows.Editors.SectionsCollection.AllDisplayCharacterEnumerable(this);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0002EC40 File Offset: 0x0002CE40
		internal global::System.IFormatProvider FormatProvider
		{
			get
			{
				if (this.maskInfo == null)
				{
					return global::System.Globalization.CultureInfo.CurrentCulture;
				}
				return this.maskInfo.FormatProvider;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0002EC5B File Offset: 0x0002CE5B
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureCalendar(this.FormatProvider);
			}
		}

		// Token: 0x040003A3 RID: 931
		private global::Infragistics.Windows.Editors.MaskInfo maskInfo;

		// Token: 0x040003A4 RID: 932
		internal bool _isCacheInvalid;

		// Token: 0x020000B8 RID: 184
		private class AllDisplayCharacterEnumerable : global::System.Collections.IEnumerable
		{
			// Token: 0x06000A19 RID: 2585 RVA: 0x0002EC68 File Offset: 0x0002CE68
			internal AllDisplayCharacterEnumerable(global::Infragistics.Windows.Editors.SectionsCollection sections)
			{
				this._sections = sections;
			}

			// Token: 0x06000A1A RID: 2586 RVA: 0x0002EC77 File Offset: 0x0002CE77
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Windows.Editors.SectionsCollection.AllDisplayCharacterEnumerator(this._sections);
			}

			// Token: 0x040003A5 RID: 933
			private global::Infragistics.Windows.Editors.SectionsCollection _sections;
		}

		// Token: 0x020000B9 RID: 185
		private class AllDisplayCharacterEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000A1B RID: 2587 RVA: 0x0002EC84 File Offset: 0x0002CE84
			internal AllDisplayCharacterEnumerator(global::Infragistics.Windows.Editors.SectionsCollection sections)
			{
				this._sections = sections;
			}

			// Token: 0x06000A1C RID: 2588 RVA: 0x0002EC93 File Offset: 0x0002CE93
			public void Reset()
			{
				this._current = null;
			}

			// Token: 0x06000A1D RID: 2589 RVA: 0x0002EC9C File Offset: 0x0002CE9C
			public bool MoveNext()
			{
				if (this._current == null)
				{
					this._current = ((this._sections != null && this._sections.Count > 0) ? this._sections[0].FirstDisplayChar : null);
				}
				else
				{
					this._current = this._current.NextDisplayChar;
				}
				return null != this._current;
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002ED00 File Offset: 0x0002CF00
			public object Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x040003A6 RID: 934
			private global::Infragistics.Windows.Editors.SectionsCollection _sections;

			// Token: 0x040003A7 RID: 935
			private global::Infragistics.Windows.Editors.DisplayCharBase _current;
		}
	}
}
