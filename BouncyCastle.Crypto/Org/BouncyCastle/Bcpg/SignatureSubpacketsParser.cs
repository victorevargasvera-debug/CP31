using System;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200058F RID: 1423
	public class SignatureSubpacketsParser
	{
		// Token: 0x060035DD RID: 13789 RVA: 0x000FFBD2 File Offset: 0x000FDDD2
		public SignatureSubpacketsParser(global::System.IO.Stream input)
		{
			this.input = input;
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x000FFBE4 File Offset: 0x000FDDE4
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacket ReadPacket()
		{
			int i = this.input.ReadByte();
			if (i < 0)
			{
				return null;
			}
			bool isLongLength = false;
			int bodyLen;
			if (i < 192)
			{
				bodyLen = i;
			}
			else if (i <= 223)
			{
				bodyLen = (i - 192 << 8) + this.input.ReadByte() + 192;
			}
			else
			{
				if (i != 255)
				{
					throw new global::System.IO.IOException("unexpected length header");
				}
				isLongLength = true;
				bodyLen = (this.input.ReadByte() << 24 | this.input.ReadByte() << 16 | this.input.ReadByte() << 8 | this.input.ReadByte());
			}
			int num = this.input.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("unexpected EOF reading signature sub packet");
			}
			if (bodyLen <= 0)
			{
				throw new global::System.IO.EndOfStreamException("out of range data found in signature sub packet");
			}
			byte[] data = new byte[bodyLen - 1];
			int bytesRead = global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this.input, data);
			bool isCritical = (num & 128) != 0;
			global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type = (global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag)(num & 127);
			if (bytesRead != data.Length)
			{
				if (type <= global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.ExpireTime)
				{
					if (type == global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime)
					{
						data = this.CheckData(data, 4, bytesRead, "Signature Creation Time");
						goto IL_161;
					}
					if (type == global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.ExpireTime)
					{
						data = this.CheckData(data, 4, bytesRead, "Signature Expiration Time");
						goto IL_161;
					}
				}
				else
				{
					if (type == global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyExpireTime)
					{
						data = this.CheckData(data, 4, bytesRead, "Signature Key Expiration Time");
						goto IL_161;
					}
					if (type == global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId)
					{
						data = this.CheckData(data, 8, bytesRead, "Issuer");
						goto IL_161;
					}
				}
				throw new global::System.IO.EndOfStreamException("truncated subpacket data.");
			}
			IL_161:
			switch (type)
			{
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime:
				return new global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.ExpireTime:
				return new global::Org.BouncyCastle.Bcpg.Sig.SignatureExpirationTime(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Exportable:
				return new global::Org.BouncyCastle.Bcpg.Sig.Exportable(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.TrustSig:
				return new global::Org.BouncyCastle.Bcpg.Sig.TrustSignature(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Revocable:
				return new global::Org.BouncyCastle.Bcpg.Sig.Revocable(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyExpireTime:
				return new global::Org.BouncyCastle.Bcpg.Sig.KeyExpirationTime(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredSymmetricAlgorithms:
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredHashAlgorithms:
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredCompressionAlgorithms:
				return new global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms(type, isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId:
				return new global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.NotationData:
				return new global::Org.BouncyCastle.Bcpg.Sig.NotationData(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PrimaryUserId:
				return new global::Org.BouncyCastle.Bcpg.Sig.PrimaryUserId(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyFlags:
				return new global::Org.BouncyCastle.Bcpg.Sig.KeyFlags(isCritical, isLongLength, data);
			case global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.SignerUserId:
				return new global::Org.BouncyCastle.Bcpg.Sig.SignerUserId(isCritical, isLongLength, data);
			}
			return new global::Org.BouncyCastle.Bcpg.SignatureSubpacket(type, isCritical, isLongLength, data);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000FFE4E File Offset: 0x000FE04E
		private byte[] CheckData(byte[] data, int expected, int bytesRead, string name)
		{
			if (bytesRead != expected)
			{
				throw new global::System.IO.EndOfStreamException("truncated " + name + " subpacket data.");
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(data, 0, expected);
		}

		// Token: 0x0400185D RID: 6237
		private readonly global::System.IO.Stream input;
	}
}
