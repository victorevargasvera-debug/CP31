using System;
using System.Globalization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000166 RID: 358
	public abstract class ValueEntry
	{
		// Token: 0x06000C3B RID: 3131 RVA: 0x0002888C File Offset: 0x00026A8C
		public ValueEntry()
		{
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000C3C RID: 3132
		public abstract object Context { get; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000C3D RID: 3133
		public abstract global::System.Globalization.CultureInfo Culture { get; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000C3E RID: 3134
		public abstract string Format { get; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000C3F RID: 3135
		public abstract object Value { get; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00028894 File Offset: 0x00026A94
		public double ValueAsDouble
		{
			get
			{
				return this.GetValueAsDouble(null);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000288A0 File Offset: 0x00026AA0
		internal double GetValueAsDouble(global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			if (this._cachedValueAsDouble != null)
			{
				return this._cachedValueAsDouble.Value;
			}
			object value = this.Value;
			object obj;
			if (context != null)
			{
				obj = context.ConvertValue(value, typeof(double));
			}
			else
			{
				obj = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), this.Culture, this.Format);
			}
			if (obj is double)
			{
				double num = (double)obj;
				this._cachedValueAsDouble = new double?(num);
				return num;
			}
			this._cachedValueAsDouble = new double?(double.NaN);
			return this._cachedValueAsDouble.Value;
		}

		// Token: 0x040005D8 RID: 1496
		private double? _cachedValueAsDouble;
	}
}
