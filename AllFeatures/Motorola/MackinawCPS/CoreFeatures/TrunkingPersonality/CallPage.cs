using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000AE RID: 174
	[global::System.Serializable]
	public class CallPage : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060016FC RID: 5884 RVA: 0x0015AA68 File Offset: 0x00158C68
		public CallPage(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0015AA84 File Offset: 0x00158C84
		protected CallPage(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0015AA9C File Offset: 0x00158C9C
		public override void Init()
		{
			int a_ = 1;
			short num = (short)467120589;
			short num2 = num;
			num = (short)1610068429;
			switch (num2 == num)
			{
			}
			num = (short)420151296;
			if (num != 0)
			{
			}
			num = (short)538312704;
			short num3 = num;
			num = (short)1456537601;
			if (num != 0)
			{
			}
			this.trkPerCallPageCallAlertPageOperation_A7597 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋跍뇏뻑룓蛕맗뷙맛鷝臟軡裣꟥蓧迩黫髭ꃯ鏱鏳鏵럷諹駻賽懿瘁洃椅昇唉䴋㤍┏⬑⌓", a_), global::CommonResources.AcgResources.ID_CALLALERTPAGEOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerCallPageCallAlertPageOperation_A7597LovStrs);
			this.trkPerCallPageCallAlertPageOperation_A7597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerCallPageCallAlertPageOperation_A7597.DataTransferOrder = 7;
			this.trkPerCallPagePrivateCallOperation_A8759 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.indexTrkPerCallPagePrivateCallOperation_A8759LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.idTrkPerCallPagePrivateCallOperation_A8759LovStrs), this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋跍뇏뻑룓蛕맗뷙맛軝鋟诡鋣蟥鳧迩꿫迭鳯黱믳蛵鷷裹鷻諽槿洁樃夅䤇㈉㬋㬍⤏", a_), global::CommonResources.AcgResources.ID_PRIVATECALLOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerCallPagePrivateCallOperation_A8759LovStrs);
			this.trkPerCallPagePrivateCallOperation_A8759.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerCallPagePrivateCallOperation_A8759.DataTransferOrder = 37;
			this.trkPerCallPagePrivateCallType_A8760 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋跍뇏뻑룓蛕맗뷙맛軝鋟诡鋣蟥鳧迩꿫迭鳯黱ꃳ迵裷鿹ꏻ뿽㣿㔁㈃㘅", a_), global::CommonResources.AcgResources.ID_PRIVATECALLTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerCallPagePrivateCallType_A8760LovStrs);
			this.trkPerCallPagePrivateCallType_A8760.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerCallPagePrivateCallType_A8760.DataTransferOrder = 4;
			this.trkPerCallPageInCallUserAlertEnable_A9434 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋跍뇏뻑룓蛕맗뷙맛韝軟ꇡ藣諥蓧뿩鿫语苯돱飳鏵諷軹맻都懿态栃挅圇䬉㔋㨍⌏☑", a_), global::CommonResources.AcgResources.ID_INCALLUSERALERTENABLE);
			this.trkPerCallPageInCallUserAlertEnable_A9434.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerCallPageInCallUserAlertEnable_A9434.DataTransferOrder = 39;
			this.trkPerCallPageAutomaticCallAlert_A9754 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋跍뇏뻑룓蛕맗뷙맛鿝闟雡诣该觧黩藫跭돯鏱飳髵맷雹駻賽瓿崁䔃㼅㼇㼉㠋", a_), global::CommonResources.AcgResources.ID_AUTOMATICCALLALERT);
			this.trkPerCallPageAutomaticCallAlert_A9754.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerCallPageAutomaticCallAlert_A9754.DataTransferOrder = 40;
			this.trkPerCallPageHotListItemID_A19982 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋跍뇏뻑룓蛕맗뷙맛雝迟雡꣣迥鯧黩ꗫ髭闯鿱뷳답ꟷ믹췻쟽㧿㨁㘃", a_), global::CommonResources.AcgResources.ID_TRUNKINGCALLHOTLIST, null, null, true, false);
			this.trkPerCallPageHotListItemID_A19982.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerCallPageHotListItemID_A19982.DataTransferOrder = 30;
			this.trkPerFeaturesAstroAlertingToneTable = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋裍뗏돑ꃓꏕ꫗뿙꿛鿝鏟雡難觥ꧧ蛩觫鳭蓯鯱髳釵곷闹鋻鯽哿持昃樅洇", a_), global::CommonResources.AcgResources.ID_TONESIGNALINGLIST, new string[]
			{
				global::CommonResources.AcgResources.ID_TONESIGNALINGDISABLED
			}, new int[1], true, false);
			this.trkPerFeaturesAstroAlertingToneTable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerFeaturesAstroAlertingToneTable.DataTransferOrder = 41;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臁ꗃ꫅꓇胏돑돓돕", a_);
			base.Id = 10181;
			base.UIName = global::CommonResources.AcgResources.ID_CALLPAGE;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0015AD44 File Offset: 0x00158F44
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1349255178;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)347340822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.trkPerFeaturesAstroAlertingToneTable = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗鳙맛뿝铟韡難菥鯧ꯩ鿫髭苯鷱뗳髵鷷裹裻韽滿攁倃椅昇漉堋漍爏縑焓", a_), global::CommonResources.AcgResources.ID_TONESIGNALINGLIST, new string[]
					{
						global::CommonResources.AcgResources.ID_TONESIGNALINGDISABLED
					}, new int[1], true, false);
					this.trkPerFeaturesAstroAlertingToneTable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerFeaturesAstroAlertingToneTable.DataTransferOrder = 41;
					num = (short)1475411980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.trkPerCallPagePrivateCallOperation_A8759 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.indexTrkPerCallPagePrivateCallOperation_A8759LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.idTrkPerCallPagePrivateCallOperation_A8759LovStrs), this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧뫩黫蟭蛯鏱胳鏵믷鯹郻鋽俿爁愃琅椇縉攋愍縏䴑唓⸕⼗⼙┛", a_), global::CommonResources.AcgResources.ID_PRIVATECALLOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerCallPagePrivateCallOperation_A8759LovStrs);
					this.trkPerCallPagePrivateCallOperation_A8759.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerCallPagePrivateCallOperation_A8759.DataTransferOrder = 37;
					num = (short)1654390797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗鳙맛뿝铟韡難菥鯧ꯩ鿫髭苯鷱뗳髵鷷裹裻韽滿攁倃椅昇漉堋漍爏縑焓", a_)))
					{
						num = (short)1535442945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62F;
				case 4:
					num = (short)1255538689;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꏩ苫귭釯黱飳ꏵ请鿹軻뿽泿朁瘃爅䴇搉洋氍簏眑䬓圕℗⸙⼛⨝", a_)))
					{
						num = (short)748486674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 5:
				{
					num = (short)1046991321;
					short num3 = num;
					num = (short)2037699033;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_261;
					default:
						num = (short)498925568;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꯩ駫髭鿯鿱闳苵釷駹뿻鿽泿渁䔃樅洇砉砋儍儏⬑⌓⌕Ⱇ", a_)))
						{
							num = (short)1213530120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_482;
					}
					break;
				}
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꧩ跫苭鳯돱飳鏵諷軹곻鿽柿朁䬃瘅洇砉洋稍礏紑稓䤕夗ⴙ⤛✝ᜟ", a_)))
					{
						num = (short)561643531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E4;
				case 7:
					goto IL_3E4;
				case 8:
				{
					num = (short)1187577856;
					short num4 = num;
					this.trkPerCallPageAutomaticCallAlert_A9754 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꯩ駫髭鿯鿱闳苵釷駹뿻鿽泿渁䔃樅洇砉砋儍儏⬑⌓⌕Ⱇ", a_), global::CommonResources.AcgResources.ID_AUTOMATICCALLALERT);
					this.trkPerCallPageAutomaticCallAlert_A9754.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerCallPageAutomaticCallAlert_A9754.DataTransferOrder = 40;
					num = (short)426442772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꋩ菫髭볯鯱蟳苵뇷軹駻鏽䧿䘁嬃䜅㤇㌉㔋㘍∏", a_)))
					{
						num = (short)196018191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_434;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 11:
					this.trkPerCallPageCallAlertPageOperation_A7597 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꧩ跫苭鳯돱飳鏵諷軹곻鿽柿朁䬃瘅洇砉洋稍礏紑稓䤕夗ⴙ⤛✝ᜟ", a_), global::CommonResources.AcgResources.ID_CALLALERTPAGEOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerCallPageCallAlertPageOperation_A7597LovStrs);
					this.trkPerCallPageCallAlertPageOperation_A7597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerCallPageCallAlertPageOperation_A7597.DataTransferOrder = 7;
					num = (short)623509511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_386;
				case 13:
					goto IL_56F;
				case 14:
					goto IL_434;
				case 15:
					this.trkPerCallPageHotListItemID_A19982 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꋩ菫髭볯鯱蟳苵뇷軹駻鏽䧿䘁嬃䜅㤇㌉㔋㘍∏", a_), global::CommonResources.AcgResources.ID_TRUNKINGCALLHOTLIST, null, null, true, false);
					this.trkPerCallPageHotListItemID_A19982.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerCallPageHotListItemID_A19982.DataTransferOrder = 30;
					num = (short)595591182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.trkPerCallPagePrivateCallType_A8760 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧뫩黫蟭蛯鏱胳鏵믷鯹郻鋽哿笁球挅圇䬉㐋㤍☏∑", a_), global::CommonResources.AcgResources.ID_PRIVATECALLTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerCallPagePrivateCallType_A8760LovStrs);
					this.trkPerCallPagePrivateCallType_A8760.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerCallPagePrivateCallType_A8760.DataTransferOrder = 4;
					num = (short)1495662613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧뫩黫蟭蛯鏱胳鏵믷鯹郻鋽哿笁球挅圇䬉㐋㤍☏∑", a_)))
					{
						num = (short)1941504016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5BA;
				case 18:
					this.trkPerCallPageInCallUserAlertEnable_A9434 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧ꏩ苫귭釯黱飳ꏵ请鿹軻뿽泿朁瘃爅䴇搉洋氍簏眑䬓圕℗⸙⼛⨝", a_), global::CommonResources.AcgResources.ID_INCALLUSERALERTENABLE);
					this.trkPerCallPageInCallUserAlertEnable_A9434.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerCallPageInCallUserAlertEnable_A9434.DataTransferOrder = 39;
					num = (short)1535508503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1308557318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_482;
				case 21:
					goto IL_5BA;
				case 22:
					if (producerFields != null)
					{
						num = (short)334823443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62F;
				case 23:
					goto IL_261;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗駙뷛닝賟닡藣臥跧뫩黫蟭蛯鏱胳鏵믷鯹郻鋽俿爁愃琅椇縉攋愍縏䴑唓⸕⼗⼙┛", a_)))
					{
						num = (short)501153794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56F;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2069626880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_261:
				num = (short)861929477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E4:
				num = (short)480509976;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_434:
				num = (short)1567686659;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_482:
				num = (short)400097289;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_56F:
				num = (short)1894449169;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5BA:
				num = (short)994902020;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_386:
			IL_62F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跍뇏뻑룓龎賛뿝蟟蟡", a_);
			base.Id = 10181;
			base.UIName = global::CommonResources.AcgResources.ID_CALLPAGE;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0015B3B4 File Offset: 0x001595B4
		public override void PopulateReferences()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
			short num2;
			global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset> list;
			global::System.Collections.Generic.List<string> list2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (trunkingPersonality.General.TrkPerGeneralProtocolType_A8767 == null)
					{
						return;
					}
					num2 = (short)1781603475;
					short num3 = num2;
					num2 = (short)1210588307;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1169555457;
						if (num2 != 0)
						{
						}
						num2 = (short)1577254912;
						if (num2 != 0)
						{
						}
						num2 = (short)931594242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1206452224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)299368448;
					short num4 = num2;
					((global::AcpBusinessLayer.AcpSparseLOVField)trunkingPersonality.General.TrkPerGeneralProtocolType_A8767).SetBuddyRecRefField(this.trkPerCallPageHotListItemID_A19982, list, list2);
					num2 = (short)1457258500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (trunkingPersonality != null)
					{
						num2 = (short)561053697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					return;
				}
				goto IL_24;
			}
			return;
			IL_24:
			this.trkPerFeaturesAstroAlertingToneTable.SetRecset(this.a(4156));
			list2 = new global::System.Collections.Generic.List<string>();
			list = new global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset>();
			list.Add((global::AcpBusinessLayer.Recordset)this.a(2214));
			list2.Add(global::CommonResources.AcgResources.ID_II);
			list.Add((global::AcpBusinessLayer.Recordset)this.a(2208));
			list2.Add(global::CommonResources.AcgResources.ID_ASTRO25);
			trunkingPersonality = (base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality);
			num2 = (short)937754627;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0015B5A8 File Offset: 0x001597A8
		public override void DropReferences()
		{
			short num = (short)1955797004;
			short num2 = num;
			num = (short)434378764;
			switch (num2 == num)
			{
			}
			num = (short)238026753;
			if (num != 0)
			{
			}
			num = (short)1513160704;
			short num3 = num;
			num = (short)1531117568;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0015B654 File Offset: 0x00159854
		public override void SetConstraints()
		{
			short num = (short)641167194;
			short num2 = num;
			num = (short)608333658;
			switch (num2 == num)
			{
			}
			num = (short)680919041;
			if (num != 0)
			{
			}
			num = (short)1764294656;
			short num3 = num;
			num = (short)1854210048;
			if (num != 0)
			{
			}
			this.trkPerCallPageCallAlertPageOperation_A7597.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkDVRSActViaCallAlertApp);
			this.trkPerCallPageCallAlertPageOperation_A7597.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkDVRSActViaCallAlertValid);
			this.trkPerCallPagePrivateCallOperation_A8759.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConPrivateCallTypeIsNotNone);
			this.trkPerCallPagePrivateCallOperation_A8759.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conPvtCallOperNotRespOnlyOrPvtCallTypeNotPcWithCa);
			this.trkPerCallPageInCallUserAlertEnable_A9434.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkCallAlertIsNotDisabledOrWithUnmuteEnable);
			this.trkPerCallPageAutomaticCallAlert_A9754.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConEnhancedPrivateCallWithCallAlertEnabled);
			this.trkPerCallPageHotListItemID_A19982.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conOperationOrTypeIsNotDisabled);
			this.trkPerFeaturesAstroAlertingToneTable.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkPerIsASTRO25);
			this.trkPerFeaturesAstroAlertingToneTable.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSignalingToneListValid);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0015B7CC File Offset: 0x001599CC
		public override void SetupDependencies()
		{
			short num = (short)1886760070;
			short num2 = num;
			num = (short)1487056006;
			switch (num2 == num)
			{
			}
			num = (short)533069825;
			if (num != 0)
			{
			}
			num = (short)270925824;
			short num3 = num;
			num = (short)1795686400;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkPerCallPageCallAlertPageOperation_A7597);
			this.trkPerCallPagePrivateCallType_A8760.AddDependentObject(this.trkPerCallPagePrivateCallOperation_A8759);
			this.trkPerCallPageCallAlertPageOperation_A7597.AddDependentObject(this.trkPerCallPageInCallUserAlertEnable_A9434);
			this.trkPerCallPagePrivateCallType_A8760.AddDependentObject(this.trkPerCallPageAutomaticCallAlert_A9754);
			this.trkPerCallPagePrivateCallType_A8760.AddDependentObject(this.trkPerCallPageHotListItemID_A19982);
			this.trkPerCallPageCallAlertPageOperation_A7597.AddDependentObject(this.trkPerCallPageHotListItemID_A19982);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerFeaturesAstroAlertingToneTable);
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0015B90C File Offset: 0x00159B0C
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList ToneSignalingListForTrkPerFeaturesAstroAlertingToneTable
		{
			get
			{
				short num = (short)1848076869;
				short num2 = num;
				num = (short)704997957;
				switch (num2 == num)
				{
				}
				num = (short)1337589760;
				if (num != 0)
				{
				}
				num = (short)2065367040;
				short num3 = num;
				num = (short)1474101249;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x0015B9C8 File Offset: 0x00159BC8
		public bool HasDiffs
		{
			get
			{
				short num = (short)313829332;
				short num2 = num;
				num = (short)1613080532;
				switch (num2 == num)
				{
				}
				num = (short)1091305473;
				if (num != 0)
				{
				}
				num = (short)314900480;
				short num3 = num;
				num = (short)2146304000;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0015BA78 File Offset: 0x00159C78
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0015BB2C File Offset: 0x00159D2C
		public int TrkPerCallPageCallAlertPageOperation_A7597Value
		{
			get
			{
				short num = (short)1725693953;
				if (num != 0)
				{
				}
				num = (short)199315445;
				short num2 = num;
				num = (short)750866421;
				switch (num2 == num)
				{
				}
				num = (short)462815232;
				short num3 = num;
				num = (short)603848704;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.Value;
			}
			set
			{
				short num = (short)376614620;
				short num2 = num;
				num = (short)671330012;
				switch (num2 == num)
				{
				}
				num = (short)1076166657;
				if (num != 0)
				{
				}
				num = (short)120127488;
				short num3 = num;
				num = (short)1577517056;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.Value = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0015BBE4 File Offset: 0x00159DE4
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x0015BC98 File Offset: 0x00159E98
		public string TrkPerCallPageCallAlertPageOperation_A7597_UIValue
		{
			get
			{
				short num = (short)1747058988;
				short num2 = num;
				num = (short)1493893420;
				switch (num2 == num)
				{
				}
				num = (short)77201409;
				if (num != 0)
				{
				}
				num = (short)474677248;
				short num3 = num;
				num = (short)1760231424;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.UIValue;
			}
			set
			{
				short num = (short)1211326038;
				short num2 = num;
				num = (short)540696150;
				switch (num2 == num)
				{
				}
				num = (short)1707278337;
				if (num != 0)
				{
				}
				num = (short)1154220032;
				short num3 = num;
				num = (short)1164509184;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.UIValue = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0015BD4C File Offset: 0x00159F4C
		public global::AcpBusinessLayer.AcpListField TrkPerCallPageCallAlertPageOperation_A7597
		{
			get
			{
				short num = (short)502005760;
				short num2 = num;
				num = (short)613875713;
				if (num != 0)
				{
				}
				num = (short)1225020993;
				short num3 = num;
				num = (short)1766479425;
				switch (num3 == num)
				{
				}
				num = (short)1967063040;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0015BDFC File Offset: 0x00159FFC
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0015BEAC File Offset: 0x0015A0AC
		public bool TrkPerCallPageCallAlertPageOperation_A7597_Applicable
		{
			get
			{
				short num = (short)143982592;
				short num2 = num;
				num = (short)1133093244;
				short num3 = num;
				num = (short)1758110076;
				switch (num3 == num)
				{
				}
				num = (short)473366529;
				if (num != 0)
				{
				}
				num = (short)1048248320;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.Applicable;
			}
			set
			{
				short num = (short)1756168192;
				short num2 = num;
				num = (short)1083458951;
				short num3 = num;
				num = (short)1533166983;
				switch (num3 == num)
				{
				}
				num = (short)261292033;
				if (num != 0)
				{
				}
				num = (short)20971520;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.Applicable = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0015BF60 File Offset: 0x0015A160
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0015C014 File Offset: 0x0015A214
		public bool TrkPerCallPageCallAlertPageOperation_A7597_Valid
		{
			get
			{
				short num = (short)1502150656;
				short num2 = num;
				num = (short)1487433294;
				short num3 = num;
				num = (short)1372679758;
				switch (num3 == num)
				{
				}
				num = (short)1084686337;
				if (num != 0)
				{
				}
				num = (short)337379328;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.Valid;
			}
			set
			{
				short num = (short)1704394752;
				short num2 = num;
				num = (short)871529255;
				short num3 = num;
				num = (short)1490254631;
				switch (num3 == num)
				{
				}
				num = (short)290914304;
				if (num != 0)
				{
				}
				num = (short)1635844097;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.Valid = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0015C0C8 File Offset: 0x0015A2C8
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0015C180 File Offset: 0x0015A380
		public bool TrkPerCallPageCallAlertPageOperation_A7597_Visible
		{
			get
			{
				short num = (short)1865285632;
				short num2 = num;
				num = (short)1903518525;
				short num3 = num;
				num = (short)1009214269;
				switch (num3 == num)
				{
				}
				num = (short)501678081;
				if (num != 0)
				{
				}
				num = (short)1203437568;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.Visible;
			}
			set
			{
				short num = (short)344457216;
				short num2 = num;
				num = (short)1301237586;
				short num3 = num;
				num = (short)2015383378;
				switch (num3 == num)
				{
				}
				num = (short)2017853440;
				if (num != 0)
				{
				}
				num = (short)319160321;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.Visible = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0015C234 File Offset: 0x0015A434
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x0015C2EC File Offset: 0x0015A4EC
		public bool TrkPerCallPageCallAlertPageOperation_A7597_Editable
		{
			get
			{
				short num = (short)1027670016;
				short num2 = num;
				num = (short)1807616624;
				short num3 = num;
				num = (short)1085213296;
				switch (num3 == num)
				{
				}
				num = (short)1365704705;
				if (num != 0)
				{
				}
				num = (short)869466112;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.Editable;
			}
			set
			{
				short num = (short)2112290816;
				short num2 = num;
				num = (short)24398826;
				short num3 = num;
				num = (short)1755532266;
				switch (num3 == num)
				{
				}
				num = (short)2063990784;
				if (num != 0)
				{
				}
				num = (short)1463943169;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.Editable = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x0015C3A0 File Offset: 0x0015A5A0
		internal string TrkPerCallPageCallAlertPageOperation_A7597_UILabel
		{
			get
			{
				short num = (short)1949892608;
				short num2 = num;
				num = (short)1637778366;
				short num3 = num;
				num = (short)1739752382;
				switch (num3 == num)
				{
				}
				num = (short)7602176;
				if (num != 0)
				{
				}
				num = (short)969736193;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.UIName;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0015C454 File Offset: 0x0015A654
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x0015C50C File Offset: 0x0015A70C
		internal bool TrkPerCallPageCallAlertPageOperation_A7597_HiddenStatic
		{
			get
			{
				short num = (short)1700069376;
				short num2 = num;
				num = (short)1222956932;
				short num3 = num;
				num = (short)856545156;
				switch (num3 == num)
				{
				}
				num = (short)2073034752;
				if (num != 0)
				{
				}
				num = (short)9830401;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.HiddenStatic;
			}
			set
			{
				short num = (short)655949824;
				short num2 = num;
				num = (short)2008419550;
				short num3 = num;
				num = (short)2070088926;
				switch (num3 == num)
				{
				}
				num = (short)817496065;
				if (num != 0)
				{
				}
				num = (short)1223229440;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.HiddenStatic = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x0015C5C4 File Offset: 0x0015A7C4
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0015C67C File Offset: 0x0015A87C
		internal bool TrkPerCallPageCallAlertPageOperation_A7597_HiddenDynamic
		{
			get
			{
				short num = (short)1919025152;
				short num2 = num;
				num = (short)1490990829;
				short num3 = num;
				num = (short)517584621;
				switch (num3 == num)
				{
				}
				num = (short)118751233;
				if (num != 0)
				{
				}
				num = (short)1976434688;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597.HiddenDynamic;
			}
			set
			{
				short num = (short)566427648;
				short num2 = num;
				num = (short)522185682;
				short num3 = num;
				num = (short)1932585938;
				switch (num3 == num)
				{
				}
				num = (short)1548156929;
				if (num != 0)
				{
				}
				num = (short)1858011136;
				if (num != 0)
				{
				}
				this.trkPerCallPageCallAlertPageOperation_A7597.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0015C730 File Offset: 0x0015A930
		public bool TrkPerCallPageCallAlertPageOperation_A7597_HasDiffs
		{
			get
			{
				short num = (short)1347944448;
				short num2 = num;
				num = (short)1894389354;
				short num3 = num;
				num = (short)501093994;
				switch (num3 == num)
				{
				}
				num = (short)40435713;
				if (num != 0)
				{
				}
				num = (short)144244736;
				if (num != 0)
				{
				}
				return this.trkPerCallPageCallAlertPageOperation_A7597._HasDiffs;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0015C7E4 File Offset: 0x0015A9E4
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x0015C89C File Offset: 0x0015AA9C
		public int TrkPerCallPagePrivateCallOperation_A8759Value
		{
			get
			{
				short num = (short)1772814336;
				short num2 = num;
				num = (short)1025722915;
				short num3 = num;
				num = (short)1399736867;
				switch (num3 == num)
				{
				}
				num = (short)1767505920;
				if (num != 0)
				{
				}
				num = (short)1336868865;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.Value;
			}
			set
			{
				short num = (short)880541696;
				short num2 = num;
				num = (short)1065484289;
				if (num != 0)
				{
				}
				num = (short)1605712664;
				short num3 = num;
				num = (short)1851800344;
				switch (num3 == num)
				{
				}
				num = (short)2088501248;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.Value = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0015C954 File Offset: 0x0015AB54
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0015CA0C File Offset: 0x0015AC0C
		public string TrkPerCallPagePrivateCallOperation_A8759_UIValue
		{
			get
			{
				short num = (short)1268514816;
				short num2 = num;
				num = (short)1936815345;
				short num3 = num;
				num = (short)1937994993;
				switch (num3 == num)
				{
				}
				num = (short)742653953;
				if (num != 0)
				{
				}
				num = (short)1476329472;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.UIValue;
			}
			set
			{
				short num = (short)1334706176;
				short num2 = num;
				num = (short)1366661993;
				short num3 = num;
				num = (short)2022480745;
				switch (num3 == num)
				{
				}
				num = (short)719060992;
				if (num != 0)
				{
				}
				num = (short)1624571905;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.UIValue = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x0015CAC4 File Offset: 0x0015ACC4
		public global::AcpBusinessLayer.AcpListField TrkPerCallPagePrivateCallOperation_A8759
		{
			get
			{
				short num = (short)1535246336;
				short num2 = num;
				num = (short)219086849;
				if (num != 0)
				{
				}
				num = (short)828514056;
				short num3 = num;
				num = (short)1814634248;
				switch (num3 == num)
				{
				}
				num = (short)533659648;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0015CB74 File Offset: 0x0015AD74
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0015CC28 File Offset: 0x0015AE28
		public bool TrkPerCallPagePrivateCallOperation_A8759_Applicable
		{
			get
			{
				short num = (short)815005696;
				short num2 = num;
				num = (short)1353743851;
				short num3 = num;
				num = (short)1061715435;
				switch (num3 == num)
				{
				}
				num = (short)1344339969;
				if (num != 0)
				{
				}
				num = (short)14876672;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.Applicable;
			}
			set
			{
				short num = (short)948436992;
				short num2 = num;
				num = (short)1184087155;
				short num3 = num;
				num = (short)1296612467;
				switch (num3 == num)
				{
				}
				num = (short)121503745;
				if (num != 0)
				{
				}
				num = (short)39583744;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.Applicable = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0015CCE0 File Offset: 0x0015AEE0
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0015CD94 File Offset: 0x0015AF94
		public bool TrkPerCallPagePrivateCallOperation_A8759_Valid
		{
			get
			{
				short num = (short)1025638400;
				short num2 = num;
				num = (short)1935029201;
				short num3 = num;
				num = (short)1414411217;
				switch (num3 == num)
				{
				}
				num = (short)1099825153;
				if (num != 0)
				{
				}
				num = (short)1058471936;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.Valid;
			}
			set
			{
				short num = (short)152043520;
				short num2 = num;
				num = (short)1739216723;
				short num3 = num;
				num = (short)1222334291;
				switch (num3 == num)
				{
				}
				num = (short)1527709697;
				if (num != 0)
				{
				}
				num = (short)1841758208;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.Valid = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x0015CE4C File Offset: 0x0015B04C
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0015CF00 File Offset: 0x0015B100
		public bool TrkPerCallPagePrivateCallOperation_A8759_Visible
		{
			get
			{
				short num = (short)1121779712;
				short num2 = num;
				num = (short)606529785;
				short num3 = num;
				num = (short)87812345;
				switch (num3 == num)
				{
				}
				num = (short)1198391297;
				if (num != 0)
				{
				}
				num = (short)1926955008;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.Visible;
			}
			set
			{
				short num = (short)545980416;
				short num2 = num;
				num = (short)103354942;
				short num3 = num;
				num = (short)112661054;
				switch (num3 == num)
				{
				}
				num = (short)293404673;
				if (num != 0)
				{
				}
				num = (short)1497694208;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.Visible = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0015CFB8 File Offset: 0x0015B1B8
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0015D06C File Offset: 0x0015B26C
		public bool TrkPerCallPagePrivateCallOperation_A8759_Editable
		{
			get
			{
				short num = (short)1890975744;
				short num2 = num;
				num = (short)1124073473;
				if (num != 0)
				{
				}
				num = (short)633617737;
				short num3 = num;
				num = (short)704855369;
				switch (num3 == num)
				{
				}
				num = (short)915472384;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.Editable;
			}
			set
			{
				short num = (short)658505728;
				short num2 = num;
				num = (short)477875505;
				short num3 = num;
				num = (short)1441123633;
				switch (num3 == num)
				{
				}
				num = (short)2104295425;
				if (num != 0)
				{
				}
				num = (short)131072;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.Editable = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x0015D120 File Offset: 0x0015B320
		internal string TrkPerCallPagePrivateCallOperation_A8759_UILabel
		{
			get
			{
				short num = (short)1891368960;
				short num2 = num;
				num = (short)2070785704;
				short num3 = num;
				num = (short)1956818600;
				switch (num3 == num)
				{
				}
				num = (short)313982976;
				if (num != 0)
				{
				}
				num = (short)329121793;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.UIName;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x0015D1D4 File Offset: 0x0015B3D4
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x0015D288 File Offset: 0x0015B488
		internal bool TrkPerCallPagePrivateCallOperation_A8759_HiddenStatic
		{
			get
			{
				short num = (short)1659633664;
				short num2 = num;
				num = (short)708575233;
				if (num != 0)
				{
				}
				num = (short)1787726962;
				short num3 = num;
				num = (short)2007600242;
				switch (num3 == num)
				{
				}
				num = (short)206372864;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.HiddenStatic;
			}
			set
			{
				short num = (short)1756692480;
				short num2 = num;
				num = (short)1336103080;
				short num3 = num;
				num = (short)1864257704;
				switch (num3 == num)
				{
				}
				num = (short)1672675328;
				if (num != 0)
				{
				}
				num = (short)1962672129;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.HiddenStatic = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0015D33C File Offset: 0x0015B53C
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x0015D3F0 File Offset: 0x0015B5F0
		internal bool TrkPerCallPagePrivateCallOperation_A8759_HiddenDynamic
		{
			get
			{
				short num = (short)1787822080;
				short num2 = num;
				num = (short)546977086;
				short num3 = num;
				num = (short)1444951358;
				switch (num3 == num)
				{
				}
				num = (short)1977548801;
				if (num != 0)
				{
				}
				num = (short)1366949888;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759.HiddenDynamic;
			}
			set
			{
				short num = (short)819003392;
				short num2 = num;
				num = (short)1272709121;
				if (num != 0)
				{
				}
				num = (short)874827287;
				short num3 = num;
				num = (short)1361956375;
				switch (num3 == num)
				{
				}
				num = (short)943652864;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallOperation_A8759.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0015D4A4 File Offset: 0x0015B6A4
		public bool TrkPerCallPagePrivateCallOperation_A8759_HasDiffs
		{
			get
			{
				short num = (short)989200384;
				short num2 = num;
				num = (short)769486575;
				short num3 = num;
				num = (short)1990094575;
				switch (num3 == num)
				{
				}
				num = (short)2092367872;
				if (num != 0)
				{
				}
				num = (short)824639489;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallOperation_A8759._HasDiffs;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x0015D558 File Offset: 0x0015B758
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0015D60C File Offset: 0x0015B80C
		public int TrkPerCallPagePrivateCallType_A8760Value
		{
			get
			{
				short num = (short)1140850688;
				short num2 = num;
				num = (short)1494595267;
				short num3 = num;
				num = (short)1188148931;
				switch (num3 == num)
				{
				}
				num = (short)1990131713;
				if (num != 0)
				{
				}
				num = (short)255459328;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.Value;
			}
			set
			{
				short num = (short)25493504;
				short num2 = num;
				num = (short)1287182200;
				short num3 = num;
				num = (short)1840371576;
				switch (num3 == num)
				{
				}
				num = (short)764870656;
				if (num != 0)
				{
				}
				num = (short)927203329;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.Value = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x0015D6C0 File Offset: 0x0015B8C0
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x0015D774 File Offset: 0x0015B974
		public string TrkPerCallPagePrivateCallType_A8760_UIValue
		{
			get
			{
				short num = (short)369819648;
				short num2 = num;
				num = (short)24095474;
				short num3 = num;
				num = (short)1418963698;
				switch (num3 == num)
				{
				}
				num = (short)962396161;
				if (num != 0)
				{
				}
				num = (short)992542720;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.UIValue;
			}
			set
			{
				short num = (short)1885732864;
				short num2 = num;
				num = (short)395079892;
				short num3 = num;
				num = (short)1632268500;
				switch (num3 == num)
				{
				}
				num = (short)1668808705;
				if (num != 0)
				{
				}
				num = (short)564330496;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.UIValue = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x0015D828 File Offset: 0x0015BA28
		public global::AcpBusinessLayer.AcpListField TrkPerCallPagePrivateCallType_A8760
		{
			get
			{
				short num = (short)246874112;
				short num2 = num;
				num = (short)1810672017;
				short num3 = num;
				num = (short)1010674065;
				switch (num3 == num)
				{
				}
				num = (short)1818296320;
				if (num != 0)
				{
				}
				num = (short)1770127361;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x0015D8D8 File Offset: 0x0015BAD8
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x0015D98C File Offset: 0x0015BB8C
		public bool TrkPerCallPagePrivateCallType_A8760_Applicable
		{
			get
			{
				short num = (short)1924399104;
				short num2 = num;
				num = (short)2129247779;
				short num3 = num;
				num = (short)5226019;
				switch (num3 == num)
				{
				}
				num = (short)1499332609;
				if (num != 0)
				{
				}
				num = (short)268959744;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.Applicable;
			}
			set
			{
				short num = (short)1710882816;
				short num2 = num;
				num = (short)1056374785;
				if (num != 0)
				{
				}
				num = (short)1806990630;
				short num3 = num;
				num = (short)733052198;
				switch (num3 == num)
				{
				}
				num = (short)1050017792;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.Applicable = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x0015DA44 File Offset: 0x0015BC44
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x0015DAFC File Offset: 0x0015BCFC
		public bool TrkPerCallPagePrivateCallType_A8760_Valid
		{
			get
			{
				short num = (short)795803648;
				short num2 = num;
				num = (short)1830307452;
				short num3 = num;
				num = (short)1825982076;
				switch (num3 == num)
				{
				}
				num = (short)643170305;
				if (num != 0)
				{
				}
				num = (short)1122172928;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.Valid;
			}
			set
			{
				short num = (short)919863296;
				short num2 = num;
				num = (short)1182571549;
				short num3 = num;
				num = (short)1974574109;
				switch (num3 == num)
				{
				}
				num = (short)1935933440;
				if (num != 0)
				{
				}
				num = (short)1382678529;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.Valid = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x0015DBB0 File Offset: 0x0015BDB0
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x0015DC64 File Offset: 0x0015BE64
		public bool TrkPerCallPagePrivateCallType_A8760_Visible
		{
			get
			{
				short num = (short)1830420480;
				short num2 = num;
				num = (short)1534001153;
				if (num != 0)
				{
				}
				num = (short)702754318;
				short num3 = num;
				num = (short)1187589646;
				switch (num3 == num)
				{
				}
				num = (short)683409408;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.Visible;
			}
			set
			{
				short num = (short)68026368;
				short num2 = num;
				num = (short)1577254913;
				if (num != 0)
				{
				}
				num = (short)1124989525;
				short num3 = num;
				num = (short)1266547285;
				switch (num3 == num)
				{
				}
				num = (short)1033633792;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.Visible = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x0015DD20 File Offset: 0x0015BF20
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0015DDD4 File Offset: 0x0015BFD4
		public bool TrkPerCallPagePrivateCallType_A8760_Editable
		{
			get
			{
				short num = (short)1259732992;
				short num2 = num;
				num = (short)1216610305;
				if (num != 0)
				{
				}
				num = (short)127930292;
				short num3 = num;
				num = (short)1959989172;
				switch (num3 == num)
				{
				}
				num = (short)1667235840;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.Editable;
			}
			set
			{
				short num = (short)1012465664;
				short num2 = num;
				num = (short)2054119711;
				short num3 = num;
				num = (short)565141791;
				switch (num3 == num)
				{
				}
				num = (short)1313538049;
				if (num != 0)
				{
				}
				num = (short)1778712576;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.Editable = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x0015DE88 File Offset: 0x0015C088
		internal string TrkPerCallPagePrivateCallType_A8760_UILabel
		{
			get
			{
				short num = (short)1369440256;
				short num2 = num;
				num = (short)349143944;
				short num3 = num;
				num = (short)844792712;
				switch (num3 == num)
				{
				}
				num = (short)1338769409;
				if (num != 0)
				{
				}
				num = (short)943849472;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.UIName;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x0015DF40 File Offset: 0x0015C140
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x0015DFF4 File Offset: 0x0015C1F4
		internal bool TrkPerCallPagePrivateCallType_A8760_HiddenStatic
		{
			get
			{
				short num = (short)1836253184;
				short num2 = num;
				num = (short)1268618779;
				short num3 = num;
				num = (short)1038521883;
				switch (num3 == num)
				{
				}
				num = (short)226033665;
				if (num != 0)
				{
				}
				num = (short)1586364416;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.HiddenStatic;
			}
			set
			{
				short num = (short)2132017152;
				short num2 = num;
				num = (short)2100109345;
				short num3 = num;
				num = (short)124264481;
				switch (num3 == num)
				{
				}
				num = (short)319422464;
				if (num != 0)
				{
				}
				num = (short)604504065;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.HiddenStatic = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x0015E0AC File Offset: 0x0015C2AC
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x0015E160 File Offset: 0x0015C360
		internal bool TrkPerCallPagePrivateCallType_A8760_HiddenDynamic
		{
			get
			{
				short num = (short)724369408;
				short num2 = num;
				num = (short)1447980219;
				short num3 = num;
				num = (short)55274683;
				switch (num3 == num)
				{
				}
				num = (short)1998716929;
				if (num != 0)
				{
				}
				num = (short)1507196928;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760.HiddenDynamic;
			}
			set
			{
				short num = (short)1503002624;
				short num2 = num;
				num = (short)749918979;
				short num3 = num;
				num = (short)1660148483;
				switch (num3 == num)
				{
				}
				num = (short)731643905;
				if (num != 0)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				this.trkPerCallPagePrivateCallType_A8760.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0015E214 File Offset: 0x0015C414
		public bool TrkPerCallPagePrivateCallType_A8760_HasDiffs
		{
			get
			{
				short num = (short)112328704;
				short num2 = num;
				num = (short)1835537266;
				short num3 = num;
				num = (short)1242633074;
				switch (num3 == num)
				{
				}
				num = (short)1018691585;
				if (num != 0)
				{
				}
				num = (short)1123090432;
				if (num != 0)
				{
				}
				return this.trkPerCallPagePrivateCallType_A8760._HasDiffs;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0015E2CC File Offset: 0x0015C4CC
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0015E380 File Offset: 0x0015C580
		public bool TrkPerCallPageInCallUserAlertEnable_A9434Value
		{
			get
			{
				short num = (short)947585024;
				short num2 = num;
				num = (short)1714749441;
				if (num != 0)
				{
				}
				num = (short)350085667;
				short num3 = num;
				num = (short)535159331;
				switch (num3 == num)
				{
				}
				num = (short)432472064;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.Value;
			}
			set
			{
				short num = (short)134021120;
				short num2 = num;
				num = (short)770498667;
				short num3 = num;
				num = (short)1323163755;
				switch (num3 == num)
				{
				}
				num = (short)871497729;
				if (num != 0)
				{
				}
				num = (short)1070465024;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.Value = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0015E434 File Offset: 0x0015C634
		public global::AcpBusinessLayer.AcpField<bool> TrkPerCallPageInCallUserAlertEnable_A9434
		{
			get
			{
				short num = (short)1479737344;
				short num2 = num;
				num = (short)1600231885;
				short num3 = num;
				num = (short)985700813;
				switch (num3 == num)
				{
				}
				num = (short)1491009536;
				if (num != 0)
				{
				}
				num = (short)1660354561;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x0015E4E4 File Offset: 0x0015C6E4
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x0015E598 File Offset: 0x0015C798
		public bool TrkPerCallPageInCallUserAlertEnable_A9434_UIValue
		{
			get
			{
				short num = (short)510656512;
				short num2 = num;
				num = (short)1273167873;
				if (num != 0)
				{
				}
				num = (short)266497450;
				short num3 = num;
				num = (short)991063466;
				switch (num3 == num)
				{
				}
				num = (short)1190920192;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.Value;
			}
			set
			{
				short num = (short)473694208;
				short num2 = num;
				num = (short)1432022579;
				short num3 = num;
				num = (short)168291891;
				switch (num3 == num)
				{
				}
				num = (short)2139029505;
				if (num != 0)
				{
				}
				num = (short)1325465600;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.Value = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x0015E650 File Offset: 0x0015C850
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0015E704 File Offset: 0x0015C904
		public bool TrkPerCallPageInCallUserAlertEnable_A9434_Applicable
		{
			get
			{
				short num = (short)894042112;
				short num2 = num;
				num = (short)1465288021;
				short num3 = num;
				num = (short)247629141;
				switch (num3 == num)
				{
				}
				num = (short)1102577664;
				if (num != 0)
				{
				}
				num = (short)436994049;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.Applicable;
			}
			set
			{
				short num = (short)840853736;
				short num2 = num;
				num = (short)1792633064;
				switch (num2 == num)
				{
				}
				num = (short)769261568;
				short num3 = num;
				num = (short)1359413249;
				if (num != 0)
				{
				}
				num = (short)2030960640;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.Applicable = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x0015E7B8 File Offset: 0x0015C9B8
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0015E870 File Offset: 0x0015CA70
		public bool TrkPerCallPageInCallUserAlertEnable_A9434_Valid
		{
			get
			{
				short num = (short)1459758580;
				short num2 = num;
				num = (short)236791284;
				switch (num2 == num)
				{
				}
				num = (short)1958281216;
				short num3 = num;
				num = (short)1512570881;
				if (num != 0)
				{
				}
				num = (short)657719296;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.Valid;
			}
			set
			{
				short num = (short)394953249;
				short num2 = num;
				num = (short)234783265;
				switch (num2 == num)
				{
				}
				num = (short)2021130240;
				short num3 = num;
				num = (short)2032205825;
				if (num != 0)
				{
				}
				num = (short)412942336;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.Valid = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0015E924 File Offset: 0x0015CB24
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0015E9DC File Offset: 0x0015CBDC
		public bool TrkPerCallPageInCallUserAlertEnable_A9434_Visible
		{
			get
			{
				short num = (short)1352817607;
				short num2 = num;
				num = (short)18045895;
				switch (num2 == num)
				{
				}
				num = (short)2032599040;
				short num3 = num;
				num = (short)2103050241;
				if (num != 0)
				{
				}
				num = (short)1745158144;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.Visible;
			}
			set
			{
				short num = (short)1907867512;
				short num2 = num;
				num = (short)1655816056;
				switch (num2 == num)
				{
				}
				num = (short)1519124480;
				short num3 = num;
				num = (short)2001797120;
				if (num != 0)
				{
				}
				num = (short)1707868161;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.Visible = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0015EA90 File Offset: 0x0015CC90
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0015EB48 File Offset: 0x0015CD48
		public bool TrkPerCallPageInCallUserAlertEnable_A9434_Editable
		{
			get
			{
				short num = (short)920924950;
				short num2 = num;
				num = (short)501887766;
				switch (num2 == num)
				{
				}
				num = (short)765394944;
				short num3 = num;
				num = (short)1080229888;
				if (num != 0)
				{
				}
				num = (short)2050621441;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.Editable;
			}
			set
			{
				short num = (short)1324196421;
				short num2 = num;
				num = (short)561095237;
				switch (num2 == num)
				{
				}
				num = (short)965345280;
				short num3 = num;
				num = (short)521863169;
				if (num != 0)
				{
				}
				num = (short)1596915712;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.Editable = value;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x0015EBFC File Offset: 0x0015CDFC
		internal string TrkPerCallPageInCallUserAlertEnable_A9434_UILabel
		{
			get
			{
				short num = (short)1021525703;
				short num2 = num;
				num = (short)621952711;
				switch (num2 == num)
				{
				}
				num = (short)620691456;
				short num3 = num;
				num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)503709696;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.UIName;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x0015ECB0 File Offset: 0x0015CEB0
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x0015ED64 File Offset: 0x0015CF64
		internal bool TrkPerCallPageInCallUserAlertEnable_A9434_HiddenStatic
		{
			get
			{
				short num = (short)525027325;
				short num2 = num;
				num = (short)964773885;
				switch (num2 == num)
				{
				}
				num = (short)2014904320;
				short num3 = num;
				num = (short)995426305;
				if (num != 0)
				{
				}
				num = (short)715128832;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.HiddenStatic;
			}
			set
			{
				short num = (short)2029794574;
				short num2 = num;
				num = (short)982201614;
				switch (num2 == num)
				{
				}
				num = (short)448004096;
				short num3 = num;
				num = (short)810614785;
				if (num != 0)
				{
				}
				num = (short)1554317312;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.HiddenStatic = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0015EE1C File Offset: 0x0015D01C
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x0015EED4 File Offset: 0x0015D0D4
		internal bool TrkPerCallPageInCallUserAlertEnable_A9434_HiddenDynamic
		{
			get
			{
				short num = (short)381173489;
				short num2 = num;
				num = (short)142294769;
				switch (num2 == num)
				{
				}
				num = (short)575799296;
				short num3 = num;
				num = (short)1329397761;
				if (num != 0)
				{
				}
				num = (short)1362690048;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434.HiddenDynamic;
			}
			set
			{
				short num = (short)1410572081;
				short num2 = num;
				num = (short)159293233;
				switch (num2 == num)
				{
				}
				num = (short)1918369792;
				short num3 = num;
				num = (short)1633026049;
				if (num != 0)
				{
				}
				num = (short)1218969600;
				if (num != 0)
				{
				}
				this.trkPerCallPageInCallUserAlertEnable_A9434.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x0015EF8C File Offset: 0x0015D18C
		public bool TrkPerCallPageInCallUserAlertEnable_A9434_HasDiffs
		{
			get
			{
				short num = (short)203344452;
				short num2 = num;
				num = (short)1443482180;
				switch (num2 == num)
				{
				}
				num = (short)510197760;
				short num3 = num;
				num = (short)879624193;
				if (num != 0)
				{
				}
				num = (short)264241152;
				if (num != 0)
				{
				}
				return this.trkPerCallPageInCallUserAlertEnable_A9434._HasDiffs;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0015F040 File Offset: 0x0015D240
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0015F0F4 File Offset: 0x0015D2F4
		public bool TrkPerCallPageAutomaticCallAlert_A9754Value
		{
			get
			{
				short num = (short)302435167;
				short num2 = num;
				num = (short)2065550175;
				switch (num2 == num)
				{
				}
				num = (short)533790720;
				short num3 = num;
				num = (short)495058944;
				if (num != 0)
				{
				}
				num = (short)1944059905;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.Value;
			}
			set
			{
				short num = (short)2079186245;
				short num2 = num;
				num = (short)1201331525;
				switch (num2 == num)
				{
				}
				num = (short)778567680;
				short num3 = num;
				num = (short)610992129;
				if (num != 0)
				{
				}
				num = (short)1766653952;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.Value = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0015F1AC File Offset: 0x0015D3AC
		public global::AcpBusinessLayer.AcpField<bool> TrkPerCallPageAutomaticCallAlert_A9754
		{
			get
			{
				short num = (short)1754833378;
				short num2 = num;
				num = (short)1585553890;
				switch (num2 == num)
				{
				}
				num = (short)1843331072;
				short num3 = num;
				num = (short)1121255424;
				if (num != 0)
				{
				}
				num = (short)113573889;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x0015F25C File Offset: 0x0015D45C
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0015F310 File Offset: 0x0015D510
		public bool TrkPerCallPageAutomaticCallAlert_A9754_UIValue
		{
			get
			{
				short num = (short)547829615;
				short num2 = num;
				num = (short)1937454959;
				switch (num2 == num)
				{
				}
				num = (short)1671954432;
				short num3 = num;
				num = (short)1878720513;
				if (num != 0)
				{
				}
				num = (short)1940127744;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.Value;
			}
			set
			{
				short num = (short)1374953557;
				short num2 = num;
				num = (short)1181360213;
				switch (num2 == num)
				{
				}
				num = (short)956694528;
				short num3 = num;
				num = (short)286982145;
				if (num != 0)
				{
				}
				num = (short)8978432;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.Value = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x0015F3C8 File Offset: 0x0015D5C8
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x0015F47C File Offset: 0x0015D67C
		public bool TrkPerCallPageAutomaticCallAlert_A9754_Applicable
		{
			get
			{
				short num = (short)797771203;
				short num2 = num;
				num = (short)1619068355;
				switch (num2 == num)
				{
				}
				num = (short)1953103872;
				short num3 = num;
				num = (short)790298625;
				if (num != 0)
				{
				}
				num = (short)1251803136;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.Applicable;
			}
			set
			{
				short num = (short)1773296894;
				short num2 = num;
				num = (short)1250778366;
				switch (num2 == num)
				{
				}
				num = (short)1907556352;
				short num3 = num;
				num = (short)1576927233;
				if (num != 0)
				{
				}
				num = (short)1707999232;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.Applicable = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x0015F534 File Offset: 0x0015D734
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x0015F5E4 File Offset: 0x0015D7E4
		public bool TrkPerCallPageAutomaticCallAlert_A9754_Valid
		{
			get
			{
				short num = (short)405330244;
				short num2 = num;
				num = (short)1393285444;
				switch (num2 == num)
				{
				}
				num = (short)1707147264;
				short num3 = num;
				num = (short)1631780865;
				if (num != 0)
				{
				}
				num = (short)631898112;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.Valid;
			}
			set
			{
				short num = (short)2142744862;
				short num2 = num;
				num = (short)320450846;
				switch (num2 == num)
				{
				}
				num = (short)806617088;
				short num3 = num;
				num = (short)775684097;
				if (num != 0)
				{
				}
				num = (short)516554752;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.Valid = value;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0015F698 File Offset: 0x0015D898
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x0015F74C File Offset: 0x0015D94C
		public bool TrkPerCallPageAutomaticCallAlert_A9754_Visible
		{
			get
			{
				short num = (short)1742322112;
				short num2 = num;
				num = (short)1334426048;
				switch (num2 == num)
				{
				}
				num = (short)712638464;
				short num3 = num;
				num = (short)1561067520;
				if (num != 0)
				{
				}
				num = (short)477495297;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.Visible;
			}
			set
			{
				short num = (short)1567766293;
				short num2 = num;
				num = (short)1444951829;
				switch (num2 == num)
				{
				}
				num = (short)1001717760;
				short num3 = num;
				num = (short)555941888;
				if (num != 0)
				{
				}
				num = (short)1260060673;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.Visible = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x0015F800 File Offset: 0x0015DA00
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x0015F8B0 File Offset: 0x0015DAB0
		public bool TrkPerCallPageAutomaticCallAlert_A9754_Editable
		{
			get
			{
				short num = (short)1365049345;
				if (num != 0)
				{
				}
				num = (short)141987463;
				short num2 = num;
				num = (short)1513524871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)360644608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1206910976;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.Editable;
			}
			set
			{
				short num = (short)1901797302;
				short num2 = num;
				num = (short)311041974;
				switch (num2 == num)
				{
				}
				num = (short)231211008;
				short num3 = num;
				num = (short)949551104;
				if (num != 0)
				{
				}
				num = (short)1872166913;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.Editable = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x0015F968 File Offset: 0x0015DB68
		internal string TrkPerCallPageAutomaticCallAlert_A9754_UILabel
		{
			get
			{
				short num = (short)318469540;
				short num2 = num;
				num = (short)1553757604;
				switch (num2 == num)
				{
				}
				num = (short)1043595264;
				short num3 = num;
				num = (short)1425276929;
				if (num != 0)
				{
				}
				num = (short)735969280;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.UIName;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0015FA1C File Offset: 0x0015DC1C
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0015FAD0 File Offset: 0x0015DCD0
		internal bool TrkPerCallPageAutomaticCallAlert_A9754_HiddenStatic
		{
			get
			{
				short num = (short)113442817;
				if (num != 0)
				{
				}
				num = (short)892477899;
				short num2 = num;
				num = (short)1815224779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765867520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777781248;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.HiddenStatic;
			}
			set
			{
				short num = (short)768601075;
				short num2 = num;
				num = (short)731835379;
				switch (num2 == num)
				{
				}
				num = (short)1103757312;
				short num3 = num;
				num = (short)1496383488;
				if (num != 0)
				{
				}
				num = (short)350289921;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.HiddenStatic = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0015FB84 File Offset: 0x0015DD84
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0015FC3C File Offset: 0x0015DE3C
		internal bool TrkPerCallPageAutomaticCallAlert_A9754_HiddenDynamic
		{
			get
			{
				short num = (short)968199811;
				short num2 = num;
				num = (short)411799171;
				switch (num2 == num)
				{
				}
				num = (short)2118516736;
				short num3 = num;
				num = (short)1710817281;
				if (num != 0)
				{
				}
				num = (short)1885667328;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754.HiddenDynamic;
			}
			set
			{
				short num = (short)1673141493;
				short num2 = num;
				num = (short)1016929525;
				switch (num2 == num)
				{
				}
				num = (short)980418560;
				short num3 = num;
				num = (short)1848967169;
				if (num != 0)
				{
				}
				num = (short)892862464;
				if (num != 0)
				{
				}
				this.trkPerCallPageAutomaticCallAlert_A9754.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x0015FCF0 File Offset: 0x0015DEF0
		public bool TrkPerCallPageAutomaticCallAlert_A9754_HasDiffs
		{
			get
			{
				short num = (short)1214933454;
				short num2 = num;
				num = (short)981166542;
				switch (num2 == num)
				{
				}
				num = (short)1477771264;
				short num3 = num;
				num = (short)122290176;
				if (num != 0)
				{
				}
				num = (short)980090881;
				if (num != 0)
				{
				}
				return this.trkPerCallPageAutomaticCallAlert_A9754._HasDiffs;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x0015FDA8 File Offset: 0x0015DFA8
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0015FE60 File Offset: 0x0015E060
		public int TrkPerCallPageHotListItemID_A19982Value
		{
			get
			{
				short num = (short)190430398;
				short num2 = num;
				num = (short)1229962430;
				switch (num2 == num)
				{
				}
				num = (short)1690304512;
				short num3 = num;
				num = (short)1290076161;
				if (num != 0)
				{
				}
				num = (short)375193600;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.Value;
			}
			set
			{
				short num = (short)1862724478;
				short num2 = num;
				num = (short)1527507838;
				switch (num2 == num)
				{
				}
				num = (short)735182848;
				short num3 = num;
				num = (short)376438785;
				if (num != 0)
				{
				}
				num = (short)555220992;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.Value = value;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x0015FF18 File Offset: 0x0015E118
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x0015FFCC File Offset: 0x0015E1CC
		public string TrkPerCallPageHotListItemID_A19982_UIValue
		{
			get
			{
				short num = (short)1133330601;
				short num2 = num;
				num = (short)1385054377;
				switch (num2 == num)
				{
				}
				num = (short)1647312896;
				short num3 = num;
				num = (short)31064065;
				if (num != 0)
				{
				}
				num = (short)1022623744;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.UIValue;
			}
			set
			{
				short num = (short)404002862;
				short num2 = num;
				num = (short)614766638;
				switch (num2 == num)
				{
				}
				num = (short)745996288;
				short num3 = num;
				num = (short)1895301121;
				if (num != 0)
				{
				}
				num = (short)1872101376;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.UIValue = value;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00160080 File Offset: 0x0015E280
		public global::AcpBusinessLayer.AcpRecRefField TrkPerCallPageHotListItemID_A19982
		{
			get
			{
				short num = (short)1443232516;
				short num2 = num;
				num = (short)1296169732;
				switch (num2 == num)
				{
				}
				num = (short)908984320;
				short num3 = num;
				num = (short)1210777600;
				if (num != 0)
				{
				}
				num = (short)1771962369;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00160130 File Offset: 0x0015E330
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x001601E4 File Offset: 0x0015E3E4
		public bool TrkPerCallPageHotListItemID_A19982_Applicable
		{
			get
			{
				short num = (short)1130097332;
				short num2 = num;
				num = (short)759622324;
				switch (num2 == num)
				{
				}
				num = (short)1640366080;
				short num3 = num;
				num = (short)942669824;
				if (num != 0)
				{
				}
				num = (short)1895235585;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.Applicable;
			}
			set
			{
				short num = (short)1458176001;
				if (num != 0)
				{
				}
				num = (short)1941822629;
				short num2 = num;
				num = (short)90496165;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504037376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149173760;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.Applicable = value;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00160298 File Offset: 0x0015E498
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0016034C File Offset: 0x0015E54C
		public bool TrkPerCallPageHotListItemID_A19982_Valid
		{
			get
			{
				short num = (short)1119025912;
				short num2 = num;
				num = (short)1755839224;
				switch (num2 == num)
				{
				}
				num = (short)1407320064;
				short num3 = num;
				num = (short)1811873793;
				if (num != 0)
				{
				}
				num = (short)1521680384;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.Valid;
			}
			set
			{
				short num = (short)291788815;
				short num2 = num;
				num = (short)828135439;
				switch (num2 == num)
				{
				}
				num = (short)1812135936;
				short num3 = num;
				num = (short)123011073;
				if (num != 0)
				{
				}
				num = (short)216334336;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.Valid = value;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00160400 File Offset: 0x0015E600
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x001604B4 File Offset: 0x0015E6B4
		public bool TrkPerCallPageHotListItemID_A19982_Visible
		{
			get
			{
				short num = (short)1934414061;
				short num2 = num;
				num = (short)69718253;
				switch (num2 == num)
				{
				}
				num = (short)2132279296;
				short num3 = num;
				num = (short)1191247873;
				if (num != 0)
				{
				}
				num = (short)870055936;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.Visible;
			}
			set
			{
				short num = (short)830668801;
				if (num != 0)
				{
				}
				num = (short)1880758561;
				short num2 = num;
				num = (short)1911363873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562640384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)59375616;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.Visible = value;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00160568 File Offset: 0x0015E768
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00160620 File Offset: 0x0015E820
		public bool TrkPerCallPageHotListItemID_A19982_Editable
		{
			get
			{
				short num = (short)854937209;
				short num2 = num;
				num = (short)1239371385;
				switch (num2 == num)
				{
				}
				num = (short)447217664;
				short num3 = num;
				num = (short)1535246337;
				if (num != 0)
				{
				}
				num = (short)1551826944;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.Editable;
			}
			set
			{
				short num = (short)1755709441;
				if (num != 0)
				{
				}
				num = (short)848451370;
				short num2 = num;
				num = (short)276387626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532611072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496121344;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.Editable = value;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x001606D4 File Offset: 0x0015E8D4
		internal string TrkPerCallPageHotListItemID_A19982_UILabel
		{
			get
			{
				short num = (short)2143650031;
				short num2 = num;
				num = (short)1143505135;
				switch (num2 == num)
				{
				}
				num = (short)1542127616;
				short num3 = num;
				num = (short)1605107713;
				if (num != 0)
				{
				}
				num = (short)1584988160;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.UIName;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x00160788 File Offset: 0x0015E988
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x0016083C File Offset: 0x0015EA3C
		internal bool TrkPerCallPageHotListItemID_A19982_HiddenStatic
		{
			get
			{
				short num = (short)1417978487;
				short num2 = num;
				num = (short)1378067063;
				switch (num2 == num)
				{
				}
				num = (short)1212416000;
				short num3 = num;
				num = (short)2119106561;
				if (num != 0)
				{
				}
				num = (short)882507776;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.HiddenStatic;
			}
			set
			{
				short num = (short)334958499;
				short num2 = num;
				num = (short)1530728355;
				switch (num2 == num)
				{
				}
				num = (short)1625686016;
				short num3 = num;
				num = (short)1500971009;
				if (num != 0)
				{
				}
				num = (short)843055104;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.HiddenStatic = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x001608F0 File Offset: 0x0015EAF0
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x001609A4 File Offset: 0x0015EBA4
		internal bool TrkPerCallPageHotListItemID_A19982_HiddenDynamic
		{
			get
			{
				short num = (short)1558591021;
				short num2 = num;
				num = (short)1455765037;
				switch (num2 == num)
				{
				}
				num = (short)535035904;
				short num3 = num;
				num = (short)1009385472;
				if (num != 0)
				{
				}
				num = (short)1120141313;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982.HiddenDynamic;
			}
			set
			{
				short num = (short)427360257;
				if (num != 0)
				{
				}
				num = (short)1751793729;
				short num2 = num;
				num = (short)443039809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)440467456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754712576;
				if (num != 0)
				{
				}
				this.trkPerCallPageHotListItemID_A19982.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00160A58 File Offset: 0x0015EC58
		public bool TrkPerCallPageHotListItemID_A19982_HasDiffs
		{
			get
			{
				short num = (short)882507777;
				if (num != 0)
				{
				}
				num = (short)1333569788;
				short num2 = num;
				num = (short)1068607740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139357184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)50069504;
				if (num != 0)
				{
				}
				return this.trkPerCallPageHotListItemID_A19982._HasDiffs;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00160B0C File Offset: 0x0015ED0C
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00160BC0 File Offset: 0x0015EDC0
		public int TrkPerFeaturesAstroAlertingToneTableValue
		{
			get
			{
				short num = (short)1401977207;
				short num2 = num;
				num = (short)1032026487;
				switch (num2 == num)
				{
				}
				num = (short)1032192000;
				short num3 = num;
				num = (short)1348796417;
				if (num != 0)
				{
				}
				num = (short)1415970816;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.Value;
			}
			set
			{
				short num = (short)624650215;
				short num2 = num;
				num = (short)2016634855;
				switch (num2 == num)
				{
				}
				num = (short)1486159872;
				short num3 = num;
				num = (short)1383071745;
				if (num != 0)
				{
				}
				num = (short)1454833664;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.Value = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00160C74 File Offset: 0x0015EE74
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00160D28 File Offset: 0x0015EF28
		public string TrkPerFeaturesAstroAlertingToneTable_UIValue
		{
			get
			{
				short num = (short)866947381;
				short num2 = num;
				num = (short)2044170549;
				switch (num2 == num)
				{
				}
				num = (short)1031340032;
				short num3 = num;
				num = (short)1087832064;
				if (num != 0)
				{
				}
				num = (short)95551489;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.UIValue;
			}
			set
			{
				short num = (short)872524817;
				short num2 = num;
				num = (short)1093118993;
				switch (num2 == num)
				{
				}
				num = (short)655032320;
				short num3 = num;
				num = (short)1983905792;
				if (num != 0)
				{
				}
				num = (short)2108293121;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.UIValue = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x00160DE0 File Offset: 0x0015EFE0
		public global::AcpBusinessLayer.AcpRecRefField TrkPerFeaturesAstroAlertingToneTable
		{
			get
			{
				short num = (short)273659849;
				short num2 = num;
				num = (short)2013902793;
				switch (num2 == num)
				{
				}
				num = (short)2121203712;
				short num3 = num;
				num = (short)1188298753;
				if (num != 0)
				{
				}
				num = (short)1463549952;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00160E90 File Offset: 0x0015F090
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x00160F44 File Offset: 0x0015F144
		public bool TrkPerFeaturesAstroAlertingToneTable_Applicable
		{
			get
			{
				short num = (short)93809715;
				short num2 = num;
				num = (short)890268723;
				switch (num2 == num)
				{
				}
				num = (short)135725056;
				short num3 = num;
				num = (short)2000748544;
				if (num != 0)
				{
				}
				num = (short)1044447233;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.Applicable;
			}
			set
			{
				short num = (short)704269067;
				short num2 = num;
				num = (short)871320331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469237760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526647297;
				if (num != 0)
				{
				}
				num = (short)877461504;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.Applicable = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x00160FF8 File Offset: 0x0015F1F8
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x001610AC File Offset: 0x0015F2AC
		public bool TrkPerFeaturesAstroAlertingToneTable_Valid
		{
			get
			{
				short num = (short)1957350720;
				short num2 = num;
				num = (short)301387072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1693384704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)931856385;
				if (num != 0)
				{
				}
				num = (short)1147338752;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.Valid;
			}
			set
			{
				short num = (short)2045313025;
				if (num != 0)
				{
				}
				num = (short)1854013440;
				short num2 = num;
				num = (short)341876673;
				short num3 = num;
				num = (short)1014341569;
				switch (num3 == num)
				{
				}
				num = (short)1581580288;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.Valid = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00161160 File Offset: 0x0015F360
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x00161218 File Offset: 0x0015F418
		public bool TrkPerFeaturesAstroAlertingToneTable_Visible
		{
			get
			{
				short num = (short)1258798449;
				short num2 = num;
				num = (short)659471729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611923456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850788353;
				if (num != 0)
				{
				}
				num = (short)1667104768;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.Visible;
			}
			set
			{
				short num = (short)558596218;
				short num2 = num;
				num = (short)1789493370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555810816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2046164993;
				if (num != 0)
				{
				}
				num = (short)1024393216;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.Visible = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x001612CC File Offset: 0x0015F4CC
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x00161384 File Offset: 0x0015F584
		public bool TrkPerFeaturesAstroAlertingToneTable_Editable
		{
			get
			{
				short num = (short)937382611;
				short num2 = num;
				num = (short)548360915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786563072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1346437121;
				if (num != 0)
				{
				}
				num = (short)1804402688;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.Editable;
			}
			set
			{
				short num = (short)1872083321;
				short num2 = num;
				num = (short)1096071545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1983512576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127205376;
				if (num != 0)
				{
				}
				num = (short)243007489;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.Editable = value;
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00161438 File Offset: 0x0015F638
		internal string TrkPerFeaturesAstroAlertingToneTable_UILabel
		{
			get
			{
				short num = (short)1372985368;
				short num2 = num;
				num = (short)1938888728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915158528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348127232;
				if (num != 0)
				{
				}
				num = (short)1478361089;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.UIName;
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x001614E8 File Offset: 0x0015F6E8
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0016159C File Offset: 0x0015F79C
		internal bool TrkPerFeaturesAstroAlertingToneTable_HiddenStatic
		{
			get
			{
				short num = (short)2116408611;
				short num2 = num;
				num = (short)741201187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845035008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758251520;
				if (num != 0)
				{
				}
				num = (short)1216741377;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.HiddenStatic;
			}
			set
			{
				short num = (short)2086199923;
				short num2 = num;
				num = (short)1347150451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881131520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1678770177;
				if (num != 0)
				{
				}
				num = (short)2136604672;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.HiddenStatic = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00161650 File Offset: 0x0015F850
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x00161704 File Offset: 0x0015F904
		internal bool TrkPerFeaturesAstroAlertingToneTable_HiddenDynamic
		{
			get
			{
				short num = (short)499974145;
				if (num != 0)
				{
				}
				num = (short)1572405248;
				short num2 = num;
				num = (short)1918623429;
				short num3 = num;
				num = (short)1216405189;
				switch (num3 == num)
				{
				}
				num = (short)188350464;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable.HiddenDynamic;
			}
			set
			{
				short num = (short)33000118;
				short num2 = num;
				num = (short)1307151030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067791872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744488961;
				if (num != 0)
				{
				}
				num = (short)2060779520;
				if (num != 0)
				{
				}
				this.trkPerFeaturesAstroAlertingToneTable.HiddenDynamic = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x001617B8 File Offset: 0x0015F9B8
		public bool TrkPerFeaturesAstroAlertingToneTable_HasDiffs
		{
			get
			{
				short num = (short)672089366;
				short num2 = num;
				num = (short)127026454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)180158464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016791040;
				if (num != 0)
				{
				}
				num = (short)1520959489;
				if (num != 0)
				{
				}
				return this.trkPerFeaturesAstroAlertingToneTable._HasDiffs;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00161870 File Offset: 0x0015FA70
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1506518749;
				short num2 = num;
				num = (short)1265411805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794899968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2032795649;
				if (num != 0)
				{
				}
				num = (short)309526528;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0016192C File Offset: 0x0015FB2C
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
					num2 = (short)308281345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1584660481;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)656952506;
					short num3 = num2;
					num2 = (short)1200442554;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_165;
					default:
						num2 = (short)819658752;
						if (num2 != 0)
						{
						}
						num2 = (short)946929667;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)963903488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_165;
				case 4:
					return result;
				}
				goto IL_24;
				IL_165:
				num2 = (short)930021376;
				short num4 = num2;
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1386545156;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1605959682;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400086B RID: 2155
		private global::AcpBusinessLayer.AcpListField trkPerCallPageCallAlertPageOperation_A7597;

		// Token: 0x0400086C RID: 2156
		private global::AcpBusinessLayer.AcpListField trkPerCallPagePrivateCallOperation_A8759;

		// Token: 0x0400086D RID: 2157
		private global::AcpBusinessLayer.AcpListField trkPerCallPagePrivateCallType_A8760;

		// Token: 0x0400086E RID: 2158
		private global::AcpBusinessLayer.AcpField<bool> trkPerCallPageInCallUserAlertEnable_A9434;

		// Token: 0x0400086F RID: 2159
		private global::AcpBusinessLayer.AcpField<bool> trkPerCallPageAutomaticCallAlert_A9754;

		// Token: 0x04000870 RID: 2160
		private global::AcpBusinessLayer.AcpRecRefField trkPerCallPageHotListItemID_A19982;

		// Token: 0x04000871 RID: 2161
		private global::AcpBusinessLayer.AcpRecRefField trkPerFeaturesAstroAlertingToneTable;
	}
}
