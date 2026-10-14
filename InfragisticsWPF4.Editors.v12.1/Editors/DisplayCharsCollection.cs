using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000084 RID: 132
	public class DisplayCharsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.DisplayCharBase>
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x000202F0 File Offset: 0x0001E4F0
		internal DisplayCharsCollection() : this(null)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000202F9 File Offset: 0x0001E4F9
		internal DisplayCharsCollection(global::Infragistics.Windows.Editors.SectionBase section) : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Editors.DisplayCharBase>())
		{
			this.section = section;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0002030D File Offset: 0x0001E50D
		public global::Infragistics.Windows.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00020315 File Offset: 0x0001E515
		internal void Add(global::Infragistics.Windows.Editors.DisplayCharBase displayChar)
		{
			base.Items.Add(displayChar);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00020323 File Offset: 0x0001E523
		internal void Insert(int index, global::Infragistics.Windows.Editors.DisplayCharBase displayChar)
		{
			base.Items.Insert(index, displayChar);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00020334 File Offset: 0x0001E534
		internal global::Infragistics.Windows.Editors.DisplayCharsCollection InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayCharsCollection = new global::Infragistics.Windows.Editors.DisplayCharsCollection(section);
			for (int i = 0; i < base.Count; i++)
			{
				displayCharsCollection.Add(base[i].InternalClone(section));
			}
			return displayCharsCollection;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0002036D File Offset: 0x0001E56D
		internal void Clear()
		{
			base.Items.Clear();
		}

		// Token: 0x0400029F RID: 671
		private global::Infragistics.Windows.Editors.SectionBase section;
	}
}
