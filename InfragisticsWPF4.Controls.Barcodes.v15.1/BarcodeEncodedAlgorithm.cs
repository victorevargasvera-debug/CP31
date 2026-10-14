using System;
using System.Text;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000004 RID: 4
	internal class BarcodeEncodedAlgorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002D75 File Offset: 0x00000F75
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002D7D File Offset: 0x00000F7D
		private global::Infragistics.Controls.Barcodes.XamBarcode Barcode { get; set; }

		// Token: 0x06000017 RID: 23 RVA: 0x00002D86 File Offset: 0x00000F86
		public BarcodeEncodedAlgorithm(global::Infragistics.Controls.Barcodes.XamBarcode barcode)
		{
			this.Barcode = barcode;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D95 File Offset: 0x00000F95
		public global::System.Text.Encoding GetEncoding(int codePage)
		{
			return global::System.Text.Encoding.GetEncoding(codePage);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002D9D File Offset: 0x00000F9D
		public global::System.Text.Encoding GetEncoding(string name)
		{
			return global::System.Text.Encoding.GetEncoding(name);
		}
	}
}
