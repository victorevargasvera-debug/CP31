using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200002F RID: 47
	public class PercentileData<T> : global::Infragistics.Controls.Grids.PercentileData where T : global::System.IComparable
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0000B8EC File Offset: 0x00009AEC
		public override double GetPercentileValue(object dataValue)
		{
			T t = (T)((object)dataValue);
			if (base.CalculatedValuesDictionary.Contains(t))
			{
				return (double)base.CalculatedValuesDictionary[t];
			}
			return this.CalculatePercentile(t);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B93C File Offset: 0x00009B3C
		private double CalculatePercentile(T value)
		{
			global::System.Linq.IQueryable<T> source = (global::System.Linq.IQueryable<T>)base.CachedCastedList;
			double num = global::System.Convert.ToDouble(source.Count((T a) => ((object)a == null) ? false : (a.CompareTo((object)value) < 0)));
			double num2 = global::System.Convert.ToDouble(source.Count((T a) => ((object)a == null) ? false : (a.CompareTo((object)value) > 0)));
			double num3 = num / (num + num2) * 100.0;
			base.CalculatedValuesDictionary.Add(value, num3);
			return num3;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000BB5C File Offset: 0x00009D5C
		protected override void OnOriginalSortedListSet()
		{
			base.CalculatedValuesDictionary = new global::System.Collections.Generic.Dictionary<T, double>();
			base.CachedCastedList = null;
			if (base.OriginalSortedList != null)
			{
				base.CachedCastedList = base.OriginalSortedList.AsQueryable().Cast<T>();
				base.ItemCount = base.OriginalSortedList.Count;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000BBAC File Offset: 0x00009DAC
		protected internal override double GetValueJustUnderPercentile(double percentile)
		{
			double result = 0.0;
			if (base.ItemCount > 0)
			{
				int num = global::System.Convert.ToInt32(global::System.Math.Floor(percentile / 100.0 * (double)base.ItemCount));
				if (num >= base.OriginalSortedList.Count)
				{
					num = base.OriginalSortedList.Count - 1;
				}
				result = global::System.Convert.ToDouble(base.OriginalSortedList[num]);
			}
			return result;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000BC1C File Offset: 0x00009E1C
		protected internal override double GetValueJustOverPercentile(double percentile)
		{
			double result = 0.0;
			if (base.ItemCount > 0)
			{
				int index = global::System.Convert.ToInt32(global::System.Math.Ceiling(percentile / 100.0 * (double)base.ItemCount));
				result = global::System.Convert.ToDouble(base.OriginalSortedList[index]);
			}
			return result;
		}
	}
}
