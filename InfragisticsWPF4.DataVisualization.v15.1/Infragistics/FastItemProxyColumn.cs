using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x0200003B RID: 59
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	internal sealed class FastItemProxyColumn : global::Infragistics.IFastItemColumnInternal, global::Infragistics.IFastItemColumn<double>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.ICollection<double>, global::System.Collections.Generic.IEnumerable<double>, global::System.Collections.IEnumerable, global::Infragistics.IFastItemColumnPropertyName
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000DD8A File Offset: 0x0000BF8A
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0000DD92 File Offset: 0x0000BF92
		public string PropertyName { get; private set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0000DE16 File Offset: 0x0000C016
		public double Minimum
		{
			get
			{
				if (double.IsNaN(this.minimum) && this.FastItemsSource != null)
				{
					this.minimum = double.PositiveInfinity;
					for (int i = 0; i < this.FastItemsSource.Count; i++)
					{
						double num = this.ToDouble(this.FastItemsSource[i]);
						if (!double.IsNaN(num))
						{
							this.minimum = global::System.Math.Min(this.minimum, num);
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000DE20 File Offset: 0x0000C020
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0000DE9A File Offset: 0x0000C09A
		public double Maximum
		{
			get
			{
				if (double.IsNaN(this.maximum) && this.FastItemsSource != null)
				{
					this.maximum = double.NegativeInfinity;
					for (int i = 0; i < this.FastItemsSource.Count; i++)
					{
						double num = this.ToDouble(this.FastItemsSource[i]);
						if (!double.IsNaN(num))
						{
							this.maximum = global::System.Math.Max(this.maximum, num);
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

		// Token: 0x170000D7 RID: 215
		public double this[int index]
		{
			get
			{
				return this.ToDouble(this.FastItemsSource[index]);
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000DF8C File Offset: 0x0000C18C
		public global::System.Collections.Generic.IEnumerator<double> GetEnumerator()
		{
			if (this.FastItemsSource != null)
			{
				for (int i = 0; i < this.FastItemsSource.Count; i++)
				{
					yield return this.ToDouble(this.FastItemsSource[i]);
				}
			}
			yield break;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000E074 File Offset: 0x0000C274
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			if (this.FastItemsSource != null)
			{
				for (int i = 0; i < this.FastItemsSource.Count; i++)
				{
					yield return this.ToDouble(this.FastItemsSource[i]);
				}
			}
			yield break;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000E090 File Offset: 0x0000C290
		public bool Contains(double item)
		{
			foreach (double num in this)
			{
				double num2 = num;
				if (num2 == item)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
		public void CopyTo(double[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000E0E7 File Offset: 0x0000C2E7
		public int Count
		{
			get
			{
				if (this.FastItemsSource == null)
				{
					return 0;
				}
				return this.FastItemsSource.Count;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000E0FE File Offset: 0x0000C2FE
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000E104 File Offset: 0x0000C304
		public int IndexOf(double item)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (this[i] == item)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000E12F File Offset: 0x0000C32F
		internal FastItemProxyColumn(global::Infragistics.IFastItemsSource fastItemsSource, string propertyName)
		{
			this.PropertyName = propertyName;
			this.FastItemsSource = fastItemsSource;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000E145 File Offset: 0x0000C345
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000E14D File Offset: 0x0000C34D
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

		// Token: 0x06000372 RID: 882 RVA: 0x0000E160 File Offset: 0x0000C360
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
			if (item is global::System.IConvertible)
			{
				try
				{
					return global::System.Convert.ToDouble(item);
				}
				catch
				{
					return double.NaN;
				}
			}
			if (item is global::System.TimeSpan)
			{
				return ((global::System.TimeSpan)item).TotalMilliseconds;
			}
			if (item is global::System.DateTime)
			{
				return ((global::System.DateTime)item).ToOADate();
			}
			if (item is global::System.DateTime?)
			{
				return (item as global::System.DateTime?).Value.ToOADate();
			}
			return double.NaN;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000E260 File Offset: 0x0000C460
		public bool Reset()
		{
			this.Minimum = double.NaN;
			this.Maximum = double.NaN;
			return this.FastItemsSource == null || this.InsertRange(0, this.FastItemsSource.Count);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000E29C File Offset: 0x0000C49C
		public bool InsertRange(int position, int count)
		{
			this.Minimum = double.NaN;
			this.Maximum = double.NaN;
			return true;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000E2BD File Offset: 0x0000C4BD
		public bool RemoveRange(int position, int count)
		{
			this.Minimum = double.NaN;
			this.Maximum = double.NaN;
			return true;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000E2DE File Offset: 0x0000C4DE
		public bool ReplaceRange(int position, int count)
		{
			this.Minimum = double.NaN;
			this.Maximum = double.NaN;
			return true;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000E2FF File Offset: 0x0000C4FF
		public void Add(double item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000E306 File Offset: 0x0000C506
		public void Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000E30D File Offset: 0x0000C50D
		public bool Remove(double item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000E314 File Offset: 0x0000C514
		public void Insert(int index, double item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000E31B File Offset: 0x0000C51B
		public void RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0400012D RID: 301
		private double minimum;

		// Token: 0x0400012E RID: 302
		private double maximum;

		// Token: 0x0400012F RID: 303
		private global::Infragistics.IFastItemsSource fastItemsSource;

		// Token: 0x04000130 RID: 304
		private global::Infragistics.FastReflectionHelper fastReflectionHelper;
	}
}
