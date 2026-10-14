using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000524 RID: 1316
	public class CmsCompressedDataGenerator
	{
		// Token: 0x060032F7 RID: 13047 RVA: 0x000F3648 File Offset: 0x000F1848
		public global::Org.BouncyCastle.Cms.CmsCompressedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, string compressionOid)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier comAlgId;
			global::Org.BouncyCastle.Asn1.Asn1OctetString comOcts;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream zOut = new global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream(memoryStream, -1);
				content.Write(zOut);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(zOut);
				comAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(compressionOid));
				comOcts = new global::Org.BouncyCastle.Asn1.BerOctetString(memoryStream.ToArray());
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("exception encoding data.", e);
			}
			global::Org.BouncyCastle.Asn1.Cms.ContentInfo comContent = new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data, comOcts);
			return new global::Org.BouncyCastle.Cms.CmsCompressedData(new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.CompressedData, new global::Org.BouncyCastle.Asn1.Cms.CompressedData(comAlgId, comContent)));
		}

		// Token: 0x040016B5 RID: 5813
		public const string ZLib = "1.2.840.113549.1.9.16.3.8";
	}
}
