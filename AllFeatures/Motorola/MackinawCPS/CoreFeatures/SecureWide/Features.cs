using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E5 RID: 229
	[global::System.Serializable]
	public class Features : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001F94 RID: 8084 RVA: 0x001F7884 File Offset: 0x001F5A84
		public Features(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x001F78A0 File Offset: 0x001F5AA0
		protected Features(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x001F78B8 File Offset: 0x001F5AB8
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1872407418;
			short num2 = num;
			num = (short)1619045242;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1469972480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)218497024;
			if (num != 0)
			{
			}
			num = (short)205651969;
			if (num != 0)
			{
			}
			this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭맯闱髳駵諷鿹꿻鯽揿省瘃挅䬇昉椋漍戏䄑挓缕気礙琛䤝䠟䜡䨣甥尧堩䴫席䀯圱倳椵礷ȹ฻ഽ砿", a_), global::CommonResources.AcgResources.ID_IGNORESECURECLEARSWITCHWHENSTRAPPED);
			this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.DataTransferOrder = 9;
			this.secWideFeaturesInfiniteKeyRetention_A8292 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭맯鳱鋳鿵雷鏹裻鯽䯿朁紃吅洇縉椋怍搏笑笓砕䜗嬙␛Ⱍ᤟အ", a_), global::CommonResources.AcgResources.ID_INFINITEKEYRETENTION);
			this.secWideFeaturesInfiniteKeyRetention_A8292.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideFeaturesInfiniteKeyRetention_A8292.DataTransferOrder = 20;
			this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭뻯鷱髳껵듷꧹鿻鿽滿圁樃甅礇缉椋戍猏稑倓挕樗笙栛眝伟䰡䤣唥眧欩ᐫᬭܯȱ", a_), global::CommonResources.AcgResources.ID_NONXLSCANUNSQUELCHDURATIONMS, 0, 255, null, null, 0, 25);
			this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.DataTransferOrder = 21;
			this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.ShowHexValue = false;
			this.secWideFeaturesPeriodicKeyfailAlertTone_A8695 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭ꃯ韱蛳鿵韷黹闻鷽䯿朁紃怅椇按怋伍簏眑易戕䰗甙爛笝缟挡ᰣဥᄧἩ", a_), global::CommonResources.AcgResources.ID_PERIODICKEYFAILALERTTONE);
			this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.DataTransferOrder = 12;
			this.secWideFeaturesProperCodeEnhancer_A8764 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭ꃯ胱鯳蛵鷷裹뿻釽擿朁䄃栅怇欉戋洍甏怑䬓圕‗ⴙ⨛⨝", a_), global::CommonResources.AcgResources.ID_PROPERCODEENHANCER);
			this.secWideFeaturesProperCodeEnhancer_A8764.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.secWideFeaturesProperCodeEnhancer_A8764.DataTransferOrder = 13;
			this.secWideFeaturesClearAlertTones_A9524 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭돯黱釳韵諷믹郻鯽狿瘁倃椅昇漉缋儍儏⬑ℓ␕Ⱇ", a_), global::CommonResources.AcgResources.ID_CLEARALERTTONES, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideFeaturesClearAlertTones_A9524LovStrs);
			this.secWideFeaturesClearAlertTones_A9524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideFeaturesClearAlertTones_A9524.DataTransferOrder = 15;
			this.secWideFeaturesXLScanUnsquelchDurationMs_A9682 = new global::AcpBusinessLayer.AcpSimpleRangeField(35, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭꣯뻱ꟳ闵駷铹ꧻ都珿猁焃挅搇椉搋䨍攏怑甓戕焗甙爛匝匟紡攣ἥḧሩḫ", a_), global::CommonResources.AcgResources.ID_XLSCANUNSQUELCHDURATIONMS, 0, 255, null, null, 0, 25);
			this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.DataTransferOrder = 23;
			this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.ShowHexValue = false;
			this.secWideInfiniteUKEKRetention_A41551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝꧟賡苣迥蛧菩飫语ꗯ맱뇳뷵꫷鿹裻鯽滿瘁洃椅昇唉䴋㨍ℏ✑ℓ✕", a_), global::CommonResources.AcgResources.ID_INFINITEUKEKRETENTION);
			this.secWideInfiniteUKEKRetention_A41551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideInfiniteUKEKRetention_A41551.DataTransferOrder = 46;
			this.secWideFeaturesDisableHardKeyZeroize_A43046 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꛟ蟡藣鋥鷧飩觫鷭듯鯱蟳韵髷雹駻뛽懿瀁怃䴅洇猉嘋欍戏紑紓氕紗䔙崛⨝ጟሡဣဥ", a_), global::CommonResources.AcgResources.ID_DISABLEHARDKEYZEROIZE);
			this.secWideFeaturesDisableHardKeyZeroize_A43046.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.secWideFeaturesDisableHardKeyZeroize_A43046.DataTransferOrder = 48;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铑뇓럕곗꿙껛믝鏟", a_);
			base.Id = 10046;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x001F7BD4 File Offset: 0x001F5DD4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)530841615;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧뫩黫臭胯韱蛳뗵韷黹駻믽滿樁攃栅欇漉縋儍儏⨑⌓―Ⱇ", a_)))
					{
						num = (short)231997459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E2;
				case 1:
					this.secWideFeaturesInfiniteKeyRetention_A8292 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꏩ苫裭駯鳱鷳苵鷷뇹駻蟽勿朁瀃挅昇縉攋愍縏䴑唓⸕⨗⌙⸛", a_), global::CommonResources.AcgResources.ID_INFINITEKEYRETENTION);
					this.secWideFeaturesInfiniteKeyRetention_A8292.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideFeaturesInfiniteKeyRetention_A8292.DataTransferOrder = 20;
					num = (short)330235922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鏙닛룝觟賡跣鋥跧뿩꟫꯭믯ꃱ釳苵鷷铹裻韽濿氁嬃䜅㰇㬉㤋㬍ℏ", a_)))
					{
						num = (short)1694171146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E2;
				case 3:
					this.secWideFeaturesClearAlertTones_A9524 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꧩ胫语釯胱뗳髵鷷裹裻꫽濿氁愃甅圇䬉㔋㬍∏☑", a_), global::CommonResources.AcgResources.ID_CLEARALERTTONES, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideFeaturesClearAlertTones_A9524LovStrs);
					this.secWideFeaturesClearAlertTones_A9524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideFeaturesClearAlertTones_A9524.DataTransferOrder = 15;
					num = (short)406388763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)439154131;
					short num3 = num;
					num = (short)2105931219;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25C;
					default:
						num = (short)796655616;
						if (num != 0)
						{
						}
						this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570 = new global::AcpBusinessLayer.AcpSimpleRangeField(11, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꓩ菫胭꣯뻱ꟳ闵駷铹ꧻ都珿猁焃挅搇椉搋䨍攏怑甓戕焗甙爛猝匟紡攣ḥᴧᴩᰫ", a_), global::CommonResources.AcgResources.ID_NONXLSCANUNSQUELCHDURATIONMS, null, null, 0, 25);
						this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.DataTransferOrder = 21;
						this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.ShowHexValue = false;
						num = (short)164167701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧껩藫鷭釯郱飳鏵냷鯹軻髽䯿朁紃尅洇砉挋服樏眑䬓圕Ⱇ⤙Ⱋ⨝ᘟ", a_)))
					{
						num = (short)1418657809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_785;
				case 6:
					this.secWideFeaturesPeriodicKeyfailAlertTone_A8695 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧뫩觫鳭駯鷱郳鿵鯷뇹駻蟽替持洃樅䤇昉椋簍搏䘑笓砕紗䔙崛☝ᘟᬡᄣ", a_), global::CommonResources.AcgResources.ID_PERIODICKEYFAILALERTTONE);
					this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.DataTransferOrder = 12;
					num = (short)1330184203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧뫩觫鳭駯鷱郳鿵鯷뇹駻蟽替持洃樅䤇昉椋簍搏䘑笓砕紗䔙崛☝ᘟᬡᄣ", a_)))
					{
						num = (short)2082865158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_331;
				case 8:
					num = (short)629604368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.secWideFeaturesXLScanUnsquelchDurationMs_A9682 = new global::AcpBusinessLayer.AcpSimpleRangeField(35, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧닩ꃫ뷭鏯鏱髳ꏵ雷觹跻诽旿渁會清䰇缉縋漍搏笑笓砕唗椙䌛弝᤟ᐡᰣᐥ", a_), global::CommonResources.AcgResources.ID_XLSCANUNSQUELCHDURATIONMS, null, null, 0, 25);
					this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.DataTransferOrder = 23;
					this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.ShowHexValue = false;
					num = (short)2119630868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.secWideInfiniteUKEKRetention_A41551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鏙닛룝觟賡跣鋥跧뿩꟫꯭믯ꃱ釳苵鷷铹裻韽濿氁嬃䜅㰇㬉㤋㬍ℏ", a_), global::CommonResources.AcgResources.ID_INFINITEUKEKRETENTION);
					this.secWideInfiniteUKEKRetention_A41551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideInfiniteUKEKRetention_A41551.DataTransferOrder = 46;
					num = (short)1419968538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_331;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꧩ胫语釯胱뗳髵鷷裹裻꫽濿氁愃甅圇䬉㔋㬍∏☑", a_)))
					{
						num = (short)1244790787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 13:
					num = (short)1106116632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꏩ诫胭鿯胱釳ꗵ鷷駹觻賽旿䄁栃挅椇砉弋礍礏昑眓縕众爙礛瀝猟嘡嘣䜥堧娩䤫䨭漯猱ళеଷȹ", a_), global::CommonResources.AcgResources.ID_IGNORESECURECLEARSWITCHWHENSTRAPPED);
					this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.DataTransferOrder = 9;
					num = (short)1892483097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꏩ诫胭鿯胱釳ꗵ鷷駹觻賽旿䄁栃挅椇砉弋礍礏昑眓縕众爙礛瀝猟嘡嘣䜥堧娩䤫䨭漯猱ళеଷȹ", a_)))
					{
						num = (short)174063616;
						short num4 = num;
						num = (short)1386676238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 17:
					this.secWideFeaturesDisableHardKeyZeroize_A43046 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧껩藫鷭釯郱飳鏵냷鯹軻髽䯿朁紃尅洇砉挋服樏眑䬓圕Ⱇ⤙Ⱋ⨝ᘟ", a_), global::CommonResources.AcgResources.ID_DISABLEHARDKEYZEROIZE);
					this.secWideFeaturesDisableHardKeyZeroize_A43046.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.secWideFeaturesDisableHardKeyZeroize_A43046.DataTransferOrder = 48;
					num = (short)1939669021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_568;
				case 19:
					this.secWideFeaturesProperCodeEnhancer_A8764 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧뫩黫臭胯韱蛳뗵韷黹駻믽滿樁攃栅欇漉縋儍儏⨑⌓―Ⱇ", a_), global::CommonResources.AcgResources.ID_PROPERCODEENHANCER);
					this.secWideFeaturesProperCodeEnhancer_A8764.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.secWideFeaturesProperCodeEnhancer_A8764.DataTransferOrder = 13;
					num = (short)463142935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_1C0;
				case 21:
					goto IL_62D;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧닩ꃫ뷭鏯鏱髳ꏵ雷觹跻诽旿渁會清䰇缉縋漍搏笑笓砕唗椙䌛弝᤟ᐡᰣᐥ", a_)))
					{
						num = (short)704184329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 23:
					goto IL_6E2;
				case 24:
					if (producerFields != null)
					{
						num = (short)24117256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_785;
				case 25:
					goto IL_25C;
				case 26:
					goto IL_2E2;
				case 27:
					goto IL_D0;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꓩ菫胭꣯뻱ꟳ闵駷铹ꧻ都珿猁焃挅搇椉搋䨍攏怑甓戕焗甙爛猝匟紡攣ḥᴧᴩᰫ", a_)))
					{
						num = (short)172032004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62D;
				case 29:
					goto IL_47A;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋ꯍ돏藑뷓닕뷗鳙맛뿝铟韡難菥鯧ꏩ苫裭駯鳱鷳苵鷷뇹駻蟽勿朁瀃挅昇縉攋愍縏䴑唓⸕⨗⌙⸛", a_)))
					{
						num = (short)1135673345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_568;
				}
				IL_AA:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1854472205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D0:
				num = (short)418316310;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_173:
				num = (short)2145255454;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25C:
				num = (short)606994433;
				if (num != 0)
				{
				}
				goto IL_173;
				IL_1C0:
				num = (short)639434754;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E2:
				num = (short)1685520389;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_331:
				num = (short)1757675520;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_568:
				num = (short)849084444;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62D:
				num = (short)684261383;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6E2:
				num = (short)620429324;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_47A:
			IL_785:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("請ꯍ뇏ꛑꇓꓕ뷗꧙", a_);
			base.Id = 10046;
			base.UIName = global::CommonResources.AcgResources.ID_FEATURES;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x001F8398 File Offset: 0x001F6598
		public override void PopulateReferences()
		{
			short num = (short)1111208006;
			short num2 = num;
			num = (short)1105440838;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1148387328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)184352769;
			if (num != 0)
			{
			}
			num = (short)885325824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x001F8444 File Offset: 0x001F6644
		public override void DropReferences()
		{
			short num = (short)711629319;
			short num2 = num;
			num = (short)1692572167;
			switch (num2 == num)
			{
			default:
			{
				num = (short)25034752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1029636097;
			if (num != 0)
			{
			}
			num = (short)926220288;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x001F84F0 File Offset: 0x001F66F0
		public override void SetConstraints()
		{
			short num = (short)622473777;
			short num2 = num;
			num = (short)1196241457;
			switch (num2 == num)
			{
			default:
			{
				num = (short)981532672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)740491265;
			if (num != 0)
			{
			}
			num = (short)524746752;
			if (num != 0)
			{
			}
			this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conIgnoreTmssWhenStrapd);
			this.secWideFeaturesInfiniteKeyRetention_A8292.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conSecOperationIsNotDisabled);
			this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideFeaturesProperCodeEnhancer_A8764.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secWideFeaturesProperCodeEnhancer_A8764.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSetToInVisible);
			this.secWideFeaturesClearAlertTones_A9524.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideFeaturesClearAlertTones_A9524.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConClearRxAlertToneBasedOnTacticalInhibit);
			this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secWideFeaturesDisableHardKeyZeroize_A43046.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConDisableHardKeyZeroizeIsApp);
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x001F8680 File Offset: 0x001F6880
		public override void SetupDependencies()
		{
			short num = (short)1490178620;
			short num2 = num;
			num = (short)1439781436;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1997733888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)698089472;
			if (num != 0)
			{
			}
			num = (short)2020737025;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesInfiniteKeyRetention_A8292);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesPeriodicKeyfailAlertTone_A8695);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesProperCodeEnhancer_A8764);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesClearAlertTones_A9524);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.secWideFeaturesClearAlertTones_A9524);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesXLScanUnsquelchDurationMs_A9682);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideFeaturesDisableHardKeyZeroize_A43046);
			this.secWideFeaturesInfiniteKeyRetention_A8292.AddDependentObject(this.secWideFeaturesDisableHardKeyZeroize_A43046);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.secWideFeaturesDisableHardKeyZeroize_A43046);
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x001F8834 File Offset: 0x001F6A34
		public bool HasDiffs
		{
			get
			{
				short num = (short)1439267427;
				short num2 = num;
				num = (short)75135587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)489619456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)418250753;
				if (num != 0)
				{
				}
				num = (short)1463484416;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x001F88E4 File Offset: 0x001F6AE4
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x001F899C File Offset: 0x001F6B9C
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238Value
		{
			get
			{
				short num = (short)312091604;
				short num2 = num;
				num = (short)1776690132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1827864576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1623851008;
				if (num != 0)
				{
				}
				num = (short)1366360065;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Value;
			}
			set
			{
				short num = (short)1736377389;
				short num2 = num;
				num = (short)266404909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)931987456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)896532480;
				if (num != 0)
				{
				}
				num = (short)2140602369;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Value = value;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x001F8A50 File Offset: 0x001F6C50
		public global::AcpBusinessLayer.AcpField<bool> SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238
		{
			get
			{
				short num = (short)1488125952;
				short num2 = num;
				num = (short)1150097874;
				short num3 = num;
				num = (short)2135497170;
				switch (num3 == num)
				{
				}
				num = (short)954728449;
				if (num != 0)
				{
				}
				num = (short)355598336;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x001F8B00 File Offset: 0x001F6D00
		// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x001F8BB4 File Offset: 0x001F6DB4
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_UIValue
		{
			get
			{
				short num = (short)462094336;
				short num2 = num;
				num = (short)1703321015;
				short num3 = num;
				num = (short)1163566519;
				switch (num3 == num)
				{
				}
				num = (short)355139584;
				if (num != 0)
				{
				}
				num = (short)1220542465;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Value;
			}
			set
			{
				short num = (short)2102132736;
				short num2 = num;
				num = (short)445635128;
				short num3 = num;
				num = (short)1416419896;
				switch (num3 == num)
				{
				}
				num = (short)27394048;
				if (num != 0)
				{
				}
				num = (short)599982081;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Value = value;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x001F8C6C File Offset: 0x001F6E6C
		// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x001F8D24 File Offset: 0x001F6F24
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_Applicable
		{
			get
			{
				short num = (short)1204879360;
				short num2 = num;
				num = (short)1007530850;
				short num3 = num;
				num = (short)1840493410;
				switch (num3 == num)
				{
				}
				num = (short)1263403009;
				if (num != 0)
				{
				}
				num = (short)1685782528;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Applicable;
			}
			set
			{
				short num = (short)1099366400;
				short num2 = num;
				num = (short)1067677807;
				short num3 = num;
				num = (short)286095471;
				switch (num3 == num)
				{
				}
				num = (short)1255538689;
				if (num != 0)
				{
				}
				num = (short)1886060544;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Applicable = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x001F8DDC File Offset: 0x001F6FDC
		// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x001F8E90 File Offset: 0x001F7090
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_Valid
		{
			get
			{
				short num = (short)1349124096;
				short num2 = num;
				num = (short)1356543215;
				short num3 = num;
				num = (short)2079995119;
				switch (num3 == num)
				{
				}
				num = (short)1567883264;
				if (num != 0)
				{
				}
				num = (short)1137180673;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Valid;
			}
			set
			{
				short num = (short)1826160640;
				short num2 = num;
				num = (short)93650945;
				if (num != 0)
				{
				}
				num = (short)1206346008;
				short num3 = num;
				num = (short)391340312;
				switch (num3 == num)
				{
				}
				num = (short)48431104;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Valid = value;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x001F8F48 File Offset: 0x001F7148
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x001F8FFC File Offset: 0x001F71FC
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_Visible
		{
			get
			{
				short num = (short)2008875008;
				short num2 = num;
				num = (short)1925054653;
				short num3 = num;
				num = (short)1966604477;
				switch (num3 == num)
				{
				}
				num = (short)1366818817;
				if (num != 0)
				{
				}
				num = (short)220856320;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Visible;
			}
			set
			{
				short num = (short)1835073536;
				short num2 = num;
				num = (short)365734872;
				short num3 = num;
				num = (short)230927320;
				switch (num3 == num)
				{
				}
				num = (short)1469513728;
				if (num != 0)
				{
				}
				num = (short)612171777;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Visible = value;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x001F90B0 File Offset: 0x001F72B0
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x001F9164 File Offset: 0x001F7364
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_Editable
		{
			get
			{
				short num = (short)357040128;
				short num2 = num;
				num = (short)667942913;
				if (num != 0)
				{
				}
				num = (short)1976737374;
				short num3 = num;
				num = (short)1420009054;
				switch (num3 == num)
				{
				}
				num = (short)325582848;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Editable;
			}
			set
			{
				short num = (short)579600384;
				short num2 = num;
				num = (short)234946561;
				if (num != 0)
				{
				}
				num = (short)597235290;
				short num3 = num;
				num = (short)595531354;
				switch (num3 == num)
				{
				}
				num = (short)1602682880;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.Editable = value;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x001F9218 File Offset: 0x001F7418
		internal string SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_UILabel
		{
			get
			{
				short num = (short)1067188224;
				short num2 = num;
				num = (short)794396287;
				short num3 = num;
				num = (short)1452639871;
				switch (num3 == num)
				{
				}
				num = (short)852099073;
				if (num != 0)
				{
				}
				num = (short)1127022592;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.UIName;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x001F92CC File Offset: 0x001F74CC
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x001F9384 File Offset: 0x001F7584
		internal bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_HiddenStatic
		{
			get
			{
				short num = (short)1368064000;
				short num2 = num;
				num = (short)1976030215;
				short num3 = num;
				num = (short)1795937287;
				switch (num3 == num)
				{
				}
				num = (short)1017184257;
				if (num != 0)
				{
				}
				num = (short)1325924352;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.HiddenStatic;
			}
			set
			{
				short num = (short)242024448;
				short num2 = num;
				num = (short)652755947;
				short num3 = num;
				num = (short)17908715;
				switch (num3 == num)
				{
				}
				num = (short)1874264065;
				if (num != 0)
				{
				}
				num = (short)760479744;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.HiddenStatic = value;
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x001F943C File Offset: 0x001F763C
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x001F94F0 File Offset: 0x001F76F0
		internal bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_HiddenDynamic
		{
			get
			{
				short num = (short)584646656;
				short num2 = num;
				num = (short)1718568915;
				short num3 = num;
				num = (short)411584467;
				switch (num3 == num)
				{
				}
				num = (short)128253953;
				if (num != 0)
				{
				}
				num = (short)174653440;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.HiddenDynamic;
			}
			set
			{
				short num = (short)554500096;
				short num2 = num;
				num = (short)1740163316;
				short num3 = num;
				num = (short)1809434868;
				switch (num3 == num)
				{
				}
				num = (short)1820196865;
				if (num != 0)
				{
				}
				num = (short)1485832192;
				if (num != 0)
				{
				}
				this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x001F95A8 File Offset: 0x001F77A8
		public bool SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238_HasDiffs
		{
			get
			{
				short num = (short)244776960;
				short num2 = num;
				num = (short)471133818;
				short num3 = num;
				num = (short)1060367994;
				switch (num3 == num)
				{
				}
				num = (short)875626496;
				if (num != 0)
				{
				}
				num = (short)1624637441;
				if (num != 0)
				{
				}
				return this.secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238._HasDiffs;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x001F9660 File Offset: 0x001F7860
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x001F9718 File Offset: 0x001F7918
		public bool SecWideFeaturesInfiniteKeyRetention_A8292Value
		{
			get
			{
				short num = (short)1014169600;
				short num2 = num;
				num = (short)880807094;
				short num3 = num;
				num = (short)587861174;
				switch (num3 == num)
				{
				}
				num = (short)611254273;
				if (num != 0)
				{
				}
				num = (short)78315520;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.Value;
			}
			set
			{
				short num = (short)976093184;
				short num2 = num;
				num = (short)1624086205;
				short num3 = num;
				num = (short)396400317;
				switch (num3 == num)
				{
				}
				num = (short)1545535488;
				if (num != 0)
				{
				}
				num = (short)387776513;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.Value = value;
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x001F97D0 File Offset: 0x001F79D0
		public global::AcpBusinessLayer.AcpField<bool> SecWideFeaturesInfiniteKeyRetention_A8292
		{
			get
			{
				short num = (short)1800339456;
				short num2 = num;
				num = (short)1684071906;
				short num3 = num;
				num = (short)1057154530;
				switch (num3 == num)
				{
				}
				num = (short)1196425217;
				if (num != 0)
				{
				}
				num = (short)1714290688;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x001F9880 File Offset: 0x001F7A80
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x001F9934 File Offset: 0x001F7B34
		public bool SecWideFeaturesInfiniteKeyRetention_A8292_UIValue
		{
			get
			{
				short num = (short)921305088;
				short num2 = num;
				num = (short)1146489272;
				short num3 = num;
				num = (short)348195256;
				switch (num3 == num)
				{
				}
				num = (short)1386348545;
				if (num != 0)
				{
				}
				num = (short)429719552;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.Value;
			}
			set
			{
				short num = (short)9175040;
				short num2 = num;
				num = (short)652579827;
				short num3 = num;
				num = (short)1163564019;
				switch (num3 == num)
				{
				}
				num = (short)1065811969;
				if (num != 0)
				{
				}
				num = (short)107741184;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.Value = value;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x001F99E8 File Offset: 0x001F7BE8
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x001F9AA0 File Offset: 0x001F7CA0
		public bool SecWideFeaturesInfiniteKeyRetention_A8292_Applicable
		{
			get
			{
				short num = (short)835125248;
				short num2 = num;
				num = (short)1420951579;
				short num3 = num;
				num = (short)1517944859;
				switch (num3 == num)
				{
				}
				num = (short)766050304;
				if (num != 0)
				{
				}
				num = (short)845742081;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.Applicable;
			}
			set
			{
				short num = (short)1034092544;
				short num2 = num;
				num = (short)679728027;
				short num3 = num;
				num = (short)946721691;
				switch (num3 == num)
				{
				}
				num = (short)1689124864;
				if (num != 0)
				{
				}
				num = (short)1794310145;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.Applicable = value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x001F9B54 File Offset: 0x001F7D54
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x001F9C08 File Offset: 0x001F7E08
		public bool SecWideFeaturesInfiniteKeyRetention_A8292_Valid
		{
			get
			{
				short num = (short)125632512;
				short num2 = num;
				num = (short)1425539358;
				short num3 = num;
				num = (short)1421082910;
				switch (num3 == num)
				{
				}
				num = (short)870645761;
				if (num != 0)
				{
				}
				num = (short)512622592;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.Valid;
			}
			set
			{
				short num = (short)291110912;
				short num2 = num;
				num = (short)801832961;
				if (num != 0)
				{
				}
				num = (short)153850440;
				short num3 = num;
				num = (short)1254462024;
				switch (num3 == num)
				{
				}
				num = (short)1649672192;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.Valid = value;
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x001F9CBC File Offset: 0x001F7EBC
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x001F9D70 File Offset: 0x001F7F70
		public bool SecWideFeaturesInfiniteKeyRetention_A8292_Visible
		{
			get
			{
				short num = (short)1190985728;
				short num2 = num;
				num = (short)396496938;
				short num3 = num;
				num = (short)2088177706;
				switch (num3 == num)
				{
				}
				num = (short)1030488064;
				if (num != 0)
				{
				}
				num = (short)1713307649;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.Visible;
			}
			set
			{
				short num = (short)423559168;
				short num2 = num;
				num = (short)184559467;
				short num3 = num;
				num = (short)2090936171;
				switch (num3 == num)
				{
				}
				num = (short)972292096;
				if (num != 0)
				{
				}
				num = (short)342360065;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.Visible = value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x001F9E2C File Offset: 0x001F802C
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x001F9EE0 File Offset: 0x001F80E0
		public bool SecWideFeaturesInfiniteKeyRetention_A8292_Editable
		{
			get
			{
				short num = (short)426508288;
				short num2 = num;
				num = (short)1607501498;
				short num3 = num;
				num = (short)406619834;
				switch (num3 == num)
				{
				}
				num = (short)1863450625;
				if (num != 0)
				{
				}
				num = (short)681967616;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.Editable;
			}
			set
			{
				short num = (short)1182924800;
				short num2 = num;
				num = (short)1962991407;
				short num3 = num;
				num = (short)190963503;
				switch (num3 == num)
				{
				}
				num = (short)640942081;
				if (num != 0)
				{
				}
				num = (short)1187446784;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.Editable = value;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x001F9F94 File Offset: 0x001F8194
		internal string SecWideFeaturesInfiniteKeyRetention_A8292_UILabel
		{
			get
			{
				short num = (short)1682046976;
				short num2 = num;
				num = (short)1060466150;
				short num3 = num;
				num = (short)41381350;
				switch (num3 == num)
				{
				}
				num = (short)621871105;
				if (num != 0)
				{
				}
				num = (short)167706624;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.UIName;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x001FA04C File Offset: 0x001F824C
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x001FA100 File Offset: 0x001F8300
		internal bool SecWideFeaturesInfiniteKeyRetention_A8292_HiddenStatic
		{
			get
			{
				short num = (short)663683072;
				short num2 = num;
				num = (short)1197408257;
				if (num != 0)
				{
				}
				num = (short)229012026;
				short num3 = num;
				num = (short)752382522;
				switch (num3 == num)
				{
				}
				num = (short)1170735104;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.HiddenStatic;
			}
			set
			{
				short num = (short)1003749376;
				short num2 = num;
				num = (short)281648210;
				short num3 = num;
				num = (short)1877449810;
				switch (num3 == num)
				{
				}
				num = (short)1143996417;
				if (num != 0)
				{
				}
				num = (short)972488704;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.HiddenStatic = value;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x001FA1B8 File Offset: 0x001F83B8
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x001FA26C File Offset: 0x001F846C
		internal bool SecWideFeaturesInfiniteKeyRetention_A8292_HiddenDynamic
		{
			get
			{
				short num = (short)1763377152;
				short num2 = num;
				num = (short)466869445;
				short num3 = num;
				num = (short)1935596741;
				switch (num3 == num)
				{
				}
				num = (short)1383202817;
				if (num != 0)
				{
				}
				num = (short)675938304;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292.HiddenDynamic;
			}
			set
			{
				short num = (short)1703477248;
				short num2 = num;
				num = (short)1390337240;
				short num3 = num;
				num = (short)1063050456;
				switch (num3 == num)
				{
				}
				num = (short)1635778560;
				if (num != 0)
				{
				}
				num = (short)1502674945;
				if (num != 0)
				{
				}
				this.secWideFeaturesInfiniteKeyRetention_A8292.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x001FA324 File Offset: 0x001F8524
		public bool SecWideFeaturesInfiniteKeyRetention_A8292_HasDiffs
		{
			get
			{
				short num = (short)85852160;
				short num2 = num;
				num = (short)30438567;
				short num3 = num;
				num = (short)28669095;
				switch (num3 == num)
				{
				}
				num = (short)1562378240;
				if (num != 0)
				{
				}
				num = (short)1329594369;
				if (num != 0)
				{
				}
				return this.secWideFeaturesInfiniteKeyRetention_A8292._HasDiffs;
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x001FA3D8 File Offset: 0x001F85D8
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x001FA48C File Offset: 0x001F868C
		public int SecWideFeaturesNonXLScanUnsquelchDurationms_A8570Value
		{
			get
			{
				short num = (short)1574371328;
				short num2 = num;
				num = (short)912297468;
				short num3 = num;
				num = (short)1457294844;
				switch (num3 == num)
				{
				}
				num = (short)1183252480;
				if (num != 0)
				{
				}
				num = (short)1986527233;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Value;
			}
			set
			{
				short num = (short)615448576;
				short num2 = num;
				num = (short)1263643344;
				short num3 = num;
				num = (short)1605937872;
				switch (num3 == num)
				{
				}
				num = (short)1836122112;
				if (num != 0)
				{
				}
				num = (short)893452289;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Value = value;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x001FA540 File Offset: 0x001F8740
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideFeaturesNonXLScanUnsquelchDurationms_A8570
		{
			get
			{
				short num = (short)1382285312;
				short num2 = num;
				num = (short)1737558396;
				short num3 = num;
				num = (short)1147406716;
				switch (num3 == num)
				{
				}
				num = (short)1152843777;
				if (num != 0)
				{
				}
				num = (short)257359872;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570;
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x001FA5F0 File Offset: 0x001F87F0
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x001FA6A4 File Offset: 0x001F88A4
		public string SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_UIValue
		{
			get
			{
				short num = (short)1297219584;
				short num2 = num;
				num = (short)1390549062;
				short num3 = num;
				num = (short)1687820358;
				switch (num3 == num)
				{
				}
				num = (short)738459648;
				if (num != 0)
				{
				}
				num = (short)223477761;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.UIValue;
			}
			set
			{
				short num = (short)1256062976;
				short num2 = num;
				num = (short)638838792;
				short num3 = num;
				num = (short)1487857672;
				switch (num3 == num)
				{
				}
				num = (short)930480128;
				if (num != 0)
				{
				}
				num = (short)126877697;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.UIValue = value;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x001FA75C File Offset: 0x001F895C
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x001FA810 File Offset: 0x001F8A10
		internal int SecWideFeaturesNonXLScanUnsquelchDurationms_A8570Min
		{
			get
			{
				short num = (short)176881664;
				short num2 = num;
				num = (short)1581913136;
				short num3 = num;
				num = (short)679023664;
				switch (num3 == num)
				{
				}
				num = (short)884867073;
				if (num != 0)
				{
				}
				num = (short)626655232;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Min;
			}
			set
			{
				short num = (short)589496320;
				short num2 = num;
				num = (short)558188041;
				short num3 = num;
				num = (short)1211581961;
				switch (num3 == num)
				{
				}
				num = (short)375717889;
				if (num != 0)
				{
				}
				num = (short)1074659328;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Min = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x001FA8C8 File Offset: 0x001F8AC8
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x001FA97C File Offset: 0x001F8B7C
		internal int SecWideFeaturesNonXLScanUnsquelchDurationms_A8570Max
		{
			get
			{
				short num = (short)209453056;
				short num2 = num;
				num = (short)1051826237;
				short num3 = num;
				num = (short)990353469;
				switch (num3 == num)
				{
				}
				num = (short)939524097;
				if (num != 0)
				{
				}
				num = (short)246546432;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Max;
			}
			set
			{
				short num = (short)1327235072;
				short num2 = num;
				num = (short)1721446422;
				short num3 = num;
				num = (short)1848127510;
				switch (num3 == num)
				{
				}
				num = (short)2061828097;
				if (num != 0)
				{
				}
				num = (short)1807613952;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Max = value;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x001FAA30 File Offset: 0x001F8C30
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x001FAAE0 File Offset: 0x001F8CE0
		internal int SecWideFeaturesNonXLScanUnsquelchDurationms_A8570Step
		{
			get
			{
				short num = (short)1647640576;
				short num2 = num;
				num = (short)493256227;
				short num3 = num;
				num = (short)1158970915;
				switch (num3 == num)
				{
				}
				num = (short)2088435713;
				if (num != 0)
				{
				}
				num = (short)288948224;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.StepSize;
			}
			set
			{
				short num = (short)1761804288;
				short num2 = num;
				num = (short)508548978;
				short num3 = num;
				num = (short)312924018;
				switch (num3 == num)
				{
				}
				num = (short)118161408;
				if (num != 0)
				{
				}
				num = (short)66519041;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.StepSize = value;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x001FAB94 File Offset: 0x001F8D94
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x001FAC44 File Offset: 0x001F8E44
		public bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_Applicable
		{
			get
			{
				short num = (short)293535744;
				short num2 = num;
				num = (short)1926935015;
				short num3 = num;
				num = (short)605794791;
				switch (num3 == num)
				{
				}
				num = (short)1950744576;
				if (num != 0)
				{
				}
				num = (short)826146817;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Applicable;
			}
			set
			{
				short num = (short)1005256704;
				short num2 = num;
				num = (short)944531570;
				short num3 = num;
				num = (short)1272670322;
				switch (num3 == num)
				{
				}
				num = (short)668467200;
				if (num != 0)
				{
				}
				num = (short)1962147841;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Applicable = value;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x001FACF8 File Offset: 0x001F8EF8
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x001FADAC File Offset: 0x001F8FAC
		public bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_Valid
		{
			get
			{
				short num = (short)1809645568;
				short num2 = num;
				num = (short)471322899;
				short num3 = num;
				num = (short)1713230099;
				switch (num3 == num)
				{
				}
				num = (short)1396375552;
				if (num != 0)
				{
				}
				num = (short)1432354817;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Valid;
			}
			set
			{
				short num = (short)1317208064;
				short num2 = num;
				num = (short)31409078;
				short num3 = num;
				num = (short)601441206;
				switch (num3 == num)
				{
				}
				num = (short)1039073281;
				if (num != 0)
				{
				}
				num = (short)680656896;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Valid = value;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x001FAE64 File Offset: 0x001F9064
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x001FAF18 File Offset: 0x001F9118
		public bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_Visible
		{
			get
			{
				short num = (short)278265856;
				short num2 = num;
				num = (short)332285317;
				short num3 = num;
				num = (short)1875395973;
				switch (num3 == num)
				{
				}
				num = (short)1762983937;
				if (num != 0)
				{
				}
				num = (short)1631780864;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Visible;
			}
			set
			{
				short num = (short)196804608;
				short num2 = num;
				num = (short)1093264294;
				short num3 = num;
				num = (short)1901912998;
				switch (num3 == num)
				{
				}
				num = (short)284360704;
				if (num != 0)
				{
				}
				num = (short)358481921;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Visible = value;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x001FAFCC File Offset: 0x001F91CC
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x001FB07C File Offset: 0x001F927C
		public bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_Editable
		{
			get
			{
				short num = (short)294977536;
				short num2 = num;
				num = (short)139673073;
				short num3 = num;
				num = (short)211303921;
				switch (num3 == num)
				{
				}
				num = (short)1638858753;
				if (num != 0)
				{
				}
				num = (short)1964834816;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Editable;
			}
			set
			{
				short num = (short)285605888;
				short num2 = num;
				num = (short)276757108;
				short num3 = num;
				num = (short)140900980;
				switch (num3 == num)
				{
				}
				num = (short)833290241;
				if (num != 0)
				{
				}
				num = (short)927203328;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.Editable = value;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x001FB130 File Offset: 0x001F9330
		internal string SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_UILabel
		{
			get
			{
				short num = (short)1594097664;
				short num2 = num;
				num = (short)560463873;
				if (num != 0)
				{
				}
				num = (short)685278686;
				short num3 = num;
				num = (short)1962313182;
				switch (num3 == num)
				{
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.UIName;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x001FB1E4 File Offset: 0x001F93E4
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x001FB298 File Offset: 0x001F9498
		internal bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_HiddenStatic
		{
			get
			{
				short num = (short)877920256;
				short num2 = num;
				num = (short)1815805953;
				if (num != 0)
				{
				}
				num = (short)1979293084;
				short num3 = num;
				num = (short)2011340188;
				switch (num3 == num)
				{
				}
				num = (short)1877147648;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.HiddenStatic;
			}
			set
			{
				short num = (short)1524039680;
				short num2 = num;
				num = (short)1316095644;
				short num3 = num;
				num = (short)251004572;
				switch (num3 == num)
				{
				}
				num = (short)479657984;
				if (num != 0)
				{
				}
				num = (short)796196865;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.HiddenStatic = value;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x001FB34C File Offset: 0x001F954C
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x001FB400 File Offset: 0x001F9600
		internal bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_HiddenDynamic
		{
			get
			{
				short num = (short)1521483776;
				short num2 = num;
				num = (short)403439617;
				if (num != 0)
				{
				}
				num = (short)292074051;
				short num3 = num;
				num = (short)406303299;
				switch (num3 == num)
				{
				}
				num = (short)1743192064;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.HiddenDynamic;
			}
			set
			{
				short num = (short)1418264576;
				short num2 = num;
				num = (short)375776807;
				short num3 = num;
				num = (short)1293805095;
				switch (num3 == num)
				{
				}
				num = (short)463470593;
				if (num != 0)
				{
				}
				num = (short)2121728000;
				if (num != 0)
				{
				}
				this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x001FB4B8 File Offset: 0x001F96B8
		public bool SecWideFeaturesNonXLScanUnsquelchDurationms_A8570_HasDiffs
		{
			get
			{
				short num = (short)911081472;
				short num2 = num;
				num = (short)1976575172;
				short num3 = num;
				num = (short)1068311748;
				switch (num3 == num)
				{
				}
				num = (short)215089153;
				if (num != 0)
				{
				}
				num = (short)1438908416;
				if (num != 0)
				{
				}
				return this.secWideFeaturesNonXLScanUnsquelchDurationms_A8570._HasDiffs;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x001FB56C File Offset: 0x001F976C
		// (set) Token: 0x06001FDD RID: 8157 RVA: 0x001FB620 File Offset: 0x001F9820
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695Value
		{
			get
			{
				short num = (short)789577728;
				short num2 = num;
				num = (short)1855011245;
				short num3 = num;
				num = (short)383400365;
				switch (num3 == num)
				{
				}
				num = (short)478609409;
				if (num != 0)
				{
				}
				num = (short)1262682112;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Value;
			}
			set
			{
				short num = (short)370278400;
				short num2 = num;
				num = (short)1753546753;
				if (num != 0)
				{
				}
				num = (short)1245084163;
				short num3 = num;
				num = (short)1647016451;
				switch (num3 == num)
				{
				}
				num = (short)1869479936;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Value = value;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x001FB6D4 File Offset: 0x001F98D4
		public global::AcpBusinessLayer.AcpField<bool> SecWideFeaturesPeriodicKeyfailAlertTone_A8695
		{
			get
			{
				short num = (short)1166540800;
				short num2 = num;
				num = (short)1907149993;
				short num3 = num;
				num = (short)579062953;
				switch (num3 == num)
				{
				}
				num = (short)655687681;
				if (num != 0)
				{
				}
				num = (short)353697792;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x001FB784 File Offset: 0x001F9984
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x001FB838 File Offset: 0x001F9A38
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_UIValue
		{
			get
			{
				short num = (short)655622144;
				short num2 = num;
				num = (short)771960951;
				short num3 = num;
				num = (short)1992765559;
				switch (num3 == num)
				{
				}
				num = (short)2051080192;
				if (num != 0)
				{
				}
				num = (short)1143799809;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Value;
			}
			set
			{
				short num = (short)1201078272;
				short num2 = num;
				num = (short)1793130497;
				if (num != 0)
				{
				}
				num = (short)67216415;
				short num3 = num;
				num = (short)1021617183;
				switch (num3 == num)
				{
				}
				num = (short)1343225856;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Value = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x001FB8EC File Offset: 0x001F9AEC
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x001FB9A0 File Offset: 0x001F9BA0
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_Applicable
		{
			get
			{
				short num = (short)379584512;
				short num2 = num;
				num = (short)1604971053;
				short num3 = num;
				num = (short)1078258221;
				switch (num3 == num)
				{
				}
				num = (short)724303872;
				if (num != 0)
				{
				}
				num = (short)1659830273;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Applicable;
			}
			set
			{
				short num = (short)1060700160;
				short num2 = num;
				num = (short)1042937666;
				short num3 = num;
				num = (short)1528100674;
				switch (num3 == num)
				{
				}
				num = (short)1474363393;
				if (num != 0)
				{
				}
				num = (short)2022703104;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Applicable = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x001FBA54 File Offset: 0x001F9C54
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x001FBB08 File Offset: 0x001F9D08
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_Valid
		{
			get
			{
				short num = (short)1251475456;
				short num2 = num;
				num = (short)1629972242;
				short num3 = num;
				num = (short)371091218;
				switch (num3 == num)
				{
				}
				num = (short)1331757057;
				if (num != 0)
				{
				}
				num = (short)1792540672;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Valid;
			}
			set
			{
				short num = (short)203685888;
				short num2 = num;
				num = (short)191550251;
				short num3 = num;
				num = (short)556258091;
				switch (num3 == num)
				{
				}
				num = (short)1116667905;
				if (num != 0)
				{
				}
				num = (short)712638464;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Valid = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x001FBBC0 File Offset: 0x001F9DC0
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x001FBC74 File Offset: 0x001F9E74
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_Visible
		{
			get
			{
				short num = (short)2021130240;
				short num2 = num;
				num = (short)1817000695;
				short num3 = num;
				num = (short)822491895;
				switch (num3 == num)
				{
				}
				num = (short)142671872;
				if (num != 0)
				{
				}
				num = (short)2001993729;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Visible;
			}
			set
			{
				short num = (short)1686568960;
				short num2 = num;
				num = (short)1160249345;
				if (num != 0)
				{
				}
				num = (short)51659690;
				short num3 = num;
				num = (short)458965930;
				switch (num3 == num)
				{
				}
				num = (short)1480458240;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Visible = value;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x001FBD28 File Offset: 0x001F9F28
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x001FBDDC File Offset: 0x001F9FDC
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_Editable
		{
			get
			{
				short num = (short)1310785536;
				short num2 = num;
				num = (short)1981743930;
				short num3 = num;
				num = (short)1028719418;
				switch (num3 == num)
				{
				}
				num = (short)406585344;
				if (num != 0)
				{
				}
				num = (short)1281818625;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Editable;
			}
			set
			{
				short num = (short)2119368704;
				short num2 = num;
				num = (short)1551072886;
				short num3 = num;
				num = (short)935493238;
				switch (num3 == num)
				{
				}
				num = (short)871956480;
				if (num != 0)
				{
				}
				num = (short)1229914113;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.Editable = value;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x001FBE90 File Offset: 0x001FA090
		internal string SecWideFeaturesPeriodicKeyfailAlertTone_A8695_UILabel
		{
			get
			{
				short num = (short)34799616;
				short num2 = num;
				num = (short)931659226;
				short num3 = num;
				num = (short)1422458330;
				switch (num3 == num)
				{
				}
				num = (short)681312257;
				if (num != 0)
				{
				}
				num = (short)1691090944;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.UIName;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x001FBF44 File Offset: 0x001FA144
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x001FBFF8 File Offset: 0x001FA1F8
		internal bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_HiddenStatic
		{
			get
			{
				short num = (short)1113128960;
				short num2 = num;
				num = (short)1371403656;
				short num3 = num;
				num = (short)589821320;
				switch (num3 == num)
				{
				}
				num = (short)1866727425;
				if (num != 0)
				{
				}
				num = (short)951386112;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.HiddenStatic;
			}
			set
			{
				short num = (short)1660420096;
				short num2 = num;
				num = (short)2000702953;
				short num3 = num;
				num = (short)1684295145;
				switch (num3 == num)
				{
				}
				num = (short)1279590401;
				if (num != 0)
				{
				}
				num = (short)426901504;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.HiddenStatic = value;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x001FC0AC File Offset: 0x001FA2AC
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x001FC160 File Offset: 0x001FA360
		internal bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_HiddenDynamic
		{
			get
			{
				short num = (short)633143296;
				short num2 = num;
				num = (short)107505630;
				short num3 = num;
				num = (short)1541629918;
				switch (num3 == num)
				{
				}
				num = (short)820117505;
				if (num != 0)
				{
				}
				num = (short)84475904;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.HiddenDynamic;
			}
			set
			{
				short num = (short)668532736;
				short num2 = num;
				num = (short)798663556;
				short num3 = num;
				num = (short)1975821188;
				switch (num3 == num)
				{
				}
				num = (short)1219821569;
				if (num != 0)
				{
				}
				num = (short)1403781120;
				if (num != 0)
				{
				}
				this.secWideFeaturesPeriodicKeyfailAlertTone_A8695.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x001FC21C File Offset: 0x001FA41C
		public bool SecWideFeaturesPeriodicKeyfailAlertTone_A8695_HasDiffs
		{
			get
			{
				short num = (short)1104543744;
				short num2 = num;
				num = (short)628785915;
				short num3 = num;
				num = (short)1767801595;
				switch (num3 == num)
				{
				}
				num = (short)257228800;
				if (num != 0)
				{
				}
				num = (short)11337729;
				if (num != 0)
				{
				}
				return this.secWideFeaturesPeriodicKeyfailAlertTone_A8695._HasDiffs;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x001FC2CC File Offset: 0x001FA4CC
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x001FC37C File Offset: 0x001FA57C
		public bool SecWideFeaturesProperCodeEnhancer_A8764Value
		{
			get
			{
				short num = (short)1350303744;
				short num2 = num;
				num = (short)188332757;
				short num3 = num;
				num = (short)375372501;
				switch (num3 == num)
				{
				}
				num = (short)823066625;
				if (num != 0)
				{
				}
				num = (short)469368832;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.Value;
			}
			set
			{
				short num = (short)173539328;
				short num2 = num;
				num = (short)169369155;
				short num3 = num;
				num = (short)503340611;
				switch (num3 == num)
				{
				}
				num = (short)992346112;
				if (num != 0)
				{
				}
				num = (short)1749024769;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.Value = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x001FC430 File Offset: 0x001FA630
		public global::AcpBusinessLayer.AcpField<bool> SecWideFeaturesProperCodeEnhancer_A8764
		{
			get
			{
				short num = (short)143851520;
				short num2 = num;
				num = (short)2000928504;
				short num3 = num;
				num = (short)1281539832;
				switch (num3 == num)
				{
				}
				num = (short)198705152;
				if (num != 0)
				{
				}
				num = (short)536281089;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x001FC4E4 File Offset: 0x001FA6E4
		// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x001FC594 File Offset: 0x001FA794
		public bool SecWideFeaturesProperCodeEnhancer_A8764_UIValue
		{
			get
			{
				short num = (short)1631846400;
				short num2 = num;
				num = (short)1150924198;
				short num3 = num;
				num = (short)1364374950;
				switch (num3 == num)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				num = (short)1886322688;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.Value;
			}
			set
			{
				short num = (short)781582336;
				short num2 = num;
				num = (short)1479278593;
				if (num != 0)
				{
				}
				num = (short)687446904;
				short num3 = num;
				num = (short)122264440;
				switch (num3 == num)
				{
				}
				num = (short)986054656;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.Value = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x001FC64C File Offset: 0x001FA84C
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x001FC704 File Offset: 0x001FA904
		public bool SecWideFeaturesProperCodeEnhancer_A8764_Applicable
		{
			get
			{
				short num = (short)163971072;
				short num2 = num;
				num = (short)887236704;
				short num3 = num;
				num = (short)2134452320;
				switch (num3 == num)
				{
				}
				num = (short)930480128;
				if (num != 0)
				{
				}
				num = (short)1054932993;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.Applicable;
			}
			set
			{
				short num = (short)945094656;
				short num2 = num;
				num = (short)2058194579;
				short num3 = num;
				num = (short)288657043;
				switch (num3 == num)
				{
				}
				num = (short)515571713;
				if (num != 0)
				{
				}
				num = (short)721158144;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.Applicable = value;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x001FC7BC File Offset: 0x001FA9BC
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x001FC870 File Offset: 0x001FAA70
		public bool SecWideFeaturesProperCodeEnhancer_A8764_Valid
		{
			get
			{
				short num = (short)1043922944;
				short num2 = num;
				num = (short)1143537665;
				if (num != 0)
				{
				}
				num = (short)1837915744;
				short num3 = num;
				num = (short)1861770848;
				switch (num3 == num)
				{
				}
				num = (short)206766080;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.Valid;
			}
			set
			{
				short num = (short)1551040512;
				short num2 = num;
				num = (short)850125392;
				short num3 = num;
				num = (short)1285349968;
				switch (num3 == num)
				{
				}
				num = (short)1480785921;
				if (num != 0)
				{
				}
				num = (short)577830912;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.Valid = value;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x001FC928 File Offset: 0x001FAB28
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x001FC9DC File Offset: 0x001FABDC
		public bool SecWideFeaturesProperCodeEnhancer_A8764_Visible
		{
			get
			{
				short num = (short)965935104;
				short num2 = num;
				num = (short)975197946;
				short num3 = num;
				num = (short)1293965050;
				switch (num3 == num)
				{
				}
				num = (short)1670774784;
				if (num != 0)
				{
				}
				num = (short)1504903169;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.Visible;
			}
			set
			{
				short num = (short)326500352;
				short num2 = num;
				num = (short)1394988811;
				short num3 = num;
				num = (short)1984222987;
				switch (num3 == num)
				{
				}
				num = (short)1620967424;
				if (num != 0)
				{
				}
				num = (short)987889665;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.Visible = value;
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x001FCA94 File Offset: 0x001FAC94
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x001FCB4C File Offset: 0x001FAD4C
		public bool SecWideFeaturesProperCodeEnhancer_A8764_Editable
		{
			get
			{
				short num = (short)226426880;
				short num2 = num;
				num = (short)10520415;
				short num3 = num;
				num = (short)1369147231;
				switch (num3 == num)
				{
				}
				num = (short)842137600;
				if (num != 0)
				{
				}
				num = (short)1719468033;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.Editable;
			}
			set
			{
				short num = (short)219611136;
				short num2 = num;
				num = (short)2080307340;
				short num3 = num;
				num = (short)2034432140;
				switch (num3 == num)
				{
				}
				num = (short)1262747648;
				if (num != 0)
				{
				}
				num = (short)1372454913;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.Editable = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x001FCC08 File Offset: 0x001FAE08
		internal string SecWideFeaturesProperCodeEnhancer_A8764_UILabel
		{
			get
			{
				short num = (short)532480000;
				short num2 = num;
				num = (short)78455637;
				short num3 = num;
				num = (short)301474645;
				switch (num3 == num)
				{
				}
				num = (short)195231745;
				if (num != 0)
				{
				}
				num = (short)1527906304;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.UIName;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x001FCCC0 File Offset: 0x001FAEC0
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x001FCD74 File Offset: 0x001FAF74
		internal bool SecWideFeaturesProperCodeEnhancer_A8764_HiddenStatic
		{
			get
			{
				short num = (short)1005977600;
				short num2 = num;
				num = (short)1095562113;
				short num3 = num;
				num = (short)488502145;
				switch (num3 == num)
				{
				}
				num = (short)729874432;
				if (num != 0)
				{
				}
				num = (short)1532952577;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.HiddenStatic;
			}
			set
			{
				short num = (short)973340672;
				short num2 = num;
				num = (short)491564635;
				short num3 = num;
				num = (short)1088859739;
				switch (num3 == num)
				{
				}
				num = (short)26083329;
				if (num != 0)
				{
				}
				num = (short)1247346688;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.HiddenStatic = value;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x001FCE28 File Offset: 0x001FB028
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x001FCEDC File Offset: 0x001FB0DC
		internal bool SecWideFeaturesProperCodeEnhancer_A8764_HiddenDynamic
		{
			get
			{
				short num = (short)2019950592;
				short num2 = num;
				num = (short)1846581805;
				short num3 = num;
				num = (short)1923979821;
				switch (num3 == num)
				{
				}
				num = (short)1981349889;
				if (num != 0)
				{
				}
				num = (short)1791688704;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764.HiddenDynamic;
			}
			set
			{
				short num = (short)619870560;
				short num2 = num;
				num = (short)1053587808;
				switch (num2 == num)
				{
				}
				num = (short)234029056;
				short num3 = num;
				num = (short)448921600;
				if (num != 0)
				{
				}
				num = (short)714407937;
				if (num != 0)
				{
				}
				this.secWideFeaturesProperCodeEnhancer_A8764.HiddenDynamic = value;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x001FCF90 File Offset: 0x001FB190
		public bool SecWideFeaturesProperCodeEnhancer_A8764_HasDiffs
		{
			get
			{
				short num = (short)1317562309;
				short num2 = num;
				num = (short)147154885;
				switch (num2 == num)
				{
				}
				num = (short)563871744;
				short num3 = num;
				num = (short)1533411328;
				if (num != 0)
				{
				}
				num = (short)887029761;
				if (num != 0)
				{
				}
				return this.secWideFeaturesProperCodeEnhancer_A8764._HasDiffs;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x001FD044 File Offset: 0x001FB244
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x001FD0FC File Offset: 0x001FB2FC
		public int SecWideFeaturesClearAlertTones_A9524Value
		{
			get
			{
				short num = (short)783911926;
				short num2 = num;
				num = (short)289377270;
				switch (num2 == num)
				{
				}
				num = (short)115736576;
				short num3 = num;
				num = (short)1339555841;
				if (num != 0)
				{
				}
				num = (short)124911616;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.Value;
			}
			set
			{
				short num = (short)1558090741;
				short num2 = num;
				num = (short)1651020789;
				switch (num2 == num)
				{
				}
				num = (short)1417412608;
				short num3 = num;
				num = (short)1775370241;
				if (num != 0)
				{
				}
				num = (short)1753612288;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.Value = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x001FD1B0 File Offset: 0x001FB3B0
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x001FD264 File Offset: 0x001FB464
		public string SecWideFeaturesClearAlertTones_A9524_UIValue
		{
			get
			{
				short num = (short)1736826928;
				short num2 = num;
				num = (short)1190387760;
				switch (num2 == num)
				{
				}
				num = (short)478085120;
				short num3 = num;
				num = (short)1444806657;
				if (num != 0)
				{
				}
				num = (short)235077632;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.UIValue;
			}
			set
			{
				short num = (short)1151945428;
				short num2 = num;
				num = (short)1858095828;
				switch (num2 == num)
				{
				}
				num = (short)1962868736;
				short num3 = num;
				num = (short)1209008129;
				if (num != 0)
				{
				}
				num = (short)1130627072;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.UIValue = value;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x001FD318 File Offset: 0x001FB518
		public global::AcpBusinessLayer.AcpListField SecWideFeaturesClearAlertTones_A9524
		{
			get
			{
				short num = (short)1658492230;
				short num2 = num;
				num = (short)1311872326;
				switch (num2 == num)
				{
				}
				num = (short)1302724608;
				short num3 = num;
				num = (short)412221441;
				if (num != 0)
				{
				}
				num = (short)1385299968;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x001FD3CC File Offset: 0x001FB5CC
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x001FD480 File Offset: 0x001FB680
		public bool SecWideFeaturesClearAlertTones_A9524_Applicable
		{
			get
			{
				short num = (short)1683854875;
				short num2 = num;
				num = (short)806852123;
				switch (num2 == num)
				{
				}
				num = (short)1955987456;
				short num3 = num;
				num = (short)440205312;
				if (num != 0)
				{
				}
				num = (short)1143406593;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.Applicable;
			}
			set
			{
				short num = (short)898105356;
				short num2 = num;
				num = (short)1801322508;
				switch (num2 == num)
				{
				}
				num = (short)1700659200;
				short num3 = num;
				num = (short)1015545857;
				if (num != 0)
				{
				}
				num = (short)555352064;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.Applicable = value;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x001FD534 File Offset: 0x001FB734
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x001FD5E8 File Offset: 0x001FB7E8
		public bool SecWideFeaturesClearAlertTones_A9524_Valid
		{
			get
			{
				short num = (short)1806254666;
				short num2 = num;
				num = (short)1456751178;
				switch (num2 == num)
				{
				}
				num = (short)1661599744;
				short num3 = num;
				num = (short)1680211969;
				if (num != 0)
				{
				}
				num = (short)1580924928;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.Valid;
			}
			set
			{
				short num = (short)179529007;
				short num2 = num;
				num = (short)35611951;
				switch (num2 == num)
				{
				}
				num = (short)432603136;
				short num3 = num;
				num = (short)904790016;
				if (num != 0)
				{
				}
				num = (short)119013377;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.Valid = value;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x001FD69C File Offset: 0x001FB89C
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x001FD750 File Offset: 0x001FB950
		public bool SecWideFeaturesClearAlertTones_A9524_Visible
		{
			get
			{
				short num = (short)1739997207;
				short num2 = num;
				num = (short)1034043415;
				switch (num2 == num)
				{
				}
				num = (short)2086010880;
				short num3 = num;
				num = (short)1080164353;
				if (num != 0)
				{
				}
				num = (short)1664221184;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.Visible;
			}
			set
			{
				short num = (short)1995703531;
				short num2 = num;
				num = (short)804127979;
				switch (num2 == num)
				{
				}
				num = (short)2078081024;
				short num3 = num;
				num = (short)397017088;
				if (num != 0)
				{
				}
				num = (short)67633153;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.Visible = value;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x001FD804 File Offset: 0x001FBA04
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x001FD8B8 File Offset: 0x001FBAB8
		public bool SecWideFeaturesClearAlertTones_A9524_Editable
		{
			get
			{
				short num = (short)1663252468;
				short num2 = num;
				num = (short)559364084;
				switch (num2 == num)
				{
				}
				num = (short)297205760;
				short num3 = num;
				num = (short)1906638849;
				if (num != 0)
				{
				}
				num = (short)295501824;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.Editable;
			}
			set
			{
				short num = (short)1785673150;
				short num2 = num;
				num = (short)1561802174;
				switch (num2 == num)
				{
				}
				num = (short)1181876224;
				short num3 = num;
				num = (short)1371865088;
				if (num != 0)
				{
				}
				num = (short)662831105;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.Editable = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x001FD96C File Offset: 0x001FBB6C
		internal string SecWideFeaturesClearAlertTones_A9524_UILabel
		{
			get
			{
				short num = (short)1073373976;
				short num2 = num;
				num = (short)2017092376;
				switch (num2 == num)
				{
				}
				num = (short)113049600;
				short num3 = num;
				num = (short)43319297;
				if (num != 0)
				{
				}
				num = (short)743309312;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.UIName;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x001FDA24 File Offset: 0x001FBC24
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x001FDAD4 File Offset: 0x001FBCD4
		internal bool SecWideFeaturesClearAlertTones_A9524_HiddenStatic
		{
			get
			{
				short num = (short)1382166344;
				short num2 = num;
				num = (short)756166472;
				switch (num2 == num)
				{
				}
				num = (short)350552064;
				short num3 = num;
				num = (short)1468661761;
				if (num != 0)
				{
				}
				num = (short)688324608;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.HiddenStatic;
			}
			set
			{
				short num = (short)771042129;
				short num2 = num;
				num = (short)1136798545;
				switch (num2 == num)
				{
				}
				num = (short)792788992;
				short num3 = num;
				num = (short)759562240;
				if (num != 0)
				{
				}
				num = (short)1569521665;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.HiddenStatic = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x001FDB90 File Offset: 0x001FBD90
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x001FDC48 File Offset: 0x001FBE48
		internal bool SecWideFeaturesClearAlertTones_A9524_HiddenDynamic
		{
			get
			{
				short num = (short)963495553;
				short num2 = num;
				num = (short)1264240257;
				switch (num2 == num)
				{
				}
				num = (short)273088512;
				short num3 = num;
				num = (short)1903427585;
				if (num != 0)
				{
				}
				num = (short)495714304;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524.HiddenDynamic;
			}
			set
			{
				short num = (short)648706740;
				short num2 = num;
				num = (short)1586854580;
				switch (num2 == num)
				{
				}
				num = (short)1074200576;
				short num3 = num;
				num = (short)1558380545;
				if (num != 0)
				{
				}
				num = (short)1313341440;
				if (num != 0)
				{
				}
				this.secWideFeaturesClearAlertTones_A9524.HiddenDynamic = value;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x001FDCFC File Offset: 0x001FBEFC
		public bool SecWideFeaturesClearAlertTones_A9524_HasDiffs
		{
			get
			{
				short num = (short)1836368988;
				short num2 = num;
				num = (short)1916978268;
				switch (num2 == num)
				{
				}
				num = (short)209125376;
				short num3 = num;
				num = (short)1823014913;
				if (num != 0)
				{
				}
				num = (short)2131361792;
				if (num != 0)
				{
				}
				return this.secWideFeaturesClearAlertTones_A9524._HasDiffs;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x001FDDB0 File Offset: 0x001FBFB0
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x001FDE64 File Offset: 0x001FC064
		public int SecWideFeaturesXLScanUnsquelchDurationMs_A9682Value
		{
			get
			{
				short num = (short)1200304432;
				short num2 = num;
				num = (short)605696304;
				switch (num2 == num)
				{
				}
				num = (short)141361152;
				short num3 = num;
				num = (short)1755054081;
				if (num != 0)
				{
				}
				num = (short)106823680;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Value;
			}
			set
			{
				short num = (short)1461127190;
				short num2 = num;
				num = (short)735578134;
				switch (num2 == num)
				{
				}
				num = (short)1379139584;
				short num3 = num;
				num = (short)989265920;
				if (num != 0)
				{
				}
				num = (short)2050883585;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Value = value;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x001FDF18 File Offset: 0x001FC118
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideFeaturesXLScanUnsquelchDurationMs_A9682
		{
			get
			{
				short num = (short)331093387;
				short num2 = num;
				num = (short)1760499083;
				switch (num2 == num)
				{
				}
				num = (short)1926365184;
				short num3 = num;
				num = (short)2090729472;
				if (num != 0)
				{
				}
				num = (short)1171652609;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x001FDFCC File Offset: 0x001FC1CC
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x001FE080 File Offset: 0x001FC280
		public string SecWideFeaturesXLScanUnsquelchDurationMs_A9682_UIValue
		{
			get
			{
				short num = (short)1652132812;
				short num2 = num;
				num = (short)1054903244;
				switch (num2 == num)
				{
				}
				num = (short)916127744;
				short num3 = num;
				num = (short)288030720;
				if (num != 0)
				{
				}
				num = (short)853475329;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.UIValue;
			}
			set
			{
				short num = (short)3085553;
				short num2 = num;
				num = (short)1689654513;
				switch (num2 == num)
				{
				}
				num = (short)2109276160;
				short num3 = num;
				num = (short)18808833;
				if (num != 0)
				{
				}
				num = (short)1279000576;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.UIValue = value;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x001FE134 File Offset: 0x001FC334
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x001FE1E8 File Offset: 0x001FC3E8
		internal int SecWideFeaturesXLScanUnsquelchDurationMs_A9682Min
		{
			get
			{
				short num = (short)682168344;
				short num2 = num;
				num = (short)1181749272;
				switch (num2 == num)
				{
				}
				num = (short)934674432;
				short num3 = num;
				num = (short)940376065;
				if (num != 0)
				{
				}
				num = (short)1578303488;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Min;
			}
			set
			{
				short num = (short)285342752;
				short num2 = num;
				num = (short)119929888;
				switch (num2 == num)
				{
				}
				num = (short)55377920;
				short num3 = num;
				num = (short)96534529;
				if (num != 0)
				{
				}
				num = (short)544604160;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Min = value;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x001FE29C File Offset: 0x001FC49C
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x001FE350 File Offset: 0x001FC550
		internal int SecWideFeaturesXLScanUnsquelchDurationMs_A9682Max
		{
			get
			{
				short num = (short)1461846017;
				if (num != 0)
				{
				}
				num = (short)1171567511;
				short num2 = num;
				num = (short)1542697879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)977731584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122776576;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Max;
			}
			set
			{
				short num = (short)1455967005;
				short num2 = num;
				num = (short)1798392605;
				switch (num2 == num)
				{
				}
				num = (short)1107165184;
				short num3 = num;
				num = (short)132448257;
				if (num != 0)
				{
				}
				num = (short)698613760;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Max = value;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x001FE404 File Offset: 0x001FC604
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x001FE4BC File Offset: 0x001FC6BC
		internal int SecWideFeaturesXLScanUnsquelchDurationMs_A9682Step
		{
			get
			{
				short num = (short)7200741;
				short num2 = num;
				num = (short)1062461413;
				switch (num2 == num)
				{
				}
				num = (short)1214447616;
				short num3 = num;
				num = (short)796000257;
				if (num != 0)
				{
				}
				num = (short)1826422784;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.StepSize;
			}
			set
			{
				short num = (short)152275700;
				short num2 = num;
				num = (short)1515752180;
				switch (num2 == num)
				{
				}
				num = (short)1634074624;
				short num3 = num;
				num = (short)1886846977;
				if (num != 0)
				{
				}
				num = (short)1754595328;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.StepSize = value;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x001FE574 File Offset: 0x001FC774
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x001FE62C File Offset: 0x001FC82C
		public bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_Applicable
		{
			get
			{
				short num = (short)891355137;
				if (num != 0)
				{
				}
				num = (short)219565950;
				short num2 = num;
				num = (short)1378963326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989148672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343932928;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Applicable;
			}
			set
			{
				short num = (short)737280001;
				if (num != 0)
				{
				}
				num = (short)641751899;
				short num2 = num;
				num = (short)1142578011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1978007552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1257177088;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Applicable = value;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x001FE6E0 File Offset: 0x001FC8E0
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x001FE794 File Offset: 0x001FC994
		public bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_Valid
		{
			get
			{
				short num = (short)737989769;
				short num2 = num;
				num = (short)43897993;
				switch (num2 == num)
				{
				}
				num = (short)801636352;
				short num3 = num;
				num = (short)2011889665;
				if (num != 0)
				{
				}
				num = (short)1177288704;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Valid;
			}
			set
			{
				short num = (short)234356761;
				short num2 = num;
				num = (short)2097610777;
				switch (num2 == num)
				{
				}
				num = (short)2032992256;
				short num3 = num;
				num = (short)1300824065;
				if (num != 0)
				{
				}
				num = (short)1176436736;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Valid = value;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x001FE848 File Offset: 0x001FCA48
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x001FE8FC File Offset: 0x001FCAFC
		public bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_Visible
		{
			get
			{
				short num = (short)1516181389;
				short num2 = num;
				num = (short)618534797;
				switch (num2 == num)
				{
				}
				num = (short)1726021632;
				short num3 = num;
				num = (short)1762590720;
				if (num != 0)
				{
				}
				num = (short)124977153;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Visible;
			}
			set
			{
				short num = (short)2002841349;
				short num2 = num;
				num = (short)1298263813;
				switch (num2 == num)
				{
				}
				num = (short)1592721408;
				short num3 = num;
				num = (short)2096627713;
				if (num != 0)
				{
				}
				num = (short)1770848256;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Visible = value;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x001FE9B4 File Offset: 0x001FCBB4
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x001FEA6C File Offset: 0x001FCC6C
		public bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_Editable
		{
			get
			{
				short num = (short)556728321;
				if (num != 0)
				{
				}
				num = (short)2036325028;
				short num2 = num;
				num = (short)2142034596;
				switch (num2 == num)
				{
				default:
				{
					num = (short)92340224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1701904384;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Editable;
			}
			set
			{
				short num = (short)1006048110;
				short num2 = num;
				num = (short)1433277294;
				switch (num2 == num)
				{
				}
				num = (short)534904832;
				short num3 = num;
				num = (short)16711681;
				if (num != 0)
				{
				}
				num = (short)1003683840;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.Editable = value;
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x001FEB20 File Offset: 0x001FCD20
		internal string SecWideFeaturesXLScanUnsquelchDurationMs_A9682_UILabel
		{
			get
			{
				short num = (short)997468594;
				short num2 = num;
				num = (short)222767538;
				switch (num2 == num)
				{
				}
				num = (short)549191680;
				short num3 = num;
				num = (short)354222081;
				if (num != 0)
				{
				}
				num = (short)827785216;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.UIName;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x001FEBD4 File Offset: 0x001FCDD4
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x001FEC8C File Offset: 0x001FCE8C
		internal bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_HiddenStatic
		{
			get
			{
				short num = (short)1222975370;
				short num2 = num;
				num = (short)1480466314;
				switch (num2 == num)
				{
				}
				num = (short)1889730560;
				short num3 = num;
				num = (short)1928003585;
				if (num != 0)
				{
				}
				num = (short)470286336;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.HiddenStatic;
			}
			set
			{
				short num = (short)1285135212;
				short num2 = num;
				num = (short)2022480748;
				switch (num2 == num)
				{
				}
				num = (short)1362886656;
				short num3 = num;
				num = (short)1878458369;
				if (num != 0)
				{
				}
				num = (short)86835200;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.HiddenStatic = value;
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x001FED44 File Offset: 0x001FCF44
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x001FEDF8 File Offset: 0x001FCFF8
		internal bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_HiddenDynamic
		{
			get
			{
				short num = (short)1751901717;
				short num2 = num;
				num = (short)704046613;
				switch (num2 == num)
				{
				}
				num = (short)1149042688;
				short num3 = num;
				num = (short)554303489;
				if (num != 0)
				{
				}
				num = (short)1863974912;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.HiddenDynamic;
			}
			set
			{
				short num = (short)600451428;
				short num2 = num;
				num = (short)1532045668;
				switch (num2 == num)
				{
				}
				num = (short)686555136;
				short num3 = num;
				num = (short)777846785;
				if (num != 0)
				{
				}
				num = (short)301989888;
				if (num != 0)
				{
				}
				this.secWideFeaturesXLScanUnsquelchDurationMs_A9682.HiddenDynamic = value;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x001FEEAC File Offset: 0x001FD0AC
		public bool SecWideFeaturesXLScanUnsquelchDurationMs_A9682_HasDiffs
		{
			get
			{
				short num = (short)61414985;
				short num2 = num;
				num = (short)464723529;
				switch (num2 == num)
				{
				}
				num = (short)351141888;
				short num3 = num;
				num = (short)717881345;
				if (num != 0)
				{
				}
				num = (short)1429798912;
				if (num != 0)
				{
				}
				return this.secWideFeaturesXLScanUnsquelchDurationMs_A9682._HasDiffs;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x001FEF60 File Offset: 0x001FD160
		public global::AcpBusinessLayer.AcpField<bool> SecWideInfiniteUKEKRetention_A41551
		{
			get
			{
				short num = (short)316005733;
				short num2 = num;
				num = (short)1136844133;
				switch (num2 == num)
				{
				}
				num = (short)271450112;
				short num3 = num;
				num = (short)1769013249;
				if (num != 0)
				{
				}
				num = (short)1447100416;
				if (num != 0)
				{
				}
				return this.secWideInfiniteUKEKRetention_A41551;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x001FF00C File Offset: 0x001FD20C
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x001FF0C4 File Offset: 0x001FD2C4
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046Value
		{
			get
			{
				short num = (short)1578114821;
				short num2 = num;
				num = (short)1531911941;
				switch (num2 == num)
				{
				}
				num = (short)100204544;
				short num3 = num;
				num = (short)1787035649;
				if (num != 0)
				{
				}
				num = (short)10878976;
				if (num != 0)
				{
				}
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.Value;
			}
			set
			{
				short num = (short)1698734413;
				short num2 = num;
				num = (short)1041146189;
				switch (num2 == num)
				{
				}
				num = (short)1008271360;
				short num3 = num;
				num = (short)1980628992;
				if (num != 0)
				{
				}
				num = (short)628817921;
				if (num != 0)
				{
				}
				this.secWideFeaturesDisableHardKeyZeroize_A43046.Value = value;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x001FF17C File Offset: 0x001FD37C
		public global::AcpBusinessLayer.AcpField<bool> SecWideFeaturesDisableHardKeyZeroize_A43046
		{
			get
			{
				short num = (short)46539847;
				short num2 = num;
				num = (short)1125196871;
				switch (num2 == num)
				{
				}
				num = (short)1876033536;
				short num3 = num;
				num = (short)1198456833;
				if (num != 0)
				{
				}
				num = (short)2007105536;
				if (num != 0)
				{
				}
				return this.secWideFeaturesDisableHardKeyZeroize_A43046;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x001FF22C File Offset: 0x001FD42C
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x001FF2E0 File Offset: 0x001FD4E0
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046_UIValue
		{
			get
			{
				short num = (short)1347799364;
				short num2 = num;
				num = (short)118868292;
				switch (num2 == num)
				{
				}
				num = (short)1702756352;
				short num3 = num;
				num = (short)1941110785;
				if (num != 0)
				{
				}
				num = (short)1649410048;
				if (num != 0)
				{
				}
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.Value;
			}
			set
			{
				short num = (short)705755139;
				short num2 = num;
				num = (short)630388739;
				switch (num2 == num)
				{
				}
				num = (short)1143734272;
				short num3 = num;
				num = (short)398983169;
				if (num != 0)
				{
				}
				num = (short)549191680;
				if (num != 0)
				{
				}
				this.secWideFeaturesDisableHardKeyZeroize_A43046.Value = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x001FF39C File Offset: 0x001FD59C
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x001FF450 File Offset: 0x001FD650
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046_Applicable
		{
			get
			{
				short num = (short)8203520;
				short num2 = num;
				num = (short)471346432;
				switch (num2 == num)
				{
				}
				num = (short)976945152;
				short num3 = num;
				num = (short)1951989761;
				if (num != 0)
				{
				}
				num = (short)909967360;
				if (num != 0)
				{
				}
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.Applicable;
			}
			set
			{
				short num = (short)460534695;
				short num2 = num;
				num = (short)2136224679;
				switch (num2 == num)
				{
				}
				num = (short)259391488;
				short num3 = num;
				num = (short)1477181440;
				if (num != 0)
				{
				}
				num = (short)328073217;
				if (num != 0)
				{
				}
				this.secWideFeaturesDisableHardKeyZeroize_A43046.Applicable = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x001FF508 File Offset: 0x001FD708
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x001FF5BC File Offset: 0x001FD7BC
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046_Valid
		{
			get
			{
				short num = (short)649582032;
				short num2 = num;
				num = (short)996922832;
				switch (num2 == num)
				{
				}
				num = (short)1885732864;
				short num3 = num;
				num = (short)230359041;
				if (num != 0)
				{
				}
				num = (short)504561664;
				if (num != 0)
				{
				}
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.Valid;
			}
			set
			{
				short num = (short)1315391536;
				short num2 = num;
				num = (short)1331710000;
				switch (num2 == num)
				{
				}
				num = (short)2011430912;
				short num3 = num;
				num = (short)241106945;
				if (num != 0)
				{
				}
				num = (short)1324089344;
				if (num != 0)
				{
				}
				this.secWideFeaturesDisableHardKeyZeroize_A43046.Valid = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x001FF670 File Offset: 0x001FD870
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x001FF724 File Offset: 0x001FD924
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046_Visible
		{
			get
			{
				short num = (short)1259274241;
				if (num != 0)
				{
				}
				num = (short)844914606;
				short num2 = num;
				num = (short)55336878;
				switch (num2 == num)
				{
				}
				num = (short)374538240;
				if (num != 0)
				{
				}
				num = (short)1307443200;
				short num3 = num;
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.Visible;
			}
			set
			{
				short num = (short)274495082;
				short num2 = num;
				num = (short)1413903978;
				switch (num2 == num)
				{
				}
				num = (short)1132527616;
				if (num != 0)
				{
				}
				num = (short)129302529;
				if (num != 0)
				{
				}
				num = (short)1825505280;
				short num3 = num;
				this.secWideFeaturesDisableHardKeyZeroize_A43046.Visible = value;
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x001FF7DC File Offset: 0x001FD9DC
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x001FF894 File Offset: 0x001FDA94
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046_Editable
		{
			get
			{
				short num = (short)790300713;
				short num2 = num;
				num = (short)1723992105;
				switch (num2 == num)
				{
				}
				num = (short)1385693184;
				if (num != 0)
				{
				}
				num = (short)393347073;
				if (num != 0)
				{
				}
				num = (short)1828061184;
				short num3 = num;
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.Editable;
			}
			set
			{
				short num = (short)1273285438;
				short num2 = num;
				num = (short)1982647102;
				switch (num2 == num)
				{
				}
				num = (short)943063040;
				if (num != 0)
				{
				}
				num = (short)1989672961;
				if (num != 0)
				{
				}
				num = (short)399310848;
				short num3 = num;
				this.secWideFeaturesDisableHardKeyZeroize_A43046.Editable = value;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x001FF948 File Offset: 0x001FDB48
		internal string SecWideFeaturesDisableHardKeyZeroize_A43046_UILabel
		{
			get
			{
				short num = (short)1998258177;
				if (num != 0)
				{
				}
				num = (short)912800443;
				short num2 = num;
				num = (short)1856191163;
				switch (num2 == num)
				{
				}
				num = (short)34996224;
				if (num != 0)
				{
				}
				num = (short)56492032;
				short num3 = num;
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.UIName;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x001FF9FC File Offset: 0x001FDBFC
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x001FFAB4 File Offset: 0x001FDCB4
		internal bool SecWideFeaturesDisableHardKeyZeroize_A43046_HiddenStatic
		{
			get
			{
				short num = (short)1184759809;
				if (num != 0)
				{
				}
				num = (short)1814337830;
				short num2 = num;
				num = (short)1043044646;
				switch (num2 == num)
				{
				}
				num = (short)356122624;
				if (num != 0)
				{
				}
				num = (short)1723727872;
				short num3 = num;
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.HiddenStatic;
			}
			set
			{
				short num = (short)1706353284;
				short num2 = num;
				num = (short)1716839044;
				switch (num2 == num)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				num = (short)1177419777;
				if (num != 0)
				{
				}
				num = (short)194772992;
				short num3 = num;
				this.secWideFeaturesDisableHardKeyZeroize_A43046.HiddenStatic = value;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x001FFB68 File Offset: 0x001FDD68
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x001FFC20 File Offset: 0x001FDE20
		internal bool SecWideFeaturesDisableHardKeyZeroize_A43046_HiddenDynamic
		{
			get
			{
				short num = (short)775028737;
				if (num != 0)
				{
				}
				num = (short)92779758;
				short num2 = num;
				num = (short)1305588974;
				switch (num2 == num)
				{
				}
				num = (short)1654194176;
				if (num != 0)
				{
				}
				num = (short)1743060992;
				short num3 = num;
				return this.secWideFeaturesDisableHardKeyZeroize_A43046.HiddenDynamic;
			}
			set
			{
				short num = (short)1597505537;
				if (num != 0)
				{
				}
				num = (short)559243877;
				short num2 = num;
				num = (short)335635045;
				switch (num2 == num)
				{
				}
				num = (short)1228603392;
				if (num != 0)
				{
				}
				num = (short)1273036800;
				short num3 = num;
				this.secWideFeaturesDisableHardKeyZeroize_A43046.HiddenDynamic = value;
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x001FFCD4 File Offset: 0x001FDED4
		public bool SecWideFeaturesDisableHardKeyZeroize_A43046_HasDiffs
		{
			get
			{
				short num = (short)1463147067;
				short num2 = num;
				num = (short)1242815035;
				switch (num2 == num)
				{
				}
				num = (short)809828353;
				if (num != 0)
				{
				}
				num = (short)1832845312;
				if (num != 0)
				{
				}
				num = (short)58654720;
				short num3 = num;
				return this.secWideFeaturesDisableHardKeyZeroize_A43046._HasDiffs;
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x001FFD8C File Offset: 0x001FDF8C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1554313368;
				short num2 = num;
				num = (short)951971992;
				switch (num2 == num)
				{
				}
				num = (short)831324161;
				if (num != 0)
				{
				}
				num = (short)669581312;
				if (num != 0)
				{
				}
				num = (short)1504116736;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x001FFE4C File Offset: 0x001FE04C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)819986436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)253231107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1643511809;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_11B;
				case 4:
					goto IL_100;
				}
				goto IL_24;
			}
			IL_100:
			return result;
			IL_24:
			num2 = (short)1772879872;
			short num3 = num2;
			result = null;
			num2 = (short)1159113104;
			short num4 = num2;
			num2 = (short)1288612240;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11B:
				num2 = (short)636420097;
				if (num2 != 0)
				{
				}
				if (base.ParentRecset.ContainerDoc != null)
				{
					num2 = (short)446300160;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)600834048;
				if (num2 != 0)
				{
				}
				num2 = (short)785514498;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x04000BBA RID: 3002
		private global::AcpBusinessLayer.AcpField<bool> secWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238;

		// Token: 0x04000BBB RID: 3003
		private global::AcpBusinessLayer.AcpField<bool> secWideFeaturesInfiniteKeyRetention_A8292;

		// Token: 0x04000BBC RID: 3004
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideFeaturesNonXLScanUnsquelchDurationms_A8570;

		// Token: 0x04000BBD RID: 3005
		private global::AcpBusinessLayer.AcpField<bool> secWideFeaturesPeriodicKeyfailAlertTone_A8695;

		// Token: 0x04000BBE RID: 3006
		private global::AcpBusinessLayer.AcpField<bool> secWideFeaturesProperCodeEnhancer_A8764;

		// Token: 0x04000BBF RID: 3007
		private global::AcpBusinessLayer.AcpListField secWideFeaturesClearAlertTones_A9524;

		// Token: 0x04000BC0 RID: 3008
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideFeaturesXLScanUnsquelchDurationMs_A9682;

		// Token: 0x04000BC1 RID: 3009
		private global::AcpBusinessLayer.AcpField<bool> secWideInfiniteUKEKRetention_A41551;

		// Token: 0x04000BC2 RID: 3010
		private global::AcpBusinessLayer.AcpField<bool> secWideFeaturesDisableHardKeyZeroize_A43046;
	}
}
