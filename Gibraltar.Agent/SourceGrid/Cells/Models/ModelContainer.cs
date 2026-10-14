using System;
using DevAge.Collections;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003A5 RID: 933
	internal class ModelContainer
	{
		// Token: 0x06002B55 RID: 11093 RVA: 0x00091EA0 File Offset: 0x000900A0
		public virtual global::SourceGrid.Cells.Models.IModel FindModel(global::System.Type modelType)
		{
			if (typeof(global::SourceGrid.Cells.Models.IValueModel).IsAssignableFrom(modelType))
			{
				return this.m_ValueModel;
			}
			if (this.m_ModelList == null)
			{
				this.m_ModelList = new global::SourceGrid.Cells.Models.ModelContainer.ModelList();
			}
			return this.m_ModelList.GetByType(modelType);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00091EE0 File Offset: 0x000900E0
		public virtual void AddModel(global::SourceGrid.Cells.Models.IModel model)
		{
			global::System.Type type = model.GetType();
			if (typeof(global::SourceGrid.Cells.Models.IValueModel).IsAssignableFrom(type))
			{
				this.m_ValueModel = (global::SourceGrid.Cells.Models.IValueModel)model;
				return;
			}
			if (this.m_ModelList == null)
			{
				this.m_ModelList = new global::SourceGrid.Cells.Models.ModelContainer.ModelList();
			}
			this.m_ModelList.Add(model);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00091F3C File Offset: 0x0009013C
		public virtual void RemoveModel(global::SourceGrid.Cells.Models.IModel model)
		{
			if (object.ReferenceEquals(model, this.m_ValueModel))
			{
				this.m_ValueModel = null;
				return;
			}
			if (this.m_ModelList != null)
			{
				this.m_ModelList.Remove(model);
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x00091F70 File Offset: 0x00090170
		// (set) Token: 0x06002B59 RID: 11097 RVA: 0x00091F78 File Offset: 0x00090178
		public virtual global::SourceGrid.Cells.Models.IValueModel ValueModel
		{
			get
			{
				return this.m_ValueModel;
			}
			set
			{
				this.m_ValueModel = value;
			}
		}

		// Token: 0x04000E92 RID: 3730
		private global::SourceGrid.Cells.Models.ModelContainer.ModelList m_ModelList;

		// Token: 0x04000E93 RID: 3731
		private global::SourceGrid.Cells.Models.IValueModel m_ValueModel;

		// Token: 0x020004D4 RID: 1236
		public class ModelList : global::DevAge.Collections.ListByType<global::SourceGrid.Cells.Models.IModel>
		{
		}
	}
}
