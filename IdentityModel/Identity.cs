using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace IdentityModel
{
	// Token: 0x02000008 RID: 8
	public static class Identity
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002538 File Offset: 0x00000738
		public static global::System.Security.Claims.ClaimsIdentity Anonymous
		{
			get
			{
				return new global::System.Security.Claims.ClaimsIdentity(new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>
				{
					new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "")
				});
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000255C File Offset: 0x0000075C
		public static global::System.Security.Claims.ClaimsIdentity Create(string authenticationType, params global::System.Security.Claims.Claim[] claims)
		{
			return new global::System.Security.Claims.ClaimsIdentity(claims, authenticationType);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002568 File Offset: 0x00000768
		public static global::System.Security.Claims.ClaimsIdentity CreateFromCertificate(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string authenticationType = "X.509", bool includeAllClaims = false)
		{
			global::System.Collections.Generic.List<global::System.Security.Claims.Claim> list = new global::System.Collections.Generic.List<global::System.Security.Claims.Claim>();
			string issuer = certificate.Issuer;
			list.Add(new global::System.Security.Claims.Claim("issuer", issuer));
			string thumbprint = certificate.Thumbprint;
			list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint", thumbprint, "http://www.w3.org/2001/XMLSchema#base64Binary", issuer));
			string value = certificate.SubjectName.Name;
			if (!string.IsNullOrEmpty(value))
			{
				list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
			}
			if (includeAllClaims)
			{
				value = certificate.SerialNumber;
				if (!string.IsNullOrEmpty(value))
				{
					list.Add(new global::System.Security.Claims.Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
				}
				value = certificate.GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType.DnsName, false);
				if (!string.IsNullOrEmpty(value))
				{
					list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
				}
				value = certificate.GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType.SimpleName, false);
				if (!string.IsNullOrEmpty(value))
				{
					list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
				}
				value = certificate.GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType.EmailName, false);
				if (!string.IsNullOrEmpty(value))
				{
					list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
				}
				value = certificate.GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType.UpnName, false);
				if (!string.IsNullOrEmpty(value))
				{
					list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
				}
				value = certificate.GetNameInfo(global::System.Security.Cryptography.X509Certificates.X509NameType.UrlName, false);
				if (!string.IsNullOrEmpty(value))
				{
					list.Add(new global::System.Security.Claims.Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri", value, "http://www.w3.org/2001/XMLSchema#string", issuer));
				}
			}
			return new global::System.Security.Claims.ClaimsIdentity(list, authenticationType);
		}
	}
}
