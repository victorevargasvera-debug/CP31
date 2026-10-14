using System;
using System.Globalization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000276 RID: 630
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	internal class ParseFormatAttribute : global::System.Attribute
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00073FEC File Offset: 0x000721EC
		public ParseFormatAttribute()
		{
			global::System.Globalization.CultureInfo invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
			this.DateTimeFormat = invariantCulture.DateTimeFormat.ShortDatePattern;
			this.NumberFormat = "+00000000.0000;-00000000.0000";
			this.TrimBeforeParse = true;
			this.CultureInfo = invariantCulture;
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00074034 File Offset: 0x00072234
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x0007403C File Offset: 0x0007223C
		public global::System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				return this.mCultureInfo;
			}
			set
			{
				this.mCultureInfo = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x00074048 File Offset: 0x00072248
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x00074050 File Offset: 0x00072250
		public string DateTimeFormat
		{
			get
			{
				return this.mDateTimeFormat;
			}
			set
			{
				this.mDateTimeFormat = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0007405C File Offset: 0x0007225C
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x00074064 File Offset: 0x00072264
		public string NumberFormat
		{
			get
			{
				return this.mNumberFormat;
			}
			set
			{
				this.mNumberFormat = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00074070 File Offset: 0x00072270
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x00074078 File Offset: 0x00072278
		public bool TrimBeforeParse
		{
			get
			{
				return this.mTrimBeforeParse;
			}
			set
			{
				this.mTrimBeforeParse = value;
			}
		}

		// Token: 0x04000BFF RID: 3071
		private string mDateTimeFormat;

		// Token: 0x04000C00 RID: 3072
		private string mNumberFormat;

		// Token: 0x04000C01 RID: 3073
		private bool mTrimBeforeParse;

		// Token: 0x04000C02 RID: 3074
		private global::System.Globalization.CultureInfo mCultureInfo;
	}
}
