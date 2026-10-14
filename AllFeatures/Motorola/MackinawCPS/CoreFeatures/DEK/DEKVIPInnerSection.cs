using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000334 RID: 820
	[global::System.Serializable]
	public class DEKVIPInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007E4C RID: 32332 RVA: 0x00746B08 File Offset: 0x00744D08
		public DEKVIPInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x00746B24 File Offset: 0x00744D24
		protected DEKVIPInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x00746B3C File Offset: 0x00744D3C
		public override void Init()
		{
			int a_ = 12;
			short num = (short)477626368;
			short num2 = num;
			num = (short)2027018024;
			short num3 = num;
			num = (short)1032836904;
			switch (num3 == num)
			{
			}
			num = (short)1224736769;
			if (num != 0)
			{
			}
			num = (short)884998144;
			if (num != 0)
			{
			}
			this.dEKVIPInputBCO_A21337 = new global::AcpBusinessLayer.AcpSparseLOVField(19, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPInputBCO_A21337LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPInputBCO_A21337LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖郘뗚규꫞闠ꇢꛤ꣦뛨ꫪ\udfec\udeee싰샲싴", a_), global::CommonResources.AcgResources.ID_INPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPInputBCO_A21337LovStrs);
			this.dEKVIPInputBCO_A21337.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKVIPInputBCO_A21337.DataTransferOrder = -1;
			this.dEKVIPInputFeature_A21338 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPInputFeature_A21338LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPInputFeature_A21338LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖郘뗚규꫞闠ꗢ胤蛦鷨黪鿬諮껰닲쟴웶쫸죺염", a_), global::CommonResources.AcgResources.ID_INPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPInputFeature_A21338LovStrs);
			this.dEKVIPInputFeature_A21338.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKVIPInputFeature_A21338.DataTransferOrder = 18;
			this.dEKVIPInputFeature_A21338.ValidateAcrossRecset = true;
			this.dEKVIPOutputBCO_A21347 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPOutputBCO_A21347LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPOutputBCO_A21347LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖雘껚꧜꿞铠韢꟤ꓦꛨ듪곬\uddee샰샲쇴샶", a_), global::CommonResources.AcgResources.ID_OUTPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPOutputBCO_A21347LovStrs);
			this.dEKVIPOutputBCO_A21347.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKVIPOutputBCO_A21347.DataTransferOrder = -1;
			this.dEKVIPKey_A22573 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖鋘뻚ꓜ胞ꃠ퇢ퟤ틦\udee8\ud8ea", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.dEKVIPKey_A22573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKVIPKey_A22573.DataTransferOrder = -1;
			this.dEKVIPName_A22574 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DEKAVIP1, this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖韘뫚냜뫞뻠ꋢퟤ헦\udce8\udcea\ud9ec", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.dEKVIPName_A22574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKVIPName_A22574.DataTransferOrder = -1;
			this.dEKVIPOutputFeature_A21346 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPOutputFeature_A21346LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPOutputFeature_A21346LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖雘껚꧜꿞铠韢ꏤ苦裨鿪飬鷮铰곲듴엶죸죺짼짾", a_), global::CommonResources.AcgResources.ID_OUTPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPOutputFeature_A21346LovStrs);
			this.dEKVIPOutputFeature_A21346.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKVIPOutputFeature_A21346.DataTransferOrder = 14;
			this.dEKVIPOutputFeature_A21346.ValidateAcrossRecset = true;
			this.dEKVIPButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖鯘껚꧜ꯞ軠跢뛤迦蛨駪駬뿮菰雲蛴蓶그鋺郼髾", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.dEKVIPButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKVIPButtonShortPressTime.DataTransferOrder = -1;
			this.dEKVIPButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.dEKVIPButtonShortPressTime.ShowHexValue = false;
			this.dEKVIPButtonShortPressTime.ValidateAcrossRecset = true;
			this.dEKVIPButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("觌諎髐藒鳔蟖鯘껚꧜ꯞ軠跢ꧤ裦蟨質뷬鷮铰胲蛴ꏶ郸雺飼", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.dEKVIPButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKVIPButtonLongPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.dEKVIPButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.dEKVIPButtonLongPressTime.ShowHexValue = false;
			this.dEKVIPButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觌諎髐菔黖觘", a_);
			base.Id = 10206;
			base.UIName = global::CommonResources.AcgResources.ID_DEKVIP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x00746ED4 File Offset: 0x007450D4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)407175190;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dEKVIPName_A22574 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DEKAVIP1, this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍黏돑맓돕蟗鯙헟헡탣", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.dEKVIPName_A22574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKVIPName_A22574.DataTransferOrder = -1;
					num = (short)130351116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍駏병ꓓꏕ곗飙鿛針뿟ꏡ훣ퟥ\udbe7\ud9e9\udbeb", a_)))
					{
						num = (short)851771418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍黏돑맓돕蟗鯙헟헡탣", a_)))
					{
						num = (short)1664155648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍駏병ꓓꏕ곗鳙맛뿝铟韡難菥럧ꯩ\udeeb\udfed쏯쇱쳳", a_)))
					{
						num = (short)2056912923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_513;
				case 4:
					this.dEKVIPButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鋏ꟑꃓꋕ럗듙进뛝迟郡郣뛥髧迩鿫鷭ꓯ鯱駳鏵", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.dEKVIPButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKVIPButtonShortPressTime.DataTransferOrder = -1;
					this.dEKVIPButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.dEKVIPButtonShortPressTime.ShowHexValue = false;
					this.dEKVIPButtonShortPressTime.ValidateAcrossRecset = true;
					num = (short)1608318981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_321;
				case 6:
					goto IL_101;
				case 7:
					goto IL_184;
				case 8:
					goto IL_36D;
				case 9:
					num = (short)1341390863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鋏ꟑꃓꋕ럗듙郛뇝軟藡듣铥跧駩鿫뫭駯鿱釳", a_)))
					{
						num = (short)1794899988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_791;
				case 11:
					goto IL_50E;
				case 12:
					goto IL_EA;
				case 13:
				{
					num = (short)692083207;
					short num3 = num;
					num = (short)1979341319;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num = (short)2067988480;
						if (num != 0)
						{
						}
						this.dEKVIPOutputBCO_A21347 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPOutputBCO_A21347LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPOutputBCO_A21347LovStrs), this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鿏ꟑꃓꛕ귗껙黛鷝꿟뷡ꗣ퓥\ud9e7\ud9e9\ud8eb\ud9ed", a_), global::CommonResources.AcgResources.ID_OUTPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPOutputBCO_A21347LovStrs);
						this.dEKVIPOutputBCO_A21347.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.dEKVIPOutputBCO_A21347.DataTransferOrder = -1;
						num = (short)656343048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鿏ꟑꃓꛕ귗껙黛鷝꿟뷡ꗣ퓥\ud9e7\ud9e9\ud8eb\ud9ed", a_)))
					{
						num = (short)12451853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36D;
				case 15:
					if (producerFields != null)
					{
						num = (short)1851719696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_791;
				case 16:
					num = (short)961806337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_431;
				case 18:
				{
					this.dEKVIPKey_A22573 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鯏럑귓觕駗ퟟ퇡", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.dEKVIPKey_A22573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKVIPKey_A22573.DataTransferOrder = -1;
					num = (short)127205376;
					short num4 = num;
					num = (short)461570073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鋏ꟑꃓꋕ럗듙进뛝迟郡郣뛥髧迩鿫鷭ꓯ鯱駳鏵", a_)))
					{
						num = (short)1170276356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_321;
				case 20:
					this.dEKVIPButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鋏ꟑꃓꋕ럗듙郛뇝軟藡듣铥跧駩鿫뫭駯鿱釳", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.dEKVIPButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKVIPButtonLongPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.dEKVIPButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.dEKVIPButtonLongPressTime.ShowHexValue = false;
					this.dEKVIPButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)16973835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.dEKVIPOutputFeature_A21346 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPOutputFeature_A21346LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPOutputFeature_A21346LovStrs), this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鿏ꟑꃓꛕ귗껙髛믝臟雡釣铥跧뗩귫\udced쇯쇱샳샵", a_), global::CommonResources.AcgResources.ID_OUTPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPOutputFeature_A21346LovStrs);
					this.dEKVIPOutputFeature_A21346.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKVIPOutputFeature_A21346.DataTransferOrder = 14;
					this.dEKVIPOutputFeature_A21346.ValidateAcrossRecset = true;
					num = (short)1991442449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					continue;
				case 23:
					goto IL_513;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鯏럑귓觕駗ퟟ퇡", a_)))
					{
						num = (short)431620114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 25:
					goto IL_137;
				case 26:
					this.dEKVIPInputBCO_A21337 = new global::AcpBusinessLayer.AcpSparseLOVField(19, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPInputBCO_A21337LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPInputBCO_A21337LovStrs), this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍駏병ꓓꏕ곗飙鿛針뿟ꏡ훣ퟥ\udbe7\ud9e9\udbeb", a_), global::CommonResources.AcgResources.ID_INPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPInputBCO_A21337LovStrs);
					this.dEKVIPInputBCO_A21337.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKVIPInputBCO_A21337.DataTransferOrder = -1;
					num = (short)141099015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.dEKVIPInputFeature_A21338 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKVIPInputFeature_A21338LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKVIPInputFeature_A21338LovStrs), this, global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍駏병ꓓꏕ곗鳙맛뿝铟韡難菥럧ꯩ\udeeb\udfed쏯쇱쳳", a_), global::CommonResources.AcgResources.ID_INPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKVIPInputFeature_A21338LovStrs);
					this.dEKVIPInputFeature_A21338.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKVIPInputFeature_A21338.DataTransferOrder = 18;
					this.dEKVIPInputFeature_A21338.ValidateAcrossRecset = true;
					num = (short)1218314263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9E:
				num = (short)1661075457;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)257163273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_EA:
				num = (short)1693450246;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_101:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃菅菇鳉藋黍鿏ꟑꃓꛕ귗껙髛믝臟雡釣铥跧뗩귫\udced쇯쇱샳샵", a_)))
				{
					num = (short)409993237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_431;
				IL_137:
				num = (short)1033568258;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_184:
				num = (short)608043011;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_321:
				num = (short)1353383946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36D:
				num = (short)1184104472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_431:
				num = (short)6029331;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_513:
				num = (short)1492451342;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_50E:
			IL_791:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃菅菇髋蟍胏", a_);
			base.Id = 10206;
			base.UIName = global::CommonResources.AcgResources.ID_DEKVIP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x007476A4 File Offset: 0x007458A4
		public override void PopulateReferences()
		{
			short num = (short)364511232;
			short num2 = num;
			num = (short)1746138056;
			short num3 = num;
			num = (short)1225061320;
			switch (num3 == num)
			{
			}
			num = (short)1841364992;
			if (num != 0)
			{
			}
			num = (short)980484097;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x00747754 File Offset: 0x00745954
		public override void DropReferences()
		{
			short num = (short)1187905536;
			short num2 = num;
			num = (short)388571497;
			short num3 = num;
			num = (short)1598300521;
			switch (num3 == num)
			{
			}
			num = (short)225181697;
			if (num != 0)
			{
			}
			num = (short)79495168;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x007477FC File Offset: 0x007459FC
		public override void SetConstraints()
		{
			short num = (short)1043595264;
			short num2 = num;
			num = (short)209122191;
			short num3 = num;
			num = (short)302576527;
			switch (num3 == num)
			{
			}
			num = (short)564199424;
			if (num != 0)
			{
			}
			num = (short)739770369;
			if (num != 0)
			{
			}
			this.dEKVIPInputBCO_A21337.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKVIP);
			this.dEKVIPInputFeature_A21338.ValidateAcrossRecset = true;
			this.dEKVIPInputFeature_A21338.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKVIP);
			this.dEKVIPInputFeature_A21338.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.conDEKInputSelectionsIsValid);
			this.dEKVIPInputFeature_A21338.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKVIPEditbl);
			this.dEKVIPOutputBCO_A21347.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKVIP);
			this.dEKVIPKey_A22573.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKVIP);
			this.dEKVIPName_A22574.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.dEKVIPOutputFeature_A21346.ValidateAcrossRecset = true;
			this.dEKVIPOutputFeature_A21346.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKVIPForR4);
			this.dEKVIPOutputFeature_A21346.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConEmerAlrmRxIndicTypeNotNoIndicAndVipOutFeatureIsEmergencyAlarmRx);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x00747990 File Offset: 0x00745B90
		public override void SetupDependencies()
		{
			short num = (short)787152896;
			short num2 = num;
			num = (short)1595531494;
			short num3 = num;
			num = (short)1807343846;
			switch (num3 == num)
			{
			}
			num = (short)671481856;
			if (num != 0)
			{
			}
			num = (short)907411457;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK dek = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK;
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKVIPInputBCO_A21337);
			this.dEKVIPName_A22574.AddDependentObject(this.dEKVIPInputBCO_A21337);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKVIPInputFeature_A21338);
			this.dEKVIPName_A22574.AddDependentObject(this.dEKVIPInputFeature_A21338);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.dEKVIPInputFeature_A21338);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedConsoletteEnable_A37231.AddDependentObject(this.dEKVIPInputFeature_A21338);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dEKVIPInputFeature_A21338);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKVIPOutputBCO_A21347);
			this.dEKVIPName_A22574.AddDependentObject(this.dEKVIPOutputBCO_A21347);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKVIPKey_A22573);
			this.dEKVIPName_A22574.AddDependentObject(this.dEKVIPKey_A22573);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKVIPOutputFeature_A21346);
			this.dEKVIPName_A22574.AddDependentObject(this.dEKVIPOutputFeature_A21346);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.dEKVIPOutputFeature_A21346);
			this.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.AddDependentObject(this.dEKVIPOutputFeature_A21346);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedConsoletteEnable_A37231.AddDependentObject(this.dEKVIPOutputFeature_A21346);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dEKVIPOutputFeature_A21346);
			this.dEKVIPInputFeature_A21338.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10225] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren).RadErgoWidePASirenSirenPAAfterReset_A9140);
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x06007E54 RID: 32340 RVA: 0x00747C10 File Offset: 0x00745E10
		public bool HasDiffs
		{
			get
			{
				short num = (short)1036492386;
				short num2 = num;
				num = (short)1465097826;
				switch (num2 == num)
				{
				}
				num = (short)592904192;
				if (num != 0)
				{
				}
				num = (short)468975617;
				if (num != 0)
				{
				}
				num = (short)1779564544;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x06007E55 RID: 32341 RVA: 0x00747CC0 File Offset: 0x00745EC0
		// (set) Token: 0x06007E56 RID: 32342 RVA: 0x00747D74 File Offset: 0x00745F74
		public int DEKVIPInputBCO_A21337Value
		{
			get
			{
				short num = (short)538051940;
				short num2 = num;
				num = (short)745669988;
				switch (num2 == num)
				{
				}
				num = (short)1810235393;
				if (num != 0)
				{
				}
				num = (short)345374720;
				if (num != 0)
				{
				}
				num = (short)1013907456;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.Value;
			}
			set
			{
				short num = (short)78698684;
				short num2 = num;
				num = (short)1924716732;
				switch (num2 == num)
				{
				}
				num = (short)144113665;
				if (num != 0)
				{
				}
				num = (short)434831360;
				if (num != 0)
				{
				}
				num = (short)69468160;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.Value = value;
			}
		}

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x00747E2C File Offset: 0x0074602C
		// (set) Token: 0x06007E58 RID: 32344 RVA: 0x00747EE0 File Offset: 0x007460E0
		public string DEKVIPInputBCO_A21337_UIValue
		{
			get
			{
				short num = (short)1489872304;
				short num2 = num;
				num = (short)423601584;
				switch (num2 == num)
				{
				}
				num = (short)1858863105;
				if (num != 0)
				{
				}
				num = (short)1122631680;
				if (num != 0)
				{
				}
				num = (short)1215299584;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.UIValue;
			}
			set
			{
				short num = (short)1745074397;
				short num2 = num;
				num = (short)1809955037;
				switch (num2 == num)
				{
				}
				num = (short)1291517953;
				if (num != 0)
				{
				}
				num = (short)1313603584;
				if (num != 0)
				{
				}
				num = (short)1401749504;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.UIValue = value;
			}
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x06007E59 RID: 32345 RVA: 0x00747F98 File Offset: 0x00746198
		public global::AcpBusinessLayer.AcpListField DEKVIPInputBCO_A21337
		{
			get
			{
				short num = (short)997514774;
				short num2 = num;
				num = (short)48487958;
				switch (num2 == num)
				{
				}
				num = (short)476839936;
				if (num != 0)
				{
				}
				num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)1728380928;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337;
			}
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x06007E5A RID: 32346 RVA: 0x00748048 File Offset: 0x00746248
		// (set) Token: 0x06007E5B RID: 32347 RVA: 0x007480FC File Offset: 0x007462FC
		public bool DEKVIPInputBCO_A21337_Applicable
		{
			get
			{
				short num = (short)1906236703;
				short num2 = num;
				num = (short)334421279;
				switch (num2 == num)
				{
				}
				num = (short)524681216;
				if (num != 0)
				{
				}
				num = (short)1470431233;
				if (num != 0)
				{
				}
				num = (short)791937024;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.Applicable;
			}
			set
			{
				short num = (short)1852788459;
				short num2 = num;
				num = (short)641224427;
				switch (num2 == num)
				{
				}
				num = (short)686817281;
				if (num != 0)
				{
				}
				num = (short)162529280;
				if (num != 0)
				{
				}
				num = (short)1663696896;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.Applicable = value;
			}
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x007481B4 File Offset: 0x007463B4
		// (set) Token: 0x06007E5D RID: 32349 RVA: 0x00748268 File Offset: 0x00746468
		public bool DEKVIPInputBCO_A21337_Valid
		{
			get
			{
				short num = (short)698800131;
				short num2 = num;
				num = (short)32364547;
				switch (num2 == num)
				{
				}
				num = (short)1165426689;
				if (num != 0)
				{
				}
				num = (short)372310016;
				if (num != 0)
				{
				}
				num = (short)1492582400;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.Valid;
			}
			set
			{
				short num = (short)414242592;
				short num2 = num;
				num = (short)1420744480;
				switch (num2 == num)
				{
				}
				num = (short)836370433;
				if (num != 0)
				{
				}
				num = (short)1304756224;
				if (num != 0)
				{
				}
				num = (short)1163329536;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.Valid = value;
			}
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x00748320 File Offset: 0x00746520
		// (set) Token: 0x06007E5F RID: 32351 RVA: 0x007483D8 File Offset: 0x007465D8
		public bool DEKVIPInputBCO_A21337_Visible
		{
			get
			{
				short num = (short)1529020417;
				if (num != 0)
				{
				}
				num = (short)1531779721;
				short num2 = num;
				num = (short)437918345;
				switch (num2 == num)
				{
				}
				num = (short)731774976;
				if (num != 0)
				{
				}
				num = (short)1755250688;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.Visible;
			}
			set
			{
				short num = (short)752409707;
				short num2 = num;
				num = (short)1277287531;
				switch (num2 == num)
				{
				}
				num = (short)2035679232;
				if (num != 0)
				{
				}
				num = (short)1367212033;
				if (num != 0)
				{
				}
				num = (short)5308416;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.Visible = value;
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x06007E60 RID: 32352 RVA: 0x0074848C File Offset: 0x0074668C
		// (set) Token: 0x06007E61 RID: 32353 RVA: 0x00748540 File Offset: 0x00746740
		public bool DEKVIPInputBCO_A21337_Editable
		{
			get
			{
				short num = (short)831240606;
				short num2 = num;
				num = (short)1721350558;
				switch (num2 == num)
				{
				}
				num = (short)647692289;
				if (num != 0)
				{
				}
				num = (short)366477312;
				if (num != 0)
				{
				}
				num = (short)858849280;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.Editable;
			}
			set
			{
				short num = (short)1375351923;
				short num2 = num;
				num = (short)34026611;
				switch (num2 == num)
				{
				}
				num = (short)1563295745;
				if (num != 0)
				{
				}
				num = (short)466354176;
				if (num != 0)
				{
				}
				num = (short)501743616;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.Editable = value;
			}
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x06007E62 RID: 32354 RVA: 0x007485F4 File Offset: 0x007467F4
		internal string DEKVIPInputBCO_A21337_UILabel
		{
			get
			{
				short num = (short)1235221213;
				short num2 = num;
				num = (short)1890384605;
				switch (num2 == num)
				{
				}
				num = (short)345571329;
				if (num != 0)
				{
				}
				num = (short)1403781120;
				if (num != 0)
				{
				}
				num = (short)685113344;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.UIName;
			}
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x007486A4 File Offset: 0x007468A4
		// (set) Token: 0x06007E64 RID: 32356 RVA: 0x00748758 File Offset: 0x00746958
		internal bool DEKVIPInputBCO_A21337_HiddenStatic
		{
			get
			{
				short num = (short)940823587;
				short num2 = num;
				num = (short)425382947;
				switch (num2 == num)
				{
				}
				num = (short)1668677633;
				if (num != 0)
				{
				}
				num = (short)1271332864;
				if (num != 0)
				{
				}
				num = (short)1918238720;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.HiddenStatic;
			}
			set
			{
				short num = (short)768850499;
				short num2 = num;
				num = (short)1550105155;
				switch (num2 == num)
				{
				}
				num = (short)1485897729;
				if (num != 0)
				{
				}
				num = (short)2134638592;
				if (num != 0)
				{
				}
				num = (short)208601088;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.HiddenStatic = value;
			}
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x00748810 File Offset: 0x00746A10
		// (set) Token: 0x06007E66 RID: 32358 RVA: 0x007488C4 File Offset: 0x00746AC4
		internal bool DEKVIPInputBCO_A21337_HiddenDynamic
		{
			get
			{
				short num = (short)1260269863;
				short num2 = num;
				num = (short)2046570791;
				switch (num2 == num)
				{
				}
				num = (short)1282867201;
				if (num != 0)
				{
				}
				num = (short)1115619328;
				if (num != 0)
				{
				}
				num = (short)2134441984;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337.HiddenDynamic;
			}
			set
			{
				short num = (short)235470849;
				if (num != 0)
				{
				}
				num = (short)1649155983;
				short num2 = num;
				num = (short)895885199;
				switch (num2 == num)
				{
				}
				num = (short)1518796800;
				if (num != 0)
				{
				}
				num = (short)779485184;
				short num3 = num;
				this.dEKVIPInputBCO_A21337.HiddenDynamic = value;
			}
		}

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x06007E67 RID: 32359 RVA: 0x0074897C File Offset: 0x00746B7C
		public bool DEKVIPInputBCO_A21337_HasDiffs
		{
			get
			{
				short num = (short)260308993;
				if (num != 0)
				{
				}
				num = (short)127961191;
				short num2 = num;
				num = (short)1176340583;
				switch (num2 == num)
				{
				}
				num = (short)319553536;
				if (num != 0)
				{
				}
				num = (short)31457280;
				short num3 = num;
				return this.dEKVIPInputBCO_A21337._HasDiffs;
			}
		}

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x06007E68 RID: 32360 RVA: 0x00748A34 File Offset: 0x00746C34
		// (set) Token: 0x06007E69 RID: 32361 RVA: 0x00748AEC File Offset: 0x00746CEC
		public int DEKVIPInputFeature_A21338Value
		{
			get
			{
				short num = (short)229678150;
				short num2 = num;
				num = (short)936483910;
				switch (num2 == num)
				{
				}
				num = (short)1546190848;
				if (num != 0)
				{
				}
				num = (short)715325441;
				if (num != 0)
				{
				}
				num = (short)1698103296;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.Value;
			}
			set
			{
				short num = (short)229244929;
				if (num != 0)
				{
				}
				num = (short)332990901;
				short num2 = num;
				num = (short)225642933;
				switch (num2 == num)
				{
				}
				num = (short)1877999616;
				if (num != 0)
				{
				}
				num = (short)261750784;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.Value = value;
			}
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x00748BA0 File Offset: 0x00746DA0
		// (set) Token: 0x06007E6B RID: 32363 RVA: 0x00748C54 File Offset: 0x00746E54
		public string DEKVIPInputFeature_A21338_UIValue
		{
			get
			{
				short num = (short)30440891;
				short num2 = num;
				num = (short)610958779;
				switch (num2 == num)
				{
				}
				num = (short)1676214272;
				if (num != 0)
				{
				}
				num = (short)245563393;
				if (num != 0)
				{
				}
				num = (short)249757696;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.UIValue;
			}
			set
			{
				short num = (short)1542312686;
				short num2 = num;
				num = (short)2009912046;
				switch (num2 == num)
				{
				}
				num = (short)1245773824;
				if (num != 0)
				{
				}
				num = (short)1833435137;
				if (num != 0)
				{
				}
				num = (short)1897201664;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.UIValue = value;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x00748D08 File Offset: 0x00746F08
		public global::AcpBusinessLayer.AcpListField DEKVIPInputFeature_A21338
		{
			get
			{
				short num = (short)1548746716;
				short num2 = num;
				num = (short)764805084;
				switch (num2 == num)
				{
				}
				num = (short)1793458177;
				if (num != 0)
				{
				}
				num = (short)1338310656;
				if (num != 0)
				{
				}
				num = (short)1530855424;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338;
			}
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x00748DB8 File Offset: 0x00746FB8
		// (set) Token: 0x06007E6E RID: 32366 RVA: 0x00748E6C File Offset: 0x0074706C
		public bool DEKVIPInputFeature_A21338_Applicable
		{
			get
			{
				short num = (short)1885410033;
				short num2 = num;
				num = (short)1681134321;
				switch (num2 == num)
				{
				}
				num = (short)1615659008;
				if (num != 0)
				{
				}
				num = (short)2124939265;
				if (num != 0)
				{
				}
				num = (short)159186944;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.Applicable;
			}
			set
			{
				short num = (short)347275265;
				if (num != 0)
				{
				}
				num = (short)501154783;
				short num2 = num;
				num = (short)73073631;
				switch (num2 == num)
				{
				}
				num = (short)750583808;
				if (num != 0)
				{
				}
				num = (short)466157568;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.Applicable = value;
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x06007E6F RID: 32367 RVA: 0x00748F24 File Offset: 0x00747124
		// (set) Token: 0x06007E70 RID: 32368 RVA: 0x00748FD8 File Offset: 0x007471D8
		public bool DEKVIPInputFeature_A21338_Valid
		{
			get
			{
				short num = (short)928011;
				short num2 = num;
				num = (short)1496525067;
				switch (num2 == num)
				{
				}
				num = (short)632684544;
				if (num != 0)
				{
				}
				num = (short)346816513;
				if (num != 0)
				{
				}
				num = (short)1170538496;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.Valid;
			}
			set
			{
				short num = (short)1289681979;
				short num2 = num;
				num = (short)732232763;
				switch (num2 == num)
				{
				}
				num = (short)130285569;
				if (num != 0)
				{
				}
				num = (short)1897660416;
				if (num != 0)
				{
				}
				num = (short)244973568;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.Valid = value;
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x0074908C File Offset: 0x0074728C
		// (set) Token: 0x06007E72 RID: 32370 RVA: 0x00749140 File Offset: 0x00747340
		public bool DEKVIPInputFeature_A21338_Visible
		{
			get
			{
				short num = (short)752260650;
				short num2 = num;
				num = (short)740005418;
				switch (num2 == num)
				{
				}
				num = (short)603652096;
				if (num != 0)
				{
				}
				num = (short)848625665;
				if (num != 0)
				{
				}
				num = (short)1478492160;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.Visible;
			}
			set
			{
				short num = (short)2046476290;
				short num2 = num;
				num = (short)1381941250;
				switch (num2 == num)
				{
				}
				num = (short)1328283649;
				if (num != 0)
				{
				}
				num = (short)179503104;
				if (num != 0)
				{
				}
				num = (short)983891968;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.Visible = value;
			}
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x06007E73 RID: 32371 RVA: 0x007491F4 File Offset: 0x007473F4
		// (set) Token: 0x06007E74 RID: 32372 RVA: 0x007492A8 File Offset: 0x007474A8
		public bool DEKVIPInputFeature_A21338_Editable
		{
			get
			{
				short num = (short)456604604;
				short num2 = num;
				num = (short)369966012;
				switch (num2 == num)
				{
				}
				num = (short)1683750912;
				if (num != 0)
				{
				}
				num = (short)594608129;
				if (num != 0)
				{
				}
				num = (short)1191444480;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.Editable;
			}
			set
			{
				short num = (short)560801820;
				short num2 = num;
				num = (short)911157276;
				switch (num2 == num)
				{
				}
				num = (short)564920320;
				if (num != 0)
				{
				}
				num = (short)1478230017;
				if (num != 0)
				{
				}
				num = (short)557842432;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.Editable = value;
			}
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x06007E75 RID: 32373 RVA: 0x0074935C File Offset: 0x0074755C
		internal string DEKVIPInputFeature_A21338_UILabel
		{
			get
			{
				short num = (short)99590117;
				short num2 = num;
				num = (short)1766629349;
				switch (num2 == num)
				{
				}
				num = (short)793640961;
				if (num != 0)
				{
				}
				num = (short)1033568256;
				if (num != 0)
				{
				}
				num = (short)1473708032;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.UIName;
			}
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x06007E76 RID: 32374 RVA: 0x00749410 File Offset: 0x00747610
		// (set) Token: 0x06007E77 RID: 32375 RVA: 0x007494C4 File Offset: 0x007476C4
		internal bool DEKVIPInputFeature_A21338_HiddenStatic
		{
			get
			{
				short num = (short)346046995;
				short num2 = num;
				num = (short)1251557907;
				switch (num2 == num)
				{
				}
				num = (short)1568407553;
				if (num != 0)
				{
				}
				num = (short)1068761088;
				if (num != 0)
				{
				}
				num = (short)492240896;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.HiddenStatic;
			}
			set
			{
				short num = (short)1802576193;
				short num2 = num;
				num = (short)1839997249;
				switch (num2 == num)
				{
				}
				num = (short)1111097345;
				if (num != 0)
				{
				}
				num = (short)1048576000;
				if (num != 0)
				{
				}
				num = (short)890044416;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.HiddenStatic = value;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x06007E78 RID: 32376 RVA: 0x00749578 File Offset: 0x00747778
		// (set) Token: 0x06007E79 RID: 32377 RVA: 0x0074962C File Offset: 0x0074782C
		internal bool DEKVIPInputFeature_A21338_HiddenDynamic
		{
			get
			{
				short num = (short)1585593459;
				short num2 = num;
				num = (short)1881554035;
				switch (num2 == num)
				{
				}
				num = (short)54853633;
				if (num != 0)
				{
				}
				num = (short)1003094016;
				if (num != 0)
				{
				}
				num = (short)1542914048;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338.HiddenDynamic;
			}
			set
			{
				short num = (short)196673537;
				if (num != 0)
				{
				}
				num = (short)251664003;
				short num2 = num;
				num = (short)433985155;
				switch (num2 == num)
				{
				}
				num = (short)1004994560;
				if (num != 0)
				{
				}
				num = (short)54984704;
				short num3 = num;
				this.dEKVIPInputFeature_A21338.HiddenDynamic = value;
			}
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x007496E0 File Offset: 0x007478E0
		public bool DEKVIPInputFeature_A21338_HasDiffs
		{
			get
			{
				short num = (short)1922256490;
				short num2 = num;
				num = (short)807095914;
				switch (num2 == num)
				{
				}
				num = (short)1595015169;
				if (num != 0)
				{
				}
				num = (short)1690304512;
				if (num != 0)
				{
				}
				num = (short)1821769728;
				short num3 = num;
				return this.dEKVIPInputFeature_A21338._HasDiffs;
			}
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x06007E7B RID: 32379 RVA: 0x00749794 File Offset: 0x00747994
		// (set) Token: 0x06007E7C RID: 32380 RVA: 0x00749848 File Offset: 0x00747A48
		public int DEKVIPOutputBCO_A21347Value
		{
			get
			{
				short num = (short)2146107393;
				if (num != 0)
				{
				}
				num = (short)1975395875;
				short num2 = num;
				num = (short)83240483;
				switch (num2 == num)
				{
				}
				num = (short)1400700928;
				if (num != 0)
				{
				}
				num = (short)316801024;
				short num3 = num;
				return this.dEKVIPOutputBCO_A21347.Value;
			}
			set
			{
				short num = (short)451526937;
				short num2 = num;
				num = (short)144490777;
				switch (num2 == num)
				{
				}
				num = (short)1181876225;
				if (num != 0)
				{
				}
				num = (short)1706754048;
				if (num != 0)
				{
				}
				num = (short)1879572480;
				short num3 = num;
				this.dEKVIPOutputBCO_A21347.Value = value;
			}
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x06007E7D RID: 32381 RVA: 0x007498FC File Offset: 0x00747AFC
		// (set) Token: 0x06007E7E RID: 32382 RVA: 0x007499B0 File Offset: 0x00747BB0
		public string DEKVIPOutputBCO_A21347_UIValue
		{
			get
			{
				short num = (short)1215327193;
				short num2 = num;
				num = (short)1853385689;
				switch (num2 == num)
				{
				}
				num = (short)1362952193;
				if (num != 0)
				{
				}
				num = (short)1150812160;
				if (num != 0)
				{
				}
				num = (short)534249472;
				short num3 = num;
				return this.dEKVIPOutputBCO_A21347.UIValue;
			}
			set
			{
				short num = (short)341806935;
				short num2 = num;
				num = (short)899714903;
				switch (num2 == num)
				{
				}
				num = (short)2097610753;
				if (num != 0)
				{
				}
				num = (short)269221888;
				if (num != 0)
				{
				}
				num = (short)1598619648;
				short num3 = num;
				this.dEKVIPOutputBCO_A21347.UIValue = value;
			}
		}

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x06007E7F RID: 32383 RVA: 0x00749A68 File Offset: 0x00747C68
		public global::AcpBusinessLayer.AcpListField DEKVIPOutputBCO_A21347
		{
			get
			{
				short num = (short)518319541;
				short num2 = num;
				num = (short)1086844341;
				switch (num2 == num)
				{
				}
				num = (short)46661632;
				if (num != 0)
				{
				}
				num = (short)861798401;
				if (num != 0)
				{
				}
				num = (short)1037107200;
				short num3 = num;
				return this.dEKVIPOutputBCO_A21347;
			}
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x06007E80 RID: 32384 RVA: 0x00749B18 File Offset: 0x00747D18
		// (set) Token: 0x06007E81 RID: 32385 RVA: 0x00749BD0 File Offset: 0x00747DD0
		public bool DEKVIPOutputBCO_A21347_Applicable
		{
			get
			{
				short num = (short)1341611900;
				short num2 = num;
				num = (short)810704764;
				switch (num2 == num)
				{
				}
				num = (short)1977155585;
				if (num != 0)
				{
				}
				num = (short)791609344;
				if (num != 0)
				{
				}
				num = (short)310116352;
				short num3 = num;
				return this.dEKVIPOutputBCO_A21347.Applicable;
			}
			set
			{
				short num = (short)1416333890;
				short num2 = num;
				num = (short)384993858;
				switch (num2 == num)
				{
				}
				num = (short)326434817;
				if (num != 0)
				{
				}
				num = (short)1633812480;
				if (num != 0)
				{
				}
				num = (short)774701056;
				short num3 = num;
				this.dEKVIPOutputBCO_A21347.Applicable = value;
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x06007E82 RID: 32386 RVA: 0x00749C88 File Offset: 0x00747E88
		// (set) Token: 0x06007E83 RID: 32387 RVA: 0x00749D3C File Offset: 0x00747F3C
		public bool DEKVIPOutputBCO_A21347_Valid
		{
			get
			{
				short num = (short)1456747241;
				short num2 = num;
				num = (short)330576617;
				switch (num2 == num)
				{
				}
				num = (short)330891265;
				if (num != 0)
				{
				}
				num = (short)1335033856;
				if (num != 0)
				{
				}
				num = (short)252182528;
				short num3 = num;
				return this.dEKVIPOutputBCO_A21347.Valid;
			}
			set
			{
				short num = (short)1812981550;
				short num2 = num;
				num = (short)1982654254;
				switch (num2 == num)
				{
				}
				num = (short)1259274241;
				if (num != 0)
				{
				}
				num = (short)1364590592;
				if (num != 0)
				{
				}
				num = (short)1241972736;
				short num3 = num;
				this.dEKVIPOutputBCO_A21347.Valid = value;
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x00749DF0 File Offset: 0x00747FF0
		// (set) Token: 0x06007E85 RID: 32389 RVA: 0x00749EA8 File Offset: 0x007480A8
		public bool DEKVIPOutputBCO_A21347_Visible
		{
			get
			{
				short num = (short)1008290675;
				short num2 = num;
				num = (short)1597131635;
				switch (num2 == num)
				{
				}
				num = (short)1863581697;
				if (num != 0)
				{
				}
				num = (short)1816854528;
				if (num != 0)
				{
				}
				num = (short)1967915008;
				short num3 = num;
				return this.dEKVIPOutputBCO_A21347.Visible;
			}
			set
			{
				short num = (short)1173029636;
				short num2 = num;
				num = (short)1328939780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301676032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)942276608;
				if (num != 0)
				{
				}
				num = (short)1491271681;
				if (num != 0)
				{
				}
				this.dEKVIPOutputBCO_A21347.Visible = value;
			}
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x00749F5C File Offset: 0x0074815C
		// (set) Token: 0x06007E87 RID: 32391 RVA: 0x0074A014 File Offset: 0x00748214
		public bool DEKVIPOutputBCO_A21347_Editable
		{
			get
			{
				short num = (short)161587139;
				short num2 = num;
				num = (short)249012163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)915144704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095368705;
				if (num != 0)
				{
				}
				num = (short)567672832;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputBCO_A21347.Editable;
			}
			set
			{
				short num = (short)1145160353;
				short num2 = num;
				num = (short)624804513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)575733760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996868096;
				if (num != 0)
				{
				}
				num = (short)2024472577;
				if (num != 0)
				{
				}
				this.dEKVIPOutputBCO_A21347.Editable = value;
			}
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x0074A0C8 File Offset: 0x007482C8
		internal string DEKVIPOutputBCO_A21347_UILabel
		{
			get
			{
				short num = (short)1118831065;
				short num2 = num;
				num = (short)489161177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925040640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099235329;
				if (num != 0)
				{
				}
				num = (short)1832583168;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputBCO_A21347.UIName;
			}
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x06007E89 RID: 32393 RVA: 0x0074A17C File Offset: 0x0074837C
		// (set) Token: 0x06007E8A RID: 32394 RVA: 0x0074A230 File Offset: 0x00748430
		internal bool DEKVIPOutputBCO_A21347_HiddenStatic
		{
			get
			{
				short num = (short)626879272;
				short num2 = num;
				num = (short)1381985064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1736441856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)346750976;
				if (num != 0)
				{
				}
				num = (short)1746272257;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputBCO_A21347.HiddenStatic;
			}
			set
			{
				short num = (short)1105526785;
				if (num != 0)
				{
				}
				num = (short)105971712;
				short num2 = num;
				num = (short)703808672;
				short num3 = num;
				num = (short)1103053984;
				switch (num3 == num)
				{
				}
				num = (short)1117585408;
				if (num != 0)
				{
				}
				this.dEKVIPOutputBCO_A21347.HiddenStatic = value;
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x06007E8B RID: 32395 RVA: 0x0074A2E4 File Offset: 0x007484E4
		// (set) Token: 0x06007E8C RID: 32396 RVA: 0x0074A398 File Offset: 0x00748598
		internal bool DEKVIPOutputBCO_A21347_HiddenDynamic
		{
			get
			{
				short num = (short)1714656429;
				short num2 = num;
				num = (short)1301648557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)748748800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391656961;
				if (num != 0)
				{
				}
				num = (short)1017905152;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputBCO_A21347.HiddenDynamic;
			}
			set
			{
				short num = (short)646547368;
				short num2 = num;
				num = (short)1067747240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)49872896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892876289;
				if (num != 0)
				{
				}
				num = (short)812515328;
				if (num != 0)
				{
				}
				this.dEKVIPOutputBCO_A21347.HiddenDynamic = value;
			}
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x06007E8D RID: 32397 RVA: 0x0074A450 File Offset: 0x00748650
		public bool DEKVIPOutputBCO_A21347_HasDiffs
		{
			get
			{
				short num = (short)1617102286;
				short num2 = num;
				num = (short)1698629070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15204352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794492928;
				if (num != 0)
				{
				}
				num = (short)523501569;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputBCO_A21347._HasDiffs;
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x0074A508 File Offset: 0x00748708
		// (set) Token: 0x06007E8F RID: 32399 RVA: 0x0074A5B8 File Offset: 0x007487B8
		public string DEKVIPKey_A22573Value
		{
			get
			{
				short num = (short)54371796;
				short num2 = num;
				num = (short)442148308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012006912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642135553;
				if (num != 0)
				{
				}
				num = (short)1760821248;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.Value;
			}
			set
			{
				short num = (short)309002240;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
					{
						num = (short)936814059;
						short num3 = num;
						num = (short)1365288427;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)192675840;
							if (num != 0)
							{
							}
							num = (short)1354432513;
							if (num != 0)
							{
							}
							this.dEKVIPKey_A22573.Value = value;
							num = (short)973340672;
							short num4 = num;
							num = (short)901251074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						return;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)381485057;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x0074A6E0 File Offset: 0x007488E0
		// (set) Token: 0x06007E91 RID: 32401 RVA: 0x0074A794 File Offset: 0x00748994
		public string DEKVIPKey_A22573_UIValue
		{
			get
			{
				short num = (short)481810998;
				short num2 = num;
				num = (short)2044779062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900806144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)364576768;
				if (num != 0)
				{
				}
				num = (short)2101739521;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.Value;
			}
			set
			{
				short num = (short)1610986516;
				short num2 = num;
				num = (short)389198868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)791150592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)767492097;
				if (num != 0)
				{
				}
				num = (short)907083776;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.Value = value;
			}
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x0074A84C File Offset: 0x00748A4C
		public global::AcpBusinessLayer.AcpKeyField DEKVIPKey_A22573
		{
			get
			{
				short num = (short)117440513;
				if (num != 0)
				{
				}
				num = (short)36896768;
				short num2 = num;
				num = (short)1252217519;
				short num3 = num;
				num = (short)892752559;
				switch (num3 == num)
				{
				}
				num = (short)1329004544;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573;
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x06007E93 RID: 32403 RVA: 0x0074A900 File Offset: 0x00748B00
		// (set) Token: 0x06007E94 RID: 32404 RVA: 0x0074A9B4 File Offset: 0x00748BB4
		public bool DEKVIPKey_A22573_Applicable
		{
			get
			{
				short num = (short)1339900376;
				short num2 = num;
				num = (short)82395608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965017600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1255604225;
				if (num != 0)
				{
				}
				num = (short)2070740992;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.Applicable;
			}
			set
			{
				short num = (short)1693325086;
				short num2 = num;
				num = (short)1230378782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)113704960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258815488;
				if (num != 0)
				{
				}
				num = (short)1011810305;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.Applicable = value;
			}
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x06007E95 RID: 32405 RVA: 0x0074AA6C File Offset: 0x00748C6C
		// (set) Token: 0x06007E96 RID: 32406 RVA: 0x0074AB24 File Offset: 0x00748D24
		public bool DEKVIPKey_A22573_Valid
		{
			get
			{
				short num = (short)1331224268;
				short num2 = num;
				num = (short)19259084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554055168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638401;
				if (num != 0)
				{
				}
				num = (short)544997376;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.Valid;
			}
			set
			{
				short num = (short)1702736975;
				short num2 = num;
				num = (short)645444687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1127088128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)617611264;
				if (num != 0)
				{
				}
				num = (short)279248897;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.Valid = value;
			}
		}

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x06007E97 RID: 32407 RVA: 0x0074ABDC File Offset: 0x00748DDC
		// (set) Token: 0x06007E98 RID: 32408 RVA: 0x0074AC94 File Offset: 0x00748E94
		public bool DEKVIPKey_A22573_Visible
		{
			get
			{
				short num = (short)874846649;
				short num2 = num;
				num = (short)1576147385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)70647808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40828928;
				if (num != 0)
				{
				}
				num = (short)1239285761;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.Visible;
			}
			set
			{
				short num = (short)752349792;
				short num2 = num;
				num = (short)1481044576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666697728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1127415809;
				if (num != 0)
				{
				}
				num = (short)1477115904;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.Visible = value;
			}
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x06007E99 RID: 32409 RVA: 0x0074AD48 File Offset: 0x00748F48
		// (set) Token: 0x06007E9A RID: 32410 RVA: 0x0074AE00 File Offset: 0x00749000
		public bool DEKVIPKey_A22573_Editable
		{
			get
			{
				short num = (short)2068240795;
				short num2 = num;
				num = (short)1973541275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988689920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)87359489;
				if (num != 0)
				{
				}
				num = (short)1383137280;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.Editable;
			}
			set
			{
				short num = (short)1173919664;
				short num2 = num;
				num = (short)1206359984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977548800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179896320;
				if (num != 0)
				{
				}
				num = (short)1522991105;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.Editable = value;
			}
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x06007E9B RID: 32411 RVA: 0x0074AEB4 File Offset: 0x007490B4
		internal string DEKVIPKey_A22573_UILabel
		{
			get
			{
				short num = (short)304849855;
				short num2 = num;
				num = (short)323265471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2122514432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140143617;
				if (num != 0)
				{
				}
				num = (short)1875312640;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.UIName;
			}
		}

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x06007E9C RID: 32412 RVA: 0x0074AF68 File Offset: 0x00749168
		// (set) Token: 0x06007E9D RID: 32413 RVA: 0x0074B01C File Offset: 0x0074921C
		internal bool DEKVIPKey_A22573_HiddenStatic
		{
			get
			{
				short num = (short)2030166716;
				short num2 = num;
				num = -7492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719585280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442906113;
				if (num != 0)
				{
				}
				num = (short)1740111872;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.HiddenStatic;
			}
			set
			{
				short num = (short)1599076716;
				short num2 = num;
				num = (short)1034942828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1141637120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1199898624;
				if (num != 0)
				{
				}
				num = (short)1364918273;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.HiddenStatic = value;
			}
		}

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x0074B0D0 File Offset: 0x007492D0
		// (set) Token: 0x06007E9F RID: 32415 RVA: 0x0074B184 File Offset: 0x00749384
		internal bool DEKVIPKey_A22573_HiddenDynamic
		{
			get
			{
				short num = (short)2134034253;
				short num2 = num;
				num = (short)1302382413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170983424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837615616;
				if (num != 0)
				{
				}
				num = (short)1691549697;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573.HiddenDynamic;
			}
			set
			{
				short num = (short)110755841;
				if (num != 0)
				{
				}
				num = (short)1813839872;
				short num2 = num;
				num = (short)37040236;
				short num3 = num;
				num = (short)1538404460;
				switch (num3 == num)
				{
				}
				num = (short)624558080;
				if (num != 0)
				{
				}
				this.dEKVIPKey_A22573.HiddenDynamic = value;
			}
		}

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x0074B23C File Offset: 0x0074943C
		public bool DEKVIPKey_A22573_HasDiffs
		{
			get
			{
				short num = (short)1271298653;
				short num2 = num;
				num = (short)795179613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065956864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2124742656;
				if (num != 0)
				{
				}
				num = (short)1539178497;
				if (num != 0)
				{
				}
				return this.dEKVIPKey_A22573._HasDiffs;
			}
		}

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x06007EA1 RID: 32417 RVA: 0x0074B2F4 File Offset: 0x007494F4
		// (set) Token: 0x06007EA2 RID: 32418 RVA: 0x0074B3AC File Offset: 0x007495AC
		public string DEKVIPName_A22574Value
		{
			get
			{
				short num = (short)1748471814;
				short num2 = num;
				num = (short)1432522758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081554432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)260636673;
				if (num != 0)
				{
				}
				num = (short)1133772800;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.Value;
			}
			set
			{
				short num = (short)756904817;
				short num2 = num;
				num = (short)1669362545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)718077952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844969473;
				if (num != 0)
				{
				}
				num = (short)1793261568;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.Value = value;
			}
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x06007EA3 RID: 32419 RVA: 0x0074B464 File Offset: 0x00749664
		public global::AcpBusinessLayer.AcpField<string> DEKVIPName_A22574
		{
			get
			{
				short num = (short)1504605593;
				short num2 = num;
				num = (short)634746265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2020147200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1225916417;
				if (num != 0)
				{
				}
				num = (short)1518338048;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574;
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x0074B510 File Offset: 0x00749710
		// (set) Token: 0x06007EA5 RID: 32421 RVA: 0x0074B5C4 File Offset: 0x007497C4
		public string DEKVIPName_A22574_UIValue
		{
			get
			{
				short num = (short)1180622855;
				short num2 = num;
				num = (short)1283776519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)878116864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)20840449;
				if (num != 0)
				{
				}
				num = (short)1488912384;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.Value;
			}
			set
			{
				short num = (short)693378224;
				short num2 = num;
				num = (short)2129796272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602551808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)365232129;
				if (num != 0)
				{
				}
				num = (short)228655104;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.Value = value;
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x0074B678 File Offset: 0x00749878
		// (set) Token: 0x06007EA7 RID: 32423 RVA: 0x0074B72C File Offset: 0x0074992C
		public bool DEKVIPName_A22574_Applicable
		{
			get
			{
				short num = (short)1413078424;
				short num2 = num;
				num = (short)297983384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)836108288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)257163265;
				if (num != 0)
				{
				}
				num = (short)1888419840;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.Applicable;
			}
			set
			{
				short num = (short)1063909687;
				short num2 = num;
				num = (short)1964177719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396965376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)680722433;
				if (num != 0)
				{
				}
				num = (short)1934163968;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.Applicable = value;
			}
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x06007EA8 RID: 32424 RVA: 0x0074B7E4 File Offset: 0x007499E4
		// (set) Token: 0x06007EA9 RID: 32425 RVA: 0x0074B898 File Offset: 0x00749A98
		public bool DEKVIPName_A22574_Valid
		{
			get
			{
				short num = (short)1119417959;
				short num2 = num;
				num = (short)674625127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937230336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742850561;
				if (num != 0)
				{
				}
				num = (short)979369984;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.Valid;
			}
			set
			{
				short num = (short)417267041;
				short num2 = num;
				num = (short)624033121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988231168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1702690817;
				if (num != 0)
				{
				}
				num = (short)1071710208;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.Valid = value;
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x0074B94C File Offset: 0x00749B4C
		// (set) Token: 0x06007EAB RID: 32427 RVA: 0x0074BA00 File Offset: 0x00749C00
		public bool DEKVIPName_A22574_Visible
		{
			get
			{
				short num = (short)1469463010;
				short num2 = num;
				num = (short)1124284898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140836864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)41811969;
				if (num != 0)
				{
				}
				num = (short)49283072;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.Visible;
			}
			set
			{
				short num = (short)1525809153;
				if (num != 0)
				{
				}
				num = (short)708378624;
				short num2 = num;
				num = (short)887536884;
				short num3 = num;
				num = (short)1047182580;
				switch (num3 == num)
				{
				}
				num = (short)1651113984;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.Visible = value;
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x06007EAC RID: 32428 RVA: 0x0074BAB8 File Offset: 0x00749CB8
		// (set) Token: 0x06007EAD RID: 32429 RVA: 0x0074BB6C File Offset: 0x00749D6C
		public bool DEKVIPName_A22574_Editable
		{
			get
			{
				short num = (short)2115328836;
				short num2 = num;
				num = (short)1716738884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1433206784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536294913;
				if (num != 0)
				{
				}
				num = (short)1902182400;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.Editable;
			}
			set
			{
				short num = (short)1991421286;
				short num2 = num;
				num = (short)920890726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645267456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1500250112;
				if (num != 0)
				{
				}
				num = (short)1661075457;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.Editable = value;
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x06007EAE RID: 32430 RVA: 0x0074BC24 File Offset: 0x00749E24
		internal string DEKVIPName_A22574_UILabel
		{
			get
			{
				short num = (short)397711769;
				short num2 = num;
				num = (short)322410905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568721408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1048051713;
				if (num != 0)
				{
				}
				num = (short)1769799680;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.UIName;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x06007EAF RID: 32431 RVA: 0x0074BCD8 File Offset: 0x00749ED8
		// (set) Token: 0x06007EB0 RID: 32432 RVA: 0x0074BD8C File Offset: 0x00749F8C
		internal bool DEKVIPName_A22574_HiddenStatic
		{
			get
			{
				short num = (short)59913893;
				short num2 = num;
				num = (short)1313289893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992163328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1155465216;
				if (num != 0)
				{
				}
				num = (short)223477761;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.HiddenStatic;
			}
			set
			{
				short num = (short)621441199;
				short num2 = num;
				num = (short)1637445807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195756032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)613548032;
				if (num != 0)
				{
				}
				num = (short)803602433;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.HiddenStatic = value;
			}
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x06007EB1 RID: 32433 RVA: 0x0074BE44 File Offset: 0x0074A044
		// (set) Token: 0x06007EB2 RID: 32434 RVA: 0x0074BEF8 File Offset: 0x0074A0F8
		internal bool DEKVIPName_A22574_HiddenDynamic
		{
			get
			{
				short num = (short)1487251583;
				short num2 = num;
				num = (short)1514907775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)49479680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879230976;
				if (num != 0)
				{
				}
				num = (short)584318977;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574.HiddenDynamic;
			}
			set
			{
				short num = (short)445467628;
				short num2 = num;
				num = (short)368135148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1115160576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1820000257;
				if (num != 0)
				{
				}
				num = (short)828702720;
				if (num != 0)
				{
				}
				this.dEKVIPName_A22574.HiddenDynamic = value;
			}
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x06007EB3 RID: 32435 RVA: 0x0074BFB0 File Offset: 0x0074A1B0
		public bool DEKVIPName_A22574_HasDiffs
		{
			get
			{
				short num = (short)1711082756;
				short num2 = num;
				num = (short)820055300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)937230336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1726873600;
				if (num != 0)
				{
				}
				num = (short)1867317249;
				if (num != 0)
				{
				}
				return this.dEKVIPName_A22574._HasDiffs;
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x06007EB4 RID: 32436 RVA: 0x0074C064 File Offset: 0x0074A264
		// (set) Token: 0x06007EB5 RID: 32437 RVA: 0x0074C118 File Offset: 0x0074A318
		public int DEKVIPOutputFeature_A21346Value
		{
			get
			{
				short num = (short)791812393;
				short num2 = num;
				num = (short)1167661353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472186880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89194497;
				if (num != 0)
				{
				}
				num = (short)453443584;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.Value;
			}
			set
			{
				short num = (short)2044939647;
				short num2 = num;
				num = (short)58805631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1880096768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)833028096;
				if (num != 0)
				{
				}
				num = (short)1036582913;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.Value = value;
			}
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x0074C1CC File Offset: 0x0074A3CC
		// (set) Token: 0x06007EB7 RID: 32439 RVA: 0x0074C280 File Offset: 0x0074A480
		public string DEKVIPOutputFeature_A21346_UIValue
		{
			get
			{
				short num = (short)1099683479;
				short num2 = num;
				num = (short)704894615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618725376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)573374464;
				if (num != 0)
				{
				}
				num = (short)515440641;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.UIValue;
			}
			set
			{
				short num = (short)1618477057;
				if (num != 0)
				{
				}
				num = (short)1962672128;
				short num2 = num;
				num = (short)247562415;
				short num3 = num;
				num = (short)463110319;
				switch (num3 == num)
				{
				}
				num = (short)22740992;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.UIValue = value;
			}
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x06007EB8 RID: 32440 RVA: 0x0074C334 File Offset: 0x0074A534
		public global::AcpBusinessLayer.AcpListField DEKVIPOutputFeature_A21346
		{
			get
			{
				short num = (short)832296435;
				short num2 = num;
				num = (short)610915827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)936181760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)906559489;
				if (num != 0)
				{
				}
				num = (short)1563492352;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346;
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x0074C3E4 File Offset: 0x0074A5E4
		// (set) Token: 0x06007EBA RID: 32442 RVA: 0x0074C498 File Offset: 0x0074A698
		public bool DEKVIPOutputFeature_A21346_Applicable
		{
			get
			{
				short num = (short)297933104;
				short num2 = num;
				num = (short)194124080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2095644672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1356857344;
				if (num != 0)
				{
				}
				num = (short)262668289;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.Applicable;
			}
			set
			{
				short num = (short)811988174;
				short num2 = num;
				num = (short)1224078542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319094784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386007041;
				if (num != 0)
				{
				}
				num = (short)178782208;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.Applicable = value;
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x0074C550 File Offset: 0x0074A750
		// (set) Token: 0x06007EBC RID: 32444 RVA: 0x0074C604 File Offset: 0x0074A804
		public bool DEKVIPOutputFeature_A21346_Valid
		{
			get
			{
				short num = (short)137494529;
				if (num != 0)
				{
				}
				num = (short)1640300544;
				short num2 = num;
				num = (short)863728087;
				short num3 = num;
				num = (short)296186327;
				switch (num3 == num)
				{
				}
				num = (short)404619264;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.Valid;
			}
			set
			{
				short num = (short)87293953;
				if (num != 0)
				{
				}
				num = (short)347668480;
				short num2 = num;
				num = (short)258304851;
				short num3 = num;
				num = (short)683699027;
				switch (num3 == num)
				{
				}
				num = (short)809172992;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.Valid = value;
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x0074C6B4 File Offset: 0x0074A8B4
		// (set) Token: 0x06007EBE RID: 32446 RVA: 0x0074C768 File Offset: 0x0074A968
		public bool DEKVIPOutputFeature_A21346_Visible
		{
			get
			{
				short num = (short)311360515;
				short num2 = num;
				num = (short)2087451651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436076544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)19136513;
				if (num != 0)
				{
				}
				num = (short)471859200;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.Visible;
			}
			set
			{
				short num = (short)541515748;
				short num2 = num;
				num = (short)26861540;
				switch (num2 == num)
				{
				}
				num = (short)1418067968;
				short num3 = num;
				num = (short)1293156353;
				if (num != 0)
				{
				}
				num = (short)609288192;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.Visible = value;
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x06007EBF RID: 32447 RVA: 0x0074C81C File Offset: 0x0074AA1C
		// (set) Token: 0x06007EC0 RID: 32448 RVA: 0x0074C8D4 File Offset: 0x0074AAD4
		public bool DEKVIPOutputFeature_A21346_Editable
		{
			get
			{
				short num = (short)1084164205;
				short num2 = num;
				num = (short)1942751341;
				switch (num2 == num)
				{
				}
				num = (short)596705280;
				short num3 = num;
				num = (short)2114715649;
				if (num != 0)
				{
				}
				num = (short)1326186496;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.Editable;
			}
			set
			{
				short num = (short)1711013889;
				if (num != 0)
				{
				}
				num = (short)144810970;
				short num2 = num;
				num = (short)345875418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)768737280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)456523776;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.Editable = value;
			}
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x06007EC1 RID: 32449 RVA: 0x0074C98C File Offset: 0x0074AB8C
		internal string DEKVIPOutputFeature_A21346_UILabel
		{
			get
			{
				short num = (short)1274281985;
				if (num != 0)
				{
				}
				num = (short)1716720691;
				short num2 = num;
				num = (short)271127603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478412800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276824064;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.UIName;
			}
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x06007EC2 RID: 32450 RVA: 0x0074CA40 File Offset: 0x0074AC40
		// (set) Token: 0x06007EC3 RID: 32451 RVA: 0x0074CAF0 File Offset: 0x0074ACF0
		internal bool DEKVIPOutputFeature_A21346_HiddenStatic
		{
			get
			{
				short num = (short)1973426768;
				short num2 = num;
				num = (short)989600336;
				switch (num2 == num)
				{
				}
				num = (short)607715328;
				short num3 = num;
				num = (short)1800011776;
				if (num != 0)
				{
				}
				num = (short)1132396545;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.HiddenStatic;
			}
			set
			{
				short num = (short)1218901922;
				short num2 = num;
				num = (short)734394274;
				switch (num2 == num)
				{
				}
				num = (short)209125376;
				short num3 = num;
				num = (short)647757825;
				if (num != 0)
				{
				}
				num = (short)274202624;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.HiddenStatic = value;
			}
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x06007EC4 RID: 32452 RVA: 0x0074CBA4 File Offset: 0x0074ADA4
		// (set) Token: 0x06007EC5 RID: 32453 RVA: 0x0074CC58 File Offset: 0x0074AE58
		internal bool DEKVIPOutputFeature_A21346_HiddenDynamic
		{
			get
			{
				short num = (short)332370524;
				short num2 = num;
				num = (short)1689817692;
				switch (num2 == num)
				{
				}
				num = (short)1669595136;
				short num3 = num;
				num = (short)1642004481;
				if (num != 0)
				{
				}
				num = (short)1895432192;
				if (num != 0)
				{
				}
				return this.dEKVIPOutputFeature_A21346.HiddenDynamic;
			}
			set
			{
				short num = (short)1943285818;
				short num2 = num;
				num = (short)896282682;
				switch (num2 == num)
				{
				}
				num = (short)351928320;
				short num3 = num;
				num = (short)287178752;
				if (num != 0)
				{
				}
				num = (short)1965490177;
				if (num != 0)
				{
				}
				this.dEKVIPOutputFeature_A21346.HiddenDynamic = value;
			}
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x0074CD0C File Offset: 0x0074AF0C
		public bool DEKVIPOutputFeature_A21346_HasDiffs
		{
			get
			{
				short num = (short)1549845988;
				short num2 = num;
				num = (short)747881956;
				switch (num2 == num)
				{
				}
				num = (short)309198849;
				if (num != 0)
				{
				}
				num = (short)1499922432;
				if (num != 0)
				{
				}
				num = (short)44761088;
				short num3 = num;
				return this.dEKVIPOutputFeature_A21346._HasDiffs;
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x06007EC7 RID: 32455 RVA: 0x0074CDC0 File Offset: 0x0074AFC0
		// (set) Token: 0x06007EC8 RID: 32456 RVA: 0x0074CE74 File Offset: 0x0074B074
		public int DEKVIPButtonShortPressTimeValue
		{
			get
			{
				short num = (short)1783086469;
				short num2 = num;
				num = (short)750894469;
				switch (num2 == num)
				{
				}
				num = (short)1800601601;
				if (num != 0)
				{
				}
				num = (short)363003904;
				if (num != 0)
				{
				}
				num = (short)2083389440;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)915341313;
				if (num != 0)
				{
				}
				num = (short)998430332;
				short num2 = num;
				num = (short)2140984956;
				switch (num2 == num)
				{
				}
				num = (short)976879616;
				if (num != 0)
				{
				}
				num = (short)322371584;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x0074CF28 File Offset: 0x0074B128
		// (set) Token: 0x06007ECA RID: 32458 RVA: 0x0074CFDC File Offset: 0x0074B1DC
		public string DEKVIPButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)1407080824;
				short num2 = num;
				num = (short)1078745464;
				switch (num2 == num)
				{
				}
				num = (short)1551958016;
				if (num != 0)
				{
				}
				num = (short)1465581569;
				if (num != 0)
				{
				}
				num = (short)426049536;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)1892764529;
				short num2 = num;
				num = (short)1691437937;
				switch (num2 == num)
				{
				}
				num = (short)1307115521;
				if (num != 0)
				{
				}
				num = (short)1896022016;
				if (num != 0)
				{
				}
				num = (short)715063296;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x06007ECB RID: 32459 RVA: 0x0074D090 File Offset: 0x0074B290
		public global::AcpBusinessLayer.AcpSimpleRangeField DEKVIPButtonShortPressTime
		{
			get
			{
				short num = (short)800659901;
				short num2 = num;
				num = (short)1690900925;
				switch (num2 == num)
				{
				}
				num = (short)638779393;
				if (num != 0)
				{
				}
				num = (short)139001856;
				if (num != 0)
				{
				}
				num = (short)2016149504;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime;
			}
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x06007ECC RID: 32460 RVA: 0x0074D140 File Offset: 0x0074B340
		// (set) Token: 0x06007ECD RID: 32461 RVA: 0x0074D1F8 File Offset: 0x0074B3F8
		internal int DEKVIPButtonShortPressTimeMin
		{
			get
			{
				short num = (short)1613758465;
				if (num != 0)
				{
				}
				num = (short)936486122;
				short num2 = num;
				num = (short)1821025514;
				switch (num2 == num)
				{
				}
				num = (short)1984561152;
				if (num != 0)
				{
				}
				num = (short)540213248;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Min;
			}
			set
			{
				short num = (short)1509095259;
				short num2 = num;
				num = (short)1643444059;
				switch (num2 == num)
				{
				}
				num = (short)358350848;
				if (num != 0)
				{
				}
				num = (short)1712586753;
				if (num != 0)
				{
				}
				num = (short)367001600;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Min = value;
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x06007ECE RID: 32462 RVA: 0x0074D2B0 File Offset: 0x0074B4B0
		// (set) Token: 0x06007ECF RID: 32463 RVA: 0x0074D364 File Offset: 0x0074B564
		internal int DEKVIPButtonShortPressTimeMax
		{
			get
			{
				short num = (short)1328791156;
				short num2 = num;
				num = (short)1238482548;
				switch (num2 == num)
				{
				}
				num = (short)629014529;
				if (num != 0)
				{
				}
				num = (short)708247552;
				if (num != 0)
				{
				}
				num = (short)1160249344;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Max;
			}
			set
			{
				short num = (short)1620133113;
				short num2 = num;
				num = (short)246433017;
				switch (num2 == num)
				{
				}
				num = (short)571408385;
				if (num != 0)
				{
				}
				num = (short)1250295808;
				if (num != 0)
				{
				}
				num = (short)1705902080;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Max = value;
			}
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x06007ED0 RID: 32464 RVA: 0x0074D41C File Offset: 0x0074B61C
		// (set) Token: 0x06007ED1 RID: 32465 RVA: 0x0074D4D0 File Offset: 0x0074B6D0
		internal int DEKVIPButtonShortPressTimeStep
		{
			get
			{
				short num = (short)1191067649;
				short num2 = num;
				num = (short)99696641;
				switch (num2 == num)
				{
				}
				num = (short)689045504;
				if (num != 0)
				{
				}
				num = (short)1737883649;
				if (num != 0)
				{
				}
				num = (short)775094272;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.StepSize;
			}
			set
			{
				short num = (short)537747723;
				short num2 = num;
				num = (short)142565643;
				switch (num2 == num)
				{
				}
				num = (short)1330315264;
				if (num != 0)
				{
				}
				num = (short)773783553;
				if (num != 0)
				{
				}
				num = (short)4456448;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.StepSize = value;
			}
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x0074D588 File Offset: 0x0074B788
		// (set) Token: 0x06007ED3 RID: 32467 RVA: 0x0074D640 File Offset: 0x0074B840
		public bool DEKVIPButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)2070360848;
				short num2 = num;
				num = (short)416822032;
				switch (num2 == num)
				{
				}
				num = (short)396886017;
				if (num != 0)
				{
				}
				num = (short)727449600;
				if (num != 0)
				{
				}
				num = (short)166002688;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)1025456701;
				short num2 = num;
				num = (short)1090599485;
				switch (num2 == num)
				{
				}
				num = (short)413270017;
				if (num != 0)
				{
				}
				num = (short)900661248;
				if (num != 0)
				{
				}
				num = (short)810876928;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x06007ED4 RID: 32468 RVA: 0x0074D6F4 File Offset: 0x0074B8F4
		// (set) Token: 0x06007ED5 RID: 32469 RVA: 0x0074D7A8 File Offset: 0x0074B9A8
		public bool DEKVIPButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)258387327;
				short num2 = num;
				num = (short)1293790591;
				switch (num2 == num)
				{
				}
				num = (short)254017537;
				if (num != 0)
				{
				}
				num = (short)65601536;
				if (num != 0)
				{
				}
				num = (short)2017722368;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)312130120;
				short num2 = num;
				num = (short)1131330120;
				switch (num2 == num)
				{
				}
				num = (short)2055340032;
				if (num != 0)
				{
				}
				num = (short)74842113;
				if (num != 0)
				{
				}
				num = (short)551616512;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x06007ED6 RID: 32470 RVA: 0x0074D864 File Offset: 0x0074BA64
		// (set) Token: 0x06007ED7 RID: 32471 RVA: 0x0074D918 File Offset: 0x0074BB18
		public bool DEKVIPButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)425858882;
				short num2 = num;
				num = (short)1239881538;
				switch (num2 == num)
				{
				}
				num = (short)352845825;
				if (num != 0)
				{
				}
				num = (short)906690560;
				if (num != 0)
				{
				}
				num = (short)1009319936;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)231145473;
				if (num != 0)
				{
				}
				num = (short)1342581981;
				short num2 = num;
				num = (short)1855401181;
				switch (num2 == num)
				{
				}
				num = (short)395116544;
				if (num != 0)
				{
				}
				num = (short)747241472;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x06007ED8 RID: 32472 RVA: 0x0074D9CC File Offset: 0x0074BBCC
		// (set) Token: 0x06007ED9 RID: 32473 RVA: 0x0074DA80 File Offset: 0x0074BC80
		public bool DEKVIPButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)1472903535;
				short num2 = num;
				num = (short)1045608815;
				switch (num2 == num)
				{
				}
				num = (short)275382273;
				if (num != 0)
				{
				}
				num = (short)212729856;
				if (num != 0)
				{
				}
				num = (short)1548615680;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)460518081;
				short num2 = num;
				num = (short)242545345;
				switch (num2 == num)
				{
				}
				num = (short)1172045825;
				if (num != 0)
				{
				}
				num = (short)1657864192;
				if (num != 0)
				{
				}
				num = (short)171376640;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x0074DB38 File Offset: 0x0074BD38
		internal string DEKVIPButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1991221157;
				short num2 = num;
				num = (short)1387241381;
				switch (num2 == num)
				{
				}
				num = (short)1585905664;
				if (num != 0)
				{
				}
				num = (short)251396097;
				if (num != 0)
				{
				}
				num = (short)1169096704;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.UIName;
			}
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x06007EDB RID: 32475 RVA: 0x0074DBEC File Offset: 0x0074BDEC
		// (set) Token: 0x06007EDC RID: 32476 RVA: 0x0074DCA0 File Offset: 0x0074BEA0
		internal bool DEKVIPButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)111986390;
				short num2 = num;
				num = (short)713541334;
				switch (num2 == num)
				{
				}
				num = (short)376373249;
				if (num != 0)
				{
				}
				num = (short)345636864;
				if (num != 0)
				{
				}
				num = (short)1236533248;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)2073821185;
				if (num != 0)
				{
				}
				num = (short)363669474;
				short num2 = num;
				num = (short)761866210;
				switch (num2 == num)
				{
				}
				num = (short)1533607936;
				if (num != 0)
				{
				}
				num = (short)3866624;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x06007EDD RID: 32477 RVA: 0x0074DD58 File Offset: 0x0074BF58
		// (set) Token: 0x06007EDE RID: 32478 RVA: 0x0074DE0C File Offset: 0x0074C00C
		internal bool DEKVIPButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1850540033;
				if (num != 0)
				{
				}
				num = (short)1547332544;
				short num2 = num;
				num = (short)698051520;
				switch (num2 == num)
				{
				}
				num = (short)102498304;
				if (num != 0)
				{
				}
				num = (short)166592512;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)484311041;
				if (num != 0)
				{
				}
				num = (short)1246072291;
				short num2 = num;
				num = (short)1398377955;
				switch (num2 == num)
				{
				}
				num = (short)683606016;
				if (num != 0)
				{
				}
				num = (short)1312489472;
				short num3 = num;
				this.dEKVIPButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x06007EDF RID: 32479 RVA: 0x0074DEC0 File Offset: 0x0074C0C0
		public bool DEKVIPButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)542964323;
				short num2 = num;
				num = (short)1717697123;
				switch (num2 == num)
				{
				}
				num = (short)880476160;
				if (num != 0)
				{
				}
				num = (short)987627521;
				if (num != 0)
				{
				}
				num = (short)2009989120;
				short num3 = num;
				return this.dEKVIPButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x06007EE0 RID: 32480 RVA: 0x0074DF74 File Offset: 0x0074C174
		// (set) Token: 0x06007EE1 RID: 32481 RVA: 0x0074E02C File Offset: 0x0074C22C
		public int DEKVIPButtonLongPressTimeValue
		{
			get
			{
				short num = (short)1390157180;
				short num2 = num;
				num = (short)1820204412;
				switch (num2 == num)
				{
				}
				num = (short)195559425;
				if (num != 0)
				{
				}
				num = (short)1672544256;
				if (num != 0)
				{
				}
				num = (short)1671626752;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)1081880948;
				short num2 = num;
				num = (short)1661022580;
				switch (num2 == num)
				{
				}
				num = (short)823132160;
				if (num != 0)
				{
				}
				num = (short)273481729;
				if (num != 0)
				{
				}
				num = (short)2146238464;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x06007EE2 RID: 32482 RVA: 0x0074E0E0 File Offset: 0x0074C2E0
		// (set) Token: 0x06007EE3 RID: 32483 RVA: 0x0074E194 File Offset: 0x0074C394
		public string DEKVIPButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)654508033;
				if (num != 0)
				{
				}
				num = (short)671029529;
				short num2 = num;
				num = (short)679221529;
				switch (num2 == num)
				{
				}
				num = (short)1776025600;
				if (num != 0)
				{
				}
				num = (short)896532480;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1809729297;
				short num2 = num;
				num = (short)178865937;
				switch (num2 == num)
				{
				}
				num = (short)1524498433;
				if (num != 0)
				{
				}
				num = (short)1936523264;
				if (num != 0)
				{
				}
				num = (short)827064320;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x06007EE4 RID: 32484 RVA: 0x0074E24C File Offset: 0x0074C44C
		public global::AcpBusinessLayer.AcpCustomRangeField DEKVIPButtonLongPressTime
		{
			get
			{
				short num = (short)349175809;
				if (num != 0)
				{
				}
				num = (short)1136562965;
				short num2 = num;
				num = (short)1443271445;
				switch (num2 == num)
				{
				}
				num = (short)655228928;
				if (num != 0)
				{
				}
				num = (short)1433010176;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime;
			}
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x06007EE5 RID: 32485 RVA: 0x0074E2FC File Offset: 0x0074C4FC
		// (set) Token: 0x06007EE6 RID: 32486 RVA: 0x0074E3B0 File Offset: 0x0074C5B0
		public bool DEKVIPButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)691642871;
				short num2 = num;
				num = (short)100246007;
				switch (num2 == num)
				{
				}
				num = (short)1437073409;
				if (num != 0)
				{
				}
				num = (short)461897728;
				if (num != 0)
				{
				}
				num = (short)800194560;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1115399240;
				short num2 = num;
				num = (short)399942728;
				switch (num2 == num)
				{
				}
				num = (short)1804337153;
				if (num != 0)
				{
				}
				num = (short)1662910464;
				if (num != 0)
				{
				}
				num = (short)1088356352;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x06007EE7 RID: 32487 RVA: 0x0074E464 File Offset: 0x0074C664
		// (set) Token: 0x06007EE8 RID: 32488 RVA: 0x0074E518 File Offset: 0x0074C718
		public bool DEKVIPButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)87818241;
				if (num != 0)
				{
				}
				num = (short)1347240052;
				short num2 = num;
				num = (short)1670004852;
				switch (num2 == num)
				{
				}
				num = (short)482148352;
				if (num != 0)
				{
				}
				num = (short)877002752;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)548070042;
				short num2 = num;
				num = (short)1768284826;
				switch (num2 == num)
				{
				}
				num = (short)622395393;
				if (num != 0)
				{
				}
				num = (short)1703346176;
				if (num != 0)
				{
				}
				num = (short)262078464;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x06007EE9 RID: 32489 RVA: 0x0074E5CC File Offset: 0x0074C7CC
		// (set) Token: 0x06007EEA RID: 32490 RVA: 0x0074E680 File Offset: 0x0074C880
		public bool DEKVIPButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)523800166;
				short num2 = num;
				num = (short)1563463270;
				switch (num2 == num)
				{
				}
				num = (short)622526464;
				if (num != 0)
				{
				}
				num = (short)1445068801;
				if (num != 0)
				{
				}
				num = (short)392429568;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)1050228359;
				short num2 = num;
				num = (short)1859991175;
				switch (num2 == num)
				{
				}
				num = (short)570425344;
				if (num != 0)
				{
				}
				num = (short)1855127553;
				if (num != 0)
				{
				}
				num = (short)575733760;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x0074E738 File Offset: 0x0074C938
		// (set) Token: 0x06007EEC RID: 32492 RVA: 0x0074E7EC File Offset: 0x0074C9EC
		public bool DEKVIPButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)1647558577;
				short num2 = num;
				num = (short)1957937073;
				switch (num2 == num)
				{
				}
				num = (short)791740416;
				if (num != 0)
				{
				}
				num = (short)1989476353;
				if (num != 0)
				{
				}
				num = (short)1532231680;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)1313341965;
				short num2 = num;
				num = (short)1217004045;
				switch (num2 == num)
				{
				}
				num = (short)443416577;
				if (num != 0)
				{
				}
				num = (short)808517632;
				if (num != 0)
				{
				}
				num = (short)1523515392;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x06007EED RID: 32493 RVA: 0x0074E8A4 File Offset: 0x0074CAA4
		internal string DEKVIPButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)1244445913;
				short num2 = num;
				num = (short)42187993;
				switch (num2 == num)
				{
				}
				num = (short)561774593;
				if (num != 0)
				{
				}
				num = (short)1334968320;
				if (num != 0)
				{
				}
				num = (short)867893248;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.UIName;
			}
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x06007EEE RID: 32494 RVA: 0x0074E95C File Offset: 0x0074CB5C
		// (set) Token: 0x06007EEF RID: 32495 RVA: 0x0074EA10 File Offset: 0x0074CC10
		internal bool DEKVIPButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1144389633;
				if (num != 0)
				{
				}
				num = (short)1416616901;
				short num2 = num;
				num = (short)1486609349;
				switch (num2 == num)
				{
				}
				num = (short)1464401920;
				if (num != 0)
				{
				}
				num = (short)1202454528;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)472112792;
				short num2 = num;
				num = (short)60284568;
				switch (num2 == num)
				{
				}
				num = (short)282132480;
				if (num != 0)
				{
				}
				num = (short)1172111361;
				if (num != 0)
				{
				}
				num = (short)1661468672;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x06007EF0 RID: 32496 RVA: 0x0074EAC8 File Offset: 0x0074CCC8
		// (set) Token: 0x06007EF1 RID: 32497 RVA: 0x0074EB80 File Offset: 0x0074CD80
		internal bool DEKVIPButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1337678524;
				short num2 = num;
				num = (short)1907448508;
				switch (num2 == num)
				{
				}
				num = (short)386727937;
				if (num != 0)
				{
				}
				num = (short)1126498304;
				if (num != 0)
				{
				}
				num = (short)710803456;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)2065739732;
				short num2 = num;
				num = (short)1381281748;
				switch (num2 == num)
				{
				}
				num = (short)686030848;
				if (num != 0)
				{
				}
				num = (short)1688338433;
				if (num != 0)
				{
				}
				num = (short)2040528896;
				short num3 = num;
				this.dEKVIPButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x06007EF2 RID: 32498 RVA: 0x0074EC34 File Offset: 0x0074CE34
		public bool DEKVIPButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)214512086;
				short num2 = num;
				num = (short)285946326;
				switch (num2 == num)
				{
				}
				num = (short)1851654145;
				if (num != 0)
				{
				}
				num = (short)152502272;
				if (num != 0)
				{
				}
				num = (short)863895552;
				short num3 = num;
				return this.dEKVIPButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x0074ECE8 File Offset: 0x0074CEE8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1371736648;
				short num2 = num;
				num = (short)1790970440;
				switch (num2 == num)
				{
				}
				num = (short)458620929;
				if (num != 0)
				{
				}
				num = (short)614858752;
				if (num != 0)
				{
				}
				num = (short)1313341440;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x06007EF4 RID: 32500 RVA: 0x0074EDA4 File Offset: 0x0074CFA4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1566034163;
				short num2 = num;
				num = (short)1460324595;
				switch (num2 == num)
				{
				}
				num = (short)142737408;
				short num3 = num;
				num = (short)963510272;
				if (num != 0)
				{
				}
				num = (short)318504961;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x0074EE64 File Offset: 0x0074D064
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1250928038;
				short num2 = num;
				num = (short)637314470;
				switch (num2 == num)
				{
				}
				num = (short)1187053568;
				short num3 = num;
				num = (short)715194368;
				if (num != 0)
				{
				}
				num = (short)1187577857;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x0074EF20 File Offset: 0x0074D120
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)90004205;
				short num2 = num;
				num = (short)1032018669;
				switch (num2 == num)
				{
				}
				num = (short)1691615232;
				short num3 = num;
				num = (short)852230144;
				if (num != 0)
				{
				}
				num = (short)1702428673;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x0074EFE0 File Offset: 0x0074D1E0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1026490368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_FE;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)968294401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)1783496705;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)2030168466;
					short num3 = num2;
					num2 = (short)1518725522;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
						num2 = (short)186908672;
						if (num2 != 0)
						{
						}
						num2 = (short)609550338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_FE:
				num2 = (short)36044800;
				short num4 = num2;
				num2 = (short)329777155;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)434634756;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003997 RID: 14743
		private global::AcpBusinessLayer.AcpListField dEKVIPInputBCO_A21337;

		// Token: 0x04003998 RID: 14744
		private global::AcpBusinessLayer.AcpListField dEKVIPInputFeature_A21338;

		// Token: 0x04003999 RID: 14745
		private global::AcpBusinessLayer.AcpListField dEKVIPOutputBCO_A21347;

		// Token: 0x0400399A RID: 14746
		private global::AcpBusinessLayer.AcpKeyField dEKVIPKey_A22573;

		// Token: 0x0400399B RID: 14747
		private global::AcpBusinessLayer.AcpField<string> dEKVIPName_A22574;

		// Token: 0x0400399C RID: 14748
		private global::AcpBusinessLayer.AcpListField dEKVIPOutputFeature_A21346;

		// Token: 0x0400399D RID: 14749
		private global::AcpBusinessLayer.AcpSimpleRangeField dEKVIPButtonShortPressTime;

		// Token: 0x0400399E RID: 14750
		private global::AcpBusinessLayer.AcpCustomRangeField dEKVIPButtonLongPressTime;
	}
}
