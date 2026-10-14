using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200002B RID: 43
	internal class SizeSettings
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00017A48 File Offset: 0x00015C48
		internal SizeSettings()
		{
			this.Columns = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			this.Rows = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			int? nullValue = global::Infragistics.Controls.Barcodes.XamPdf417Barcode.NullValue;
			this.AspectRatio = ((nullValue != null) ? new double?((double)nullValue.GetValueOrDefault()) : null);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00017A9E File Offset: 0x00015C9E
		internal SizeSettings(int? columns, int? rows, double? aspectRatio)
		{
			this.Columns = columns;
			this.Rows = rows;
			this.AspectRatio = aspectRatio;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00017ABB File Offset: 0x00015CBB
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00017AC3 File Offset: 0x00015CC3
		public int? Columns { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00017ACC File Offset: 0x00015CCC
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00017AD4 File Offset: 0x00015CD4
		public int? Rows { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00017ADD File Offset: 0x00015CDD
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00017AE5 File Offset: 0x00015CE5
		public double? AspectRatio { get; set; }
	}
}
