using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200002E RID: 46
	public sealed class ConsoleAliasesListSettingsSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x00034AF0 File Offset: 0x00032CF0
		public object Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			int a_ = 5;
			short num = (short)1793983962;
			short num2 = num;
			num = (short)461964762;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return list;
			case 1:
				break;
			default:
			{
				num = (short)919339008;
				short num3 = num;
				break;
			}
			}
			num = (short)138346496;
			if (num != 0)
			{
			}
			num = (short)1684799489;
			if (num != 0)
			{
			}
			num = (short)1671692288;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = global::System.Xml.Linq.XElement.Parse(section.OuterXml).Elements(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮝ풟횡춣좥쾧", a_));
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting>();
				global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)1049231360;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_12B;
							}
							continue;
						case 1:
							goto IL_220;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1735065604;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement xelement = enumerator.Current;
							list.Add(new global::Motorola.CommonCPS.RadioManagement.SharedServices.ConsoleAliasesListSetting
							{
								type = xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킟잡", a_)).Value,
								key = xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮝ\ud99f", a_)).Value,
								value = xelement.Attribute(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾝ첟힡솣", a_)).Value
							});
							num = (short)1605369858;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)876675073;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1CA:
						num = (short)1489567747;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12B:
						goto IL_1CA;
					}
					IL_220:;
				}
				finally
				{
					num = (short)630390784;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_254;
							}
							continue;
						case 1:
							goto IL_28B;
						case 2:
							enumerator.Dispose();
							num = (short)193658881;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_254:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1648623618;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_28B:;
				}
				break;
			}
			}
			return list;
		}
	}
}
