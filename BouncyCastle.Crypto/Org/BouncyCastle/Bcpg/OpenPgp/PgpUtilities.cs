using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C6 RID: 1478
	public sealed class PgpUtilities
	{
		// Token: 0x060037B6 RID: 14262 RVA: 0x001075E1 File Offset: 0x001057E1
		private PgpUtilities()
		{
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x001075EC File Offset: 0x001057EC
		public static global::Org.BouncyCastle.Bcpg.MPInteger[] DsaSigToMpi(byte[] encoding)
		{
			global::Org.BouncyCastle.Asn1.DerInteger i;
			global::Org.BouncyCastle.Asn1.DerInteger i2;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence instance = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(encoding);
				i = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(instance[0]);
				i2 = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(instance[1]);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception encoding signature", e);
			}
			return new global::Org.BouncyCastle.Bcpg.MPInteger[]
			{
				new global::Org.BouncyCastle.Bcpg.MPInteger(i.Value),
				new global::Org.BouncyCastle.Bcpg.MPInteger(i2.Value)
			};
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x0010765C File Offset: 0x0010585C
		public static global::Org.BouncyCastle.Bcpg.MPInteger[] RsaSigToMpi(byte[] encoding)
		{
			return new global::Org.BouncyCastle.Bcpg.MPInteger[]
			{
				new global::Org.BouncyCastle.Bcpg.MPInteger(new global::Org.BouncyCastle.Math.BigInteger(1, encoding))
			};
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x00107674 File Offset: 0x00105874
		public static string GetDigestName(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.MD5:
				return "MD5";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1:
				return "SHA1";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.RipeMD160:
				return "RIPEMD160";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.MD2:
				return "MD2";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha256:
				return "SHA256";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha384:
				return "SHA384";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha512:
				return "SHA512";
			case global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha224:
				return "SHA224";
			}
			throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown hash algorithm tag in GetDigestName: " + hashAlgorithm.ToString());
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00107704 File Offset: 0x00105904
		public static string GetSignatureName(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm)
		{
			string encAlg;
			if (keyAlgorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral && keyAlgorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaSign)
			{
				switch (keyAlgorithm)
				{
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
					encAlg = "ElGamal";
					break;
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
					encAlg = "DSA";
					break;
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
					encAlg = "ECDH";
					break;
				case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
					encAlg = "ECDSA";
					break;
				default:
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown algorithm tag in signature:" + keyAlgorithm.ToString());
				}
			}
			else
			{
				encAlg = "RSA";
			}
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(hashAlgorithm) + "with" + encAlg;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00107790 File Offset: 0x00105990
		public static string GetSymmetricCipherName(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm)
		{
			switch (algorithm)
			{
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null:
				return null;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Idea:
				return "IDEA";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.TripleDes:
				return "DESEDE";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Cast5:
				return "CAST5";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Blowfish:
				return "Blowfish";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Safer:
				return "SAFER";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Des:
				return "DES";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128:
				return "AES";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes192:
				return "AES";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes256:
				return "AES";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Twofish:
				return "Twofish";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia128:
				return "Camellia";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia192:
				return "Camellia";
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia256:
				return "Camellia";
			default:
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown symmetric algorithm: " + algorithm.ToString());
			}
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0010784C File Offset: 0x00105A4C
		public static int GetKeySize(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm)
		{
			int keySize;
			switch (algorithm)
			{
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Idea:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Cast5:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Blowfish:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Safer:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia128:
				keySize = 128;
				break;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.TripleDes:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes192:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia192:
				keySize = 192;
				break;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Des:
				keySize = 64;
				break;
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes256:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Twofish:
			case global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia256:
				keySize = 256;
				break;
			default:
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown symmetric algorithm: " + algorithm.ToString());
			}
			return keySize;
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x001078D2 File Offset: 0x00105AD2
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter MakeKey(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, byte[] keyBytes)
		{
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(algorithm), keyBytes);
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x001078E0 File Offset: 0x00105AE0
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter MakeRandomKey(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			byte[] keyBytes = new byte[(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetKeySize(algorithm) + 7) / 8];
			random.NextBytes(keyBytes);
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.MakeKey(algorithm, keyBytes);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x0010790B File Offset: 0x00105B0B
		internal static byte[] EncodePassPhrase(char[] passPhrase, bool utf8)
		{
			if (passPhrase == null)
			{
				return null;
			}
			if (!utf8)
			{
				return global::Org.BouncyCastle.Utilities.Strings.ToByteArray(passPhrase);
			}
			return global::System.Text.Encoding.UTF8.GetBytes(passPhrase);
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00107927 File Offset: 0x00105B27
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter MakeKeyFromPassPhrase(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, char[] passPhrase)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(algorithm, s2k, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, false), true);
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00107938 File Offset: 0x00105B38
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter MakeKeyFromPassPhraseUtf8(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, char[] passPhrase)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(algorithm, s2k, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, true), true);
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00107949 File Offset: 0x00105B49
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter MakeKeyFromPassPhraseRaw(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] rawPassPhrase)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(algorithm, s2k, rawPassPhrase, false);
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00107954 File Offset: 0x00105B54
		internal static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter DoMakeKeyFromPassPhrase(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] rawPassPhrase, bool clearPassPhrase)
		{
			byte[] keyBytes = new byte[(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetKeySize(algorithm) + 7) / 8];
			int generatedBytes = 0;
			int loopCount = 0;
			while (generatedBytes < keyBytes.Length)
			{
				global::Org.BouncyCastle.Crypto.IDigest digest;
				if (s2k != null)
				{
					string digestName = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(s2k.HashAlgorithm);
					try
					{
						digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(digestName);
					}
					catch (global::System.Exception e)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("can't find S2k digest", e);
					}
					for (int i = 0; i != loopCount; i++)
					{
						digest.Update(0);
					}
					byte[] iv = s2k.GetIV();
					switch (s2k.Type)
					{
					case 0:
						digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
						goto IL_1B9;
					case 1:
						digest.BlockUpdate(iv, 0, iv.Length);
						digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
						goto IL_1B9;
					case 3:
					{
						long count = s2k.IterationCount;
						digest.BlockUpdate(iv, 0, iv.Length);
						digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
						count -= (long)(iv.Length + rawPassPhrase.Length);
						while (count > 0L)
						{
							if (count < (long)iv.Length)
							{
								digest.BlockUpdate(iv, 0, (int)count);
								break;
							}
							digest.BlockUpdate(iv, 0, iv.Length);
							count -= (long)iv.Length;
							if (count < (long)rawPassPhrase.Length)
							{
								digest.BlockUpdate(rawPassPhrase, 0, (int)count);
								count = 0L;
							}
							else
							{
								digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
								count -= (long)rawPassPhrase.Length;
							}
						}
						goto IL_1B9;
					}
					}
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown S2k type: " + s2k.Type.ToString());
				}
				try
				{
					digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest("MD5");
					for (int j = 0; j != loopCount; j++)
					{
						digest.Update(0);
					}
					digest.BlockUpdate(rawPassPhrase, 0, rawPassPhrase.Length);
				}
				catch (global::System.Exception e2)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("can't find MD5 digest", e2);
				}
				IL_1B9:
				byte[] dig = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
				if (dig.Length > keyBytes.Length - generatedBytes)
				{
					global::System.Array.Copy(dig, 0, keyBytes, generatedBytes, keyBytes.Length - generatedBytes);
				}
				else
				{
					global::System.Array.Copy(dig, 0, keyBytes, generatedBytes, dig.Length);
				}
				generatedBytes += dig.Length;
				loopCount++;
			}
			if (clearPassPhrase && rawPassPhrase != null)
			{
				global::System.Array.Clear(rawPassPhrase, 0, rawPassPhrase.Length);
			}
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.MakeKey(algorithm, keyBytes);
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00107B94 File Offset: 0x00105D94
		public static void WriteFileToLiteralData(global::System.IO.Stream output, char fileType, global::System.IO.FileInfo file)
		{
			global::System.IO.Stream pOut = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpLiteralDataGenerator().Open(output, fileType, file.Name, file.Length, file.LastWriteTime);
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.PipeFileContents(file, pOut, 32768);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00107BCC File Offset: 0x00105DCC
		public static void WriteFileToLiteralData(global::System.IO.Stream output, char fileType, global::System.IO.FileInfo file, byte[] buffer)
		{
			global::System.IO.Stream pOut = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpLiteralDataGenerator().Open(output, fileType, file.Name, file.LastWriteTime, buffer);
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.PipeFileContents(file, pOut, buffer.Length);
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00107C00 File Offset: 0x00105E00
		private static void PipeFileContents(global::System.IO.FileInfo file, global::System.IO.Stream pOut, int bufSize)
		{
			global::System.IO.FileStream inputStream = file.OpenRead();
			byte[] buf = new byte[bufSize];
			try
			{
				int len;
				while ((len = inputStream.Read(buf, 0, buf.Length)) > 0)
				{
					pOut.Write(buf, 0, len);
				}
			}
			finally
			{
				global::System.Array.Clear(buf, 0, buf.Length);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(pOut);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(inputStream);
			}
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00107C60 File Offset: 0x00105E60
		private static bool IsPossiblyBase64(int ch)
		{
			return (ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122) || (ch >= 48 && ch <= 57) || ch == 43 || ch == 47 || ch == 13 || ch == 10;
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00107C98 File Offset: 0x00105E98
		public static global::System.IO.Stream GetDecoderStream(global::System.IO.Stream inputStream)
		{
			if (!inputStream.CanSeek)
			{
				throw new global::System.ArgumentException("inputStream must be seek-able", "inputStream");
			}
			long markedPos = inputStream.Position;
			int ch = inputStream.ReadByte();
			if ((ch & 128) != 0)
			{
				inputStream.Position = markedPos;
				return inputStream;
			}
			if (!global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.IsPossiblyBase64(ch))
			{
				inputStream.Position = markedPos;
				return new global::Org.BouncyCastle.Bcpg.ArmoredInputStream(inputStream);
			}
			byte[] buf = new byte[60];
			int count = 1;
			int index = 1;
			buf[0] = (byte)ch;
			while (count != 60 && (ch = inputStream.ReadByte()) >= 0)
			{
				if (!global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.IsPossiblyBase64(ch))
				{
					inputStream.Position = markedPos;
					return new global::Org.BouncyCastle.Bcpg.ArmoredInputStream(inputStream);
				}
				if (ch != 10 && ch != 13)
				{
					buf[index++] = (byte)ch;
				}
				count++;
			}
			inputStream.Position = markedPos;
			if (count < 4)
			{
				return new global::Org.BouncyCastle.Bcpg.ArmoredInputStream(inputStream);
			}
			byte[] firstBlock = new byte[8];
			global::System.Array.Copy(buf, 0, firstBlock, 0, firstBlock.Length);
			global::System.IO.Stream result;
			try
			{
				bool hasHeaders = (global::Org.BouncyCastle.Utilities.Encoders.Base64.Decode(firstBlock)[0] & 128) == 0;
				result = new global::Org.BouncyCastle.Bcpg.ArmoredInputStream(inputStream, hasHeaders);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				throw new global::System.IO.IOException(ex2.Message);
			}
			return result;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00107DB8 File Offset: 0x00105FB8
		internal static global::Org.BouncyCastle.Crypto.IWrapper CreateWrapper(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm)
		{
			if (encAlgorithm - global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128 <= 2)
			{
				return global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper("AESWRAP");
			}
			if (encAlgorithm - global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Camellia128 > 2)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown wrap algorithm: " + encAlgorithm.ToString());
			}
			return global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper("CAMELLIAWRAP");
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00107E08 File Offset: 0x00106008
		internal static byte[] GenerateIV(int length, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			byte[] iv = new byte[length];
			random.NextBytes(iv);
			return iv;
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00107E24 File Offset: 0x00106024
		internal static global::Org.BouncyCastle.Bcpg.S2k GenerateS2k(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, int s2kCount, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			byte[] iv = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GenerateIV(8, random);
			return new global::Org.BouncyCastle.Bcpg.S2k(hashAlgorithm, iv, s2kCount);
		}

		// Token: 0x04001911 RID: 6417
		private const int ReadAhead = 60;
	}
}
