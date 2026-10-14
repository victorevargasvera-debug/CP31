using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using NPOI.OpenXml4Net.OPC;
using NPOI.POIFS.Crypt.Dsig.Facets;
using NPOI.POIFS.Crypt.Dsig.Services;

namespace NPOI.POIFS.Crypt.Dsig
{
	// Token: 0x020000FA RID: 250
	public class SignatureConfig
	{
		// Token: 0x06000F05 RID: 3845 RVA: 0x000359BC File Offset: 0x00033BBC
		protected internal void Init(bool onlyValidation)
		{
			if (this.opcPackage == null)
			{
				throw new global::NPOI.EncryptedDocumentException("opcPackage is null");
			}
			if (this.uriDereferencer == null)
			{
				this.uriDereferencer = new global::NPOI.POIFS.Crypt.Dsig.OOXMLURIDereferencer();
			}
			if (this.uriDereferencer is global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable)
			{
				((global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable)this.uriDereferencer).SetSignatureConfig(this);
			}
			if (this.namespacePrefixes.Count == 0)
			{
				this.namespacePrefixes.Add(global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet.OO_DIGSIG_NS, "mdssi");
				this.namespacePrefixes.Add(global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet.XADES_132_NS, "xd");
			}
			if (onlyValidation)
			{
				return;
			}
			if (this.signatureMarshalListener == null)
			{
				this.signatureMarshalListener = new global::NPOI.POIFS.Crypt.Dsig.SignatureMarshalListener();
			}
			if (this.signatureMarshalListener is global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable)
			{
				((global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable)this.signatureMarshalListener).SetSignatureConfig(this);
			}
			if (this.tspService != null)
			{
				this.tspService.SetSignatureConfig(this);
			}
			if (this.signatureFacets.Count == 0)
			{
				this.AddSignatureFacet(new global::NPOI.POIFS.Crypt.Dsig.Facets.OOXMLSignatureFacet());
				this.AddSignatureFacet(new global::NPOI.POIFS.Crypt.Dsig.Facets.KeyInfoSignatureFacet());
				this.AddSignatureFacet(new global::NPOI.POIFS.Crypt.Dsig.Facets.XAdESSignatureFacet());
				this.AddSignatureFacet(new global::NPOI.POIFS.Crypt.Dsig.Facets.Office2010SignatureFacet());
			}
			foreach (global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet signatureFacet in this.signatureFacets)
			{
				signatureFacet.SetSignatureConfig(this);
			}
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00035B0C File Offset: 0x00033D0C
		public void AddSignatureFacet(global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet signatureFacet)
		{
			this.signatureFacets.Add(signatureFacet);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00035B1A File Offset: 0x00033D1A
		public global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet> GetSignatureFacets()
		{
			return this.signatureFacets;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00035B22 File Offset: 0x00033D22
		public void SetSignatureFacets(global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet> signatureFacets)
		{
			this.signatureFacets = signatureFacets;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00035B2B File Offset: 0x00033D2B
		public global::NPOI.POIFS.Crypt.HashAlgorithm GetDigestAlgo()
		{
			return this.digestAlgo;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00035B33 File Offset: 0x00033D33
		public void SetDigestAlgo(global::NPOI.POIFS.Crypt.HashAlgorithm digestAlgo)
		{
			this.digestAlgo = digestAlgo;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00035B3C File Offset: 0x00033D3C
		public global::NPOI.OpenXml4Net.OPC.OPCPackage GetOpcPackage()
		{
			return this.opcPackage.Value;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00035B49 File Offset: 0x00033D49
		public void SetOpcPackage(global::NPOI.OpenXml4Net.OPC.OPCPackage opcPackage)
		{
			this.opcPackage.Value = opcPackage;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00035B57 File Offset: 0x00033D57
		public global::NPOI.POIFS.Crypt.IPrivateKey GetKey()
		{
			return this.key;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00035B5F File Offset: 0x00033D5F
		public void SetKey(global::NPOI.POIFS.Crypt.IPrivateKey key)
		{
			this.key = key;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00035B68 File Offset: 0x00033D68
		public global::System.Collections.Generic.List<global::System.Security.Cryptography.X509Certificates.X509Certificate> GetSigningCertificateChain()
		{
			return this.signingCertificateChain;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00035B70 File Offset: 0x00033D70
		public void SetSigningCertificateChain(global::System.Collections.Generic.List<global::System.Security.Cryptography.X509Certificates.X509Certificate> signingCertificateChain)
		{
			this.signingCertificateChain = signingCertificateChain;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00035B79 File Offset: 0x00033D79
		public global::System.DateTime GetExecutionTime()
		{
			return this.executionTime;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00035B81 File Offset: 0x00033D81
		public void SetExecutionTime(global::System.DateTime executionTime)
		{
			this.executionTime = executionTime;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00035B8A File Offset: 0x00033D8A
		public global::NPOI.POIFS.Crypt.Dsig.Services.ISignaturePolicyService GetSignaturePolicyService()
		{
			return this.signaturePolicyService;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00035B92 File Offset: 0x00033D92
		public void SetSignaturePolicyService(global::NPOI.POIFS.Crypt.Dsig.Services.ISignaturePolicyService signaturePolicyService)
		{
			this.signaturePolicyService = signaturePolicyService;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00035B9B File Offset: 0x00033D9B
		public string GetSignatureDescription()
		{
			return this.signatureDescription;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00035BA3 File Offset: 0x00033DA3
		public void SetSignatureDescription(string signatureDescription)
		{
			this.signatureDescription = signatureDescription;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00035BAC File Offset: 0x00033DAC
		public string GetCanonicalizationMethod()
		{
			return this.canonicalizationMethod;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00035BB4 File Offset: 0x00033DB4
		public void SetCanonicalizationMethod(string canonicalizationMethod)
		{
			this.canonicalizationMethod = canonicalizationMethod;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00035BBD File Offset: 0x00033DBD
		public string GetPackageSignatureId()
		{
			return this.packageSignatureId;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00035BC8 File Offset: 0x00033DC8
		public void SetPackageSignatureId(string packageSignatureId)
		{
			this.packageSignatureId = global::NPOI.POIFS.Crypt.Dsig.SignatureConfig.nvl<string>(packageSignatureId, "xmldsig-" + global::System.Guid.NewGuid().ToString());
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00035BFE File Offset: 0x00033DFE
		public string GetTspUrl()
		{
			return this.tspUrl;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00035C06 File Offset: 0x00033E06
		public void SetTspUrl(string tspUrl)
		{
			this.tspUrl = tspUrl;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00035C0F File Offset: 0x00033E0F
		public bool IsTspOldProtocol()
		{
			return this.tspOldProtocol;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00035C17 File Offset: 0x00033E17
		public void SetTspOldProtocol(bool tspOldProtocol)
		{
			this.tspOldProtocol = tspOldProtocol;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00035C20 File Offset: 0x00033E20
		public global::NPOI.POIFS.Crypt.HashAlgorithm GetTspDigestAlgo()
		{
			return global::NPOI.POIFS.Crypt.Dsig.SignatureConfig.nvl<global::NPOI.POIFS.Crypt.HashAlgorithm>(this.tspDigestAlgo, this.digestAlgo);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00035C33 File Offset: 0x00033E33
		public void SetTspDigestAlgo(global::NPOI.POIFS.Crypt.HashAlgorithm tspDigestAlgo)
		{
			this.tspDigestAlgo = tspDigestAlgo;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00035C3C File Offset: 0x00033E3C
		public string GetProxyUrl()
		{
			return this.proxyUrl;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00035C44 File Offset: 0x00033E44
		public void SetProxyUrl(string proxyUrl)
		{
			this.proxyUrl = proxyUrl;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00035C4D File Offset: 0x00033E4D
		public global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampService GetTspService()
		{
			return this.tspService;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00035C55 File Offset: 0x00033E55
		public void SetTspService(global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampService tspService)
		{
			this.tspService = tspService;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00035C5E File Offset: 0x00033E5E
		public string GetTspUser()
		{
			return this.tspUser;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00035C66 File Offset: 0x00033E66
		public void SetTspUser(string tspUser)
		{
			this.tspUser = tspUser;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00035C6F File Offset: 0x00033E6F
		public string GetTspPass()
		{
			return this.tspPass;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00035C77 File Offset: 0x00033E77
		public void SetTspPass(string tspPass)
		{
			this.tspPass = tspPass;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00035C80 File Offset: 0x00033E80
		public global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampServiceValidator GetTspValidator()
		{
			return this.tspValidator;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00035C88 File Offset: 0x00033E88
		public void SetTspValidator(global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampServiceValidator tspValidator)
		{
			this.tspValidator = tspValidator;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00035C91 File Offset: 0x00033E91
		public global::NPOI.POIFS.Crypt.Dsig.Services.IRevocationDataService GetRevocationDataService()
		{
			return this.revocationDataService;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00035C99 File Offset: 0x00033E99
		public void SetRevocationDataService(global::NPOI.POIFS.Crypt.Dsig.Services.IRevocationDataService revocationDataService)
		{
			this.revocationDataService = revocationDataService;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00035CA2 File Offset: 0x00033EA2
		public global::NPOI.POIFS.Crypt.HashAlgorithm GetXadesDigestAlgo()
		{
			return global::NPOI.POIFS.Crypt.Dsig.SignatureConfig.nvl<global::NPOI.POIFS.Crypt.HashAlgorithm>(this.xadesDigestAlgo, this.digestAlgo);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00035CB5 File Offset: 0x00033EB5
		public void SetXadesDigestAlgo(global::NPOI.POIFS.Crypt.HashAlgorithm xadesDigestAlgo)
		{
			this.xadesDigestAlgo = xadesDigestAlgo;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00035CBE File Offset: 0x00033EBE
		public string GetUserAgent()
		{
			return this.userAgent;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00035CC6 File Offset: 0x00033EC6
		public void SetUserAgent(string userAgent)
		{
			this.userAgent = userAgent;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00035CCF File Offset: 0x00033ECF
		public string GetTspRequestPolicy()
		{
			return this.tspRequestPolicy;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00035CD7 File Offset: 0x00033ED7
		public void SetTspRequestPolicy(string tspRequestPolicy)
		{
			this.tspRequestPolicy = tspRequestPolicy;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00035CE0 File Offset: 0x00033EE0
		public bool IsIncludeEntireCertificateChain()
		{
			return this.includeEntireCertificateChain;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00035CE8 File Offset: 0x00033EE8
		public void SetIncludeEntireCertificateChain(bool includeEntireCertificateChain)
		{
			this.includeEntireCertificateChain = includeEntireCertificateChain;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00035CF1 File Offset: 0x00033EF1
		public bool IsIncludeIssuerSerial()
		{
			return this.includeIssuerSerial;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00035CF9 File Offset: 0x00033EF9
		public void SetIncludeIssuerSerial(bool includeIssuerSerial)
		{
			this.includeIssuerSerial = includeIssuerSerial;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00035D02 File Offset: 0x00033F02
		public bool IsIncludeKeyValue()
		{
			return this.includeKeyValue;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00035D0A File Offset: 0x00033F0A
		public void SetIncludeKeyValue(bool includeKeyValue)
		{
			this.includeKeyValue = includeKeyValue;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00035D13 File Offset: 0x00033F13
		public string GetXadesRole()
		{
			return this.xadesRole;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00035D1B File Offset: 0x00033F1B
		public void SetXadesRole(string xadesRole)
		{
			this.xadesRole = xadesRole;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00035D24 File Offset: 0x00033F24
		public string GetXadesSignatureId()
		{
			return global::NPOI.POIFS.Crypt.Dsig.SignatureConfig.nvl<string>(this.xadesSignatureId, "idSignedProperties");
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00035D36 File Offset: 0x00033F36
		public void SetXadesSignatureId(string xadesSignatureId)
		{
			this.xadesSignatureId = xadesSignatureId;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00035D3F File Offset: 0x00033F3F
		public bool IsXadesSignaturePolicyImplied()
		{
			return this.xadesSignaturePolicyImplied;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00035D47 File Offset: 0x00033F47
		public void SetXadesSignaturePolicyImplied(bool xadesSignaturePolicyImplied)
		{
			this.xadesSignaturePolicyImplied = xadesSignaturePolicyImplied;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00035D50 File Offset: 0x00033F50
		public bool IsXadesIssuerNameNoReverseOrder()
		{
			return this.xadesIssuerNameNoReverseOrder;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00035D58 File Offset: 0x00033F58
		public void SetXadesIssuerNameNoReverseOrder(bool xadesIssuerNameNoReverseOrder)
		{
			this.xadesIssuerNameNoReverseOrder = xadesIssuerNameNoReverseOrder;
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00035D61 File Offset: 0x00033F61
		public global::System.Collections.Generic.Dictionary<string, string> GetNamespacePrefixes()
		{
			return this.namespacePrefixes;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00035D69 File Offset: 0x00033F69
		public void SetNamespacePrefixes(global::System.Collections.Generic.Dictionary<string, string> namespacePrefixes)
		{
			this.namespacePrefixes = namespacePrefixes;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00035D72 File Offset: 0x00033F72
		protected static T nvl<T>(T value, T defaultValue)
		{
			if (value != null)
			{
				return value;
			}
			return defaultValue;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00035D80 File Offset: 0x00033F80
		public byte[] GetHashMagic()
		{
			string jceId = this.GetDigestAlgo().jceId;
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(jceId);
			if (num <= 2631153146U)
			{
				if (num != 2070555668U)
				{
					if (num != 2102584679U)
					{
						if (num == 2631153146U)
						{
							if (jceId == "sha256")
							{
								return new byte[]
								{
									48,
									47,
									48,
									11,
									6,
									9,
									96,
									134,
									72,
									1,
									101,
									3,
									4,
									2,
									1,
									4,
									32
								};
							}
						}
					}
					else if (jceId == "ripemd160")
					{
						return new byte[]
						{
							48,
							31,
							48,
							7,
							6,
							5,
							43,
							36,
							3,
							2,
							1,
							4,
							20
						};
					}
				}
				else if (jceId == "sha1")
				{
					return new byte[]
					{
						48,
						31,
						48,
						7,
						6,
						5,
						43,
						14,
						3,
						2,
						26,
						4,
						20
					};
				}
			}
			else if (num <= 2694049387U)
			{
				if (num != 2632285979U)
				{
					if (num == 2694049387U)
					{
						if (jceId == "sha512")
						{
							return new byte[]
							{
								48,
								79,
								48,
								11,
								6,
								9,
								96,
								134,
								72,
								1,
								101,
								3,
								4,
								2,
								3,
								4,
								64
							};
						}
					}
				}
				else if (jceId == "sha224")
				{
					return new byte[]
					{
						48,
						43,
						48,
						11,
						6,
						9,
						96,
						134,
						72,
						1,
						101,
						3,
						4,
						2,
						4,
						4,
						28
					};
				}
			}
			else if (num != 2700614742U)
			{
				if (num == 3980986459U)
				{
					if (jceId == "ripemd128")
					{
						return new byte[]
						{
							48,
							27,
							48,
							7,
							6,
							5,
							43,
							36,
							3,
							2,
							2,
							4,
							16
						};
					}
				}
			}
			else if (jceId == "sha384")
			{
				return new byte[]
				{
					48,
					63,
					48,
					11,
					6,
					9,
					96,
					134,
					72,
					1,
					101,
					3,
					4,
					2,
					2,
					4,
					48
				};
			}
			string str = "Hash algorithm ";
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = this.GetDigestAlgo();
			throw new global::NPOI.EncryptedDocumentException(str + ((hashAlgorithm != null) ? hashAlgorithm.ToString() : null) + " not supported for signing.");
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00035F50 File Offset: 0x00034150
		public string GetSignatureMethodUri()
		{
			string jceId = this.GetDigestAlgo().jceId;
			if (jceId == "sha1")
			{
				return global::NPOI.POIFS.Crypt.Dsig.XMLSignature.ALGO_ID_SIGNATURE_RSA_SHA1;
			}
			if (jceId == "sha224")
			{
				return global::NPOI.POIFS.Crypt.Dsig.XMLSignature.ALGO_ID_SIGNATURE_RSA_SHA224;
			}
			if (jceId == "sha256")
			{
				return global::NPOI.POIFS.Crypt.Dsig.XMLSignature.ALGO_ID_SIGNATURE_RSA_SHA256;
			}
			if (jceId == "sha384")
			{
				return global::NPOI.POIFS.Crypt.Dsig.XMLSignature.ALGO_ID_SIGNATURE_RSA_SHA384;
			}
			if (jceId == "sha512")
			{
				return global::NPOI.POIFS.Crypt.Dsig.XMLSignature.ALGO_ID_SIGNATURE_RSA_SHA512;
			}
			if (!(jceId == "ripemd160"))
			{
				string str = "Hash algorithm ";
				global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = this.GetDigestAlgo();
				throw new global::NPOI.EncryptedDocumentException(str + ((hashAlgorithm != null) ? hashAlgorithm.ToString() : null) + " not supported for signing.");
			}
			return global::NPOI.POIFS.Crypt.Dsig.XMLSignature.ALGO_ID_SIGNATURE_RSA_RIPEMD160;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00036003 File Offset: 0x00034203
		public string GetDigestMethodUri()
		{
			return global::NPOI.POIFS.Crypt.Dsig.SignatureConfig.GetDigestMethodUri(this.GetDigestAlgo());
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00036010 File Offset: 0x00034210
		public static string GetDigestMethodUri(global::NPOI.POIFS.Crypt.HashAlgorithm digestAlgo)
		{
			string jceId = digestAlgo.jceId;
			if (jceId == "sha1")
			{
				return "http://www.w3.org/2000/09/xmldsig#sha1";
			}
			if (jceId == "sha224")
			{
				return "http://www.w3.org/2001/04/xmldsig-more#sha224";
			}
			if (jceId == "sha256")
			{
				return "http://www.w3.org/2001/04/xmlenc#sha256";
			}
			if (jceId == "sha384")
			{
				return "http://www.w3.org/2001/04/xmldsig-more#sha384";
			}
			if (jceId == "sha512")
			{
				return "http://www.w3.org/2001/04/xmlenc#sha512";
			}
			if (!(jceId == "ripemd160"))
			{
				throw new global::NPOI.EncryptedDocumentException("Hash algorithm " + ((digestAlgo != null) ? digestAlgo.ToString() : null) + " not supported for signing.");
			}
			return "http://www.w3.org/2001/04/xmlenc#ripemd160";
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000360B9 File Offset: 0x000342B9
		public string GetXadesCanonicalizationMethod()
		{
			return this.xadesCanonicalizationMethod;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000360C1 File Offset: 0x000342C1
		public void SetXadesCanonicalizationMethod(string xadesCanonicalizationMethod)
		{
			this.xadesCanonicalizationMethod = xadesCanonicalizationMethod;
		}

		// Token: 0x0400047D RID: 1149
		private global::System.Threading.ThreadLocal<global::NPOI.OpenXml4Net.OPC.OPCPackage> opcPackage = new global::System.Threading.ThreadLocal<global::NPOI.OpenXml4Net.OPC.OPCPackage>();

		// Token: 0x0400047E RID: 1150
		private global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet> signatureFacets = new global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet>();

		// Token: 0x0400047F RID: 1151
		private global::NPOI.POIFS.Crypt.HashAlgorithm digestAlgo = global::NPOI.POIFS.Crypt.HashAlgorithm.sha1;

		// Token: 0x04000480 RID: 1152
		private global::System.DateTime executionTime = global::System.DateTime.Now;

		// Token: 0x04000481 RID: 1153
		private global::NPOI.POIFS.Crypt.IPrivateKey key;

		// Token: 0x04000482 RID: 1154
		private global::System.Collections.Generic.List<global::System.Security.Cryptography.X509Certificates.X509Certificate> signingCertificateChain;

		// Token: 0x04000483 RID: 1155
		private global::NPOI.POIFS.Crypt.Dsig.Services.ISignaturePolicyService signaturePolicyService;

		// Token: 0x04000484 RID: 1156
		private global::NPOI.POIFS.Crypt.Dsig.IURIDereferencer uriDereferencer;

		// Token: 0x04000485 RID: 1157
		private string canonicalizationMethod = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";

		// Token: 0x04000486 RID: 1158
		private bool includeEntireCertificateChain = true;

		// Token: 0x04000487 RID: 1159
		private bool includeIssuerSerial;

		// Token: 0x04000488 RID: 1160
		private bool includeKeyValue;

		// Token: 0x04000489 RID: 1161
		private global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampService tspService = new global::NPOI.POIFS.Crypt.Dsig.Services.TSPTimeStampService();

		// Token: 0x0400048A RID: 1162
		private string tspUrl;

		// Token: 0x0400048B RID: 1163
		private bool tspOldProtocol;

		// Token: 0x0400048C RID: 1164
		private global::NPOI.POIFS.Crypt.HashAlgorithm tspDigestAlgo;

		// Token: 0x0400048D RID: 1165
		private string tspUser;

		// Token: 0x0400048E RID: 1166
		private string tspPass;

		// Token: 0x0400048F RID: 1167
		private global::NPOI.POIFS.Crypt.Dsig.Services.ITimeStampServiceValidator tspValidator;

		// Token: 0x04000490 RID: 1168
		private string tspRequestPolicy = "1.3.6.1.4.1.13762.3";

		// Token: 0x04000491 RID: 1169
		private string userAgent = "POI XmlSign Service TSP Client";

		// Token: 0x04000492 RID: 1170
		private string proxyUrl;

		// Token: 0x04000493 RID: 1171
		private global::NPOI.POIFS.Crypt.Dsig.Services.IRevocationDataService revocationDataService;

		// Token: 0x04000494 RID: 1172
		private global::NPOI.POIFS.Crypt.HashAlgorithm xadesDigestAlgo;

		// Token: 0x04000495 RID: 1173
		private string xadesRole;

		// Token: 0x04000496 RID: 1174
		private string xadesSignatureId = "idSignedProperties";

		// Token: 0x04000497 RID: 1175
		private bool xadesSignaturePolicyImplied = true;

		// Token: 0x04000498 RID: 1176
		private string xadesCanonicalizationMethod = "http://www.w3.org/2001/10/xml-exc-c14n#";

		// Token: 0x04000499 RID: 1177
		private bool xadesIssuerNameNoReverseOrder = true;

		// Token: 0x0400049A RID: 1178
		private string packageSignatureId = "idPackageSignature";

		// Token: 0x0400049B RID: 1179
		private string signatureDescription = "Office OpenXML Document";

		// Token: 0x0400049C RID: 1180
		private global::NPOI.POIFS.Crypt.Dsig.IEventListener signatureMarshalListener;

		// Token: 0x0400049D RID: 1181
		private global::System.Collections.Generic.Dictionary<string, string> namespacePrefixes = new global::System.Collections.Generic.Dictionary<string, string>();
	}
}
