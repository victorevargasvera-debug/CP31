using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x02000058 RID: 88
	[global::System.Serializable]
	public class CAIData : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00055330 File Offset: 0x00053530
		public CAIData(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0005534C File Offset: 0x0005354C
		protected CAIData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00055364 File Offset: 0x00053564
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1936687871;
			short num2 = num;
			num = (short)112689919;
			switch (num2 == num)
			{
			}
			num = (short)1284964352;
			short num3 = num;
			num = (short)1024262145;
			if (num != 0)
			{
			}
			num = (short)110755840;
			if (num != 0)
			{
			}
			this.trkWideCAIDataFrameSyncSeekPeriodms_A8146 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩ꫫ鳭釯鿱釳ꗵ臷铹鿻귽旿朁漃嘅洇砉攋愍琏缑朓䤕夗∙ⴛ⨝ᘟ", a_), global::CommonResources.AcgResources.ID_FRAMESYNCSEEKPERIODMS, 0, 100, null, null, 0, 50);
			this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.DataTransferOrder = 5;
			this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.ShowHexValue = false;
			this.trkWideCAIDataTxLimitedPatienceSec_A9545 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩룫雭볯鯱駳鿵賷鿹飻껽懿瘁洃挅昇椉椋崍甏焑䬓圕℗⼙⠛⬝", a_), global::CommonResources.AcgResources.ID_TXLIMITEDPATIENCESEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.trkWideCAIDataTxLimitedPatienceSec_A9545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataTxLimitedPatienceSec_A9545.DataTransferOrder = 12;
			this.trkWideCAIDataTxLimitedPatienceSec_A9545.ShowHexValue = false;
			this.trkWideCAIDataMaxTxAttempts_A8475 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩ꇫ迭裯꛱賳럵賷軹駻鏽烿瘁眃夅䤇㈉㠋㤍┏", a_), global::CommonResources.AcgResources.ID_CAIDATAMAXTXATTEMPTS, 2, 10, null, null, 0, 1);
			this.trkWideCAIDataMaxTxAttempts_A8475.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataMaxTxAttempts_A8475.DataTransferOrder = 9;
			this.trkWideCAIDataMaxTxAttempts_A8475.ShowHexValue = false;
			this.trkWideCAIDataMinResponseTimerms_A8515 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩ꇫ蟭黯ꃱ釳藵裷闹鋻跽旿嘁洃欅洇砉愋納伏匑Ⱃ⌕⤗⼙", a_), global::CommonResources.AcgResources.ID_CAIDATAMINRESPONSETIMERMS, 1, 40, null, null, 0, 50);
			this.trkWideCAIDataMinResponseTimerms_A8515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataMinResponseTimerms_A8515.DataTransferOrder = 10;
			this.trkWideCAIDataMinResponseTimerms_A8515.ShowHexValue = false;
			this.trkWideCAIDataResponseTimerms_A8949 = new global::AcpBusinessLayer.AcpSimpleRangeField(33, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩뻫语華英鯳飵请鿹ꣻ韽淿朁瘃欅笇唉䴋㘍⤏☑ⴓ", a_), global::CommonResources.AcgResources.ID_CAIDATARESPONSETIMERMS, 1, 50, null, null, 0, 100);
			this.trkWideCAIDataResponseTimerms_A8949.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataResponseTimerms_A8949.DataTransferOrder = 11;
			this.trkWideCAIDataResponseTimerms_A8949.ShowHexValue = false;
			this.trkWideCAIDataTxLongRandomRangeMs_A9547 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩룫雭볯鷱髳釵꫷鯹鋻髽濿漁嘃朅昇洉椋䌍挏䴑唓⼕ⴗ⸙⬛", a_), global::CommonResources.AcgResources.ID_TXLONGRANDOMRANGEMS, 1, 100, null, null, 0, 50);
			this.trkWideCAIDataTxLongRandomRangeMs_A9547.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataTxLongRandomRangeMs_A9547.DataTransferOrder = 6;
			this.trkWideCAIDataTxLongRandomRangeMs_A9547.ShowHexValue = false;
			this.trkWideCAIDataTxRespRandomRangems_A9564 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩룫雭ꋯ韱蟳蛵꫷鯹鋻髽濿漁嘃朅昇洉椋挍挏䴑唓⼕ⴗⰙ⠛", a_), global::CommonResources.AcgResources.ID_TXRESPRANDOMRANGEMS, 1, 20, null, null, 0, 50);
			this.trkWideCAIDataTxRespRandomRangems_A9564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataTxRespRandomRangems_A9564.DataTransferOrder = 7;
			this.trkWideCAIDataTxRespRandomRangems_A9564.ShowHexValue = false;
			this.trkWideCAIDataTxShortRandomRangems_A9566 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓臕뇗뻙맛鷝ꇟꯡꃣ蟥鳧诩룫雭ꏯ髱鯳蓵賷꣹鷻都擿洁椃吅椇搉欋欍紏愑䬓圕℗⼙⨛⠝", a_), global::CommonResources.AcgResources.ID_TXSHORTRANDOMRANGEMS, 1, 10, null, null, 0, 50);
			this.trkWideCAIDataTxShortRandomRangems_A9566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideCAIDataTxShortRandomRangems_A9566.DataTransferOrder = 8;
			this.trkWideCAIDataTxShortRandomRangems_A9566.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏏鏑鷓鳗믙꣛뿝", a_);
			base.Id = 10064;
			base.UIName = global::CommonResources.AcgResources.ID_CAIDATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000556B4 File Offset: 0x000538B4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)385351697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥뫧迩鿫黭鿯鳱蟳鏵곷鏹釻鯽狿漁眃夅䤇㈉㔋㨍⤏", a_)))
					{
						num = (short)1332936711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C4;
				case 1:
					if (producerFields != null)
					{
						num = (short)460587010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_734;
				case 2:
					num = (short)1974403083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩뻫语華英꛳韵雷黹鏻鏽勿持樃愅洇有缋儍儏⬑ℓ―Ⱇ", a_)))
					{
						num = (short)635437070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E8;
				case 4:
					this.trkWideCAIDataMaxTxAttempts_A8475 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥ꗧ诩铫뫭裯돱胳苵鷷韹賻諽珿崁䔃㸅㰇㴉㤋", a_), global::CommonResources.AcgResources.ID_CAIDATAMAXTXATTEMPTS, null, null, 0, 1);
					this.trkWideCAIDataMaxTxAttempts_A8475.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataMaxTxAttempts_A8475.DataTransferOrder = 9;
					this.trkWideCAIDataMaxTxAttempts_A8475.ShowHexValue = false;
					num = (short)1663827994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1805647873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.trkWideCAIDataTxShortRandomRangems_A9566 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩뿫蛭鿯胱胳ꓵ駷铹飻釽淿倁攃栅漇漉愋納伏匑ⴓ⌕⸗Ⱉ", a_), global::CommonResources.AcgResources.ID_TXSHORTRANDOMRANGEMS, null, null, 0, 50);
					this.trkWideCAIDataTxShortRandomRangems_A9566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataTxShortRandomRangems_A9566.DataTransferOrder = 8;
					this.trkWideCAIDataTxShortRandomRangems_A9566.ShowHexValue = false;
					num = (short)1355153429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.trkWideCAIDataResponseTimerms_A8949 = new global::AcpBusinessLayer.AcpSimpleRangeField(33, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥뫧迩鿫黭鿯鳱蟳鏵곷鏹釻鯽狿漁眃夅䤇㈉㔋㨍⤏", a_), global::CommonResources.AcgResources.ID_CAIDATARESPONSETIMERMS, null, null, 0, 100);
					this.trkWideCAIDataResponseTimerms_A8949.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataResponseTimerms_A8949.DataTransferOrder = 11;
					this.trkWideCAIDataResponseTimerms_A8949.ShowHexValue = false;
					num = (short)182386708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1247922557;
					short num3 = num;
					num = (short)814729597;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					default:
						num = (short)1633878016;
						if (num != 0)
						{
						}
						goto IL_4EB;
					}
					break;
				}
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩ꃫ蟭鷯鯱胳鏵鳷꫹鷻諽槿朁樃攅洇変椋洍伏匑ⴓ⌕Ⱇ⼙", a_)))
					{
						num = (short)2078212121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4EB;
				case 10:
					this.trkWideCAIDataMinResponseTimerms_A8515 = new global::AcpBusinessLayer.AcpSimpleRangeField(14, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥ꗧ菩苫볭闯臱蓳駵雷觹駻꫽槿漁愃琅攇礉匋伍⠏✑┓⌕", a_), global::CommonResources.AcgResources.ID_CAIDATAMINRESPONSETIMERMS, null, null, 0, 50);
					this.trkWideCAIDataMinResponseTimerms_A8515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataMinResponseTimerms_A8515.DataTransferOrder = 10;
					this.trkWideCAIDataMinResponseTimerms_A8515.ShowHexValue = false;
					num = (short)927596567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥껧飩跫菭闯ꇱ跳飵鯷꧹駻鯽毿刁愃琅愇攉栋挍挏䴑唓⸕⤗⸙⨛", a_)))
					{
						num = (short)64094220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
				case 12:
				{
					num = (short)2015100928;
					short num4 = num;
					this.trkWideCAIDataFrameSyncSeekPeriodms_A8146 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥껧飩跫菭闯ꇱ跳飵鯷꧹駻鯽毿刁愃琅愇攉栋挍挏䴑唓⸕⤗⸙⨛", a_), global::CommonResources.AcgResources.ID_FRAMESYNCSEEKPERIODMS, null, null, 0, 50);
					this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.DataTransferOrder = 5;
					this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.ShowHexValue = false;
					num = (short)541196306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_2E8;
				case 14:
					this.trkWideCAIDataTxRespRandomRangems_A9564 = new global::AcpBusinessLayer.AcpSimpleRangeField(20, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩뻫语華英꛳韵雷黹鏻鏽勿持樃愅洇有缋儍儏⬑ℓ―Ⱇ", a_), global::CommonResources.AcgResources.ID_TXRESPRANDOMRANGEMS, null, null, 0, 50);
					this.trkWideCAIDataTxRespRandomRangems_A9564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataTxRespRandomRangems_A9564.DataTransferOrder = 7;
					this.trkWideCAIDataTxRespRandomRangems_A9564.ShowHexValue = false;
					num = (short)1108410381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.trkWideCAIDataTxLongRandomRangeMs_A9547 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩ꃫ臭黯闱꛳韵雷黹鏻鏽勿持樃愅洇䜉缋儍儏⬑ℓ∕⼗", a_), global::CommonResources.AcgResources.ID_TXLONGRANDOMRANGEMS, null, null, 0, 50);
					this.trkWideCAIDataTxLongRandomRangeMs_A9547.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataTxLongRandomRangeMs_A9547.DataTransferOrder = 6;
					this.trkWideCAIDataTxLongRandomRangeMs_A9547.ShowHexValue = false;
					num = (short)130875408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_437;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 18:
					goto IL_15A;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩뿫蛭鿯胱胳ꓵ駷铹飻釽淿倁攃栅漇漉愋納伏匑ⴓ⌕⸗Ⱉ", a_)))
					{
						num = (short)1609760774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_734;
				case 20:
					goto IL_C4;
				case 21:
					goto IL_4E6;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩ꃫ臭黯闱꛳韵雷黹鏻鏽勿持樃愅洇䜉缋儍儏⬑ℓ∕⼗", a_)))
					{
						num = (short)2016542735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_437;
				case 23:
					goto IL_111;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥ꗧ菩苫볭闯臱蓳駵雷觹駻꫽槿漁愃琅攇礉匋伍⠏✑┓⌕", a_)))
					{
						num = (short)687800330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_111;
				case 25:
					this.trkWideCAIDataTxLimitedPatienceSec_A9545 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥볧鋩ꃫ蟭鷯鯱胳鏵鳷꫹鷻諽槿朁樃攅洇変椋洍伏匑ⴓ⌕Ⱇ⼙", a_), global::CommonResources.AcgResources.ID_TXLIMITEDPATIENCESEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.trkWideCAIDataTxLimitedPatienceSec_A9545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideCAIDataTxLimitedPatienceSec_A9545.DataTransferOrder = 12;
					this.trkWideCAIDataTxLimitedPatienceSec_A9545.ShowHexValue = false;
					num = (short)430571528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_335;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏藑뷓닕뷗駙鷛韝ꓟ菡郣蟥ꗧ诩铫뫭裯돱胳苵鷷韹賻諽珿崁䔃㸅㰇㴉㤋", a_)))
					{
						num = (short)1204224004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_335;
				}
				goto IL_9D;
				IL_A7:
				num = (short)1277952005;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_A7;
				}
				break;
				IL_C4:
				num = (short)579403798;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				num = (short)2016018432;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15A:
				num = (short)775553033;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E8:
				num = (short)265355283;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_335:
				num = (short)1164967960;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_437:
				num = (short)1610547203;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4EB:
				num = (short)1220149249;
				if (num != 0)
				{
				}
				num = (short)3801115;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4E6:
			IL_734:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迋迍駏郓럕곗믙", a_);
			base.Id = 10064;
			base.UIName = global::CommonResources.AcgResources.ID_CAIDATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00055E28 File Offset: 0x00054028
		public override void PopulateReferences()
		{
			short num = (short)1664210416;
			short num2 = num;
			num = (short)2096944624;
			switch (num2 == num)
			{
			}
			num = (short)1371406336;
			short num3 = num;
			num = (short)773586945;
			if (num != 0)
			{
			}
			num = (short)1863647232;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00055ED0 File Offset: 0x000540D0
		public override void DropReferences()
		{
			short num = (short)2122263731;
			short num2 = num;
			num = (short)848112819;
			switch (num2 == num)
			{
			}
			num = (short)1337720832;
			short num3 = num;
			num = (short)1837498369;
			if (num != 0)
			{
			}
			num = (short)1435893760;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00055F78 File Offset: 0x00054178
		public override void SetConstraints()
		{
			short num = (short)1591083009;
			if (num != 0)
			{
			}
			num = (short)217274159;
			short num2 = num;
			num = (short)59922223;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1146486784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)897646592;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00056024 File Offset: 0x00054224
		public override void SetupDependencies()
		{
			short num = (short)1807482881;
			if (num != 0)
			{
			}
			num = (short)165476352;
			short num2 = num;
			num = (short)854325248;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1399455744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)870645760;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000560D0 File Offset: 0x000542D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1348148445;
				short num2 = num;
				num = (short)744037597;
				switch (num2 == num)
				{
				}
				num = (short)1204617216;
				short num3 = num;
				num = (short)112001025;
				if (num != 0)
				{
				}
				num = (short)1031471104;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00056184 File Offset: 0x00054384
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0005623C File Offset: 0x0005443C
		public int TrkWideCAIDataFrameSyncSeekPeriodms_A8146Value
		{
			get
			{
				short num = (short)25296897;
				if (num != 0)
				{
				}
				num = (short)1093920929;
				short num2 = num;
				num = (short)1235478689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100728832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2106523648;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Value;
			}
			set
			{
				short num = (short)430715919;
				short num2 = num;
				num = (short)511652879;
				switch (num2 == num)
				{
				}
				num = (short)950730752;
				short num3 = num;
				num = (short)1378091009;
				if (num != 0)
				{
				}
				num = (short)881328128;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Value = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000562F0 File Offset: 0x000544F0
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataFrameSyncSeekPeriodms_A8146
		{
			get
			{
				short num = (short)567887600;
				short num2 = num;
				num = (short)1193494256;
				switch (num2 == num)
				{
				}
				num = (short)1625817088;
				short num3 = num;
				num = (short)1798569984;
				if (num != 0)
				{
				}
				num = (short)478347265;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000563A0 File Offset: 0x000545A0
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00056454 File Offset: 0x00054654
		public string TrkWideCAIDataFrameSyncSeekPeriodms_A8146_UIValue
		{
			get
			{
				short num = (short)558104237;
				short num2 = num;
				num = (short)612695725;
				switch (num2 == num)
				{
				}
				num = (short)1691287552;
				short num3 = num;
				num = (short)562823169;
				if (num != 0)
				{
				}
				num = (short)45023232;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.UIValue;
			}
			set
			{
				short num = (short)989708402;
				short num2 = num;
				num = (short)216580210;
				switch (num2 == num)
				{
				}
				num = (short)1721827328;
				short num3 = num;
				num = (short)670105601;
				if (num != 0)
				{
				}
				num = (short)650641408;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.UIValue = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00056508 File Offset: 0x00054708
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000565BC File Offset: 0x000547BC
		internal int TrkWideCAIDataFrameSyncSeekPeriodms_A8146Min
		{
			get
			{
				short num = (short)689619413;
				short num2 = num;
				num = (short)1997783509;
				switch (num2 == num)
				{
				}
				num = (short)297009152;
				short num3 = num;
				num = (short)2022834176;
				if (num != 0)
				{
				}
				num = (short)1798963201;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Min;
			}
			set
			{
				short num = (short)1938360899;
				short num2 = num;
				num = (short)616565315;
				switch (num2 == num)
				{
				}
				num = (short)300613632;
				short num3 = num;
				num = (short)1765343232;
				if (num != 0)
				{
				}
				num = (short)1525743617;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Min = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00056674 File Offset: 0x00054874
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00056728 File Offset: 0x00054928
		internal int TrkWideCAIDataFrameSyncSeekPeriodms_A8146Max
		{
			get
			{
				short num = (short)598237129;
				short num2 = num;
				num = (short)945119177;
				switch (num2 == num)
				{
				}
				num = (short)1853095936;
				short num3 = num;
				num = (short)2014707713;
				if (num != 0)
				{
				}
				num = (short)450822144;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Max;
			}
			set
			{
				short num = (short)1415869673;
				short num2 = num;
				num = (short)1526691049;
				switch (num2 == num)
				{
				}
				num = (short)2086928384;
				short num3 = num;
				num = (short)353107969;
				if (num != 0)
				{
				}
				num = (short)1900609536;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Max = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000567DC File Offset: 0x000549DC
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00056890 File Offset: 0x00054A90
		internal int TrkWideCAIDataFrameSyncSeekPeriodms_A8146Step
		{
			get
			{
				short num = (short)560294102;
				short num2 = num;
				num = (short)1753180374;
				switch (num2 == num)
				{
				}
				num = (short)235012096;
				short num3 = num;
				num = (short)1557856257;
				if (num != 0)
				{
				}
				num = (short)442826752;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.StepSize;
			}
			set
			{
				short num = (short)953350662;
				short num2 = num;
				num = (short)1152580102;
				switch (num2 == num)
				{
				}
				num = (short)225574912;
				short num3 = num;
				num = (short)836632576;
				if (num != 0)
				{
				}
				num = (short)1949761537;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.StepSize = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00056944 File Offset: 0x00054B44
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x000569F8 File Offset: 0x00054BF8
		public bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_Applicable
		{
			get
			{
				short num = (short)1144891323;
				short num2 = num;
				num = (short)1443342267;
				switch (num2 == num)
				{
				}
				num = (short)1133969408;
				short num3 = num;
				num = (short)1206714369;
				if (num != 0)
				{
				}
				num = (short)744554496;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Applicable;
			}
			set
			{
				short num = (short)2004262256;
				short num2 = num;
				num = (short)139304304;
				switch (num2 == num)
				{
				}
				num = (short)1344667648;
				short num3 = num;
				num = (short)353566721;
				if (num != 0)
				{
				}
				num = (short)1787297792;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Applicable = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00056AAC File Offset: 0x00054CAC
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00056B5C File Offset: 0x00054D5C
		public bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_Valid
		{
			get
			{
				short num = (short)1395551236;
				short num2 = num;
				num = (short)1301834756;
				switch (num2 == num)
				{
				}
				num = (short)1283653632;
				short num3 = num;
				num = (short)85000192;
				if (num != 0)
				{
				}
				num = (short)1461911553;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Valid;
			}
			set
			{
				short num = (short)1517581308;
				short num2 = num;
				num = (short)1281192956;
				switch (num2 == num)
				{
				}
				num = (short)2129068032;
				short num3 = num;
				num = (short)1665204224;
				if (num != 0)
				{
				}
				num = (short)1637351425;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Valid = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00056C14 File Offset: 0x00054E14
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00056CCC File Offset: 0x00054ECC
		public bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_Visible
		{
			get
			{
				short num = (short)77327702;
				short num2 = num;
				num = (short)810151254;
				switch (num2 == num)
				{
				}
				num = (short)245694464;
				short num3 = num;
				num = (short)291307520;
				if (num != 0)
				{
				}
				num = (short)672202753;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Visible;
			}
			set
			{
				short num = (short)1499116184;
				short num2 = num;
				num = (short)1658172056;
				switch (num2 == num)
				{
				}
				num = (short)1725759488;
				short num3 = num;
				num = (short)235143168;
				if (num != 0)
				{
				}
				num = (short)19202049;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Visible = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00056D80 File Offset: 0x00054F80
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00056E34 File Offset: 0x00055034
		public bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_Editable
		{
			get
			{
				short num = (short)802816001;
				if (num != 0)
				{
				}
				num = (short)1205429953;
				short num2 = num;
				num = (short)1504143041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620180992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610336768;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Editable;
			}
			set
			{
				short num = (short)1372717057;
				if (num != 0)
				{
				}
				num = (short)699876338;
				short num2 = num;
				num = (short)1922515954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)238878720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)66912256;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.Editable = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00056EEC File Offset: 0x000550EC
		internal string TrkWideCAIDataFrameSyncSeekPeriodms_A8146_UILabel
		{
			get
			{
				short num = (short)1334509569;
				if (num != 0)
				{
				}
				num = (short)1362978281;
				short num2 = num;
				num = (short)516646377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1127612416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)43712512;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.UIName;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00056FA4 File Offset: 0x000551A4
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00057058 File Offset: 0x00055258
		internal bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_HiddenStatic
		{
			get
			{
				short num = (short)1431945939;
				short num2 = num;
				num = (short)1674166995;
				switch (num2 == num)
				{
				}
				num = (short)2019819520;
				short num3 = num;
				num = (short)954073089;
				if (num != 0)
				{
				}
				num = (short)1828454400;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.HiddenStatic;
			}
			set
			{
				short num = (short)1800994764;
				short num2 = num;
				num = (short)583794636;
				switch (num2 == num)
				{
				}
				num = (short)850526208;
				short num3 = num;
				num = (short)1924071425;
				if (num != 0)
				{
				}
				num = (short)1729953792;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.HiddenStatic = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0005710C File Offset: 0x0005530C
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x000571C0 File Offset: 0x000553C0
		internal bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_HiddenDynamic
		{
			get
			{
				short num = (short)746925231;
				short num2 = num;
				num = (short)1648569519;
				switch (num2 == num)
				{
				}
				num = (short)310050816;
				short num3 = num;
				num = (short)1471348737;
				if (num != 0)
				{
				}
				num = (short)1368064000;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.HiddenDynamic;
			}
			set
			{
				short num = (short)1565324742;
				short num2 = num;
				num = (short)748156358;
				switch (num2 == num)
				{
				}
				num = (short)1260060672;
				short num3 = num;
				num = (short)583139329;
				if (num != 0)
				{
				}
				num = (short)2091188224;
				if (num != 0)
				{
				}
				this.trkWideCAIDataFrameSyncSeekPeriodms_A8146.HiddenDynamic = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00057278 File Offset: 0x00055478
		public bool TrkWideCAIDataFrameSyncSeekPeriodms_A8146_HasDiffs
		{
			get
			{
				short num = (short)1820439921;
				short num2 = num;
				num = (short)898807153;
				switch (num2 == num)
				{
				}
				num = (short)475070464;
				short num3 = num;
				num = (short)550174721;
				if (num != 0)
				{
				}
				num = (short)466616320;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataFrameSyncSeekPeriodms_A8146._HasDiffs;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0005732C File Offset: 0x0005552C
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x000573E0 File Offset: 0x000555E0
		public int TrkWideCAIDataTxLimitedPatienceSec_A9545Value
		{
			get
			{
				short num = (short)1676584625;
				short num2 = num;
				num = (short)1856874161;
				switch (num2 == num)
				{
				}
				num = (short)2008219648;
				short num3 = num;
				num = (short)1915682817;
				if (num != 0)
				{
				}
				num = (short)214237184;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Value;
			}
			set
			{
				short num = (short)1814713907;
				short num2 = num;
				num = (short)536696371;
				switch (num2 == num)
				{
				}
				num = (short)134676480;
				short num3 = num;
				num = (short)1768816641;
				if (num != 0)
				{
				}
				num = (short)1780940800;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Value = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00057494 File Offset: 0x00055694
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataTxLimitedPatienceSec_A9545
		{
			get
			{
				short num = (short)2065568348;
				short num2 = num;
				num = (short)927601244;
				switch (num2 == num)
				{
				}
				num = (short)1124073472;
				short num3 = num;
				num = (short)786104321;
				if (num != 0)
				{
				}
				num = (short)661258240;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00057544 File Offset: 0x00055744
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x000575F8 File Offset: 0x000557F8
		public string TrkWideCAIDataTxLimitedPatienceSec_A9545_UIValue
		{
			get
			{
				short num = (short)799679482;
				short num2 = num;
				num = (short)913581050;
				switch (num2 == num)
				{
				}
				num = (short)1889861632;
				short num3 = num;
				num = (short)934543361;
				if (num != 0)
				{
				}
				num = (short)1394671616;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.UIValue;
			}
			set
			{
				short num = (short)597905283;
				short num2 = num;
				num = (short)970739587;
				switch (num2 == num)
				{
				}
				num = (short)900071424;
				short num3 = num;
				num = (short)1929445377;
				if (num != 0)
				{
				}
				num = (short)195166208;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.UIValue = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000576AC File Offset: 0x000558AC
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00057760 File Offset: 0x00055960
		internal int TrkWideCAIDataTxLimitedPatienceSec_A9545Min
		{
			get
			{
				short num = (short)142737409;
				if (num != 0)
				{
				}
				num = (short)897473364;
				short num2 = num;
				num = (short)1573870420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1776156672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)818413568;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Min;
			}
			set
			{
				short num = (short)758802008;
				short num2 = num;
				num = (short)1831691864;
				switch (num2 == num)
				{
				}
				num = (short)372047872;
				short num3 = num;
				num = (short)1815216129;
				if (num != 0)
				{
				}
				num = (short)447217664;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Min = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00057814 File Offset: 0x00055A14
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x000578C8 File Offset: 0x00055AC8
		internal int TrkWideCAIDataTxLimitedPatienceSec_A9545Max
		{
			get
			{
				short num = (short)1808304731;
				short num2 = num;
				num = (short)751209051;
				switch (num2 == num)
				{
				}
				num = (short)1941110784;
				short num3 = num;
				num = (short)2020278273;
				if (num != 0)
				{
				}
				num = (short)1048576;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Max;
			}
			set
			{
				short num = (short)1172731622;
				short num2 = num;
				num = (short)1936946918;
				switch (num2 == num)
				{
				}
				num = (short)171114496;
				short num3 = num;
				num = (short)795213825;
				if (num != 0)
				{
				}
				num = (short)879034368;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Max = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00057980 File Offset: 0x00055B80
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00057A38 File Offset: 0x00055C38
		internal int TrkWideCAIDataTxLimitedPatienceSec_A9545Step
		{
			get
			{
				short num = (short)1332199806;
				short num2 = num;
				num = (short)2033697150;
				switch (num2 == num)
				{
				}
				num = (short)1824129024;
				short num3 = num;
				num = (short)995426304;
				if (num != 0)
				{
				}
				num = (short)1403518977;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.StepSize;
			}
			set
			{
				short num = (short)315123129;
				short num2 = num;
				num = (short)1236166073;
				switch (num2 == num)
				{
				}
				num = (short)1883504640;
				short num3 = num;
				num = (short)377683968;
				if (num != 0)
				{
				}
				num = (short)1432748033;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.StepSize = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00057AEC File Offset: 0x00055CEC
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00057BA4 File Offset: 0x00055DA4
		public bool TrkWideCAIDataTxLimitedPatienceSec_A9545_Applicable
		{
			get
			{
				short num = (short)502792193;
				if (num != 0)
				{
				}
				num = (short)1221387537;
				short num2 = num;
				num = (short)2122573073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212336640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)724631552;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Applicable;
			}
			set
			{
				short num = (short)1260990473;
				short num2 = num;
				num = (short)1257254921;
				switch (num2 == num)
				{
				}
				num = (short)1213464576;
				short num3 = num;
				num = (short)606732289;
				if (num != 0)
				{
				}
				num = (short)552402944;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Applicable = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00057C58 File Offset: 0x00055E58
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00057D0C File Offset: 0x00055F0C
		public bool TrkWideCAIDataTxLimitedPatienceSec_A9545_Valid
		{
			get
			{
				short num = (short)1436030225;
				short num2 = num;
				num = (short)31331601;
				switch (num2 == num)
				{
				}
				num = (short)601096192;
				short num3 = num;
				num = (short)1809055744;
				if (num != 0)
				{
				}
				num = (short)962134017;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Valid;
			}
			set
			{
				short num = (short)1937965057;
				if (num != 0)
				{
				}
				num = (short)814525912;
				short num2 = num;
				num = (short)343387608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1145438208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1291190272;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Valid = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00057DC0 File Offset: 0x00055FC0
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00057E78 File Offset: 0x00056078
		public bool TrkWideCAIDataTxLimitedPatienceSec_A9545_Visible
		{
			get
			{
				short num = (short)899743744;
				short num2 = num;
				num = (short)257342638;
				short num3 = num;
				num = (short)1019395246;
				switch (num3 == num)
				{
				}
				num = (short)1007616001;
				if (num != 0)
				{
				}
				num = (short)217055232;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Visible;
			}
			set
			{
				short num = (short)95617024;
				short num2 = num;
				num = (short)809254126;
				short num3 = num;
				num = (short)906181870;
				switch (num3 == num)
				{
				}
				num = (short)354549761;
				if (num != 0)
				{
				}
				num = (short)1593769984;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Visible = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00057F2C File Offset: 0x0005612C
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00057FE0 File Offset: 0x000561E0
		public bool TrkWideCAIDataTxLimitedPatienceSec_A9545_Editable
		{
			get
			{
				short num = (short)2023555072;
				short num2 = num;
				num = (short)1992556545;
				if (num != 0)
				{
				}
				num = (short)1154871049;
				short num3 = num;
				num = (short)1764617993;
				switch (num3 == num)
				{
				}
				num = (short)205979648;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.Editable;
			}
			set
			{
				short num = (short)577896448;
				short num2 = num;
				num = (short)246695739;
				short num3 = num;
				num = (short)574572347;
				switch (num3 == num)
				{
				}
				num = (short)1341784065;
				if (num != 0)
				{
				}
				num = (short)2144796672;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.Editable = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00058094 File Offset: 0x00056294
		internal string TrkWideCAIDataTxLimitedPatienceSec_A9545_UILabel
		{
			get
			{
				short num = (short)847249408;
				short num2 = num;
				num = (short)1676279809;
				if (num != 0)
				{
				}
				num = (short)1157560615;
				short num3 = num;
				num = (short)894630183;
				switch (num3 == num)
				{
				}
				num = (short)1677393920;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.UIName;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0005814C File Offset: 0x0005634C
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00058200 File Offset: 0x00056400
		internal bool TrkWideCAIDataTxLimitedPatienceSec_A9545_HiddenStatic
		{
			get
			{
				short num = (short)694616064;
				short num2 = num;
				num = (short)519733011;
				short num3 = num;
				num = (short)1450606355;
				switch (num3 == num)
				{
				}
				num = (short)622854145;
				if (num != 0)
				{
				}
				num = (short)1715929088;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.HiddenStatic;
			}
			set
			{
				short num = (short)15335424;
				short num2 = num;
				num = (short)1335527737;
				short num3 = num;
				num = (short)1865451833;
				switch (num3 == num)
				{
				}
				num = (short)1460535297;
				if (num != 0)
				{
				}
				num = (short)285999104;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.HiddenStatic = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000582B4 File Offset: 0x000564B4
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00058368 File Offset: 0x00056568
		internal bool TrkWideCAIDataTxLimitedPatienceSec_A9545_HiddenDynamic
		{
			get
			{
				short num = (short)1261633536;
				short num2 = num;
				num = (short)342614388;
				short num3 = num;
				num = (short)1248321908;
				switch (num3 == num)
				{
				}
				num = (short)1618608129;
				if (num != 0)
				{
				}
				num = (short)1023606784;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545.HiddenDynamic;
			}
			set
			{
				short num = (short)1387724800;
				short num2 = num;
				num = (short)820973315;
				short num3 = num;
				num = (short)1446383363;
				switch (num3 == num)
				{
				}
				num = (short)1724645377;
				if (num != 0)
				{
				}
				num = (short)904134656;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLimitedPatienceSec_A9545.HiddenDynamic = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00058420 File Offset: 0x00056620
		public bool TrkWideCAIDataTxLimitedPatienceSec_A9545_HasDiffs
		{
			get
			{
				short num = (short)749142016;
				short num2 = num;
				num = (short)1507056678;
				short num3 = num;
				num = (short)169532454;
				switch (num3 == num)
				{
				}
				num = (short)1572601856;
				if (num != 0)
				{
				}
				num = (short)1309868033;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLimitedPatienceSec_A9545._HasDiffs;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000584D4 File Offset: 0x000566D4
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00058588 File Offset: 0x00056788
		public int TrkWideCAIDataMaxTxAttempts_A8475Value
		{
			get
			{
				short num = (short)80936960;
				short num2 = num;
				num = (short)1744184151;
				short num3 = num;
				num = (short)1390158679;
				switch (num3 == num)
				{
				}
				num = (short)238026752;
				if (num != 0)
				{
				}
				num = (short)1564344321;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Value;
			}
			set
			{
				short num = (short)109641728;
				short num2 = num;
				num = (short)1963050481;
				short num3 = num;
				num = (short)834323953;
				switch (num3 == num)
				{
				}
				num = (short)1797652481;
				if (num != 0)
				{
				}
				num = (short)1636958208;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Value = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00058640 File Offset: 0x00056840
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataMaxTxAttempts_A8475
		{
			get
			{
				short num = (short)1458896896;
				short num2 = num;
				num = (short)204996609;
				if (num != 0)
				{
				}
				num = (short)1841632061;
				short num3 = num;
				num = (short)1877611325;
				switch (num3 == num)
				{
				}
				num = (short)857276416;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000586F0 File Offset: 0x000568F0
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x000587A8 File Offset: 0x000569A8
		public string TrkWideCAIDataMaxTxAttempts_A8475_UIValue
		{
			get
			{
				short num = (short)1229914112;
				short num2 = num;
				num = (short)2133561878;
				short num3 = num;
				num = (short)2131268118;
				switch (num3 == num)
				{
				}
				num = (short)1864040448;
				if (num != 0)
				{
				}
				num = (short)1528496129;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.UIValue;
			}
			set
			{
				short num = (short)261750784;
				short num2 = num;
				num = (short)174217738;
				short num3 = num;
				num = (short)2050906634;
				switch (num3 == num)
				{
				}
				num = (short)315424769;
				if (num != 0)
				{
				}
				num = (short)1839267840;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.UIValue = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0005885C File Offset: 0x00056A5C
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00058914 File Offset: 0x00056B14
		internal int TrkWideCAIDataMaxTxAttempts_A8475Min
		{
			get
			{
				short num = (short)1297612800;
				short num2 = num;
				num = (short)13822165;
				short num3 = num;
				num = (short)424208597;
				switch (num3 == num)
				{
				}
				num = (short)2136539137;
				if (num != 0)
				{
				}
				num = (short)1706033152;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Min;
			}
			set
			{
				short num = (short)891092992;
				short num2 = num;
				num = (short)1244266497;
				if (num != 0)
				{
				}
				num = (short)608241503;
				short num3 = num;
				num = (short)362350431;
				switch (num3 == num)
				{
				}
				num = (short)1196687360;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Min = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000589CC File Offset: 0x00056BCC
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00058A80 File Offset: 0x00056C80
		internal int TrkWideCAIDataMaxTxAttempts_A8475Max
		{
			get
			{
				short num = (short)1389821952;
				short num2 = num;
				num = (short)1468551466;
				short num3 = num;
				num = (short)1314804010;
				switch (num3 == num)
				{
				}
				num = (short)445448193;
				if (num != 0)
				{
				}
				num = (short)560005120;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Max;
			}
			set
			{
				short num = (short)1414070272;
				short num2 = num;
				num = (short)546195771;
				short num3 = num;
				num = (short)1016744251;
				switch (num3 == num)
				{
				}
				num = (short)548143104;
				if (num != 0)
				{
				}
				num = (short)1483145217;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Max = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00058B34 File Offset: 0x00056D34
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00058BEC File Offset: 0x00056DEC
		internal int TrkWideCAIDataMaxTxAttempts_A8475Step
		{
			get
			{
				short num = (short)1818230784;
				short num2 = num;
				num = (short)1964906945;
				short num3 = num;
				num = (short)1486166465;
				switch (num3 == num)
				{
				}
				num = (short)1503068160;
				if (num != 0)
				{
				}
				num = (short)1155399681;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.StepSize;
			}
			set
			{
				short num = (short)1464008704;
				short num2 = num;
				num = (short)736652194;
				short num3 = num;
				num = (short)480865186;
				switch (num3 == num)
				{
				}
				num = (short)872415233;
				if (num != 0)
				{
				}
				num = (short)1298726912;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.StepSize = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00058CA4 File Offset: 0x00056EA4
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00058D58 File Offset: 0x00056F58
		public bool TrkWideCAIDataMaxTxAttempts_A8475_Applicable
		{
			get
			{
				short num = (short)540344320;
				short num2 = num;
				num = (short)781907943;
				short num3 = num;
				num = (short)1590622183;
				switch (num3 == num)
				{
				}
				num = (short)620822529;
				if (num != 0)
				{
				}
				num = (short)1662976000;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Applicable;
			}
			set
			{
				short num = (short)589824000;
				short num2 = num;
				num = (short)1307130830;
				short num3 = num;
				num = (short)58735566;
				switch (num3 == num)
				{
				}
				num = (short)875626497;
				if (num != 0)
				{
				}
				num = (short)394657792;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Applicable = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00058E0C File Offset: 0x0005700C
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00058EC8 File Offset: 0x000570C8
		public bool TrkWideCAIDataMaxTxAttempts_A8475_Valid
		{
			get
			{
				short num = (short)1761869824;
				short num2 = num;
				num = (short)2029659493;
				short num3 = num;
				num = (short)913057125;
				switch (num3 == num)
				{
				}
				num = (short)1661992960;
				if (num != 0)
				{
				}
				num = (short)830734337;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Valid;
			}
			set
			{
				short num = (short)1765408768;
				short num2 = num;
				num = (short)67177858;
				short num3 = num;
				num = (short)477498754;
				switch (num3 == num)
				{
				}
				num = (short)732233729;
				if (num != 0)
				{
				}
				num = (short)1666973696;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Valid = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00058F7C File Offset: 0x0005717C
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00059030 File Offset: 0x00057230
		public bool TrkWideCAIDataMaxTxAttempts_A8475_Visible
		{
			get
			{
				short num = (short)1840775168;
				short num2 = num;
				num = (short)649106350;
				short num3 = num;
				num = (short)79467438;
				switch (num3 == num)
				{
				}
				num = (short)1381040129;
				if (num != 0)
				{
				}
				num = (short)976551936;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Visible;
			}
			set
			{
				short num = (short)2014314496;
				short num2 = num;
				num = (short)750059521;
				if (num != 0)
				{
				}
				num = (short)182852960;
				short num3 = num;
				num = (short)393878880;
				switch (num3 == num)
				{
				}
				num = (short)170852352;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Visible = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x000590E8 File Offset: 0x000572E8
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x000591A0 File Offset: 0x000573A0
		public bool TrkWideCAIDataMaxTxAttempts_A8475_Editable
		{
			get
			{
				short num = (short)381485056;
				short num2 = num;
				num = (short)873997962;
				short num3 = num;
				num = (short)536553098;
				switch (num3 == num)
				{
				}
				num = (short)1464336385;
				if (num != 0)
				{
				}
				num = (short)1428094976;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.Editable;
			}
			set
			{
				short num = (short)1531641856;
				short num2 = num;
				num = (short)2017787905;
				if (num != 0)
				{
				}
				num = (short)1915660933;
				short num3 = num;
				num = (short)1797302917;
				switch (num3 == num)
				{
				}
				num = (short)70778880;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.Editable = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00059258 File Offset: 0x00057458
		internal string TrkWideCAIDataMaxTxAttempts_A8475_UILabel
		{
			get
			{
				short num = (short)715456512;
				short num2 = num;
				num = (short)753602115;
				short num3 = num;
				num = (short)79433283;
				switch (num3 == num)
				{
				}
				num = (short)2006974464;
				if (num != 0)
				{
				}
				num = (short)920780801;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.UIName;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00059310 File Offset: 0x00057510
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x000593C4 File Offset: 0x000575C4
		internal bool TrkWideCAIDataMaxTxAttempts_A8475_HiddenStatic
		{
			get
			{
				short num = (short)355598336;
				short num2 = num;
				num = (short)3409989;
				short num3 = num;
				num = (short)600180805;
				switch (num3 == num)
				{
				}
				num = (short)2086928384;
				if (num != 0)
				{
				}
				num = (short)41811969;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.HiddenStatic;
			}
			set
			{
				short num = (short)330170368;
				short num2 = num;
				num = (short)420774543;
				short num3 = num;
				num = (short)164201103;
				switch (num3 == num)
				{
				}
				num = (short)1859911681;
				if (num != 0)
				{
				}
				num = (short)1568342016;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.HiddenStatic = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0005947C File Offset: 0x0005767C
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00059534 File Offset: 0x00057734
		internal bool TrkWideCAIDataMaxTxAttempts_A8475_HiddenDynamic
		{
			get
			{
				short num = (short)1996488704;
				short num2 = num;
				num = (short)1218707457;
				if (num != 0)
				{
				}
				num = (short)748638640;
				short num3 = num;
				num = (short)15356336;
				switch (num3 == num)
				{
				}
				num = (short)699793408;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475.HiddenDynamic;
			}
			set
			{
				short num = (short)45088768;
				short num2 = num;
				num = (short)1427177473;
				if (num != 0)
				{
				}
				num = (short)1414764058;
				short num3 = num;
				num = (short)110859802;
				switch (num3 == num)
				{
				}
				num = (short)1474691072;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMaxTxAttempts_A8475.HiddenDynamic = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000595E8 File Offset: 0x000577E8
		public bool TrkWideCAIDataMaxTxAttempts_A8475_HasDiffs
		{
			get
			{
				short num = (short)1057751040;
				short num2 = num;
				num = (short)1378265402;
				short num3 = num;
				num = (short)1688840506;
				switch (num3 == num)
				{
				}
				num = (short)171769856;
				if (num != 0)
				{
				}
				num = (short)970522625;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMaxTxAttempts_A8475._HasDiffs;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0005969C File Offset: 0x0005789C
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00059750 File Offset: 0x00057950
		public int TrkWideCAIDataMinResponseTimerms_A8515Value
		{
			get
			{
				short num = (short)1350238208;
				short num2 = num;
				num = (short)1522763236;
				short num3 = num;
				num = (short)1425769956;
				switch (num3 == num)
				{
				}
				num = (short)867041280;
				if (num != 0)
				{
				}
				num = (short)2137784321;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Value;
			}
			set
			{
				short num = (short)1751449600;
				short num2 = num;
				num = (short)2042171586;
				short num3 = num;
				num = (short)420614338;
				switch (num3 == num)
				{
				}
				num = (short)1888681985;
				if (num != 0)
				{
				}
				num = (short)1738407936;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Value = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00059808 File Offset: 0x00057A08
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataMinResponseTimerms_A8515
		{
			get
			{
				short num = (short)814612480;
				short num2 = num;
				num = (short)307167233;
				if (num != 0)
				{
				}
				num = (short)1402398067;
				short num3 = num;
				num = (short)460973427;
				switch (num3 == num)
				{
				}
				num = (short)1756168192;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000598B8 File Offset: 0x00057AB8
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00059970 File Offset: 0x00057B70
		public string TrkWideCAIDataMinResponseTimerms_A8515_UIValue
		{
			get
			{
				short num = (short)2059010048;
				short num2 = num;
				num = (short)259914910;
				short num3 = num;
				num = (short)1595866270;
				switch (num3 == num)
				{
				}
				num = (short)672464897;
				if (num != 0)
				{
				}
				num = (short)871497728;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.UIValue;
			}
			set
			{
				short num = (short)215168606;
				short num2 = num;
				num = (short)274413150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985609728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931608064;
				if (num != 0)
				{
				}
				num = (short)88670209;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.UIValue = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00059A24 File Offset: 0x00057C24
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00059AD8 File Offset: 0x00057CD8
		internal int TrkWideCAIDataMinResponseTimerms_A8515Min
		{
			get
			{
				short num = (short)75570552;
				short num2 = num;
				num = (short)475995512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)316145664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1839661057;
				if (num != 0)
				{
				}
				num = (short)1449066496;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Min;
			}
			set
			{
				short num = (short)704869566;
				short num2 = num;
				num = (short)405173438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2108030976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974075392;
				if (num != 0)
				{
				}
				num = (short)2021916673;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Min = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00059B8C File Offset: 0x00057D8C
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00059C40 File Offset: 0x00057E40
		internal int TrkWideCAIDataMinResponseTimerms_A8515Max
		{
			get
			{
				short num = (short)1282343768;
				short num2 = num;
				num = (short)623706968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62717952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)643170304;
				if (num != 0)
				{
				}
				num = (short)187039745;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Max;
			}
			set
			{
				short num = (short)634931156;
				short num2 = num;
				num = (short)624445396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1080164352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)8781824;
				if (num != 0)
				{
				}
				num = (short)1815216129;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Max = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00059CF4 File Offset: 0x00057EF4
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00059DAC File Offset: 0x00057FAC
		internal int TrkWideCAIDataMinResponseTimerms_A8515Step
		{
			get
			{
				short num = (short)730016812;
				short num2 = num;
				num = (short)2020813868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097007104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931345921;
				if (num != 0)
				{
				}
				num = (short)623575040;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.StepSize;
			}
			set
			{
				short num = (short)1934398818;
				short num2 = num;
				num = (short)598054242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995571200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668939777;
				if (num != 0)
				{
				}
				num = (short)983891968;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.StepSize = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00059E60 File Offset: 0x00058060
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00059F14 File Offset: 0x00058114
		public bool TrkWideCAIDataMinResponseTimerms_A8515_Applicable
		{
			get
			{
				short num = (short)414470939;
				short num2 = num;
				num = (short)515527451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)940769280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951189505;
				if (num != 0)
				{
				}
				num = (short)1337720832;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Applicable;
			}
			set
			{
				short num = (short)313784388;
				short num2 = num;
				num = (short)85850180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591738368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027749377;
				if (num != 0)
				{
				}
				num = (short)1748238336;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Applicable = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00059FCC File Offset: 0x000581CC
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0005A084 File Offset: 0x00058284
		public bool TrkWideCAIDataMinResponseTimerms_A8515_Valid
		{
			get
			{
				short num = (short)1036393691;
				short num2 = num;
				num = (short)858070235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591607296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1517879296;
				if (num != 0)
				{
				}
				num = (short)1507393537;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Valid;
			}
			set
			{
				short num = (short)142934017;
				if (num != 0)
				{
				}
				num = (short)1992228864;
				short num2 = num;
				num = (short)323999912;
				short num3 = num;
				num = (short)2053101736;
				switch (num3 == num)
				{
				}
				num = (short)330956800;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Valid = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0005A138 File Offset: 0x00058338
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0005A1F0 File Offset: 0x000583F0
		public bool TrkWideCAIDataMinResponseTimerms_A8515_Visible
		{
			get
			{
				short num = (short)1610702425;
				short num2 = num;
				num = (short)935616089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467416576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1291517953;
				if (num != 0)
				{
				}
				num = (short)1456472064;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Visible;
			}
			set
			{
				short num = (short)519082983;
				short num2 = num;
				num = (short)1030132711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046296064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074279937;
				if (num != 0)
				{
				}
				num = (short)1985216512;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Visible = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0005A2A4 File Offset: 0x000584A4
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0005A354 File Offset: 0x00058554
		public bool TrkWideCAIDataMinResponseTimerms_A8515_Editable
		{
			get
			{
				short num = (short)1538909901;
				short num2 = num;
				num = (short)317318861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484507648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1397161984;
				if (num != 0)
				{
				}
				num = (short)2084241409;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.Editable;
			}
			set
			{
				short num = (short)1151664129;
				if (num != 0)
				{
				}
				num = (short)499908608;
				short num2 = num;
				num = (short)1416166224;
				short num3 = num;
				num = (short)372177744;
				switch (num3 == num)
				{
				}
				num = (short)1811349504;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.Editable = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0005A40C File Offset: 0x0005860C
		internal string TrkWideCAIDataMinResponseTimerms_A8515_UILabel
		{
			get
			{
				short num = (short)2103067189;
				short num2 = num;
				num = (short)2040349237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1771700224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126708737;
				if (num != 0)
				{
				}
				num = (short)983171072;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.UIName;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0005A4C0 File Offset: 0x000586C0
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0005A574 File Offset: 0x00058774
		internal bool TrkWideCAIDataMinResponseTimerms_A8515_HiddenStatic
		{
			get
			{
				short num = (short)266141697;
				if (num != 0)
				{
				}
				num = (short)1306525696;
				short num2 = num;
				num = (short)1530119367;
				short num3 = num;
				num = (short)561235143;
				switch (num3 == num)
				{
				}
				num = (short)110231552;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.HiddenStatic;
			}
			set
			{
				short num = (short)1139671327;
				short num2 = num;
				num = (short)550699295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)526516224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)607059968;
				if (num != 0)
				{
				}
				num = (short)826408961;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.HiddenStatic = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0005A62C File Offset: 0x0005882C
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0005A6E4 File Offset: 0x000588E4
		internal bool TrkWideCAIDataMinResponseTimerms_A8515_HiddenDynamic
		{
			get
			{
				short num = (short)422969345;
				if (num != 0)
				{
				}
				num = (short)186515456;
				short num2 = num;
				num = (short)1043974564;
				short num3 = num;
				num = (short)2121779620;
				switch (num3 == num)
				{
				}
				num = (short)332726272;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515.HiddenDynamic;
			}
			set
			{
				short num = (short)186137017;
				short num2 = num;
				num = (short)1512847801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321912832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264123904;
				if (num != 0)
				{
				}
				num = (short)1907032065;
				if (num != 0)
				{
				}
				this.trkWideCAIDataMinResponseTimerms_A8515.HiddenDynamic = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0005A79C File Offset: 0x0005899C
		public bool TrkWideCAIDataMinResponseTimerms_A8515_HasDiffs
		{
			get
			{
				short num = (short)981362041;
				short num2 = num;
				num = (short)679961977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494155264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1559429121;
				if (num != 0)
				{
				}
				num = (short)1428815872;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataMinResponseTimerms_A8515._HasDiffs;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0005A850 File Offset: 0x00058A50
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x0005A904 File Offset: 0x00058B04
		public int TrkWideCAIDataResponseTimerms_A8949Value
		{
			get
			{
				short num = (short)2141610419;
				short num2 = num;
				num = (short)175530419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1910177792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30277633;
				if (num != 0)
				{
				}
				num = (short)2093481984;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Value;
			}
			set
			{
				short num = (short)279077550;
				short num2 = num;
				num = (short)199189166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881917952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)913440768;
				if (num != 0)
				{
				}
				num = (short)55705601;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Value = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0005A9B8 File Offset: 0x00058BB8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataResponseTimerms_A8949
		{
			get
			{
				short num = (short)1598633710;
				short num2 = num;
				num = (short)592262894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2123104256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)888930305;
				if (num != 0)
				{
				}
				num = (short)499515392;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0005AA68 File Offset: 0x00058C68
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0005AB1C File Offset: 0x00058D1C
		public string TrkWideCAIDataResponseTimerms_A8949_UIValue
		{
			get
			{
				short num = (short)1404567744;
				short num2 = num;
				num = (short)1712586944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1752170496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029715457;
				if (num != 0)
				{
				}
				num = (short)422838272;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.UIValue;
			}
			set
			{
				short num = (short)1879310337;
				if (num != 0)
				{
				}
				num = (short)1034158080;
				short num2 = num;
				num = (short)432722913;
				short num3 = num;
				num = (short)2128860129;
				switch (num3 == num)
				{
				}
				num = (short)458489856;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.UIValue = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0005ABD0 File Offset: 0x00058DD0
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0005AC84 File Offset: 0x00058E84
		internal int TrkWideCAIDataResponseTimerms_A8949Min
		{
			get
			{
				short num = (short)1916707015;
				short num2 = num;
				num = (short)1980997831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039007744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914830849;
				if (num != 0)
				{
				}
				num = (short)1789263872;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Min;
			}
			set
			{
				short num = (short)371487809;
				short num2 = num;
				num = (short)1449161793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)126418944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202440705;
				if (num != 0)
				{
				}
				num = (short)263913472;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Min = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0005AD3C File Offset: 0x00058F3C
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0005ADF0 File Offset: 0x00058FF0
		internal int TrkWideCAIDataResponseTimerms_A8949Max
		{
			get
			{
				short num = (short)1828585473;
				if (num != 0)
				{
				}
				num = (short)1424097280;
				short num2 = num;
				num = (short)1162968355;
				short num3 = num;
				num = (short)926514467;
				switch (num3 == num)
				{
				}
				num = (short)369754112;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Max;
			}
			set
			{
				short num = (short)123726044;
				short num2 = num;
				num = (short)1214048476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)116588544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474546177;
				if (num != 0)
				{
				}
				num = (short)1817706496;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Max = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0005AEA8 File Offset: 0x000590A8
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0005AF5C File Offset: 0x0005915C
		internal int TrkWideCAIDataResponseTimerms_A8949Step
		{
			get
			{
				short num = (short)103339045;
				short num2 = num;
				num = (short)628937765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292697600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262485505;
				if (num != 0)
				{
				}
				num = (short)650903552;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.StepSize;
			}
			set
			{
				short num = (short)2128533523;
				short num2 = num;
				num = (short)1069799443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248446976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)650772481;
				if (num != 0)
				{
				}
				num = (short)340197376;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.StepSize = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0005B014 File Offset: 0x00059214
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0005B0C8 File Offset: 0x000592C8
		public bool TrkWideCAIDataResponseTimerms_A8949_Applicable
		{
			get
			{
				short num = (short)1200422913;
				if (num != 0)
				{
				}
				num = (short)131923968;
				short num2 = num;
				num = (short)2094670315;
				short num3 = num;
				num = (short)1166746091;
				switch (num3 == num)
				{
				}
				num = (short)558694400;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Applicable;
			}
			set
			{
				short num = (short)589386891;
				short num2 = num;
				num = (short)1820415115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220725248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1077542912;
				if (num != 0)
				{
				}
				num = (short)178651137;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Applicable = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0005B180 File Offset: 0x00059380
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0005B234 File Offset: 0x00059434
		public bool TrkWideCAIDataResponseTimerms_A8949_Valid
		{
			get
			{
				short num = (short)344199900;
				short num2 = num;
				num = (short)513282780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1976172544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375731712;
				if (num != 0)
				{
				}
				num = (short)75104257;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Valid;
			}
			set
			{
				short num = (short)1559559240;
				short num2 = num;
				num = (short)1098447944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656291328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1002176513;
				if (num != 0)
				{
				}
				num = (short)982777856;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Valid = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0005B2E8 File Offset: 0x000594E8
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x0005B3A0 File Offset: 0x000595A0
		public bool TrkWideCAIDataResponseTimerms_A8949_Visible
		{
			get
			{
				short num = (short)27981539;
				short num2 = num;
				num = (short)133166819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)400162816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1591279617;
				if (num != 0)
				{
				}
				num = (short)1634795520;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Visible;
			}
			set
			{
				short num = (short)444527758;
				short num2 = num;
				num = (short)927134862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015035392;
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
				num = (short)706674688;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Visible = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0005B458 File Offset: 0x00059658
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0005B50C File Offset: 0x0005970C
		public bool TrkWideCAIDataResponseTimerms_A8949_Editable
		{
			get
			{
				short num = (short)1721103353;
				short num2 = num;
				num = (short)1769599993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615645184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)537001985;
				if (num != 0)
				{
				}
				num = (short)1409482752;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.Editable;
			}
			set
			{
				short num = (short)1215101241;
				short num2 = num;
				num = (short)1526004025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727922176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622081537;
				if (num != 0)
				{
				}
				num = (short)1470300160;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.Editable = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0005B5C4 File Offset: 0x000597C4
		internal string TrkWideCAIDataResponseTimerms_A8949_UILabel
		{
			get
			{
				short num = (short)1614938113;
				if (num != 0)
				{
				}
				num = (short)1117323264;
				short num2 = num;
				num = (short)432961567;
				short num3 = num;
				num = (short)1004566559;
				switch (num3 == num)
				{
				}
				num = (short)1981743104;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.UIName;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0005B678 File Offset: 0x00059878
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x0005B72C File Offset: 0x0005992C
		internal bool TrkWideCAIDataResponseTimerms_A8949_HiddenStatic
		{
			get
			{
				short num = (short)520503442;
				short num2 = num;
				num = (short)1677082770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1709178880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2086010881;
				if (num != 0)
				{
				}
				num = (short)1433337856;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.HiddenStatic;
			}
			set
			{
				short num = (short)525018395;
				short num2 = num;
				num = (short)1287202075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)619053056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842334208;
				if (num != 0)
				{
				}
				num = (short)2115895297;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.HiddenStatic = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0005B7E0 File Offset: 0x000599E0
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0005B894 File Offset: 0x00059A94
		internal bool TrkWideCAIDataResponseTimerms_A8949_HiddenDynamic
		{
			get
			{
				short num = (short)559155630;
				short num2 = num;
				num = (short)843188654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)439353344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909719041;
				if (num != 0)
				{
				}
				num = (short)2063597568;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949.HiddenDynamic;
			}
			set
			{
				short num = (short)639685084;
				short num2 = num;
				num = (short)1102107100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598160896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1578172416;
				if (num != 0)
				{
				}
				num = (short)38273025;
				if (num != 0)
				{
				}
				this.trkWideCAIDataResponseTimerms_A8949.HiddenDynamic = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0005B948 File Offset: 0x00059B48
		public bool TrkWideCAIDataResponseTimerms_A8949_HasDiffs
		{
			get
			{
				short num = (short)1274130409;
				short num2 = num;
				num = (short)1828368361;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1595604992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1270546433;
				if (num != 0)
				{
				}
				num = (short)1027342336;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataResponseTimerms_A8949._HasDiffs;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0005B9FC File Offset: 0x00059BFC
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0005BAB0 File Offset: 0x00059CB0
		public int TrkWideCAIDataTxLongRandomRangeMs_A9547Value
		{
			get
			{
				short num = (short)242644061;
				short num2 = num;
				num = (short)1053389917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2054815744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322371585;
				if (num != 0)
				{
				}
				num = (short)1210974208;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Value;
			}
			set
			{
				short num = (short)760770;
				short num2 = num;
				num = (short)1967299522;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1333919744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611909633;
				if (num != 0)
				{
				}
				num = (short)1848377344;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Value = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0005BB64 File Offset: 0x00059D64
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataTxLongRandomRangeMs_A9547
		{
			get
			{
				short num = (short)1008336897;
				if (num != 0)
				{
				}
				num = (short)649068544;
				short num2 = num;
				num = (short)535058015;
				short num3 = num;
				num = (short)633362015;
				switch (num3 == num)
				{
				}
				num = (short)1670971392;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0005BC18 File Offset: 0x00059E18
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0005BCD0 File Offset: 0x00059ED0
		public string TrkWideCAIDataTxLongRandomRangeMs_A9547_UIValue
		{
			get
			{
				short num = (short)265573348;
				short num2 = num;
				num = (short)620188644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38010880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152961025;
				if (num != 0)
				{
				}
				num = (short)1748762624;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.UIValue;
			}
			set
			{
				short num = (short)340059251;
				short num2 = num;
				num = (short)203416691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)723976192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814626305;
				if (num != 0)
				{
				}
				num = (short)494272512;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.UIValue = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0005BD84 File Offset: 0x00059F84
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0005BE38 File Offset: 0x0005A038
		internal int TrkWideCAIDataTxLongRandomRangeMs_A9547Min
		{
			get
			{
				short num = (short)1567686657;
				if (num != 0)
				{
				}
				num = (short)739377152;
				short num2 = num;
				num = (short)222201029;
				short num3 = num;
				num = (short)488342725;
				switch (num3 == num)
				{
				}
				num = (short)819331072;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Min;
			}
			set
			{
				short num = (short)837175070;
				short num2 = num;
				num = (short)274024222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1987903488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)464781313;
				if (num != 0)
				{
				}
				num = (short)222691328;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Min = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0005BEEC File Offset: 0x0005A0EC
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0005BFA0 File Offset: 0x0005A1A0
		internal int TrkWideCAIDataTxLongRandomRangeMs_A9547Max
		{
			get
			{
				short num = (short)367788033;
				if (num != 0)
				{
				}
				num = (short)1899757568;
				short num2 = num;
				num = (short)848473018;
				short num3 = num;
				num = (short)1283697594;
				switch (num3 == num)
				{
				}
				num = (short)1324285952;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Max;
			}
			set
			{
				short num = (short)1868601124;
				short num2 = num;
				num = (short)665818916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642921984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105775105;
				if (num != 0)
				{
				}
				num = (short)1314848768;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Max = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0005C058 File Offset: 0x0005A258
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0005C108 File Offset: 0x0005A308
		internal int TrkWideCAIDataTxLongRandomRangeMs_A9547Step
		{
			get
			{
				short num = (short)1926354091;
				short num2 = num;
				num = (short)1319883947;
				switch (num2 == num)
				{
				}
				num = (short)862191617;
				if (num != 0)
				{
				}
				num = (short)1503002624;
				short num3 = num;
				num = (short)1959264256;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.StepSize;
			}
			set
			{
				short num = (short)2071050953;
				short num2 = num;
				num = (short)1494530761;
				switch (num2 == num)
				{
				}
				num = (short)777781249;
				if (num != 0)
				{
				}
				num = (short)1550057472;
				short num3 = num;
				num = (short)1286471680;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.StepSize = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0005C1C0 File Offset: 0x0005A3C0
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0005C278 File Offset: 0x0005A478
		public bool TrkWideCAIDataTxLongRandomRangeMs_A9547_Applicable
		{
			get
			{
				short num = (short)37174736;
				short num2 = num;
				num = (short)2068135376;
				switch (num2 == num)
				{
				}
				num = (short)249430017;
				if (num != 0)
				{
				}
				num = (short)711131136;
				short num3 = num;
				num = (short)1877999616;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Applicable;
			}
			set
			{
				short num = (short)182387352;
				short num2 = num;
				num = (short)1662780056;
				switch (num2 == num)
				{
				}
				num = (short)2162689;
				if (num != 0)
				{
				}
				num = (short)1139998720;
				short num3 = num;
				num = (short)1465384960;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Applicable = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0005C32C File Offset: 0x0005A52C
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x0005C3E0 File Offset: 0x0005A5E0
		public bool TrkWideCAIDataTxLongRandomRangeMs_A9547_Valid
		{
			get
			{
				short num = (short)12153843;
				short num2 = num;
				num = (short)308179955;
				switch (num2 == num)
				{
				}
				num = (short)1898577920;
				if (num != 0)
				{
				}
				num = (short)217907200;
				short num3 = num;
				num = (short)875102209;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Valid;
			}
			set
			{
				short num = (short)1754499940;
				short num2 = num;
				num = (short)1825672036;
				switch (num2 == num)
				{
				}
				num = (short)39780352;
				if (num != 0)
				{
				}
				num = (short)2039676928;
				short num3 = num;
				num = (short)962396161;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Valid = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0005C498 File Offset: 0x0005A698
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0005C550 File Offset: 0x0005A750
		public bool TrkWideCAIDataTxLongRandomRangeMs_A9547_Visible
		{
			get
			{
				short num = (short)1495540001;
				short num2 = num;
				num = (short)1027612961;
				switch (num2 == num)
				{
				}
				num = (short)186712064;
				if (num != 0)
				{
				}
				num = (short)2057175040;
				short num3 = num;
				num = (short)910950401;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Visible;
			}
			set
			{
				short num = (short)346281464;
				short num2 = num;
				num = (short)840619512;
				switch (num2 == num)
				{
				}
				num = (short)151060481;
				if (num != 0)
				{
				}
				num = (short)459735040;
				short num3 = num;
				num = (short)609288192;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Visible = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0005C604 File Offset: 0x0005A804
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		public bool TrkWideCAIDataTxLongRandomRangeMs_A9547_Editable
		{
			get
			{
				short num = (short)594612072;
				short num2 = num;
				num = (short)1949568872;
				switch (num2 == num)
				{
				}
				num = (short)1098448897;
				if (num != 0)
				{
				}
				num = (short)364249088;
				short num3 = num;
				num = (short)435617792;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.Editable;
			}
			set
			{
				short num = (short)2069579958;
				short num2 = num;
				num = (short)99436726;
				switch (num2 == num)
				{
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				num = (short)1921581056;
				short num3 = num;
				num = (short)636813312;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.Editable = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0005C774 File Offset: 0x0005A974
		internal string TrkWideCAIDataTxLongRandomRangeMs_A9547_UILabel
		{
			get
			{
				short num = (short)1595342997;
				short num2 = num;
				num = (short)154534037;
				switch (num2 == num)
				{
				}
				num = (short)1493237760;
				if (num != 0)
				{
				}
				num = (short)807862272;
				short num3 = num;
				num = (short)1677590529;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.UIName;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0005C82C File Offset: 0x0005AA2C
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0005C8E0 File Offset: 0x0005AAE0
		internal bool TrkWideCAIDataTxLongRandomRangeMs_A9547_HiddenStatic
		{
			get
			{
				short num = (short)1771650157;
				short num2 = num;
				num = (short)253967469;
				switch (num2 == num)
				{
				}
				num = (short)1308557313;
				if (num != 0)
				{
				}
				num = (short)1360789504;
				short num3 = num;
				num = (short)4128768;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.HiddenStatic;
			}
			set
			{
				short num = (short)768163676;
				short num2 = num;
				num = (short)1126186844;
				switch (num2 == num)
				{
				}
				num = (short)1204486144;
				if (num != 0)
				{
				}
				num = (short)288096256;
				short num3 = num;
				num = (short)394330113;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.HiddenStatic = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0005C994 File Offset: 0x0005AB94
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		internal bool TrkWideCAIDataTxLongRandomRangeMs_A9547_HiddenDynamic
		{
			get
			{
				short num = (short)117637121;
				if (num != 0)
				{
				}
				num = (short)776590321;
				short num2 = num;
				num = (short)509727729;
				switch (num2 == num)
				{
				}
				num = (short)717684736;
				short num3 = num;
				num = (short)123535360;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547.HiddenDynamic;
			}
			set
			{
				short num = (short)1095040775;
				short num2 = num;
				num = (short)274792199;
				switch (num2 == num)
				{
				}
				num = (short)167051265;
				if (num != 0)
				{
				}
				num = (short)1390084096;
				short num3 = num;
				num = (short)1626996736;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxLongRandomRangeMs_A9547.HiddenDynamic = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0005CB00 File Offset: 0x0005AD00
		public bool TrkWideCAIDataTxLongRandomRangeMs_A9547_HasDiffs
		{
			get
			{
				short num = (short)1512131410;
				short num2 = num;
				num = (short)62081874;
				switch (num2 == num)
				{
				}
				num = (short)578682880;
				if (num != 0)
				{
				}
				num = (short)1079771136;
				short num3 = num;
				num = (short)1765081089;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxLongRandomRangeMs_A9547._HasDiffs;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0005CC6C File Offset: 0x0005AE6C
		public int TrkWideCAIDataTxRespRandomRangems_A9564Value
		{
			get
			{
				short num = (short)804376633;
				short num2 = num;
				num = (short)332058681;
				switch (num2 == num)
				{
				}
				num = (short)1714159617;
				if (num != 0)
				{
				}
				num = (short)808452096;
				short num3 = num;
				num = (short)209518592;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Value;
			}
			set
			{
				short num = (short)1890127141;
				short num2 = num;
				num = (short)1984826661;
				switch (num2 == num)
				{
				}
				num = (short)1935736833;
				if (num != 0)
				{
				}
				num = (short)431161344;
				short num3 = num;
				num = (short)1636237312;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Value = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0005CD20 File Offset: 0x0005AF20
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataTxRespRandomRangems_A9564
		{
			get
			{
				short num = (short)2045759594;
				short num2 = num;
				num = (short)2134757482;
				switch (num2 == num)
				{
				}
				num = (short)240451585;
				if (num != 0)
				{
				}
				num = (short)867631104;
				short num3 = num;
				num = (short)1680211968;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0005CDD0 File Offset: 0x0005AFD0
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0005CE84 File Offset: 0x0005B084
		public string TrkWideCAIDataTxRespRandomRangems_A9564_UIValue
		{
			get
			{
				short num = (short)872530330;
				short num2 = num;
				num = (short)605143450;
				switch (num2 == num)
				{
				}
				num = (short)1658978304;
				if (num != 0)
				{
				}
				num = (short)466878464;
				short num3 = num;
				num = (short)1420165121;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.UIValue;
			}
			set
			{
				short num = (short)1523983591;
				short num2 = num;
				num = (short)468133095;
				switch (num2 == num)
				{
				}
				num = (short)1390542848;
				if (num != 0)
				{
				}
				num = (short)1299447808;
				short num3 = num;
				num = (short)2108751873;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.UIValue = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0005CF38 File Offset: 0x0005B138
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0005CFEC File Offset: 0x0005B1EC
		internal int TrkWideCAIDataTxRespRandomRangems_A9564Min
		{
			get
			{
				short num = (short)1132149911;
				short num2 = num;
				num = (short)1237793943;
				switch (num2 == num)
				{
				}
				num = (short)957743104;
				if (num != 0)
				{
				}
				num = (short)1713176576;
				short num3 = num;
				num = (short)1268776961;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Min;
			}
			set
			{
				short num = (short)741824768;
				short num2 = num;
				num = (short)1982290176;
				switch (num2 == num)
				{
				}
				num = (short)894042113;
				if (num != 0)
				{
				}
				num = (short)491913216;
				short num3 = num;
				num = (short)1962934272;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Min = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0005D0A4 File Offset: 0x0005B2A4
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0005D158 File Offset: 0x0005B358
		internal int TrkWideCAIDataTxRespRandomRangems_A9564Max
		{
			get
			{
				short num = (short)518743313;
				short num2 = num;
				num = (short)965829905;
				switch (num2 == num)
				{
				}
				num = (short)1125384193;
				if (num != 0)
				{
				}
				num = (short)1976238080;
				short num3 = num;
				num = (short)2026504192;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Max;
			}
			set
			{
				short num = (short)374231254;
				short num2 = num;
				num = (short)1488933078;
				switch (num2 == num)
				{
				}
				num = (short)329187329;
				if (num != 0)
				{
				}
				num = (short)229376000;
				short num3 = num;
				num = (short)1299513344;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Max = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0005D20C File Offset: 0x0005B40C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0005D2C4 File Offset: 0x0005B4C4
		internal int TrkWideCAIDataTxRespRandomRangems_A9564Step
		{
			get
			{
				short num = (short)801595267;
				short num2 = num;
				num = (short)1170169731;
				switch (num2 == num)
				{
				}
				num = (short)1085669376;
				if (num != 0)
				{
				}
				num = (short)1990000640;
				short num3 = num;
				num = (short)621936641;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.StepSize;
			}
			set
			{
				short num = (short)204408069;
				short num2 = num;
				num = (short)829097221;
				switch (num2 == num)
				{
				}
				num = (short)1789853697;
				if (num != 0)
				{
				}
				num = (short)815988736;
				short num3 = num;
				num = (short)120389632;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.StepSize = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0005D378 File Offset: 0x0005B578
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0005D430 File Offset: 0x0005B630
		public bool TrkWideCAIDataTxRespRandomRangems_A9564_Applicable
		{
			get
			{
				short num = (short)425795041;
				short num2 = num;
				num = (short)1847533025;
				switch (num2 == num)
				{
				}
				num = (short)1386348545;
				if (num != 0)
				{
				}
				num = (short)1092616192;
				short num3 = num;
				num = (short)1645477888;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Applicable;
			}
			set
			{
				short num = (short)1641949502;
				short num2 = num;
				num = (short)1425811774;
				switch (num2 == num)
				{
				}
				num = (short)1871511553;
				if (num != 0)
				{
				}
				num = (short)1509425152;
				short num3 = num;
				num = (short)1099956224;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Applicable = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0005D4E4 File Offset: 0x0005B6E4
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0005D598 File Offset: 0x0005B798
		public bool TrkWideCAIDataTxRespRandomRangems_A9564_Valid
		{
			get
			{
				short num = (short)793445481;
				short num2 = num;
				num = (short)228328553;
				switch (num2 == num)
				{
				}
				num = (short)1974403073;
				if (num != 0)
				{
				}
				num = (short)1064763392;
				short num3 = num;
				num = (short)910622720;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Valid;
			}
			set
			{
				short num = (short)2101759839;
				short num2 = num;
				num = (short)1647791967;
				switch (num2 == num)
				{
				}
				num = (short)1758396417;
				if (num != 0)
				{
				}
				num = (short)78905344;
				short num3 = num;
				num = (short)2071461888;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Valid = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0005D64C File Offset: 0x0005B84C
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0005D700 File Offset: 0x0005B900
		public bool TrkWideCAIDataTxRespRandomRangems_A9564_Visible
		{
			get
			{
				short num = (short)1030291457;
				if (num != 0)
				{
				}
				num = (short)694784244;
				short num2 = num;
				num = (short)1522110708;
				switch (num2 == num)
				{
				}
				num = (short)1910702080;
				short num3 = num;
				num = (short)1185218560;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Visible;
			}
			set
			{
				short num = (short)1919221761;
				if (num != 0)
				{
				}
				num = (short)296252977;
				short num2 = num;
				num = (short)794064433;
				switch (num2 == num)
				{
				}
				num = (short)1164509184;
				short num3 = num;
				num = (short)124518400;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Visible = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0005D7B4 File Offset: 0x0005B9B4
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0005D86C File Offset: 0x0005BA6C
		public bool TrkWideCAIDataTxRespRandomRangems_A9564_Editable
		{
			get
			{
				short num = (short)1132248423;
				short num2 = num;
				num = (short)2013379943;
				switch (num2 == num)
				{
				}
				num = (short)1226637313;
				if (num != 0)
				{
				}
				num = (short)603914240;
				short num3 = num;
				num = (short)1794572288;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.Editable;
			}
			set
			{
				short num = (short)904740400;
				short num2 = num;
				num = (short)558513712;
				switch (num2 == num)
				{
				}
				num = (short)539164673;
				if (num != 0)
				{
				}
				num = (short)770572288;
				short num3 = num;
				num = (short)576061440;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.Editable = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0005D924 File Offset: 0x0005BB24
		internal string TrkWideCAIDataTxRespRandomRangems_A9564_UILabel
		{
			get
			{
				short num = (short)792526849;
				if (num != 0)
				{
				}
				num = (short)1172062591;
				short num2 = num;
				num = (short)1781809535;
				switch (num2 == num)
				{
				}
				num = (short)1241382912;
				short num3 = num;
				num = (short)1807941632;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.UIName;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0005D9DC File Offset: 0x0005BBDC
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0005DA90 File Offset: 0x0005BC90
		internal bool TrkWideCAIDataTxRespRandomRangems_A9564_HiddenStatic
		{
			get
			{
				short num = (short)303955969;
				if (num != 0)
				{
				}
				num = (short)849262867;
				short num2 = num;
				num = (short)975747347;
				switch (num2 == num)
				{
				}
				num = (short)1120075776;
				short num3 = num;
				num = (short)255197184;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.HiddenStatic;
			}
			set
			{
				short num = (short)2017325557;
				short num2 = num;
				num = (short)1105457653;
				switch (num2 == num)
				{
				}
				num = (short)567607296;
				if (num != 0)
				{
				}
				num = (short)651689984;
				short num3 = num;
				num = (short)1189609473;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.HiddenStatic = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0005DB44 File Offset: 0x0005BD44
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0005DBF8 File Offset: 0x0005BDF8
		internal bool TrkWideCAIDataTxRespRandomRangems_A9564_HiddenDynamic
		{
			get
			{
				short num = (short)1523679238;
				short num2 = num;
				num = (short)1245544454;
				switch (num2 == num)
				{
				}
				num = (short)1403191296;
				if (num != 0)
				{
				}
				num = (short)1306853376;
				short num3 = num;
				num = (short)1063780353;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564.HiddenDynamic;
			}
			set
			{
				short num = (short)1335258580;
				short num2 = num;
				num = (short)1040870868;
				switch (num2 == num)
				{
				}
				num = (short)1935671297;
				if (num != 0)
				{
				}
				num = (short)641925120;
				short num3 = num;
				num = (short)497221632;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxRespRandomRangems_A9564.HiddenDynamic = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0005DCB0 File Offset: 0x0005BEB0
		public bool TrkWideCAIDataTxRespRandomRangems_A9564_HasDiffs
		{
			get
			{
				short num = (short)1599864833;
				if (num != 0)
				{
				}
				num = (short)1405835006;
				short num2 = num;
				num = (short)1208309502;
				switch (num2 == num)
				{
				}
				num = (short)4456448;
				short num3 = num;
				num = (short)1745027072;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxRespRandomRangems_A9564._HasDiffs;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0005DD68 File Offset: 0x0005BF68
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0005DE20 File Offset: 0x0005C020
		public int TrkWideCAIDataTxShortRandomRangems_A9566Value
		{
			get
			{
				short num = (short)1359243930;
				short num2 = num;
				num = (short)1657301658;
				switch (num2 == num)
				{
				}
				num = (short)886439937;
				if (num != 0)
				{
				}
				num = (short)1099628544;
				short num3 = num;
				num = (short)1780613120;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Value;
			}
			set
			{
				short num = (short)246355379;
				short num2 = num;
				num = (short)681776563;
				switch (num2 == num)
				{
				}
				num = (short)768540673;
				if (num != 0)
				{
				}
				num = (short)572456960;
				short num3 = num;
				num = (short)506265600;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Value = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0005DED8 File Offset: 0x0005C0D8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideCAIDataTxShortRandomRangems_A9566
		{
			get
			{
				short num = (short)1688191223;
				short num2 = num;
				num = (short)1495711991;
				switch (num2 == num)
				{
				}
				num = (short)1197408256;
				if (num != 0)
				{
				}
				num = (short)698810368;
				short num3 = num;
				num = (short)2030370817;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0005DF88 File Offset: 0x0005C188
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0005E03C File Offset: 0x0005C23C
		public string TrkWideCAIDataTxShortRandomRangems_A9566_UIValue
		{
			get
			{
				short num = (short)1555365889;
				if (num != 0)
				{
				}
				num = (short)523489607;
				short num2 = num;
				num = (short)1403244871;
				switch (num2 == num)
				{
				}
				num = (short)1842479104;
				short num3 = num;
				num = (short)698875904;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.UIValue;
			}
			set
			{
				short num = (short)1601991547;
				short num2 = num;
				num = (short)2134537083;
				switch (num2 == num)
				{
				}
				num = (short)196214784;
				if (num != 0)
				{
				}
				num = (short)590544896;
				short num3 = num;
				num = (short)1549533185;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.UIValue = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0005E1AC File Offset: 0x0005C3AC
		internal int TrkWideCAIDataTxShortRandomRangems_A9566Min
		{
			get
			{
				short num = (short)1819227393;
				short num2 = num;
				num = (short)1502033153;
				switch (num2 == num)
				{
				}
				num = (short)1176043521;
				if (num != 0)
				{
				}
				num = (short)964296704;
				short num3 = num;
				num = (short)1388183552;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Min;
			}
			set
			{
				short num = (short)1679425537;
				if (num != 0)
				{
				}
				num = (short)2131609552;
				short num2 = num;
				num = (short)217958352;
				switch (num2 == num)
				{
				}
				num = (short)2125594624;
				short num3 = num;
				num = (short)2124939264;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Min = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0005E260 File Offset: 0x0005C460
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x0005E314 File Offset: 0x0005C514
		internal int TrkWideCAIDataTxShortRandomRangems_A9566Max
		{
			get
			{
				short num = (short)1737774936;
				short num2 = num;
				num = (short)2022594392;
				switch (num2 == num)
				{
				}
				num = (short)677380097;
				if (num != 0)
				{
				}
				num = (short)1439432704;
				short num3 = num;
				num = (short)1209663488;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Max;
			}
			set
			{
				short num = (short)1098713234;
				short num2 = num;
				num = (short)407505042;
				switch (num2 == num)
				{
				}
				num = (short)216268801;
				if (num != 0)
				{
				}
				num = (short)1725497344;
				short num3 = num;
				num = (short)2088828928;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Max = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0005E3CC File Offset: 0x0005C5CC
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x0005E480 File Offset: 0x0005C680
		internal int TrkWideCAIDataTxShortRandomRangems_A9566Step
		{
			get
			{
				short num = (short)1964053561;
				short num2 = num;
				num = (short)1357321273;
				switch (num2 == num)
				{
				}
				num = (short)1374158848;
				if (num != 0)
				{
				}
				num = (short)1947271168;
				short num3 = num;
				num = (short)1595408385;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.StepSize;
			}
			set
			{
				short num = (short)150370207;
				short num2 = num;
				num = (short)585791391;
				switch (num2 == num)
				{
				}
				num = (short)2019753984;
				if (num != 0)
				{
				}
				num = (short)279445504;
				short num3 = num;
				num = (short)243597313;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.StepSize = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0005E538 File Offset: 0x0005C738
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0005E5EC File Offset: 0x0005C7EC
		public bool TrkWideCAIDataTxShortRandomRangems_A9566_Applicable
		{
			get
			{
				short num = (short)119633587;
				short num2 = num;
				num = (short)293369523;
				switch (num2 == num)
				{
				}
				num = (short)636223489;
				if (num != 0)
				{
				}
				num = (short)1029046272;
				short num3 = num;
				num = (short)307625984;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Applicable;
			}
			set
			{
				short num = (short)1728577537;
				if (num != 0)
				{
				}
				num = (short)895019551;
				short num2 = num;
				num = (short)1051585055;
				switch (num2 == num)
				{
				}
				num = (short)132710400;
				short num3 = num;
				num = (short)971112448;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Applicable = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0005E6A0 File Offset: 0x0005C8A0
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0005E754 File Offset: 0x0005C954
		public bool TrkWideCAIDataTxShortRandomRangems_A9566_Valid
		{
			get
			{
				short num = (short)2044621373;
				short num2 = num;
				num = (short)1052734013;
				switch (num2 == num)
				{
				}
				num = (short)1971453953;
				if (num != 0)
				{
				}
				num = (short)274857984;
				short num3 = num;
				num = (short)2036006912;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Valid;
			}
			set
			{
				short num = (short)1331337236;
				short num2 = num;
				num = (short)1920505876;
				switch (num2 == num)
				{
				}
				num = (short)265093121;
				if (num != 0)
				{
				}
				num = (short)2044133376;
				short num3 = num;
				num = (short)1007419392;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Valid = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0005E80C File Offset: 0x0005CA0C
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0005E8C4 File Offset: 0x0005CAC4
		public bool TrkWideCAIDataTxShortRandomRangems_A9566_Visible
		{
			get
			{
				short num = (short)1483170249;
				short num2 = num;
				num = (short)1336500681;
				switch (num2 == num)
				{
				}
				num = (short)503447552;
				if (num != 0)
				{
				}
				num = (short)1215299584;
				short num3 = num;
				num = (short)1431633921;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Visible;
			}
			set
			{
				short num = (short)289144833;
				if (num != 0)
				{
				}
				num = (short)350410942;
				short num2 = num;
				num = (short)580638910;
				switch (num2 == num)
				{
				}
				num = (short)726335488;
				short num3 = num;
				num = (short)1103691776;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Visible = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0005E978 File Offset: 0x0005CB78
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0005EA2C File Offset: 0x0005CC2C
		public bool TrkWideCAIDataTxShortRandomRangems_A9566_Editable
		{
			get
			{
				short num = (short)1953955841;
				if (num != 0)
				{
				}
				num = (short)1103671746;
				short num2 = num;
				num = (short)427733442;
				switch (num2 == num)
				{
				}
				num = (short)1915092992;
				short num3 = num;
				num = (short)1896022016;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.Editable;
			}
			set
			{
				short num = (short)1675886593;
				if (num != 0)
				{
				}
				num = (short)1021842543;
				short num2 = num;
				num = (short)1206719599;
				switch (num2 == num)
				{
				}
				num = (short)810352640;
				short num3 = num;
				num = (short)786759680;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.Editable = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0005EAE0 File Offset: 0x0005CCE0
		internal string TrkWideCAIDataTxShortRandomRangems_A9566_UILabel
		{
			get
			{
				short num = (short)1084982878;
				short num2 = num;
				num = (short)559253086;
				switch (num2 == num)
				{
				}
				num = (short)1480523777;
				if (num != 0)
				{
				}
				num = (short)404750336;
				short num3 = num;
				num = (short)583991296;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.UIName;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0005EB94 File Offset: 0x0005CD94
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0005EC48 File Offset: 0x0005CE48
		internal bool TrkWideCAIDataTxShortRandomRangems_A9566_HiddenStatic
		{
			get
			{
				short num = (short)60883775;
				short num2 = num;
				num = (short)1046741823;
				switch (num2 == num)
				{
				}
				num = (short)790495233;
				if (num != 0)
				{
				}
				num = (short)1274937344;
				short num3 = num;
				num = (short)928448512;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.HiddenStatic;
			}
			set
			{
				short num = (short)1916054713;
				short num2 = num;
				num = (short)684698809;
				switch (num2 == num)
				{
				}
				num = (short)1894973441;
				if (num != 0)
				{
				}
				num = (short)756219904;
				short num3 = num;
				num = (short)980287488;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.HiddenStatic = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0005ED00 File Offset: 0x0005CF00
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0005EDB4 File Offset: 0x0005CFB4
		internal bool TrkWideCAIDataTxShortRandomRangems_A9566_HiddenDynamic
		{
			get
			{
				short num = (short)1451100926;
				short num2 = num;
				num = (short)2067663614;
				switch (num2 == num)
				{
				}
				num = (short)1704394752;
				if (num != 0)
				{
				}
				num = (short)1903427584;
				short num3 = num;
				num = (short)1470562305;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566.HiddenDynamic;
			}
			set
			{
				short num = (short)689635329;
				if (num != 0)
				{
				}
				num = (short)663812439;
				short num2 = num;
				num = (short)1416427863;
				switch (num2 == num)
				{
				}
				num = (short)746848256;
				short num3 = num;
				num = (short)1773535232;
				if (num != 0)
				{
				}
				this.trkWideCAIDataTxShortRandomRangems_A9566.HiddenDynamic = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0005EE6C File Offset: 0x0005D06C
		public bool TrkWideCAIDataTxShortRandomRangems_A9566_HasDiffs
		{
			get
			{
				short num = (short)133918625;
				short num2 = num;
				num = (short)1692233633;
				switch (num2 == num)
				{
				}
				num = (short)231145472;
				if (num != 0)
				{
				}
				num = (short)2126118912;
				short num3 = num;
				num = (short)2113667073;
				if (num != 0)
				{
				}
				return this.trkWideCAIDataTxShortRandomRangems_A9566._HasDiffs;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0005EF20 File Offset: 0x0005D120
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)998834179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				case 1:
					num2 = (short)1715470337;
					if (num2 != 0)
					{
					}
					goto IL_117;
				case 2:
					num2 = (short)589365248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)67436544;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)669515777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					IL_3A:
					if (base.ParentRecset != null)
					{
						num2 = (short)783351810;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				}
				goto IL_24;
				IL_117:
				num2 = (short)682804796;
				short num4 = num2;
				num2 = (short)1794950716;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3A;
				default:
					goto IL_14E;
				}
			}
			IL_14E:
			num2 = (short)1590493184;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1106706436;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001EE RID: 494
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataFrameSyncSeekPeriodms_A8146;

		// Token: 0x040001EF RID: 495
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataTxLimitedPatienceSec_A9545;

		// Token: 0x040001F0 RID: 496
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataMaxTxAttempts_A8475;

		// Token: 0x040001F1 RID: 497
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataMinResponseTimerms_A8515;

		// Token: 0x040001F2 RID: 498
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataResponseTimerms_A8949;

		// Token: 0x040001F3 RID: 499
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataTxLongRandomRangeMs_A9547;

		// Token: 0x040001F4 RID: 500
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataTxRespRandomRangems_A9564;

		// Token: 0x040001F5 RID: 501
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideCAIDataTxShortRandomRangems_A9566;
	}
}
