using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using CommonResources;
using Motorola.Common.CustomException;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.UCL.CallListUpdate
{
	// Token: 0x02000220 RID: 544
	internal sealed class ConsoleAliasesListSettingsSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06001BC2 RID: 7106 RVA: 0x0023C1A0 File Offset: 0x0023A3A0
		public object Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			int a_ = 11;
			short num = (short)1536753664;
			switch (num)
			{
			default:
			{
				num = (short)1481244673;
				if (num != 0)
				{
				}
				num = (short)1413611520;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IList<global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					case 1:
					{
						global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = global::System.Xml.Linq.XElement.Parse(section.OuterXml).Elements(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶍﾕﶙ", a_));
						if (enumerable.Count<global::System.Xml.Linq.XElement>() == 0)
						{
							goto Block_2;
						}
						list = new global::System.Collections.Generic.List<global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting>();
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = enumerable.GetEnumerator();
						num = (short)1264517122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_153;
					case 3:
						goto IL_A6;
					}
					IL_84:
					if (string.IsNullOrEmpty(section.InnerXml))
					{
						num = (short)1498546179;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)582811649;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A6:
				num = (short)384696320;
				short num3 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.ConsoleAliasesListSetting_Missing);
				Block_2:
				throw new global::Motorola.Common.CustomException.CommonException(global::CommonResources.AppResources.ConsoleAliasesListSetting_Missing);
				IL_153:
				try
				{
					num = (short)280166401;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)39845890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_191;
							}
							continue;
						case 2:
							goto IL_286;
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)628686848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement xelement = enumerator.Current;
							list.Add(new global::SpecialFeatures.UCL.CallListUpdate.ConsoleAliasesListSetting
							{
								type = xelement.Attribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("揄", a_)).Value,
								key = xelement.Attribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)).Value,
								value = xelement.Attribute(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺑ", a_)).Value
							});
							num = (short)1489305603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_230:
						num = (short)258146308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_191:
						goto IL_230;
					}
					IL_286:;
				}
				finally
				{
					num = (short)2123628545;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_344;
						case 1:
							goto IL_2A1;
						case 2:
						{
							num = (short)1296961032;
							short num4 = num;
							num = (short)89722376;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A1;
							default:
								num = (short)6160384;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1253965824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_2BE;
						IL_2A1:
						switch (0)
						{
						case 0:
							IL_2BE:
							if (enumerator == null)
							{
								goto IL_346;
							}
							num = (short)2091581442;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_344:
					IL_346:;
				}
				return list;
			}
			}
		}
	}
}
