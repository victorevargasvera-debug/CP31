using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000037 RID: 55
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	internal sealed class FastItemColumn : global::Infragistics.IFastItemColumnInternal, global::Infragistics.IFastItemColumn<double>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.ICollection<double>, global::System.Collections.Generic.IEnumerable<double>, global::System.Collections.IEnumerable, global::Infragistics.IFastItemColumnPropertyName
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x0000CADF File Offset: 0x0000ACDF
		internal FastItemColumn(global::Infragistics.IFastItemsSource fastItemsSource, string propertyName)
		{
			this.PropertyName = propertyName;
			this.FastItemsSource = fastItemsSource;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000CAF5 File Offset: 0x0000ACF5
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000CAFD File Offset: 0x0000ACFD
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000CB0D File Offset: 0x0000AD0D
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000CB15 File Offset: 0x0000AD15
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000CB20 File Offset: 0x0000AD20
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		public double Minimum
		{
			get
			{
				if (double.IsNaN(this.minimum) && this.Values != null)
				{
					this.minimum = double.PositiveInfinity;
					foreach (double num in this.Values)
					{
						double num2 = num;
						if (!double.IsNaN(num2))
						{
							this.minimum = global::System.Math.Min(this.minimum, num2);
						}
					}
				}
				return this.minimum;
			}
			private set
			{
				this.minimum = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000CC54 File Offset: 0x0000AE54
		public double Maximum
		{
			get
			{
				if (double.IsNaN(this.maximum) && this.Values != null)
				{
					this.maximum = double.NegativeInfinity;
					foreach (double num in this.Values)
					{
						double num2 = num;
						if (!double.IsNaN(num2))
						{
							this.maximum = global::System.Math.Max(this.maximum, num2);
						}
					}
				}
				return this.maximum;
			}
			private set
			{
				this.maximum = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		public double this[int index]
		{
			get
			{
				return this.Values[index];
			}
			set
			{
				this.Values[index] = value;
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000CC7A File Offset: 0x0000AE7A
		public global::System.Collections.Generic.IEnumerator<double> GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.Values.GetEnumerator();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000CC9E File Offset: 0x0000AE9E
		public bool Contains(double item)
		{
			return this.Values.Contains(item);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000CCAC File Offset: 0x0000AEAC
		public void CopyTo(double[] array, int arrayIndex)
		{
			this.Values.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000CCBB File Offset: 0x0000AEBB
		public int Count
		{
			get
			{
				return this.Values.Count;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000CCCB File Offset: 0x0000AECB
		public int IndexOf(double item)
		{
			return this.Values.IndexOf(item);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000CCD9 File Offset: 0x0000AED9
		public void Add(double item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		public void Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000CCE7 File Offset: 0x0000AEE7
		public bool Remove(double item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000CCEE File Offset: 0x0000AEEE
		public void Insert(int index, double item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000CCF5 File Offset: 0x0000AEF5
		public void RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		public bool Reset()
		{
			this.Values = null;
			this.Minimum = double.NaN;
			this.Maximum = double.NaN;
			return this.FastItemsSource == null || this.InsertRange(0, this.FastItemsSource.Count);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public bool InsertRange(int position, int count)
		{
			global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>
			{
				Capacity = count
			};
			global::Infragistics.IFastItemsSource fastItemsSource = this.fastItemsSource;
			double num = this.Minimum;
			double num2 = this.Maximum;
			bool flag = double.IsNaN(this.Minimum);
			bool flag2 = double.IsNaN(this.Maximum);
			global::System.Collections.IList list2 = fastItemsSource.ContentsAsIList();
			if (list2 != null && this._propertyName != null && this._propertyName.StartsWith("[") && list2.Count > 0 && list2[0] is double[])
			{
				int num3;
				if (int.TryParse(this._propertyName.Replace("[", "").Replace("]", ""), out num3) && num3 >= 0)
				{
					for (int i = position; i < position + count; i++)
					{
						double[] array = (double[])list2[i];
						double num4 = double.NaN;
						if (num3 < array.Length)
						{
							num4 = array[num3];
						}
						bool flag3 = num4 != num4;
						if (flag || num4 < num)
						{
							num = num4;
							flag = flag3;
						}
						if (flag2 || num4 > num2)
						{
							num2 = num4;
							flag2 = flag3;
						}
						list.Add(num4);
					}
				}
			}
			else
			{
				for (int j = position; j < position + count; j++)
				{
					double num4 = this.ToDouble(fastItemsSource[j]);
					bool flag4 = num4 != num4;
					if (flag || num4 < num)
					{
						num = num4;
						flag = flag4;
					}
					if (flag2 || num4 > num2)
					{
						num2 = num4;
						flag2 = flag4;
					}
					list.Add(num4);
				}
			}
			this.Minimum = num;
			this.Maximum = num2;
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

		// Token: 0x060002FA RID: 762 RVA: 0x0000CF14 File Offset: 0x0000B114
		public bool RemoveRange(int position, int count)
		{
			int num = position;
			while (num < position + count && !double.IsNaN(this.Minimum) && !double.IsNaN(this.Maximum))
			{
				if (this[num] == this.Minimum)
				{
					this.Minimum = double.NaN;
				}
				if (this[num] == this.Maximum)
				{
					this.Maximum = double.NaN;
				}
				num++;
			}
			this.Values.RemoveRange(position, count);
			return true;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000CF94 File Offset: 0x0000B194
		public void ReplaceMinMax(double oldValue, double newValue)
		{
			if (double.IsNaN(oldValue))
			{
				if (!double.IsNaN(newValue))
				{
					if (!double.IsNaN(this.Minimum))
					{
						this.Minimum = global::System.Math.Min(newValue, this.Minimum);
					}
					if (!double.IsNaN(this.Maximum))
					{
						this.Maximum = global::System.Math.Max(newValue, this.Maximum);
					}
				}
				return;
			}
			if (double.IsNaN(newValue))
			{
				this.Minimum = ((!double.IsNaN(this.Minimum) && oldValue == this.Minimum) ? double.NaN : this.Minimum);
				this.Maximum = ((!double.IsNaN(this.Maximum) && oldValue == this.Maximum) ? double.NaN : this.Maximum);
				return;
			}
			if (!double.IsNaN(this.Minimum))
			{
				if (oldValue == this.Minimum && newValue > this.Minimum)
				{
					this.Minimum = double.NaN;
				}
				else
				{
					this.Minimum = global::System.Math.Min(newValue, this.Minimum);
				}
			}
			if (!double.IsNaN(this.Maximum))
			{
				if (oldValue == this.Maximum && newValue < this.Maximum)
				{
					this.Maximum = double.NaN;
					return;
				}
				this.Maximum = global::System.Math.Max(newValue, this.Maximum);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		public bool ReplaceRange(int position, int count)
		{
			bool result = false;
			for (int i = 0; i < count; i++)
			{
				double num = this.Values[position + i];
				double num2 = this.ToDouble(this.FastItemsSource[position + i]);
				if (num != num2)
				{
					this.Values[position + i] = num2;
					result = true;
					this.ReplaceMinMax(num, num2);
				}
			}
			return result;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000D138 File Offset: 0x0000B338
		private double ToDouble(object item)
		{
			if (item == null)
			{
				return double.NaN;
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
					return double.NaN;
				}
			}
			if (item is double)
			{
				return (double)item;
			}
			if (item is global::System.Windows.Duration)
			{
				item = ((global::System.Windows.Duration)item).TimeSpan;
			}
			if (item is global::System.DateTime)
			{
				return (double)((global::System.DateTime)item).Ticks;
			}
			if (item is global::System.TimeSpan)
			{
				return (double)((global::System.TimeSpan)item).Ticks;
			}
			if (item is string && string.IsNullOrEmpty((string)item))
			{
				return double.NaN;
			}
			if (item is global::System.IConvertible)
			{
				try
				{
					return global::System.Convert.ToDouble(item);
				}
				catch
				{
				}
			}
			return double.NaN;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000D244 File Offset: 0x0000B444
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000D24C File Offset: 0x0000B44C
		internal global::System.Collections.Generic.List<double> Values { get; private set; }

		// Token: 0x06000300 RID: 768 RVA: 0x0000D26C File Offset: 0x0000B46C
		public static global::System.Collections.Generic.List<int> GetSortedIndices(global::System.Collections.IList values)
		{
			global::System.Collections.Generic.IEnumerable<int> source = global::System.Linq.Enumerable.Range(0, values.Count);
			source = from i in source
			orderby values[i]
			select i;
			return source.ToList<int>();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000D2B1 File Offset: 0x0000B4B1
		internal global::System.Collections.Generic.List<int> GetSortedIndices()
		{
			return global::Infragistics.FastItemColumn.GetSortedIndices(this.Values);
		}

		// Token: 0x04000113 RID: 275
		[global::System.Runtime.CompilerServices.Weak]
		private global::Infragistics.IFastItemsSource fastItemsSource;

		// Token: 0x04000114 RID: 276
		[global::System.Runtime.CompilerServices.DontObfuscate]
		private string _propertyName;

		// Token: 0x04000115 RID: 277
		private double minimum;

		// Token: 0x04000116 RID: 278
		private double maximum;

		// Token: 0x04000117 RID: 279
		private global::Infragistics.FastReflectionHelper fastReflectionHelper;
	}
}
