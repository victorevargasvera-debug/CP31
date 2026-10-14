using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B2 RID: 1458
	public class PgpObjectFactory
	{
		// Token: 0x06003668 RID: 13928 RVA: 0x0010193B File Offset: 0x000FFB3B
		public PgpObjectFactory(global::System.IO.Stream inputStream)
		{
			this.bcpgIn = global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(inputStream);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0010194F File Offset: 0x000FFB4F
		public PgpObjectFactory(byte[] bytes) : this(new global::System.IO.MemoryStream(bytes, false))
		{
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x00101960 File Offset: 0x000FFB60
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject NextPgpObject()
		{
			global::Org.BouncyCastle.Bcpg.PacketTag tag = this.bcpgIn.NextPacketTag();
			if (tag == (global::Org.BouncyCastle.Bcpg.PacketTag)(-1))
			{
				return null;
			}
			switch (tag)
			{
			case global::Org.BouncyCastle.Bcpg.PacketTag.PublicKeyEncryptedSession:
			case global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncryptedSessionKey:
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataList(this.bcpgIn);
			case global::Org.BouncyCastle.Bcpg.PacketTag.Signature:
			{
				global::System.Collections.IList i = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				while (this.bcpgIn.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.Signature)
				{
					try
					{
						i.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature(this.bcpgIn));
					}
					catch (global::Org.BouncyCastle.Bcpg.UnsupportedPacketVersionException)
					{
					}
					catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException e)
					{
						string str = "can't create signature object: ";
						global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex = e;
						throw new global::System.IO.IOException(str + ((ex != null) ? ex.ToString() : null));
					}
				}
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[] sigs = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[i.Count];
				for (int j = 0; j < i.Count; j++)
				{
					sigs[j] = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)i[j];
				}
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureList(sigs);
			}
			case global::Org.BouncyCastle.Bcpg.PacketTag.OnePassSignature:
			{
				global::System.Collections.IList k = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				while (this.bcpgIn.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.OnePassSignature)
				{
					try
					{
						k.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature(this.bcpgIn));
					}
					catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException e2)
					{
						string str2 = "can't create one pass signature object: ";
						global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex2 = e2;
						throw new global::System.IO.IOException(str2 + ((ex2 != null) ? ex2.ToString() : null));
					}
				}
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature[] sigs2 = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature[k.Count];
				for (int l = 0; l < k.Count; l++)
				{
					sigs2[l] = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature)k[l];
				}
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignatureList(sigs2);
			}
			case global::Org.BouncyCastle.Bcpg.PacketTag.SecretKey:
				try
				{
					return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing(this.bcpgIn);
				}
				catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException e3)
				{
					string str3 = "can't create secret key object: ";
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex3 = e3;
					throw new global::System.IO.IOException(str3 + ((ex3 != null) ? ex3.ToString() : null));
				}
				break;
			case global::Org.BouncyCastle.Bcpg.PacketTag.PublicKey:
				break;
			case global::Org.BouncyCastle.Bcpg.PacketTag.SecretSubkey:
			case global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncrypted:
				goto IL_1E1;
			case global::Org.BouncyCastle.Bcpg.PacketTag.CompressedData:
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpCompressedData(this.bcpgIn);
			case global::Org.BouncyCastle.Bcpg.PacketTag.Marker:
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpMarker(this.bcpgIn);
			case global::Org.BouncyCastle.Bcpg.PacketTag.LiteralData:
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpLiteralData(this.bcpgIn);
			default:
				if (tag - global::Org.BouncyCastle.Bcpg.PacketTag.Experimental1 > 3)
				{
					goto IL_1E1;
				}
				return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpExperimental(this.bcpgIn);
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing(this.bcpgIn);
			IL_1E1:
			throw new global::System.IO.IOException("unknown object in stream " + this.bcpgIn.NextPacketTag().ToString());
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00101BB0 File Offset: 0x000FFDB0
		[global::System.Obsolete("Use NextPgpObject() instead")]
		public object NextObject()
		{
			return this.NextPgpObject();
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x00101BB8 File Offset: 0x000FFDB8
		public global::System.Collections.IList AllPgpObjects()
		{
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject pgpObject;
			while ((pgpObject = this.NextPgpObject()) != null)
			{
				result.Add(pgpObject);
			}
			return result;
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x00101BE0 File Offset: 0x000FFDE0
		public global::System.Collections.IList FilterPgpObjects(global::System.Type type)
		{
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject pgpObject;
			while ((pgpObject = this.NextPgpObject()) != null)
			{
				if (type.IsInstanceOfType(pgpObject))
				{
					result.Add(pgpObject);
				}
			}
			return result;
		}

		// Token: 0x040018D0 RID: 6352
		private readonly global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn;
	}
}
