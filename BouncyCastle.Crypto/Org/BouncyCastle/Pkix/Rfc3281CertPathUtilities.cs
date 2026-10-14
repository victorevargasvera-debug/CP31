using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A7 RID: 423
	internal class Rfc3281CertPathUtilities
	{
		// Token: 0x06001009 RID: 4105 RVA: 0x0003F32C File Offset: 0x0003D52C
		internal static void ProcessAttrCert7(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixCertPath holderCertPath, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet critExtOids = attrCert.GetCriticalExtensionOids();
			if (critExtOids.Contains(global::Org.BouncyCastle.Asn1.X509.X509Extensions.TargetInformation.Id))
			{
				try
				{
					global::Org.BouncyCastle.Asn1.X509.TargetInformation.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(attrCert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.TargetInformation));
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Target information extension could not be read.", e);
				}
			}
			critExtOids.Remove(global::Org.BouncyCastle.Asn1.X509.X509Extensions.TargetInformation.Id);
			foreach (object obj in pkixParams.GetAttrCertCheckers())
			{
				((global::Org.BouncyCastle.Pkix.PkixAttrCertChecker)obj).Check(attrCert, certPath, holderCertPath, critExtOids);
			}
			if (!critExtOids.IsEmpty)
			{
				string str = "Attribute certificate contains unsupported critical extensions: ";
				global::Org.BouncyCastle.Utilities.Collections.ISet set = critExtOids;
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException(str + ((set != null) ? set.ToString() : null));
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0003F400 File Offset: 0x0003D600
		internal static void CheckCrls(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::Org.BouncyCastle.X509.X509Certificate issuerCert, global::System.DateTime validDate, global::System.Collections.IList certPathCerts)
		{
			if (!paramsPKIX.IsRevocationEnabled)
			{
				return;
			}
			if (attrCert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.NoRevAvail) != null)
			{
				if (attrCert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints) != null || attrCert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityInfoAccess) != null)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("No rev avail extension is set, but also an AC revocation pointer.");
				}
				return;
			}
			else
			{
				global::Org.BouncyCastle.Asn1.X509.CrlDistPoint crldp = null;
				try
				{
					crldp = global::Org.BouncyCastle.Asn1.X509.CrlDistPoint.GetInstance(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetExtensionValue(attrCert, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlDistributionPoints));
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("CRL distribution point extension could not be read.", e);
				}
				try
				{
					global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.AddAdditionalStoresFromCrlDistributionPoint(crldp, paramsPKIX);
				}
				catch (global::System.Exception e2)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("No additional CRL locations could be decoded from CRL distribution point extension.", e2);
				}
				global::Org.BouncyCastle.Pkix.CertStatus certStatus = new global::Org.BouncyCastle.Pkix.CertStatus();
				global::Org.BouncyCastle.Pkix.ReasonsMask reasonsMask = new global::Org.BouncyCastle.Pkix.ReasonsMask();
				global::System.Exception lastException = null;
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
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Distribution points could not be read.", e3);
					}
					try
					{
						int i = 0;
						while (i < dps.Length && certStatus.Status == 11 && !reasonsMask.IsAllReasons)
						{
							global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIXClone = (global::Org.BouncyCastle.Pkix.PkixParameters)paramsPKIX.Clone();
							global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.CheckCrl(dps[i], attrCert, paramsPKIXClone, validDate, issuerCert, certStatus, reasonsMask, certPathCerts);
							validCrlFound = true;
							i++;
						}
					}
					catch (global::System.Exception e4)
					{
						lastException = new global::System.Exception("No valid CRL for distribution point found.", e4);
					}
				}
				if (certStatus.Status == 11 && !reasonsMask.IsAllReasons)
				{
					try
					{
						global::Org.BouncyCastle.Asn1.X509.X509Name issuer;
						try
						{
							issuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(attrCert.Issuer.GetPrincipals()[0].GetEncoded());
						}
						catch (global::System.Exception e5)
						{
							throw new global::System.Exception("Issuer from certificate for CRL could not be reencoded.", e5);
						}
						global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp = new global::Org.BouncyCastle.Asn1.X509.DistributionPoint(new global::Org.BouncyCastle.Asn1.X509.DistributionPointName(0, new global::Org.BouncyCastle.Asn1.X509.GeneralNames(new global::Org.BouncyCastle.Asn1.X509.GeneralName(4, issuer))), null, null);
						global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIXClone2 = (global::Org.BouncyCastle.Pkix.PkixParameters)paramsPKIX.Clone();
						global::Org.BouncyCastle.Pkix.Rfc3281CertPathUtilities.CheckCrl(dp, attrCert, paramsPKIXClone2, validDate, issuerCert, certStatus, reasonsMask, certPathCerts);
						validCrlFound = true;
					}
					catch (global::System.Exception e6)
					{
						lastException = new global::System.Exception("No valid CRL for distribution point found.", e6);
					}
				}
				if (!validCrlFound)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("No valid CRL found.", lastException);
				}
				if (certStatus.Status != 11)
				{
					string formattedDate = certStatus.RevocationDate.Value.ToString("ddd MMM dd HH:mm:ss K yyyy");
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate revocation after " + formattedDate + ", reason: " + global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.CrlReasons[certStatus.Status]);
				}
				if (!reasonsMask.IsAllReasons && certStatus.Status == 11)
				{
					certStatus.Status = 12;
				}
				if (certStatus.Status == 12)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate status could not be determined.");
				}
				return;
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0003F674 File Offset: 0x0003D874
		internal static void AdditionalChecks(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			foreach (object obj in pkixParams.GetProhibitedACAttributes())
			{
				string oid = (string)obj;
				if (attrCert.GetAttributes(oid) != null)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate contains prohibited attribute: " + oid + ".");
				}
			}
			foreach (object obj2 in pkixParams.GetNecessaryACAttributes())
			{
				string oid2 = (string)obj2;
				if (attrCert.GetAttributes(oid2) == null)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate does not contain necessary attribute: " + oid2 + ".");
				}
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0003F748 File Offset: 0x0003D948
		internal static void ProcessAttrCert5(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			try
			{
				attrCert.CheckValidity(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetValidDate(pkixParams));
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateExpiredException e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate is not valid.", e);
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateNotYetValidException e2)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate is not valid.", e2);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0003F79C File Offset: 0x0003D99C
		internal static void ProcessAttrCert4(global::Org.BouncyCastle.X509.X509Certificate acIssuerCert, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::System.Collections.IEnumerable trustedACIssuers = pkixParams.GetTrustedACIssuers();
			bool trusted = false;
			foreach (object obj in trustedACIssuers)
			{
				global::Org.BouncyCastle.Pkix.TrustAnchor anchor = (global::Org.BouncyCastle.Pkix.TrustAnchor)obj;
				global::System.Collections.IDictionary symbols = global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols;
				if (acIssuerCert.SubjectDN.ToString(false, symbols).Equals(anchor.CAName) || acIssuerCert.Equals(anchor.TrustedCert))
				{
					trusted = true;
				}
			}
			if (!trusted)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate issuer is not directly trusted.");
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0003F834 File Offset: 0x0003DA34
		internal static void ProcessAttrCert3(global::Org.BouncyCastle.X509.X509Certificate acIssuerCert, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			if (acIssuerCert.GetKeyUsage() != null && !acIssuerCert.GetKeyUsage()[0] && !acIssuerCert.GetKeyUsage()[1])
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate issuer public key cannot be used to validate digital signatures.");
			}
			if (acIssuerCert.GetBasicConstraints() != -1)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Attribute certificate issuer is also a public key certificate issuer.");
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0003F874 File Offset: 0x0003DA74
		internal static global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult ProcessAttrCert2(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::Org.BouncyCastle.Pkix.PkixCertPathValidator validator = new global::Org.BouncyCastle.Pkix.PkixCertPathValidator();
			global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult result;
			try
			{
				result = validator.Validate(certPath, pkixParams);
			}
			catch (global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException e)
			{
				throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Certification path for issuer certificate of attribute certificate could not be validated.", e);
			}
			return result;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
		internal static global::Org.BouncyCastle.Pkix.PkixCertPath ProcessAttrCert1(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixParameters pkixParams)
		{
			global::Org.BouncyCastle.Pkix.PkixCertPathBuilderResult result = null;
			global::Org.BouncyCastle.Utilities.Collections.ISet holderPKCs = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			if (attrCert.Holder.GetIssuer() != null)
			{
				global::Org.BouncyCastle.X509.Store.X509CertStoreSelector selector = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
				selector.SerialNumber = attrCert.Holder.SerialNumber;
				global::Org.BouncyCastle.Asn1.X509.X509Name[] principals = attrCert.Holder.GetIssuer();
				for (int i = 0; i < principals.Length; i++)
				{
					try
					{
						selector.Issuer = principals[i];
						holderPKCs.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(selector, pkixParams.GetStores()));
					}
					catch (global::System.Exception e)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Public key certificate for attribute certificate cannot be searched.", e);
					}
				}
				if (holderPKCs.IsEmpty)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Public key certificate specified in base certificate ID for attribute certificate cannot be found.");
				}
			}
			if (attrCert.Holder.GetEntityNames() != null)
			{
				global::Org.BouncyCastle.X509.Store.X509CertStoreSelector selector2 = new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector();
				global::Org.BouncyCastle.Asn1.X509.X509Name[] principals2 = attrCert.Holder.GetEntityNames();
				for (int j = 0; j < principals2.Length; j++)
				{
					try
					{
						selector2.Issuer = principals2[j];
						holderPKCs.AddAll(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.FindCertificates(selector2, pkixParams.GetStores()));
					}
					catch (global::System.Exception e2)
					{
						throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Public key certificate for attribute certificate cannot be searched.", e2);
					}
				}
				if (holderPKCs.IsEmpty)
				{
					throw new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Public key certificate specified in entity name for attribute certificate cannot be found.");
				}
			}
			global::Org.BouncyCastle.Pkix.PkixBuilderParameters parameters = global::Org.BouncyCastle.Pkix.PkixBuilderParameters.GetInstance(pkixParams);
			global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException lastException = null;
			foreach (object obj in holderPKCs)
			{
				global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)obj;
				parameters.SetTargetConstraints(new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector
				{
					Certificate = cert
				});
				global::Org.BouncyCastle.Pkix.PkixCertPathBuilder builder = new global::Org.BouncyCastle.Pkix.PkixCertPathBuilder();
				try
				{
					result = builder.Build(global::Org.BouncyCastle.Pkix.PkixBuilderParameters.GetInstance(parameters));
				}
				catch (global::Org.BouncyCastle.Pkix.PkixCertPathBuilderException e3)
				{
					lastException = new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorException("Certification path for public key certificate of attribute certificate could not be build.", e3);
				}
			}
			if (lastException != null)
			{
				throw lastException;
			}
			return result.CertPath;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0003FA88 File Offset: 0x0003DC88
		private static void CheckCrl(global::Org.BouncyCastle.Asn1.X509.DistributionPoint dp, global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixParameters paramsPKIX, global::System.DateTime validDate, global::Org.BouncyCastle.X509.X509Certificate issuerCert, global::Org.BouncyCastle.Pkix.CertStatus certStatus, global::Org.BouncyCastle.Pkix.ReasonsMask reasonMask, global::System.Collections.IList certPathCerts)
		{
			if (attrCert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.NoRevAvail) != null)
			{
				return;
			}
			global::System.DateTime currentDate = global::System.DateTime.UtcNow;
			if (validDate.CompareTo(currentDate) > 0)
			{
				throw new global::System.Exception("Validation time is in future.");
			}
			global::System.Collections.IEnumerable completeCrls = global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetCompleteCrls(dp, attrCert, currentDate, paramsPKIX);
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
						global::Org.BouncyCastle.Utilities.Collections.ISet keys = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlF(crl, attrCert, null, null, paramsPKIX, certPathCerts);
						global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlG(crl, keys);
						global::Org.BouncyCastle.X509.X509Crl deltaCRL = null;
						if (paramsPKIX.IsUseDeltasEnabled)
						{
							deltaCRL = global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlH(global::Org.BouncyCastle.Pkix.PkixCertPathValidatorUtilities.GetDeltaCrls(currentDate, paramsPKIX, crl), pubKey);
						}
						if (paramsPKIX.ValidityModel != 1 && attrCert.NotAfter.CompareTo(crl.ThisUpdate) < 0)
						{
							throw new global::System.Exception("No valid CRL for current time found.");
						}
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlB1(dp, attrCert, crl);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlB2(dp, attrCert, crl);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlC(deltaCRL, crl, paramsPKIX);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlI(validDate, deltaCRL, attrCert, certStatus, paramsPKIX);
						global::Org.BouncyCastle.Pkix.Rfc3280CertPathUtilities.ProcessCrlJ(validDate, crl, attrCert, certStatus);
						if (certStatus.Status == 8)
						{
							certStatus.Status = 11;
						}
						reasonMask.AddReasons(interimReasonsMask);
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
	}
}
