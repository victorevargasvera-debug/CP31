using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200058D RID: 1421
	public class SignaturePacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x060035C1 RID: 13761 RVA: 0x000FF0F8 File Offset: 0x000FD2F8
		internal SignaturePacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.version = bcpgIn.ReadByte();
			if (this.version == 3 || this.version == 2)
			{
				bcpgIn.ReadByte();
				this.signatureType = bcpgIn.ReadByte();
				this.creationTime = ((long)bcpgIn.ReadByte() << 24 | (long)bcpgIn.ReadByte() << 16 | (long)bcpgIn.ReadByte() << 8 | (long)((ulong)bcpgIn.ReadByte())) * 1000L;
				this.keyId |= (long)bcpgIn.ReadByte() << 56;
				this.keyId |= (long)bcpgIn.ReadByte() << 48;
				this.keyId |= (long)bcpgIn.ReadByte() << 40;
				this.keyId |= (long)bcpgIn.ReadByte() << 32;
				this.keyId |= (long)bcpgIn.ReadByte() << 24;
				this.keyId |= (long)bcpgIn.ReadByte() << 16;
				this.keyId |= (long)bcpgIn.ReadByte() << 8;
				this.keyId |= (long)((ulong)bcpgIn.ReadByte());
				this.keyAlgorithm = (global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag)bcpgIn.ReadByte();
				this.hashAlgorithm = (global::Org.BouncyCastle.Bcpg.HashAlgorithmTag)bcpgIn.ReadByte();
			}
			else
			{
				if (this.version != 4)
				{
					global::Org.BouncyCastle.Utilities.IO.Streams.Drain(bcpgIn);
					throw new global::Org.BouncyCastle.Bcpg.UnsupportedPacketVersionException("unsupported version: " + this.version.ToString());
				}
				this.signatureType = bcpgIn.ReadByte();
				this.keyAlgorithm = (global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag)bcpgIn.ReadByte();
				this.hashAlgorithm = (global::Org.BouncyCastle.Bcpg.HashAlgorithmTag)bcpgIn.ReadByte();
				byte[] hashed = new byte[bcpgIn.ReadByte() << 8 | bcpgIn.ReadByte()];
				bcpgIn.ReadFully(hashed);
				global::Org.BouncyCastle.Bcpg.SignatureSubpacketsParser sIn = new global::Org.BouncyCastle.Bcpg.SignatureSubpacketsParser(new global::System.IO.MemoryStream(hashed, false));
				global::System.Collections.IList v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::Org.BouncyCastle.Bcpg.SignatureSubpacket sub;
				while ((sub = sIn.ReadPacket()) != null)
				{
					v.Add(sub);
				}
				this.hashedData = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[v.Count];
				for (int i = 0; i != this.hashedData.Length; i++)
				{
					global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = (global::Org.BouncyCastle.Bcpg.SignatureSubpacket)v[i];
					if (p is global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId)
					{
						this.keyId = ((global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId)p).KeyId;
					}
					else if (p is global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime)
					{
						this.creationTime = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(((global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime)p).GetTime());
					}
					this.hashedData[i] = p;
				}
				byte[] unhashed = new byte[bcpgIn.ReadByte() << 8 | bcpgIn.ReadByte()];
				bcpgIn.ReadFully(unhashed);
				sIn = new global::Org.BouncyCastle.Bcpg.SignatureSubpacketsParser(new global::System.IO.MemoryStream(unhashed, false));
				v.Clear();
				while ((sub = sIn.ReadPacket()) != null)
				{
					v.Add(sub);
				}
				this.unhashedData = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[v.Count];
				for (int j = 0; j != this.unhashedData.Length; j++)
				{
					global::Org.BouncyCastle.Bcpg.SignatureSubpacket p2 = (global::Org.BouncyCastle.Bcpg.SignatureSubpacket)v[j];
					if (p2 is global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId)
					{
						this.keyId = ((global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId)p2).KeyId;
					}
					this.unhashedData[j] = p2;
				}
			}
			this.fingerprint = new byte[2];
			bcpgIn.ReadFully(this.fingerprint);
			global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag publicKeyAlgorithmTag = this.keyAlgorithm;
			if (publicKeyAlgorithmTag == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral || publicKeyAlgorithmTag == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaSign)
			{
				global::Org.BouncyCastle.Bcpg.MPInteger v2 = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				this.signature = new global::Org.BouncyCastle.Bcpg.MPInteger[]
				{
					v2
				};
				return;
			}
			switch (publicKeyAlgorithmTag)
			{
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
			{
				global::Org.BouncyCastle.Bcpg.MPInteger p3 = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				global::Org.BouncyCastle.Bcpg.MPInteger g = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				global::Org.BouncyCastle.Bcpg.MPInteger y = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				this.signature = new global::Org.BouncyCastle.Bcpg.MPInteger[]
				{
					p3,
					g,
					y
				};
				return;
			}
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
			{
				global::Org.BouncyCastle.Bcpg.MPInteger r = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				global::Org.BouncyCastle.Bcpg.MPInteger s = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				this.signature = new global::Org.BouncyCastle.Bcpg.MPInteger[]
				{
					r,
					s
				};
				return;
			}
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
			{
				global::Org.BouncyCastle.Bcpg.MPInteger ecR = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				global::Org.BouncyCastle.Bcpg.MPInteger ecS = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
				this.signature = new global::Org.BouncyCastle.Bcpg.MPInteger[]
				{
					ecR,
					ecS
				};
				return;
			}
			}
			if (this.keyAlgorithm >= global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Experimental_1 && this.keyAlgorithm <= global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Experimental_11)
			{
				this.signature = null;
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				int ch;
				while ((ch = bcpgIn.ReadByte()) >= 0)
				{
					bOut.WriteByte((byte)ch);
				}
				this.signatureEncoding = bOut.ToArray();
				return;
			}
			throw new global::System.IO.IOException("unknown signature key algorithm: " + this.keyAlgorithm.ToString());
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x000FF550 File Offset: 0x000FD750
		public SignaturePacket(int signatureType, long keyId, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] hashedData, global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] unhashedData, byte[] fingerprint, global::Org.BouncyCastle.Bcpg.MPInteger[] signature) : this(4, signatureType, keyId, keyAlgorithm, hashAlgorithm, hashedData, unhashedData, fingerprint, signature)
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x000FF574 File Offset: 0x000FD774
		public SignaturePacket(int version, int signatureType, long keyId, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, long creationTime, byte[] fingerprint, global::Org.BouncyCastle.Bcpg.MPInteger[] signature) : this(version, signatureType, keyId, keyAlgorithm, hashAlgorithm, null, null, fingerprint, signature)
		{
			this.creationTime = creationTime;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x000FF59C File Offset: 0x000FD79C
		public SignaturePacket(int version, int signatureType, long keyId, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] hashedData, global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] unhashedData, byte[] fingerprint, global::Org.BouncyCastle.Bcpg.MPInteger[] signature)
		{
			this.version = version;
			this.signatureType = signatureType;
			this.keyId = keyId;
			this.keyAlgorithm = keyAlgorithm;
			this.hashAlgorithm = hashAlgorithm;
			this.hashedData = hashedData;
			this.unhashedData = unhashedData;
			this.fingerprint = fingerprint;
			this.signature = signature;
			if (hashedData != null)
			{
				this.setCreationTime();
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x000FF5FE File Offset: 0x000FD7FE
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000FF606 File Offset: 0x000FD806
		public int SignatureType
		{
			get
			{
				return this.signatureType;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x000FF60E File Offset: 0x000FD80E
		public long KeyId
		{
			get
			{
				return this.keyId;
			}
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000FF618 File Offset: 0x000FD818
		public byte[] GetSignatureTrailer()
		{
			byte[] trailer;
			if (this.version == 3)
			{
				trailer = new byte[5];
				long time = this.creationTime / 1000L;
				trailer[0] = (byte)this.signatureType;
				trailer[1] = (byte)(time >> 24);
				trailer[2] = (byte)(time >> 16);
				trailer[3] = (byte)(time >> 8);
				trailer[4] = (byte)time;
			}
			else
			{
				global::System.IO.MemoryStream sOut = new global::System.IO.MemoryStream();
				sOut.WriteByte((byte)this.Version);
				sOut.WriteByte((byte)this.SignatureType);
				sOut.WriteByte((byte)this.KeyAlgorithm);
				sOut.WriteByte((byte)this.HashAlgorithm);
				global::System.IO.MemoryStream hOut = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] hashed = this.GetHashedSubPackets();
				for (int i = 0; i != hashed.Length; i++)
				{
					hashed[i].Encode(hOut);
				}
				byte[] data = hOut.ToArray();
				sOut.WriteByte((byte)(data.Length >> 8));
				sOut.WriteByte((byte)data.Length);
				sOut.Write(data, 0, data.Length);
				byte[] hData = sOut.ToArray();
				sOut.WriteByte((byte)this.Version);
				sOut.WriteByte(byte.MaxValue);
				sOut.WriteByte((byte)(hData.Length >> 24));
				sOut.WriteByte((byte)(hData.Length >> 16));
				sOut.WriteByte((byte)(hData.Length >> 8));
				sOut.WriteByte((byte)hData.Length);
				trailer = sOut.ToArray();
			}
			return trailer;
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x000FF75F File Offset: 0x000FD95F
		public global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag KeyAlgorithm
		{
			get
			{
				return this.keyAlgorithm;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x000FF767 File Offset: 0x000FD967
		public global::Org.BouncyCastle.Bcpg.HashAlgorithmTag HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x000FF76F File Offset: 0x000FD96F
		public global::Org.BouncyCastle.Bcpg.MPInteger[] GetSignature()
		{
			return this.signature;
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000FF778 File Offset: 0x000FD978
		public byte[] GetSignatureBytes()
		{
			if (this.signatureEncoding != null)
			{
				return (byte[])this.signatureEncoding.Clone();
			}
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(bOut);
			foreach (global::Org.BouncyCastle.Bcpg.MPInteger sigObj in this.signature)
			{
				try
				{
					bcOut.WriteObject(sigObj);
				}
				catch (global::System.IO.IOException e)
				{
					string str = "internal error: ";
					global::System.IO.IOException ex = e;
					throw new global::System.Exception(str + ((ex != null) ? ex.ToString() : null));
				}
			}
			return bOut.ToArray();
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x000FF808 File Offset: 0x000FDA08
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] GetHashedSubPackets()
		{
			return this.hashedData;
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x000FF810 File Offset: 0x000FDA10
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] GetUnhashedSubPackets()
		{
			return this.unhashedData;
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x000FF818 File Offset: 0x000FDA18
		public long CreationTime
		{
			get
			{
				return this.creationTime;
			}
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x000FF820 File Offset: 0x000FDA20
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(bOut);
			pOut.WriteByte((byte)this.version);
			if (this.version == 3 || this.version == 2)
			{
				pOut.Write(new byte[]
				{
					5,
					(byte)this.signatureType
				});
				pOut.WriteInt((int)(this.creationTime / 1000L));
				pOut.WriteLong(this.keyId);
				pOut.Write(new byte[]
				{
					(byte)this.keyAlgorithm,
					(byte)this.hashAlgorithm
				});
			}
			else
			{
				if (this.version != 4)
				{
					throw new global::System.IO.IOException("unknown version: " + this.version.ToString());
				}
				pOut.Write(new byte[]
				{
					(byte)this.signatureType,
					(byte)this.keyAlgorithm,
					(byte)this.hashAlgorithm
				});
				global::Org.BouncyCastle.Bcpg.SignaturePacket.EncodeLengthAndData(pOut, global::Org.BouncyCastle.Bcpg.SignaturePacket.GetEncodedSubpackets(this.hashedData));
				global::Org.BouncyCastle.Bcpg.SignaturePacket.EncodeLengthAndData(pOut, global::Org.BouncyCastle.Bcpg.SignaturePacket.GetEncodedSubpackets(this.unhashedData));
			}
			pOut.Write(this.fingerprint);
			if (this.signature != null)
			{
				global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOutputStream = pOut;
				global::Org.BouncyCastle.Bcpg.BcpgObject[] v = this.signature;
				bcpgOutputStream.WriteObjects(v);
			}
			else
			{
				pOut.Write(this.signatureEncoding);
			}
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.Signature, bOut.ToArray(), true);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000FF965 File Offset: 0x000FDB65
		private static void EncodeLengthAndData(global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut, byte[] data)
		{
			pOut.WriteShort((short)data.Length);
			pOut.Write(data);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x000FF978 File Offset: 0x000FDB78
		private static byte[] GetEncodedSubpackets(global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] ps)
		{
			global::System.IO.MemoryStream sOut = new global::System.IO.MemoryStream();
			for (int i = 0; i < ps.Length; i++)
			{
				ps[i].Encode(sOut);
			}
			return sOut.ToArray();
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000FF9AC File Offset: 0x000FDBAC
		private void setCreationTime()
		{
			foreach (global::Org.BouncyCastle.Bcpg.SignatureSubpacket p in this.hashedData)
			{
				if (p is global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime)
				{
					this.creationTime = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(((global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime)p).GetTime());
					return;
				}
			}
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000FF9F1 File Offset: 0x000FDBF1
		public static global::Org.BouncyCastle.Bcpg.SignaturePacket FromByteArray(byte[] data)
		{
			return new global::Org.BouncyCastle.Bcpg.SignaturePacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(new global::System.IO.MemoryStream(data)));
		}

		// Token: 0x0400184E RID: 6222
		private int version;

		// Token: 0x0400184F RID: 6223
		private int signatureType;

		// Token: 0x04001850 RID: 6224
		private long creationTime;

		// Token: 0x04001851 RID: 6225
		private long keyId;

		// Token: 0x04001852 RID: 6226
		private global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm;

		// Token: 0x04001853 RID: 6227
		private global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm;

		// Token: 0x04001854 RID: 6228
		private global::Org.BouncyCastle.Bcpg.MPInteger[] signature;

		// Token: 0x04001855 RID: 6229
		private byte[] fingerprint;

		// Token: 0x04001856 RID: 6230
		private global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] hashedData;

		// Token: 0x04001857 RID: 6231
		private global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] unhashedData;

		// Token: 0x04001858 RID: 6232
		private byte[] signatureEncoding;
	}
}
