using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C8 RID: 1480
	[global::System.Serializable]
	public class OneTouchInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C89F RID: 51359 RVA: 0x00BB7B5C File Offset: 0x00BB5D5C
		public OneTouchInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x00BB7B78 File Offset: 0x00BB5D78
		protected OneTouchInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x00BB7B90 File Offset: 0x00BB5D90
		public override void Init()
		{
			int a_ = 1;
			short num = (short)233375851;
			short num2 = num;
			num = (short)836438123;
			switch (num2 == num)
			{
			}
			num = (short)1766981633;
			if (num != 0)
			{
			}
			num = (short)649723904;
			short num3 = num;
			num = (short)813957120;
			if (num != 0)
			{
			}
			this.cnvPerOneTouchFeature_A19662 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerOneTouchFeature_A19662LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerOneTouchFeature_A19662LovStrs), this, global::AllFeatures.CodeplugGuid.b("臁꫃냅飇꿉뻋臍뻏럑胓맕귗맙듛飝藟菡郣鏥髧迩돫꿭쇯쯱싳샵쫷", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerOneTouchFeature_A19662LovStrs);
			this.cnvPerOneTouchFeature_A19662.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerOneTouchFeature_A19662.DataTransferOrder = 44;
			this.cnvPerOneTouchButton_A19765 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臁꫃냅飇꿉뻋臍뻏럑胓맕귗맙듛鳝闟雡郣觥蛧뗩귫\udfed짯엱싳쏵", a_), global::CommonResources.AcgResources.ID_BUTTON, 100);
			this.cnvPerOneTouchButton_A19765.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerOneTouchButton_A19765.DataTransferOrder = -1;
			this.cnvPerOneTouchIndex_A19663 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("臁꫃냅飇꿉뻋臍뻏럑胓맕귗맙듛韝軟蛡臣黥럧ꯩ\uddebퟭ웯쓱쟳", a_), global::CommonResources.AcgResources.ID_INDEX, 1, 100, null, null, 0, 1);
			this.cnvPerOneTouchIndex_A19663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerOneTouchIndex_A19663.DataTransferOrder = 122;
			this.cnvPerOneTouchIndex_A19663.ShowHexValue = false;
			this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("臁꫃냅飇꿉뻋臍뻏럑胓맕귗맙듛鿝苟胡難菥黧菩跫髭闯雱믳飵鷷껹鏻诽揿樁䔃樅愇欉缋儍儏⌑ⴓ―⸗⸙", a_), global::CommonResources.AcgResources.ID_ABBREVIATEDONETOUCHALIAS, 4);
			this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.DataTransferOrder = 286;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ뻇꿉ꋋ뫍맏뷑뫓럕듗龎鏛냝藟싡냣觥鷧觩蓫", a_);
			base.Id = 10146;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALONETOUCH;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x00BB7D88 File Offset: 0x00BB5F88
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)722927625;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvPerOneTouchFeature_A19662 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerOneTouchFeature_A19662LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerOneTouchFeature_A19662LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩ꫫ语釯蛱至蓵鷷ꗹ뷻쿽㧿㐁㈃㐅", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerOneTouchFeature_A19662LovStrs);
					this.cnvPerOneTouchFeature_A19662.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerOneTouchFeature_A19662.DataTransferOrder = 44;
					num = (short)1656291329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_318;
				case 2:
					num = (short)1897463820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_248;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩ꗫ胭铯韱賳꧵맷쯹엻죽㛿㄁", a_)))
					{
						num = (short)1244332037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_199;
				case 5:
					this.cnvPerOneTouchIndex_A19663 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩ꗫ胭铯韱賳꧵맷쯹엻죽㛿㄁", a_), global::CommonResources.AcgResources.ID_INDEX, null, null, 0, 1);
					this.cnvPerOneTouchIndex_A19663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerOneTouchIndex_A19663.DataTransferOrder = 122;
					this.cnvPerOneTouchIndex_A19663.ShowHexValue = false;
					num = (short)1851064327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩귫賭鋯胱釳胵釷鯹裻鯽擿䴁樃挅將攉礋洍砏匑砓缕礗椙䌛弝ᄟᬡሣဥᰧ", a_), global::CommonResources.AcgResources.ID_ABBREVIATEDONETOUCHALIAS, 4);
					this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.DataTransferOrder = 286;
					num = (short)1948778506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_199;
				case 8:
					num = (short)2125987854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 10:
					goto IL_2ED;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩껫鯭蓯蛱鯳飵ꟷ믹췻쟽㟿㐁㄃", a_)))
					{
						num = (short)680198157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_248;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩ꫫ语釯蛱至蓵鷷ꗹ뷻쿽㧿㐁㈃㐅", a_)))
					{
						num = (short)1486618624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_318;
				case 13:
				{
					num = (short)1995527536;
					short num3 = num;
					num = (short)76830064;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_248;
					default:
						num = (short)1350959104;
						if (num != 0)
						{
						}
						this.cnvPerOneTouchButton_A19765 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩껫鯭蓯蛱鯳飵ꟷ믹췻쟽㟿㐁㄃", a_), global::CommonResources.AcgResources.ID_BUTTON, 100);
						this.cnvPerOneTouchButton_A19765.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.cnvPerOneTouchButton_A19765.DataTransferOrder = -1;
						num = (short)501874691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					if (producerFields != null)
					{
						num = (short)1785004034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41A;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鏛냝藟뛡诣鏥诧苩귫賭鋯胱釳胵釷鯹裻鯽擿䴁樃挅將攉礋洍砏匑砓缕礗椙䌛弝ᄟᬡሣဥᰧ", a_)))
					{
						num = (short)383057920;
						short num4 = num;
						num = (short)1259798534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41A;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)452657160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_41A;
				IL_199:
				num = (short)888537103;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_248:
				num = (short)1429340164;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_318:
				num = (short)1721499659;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2ED:
			num = (short)311689217;
			if (num != 0)
			{
			}
			IL_41A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏏뷑뫓ꃕ뷗듙꣛럝迟賡藣諥죧ꗩ苫语탯꛱鯳菵鯷鋹", a_);
			base.Id = 10146;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALONETOUCH;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x00BB81E0 File Offset: 0x00BB63E0
		public override void PopulateReferences()
		{
			short num = (short)1543582860;
			short num2 = num;
			num = (short)300561548;
			switch (num2 == num)
			{
			}
			num = (short)1012203520;
			if (num != 0)
			{
			}
			num = (short)2124873728;
			short num3 = num;
			num = (short)1691418625;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x00BB8288 File Offset: 0x00BB6488
		public override void DropReferences()
		{
			short num = (short)1332436397;
			short num2 = num;
			num = (short)228285869;
			switch (num2 == num)
			{
			}
			num = (short)57278464;
			if (num != 0)
			{
			}
			num = (short)1704001536;
			short num3 = num;
			num = (short)1439236097;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x00BB8334 File Offset: 0x00BB6534
		public override void SetConstraints()
		{
			short num = (short)1232327606;
			short num2 = num;
			num = (short)1459409846;
			switch (num2 == num)
			{
			}
			num = (short)408748032;
			if (num != 0)
			{
			}
			num = (short)440860672;
			short num3 = num;
			num = (short)1553530881;
			if (num != 0)
			{
			}
			this.cnvPerOneTouchFeature_A19662.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRSISysIsEnabled);
			this.cnvPerOneTouchFeature_A19662.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsCnvOneTouchFeatValid);
			this.cnvPerOneTouchButton_A19765.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cnvPerOneTouchIndex_A19663.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConOneTouchButtonFeatureIsEnabled);
			this.cnvPerOneTouchIndex_A19663.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsCnvOneTouchIndexValid);
			this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsCnvOneTouchAbbrvivateOenTouchInvalid);
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x00BB8468 File Offset: 0x00BB6668
		public override void SetupDependencies()
		{
			short num = (short)1692174736;
			short num2 = num;
			num = (short)260737424;
			switch (num2 == num)
			{
			}
			num = (short)79036417;
			if (num != 0)
			{
			}
			num = (short)1782513664;
			short num3 = num;
			num = (short)1943732224;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.RAC.CnvPerRACRepeaterAccess_A8939.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.RAC.CnvPerRACAccessType_A7388.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.RAC.CnvPerRACCodeType2_A8817.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			conventionalPersonality.NonASTROCall.CnvPerNonASTROCallRTTButtonAccess_A8493.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			this.RefDisplayAndMenu.Advanced.RadioErgDispAdvanceStatusAutoExit_42158.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			this.RefRadioErgonomicsWide.HomeMode.RadErgoWideHomeModeHomeModeSelection_A8202.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			this.RefDisplayAndMenu.Advanced.RadErgoWideDispMenu_A21430.AddDependentObject(this.cnvPerOneTouchFeature_A19662);
			this.cnvPerOneTouchFeature_A19662.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
			conventionalPersonality.Signaling.CnvPerSignalingSystemNumber_A9243.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
			conventionalPersonality.Signaling.CnvPerSignalingSignalingType_A9129.AddDependentObject(this.cnvPerOneTouchIndex_A19663);
		}

		// Token: 0x170064A0 RID: 25760
		// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x00BB86FC File Offset: 0x00BB68FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1473265967;
				short num2 = num;
				num = (short)1739931951;
				switch (num2 == num)
				{
				}
				num = (short)1659371521;
				if (num != 0)
				{
				}
				num = (short)580124672;
				short num3 = num;
				num = (short)1906245632;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170064A1 RID: 25761
		// (get) Token: 0x0600C8A8 RID: 51368 RVA: 0x00BB87AC File Offset: 0x00BB69AC
		// (set) Token: 0x0600C8A9 RID: 51369 RVA: 0x00BB8860 File Offset: 0x00BB6A60
		public int CnvPerOneTouchFeature_A19662Value
		{
			get
			{
				short num = (short)1020081348;
				short num2 = num;
				num = (short)836842692;
				switch (num2 == num)
				{
				}
				num = (short)1379663872;
				if (num != 0)
				{
				}
				num = (short)1540620288;
				short num3 = num;
				num = (short)1504313345;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.Value;
			}
			set
			{
				short num = (short)938025330;
				short num2 = num;
				num = (short)1754997106;
				switch (num2 == num)
				{
				}
				num = (short)962527232;
				if (num != 0)
				{
				}
				num = (short)1323761664;
				short num3 = num;
				num = (short)654966785;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.Value = value;
			}
		}

		// Token: 0x170064A2 RID: 25762
		// (get) Token: 0x0600C8AA RID: 51370 RVA: 0x00BB8918 File Offset: 0x00BB6B18
		// (set) Token: 0x0600C8AB RID: 51371 RVA: 0x00BB89CC File Offset: 0x00BB6BCC
		public string CnvPerOneTouchFeature_A19662_UIValue
		{
			get
			{
				short num = (short)2102984163;
				short num2 = num;
				num = (short)1721892323;
				switch (num2 == num)
				{
				}
				num = (short)649134081;
				if (num != 0)
				{
				}
				num = (short)408879104;
				short num3 = num;
				num = (short)522846208;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.UIValue;
			}
			set
			{
				short num = (short)1222970975;
				short num2 = num;
				num = (short)1854148191;
				switch (num2 == num)
				{
				}
				num = (short)1503133696;
				if (num != 0)
				{
				}
				num = (short)1065353216;
				short num3 = num;
				num = (short)70516737;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.UIValue = value;
			}
		}

		// Token: 0x170064A3 RID: 25763
		// (get) Token: 0x0600C8AC RID: 51372 RVA: 0x00BB8A80 File Offset: 0x00BB6C80
		public global::AcpBusinessLayer.AcpListField CnvPerOneTouchFeature_A19662
		{
			get
			{
				short num = (short)414306114;
				short num2 = num;
				num = (short)2082000706;
				switch (num2 == num)
				{
				}
				num = (short)1688469505;
				if (num != 0)
				{
				}
				num = (short)829292544;
				short num3 = num;
				num = (short)1909850112;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662;
			}
		}

		// Token: 0x170064A4 RID: 25764
		// (get) Token: 0x0600C8AD RID: 51373 RVA: 0x00BB8B30 File Offset: 0x00BB6D30
		// (set) Token: 0x0600C8AE RID: 51374 RVA: 0x00BB8BE4 File Offset: 0x00BB6DE4
		public bool CnvPerOneTouchFeature_A19662_Applicable
		{
			get
			{
				short num = (short)924254209;
				if (num != 0)
				{
				}
				num = (short)116731933;
				short num2 = num;
				num = (short)1684287517;
				switch (num2 == num)
				{
				}
				num = (short)1112473600;
				short num3 = num;
				num = (short)1814429696;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.Applicable;
			}
			set
			{
				short num = (short)903951278;
				short num2 = num;
				num = (short)958804910;
				switch (num2 == num)
				{
				}
				num = (short)603848705;
				if (num != 0)
				{
				}
				num = (short)278528000;
				short num3 = num;
				num = (short)976945152;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.Applicable = value;
			}
		}

		// Token: 0x170064A5 RID: 25765
		// (get) Token: 0x0600C8AF RID: 51375 RVA: 0x00BB8C98 File Offset: 0x00BB6E98
		// (set) Token: 0x0600C8B0 RID: 51376 RVA: 0x00BB8D4C File Offset: 0x00BB6F4C
		public bool CnvPerOneTouchFeature_A19662_Valid
		{
			get
			{
				short num = (short)1184642755;
				short num2 = num;
				num = (short)1198995139;
				switch (num2 == num)
				{
				}
				num = (short)238223361;
				if (num != 0)
				{
				}
				num = (short)1058799616;
				short num3 = num;
				num = (short)75890688;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.Valid;
			}
			set
			{
				short num = (short)1577910273;
				if (num != 0)
				{
				}
				num = (short)505272831;
				short num2 = num;
				num = (short)2042550783;
				switch (num2 == num)
				{
				}
				num = (short)714080256;
				short num3 = num;
				num = (short)536870912;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.Valid = value;
			}
		}

		// Token: 0x170064A6 RID: 25766
		// (get) Token: 0x0600C8B1 RID: 51377 RVA: 0x00BB8E00 File Offset: 0x00BB7000
		// (set) Token: 0x0600C8B2 RID: 51378 RVA: 0x00BB8EB4 File Offset: 0x00BB70B4
		public bool CnvPerOneTouchFeature_A19662_Visible
		{
			get
			{
				short num = (short)538086810;
				short num2 = num;
				num = (short)1939312026;
				switch (num2 == num)
				{
				}
				num = (short)1395458049;
				if (num != 0)
				{
				}
				num = (short)1039138816;
				short num3 = num;
				num = (short)1932460032;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.Visible;
			}
			set
			{
				short num = (short)1532405887;
				short num2 = num;
				num = (short)729983103;
				switch (num2 == num)
				{
				}
				num = (short)1547567104;
				if (num != 0)
				{
				}
				num = (short)96075776;
				short num3 = num;
				num = (short)596901889;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.Visible = value;
			}
		}

		// Token: 0x170064A7 RID: 25767
		// (get) Token: 0x0600C8B3 RID: 51379 RVA: 0x00BB8F68 File Offset: 0x00BB7168
		// (set) Token: 0x0600C8B4 RID: 51380 RVA: 0x00BB901C File Offset: 0x00BB721C
		public bool CnvPerOneTouchFeature_A19662_Editable
		{
			get
			{
				short num = (short)1246323795;
				short num2 = num;
				num = (short)1884185683;
				switch (num2 == num)
				{
				}
				num = (short)2106523649;
				if (num != 0)
				{
				}
				num = (short)1522335744;
				short num3 = num;
				num = (short)1354366976;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.Editable;
			}
			set
			{
				short num = (short)1242799664;
				short num2 = num;
				num = (short)456957488;
				switch (num2 == num)
				{
				}
				num = (short)1438580737;
				if (num != 0)
				{
				}
				num = (short)122552320;
				short num3 = num;
				num = (short)879886336;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.Editable = value;
			}
		}

		// Token: 0x170064A8 RID: 25768
		// (get) Token: 0x0600C8B5 RID: 51381 RVA: 0x00BB90D0 File Offset: 0x00BB72D0
		internal string CnvPerOneTouchFeature_A19662_UILabel
		{
			get
			{
				short num = (short)155241010;
				short num2 = num;
				num = (short)247908914;
				switch (num2 == num)
				{
				}
				num = (short)2105147392;
				if (num != 0)
				{
				}
				num = (short)1073348608;
				short num3 = num;
				num = (short)597360641;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.UIName;
			}
		}

		// Token: 0x170064A9 RID: 25769
		// (get) Token: 0x0600C8B6 RID: 51382 RVA: 0x00BB9184 File Offset: 0x00BB7384
		// (set) Token: 0x0600C8B7 RID: 51383 RVA: 0x00BB9238 File Offset: 0x00BB7438
		internal bool CnvPerOneTouchFeature_A19662_HiddenStatic
		{
			get
			{
				short num = (short)1950416897;
				if (num != 0)
				{
				}
				num = (short)422621247;
				short num2 = num;
				num = (short)720941119;
				switch (num2 == num)
				{
				}
				num = (short)100794368;
				short num3 = num;
				num = (short)937754624;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.HiddenStatic;
			}
			set
			{
				short num = (short)918117110;
				short num2 = num;
				num = (short)356080374;
				switch (num2 == num)
				{
				}
				num = (short)1667694593;
				if (num != 0)
				{
				}
				num = (short)617938944;
				short num3 = num;
				num = (short)1261043712;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.HiddenStatic = value;
			}
		}

		// Token: 0x170064AA RID: 25770
		// (get) Token: 0x0600C8B8 RID: 51384 RVA: 0x00BB92EC File Offset: 0x00BB74EC
		// (set) Token: 0x0600C8B9 RID: 51385 RVA: 0x00BB93A0 File Offset: 0x00BB75A0
		internal bool CnvPerOneTouchFeature_A19662_HiddenDynamic
		{
			get
			{
				short num = (short)1065967164;
				short num2 = num;
				num = (short)534535740;
				switch (num2 == num)
				{
				}
				num = (short)1066729473;
				if (num != 0)
				{
				}
				num = (short)1980235776;
				short num3 = num;
				num = (short)523632640;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662.HiddenDynamic;
			}
			set
			{
				short num = (short)123558660;
				short num2 = num;
				num = (short)773085956;
				switch (num2 == num)
				{
				}
				num = (short)1045626881;
				if (num != 0)
				{
				}
				num = (short)1682178048;
				short num3 = num;
				num = (short)477757440;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchFeature_A19662.HiddenDynamic = value;
			}
		}

		// Token: 0x170064AB RID: 25771
		// (get) Token: 0x0600C8BA RID: 51386 RVA: 0x00BB9454 File Offset: 0x00BB7654
		public bool CnvPerOneTouchFeature_A19662_HasDiffs
		{
			get
			{
				short num = (short)808255489;
				if (num != 0)
				{
				}
				num = (short)2000209090;
				short num2 = num;
				num = (short)909034690;
				switch (num2 == num)
				{
				}
				num = (short)1019609088;
				short num3 = num;
				num = (short)243662848;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchFeature_A19662._HasDiffs;
			}
		}

		// Token: 0x170064AC RID: 25772
		// (get) Token: 0x0600C8BB RID: 51387 RVA: 0x00BB9504 File Offset: 0x00BB7704
		// (set) Token: 0x0600C8BC RID: 51388 RVA: 0x00BB95B8 File Offset: 0x00BB77B8
		public string CnvPerOneTouchButton_A19765Value
		{
			get
			{
				short num = (short)555286529;
				if (num != 0)
				{
				}
				num = (short)1225480976;
				short num2 = num;
				num = (short)1001216784;
				switch (num2 == num)
				{
				}
				num = (short)1232601088;
				if (num != 0)
				{
				}
				num = (short)1622016000;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.Value;
			}
			set
			{
				short num = (short)1579483137;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1579220992;
						short num3 = num;
						this.cnvPerOneTouchButton_A19765.Value = value;
						num = (short)1710948354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_F3;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)254910752;
					short num4 = num;
					num = (short)1302962464;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num = (short)269942784;
						if (num != 0)
						{
						}
						num = (short)49086464;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F3:
				num = (short)825163777;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170064AD RID: 25773
		// (get) Token: 0x0600C8BD RID: 51389 RVA: 0x00BB96E4 File Offset: 0x00BB78E4
		// (set) Token: 0x0600C8BE RID: 51390 RVA: 0x00BB979C File Offset: 0x00BB799C
		public string CnvPerOneTouchButton_A19765_UIValue
		{
			get
			{
				short num = (short)971846487;
				short num2 = num;
				num = (short)840184663;
				switch (num2 == num)
				{
				}
				num = (short)1154285569;
				if (num != 0)
				{
				}
				num = (short)1436155904;
				if (num != 0)
				{
				}
				num = (short)1056505856;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.Value;
			}
			set
			{
				short num = (short)376574915;
				short num2 = num;
				num = (short)653005763;
				switch (num2 == num)
				{
				}
				num = (short)1137704960;
				if (num != 0)
				{
				}
				num = (short)1045626881;
				if (num != 0)
				{
				}
				num = (short)1020919808;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.Value = value;
			}
		}

		// Token: 0x170064AE RID: 25774
		// (get) Token: 0x0600C8BF RID: 51391 RVA: 0x00BB9854 File Offset: 0x00BB7A54
		public global::AcpBusinessLayer.AcpKeyField CnvPerOneTouchButton_A19765
		{
			get
			{
				short num = (short)1858951546;
				short num2 = num;
				num = (short)1009015162;
				switch (num2 == num)
				{
				}
				num = (short)1103364097;
				if (num != 0)
				{
				}
				num = (short)1551499264;
				if (num != 0)
				{
				}
				num = (short)962658304;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765;
			}
		}

		// Token: 0x170064AF RID: 25775
		// (get) Token: 0x0600C8C0 RID: 51392 RVA: 0x00BB9904 File Offset: 0x00BB7B04
		// (set) Token: 0x0600C8C1 RID: 51393 RVA: 0x00BB99B8 File Offset: 0x00BB7BB8
		public bool CnvPerOneTouchButton_A19765_Applicable
		{
			get
			{
				short num = (short)2041033035;
				short num2 = num;
				num = (short)1216786763;
				switch (num2 == num)
				{
				}
				num = (short)1302462464;
				if (num != 0)
				{
				}
				num = (short)1247936513;
				if (num != 0)
				{
				}
				num = (short)858718208;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.Applicable;
			}
			set
			{
				short num = (short)2003883264;
				short num2 = num;
				num = (short)1523963136;
				switch (num2 == num)
				{
				}
				num = (short)351862785;
				if (num != 0)
				{
				}
				num = (short)1981612032;
				if (num != 0)
				{
				}
				num = (short)674627584;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.Applicable = value;
			}
		}

		// Token: 0x170064B0 RID: 25776
		// (get) Token: 0x0600C8C2 RID: 51394 RVA: 0x00BB9A6C File Offset: 0x00BB7C6C
		// (set) Token: 0x0600C8C3 RID: 51395 RVA: 0x00BB9B1C File Offset: 0x00BB7D1C
		public bool CnvPerOneTouchButton_A19765_Valid
		{
			get
			{
				short num = (short)1372811825;
				short num2 = num;
				num = (short)1717137969;
				switch (num2 == num)
				{
				}
				num = (short)1583153153;
				if (num != 0)
				{
				}
				num = (short)577306624;
				if (num != 0)
				{
				}
				num = (short)1504772096;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.Valid;
			}
			set
			{
				short num = (short)1152192748;
				short num2 = num;
				num = (short)553193708;
				switch (num2 == num)
				{
				}
				num = (short)2034237441;
				if (num != 0)
				{
				}
				num = (short)1829175296;
				if (num != 0)
				{
				}
				num = (short)1253113856;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.Valid = value;
			}
		}

		// Token: 0x170064B1 RID: 25777
		// (get) Token: 0x0600C8C4 RID: 51396 RVA: 0x00BB9BD0 File Offset: 0x00BB7DD0
		// (set) Token: 0x0600C8C5 RID: 51397 RVA: 0x00BB9C88 File Offset: 0x00BB7E88
		public bool CnvPerOneTouchButton_A19765_Visible
		{
			get
			{
				short num = (short)147086501;
				short num2 = num;
				num = (short)1326144677;
				switch (num2 == num)
				{
				}
				num = (short)1543503873;
				if (num != 0)
				{
				}
				num = (short)1329856512;
				if (num != 0)
				{
				}
				num = (short)167051264;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.Visible;
			}
			set
			{
				short num = (short)338534653;
				short num2 = num;
				num = (short)809804029;
				switch (num2 == num)
				{
				}
				num = (short)195887104;
				if (num != 0)
				{
				}
				num = (short)1062469633;
				if (num != 0)
				{
				}
				num = (short)1204879360;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.Visible = value;
			}
		}

		// Token: 0x170064B2 RID: 25778
		// (get) Token: 0x0600C8C6 RID: 51398 RVA: 0x00BB9D3C File Offset: 0x00BB7F3C
		// (set) Token: 0x0600C8C7 RID: 51399 RVA: 0x00BB9DF4 File Offset: 0x00BB7FF4
		public bool CnvPerOneTouchButton_A19765_Editable
		{
			get
			{
				short num = (short)1828978689;
				if (num != 0)
				{
				}
				num = (short)881701904;
				short num2 = num;
				num = (short)1347073040;
				switch (num2 == num)
				{
				}
				num = (short)1398669312;
				if (num != 0)
				{
				}
				num = (short)665190400;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.Editable;
			}
			set
			{
				short num = (short)1870005455;
				short num2 = num;
				num = (short)469238991;
				switch (num2 == num)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				num = (short)1575550976;
				if (num != 0)
				{
				}
				num = (short)364838912;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.Editable = value;
			}
		}

		// Token: 0x170064B3 RID: 25779
		// (get) Token: 0x0600C8C8 RID: 51400 RVA: 0x00BB9EA8 File Offset: 0x00BB80A8
		internal string CnvPerOneTouchButton_A19765_UILabel
		{
			get
			{
				short num = (short)896139265;
				if (num != 0)
				{
				}
				num = (short)1872230279;
				short num2 = num;
				num = (short)1094514567;
				switch (num2 == num)
				{
				}
				num = (short)1558052864;
				if (num != 0)
				{
				}
				num = (short)133365760;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.UIName;
			}
		}

		// Token: 0x170064B4 RID: 25780
		// (get) Token: 0x0600C8C9 RID: 51401 RVA: 0x00BB9F5C File Offset: 0x00BB815C
		// (set) Token: 0x0600C8CA RID: 51402 RVA: 0x00BBA014 File Offset: 0x00BB8214
		internal bool CnvPerOneTouchButton_A19765_HiddenStatic
		{
			get
			{
				short num = (short)512551684;
				short num2 = num;
				num = (short)1064495876;
				switch (num2 == num)
				{
				}
				num = (short)971833345;
				if (num != 0)
				{
				}
				num = (short)1276379136;
				if (num != 0)
				{
				}
				num = (short)1122959360;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.HiddenStatic;
			}
			set
			{
				short num = (short)116406964;
				short num2 = num;
				num = (short)1936210612;
				switch (num2 == num)
				{
				}
				num = (short)556269569;
				if (num != 0)
				{
				}
				num = (short)158466048;
				if (num != 0)
				{
				}
				num = (short)339935232;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.HiddenStatic = value;
			}
		}

		// Token: 0x170064B5 RID: 25781
		// (get) Token: 0x0600C8CB RID: 51403 RVA: 0x00BBA0C8 File Offset: 0x00BB82C8
		// (set) Token: 0x0600C8CC RID: 51404 RVA: 0x00BBA17C File Offset: 0x00BB837C
		internal bool CnvPerOneTouchButton_A19765_HiddenDynamic
		{
			get
			{
				short num = (short)754908012;
				short num2 = num;
				num = (short)285277036;
				switch (num2 == num)
				{
				}
				num = (short)1525809152;
				if (num != 0)
				{
				}
				num = (short)729219073;
				if (num != 0)
				{
				}
				num = (short)365756416;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765.HiddenDynamic;
			}
			set
			{
				short num = (short)1371762675;
				short num2 = num;
				num = (short)2106355699;
				switch (num2 == num)
				{
				}
				num = (short)1998716929;
				if (num != 0)
				{
				}
				num = (short)102825984;
				if (num != 0)
				{
				}
				num = (short)202702848;
				short num3 = num;
				this.cnvPerOneTouchButton_A19765.HiddenDynamic = value;
			}
		}

		// Token: 0x170064B6 RID: 25782
		// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x00BBA230 File Offset: 0x00BB8430
		public bool CnvPerOneTouchButton_A19765_HasDiffs
		{
			get
			{
				short num = (short)1038933612;
				short num2 = num;
				num = (short)1280892524;
				switch (num2 == num)
				{
				}
				num = (short)1966081;
				if (num != 0)
				{
				}
				num = (short)762970112;
				if (num != 0)
				{
				}
				num = (short)1506541568;
				short num3 = num;
				return this.cnvPerOneTouchButton_A19765._HasDiffs;
			}
		}

		// Token: 0x170064B7 RID: 25783
		// (get) Token: 0x0600C8CE RID: 51406 RVA: 0x00BBA2E4 File Offset: 0x00BB84E4
		// (set) Token: 0x0600C8CF RID: 51407 RVA: 0x00BBA39C File Offset: 0x00BB859C
		public int CnvPerOneTouchIndex_A19663Value
		{
			get
			{
				short num = (short)727714590;
				short num2 = num;
				num = (short)223808286;
				switch (num2 == num)
				{
				}
				num = (short)1625423872;
				if (num != 0)
				{
				}
				num = (short)861077505;
				if (num != 0)
				{
				}
				num = (short)1118568448;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Value;
			}
			set
			{
				short num = (short)2138439681;
				if (num != 0)
				{
				}
				num = (short)123029220;
				short num2 = num;
				num = (short)1679640292;
				switch (num2 == num)
				{
				}
				num = (short)356057088;
				if (num != 0)
				{
				}
				num = (short)183959552;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Value = value;
			}
		}

		// Token: 0x170064B8 RID: 25784
		// (get) Token: 0x0600C8D0 RID: 51408 RVA: 0x00BBA454 File Offset: 0x00BB8654
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerOneTouchIndex_A19663
		{
			get
			{
				short num = (short)563934350;
				short num2 = num;
				num = (short)1258615950;
				switch (num2 == num)
				{
				}
				num = (short)2038890496;
				if (num != 0)
				{
				}
				num = (short)194576385;
				if (num != 0)
				{
				}
				num = (short)853803008;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663;
			}
		}

		// Token: 0x170064B9 RID: 25785
		// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x00BBA504 File Offset: 0x00BB8704
		// (set) Token: 0x0600C8D2 RID: 51410 RVA: 0x00BBA5BC File Offset: 0x00BB87BC
		public string CnvPerOneTouchIndex_A19663_UIValue
		{
			get
			{
				short num = (short)51361586;
				short num2 = num;
				num = (short)1805891378;
				switch (num2 == num)
				{
				}
				num = (short)529072129;
				if (num != 0)
				{
				}
				num = (short)1374486528;
				if (num != 0)
				{
				}
				num = (short)1897660416;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.UIValue;
			}
			set
			{
				short num = (short)2131230721;
				if (num != 0)
				{
				}
				num = (short)1884672391;
				short num2 = num;
				num = (short)92787079;
				switch (num2 == num)
				{
				}
				num = (short)93126656;
				if (num != 0)
				{
				}
				num = (short)513736704;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.UIValue = value;
			}
		}

		// Token: 0x170064BA RID: 25786
		// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x00BBA670 File Offset: 0x00BB8870
		// (set) Token: 0x0600C8D4 RID: 51412 RVA: 0x00BBA728 File Offset: 0x00BB8928
		internal int CnvPerOneTouchIndex_A19663Min
		{
			get
			{
				short num = (short)1063197554;
				short num2 = num;
				num = (short)1258298226;
				switch (num2 == num)
				{
				}
				num = (short)680394752;
				if (num != 0)
				{
				}
				num = (short)1401749505;
				if (num != 0)
				{
				}
				num = (short)804782080;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Min;
			}
			set
			{
				short num = (short)79838905;
				short num2 = num;
				num = (short)1812872889;
				switch (num2 == num)
				{
				}
				num = (short)71172097;
				if (num != 0)
				{
				}
				num = (short)1231749120;
				if (num != 0)
				{
				}
				num = (short)1473118208;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Min = value;
			}
		}

		// Token: 0x170064BB RID: 25787
		// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x00BBA7DC File Offset: 0x00BB89DC
		// (set) Token: 0x0600C8D6 RID: 51414 RVA: 0x00BBA890 File Offset: 0x00BB8A90
		internal int CnvPerOneTouchIndex_A19663Max
		{
			get
			{
				short num = (short)1601120242;
				short num2 = num;
				num = (short)2126915570;
				switch (num2 == num)
				{
				}
				num = (short)1751187457;
				if (num != 0)
				{
				}
				num = (short)95027200;
				if (num != 0)
				{
				}
				num = (short)1384120320;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Max;
			}
			set
			{
				short num = (short)2107170669;
				short num2 = num;
				num = (short)254140269;
				switch (num2 == num)
				{
				}
				num = (short)1159987200;
				if (num != 0)
				{
				}
				num = (short)318308353;
				if (num != 0)
				{
				}
				num = (short)1853554688;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Max = value;
			}
		}

		// Token: 0x170064BC RID: 25788
		// (get) Token: 0x0600C8D7 RID: 51415 RVA: 0x00BBA948 File Offset: 0x00BB8B48
		// (set) Token: 0x0600C8D8 RID: 51416 RVA: 0x00BBA9FC File Offset: 0x00BB8BFC
		internal int CnvPerOneTouchIndex_A19663Step
		{
			get
			{
				short num = (short)1050806364;
				short num2 = num;
				num = (short)4655196;
				switch (num2 == num)
				{
				}
				num = (short)544931841;
				if (num != 0)
				{
				}
				num = (short)434896896;
				if (num != 0)
				{
				}
				num = (short)275644416;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.StepSize;
			}
			set
			{
				short num = (short)1399019563;
				short num2 = num;
				num = (short)936794155;
				switch (num2 == num)
				{
				}
				num = (short)1454309377;
				if (num != 0)
				{
				}
				num = (short)822673408;
				if (num != 0)
				{
				}
				num = (short)190644224;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.StepSize = value;
			}
		}

		// Token: 0x170064BD RID: 25789
		// (get) Token: 0x0600C8D9 RID: 51417 RVA: 0x00BBAAB4 File Offset: 0x00BB8CB4
		// (set) Token: 0x0600C8DA RID: 51418 RVA: 0x00BBAB68 File Offset: 0x00BB8D68
		public bool CnvPerOneTouchIndex_A19663_Applicable
		{
			get
			{
				short num = (short)5832705;
				if (num != 0)
				{
				}
				num = (short)1206581882;
				short num2 = num;
				num = (short)1714027130;
				switch (num2 == num)
				{
				}
				num = (short)1208156160;
				if (num != 0)
				{
				}
				num = (short)1843855360;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Applicable;
			}
			set
			{
				short num = (short)2052249167;
				short num2 = num;
				num = (short)1234490959;
				switch (num2 == num)
				{
				}
				num = (short)1848246273;
				if (num != 0)
				{
				}
				num = (short)1013317632;
				if (num != 0)
				{
				}
				num = (short)644284416;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Applicable = value;
			}
		}

		// Token: 0x170064BE RID: 25790
		// (get) Token: 0x0600C8DB RID: 51419 RVA: 0x00BBAC20 File Offset: 0x00BB8E20
		// (set) Token: 0x0600C8DC RID: 51420 RVA: 0x00BBACD4 File Offset: 0x00BB8ED4
		public bool CnvPerOneTouchIndex_A19663_Valid
		{
			get
			{
				short num = (short)66978473;
				short num2 = num;
				num = (short)1769472681;
				switch (num2 == num)
				{
				}
				num = (short)182845441;
				if (num != 0)
				{
				}
				num = (short)448069632;
				if (num != 0)
				{
				}
				num = (short)1701576704;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Valid;
			}
			set
			{
				short num = (short)2005339891;
				short num2 = num;
				num = (short)1026887411;
				switch (num2 == num)
				{
				}
				num = (short)902758401;
				if (num != 0)
				{
				}
				num = (short)1047920640;
				if (num != 0)
				{
				}
				num = (short)1501102080;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Valid = value;
			}
		}

		// Token: 0x170064BF RID: 25791
		// (get) Token: 0x0600C8DD RID: 51421 RVA: 0x00BBAD88 File Offset: 0x00BB8F88
		// (set) Token: 0x0600C8DE RID: 51422 RVA: 0x00BBAE38 File Offset: 0x00BB9038
		public bool CnvPerOneTouchIndex_A19663_Visible
		{
			get
			{
				short num = (short)241774207;
				short num2 = num;
				num = (short)738340479;
				switch (num2 == num)
				{
				}
				num = (short)565051393;
				if (num != 0)
				{
				}
				num = (short)2133000192;
				if (num != 0)
				{
				}
				num = (short)1384710144;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Visible;
			}
			set
			{
				short num = (short)404725775;
				short num2 = num;
				num = (short)1603706895;
				switch (num2 == num)
				{
				}
				num = (short)809762817;
				if (num != 0)
				{
				}
				num = (short)1154351104;
				if (num != 0)
				{
				}
				num = (short)526778368;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Visible = value;
			}
		}

		// Token: 0x170064C0 RID: 25792
		// (get) Token: 0x0600C8DF RID: 51423 RVA: 0x00BBAEEC File Offset: 0x00BB90EC
		// (set) Token: 0x0600C8E0 RID: 51424 RVA: 0x00BBAFA4 File Offset: 0x00BB91A4
		public bool CnvPerOneTouchIndex_A19663_Editable
		{
			get
			{
				short num = (short)1342373889;
				if (num != 0)
				{
				}
				num = (short)202506605;
				short num2 = num;
				num = (short)692715885;
				switch (num2 == num)
				{
				}
				num = (short)1055522816;
				if (num != 0)
				{
				}
				num = (short)1222639616;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.Editable;
			}
			set
			{
				short num = (short)218828207;
				short num2 = num;
				num = (short)919866799;
				switch (num2 == num)
				{
				}
				num = (short)1257766912;
				if (num != 0)
				{
				}
				num = (short)1077018625;
				if (num != 0)
				{
				}
				num = (short)748617728;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.Editable = value;
			}
		}

		// Token: 0x170064C1 RID: 25793
		// (get) Token: 0x0600C8E1 RID: 51425 RVA: 0x00BBB058 File Offset: 0x00BB9258
		internal string CnvPerOneTouchIndex_A19663_UILabel
		{
			get
			{
				short num = (short)1840817257;
				short num2 = num;
				num = (short)262644841;
				switch (num2 == num)
				{
				}
				num = (short)343801856;
				if (num != 0)
				{
				}
				num = (short)983498753;
				if (num != 0)
				{
				}
				num = (short)566362112;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.UIName;
			}
		}

		// Token: 0x170064C2 RID: 25794
		// (get) Token: 0x0600C8E2 RID: 51426 RVA: 0x00BBB10C File Offset: 0x00BB930C
		// (set) Token: 0x0600C8E3 RID: 51427 RVA: 0x00BBB1C0 File Offset: 0x00BB93C0
		internal bool CnvPerOneTouchIndex_A19663_HiddenStatic
		{
			get
			{
				short num = (short)417291539;
				short num2 = num;
				num = (short)795761939;
				switch (num2 == num)
				{
				}
				num = (short)775094272;
				if (num != 0)
				{
				}
				num = (short)1979121665;
				if (num != 0)
				{
				}
				num = (short)189726720;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.HiddenStatic;
			}
			set
			{
				short num = (short)1631124034;
				short num2 = num;
				num = (short)1645017666;
				switch (num2 == num)
				{
				}
				num = (short)692649985;
				if (num != 0)
				{
				}
				num = (short)897581056;
				if (num != 0)
				{
				}
				num = (short)406192128;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.HiddenStatic = value;
			}
		}

		// Token: 0x170064C3 RID: 25795
		// (get) Token: 0x0600C8E4 RID: 51428 RVA: 0x00BBB278 File Offset: 0x00BB9478
		// (set) Token: 0x0600C8E5 RID: 51429 RVA: 0x00BBB32C File Offset: 0x00BB952C
		internal bool CnvPerOneTouchIndex_A19663_HiddenDynamic
		{
			get
			{
				short num = (short)1613217260;
				short num2 = num;
				num = (short)1069006316;
				switch (num2 == num)
				{
				}
				num = (short)201129985;
				if (num != 0)
				{
				}
				num = (short)69533696;
				if (num != 0)
				{
				}
				num = (short)363528192;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663.HiddenDynamic;
			}
			set
			{
				short num = (short)335291073;
				short num2 = num;
				num = (short)1919951553;
				switch (num2 == num)
				{
				}
				num = (short)482869248;
				if (num != 0)
				{
				}
				num = (short)1911685121;
				if (num != 0)
				{
				}
				num = (short)597819392;
				short num3 = num;
				this.cnvPerOneTouchIndex_A19663.HiddenDynamic = value;
			}
		}

		// Token: 0x170064C4 RID: 25796
		// (get) Token: 0x0600C8E6 RID: 51430 RVA: 0x00BBB3E0 File Offset: 0x00BB95E0
		public bool CnvPerOneTouchIndex_A19663_HasDiffs
		{
			get
			{
				short num = (short)2010176030;
				short num2 = num;
				num = (short)1836964382;
				switch (num2 == num)
				{
				}
				num = (short)1990721537;
				if (num != 0)
				{
				}
				num = (short)1735262208;
				if (num != 0)
				{
				}
				num = (short)708771840;
				short num3 = num;
				return this.cnvPerOneTouchIndex_A19663._HasDiffs;
			}
		}

		// Token: 0x170064C5 RID: 25797
		// (get) Token: 0x0600C8E7 RID: 51431 RVA: 0x00BBB494 File Offset: 0x00BB9694
		// (set) Token: 0x0600C8E8 RID: 51432 RVA: 0x00BBB544 File Offset: 0x00BB9744
		public string CnvPerOneTouchAbbreviatedOneTouchAlias_A19664Value
		{
			get
			{
				short num = (short)967653633;
				short num2 = num;
				num = (short)40646913;
				switch (num2 == num)
				{
				}
				num = (short)1050345473;
				if (num != 0)
				{
				}
				num = (short)1201995776;
				if (num != 0)
				{
				}
				num = (short)718340096;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Value;
			}
			set
			{
				short num = (short)1912002953;
				short num2 = num;
				num = (short)744348041;
				switch (num2 == num)
				{
				}
				num = (short)2100297729;
				if (num != 0)
				{
				}
				num = (short)1442119680;
				if (num != 0)
				{
				}
				num = (short)313524224;
				short num3 = num;
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Value = value;
			}
		}

		// Token: 0x170064C6 RID: 25798
		// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x00BBB5F8 File Offset: 0x00BB97F8
		public global::AcpBusinessLayer.AcpField<string> CnvPerOneTouchAbbreviatedOneTouchAlias_A19664
		{
			get
			{
				short num = (short)214016943;
				short num2 = num;
				num = (short)1949017007;
				switch (num2 == num)
				{
				}
				num = (short)1681915905;
				if (num != 0)
				{
				}
				num = (short)71172096;
				if (num != 0)
				{
				}
				num = (short)1471414272;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664;
			}
		}

		// Token: 0x170064C7 RID: 25799
		// (get) Token: 0x0600C8EA RID: 51434 RVA: 0x00BBB6A8 File Offset: 0x00BB98A8
		// (set) Token: 0x0600C8EB RID: 51435 RVA: 0x00BBB75C File Offset: 0x00BB995C
		public string CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_UIValue
		{
			get
			{
				short num = (short)967601355;
				short num2 = num;
				num = (short)644639947;
				switch (num2 == num)
				{
				}
				num = (short)1824522241;
				if (num != 0)
				{
				}
				num = (short)266600448;
				if (num != 0)
				{
				}
				num = (short)740950016;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Value;
			}
			set
			{
				short num = (short)1246147372;
				short num2 = num;
				num = (short)1271116588;
				switch (num2 == num)
				{
				}
				num = (short)570621952;
				if (num != 0)
				{
				}
				num = (short)438370305;
				if (num != 0)
				{
				}
				num = (short)638058496;
				short num3 = num;
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Value = value;
			}
		}

		// Token: 0x170064C8 RID: 25800
		// (get) Token: 0x0600C8EC RID: 51436 RVA: 0x00BBB810 File Offset: 0x00BB9A10
		// (set) Token: 0x0600C8ED RID: 51437 RVA: 0x00BBB8C0 File Offset: 0x00BB9AC0
		public bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_Applicable
		{
			get
			{
				short num = (short)1498779518;
				short num2 = num;
				num = (short)1896910718;
				switch (num2 == num)
				{
				}
				num = (short)243269633;
				if (num != 0)
				{
				}
				num = (short)1931018240;
				if (num != 0)
				{
				}
				num = (short)832307200;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Applicable;
			}
			set
			{
				short num = (short)323990739;
				short num2 = num;
				num = (short)2086319315;
				switch (num2 == num)
				{
				}
				num = (short)1875836929;
				if (num != 0)
				{
				}
				num = (short)463011840;
				if (num != 0)
				{
				}
				num = (short)1700003840;
				short num3 = num;
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Applicable = value;
			}
		}

		// Token: 0x170064C9 RID: 25801
		// (get) Token: 0x0600C8EE RID: 51438 RVA: 0x00BBB978 File Offset: 0x00BB9B78
		// (set) Token: 0x0600C8EF RID: 51439 RVA: 0x00BBBA2C File Offset: 0x00BB9C2C
		public bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_Valid
		{
			get
			{
				short num = (short)235405313;
				if (num != 0)
				{
				}
				num = (short)1503193858;
				short num2 = num;
				num = (short)642837250;
				switch (num2 == num)
				{
				}
				num = (short)230817792;
				if (num != 0)
				{
				}
				num = (short)1718091776;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Valid;
			}
			set
			{
				short num = (short)305889232;
				short num2 = num;
				num = (short)417431504;
				switch (num2 == num)
				{
				}
				num = (short)343605249;
				if (num != 0)
				{
				}
				num = (short)459407360;
				if (num != 0)
				{
				}
				num = (short)209190912;
				short num3 = num;
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Valid = value;
			}
		}

		// Token: 0x170064CA RID: 25802
		// (get) Token: 0x0600C8F0 RID: 51440 RVA: 0x00BBBAE0 File Offset: 0x00BB9CE0
		// (set) Token: 0x0600C8F1 RID: 51441 RVA: 0x00BBBB94 File Offset: 0x00BB9D94
		public bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_Visible
		{
			get
			{
				short num = (short)877285350;
				short num2 = num;
				num = (short)598757350;
				switch (num2 == num)
				{
				}
				num = (short)2124742656;
				if (num != 0)
				{
				}
				num = (short)1203765249;
				if (num != 0)
				{
				}
				num = (short)1663369216;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Visible;
			}
			set
			{
				short num = (short)1449164254;
				short num2 = num;
				num = (short)153058782;
				switch (num2 == num)
				{
				}
				num = (short)1581711360;
				if (num != 0)
				{
				}
				num = (short)1879638017;
				if (num != 0)
				{
				}
				num = (short)1068367872;
				short num3 = num;
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Visible = value;
			}
		}

		// Token: 0x170064CB RID: 25803
		// (get) Token: 0x0600C8F2 RID: 51442 RVA: 0x00BBBC4C File Offset: 0x00BB9E4C
		// (set) Token: 0x0600C8F3 RID: 51443 RVA: 0x00BBBD00 File Offset: 0x00BB9F00
		public bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_Editable
		{
			get
			{
				short num = (short)1452369538;
				short num2 = num;
				num = (short)816277122;
				switch (num2 == num)
				{
				}
				num = (short)876806145;
				if (num != 0)
				{
				}
				num = (short)611188736;
				if (num != 0)
				{
				}
				num = (short)1315897344;
				short num3 = num;
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Editable;
			}
			set
			{
				short num = (short)1059973614;
				short num2 = num;
				num = (short)302442990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820196864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)958267392;
				if (num != 0)
				{
				}
				num = (short)361037825;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.Editable = value;
			}
		}

		// Token: 0x170064CC RID: 25804
		// (get) Token: 0x0600C8F4 RID: 51444 RVA: 0x00BBBDB4 File Offset: 0x00BB9FB4
		internal string CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_UILabel
		{
			get
			{
				short num = (short)25911759;
				short num2 = num;
				num = (short)1950507471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)877461504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)279379969;
				if (num != 0)
				{
				}
				num = (short)366739456;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.UIName;
			}
		}

		// Token: 0x170064CD RID: 25805
		// (get) Token: 0x0600C8F5 RID: 51445 RVA: 0x00BBBE6C File Offset: 0x00BBA06C
		// (set) Token: 0x0600C8F6 RID: 51446 RVA: 0x00BBBF20 File Offset: 0x00BBA120
		internal bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_HiddenStatic
		{
			get
			{
				short num = (short)462485584;
				short num2 = num;
				num = (short)1118042192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1709637632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852243969;
				if (num != 0)
				{
				}
				num = (short)908853248;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.HiddenStatic;
			}
			set
			{
				short num = (short)1571166912;
				short num2 = num;
				num = (short)548281024;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302252032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383923712;
				if (num != 0)
				{
				}
				num = (short)506003457;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.HiddenStatic = value;
			}
		}

		// Token: 0x170064CE RID: 25806
		// (get) Token: 0x0600C8F7 RID: 51447 RVA: 0x00BBBFD4 File Offset: 0x00BBA1D4
		// (set) Token: 0x0600C8F8 RID: 51448 RVA: 0x00BBC090 File Offset: 0x00BBA290
		internal bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_HiddenDynamic
		{
			get
			{
				short num = (short)1181780313;
				short num2 = num;
				num = (short)752585049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680998400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1685913601;
				if (num != 0)
				{
				}
				num = (short)103940096;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.HiddenDynamic;
			}
			set
			{
				short num = (short)380761491;
				short num2 = num;
				num = (short)1969091987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2075721728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205075969;
				if (num != 0)
				{
				}
				num = (short)904790016;
				if (num != 0)
				{
				}
				this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664.HiddenDynamic = value;
			}
		}

		// Token: 0x170064CF RID: 25807
		// (get) Token: 0x0600C8F9 RID: 51449 RVA: 0x00BBC148 File Offset: 0x00BBA348
		public bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_HasDiffs
		{
			get
			{
				short num = (short)728984020;
				short num2 = num;
				num = (short)1529440724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671102464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844890112;
				if (num != 0)
				{
				}
				num = (short)678887425;
				if (num != 0)
				{
				}
				return this.cnvPerOneTouchAbbreviatedOneTouchAlias_A19664._HasDiffs;
			}
		}

		// Token: 0x170064D0 RID: 25808
		// (get) Token: 0x0600C8FA RID: 51450 RVA: 0x00BBC200 File Offset: 0x00BBA400
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)402962625;
				short num2 = num;
				num = (short)27179201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403374080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61669376;
				if (num != 0)
				{
				}
				num = (short)1873739777;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x170064D1 RID: 25809
		// (get) Token: 0x0600C8FB RID: 51451 RVA: 0x00BBC2BC File Offset: 0x00BBA4BC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1236951594;
				short num2 = num;
				num = (short)1930388010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513291776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1328152577;
				if (num != 0)
				{
				}
				num = (short)1813315584;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x0600C8FC RID: 51452 RVA: 0x00BBC37C File Offset: 0x00BBA57C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1627507374;
			short num2 = num;
			num = (short)1626720942;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B3:
				num = (short)47316992;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1761345536;
				if (num != 0)
				{
				}
				num = (short)1394475009;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_7B:
				switch (num3)
				{
				case 0:
					num = (short)136380419;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1072431106;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F0;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)832176129;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				case 4:
					goto IL_AB;
				}
				goto IL_95;
			}
			IL_AB:
			if (base.ParentRecset != null)
			{
				goto IL_B3;
			}
			IL_F0:
			IL_12F:
			num = (short)1536032768;
			short num4 = num;
			return result;
			IL_95:
			result = null;
			num = (short)948568068;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7B;
		}

		// Token: 0x040064C3 RID: 25795
		private global::AcpBusinessLayer.AcpListField cnvPerOneTouchFeature_A19662;

		// Token: 0x040064C4 RID: 25796
		private global::AcpBusinessLayer.AcpKeyField cnvPerOneTouchButton_A19765;

		// Token: 0x040064C5 RID: 25797
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerOneTouchIndex_A19663;

		// Token: 0x040064C6 RID: 25798
		private global::AcpBusinessLayer.AcpField<string> cnvPerOneTouchAbbreviatedOneTouchAlias_A19664;
	}
}
