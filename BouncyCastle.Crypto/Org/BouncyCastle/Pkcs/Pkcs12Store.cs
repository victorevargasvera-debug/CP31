using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001AE RID: 430
	public class Pkcs12Store
	{
		// Token: 0x0600104C RID: 4172 RVA: 0x00041012 File Offset: 0x0003F212
		private static global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier CreateSubjectKeyID(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey)
		{
			return new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier(global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pubKey));
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00041020 File Offset: 0x0003F220
		internal Pkcs12Store(global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm, bool useDerEncoding)
		{
			this.keyAlgorithm = keyAlgorithm;
			this.keyPrfAlgorithm = null;
			this.certAlgorithm = certAlgorithm;
			this.certPrfAlgorithm = null;
			this.useDerEncoding = useDerEncoding;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00041090 File Offset: 0x0003F290
		internal Pkcs12Store(global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyPrfAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier certPrfAlgorithm, bool useDerEncoding)
		{
			this.keyAlgorithm = keyAlgorithm;
			this.keyPrfAlgorithm = keyPrfAlgorithm;
			this.certAlgorithm = certAlgorithm;
			this.certPrfAlgorithm = certPrfAlgorithm;
			this.useDerEncoding = useDerEncoding;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x000410FF File Offset: 0x0003F2FF
		public Pkcs12Store() : this(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc, false)
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00041112 File Offset: 0x0003F312
		public Pkcs12Store(global::System.IO.Stream input, char[] password) : this()
		{
			this.Load(input, password);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00041124 File Offset: 0x0003F324
		protected virtual void LoadKeyBag(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privKeyInfo, global::Org.BouncyCastle.Asn1.Asn1Set bagAttributes)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key = global::Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(privKeyInfo);
			global::System.Collections.IDictionary attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry keyEntry = new global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry(key, attributes);
			string alias = null;
			global::Org.BouncyCastle.Asn1.Asn1OctetString localId = null;
			if (bagAttributes != null)
			{
				foreach (object obj in bagAttributes)
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence asn1Sequence = (global::Org.BouncyCastle.Asn1.Asn1Sequence)obj;
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier aOid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(asn1Sequence[0]);
					global::Org.BouncyCastle.Asn1.Asn1Set attrSet = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(asn1Sequence[1]);
					if (attrSet.Count > 0)
					{
						global::Org.BouncyCastle.Asn1.Asn1Encodable attr = attrSet[0];
						if (attributes.Contains(aOid.Id))
						{
							if (!attributes[aOid.Id].Equals(attr))
							{
								throw new global::System.IO.IOException("attempt to add existing attribute with different value");
							}
						}
						else
						{
							attributes.Add(aOid.Id, attr);
						}
						if (aOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName))
						{
							alias = ((global::Org.BouncyCastle.Asn1.DerBmpString)attr).GetString();
							this.keys[alias] = keyEntry;
						}
						else if (aOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID))
						{
							localId = (global::Org.BouncyCastle.Asn1.Asn1OctetString)attr;
						}
					}
				}
			}
			if (localId == null)
			{
				this.unmarkedKeyEntry = keyEntry;
				return;
			}
			string name = global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(localId.GetOctets());
			if (alias == null)
			{
				this.keys[name] = keyEntry;
				return;
			}
			this.localIds[alias] = name;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00041288 File Offset: 0x0003F488
		protected virtual void LoadPkcs8ShroudedKeyBag(global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo encPrivKeyInfo, global::Org.BouncyCastle.Asn1.Asn1Set bagAttributes, char[] password, bool wrongPkcs12Zero)
		{
			if (password != null)
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privInfo = global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(password, wrongPkcs12Zero, encPrivKeyInfo);
				this.LoadKeyBag(privInfo, bagAttributes);
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000412AC File Offset: 0x0003F4AC
		public void Load(global::System.IO.Stream input, char[] password)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			global::Org.BouncyCastle.Asn1.Pkcs.Pfx bag = global::Org.BouncyCastle.Asn1.Pkcs.Pfx.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromStream(input));
			global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo info = bag.AuthSafe;
			bool wrongPkcs12Zero = false;
			if (bag.MacData != null)
			{
				if (password == null)
				{
					throw new global::System.ArgumentNullException("password", "no password supplied when one expected");
				}
				global::Org.BouncyCastle.Asn1.Pkcs.MacData macData = bag.MacData;
				global::Org.BouncyCastle.Asn1.X509.DigestInfo dInfo = macData.Mac;
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId = dInfo.AlgorithmID;
				byte[] salt = macData.GetSalt();
				int itCount = macData.IterationCount.IntValue;
				byte[] data = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(info.Content).GetOctets();
				byte[] a = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CalculatePbeMac(algId.Algorithm, salt, itCount, password, false, data);
				byte[] dig = dInfo.GetDigest();
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a, dig))
				{
					if (password.Length != 0)
					{
						throw new global::System.IO.IOException("PKCS12 key store MAC invalid - wrong password or corrupted file.");
					}
					if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(global::Org.BouncyCastle.Pkcs.Pkcs12Store.CalculatePbeMac(algId.Algorithm, salt, itCount, password, true, data), dig))
					{
						throw new global::System.IO.IOException("PKCS12 key store MAC invalid - wrong password or corrupted file.");
					}
					wrongPkcs12Zero = true;
				}
			}
			else if (password != null)
			{
				string ignoreProperty = global::Org.BouncyCastle.Utilities.Platform.GetEnvironmentVariable("Org.BouncyCastle.Pkcs12.IgnoreUselessPassword");
				if (ignoreProperty == null || !global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase("true", ignoreProperty))
				{
					throw new global::System.IO.IOException("password supplied for keystore that does not require one");
				}
			}
			this.keys.Clear();
			this.localIds.Clear();
			this.unmarkedKeyEntry = null;
			global::System.Collections.IList certBags = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (info.ContentType.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data))
			{
				foreach (global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo ci in global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe.GetInstance(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(info.Content).GetOctets()).GetContentInfo())
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = ci.ContentType;
					byte[] octets = null;
					if (oid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data))
					{
						octets = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(ci.Content).GetOctets();
					}
					else if (oid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.EncryptedData) && password != null)
					{
						global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData d = global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData.GetInstance(ci.Content);
						octets = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CryptPbeData(false, d.EncryptionAlgorithm, password, wrongPkcs12Zero, d.Content.GetOctets());
					}
					if (octets != null)
					{
						foreach (object obj in global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(octets))
						{
							global::Org.BouncyCastle.Asn1.Pkcs.SafeBag b = global::Org.BouncyCastle.Asn1.Pkcs.SafeBag.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
							if (b.BagID.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.CertBag))
							{
								certBags.Add(b);
							}
							else if (b.BagID.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs8ShroudedKeyBag))
							{
								this.LoadPkcs8ShroudedKeyBag(global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo.GetInstance(b.BagValue), b.BagAttributes, password, wrongPkcs12Zero);
							}
							else if (b.BagID.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.KeyBag))
							{
								this.LoadKeyBag(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(b.BagValue), b.BagAttributes);
							}
						}
					}
				}
			}
			this.certs.Clear();
			this.chainCerts.Clear();
			this.keyCerts.Clear();
			foreach (object obj2 in certBags)
			{
				global::Org.BouncyCastle.Asn1.Pkcs.SafeBag b2 = (global::Org.BouncyCastle.Asn1.Pkcs.SafeBag)obj2;
				byte[] octets2 = ((global::Org.BouncyCastle.Asn1.Asn1OctetString)global::Org.BouncyCastle.Asn1.Pkcs.CertBag.GetInstance(b2.BagValue).CertValue).GetOctets();
				global::Org.BouncyCastle.X509.X509Certificate cert = new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(octets2);
				global::System.Collections.IDictionary attributes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
				global::Org.BouncyCastle.Asn1.Asn1OctetString localId = null;
				string alias = null;
				if (b2.BagAttributes != null)
				{
					foreach (object obj3 in b2.BagAttributes)
					{
						global::Org.BouncyCastle.Asn1.Asn1Sequence asn1Sequence = (global::Org.BouncyCastle.Asn1.Asn1Sequence)obj3;
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier aOid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(asn1Sequence[0]);
						global::Org.BouncyCastle.Asn1.Asn1Set attrSet = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(asn1Sequence[1]);
						if (attrSet.Count > 0)
						{
							global::Org.BouncyCastle.Asn1.Asn1Encodable attr = attrSet[0];
							if (attributes.Contains(aOid.Id))
							{
								if (aOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID))
								{
									string id = global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(attr).GetOctets());
									if (this.keys[id] == null && this.localIds[id] == null)
									{
										continue;
									}
								}
								if (!attributes[aOid.Id].Equals(attr))
								{
									throw new global::System.IO.IOException("attempt to add existing attribute with different value");
								}
							}
							else
							{
								attributes.Add(aOid.Id, attr);
							}
							if (aOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName))
							{
								alias = ((global::Org.BouncyCastle.Asn1.DerBmpString)attr).GetString();
							}
							else if (aOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID))
							{
								localId = (global::Org.BouncyCastle.Asn1.Asn1OctetString)attr;
							}
						}
					}
				}
				global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId certId = new global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId(cert.GetPublicKey());
				global::Org.BouncyCastle.Pkcs.X509CertificateEntry certEntry = new global::Org.BouncyCastle.Pkcs.X509CertificateEntry(cert, attributes);
				this.chainCerts[certId] = certEntry;
				if (this.unmarkedKeyEntry != null)
				{
					if (this.keyCerts.Count == 0)
					{
						string name = global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(certId.Id);
						this.keyCerts[name] = certEntry;
						this.keys[name] = this.unmarkedKeyEntry;
					}
					else
					{
						this.keys["unmarked"] = this.unmarkedKeyEntry;
					}
				}
				else
				{
					if (localId != null)
					{
						string name2 = global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(localId.GetOctets());
						this.keyCerts[name2] = certEntry;
					}
					if (alias != null)
					{
						this.certs[alias] = certEntry;
					}
				}
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00041844 File Offset: 0x0003FA44
		public global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry GetKey(string alias)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			return (global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry)this.keys[alias];
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00041865 File Offset: 0x0003FA65
		public bool IsCertificateEntry(string alias)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			return this.certs[alias] != null && this.keys[alias] == null;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00041894 File Offset: 0x0003FA94
		public bool IsKeyEntry(string alias)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			return this.keys[alias] != null;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x000418B4 File Offset: 0x0003FAB4
		private global::System.Collections.IDictionary GetAliasesTable()
		{
			global::System.Collections.IDictionary tab = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			foreach (object obj in this.certs.Keys)
			{
				string key = (string)obj;
				tab[key] = "cert";
			}
			foreach (object obj2 in this.keys.Keys)
			{
				string a = (string)obj2;
				if (tab[a] == null)
				{
					tab[a] = "key";
				}
			}
			return tab;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x0004197C File Offset: 0x0003FB7C
		public global::System.Collections.IEnumerable Aliases
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.GetAliasesTable().Keys);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0004198E File Offset: 0x0003FB8E
		public bool ContainsAlias(string alias)
		{
			return this.certs[alias] != null || this.keys[alias] != null;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000419B0 File Offset: 0x0003FBB0
		public global::Org.BouncyCastle.Pkcs.X509CertificateEntry GetCertificate(string alias)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			global::Org.BouncyCastle.Pkcs.X509CertificateEntry c = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.certs[alias];
			if (c == null)
			{
				string id = (string)this.localIds[alias];
				if (id != null)
				{
					c = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.keyCerts[id];
				}
				else
				{
					c = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.keyCerts[alias];
				}
			}
			return c;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00041A1C File Offset: 0x0003FC1C
		public string GetCertificateAlias(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			if (cert == null)
			{
				throw new global::System.ArgumentNullException("cert");
			}
			foreach (object obj in this.certs)
			{
				global::System.Collections.DictionaryEntry entry = (global::System.Collections.DictionaryEntry)obj;
				if (((global::Org.BouncyCastle.Pkcs.X509CertificateEntry)entry.Value).Certificate.Equals(cert))
				{
					return (string)entry.Key;
				}
			}
			foreach (object obj2 in this.keyCerts)
			{
				global::System.Collections.DictionaryEntry entry2 = (global::System.Collections.DictionaryEntry)obj2;
				if (((global::Org.BouncyCastle.Pkcs.X509CertificateEntry)entry2.Value).Certificate.Equals(cert))
				{
					return (string)entry2.Key;
				}
			}
			return null;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00041B18 File Offset: 0x0003FD18
		public global::Org.BouncyCastle.Pkcs.X509CertificateEntry[] GetCertificateChain(string alias)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			if (!this.IsKeyEntry(alias))
			{
				return null;
			}
			global::Org.BouncyCastle.Pkcs.X509CertificateEntry c = this.GetCertificate(alias);
			if (c != null)
			{
				global::System.Collections.IList cs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				while (c != null)
				{
					global::Org.BouncyCastle.X509.X509Certificate x509c = c.Certificate;
					global::Org.BouncyCastle.Pkcs.X509CertificateEntry nextC = null;
					global::Org.BouncyCastle.Asn1.Asn1OctetString akiValue = x509c.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityKeyIdentifier);
					if (akiValue != null)
					{
						byte[] keyID = global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier.GetInstance(akiValue.GetOctets()).GetKeyIdentifier();
						if (keyID != null)
						{
							nextC = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.chainCerts[new global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId(keyID)];
						}
					}
					if (nextC == null)
					{
						global::Org.BouncyCastle.Asn1.X509.X509Name i = x509c.IssuerDN;
						global::Org.BouncyCastle.Asn1.X509.X509Name s = x509c.SubjectDN;
						if (!i.Equivalent(s))
						{
							foreach (object obj in this.chainCerts.Keys)
							{
								global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId certId = (global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId)obj;
								global::Org.BouncyCastle.Pkcs.X509CertificateEntry x509CertEntry = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.chainCerts[certId];
								global::Org.BouncyCastle.X509.X509Certificate crt = x509CertEntry.Certificate;
								if (crt.SubjectDN.Equivalent(i))
								{
									try
									{
										x509c.Verify(crt.GetPublicKey());
										nextC = x509CertEntry;
										break;
									}
									catch (global::Org.BouncyCastle.Security.InvalidKeyException)
									{
									}
								}
							}
						}
					}
					cs.Add(c);
					if (nextC != c)
					{
						c = nextC;
					}
					else
					{
						c = null;
					}
				}
				global::Org.BouncyCastle.Pkcs.X509CertificateEntry[] result = new global::Org.BouncyCastle.Pkcs.X509CertificateEntry[cs.Count];
				for (int j = 0; j < cs.Count; j++)
				{
					result[j] = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)cs[j];
				}
				return result;
			}
			return null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00041CB8 File Offset: 0x0003FEB8
		public void SetCertificateEntry(string alias, global::Org.BouncyCastle.Pkcs.X509CertificateEntry certEntry)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			if (certEntry == null)
			{
				throw new global::System.ArgumentNullException("certEntry");
			}
			if (this.keys[alias] != null)
			{
				throw new global::System.ArgumentException("There is a key entry with the name " + alias + ".");
			}
			this.certs[alias] = certEntry;
			this.chainCerts[new global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId(certEntry.Certificate.GetPublicKey())] = certEntry;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00041D30 File Offset: 0x0003FF30
		public void SetKeyEntry(string alias, global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry keyEntry, global::Org.BouncyCastle.Pkcs.X509CertificateEntry[] chain)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			if (keyEntry == null)
			{
				throw new global::System.ArgumentNullException("keyEntry");
			}
			if (keyEntry.Key.IsPrivate && chain == null)
			{
				throw new global::System.ArgumentException("No certificate chain for private key");
			}
			if (this.keys[alias] != null)
			{
				this.DeleteEntry(alias);
			}
			this.keys[alias] = keyEntry;
			this.certs[alias] = chain[0];
			for (int i = 0; i != chain.Length; i++)
			{
				this.chainCerts[new global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId(chain[i].Certificate.GetPublicKey())] = chain[i];
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00041DD4 File Offset: 0x0003FFD4
		public void DeleteEntry(string alias)
		{
			if (alias == null)
			{
				throw new global::System.ArgumentNullException("alias");
			}
			global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry i = (global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry)this.keys[alias];
			if (i != null)
			{
				this.keys.Remove(alias);
			}
			global::Org.BouncyCastle.Pkcs.X509CertificateEntry c = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.certs[alias];
			if (c != null)
			{
				this.certs.Remove(alias);
				this.chainCerts.Remove(new global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId(c.Certificate.GetPublicKey()));
			}
			if (i != null)
			{
				string id = (string)this.localIds[alias];
				if (id != null)
				{
					this.localIds.Remove(alias);
					c = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.keyCerts[id];
				}
				if (c != null)
				{
					this.keyCerts.Remove(id);
					this.chainCerts.Remove(new global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId(c.Certificate.GetPublicKey()));
				}
			}
			if (c == null && i == null)
			{
				throw new global::System.ArgumentException("no such entry as " + alias);
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00041EC8 File Offset: 0x000400C8
		public bool IsEntryOfType(string alias, global::System.Type entryType)
		{
			if (entryType == typeof(global::Org.BouncyCastle.Pkcs.X509CertificateEntry))
			{
				return this.IsCertificateEntry(alias);
			}
			return entryType == typeof(global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry) && this.IsKeyEntry(alias) && this.GetCertificate(alias) != null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00041F18 File Offset: 0x00040118
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size()
		{
			return this.Count;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00041F20 File Offset: 0x00040120
		public int Count
		{
			get
			{
				return this.GetAliasesTable().Count;
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00041F30 File Offset: 0x00040130
		public void Save(global::System.IO.Stream stream, char[] password, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (random == null)
			{
				throw new global::System.ArgumentNullException("random");
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector keyBags = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.keys.Keys)
			{
				string name = (string)obj;
				byte[] kSalt = new byte[20];
				random.NextBytes(kSalt);
				global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry privKey = (global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry)this.keys[name];
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier bagOid;
				global::Org.BouncyCastle.Asn1.Asn1Encodable bagData;
				if (password == null)
				{
					bagOid = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.KeyBag;
					bagData = global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(privKey.Key);
				}
				else
				{
					bagOid = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs8ShroudedKeyBag;
					if (this.keyPrfAlgorithm != null)
					{
						bagData = global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(this.keyAlgorithm, this.keyPrfAlgorithm, password, kSalt, 1024, random, privKey.Key);
					}
					else
					{
						bagData = global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(this.keyAlgorithm, password, kSalt, 1024, privKey.Key);
					}
				}
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector kName = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				foreach (object obj2 in privKey.BagAttributeKeys)
				{
					string oid = (string)obj2;
					global::Org.BouncyCastle.Asn1.Asn1Encodable entry = privKey[oid];
					if (!oid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName.Id))
					{
						kName.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
						{
							new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid),
							new global::Org.BouncyCastle.Asn1.DerSet(entry)
						}));
					}
				}
				kName.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName,
					new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerBmpString(name))
				}));
				if (privKey[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID] == null)
				{
					global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier subjectKeyID = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CreateSubjectKeyID(this.GetCertificate(name).Certificate.GetPublicKey());
					kName.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
					{
						global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID,
						new global::Org.BouncyCastle.Asn1.DerSet(subjectKeyID)
					}));
				}
				keyBags.Add(new global::Org.BouncyCastle.Asn1.Pkcs.SafeBag(bagOid, bagData.ToAsn1Object(), new global::Org.BouncyCastle.Asn1.DerSet(kName)));
			}
			byte[] keyBagsEncoding = new global::Org.BouncyCastle.Asn1.DerSequence(keyBags).GetDerEncoded();
			global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo keysInfo = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data, new global::Org.BouncyCastle.Asn1.BerOctetString(keyBagsEncoding));
			byte[] cSalt = new byte[20];
			random.NextBytes(cSalt);
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector certBags = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams cParams = new global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams(cSalt, 1024);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier cAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(this.certAlgorithm, cParams.ToAsn1Object());
			global::Org.BouncyCastle.Utilities.Collections.ISet doneCerts = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj3 in this.keys.Keys)
			{
				string name2 = (string)obj3;
				global::Org.BouncyCastle.Pkcs.X509CertificateEntry certEntry = this.GetCertificate(name2);
				global::Org.BouncyCastle.Asn1.Pkcs.CertBag cBag = new global::Org.BouncyCastle.Asn1.Pkcs.CertBag(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.X509Certificate, new global::Org.BouncyCastle.Asn1.DerOctetString(certEntry.Certificate.GetEncoded()));
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector fName = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				foreach (object obj4 in certEntry.BagAttributeKeys)
				{
					string oid2 = (string)obj4;
					global::Org.BouncyCastle.Asn1.Asn1Encodable entry2 = certEntry[oid2];
					if (!oid2.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName.Id))
					{
						fName.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
						{
							new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid2),
							new global::Org.BouncyCastle.Asn1.DerSet(entry2)
						}));
					}
				}
				fName.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName,
					new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerBmpString(name2))
				}));
				if (certEntry[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID] == null)
				{
					global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier subjectKeyID2 = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CreateSubjectKeyID(certEntry.Certificate.GetPublicKey());
					fName.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
					{
						global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID,
						new global::Org.BouncyCastle.Asn1.DerSet(subjectKeyID2)
					}));
				}
				certBags.Add(new global::Org.BouncyCastle.Asn1.Pkcs.SafeBag(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.CertBag, cBag.ToAsn1Object(), new global::Org.BouncyCastle.Asn1.DerSet(fName)));
				doneCerts.Add(certEntry.Certificate);
			}
			foreach (object obj5 in this.certs.Keys)
			{
				string certId = (string)obj5;
				global::Org.BouncyCastle.Pkcs.X509CertificateEntry cert = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.certs[certId];
				if (this.keys[certId] == null)
				{
					global::Org.BouncyCastle.Asn1.Pkcs.CertBag cBag2 = new global::Org.BouncyCastle.Asn1.Pkcs.CertBag(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.X509Certificate, new global::Org.BouncyCastle.Asn1.DerOctetString(cert.Certificate.GetEncoded()));
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector fName2 = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					foreach (object obj6 in cert.BagAttributeKeys)
					{
						string oid3 = (string)obj6;
						if (!oid3.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID.Id))
						{
							global::Org.BouncyCastle.Asn1.Asn1Encodable entry3 = cert[oid3];
							if (!oid3.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName.Id))
							{
								fName2.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
								{
									new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid3),
									new global::Org.BouncyCastle.Asn1.DerSet(entry3)
								}));
							}
						}
					}
					fName2.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
					{
						global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtFriendlyName,
						new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerBmpString(certId))
					}));
					certBags.Add(new global::Org.BouncyCastle.Asn1.Pkcs.SafeBag(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.CertBag, cBag2.ToAsn1Object(), new global::Org.BouncyCastle.Asn1.DerSet(fName2)));
					doneCerts.Add(cert.Certificate);
				}
			}
			foreach (object obj7 in this.chainCerts.Keys)
			{
				global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId certId2 = (global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId)obj7;
				global::Org.BouncyCastle.Pkcs.X509CertificateEntry cert2 = (global::Org.BouncyCastle.Pkcs.X509CertificateEntry)this.chainCerts[certId2];
				if (!doneCerts.Contains(cert2.Certificate))
				{
					global::Org.BouncyCastle.Asn1.Pkcs.CertBag cBag3 = new global::Org.BouncyCastle.Asn1.Pkcs.CertBag(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.X509Certificate, new global::Org.BouncyCastle.Asn1.DerOctetString(cert2.Certificate.GetEncoded()));
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector fName3 = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					foreach (object obj8 in cert2.BagAttributeKeys)
					{
						string oid4 = (string)obj8;
						if (!oid4.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtLocalKeyID.Id))
						{
							fName3.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
							{
								new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid4),
								new global::Org.BouncyCastle.Asn1.DerSet(cert2[oid4])
							}));
						}
					}
					certBags.Add(new global::Org.BouncyCastle.Asn1.Pkcs.SafeBag(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.CertBag, cBag3.ToAsn1Object(), new global::Org.BouncyCastle.Asn1.DerSet(fName3)));
				}
			}
			byte[] certBagsEncoding = new global::Org.BouncyCastle.Asn1.DerSequence(certBags).GetDerEncoded();
			global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo certsInfo;
			if (password == null || this.certAlgorithm == null)
			{
				certsInfo = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data, new global::Org.BouncyCastle.Asn1.BerOctetString(certBagsEncoding));
			}
			else
			{
				byte[] certBytes = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CryptPbeData(true, cAlgId, password, false, certBagsEncoding);
				global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData cInfo = new global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data, cAlgId, new global::Org.BouncyCastle.Asn1.BerOctetString(certBytes));
				certsInfo = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.EncryptedData, cInfo.ToAsn1Object());
			}
			byte[] data = new global::Org.BouncyCastle.Asn1.Pkcs.AuthenticatedSafe(new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo[]
			{
				keysInfo,
				certsInfo
			}).GetEncoded(this.useDerEncoding ? "DER" : "BER");
			global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo = new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data, new global::Org.BouncyCastle.Asn1.BerOctetString(data));
			global::Org.BouncyCastle.Asn1.Pkcs.MacData macData = null;
			if (password != null)
			{
				byte[] mSalt = new byte[20];
				random.NextBytes(mSalt);
				byte[] mac = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CalculatePbeMac(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, mSalt, 1024, password, false, data);
				macData = new global::Org.BouncyCastle.Asn1.Pkcs.MacData(new global::Org.BouncyCastle.Asn1.X509.DigestInfo(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance), mac), mSalt, 1024);
			}
			new global::Org.BouncyCastle.Asn1.Pkcs.Pfx(contentInfo, macData).EncodeTo(stream, this.useDerEncoding ? "DER" : "BER");
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000427C4 File Offset: 0x000409C4
		internal static byte[] CalculatePbeMac(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, byte[] salt, int itCount, char[] password, bool wrongPkcs12Zero, byte[] data)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = global::Org.BouncyCastle.Security.PbeUtilities.GenerateAlgorithmParameters(oid, salt, itCount);
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParams = global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(oid, password, wrongPkcs12Zero, asn1Params);
			global::Org.BouncyCastle.Crypto.IMac mac = (global::Org.BouncyCastle.Crypto.IMac)global::Org.BouncyCastle.Security.PbeUtilities.CreateEngine(oid);
			mac.Init(cipherParams);
			return global::Org.BouncyCastle.Security.MacUtilities.DoFinal(mac, data);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00042800 File Offset: 0x00040A00
		private static byte[] CryptPbeData(bool forEncryption, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, char[] password, bool wrongPkcs12Zero, byte[] data)
		{
			global::Org.BouncyCastle.Crypto.IBufferedCipher cipher = global::Org.BouncyCastle.Security.PbeUtilities.CreateEngine(algId) as global::Org.BouncyCastle.Crypto.IBufferedCipher;
			if (cipher == null)
			{
				string str = "Unknown encryption algorithm: ";
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm = algId.Algorithm;
				throw new global::System.Exception(str + ((algorithm != null) ? algorithm.ToString() : null));
			}
			if (algId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbeS2))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters pbeParameters = global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters.GetInstance(algId.Parameters);
				global::Org.BouncyCastle.Crypto.ICipherParameters cipherParams = global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algId.Algorithm, password, pbeParameters);
				cipher.Init(forEncryption, cipherParams);
				return cipher.DoFinal(data);
			}
			global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams pbeParameters2 = global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams.GetInstance(algId.Parameters);
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParams2 = global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algId.Algorithm, password, wrongPkcs12Zero, pbeParameters2);
			cipher.Init(forEncryption, cipherParams2);
			return cipher.DoFinal(data);
		}

		// Token: 0x040008A1 RID: 2209
		public const string IgnoreUselessPasswordProperty = "Org.BouncyCastle.Pkcs12.IgnoreUselessPassword";

		// Token: 0x040008A2 RID: 2210
		private readonly global::Org.BouncyCastle.Pkcs.Pkcs12Store.IgnoresCaseHashtable keys = new global::Org.BouncyCastle.Pkcs.Pkcs12Store.IgnoresCaseHashtable();

		// Token: 0x040008A3 RID: 2211
		private readonly global::System.Collections.IDictionary localIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008A4 RID: 2212
		private readonly global::Org.BouncyCastle.Pkcs.Pkcs12Store.IgnoresCaseHashtable certs = new global::Org.BouncyCastle.Pkcs.Pkcs12Store.IgnoresCaseHashtable();

		// Token: 0x040008A5 RID: 2213
		private readonly global::System.Collections.IDictionary chainCerts = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008A6 RID: 2214
		private readonly global::System.Collections.IDictionary keyCerts = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008A7 RID: 2215
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm;

		// Token: 0x040008A8 RID: 2216
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyPrfAlgorithm;

		// Token: 0x040008A9 RID: 2217
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm;

		// Token: 0x040008AA RID: 2218
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier certPrfAlgorithm;

		// Token: 0x040008AB RID: 2219
		private readonly bool useDerEncoding;

		// Token: 0x040008AC RID: 2220
		private global::Org.BouncyCastle.Pkcs.AsymmetricKeyEntry unmarkedKeyEntry;

		// Token: 0x040008AD RID: 2221
		private const int MinIterations = 1024;

		// Token: 0x040008AE RID: 2222
		private const int SaltSize = 20;

		// Token: 0x020007AF RID: 1967
		internal class CertId
		{
			// Token: 0x06004534 RID: 17716 RVA: 0x00132C29 File Offset: 0x00130E29
			internal CertId(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey)
			{
				this.id = global::Org.BouncyCastle.Pkcs.Pkcs12Store.CreateSubjectKeyID(pubKey).GetKeyIdentifier();
			}

			// Token: 0x06004535 RID: 17717 RVA: 0x00132C42 File Offset: 0x00130E42
			internal CertId(byte[] id)
			{
				this.id = id;
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06004536 RID: 17718 RVA: 0x00132C51 File Offset: 0x00130E51
			internal byte[] Id
			{
				get
				{
					return this.id;
				}
			}

			// Token: 0x06004537 RID: 17719 RVA: 0x00132C59 File Offset: 0x00130E59
			public override int GetHashCode()
			{
				return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.id);
			}

			// Token: 0x06004538 RID: 17720 RVA: 0x00132C68 File Offset: 0x00130E68
			public override bool Equals(object obj)
			{
				if (obj == this)
				{
					return true;
				}
				global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId other = obj as global::Org.BouncyCastle.Pkcs.Pkcs12Store.CertId;
				return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.id, other.id);
			}

			// Token: 0x04002332 RID: 9010
			private readonly byte[] id;
		}

		// Token: 0x020007B0 RID: 1968
		private class IgnoresCaseHashtable : global::System.Collections.IEnumerable
		{
			// Token: 0x06004539 RID: 17721 RVA: 0x00132C98 File Offset: 0x00130E98
			public void Clear()
			{
				this.orig.Clear();
				this.keys.Clear();
			}

			// Token: 0x0600453A RID: 17722 RVA: 0x00132CB0 File Offset: 0x00130EB0
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return this.orig.GetEnumerator();
			}

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x0600453B RID: 17723 RVA: 0x00132CBD File Offset: 0x00130EBD
			public global::System.Collections.ICollection Keys
			{
				get
				{
					return this.orig.Keys;
				}
			}

			// Token: 0x0600453C RID: 17724 RVA: 0x00132CCC File Offset: 0x00130ECC
			public object Remove(string alias)
			{
				string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(alias);
				string i = (string)this.keys[upper];
				if (i == null)
				{
					return null;
				}
				this.keys.Remove(upper);
				object result = this.orig[i];
				this.orig.Remove(i);
				return result;
			}

			// Token: 0x17000A76 RID: 2678
			public object this[string alias]
			{
				get
				{
					string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(alias);
					string i = (string)this.keys[upper];
					if (i == null)
					{
						return null;
					}
					return this.orig[i];
				}
				set
				{
					string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(alias);
					string i = (string)this.keys[upper];
					if (i != null)
					{
						this.orig.Remove(i);
					}
					this.keys[upper] = alias;
					this.orig[alias] = value;
				}
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x0600453F RID: 17727 RVA: 0x00132DA3 File Offset: 0x00130FA3
			public global::System.Collections.ICollection Values
			{
				get
				{
					return this.orig.Values;
				}
			}

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06004540 RID: 17728 RVA: 0x00132DB0 File Offset: 0x00130FB0
			public int Count
			{
				get
				{
					return this.orig.Count;
				}
			}

			// Token: 0x04002333 RID: 9011
			private readonly global::System.Collections.IDictionary orig = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

			// Token: 0x04002334 RID: 9012
			private readonly global::System.Collections.IDictionary keys = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}
	}
}
