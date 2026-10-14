using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200003A RID: 58
	internal sealed class FastItemIntColumn : global::Infragistics.IFastItemColumnInternal, global::Infragistics.IFastItemColumn<int>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.ICollection<int>, global::System.Collections.Generic.IEnumerable<int>, global::System.Collections.IEnumerable, global::Infragistics.IFastItemColumnPropertyName
	{
		// Token: 0x06000341 RID: 833 RVA: 0x0000DA80 File Offset: 0x0000BC80
		internal FastItemIntColumn(global::Infragistics.IFastItemsSource fastItemsSource, string propertyName)
		{
			this.PropertyName = propertyName;
			this.FastItemsSource = fastItemsSource;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000DA96 File Offset: 0x0000BC96
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0000DA9E File Offset: 0x0000BC9E
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000DAAE File Offset: 0x0000BCAE
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0000DAB6 File Offset: 0x0000BCB6
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000DABF File Offset: 0x0000BCBF
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000DAC7 File Offset: 0x0000BCC7
		public int Minimum
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		public int Maximum
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

		// Token: 0x170000D0 RID: 208
		public int this[int index]
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

		// Token: 0x0600034C RID: 844 RVA: 0x0000DAF6 File Offset: 0x0000BCF6
		public global::System.Collections.Generic.IEnumerator<int> GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000DB08 File Offset: 0x0000BD08
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000DB1A File Offset: 0x0000BD1A
		public bool Contains(int item)
		{
			return this.Values.Contains(item);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000DB28 File Offset: 0x0000BD28
		public void CopyTo(int[] array, int arrayIndex)
		{
			this.Values.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000DB37 File Offset: 0x0000BD37
		public int Count
		{
			get
			{
				return this.Values.Count;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000DB44 File Offset: 0x0000BD44
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000DB47 File Offset: 0x0000BD47
		public int IndexOf(int item)
		{
			return this.Values.IndexOf(item);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000DB55 File Offset: 0x0000BD55
		public void Add(int item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000DB5C File Offset: 0x0000BD5C
		public void Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000DB63 File Offset: 0x0000BD63
		public bool Remove(int item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000DB6A File Offset: 0x0000BD6A
		public void Insert(int index, int item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000DB71 File Offset: 0x0000BD71
		public void RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000DB78 File Offset: 0x0000BD78
		public bool Reset()
		{
			this.Values = null;
			return this.FastItemsSource == null || this.InsertRange(0, this.FastItemsSource.Count);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		public bool InsertRange(int position, int count)
		{
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>
			{
				Capacity = count
			};
			global::Infragistics.IFastItemsSource fastItemsSource = this.fastItemsSource;
			int minimum = this.Minimum;
			int maximum = this.Maximum;
			for (int i = position; i < position + count; i++)
			{
				int item = this.ToInt(fastItemsSource[i]);
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

		// Token: 0x0600035A RID: 858 RVA: 0x0000DC18 File Offset: 0x0000BE18
		public bool ReplaceRange(int position, int count)
		{
			bool result = false;
			for (int i = 0; i < count; i++)
			{
				int num = this.Values[position + i];
				int num2 = this.ToInt(this.FastItemsSource[position + i]);
				if (num != num2)
				{
					this.Values[position + i] = num2;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000DC6D File Offset: 0x0000BE6D
		public bool RemoveRange(int position, int count)
		{
			this.Values.RemoveRange(position, count);
			return true;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000DC80 File Offset: 0x0000BE80
		private int ToInt(object item)
		{
			if (item == null)
			{
				return int.MinValue;
			}
			if (this.fastReflectionHelper == null)
			{
				this.fastReflectionHelper = new global::Infragistics.FastReflectionHelper(false, this.PropertyName);
			}
			if (!this.fastReflectionHelper.Invalid)
			{
				item = this.fastReflectionHelper.GetPropertyValue(item.GetType(), item);
				if (item == null)
				{
					return int.MinValue;
				}
			}
			if (item is int)
			{
				return (int)item;
			}
			if (item is global::System.Windows.Duration)
			{
				item = ((global::System.Windows.Duration)item).TimeSpan;
			}
			if (item is global::System.TimeSpan)
			{
				item = ((global::System.TimeSpan)item).Ticks;
			}
			if (item is global::System.DateTime)
			{
				item = ((global::System.DateTime)item).Ticks;
			}
			if (item is global::System.IConvertible)
			{
				try
				{
					return global::System.Convert.ToInt32(item);
				}
				catch
				{
				}
				return int.MinValue;
			}
			return int.MinValue;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000DD6C File Offset: 0x0000BF6C
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000DD74 File Offset: 0x0000BF74
		private global::System.Collections.Generic.List<int> Values { get; set; }

		// Token: 0x0600035F RID: 863 RVA: 0x0000DD7D File Offset: 0x0000BF7D
		internal global::System.Collections.Generic.List<int> GetSortedIndices()
		{
			return global::Infragistics.FastItemColumn.GetSortedIndices(this.Values);
		}

		// Token: 0x04000127 RID: 295
		[global::System.Runtime.CompilerServices.Weak]
		private global::Infragistics.IFastItemsSource fastItemsSource;

		// Token: 0x04000128 RID: 296
		[global::System.Runtime.CompilerServices.DontObfuscate]
		private string _propertyName;

		// Token: 0x04000129 RID: 297
		private int _minimum;

		// Token: 0x0400012A RID: 298
		private int _maximum;

		// Token: 0x0400012B RID: 299
		private global::Infragistics.FastReflectionHelper fastReflectionHelper;
	}
}
