using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200017A RID: 378
	[global::System.Serializable]
	public class Location : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003C91 RID: 15505 RVA: 0x00389BC8 File Offset: 0x00387DC8
		public Location(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00389BE4 File Offset: 0x00387DE4
		protected Location(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00389BFC File Offset: 0x00387DFC
		public override void Init()
		{
			int a_ = 15;
			short num = (short)674103296;
			short num2 = num;
			num = (short)64382963;
			short num3 = num;
			num = (short)1378445299;
			switch (num3 == num)
			{
			}
			num = (short)201588736;
			if (num != 0)
			{
			}
			num = (short)554303489;
			if (num != 0)
			{
			}
			this.radWideLocationLocationEnable_A8448 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫ꋭ鿯釱闳苵釷闹鋻믽滿持昃樅洇唉䴋㘍␏☑Ⱃ", a_), global::CommonResources.AcgResources.ID_LOCATIONENABLE);
			this.radWideLocationLocationEnable_A8448.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideLocationLocationEnable_A8448.DataTransferOrder = 7;
			this.radWideLocationMaxStoredLocationRequests_A8473 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫ꏭ釯諱ꟳ苵韷裹駻髽䳿洁會朅簇按挋怍䈏眑攓挕紗椙栛洝缟挡ᰣሥἧᤩ", a_), global::CommonResources.AcgResources.ID_MAXSTOREDLOCATIONREQUESTS, 0, 10, 1);
			this.radWideLocationMaxStoredLocationRequests_A8473.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideLocationMaxStoredLocationRequests_A8473.DataTransferOrder = 109;
			this.radWideLocationMaxStoredLocationRequests_A8473.ShowHexValue = false;
			this.radWideLocationUserSelectableLocationEnable_A9605 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫믭華韱蛳ꗵ鷷雹駻鷽瓿持昃樅洇䘉挋洍焏昑紓礕瘗弙爛缝䈟両䄣礥椧ጩᨫḭԯ", a_), global::CommonResources.AcgResources.ID_USERSELECTABLELOCATIONENABLE);
			this.radWideLocationUserSelectableLocationEnable_A9605.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideLocationUserSelectableLocationEnable_A9605.DataTransferOrder = 95;
			this.radWideLocationDistanceUnit_A13080 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫ꫭ駯臱胳韵雷駹駻꯽滿欁瀃夅䤇㬉㼋㸍⠏∑", a_), global::CommonResources.AcgResources.ID_DISTANCEUNIT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLocationDistanceUnit_A13080LovStrs);
			this.radWideLocationDistanceUnit_A13080.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideLocationDistanceUnit_A13080.DataTransferOrder = 99;
			this.radWideLocationExitLocationMenuonPTT_A13081 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫꯭裯鯱胳뫵韷駹鷻諽槿洁樃䬅洇搉礋愍縏䈑䀓䈕䜗嬙ⴛⴝဟᨡᔣ", a_), global::CommonResources.AcgResources.ID_EXITLOCATIONMENUONPTT);
			this.radWideLocationExitLocationMenuonPTT_A13081.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideLocationExitLocationMenuonPTT_A13081.DataTransferOrder = 100;
			this.radWideLocationGpsMode_A22627 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫ꧭ胯臱맳駵鳷鿹ꏻ뿽㋿、㈃㐅㼇", a_), global::CommonResources.AcgResources.ID_GPSMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLocationGpsMode_A22627LovStrs);
			this.radWideLocationGpsMode_A22627.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLocationGpsMode_A22627.DataTransferOrder = 9;
			this.radWideLocationDisplayFormat_A41561 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideLocationDisplayFormat_A41561LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideLocationDisplayFormat_A41561LovStrs), this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫ꫭ駯臱蓳髵駷菹뫻釽狿漁攃爅圇䬉㠋㼍┏␑┓", a_), global::CommonResources.AcgResources.ID_LOCATIONDISPLAYFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLocationDisplayFormat_A41561LovStrs);
			this.radWideLocationDisplayFormat_A41561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideLocationDisplayFormat_A41561.DataTransferOrder = 55;
			this.gPSFailToneInterval_42329 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("韏苑蟓郕맗동냛諝迟賡臣꿥蛧黩觫鳭蛯鏱飳꧵쳷죹쿻쳽㧿", a_), global::CommonResources.AcgResources.ID_GPSFAILTONEINTERVALSEC, 0, 31, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 30);
			this.gPSFailToneInterval_42329.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.gPSFailToneInterval_42329.DataTransferOrder = 10;
			this.gPSFailToneInterval_42329.ShowHexValue = false;
			this.radWideLocP25LocationReporting_42412 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡듣퓥\udde7ꛩ菫跭釯蛱鷳駵雷꣹駻軽濿瀁瀃漅昇洉匋㨍∏☑┓␕", a_), global::CommonResources.AcgResources.ID_P25LOCATIONREPORTING);
			this.radWideLocP25LocationReporting_42412.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideLocP25LocationReporting_42412.DataTransferOrder = 175;
			this.radWideLocationDisplayPeerLocation_42433 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫ꫭ駯臱蓳髵駷菹곻鯽旿瀁䠃椅欇欉砋服缏簑䬓∕⨗⸙⼛ⴝ", a_), global::CommonResources.AcgResources.ID_DISPLAYPEERLOCATION);
			this.radWideLocationDisplayPeerLocation_42433.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideLocationDisplayPeerLocation_42433.DataTransferOrder = 212;
			this.radioErgoConfigACMissionCriticalGeofenceMode_42918 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯뿱鷳藵请鏹鏻都䏿瀁洃爅愇椉洋戍圏眑笓瀕紗琙缛笝洟䴡䀣䌥眧ḩḫᜭį਱", a_), global::CommonResources.AcgResources.ID_GEOFENCEACTIONOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadioErgoConfigACMissionCriticalGeofenceMode_42918LovStrs);
			this.radioErgoConfigACMissionCriticalGeofenceMode_42918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACMissionCriticalGeofenceMode_42918.DataTransferOrder = 260;
			this.radWideLocationSystemManagedGeofence_43042 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鋝迟臡藣鋥臧藩苫뷭觯臱胳鏵闷럹鷻都懿攁愃戅伇漉挋栍甏簑眓猕䜗⸙⼛⸝ᐟအ", a_), global::CommonResources.AcgResources.ID_SYSTEMMANAGEDGEOFENCE);
			this.radWideLocationSystemManagedGeofence_43042.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideLocationSystemManagedGeofence_43042.DataTransferOrder = 261;
			this.radWideFeaturesMapping = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛飝藟菡郣鏥髧迩鿫ꏭ釯英蓳鿵雷鷹", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESMAPPING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesMappingLovStrs);
			this.radWideFeaturesMapping.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFeaturesMapping.DataTransferOrder = 176;
			this.radWideSmartMappingServerAssistedLocation = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛距跟菡難鋥ꗧ诩鳫黭駯鳱鏳ꗵ鷷裹諻鯽狿䌁眃甅愇礉砋欍琏帑笓甕礗渙甛焝丟", a_), global::CommonResources.AcgResources.ID_RADWIDESMARTMAPPINGSERVERASSISTEDLOCATION);
			this.radWideSmartMappingServerAssistedLocation.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideSmartMappingServerAssistedLocation.DataTransferOrder = 177;
			this.radWideReverseGeocodedLocationDisplayFormat = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛賝藟铡臣铥鯧迩꯫语鿯釱鯳鋵鷷黹냻釽揿持瀃漅朇搉䠋服挏我砓眕愗尙猛氝䴟䌡倣", a_), global::CommonResources.AcgResources.ID_RADWIDEREVERSEGEOCODEDLOCATIONDISPLAYFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideReverseGeocodedLocationDisplayFormatLovStrs);
			this.radWideReverseGeocodedLocationDisplayFormat.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideReverseGeocodedLocationDisplayFormat.DataTransferOrder = 178;
			this.radCfgLocationReporting = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓闕뻗뷙郛뇝菟菡郣迥蟧蓩뻫语胯鷱蛳苵釷铹鯻", a_), global::CommonResources.AcgResources.ID_LOCATION_REPORTING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadCfgLocationReportingLovStrs);
			this.radCfgLocationReporting.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radCfgLocationReporting.DataTransferOrder = 56;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳏뷑럓럕곗동돛냝", a_);
			base.Id = 10100;
			base.UIName = global::CommonResources.AcgResources.ID_LOCATION;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x0038A0E0 File Offset: 0x003882E0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1570635807;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radWideReverseGeocodedLocationDisplayFormat = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚远뫞韠蛢韤铦賨곪裬胮鋰鳲釴鋶鷸럺鋼鳾怀眂氄栆月伊搌簎愐缒琔渖弘琚漜爞䀠圢", a_), global::CommonResources.AcgResources.ID_RADWIDEREVERSEGEOCODEDLOCATIONDISPLAYFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideReverseGeocodedLocationDisplayFormatLovStrs);
					this.radWideReverseGeocodedLocationDisplayFormat.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideReverseGeocodedLocationDisplayFormat.DataTransferOrder = 178;
					num = (short)406388756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꧬ蛮苰蟲铴駶髸黺꣼釾栀眂娄䘆㠈㠊㴌㜎ℐ", a_)))
					{
						num = (short)42074121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_658;
				case 2:
					goto IL_6A7;
				case 3:
					goto IL_60D;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꧬ蛮苰菲駴零胸꯺飼髾猀伂樄搆栈缊搌怎缐䰒℔┖ⴘ⠚⸜", a_)))
					{
						num = (short)1181024271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A97;
				case 5:
					goto IL_3E4;
				case 6:
					this.radWideLocP25LocationReporting_42412 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠돢ퟤ틦ꗨ蓪軬軮藰髲髴駶꯸黺跼郾猀眂氄椆済吊㤌㴎┐−✔", a_), global::CommonResources.AcgResources.ID_P25LOCATIONREPORTING);
					this.radWideLocP25LocationReporting_42412.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideLocP25LocationReporting_42412.DataTransferOrder = 175;
					num = (short)31064072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚远뫞韠蛢韤铦賨곪裬胮鋰鳲釴鋶鷸럺鋼鳾怀眂氄栆月伊搌簎愐缒琔渖弘琚漜爞䀠圢", a_)))
					{
						num = (short)1118306304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE7;
				case 8:
					goto IL_B30;
				case 9:
					this.radWideLocationDistanceUnit_A13080 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꧬ蛮苰蟲铴駶髸黺꣼釾栀眂娄䘆㠈㠊㴌㜎ℐ", a_), global::CommonResources.AcgResources.ID_DISTANCEUNIT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLocationDistanceUnit_A13080LovStrs);
					this.radWideLocationDistanceUnit_A13080.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideLocationDistanceUnit_A13080.DataTransferOrder = 99;
					num = (short)1108213796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮볰髲蛴蓶郸铺鏼볾猀樂焄渆樈樊愌䠎琐簒猔爖眘砚砜刞丠䜢䀤砦ᴨᤪᐬḮर", a_)))
					{
						num = (short)1630076958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 11:
					num = (short)1831927825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪뻬雮苰蟲郴髶듸髺鏼黾昀昂愄䀆氈搊欌樎缐瀒瀔䠖ⴘ⠚ⴜ⬞ጠ", a_)))
					{
						num = (short)312606758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C31;
				case 13:
					goto IL_C31;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪꣬韮飰蟲맴飶髸髺觼雾渀洂䠄戆月縊戌愎䄐䜒䄔䠖堘⨚⸜⼞ᤠሢ", a_)))
					{
						num = (short)1078591528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A5;
				case 15:
					this.radWideLocationDisplayPeerLocation_42433 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꧬ蛮苰菲駴零胸꯺飼髾猀伂樄搆栈缊搌怎缐䰒℔┖ⴘ⠚⸜", a_), global::CommonResources.AcgResources.ID_DISPLAYPEERLOCATION);
					this.radWideLocationDisplayPeerLocation_42433.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideLocationDisplayPeerLocation_42433.DataTransferOrder = 212;
					num = (short)1131937843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꃬ軮觰ꃲ致飶诸黺駼돾渀怂搄猆怈搊挌崎琐戒怔爖樘漚渜䀞怠ᬢᄤဦᨨ", a_)))
					{
						num = (short)345767970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C3;
				case 17:
					if (producerFields != null)
					{
						num = (short)850853921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7E;
				case 18:
					goto IL_9F4;
				case 19:
					this.radWideSmartMappingServerAssistedLocation = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚軜닞胠釢釤ꫦ裨鯪鷬蛮鿰铲꛴鋶诸跺飼跾䀀瀂瘄渆稈缊栌欎崐簒瘔瘖洘爚爜焞", a_), global::CommonResources.AcgResources.ID_RADWIDESMARTMAPPINGSERVERASSISTEDLOCATION);
					this.radWideSmartMappingServerAssistedLocation.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideSmartMappingServerAssistedLocation.DataTransferOrder = 177;
					num = (short)839057410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
				{
					num = (short)606443671;
					short num3 = num;
					num = (short)1021941911;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A0;
					default:
						num = (short)1375010816;
						if (num != 0)
						{
						}
						goto IL_BE7;
					}
					break;
				}
				case 21:
					goto IL_293;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꧬ蛮苰菲駴零胸뷺鋼跾氀戂焄堆䠈㼊㰌㨎✐−", a_)))
					{
						num = (short)727777306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F4;
				case 23:
					this.gPSFailToneInterval_42329 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裎臐胒鏔뛖냘럚觜냞迠蛢곤触鷨軪鿬駮郰鿲ꫴ쏶쯸죺쿼웾", a_), global::CommonResources.AcgResources.ID_GPSFAILTONEINTERVALSEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 30);
					this.gPSFailToneInterval_42329.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.gPSFailToneInterval_42329.DataTransferOrder = 10;
					this.gPSFailToneInterval_42329.ShowHexValue = false;
					num = (short)1962672133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_9A5;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裎臐胒鏔뛖냘럚觜냞迠蛢곤触鷨軪鿬駮郰鿲ꫴ쏶쯸죺쿼웾", a_)))
					{
						num = (short)2048262167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E4;
				case 26:
					this.radWideLocationDisplayFormat_A41561 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideLocationDisplayFormat_A41561LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideLocationDisplayFormat_A41561LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꧬ蛮苰菲駴零胸뷺鋼跾氀戂焄堆䠈㼊㰌㨎✐−", a_), global::CommonResources.AcgResources.ID_LOCATIONDISPLAYFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLocationDisplayFormat_A41561LovStrs);
					this.radWideLocationDisplayFormat_A41561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideLocationDisplayFormat_A41561.DataTransferOrder = 55;
					num = (short)1172766738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_9A0;
				case 28:
					goto IL_14A;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꫬ鿮苰뻲髴鏶鳸ꓺ볼췾㌀㔂㜄〆", a_)))
					{
						num = (short)693370915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53D;
				case 30:
					this.radioErgoConfigACMissionCriticalGeofenceMode_42918 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮볰髲蛴蓶郸铺鏼볾猀樂焄渆樈樊愌䠎琐簒猔爖眘砚砜刞丠䜢䀤砦ᴨᤪᐬḮर", a_), global::CommonResources.AcgResources.ID_GEOFENCEACTIONOPERATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadioErgoConfigACMissionCriticalGeofenceMode_42918LovStrs);
					this.radioErgoConfigACMissionCriticalGeofenceMode_42918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACMissionCriticalGeofenceMode_42918.DataTransferOrder = 260;
					num = (short)1624440860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					num = (short)1075052545;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_124;
					}
					continue;
				case 32:
					goto IL_538;
				case 33:
					num = (short)751829029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.radWideLocationMaxStoredLocationRequests_A8473 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꃬ軮觰ꃲ致飶诸黺駼돾渀怂搄猆怈搊挌崎琐戒怔爖樘漚渜䀞怠ᬢᄤဦᨨ", a_), global::CommonResources.AcgResources.ID_MAXSTOREDLOCATIONREQUESTS);
					this.radWideLocationMaxStoredLocationRequests_A8473.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideLocationMaxStoredLocationRequests_A8473.DataTransferOrder = 109;
					this.radWideLocationMaxStoredLocationRequests_A8473.ShowHexValue = false;
					num = (short)987037746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					this.radWideLocationGpsMode_A22627 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꫬ鿮苰뻲髴鏶鳸ꓺ볼췾㌀㔂㜄〆", a_), global::CommonResources.AcgResources.ID_GPSMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLocationGpsMode_A22627LovStrs);
					this.radWideLocationGpsMode_A22627.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLocationGpsMode_A22627.DataTransferOrder = 9;
					num = (short)1506082859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_658;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꇬ胮鋰鋲致黶雸闺룼釾怀愂椄戆嘈䨊㔌㬎┐⬒", a_)))
					{
						num = (short)1816789039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				case 38:
					this.radWideLocationSystemManagedGeofence_43042 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪뻬雮苰蟲郴髶듸髺鏼黾昀昂愄䀆氈搊欌樎缐瀒瀔䠖ⴘ⠚ⴜ⬞ጠ", a_), global::CommonResources.AcgResources.ID_SYSTEMMANAGEDGEOFENCE);
					this.radWideLocationSystemManagedGeofence_43042.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideLocationSystemManagedGeofence_43042.DataTransferOrder = 261;
					num = (short)15073293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					this.radWideFeaturesMapping = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꃬ軮臰菲鳴駶黸", a_), global::CommonResources.AcgResources.ID_RADWIDEFEATURESMAPPING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesMappingLovStrs);
					this.radWideFeaturesMapping.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFeaturesMapping.DataTransferOrder = 176;
					num = (short)1577779227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					this.radWideLocationExitLocationMenuonPTT_A13081 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪꣬韮飰蟲맴飶髸髺觼雾渀洂䠄戆月縊戌愎䄐䜒䄔䠖堘⨚⸜⼞ᤠሢ", a_), global::CommonResources.AcgResources.ID_EXITLOCATIONMENUONPTT);
					this.radWideLocationExitLocationMenuonPTT_A13081.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideLocationExitLocationMenuonPTT_A13081.DataTransferOrder = 100;
					num = (short)1902313496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪룬鳮铰臲꛴鋶闸黺黼课怀愂椄戆䔈搊渌渎攐稒稔礖尘甚簜紞䴠䘢稤昦ဨᴪᴬᨮ", a_)))
					{
						num = (short)1868824621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_60D;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚鯜뫞胠韢郤闦賨飪ꃬ軮臰菲鳴駶黸", a_)))
					{
						num = (short)1354367015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_246;
				case 43:
				{
					num = (short)310378496;
					short num4 = num;
					goto IL_53D;
				}
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚軜닞胠釢釤ꫦ裨鯪鷬蛮鿰铲꛴鋶诸跺飼跾䀀瀂瘄渆稈缊栌欎崐簒瘔瘖洘爚爜焞", a_)))
					{
						num = (short)82247699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A7;
				case 45:
					this.radWideLocationUserSelectableLocationEnable_A9605 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪룬鳮铰臲꛴鋶闸黺黼课怀愂椄戆䔈搊渌渎攐稒稔礖尘甚簜紞䴠䘢稤昦ဨᴪᴬᨮ", a_), global::CommonResources.AcgResources.ID_USERSELECTABLELOCATIONENABLE);
					this.radWideLocationUserSelectableLocationEnable_A9605.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideLocationUserSelectableLocationEnable_A9605.DataTransferOrder = 95;
					num = (short)501612547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠돢ퟤ틦ꗨ蓪軬軮藰髲髴駶꯸黺跼郾猀眂氄椆済吊㤌㴎┐−✔", a_)))
					{
						num = (short)98631686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B30;
				case 47:
					this.radWideLocationLocationEnable_A8448 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚釜냞苠苢釤軦蛨藪ꇬ胮鋰鋲致黶雸闺룼釾怀愂椄戆嘈䨊㔌㬎┐⬒", a_), global::CommonResources.AcgResources.ID_LOCATIONENABLE);
					this.radWideLocationLocationEnable_A8448.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideLocationLocationEnable_A8448.DataTransferOrder = 7;
					num = (short)339410965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					this.radCfgLocationReporting = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒雔뇖뻘韚닜볞胠韢賤裦蟨맪裬鿮黰臲致黶韸鳺", a_), global::CommonResources.AcgResources.ID_LOCATION_REPORTING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadCfgLocationReportingLovStrs);
					this.radCfgLocationReporting.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radCfgLocationReporting.DataTransferOrder = 56;
					num = (short)1194262560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒雔뇖뻘韚닜볞胠韢賤裦蟨맪裬鿮黰臲致黶韸鳺", a_)))
					{
						num = (short)841941040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7E;
				case 50:
					goto IL_5C3;
				case 51:
					goto IL_A97;
				}
				IL_124:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)177995787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14A:
				num = (short)1951989772;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_246:
				num = (short)1270480940;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9A0:
				goto IL_246;
				IL_293:
				num = (short)1219428368;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E4:
				num = (short)1855651886;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_53D:
				num = (short)2100756502;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5C3:
				num = (short)762314793;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_60D:
				num = (short)1610153985;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_658:
				num = (short)997916686;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6A7:
				num = (short)1931280391;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9A5:
				num = (short)685637661;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9F4:
				num = (short)2124152857;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A97:
				num = (short)418578442;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B30:
				num = (short)1726283780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE7:
				num = (short)377946161;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C31:
				num = (short)1095827498;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_538:
			IL_C7E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菎뻐냒듔ꏖ냘듚돜", a_);
			base.Id = 10100;
			base.UIName = global::CommonResources.AcgResources.ID_LOCATION;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0038AD9C File Offset: 0x00388F9C
		public override void PopulateReferences()
		{
			short num = (short)42821167;
			short num2 = num;
			num = (short)932668975;
			switch (num2 == num)
			{
			}
			num = (short)1154744320;
			if (num != 0)
			{
			}
			num = (short)1133379585;
			if (num != 0)
			{
			}
			num = (short)2083979264;
			short num3 = num;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x0038AE48 File Offset: 0x00389048
		public override void DropReferences()
		{
			short num = (short)261488641;
			if (num != 0)
			{
			}
			num = (short)1808884601;
			short num2 = num;
			num = (short)1087398777;
			switch (num2 == num)
			{
			}
			num = (short)1450770432;
			if (num != 0)
			{
			}
			num = (short)1383989248;
			short num3 = num;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0038AEF0 File Offset: 0x003890F0
		public override void SetConstraints()
		{
			short num = (short)143291209;
			short num2 = num;
			num = (short)1228698441;
			switch (num2 == num)
			{
			}
			num = (short)1456865281;
			if (num != 0)
			{
			}
			num = (short)1289551872;
			if (num != 0)
			{
			}
			num = (short)570621952;
			short num3 = num;
			this.radWideLocationMaxStoredLocationRequests_A8473.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocEnIsEnabled);
			this.radWideLocationUserSelectableLocationEnable_A9605.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideLocationUserSelectableLocationEnable_A9605.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConUserSelectableLocationEnableIsValid);
			this.radWideLocationDistanceUnit_A13080.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideLocationExitLocationMenuonPTT_A13081.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideLocationGpsMode_A22627.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideLocationDisplayFormat_A41561.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocEnOrDisplayPeerLocationIsEnabled);
			this.gPSFailToneInterval_42329.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideLocP25LocationReporting_42412.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radioErgoConfigACMissionCriticalGeofenceMode_42918.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideLocationSystemManagedGeofence_43042.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSystemManagedGeofenceApplicable);
			this.radWideLocationSystemManagedGeofence_43042.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSystemManagedGeofenceValid);
			this.radWideFeaturesMapping.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideSmartMappingServerAssistedLocation.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideReverseGeocodedLocationDisplayFormat.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radCfgLocationReporting.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConLocationEnableIsEnabled);
			this.radWideFeaturesMapping.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForMappingMode);
			this.radWideReverseGeocodedLocationDisplayFormat.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForGeocodedLocationFormat);
			this.radCfgLocationReporting.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForSmartLocateReporting);
			this.radWideSmartMappingServerAssistedLocation.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConValidBasedOnLTEAndWifiEnableBitForServerAssistedLocation);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x0038B164 File Offset: 0x00389364
		public override void SetupDependencies()
		{
			short num = (short)1561637754;
			short num2 = num;
			num = (short)1857926010;
			switch (num2 == num)
			{
			}
			num = (short)1891762177;
			if (num != 0)
			{
			}
			num = (short)1776156672;
			if (num != 0)
			{
			}
			num = (short)1833762816;
			short num3 = num;
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocationMaxStoredLocationRequests_A8473);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocationUserSelectableLocationEnable_A9605);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.radWideLocationUserSelectableLocationEnable_A9605);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.radWideLocationUserSelectableLocationEnable_A9605);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocationDistanceUnit_A13080);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocationExitLocationMenuonPTT_A13081);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocationGpsMode_A22627);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocationDisplayFormat_A41561);
			this.radWideLocationDisplayPeerLocation_42433.AddDependentObject(this.radWideLocationDisplayFormat_A41561);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.gPSFailToneInterval_42329);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideLocP25LocationReporting_42412);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radioErgoConfigACMissionCriticalGeofenceMode_42918);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideFeaturesMapping);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideSmartMappingServerAssistedLocation);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radWideReverseGeocodedLocationDisplayFormat);
			this.radWideLocationLocationEnable_A8448.AddDependentObject(this.radCfgLocationReporting);
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0038B348 File Offset: 0x00389548
		public bool HasDiffs
		{
			get
			{
				short num = (short)1406317820;
				short num2 = num;
				num = (short)85112060;
				switch (num2 == num)
				{
				}
				num = (short)1329659905;
				if (num != 0)
				{
				}
				num = (short)98238464;
				if (num != 0)
				{
				}
				num = (short)527237120;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06003C9A RID: 15514 RVA: 0x0038B3F8 File Offset: 0x003895F8
		// (set) Token: 0x06003C9B RID: 15515 RVA: 0x0038B4AC File Offset: 0x003896AC
		public bool RadWideLocationLocationEnable_A8448Value
		{
			get
			{
				short num = (short)707198977;
				if (num != 0)
				{
				}
				num = (short)149109278;
				short num2 = num;
				num = (short)1455176222;
				switch (num2 == num)
				{
				}
				num = (short)1334247424;
				if (num != 0)
				{
				}
				num = (short)178192384;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.Value;
			}
			set
			{
				short num = (short)180222956;
				short num2 = num;
				num = (short)1200880620;
				switch (num2 == num)
				{
				}
				num = (short)948764673;
				if (num != 0)
				{
				}
				num = (short)2045837312;
				if (num != 0)
				{
				}
				num = (short)1346568192;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.Value = value;
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06003C9C RID: 15516 RVA: 0x0038B564 File Offset: 0x00389764
		public global::AcpBusinessLayer.AcpField<bool> RadWideLocationLocationEnable_A8448
		{
			get
			{
				short num = (short)48903471;
				short num2 = num;
				num = (short)814167343;
				switch (num2 == num)
				{
				}
				num = (short)616169473;
				if (num != 0)
				{
				}
				num = (short)52887552;
				if (num != 0)
				{
				}
				num = (short)785055744;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448;
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x0038B618 File Offset: 0x00389818
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x0038B6CC File Offset: 0x003898CC
		public bool RadWideLocationLocationEnable_A8448_UIValue
		{
			get
			{
				short num = (short)631055556;
				short num2 = num;
				num = (short)1024730308;
				switch (num2 == num)
				{
				}
				num = (short)85327873;
				if (num != 0)
				{
				}
				num = (short)755826688;
				if (num != 0)
				{
				}
				num = (short)1191051264;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.Value;
			}
			set
			{
				short num = (short)1591020634;
				short num2 = num;
				num = (short)484641882;
				switch (num2 == num)
				{
				}
				num = (short)763559937;
				if (num != 0)
				{
				}
				num = (short)1284505600;
				if (num != 0)
				{
				}
				num = (short)770048000;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.Value = value;
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x0038B784 File Offset: 0x00389984
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x0038B834 File Offset: 0x00389A34
		public bool RadWideLocationLocationEnable_A8448_Applicable
		{
			get
			{
				short num = (short)45211606;
				short num2 = num;
				num = (short)299556822;
				switch (num2 == num)
				{
				}
				num = (short)793706496;
				if (num != 0)
				{
				}
				num = (short)932315137;
				if (num != 0)
				{
				}
				num = (short)798294016;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.Applicable;
			}
			set
			{
				short num = (short)554881013;
				short num2 = num;
				num = (short)321834997;
				switch (num2 == num)
				{
				}
				num = (short)668794880;
				if (num != 0)
				{
				}
				num = (short)279248897;
				if (num != 0)
				{
				}
				num = (short)1958871040;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.Applicable = value;
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0038B8EC File Offset: 0x00389AEC
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x0038B9A0 File Offset: 0x00389BA0
		public bool RadWideLocationLocationEnable_A8448_Valid
		{
			get
			{
				short num = (short)1121622943;
				short num2 = num;
				num = (short)81632159;
				switch (num2 == num)
				{
				}
				num = (short)1144127488;
				if (num != 0)
				{
				}
				num = (short)1584267265;
				if (num != 0)
				{
				}
				num = (short)1648820224;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.Valid;
			}
			set
			{
				short num = (short)1847918593;
				if (num != 0)
				{
				}
				num = (short)278078562;
				short num2 = num;
				num = (short)1538335842;
				switch (num2 == num)
				{
				}
				num = (short)266928128;
				if (num != 0)
				{
				}
				num = (short)817299456;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.Valid = value;
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x0038BA58 File Offset: 0x00389C58
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x0038BB0C File Offset: 0x00389D0C
		public bool RadWideLocationLocationEnable_A8448_Visible
		{
			get
			{
				short num = (short)55421689;
				short num2 = num;
				num = (short)1024305913;
				switch (num2 == num)
				{
				}
				num = (short)669777921;
				if (num != 0)
				{
				}
				num = (short)16908288;
				if (num != 0)
				{
				}
				num = (short)560726016;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.Visible;
			}
			set
			{
				short num = (short)298844161;
				if (num != 0)
				{
				}
				num = (short)506764179;
				short num2 = num;
				num = (short)803445651;
				switch (num2 == num)
				{
				}
				num = (short)1783169024;
				if (num != 0)
				{
				}
				num = (short)1098448896;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.Visible = value;
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x0038BBC0 File Offset: 0x00389DC0
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x0038BC74 File Offset: 0x00389E74
		public bool RadWideLocationLocationEnable_A8448_Editable
		{
			get
			{
				short num = (short)399340342;
				short num2 = num;
				num = (short)368079670;
				switch (num2 == num)
				{
				}
				num = (short)1057882113;
				if (num != 0)
				{
				}
				num = (short)153157632;
				if (num != 0)
				{
				}
				num = (short)1438842880;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.Editable;
			}
			set
			{
				short num = (short)2048233025;
				short num2 = num;
				num = (short)351047233;
				switch (num2 == num)
				{
				}
				num = (short)2121334784;
				if (num != 0)
				{
				}
				num = (short)666763265;
				if (num != 0)
				{
				}
				num = (short)1208877056;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.Editable = value;
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x0038BD2C File Offset: 0x00389F2C
		internal string RadWideLocationLocationEnable_A8448_UILabel
		{
			get
			{
				short num = (short)1201194879;
				short num2 = num;
				num = (short)1388365695;
				switch (num2 == num)
				{
				}
				num = (short)1927151617;
				if (num != 0)
				{
				}
				num = (short)1570111488;
				if (num != 0)
				{
				}
				num = (short)1908342784;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.UIName;
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x0038BDE0 File Offset: 0x00389FE0
		// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x0038BE94 File Offset: 0x0038A094
		internal bool RadWideLocationLocationEnable_A8448_HiddenStatic
		{
			get
			{
				short num = (short)1166079475;
				short num2 = num;
				num = (short)1874851315;
				switch (num2 == num)
				{
				}
				num = (short)1340145665;
				if (num != 0)
				{
				}
				num = (short)537264128;
				if (num != 0)
				{
				}
				num = (short)1143275520;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.HiddenStatic;
			}
			set
			{
				short num = (short)1113279018;
				short num2 = num;
				num = (short)1156401706;
				switch (num2 == num)
				{
				}
				num = (short)877789185;
				if (num != 0)
				{
				}
				num = (short)489160704;
				if (num != 0)
				{
				}
				num = (short)1932328960;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.HiddenStatic = value;
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06003CAA RID: 15530 RVA: 0x0038BF4C File Offset: 0x0038A14C
		// (set) Token: 0x06003CAB RID: 15531 RVA: 0x0038C000 File Offset: 0x0038A200
		internal bool RadWideLocationLocationEnable_A8448_HiddenDynamic
		{
			get
			{
				short num = (short)1627568072;
				short num2 = num;
				num = (short)416266184;
				switch (num2 == num)
				{
				}
				num = (short)595460097;
				if (num != 0)
				{
				}
				num = (short)987037696;
				if (num != 0)
				{
				}
				num = (short)2092564480;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448.HiddenDynamic;
			}
			set
			{
				short num = (short)1483253425;
				short num2 = num;
				num = (short)1714005681;
				switch (num2 == num)
				{
				}
				num = (short)1811152897;
				if (num != 0)
				{
				}
				num = (short)885260288;
				if (num != 0)
				{
				}
				num = (short)2005598208;
				short num3 = num;
				this.radWideLocationLocationEnable_A8448.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x0038C0B4 File Offset: 0x0038A2B4
		public bool RadWideLocationLocationEnable_A8448_HasDiffs
		{
			get
			{
				short num = (short)1788245548;
				short num2 = num;
				num = (short)1006007852;
				switch (num2 == num)
				{
				}
				num = (short)977666048;
				if (num != 0)
				{
				}
				num = (short)1214316545;
				if (num != 0)
				{
				}
				num = (short)919535616;
				short num3 = num;
				return this.radWideLocationLocationEnable_A8448._HasDiffs;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x0038C168 File Offset: 0x0038A368
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x0038C21C File Offset: 0x0038A41C
		public int RadWideLocationMaxStoredLocationRequests_A8473Value
		{
			get
			{
				short num = (short)1689173920;
				short num2 = num;
				num = (short)1074839456;
				switch (num2 == num)
				{
				}
				num = (short)698089472;
				if (num != 0)
				{
				}
				num = (short)103677953;
				if (num != 0)
				{
				}
				num = (short)2008285184;
				short num3 = num;
				return this.radWideLocationMaxStoredLocationRequests_A8473.Value;
			}
			set
			{
				short num = (short)1229838795;
				short num2 = num;
				num = (short)853531083;
				switch (num2 == num)
				{
				}
				num = (short)1321795584;
				if (num != 0)
				{
				}
				num = (short)1127940097;
				if (num != 0)
				{
				}
				num = (short)1543503872;
				short num3 = num;
				this.radWideLocationMaxStoredLocationRequests_A8473.Value = value;
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x0038C2D4 File Offset: 0x0038A4D4
		public global::AcpBusinessLayer.AcpRangeField<int, int> RadWideLocationMaxStoredLocationRequests_A8473
		{
			get
			{
				short num = (short)1038970423;
				short num2 = num;
				num = (short)617836087;
				switch (num2 == num)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				num = (short)1505624064;
				if (num != 0)
				{
				}
				num = (short)527826944;
				short num3 = num;
				return this.radWideLocationMaxStoredLocationRequests_A8473;
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x0038C384 File Offset: 0x0038A584
		// (set) Token: 0x06003CB1 RID: 15537 RVA: 0x0038C438 File Offset: 0x0038A638
		public int RadWideLocationMaxStoredLocationRequests_A8473_UIValue
		{
			get
			{
				short num = (short)980454397;
				short num2 = num;
				num = (short)1652657149;
				switch (num2 == num)
				{
				}
				num = (short)2118189057;
				if (num != 0)
				{
				}
				num = (short)984154112;
				if (num != 0)
				{
				}
				num = (short)673775616;
				short num3 = num;
				return this.radWideLocationMaxStoredLocationRequests_A8473.UIValue;
			}
			set
			{
				short num = (short)238491379;
				short num2 = num;
				num = (short)345446131;
				switch (num2 == num)
				{
				}
				num = (short)873988096;
				if (num != 0)
				{
				}
				num = (short)20840449;
				if (num != 0)
				{
				}
				num = (short)1204420608;
				short num3 = num;
				this.radWideLocationMaxStoredLocationRequests_A8473.UIValue = value;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x0038C4EC File Offset: 0x0038A6EC
		// (set) Token: 0x06003CB3 RID: 15539 RVA: 0x0038C5A0 File Offset: 0x0038A7A0
		internal int RadWideLocationMaxStoredLocationRequests_A8473Min
		{
			get
			{
				short num = (short)1711801440;
				short num2 = num;
				num = (short)2028602464;
				switch (num2 == num)
				{
				}
				num = (short)2135752705;
				if (num != 0)
				{
				}
				num = (short)1542848512;
				if (num != 0)
				{
				}
				num = (short)1506279424;
				short num3 = num;
				return this.radWideLocationMaxStoredLocationRequests_A8473.Min;
			}
			set
			{
				short num = (short)1996292096;
				short num2 = num;
				num = (short)880869377;
				if (num != 0)
				{
				}
				num = (short)825732759;
				short num3 = num;
				num = (short)1836363415;
				switch (num3 == num)
				{
				}
				num = (short)763953152;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.Min = value;
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06003CB4 RID: 15540 RVA: 0x0038C654 File Offset: 0x0038A854
		// (set) Token: 0x06003CB5 RID: 15541 RVA: 0x0038C708 File Offset: 0x0038A908
		internal int RadWideLocationMaxStoredLocationRequests_A8473Max
		{
			get
			{
				short num = (short)871563264;
				short num2 = num;
				num = (short)1055330575;
				short num3 = num;
				num = (short)94966031;
				switch (num3 == num)
				{
				}
				num = (short)1495990273;
				if (num != 0)
				{
				}
				num = (short)1489567744;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.Max;
			}
			set
			{
				short num = (short)1252392960;
				short num2 = num;
				num = (short)457834497;
				if (num != 0)
				{
				}
				num = (short)1280958807;
				short num3 = num;
				num = (short)1790894423;
				switch (num3 == num)
				{
				}
				num = (short)829554688;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.Max = value;
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x0038C7BC File Offset: 0x0038A9BC
		// (set) Token: 0x06003CB7 RID: 15543 RVA: 0x0038C870 File Offset: 0x0038AA70
		internal int RadWideLocationMaxStoredLocationRequests_A8473Step
		{
			get
			{
				short num = (short)1350893568;
				short num2 = num;
				num = (short)890143340;
				short num3 = num;
				num = (short)1535804012;
				switch (num3 == num)
				{
				}
				num = (short)323026945;
				if (num != 0)
				{
				}
				num = (short)1570504704;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.StepSize;
			}
			set
			{
				short num = (short)1956970496;
				short num2 = num;
				num = (short)488795939;
				short num3 = num;
				num = (short)1644064547;
				switch (num3 == num)
				{
				}
				num = (short)650903553;
				if (num != 0)
				{
				}
				num = (short)1892352000;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.StepSize = value;
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x0038C924 File Offset: 0x0038AB24
		// (set) Token: 0x06003CB9 RID: 15545 RVA: 0x0038C9DC File Offset: 0x0038ABDC
		public bool RadWideLocationMaxStoredLocationRequests_A8473_Applicable
		{
			get
			{
				short num = (short)39845888;
				short num2 = num;
				num = (short)2111686045;
				short num3 = num;
				num = (short)711050653;
				switch (num3 == num)
				{
				}
				num = (short)691339264;
				if (num != 0)
				{
				}
				num = (short)1185218561;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.Applicable;
			}
			set
			{
				short num = (short)1854668800;
				short num2 = num;
				num = (short)2128454624;
				short num3 = num;
				num = (short)203203552;
				switch (num3 == num)
				{
				}
				num = (short)449576961;
				if (num != 0)
				{
				}
				num = (short)846594048;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.Applicable = value;
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06003CBA RID: 15546 RVA: 0x0038CA90 File Offset: 0x0038AC90
		// (set) Token: 0x06003CBB RID: 15547 RVA: 0x0038CB44 File Offset: 0x0038AD44
		public bool RadWideLocationMaxStoredLocationRequests_A8473_Valid
		{
			get
			{
				short num = (short)1160183808;
				short num2 = num;
				num = (short)63372334;
				short num3 = num;
				num = (short)396033070;
				switch (num3 == num)
				{
				}
				num = (short)877264897;
				if (num != 0)
				{
				}
				num = (short)575602688;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.Valid;
			}
			set
			{
				short num = (short)2121990144;
				short num2 = num;
				num = (short)1685040081;
				short num3 = num;
				num = (short)1991814097;
				switch (num3 == num)
				{
				}
				num = (short)1024131073;
				if (num != 0)
				{
				}
				num = (short)936443904;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.Valid = value;
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06003CBC RID: 15548 RVA: 0x0038CBFC File Offset: 0x0038ADFC
		// (set) Token: 0x06003CBD RID: 15549 RVA: 0x0038CCB4 File Offset: 0x0038AEB4
		public bool RadWideLocationMaxStoredLocationRequests_A8473_Visible
		{
			get
			{
				short num = (short)2047213568;
				short num2 = num;
				num = (short)1085014232;
				short num3 = num;
				num = (short)481820888;
				switch (num3 == num)
				{
				}
				num = (short)1775763457;
				if (num != 0)
				{
				}
				num = (short)125632512;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.Visible;
			}
			set
			{
				short num = (short)975699968;
				short num2 = num;
				num = (short)1080147018;
				short num3 = num;
				num = (short)335002698;
				switch (num3 == num)
				{
				}
				num = (short)494338049;
				if (num != 0)
				{
				}
				num = (short)896139264;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.Visible = value;
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06003CBE RID: 15550 RVA: 0x0038CD68 File Offset: 0x0038AF68
		// (set) Token: 0x06003CBF RID: 15551 RVA: 0x0038CE1C File Offset: 0x0038B01C
		public bool RadWideLocationMaxStoredLocationRequests_A8473_Editable
		{
			get
			{
				short num = (short)444727296;
				short num2 = num;
				num = (short)698209596;
				short num3 = num;
				num = (short)382063932;
				switch (num3 == num)
				{
				}
				num = (short)770048001;
				if (num != 0)
				{
				}
				num = (short)1157103616;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.Editable;
			}
			set
			{
				short num = (short)1307049984;
				short num2 = num;
				num = (short)369887627;
				short num3 = num;
				num = (short)830540171;
				switch (num3 == num)
				{
				}
				num = (short)820772865;
				if (num != 0)
				{
				}
				num = (short)136445952;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.Editable = value;
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x0038CED0 File Offset: 0x0038B0D0
		internal string RadWideLocationMaxStoredLocationRequests_A8473_UILabel
		{
			get
			{
				short num = (short)1270808576;
				short num2 = num;
				num = (short)735338879;
				short num3 = num;
				num = (short)1524523391;
				switch (num3 == num)
				{
				}
				num = (short)11468801;
				if (num != 0)
				{
				}
				num = (short)587399168;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.UIName;
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x0038CF88 File Offset: 0x0038B188
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x0038D03C File Offset: 0x0038B23C
		internal bool RadWideLocationMaxStoredLocationRequests_A8473_HiddenStatic
		{
			get
			{
				short num = (short)1090060288;
				short num2 = num;
				num = (short)354175985;
				short num3 = num;
				num = (short)230968305;
				switch (num3 == num)
				{
				}
				num = (short)2059272193;
				if (num != 0)
				{
				}
				num = (short)1930625024;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.HiddenStatic;
			}
			set
			{
				short num = (short)1168965632;
				short num2 = num;
				num = (short)1683484494;
				short num3 = num;
				num = (short)1434447694;
				switch (num3 == num)
				{
				}
				num = (short)1692729345;
				if (num != 0)
				{
				}
				num = (short)1656881152;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.HiddenStatic = value;
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x0038D0F4 File Offset: 0x0038B2F4
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x0038D1AC File Offset: 0x0038B3AC
		internal bool RadWideLocationMaxStoredLocationRequests_A8473_HiddenDynamic
		{
			get
			{
				short num = (short)1427898368;
				short num2 = num;
				num = (short)2113446724;
				short num3 = num;
				num = (short)1497342788;
				switch (num3 == num)
				{
				}
				num = (short)2019033089;
				if (num != 0)
				{
				}
				num = (short)1267400704;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473.HiddenDynamic;
			}
			set
			{
				short num = (short)168361984;
				short num2 = num;
				num = (short)797566529;
				short num3 = num;
				num = (short)423552577;
				switch (num3 == num)
				{
				}
				num = (short)1960378368;
				if (num != 0)
				{
				}
				num = (short)1185677313;
				if (num != 0)
				{
				}
				this.radWideLocationMaxStoredLocationRequests_A8473.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x0038D260 File Offset: 0x0038B460
		public bool RadWideLocationMaxStoredLocationRequests_A8473_HasDiffs
		{
			get
			{
				short num = (short)1802305536;
				short num2 = num;
				num = (short)153981023;
				short num3 = num;
				num = (short)1373999199;
				switch (num3 == num)
				{
				}
				num = (short)1928724481;
				if (num != 0)
				{
				}
				num = (short)1017446400;
				if (num != 0)
				{
				}
				return this.radWideLocationMaxStoredLocationRequests_A8473._HasDiffs;
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x0038D318 File Offset: 0x0038B518
		// (set) Token: 0x06003CC7 RID: 15559 RVA: 0x0038D3CC File Offset: 0x0038B5CC
		public bool RadWideLocationUserSelectableLocationEnable_A9605Value
		{
			get
			{
				short num = (short)1524498432;
				short num2 = num;
				num = (short)595390923;
				short num3 = num;
				num = (short)319549899;
				switch (num3 == num)
				{
				}
				num = (short)191561729;
				if (num != 0)
				{
				}
				num = (short)642711552;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.Value;
			}
			set
			{
				short num = (short)908197888;
				short num2 = num;
				num = (short)783137656;
				short num3 = num;
				num = (short)1408613240;
				switch (num3 == num)
				{
				}
				num = (short)169148416;
				if (num != 0)
				{
				}
				num = (short)668663809;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.Value = value;
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x0038D480 File Offset: 0x0038B680
		public global::AcpBusinessLayer.AcpField<bool> RadWideLocationUserSelectableLocationEnable_A9605
		{
			get
			{
				short num = (short)1362362368;
				short num2 = num;
				num = (short)952877583;
				short num3 = num;
				num = (short)1340260879;
				switch (num3 == num)
				{
				}
				num = (short)2049703936;
				if (num != 0)
				{
				}
				num = (short)929103873;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x0038D530 File Offset: 0x0038B730
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x0038D5E4 File Offset: 0x0038B7E4
		public bool RadWideLocationUserSelectableLocationEnable_A9605_UIValue
		{
			get
			{
				short num = (short)719912960;
				short num2 = num;
				num = (short)578669852;
				short num3 = num;
				num = (short)219270428;
				switch (num3 == num)
				{
				}
				num = (short)903348225;
				if (num != 0)
				{
				}
				num = (short)80805888;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.Value;
			}
			set
			{
				short num = (short)1754398720;
				short num2 = num;
				num = (short)1999991296;
				short num3 = num;
				num = (short)1703571968;
				switch (num3 == num)
				{
				}
				num = (short)1542127617;
				if (num != 0)
				{
				}
				num = (short)378863616;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.Value = value;
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x0038D69C File Offset: 0x0038B89C
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x0038D754 File Offset: 0x0038B954
		public bool RadWideLocationUserSelectableLocationEnable_A9605_Applicable
		{
			get
			{
				short num = (short)1384251392;
				short num2 = num;
				num = (short)422334060;
				short num3 = num;
				num = (short)2010074732;
				switch (num3 == num)
				{
				}
				num = (short)1330053121;
				if (num != 0)
				{
				}
				num = (short)1126498304;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.Applicable;
			}
			set
			{
				short num = (short)1072365568;
				short num2 = num;
				num = (short)643214951;
				short num3 = num;
				num = (short)1809952359;
				switch (num3 == num)
				{
				}
				num = (short)1669332993;
				if (num != 0)
				{
				}
				num = (short)617218048;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.Applicable = value;
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x0038D808 File Offset: 0x0038BA08
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x0038D8BC File Offset: 0x0038BABC
		public bool RadWideLocationUserSelectableLocationEnable_A9605_Valid
		{
			get
			{
				short num = (short)1584857088;
				short num2 = num;
				num = (short)1338227912;
				short num3 = num;
				num = (short)1155054792;
				switch (num3 == num)
				{
				}
				num = (short)1294794752;
				if (num != 0)
				{
				}
				num = (short)1883045889;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.Valid;
			}
			set
			{
				short num = (short)113639424;
				short num2 = num;
				num = (short)1655307549;
				short num3 = num;
				num = (short)361168157;
				switch (num3 == num)
				{
				}
				num = (short)341377025;
				if (num != 0)
				{
				}
				num = (short)1179385856;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.Valid = value;
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x0038D974 File Offset: 0x0038BB74
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x0038DA28 File Offset: 0x0038BC28
		public bool RadWideLocationUserSelectableLocationEnable_A9605_Visible
		{
			get
			{
				short num = (short)888209408;
				short num2 = num;
				num = (short)1978069978;
				short num3 = num;
				num = (short)700052442;
				switch (num3 == num)
				{
				}
				num = (short)2146172929;
				if (num != 0)
				{
				}
				num = (short)899416064;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.Visible;
			}
			set
			{
				short num = (short)684392448;
				short num2 = num;
				num = (short)1774181169;
				short num3 = num;
				num = (short)278780721;
				switch (num3 == num)
				{
				}
				num = (short)676462593;
				if (num != 0)
				{
				}
				num = (short)1170669568;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.Visible = value;
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x0038DAE0 File Offset: 0x0038BCE0
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x0038DB94 File Offset: 0x0038BD94
		public bool RadWideLocationUserSelectableLocationEnable_A9605_Editable
		{
			get
			{
				short num = (short)18808832;
				short num2 = num;
				num = (short)1762905063;
				short num3 = num;
				num = (short)126864359;
				switch (num3 == num)
				{
				}
				num = (short)1700134913;
				if (num != 0)
				{
				}
				num = (short)810942464;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.Editable;
			}
			set
			{
				short num = (short)177405952;
				short num2 = num;
				num = (short)1475411969;
				if (num != 0)
				{
				}
				num = (short)1402367982;
				short num3 = num;
				num = (short)1089564654;
				switch (num3 == num)
				{
				}
				num = (short)1109852160;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.Editable = value;
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x0038DC48 File Offset: 0x0038BE48
		internal string RadWideLocationUserSelectableLocationEnable_A9605_UILabel
		{
			get
			{
				short num = (short)2035023872;
				short num2 = num;
				num = (short)650780219;
				short num3 = num;
				num = (short)45227579;
				switch (num3 == num)
				{
				}
				num = (short)912654336;
				if (num != 0)
				{
				}
				num = (short)12451841;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.UIName;
			}
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x0038DCFC File Offset: 0x0038BEFC
		// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x0038DDB0 File Offset: 0x0038BFB0
		internal bool RadWideLocationUserSelectableLocationEnable_A9605_HiddenStatic
		{
			get
			{
				short num = (short)682164224;
				short num2 = num;
				num = (short)1521492068;
				short num3 = num;
				num = (short)2002919524;
				switch (num3 == num)
				{
				}
				num = (short)285278209;
				if (num != 0)
				{
				}
				num = (short)1055260672;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.HiddenStatic;
			}
			set
			{
				short num = (short)1510342656;
				short num2 = num;
				num = (short)1212505539;
				short num3 = num;
				num = (short)1002659267;
				switch (num3 == num)
				{
				}
				num = (short)1900019713;
				if (num != 0)
				{
				}
				num = (short)446103552;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.HiddenStatic = value;
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x0038DE68 File Offset: 0x0038C068
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x0038DF1C File Offset: 0x0038C11C
		internal bool RadWideLocationUserSelectableLocationEnable_A9605_HiddenDynamic
		{
			get
			{
				short num = (short)77922304;
				short num2 = num;
				num = (short)593350342;
				short num3 = num;
				num = (short)44551878;
				switch (num3 == num)
				{
				}
				num = (short)590282753;
				if (num != 0)
				{
				}
				num = (short)56164352;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605.HiddenDynamic;
			}
			set
			{
				short num = (short)1856897024;
				short num2 = num;
				num = (short)1159589533;
				short num3 = num;
				num = (short)2035347101;
				switch (num3 == num)
				{
				}
				num = (short)1971650560;
				if (num != 0)
				{
				}
				num = (short)1833697281;
				if (num != 0)
				{
				}
				this.radWideLocationUserSelectableLocationEnable_A9605.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x0038DFD0 File Offset: 0x0038C1D0
		public bool RadWideLocationUserSelectableLocationEnable_A9605_HasDiffs
		{
			get
			{
				short num = (short)850722816;
				short num2 = num;
				num = (short)1503402291;
				short num3 = num;
				num = (short)1067194675;
				switch (num3 == num)
				{
				}
				num = (short)805765121;
				if (num != 0)
				{
				}
				num = (short)1356070912;
				if (num != 0)
				{
				}
				return this.radWideLocationUserSelectableLocationEnable_A9605._HasDiffs;
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x0038E084 File Offset: 0x0038C284
		// (set) Token: 0x06003CDA RID: 15578 RVA: 0x0038E13C File Offset: 0x0038C33C
		public int RadWideLocationDistanceUnit_A13080Value
		{
			get
			{
				short num = (short)1031208960;
				short num2 = num;
				num = (short)1054127422;
				short num3 = num;
				num = (short)1057273150;
				switch (num3 == num)
				{
				}
				num = (short)2013986817;
				if (num != 0)
				{
				}
				num = (short)1179648;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.Value;
			}
			set
			{
				short num = (short)1286209536;
				short num2 = num;
				num = (short)1832772956;
				short num3 = num;
				num = (short)642639196;
				switch (num3 == num)
				{
				}
				num = (short)29687809;
				if (num != 0)
				{
				}
				num = (short)1425866752;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.Value = value;
			}
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x0038E1F0 File Offset: 0x0038C3F0
		// (set) Token: 0x06003CDC RID: 15580 RVA: 0x0038E2A8 File Offset: 0x0038C4A8
		public string RadWideLocationDistanceUnit_A13080_UIValue
		{
			get
			{
				short num = (short)351666176;
				short num2 = num;
				num = (short)471726002;
				short num3 = num;
				num = (short)798422962;
				switch (num3 == num)
				{
				}
				num = (short)945291264;
				if (num != 0)
				{
				}
				num = (short)44040193;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.UIValue;
			}
			set
			{
				short num = (short)847708160;
				short num2 = num;
				num = (short)795869185;
				if (num != 0)
				{
				}
				num = (short)1414887176;
				short num3 = num;
				num = (short)949581576;
				switch (num3 == num)
				{
				}
				num = (short)962199552;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.UIValue = value;
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x0038E35C File Offset: 0x0038C55C
		public global::AcpBusinessLayer.AcpListField RadWideLocationDistanceUnit_A13080
		{
			get
			{
				short num = (short)1438580736;
				short num2 = num;
				num = (short)1171055215;
				short num3 = num;
				num = (short)801563247;
				switch (num3 == num)
				{
				}
				num = (short)1842151425;
				if (num != 0)
				{
				}
				num = (short)1545142272;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080;
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x0038E408 File Offset: 0x0038C608
		// (set) Token: 0x06003CDF RID: 15583 RVA: 0x0038E4C0 File Offset: 0x0038C6C0
		public bool RadWideLocationDistanceUnit_A13080_Applicable
		{
			get
			{
				short num = (short)793903104;
				short num2 = num;
				num = (short)873776807;
				short num3 = num;
				num = (short)571131559;
				switch (num3 == num)
				{
				}
				num = (short)1492516864;
				if (num != 0)
				{
				}
				num = (short)2112159745;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.Applicable;
			}
			set
			{
				short num = (short)2621440;
				short num2 = num;
				num = (short)2060189697;
				if (num != 0)
				{
				}
				num = (short)1079654824;
				short num3 = num;
				num = (short)144456104;
				switch (num3 == num)
				{
				}
				num = (short)928710656;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.Applicable = value;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x0038E578 File Offset: 0x0038C778
		// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x0038E62C File Offset: 0x0038C82C
		public bool RadWideLocationDistanceUnit_A13080_Valid
		{
			get
			{
				short num = (short)840237056;
				short num2 = num;
				num = (short)1798701057;
				if (num != 0)
				{
				}
				num = (short)1558148334;
				short num3 = num;
				num = (short)1196258542;
				switch (num3 == num)
				{
				}
				num = (short)445120512;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.Valid;
			}
			set
			{
				short num = (short)1659502592;
				short num2 = num;
				num = (short)154578492;
				short num3 = num;
				num = (short)1169862204;
				switch (num3 == num)
				{
				}
				num = (short)1578762241;
				if (num != 0)
				{
				}
				num = (short)1155072000;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.Valid = value;
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x0038E6E4 File Offset: 0x0038C8E4
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x0038E798 File Offset: 0x0038C998
		public bool RadWideLocationDistanceUnit_A13080_Visible
		{
			get
			{
				short num = (short)2145255424;
				short num2 = num;
				num = (short)817448241;
				short num3 = num;
				num = (short)76367153;
				switch (num3 == num)
				{
				}
				num = (short)1428619264;
				if (num != 0)
				{
				}
				num = (short)197459969;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.Visible;
			}
			set
			{
				short num = (short)796196864;
				short num2 = num;
				num = (short)430123578;
				short num3 = num;
				num = (short)1094330938;
				switch (num3 == num)
				{
				}
				num = (short)1625489409;
				if (num != 0)
				{
				}
				num = (short)1622540288;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.Visible = value;
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x0038E84C File Offset: 0x0038CA4C
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x0038E900 File Offset: 0x0038CB00
		public bool RadWideLocationDistanceUnit_A13080_Editable
		{
			get
			{
				short num = (short)984612864;
				short num2 = num;
				num = (short)4182098;
				short num3 = num;
				num = (short)1727975506;
				switch (num3 == num)
				{
				}
				num = (short)863371265;
				if (num != 0)
				{
				}
				num = (short)1476788224;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.Editable;
			}
			set
			{
				short num = (short)138870784;
				short num2 = num;
				num = (short)391774209;
				if (num != 0)
				{
				}
				num = (short)1137260166;
				short num3 = num;
				num = (short)670119558;
				switch (num3 == num)
				{
				}
				num = (short)1696464896;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.Editable = value;
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x0038E9B4 File Offset: 0x0038CBB4
		internal string RadWideLocationDistanceUnit_A13080_UILabel
		{
			get
			{
				short num = (short)699596800;
				short num2 = num;
				num = (short)91129845;
				short num3 = num;
				num = (short)1934854133;
				switch (num3 == num)
				{
				}
				num = (short)1741029376;
				if (num != 0)
				{
				}
				num = (short)295895041;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.UIName;
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x0038EA68 File Offset: 0x0038CC68
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x0038EB1C File Offset: 0x0038CD1C
		internal bool RadWideLocationDistanceUnit_A13080_HiddenStatic
		{
			get
			{
				short num = (short)1042939904;
				short num2 = num;
				num = (short)119799809;
				if (num != 0)
				{
				}
				num = (short)777386910;
				short num3 = num;
				num = (short)1197538206;
				switch (num3 == num)
				{
				}
				num = (short)1378942976;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.HiddenStatic;
			}
			set
			{
				short num = (short)605093888;
				short num2 = num;
				num = (short)517940520;
				short num3 = num;
				num = (short)286467368;
				switch (num3 == num)
				{
				}
				num = (short)1087438849;
				if (num != 0)
				{
				}
				num = (short)368312320;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.HiddenStatic = value;
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x0038EBD0 File Offset: 0x0038CDD0
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x0038EC84 File Offset: 0x0038CE84
		internal bool RadWideLocationDistanceUnit_A13080_HiddenDynamic
		{
			get
			{
				short num = (short)905726184;
				short num2 = num;
				num = (short)780093672;
				switch (num2 == num)
				{
				}
				num = (short)1750859777;
				if (num != 0)
				{
				}
				num = (short)722272256;
				short num3 = num;
				num = (short)1644691456;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080.HiddenDynamic;
			}
			set
			{
				short num = (short)2087840904;
				short num2 = num;
				num = (short)103017608;
				switch (num2 == num)
				{
				}
				num = (short)1259732993;
				if (num != 0)
				{
				}
				num = (short)439681024;
				short num3 = num;
				num = (short)1358495744;
				if (num != 0)
				{
				}
				this.radWideLocationDistanceUnit_A13080.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x0038ED3C File Offset: 0x0038CF3C
		public bool RadWideLocationDistanceUnit_A13080_HasDiffs
		{
			get
			{
				short num = (short)555107315;
				short num2 = num;
				num = (short)1102005235;
				switch (num2 == num)
				{
				}
				num = (short)990576641;
				if (num != 0)
				{
				}
				num = (short)491192320;
				short num3 = num;
				num = (short)1242431488;
				if (num != 0)
				{
				}
				return this.radWideLocationDistanceUnit_A13080._HasDiffs;
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x0038EDF0 File Offset: 0x0038CFF0
		// (set) Token: 0x06003CED RID: 15597 RVA: 0x0038EEA4 File Offset: 0x0038D0A4
		public bool RadWideLocationExitLocationMenuonPTT_A13081Value
		{
			get
			{
				short num = (short)955608919;
				short num2 = num;
				num = (short)232812375;
				switch (num2 == num)
				{
				}
				num = (short)1692794880;
				if (num != 0)
				{
				}
				num = (short)1888354304;
				short num3 = num;
				num = (short)96993281;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.Value;
			}
			set
			{
				short num = (short)1136669695;
				short num2 = num;
				num = (short)964244479;
				switch (num2 == num)
				{
				}
				num = (short)2086273025;
				if (num != 0)
				{
				}
				num = (short)143654912;
				short num3 = num;
				num = (short)1185087488;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.Value = value;
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x0038EF58 File Offset: 0x0038D158
		public global::AcpBusinessLayer.AcpField<bool> RadWideLocationExitLocationMenuonPTT_A13081
		{
			get
			{
				short num = (short)584564923;
				short num2 = num;
				num = (short)1830142139;
				switch (num2 == num)
				{
				}
				num = (short)1413414913;
				if (num != 0)
				{
				}
				num = (short)983760896;
				short num3 = num;
				num = (short)701956096;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081;
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x0038F004 File Offset: 0x0038D204
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x0038F0BC File Offset: 0x0038D2BC
		public bool RadWideLocationExitLocationMenuonPTT_A13081_UIValue
		{
			get
			{
				short num = (short)2000881877;
				short num2 = num;
				num = (short)569706709;
				switch (num2 == num)
				{
				}
				num = (short)907804673;
				if (num != 0)
				{
				}
				num = (short)719192064;
				short num3 = num;
				num = (short)77266944;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.Value;
			}
			set
			{
				short num = (short)1175561923;
				short num2 = num;
				num = (short)1727375043;
				switch (num2 == num)
				{
				}
				num = (short)544604161;
				if (num != 0)
				{
				}
				num = (short)653131776;
				short num3 = num;
				num = (short)271056896;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.Value = value;
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x0038F174 File Offset: 0x0038D374
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x0038F22C File Offset: 0x0038D42C
		public bool RadWideLocationExitLocationMenuonPTT_A13081_Applicable
		{
			get
			{
				short num = (short)1239285761;
				if (num != 0)
				{
				}
				num = (short)559679571;
				short num2 = num;
				num = (short)698026067;
				switch (num2 == num)
				{
				}
				num = (short)2144862208;
				short num3 = num;
				num = (short)542638080;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.Applicable;
			}
			set
			{
				short num = (short)345767937;
				if (num != 0)
				{
				}
				num = (short)1460392096;
				short num2 = num;
				num = (short)1200345248;
				switch (num2 == num)
				{
				}
				num = (short)5111808;
				short num3 = num;
				num = (short)1049821184;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.Applicable = value;
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x0038F2E0 File Offset: 0x0038D4E0
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x0038F398 File Offset: 0x0038D598
		public bool RadWideLocationExitLocationMenuonPTT_A13081_Valid
		{
			get
			{
				short num = (short)763311344;
				short num2 = num;
				num = (short)278869232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)885522432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5046272;
				if (num != 0)
				{
				}
				num = (short)395444225;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.Valid;
			}
			set
			{
				short num = (short)164187227;
				short num2 = num;
				num = (short)28331099;
				switch (num2 == num)
				{
				}
				num = (short)242548736;
				short num3 = num;
				num = (short)1719271425;
				if (num != 0)
				{
				}
				num = (short)1200160768;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.Valid = value;
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x0038F450 File Offset: 0x0038D650
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x0038F508 File Offset: 0x0038D708
		public bool RadWideLocationExitLocationMenuonPTT_A13081_Visible
		{
			get
			{
				short num = (short)644396800;
				short num2 = num;
				num = (short)67483392;
				switch (num2 == num)
				{
				}
				num = (short)957218816;
				short num3 = num;
				num = (short)1084424192;
				if (num != 0)
				{
				}
				num = (short)210370561;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.Visible;
			}
			set
			{
				short num = (short)149291009;
				if (num != 0)
				{
				}
				num = (short)1529080103;
				short num2 = num;
				num = (short)1933633831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1883373568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300496384;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.Visible = value;
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x0038F5C0 File Offset: 0x0038D7C0
		// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x0038F674 File Offset: 0x0038D874
		public bool RadWideLocationExitLocationMenuonPTT_A13081_Editable
		{
			get
			{
				short num = (short)244974524;
				short num2 = num;
				num = (short)1023148988;
				switch (num2 == num)
				{
				}
				num = (short)1710751744;
				short num3 = num;
				num = (short)2032271361;
				if (num != 0)
				{
				}
				num = (short)540475392;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.Editable;
			}
			set
			{
				short num = (short)931822891;
				short num2 = num;
				num = (short)833191211;
				switch (num2 == num)
				{
				}
				num = (short)1257308160;
				short num3 = num;
				num = (short)947978240;
				if (num != 0)
				{
				}
				num = (short)418971649;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.Editable = value;
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x0038F728 File Offset: 0x0038D928
		internal string RadWideLocationExitLocationMenuonPTT_A13081_UILabel
		{
			get
			{
				short num = (short)510525616;
				short num2 = num;
				num = (short)598147248;
				switch (num2 == num)
				{
				}
				num = (short)2089943040;
				short num3 = num;
				num = (short)695664641;
				if (num != 0)
				{
				}
				num = (short)1026097152;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.UIName;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06003CFA RID: 15610 RVA: 0x0038F7DC File Offset: 0x0038D9DC
		// (set) Token: 0x06003CFB RID: 15611 RVA: 0x0038F890 File Offset: 0x0038DA90
		internal bool RadWideLocationExitLocationMenuonPTT_A13081_HiddenStatic
		{
			get
			{
				short num = (short)1531283985;
				short num2 = num;
				num = (short)1046645265;
				switch (num2 == num)
				{
				}
				num = (short)1420820480;
				short num3 = num;
				num = (short)2063663105;
				if (num != 0)
				{
				}
				num = (short)1139212288;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.HiddenStatic;
			}
			set
			{
				short num = (short)1445277954;
				short num2 = num;
				num = (short)318648578;
				switch (num2 == num)
				{
				}
				num = (short)1780350976;
				short num3 = num;
				num = (short)1000734721;
				if (num != 0)
				{
				}
				num = (short)1468399616;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.HiddenStatic = value;
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x0038F944 File Offset: 0x0038DB44
		// (set) Token: 0x06003CFD RID: 15613 RVA: 0x0038F9F8 File Offset: 0x0038DBF8
		internal bool RadWideLocationExitLocationMenuonPTT_A13081_HiddenDynamic
		{
			get
			{
				short num = (short)1862642435;
				short num2 = num;
				num = (short)36612867;
				switch (num2 == num)
				{
				}
				num = (short)816381952;
				short num3 = num;
				num = (short)1722613761;
				if (num != 0)
				{
				}
				num = (short)1921646592;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081.HiddenDynamic;
			}
			set
			{
				short num = (short)718338584;
				short num2 = num;
				num = (short)281279000;
				switch (num2 == num)
				{
				}
				num = (short)443088896;
				short num3 = num;
				num = (short)754450433;
				if (num != 0)
				{
				}
				num = (short)1447690240;
				if (num != 0)
				{
				}
				this.radWideLocationExitLocationMenuonPTT_A13081.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x0038FAB0 File Offset: 0x0038DCB0
		public bool RadWideLocationExitLocationMenuonPTT_A13081_HasDiffs
		{
			get
			{
				short num = (short)1752122480;
				short num2 = num;
				num = (short)1840333936;
				switch (num2 == num)
				{
				}
				num = (short)1445068800;
				short num3 = num;
				num = (short)621674496;
				if (num != 0)
				{
				}
				num = (short)1485373441;
				if (num != 0)
				{
				}
				return this.radWideLocationExitLocationMenuonPTT_A13081._HasDiffs;
			}
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x0038FB64 File Offset: 0x0038DD64
		// (set) Token: 0x06003D00 RID: 15616 RVA: 0x0038FC18 File Offset: 0x0038DE18
		public int RadWideLocationGpsMode_A22627Value
		{
			get
			{
				short num = (short)902553503;
				short num2 = num;
				num = (short)158719903;
				switch (num2 == num)
				{
				}
				num = (short)1840644096;
				short num3 = num;
				num = (short)1709375488;
				if (num != 0)
				{
				}
				num = (short)916520961;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.Value;
			}
			set
			{
				short num = (short)1528039029;
				short num2 = num;
				num = (short)1320093301;
				switch (num2 == num)
				{
				}
				num = (short)844431360;
				short num3 = num;
				num = (short)519503873;
				if (num != 0)
				{
				}
				num = (short)1177223168;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.Value = value;
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x0038FCCC File Offset: 0x0038DECC
		// (set) Token: 0x06003D02 RID: 15618 RVA: 0x0038FD84 File Offset: 0x0038DF84
		public string RadWideLocationGpsMode_A22627_UIValue
		{
			get
			{
				short num = (short)313473111;
				short num2 = num;
				num = (short)310720599;
				switch (num2 == num)
				{
				}
				num = (short)1765015552;
				short num3 = num;
				num = (short)1113194497;
				if (num != 0)
				{
				}
				num = (short)1716715520;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.UIValue;
			}
			set
			{
				short num = (short)1229445502;
				short num2 = num;
				num = (short)2091768190;
				switch (num2 == num)
				{
				}
				num = (short)520749056;
				short num3 = num;
				num = (short)227803137;
				if (num != 0)
				{
				}
				num = (short)1717698560;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.UIValue = value;
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x0038FE3C File Offset: 0x0038E03C
		public global::AcpBusinessLayer.AcpListField RadWideLocationGpsMode_A22627
		{
			get
			{
				short num = (short)183369771;
				short num2 = num;
				num = (short)1411252267;
				switch (num2 == num)
				{
				}
				num = (short)904134656;
				short num3 = num;
				num = (short)285147136;
				if (num != 0)
				{
				}
				num = (short)1721237505;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627;
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x0038FEEC File Offset: 0x0038E0EC
		// (set) Token: 0x06003D05 RID: 15621 RVA: 0x0038FFA4 File Offset: 0x0038E1A4
		public bool RadWideLocationGpsMode_A22627_Applicable
		{
			get
			{
				short num = (short)194541462;
				short num2 = num;
				num = (short)1053587350;
				switch (num2 == num)
				{
				}
				num = (short)1982922752;
				short num3 = num;
				num = (short)1553661952;
				if (num != 0)
				{
				}
				num = (short)546897921;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.Applicable;
			}
			set
			{
				short num = (short)2125714146;
				short num2 = num;
				num = (short)1951322850;
				switch (num2 == num)
				{
				}
				num = (short)471859200;
				short num3 = num;
				num = (short)290652160;
				if (num != 0)
				{
				}
				num = (short)488505345;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.Applicable = value;
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x0039005C File Offset: 0x0038E25C
		// (set) Token: 0x06003D07 RID: 15623 RVA: 0x00390110 File Offset: 0x0038E310
		public bool RadWideLocationGpsMode_A22627_Valid
		{
			get
			{
				short num = (short)352452609;
				if (num != 0)
				{
				}
				num = (short)1789207432;
				short num2 = num;
				num = (short)1316234120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)453050368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937426944;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.Valid;
			}
			set
			{
				short num = (short)92644522;
				short num2 = num;
				num = (short)9151658;
				switch (num2 == num)
				{
				}
				num = (short)1767374848;
				short num3 = num;
				num = (short)1497694209;
				if (num != 0)
				{
				}
				num = (short)582287360;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.Valid = value;
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x003901C8 File Offset: 0x0038E3C8
		// (set) Token: 0x06003D09 RID: 15625 RVA: 0x0039027C File Offset: 0x0038E47C
		public bool RadWideLocationGpsMode_A22627_Visible
		{
			get
			{
				short num = (short)1510687729;
				short num2 = num;
				num = (short)1617839089;
				switch (num2 == num)
				{
				}
				num = (short)2082930688;
				short num3 = num;
				num = (short)210501633;
				if (num != 0)
				{
				}
				num = (short)539099136;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.Visible;
			}
			set
			{
				short num = (short)2139619329;
				if (num != 0)
				{
				}
				num = (short)1596814416;
				short num2 = num;
				num = (short)2045408336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817758208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1552809984;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.Visible = value;
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x00390334 File Offset: 0x0038E534
		// (set) Token: 0x06003D0B RID: 15627 RVA: 0x003903E8 File Offset: 0x0038E5E8
		public bool RadWideLocationGpsMode_A22627_Editable
		{
			get
			{
				short num = (short)2114189587;
				short num2 = num;
				num = (short)1861024019;
				switch (num2 == num)
				{
				}
				num = (short)191430656;
				short num3 = num;
				num = (short)2058747905;
				if (num != 0)
				{
				}
				num = (short)1910964224;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.Editable;
			}
			set
			{
				short num = (short)52811644;
				short num2 = num;
				num = (short)598005628;
				switch (num2 == num)
				{
				}
				num = (short)1207566336;
				short num3 = num;
				num = (short)269549568;
				if (num != 0)
				{
				}
				num = (short)431751169;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.Editable = value;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06003D0C RID: 15628 RVA: 0x003904A0 File Offset: 0x0038E6A0
		internal string RadWideLocationGpsMode_A22627_UILabel
		{
			get
			{
				short num = (short)852062522;
				short num2 = num;
				num = (short)508653882;
				switch (num2 == num)
				{
				}
				num = (short)1890582528;
				short num3 = num;
				num = (short)1489371137;
				if (num != 0)
				{
				}
				num = (short)647954432;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.UIName;
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x00390554 File Offset: 0x0038E754
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x00390608 File Offset: 0x0038E808
		internal bool RadWideLocationGpsMode_A22627_HiddenStatic
		{
			get
			{
				short num = (short)2090139649;
				if (num != 0)
				{
				}
				num = (short)13142739;
				short num2 = num;
				num = (short)550079187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1420754944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)631832576;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.HiddenStatic;
			}
			set
			{
				short num = (short)1600552774;
				short num2 = num;
				num = (short)2054913862;
				switch (num2 == num)
				{
				}
				num = (short)1140916224;
				short num3 = num;
				num = (short)1036124160;
				if (num != 0)
				{
				}
				num = (short)882049025;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.HiddenStatic = value;
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x003906BC File Offset: 0x0038E8BC
		// (set) Token: 0x06003D10 RID: 15632 RVA: 0x00390770 File Offset: 0x0038E970
		internal bool RadWideLocationGpsMode_A22627_HiddenDynamic
		{
			get
			{
				short num = (short)1370088755;
				short num2 = num;
				num = (short)1615455539;
				switch (num2 == num)
				{
				}
				num = (short)544800768;
				short num3 = num;
				num = (short)70713344;
				if (num != 0)
				{
				}
				num = (short)402915329;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627.HiddenDynamic;
			}
			set
			{
				short num = (short)456389762;
				short num2 = num;
				num = (short)1270150274;
				switch (num2 == num)
				{
				}
				num = (short)1573322752;
				short num3 = num;
				num = (short)227934208;
				if (num != 0)
				{
				}
				num = (short)2009333761;
				if (num != 0)
				{
				}
				this.radWideLocationGpsMode_A22627.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x00390824 File Offset: 0x0038EA24
		public bool RadWideLocationGpsMode_A22627_HasDiffs
		{
			get
			{
				short num = (short)1555029127;
				short num2 = num;
				num = (short)1469242503;
				switch (num2 == num)
				{
				}
				num = (short)1579155456;
				short num3 = num;
				num = (short)932708353;
				if (num != 0)
				{
				}
				num = (short)897646592;
				if (num != 0)
				{
				}
				return this.radWideLocationGpsMode_A22627._HasDiffs;
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06003D12 RID: 15634 RVA: 0x003908D8 File Offset: 0x0038EAD8
		// (set) Token: 0x06003D13 RID: 15635 RVA: 0x0039098C File Offset: 0x0038EB8C
		public int RadWideLocationDisplayFormat_A41561Value
		{
			get
			{
				short num = (short)901271791;
				short num2 = num;
				num = (short)1382437103;
				switch (num2 == num)
				{
				}
				num = (short)46989312;
				short num3 = num;
				num = (short)1658781697;
				if (num != 0)
				{
				}
				num = (short)1004929024;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.Value;
			}
			set
			{
				short num = (short)798162945;
				if (num != 0)
				{
				}
				num = (short)1270247092;
				short num2 = num;
				num = (short)1176202932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1991835648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)918945792;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.Value = value;
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x00390A40 File Offset: 0x0038EC40
		// (set) Token: 0x06003D15 RID: 15637 RVA: 0x00390AF8 File Offset: 0x0038ECF8
		public string RadWideLocationDisplayFormat_A41561_UIValue
		{
			get
			{
				short num = (short)1004933583;
				short num2 = num;
				num = (short)1620054479;
				switch (num2 == num)
				{
				}
				num = (short)414515200;
				short num3 = num;
				num = (short)1189609473;
				if (num != 0)
				{
				}
				num = (short)2077556736;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.UIValue;
			}
			set
			{
				short num = (short)1819672577;
				if (num != 0)
				{
				}
				num = (short)1826853302;
				short num2 = num;
				num = (short)516329910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131427328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536229376;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.UIValue = value;
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x00390BB0 File Offset: 0x0038EDB0
		public global::AcpBusinessLayer.AcpListField RadWideLocationDisplayFormat_A41561
		{
			get
			{
				short num = (short)344714572;
				short num2 = num;
				num = (short)1868426572;
				switch (num2 == num)
				{
				}
				num = (short)538312704;
				short num3 = num;
				num = (short)726794241;
				if (num != 0)
				{
				}
				num = (short)203358208;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561;
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00390C60 File Offset: 0x0038EE60
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x00390D10 File Offset: 0x0038EF10
		public bool RadWideLocationDisplayFormat_A41561_Applicable
		{
			get
			{
				short num = (short)1024769517;
				short num2 = num;
				num = (short)1477230061;
				switch (num2 == num)
				{
				}
				num = (short)1096744960;
				short num3 = num;
				num = (short)1921056769;
				if (num != 0)
				{
				}
				num = (short)485818368;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.Applicable;
			}
			set
			{
				short num = (short)729335061;
				short num2 = num;
				num = (short)464307477;
				switch (num2 == num)
				{
				}
				num = (short)1134821376;
				short num3 = num;
				num = (short)339673089;
				if (num != 0)
				{
				}
				num = (short)769261568;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.Applicable = value;
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00390DC4 File Offset: 0x0038EFC4
		// (set) Token: 0x06003D1A RID: 15642 RVA: 0x00390E78 File Offset: 0x0038F078
		public bool RadWideLocationDisplayFormat_A41561_Valid
		{
			get
			{
				short num = (short)1233600885;
				short num2 = num;
				num = (short)1300185461;
				switch (num2 == num)
				{
				}
				num = (short)1620377600;
				short num3 = num;
				num = (short)2112552961;
				if (num != 0)
				{
				}
				num = (short)781778944;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.Valid;
			}
			set
			{
				short num = (short)1253158159;
				short num2 = num;
				num = (short)1871031567;
				switch (num2 == num)
				{
				}
				num = (short)2016673792;
				short num3 = num;
				num = (short)2114387968;
				if (num != 0)
				{
				}
				num = (short)1559822337;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.Valid = value;
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x00390F30 File Offset: 0x0038F130
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x00390FE8 File Offset: 0x0038F1E8
		public bool RadWideLocationDisplayFormat_A41561_Visible
		{
			get
			{
				short num = (short)854314913;
				short num2 = num;
				num = (short)871681953;
				switch (num2 == num)
				{
				}
				num = (short)1942421504;
				short num3 = num;
				num = (short)1309409280;
				if (num != 0)
				{
				}
				num = (short)1077805057;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.Visible;
			}
			set
			{
				short num = (short)1330359413;
				short num2 = num;
				num = (short)1248242805;
				switch (num2 == num)
				{
				}
				num = (short)1976303616;
				short num3 = num;
				num = (short)895156224;
				if (num != 0)
				{
				}
				num = (short)946995201;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.Visible = value;
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x0039109C File Offset: 0x0038F29C
		// (set) Token: 0x06003D1E RID: 15646 RVA: 0x00391150 File Offset: 0x0038F350
		public bool RadWideLocationDisplayFormat_A41561_Editable
		{
			get
			{
				short num = (short)140728051;
				short num2 = num;
				num = (short)2053592819;
				switch (num2 == num)
				{
				}
				num = (short)343867392;
				short num3 = num;
				num = (short)1522991105;
				if (num != 0)
				{
				}
				num = (short)1508573184;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.Editable;
			}
			set
			{
				short num = (short)1160073371;
				short num2 = num;
				num = (short)1767526555;
				switch (num2 == num)
				{
				}
				num = (short)596312064;
				short num3 = num;
				num = (short)391643137;
				if (num != 0)
				{
				}
				num = (short)1593180160;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.Editable = value;
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x00391204 File Offset: 0x0038F404
		internal string RadWideLocationDisplayFormat_A41561_UILabel
		{
			get
			{
				short num = (short)873540367;
				short num2 = num;
				num = (short)859712271;
				switch (num2 == num)
				{
				}
				num = (short)954793984;
				short num3 = num;
				num = (short)1345650689;
				if (num != 0)
				{
				}
				num = (short)1124401152;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.UIName;
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x003912B8 File Offset: 0x0038F4B8
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x0039136C File Offset: 0x0038F56C
		internal bool RadWideLocationDisplayFormat_A41561_HiddenStatic
		{
			get
			{
				short num = (short)1291060343;
				short num2 = num;
				num = (short)1636893815;
				switch (num2 == num)
				{
				}
				num = (short)1157627904;
				short num3 = num;
				num = (short)626589697;
				if (num != 0)
				{
				}
				num = (short)757465088;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.HiddenStatic;
			}
			set
			{
				short num = (short)298126569;
				short num2 = num;
				num = (short)1944194281;
				switch (num2 == num)
				{
				}
				num = (short)1685979136;
				short num3 = num;
				num = (short)257097729;
				if (num != 0)
				{
				}
				num = (short)1659895808;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.HiddenStatic = value;
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x00391420 File Offset: 0x0038F620
		// (set) Token: 0x06003D23 RID: 15651 RVA: 0x003914D4 File Offset: 0x0038F6D4
		internal bool RadWideLocationDisplayFormat_A41561_HiddenDynamic
		{
			get
			{
				short num = (short)1743076734;
				short num2 = num;
				num = (short)1366441342;
				switch (num2 == num)
				{
				}
				num = (short)495386624;
				short num3 = num;
				num = (short)174194688;
				if (num != 0)
				{
				}
				num = (short)345112577;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561.HiddenDynamic;
			}
			set
			{
				short num = (short)1168258815;
				short num2 = num;
				num = (short)782644991;
				switch (num2 == num)
				{
				}
				num = (short)1244135424;
				short num3 = num;
				num = (short)226033664;
				if (num != 0)
				{
				}
				num = (short)1370816513;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayFormat_A41561.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x0039158C File Offset: 0x0038F78C
		public bool RadWideLocationDisplayFormat_A41561_HasDiffs
		{
			get
			{
				short num = (short)1187708928;
				short num2 = num;
				num = (short)94830593;
				if (num != 0)
				{
				}
				num = (short)857627265;
				short num3 = num;
				num = (short)1277254273;
				switch (num3 == num)
				{
				}
				num = (short)1681981440;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayFormat_A41561._HasDiffs;
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x00391640 File Offset: 0x0038F840
		// (set) Token: 0x06003D26 RID: 15654 RVA: 0x003916F4 File Offset: 0x0038F8F4
		public int GPSFailToneInterval_42329Value
		{
			get
			{
				short num = (short)779812864;
				short num2 = num;
				num = (short)307871888;
				short num3 = num;
				num = (short)1554694288;
				switch (num3 == num)
				{
				}
				num = (short)321978369;
				if (num != 0)
				{
				}
				num = (short)1781661696;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Value;
			}
			set
			{
				short num = (short)55640064;
				short num2 = num;
				num = (short)1884262719;
				short num3 = num;
				num = (short)1777373503;
				switch (num3 == num)
				{
				}
				num = (short)877592577;
				if (num != 0)
				{
				}
				num = (short)1288110080;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Value = value;
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x003917A8 File Offset: 0x0038F9A8
		public global::AcpBusinessLayer.AcpSimpleRangeField GPSFailToneInterval_42329
		{
			get
			{
				short num = (short)1715339264;
				short num2 = num;
				num = (short)69391328;
				short num3 = num;
				num = (short)341562336;
				switch (num3 == num)
				{
				}
				num = (short)57409536;
				if (num != 0)
				{
				}
				num = (short)1905524737;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329;
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x00391858 File Offset: 0x0038FA58
		// (set) Token: 0x06003D29 RID: 15657 RVA: 0x0039190C File Offset: 0x0038FB0C
		public string GPSFailToneInterval_42329_UIValue
		{
			get
			{
				short num = (short)1564475392;
				short num2 = num;
				num = (short)1172890826;
				short num3 = num;
				num = (short)703194314;
				switch (num3 == num)
				{
				}
				num = (short)1979645952;
				if (num != 0)
				{
				}
				num = (short)164495361;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.UIValue;
			}
			set
			{
				short num = (short)1108213760;
				short num2 = num;
				num = (short)1120873461;
				short num3 = num;
				num = (short)415443957;
				switch (num3 == num)
				{
				}
				num = (short)1915027457;
				if (num != 0)
				{
				}
				num = (short)1606680576;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.UIValue = value;
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x003919C8 File Offset: 0x0038FBC8
		// (set) Token: 0x06003D2B RID: 15659 RVA: 0x00391A7C File Offset: 0x0038FC7C
		internal int GPSFailToneInterval_42329Min
		{
			get
			{
				short num = (short)660078592;
				short num2 = num;
				num = (short)316141823;
				short num3 = num;
				num = (short)1101525247;
				switch (num3 == num)
				{
				}
				num = (short)1292632065;
				if (num != 0)
				{
				}
				num = (short)1529675776;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Min;
			}
			set
			{
				short num = (short)1176698880;
				short num2 = num;
				num = (short)1140971531;
				short num3 = num;
				num = (short)1824577547;
				switch (num3 == num)
				{
				}
				num = (short)2014576641;
				if (num != 0)
				{
				}
				num = (short)807272448;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Min = value;
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x00391B34 File Offset: 0x0038FD34
		// (set) Token: 0x06003D2D RID: 15661 RVA: 0x00391BE8 File Offset: 0x0038FDE8
		internal int GPSFailToneInterval_42329Max
		{
			get
			{
				short num = (short)281280512;
				short num2 = num;
				num = (short)2104671725;
				short num3 = num;
				num = (short)1208008173;
				switch (num3 == num)
				{
				}
				num = (short)1435041793;
				if (num != 0)
				{
				}
				num = (short)1186922496;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Max;
			}
			set
			{
				short num = (short)1124073472;
				short num2 = num;
				num = (short)401932289;
				if (num != 0)
				{
				}
				num = (short)1792086442;
				short num3 = num;
				num = (short)1848316330;
				switch (num3 == num)
				{
				}
				num = (short)812253184;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Max = value;
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x00391CA0 File Offset: 0x0038FEA0
		// (set) Token: 0x06003D2F RID: 15663 RVA: 0x00391D54 File Offset: 0x0038FF54
		internal int GPSFailToneInterval_42329Step
		{
			get
			{
				short num = (short)753205248;
				short num2 = num;
				num = (short)1797558914;
				short num3 = num;
				num = (short)1605866114;
				switch (num3 == num)
				{
				}
				num = (short)1801584640;
				if (num != 0)
				{
				}
				num = (short)1949564929;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.StepSize;
			}
			set
			{
				short num = (short)244449280;
				short num2 = num;
				num = (short)1424290392;
				short num3 = num;
				num = (short)631829080;
				switch (num3 == num)
				{
				}
				num = (short)1063976960;
				if (num != 0)
				{
				}
				num = (short)486735873;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.StepSize = value;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06003D30 RID: 15664 RVA: 0x00391E0C File Offset: 0x0039000C
		// (set) Token: 0x06003D31 RID: 15665 RVA: 0x00391EC0 File Offset: 0x003900C0
		public bool GPSFailToneInterval_42329_Applicable
		{
			get
			{
				short num = (short)836108288;
				short num2 = num;
				num = (short)936214890;
				short num3 = num;
				num = (short)868712810;
				switch (num3 == num)
				{
				}
				num = (short)1689124864;
				if (num != 0)
				{
				}
				num = (short)1794048001;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Applicable;
			}
			set
			{
				short num = (short)1349517312;
				short num2 = num;
				num = (short)903718109;
				short num3 = num;
				num = (short)1961403613;
				switch (num3 == num)
				{
				}
				num = (short)1930362881;
				if (num != 0)
				{
				}
				num = (short)1449000960;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Applicable = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06003D32 RID: 15666 RVA: 0x00391F74 File Offset: 0x00390174
		// (set) Token: 0x06003D33 RID: 15667 RVA: 0x00392028 File Offset: 0x00390228
		public bool GPSFailToneInterval_42329_Valid
		{
			get
			{
				short num = (short)852688896;
				short num2 = num;
				num = (short)972242047;
				short num3 = num;
				num = (short)2059287679;
				switch (num3 == num)
				{
				}
				num = (short)175243265;
				if (num != 0)
				{
				}
				num = (short)428408832;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Valid;
			}
			set
			{
				short num = (short)1799356416;
				short num2 = num;
				num = (short)782159483;
				short num3 = num;
				num = (short)938331771;
				switch (num3 == num)
				{
				}
				num = (short)114884609;
				if (num != 0)
				{
				}
				num = (short)1755709440;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Valid = value;
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x003920E0 File Offset: 0x003902E0
		// (set) Token: 0x06003D35 RID: 15669 RVA: 0x00392198 File Offset: 0x00390398
		public bool GPSFailToneInterval_42329_Visible
		{
			get
			{
				short num = (short)1365114880;
				short num2 = num;
				num = (short)134523177;
				short num3 = num;
				num = (short)1783015721;
				switch (num3 == num)
				{
				}
				num = (short)648544257;
				if (num != 0)
				{
				}
				num = (short)1119879168;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Visible;
			}
			set
			{
				short num = (short)56754176;
				short num2 = num;
				num = (short)590861755;
				short num3 = num;
				num = (short)1740363195;
				switch (num3 == num)
				{
				}
				num = (short)1132986368;
				if (num != 0)
				{
				}
				num = (short)2142830593;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Visible = value;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x0039224C File Offset: 0x0039044C
		// (set) Token: 0x06003D37 RID: 15671 RVA: 0x00392300 File Offset: 0x00390500
		public bool GPSFailToneInterval_42329_Editable
		{
			get
			{
				short num = (short)2066219008;
				short num2 = num;
				num = (short)28691919;
				short num3 = num;
				num = (short)1389088207;
				switch (num3 == num)
				{
				}
				num = (short)1757478913;
				if (num != 0)
				{
				}
				num = (short)66912256;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.Editable;
			}
			set
			{
				short num = (short)304414720;
				short num2 = num;
				num = (short)965702846;
				short num3 = num;
				num = (short)41383102;
				switch (num3 == num)
				{
				}
				num = (short)1669201921;
				if (num != 0)
				{
				}
				num = (short)1246756864;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.Editable = value;
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x003923B8 File Offset: 0x003905B8
		internal string GPSFailToneInterval_42329_UILabel
		{
			get
			{
				short num = (short)1423179776;
				short num2 = num;
				num = (short)384584458;
				short num3 = num;
				num = (short)1343572746;
				switch (num3 == num)
				{
				}
				num = (short)1215889409;
				if (num != 0)
				{
				}
				num = (short)186712064;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.UIName;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x0039246C File Offset: 0x0039066C
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x00392524 File Offset: 0x00390724
		internal bool GPSFailToneInterval_42329_HiddenStatic
		{
			get
			{
				short num = (short)1425014784;
				short num2 = num;
				num = (short)157555600;
				short num3 = num;
				num = (short)1382095760;
				switch (num3 == num)
				{
				}
				num = (short)429457408;
				if (num != 0)
				{
				}
				num = (short)1284112385;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.HiddenStatic;
			}
			set
			{
				short num = (short)549584896;
				short num2 = num;
				num = (short)418003734;
				short num3 = num;
				num = (short)38091542;
				switch (num3 == num)
				{
				}
				num = (short)269418496;
				if (num != 0)
				{
				}
				num = (short)2115239937;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.HiddenStatic = value;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x003925DC File Offset: 0x003907DC
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x0039268C File Offset: 0x0039088C
		internal bool GPSFailToneInterval_42329_HiddenDynamic
		{
			get
			{
				short num = (short)702021632;
				short num2 = num;
				num = (short)1988572704;
				short num3 = num;
				num = (short)32388640;
				switch (num3 == num)
				{
				}
				num = (short)1544290305;
				if (num != 0)
				{
				}
				num = (short)2089418752;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329.HiddenDynamic;
			}
			set
			{
				short num = (short)371851264;
				short num2 = num;
				num = (short)1105864147;
				short num3 = num;
				num = (short)2012816851;
				switch (num3 == num)
				{
				}
				num = (short)1663762432;
				if (num != 0)
				{
				}
				num = (short)185663489;
				if (num != 0)
				{
				}
				this.gPSFailToneInterval_42329.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x00392744 File Offset: 0x00390944
		public bool GPSFailToneInterval_42329_HasDiffs
		{
			get
			{
				short num = (short)1748041728;
				short num2 = num;
				num = (short)2118734823;
				short num3 = num;
				num = (short)1319130087;
				switch (num3 == num)
				{
				}
				num = (short)1681915905;
				if (num != 0)
				{
				}
				num = (short)946536448;
				if (num != 0)
				{
				}
				return this.gPSFailToneInterval_42329._HasDiffs;
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x00392800 File Offset: 0x00390A00
		// (set) Token: 0x06003D3F RID: 15679 RVA: 0x003928B4 File Offset: 0x00390AB4
		public bool RadWideLocP25LocationReporting_42412Value
		{
			get
			{
				short num = (short)1798569984;
				short num2 = num;
				num = (short)1727526964;
				short num3 = num;
				num = (short)1548417076;
				switch (num3 == num)
				{
				}
				num = (short)267649025;
				if (num != 0)
				{
				}
				num = (short)643694592;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.Value;
			}
			set
			{
				short num = (short)84934656;
				short num2 = num;
				num = (short)616951037;
				short num3 = num;
				num = (short)1739844861;
				switch (num3 == num)
				{
				}
				num = (short)145424384;
				if (num != 0)
				{
				}
				num = (short)1248526337;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.Value = value;
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x00392968 File Offset: 0x00390B68
		public global::AcpBusinessLayer.AcpField<bool> RadWideLocP25LocationReporting_42412
		{
			get
			{
				short num = (short)946929664;
				short num2 = num;
				num = (short)2038047669;
				short num3 = num;
				num = (short)133309365;
				switch (num3 == num)
				{
				}
				num = (short)890503168;
				if (num != 0)
				{
				}
				num = (short)1313472513;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412;
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x00392A18 File Offset: 0x00390C18
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00392ACC File Offset: 0x00390CCC
		public bool RadWideLocP25LocationReporting_42412_UIValue
		{
			get
			{
				short num = (short)222035968;
				short num2 = num;
				num = (short)604897281;
				if (num != 0)
				{
				}
				num = (short)665243140;
				short num3 = num;
				num = (short)1826344452;
				switch (num3 == num)
				{
				}
				num = (short)939065344;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.Value;
			}
			set
			{
				short num = (short)86310912;
				short num2 = num;
				num = (short)1812714244;
				short num3 = num;
				num = (short)1711723268;
				switch (num3 == num)
				{
				}
				num = (short)1370816513;
				if (num != 0)
				{
				}
				num = (short)1769013248;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.Value = value;
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00392B80 File Offset: 0x00390D80
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00392C34 File Offset: 0x00390E34
		public bool RadWideLocP25LocationReporting_42412_Applicable
		{
			get
			{
				short num = (short)1761935360;
				short num2 = num;
				num = (short)574710865;
				short num3 = num;
				num = (short)1110664273;
				switch (num3 == num)
				{
				}
				num = (short)1271726080;
				if (num != 0)
				{
				}
				num = (short)1483931649;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.Applicable;
			}
			set
			{
				short num = (short)421396480;
				short num2 = num;
				num = (short)2120502613;
				short num3 = num;
				num = (short)104615253;
				switch (num3 == num)
				{
				}
				num = (short)688717825;
				if (num != 0)
				{
				}
				num = (short)1011351552;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.Applicable = value;
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00392CEC File Offset: 0x00390EEC
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00392DA0 File Offset: 0x00390FA0
		public bool RadWideLocP25LocationReporting_42412_Valid
		{
			get
			{
				short num = (short)1617100800;
				short num2 = num;
				num = (short)950599681;
				if (num != 0)
				{
				}
				num = (short)1318471751;
				short num3 = num;
				num = (short)694634567;
				switch (num3 == num)
				{
				}
				num = (short)7864320;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.Valid;
			}
			set
			{
				short num = (short)220659712;
				short num2 = num;
				num = (short)449874610;
				short num3 = num;
				num = (short)1517062834;
				switch (num3 == num)
				{
				}
				num = (short)176095232;
				if (num != 0)
				{
				}
				num = (short)1236860929;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.Valid = value;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x00392E54 File Offset: 0x00391054
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x00392F08 File Offset: 0x00391108
		public bool RadWideLocP25LocationReporting_42412_Visible
		{
			get
			{
				short num = (short)814678016;
				short num2 = num;
				num = (short)453587954;
				short num3 = num;
				num = (short)1924084722;
				switch (num3 == num)
				{
				}
				num = (short)836370433;
				if (num != 0)
				{
				}
				num = (short)315752448;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.Visible;
			}
			set
			{
				short num = (short)660930560;
				short num2 = num;
				num = (short)322259783;
				short num3 = num;
				num = (short)2035895111;
				switch (num3 == num)
				{
				}
				num = (short)243793921;
				if (num != 0)
				{
				}
				num = (short)768540672;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.Visible = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x00392FC0 File Offset: 0x003911C0
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x00393078 File Offset: 0x00391278
		public bool RadWideLocP25LocationReporting_42412_Editable
		{
			get
			{
				short num = (short)2043871232;
				short num2 = num;
				num = (short)977763598;
				short num3 = num;
				num = (short)1130331406;
				switch (num3 == num)
				{
				}
				num = (short)725549057;
				if (num != 0)
				{
				}
				num = (short)2086273024;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.Editable;
			}
			set
			{
				short num = (short)1917452288;
				short num2 = num;
				num = (short)26738689;
				if (num != 0)
				{
				}
				num = (short)1805617641;
				short num3 = num;
				num = (short)1067813353;
				switch (num3 == num)
				{
				}
				num = (short)1418461184;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.Editable = value;
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00393130 File Offset: 0x00391330
		internal string RadWideLocP25LocationReporting_42412_UILabel
		{
			get
			{
				short num = (short)928055296;
				short num2 = num;
				num = (short)159966682;
				short num3 = num;
				num = (short)1781655002;
				switch (num3 == num)
				{
				}
				num = (short)1430650881;
				if (num != 0)
				{
				}
				num = (short)1942945792;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.UIName;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x003931E4 File Offset: 0x003913E4
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x00393298 File Offset: 0x00391498
		internal bool RadWideLocP25LocationReporting_42412_HiddenStatic
		{
			get
			{
				short num = (short)477954048;
				short num2 = num;
				num = (short)476618935;
				short num3 = num;
				num = (short)932749495;
				switch (num3 == num)
				{
				}
				num = (short)694091777;
				if (num != 0)
				{
				}
				num = (short)538640384;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.HiddenStatic;
			}
			set
			{
				short num = (short)1656881152;
				short num2 = num;
				num = (short)2066677761;
				if (num != 0)
				{
				}
				num = (short)13440321;
				short num3 = num;
				num = (short)2119701825;
				switch (num3 == num)
				{
				}
				num = (short)692912128;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.HiddenStatic = value;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x00393350 File Offset: 0x00391550
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x00393404 File Offset: 0x00391604
		internal bool RadWideLocP25LocationReporting_42412_HiddenDynamic
		{
			get
			{
				short num = (short)227868672;
				short num2 = num;
				num = (short)1686503425;
				if (num != 0)
				{
				}
				num = (short)42467328;
				short num3 = num;
				num = (short)1864761344;
				switch (num3 == num)
				{
				}
				num = (short)2140995584;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412.HiddenDynamic;
			}
			set
			{
				short num = (short)251330560;
				short num2 = num;
				num = (short)799342593;
				if (num != 0)
				{
				}
				num = (short)773632874;
				short num3 = num;
				num = (short)1696707434;
				switch (num3 == num)
				{
				}
				num = (short)1788936192;
				if (num != 0)
				{
				}
				this.radWideLocP25LocationReporting_42412.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x003934B8 File Offset: 0x003916B8
		public bool RadWideLocP25LocationReporting_42412_HasDiffs
		{
			get
			{
				short num = (short)1386610688;
				short num2 = num;
				num = (short)2138418930;
				short num3 = num;
				num = (short)1203351282;
				switch (num3 == num)
				{
				}
				num = (short)1123090433;
				if (num != 0)
				{
				}
				num = (short)1442316288;
				if (num != 0)
				{
				}
				return this.radWideLocP25LocationReporting_42412._HasDiffs;
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x00393570 File Offset: 0x00391770
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x00393624 File Offset: 0x00391824
		public bool RadWideLocationDisplayPeerLocation_42433Value
		{
			get
			{
				short num = (short)526188544;
				short num2 = num;
				num = (short)156696577;
				if (num != 0)
				{
				}
				num = (short)2044639926;
				short num3 = num;
				num = (short)465877686;
				switch (num3 == num)
				{
				}
				num = (short)1050738688;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.Value;
			}
			set
			{
				short num = (short)622854144;
				short num2 = num;
				num = (short)1182269441;
				if (num != 0)
				{
				}
				num = (short)1417367094;
				short num3 = num;
				num = (short)2110606902;
				switch (num3 == num)
				{
				}
				num = (short)721027072;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.Value = value;
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x003936DC File Offset: 0x003918DC
		public global::AcpBusinessLayer.AcpField<bool> RadWideLocationDisplayPeerLocation_42433
		{
			get
			{
				short num = (short)513998848;
				short num2 = num;
				num = (short)1282082712;
				short num3 = num;
				num = (short)610469784;
				switch (num3 == num)
				{
				}
				num = (short)337510401;
				if (num != 0)
				{
				}
				num = (short)1500512256;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433;
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06003D54 RID: 15700 RVA: 0x00393790 File Offset: 0x00391990
		// (set) Token: 0x06003D55 RID: 15701 RVA: 0x00393844 File Offset: 0x00391A44
		public bool RadWideLocationDisplayPeerLocation_42433_UIValue
		{
			get
			{
				short num = (short)1656553472;
				short num2 = num;
				num = (short)177412724;
				short num3 = num;
				num = (short)1486887540;
				switch (num3 == num)
				{
				}
				num = (short)756023297;
				if (num != 0)
				{
				}
				num = (short)602472448;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.Value;
			}
			set
			{
				short num = (short)1010565120;
				short num2 = num;
				num = (short)79659551;
				short num3 = num;
				num = (short)1719108127;
				switch (num3 == num)
				{
				}
				num = (short)1670381568;
				if (num != 0)
				{
				}
				num = (short)796393473;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.Value = value;
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x003938F8 File Offset: 0x00391AF8
		// (set) Token: 0x06003D57 RID: 15703 RVA: 0x003939B0 File Offset: 0x00391BB0
		public bool RadWideLocationDisplayPeerLocation_42433_Applicable
		{
			get
			{
				short num = (short)2089091072;
				short num2 = num;
				num = (short)1821999589;
				short num3 = num;
				num = (short)2045084133;
				switch (num3 == num)
				{
				}
				num = (short)1226244097;
				if (num != 0)
				{
				}
				num = (short)694026240;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.Applicable;
			}
			set
			{
				short num = (short)1878589440;
				short num2 = num;
				num = (short)1669607100;
				short num3 = num;
				num = (short)538259132;
				switch (num3 == num)
				{
				}
				num = (short)1528561665;
				if (num != 0)
				{
				}
				num = (short)929890304;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.Applicable = value;
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x00393A64 File Offset: 0x00391C64
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x00393B18 File Offset: 0x00391D18
		public bool RadWideLocationDisplayPeerLocation_42433_Valid
		{
			get
			{
				short num = (short)39796505;
				short num2 = num;
				num = (short)1596145433;
				switch (num2 == num)
				{
				}
				num = (short)364838912;
				if (num != 0)
				{
				}
				num = (short)1084162048;
				short num3 = num;
				num = (short)800849921;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.Valid;
			}
			set
			{
				short num = (short)904579263;
				short num2 = num;
				num = (short)582207679;
				switch (num2 == num)
				{
				}
				num = (short)835321857;
				if (num != 0)
				{
				}
				num = (short)557187072;
				short num3 = num;
				num = (short)1926168576;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.Valid = value;
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x00393BCC File Offset: 0x00391DCC
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x00393C80 File Offset: 0x00391E80
		public bool RadWideLocationDisplayPeerLocation_42433_Visible
		{
			get
			{
				short num = (short)1102839809;
				if (num != 0)
				{
				}
				num = (short)926870516;
				short num2 = num;
				num = (short)1847127028;
				switch (num2 == num)
				{
				}
				num = (short)380829696;
				short num3 = num;
				num = (short)1561067520;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.Visible;
			}
			set
			{
				short num = (short)27066369;
				if (num != 0)
				{
				}
				num = (short)437731056;
				short num2 = num;
				num = (short)2077245168;
				switch (num2 == num)
				{
				}
				num = (short)638517248;
				short num3 = num;
				num = (short)1688600576;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.Visible = value;
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x00393D34 File Offset: 0x00391F34
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x00393DE8 File Offset: 0x00391FE8
		public bool RadWideLocationDisplayPeerLocation_42433_Editable
		{
			get
			{
				short num = (short)125601145;
				short num2 = num;
				num = (short)1320912249;
				switch (num2 == num)
				{
				}
				num = (short)336199680;
				if (num != 0)
				{
				}
				num = (short)309657600;
				short num3 = num;
				num = (short)2016018433;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.Editable;
			}
			set
			{
				short num = (short)1156406046;
				short num2 = num;
				num = (short)519133982;
				switch (num2 == num)
				{
				}
				num = (short)814743552;
				if (num != 0)
				{
				}
				num = (short)1032978432;
				short num3 = num;
				num = (short)649003009;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.Editable = value;
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x00393E9C File Offset: 0x0039209C
		internal string RadWideLocationDisplayPeerLocation_42433_UILabel
		{
			get
			{
				short num = (short)82685453;
				short num2 = num;
				num = (short)956411405;
				switch (num2 == num)
				{
				}
				num = (short)1486290944;
				if (num != 0)
				{
				}
				num = (short)1005453312;
				short num3 = num;
				num = (short)433913857;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.UIName;
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00393F50 File Offset: 0x00392150
		// (set) Token: 0x06003D60 RID: 15712 RVA: 0x00394000 File Offset: 0x00392200
		internal bool RadWideLocationDisplayPeerLocation_42433_HiddenStatic
		{
			get
			{
				short num = (short)88772835;
				short num2 = num;
				num = (short)730894563;
				switch (num2 == num)
				{
				}
				num = (short)743833601;
				if (num != 0)
				{
				}
				num = (short)7143424;
				short num3 = num;
				num = (short)98697216;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.HiddenStatic;
			}
			set
			{
				short num = (short)268972992;
				short num2 = num;
				num = (short)1347630016;
				switch (num2 == num)
				{
				}
				num = (short)972881920;
				if (num != 0)
				{
				}
				num = (short)769654784;
				short num3 = num;
				num = (short)258473985;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.HiddenStatic = value;
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06003D61 RID: 15713 RVA: 0x003940BC File Offset: 0x003922BC
		// (set) Token: 0x06003D62 RID: 15714 RVA: 0x00394170 File Offset: 0x00392370
		internal bool RadWideLocationDisplayPeerLocation_42433_HiddenDynamic
		{
			get
			{
				short num = (short)709624833;
				short num2 = num;
				num = (short)1130169345;
				switch (num2 == num)
				{
				}
				num = (short)786300929;
				if (num != 0)
				{
				}
				num = (short)1855717376;
				short num3 = num;
				num = (short)1988558848;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433.HiddenDynamic;
			}
			set
			{
				short num = (short)1380299861;
				short num2 = num;
				num = (short)395555925;
				switch (num2 == num)
				{
				}
				num = (short)415891457;
				if (num != 0)
				{
				}
				num = (short)616628224;
				short num3 = num;
				num = (short)539033600;
				if (num != 0)
				{
				}
				this.radWideLocationDisplayPeerLocation_42433.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06003D63 RID: 15715 RVA: 0x00394228 File Offset: 0x00392428
		public bool RadWideLocationDisplayPeerLocation_42433_HasDiffs
		{
			get
			{
				short num = (short)1202319336;
				short num2 = num;
				num = (short)1323757544;
				switch (num2 == num)
				{
				}
				num = (short)1393229825;
				if (num != 0)
				{
				}
				num = (short)1523777536;
				short num3 = num;
				num = (short)1601503232;
				if (num != 0)
				{
				}
				return this.radWideLocationDisplayPeerLocation_42433._HasDiffs;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x003942DC File Offset: 0x003924DC
		// (set) Token: 0x06003D65 RID: 15717 RVA: 0x00394390 File Offset: 0x00392590
		public int RadioErgoConfigACMissionCriticalGeofenceMode_42918Value
		{
			get
			{
				short num = (short)1652702885;
				short num2 = num;
				num = (short)1297432229;
				switch (num2 == num)
				{
				}
				num = (short)312475649;
				if (num != 0)
				{
				}
				num = (short)1759248384;
				short num3 = num;
				num = (short)2059796480;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Value;
			}
			set
			{
				short num = (short)733818416;
				short num2 = num;
				num = (short)848834096;
				switch (num2 == num)
				{
				}
				num = (short)764084225;
				if (num != 0)
				{
				}
				num = (short)1402208256;
				short num3 = num;
				num = (short)528089088;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Value = value;
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00394444 File Offset: 0x00392644
		// (set) Token: 0x06003D67 RID: 15719 RVA: 0x003944F8 File Offset: 0x003926F8
		public string RadioErgoConfigACMissionCriticalGeofenceMode_42918_UIValue
		{
			get
			{
				short num = (short)1413260547;
				short num2 = num;
				num = (short)754099459;
				switch (num2 == num)
				{
				}
				num = (short)178651137;
				if (num != 0)
				{
				}
				num = (short)797769728;
				short num3 = num;
				num = (short)321847296;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.UIValue;
			}
			set
			{
				short num = (short)75905315;
				short num2 = num;
				num = (short)225065251;
				switch (num2 == num)
				{
				}
				num = (short)116457472;
				if (num != 0)
				{
				}
				num = (short)723845120;
				short num3 = num;
				num = (short)1308753921;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.UIValue = value;
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x003945AC File Offset: 0x003927AC
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACMissionCriticalGeofenceMode_42918
		{
			get
			{
				short num = (short)1607014955;
				short num2 = num;
				num = (short)1819482667;
				switch (num2 == num)
				{
				}
				num = (short)1562902529;
				if (num != 0)
				{
				}
				num = (short)1961295872;
				short num3 = num;
				num = (short)669253632;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918;
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06003D69 RID: 15721 RVA: 0x00394660 File Offset: 0x00392860
		// (set) Token: 0x06003D6A RID: 15722 RVA: 0x00394714 File Offset: 0x00392914
		public bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_Applicable
		{
			get
			{
				short num = (short)2001078412;
				short num2 = num;
				num = (short)992675980;
				switch (num2 == num)
				{
				}
				num = (short)1174470656;
				if (num != 0)
				{
				}
				num = (short)1627324416;
				short num3 = num;
				num = (short)1610219521;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Applicable;
			}
			set
			{
				short num = (short)1211532083;
				short num2 = num;
				num = (short)194741043;
				switch (num2 == num)
				{
				}
				num = (short)2019491841;
				if (num != 0)
				{
				}
				num = (short)1284374528;
				short num3 = num;
				num = (short)1999044608;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Applicable = value;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x003947C8 File Offset: 0x003929C8
		// (set) Token: 0x06003D6C RID: 15724 RVA: 0x0039487C File Offset: 0x00392A7C
		public bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_Valid
		{
			get
			{
				short num = (short)1367944219;
				short num2 = num;
				num = (short)363670555;
				switch (num2 == num)
				{
				}
				num = (short)2120613888;
				if (num != 0)
				{
				}
				num = (short)184811520;
				short num3 = num;
				num = (short)1989607425;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Valid;
			}
			set
			{
				short num = (short)99568593;
				short num2 = num;
				num = (short)1560693713;
				switch (num2 == num)
				{
				}
				num = (short)114294785;
				if (num != 0)
				{
				}
				num = (short)1222311936;
				short num3 = num;
				num = (short)1357971456;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Valid = value;
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06003D6D RID: 15725 RVA: 0x00394934 File Offset: 0x00392B34
		// (set) Token: 0x06003D6E RID: 15726 RVA: 0x003949EC File Offset: 0x00392BEC
		public bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_Visible
		{
			get
			{
				short num = (short)2101084161;
				if (num != 0)
				{
				}
				num = (short)713746421;
				short num2 = num;
				num = (short)1958799349;
				switch (num2 == num)
				{
				}
				num = (short)359137280;
				short num3 = num;
				num = (short)934084608;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Visible;
			}
			set
			{
				short num = (short)1614926855;
				short num2 = num;
				num = (short)744936455;
				switch (num2 == num)
				{
				}
				num = (short)1409351680;
				if (num != 0)
				{
				}
				num = (short)1397882880;
				short num3 = num;
				num = (short)1744764929;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Visible = value;
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x00394AA4 File Offset: 0x00392CA4
		// (set) Token: 0x06003D70 RID: 15728 RVA: 0x00394B58 File Offset: 0x00392D58
		public bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_Editable
		{
			get
			{
				short num = (short)1929459145;
				short num2 = num;
				num = (short)741815753;
				switch (num2 == num)
				{
				}
				num = (short)1934295041;
				if (num != 0)
				{
				}
				num = (short)269484032;
				short num3 = num;
				num = (short)954793984;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Editable;
			}
			set
			{
				short num = (short)674175888;
				short num2 = num;
				num = (short)581442448;
				switch (num2 == num)
				{
				}
				num = (short)984285184;
				if (num != 0)
				{
				}
				num = (short)1219035136;
				short num3 = num;
				num = (short)1691156481;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.Editable = value;
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x00394C0C File Offset: 0x00392E0C
		internal string RadioErgoConfigACMissionCriticalGeofenceMode_42918_UILabel
		{
			get
			{
				short num = (short)1954121644;
				short num2 = num;
				num = (short)759859116;
				switch (num2 == num)
				{
				}
				num = (short)1773993985;
				if (num != 0)
				{
				}
				num = (short)161808384;
				short num3 = num;
				num = (short)196411392;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.UIName;
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06003D72 RID: 15730 RVA: 0x00394CC0 File Offset: 0x00392EC0
		// (set) Token: 0x06003D73 RID: 15731 RVA: 0x00394D70 File Offset: 0x00392F70
		internal bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_HiddenStatic
		{
			get
			{
				short num = (short)1090553646;
				short num2 = num;
				num = (short)1831831342;
				switch (num2 == num)
				{
				}
				num = (short)945029121;
				if (num != 0)
				{
				}
				num = (short)1010761728;
				short num3 = num;
				num = (short)1211695104;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.HiddenStatic;
			}
			set
			{
				short num = (short)1854237468;
				short num2 = num;
				num = (short)1152084764;
				switch (num2 == num)
				{
				}
				num = (short)1850408960;
				if (num != 0)
				{
				}
				num = (short)1182138368;
				short num3 = num;
				num = (short)415825921;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.HiddenStatic = value;
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x00394E24 File Offset: 0x00393024
		// (set) Token: 0x06003D75 RID: 15733 RVA: 0x00394EDC File Offset: 0x003930DC
		internal bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_HiddenDynamic
		{
			get
			{
				short num = (short)467600816;
				short num2 = num;
				num = (short)186451376;
				switch (num2 == num)
				{
				}
				num = (short)841678849;
				if (num != 0)
				{
				}
				num = (short)1127677952;
				short num3 = num;
				num = (short)1978400768;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918.HiddenDynamic;
			}
			set
			{
				short num = (short)1871704220;
				short num2 = num;
				num = (short)649130140;
				switch (num2 == num)
				{
				}
				num = (short)1186856961;
				if (num != 0)
				{
				}
				num = (short)1722875904;
				short num3 = num;
				num = (short)105578496;
				if (num != 0)
				{
				}
				this.radioErgoConfigACMissionCriticalGeofenceMode_42918.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06003D76 RID: 15734 RVA: 0x00394F90 File Offset: 0x00393190
		public bool RadioErgoConfigACMissionCriticalGeofenceMode_42918_HasDiffs
		{
			get
			{
				short num = (short)1039979145;
				short num2 = num;
				num = (short)184013449;
				switch (num2 == num)
				{
				}
				num = (short)1442840576;
				if (num != 0)
				{
				}
				num = (short)404553728;
				short num3 = num;
				num = (short)233635841;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACMissionCriticalGeofenceMode_42918._HasDiffs;
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06003D77 RID: 15735 RVA: 0x00395044 File Offset: 0x00393244
		// (set) Token: 0x06003D78 RID: 15736 RVA: 0x003950F8 File Offset: 0x003932F8
		public bool RadWideLocationSystemManagedGeofence_43042Value
		{
			get
			{
				short num = (short)406430102;
				short num2 = num;
				num = (short)1220256150;
				switch (num2 == num)
				{
				}
				num = (short)843841536;
				short num3 = num;
				num = (short)211877888;
				if (num != 0)
				{
				}
				num = (short)908853249;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.Value;
			}
			set
			{
				short num = (short)2100579359;
				short num2 = num;
				num = (short)2036616223;
				switch (num2 == num)
				{
				}
				num = (short)1262551040;
				short num3 = num;
				num = (short)112721920;
				if (num != 0)
				{
				}
				num = (short)2138505217;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.Value = value;
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x003951B4 File Offset: 0x003933B4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLocationSystemManagedGeofence_43042
		{
			get
			{
				short num = (short)2008065096;
				short num2 = num;
				num = (short)803775560;
				switch (num2 == num)
				{
				}
				num = (short)94109696;
				short num3 = num;
				num = (short)995557376;
				if (num != 0)
				{
				}
				num = (short)889651201;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042;
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06003D7A RID: 15738 RVA: 0x00395264 File Offset: 0x00393464
		// (set) Token: 0x06003D7B RID: 15739 RVA: 0x00395314 File Offset: 0x00393514
		public bool RadWideLocationSystemManagedGeofence_43042_UIValue
		{
			get
			{
				short num = (short)523707703;
				short num2 = num;
				num = (short)1301423415;
				switch (num2 == num)
				{
				}
				num = (short)1630994432;
				short num3 = num;
				num = (short)996671488;
				if (num != 0)
				{
				}
				num = (short)1207697409;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.Value;
			}
			set
			{
				short num = (short)188187797;
				short num2 = num;
				num = (short)1989379221;
				switch (num2 == num)
				{
				}
				num = (short)1517486080;
				short num3 = num;
				num = (short)1971126272;
				if (num != 0)
				{
				}
				num = (short)276103169;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.Value = value;
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06003D7C RID: 15740 RVA: 0x003953C8 File Offset: 0x003935C8
		// (set) Token: 0x06003D7D RID: 15741 RVA: 0x0039547C File Offset: 0x0039367C
		public bool RadWideLocationSystemManagedGeofence_43042_Applicable
		{
			get
			{
				short num = (short)419495937;
				if (num != 0)
				{
				}
				num = (short)1451580498;
				short num2 = num;
				num = (short)1218075730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1853947904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1682046976;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.Applicable;
			}
			set
			{
				short num = (short)1996639169;
				short num2 = num;
				num = (short)266161089;
				switch (num2 == num)
				{
				}
				num = (short)984809472;
				short num3 = num;
				num = (short)606076928;
				if (num != 0)
				{
				}
				num = (short)1300365313;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.Applicable = value;
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06003D7E RID: 15742 RVA: 0x00395530 File Offset: 0x00393730
		// (set) Token: 0x06003D7F RID: 15743 RVA: 0x003955E4 File Offset: 0x003937E4
		public bool RadWideLocationSystemManagedGeofence_43042_Valid
		{
			get
			{
				short num = (short)154840696;
				short num2 = num;
				num = (short)1215278712;
				switch (num2 == num)
				{
				}
				num = (short)714276864;
				short num3 = num;
				num = (short)1311113216;
				if (num != 0)
				{
				}
				num = (short)1024327681;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.Valid;
			}
			set
			{
				short num = (short)2076962857;
				short num2 = num;
				num = (short)1299247145;
				switch (num2 == num)
				{
				}
				num = (short)46465024;
				short num3 = num;
				num = (short)1773666305;
				if (num != 0)
				{
				}
				num = (short)350683136;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.Valid = value;
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06003D80 RID: 15744 RVA: 0x0039569C File Offset: 0x0039389C
		// (set) Token: 0x06003D81 RID: 15745 RVA: 0x00395754 File Offset: 0x00393954
		public bool RadWideLocationSystemManagedGeofence_43042_Visible
		{
			get
			{
				short num = (short)1834929921;
				short num2 = num;
				num = (short)1073401601;
				switch (num2 == num)
				{
				}
				num = (short)36306944;
				short num3 = num;
				num = (short)169082880;
				if (num != 0)
				{
				}
				num = (short)84410369;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.Visible;
			}
			set
			{
				short num = (short)1091631366;
				short num2 = num;
				num = (short)1621031174;
				switch (num2 == num)
				{
				}
				num = (short)158793728;
				short num3 = num;
				num = (short)1431240705;
				if (num != 0)
				{
				}
				num = (short)1321336832;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.Visible = value;
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x00395808 File Offset: 0x00393A08
		// (set) Token: 0x06003D83 RID: 15747 RVA: 0x003958BC File Offset: 0x00393ABC
		public bool RadWideLocationSystemManagedGeofence_43042_Editable
		{
			get
			{
				short num = (short)1208005145;
				short num2 = num;
				num = (short)574403097;
				switch (num2 == num)
				{
				}
				num = (short)1422131200;
				short num3 = num;
				num = (short)1543110657;
				if (num != 0)
				{
				}
				num = (short)1083113472;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.Editable;
			}
			set
			{
				short num = (short)723164341;
				short num2 = num;
				num = (short)801348789;
				switch (num2 == num)
				{
				}
				num = (short)1041301504;
				short num3 = num;
				num = (short)1431896065;
				if (num != 0)
				{
				}
				num = (short)905314304;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.Editable = value;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x00395974 File Offset: 0x00393B74
		internal string RadWideLocationSystemManagedGeofence_43042_UILabel
		{
			get
			{
				short num = (short)95576299;
				short num2 = num;
				num = (short)94789867;
				switch (num2 == num)
				{
				}
				num = (short)1939144704;
				short num3 = num;
				num = (short)633667585;
				if (num != 0)
				{
				}
				num = (short)208666624;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.UIName;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x00395A28 File Offset: 0x00393C28
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00395ADC File Offset: 0x00393CDC
		internal bool RadWideLocationSystemManagedGeofence_43042_HiddenStatic
		{
			get
			{
				short num = (short)35328023;
				short num2 = num;
				num = (short)471994391;
				switch (num2 == num)
				{
				}
				num = (short)405078016;
				short num3 = num;
				num = (short)1913913344;
				if (num != 0)
				{
				}
				num = (short)834404353;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.HiddenStatic;
			}
			set
			{
				short num = (short)572224708;
				short num2 = num;
				num = (short)127169732;
				switch (num2 == num)
				{
				}
				num = (short)878051328;
				short num3 = num;
				num = (short)397869057;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.HiddenStatic = value;
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00395B90 File Offset: 0x00393D90
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00395C44 File Offset: 0x00393E44
		internal bool RadWideLocationSystemManagedGeofence_43042_HiddenDynamic
		{
			get
			{
				short num = (short)1385595074;
				short num2 = num;
				num = (short)2092269762;
				switch (num2 == num)
				{
				}
				num = (short)915210240;
				short num3 = num;
				num = (short)91881473;
				if (num != 0)
				{
				}
				num = (short)1811021824;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042.HiddenDynamic;
			}
			set
			{
				short num = (short)37492147;
				short num2 = num;
				num = (short)1367545267;
				switch (num2 == num)
				{
				}
				num = (short)1373437952;
				short num3 = num;
				num = (short)1052901377;
				if (num != 0)
				{
				}
				num = (short)552009728;
				if (num != 0)
				{
				}
				this.radWideLocationSystemManagedGeofence_43042.HiddenDynamic = value;
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x00395CF8 File Offset: 0x00393EF8
		public bool RadWideLocationSystemManagedGeofence_43042_HasDiffs
		{
			get
			{
				short num = (short)216798483;
				short num2 = num;
				num = (short)1276581139;
				switch (num2 == num)
				{
				}
				num = (short)1074528256;
				short num3 = num;
				num = (short)1731657729;
				if (num != 0)
				{
				}
				num = (short)27131904;
				if (num != 0)
				{
				}
				return this.radWideLocationSystemManagedGeofence_43042._HasDiffs;
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x00395DAC File Offset: 0x00393FAC
		// (set) Token: 0x06003D8B RID: 15755 RVA: 0x00395E60 File Offset: 0x00394060
		public int RadWideFeaturesMappingValue
		{
			get
			{
				short num = (short)2010967405;
				short num2 = num;
				num = (short)1965223277;
				switch (num2 == num)
				{
				}
				num = (short)853016576;
				short num3 = num;
				num = (short)650969088;
				if (num != 0)
				{
				}
				num = (short)2017198081;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.Value;
			}
			set
			{
				short num = (short)1543442919;
				short num2 = num;
				num = (short)1309479399;
				switch (num2 == num)
				{
				}
				num = (short)1080623104;
				short num3 = num;
				num = (short)548405249;
				if (num != 0)
				{
				}
				num = (short)1124794368;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.Value = value;
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06003D8C RID: 15756 RVA: 0x00395F18 File Offset: 0x00394118
		// (set) Token: 0x06003D8D RID: 15757 RVA: 0x00395FCC File Offset: 0x003941CC
		public string RadWideFeaturesMapping_UIValue
		{
			get
			{
				short num = (short)1499070187;
				short num2 = num;
				num = (short)2091253483;
				switch (num2 == num)
				{
				}
				num = (short)304611328;
				short num3 = num;
				num = (short)763822080;
				if (num != 0)
				{
				}
				num = (short)1182859265;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.UIValue;
			}
			set
			{
				short num = (short)911627722;
				short num2 = num;
				num = (short)816928202;
				switch (num2 == num)
				{
				}
				num = (short)1388576768;
				short num3 = num;
				num = (short)213581825;
				if (num != 0)
				{
				}
				num = (short)312016896;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.UIValue = value;
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06003D8E RID: 15758 RVA: 0x00396080 File Offset: 0x00394280
		public global::AcpBusinessLayer.AcpListField RadWideFeaturesMapping
		{
			get
			{
				short num = (short)1384833770;
				short num2 = num;
				num = (short)488039146;
				switch (num2 == num)
				{
				}
				num = (short)447348736;
				short num3 = num;
				num = (short)15990784;
				if (num != 0)
				{
				}
				num = (short)813105153;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x00396134 File Offset: 0x00394334
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x003961E8 File Offset: 0x003943E8
		public bool RadWideFeaturesMapping_Applicable
		{
			get
			{
				short num = (short)1231378212;
				short num2 = num;
				num = (short)2055362340;
				switch (num2 == num)
				{
				}
				num = (short)1858469888;
				short num3 = num;
				num = (short)1560084480;
				if (num != 0)
				{
				}
				num = (short)1317994497;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.Applicable;
			}
			set
			{
				short num = (short)572585143;
				short num2 = num;
				num = (short)889189559;
				switch (num2 == num)
				{
				}
				num = (short)846397440;
				short num3 = num;
				num = (short)869531649;
				if (num != 0)
				{
				}
				num = (short)191102976;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.Applicable = value;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x0039629C File Offset: 0x0039449C
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x00396350 File Offset: 0x00394550
		public bool RadWideFeaturesMapping_Valid
		{
			get
			{
				short num = (short)10991146;
				short num2 = num;
				num = (short)104969770;
				switch (num2 == num)
				{
				}
				num = (short)888733696;
				short num3 = num;
				num = (short)1284046849;
				if (num != 0)
				{
				}
				num = (short)1668153344;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.Valid;
			}
			set
			{
				short num = (short)1128866656;
				short num2 = num;
				num = (short)1961436000;
				switch (num2 == num)
				{
				}
				num = (short)1657864192;
				short num3 = num;
				num = (short)1741488129;
				if (num != 0)
				{
				}
				num = (short)105512960;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.Valid = value;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x00396404 File Offset: 0x00394604
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x003964B8 File Offset: 0x003946B8
		public bool RadWideFeaturesMapping_Visible
		{
			get
			{
				short num = (short)1397817345;
				if (num != 0)
				{
				}
				num = (short)1704459725;
				short num2 = num;
				num = (short)612826573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044067840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1623392256;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.Visible;
			}
			set
			{
				short num = (short)1596576752;
				short num2 = num;
				num = (short)1922028528;
				switch (num2 == num)
				{
				}
				num = (short)1873346560;
				short num3 = num;
				num = (short)266469377;
				if (num != 0)
				{
				}
				num = (short)2010513408;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.Visible = value;
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x0039656C File Offset: 0x0039476C
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00396620 File Offset: 0x00394820
		public bool RadWideFeaturesMapping_Editable
		{
			get
			{
				short num = (short)1342522096;
				short num2 = num;
				num = (short)1143685872;
				switch (num2 == num)
				{
				}
				num = (short)525008896;
				short num3 = num;
				num = (short)1250426880;
				if (num != 0)
				{
				}
				num = (short)315424769;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.Editable;
			}
			set
			{
				short num = (short)1002146610;
				short num2 = num;
				num = (short)681413426;
				switch (num2 == num)
				{
				}
				num = (short)379715584;
				short num3 = num;
				num = (short)1714290689;
				if (num != 0)
				{
				}
				num = (short)1049755648;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.Editable = value;
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06003D97 RID: 15767 RVA: 0x003966D4 File Offset: 0x003948D4
		internal string RadWideFeaturesMapping_UILabel
		{
			get
			{
				short num = (short)1805402916;
				short num2 = num;
				num = (short)193676068;
				switch (num2 == num)
				{
				}
				num = (short)1462042624;
				short num3 = num;
				num = (short)585498625;
				if (num != 0)
				{
				}
				num = (short)1919483904;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.UIName;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06003D98 RID: 15768 RVA: 0x0039678C File Offset: 0x0039498C
		// (set) Token: 0x06003D99 RID: 15769 RVA: 0x00396844 File Offset: 0x00394A44
		internal bool RadWideFeaturesMapping_HiddenStatic
		{
			get
			{
				short num = (short)321532279;
				short num2 = num;
				num = (short)1494430071;
				switch (num2 == num)
				{
				}
				num = (short)1382219776;
				short num3 = num;
				num = (short)2095448065;
				if (num != 0)
				{
				}
				num = (short)217710592;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.HiddenStatic;
			}
			set
			{
				short num = (short)1648104127;
				short num2 = num;
				num = (short)2061570751;
				switch (num2 == num)
				{
				}
				num = (short)890241024;
				short num3 = num;
				num = (short)531038208;
				if (num != 0)
				{
				}
				num = (short)2126446593;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.HiddenStatic = value;
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x003968F8 File Offset: 0x00394AF8
		// (set) Token: 0x06003D9B RID: 15771 RVA: 0x003969B0 File Offset: 0x00394BB0
		internal bool RadWideFeaturesMapping_HiddenDynamic
		{
			get
			{
				short num = (short)954442697;
				short num2 = num;
				num = (short)2146018249;
				switch (num2 == num)
				{
				}
				num = (short)435748864;
				short num3 = num;
				num = (short)1022164993;
				if (num != 0)
				{
				}
				num = (short)1922957312;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping.HiddenDynamic;
			}
			set
			{
				short num = (short)629578333;
				short num2 = num;
				num = (short)1675729501;
				switch (num2 == num)
				{
				}
				num = (short)1495203840;
				short num3 = num;
				num = (short)1720975361;
				if (num != 0)
				{
				}
				num = (short)1869414400;
				if (num != 0)
				{
				}
				this.radWideFeaturesMapping.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x00396A64 File Offset: 0x00394C64
		public bool RadWideFeaturesMapping_HasDiffs
		{
			get
			{
				short num = (short)1093798137;
				short num2 = num;
				num = (short)1133316345;
				switch (num2 == num)
				{
				}
				num = (short)775225344;
				short num3 = num;
				num = (short)1638858753;
				if (num != 0)
				{
				}
				num = (short)686751744;
				if (num != 0)
				{
				}
				return this.radWideFeaturesMapping._HasDiffs;
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x00396B18 File Offset: 0x00394D18
		// (set) Token: 0x06003D9E RID: 15774 RVA: 0x00396BCC File Offset: 0x00394DCC
		public bool RadWideSmartMappingServerAssistedLocationValue
		{
			get
			{
				short num = (short)1560879213;
				short num2 = num;
				num = (short)1945116781;
				switch (num2 == num)
				{
				}
				num = (short)1163919360;
				short num3 = num;
				num = (short)179961857;
				if (num != 0)
				{
				}
				num = (short)1703280640;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.Value;
			}
			set
			{
				short num = (short)536927440;
				short num2 = num;
				num = (short)56089808;
				switch (num2 == num)
				{
				}
				num = (short)484966400;
				short num3 = num;
				num = (short)1147011073;
				if (num != 0)
				{
				}
				num = (short)774242304;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.Value = value;
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x00396C84 File Offset: 0x00394E84
		public global::AcpBusinessLayer.AcpField<bool> RadWideSmartMappingServerAssistedLocation
		{
			get
			{
				short num = (short)1569771113;
				short num2 = num;
				num = (short)2088685161;
				switch (num2 == num)
				{
				}
				num = (short)2096889856;
				short num3 = num;
				num = (short)1119223808;
				if (num != 0)
				{
				}
				num = (short)733544449;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation;
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x00396D38 File Offset: 0x00394F38
		// (set) Token: 0x06003DA1 RID: 15777 RVA: 0x00396DEC File Offset: 0x00394FEC
		public bool RadWideSmartMappingServerAssistedLocation_UIValue
		{
			get
			{
				short num = (short)1237998100;
				short num2 = num;
				num = (short)1137072660;
				switch (num2 == num)
				{
				}
				num = (short)1325662208;
				short num3 = num;
				num = (short)935657473;
				if (num != 0)
				{
				}
				num = (short)294125568;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.Value;
			}
			set
			{
				short num = (short)174428938;
				short num2 = num;
				num = (short)99717898;
				switch (num2 == num)
				{
				}
				num = (short)1924661248;
				short num3 = num;
				num = (short)1218904064;
				if (num != 0)
				{
				}
				num = (short)514260993;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.Value = value;
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x00396EA0 File Offset: 0x003950A0
		// (set) Token: 0x06003DA3 RID: 15779 RVA: 0x00396F58 File Offset: 0x00395158
		public bool RadWideSmartMappingServerAssistedLocation_Applicable
		{
			get
			{
				short num = (short)1182662657;
				if (num != 0)
				{
				}
				num = (short)1017863450;
				short num2 = num;
				num = (short)1865375002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086600704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1550385152;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.Applicable;
			}
			set
			{
				short num = (short)1727812299;
				short num2 = num;
				num = (short)2097763019;
				switch (num2 == num)
				{
				}
				num = (short)2028339200;
				short num3 = num;
				num = (short)1582432257;
				if (num != 0)
				{
				}
				num = (short)853475328;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.Applicable = value;
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00397010 File Offset: 0x00395210
		// (set) Token: 0x06003DA5 RID: 15781 RVA: 0x003970C8 File Offset: 0x003952C8
		public bool RadWideSmartMappingServerAssistedLocation_Valid
		{
			get
			{
				short num = (short)1941241856;
				short num2 = num;
				num = (short)1144862171;
				short num3 = num;
				num = (short)1872967131;
				switch (num3 == num)
				{
				}
				num = (short)1288896513;
				if (num != 0)
				{
				}
				num = (short)694484992;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.Valid;
			}
			set
			{
				short num = (short)1521156096;
				short num2 = num;
				num = (short)1009989457;
				short num3 = num;
				num = (short)706623313;
				switch (num3 == num)
				{
				}
				num = (short)1478164481;
				if (num != 0)
				{
				}
				num = (short)1016659968;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.Valid = value;
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06003DA6 RID: 15782 RVA: 0x0039717C File Offset: 0x0039537C
		// (set) Token: 0x06003DA7 RID: 15783 RVA: 0x0039722C File Offset: 0x0039542C
		public bool RadWideSmartMappingServerAssistedLocation_Visible
		{
			get
			{
				short num = (short)992149504;
				short num2 = num;
				num = (short)259970269;
				short num3 = num;
				num = (short)2023609565;
				switch (num3 == num)
				{
				}
				num = (short)1228537857;
				if (num != 0)
				{
				}
				num = (short)2143092736;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.Visible;
			}
			set
			{
				short num = (short)409600000;
				short num2 = num;
				num = (short)728173433;
				short num3 = num;
				num = (short)563547001;
				switch (num3 == num)
				{
				}
				num = (short)266731520;
				if (num != 0)
				{
				}
				num = (short)2072248321;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.Visible = value;
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06003DA8 RID: 15784 RVA: 0x003972E4 File Offset: 0x003954E4
		// (set) Token: 0x06003DA9 RID: 15785 RVA: 0x0039739C File Offset: 0x0039559C
		public bool RadWideSmartMappingServerAssistedLocation_Editable
		{
			get
			{
				short num = (short)1596129280;
				short num2 = num;
				num = (short)2053373953;
				if (num != 0)
				{
				}
				num = (short)197464807;
				short num3 = num;
				num = (short)185275111;
				switch (num3 == num)
				{
				}
				num = (short)446562304;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.Editable;
			}
			set
			{
				short num = (short)462356480;
				short num2 = num;
				num = (short)273942123;
				short num3 = num;
				num = (short)1157039723;
				switch (num3 == num)
				{
				}
				num = (short)891486209;
				if (num != 0)
				{
				}
				num = (short)159842304;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.Editable = value;
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06003DAA RID: 15786 RVA: 0x00397450 File Offset: 0x00395650
		internal string RadWideSmartMappingServerAssistedLocation_UILabel
		{
			get
			{
				short num = (short)999620608;
				short num2 = num;
				num = (short)1135695209;
				short num3 = num;
				num = (short)581522793;
				switch (num3 == num)
				{
				}
				num = (short)1239220225;
				if (num != 0)
				{
				}
				num = (short)1992032256;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.UIName;
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00397504 File Offset: 0x00395704
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x003975BC File Offset: 0x003957BC
		internal bool RadWideSmartMappingServerAssistedLocation_HiddenStatic
		{
			get
			{
				short num = (short)365297664;
				short num2 = num;
				num = (short)145354909;
				short num3 = num;
				num = (short)1738338461;
				switch (num3 == num)
				{
				}
				num = (short)1893728256;
				if (num != 0)
				{
				}
				num = (short)435355649;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.HiddenStatic;
			}
			set
			{
				short num = (short)1557594112;
				short num2 = num;
				num = (short)1391788846;
				short num3 = num;
				num = (short)93455150;
				switch (num3 == num)
				{
				}
				num = (short)1434910721;
				if (num != 0)
				{
				}
				num = (short)34603008;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.HiddenStatic = value;
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00397670 File Offset: 0x00395870
		// (set) Token: 0x06003DAE RID: 15790 RVA: 0x00397724 File Offset: 0x00395924
		internal bool RadWideSmartMappingServerAssistedLocation_HiddenDynamic
		{
			get
			{
				short num = (short)1310195712;
				short num2 = num;
				num = (short)1571537058;
				short num3 = num;
				num = (short)1184219298;
				switch (num3 == num)
				{
				}
				num = (short)1252524033;
				if (num != 0)
				{
				}
				num = (short)682819584;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation.HiddenDynamic;
			}
			set
			{
				short num = (short)1600061440;
				short num2 = num;
				num = (short)120431274;
				short num3 = num;
				num = (short)1609671338;
				switch (num3 == num)
				{
				}
				num = (short)734265344;
				if (num != 0)
				{
				}
				num = (short)904134657;
				if (num != 0)
				{
				}
				this.radWideSmartMappingServerAssistedLocation.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x003977DC File Offset: 0x003959DC
		public bool RadWideSmartMappingServerAssistedLocation_HasDiffs
		{
			get
			{
				short num = (short)1896218624;
				short num2 = num;
				num = (short)2038101588;
				short num3 = num;
				num = (short)1711076948;
				switch (num3 == num)
				{
				}
				num = (short)1996488705;
				if (num != 0)
				{
				}
				num = (short)1622147072;
				if (num != 0)
				{
				}
				return this.radWideSmartMappingServerAssistedLocation._HasDiffs;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x00397890 File Offset: 0x00395A90
		// (set) Token: 0x06003DB1 RID: 15793 RVA: 0x00397944 File Offset: 0x00395B44
		public int RadWideReverseGeocodedLocationDisplayFormatValue
		{
			get
			{
				short num = (short)1393098752;
				short num2 = num;
				num = (short)440467457;
				if (num != 0)
				{
				}
				num = (short)1446953309;
				short num3 = num;
				num = (short)99402077;
				switch (num3 == num)
				{
				}
				num = (short)1579810816;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.Value;
			}
			set
			{
				short num = (short)483196928;
				short num2 = num;
				num = (short)789184513;
				if (num != 0)
				{
				}
				num = (short)1919733267;
				short num3 = num;
				num = (short)1025887763;
				switch (num3 == num)
				{
				}
				num = (short)135331840;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.Value = value;
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x003979F8 File Offset: 0x00395BF8
		// (set) Token: 0x06003DB3 RID: 15795 RVA: 0x00397AB0 File Offset: 0x00395CB0
		public string RadWideReverseGeocodedLocationDisplayFormat_UIValue
		{
			get
			{
				short num = (short)944504832;
				short num2 = num;
				num = (short)1410699229;
				short num3 = num;
				num = (short)850825181;
				switch (num3 == num)
				{
				}
				num = (short)1228668929;
				if (num != 0)
				{
				}
				num = (short)1189478400;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.UIValue;
			}
			set
			{
				short num = (short)880607232;
				short num2 = num;
				num = (short)1189389863;
				short num3 = num;
				num = (short)701736487;
				switch (num3 == num)
				{
				}
				num = (short)1489240065;
				if (num != 0)
				{
				}
				num = (short)173408256;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.UIValue = value;
			}
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00397B68 File Offset: 0x00395D68
		public global::AcpBusinessLayer.AcpListField RadWideReverseGeocodedLocationDisplayFormat
		{
			get
			{
				short num = (short)1662779392;
				short num2 = num;
				num = (short)1272981601;
				short num3 = num;
				num = (short)409675873;
				switch (num3 == num)
				{
				}
				num = (short)606011393;
				if (num != 0)
				{
				}
				num = (short)2621440;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat;
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x00397C18 File Offset: 0x00395E18
		// (set) Token: 0x06003DB6 RID: 15798 RVA: 0x00397CCC File Offset: 0x00395ECC
		public bool RadWideReverseGeocodedLocationDisplayFormat_Applicable
		{
			get
			{
				short num = (short)1130954752;
				short num2 = num;
				num = (short)332640426;
				short num3 = num;
				num = (short)1081979050;
				switch (num3 == num)
				{
				}
				num = (short)1776615425;
				if (num != 0)
				{
				}
				num = (short)155975680;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.Applicable;
			}
			set
			{
				short num = (short)866779136;
				short num2 = num;
				num = (short)1167924281;
				short num3 = num;
				num = (short)1048255545;
				switch (num3 == num)
				{
				}
				num = (short)2067202048;
				if (num != 0)
				{
				}
				num = (short)1739063297;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.Applicable = value;
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x00397D84 File Offset: 0x00395F84
		// (set) Token: 0x06003DB8 RID: 15800 RVA: 0x00397E38 File Offset: 0x00396038
		public bool RadWideReverseGeocodedLocationDisplayFormat_Valid
		{
			get
			{
				short num = (short)1161035776;
				short num2 = num;
				num = (short)1393986576;
				short num3 = num;
				num = (short)253398032;
				switch (num3 == num)
				{
				}
				num = (short)689897472;
				if (num != 0)
				{
				}
				num = (short)907542529;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.Valid;
			}
			set
			{
				short num = (short)752353280;
				short num2 = num;
				num = (short)1714552833;
				if (num != 0)
				{
				}
				num = (short)1301638611;
				short num3 = num;
				num = (short)2033544659;
				switch (num3 == num)
				{
				}
				num = (short)553451520;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.Valid = value;
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x00397EF0 File Offset: 0x003960F0
		// (set) Token: 0x06003DBA RID: 15802 RVA: 0x00397FA4 File Offset: 0x003961A4
		public bool RadWideReverseGeocodedLocationDisplayFormat_Visible
		{
			get
			{
				short num = (short)555089920;
				short num2 = num;
				num = (short)1621323509;
				short num3 = num;
				num = (short)921792245;
				switch (num3 == num)
				{
				}
				num = (short)278069248;
				if (num != 0)
				{
				}
				num = (short)1894711297;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.Visible;
			}
			set
			{
				short num = (short)1270284288;
				short num2 = num;
				num = (short)709061437;
				short num3 = num;
				num = (short)668035901;
				switch (num3 == num)
				{
				}
				num = (short)1480916993;
				if (num != 0)
				{
				}
				num = (short)1740898304;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.Visible = value;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x00398058 File Offset: 0x00396258
		// (set) Token: 0x06003DBC RID: 15804 RVA: 0x0039810C File Offset: 0x0039630C
		public bool RadWideReverseGeocodedLocationDisplayFormat_Editable
		{
			get
			{
				short num = (short)495714304;
				short num2 = num;
				num = (short)778194475;
				short num3 = num;
				num = (short)1722568235;
				switch (num3 == num)
				{
				}
				num = (short)1157038081;
				if (num != 0)
				{
				}
				num = (short)1356595200;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.Editable;
			}
			set
			{
				short num = (short)62455808;
				short num2 = num;
				num = (short)1835101261;
				short num3 = num;
				num = (short)1449421901;
				switch (num3 == num)
				{
				}
				num = (short)390922241;
				if (num != 0)
				{
				}
				num = (short)1942224896;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.Editable = value;
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x003981C4 File Offset: 0x003963C4
		internal string RadWideReverseGeocodedLocationDisplayFormat_UILabel
		{
			get
			{
				short num = (short)316080128;
				short num2 = num;
				num = (short)1444600422;
				short num3 = num;
				num = (short)1425201766;
				switch (num3 == num)
				{
				}
				num = (short)910753792;
				if (num != 0)
				{
				}
				num = (short)1506476033;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.UIName;
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x00398278 File Offset: 0x00396478
		// (set) Token: 0x06003DBF RID: 15807 RVA: 0x00398330 File Offset: 0x00396530
		internal bool RadWideReverseGeocodedLocationDisplayFormat_HiddenStatic
		{
			get
			{
				short num = (short)1073020928;
				short num2 = num;
				num = (short)101318657;
				if (num != 0)
				{
				}
				num = (short)2023258056;
				short num3 = num;
				num = (short)1954969544;
				switch (num3 == num)
				{
				}
				num = (short)1443495936;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.HiddenStatic;
			}
			set
			{
				short num = (short)215023616;
				short num2 = num;
				num = (short)1569912134;
				short num3 = num;
				num = (short)1630336326;
				switch (num3 == num)
				{
				}
				num = (short)1569456129;
				if (num != 0)
				{
				}
				num = (short)1174274048;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.HiddenStatic = value;
			}
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06003DC0 RID: 15808 RVA: 0x003983E4 File Offset: 0x003965E4
		// (set) Token: 0x06003DC1 RID: 15809 RVA: 0x00398498 File Offset: 0x00396698
		internal bool RadWideReverseGeocodedLocationDisplayFormat_HiddenDynamic
		{
			get
			{
				short num = (short)1718222848;
				short num2 = num;
				num = (short)531839042;
				short num3 = num;
				num = (short)1147353154;
				switch (num3 == num)
				{
				}
				num = (short)64815105;
				if (num != 0)
				{
				}
				num = (short)741539840;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat.HiddenDynamic;
			}
			set
			{
				short num = (short)2105081856;
				short num2 = num;
				num = (short)136118273;
				if (num != 0)
				{
				}
				num = (short)1329405699;
				short num3 = num;
				num = (short)277683971;
				switch (num3 == num)
				{
				}
				num = (short)2147024896;
				if (num != 0)
				{
				}
				this.radWideReverseGeocodedLocationDisplayFormat.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06003DC2 RID: 15810 RVA: 0x00398550 File Offset: 0x00396750
		public bool RadWideReverseGeocodedLocationDisplayFormat_HasDiffs
		{
			get
			{
				short num = (short)1642528768;
				short num2 = num;
				num = (short)1510801409;
				if (num != 0)
				{
				}
				num = (short)1814083538;
				short num3 = num;
				num = (short)378189778;
				switch (num3 == num)
				{
				}
				num = (short)1145700352;
				if (num != 0)
				{
				}
				return this.radWideReverseGeocodedLocationDisplayFormat._HasDiffs;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06003DC3 RID: 15811 RVA: 0x00398604 File Offset: 0x00396804
		// (set) Token: 0x06003DC4 RID: 15812 RVA: 0x003986B8 File Offset: 0x003968B8
		public int RadCfgLocationReportingValue
		{
			get
			{
				short num = (short)1299316736;
				short num2 = num;
				num = (short)851143649;
				short num3 = num;
				num = (short)2103995361;
				switch (num3 == num)
				{
				}
				num = (short)966983680;
				if (num != 0)
				{
				}
				num = (short)1712717825;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.Value;
			}
			set
			{
				short num = (short)1870921728;
				short num2 = num;
				num = (short)1115748528;
				short num3 = num;
				num = (short)530249904;
				switch (num3 == num)
				{
				}
				num = (short)1770258433;
				if (num != 0)
				{
				}
				num = (short)805044224;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.Value = value;
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x0039876C File Offset: 0x0039696C
		// (set) Token: 0x06003DC6 RID: 15814 RVA: 0x00398820 File Offset: 0x00396A20
		public string RadCfgLocationReporting_UIValue
		{
			get
			{
				short num = (short)730726400;
				short num2 = num;
				num = (short)363106335;
				short num3 = num;
				num = (short)1033801759;
				switch (num3 == num)
				{
				}
				num = (short)1286733825;
				if (num != 0)
				{
				}
				num = (short)137363456;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.UIValue;
			}
			set
			{
				short num = (short)1949368320;
				short num2 = num;
				num = (short)1063067976;
				short num3 = num;
				num = (short)1084170568;
				switch (num3 == num)
				{
				}
				num = (short)284819457;
				if (num != 0)
				{
				}
				num = (short)1452933120;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.UIValue = value;
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x003988D4 File Offset: 0x00396AD4
		public global::AcpBusinessLayer.AcpListField RadCfgLocationReporting
		{
			get
			{
				short num = (short)564658176;
				short num2 = num;
				num = (short)1376256001;
				if (num != 0)
				{
				}
				num = (short)1306443110;
				short num3 = num;
				num = (short)796441958;
				switch (num3 == num)
				{
				}
				num = (short)140115968;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting;
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x00398984 File Offset: 0x00396B84
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x00398A3C File Offset: 0x00396C3C
		public bool RadCfgLocationReporting_Applicable
		{
			get
			{
				short num = (short)1604255744;
				short num2 = num;
				num = (short)1591730509;
				short num3 = num;
				num = (short)926146893;
				switch (num3 == num)
				{
				}
				num = (short)597426177;
				if (num != 0)
				{
				}
				num = (short)2134573056;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.Applicable;
			}
			set
			{
				short num = (short)1039269888;
				short num2 = num;
				num = (short)969807846;
				short num3 = num;
				num = (short)1448482790;
				switch (num3 == num)
				{
				}
				num = (short)1170866177;
				if (num != 0)
				{
				}
				num = (short)143589376;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.Applicable = value;
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x00398AF0 File Offset: 0x00396CF0
		// (set) Token: 0x06003DCB RID: 15819 RVA: 0x00398BA0 File Offset: 0x00396DA0
		public bool RadCfgLocationReporting_Valid
		{
			get
			{
				short num = (short)460062720;
				short num2 = num;
				num = (short)1275587302;
				short num3 = num;
				num = (short)2058283750;
				switch (num3 == num)
				{
				}
				num = (short)1512636416;
				if (num != 0)
				{
				}
				num = (short)694616065;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.Valid;
			}
			set
			{
				short num = (short)1601372160;
				short num2 = num;
				num = (short)342228993;
				if (num != 0)
				{
				}
				num = (short)499633540;
				short num3 = num;
				num = (short)497732996;
				switch (num3 == num)
				{
				}
				num = (short)299499520;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.Valid = value;
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06003DCC RID: 15820 RVA: 0x00398C58 File Offset: 0x00396E58
		// (set) Token: 0x06003DCD RID: 15821 RVA: 0x00398D0C File Offset: 0x00396F0C
		public bool RadCfgLocationReporting_Visible
		{
			get
			{
				short num = (short)1597440000;
				short num2 = num;
				num = (short)451734919;
				short num3 = num;
				num = (short)1222110599;
				switch (num3 == num)
				{
				}
				num = (short)1433993216;
				if (num != 0)
				{
				}
				num = (short)1520631809;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.Visible;
			}
			set
			{
				short num = (short)1042677760;
				short num2 = num;
				num = (short)432446101;
				short num3 = num;
				num = (short)2028640917;
				switch (num3 == num)
				{
				}
				num = (short)113704961;
				if (num != 0)
				{
				}
				num = (short)51970048;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.Visible = value;
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x00398DC4 File Offset: 0x00396FC4
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x00398E7C File Offset: 0x0039707C
		public bool RadCfgLocationReporting_Editable
		{
			get
			{
				short num = (short)95420416;
				short num2 = num;
				num = (short)1428357121;
				if (num != 0)
				{
				}
				num = (short)1416904693;
				short num3 = num;
				num = (short)1089421301;
				switch (num3 == num)
				{
				}
				num = (short)817561600;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.Editable;
			}
			set
			{
				short num = (short)2007564288;
				short num2 = num;
				num = (short)1620406485;
				short num3 = num;
				num = (short)1034121429;
				switch (num3 == num)
				{
				}
				num = (short)377421825;
				if (num != 0)
				{
				}
				num = (short)2085683200;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.Editable = value;
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x00398F30 File Offset: 0x00397130
		internal string RadCfgLocationReporting_UILabel
		{
			get
			{
				short num = (short)350683136;
				short num2 = num;
				num = (short)1561817109;
				short num3 = num;
				num = (short)412774421;
				switch (num3 == num)
				{
				}
				num = (short)349503488;
				if (num != 0)
				{
				}
				num = (short)885260289;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.UIName;
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x00398FE4 File Offset: 0x003971E4
		// (set) Token: 0x06003DD2 RID: 15826 RVA: 0x0039909C File Offset: 0x0039729C
		internal bool RadCfgLocationReporting_HiddenStatic
		{
			get
			{
				short num = (short)1611268096;
				short num2 = num;
				num = (short)1013362036;
				short num3 = num;
				num = (short)460434804;
				switch (num3 == num)
				{
				}
				num = (short)390266881;
				if (num != 0)
				{
				}
				num = (short)1394671616;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.HiddenStatic;
			}
			set
			{
				short num = (short)1847721984;
				short num2 = num;
				num = (short)1191434496;
				short num3 = num;
				num = (short)550951168;
				switch (num3 == num)
				{
				}
				num = (short)573046785;
				if (num != 0)
				{
				}
				num = (short)776077312;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.HiddenStatic = value;
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x00399150 File Offset: 0x00397350
		// (set) Token: 0x06003DD4 RID: 15828 RVA: 0x00399204 File Offset: 0x00397404
		internal bool RadCfgLocationReporting_HiddenDynamic
		{
			get
			{
				short num = (short)1085734912;
				short num2 = num;
				num = (short)581319397;
				short num3 = num;
				num = (short)803224293;
				switch (num3 == num)
				{
				}
				num = (short)1406599169;
				if (num != 0)
				{
				}
				num = (short)1699872768;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting.HiddenDynamic;
			}
			set
			{
				short num = (short)523632640;
				short num2 = num;
				num = (short)226230273;
				if (num != 0)
				{
				}
				num = (short)788304015;
				short num3 = num;
				num = (short)1999212687;
				switch (num3 == num)
				{
				}
				num = (short)229244928;
				if (num != 0)
				{
				}
				this.radCfgLocationReporting.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x003992BC File Offset: 0x003974BC
		public bool RadCfgLocationReporting_HasDiffs
		{
			get
			{
				short num = (short)2123366400;
				short num2 = num;
				num = (short)1995716264;
				short num3 = num;
				num = (short)1120417448;
				switch (num3 == num)
				{
				}
				num = (short)726794241;
				if (num != 0)
				{
				}
				num = (short)1272709120;
				if (num != 0)
				{
				}
				return this.radCfgLocationReporting._HasDiffs;
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x00399370 File Offset: 0x00397570
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems RefMenuItems
		{
			get
			{
				short num = (short)1942749184;
				short num2 = num;
				num = (short)479634952;
				short num3 = num;
				num = (short)958506504;
				switch (num3 == num)
				{
				}
				num = (short)1250361345;
				if (num != 0)
				{
				}
				num = (short)1367539712;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2088)[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00399430 File Offset: 0x00397630
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)211484672;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)831389697;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num = (short)820969476;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_B0;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)795148290;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (base.ParentRecset.ContainerDoc == null)
						{
							return result;
						}
						num = (short)916564329;
						short num4 = num;
						num = (short)2135665001;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1263403008;
							if (num != 0)
							{
							}
							num = (short)457900035;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_4D:
				result = null;
				num = (short)2058813440;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_B0:
			num = (short)312147969;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0400120E RID: 4622
		private global::AcpBusinessLayer.AcpField<bool> radWideLocationLocationEnable_A8448;

		// Token: 0x0400120F RID: 4623
		private global::AcpBusinessLayer.AcpRangeField<int, int> radWideLocationMaxStoredLocationRequests_A8473;

		// Token: 0x04001210 RID: 4624
		private global::AcpBusinessLayer.AcpField<bool> radWideLocationUserSelectableLocationEnable_A9605;

		// Token: 0x04001211 RID: 4625
		private global::AcpBusinessLayer.AcpListField radWideLocationDistanceUnit_A13080;

		// Token: 0x04001212 RID: 4626
		private global::AcpBusinessLayer.AcpField<bool> radWideLocationExitLocationMenuonPTT_A13081;

		// Token: 0x04001213 RID: 4627
		private global::AcpBusinessLayer.AcpListField radWideLocationGpsMode_A22627;

		// Token: 0x04001214 RID: 4628
		private global::AcpBusinessLayer.AcpListField radWideLocationDisplayFormat_A41561;

		// Token: 0x04001215 RID: 4629
		private global::AcpBusinessLayer.AcpSimpleRangeField gPSFailToneInterval_42329;

		// Token: 0x04001216 RID: 4630
		private global::AcpBusinessLayer.AcpField<bool> radWideLocP25LocationReporting_42412;

		// Token: 0x04001217 RID: 4631
		private global::AcpBusinessLayer.AcpField<bool> radWideLocationDisplayPeerLocation_42433;

		// Token: 0x04001218 RID: 4632
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACMissionCriticalGeofenceMode_42918;

		// Token: 0x04001219 RID: 4633
		private global::AcpBusinessLayer.AcpField<bool> radWideLocationSystemManagedGeofence_43042;

		// Token: 0x0400121A RID: 4634
		private global::AcpBusinessLayer.AcpListField radWideFeaturesMapping;

		// Token: 0x0400121B RID: 4635
		private global::AcpBusinessLayer.AcpField<bool> radWideSmartMappingServerAssistedLocation;

		// Token: 0x0400121C RID: 4636
		private global::AcpBusinessLayer.AcpListField radWideReverseGeocodedLocationDisplayFormat;

		// Token: 0x0400121D RID: 4637
		private global::AcpBusinessLayer.AcpListField radCfgLocationReporting;
	}
}
