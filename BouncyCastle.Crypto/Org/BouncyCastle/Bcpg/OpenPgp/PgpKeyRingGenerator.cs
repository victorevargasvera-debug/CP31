using System;
using System.Collections;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005AC RID: 1452
	public class PgpKeyRingGenerator
	{
		// Token: 0x06003646 RID: 13894 RVA: 0x001011D0 File Offset: 0x000FF3D0
		[global::System.Obsolete("Use version taking an explicit 'useSha1' parameter instead")]
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, masterKey, id, encAlgorithm, passPhrase, false, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x001011F4 File Offset: 0x000FF3F4
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, masterKey, id, encAlgorithm, false, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00101218 File Offset: 0x000FF418
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, masterKey, id, encAlgorithm, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, utf8PassPhrase), useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00101244 File Offset: 0x000FF444
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			this.keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			base..ctor();
			this.certificationLevel = certificationLevel;
			this.masterKey = masterKey;
			this.id = id;
			this.encAlgorithm = encAlgorithm;
			this.rawPassPhrase = rawPassPhrase;
			this.useSha1 = useSha1;
			this.hashedPacketVector = hashedPackets;
			this.unhashedPacketVector = unhashedPackets;
			this.rand = rand;
			this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(certificationLevel, masterKey, id, encAlgorithm, rawPassPhrase, false, useSha1, hashedPackets, unhashedPackets, rand));
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x001012C8 File Offset: 0x000FF4C8
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, masterKey, id, encAlgorithm, hashAlgorithm, false, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x001012F0 File Offset: 0x000FF4F0
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand) : this(certificationLevel, masterKey, id, encAlgorithm, hashAlgorithm, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, utf8PassPhrase), useSha1, hashedPackets, unhashedPackets, rand)
		{
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0010131C File Offset: 0x000FF51C
		public PgpKeyRingGenerator(int certificationLevel, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey, string id, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool useSha1, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			this.keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			base..ctor();
			this.certificationLevel = certificationLevel;
			this.masterKey = masterKey;
			this.id = id;
			this.encAlgorithm = encAlgorithm;
			this.rawPassPhrase = rawPassPhrase;
			this.useSha1 = useSha1;
			this.hashedPacketVector = hashedPackets;
			this.unhashedPacketVector = unhashedPackets;
			this.rand = rand;
			this.hashAlgorithm = hashAlgorithm;
			this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(certificationLevel, masterKey, id, encAlgorithm, hashAlgorithm, rawPassPhrase, false, useSha1, hashedPackets, unhashedPackets, rand));
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x001013AA File Offset: 0x000FF5AA
		public void AddSubKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair)
		{
			this.AddSubKey(keyPair, this.hashedPacketVector, this.unhashedPacketVector);
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x001013BF File Offset: 0x000FF5BF
		public void AddSubKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			this.AddSubKey(keyPair, this.hashedPacketVector, this.unhashedPacketVector, hashAlgorithm);
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x001013D5 File Offset: 0x000FF5D5
		public void AddSubKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag primaryKeyBindingHashAlgorithm)
		{
			this.AddSubKey(keyPair, this.hashedPacketVector, this.unhashedPacketVector, hashAlgorithm, primaryKeyBindingHashAlgorithm);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x001013EC File Offset: 0x000FF5EC
		public void AddSubKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets)
		{
			this.AddSubKey(keyPair, hashedPackets, unhashedPackets, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x001013F8 File Offset: 0x000FF5F8
		public void AddSubKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			try
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator sGen = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator(this.masterKey.PublicKey.Algorithm, hashAlgorithm);
				sGen.InitSign(24, this.masterKey.PrivateKey);
				sGen.SetHashedSubpackets(hashedPackets);
				sGen.SetUnhashedSubpackets(unhashedPackets);
				global::System.Collections.IList subSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				subSigs.Add(sGen.GenerateCertification(this.masterKey.PublicKey, keyPair.PublicKey));
				this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(keyPair.PrivateKey, new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(keyPair.PublicKey, null, subSigs), this.encAlgorithm, this.rawPassPhrase, false, this.useSha1, this.rand, false));
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException)
			{
				throw;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception adding subkey: ", e);
			}
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x001014D0 File Offset: 0x000FF6D0
		public void AddSubKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair keyPair, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPackets, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPackets, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag primaryKeyBindingHashAlgorithm)
		{
			try
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator sGen = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator(this.masterKey.PublicKey.Algorithm, hashAlgorithm);
				sGen.InitSign(24, this.masterKey.PrivateKey);
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator pGen = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureGenerator(keyPair.PublicKey.Algorithm, primaryKeyBindingHashAlgorithm);
				pGen.InitSign(25, keyPair.PrivateKey);
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketGenerator spGen = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketGenerator(hashedPackets);
				spGen.SetEmbeddedSignature(false, pGen.GenerateCertification(this.masterKey.PublicKey, keyPair.PublicKey));
				sGen.SetHashedSubpackets(spGen.Generate());
				sGen.SetUnhashedSubpackets(unhashedPackets);
				global::System.Collections.IList subSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				subSigs.Add(sGen.GenerateCertification(this.masterKey.PublicKey, keyPair.PublicKey));
				this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(keyPair.PrivateKey, new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(keyPair.PublicKey, null, subSigs), this.encAlgorithm, this.rawPassPhrase, false, this.useSha1, this.rand, false));
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException)
			{
				throw;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception adding subkey: ", e);
			}
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x001015F4 File Offset: 0x000FF7F4
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing GenerateSecretKeyRing()
		{
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing(this.keys);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00101604 File Offset: 0x000FF804
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing GeneratePublicKeyRing()
		{
			global::System.Collections.IList pubKeys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::System.Collections.IEnumerator enumerator = this.keys.GetEnumerator();
			enumerator.MoveNext();
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey pgpSecretKey = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)enumerator.Current;
			pubKeys.Add(pgpSecretKey.PublicKey);
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				pgpSecretKey = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)obj;
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey i = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(pgpSecretKey.PublicKey);
				i.publicPk = new global::Org.BouncyCastle.Bcpg.PublicSubkeyPacket(i.Algorithm, i.CreationTime, i.publicPk.Key);
				pubKeys.Add(i);
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing(pubKeys);
		}

		// Token: 0x040018B9 RID: 6329
		private global::System.Collections.IList keys;

		// Token: 0x040018BA RID: 6330
		private string id;

		// Token: 0x040018BB RID: 6331
		private global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm;

		// Token: 0x040018BC RID: 6332
		private global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm;

		// Token: 0x040018BD RID: 6333
		private int certificationLevel;

		// Token: 0x040018BE RID: 6334
		private byte[] rawPassPhrase;

		// Token: 0x040018BF RID: 6335
		private bool useSha1;

		// Token: 0x040018C0 RID: 6336
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyPair masterKey;

		// Token: 0x040018C1 RID: 6337
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashedPacketVector;

		// Token: 0x040018C2 RID: 6338
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector unhashedPacketVector;

		// Token: 0x040018C3 RID: 6339
		private global::Org.BouncyCastle.Security.SecureRandom rand;
	}
}
