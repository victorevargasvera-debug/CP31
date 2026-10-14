using System;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using AcpCommonLib.Exceptions;
using AcpCommonResources;
using AcpUtility;

namespace AcpCommonLib
{
	// Token: 0x02000017 RID: 23
	public static class Utility
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000875C File Offset: 0x0000695C
		public static void LogMissingXmlNode(global::System.Xml.XPath.IXPathNavigable node)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			global::System.Xml.XmlNode xmlNode;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1AD;
				case 1:
					if (!(xmlNode.Name != global::AcpCommonLib.Exceptions.AcpSecurityException.b("꫷闹鏻諽", a_)))
					{
						num2 = (short)810811392;
						short num3 = num2;
						num2 = (short)759824387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 2:
					goto IL_141;
				case 3:
					goto IL_13F;
				case 4:
					if (xmlNode != null)
					{
						num2 = (short)1541603328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				}
				goto IL_2D;
				IL_141:
				text = xmlNode.Attributes[global::AcpCommonLib.Exceptions.AcpSecurityException.b("뛷鯹釻鯽", a_)].Value + global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꓷ", a_) + text;
				xmlNode = xmlNode.ParentNode;
				num2 = (short)1238171652;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13F:
			IL_1B2:
			string message = global::AcpCommonResources.AcpResources.Unable_To_Import.AcpStringFormat(new object[]
			{
				text
			});
			global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
			return;
			IL_2D:
			xmlNode = (node as global::System.Xml.XmlNode);
			text = "";
			num2 = (short)370413371;
			short num4 = num2;
			num2 = (short)2136215355;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1AD:
				num2 = (short)906625025;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1447690240;
				if (num2 != 0)
				{
				}
				num2 = (short)1927806977;
				if (num2 != 0)
				{
				}
				num2 = (short)811008002;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008940 File Offset: 0x00006B40
		public static global::AcpCommonLib.IAcpField GetCompField(global::AcpCommonLib.IAcpField activeDocField)
		{
			short num = (short)1109590016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_F6;
				}
				global::AcpCommonLib.IAcpRecordset parent;
				global::AcpCommonLib.IAcpField result;
				global::AcpCommonLib.IAcpFeatureNode parent2;
				global::AcpCommonLib.IAcpFeatureSection parent5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						if (parent.IsEmbeddedRecset)
						{
							num = (short)1618673688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(parent.RecsetId);
						num = (short)576323620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (parent.HasKeyField)
						{
							num = (short)1448738830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)344719389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1321140224;
						short num3 = num;
						num = (short)1667760163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count > 0)
						{
							num = (short)1602682899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_582;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode != null)
						{
							num = (short)958791713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						num = (short)1413677079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						int num4;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = feature2[num4];
						num = (short)945029128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						int num4;
						if (feature2.Count > num4)
						{
							num = (short)1904869382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_582;
					}
					case 8:
						goto IL_582;
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature.NodeFromKey(parent2.ReferenceKey);
						num = (short)2035548180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_359;
					case 11:
						num = (short)587923481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_359;
					case 13:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
						result = acpFeatureSection[activeDocField.UIName];
						goto IL_420;
					}
					case 14:
						num = (short)699400220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset parent3;
						if (parent3.HasKeyField)
						{
							num = (short)485425157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1830682627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)1297154092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B3;
					}
					case 17:
						goto IL_439;
					case 18:
						num = (short)105775143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)20250631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_359;
					case 21:
						num = (short)216399873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
						if (acpFeatureSection != null)
						{
							num = (short)1093271565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 23:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count > 0)
						{
							num = (short)871694370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_582;
					}
					case 24:
					{
						global::AcpCommonLib.IAcpFeatureSection parentSection = parent.ParentSection;
						global::AcpCommonLib.IAcpFeatureNode parent4 = parentSection.Parent;
						global::AcpCommonLib.IAcpRecordset parent3 = parent4.Parent;
						int num4 = parent3.IndexOf(parent4);
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = null;
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(parent3.RecsetId);
						global::AcpCommonLib.IAcpRecordset acpRecordset = null;
						num = (short)755367952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count > 0)
						{
							num = (short)1595539465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 26:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						int num5;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = acpRecordset[num5];
						num = (short)1723334696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_51D;
					case 28:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (acpRecordset.Count > 0)
						{
							num = (short)1797849134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 29:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (acpRecordset.Count > 0)
						{
							num = (short)833552402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 30:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
						global::AcpCommonLib.IAcpFeatureSection parentSection;
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2 = acpFeatureNode2[parentSection.FeatureSectionId];
						num = (short)338624561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
						if (acpFeatureNode2 != null)
						{
							num = (short)399441950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43E;
					}
					case 32:
						goto IL_582;
					case 33:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = acpFeatureNode[parent5.FeatureSectionId];
						num = (short)189136918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::AcpCommonLib.IAcpFeatureNode parent4;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = feature2.NodeFromKey(parent4.ReferenceKey);
						num = (short)2070675488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						int num5;
						if (feature.Count > num5)
						{
							num = (short)1866989606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 36:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)919732267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B5;
					}
					case 37:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count > 0)
						{
							num = (short)1903820802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 38:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						int num5;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature[num5];
						num = (short)1033699340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						int num5;
						if (acpRecordset.Count > num5)
						{
							num = (short)1601110042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					}
					case 40:
						goto IL_359;
					case 41:
					{
						if (parent == null)
						{
							num = (short)898498607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = parent.IndexOf(parent2);
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
						result = null;
						num = (short)1550254080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
						global::AcpCommonLib.IAcpRecordset acpRecordset = acpFeatureSection2.EmbeddedRecset;
						num = (short)1107296283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						num = (short)1184759853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)1565851663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (parent.HasKeyField)
						{
							num = (short)1085014027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1260322853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = acpRecordset.NodeFromKey(parent2.ReferenceKey);
						num = (short)191234058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
					{
						num = (short)1872983480;
						short num6 = num;
						num = (short)792098232;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_420;
						default:
							goto IL_179;
						}
						break;
					}
					case 48:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset;
						if (acpRecordset != null)
						{
							num = (short)117047317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_778;
					}
					case 49:
					{
						num = (short)108920833;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
						if (acpFeatureSection2 != null)
						{
							num = (short)1008009258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51D;
					}
					}
					goto IL_F6;
					IL_359:
					num = (short)1565786116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_420:
					num = (short)1977024529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51D:
					num = (short)1142947888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_582:
					num = (short)1030684703;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_179:
				num = (short)571342848;
				if (num != 0)
				{
				}
				return null;
				IL_439:
				return result;
				IL_43E:
				return null;
				IL_4B3:
				return null;
				IL_4B5:
				return null;
				IL_778:
				return null;
				IL_F6:
				parent5 = activeDocField.Parent;
				parent2 = parent5.Parent;
				parent = parent2.Parent;
				num = (short)372506665;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009218 File Offset: 0x00007418
		public static void Compare(global::AcpCommonLib.IAcpField activeDocField, global::AcpCommonLib.IAcpField compDocField)
		{
			short num = (short)1914044421;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (activeDocField.CompareTo(compDocField) == 0)
					{
						num = (short)1824784395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					string message = global::AcpCommonLib.Utility.FormatFieldValue(compDocField);
					num = (short)67502087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1308884993;
					if (num != 0)
					{
					}
					global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.UnregisterFieldInReport(activeDocField);
					num = (short)691142658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_A8;
				case 3:
				{
					if (compDocField == null)
					{
						num = (short)241172488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1724252160;
					short num3 = num;
					global::AcpCommonLib.IAcpFeatureSection parent = activeDocField.Parent;
					num = (short)200409088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.ContainsField(activeDocField))
					{
						num = (short)1634009089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 6:
					goto IL_1AF;
				case 7:
					if (!global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.ContainsField(activeDocField))
					{
						num = (short)2126905354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				case 8:
					goto IL_143;
				case 9:
					if (!activeDocField._HasDiffs)
					{
						num = (short)792723468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FF;
				case 10:
				{
					string message;
					global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.RegisterFieldInReport(activeDocField, message, false);
					num = (short)1631453197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
				{
					num = (short)1495815085;
					short num4 = num;
					num = (short)1640649645;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
						num = (short)1925906432;
						if (num != 0)
						{
						}
						num = (short)1727987716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					activeDocField._HasDiffs = true;
					num = (short)195493894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_CD;
				case 14:
					goto IL_C7;
				case 15:
					num = (short)1040187395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_64;
				IL_67:
				num = (short)1353777167;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64:
				if (activeDocField != null)
				{
					goto IL_67;
				}
				return;
				IL_A8:
				activeDocField._HasDiffs = false;
				num = (short)1759707150;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD:
				num = (short)318636041;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			goto IL_2FF;
			IL_143:
			return;
			IL_1AF:
			IL_2FF:
			global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.FieldsReportChanged = true;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009530 File Offset: 0x00007730
		public static string FormatFieldValue(global::AcpCommonLib.IAcpField field)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			int num;
			short num2;
			string text;
			string str;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (field.IsMasked)
					{
						num2 = (short)1742602243;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1201864712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_162;
				case 2:
				{
					if (field is global::AcpCommonLib.IAcpRangeField)
					{
						num2 = (short)596901903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpCommonLib.IAcpPointerField acpPointerField = field as global::AcpCommonLib.IAcpPointerField;
					text = acpPointerField.ToString();
					str = acpPointerField.HexUIValue;
					flag = acpPointerField.ShowHexValue;
					num2 = (short)2035220486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_371;
				case 4:
					num2 = (short)529072144;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!flag)
					{
						num2 = (short)1230766093;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_38D;
				case 6:
					goto IL_2FB;
				case 7:
					if (field == null)
					{
						num2 = (short)1552941073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)778895370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!(field is global::AcpCommonLib.IAcpRangeField))
					{
						num2 = (short)1425735684;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 9:
					num2 = (short)1213333518;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					if (!(field is global::AcpCommonLib.IAcpListField))
					{
						goto IL_335;
					}
					num2 = (short)862962201;
					short num3 = num2;
					num2 = (short)1101578777;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
						num2 = (short)658374657;
						if (num2 != 0)
						{
						}
						num2 = (short)399572992;
						if (num2 != 0)
						{
						}
						num2 = (short)1105788937;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					goto IL_11E;
				case 12:
				{
					num2 = (short)509542400;
					short num4 = num2;
					goto IL_2FB;
				}
				case 13:
					return text;
				case 14:
					if (((global::AcpCommonLib.IAcpListField)field).SerializeItems)
					{
						num2 = (short)1497432065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_335;
				case 15:
				{
					global::AcpCommonLib.IAcpRangeField acpRangeField = field as global::AcpCommonLib.IAcpRangeField;
					text = acpRangeField.ToString();
					str = acpRangeField.HexUIValue;
					flag = acpRangeField.ShowHexValue;
					num2 = (short)947453964;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					if (!(field is global::AcpCommonLib.IAcpPointerField))
					{
						num2 = (short)1595998219;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 17:
					goto IL_A2;
				}
				goto IL_61;
				IL_A7:
				num2 = (short)1543766018;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2FB:
				num2 = (short)1597112325;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_335:
				num2 = (short)649330688;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A2:
			return null;
			IL_11E:
			return field.ToString();
			IL_162:
			return ((global::AcpCommonLib.IAcpListField)field).BuildReportString();
			IL_371:
			return "".PadLeft(field.ToString().Length, '*');
			IL_38D:
			return text + global::AcpCommonLib.Exceptions.AcpSecurityException.b("헴\udaf6\ud9f8", a_) + str;
			IL_61:
			text = "";
			str = "";
			flag = false;
			num2 = (short)944177159;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000098E0 File Offset: 0x00007AE0
		public static string displayReverseForSpecialLanguageAndField(global::AcpCommonLib.IAcpField fld, string fldValue)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1718550533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::AcpCommonLib.Exceptions.AcpSecurityException.b("搄甆", a_)))
					{
						num2 = (short)1331691524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)26869766;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_14D;
				case 3:
					result = global::AcpCommonLib.Utility.reverseConverter(fldValue);
					num2 = (short)36700162;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return fldValue;
				case 5:
					if (!string.IsNullOrEmpty(fldValue))
					{
						num2 = (short)539820035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					num2 = (short)1423048705;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.Utility.IsArabicSpecialField(fld.Name))
					{
						num2 = (short)1493368832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 7:
					goto IL_BF;
				case 8:
					if (fld == null)
					{
						num2 = (short)242221063;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1566375937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3D;
			}
			IL_14D:
			return result;
			IL_3D:
			result = fldValue;
			num2 = (short)155910071;
			short num3 = num2;
			num2 = (short)813891511;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BF:
				num2 = (short)2046689280;
				short num4 = num2;
				return fldValue;
			}
			default:
			{
				num2 = (short)1937506304;
				if (num2 != 0)
				{
				}
				num2 = (short)1867055112;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009B04 File Offset: 0x00007D04
		public static string reverseConverter(string val)
		{
			short num = (short)899809281;
			if (num != 0)
			{
			}
			num = (short)986578944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
					{
						if (num3 < val.Length)
						{
							char c = val[num3];
							text += c + '‎';
							num3++;
							num = (short)74907650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)359843682;
						short num4 = num;
						num = (short)1470941026;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return text;
						default:
							num = (short)840957952;
							if (num != 0)
							{
							}
							num = (short)65667073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return text;
					case 2:
					{
						num = (short)1107820544;
						short num5 = num;
						goto IL_88;
					}
					case 3:
						goto IL_88;
					}
					goto IL_66;
					IL_88:
					num = (short)447283200;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_66:
				text = string.Empty;
				num3 = 0;
				num = (short)1721761795;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009C8C File Offset: 0x00007E8C
		public static string reverseConverterBack(string val)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					int startIndex;
					if ((startIndex = val.IndexOf('‎')) >= 0)
					{
						val = val.Remove(startIndex, 1);
						num2 = (short)586743810;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1452643811;
					short num3 = num2;
					num2 = (short)1470928355;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return val;
					default:
						num2 = (short)302645248;
						if (num2 != 0)
						{
						}
						num2 = (short)718733313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return val;
				case 2:
					goto IL_64;
				case 3:
					goto IL_64;
				}
				goto IL_20;
				IL_64:
				num2 = (short)443088896;
				short num4 = num2;
				num2 = (short)1067515904;
				num = (int)((global::System.IntPtr)num2);
			}
			return val;
			IL_20:
			string empty = string.Empty;
			num2 = (short)289669121;
			if (num2 != 0)
			{
			}
			num2 = (short)1644036099;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009DDC File Offset: 0x00007FDC
		public static bool IsArabicSpecialField(string uiTag)
		{
			int a_ = 0;
			short num = (short)1675296771;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1908274124;
					short num3 = num;
					num = (short)1588917196;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1582628865;
						if (num != 0)
						{
						}
						num = (short)170852352;
						if (num != 0)
						{
						}
						num = (short)1401946113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (uiTag == global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꃱ闳鋵뇷铹髻釽䟿朁樃挅稇欉怋䌍儏儑唓爕簗栙礛洝匟紡攣ሥᤧሩἫ᤭", a_))
					{
						num = (short)545259520;
						short num4 = num;
						num = (short)573833218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_150;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (uiTag == global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꃱ闳鋵뇷铹髻釽䛿丁䔃唅䀇稉挋簍搏向堓圕䬗则缛焝䐟䜡笣朥ဧᬩἫᰭ", a_))
				{
					break;
				}
				num = (short)169738240;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_150:
			return true;
		}

		// Token: 0x04000062 RID: 98
		public const string Delimiter = "\\";

		// Token: 0x04000063 RID: 99
		public const string ReportManagerDelimiter = "»";
	}
}
