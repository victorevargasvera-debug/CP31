using System;
using System.Collections;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000198 RID: 408
	public class PkixCertPathBuilder
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x00037C6C File Offset: 0x00035E6C
		public virtual global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult Build(global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixParams)
		{
			global::Org.BouncyCastle.X509.Store.IX509Selector certSelect = pkixParams.GetTargetCertConstraints();
			if (!(certSelect is global::Org.BouncyCastle.X509.Store.X509CertStoreSelector))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException(string.Concat(new string[]
				{
					"TargetConstraints must be an instance of ",
					typeof(global::Org.BouncyCastle.X509.Store.X509CertStoreSelector).FullName,
					" for ",
					global::Org.BouncyCastle.Utilities.Platform.GetTypeName(this),
					" class."
				}));
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet targets = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			try
			{
				targets.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates((global::Org.BouncyCastle.X509.Store.X509CertStoreSelector)certSelect, pkixParams.GetStores()));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Error finding target certificate.", e);
			}
			if (targets.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("No certificate found matching targetConstraints.");
			}
			global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult result = null;
			global::System.Collections.IList certPathList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in targets)
			{
				global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)obj;
				result = this.Build(cert, pkixParams, certPathList);
				if (result != null)
				{
					break;
				}
			}
			if (result == null && this.certPathException != null)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException(this.certPathException.Message, this.certPathException.InnerException);
			}
			if (result == null && this.certPathException == null)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException("Unable to find certificate chain.");
			}
			return result;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00037DB8 File Offset: 0x00035FB8
		protected virtual global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult Build(global::Org.BouncyCastle.X509.X509Certificate tbvCert, global::Org.BouncyCastle.Pkix.PkixBuilderParameters pkixParams, global::System.Collections.IList tbvPath)
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
			global::Org.BouncyCastle.Pkix.PkixCertPathValidator validator = new global::Org.BouncyCastle.Pkix.PkixCertPathValidator();
			try
			{
				if (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.IsIssuerTrustAnchor(tbvCert, pkixParams.GetTrustAnchors()))
				{
					global::Org.BouncyCastle.Pkix.PkixCertPath certPath = null;
					try
					{
						certPath = new global::Org.BouncyCastle.Pkix.PkixCertPath(tbvPath);
					}
					catch (global::System.Exception e)
					{
						throw new global::System.Exception("Certification path could not be constructed from certificate list.", e);
					}
					global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult result = null;
					try
					{
						result = validator.Validate(certPath, pkixParams);
					}
					catch (global::System.Exception e2)
					{
						throw new global::System.Exception("Certification path could not be validated.", e2);
					}
					return new global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult(certPath, result.TrustAnchor, result.PolicyTree, result.SubjectPublicKey);
				}
				try
				{
					global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoresFromAltNames(tbvCert, pkixParams);
				}
				catch (global::Org.BouncyCastle.Security.Certificates.CertificateParsingException e3)
				{
					throw new global::System.Exception("No additiontal X.509 stores can be added from certificate locations.", e3);
				}
				global::Org.BouncyCastle.Utilities.Collections.HashSet issuers = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				try
				{
					issuers.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindIssuerCerts(tbvCert, pkixParams));
				}
				catch (global::System.Exception e4)
				{
					throw new global::System.Exception("Cannot find issuer certificate for certificate in certification path.", e4);
				}
				if (issuers.IsEmpty)
				{
					throw new global::System.Exception("No issuer certificate for certificate in certification path found.");
				}
				foreach (object obj in issuers)
				{
					global::Org.BouncyCastle.X509.X509Certificate issuer = (global::Org.BouncyCastle.X509.X509Certificate)obj;
					builderResult = this.Build(issuer, pkixParams, tbvPath);
					if (builderResult != null)
					{
						break;
					}
				}
			}
			catch (global::System.Exception e5)
			{
				this.certPathException = e5;
			}
			if (builderResult == null)
			{
				tbvPath.Remove(tbvCert);
			}
			return builderResult;
		}

		// Token: 0x04000855 RID: 2133
		private global::System.Exception certPathException;
	}
}
