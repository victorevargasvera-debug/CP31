using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000D4 RID: 212
	[global::System.Serializable]
	public class ASTROOTAR : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001E4F RID: 7759 RVA: 0x001E2F04 File Offset: 0x001E1104
		public ASTROOTAR(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x001E2F20 File Offset: 0x001E1120
		protected ASTROOTAR(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x001E2F38 File Offset: 0x001E1138
		public override void Init()
		{
			int a_ = 13;
			short num = (short)62606358;
			short num2 = num;
			num = (short)262425622;
			switch (num2 == num)
			{
			}
			num = (short)636420097;
			if (num != 0)
			{
			}
			num = (short)1598160896;
			short num3 = num;
			num = (short)899547136;
			if (num != 0)
			{
			}
			this.secWideASTROOTARASTROOTAREnable_A7496 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙鷛距듟냡ꯣꧥ볧ꯩ뻫꿭ꏯ꛱꛳맵럷껹뷻곽䗿氁攃搅搇漉匋伍✏☑ⴓ―", a_), global::CommonResources.AcgResources.ID_ASTROOTARENABLE);
			this.secWideASTROOTARASTROOTAREnable_A7496.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideASTROOTARASTROOTAREnable_A7496.DataTransferOrder = 4;
			this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙鷛距듟냡ꯣꧥ볧ꯩ뻫볭釯雱鷳駵뇷铹铻韽拿欁瀃瀅愇欉䴋崍䐏䀑嬓夕䰗嬙丛䄝感ᨡᰣᔥᰧ", a_), global::CommonResources.AcgResources.ID_RADIOINHIBITVIAASTROOTAR);
			this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.DataTransferOrder = 39;
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙鷛距듟냡ꯣꧥ볧ꯩ뻫꟭黯雱鷳胵釷黹觻鿽泿䌁圃刅娇䔉䌋娍儏䀑䘓眕簗猙猛圝搟紡攣ḥᨧሩᠫ", a_), global::CommonResources.AcgResources.ID_INDIVIDUALASTROOTARRADIOID, 0, 9999999, null, null, 0, 1);
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.DataTransferOrder = 33;
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迍菏蛑蛓駕闙裛鿝닟", a_);
			base.Id = 10042;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTAR;
			base.DataTransferOrder = 3;
			this.PostInit();
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x001E30E0 File Offset: 0x001E12E0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)211222528;
			short num2 = num;
			num = (short)1001259019;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					this.secWideASTROOTARIndividualASTROOTARRadioID_A8284 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꇟ뇡냣듥꟧ꗩ룫꿭ꋯ믱髳鋵釷賹闻髽痿持栃䜅嬇帉帋䄍式䘑唓䐕䨗笙砛眝伟次怣礥椧ሩḫᘭЯ", a_), global::CommonResources.AcgResources.ID_INDIVIDUALASTROOTARRADIOID, null, null, 0, 1);
					this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.DataTransferOrder = 33;
					this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.ShowHexValue = false;
					num = (short)2070622492;
					short num4 = num;
					num = (short)804598044;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28C;
					default:
						num = (short)1607598080;
						if (num != 0)
						{
						}
						num = (short)1857749000;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꇟ뇡냣듥꟧ꗩ룫꿭ꋯ믱髳鋵釷賹闻髽痿持栃䜅嬇帉帋䄍式䘑唓䐕䨗笙砛眝伟次怣礥椧ሩḫᘭЯ", a_)))
					{
						num = (short)1180106752;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34E;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꇟ뇡냣듥꟧ꗩ룫꿭ꋯ돱ꟳꋵ꫷뗹돻꫽䇿倁䄃栅椇栉怋欍伏匑⌓∕℗Ⱉ", a_)))
					{
						num = (short)1149894666;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12F;
				case 3:
					num = (short)515506185;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)500760578;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2AE;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꇟ뇡냣듥꟧ꗩ룫꿭ꋯꃱ闳鋵釷闹뗻都棿欁昃漅簇簉攋漍儏䄑䀓䐕圗唙䠛弝爟紡攣ḥဧᤩᠫ", a_)))
					{
						num = (short)875495436;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 7:
					goto IL_12F;
				case 8:
					goto IL_270;
				case 9:
					goto IL_28C;
				case 10:
					this.secWideASTROOTARASTROOTAREnable_A7496 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꇟ뇡냣듥꟧ꗩ룫꿭ꋯ돱ꟳꋵ꫷뗹돻꫽䇿倁䄃栅椇栉怋欍伏匑⌓∕℗Ⱉ", a_), global::CommonResources.AcgResources.ID_ASTROOTARENABLE);
					this.secWideASTROOTARASTROOTAREnable_A7496.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideASTROOTARASTROOTAREnable_A7496.DataTransferOrder = 4;
					num = (short)834273287;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 12:
					this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝ꇟ뇡냣듥꟧ꗩ룫꿭ꋯꃱ闳鋵釷闹뗻都棿欁昃漅簇簉攋漍儏䄑䀓䐕圗唙䠛弝爟紡攣ḥဧᤩᠫ", a_), global::CommonResources.AcgResources.ID_RADIOINHIBITVIAASTROOTAR);
					this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.DataTransferOrder = 39;
					num = (short)974389253;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1807613953;
					if (num != 0)
					{
					}
					num = (short)1980825603;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_12F:
				num = (short)811270150;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_28C:
				if (producerFields != null)
				{
					num = (short)1704787972;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2AE:
				num = (short)1791950849;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_270:
			IL_34E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏑蟓苕諗闙ﳛ針듟ꏡ뛣", a_);
			base.Id = 10042;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROOTAR;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x001E346C File Offset: 0x001E166C
		public override void PopulateReferences()
		{
			short num = (short)702633481;
			short num2 = num;
			num = (short)638277129;
			switch (num2 == num)
			{
			}
			num = (short)596574208;
			if (num != 0)
			{
			}
			num = (short)1857552384;
			short num3 = num;
			num = (short)405340161;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x001E3518 File Offset: 0x001E1718
		public override void DropReferences()
		{
			short num = (short)1025072013;
			short num2 = num;
			num = (short)2907021;
			switch (num2 == num)
			{
			}
			num = (short)1712521217;
			if (num != 0)
			{
			}
			num = (short)1710817280;
			short num3 = num;
			num = (short)1578237952;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x001E35C4 File Offset: 0x001E17C4
		public override void SetConstraints()
		{
			short num = (short)959553;
			short num2 = num;
			num = (short)249799745;
			switch (num2 == num)
			{
			}
			num = (short)776536065;
			if (num != 0)
			{
			}
			num = (short)2109603840;
			short num3 = num;
			num = (short)1890910208;
			if (num != 0)
			{
			}
			this.secWideASTROOTARASTROOTAREnable_A7496.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConAstroOtarIsApp);
			this.secWideASTROOTARASTROOTAREnable_A7496.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConAstroOtarEnableInvalidIfOtarEnabledAndSecureIsHardware);
			this.secWideASTROOTARASTROOTAREnable_A7496.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conAstroOtarIsEditable);
			this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conSecRadInhIsEditable);
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConASTROOTARRadioIDVallid);
			this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conInvisiableWhenOpenFromRMC);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x001E3724 File Offset: 0x001E1924
		public override void SetupDependencies()
		{
			short num = (short)1441267713;
			if (num != 0)
			{
			}
			num = (short)144562908;
			short num2 = num;
			num = (short)288545500;
			switch (num2 == num)
			{
			}
			num = (short)169017344;
			short num3 = num;
			num = (short)597032960;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideASTROOTARASTROOTAREnable_A7496);
			secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideASTROOTARASTROOTAREnable_A7496);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideASTROOTARASTROOTAREnable_A7496);
			secureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideASTROOTARASTROOTAREnable_A7496);
			this.secWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834);
			secureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834);
			this.secWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secWideASTROOTARIndividualASTROOTARRadioID_A8284);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideASTROOTARIndividualASTROOTARRadioID_A8284);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideASTROOTARIndividualASTROOTARRadioID_A8284);
			secureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideASTROOTARIndividualASTROOTARRadioID_A8284);
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x001E38E4 File Offset: 0x001E1AE4
		public bool HasDiffs
		{
			get
			{
				short num = (short)839749793;
				short num2 = num;
				num = (short)894734497;
				switch (num2 == num)
				{
				}
				num = (short)304087041;
				if (num != 0)
				{
				}
				num = (short)928120832;
				short num3 = num;
				num = (short)1442709504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x001E3994 File Offset: 0x001E1B94
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x001E3A50 File Offset: 0x001E1C50
		public bool SecWideASTROOTARASTROOTAREnable_A7496Value
		{
			get
			{
				short num = (short)1751168439;
				short num2 = num;
				num = (short)1382593975;
				switch (num2 == num)
				{
				}
				num = (short)1904082945;
				if (num != 0)
				{
				}
				num = (short)876544000;
				short num3 = num;
				num = (short)1761542144;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.Value;
			}
			set
			{
				short num = (short)53264106;
				short num2 = num;
				num = (short)468762346;
				switch (num2 == num)
				{
				}
				num = (short)1276772352;
				if (num != 0)
				{
				}
				num = (short)959512576;
				short num3 = num;
				num = (short)1490485249;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.Value = value;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x001E3B04 File Offset: 0x001E1D04
		public global::AcpBusinessLayer.AcpField<bool> SecWideASTROOTARASTROOTAREnable_A7496
		{
			get
			{
				short num = (short)473417324;
				short num2 = num;
				num = (short)686605932;
				switch (num2 == num)
				{
				}
				num = (short)626130945;
				if (num != 0)
				{
				}
				num = (short)518062080;
				short num3 = num;
				num = (short)1888026624;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x001E3BB4 File Offset: 0x001E1DB4
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x001E3C68 File Offset: 0x001E1E68
		public bool SecWideASTROOTARASTROOTAREnable_A7496_UIValue
		{
			get
			{
				short num = (short)961282049;
				if (num != 0)
				{
				}
				num = (short)1999635983;
				short num2 = num;
				num = (short)1174996495;
				switch (num2 == num)
				{
				}
				num = (short)1029111808;
				short num3 = num;
				num = (short)1710358528;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.Value;
			}
			set
			{
				short num = (short)1265132299;
				short num2 = num;
				num = (short)2014995211;
				switch (num2 == num)
				{
				}
				num = (short)779091969;
				if (num != 0)
				{
				}
				num = (short)1848770560;
				short num3 = num;
				num = (short)1895759872;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.Value = value;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x001E3D20 File Offset: 0x001E1F20
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x001E3DD8 File Offset: 0x001E1FD8
		public bool SecWideASTROOTARASTROOTAREnable_A7496_Applicable
		{
			get
			{
				short num = (short)1898645013;
				short num2 = num;
				num = (short)1041237525;
				switch (num2 == num)
				{
				}
				num = (short)1525678081;
				if (num != 0)
				{
				}
				num = (short)653262848;
				short num3 = num;
				num = (short)820248576;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.Applicable;
			}
			set
			{
				short num = (short)1517764709;
				short num2 = num;
				num = (short)308494437;
				switch (num2 == num)
				{
				}
				num = (short)133824512;
				if (num != 0)
				{
				}
				num = (short)36831232;
				short num3 = num;
				num = (short)406257665;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.Applicable = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x001E3E90 File Offset: 0x001E2090
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x001E3F40 File Offset: 0x001E2140
		public bool SecWideASTROOTARASTROOTAREnable_A7496_Valid
		{
			get
			{
				short num = (short)1937093306;
				short num2 = num;
				num = (short)1204269754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2001207296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622736897;
				if (num != 0)
				{
				}
				num = (short)628948992;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.Valid;
			}
			set
			{
				short num = (short)1730554031;
				short num2 = num;
				num = (short)1807493295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492385792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1857093633;
				if (num != 0)
				{
				}
				num = (short)1844051968;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.Valid = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x001E3FF8 File Offset: 0x001E21F8
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x001E40AC File Offset: 0x001E22AC
		public bool SecWideASTROOTARASTROOTAREnable_A7496_Visible
		{
			get
			{
				short num = (short)261014515;
				short num2 = num;
				num = (short)1874576371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175715840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1314848768;
				if (num != 0)
				{
				}
				num = (short)292552705;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.Visible;
			}
			set
			{
				short num = (short)1642684963;
				short num2 = num;
				num = (short)661742115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1865482240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1085276160;
				if (num != 0)
				{
				}
				num = (short)680591361;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.Visible = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x001E4164 File Offset: 0x001E2364
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x001E4218 File Offset: 0x001E2418
		public bool SecWideASTROOTARASTROOTAREnable_A7496_Editable
		{
			get
			{
				short num = (short)700579841;
				if (num != 0)
				{
				}
				num = (short)1984102400;
				short num2 = num;
				num = (short)939175324;
				short num3 = num;
				num = (short)686861724;
				switch (num3 == num)
				{
				}
				num = (short)158334976;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.Editable;
			}
			set
			{
				short num = (short)2078015489;
				if (num != 0)
				{
				}
				num = (short)36110336;
				short num2 = num;
				num = (short)942845918;
				short num3 = num;
				num = (short)2050469854;
				switch (num3 == num)
				{
				}
				num = (short)985464832;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.Editable = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x001E42CC File Offset: 0x001E24CC
		internal string SecWideASTROOTARASTROOTAREnable_A7496_UILabel
		{
			get
			{
				short num = (short)1594645472;
				short num2 = num;
				num = (short)1957452768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)884539392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)325386241;
				if (num != 0)
				{
				}
				num = (short)464191488;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.UIName;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x001E4384 File Offset: 0x001E2584
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x001E4438 File Offset: 0x001E2638
		internal bool SecWideASTROOTARASTROOTAREnable_A7496_HiddenStatic
		{
			get
			{
				short num = (short)1096621473;
				short num2 = num;
				num = (short)650190241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270467072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)878379008;
				if (num != 0)
				{
				}
				num = (short)522125313;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.HiddenStatic;
			}
			set
			{
				short num = (short)1185823973;
				short num2 = num;
				num = (short)240401637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)961609728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508690433;
				if (num != 0)
				{
				}
				num = (short)514654208;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.HiddenStatic = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x001E44F0 File Offset: 0x001E26F0
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x001E45A4 File Offset: 0x001E27A4
		internal bool SecWideASTROOTARASTROOTAREnable_A7496_HiddenDynamic
		{
			get
			{
				short num = (short)1154404045;
				short num2 = num;
				num = (short)1172557517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1054015488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)177930240;
				if (num != 0)
				{
				}
				num = (short)733872129;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496.HiddenDynamic;
			}
			set
			{
				short num = (short)1065657787;
				short num2 = num;
				num = (short)1398318523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562378240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264844801;
				if (num != 0)
				{
				}
				num = (short)1290469376;
				if (num != 0)
				{
				}
				this.secWideASTROOTARASTROOTAREnable_A7496.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x001E4658 File Offset: 0x001E2858
		public bool SecWideASTROOTARASTROOTAREnable_A7496_HasDiffs
		{
			get
			{
				short num = (short)377388580;
				short num2 = num;
				num = (short)3112484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1264975872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)813301761;
				if (num != 0)
				{
				}
				num = (short)890830848;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARASTROOTAREnable_A7496._HasDiffs;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x001E470C File Offset: 0x001E290C
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x001E47C0 File Offset: 0x001E29C0
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834Value
		{
			get
			{
				short num = (short)492240897;
				if (num != 0)
				{
				}
				num = (short)1195311104;
				short num2 = num;
				num = (short)95425740;
				short num3 = num;
				num = (short)1547244748;
				switch (num3 == num)
				{
				}
				num = (short)1833107456;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value;
			}
			set
			{
				short num = (short)1362101034;
				short num2 = num;
				num = (short)154272554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1282801664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460259329;
				if (num != 0)
				{
				}
				num = (short)1585053696;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x001E487C File Offset: 0x001E2A7C
		public global::AcpBusinessLayer.AcpField<bool> SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834
		{
			get
			{
				short num = (short)1390256867;
				short num2 = num;
				num = (short)569877219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)592248832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)354877441;
				if (num != 0)
				{
				}
				num = (short)1725956096;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x001E492C File Offset: 0x001E2B2C
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x001E49E4 File Offset: 0x001E2BE4
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_UIValue
		{
			get
			{
				short num = (short)929016150;
				short num2 = num;
				num = (short)1559996758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1464926208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349372416;
				if (num != 0)
				{
				}
				num = (short)1834287105;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value;
			}
			set
			{
				short num = (short)27078471;
				short num2 = num;
				num = (short)1145909063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555352064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)100990976;
				if (num != 0)
				{
				}
				num = (short)47251457;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value = value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x001E4A9C File Offset: 0x001E2C9C
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x001E4B4C File Offset: 0x001E2D4C
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_Applicable
		{
			get
			{
				short num = (short)62861792;
				short num2 = num;
				num = (short)1305883104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639120896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893321217;
				if (num != 0)
				{
				}
				num = (short)1679294464;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Applicable;
			}
			set
			{
				short num = (short)258985480;
				short num2 = num;
				num = (short)1919536648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607794688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)969801728;
				if (num != 0)
				{
				}
				num = (short)1748172801;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Applicable = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x001E4C00 File Offset: 0x001E2E00
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x001E4CB4 File Offset: 0x001E2EB4
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_Valid
		{
			get
			{
				short num = (short)1670856056;
				short num2 = num;
				num = (short)1419001208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709296128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1288830977;
				if (num != 0)
				{
				}
				num = (short)1436942336;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Valid;
			}
			set
			{
				short num = (short)338861510;
				short num2 = num;
				num = (short)1078173126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243007488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168886273;
				if (num != 0)
				{
				}
				num = (short)2138243072;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Valid = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x001E4D68 File Offset: 0x001E2F68
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x001E4E20 File Offset: 0x001E3020
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_Visible
		{
			get
			{
				short num = (short)1887091698;
				short num2 = num;
				num = (short)1802681330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158742016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1192361984;
				if (num != 0)
				{
				}
				num = (short)1199112193;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Visible;
			}
			set
			{
				short num = (short)985653399;
				short num2 = num;
				num = (short)899276951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828506112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2098790400;
				if (num != 0)
				{
				}
				num = (short)717488129;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Visible = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x001E4ED8 File Offset: 0x001E30D8
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x001E4F8C File Offset: 0x001E318C
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_Editable
		{
			get
			{
				short num = (short)1839210054;
				short num2 = num;
				num = (short)1529880134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047606784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1483472896;
				if (num != 0)
				{
				}
				num = (short)644808705;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Editable;
			}
			set
			{
				short num = (short)252168554;
				short num2 = num;
				num = (short)1919076714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097924608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1157365761;
				if (num != 0)
				{
				}
				num = (short)1842020352;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Editable = value;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x001E5040 File Offset: 0x001E3240
		internal string SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_UILabel
		{
			get
			{
				short num = (short)1031124016;
				short num2 = num;
				num = (short)203535408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1877999616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1771503617;
				if (num != 0)
				{
				}
				num = (short)215875584;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.UIName;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x001E50F4 File Offset: 0x001E32F4
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x001E51A8 File Offset: 0x001E33A8
		internal bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_HiddenStatic
		{
			get
			{
				short num = (short)1752800286;
				short num2 = num;
				num = (short)411933726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302186496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1994391553;
				if (num != 0)
				{
				}
				num = (short)1728249856;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.HiddenStatic;
			}
			set
			{
				short num = (short)260505601;
				if (num != 0)
				{
				}
				num = (short)153616384;
				short num2 = num;
				num = (short)177143013;
				short num3 = num;
				num = (short)594935013;
				switch (num3 == num)
				{
				}
				num = (short)1317404672;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.HiddenStatic = value;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x001E5260 File Offset: 0x001E3460
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x001E5314 File Offset: 0x001E3514
		internal bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_HiddenDynamic
		{
			get
			{
				short num = (short)1126332671;
				short num2 = num;
				num = (short)1361279231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2142109696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645267457;
				if (num != 0)
				{
				}
				num = (short)1455292416;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.HiddenDynamic;
			}
			set
			{
				short num = (short)1739160144;
				short num2 = num;
				num = (short)255687248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813694976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1559429120;
				if (num != 0)
				{
				}
				num = (short)760283137;
				if (num != 0)
				{
				}
				this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x001E53C8 File Offset: 0x001E35C8
		public bool SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834_HasDiffs
		{
			get
			{
				short num = (short)1201333177;
				short num2 = num;
				num = (short)999154617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282066944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586285056;
				if (num != 0)
				{
				}
				num = (short)1837105153;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARRadioInhibitviaASTROOTAR_A8834._HasDiffs;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x001E547C File Offset: 0x001E367C
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x001E5530 File Offset: 0x001E3730
		public int SecWideASTROOTARIndividualASTROOTARRadioID_A8284Value
		{
			get
			{
				short num = (short)130186138;
				short num2 = num;
				num = (short)646871962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062155776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362151937;
				if (num != 0)
				{
				}
				num = (short)1286864896;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Value;
			}
			set
			{
				short num = (short)122683570;
				short num2 = num;
				num = (short)921764018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391788032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51707905;
				if (num != 0)
				{
				}
				num = (short)144441344;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Value = value;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x001E55E8 File Offset: 0x001E37E8
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideASTROOTARIndividualASTROOTARRadioID_A8284
		{
			get
			{
				short num = (short)634922886;
				short num2 = num;
				num = (short)2029987718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2111373312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1138884609;
				if (num != 0)
				{
				}
				num = (short)540016640;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x001E5698 File Offset: 0x001E3898
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x001E574C File Offset: 0x001E394C
		public string SecWideASTROOTARIndividualASTROOTARRadioID_A8284_UIValue
		{
			get
			{
				short num = (short)103298738;
				short num2 = num;
				num = (short)1409824434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1162412032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174405121;
				if (num != 0)
				{
				}
				num = (short)40894464;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.UIValue;
			}
			set
			{
				short num = (short)211696885;
				short num2 = num;
				num = (short)2043690229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608894976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505165312;
				if (num != 0)
				{
				}
				num = (short)169738241;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.UIValue = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x001E5804 File Offset: 0x001E3A04
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x001E58B8 File Offset: 0x001E3AB8
		internal int SecWideASTROOTARIndividualASTROOTARRadioID_A8284Min
		{
			get
			{
				short num = (short)1466295197;
				short num2 = num;
				num = (short)1790698397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)454623232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505675777;
				if (num != 0)
				{
				}
				num = (short)1918369792;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Min;
			}
			set
			{
				short num = (short)235069606;
				short num2 = num;
				num = (short)449241254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554251776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61145089;
				if (num != 0)
				{
				}
				num = (short)1493696512;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Min = value;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x001E5974 File Offset: 0x001E3B74
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x001E5A28 File Offset: 0x001E3C28
		internal int SecWideASTROOTARIndividualASTROOTARRadioID_A8284Max
		{
			get
			{
				short num = (short)1617888470;
				short num2 = num;
				num = (short)517801174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046872064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1036058625;
				if (num != 0)
				{
				}
				num = (short)238223360;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Max;
			}
			set
			{
				short num = (short)1062862849;
				if (num != 0)
				{
				}
				num = (short)982908928;
				short num2 = num;
				num = (short)1828136114;
				short num3 = num;
				num = (short)1452418226;
				switch (num3 == num)
				{
				}
				num = (short)900005888;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Max = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x001E5ADC File Offset: 0x001E3CDC
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x001E5B90 File Offset: 0x001E3D90
		internal int SecWideASTROOTARIndividualASTROOTARRadioID_A8284Step
		{
			get
			{
				short num = (short)1271889140;
				short num2 = num;
				num = (short)58227956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660420096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1484652545;
				if (num != 0)
				{
				}
				num = (short)1257832448;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.StepSize;
			}
			set
			{
				short num = (short)1486564981;
				short num2 = num;
				num = (short)2134650485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)754384896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141650945;
				if (num != 0)
				{
				}
				num = (short)2006384640;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.StepSize = value;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x001E5C44 File Offset: 0x001E3E44
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x001E5CF8 File Offset: 0x001E3EF8
		public bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_Applicable
		{
			get
			{
				short num = (short)215741495;
				short num2 = num;
				num = (short)992670775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326514176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)843120641;
				if (num != 0)
				{
				}
				num = (short)1281884160;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Applicable;
			}
			set
			{
				short num = (short)1276020540;
				short num2 = num;
				num = (short)956008252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196804608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)383320064;
				if (num != 0)
				{
				}
				num = (short)2139095041;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Applicable = value;
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x001E5DAC File Offset: 0x001E3FAC
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x001E5E60 File Offset: 0x001E4060
		public bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_Valid
		{
			get
			{
				short num = (short)739049473;
				if (num != 0)
				{
				}
				num = (short)320077824;
				short num2 = num;
				num = (short)1585493457;
				short num3 = num;
				num = (short)1568388561;
				switch (num3 == num)
				{
				}
				num = (short)1584201728;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Valid;
			}
			set
			{
				short num = (short)2052007453;
				short num2 = num;
				num = (short)1285695005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)677576704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996737024;
				if (num != 0)
				{
				}
				num = (short)206241793;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Valid = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x001E5F14 File Offset: 0x001E4114
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x001E5FCC File Offset: 0x001E41CC
		public bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_Visible
		{
			get
			{
				short num = (short)656262671;
				short num2 = num;
				num = (short)1882441231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249561088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1486356480;
				if (num != 0)
				{
				}
				num = (short)711852033;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Visible;
			}
			set
			{
				short num = (short)880315766;
				short num2 = num;
				num = (short)677743990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017970688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184038912;
				if (num != 0)
				{
				}
				num = (short)1011744769;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Visible = value;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x001E6088 File Offset: 0x001E4288
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x001E6140 File Offset: 0x001E4340
		public bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_Editable
		{
			get
			{
				short num = (short)452591617;
				if (num != 0)
				{
				}
				num = (short)1457651712;
				short num2 = num;
				num = (short)1174606547;
				short num3 = num;
				num = (short)1138496211;
				switch (num3 == num)
				{
				}
				num = (short)1171128320;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Editable;
			}
			set
			{
				short num = (short)1171789204;
				short num2 = num;
				num = (short)737088916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)636420096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2070282240;
				if (num != 0)
				{
				}
				num = (short)716701697;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.Editable = value;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x001E61F4 File Offset: 0x001E43F4
		internal string SecWideASTROOTARIndividualASTROOTARRadioID_A8284_UILabel
		{
			get
			{
				short num = (short)514955045;
				short num2 = num;
				num = (short)922523429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525350400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1764098049;
				if (num != 0)
				{
				}
				num = (short)1824784384;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.UIName;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x001E62A8 File Offset: 0x001E44A8
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x001E635C File Offset: 0x001E455C
		internal bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_HiddenStatic
		{
			get
			{
				short num = (short)523359278;
				short num2 = num;
				num = (short)1695732782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1709047808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)159121409;
				if (num != 0)
				{
				}
				num = (short)1107296256;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.HiddenStatic;
			}
			set
			{
				short num = (short)483038467;
				short num2 = num;
				num = (short)1614386435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746599936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263599617;
				if (num != 0)
				{
				}
				num = (short)436469760;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.HiddenStatic = value;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x001E6414 File Offset: 0x001E4614
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x001E64C8 File Offset: 0x001E46C8
		internal bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_HiddenDynamic
		{
			get
			{
				short num = (short)1895745693;
				short num2 = num;
				num = (short)1658701981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839202304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1192427521;
				if (num != 0)
				{
				}
				num = (short)397606912;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.HiddenDynamic;
			}
			set
			{
				short num = (short)1950327455;
				short num2 = num;
				num = (short)1628086943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010775552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601817089;
				if (num != 0)
				{
				}
				num = (short)464781312;
				if (num != 0)
				{
				}
				this.secWideASTROOTARIndividualASTROOTARRadioID_A8284.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x001E6580 File Offset: 0x001E4780
		public bool SecWideASTROOTARIndividualASTROOTARRadioID_A8284_HasDiffs
		{
			get
			{
				short num = (short)914552519;
				short num2 = num;
				num = (short)1291187911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709951488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068564481;
				if (num != 0)
				{
				}
				num = (short)1198129152;
				if (num != 0)
				{
				}
				return this.secWideASTROOTARIndividualASTROOTARRadioID_A8284._HasDiffs;
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x001E6634 File Offset: 0x001E4834
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1120927744;
					short num3 = num2;
					num2 = (short)1483735042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)457441281;
					if (num2 != 0)
					{
					}
					num2 = (short)291653655;
					short num4 = num2;
					num2 = (short)978208791;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1373700096;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)742195200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					return result;
				case 3:
					num2 = (short)1378091009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)381091843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)808386564;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x001E67A4 File Offset: 0x001E49A4
		public void PostInit()
		{
			short num = (short)317892013;
			short num2 = num;
			num = (short)1362077101;
			switch (num2 == num)
			{
			}
			num = (short)1201078273;
			if (num != 0)
			{
			}
			num = (short)2145058816;
			if (num != 0)
			{
			}
			num = (short)1695744000;
			short num3 = num;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General.OnSecureWideGeneralOtarEnablePropertyChanged;
			this.a();
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x001E6864 File Offset: 0x001E4A64
		private void a()
		{
			short num = (short)736139449;
			short num2 = num;
			num = (short)1109170361;
			switch (num2 == num)
			{
			}
			num = (short)2014052353;
			if (num != 0)
			{
			}
			num = (short)769785856;
			if (num != 0)
			{
			}
			num = (short)505413632;
			short num3 = num;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR.OnSecureWideIndividualAstroOtarID_PropertyChangedHandle;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x001E6920 File Offset: 0x001E4B20
		public static void OnSecureWideIndividualAstroOtarID_PropertyChangedHandle(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 5;
			short num = (short)1813839878;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR astrootar;
				switch (num2)
				{
				case 0:
					if (section != null)
					{
						num = (short)2049114116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)1326252032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_259;
				case 3:
					if (global::AcpCommonLib.FeatureManager.IsInitialized)
					{
						num = (short)964100098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)1609105409;
					if (num != 0)
					{
					}
					num = (short)510656515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)416808960;
					short num3 = num;
					try
					{
						num = (short)1768554502;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								if (enumerator.MoveNext())
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1812135940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)605682027;
								short num4 = num;
								num = (short)1199372651;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1177812992;
									if (num != 0)
									{
									}
									num = (short)643956741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_1EE;
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
								secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.SetValue(astrootar.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.Value);
								num = (short)2077622272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
								if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
								{
									num = (short)1712062467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								num = (short)832241666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							}
							IL_C3:
							num = (short)1826357249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C1:
							goto IL_C3;
						}
						IL_1EE:
						return;
					}
					finally
					{
						num = (short)416088066;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)881721345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_256;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_223;
								}
								continue;
							}
							IL_223:
							if (enumerator == null)
							{
								break;
							}
							num = (short)513802240;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_256:;
					}
					goto IL_259;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("闅귇꧉鯋ꟍ듏럑闓藕賗裙鏛針듟ꏡ뛣꿥蛧軩藫飭駯雱至韵铷믹꿻꫽勿䴁䬃刅䤇堉帋漍琏笑笓引尗䔙崛☝ሟᨡဣ礥紧挩稫伭尯䜱儳", a_))
				{
					num = (short)1550385153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_259:
				astrootar = (section as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR);
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset).GetEnumerator();
				num = (short)1784676357;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000B7C RID: 2940
		private global::AcpBusinessLayer.AcpField<bool> secWideASTROOTARASTROOTAREnable_A7496;

		// Token: 0x04000B7D RID: 2941
		private global::AcpBusinessLayer.AcpField<bool> secWideASTROOTARRadioInhibitviaASTROOTAR_A8834;

		// Token: 0x04000B7E RID: 2942
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideASTROOTARIndividualASTROOTARRadioID_A8284;
	}
}
