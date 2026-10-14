using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200008A RID: 138
	public class DisplayCharsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.DisplayCharBase>
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x00021D58 File Offset: 0x0001FF58
		internal DisplayCharsCollection() : this(null)
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00021D61 File Offset: 0x0001FF61
		internal DisplayCharsCollection(global::Infragistics.Windows.Editors.SectionBase section) : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Editors.DisplayCharBase>())
		{
			this.section = section;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00021D75 File Offset: 0x0001FF75
		public global::Infragistics.Windows.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00021D7D File Offset: 0x0001FF7D
		internal void Add(global::Infragistics.Windows.Editors.DisplayCharBase displayChar)
		{
			base.Items.Add(displayChar);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00021D8B File Offset: 0x0001FF8B
		internal void Insert(int index, global::Infragistics.Windows.Editors.DisplayCharBase displayChar)
		{
			base.Items.Insert(index, displayChar);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00021D9C File Offset: 0x0001FF9C
		internal global::Infragistics.Windows.Editors.DisplayCharsCollection InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.DisplayCharsCollection displayCharsCollection = new global::Infragistics.Windows.Editors.DisplayCharsCollection(section);
			for (int i = 0; i < base.Count; i++)
			{
				displayCharsCollection.Add(base[i].InternalClone(section));
			}
			return displayCharsCollection;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00021DD5 File Offset: 0x0001FFD5
		internal void Clear()
		{
			base.Items.Clear();
		}

		// Token: 0x040002D2 RID: 722
		private global::Infragistics.Windows.Editors.SectionBase section;
	}
}
