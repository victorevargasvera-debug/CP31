using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using CommonUtility;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000017 RID: 23
	public static class WarningMessageConverter
	{
		// Token: 0x06000071 RID: 113 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public static string SourceToTarget(string sourceWarningMessage, string[] parameters)
		{
			int a_ = 15;
			short num = (short)862519296;
			switch (num)
			{
			default:
			{
				num = (short)848625666;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						goto IL_A2;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_120;
							}
							global::System.Xml.XmlNode xmlNode;
							string result;
							for (;;)
							{
								IL_B1:
								int num3;
								switch (num2)
								{
								case 0:
								{
									string innerText;
									if (!(innerText == global::CommonUtility.VersionUtility.b("瀿", a_)))
									{
										num = (short)806486017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xmlNode = xmlNode.NextSibling;
									num = (short)62849043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1674117144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(xmlNode.InnerText, null);
									num = (short)1739259926;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(xmlNode.InnerText, null);
									num = (short)946077714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_568;
								case 5:
								{
									string[] array;
									if (array.Count<string>() > 1)
									{
										num = (short)1121910793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B8;
								}
								case 6:
									goto IL_21C;
								case 7:
								{
									global::System.Text.StringBuilder stringBuilder;
									text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, text, stringBuilder.ToString());
									text = text.Replace(global::CommonUtility.VersionUtility.b("䴿", a_), string.Empty);
									text = text.Replace(global::CommonUtility.VersionUtility.b("䨿", a_), string.Empty);
									num = (short)84541463;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									if (num3 >= parameters.Length)
									{
										num = (short)464846855;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string[] array = parameters[num3].Split(new char[]
									{
										':'
									});
									num = (short)467402757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									string[] array;
									global::System.Text.StringBuilder stringBuilder;
									stringBuilder.Append(array[0] + global::CommonUtility.VersionUtility.b("稿", a_));
									stringBuilder.AppendLine(global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(array[1], null));
									num = (short)1468530704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_382;
								case 11:
									result = text;
									num = (short)1156251658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_21C;
								case 13:
								{
									if (xmlNode == null)
									{
										num = (short)1043988491;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string innerText = xmlNode.InnerText;
									num = (short)437583872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									num = (short)161284121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)272105476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_2B8;
								case 17:
									goto IL_583;
								case 18:
									goto IL_568;
								case 19:
									if (xmlNode != null)
									{
										num = (short)540344323;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_568;
								case 20:
								{
									num = (short)2066082923;
									short num4 = num;
									num = (short)1316351083;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_27C;
									default:
										num = (short)549257216;
										if (num != 0)
										{
										}
										if (xmlNode != null)
										{
											num = (short)595656706;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_568;
									}
									break;
								}
								case 21:
								{
									global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
									num3 = 0;
									num = (short)1071906828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									if (parameters != null)
									{
										num = (short)1783365646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_568;
								case 23:
									goto IL_568;
								case 24:
								{
									string innerText;
									if (!(innerText == global::CommonUtility.VersionUtility.b("焿", a_)))
									{
										num = (short)1157300239;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xmlNode = xmlNode.NextSibling;
									num = (short)1401356308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									if (parameters.Count<string>() != 0)
									{
										goto IL_27C;
									}
									goto IL_568;
								}
								goto IL_120;
								IL_21C:
								num = (short)474218504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27C:
								num = (short)750649365;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B8:
								num3++;
								num = (short)2065039366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_568:
								result = text;
								num = (short)78118929;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_382:
							IL_583:
							return result;
							IL_120:
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.LoadXml(sourceWarningMessage);
							xmlNode = xmlDocument.DocumentElement.FirstChild;
							num = (short)1354760205;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_B1;
						}
						catch
						{
							return global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(sourceWarningMessage, parameters);
						}
						goto IL_590;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (string.IsNullOrEmpty(sourceWarningMessage))
					{
						num = (short)1805910017;
						if (num != 0)
						{
						}
						num = (short)1363804160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_590:
					text = string.Empty;
					num = (short)884211713;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				num = (short)761724928;
				short num5 = num;
				return string.Empty;
			}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public static string OriginalToSource(string originalResourceID, int type = 0)
		{
			int a_ = 6;
			if (string.IsNullOrEmpty(originalResourceID))
			{
				short num = (short)1862028840;
				short num2 = num;
				num = (short)1113280040;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2082209793;
					if (num != 0)
					{
					}
					num = (short)1009909760;
					if (num != 0)
					{
					}
					num = (short)1098711040;
					short num3 = num;
					return string.Empty;
				}
				}
			}
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			global::System.Xml.XmlElement newChild = xmlDocument.CreateElement(global::CommonUtility.VersionUtility.b("收嘸吺䤼", a_));
			global::System.Xml.XmlNode xmlNode = xmlDocument.AppendChild(newChild);
			global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement(global::CommonUtility.VersionUtility.b("挶䀸䬺堼", a_));
			xmlElement.InnerText = type.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			xmlNode.AppendChild(xmlElement);
			global::System.Xml.XmlElement xmlElement2 = xmlDocument.CreateElement(global::CommonUtility.VersionUtility.b("收尸䠺刼䨾㍀⁂⁄", a_));
			xmlElement2.InnerText = originalResourceID;
			xmlNode.AppendChild(xmlElement2);
			return xmlDocument.OuterXml.ToString();
		}
	}
}
