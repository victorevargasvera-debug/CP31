using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Infragistics
{
	// Token: 0x02000039 RID: 57
	internal sealed class FastItemObjectColumn : global::Infragistics.IFastItemColumnInternal, global::Infragistics.IFastItemColumn<object>, global::System.Collections.Generic.IList<object>, global::System.Collections.Generic.ICollection<object>, global::System.Collections.Generic.IEnumerable<object>, global::System.Collections.IEnumerable, global::Infragistics.IFastItemColumnPropertyName
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0000D82A File Offset: 0x0000BA2A
		internal FastItemObjectColumn(global::Infragistics.IFastItemsSource fastItemsSource, string propertyName)
		{
			this.PropertyName = propertyName;
			this.FastItemsSource = fastItemsSource;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000D840 File Offset: 0x0000BA40
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000D848 File Offset: 0x0000BA48
		[global::System.Runtime.CompilerServices.Weak]
		internal global::Infragistics.IFastItemsSource FastItemsSource
		{
			get
			{
				return this.fastItemsSource;
			}
			set
			{
				this.fastItemsSource = value;
				this.Reset();
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000D858 File Offset: 0x0000BA58
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000D860 File Offset: 0x0000BA60
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			private set
			{
				this._propertyName = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000D869 File Offset: 0x0000BA69
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000D871 File Offset: 0x0000BA71
		public object Minimum
		{
			get
			{
				return this._minimum;
			}
			private set
			{
				this._minimum = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000D87A File Offset: 0x0000BA7A
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000D882 File Offset: 0x0000BA82
		public object Maximum
		{
			get
			{
				return this._maximum;
			}
			private set
			{
				this._maximum = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		public object this[int index]
		{
			get
			{
				return this.Values[index];
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public global::System.Collections.Generic.IEnumerator<object> GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000D8B2 File Offset: 0x0000BAB2
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		public bool Contains(object item)
		{
			return this.Values.Contains(item);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000D8D2 File Offset: 0x0000BAD2
		public void CopyTo(object[] array, int arrayIndex)
		{
			this.Values.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000D8E1 File Offset: 0x0000BAE1
		public int Count
		{
			get
			{
				return this.Values.Count;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000D8EE File Offset: 0x0000BAEE
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000D8F1 File Offset: 0x0000BAF1
		public int IndexOf(object item)
		{
			return this.Values.IndexOf(item);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000D8FF File Offset: 0x0000BAFF
		public void Add(object item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000D906 File Offset: 0x0000BB06
		public void Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000D90D File Offset: 0x0000BB0D
		public bool Remove(object item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000D914 File Offset: 0x0000BB14
		public void Insert(int index, object item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000D91B File Offset: 0x0000BB1B
		public void RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000D922 File Offset: 0x0000BB22
		public bool Reset()
		{
			this.Values = null;
			return this.FastItemsSource == null || this.InsertRange(0, this.FastItemsSource.Count);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000D948 File Offset: 0x0000BB48
		public bool InsertRange(int position, int count)
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>
			{
				Capacity = count
			};
			for (int i = position; i < position + count; i++)
			{
				object item = this.ToObject(this.FastItemsSource[i]);
				list.Add(item);
			}
			if (this.Values == null)
			{
				this.Values = list;
			}
			else
			{
				this.Values.InsertRange(position, list);
			}
			return true;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		public bool ReplaceRange(int position, int count)
		{
			bool result = false;
			for (int i = 0; i < count; i++)
			{
				object obj = this.Values[position + i];
				object obj2 = this.ToObject(this.FastItemsSource[position + i]);
				if (obj != obj2)
				{
					this.Values[position + i] = obj2;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000DA01 File Offset: 0x0000BC01
		public bool RemoveRange(int position, int count)
		{
			this.Values.RemoveRange(position, count);
			return true;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000DA14 File Offset: 0x0000BC14
		private object ToObject(object item)
		{
			if (item == null)
			{
				return null;
			}
			if (this.fastReflectionHelper == null)
			{
				this.fastReflectionHelper = new global::Infragistics.FastReflectionHelper(false, this.PropertyName);
			}
			if (!this.fastReflectionHelper.Invalid)
			{
				item = this.fastReflectionHelper.GetPropertyValue(item.GetType(), item);
			}
			return item;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000DA62 File Offset: 0x0000BC62
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000DA6A File Offset: 0x0000BC6A
		private global::System.Collections.Generic.List<object> Values { get; set; }

		// Token: 0x06000340 RID: 832 RVA: 0x0000DA73 File Offset: 0x0000BC73
		internal global::System.Collections.Generic.List<int> GetSortedIndices()
		{
			return global::Infragistics.FastItemColumn.GetSortedIndices(this.Values);
		}

		// Token: 0x04000121 RID: 289
		[global::System.Runtime.CompilerServices.Weak]
		private global::Infragistics.IFastItemsSource fastItemsSource;

		// Token: 0x04000122 RID: 290
		[global::System.Runtime.CompilerServices.DontObfuscate]
		private string _propertyName;

		// Token: 0x04000123 RID: 291
		private object _minimum;

		// Token: 0x04000124 RID: 292
		private object _maximum;

		// Token: 0x04000125 RID: 293
		private global::Infragistics.FastReflectionHelper fastReflectionHelper;
	}
}
