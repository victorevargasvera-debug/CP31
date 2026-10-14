using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlTokenComponent
{
	// Token: 0x02000009 RID: 9
	public class SamlTokenConfigSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00005A78 File Offset: 0x00003C78
		public object Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			int a_ = 8;
			short num = (short)1193541632;
			switch (num)
			{
			default:
			{
				num = (short)507117570;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Xml.Linq.XElement a_2;
				global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_147;
					case 1:
						goto IL_80;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 3:
					{
						global::System.Xml.Linq.XElement xelement = global::System.Xml.Linq.XElement.Parse(section.OuterXml);
						global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = xelement.Elements(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫸韺铼髾漀眂䘄戆笈缊搌椎砐瀒琔挖簘", a_));
						if (enumerable.Count<global::System.Xml.Linq.XElement>() == 0)
						{
							goto Block_2;
						}
						a_2 = xelement.Element(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꫸黺迼觾搀焂䘄戆笈缊搌椎砐瀒琔挖簘", a_));
						list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CertificateObj>();
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = enumerable.GetEnumerator();
						num = (short)1332412416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5D:
					if (string.IsNullOrEmpty(section.InnerXml))
					{
						num = (short)370933761;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)189071363;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_80:
				num = (short)832176129;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificateNameNotMatch);
				Block_2:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.X509ClientCertificateNameNotMatch);
				IL_147:
				try
				{
					num = (short)1457586180;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1404108803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement a_3 = enumerator.Current;
							global::Motorola.Security.SamlTokenComponent.CertificateObj certificateObj = new global::Motorola.Security.SamlTokenComponent.CertificateObj();
							global::Motorola.Security.SamlTokenComponent.SamlTokenConfigSectionHandler.a(certificateObj, a_3);
							certificateObj.certificateType = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뫸韺铼髾漀眂䘄戆笈缊搌椎砐瀒琔挖簘", a_);
							list.Add(certificateObj);
							num = (short)670236673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_225;
						case 3:
							num = (short)1137770498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_184;
							}
							continue;
						}
						IL_1D3:
						num = (short)1977352192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_184:
						goto IL_1D3;
					}
					IL_225:;
				}
				finally
				{
					num = (short)767229954;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
						switch (num2)
						{
						case 0:
						{
							num = (short)1235812655;
							short num3 = num;
							num = (short)347210031;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_240;
							default:
								goto IL_2D0;
							}
							break;
						}
						case 1:
							enumerator.Dispose();
							num = (short)783876096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_240;
						}
						goto IL_25D;
						IL_240:
						switch (0)
						{
						case 0:
							IL_25D:
							if (enumerator == null)
							{
								goto IL_2E8;
							}
							num = (short)832438273;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_2D0:
					num = (short)74121216;
					if (num != 0)
					{
					}
					IL_2E8:;
				}
				num = (short)1164640256;
				short num4 = num;
				global::Motorola.Security.SamlTokenComponent.CertificateObj certificateObj2 = new global::Motorola.Security.SamlTokenComponent.CertificateObj();
				global::Motorola.Security.SamlTokenComponent.SamlTokenConfigSectionHandler.a(certificateObj2, a_2);
				certificateObj2.certificateType = global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("꫸黺迼觾搀焂䘄戆笈缊搌椎砐瀒琔挖簘", a_);
				list.Add(certificateObj2);
				return list;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005DD0 File Offset: 0x00003FD0
		private static void a(global::Motorola.Security.SamlTokenComponent.CertificateObj A_0, global::System.Xml.Linq.XElement A_1)
		{
			int a_ = 19;
			short num = (short)593182444;
			short num2 = num;
			num = (short)2075999980;
			switch (num2 == num)
			{
			}
			num = (short)1539637248;
			short num3 = num;
			num = (short)115539969;
			if (num != 0)
			{
			}
			num = (short)2019164160;
			if (num != 0)
			{
			}
			A_0.storeLocation = (global::System.Security.Cryptography.X509Certificates.StoreLocation)global::System.Enum.Parse(typeof(global::System.Security.Cryptography.X509Certificates.StoreLocation), A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("圃爅朇砉椋䈍缏焑甓戕焗甙爛", a_)).Value);
			A_0.storeName = (global::System.Security.Cryptography.X509Certificates.StoreName)global::System.Enum.Parse(typeof(global::System.Security.Cryptography.X509Certificates.StoreName), A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("圃爅朇砉椋䀍焏缑焓", a_)).Value);
			A_0.findType = (global::System.Security.Cryptography.X509Certificates.X509FindType)global::System.Enum.Parse(typeof(global::System.Security.Cryptography.X509Certificates.X509FindType), A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("尃㌅㠇㌉䨋服縏瘑䀓漕栗缙", a_)).Value);
			A_0.value = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("刃朅搇缉椋", a_)).Value;
			A_0.clientType = ((A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃樅愇漉戋稍䐏欑搓猕", a_)) != null) ? A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("䜃樅愇漉戋稍䐏欑搓猕", a_)).Value : null);
		}
	}
}
