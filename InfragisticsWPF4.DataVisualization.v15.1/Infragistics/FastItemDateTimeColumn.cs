using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000038 RID: 56
	internal sealed class FastItemDateTimeColumn : global::Infragistics.IFastItemColumnInternal, global::Infragistics.IFastItemColumn<global::System.DateTime>, global::System.Collections.Generic.IList<global::System.DateTime>, global::System.Collections.Generic.ICollection<global::System.DateTime>, global::System.Collections.Generic.IEnumerable<global::System.DateTime>, global::System.Collections.IEnumerable, global::Infragistics.IFastItemColumnPropertyName
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0000D2BE File Offset: 0x0000B4BE
		internal FastItemDateTimeColumn(global::Infragistics.IFastItemsSource fastItemsSource, string propertyName)
		{
			this.PropertyName = propertyName;
			this.FastItemsSource = fastItemsSource;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0000D2DC File Offset: 0x0000B4DC
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000D2EC File Offset: 0x0000B4EC
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000D300 File Offset: 0x0000B500
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000D38C File Offset: 0x0000B58C
		public global::System.DateTime Minimum
		{
			get
			{
				if (!this.hasMinimum && this.Values != null)
				{
					foreach (global::System.DateTime t in this.Values)
					{
						if (t < this.minimum)
						{
							this.minimum = t;
						}
					}
					if (this.Values.Count > 0)
					{
						this.hasMinimum = true;
					}
				}
				return this.minimum;
			}
			private set
			{
				this.minimum = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000D398 File Offset: 0x0000B598
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000D424 File Offset: 0x0000B624
		public global::System.DateTime Maximum
		{
			get
			{
				if (!this.hasMaximum && this.Values != null)
				{
					foreach (global::System.DateTime t in this.Values)
					{
						if (t > this.maximum)
						{
							this.maximum = t;
						}
					}
					if (this.Values.Count > 0)
					{
						this.hasMaximum = true;
					}
				}
				return this.maximum;
			}
			private set
			{
				this.maximum = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		public global::System.DateTime this[int index]
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

		// Token: 0x0600030D RID: 781 RVA: 0x0000D442 File Offset: 0x0000B642
		public global::System.Collections.Generic.IEnumerator<global::System.DateTime> GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000D454 File Offset: 0x0000B654
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000D466 File Offset: 0x0000B666
		public bool Contains(global::System.DateTime item)
		{
			return this.Values.Contains(item);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000D474 File Offset: 0x0000B674
		public void CopyTo(global::System.DateTime[] array, int arrayIndex)
		{
			this.Values.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000D483 File Offset: 0x0000B683
		public int Count
		{
			get
			{
				return this.Values.Count;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000D490 File Offset: 0x0000B690
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000D493 File Offset: 0x0000B693
		public int IndexOf(global::System.DateTime item)
		{
			return this.Values.IndexOf(item);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000D4A1 File Offset: 0x0000B6A1
		public void Add(global::System.DateTime item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
		public void Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000D4AF File Offset: 0x0000B6AF
		public bool Remove(global::System.DateTime item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
		public void Insert(int index, global::System.DateTime item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000D4BD File Offset: 0x0000B6BD
		public void RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		public bool Reset()
		{
			this.Values = null;
			this.hasMinimum = false;
			this.hasMaximum = false;
			return this.FastItemsSource == null || this.InsertRange(0, this.FastItemsSource.Count);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public bool InsertRange(int position, int count)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>
			{
				Capacity = count
			};
			global::Infragistics.IFastItemsSource fastItemsSource = this.fastItemsSource;
			global::System.DateTime t = this.Minimum;
			global::System.DateTime t2 = this.Maximum;
			for (int i = position; i < position + count; i++)
			{
				global::System.DateTime dateTime = this.ToDateTime(fastItemsSource[i]);
				if (!this.hasMinimum)
				{
					t = dateTime;
					this.hasMinimum = true;
				}
				else if (dateTime < t)
				{
					t = dateTime;
				}
				if (!this.hasMaximum)
				{
					t2 = dateTime;
					this.hasMaximum = true;
				}
				else if (dateTime > t2)
				{
					t2 = dateTime;
				}
				list.Add(dateTime);
			}
			this.Minimum = t;
			this.Maximum = t2;
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

		// Token: 0x0600031B RID: 795 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		public bool RemoveRange(int position, int count)
		{
			for (int i = position; i < position + count; i++)
			{
				if (this[i] == this.Minimum)
				{
					this.hasMinimum = false;
				}
				if (this[i] == this.Maximum)
				{
					this.hasMaximum = false;
				}
			}
			this.Values.RemoveRange(position, count);
			return true;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000D628 File Offset: 0x0000B828
		public void ReplaceMinMax(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			if (oldValue != global::System.DateTime.MinValue)
			{
				if (newValue != global::System.DateTime.MinValue)
				{
					this.Minimum = ((newValue < this.Minimum) ? newValue : this.Minimum);
					this.Maximum = ((newValue > this.Maximum) ? newValue : this.Maximum);
				}
				return;
			}
			this.Minimum = ((newValue < this.Minimum) ? newValue : this.Minimum);
			this.Maximum = ((newValue > this.Maximum) ? newValue : this.Maximum);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		public bool ReplaceRange(int position, int count)
		{
			bool result = false;
			for (int i = 0; i < count; i++)
			{
				global::System.DateTime dateTime = this.Values[position + i];
				global::System.DateTime dateTime2 = this.ToDateTime(this.FastItemsSource[position + i]);
				if (dateTime != dateTime2)
				{
					this.Values[position + i] = dateTime2;
					result = true;
					this.ReplaceMinMax(dateTime, dateTime2);
				}
			}
			return result;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000D728 File Offset: 0x0000B928
		private global::System.DateTime ToDateTime(object item)
		{
			if (item == null)
			{
				return global::System.DateTime.MinValue;
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
					return global::System.DateTime.MinValue;
				}
			}
			if (item is global::System.DateTime)
			{
				return (global::System.DateTime)item;
			}
			if (item is double)
			{
				return global::System.DateTime.FromOADate((double)item);
			}
			if (item is global::System.Windows.Duration)
			{
				item = ((global::System.Windows.Duration)item).TimeSpan;
			}
			if (item is global::System.TimeSpan)
			{
				return new global::System.DateTime(((global::System.TimeSpan)item).Ticks);
			}
			if (item is global::System.IConvertible)
			{
				try
				{
					return global::System.Convert.ToDateTime(item);
				}
				catch
				{
				}
			}
			return global::System.DateTime.MinValue;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000D80C File Offset: 0x0000BA0C
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0000D814 File Offset: 0x0000BA14
		private global::System.Collections.Generic.List<global::System.DateTime> Values { get; set; }

		// Token: 0x06000321 RID: 801 RVA: 0x0000D81D File Offset: 0x0000BA1D
		public global::System.Collections.Generic.List<int> GetSortedIndices()
		{
			return global::Infragistics.FastItemColumn.GetSortedIndices(this.Values);
		}

		// Token: 0x04000119 RID: 281
		[global::System.Runtime.CompilerServices.Weak]
		private global::Infragistics.IFastItemsSource fastItemsSource;

		// Token: 0x0400011A RID: 282
		[global::System.Runtime.CompilerServices.DontObfuscate]
		private string _propertyName;

		// Token: 0x0400011B RID: 283
		private bool hasMinimum;

		// Token: 0x0400011C RID: 284
		private bool hasMaximum;

		// Token: 0x0400011D RID: 285
		private global::System.DateTime minimum;

		// Token: 0x0400011E RID: 286
		private global::System.DateTime maximum;

		// Token: 0x0400011F RID: 287
		private global::Infragistics.FastReflectionHelper fastReflectionHelper;
	}
}
