using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200009E RID: 158
	public sealed class CertificateUrl
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x0001AC30 File Offset: 0x00018E30
		public CertificateUrl(short type, global::System.Collections.IList urlAndHashList)
		{
			if (!global::Org.BouncyCastle.Tls.CertChainType.IsValid(type))
			{
				throw new global::System.ArgumentException("not a valid CertChainType value", "type");
			}
			if (urlAndHashList == null || urlAndHashList.Count < 1)
			{
				throw new global::System.ArgumentException("must have length > 0", "urlAndHashList");
			}
			if (type == 1 && urlAndHashList.Count != 1)
			{
				throw new global::System.ArgumentException("must contain exactly one entry when type is " + global::Org.BouncyCastle.Tls.CertChainType.GetText(type), "urlAndHashList");
			}
			this.m_type = type;
			this.m_urlAndHashList = urlAndHashList;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001ACAD File Offset: 0x00018EAD
		public short Type
		{
			get
			{
				return this.m_type;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001ACB5 File Offset: 0x00018EB5
		public global::System.Collections.IList UrlAndHashList
		{
			get
			{
				return this.m_urlAndHashList;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		public void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(this.m_type, output);
			global::Org.BouncyCastle.Tls.CertificateUrl.ListBuffer16 buf = new global::Org.BouncyCastle.Tls.CertificateUrl.ListBuffer16();
			foreach (object obj in this.m_urlAndHashList)
			{
				((global::Org.BouncyCastle.Tls.UrlAndHash)obj).Encode(buf);
			}
			buf.EncodeTo(output);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001AD30 File Offset: 0x00018F30
		public static global::Org.BouncyCastle.Tls.CertificateUrl Parse(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			short type = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if (!global::Org.BouncyCastle.Tls.CertChainType.IsValid(type))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (num < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(num, input), false);
			global::System.Collections.IList url_and_hash_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Tls.UrlAndHash url_and_hash = global::Org.BouncyCastle.Tls.UrlAndHash.Parse(context, buf);
				url_and_hash_list.Add(url_and_hash);
			}
			if (type == 1 && url_and_hash_list.Count != 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return new global::Org.BouncyCastle.Tls.CertificateUrl(type, url_and_hash_list);
		}

		// Token: 0x04000353 RID: 851
		private readonly short m_type;

		// Token: 0x04000354 RID: 852
		private readonly global::System.Collections.IList m_urlAndHashList;

		// Token: 0x020007A1 RID: 1953
		internal class ListBuffer16 : global::System.IO.MemoryStream
		{
			// Token: 0x06004505 RID: 17669 RVA: 0x001326B5 File Offset: 0x001308B5
			internal ListBuffer16()
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, this);
			}

			// Token: 0x06004506 RID: 17670 RVA: 0x001326C4 File Offset: 0x001308C4
			internal void EncodeTo(global::System.IO.Stream output)
			{
				int i = (int)this.Length - 2;
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
				this.Seek(0L, global::System.IO.SeekOrigin.Begin);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, this);
				global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, output);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
			}
		}
	}
}
