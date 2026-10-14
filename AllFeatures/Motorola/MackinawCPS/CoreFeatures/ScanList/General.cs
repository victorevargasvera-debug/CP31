using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x02000119 RID: 281
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002888 RID: 10376 RVA: 0x0027B798 File Offset: 0x00279998
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0027B7B4 File Offset: 0x002799B4
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0027B7CC File Offset: 0x002799CC
		public override void Init()
		{
			int a_ = 5;
			short num = (short)999877622;
			short num2 = num;
			num = (short)460778486;
			switch (num2 == num)
			{
			}
			num = (short)1831731200;
			short num3 = num;
			num = (short)791150593;
			if (num != 0)
			{
			}
			num = (short)548732928;
			if (num != 0)
			{
			}
			this.scanLstGeneralDesignatedDataMember_A7829 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟ꛡ臣闥臧跩苫迭蓯韱郳답駷軹鷻돽旿漁昃挅稇唉䴋㤍⠏‑ⴓ", a_), global::CommonResources.AcgResources.ID_DESIGNATEDDATAMEMBER, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, true);
			this.scanLstGeneralDesignatedDataMember_A7829.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralDesignatedDataMember_A7829.DataTransferOrder = 21;
			this.scanLstGeneralDesignatedVoiceTxMember_A7830 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟ꛡ臣闥臧跩苫迭蓯韱郳ꃵ韷鏹鿻鯽哿稁䤃挅攇栉椋簍伏匑⌓⸕⬗⨙", a_), global::CommonResources.AcgResources.ID_DESIGNATEDVOICETXMEMBER, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, true);
			this.scanLstGeneralDesignatedVoiceTxMember_A7830.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralDesignatedVoiceTxMember_A7830.DataTransferOrder = 20;
			this.scanLstGeneralDynamicPriority_A7915 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟ꛡ鷣裥觧蟩藫跭ꃯ胱鷳駵諷鏹裻蟽忿䌁㌃㼅㤇㼉", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTDYNAMICPRIORITY);
			this.scanLstGeneralDynamicPriority_A7915.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralDynamicPriority_A7915.DataTransferOrder = 8;
			this.scanLstGeneralNonPriorityMembers_A8569 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟곡诣裥룧飩藫臭苯鯱胳迵뗷鿹釻鳽旿瀁眃夅䤇㈉㤋㠍⤏", a_), global::CommonResources.AcgResources.ID_NONPRIORITYMEMBERS, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralNonPriorityMembers_A8569LovStrs);
			this.scanLstGeneralNonPriorityMembers_A8569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralNonPriorityMembers_A8569.DataTransferOrder = 16;
			this.scanLstGeneralPriority1Type_A8745 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟닡難迥蟧飩藫髭觯쏱ꃳ迵裷鿹ꏻ뿽㣿㔁〃㌅", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITY1TYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralPriority1Type_A8745LovStrs);
			this.scanLstGeneralPriority1Type_A8745.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstGeneralPriority1Type_A8745.DataTransferOrder = 10;
			this.scanLstGeneralPriorityMember1_A8747 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟닡難迥蟧飩藫髭觯뿱釳鯵髷鿹軻쿽忿䌁㰃ㄅ㰇㴉", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITYMEMBER1, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.scanLstGeneralPriorityMember1_A8747.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralPriorityMember1_A8747.DataTransferOrder = 12;
			this.scanLstGeneralPriority2Type_A8748 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟닡難迥蟧飩藫髭觯샱ꃳ迵裷鿹ꏻ뿽㣿㔁〃㸅", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITY2TYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralPriority2Type_A8748LovStrs);
			this.scanLstGeneralPriority2Type_A8748.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstGeneralPriority2Type_A8748.DataTransferOrder = 11;
			this.scanLstGeneralPriorityMember2_A8749 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟닡難迥蟧飩藫髭觯뿱釳鯵髷鿹軻쳽忿䌁㰃ㄅ㰇㌉", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITYMEMBER2, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.scanLstGeneralPriorityMember2_A8749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralPriorityMember2_A8749.DataTransferOrder = 13;
			this.scanLstGeneralRecord_A8921 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟냡臣藥蟧飩裫뇭뇯쫱췳쓵짷", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMRECORD, null, null, true, false);
			this.scanLstGeneralRecord_A8921.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstGeneralRecord_A8921.DataTransferOrder = 9;
			this.scanLstGeneralRecord_A8921.EvaluateRecRefs = true;
			this.scanLstGeneralScanType_A9058 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.indexScanLstGeneralScanType_A9058LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.idScanLstGeneralScanType_A9058LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟뇡蟣蟥蛧뻩闫黭闯귱뗳쿵죷쿹쓻", a_), global::CommonResources.AcgResources.ID_SCANTYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralScanType_A9058LovStrs);
			this.scanLstGeneralScanType_A9058.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstGeneralScanType_A9058.DataTransferOrder = 1;
			this.scanLstGeneralScanType_A9058.EvaluateRecRefs = true;
			this.scanLstGeneralType_A9578 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟뛡鷣雥跧뗩귫ퟭ엯엱쳳", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMTYPE, string.Empty);
			this.scanLstGeneralType_A9578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstGeneralType_A9578.DataTransferOrder = -1;
			this.scanLstGeneralKeyofScanList_A12668 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟ꧡ臣鿥蟧賩뿫跭釯鳱룳鿵请軹ꏻ뿽ㇿ、㈃々〇", a_), global::CommonResources.AcgResources.ID_SCANLISTALIAS, 14);
			this.scanLstGeneralKeyofScanList_A12668.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstGeneralKeyofScanList_A12668.DataTransferOrder = 14;
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.indexScanLstGeneralDesignatedVoiceTxMemberType_A21524LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.idScanLstGeneralDesignatedVoiceTxMemberType_A21524LovStrs), this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟ꛡ臣闥臧跩苫迭蓯韱郳ꃵ韷鏹鿻鯽哿稁䤃挅攇栉椋簍䐏欑搓猕䜗嬙⸛⼝ᔟအဣ", a_), global::CommonResources.AcgResources.ID_DESIGNATEDVOICETXMEMBERTYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralDesignatedVoiceTxMemberType_A21524LovStrs);
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.DataTransferOrder = 5;
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.EvaluateRecRefs = true;
			this.scanLstGeneralDesignatedDataTxRxType_A21525 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ鏓돕뛗뿙껛뿝賟ꛡ臣闥臧跩苫迭蓯韱郳답駷軹鷻꫽磿倁簃刅焇稉椋儍儏‑┓⌕⨗⼙", a_), global::CommonResources.AcgResources.ID_DESIGNATEDDATARXTXTYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralDesignatedDataTxRxType_A21525LovStrs);
			this.scanLstGeneralDesignatedDataTxRxType_A21525.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanLstGeneralDesignatedDataTxRxType_A21525.DataTransferOrder = 3;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10131;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0027BC88 File Offset: 0x00279E88
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1896611851;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6C2;
				case 1:
					goto IL_503;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛諝駟鋡臣맥ꧧ폩\ud9eb\ud9ed죯", a_)))
					{
						num = (short)792395818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C2;
				case 3:
				{
					num = (short)1115128134;
					short num3 = num;
					num = (short)214466886;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3CF;
					default:
						num = (short)1250099200;
						if (num != 0)
						{
						}
						num = (short)426180639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫\udcedꓯ诱蓳鏵ꟷ믹쓻짽㓿㨁", a_)))
					{
						num = (short)833486883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39F;
				case 5:
					this.scanLstGeneralDesignatedVoiceTxMemberType_A21524 = new global::AcpBusinessLayer.AcpSparseLOVField(3, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.indexScanLstGeneralDesignatedVoiceTxMemberType_A21524LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.idScanLstGeneralDesignatedVoiceTxMemberType_A21524LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯ꓱ鯳鿵鯷鿹ꣻ蛽䷿朁椃搅洇砉堋眍怏眑䬓圕⨗⬙⤛Ⱍᐟ", a_), global::CommonResources.AcgResources.ID_DESIGNATEDVOICETXMEMBERTYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralDesignatedVoiceTxMemberType_A21524LovStrs);
					this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.DataTransferOrder = 5;
					this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.EvaluateRecRefs = true;
					num = (short)111804432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.scanLstGeneralKeyofScanList_A12668 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛闝藟鯡诣胥믧觩跫胭볯鯱蟳苵ꟷ믹췻쳽㛿㐁㰃", a_), global::CommonResources.AcgResources.ID_SCANLISTALIAS, 14);
					this.scanLstGeneralKeyofScanList_A12668.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstGeneralKeyofScanList_A12668.DataTransferOrder = 14;
					num = (short)1606615060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_2DF;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛賝藟臡诣铥賧뗩귫훭짯샱엳", a_)))
					{
						num = (short)2053439527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DF;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫ꏭ闯鿱雳鏵諷죹ꏻ뿽㣿㔁〃㼅", a_)))
					{
						goto IL_3CF;
					}
					goto IL_820;
				case 10:
					this.scanLstGeneralDynamicPriority_A7915 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝駟賡藣该臧觩볫鳭駯鷱蛳鿵賷菹ꏻ뿽㟿㬁㔃㌅", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTDYNAMICPRIORITY);
					this.scanLstGeneralDynamicPriority_A7915.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralDynamicPriority_A7915.DataTransferOrder = 8;
					num = (short)126943261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_E5;
					}
					continue;
				case 12:
					goto IL_710;
				case 13:
					goto IL_820;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫ꏭ闯鿱雳鏵諷쯹ꏻ뿽㣿㔁〃ㄅ", a_)))
					{
						num = (short)1684406295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98C;
				case 15:
					goto IL_98C;
				case 16:
					goto IL_ACA;
				case 17:
					this.scanLstGeneralPriority1Type_A8745 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫\udfedꓯ诱蓳鏵ꟷ믹쓻짽㓿㜁", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITY1TYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralPriority1Type_A8745LovStrs);
					this.scanLstGeneralPriority1Type_A8745.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstGeneralPriority1Type_A8745.DataTransferOrder = 10;
					num = (short)1830092828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛距菟菡諣닥釧髩觫뇭뇯쯱쓳쏵샷", a_)))
					{
						num = (short)1845231659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_710;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫\udfedꓯ诱蓳鏵ꟷ믹쓻짽㓿㜁", a_)))
					{
						num = (short)1485766673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_508;
				case 20:
					goto IL_438;
				case 21:
					if (producerFields != null)
					{
						num = (short)1259601923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B7B;
				case 22:
					this.scanLstGeneralNonPriorityMembers_A8569 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛郝迟賡듣铥臧藩黫蟭蓯诱맳鏵闷飹駻賽珿崁䔃㸅㴇㰉㔋", a_), global::CommonResources.AcgResources.ID_NONPRIORITYMEMBERS, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralNonPriorityMembers_A8569LovStrs);
					this.scanLstGeneralNonPriorityMembers_A8569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralNonPriorityMembers_A8569.DataTransferOrder = 16;
					num = (short)897450010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					this.scanLstGeneralPriorityMember1_A8747 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫ꏭ闯鿱雳鏵諷쯹ꏻ뿽㣿㔁〃ㄅ", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITYMEMBER1, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.scanLstGeneralPriorityMember1_A8747.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralPriorityMember1_A8747.DataTransferOrder = 12;
					num = (short)936640527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.scanLstGeneralDesignatedDataMember_A7829 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯뛱闳苵駷럹駻鏽拿朁瘃夅䤇㴉㐋㰍⤏", a_), global::CommonResources.AcgResources.ID_DESIGNATEDDATAMEMBER, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, true);
					this.scanLstGeneralDesignatedDataMember_A7829.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralDesignatedDataMember_A7829.DataTransferOrder = 21;
					num = (short)1146748964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛郝迟賡듣铥臧藩黫蟭蓯诱맳鏵闷飹駻賽珿崁䔃㸅㴇㰉㔋", a_)))
					{
						num = (short)728891414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_674;
				case 26:
					goto IL_674;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛闝藟鯡诣胥믧觩跫胭볯鯱蟳苵ꟷ믹췻쳽㛿㐁㰃", a_)))
					{
						num = (short)1294925830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_438;
				case 28:
					goto IL_508;
				case 29:
					goto IL_3EB;
				case 30:
					this.scanLstGeneralDesignatedVoiceTxMember_A7830 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯ꓱ鯳鿵鯷鿹ꣻ蛽䷿朁椃搅洇砉匋伍✏⨑✓☕", a_), global::CommonResources.AcgResources.ID_DESIGNATEDVOICETXMEMBER, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, true);
					this.scanLstGeneralDesignatedVoiceTxMember_A7830.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralDesignatedVoiceTxMember_A7830.DataTransferOrder = 20;
					num = (short)528220192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯뛱闳苵駷럹駻鏽拿朁瘃夅䤇㴉㐋㰍⤏", a_)))
					{
						num = (short)1217331224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 32:
					goto IL_1EC;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝駟賡藣该臧觩볫鳭駯鷱蛳鿵賷菹ꏻ뿽㟿㬁㔃㌅", a_)))
					{
						num = (short)2087583754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EB;
				case 34:
					num = (short)2043215893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					this.scanLstGeneralPriority2Type_A8748 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫\udcedꓯ诱蓳鏵ꟷ믹쓻짽㓿㨁", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITY2TYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralPriority2Type_A8748LovStrs);
					this.scanLstGeneralPriority2Type_A8748.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstGeneralPriority2Type_A8748.DataTransferOrder = 11;
					num = (short)414384166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_291;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯ꓱ鯳鿵鯷鿹ꣻ蛽䷿朁椃搅洇砉堋眍怏眑䬓圕⨗⬙⤛Ⱍᐟ", a_)))
					{
						num = (short)1935212549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ACA;
				case 38:
					goto IL_39F;
				case 39:
					this.scanLstGeneralRecord_A8921 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛賝藟臡诣铥賧뗩귫훭짯샱엳", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMRECORD, null, null, true, false);
					this.scanLstGeneralRecord_A8921.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstGeneralRecord_A8921.DataTransferOrder = 9;
					this.scanLstGeneralRecord_A8921.EvaluateRecRefs = true;
					num = (short)1861287943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
				{
					this.scanLstGeneralDesignatedDataTxRxType_A21525 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯뛱闳苵駷껹蓻곽磿嘁紃瘅洇唉䴋㰍ℏ✑☓⌕", a_), global::CommonResources.AcgResources.ID_DESIGNATEDDATARXTXTYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralDesignatedDataTxRxType_A21525LovStrs);
					this.scanLstGeneralDesignatedDataTxRxType_A21525.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralDesignatedDataTxRxType_A21525.DataTransferOrder = 3;
					num = (short)148242432;
					short num4 = num;
					num = (short)1102774273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯뛱闳苵駷껹蓻곽磿嘁紃瘅洇唉䴋㰍ℏ✑☓⌕", a_)))
					{
						num = (short)944898088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B7B;
				case 42:
					this.scanLstGeneralType_A9578 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛諝駟鋡臣맥ꧧ폩\ud9eb\ud9ed죯", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMTYPE, string.Empty);
					this.scanLstGeneralType_A9578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstGeneralType_A9578.DataTransferOrder = -1;
					num = (short)1450639360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					this.scanLstGeneralScanType_A9058 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.indexScanLstGeneralScanType_A9058LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.idScanLstGeneralScanType_A9058LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛距菟菡諣닥釧髩觫뇭뇯쯱쓳쏵샷", a_), global::CommonResources.AcgResources.ID_SCANTYPE, global::Motorola.MackinawCPS.CoreFeatures.ScanList.LOVs.ScanLstGeneralScanType_A9058LovStrs);
					this.scanLstGeneralScanType_A9058.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstGeneralScanType_A9058.DataTransferOrder = 1;
					this.scanLstGeneralScanType_A9058.EvaluateRecRefs = true;
					num = (short)711131148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					this.scanLstGeneralPriorityMember2_A8749 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛軝鋟诡诣铥臧黩闫ꏭ闯鿱雳鏵諷죹ꏻ뿽㣿㔁〃㼅", a_), global::CommonResources.AcgResources.ID_PRIORITYASSIGNMENTPRIORITYMEMBER2, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.scanLstGeneralPriorityMember2_A8749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanLstGeneralPriorityMember2_A8749.DataTransferOrder = 13;
					num = (short)1376845837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁ꟃꟅꛇ蛉뿋뫍韏럑뫓돕꫗믙냛髝藟釡跣臥蛧诩飫语铯ꓱ鯳鿵鯷鿹ꣻ蛽䷿朁椃搅洇砉匋伍✏⨑✓☕", a_)))
					{
						num = (short)2089091102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EC;
				}
				IL_E5:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1459159074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1EC:
				num = (short)1663828001;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_291:
				num = (short)1570963501;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DF:
				num = (short)921436178;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39F:
				num = (short)2081095689;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CF:
				num = (short)171114540;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EB:
				num = (short)670498841;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_438:
				num = (short)1049428005;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_508:
				num = (short)1515323393;
				if (num != 0)
				{
				}
				num = (short)2052325390;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_674:
				num = (short)307757075;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C2:
				num = (short)844038171;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_710:
				num = (short)809500674;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_820:
				num = (short)524156936;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_98C:
				num = (short)1352794116;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ACA:
				num = (short)1271857193;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_503:
			IL_B7B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藁ꇃꣅ귇룉귋ꋍ", a_);
			base.Id = 10131;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0027C844 File Offset: 0x0027AA44
		public override void PopulateReferences()
		{
			short num = (short)201588737;
			if (num != 0)
			{
			}
			num = (short)1426041150;
			short num2 = num;
			num = (short)785623358;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1971650560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1152516096;
			if (num != 0)
			{
			}
			this.scanLstGeneralDesignatedDataMember_A7829.SetRecset(base.Parent[10132].EmbeddedRecset);
			this.scanLstGeneralDesignatedVoiceTxMember_A7830.SetRecset(base.Parent[10132].EmbeddedRecset);
			this.scanLstGeneralPriorityMember1_A8747.SetRecset(base.Parent[10132].EmbeddedRecset);
			this.scanLstGeneralPriorityMember2_A8749.SetRecset(base.Parent[10132].EmbeddedRecset);
			this.scanLstGeneralRecord_A8921.SetRecset(this.a(2064));
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0027C984 File Offset: 0x0027AB84
		public override void DropReferences()
		{
			short num = (short)2006253198;
			short num2 = num;
			num = (short)258408078;
			switch (num2 == num)
			{
			}
			num = (short)337313792;
			short num3 = num;
			num = (short)1398800385;
			if (num != 0)
			{
			}
			num = (short)1730609152;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0027CA2C File Offset: 0x0027AC2C
		public override void SetConstraints()
		{
			short num = (short)1100152833;
			if (num != 0)
			{
			}
			num = (short)1337253934;
			short num2 = num;
			num = (short)1201201198;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1515520000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1302200320;
			if (num != 0)
			{
			}
			this.scanLstGeneralDesignatedDataMember_A7829.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanTypeIsCnvAndDesignatedDataTxRxTypeIsFixed);
			this.scanLstGeneralDesignatedDataMember_A7829.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanDesignatedDataMbrRecRefValid);
			this.scanLstGeneralDesignatedVoiceTxMember_A7830.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanTypeIsNotVotingScanOrTxSteeringIsDisAndDsgnTxMbrType);
			this.scanLstGeneralDesignatedVoiceTxMember_A7830.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanDesignatedTxMbrRecRefValid);
			this.scanLstGeneralDynamicPriority_A7915.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsCnv);
			this.scanLstGeneralNonPriorityMembers_A8569.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsNotVotingScan);
			this.scanLstGeneralPriority1Type_A8745.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsConventionalOrPriorityMonitor);
			this.scanLstGeneralPriority1Type_A8745.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsPriorityOneAndTwoValidforPriorityOne);
			this.scanLstGeneralPriorityMember1_A8747.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConPrtyOneTypeIsOperatorSelectOrFixedAndScanLstTypeIsCnvOrPriMon);
			this.scanLstGeneralPriorityMember1_A8747.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanPriority1MbrRecRefValid);
			this.scanLstGeneralPriority2Type_A8748.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsCnvAndDynPrtyEnIsDisOrScanLstTypeIsPriorityMonitor);
			this.scanLstGeneralPriority2Type_A8748.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsPriorityOneAndTwoValidforPriorityTwo);
			this.scanLstGeneralPriorityMember2_A8749.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConPrtyTwoTypeIsOpertSelOrFixedAndScanTypeIsCnvAndDynPrtyEnIsDisOrScanTypeIsPriorMon);
			this.scanLstGeneralPriorityMember2_A8749.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanPriority2MbrRecRefValid);
			this.scanLstGeneralRecord_A8921.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanTypePriorityMonitor);
			this.scanLstGeneralScanType_A9058.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanTypeSetMaxChannels);
			this.scanLstGeneralType_A9578.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanTypePriorityMonitor);
			this.scanLstGeneralType_A9578.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.conLookupTrkSysTypeForScanLst);
			this.scanLstGeneralType_A9578.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanTypeIsNotVotingScanOrTxSteeringIsDis);
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsPriorityMonitorScanValid);
			this.scanLstGeneralDesignatedDataTxRxType_A21525.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanLstTypeIsCnv);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0027CCD0 File Offset: 0x0027AED0
		public override void SetupDependencies()
		{
			short num = (short)568534414;
			short num2 = num;
			num = (short)51258766;
			switch (num2 == num)
			{
			}
			num = (short)1668284416;
			short num3 = num;
			num = (short)1414594560;
			if (num != 0)
			{
			}
			num = (short)2103508993;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.scanLstGeneralDesignatedDataTxRxType_A21525.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefConventionalWide.ASTROOTAC.CnvWideASTROOTACOTACRFeature_A8662.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefConventionalWide.ASTROOTAC.CnvWideASTROOTACOTACSFeature_A8667.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.scanLstGeneralDesignatedDataMember_A7829);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralDesignatedVoiceTxMember_A7830);
			scanList.Advanced.ScanLstAdvancedTxSteering_A9572.AddDependentObject(this.scanLstGeneralDesignatedVoiceTxMember_A7830);
			this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.AddDependentObject(this.scanLstGeneralDesignatedVoiceTxMember_A7830);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralDynamicPriority_A7915);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralNonPriorityMembers_A8569);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralPriority1Type_A8745);
			this.scanLstGeneralPriority2Type_A8748.AddDependentObject(this.scanLstGeneralPriority1Type_A8745);
			this.scanLstGeneralDynamicPriority_A7915.AddDependentObject(this.scanLstGeneralPriority1Type_A8745);
			this.scanLstGeneralPriority1Type_A8745.AddDependentObject(this.scanLstGeneralPriorityMember1_A8747);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralPriorityMember1_A8747);
			this.scanLstGeneralPriorityMember2_A8749.AddDependentObject(this.scanLstGeneralPriorityMember1_A8747);
			this.scanLstGeneralPriority2Type_A8748.AddDependentObject(this.scanLstGeneralPriorityMember1_A8747);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralPriority2Type_A8748);
			this.scanLstGeneralDynamicPriority_A7915.AddDependentObject(this.scanLstGeneralPriority2Type_A8748);
			this.scanLstGeneralPriority1Type_A8745.AddDependentObject(this.scanLstGeneralPriority2Type_A8748);
			this.scanLstGeneralDynamicPriority_A7915.AddDependentObject(this.scanLstGeneralPriorityMember2_A8749);
			this.scanLstGeneralPriority2Type_A8748.AddDependentObject(this.scanLstGeneralPriorityMember2_A8749);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralPriorityMember2_A8749);
			this.scanLstGeneralPriorityMember1_A8747.AddDependentObject(this.scanLstGeneralPriorityMember2_A8749);
			this.scanLstGeneralPriority1Type_A8745.AddDependentObject(this.scanLstGeneralPriorityMember2_A8749);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralRecord_A8921);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralType_A9578);
			this.scanLstGeneralRecord_A8921.AddDependentObject(this.scanLstGeneralType_A9578);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralDesignatedVoiceTxMemberType_A21524);
			scanList.Advanced.ScanLstAdvancedTxSteering_A9572.AddDependentObject(this.scanLstGeneralDesignatedVoiceTxMemberType_A21524);
			this.scanLstGeneralScanType_A9058.AddDependentObject(this.scanLstGeneralDesignatedDataTxRxType_A21525);
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0027D04C File Offset: 0x0027B24C
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner ScanListInnerSectionForScanLstGeneralDesignatedDataMember_A7829
		{
			get
			{
				short num = (short)2074477326;
				short num2 = num;
				num = (short)293536526;
				switch (num2 == num)
				{
				}
				num = (short)951844864;
				short num3 = num;
				num = (short)98369537;
				if (num != 0)
				{
				}
				num = (short)131203072;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataMember_A7829.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x0027D104 File Offset: 0x0027B304
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner ScanListInnerSectionForScanLstGeneralDesignatedVoiceTxMember_A7830
		{
			get
			{
				short num = (short)536674305;
				if (num != 0)
				{
				}
				num = (short)1326342548;
				short num2 = num;
				num = (short)770793876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277952000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)520290304;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0027D1BC File Offset: 0x0027B3BC
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner ScanListInnerSectionForScanLstGeneralPriorityMember1_A8747
		{
			get
			{
				short num = (short)1257685026;
				short num2 = num;
				num = (short)148488226;
				switch (num2 == num)
				{
				}
				num = (short)390856704;
				short num3 = num;
				num = (short)1676214273;
				if (num != 0)
				{
				}
				num = (short)1696399360;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x0027D274 File Offset: 0x0027B474
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner ScanListInnerSectionForScanLstGeneralPriorityMember2_A8749
		{
			get
			{
				short num = (short)1865232120;
				short num2 = num;
				num = (short)1563766520;
				switch (num2 == num)
				{
				}
				num = (short)331022336;
				short num3 = num;
				num = (short)1808662528;
				if (num != 0)
				{
				}
				num = (short)2141716481;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x0027D32C File Offset: 0x0027B52C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem TrunkingSystemForScanLstGeneralRecord_A8921
		{
			get
			{
				short num = (short)317258347;
				short num2 = num;
				num = (short)1438906987;
				switch (num2 == num)
				{
				}
				num = (short)1051066368;
				short num3 = num;
				num = (short)1575616513;
				if (num != 0)
				{
				}
				num = (short)448921600;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x0027D3E4 File Offset: 0x0027B5E4
		public bool HasDiffs
		{
			get
			{
				short num = (short)2079030568;
				short num2 = num;
				num = (short)2097642792;
				switch (num2 == num)
				{
				}
				num = (short)1101529088;
				short num3 = num;
				num = (short)647757825;
				if (num != 0)
				{
				}
				num = (short)907870208;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x0027D494 File Offset: 0x0027B694
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0027D548 File Offset: 0x0027B748
		public int ScanLstGeneralDesignatedDataMember_A7829Value
		{
			get
			{
				short num = (short)1017205580;
				short num2 = num;
				num = (short)1394889548;
				switch (num2 == num)
				{
				}
				num = (short)954204160;
				short num3 = num;
				num = (short)1619918849;
				if (num != 0)
				{
				}
				num = (short)289603584;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataMember_A7829.Value;
			}
			set
			{
				short num = (short)1475856260;
				short num2 = num;
				num = (short)458868612;
				switch (num2 == num)
				{
				}
				num = (short)1091567616;
				short num3 = num;
				num = (short)428670977;
				if (num != 0)
				{
				}
				num = (short)1935474688;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataMember_A7829.Value = value;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x0027D600 File Offset: 0x0027B800
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0027D6B4 File Offset: 0x0027B8B4
		public string ScanLstGeneralDesignatedDataMember_A7829_UIValue
		{
			get
			{
				short num = (short)71565313;
				if (num != 0)
				{
				}
				num = (short)829649192;
				short num2 = num;
				num = (short)1536258344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1001652224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)346882048;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataMember_A7829.UIValue;
			}
			set
			{
				short num = (short)1663031197;
				short num2 = num;
				num = (short)2114443165;
				switch (num2 == num)
				{
				}
				num = (short)1709768705;
				if (num != 0)
				{
				}
				num = (short)1556086784;
				if (num != 0)
				{
				}
				num = (short)1377173504;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.UIValue = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x0027D768 File Offset: 0x0027B968
		public global::AcpBusinessLayer.AcpRecRefField ScanLstGeneralDesignatedDataMember_A7829
		{
			get
			{
				short num = (short)1547880448;
				short num2 = num;
				num = (short)15124480;
				switch (num2 == num)
				{
				}
				num = (short)1263403008;
				if (num != 0)
				{
				}
				num = (short)1663303681;
				if (num != 0)
				{
				}
				num = (short)1116078080;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x0027D814 File Offset: 0x0027BA14
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x0027D8C8 File Offset: 0x0027BAC8
		public bool ScanLstGeneralDesignatedDataMember_A7829_Applicable
		{
			get
			{
				short num = (short)286579568;
				short num2 = num;
				num = (short)1600052080;
				switch (num2 == num)
				{
				}
				num = (short)1463222273;
				if (num != 0)
				{
				}
				num = (short)1240334336;
				if (num != 0)
				{
				}
				num = (short)2078932992;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.Applicable;
			}
			set
			{
				short num = (short)1287782401;
				if (num != 0)
				{
				}
				num = (short)1775900615;
				short num2 = num;
				num = (short)1981880263;
				switch (num2 == num)
				{
				}
				num = (short)2065760256;
				if (num != 0)
				{
				}
				num = (short)227409920;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.Applicable = value;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x0027D980 File Offset: 0x0027BB80
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x0027DA30 File Offset: 0x0027BC30
		public bool ScanLstGeneralDesignatedDataMember_A7829_Valid
		{
			get
			{
				short num = (short)1976500225;
				if (num != 0)
				{
				}
				num = (short)1721627616;
				short num2 = num;
				num = (short)1881666528;
				switch (num2 == num)
				{
				}
				num = (short)958005248;
				if (num != 0)
				{
				}
				num = (short)423165952;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.Valid;
			}
			set
			{
				short num = (short)1967672593;
				short num2 = num;
				num = (short)1764773137;
				switch (num2 == num)
				{
				}
				num = (short)2052390912;
				if (num != 0)
				{
				}
				num = (short)69533697;
				if (num != 0)
				{
				}
				num = (short)938737664;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.Valid = value;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0027DAE8 File Offset: 0x0027BCE8
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x0027DB9C File Offset: 0x0027BD9C
		public bool ScanLstGeneralDesignatedDataMember_A7829_Visible
		{
			get
			{
				short num = (short)531660193;
				short num2 = num;
				num = (short)858619297;
				switch (num2 == num)
				{
				}
				num = (short)550502401;
				if (num != 0)
				{
				}
				num = (short)1306918912;
				if (num != 0)
				{
				}
				num = (short)1659830272;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.Visible;
			}
			set
			{
				short num = (short)1381672195;
				short num2 = num;
				num = (short)57255171;
				switch (num2 == num)
				{
				}
				num = (short)1644036096;
				if (num != 0)
				{
				}
				num = (short)36110337;
				if (num != 0)
				{
				}
				num = (short)2133327872;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.Visible = value;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x0027DC50 File Offset: 0x0027BE50
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x0027DD04 File Offset: 0x0027BF04
		public bool ScanLstGeneralDesignatedDataMember_A7829_Editable
		{
			get
			{
				short num = (short)1479997568;
				short num2 = num;
				num = (short)678819968;
				switch (num2 == num)
				{
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				num = (short)897712129;
				if (num != 0)
				{
				}
				num = (short)1055391744;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.Editable;
			}
			set
			{
				short num = (short)789403560;
				short num2 = num;
				num = (short)863983528;
				switch (num2 == num)
				{
				}
				num = (short)887029761;
				if (num != 0)
				{
				}
				num = (short)1921974272;
				if (num != 0)
				{
				}
				num = (short)638844928;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.Editable = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0027DDB8 File Offset: 0x0027BFB8
		internal string ScanLstGeneralDesignatedDataMember_A7829_UILabel
		{
			get
			{
				short num = (short)846109113;
				short num2 = num;
				num = (short)660052409;
				switch (num2 == num)
				{
				}
				num = (short)1855389697;
				if (num != 0)
				{
				}
				num = (short)748486656;
				if (num != 0)
				{
				}
				num = (short)1487142912;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.UIName;
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0027DE6C File Offset: 0x0027C06C
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x0027DF24 File Offset: 0x0027C124
		internal bool ScanLstGeneralDesignatedDataMember_A7829_HiddenStatic
		{
			get
			{
				short num = (short)2083804557;
				short num2 = num;
				num = (short)951342477;
				switch (num2 == num)
				{
				}
				num = (short)1661403137;
				if (num != 0)
				{
				}
				num = (short)1561133056;
				if (num != 0)
				{
				}
				num = (short)108199936;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.HiddenStatic;
			}
			set
			{
				short num = (short)1470445842;
				short num2 = num;
				num = (short)1730820370;
				switch (num2 == num)
				{
				}
				num = (short)1014038529;
				if (num != 0)
				{
				}
				num = (short)841416704;
				if (num != 0)
				{
				}
				num = (short)544473088;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.HiddenStatic = value;
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x0027DFD8 File Offset: 0x0027C1D8
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x0027E08C File Offset: 0x0027C28C
		internal bool ScanLstGeneralDesignatedDataMember_A7829_HiddenDynamic
		{
			get
			{
				short num = (short)397503486;
				short num2 = num;
				num = (short)855796734;
				switch (num2 == num)
				{
				}
				num = (short)1578172416;
				if (num != 0)
				{
				}
				num = (short)1237057537;
				if (num != 0)
				{
				}
				num = (short)574226432;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829.HiddenDynamic;
			}
			set
			{
				short num = (short)199976712;
				short num2 = num;
				num = (short)1819043592;
				switch (num2 == num)
				{
				}
				num = (short)335347713;
				if (num != 0)
				{
				}
				num = (short)718929920;
				if (num != 0)
				{
				}
				num = (short)1708195840;
				short num3 = num;
				this.scanLstGeneralDesignatedDataMember_A7829.HiddenDynamic = value;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0027E144 File Offset: 0x0027C344
		public bool ScanLstGeneralDesignatedDataMember_A7829_HasDiffs
		{
			get
			{
				short num = (short)536883107;
				short num2 = num;
				num = (short)1301491619;
				switch (num2 == num)
				{
				}
				num = (short)924254208;
				if (num != 0)
				{
				}
				num = (short)1672609793;
				if (num != 0)
				{
				}
				num = (short)1531707392;
				short num3 = num;
				return this.scanLstGeneralDesignatedDataMember_A7829._HasDiffs;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x0027E1F8 File Offset: 0x0027C3F8
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x0027E2AC File Offset: 0x0027C4AC
		public int ScanLstGeneralDesignatedVoiceTxMember_A7830Value
		{
			get
			{
				short num = (short)670073111;
				short num2 = num;
				num = (short)1688437015;
				switch (num2 == num)
				{
				}
				num = (short)741801985;
				if (num != 0)
				{
				}
				num = (short)874119168;
				if (num != 0)
				{
				}
				num = (short)1690632192;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.Value;
			}
			set
			{
				short num = (short)175626331;
				short num2 = num;
				num = (short)1233442907;
				switch (num2 == num)
				{
				}
				num = (short)661061632;
				if (num != 0)
				{
				}
				num = (short)1150681089;
				if (num != 0)
				{
				}
				num = (short)507576320;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.Value = value;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0027E360 File Offset: 0x0027C560
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x0027E414 File Offset: 0x0027C614
		public string ScanLstGeneralDesignatedVoiceTxMember_A7830_UIValue
		{
			get
			{
				short num = (short)748502704;
				short num2 = num;
				num = (short)1722433200;
				switch (num2 == num)
				{
				}
				num = (short)872611841;
				if (num != 0)
				{
				}
				num = (short)258473984;
				if (num != 0)
				{
				}
				num = (short)1152909312;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.UIValue;
			}
			set
			{
				short num = (short)432116075;
				short num2 = num;
				num = (short)2136183147;
				switch (num2 == num)
				{
				}
				num = (short)1098711041;
				if (num != 0)
				{
				}
				num = (short)1725890560;
				if (num != 0)
				{
				}
				num = (short)1902706688;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.UIValue = value;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0027E4C8 File Offset: 0x0027C6C8
		public global::AcpBusinessLayer.AcpRecRefField ScanLstGeneralDesignatedVoiceTxMember_A7830
		{
			get
			{
				short num = (short)1284834450;
				short num2 = num;
				num = (short)1906967698;
				switch (num2 == num)
				{
				}
				num = (short)1592852480;
				if (num != 0)
				{
				}
				num = (short)233701377;
				if (num != 0)
				{
				}
				num = (short)1777860608;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x0027E578 File Offset: 0x0027C778
		// (set) Token: 0x060028AF RID: 10415 RVA: 0x0027E62C File Offset: 0x0027C82C
		public bool ScanLstGeneralDesignatedVoiceTxMember_A7830_Applicable
		{
			get
			{
				short num = (short)1844289736;
				short num2 = num;
				num = (short)1549050056;
				switch (num2 == num)
				{
				}
				num = (short)1162543105;
				if (num != 0)
				{
				}
				num = (short)341901312;
				if (num != 0)
				{
				}
				num = (short)181075968;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.Applicable;
			}
			set
			{
				short num = (short)2073377520;
				short num2 = num;
				num = (short)1486633712;
				switch (num2 == num)
				{
				}
				num = (short)40042497;
				if (num != 0)
				{
				}
				num = (short)203620352;
				if (num != 0)
				{
				}
				num = (short)570687488;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.Applicable = value;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x0027E6E0 File Offset: 0x0027C8E0
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0027E794 File Offset: 0x0027C994
		public bool ScanLstGeneralDesignatedVoiceTxMember_A7830_Valid
		{
			get
			{
				short num = (short)1442699992;
				short num2 = num;
				num = (short)1421466328;
				switch (num2 == num)
				{
				}
				num = (short)1961099265;
				if (num != 0)
				{
				}
				num = (short)1760821248;
				if (num != 0)
				{
				}
				num = (short)1954086912;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.Valid;
			}
			set
			{
				short num = (short)1932457316;
				short num2 = num;
				num = (short)587265380;
				switch (num2 == num)
				{
				}
				num = (short)49938432;
				if (num != 0)
				{
				}
				num = (short)285016065;
				if (num != 0)
				{
				}
				num = (short)1150091264;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.Valid = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x0027E84C File Offset: 0x0027CA4C
		// (set) Token: 0x060028B3 RID: 10419 RVA: 0x0027E900 File Offset: 0x0027CB00
		public bool ScanLstGeneralDesignatedVoiceTxMember_A7830_Visible
		{
			get
			{
				short num = (short)624452053;
				short num2 = num;
				num = (short)2011259349;
				switch (num2 == num)
				{
				}
				num = (short)872873984;
				if (num != 0)
				{
				}
				num = (short)558497793;
				if (num != 0)
				{
				}
				num = (short)1769013248;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.Visible;
			}
			set
			{
				short num = (short)1483191756;
				short num2 = num;
				num = (short)249804236;
				switch (num2 == num)
				{
				}
				num = (short)181927937;
				if (num != 0)
				{
				}
				num = (short)1716781056;
				if (num != 0)
				{
				}
				num = (short)1182793728;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.Visible = value;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x0027E9B8 File Offset: 0x0027CBB8
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x0027EA70 File Offset: 0x0027CC70
		public bool ScanLstGeneralDesignatedVoiceTxMember_A7830_Editable
		{
			get
			{
				short num = (short)1339366960;
				short num2 = num;
				num = (short)1418141232;
				switch (num2 == num)
				{
				}
				num = (short)1178664961;
				if (num != 0)
				{
				}
				num = (short)1707016192;
				if (num != 0)
				{
				}
				num = (short)1973420032;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.Editable;
			}
			set
			{
				short num = (short)258808046;
				short num2 = num;
				num = (short)167057646;
				switch (num2 == num)
				{
				}
				num = (short)101449729;
				if (num != 0)
				{
				}
				num = (short)419430400;
				if (num != 0)
				{
				}
				num = (short)2033975296;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.Editable = value;
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x0027EB24 File Offset: 0x0027CD24
		internal string ScanLstGeneralDesignatedVoiceTxMember_A7830_UILabel
		{
			get
			{
				short num = (short)2046623745;
				if (num != 0)
				{
				}
				num = (short)1583508800;
				short num2 = num;
				num = (short)1095920960;
				switch (num2 == num)
				{
				}
				num = (short)893976576;
				if (num != 0)
				{
				}
				num = (short)311623680;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.UIName;
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0027EBD8 File Offset: 0x0027CDD8
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x0027EC90 File Offset: 0x0027CE90
		internal bool ScanLstGeneralDesignatedVoiceTxMember_A7830_HiddenStatic
		{
			get
			{
				short num = (short)942886526;
				short num2 = num;
				num = (short)1711099518;
				switch (num2 == num)
				{
				}
				num = (short)1526071297;
				if (num != 0)
				{
				}
				num = (short)1825701888;
				if (num != 0)
				{
				}
				num = (short)834994176;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.HiddenStatic;
			}
			set
			{
				short num = (short)1213976106;
				short num2 = num;
				num = (short)1298189866;
				switch (num2 == num)
				{
				}
				num = (short)586219521;
				if (num != 0)
				{
				}
				num = (short)552992768;
				if (num != 0)
				{
				}
				num = (short)503054336;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.HiddenStatic = value;
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0027ED48 File Offset: 0x0027CF48
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x0027EE00 File Offset: 0x0027D000
		internal bool ScanLstGeneralDesignatedVoiceTxMember_A7830_HiddenDynamic
		{
			get
			{
				short num = (short)1398123911;
				short num2 = num;
				num = (short)808168839;
				switch (num2 == num)
				{
				}
				num = (short)246677505;
				if (num != 0)
				{
				}
				num = (short)499122176;
				if (num != 0)
				{
				}
				num = (short)103677952;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830.HiddenDynamic;
			}
			set
			{
				short num = (short)716846785;
				short num2 = num;
				num = (short)1210922689;
				switch (num2 == num)
				{
				}
				num = (short)1440219137;
				if (num != 0)
				{
				}
				num = (short)1458700288;
				if (num != 0)
				{
				}
				num = (short)1729691648;
				short num3 = num;
				this.scanLstGeneralDesignatedVoiceTxMember_A7830.HiddenDynamic = value;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x0027EEB8 File Offset: 0x0027D0B8
		public bool ScanLstGeneralDesignatedVoiceTxMember_A7830_HasDiffs
		{
			get
			{
				short num = (short)1712039084;
				short num2 = num;
				num = (short)213165228;
				switch (num2 == num)
				{
				}
				num = (short)2106654721;
				if (num != 0)
				{
				}
				num = (short)1200095232;
				if (num != 0)
				{
				}
				num = (short)276168704;
				short num3 = num;
				return this.scanLstGeneralDesignatedVoiceTxMember_A7830._HasDiffs;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0027EF6C File Offset: 0x0027D16C
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x0027F020 File Offset: 0x0027D220
		public bool ScanLstGeneralDynamicPriority_A7915Value
		{
			get
			{
				short num = (short)223739905;
				if (num != 0)
				{
				}
				num = (short)1333935634;
				short num2 = num;
				num = (short)1115373074;
				switch (num2 == num)
				{
				}
				num = (short)1605042176;
				if (num != 0)
				{
				}
				num = (short)487063552;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.Value;
			}
			set
			{
				short num = (short)975472711;
				short num2 = num;
				num = (short)429230151;
				switch (num2 == num)
				{
				}
				num = (short)1571749889;
				if (num != 0)
				{
				}
				num = (short)2076704768;
				if (num != 0)
				{
				}
				num = (short)1539375104;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.Value = value;
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x0027F0D8 File Offset: 0x0027D2D8
		public global::AcpBusinessLayer.AcpField<bool> ScanLstGeneralDynamicPriority_A7915
		{
			get
			{
				short num = (short)877777099;
				short num2 = num;
				num = (short)763482315;
				switch (num2 == num)
				{
				}
				num = (short)1640824833;
				if (num != 0)
				{
				}
				num = (short)1266876416;
				if (num != 0)
				{
				}
				num = (short)1399128064;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x0027F188 File Offset: 0x0027D388
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x0027F23C File Offset: 0x0027D43C
		public bool ScanLstGeneralDynamicPriority_A7915_UIValue
		{
			get
			{
				short num = (short)100375958;
				short num2 = num;
				num = (short)19307926;
				switch (num2 == num)
				{
				}
				num = (short)2144403457;
				if (num != 0)
				{
				}
				num = (short)511180800;
				if (num != 0)
				{
				}
				num = (short)397082624;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.Value;
			}
			set
			{
				short num = (short)381443878;
				short num2 = num;
				num = (short)538402598;
				switch (num2 == num)
				{
				}
				num = (short)1000996865;
				if (num != 0)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				num = (short)12517376;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.Value = value;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0027F2F4 File Offset: 0x0027D4F4
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x0027F3A8 File Offset: 0x0027D5A8
		public bool ScanLstGeneralDynamicPriority_A7915_Applicable
		{
			get
			{
				short num = (short)578289665;
				if (num != 0)
				{
				}
				num = (short)1745382996;
				short num2 = num;
				num = (short)1785032276;
				switch (num2 == num)
				{
				}
				num = (short)506986496;
				if (num != 0)
				{
				}
				num = (short)1137770496;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.Applicable;
			}
			set
			{
				short num = (short)434101314;
				short num2 = num;
				num = (short)1683938370;
				switch (num2 == num)
				{
				}
				num = (short)1735196673;
				if (num != 0)
				{
				}
				num = (short)1092747264;
				if (num != 0)
				{
				}
				num = (short)1800470528;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.Applicable = value;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x0027F45C File Offset: 0x0027D65C
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x0027F510 File Offset: 0x0027D710
		public bool ScanLstGeneralDynamicPriority_A7915_Valid
		{
			get
			{
				short num = (short)729723069;
				short num2 = num;
				num = (short)122794173;
				switch (num2 == num)
				{
				}
				num = (short)1366753281;
				if (num != 0)
				{
				}
				num = (short)1731592192;
				if (num != 0)
				{
				}
				num = (short)968622080;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.Valid;
			}
			set
			{
				short num = (short)567191269;
				short num2 = num;
				num = (short)1910023909;
				switch (num2 == num)
				{
				}
				num = (short)277348352;
				if (num != 0)
				{
				}
				num = (short)177864705;
				if (num != 0)
				{
				}
				num = (short)245956608;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.Valid = value;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0027F5C4 File Offset: 0x0027D7C4
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0027F678 File Offset: 0x0027D878
		public bool ScanLstGeneralDynamicPriority_A7915_Visible
		{
			get
			{
				short num = (short)298993268;
				short num2 = num;
				num = (short)1808418420;
				switch (num2 == num)
				{
				}
				num = (short)2018050048;
				if (num != 0)
				{
				}
				num = (short)173342721;
				if (num != 0)
				{
				}
				num = (short)906297344;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.Visible;
			}
			set
			{
				short num = (short)1413533697;
				short num2 = num;
				num = (short)257282049;
				switch (num2 == num)
				{
				}
				num = (short)1372454913;
				if (num != 0)
				{
				}
				num = (short)154533888;
				if (num != 0)
				{
				}
				num = (short)1880883200;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.Visible = value;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0027F730 File Offset: 0x0027D930
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x0027F7E4 File Offset: 0x0027D9E4
		public bool ScanLstGeneralDynamicPriority_A7915_Editable
		{
			get
			{
				short num = (short)1154599419;
				short num2 = num;
				num = (short)124373499;
				switch (num2 == num)
				{
				}
				num = (short)1397489665;
				if (num != 0)
				{
				}
				num = (short)607453184;
				if (num != 0)
				{
				}
				num = (short)366870528;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.Editable;
			}
			set
			{
				short num = (short)766375318;
				short num2 = num;
				num = (short)2052584854;
				switch (num2 == num)
				{
				}
				num = (short)1598029825;
				if (num != 0)
				{
				}
				num = (short)955514880;
				if (num != 0)
				{
				}
				num = (short)1702100992;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.Editable = value;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0027F898 File Offset: 0x0027DA98
		internal string ScanLstGeneralDynamicPriority_A7915_UILabel
		{
			get
			{
				short num = (short)1728076057;
				short num2 = num;
				num = (short)795433241;
				switch (num2 == num)
				{
				}
				num = (short)1122172929;
				if (num != 0)
				{
				}
				num = (short)816644096;
				if (num != 0)
				{
				}
				num = (short)192479232;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.UIName;
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0027F94C File Offset: 0x0027DB4C
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x0027FA04 File Offset: 0x0027DC04
		internal bool ScanLstGeneralDynamicPriority_A7915_HiddenStatic
		{
			get
			{
				short num = (short)345702401;
				if (num != 0)
				{
				}
				num = (short)779091797;
				short num2 = num;
				num = (short)1600323413;
				switch (num2 == num)
				{
				}
				num = (short)1504247808;
				if (num != 0)
				{
				}
				num = (short)1253703680;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.HiddenStatic;
			}
			set
			{
				short num = (short)736590163;
				short num2 = num;
				num = (short)1866627411;
				switch (num2 == num)
				{
				}
				num = (short)221773824;
				if (num != 0)
				{
				}
				num = (short)142999553;
				if (num != 0)
				{
				}
				num = (short)281935872;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.HiddenStatic = value;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x0027FABC File Offset: 0x0027DCBC
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x0027FB70 File Offset: 0x0027DD70
		internal bool ScanLstGeneralDynamicPriority_A7915_HiddenDynamic
		{
			get
			{
				short num = (short)701801676;
				short num2 = num;
				num = (short)1994368204;
				switch (num2 == num)
				{
				}
				num = (short)796196865;
				if (num != 0)
				{
				}
				num = (short)815136768;
				if (num != 0)
				{
				}
				num = (short)1370554368;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915.HiddenDynamic;
			}
			set
			{
				short num = (short)1076761755;
				short num2 = num;
				num = (short)1312232603;
				switch (num2 == num)
				{
				}
				num = (short)1326579713;
				if (num != 0)
				{
				}
				num = (short)1461846016;
				if (num != 0)
				{
				}
				num = (short)968097792;
				short num3 = num;
				this.scanLstGeneralDynamicPriority_A7915.HiddenDynamic = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x0027FC28 File Offset: 0x0027DE28
		public bool ScanLstGeneralDynamicPriority_A7915_HasDiffs
		{
			get
			{
				short num = (short)1383872025;
				short num2 = num;
				num = (short)1020343833;
				switch (num2 == num)
				{
				}
				num = (short)1927086080;
				if (num != 0)
				{
				}
				num = (short)2075918337;
				if (num != 0)
				{
				}
				num = (short)966197248;
				short num3 = num;
				return this.scanLstGeneralDynamicPriority_A7915._HasDiffs;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x0027FCDC File Offset: 0x0027DEDC
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x0027FD90 File Offset: 0x0027DF90
		public int ScanLstGeneralNonPriorityMembers_A8569Value
		{
			get
			{
				short num = (short)285961365;
				short num2 = num;
				num = (short)654208149;
				switch (num2 == num)
				{
				}
				num = (short)2128084993;
				if (num != 0)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				num = (short)347209728;
				short num3 = num;
				return this.scanLstGeneralNonPriorityMembers_A8569.Value;
			}
			set
			{
				short num = (short)644036309;
				short num2 = num;
				num = (short)571815637;
				switch (num2 == num)
				{
				}
				num = (short)219742208;
				if (num != 0)
				{
				}
				num = (short)1910702081;
				if (num != 0)
				{
				}
				num = (short)872939520;
				short num3 = num;
				this.scanLstGeneralNonPriorityMembers_A8569.Value = value;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x0027FE48 File Offset: 0x0027E048
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x0027FEFC File Offset: 0x0027E0FC
		public string ScanLstGeneralNonPriorityMembers_A8569_UIValue
		{
			get
			{
				short num = (short)1154649359;
				short num2 = num;
				num = (short)1693486351;
				switch (num2 == num)
				{
				}
				num = (short)338952193;
				if (num != 0)
				{
				}
				num = (short)723058688;
				if (num != 0)
				{
				}
				num = (short)1065615360;
				short num3 = num;
				return this.scanLstGeneralNonPriorityMembers_A8569.UIValue;
			}
			set
			{
				short num = (short)1990066328;
				short num2 = num;
				num = (short)1538785432;
				switch (num2 == num)
				{
				}
				num = (short)540803073;
				if (num != 0)
				{
				}
				num = (short)1900085248;
				short num3 = num;
				num = (short)906887168;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.UIValue = value;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x0027FFB0 File Offset: 0x0027E1B0
		public global::AcpBusinessLayer.AcpListField ScanLstGeneralNonPriorityMembers_A8569
		{
			get
			{
				short num = (short)1520369665;
				if (num != 0)
				{
				}
				num = (short)1554784867;
				short num2 = num;
				num = (short)597041763;
				switch (num2 == num)
				{
				}
				num = (short)684523520;
				short num3 = num;
				num = (short)26542080;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x00280060 File Offset: 0x0027E260
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x00280110 File Offset: 0x0027E310
		public bool ScanLstGeneralNonPriorityMembers_A8569_Applicable
		{
			get
			{
				short num = (short)292721162;
				short num2 = num;
				num = (short)836211210;
				switch (num2 == num)
				{
				}
				num = (short)277020673;
				if (num != 0)
				{
				}
				num = (short)644153344;
				short num3 = num;
				num = (short)330104832;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.Applicable;
			}
			set
			{
				short num = (short)146511684;
				short num2 = num;
				num = (short)1846056772;
				switch (num2 == num)
				{
				}
				num = (short)1602748417;
				if (num != 0)
				{
				}
				num = (short)478674944;
				short num3 = num;
				num = (short)928645120;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.Applicable = value;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x002801C8 File Offset: 0x0027E3C8
		// (set) Token: 0x060028D7 RID: 10455 RVA: 0x0028027C File Offset: 0x0027E47C
		public bool ScanLstGeneralNonPriorityMembers_A8569_Valid
		{
			get
			{
				short num = (short)833904497;
				short num2 = num;
				num = (short)1362452337;
				switch (num2 == num)
				{
				}
				num = (short)626786304;
				if (num != 0)
				{
				}
				num = (short)1737031680;
				short num3 = num;
				num = (short)1246298113;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.Valid;
			}
			set
			{
				short num = (short)26184725;
				short num2 = num;
				num = (short)1967426581;
				switch (num2 == num)
				{
				}
				num = (short)1015218176;
				if (num != 0)
				{
				}
				num = (short)228982784;
				short num3 = num;
				num = (short)933756929;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.Valid = value;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x00280330 File Offset: 0x0027E530
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x002803E8 File Offset: 0x0027E5E8
		public bool ScanLstGeneralNonPriorityMembers_A8569_Visible
		{
			get
			{
				short num = (short)192383808;
				short num2 = num;
				num = (short)1714785088;
				switch (num2 == num)
				{
				}
				num = (short)1352597505;
				if (num != 0)
				{
				}
				num = (short)242024448;
				short num3 = num;
				num = (short)1106771968;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.Visible;
			}
			set
			{
				short num = (short)400296234;
				short num2 = num;
				num = (short)1958414634;
				switch (num2 == num)
				{
				}
				num = (short)775028737;
				if (num != 0)
				{
				}
				num = (short)446038016;
				short num3 = num;
				num = (short)190906368;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.Visible = value;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x0028049C File Offset: 0x0027E69C
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x00280550 File Offset: 0x0027E750
		public bool ScanLstGeneralNonPriorityMembers_A8569_Editable
		{
			get
			{
				short num = (short)1748238337;
				if (num != 0)
				{
				}
				num = (short)649710479;
				short num2 = num;
				num = (short)1115081615;
				switch (num2 == num)
				{
				}
				num = (short)828571648;
				short num3 = num;
				num = (short)601358336;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.Editable;
			}
			set
			{
				short num = (short)725811201;
				if (num != 0)
				{
				}
				num = (short)108963846;
				short num2 = num;
				num = (short)426027014;
				switch (num2 == num)
				{
				}
				num = (short)638451712;
				short num3 = num;
				num = (short)1750597632;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.Editable = value;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x00280608 File Offset: 0x0027E808
		internal string ScanLstGeneralNonPriorityMembers_A8569_UILabel
		{
			get
			{
				short num = (short)2013659729;
				short num2 = num;
				num = (short)598737489;
				switch (num2 == num)
				{
				}
				num = (short)955056128;
				if (num != 0)
				{
				}
				num = (short)4194304;
				short num3 = num;
				num = (short)1279524865;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.UIName;
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x002806C0 File Offset: 0x0027E8C0
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x00280774 File Offset: 0x0027E974
		internal bool ScanLstGeneralNonPriorityMembers_A8569_HiddenStatic
		{
			get
			{
				short num = (short)1526267905;
				if (num != 0)
				{
				}
				num = (short)1576257361;
				short num2 = num;
				num = (short)818267985;
				switch (num2 == num)
				{
				}
				num = (short)1750859776;
				short num3 = num;
				num = (short)1490092032;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.HiddenStatic;
			}
			set
			{
				short num = (short)487205110;
				short num2 = num;
				num = (short)1252010230;
				switch (num2 == num)
				{
				}
				num = (short)431423489;
				if (num != 0)
				{
				}
				num = (short)1305149440;
				short num3 = num;
				num = (short)356777984;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.HiddenStatic = value;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x00280828 File Offset: 0x0027EA28
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x002808DC File Offset: 0x0027EADC
		internal bool ScanLstGeneralNonPriorityMembers_A8569_HiddenDynamic
		{
			get
			{
				short num = (short)1336125275;
				short num2 = num;
				num = (short)1947182939;
				switch (num2 == num)
				{
				}
				num = (short)259719169;
				if (num != 0)
				{
				}
				num = (short)1750859776;
				short num3 = num;
				num = (short)1175846912;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569.HiddenDynamic;
			}
			set
			{
				short num = (short)826388556;
				short num2 = num;
				num = (short)1680650316;
				switch (num2 == num)
				{
				}
				num = (short)1856831489;
				if (num != 0)
				{
				}
				num = (short)856752128;
				short num3 = num;
				num = (short)276824064;
				if (num != 0)
				{
				}
				this.scanLstGeneralNonPriorityMembers_A8569.HiddenDynamic = value;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x00280994 File Offset: 0x0027EB94
		public bool ScanLstGeneralNonPriorityMembers_A8569_HasDiffs
		{
			get
			{
				short num = (short)642857669;
				short num2 = num;
				num = (short)159398597;
				switch (num2 == num)
				{
				}
				num = (short)1858076672;
				if (num != 0)
				{
				}
				num = (short)2065170432;
				short num3 = num;
				num = (short)617021441;
				if (num != 0)
				{
				}
				return this.scanLstGeneralNonPriorityMembers_A8569._HasDiffs;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x00280A4C File Offset: 0x0027EC4C
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x00280B04 File Offset: 0x0027ED04
		public int ScanLstGeneralPriority1Type_A8745Value
		{
			get
			{
				short num = (short)261152650;
				short num2 = num;
				num = (short)1007607690;
				switch (num2 == num)
				{
				}
				num = (short)450297856;
				if (num != 0)
				{
				}
				num = (short)2109210624;
				short num3 = num;
				num = (short)815333377;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.Value;
			}
			set
			{
				short num = (short)1906058006;
				short num2 = num;
				num = (short)463217430;
				switch (num2 == num)
				{
				}
				num = (short)1039335425;
				if (num != 0)
				{
				}
				num = (short)1134362624;
				short num3 = num;
				num = (short)1294467072;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.Value = value;
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x00280BBC File Offset: 0x0027EDBC
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x00280C74 File Offset: 0x0027EE74
		public string ScanLstGeneralPriority1Type_A8745_UIValue
		{
			get
			{
				short num = (short)1124018255;
				short num2 = num;
				num = (short)1686775887;
				switch (num2 == num)
				{
				}
				num = (short)183304193;
				if (num != 0)
				{
				}
				num = (short)1009451008;
				short num3 = num;
				num = (short)1656094720;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.UIValue;
			}
			set
			{
				short num = (short)684322826;
				short num2 = num;
				num = (short)794161162;
				switch (num2 == num)
				{
				}
				num = (short)1410334721;
				if (num != 0)
				{
				}
				num = (short)2033975296;
				short num3 = num;
				num = (short)1459814400;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.UIValue = value;
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x00280D28 File Offset: 0x0027EF28
		public global::AcpBusinessLayer.AcpListField ScanLstGeneralPriority1Type_A8745
		{
			get
			{
				short num = (short)1175360523;
				short num2 = num;
				num = (short)1119785995;
				switch (num2 == num)
				{
				}
				num = (short)1550974977;
				if (num != 0)
				{
				}
				num = (short)1969094656;
				short num3 = num;
				num = (short)1445330944;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x00280DD8 File Offset: 0x0027EFD8
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x00280E8C File Offset: 0x0027F08C
		public bool ScanLstGeneralPriority1Type_A8745_Applicable
		{
			get
			{
				short num = (short)1299289188;
				short num2 = num;
				num = (short)210932836;
				switch (num2 == num)
				{
				}
				num = (short)651427841;
				if (num != 0)
				{
				}
				num = (short)262537216;
				short num3 = num;
				num = (short)1727594496;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.Applicable;
			}
			set
			{
				short num = (short)847455587;
				short num2 = num;
				num = (short)182986083;
				switch (num2 == num)
				{
				}
				num = (short)885194752;
				if (num != 0)
				{
				}
				num = (short)825032704;
				short num3 = num;
				num = (short)285605889;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.Applicable = value;
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x00280F40 File Offset: 0x0027F140
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x00280FF4 File Offset: 0x0027F1F4
		public bool ScanLstGeneralPriority1Type_A8745_Valid
		{
			get
			{
				short num = (short)1766561753;
				short num2 = num;
				num = (short)101357529;
				switch (num2 == num)
				{
				}
				num = (short)878968833;
				if (num != 0)
				{
				}
				num = (short)1966669824;
				short num3 = num;
				num = (short)1919680512;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.Valid;
			}
			set
			{
				short num = (short)291291190;
				short num2 = num;
				num = (short)1533198390;
				switch (num2 == num)
				{
				}
				num = (short)392101889;
				if (num != 0)
				{
				}
				num = (short)831193088;
				short num3 = num;
				num = (short)1048313856;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.Valid = value;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x002810A8 File Offset: 0x0027F2A8
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x00281160 File Offset: 0x0027F360
		public bool ScanLstGeneralPriority1Type_A8745_Visible
		{
			get
			{
				short num = (short)376423702;
				short num2 = num;
				num = (short)1365820694;
				switch (num2 == num)
				{
				}
				num = (short)959643649;
				if (num != 0)
				{
				}
				num = (short)1381040128;
				short num3 = num;
				num = (short)953942016;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.Visible;
			}
			set
			{
				short num = (short)1845893529;
				short num2 = num;
				num = (short)1482168729;
				switch (num2 == num)
				{
				}
				num = (short)219348993;
				if (num != 0)
				{
				}
				num = (short)797638656;
				short num3 = num;
				num = (short)473759744;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.Visible = value;
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x00281218 File Offset: 0x0027F418
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x002812CC File Offset: 0x0027F4CC
		public bool ScanLstGeneralPriority1Type_A8745_Editable
		{
			get
			{
				short num = (short)250934252;
				short num2 = num;
				num = (short)819459052;
				switch (num2 == num)
				{
				}
				num = (short)2029453313;
				if (num != 0)
				{
				}
				num = (short)1775697920;
				short num3 = num;
				num = (short)2055208960;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.Editable;
			}
			set
			{
				short num = (short)1544923569;
				short num2 = num;
				num = (short)1501538737;
				switch (num2 == num)
				{
				}
				num = (short)100073473;
				if (num != 0)
				{
				}
				num = (short)829095936;
				short num3 = num;
				num = (short)881131520;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.Editable = value;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00281380 File Offset: 0x0027F580
		internal string ScanLstGeneralPriority1Type_A8745_UILabel
		{
			get
			{
				short num = (short)2014230926;
				short num2 = num;
				num = (short)1622522254;
				switch (num2 == num)
				{
				}
				num = (short)16384000;
				if (num != 0)
				{
				}
				num = (short)1554972672;
				short num3 = num;
				num = (short)168886273;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.UIName;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x00281434 File Offset: 0x0027F634
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x002814E8 File Offset: 0x0027F6E8
		internal bool ScanLstGeneralPriority1Type_A8745_HiddenStatic
		{
			get
			{
				short num = (short)1277327213;
				short num2 = num;
				num = (short)193689453;
				switch (num2 == num)
				{
				}
				num = (short)871628801;
				if (num != 0)
				{
				}
				num = (short)1362690048;
				short num3 = num;
				num = (short)1708654592;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.HiddenStatic;
			}
			set
			{
				short num = (short)373082667;
				short num2 = num;
				num = (short)1628752427;
				switch (num2 == num)
				{
				}
				num = (short)683933696;
				if (num != 0)
				{
				}
				num = (short)455933952;
				short num3 = num;
				num = (short)1728839681;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.HiddenStatic = value;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x0028159C File Offset: 0x0027F79C
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x00281650 File Offset: 0x0027F850
		internal bool ScanLstGeneralPriority1Type_A8745_HiddenDynamic
		{
			get
			{
				short num = (short)1456696791;
				short num2 = num;
				num = (short)165047767;
				switch (num2 == num)
				{
				}
				num = (short)375783425;
				if (num != 0)
				{
				}
				num = (short)1332805632;
				short num3 = num;
				num = (short)342097920;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745.HiddenDynamic;
			}
			set
			{
				short num = (short)1150595330;
				short num2 = num;
				num = (short)325431554;
				switch (num2 == num)
				{
				}
				num = (short)1938030593;
				if (num != 0)
				{
				}
				num = (short)1040646144;
				short num3 = num;
				num = (short)1873543168;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority1Type_A8745.HiddenDynamic = value;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x00281708 File Offset: 0x0027F908
		public bool ScanLstGeneralPriority1Type_A8745_HasDiffs
		{
			get
			{
				short num = (short)1625851823;
				short num2 = num;
				num = (short)1528596399;
				switch (num2 == num)
				{
				}
				num = (short)914292736;
				if (num != 0)
				{
				}
				num = (short)1815740416;
				short num3 = num;
				num = (short)40370177;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority1Type_A8745._HasDiffs;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x002817BC File Offset: 0x0027F9BC
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x00281870 File Offset: 0x0027FA70
		public int ScanLstGeneralPriorityMember1_A8747Value
		{
			get
			{
				short num = (short)138063463;
				short num2 = num;
				num = (short)663662183;
				switch (num2 == num)
				{
				}
				num = (short)1680474113;
				if (num != 0)
				{
				}
				num = (short)772538368;
				short num3 = num;
				num = (short)901251072;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.Value;
			}
			set
			{
				short num = (short)539951105;
				if (num != 0)
				{
				}
				num = (short)1612188555;
				short num2 = num;
				num = (short)1347619723;
				switch (num2 == num)
				{
				}
				num = (short)1708261376;
				short num3 = num;
				num = (short)379584512;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.Value = value;
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x00281928 File Offset: 0x0027FB28
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x002819DC File Offset: 0x0027FBDC
		public string ScanLstGeneralPriorityMember1_A8747_UIValue
		{
			get
			{
				short num = (short)1022347233;
				short num2 = num;
				num = (short)1588512737;
				switch (num2 == num)
				{
				}
				num = (short)1229455361;
				if (num != 0)
				{
				}
				num = (short)1224278016;
				short num3 = num;
				num = (short)617152512;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.UIValue;
			}
			set
			{
				short num = (short)1380716258;
				short num2 = num;
				num = (short)59248354;
				switch (num2 == num)
				{
				}
				num = (short)1698234369;
				if (num != 0)
				{
				}
				num = (short)983629824;
				short num3 = num;
				num = (short)1324220416;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.UIValue = value;
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x00281A94 File Offset: 0x0027FC94
		public global::AcpBusinessLayer.AcpRecRefField ScanLstGeneralPriorityMember1_A8747
		{
			get
			{
				short num = (short)1691504685;
				short num2 = num;
				num = (short)959795245;
				switch (num2 == num)
				{
				}
				num = (short)1137770496;
				if (num != 0)
				{
				}
				num = (short)1179713536;
				short num3 = num;
				num = (short)1308098561;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747;
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x00281B44 File Offset: 0x0027FD44
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x00281BF8 File Offset: 0x0027FDF8
		public bool ScanLstGeneralPriorityMember1_A8747_Applicable
		{
			get
			{
				short num = (short)1520444797;
				short num2 = num;
				num = (short)1482433917;
				switch (num2 == num)
				{
				}
				num = (short)1821769729;
				if (num != 0)
				{
				}
				num = (short)1870856192;
				short num3 = num;
				num = (short)636551168;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.Applicable;
			}
			set
			{
				short num = (short)300129722;
				short num2 = num;
				num = (short)657563066;
				switch (num2 == num)
				{
				}
				num = (short)1509031937;
				if (num != 0)
				{
				}
				num = (short)716570624;
				short num3 = num;
				num = (short)122159104;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.Applicable = value;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x00281CAC File Offset: 0x0027FEAC
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x00281D60 File Offset: 0x0027FF60
		public bool ScanLstGeneralPriorityMember1_A8747_Valid
		{
			get
			{
				short num = (short)525040356;
				short num2 = num;
				num = (short)1138850532;
				switch (num2 == num)
				{
				}
				num = (short)1258291200;
				if (num != 0)
				{
				}
				num = (short)1507459072;
				short num3 = num;
				num = (short)920190977;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.Valid;
			}
			set
			{
				short num = (short)1887502337;
				if (num != 0)
				{
				}
				num = (short)279324666;
				short num2 = num;
				num = (short)1012017146;
				switch (num2 == num)
				{
				}
				num = (short)303169536;
				short num3 = num;
				num = (short)1339424768;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.Valid = value;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x00281E18 File Offset: 0x00280018
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x00281ECC File Offset: 0x002800CC
		public bool ScanLstGeneralPriorityMember1_A8747_Visible
		{
			get
			{
				short num = (short)1658439594;
				short num2 = num;
				num = (short)591972266;
				switch (num2 == num)
				{
				}
				num = (short)2108882945;
				if (num != 0)
				{
				}
				num = (short)69468160;
				short num3 = num;
				num = (short)1120600064;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.Visible;
			}
			set
			{
				short num = (short)1441136641;
				if (num != 0)
				{
				}
				num = (short)923086405;
				short num2 = num;
				num = (short)1299721797;
				switch (num2 == num)
				{
				}
				num = (short)1676607488;
				short num3 = num;
				num = (short)787546112;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.Visible = value;
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x00281F84 File Offset: 0x00280184
		// (set) Token: 0x06002901 RID: 10497 RVA: 0x00282038 File Offset: 0x00280238
		public bool ScanLstGeneralPriorityMember1_A8747_Editable
		{
			get
			{
				short num = (short)1651060771;
				short num2 = num;
				num = (short)1743794211;
				switch (num2 == num)
				{
				}
				num = (short)312410112;
				if (num != 0)
				{
				}
				num = (short)2036137984;
				short num3 = num;
				num = (short)284557313;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.Editable;
			}
			set
			{
				short num = (short)249714681;
				short num2 = num;
				num = (short)2113230841;
				switch (num2 == num)
				{
				}
				num = (short)2048983041;
				if (num != 0)
				{
				}
				num = (short)58589184;
				short num3 = num;
				num = (short)266272768;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.Editable = value;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x002820EC File Offset: 0x002802EC
		internal string ScanLstGeneralPriorityMember1_A8747_UILabel
		{
			get
			{
				short num = (short)1024444679;
				short num2 = num;
				num = (short)1134676231;
				switch (num2 == num)
				{
				}
				num = (short)1806041089;
				if (num != 0)
				{
				}
				num = (short)20709376;
				short num3 = num;
				num = (short)1386807296;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.UIName;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x002821A0 File Offset: 0x002803A0
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x00282254 File Offset: 0x00280454
		internal bool ScanLstGeneralPriorityMember1_A8747_HiddenStatic
		{
			get
			{
				short num = (short)1676700167;
				short num2 = num;
				num = (short)184445447;
				switch (num2 == num)
				{
				}
				num = (short)1104281600;
				if (num != 0)
				{
				}
				num = (short)1474428928;
				short num3 = num;
				num = (short)1266745345;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.HiddenStatic;
			}
			set
			{
				short num = (short)1370961169;
				short num2 = num;
				num = (short)751252753;
				switch (num2 == num)
				{
				}
				num = (short)522059777;
				if (num != 0)
				{
				}
				num = (short)625213440;
				short num3 = num;
				num = (short)839516160;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.HiddenStatic = value;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x00282308 File Offset: 0x00280508
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x002823BC File Offset: 0x002805BC
		internal bool ScanLstGeneralPriorityMember1_A8747_HiddenDynamic
		{
			get
			{
				short num = (short)389354242;
				short num2 = num;
				num = (short)676664066;
				switch (num2 == num)
				{
				}
				num = (short)1263206401;
				if (num != 0)
				{
				}
				num = (short)1193082880;
				short num3 = num;
				num = (short)1111359488;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747.HiddenDynamic;
			}
			set
			{
				short num = (short)271974401;
				if (num != 0)
				{
				}
				num = (short)730022981;
				short num2 = num;
				num = (short)1918846021;
				switch (num2 == num)
				{
				}
				num = (short)1586495488;
				short num3 = num;
				num = (short)997916672;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember1_A8747.HiddenDynamic = value;
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x00282474 File Offset: 0x00280674
		public bool ScanLstGeneralPriorityMember1_A8747_HasDiffs
		{
			get
			{
				short num = (short)1681016522;
				short num2 = num;
				num = (short)2092648138;
				switch (num2 == num)
				{
				}
				num = (short)1051656193;
				if (num != 0)
				{
				}
				num = (short)730136576;
				short num3 = num;
				num = (short)641400832;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember1_A8747._HasDiffs;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x00282528 File Offset: 0x00280728
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x002825E0 File Offset: 0x002807E0
		public int ScanLstGeneralPriority2Type_A8748Value
		{
			get
			{
				short num = (short)1846607873;
				if (num != 0)
				{
				}
				num = (short)305395972;
				short num2 = num;
				num = (short)1483471108;
				switch (num2 == num)
				{
				}
				num = (short)1738211328;
				short num3 = num;
				num = (short)666238976;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.Value;
			}
			set
			{
				short num = (short)33357825;
				if (num != 0)
				{
				}
				num = (short)1764715571;
				short num2 = num;
				num = (short)820538419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043150336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694892032;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.Value = value;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x00282694 File Offset: 0x00280894
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x00282748 File Offset: 0x00280948
		public string ScanLstGeneralPriority2Type_A8748_UIValue
		{
			get
			{
				short num = (short)95550720;
				short num2 = num;
				num = (short)933362944;
				switch (num2 == num)
				{
				}
				num = (short)1707606016;
				short num3 = num;
				num = (short)664600577;
				if (num != 0)
				{
				}
				num = (short)1443692544;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.UIValue;
			}
			set
			{
				short num = (short)1082456625;
				short num2 = num;
				num = (short)1518533169;
				switch (num2 == num)
				{
				}
				num = (short)1033175040;
				short num3 = num;
				num = (short)1585315841;
				if (num != 0)
				{
				}
				num = (short)1090650112;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.UIValue = value;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x002827FC File Offset: 0x002809FC
		public global::AcpBusinessLayer.AcpListField ScanLstGeneralPriority2Type_A8748
		{
			get
			{
				short num = (short)1726283777;
				if (num != 0)
				{
				}
				num = (short)131979022;
				short num2 = num;
				num = (short)789174030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277165568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1628438528;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x002828AC File Offset: 0x00280AAC
		// (set) Token: 0x0600290E RID: 10510 RVA: 0x00282960 File Offset: 0x00280B60
		public bool ScanLstGeneralPriority2Type_A8748_Applicable
		{
			get
			{
				short num = (short)109288027;
				short num2 = num;
				num = (short)2080152155;
				switch (num2 == num)
				{
				}
				num = (short)2060779520;
				short num3 = num;
				num = (short)1561985025;
				if (num != 0)
				{
				}
				num = (short)1192624128;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.Applicable;
			}
			set
			{
				short num = (short)1174041211;
				short num2 = num;
				num = (short)1514107515;
				switch (num2 == num)
				{
				}
				num = (short)1145044992;
				short num3 = num;
				num = (short)1314455553;
				if (num != 0)
				{
				}
				num = (short)1170276352;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.Applicable = value;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x00282A14 File Offset: 0x00280C14
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x00282AC4 File Offset: 0x00280CC4
		public bool ScanLstGeneralPriority2Type_A8748_Valid
		{
			get
			{
				short num = (short)1470732115;
				short num2 = num;
				num = (short)121083731;
				switch (num2 == num)
				{
				}
				num = (short)928317440;
				short num3 = num;
				num = (short)36765697;
				if (num != 0)
				{
				}
				num = (short)1355284480;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.Valid;
			}
			set
			{
				short num = (short)1969774457;
				short num2 = num;
				num = (short)371613561;
				switch (num2 == num)
				{
				}
				num = (short)753467392;
				short num3 = num;
				num = (short)456130560;
				if (num != 0)
				{
				}
				num = (short)1486749697;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.Valid = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x00282B78 File Offset: 0x00280D78
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x00282C2C File Offset: 0x00280E2C
		public bool ScanLstGeneralPriority2Type_A8748_Visible
		{
			get
			{
				short num = (short)389939201;
				if (num != 0)
				{
				}
				num = (short)498012672;
				short num2 = num;
				num = (short)1777603072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1743060992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735131136;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.Visible;
			}
			set
			{
				short num = (short)401813656;
				short num2 = num;
				num = (short)166998168;
				switch (num2 == num)
				{
				}
				num = (short)1219624960;
				short num3 = num;
				num = (short)2038169601;
				if (num != 0)
				{
				}
				num = (short)1228013568;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.Visible = value;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x00282CE4 File Offset: 0x00280EE4
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x00282D9C File Offset: 0x00280F9C
		public bool ScanLstGeneralPriority2Type_A8748_Editable
		{
			get
			{
				short num = (short)1671641125;
				short num2 = num;
				num = (short)1117141029;
				switch (num2 == num)
				{
				}
				num = (short)1404960768;
				short num3 = num;
				num = (short)16121856;
				if (num != 0)
				{
				}
				num = (short)1824194561;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.Editable;
			}
			set
			{
				short num = (short)1655527801;
				short num2 = num;
				num = (short)1764645241;
				switch (num2 == num)
				{
				}
				num = (short)1509556224;
				short num3 = num;
				num = (short)590544897;
				if (num != 0)
				{
				}
				num = (short)396099584;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.Editable = value;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x00282E50 File Offset: 0x00281050
		internal string ScanLstGeneralPriority2Type_A8748_UILabel
		{
			get
			{
				short num = (short)1895856115;
				short num2 = num;
				num = (short)1582921715;
				switch (num2 == num)
				{
				}
				num = (short)1128267776;
				short num3 = num;
				num = (short)1028063232;
				if (num != 0)
				{
				}
				num = (short)981139457;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.UIName;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x00282F04 File Offset: 0x00281104
		// (set) Token: 0x06002917 RID: 10519 RVA: 0x00282FBC File Offset: 0x002811BC
		internal bool ScanLstGeneralPriority2Type_A8748_HiddenStatic
		{
			get
			{
				short num = (short)347676587;
				short num2 = num;
				num = (short)793190315;
				switch (num2 == num)
				{
				}
				num = (short)385417216;
				short num3 = num;
				num = (short)918945792;
				if (num != 0)
				{
				}
				num = (short)181207041;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.HiddenStatic;
			}
			set
			{
				short num = (short)1331625985;
				if (num != 0)
				{
				}
				num = (short)750060005;
				short num2 = num;
				num = (short)1121452517;
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
				num = (short)349765632;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.HiddenStatic = value;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x00283074 File Offset: 0x00281274
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x00283128 File Offset: 0x00281328
		internal bool ScanLstGeneralPriority2Type_A8748_HiddenDynamic
		{
			get
			{
				short num = (short)1215311673;
				short num2 = num;
				num = (short)1886400313;
				switch (num2 == num)
				{
				}
				num = (short)1093992448;
				short num3 = num;
				num = (short)1745420288;
				if (num != 0)
				{
				}
				num = (short)1625948161;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748.HiddenDynamic;
			}
			set
			{
				short num = (short)1785665448;
				short num2 = num;
				num = (short)750852008;
				switch (num2 == num)
				{
				}
				num = (short)260964352;
				short num3 = num;
				num = (short)2036531201;
				if (num != 0)
				{
				}
				num = (short)2101411840;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriority2Type_A8748.HiddenDynamic = value;
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x002831DC File Offset: 0x002813DC
		public bool ScanLstGeneralPriority2Type_A8748_HasDiffs
		{
			get
			{
				short num = (short)69861377;
				if (num != 0)
				{
				}
				num = (short)2116097075;
				short num2 = num;
				num = (short)2017924147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1194328064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850067456;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriority2Type_A8748._HasDiffs;
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x00283294 File Offset: 0x00281494
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x00283348 File Offset: 0x00281548
		public int ScanLstGeneralPriorityMember2_A8749Value
		{
			get
			{
				short num = (short)1964234785;
				short num2 = num;
				num = (short)610392097;
				switch (num2 == num)
				{
				}
				num = (short)1500184576;
				short num3 = num;
				num = (short)1232863233;
				if (num != 0)
				{
				}
				num = (short)658243584;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.Value;
			}
			set
			{
				short num = (short)1488177805;
				short num2 = num;
				num = (short)50252429;
				switch (num2 == num)
				{
				}
				num = (short)1343946752;
				short num3 = num;
				num = (short)1932001281;
				if (num != 0)
				{
				}
				num = (short)1737293824;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.Value = value;
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x002833FC File Offset: 0x002815FC
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x002834B4 File Offset: 0x002816B4
		public string ScanLstGeneralPriorityMember2_A8749_UIValue
		{
			get
			{
				short num = (short)619902544;
				short num2 = num;
				num = (short)2144007760;
				switch (num2 == num)
				{
				}
				num = (short)1661992960;
				short num3 = num;
				num = (short)1584594945;
				if (num != 0)
				{
				}
				num = (short)640483328;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.UIValue;
			}
			set
			{
				short num = (short)978131327;
				short num2 = num;
				num = (short)464853375;
				switch (num2 == num)
				{
				}
				num = (short)784138240;
				short num3 = num;
				num = (short)294649857;
				if (num != 0)
				{
				}
				num = (short)289013760;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.UIValue = value;
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x0028356C File Offset: 0x0028176C
		public global::AcpBusinessLayer.AcpRecRefField ScanLstGeneralPriorityMember2_A8749
		{
			get
			{
				short num = (short)1562574184;
				short num2 = num;
				num = (short)291831144;
				switch (num2 == num)
				{
				}
				num = (short)2006843392;
				short num3 = num;
				num = (short)172621824;
				if (num != 0)
				{
				}
				num = (short)332922881;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749;
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x0028361C File Offset: 0x0028181C
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x002836D0 File Offset: 0x002818D0
		public bool ScanLstGeneralPriorityMember2_A8749_Applicable
		{
			get
			{
				short num = (short)1898631215;
				short num2 = num;
				num = (short)1381093423;
				switch (num2 == num)
				{
				}
				num = (short)485752832;
				short num3 = num;
				num = (short)1891500033;
				if (num != 0)
				{
				}
				num = (short)1275265024;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.Applicable;
			}
			set
			{
				short num = (short)964530672;
				short num2 = num;
				num = (short)651727344;
				switch (num2 == num)
				{
				}
				num = (short)828243968;
				short num3 = num;
				num = (short)986185729;
				if (num != 0)
				{
				}
				num = (short)1471610880;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.Applicable = value;
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x00283788 File Offset: 0x00281988
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x0028383C File Offset: 0x00281A3C
		public bool ScanLstGeneralPriorityMember2_A8749_Valid
		{
			get
			{
				short num = (short)2046530802;
				short num2 = num;
				num = (short)726045938;
				switch (num2 == num)
				{
				}
				num = (short)1351614464;
				short num3 = num;
				num = (short)827064321;
				if (num != 0)
				{
				}
				num = (short)365101056;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.Valid;
			}
			set
			{
				short num = (short)1081917855;
				short num2 = num;
				num = (short)1321320863;
				switch (num2 == num)
				{
				}
				num = (short)154140672;
				short num3 = num;
				num = (short)50331648;
				if (num != 0)
				{
				}
				num = (short)296550401;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.Valid = value;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x002838F0 File Offset: 0x00281AF0
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x002839A4 File Offset: 0x00281BA4
		public bool ScanLstGeneralPriorityMember2_A8749_Visible
		{
			get
			{
				short num = (short)1849633509;
				short num2 = num;
				num = (short)1300441829;
				switch (num2 == num)
				{
				}
				num = (short)825163776;
				short num3 = num;
				num = (short)305987585;
				if (num != 0)
				{
				}
				num = (short)2088239104;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.Visible;
			}
			set
			{
				short num = (short)186466218;
				short num2 = num;
				num = (short)104873898;
				switch (num2 == num)
				{
				}
				num = (short)1614151680;
				short num3 = num;
				num = (short)1166671872;
				if (num != 0)
				{
				}
				num = (short)1339097089;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.Visible = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x00283A5C File Offset: 0x00281C5C
		// (set) Token: 0x06002927 RID: 10535 RVA: 0x00283B10 File Offset: 0x00281D10
		public bool ScanLstGeneralPriorityMember2_A8749_Editable
		{
			get
			{
				short num = (short)669090940;
				short num2 = num;
				num = (short)839615612;
				switch (num2 == num)
				{
				}
				num = (short)1040056320;
				short num3 = num;
				num = (short)1552285697;
				if (num != 0)
				{
				}
				num = (short)1304494080;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.Editable;
			}
			set
			{
				short num = (short)606168170;
				short num2 = num;
				num = (short)214852714;
				switch (num2 == num)
				{
				}
				num = (short)1857945600;
				short num3 = num;
				num = (short)399245312;
				if (num != 0)
				{
				}
				num = (short)1108475905;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.Editable = value;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x00283BC8 File Offset: 0x00281DC8
		internal string ScanLstGeneralPriorityMember2_A8749_UILabel
		{
			get
			{
				short num = (short)977307110;
				short num2 = num;
				num = (short)1324451302;
				switch (num2 == num)
				{
				}
				num = (short)1195114496;
				short num3 = num;
				num = (short)1685192704;
				if (num != 0)
				{
				}
				num = (short)308412417;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.UIName;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x00283C7C File Offset: 0x00281E7C
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x00283D30 File Offset: 0x00281F30
		internal bool ScanLstGeneralPriorityMember2_A8749_HiddenStatic
		{
			get
			{
				short num = (short)595732237;
				short num2 = num;
				num = (short)812263181;
				switch (num2 == num)
				{
				}
				num = (short)1921646592;
				short num3 = num;
				num = (short)1853358080;
				if (num != 0)
				{
				}
				num = (short)1885995009;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.HiddenStatic;
			}
			set
			{
				short num = (short)816822270;
				short num2 = num;
				num = (short)394246142;
				switch (num2 == num)
				{
				}
				num = (short)764477440;
				short num3 = num;
				num = (short)2146369537;
				if (num != 0)
				{
				}
				num = (short)636878848;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.HiddenStatic = value;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x00283DE4 File Offset: 0x00281FE4
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x00283E94 File Offset: 0x00282094
		internal bool ScanLstGeneralPriorityMember2_A8749_HiddenDynamic
		{
			get
			{
				short num = (short)437459836;
				short num2 = num;
				num = (short)1490426748;
				switch (num2 == num)
				{
				}
				num = (short)244973568;
				short num3 = num;
				num = (short)2070675456;
				if (num != 0)
				{
				}
				num = (short)1811087361;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749.HiddenDynamic;
			}
			set
			{
				short num = (short)1318826343;
				short num2 = num;
				num = (short)632336743;
				switch (num2 == num)
				{
				}
				num = (short)1765998592;
				short num3 = num;
				num = (short)34013184;
				if (num != 0)
				{
				}
				num = (short)1538850817;
				if (num != 0)
				{
				}
				this.scanLstGeneralPriorityMember2_A8749.HiddenDynamic = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x00283F4C File Offset: 0x0028214C
		public bool ScanLstGeneralPriorityMember2_A8749_HasDiffs
		{
			get
			{
				short num = (short)577311066;
				short num2 = num;
				num = (short)112464218;
				switch (num2 == num)
				{
				}
				num = (short)1442643968;
				short num3 = num;
				num = (short)532217857;
				if (num != 0)
				{
				}
				num = (short)1556348928;
				if (num != 0)
				{
				}
				return this.scanLstGeneralPriorityMember2_A8749._HasDiffs;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x00284000 File Offset: 0x00282200
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x002840B4 File Offset: 0x002822B4
		public int ScanLstGeneralRecord_A8921Value
		{
			get
			{
				short num = (short)400162817;
				if (num != 0)
				{
				}
				num = (short)309850323;
				short num2 = num;
				num = (short)1707798739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)130809856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1201930240;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.Value;
			}
			set
			{
				short num = (short)1109262337;
				if (num != 0)
				{
				}
				num = (short)84964487;
				short num2 = num;
				num = (short)170357895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112997888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917110784;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.Value = value;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00284170 File Offset: 0x00282370
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x00284228 File Offset: 0x00282428
		public string ScanLstGeneralRecord_A8921_UIValue
		{
			get
			{
				short num = (short)1423891889;
				short num2 = num;
				num = (short)662298033;
				switch (num2 == num)
				{
				}
				num = (short)1534722048;
				short num3 = num;
				num = (short)527499265;
				if (num != 0)
				{
				}
				num = (short)1862991872;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.UIValue;
			}
			set
			{
				short num = (short)542543401;
				short num2 = num;
				num = (short)963808809;
				switch (num2 == num)
				{
				}
				num = (short)1549336576;
				short num3 = num;
				num = (short)402522113;
				if (num != 0)
				{
				}
				num = (short)226754560;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.UIValue = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x002842E0 File Offset: 0x002824E0
		public global::AcpBusinessLayer.AcpRecRefField ScanLstGeneralRecord_A8921
		{
			get
			{
				short num = (short)1813921345;
				short num2 = num;
				num = (short)479215169;
				switch (num2 == num)
				{
				}
				num = (short)2029256704;
				short num3 = num;
				num = (short)2133852161;
				if (num != 0)
				{
				}
				num = (short)1242759168;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x00284390 File Offset: 0x00282590
		// (set) Token: 0x06002934 RID: 10548 RVA: 0x00284444 File Offset: 0x00282644
		public bool ScanLstGeneralRecord_A8921_Applicable
		{
			get
			{
				short num = (short)20408548;
				short num2 = num;
				num = (short)1116432612;
				switch (num2 == num)
				{
				}
				num = (short)1788477440;
				short num3 = num;
				num = (short)1943928832;
				if (num != 0)
				{
				}
				num = (short)285016065;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.Applicable;
			}
			set
			{
				short num = (short)1033172834;
				short num2 = num;
				num = (short)1016592226;
				switch (num2 == num)
				{
				}
				num = (short)299827200;
				short num3 = num;
				num = (short)1784152065;
				if (num != 0)
				{
				}
				num = (short)699465728;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.Applicable = value;
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x002844F8 File Offset: 0x002826F8
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x002845AC File Offset: 0x002827AC
		public bool ScanLstGeneralRecord_A8921_Valid
		{
			get
			{
				short num = (short)1574408069;
				short num2 = num;
				num = (short)829001605;
				switch (num2 == num)
				{
				}
				num = (short)1657602048;
				short num3 = num;
				num = (short)1571946497;
				if (num != 0)
				{
				}
				num = (short)1413873664;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.Valid;
			}
			set
			{
				short num = (short)1920914635;
				short num2 = num;
				num = (short)1011143883;
				switch (num2 == num)
				{
				}
				num = (short)1655111680;
				short num3 = num;
				num = (short)1283457025;
				if (num != 0)
				{
				}
				num = (short)1866530816;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.Valid = value;
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x00284660 File Offset: 0x00282860
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x00284714 File Offset: 0x00282914
		public bool ScanLstGeneralRecord_A8921_Visible
		{
			get
			{
				short num = (short)1535686704;
				short num2 = num;
				num = (short)816691248;
				switch (num2 == num)
				{
				}
				num = (short)1621950464;
				short num3 = num;
				num = (short)1952907264;
				if (num != 0)
				{
				}
				num = (short)261423105;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.Visible;
			}
			set
			{
				short num = (short)1574582349;
				short num2 = num;
				num = (short)574699597;
				switch (num2 == num)
				{
				}
				num = (short)1958150144;
				short num3 = num;
				num = (short)780599297;
				if (num != 0)
				{
				}
				num = (short)1239285760;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.Visible = value;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x002847CC File Offset: 0x002829CC
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x00284880 File Offset: 0x00282A80
		public bool ScanLstGeneralRecord_A8921_Editable
		{
			get
			{
				short num = (short)114607905;
				short num2 = num;
				num = (short)1713686305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1145569280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)20905985;
				if (num != 0)
				{
				}
				num = (short)9502720;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.Editable;
			}
			set
			{
				short num = (short)899562189;
				short num2 = num;
				num = (short)1112488653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)333250560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489619456;
				if (num != 0)
				{
				}
				num = (short)1077411841;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.Editable = value;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x00284934 File Offset: 0x00282B34
		internal string ScanLstGeneralRecord_A8921_UILabel
		{
			get
			{
				short num = (short)962076009;
				short num2 = num;
				num = (short)151788905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1932525568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020723200;
				if (num != 0)
				{
				}
				num = (short)1350041601;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.UIName;
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x002849E8 File Offset: 0x00282BE8
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x00284AA0 File Offset: 0x00282CA0
		internal bool ScanLstGeneralRecord_A8921_HiddenStatic
		{
			get
			{
				short num = (short)36110030;
				short num2 = num;
				num = (short)809828046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023882752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5046273;
				if (num != 0)
				{
				}
				num = (short)546963456;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.HiddenStatic;
			}
			set
			{
				short num = (short)320171043;
				short num2 = num;
				num = (short)1941466147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874591744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1517420545;
				if (num != 0)
				{
				}
				num = (short)1306525696;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.HiddenStatic = value;
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x00284B58 File Offset: 0x00282D58
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00284C10 File Offset: 0x00282E10
		internal bool ScanLstGeneralRecord_A8921_HiddenDynamic
		{
			get
			{
				short num = (short)1540358145;
				if (num != 0)
				{
				}
				num = (short)1412890624;
				short num2 = num;
				num = (short)1118207036;
				short num3 = num;
				num = (short)333610044;
				switch (num3 == num)
				{
				}
				num = (short)420020224;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921.HiddenDynamic;
			}
			set
			{
				short num = (short)444334771;
				short num2 = num;
				num = (short)268370611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401211392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)929234944;
				if (num != 0)
				{
				}
				num = (short)1997799425;
				if (num != 0)
				{
				}
				this.scanLstGeneralRecord_A8921.HiddenDynamic = value;
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x00284CC8 File Offset: 0x00282EC8
		public bool ScanLstGeneralRecord_A8921_HasDiffs
		{
			get
			{
				short num = (short)1463243443;
				short num2 = num;
				num = (short)2114278067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993984512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)291307521;
				if (num != 0)
				{
				}
				num = (short)425132032;
				if (num != 0)
				{
				}
				return this.scanLstGeneralRecord_A8921._HasDiffs;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00284D7C File Offset: 0x00282F7C
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x00284E30 File Offset: 0x00283030
		public int ScanLstGeneralScanType_A9058Value
		{
			get
			{
				short num = (short)800784279;
				short num2 = num;
				num = (short)319618967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915551744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415184385;
				if (num != 0)
				{
				}
				num = (short)1749614592;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.Value;
			}
			set
			{
				short num = (short)474753537;
				short num2 = num;
				num = (short)964766209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822883840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)864157697;
				if (num != 0)
				{
				}
				num = (short)1186332672;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.Value = value;
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x00284EE8 File Offset: 0x002830E8
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x00284F9C File Offset: 0x0028319C
		public string ScanLstGeneralScanType_A9058_UIValue
		{
			get
			{
				short num = (short)265962781;
				short num2 = num;
				num = (short)46155037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418578432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463339520;
				if (num != 0)
				{
				}
				num = (short)934608897;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.UIValue;
			}
			set
			{
				short num = (short)1725367657;
				short num2 = num;
				num = (short)2132084073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)902692864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562692097;
				if (num != 0)
				{
				}
				num = (short)764805120;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.UIValue = value;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x00285054 File Offset: 0x00283254
		public global::AcpBusinessLayer.AcpListField ScanLstGeneralScanType_A9058
		{
			get
			{
				short num = (short)1155772636;
				short num2 = num;
				num = (short)1331736796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)792199168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)339673089;
				if (num != 0)
				{
				}
				num = (short)709558272;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x00285104 File Offset: 0x00283304
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x002851BC File Offset: 0x002833BC
		public bool ScanLstGeneralScanType_A9058_Applicable
		{
			get
			{
				short num = (short)106065006;
				short num2 = num;
				num = (short)912944238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101004800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1831272448;
				if (num != 0)
				{
				}
				num = (short)1142620161;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.Applicable;
			}
			set
			{
				short num = (short)332865486;
				short num2 = num;
				num = (short)448208846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7012352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1227227136;
				if (num != 0)
				{
				}
				num = (short)798883841;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.Applicable = value;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x00285270 File Offset: 0x00283470
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x00285328 File Offset: 0x00283528
		public bool ScanLstGeneralScanType_A9058_Valid
		{
			get
			{
				short num = (short)898207107;
				short num2 = num;
				num = (short)790924675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205993472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1371340801;
				if (num != 0)
				{
				}
				num = (short)756416512;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.Valid;
			}
			set
			{
				short num = (short)1166658605;
				short num2 = num;
				num = (short)1005374509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2621440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)973275137;
				if (num != 0)
				{
				}
				num = (short)968163328;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.Valid = value;
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x002853DC File Offset: 0x002835DC
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x0028548C File Offset: 0x0028368C
		public bool ScanLstGeneralScanType_A9058_Visible
		{
			get
			{
				short num = (short)1931719231;
				short num2 = num;
				num = (short)1292874303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1263665152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653538816;
				if (num != 0)
				{
				}
				num = (short)1658978305;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.Visible;
			}
			set
			{
				short num = (short)1348547180;
				short num2 = num;
				num = (short)1148072556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231538688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83886081;
				if (num != 0)
				{
				}
				num = (short)699596800;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.Visible = value;
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x00285540 File Offset: 0x00283740
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x002855F4 File Offset: 0x002837F4
		public bool ScanLstGeneralScanType_A9058_Editable
		{
			get
			{
				short num = (short)552779764;
				short num2 = num;
				num = (short)437501940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286406144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1419313153;
				if (num != 0)
				{
				}
				num = (short)123666432;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.Editable;
			}
			set
			{
				short num = (short)1074398255;
				short num2 = num;
				num = (short)581108783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816461312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40108033;
				if (num != 0)
				{
				}
				num = (short)479133696;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.Editable = value;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x002856A8 File Offset: 0x002838A8
		internal string ScanLstGeneralScanType_A9058_UILabel
		{
			get
			{
				short num = (short)1372147837;
				short num2 = num;
				num = (short)1563512957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071448064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1144520705;
				if (num != 0)
				{
				}
				num = (short)905641984;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.UIName;
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x0028575C File Offset: 0x0028395C
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x00285814 File Offset: 0x00283A14
		internal bool ScanLstGeneralScanType_A9058_HiddenStatic
		{
			get
			{
				short num = (short)1532173791;
				short num2 = num;
				num = (short)235150815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1924595712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429667841;
				if (num != 0)
				{
				}
				num = (short)835846144;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.HiddenStatic;
			}
			set
			{
				short num = (short)47130324;
				short num2 = num;
				num = (short)865609428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758448128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567279617;
				if (num != 0)
				{
				}
				num = (short)328007680;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.HiddenStatic = value;
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x002858CC File Offset: 0x00283ACC
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x00285980 File Offset: 0x00283B80
		internal bool ScanLstGeneralScanType_A9058_HiddenDynamic
		{
			get
			{
				short num = (short)864681985;
				if (num != 0)
				{
				}
				num = (short)1971650560;
				short num2 = num;
				num = (short)443260844;
				short num3 = num;
				num = (short)1117233068;
				switch (num3 == num)
				{
				}
				num = (short)2094202880;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058.HiddenDynamic;
			}
			set
			{
				short num = (short)868350576;
				short num2 = num;
				num = (short)475527792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589510144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1097531393;
				if (num != 0)
				{
				}
				num = (short)996081664;
				if (num != 0)
				{
				}
				this.scanLstGeneralScanType_A9058.HiddenDynamic = value;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x00285A34 File Offset: 0x00283C34
		public bool ScanLstGeneralScanType_A9058_HasDiffs
		{
			get
			{
				short num = (short)1916615780;
				short num2 = num;
				num = (short)491404388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76414976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7405569;
				if (num != 0)
				{
				}
				num = (short)644546560;
				if (num != 0)
				{
				}
				return this.scanLstGeneralScanType_A9058._HasDiffs;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00285AEC File Offset: 0x00283CEC
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00285BA4 File Offset: 0x00283DA4
		public int ScanLstGeneralType_A9578Value
		{
			get
			{
				short num = (short)819705870;
				short num2 = num;
				num = (short)1563998222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319619072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1230700545;
				if (num != 0)
				{
				}
				num = (short)844890112;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.Value;
			}
			set
			{
				short num = (short)1766371483;
				short num2 = num;
				num = (short)1954328731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1456144384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				num = (short)1525219329;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.Value = value;
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00285C58 File Offset: 0x00283E58
		public global::AcpBusinessLayer.AcpPointerField<int> ScanLstGeneralType_A9578
		{
			get
			{
				short num = (short)2049771014;
				short num2 = num;
				num = (short)528025094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1347289088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)875167745;
				if (num != 0)
				{
				}
				num = (short)258342912;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x00285D08 File Offset: 0x00283F08
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x00285DC0 File Offset: 0x00283FC0
		public string ScanLstGeneralType_A9578_UIValue
		{
			get
			{
				short num = (short)11813033;
				short num2 = num;
				num = (short)1486045353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492058112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1216544768;
				if (num != 0)
				{
				}
				num = (short)545849345;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.UIValue;
			}
			set
			{
				short num = (short)49790245;
				short num2 = num;
				num = (short)1267711269;
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
				num = (short)780206081;
				if (num != 0)
				{
				}
				num = (short)1506410496;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.UIValue = value;
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x00285E74 File Offset: 0x00284074
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x00285F2C File Offset: 0x0028412C
		public bool ScanLstGeneralType_A9578_Applicable
		{
			get
			{
				short num = (short)1254677697;
				short num2 = num;
				num = (short)1410718913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)690814976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)394592257;
				if (num != 0)
				{
				}
				num = (short)367263744;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.Applicable;
			}
			set
			{
				short num = (short)33851729;
				short num2 = num;
				num = (short)414419281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)105054208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1978662913;
				if (num != 0)
				{
				}
				num = (short)1181220864;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.Applicable = value;
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x00285FE4 File Offset: 0x002841E4
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x00286098 File Offset: 0x00284298
		public bool ScanLstGeneralType_A9578_Valid
		{
			get
			{
				short num = (short)1717436417;
				if (num != 0)
				{
				}
				num = (short)1158545408;
				short num2 = num;
				num = (short)1034511299;
				short num3 = num;
				num = (short)1803248579;
				switch (num3 == num)
				{
				}
				num = (short)839647232;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.Valid;
			}
			set
			{
				short num = (short)514327773;
				short num2 = num;
				num = (short)964756701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)769523712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417005568;
				if (num != 0)
				{
				}
				num = (short)1096286209;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.Valid = value;
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x0028614C File Offset: 0x0028434C
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x00286204 File Offset: 0x00284404
		public bool ScanLstGeneralType_A9578_Visible
		{
			get
			{
				short num = (short)1802594067;
				short num2 = num;
				num = (short)1114531603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)29556736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980746241;
				if (num != 0)
				{
				}
				num = (short)178978816;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.Visible;
			}
			set
			{
				short num = (short)906061211;
				short num2 = num;
				num = (short)802383259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550319616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945239553;
				if (num != 0)
				{
				}
				num = (short)1449459712;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.Visible = value;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x002862B8 File Offset: 0x002844B8
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x0028636C File Offset: 0x0028456C
		public bool ScanLstGeneralType_A9578_Editable
		{
			get
			{
				short num = (short)1488198082;
				short num2 = num;
				num = (short)1851922882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)157155328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028325377;
				if (num != 0)
				{
				}
				num = (short)595853312;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.Editable;
			}
			set
			{
				short num = (short)1797106384;
				short num2 = num;
				num = (short)1459661520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360003072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498597888;
				if (num != 0)
				{
				}
				num = (short)1482293249;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.Editable = value;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06002961 RID: 10593 RVA: 0x00286424 File Offset: 0x00284624
		internal string ScanLstGeneralType_A9578_UILabel
		{
			get
			{
				short num = (short)717731146;
				short num2 = num;
				num = (short)1192605002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678363136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)483852289;
				if (num != 0)
				{
				}
				num = (short)687079424;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.UIName;
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x002864DC File Offset: 0x002846DC
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x00286590 File Offset: 0x00284790
		internal bool ScanLstGeneralType_A9578_HiddenStatic
		{
			get
			{
				short num = (short)1924843720;
				short num2 = num;
				num = (short)1155778760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820459008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)749142017;
				if (num != 0)
				{
				}
				num = (short)1148715008;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.HiddenStatic;
			}
			set
			{
				short num = (short)480293328;
				short num2 = num;
				num = (short)1859891664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1983643648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46071809;
				if (num != 0)
				{
				}
				num = (short)1429995520;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.HiddenStatic = value;
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x00286648 File Offset: 0x00284848
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x00286700 File Offset: 0x00284900
		internal bool ScanLstGeneralType_A9578_HiddenDynamic
		{
			get
			{
				short num = (short)1717299032;
				short num2 = num;
				num = (short)553707352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1807876096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1278410753;
				if (num != 0)
				{
				}
				num = (short)459079680;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578.HiddenDynamic;
			}
			set
			{
				short num = (short)13413302;
				short num2 = num;
				num = (short)804105142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)976814080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1617494017;
				if (num != 0)
				{
				}
				num = (short)1595277312;
				if (num != 0)
				{
				}
				this.scanLstGeneralType_A9578.HiddenDynamic = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x002867B8 File Offset: 0x002849B8
		public bool ScanLstGeneralType_A9578_HasDiffs
		{
			get
			{
				short num = (short)1039953694;
				short num2 = num;
				num = (short)1705930526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1633419264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957429249;
				if (num != 0)
				{
				}
				num = (short)658178048;
				if (num != 0)
				{
				}
				return this.scanLstGeneralType_A9578._HasDiffs;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x00286870 File Offset: 0x00284A70
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x00286920 File Offset: 0x00284B20
		public string ScanLstGeneralKeyofScanList_A12668Value
		{
			get
			{
				short num = (short)1851796693;
				short num2 = num;
				num = (short)523447509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811401216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2084765697;
				if (num != 0)
				{
				}
				num = (short)1418985472;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.Value;
			}
			set
			{
				short num = (short)244842498;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)239346106;
						short num3 = num;
						num = (short)72163770;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1728118785;
							if (num != 0)
							{
							}
							num = (short)257228800;
							short num4 = num;
							num = (short)1983905792;
							if (num != 0)
							{
							}
							this.scanLstGeneralKeyofScanList_A12668.Value = value;
							num = (short)1768292352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1814429697;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x00286A44 File Offset: 0x00284C44
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x00286AF8 File Offset: 0x00284CF8
		public string ScanLstGeneralKeyofScanList_A12668_UIValue
		{
			get
			{
				short num = (short)40443507;
				short num2 = num;
				num = (short)1330323059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1832779776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1413545985;
				if (num != 0)
				{
				}
				num = (short)412221440;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.Value;
			}
			set
			{
				short num = (short)439606112;
				short num2 = num;
				num = (short)1128782688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1163460608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1321467905;
				if (num != 0)
				{
				}
				num = (short)1759117312;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.Value = value;
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x00286BAC File Offset: 0x00284DAC
		public global::AcpBusinessLayer.AcpKeyField ScanLstGeneralKeyofScanList_A12668
		{
			get
			{
				short num = (short)122563380;
				short num2 = num;
				num = (short)2047421236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074214400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210698240;
				if (num != 0)
				{
				}
				num = (short)957349889;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x00286C5C File Offset: 0x00284E5C
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x00286D14 File Offset: 0x00284F14
		public bool ScanLstGeneralKeyofScanList_A12668_Applicable
		{
			get
			{
				short num = (short)1606278470;
				short num2 = num;
				num = (short)148430150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1058078720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)913113089;
				if (num != 0)
				{
				}
				num = (short)1375338496;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.Applicable;
			}
			set
			{
				short num = (short)750428767;
				short num2 = num;
				num = (short)552116831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207814656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391788033;
				if (num != 0)
				{
				}
				num = (short)1286995968;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.Applicable = value;
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x00286DC8 File Offset: 0x00284FC8
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x00286E7C File Offset: 0x0028507C
		public bool ScanLstGeneralKeyofScanList_A12668_Valid
		{
			get
			{
				short num = (short)1392506939;
				short num2 = num;
				num = (short)730396731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)461242368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1135935489;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.Valid;
			}
			set
			{
				short num = (short)1785803805;
				short num2 = num;
				num = (short)215888925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)580583424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1989148673;
				if (num != 0)
				{
				}
				num = (short)1385693184;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.Valid = value;
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x00286F30 File Offset: 0x00285130
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x00286FE4 File Offset: 0x002851E4
		public bool ScanLstGeneralKeyofScanList_A12668_Visible
		{
			get
			{
				short num = (short)1145992868;
				short num2 = num;
				num = (short)698185380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)812515328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2037186561;
				if (num != 0)
				{
				}
				num = (short)1586298880;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.Visible;
			}
			set
			{
				short num = (short)1038294253;
				short num2 = num;
				num = (short)523836653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1748369408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)829227008;
				if (num != 0)
				{
				}
				num = (short)200540161;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.Visible = value;
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x0028709C File Offset: 0x0028529C
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x00287150 File Offset: 0x00285350
		public bool ScanLstGeneralKeyofScanList_A12668_Editable
		{
			get
			{
				short num = (short)1186920084;
				short num2 = num;
				num = (short)1736832660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1826619392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1457913857;
				if (num != 0)
				{
				}
				num = (short)1029701632;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.Editable;
			}
			set
			{
				short num = (short)834756386;
				short num2 = num;
				num = (short)1710907170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1576140800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1190002689;
				if (num != 0)
				{
				}
				num = (short)672202752;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.Editable = value;
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x00287204 File Offset: 0x00285404
		internal string ScanLstGeneralKeyofScanList_A12668_UILabel
		{
			get
			{
				short num = (short)1854566835;
				short num2 = num;
				num = (short)895119795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429260800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074607617;
				if (num != 0)
				{
				}
				num = (short)1557135360;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.UIName;
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x002872B8 File Offset: 0x002854B8
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x0028736C File Offset: 0x0028556C
		internal bool ScanLstGeneralKeyofScanList_A12668_HiddenStatic
		{
			get
			{
				short num = (short)1671577560;
				short num2 = num;
				num = (short)188432344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236533248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215154688;
				if (num != 0)
				{
				}
				num = (short)1184759809;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.HiddenStatic;
			}
			set
			{
				short num = (short)1324960421;
				short num2 = num;
				num = (short)204425893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1535311872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1511522305;
				if (num != 0)
				{
				}
				num = (short)1992359936;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.HiddenStatic = value;
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x00287420 File Offset: 0x00285620
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x002874D4 File Offset: 0x002856D4
		internal bool ScanLstGeneralKeyofScanList_A12668_HiddenDynamic
		{
			get
			{
				short num = (short)1760141848;
				short num2 = num;
				num = (short)637968920;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1126957056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)884473856;
				if (num != 0)
				{
				}
				num = (short)649330689;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668.HiddenDynamic;
			}
			set
			{
				short num = (short)1293285776;
				short num2 = num;
				num = (short)1953167760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663945216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172242433;
				if (num != 0)
				{
				}
				num = (short)771489792;
				if (num != 0)
				{
				}
				this.scanLstGeneralKeyofScanList_A12668.HiddenDynamic = value;
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x0028758C File Offset: 0x0028578C
		public bool ScanLstGeneralKeyofScanList_A12668_HasDiffs
		{
			get
			{
				short num = (short)1606019416;
				short num2 = num;
				num = (short)1913710936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491337216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)480051201;
				if (num != 0)
				{
				}
				num = (short)1910767616;
				if (num != 0)
				{
				}
				return this.scanLstGeneralKeyofScanList_A12668._HasDiffs;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x00287640 File Offset: 0x00285840
		// (set) Token: 0x0600297B RID: 10619 RVA: 0x002876F0 File Offset: 0x002858F0
		public int ScanLstGeneralDesignatedVoiceTxMemberType_A21524Value
		{
			get
			{
				short num = (short)1000900599;
				short num2 = num;
				num = (short)1705805815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687552000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)63242241;
				if (num != 0)
				{
				}
				num = (short)1773404160;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Value;
			}
			set
			{
				short num = (short)719726759;
				short num2 = num;
				num = (short)1674455207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261488640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188481536;
				if (num != 0)
				{
				}
				num = (short)1875312641;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Value = value;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x002877A4 File Offset: 0x002859A4
		// (set) Token: 0x0600297D RID: 10621 RVA: 0x0028785C File Offset: 0x00285A5C
		public string ScanLstGeneralDesignatedVoiceTxMemberType_A21524_UIValue
		{
			get
			{
				short num = (short)268904330;
				short num2 = num;
				num = (short)1657677706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)381419520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)868941825;
				if (num != 0)
				{
				}
				num = (short)1855717376;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.UIValue;
			}
			set
			{
				short num = (short)1344735402;
				short num2 = num;
				num = (short)886835370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912340480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1079902209;
				if (num != 0)
				{
				}
				num = (short)2016935936;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.UIValue = value;
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x00287910 File Offset: 0x00285B10
		public global::AcpBusinessLayer.AcpListField ScanLstGeneralDesignatedVoiceTxMemberType_A21524
		{
			get
			{
				short num = (short)401211393;
				if (num != 0)
				{
				}
				num = (short)162011888;
				short num2 = num;
				num = (short)465181424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1477574656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341639168;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x002879C4 File Offset: 0x00285BC4
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x00287A78 File Offset: 0x00285C78
		public bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_Applicable
		{
			get
			{
				short num = (short)637347439;
				short num2 = num;
				num = (short)421930607;
				switch (num2 == num)
				{
				}
				num = (short)237699072;
				short num3 = num;
				num = (short)967704576;
				if (num != 0)
				{
				}
				num = (short)2035154945;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Applicable;
			}
			set
			{
				short num = (short)1533542401;
				if (num != 0)
				{
				}
				num = (short)1963746961;
				short num2 = num;
				num = (short)144467601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1408630784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)718602240;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Applicable = value;
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x00287B30 File Offset: 0x00285D30
		// (set) Token: 0x06002982 RID: 10626 RVA: 0x00287BE4 File Offset: 0x00285DE4
		public bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_Valid
		{
			get
			{
				short num = (short)1886623869;
				short num2 = num;
				num = (short)1204328573;
				switch (num2 == num)
				{
				}
				num = (short)1686634496;
				short num3 = num;
				num = (short)608894977;
				if (num != 0)
				{
				}
				num = (short)230359040;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Valid;
			}
			set
			{
				short num = (short)1148159900;
				short num2 = num;
				num = (short)917473180;
				switch (num2 == num)
				{
				}
				num = (short)891420672;
				short num3 = num;
				num = (short)819331073;
				if (num != 0)
				{
				}
				num = (short)206241792;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Valid = value;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x00287C9C File Offset: 0x00285E9C
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x00287D54 File Offset: 0x00285F54
		public bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_Visible
		{
			get
			{
				short num = (short)1184628737;
				if (num != 0)
				{
				}
				num = (short)1231358633;
				short num2 = num;
				num = (short)440797865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)693960704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)283181056;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Visible;
			}
			set
			{
				short num = (short)1361853287;
				short num2 = num;
				num = (short)1662729063;
				switch (num2 == num)
				{
				}
				num = (short)823918592;
				short num3 = num;
				num = (short)519241728;
				if (num != 0)
				{
				}
				num = (short)259653633;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Visible = value;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x00287E08 File Offset: 0x00286008
		// (set) Token: 0x06002986 RID: 10630 RVA: 0x00287EC0 File Offset: 0x002860C0
		public bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_Editable
		{
			get
			{
				short num = (short)1043791873;
				if (num != 0)
				{
				}
				num = (short)200842925;
				short num2 = num;
				num = (short)780574381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)307757056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751370240;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Editable;
			}
			set
			{
				short num = (short)1963734663;
				short num2 = num;
				num = (short)1821259399;
				switch (num2 == num)
				{
				}
				num = (short)1949696000;
				short num3 = num;
				num = (short)657522688;
				if (num != 0)
				{
				}
				num = (short)1195835393;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.Editable = value;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x00287F78 File Offset: 0x00286178
		internal string ScanLstGeneralDesignatedVoiceTxMemberType_A21524_UILabel
		{
			get
			{
				short num = (short)1373110273;
				if (num != 0)
				{
				}
				num = (short)395344670;
				short num2 = num;
				num = (short)598047518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029963776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340932096;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.UIName;
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x00288030 File Offset: 0x00286230
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x002880E4 File Offset: 0x002862E4
		internal bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_HiddenStatic
		{
			get
			{
				short num = (short)1862873230;
				short num2 = num;
				num = (short)1322070158;
				switch (num2 == num)
				{
				}
				num = (short)1582039040;
				short num3 = num;
				num = (short)314310657;
				if (num != 0)
				{
				}
				num = (short)1348534272;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.HiddenStatic;
			}
			set
			{
				short num = (short)1740885402;
				short num2 = num;
				num = (short)1840041370;
				switch (num2 == num)
				{
				}
				num = (short)1276837888;
				short num3 = num;
				num = (short)1892548608;
				if (num != 0)
				{
				}
				num = (short)60424193;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.HiddenStatic = value;
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x0028819C File Offset: 0x0028639C
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x00288250 File Offset: 0x00286450
		internal bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_HiddenDynamic
		{
			get
			{
				short num = (short)1201085097;
				short num2 = num;
				num = (short)859118249;
				switch (num2 == num)
				{
				}
				num = (short)1156382720;
				short num3 = num;
				num = (short)860553216;
				if (num != 0)
				{
				}
				num = (short)209846273;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.HiddenDynamic;
			}
			set
			{
				short num = (short)1459027969;
				if (num != 0)
				{
				}
				num = (short)65968539;
				short num2 = num;
				num = (short)1133025691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)966393856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)162463744;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedVoiceTxMemberType_A21524.HiddenDynamic = value;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x00288304 File Offset: 0x00286504
		public bool ScanLstGeneralDesignatedVoiceTxMemberType_A21524_HasDiffs
		{
			get
			{
				short num = (short)1064883514;
				short num2 = num;
				num = (short)2052052282;
				switch (num2 == num)
				{
				}
				num = (short)784400384;
				short num3 = num;
				num = (short)824639489;
				if (num != 0)
				{
				}
				num = (short)1195376640;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedVoiceTxMemberType_A21524._HasDiffs;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x002883BC File Offset: 0x002865BC
		// (set) Token: 0x0600298E RID: 10638 RVA: 0x00288470 File Offset: 0x00286670
		public int ScanLstGeneralDesignatedDataTxRxType_A21525Value
		{
			get
			{
				short num = (short)243325650;
				short num2 = num;
				num = (short)1381161682;
				switch (num2 == num)
				{
				}
				num = (short)1595342848;
				short num3 = num;
				num = (short)1630142465;
				if (num != 0)
				{
				}
				num = (short)2048851968;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.Value;
			}
			set
			{
				short num = (short)1716478819;
				short num2 = num;
				num = (short)580346723;
				switch (num2 == num)
				{
				}
				num = (short)522715136;
				short num3 = num;
				num = (short)1737293825;
				if (num != 0)
				{
				}
				num = (short)2752512;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.Value = value;
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x00288524 File Offset: 0x00286724
		// (set) Token: 0x06002990 RID: 10640 RVA: 0x002885D8 File Offset: 0x002867D8
		public string ScanLstGeneralDesignatedDataTxRxType_A21525_UIValue
		{
			get
			{
				short num = (short)41622214;
				short num2 = num;
				num = (short)592779974;
				switch (num2 == num)
				{
				}
				num = (short)1229127680;
				short num3 = num;
				num = (short)2140405761;
				if (num != 0)
				{
				}
				num = (short)1442840576;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.UIValue;
			}
			set
			{
				short num = (short)472966277;
				short num2 = num;
				num = (short)1196942469;
				switch (num2 == num)
				{
				}
				num = (short)1624113152;
				short num3 = num;
				num = (short)90112001;
				if (num != 0)
				{
				}
				num = (short)1808465920;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.UIValue = value;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x00288690 File Offset: 0x00286890
		public global::AcpBusinessLayer.AcpListField ScanLstGeneralDesignatedDataTxRxType_A21525
		{
			get
			{
				short num = (short)1864499201;
				if (num != 0)
				{
				}
				num = (short)325801267;
				short num2 = num;
				num = (short)1431917875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846804480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662503424;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525;
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x0028873C File Offset: 0x0028693C
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x002887F0 File Offset: 0x002869F0
		public bool ScanLstGeneralDesignatedDataTxRxType_A21525_Applicable
		{
			get
			{
				short num = (short)1553591583;
				short num2 = num;
				num = (short)1192946975;
				switch (num2 == num)
				{
				}
				num = (short)127139840;
				short num3 = num;
				num = (short)1955266560;
				if (num != 0)
				{
				}
				num = (short)1337917441;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.Applicable;
			}
			set
			{
				short num = (short)322895873;
				if (num != 0)
				{
				}
				num = (short)435283952;
				short num2 = num;
				num = (short)935978992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205403648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648675328;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.Applicable = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x002888A4 File Offset: 0x00286AA4
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x00288958 File Offset: 0x00286B58
		public bool ScanLstGeneralDesignatedDataTxRxType_A21525_Valid
		{
			get
			{
				short num = (short)1122922622;
				short num2 = num;
				num = (short)1880715390;
				switch (num2 == num)
				{
				}
				num = (short)31522816;
				short num3 = num;
				num = (short)1728839681;
				if (num != 0)
				{
				}
				num = (short)6553600;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.Valid;
			}
			set
			{
				short num = (short)464127609;
				short num2 = num;
				num = (short)97715833;
				switch (num2 == num)
				{
				}
				num = (short)1783955456;
				short num3 = num;
				num = (short)1301217280;
				if (num != 0)
				{
				}
				num = (short)475332609;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.Valid = value;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x00288A10 File Offset: 0x00286C10
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x00288AC4 File Offset: 0x00286CC4
		public bool ScanLstGeneralDesignatedDataTxRxType_A21525_Visible
		{
			get
			{
				short num = (short)1993998337;
				if (num != 0)
				{
				}
				num = (short)1150134286;
				short num2 = num;
				num = (short)1139386382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1651048448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850788352;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.Visible;
			}
			set
			{
				short num = (short)631373825;
				if (num != 0)
				{
				}
				num = (short)549939959;
				short num2 = num;
				num = (short)825584375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784217600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388497408;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.Visible = value;
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x00288B78 File Offset: 0x00286D78
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x00288C2C File Offset: 0x00286E2C
		public bool ScanLstGeneralDesignatedDataTxRxType_A21525_Editable
		{
			get
			{
				short num = (short)1850108581;
				short num2 = num;
				num = (short)521497253;
				switch (num2 == num)
				{
				}
				num = (short)1280704512;
				short num3 = num;
				num = (short)1809448961;
				if (num != 0)
				{
				}
				num = (short)1738539008;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.Editable;
			}
			set
			{
				short num = (short)772941487;
				short num2 = num;
				num = (short)1556031151;
				switch (num2 == num)
				{
				}
				num = (short)131923968;
				short num3 = num;
				num = (short)1976762369;
				if (num != 0)
				{
				}
				num = (short)209846272;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.Editable = value;
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x00288CE4 File Offset: 0x00286EE4
		internal string ScanLstGeneralDesignatedDataTxRxType_A21525_UILabel
		{
			get
			{
				short num = (short)851228735;
				short num2 = num;
				num = (short)452311103;
				switch (num2 == num)
				{
				}
				num = (short)698089472;
				short num3 = num;
				num = (short)1892614144;
				if (num != 0)
				{
				}
				num = (short)1118306305;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.UIName;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x00288D98 File Offset: 0x00286F98
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x00288E4C File Offset: 0x0028704C
		internal bool ScanLstGeneralDesignatedDataTxRxType_A21525_HiddenStatic
		{
			get
			{
				short num = (short)1321926144;
				short num2 = num;
				num = (short)1950219776;
				switch (num2 == num)
				{
				}
				num = (short)185008128;
				short num3 = num;
				num = (short)627441664;
				if (num != 0)
				{
				}
				num = (short)1517355009;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.HiddenStatic;
			}
			set
			{
				short num = (short)1254883329;
				if (num != 0)
				{
				}
				num = (short)1835794432;
				short num2 = num;
				num = (short)138552254;
				short num3 = num;
				num = (short)664282046;
				switch (num3 == num)
				{
				}
				num = (short)206438400;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.HiddenStatic = value;
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x00288F00 File Offset: 0x00287100
		// (set) Token: 0x0600299E RID: 10654 RVA: 0x00288FB4 File Offset: 0x002871B4
		internal bool ScanLstGeneralDesignatedDataTxRxType_A21525_HiddenDynamic
		{
			get
			{
				short num = (short)2106214006;
				short num2 = num;
				num = (short)296044150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642711552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997588993;
				if (num != 0)
				{
				}
				num = (short)123535360;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525.HiddenDynamic;
			}
			set
			{
				short num = (short)1769735498;
				short num2 = num;
				num = (short)1239352650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)11206656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)689307649;
				if (num != 0)
				{
				}
				num = (short)605290496;
				if (num != 0)
				{
				}
				this.scanLstGeneralDesignatedDataTxRxType_A21525.HiddenDynamic = value;
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0028906C File Offset: 0x0028726C
		public bool ScanLstGeneralDesignatedDataTxRxType_A21525_HasDiffs
		{
			get
			{
				short num = (short)353310992;
				short num2 = num;
				num = (short)1774131472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287454720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1375338496;
				if (num != 0)
				{
				}
				num = (short)1413021697;
				if (num != 0)
				{
				}
				return this.scanLstGeneralDesignatedDataTxRxType_A21525._HasDiffs;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x00289120 File Offset: 0x00287320
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)633013122;
				short num2 = num;
				num = (short)1200096130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074790400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)631898113;
				if (num != 0)
				{
				}
				num = (short)218890240;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x002891E0 File Offset: 0x002873E0
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide RefConventionalWide
		{
			get
			{
				short num = (short)2024649968;
				short num2 = num;
				num = (short)2035725552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1088749568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)323354625;
				if (num != 0)
				{
				}
				num = (short)234553344;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide;
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x002892A4 File Offset: 0x002874A4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
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
						num2 = (short)792199168;
						short num3 = num2;
						num2 = (short)1521599650;
						short num4 = num2;
						num2 = (short)799196322;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)463405056;
							if (num2 != 0)
							{
							}
							num2 = (short)291307521;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						num2 = (short)529465345;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)2104426499;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)45416448;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)861995012;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						return result;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1511456770;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x04000EF5 RID: 3829
		private global::AcpBusinessLayer.AcpRecRefField scanLstGeneralDesignatedDataMember_A7829;

		// Token: 0x04000EF6 RID: 3830
		private global::AcpBusinessLayer.AcpRecRefField scanLstGeneralDesignatedVoiceTxMember_A7830;

		// Token: 0x04000EF7 RID: 3831
		private global::AcpBusinessLayer.AcpField<bool> scanLstGeneralDynamicPriority_A7915;

		// Token: 0x04000EF8 RID: 3832
		private global::AcpBusinessLayer.AcpListField scanLstGeneralNonPriorityMembers_A8569;

		// Token: 0x04000EF9 RID: 3833
		private global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A8745;

		// Token: 0x04000EFA RID: 3834
		private global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember1_A8747;

		// Token: 0x04000EFB RID: 3835
		private global::AcpBusinessLayer.AcpListField scanLstGeneralPriority2Type_A8748;

		// Token: 0x04000EFC RID: 3836
		private global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember2_A8749;

		// Token: 0x04000EFD RID: 3837
		private global::AcpBusinessLayer.AcpRecRefField scanLstGeneralRecord_A8921;

		// Token: 0x04000EFE RID: 3838
		private global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A9058;

		// Token: 0x04000EFF RID: 3839
		private global::AcpBusinessLayer.AcpPointerField<int> scanLstGeneralType_A9578;

		// Token: 0x04000F00 RID: 3840
		private global::AcpBusinessLayer.AcpKeyField scanLstGeneralKeyofScanList_A12668;

		// Token: 0x04000F01 RID: 3841
		private global::AcpBusinessLayer.AcpListField scanLstGeneralDesignatedVoiceTxMemberType_A21524;

		// Token: 0x04000F02 RID: 3842
		private global::AcpBusinessLayer.AcpListField scanLstGeneralDesignatedDataTxRxType_A21525;
	}
}
