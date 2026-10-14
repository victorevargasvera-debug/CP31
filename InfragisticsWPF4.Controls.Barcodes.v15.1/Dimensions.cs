using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000015 RID: 21
	internal class Dimensions
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000BB9C File Offset: 0x00009D9C
		public void UpdateDimensions(double lDimension)
		{
			this.ModuleW = lDimension / 29.0;
			this.ModuleV = 2.0 / global::System.Math.Sqrt(3.0) * this.ModuleW;
			this.ModuleX = this.ModuleW;
			this.ModuleY = 1.5 / global::System.Math.Sqrt(3.0) * this.ModuleW;
			this.ModuleY = global::Infragistics.Controls.Barcodes.MeasureHelper.GetYPixels(this.ModuleY);
			this.ModuleW = global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(this.ModuleW);
			this.ModuleV = global::Infragistics.Controls.Barcodes.MeasureHelper.GetYPixels(this.ModuleV);
			this.ModuleX = global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(this.ModuleX);
			this.RDimensions = new double[6];
			double num = lDimension / 25.5;
			this.RDimensions[0] = num * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(0.51);
			this.RDimensions[1] = num * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(1.18);
			this.RDimensions[2] = num * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(1.86);
			this.RDimensions[3] = num * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(2.53);
			this.RDimensions[4] = num * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(3.2);
			this.RDimensions[5] = num * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(3.87);
		}

		// Token: 0x0400008F RID: 143
		public double ModuleW;

		// Token: 0x04000090 RID: 144
		public double ModuleX;

		// Token: 0x04000091 RID: 145
		public double ModuleY;

		// Token: 0x04000092 RID: 146
		public double ModuleV;

		// Token: 0x04000093 RID: 147
		public double[] RDimensions;
	}
}
