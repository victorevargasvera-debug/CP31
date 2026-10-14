using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x0200001F RID: 31
	public static class AcpObjectDataProvider
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000204FC File Offset: 0x0001E6FC
		static AcpObjectDataProvider()
		{
			short num = (short)230104250;
			short num2 = num;
			num = (short)175840442;
			switch (num2 == num)
			{
			}
			num = (short)453181440;
			short num3 = num;
			num = (short)2008612865;
			if (num != 0)
			{
			}
			num = (short)804257792;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000205A4 File Offset: 0x0001E7A4
		public static global::AcpBusinessLayer.Recordset GetRecordset(int parentRecsetID)
		{
			short num = (short)1526802507;
			short num2 = num;
			num = (short)1332553803;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_120:
				num = (short)1920270339;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1327038464;
				if (num != 0)
				{
				}
				num = (short)1762983937;
				if (num != 0)
				{
				}
				num = (short)550174724;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			global::AcpBusinessLayer.Recordset result;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_10D;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)771817474;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(parentRecsetID);
					num = (short)1529282565;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_171;
				case 3:
					goto IL_139;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_AE;
					}
					continue;
				case 5:
					return result;
				}
				IL_AE:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)143720448;
					short num4 = num;
					num = (short)1368850432;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1059782657;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_10D:
			return null;
			IL_139:
			return result;
			IL_171:
			result = (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(parentRecsetID);
			goto IL_120;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0002074C File Offset: 0x0001E94C
		public static global::AcpBusinessLayer.Recordset GetRecordset(int parentRecsetID, int parentSectionID)
		{
			int a_ = 1;
			short num = (short)1139671047;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.Recordset recordset;
			for (;;)
			{
				num = (short)601554944;
				short num3 = num;
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1377959937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)849477633;
					if (num != 0)
					{
					}
					recordset = global::AcpUI.AcpObjectDataProvider.GetRecordset(parentRecsetID);
					num = (short)2146304003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					recordset = global::AcpUI.AcpObjectDataProvider.GetRecordset(parentRecsetID);
					num = (short)1048838150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_CE;
				case 3:
					goto IL_1A9;
				case 4:
				{
					num = (short)1686692359;
					short num4 = num;
					num = (short)1428742663;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)755499008;
						if (num != 0)
						{
						}
						if (recordset != null)
						{
							num = (short)1430716418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					num = (short)1382416392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_B1;
				case 6:
					goto IL_1A9;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 8:
					goto IL_228;
				}
				IL_7A:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1820590085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1820065792;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A9:
				num = (short)1717501956;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B1:
			return null;
			IL_CE:
			global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = ((global::AcpCommonLib.IAcpFeatureNode)((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(recordset)).CurrentItem)[parentSectionID];
			if (acpFeatureSection == null)
			{
				string paramName = string.Format(global::AcpUI.Common.Utility.c("얖ﲘ얠킢삤펦覨슪쎬\udcae얰튲\udbb4풶\udcb8鮺쪼횾뗀ꯂ軆跈뛌ￎ곐뇔룖볘꣚﷜뇞軠韢엤蓦蛨藪駬軮飰鷲헴零\ud9f8뷺飼黾甀瘂眄戆娈渊渌笎砐簒笔㜖渘爚検眞Ġ樢愤ܦ刨ᨪ倬", a_), parentRecsetID, parentSectionID);
				throw new global::System.ArgumentException(global::AcpUI.Common.Utility.c("햠삤쒦\udda8슪슬솮", a_), paramName);
			}
			if (acpFeatureSection.EmbeddedRecset == null)
			{
				throw new global::System.InvalidOperationException(string.Format(global::AcpUI.Common.Utility.c("톖ﲘ漢펠욢슦쪨\udfaa쒬삮\udfb0鎲슴\udeb6춸펺鶼藀뻄듈꧌ꃎ듐ꃒ맖뛘꿚﷜볞軠跢釤蛦胨藪췬軮鿰폲郴髶鯸黺駼鯾搀朂┄唆氈栊戌紎甐怒瀔挖㤘爚猜氞唠䈢䬤䐦䰨", a_), parentSectionID));
			}
			return (global::AcpBusinessLayer.Recordset)acpFeatureSection.EmbeddedRecset;
			IL_228:
			string paramName2 = string.Format(global::AcpUI.Common.Utility.c("횖릘즚ﲞ캠톢솤풦첨\udfaa趬욮\udfb0삲솴횶ힸ\ud8ba\ud8bc龾뛀ꫂ뇄꿆苊觌꫐꣔뷘듚룜곞쇠跢諤鏦짨軪闬蛮苰蟲", a_), parentRecsetID);
			throw new global::System.ArgumentException(global::AcpUI.Common.Utility.c("햠삤쒦\udaa8캪\ud9ac", a_), paramName2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00020A14 File Offset: 0x0001EC14
		public static global::AcpBusinessLayer.Recordset GetRecordset(int parentRecsetID, int parentNodeIndex, int parentSectionID)
		{
			int a_ = 11;
			short num = (short)885653514;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.Recordset recordset;
			for (;;)
			{
				num = (short)392364033;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (parentNodeIndex >= recordset.Count)
					{
						num = (short)2115698700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)703135749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_344;
				case 2:
					if (parentNodeIndex >= 0)
					{
						num = (short)1676345350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CC;
				case 3:
					goto IL_C5;
				case 4:
					goto IL_2C4;
				case 5:
					goto IL_E1;
				case 6:
					num = (short)707592192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)913637384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					recordset = global::AcpUI.AcpObjectDataProvider.GetRecordset(parentRecsetID);
					num = (short)227409924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1377763328;
					short num3 = num;
					recordset = global::AcpUI.AcpObjectDataProvider.GetRecordset(parentRecsetID);
					num = (short)1024065547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (recordset == null)
					{
						num = (short)56033281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)476577794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				case 11:
					goto IL_2C4;
				case 12:
					goto IL_2BD;
				}
				IL_8B:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)415563779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)480837639;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C4:
				num = (short)1683778550;
				short num4 = num;
				num = (short)1172532214;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1CC;
				default:
					num = (short)1117519872;
					if (num != 0)
					{
					}
					num = (short)46071817;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C5:
			return null;
			IL_E1:
			global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = recordset[parentNodeIndex][parentSectionID];
			if (acpFeatureSection == null)
			{
				string paramName = string.Format(global::AcpUI.Common.Utility.c("욢욤좦\udba8쾪\udeac쪮얰鎲\udcb4\ud9b6쪸쾺\udcbc톾ꋀꛂ냆ꃈ뿊ꗌ飐韒곖ꛚ﷜믞軠蛢雤쟦蟨蓪駬쿮鋰鳲鯴菶飸鋺鏼\udffe怀⌂䌄戆栈缊砌紎琐䀒瀔琖洘爚爜焞Ġ吢䰤匦䄨ପ搬欮ᄰ䠲д䨶", a_), parentRecsetID, parentSectionID);
				throw new global::System.ArgumentException(global::AcpUI.Common.Utility.c("토슢힤슦잨\udfaaﺬ쪮튰잲\udcb4\ud8b6ힸ寮", a_), paramName);
			}
			if (acpFeatureSection.EmbeddedRecset == null)
			{
				throw new global::System.InvalidOperationException(string.Format(global::AcpUI.Common.Utility.c("욢쒤펦\udca8\ud9aa좬ﲮ풰킲솴\udeb6횸햺鶼좾ꣀ럂귄胈迊듎껒돖뛘뻚껜￞迠賢釤쟦諨蓪菬鯮郰髲鯴ퟶ飸闺\uddfc髾氀愂怄挆洈渊椌⼎䌐瘒瘔砖欘缚渜稞唠̢䰤䤦娨弪䰬䄮到嘲", a_), parentSectionID));
			}
			return (global::AcpBusinessLayer.Recordset)acpFeatureSection.EmbeddedRecset;
			IL_1CC:
			throw new global::System.ArgumentOutOfRangeException(global::AcpUI.Common.Utility.c("토슢힤슦잨\udfaa삮햰횲ﲴ\ud9b6\uddb8\udeba얼", a_));
			IL_2BD:
			goto IL_1CC;
			IL_344:
			string paramName2 = string.Format(global::AcpUI.Common.Utility.c("莢슦쪨쒪\udfac쮮슰횲솴鞶킸햺캼쮾ꃀ귂ꛄꋆ볊꓌믎말鳔鏖律ꃚꋞ쇠蟢諤苦髨쯪菬胮藰폲郴迶郸裺觼", a_), parentRecsetID);
			throw new global::System.ArgumentException(global::AcpUI.Common.Utility.c("토슢힤슦잨\udfaaﾬ쪮튰삲킴쎶ﾺ", a_), paramName2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00020D74 File Offset: 0x0001EF74
		public static global::AcpBusinessLayer.FeatureNode GetNode(int parentRecsetID, int parentNodeIndex)
		{
			int a_ = 14;
			short num = (short)1934491651;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.Recordset recordset;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15C;
				case 1:
				{
					num = (short)177941911;
					short num3 = num;
					num = (short)880422295;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)156172288;
						if (num != 0)
						{
						}
						num = (short)2108882948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_A6;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					continue;
				case 4:
				{
					num = (short)834338816;
					short num4 = num;
					if (parentNodeIndex > recordset.Count - 1)
					{
						num = (short)885456896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B4;
				}
				case 5:
					if (parentNodeIndex >= 0)
					{
						num = (short)43057153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A0;
				}
				IL_47:
				num = (short)796786689;
				if (num != 0)
				{
				}
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)269156354;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					recordset = global::AcpUI.AcpObjectDataProvider.GetRecordset(parentRecsetID);
					num = (short)300482565;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A6:
			return null;
			IL_15C:
			IL_1A0:
			throw new global::System.ArgumentOutOfRangeException(global::AcpUI.Common.Utility.c("풣장\udaa7쾩슫\udaadﺯ\uddb1킳펵풹\ud8bb\udbbd뢿", a_));
			IL_1B4:
			return (global::AcpBusinessLayer.FeatureNode)recordset[parentNodeIndex];
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00020F44 File Offset: 0x0001F144
		public static global::AcpBusinessLayer.FeatureNode GetNode(int parentRecsetID, int parentNodeIndex, int parentSectionID, int childNodeIndex, bool canBeEmpty)
		{
			int a_ = 14;
			short num = (short)103809034;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.FeatureNode result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (childNodeIndex >= 0)
					{
						num = (short)152698892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29C;
				case 1:
					num = (short)1239482368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::AcpBusinessLayer.Recordset recordset;
					if (childNodeIndex > recordset.Count - 1)
					{
						num = (short)2140405766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = (global::AcpBusinessLayer.FeatureNode)recordset[childNodeIndex];
					num = (short)243531781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_9A;
				case 4:
				{
					num = (short)1369711512;
					short num3 = num;
					num = (short)1045635992;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BB;
					default:
						goto IL_234;
					}
					break;
				}
				case 5:
					goto IL_C3;
				case 6:
					goto IL_12B;
				case 7:
				{
					if (!canBeEmpty)
					{
						num = (short)207683592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1123811328;
					short num4 = num;
					global::AcpBusinessLayer.Recordset recordset;
					result = recordset.CreateDefaultRecord();
					num = (short)1657274372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_1B5;
				case 9:
				{
					global::AcpBusinessLayer.Recordset recordset;
					if (recordset.Count > 0)
					{
						num = (short)1427177473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)513605639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 11:
				{
					global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)global::AcpUI.AcpObjectDataProvider.GetNode(parentRecsetID, parentNodeIndex)[parentSectionID];
					if (featureSection.EmbeddedRecset == null)
					{
						goto Block_3;
					}
					global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset;
					goto IL_2BB;
				}
				case 12:
					num = (short)909049858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1380581379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1188495371;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BB:
				num = (short)1570504713;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			return null;
			IL_C3:
			num = (short)1687027713;
			if (num != 0)
			{
			}
			return result;
			IL_12B:
			goto IL_29C;
			Block_3:
			throw new global::System.ArithmeticException(global::AcpUI.Common.Utility.c("풣장\udaa7쾩슫\udaadힱힳ습톷햹튻蒿", a_));
			IL_1B5:
			throw new global::System.ArgumentException(global::AcpUI.Common.Utility.c("잣장욧즫\uddaf슱삳쾵", a_));
			IL_234:
			num = (short)1133772800;
			if (num != 0)
			{
			}
			return result;
			IL_29C:
			throw new global::System.ArgumentOutOfRangeException(global::AcpUI.Common.Utility.c("잣캥솧용좫\udfaf횱톳ﾵ횷\udeb9\ud9bb욽", a_));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002124C File Offset: 0x0001F44C
		public static global::AcpBusinessLayer.Recordset GetComparatorRecordset(int parentRecsetID)
		{
			short num = (short)1961164801;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_14D;
					}
					num = (short)1544234993;
					short num3 = num;
					num = (short)1940072433;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
						num = (short)1772027904;
						if (num != 0)
						{
						}
						num = (short)525860867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)886833153;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
					goto IL_BA;
				case 3:
					goto IL_146;
				}
				IL_5C:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1481965568;
					short num4 = num;
					num = (short)2082799618;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)914030592;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BA:
			return null;
			IL_146:
			return null;
			IL_14D:
			return (global::AcpBusinessLayer.Recordset)global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(parentRecsetID);
		}
	}
}
