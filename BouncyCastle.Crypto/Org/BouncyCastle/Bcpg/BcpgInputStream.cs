using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000569 RID: 1385
	public class BcpgInputStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
	{
		// Token: 0x060034F9 RID: 13561 RVA: 0x000FCFA4 File Offset: 0x000FB1A4
		internal static global::Org.BouncyCastle.Bcpg.BcpgInputStream Wrap(global::System.IO.Stream inStr)
		{
			if (inStr is global::Org.BouncyCastle.Bcpg.BcpgInputStream)
			{
				return (global::Org.BouncyCastle.Bcpg.BcpgInputStream)inStr;
			}
			return new global::Org.BouncyCastle.Bcpg.BcpgInputStream(inStr);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x000FCFBB File Offset: 0x000FB1BB
		private BcpgInputStream(global::System.IO.Stream inputStream)
		{
			this.m_in = inputStream;
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000FCFCA File Offset: 0x000FB1CA
		public override int ReadByte()
		{
			if (this.next)
			{
				this.next = false;
				return this.nextB;
			}
			return this.m_in.ReadByte();
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000FCFF0 File Offset: 0x000FB1F0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (!this.next)
			{
				return this.m_in.Read(buffer, offset, count);
			}
			if (this.nextB < 0)
			{
				return 0;
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			buffer[offset] = (byte)this.nextB;
			this.next = false;
			return 1;
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000FD03F File Offset: 0x000FB23F
		public byte[] ReadAll()
		{
			return global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(this);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000FD047 File Offset: 0x000FB247
		public void ReadFully(byte[] buffer, int off, int len)
		{
			if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this, buffer, off, len) < len)
			{
				throw new global::System.IO.EndOfStreamException();
			}
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000FD05B File Offset: 0x000FB25B
		public void ReadFully(byte[] buffer)
		{
			this.ReadFully(buffer, 0, buffer.Length);
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000FD068 File Offset: 0x000FB268
		public global::Org.BouncyCastle.Bcpg.PacketTag NextPacketTag()
		{
			if (!this.next)
			{
				try
				{
					this.nextB = this.m_in.ReadByte();
				}
				catch (global::System.IO.EndOfStreamException)
				{
					this.nextB = -1;
				}
				this.next = true;
			}
			if (this.nextB < 0)
			{
				return (global::Org.BouncyCastle.Bcpg.PacketTag)this.nextB;
			}
			int maskB = this.nextB & 63;
			if ((this.nextB & 64) == 0)
			{
				maskB >>= 2;
			}
			return (global::Org.BouncyCastle.Bcpg.PacketTag)maskB;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000FD0DC File Offset: 0x000FB2DC
		public global::Org.BouncyCastle.Bcpg.Packet ReadPacket()
		{
			int hdr = this.ReadByte();
			if (hdr < 0)
			{
				return null;
			}
			if ((hdr & 128) == 0)
			{
				throw new global::System.IO.IOException("invalid header encountered");
			}
			bool flag = (hdr & 64) != 0;
			int bodyLen = 0;
			bool partial = false;
			global::Org.BouncyCastle.Bcpg.PacketTag tag;
			if (flag)
			{
				tag = (global::Org.BouncyCastle.Bcpg.PacketTag)(hdr & 63);
				int i = this.ReadByte();
				if (i < 192)
				{
					bodyLen = i;
				}
				else if (i <= 223)
				{
					int b = this.m_in.ReadByte();
					bodyLen = (i - 192 << 8) + b + 192;
				}
				else if (i == 255)
				{
					bodyLen = (this.m_in.ReadByte() << 24 | this.m_in.ReadByte() << 16 | this.m_in.ReadByte() << 8 | this.m_in.ReadByte());
				}
				else
				{
					partial = true;
					bodyLen = 1 << i;
				}
			}
			else
			{
				int lengthType = hdr & 3;
				tag = (global::Org.BouncyCastle.Bcpg.PacketTag)((hdr & 63) >> 2);
				switch (lengthType)
				{
				case 0:
					bodyLen = this.ReadByte();
					break;
				case 1:
					bodyLen = (this.ReadByte() << 8 | this.ReadByte());
					break;
				case 2:
					bodyLen = (this.ReadByte() << 24 | this.ReadByte() << 16 | this.ReadByte() << 8 | this.ReadByte());
					break;
				case 3:
					partial = true;
					break;
				default:
					throw new global::System.IO.IOException("unknown length type encountered");
				}
			}
			global::Org.BouncyCastle.Bcpg.BcpgInputStream objStream;
			if (bodyLen == 0 && partial)
			{
				objStream = this;
			}
			else
			{
				objStream = new global::Org.BouncyCastle.Bcpg.BcpgInputStream(new global::System.IO.BufferedStream(new global::Org.BouncyCastle.Bcpg.BcpgInputStream.PartialInputStream(this, partial, bodyLen)));
			}
			switch (tag)
			{
			case global::Org.BouncyCastle.Bcpg.PacketTag.Reserved:
				return new global::Org.BouncyCastle.Bcpg.InputStreamPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.PublicKeyEncryptedSession:
				return new global::Org.BouncyCastle.Bcpg.PublicKeyEncSessionPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.Signature:
				return new global::Org.BouncyCastle.Bcpg.SignaturePacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncryptedSessionKey:
				return new global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.OnePassSignature:
				return new global::Org.BouncyCastle.Bcpg.OnePassSignaturePacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.SecretKey:
				return new global::Org.BouncyCastle.Bcpg.SecretKeyPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.PublicKey:
				return new global::Org.BouncyCastle.Bcpg.PublicKeyPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.SecretSubkey:
				return new global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.CompressedData:
				return new global::Org.BouncyCastle.Bcpg.CompressedDataPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncrypted:
				return new global::Org.BouncyCastle.Bcpg.SymmetricEncDataPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.Marker:
				return new global::Org.BouncyCastle.Bcpg.MarkerPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.LiteralData:
				return new global::Org.BouncyCastle.Bcpg.LiteralDataPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.Trust:
				return new global::Org.BouncyCastle.Bcpg.TrustPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.UserId:
				return new global::Org.BouncyCastle.Bcpg.UserIdPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.PublicSubkey:
				return new global::Org.BouncyCastle.Bcpg.PublicSubkeyPacket(objStream);
			case (global::Org.BouncyCastle.Bcpg.PacketTag)15:
			case (global::Org.BouncyCastle.Bcpg.PacketTag)16:
				break;
			case global::Org.BouncyCastle.Bcpg.PacketTag.UserAttribute:
				return new global::Org.BouncyCastle.Bcpg.UserAttributePacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricEncryptedIntegrityProtected:
				return new global::Org.BouncyCastle.Bcpg.SymmetricEncIntegrityPacket(objStream);
			case global::Org.BouncyCastle.Bcpg.PacketTag.ModificationDetectionCode:
				return new global::Org.BouncyCastle.Bcpg.ModDetectionCodePacket(objStream);
			default:
				if (tag - global::Org.BouncyCastle.Bcpg.PacketTag.Experimental1 <= 3)
				{
					return new global::Org.BouncyCastle.Bcpg.ExperimentalPacket(tag, objStream);
				}
				break;
			}
			throw new global::System.IO.IOException("unknown packet type encountered: " + tag.ToString());
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000FD370 File Offset: 0x000FB570
		public global::Org.BouncyCastle.Bcpg.PacketTag SkipMarkerPackets()
		{
			global::Org.BouncyCastle.Bcpg.PacketTag tag;
			while ((tag = this.NextPacketTag()) == global::Org.BouncyCastle.Bcpg.PacketTag.Marker)
			{
				this.ReadPacket();
			}
			return tag;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000FD393 File Offset: 0x000FB593
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.m_in);
			base.Close();
		}

		// Token: 0x040017BC RID: 6076
		private global::System.IO.Stream m_in;

		// Token: 0x040017BD RID: 6077
		private bool next;

		// Token: 0x040017BE RID: 6078
		private int nextB;

		// Token: 0x02000843 RID: 2115
		private class PartialInputStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
		{
			// Token: 0x06004730 RID: 18224 RVA: 0x0013AD11 File Offset: 0x00138F11
			internal PartialInputStream(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn, bool partial, int dataLength)
			{
				this.m_in = bcpgIn;
				this.partial = partial;
				this.dataLength = dataLength;
			}

			// Token: 0x06004731 RID: 18225 RVA: 0x0013AD30 File Offset: 0x00138F30
			public override int ReadByte()
			{
				while (this.dataLength == 0)
				{
					if (!this.partial || this.ReadPartialDataLength() < 0)
					{
						return -1;
					}
				}
				int num = this.m_in.ReadByte();
				if (num < 0)
				{
					throw new global::System.IO.EndOfStreamException("Premature end of stream in PartialInputStream");
				}
				this.dataLength--;
				return num;
			}

			// Token: 0x06004732 RID: 18226 RVA: 0x0013AD80 File Offset: 0x00138F80
			public override int Read(byte[] buffer, int offset, int count)
			{
				while (this.dataLength == 0)
				{
					if (!this.partial || this.ReadPartialDataLength() < 0)
					{
						return 0;
					}
				}
				int readLen = (this.dataLength > count || this.dataLength < 0) ? count : this.dataLength;
				int len = this.m_in.Read(buffer, offset, readLen);
				if (len < 1)
				{
					throw new global::System.IO.EndOfStreamException("Premature end of stream in PartialInputStream");
				}
				this.dataLength -= len;
				return len;
			}

			// Token: 0x06004733 RID: 18227 RVA: 0x0013ADF4 File Offset: 0x00138FF4
			private int ReadPartialDataLength()
			{
				int i = this.m_in.ReadByte();
				if (i < 0)
				{
					return -1;
				}
				this.partial = false;
				if (i < 192)
				{
					this.dataLength = i;
				}
				else if (i <= 223)
				{
					this.dataLength = (i - 192 << 8) + this.m_in.ReadByte() + 192;
				}
				else if (i == 255)
				{
					this.dataLength = (this.m_in.ReadByte() << 24 | this.m_in.ReadByte() << 16 | this.m_in.ReadByte() << 8 | this.m_in.ReadByte());
				}
				else
				{
					this.partial = true;
					this.dataLength = 1 << i;
				}
				return 0;
			}

			// Token: 0x040025A8 RID: 9640
			private global::Org.BouncyCastle.Bcpg.BcpgInputStream m_in;

			// Token: 0x040025A9 RID: 9641
			private bool partial;

			// Token: 0x040025AA RID: 9642
			private int dataLength;
		}
	}
}
