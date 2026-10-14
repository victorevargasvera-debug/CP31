using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000239 RID: 569
	[global::System.Serializable]
	public class HornAndLights : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060065B4 RID: 26036 RVA: 0x005B1954 File Offset: 0x005AFB54
		public HornAndLights(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x005B1970 File Offset: 0x005AFB70
		protected HornAndLights(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x005B1988 File Offset: 0x005AFB88
		public override void Init()
		{
			int a_ = 6;
			short num = (short)622742445;
			short num2 = num;
			num = (short)1416580013;
			switch (num2 == num)
			{
			}
			num = (short)410648576;
			short num3 = num;
			num = (short)377290753;
			if (num != 0)
			{
			}
			num = (short)2065825792;
			if (num != 0)
			{
			}
			this.radErgoWideHornandLightsAlarmRearmOption_A7423 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴뛶闸髺迼鋾匀昂搄甆搈䐊紌笎砐簒笔䠖堘Ⱊ⤜ⴞሠ", a_), global::CommonResources.AcgResources.ID_ALARMALARMREARMOPTION);
			this.radErgoWideHornandLightsAlarmRearmOption_A7423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsAlarmRearmOption_A7423.DataTransferOrder = 30;
			this.radErgoWideHornandLightsAlarmType_A7424 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴뛶闸髺迼鋾唀稂甄戆嘈䨊㨌㬎⌐✒", a_), global::CommonResources.AcgResources.ID_ALARMALARMTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideHornandLightsAlarmType_A7424LovStrs);
			this.radErgoWideHornandLightsAlarmType_A7424.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsAlarmType_A7424.DataTransferOrder = 28;
			this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984 = new global::AcpBusinessLayer.AcpSimpleRangeField(7, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴닶臸迺飼跾漀戂椄䘆攈樊缌戎唐瘒礔瘖怘栚砜簞縠戢ሤḦᄨἪ", a_), global::CommonResources.AcgResources.ID_ALARMEXTERNALALARMDELAYSEC, 0, 15, null, null, 0, 1);
			this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.DataTransferOrder = 29;
			this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.ShowHexValue = false;
			this.radErgoWideHornandLightsHornLights_A8206 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴뿶雸觺鏼돾栀搂洄猆稈吊䰌㜎⌐⌒⌔", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTS);
			this.radErgoWideHornandLightsHornLights_A8206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsHornLights_A8206.DataTransferOrder = 26;
			this.radErgoWideHornandLightsHornDurationsec_A8207 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴뿶雸觺鏼믾琀焂搄猆怈搊挌簎琐瀒䨔嘖℘⤚ⴜ⠞", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTSHORNDURATIONSEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.radErgoWideHornandLightsHornDurationsec_A8207.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsHornDurationsec_A8207.DataTransferOrder = 32;
			this.radErgoWideHornandLightsHornDurationsec_A8207.ShowHexValue = false;
			this.radErgoWideHornandLightsLightDurationsec_A8430 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴믶郸鳺闼课䔀瘂眄昆紈戊戌愎成瘒瘔䠖堘⌚⤜Ⱎᄠ", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTSLIGHTDURATIONSEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.radErgoWideHornandLightsLightDurationsec_A8430.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsLightDurationsec_A8430.DataTransferOrder = 33;
			this.radErgoWideHornandLightsLightDurationsec_A8430.ShowHexValue = false;
			this.radErgoWideHornandLightsPermanentHornLights_A8697 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢蓤触跨꟪蓬裮駰蟲蛴ꟶ鳸觺郼黾漀昂欄猆䄈搊缌愎崐稒爔编洘栚䈜帞ᤠᔢᰤဦ", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTSPERMANENTHORNANDLIGHTS);
			this.radErgoWideHornandLightsPermanentHornLights_A8697.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornandLightsPermanentHornLights_A8697.DataTransferOrder = 31;
			this.radErgoWideHornAndLightsTwoAlarmOption_A9510 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊裌뷎뛐볒苔뻖뷘뻚關냞鏠跢ꓤ触跨꟪蓬裮駰蟲蛴ꏶ軸铺볼鏾怀焂栄䠆礈缊搌怎缐䰒吔⸖Ⱈ⨚ⴜ", a_), global::CommonResources.AcgResources.ID_ALARMTWOALARMOPTION);
			this.radErgoWideHornAndLightsTwoAlarmOption_A9510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideHornAndLightsTwoAlarmOption_A9510.DataTransferOrder = 27;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迆ꛈ맊ꏌ냐뷒뇔闘닚뫜럞闠郢", a_);
			base.Id = 10221;
			base.UIName = global::CommonResources.AcgResources.ID_HORNANDLIGHTS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x005B1C84 File Offset: 0x005AFE84
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1598554124;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_114;
				case 1:
					this.radErgoWideHornandLightsHornLights_A8206 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華뫱鯳蓵雷뛹闻駽棿瘁眃夅䤇㈉㸋㸍☏", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTS);
					this.radErgoWideHornandLightsHornLights_A8206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideHornandLightsHornLights_A8206.DataTransferOrder = 26;
					num = (short)376504320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1463214289;
					short num3 = num;
					num = (short)1290723537;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AC;
					default:
						num = (short)1498021888;
						if (num != 0)
						{
						}
						this.radErgoWideHornandLightsAlarmRearmOption_A7423 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華돱飳韵諷韹껻鯽懿瀁椃䤅砇縉攋愍縏䴑唓ℕⰗ⠙⼛", a_), global::CommonResources.AcgResources.ID_ALARMALARMREARMOPTION);
						this.radErgoWideHornandLightsAlarmRearmOption_A7423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgoWideHornandLightsAlarmRearmOption_A7423.DataTransferOrder = 30;
						num = (short)491651093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_474;
				case 4:
					this.radErgoWideHornandLightsAlarmType_A7424 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華돱飳韵諷韹ꣻ蟽烿朁嬃䜅㼇㸉㸋㨍", a_), global::CommonResources.AcgResources.ID_ALARMALARMTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideHornandLightsAlarmType_A7424LovStrs);
					this.radErgoWideHornandLightsAlarmType_A7424.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideHornandLightsAlarmType_A7424.DataTransferOrder = 28;
					num = (short)709492745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝ꇟ賡胣ꫥ臧跩蓫髭華꛱菳駵맷雹鷻賽淿䴁球爅愇攉戋儍儏⬑ℓ✕⠗", a_)))
					{
						num = (short)2140536852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6EC;
				case 6:
					this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984 = new global::AcpBusinessLayer.AcpSimpleRangeField(7, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華럱賳苵鷷裹鋻鿽泿䌁栃朅稇有䠋欍簏猑洓攕紗礙䌛弝ᜟᬡᰣሥ", a_), global::CommonResources.AcgResources.ID_ALARMEXTERNALALARMDELAYSEC, null, null, 0, 1);
					this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.DataTransferOrder = 29;
					this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.ShowHexValue = false;
					num = (short)2069954576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華돱飳韵諷韹ꣻ蟽烿朁嬃䜅㼇㸉㸋㨍", a_)))
					{
						num = (short)1782841348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_479;
				case 8:
					num = (short)1986592786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_479;
				case 10:
					goto IL_3D7;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華뻱鷳釵郷軹룻诽狿持瀃漅朇搉缋欍猏䴑唓⸕Ⱇ⤙Ⱋ", a_)))
					{
						num = (short)355729430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D7;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 13:
					goto IL_1AC;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華뫱鯳蓵雷뻹觻賽懿瘁洃椅昇礉椋洍伏匑Ⱃ␕⠗ⴙ", a_)))
					{
						num = (short)1209270297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C5;
				case 15:
				{
					num = (short)553779200;
					short num4 = num;
					num = (short)1998127131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
					goto IL_330;
				case 17:
					goto IL_2E3;
				case 18:
					if (producerFields != null)
					{
						num = (short)568524815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6EC;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華ꋱ釳蓵闷鯹鋻鯽滿瘁䰃椅稇搉䀋服眏稑怓攕䜗嬙␛⠝᤟ᔡ", a_)))
					{
						num = (short)203096077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 20:
					this.radErgoWideHornAndLightsTwoAlarmOption_A9510 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝ꇟ賡胣ꫥ臧跩蓫髭華꛱菳駵맷雹鷻賽淿䴁球爅愇攉戋儍儏⬑ℓ✕⠗", a_), global::CommonResources.AcgResources.ID_ALARMTWOALARMOPTION);
					this.radErgoWideHornAndLightsTwoAlarmOption_A9510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideHornAndLightsTwoAlarmOption_A9510.DataTransferOrder = 27;
					num = (short)171048963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_15F;
				case 22:
					this.radErgoWideHornandLightsLightDurationsec_A8430 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華뻱鷳釵郷軹룻诽狿持瀃漅朇搉缋欍猏䴑唓⸕Ⱇ⤙Ⱋ", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTSLIGHTDURATIONSEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.radErgoWideHornandLightsLightDurationsec_A8430.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideHornandLightsLightDurationsec_A8430.DataTransferOrder = 33;
					this.radErgoWideHornandLightsLightDurationsec_A8430.ShowHexValue = false;
					num = (short)1518534666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_C5;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華뫱鯳蓵雷뛹闻駽棿瘁眃夅䤇㈉㸋㸍☏", a_)))
					{
						num = (short)1287454721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_114;
				case 25:
					this.radErgoWideHornandLightsHornDurationsec_A8207 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華뫱鯳蓵雷뻹觻賽懿瘁洃椅昇礉椋洍伏匑Ⱃ␕⠗ⴙ", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTSHORNDURATIONSEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.radErgoWideHornandLightsHornDurationsec_A8207.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideHornandLightsHornDurationsec_A8207.DataTransferOrder = 32;
					this.radErgoWideHornandLightsHornDurationsec_A8207.ShowHexValue = false;
					num = (short)638451735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					num = (short)222035969;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華럱賳苵鷷裹鋻鿽泿䌁栃朅稇有䠋欍簏猑洓攕紗礙䌛弝ᜟᬡᰣሥ", a_)))
					{
						num = (short)1860960262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_330;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華돱飳韵諷韹껻鯽懿瀁椃䤅砇縉攋愍縏䴑唓ℕⰗ⠙⼛", a_)))
					{
						num = (short)1466630146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15F;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1205534728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C5:
				num = (short)23724043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_114:
				num = (short)1688797198;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15F:
				num = (short)1266155527;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AC:
				this.radErgoWideHornandLightsPermanentHornLights_A8697 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕郗뗙껛냝臟賡胣ꫥ臧跩蓫髭華ꋱ釳蓵闷鯹鋻鯽滿瘁䰃椅稇搉䀋服眏稑怓攕䜗嬙␛⠝᤟ᔡ", a_), global::CommonResources.AcgResources.ID_HORNANDLIGHTSPERMANENTHORNANDLIGHTS);
				this.radErgoWideHornandLightsPermanentHornLights_A8697.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.radErgoWideHornandLightsPermanentHornLights_A8697.DataTransferOrder = 31;
				num = (short)1679753233;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E3:
				num = (short)1175650309;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_330:
				num = (short)178913304;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D7:
				num = (short)988348435;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_479:
				num = (short)153288730;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_474:
			IL_6EC:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諁ꯃ듅ꛇ귋ꃍ듏飓뿕뿗닙꣛귝", a_);
			base.Id = 10221;
			base.UIName = global::CommonResources.AcgResources.ID_HORNANDLIGHTS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x005B23B0 File Offset: 0x005B05B0
		public override void PopulateReferences()
		{
			short num = (short)720917333;
			short num2 = num;
			num = (short)1778406229;
			switch (num2 == num)
			{
			}
			num = (short)1085669376;
			short num3 = num;
			num = (short)703135744;
			if (num != 0)
			{
			}
			num = (short)862650369;
			if (num != 0)
			{
			}
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x005B2458 File Offset: 0x005B0658
		public override void DropReferences()
		{
			short num = (short)487492775;
			short num2 = num;
			num = (short)1698925735;
			switch (num2 == num)
			{
			}
			num = (short)1573519360;
			short num3 = num;
			num = (short)1790312449;
			if (num != 0)
			{
			}
			num = (short)2060255232;
			if (num != 0)
			{
			}
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x005B2504 File Offset: 0x005B0704
		public override void SetConstraints()
		{
			short num = (short)777128537;
			short num2 = num;
			num = (short)275122777;
			switch (num2 == num)
			{
			}
			num = (short)1951465472;
			short num3 = num;
			num = (short)924844033;
			if (num != 0)
			{
			}
			num = (short)1825832960;
			if (num != 0)
			{
			}
			this.radErgoWideHornandLightsAlarmRearmOption_A7423.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConHornAndLightIsEnabled);
			this.radErgoWideHornandLightsAlarmType_A7424.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConTwoAlarmOptIsDisabledAndHornAndLightIsEnabled);
			this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConHornAndLightIsEnabled);
			this.radErgoWideHornandLightsHornLights_A8206.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoHornLightIsApp);
			this.radErgoWideHornandLightsHornLights_A8206.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoHornLightIsValid);
			this.radErgoWideHornandLightsHornDurationsec_A8207.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConHornAndLightIsEnabled);
			this.radErgoWideHornandLightsLightDurationsec_A8430.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConHornAndLightIsEnabled);
			this.radErgoWideHornandLightsPermanentHornLights_A8697.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConHornAndLightIsEnabled);
			this.radErgoWideHornAndLightsTwoAlarmOption_A9510.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConHornAndLightIsEnabled);
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x005B267C File Offset: 0x005B087C
		public override void SetupDependencies()
		{
			short num = (short)30116371;
			short num2 = num;
			num = (short)872647187;
			switch (num2 == num)
			{
			}
			num = (short)622985216;
			short num3 = num;
			num = (short)740425728;
			if (num != 0)
			{
			}
			num = (short)1142030337;
			if (num != 0)
			{
			}
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornandLightsAlarmRearmOption_A7423);
			this.radErgoWideHornAndLightsTwoAlarmOption_A9510.AddDependentObject(this.radErgoWideHornandLightsAlarmType_A7424);
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornandLightsAlarmType_A7424);
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideHornandLightsHornLights_A8206);
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornandLightsHornDurationsec_A8207);
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornandLightsLightDurationsec_A8430);
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornandLightsPermanentHornLights_A8697);
			this.radErgoWideHornandLightsHornLights_A8206.AddDependentObject(this.radErgoWideHornAndLightsTwoAlarmOption_A9510);
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x005B27D0 File Offset: 0x005B09D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1318308980;
				short num2 = num;
				num = (short)1750977652;
				switch (num2 == num)
				{
				}
				num = (short)1632763904;
				short num3 = num;
				num = (short)1427832832;
				if (num != 0)
				{
				}
				num = (short)583598081;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x005B2884 File Offset: 0x005B0A84
		// (set) Token: 0x060065BE RID: 26046 RVA: 0x005B2938 File Offset: 0x005B0B38
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423Value
		{
			get
			{
				short num = (short)719415135;
				short num2 = num;
				num = (short)1269524319;
				switch (num2 == num)
				{
				}
				num = (short)413204480;
				short num3 = num;
				num = (short)772407297;
				if (num != 0)
				{
				}
				num = (short)1901068288;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.Value;
			}
			set
			{
				short num = (short)1722778078;
				short num2 = num;
				num = (short)1362592222;
				switch (num2 == num)
				{
				}
				num = (short)100204544;
				short num3 = num;
				num = (short)570097665;
				if (num != 0)
				{
				}
				num = (short)1428357120;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.Value = value;
			}
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x060065BF RID: 26047 RVA: 0x005B29F0 File Offset: 0x005B0BF0
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideHornandLightsAlarmRearmOption_A7423
		{
			get
			{
				short num = (short)944751280;
				short num2 = num;
				num = (short)199213744;
				switch (num2 == num)
				{
				}
				num = (short)957480960;
				short num3 = num;
				num = (short)2097217537;
				if (num != 0)
				{
				}
				num = (short)1462173696;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423;
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x060065C0 RID: 26048 RVA: 0x005B2AA0 File Offset: 0x005B0CA0
		// (set) Token: 0x060065C1 RID: 26049 RVA: 0x005B2B54 File Offset: 0x005B0D54
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423_UIValue
		{
			get
			{
				short num = (short)391569124;
				short num2 = num;
				num = (short)39837412;
				switch (num2 == num)
				{
				}
				num = (short)1577189376;
				short num3 = num;
				num = (short)1351221248;
				if (num != 0)
				{
				}
				num = (short)1683292161;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.Value;
			}
			set
			{
				short num = (short)1377938902;
				short num2 = num;
				num = (short)841199062;
				switch (num2 == num)
				{
				}
				num = (short)1275658240;
				short num3 = num;
				num = (short)845348864;
				if (num != 0)
				{
				}
				num = (short)985661441;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.Value = value;
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x060065C2 RID: 26050 RVA: 0x005B2C0C File Offset: 0x005B0E0C
		// (set) Token: 0x060065C3 RID: 26051 RVA: 0x005B2CC0 File Offset: 0x005B0EC0
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423_Applicable
		{
			get
			{
				short num = (short)843901924;
				short num2 = num;
				num = (short)309390308;
				switch (num2 == num)
				{
				}
				num = (short)1278214144;
				short num3 = num;
				num = (short)1284177920;
				if (num != 0)
				{
				}
				num = (short)194969601;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.Applicable;
			}
			set
			{
				short num = (short)37229560;
				short num2 = num;
				num = (short)1635128312;
				switch (num2 == num)
				{
				}
				num = (short)2007105537;
				if (num != 0)
				{
				}
				num = (short)2117599232;
				short num3 = num;
				num = (short)423297024;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.Applicable = value;
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x060065C4 RID: 26052 RVA: 0x005B2D78 File Offset: 0x005B0F78
		// (set) Token: 0x060065C5 RID: 26053 RVA: 0x005B2E2C File Offset: 0x005B102C
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423_Valid
		{
			get
			{
				short num = (short)2035762960;
				short num2 = num;
				num = (short)644826896;
				switch (num2 == num)
				{
				}
				num = (short)134479873;
				if (num != 0)
				{
				}
				num = (short)635502592;
				short num3 = num;
				num = (short)240713728;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.Valid;
			}
			set
			{
				short num = (short)410363344;
				short num2 = num;
				num = (short)1919395280;
				switch (num2 == num)
				{
				}
				num = (short)1520173057;
				if (num != 0)
				{
				}
				num = (short)962134016;
				short num3 = num;
				num = (short)1486159872;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.Valid = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x060065C6 RID: 26054 RVA: 0x005B2EE4 File Offset: 0x005B10E4
		// (set) Token: 0x060065C7 RID: 26055 RVA: 0x005B2F98 File Offset: 0x005B1198
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423_Visible
		{
			get
			{
				short num = (short)858363056;
				short num2 = num;
				num = (short)989303984;
				switch (num2 == num)
				{
				}
				num = (short)1134821377;
				if (num != 0)
				{
				}
				num = (short)42598400;
				short num3 = num;
				num = (short)454754304;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.Visible;
			}
			set
			{
				short num = (short)1584463873;
				if (num != 0)
				{
				}
				num = (short)1094220930;
				short num2 = num;
				num = (short)2023062658;
				switch (num2 == num)
				{
				}
				num = (short)1817378816;
				short num3 = num;
				num = (short)1935605760;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.Visible = value;
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x060065C8 RID: 26056 RVA: 0x005B3050 File Offset: 0x005B1250
		// (set) Token: 0x060065C9 RID: 26057 RVA: 0x005B3104 File Offset: 0x005B1304
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423_Editable
		{
			get
			{
				short num = (short)2085552129;
				if (num != 0)
				{
				}
				num = (short)970444631;
				short num2 = num;
				num = (short)12832599;
				switch (num2 == num)
				{
				}
				num = (short)511967232;
				short num3 = num;
				num = (short)1502150656;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.Editable;
			}
			set
			{
				short num = (short)327678066;
				short num2 = num;
				num = (short)418248818;
				switch (num2 == num)
				{
				}
				num = (short)1735458817;
				if (num != 0)
				{
				}
				num = (short)1750663168;
				short num3 = num;
				num = (short)504627200;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.Editable = value;
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x060065CA RID: 26058 RVA: 0x005B31BC File Offset: 0x005B13BC
		internal string RadErgoWideHornandLightsAlarmRearmOption_A7423_UILabel
		{
			get
			{
				short num = (short)144093643;
				short num2 = num;
				num = (short)6336971;
				switch (num2 == num)
				{
				}
				num = (short)1074069504;
				if (num != 0)
				{
				}
				num = (short)587137024;
				short num3 = num;
				num = (short)104529921;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.UIName;
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x005B3274 File Offset: 0x005B1474
		// (set) Token: 0x060065CC RID: 26060 RVA: 0x005B332C File Offset: 0x005B152C
		internal bool RadErgoWideHornandLightsAlarmRearmOption_A7423_HiddenStatic
		{
			get
			{
				short num = (short)878015372;
				short num2 = num;
				num = (short)753300364;
				switch (num2 == num)
				{
				}
				num = (short)5767169;
				if (num != 0)
				{
				}
				num = (short)1383464960;
				short num3 = num;
				num = (short)86179840;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.HiddenStatic;
			}
			set
			{
				short num = (short)2140930049;
				if (num != 0)
				{
				}
				num = (short)410111042;
				short num2 = num;
				num = (short)1343474754;
				switch (num2 == num)
				{
				}
				num = (short)243924992;
				short num3 = num;
				num = (short)401473536;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.HiddenStatic = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x005B33E0 File Offset: 0x005B15E0
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x005B3494 File Offset: 0x005B1694
		internal bool RadErgoWideHornandLightsAlarmRearmOption_A7423_HiddenDynamic
		{
			get
			{
				short num = (short)1260793269;
				short num2 = num;
				num = (short)2091396533;
				switch (num2 == num)
				{
				}
				num = (short)767361025;
				if (num != 0)
				{
				}
				num = (short)695074816;
				short num3 = num;
				num = (short)557318144;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423.HiddenDynamic;
			}
			set
			{
				short num = (short)1963525296;
				short num2 = num;
				num = (short)464389296;
				switch (num2 == num)
				{
				}
				num = (short)2122907649;
				if (num != 0)
				{
				}
				num = (short)1138360320;
				short num3 = num;
				num = (short)493289472;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmRearmOption_A7423.HiddenDynamic = value;
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x060065CF RID: 26063 RVA: 0x005B3548 File Offset: 0x005B1748
		public bool RadErgoWideHornandLightsAlarmRearmOption_A7423_HasDiffs
		{
			get
			{
				short num = (short)765869786;
				short num2 = num;
				num = (short)63913690;
				switch (num2 == num)
				{
				}
				num = (short)282460161;
				if (num != 0)
				{
				}
				num = (short)385482752;
				short num3 = num;
				num = (short)1942159360;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmRearmOption_A7423._HasDiffs;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x060065D0 RID: 26064 RVA: 0x005B35FC File Offset: 0x005B17FC
		// (set) Token: 0x060065D1 RID: 26065 RVA: 0x005B36B0 File Offset: 0x005B18B0
		public int RadErgoWideHornandLightsAlarmType_A7424Value
		{
			get
			{
				short num = (short)681312257;
				if (num != 0)
				{
				}
				num = (short)1876681187;
				short num2 = num;
				num = (short)4710883;
				switch (num2 == num)
				{
				}
				num = (short)512950272;
				short num3 = num;
				num = (short)456720384;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.Value;
			}
			set
			{
				short num = (short)604111929;
				short num2 = num;
				num = (short)1700922425;
				switch (num2 == num)
				{
				}
				num = (short)792068096;
				if (num != 0)
				{
				}
				num = (short)2037448704;
				short num3 = num;
				num = (short)176685057;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.Value = value;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x060065D2 RID: 26066 RVA: 0x005B3768 File Offset: 0x005B1968
		// (set) Token: 0x060065D3 RID: 26067 RVA: 0x005B381C File Offset: 0x005B1A1C
		public string RadErgoWideHornandLightsAlarmType_A7424_UIValue
		{
			get
			{
				short num = (short)329130560;
				short num2 = num;
				num = (short)1583882816;
				switch (num2 == num)
				{
				}
				num = (short)1279459329;
				if (num != 0)
				{
				}
				num = (short)370343936;
				short num3 = num;
				num = (short)332136448;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.UIValue;
			}
			set
			{
				short num = (short)1713057553;
				short num2 = num;
				num = (short)1828335377;
				switch (num2 == num)
				{
				}
				num = (short)1718484993;
				if (num != 0)
				{
				}
				num = (short)2110717952;
				short num3 = num;
				num = (short)1345781760;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.UIValue = value;
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x060065D4 RID: 26068 RVA: 0x005B38D0 File Offset: 0x005B1AD0
		public global::AcpBusinessLayer.AcpListField RadErgoWideHornandLightsAlarmType_A7424
		{
			get
			{
				short num = (short)374875722;
				short num2 = num;
				num = (short)348726858;
				switch (num2 == num)
				{
				}
				num = (short)1382744064;
				if (num != 0)
				{
				}
				num = (short)459145216;
				short num3 = num;
				num = (short)512753665;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424;
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x060065D5 RID: 26069 RVA: 0x005B3980 File Offset: 0x005B1B80
		// (set) Token: 0x060065D6 RID: 26070 RVA: 0x005B3A30 File Offset: 0x005B1C30
		public bool RadErgoWideHornandLightsAlarmType_A7424_Applicable
		{
			get
			{
				short num = (short)460539782;
				short num2 = num;
				num = (short)110839686;
				switch (num2 == num)
				{
				}
				num = (short)807665664;
				if (num != 0)
				{
				}
				num = (short)1796407296;
				short num3 = num;
				num = (short)906035201;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.Applicable;
			}
			set
			{
				short num = (short)150810764;
				short num2 = num;
				num = (short)606154892;
				switch (num2 == num)
				{
				}
				num = (short)1436090369;
				if (num != 0)
				{
				}
				num = (short)145686528;
				short num3 = num;
				num = (short)1511391232;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.Applicable = value;
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x060065D7 RID: 26071 RVA: 0x005B3AE8 File Offset: 0x005B1CE8
		// (set) Token: 0x060065D8 RID: 26072 RVA: 0x005B3BA0 File Offset: 0x005B1DA0
		public bool RadErgoWideHornandLightsAlarmType_A7424_Valid
		{
			get
			{
				short num = (short)255721473;
				if (num != 0)
				{
				}
				num = (short)959255642;
				short num2 = num;
				num = (short)663884890;
				switch (num2 == num)
				{
				}
				num = (short)1973288960;
				short num3 = num;
				num = (short)27787264;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.Valid;
			}
			set
			{
				short num = (short)1305611505;
				short num2 = num;
				num = (short)514526449;
				switch (num2 == num)
				{
				}
				num = (short)669515777;
				if (num != 0)
				{
				}
				num = (short)753205248;
				short num3 = num;
				num = (short)1684537344;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.Valid = value;
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x060065D9 RID: 26073 RVA: 0x005B3C54 File Offset: 0x005B1E54
		// (set) Token: 0x060065DA RID: 26074 RVA: 0x005B3D08 File Offset: 0x005B1F08
		public bool RadErgoWideHornandLightsAlarmType_A7424_Visible
		{
			get
			{
				short num = (short)1912634396;
				short num2 = num;
				num = (short)2079161372;
				switch (num2 == num)
				{
				}
				num = (short)707723264;
				if (num != 0)
				{
				}
				num = (short)1786576896;
				short num3 = num;
				num = (short)1486946305;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.Visible;
			}
			set
			{
				short num = (short)1321945320;
				short num2 = num;
				num = (short)1279477992;
				switch (num2 == num)
				{
				}
				num = (short)1729232896;
				if (num != 0)
				{
				}
				num = (short)1421279232;
				short num3 = num;
				num = (short)254083073;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.Visible = value;
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x060065DB RID: 26075 RVA: 0x005B3DBC File Offset: 0x005B1FBC
		// (set) Token: 0x060065DC RID: 26076 RVA: 0x005B3E74 File Offset: 0x005B2074
		public bool RadErgoWideHornandLightsAlarmType_A7424_Editable
		{
			get
			{
				short num = (short)218162775;
				short num2 = num;
				num = (short)1208870487;
				switch (num2 == num)
				{
				}
				num = (short)1439563777;
				if (num != 0)
				{
				}
				num = (short)492896256;
				short num3 = num;
				num = (short)1511522304;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.Editable;
			}
			set
			{
				short num = (short)90387726;
				short num2 = num;
				num = (short)1217541390;
				switch (num2 == num)
				{
				}
				num = (short)1635778561;
				if (num != 0)
				{
				}
				num = (short)1058275328;
				short num3 = num;
				num = (short)1174601728;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.Editable = value;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x060065DD RID: 26077 RVA: 0x005B3F28 File Offset: 0x005B2128
		internal string RadErgoWideHornandLightsAlarmType_A7424_UILabel
		{
			get
			{
				short num = (short)806040666;
				short num2 = num;
				num = (short)817968218;
				switch (num2 == num)
				{
				}
				num = (short)1020788736;
				if (num != 0)
				{
				}
				num = (short)1456537600;
				short num3 = num;
				num = (short)428539905;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.UIName;
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x005B3FDC File Offset: 0x005B21DC
		// (set) Token: 0x060065DF RID: 26079 RVA: 0x005B4090 File Offset: 0x005B2290
		internal bool RadErgoWideHornandLightsAlarmType_A7424_HiddenStatic
		{
			get
			{
				short num = (short)83632757;
				short num2 = num;
				num = (short)406200949;
				switch (num2 == num)
				{
				}
				num = (short)1357316097;
				if (num != 0)
				{
				}
				num = (short)1951596544;
				short num3 = num;
				num = (short)1208090624;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.HiddenStatic;
			}
			set
			{
				short num = (short)672862849;
				short num2 = num;
				num = (short)894702209;
				switch (num2 == num)
				{
				}
				num = (short)649658369;
				if (num != 0)
				{
				}
				num = (short)994377728;
				short num3 = num;
				num = (short)1295056896;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.HiddenStatic = value;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x060065E0 RID: 26080 RVA: 0x005B4144 File Offset: 0x005B2344
		// (set) Token: 0x060065E1 RID: 26081 RVA: 0x005B41F8 File Offset: 0x005B23F8
		internal bool RadErgoWideHornandLightsAlarmType_A7424_HiddenDynamic
		{
			get
			{
				short num = (short)1525342904;
				short num2 = num;
				num = (short)2032394936;
				switch (num2 == num)
				{
				}
				num = (short)295895041;
				if (num != 0)
				{
				}
				num = (short)767950848;
				short num3 = num;
				num = (short)1602158592;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424.HiddenDynamic;
			}
			set
			{
				short num = (short)923397031;
				short num2 = num;
				num = (short)928639911;
				switch (num2 == num)
				{
				}
				num = (short)440074241;
				if (num != 0)
				{
				}
				num = (short)1079377920;
				short num3 = num;
				num = (short)1031602176;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsAlarmType_A7424.HiddenDynamic = value;
			}
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x060065E2 RID: 26082 RVA: 0x005B42B0 File Offset: 0x005B24B0
		public bool RadErgoWideHornandLightsAlarmType_A7424_HasDiffs
		{
			get
			{
				short num = (short)589564901;
				short num2 = num;
				num = (short)618269669;
				switch (num2 == num)
				{
				}
				num = (short)1713831937;
				if (num != 0)
				{
				}
				num = (short)1704263680;
				short num3 = num;
				num = (short)689963008;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsAlarmType_A7424._HasDiffs;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x060065E3 RID: 26083 RVA: 0x005B4364 File Offset: 0x005B2564
		// (set) Token: 0x060065E4 RID: 26084 RVA: 0x005B4418 File Offset: 0x005B2618
		public int RadErgoWideHornandLightsExternalAlarmDelaysec_A7984Value
		{
			get
			{
				short num = (short)1283387164;
				short num2 = num;
				num = (short)2075782940;
				switch (num2 == num)
				{
				}
				num = (short)1503264769;
				if (num != 0)
				{
				}
				num = (short)1078001664;
				short num3 = num;
				num = (short)2140733440;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Value;
			}
			set
			{
				short num = (short)298901391;
				short num2 = num;
				num = (short)149479311;
				switch (num2 == num)
				{
				}
				num = (short)1256718337;
				if (num != 0)
				{
				}
				num = (short)735248384;
				short num3 = num;
				num = (short)1713438720;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Value = value;
			}
		}

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x060065E5 RID: 26085 RVA: 0x005B44D0 File Offset: 0x005B26D0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideHornandLightsExternalAlarmDelaysec_A7984
		{
			get
			{
				short num = (short)1546913551;
				short num2 = num;
				num = (short)247006991;
				switch (num2 == num)
				{
				}
				num = (short)178192385;
				if (num != 0)
				{
				}
				num = (short)100007936;
				short num3 = num;
				num = (short)1853554688;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984;
			}
		}

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x060065E6 RID: 26086 RVA: 0x005B4580 File Offset: 0x005B2780
		// (set) Token: 0x060065E7 RID: 26087 RVA: 0x005B4634 File Offset: 0x005B2834
		public string RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_UIValue
		{
			get
			{
				short num = (short)39059457;
				if (num != 0)
				{
				}
				num = (short)1199149867;
				short num2 = num;
				num = (short)294425387;
				switch (num2 == num)
				{
				}
				num = (short)968491008;
				short num3 = num;
				num = (short)1506082816;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.UIValue;
			}
			set
			{
				short num = (short)132063560;
				short num2 = num;
				num = (short)868819272;
				switch (num2 == num)
				{
				}
				num = (short)80347136;
				if (num != 0)
				{
				}
				num = (short)1770717184;
				short num3 = num;
				num = (short)218562561;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.UIValue = value;
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x060065E8 RID: 26088 RVA: 0x005B46E8 File Offset: 0x005B28E8
		// (set) Token: 0x060065E9 RID: 26089 RVA: 0x005B479C File Offset: 0x005B299C
		internal int RadErgoWideHornandLightsExternalAlarmDelaysec_A7984Min
		{
			get
			{
				short num = (short)1847957093;
				short num2 = num;
				num = (short)514299493;
				switch (num2 == num)
				{
				}
				num = (short)1426456576;
				if (num != 0)
				{
				}
				num = (short)1668808704;
				short num3 = num;
				num = (short)2107834369;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Min;
			}
			set
			{
				short num = (short)929672785;
				short num2 = num;
				num = (short)1359195729;
				switch (num2 == num)
				{
				}
				num = (short)583467009;
				if (num != 0)
				{
				}
				num = (short)677642240;
				short num3 = num;
				num = (short)522321920;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Min = value;
			}
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x060065EA RID: 26090 RVA: 0x005B4850 File Offset: 0x005B2A50
		// (set) Token: 0x060065EB RID: 26091 RVA: 0x005B4904 File Offset: 0x005B2B04
		internal int RadErgoWideHornandLightsExternalAlarmDelaysec_A7984Max
		{
			get
			{
				short num = (short)238177801;
				short num2 = num;
				num = (short)1750486537;
				switch (num2 == num)
				{
				}
				num = (short)1941569536;
				if (num != 0)
				{
				}
				num = (short)516358144;
				short num3 = num;
				num = (short)665452545;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Max;
			}
			set
			{
				short num = (short)1712502229;
				short num2 = num;
				num = (short)1394259413;
				switch (num2 == num)
				{
				}
				num = (short)1476526080;
				if (num != 0)
				{
				}
				num = (short)1302396928;
				short num3 = num;
				num = (short)295305217;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Max = value;
			}
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x060065EC RID: 26092 RVA: 0x005B49BC File Offset: 0x005B2BBC
		// (set) Token: 0x060065ED RID: 26093 RVA: 0x005B4A74 File Offset: 0x005B2C74
		internal int RadErgoWideHornandLightsExternalAlarmDelaysec_A7984Step
		{
			get
			{
				short num = (short)2051941006;
				short num2 = num;
				num = (short)453386894;
				switch (num2 == num)
				{
				}
				num = (short)1065484288;
				if (num != 0)
				{
				}
				num = (short)5373952;
				short num3 = num;
				num = (short)837484545;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.StepSize;
			}
			set
			{
				short num = (short)466868256;
				short num2 = num;
				num = (short)1474353184;
				switch (num2 == num)
				{
				}
				num = (short)1340407808;
				if (num != 0)
				{
				}
				num = (short)484311040;
				short num3 = num;
				num = (short)834076673;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.StepSize = value;
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x060065EE RID: 26094 RVA: 0x005B4B28 File Offset: 0x005B2D28
		// (set) Token: 0x060065EF RID: 26095 RVA: 0x005B4BDC File Offset: 0x005B2DDC
		public bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_Applicable
		{
			get
			{
				short num = (short)106632335;
				short num2 = num;
				num = (short)1048974479;
				switch (num2 == num)
				{
				}
				num = (short)923140097;
				if (num != 0)
				{
				}
				num = (short)724238336;
				short num3 = num;
				num = (short)918224896;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Applicable;
			}
			set
			{
				short num = (short)1623074208;
				short num2 = num;
				num = (short)239281568;
				switch (num2 == num)
				{
				}
				num = (short)1400045569;
				if (num != 0)
				{
				}
				num = (short)2104492032;
				short num3 = num;
				num = (short)1151664128;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Applicable = value;
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x060065F0 RID: 26096 RVA: 0x005B4C94 File Offset: 0x005B2E94
		// (set) Token: 0x060065F1 RID: 26097 RVA: 0x005B4D48 File Offset: 0x005B2F48
		public bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_Valid
		{
			get
			{
				short num = (short)1286406145;
				if (num != 0)
				{
				}
				num = (short)1431078903;
				short num2 = num;
				num = (short)984844279;
				switch (num2 == num)
				{
				}
				num = (short)1745354752;
				short num3 = num;
				num = (short)1498611712;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Valid;
			}
			set
			{
				short num = (short)772800513;
				if (num != 0)
				{
				}
				num = (short)1024707454;
				short num2 = num;
				num = (short)1722207102;
				switch (num2 == num)
				{
				}
				num = (short)759627776;
				short num3 = num;
				num = (short)1528430592;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Valid = value;
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x060065F2 RID: 26098 RVA: 0x005B4E00 File Offset: 0x005B3000
		// (set) Token: 0x060065F3 RID: 26099 RVA: 0x005B4EB4 File Offset: 0x005B30B4
		public bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_Visible
		{
			get
			{
				short num = (short)1490987056;
				short num2 = num;
				num = (short)1104259120;
				switch (num2 == num)
				{
				}
				num = (short)290258944;
				if (num != 0)
				{
				}
				num = (short)1292697600;
				short num3 = num;
				num = (short)1368129537;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Visible;
			}
			set
			{
				short num = (short)709296129;
				if (num != 0)
				{
				}
				num = (short)354746368;
				short num2 = num;
				num = (short)2013251642;
				short num3 = num;
				num = (short)1066715194;
				switch (num3 == num)
				{
				}
				num = (short)814350336;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Visible = value;
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x005B4F6C File Offset: 0x005B316C
		// (set) Token: 0x060065F5 RID: 26101 RVA: 0x005B5024 File Offset: 0x005B3224
		public bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_Editable
		{
			get
			{
				short num = (short)1438449665;
				if (num != 0)
				{
				}
				num = (short)1324941312;
				short num2 = num;
				num = (short)753812766;
				short num3 = num;
				num = (short)2132231454;
				switch (num3 == num)
				{
				}
				num = (short)2146959360;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Editable;
			}
			set
			{
				short num = (short)628773580;
				short num2 = num;
				num = (short)1996575436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)777977856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)340983808;
				if (num != 0)
				{
				}
				num = (short)565116929;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.Editable = value;
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x005B50D8 File Offset: 0x005B32D8
		internal string RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_UILabel
		{
			get
			{
				short num = (short)191470693;
				short num2 = num;
				num = (short)573283429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)619118592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634650625;
				if (num != 0)
				{
				}
				num = (short)413204480;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.UIName;
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x060065F7 RID: 26103 RVA: 0x005B518C File Offset: 0x005B338C
		// (set) Token: 0x060065F8 RID: 26104 RVA: 0x005B5240 File Offset: 0x005B3440
		internal bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_HiddenStatic
		{
			get
			{
				short num = (short)732338014;
				short num2 = num;
				num = (short)1945737054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1968766976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730857473;
				if (num != 0)
				{
				}
				num = (short)411893760;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.HiddenStatic;
			}
			set
			{
				short num = (short)2115468617;
				short num2 = num;
				num = (short)419593545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1712390144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)373620737;
				if (num != 0)
				{
				}
				num = (short)13500416;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.HiddenStatic = value;
			}
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x005B52F4 File Offset: 0x005B34F4
		// (set) Token: 0x060065FA RID: 26106 RVA: 0x005B53A8 File Offset: 0x005B35A8
		internal bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_HiddenDynamic
		{
			get
			{
				short num = (short)131848074;
				short num2 = num;
				num = (short)1872680842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1111425024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)633274368;
				if (num != 0)
				{
				}
				num = (short)866910209;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.HiddenDynamic;
			}
			set
			{
				short num = (short)372442886;
				short num2 = num;
				num = (short)550242054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023686144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1049034752;
				if (num != 0)
				{
				}
				num = (short)240451585;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984.HiddenDynamic = value;
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x060065FB RID: 26107 RVA: 0x005B5460 File Offset: 0x005B3660
		public bool RadErgoWideHornandLightsExternalAlarmDelaysec_A7984_HasDiffs
		{
			get
			{
				short num = (short)389729012;
				short num2 = num;
				num = (short)600558324;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1478819840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205927936;
				if (num != 0)
				{
				}
				num = (short)1553203201;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsExternalAlarmDelaysec_A7984._HasDiffs;
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x005B5514 File Offset: 0x005B3714
		// (set) Token: 0x060065FD RID: 26109 RVA: 0x005B55C8 File Offset: 0x005B37C8
		public bool RadErgoWideHornandLightsHornLights_A8206Value
		{
			get
			{
				short num = (short)2090228968;
				short num2 = num;
				num = (short)104684776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351548928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1354039297;
				if (num != 0)
				{
				}
				num = (short)1589444608;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.Value;
			}
			set
			{
				short num = (short)757858305;
				if (num != 0)
				{
				}
				num = (short)1234763776;
				short num2 = num;
				num = (short)1686941273;
				short num3 = num;
				num = (short)2129768025;
				switch (num3 == num)
				{
				}
				num = (short)413138944;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.Value = value;
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x005B567C File Offset: 0x005B387C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideHornandLightsHornLights_A8206
		{
			get
			{
				short num = (short)482559859;
				short num2 = num;
				num = (short)2002405235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469303296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437649409;
				if (num != 0)
				{
				}
				num = (short)1676738560;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206;
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x005B572C File Offset: 0x005B392C
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x005B57E0 File Offset: 0x005B39E0
		public bool RadErgoWideHornandLightsHornLights_A8206_UIValue
		{
			get
			{
				short num = (short)1530501885;
				short num2 = num;
				num = (short)291740413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2039873536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)614924289;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.Value;
			}
			set
			{
				short num = (short)1919287297;
				if (num != 0)
				{
				}
				num = (short)2006908928;
				short num2 = num;
				num = (short)107861501;
				short num3 = num;
				num = (short)1054463485;
				switch (num3 == num)
				{
				}
				num = (short)1035010048;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.Value = value;
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x005B5898 File Offset: 0x005B3A98
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x005B5948 File Offset: 0x005B3B48
		public bool RadErgoWideHornandLightsHornLights_A8206_Applicable
		{
			get
			{
				short num = (short)2132975433;
				short num2 = num;
				num = (short)9150281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519910912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897581057;
				if (num != 0)
				{
				}
				num = (short)32702464;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.Applicable;
			}
			set
			{
				short num = (short)1051037908;
				short num2 = num;
				num = (short)2144047316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428670976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)511246337;
				if (num != 0)
				{
				}
				num = (short)1485307904;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.Applicable = value;
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x06006603 RID: 26115 RVA: 0x005B59FC File Offset: 0x005B3BFC
		// (set) Token: 0x06006604 RID: 26116 RVA: 0x005B5AB0 File Offset: 0x005B3CB0
		public bool RadErgoWideHornandLightsHornLights_A8206_Valid
		{
			get
			{
				short num = (short)343072923;
				short num2 = num;
				num = (short)310632603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881524736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1955659777;
				if (num != 0)
				{
				}
				num = (short)1414594560;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.Valid;
			}
			set
			{
				short num = (short)35267024;
				short num2 = num;
				num = (short)1114972624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121320960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)464453632;
				if (num != 0)
				{
				}
				num = (short)1772748801;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.Valid = value;
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x06006605 RID: 26117 RVA: 0x005B5B64 File Offset: 0x005B3D64
		// (set) Token: 0x06006606 RID: 26118 RVA: 0x005B5C18 File Offset: 0x005B3E18
		public bool RadErgoWideHornandLightsHornLights_A8206_Visible
		{
			get
			{
				short num = (short)1823741332;
				short num2 = num;
				num = (short)1193350548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1132331008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)617152513;
				if (num != 0)
				{
				}
				num = (short)1920073728;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.Visible;
			}
			set
			{
				short num = (short)1103322955;
				short num2 = num;
				num = (short)203644747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481637888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266352128;
				if (num != 0)
				{
				}
				num = (short)956432385;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.Visible = value;
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x06006607 RID: 26119 RVA: 0x005B5CCC File Offset: 0x005B3ECC
		// (set) Token: 0x06006608 RID: 26120 RVA: 0x005B5D80 File Offset: 0x005B3F80
		public bool RadErgoWideHornandLightsHornLights_A8206_Editable
		{
			get
			{
				short num = (short)624548563;
				short num2 = num;
				num = (short)2078530259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)800129024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212205568;
				if (num != 0)
				{
				}
				num = (short)1565458433;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.Editable;
			}
			set
			{
				short num = (short)1043493134;
				short num2 = num;
				num = (short)1394635022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)564264960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689780225;
				if (num != 0)
				{
				}
				num = (short)985661440;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.Editable = value;
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x06006609 RID: 26121 RVA: 0x005B5E34 File Offset: 0x005B4034
		internal string RadErgoWideHornandLightsHornLights_A8206_UILabel
		{
			get
			{
				short num = (short)1775501560;
				short num2 = num;
				num = (short)1522335992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1691156480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457441281;
				if (num != 0)
				{
				}
				num = (short)1923088384;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.UIName;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600660A RID: 26122 RVA: 0x005B5EEC File Offset: 0x005B40EC
		// (set) Token: 0x0600660B RID: 26123 RVA: 0x005B5FA4 File Offset: 0x005B41A4
		internal bool RadErgoWideHornandLightsHornLights_A8206_HiddenStatic
		{
			get
			{
				short num = (short)1010342060;
				short num2 = num;
				num = (short)1899731116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)620494848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074528257;
				if (num != 0)
				{
				}
				num = (short)1015611392;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.HiddenStatic;
			}
			set
			{
				short num = (short)2135455737;
				short num2 = num;
				num = (short)268531705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429916160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071789569;
				if (num != 0)
				{
				}
				num = (short)1313210368;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.HiddenStatic = value;
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600660C RID: 26124 RVA: 0x005B6058 File Offset: 0x005B4258
		// (set) Token: 0x0600660D RID: 26125 RVA: 0x005B610C File Offset: 0x005B430C
		internal bool RadErgoWideHornandLightsHornLights_A8206_HiddenDynamic
		{
			get
			{
				short num = (short)1030160385;
				if (num != 0)
				{
				}
				num = (short)849412096;
				short num2 = num;
				num = (short)2138044797;
				short num3 = num;
				num = (short)1679096189;
				switch (num3 == num)
				{
				}
				num = (short)1717633024;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206.HiddenDynamic;
			}
			set
			{
				short num = (short)634026679;
				short num2 = num;
				num = (short)1975220919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)846135296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1032257536;
				if (num != 0)
				{
				}
				num = (short)1277558785;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornLights_A8206.HiddenDynamic = value;
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600660E RID: 26126 RVA: 0x005B61C0 File Offset: 0x005B43C0
		public bool RadErgoWideHornandLightsHornLights_A8206_HasDiffs
		{
			get
			{
				short num = (short)2005987788;
				short num2 = num;
				num = (short)1020195276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)266338304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715339265;
				if (num != 0)
				{
				}
				num = (short)1711669248;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornLights_A8206._HasDiffs;
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x005B6274 File Offset: 0x005B4474
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x005B6328 File Offset: 0x005B4528
		public int RadErgoWideHornandLightsHornDurationsec_A8207Value
		{
			get
			{
				short num = (short)667694289;
				short num2 = num;
				num = (short)1005925585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1770389504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)681181185;
				if (num != 0)
				{
				}
				num = (short)1032781824;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Value;
			}
			set
			{
				short num = (short)1992189836;
				short num2 = num;
				num = (short)1351706508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541851648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394671617;
				if (num != 0)
				{
				}
				num = (short)236060672;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Value = value;
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x005B63DC File Offset: 0x005B45DC
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideHornandLightsHornDurationsec_A8207
		{
			get
			{
				short num = (short)1497637703;
				short num2 = num;
				num = (short)644686663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773849088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794244609;
				if (num != 0)
				{
				}
				num = (short)1833172992;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207;
			}
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x005B648C File Offset: 0x005B468C
		// (set) Token: 0x06006613 RID: 26131 RVA: 0x005B6540 File Offset: 0x005B4740
		public string RadErgoWideHornandLightsHornDurationsec_A8207_UIValue
		{
			get
			{
				short num = (short)245915232;
				short num2 = num;
				num = (short)823549536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803157504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)198967297;
				if (num != 0)
				{
				}
				num = (short)1879048192;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.UIValue;
			}
			set
			{
				short num = (short)599157136;
				short num2 = num;
				num = (short)2134665616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2107572224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)473366529;
				if (num != 0)
				{
				}
				num = (short)1654063104;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.UIValue = value;
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x06006614 RID: 26132 RVA: 0x005B65F4 File Offset: 0x005B47F4
		// (set) Token: 0x06006615 RID: 26133 RVA: 0x005B66A8 File Offset: 0x005B48A8
		internal int RadErgoWideHornandLightsHornDurationsec_A8207Min
		{
			get
			{
				short num = (short)275316737;
				if (num != 0)
				{
				}
				num = (short)876675072;
				short num2 = num;
				num = (short)2053803050;
				short num3 = num;
				num = (short)583044138;
				switch (num3 == num)
				{
				}
				num = (short)20316160;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Min;
			}
			set
			{
				short num = (short)901143098;
				short num2 = num;
				num = (short)1401248314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814757376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634191873;
				if (num != 0)
				{
				}
				num = (short)229703680;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Min = value;
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x005B6760 File Offset: 0x005B4960
		// (set) Token: 0x06006617 RID: 26135 RVA: 0x005B6814 File Offset: 0x005B4A14
		internal int RadErgoWideHornandLightsHornDurationsec_A8207Max
		{
			get
			{
				short num = (short)1883491683;
				short num2 = num;
				num = (short)935120227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)129433600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460193793;
				if (num != 0)
				{
				}
				num = (short)1557266432;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Max;
			}
			set
			{
				short num = (short)1700892651;
				short num2 = num;
				num = (short)1852346347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)545849344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1055457281;
				if (num != 0)
				{
				}
				num = (short)1088684032;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Max = value;
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x005B68CC File Offset: 0x005B4ACC
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x005B6980 File Offset: 0x005B4B80
		internal int RadErgoWideHornandLightsHornDurationsec_A8207Step
		{
			get
			{
				short num = (short)1934118721;
				short num2 = num;
				num = (short)1647857473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301413888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)306970624;
				if (num != 0)
				{
				}
				num = (short)901644289;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.StepSize;
			}
			set
			{
				short num = (short)1064137863;
				short num2 = num;
				num = (short)58225799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533266432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89063425;
				if (num != 0)
				{
				}
				num = (short)1592918016;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.StepSize = value;
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x005B6A38 File Offset: 0x005B4C38
		// (set) Token: 0x0600661B RID: 26139 RVA: 0x005B6AEC File Offset: 0x005B4CEC
		public bool RadErgoWideHornandLightsHornDurationsec_A8207_Applicable
		{
			get
			{
				short num = (short)1173582290;
				short num2 = num;
				num = (short)1671852498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)331022336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)590479361;
				if (num != 0)
				{
				}
				num = (short)1493630976;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Applicable;
			}
			set
			{
				short num = (short)1698498565;
				short num2 = num;
				num = (short)285083653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)493748224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536412161;
				if (num != 0)
				{
				}
				num = (short)1022623744;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Applicable = value;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600661C RID: 26140 RVA: 0x005B6BA0 File Offset: 0x005B4DA0
		// (set) Token: 0x0600661D RID: 26141 RVA: 0x005B6C54 File Offset: 0x005B4E54
		public bool RadErgoWideHornandLightsHornDurationsec_A8207_Valid
		{
			get
			{
				short num = (short)158924809;
				short num2 = num;
				num = (short)1442578441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483407360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1965031425;
				if (num != 0)
				{
				}
				num = (short)1466302464;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Valid;
			}
			set
			{
				short num = (short)51497015;
				short num2 = num;
				num = (short)915195959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479344128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107361793;
				if (num != 0)
				{
				}
				num = (short)245366784;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Valid = value;
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x005B6D08 File Offset: 0x005B4F08
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x005B6DBC File Offset: 0x005B4FBC
		public bool RadErgoWideHornandLightsHornDurationsec_A8207_Visible
		{
			get
			{
				short num = (short)1984364545;
				if (num != 0)
				{
				}
				num = (short)859832320;
				short num2 = num;
				num = (short)1398391904;
				short num3 = num;
				num = (short)515556448;
				switch (num3 == num)
				{
				}
				num = (short)1125842944;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Visible;
			}
			set
			{
				short num = (short)640739339;
				short num2 = num;
				num = (short)1978787851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)24248320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039335424;
				if (num != 0)
				{
				}
				num = (short)885325825;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Visible = value;
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x005B6E70 File Offset: 0x005B5070
		// (set) Token: 0x06006621 RID: 26145 RVA: 0x005B6F28 File Offset: 0x005B5128
		public bool RadErgoWideHornandLightsHornDurationsec_A8207_Editable
		{
			get
			{
				short num = (short)1869021185;
				if (num != 0)
				{
				}
				num = (short)1700462592;
				short num2 = num;
				num = (short)295200477;
				short num3 = num;
				num = (short)933586653;
				switch (num3 == num)
				{
				}
				num = (short)36175872;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.Editable;
			}
			set
			{
				short num = (short)991408907;
				short num2 = num;
				num = (short)1058910987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620967424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534656513;
				if (num != 0)
				{
				}
				num = (short)515506176;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.Editable = value;
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x06006622 RID: 26146 RVA: 0x005B6FE0 File Offset: 0x005B51E0
		internal string RadErgoWideHornandLightsHornDurationsec_A8207_UILabel
		{
			get
			{
				short num = (short)1542381527;
				short num2 = num;
				num = (short)1116594135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)36110336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)165609472;
				if (num != 0)
				{
				}
				num = (short)721158145;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.UIName;
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x06006623 RID: 26147 RVA: 0x005B7098 File Offset: 0x005B5298
		// (set) Token: 0x06006624 RID: 26148 RVA: 0x005B7150 File Offset: 0x005B5350
		internal bool RadErgoWideHornandLightsHornDurationsec_A8207_HiddenStatic
		{
			get
			{
				short num = (short)979796805;
				short num2 = num;
				num = (short)1134920517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598488576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314834945;
				if (num != 0)
				{
				}
				num = (short)2037972992;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.HiddenStatic;
			}
			set
			{
				short num = (short)1192838988;
				short num2 = num;
				num = (short)484853580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1049427968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159135233;
				if (num != 0)
				{
				}
				num = (short)701300736;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.HiddenStatic = value;
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x06006625 RID: 26149 RVA: 0x005B7208 File Offset: 0x005B5408
		// (set) Token: 0x06006626 RID: 26150 RVA: 0x005B72BC File Offset: 0x005B54BC
		internal bool RadErgoWideHornandLightsHornDurationsec_A8207_HiddenDynamic
		{
			get
			{
				short num = (short)526843905;
				if (num != 0)
				{
				}
				num = (short)257294336;
				short num2 = num;
				num = (short)1487549428;
				short num3 = num;
				num = (short)144651252;
				switch (num3 == num)
				{
				}
				num = (short)2018574336;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207.HiddenDynamic;
			}
			set
			{
				short num = (short)1434190799;
				short num2 = num;
				num = (short)2044003279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469827584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558380544;
				if (num != 0)
				{
				}
				num = (short)2062417921;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsHornDurationsec_A8207.HiddenDynamic = value;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x06006627 RID: 26151 RVA: 0x005B7370 File Offset: 0x005B5570
		public bool RadErgoWideHornandLightsHornDurationsec_A8207_HasDiffs
		{
			get
			{
				short num = (short)912618083;
				short num2 = num;
				num = (short)1470394979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)283770880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575995905;
				if (num != 0)
				{
				}
				num = (short)2091319296;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsHornDurationsec_A8207._HasDiffs;
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x005B7424 File Offset: 0x005B5624
		// (set) Token: 0x06006629 RID: 26153 RVA: 0x005B74DC File Offset: 0x005B56DC
		public int RadErgoWideHornandLightsLightDurationsec_A8430Value
		{
			get
			{
				short num = (short)332726273;
				if (num != 0)
				{
				}
				num = (short)1713963008;
				short num2 = num;
				num = (short)1589865522;
				short num3 = num;
				num = (short)1193503794;
				switch (num3 == num)
				{
				}
				num = (short)1823670272;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Value;
			}
			set
			{
				short num = (short)2116078940;
				short num2 = num;
				num = (short)1420545372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)558694400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1523122176;
				if (num != 0)
				{
				}
				num = (short)1558118401;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Value = value;
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x005B7594 File Offset: 0x005B5794
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideHornandLightsLightDurationsec_A8430
		{
			get
			{
				short num = (short)1278564140;
				short num2 = num;
				num = (short)277042988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1013317632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307494913;
				if (num != 0)
				{
				}
				num = (short)183238656;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430;
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600662B RID: 26155 RVA: 0x005B7640 File Offset: 0x005B5840
		// (set) Token: 0x0600662C RID: 26156 RVA: 0x005B76F8 File Offset: 0x005B58F8
		public string RadErgoWideHornandLightsLightDurationsec_A8430_UIValue
		{
			get
			{
				short num = (short)856441893;
				short num2 = num;
				num = (short)420103205;
				switch (num2 == num)
				{
				}
				num = (short)1641480193;
				if (num != 0)
				{
				}
				num = (short)1377763328;
				short num3 = num;
				num = (short)2093875200;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.UIValue;
			}
			set
			{
				short num = (short)334871072;
				short num2 = num;
				num = (short)1951775264;
				switch (num2 == num)
				{
				}
				num = (short)1648885761;
				if (num != 0)
				{
				}
				num = (short)1531379712;
				short num3 = num;
				num = (short)113901568;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.UIValue = value;
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x005B77AC File Offset: 0x005B59AC
		// (set) Token: 0x0600662E RID: 26158 RVA: 0x005B7860 File Offset: 0x005B5A60
		internal int RadErgoWideHornandLightsLightDurationsec_A8430Min
		{
			get
			{
				short num = (short)966141036;
				short num2 = num;
				num = (short)1533617260;
				switch (num2 == num)
				{
				}
				num = (short)1504641025;
				if (num != 0)
				{
				}
				num = (short)1983250432;
				short num3 = num;
				num = (short)1741488128;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Min;
			}
			set
			{
				short num = (short)1298832864;
				short num2 = num;
				num = (short)387227104;
				switch (num2 == num)
				{
				}
				num = (short)1240203265;
				if (num != 0)
				{
				}
				num = (short)1831796736;
				short num3 = num;
				num = (short)1872297984;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Min = value;
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600662F RID: 26159 RVA: 0x005B7914 File Offset: 0x005B5B14
		// (set) Token: 0x06006630 RID: 26160 RVA: 0x005B79C8 File Offset: 0x005B5BC8
		internal int RadErgoWideHornandLightsLightDurationsec_A8430Max
		{
			get
			{
				short num = (short)586810002;
				short num2 = num;
				num = (short)367461010;
				switch (num2 == num)
				{
				}
				num = (short)1876361217;
				if (num != 0)
				{
				}
				num = (short)1230700544;
				short num3 = num;
				num = (short)75628544;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Max;
			}
			set
			{
				short num = (short)1470555582;
				short num2 = num;
				num = (short)1324017086;
				switch (num2 == num)
				{
				}
				num = (short)443482113;
				if (num != 0)
				{
				}
				num = (short)1660551168;
				short num3 = num;
				num = (short)977207296;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Max = value;
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x06006631 RID: 26161 RVA: 0x005B7A7C File Offset: 0x005B5C7C
		// (set) Token: 0x06006632 RID: 26162 RVA: 0x005B7B30 File Offset: 0x005B5D30
		internal int RadErgoWideHornandLightsLightDurationsec_A8430Step
		{
			get
			{
				short num = (short)1569772084;
				short num2 = num;
				num = (short)432853556;
				switch (num2 == num)
				{
				}
				num = (short)1503657985;
				if (num != 0)
				{
				}
				num = (short)1212940288;
				short num3 = num;
				num = (short)60489728;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.StepSize;
			}
			set
			{
				short num = (short)969040743;
				short num2 = num;
				num = (short)368141159;
				switch (num2 == num)
				{
				}
				num = (short)1616969729;
				if (num != 0)
				{
				}
				num = (short)1141440512;
				short num3 = num;
				num = (short)1571946496;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.StepSize = value;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x06006633 RID: 26163 RVA: 0x005B7BE4 File Offset: 0x005B5DE4
		// (set) Token: 0x06006634 RID: 26164 RVA: 0x005B7C9C File Offset: 0x005B5E9C
		public bool RadErgoWideHornandLightsLightDurationsec_A8430_Applicable
		{
			get
			{
				short num = (short)999242144;
				short num2 = num;
				num = (short)978729376;
				switch (num2 == num)
				{
				}
				num = (short)2052194305;
				if (num != 0)
				{
				}
				num = (short)2028535808;
				short num3 = num;
				num = (short)25952256;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Applicable;
			}
			set
			{
				short num = (short)986271736;
				short num2 = num;
				num = (short)271601656;
				switch (num2 == num)
				{
				}
				num = (short)1495203841;
				if (num != 0)
				{
				}
				num = (short)1884684288;
				short num3 = num;
				num = (short)728498176;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Applicable = value;
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x06006635 RID: 26165 RVA: 0x005B7D54 File Offset: 0x005B5F54
		// (set) Token: 0x06006636 RID: 26166 RVA: 0x005B7E08 File Offset: 0x005B6008
		public bool RadErgoWideHornandLightsLightDurationsec_A8430_Valid
		{
			get
			{
				short num = (short)1383596033;
				if (num != 0)
				{
				}
				num = (short)1960500707;
				short num2 = num;
				num = (short)1470750179;
				switch (num2 == num)
				{
				}
				num = (short)517865472;
				short num3 = num;
				num = (short)195231744;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Valid;
			}
			set
			{
				short num = (short)16715475;
				short num2 = num;
				num = (short)923340499;
				switch (num2 == num)
				{
				}
				num = (short)24707073;
				if (num != 0)
				{
				}
				num = (short)1741553664;
				short num3 = num;
				num = (short)2062155776;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Valid = value;
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x06006637 RID: 26167 RVA: 0x005B7EBC File Offset: 0x005B60BC
		// (set) Token: 0x06006638 RID: 26168 RVA: 0x005B7F70 File Offset: 0x005B6170
		public bool RadErgoWideHornandLightsLightDurationsec_A8430_Visible
		{
			get
			{
				short num = (short)865434563;
				short num2 = num;
				num = (short)323189699;
				switch (num2 == num)
				{
				}
				num = (short)1692991489;
				if (num != 0)
				{
				}
				num = (short)798162944;
				short num3 = num;
				num = (short)408813568;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Visible;
			}
			set
			{
				short num = (short)1656017381;
				short num2 = num;
				num = (short)759353829;
				switch (num2 == num)
				{
				}
				num = (short)1026752513;
				if (num != 0)
				{
				}
				num = (short)588185600;
				short num3 = num;
				num = (short)1954349056;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Visible = value;
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x06006639 RID: 26169 RVA: 0x005B8024 File Offset: 0x005B6224
		// (set) Token: 0x0600663A RID: 26170 RVA: 0x005B80DC File Offset: 0x005B62DC
		public bool RadErgoWideHornandLightsLightDurationsec_A8430_Editable
		{
			get
			{
				short num = (short)360841448;
				short num2 = num;
				num = (short)537788648;
				switch (num2 == num)
				{
				}
				num = (short)257687552;
				if (num != 0)
				{
				}
				num = (short)1740505088;
				short num3 = num;
				num = (short)1469775873;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.Editable;
			}
			set
			{
				short num = (short)686985561;
				short num2 = num;
				num = (short)10129753;
				switch (num2 == num)
				{
				}
				num = (short)1855913985;
				if (num != 0)
				{
				}
				num = (short)1867841536;
				short num3 = num;
				num = (short)241565696;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.Editable = value;
			}
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600663B RID: 26171 RVA: 0x005B8190 File Offset: 0x005B6390
		internal string RadErgoWideHornandLightsLightDurationsec_A8430_UILabel
		{
			get
			{
				short num = (short)853192008;
				short num2 = num;
				num = (short)64335176;
				switch (num2 == num)
				{
				}
				num = (short)1331691521;
				if (num != 0)
				{
				}
				num = (short)1347813376;
				short num3 = num;
				num = (short)1657667584;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.UIName;
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x005B8248 File Offset: 0x005B6448
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x005B82FC File Offset: 0x005B64FC
		internal bool RadErgoWideHornandLightsLightDurationsec_A8430_HiddenStatic
		{
			get
			{
				short num = (short)672375745;
				short num2 = num;
				num = (short)46441409;
				switch (num2 == num)
				{
				}
				num = (short)80805889;
				if (num != 0)
				{
				}
				num = (short)1802305536;
				short num3 = num;
				num = (short)1990524928;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.HiddenStatic;
			}
			set
			{
				short num = (short)860182341;
				short num2 = num;
				num = (short)797005637;
				switch (num2 == num)
				{
				}
				num = (short)1834614785;
				if (num != 0)
				{
				}
				num = (short)131465216;
				short num3 = num;
				num = (short)1054801920;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.HiddenStatic = value;
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x005B83B4 File Offset: 0x005B65B4
		// (set) Token: 0x0600663F RID: 26175 RVA: 0x005B846C File Offset: 0x005B666C
		internal bool RadErgoWideHornandLightsLightDurationsec_A8430_HiddenDynamic
		{
			get
			{
				short num = (short)226220745;
				short num2 = num;
				num = (short)921033417;
				switch (num2 == num)
				{
				}
				num = (short)1699479553;
				if (num != 0)
				{
				}
				num = (short)405012480;
				short num3 = num;
				num = (short)1246625792;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430.HiddenDynamic;
			}
			set
			{
				short num = (short)541305046;
				short num2 = num;
				num = (short)1897965782;
				switch (num2 == num)
				{
				}
				num = (short)1599864833;
				if (num != 0)
				{
				}
				num = (short)1143472128;
				short num3 = num;
				num = (short)1253638144;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsLightDurationsec_A8430.HiddenDynamic = value;
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x005B8524 File Offset: 0x005B6724
		public bool RadErgoWideHornandLightsLightDurationsec_A8430_HasDiffs
		{
			get
			{
				short num = (short)1936211095;
				short num2 = num;
				num = (short)485702807;
				switch (num2 == num)
				{
				}
				num = (short)1675558913;
				if (num != 0)
				{
				}
				num = (short)1967194112;
				short num3 = num;
				num = (short)1847984128;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsLightDurationsec_A8430._HasDiffs;
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x005B85D8 File Offset: 0x005B67D8
		// (set) Token: 0x06006642 RID: 26178 RVA: 0x005B8688 File Offset: 0x005B6888
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697Value
		{
			get
			{
				short num = (short)522170528;
				short num2 = num;
				num = (short)696627360;
				switch (num2 == num)
				{
				}
				num = (short)1959985153;
				if (num != 0)
				{
				}
				num = (short)511115264;
				short num3 = num;
				num = (short)2012872704;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.Value;
			}
			set
			{
				short num = (short)1261244699;
				short num2 = num;
				num = (short)1638535451;
				switch (num2 == num)
				{
				}
				num = (short)1262551041;
				if (num != 0)
				{
				}
				num = (short)1068826624;
				short num3 = num;
				num = (short)1267662848;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.Value = value;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x005B8740 File Offset: 0x005B6940
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideHornandLightsPermanentHornLights_A8697
		{
			get
			{
				short num = (short)1844725362;
				short num2 = num;
				num = (short)641746546;
				switch (num2 == num)
				{
				}
				num = (short)885719041;
				if (num != 0)
				{
				}
				num = (short)254672896;
				short num3 = num;
				num = (short)2029846528;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697;
			}
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x06006644 RID: 26180 RVA: 0x005B87F0 File Offset: 0x005B69F0
		// (set) Token: 0x06006645 RID: 26181 RVA: 0x005B88A4 File Offset: 0x005B6AA4
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697_UIValue
		{
			get
			{
				short num = (short)1842937857;
				if (num != 0)
				{
				}
				num = (short)35822303;
				short num2 = num;
				num = (short)469146335;
				switch (num2 == num)
				{
				}
				num = (short)401211392;
				short num3 = num;
				num = (short)500826112;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.Value;
			}
			set
			{
				short num = (short)1187381249;
				if (num != 0)
				{
				}
				num = (short)1465478791;
				short num2 = num;
				num = (short)1834905223;
				switch (num2 == num)
				{
				}
				num = (short)1351680000;
				short num3 = num;
				num = (short)353763328;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.Value = value;
			}
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x005B8958 File Offset: 0x005B6B58
		// (set) Token: 0x06006647 RID: 26183 RVA: 0x005B8A0C File Offset: 0x005B6C0C
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697_Applicable
		{
			get
			{
				short num = (short)608169349;
				short num2 = num;
				num = (short)425127301;
				switch (num2 == num)
				{
				}
				num = (short)1757020160;
				if (num != 0)
				{
				}
				num = (short)1317732352;
				short num3 = num;
				num = (short)493486081;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.Applicable;
			}
			set
			{
				short num = (short)1293497240;
				short num2 = num;
				num = (short)805712792;
				switch (num2 == num)
				{
				}
				num = (short)1771962369;
				if (num != 0)
				{
				}
				num = (short)1046937600;
				short num3 = num;
				num = (short)1027801088;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.Applicable = value;
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x06006648 RID: 26184 RVA: 0x005B8AC0 File Offset: 0x005B6CC0
		// (set) Token: 0x06006649 RID: 26185 RVA: 0x005B8B70 File Offset: 0x005B6D70
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697_Valid
		{
			get
			{
				short num = (short)81993591;
				short num2 = num;
				num = (short)1157111671;
				switch (num2 == num)
				{
				}
				num = (short)926220288;
				if (num != 0)
				{
				}
				num = (short)1355153408;
				short num3 = num;
				num = (short)1321205761;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.Valid;
			}
			set
			{
				short num = (short)798031873;
				if (num != 0)
				{
				}
				num = (short)1511320573;
				short num2 = num;
				num = (short)2013850621;
				switch (num2 == num)
				{
				}
				num = (short)199622656;
				short num3 = num;
				num = (short)875692032;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.Valid = value;
			}
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x005B8C24 File Offset: 0x005B6E24
		// (set) Token: 0x0600664B RID: 26187 RVA: 0x005B8CD8 File Offset: 0x005B6ED8
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697_Visible
		{
			get
			{
				short num = (short)1694367069;
				short num2 = num;
				num = (short)1619983709;
				switch (num2 == num)
				{
				}
				num = (short)1503592449;
				if (num != 0)
				{
				}
				num = (short)1474953216;
				short num3 = num;
				num = (short)1271595008;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.Visible;
			}
			set
			{
				short num = (short)1116864513;
				if (num != 0)
				{
				}
				num = (short)164019917;
				short num2 = num;
				num = (short)1050984141;
				switch (num2 == num)
				{
				}
				num = (short)1194917888;
				short num3 = num;
				num = (short)1402011648;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.Visible = value;
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x005B8D90 File Offset: 0x005B6F90
		// (set) Token: 0x0600664D RID: 26189 RVA: 0x005B8E44 File Offset: 0x005B7044
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697_Editable
		{
			get
			{
				short num = (short)378471181;
				short num2 = num;
				num = (short)1347420941;
				switch (num2 == num)
				{
				}
				num = (short)1542062080;
				if (num != 0)
				{
				}
				num = (short)1991770112;
				short num3 = num;
				num = (short)1216413697;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.Editable;
			}
			set
			{
				short num = (short)1863747901;
				short num2 = num;
				num = (short)1364298045;
				switch (num2 == num)
				{
				}
				num = (short)335085568;
				if (num != 0)
				{
				}
				num = (short)1350696960;
				short num3 = num;
				num = (short)1571225601;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.Editable = value;
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600664E RID: 26190 RVA: 0x005B8EF8 File Offset: 0x005B70F8
		internal string RadErgoWideHornandLightsPermanentHornLights_A8697_UILabel
		{
			get
			{
				short num = (short)1854603265;
				if (num != 0)
				{
				}
				num = (short)1879627211;
				short num2 = num;
				num = (short)2033636811;
				switch (num2 == num)
				{
				}
				num = (short)819527680;
				short num3 = num;
				num = (short)472186880;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.UIName;
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x005B8FAC File Offset: 0x005B71AC
		// (set) Token: 0x06006650 RID: 26192 RVA: 0x005B9060 File Offset: 0x005B7260
		internal bool RadErgoWideHornandLightsPermanentHornLights_A8697_HiddenStatic
		{
			get
			{
				short num = (short)725297876;
				short num2 = num;
				num = (short)2117348052;
				switch (num2 == num)
				{
				}
				num = (short)2066612224;
				if (num != 0)
				{
				}
				num = (short)678035456;
				short num3 = num;
				num = (short)923140097;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.HiddenStatic;
			}
			set
			{
				short num = (short)1936840358;
				short num2 = num;
				num = (short)230807206;
				switch (num2 == num)
				{
				}
				num = (short)678494209;
				if (num != 0)
				{
				}
				num = (short)1183514624;
				short num3 = num;
				num = (short)849084416;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.HiddenStatic = value;
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x005B9118 File Offset: 0x005B7318
		// (set) Token: 0x06006652 RID: 26194 RVA: 0x005B91CC File Offset: 0x005B73CC
		internal bool RadErgoWideHornandLightsPermanentHornLights_A8697_HiddenDynamic
		{
			get
			{
				short num = (short)1373335360;
				short num2 = num;
				num = (short)1606315840;
				switch (num2 == num)
				{
				}
				num = (short)125763584;
				if (num != 0)
				{
				}
				num = (short)578551808;
				short num3 = num;
				num = (short)1401159681;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697.HiddenDynamic;
			}
			set
			{
				short num = (short)757342791;
				short num2 = num;
				num = (short)385950279;
				switch (num2 == num)
				{
				}
				num = (short)1354956801;
				if (num != 0)
				{
				}
				num = (short)1210253312;
				short num3 = num;
				num = (short)125894656;
				if (num != 0)
				{
				}
				this.radErgoWideHornandLightsPermanentHornLights_A8697.HiddenDynamic = value;
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x06006653 RID: 26195 RVA: 0x005B9280 File Offset: 0x005B7480
		public bool RadErgoWideHornandLightsPermanentHornLights_A8697_HasDiffs
		{
			get
			{
				short num = (short)1711615444;
				short num2 = num;
				num = (short)864562644;
				switch (num2 == num)
				{
				}
				num = (short)2084372480;
				if (num != 0)
				{
				}
				num = (short)1324351488;
				short num3 = num;
				num = (short)1485176833;
				if (num != 0)
				{
				}
				return this.radErgoWideHornandLightsPermanentHornLights_A8697._HasDiffs;
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x06006654 RID: 26196 RVA: 0x005B9334 File Offset: 0x005B7534
		// (set) Token: 0x06006655 RID: 26197 RVA: 0x005B93E8 File Offset: 0x005B75E8
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510Value
		{
			get
			{
				short num = (short)1188717776;
				short num2 = num;
				num = (short)493642960;
				switch (num2 == num)
				{
				}
				num = (short)1570766848;
				if (num != 0)
				{
				}
				num = (short)1711800320;
				short num3 = num;
				num = (short)1993605121;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Value;
			}
			set
			{
				short num = (short)560827072;
				short num2 = num;
				num = (short)966494912;
				switch (num2 == num)
				{
				}
				num = (short)242614272;
				if (num != 0)
				{
				}
				num = (short)1454505984;
				short num3 = num;
				num = (short)917372929;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Value = value;
			}
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x06006656 RID: 26198 RVA: 0x005B949C File Offset: 0x005B769C
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideHornAndLightsTwoAlarmOption_A9510
		{
			get
			{
				short num = (short)1429379090;
				short num2 = num;
				num = (short)2076416018;
				switch (num2 == num)
				{
				}
				num = (short)925499393;
				if (num != 0)
				{
				}
				num = (short)410910720;
				short num3 = num;
				num = (short)971833344;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510;
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x005B9550 File Offset: 0x005B7750
		// (set) Token: 0x06006658 RID: 26200 RVA: 0x005B9604 File Offset: 0x005B7804
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_UIValue
		{
			get
			{
				short num = (short)1635123201;
				if (num != 0)
				{
				}
				num = (short)104237306;
				short num2 = num;
				num = (short)378374394;
				switch (num2 == num)
				{
				}
				num = (short)783351808;
				short num3 = num;
				num = (short)1447886848;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Value;
			}
			set
			{
				short num = (short)1496425528;
				short num2 = num;
				num = (short)412984376;
				switch (num2 == num)
				{
				}
				num = (short)2143879169;
				if (num != 0)
				{
				}
				num = (short)473628672;
				short num3 = num;
				num = (short)791543808;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Value = value;
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x06006659 RID: 26201 RVA: 0x005B96B8 File Offset: 0x005B78B8
		// (set) Token: 0x0600665A RID: 26202 RVA: 0x005B9770 File Offset: 0x005B7970
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_Applicable
		{
			get
			{
				short num = (short)494862337;
				if (num != 0)
				{
				}
				num = (short)1479697428;
				short num2 = num;
				num = (short)1091920916;
				switch (num2 == num)
				{
				}
				num = (short)532152320;
				short num3 = num;
				num = (short)402128896;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Applicable;
			}
			set
			{
				short num = (short)454734175;
				short num2 = num;
				num = (short)1871360351;
				switch (num2 == num)
				{
				}
				num = (short)285540352;
				if (num != 0)
				{
				}
				num = (short)464846848;
				short num3 = num;
				num = (short)1753874433;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Applicable = value;
			}
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x005B9828 File Offset: 0x005B7A28
		// (set) Token: 0x0600665C RID: 26204 RVA: 0x005B98DC File Offset: 0x005B7ADC
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_Valid
		{
			get
			{
				short num = (short)361121379;
				short num2 = num;
				num = (short)1824605795;
				switch (num2 == num)
				{
				}
				num = (short)181534721;
				if (num != 0)
				{
				}
				num = (short)375062528;
				short num3 = num;
				num = (short)1790771200;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Valid;
			}
			set
			{
				short num = (short)1520280218;
				short num2 = num;
				num = (short)481469082;
				switch (num2 == num)
				{
				}
				num = (short)110034945;
				if (num != 0)
				{
				}
				num = (short)551092224;
				short num3 = num;
				num = (short)2056650752;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Valid = value;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x005B9990 File Offset: 0x005B7B90
		// (set) Token: 0x0600665E RID: 26206 RVA: 0x005B9A48 File Offset: 0x005B7C48
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_Visible
		{
			get
			{
				short num = (short)1056069255;
				short num2 = num;
				num = (short)468539015;
				switch (num2 == num)
				{
				}
				num = (short)567214081;
				if (num != 0)
				{
				}
				num = (short)337838080;
				short num3 = num;
				num = (short)198443008;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Visible;
			}
			set
			{
				short num = (short)279367329;
				short num2 = num;
				num = (short)1197067937;
				switch (num2 == num)
				{
				}
				num = (short)592510977;
				if (num != 0)
				{
				}
				num = (short)465567744;
				short num3 = num;
				num = (short)1108017152;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Visible = value;
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x005B9B00 File Offset: 0x005B7D00
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x005B9BB8 File Offset: 0x005B7DB8
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_Editable
		{
			get
			{
				short num = (short)1147535360;
				short num2 = num;
				num = (short)902567148;
				short num3 = num;
				num = (short)875828460;
				switch (num3 == num)
				{
				}
				num = (short)2087583744;
				if (num != 0)
				{
				}
				num = (short)945684481;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Editable;
			}
			set
			{
				short num = (short)936443904;
				short num2 = num;
				num = (short)1825632914;
				short num3 = num;
				num = (short)737800850;
				switch (num3 == num)
				{
				}
				num = (short)791281665;
				if (num != 0)
				{
				}
				num = (short)1781858304;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.Editable = value;
			}
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x005B9C6C File Offset: 0x005B7E6C
		internal string RadErgoWideHornAndLightsTwoAlarmOption_A9510_UILabel
		{
			get
			{
				short num = (short)371916800;
				short num2 = num;
				num = (short)356712449;
				if (num != 0)
				{
				}
				num = (short)1445375574;
				short num3 = num;
				num = (short)937274966;
				switch (num3 == num)
				{
				}
				num = (short)1537343488;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.UIName;
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x06006662 RID: 26210 RVA: 0x005B9D24 File Offset: 0x005B7F24
		// (set) Token: 0x06006663 RID: 26211 RVA: 0x005B9DDC File Offset: 0x005B7FDC
		internal bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_HiddenStatic
		{
			get
			{
				short num = (short)1743126528;
				short num2 = num;
				num = (short)1053229057;
				if (num != 0)
				{
				}
				num = (short)1448806286;
				short num3 = num;
				num = (short)2076116878;
				switch (num3 == num)
				{
				}
				num = (short)1607532544;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.HiddenStatic;
			}
			set
			{
				short num = (short)1164181504;
				short num2 = num;
				num = (short)348129663;
				short num3 = num;
				num = (short)1583548799;
				switch (num3 == num)
				{
				}
				num = (short)33030145;
				if (num != 0)
				{
				}
				num = (short)968359936;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.HiddenStatic = value;
			}
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x005B9E90 File Offset: 0x005B8090
		// (set) Token: 0x06006665 RID: 26213 RVA: 0x005B9F44 File Offset: 0x005B8144
		internal bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_HiddenDynamic
		{
			get
			{
				short num = (short)1794637824;
				short num2 = num;
				num = (short)1756173137;
				short num3 = num;
				num = (short)1605505873;
				switch (num3 == num)
				{
				}
				num = (short)699793408;
				if (num != 0)
				{
				}
				num = (short)2126446593;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510.HiddenDynamic;
			}
			set
			{
				short num = (short)1305280512;
				short num2 = num;
				num = (short)1670600558;
				short num3 = num;
				num = (short)1730303854;
				switch (num3 == num)
				{
				}
				num = (short)2023227393;
				if (num != 0)
				{
				}
				num = (short)310837248;
				if (num != 0)
				{
				}
				this.radErgoWideHornAndLightsTwoAlarmOption_A9510.HiddenDynamic = value;
			}
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x005B9FFC File Offset: 0x005B81FC
		public bool RadErgoWideHornAndLightsTwoAlarmOption_A9510_HasDiffs
		{
			get
			{
				short num = (short)1802633216;
				short num2 = num;
				num = (short)1985439667;
				short num3 = num;
				num = (short)1152673715;
				switch (num3 == num)
				{
				}
				num = (short)819068929;
				if (num != 0)
				{
				}
				num = (short)962461696;
				if (num != 0)
				{
				}
				return this.radErgoWideHornAndLightsTwoAlarmOption_A9510._HasDiffs;
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x06006667 RID: 26215 RVA: 0x005BA0AC File Offset: 0x005B82AC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1470758912;
				short num2 = num;
				num = (short)1959884599;
				short num3 = num;
				num = (short)1657042743;
				switch (num3 == num)
				{
				}
				num = (short)139657217;
				if (num != 0)
				{
				}
				num = (short)1619460096;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x005BA16C File Offset: 0x005B836C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num2 = (short)1329528834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_B1;
				case 2:
					num2 = (short)1647902724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2103902209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1491002543;
					short num3 = num2;
					num2 = (short)1631904943;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1669529600;
						if (num2 != 0)
						{
						}
						num2 = (short)1118437379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			IL_B1:
			num2 = (short)74317825;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			num2 = (short)387776512;
			short num4 = num2;
			result = null;
			num2 = (short)1938227200;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040026A3 RID: 9891
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideHornandLightsAlarmRearmOption_A7423;

		// Token: 0x040026A4 RID: 9892
		private global::AcpBusinessLayer.AcpListField radErgoWideHornandLightsAlarmType_A7424;

		// Token: 0x040026A5 RID: 9893
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideHornandLightsExternalAlarmDelaysec_A7984;

		// Token: 0x040026A6 RID: 9894
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideHornandLightsHornLights_A8206;

		// Token: 0x040026A7 RID: 9895
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideHornandLightsHornDurationsec_A8207;

		// Token: 0x040026A8 RID: 9896
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideHornandLightsLightDurationsec_A8430;

		// Token: 0x040026A9 RID: 9897
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideHornandLightsPermanentHornLights_A8697;

		// Token: 0x040026AA RID: 9898
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideHornAndLightsTwoAlarmOption_A9510;
	}
}
