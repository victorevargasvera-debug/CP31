using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F5 RID: 245
	public sealed class SupplementalDataEntry
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00023A89 File Offset: 0x00021C89
		public SupplementalDataEntry(int dataType, byte[] data)
		{
			this.m_dataType = dataType;
			this.m_data = data;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00023A9F File Offset: 0x00021C9F
		public int DataType
		{
			get
			{
				return this.m_dataType;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00023AA7 File Offset: 0x00021CA7
		public byte[] Data
		{
			get
			{
				return this.m_data;
			}
		}

		// Token: 0x040006D3 RID: 1747
		private readonly int m_dataType;

		// Token: 0x040006D4 RID: 1748
		private readonly byte[] m_data;
	}
}
