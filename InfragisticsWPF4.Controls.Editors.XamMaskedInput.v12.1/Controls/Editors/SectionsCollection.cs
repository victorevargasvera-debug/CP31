using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000043 RID: 67
	public class SectionsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.SectionBase>
	{
		// Token: 0x06000285 RID: 645 RVA: 0x0000FC88 File Offset: 0x0000DE88
		internal SectionsCollection() : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Editors.SectionBase>())
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000FC95 File Offset: 0x0000DE95
		internal void Initialize(global::Infragistics.Controls.Editors.MaskInfo maskInfo)
		{
			this.maskInfo = maskInfo;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000FC9E File Offset: 0x0000DE9E
		internal global::Infragistics.Controls.Editors.MaskInfo MaskInfo
		{
			get
			{
				return this.maskInfo;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000FCA6 File Offset: 0x0000DEA6
		internal global::Infragistics.Controls.Editors.XamMaskedInput MaskedInput
		{
			get
			{
				return this.maskInfo.MaskedInput;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000FCB3 File Offset: 0x0000DEB3
		internal void Add(global::Infragistics.Controls.Editors.SectionBase section)
		{
			base.Items.Add(section);
			section.InitSectionsCollection(this);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
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

		// Token: 0x0600028B RID: 651 RVA: 0x0000FD08 File Offset: 0x0000DF08
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		internal global::System.Collections.IEnumerable AllDisplayCharacters
		{
			get
			{
				return new global::Infragistics.Controls.Editors.SectionsCollection.AllDisplayCharacterEnumerable(this);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000FD84 File Offset: 0x0000DF84
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000FD9F File Offset: 0x0000DF9F
		internal global::System.Globalization.Calendar Calendar
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureCalendar(this.FormatProvider);
			}
		}

		// Token: 0x040000E8 RID: 232
		private global::Infragistics.Controls.Editors.MaskInfo maskInfo;

		// Token: 0x040000E9 RID: 233
		internal bool _isCacheInvalid;

		// Token: 0x02000044 RID: 68
		private class AllDisplayCharacterEnumerable : global::System.Collections.IEnumerable
		{
			// Token: 0x0600028F RID: 655 RVA: 0x0000FDAC File Offset: 0x0000DFAC
			internal AllDisplayCharacterEnumerable(global::Infragistics.Controls.Editors.SectionsCollection sections)
			{
				this._sections = sections;
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0000FDBB File Offset: 0x0000DFBB
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Controls.Editors.SectionsCollection.AllDisplayCharacterEnumerator(this._sections);
			}

			// Token: 0x040000EA RID: 234
			private global::Infragistics.Controls.Editors.SectionsCollection _sections;
		}

		// Token: 0x02000045 RID: 69
		private class AllDisplayCharacterEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000291 RID: 657 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
			internal AllDisplayCharacterEnumerator(global::Infragistics.Controls.Editors.SectionsCollection sections)
			{
				this._sections = sections;
				this._sectionsCount = this._sections.Count;
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
			public void Reset()
			{
				this._current = null;
			}

			// Token: 0x06000293 RID: 659 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
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

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
			public object Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x040000EB RID: 235
			private global::Infragistics.Controls.Editors.SectionsCollection _sections;

			// Token: 0x040000EC RID: 236
			private int _sectionsCount;

			// Token: 0x040000ED RID: 237
			private global::Infragistics.Controls.Editors.DisplayCharBase _current;

			// Token: 0x040000EE RID: 238
			private global::Infragistics.Controls.Editors.DisplayCharsCollection _currentDisplayChars;

			// Token: 0x040000EF RID: 239
			private int _currentDisplayCharsCount;

			// Token: 0x040000F0 RID: 240
			private int _currentSectionIndex;

			// Token: 0x040000F1 RID: 241
			private int _currentDisplayCharIndex;
		}
	}
}
