using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000523 RID: 1315
	public class CmsCompressedData
	{
		// Token: 0x060032EF RID: 13039 RVA: 0x000F351F File Offset: 0x000F171F
		public CmsCompressedData(byte[] compressedData) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(compressedData))
		{
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x000F352D File Offset: 0x000F172D
		public CmsCompressedData(global::System.IO.Stream compressedDataStream) : this(global::Org.BouncyCastle.Cms.CmsUtilities.ReadContentInfo(compressedDataStream))
		{
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x000F353B File Offset: 0x000F173B
		public CmsCompressedData(global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo)
		{
			this.contentInfo = contentInfo;
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x000F354C File Offset: 0x000F174C
		public byte[] GetContent()
		{
			global::Org.BouncyCastle.Utilities.Zlib.ZInputStream zIn = new global::Org.BouncyCastle.Utilities.Zlib.ZInputStream(((global::Org.BouncyCastle.Asn1.Asn1OctetString)global::Org.BouncyCastle.Asn1.Cms.CompressedData.GetInstance(this.contentInfo.Content).EncapContentInfo.Content).GetOctetStream());
			byte[] result;
			try
			{
				result = global::Org.BouncyCastle.Cms.CmsUtilities.StreamToByteArray(zIn);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("exception reading compressed stream.", e);
			}
			finally
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(zIn);
			}
			return result;
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x000F35C0 File Offset: 0x000F17C0
		public byte[] GetContent(int limit)
		{
			global::Org.BouncyCastle.Utilities.Zlib.ZInputStream zIn = new global::Org.BouncyCastle.Utilities.Zlib.ZInputStream(new global::System.IO.MemoryStream(((global::Org.BouncyCastle.Asn1.Asn1OctetString)global::Org.BouncyCastle.Asn1.Cms.CompressedData.GetInstance(this.contentInfo.Content).EncapContentInfo.Content).GetOctets(), false));
			byte[] result;
			try
			{
				result = global::Org.BouncyCastle.Cms.CmsUtilities.StreamToByteArray(zIn, limit);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("exception reading compressed stream.", e);
			}
			return result;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x000F3628 File Offset: 0x000F1828
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo ContentInfo
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x000F3630 File Offset: 0x000F1830
		public byte[] GetEncoded()
		{
			return this.contentInfo.GetEncoded();
		}

		// Token: 0x040016B4 RID: 5812
		internal global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo;
	}
}
