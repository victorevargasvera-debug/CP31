using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000525 RID: 1317
	public class CmsCompressedDataParser : global::Org.BouncyCastle.Cms.CmsContentInfoParser
	{
		// Token: 0x060032F8 RID: 13048 RVA: 0x000F36CC File Offset: 0x000F18CC
		public CmsCompressedDataParser(byte[] compressedData) : this(new global::System.IO.MemoryStream(compressedData, false))
		{
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x000F36DB File Offset: 0x000F18DB
		public CmsCompressedDataParser(global::System.IO.Stream compressedData) : base(compressedData)
		{
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x000F36E4 File Offset: 0x000F18E4
		public global::Org.BouncyCastle.Cms.CmsTypedStream GetContent()
		{
			global::Org.BouncyCastle.Cms.CmsTypedStream result;
			try
			{
				global::Org.BouncyCastle.Asn1.Cms.ContentInfoParser encapContentInfo = new global::Org.BouncyCastle.Asn1.Cms.CompressedDataParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)this.contentInfo.GetContent(16)).GetEncapContentInfo();
				global::Org.BouncyCastle.Asn1.Asn1OctetStringParser bytes = (global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)encapContentInfo.GetContent(4);
				result = new global::Org.BouncyCastle.Cms.CmsTypedStream(encapContentInfo.ContentType.ToString(), new global::Org.BouncyCastle.Utilities.Zlib.ZInputStream(bytes.GetOctetStream()));
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("IOException reading compressed content.", e);
			}
			return result;
		}
	}
}
