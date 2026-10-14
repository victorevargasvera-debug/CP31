using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200010B RID: 267
	public class BoolToValueConverter : global::Infragistics.Windows.Controls.BoolConverter
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00020324 File Offset: 0x0001E524
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0002032C File Offset: 0x0001E52C
		public object FalseConvertValue
		{
			get
			{
				return this.falseValue;
			}
			set
			{
				this.falseValue = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00020335 File Offset: 0x0001E535
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0002033D File Offset: 0x0001E53D
		public object TrueConvertValue
		{
			get
			{
				return this.trueValue;
			}
			set
			{
				this.trueValue = value;
			}
		}
	}
}
