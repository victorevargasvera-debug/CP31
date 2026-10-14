using System;
using System.ComponentModel;

namespace DevAge.ComponentModel
{
	// Token: 0x020002EA RID: 746
	internal interface IBoundList
	{
		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060023DF RID: 9183
		// (set) Token: 0x060023E0 RID: 9184
		bool AllowDelete { get; set; }

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060023E1 RID: 9185
		// (set) Token: 0x060023E2 RID: 9186
		bool AllowEdit { get; set; }

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060023E3 RID: 9187
		// (set) Token: 0x060023E4 RID: 9188
		bool AllowNew { get; set; }

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060023E5 RID: 9189
		// (set) Token: 0x060023E6 RID: 9190
		bool AllowSort { get; set; }

		// Token: 0x060023E7 RID: 9191
		void ApplySort(global::System.ComponentModel.ListSortDescriptionCollection sorts);

		// Token: 0x060023E8 RID: 9192
		int BeginAddNew();

		// Token: 0x060023E9 RID: 9193
		void BeginEdit(int index);

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060023EA RID: 9194
		int Count { get; }

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060023EB RID: 9195
		object EditedObject { get; }

		// Token: 0x060023EC RID: 9196
		void EndEdit(bool cancel);

		// Token: 0x060023ED RID: 9197
		global::System.ComponentModel.PropertyDescriptorCollection GetItemProperties();

		// Token: 0x060023EE RID: 9198
		global::System.ComponentModel.PropertyDescriptor GetItemProperty(string name, global::System.StringComparison comparison);

		// Token: 0x060023EF RID: 9199
		object GetItemValue(int index, global::System.ComponentModel.PropertyDescriptor property);

		// Token: 0x060023F0 RID: 9200
		int IndexOf(object item);

		// Token: 0x1400009B RID: 155
		// (add) Token: 0x060023F1 RID: 9201
		// (remove) Token: 0x060023F2 RID: 9202
		event global::System.ComponentModel.ListChangedEventHandler ListChanged;

		// Token: 0x060023F3 RID: 9203
		void RemoveAt(int index);

		// Token: 0x060023F4 RID: 9204
		void SetEditValue(global::System.ComponentModel.PropertyDescriptor property, object value);

		// Token: 0x17000B56 RID: 2902
		object this[int index]
		{
			get;
		}
	}
}
