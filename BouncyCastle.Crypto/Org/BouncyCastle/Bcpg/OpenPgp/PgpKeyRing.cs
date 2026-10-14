using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005AB RID: 1451
	public abstract class PgpKeyRing : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x06003641 RID: 13889 RVA: 0x001010A0 File Offset: 0x000FF2A0
		internal PgpKeyRing()
		{
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x001010A8 File Offset: 0x000FF2A8
		internal static global::Org.BouncyCastle.Bcpg.TrustPacket ReadOptionalTrustPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream pIn)
		{
			if (pIn.SkipMarkerPackets() != global::Org.BouncyCastle.Bcpg.PacketTag.Trust)
			{
				return null;
			}
			return (global::Org.BouncyCastle.Bcpg.TrustPacket)pIn.ReadPacket();
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x001010C4 File Offset: 0x000FF2C4
		internal static global::System.Collections.IList ReadSignaturesAndTrust(global::Org.BouncyCastle.Bcpg.BcpgInputStream pIn)
		{
			global::System.Collections.IList result;
			try
			{
				global::System.Collections.IList sigList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				while (pIn.SkipMarkerPackets() == global::Org.BouncyCastle.Bcpg.PacketTag.Signature)
				{
					global::Org.BouncyCastle.Bcpg.SignaturePacket signaturePacket = (global::Org.BouncyCastle.Bcpg.SignaturePacket)pIn.ReadPacket();
					global::Org.BouncyCastle.Bcpg.TrustPacket trustPacket = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(pIn);
					sigList.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature(signaturePacket, trustPacket));
				}
				result = sigList;
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException e)
			{
				throw new global::System.IO.IOException("can't create signature object: " + e.Message, e);
			}
			return result;
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00101134 File Offset: 0x000FF334
		internal static void ReadUserIDs(global::Org.BouncyCastle.Bcpg.BcpgInputStream pIn, out global::System.Collections.IList ids, out global::System.Collections.IList idTrusts, out global::System.Collections.IList idSigs)
		{
			ids = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			idTrusts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			idSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.IsUserTag(pIn.SkipMarkerPackets()))
			{
				global::Org.BouncyCastle.Bcpg.Packet obj = pIn.ReadPacket();
				if (obj is global::Org.BouncyCastle.Bcpg.UserIdPacket)
				{
					global::Org.BouncyCastle.Bcpg.UserIdPacket id = (global::Org.BouncyCastle.Bcpg.UserIdPacket)obj;
					ids.Add(id.GetId());
				}
				else
				{
					global::Org.BouncyCastle.Bcpg.UserAttributePacket user = (global::Org.BouncyCastle.Bcpg.UserAttributePacket)obj;
					ids.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector(user.GetSubpackets()));
				}
				idTrusts.Add(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(pIn));
				idSigs.Add(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadSignaturesAndTrust(pIn));
			}
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x001011C1 File Offset: 0x000FF3C1
		private static bool IsUserTag(global::Org.BouncyCastle.Bcpg.PacketTag tag)
		{
			return tag == global::Org.BouncyCastle.Bcpg.PacketTag.UserId || tag == global::Org.BouncyCastle.Bcpg.PacketTag.UserAttribute;
		}
	}
}
