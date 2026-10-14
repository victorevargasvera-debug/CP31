using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RepeaterIDList;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005CA RID: 1482
	[global::System.Serializable]
	public class RAC : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C944 RID: 51524 RVA: 0x00BBFC60 File Offset: 0x00BBDE60
		public RAC(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x00BBFC7C File Offset: 0x00BBDE7C
		protected RAC(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x00BBFC94 File Offset: 0x00BBDE94
		public override void Init()
		{
			int a_ = 4;
			short num = (short)295370753;
			if (num != 0)
			{
			}
			num = (short)1490021686;
			short num2 = num;
			num = (short)957476150;
			switch (num2 == num)
			{
			default:
			{
				num = (short)974716928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)507707392;
			if (num != 0)
			{
			}
			this.cnvPerRACAccessType_A7388 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔雖뫘룚룜곞鋠럢鳤韦賨듪곬\ud8ee싰쯲췴", a_), global::CommonResources.AcgResources.ID_ACCESSTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRACAccessType_A7388LovStrs);
			this.cnvPerRACAccessType_A7388.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACAccessType_A7388.DataTransferOrder = 18;
			this.cnvPerRACCodeType1_A7680 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerRACCodeType1_A7680LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerRACCodeType1_A7680LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔铖뛘뿚룜诞飠鏢胤훦뛨ꫪ\udaec\ud9ee짰쏲", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON1PTTCODETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRACCodeType1_A7680LovStrs);
			this.cnvPerRACCodeType1_A7680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACCodeType1_A7680.DataTransferOrder = 11;
			this.cnvPerRACMDCRepeaterID1_A8783 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔髖鷘飚远뫞釠蛢蓤鏦賨駪ꓬ꯮샰곲듴쿶컸쏺컼", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON1PTTMDCREPEATERID, null, null, false, false);
			this.cnvPerRACMDCRepeaterID1_A8783.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACMDCRepeaterID1_A8783.DataTransferOrder = 104;
			this.cnvPerRACMDCRepeaterID2_A8814 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔髖鷘飚远뫞釠蛢蓤鏦賨駪ꓬ꯮쏰곲듴쿶쇸쫺짼", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON2MDCREPEATERID, null, null, false, false);
			this.cnvPerRACMDCRepeaterID2_A8814.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACMDCRepeaterID2_A8814.DataTransferOrder = 117;
			this.cnvPerRACCodeType2_A8817 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔铖뛘뿚룜诞飠鏢胤헦뛨ꫪ헬ퟮ샰쓲", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON2CODETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRACCodeType2_A8817LovStrs);
			this.cnvPerRACCodeType2_A8817.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACCodeType2_A8817.DataTransferOrder = 19;
			this.cnvPerRACRepeaterAccess_A8939 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔藖볘ꯚ룜뻞闠蛢韤ꛦ諨裪裬鳮苰곲듴쿶샸죺쓼", a_), global::CommonResources.AcgResources.ID_REPEATERACCESS);
			this.cnvPerRACRepeaterAccess_A8939.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACRepeaterAccess_A8939.DataTransferOrder = 8;
			this.cnvPerRACToneSignalingSystem_A9392 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔菖뛘뗚룜賞裠蓢诤蛦藨苪菬裮ꋰ諲蛴菶鳸雺ꋼ뻾㠀。㰄㔆", a_), global::CommonResources.AcgResources.ID_SINGLETONELISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_TONESIGNALINGDISABLED
			}, new int[1], true, false);
			this.cnvPerRACToneSignalingSystem_A9392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACToneSignalingSystem_A9392.DataTransferOrder = 96;
			this.cnvPerRACSingletone_A43073 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔蓖냘뗚뫜돞蓠韢諤触賨듪곬\udbee싰쏲싴쓶", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON2SINGLETONEALIASSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[]
			{
				65535
			}, false, false);
			this.cnvPerRACSingletone_A43073.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACSingletone_A43073.DataTransferOrder = 115;
			this.cnvPerRACSingletone_A43072 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛄꧆뿈鯊꣌뷎菐鋒雔蓖냘뗚뫜돞蓠韢諤触賨듪곬\udbee싰쏲싴엶", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON1PTTSINGLETONEALIASSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[]
			{
				65535
			}, false, false);
			this.cnvPerRACSingletone_A43072.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerRACSingletone_A43072.DataTransferOrder = 110;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韄蛆諈", a_);
			base.Id = 10138;
			base.UIName = global::CommonResources.AcgResources.ID_RAC;
			base.DataTransferOrder = 9;
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x00BBFFEC File Offset: 0x00BBE1EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)934346781;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvPerRACMDCRepeaterID2_A8814 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗韙飛鷝닟蟡铣菥觧黩觫鳭맯뛱웳꧵맷싹쓻쿽㓿", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON2MDCREPEATERID, null, null, false, false);
					this.cnvPerRACMDCRepeaterID2_A8814.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACMDCRepeaterID2_A8814.DataTransferOrder = 117;
					num = (short)577830914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_722;
				case 2:
					goto IL_364;
				case 3:
					goto IL_CF;
				case 4:
				{
					num = (short)688062464;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗駙돛뫝藟뛡鷣雥跧\udbe9돫꿭쟯쓱쳳웵", a_)))
					{
						num = (short)751435788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5DA;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗觙뗛냝蟟軡臣鋥蟧蓩觫뇭뇯웱쟳웵쿷죹", a_)))
					{
						num = (short)1453916185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7CE;
				case 6:
					goto IL_670;
				case 7:
					this.cnvPerRACMDCRepeaterID1_A8783 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗韙飛鷝닟蟡铣菥觧黩觫鳭맯뛱엳꧵맷싹쯻웽㏿", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON1PTTMDCREPEATERID, null, null, false, false);
					this.cnvPerRACMDCRepeaterID1_A8783.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACMDCRepeaterID1_A8783.DataTransferOrder = 104;
					num = (short)59965446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1362034706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.cnvPerRACToneSignalingSystem_A9392 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗軙돛냝藟뇡跣臥蛧诩胫蟭黯闱ꟳ迵请軹駻鏽忿䌁㴃㔅ㄇ㠉", a_), global::CommonResources.AcgResources.ID_SINGLETONELISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_TONESIGNALINGDISABLED
					}, new int[1], true, false);
					this.cnvPerRACToneSignalingSystem_A9392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACToneSignalingSystem_A9392.DataTransferOrder = 96;
					num = (short)1590493185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗韙飛鷝닟蟡铣菥觧黩觫鳭맯뛱웳꧵맷싹쓻쿽㓿", a_)))
					{
						num = (short)1528561664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_364;
				case 11:
					num = (short)1193738241;
					if (num != 0)
					{
					}
					this.cnvPerRACAccessType_A7388 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗鯙뿛뷝藟釡韣닥釧髩觫뇭뇯엱쟳컵샷", a_), global::CommonResources.AcgResources.ID_ACCESSTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRACAccessType_A7388LovStrs);
					this.cnvPerRACAccessType_A7388.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACAccessType_A7388.DataTransferOrder = 18;
					num = (short)2134507550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					this.cnvPerRACCodeType1_A7680 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerRACCodeType1_A7680LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerRACCodeType1_A7680LovStrs), this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗駙돛뫝藟뛡鷣雥跧\udbe9돫꿭쟯쓱쳳웵", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON1PTTCODETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRACCodeType1_A7680LovStrs);
					this.cnvPerRACCodeType1_A7680.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACCodeType1_A7680.DataTransferOrder = 11;
					num = (short)382736226;
					short num4 = num;
					num = (short)1685460834;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_722;
					default:
						num = (short)847577088;
						if (num != 0)
						{
						}
						num = (short)674365453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_5DA;
				case 14:
					goto IL_544;
				case 15:
					goto IL_316;
				case 16:
					this.cnvPerRACSingletone_A43073 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗觙뗛냝蟟軡臣鋥蟧蓩觫뇭뇯웱쟳웵쿷짹", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON2SINGLETONEALIASSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[]
					{
						65535
					}, false, false);
					this.cnvPerRACSingletone_A43073.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACSingletone_A43073.DataTransferOrder = 115;
					num = (short)882442255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.cnvPerRACRepeaterAccess_A8939 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗裙맛껝藟菡郣菥髧ꯩ迫跭闯臱蟳꧵맷싹엻췽㧿", a_), global::CommonResources.AcgResources.ID_REPEATERACCESS);
					this.cnvPerRACRepeaterAccess_A8939.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACRepeaterAccess_A8939.DataTransferOrder = 8;
					num = (short)1497104387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗鯙뿛뷝藟釡韣닥釧髩觫뇭뇯엱쟳컵샷", a_)))
					{
						num = (short)1786183691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_178;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗軙돛냝藟뇡跣臥蛧诩胫蟭黯闱ꟳ迵请軹駻鏽忿䌁㴃㔅ㄇ㠉", a_)))
					{
						num = (short)337313801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗駙돛뫝藟뛡鷣雥跧\ud8e9돫꿭죯쫱엳쇵", a_)))
					{
						num = (short)1661730837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_727;
				case 21:
					this.cnvPerRACCodeType2_A8817 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗駙돛뫝藟뛡鷣雥跧\ud8e9돫꿭죯쫱엳쇵", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON2CODETYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerRACCodeType2_A8817LovStrs);
					this.cnvPerRACCodeType2_A8817.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACCodeType2_A8817.DataTransferOrder = 19;
					num = (short)321126426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1015545884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗裙맛껝藟菡郣菥髧ꯩ迫跭闯臱蟳꧵맷싹엻췽㧿", a_)))
					{
						num = (short)1597177873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗觙뗛냝蟟軡臣鋥蟧蓩觫뇭뇯웱쟳웵쿷짹", a_)))
					{
						num = (short)1930428432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_316;
				case 25:
					this.cnvPerRACSingletone_A43072 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗觙뗛냝蟟軡臣鋥蟧蓩觫뇭뇯웱쟳웵쿷죹", a_), global::CommonResources.AcgResources.ID_REPEATERACCESSBUTTON1PTTSINGLETONEALIASSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[]
					{
						65535
					}, false, false);
					this.cnvPerRACSingletone_A43072.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerRACSingletone_A43072.DataTransferOrder = 110;
					num = (short)1579417614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_727;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诇꓉뫋黍뗏ꃑ蛓韕鯗韙飛鷝닟蟡铣菥觧黩觫鳭맯뛱엳꧵맷싹쯻웽㏿", a_)))
					{
						num = (short)259522567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_670;
				case 28:
					if (producerFields != null)
					{
						num = (short)2017198088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7CE;
				case 29:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 30:
					goto IL_178;
				}
				IL_A9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)722010134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_CF:
				num = (short)282787859;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_178:
				num = (short)1061158916;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EF:
				num = (short)1605500952;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_722:
				goto IL_1EF;
				IL_316:
				num = (short)532283397;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_364:
				num = (short)399376404;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5DA:
				num = (short)1051131931;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_670:
				num = (short)1992818698;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_727:
				num = (short)1320550423;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_544:
			IL_7CE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髇诉迋", a_);
			base.Id = 10138;
			base.UIName = global::CommonResources.AcgResources.ID_RAC;
			base.DataTransferOrder = 9;
		}

		// Token: 0x0600C948 RID: 51528 RVA: 0x00BC07FC File Offset: 0x00BBE9FC
		public override void PopulateReferences()
		{
			short num = (short)10929161;
			short num2 = num;
			num = (short)409584649;
			switch (num2 == num)
			{
			}
			num = (short)1419182081;
			if (num != 0)
			{
			}
			num = (short)176291840;
			short num3 = num;
			num = (short)82640896;
			if (num != 0)
			{
			}
			this.cnvPerRACMDCRepeaterID1_A8783.SetRecset(this.a(2034)[0][10077].EmbeddedRecset);
			this.cnvPerRACMDCRepeaterID2_A8814.SetRecset(this.a(2034)[0][10077].EmbeddedRecset);
			this.cnvPerRACToneSignalingSystem_A9392.SetRecset(this.a(4156));
			this.cnvPerRACToneSignalingSystem_A9392.AddSlaveField(this.cnvPerRACSingletone_A43072, 10787);
			this.cnvPerRACToneSignalingSystem_A9392.AddSlaveField(this.cnvPerRACSingletone_A43073, 10787);
		}

		// Token: 0x0600C949 RID: 51529 RVA: 0x00BC093C File Offset: 0x00BBEB3C
		public override void DropReferences()
		{
			short num = (short)491135655;
			short num2 = num;
			num = (short)1517494951;
			switch (num2 == num)
			{
			}
			num = (short)1965031425;
			if (num != 0)
			{
			}
			num = (short)1850671104;
			short num3 = num;
			num = (short)1873870848;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x00BC09EC File Offset: 0x00BBEBEC
		public override void SetConstraints()
		{
			short num = (short)1282661441;
			short num2 = num;
			num = (short)424926273;
			switch (num2 == num)
			{
			}
			num = (short)904790017;
			if (num != 0)
			{
			}
			num = (short)1989214208;
			short num3 = num;
			num = (short)798097408;
			if (num != 0)
			{
			}
			this.cnvPerRACAccessType_A7388.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRptrAccIsEnabledAndCnvRxOnlyIsDisabledAndCnvPerAstroVoiceTxModIsNonASTRO);
			this.cnvPerRACAccessType_A7388.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACCodeType1_A7680.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRptrAccIsEnabledAndCnvRxOnlyIsDisabledAndCnvPerAstroVoiceTxModIsNonASTRO);
			this.cnvPerRACCodeType1_A7680.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRabBtnIsNoneOrSingletoneOrDtmfOrMdcAndCnvPerIsMDC);
			this.cnvPerRACCodeType1_A7680.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACMDCRepeaterID1_A8783.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerNotRxOnlyAndTXNonAstroAndRptrAccEnabledAndRAB1CodeMDC);
			this.cnvPerRACMDCRepeaterID1_A8783.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACMDCRepeaterID2_A8814.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerNotRxOnlyAndTXNonAstroAndRptrAccEnabledAndTypeManualAndRAB2CodeMDC);
			this.cnvPerRACMDCRepeaterID2_A8814.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACCodeType2_A8817.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerNotRxOnlyAndTxIsNonAstroAndRepeaterAccessIsEnabledAndTypeManual);
			this.cnvPerRACCodeType2_A8817.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRab2BtnIsNoneOrSingletoneOrDtmfOrMdcAndCnvPerIsMDC);
			this.cnvPerRACCodeType2_A8817.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACRepeaterAccess_A8939.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerRptrAccInvalidWhenEnabledAndCnvRxOnlyEnabledOrTxVoiceSignalTypeIsAstro);
			this.cnvPerRACRepeaterAccess_A8939.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACToneSignalingSystem_A9392.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSingletoneListSelectionApplicable);
			this.cnvPerRACToneSignalingSystem_A9392.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSingletoneListSelection1Valid);
			this.cnvPerRACToneSignalingSystem_A9392.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACSingletone_A43073.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerNotRxOnlyAndTXNonAstroAndRptrAccEnabledAndTypeManualAndRAB2CodeSingletone);
			this.cnvPerRACSingletone_A43073.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSingletoneAliasSelection2Valid);
			this.cnvPerRACSingletone_A43073.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
			this.cnvPerRACSingletone_A43072.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerNotRxOnlyAndTXNonAstroAndRptrAccEnabledAndRAB1CodeSingletone);
			this.cnvPerRACSingletone_A43072.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSingletoneAliasSelection1Valid);
			this.cnvPerRACSingletone_A43072.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsNotDVRS);
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x00BC0CA8 File Offset: 0x00BBEEA8
		public override void SetupDependencies()
		{
			short num = (short)693563392;
			short num2 = num;
			num = (short)1983836160;
			switch (num2 == num)
			{
			}
			num = (short)2135293952;
			if (num != 0)
			{
			}
			num = (short)1802633216;
			short num3 = num;
			num = (short)1089011713;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACAccessType_A7388);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACAccessType_A7388);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACAccessType_A7388);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACAccessType_A7388);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACAccessType_A7388);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACCodeType1_A7680);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACCodeType1_A7680);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACCodeType1_A7680);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACCodeType1_A7680);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACCodeType1_A7680);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerRACCodeType1_A7680);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			this.cnvPerRACCodeType1_A7680.AddDependentObject(this.cnvPerRACMDCRepeaterID1_A8783);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			this.cnvPerRACCodeType2_A8817.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			this.cnvPerRACAccessType_A7388.AddDependentObject(this.cnvPerRACMDCRepeaterID2_A8814);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			this.cnvPerRACAccessType_A7388.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerRACCodeType2_A8817);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACRepeaterAccess_A8939);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACRepeaterAccess_A8939);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACRepeaterAccess_A8939);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACRepeaterAccess_A8939);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACToneSignalingSystem_A9392);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACToneSignalingSystem_A9392);
			this.cnvPerRACSingletone_A43072.AddDependentObject(this.cnvPerRACToneSignalingSystem_A9392);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACToneSignalingSystem_A9392);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACToneSignalingSystem_A9392);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACToneSignalingSystem_A9392);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACSingletone_A43073);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACSingletone_A43073);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACSingletone_A43073);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACSingletone_A43073);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACSingletone_A43073);
			this.cnvPerRACCodeType2_A8817.AddDependentObject(this.cnvPerRACSingletone_A43073);
			this.cnvPerRACAccessType_A7388.AddDependentObject(this.cnvPerRACSingletone_A43073);
			this.cnvPerRACSingletone_A43072.AddDependentObject(this.cnvPerRACSingletone_A43073);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerRACSingletone_A43072);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerRACSingletone_A43072);
			this.cnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerRACSingletone_A43072);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerRACSingletone_A43072);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerRACSingletone_A43072);
			this.cnvPerRACCodeType1_A7680.AddDependentObject(this.cnvPerRACSingletone_A43072);
		}

		// Token: 0x170064F8 RID: 25848
		// (get) Token: 0x0600C94C RID: 51532 RVA: 0x00BC1224 File Offset: 0x00BBF424
		public global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner MDCRepeaterIDTableInnerSectionForCnvPerRACMDCRepeaterID1_A8783
		{
			get
			{
				short num = (short)1649039366;
				short num2 = num;
				num = (short)1314215942;
				switch (num2 == num)
				{
				}
				num = (short)1950089217;
				if (num != 0)
				{
				}
				num = (short)1900150784;
				short num3 = num;
				num = (short)734855168;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner;
			}
		}

		// Token: 0x170064F9 RID: 25849
		// (get) Token: 0x0600C94D RID: 51533 RVA: 0x00BC12DC File Offset: 0x00BBF4DC
		public global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner MDCRepeaterIDTableInnerSectionForCnvPerRACMDCRepeaterID2_A8814
		{
			get
			{
				short num = (short)527791033;
				short num2 = num;
				num = (short)739275705;
				switch (num2 == num)
				{
				}
				num = (short)607715329;
				if (num != 0)
				{
				}
				num = (short)1934753792;
				short num3 = num;
				num = (short)1320026112;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner;
			}
		}

		// Token: 0x170064FA RID: 25850
		// (get) Token: 0x0600C94E RID: 51534 RVA: 0x00BC1394 File Offset: 0x00BBF594
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList ToneSignalingListForCnvPerRACToneSignalingSystem_A9392
		{
			get
			{
				short num = (short)1204788271;
				short num2 = num;
				num = (short)848862255;
				switch (num2 == num)
				{
				}
				num = (short)364445697;
				if (num != 0)
				{
				}
				num = (short)1412497408;
				short num3 = num;
				num = (short)916193280;
				if (num != 0)
				{
				}
				return this.cnvPerRACToneSignalingSystem_A9392.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
			}
		}

		// Token: 0x170064FB RID: 25851
		// (get) Token: 0x0600C94F RID: 51535 RVA: 0x00BC144C File Offset: 0x00BBF64C
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner AstroAlertingToneTableInnerSectionForCnvPerRACSingletone_A43073
		{
			get
			{
				short num = (short)982790982;
				short num2 = num;
				num = (short)1570648902;
				switch (num2 == num)
				{
				}
				num = (short)872284161;
				if (num != 0)
				{
				}
				num = (short)1514078208;
				short num3 = num;
				num = (short)241827840;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43073.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner;
			}
		}

		// Token: 0x170064FC RID: 25852
		// (get) Token: 0x0600C950 RID: 51536 RVA: 0x00BC1504 File Offset: 0x00BBF704
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner AstroAlertingToneTableInnerSectionForCnvPerRACSingletone_A43072
		{
			get
			{
				short num = (short)1773971782;
				short num2 = num;
				num = (short)2002102598;
				switch (num2 == num)
				{
				}
				num = (short)559087616;
				if (num != 0)
				{
				}
				num = (short)1575485440;
				short num3 = num;
				num = (short)360775681;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner;
			}
		}

		// Token: 0x170064FD RID: 25853
		// (get) Token: 0x0600C951 RID: 51537 RVA: 0x00BC15BC File Offset: 0x00BBF7BC
		public bool HasDiffs
		{
			get
			{
				short num = (short)783275604;
				short num2 = num;
				num = (short)652465748;
				switch (num2 == num)
				{
				}
				num = (short)506789889;
				if (num != 0)
				{
				}
				num = (short)2079784960;
				short num3 = num;
				num = (short)1877999616;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170064FE RID: 25854
		// (get) Token: 0x0600C952 RID: 51538 RVA: 0x00BC166C File Offset: 0x00BBF86C
		// (set) Token: 0x0600C953 RID: 51539 RVA: 0x00BC1724 File Offset: 0x00BBF924
		public int CnvPerRACAccessType_A7388Value
		{
			get
			{
				short num = (short)1926389495;
				short num2 = num;
				num = (short)1470783223;
				switch (num2 == num)
				{
				}
				num = (short)368050176;
				if (num != 0)
				{
				}
				num = (short)1583677440;
				short num3 = num;
				num = (short)1294925825;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.Value;
			}
			set
			{
				short num = (short)497289713;
				short num2 = num;
				num = (short)1801325041;
				switch (num2 == num)
				{
				}
				num = (short)361824257;
				if (num != 0)
				{
				}
				num = (short)197525504;
				short num3 = num;
				num = (short)479789056;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.Value = value;
			}
		}

		// Token: 0x170064FF RID: 25855
		// (get) Token: 0x0600C954 RID: 51540 RVA: 0x00BC17DC File Offset: 0x00BBF9DC
		// (set) Token: 0x0600C955 RID: 51541 RVA: 0x00BC1890 File Offset: 0x00BBFA90
		public string CnvPerRACAccessType_A7388_UIValue
		{
			get
			{
				short num = (short)390858119;
				short num2 = num;
				num = (short)1141048711;
				switch (num2 == num)
				{
				}
				num = (short)1527382017;
				if (num != 0)
				{
				}
				num = (short)1725300736;
				short num3 = num;
				num = (short)1102053376;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.UIValue;
			}
			set
			{
				short num = (short)318258012;
				short num2 = num;
				num = (short)179845980;
				switch (num2 == num)
				{
				}
				num = (short)860094465;
				if (num != 0)
				{
				}
				num = (short)1078788096;
				short num3 = num;
				num = (short)1848115200;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.UIValue = value;
			}
		}

		// Token: 0x17006500 RID: 25856
		// (get) Token: 0x0600C956 RID: 51542 RVA: 0x00BC1944 File Offset: 0x00BBFB44
		public global::AcpBusinessLayer.AcpListField CnvPerRACAccessType_A7388
		{
			get
			{
				short num = (short)434725665;
				short num2 = num;
				num = (short)951280417;
				switch (num2 == num)
				{
				}
				num = (short)458424321;
				if (num != 0)
				{
				}
				num = (short)1542258688;
				short num3 = num;
				num = (short)1937506304;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388;
			}
		}

		// Token: 0x17006501 RID: 25857
		// (get) Token: 0x0600C957 RID: 51543 RVA: 0x00BC19F4 File Offset: 0x00BBFBF4
		// (set) Token: 0x0600C958 RID: 51544 RVA: 0x00BC1AA8 File Offset: 0x00BBFCA8
		public bool CnvPerRACAccessType_A7388_Applicable
		{
			get
			{
				short num = (short)1823036567;
				short num2 = num;
				num = (short)142824599;
				switch (num2 == num)
				{
				}
				num = (short)266207233;
				if (num != 0)
				{
				}
				num = (short)703987712;
				short num3 = num;
				num = (short)1439760384;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.Applicable;
			}
			set
			{
				short num = (short)1759913281;
				short num2 = num;
				num = (short)238232897;
				switch (num2 == num)
				{
				}
				num = (short)1393360896;
				if (num != 0)
				{
				}
				num = (short)1953562624;
				short num3 = num;
				num = (short)1378091009;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.Applicable = value;
			}
		}

		// Token: 0x17006502 RID: 25858
		// (get) Token: 0x0600C959 RID: 51545 RVA: 0x00BC1B60 File Offset: 0x00BBFD60
		// (set) Token: 0x0600C95A RID: 51546 RVA: 0x00BC1C14 File Offset: 0x00BBFE14
		public bool CnvPerRACAccessType_A7388_Valid
		{
			get
			{
				short num = (short)761330212;
				short num2 = num;
				num = (short)717552164;
				switch (num2 == num)
				{
				}
				num = (short)1794572288;
				if (num != 0)
				{
				}
				num = (short)1222967296;
				short num3 = num;
				num = (short)586481665;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.Valid;
			}
			set
			{
				short num = (short)1664887167;
				short num2 = num;
				num = (short)1866541439;
				switch (num2 == num)
				{
				}
				num = (short)1367605249;
				if (num != 0)
				{
				}
				num = (short)669515776;
				short num3 = num;
				num = (short)1123418112;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.Valid = value;
			}
		}

		// Token: 0x17006503 RID: 25859
		// (get) Token: 0x0600C95B RID: 51547 RVA: 0x00BC1CCC File Offset: 0x00BBFECC
		// (set) Token: 0x0600C95C RID: 51548 RVA: 0x00BC1D80 File Offset: 0x00BBFF80
		public bool CnvPerRACAccessType_A7388_Visible
		{
			get
			{
				short num = (short)1391263745;
				if (num != 0)
				{
				}
				num = (short)2095532300;
				short num2 = num;
				num = (short)474564876;
				switch (num2 == num)
				{
				}
				num = (short)1025376256;
				short num3 = num;
				num = (short)5373952;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.Visible;
			}
			set
			{
				short num = (short)1259971257;
				short num2 = num;
				num = (short)1617273529;
				switch (num2 == num)
				{
				}
				num = (short)1101660161;
				if (num != 0)
				{
				}
				num = (short)643694592;
				short num3 = num;
				num = (short)988479488;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.Visible = value;
			}
		}

		// Token: 0x17006504 RID: 25860
		// (get) Token: 0x0600C95D RID: 51549 RVA: 0x00BC1E34 File Offset: 0x00BC0034
		// (set) Token: 0x0600C95E RID: 51550 RVA: 0x00BC1EE8 File Offset: 0x00BC00E8
		public bool CnvPerRACAccessType_A7388_Editable
		{
			get
			{
				short num = (short)2006307682;
				short num2 = num;
				num = (short)633066338;
				switch (num2 == num)
				{
				}
				num = (short)1931804673;
				if (num != 0)
				{
				}
				num = (short)1555628032;
				short num3 = num;
				num = (short)2015494144;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.Editable;
			}
			set
			{
				short num = (short)1605352589;
				short num2 = num;
				num = (short)2015673485;
				switch (num2 == num)
				{
				}
				num = (short)1199767552;
				if (num != 0)
				{
				}
				num = (short)1046413312;
				short num3 = num;
				num = (short)662306817;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.Editable = value;
			}
		}

		// Token: 0x17006505 RID: 25861
		// (get) Token: 0x0600C95F RID: 51551 RVA: 0x00BC1F9C File Offset: 0x00BC019C
		internal string CnvPerRACAccessType_A7388_UILabel
		{
			get
			{
				short num = (short)716111873;
				if (num != 0)
				{
				}
				num = (short)2075651768;
				short num2 = num;
				num = (short)1155526328;
				switch (num2 == num)
				{
				}
				num = (short)1976041472;
				short num3 = num;
				num = (short)1309540352;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.UIName;
			}
		}

		// Token: 0x17006506 RID: 25862
		// (get) Token: 0x0600C960 RID: 51552 RVA: 0x00BC2050 File Offset: 0x00BC0250
		// (set) Token: 0x0600C961 RID: 51553 RVA: 0x00BC2104 File Offset: 0x00BC0304
		internal bool CnvPerRACAccessType_A7388_HiddenStatic
		{
			get
			{
				short num = (short)1467800982;
				short num2 = num;
				num = (short)1245961622;
				switch (num2 == num)
				{
				}
				num = (short)1376518145;
				if (num != 0)
				{
				}
				num = (short)1726611456;
				short num3 = num;
				num = (short)1199636480;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.HiddenStatic;
			}
			set
			{
				short num = (short)1918259418;
				short num2 = num;
				num = (short)404181210;
				switch (num2 == num)
				{
				}
				num = (short)1214382081;
				if (num != 0)
				{
				}
				num = (short)1124794368;
				short num3 = num;
				num = (short)1550581760;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.HiddenStatic = value;
			}
		}

		// Token: 0x17006507 RID: 25863
		// (get) Token: 0x0600C962 RID: 51554 RVA: 0x00BC21BC File Offset: 0x00BC03BC
		// (set) Token: 0x0600C963 RID: 51555 RVA: 0x00BC2274 File Offset: 0x00BC0474
		internal bool CnvPerRACAccessType_A7388_HiddenDynamic
		{
			get
			{
				short num = (short)535835355;
				short num2 = num;
				num = (short)1164456667;
				switch (num2 == num)
				{
				}
				num = (short)855506944;
				if (num != 0)
				{
				}
				num = (short)1794506752;
				short num3 = num;
				num = (short)1564999681;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388.HiddenDynamic;
			}
			set
			{
				short num = (short)806141957;
				short num2 = num;
				num = (short)948420613;
				switch (num2 == num)
				{
				}
				num = (short)170524673;
				if (num != 0)
				{
				}
				num = (short)926351360;
				short num3 = num;
				num = (short)414121984;
				if (num != 0)
				{
				}
				this.cnvPerRACAccessType_A7388.HiddenDynamic = value;
			}
		}

		// Token: 0x17006508 RID: 25864
		// (get) Token: 0x0600C964 RID: 51556 RVA: 0x00BC232C File Offset: 0x00BC052C
		public bool CnvPerRACAccessType_A7388_HasDiffs
		{
			get
			{
				short num = (short)275066089;
				short num2 = num;
				num = (short)1661086953;
				switch (num2 == num)
				{
				}
				num = (short)1387790337;
				if (num != 0)
				{
				}
				num = (short)683868160;
				short num3 = num;
				num = (short)160301056;
				if (num != 0)
				{
				}
				return this.cnvPerRACAccessType_A7388._HasDiffs;
			}
		}

		// Token: 0x17006509 RID: 25865
		// (get) Token: 0x0600C965 RID: 51557 RVA: 0x00BC23E0 File Offset: 0x00BC05E0
		// (set) Token: 0x0600C966 RID: 51558 RVA: 0x00BC2494 File Offset: 0x00BC0694
		public int CnvPerRACCodeType1_A7680Value
		{
			get
			{
				short num = (short)1162215425;
				if (num != 0)
				{
				}
				num = (short)1464313785;
				short num2 = num;
				num = (short)1915725753;
				switch (num2 == num)
				{
				}
				num = (short)78381056;
				short num3 = num;
				num = (short)1307770880;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.Value;
			}
			set
			{
				short num = (short)2040176406;
				short num2 = num;
				num = (short)522100502;
				switch (num2 == num)
				{
				}
				num = (short)102760449;
				if (num != 0)
				{
				}
				num = (short)925106176;
				short num3 = num;
				num = (short)1831141376;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.Value = value;
			}
		}

		// Token: 0x1700650A RID: 25866
		// (get) Token: 0x0600C967 RID: 51559 RVA: 0x00BC254C File Offset: 0x00BC074C
		// (set) Token: 0x0600C968 RID: 51560 RVA: 0x00BC2600 File Offset: 0x00BC0800
		public string CnvPerRACCodeType1_A7680_UIValue
		{
			get
			{
				short num = (short)426876065;
				short num2 = num;
				num = (short)148020385;
				switch (num2 == num)
				{
				}
				num = (short)1896873985;
				if (num != 0)
				{
				}
				num = (short)1928003584;
				short num3 = num;
				num = (short)155779072;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.UIValue;
			}
			set
			{
				short num = (short)608408193;
				short num2 = num;
				num = (short)1101566593;
				switch (num2 == num)
				{
				}
				num = (short)893845505;
				if (num != 0)
				{
				}
				num = (short)1936195584;
				short num3 = num;
				num = (short)1863647232;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.UIValue = value;
			}
		}

		// Token: 0x1700650B RID: 25867
		// (get) Token: 0x0600C969 RID: 51561 RVA: 0x00BC26B4 File Offset: 0x00BC08B4
		public global::AcpBusinessLayer.AcpListField CnvPerRACCodeType1_A7680
		{
			get
			{
				short num = (short)1351923407;
				short num2 = num;
				num = (short)1957607119;
				switch (num2 == num)
				{
				}
				num = (short)1474756608;
				if (num != 0)
				{
				}
				num = (short)1337786368;
				short num3 = num;
				num = (short)818085889;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680;
			}
		}

		// Token: 0x1700650C RID: 25868
		// (get) Token: 0x0600C96A RID: 51562 RVA: 0x00BC2764 File Offset: 0x00BC0964
		// (set) Token: 0x0600C96B RID: 51563 RVA: 0x00BC2818 File Offset: 0x00BC0A18
		public bool CnvPerRACCodeType1_A7680_Applicable
		{
			get
			{
				short num = (short)1209009480;
				short num2 = num;
				num = (short)159122760;
				switch (num2 == num)
				{
				}
				num = (short)1526726657;
				if (num != 0)
				{
				}
				num = (short)2061434880;
				short num3 = num;
				num = (short)890437632;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.Applicable;
			}
			set
			{
				short num = (short)184614913;
				if (num != 0)
				{
				}
				num = (short)855494222;
				short num2 = num;
				num = (short)70176334;
				switch (num2 == num)
				{
				}
				num = (short)296484864;
				short num3 = num;
				num = (short)1851719680;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.Applicable = value;
			}
		}

		// Token: 0x1700650D RID: 25869
		// (get) Token: 0x0600C96C RID: 51564 RVA: 0x00BC28D0 File Offset: 0x00BC0AD0
		// (set) Token: 0x0600C96D RID: 51565 RVA: 0x00BC2984 File Offset: 0x00BC0B84
		public bool CnvPerRACCodeType1_A7680_Valid
		{
			get
			{
				short num = (short)44579110;
				short num2 = num;
				num = (short)1535260966;
				switch (num2 == num)
				{
				}
				num = (short)840826881;
				if (num != 0)
				{
				}
				num = (short)1708457984;
				short num3 = num;
				num = (short)1574043648;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.Valid;
			}
			set
			{
				short num = (short)230843057;
				short num2 = num;
				num = (short)1562206897;
				switch (num2 == num)
				{
				}
				num = (short)1924464641;
				if (num != 0)
				{
				}
				num = (short)1087832064;
				short num3 = num;
				num = (short)2132082688;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.Valid = value;
			}
		}

		// Token: 0x1700650E RID: 25870
		// (get) Token: 0x0600C96E RID: 51566 RVA: 0x00BC2A3C File Offset: 0x00BC0C3C
		// (set) Token: 0x0600C96F RID: 51567 RVA: 0x00BC2AF0 File Offset: 0x00BC0CF0
		public bool CnvPerRACCodeType1_A7680_Visible
		{
			get
			{
				short num = (short)411180072;
				short num2 = num;
				num = (short)1361845288;
				switch (num2 == num)
				{
				}
				num = (short)636747776;
				if (num != 0)
				{
				}
				num = (short)864813056;
				short num3 = num;
				num = (short)1599602689;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.Visible;
			}
			set
			{
				short num = (short)2125594625;
				if (num != 0)
				{
				}
				num = (short)1236437738;
				short num2 = num;
				num = (short)340560618;
				switch (num2 == num)
				{
				}
				num = (short)940113920;
				short num3 = num;
				num = (short)1003159552;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.Visible = value;
			}
		}

		// Token: 0x1700650F RID: 25871
		// (get) Token: 0x0600C970 RID: 51568 RVA: 0x00BC2BA8 File Offset: 0x00BC0DA8
		// (set) Token: 0x0600C971 RID: 51569 RVA: 0x00BC2C5C File Offset: 0x00BC0E5C
		public bool CnvPerRACCodeType1_A7680_Editable
		{
			get
			{
				short num = (short)1282328727;
				short num2 = num;
				num = (short)1604634775;
				switch (num2 == num)
				{
				}
				num = (short)1875574785;
				if (num != 0)
				{
				}
				num = (short)269615104;
				short num3 = num;
				num = (short)456523776;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.Editable;
			}
			set
			{
				short num = (short)1556467139;
				short num2 = num;
				num = (short)559664579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1996095488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008088576;
				if (num != 0)
				{
				}
				num = (short)1509228545;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.Editable = value;
			}
		}

		// Token: 0x17006510 RID: 25872
		// (get) Token: 0x0600C972 RID: 51570 RVA: 0x00BC2D14 File Offset: 0x00BC0F14
		internal string CnvPerRACCodeType1_A7680_UILabel
		{
			get
			{
				short num = (short)599387021;
				short num2 = num;
				num = (short)1202711437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607846400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1941897217;
				if (num != 0)
				{
				}
				num = (short)1675886592;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.UIName;
			}
		}

		// Token: 0x17006511 RID: 25873
		// (get) Token: 0x0600C973 RID: 51571 RVA: 0x00BC2DC8 File Offset: 0x00BC0FC8
		// (set) Token: 0x0600C974 RID: 51572 RVA: 0x00BC2E7C File Offset: 0x00BC107C
		internal bool CnvPerRACCodeType1_A7680_HiddenStatic
		{
			get
			{
				short num = (short)1562231637;
				short num2 = num;
				num = (short)1388626773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)151846912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054094849;
				if (num != 0)
				{
				}
				num = (short)119013376;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.HiddenStatic;
			}
			set
			{
				short num = (short)435255654;
				short num2 = num;
				num = (short)417429862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391577600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435828225;
				if (num != 0)
				{
				}
				num = (short)1344733184;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.HiddenStatic = value;
			}
		}

		// Token: 0x17006512 RID: 25874
		// (get) Token: 0x0600C975 RID: 51573 RVA: 0x00BC2F30 File Offset: 0x00BC1130
		// (set) Token: 0x0600C976 RID: 51574 RVA: 0x00BC2FE4 File Offset: 0x00BC11E4
		internal bool CnvPerRACCodeType1_A7680_HiddenDynamic
		{
			get
			{
				short num = (short)1788688368;
				short num2 = num;
				num = (short)690894832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473052672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)870318081;
				if (num != 0)
				{
				}
				num = (short)1288110080;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680.HiddenDynamic;
			}
			set
			{
				short num = (short)1183295510;
				short num2 = num;
				num = (short)755148822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365821952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302841856;
				if (num != 0)
				{
				}
				num = (short)1237778433;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType1_A7680.HiddenDynamic = value;
			}
		}

		// Token: 0x17006513 RID: 25875
		// (get) Token: 0x0600C977 RID: 51575 RVA: 0x00BC309C File Offset: 0x00BC129C
		public bool CnvPerRACCodeType1_A7680_HasDiffs
		{
			get
			{
				short num = (short)829608145;
				short num2 = num;
				num = (short)2034946257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761017856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450822144;
				if (num != 0)
				{
				}
				num = (short)643563521;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType1_A7680._HasDiffs;
			}
		}

		// Token: 0x17006514 RID: 25876
		// (get) Token: 0x0600C978 RID: 51576 RVA: 0x00BC3154 File Offset: 0x00BC1354
		// (set) Token: 0x0600C979 RID: 51577 RVA: 0x00BC3208 File Offset: 0x00BC1408
		public int CnvPerRACMDCRepeaterID1_A8783Value
		{
			get
			{
				short num = (short)120050110;
				short num2 = num;
				num = (short)1738658238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1923743744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542062081;
				if (num != 0)
				{
				}
				num = (short)1507786752;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.Value;
			}
			set
			{
				short num = (short)207229748;
				short num2 = num;
				num = (short)1975784244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)624164864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)308150273;
				if (num != 0)
				{
				}
				num = (short)1282736128;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.Value = value;
			}
		}

		// Token: 0x17006515 RID: 25877
		// (get) Token: 0x0600C97A RID: 51578 RVA: 0x00BC32C0 File Offset: 0x00BC14C0
		// (set) Token: 0x0600C97B RID: 51579 RVA: 0x00BC3378 File Offset: 0x00BC1578
		public string CnvPerRACMDCRepeaterID1_A8783_UIValue
		{
			get
			{
				short num = (short)428294111;
				short num2 = num;
				num = (short)304299999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047068672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1830092800;
				if (num != 0)
				{
				}
				num = (short)1010434049;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.UIValue;
			}
			set
			{
				short num = (short)563884046;
				short num2 = num;
				num = (short)1427648526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557121536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)670367745;
				if (num != 0)
				{
				}
				num = (short)1643118592;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.UIValue = value;
			}
		}

		// Token: 0x17006516 RID: 25878
		// (get) Token: 0x0600C97C RID: 51580 RVA: 0x00BC3430 File Offset: 0x00BC1630
		public global::AcpBusinessLayer.AcpRecRefField CnvPerRACMDCRepeaterID1_A8783
		{
			get
			{
				short num = (short)2076180481;
				if (num != 0)
				{
				}
				num = (short)283508736;
				short num2 = num;
				num = (short)1849028678;
				short num3 = num;
				num = (short)389083206;
				switch (num3 == num)
				{
				}
				num = (short)342884352;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783;
			}
		}

		// Token: 0x17006517 RID: 25879
		// (get) Token: 0x0600C97D RID: 51581 RVA: 0x00BC34E4 File Offset: 0x00BC16E4
		// (set) Token: 0x0600C97E RID: 51582 RVA: 0x00BC3598 File Offset: 0x00BC1798
		public bool CnvPerRACMDCRepeaterID1_A8783_Applicable
		{
			get
			{
				short num = (short)1278780457;
				short num2 = num;
				num = (short)700359721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363986944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)909836288;
				if (num != 0)
				{
				}
				num = (short)868745217;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.Applicable;
			}
			set
			{
				short num = (short)826504361;
				short num2 = num;
				num = (short)203584681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1073479680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)582746112;
				if (num != 0)
				{
				}
				num = (short)733151233;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.Applicable = value;
			}
		}

		// Token: 0x17006518 RID: 25880
		// (get) Token: 0x0600C97F RID: 51583 RVA: 0x00BC364C File Offset: 0x00BC184C
		// (set) Token: 0x0600C980 RID: 51584 RVA: 0x00BC3700 File Offset: 0x00BC1900
		public bool CnvPerRACMDCRepeaterID1_A8783_Valid
		{
			get
			{
				short num = (short)1925705895;
				short num2 = num;
				num = (short)1999696039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640155648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030174209;
				if (num != 0)
				{
				}
				num = (short)1130299392;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.Valid;
			}
			set
			{
				short num = (short)1538483737;
				short num2 = num;
				num = (short)1463051801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)94175232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1710424065;
				if (num != 0)
				{
				}
				num = (short)183959552;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.Valid = value;
			}
		}

		// Token: 0x17006519 RID: 25881
		// (get) Token: 0x0600C981 RID: 51585 RVA: 0x00BC37B8 File Offset: 0x00BC19B8
		// (set) Token: 0x0600C982 RID: 51586 RVA: 0x00BC3870 File Offset: 0x00BC1A70
		public bool CnvPerRACMDCRepeaterID1_A8783_Visible
		{
			get
			{
				short num = (short)1451360257;
				if (num != 0)
				{
				}
				num = (short)1614807040;
				short num2 = num;
				num = (short)835841417;
				short num3 = num;
				num = (short)447606153;
				switch (num3 == num)
				{
				}
				num = (short)969998336;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.Visible;
			}
			set
			{
				short num = (short)1006113386;
				short num2 = num;
				num = (short)2042565226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892810752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414856705;
				if (num != 0)
				{
				}
				num = (short)767688704;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.Visible = value;
			}
		}

		// Token: 0x1700651A RID: 25882
		// (get) Token: 0x0600C983 RID: 51587 RVA: 0x00BC3924 File Offset: 0x00BC1B24
		// (set) Token: 0x0600C984 RID: 51588 RVA: 0x00BC39DC File Offset: 0x00BC1BDC
		public bool CnvPerRACMDCRepeaterID1_A8783_Editable
		{
			get
			{
				short num = (short)1699153708;
				short num2 = num;
				num = (short)355534636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902510080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1325465601;
				if (num != 0)
				{
				}
				num = (short)1458700288;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.Editable;
			}
			set
			{
				short num = (short)385237213;
				short num2 = num;
				num = (short)976699613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)831913984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789643265;
				if (num != 0)
				{
				}
				num = (short)1718943744;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.Editable = value;
			}
		}

		// Token: 0x1700651B RID: 25883
		// (get) Token: 0x0600C985 RID: 51589 RVA: 0x00BC3A94 File Offset: 0x00BC1C94
		internal string CnvPerRACMDCRepeaterID1_A8783_UILabel
		{
			get
			{
				short num = (short)1714936873;
				short num2 = num;
				num = (short)779213865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733951488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109903873;
				if (num != 0)
				{
				}
				num = (short)1386479616;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.UIName;
			}
		}

		// Token: 0x1700651C RID: 25884
		// (get) Token: 0x0600C986 RID: 51590 RVA: 0x00BC3B48 File Offset: 0x00BC1D48
		// (set) Token: 0x0600C987 RID: 51591 RVA: 0x00BC3C00 File Offset: 0x00BC1E00
		internal bool CnvPerRACMDCRepeaterID1_A8783_HiddenStatic
		{
			get
			{
				short num = (short)2000289793;
				if (num != 0)
				{
				}
				num = (short)743964672;
				short num2 = num;
				num = (short)1150223965;
				short num3 = num;
				num = (short)1794967133;
				switch (num3 == num)
				{
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.HiddenStatic;
			}
			set
			{
				short num = (short)1460601229;
				short num2 = num;
				num = (short)1434648973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)528809984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)550961152;
				if (num != 0)
				{
				}
				num = (short)1255407617;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.HiddenStatic = value;
			}
		}

		// Token: 0x1700651D RID: 25885
		// (get) Token: 0x0600C988 RID: 51592 RVA: 0x00BC3CB4 File Offset: 0x00BC1EB4
		// (set) Token: 0x0600C989 RID: 51593 RVA: 0x00BC3D68 File Offset: 0x00BC1F68
		internal bool CnvPerRACMDCRepeaterID1_A8783_HiddenDynamic
		{
			get
			{
				short num = (short)1853896509;
				short num2 = num;
				num = (short)1315845949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989279744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914306561;
				if (num != 0)
				{
				}
				num = (short)283377664;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783.HiddenDynamic;
			}
			set
			{
				short num = (short)920240725;
				short num2 = num;
				num = (short)1965081173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)198639616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577503233;
				if (num != 0)
				{
				}
				num = (short)390135808;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID1_A8783.HiddenDynamic = value;
			}
		}

		// Token: 0x1700651E RID: 25886
		// (get) Token: 0x0600C98A RID: 51594 RVA: 0x00BC3E1C File Offset: 0x00BC201C
		public bool CnvPerRACMDCRepeaterID1_A8783_HasDiffs
		{
			get
			{
				short num = (short)500594544;
				short num2 = num;
				num = (short)1177778032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)634978304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1890648065;
				if (num != 0)
				{
				}
				num = (short)1392967680;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID1_A8783._HasDiffs;
			}
		}

		// Token: 0x1700651F RID: 25887
		// (get) Token: 0x0600C98B RID: 51595 RVA: 0x00BC3ED4 File Offset: 0x00BC20D4
		// (set) Token: 0x0600C98C RID: 51596 RVA: 0x00BC3F8C File Offset: 0x00BC218C
		public int CnvPerRACMDCRepeaterID2_A8814Value
		{
			get
			{
				short num = (short)307646135;
				short num2 = num;
				num = (short)782126775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)159252480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527564801;
				if (num != 0)
				{
				}
				num = (short)418709504;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.Value;
			}
			set
			{
				short num = (short)357774867;
				short num2 = num;
				num = (short)1601975827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1361575936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496317953;
				if (num != 0)
				{
				}
				num = (short)635109376;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.Value = value;
			}
		}

		// Token: 0x17006520 RID: 25888
		// (get) Token: 0x0600C98D RID: 51597 RVA: 0x00BC4040 File Offset: 0x00BC2240
		// (set) Token: 0x0600C98E RID: 51598 RVA: 0x00BC40F0 File Offset: 0x00BC22F0
		public string CnvPerRACMDCRepeaterID2_A8814_UIValue
		{
			get
			{
				short num = (short)699700435;
				short num2 = num;
				num = (short)521311443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1580728320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1446379521;
				if (num != 0)
				{
				}
				num = (short)644349952;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.UIValue;
			}
			set
			{
				short num = (short)33299312;
				short num2 = num;
				num = (short)1370626928;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136539136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714997761;
				if (num != 0)
				{
				}
				num = (short)323026944;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.UIValue = value;
			}
		}

		// Token: 0x17006521 RID: 25889
		// (get) Token: 0x0600C98F RID: 51599 RVA: 0x00BC41A4 File Offset: 0x00BC23A4
		public global::AcpBusinessLayer.AcpRecRefField CnvPerRACMDCRepeaterID2_A8814
		{
			get
			{
				short num = (short)1306968719;
				short num2 = num;
				num = (short)1663025807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508442112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)802750465;
				if (num != 0)
				{
				}
				num = (short)1671626752;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814;
			}
		}

		// Token: 0x17006522 RID: 25890
		// (get) Token: 0x0600C990 RID: 51600 RVA: 0x00BC4254 File Offset: 0x00BC2454
		// (set) Token: 0x0600C991 RID: 51601 RVA: 0x00BC4308 File Offset: 0x00BC2508
		public bool CnvPerRACMDCRepeaterID2_A8814_Applicable
		{
			get
			{
				short num = (short)711384571;
				short num2 = num;
				num = (short)1572003323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142999552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1419575296;
				if (num != 0)
				{
				}
				num = (short)800194561;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.Applicable;
			}
			set
			{
				short num = (short)1639620244;
				short num2 = num;
				num = (short)1819975316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980942848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046937601;
				if (num != 0)
				{
				}
				num = (short)1241186304;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.Applicable = value;
			}
		}

		// Token: 0x17006523 RID: 25891
		// (get) Token: 0x0600C992 RID: 51602 RVA: 0x00BC43C0 File Offset: 0x00BC25C0
		// (set) Token: 0x0600C993 RID: 51603 RVA: 0x00BC4478 File Offset: 0x00BC2678
		public bool CnvPerRACMDCRepeaterID2_A8814_Valid
		{
			get
			{
				short num = (short)1171554420;
				short num2 = num;
				num = (short)1940095092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)293666816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)235864065;
				if (num != 0)
				{
				}
				num = (short)1375666176;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.Valid;
			}
			set
			{
				short num = (short)1867240693;
				short num2 = num;
				num = (short)188142837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)594411520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)815661057;
				if (num != 0)
				{
				}
				num = (short)1058209792;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.Valid = value;
			}
		}

		// Token: 0x17006524 RID: 25892
		// (get) Token: 0x0600C994 RID: 51604 RVA: 0x00BC4530 File Offset: 0x00BC2730
		// (set) Token: 0x0600C995 RID: 51605 RVA: 0x00BC45E8 File Offset: 0x00BC27E8
		public bool CnvPerRACMDCRepeaterID2_A8814_Visible
		{
			get
			{
				short num = (short)727705556;
				short num2 = num;
				num = (short)1453975508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068564480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1114177537;
				if (num != 0)
				{
				}
				num = (short)298057728;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.Visible;
			}
			set
			{
				short num = (short)117831992;
				short num2 = num;
				num = (short)32569656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720909824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1467613185;
				if (num != 0)
				{
				}
				num = (short)1387528192;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.Visible = value;
			}
		}

		// Token: 0x17006525 RID: 25893
		// (get) Token: 0x0600C996 RID: 51606 RVA: 0x00BC46A4 File Offset: 0x00BC28A4
		// (set) Token: 0x0600C997 RID: 51607 RVA: 0x00BC4758 File Offset: 0x00BC2958
		public bool CnvPerRACMDCRepeaterID2_A8814_Editable
		{
			get
			{
				short num = (short)1188066641;
				short num2 = num;
				num = (short)910914897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958412288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18939904;
				if (num != 0)
				{
				}
				num = (short)1369571329;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.Editable;
			}
			set
			{
				short num = (short)1948951973;
				short num2 = num;
				num = (short)593208741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)914751488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385758720;
				if (num != 0)
				{
				}
				num = (short)1628372993;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.Editable = value;
			}
		}

		// Token: 0x17006526 RID: 25894
		// (get) Token: 0x0600C998 RID: 51608 RVA: 0x00BC480C File Offset: 0x00BC2A0C
		internal string CnvPerRACMDCRepeaterID2_A8814_UILabel
		{
			get
			{
				short num = (short)1567140036;
				short num2 = num;
				num = (short)1391438020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907687424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526057472;
				if (num != 0)
				{
				}
				num = (short)354025473;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.UIName;
			}
		}

		// Token: 0x17006527 RID: 25895
		// (get) Token: 0x0600C999 RID: 51609 RVA: 0x00BC48C0 File Offset: 0x00BC2AC0
		// (set) Token: 0x0600C99A RID: 51610 RVA: 0x00BC4978 File Offset: 0x00BC2B78
		internal bool CnvPerRACMDCRepeaterID2_A8814_HiddenStatic
		{
			get
			{
				short num = (short)1943167497;
				short num2 = num;
				num = (short)701260297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)784924672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)181075968;
				if (num != 0)
				{
				}
				num = (short)1077084161;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.HiddenStatic;
			}
			set
			{
				short num = (short)508358214;
				short num2 = num;
				num = (short)161017414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1568276480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1579941889;
				if (num != 0)
				{
				}
				num = (short)467271680;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.HiddenStatic = value;
			}
		}

		// Token: 0x17006528 RID: 25896
		// (get) Token: 0x0600C99B RID: 51611 RVA: 0x00BC4A2C File Offset: 0x00BC2C2C
		// (set) Token: 0x0600C99C RID: 51612 RVA: 0x00BC4ADC File Offset: 0x00BC2CDC
		internal bool CnvPerRACMDCRepeaterID2_A8814_HiddenDynamic
		{
			get
			{
				short num = (short)676272565;
				short num2 = num;
				num = (short)1653283253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036858880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1864105985;
				if (num != 0)
				{
				}
				num = (short)1765343232;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814.HiddenDynamic;
			}
			set
			{
				short num = (short)2105436122;
				short num2 = num;
				num = (short)1948149722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422117376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331939841;
				if (num != 0)
				{
				}
				num = (short)830013440;
				if (num != 0)
				{
				}
				this.cnvPerRACMDCRepeaterID2_A8814.HiddenDynamic = value;
			}
		}

		// Token: 0x17006529 RID: 25897
		// (get) Token: 0x0600C99D RID: 51613 RVA: 0x00BC4B90 File Offset: 0x00BC2D90
		public bool CnvPerRACMDCRepeaterID2_A8814_HasDiffs
		{
			get
			{
				short num = (short)1140354823;
				short num2 = num;
				num = (short)1294954247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)829947904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1154220033;
				if (num != 0)
				{
				}
				num = (short)831717376;
				if (num != 0)
				{
				}
				return this.cnvPerRACMDCRepeaterID2_A8814._HasDiffs;
			}
		}

		// Token: 0x1700652A RID: 25898
		// (get) Token: 0x0600C99E RID: 51614 RVA: 0x00BC4C48 File Offset: 0x00BC2E48
		// (set) Token: 0x0600C99F RID: 51615 RVA: 0x00BC4D00 File Offset: 0x00BC2F00
		public int CnvPerRACCodeType2_A8817Value
		{
			get
			{
				short num = (short)882486362;
				short num2 = num;
				num = (short)10726490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1914961920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998258177;
				if (num != 0)
				{
				}
				num = (short)1561264128;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817.Value;
			}
			set
			{
				short num = (short)2133716567;
				short num2 = num;
				num = (short)297397847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532152320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917504001;
				if (num != 0)
				{
				}
				num = (short)248512512;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType2_A8817.Value = value;
			}
		}

		// Token: 0x1700652B RID: 25899
		// (get) Token: 0x0600C9A0 RID: 51616 RVA: 0x00BC4DB8 File Offset: 0x00BC2FB8
		// (set) Token: 0x0600C9A1 RID: 51617 RVA: 0x00BC4E6C File Offset: 0x00BC306C
		public string CnvPerRACCodeType2_A8817_UIValue
		{
			get
			{
				short num = (short)1135280129;
				if (num != 0)
				{
				}
				num = (short)827326464;
				short num2 = num;
				num = (short)378552870;
				short num3 = num;
				num = (short)1823949350;
				switch (num3 == num)
				{
				}
				num = (short)2126249984;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817.UIValue;
			}
			set
			{
				short num = (short)945558689;
				short num2 = num;
				num = (short)1083446433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)525533184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992163329;
				if (num != 0)
				{
				}
				num = (short)1077215232;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType2_A8817.UIValue = value;
			}
		}

		// Token: 0x1700652C RID: 25900
		// (get) Token: 0x0600C9A2 RID: 51618 RVA: 0x00BC4F24 File Offset: 0x00BC3124
		public global::AcpBusinessLayer.AcpListField CnvPerRACCodeType2_A8817
		{
			get
			{
				short num = (short)838690868;
				short num2 = num;
				num = (short)377382964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1264713728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1347158017;
				if (num != 0)
				{
				}
				num = (short)605093888;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817;
			}
		}

		// Token: 0x1700652D RID: 25901
		// (get) Token: 0x0600C9A3 RID: 51619 RVA: 0x00BC4FD8 File Offset: 0x00BC31D8
		// (set) Token: 0x0600C9A4 RID: 51620 RVA: 0x00BC508C File Offset: 0x00BC328C
		public bool CnvPerRACCodeType2_A8817_Applicable
		{
			get
			{
				short num = (short)2143813633;
				if (num != 0)
				{
				}
				num = (short)827260928;
				short num2 = num;
				num = (short)200100764;
				short num3 = num;
				num = (short)1656834972;
				switch (num3 == num)
				{
				}
				num = (short)1477443584;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817.Applicable;
			}
			set
			{
				short num = (short)1944145991;
				short num2 = num;
				num = (short)170152007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1439236096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1423179776;
				if (num != 0)
				{
				}
				num = (short)199426049;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType2_A8817.Applicable = value;
			}
		}

		// Token: 0x1700652E RID: 25902
		// (get) Token: 0x0600C9A5 RID: 51621 RVA: 0x00BC5140 File Offset: 0x00BC3340
		// (set) Token: 0x0600C9A6 RID: 51622 RVA: 0x00BC51F8 File Offset: 0x00BC33F8
		public bool CnvPerRACCodeType2_A8817_Valid
		{
			get
			{
				short num = (short)632493307;
				short num2 = num;
				num = (short)992417019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701104128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)855310337;
				if (num != 0)
				{
				}
				num = (short)1694826496;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817.Valid;
			}
			set
			{
				short num = (short)1083918861;
				short num2 = num;
				num = (short)694831629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478478336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1846411265;
				if (num != 0)
				{
				}
				num = (short)1621426176;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType2_A8817.Valid = value;
			}
		}

		// Token: 0x1700652F RID: 25903
		// (get) Token: 0x0600C9A7 RID: 51623 RVA: 0x00BC52AC File Offset: 0x00BC34AC
		// (set) Token: 0x0600C9A8 RID: 51624 RVA: 0x00BC5360 File Offset: 0x00BC3560
		public bool CnvPerRACCodeType2_A8817_Visible
		{
			get
			{
				short num = (short)980937838;
				short num2 = num;
				num = (short)1023011950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)728825856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)103677953;
				if (num != 0)
				{
				}
				num = (short)939261952;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817.Visible;
			}
			set
			{
				short num = (short)2028193638;
				short num2 = num;
				num = (short)400541542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150222336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)905838593;
				if (num != 0)
				{
				}
				num = (short)208601088;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType2_A8817.Visible = value;
			}
		}

		// Token: 0x17006530 RID: 25904
		// (get) Token: 0x0600C9A9 RID: 51625 RVA: 0x00BC5418 File Offset: 0x00BC3618
		// (set) Token: 0x0600C9AA RID: 51626 RVA: 0x00BC54CC File Offset: 0x00BC36CC
		public bool CnvPerRACCodeType2_A8817_Editable
		{
			get
			{
				short num = (short)1556867584;
				short num2 = num;
				num = (short)746646016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681522688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885405185;
				if (num != 0)
				{
				}
				num = (short)2069102592;
				if (num != 0)
				{
				}
				return this.cnvPerRACCodeType2_A8817.Editable;
			}
			set
			{
				short num = (short)1206553623;
				short num2 = num;
				num = (short)1417251863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970798592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127074304;
				if (num != 0)
				{
				}
				num = (short)830668801;
				if (num != 0)
				{
				}
				this.cnvPerRACCodeType2_A8817.Editable = value;
			}
		}

		// Token: 0x17006531 RID: 25905
		// (get) Token: 0x0600C9AB RID: 51627 RVA: 0x00BC5580 File Offset: 0x00BC3780
		internal string CnvPerRACCodeType2_A8817_UILabel
		{
			get
			{
				short num = (short)1955116816;
				short num2 = num;
				num = (short)1615443728;
				switch (num2 == num)
				{
				}
				num = (short)1965883392;
				if (num != 0)
				{
				}
				num = (short)605880321;
				if (num != 0)
				{
				}
				num = (short)2027618304;
				short num3 = num;
				return this.cnvPerRACCodeType2_A8817.UIName;
			}
		}

		// Token: 0x17006532 RID: 25906
		// (get) Token: 0x0600C9AC RID: 51628 RVA: 0x00BC5634 File Offset: 0x00BC3834
		// (set) Token: 0x0600C9AD RID: 51629 RVA: 0x00BC56E8 File Offset: 0x00BC38E8
		internal bool CnvPerRACCodeType2_A8817_HiddenStatic
		{
			get
			{
				short num = (short)971423872;
				short num2 = num;
				num = (short)868794496;
				switch (num2 == num)
				{
				}
				num = (short)1513947136;
				if (num != 0)
				{
				}
				num = (short)1816657921;
				if (num != 0)
				{
				}
				num = (short)928317440;
				short num3 = num;
				return this.cnvPerRACCodeType2_A8817.HiddenStatic;
			}
			set
			{
				short num = (short)2126928222;
				short num2 = num;
				num = (short)2012961118;
				switch (num2 == num)
				{
				}
				num = (short)342228993;
				if (num != 0)
				{
				}
				num = (short)141295616;
				if (num != 0)
				{
				}
				num = (short)1432748032;
				short num3 = num;
				this.cnvPerRACCodeType2_A8817.HiddenStatic = value;
			}
		}

		// Token: 0x17006533 RID: 25907
		// (get) Token: 0x0600C9AE RID: 51630 RVA: 0x00BC579C File Offset: 0x00BC399C
		// (set) Token: 0x0600C9AF RID: 51631 RVA: 0x00BC5854 File Offset: 0x00BC3A54
		internal bool CnvPerRACCodeType2_A8817_HiddenDynamic
		{
			get
			{
				short num = (short)160668350;
				short num2 = num;
				num = (short)1519557310;
				switch (num2 == num)
				{
				}
				num = (short)215678977;
				if (num != 0)
				{
				}
				num = (short)1029570560;
				if (num != 0)
				{
				}
				num = (short)1232142336;
				short num3 = num;
				return this.cnvPerRACCodeType2_A8817.HiddenDynamic;
			}
			set
			{
				short num = (short)1711422699;
				short num2 = num;
				num = (short)1958100203;
				switch (num2 == num)
				{
				}
				num = (short)2088501249;
				if (num != 0)
				{
				}
				num = (short)1902772224;
				if (num != 0)
				{
				}
				num = (short)657719296;
				short num3 = num;
				this.cnvPerRACCodeType2_A8817.HiddenDynamic = value;
			}
		}

		// Token: 0x17006534 RID: 25908
		// (get) Token: 0x0600C9B0 RID: 51632 RVA: 0x00BC590C File Offset: 0x00BC3B0C
		public bool CnvPerRACCodeType2_A8817_HasDiffs
		{
			get
			{
				short num = (short)1752954819;
				short num2 = num;
				num = (short)1523120067;
				switch (num2 == num)
				{
				}
				num = (short)998178816;
				if (num != 0)
				{
				}
				num = (short)539492353;
				if (num != 0)
				{
				}
				num = (short)1806106624;
				short num3 = num;
				return this.cnvPerRACCodeType2_A8817._HasDiffs;
			}
		}

		// Token: 0x17006535 RID: 25909
		// (get) Token: 0x0600C9B1 RID: 51633 RVA: 0x00BC59C4 File Offset: 0x00BC3BC4
		// (set) Token: 0x0600C9B2 RID: 51634 RVA: 0x00BC5A78 File Offset: 0x00BC3C78
		public bool CnvPerRACRepeaterAccess_A8939Value
		{
			get
			{
				short num = (short)188809217;
				if (num != 0)
				{
				}
				num = (short)1898478927;
				short num2 = num;
				num = (short)397311311;
				switch (num2 == num)
				{
				}
				num = (short)1205141504;
				if (num != 0)
				{
				}
				num = (short)2048983040;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.Value;
			}
			set
			{
				short num = (short)2084590099;
				short num2 = num;
				num = (short)1820938771;
				switch (num2 == num)
				{
				}
				num = (short)194379776;
				if (num != 0)
				{
				}
				num = (short)813957121;
				if (num != 0)
				{
				}
				num = (short)2145452032;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.Value = value;
			}
		}

		// Token: 0x17006536 RID: 25910
		// (get) Token: 0x0600C9B3 RID: 51635 RVA: 0x00BC5B2C File Offset: 0x00BC3D2C
		public global::AcpBusinessLayer.AcpField<bool> CnvPerRACRepeaterAccess_A8939
		{
			get
			{
				short num = (short)2085900722;
				short num2 = num;
				num = (short)582242738;
				switch (num2 == num)
				{
				}
				num = (short)71303168;
				if (num != 0)
				{
				}
				num = (short)1314521089;
				if (num != 0)
				{
				}
				num = (short)771555328;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939;
			}
		}

		// Token: 0x17006537 RID: 25911
		// (get) Token: 0x0600C9B4 RID: 51636 RVA: 0x00BC5BD8 File Offset: 0x00BC3DD8
		// (set) Token: 0x0600C9B5 RID: 51637 RVA: 0x00BC5C8C File Offset: 0x00BC3E8C
		public bool CnvPerRACRepeaterAccess_A8939_UIValue
		{
			get
			{
				short num = (short)649143220;
				short num2 = num;
				num = (short)914498484;
				switch (num2 == num)
				{
				}
				num = (short)2071855105;
				if (num != 0)
				{
				}
				num = (short)288620544;
				if (num != 0)
				{
				}
				num = (short)642514944;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.Value;
			}
			set
			{
				short num = (short)898801587;
				short num2 = num;
				num = (short)1038589875;
				switch (num2 == num)
				{
				}
				num = (short)1743978497;
				if (num != 0)
				{
				}
				num = (short)148570112;
				if (num != 0)
				{
				}
				num = (short)313851904;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.Value = value;
			}
		}

		// Token: 0x17006538 RID: 25912
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x00BC5D40 File Offset: 0x00BC3F40
		// (set) Token: 0x0600C9B7 RID: 51639 RVA: 0x00BC5DF4 File Offset: 0x00BC3FF4
		public bool CnvPerRACRepeaterAccess_A8939_Applicable
		{
			get
			{
				short num = (short)375720146;
				short num2 = num;
				num = (short)1065224402;
				switch (num2 == num)
				{
				}
				num = (short)357040129;
				if (num != 0)
				{
				}
				num = (short)2128281600;
				if (num != 0)
				{
				}
				num = (short)356843520;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.Applicable;
			}
			set
			{
				short num = (short)1767599329;
				short num2 = num;
				num = (short)1325559009;
				switch (num2 == num)
				{
				}
				num = (short)1718026240;
				if (num != 0)
				{
				}
				num = (short)549257217;
				if (num != 0)
				{
				}
				num = (short)372047872;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.Applicable = value;
			}
		}

		// Token: 0x17006539 RID: 25913
		// (get) Token: 0x0600C9B8 RID: 51640 RVA: 0x00BC5EAC File Offset: 0x00BC40AC
		// (set) Token: 0x0600C9B9 RID: 51641 RVA: 0x00BC5F60 File Offset: 0x00BC4160
		public bool CnvPerRACRepeaterAccess_A8939_Valid
		{
			get
			{
				short num = (short)1184004152;
				short num2 = num;
				num = (short)2038528056;
				switch (num2 == num)
				{
				}
				num = (short)1087635457;
				if (num != 0)
				{
				}
				num = (short)1818558464;
				if (num != 0)
				{
				}
				num = (short)1473314816;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.Valid;
			}
			set
			{
				short num = (short)564620484;
				short num2 = num;
				num = (short)1235971268;
				switch (num2 == num)
				{
				}
				num = (short)1874526209;
				if (num != 0)
				{
				}
				num = (short)1614938112;
				if (num != 0)
				{
				}
				num = (short)1405091840;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.Valid = value;
			}
		}

		// Token: 0x1700653A RID: 25914
		// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x00BC6014 File Offset: 0x00BC4214
		// (set) Token: 0x0600C9BB RID: 51643 RVA: 0x00BC60C8 File Offset: 0x00BC42C8
		public bool CnvPerRACRepeaterAccess_A8939_Visible
		{
			get
			{
				short num = (short)1585405544;
				short num2 = num;
				num = (short)1235508840;
				switch (num2 == num)
				{
				}
				num = (short)2102067201;
				if (num != 0)
				{
				}
				num = (short)2101805056;
				if (num != 0)
				{
				}
				num = (short)6684672;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.Visible;
			}
			set
			{
				short num = (short)639164115;
				short num2 = num;
				num = (short)437509843;
				switch (num2 == num)
				{
				}
				num = (short)1286799361;
				if (num != 0)
				{
				}
				num = (short)1790705664;
				if (num != 0)
				{
				}
				num = (short)1093337088;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.Visible = value;
			}
		}

		// Token: 0x1700653B RID: 25915
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x00BC617C File Offset: 0x00BC437C
		// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x00BC6230 File Offset: 0x00BC4430
		public bool CnvPerRACRepeaterAccess_A8939_Editable
		{
			get
			{
				short num = (short)2114055650;
				short num2 = num;
				num = (short)532606434;
				switch (num2 == num)
				{
				}
				num = (short)598933505;
				if (num != 0)
				{
				}
				num = (short)1178009600;
				if (num != 0)
				{
				}
				num = (short)790888448;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.Editable;
			}
			set
			{
				short num = (short)1902963879;
				short num2 = num;
				num = (short)1442507943;
				switch (num2 == num)
				{
				}
				num = (short)448724993;
				if (num != 0)
				{
				}
				num = (short)1105330176;
				if (num != 0)
				{
				}
				num = (short)832176128;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.Editable = value;
			}
		}

		// Token: 0x1700653C RID: 25916
		// (get) Token: 0x0600C9BE RID: 51646 RVA: 0x00BC62E4 File Offset: 0x00BC44E4
		internal string CnvPerRACRepeaterAccess_A8939_UILabel
		{
			get
			{
				short num = (short)1941674419;
				short num2 = num;
				num = (short)1755552179;
				switch (num2 == num)
				{
				}
				num = (short)23527425;
				if (num != 0)
				{
				}
				num = (short)20119552;
				if (num != 0)
				{
				}
				num = (short)494665728;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.UIName;
			}
		}

		// Token: 0x1700653D RID: 25917
		// (get) Token: 0x0600C9BF RID: 51647 RVA: 0x00BC6398 File Offset: 0x00BC4598
		// (set) Token: 0x0600C9C0 RID: 51648 RVA: 0x00BC644C File Offset: 0x00BC464C
		internal bool CnvPerRACRepeaterAccess_A8939_HiddenStatic
		{
			get
			{
				short num = (short)334743606;
				short num2 = num;
				num = (short)1614530614;
				switch (num2 == num)
				{
				}
				num = (short)1529085952;
				if (num != 0)
				{
				}
				num = (short)1331888129;
				if (num != 0)
				{
				}
				num = (short)777322496;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.HiddenStatic;
			}
			set
			{
				short num = (short)348782593;
				if (num != 0)
				{
				}
				num = (short)80942586;
				short num2 = num;
				num = (short)1393366522;
				switch (num2 == num)
				{
				}
				num = (short)1862533120;
				if (num != 0)
				{
				}
				num = (short)85852160;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.HiddenStatic = value;
			}
		}

		// Token: 0x1700653E RID: 25918
		// (get) Token: 0x0600C9C1 RID: 51649 RVA: 0x00BC6504 File Offset: 0x00BC4704
		// (set) Token: 0x0600C9C2 RID: 51650 RVA: 0x00BC65B8 File Offset: 0x00BC47B8
		internal bool CnvPerRACRepeaterAccess_A8939_HiddenDynamic
		{
			get
			{
				short num = (short)969509144;
				short num2 = num;
				num = (short)259426584;
				switch (num2 == num)
				{
				}
				num = (short)134348800;
				if (num != 0)
				{
				}
				num = (short)369688577;
				if (num != 0)
				{
				}
				num = (short)698286080;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939.HiddenDynamic;
			}
			set
			{
				short num = (short)1846545553;
				short num2 = num;
				num = (short)298388625;
				switch (num2 == num)
				{
				}
				num = (short)830078977;
				if (num != 0)
				{
				}
				num = (short)1732575232;
				if (num != 0)
				{
				}
				num = (short)139919360;
				short num3 = num;
				this.cnvPerRACRepeaterAccess_A8939.HiddenDynamic = value;
			}
		}

		// Token: 0x1700653F RID: 25919
		// (get) Token: 0x0600C9C3 RID: 51651 RVA: 0x00BC666C File Offset: 0x00BC486C
		public bool CnvPerRACRepeaterAccess_A8939_HasDiffs
		{
			get
			{
				short num = (short)1167401330;
				short num2 = num;
				num = (short)1473716594;
				switch (num2 == num)
				{
				}
				num = (short)320602113;
				if (num != 0)
				{
				}
				num = (short)854720512;
				if (num != 0)
				{
				}
				num = (short)992673792;
				short num3 = num;
				return this.cnvPerRACRepeaterAccess_A8939._HasDiffs;
			}
		}

		// Token: 0x17006540 RID: 25920
		// (get) Token: 0x0600C9C4 RID: 51652 RVA: 0x00BC6720 File Offset: 0x00BC4920
		// (set) Token: 0x0600C9C5 RID: 51653 RVA: 0x00BC67D4 File Offset: 0x00BC49D4
		public int CnvPerRACToneSignalingSystem_A9392Value
		{
			get
			{
				short num = (short)1445473438;
				short num2 = num;
				num = (short)1519725726;
				switch (num2 == num)
				{
				}
				num = (short)647692288;
				if (num != 0)
				{
				}
				num = (short)48168961;
				if (num != 0)
				{
				}
				num = (short)391315456;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.Value;
			}
			set
			{
				short num = (short)702074835;
				short num2 = num;
				num = (short)2100875219;
				switch (num2 == num)
				{
				}
				num = (short)894369793;
				if (num != 0)
				{
				}
				num = (short)1248460800;
				if (num != 0)
				{
				}
				num = (short)1704853504;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.Value = value;
			}
		}

		// Token: 0x17006541 RID: 25921
		// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x00BC688C File Offset: 0x00BC4A8C
		// (set) Token: 0x0600C9C7 RID: 51655 RVA: 0x00BC6940 File Offset: 0x00BC4B40
		public string CnvPerRACToneSignalingSystem_A9392_UIValue
		{
			get
			{
				short num = (short)1519088199;
				short num2 = num;
				num = (short)657879623;
				switch (num2 == num)
				{
				}
				num = (short)601161728;
				if (num != 0)
				{
				}
				num = (short)272695297;
				if (num != 0)
				{
				}
				num = (short)754122752;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.UIValue;
			}
			set
			{
				short num = (short)1223936255;
				short num2 = num;
				num = (short)2120730879;
				switch (num2 == num)
				{
				}
				num = (short)569573377;
				if (num != 0)
				{
				}
				num = (short)90767360;
				if (num != 0)
				{
				}
				num = (short)780599296;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.UIValue = value;
			}
		}

		// Token: 0x17006542 RID: 25922
		// (get) Token: 0x0600C9C8 RID: 51656 RVA: 0x00BC69F4 File Offset: 0x00BC4BF4
		public global::AcpBusinessLayer.AcpRecRefField CnvPerRACToneSignalingSystem_A9392
		{
			get
			{
				short num = (short)1063998599;
				short num2 = num;
				num = (short)1613780103;
				switch (num2 == num)
				{
				}
				num = (short)1269432321;
				if (num != 0)
				{
				}
				num = (short)1837760512;
				if (num != 0)
				{
				}
				num = (short)1505820672;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392;
			}
		}

		// Token: 0x17006543 RID: 25923
		// (get) Token: 0x0600C9C9 RID: 51657 RVA: 0x00BC6AA8 File Offset: 0x00BC4CA8
		// (set) Token: 0x0600C9CA RID: 51658 RVA: 0x00BC6B5C File Offset: 0x00BC4D5C
		public bool CnvPerRACToneSignalingSystem_A9392_Applicable
		{
			get
			{
				short num = (short)811766790;
				short num2 = num;
				num = (short)1484821510;
				switch (num2 == num)
				{
				}
				num = (short)1833304065;
				if (num != 0)
				{
				}
				num = (short)45481984;
				if (num != 0)
				{
				}
				num = (short)41811968;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.Applicable;
			}
			set
			{
				short num = (short)2127105423;
				short num2 = num;
				num = (short)1779830159;
				switch (num2 == num)
				{
				}
				num = (short)1682767872;
				if (num != 0)
				{
				}
				num = (short)1384054785;
				if (num != 0)
				{
				}
				num = (short)225378304;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.Applicable = value;
			}
		}

		// Token: 0x17006544 RID: 25924
		// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x00BC6C10 File Offset: 0x00BC4E10
		// (set) Token: 0x0600C9CC RID: 51660 RVA: 0x00BC6CC4 File Offset: 0x00BC4EC4
		public bool CnvPerRACToneSignalingSystem_A9392_Valid
		{
			get
			{
				short num = (short)1177615828;
				short num2 = num;
				num = (short)1892351444;
				switch (num2 == num)
				{
				}
				num = (short)427950080;
				if (num != 0)
				{
				}
				num = (short)675348481;
				if (num != 0)
				{
				}
				num = (short)1212481536;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.Valid;
			}
			set
			{
				short num = (short)126577952;
				short num2 = num;
				num = (short)865430816;
				switch (num2 == num)
				{
				}
				num = (short)1420492801;
				if (num != 0)
				{
				}
				num = (short)1816264704;
				if (num != 0)
				{
				}
				num = (short)640090112;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.Valid = value;
			}
		}

		// Token: 0x17006545 RID: 25925
		// (get) Token: 0x0600C9CD RID: 51661 RVA: 0x00BC6D7C File Offset: 0x00BC4F7C
		// (set) Token: 0x0600C9CE RID: 51662 RVA: 0x00BC6E30 File Offset: 0x00BC5030
		public bool CnvPerRACToneSignalingSystem_A9392_Visible
		{
			get
			{
				short num = (short)1928921089;
				if (num != 0)
				{
				}
				num = (short)1013169728;
				short num2 = num;
				num = (short)1148501568;
				switch (num2 == num)
				{
				}
				num = (short)62914560;
				if (num != 0)
				{
				}
				num = (short)1659568128;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.Visible;
			}
			set
			{
				short num = (short)219866404;
				short num2 = num;
				num = (short)1712645412;
				switch (num2 == num)
				{
				}
				num = (short)146669569;
				if (num != 0)
				{
				}
				num = (short)1367146496;
				if (num != 0)
				{
				}
				num = (short)118882304;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.Visible = value;
			}
		}

		// Token: 0x17006546 RID: 25926
		// (get) Token: 0x0600C9CF RID: 51663 RVA: 0x00BC6EE8 File Offset: 0x00BC50E8
		// (set) Token: 0x0600C9D0 RID: 51664 RVA: 0x00BC6F98 File Offset: 0x00BC5198
		public bool CnvPerRACToneSignalingSystem_A9392_Editable
		{
			get
			{
				short num = (short)1900302181;
				short num2 = num;
				num = (short)1788366693;
				switch (num2 == num)
				{
				}
				num = (short)1586954241;
				if (num != 0)
				{
				}
				num = (short)1935998976;
				if (num != 0)
				{
				}
				num = (short)346095616;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.Editable;
			}
			set
			{
				short num = (short)236308299;
				short num2 = num;
				num = (short)147507019;
				switch (num2 == num)
				{
				}
				num = (short)930807809;
				if (num != 0)
				{
				}
				num = (short)638451712;
				if (num != 0)
				{
				}
				num = (short)759824384;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.Editable = value;
			}
		}

		// Token: 0x17006547 RID: 25927
		// (get) Token: 0x0600C9D1 RID: 51665 RVA: 0x00BC7050 File Offset: 0x00BC5250
		internal string CnvPerRACToneSignalingSystem_A9392_UILabel
		{
			get
			{
				short num = (short)24621403;
				short num2 = num;
				num = (short)25932123;
				switch (num2 == num)
				{
				}
				num = (short)1483669504;
				if (num != 0)
				{
				}
				num = (short)765394945;
				if (num != 0)
				{
				}
				num = (short)1983840256;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.UIName;
			}
		}

		// Token: 0x17006548 RID: 25928
		// (get) Token: 0x0600C9D2 RID: 51666 RVA: 0x00BC7108 File Offset: 0x00BC5308
		// (set) Token: 0x0600C9D3 RID: 51667 RVA: 0x00BC71BC File Offset: 0x00BC53BC
		internal bool CnvPerRACToneSignalingSystem_A9392_HiddenStatic
		{
			get
			{
				short num = (short)439689713;
				short num2 = num;
				num = (short)1514807793;
				switch (num2 == num)
				{
				}
				num = (short)1336672257;
				if (num != 0)
				{
				}
				num = (short)1995440128;
				if (num != 0)
				{
				}
				num = (short)217513984;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.HiddenStatic;
			}
			set
			{
				short num = (short)447474314;
				short num2 = num;
				num = (short)1724377738;
				switch (num2 == num)
				{
				}
				num = (short)282853377;
				if (num != 0)
				{
				}
				num = (short)1639776256;
				if (num != 0)
				{
				}
				num = (short)1593311232;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.HiddenStatic = value;
			}
		}

		// Token: 0x17006549 RID: 25929
		// (get) Token: 0x0600C9D4 RID: 51668 RVA: 0x00BC7270 File Offset: 0x00BC5470
		// (set) Token: 0x0600C9D5 RID: 51669 RVA: 0x00BC7324 File Offset: 0x00BC5524
		internal bool CnvPerRACToneSignalingSystem_A9392_HiddenDynamic
		{
			get
			{
				short num = (short)590421236;
				short num2 = num;
				num = (short)509156596;
				switch (num2 == num)
				{
				}
				num = (short)942473216;
				if (num != 0)
				{
				}
				num = (short)330170369;
				if (num != 0)
				{
				}
				num = (short)1996816384;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392.HiddenDynamic;
			}
			set
			{
				short num = (short)205347496;
				short num2 = num;
				num = (short)1087330984;
				switch (num2 == num)
				{
				}
				num = (short)2038497281;
				if (num != 0)
				{
				}
				num = (short)842924032;
				if (num != 0)
				{
				}
				num = (short)116588544;
				short num3 = num;
				this.cnvPerRACToneSignalingSystem_A9392.HiddenDynamic = value;
			}
		}

		// Token: 0x1700654A RID: 25930
		// (get) Token: 0x0600C9D6 RID: 51670 RVA: 0x00BC73DC File Offset: 0x00BC55DC
		public bool CnvPerRACToneSignalingSystem_A9392_HasDiffs
		{
			get
			{
				short num = (short)1826474658;
				short num2 = num;
				num = (short)1622461090;
				switch (num2 == num)
				{
				}
				num = (short)673972225;
				if (num != 0)
				{
				}
				num = (short)316735488;
				if (num != 0)
				{
				}
				num = (short)692387840;
				short num3 = num;
				return this.cnvPerRACToneSignalingSystem_A9392._HasDiffs;
			}
		}

		// Token: 0x1700654B RID: 25931
		// (get) Token: 0x0600C9D7 RID: 51671 RVA: 0x00BC7490 File Offset: 0x00BC5690
		// (set) Token: 0x0600C9D8 RID: 51672 RVA: 0x00BC7544 File Offset: 0x00BC5744
		public int CnvPerRACSingletone_A43073Value
		{
			get
			{
				short num = (short)85107315;
				short num2 = num;
				num = (short)1570480755;
				switch (num2 == num)
				{
				}
				num = (short)331939840;
				if (num != 0)
				{
				}
				num = (short)834863105;
				if (num != 0)
				{
				}
				num = (short)796524544;
				short num3 = num;
				return this.cnvPerRACSingletone_A43073.Value;
			}
			set
			{
				short num = (short)1204030414;
				short num2 = num;
				num = (short)1564412878;
				switch (num2 == num)
				{
				}
				num = (short)1104609281;
				if (num != 0)
				{
				}
				num = (short)425852928;
				if (num != 0)
				{
				}
				num = (short)1401356288;
				short num3 = num;
				this.cnvPerRACSingletone_A43073.Value = value;
			}
		}

		// Token: 0x1700654C RID: 25932
		// (get) Token: 0x0600C9D9 RID: 51673 RVA: 0x00BC75FC File Offset: 0x00BC57FC
		// (set) Token: 0x0600C9DA RID: 51674 RVA: 0x00BC76B0 File Offset: 0x00BC58B0
		public string CnvPerRACSingletone_A43073_UIValue
		{
			get
			{
				short num = (short)309001043;
				short num2 = num;
				num = (short)1000536915;
				switch (num2 == num)
				{
				}
				num = (short)2110849025;
				if (num != 0)
				{
				}
				num = (short)1930625024;
				if (num != 0)
				{
				}
				num = (short)1568538624;
				short num3 = num;
				return this.cnvPerRACSingletone_A43073.UIValue;
			}
			set
			{
				short num = (short)319738724;
				short num2 = num;
				num = (short)1604637540;
				switch (num2 == num)
				{
				}
				num = (short)836698112;
				if (num != 0)
				{
				}
				num = (short)1799815169;
				if (num != 0)
				{
				}
				num = (short)708378624;
				short num3 = num;
				this.cnvPerRACSingletone_A43073.UIValue = value;
			}
		}

		// Token: 0x1700654D RID: 25933
		// (get) Token: 0x0600C9DB RID: 51675 RVA: 0x00BC7768 File Offset: 0x00BC5968
		public global::AcpBusinessLayer.AcpRecRefField CnvPerRACSingletone_A43073
		{
			get
			{
				short num = (short)1273095043;
				short num2 = num;
				num = (short)227337091;
				switch (num2 == num)
				{
				}
				num = (short)1652621313;
				if (num != 0)
				{
				}
				num = (short)216399872;
				if (num != 0)
				{
				}
				num = (short)1232207872;
				short num3 = num;
				return this.cnvPerRACSingletone_A43073;
			}
		}

		// Token: 0x1700654E RID: 25934
		// (get) Token: 0x0600C9DC RID: 51676 RVA: 0x00BC7818 File Offset: 0x00BC5A18
		// (set) Token: 0x0600C9DD RID: 51677 RVA: 0x00BC78CC File Offset: 0x00BC5ACC
		public bool CnvPerRACSingletone_A43073_Applicable
		{
			get
			{
				short num = (short)355972755;
				short num2 = num;
				num = (short)647411347;
				switch (num2 == num)
				{
				}
				num = (short)645070848;
				if (num != 0)
				{
				}
				num = (short)1392836609;
				if (num != 0)
				{
				}
				num = (short)53673984;
				short num3 = num;
				return this.cnvPerRACSingletone_A43073.Applicable;
			}
			set
			{
				short num = (short)1718184761;
				short num2 = num;
				num = (short)81357625;
				switch (num2 == num)
				{
				}
				num = (short)775684097;
				if (num != 0)
				{
				}
				num = (short)387579904;
				if (num != 0)
				{
				}
				num = (short)991756288;
				short num3 = num;
				this.cnvPerRACSingletone_A43073.Applicable = value;
			}
		}

		// Token: 0x1700654F RID: 25935
		// (get) Token: 0x0600C9DE RID: 51678 RVA: 0x00BC7980 File Offset: 0x00BC5B80
		// (set) Token: 0x0600C9DF RID: 51679 RVA: 0x00BC7A34 File Offset: 0x00BC5C34
		public bool CnvPerRACSingletone_A43073_Valid
		{
			get
			{
				short num = (short)1233190540;
				short num2 = num;
				num = (short)1633091212;
				switch (num2 == num)
				{
				}
				num = (short)1320026112;
				if (num != 0)
				{
				}
				num = (short)920977409;
				if (num != 0)
				{
				}
				num = (short)1795948544;
				short num3 = num;
				return this.cnvPerRACSingletone_A43073.Valid;
			}
			set
			{
				short num = (short)264699905;
				if (num != 0)
				{
				}
				num = (short)1988549311;
				short num2 = num;
				num = (short)361618111;
				switch (num2 == num)
				{
				}
				num = (short)1313341440;
				if (num != 0)
				{
				}
				num = (short)1111228416;
				short num3 = num;
				this.cnvPerRACSingletone_A43073.Valid = value;
			}
		}

		// Token: 0x17006550 RID: 25936
		// (get) Token: 0x0600C9E0 RID: 51680 RVA: 0x00BC7AEC File Offset: 0x00BC5CEC
		// (set) Token: 0x0600C9E1 RID: 51681 RVA: 0x00BC7BA0 File Offset: 0x00BC5DA0
		public bool CnvPerRACSingletone_A43073_Visible
		{
			get
			{
				short num = (short)1605652557;
				short num2 = num;
				num = (short)1893748813;
				switch (num2 == num)
				{
				}
				num = (short)526123008;
				if (num != 0)
				{
				}
				num = (short)384827393;
				if (num != 0)
				{
				}
				num = (short)1418461184;
				short num3 = num;
				return this.cnvPerRACSingletone_A43073.Visible;
			}
			set
			{
				short num = (short)1281884160;
				short num2 = num;
				num = (short)749781985;
				short num3 = num;
				num = (short)1120191457;
				switch (num3 == num)
				{
				}
				num = (short)415432705;
				if (num != 0)
				{
				}
				num = (short)1720188928;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43073.Visible = value;
			}
		}

		// Token: 0x17006551 RID: 25937
		// (get) Token: 0x0600C9E2 RID: 51682 RVA: 0x00BC7C54 File Offset: 0x00BC5E54
		// (set) Token: 0x0600C9E3 RID: 51683 RVA: 0x00BC7D0C File Offset: 0x00BC5F0C
		public bool CnvPerRACSingletone_A43073_Editable
		{
			get
			{
				short num = (short)140705792;
				short num2 = num;
				num = (short)1207673109;
				short num3 = num;
				num = (short)1693294869;
				switch (num3 == num)
				{
				}
				num = (short)773783552;
				if (num != 0)
				{
				}
				num = (short)1726742529;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43073.Editable;
			}
			set
			{
				short num = (short)975372288;
				short num2 = num;
				num = (short)402863975;
				short num3 = num;
				num = (short)483473255;
				switch (num3 == num)
				{
				}
				num = (short)1330905088;
				if (num != 0)
				{
				}
				num = (short)2033647617;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43073.Editable = value;
			}
		}

		// Token: 0x17006552 RID: 25938
		// (get) Token: 0x0600C9E4 RID: 51684 RVA: 0x00BC7DC4 File Offset: 0x00BC5FC4
		internal string CnvPerRACSingletone_A43073_UILabel
		{
			get
			{
				short num = (short)216399872;
				short num2 = num;
				num = (short)964054220;
				short num3 = num;
				num = (short)830885068;
				switch (num3 == num)
				{
				}
				num = (short)97976320;
				if (num != 0)
				{
				}
				num = (short)287178753;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43073.UIName;
			}
		}

		// Token: 0x17006553 RID: 25939
		// (get) Token: 0x0600C9E5 RID: 51685 RVA: 0x00BC7E7C File Offset: 0x00BC607C
		// (set) Token: 0x0600C9E6 RID: 51686 RVA: 0x00BC7F30 File Offset: 0x00BC6130
		internal bool CnvPerRACSingletone_A43073_HiddenStatic
		{
			get
			{
				short num = (short)100597760;
				short num2 = num;
				num = (short)585498625;
				if (num != 0)
				{
				}
				num = (short)1405385035;
				short num3 = num;
				num = (short)1895070027;
				switch (num3 == num)
				{
				}
				num = (short)1686962176;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43073.HiddenStatic;
			}
			set
			{
				short num = (short)1775042560;
				short num2 = num;
				num = (short)1618088012;
				short num3 = num;
				num = (short)378146892;
				switch (num3 == num)
				{
				}
				num = (short)1294794753;
				if (num != 0)
				{
				}
				num = (short)122748928;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43073.HiddenStatic = value;
			}
		}

		// Token: 0x17006554 RID: 25940
		// (get) Token: 0x0600C9E7 RID: 51687 RVA: 0x00BC7FE8 File Offset: 0x00BC61E8
		// (set) Token: 0x0600C9E8 RID: 51688 RVA: 0x00BC809C File Offset: 0x00BC629C
		internal bool CnvPerRACSingletone_A43073_HiddenDynamic
		{
			get
			{
				short num = (short)493355008;
				short num2 = num;
				num = (short)814557167;
				short num3 = num;
				num = (short)1386751983;
				switch (num3 == num)
				{
				}
				num = (short)1202323457;
				if (num != 0)
				{
				}
				num = (short)786956288;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43073.HiddenDynamic;
			}
			set
			{
				short num = (short)1262223360;
				short num2 = num;
				num = (short)2106329864;
				short num3 = num;
				num = (short)425462536;
				switch (num3 == num)
				{
				}
				num = (short)631767041;
				if (num != 0)
				{
				}
				num = (short)913244160;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43073.HiddenDynamic = value;
			}
		}

		// Token: 0x17006555 RID: 25941
		// (get) Token: 0x0600C9E9 RID: 51689 RVA: 0x00BC8150 File Offset: 0x00BC6350
		public bool CnvPerRACSingletone_A43073_HasDiffs
		{
			get
			{
				short num = (short)1587871744;
				short num2 = num;
				num = (short)1077709075;
				short num3 = num;
				num = (short)2095810835;
				switch (num3 == num)
				{
				}
				num = (short)1531117569;
				if (num != 0)
				{
				}
				num = (short)354680832;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43073._HasDiffs;
			}
		}

		// Token: 0x17006556 RID: 25942
		// (get) Token: 0x0600C9EA RID: 51690 RVA: 0x00BC8204 File Offset: 0x00BC6404
		// (set) Token: 0x0600C9EB RID: 51691 RVA: 0x00BC82B8 File Offset: 0x00BC64B8
		public int CnvPerRACSingletone_A43072Value
		{
			get
			{
				short num = (short)806813696;
				short num2 = num;
				num = (short)1740242945;
				if (num != 0)
				{
				}
				num = (short)949091626;
				short num3 = num;
				num = (short)1567030570;
				switch (num3 == num)
				{
				}
				num = (short)989986816;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.Value;
			}
			set
			{
				short num = (short)994115584;
				short num2 = num;
				num = (short)572624814;
				short num3 = num;
				num = (short)1207472046;
				switch (num3 == num)
				{
				}
				num = (short)561643521;
				if (num != 0)
				{
				}
				num = (short)1750466560;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.Value = value;
			}
		}

		// Token: 0x17006557 RID: 25943
		// (get) Token: 0x0600C9EC RID: 51692 RVA: 0x00BC8368 File Offset: 0x00BC6568
		// (set) Token: 0x0600C9ED RID: 51693 RVA: 0x00BC841C File Offset: 0x00BC661C
		public string CnvPerRACSingletone_A43072_UIValue
		{
			get
			{
				short num = (short)1607729152;
				short num2 = num;
				num = (short)1515754020;
				short num3 = num;
				num = (short)151753252;
				switch (num3 == num)
				{
				}
				num = (short)1379139585;
				if (num != 0)
				{
				}
				num = (short)1008467968;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.UIValue;
			}
			set
			{
				short num = (short)1604517888;
				short num2 = num;
				num = (short)2127956734;
				short num3 = num;
				num = (short)1782385406;
				switch (num3 == num)
				{
				}
				num = (short)908001281;
				if (num != 0)
				{
				}
				num = (short)2012872704;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.UIValue = value;
			}
		}

		// Token: 0x17006558 RID: 25944
		// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x00BC84D0 File Offset: 0x00BC66D0
		public global::AcpBusinessLayer.AcpRecRefField CnvPerRACSingletone_A43072
		{
			get
			{
				short num = (short)867762176;
				short num2 = num;
				num = (short)1442971584;
				short num3 = num;
				num = (short)138477504;
				switch (num3 == num)
				{
				}
				num = (short)445579265;
				if (num != 0)
				{
				}
				num = (short)1957953536;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072;
			}
		}

		// Token: 0x17006559 RID: 25945
		// (get) Token: 0x0600C9EF RID: 51695 RVA: 0x00BC8580 File Offset: 0x00BC6780
		// (set) Token: 0x0600C9F0 RID: 51696 RVA: 0x00BC8634 File Offset: 0x00BC6834
		public bool CnvPerRACSingletone_A43072_Applicable
		{
			get
			{
				short num = (short)1660813312;
				short num2 = num;
				num = (short)1062010881;
				if (num != 0)
				{
				}
				num = (short)578075128;
				short num3 = num;
				num = (short)2077211128;
				switch (num3 == num)
				{
				}
				num = (short)704249856;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.Applicable;
			}
			set
			{
				short num = (short)1827209216;
				short num2 = num;
				num = (short)726042527;
				short num3 = num;
				num = (short)219056031;
				switch (num3 == num)
				{
				}
				num = (short)1877344257;
				if (num != 0)
				{
				}
				num = (short)596508672;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.Applicable = value;
			}
		}

		// Token: 0x1700655A RID: 25946
		// (get) Token: 0x0600C9F1 RID: 51697 RVA: 0x00BC86EC File Offset: 0x00BC68EC
		// (set) Token: 0x0600C9F2 RID: 51698 RVA: 0x00BC87A0 File Offset: 0x00BC69A0
		public bool CnvPerRACSingletone_A43072_Valid
		{
			get
			{
				short num = (short)1675952128;
				short num2 = num;
				num = (short)1374289921;
				if (num != 0)
				{
				}
				num = (short)1588399874;
				short num3 = num;
				num = (short)1804472066;
				switch (num3 == num)
				{
				}
				num = (short)1280245760;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.Valid;
			}
			set
			{
				short num = (short)485228544;
				short num2 = num;
				num = (short)260708232;
				short num3 = num;
				num = (short)246159240;
				switch (num3 == num)
				{
				}
				num = (short)938475521;
				if (num != 0)
				{
				}
				num = (short)1318977536;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.Valid = value;
			}
		}

		// Token: 0x1700655B RID: 25947
		// (get) Token: 0x0600C9F3 RID: 51699 RVA: 0x00BC8854 File Offset: 0x00BC6A54
		// (set) Token: 0x0600C9F4 RID: 51700 RVA: 0x00BC8908 File Offset: 0x00BC6B08
		public bool CnvPerRACSingletone_A43072_Visible
		{
			get
			{
				short num = (short)1675034624;
				short num2 = num;
				num = (short)1091648647;
				short num3 = num;
				num = (short)1761164423;
				switch (num3 == num)
				{
				}
				num = (short)1934098433;
				if (num != 0)
				{
				}
				num = (short)1069023232;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.Visible;
			}
			set
			{
				short num = (short)895942656;
				short num2 = num;
				num = (short)638241461;
				short num3 = num;
				num = (short)245811893;
				switch (num3 == num)
				{
				}
				num = (short)1802305536;
				if (num != 0)
				{
				}
				num = (short)2100428801;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.Visible = value;
			}
		}

		// Token: 0x1700655C RID: 25948
		// (get) Token: 0x0600C9F5 RID: 51701 RVA: 0x00BC89C0 File Offset: 0x00BC6BC0
		// (set) Token: 0x0600C9F6 RID: 51702 RVA: 0x00BC8A74 File Offset: 0x00BC6C74
		public bool CnvPerRACSingletone_A43072_Editable
		{
			get
			{
				short num = (short)1125908480;
				short num2 = num;
				num = (short)1061662505;
				short num3 = num;
				num = (short)1834987305;
				switch (num3 == num)
				{
				}
				num = (short)18022401;
				if (num != 0)
				{
				}
				num = (short)1271988224;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.Editable;
			}
			set
			{
				short num = (short)10092544;
				short num2 = num;
				num = (short)1575267137;
				short num3 = num;
				num = (short)246590273;
				switch (num3 == num)
				{
				}
				num = (short)1645608960;
				if (num != 0)
				{
				}
				num = (short)316866561;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.Editable = value;
			}
		}

		// Token: 0x1700655D RID: 25949
		// (get) Token: 0x0600C9F7 RID: 51703 RVA: 0x00BC8B2C File Offset: 0x00BC6D2C
		internal string CnvPerRACSingletone_A43072_UILabel
		{
			get
			{
				short num = (short)1614151680;
				short num2 = num;
				num = (short)1090632530;
				short num3 = num;
				num = (short)1652800338;
				switch (num3 == num)
				{
				}
				num = (short)451084289;
				if (num != 0)
				{
				}
				num = (short)930807808;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.UIName;
			}
		}

		// Token: 0x1700655E RID: 25950
		// (get) Token: 0x0600C9F8 RID: 51704 RVA: 0x00BC8BE4 File Offset: 0x00BC6DE4
		// (set) Token: 0x0600C9F9 RID: 51705 RVA: 0x00BC8C98 File Offset: 0x00BC6E98
		internal bool CnvPerRACSingletone_A43072_HiddenStatic
		{
			get
			{
				short num = (short)475791360;
				short num2 = num;
				num = (short)1328004725;
				short num3 = num;
				num = (short)1144897141;
				switch (num3 == num)
				{
				}
				num = (short)1592590336;
				if (num != 0)
				{
				}
				num = (short)40697857;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.HiddenStatic;
			}
			set
			{
				short num = (short)2070085632;
				short num2 = num;
				num = (short)1851681309;
				short num3 = num;
				num = (short)1999596061;
				switch (num3 == num)
				{
				}
				num = (short)1449918465;
				if (num != 0)
				{
				}
				num = (short)457965568;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.HiddenStatic = value;
			}
		}

		// Token: 0x1700655F RID: 25951
		// (get) Token: 0x0600C9FA RID: 51706 RVA: 0x00BC8D4C File Offset: 0x00BC6F4C
		// (set) Token: 0x0600C9FB RID: 51707 RVA: 0x00BC8E00 File Offset: 0x00BC7000
		internal bool CnvPerRACSingletone_A43072_HiddenDynamic
		{
			get
			{
				short num = (short)514260992;
				short num2 = num;
				num = (short)1117328804;
				short num3 = num;
				num = (short)146871716;
				switch (num3 == num)
				{
				}
				num = (short)1454309377;
				if (num != 0)
				{
				}
				num = (short)1103495168;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072.HiddenDynamic;
			}
			set
			{
				short num = (short)887357440;
				short num2 = num;
				num = (short)1521824075;
				short num3 = num;
				num = (short)756625739;
				switch (num3 == num)
				{
				}
				num = (short)1046544385;
				if (num != 0)
				{
				}
				num = (short)1582170112;
				if (num != 0)
				{
				}
				this.cnvPerRACSingletone_A43072.HiddenDynamic = value;
			}
		}

		// Token: 0x17006560 RID: 25952
		// (get) Token: 0x0600C9FC RID: 51708 RVA: 0x00BC8EB4 File Offset: 0x00BC70B4
		public bool CnvPerRACSingletone_A43072_HasDiffs
		{
			get
			{
				short num = (short)390987776;
				short num2 = num;
				num = (short)188546159;
				short num3 = num;
				num = (short)1559624815;
				switch (num3 == num)
				{
				}
				num = (short)1569128449;
				if (num != 0)
				{
				}
				num = (short)1325465600;
				if (num != 0)
				{
				}
				return this.cnvPerRACSingletone_A43072._HasDiffs;
			}
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x00BC8F6C File Offset: 0x00BC716C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				short num = (short)1626406912;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				for (;;)
				{
					IL_33:
					int num3;
					switch (num3)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)720764930;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						num = (short)1117978627;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1598750724;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1685913601;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_4D:
				num = (short)1033306113;
				if (num != 0)
				{
				}
				num = (short)1234669252;
				short num4 = num;
				num = (short)1579912900;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)507379712;
					if (num != 0)
					{
					}
					result = null;
					num = (short)302579712;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}
				}
			}
			return result;
		}

		// Token: 0x040064CA RID: 25802
		private global::AcpBusinessLayer.AcpListField cnvPerRACAccessType_A7388;

		// Token: 0x040064CB RID: 25803
		private global::AcpBusinessLayer.AcpListField cnvPerRACCodeType1_A7680;

		// Token: 0x040064CC RID: 25804
		private global::AcpBusinessLayer.AcpRecRefField cnvPerRACMDCRepeaterID1_A8783;

		// Token: 0x040064CD RID: 25805
		private global::AcpBusinessLayer.AcpRecRefField cnvPerRACMDCRepeaterID2_A8814;

		// Token: 0x040064CE RID: 25806
		private global::AcpBusinessLayer.AcpListField cnvPerRACCodeType2_A8817;

		// Token: 0x040064CF RID: 25807
		private global::AcpBusinessLayer.AcpField<bool> cnvPerRACRepeaterAccess_A8939;

		// Token: 0x040064D0 RID: 25808
		private global::AcpBusinessLayer.AcpRecRefField cnvPerRACToneSignalingSystem_A9392;

		// Token: 0x040064D1 RID: 25809
		private global::AcpBusinessLayer.AcpRecRefField cnvPerRACSingletone_A43073;

		// Token: 0x040064D2 RID: 25810
		private global::AcpBusinessLayer.AcpRecRefField cnvPerRACSingletone_A43072;
	}
}
