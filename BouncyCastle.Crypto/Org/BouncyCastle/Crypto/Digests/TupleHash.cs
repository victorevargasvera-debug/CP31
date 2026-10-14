using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E9 RID: 1257
	public class TupleHash : global::Org.BouncyCastle.Crypto.IXof, global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06003187 RID: 12679 RVA: 0x000EDDFD File Offset: 0x000EBFFD
		public TupleHash(int bitLength, byte[] S) : this(bitLength, S, bitLength * 2)
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x000EDE0A File Offset: 0x000EC00A
		public TupleHash(int bitLength, byte[] S, int outputSize)
		{
			this.cshake = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(bitLength, global::Org.BouncyCastle.Crypto.Digests.TupleHash.N_TUPLE_HASH, S);
			this.bitLength = bitLength;
			this.outputLength = (outputSize + 7) / 8;
			this.Reset();
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x000EDE3C File Offset: 0x000EC03C
		public TupleHash(global::Org.BouncyCastle.Crypto.Digests.TupleHash original)
		{
			this.cshake = new global::Org.BouncyCastle.Crypto.Digests.CShakeDigest(original.cshake);
			this.bitLength = this.cshake.fixedOutputLength;
			this.outputLength = this.bitLength * 2 / 8;
			this.firstOutput = original.firstOutput;
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x000EDE8D File Offset: 0x000EC08D
		public virtual string AlgorithmName
		{
			get
			{
				return "TupleHash" + this.cshake.AlgorithmName.Substring(6);
			}
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000EDEAA File Offset: 0x000EC0AA
		public virtual int GetByteLength()
		{
			return this.cshake.GetByteLength();
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000EDEB7 File Offset: 0x000EC0B7
		public virtual int GetDigestSize()
		{
			return this.outputLength;
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000EDEC0 File Offset: 0x000EC0C0
		public virtual void Update(byte b)
		{
			byte[] bytes = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.Encode(b);
			this.cshake.BlockUpdate(bytes, 0, bytes.Length);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000EDEE4 File Offset: 0x000EC0E4
		public virtual void BlockUpdate(byte[] inBuf, int inOff, int len)
		{
			byte[] bytes = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.Encode(inBuf, inOff, len);
			this.cshake.BlockUpdate(bytes, 0, bytes.Length);
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000EDF0C File Offset: 0x000EC10C
		private void wrapUp(int outputSize)
		{
			byte[] encOut = global::Org.BouncyCastle.Crypto.Digests.XofUtilities.RightEncode((long)(outputSize * 8));
			this.cshake.BlockUpdate(encOut, 0, encOut.Length);
			this.firstOutput = false;
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000EDF3A File Offset: 0x000EC13A
		public virtual int DoFinal(byte[] outBuf, int outOff)
		{
			if (this.firstOutput)
			{
				this.wrapUp(this.GetDigestSize());
			}
			int result = this.cshake.DoFinal(outBuf, outOff, this.GetDigestSize());
			this.Reset();
			return result;
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000EDF69 File Offset: 0x000EC169
		public virtual int DoFinal(byte[] outBuf, int outOff, int outLen)
		{
			if (this.firstOutput)
			{
				this.wrapUp(this.GetDigestSize());
			}
			int result = this.cshake.DoFinal(outBuf, outOff, outLen);
			this.Reset();
			return result;
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x000EDF93 File Offset: 0x000EC193
		public virtual int DoOutput(byte[] outBuf, int outOff, int outLen)
		{
			if (this.firstOutput)
			{
				this.wrapUp(0);
			}
			return this.cshake.DoOutput(outBuf, outOff, outLen);
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000EDFB2 File Offset: 0x000EC1B2
		public virtual void Reset()
		{
			this.cshake.Reset();
			this.firstOutput = true;
		}

		// Token: 0x04001595 RID: 5525
		private static readonly byte[] N_TUPLE_HASH = global::Org.BouncyCastle.Utilities.Strings.ToByteArray("TupleHash");

		// Token: 0x04001596 RID: 5526
		private readonly global::Org.BouncyCastle.Crypto.Digests.CShakeDigest cshake;

		// Token: 0x04001597 RID: 5527
		private readonly int bitLength;

		// Token: 0x04001598 RID: 5528
		private readonly int outputLength;

		// Token: 0x04001599 RID: 5529
		private bool firstOutput;
	}
}
