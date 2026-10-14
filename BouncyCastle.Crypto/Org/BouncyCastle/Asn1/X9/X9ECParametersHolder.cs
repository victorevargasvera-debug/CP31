using System;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000637 RID: 1591
	public abstract class X9ECParametersHolder
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003B0F RID: 15119 RVA: 0x001107B4 File Offset: 0x0010E9B4
		public global::Org.BouncyCastle.Asn1.X9.X9ECParameters Parameters
		{
			get
			{
				global::Org.BouncyCastle.Asn1.X9.X9ECParameters result;
				lock (this)
				{
					if (this.parameters == null)
					{
						this.parameters = this.CreateParameters();
					}
					result = this.parameters;
				}
				return result;
			}
		}

		// Token: 0x06003B10 RID: 15120
		protected abstract global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters();

		// Token: 0x040019D5 RID: 6613
		private global::Org.BouncyCastle.Asn1.X9.X9ECParameters parameters;
	}
}
