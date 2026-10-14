using System;

namespace NPOI.HPSF
{
	// Token: 0x02000525 RID: 1317
	[global::System.Serializable]
	public abstract class VariantTypeException : global::NPOI.HPSF.HPSFException
	{
		// Token: 0x06003188 RID: 12680 RVA: 0x000959DB File Offset: 0x00093BDB
		public VariantTypeException(long variantType, object value, string msg) : base(msg)
		{
			this.variantType = variantType;
			this.value = value;
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000959F2 File Offset: 0x00093BF2
		public long VariantType
		{
			get
			{
				return this.variantType;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x000959FA File Offset: 0x00093BFA
		public object Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x040015E9 RID: 5609
		private object value;

		// Token: 0x040015EA RID: 5610
		private long variantType;
	}
}
