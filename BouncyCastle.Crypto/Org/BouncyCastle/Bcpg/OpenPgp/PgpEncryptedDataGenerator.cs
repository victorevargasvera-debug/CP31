using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A5 RID: 1445
	public class PgpEncryptedDataGenerator : global::Org.BouncyCastle.Bcpg.OpenPgp.IStreamGenerator
	{
		// Token: 0x0600361C RID: 13852 RVA: 0x0010084D File Offset: 0x000FEA4D
		public PgpEncryptedDataGenerator(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm)
		{
			this.defAlgorithm = encAlgorithm;
			this.rand = new global::Org.BouncyCastle.Security.SecureRandom();
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x00100872 File Offset: 0x000FEA72
		public PgpEncryptedDataGenerator(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, bool withIntegrityPacket)
		{
			this.defAlgorithm = encAlgorithm;
			this.withIntegrityPacket = withIntegrityPacket;
			this.rand = new global::Org.BouncyCastle.Security.SecureRandom();
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0010089E File Offset: 0x000FEA9E
		public PgpEncryptedDataGenerator(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			this.defAlgorithm = encAlgorithm;
			this.rand = rand;
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x001008BF File Offset: 0x000FEABF
		public PgpEncryptedDataGenerator(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, bool withIntegrityPacket, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			this.defAlgorithm = encAlgorithm;
			this.rand = rand;
			this.withIntegrityPacket = withIntegrityPacket;
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x001008E7 File Offset: 0x000FEAE7
		public PgpEncryptedDataGenerator(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand, bool oldFormat)
		{
			this.defAlgorithm = encAlgorithm;
			this.rand = rand;
			this.oldFormat = oldFormat;
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x0010090F File Offset: 0x000FEB0F
		[global::System.Obsolete("Use version that takes an explicit s2kDigest parameter")]
		public void AddMethod(char[] passPhrase)
		{
			this.AddMethod(passPhrase, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1);
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x00100919 File Offset: 0x000FEB19
		public void AddMethod(char[] passPhrase, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag s2kDigest)
		{
			this.DoAddMethod(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, false), true, s2kDigest);
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0010092A File Offset: 0x000FEB2A
		public void AddMethodUtf8(char[] passPhrase, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag s2kDigest)
		{
			this.DoAddMethod(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, true), true, s2kDigest);
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0010093B File Offset: 0x000FEB3B
		public void AddMethodRaw(byte[] rawPassPhrase, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag s2kDigest)
		{
			this.DoAddMethod(rawPassPhrase, false, s2kDigest);
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00100948 File Offset: 0x000FEB48
		internal void DoAddMethod(byte[] rawPassPhrase, bool clearPassPhrase, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag s2kDigest)
		{
			global::Org.BouncyCastle.Bcpg.S2k s2k = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GenerateS2k(s2kDigest, 96, this.rand);
			this.methods.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.PbeMethod(this.defAlgorithm, s2k, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(this.defAlgorithm, s2k, rawPassPhrase, clearPassPhrase)));
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0010098A File Offset: 0x000FEB8A
		public void AddMethod(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key)
		{
			this.AddMethod(key, true);
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00100994 File Offset: 0x000FEB94
		public void AddMethod(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, bool sessionKeyObfuscation)
		{
			if (!key.IsEncryptionKey)
			{
				throw new global::System.ArgumentException("passed in key not an encryption key!");
			}
			this.methods.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.PubMethod(key, sessionKeyObfuscation));
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x001009BC File Offset: 0x000FEBBC
		private void AddCheckSum(byte[] sessionInfo)
		{
			int check = 0;
			for (int i = 1; i < sessionInfo.Length - 2; i++)
			{
				check += (int)sessionInfo[i];
			}
			sessionInfo[sessionInfo.Length - 2] = (byte)(check >> 8);
			sessionInfo[sessionInfo.Length - 1] = (byte)check;
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x001009F8 File Offset: 0x000FEBF8
		private byte[] CreateSessionInfo(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key)
		{
			byte[] key2 = key.GetKey();
			byte[] sessionInfo = new byte[key2.Length + 3];
			sessionInfo[0] = (byte)algorithm;
			key2.CopyTo(sessionInfo, 1);
			this.AddCheckSum(sessionInfo);
			return sessionInfo;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00100A2C File Offset: 0x000FEC2C
		private global::System.IO.Stream Open(global::System.IO.Stream outStr, long length, byte[] buffer)
		{
			if (this.cOut != null)
			{
				throw new global::System.InvalidOperationException("generator already in open state");
			}
			if (this.methods.Count == 0)
			{
				throw new global::System.InvalidOperationException("No encryption methods specified");
			}
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr);
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
			if (this.methods.Count == 1)
			{
				if (this.methods[0] is global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.PbeMethod)
				{
					key = ((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.PbeMethod)this.methods[0]).GetKey();
				}
				else
				{
					key = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.MakeRandomKey(this.defAlgorithm, this.rand);
					byte[] sessionInfo = this.CreateSessionInfo(this.defAlgorithm, key);
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.PubMethod i = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.PubMethod)this.methods[0];
					try
					{
						i.AddSessionInfo(sessionInfo, this.rand);
					}
					catch (global::System.Exception e)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception encrypting session key", e);
					}
				}
				this.pOut.WritePacket((global::Org.BouncyCastle.Bcpg.ContainedPacket)this.methods[0]);
			}
			else
			{
				key = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.MakeRandomKey(this.defAlgorithm, this.rand);
				byte[] sessionInfo2 = this.CreateSessionInfo(this.defAlgorithm, key);
				for (int j = 0; j != this.methods.Count; j++)
				{
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.EncMethod k = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.EncMethod)this.methods[j];
					try
					{
						k.AddSessionInfo(sessionInfo2, this.rand);
					}
					catch (global::System.Exception e2)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception encrypting session key", e2);
					}
					this.pOut.WritePacket(k);
				}
			}
			string cName = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(this.defAlgorithm);
			if (cName == null)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("null cipher specified");
			}
			global::System.IO.Stream result;
			try
			{
				if (this.withIntegrityPacket)
				{
					cName += "/CFB/NoPadding";
				}
				else
				{
					cName += "/OpenPGPCFB/NoPadding";
				}
				this.c = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(cName);
				byte[] iv = new byte[this.c.GetBlockSize()];
				this.c.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, iv), this.rand));
				if (buffer == null)
				{
					if (this.withIntegrityPacket)
					{
						this.pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricEncryptedIntegrityProtected, length + (long)this.c.GetBlockSize() + 2L + 1L + 22L);
						this.pOut.WriteByte(1);
					}
					else
					{
						this.pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncrypted, length + (long)this.c.GetBlockSize() + 2L, this.oldFormat);
					}
				}
				else if (this.withIntegrityPacket)
				{
					this.pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricEncryptedIntegrityProtected, buffer);
					this.pOut.WriteByte(1);
				}
				else
				{
					this.pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr, global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncrypted, buffer);
				}
				int blockSize = this.c.GetBlockSize();
				byte[] inLineIv = new byte[blockSize + 2];
				this.rand.NextBytes(inLineIv, 0, blockSize);
				global::System.Array.Copy(inLineIv, inLineIv.Length - 4, inLineIv, inLineIv.Length - 2, 2);
				global::System.IO.Stream myOut = this.cOut = new global::Org.BouncyCastle.Crypto.IO.CipherStream(this.pOut, null, this.c);
				if (this.withIntegrityPacket)
				{
					global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1));
					myOut = (this.digestOut = new global::Org.BouncyCastle.Crypto.IO.DigestStream(myOut, null, digest));
				}
				myOut.Write(inLineIv, 0, inLineIv.Length);
				result = new global::Org.BouncyCastle.Bcpg.OpenPgp.WrappedGeneratorStream(this, myOut);
			}
			catch (global::System.Exception e3)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception creating cipher", e3);
			}
			return result;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00100DBC File Offset: 0x000FEFBC
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, long length)
		{
			return this.Open(outStr, length, null);
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00100DC7 File Offset: 0x000FEFC7
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, byte[] buffer)
		{
			return this.Open(outStr, 0L, buffer);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00100DD4 File Offset: 0x000FEFD4
		public void Close()
		{
			if (this.cOut != null)
			{
				if (this.digestOut != null)
				{
					new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(this.digestOut, global::Org.BouncyCastle.Bcpg.PacketTag.ModificationDetectionCode, 20L).Flush();
					this.digestOut.Flush();
					byte[] dig = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(this.digestOut.WriteDigest());
					this.cOut.Write(dig, 0, dig.Length);
				}
				this.cOut.Flush();
				try
				{
					this.pOut.Write(this.c.DoFinal());
					this.pOut.Finish();
				}
				catch (global::System.Exception e)
				{
					throw new global::System.IO.IOException(e.Message, e);
				}
				this.cOut = null;
				this.pOut = null;
			}
		}

		// Token: 0x040018A5 RID: 6309
		private global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut;

		// Token: 0x040018A6 RID: 6310
		private global::Org.BouncyCastle.Crypto.IO.CipherStream cOut;

		// Token: 0x040018A7 RID: 6311
		private global::Org.BouncyCastle.Crypto.IBufferedCipher c;

		// Token: 0x040018A8 RID: 6312
		private bool withIntegrityPacket;

		// Token: 0x040018A9 RID: 6313
		private bool oldFormat;

		// Token: 0x040018AA RID: 6314
		private global::Org.BouncyCastle.Crypto.IO.DigestStream digestOut;

		// Token: 0x040018AB RID: 6315
		private readonly global::System.Collections.IList methods = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040018AC RID: 6316
		private readonly global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag defAlgorithm;

		// Token: 0x040018AD RID: 6317
		private readonly global::Org.BouncyCastle.Security.SecureRandom rand;

		// Token: 0x02000847 RID: 2119
		private abstract class EncMethod : global::Org.BouncyCastle.Bcpg.ContainedPacket
		{
			// Token: 0x0600473D RID: 18237
			public abstract void AddSessionInfo(byte[] si, global::Org.BouncyCastle.Security.SecureRandom random);

			// Token: 0x040025B2 RID: 9650
			protected byte[] sessionInfo;

			// Token: 0x040025B3 RID: 9651
			protected global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm;

			// Token: 0x040025B4 RID: 9652
			protected global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key;
		}

		// Token: 0x02000848 RID: 2120
		private class PbeMethod : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.EncMethod
		{
			// Token: 0x0600473F RID: 18239 RVA: 0x0013B0AF File Offset: 0x001392AF
			internal PbeMethod(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key)
			{
				this.encAlgorithm = encAlgorithm;
				this.s2k = s2k;
				this.key = key;
			}

			// Token: 0x06004740 RID: 18240 RVA: 0x0013B0CC File Offset: 0x001392CC
			public global::Org.BouncyCastle.Crypto.Parameters.KeyParameter GetKey()
			{
				return this.key;
			}

			// Token: 0x06004741 RID: 18241 RVA: 0x0013B0D4 File Offset: 0x001392D4
			public override void AddSessionInfo(byte[] si, global::Org.BouncyCastle.Security.SecureRandom random)
			{
				global::Org.BouncyCastle.Crypto.IBufferedCipher c = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(this.encAlgorithm) + "/CFB/NoPadding");
				byte[] iv = new byte[c.GetBlockSize()];
				c.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.key, iv), random));
				this.sessionInfo = c.DoFinal(si, 0, si.Length - 2);
			}

			// Token: 0x06004742 RID: 18242 RVA: 0x0013B134 File Offset: 0x00139334
			public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut)
			{
				global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket pk = new global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket(this.encAlgorithm, this.s2k, this.sessionInfo);
				pOut.WritePacket(pk);
			}

			// Token: 0x040025B5 RID: 9653
			private global::Org.BouncyCastle.Bcpg.S2k s2k;
		}

		// Token: 0x02000849 RID: 2121
		private class PubMethod : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedDataGenerator.EncMethod
		{
			// Token: 0x06004743 RID: 18243 RVA: 0x0013B160 File Offset: 0x00139360
			internal PubMethod(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey, bool sessionKeyObfuscation)
			{
				this.pubKey = pubKey;
				this.sessionKeyObfuscation = sessionKeyObfuscation;
			}

			// Token: 0x06004744 RID: 18244 RVA: 0x0013B178 File Offset: 0x00139378
			public override void AddSessionInfo(byte[] sessionInfo, global::Org.BouncyCastle.Security.SecureRandom random)
			{
				byte[] encryptedSessionInfo = this.EncryptSessionInfo(sessionInfo, random);
				this.data = this.ProcessSessionInfo(encryptedSessionInfo);
			}

			// Token: 0x06004745 RID: 18245 RVA: 0x0013B19C File Offset: 0x0013939C
			private byte[] EncryptSessionInfo(byte[] sessionInfo, global::Org.BouncyCastle.Security.SecureRandom random)
			{
				if (this.pubKey.Algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC)
				{
					global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = this.pubKey.Algorithm;
					global::Org.BouncyCastle.Crypto.IBufferedCipher c;
					if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 1)
					{
						switch (algorithm)
						{
						case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
						case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
							c = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("ElGamal/ECB/PKCS1Padding");
							goto IL_A2;
						case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
							throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Can't use DSA for encryption.");
						case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
							throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Can't use ECDSA for encryption.");
						}
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown asymmetric algorithm: " + this.pubKey.Algorithm.ToString());
					}
					c = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("RSA//PKCS1Padding");
					IL_A2:
					global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter akp = this.pubKey.GetKey();
					c.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(akp, random));
					return c.DoFinal(sessionInfo);
				}
				global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey ecKey = (global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey)this.pubKey.PublicKeyPacket.Key;
				global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator keyPairGenerator = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyPairGenerator("ECDH");
				keyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(ecKey.CurveOid, random));
				global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair asymmetricCipherKeyPair = keyPairGenerator.GenerateKeyPair();
				global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephPriv = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)asymmetricCipherKeyPair.Private;
				global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephPub = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)asymmetricCipherKeyPair.Public;
				global::Org.BouncyCastle.Math.EC.ECPoint S = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.pubKey.GetKey()).Q.Multiply(ephPriv.D).Normalize();
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.CreateKey(this.pubKey.PublicKeyPacket, S));
				global::Org.BouncyCastle.Crypto.IWrapper wrapper = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.CreateWrapper(ecKey.SymmetricKeyAlgorithm);
				wrapper.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(key, random));
				byte[] paddedSessionData = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPad.PadSessionData(sessionInfo, this.sessionKeyObfuscation);
				byte[] C = wrapper.Wrap(paddedSessionData, 0, paddedSessionData.Length);
				byte[] VB = new global::Org.BouncyCastle.Bcpg.MPInteger(new global::Org.BouncyCastle.Math.BigInteger(1, ephPub.Q.GetEncoded(false))).GetEncoded();
				byte[] rv = new byte[VB.Length + 1 + C.Length];
				global::System.Array.Copy(VB, 0, rv, 0, VB.Length);
				rv[VB.Length] = (byte)C.Length;
				global::System.Array.Copy(C, 0, rv, VB.Length + 1, C.Length);
				return rv;
			}

			// Token: 0x06004746 RID: 18246 RVA: 0x0013B394 File Offset: 0x00139594
			private byte[][] ProcessSessionInfo(byte[] encryptedSessionInfo)
			{
				global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = this.pubKey.Algorithm;
				if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 1)
				{
					switch (algorithm)
					{
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
					{
						int halfLength = encryptedSessionInfo.Length / 2;
						byte[] b = new byte[halfLength];
						byte[] b2 = new byte[halfLength];
						global::System.Array.Copy(encryptedSessionInfo, 0, b, 0, halfLength);
						global::System.Array.Copy(encryptedSessionInfo, halfLength, b2, 0, halfLength);
						return new byte[][]
						{
							this.ConvertToEncodedMpi(b),
							this.ConvertToEncodedMpi(b2)
						};
					}
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
						return new byte[][]
						{
							encryptedSessionInfo
						};
					}
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown asymmetric algorithm: " + this.pubKey.Algorithm.ToString());
				}
				return new byte[][]
				{
					this.ConvertToEncodedMpi(encryptedSessionInfo)
				};
			}

			// Token: 0x06004747 RID: 18247 RVA: 0x0013B468 File Offset: 0x00139668
			private byte[] ConvertToEncodedMpi(byte[] encryptedSessionInfo)
			{
				byte[] encoded;
				try
				{
					encoded = new global::Org.BouncyCastle.Bcpg.MPInteger(new global::Org.BouncyCastle.Math.BigInteger(1, encryptedSessionInfo)).GetEncoded();
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Invalid MPI encoding: " + e.Message, e);
				}
				return encoded;
			}

			// Token: 0x06004748 RID: 18248 RVA: 0x0013B4B4 File Offset: 0x001396B4
			public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut)
			{
				global::Org.BouncyCastle.Bcpg.PublicKeyEncSessionPacket pk = new global::Org.BouncyCastle.Bcpg.PublicKeyEncSessionPacket(this.pubKey.KeyId, this.pubKey.Algorithm, this.data);
				pOut.WritePacket(pk);
			}

			// Token: 0x040025B6 RID: 9654
			internal global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey;

			// Token: 0x040025B7 RID: 9655
			internal bool sessionKeyObfuscation;

			// Token: 0x040025B8 RID: 9656
			internal byte[][] data;
		}
	}
}
