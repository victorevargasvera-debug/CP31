using System;
using System.IO;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200053F RID: 1343
	public class CmsTypedStream
	{
		// Token: 0x060033EA RID: 13290 RVA: 0x000F895B File Offset: 0x000F6B5B
		public CmsTypedStream(global::System.IO.Stream inStream) : this(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data.Id, inStream, 32768)
		{
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x000F8973 File Offset: 0x000F6B73
		public CmsTypedStream(string oid, global::System.IO.Stream inStream) : this(oid, inStream, 32768)
		{
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000F8982 File Offset: 0x000F6B82
		public CmsTypedStream(string oid, global::System.IO.Stream inStream, int bufSize)
		{
			this._oid = oid;
			this._in = new global::Org.BouncyCastle.Cms.CmsTypedStream.FullReaderStream(new global::System.IO.BufferedStream(inStream, bufSize));
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x000F89A3 File Offset: 0x000F6BA3
		public string ContentType
		{
			get
			{
				return this._oid;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x000F89AB File Offset: 0x000F6BAB
		public global::System.IO.Stream ContentStream
		{
			get
			{
				return this._in;
			}
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000F89B3 File Offset: 0x000F6BB3
		public void Drain()
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.Drain(this._in);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this._in);
		}

		// Token: 0x04001741 RID: 5953
		private const int BufferSize = 32768;

		// Token: 0x04001742 RID: 5954
		private readonly string _oid;

		// Token: 0x04001743 RID: 5955
		private readonly global::System.IO.Stream _in;

		// Token: 0x02000842 RID: 2114
		private class FullReaderStream : global::Org.BouncyCastle.Utilities.IO.FilterStream
		{
			// Token: 0x0600472E RID: 18222 RVA: 0x0013ACF8 File Offset: 0x00138EF8
			internal FullReaderStream(global::System.IO.Stream input) : base(input)
			{
			}

			// Token: 0x0600472F RID: 18223 RVA: 0x0013AD01 File Offset: 0x00138F01
			public override int Read(byte[] buf, int off, int len)
			{
				return global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this.s, buf, off, len);
			}
		}
	}
}
