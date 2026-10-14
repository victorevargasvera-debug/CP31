using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.IsisMtt;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Extension;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x0200019F RID: 415
	public class PkixCertPathValidatorUtilities
	{
		// Token: 0x06000F30 RID: 3888 RVA: 0x0003887C File Offset: 0x00036A7C
		internal static global::Org.BouncyCastle.Pkix.TrustAnchor FindTrustAnchor(global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.Utilities.Collections.ISet trustAnchors)
		{
			global::System.Collections.IEnumerator iter = trustAnchors.GetEnumerator();
			global::Org.BouncyCastle.Pkix.TrustAnchor trust = null;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter trustPublicKey = null;
			global::System.Exception invalidKeyEx = null;
			global::Org.BouncyCastle.X509.Store.X509CertStoreSelector certSelectX509 = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
			try
			{
				certSelectX509.Subject = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert);
				goto IL_BC;
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::System.Exception("Cannot set subject search criteria for trust anchor.", ex);
			}
			IL_35:
			trust = (global::Org.BouncyCastle.Pkix.TrustAnchor)iter.Current;
			if (trust.TrustedCert != null)
			{
				if (certSelectX509.Match(trust.TrustedCert))
				{
					trustPublicKey = trust.TrustedCert.GetPublicKey();
				}
				else
				{
					trust = null;
				}
			}
			else
			{
				if (trust.CAName != null && trust.CAPublicKey != null)
				{
					try
					{
						global::Org.BouncyCastle.Asn1.X509.X509Name issuerPrincipal = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert);
						global::Org.BouncyCastle.Asn1.X509.X509Name caName = new global::Org.BouncyCastle.Asn1.X509.X509Name(trust.CAName);
						if (issuerPrincipal.Equivalent(caName, true))
						{
							trustPublicKey = trust.CAPublicKey;
						}
						else
						{
							trust = null;
						}
						goto IL_AB;
					}
					catch (global::Org.BouncyCastle.Security.InvalidParameterException)
					{
						trust = null;
						goto IL_AB;
					}
				}
				trust = null;
			}
			IL_AB:
			if (trustPublicKey != null)
			{
				try
				{
					cert.Verify(trustPublicKey);
				}
				catch (global::System.Exception invalidKeyEx)
				{
					trust = null;
				}
			}
			IL_BC:
			if (iter.MoveNext() && trust == null)
			{
				goto IL_35;
			}
			if (trust == null && invalidKeyEx != null)
			{
				throw new global::System.Exception("TrustAnchor found but certificate validation failed.", invalidKeyEx);
			}
			return trust;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00038990 File Offset: 0x00036B90
		internal static bool IsIssuerTrustAnchor(global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.Utilities.Collections.ISet trustAnchors)
		{
			bool result;
			try
			{
				result = (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindTrustAnchor(cert, trustAnchors) != null);
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000389C0 File Offset: 0x00036BC0
		internal static void AddAdditionalStoresFromAltNames(global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			if (cert.GetIssuerAlternativeNames() != null)
			{
				foreach (object obj in cert.GetIssuerAlternativeNames())
				{
					global::System.Collections.IList list = (global::System.Collections.IList)obj;
					if (list[0].Equals(6))
					{
						global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoreFromLocation((string)list[1], pkixParams);
					}
				}
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00038A20 File Offset: 0x00036C20
		internal static global::System.DateTime GetValidDate(global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX)
		{
			global::Org.BouncyCastle.Utilities.Date.DateTimeObject validDate = paramsPKIX.Date;
			if (validDate == null)
			{
				return global::System.DateTime.UtcNow;
			}
			return validDate.Value;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00038A43 File Offset: 0x00036C43
		internal static global::Org.BouncyCastle.Asn1.X509.X509Name GetIssuerPrincipal(object cert)
		{
			if (cert is global::Org.BouncyCastle.X509.X509Certificate)
			{
				return ((global::Org.BouncyCastle.X509.X509Certificate)cert).IssuerDN;
			}
			return ((global::Org.BouncyCastle.X509.IX509AttributeCertificate)cert).Issuer.GetPrincipals()[0];
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00038A6B File Offset: 0x00036C6B
		internal static bool IsSelfIssued(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			return cert.SubjectDN.Equivalent(cert.IssuerDN, true);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00038A80 File Offset: 0x00036C80
		internal static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetAlgorithmIdentifier(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmID;
			try
			{
				algorithmID = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(key).AlgorithmID;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subject public key cannot be decoded.", e);
			}
			return algorithmID;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00038ABC File Offset: 0x00036CBC
		internal static bool IsAnyPolicy(global::Org.BouncyCastle.Utilities.Collections.ISet policySet)
		{
			return policySet == null || policySet.Contains(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ANY_POLICY) || policySet.Count == 0;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00038ADC File Offset: 0x00036CDC
		internal static void AddAdditionalStoreFromLocation(string location, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			if (pkixParams.IsAdditionalLocationsEnabled)
			{
				try
				{
					if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(location, "ldap://"))
					{
						location = location.Substring(7);
						int slashPos = location.IndexOf('/');
						if (slashPos != -1)
						{
							"ldap://" + location.Substring(0, slashPos);
						}
						else
						{
							"ldap://" + location;
						}
						throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("LDAP cert/CRL stores");
					}
				}
				catch (global::System.Exception)
				{
					throw new global::System.Exception("Exception adding X.509 stores.");
				}
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00038B60 File Offset: 0x00036D60
		private static global::Org.BouncyCastle.Math.BigInteger GetSerialNumber(object cert)
		{
			if (cert is global::Org.BouncyCastle.X509.X509Certificate)
			{
				return ((global::Org.BouncyCastle.X509.X509Certificate)cert).SerialNumber;
			}
			return ((global::Org.BouncyCastle.X509.X509V2AttributeCertificate)cert).SerialNumber;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00038B84 File Offset: 0x00036D84
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet GetQualifierSet(global::Org.BouncyCastle.Asn1.Asn1Sequence qualifiers)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet pq = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			if (qualifiers == null)
			{
				return pq;
			}
			foreach (object obj in qualifiers)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
				try
				{
					pq.Add(global::Org.BouncyCastle.Asn1.X509.PolicyQualifierInfo.GetInstance(ae.ToAsn1Object()));
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy qualifier info cannot be decoded.", ex);
				}
			}
			return pq;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00038C0C File Offset: 0x00036E0C
		internal static global::Org.BouncyCastle.Pkix.PkixPolicyNode RemovePolicyNode(global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree, global::System.Collections.IList[] policyNodes, global::Org.BouncyCastle.Pkix.PkixPolicyNode _node)
		{
			global::Org.BouncyCastle.Pkix.PkixPolicyNode _parent = _node.Parent;
			if (validPolicyTree == null)
			{
				return null;
			}
			if (_parent == null)
			{
				for (int i = 0; i < policyNodes.Length; i++)
				{
					policyNodes[i] = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				}
				return null;
			}
			_parent.RemoveChild(_node);
			global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNodeRecurse(policyNodes, _node);
			return validPolicyTree;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00038C50 File Offset: 0x00036E50
		private static void RemovePolicyNodeRecurse(global::System.Collections.IList[] policyNodes, global::Org.BouncyCastle.Pkix.PkixPolicyNode _node)
		{
			policyNodes[_node.Depth].Remove(_node);
			if (_node.HasChildren)
			{
				foreach (object obj in _node.Children)
				{
					global::Org.BouncyCastle.Pkix.PkixPolicyNode _child = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj;
					global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNodeRecurse(policyNodes, _child);
				}
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00038CC0 File Offset: 0x00036EC0
		internal static void PrepareNextCertB1(int i, global::System.Collections.IList[] policyNodes, string id_p, global::System.Collections.IDictionary m_idp, global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			bool idp_found = false;
			foreach (object obj in policyNodes[i])
			{
				global::Org.BouncyCastle.Pkix.PkixPolicyNode node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj;
				if (node.ValidPolicy.Equals(id_p))
				{
					idp_found = true;
					node.ExpectedPolicies = (global::Org.BouncyCastle.Utilities.Collections.ISet)m_idp[id_p];
					break;
				}
			}
			if (!idp_found)
			{
				foreach (object obj2 in policyNodes[i])
				{
					global::Org.BouncyCastle.Pkix.PkixPolicyNode node2 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj2;
					if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ANY_POLICY.Equals(node2.ValidPolicy))
					{
						global::Org.BouncyCastle.Utilities.Collections.ISet pq = null;
						global::Org.BouncyCastle.Asn1.Asn1Sequence policies = null;
						try
						{
							policies = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies));
						}
						catch (global::System.Exception e)
						{
							throw new global::System.Exception("Certificate policies cannot be decoded.", e);
						}
						global::System.Collections.IEnumerator enm = policies.GetEnumerator();
						while (enm.MoveNext())
						{
							global::Org.BouncyCastle.Asn1.X509.PolicyInformation pinfo = null;
							try
							{
								pinfo = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(enm.Current);
							}
							catch (global::System.Exception ex)
							{
								throw new global::System.Exception("Policy information cannot be decoded.", ex);
							}
							if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ANY_POLICY.Equals(pinfo.PolicyIdentifier.Id))
							{
								try
								{
									pq = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetQualifierSet(pinfo.PolicyQualifiers);
									break;
								}
								catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException ex2)
								{
									throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy qualifier info set could not be built.", ex2);
								}
							}
						}
						bool ci = false;
						global::Org.BouncyCastle.Utilities.Collections.ISet critExtOids = cert.GetCriticalExtensionOids();
						if (critExtOids != null)
						{
							ci = critExtOids.Contains(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies.Id);
						}
						global::Org.BouncyCastle.Pkix.PkixPolicyNode p_node = node2.Parent;
						if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ANY_POLICY.Equals(p_node.ValidPolicy))
						{
							global::Org.BouncyCastle.Pkix.PkixPolicyNode c_node = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), i, (global::Org.BouncyCastle.Utilities.Collections.ISet)m_idp[id_p], p_node, pq, id_p, ci);
							p_node.AddChild(c_node);
							policyNodes[i].Add(c_node);
							return;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00038E84 File Offset: 0x00037084
		internal static global::Org.BouncyCastle.Pkix.PkixPolicyNode PrepareNextCertB2(int i, global::System.Collections.IList[] policyNodes, string id_p, global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree)
		{
			int pos = 0;
			foreach (object obj in global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(policyNodes[i]))
			{
				global::Org.BouncyCastle.Pkix.PkixPolicyNode node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj;
				if (node.ValidPolicy.Equals(id_p))
				{
					node.Parent.RemoveChild(node);
					policyNodes[i].RemoveAt(pos);
					for (int j = i - 1; j >= 0; j--)
					{
						global::System.Collections.IList nodes = policyNodes[j];
						for (int k = 0; k < nodes.Count; k++)
						{
							global::Org.BouncyCastle.Pkix.PkixPolicyNode node2 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)nodes[k];
							if (!node2.HasChildren)
							{
								validPolicyTree = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, node2);
								if (validPolicyTree == null)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					pos++;
				}
			}
			return validPolicyTree;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00038F60 File Offset: 0x00037160
		internal static void GetCertStatus(global::System.DateTime validDate, global::Org.BouncyCastle.X509.X509Crl crl, object cert, global::Org.BouncyCastle.Pkix.CertStatus certStatus)
		{
			global::Org.BouncyCastle.X509.X509Crl bcCRL = null;
			try
			{
				bcCRL = new global::Org.BouncyCastle.X509.X509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(crl.GetEncoded())));
			}
			catch (global::System.Exception exception)
			{
				throw new global::System.Exception("Bouncy Castle X509Crl could not be created.", exception);
			}
			global::Org.BouncyCastle.X509.X509CrlEntry crl_entry = bcCRL.GetRevokedCertificate(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetSerialNumber(cert));
			if (crl_entry == null)
			{
				return;
			}
			global::Org.BouncyCastle.Asn1.X509.X509Name issuer = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert);
			if (!issuer.Equivalent(crl_entry.GetCertificateIssuer(), true) && !issuer.Equivalent(crl.IssuerDN, true))
			{
				return;
			}
			int reasonCodeValue = 0;
			if (crl_entry.HasExtensions)
			{
				try
				{
					global::Org.BouncyCastle.Asn1.DerEnumerated reasonCode = global::Org.BouncyCastle.Asn1.DerEnumerated.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(crl_entry, global::Org.BouncyCastle.Asn1.X509.X509Extensions.ReasonCode));
					if (reasonCode != null)
					{
						reasonCodeValue = reasonCode.IntValueExact;
					}
				}
				catch (global::System.Exception e)
				{
					throw new global::System.Exception("Reason code CRL entry extension could not be decoded.", e);
				}
			}
			global::System.DateTime revocationDate = crl_entry.RevocationDate;
			if (validDate.Ticks < revocationDate.Ticks && reasonCodeValue > 2 && reasonCodeValue != 10)
			{
				return;
			}
			certStatus.Status = reasonCodeValue;
			certStatus.RevocationDate = new global::Org.BouncyCastle.Utilities.Date.DateTimeObject(revocationDate);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00039060 File Offset: 0x00037260
		internal static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetNextWorkingKey(global::System.Collections.IList certs, int index)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey = ((global::Org.BouncyCastle.X509.X509Certificate)certs[index]).GetPublicKey();
			if (!(pubKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters))
			{
				return pubKey;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters dsaPubKey = (global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)pubKey;
			if (dsaPubKey.Parameters != null)
			{
				return dsaPubKey;
			}
			for (int i = index + 1; i < certs.Count; i++)
			{
				pubKey = ((global::Org.BouncyCastle.X509.X509Certificate)certs[i]).GetPublicKey();
				if (!(pubKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters))
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("DSA parameters cannot be inherited from previous certificate.");
				}
				global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters prevDSAPubKey = (global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)pubKey;
				if (prevDSAPubKey.Parameters != null)
				{
					global::Org.BouncyCastle.Crypto.Parameters.DsaParameters dsaParams = prevDSAPubKey.Parameters;
					try
					{
						return new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(dsaPubKey.Y, dsaParams);
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(ex.Message);
					}
				}
			}
			throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("DSA parameters cannot be inherited from previous certificate.");
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00039124 File Offset: 0x00037324
		internal static global::System.DateTime GetValidCertDateFromValidityModel(global::Org.BouncyCastle.Pkix.PkixParameters paramsPkix, global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index)
		{
			if (paramsPkix.ValidityModel != 1)
			{
				return global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetValidDate(paramsPkix);
			}
			if (index <= 0)
			{
				return global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetValidDate(paramsPkix);
			}
			if (index - 1 == 0)
			{
				global::Org.BouncyCastle.Asn1.DerGeneralizedTime dateOfCertgen = null;
				try
				{
					dateOfCertgen = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index - 1]).GetExtensionValue(global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATDateOfCertGen));
				}
				catch (global::System.ArgumentException)
				{
					throw new global::System.Exception("Date of cert gen extension could not be read.");
				}
				if (dateOfCertgen != null)
				{
					try
					{
						return dateOfCertgen.ToDateTime();
					}
					catch (global::System.ArgumentException e)
					{
						throw new global::System.Exception("Date from date of cert gen extension could not be parsed.", e);
					}
				}
			}
			return ((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index - 1]).NotBefore;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000391D4 File Offset: 0x000373D4
		internal static global::System.Collections.ICollection FindCertificates(global::Org.BouncyCastle.X509.Store.X509CertStoreSelector certSelect, global::System.Collections.IList certStores)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet certs = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in certStores)
			{
				global::Org.BouncyCastle.X509.Store.IX509Store certStore = (global::Org.BouncyCastle.X509.Store.IX509Store)obj;
				try
				{
					foreach (object obj2 in certStore.GetMatches(certSelect))
					{
						global::Org.BouncyCastle.X509.X509Certificate c = (global::Org.BouncyCastle.X509.X509Certificate)obj2;
						certs.Add(c);
					}
				}
				catch (global::System.Exception e)
				{
					throw new global::System.Exception("Problem while picking certificates from X.509 store.", e);
				}
			}
			return certs;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00039298 File Offset: 0x00037498
		internal static void GetCrlIssuersFromDistributionPoint(global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp, global::System.Collections.ICollection issuerPrincipals, global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector selector, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::System.Collections.IList issuers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (dp.CrlIssuer != null)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames = dp.CrlIssuer.GetNames();
				for (int i = 0; i < genNames.Length; i++)
				{
					if (genNames[i].TagNo == 4)
					{
						try
						{
							issuers.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(genNames[i].Name.ToAsn1Object()));
						}
						catch (global::System.IO.IOException e)
						{
							throw new global::System.Exception("CRL issuer information from distribution point cannot be decoded.", e);
						}
					}
				}
			}
			else
			{
				if (dp.DistributionPointName == null)
				{
					throw new global::System.Exception("CRL issuer is omitted from distribution point but no distributionPoint field present.");
				}
				foreach (object obj in issuerPrincipals)
				{
					issuers.Add((global::Org.BouncyCastle.Asn1.X509.X509Name)obj);
				}
			}
			selector.Issuers = issuers;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00039354 File Offset: 0x00037554
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet GetCompleteCrls(global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp, object cert, global::System.DateTime currentDate, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX)
		{
			global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector crlselect = new global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector();
			try
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet issuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				if (cert is global::Org.BouncyCastle.X509.X509V2AttributeCertificate)
				{
					issuers.Add(((global::Org.BouncyCastle.X509.X509V2AttributeCertificate)cert).Issuer.GetPrincipals()[0]);
				}
				else
				{
					issuers.Add(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert));
				}
				global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetCrlIssuersFromDistributionPoint(dp, issuers, crlselect, paramsPKIX);
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("Could not get issuer information from distribution point.", e);
			}
			if (cert is global::Org.BouncyCastle.X509.X509Certificate)
			{
				crlselect.CertificateChecking = (global::Org.BouncyCastle.X509.X509Certificate)cert;
			}
			else if (cert is global::Org.BouncyCastle.X509.X509V2AttributeCertificate)
			{
				crlselect.AttrCertChecking = (global::Org.BouncyCastle.X509.IX509AttributeCertificate)cert;
			}
			crlselect.CompleteCrlEnabled = true;
			global::Org.BouncyCastle.Utilities.Collections.ISet set = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.CrlUtilities.FindCrls(crlselect, paramsPKIX, currentDate);
			if (!set.IsEmpty)
			{
				return set;
			}
			if (cert is global::Org.BouncyCastle.X509.IX509AttributeCertificate)
			{
				global::Org.BouncyCastle.X509.IX509AttributeCertificate aCert = (global::Org.BouncyCastle.X509.IX509AttributeCertificate)cert;
				string str = "No CRLs found for issuer \"";
				global::Org.BouncyCastle.Asn1.X509.X509Name x509Name = aCert.Issuer.GetPrincipals()[0];
				throw new global::System.Exception(str + ((x509Name != null) ? x509Name.ToString() : null) + "\"");
			}
			global::Org.BouncyCastle.X509.X509Certificate xCert = (global::Org.BouncyCastle.X509.X509Certificate)cert;
			string str2 = "No CRLs found for issuer \"";
			global::Org.BouncyCastle.Asn1.X509.X509Name issuerDN = xCert.IssuerDN;
			throw new global::System.Exception(str2 + ((issuerDN != null) ? issuerDN.ToString() : null) + "\"");
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00039478 File Offset: 0x00037678
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet GetDeltaCrls(global::System.DateTime currentDate, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.X509.X509Crl completeCRL)
		{
			global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector deltaSelect = new global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector();
			try
			{
				global::System.Collections.IList deltaSelectIssuer = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				deltaSelectIssuer.Add(completeCRL.IssuerDN);
				deltaSelect.Issuers = deltaSelectIssuer;
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.Exception("Cannot extract issuer from CRL.", e);
			}
			global::Org.BouncyCastle.Math.BigInteger completeCRLNumber = null;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Object asn1Object = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(completeCRL, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlNumber);
				if (asn1Object != null)
				{
					completeCRLNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(asn1Object).PositiveValue;
				}
			}
			catch (global::System.Exception e2)
			{
				throw new global::System.Exception("CRL number extension could not be extracted from CRL.", e2);
			}
			byte[] idp = null;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Object obj = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(completeCRL, global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint);
				if (obj != null)
				{
					idp = obj.GetDerEncoded();
				}
			}
			catch (global::System.Exception e3)
			{
				throw new global::System.Exception("Issuing distribution point extension value could not be read.", e3);
			}
			deltaSelect.MinCrlNumber = ((completeCRLNumber == null) ? null : completeCRLNumber.Add(global::Org.BouncyCastle.Math.BigInteger.One));
			deltaSelect.IssuingDistributionPoint = idp;
			deltaSelect.IssuingDistributionPointEnabled = true;
			deltaSelect.MaxBaseCrlNumber = completeCRLNumber;
			global::System.Collections.IEnumerable enumerable = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.CrlUtilities.FindCrls(deltaSelect, paramsPKIX, currentDate);
			global::Org.BouncyCastle.Utilities.Collections.ISet result = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj2 in enumerable)
			{
				global::Org.BouncyCastle.X509.X509Crl crl = (global::Org.BouncyCastle.X509.X509Crl)obj2;
				if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.isDeltaCrl(crl))
				{
					result.Add(crl);
				}
			}
			return result;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000395D4 File Offset: 0x000377D4
		private static bool isDeltaCrl(global::Org.BouncyCastle.X509.X509Crl crl)
		{
			return crl.GetCriticalExtensionOids().Contains(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator.Id);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000395EC File Offset: 0x000377EC
		internal static global::System.Collections.ICollection FindCertificates(global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector certSelect, global::System.Collections.IList certStores)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet certs = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in certStores)
			{
				global::Org.BouncyCastle.X509.Store.IX509Store certStore = (global::Org.BouncyCastle.X509.Store.IX509Store)obj;
				try
				{
					foreach (object obj2 in certStore.GetMatches(certSelect))
					{
						global::Org.BouncyCastle.X509.X509V2AttributeCertificate ac = (global::Org.BouncyCastle.X509.X509V2AttributeCertificate)obj2;
						certs.Add(ac);
					}
				}
				catch (global::System.Exception e)
				{
					throw new global::System.Exception("Problem while picking certificates from X.509 store.", e);
				}
			}
			return certs;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000396B0 File Offset: 0x000378B0
		internal static void AddAdditionalStoresFromCrlDistributionPoint(global::Org.BouncyCastle.Asn1.X509.CrlDistPoint crldp, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			if (crldp != null)
			{
				global::Org.BouncyCastle.Asn1.X509.DistributionPoint[] dps = null;
				try
				{
					dps = crldp.GetDistributionPoints();
				}
				catch (global::System.Exception e)
				{
					throw new global::System.Exception("Distribution points could not be read.", e);
				}
				for (int i = 0; i < dps.Length; i++)
				{
					global::Org.BouncyCastle.Asn1.X509.DistributionPointName dpn = dps[i].DistributionPointName;
					if (dpn != null && dpn.PointType == 0)
					{
						global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(dpn.Name).GetNames();
						for (int j = 0; j < genNames.Length; j++)
						{
							if (genNames[j].TagNo == 6)
							{
								global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoreFromLocation(global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(genNames[j].Name).GetString(), pkixParams);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0003975C File Offset: 0x0003795C
		internal static bool ProcessCertD1i(int index, global::System.Collections.IList[] policyNodes, global::Org.BouncyCastle.Asn1.DerObjectIdentifier pOid, global::Org.BouncyCastle.Utilities.Collections.ISet pq)
		{
			global::System.Collections.IList policyNodeVec = policyNodes[index - 1];
			for (int i = 0; i < policyNodeVec.Count; i++)
			{
				global::Org.BouncyCastle.Pkix.PkixPolicyNode node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)policyNodeVec[i];
				if (node.ExpectedPolicies.Contains(pOid.Id))
				{
					global::Org.BouncyCastle.Utilities.Collections.ISet childExpectedPolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
					childExpectedPolicies.Add(pOid.Id);
					global::Org.BouncyCastle.Pkix.PkixPolicyNode child = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), index, childExpectedPolicies, node, pq, pOid.Id, false);
					node.AddChild(child);
					policyNodes[index].Add(child);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000397E0 File Offset: 0x000379E0
		internal static void ProcessCertD1ii(int index, global::System.Collections.IList[] policyNodes, global::Org.BouncyCastle.Asn1.DerObjectIdentifier _poid, global::Org.BouncyCastle.Utilities.Collections.ISet _pq)
		{
			global::System.Collections.IList policyNodeVec = policyNodes[index - 1];
			for (int i = 0; i < policyNodeVec.Count; i++)
			{
				global::Org.BouncyCastle.Pkix.PkixPolicyNode _node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)policyNodeVec[i];
				if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ANY_POLICY.Equals(_node.ValidPolicy))
				{
					global::Org.BouncyCastle.Utilities.Collections.ISet _childExpectedPolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
					_childExpectedPolicies.Add(_poid.Id);
					global::Org.BouncyCastle.Pkix.PkixPolicyNode _child = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), index, _childExpectedPolicies, _node, _pq, _poid.Id, false);
					_node.AddChild(_child);
					policyNodes[index].Add(_child);
					return;
				}
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00039860 File Offset: 0x00037A60
		internal static global::System.Collections.ICollection FindIssuerCerts(global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixParams)
		{
			global::Org.BouncyCastle.X509.Store.X509CertStoreSelector certSelect = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
			global::Org.BouncyCastle.Utilities.Collections.ISet certs = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			try
			{
				certSelect.Subject = cert.IssuerDN;
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::System.Exception("Subject criteria for certificate selector to find issuer certificate could not be set.", ex);
			}
			try
			{
				certs.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(certSelect, pkixParams.GetStores()));
				certs.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(certSelect, pkixParams.GetAdditionalStores()));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("Issuer certificate cannot be searched.", e);
			}
			return certs;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000398E8 File Offset: 0x00037AE8
		internal static global::Org.BouncyCastle.Asn1.Asn1Object GetExtensionValue(global::Org.BouncyCastle.X509.IX509Extension ext, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString bytes = ext.GetExtensionValue(oid);
			if (bytes == null)
			{
				return null;
			}
			return global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(bytes);
		}

		// Token: 0x0400085D RID: 2141
		private static readonly global::Org.BouncyCastle.Pkix.PkixCrlUtilities CrlUtilities = new global::Org.BouncyCastle.Pkix.PkixCrlUtilities();

		// Token: 0x0400085E RID: 2142
		internal static readonly string ANY_POLICY = "2.5.29.32.0";

		// Token: 0x0400085F RID: 2143
		internal static readonly string CRL_NUMBER = global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlNumber.Id;

		// Token: 0x04000860 RID: 2144
		internal static readonly int KEY_CERT_SIGN = 5;

		// Token: 0x04000861 RID: 2145
		internal static readonly int CRL_SIGN = 6;

		// Token: 0x04000862 RID: 2146
		internal static readonly string[] crlReasons = new string[]
		{
			"unspecified",
			"keyCompromise",
			"cACompromise",
			"affiliationChanged",
			"superseded",
			"cessationOfOperation",
			"certificateHold",
			"unknown",
			"removeFromCRL",
			"privilegeWithdrawn",
			"aACompromise"
		};
	}
}
