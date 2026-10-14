using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200030A RID: 778
	public class CertificateUrl
	{
		// Token: 0x06002114 RID: 8468 RVA: 0x00092A80 File Offset: 0x00090C80
		public CertificateUrl(byte type, global::System.Collections.IList urlAndHashList)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.CertChainType.IsValid(type))
			{
				throw new global::System.ArgumentException("not a valid CertChainType value", "type");
			}
			if (urlAndHashList == null || urlAndHashList.Count < 1)
			{
				throw new global::System.ArgumentException("must have length > 0", "urlAndHashList");
			}
			this.mType = type;
			this.mUrlAndHashList = urlAndHashList;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x00092AD5 File Offset: 0x00090CD5
		public virtual byte Type
		{
			get
			{
				return this.mType;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00092ADD File Offset: 0x00090CDD
		public virtual global::System.Collections.IList UrlAndHashList
		{
			get
			{
				return this.mUrlAndHashList;
			}
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00092AE8 File Offset: 0x00090CE8
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.mType, output);
			global::Org.BouncyCastle.Crypto.Tls.CertificateUrl.ListBuffer16 buf = new global::Org.BouncyCastle.Crypto.Tls.CertificateUrl.ListBuffer16();
			foreach (object obj in this.mUrlAndHashList)
			{
				((global::Org.BouncyCastle.Crypto.Tls.UrlAndHash)obj).Encode(buf);
			}
			buf.EncodeTo(output);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00092B58 File Offset: 0x00090D58
		public static global::Org.BouncyCastle.Crypto.Tls.CertificateUrl parse(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::System.IO.Stream input)
		{
			byte type = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (!global::Org.BouncyCastle.Crypto.Tls.CertChainType.IsValid(type))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int num = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			if (num < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(num, input), false);
			global::System.Collections.IList url_and_hash_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Crypto.Tls.UrlAndHash url_and_hash = global::Org.BouncyCastle.Crypto.Tls.UrlAndHash.Parse(context, buf);
				url_and_hash_list.Add(url_and_hash);
			}
			return new global::Org.BouncyCastle.Crypto.Tls.CertificateUrl(type, url_and_hash_list);
		}

		// Token: 0x04000BA4 RID: 2980
		protected readonly byte mType;

		// Token: 0x04000BA5 RID: 2981
		protected readonly global::System.Collections.IList mUrlAndHashList;

		// Token: 0x020007F4 RID: 2036
		internal class ListBuffer16 : global::System.IO.MemoryStream
		{
			// Token: 0x06004628 RID: 17960 RVA: 0x001361EE File Offset: 0x001343EE
			internal ListBuffer16()
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(0, this);
			}

			// Token: 0x06004629 RID: 17961 RVA: 0x001361FD File Offset: 0x001343FD
			internal void EncodeTo(global::System.IO.Stream output)
			{
				long num = this.Length - 2L;
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(num);
				this.Position = 0L;
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16((int)num, this);
				global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, output);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this);
			}
		}
	}
}
