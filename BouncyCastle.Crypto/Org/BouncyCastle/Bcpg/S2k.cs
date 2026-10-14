using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200058A RID: 1418
	public class S2k : global::Org.BouncyCastle.Bcpg.BcpgObject
	{
		// Token: 0x060035A7 RID: 13735 RVA: 0x000FEC58 File Offset: 0x000FCE58
		internal S2k(global::System.IO.Stream inStr)
		{
			this.type = inStr.ReadByte();
			this.algorithm = (global::Org.BouncyCastle.Bcpg.HashAlgorithmTag)inStr.ReadByte();
			if (this.type != 101)
			{
				if (this.type != 0)
				{
					this.iv = new byte[8];
					if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr, this.iv, 0, this.iv.Length) < this.iv.Length)
					{
						throw new global::System.IO.EndOfStreamException();
					}
					if (this.type == 3)
					{
						this.itCount = inStr.ReadByte();
						return;
					}
				}
			}
			else
			{
				inStr.ReadByte();
				inStr.ReadByte();
				inStr.ReadByte();
				this.protectionMode = inStr.ReadByte();
			}
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000FED0B File Offset: 0x000FCF0B
		public S2k(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag algorithm)
		{
			this.type = 0;
			this.algorithm = algorithm;
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000FED2F File Offset: 0x000FCF2F
		public S2k(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag algorithm, byte[] iv)
		{
			this.type = 1;
			this.algorithm = algorithm;
			this.iv = iv;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x000FED5A File Offset: 0x000FCF5A
		public S2k(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag algorithm, byte[] iv, int itCount)
		{
			this.type = 3;
			this.algorithm = algorithm;
			this.iv = iv;
			this.itCount = itCount;
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x000FED8C File Offset: 0x000FCF8C
		public virtual int Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x000FED94 File Offset: 0x000FCF94
		public virtual global::Org.BouncyCastle.Bcpg.HashAlgorithmTag HashAlgorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x000FED9C File Offset: 0x000FCF9C
		public virtual byte[] GetIV()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.iv);
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x000FEDA9 File Offset: 0x000FCFA9
		[global::System.Obsolete("Use 'IterationCount' property instead")]
		public long GetIterationCount()
		{
			return this.IterationCount;
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x000FEDB1 File Offset: 0x000FCFB1
		public virtual long IterationCount
		{
			get
			{
				return (long)((long)(16 + (this.itCount & 15)) << (this.itCount >> 4) + 6);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x000FEDCE File Offset: 0x000FCFCE
		public virtual int ProtectionMode
		{
			get
			{
				return this.protectionMode;
			}
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x000FEDD8 File Offset: 0x000FCFD8
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteByte((byte)this.type);
			bcpgOut.WriteByte((byte)this.algorithm);
			if (this.type != 101)
			{
				if (this.type != 0)
				{
					bcpgOut.Write(this.iv);
				}
				if (this.type == 3)
				{
					bcpgOut.WriteByte((byte)this.itCount);
					return;
				}
			}
			else
			{
				bcpgOut.WriteByte(71);
				bcpgOut.WriteByte(78);
				bcpgOut.WriteByte(85);
				bcpgOut.WriteByte((byte)this.protectionMode);
			}
		}

		// Token: 0x04001839 RID: 6201
		private const int ExpBias = 6;

		// Token: 0x0400183A RID: 6202
		public const int Simple = 0;

		// Token: 0x0400183B RID: 6203
		public const int Salted = 1;

		// Token: 0x0400183C RID: 6204
		public const int SaltedAndIterated = 3;

		// Token: 0x0400183D RID: 6205
		public const int GnuDummyS2K = 101;

		// Token: 0x0400183E RID: 6206
		public const int GnuProtectionModeNoPrivateKey = 1;

		// Token: 0x0400183F RID: 6207
		public const int GnuProtectionModeDivertToCard = 2;

		// Token: 0x04001840 RID: 6208
		internal int type;

		// Token: 0x04001841 RID: 6209
		internal global::Org.BouncyCastle.Bcpg.HashAlgorithmTag algorithm;

		// Token: 0x04001842 RID: 6210
		internal byte[] iv;

		// Token: 0x04001843 RID: 6211
		internal int itCount = -1;

		// Token: 0x04001844 RID: 6212
		internal int protectionMode = -1;
	}
}
