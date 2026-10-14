using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F4 RID: 1268
	[global::System.Serializable]
	public class DACListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AA3B RID: 43579 RVA: 0x009E8220 File Offset: 0x009E6420
		public DACListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x009E823C File Offset: 0x009E643C
		protected DACListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x009E8254 File Offset: 0x009E6454
		public override void Init()
		{
			int a_ = 10;
			short num = (short)244035554;
			short num2 = num;
			num = (short)1407692770;
			switch (num2 == num)
			{
			default:
			{
				num = (short)129957888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1601306624;
			if (num != 0)
			{
			}
			num = (short)1086455809;
			if (num != 0)
			{
			}
			this.dataProfilesDACOperationalMode_A36199 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐菒꟔룖뿘닚뇜뫞鋠꟢ꓤꓦꛨ鯪裬鷮郰蟲鳴飶韸髺釼닾渀朂怄堆䠈㠊㬌㸎⠐⨒", a_), global::CommonResources.AcgResources.ID_OPERATIONALMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfilesDACOperationalMode_A36199LovStrs);
			this.dataProfilesDACOperationalMode_A36199.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfilesDACOperationalMode_A36199.DataTransferOrder = 35;
			this.dataProfilesDACSlotSize_A36203 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.indexDataProfilesDACSlotSize_A36203LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.idDataProfilesDACSlotSize_A36203LovStrs), this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐菒꟔룖뿘닚뇜뫞鋠꟢ꓤꓦ뫨蟪苬鯮ꋰ髲迴鋶꛸뫺컼짾㌀㌂㘄", a_), global::CommonResources.AcgResources.ID_SLOTSIZE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfilesDACSlotSize_A36203LovStrs);
			this.dataProfilesDACSlotSize_A36203.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfilesDACSlotSize_A36203.DataTransferOrder = 36;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裊軌軎臐釔雖高ﯚ釜뛞鋠韢", a_);
			base.Id = 10506;
			base.UIName = global::CommonResources.AcgResources.ID_CCAPDACLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x009E83C4 File Offset: 0x009E65C4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)260571144;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dataProfilesDACOperationalMode_A36199 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐뫒맔닖꫘鿚鳜鳞껠鏢胤闦裨鿪蓬胮鿰鋲駴뫶雸鿺飼ꃾ䀀。㌄㘆〈㈊", a_), global::CommonResources.AcgResources.ID_OPERATIONALMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfilesDACOperationalMode_A36199LovStrs);
					this.dataProfilesDACOperationalMode_A36199.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfilesDACOperationalMode_A36199.DataTransferOrder = 35;
					num = (short)1389690885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1E4;
				case 2:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐뫒맔닖꫘鿚鳜鳞껠鏢胤闦裨鿪蓬胮鿰鋲駴뫶雸鿺飼ꃾ䀀。㌄㘆〈㈊", a_)))
					{
						goto IL_7A;
					}
					num = (short)651404820;
					short num3 = num;
					num = (short)335717908;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_165;
					default:
						num = (short)2030108672;
						if (num != 0)
						{
						}
						num = (short)2143158272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐뫒맔닖꫘鿚鳜鳞닠迢諤鏦뫨苪韬諮껰닲웴쇶쯸쯺컼", a_)))
					{
						num = (short)1475739652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_280;
				case 4:
					this.dataProfilesDACSlotSize_A36203 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.indexDataProfilesDACSlotSize_A36203LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.idDataProfilesDACSlotSize_A36203LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鯊뿌ꃎ럐뫒맔닖꫘鿚鳜鳞닠迢諤鏦뫨苪韬諮껰닲웴쇶쯸쯺컼", a_), global::CommonResources.AcgResources.ID_SLOTSIZE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfilesDACSlotSize_A36203LovStrs);
					this.dataProfilesDACSlotSize_A36203.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfilesDACSlotSize_A36203.DataTransferOrder = 36;
					num = (short)440139777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_7A;
				case 6:
					num = (short)998047753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)763101186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 9:
					if (producerFields != null)
					{
						goto IL_165;
					}
					goto IL_280;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1602945030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)1290469377;
				if (num != 0)
				{
				}
				num = (short)2141585411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_165:
				num = (short)1221394439;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E4:
			IL_280:
			num = (short)111214592;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胂蛄蛆駈觌軎鋐駔뻖꫘꿚", a_);
			base.Id = 10506;
			base.UIName = global::CommonResources.AcgResources.ID_CCAPDACLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x009E86AC File Offset: 0x009E68AC
		public override void PopulateReferences()
		{
			short num = (short)1790122982;
			short num2 = num;
			num = (short)707402726;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1492320256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)88276993;
			if (num != 0)
			{
			}
			num = (short)166789120;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x009E8758 File Offset: 0x009E6958
		public override void DropReferences()
		{
			short num = (short)99894917;
			short num2 = num;
			num = (short)1828406917;
			switch (num2 == num)
			{
			default:
			{
				num = (short)894238720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1031798785;
			if (num != 0)
			{
			}
			num = (short)477233152;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x009E8804 File Offset: 0x009E6A04
		public override void SetConstraints()
		{
			short num = (short)919443901;
			short num2 = num;
			num = (short)1482922429;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1397358592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)902889473;
			if (num != 0)
			{
			}
			num = (short)669646848;
			if (num != 0)
			{
			}
			this.dataProfilesDACOperationalMode_A36199.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileOperModeApp);
			this.dataProfilesDACOperationalMode_A36199.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileOperModeValid);
			this.dataProfilesDACOperationalMode_A36199.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conFirstRowOfDACTableNotEditable);
			this.dataProfilesDACSlotSize_A36203.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeIsTrkAndOperationModeIsControlledChannelAccess);
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x009E890C File Offset: 0x009E6B0C
		public override void SetupDependencies()
		{
			short num = (short)1561968403;
			short num2 = num;
			num = (short)1765719827;
			switch (num2 == num)
			{
			default:
			{
				num = (short)34668544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)602210305;
			if (num != 0)
			{
			}
			num = (short)1770389504;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfilesDACOperationalMode_A36199);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfilesDACSlotSize_A36203);
			this.dataProfilesDACOperationalMode_A36199.AddDependentObject(this.dataProfilesDACSlotSize_A36203);
			this.dataProfilesDACOperationalMode_A36199.AddDependentObject((base.ParentRecset.ParentSection.Parent[10600] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity).DataProfNLSSecClrStrp_A36415);
		}

		// Token: 0x17005549 RID: 21833
		// (get) Token: 0x0600AA43 RID: 43587 RVA: 0x009E8A3C File Offset: 0x009E6C3C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1750053713;
				short num2 = num;
				num = (short)507818833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)185729024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1363607553;
				if (num != 0)
				{
				}
				num = (short)1448017920;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700554A RID: 21834
		// (get) Token: 0x0600AA44 RID: 43588 RVA: 0x009E8AEC File Offset: 0x009E6CEC
		// (set) Token: 0x0600AA45 RID: 43589 RVA: 0x009E8BA0 File Offset: 0x009E6DA0
		public int DataProfilesDACOperationalMode_A36199Value
		{
			get
			{
				short num = (short)524352412;
				short num2 = num;
				num = (short)1561525148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068236800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)783351809;
				if (num != 0)
				{
				}
				num = (short)6815744;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.Value;
			}
			set
			{
				short num = (short)979747544;
				short num2 = num;
				num = (short)2094580440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038890496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1097596929;
				if (num != 0)
				{
				}
				num = (short)1916534784;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.Value = value;
			}
		}

		// Token: 0x1700554B RID: 21835
		// (get) Token: 0x0600AA46 RID: 43590 RVA: 0x009E8C58 File Offset: 0x009E6E58
		// (set) Token: 0x0600AA47 RID: 43591 RVA: 0x009E8D0C File Offset: 0x009E6F0C
		public string DataProfilesDACOperationalMode_A36199_UIValue
		{
			get
			{
				short num = (short)756744235;
				short num2 = num;
				num = (short)275447851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)389480448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1685454849;
				if (num != 0)
				{
				}
				num = (short)1269235712;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.UIValue;
			}
			set
			{
				short num = (short)1485832193;
				if (num != 0)
				{
				}
				num = (short)1676148736;
				short num2 = num;
				num = (short)573860146;
				short num3 = num;
				num = (short)1596811570;
				switch (num3 == num)
				{
				}
				num = (short)1001717760;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.UIValue = value;
			}
		}

		// Token: 0x1700554C RID: 21836
		// (get) Token: 0x0600AA48 RID: 43592 RVA: 0x009E8DC0 File Offset: 0x009E6FC0
		public global::AcpBusinessLayer.AcpListField DataProfilesDACOperationalMode_A36199
		{
			get
			{
				short num = (short)64159745;
				if (num != 0)
				{
				}
				num = (short)727252992;
				short num2 = num;
				num = (short)1711684807;
				short num3 = num;
				num = (short)1488141511;
				switch (num3 == num)
				{
				}
				num = (short)1714683904;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199;
			}
		}

		// Token: 0x1700554D RID: 21837
		// (get) Token: 0x0600AA49 RID: 43593 RVA: 0x009E8E70 File Offset: 0x009E7070
		// (set) Token: 0x0600AA4A RID: 43594 RVA: 0x009E8F24 File Offset: 0x009E7124
		public bool DataProfilesDACOperationalMode_A36199_Applicable
		{
			get
			{
				short num = (short)1177903656;
				short num2 = num;
				num = (short)151216680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836056576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751042561;
				if (num != 0)
				{
				}
				num = (short)1094516736;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.Applicable;
			}
			set
			{
				short num = (short)1686726748;
				short num2 = num;
				num = (short)930703452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529610240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216596481;
				if (num != 0)
				{
				}
				num = (short)920649728;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.Applicable = value;
			}
		}

		// Token: 0x1700554E RID: 21838
		// (get) Token: 0x0600AA4B RID: 43595 RVA: 0x009E8FD8 File Offset: 0x009E71D8
		// (set) Token: 0x0600AA4C RID: 43596 RVA: 0x009E908C File Offset: 0x009E728C
		public bool DataProfilesDACOperationalMode_A36199_Valid
		{
			get
			{
				short num = (short)1360434428;
				short num2 = num;
				num = (short)1047827708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428081152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1167196161;
				if (num != 0)
				{
				}
				num = (short)30932992;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.Valid;
			}
			set
			{
				short num = (short)518250367;
				short num2 = num;
				num = (short)404152191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)446300160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)906887169;
				if (num != 0)
				{
				}
				num = (short)877133824;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.Valid = value;
			}
		}

		// Token: 0x1700554F RID: 21839
		// (get) Token: 0x0600AA4D RID: 43597 RVA: 0x009E9140 File Offset: 0x009E7340
		// (set) Token: 0x0600AA4E RID: 43598 RVA: 0x009E91F4 File Offset: 0x009E73F4
		public bool DataProfilesDACOperationalMode_A36199_Visible
		{
			get
			{
				short num = (short)375002875;
				short num2 = num;
				num = (short)527439611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)563085312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)74842113;
				if (num != 0)
				{
				}
				num = (short)287440896;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.Visible;
			}
			set
			{
				short num = (short)375313018;
				short num2 = num;
				num = (short)25481850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901592576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1970995201;
				if (num != 0)
				{
				}
				num = (short)1185611776;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.Visible = value;
			}
		}

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x0600AA4F RID: 43599 RVA: 0x009E92A8 File Offset: 0x009E74A8
		// (set) Token: 0x0600AA50 RID: 43600 RVA: 0x009E9360 File Offset: 0x009E7560
		public bool DataProfilesDACOperationalMode_A36199_Editable
		{
			get
			{
				short num = (short)347373442;
				short num2 = num;
				num = (short)710115202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188102144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)196149249;
				if (num != 0)
				{
				}
				num = (short)586350592;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.Editable;
			}
			set
			{
				short num = (short)1415651397;
				short num2 = num;
				num = (short)507191365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1918763008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)126484480;
				if (num != 0)
				{
				}
				num = (short)467468289;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.Editable = value;
			}
		}

		// Token: 0x17005551 RID: 21841
		// (get) Token: 0x0600AA51 RID: 43601 RVA: 0x009E9414 File Offset: 0x009E7614
		internal string DataProfilesDACOperationalMode_A36199_UILabel
		{
			get
			{
				short num = (short)124025322;
				short num2 = num;
				num = (short)1050376682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1983774720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030501888;
				if (num != 0)
				{
				}
				num = (short)1171324929;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.UIName;
			}
		}

		// Token: 0x17005552 RID: 21842
		// (get) Token: 0x0600AA52 RID: 43602 RVA: 0x009E94C8 File Offset: 0x009E76C8
		// (set) Token: 0x0600AA53 RID: 43603 RVA: 0x009E9580 File Offset: 0x009E7780
		internal bool DataProfilesDACOperationalMode_A36199_HiddenStatic
		{
			get
			{
				short num = (short)1113332966;
				short num2 = num;
				num = (short)452599014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1979121664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407961600;
				if (num != 0)
				{
				}
				num = (short)297271297;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.HiddenStatic;
			}
			set
			{
				short num = (short)1752382040;
				short num2 = num;
				num = (short)780745304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)996016128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409482753;
				if (num != 0)
				{
				}
				num = (short)784203776;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.HiddenStatic = value;
			}
		}

		// Token: 0x17005553 RID: 21843
		// (get) Token: 0x0600AA54 RID: 43604 RVA: 0x009E9638 File Offset: 0x009E7838
		// (set) Token: 0x0600AA55 RID: 43605 RVA: 0x009E96EC File Offset: 0x009E78EC
		internal bool DataProfilesDACOperationalMode_A36199_HiddenDynamic
		{
			get
			{
				short num = (short)1170669640;
				short num2 = num;
				num = (short)1692663880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1209991168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146172929;
				if (num != 0)
				{
				}
				num = (short)1837760512;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199.HiddenDynamic;
			}
			set
			{
				short num = (short)1751892114;
				short num2 = num;
				num = (short)773243026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491520000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536884736;
				if (num != 0)
				{
				}
				num = (short)1833238529;
				if (num != 0)
				{
				}
				this.dataProfilesDACOperationalMode_A36199.HiddenDynamic = value;
			}
		}

		// Token: 0x17005554 RID: 21844
		// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x009E97A0 File Offset: 0x009E79A0
		public bool DataProfilesDACOperationalMode_A36199_HasDiffs
		{
			get
			{
				short num = (short)716336781;
				short num2 = num;
				num = (short)1918267021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90832896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1459486721;
				if (num != 0)
				{
				}
				num = (short)737607680;
				if (num != 0)
				{
				}
				return this.dataProfilesDACOperationalMode_A36199._HasDiffs;
			}
		}

		// Token: 0x17005555 RID: 21845
		// (get) Token: 0x0600AA57 RID: 43607 RVA: 0x009E9854 File Offset: 0x009E7A54
		// (set) Token: 0x0600AA58 RID: 43608 RVA: 0x009E9908 File Offset: 0x009E7B08
		public int DataProfilesDACSlotSize_A36203Value
		{
			get
			{
				short num = (short)767578485;
				short num2 = num;
				num = (short)923292021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1517027328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508362752;
				if (num != 0)
				{
				}
				num = (short)2024996865;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.Value;
			}
			set
			{
				short num = (short)447414273;
				if (num != 0)
				{
				}
				num = (short)1795883008;
				short num2 = num;
				num = (short)611103759;
				short num3 = num;
				num = (short)154448911;
				switch (num3 == num)
				{
				}
				num = (short)1212874752;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.Value = value;
			}
		}

		// Token: 0x17005556 RID: 21846
		// (get) Token: 0x0600AA59 RID: 43609 RVA: 0x009E99C0 File Offset: 0x009E7BC0
		// (set) Token: 0x0600AA5A RID: 43610 RVA: 0x009E9A74 File Offset: 0x009E7C74
		public string DataProfilesDACSlotSize_A36203_UIValue
		{
			get
			{
				short num = (short)945029121;
				if (num != 0)
				{
				}
				num = (short)1604583424;
				short num2 = num;
				num = (short)1477755208;
				short num3 = num;
				num = (short)723239240;
				switch (num3 == num)
				{
				}
				num = (short)1025703936;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.UIValue;
			}
			set
			{
				short num = (short)1335550517;
				short num2 = num;
				num = (short)556196405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1319043072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432092673;
				if (num != 0)
				{
				}
				num = (short)552271872;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.UIValue = value;
			}
		}

		// Token: 0x17005557 RID: 21847
		// (get) Token: 0x0600AA5B RID: 43611 RVA: 0x009E9B28 File Offset: 0x009E7D28
		public global::AcpBusinessLayer.AcpListField DataProfilesDACSlotSize_A36203
		{
			get
			{
				short num = (short)2060485717;
				short num2 = num;
				num = (short)817726549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)456130560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)587530241;
				if (num != 0)
				{
				}
				num = (short)163381248;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203;
			}
		}

		// Token: 0x17005558 RID: 21848
		// (get) Token: 0x0600AA5C RID: 43612 RVA: 0x009E9BD8 File Offset: 0x009E7DD8
		// (set) Token: 0x0600AA5D RID: 43613 RVA: 0x009E9C8C File Offset: 0x009E7E8C
		public bool DataProfilesDACSlotSize_A36203_Applicable
		{
			get
			{
				short num = (short)1702255450;
				short num2 = num;
				num = (short)270555994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1651179520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784610816;
				if (num != 0)
				{
				}
				num = (short)538181633;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.Applicable;
			}
			set
			{
				short num = (short)429250350;
				short num2 = num;
				num = (short)564647726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1730150400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14090241;
				if (num != 0)
				{
				}
				num = (short)1258618880;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.Applicable = value;
			}
		}

		// Token: 0x17005559 RID: 21849
		// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x009E9D44 File Offset: 0x009E7F44
		// (set) Token: 0x0600AA5F RID: 43615 RVA: 0x009E9DF4 File Offset: 0x009E7FF4
		public bool DataProfilesDACSlotSize_A36203_Valid
		{
			get
			{
				short num = (short)453506470;
				short num2 = num;
				num = (short)1065743782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)780075008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)680984576;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.Valid;
			}
			set
			{
				short num = (short)100054586;
				short num2 = num;
				num = (short)287553082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1797586944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1105592321;
				if (num != 0)
				{
				}
				num = (short)1670250496;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.Valid = value;
			}
		}

		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x009E9EAC File Offset: 0x009E80AC
		// (set) Token: 0x0600AA61 RID: 43617 RVA: 0x009E9F64 File Offset: 0x009E8164
		public bool DataProfilesDACSlotSize_A36203_Visible
		{
			get
			{
				short num = (short)1541079040;
				short num2 = num;
				num = (short)84708281;
				short num3 = num;
				num = (short)258706361;
				switch (num3 == num)
				{
				}
				num = (short)688062465;
				if (num != 0)
				{
				}
				num = (short)49086464;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.Visible;
			}
			set
			{
				short num = (short)359596032;
				short num2 = num;
				num = (short)1793778244;
				short num3 = num;
				num = (short)2095440452;
				switch (num3 == num)
				{
				}
				num = (short)297140225;
				if (num != 0)
				{
				}
				num = (short)884801536;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.Visible = value;
			}
		}

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x009EA018 File Offset: 0x009E8218
		// (set) Token: 0x0600AA63 RID: 43619 RVA: 0x009EA0CC File Offset: 0x009E82CC
		public bool DataProfilesDACSlotSize_A36203_Editable
		{
			get
			{
				short num = (short)964755456;
				short num2 = num;
				num = (short)933098151;
				short num3 = num;
				num = (short)966062759;
				switch (num3 == num)
				{
				}
				num = (short)606994432;
				if (num != 0)
				{
				}
				num = (short)430637057;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.Editable;
			}
			set
			{
				short num = (short)48955392;
				short num2 = num;
				num = (short)1428029441;
				if (num != 0)
				{
				}
				num = (short)1649994216;
				short num3 = num;
				num = (short)924510696;
				switch (num3 == num)
				{
				}
				num = (short)1995702272;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.Editable = value;
			}
		}

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x0600AA64 RID: 43620 RVA: 0x009EA184 File Offset: 0x009E8384
		internal string DataProfilesDACSlotSize_A36203_UILabel
		{
			get
			{
				short num = (short)868679680;
				short num2 = num;
				num = (short)782245447;
				short num3 = num;
				num = (short)1022369351;
				switch (num3 == num)
				{
				}
				num = (short)2003697665;
				if (num != 0)
				{
				}
				num = (short)1148715008;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.UIName;
			}
		}

		// Token: 0x1700555D RID: 21853
		// (get) Token: 0x0600AA65 RID: 43621 RVA: 0x009EA238 File Offset: 0x009E8438
		// (set) Token: 0x0600AA66 RID: 43622 RVA: 0x009EA2EC File Offset: 0x009E84EC
		internal bool DataProfilesDACSlotSize_A36203_HiddenStatic
		{
			get
			{
				short num = (short)1445462016;
				short num2 = num;
				num = (short)8429619;
				short num3 = num;
				num = (short)1916182579;
				switch (num3 == num)
				{
				}
				num = (short)1706295297;
				if (num != 0)
				{
				}
				num = (short)220397568;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.HiddenStatic;
			}
			set
			{
				short num = (short)557514752;
				short num2 = num;
				num = (short)176225111;
				short num3 = num;
				num = (short)28310359;
				switch (num3 == num)
				{
				}
				num = (short)1943076865;
				if (num != 0)
				{
				}
				num = (short)1714028544;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.HiddenStatic = value;
			}
		}

		// Token: 0x1700555E RID: 21854
		// (get) Token: 0x0600AA67 RID: 43623 RVA: 0x009EA3A4 File Offset: 0x009E85A4
		// (set) Token: 0x0600AA68 RID: 43624 RVA: 0x009EA45C File Offset: 0x009E865C
		internal bool DataProfilesDACSlotSize_A36203_HiddenDynamic
		{
			get
			{
				short num = (short)1903165440;
				short num2 = num;
				num = (short)1628737865;
				short num3 = num;
				num = (short)1492160841;
				switch (num3 == num)
				{
				}
				num = (short)695402496;
				if (num != 0)
				{
				}
				num = (short)62783489;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203.HiddenDynamic;
			}
			set
			{
				short num = (short)819855360;
				short num2 = num;
				num = (short)609681409;
				if (num != 0)
				{
				}
				num = (short)11078614;
				short num3 = num;
				num = (short)1045433302;
				switch (num3 == num)
				{
				}
				num = (short)600309760;
				if (num != 0)
				{
				}
				this.dataProfilesDACSlotSize_A36203.HiddenDynamic = value;
			}
		}

		// Token: 0x1700555F RID: 21855
		// (get) Token: 0x0600AA69 RID: 43625 RVA: 0x009EA514 File Offset: 0x009E8714
		public bool DataProfilesDACSlotSize_A36203_HasDiffs
		{
			get
			{
				short num = (short)1317011456;
				short num2 = num;
				num = (short)207259451;
				short num3 = num;
				num = (short)1395492667;
				switch (num3 == num)
				{
				}
				num = (short)1970733057;
				if (num != 0)
				{
				}
				num = (short)1761148928;
				if (num != 0)
				{
				}
				return this.dataProfilesDACSlotSize_A36203._HasDiffs;
			}
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x009EA5CC File Offset: 0x009E87CC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (base.ParentRecset == null)
						{
							goto IL_139;
						}
						num2 = (short)237781598;
						short num3 = num2;
						num2 = (short)688210526;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
							num2 = (short)1126170624;
							if (num2 != 0)
							{
							}
							num2 = (short)1096613889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						num2 = (short)1308098562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)655687684;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_139;
					case 3:
						goto IL_FA;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1392640003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				IL_FA:
				IL_139:
				num2 = (short)1696792576;
				short num4 = num2;
				return result;
			}
			}
			IL_24:
			num2 = (short)1410007041;
			if (num2 != 0)
			{
			}
			result = null;
			IL_4C:
			num2 = (short)2138308608;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005154 RID: 20820
		private global::AcpBusinessLayer.AcpListField dataProfilesDACOperationalMode_A36199;

		// Token: 0x04005155 RID: 20821
		private global::AcpBusinessLayer.AcpListField dataProfilesDACSlotSize_A36203;
	}
}
