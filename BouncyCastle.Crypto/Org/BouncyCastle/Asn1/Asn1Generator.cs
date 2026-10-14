using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005DD RID: 1501
	public abstract class Asn1Generator
	{
		// Token: 0x06003849 RID: 14409 RVA: 0x00109214 File Offset: 0x00107414
		protected Asn1Generator(global::System.IO.Stream outStream)
		{
			this._out = outStream;
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x00109223 File Offset: 0x00107423
		protected global::System.IO.Stream Out
		{
			get
			{
				return this._out;
			}
		}

		// Token: 0x0600384B RID: 14411
		public abstract void AddObject(global::Org.BouncyCastle.Asn1.Asn1Encodable obj);

		// Token: 0x0600384C RID: 14412
		public abstract void AddObject(global::Org.BouncyCastle.Asn1.Asn1Object obj);

		// Token: 0x0600384D RID: 14413
		public abstract global::System.IO.Stream GetRawOutputStream();

		// Token: 0x0600384E RID: 14414
		public abstract void Close();

		// Token: 0x04001934 RID: 6452
		private global::System.IO.Stream _out;
	}
}
