using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B0 RID: 176
	public class SectionsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.SectionBase>
	{
		// Token: 0x060009A1 RID: 2465 RVA: 0x0002CB38 File Offset: 0x0002AD38
		internal SectionsCollection() : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Editors.SectionBase>())
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0002CB45 File Offset: 0x0002AD45
		internal void Initialize(global::Infragistics.Windows.Editors.MaskInfo maskInfo)
		{
			this.maskInfo = maskInfo;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0002CB4E File Offset: 0x0002AD4E
		internal global::Infragistics.Windows.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.maskInfo;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0002CB56 File Offset: 0x0002AD56
		internal global::Infragistics.Windows.Editors.XamMaskedEditor MaskedEditor
		{
			get
			{
				return this.maskInfo.MaskEditor;
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0002CB63 File Offset: 0x0002AD63
		internal void Add(global::Infragistics.Windows.Editors.SectionBase section)
		{
			base.Items.Add(section);
			section.InitSectionsCollection(this);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002CB78 File Offset: 0x0002AD78
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

		// Token: 0x060009A7 RID: 2471 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002CC2C File Offset: 0x0002AE2C
		internal global::System.Collections.IEnumerable AllDisplayCharacters
		{
			get
			{
				return new global::Infragistics.Windows.Editors.SectionsCollection.AllDisplayCharacterEnumerable(this);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0002CC34 File Offset: 0x0002AE34
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002CC4F File Offset: 0x0002AE4F
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return global::Infragistics.Windows.Editors.XamMaskedEditor.GetCultureCalendar(this.FormatProvider);
			}
		}

		// Token: 0x0400036C RID: 876
		private global::Infragistics.Windows.Editors.MaskInfo maskInfo;

		// Token: 0x0400036D RID: 877
		internal bool _isCacheInvalid;

		// Token: 0x020000B1 RID: 177
		private class AllDisplayCharacterEnumerable : global::System.Collections.IEnumerable
		{
			// Token: 0x060009AB RID: 2475 RVA: 0x0002CC5C File Offset: 0x0002AE5C
			internal AllDisplayCharacterEnumerable(global::Infragistics.Windows.Editors.SectionsCollection sections)
			{
				this._sections = sections;
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x0002CC6B File Offset: 0x0002AE6B
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Windows.Editors.SectionsCollection.AllDisplayCharacterEnumerator(this._sections);
			}

			// Token: 0x0400036E RID: 878
			private global::Infragistics.Windows.Editors.SectionsCollection _sections;
		}

		// Token: 0x020000B2 RID: 178
		private class AllDisplayCharacterEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060009AD RID: 2477 RVA: 0x0002CC78 File Offset: 0x0002AE78
			internal AllDisplayCharacterEnumerator(global::Infragistics.Windows.Editors.SectionsCollection sections)
			{
				this._sections = sections;
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x0002CC87 File Offset: 0x0002AE87
			public void Reset()
			{
				this._current = null;
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x0002CC90 File Offset: 0x0002AE90
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

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
			public object Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x0400036F RID: 879
			private global::Infragistics.Windows.Editors.SectionsCollection _sections;

			// Token: 0x04000370 RID: 880
			private global::Infragistics.Windows.Editors.DisplayCharBase _current;
		}
	}
}
