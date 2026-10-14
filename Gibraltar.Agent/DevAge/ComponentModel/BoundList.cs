using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevAge.ComponentModel
{
	// Token: 0x02000333 RID: 819
	internal class BoundList<T> : global::DevAge.ComponentModel.BoundListBase<T>
	{
		// Token: 0x0600267E RID: 9854 RVA: 0x000855C8 File Offset: 0x000837C8
		public BoundList(global::System.Collections.Generic.IList<T> list)
		{
			this.mList = list;
			base.AllowNew = true;
			base.AllowDelete = true;
			base.AllowEdit = true;
			base.AllowSort = (this.mList is global::System.Collections.Generic.List<T>);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00085610 File Offset: 0x00083810
		protected override T OnAddNew()
		{
			T t = global::System.Activator.CreateInstance<T>();
			this.mList.Add(t);
			return t;
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00085634 File Offset: 0x00083834
		public override int IndexOf(object item)
		{
			return this.mList.IndexOf((T)((object)item));
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00085648 File Offset: 0x00083848
		protected override void OnRemoveAt(int index)
		{
			this.mList.RemoveAt(index);
		}

		// Token: 0x17000BE7 RID: 3047
		public override object this[int index]
		{
			get
			{
				return this.mList[index];
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x0008566C File Offset: 0x0008386C
		public override int Count
		{
			get
			{
				return this.mList.Count;
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0008567C File Offset: 0x0008387C
		public override void ApplySort(global::System.ComponentModel.ListSortDescriptionCollection sorts)
		{
			global::System.Collections.Generic.List<T> list = this.mList as global::System.Collections.Generic.List<T>;
			if (list == null)
			{
				throw new global::DevAge.DevAgeApplicationException("Sort not supported, the list must be an instance of List<T>.");
			}
			list.Sort(delegate(T x, T y)
			{
				foreach (object obj in ((global::System.Collections.IEnumerable)sorts))
				{
					global::System.ComponentModel.ListSortDescription listSortDescription = (global::System.ComponentModel.ListSortDescription)obj;
					global::System.IComparable comparable = listSortDescription.PropertyDescriptor.GetValue(x) as global::System.IComparable;
					global::System.IComparable comparable2 = listSortDescription.PropertyDescriptor.GetValue(y) as global::System.IComparable;
					if (listSortDescription.SortDirection == global::System.ComponentModel.ListSortDirection.Descending)
					{
						global::System.IComparable comparable3 = comparable;
						comparable = comparable2;
						comparable2 = comparable3;
					}
					if (comparable != null && comparable2 != null)
					{
						int num = comparable.CompareTo(comparable2);
						if (num != 0)
						{
							return num;
						}
					}
					else
					{
						if (comparable != null)
						{
							return 1;
						}
						return -1;
					}
				}
				return 0;
			});
			this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.Reset, -1));
		}

		// Token: 0x04000D96 RID: 3478
		private global::System.Collections.Generic.IList<T> mList;
	}
}
