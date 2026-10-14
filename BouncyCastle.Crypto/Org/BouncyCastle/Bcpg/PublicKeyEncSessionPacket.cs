using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000585 RID: 1413
	public class PublicKeyEncSessionPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x06003581 RID: 13697 RVA: 0x000FE534 File Offset: 0x000FC734
		internal PublicKeyEncSessionPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.version = bcpgIn.ReadByte();
			this.keyId |= (long)bcpgIn.ReadByte() << 56;
			this.keyId |= (long)bcpgIn.ReadByte() << 48;
			this.keyId |= (long)bcpgIn.ReadByte() << 40;
			this.keyId |= (long)bcpgIn.ReadByte() << 32;
			this.keyId |= (long)bcpgIn.ReadByte() << 24;
			this.keyId |= (long)bcpgIn.ReadByte() << 16;
			this.keyId |= (long)bcpgIn.ReadByte() << 8;
			this.keyId |= (long)((ulong)bcpgIn.ReadByte());
			this.algorithm = (global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag)bcpgIn.ReadByte();
			global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag publicKeyAlgorithmTag = this.algorithm;
			if (publicKeyAlgorithmTag - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 1)
			{
				switch (publicKeyAlgorithmTag)
				{
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
				{
					global::Org.BouncyCastle.Bcpg.MPInteger p = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
					global::Org.BouncyCastle.Bcpg.MPInteger g = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
					this.data = new byte[][]
					{
						p.GetEncoded(),
						g.GetEncoded()
					};
					return;
				}
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
					this.data = new byte[][]
					{
						global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(bcpgIn)
					};
					return;
				}
				throw new global::System.IO.IOException("unknown PGP public key algorithm encountered");
			}
			this.data = new byte[][]
			{
				new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn).GetEncoded()
			};
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x000FE6A8 File Offset: 0x000FC8A8
		public PublicKeyEncSessionPacket(long keyId, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, byte[][] data)
		{
			this.version = 3;
			this.keyId = keyId;
			this.algorithm = algorithm;
			this.data = new byte[data.Length][];
			for (int i = 0; i < data.Length; i++)
			{
				this.data[i] = global::Org.BouncyCastle.Utilities.Arrays.Clone(data[i]);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x000FE6FC File Offset: 0x000FC8FC
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x000FE704 File Offset: 0x000FC904
		public long KeyId
		{
			get
			{
				return this.keyId;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x000FE70C File Offset: 0x000FC90C
		public global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x000FE714 File Offset: 0x000FC914
		public byte[][] GetEncSessionKey()
		{
			return this.data;
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x000FE71C File Offset: 0x000FC91C
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(bOut);
			pOut.WriteByte((byte)this.version);
			pOut.WriteLong(this.keyId);
			pOut.WriteByte((byte)this.algorithm);
			for (int i = 0; i < this.data.Length; i++)
			{
				pOut.Write(this.data[i]);
			}
			global::Org.BouncyCastle.Utilities.Platform.Dispose(pOut);
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.PublicKeyEncryptedSession, bOut.ToArray(), true);
		}

		// Token: 0x04001827 RID: 6183
		private int version;

		// Token: 0x04001828 RID: 6184
		private long keyId;

		// Token: 0x04001829 RID: 6185
		private global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm;

		// Token: 0x0400182A RID: 6186
		private byte[][] data;
	}
}
