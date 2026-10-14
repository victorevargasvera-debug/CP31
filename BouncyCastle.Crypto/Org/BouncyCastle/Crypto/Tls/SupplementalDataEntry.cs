using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000352 RID: 850
	public class SupplementalDataEntry
	{
		// Token: 0x060022DE RID: 8926 RVA: 0x00098F07 File Offset: 0x00097107
		public SupplementalDataEntry(int dataType, byte[] data)
		{
			this.mDataType = dataType;
			this.mData = data;
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x00098F1D File Offset: 0x0009711D
		public virtual int DataType
		{
			get
			{
				return this.mDataType;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x00098F25 File Offset: 0x00097125
		public virtual byte[] Data
		{
			get
			{
				return this.mData;
			}
		}

		// Token: 0x04000E2B RID: 3627
		protected readonly int mDataType;

		// Token: 0x04000E2C RID: 3628
		protected readonly byte[] mData;
	}
}
