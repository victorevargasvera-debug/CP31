using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x0200019C RID: 412
	public class PkixCertPathValidator
	{
		// Token: 0x06000F20 RID: 3872 RVA: 0x0003805C File Offset: 0x0003625C
		public virtual global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult Validate(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixParameters paramsPkix)
		{
			if (paramsPkix.GetTrustAnchors() == null)
			{
				throw new global::System.ArgumentException("trustAnchors is null, this is not allowed for certification path validation.", "parameters");
			}
			global::System.Collections.IList certs = certPath.Certificates;
			int i = certs.Count;
			if (certs.Count == 0)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Certification path is empty.", null, certPath, 0);
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet userInitialPolicySet = paramsPkix.GetInitialPolicies();
			global::Org.BouncyCastle.Pkix.TrustAnchor trust;
			try
			{
				trust = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindTrustAnchor((global::Org.BouncyCastle.X509.X509Certificate)certs[certs.Count - 1], paramsPkix.GetTrustAnchors());
				if (trust == null)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Trust anchor for certification path not found.", null, certPath, -1);
				}
				global::Org.BouncyCastle.Pkix.PkixCertPathValidator.CheckCertificate(trust.TrustedCert);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException(e.Message, e.InnerException, certPath, certs.Count - 1);
			}
			int index = 0;
			global::System.Collections.IList[] policyNodes = new global::System.Collections.IList[i + 1];
			for (int j = 0; j < policyNodes.Length; j++)
			{
				policyNodes[j] = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet policySet = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			policySet.Add(global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY);
			global::Org.BouncyCastle.Pkix.PkixPolicyNode validPolicyTree = new global::Org.BouncyCastle.Pkix.PkixPolicyNode(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), 0, policySet, null, new global::Org.BouncyCastle.Utilities.Collections.HashSet(), global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ANY_POLICY, false);
			policyNodes[0].Add(validPolicyTree);
			global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator nameConstraintValidator = new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator();
			global::Org.BouncyCastle.Utilities.Collections.ISet acceptablePolicies = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			int explicitPolicy;
			if (paramsPkix.IsExplicitPolicyRequired)
			{
				explicitPolicy = 0;
			}
			else
			{
				explicitPolicy = i + 1;
			}
			int inhibitAnyPolicy;
			if (paramsPkix.IsAnyPolicyInhibited)
			{
				inhibitAnyPolicy = 0;
			}
			else
			{
				inhibitAnyPolicy = i + 1;
			}
			int policyMapping;
			if (paramsPkix.IsPolicyMappingInhibited)
			{
				policyMapping = 0;
			}
			else
			{
				policyMapping = i + 1;
			}
			global::Org.BouncyCastle.X509.X509Certificate sign = trust.TrustedCert;
			global::Org.BouncyCastle.Asn1.X509.X509Name workingIssuerName;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter workingPublicKey;
			try
			{
				if (sign != null)
				{
					workingIssuerName = sign.SubjectDN;
					workingPublicKey = sign.GetPublicKey();
				}
				else
				{
					workingIssuerName = new global::Org.BouncyCastle.Asn1.X509.X509Name(trust.CAName);
					workingPublicKey = trust.CAPublicKey;
				}
			}
			catch (global::System.ArgumentException ex)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Subject of trust anchor could not be (re)encoded.", ex, certPath, -1);
			}
			try
			{
				global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetAlgorithmIdentifier(workingPublicKey);
			}
			catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException e2)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Algorithm identifier of public key of trust anchor could not be read.", e2, certPath, -1);
			}
			int maxPathLength = i;
			global::Org.BouncyCastle.X509.Store.X509CertStoreSelector certConstraints = paramsPkix.GetTargetCertConstraints();
			if (certConstraints != null && !certConstraints.Match((global::Org.BouncyCastle.X509.X509Certificate)certs[0]))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Target certificate in certification path does not match targetConstraints.", null, certPath, 0);
			}
			global::System.Collections.IList pathCheckers = paramsPkix.GetCertPathCheckers();
			foreach (object obj in pathCheckers)
			{
				((global::Org.BouncyCastle.Pkix.PkixCertPathChecker)obj).Init(false);
			}
			global::Org.BouncyCastle.X509.X509Certificate cert = null;
			for (index = certs.Count - 1; index >= 0; index--)
			{
				int k = i - index;
				cert = (global::Org.BouncyCastle.X509.X509Certificate)certs[index];
				try
				{
					global::Org.BouncyCastle.Pkix.PkixCertPathValidator.CheckCertificate(cert);
				}
				catch (global::System.Exception e3)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException(e3.Message, e3.InnerException, certPath, index);
				}
				global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCertA(certPath, paramsPkix, index, workingPublicKey, workingIssuerName, sign);
				global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCertBC(certPath, index, nameConstraintValidator);
				validPolicyTree = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCertD(certPath, index, acceptablePolicies, validPolicyTree, policyNodes, inhibitAnyPolicy);
				validPolicyTree = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCertE(certPath, index, validPolicyTree);
				global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCertF(certPath, index, validPolicyTree, explicitPolicy);
				if (k != i)
				{
					if (cert != null && cert.Version == 1)
					{
						if (k != 1 || !cert.Equals(trust.TrustedCert))
						{
							throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Version 1 certificates can't be used as CA ones.", null, certPath, index);
						}
					}
					else
					{
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertA(certPath, index);
						validPolicyTree = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareCertB(certPath, index, policyNodes, validPolicyTree, policyMapping);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertG(certPath, index, nameConstraintValidator);
						explicitPolicy = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertH1(certPath, index, explicitPolicy);
						policyMapping = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertH2(certPath, index, policyMapping);
						inhibitAnyPolicy = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertH3(certPath, index, inhibitAnyPolicy);
						explicitPolicy = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertI1(certPath, index, explicitPolicy);
						policyMapping = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertI2(certPath, index, policyMapping);
						inhibitAnyPolicy = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertJ(certPath, index, inhibitAnyPolicy);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertK(certPath, index);
						maxPathLength = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertL(certPath, index, maxPathLength);
						maxPathLength = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertM(certPath, index, maxPathLength);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertN(certPath, index);
						global::Org.BouncyCastle.Utilities.Collections.ISet criticalExtensions = cert.GetCriticalExtensionOids();
						if (criticalExtensions != null)
						{
							criticalExtensions = new global::Org.BouncyCastle.Utilities.Collections.HashSet(criticalExtensions);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyMappings.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.InhibitAnyPolicy.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyConstraints.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName.Id);
							criticalExtensions.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.NameConstraints.Id);
						}
						else
						{
							criticalExtensions = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
						}
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.PrepareNextCertO(certPath, index, criticalExtensions, pathCheckers);
						sign = cert;
						workingIssuerName = sign.SubjectDN;
						try
						{
							workingPublicKey = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetNextWorkingKey(certPath.Certificates, index);
						}
						catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException e4)
						{
							throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Next working key could not be retrieved.", e4, certPath, index);
						}
						global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetAlgorithmIdentifier(workingPublicKey);
					}
				}
			}
			explicitPolicy = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.WrapupCertA(explicitPolicy, cert);
			explicitPolicy = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.WrapupCertB(certPath, index + 1, explicitPolicy);
			global::Org.BouncyCastle.Utilities.Collections.ISet criticalExtensions2 = cert.GetCriticalExtensionOids();
			if (criticalExtensions2 != null)
			{
				criticalExtensions2 = new global::Org.BouncyCastle.Utilities.Collections.HashSet(criticalExtensions2);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyMappings.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.InhibitAnyPolicy.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.PolicyConstraints.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.NameConstraints.Id);
				criticalExtensions2.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints.Id);
			}
			else
			{
				criticalExtensions2 = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			}
			global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.WrapupCertF(certPath, index + 1, pathCheckers, criticalExtensions2);
			global::Org.BouncyCastle.Pkix.PkixPolicyNode intersection = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.WrapupCertG(certPath, paramsPkix, userInitialPolicySet, index + 1, policyNodes, validPolicyTree, acceptablePolicies);
			if (explicitPolicy > 0 || intersection != null)
			{
				return new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult(trust, intersection, cert.GetPublicKey());
			}
			throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Path processing failed on policy.", null, certPath, index);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0003866C File Offset: 0x0003686C
		internal static void CheckCertificate(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			try
			{
				global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(cert.CertificateStructure.TbsCertificate);
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e)
			{
				throw new global::System.Exception("unable to process TBSCertificate", e);
			}
		}
	}
}
