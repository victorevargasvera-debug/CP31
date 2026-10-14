using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A6 RID: 422
	public class Rfc3280CertPathUtilities
	{
		// Token: 0x06000FE3 RID: 4067 RVA: 0x0003CC30 File Offset: 0x0003AE30
		internal static void ProcessCrlB2(global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp, object cert, global::Org.BouncyCastle.X509.X509Crl crl)
		{
			global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint idp = null;
			try
			{
				idp = global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(crl, global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("0 Issuing distribution point extension could not be decoded.", e);
			}
			if (idp != null)
			{
				if (idp.DistributionPoint != null)
				{
					global::Org.BouncyCastle.Asn1.X509.DistributionPointName dpName = global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(idp).DistributionPoint;
					global::System.Collections.IList names = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
					if (dpName.PointType == 0)
					{
						global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(dpName.Name).GetNames();
						for (int i = 0; i < genNames.Length; i++)
						{
							names.Add(genNames[i]);
						}
					}
					if (dpName.PointType == 1)
					{
						global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
						try
						{
							foreach (object obj in global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(crl.IssuerDN.GetEncoded())))
							{
								vec.Add((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj);
							}
						}
						catch (global::System.IO.IOException e3)
						{
							throw new global::System.Exception("Could not read CRL issuer.", e3);
						}
						vec.Add(dpName.Name);
						names.Add(new global::Org.BouncyCastle.Asn1.X509.GeneralName(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(vec))));
					}
					bool matches = false;
					if (dp.DistributionPointName != null)
					{
						dpName = dp.DistributionPointName;
						global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames2 = null;
						if (dpName.PointType == 0)
						{
							genNames2 = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(dpName.Name).GetNames();
						}
						if (dpName.PointType == 1)
						{
							if (dp.CrlIssuer != null)
							{
								genNames2 = dp.CrlIssuer.GetNames();
							}
							else
							{
								genNames2 = new global::Org.BouncyCastle.Asn1.X509.GeneralName[1];
								try
								{
									genNames2[0] = new global::Org.BouncyCastle.Asn1.X509.GeneralName(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert));
								}
								catch (global::System.IO.IOException e4)
								{
									throw new global::System.Exception("Could not read certificate issuer.", e4);
								}
							}
							for (int j = 0; j < genNames2.Length; j++)
							{
								global::System.Collections.IEnumerator e5 = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(genNames2[j].Name.ToAsn1Object()).GetEnumerator();
								global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec2 = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
								while (e5.MoveNext())
								{
									object obj2 = e5.Current;
									vec2.Add((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2);
								}
								vec2.Add(dpName.Name);
								genNames2[j] = new global::Org.BouncyCastle.Asn1.X509.GeneralName(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(vec2)));
							}
						}
						if (genNames2 != null)
						{
							for (int k = 0; k < genNames2.Length; k++)
							{
								if (names.Contains(genNames2[k]))
								{
									matches = true;
									break;
								}
							}
						}
						if (!matches)
						{
							throw new global::System.Exception("No match for certificate CRL issuing distribution point name to cRLIssuer CRL distribution point.");
						}
					}
					else
					{
						if (dp.CrlIssuer == null)
						{
							throw new global::System.Exception("Either the cRLIssuer or the distributionPoint field must be contained in DistributionPoint.");
						}
						global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames3 = dp.CrlIssuer.GetNames();
						for (int l = 0; l < genNames3.Length; l++)
						{
							if (names.Contains(genNames3[l]))
							{
								matches = true;
								break;
							}
						}
						if (!matches)
						{
							throw new global::System.Exception("No match for certificate CRL issuing distribution point name to cRLIssuer CRL distribution point.");
						}
					}
				}
				global::Org.BouncyCastle.Asn1.X509.BasicConstraints bc = null;
				try
				{
					bc = global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue((global::Org.BouncyCastle.X509.IX509Extension)cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints));
				}
				catch (global::System.Exception e6)
				{
					throw new global::System.Exception("Basic constraints extension could not be decoded.", e6);
				}
				if (idp.OnlyContainsUserCerts && bc != null && bc.IsCA())
				{
					throw new global::System.Exception("CA Cert CRL only contains user certificates.");
				}
				if (idp.OnlyContainsCACerts && (bc == null || !bc.IsCA()))
				{
					throw new global::System.Exception("End CRL only contains CA certificates.");
				}
				if (idp.OnlyContainsAttributeCerts)
				{
					throw new global::System.Exception("onlyContainsAttributeCerts boolean is asserted.");
				}
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0003CF6C File Offset: 0x0003B16C
		internal static void ProcessCertBC(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator nameConstraintValidator)
		{
			global::System.Collections.IList certificates = certPath.Certificates;
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certificates[index];
			int i = certificates.Count;
			int j = i - index;
			if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued(cert) || j >= i)
			{
				global::Org.BouncyCastle.Asn1.X509.X509Name principal = cert.SubjectDN;
				global::Org.BouncyCastle.Asn1.Asn1Sequence dns;
				try
				{
					dns = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(principal.GetEncoded());
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Exception extracting subject name when checking subtrees.", e, certPath, index);
				}
				try
				{
					nameConstraintValidator.CheckPermittedDN(dns);
					nameConstraintValidator.CheckExcludedDN(dns);
				}
				catch (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException e2)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subtree check for certificate subject failed.", e2, certPath, index);
				}
				global::Org.BouncyCastle.Asn1.X509.GeneralNames altName = null;
				try
				{
					altName = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName));
				}
				catch (global::System.Exception e3)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subject alternative name extension could not be decoded.", e3, certPath, index);
				}
				foreach (object obj in global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(dns).GetValueList(global::Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress))
				{
					string email = (string)obj;
					global::Org.BouncyCastle.Asn1.X509.GeneralName emailAsGeneralName = new global::Org.BouncyCastle.Asn1.X509.GeneralName(1, email);
					try
					{
						nameConstraintValidator.checkPermitted(emailAsGeneralName);
						nameConstraintValidator.checkExcluded(emailAsGeneralName);
					}
					catch (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException ex)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subtree check for certificate subject alternative email failed.", ex, certPath, index);
					}
				}
				if (altName != null)
				{
					global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames = null;
					try
					{
						genNames = altName.GetNames();
					}
					catch (global::System.Exception e4)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subject alternative name contents could not be decoded.", e4, certPath, index);
					}
					foreach (global::Org.BouncyCastle.Asn1.X509.GeneralName genName in genNames)
					{
						try
						{
							nameConstraintValidator.checkPermitted(genName);
							nameConstraintValidator.checkExcluded(genName);
						}
						catch (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException e5)
						{
							throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subtree check for certificate subject alternative name failed.", e5, certPath, index);
						}
					}
				}
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0003D14C File Offset: 0x0003B34C
		internal static void PrepareNextCertA(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.Asn1Sequence pm = null;
			try
			{
				pm = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyMappings));
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy mappings extension could not be decoded.", ex, certPath, index);
			}
			if (pm != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence mappings = pm;
				for (int i = 0; i < mappings.Count; i++)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier issuerDomainPolicy = null;
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier subjectDomainPolicy = null;
					try
					{
						global::Org.BouncyCastle.Asn1.Asn1Sequence instance = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(mappings[i]);
						issuerDomainPolicy = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(instance[0]);
						subjectDomainPolicy = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(instance[1]);
					}
					catch (global::System.Exception e)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy mappings extension contents could not be decoded.", e, certPath, index);
					}
					if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(issuerDomainPolicy.Id))
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("IssuerDomainPolicy is anyPolicy", null, certPath, index);
					}
					if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(subjectDomainPolicy.Id))
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("SubjectDomainPolicy is anyPolicy,", null, certPath, index);
					}
				}
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0003D254 File Offset: 0x0003B454
		internal static global::Org.BouncyCastle.Pkix.PkixPolicyNode ProcessCertD(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::Org.BouncyCastle.Utilities.Collections.ISet acceptablePolicies, global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree, global::System.Collections.IList[] policyNodes, int inhibitAnyPolicy)
		{
			global::System.Collections.IList certificates = certPath.Certificates;
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certificates[index];
			int i = certificates.Count;
			int j = i - index;
			global::Org.BouncyCastle.Asn1.Asn1Sequence certPolicies = null;
			try
			{
				certPolicies = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not read certificate policies extension from certificate.", e, certPath, index);
			}
			if (certPolicies != null && validPolicyTree != null)
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet pols = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in certPolicies)
				{
					global::Org.BouncyCastle.Asn1.X509.PolicyInformation pInfo = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier pOid = pInfo.PolicyIdentifier;
					pols.Add(pOid.Id);
					if (!global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(pOid.Id))
					{
						global::Org.BouncyCastle.Utilities.Collections.ISet pq = null;
						try
						{
							pq = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetQualifierSet(pInfo.PolicyQualifiers);
						}
						catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException ex)
						{
							throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy qualifier info set could not be build.", ex, certPath, index);
						}
						if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ProcessCertD1i(j, policyNodes, pOid, pq))
						{
							global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.ProcessCertD1ii(j, policyNodes, pOid, pq);
						}
					}
				}
				if (acceptablePolicies.IsEmpty || acceptablePolicies.Contains(global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY))
				{
					acceptablePolicies.Clear();
					acceptablePolicies.AddAll(pols);
				}
				else
				{
					global::Org.BouncyCastle.Utilities.Collections.ISet t = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
					foreach (object o in acceptablePolicies)
					{
						if (pols.Contains(o))
						{
							t.Add(o);
						}
					}
					acceptablePolicies.Clear();
					acceptablePolicies.AddAll(t);
				}
				if (inhibitAnyPolicy > 0 || (j < i && global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued(cert)))
				{
					foreach (object obj2 in certPolicies)
					{
						global::Org.BouncyCastle.Asn1.X509.PolicyInformation pInfo2 = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2).ToAsn1Object());
						if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(pInfo2.PolicyIdentifier.Id))
						{
							global::Org.BouncyCastle.Utilities.Collections.ISet _apq = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetQualifierSet(pInfo2.PolicyQualifiers);
							global::System.Collections.IList _nodes = policyNodes[j - 1];
							for (int k = 0; k < _nodes.Count; k++)
							{
								global::Org.BouncyCastle.Pkix.PkixPolicyNode _node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)_nodes[k];
								foreach (object _tmp in _node.ExpectedPolicies)
								{
									string _policy;
									if (_tmp is string)
									{
										_policy = (string)_tmp;
									}
									else
									{
										if (!(_tmp is global::Org.BouncyCastle.Asn1.DerObjectIdentifier))
										{
											continue;
										}
										_policy = ((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)_tmp).Id;
									}
									bool _found = false;
									foreach (object obj3 in _node.Children)
									{
										global::Org.BouncyCastle.Pkix.PkixPolicyNode _child = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj3;
										if (_policy.Equals(_child.ValidPolicy))
										{
											_found = true;
										}
									}
									if (!_found)
									{
										global::Org.BouncyCastle.Utilities.Collections.ISet _newChildExpectedPolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
										_newChildExpectedPolicies.Add(_policy);
										global::Org.BouncyCastle.Pkix.PkixPolicyNode _newChild = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), j, _newChildExpectedPolicies, _node, _apq, _policy, false);
										_node.AddChild(_newChild);
										policyNodes[j].Add(_newChild);
									}
								}
							}
							break;
						}
					}
				}
				global::Org.BouncyCastle.Pkix.PkixPolicyNode _validPolicyTree = validPolicyTree;
				for (int l = j - 1; l >= 0; l--)
				{
					global::System.Collections.IList nodes = policyNodes[l];
					for (int m = 0; m < nodes.Count; m++)
					{
						global::Org.BouncyCastle.Pkix.PkixPolicyNode node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)nodes[m];
						if (!node.HasChildren)
						{
							_validPolicyTree = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNode(_validPolicyTree, policyNodes, node);
							if (_validPolicyTree == null)
							{
								break;
							}
						}
					}
				}
				global::Org.BouncyCastle.Utilities.Collections.ISet criticalExtensionOids = cert.GetCriticalExtensionOids();
				if (criticalExtensionOids != null)
				{
					bool critical = criticalExtensionOids.Contains(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies.Id);
					global::System.Collections.IList nodes2 = policyNodes[j];
					for (int n = 0; n < nodes2.Count; n++)
					{
						((global::Org.BouncyCastle.Pkix.PkixPolicyNode)nodes2[n]).IsCritical = critical;
					}
				}
				return _validPolicyTree;
			}
			return null;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		internal static void ProcessCrlB1(global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp, object cert, global::Org.BouncyCastle.X509.X509Crl crl)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object idp = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(crl, global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint);
			bool isIndirect = false;
			if (idp != null && global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(idp).IsIndirectCrl)
			{
				isIndirect = true;
			}
			byte[] issuerBytes = crl.IssuerDN.GetEncoded();
			bool matchIssuer = false;
			if (dp.CrlIssuer != null)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralName[] genNames = dp.CrlIssuer.GetNames();
				for (int i = 0; i < genNames.Length; i++)
				{
					if (genNames[i].TagNo == 4)
					{
						try
						{
							if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(genNames[i].Name.ToAsn1Object().GetEncoded(), issuerBytes))
							{
								matchIssuer = true;
							}
						}
						catch (global::System.IO.IOException e)
						{
							throw new global::System.Exception("CRL issuer information from distribution point cannot be decoded.", e);
						}
					}
				}
				if (matchIssuer && !isIndirect)
				{
					throw new global::System.Exception("Distribution point contains cRLIssuer field but CRL is not indirect.");
				}
				if (!matchIssuer)
				{
					throw new global::System.Exception("CRL issuer of CRL does not match CRL issuer of distribution point.");
				}
			}
			else if (crl.IssuerDN.Equivalent(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert), true))
			{
				matchIssuer = true;
			}
			if (!matchIssuer)
			{
				throw new global::System.Exception("Cannot find matching CRL issuer for certificate.");
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
		internal static global::Org.BouncyCastle.Pkix.ReasonsMask ProcessCrlD(global::Org.BouncyCastle.X509.X509Crl crl, global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp)
		{
			global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint idp = null;
			try
			{
				idp = global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(crl, global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("issuing distribution point extension could not be decoded.", e);
			}
			if (idp != null && idp.OnlySomeReasons != null && dp.Reasons != null)
			{
				return new global::Org.BouncyCastle.Pkix.ReasonsMask(dp.Reasons.IntValue).Intersect(new global::Org.BouncyCastle.Pkix.ReasonsMask(idp.OnlySomeReasons.IntValue));
			}
			if ((idp == null || idp.OnlySomeReasons == null) && dp.Reasons == null)
			{
				return global::Org.BouncyCastle.Pkix.ReasonsMask.AllReasons;
			}
			global::Org.BouncyCastle.Pkix.ReasonsMask dpReasons;
			if (dp.Reasons == null)
			{
				dpReasons = global::Org.BouncyCastle.Pkix.ReasonsMask.AllReasons;
			}
			else
			{
				dpReasons = new global::Org.BouncyCastle.Pkix.ReasonsMask(dp.Reasons.IntValue);
			}
			global::Org.BouncyCastle.Pkix.ReasonsMask idpReasons;
			if (idp == null)
			{
				idpReasons = global::Org.BouncyCastle.Pkix.ReasonsMask.AllReasons;
			}
			else
			{
				idpReasons = new global::Org.BouncyCastle.Pkix.ReasonsMask(idp.OnlySomeReasons.IntValue);
			}
			return dpReasons.Intersect(idpReasons);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0003D8A4 File Offset: 0x0003BAA4
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet ProcessCrlF(global::Org.BouncyCastle.X509.X509Crl crl, object cert, global::Org.BouncyCastle.X509.X509Certificate defaultCRLSignCert, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter defaultCRLSignKey, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::System.Collections.IList certPathCerts)
		{
			global::Org.BouncyCastle.X509.Store.X509CertStoreSelector selector = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
			try
			{
				selector.Subject = crl.IssuerDN;
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.Exception("Subject criteria for certificate selector to find issuer certificate for CRL could not be set.", e);
			}
			global::System.Collections.IList coll = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			try
			{
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(coll, global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(selector, paramsPKIX.GetStores()));
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(coll, global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(selector, paramsPKIX.GetAdditionalStores()));
			}
			catch (global::System.Exception e2)
			{
				throw new global::System.Exception("Issuer certificate for CRL cannot be searched.", e2);
			}
			coll.Add(defaultCRLSignCert);
			global::System.Collections.IEnumerator cert_it = coll.GetEnumerator();
			global::System.Collections.IList validCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::System.Collections.IList validKeys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (cert_it.MoveNext())
			{
				object obj = cert_it.Current;
				global::Org.BouncyCastle.X509.X509Certificate signingCert = (global::Org.BouncyCastle.X509.X509Certificate)obj;
				if (signingCert.Equals(defaultCRLSignCert))
				{
					validCerts.Add(signingCert);
					validKeys.Add(defaultCRLSignKey);
				}
				else
				{
					try
					{
						global::Org.BouncyCastle.Pkix.PkixCertPathBuilder pkixCertPathBuilder = new global::Org.BouncyCastle.Pkix.PkixCertPathBuilder();
						selector = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
						selector.Certificate = signingCert;
						global::Org.BouncyCastle.Pkix.PkixParameters pkixParameters = (global::Org.BouncyCastle.Pkix.PkixParameters)paramsPKIX.Clone();
						pkixParameters.SetTargetCertConstraints(selector);
						global::Org.BouncyCastle.Pkix.PkixBuilderParameters parameters = global::Org.BouncyCastle.Pkix.PkixBuilderParameters.GetInstance(pkixParameters);
						if (certPathCerts.Contains(signingCert))
						{
							parameters.IsRevocationEnabled = false;
						}
						else
						{
							parameters.IsRevocationEnabled = true;
						}
						global::System.Collections.IList certs = pkixCertPathBuilder.Build(parameters).CertPath.Certificates;
						validCerts.Add(signingCert);
						validKeys.Add(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetNextWorkingKey(certs, 0));
					}
					catch (global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException e3)
					{
						throw new global::System.Exception("CertPath for CRL signer failed to validate.", e3);
					}
					catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException e4)
					{
						throw new global::System.Exception("Public key of issuer certificate of CRL could not be retrieved.", e4);
					}
				}
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet checkKeys = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			global::System.Exception lastException = null;
			for (int i = 0; i < validCerts.Count; i++)
			{
				bool[] keyusage = ((global::Org.BouncyCastle.X509.X509Certificate)validCerts[i]).GetKeyUsage();
				if (keyusage != null && (keyusage.Length < 7 || !keyusage[global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CRL_SIGN]))
				{
					lastException = new global::System.Exception("Issuer certificate key usage extension does not permit CRL signing.");
				}
				else
				{
					checkKeys.Add(validKeys[i]);
				}
			}
			if (checkKeys.Count == 0 && lastException == null)
			{
				throw new global::System.Exception("Cannot find a valid issuer certificate.");
			}
			if (checkKeys.Count == 0 && lastException != null)
			{
				throw lastException;
			}
			return checkKeys;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0003DAC8 File Offset: 0x0003BCC8
		internal static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter ProcessCrlG(global::Org.BouncyCastle.X509.X509Crl crl, global::Org.BouncyCastle.Utilities.Collections.ISet keys)
		{
			global::System.Exception lastException = null;
			foreach (object obj in keys)
			{
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)obj;
				try
				{
					crl.Verify(key);
					return key;
				}
				catch (global::System.Exception lastException)
				{
				}
			}
			throw new global::System.Exception("Cannot verify CRL.", lastException);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0003DB44 File Offset: 0x0003BD44
		internal static global::Org.BouncyCastle.X509.X509Crl ProcessCrlH(global::Org.BouncyCastle.Utilities.Collections.ISet deltaCrls, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			global::System.Exception lastException = null;
			foreach (object obj in deltaCrls)
			{
				global::Org.BouncyCastle.X509.X509Crl crl = (global::Org.BouncyCastle.X509.X509Crl)obj;
				try
				{
					crl.Verify(key);
					return crl;
				}
				catch (global::System.Exception lastException)
				{
				}
			}
			if (lastException != null)
			{
				throw new global::System.Exception("Cannot verify delta CRL.", lastException);
			}
			return null;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
		private static void CheckCrl(global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.X509.X509Certificate cert, global::System.DateTime validDate, global::Org.BouncyCastle.X509.X509Certificate defaultCRLSignCert, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter defaultCRLSignKey, global::Org.BouncyCastle.Pkix.CertStatus certStatus, global::Org.BouncyCastle.Pkix.ReasonsMask reasonMask, global::System.Collections.IList certPathCerts)
		{
			global::System.DateTime currentDate = global::System.DateTime.UtcNow;
			if (validDate.Ticks > currentDate.Ticks)
			{
				throw new global::System.Exception("Validation time is in future.");
			}
			global::System.Collections.IEnumerable completeCrls = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetCompleteCrls(dp, cert, currentDate, paramsPKIX);
			bool validCrlFound = false;
			global::System.Exception lastException = null;
			global::System.Collections.IEnumerator crl_iter = completeCrls.GetEnumerator();
			while (crl_iter.MoveNext() && certStatus.Status == 11 && !reasonMask.IsAllReasons)
			{
				try
				{
					global::Org.BouncyCastle.X509.X509Crl crl = (global::Org.BouncyCastle.X509.X509Crl)crl_iter.Current;
					global::Org.BouncyCastle.Pkix.ReasonsMask interimReasonsMask = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlD(crl, dp);
					if (interimReasonsMask.HasNewReasons(reasonMask))
					{
						global::Org.BouncyCastle.Utilities.Collections.ISet keys = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlF(crl, cert, defaultCRLSignCert, defaultCRLSignKey, paramsPKIX, certPathCerts);
						global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlG(crl, keys);
						global::Org.BouncyCastle.X509.X509Crl deltaCRL = null;
						if (paramsPKIX.IsUseDeltasEnabled)
						{
							deltaCRL = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlH(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl), key);
						}
						if (paramsPKIX.ValidityModel != 1 && cert.NotAfter.Ticks < crl.ThisUpdate.Ticks)
						{
							throw new global::System.Exception("No valid CRL for current time found.");
						}
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlB1(dp, cert, crl);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlB2(dp, cert, crl);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlC(deltaCRL, crl, paramsPKIX);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlI(validDate, deltaCRL, cert, certStatus, paramsPKIX);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlJ(validDate, crl, cert, certStatus);
						if (certStatus.Status == 8)
						{
							certStatus.Status = 11;
						}
						reasonMask.AddReasons(interimReasonsMask);
						global::Org.BouncyCastle.Utilities.Collections.ISet criticalExtensions = crl.GetCriticalExtensionOids();
						if (criticalExtensions != null)
						{
							criticalExtensions = new global::Org.BouncyCastle.Utilities.Collections.HashSet(criticalExtensions);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator.Id);
							if (!criticalExtensions.IsEmpty)
							{
								throw new global::System.Exception("CRL contains unsupported critical extensions.");
							}
						}
						if (deltaCRL != null)
						{
							criticalExtensions = deltaCRL.GetCriticalExtensionOids();
							if (criticalExtensions != null)
							{
								criticalExtensions = new global::Org.BouncyCastle.Utilities.Collections.HashSet(criticalExtensions);
								criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint.Id);
								criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator.Id);
								if (!criticalExtensions.IsEmpty)
								{
									throw new global::System.Exception("Delta CRL contains unsupported critical extension.");
								}
							}
						}
						validCrlFound = true;
					}
				}
				catch (global::System.Exception lastException)
				{
				}
			}
			if (!validCrlFound)
			{
				throw lastException;
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0003DDD4 File Offset: 0x0003BFD4
		protected static void CheckCrls(global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.X509.X509Certificate cert, global::System.DateTime validDate, global::Org.BouncyCastle.X509.X509Certificate sign, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter workingPublicKey, global::System.Collections.IList certPathCerts)
		{
			global::System.Exception lastException = null;
			global::Org.BouncyCastle.Asn1.X509.CrlDistPoint crldp = null;
			try
			{
				crldp = global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("CRL distribution point extension could not be read.", e);
			}
			try
			{
				global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoresFromCrlDistributionPoint(crldp, paramsPKIX);
			}
			catch (global::System.Exception e2)
			{
				throw new global::System.Exception("No additional CRL locations could be decoded from CRL distribution point extension.", e2);
			}
			global::Org.BouncyCastle.Pkix.CertStatus certStatus = new global::Org.BouncyCastle.Pkix.CertStatus();
			global::Org.BouncyCastle.Pkix.ReasonsMask reasonsMask = new global::Org.BouncyCastle.Pkix.ReasonsMask();
			bool validCrlFound = false;
			if (crldp != null)
			{
				global::Org.BouncyCastle.Asn1.X509.DistributionPoint[] dps = null;
				try
				{
					dps = crldp.GetDistributionPoints();
				}
				catch (global::System.Exception e3)
				{
					throw new global::System.Exception("Distribution points could not be read.", e3);
				}
				if (dps != null)
				{
					int i = 0;
					while (i < dps.Length && certStatus.Status == 11 && !reasonsMask.IsAllReasons)
					{
						global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIXClone = (global::Org.BouncyCastle.Pkix.PkixParameters)paramsPKIX.Clone();
						try
						{
							global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CheckCrl(dps[i], paramsPKIXClone, cert, validDate, sign, workingPublicKey, certStatus, reasonsMask, certPathCerts);
							validCrlFound = true;
						}
						catch (global::System.Exception lastException)
						{
						}
						i++;
					}
				}
			}
			if (certStatus.Status == 11 && !reasonsMask.IsAllReasons)
			{
				try
				{
					global::Org.BouncyCastle.Asn1.X509.X509Name issuer;
					try
					{
						issuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(cert.IssuerDN.GetEncoded());
					}
					catch (global::System.Exception e4)
					{
						throw new global::System.Exception("Issuer from certificate for CRL could not be reencoded.", e4);
					}
					global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp = new global::Org.BouncyCastle.Asn1.X509.DistributionPoint(new global::Org.BouncyCastle.Asn1.X509.DistributionPointName(0, new global::Org.BouncyCastle.Asn1.X509.GeneralNames(new global::Org.BouncyCastle.Asn1.X509.GeneralName(4, issuer))), null, null);
					global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIXClone2 = (global::Org.BouncyCastle.Pkix.PkixParameters)paramsPKIX.Clone();
					global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CheckCrl(dp, paramsPKIXClone2, cert, validDate, sign, workingPublicKey, certStatus, reasonsMask, certPathCerts);
					validCrlFound = true;
				}
				catch (global::System.Exception lastException)
				{
				}
			}
			if (!validCrlFound)
			{
				throw lastException;
			}
			if (certStatus.Status != 11)
			{
				string formattedDate = certStatus.RevocationDate.Value.ToString("ddd MMM dd HH:mm:ss K yyyy");
				throw new global::System.Exception("Certificate revocation after " + formattedDate + ", reason: " + global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CrlReasons[certStatus.Status]);
			}
			if (!reasonsMask.IsAllReasons && certStatus.Status == 11)
			{
				certStatus.Status = 12;
			}
			if (certStatus.Status == 12)
			{
				throw new global::System.Exception("Certificate status could not be determined.");
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0003DFE4 File Offset: 0x0003C1E4
		internal static global::Org.BouncyCastle.Pkix.PkixPolicyNode PrepareCertB(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::System.Collections.IList[] policyNodes, global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree, int policyMapping)
		{
			global::System.Collections.IList certificates = certPath.Certificates;
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certificates[index];
			int i = certificates.Count - index;
			global::Org.BouncyCastle.Asn1.Asn1Sequence pm = null;
			try
			{
				pm = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyMappings));
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy mappings extension could not be decoded.", ex, certPath, index);
			}
			global::Org.BouncyCastle.Pkix.PkixPolicyNode _validPolicyTree = validPolicyTree;
			if (pm != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence mappings = pm;
				global::System.Collections.IDictionary m_idp = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
				global::Org.BouncyCastle.Utilities.Collections.ISet s_idp = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				for (int j = 0; j < mappings.Count; j++)
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence asn1Sequence = (global::Org.BouncyCastle.Asn1.Asn1Sequence)mappings[j];
					string id_p = ((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)asn1Sequence[0]).Id;
					string sd_p = ((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)asn1Sequence[1]).Id;
					if (!m_idp.Contains(id_p))
					{
						m_idp[id_p] = new global::Org.BouncyCastle.Utilities.Collections.HashSet
						{
							sd_p
						};
						s_idp.Add(id_p);
					}
					else
					{
						global::Org.BouncyCastle.Utilities.Collections.ISet tmp = (global::Org.BouncyCastle.Utilities.Collections.ISet)m_idp[id_p];
						tmp.Add(sd_p);
					}
				}
				foreach (object obj in s_idp)
				{
					string id_p2 = (string)obj;
					if (policyMapping > 0)
					{
						bool idp_found = false;
						foreach (object obj2 in policyNodes[i])
						{
							global::Org.BouncyCastle.Pkix.PkixPolicyNode node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj2;
							if (node.ValidPolicy.Equals(id_p2))
							{
								idp_found = true;
								node.ExpectedPolicies = (global::Org.BouncyCastle.Utilities.Collections.ISet)m_idp[id_p2];
								break;
							}
						}
						if (!idp_found)
						{
							foreach (object obj3 in policyNodes[i])
							{
								global::Org.BouncyCastle.Pkix.PkixPolicyNode node2 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj3;
								if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(node2.ValidPolicy))
								{
									global::Org.BouncyCastle.Utilities.Collections.ISet pq = null;
									global::Org.BouncyCastle.Asn1.Asn1Sequence policies = null;
									try
									{
										policies = (global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies);
									}
									catch (global::System.Exception e)
									{
										throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Certificate policies extension could not be decoded.", e, certPath, index);
									}
									foreach (object obj4 in policies)
									{
										global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj4;
										global::Org.BouncyCastle.Asn1.X509.PolicyInformation pinfo = null;
										try
										{
											pinfo = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(ae.ToAsn1Object());
										}
										catch (global::System.Exception ex2)
										{
											throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy information could not be decoded.", ex2, certPath, index);
										}
										if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(pinfo.PolicyIdentifier.Id))
										{
											try
											{
												pq = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetQualifierSet(pinfo.PolicyQualifiers);
												break;
											}
											catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException ex3)
											{
												throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy qualifier info set could not be decoded.", ex3, certPath, index);
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
									if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(p_node.ValidPolicy))
									{
										global::Org.BouncyCastle.Pkix.PkixPolicyNode c_node = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), i, (global::Org.BouncyCastle.Utilities.Collections.ISet)m_idp[id_p2], p_node, pq, id_p2, ci);
										p_node.AddChild(c_node);
										policyNodes[i].Add(c_node);
										break;
									}
									break;
								}
							}
						}
					}
					else if (policyMapping <= 0)
					{
						foreach (object obj5 in global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(policyNodes[i]))
						{
							global::Org.BouncyCastle.Pkix.PkixPolicyNode node3 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj5;
							if (node3.ValidPolicy.Equals(id_p2))
							{
								node3.Parent.RemoveChild(node3);
								for (int k = i - 1; k >= 0; k--)
								{
									foreach (object obj6 in global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(policyNodes[k]))
									{
										global::Org.BouncyCastle.Pkix.PkixPolicyNode node4 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj6;
										if (!node4.HasChildren)
										{
											_validPolicyTree = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNode(_validPolicyTree, policyNodes, node4);
											if (_validPolicyTree == null)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return _validPolicyTree;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0003E41C File Offset: 0x0003C61C
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet[] ProcessCrlA1ii(global::System.DateTime currentDate, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.X509.X509Crl crl)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet deltaSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector crlselect = new global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector();
			crlselect.CertificateChecking = cert;
			try
			{
				global::System.Collections.IList issuer = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				issuer.Add(crl.IssuerDN);
				crlselect.Issuers = issuer;
			}
			catch (global::System.IO.IOException e)
			{
				string str = "Cannot extract issuer from CRL.";
				global::System.IO.IOException ex = e;
				throw new global::System.Exception(str + ((ex != null) ? ex.ToString() : null), e);
			}
			crlselect.CompleteCrlEnabled = true;
			global::Org.BouncyCastle.Utilities.Collections.ISet completeSet = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CrlUtilities.FindCrls(crlselect, paramsPKIX, currentDate);
			if (paramsPKIX.IsUseDeltasEnabled)
			{
				try
				{
					deltaSet.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl));
				}
				catch (global::System.Exception e2)
				{
					throw new global::System.Exception("Exception obtaining delta CRLs.", e2);
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.ISet[]
			{
				completeSet,
				deltaSet
			};
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0003E4E0 File Offset: 0x0003C6E0
		internal static global::Org.BouncyCastle.Utilities.Collections.ISet ProcessCrlA1i(global::System.DateTime currentDate, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.X509.X509Crl crl)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet deltaSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			if (paramsPKIX.IsUseDeltasEnabled)
			{
				global::Org.BouncyCastle.Asn1.X509.CrlDistPoint freshestCRL = null;
				try
				{
					freshestCRL = global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.FreshestCrl));
				}
				catch (global::System.Exception e)
				{
					throw new global::System.Exception("Freshest CRL extension could not be decoded from certificate.", e);
				}
				if (freshestCRL == null)
				{
					try
					{
						freshestCRL = global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(crl, global::Org.BouncyCastle.Asn1.X509.X509Extensions.FreshestCrl));
					}
					catch (global::System.Exception e2)
					{
						throw new global::System.Exception("Freshest CRL extension could not be decoded from CRL.", e2);
					}
				}
				if (freshestCRL != null)
				{
					try
					{
						global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoresFromCrlDistributionPoint(freshestCRL, paramsPKIX);
					}
					catch (global::System.Exception e3)
					{
						throw new global::System.Exception("No new delta CRL locations could be added from Freshest CRL extension.", e3);
					}
					try
					{
						deltaSet.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl));
					}
					catch (global::System.Exception e4)
					{
						throw new global::System.Exception("Exception obtaining delta CRLs.", e4);
					}
				}
			}
			return deltaSet;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0003E5B4 File Offset: 0x0003C7B4
		internal static void ProcessCertF(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree, int explicitPolicy)
		{
			if (explicitPolicy <= 0 && validPolicyTree == null)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("No valid policy tree found when one expected.", null, certPath, index);
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0003E5CC File Offset: 0x0003C7CC
		internal static void ProcessCertA(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, int index, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter workingPublicKey, global::Org.BouncyCastle.Asn1.X509.X509Name workingIssuerName, global::Org.BouncyCastle.X509.X509Certificate sign)
		{
			global::System.Collections.IList certs = certPath.Certificates;
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certs[index];
			try
			{
				cert.Verify(workingPublicKey);
			}
			catch (global::Org.BouncyCastle.Security.GeneralSecurityException e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not validate certificate signature.", e, certPath, index);
			}
			try
			{
				cert.CheckValidity(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetValidCertDateFromValidityModel(paramsPKIX, certPath, index));
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateExpiredException e2)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not validate certificate: " + e2.Message, e2, certPath, index);
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateNotYetValidException e3)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not validate certificate: " + e3.Message, e3, certPath, index);
			}
			catch (global::System.Exception e4)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not validate time of certificate.", e4, certPath, index);
			}
			if (paramsPKIX.IsRevocationEnabled)
			{
				try
				{
					global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CheckCrls(paramsPKIX, cert, global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetValidCertDateFromValidityModel(paramsPKIX, certPath, index), sign, workingPublicKey, certs);
				}
				catch (global::System.Exception e5)
				{
					global::System.Exception cause = e5.InnerException;
					if (cause == null)
					{
						cause = e5;
					}
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException(e5.Message, cause, certPath, index);
				}
			}
			global::Org.BouncyCastle.Asn1.X509.X509Name issuer = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetIssuerPrincipal(cert);
			if (!issuer.Equivalent(workingIssuerName, true))
			{
				string[] array = new string[5];
				array[0] = "IssuerName(";
				int num = 1;
				global::Org.BouncyCastle.Asn1.X509.X509Name x509Name = issuer;
				array[num] = ((x509Name != null) ? x509Name.ToString() : null);
				array[2] = ") does not match SubjectName(";
				array[3] = ((workingIssuerName != null) ? workingIssuerName.ToString() : null);
				array[4] = ") of signing certificate.";
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException(string.Concat(array), null, certPath, index);
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0003E744 File Offset: 0x0003C944
		internal static int PrepareNextCertI1(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int explicitPolicy)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.Asn1Sequence pc = null;
			try
			{
				pc = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyConstraints));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy constraints extension cannot be decoded.", e, certPath, index);
			}
			if (pc != null)
			{
				global::System.Collections.IEnumerator policyConstraints = pc.GetEnumerator();
				while (policyConstraints.MoveNext())
				{
					try
					{
						global::Org.BouncyCastle.Asn1.Asn1TaggedObject constraint = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(policyConstraints.Current);
						if (constraint.TagNo == 0)
						{
							int tmpInt = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(constraint, false).IntValueExact;
							if (tmpInt < explicitPolicy)
							{
								return tmpInt;
							}
							break;
						}
					}
					catch (global::System.ArgumentException e2)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy constraints extension contents cannot be decoded.", e2, certPath, index);
					}
				}
			}
			return explicitPolicy;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0003E804 File Offset: 0x0003CA04
		internal static int PrepareNextCertI2(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int policyMapping)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.Asn1Sequence pc = null;
			try
			{
				pc = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyConstraints));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy constraints extension cannot be decoded.", e, certPath, index);
			}
			if (pc != null)
			{
				global::System.Collections.IEnumerator policyConstraints = pc.GetEnumerator();
				while (policyConstraints.MoveNext())
				{
					try
					{
						global::Org.BouncyCastle.Asn1.Asn1TaggedObject constraint = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(policyConstraints.Current);
						if (constraint.TagNo == 1)
						{
							int tmpInt = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(constraint, false).IntValueExact;
							if (tmpInt < policyMapping)
							{
								return tmpInt;
							}
							break;
						}
					}
					catch (global::System.ArgumentException e2)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy constraints extension contents cannot be decoded.", e2, certPath, index);
					}
				}
			}
			return policyMapping;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		internal static void PrepareNextCertG(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator nameConstraintValidator)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.X509.NameConstraints nc = null;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence ncSeq = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.NameConstraints));
				if (ncSeq != null)
				{
					nc = new global::Org.BouncyCastle.Asn1.X509.NameConstraints(ncSeq);
				}
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Name constraints extension could not be decoded.", e, certPath, index);
			}
			if (nc != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence permitted = nc.PermittedSubtrees;
				if (permitted != null)
				{
					try
					{
						nameConstraintValidator.IntersectPermittedSubtree(permitted);
					}
					catch (global::System.Exception ex)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Permitted subtrees cannot be build from name constraints extension.", ex, certPath, index);
					}
				}
				global::Org.BouncyCastle.Asn1.Asn1Sequence excluded = nc.ExcludedSubtrees;
				if (excluded != null)
				{
					global::System.Collections.IEnumerator e2 = excluded.GetEnumerator();
					try
					{
						while (e2.MoveNext())
						{
							object obj = e2.Current;
							global::Org.BouncyCastle.Asn1.X509.GeneralSubtree subtree = global::Org.BouncyCastle.Asn1.X509.GeneralSubtree.GetInstance(obj);
							nameConstraintValidator.AddExcludedSubtree(subtree);
						}
					}
					catch (global::System.Exception ex2)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Excluded subtrees cannot be build from name constraints extension.", ex2, certPath, index);
					}
				}
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0003E9AC File Offset: 0x0003CBAC
		internal static int PrepareNextCertJ(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int inhibitAnyPolicy)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.DerInteger iap = null;
			try
			{
				iap = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.InhibitAnyPolicy));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Inhibit any-policy extension cannot be decoded.", e, certPath, index);
			}
			if (iap != null)
			{
				int _inhibitAnyPolicy = iap.IntValueExact;
				if (_inhibitAnyPolicy < inhibitAnyPolicy)
				{
					return _inhibitAnyPolicy;
				}
			}
			return inhibitAnyPolicy;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0003EA10 File Offset: 0x0003CC10
		internal static void PrepareNextCertK(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.X509.BasicConstraints bc = null;
			try
			{
				bc = global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Basic constraints extension cannot be decoded.", e, certPath, index);
			}
			if (bc == null)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Intermediate certificate lacks BasicConstraints");
			}
			if (!bc.IsCA())
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Not a CA certificate");
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0003EA84 File Offset: 0x0003CC84
		internal static int PrepareNextCertL(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int maxPathLength)
		{
			if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index]))
			{
				return maxPathLength;
			}
			if (maxPathLength <= 0)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Max path length not greater than zero", null, certPath, index);
			}
			return maxPathLength - 1;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0003EAB8 File Offset: 0x0003CCB8
		internal static int PrepareNextCertM(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int maxPathLength)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.X509.BasicConstraints bc = null;
			try
			{
				bc = global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Basic constraints extension cannot be decoded.", e, certPath, index);
			}
			if (bc != null)
			{
				global::Org.BouncyCastle.Math.BigInteger _pathLengthConstraint = bc.PathLenConstraint;
				if (_pathLengthConstraint != null)
				{
					int _plc = _pathLengthConstraint.IntValue;
					if (_plc < maxPathLength)
					{
						return _plc;
					}
				}
			}
			return maxPathLength;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		internal static void PrepareNextCertN(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index)
		{
			bool[] _usage = ((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index]).GetKeyUsage();
			if (_usage != null && !_usage[global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.KEY_CERT_SIGN])
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Issuer certificate keyusage extension is critical and does not permit key signing.", null, certPath, index);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0003EB6C File Offset: 0x0003CD6C
		internal static void PrepareNextCertO(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::Org.BouncyCastle.Utilities.Collections.ISet criticalExtensions, global::System.Collections.IList pathCheckers)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::System.Collections.IEnumerator tmpIter = pathCheckers.GetEnumerator();
			while (tmpIter.MoveNext())
			{
				try
				{
					((global::Org.BouncyCastle.Pkix.PkixCertPathChecker)tmpIter.Current).Check(cert, criticalExtensions);
				}
				catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException e)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException(e.Message, e.InnerException, certPath, index);
				}
			}
			if (!criticalExtensions.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Certificate has unsupported critical extension.", null, certPath, index);
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0003EBEC File Offset: 0x0003CDEC
		internal static int PrepareNextCertH1(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int explicitPolicy)
		{
			if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index]) && explicitPolicy != 0)
			{
				return explicitPolicy - 1;
			}
			return explicitPolicy;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0003EC0E File Offset: 0x0003CE0E
		internal static int PrepareNextCertH2(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int policyMapping)
		{
			if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index]) && policyMapping != 0)
			{
				return policyMapping - 1;
			}
			return policyMapping;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0003EC30 File Offset: 0x0003CE30
		internal static int PrepareNextCertH3(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int inhibitAnyPolicy)
		{
			if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued((global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index]) && inhibitAnyPolicy != 0)
			{
				return inhibitAnyPolicy - 1;
			}
			return inhibitAnyPolicy;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0003EC52 File Offset: 0x0003CE52
		internal static int WrapupCertA(int explicitPolicy, global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued(cert) && explicitPolicy != 0)
			{
				explicitPolicy--;
			}
			return explicitPolicy;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0003EC68 File Offset: 0x0003CE68
		internal static int WrapupCertB(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, int explicitPolicy)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.Asn1Sequence pc = null;
			try
			{
				pc = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyConstraints));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy constraints could not be decoded.", e, certPath, index);
			}
			if (pc != null)
			{
				foreach (object obj in pc)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject constraint = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
					if (constraint.TagNo == 0)
					{
						int tmpInt;
						try
						{
							tmpInt = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(constraint, false).IntValueExact;
						}
						catch (global::System.Exception e2)
						{
							throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Policy constraints requireExplicitPolicy field could not be decoded.", e2, certPath, index);
						}
						if (tmpInt == 0)
						{
							return 0;
						}
					}
				}
			}
			return explicitPolicy;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0003ED1C File Offset: 0x0003CF1C
		internal static void WrapupCertF(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::System.Collections.IList pathCheckers, global::Org.BouncyCastle.Utilities.Collections.ISet criticalExtensions)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::System.Collections.IEnumerator tmpIter = pathCheckers.GetEnumerator();
			while (tmpIter.MoveNext())
			{
				try
				{
					((global::Org.BouncyCastle.Pkix.PkixCertPathChecker)tmpIter.Current).Check(cert, criticalExtensions);
				}
				catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException e)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Additional certificate path checker failed.", e, certPath, index);
				}
			}
			if (!criticalExtensions.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Certificate has unsupported critical extension", null, certPath, index);
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0003ED98 File Offset: 0x0003CF98
		internal static global::Org.BouncyCastle.Pkix.PkixPolicyNode WrapupCertG(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.Utilities.Collections.ISet userInitialPolicySet, int index, global::System.Collections.IList[] policyNodes, global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree, global::Org.BouncyCastle.Utilities.Collections.ISet acceptablePolicies)
		{
			int i = certPath.Certificates.Count;
			global::Org.BouncyCastle.Pkix.PkixPolicyNode intersection;
			if (validPolicyTree == null)
			{
				if (paramsPKIX.IsExplicitPolicyRequired)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Explicit policy requested but none available.", null, certPath, index);
				}
				intersection = null;
			}
			else if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsAnyPolicy(userInitialPolicySet))
			{
				if (paramsPKIX.IsExplicitPolicyRequired)
				{
					if (acceptablePolicies.IsEmpty)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Explicit policy requested but none available.", null, certPath, index);
					}
					global::Org.BouncyCastle.Utilities.Collections.ISet _validPolicyNodeSet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
					foreach (global::System.Collections.IList _nodeDepth in policyNodes)
					{
						for (int k = 0; k < _nodeDepth.Count; k++)
						{
							global::Org.BouncyCastle.Pkix.PkixPolicyNode _node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)_nodeDepth[k];
							if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(_node.ValidPolicy))
							{
								foreach (object o in _node.Children)
								{
									_validPolicyNodeSet.Add(o);
								}
							}
						}
					}
					foreach (object obj in _validPolicyNodeSet)
					{
						string _validPolicy = ((global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj).ValidPolicy;
						acceptablePolicies.Contains(_validPolicy);
					}
					if (validPolicyTree != null)
					{
						for (int l = i - 1; l >= 0; l--)
						{
							global::System.Collections.IList nodes = policyNodes[l];
							for (int m = 0; m < nodes.Count; m++)
							{
								global::Org.BouncyCastle.Pkix.PkixPolicyNode node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)nodes[m];
								if (!node.HasChildren)
								{
									validPolicyTree = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, node);
								}
							}
						}
					}
				}
				intersection = validPolicyTree;
			}
			else
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet _validPolicyNodeSet2 = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (global::System.Collections.IList _nodeDepth2 in policyNodes)
				{
					for (int k2 = 0; k2 < _nodeDepth2.Count; k2++)
					{
						global::Org.BouncyCastle.Pkix.PkixPolicyNode _node2 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)_nodeDepth2[k2];
						if (global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(_node2.ValidPolicy))
						{
							foreach (object obj2 in _node2.Children)
							{
								global::Org.BouncyCastle.Pkix.PkixPolicyNode _c_node = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj2;
								if (!global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY.Equals(_c_node.ValidPolicy))
								{
									_validPolicyNodeSet2.Add(_c_node);
								}
							}
						}
					}
				}
				foreach (object obj3 in _validPolicyNodeSet2)
				{
					global::Org.BouncyCastle.Pkix.PkixPolicyNode _node3 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)obj3;
					string _validPolicy2 = _node3.ValidPolicy;
					if (!userInitialPolicySet.Contains(_validPolicy2))
					{
						validPolicyTree = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, _node3);
					}
				}
				if (validPolicyTree != null)
				{
					for (int j2 = i - 1; j2 >= 0; j2--)
					{
						global::System.Collections.IList nodes2 = policyNodes[j2];
						for (int k3 = 0; k3 < nodes2.Count; k3++)
						{
							global::Org.BouncyCastle.Pkix.PkixPolicyNode node2 = (global::Org.BouncyCastle.Pkix.PkixPolicyNode)nodes2[k3];
							if (!node2.HasChildren)
							{
								validPolicyTree = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.RemovePolicyNode(validPolicyTree, policyNodes, node2);
							}
						}
					}
				}
				intersection = validPolicyTree;
			}
			return intersection;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0003F0CC File Offset: 0x0003D2CC
		internal static void ProcessCrlC(global::Org.BouncyCastle.X509.X509Crl deltaCRL, global::Org.BouncyCastle.X509.X509Crl completeCRL, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			if (deltaCRL == null)
			{
				return;
			}
			global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint completeidp = null;
			try
			{
				completeidp = global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(completeCRL, global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.Exception("000 Issuing distribution point extension could not be decoded.", e);
			}
			if (pkixParams.IsUseDeltasEnabled)
			{
				if (!deltaCRL.IssuerDN.Equivalent(completeCRL.IssuerDN, true))
				{
					throw new global::System.Exception("Complete CRL issuer does not match delta CRL issuer.");
				}
				global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint deltaidp = null;
				try
				{
					deltaidp = global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(deltaCRL, global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint));
				}
				catch (global::System.Exception e2)
				{
					throw new global::System.Exception("Issuing distribution point extension from delta CRL could not be decoded.", e2);
				}
				if (!object.Equals(completeidp, deltaidp))
				{
					throw new global::System.Exception("Issuing distribution point extension from delta CRL and complete CRL does not match.");
				}
				global::Org.BouncyCastle.Asn1.Asn1Object completeKeyIdentifier = null;
				try
				{
					completeKeyIdentifier = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(completeCRL, global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityKeyIdentifier);
				}
				catch (global::System.Exception e3)
				{
					throw new global::System.Exception("Authority key identifier extension could not be extracted from complete CRL.", e3);
				}
				global::Org.BouncyCastle.Asn1.Asn1Object deltaKeyIdentifier = null;
				try
				{
					deltaKeyIdentifier = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(deltaCRL, global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityKeyIdentifier);
				}
				catch (global::System.Exception e4)
				{
					throw new global::System.Exception("Authority key identifier extension could not be extracted from delta CRL.", e4);
				}
				if (completeKeyIdentifier == null)
				{
					throw new global::System.Exception("CRL authority key identifier is null.");
				}
				if (deltaKeyIdentifier == null)
				{
					throw new global::System.Exception("Delta CRL authority key identifier is null.");
				}
				if (!completeKeyIdentifier.Equals(deltaKeyIdentifier))
				{
					throw new global::System.Exception("Delta CRL authority key identifier does not match complete CRL authority key identifier.");
				}
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0003F208 File Offset: 0x0003D408
		internal static void ProcessCrlI(global::System.DateTime validDate, global::Org.BouncyCastle.X509.X509Crl deltacrl, object cert, global::Org.BouncyCastle.Pkix.CertStatus certStatus, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			if (pkixParams.IsUseDeltasEnabled && deltacrl != null)
			{
				global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetCertStatus(validDate, deltacrl, cert, certStatus);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0003F21F File Offset: 0x0003D41F
		internal static void ProcessCrlJ(global::System.DateTime validDate, global::Org.BouncyCastle.X509.X509Crl completecrl, object cert, global::Org.BouncyCastle.Pkix.CertStatus certStatus)
		{
			if (certStatus.Status == 11)
			{
				global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetCertStatus(validDate, completecrl, cert, certStatus);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0003F234 File Offset: 0x0003D434
		internal static global::Org.BouncyCastle.Pkix.PkixPolicyNode ProcessCertE(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, int index, global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree)
		{
			global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[index];
			global::Org.BouncyCastle.Asn1.Asn1Sequence certPolicies = null;
			try
			{
				certPolicies = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(cert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not read certificate policies extension from certificate.", e, certPath, index);
			}
			if (certPolicies == null)
			{
				validPolicyTree = null;
			}
			return validPolicyTree;
		}

		// Token: 0x0400088F RID: 2191
		private static readonly global::Org.BouncyCastle.Pkix.PkixCrlUtilities CrlUtilities = new global::Org.BouncyCastle.Pkix.PkixCrlUtilities();

		// Token: 0x04000890 RID: 2192
		internal static readonly string ANY_POLICY = "2.5.29.32.0";

		// Token: 0x04000891 RID: 2193
		internal static readonly int KEY_CERT_SIGN = 5;

		// Token: 0x04000892 RID: 2194
		internal static readonly int CRL_SIGN = 6;

		// Token: 0x04000893 RID: 2195
		internal static readonly string[] CrlReasons = new string[]
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
