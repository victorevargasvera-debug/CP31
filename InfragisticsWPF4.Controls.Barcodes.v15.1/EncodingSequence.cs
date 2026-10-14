using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200002D RID: 45
	internal struct EncodingSequence
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0001A1DD File Offset: 0x000183DD
		public EncodingSequence(global::System.Collections.IList mode, global::System.Collections.Generic.List<int> number)
		{
			this.encodingType = mode;
			this.bytesNumber = number;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001A1ED File Offset: 0x000183ED
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0001A1F5 File Offset: 0x000183F5
		public global::System.Collections.IList EncodingType
		{
			get
			{
				return this.encodingType;
			}
			set
			{
				this.encodingType = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0001A1FE File Offset: 0x000183FE
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0001A206 File Offset: 0x00018406
		public global::System.Collections.Generic.List<int> BytesNumber
		{
			get
			{
				return this.bytesNumber;
			}
			set
			{
				this.bytesNumber = value;
			}
		}

		// Token: 0x04000124 RID: 292
		private global::System.Collections.IList encodingType;

		// Token: 0x04000125 RID: 293
		private global::System.Collections.Generic.List<int> bytesNumber;
	}
}
