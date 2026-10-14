using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.PhoneWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C9 RID: 1481
	[global::System.Serializable]
	public class Phone : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C8FD RID: 51453 RVA: 0x00BBC4E4 File Offset: 0x00BBA6E4
		public Phone(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x00BBC500 File Offset: 0x00BBA700
		protected Phone(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x00BBC518 File Offset: 0x00BBA718
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1649389926;
			short num2 = num;
			num = (short)1248833894;
			switch (num2 == num)
			{
			default:
			{
				num = (short)804257792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)62914560;
			if (num != 0)
			{
			}
			num = (short)1314914305;
			if (num != 0)
			{
			}
			this.cnvPerPhoneAccessTimingTable_A7387 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜连觠賢诤苦꣨裪軬諮苰胲ꇴ黶铸鋺鏼飾唀戂朄欆氈吊䰌㠎∐⬒∔", a_), global::CommonResources.AcgResources.ID_DTMFTIMINGSELECT, null, null, false, false);
			this.cnvPerPhoneAccessTimingTable_A7387.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerPhoneAccessTimingTable_A7387.DataTransferOrder = 20;
			this.cnvPerPhoneAutoAccessCodeSelect_A7503 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜连觠賢诤苦꣨黪駬胮냰郲雴鋶諸裺뻼郾攀昂嘄戆攈渊渌笎丐划∔∖⤘⠚", a_), global::CommonResources.AcgResources.ID_AUTOACCESSCODESELECT, null, null, false, false);
			this.cnvPerPhoneAutoAccessCodeSelect_A7503.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerPhoneAutoAccessCodeSelect_A7503.DataTransferOrder = 82;
			this.cnvPerPhonePhoneOperation_A8703 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜连觠賢诤苦맨菪苬臮铰볲藴鋶诸髺觼雾渀洂娄䘆ㄈ㰊㴌㰎", a_), global::CommonResources.AcgResources.ID_PHONEOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerPhonePhoneOperation_A8703LovStrs);
			this.cnvPerPhonePhoneOperation_A8703.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerPhonePhoneOperation_A8703.DataTransferOrder = 7;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菒뷔룖럘뻚", a_);
			base.Id = 10139;
			base.UIName = global::CommonResources.AcgResources.ID_PHONE;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600C900 RID: 51456 RVA: 0x00BBC6B0 File Offset: 0x00BBA8B0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1685127171;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1F9;
				case 1:
					this.cnvPerPhoneAutoAccessCodeSelect_A7503 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙賛뛝迟賡臣꟥鷧黩菫꿭鏯釱釳藵请맹鏻髽旿儁愃樅洇椉砋儍儏┑ℓ☕⬗", a_), global::CommonResources.AcgResources.ID_AUTOACCESSCODESELECT, null, null, false, false);
					this.cnvPerPhoneAutoAccessCodeSelect_A7503.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerPhoneAutoAccessCodeSelect_A7503.DataTransferOrder = 82;
					num = (short)1366753286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.cnvPerPhoneAccessTimingTable_A7387 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙賛뛝迟賡臣꟥诧觩觫鷭華꛱鷳鯵釷铹鯻꫽懿态栃挅圇䬉㬋㴍⠏┑", a_), global::CommonResources.AcgResources.ID_DTMFTIMINGSELECT, null, null, false, false);
					this.cnvPerPhoneAccessTimingTable_A7387.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerPhoneAccessTimingTable_A7387.DataTransferOrder = 20;
					num = (short)1497301001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙賛뛝迟賡臣꟥诧觩觫鷭華꛱鷳鯵釷铹鯻꫽懿态栃挅圇䬉㬋㴍⠏┑", a_)))
					{
						num = (short)232914946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DE;
				case 5:
				{
					num = (short)547291137;
					if (num != 0)
					{
					}
					if (producerFields == null)
					{
						goto IL_34B;
					}
					num = (short)865334748;
					short num3 = num;
					num = (short)1109259740;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2AA;
					default:
						num = (short)771293184;
						if (num != 0)
						{
						}
						num = (short)936837128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_2AA;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙賛뛝迟賡臣꟥鷧黩菫꿭鏯釱釳藵请맹鏻髽旿儁愃樅洇椉砋儍儏┑ℓ☕⬗", a_)))
					{
						num = (short)1195245569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AA;
				case 8:
				{
					num = (short)625278976;
					short num4 = num;
					num = (short)809304068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_DE;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙賛뛝迟賡臣뛥胧藩苫语뿯英釳蓵駷軹闻釽滿崁䔃㸅㼇㨉㼋", a_)))
					{
						num = (short)1095434251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34B;
				case 11:
					this.cnvPerPhonePhoneOperation_A8703 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙賛뛝迟賡臣뛥胧藩苫语뿯英釳蓵駷軹闻釽滿崁䔃㸅㼇㨉㼋", a_), global::CommonResources.AcgResources.ID_PHONEOPERATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerPhonePhoneOperation_A8703LovStrs);
					this.cnvPerPhonePhoneOperation_A8703.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerPhonePhoneOperation_A8703.DataTransferOrder = 7;
					num = (short)658833408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)714932229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)949288972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DE:
				num = (short)1970470919;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AA:
				num = (short)1737293834;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F9:
			IL_34B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胏뫑믓룕뷗", a_);
			base.Id = 10139;
			base.UIName = global::CommonResources.AcgResources.ID_PHONE;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600C901 RID: 51457 RVA: 0x00BBCA3C File Offset: 0x00BBAC3C
		public override void PopulateReferences()
		{
			short num = (short)624281863;
			short num2 = num;
			num = (short)16042247;
			switch (num2 == num)
			{
			default:
			{
				num = (short)679608320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1301348353;
			if (num != 0)
			{
			}
			num = (short)3604480;
			if (num != 0)
			{
			}
			this.cnvPerPhoneAccessTimingTable_A7387.SetRecset(this.a(2000)[0][10002].EmbeddedRecset);
			this.cnvPerPhoneAutoAccessCodeSelect_A7503.SetRecset(this.a(2000)[0][10000].EmbeddedRecset);
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x00BBCB3C File Offset: 0x00BBAD3C
		public override void DropReferences()
		{
			short num = (short)1645477889;
			if (num != 0)
			{
			}
			num = (short)840302592;
			short num2 = num;
			num = (short)926042869;
			short num3 = num;
			num = (short)1643334389;
			switch (num3 == num)
			{
			}
			num = (short)769654784;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C903 RID: 51459 RVA: 0x00BBCBE8 File Offset: 0x00BBADE8
		public override void SetConstraints()
		{
			short num = (short)1999583558;
			short num2 = num;
			num = (short)604191046;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1094582272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2056847361;
			if (num != 0)
			{
			}
			num = (short)576913408;
			if (num != 0)
			{
			}
			this.cnvPerPhoneAccessTimingTable_A7387.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPhnIntrcntIsNotNoneAndCnvRxOnlyIsDisabled);
			this.cnvPerPhoneAutoAccessCodeSelect_A7503.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPhnIntrcntIsNotNoneAndCnvRxOnlyIsDisabled);
			this.cnvPerPhonePhoneOperation_A8703.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRSISysIsEnabled);
			this.cnvPerPhonePhoneOperation_A8703.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConManAccLiveDialgIsDisabled);
		}

		// Token: 0x0600C904 RID: 51460 RVA: 0x00BBCCF0 File Offset: 0x00BBAEF0
		public override void SetupDependencies()
		{
			short num = (short)1409084861;
			short num2 = num;
			num = (short)1121250749;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1727332352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)183435264;
			if (num != 0)
			{
			}
			num = (short)2056585217;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerPhoneAccessTimingTable_A7387);
			this.cnvPerPhonePhoneOperation_A8703.AddDependentObject(this.cnvPerPhoneAccessTimingTable_A7387);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerPhoneAccessTimingTable_A7387);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerPhoneAccessTimingTable_A7387);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerPhoneAutoAccessCodeSelect_A7503);
			this.cnvPerPhonePhoneOperation_A8703.AddDependentObject(this.cnvPerPhoneAutoAccessCodeSelect_A7503);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerPhoneAutoAccessCodeSelect_A7503);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerPhoneAutoAccessCodeSelect_A7503);
			this.RefPhoneWide.General.PhnWideGeneralManualAccessLiveDialing_A8462.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
			conventionalPersonality.ASTROCall.CnvPerTacticalInhibitKillOperation_A41553.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
			conventionalPersonality.ASTROCall.CnvPerTacticalInhibitStunOperation_A41557.AddDependentObject(this.cnvPerPhonePhoneOperation_A8703);
		}

		// Token: 0x170064D2 RID: 25810
		// (get) Token: 0x0600C905 RID: 51461 RVA: 0x00BBCEFC File Offset: 0x00BBB0FC
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner DTMFTimingInnerSectionForCnvPerPhoneAccessTimingTable_A7387
		{
			get
			{
				short num = (short)93768586;
				short num2 = num;
				num = (short)1943587722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581973504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053753344;
				if (num != 0)
				{
				}
				num = (short)1328152577;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner;
			}
		}

		// Token: 0x170064D3 RID: 25811
		// (get) Token: 0x0600C906 RID: 51462 RVA: 0x00BBCFB8 File Offset: 0x00BBB1B8
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner DTMFCodesInnerSectionForCnvPerPhoneAutoAccessCodeSelect_A7503
		{
			get
			{
				short num = (short)1162969432;
				short num2 = num;
				num = (short)1249739096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1346764800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1056505856;
				if (num != 0)
				{
				}
				num = (short)1109000193;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner;
			}
		}

		// Token: 0x170064D4 RID: 25812
		// (get) Token: 0x0600C907 RID: 51463 RVA: 0x00BBD070 File Offset: 0x00BBB270
		public bool HasDiffs
		{
			get
			{
				short num = (short)788664540;
				short num2 = num;
				num = (short)2101678300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256770048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391708673;
				if (num != 0)
				{
				}
				num = (short)1028063232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170064D5 RID: 25813
		// (get) Token: 0x0600C908 RID: 51464 RVA: 0x00BBD120 File Offset: 0x00BBB320
		// (set) Token: 0x0600C909 RID: 51465 RVA: 0x00BBD1D4 File Offset: 0x00BBB3D4
		public int CnvPerPhoneAccessTimingTable_A7387Value
		{
			get
			{
				short num = (short)182618360;
				short num2 = num;
				num = (short)2110294264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)617086976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1555693569;
				if (num != 0)
				{
				}
				num = (short)1385103360;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.Value;
			}
			set
			{
				short num = (short)1490014668;
				short num2 = num;
				num = (short)161665484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075118080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1747976192;
				if (num != 0)
				{
				}
				num = (short)1559429121;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.Value = value;
			}
		}

		// Token: 0x170064D6 RID: 25814
		// (get) Token: 0x0600C90A RID: 51466 RVA: 0x00BBD288 File Offset: 0x00BBB488
		// (set) Token: 0x0600C90B RID: 51467 RVA: 0x00BBD338 File Offset: 0x00BBB538
		public string CnvPerPhoneAccessTimingTable_A7387_UIValue
		{
			get
			{
				short num = (short)1843387668;
				short num2 = num;
				num = (short)1106763028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298726912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1646002176;
				if (num != 0)
				{
				}
				num = (short)600965121;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.UIValue;
			}
			set
			{
				short num = (short)1845336198;
				short num2 = num;
				num = (short)1101764742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373030912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146500609;
				if (num != 0)
				{
				}
				num = (short)1477705728;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.UIValue = value;
			}
		}

		// Token: 0x170064D7 RID: 25815
		// (get) Token: 0x0600C90C RID: 51468 RVA: 0x00BBD3EC File Offset: 0x00BBB5EC
		public global::AcpBusinessLayer.AcpRecRefField CnvPerPhoneAccessTimingTable_A7387
		{
			get
			{
				short num = (short)877740520;
				short num2 = num;
				num = (short)329269736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1875640320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)932642817;
				if (num != 0)
				{
				}
				num = (short)1850736640;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387;
			}
		}

		// Token: 0x170064D8 RID: 25816
		// (get) Token: 0x0600C90D RID: 51469 RVA: 0x00BBD49C File Offset: 0x00BBB69C
		// (set) Token: 0x0600C90E RID: 51470 RVA: 0x00BBD550 File Offset: 0x00BBB750
		public bool CnvPerPhoneAccessTimingTable_A7387_Applicable
		{
			get
			{
				short num = (short)1702363137;
				if (num != 0)
				{
				}
				num = (short)88801280;
				short num2 = num;
				num = (short)224762633;
				short num3 = num;
				num = (short)1577032457;
				switch (num3 == num)
				{
				}
				num = (short)370933760;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.Applicable;
			}
			set
			{
				short num = (short)2143617025;
				if (num != 0)
				{
				}
				num = (short)742850560;
				short num2 = num;
				num = (short)2003548966;
				short num3 = num;
				num = (short)2005252902;
				switch (num3 == num)
				{
				}
				num = (short)1796341760;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.Applicable = value;
			}
		}

		// Token: 0x170064D9 RID: 25817
		// (get) Token: 0x0600C90F RID: 51471 RVA: 0x00BBD608 File Offset: 0x00BBB808
		// (set) Token: 0x0600C910 RID: 51472 RVA: 0x00BBD6BC File Offset: 0x00BBB8BC
		public bool CnvPerPhoneAccessTimingTable_A7387_Valid
		{
			get
			{
				short num = (short)1860250688;
				short num2 = num;
				num = (short)1826958400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758841344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262354432;
				if (num != 0)
				{
				}
				num = (short)903806977;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.Valid;
			}
			set
			{
				short num = (short)45185246;
				short num2 = num;
				num = (short)1596881118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)470089728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1887371265;
				if (num != 0)
				{
				}
				num = (short)1621950464;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.Valid = value;
			}
		}

		// Token: 0x170064DA RID: 25818
		// (get) Token: 0x0600C911 RID: 51473 RVA: 0x00BBD770 File Offset: 0x00BBB970
		// (set) Token: 0x0600C912 RID: 51474 RVA: 0x00BBD824 File Offset: 0x00BBBA24
		public bool CnvPerPhoneAccessTimingTable_A7387_Visible
		{
			get
			{
				short num = (short)1715381080;
				short num2 = num;
				num = (short)1120379736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)968163328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)578158593;
				if (num != 0)
				{
				}
				num = (short)795344896;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.Visible;
			}
			set
			{
				short num = (short)1494810625;
				if (num != 0)
				{
				}
				num = (short)506593280;
				short num2 = num;
				num = (short)1244139384;
				short num3 = num;
				num = (short)542838648;
				switch (num3 == num)
				{
				}
				num = (short)550240256;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.Visible = value;
			}
		}

		// Token: 0x170064DB RID: 25819
		// (get) Token: 0x0600C913 RID: 51475 RVA: 0x00BBD8DC File Offset: 0x00BBBADC
		// (set) Token: 0x0600C914 RID: 51476 RVA: 0x00BBD98C File Offset: 0x00BBBB8C
		public bool CnvPerPhoneAccessTimingTable_A7387_Editable
		{
			get
			{
				short num = (short)544407553;
				if (num != 0)
				{
				}
				num = (short)1442316288;
				short num2 = num;
				num = (short)51140222;
				short num3 = num;
				num = (short)836654718;
				switch (num3 == num)
				{
				}
				num = (short)1511587840;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.Editable;
			}
			set
			{
				short num = (short)624407235;
				short num2 = num;
				num = (short)1700573891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687538176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781778945;
				if (num != 0)
				{
				}
				num = (short)1099628544;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.Editable = value;
			}
		}

		// Token: 0x170064DC RID: 25820
		// (get) Token: 0x0600C915 RID: 51477 RVA: 0x00BBDA40 File Offset: 0x00BBBC40
		internal string CnvPerPhoneAccessTimingTable_A7387_UILabel
		{
			get
			{
				short num = (short)460624149;
				short num2 = num;
				num = (short)1285984533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216989696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)443940865;
				if (num != 0)
				{
				}
				num = (short)882835456;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.UIName;
			}
		}

		// Token: 0x170064DD RID: 25821
		// (get) Token: 0x0600C916 RID: 51478 RVA: 0x00BBDAF4 File Offset: 0x00BBBCF4
		// (set) Token: 0x0600C917 RID: 51479 RVA: 0x00BBDBA8 File Offset: 0x00BBBDA8
		internal bool CnvPerPhoneAccessTimingTable_A7387_HiddenStatic
		{
			get
			{
				short num = (short)996460541;
				short num2 = num;
				num = (short)259115005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)104857600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)429391873;
				if (num != 0)
				{
				}
				num = (short)2115829760;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.HiddenStatic;
			}
			set
			{
				short num = (short)2003744288;
				short num2 = num;
				num = (short)1954723360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1888747520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760020992;
				if (num != 0)
				{
				}
				num = (short)1570832385;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.HiddenStatic = value;
			}
		}

		// Token: 0x170064DE RID: 25822
		// (get) Token: 0x0600C918 RID: 51480 RVA: 0x00BBDC60 File Offset: 0x00BBBE60
		// (set) Token: 0x0600C919 RID: 51481 RVA: 0x00BBDD14 File Offset: 0x00BBBF14
		internal bool CnvPerPhoneAccessTimingTable_A7387_HiddenDynamic
		{
			get
			{
				short num = (short)1914216349;
				short num2 = num;
				num = (short)2096996253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447283200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2047541249;
				if (num != 0)
				{
				}
				num = (short)577765376;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387.HiddenDynamic;
			}
			set
			{
				short num = (short)597693790;
				short num2 = num;
				num = (short)98178398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76021760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1793392640;
				if (num != 0)
				{
				}
				num = (short)933036033;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAccessTimingTable_A7387.HiddenDynamic = value;
			}
		}

		// Token: 0x170064DF RID: 25823
		// (get) Token: 0x0600C91A RID: 51482 RVA: 0x00BBDDC8 File Offset: 0x00BBBFC8
		public bool CnvPerPhoneAccessTimingTable_A7387_HasDiffs
		{
			get
			{
				short num = (short)25987496;
				short num2 = num;
				num = (short)681085352;
				switch (num2 == num)
				{
				}
				num = (short)914292736;
				short num3 = num;
				num = (short)1831731200;
				if (num != 0)
				{
				}
				num = (short)1538392065;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAccessTimingTable_A7387._HasDiffs;
			}
		}

		// Token: 0x170064E0 RID: 25824
		// (get) Token: 0x0600C91B RID: 51483 RVA: 0x00BBDE80 File Offset: 0x00BBC080
		// (set) Token: 0x0600C91C RID: 51484 RVA: 0x00BBDF34 File Offset: 0x00BBC134
		public int CnvPerPhoneAutoAccessCodeSelect_A7503Value
		{
			get
			{
				short num = (short)1587860410;
				short num2 = num;
				num = (short)401658810;
				switch (num2 == num)
				{
				}
				num = (short)1128333312;
				short num3 = num;
				num = (short)2065301505;
				if (num != 0)
				{
				}
				num = (short)2120417280;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.Value;
			}
			set
			{
				short num = (short)1077413038;
				short num2 = num;
				num = (short)1177224366;
				switch (num2 == num)
				{
				}
				num = (short)205062144;
				short num3 = num;
				num = (short)133431296;
				if (num != 0)
				{
				}
				num = (short)1843200001;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.Value = value;
			}
		}

		// Token: 0x170064E1 RID: 25825
		// (get) Token: 0x0600C91D RID: 51485 RVA: 0x00BBDFE8 File Offset: 0x00BBC1E8
		// (set) Token: 0x0600C91E RID: 51486 RVA: 0x00BBE09C File Offset: 0x00BBC29C
		public string CnvPerPhoneAutoAccessCodeSelect_A7503_UIValue
		{
			get
			{
				short num = (short)1291408407;
				short num2 = num;
				num = (short)2142655511;
				switch (num2 == num)
				{
				}
				num = (short)987627520;
				short num3 = num;
				num = (short)426311680;
				if (num != 0)
				{
				}
				num = (short)441974785;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.UIValue;
			}
			set
			{
				short num = (short)800456705;
				if (num != 0)
				{
				}
				num = (short)695822848;
				short num2 = num;
				num = (short)1464822272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)842989568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1360265216;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.UIValue = value;
			}
		}

		// Token: 0x170064E2 RID: 25826
		// (get) Token: 0x0600C91F RID: 51487 RVA: 0x00BBE158 File Offset: 0x00BBC358
		public global::AcpBusinessLayer.AcpRecRefField CnvPerPhoneAutoAccessCodeSelect_A7503
		{
			get
			{
				short num = (short)776470529;
				if (num != 0)
				{
				}
				num = (short)932083699;
				short num2 = num;
				num = (short)407271411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1547894784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2012938240;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503;
			}
		}

		// Token: 0x170064E3 RID: 25827
		// (get) Token: 0x0600C920 RID: 51488 RVA: 0x00BBE208 File Offset: 0x00BBC408
		// (set) Token: 0x0600C921 RID: 51489 RVA: 0x00BBE2C0 File Offset: 0x00BBC4C0
		public bool CnvPerPhoneAutoAccessCodeSelect_A7503_Applicable
		{
			get
			{
				short num = (short)1276706817;
				if (num != 0)
				{
				}
				num = (short)1937927763;
				short num2 = num;
				num = (short)1202482771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)496959488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)350617600;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.Applicable;
			}
			set
			{
				short num = (short)731260963;
				short num2 = num;
				num = (short)1673668643;
				switch (num2 == num)
				{
				}
				num = (short)1415970816;
				short num3 = num;
				num = (short)361562112;
				if (num != 0)
				{
				}
				num = (short)77201409;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.Applicable = value;
			}
		}

		// Token: 0x170064E4 RID: 25828
		// (get) Token: 0x0600C922 RID: 51490 RVA: 0x00BBE374 File Offset: 0x00BBC574
		// (set) Token: 0x0600C923 RID: 51491 RVA: 0x00BBE428 File Offset: 0x00BBC628
		public bool CnvPerPhoneAutoAccessCodeSelect_A7503_Valid
		{
			get
			{
				short num = (short)754450433;
				if (num != 0)
				{
				}
				num = (short)227716563;
				short num2 = num;
				num = (short)2064297427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)283967488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063728640;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.Valid;
			}
			set
			{
				short num = (short)813474756;
				short num2 = num;
				num = (short)1349034948;
				switch (num2 == num)
				{
				}
				num = (short)242221056;
				short num3 = num;
				num = (short)694419456;
				if (num != 0)
				{
				}
				num = (short)1537409025;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.Valid = value;
			}
		}

		// Token: 0x170064E5 RID: 25829
		// (get) Token: 0x0600C924 RID: 51492 RVA: 0x00BBE4E0 File Offset: 0x00BBC6E0
		// (set) Token: 0x0600C925 RID: 51493 RVA: 0x00BBE598 File Offset: 0x00BBC798
		public bool CnvPerPhoneAutoAccessCodeSelect_A7503_Visible
		{
			get
			{
				short num = (short)140142646;
				short num2 = num;
				num = (short)188114998;
				switch (num2 == num)
				{
				}
				num = (short)2097676288;
				short num3 = num;
				num = (short)122159104;
				if (num != 0)
				{
				}
				num = (short)1866989569;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.Visible;
			}
			set
			{
				short num = (short)714888759;
				short num2 = num;
				num = (short)1601852983;
				switch (num2 == num)
				{
				}
				num = (short)589692928;
				short num3 = num;
				num = (short)1365508096;
				if (num != 0)
				{
				}
				num = (short)1408106497;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.Visible = value;
			}
		}

		// Token: 0x170064E6 RID: 25830
		// (get) Token: 0x0600C926 RID: 51494 RVA: 0x00BBE650 File Offset: 0x00BBC850
		// (set) Token: 0x0600C927 RID: 51495 RVA: 0x00BBE704 File Offset: 0x00BBC904
		public bool CnvPerPhoneAutoAccessCodeSelect_A7503_Editable
		{
			get
			{
				short num = (short)1598670614;
				short num2 = num;
				num = (short)563988246;
				switch (num2 == num)
				{
				}
				num = (short)1435959296;
				short num3 = num;
				num = (short)1698299905;
				if (num != 0)
				{
				}
				num = (short)955121664;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.Editable;
			}
			set
			{
				short num = (short)1219633015;
				short num2 = num;
				num = (short)1010704247;
				switch (num2 == num)
				{
				}
				num = (short)416612352;
				short num3 = num;
				num = (short)36110337;
				if (num != 0)
				{
				}
				num = (short)254935040;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.Editable = value;
			}
		}

		// Token: 0x170064E7 RID: 25831
		// (get) Token: 0x0600C928 RID: 51496 RVA: 0x00BBE7BC File Offset: 0x00BBC9BC
		internal string CnvPerPhoneAutoAccessCodeSelect_A7503_UILabel
		{
			get
			{
				short num = (short)1771568760;
				short num2 = num;
				num = (short)473628280;
				switch (num2 == num)
				{
				}
				num = (short)1154023424;
				short num3 = num;
				num = (short)1964638208;
				if (num != 0)
				{
				}
				num = (short)361824257;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.UIName;
			}
		}

		// Token: 0x170064E8 RID: 25832
		// (get) Token: 0x0600C929 RID: 51497 RVA: 0x00BBE870 File Offset: 0x00BBCA70
		// (set) Token: 0x0600C92A RID: 51498 RVA: 0x00BBE928 File Offset: 0x00BBCB28
		internal bool CnvPerPhoneAutoAccessCodeSelect_A7503_HiddenStatic
		{
			get
			{
				short num = (short)1325940489;
				short num2 = num;
				num = (short)936787721;
				switch (num2 == num)
				{
				}
				num = (short)2082471936;
				short num3 = num;
				num = (short)125042689;
				if (num != 0)
				{
				}
				num = (short)329646080;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.HiddenStatic;
			}
			set
			{
				short num = (short)1874392294;
				short num2 = num;
				num = (short)1289680102;
				switch (num2 == num)
				{
				}
				num = (short)385089536;
				short num3 = num;
				num = (short)1684537345;
				if (num != 0)
				{
				}
				num = (short)214499328;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.HiddenStatic = value;
			}
		}

		// Token: 0x170064E9 RID: 25833
		// (get) Token: 0x0600C92B RID: 51499 RVA: 0x00BBE9E0 File Offset: 0x00BBCBE0
		// (set) Token: 0x0600C92C RID: 51500 RVA: 0x00BBEA90 File Offset: 0x00BBCC90
		internal bool CnvPerPhoneAutoAccessCodeSelect_A7503_HiddenDynamic
		{
			get
			{
				short num = (short)1414326;
				short num2 = num;
				num = (short)1818924214;
				switch (num2 == num)
				{
				}
				num = (short)949354496;
				short num3 = num;
				num = (short)324141057;
				if (num != 0)
				{
				}
				num = (short)2038628352;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503.HiddenDynamic;
			}
			set
			{
				short num = (short)1395723482;
				short num2 = num;
				num = (short)1282739418;
				switch (num2 == num)
				{
				}
				num = (short)1852506112;
				short num3 = num;
				num = (short)1952841728;
				if (num != 0)
				{
				}
				num = (short)1024327681;
				if (num != 0)
				{
				}
				this.cnvPerPhoneAutoAccessCodeSelect_A7503.HiddenDynamic = value;
			}
		}

		// Token: 0x170064EA RID: 25834
		// (get) Token: 0x0600C92D RID: 51501 RVA: 0x00BBEB48 File Offset: 0x00BBCD48
		public bool CnvPerPhoneAutoAccessCodeSelect_A7503_HasDiffs
		{
			get
			{
				short num = (short)1739835721;
				short num2 = num;
				num = (short)229624137;
				switch (num2 == num)
				{
				}
				num = (short)1151139840;
				short num3 = num;
				num = (short)2069233664;
				if (num != 0)
				{
				}
				num = (short)1473314817;
				if (num != 0)
				{
				}
				return this.cnvPerPhoneAutoAccessCodeSelect_A7503._HasDiffs;
			}
		}

		// Token: 0x170064EB RID: 25835
		// (get) Token: 0x0600C92E RID: 51502 RVA: 0x00BBEBFC File Offset: 0x00BBCDFC
		// (set) Token: 0x0600C92F RID: 51503 RVA: 0x00BBECB0 File Offset: 0x00BBCEB0
		public int CnvPerPhonePhoneOperation_A8703Value
		{
			get
			{
				short num = (short)1436268135;
				short num2 = num;
				num = (short)1752151655;
				switch (num2 == num)
				{
				}
				num = (short)1689976832;
				short num3 = num;
				num = (short)1872166912;
				if (num != 0)
				{
				}
				num = (short)43778049;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.Value;
			}
			set
			{
				short num = (short)1224441783;
				short num2 = num;
				num = (short)500400055;
				switch (num2 == num)
				{
				}
				num = (short)1770979328;
				short num3 = num;
				num = (short)1015283713;
				if (num != 0)
				{
				}
				num = (short)1192558592;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.Value = value;
			}
		}

		// Token: 0x170064EC RID: 25836
		// (get) Token: 0x0600C930 RID: 51504 RVA: 0x00BBED68 File Offset: 0x00BBCF68
		// (set) Token: 0x0600C931 RID: 51505 RVA: 0x00BBEE1C File Offset: 0x00BBD01C
		public string CnvPerPhonePhoneOperation_A8703_UIValue
		{
			get
			{
				short num = (short)1387122226;
				short num2 = num;
				num = (short)644927026;
				switch (num2 == num)
				{
				}
				num = (short)41222144;
				short num3 = num;
				num = (short)882704385;
				if (num != 0)
				{
				}
				num = (short)1506148352;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.UIValue;
			}
			set
			{
				short num = (short)1392953682;
				short num2 = num;
				num = (short)1821821266;
				switch (num2 == num)
				{
				}
				num = (short)1281884160;
				short num3 = num;
				num = (short)143982593;
				if (num != 0)
				{
				}
				num = (short)1644429312;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.UIValue = value;
			}
		}

		// Token: 0x170064ED RID: 25837
		// (get) Token: 0x0600C932 RID: 51506 RVA: 0x00BBEED4 File Offset: 0x00BBD0D4
		public global::AcpBusinessLayer.AcpListField CnvPerPhonePhoneOperation_A8703
		{
			get
			{
				short num = (short)249622773;
				short num2 = num;
				num = (short)1149628661;
				switch (num2 == num)
				{
				}
				num = (short)1028521984;
				short num3 = num;
				num = (short)1015742465;
				if (num != 0)
				{
				}
				num = (short)687144960;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703;
			}
		}

		// Token: 0x170064EE RID: 25838
		// (get) Token: 0x0600C933 RID: 51507 RVA: 0x00BBEF88 File Offset: 0x00BBD188
		// (set) Token: 0x0600C934 RID: 51508 RVA: 0x00BBF03C File Offset: 0x00BBD23C
		public bool CnvPerPhonePhoneOperation_A8703_Applicable
		{
			get
			{
				short num = (short)1921455464;
				short num2 = num;
				num = (short)239342952;
				switch (num2 == num)
				{
				}
				num = (short)1729757184;
				short num3 = num;
				num = (short)1110114305;
				if (num != 0)
				{
				}
				num = (short)1943797760;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.Applicable;
			}
			set
			{
				short num = (short)566755329;
				if (num != 0)
				{
				}
				num = (short)1197298354;
				short num2 = num;
				num = (short)412832434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1783169024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)571211776;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.Applicable = value;
			}
		}

		// Token: 0x170064EF RID: 25839
		// (get) Token: 0x0600C935 RID: 51509 RVA: 0x00BBF0F4 File Offset: 0x00BBD2F4
		// (set) Token: 0x0600C936 RID: 51510 RVA: 0x00BBF1AC File Offset: 0x00BBD3AC
		public bool CnvPerPhonePhoneOperation_A8703_Valid
		{
			get
			{
				short num = (short)1221358639;
				short num2 = num;
				num = (short)1742107695;
				switch (num2 == num)
				{
				}
				num = (short)1364328448;
				short num3 = num;
				num = (short)1019674625;
				if (num != 0)
				{
				}
				num = (short)67895296;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.Valid;
			}
			set
			{
				short num = (short)1957232291;
				short num2 = num;
				num = (short)1227488931;
				switch (num2 == num)
				{
				}
				num = (short)1597440000;
				short num3 = num;
				num = (short)1439760385;
				if (num != 0)
				{
				}
				num = (short)366673920;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.Valid = value;
			}
		}

		// Token: 0x170064F0 RID: 25840
		// (get) Token: 0x0600C937 RID: 51511 RVA: 0x00BBF260 File Offset: 0x00BBD460
		// (set) Token: 0x0600C938 RID: 51512 RVA: 0x00BBF314 File Offset: 0x00BBD514
		public bool CnvPerPhonePhoneOperation_A8703_Visible
		{
			get
			{
				short num = (short)1577346246;
				short num2 = num;
				num = (short)1788634310;
				switch (num2 == num)
				{
				}
				num = (short)934346752;
				short num3 = num;
				num = (short)1114701824;
				if (num != 0)
				{
				}
				num = (short)1854734337;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.Visible;
			}
			set
			{
				short num = (short)125108490;
				short num2 = num;
				num = (short)1803223306;
				switch (num2 == num)
				{
				}
				num = (short)668729344;
				short num3 = num;
				num = (short)420282369;
				if (num != 0)
				{
				}
				num = (short)1543897088;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.Visible = value;
			}
		}

		// Token: 0x170064F1 RID: 25841
		// (get) Token: 0x0600C939 RID: 51513 RVA: 0x00BBF3C8 File Offset: 0x00BBD5C8
		// (set) Token: 0x0600C93A RID: 51514 RVA: 0x00BBF47C File Offset: 0x00BBD67C
		public bool CnvPerPhonePhoneOperation_A8703_Editable
		{
			get
			{
				short num = (short)1614451924;
				short num2 = num;
				num = (short)748393684;
				switch (num2 == num)
				{
				}
				num = (short)321650688;
				short num3 = num;
				num = (short)1854013441;
				if (num != 0)
				{
				}
				num = (short)1120796672;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.Editable;
			}
			set
			{
				short num = (short)795122089;
				short num2 = num;
				num = (short)1261214121;
				switch (num2 == num)
				{
				}
				num = (short)278069248;
				short num3 = num;
				num = (short)1338638336;
				if (num != 0)
				{
				}
				num = (short)1348337665;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.Editable = value;
			}
		}

		// Token: 0x170064F2 RID: 25842
		// (get) Token: 0x0600C93B RID: 51515 RVA: 0x00BBF530 File Offset: 0x00BBD730
		internal string CnvPerPhonePhoneOperation_A8703_UILabel
		{
			get
			{
				short num = (short)369491969;
				if (num != 0)
				{
				}
				num = (short)1714018398;
				short num2 = num;
				num = (short)249354334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)841089024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)392560640;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.UIName;
			}
		}

		// Token: 0x170064F3 RID: 25843
		// (get) Token: 0x0600C93C RID: 51516 RVA: 0x00BBF5E4 File Offset: 0x00BBD7E4
		// (set) Token: 0x0600C93D RID: 51517 RVA: 0x00BBF698 File Offset: 0x00BBD898
		internal bool CnvPerPhonePhoneOperation_A8703_HiddenStatic
		{
			get
			{
				short num = (short)1417888225;
				short num2 = num;
				num = (short)1545486817;
				switch (num2 == num)
				{
				}
				num = (short)1327824896;
				short num3 = num;
				num = (short)790364160;
				if (num != 0)
				{
				}
				num = (short)842989569;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.HiddenStatic;
			}
			set
			{
				short num = (short)646753694;
				short num2 = num;
				num = (short)1076931998;
				switch (num2 == num)
				{
				}
				num = (short)963510272;
				short num3 = num;
				num = (short)1531641857;
				if (num != 0)
				{
				}
				num = (short)384958464;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.HiddenStatic = value;
			}
		}

		// Token: 0x170064F4 RID: 25844
		// (get) Token: 0x0600C93E RID: 51518 RVA: 0x00BBF74C File Offset: 0x00BBD94C
		// (set) Token: 0x0600C93F RID: 51519 RVA: 0x00BBF804 File Offset: 0x00BBDA04
		internal bool CnvPerPhonePhoneOperation_A8703_HiddenDynamic
		{
			get
			{
				short num = (short)2123893805;
				short num2 = num;
				num = (short)1249053741;
				switch (num2 == num)
				{
				}
				num = (short)703201280;
				short num3 = num;
				num = (short)544079873;
				if (num != 0)
				{
				}
				num = (short)421462016;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703.HiddenDynamic;
			}
			set
			{
				short num = (short)1234121952;
				short num2 = num;
				num = (short)1776628960;
				switch (num2 == num)
				{
				}
				num = (short)1809580032;
				short num3 = num;
				num = (short)264503296;
				if (num != 0)
				{
				}
				num = (short)123797505;
				if (num != 0)
				{
				}
				this.cnvPerPhonePhoneOperation_A8703.HiddenDynamic = value;
			}
		}

		// Token: 0x170064F5 RID: 25845
		// (get) Token: 0x0600C940 RID: 51520 RVA: 0x00BBF8B8 File Offset: 0x00BBDAB8
		public bool CnvPerPhonePhoneOperation_A8703_HasDiffs
		{
			get
			{
				short num = (short)1501784012;
				short num2 = num;
				num = (short)1123837900;
				switch (num2 == num)
				{
				}
				num = (short)1541865472;
				short num3 = num;
				num = (short)980221952;
				if (num != 0)
				{
				}
				num = (short)302579713;
				if (num != 0)
				{
				}
				return this.cnvPerPhonePhoneOperation_A8703._HasDiffs;
			}
		}

		// Token: 0x170064F6 RID: 25846
		// (get) Token: 0x0600C941 RID: 51521 RVA: 0x00BBF970 File Offset: 0x00BBDB70
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PhoneWide RefPhoneWide
		{
			get
			{
				short num = (short)433939744;
				short num2 = num;
				num = (short)143615264;
				switch (num2 == num)
				{
				}
				num = (short)770375680;
				short num3 = num;
				num = (short)530186240;
				if (num != 0)
				{
				}
				num = (short)1827995649;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2000)[0] as global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PhoneWide;
			}
		}

		// Token: 0x170064F7 RID: 25847
		// (get) Token: 0x0600C942 RID: 51522 RVA: 0x00BBFA30 File Offset: 0x00BBDC30
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1604594226;
				short num2 = num;
				num = (short)616245810;
				switch (num2 == num)
				{
				}
				num = (short)1569652736;
				short num3 = num;
				num = (short)2082340865;
				if (num != 0)
				{
				}
				num = (short)1275461632;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x00BBFAF0 File Offset: 0x00BBDCF0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_122;
				case 1:
					num2 = (short)1693450241;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)1191444483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1746206724;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)60096514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_160;
				}
				goto IL_24;
			}
			IL_122:
			return result;
			IL_160:
			result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
			goto IL_10B;
			IL_24:
			result = null;
			num2 = (short)1129250816;
			short num3 = num2;
			num2 = (short)597039557;
			short num4 = num2;
			num2 = (short)1459755461;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_10B:
				num2 = (short)1668677632;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)535691264;
				if (num2 != 0)
				{
				}
				num2 = (short)1306198017;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040064C7 RID: 25799
		private global::AcpBusinessLayer.AcpRecRefField cnvPerPhoneAccessTimingTable_A7387;

		// Token: 0x040064C8 RID: 25800
		private global::AcpBusinessLayer.AcpRecRefField cnvPerPhoneAutoAccessCodeSelect_A7503;

		// Token: 0x040064C9 RID: 25801
		private global::AcpBusinessLayer.AcpListField cnvPerPhonePhoneOperation_A8703;
	}
}
