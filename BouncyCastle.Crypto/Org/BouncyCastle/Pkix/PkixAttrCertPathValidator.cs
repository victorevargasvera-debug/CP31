using System;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000195 RID: 405
	public class PkixAttrCertPathValidator
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x000373FC File Offset: 0x000355FC
		public virtual global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult Validate(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::Org.BouncyCastle.X509.Store.IX509Selector targetConstraints = pkixParams.GetTargetConstraints();
			if (!(targetConstraints is global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector))
			{
				throw new global::System.ArgumentException("TargetConstraints must be an instance of " + typeof(global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector).FullName, "pkixParams");
			}
			global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert = ((global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector)targetConstraints).AttributeCert;
			global::Org.BouncyCastle.Pkix.PkixCertPath holderCertPath = global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.ProcessAttrCert1(attrCert, pkixParams);
			global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult result = global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.ProcessAttrCert2(certPath, pkixParams);
			global::Org.BouncyCastle.X509.X509Certificate issuerCert = (global::Org.BouncyCastle.X509.X509Certificate)certPath.Certificates[0];
			global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.ProcessAttrCert3(issuerCert, pkixParams);
			global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.ProcessAttrCert4(issuerCert, pkixParams);
			global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.ProcessAttrCert5(attrCert, pkixParams);
			global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.ProcessAttrCert7(attrCert, certPath, holderCertPath, pkixParams);
			global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.AdditionalChecks(attrCert, pkixParams);
			global::System.DateTime date;
			try
			{
				date = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetValidCertDateFromValidityModel(pkixParams, null, -1);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Could not get validity date from attribute certificate.", e);
			}
			global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.CheckCrls(attrCert, pkixParams, issuerCert, date, certPath.Certificates);
			return result;
		}
	}
}
