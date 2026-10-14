using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200058C RID: 1420
	public class SecretSubkeyPacket : global::Org.BouncyCastle.Bcpg.SecretKeyPacket
	{
		// Token: 0x060035BD RID: 13757 RVA: 0x000FF0BC File Offset: 0x000FD2BC
		internal SecretSubkeyPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000FF0C5 File Offset: 0x000FD2C5
		public SecretSubkeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyPacket, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] iv, byte[] secKeyData) : base(pubKeyPacket, encAlgorithm, s2k, iv, secKeyData)
		{
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x000FF0D4 File Offset: 0x000FD2D4
		public SecretSubkeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyPacket, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, int s2kUsage, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] iv, byte[] secKeyData) : base(pubKeyPacket, encAlgorithm, s2kUsage, s2k, iv, secKeyData)
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x000FF0E5 File Offset: 0x000FD2E5
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.SecretSubkey, base.GetEncodedContents(), true);
		}
	}
}
