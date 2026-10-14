using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000042 RID: 66
	public class SectionsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.SectionBase>
	{
		// Token: 0x06000285 RID: 645 RVA: 0x0000FA54 File Offset: 0x0000DC54
		internal SectionsCollection() : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Editors.SectionBase>())
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000FA61 File Offset: 0x0000DC61
		internal void Initialize(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			this.maskInfo = maskInfo;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000FA6A File Offset: 0x0000DC6A
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.maskInfo;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000FA72 File Offset: 0x0000DC72
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedInput
		{
			get
			{
				return this.maskInfo.MaskedInput;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000FA7F File Offset: 0x0000DC7F
		internal void Add(global::Infragistics.Controls.Editors.SectionBase section)
		{
			base.Items.Add(section);
			section.InitSectionsCollection(this);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000FA94 File Offset: 0x0000DC94
		private void CopyCharacterValues(global::Infragistics.Controls.Editors.DisplayCharsCollection dest, global::Infragistics.Controls.Editors.DisplayCharsCollection src)
		{
			for (int i = 0; i < src.Count; i++)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = dest[i];
				if (displayCharBase.IsEditable)
				{
					displayCharBase.Char = src[i].Char;
				}
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		internal global::Infragistics.Controls.Editors.SectionsCollection Clone(global::Infragistics.Controls.Editors.MaskInfo maskInfo, bool copyDisplayCharacterValues)
		{
			global::Infragistics.Controls.Editors.SectionsCollection sectionsCollection = new global::Infragistics.Controls.Editors.SectionsCollection();
			sectionsCollection.Initialize(maskInfo);
			foreach (global::Infragistics.Controls.Editors.SectionBase sectionBase in this)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase2 = sectionBase.InternalClone(sectionsCollection);
				sectionsCollection.Add(sectionBase2);
				if (copyDisplayCharacterValues)
				{
					this.CopyCharacterValues(sectionBase2.DisplayChars, sectionBase.DisplayChars);
				}
			}
			return sectionsCollection;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000FB48 File Offset: 0x0000DD48
		internal global::System.Collections.IEnumerable AllDisplayCharacters
		{
			get
			{
				return new global::Infragistics.Controls.Editors.SectionsCollection.AllDisplayCharacterEnumerable(this);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000FB50 File Offset: 0x0000DD50
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000FB6B File Offset: 0x0000DD6B
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetCultureCalendar(this.FormatProvider);
			}
		}

		// Token: 0x040000EC RID: 236
		private global::Infragistics.Controls.Editors.MaskInfo maskInfo;

		// Token: 0x040000ED RID: 237
		internal bool _isCacheInvalid;

		// Token: 0x02000043 RID: 67
		private class AllDisplayCharacterEnumerable : global::System.Collections.IEnumerable
		{
			// Token: 0x0600028F RID: 655 RVA: 0x0000FB78 File Offset: 0x0000DD78
			internal AllDisplayCharacterEnumerable(global::Infragistics.Controls.Editors.SectionsCollection sections)
			{
				this._sections = sections;
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0000FB87 File Offset: 0x0000DD87
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Controls.Editors.SectionsCollection.AllDisplayCharacterEnumerator(this._sections);
			}

			// Token: 0x040000EE RID: 238
			private global::Infragistics.Controls.Editors.SectionsCollection _sections;
		}

		// Token: 0x02000044 RID: 68
		private class AllDisplayCharacterEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000291 RID: 657 RVA: 0x0000FB94 File Offset: 0x0000DD94
			internal AllDisplayCharacterEnumerator(global::Infragistics.Controls.Editors.SectionsCollection sections)
			{
				this._sections = sections;
				this._sectionsCount = this._sections.Count;
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
			public void Reset()
			{
				this._current = null;
			}

			// Token: 0x06000293 RID: 659 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
			public bool MoveNext()
			{
				if (this._current == null)
				{
					this._currentSectionIndex = -1;
					this._currentDisplayCharsCount = 0;
				}
				for (;;)
				{
					this._currentDisplayCharIndex++;
					if (this._currentDisplayCharIndex < this._currentDisplayCharsCount)
					{
						break;
					}
					this._currentSectionIndex++;
					if (this._currentSectionIndex >= this._sectionsCount)
					{
						goto IL_A0;
					}
					this._currentDisplayChars = this._sections[this._currentSectionIndex].DisplayChars;
					this._currentDisplayCharsCount = this._currentDisplayChars.Count;
					this._currentDisplayCharIndex = -1;
				}
				this._current = this._currentDisplayChars[this._currentDisplayCharIndex];
				goto IL_A7;
				IL_A0:
				this._current = null;
				IL_A7:
				return null != this._current;
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000FC80 File Offset: 0x0000DE80
			public object Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x040000EF RID: 239
			private global::Infragistics.Controls.Editors.SectionsCollection _sections;

			// Token: 0x040000F0 RID: 240
			private int _sectionsCount;

			// Token: 0x040000F1 RID: 241
			private global::Infragistics.Controls.Editors.DisplayCharBase _current;

			// Token: 0x040000F2 RID: 242
			private global::Infragistics.Controls.Editors.DisplayCharsCollection _currentDisplayChars;

			// Token: 0x040000F3 RID: 243
			private int _currentDisplayCharsCount;

			// Token: 0x040000F4 RID: 244
			private int _currentSectionIndex;

			// Token: 0x040000F5 RID: 245
			private int _currentDisplayCharIndex;
		}
	}
}
