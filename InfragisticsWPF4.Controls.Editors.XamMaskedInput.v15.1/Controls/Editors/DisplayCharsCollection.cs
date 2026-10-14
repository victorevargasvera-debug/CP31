using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001A RID: 26
	public class DisplayCharsCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.DisplayCharBase>
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003F9C File Offset: 0x0000219C
		internal DisplayCharsCollection() : this(null)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003FA5 File Offset: 0x000021A5
		internal DisplayCharsCollection(global::Infragistics.Controls.Editors.SectionBase section) : base(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Editors.DisplayCharBase>())
		{
			this.section = section;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003FB9 File Offset: 0x000021B9
		public global::Infragistics.Controls.Editors.SectionBase Section
		{
			get
			{
				return this.section;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003FC1 File Offset: 0x000021C1
		internal void Add(global::Infragistics.Controls.Editors.DisplayCharBase displayChar)
		{
			base.Items.Add(displayChar);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003FCF File Offset: 0x000021CF
		internal void Insert(int index, global::Infragistics.Controls.Editors.DisplayCharBase displayChar)
		{
			base.Items.Insert(index, displayChar);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003FE0 File Offset: 0x000021E0
		internal global::Infragistics.Controls.Editors.DisplayCharsCollection InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.DisplayCharsCollection displayCharsCollection = new global::Infragistics.Controls.Editors.DisplayCharsCollection(section);
			for (int i = 0; i < base.Count; i++)
			{
				displayCharsCollection.Add(base[i].InternalClone(section));
			}
			return displayCharsCollection;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004019 File Offset: 0x00002219
		internal void Clear()
		{
			base.Items.Clear();
		}

		// Token: 0x04000055 RID: 85
		private global::Infragistics.Controls.Editors.SectionBase section;
	}
}
