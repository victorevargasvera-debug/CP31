using System;
using System.IO;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002BB RID: 699
	public class BufferedIesCipher : global::Org.BouncyCastle.Crypto.BufferedCipherBase
	{
		// Token: 0x06001F39 RID: 7993 RVA: 0x0008FD34 File Offset: 0x0008DF34
		public BufferedIesCipher(global::Org.BouncyCastle.Crypto.Engines.IesEngine engine)
		{
			if (engine == null)
			{
				throw new global::System.ArgumentNullException("engine");
			}
			this.engine = engine;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0008FD5C File Offset: 0x0008DF5C
		public override string AlgorithmName
		{
			get
			{
				return "IES";
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0008FD63 File Offset: 0x0008DF63
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("IES");
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0008FD76 File Offset: 0x0008DF76
		public override int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0008FD7C File Offset: 0x0008DF7C
		public override int GetOutputSize(int inputLen)
		{
			if (this.engine == null)
			{
				throw new global::System.InvalidOperationException("cipher not initialised");
			}
			int baseLen = inputLen + (int)this.buffer.Length;
			if (!this.forEncryption)
			{
				return baseLen - 20;
			}
			return baseLen + 20;
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0008FDBC File Offset: 0x0008DFBC
		public override int GetUpdateOutputSize(int inputLen)
		{
			return 0;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0008FDBF File Offset: 0x0008DFBF
		public override byte[] ProcessByte(byte input)
		{
			this.buffer.WriteByte(input);
			return null;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0008FDD0 File Offset: 0x0008DFD0
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			if (inOff < 0)
			{
				throw new global::System.ArgumentException("inOff");
			}
			if (length < 0)
			{
				throw new global::System.ArgumentException("length");
			}
			if (inOff + length > input.Length)
			{
				throw new global::System.ArgumentException("invalid offset/length specified for input array");
			}
			this.buffer.Write(input, inOff, length);
			return null;
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0008FE2C File Offset: 0x0008E02C
		public override byte[] DoFinal()
		{
			byte[] buf = this.buffer.ToArray();
			this.Reset();
			return this.engine.ProcessBlock(buf, 0, buf.Length);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0008FE5B File Offset: 0x0008E05B
		public override byte[] DoFinal(byte[] input, int inOff, int length)
		{
			this.ProcessBytes(input, inOff, length);
			return this.DoFinal();
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0008FE6D File Offset: 0x0008E06D
		public override void Reset()
		{
			this.buffer.SetLength(0L);
		}

		// Token: 0x04000B27 RID: 2855
		private readonly global::Org.BouncyCastle.Crypto.Engines.IesEngine engine;

		// Token: 0x04000B28 RID: 2856
		private bool forEncryption;

		// Token: 0x04000B29 RID: 2857
		private global::System.IO.MemoryStream buffer = new global::System.IO.MemoryStream();
	}
}
