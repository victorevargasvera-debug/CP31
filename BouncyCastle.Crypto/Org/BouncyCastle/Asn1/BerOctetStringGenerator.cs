using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F3 RID: 1523
	public class BerOctetStringGenerator : global::Org.BouncyCastle.Asn1.BerGenerator
	{
		// Token: 0x060038FA RID: 14586 RVA: 0x0010B244 File Offset: 0x00109444
		public BerOctetStringGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
			base.WriteBerHeader(36);
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x0010B255 File Offset: 0x00109455
		public BerOctetStringGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream, tagNo, isExplicit)
		{
			base.WriteBerHeader(36);
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x0010B268 File Offset: 0x00109468
		public global::System.IO.Stream GetOctetOutputStream()
		{
			return this.GetOctetOutputStream(new byte[1000]);
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x0010B27A File Offset: 0x0010947A
		public global::System.IO.Stream GetOctetOutputStream(int bufSize)
		{
			if (bufSize >= 1)
			{
				return this.GetOctetOutputStream(new byte[bufSize]);
			}
			return this.GetOctetOutputStream();
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x0010B293 File Offset: 0x00109493
		public global::System.IO.Stream GetOctetOutputStream(byte[] buf)
		{
			return new global::Org.BouncyCastle.Asn1.BerOctetStringGenerator.BufferedBerOctetStream(this, buf);
		}

		// Token: 0x02000850 RID: 2128
		private class BufferedBerOctetStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x06004757 RID: 18263 RVA: 0x0013B73F File Offset: 0x0013993F
			internal BufferedBerOctetStream(global::Org.BouncyCastle.Asn1.BerOctetStringGenerator gen, byte[] buf)
			{
				this._gen = gen;
				this._buf = buf;
				this._off = 0;
				this._derOut = global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(this._gen.Out, "DER");
			}

			// Token: 0x06004758 RID: 18264 RVA: 0x0013B778 File Offset: 0x00139978
			public override void WriteByte(byte b)
			{
				byte[] buf = this._buf;
				int off = this._off;
				this._off = off + 1;
				buf[off] = b;
				if (this._off == this._buf.Length)
				{
					global::Org.BouncyCastle.Asn1.DerOctetString.Encode(this._derOut, true, this._buf, 0, this._off);
					this._off = 0;
				}
			}

			// Token: 0x06004759 RID: 18265 RVA: 0x0013B7D0 File Offset: 0x001399D0
			public override void Write(byte[] b, int off, int len)
			{
				int bufLen = this._buf.Length;
				int available = bufLen - this._off;
				if (len < available)
				{
					global::System.Array.Copy(b, off, this._buf, this._off, len);
					this._off += len;
					return;
				}
				int count = 0;
				if (this._off > 0)
				{
					global::System.Array.Copy(b, off, this._buf, this._off, available);
					count += available;
					global::Org.BouncyCastle.Asn1.DerOctetString.Encode(this._derOut, true, this._buf, 0, bufLen);
				}
				int remaining;
				while ((remaining = len - count) >= bufLen)
				{
					global::Org.BouncyCastle.Asn1.DerOctetString.Encode(this._derOut, true, b, off + count, bufLen);
					count += bufLen;
				}
				global::System.Array.Copy(b, off + count, this._buf, 0, remaining);
				this._off = remaining;
			}

			// Token: 0x0600475A RID: 18266 RVA: 0x0013B884 File Offset: 0x00139A84
			public override void Close()
			{
				if (this._off != 0)
				{
					global::Org.BouncyCastle.Asn1.DerOctetString.Encode(this._derOut, true, this._buf, 0, this._off);
				}
				this._derOut.FlushInternal();
				this._gen.WriteBerEnd();
				base.Close();
			}

			// Token: 0x040025C6 RID: 9670
			private byte[] _buf;

			// Token: 0x040025C7 RID: 9671
			private int _off;

			// Token: 0x040025C8 RID: 9672
			private readonly global::Org.BouncyCastle.Asn1.BerOctetStringGenerator _gen;

			// Token: 0x040025C9 RID: 9673
			private readonly global::Org.BouncyCastle.Asn1.Asn1OutputStream _derOut;
		}
	}
}
