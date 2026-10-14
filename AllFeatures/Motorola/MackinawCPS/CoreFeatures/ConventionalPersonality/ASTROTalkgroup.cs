using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x0200057A RID: 1402
	[global::System.Serializable]
	public class ASTROTalkgroup : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C0E1 RID: 49377 RVA: 0x00B1DC60 File Offset: 0x00B1BE60
		public ASTROTalkgroup(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C0E2 RID: 49378 RVA: 0x00B1DC7C File Offset: 0x00B1BE7C
		protected ASTROTalkgroup(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x00B1DC94 File Offset: 0x00B1BE94
		public override void Init()
		{
			int a_ = 5;
			short num = (short)177259712;
			short num2 = num;
			num = (short)255837376;
			switch (num2 == num)
			{
			}
			num = (short)2009726976;
			if (num != 0)
			{
			}
			num = (short)988610560;
			short num3 = num;
			num = (short)1338638337;
			if (num != 0)
			{
			}
			this.cnvPerASTROTalkgroupOptionsSelectionType_A9112 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙裛뿝賟觡菣铥蟧鿩鳫ꇭ胯蛱鷳駵雷觹꿻鯽泿朁會爅愇攉戋娍椏我焓䤕夗⌙ⴛ⼝ሟ", a_), global::CommonResources.AcgResources.ID_SELECTIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROTalkgroupOptionsSelectionType_A9112LovStrs);
			this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.DataTransferOrder = 59;
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙裛뿝賟觡菣铥蟧鿩鳫ꇭ胯蛱鷳駵雷觹ꣻ鿽泿椁䌃琅朇缉簋䬍縏猑瘓稕紗䔙崛✝ሟᔡᘣ", a_), global::CommonResources.AcgResources.ID_TALKGROUP);
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.DataTransferOrder = 52;
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.EvaluateRecRefs = true;
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑蟓苕諗闙裛뿝賟觡菣铥蟧鿩鳫ꇭ胯蛱鷳駵雷觹ꣻ鿽泿椁挃琅朇缉簋䈍礏愑怓䤕夗⌙⸛☝ጟ", a_), global::CommonResources.AcgResources.ID_TALKGROUPLIST, null, null, true, false);
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.DataTransferOrder = 56;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟅鯇黉黋臍蛑뗓뫕돗뷙껛뇝闟鋡", a_);
			base.Id = 10147;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROTALKGROUP;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x00B1DE38 File Offset: 0x00B1C038
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1268056076;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)283639809;
					if (num != 0)
					{
					}
					this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜點닠럢럤꣦뷨諪臬蓮雰臲髴苶觸듺跼课栀氂欄理崈樊愌搎嘐愒稔或椘帚猜縞䌠伢䀤砦栨ሪἬᠮ̰", a_), global::CommonResources.AcgResources.ID_TALKGROUP);
					this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.DataTransferOrder = 52;
					this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.EvaluateRecRefs = true;
					num = (short)1646526468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_249;
				case 2:
					num = (short)1114505224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜點닠럢럤꣦뷨諪臬蓮雰臲髴苶觸듺跼课栀氂欄理崈樊愌搎瘐愒稔或椘圚琜氞唠簢搤ḦᬨጪḬ", a_)))
					{
						num = (short)1424162823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				case 4:
					goto IL_2B1;
				case 5:
					num = (short)429326346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.cnvPerASTROTalkgroupOptionsSelectionType_A9112 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜點닠럢럤꣦뷨諪臬蓮雰臲髴苶觸듺跼课栀氂欄理娈渊愌樎爐朒簔砖眘会搜漞䐠簢搤ḦᠨᨪἬ", a_), global::CommonResources.AcgResources.ID_SELECTIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerASTROTalkgroupOptionsSelectionType_A9112LovStrs);
					this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.DataTransferOrder = 59;
					num = (short)2023030793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜點닠럢럤꣦뷨諪臬蓮雰臲髴苶觸듺跼课栀氂欄理崈樊愌搎瘐愒稔或椘圚琜氞唠簢搤ḦᬨጪḬ", a_), global::CommonResources.AcgResources.ID_TALKGROUPLIST, null, null, true, false);
					this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.DataTransferOrder = 56;
					num = (short)1409875969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜點닠럢럤꣦뷨諪臬蓮雰臲髴苶觸듺跼课栀氂欄理娈渊愌樎爐朒簔砖眘会搜漞䐠簢搤ḦᠨᨪἬ", a_)))
					{
						num = (short)1024720902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
				case 9:
					goto IL_135;
				case 10:
					goto IL_28D;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ觘뻚꿜點닠럢럤꣦뷨諪臬蓮雰臲髴苶觸듺跼课栀氂欄理崈樊愌搎嘐愒稔或椘帚猜縞䌠伢䀤砦栨ሪἬᠮ̰", a_)))
					{
						num = (short)301531136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B1;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				num = (short)312428527;
				short num3 = num;
				num = (short)477054959;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_28D:
					if (producerFields != null)
					{
						num = (short)595853314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				default:
					num = (short)1047920640;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)734461957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				}
				IL_135:
				num = (short)1187643403;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B1:
				num = (short)1173159939;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_249:
			num = (short)108462080;
			short num4 = num;
			IL_358:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋒蛔菖诘铚﷜诞胠迢軤胦鯨蓪飬鿮", a_);
			base.Id = 10147;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROTALKGROUP;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x00B1E1D0 File Offset: 0x00B1C3D0
		public override void PopulateReferences()
		{
			short num = (short)1276725172;
			short num2 = num;
			num = (short)1215317940;
			switch (num2 == num)
			{
			}
			num = (short)212598784;
			if (num != 0)
			{
			}
			num = (short)191037441;
			if (num != 0)
			{
			}
			num = (short)1183383552;
			short num3 = num;
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.SetRecset(this.a(2062));
			this.b();
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x00B1E298 File Offset: 0x00B1C498
		public override void DropReferences()
		{
			short num = (short)728204809;
			short num2 = num;
			num = (short)1309836809;
			switch (num2 == num)
			{
			}
			num = (short)1572601857;
			if (num != 0)
			{
			}
			num = (short)1268056064;
			if (num != 0)
			{
			}
			num = (short)1275461632;
			short num3 = num;
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x00B1E344 File Offset: 0x00B1C544
		public override void SetConstraints()
		{
			short num = (short)1774711738;
			short num2 = num;
			num = (short)142865338;
			switch (num2 == num)
			{
			}
			num = (short)203816961;
			if (num != 0)
			{
			}
			num = (short)362545152;
			if (num != 0)
			{
			}
			num = (short)836763648;
			short num3 = num;
			this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAstroRxSigEnabledAndCnvTlkGrpEnIsEnabled);
			this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRSISysAndTkGrpIsDisabled);
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conTgEnabledWhenDvrsOperEnabledAndInvalidWhenTgEnabledIsAndRxVoiceSignlTypeIsNonAstro);
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAstroRxSigEnabledAndCnvTlkGrpEnIsEnabled);
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsConvTgValid);
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFieldsEditabilityByZoneClone);
			this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSetTgrpAliasTxtRecRef);
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x00B1E4A4 File Offset: 0x00B1C6A4
		public override void SetupDependencies()
		{
			short num = (short)1231895277;
			short num2 = num;
			num = (short)555825901;
			switch (num2 == num)
			{
			}
			num = (short)1107230720;
			if (num != 0)
			{
			}
			num = (short)1175388161;
			if (num != 0)
			{
			}
			num = (short)23855104;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROTalkgroupOptionsSelectionType_A9112);
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerASTROTalkgroupOptionsSelectionType_A9112);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
			conventionalPersonality.General.CnvPerGeneralTalkgroupTextList_A19822.AddDependentObject(this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283);
		}

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x0600C0E9 RID: 49385 RVA: 0x00B1E664 File Offset: 0x00B1C864
		public global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList ASTROTalkgroupListForCnvPerASTROTalkgroupOptionsTalkgroupList_A9283
		{
			get
			{
				short num = (short)1500232769;
				short num2 = num;
				num = (short)1313586241;
				switch (num2 == num)
				{
				}
				num = (short)221380608;
				if (num != 0)
				{
				}
				num = (short)504561665;
				if (num != 0)
				{
				}
				num = (short)1889468416;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList;
			}
		}

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x00B1E720 File Offset: 0x00B1C920
		public bool HasDiffs
		{
			get
			{
				short num = (short)1622162291;
				short num2 = num;
				num = (short)496515955;
				switch (num2 == num)
				{
				}
				num = (short)1511784448;
				if (num != 0)
				{
				}
				num = (short)1945632769;
				if (num != 0)
				{
				}
				num = (short)23658496;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x0600C0EB RID: 49387 RVA: 0x00B1E7D4 File Offset: 0x00B1C9D4
		// (set) Token: 0x0600C0EC RID: 49388 RVA: 0x00B1E888 File Offset: 0x00B1CA88
		public int CnvPerASTROTalkgroupOptionsSelectionType_A9112Value
		{
			get
			{
				short num = (short)1657443137;
				short num2 = num;
				num = (short)732140353;
				switch (num2 == num)
				{
				}
				num = (short)1363410945;
				if (num != 0)
				{
				}
				num = (short)1700855808;
				if (num != 0)
				{
				}
				num = (short)1425473536;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Value;
			}
			set
			{
				short num = (short)500891649;
				if (num != 0)
				{
				}
				num = (short)94387014;
				short num2 = num;
				num = (short)1227373382;
				switch (num2 == num)
				{
				}
				num = (short)1139802112;
				if (num != 0)
				{
				}
				num = (short)1566244864;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Value = value;
			}
		}

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x0600C0ED RID: 49389 RVA: 0x00B1E93C File Offset: 0x00B1CB3C
		// (set) Token: 0x0600C0EE RID: 49390 RVA: 0x00B1E9F0 File Offset: 0x00B1CBF0
		public string CnvPerASTROTalkgroupOptionsSelectionType_A9112_UIValue
		{
			get
			{
				short num = (short)2135655758;
				short num2 = num;
				num = (short)1718912334;
				switch (num2 == num)
				{
				}
				num = (short)1134428160;
				if (num != 0)
				{
				}
				num = (short)1956839425;
				if (num != 0)
				{
				}
				num = (short)799211520;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.UIValue;
			}
			set
			{
				short num = (short)183680455;
				short num2 = num;
				num = (short)637582791;
				switch (num2 == num)
				{
				}
				num = (short)1382023169;
				if (num != 0)
				{
				}
				num = (short)811728896;
				if (num != 0)
				{
				}
				num = (short)904331264;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.UIValue = value;
			}
		}

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x0600C0EF RID: 49391 RVA: 0x00B1EAA8 File Offset: 0x00B1CCA8
		public global::AcpBusinessLayer.AcpListField CnvPerASTROTalkgroupOptionsSelectionType_A9112
		{
			get
			{
				short num = (short)36917270;
				short num2 = num;
				num = (short)105074710;
				switch (num2 == num)
				{
				}
				num = (short)1592066049;
				if (num != 0)
				{
				}
				num = (short)1551958016;
				if (num != 0)
				{
				}
				num = (short)1289814016;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112;
			}
		}

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x00B1EB58 File Offset: 0x00B1CD58
		// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x00B1EC0C File Offset: 0x00B1CE0C
		public bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_Applicable
		{
			get
			{
				short num = (short)1504370444;
				short num2 = num;
				num = (short)412999436;
				switch (num2 == num)
				{
				}
				num = (short)1929248769;
				if (num != 0)
				{
				}
				num = (short)628883456;
				if (num != 0)
				{
				}
				num = (short)1575616512;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Applicable;
			}
			set
			{
				short num = (short)1708564100;
				short num2 = num;
				num = (short)1913429636;
				switch (num2 == num)
				{
				}
				num = (short)1487208449;
				if (num != 0)
				{
				}
				num = (short)1197735936;
				if (num != 0)
				{
				}
				num = (short)68812800;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Applicable = value;
			}
		}

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x00B1ECC0 File Offset: 0x00B1CEC0
		// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x00B1ED74 File Offset: 0x00B1CF74
		public bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_Valid
		{
			get
			{
				short num = (short)14261437;
				short num2 = num;
				num = (short)179150013;
				switch (num2 == num)
				{
				}
				num = (short)2142175233;
				if (num != 0)
				{
				}
				num = (short)2134966272;
				if (num != 0)
				{
				}
				num = (short)795934720;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Valid;
			}
			set
			{
				short num = (short)1779389424;
				short num2 = num;
				num = (short)1612993520;
				switch (num2 == num)
				{
				}
				num = (short)2018115585;
				if (num != 0)
				{
				}
				num = (short)582090752;
				if (num != 0)
				{
				}
				num = (short)907804672;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Valid = value;
			}
		}

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x00B1EE2C File Offset: 0x00B1D02C
		// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x00B1EEE4 File Offset: 0x00B1D0E4
		public bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_Visible
		{
			get
			{
				short num = (short)257627040;
				short num2 = num;
				num = (short)268964768;
				switch (num2 == num)
				{
				}
				num = (short)486211585;
				if (num != 0)
				{
				}
				num = (short)773455872;
				if (num != 0)
				{
				}
				num = (short)1110966272;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Visible;
			}
			set
			{
				short num = (short)1375203837;
				short num2 = num;
				num = (short)1234956797;
				switch (num2 == num)
				{
				}
				num = (short)1637351425;
				if (num != 0)
				{
				}
				num = (short)2114781184;
				if (num != 0)
				{
				}
				num = (short)1741160448;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Visible = value;
			}
		}

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x0600C0F6 RID: 49398 RVA: 0x00B1EF98 File Offset: 0x00B1D198
		// (set) Token: 0x0600C0F7 RID: 49399 RVA: 0x00B1F04C File Offset: 0x00B1D24C
		public bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_Editable
		{
			get
			{
				short num = (short)2138656663;
				short num2 = num;
				num = (short)1527140247;
				switch (num2 == num)
				{
				}
				num = (short)1231028225;
				if (num != 0)
				{
				}
				num = (short)498794496;
				if (num != 0)
				{
				}
				num = (short)1484587008;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Editable;
			}
			set
			{
				short num = (short)2061170172;
				short num2 = num;
				num = (short)2066937340;
				switch (num2 == num)
				{
				}
				num = (short)955121664;
				if (num != 0)
				{
				}
				num = (short)715522049;
				if (num != 0)
				{
				}
				num = (short)242876416;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.Editable = value;
			}
		}

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x0600C0F8 RID: 49400 RVA: 0x00B1F100 File Offset: 0x00B1D300
		internal string CnvPerASTROTalkgroupOptionsSelectionType_A9112_UILabel
		{
			get
			{
				short num = (short)1401177580;
				short num2 = num;
				num = (short)2094548460;
				switch (num2 == num)
				{
				}
				num = (short)604897281;
				if (num != 0)
				{
				}
				num = (short)1236271104;
				if (num != 0)
				{
				}
				num = (short)1449852928;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.UIName;
			}
		}

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x0600C0F9 RID: 49401 RVA: 0x00B1F1B4 File Offset: 0x00B1D3B4
		// (set) Token: 0x0600C0FA RID: 49402 RVA: 0x00B1F268 File Offset: 0x00B1D468
		internal bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_HiddenStatic
		{
			get
			{
				short num = (short)308982827;
				short num2 = num;
				num = (short)1736684587;
				switch (num2 == num)
				{
				}
				num = (short)746717184;
				if (num != 0)
				{
				}
				num = (short)1199439873;
				if (num != 0)
				{
				}
				num = (short)1098121216;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.HiddenStatic;
			}
			set
			{
				short num = (short)1079212407;
				short num2 = num;
				num = (short)230652279;
				switch (num2 == num)
				{
				}
				num = (short)1580859393;
				if (num != 0)
				{
				}
				num = (short)345440256;
				if (num != 0)
				{
				}
				num = (short)1846870016;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.HiddenStatic = value;
			}
		}

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x0600C0FB RID: 49403 RVA: 0x00B1F31C File Offset: 0x00B1D51C
		// (set) Token: 0x0600C0FC RID: 49404 RVA: 0x00B1F3D0 File Offset: 0x00B1D5D0
		internal bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_HiddenDynamic
		{
			get
			{
				short num = (short)1259667457;
				if (num != 0)
				{
				}
				num = (short)1564565667;
				short num2 = num;
				num = (short)1087332515;
				switch (num2 == num)
				{
				}
				num = (short)1873149952;
				if (num != 0)
				{
				}
				num = (short)203882496;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.HiddenDynamic;
			}
			set
			{
				short num = (short)548405249;
				if (num != 0)
				{
				}
				num = (short)1205398937;
				short num2 = num;
				num = (short)846720409;
				switch (num2 == num)
				{
				}
				num = (short)141295616;
				if (num != 0)
				{
				}
				num = (short)302776320;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsSelectionType_A9112.HiddenDynamic = value;
			}
		}

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x0600C0FD RID: 49405 RVA: 0x00B1F488 File Offset: 0x00B1D688
		public bool CnvPerASTROTalkgroupOptionsSelectionType_A9112_HasDiffs
		{
			get
			{
				short num = (short)1766584268;
				short num2 = num;
				num = (short)957149132;
				switch (num2 == num)
				{
				}
				num = (short)1149566977;
				if (num != 0)
				{
				}
				num = (short)642777088;
				if (num != 0)
				{
				}
				num = (short)263716864;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsSelectionType_A9112._HasDiffs;
			}
		}

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x0600C0FE RID: 49406 RVA: 0x00B1F53C File Offset: 0x00B1D73C
		// (set) Token: 0x0600C0FF RID: 49407 RVA: 0x00B1F5F4 File Offset: 0x00B1D7F4
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272Value
		{
			get
			{
				short num = (short)1788475978;
				short num2 = num;
				num = (short)1903295050;
				switch (num2 == num)
				{
				}
				num = (short)395509761;
				if (num != 0)
				{
				}
				num = (short)2082078720;
				if (num != 0)
				{
				}
				num = (short)711917568;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value;
			}
			set
			{
				short num = (short)374672213;
				short num2 = num;
				num = (short)1010568021;
				switch (num2 == num)
				{
				}
				num = (short)1494548481;
				if (num != 0)
				{
				}
				num = (short)965148672;
				if (num != 0)
				{
				}
				num = (short)1506082816;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value = value;
			}
		}

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x0600C100 RID: 49408 RVA: 0x00B1F6AC File Offset: 0x00B1D8AC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272
		{
			get
			{
				short num = (short)1325734924;
				short num2 = num;
				num = (short)1765481484;
				switch (num2 == num)
				{
				}
				num = (short)1775828993;
				if (num != 0)
				{
				}
				num = (short)1965555712;
				if (num != 0)
				{
				}
				num = (short)1709506560;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;
			}
		}

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x0600C101 RID: 49409 RVA: 0x00B1F758 File Offset: 0x00B1D958
		// (set) Token: 0x0600C102 RID: 49410 RVA: 0x00B1F80C File Offset: 0x00B1DA0C
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_UIValue
		{
			get
			{
				short num = (short)1967603119;
				short num2 = num;
				num = (short)7617967;
				switch (num2 == num)
				{
				}
				num = (short)1042219009;
				if (num != 0)
				{
				}
				num = (short)835190784;
				if (num != 0)
				{
				}
				num = (short)1455751168;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value;
			}
			set
			{
				short num = (short)8935786;
				short num2 = num;
				num = (short)1229478250;
				switch (num2 == num)
				{
				}
				num = (short)173473793;
				if (num != 0)
				{
				}
				num = (short)1762197504;
				if (num != 0)
				{
				}
				num = (short)1038483456;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value = value;
			}
		}

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x0600C103 RID: 49411 RVA: 0x00B1F8C0 File Offset: 0x00B1DAC0
		// (set) Token: 0x0600C104 RID: 49412 RVA: 0x00B1F978 File Offset: 0x00B1DB78
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_Applicable
		{
			get
			{
				short num = (short)1835974311;
				short num2 = num;
				num = (short)183418535;
				switch (num2 == num)
				{
				}
				num = (short)964755456;
				if (num != 0)
				{
				}
				num = (short)706478081;
				if (num != 0)
				{
				}
				num = (short)909574144;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Applicable;
			}
			set
			{
				short num = (short)2017787905;
				if (num != 0)
				{
				}
				num = (short)1198575242;
				short num2 = num;
				num = (short)2141834890;
				switch (num2 == num)
				{
				}
				num = (short)70254592;
				if (num != 0)
				{
				}
				num = (short)780599296;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Applicable = value;
			}
		}

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x0600C105 RID: 49413 RVA: 0x00B1FA30 File Offset: 0x00B1DC30
		// (set) Token: 0x0600C106 RID: 49414 RVA: 0x00B1FAE4 File Offset: 0x00B1DCE4
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_Valid
		{
			get
			{
				short num = (short)939904120;
				short num2 = num;
				num = (short)1494731896;
				switch (num2 == num)
				{
				}
				num = (short)2104033281;
				if (num != 0)
				{
				}
				num = (short)830996480;
				if (num != 0)
				{
				}
				num = (short)1172832256;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Valid;
			}
			set
			{
				short num = (short)1824443061;
				short num2 = num;
				num = (short)1012845237;
				switch (num2 == num)
				{
				}
				num = (short)1141833728;
				if (num != 0)
				{
				}
				num = (short)45154305;
				if (num != 0)
				{
				}
				num = (short)1914372096;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Valid = value;
			}
		}

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x0600C107 RID: 49415 RVA: 0x00B1FB98 File Offset: 0x00B1DD98
		// (set) Token: 0x0600C108 RID: 49416 RVA: 0x00B1FC54 File Offset: 0x00B1DE54
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_Visible
		{
			get
			{
				short num = (short)222963325;
				short num2 = num;
				num = (short)317597309;
				switch (num2 == num)
				{
				}
				num = (short)111869952;
				if (num != 0)
				{
				}
				num = (short)1581318145;
				if (num != 0)
				{
				}
				num = (short)341377024;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Visible;
			}
			set
			{
				short num = (short)101037808;
				short num2 = num;
				num = (short)1270527728;
				switch (num2 == num)
				{
				}
				num = (short)407175169;
				if (num != 0)
				{
				}
				num = (short)533659648;
				if (num != 0)
				{
				}
				num = (short)618332160;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Visible = value;
			}
		}

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x0600C109 RID: 49417 RVA: 0x00B1FD08 File Offset: 0x00B1DF08
		// (set) Token: 0x0600C10A RID: 49418 RVA: 0x00B1FDBC File Offset: 0x00B1DFBC
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_Editable
		{
			get
			{
				short num = (short)658574352;
				short num2 = num;
				num = (short)1545014288;
				switch (num2 == num)
				{
				}
				num = (short)727908352;
				if (num != 0)
				{
				}
				num = (short)211091457;
				if (num != 0)
				{
				}
				num = (short)2078146560;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Editable;
			}
			set
			{
				short num = (short)1675711379;
				short num2 = num;
				num = (short)403395475;
				switch (num2 == num)
				{
				}
				num = (short)1575288833;
				if (num != 0)
				{
				}
				num = (short)1362952192;
				if (num != 0)
				{
				}
				num = (short)630259712;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Editable = value;
			}
		}

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x0600C10B RID: 49419 RVA: 0x00B1FE70 File Offset: 0x00B1E070
		internal string CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_UILabel
		{
			get
			{
				short num = (short)1378254061;
				short num2 = num;
				num = (short)1688435949;
				switch (num2 == num)
				{
				}
				num = (short)1212416001;
				if (num != 0)
				{
				}
				num = (short)2141257728;
				if (num != 0)
				{
				}
				num = (short)986120192;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.UIName;
			}
		}

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x0600C10C RID: 49420 RVA: 0x00B1FF24 File Offset: 0x00B1E124
		// (set) Token: 0x0600C10D RID: 49421 RVA: 0x00B1FFD8 File Offset: 0x00B1E1D8
		internal bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_HiddenStatic
		{
			get
			{
				short num = (short)1356922881;
				if (num != 0)
				{
				}
				num = (short)1935711158;
				short num2 = num;
				num = (short)1573952438;
				switch (num2 == num)
				{
				}
				num = (short)1174863872;
				if (num != 0)
				{
				}
				num = (short)1820262400;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.HiddenStatic;
			}
			set
			{
				short num = (short)499435806;
				short num2 = num;
				num = (short)1803143454;
				switch (num2 == num)
				{
				}
				num = (short)1729953793;
				if (num != 0)
				{
				}
				num = (short)22413312;
				if (num != 0)
				{
				}
				num = (short)295829504;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.HiddenStatic = value;
			}
		}

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x0600C10E RID: 49422 RVA: 0x00B20090 File Offset: 0x00B1E290
		// (set) Token: 0x0600C10F RID: 49423 RVA: 0x00B20144 File Offset: 0x00B1E344
		internal bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_HiddenDynamic
		{
			get
			{
				short num = (short)580098171;
				short num2 = num;
				num = (short)873175163;
				switch (num2 == num)
				{
				}
				num = (short)2068578304;
				if (num != 0)
				{
				}
				num = (short)290783233;
				if (num != 0)
				{
				}
				num = (short)541065216;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.HiddenDynamic;
			}
			set
			{
				short num = (short)2104400729;
				short num2 = num;
				num = (short)1743821657;
				switch (num2 == num)
				{
				}
				num = (short)479461377;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				if (num != 0)
				{
				}
				num = (short)509804544;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.HiddenDynamic = value;
			}
		}

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x0600C110 RID: 49424 RVA: 0x00B201FC File Offset: 0x00B1E3FC
		public bool CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272_HasDiffs
		{
			get
			{
				short num = (short)1154909418;
				short num2 = num;
				num = (short)725976298;
				switch (num2 == num)
				{
				}
				num = (short)694222849;
				if (num != 0)
				{
				}
				num = (short)1622343680;
				if (num != 0)
				{
				}
				num = (short)1706622976;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272._HasDiffs;
			}
		}

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x0600C111 RID: 49425 RVA: 0x00B202B0 File Offset: 0x00B1E4B0
		// (set) Token: 0x0600C112 RID: 49426 RVA: 0x00B20364 File Offset: 0x00B1E564
		public int CnvPerASTROTalkgroupOptionsTalkgroupList_A9283Value
		{
			get
			{
				short num = (short)1552740258;
				short num2 = num;
				num = (short)1611788194;
				switch (num2 == num)
				{
				}
				num = (short)82444288;
				if (num != 0)
				{
				}
				num = (short)1363279873;
				if (num != 0)
				{
				}
				num = (short)2066612224;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Value;
			}
			set
			{
				short num = (short)135569822;
				short num2 = num;
				num = (short)880517534;
				switch (num2 == num)
				{
				}
				num = (short)94502912;
				if (num != 0)
				{
				}
				num = (short)993525761;
				if (num != 0)
				{
				}
				num = (short)1525219328;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Value = value;
			}
		}

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x0600C113 RID: 49427 RVA: 0x00B20418 File Offset: 0x00B1E618
		// (set) Token: 0x0600C114 RID: 49428 RVA: 0x00B204CC File Offset: 0x00B1E6CC
		public string CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_UIValue
		{
			get
			{
				short num = (short)1641876386;
				short num2 = num;
				num = (short)1685457826;
				switch (num2 == num)
				{
				}
				num = (short)1376714753;
				if (num != 0)
				{
				}
				num = (short)842137600;
				if (num != 0)
				{
				}
				num = (short)133627904;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue;
			}
			set
			{
				short num = (short)1627378436;
				short num2 = num;
				num = (short)307876612;
				switch (num2 == num)
				{
				}
				num = (short)182648832;
				if (num != 0)
				{
				}
				num = (short)1572667393;
				if (num != 0)
				{
				}
				num = (short)403243008;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue = value;
			}
		}

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x0600C115 RID: 49429 RVA: 0x00B20584 File Offset: 0x00B1E784
		public global::AcpBusinessLayer.AcpRecRefField CnvPerASTROTalkgroupOptionsTalkgroupList_A9283
		{
			get
			{
				short num = (short)1492235693;
				short num2 = num;
				num = (short)1742255533;
				switch (num2 == num)
				{
				}
				num = (short)1182072832;
				if (num != 0)
				{
				}
				num = (short)1057161217;
				if (num != 0)
				{
				}
				num = (short)356188160;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283;
			}
		}

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x0600C116 RID: 49430 RVA: 0x00B20630 File Offset: 0x00B1E830
		// (set) Token: 0x0600C117 RID: 49431 RVA: 0x00B206E4 File Offset: 0x00B1E8E4
		public bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_Applicable
		{
			get
			{
				short num = (short)584077991;
				short num2 = num;
				num = (short)658330279;
				switch (num2 == num)
				{
				}
				num = (short)1559822337;
				if (num != 0)
				{
				}
				num = (short)1337262080;
				if (num != 0)
				{
				}
				num = (short)978780160;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Applicable;
			}
			set
			{
				short num = (short)442845060;
				short num2 = num;
				num = (short)1340295044;
				switch (num2 == num)
				{
				}
				num = (short)1065025536;
				if (num != 0)
				{
				}
				num = (short)418775041;
				if (num != 0)
				{
				}
				num = (short)735248384;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Applicable = value;
			}
		}

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x0600C118 RID: 49432 RVA: 0x00B20798 File Offset: 0x00B1E998
		// (set) Token: 0x0600C119 RID: 49433 RVA: 0x00B2084C File Offset: 0x00B1EA4C
		public bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_Valid
		{
			get
			{
				short num = (short)188103059;
				short num2 = num;
				num = (short)1750808979;
				switch (num2 == num)
				{
				}
				num = (short)98435073;
				if (num != 0)
				{
				}
				num = (short)1877737472;
				if (num != 0)
				{
				}
				num = (short)1867841536;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Valid;
			}
			set
			{
				short num = (short)2049545203;
				short num2 = num;
				num = (short)992515059;
				switch (num2 == num)
				{
				}
				num = (short)516489216;
				if (num != 0)
				{
				}
				num = (short)1433862145;
				if (num != 0)
				{
				}
				num = (short)1739128832;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Valid = value;
			}
		}

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x0600C11A RID: 49434 RVA: 0x00B20900 File Offset: 0x00B1EB00
		// (set) Token: 0x0600C11B RID: 49435 RVA: 0x00B209B4 File Offset: 0x00B1EBB4
		public bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_Visible
		{
			get
			{
				short num = (short)858554067;
				short num2 = num;
				num = (short)855015123;
				switch (num2 == num)
				{
				}
				num = (short)1840513025;
				if (num != 0)
				{
				}
				num = (short)880082944;
				if (num != 0)
				{
				}
				num = (short)1210253312;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Visible;
			}
			set
			{
				short num = (short)1008767940;
				short num2 = num;
				num = (short)982225860;
				switch (num2 == num)
				{
				}
				num = (short)1110835201;
				if (num != 0)
				{
				}
				num = (short)919339008;
				if (num != 0)
				{
				}
				num = (short)1732116480;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Visible = value;
			}
		}

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x0600C11C RID: 49436 RVA: 0x00B20A6C File Offset: 0x00B1EC6C
		// (set) Token: 0x0600C11D RID: 49437 RVA: 0x00B20B20 File Offset: 0x00B1ED20
		public bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_Editable
		{
			get
			{
				short num = (short)1766051388;
				short num2 = num;
				num = (short)1464782396;
				switch (num2 == num)
				{
				}
				num = (short)1860698113;
				if (num != 0)
				{
				}
				num = (short)1418395648;
				if (num != 0)
				{
				}
				num = (short)2046361600;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Editable;
			}
			set
			{
				short num = (short)314713446;
				short num2 = num;
				num = (short)880813414;
				switch (num2 == num)
				{
				}
				num = (short)1722286081;
				if (num != 0)
				{
				}
				num = (short)670826496;
				if (num != 0)
				{
				}
				num = (short)1718026240;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.Editable = value;
			}
		}

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x0600C11E RID: 49438 RVA: 0x00B20BD4 File Offset: 0x00B1EDD4
		internal string CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_UILabel
		{
			get
			{
				short num = (short)1970601985;
				if (num != 0)
				{
				}
				num = (short)293537313;
				short num2 = num;
				num = (short)761333281;
				switch (num2 == num)
				{
				}
				num = (short)1767374848;
				if (num != 0)
				{
				}
				num = (short)1510670336;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIName;
			}
		}

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x0600C11F RID: 49439 RVA: 0x00B20C8C File Offset: 0x00B1EE8C
		// (set) Token: 0x0600C120 RID: 49440 RVA: 0x00B20D40 File Offset: 0x00B1EF40
		internal bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_HiddenStatic
		{
			get
			{
				short num = (short)663112480;
				short num2 = num;
				num = (short)1305365280;
				switch (num2 == num)
				{
				}
				num = (short)1438253057;
				if (num != 0)
				{
				}
				num = (short)1398276096;
				if (num != 0)
				{
				}
				num = (short)112984064;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.HiddenStatic;
			}
			set
			{
				short num = (short)645644791;
				short num2 = num;
				num = (short)539935223;
				switch (num2 == num)
				{
				}
				num = (short)1079377921;
				if (num != 0)
				{
				}
				num = (short)641990656;
				if (num != 0)
				{
				}
				num = (short)831389696;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.HiddenStatic = value;
			}
		}

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x0600C121 RID: 49441 RVA: 0x00B20DF8 File Offset: 0x00B1EFF8
		// (set) Token: 0x0600C122 RID: 49442 RVA: 0x00B20EAC File Offset: 0x00B1F0AC
		internal bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_HiddenDynamic
		{
			get
			{
				short num = (short)1207906333;
				short num2 = num;
				num = (short)1543319581;
				switch (num2 == num)
				{
				}
				num = (short)1884291073;
				if (num != 0)
				{
				}
				num = (short)1030094848;
				if (num != 0)
				{
				}
				num = (short)753205248;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.HiddenDynamic;
			}
			set
			{
				short num = (short)1201829685;
				short num2 = num;
				num = (short)510490421;
				switch (num2 == num)
				{
				}
				num = (short)28508161;
				if (num != 0)
				{
				}
				num = (short)1115684864;
				if (num != 0)
				{
				}
				num = (short)2082471936;
				short num3 = num;
				this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283.HiddenDynamic = value;
			}
		}

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x0600C123 RID: 49443 RVA: 0x00B20F60 File Offset: 0x00B1F160
		public bool CnvPerASTROTalkgroupOptionsTalkgroupList_A9283_HasDiffs
		{
			get
			{
				short num = (short)361495959;
				short num2 = num;
				num = (short)837352855;
				switch (num2 == num)
				{
				}
				num = (short)460128257;
				if (num != 0)
				{
				}
				num = (short)2052456448;
				if (num != 0)
				{
				}
				num = (short)884211712;
				short num3 = num;
				return this.cnvPerASTROTalkgroupOptionsTalkgroupList_A9283._HasDiffs;
			}
		}

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x0600C124 RID: 49444 RVA: 0x00B21014 File Offset: 0x00B1F214
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1195387875;
				short num2 = num;
				num = (short)1724328931;
				switch (num2 == num)
				{
				}
				num = (short)1039597569;
				if (num != 0)
				{
				}
				num = (short)1002307584;
				if (num != 0)
				{
				}
				num = (short)900595712;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600C125 RID: 49445 RVA: 0x00B210D0 File Offset: 0x00B1F2D0
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
					num2 = (short)392429569;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1302528003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_A8;
				case 2:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)1702887199;
					short num3 = num2;
					num2 = (short)728694559;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A8;
					default:
						num2 = (short)2109407232;
						if (num2 != 0)
						{
						}
						num2 = (short)1599471617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2014314496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_A8:
				num2 = (short)635174912;
				short num4 = num2;
				num2 = (short)956825604;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)500695042;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600C126 RID: 49446 RVA: 0x00B2124C File Offset: 0x00B1F44C
		private void b()
		{
			short num = (short)510394369;
			if (num != 0)
			{
			}
			num = (short)1489076620;
			short num2 = num;
			num = (short)1416659340;
			switch (num2 == num)
			{
			}
			num = (short)2049114112;
			if (num != 0)
			{
			}
			num = (short)1788084224;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x00B21300 File Offset: 0x00B1F500
		private void a()
		{
			short num = (short)1446379537;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.IAcpRecordset feature;
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_28D;
				case 1:
					num = (short)1891631117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1075642379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1DF;
				case 4:
					if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, base.Parent.Permissions))
					{
						num = (short)819396626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_1A5;
				case 6:
					num = (short)371916810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (base.Parent.Parent.ContainerDoc != null)
					{
						num = (short)1993605128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)98369550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, feature[num3].Permissions))
					{
						num = (short)781058067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1695023105;
					if (num != 0)
					{
					}
					num3++;
					num = (short)1494614028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (base.Parent.Parent.ContainerDoc.DocType != global::AcpCommonLib.DocumentType.Comparator)
					{
						num = (short)556662804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
					{
						num = (short)1225457664;
						short num4 = num;
						num = (short)1223163904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					goto IL_1A5;
				case 13:
					goto IL_3A6;
				case 14:
					if (base.Parent.Parent.ContainerDoc.IsOpen)
					{
						num = (short)1351680006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					num = (short)350224391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (num3 >= feature.Count)
					{
						num = (short)549126147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1847197705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 18:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2062);
					num3 = 0;
					num = (short)701759493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1422786581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)874446852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num = (short)1875836930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_7C:
				if (base.Parent == null)
				{
					return;
				}
				num = (short)1433735827;
				short num5 = num;
				num = (short)233378451;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3A6;
				default:
					num = (short)781123584;
					if (num != 0)
					{
					}
					num = (short)1024589825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1A5:
				num = (short)1032257552;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A6:
				if (base.Parent.Parent == null)
				{
					return;
				}
				num = (short)1978990607;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1DF:
			return;
			IL_28D:
			this.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.UIValue = feature[num3].ReferenceKey;
		}

		// Token: 0x04005C51 RID: 23633
		private global::AcpBusinessLayer.AcpListField cnvPerASTROTalkgroupOptionsSelectionType_A9112;

		// Token: 0x04005C52 RID: 23634
		private global::AcpBusinessLayer.AcpField<bool> cnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272;

		// Token: 0x04005C53 RID: 23635
		private global::AcpBusinessLayer.AcpRecRefField cnvPerASTROTalkgroupOptionsTalkgroupList_A9283;
	}
}
