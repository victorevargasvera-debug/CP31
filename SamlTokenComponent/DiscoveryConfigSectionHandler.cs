using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlTokenComponent
{
	// Token: 0x02000006 RID: 6
	public class DiscoveryConfigSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002F44 File Offset: 0x00001144
		public object Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			int a_ = 5;
			short num = (short)973275136;
			switch (num)
			{
			default:
			{
				num = (short)392167426;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_AB;
					case 1:
						goto IL_13B;
					case 2:
					{
						num = (short)888733696;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = global::System.Xml.Linq.XElement.Parse(section.OuterXml).Elements(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("답釷觹鿻釽盿朁瘃缅䴇搉栋縍缏笑稓戕", a_));
						if (enumerable.Count<global::System.Xml.Linq.XElement>() == 0)
						{
							goto Block_2;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo>();
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = enumerable.GetEnumerator();
						num = (short)1269432321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_89:
					if (string.IsNullOrEmpty(section.InnerXml))
					{
						num = (short)451084288;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)893124611;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("답釷觹鿻釽盿朁瘃缅嬇漉漋稍礏紑稓㘕笗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯ሱ䜳匵嬷丹唻儽⸿扁ⵃ㕅桇❉╋㵍⍏㭑㩓ㅕ", a_));
				Block_2:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("답釷觹鿻釽盿朁瘃缅䴇搉栋縍缏笑稓戕㠗礙猛瀝䘟䬡䌣匥娧䬩堫䜭弯就ᐳ䔵崷夹䠻圽⼿ⱁ摃⽅㭇橉⅋❍⍏⅑㵓㡕㽗", a_));
				IL_13B:
				num = (short)1182400513;
				if (num != 0)
				{
				}
				try
				{
					num = (short)1440940035;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_224;
						case 2:
							num = (short)478347264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_19F;
							}
							continue;
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)111214594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement a_2 = enumerator.Current;
							global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo discoveryEndpointInfo = new global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo();
							global::Motorola.Security.SamlTokenComponent.DiscoveryConfigSectionHandler.a(discoveryEndpointInfo, a_2);
							list.Add(discoveryEndpointInfo);
							num = (short)1343029249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1D3:
						num = (short)2019229700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19F:
						goto IL_1D3;
					}
					IL_224:;
				}
				finally
				{
					num = (short)850198529;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_293;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_25C;
							}
							continue;
						case 2:
							goto IL_276;
						}
						IL_25C:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
						if (enumerator != null)
						{
							num = (short)424804354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_293;
						IL_276:
						enumerator.Dispose();
						num = (short)81985536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_293:
						num = (short)1239273872;
						short num4 = num;
						num = (short)612487568;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_276;
						default:
							goto IL_2C7;
						}
					}
					IL_2C7:
					num = (short)414318592;
					if (num != 0)
					{
					}
				}
				return list;
			}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003240 File Offset: 0x00001440
		private static void a(global::Motorola.Security.SamlTokenComponent.DiscoveryEndpointInfo A_0, global::System.Xml.Linq.XElement A_1)
		{
			int a_ = 1;
			short num = (short)1644797092;
			short num2 = num;
			num = (short)1877843108;
			switch (num2 == num)
			{
			}
			num = (short)92667904;
			short num3 = num;
			num = (short)462684161;
			if (num != 0)
			{
			}
			num = (short)275841024;
			if (num != 0)
			{
			}
			A_0.address = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鏱郳鋵諷鿹迻跽", a_)).Value;
			A_0.binding = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("郱鷳飵鳷鏹鋻駽", a_)).Value;
			A_0.bindingConfiguration = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("郱鷳飵鳷鏹鋻駽䏿洁樃怅愇洉礋簍焏昑紓礕瘗", a_)).Value;
		}
	}
}
