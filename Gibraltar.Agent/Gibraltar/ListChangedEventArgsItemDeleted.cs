using System;
using System.ComponentModel;

namespace Gibraltar
{
	// Token: 0x0200015E RID: 350
	[global::System.Serializable]
	internal class ListChangedEventArgsItemDeleted<T> : global::System.ComponentModel.ListChangedEventArgs
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x000255C8 File Offset: 0x000237C8
		internal ListChangedEventArgsItemDeleted(T item, int index) : base(global::System.ComponentModel.ListChangedType.ItemDeleted, index, index)
		{
			this.Item = item;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000255DC File Offset: 0x000237DC
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000255E4 File Offset: 0x000237E4
		public T Item { get; private set; }
	}
}
