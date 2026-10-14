using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000194 RID: 404
	public class PkixAttrCertPathBuilder
	{
		// Token: 0x06000EF6 RID: 3830 RVA: 0x0003702C File Offset: 0x0003522C
		public virtual global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult Build(global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixParams)
		{
			global::Org.BouncyCastle.X509.Store.IX509Selector certSelect = pkixParams.GetTargetConstraints();
			if (!(certSelect is global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException(string.Concat(new string[]
				{
					"TargetConstraints must be an instance of ",
					typeof(global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector).FullName,
					" for ",
					typeof(global::Org.BouncyCastle.Pkix.PkixAttrCertPathBuilder).FullName,
					" class."
				}));
			}
			global::System.Collections.ICollection targets;
			try
			{
				targets = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates((global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector)certSelect, pkixParams.GetStores());
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Error finding target attribute certificate.", e);
			}
			if (targets.Count == 0)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("No attribute certificate found matching targetConstraints.");
			}
			global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult result = null;
			foreach (object obj in targets)
			{
				global::Org.BouncyCastle.X509.IX509AttributeCertificate cert = (global::Org.BouncyCastle.X509.IX509AttributeCertificate)obj;
				global::Org.BouncyCastle.X509.Store.X509CertStoreSelector selector = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
				global::Org.BouncyCastle.Asn1.X509.X509Name[] principals = cert.Issuer.GetPrincipals();
				global::Org.BouncyCastle.Utilities.Collections.ISet issuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				for (int i = 0; i < principals.Length; i++)
				{
					try
					{
						selector.Subject = principals[i];
						issuers.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(selector, pkixParams.GetStores()));
					}
					catch (global::System.Exception e2)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Public key certificate for attribute certificate cannot be searched.", e2);
					}
				}
				if (issuers.IsEmpty)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Public key certificate for attribute certificate cannot be found.");
				}
				global::System.Collections.IList certPathList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				foreach (object obj2 in issuers)
				{
					global::Org.BouncyCastle.X509.X509Certificate issuer = (global::Org.BouncyCastle.X509.X509Certificate)obj2;
					result = this.Build(cert, issuer, pkixParams, certPathList);
					if (result != null)
					{
						break;
					}
				}
				if (result != null)
				{
					break;
				}
			}
			if (result == null && this.certPathException != null)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Possible certificate chain could not be validated.", this.certPathException);
			}
			if (result == null && this.certPathException == null)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Unable to find certificate chain.");
			}
			return result;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00037240 File Offset: 0x00035440
		private global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult Build(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.X509.X509Certificate tbvCert, global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixParams, global::System.Collections.IList tbvPath)
		{
			if (tbvPath.Contains(tbvCert))
			{
				return null;
			}
			if (pkixParams.GetExcludedCerts().Contains(tbvCert))
			{
				return null;
			}
			if (pkixParams.MaxPathLength != -1 && tbvPath.Count - 1 > pkixParams.MaxPathLength)
			{
				return null;
			}
			tbvPath.Add(tbvCert);
			global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult builderResult = null;
			global::Org.BouncyCastle.Pkix.PkixAttrCertPathValidator validator = new global::Org.BouncyCastle.Pkix.PkixAttrCertPathValidator();
			try
			{
				if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsIssuerTrustAnchor(tbvCert, pkixParams.GetTrustAnchors()))
				{
					global::Org.BouncyCastle.Pkix.PkixCertPath certPath = new global::Org.BouncyCastle.Pkix.PkixCertPath(tbvPath);
					global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult result;
					try
					{
						result = validator.Validate(certPath, pkixParams);
					}
					catch (global::System.Exception e)
					{
						throw new global::System.Exception("Certification path could not be validated.", e);
					}
					return new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult(certPath, result.TrustAnchor, result.PolicyTree, result.SubjectPublicKey);
				}
				try
				{
					global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoresFromAltNames(tbvCert, pkixParams);
				}
				catch (global::Org.BouncyCastle.Security.Certificates.CertificateParsingException e2)
				{
					throw new global::System.Exception("No additional X.509 stores can be added from certificate locations.", e2);
				}
				global::Org.BouncyCastle.Utilities.Collections.ISet issuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				try
				{
					issuers.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindIssuerCerts(tbvCert, pkixParams));
				}
				catch (global::System.Exception e3)
				{
					throw new global::System.Exception("Cannot find issuer certificate for certificate in certification path.", e3);
				}
				if (issuers.IsEmpty)
				{
					throw new global::System.Exception("No issuer certificate for certificate in certification path found.");
				}
				foreach (object obj in issuers)
				{
					global::Org.BouncyCastle.X509.X509Certificate issuer = (global::Org.BouncyCastle.X509.X509Certificate)obj;
					if (!global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsSelfIssued(issuer))
					{
						builderResult = this.Build(attrCert, issuer, pkixParams, tbvPath);
						if (builderResult != null)
						{
							break;
						}
					}
				}
			}
			catch (global::System.Exception e4)
			{
				this.certPathException = new global::System.Exception("No valid certification path could be build.", e4);
			}
			if (builderResult == null)
			{
				tbvPath.Remove(tbvCert);
			}
			return builderResult;
		}

		// Token: 0x04000850 RID: 2128
		private global::System.Exception certPathException;
	}
}
