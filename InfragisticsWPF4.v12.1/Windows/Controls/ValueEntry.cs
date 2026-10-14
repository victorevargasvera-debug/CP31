using System;
using System.Globalization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000148 RID: 328
	public abstract class ValueEntry
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x00024C50 File Offset: 0x00022E50
		public ValueEntry()
		{
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B38 RID: 2872
		public abstract object Context { get; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B39 RID: 2873
		public abstract global::System.Globalization.CultureInfo Culture { get; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B3A RID: 2874
		public abstract string Format { get; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B3B RID: 2875
		public abstract object Value { get; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00024C58 File Offset: 0x00022E58
		public double ValueAsDouble
		{
			get
			{
				if (this._cachedValueAsDouble != null)
				{
					return this._cachedValueAsDouble.Value;
				}
				object value = this.Value;
				object obj = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), this.Culture, this.Format);
				if (obj is double)
				{
					double num = (double)obj;
					this._cachedValueAsDouble = new double?(num);
					return num;
				}
				this._cachedValueAsDouble = new double?(double.NaN);
				return this._cachedValueAsDouble.Value;
			}
		}

		// Token: 0x04000520 RID: 1312
		private double? _cachedValueAsDouble;
	}
}
