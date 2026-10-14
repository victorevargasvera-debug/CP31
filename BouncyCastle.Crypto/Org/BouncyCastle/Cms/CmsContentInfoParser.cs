using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000527 RID: 1319
	public class CmsContentInfoParser
	{
		// Token: 0x060032FF RID: 13055 RVA: 0x000F3808 File Offset: 0x000F1A08
		protected CmsContentInfoParser(global::System.IO.Stream data)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			this.data = data;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1StreamParser inStream = new global::Org.BouncyCastle.Asn1.Asn1StreamParser(data);
				this.contentInfo = new global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)inStream.ReadObject());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("IOException reading content.", e);
			}
			catch (global::System.InvalidCastException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("Unexpected object reading content.", e2);
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000F3888 File Offset: 0x000F1A88
		public void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.data);
		}

		// Token: 0x040016B8 RID: 5816
		protected global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser contentInfo;

		// Token: 0x040016B9 RID: 5817
		protected global::System.IO.Stream data;
	}
}
