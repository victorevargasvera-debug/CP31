using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A4 RID: 1444
	public abstract class PgpEncryptedData
	{
		// Token: 0x06003618 RID: 13848 RVA: 0x001007A9 File Offset: 0x000FE9A9
		internal PgpEncryptedData(global::Org.BouncyCastle.Bcpg.InputStreamPacket encData)
		{
			this.encData = encData;
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x001007B8 File Offset: 0x000FE9B8
		public virtual global::System.IO.Stream GetInputStream()
		{
			return this.encData.GetInputStream();
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x001007C5 File Offset: 0x000FE9C5
		public bool IsIntegrityProtected()
		{
			return this.encData is global::Org.BouncyCastle.Bcpg.SymmetricEncIntegrityPacket;
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x001007D8 File Offset: 0x000FE9D8
		public bool Verify()
		{
			if (!this.IsIntegrityProtected())
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("data not integrity protected.");
			}
			global::Org.BouncyCastle.Crypto.IO.DigestStream dIn = (global::Org.BouncyCastle.Crypto.IO.DigestStream)this.encStream;
			while (this.encStream.ReadByte() >= 0)
			{
			}
			byte[] lookAhead = this.truncStream.GetLookAhead();
			global::Org.BouncyCastle.Crypto.IDigest digest = dIn.ReadDigest();
			digest.BlockUpdate(lookAhead, 0, 2);
			byte[] array = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
			byte[] streamDigest = new byte[array.Length];
			global::System.Array.Copy(lookAhead, 2, streamDigest, 0, streamDigest.Length);
			return global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(array, streamDigest);
		}

		// Token: 0x040018A2 RID: 6306
		internal global::Org.BouncyCastle.Bcpg.InputStreamPacket encData;

		// Token: 0x040018A3 RID: 6307
		internal global::System.IO.Stream encStream;

		// Token: 0x040018A4 RID: 6308
		internal global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedData.TruncatedStream truncStream;

		// Token: 0x02000846 RID: 2118
		internal class TruncatedStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
		{
			// Token: 0x06004738 RID: 18232 RVA: 0x0013AEE4 File Offset: 0x001390E4
			internal TruncatedStream(global::System.IO.Stream inStr)
			{
				int numRead = global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr, this.lookAhead, 0, this.lookAhead.Length);
				if (numRead < 22)
				{
					throw new global::System.IO.EndOfStreamException();
				}
				this.inStr = inStr;
				this.bufStart = 0;
				this.bufEnd = numRead - 22;
			}

			// Token: 0x06004739 RID: 18233 RVA: 0x0013AF40 File Offset: 0x00139140
			private int FillBuffer()
			{
				if (this.bufEnd < 490)
				{
					return 0;
				}
				global::System.Array.Copy(this.lookAhead, 490, this.lookAhead, 0, 22);
				this.bufEnd = global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this.inStr, this.lookAhead, 22, 490);
				this.bufStart = 0;
				return this.bufEnd;
			}

			// Token: 0x0600473A RID: 18234 RVA: 0x0013AFA0 File Offset: 0x001391A0
			public override int ReadByte()
			{
				int num;
				if (this.bufStart < this.bufEnd)
				{
					byte[] array = this.lookAhead;
					num = this.bufStart;
					this.bufStart = num + 1;
					return array[num];
				}
				if (this.FillBuffer() < 1)
				{
					return -1;
				}
				byte[] array2 = this.lookAhead;
				num = this.bufStart;
				this.bufStart = num + 1;
				return array2[num];
			}

			// Token: 0x0600473B RID: 18235 RVA: 0x0013AFF8 File Offset: 0x001391F8
			public override int Read(byte[] buf, int off, int len)
			{
				int avail = this.bufEnd - this.bufStart;
				int pos = off;
				while (len > avail)
				{
					global::System.Array.Copy(this.lookAhead, this.bufStart, buf, pos, avail);
					this.bufStart += avail;
					pos += avail;
					len -= avail;
					if ((avail = this.FillBuffer()) < 1)
					{
						return pos - off;
					}
				}
				global::System.Array.Copy(this.lookAhead, this.bufStart, buf, pos, len);
				this.bufStart += len;
				return pos + len - off;
			}

			// Token: 0x0600473C RID: 18236 RVA: 0x0013B07C File Offset: 0x0013927C
			internal byte[] GetLookAhead()
			{
				byte[] temp = new byte[22];
				global::System.Array.Copy(this.lookAhead, this.bufStart, temp, 0, 22);
				return temp;
			}

			// Token: 0x040025AB RID: 9643
			private const int LookAheadSize = 22;

			// Token: 0x040025AC RID: 9644
			private const int LookAheadBufSize = 512;

			// Token: 0x040025AD RID: 9645
			private const int LookAheadBufLimit = 490;

			// Token: 0x040025AE RID: 9646
			private readonly global::System.IO.Stream inStr;

			// Token: 0x040025AF RID: 9647
			private readonly byte[] lookAhead = new byte[512];

			// Token: 0x040025B0 RID: 9648
			private int bufStart;

			// Token: 0x040025B1 RID: 9649
			private int bufEnd;
		}
	}
}
