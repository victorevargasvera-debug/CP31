using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000459 RID: 1113
	[global::System.Serializable]
	public class RxSSIClockRateListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600943A RID: 37946 RVA: 0x008B9DF8 File Offset: 0x008B7FF8
		public RxSSIClockRateListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x008B9E14 File Offset: 0x008B8014
		protected RxSSIClockRateListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x008B9E2C File Offset: 0x008B802C
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1662910464;
			short num2 = num;
			num = (short)679141167;
			short num3 = num;
			num = (short)770432815;
			switch (num3 == num)
			{
			}
			num = (short)241172481;
			if (num != 0)
			{
			}
			num = (short)482148352;
			if (num != 0)
			{
			}
			this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = new global::AcpBusinessLayer.AcpFrequencyField(170212500, this, global::AllFeatures.CodeplugGuid.b("跊껌믎黐ꇒ뇔ꓖ诘ꏚ軜賞꣠ꃢ觤裦諨胪뿬軮藰雲맴黶諸迺꿼蟾䜀焂怄瘆簈渊挌氎栐帒崔洖䘘娚⤜ⴞᔠᔢᴤ", a_), global::CommonResources.AcgResources.ID_RXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.DataTransferOrder = 202;
			this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.indexFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469LovStrs, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.idFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469LovStrs), this, global::AllFeatures.CodeplugGuid.b("跊껌믎黐ꇒ뇔ꓖ诘ꏚ軜賞꣠ꃢ觤裦諨胪뿬軮藰雲맴黶諸迺꿼蟾刀倂䰄䐆攈搊渌搎䌐爒愔爖吘匚朜䀞怠ᜢᜤጦἨሪ", a_), global::CommonResources.AcgResources.ID_RXSSICLOCKRATEMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469LovStrs);
			this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.DataTransferOrder = 203;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駊뗌苐胒鳔高럚닜볞諠쏢럤蛦鷨軪췬ꏮ飰胲致", a_);
			base.Id = 10792;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x008B9FA8 File Offset: 0x008B81A8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1456734211;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1560084481;
					if (num != 0)
					{
					}
					num = (short)1163132928;
					short num3 = num;
					num = (short)1852047369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賉꿋뫍鿏ꃑ냓ꗕ諗ꋙ进距꧟ꇡ裣觥诧臩뻫迭蓯韱룳鿵请軹껻蛽叿儁䴃䔅搇攉漋攍䈏猑怓猕唗则昛䄝感ᘡᘣሥḧጩ", a_)))
					{
						num = (short)1856897031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				case 2:
				{
					this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = new global::AcpBusinessLayer.AcpFrequencyField(170212500, this, global::AllFeatures.CodeplugGuid.b("賉꿋뫍鿏ꃑ냓ꗕ諗ꋙ进距꧟ꇡ裣觥诧臩뻫迭蓯韱룳鿵请軹껻蛽䛿瀁愃眅紇漉戋洍椏弑尓氕䜗嬙⠛Ⱍᐟᐡᰣ", a_), global::CommonResources.AcgResources.ID_RXFREQUENCYMHZ);
					this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.DataTransferOrder = 202;
					num = (short)2066561829;
					short num4 = num;
					num = (short)1059601189;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)631177216;
						if (num != 0)
						{
						}
						num = (short)2038366216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					num = (short)241565701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賉꿋뫍鿏ꃑ냓ꗕ諗ꋙ进距꧟ꇡ裣觥诧臩뻫迭蓯韱룳鿵请軹껻蛽䛿瀁愃眅紇漉戋洍椏弑尓氕䜗嬙⠛Ⱍᐟᐡᰣ", a_)))
					{
						num = (short)1052704770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C8;
				case 6:
					goto IL_257;
				case 7:
					this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.indexFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469LovStrs, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.idFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469LovStrs), this, global::AllFeatures.CodeplugGuid.b("賉꿋뫍鿏ꃑ냓ꗕ諗ꋙ进距꧟ꇡ裣觥诧臩뻫迭蓯韱룳鿵请軹껻蛽叿儁䴃䔅搇攉漋攍䈏猑怓猕唗则昛䄝感ᘡᘣሥḧጩ", a_), global::CommonResources.AcgResources.ID_RXSSICLOCKRATEMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469LovStrs);
					this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.DataTransferOrder = 203;
					num = (short)1171456006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_C8;
				case 9:
					if (producerFields != null)
					{
						num = (short)820314116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)49741824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C8:
				num = (short)756940801;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_257:
			IL_2A7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飉듋菏臑鷓鯗뛙돛뷝诟싡뛣蟥鳧迩쳫ꋭ駯臱胳", a_);
			base.Id = 10792;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600943E RID: 37950 RVA: 0x008BA290 File Offset: 0x008B8490
		public override void PopulateReferences()
		{
			short num = (short)422576128;
			short num2 = num;
			num = (short)759244360;
			short num3 = num;
			num = (short)710026824;
			switch (num3 == num)
			{
			}
			num = (short)1591803905;
			if (num != 0)
			{
			}
			num = (short)993787904;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600943F RID: 37951 RVA: 0x008BA338 File Offset: 0x008B8538
		public override void DropReferences()
		{
			short num = (short)970653696;
			short num2 = num;
			num = (short)1758003201;
			if (num != 0)
			{
			}
			num = (short)30746470;
			short num3 = num;
			num = (short)2036475750;
			switch (num3 == num)
			{
			}
			num = (short)1630535680;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009440 RID: 37952 RVA: 0x008BA3E0 File Offset: 0x008B85E0
		public override void SetConstraints()
		{
			short num = (short)1867710464;
			short num2 = num;
			num = (short)935549087;
			short num3 = num;
			num = (short)1447712927;
			switch (num3 == num)
			{
			}
			num = (short)1727725568;
			if (num != 0)
			{
			}
			num = (short)269352961;
			if (num != 0)
			{
			}
			this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFacOvrrdRxSSIRxFreqMHzIsValid);
			this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x008BA4CC File Offset: 0x008B86CC
		public override void SetupDependencies()
		{
			short num = (short)799932416;
			short num2 = num;
			num = (short)131069643;
			short num3 = num;
			num = (short)793900747;
			switch (num3 == num)
			{
			}
			num = (short)99942401;
			if (num != 0)
			{
			}
			num = (short)283443200;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides factoryOverrides = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides;
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468);
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469);
		}

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x008BA5D4 File Offset: 0x008B87D4
		public bool HasDiffs
		{
			get
			{
				short num = (short)395182080;
				short num2 = num;
				num = (short)51788745;
				short num3 = num;
				num = (short)821967817;
				switch (num3 == num)
				{
				}
				num = (short)409665537;
				if (num != 0)
				{
				}
				num = (short)1801977856;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x06009443 RID: 37955 RVA: 0x008BA684 File Offset: 0x008B8884
		// (set) Token: 0x06009444 RID: 37956 RVA: 0x008BA738 File Offset: 0x008B8938
		public int FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468Value
		{
			get
			{
				short num = (short)1676214272;
				short num2 = num;
				num = (short)1252812238;
				short num3 = num;
				num = (short)147940814;
				switch (num3 == num)
				{
				}
				num = (short)237699073;
				if (num != 0)
				{
				}
				num = (short)966328320;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Value;
			}
			set
			{
				short num = (short)1583808512;
				short num2 = num;
				num = (short)902268150;
				short num3 = num;
				num = (short)52987126;
				switch (num3 == num)
				{
				}
				num = (short)1271857153;
				if (num != 0)
				{
				}
				num = (short)1457127424;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Value = value;
			}
		}

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x06009445 RID: 37957 RVA: 0x008BA7EC File Offset: 0x008B89EC
		// (set) Token: 0x06009446 RID: 37958 RVA: 0x008BA8A4 File Offset: 0x008B8AA4
		public string FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_UIValue
		{
			get
			{
				short num = (short)749600768;
				short num2 = num;
				num = (short)1504618693;
				short num3 = num;
				num = (short)1636280517;
				switch (num3 == num)
				{
				}
				num = (short)600113153;
				if (num != 0)
				{
				}
				num = (short)584974336;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.UIValue;
			}
			set
			{
				short num = (short)530964018;
				short num2 = num;
				num = (short)1576394290;
				switch (num2 == num)
				{
				}
				num = (short)233897985;
				if (num != 0)
				{
				}
				num = (short)1539964928;
				short num3 = num;
				num = (short)1668677632;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.UIValue = value;
			}
		}

		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x06009447 RID: 37959 RVA: 0x008BA95C File Offset: 0x008B8B5C
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468
		{
			get
			{
				short num = (short)1868811267;
				short num2 = num;
				num = (short)1576717315;
				switch (num2 == num)
				{
				}
				num = (short)2111700993;
				if (num != 0)
				{
				}
				num = (short)817168384;
				short num3 = num;
				num = (short)1228079104;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;
			}
		}

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x06009448 RID: 37960 RVA: 0x008BAA0C File Offset: 0x008B8C0C
		// (set) Token: 0x06009449 RID: 37961 RVA: 0x008BAAC4 File Offset: 0x008B8CC4
		internal int FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468Min
		{
			get
			{
				short num = (short)2085963667;
				short num2 = num;
				num = (short)522995603;
				switch (num2 == num)
				{
				}
				num = (short)939261952;
				if (num != 0)
				{
				}
				num = (short)1210253312;
				short num3 = num;
				num = (short)648544257;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Min;
			}
			set
			{
				short num = (short)1521381425;
				short num2 = num;
				num = (short)86994993;
				switch (num2 == num)
				{
				}
				num = (short)1696006144;
				if (num != 0)
				{
				}
				num = (short)1007419392;
				short num3 = num;
				num = (short)33751041;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Min = value;
			}
		}

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x0600944A RID: 37962 RVA: 0x008BAB78 File Offset: 0x008B8D78
		// (set) Token: 0x0600944B RID: 37963 RVA: 0x008BAC30 File Offset: 0x008B8E30
		internal int FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468Max
		{
			get
			{
				short num = (short)563339521;
				short num2 = num;
				num = (short)1356390657;
				switch (num2 == num)
				{
				}
				num = (short)1388707841;
				if (num != 0)
				{
				}
				num = (short)1062862848;
				short num3 = num;
				num = (short)1340866560;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Max;
			}
			set
			{
				short num = (short)910292032;
				short num2 = num;
				num = (short)1951921216;
				switch (num2 == num)
				{
				}
				num = (short)2036662273;
				if (num != 0)
				{
				}
				num = (short)97976320;
				short num3 = num;
				num = (short)413532160;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Max = value;
			}
		}

		// Token: 0x17004A9F RID: 19103
		// (get) Token: 0x0600944C RID: 37964 RVA: 0x008BACE4 File Offset: 0x008B8EE4
		// (set) Token: 0x0600944D RID: 37965 RVA: 0x008BAD94 File Offset: 0x008B8F94
		internal int FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468Step
		{
			get
			{
				short num = (short)942527931;
				short num2 = num;
				num = (short)8443323;
				switch (num2 == num)
				{
				}
				num = (short)1800929281;
				if (num != 0)
				{
				}
				num = (short)617021440;
				short num3 = num;
				num = (short)1310195712;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.StepSize;
			}
			set
			{
				short num = (short)1132778360;
				short num2 = num;
				num = (short)2061292408;
				switch (num2 == num)
				{
				}
				num = (short)1946877953;
				if (num != 0)
				{
				}
				num = (short)2115960832;
				short num3 = num;
				num = (short)2132606976;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.StepSize = value;
			}
		}

		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x0600944E RID: 37966 RVA: 0x008BAE48 File Offset: 0x008B9048
		// (set) Token: 0x0600944F RID: 37967 RVA: 0x008BAF00 File Offset: 0x008B9100
		public bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_Applicable
		{
			get
			{
				short num = (short)235201336;
				short num2 = num;
				num = (short)1065476920;
				switch (num2 == num)
				{
				}
				num = (short)2046558209;
				if (num != 0)
				{
				}
				num = (short)1135083520;
				short num3 = num;
				num = (short)48037888;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Applicable;
			}
			set
			{
				short num = (short)1993646091;
				short num2 = num;
				num = (short)1594466315;
				switch (num2 == num)
				{
				}
				num = (short)1261895681;
				if (num != 0)
				{
				}
				num = (short)729808896;
				short num3 = num;
				num = (short)826212352;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Applicable = value;
			}
		}

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x06009450 RID: 37968 RVA: 0x008BAFB4 File Offset: 0x008B91B4
		// (set) Token: 0x06009451 RID: 37969 RVA: 0x008BB068 File Offset: 0x008B9268
		public bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_Valid
		{
			get
			{
				short num = (short)1228076188;
				short num2 = num;
				num = (short)2036528284;
				switch (num2 == num)
				{
				}
				num = (short)765132801;
				if (num != 0)
				{
				}
				num = (short)1052311552;
				short num3 = num;
				num = (short)1478230016;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Valid;
			}
			set
			{
				short num = (short)1359923467;
				short num2 = num;
				num = (short)627886347;
				switch (num2 == num)
				{
				}
				num = (short)469106688;
				if (num != 0)
				{
				}
				num = (short)474873856;
				short num3 = num;
				num = (short)1231683585;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Valid = value;
			}
		}

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x06009452 RID: 37970 RVA: 0x008BB11C File Offset: 0x008B931C
		// (set) Token: 0x06009453 RID: 37971 RVA: 0x008BB1D4 File Offset: 0x008B93D4
		public bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_Visible
		{
			get
			{
				short num = (short)97846389;
				short num2 = num;
				num = (short)300090485;
				switch (num2 == num)
				{
				}
				num = (short)1778712577;
				if (num != 0)
				{
				}
				num = (short)490668032;
				short num3 = num;
				num = (short)1245773824;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Visible;
			}
			set
			{
				short num = (short)1612582794;
				short num2 = num;
				num = (short)377884554;
				switch (num2 == num)
				{
				}
				num = (short)2127429632;
				if (num != 0)
				{
				}
				num = (short)1977286656;
				short num3 = num;
				num = (short)1336868865;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Visible = value;
			}
		}

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x06009454 RID: 37972 RVA: 0x008BB28C File Offset: 0x008B948C
		// (set) Token: 0x06009455 RID: 37973 RVA: 0x008BB344 File Offset: 0x008B9544
		public bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_Editable
		{
			get
			{
				short num = (short)2022097243;
				short num2 = num;
				num = (short)1299104091;
				switch (num2 == num)
				{
				}
				num = (short)304283649;
				if (num != 0)
				{
				}
				num = (short)805765120;
				short num3 = num;
				num = (short)1553137664;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Editable;
			}
			set
			{
				short num = (short)1725767123;
				short num2 = num;
				num = (short)1978277331;
				switch (num2 == num)
				{
				}
				num = (short)466288641;
				if (num != 0)
				{
				}
				num = (short)1789591552;
				short num3 = num;
				num = (short)459210752;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.Editable = value;
			}
		}

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x06009456 RID: 37974 RVA: 0x008BB3FC File Offset: 0x008B95FC
		internal string FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_UILabel
		{
			get
			{
				short num = (short)565329557;
				short num2 = num;
				num = (short)131677845;
				switch (num2 == num)
				{
				}
				num = (short)1077477377;
				if (num != 0)
				{
				}
				num = (short)2103967744;
				short num3 = num;
				num = (short)110428160;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.UIName;
			}
		}

		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x06009457 RID: 37975 RVA: 0x008BB4B0 File Offset: 0x008B96B0
		// (set) Token: 0x06009458 RID: 37976 RVA: 0x008BB564 File Offset: 0x008B9764
		internal bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_HiddenStatic
		{
			get
			{
				short num = (short)1722121288;
				short num2 = num;
				num = (short)1599437896;
				switch (num2 == num)
				{
				}
				num = (short)2041708544;
				if (num != 0)
				{
				}
				num = (short)960167936;
				short num3 = num;
				num = (short)2088566785;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.HiddenStatic;
			}
			set
			{
				short num = (short)1432063276;
				short num2 = num;
				num = (short)1135709484;
				switch (num2 == num)
				{
				}
				num = (short)1495859200;
				if (num != 0)
				{
				}
				num = (short)244514816;
				short num3 = num;
				num = (short)415760385;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.HiddenStatic = value;
			}
		}

		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x06009459 RID: 37977 RVA: 0x008BB618 File Offset: 0x008B9818
		// (set) Token: 0x0600945A RID: 37978 RVA: 0x008BB6CC File Offset: 0x008B98CC
		internal bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_HiddenDynamic
		{
			get
			{
				short num = (short)1311664424;
				short num2 = num;
				num = (short)125004072;
				switch (num2 == num)
				{
				}
				num = (short)142147585;
				if (num != 0)
				{
				}
				num = (short)2022703104;
				short num3 = num;
				num = (short)2086207488;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.HiddenDynamic;
			}
			set
			{
				short num = (short)1053109839;
				short num2 = num;
				num = (short)1338846799;
				switch (num2 == num)
				{
				}
				num = (short)321912833;
				if (num != 0)
				{
				}
				num = (short)439877632;
				short num3 = num;
				num = (short)1762000896;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.HiddenDynamic = value;
			}
		}

		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x0600945B RID: 37979 RVA: 0x008BB784 File Offset: 0x008B9984
		public bool FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_HasDiffs
		{
			get
			{
				short num = (short)1501551023;
				short num2 = num;
				num = (short)326293935;
				switch (num2 == num)
				{
				}
				num = (short)221577216;
				if (num != 0)
				{
				}
				num = (short)1316028416;
				short num3 = num;
				num = (short)477429761;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468._HasDiffs;
			}
		}

		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x0600945C RID: 37980 RVA: 0x008BB83C File Offset: 0x008B9A3C
		// (set) Token: 0x0600945D RID: 37981 RVA: 0x008BB8F0 File Offset: 0x008B9AF0
		public int FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469Value
		{
			get
			{
				short num = (short)1626048695;
				short num2 = num;
				num = (short)1555531959;
				switch (num2 == num)
				{
				}
				num = (short)1789198337;
				if (num != 0)
				{
				}
				num = (short)1058209792;
				short num3 = num;
				num = (short)158203904;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Value;
			}
			set
			{
				short num = (short)109586082;
				short num2 = num;
				num = (short)412559010;
				switch (num2 == num)
				{
				}
				num = (short)682164224;
				if (num != 0)
				{
				}
				num = (short)1214644224;
				short num3 = num;
				num = (short)122945537;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Value = value;
			}
		}

		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x0600945E RID: 37982 RVA: 0x008BB9A8 File Offset: 0x008B9BA8
		// (set) Token: 0x0600945F RID: 37983 RVA: 0x008BBA5C File Offset: 0x008B9C5C
		public string FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_UIValue
		{
			get
			{
				short num = (short)488111700;
				short num2 = num;
				num = (short)2101083732;
				switch (num2 == num)
				{
				}
				num = (short)919863296;
				if (num != 0)
				{
				}
				num = (short)1413873664;
				short num3 = num;
				num = (short)50659329;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.UIValue;
			}
			set
			{
				short num = (short)1540734113;
				short num2 = num;
				num = (short)462732449;
				switch (num2 == num)
				{
				}
				num = (short)674955264;
				if (num != 0)
				{
				}
				num = (short)852754432;
				short num3 = num;
				num = (short)2110259201;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.UIValue = value;
			}
		}

		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x06009460 RID: 37984 RVA: 0x008BBB14 File Offset: 0x008B9D14
		public global::AcpBusinessLayer.AcpListField FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469
		{
			get
			{
				short num = (short)398438210;
				short num2 = num;
				num = (short)2095230786;
				switch (num2 == num)
				{
				}
				num = (short)345833473;
				if (num != 0)
				{
				}
				num = (short)466747392;
				short num3 = num;
				num = (short)1062469632;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;
			}
		}

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x06009461 RID: 37985 RVA: 0x008BBBC4 File Offset: 0x008B9DC4
		// (set) Token: 0x06009462 RID: 37986 RVA: 0x008BBC78 File Offset: 0x008B9E78
		public bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_Applicable
		{
			get
			{
				short num = (short)902067308;
				short num2 = num;
				num = (short)2092528748;
				switch (num2 == num)
				{
				}
				num = (short)1400700928;
				if (num != 0)
				{
				}
				num = (short)667549696;
				short num3 = num;
				num = (short)786825217;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Applicable;
			}
			set
			{
				short num = (short)340705064;
				short num2 = num;
				num = (short)568508200;
				switch (num2 == num)
				{
				}
				num = (short)21626881;
				if (num != 0)
				{
				}
				num = (short)935002112;
				short num3 = num;
				num = (short)254148608;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Applicable = value;
			}
		}

		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x06009463 RID: 37987 RVA: 0x008BBD2C File Offset: 0x008B9F2C
		// (set) Token: 0x06009464 RID: 37988 RVA: 0x008BBDE0 File Offset: 0x008B9FE0
		public bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_Valid
		{
			get
			{
				short num = (short)2082842041;
				short num2 = num;
				num = (short)1637197241;
				switch (num2 == num)
				{
				}
				num = (short)1498021889;
				if (num != 0)
				{
				}
				num = (short)1205665792;
				short num3 = num;
				num = (short)1545666560;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Valid;
			}
			set
			{
				short num = (short)396018174;
				short num2 = num;
				num = (short)1265680894;
				switch (num2 == num)
				{
				}
				num = (short)843251713;
				if (num != 0)
				{
				}
				num = (short)2047672320;
				short num3 = num;
				num = (short)1310195712;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Valid = value;
			}
		}

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x06009465 RID: 37989 RVA: 0x008BBE94 File Offset: 0x008BA094
		// (set) Token: 0x06009466 RID: 37990 RVA: 0x008BBF48 File Offset: 0x008BA148
		public bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_Visible
		{
			get
			{
				short num = (short)506290587;
				short num2 = num;
				num = (short)1773167003;
				switch (num2 == num)
				{
				}
				num = (short)1600520193;
				if (num != 0)
				{
				}
				num = (short)448266240;
				short num3 = num;
				num = (short)1855717376;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Visible;
			}
			set
			{
				short num = (short)170900248;
				short num2 = num;
				num = (short)993901336;
				switch (num2 == num)
				{
				}
				num = (short)1876688897;
				if (num != 0)
				{
				}
				num = (short)2027421696;
				short num3 = num;
				num = (short)1894711296;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Visible = value;
			}
		}

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x06009467 RID: 37991 RVA: 0x008BC000 File Offset: 0x008BA200
		// (set) Token: 0x06009468 RID: 37992 RVA: 0x008BC0B4 File Offset: 0x008BA2B4
		public bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_Editable
		{
			get
			{
				short num = (short)2116526256;
				short num2 = num;
				num = (short)927047856;
				switch (num2 == num)
				{
				}
				num = (short)1762328576;
				if (num != 0)
				{
				}
				num = (short)463732736;
				short num3 = num;
				num = (short)93257729;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Editable;
			}
			set
			{
				short num = (short)891766851;
				short num2 = num;
				num = (short)504055875;
				switch (num2 == num)
				{
				}
				num = (short)723582977;
				if (num != 0)
				{
				}
				num = (short)535429120;
				short num3 = num;
				num = (short)1784872960;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.Editable = value;
			}
		}

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x06009469 RID: 37993 RVA: 0x008BC168 File Offset: 0x008BA368
		internal string FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_UILabel
		{
			get
			{
				short num = (short)2085139677;
				short num2 = num;
				num = (short)435795165;
				switch (num2 == num)
				{
				}
				num = (short)1172832257;
				if (num != 0)
				{
				}
				num = (short)577241088;
				short num3 = num;
				num = (short)1082982400;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.UIName;
			}
		}

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x0600946A RID: 37994 RVA: 0x008BC21C File Offset: 0x008BA41C
		// (set) Token: 0x0600946B RID: 37995 RVA: 0x008BC2D0 File Offset: 0x008BA4D0
		internal bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_HiddenStatic
		{
			get
			{
				short num = (short)145660242;
				short num2 = num;
				num = (short)557685074;
				switch (num2 == num)
				{
				}
				num = (short)442236929;
				if (num != 0)
				{
				}
				num = (short)1900871680;
				short num3 = num;
				num = (short)845676544;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.HiddenStatic;
			}
			set
			{
				short num = (short)783422882;
				short num2 = num;
				num = (short)1244796322;
				switch (num2 == num)
				{
				}
				num = (short)1007747073;
				if (num != 0)
				{
				}
				num = (short)1060831232;
				short num3 = num;
				num = (short)1011220480;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.HiddenStatic = value;
			}
		}

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x0600946C RID: 37996 RVA: 0x008BC384 File Offset: 0x008BA584
		// (set) Token: 0x0600946D RID: 37997 RVA: 0x008BC43C File Offset: 0x008BA63C
		internal bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_HiddenDynamic
		{
			get
			{
				short num = (short)1709343520;
				short num2 = num;
				num = (short)1569555232;
				switch (num2 == num)
				{
				}
				num = (short)580911105;
				if (num != 0)
				{
				}
				num = (short)719912960;
				short num3 = num;
				num = (short)343474176;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.HiddenDynamic;
			}
			set
			{
				short num = (short)234140265;
				short num2 = num;
				num = (short)805679721;
				switch (num2 == num)
				{
				}
				num = (short)514916352;
				if (num != 0)
				{
				}
				num = (short)1988296704;
				short num3 = num;
				num = (short)915996673;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.HiddenDynamic = value;
			}
		}

		// Token: 0x17004AB2 RID: 19122
		// (get) Token: 0x0600946E RID: 37998 RVA: 0x008BC4F4 File Offset: 0x008BA6F4
		public bool FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_HasDiffs
		{
			get
			{
				short num = (short)1183685021;
				short num2 = num;
				num = (short)898341277;
				switch (num2 == num)
				{
				}
				num = (short)1681784833;
				if (num != 0)
				{
				}
				num = (short)1483276288;
				short num3 = num;
				num = (short)1082327040;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469._HasDiffs;
			}
		}

		// Token: 0x17004AB3 RID: 19123
		// (get) Token: 0x0600946F RID: 37999 RVA: 0x008BC5A8 File Offset: 0x008BA7A8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1524248867;
				short num2 = num;
				num = (short)931410211;
				switch (num2 == num)
				{
				}
				num = (short)1007419392;
				if (num != 0)
				{
				}
				num = (short)1926103040;
				short num3 = num;
				num = (short)1446051841;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x008BC668 File Offset: 0x008BA868
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1263206400;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1132986372;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_118;
				case 1:
					goto IL_118;
				case 2:
					num = (short)1054474241;
					if (num != 0)
					{
					}
					num = (short)34406400;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					IL_64:
					if (base.ParentRecset != null)
					{
						num = (short)860684290;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_118;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)219742209;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_118:
				num = (short)399183567;
				short num4 = num;
				num = (short)1916407503;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_64;
				default:
					goto IL_14D;
				}
			}
			IL_14D:
			num = (short)139132928;
			if (num != 0)
			{
			}
			return result;
			IL_4D:
			result = null;
			num = (short)52690947;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x040049EA RID: 18922
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;

		// Token: 0x040049EB RID: 18923
		private global::AcpBusinessLayer.AcpListField fctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;
	}
}
