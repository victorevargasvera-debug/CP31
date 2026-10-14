using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001B RID: 27
	public class DisplayCharsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.DisplayCharBase>
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000045C0 File Offset: 0x000027C0
		internal DisplayCharsCollection() : this(null)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000045C9 File Offset: 0x000027C9
		internal DisplayCharsCollection(global::Infragistics.Controls.Editors.SectionBase section) : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Editors.DisplayCharBase>())
		{
			this.section = section;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000045DD File Offset: 0x000027DD
		public global::Infragistics.Controls.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000045E5 File Offset: 0x000027E5
		internal void Add(global::Infragistics.Controls.Editors.DisplayCharBase displayChar)
		{
			base.Items.Add(displayChar);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000045F3 File Offset: 0x000027F3
		internal void Insert(int index, global::Infragistics.Controls.Editors.DisplayCharBase displayChar)
		{
			base.Items.Insert(index, displayChar);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004604 File Offset: 0x00002804
		internal global::Infragistics.Controls.Editors.DisplayCharsCollection InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayCharsCollection = new global::Infragistics.Controls.Editors.DisplayCharsCollection(section);
			for (int i = 0; i < base.Count; i++)
			{
				displayCharsCollection.Add(base[i].InternalClone(section));
			}
			return displayCharsCollection;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000463D File Offset: 0x0000283D
		internal void Clear()
		{
			base.Items.Clear();
		}

		// Token: 0x04000053 RID: 83
		private global::Infragistics.Controls.Editors.SectionBase section;
	}
}
