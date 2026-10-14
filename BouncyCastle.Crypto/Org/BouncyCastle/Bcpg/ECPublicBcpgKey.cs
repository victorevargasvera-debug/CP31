using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000574 RID: 1396
	public abstract class ECPublicBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x06003542 RID: 13634 RVA: 0x000FDD86 File Offset: 0x000FBF86
		protected ECPublicBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.oid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey.ReadBytesOfEncodedLength(bcpgIn)));
			this.point = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn).Value;
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x000FDDB5 File Offset: 0x000FBFB5
		protected ECPublicBcpgKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Math.EC.ECPoint point)
		{
			this.point = new global::Org.BouncyCastle.Math.BigInteger(1, point.GetEncoded(false));
			this.oid = oid;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x000FDDD7 File Offset: 0x000FBFD7
		protected ECPublicBcpgKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Math.BigInteger encodedPoint)
		{
			this.point = encodedPoint;
			this.oid = oid;
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x000FDDED File Offset: 0x000FBFED
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x000FDDF4 File Offset: 0x000FBFF4
		public override byte[] GetEncoded()
		{
			byte[] result;
			try
			{
				result = base.GetEncoded();
			}
			catch (global::System.IO.IOException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x000FDE20 File Offset: 0x000FC020
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			byte[] oid = this.oid.GetEncoded();
			bcpgOut.Write(oid, 1, oid.Length - 1);
			global::Org.BouncyCastle.Bcpg.MPInteger point = new global::Org.BouncyCastle.Bcpg.MPInteger(this.point);
			bcpgOut.WriteObject(point);
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x000FDE59 File Offset: 0x000FC059
		public virtual global::Org.BouncyCastle.Math.BigInteger EncodedPoint
		{
			get
			{
				return this.point;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x000FDE61 File Offset: 0x000FC061
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier CurveOid
		{
			get
			{
				return this.oid;
			}
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000FDE6C File Offset: 0x000FC06C
		protected static byte[] ReadBytesOfEncodedLength(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			int length = bcpgIn.ReadByte();
			if (length < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			if (length == 0 || length == 255)
			{
				throw new global::System.IO.IOException("future extensions not yet implemented");
			}
			if (length > 127)
			{
				throw new global::System.IO.IOException("unsupported OID");
			}
			byte[] buffer = new byte[length + 2];
			bcpgIn.ReadFully(buffer, 2, buffer.Length - 2);
			buffer[0] = 6;
			buffer[1] = (byte)length;
			return buffer;
		}

		// Token: 0x040017D6 RID: 6102
		internal global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid;

		// Token: 0x040017D7 RID: 6103
		internal global::Org.BouncyCastle.Math.BigInteger point;
	}
}
