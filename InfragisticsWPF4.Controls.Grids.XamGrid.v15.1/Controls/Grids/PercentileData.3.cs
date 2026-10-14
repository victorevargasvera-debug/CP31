using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000030 RID: 48
	public class PercentileData<T, TRoot> : global::Infragistics.Controls.Grids.PercentileData where TRoot : global::System.IComparable
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000BC75 File Offset: 0x00009E75
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000BC7D File Offset: 0x00009E7D
		private global::System.Linq.IQueryable<TRoot> SlimmedCachedList { get; set; }

		// Token: 0x0600023D RID: 573 RVA: 0x0000BC90 File Offset: 0x00009E90
		public override double GetPercentileValue(object dataValue)
		{
			TRoot value = default(TRoot);
			if (dataValue != null)
			{
				value = (TRoot)((object)dataValue);
				if (base.CalculatedValuesDictionary.Contains(value))
				{
					return (double)base.CalculatedValuesDictionary[value];
				}
			}
			double num = global::System.Convert.ToDouble(this.SlimmedCachedList.Count((TRoot a) => a.CompareTo((object)value) < 0));
			double num2 = global::System.Convert.ToDouble(this.SlimmedCachedList.Count((TRoot a) => a.CompareTo((object)value) > 0));
			double num3 = num / (num + num2) * 100.0;
			base.CalculatedValuesDictionary.Add(value, num3);
			return num3;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000BE68 File Offset: 0x0000A068
		protected override void OnOriginalSortedListSet()
		{
			base.CalculatedValuesDictionary = new global::System.Collections.Generic.Dictionary<TRoot, double>();
			base.CachedCastedList = null;
			this.SlimmedCachedList = null;
			if (base.OriginalSortedList != null)
			{
				base.CachedCastedList = base.OriginalSortedList.AsQueryable().Cast<T>();
				global::System.Linq.IQueryable<T> source = (global::System.Linq.IQueryable<T>)base.CachedCastedList;
				this.SlimmedCachedList = source.OfType<TRoot>();
				base.ItemCount = this.SlimmedCachedList.Count<TRoot>();
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BED8 File Offset: 0x0000A0D8
		protected internal override double GetValueJustUnderPercentile(double percentile)
		{
			double result = 0.0;
			if (base.ItemCount > 0)
			{
				int index = global::System.Convert.ToInt32(global::System.Math.Floor(percentile / 100.0 * (double)base.ItemCount));
				result = global::System.Convert.ToDouble(this.SlimmedCachedList.ElementAt(index));
			}
			return result;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BF30 File Offset: 0x0000A130
		protected internal override double GetValueJustOverPercentile(double percentile)
		{
			double result = 0.0;
			if (base.ItemCount > 0)
			{
				int index = global::System.Convert.ToInt32(global::System.Math.Ceiling(percentile / 100.0 * (double)base.ItemCount));
				result = global::System.Convert.ToDouble(this.SlimmedCachedList.ElementAt(index));
			}
			return result;
		}
	}
}
