using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D6 RID: 1238
	public class NullDigest : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x000E38EB File Offset: 0x000E1AEB
		public string AlgorithmName
		{
			get
			{
				return "NULL";
			}
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000E38F2 File Offset: 0x000E1AF2
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x000E38F5 File Offset: 0x000E1AF5
		public int GetDigestSize()
		{
			return (int)this.bOut.Length;
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x000E3903 File Offset: 0x000E1B03
		public void Update(byte b)
		{
			this.bOut.WriteByte(b);
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x000E3911 File Offset: 0x000E1B11
		public void BlockUpdate(byte[] inBytes, int inOff, int len)
		{
			this.bOut.Write(inBytes, inOff, len);
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x000E3924 File Offset: 0x000E1B24
		public int DoFinal(byte[] outBytes, int outOff)
		{
			int result;
			try
			{
				result = global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this.bOut, outBytes, outOff);
			}
			finally
			{
				this.Reset();
			}
			return result;
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x000E395C File Offset: 0x000E1B5C
		public void Reset()
		{
			this.bOut.SetLength(0L);
		}

		// Token: 0x04001506 RID: 5382
		private readonly global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
	}
}
