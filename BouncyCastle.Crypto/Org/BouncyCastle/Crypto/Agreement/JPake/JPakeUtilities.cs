using System;
using System.Text;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.JPake
{
	// Token: 0x02000506 RID: 1286
	public abstract class JPakeUtilities
	{
		// Token: 0x06003240 RID: 12864 RVA: 0x000F1728 File Offset: 0x000EF928
		public static global::Org.BouncyCastle.Math.BigInteger GenerateX1(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Math.BigInteger zero = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.Zero;
			global::Org.BouncyCastle.Math.BigInteger max = q.Subtract(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One);
			return global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(zero, max, random);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000F1750 File Offset: 0x000EF950
		public static global::Org.BouncyCastle.Math.BigInteger GenerateX2(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Math.BigInteger one = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One;
			global::Org.BouncyCastle.Math.BigInteger max = q.Subtract(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One);
			return global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(one, max, random);
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000F1775 File Offset: 0x000EF975
		public static global::Org.BouncyCastle.Math.BigInteger CalculateS(char[] password)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(global::System.Text.Encoding.UTF8.GetBytes(password));
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000F1787 File Offset: 0x000EF987
		public static global::Org.BouncyCastle.Math.BigInteger CalculateGx(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger x)
		{
			return g.ModPow(x, p);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000F1791 File Offset: 0x000EF991
		public static global::Org.BouncyCastle.Math.BigInteger CalculateGA(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger gx1, global::Org.BouncyCastle.Math.BigInteger gx3, global::Org.BouncyCastle.Math.BigInteger gx4)
		{
			return gx1.Multiply(gx3).Multiply(gx4).Mod(p);
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x000F17A6 File Offset: 0x000EF9A6
		public static global::Org.BouncyCastle.Math.BigInteger CalculateX2s(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger x2, global::Org.BouncyCastle.Math.BigInteger s)
		{
			return x2.Multiply(s).Mod(q);
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x000F17B5 File Offset: 0x000EF9B5
		public static global::Org.BouncyCastle.Math.BigInteger CalculateA(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger gA, global::Org.BouncyCastle.Math.BigInteger x2s)
		{
			return gA.ModPow(x2s, p);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000F17C0 File Offset: 0x000EF9C0
		public static global::Org.BouncyCastle.Math.BigInteger[] CalculateZeroKnowledgeProof(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger gx, global::Org.BouncyCastle.Math.BigInteger x, string participantId, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Math.BigInteger zero = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.Zero;
			global::Org.BouncyCastle.Math.BigInteger vMax = q.Subtract(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One);
			global::Org.BouncyCastle.Math.BigInteger v = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(zero, vMax, random);
			global::Org.BouncyCastle.Math.BigInteger gv = g.ModPow(v, p);
			global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateHashForZeroKnowledgeProof(g, gv, gx, participantId, digest);
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				gv,
				v.Subtract(x.Multiply(h)).Mod(q)
			};
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000F181E File Offset: 0x000EFA1E
		private static global::Org.BouncyCastle.Math.BigInteger CalculateHashForZeroKnowledgeProof(global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger gr, global::Org.BouncyCastle.Math.BigInteger gx, string participantId, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			digest.Reset();
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigestIncludingSize(digest, g);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigestIncludingSize(digest, gr);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigestIncludingSize(digest, gx);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigestIncludingSize(digest, participantId);
			return new global::Org.BouncyCastle.Math.BigInteger(global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest));
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000F1853 File Offset: 0x000EFA53
		public static void ValidateGx4(global::Org.BouncyCastle.Math.BigInteger gx4)
		{
			if (gx4.Equals(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One))
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("g^x validation failed.  g^x should not be 1.");
			}
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000F186D File Offset: 0x000EFA6D
		public static void ValidateGa(global::Org.BouncyCastle.Math.BigInteger ga)
		{
			if (ga.Equals(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One))
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("ga is equal to 1.  It should not be.  The chances of this happening are on the order of 2^160 for a 160-bit q.  Try again.");
			}
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x000F1888 File Offset: 0x000EFA88
		public static void ValidateZeroKnowledgeProof(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger gx, global::Org.BouncyCastle.Math.BigInteger[] zeroKnowledgeProof, string participantId, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			global::Org.BouncyCastle.Math.BigInteger gv = zeroKnowledgeProof[0];
			global::Org.BouncyCastle.Math.BigInteger r = zeroKnowledgeProof[1];
			global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateHashForZeroKnowledgeProof(g, gv, gx, participantId, digest);
			if (gx.CompareTo(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.Zero) != 1 || gx.CompareTo(p) != -1 || gx.ModPow(q, p).CompareTo(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.One) != 0 || g.ModPow(r, p).Multiply(gx.ModPow(h, p)).Mod(p).CompareTo(gv) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Zero-knowledge proof validation failed");
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000F1906 File Offset: 0x000EFB06
		public static global::Org.BouncyCastle.Math.BigInteger CalculateKeyingMaterial(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger gx4, global::Org.BouncyCastle.Math.BigInteger x2, global::Org.BouncyCastle.Math.BigInteger s, global::Org.BouncyCastle.Math.BigInteger B)
		{
			return gx4.ModPow(x2.Multiply(s).Negate().Mod(q), p).Multiply(B).ModPow(x2, p);
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000F1930 File Offset: 0x000EFB30
		public static void ValidateParticipantIdsDiffer(string participantId1, string participantId2)
		{
			if (participantId1.Equals(participantId2))
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Both participants are using the same participantId (" + participantId1 + "). This is not allowed. Each participant must use a unique participantId.");
			}
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x000F1951 File Offset: 0x000EFB51
		public static void ValidateParticipantIdsEqual(string expectedParticipantId, string actualParticipantId)
		{
			if (!expectedParticipantId.Equals(actualParticipantId))
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException(string.Concat(new string[]
				{
					"Received payload from incorrect partner (",
					actualParticipantId,
					"). Expected to receive payload from ",
					expectedParticipantId,
					"."
				}));
			}
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000F198D File Offset: 0x000EFB8D
		public static void ValidateNotNull(object obj, string description)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException(description);
			}
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x000F199C File Offset: 0x000EFB9C
		public static global::Org.BouncyCastle.Math.BigInteger CalculateMacTag(string participantId, string partnerParticipantId, global::Org.BouncyCastle.Math.BigInteger gx1, global::Org.BouncyCastle.Math.BigInteger gx2, global::Org.BouncyCastle.Math.BigInteger gx3, global::Org.BouncyCastle.Math.BigInteger gx4, global::Org.BouncyCastle.Math.BigInteger keyingMaterial, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			byte[] macKey = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateMacKey(keyingMaterial, digest);
			global::Org.BouncyCastle.Crypto.Macs.HMac hmac = new global::Org.BouncyCastle.Crypto.Macs.HMac(digest);
			hmac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(macKey));
			global::Org.BouncyCastle.Utilities.Arrays.Fill(macKey, 0);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, "KC_1_U");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, participantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, partnerParticipantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, gx1);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, gx2);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, gx3);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(hmac, gx4);
			return new global::Org.BouncyCastle.Math.BigInteger(global::Org.BouncyCastle.Security.MacUtilities.DoFinal(hmac));
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000F1A0E File Offset: 0x000EFC0E
		private static byte[] CalculateMacKey(global::Org.BouncyCastle.Math.BigInteger keyingMaterial, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			digest.Reset();
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigest(digest, keyingMaterial);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigest(digest, "JPAKE_KC");
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000F1A2E File Offset: 0x000EFC2E
		public static void ValidateMacTag(string participantId, string partnerParticipantId, global::Org.BouncyCastle.Math.BigInteger gx1, global::Org.BouncyCastle.Math.BigInteger gx2, global::Org.BouncyCastle.Math.BigInteger gx3, global::Org.BouncyCastle.Math.BigInteger gx4, global::Org.BouncyCastle.Math.BigInteger keyingMaterial, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger partnerMacTag)
		{
			if (!global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateMacTag(partnerParticipantId, participantId, gx3, gx4, gx1, gx2, keyingMaterial, digest).Equals(partnerMacTag))
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Partner MacTag validation failed. Therefore, the password, MAC, or digest algorithm of each participant does not match.");
			}
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000F1A55 File Offset: 0x000EFC55
		private static void UpdateDigest(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger bigInteger)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigest(digest, global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(bigInteger));
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x000F1A63 File Offset: 0x000EFC63
		private static void UpdateDigest(global::Org.BouncyCastle.Crypto.IDigest digest, string str)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigest(digest, global::System.Text.Encoding.UTF8.GetBytes(str));
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x000F1A76 File Offset: 0x000EFC76
		private static void UpdateDigest(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] bytes)
		{
			digest.BlockUpdate(bytes, 0, bytes.Length);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(bytes, 0);
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000F1A8A File Offset: 0x000EFC8A
		private static void UpdateDigestIncludingSize(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger bigInteger)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigestIncludingSize(digest, global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(bigInteger));
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000F1A98 File Offset: 0x000EFC98
		private static void UpdateDigestIncludingSize(global::Org.BouncyCastle.Crypto.IDigest digest, string str)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateDigestIncludingSize(digest, global::System.Text.Encoding.UTF8.GetBytes(str));
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000F1AAB File Offset: 0x000EFCAB
		private static void UpdateDigestIncludingSize(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] bytes)
		{
			digest.BlockUpdate(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.IntToByteArray(bytes.Length), 0, 4);
			digest.BlockUpdate(bytes, 0, bytes.Length);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(bytes, 0);
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000F1ACF File Offset: 0x000EFCCF
		private static void UpdateMac(global::Org.BouncyCastle.Crypto.IMac mac, global::Org.BouncyCastle.Math.BigInteger bigInteger)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(mac, global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(bigInteger));
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x000F1ADD File Offset: 0x000EFCDD
		private static void UpdateMac(global::Org.BouncyCastle.Crypto.IMac mac, string str)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.UpdateMac(mac, global::System.Text.Encoding.UTF8.GetBytes(str));
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x000F1AF0 File Offset: 0x000EFCF0
		private static void UpdateMac(global::Org.BouncyCastle.Crypto.IMac mac, byte[] bytes)
		{
			mac.BlockUpdate(bytes, 0, bytes.Length);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(bytes, 0);
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x000F1B04 File Offset: 0x000EFD04
		private static byte[] IntToByteArray(int value)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)value);
		}

		// Token: 0x0400165F RID: 5727
		public static readonly global::Org.BouncyCastle.Math.BigInteger Zero = global::Org.BouncyCastle.Math.BigInteger.Zero;

		// Token: 0x04001660 RID: 5728
		public static readonly global::Org.BouncyCastle.Math.BigInteger One = global::Org.BouncyCastle.Math.BigInteger.One;
	}
}
