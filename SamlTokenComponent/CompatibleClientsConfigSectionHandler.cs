using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlTokenComponent
{
	// Token: 0x02000004 RID: 4
	public class CompatibleClientsConfigSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000026BC File Offset: 0x000008BC
		public object Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			int a_ = 11;
			short num = (short)469237760;
			switch (num)
			{
			default:
			{
				num = (short)403046403;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CompatibleClientInfo> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = global::System.Xml.Linq.XElement.Parse(section.OuterXml).Elements(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뿻釽淿爁攃爅愇栉怋欍匏縑紓猕瘗渙", a_));
						if (enumerable.Count<global::System.Xml.Linq.XElement>() == 0)
						{
							goto Block_2;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.CompatibleClientInfo>();
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = enumerable.GetEnumerator();
						num = (short)182583297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_139;
					case 2:
						goto IL_A6;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					IL_5C:
					num = (short)1477181441;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(section.InnerXml))
					{
						num = (short)504758274;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1499201536;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A6:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뿻釽淿爁攃爅愇栉怋欍匏縑紓猕瘗渙漛㸝䌟䴡䨣䀥䄧䴩夫尭儯䘱崳夵嘷ᨹ伻嬽⌿㙁ⵃ⥅♇橉╋㵍灏㽑㵓╕⭗㍙㉛㥝", a_));
				Block_2:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("뿻釽淿爁攃爅愇栉怋欍匏縑紓猕瘗渙漛㸝䌟䴡䨣䀥䄧䴩夫尭儯䘱崳夵嘷ᨹ伻嬽⌿㙁ⵃ⥅♇橉╋㵍灏㽑㵓╕⭗㍙㉛㥝", a_));
				IL_139:
				try
				{
					num = (short)1433468931;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1FB;
						case 2:
							num = (short)601817088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_175;
							}
							continue;
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)991952898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement a_2 = enumerator.Current;
							global::Motorola.Security.SamlTokenComponent.CompatibleClientInfo compatibleClientInfo = new global::Motorola.Security.SamlTokenComponent.CompatibleClientInfo();
							global::Motorola.Security.SamlTokenComponent.CompatibleClientsConfigSectionHandler.a(compatibleClientInfo, a_2);
							list.Add(compatibleClientInfo);
							num = (short)356777985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1A9:
						num = (short)1696858116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_175:
						goto IL_1A9;
					}
					IL_1FB:;
				}
				finally
				{
					num = (short)1262551041;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_26A;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_232;
							}
							continue;
						case 2:
							goto IL_24D;
						}
						IL_232:
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
						if (enumerator != null)
						{
							num = (short)567934978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
						IL_24D:
						enumerator.Dispose();
						num = (short)995033088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_26A:
						num = (short)264147334;
						short num3 = num;
						num = (short)1377210758;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24D;
						default:
							goto IL_29E;
						}
					}
					IL_29E:
					num = (short)714080256;
					if (num != 0)
					{
					}
				}
				num = (short)352387072;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000029B8 File Offset: 0x00000BB8
		private static void a(global::Motorola.Security.SamlTokenComponent.CompatibleClientInfo A_0, global::System.Xml.Linq.XElement A_1)
		{
			int a_ = 16;
			short num = (short)863524913;
			short num2 = num;
			num = (short)2113820721;
			switch (num2 == num)
			{
			}
			num = (short)1673920512;
			if (num != 0)
			{
			}
			num = (short)1093206017;
			if (num != 0)
			{
			}
			num = (short)344391680;
			short num3 = num;
			A_0.type = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("甀稂甄戆", a_)).Value;
			A_0.minrmversion = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("氀樂欄甆搈紊栌紎成稒稔礖", a_)).Value;
			A_0.maxrmversion = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("氀戂約甆搈紊栌紎成稒稔礖", a_)).Value;
			A_0.excludedrmversions = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("搀笂昄欆簈漊栌欎挐縒挔爖欘栚琜瀞传倢", a_)).Value;
		}
	}
}
