using System;
using System.ComponentModel;
using System.Text;

namespace Gibraltar
{
	// Token: 0x0200015F RID: 351
	[global::System.Serializable]
	internal class ListChangedEventArgsItemAdded<T> : global::System.ComponentModel.ListChangedEventArgs
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x000255F0 File Offset: 0x000237F0
		internal ListChangedEventArgsItemAdded(T item, int index) : base(global::System.ComponentModel.ListChangedType.ItemAdded, index, index)
		{
			this.Item = item;
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00025604 File Offset: 0x00023804
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0002560C File Offset: 0x0002380C
		public T Item { get; private set; }

		// Token: 0x06000EAA RID: 3754 RVA: 0x00025618 File Offset: 0x00023818
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			stringBuilder.AppendFormat("Change Type: {0} New Index: {1:N0} Old Index: {2:N0} Property Descriptor: {3}\r\n", new object[]
			{
				base.ListChangedType,
				base.NewIndex,
				base.OldIndex,
				base.PropertyDescriptor
			});
			if (this.Item == null)
			{
				stringBuilder.AppendFormat("{0} Item: (Null)", typeof(T));
			}
			else
			{
				stringBuilder.AppendFormat("{0} Item: {1}", typeof(T), this.Item);
			}
			return stringBuilder.ToString();
		}
	}
}
