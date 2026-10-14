using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002EE RID: 750
	[global::System.Serializable]
	public class RadioVIPInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007983 RID: 31107 RVA: 0x006E70D8 File Offset: 0x006E52D8
		public RadioVIPInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x006E70F4 File Offset: 0x006E52F4
		protected RadioVIPInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x006E710C File Offset: 0x006E530C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)302710784;
			short num2 = num;
			num = (short)831814195;
			short num3 = num;
			num = (short)2135325235;
			switch (num3 == num)
			{
			}
			num = (short)1720188929;
			if (num != 0)
			{
			}
			num = (short)684916736;
			if (num != 0)
			{
			}
			this.radVipOutputBCO_A20946 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipOutputBCO_A20946LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipOutputBCO_A20946LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖还닚규郞铠韢闤鋦鷨ꧪ껬ꃮ껰닲쟴쟶샸쿺쯼", a_), global::CommonResources.AcgResources.ID_OUTPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipOutputBCO_A20946LovStrs);
			this.radVipOutputBCO_A20946.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radVipOutputBCO_A20946.DataTransferOrder = -1;
			this.radVipInputBCO_A21328 = new global::AcpBusinessLayer.AcpSparseLOVField(16, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipInputBCO_A21328LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipInputBCO_A21328LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖还닚규雞迠鏢郤鏦ꯨ꣪ꋬ냮냰쇲쓴쓶쯸쏺", a_), global::CommonResources.AcgResources.ID_INPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipInputBCO_A21328LovStrs);
			this.radVipInputBCO_A21328.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radVipInputBCO_A21328.DataTransferOrder = -1;
			this.radVipInputFeature_A21329 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipInputFeature_A21329LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipInputFeature_A21329LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖还닚규雞迠鏢郤鏦꿨軪賬鯮蓰臲郴ꣶ룸짺쳼쳾㌀㨂", a_), global::CommonResources.AcgResources.ID_INPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipInputFeature_A21329LovStrs);
			this.radVipInputFeature_A21329.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radVipInputFeature_A21329.DataTransferOrder = 5;
			this.radVipInputFeature_A21329.ValidateAcrossRecset = true;
			this.radVipKey_A22500 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臒듔돖还닚규铞蓠髢뫤ꛦ\udbe8\ud9ea\ud8ec\udfee쇰", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.radVipKey_A22500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radVipKey_A22500.DataTransferOrder = -1;
			this.radVipName_A22501 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("", a_), this, global::AllFeatures.CodeplugGuid.b("臒듔돖还닚규釞胠転胤룦꣨\ud9ea\udfec\udaee쇰싲", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radVipName_A22501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radVipName_A22501.DataTransferOrder = -1;
			this.radVipOutputFeature_A20947 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipOutputFeature_A20947LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipOutputFeature_A20947LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖还닚규郞铠韢闤鋦鷨귪裬軮藰蛲蟴鋶꛸뫺쿼쿾㠀㜂㈄", a_), global::CommonResources.AcgResources.ID_OUTPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipOutputFeature_A20947LovStrs);
			this.radVipOutputFeature_A20947.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radVipOutputFeature_A20947.DataTransferOrder = 4;
			this.radVipOutputFeature_A20947.ValidateAcrossRecset = true;
			this.radioVIPShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("臒듔돖냘듚诜雞뇠냢跤裦鯨鿪뷬鷮铰胲蛴ꏶ郸雺飼", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radioVIPShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioVIPShortPressTime.DataTransferOrder = -1;
			this.radioVIPShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radioVIPShortPressTime.ShowHexValue = false;
			this.radioVIPShortPressTime.ValidateAcrossRecset = true;
			this.radioVIPLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("臒듔돖냘듚诜雞뇠꿢諤触軨믪鿬諮苰胲ꇴ黶铸黺", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radioVIPLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioVIPLongPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radioVIPLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radioVIPLongPressTime.ShowHexValue = false;
			this.radioVIPLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臒듔돖냘듚﷜觞꣠돢엤돦裨觪臬諮", a_);
			base.Id = 10207;
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x006E74A8 File Offset: 0x006E56A8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)60817425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍鯏럑귓觕駗탟틡", a_)))
					{
						num = (short)1089798170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍鿏ꟑꃓꛕ귗껙髛믝臟雡釣铥跧뗩귫\udced샯쯱샳쇵", a_)))
					{
						num = (short)785186837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_427;
				case 2:
					goto IL_504;
				case 3:
					this.radVipOutputBCO_A20946 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipOutputBCO_A20946LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipOutputBCO_A20946LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍鿏ꟑꃓꛕ귗껙黛鷝꿟뷡ꗣ퓥\ud8e7폩\ud8eb\ud8ed", a_), global::CommonResources.AcgResources.ID_OUTPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipOutputBCO_A20946LovStrs);
					this.radVipOutputBCO_A20946.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radVipOutputBCO_A20946.DataTransferOrder = -1;
					goto IL_64E;
				case 4:
					num = (short)1294729236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)209387543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_427;
				case 7:
					this.radioVIPLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ飍駏苑飓맕뛗뷙賛곝藟釡韣닥臧蟩觫", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radioVIPLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioVIPLongPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radioVIPLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radioVIPLongPressTime.ShowHexValue = false;
					this.radioVIPLongPressTime.ValidateAcrossRecset = true;
					num = (short)271187970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.radVipInputFeature_A21329 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipInputFeature_A21329LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipInputFeature_A21329LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍駏병ꓓꏕ곗鳙맛뿝铟韡難菥럧ꯩ\udeeb\udfed쏯샱췳", a_), global::CommonResources.AcgResources.ID_INPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipInputFeature_A21329LovStrs);
					this.radVipInputFeature_A21329.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radVipInputFeature_A21329.DataTransferOrder = 5;
					this.radVipInputFeature_A21329.ValidateAcrossRecset = true;
					num = (short)404094988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)1003880448;
					short num3 = num;
					this.radVipInputBCO_A21328 = new global::AcpBusinessLayer.AcpSparseLOVField(16, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipInputBCO_A21328LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipInputBCO_A21328LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍駏병ꓓꏕ곗飙鿛針뿟ꏡ훣ퟥ\udbe7\ud8e9퓫", a_), global::CommonResources.AcgResources.ID_INPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipInputBCO_A21328LovStrs);
					this.radVipInputBCO_A21328.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radVipInputBCO_A21328.DataTransferOrder = -1;
					num = (short)718536731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					goto IL_15A;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍黏돑맓돕蟗鯙헟틡헣", a_)))
					{
						num = (short)1933639696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 12:
					goto IL_36E;
				case 13:
					goto IL_C3;
				case 14:
					this.radioVIPShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ飍駏苑蟓뻕럗꣙꣛軝鋟蟡韣闥볧菩臫语", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radioVIPShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioVIPShortPressTime.DataTransferOrder = -1;
					this.radioVIPShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radioVIPShortPressTime.ShowHexValue = false;
					this.radioVIPShortPressTime.ValidateAcrossRecset = true;
					num = (short)726925337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍駏병ꓓꏕ곗飙鿛針뿟ꏡ훣ퟥ\udbe7\ud8e9퓫", a_)))
					{
						num = (short)323944457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_531;
				case 16:
					this.radVipName_A22501 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﳅ", a_), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍黏돑맓돕蟗鯙헟틡헣", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radVipName_A22501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radVipName_A22501.DataTransferOrder = -1;
					num = (short)1588592653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ飍駏苑飓맕뛗뷙賛곝藟釡韣닥臧蟩觫", a_)))
					{
						num = (short)392822791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79A;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ飍駏苑蟓뻕럗꣙꣛軝鋟蟡韣闥볧菩臫语", a_)))
					{
						num = (short)1223491598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_321;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍鿏ꟑꃓꛕ귗껙黛鷝꿟뷡ꗣ퓥\ud8e7폩\ud8eb\ud8ed", a_)))
					{
						num = (short)1414987779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
				case 21:
					this.radVipOutputFeature_A20947 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexRadVipOutputFeature_A20947LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idRadVipOutputFeature_A20947LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍鿏ꟑꃓꛕ귗껙髛믝臟雡釣铥跧뗩귫\udced샯쯱샳쇵", a_), global::CommonResources.AcgResources.ID_OUTPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.RadVipOutputFeature_A20947LovStrs);
					this.radVipOutputFeature_A20947.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radVipOutputFeature_A20947.DataTransferOrder = 4;
					this.radVipOutputFeature_A20947.ValidateAcrossRecset = true;
					num = (short)1455030278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_10F;
				case 23:
					if (producerFields != null)
					{
						num = (short)1763573764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79A;
				case 24:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍駏병ꓓꏕ곗鳙맛뿝铟韡難菥럧ꯩ\udeeb\udfed쏯샱췳", a_)))
					{
						goto IL_36E;
					}
					num = (short)56128437;
					short num4 = num;
					num = (short)1166242741;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64E;
					default:
						num = (short)1447886848;
						if (num != 0)
						{
						}
						num = (short)821231624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 25:
					goto IL_321;
				case 26:
					this.radVipKey_A22500 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇鳉ꗋ뻍鯏럑귓觕駗탟틡", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.radVipKey_A22500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radVipKey_A22500.DataTransferOrder = -1;
					num = (short)836894742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_531;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)731447301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_79A;
				IL_C3:
				num = (short)2083520513;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10F:
				num = (short)1359085579;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15A:
				num = (short)534708239;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_321:
				num = (short)132972562;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36E:
				num = (short)347406336;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_427:
				num = (short)1168572435;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_531:
				num = (short)1973026840;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64E:
				num = (short)76087306;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_504:
			num = (short)433913857;
			if (num != 0)
			{
			}
			IL_79A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ蛏鯑蓓賗믙뻛닝藟", a_);
			base.Id = 10207;
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x006E7C80 File Offset: 0x006E5E80
		public override void PopulateReferences()
		{
			short num = (short)1143078912;
			short num2 = num;
			num = (short)1585661940;
			short num3 = num;
			num = (short)81676276;
			switch (num3 == num)
			{
			}
			num = (short)1482620929;
			if (num != 0)
			{
			}
			num = (short)1471479808;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x006E7D2C File Offset: 0x006E5F2C
		public override void DropReferences()
		{
			short num = (short)1007091712;
			short num2 = num;
			num = (short)1812289096;
			short num3 = num;
			num = (short)340285000;
			switch (num3 == num)
			{
			}
			num = (short)688914433;
			if (num != 0)
			{
			}
			num = (short)257949696;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x006E7DD4 File Offset: 0x006E5FD4
		public override void SetConstraints()
		{
			short num = (short)655360;
			short num2 = num;
			num = (short)1882138682;
			short num3 = num;
			num = (short)2091460666;
			switch (num3 == num)
			{
			}
			num = (short)1528299520;
			if (num != 0)
			{
			}
			num = (short)940244993;
			if (num != 0)
			{
			}
			this.radVipOutputBCO_A20946.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConNumOfDekBoxesIs0);
			this.radVipInputBCO_A21328.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConNumOfDekBoxesIs0);
			this.radVipInputFeature_A21329.ValidateAcrossRecset = true;
			this.radVipInputFeature_A21329.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConNumOfDekBoxesIs0);
			this.radVipInputFeature_A21329.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.conRadioVIPInputSelectionIsValid);
			this.radVipInputFeature_A21329.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConNumOfDekBoxesIs0Editbl);
			this.radVipKey_A22500.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConNumOfDekBoxesIs0);
			this.radVipName_A22501.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radVipOutputFeature_A20947.ValidateAcrossRecset = true;
			this.radVipOutputFeature_A20947.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConNumOfDekBoxesIs0ForR4);
			this.radVipOutputFeature_A20947.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConRadioVIPOutputFeaturesSelect);
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x006E7F60 File Offset: 0x006E6160
		public override void SetupDependencies()
		{
			short num = (short)1650262016;
			short num2 = num;
			num = (short)2074504398;
			short num3 = num;
			num = (short)1085762766;
			switch (num3 == num)
			{
			}
			num = (short)1676017665;
			if (num != 0)
			{
			}
			num = (short)527892480;
			if (num != 0)
			{
			}
			this.RefDEK.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.radVipOutputBCO_A20946);
			this.RefDEK.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.radVipInputBCO_A21328);
			this.RefDEK.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.radVipInputFeature_A21329);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radVipInputFeature_A21329);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedConsoletteEnable_A37231.AddDependentObject(this.radVipInputFeature_A21329);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.radVipInputFeature_A21329);
			this.RefDEK.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.radVipKey_A22500);
			this.RefDEK.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.radVipOutputFeature_A20947);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radVipOutputFeature_A20947);
			this.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.AddDependentObject(this.radVipOutputFeature_A20947);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedConsoletteEnable_A37231.AddDependentObject(this.radVipOutputFeature_A20947);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.radVipOutputFeature_A20947);
			this.radVipInputFeature_A21329.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10225] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren).RadErgoWidePASirenSirenPAAfterReset_A9140);
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x006E818C File Offset: 0x006E638C
		public bool HasDiffs
		{
			get
			{
				short num = (short)81657856;
				short num2 = num;
				num = (short)48925391;
				short num3 = num;
				num = (short)816483023;
				switch (num3 == num)
				{
				}
				num = (short)308477953;
				if (num != 0)
				{
				}
				num = (short)1286275072;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x006E823C File Offset: 0x006E643C
		// (set) Token: 0x0600798D RID: 31117 RVA: 0x006E82F0 File Offset: 0x006E64F0
		public int RadVipOutputBCO_A20946Value
		{
			get
			{
				short num = (short)437190656;
				short num2 = num;
				num = (short)1834876929;
				if (num != 0)
				{
				}
				num = (short)1979073700;
				short num3 = num;
				num = (short)1252279460;
				switch (num3 == num)
				{
				}
				num = (short)400097280;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.Value;
			}
			set
			{
				short num = (short)903348224;
				short num2 = num;
				num = (short)110988999;
				short num3 = num;
				num = (short)128749255;
				switch (num3 == num)
				{
				}
				num = (short)1075970048;
				if (num != 0)
				{
				}
				num = (short)1380057089;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.Value = value;
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600798E RID: 31118 RVA: 0x006E83A8 File Offset: 0x006E65A8
		// (set) Token: 0x0600798F RID: 31119 RVA: 0x006E8460 File Offset: 0x006E6660
		public string RadVipOutputBCO_A20946_UIValue
		{
			get
			{
				short num = (short)1800011776;
				short num2 = num;
				num = (short)1104091687;
				short num3 = num;
				num = (short)1046551079;
				switch (num3 == num)
				{
				}
				num = (short)2028011520;
				if (num != 0)
				{
				}
				num = (short)539164673;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.UIValue;
			}
			set
			{
				short num = (short)407568384;
				short num2 = num;
				num = (short)384072086;
				short num3 = num;
				num = (short)1097300374;
				switch (num3 == num)
				{
				}
				num = (short)93913089;
				if (num != 0)
				{
				}
				num = (short)632750080;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.UIValue = value;
			}
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x06007990 RID: 31120 RVA: 0x006E8518 File Offset: 0x006E6718
		public global::AcpBusinessLayer.AcpListField RadVipOutputBCO_A20946
		{
			get
			{
				short num = (short)849674240;
				short num2 = num;
				num = (short)2110193665;
				if (num != 0)
				{
				}
				num = (short)1428660713;
				short num3 = num;
				num = (short)1008247273;
				switch (num3 == num)
				{
				}
				num = (short)1068498944;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946;
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x06007991 RID: 31121 RVA: 0x006E85C4 File Offset: 0x006E67C4
		// (set) Token: 0x06007992 RID: 31122 RVA: 0x006E8678 File Offset: 0x006E6878
		public bool RadVipOutputBCO_A20946_Applicable
		{
			get
			{
				short num = (short)279838720;
				short num2 = num;
				num = (short)1248324045;
				short num3 = num;
				num = (short)420866509;
				switch (num3 == num)
				{
				}
				num = (short)1242955777;
				if (num != 0)
				{
				}
				num = (short)1991114752;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.Applicable;
			}
			set
			{
				short num = (short)233004579;
				short num2 = num;
				num = (short)581328419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847511552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762394113;
				if (num != 0)
				{
				}
				num = (short)595787776;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.Applicable = value;
			}
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x006E872C File Offset: 0x006E692C
		// (set) Token: 0x06007994 RID: 31124 RVA: 0x006E87E0 File Offset: 0x006E69E0
		public bool RadVipOutputBCO_A20946_Valid
		{
			get
			{
				short num = (short)2121267580;
				short num2 = num;
				num = (short)2047670652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399966208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266600449;
				if (num != 0)
				{
				}
				num = (short)1577189376;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.Valid;
			}
			set
			{
				short num = (short)672702494;
				short num2 = num;
				num = (short)767336478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207304192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265289729;
				if (num != 0)
				{
				}
				num = (short)58916864;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.Valid = value;
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x06007995 RID: 31125 RVA: 0x006E8894 File Offset: 0x006E6A94
		// (set) Token: 0x06007996 RID: 31126 RVA: 0x006E894C File Offset: 0x006E6B4C
		public bool RadVipOutputBCO_A20946_Visible
		{
			get
			{
				short num = (short)2118916068;
				short num2 = num;
				num = (short)394336228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1009123328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)165412865;
				if (num != 0)
				{
				}
				num = (short)1226440704;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.Visible;
			}
			set
			{
				short num = (short)338342397;
				short num2 = num;
				num = (short)922726909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051014656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700724737;
				if (num != 0)
				{
				}
				num = (short)559874048;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.Visible = value;
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x06007997 RID: 31127 RVA: 0x006E8A04 File Offset: 0x006E6C04
		// (set) Token: 0x06007998 RID: 31128 RVA: 0x006E8AB8 File Offset: 0x006E6CB8
		public bool RadVipOutputBCO_A20946_Editable
		{
			get
			{
				short num = (short)1405997848;
				short num2 = num;
				num = (short)1742131992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319094784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1126301697;
				if (num != 0)
				{
				}
				num = (short)568131584;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.Editable;
			}
			set
			{
				short num = (short)1232908635;
				short num2 = num;
				num = (short)1478996315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)808058880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113208320;
				if (num != 0)
				{
				}
				num = (short)89522177;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.Editable = value;
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x006E8B6C File Offset: 0x006E6D6C
		internal string RadVipOutputBCO_A20946_UILabel
		{
			get
			{
				short num = (short)146626487;
				short num2 = num;
				num = (short)1709529015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1534197760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61669377;
				if (num != 0)
				{
				}
				num = (short)2009989120;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.UIName;
			}
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x006E8C24 File Offset: 0x006E6E24
		// (set) Token: 0x0600799B RID: 31131 RVA: 0x006E8CDC File Offset: 0x006E6EDC
		internal bool RadVipOutputBCO_A20946_HiddenStatic
		{
			get
			{
				short num = (short)1929057894;
				short num2 = num;
				num = (short)25826918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)342884352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264306689;
				if (num != 0)
				{
				}
				num = (short)657784832;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.HiddenStatic;
			}
			set
			{
				short num = (short)2120299276;
				short num2 = num;
				num = (short)1093612300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)895352832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)710344705;
				if (num != 0)
				{
				}
				num = (short)785711104;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.HiddenStatic = value;
			}
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x006E8D90 File Offset: 0x006E6F90
		// (set) Token: 0x0600799D RID: 31133 RVA: 0x006E8E44 File Offset: 0x006E7044
		internal bool RadVipOutputBCO_A20946_HiddenDynamic
		{
			get
			{
				short num = (short)2008497538;
				short num2 = num;
				num = (short)1277640066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)329383936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1681063936;
				if (num != 0)
				{
				}
				num = (short)1452015617;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946.HiddenDynamic;
			}
			set
			{
				short num = (short)8026399;
				short num2 = num;
				num = (short)1135376671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900005888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1471414273;
				if (num != 0)
				{
				}
				num = (short)1287651328;
				if (num != 0)
				{
				}
				this.radVipOutputBCO_A20946.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x006E8EFC File Offset: 0x006E70FC
		public bool RadVipOutputBCO_A20946_HasDiffs
		{
			get
			{
				short num = (short)1213226789;
				short num2 = num;
				num = (short)770924325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)443482112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886374400;
				if (num != 0)
				{
				}
				num = (short)1093074945;
				if (num != 0)
				{
				}
				return this.radVipOutputBCO_A20946._HasDiffs;
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0600799F RID: 31135 RVA: 0x006E8FB0 File Offset: 0x006E71B0
		// (set) Token: 0x060079A0 RID: 31136 RVA: 0x006E9064 File Offset: 0x006E7264
		public int RadVipInputBCO_A21328Value
		{
			get
			{
				short num = (short)1633353729;
				if (num != 0)
				{
				}
				num = (short)1032060928;
				short num2 = num;
				num = (short)1651245443;
				short num3 = num;
				num = (short)379781507;
				switch (num3 == num)
				{
				}
				num = (short)1417281536;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.Value;
			}
			set
			{
				short num = (short)977586933;
				short num2 = num;
				num = (short)2031995637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1151074304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099694080;
				if (num != 0)
				{
				}
				num = (short)256966657;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.Value = value;
			}
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x060079A1 RID: 31137 RVA: 0x006E9118 File Offset: 0x006E7318
		// (set) Token: 0x060079A2 RID: 31138 RVA: 0x006E91CC File Offset: 0x006E73CC
		public string RadVipInputBCO_A21328_UIValue
		{
			get
			{
				short num = (short)209387521;
				if (num != 0)
				{
				}
				num = (short)1700921344;
				short num2 = num;
				num = (short)819693006;
				short num3 = num;
				num = (short)399017422;
				switch (num3 == num)
				{
				}
				num = (short)828243968;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.UIValue;
			}
			set
			{
				short num = (short)30665848;
				short num2 = num;
				num = (short)1406463096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228524032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610336768;
				if (num != 0)
				{
				}
				num = (short)228196353;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.UIValue = value;
			}
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x060079A3 RID: 31139 RVA: 0x006E9280 File Offset: 0x006E7480
		public global::AcpBusinessLayer.AcpListField RadVipInputBCO_A21328
		{
			get
			{
				short num = (short)1335268973;
				short num2 = num;
				num = (short)1109562989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746927616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1946484737;
				if (num != 0)
				{
				}
				num = (short)982974464;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x006E9330 File Offset: 0x006E7530
		// (set) Token: 0x060079A5 RID: 31141 RVA: 0x006E93E4 File Offset: 0x006E75E4
		public bool RadVipInputBCO_A21328_Applicable
		{
			get
			{
				short num = (short)1136705060;
				short num2 = num;
				num = (short)1071300132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792081920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1567686657;
				if (num != 0)
				{
				}
				num = (short)1701183488;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.Applicable;
			}
			set
			{
				short num = (short)1984351851;
				short num2 = num;
				num = (short)296210027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749731840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168493057;
				if (num != 0)
				{
				}
				num = (short)2133065728;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.Applicable = value;
			}
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x006E9498 File Offset: 0x006E7698
		// (set) Token: 0x060079A7 RID: 31143 RVA: 0x006E954C File Offset: 0x006E774C
		public bool RadVipInputBCO_A21328_Valid
		{
			get
			{
				short num = (short)501404409;
				short num2 = num;
				num = (short)150786809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667811840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2085945345;
				if (num != 0)
				{
				}
				num = (short)633929728;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.Valid;
			}
			set
			{
				short num = (short)1582696516;
				short num2 = num;
				num = (short)478480452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)531628032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398996993;
				if (num != 0)
				{
				}
				num = (short)1510801408;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.Valid = value;
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x006E9600 File Offset: 0x006E7800
		// (set) Token: 0x060079A9 RID: 31145 RVA: 0x006E96B4 File Offset: 0x006E78B4
		public bool RadVipInputBCO_A21328_Visible
		{
			get
			{
				short num = (short)1218762121;
				short num2 = num;
				num = (short)1227937161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406533632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1305018369;
				if (num != 0)
				{
				}
				num = (short)1813774336;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.Visible;
			}
			set
			{
				short num = (short)2083842008;
				short num2 = num;
				num = (short)1555425240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255538688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)176291841;
				if (num != 0)
				{
				}
				num = (short)2134114304;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.Visible = value;
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x006E9768 File Offset: 0x006E7968
		// (set) Token: 0x060079AB RID: 31147 RVA: 0x006E981C File Offset: 0x006E7A1C
		public bool RadVipInputBCO_A21328_Editable
		{
			get
			{
				short num = (short)2087865942;
				short num2 = num;
				num = (short)558255702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275527168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2085421056;
				if (num != 0)
				{
				}
				num = (short)25624577;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.Editable;
			}
			set
			{
				short num = (short)714520879;
				short num2 = num;
				num = (short)78100783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)987693056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)200605697;
				if (num != 0)
				{
				}
				num = (short)2070282240;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.Editable = value;
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x006E98D0 File Offset: 0x006E7AD0
		internal string RadVipInputBCO_A21328_UILabel
		{
			get
			{
				short num = (short)1354393067;
				short num2 = num;
				num = (short)720922091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)106364928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)913506305;
				if (num != 0)
				{
				}
				num = (short)765853696;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.UIName;
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x060079AD RID: 31149 RVA: 0x006E9984 File Offset: 0x006E7B84
		// (set) Token: 0x060079AE RID: 31150 RVA: 0x006E9A34 File Offset: 0x006E7C34
		internal bool RadVipInputBCO_A21328_HiddenStatic
		{
			get
			{
				short num = (short)218553468;
				short num2 = num;
				num = (short)1108860028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1791426560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1991573505;
				if (num != 0)
				{
				}
				num = (short)797507584;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.HiddenStatic;
			}
			set
			{
				short num = (short)373451907;
				short num2 = num;
				num = (short)537029763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483393536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957888000;
				if (num != 0)
				{
				}
				num = (short)548929537;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.HiddenStatic = value;
			}
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x060079AF RID: 31151 RVA: 0x006E9AEC File Offset: 0x006E7CEC
		// (set) Token: 0x060079B0 RID: 31152 RVA: 0x006E9BA0 File Offset: 0x006E7DA0
		internal bool RadVipInputBCO_A21328_HiddenDynamic
		{
			get
			{
				short num = (short)1483348834;
				short num2 = num;
				num = (short)1563564898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747451904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1500512256;
				if (num != 0)
				{
				}
				num = (short)2045902849;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328.HiddenDynamic;
			}
			set
			{
				short num = (short)1951662081;
				if (num != 0)
				{
				}
				num = (short)408748032;
				short num2 = num;
				num = (short)1374939666;
				short num3 = num;
				num = (short)1422715410;
				switch (num3 == num)
				{
				}
				num = (short)79822848;
				if (num != 0)
				{
				}
				this.radVipInputBCO_A21328.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x060079B1 RID: 31153 RVA: 0x006E9C54 File Offset: 0x006E7E54
		public bool RadVipInputBCO_A21328_HasDiffs
		{
			get
			{
				short num = (short)617935764;
				short num2 = num;
				num = (short)1286665108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13631488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547894785;
				if (num != 0)
				{
				}
				num = (short)1640759296;
				if (num != 0)
				{
				}
				return this.radVipInputBCO_A21328._HasDiffs;
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x006E9D08 File Offset: 0x006E7F08
		// (set) Token: 0x060079B3 RID: 31155 RVA: 0x006E9DC0 File Offset: 0x006E7FC0
		public int RadVipInputFeature_A21329Value
		{
			get
			{
				short num = (short)1165897874;
				short num2 = num;
				num = (short)1893085330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611399168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1387986944;
				if (num != 0)
				{
				}
				num = (short)1755512833;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.Value;
			}
			set
			{
				short num = (short)1459577256;
				short num2 = num;
				num = (short)1292001704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)884146176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1681522689;
				if (num != 0)
				{
				}
				num = (short)468647936;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.Value = value;
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x006E9E78 File Offset: 0x006E8078
		// (set) Token: 0x060079B5 RID: 31157 RVA: 0x006E9F2C File Offset: 0x006E812C
		public string RadVipInputFeature_A21329_UIValue
		{
			get
			{
				short num = (short)1772486657;
				if (num != 0)
				{
				}
				num = (short)1543110656;
				short num2 = num;
				num = (short)1131068399;
				short num3 = num;
				num = (short)1059109871;
				switch (num3 == num)
				{
				}
				num = (short)1230176256;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.UIValue;
			}
			set
			{
				short num = (short)760852022;
				short num2 = num;
				num = (short)1112059446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2066415616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1866596352;
				if (num != 0)
				{
				}
				num = (short)1794965505;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.UIValue = value;
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x006E9FE0 File Offset: 0x006E81E0
		public global::AcpBusinessLayer.AcpListField RadVipInputFeature_A21329
		{
			get
			{
				short num = (short)1259520813;
				short num2 = num;
				num = (short)1216922413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292173312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980877313;
				if (num != 0)
				{
				}
				num = (short)2064711680;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329;
			}
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x060079B7 RID: 31159 RVA: 0x006EA094 File Offset: 0x006E8294
		// (set) Token: 0x060079B8 RID: 31160 RVA: 0x006EA148 File Offset: 0x006E8348
		public bool RadVipInputFeature_A21329_Applicable
		{
			get
			{
				short num = (short)1978044794;
				short num2 = num;
				num = (short)2034536826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)306315264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598095361;
				if (num != 0)
				{
				}
				num = (short)99155968;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.Applicable;
			}
			set
			{
				short num = (short)135382905;
				short num2 = num;
				num = (short)729073529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1147338752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1216806913;
				if (num != 0)
				{
				}
				num = (short)1382285312;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.Applicable = value;
			}
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x060079B9 RID: 31161 RVA: 0x006EA1F8 File Offset: 0x006E83F8
		// (set) Token: 0x060079BA RID: 31162 RVA: 0x006EA2AC File Offset: 0x006E84AC
		public bool RadVipInputFeature_A21329_Valid
		{
			get
			{
				short num = (short)1184873013;
				short num2 = num;
				num = (short)1148434997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1166540800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270401536;
				if (num != 0)
				{
				}
				num = (short)881786881;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.Valid;
			}
			set
			{
				short num = (short)53673985;
				if (num != 0)
				{
				}
				num = (short)1605697536;
				short num2 = num;
				num = (short)2071554729;
				short num3 = num;
				num = (short)2021878441;
				switch (num3 == num)
				{
				}
				num = (short)419692544;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.Valid = value;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x060079BB RID: 31163 RVA: 0x006EA360 File Offset: 0x006E8560
		// (set) Token: 0x060079BC RID: 31164 RVA: 0x006EA414 File Offset: 0x006E8614
		public bool RadVipInputFeature_A21329_Visible
		{
			get
			{
				short num = (short)1853154382;
				short num2 = num;
				num = (short)1127998542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1128923136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)128253953;
				if (num != 0)
				{
				}
				num = (short)274857984;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.Visible;
			}
			set
			{
				short num = (short)1839948749;
				short num2 = num;
				num = (short)434070477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)381747200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)122093569;
				if (num != 0)
				{
				}
				num = (short)811401216;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.Visible = value;
			}
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x060079BD RID: 31165 RVA: 0x006EA4CC File Offset: 0x006E86CC
		// (set) Token: 0x060079BE RID: 31166 RVA: 0x006EA584 File Offset: 0x006E8784
		public bool RadVipInputFeature_A21329_Editable
		{
			get
			{
				short num = (short)1684357288;
				short num2 = num;
				num = (short)233980072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985871872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)872939520;
				if (num != 0)
				{
				}
				num = (short)1748893697;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.Editable;
			}
			set
			{
				short num = (short)1072106098;
				short num2 = num;
				num = (short)817957490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)751501312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926823937;
				if (num != 0)
				{
				}
				num = (short)2057895936;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.Editable = value;
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x060079BF RID: 31167 RVA: 0x006EA63C File Offset: 0x006E883C
		internal string RadVipInputFeature_A21329_UILabel
		{
			get
			{
				short num = (short)280616233;
				short num2 = num;
				num = (short)51633449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197015040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937033729;
				if (num != 0)
				{
				}
				num = (short)662700032;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.UIName;
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x060079C0 RID: 31168 RVA: 0x006EA6F4 File Offset: 0x006E88F4
		// (set) Token: 0x060079C1 RID: 31169 RVA: 0x006EA7A8 File Offset: 0x006E89A8
		internal bool RadVipInputFeature_A21329_HiddenStatic
		{
			get
			{
				short num = (short)1122631681;
				if (num != 0)
				{
				}
				num = (short)2114191360;
				short num2 = num;
				num = (short)33868052;
				short num3 = num;
				num = (short)1552861460;
				switch (num3 == num)
				{
				}
				num = (short)548339712;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.HiddenStatic;
			}
			set
			{
				short num = (short)1811770187;
				short num2 = num;
				num = (short)166030155;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2123628544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)987824129;
				if (num != 0)
				{
				}
				num = (short)526254080;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.HiddenStatic = value;
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x060079C2 RID: 31170 RVA: 0x006EA85C File Offset: 0x006E8A5C
		// (set) Token: 0x060079C3 RID: 31171 RVA: 0x006EA914 File Offset: 0x006E8B14
		internal bool RadVipInputFeature_A21329_HiddenDynamic
		{
			get
			{
				short num = (short)1724956633;
				short num2 = num;
				num = (short)774684633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194510848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1910308864;
				if (num != 0)
				{
				}
				num = (short)1927544833;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329.HiddenDynamic;
			}
			set
			{
				short num = (short)750190593;
				if (num != 0)
				{
				}
				num = (short)285933568;
				short num2 = num;
				num = (short)758562517;
				short num3 = num;
				num = (short)1299037909;
				switch (num3 == num)
				{
				}
				num = (short)1305280512;
				if (num != 0)
				{
				}
				this.radVipInputFeature_A21329.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x060079C4 RID: 31172 RVA: 0x006EA9CC File Offset: 0x006E8BCC
		public bool RadVipInputFeature_A21329_HasDiffs
		{
			get
			{
				short num = (short)1605214798;
				short num2 = num;
				num = (short)689283662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311689216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1078329344;
				if (num != 0)
				{
				}
				num = (short)386727937;
				if (num != 0)
				{
				}
				return this.radVipInputFeature_A21329._HasDiffs;
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x006EAA80 File Offset: 0x006E8C80
		// (set) Token: 0x060079C6 RID: 31174 RVA: 0x006EAB38 File Offset: 0x006E8D38
		public string RadVipKey_A22500Value
		{
			get
			{
				short num = (short)20480953;
				short num2 = num;
				num = (short)2115797945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1051394048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1776353281;
				if (num != 0)
				{
				}
				num = (short)1245904896;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.Value;
			}
			set
			{
				short num = (short)1057226752;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)297664513;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_16;
					case 1:
						this.radVipKey_A22500.Value = value;
						num = (short)846856194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					goto IL_5A;
					IL_16:
					switch (0)
					{
					case 0:
					{
						IL_5A:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)828637184;
						short num3 = num;
						num = (short)1797634930;
						short num4 = num;
						num = (short)1702804338;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							num = (short)916455424;
							if (num != 0)
							{
							}
							num = (short)460455937;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x006EAC68 File Offset: 0x006E8E68
		// (set) Token: 0x060079C8 RID: 31176 RVA: 0x006EAD20 File Offset: 0x006E8F20
		public string RadVipKey_A22500_UIValue
		{
			get
			{
				short num = (short)1878578046;
				short num2 = num;
				num = (short)614323070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573781504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975975936;
				if (num != 0)
				{
				}
				num = (short)1121452033;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.Value;
			}
			set
			{
				short num = (short)953161428;
				short num2 = num;
				num = (short)664671956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)586416128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)39518209;
				if (num != 0)
				{
				}
				num = (short)829489152;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.Value = value;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x006EADD4 File Offset: 0x006E8FD4
		public global::AcpBusinessLayer.AcpKeyField RadVipKey_A22500
		{
			get
			{
				short num = (short)1725322719;
				short num2 = num;
				num = (short)399922655;
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
				num = (short)858324993;
				if (num != 0)
				{
				}
				num = (short)140771328;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x060079CA RID: 31178 RVA: 0x006EAE84 File Offset: 0x006E9084
		// (set) Token: 0x060079CB RID: 31179 RVA: 0x006EAF34 File Offset: 0x006E9134
		public bool RadVipKey_A22500_Applicable
		{
			get
			{
				short num = (short)836370433;
				if (num != 0)
				{
				}
				num = (short)1484587008;
				short num2 = num;
				num = (short)674964467;
				short num3 = num;
				num = (short)275194867;
				switch (num3 == num)
				{
				}
				num = (short)296157184;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.Applicable;
			}
			set
			{
				short num = (short)670349381;
				short num2 = num;
				num = (short)1879488581;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2134638592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)791937024;
				if (num != 0)
				{
				}
				num = (short)1427636225;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.Applicable = value;
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x060079CC RID: 31180 RVA: 0x006EAFEC File Offset: 0x006E91EC
		// (set) Token: 0x060079CD RID: 31181 RVA: 0x006EB09C File Offset: 0x006E929C
		public bool RadVipKey_A22500_Valid
		{
			get
			{
				short num = (short)90032525;
				short num2 = num;
				num = (short)1802553741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086455808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583284225;
				if (num != 0)
				{
				}
				num = (short)1773731840;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.Valid;
			}
			set
			{
				short num = (short)1273690318;
				short num2 = num;
				num = (short)453769422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2014773248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636368385;
				if (num != 0)
				{
				}
				num = (short)1322450944;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.Valid = value;
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x060079CE RID: 31182 RVA: 0x006EB150 File Offset: 0x006E9350
		// (set) Token: 0x060079CF RID: 31183 RVA: 0x006EB204 File Offset: 0x006E9404
		public bool RadVipKey_A22500_Visible
		{
			get
			{
				short num = (short)508783917;
				short num2 = num;
				num = (short)1679715629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1265041408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2108751872;
				if (num != 0)
				{
				}
				num = (short)938606593;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.Visible;
			}
			set
			{
				short num = (short)2018563294;
				short num2 = num;
				num = (short)19453150;
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
				num = (short)1726152705;
				if (num != 0)
				{
				}
				num = (short)1357053952;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.Visible = value;
			}
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x060079D0 RID: 31184 RVA: 0x006EB2BC File Offset: 0x006E94BC
		// (set) Token: 0x060079D1 RID: 31185 RVA: 0x006EB370 File Offset: 0x006E9570
		public bool RadVipKey_A22500_Editable
		{
			get
			{
				short num = (short)513010483;
				short num2 = num;
				num = (short)20835123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786366464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2033319937;
				if (num != 0)
				{
				}
				num = (short)1565392896;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.Editable;
			}
			set
			{
				short num = (short)1852832516;
				short num2 = num;
				num = (short)1854995204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)774176768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512964097;
				if (num != 0)
				{
				}
				num = (short)1037172736;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.Editable = value;
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x060079D2 RID: 31186 RVA: 0x006EB428 File Offset: 0x006E9628
		internal string RadVipKey_A22500_UILabel
		{
			get
			{
				short num = (short)896092410;
				short num2 = num;
				num = (short)617695482;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045757952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675886593;
				if (num != 0)
				{
				}
				num = (short)2062155776;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.UIName;
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x006EB4DC File Offset: 0x006E96DC
		// (set) Token: 0x060079D4 RID: 31188 RVA: 0x006EB590 File Offset: 0x006E9790
		internal bool RadVipKey_A22500_HiddenStatic
		{
			get
			{
				short num = (short)1563249133;
				short num2 = num;
				num = (short)74467821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990656000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886571009;
				if (num != 0)
				{
				}
				num = (short)1785266176;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.HiddenStatic;
			}
			set
			{
				short num = (short)752830605;
				short num2 = num;
				num = (short)836257933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371668480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1681719297;
				if (num != 0)
				{
				}
				num = (short)1327628288;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.HiddenStatic = value;
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x060079D5 RID: 31189 RVA: 0x006EB648 File Offset: 0x006E9848
		// (set) Token: 0x060079D6 RID: 31190 RVA: 0x006EB6FC File Offset: 0x006E98FC
		internal bool RadVipKey_A22500_HiddenDynamic
		{
			get
			{
				short num = (short)1246297468;
				short num2 = num;
				num = (short)156761468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18612224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1355415553;
				if (num != 0)
				{
				}
				num = (short)1611005952;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500.HiddenDynamic;
			}
			set
			{
				short num = (short)165085185;
				if (num != 0)
				{
				}
				num = (short)382402560;
				short num2 = num;
				num = (short)547112339;
				short num3 = num;
				num = (short)1762477459;
				switch (num3 == num)
				{
				}
				num = (short)281804800;
				if (num != 0)
				{
				}
				this.radVipKey_A22500.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x006EB7B0 File Offset: 0x006E99B0
		public bool RadVipKey_A22500_HasDiffs
		{
			get
			{
				short num = (short)1533542401;
				if (num != 0)
				{
				}
				num = (short)1051656192;
				short num2 = num;
				num = (short)741285055;
				short num3 = num;
				num = (short)1246698687;
				switch (num3 == num)
				{
				}
				num = (short)322699264;
				if (num != 0)
				{
				}
				return this.radVipKey_A22500._HasDiffs;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x006EB864 File Offset: 0x006E9A64
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x006EB918 File Offset: 0x006E9B18
		public string RadVipName_A22501Value
		{
			get
			{
				short num = (short)507167392;
				short num2 = num;
				num = (short)1940636320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257490944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1025310721;
				if (num != 0)
				{
				}
				num = (short)885915648;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.Value;
			}
			set
			{
				short num = (short)1125341950;
				short num2 = num;
				num = (short)1902074622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234029056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545994240;
				if (num != 0)
				{
				}
				num = (short)1337327617;
				if (num != 0)
				{
				}
				this.radVipName_A22501.Value = value;
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x006EB9CC File Offset: 0x006E9BCC
		public global::AcpBusinessLayer.AcpField<string> RadVipName_A22501
		{
			get
			{
				short num = (short)1512886004;
				short num2 = num;
				num = (short)329502452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1271267328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796669440;
				if (num != 0)
				{
				}
				num = (short)1577123841;
				if (num != 0)
				{
				}
				return this.radVipName_A22501;
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x006EBA7C File Offset: 0x006E9C7C
		// (set) Token: 0x060079DC RID: 31196 RVA: 0x006EBB30 File Offset: 0x006E9D30
		public string RadVipName_A22501_UIValue
		{
			get
			{
				short num = (short)2108294126;
				short num2 = num;
				num = (short)1888420846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)868155392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)96403457;
				if (num != 0)
				{
				}
				num = (short)628621312;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.Value;
			}
			set
			{
				short num = (short)1140220866;
				short num2 = num;
				num = (short)1863738306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608370688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683802625;
				if (num != 0)
				{
				}
				num = (short)2071592960;
				if (num != 0)
				{
				}
				this.radVipName_A22501.Value = value;
			}
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x006EBBE4 File Offset: 0x006E9DE4
		// (set) Token: 0x060079DE RID: 31198 RVA: 0x006EBC98 File Offset: 0x006E9E98
		public bool RadVipName_A22501_Applicable
		{
			get
			{
				short num = (short)2146430634;
				short num2 = num;
				num = (short)350482090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909836288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35586049;
				if (num != 0)
				{
				}
				num = (short)1552023552;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.Applicable;
			}
			set
			{
				short num = (short)1573954679;
				short num2 = num;
				num = (short)1421583479;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1537540096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)738000897;
				if (num != 0)
				{
				}
				num = (short)1545469952;
				if (num != 0)
				{
				}
				this.radVipName_A22501.Applicable = value;
			}
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x006EBD4C File Offset: 0x006E9F4C
		// (set) Token: 0x060079E0 RID: 31200 RVA: 0x006EBE00 File Offset: 0x006EA000
		public bool RadVipName_A22501_Valid
		{
			get
			{
				short num = (short)440308960;
				short num2 = num;
				num = (short)2062390496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603796992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675558913;
				if (num != 0)
				{
				}
				num = (short)2002452480;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.Valid;
			}
			set
			{
				short num = (short)1197080577;
				if (num != 0)
				{
				}
				num = (short)2118516736;
				short num2 = num;
				num = (short)158195046;
				short num3 = num;
				num = (short)1998904678;
				switch (num3 == num)
				{
				}
				num = (short)1637089280;
				if (num != 0)
				{
				}
				this.radVipName_A22501.Valid = value;
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x060079E1 RID: 31201 RVA: 0x006EBEB8 File Offset: 0x006EA0B8
		// (set) Token: 0x060079E2 RID: 31202 RVA: 0x006EBF6C File Offset: 0x006EA16C
		public bool RadVipName_A22501_Visible
		{
			get
			{
				short num = (short)1143632173;
				short num2 = num;
				num = (short)1911517485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720764928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420754945;
				if (num != 0)
				{
				}
				num = (short)568590336;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.Visible;
			}
			set
			{
				short num = (short)276688922;
				short num2 = num;
				num = (short)1385754650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1905197056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2023358465;
				if (num != 0)
				{
				}
				num = (short)1199570944;
				if (num != 0)
				{
				}
				this.radVipName_A22501.Visible = value;
			}
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x006EC024 File Offset: 0x006EA224
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x006EC0D8 File Offset: 0x006EA2D8
		public bool RadVipName_A22501_Editable
		{
			get
			{
				short num = (short)1423243936;
				short num2 = num;
				num = (short)1805449888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282460160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56492032;
				if (num != 0)
				{
				}
				num = (short)556466177;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.Editable;
			}
			set
			{
				short num = (short)1402870947;
				short num2 = num;
				num = (short)1583684771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1613037568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789708800;
				if (num != 0)
				{
				}
				num = (short)2144731137;
				if (num != 0)
				{
				}
				this.radVipName_A22501.Editable = value;
			}
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x006EC190 File Offset: 0x006EA390
		internal string RadVipName_A22501_UILabel
		{
			get
			{
				short num = (short)1863429550;
				short num2 = num;
				num = (short)820817326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685899776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095434240;
				if (num != 0)
				{
				}
				num = (short)1964244993;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.UIName;
			}
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x006EC244 File Offset: 0x006EA444
		// (set) Token: 0x060079E7 RID: 31207 RVA: 0x006EC2FC File Offset: 0x006EA4FC
		internal bool RadVipName_A22501_HiddenStatic
		{
			get
			{
				short num = (short)1556445459;
				short num2 = num;
				num = (short)500267283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)48496640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825753600;
				if (num != 0)
				{
				}
				num = (short)1091567617;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.HiddenStatic;
			}
			set
			{
				short num = (short)530277976;
				short num2 = num;
				num = (short)168060504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733361664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)699138049;
				if (num != 0)
				{
				}
				num = (short)1630011392;
				if (num != 0)
				{
				}
				this.radVipName_A22501.HiddenStatic = value;
			}
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x060079E8 RID: 31208 RVA: 0x006EC3B0 File Offset: 0x006EA5B0
		// (set) Token: 0x060079E9 RID: 31209 RVA: 0x006EC468 File Offset: 0x006EA668
		internal bool RadVipName_A22501_HiddenDynamic
		{
			get
			{
				short num = (short)2111387682;
				short num2 = num;
				num = (short)1081489442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170328064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071855105;
				if (num != 0)
				{
				}
				num = (short)1232797696;
				if (num != 0)
				{
				}
				return this.radVipName_A22501.HiddenDynamic;
			}
			set
			{
				short num = (short)1482817537;
				if (num != 0)
				{
				}
				num = (short)1014824960;
				short num2 = num;
				num = (short)35740948;
				short num3 = num;
				num = (short)163405076;
				switch (num3 == num)
				{
				}
				num = (short)1627914240;
				if (num != 0)
				{
				}
				this.radVipName_A22501.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x006EC51C File Offset: 0x006EA71C
		public bool RadVipName_A22501_HasDiffs
		{
			get
			{
				short num = (short)133909204;
				short num2 = num;
				num = (short)1816611540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)64880640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35192833;
				if (num != 0)
				{
				}
				num = (short)242548736;
				if (num != 0)
				{
				}
				return this.radVipName_A22501._HasDiffs;
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x060079EB RID: 31211 RVA: 0x006EC5CC File Offset: 0x006EA7CC
		// (set) Token: 0x060079EC RID: 31212 RVA: 0x006EC684 File Offset: 0x006EA884
		public int RadVipOutputFeature_A20947Value
		{
			get
			{
				short num = (short)1030972944;
				short num2 = num;
				num = (short)846226960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435879936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2099314688;
				if (num != 0)
				{
				}
				num = (short)1609826305;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.Value;
			}
			set
			{
				short num = (short)424118850;
				short num2 = num;
				num = (short)1564117570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)816578560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655425536;
				if (num != 0)
				{
				}
				num = (short)694943745;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.Value = value;
			}
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x060079ED RID: 31213 RVA: 0x006EC73C File Offset: 0x006EA93C
		// (set) Token: 0x060079EE RID: 31214 RVA: 0x006EC7F0 File Offset: 0x006EA9F0
		public string RadVipOutputFeature_A20947_UIValue
		{
			get
			{
				short num = (short)1383664360;
				short num2 = num;
				num = (short)1431964392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1942618112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)665321473;
				if (num != 0)
				{
				}
				num = (short)2138505216;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.UIValue;
			}
			set
			{
				short num = (short)415418348;
				short num2 = num;
				num = (short)536070124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324679168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1596260353;
				if (num != 0)
				{
				}
				num = (short)1974206464;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.UIValue = value;
			}
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x060079EF RID: 31215 RVA: 0x006EC8A4 File Offset: 0x006EAAA4
		public global::AcpBusinessLayer.AcpListField RadVipOutputFeature_A20947
		{
			get
			{
				short num = (short)1592393729;
				if (num != 0)
				{
				}
				num = (short)1707802624;
				short num2 = num;
				num = (short)155307691;
				short num3 = num;
				num = (short)1117638315;
				switch (num3 == num)
				{
				}
				num = (short)1472856064;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x060079F0 RID: 31216 RVA: 0x006EC950 File Offset: 0x006EAB50
		// (set) Token: 0x060079F1 RID: 31217 RVA: 0x006ECA04 File Offset: 0x006EAC04
		public bool RadVipOutputFeature_A20947_Applicable
		{
			get
			{
				short num = (short)1317293320;
				short num2 = num;
				num = (short)1002196232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988952064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)962527232;
				if (num != 0)
				{
				}
				num = (short)804192257;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.Applicable;
			}
			set
			{
				short num = (short)1309644235;
				short num2 = num;
				num = (short)1006933451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403322368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1475346432;
				if (num != 0)
				{
				}
				num = (short)800849921;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.Applicable = value;
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x060079F2 RID: 31218 RVA: 0x006ECAB8 File Offset: 0x006EACB8
		// (set) Token: 0x060079F3 RID: 31219 RVA: 0x006ECB6C File Offset: 0x006EAD6C
		public bool RadVipOutputFeature_A20947_Valid
		{
			get
			{
				short num = (short)1993539585;
				if (num != 0)
				{
				}
				num = (short)975896576;
				short num2 = num;
				num = (short)1715730714;
				short num3 = num;
				num = (short)211876122;
				switch (num3 == num)
				{
				}
				num = (short)1352400896;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.Valid;
			}
			set
			{
				short num = (short)1049127112;
				short num2 = num;
				num = (short)641624264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555548672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847066624;
				if (num != 0)
				{
				}
				num = (short)1465122817;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.Valid = value;
			}
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x006ECC20 File Offset: 0x006EAE20
		// (set) Token: 0x060079F5 RID: 31221 RVA: 0x006ECCD4 File Offset: 0x006EAED4
		public bool RadVipOutputFeature_A20947_Visible
		{
			get
			{
				short num = (short)465565614;
				short num2 = num;
				num = (short)722794414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1652621312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1393950721;
				if (num != 0)
				{
				}
				num = (short)1733296128;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.Visible;
			}
			set
			{
				short num = (short)601473156;
				short num2 = num;
				num = (short)1371521156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974272000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32571393;
				if (num != 0)
				{
				}
				num = (short)2099118080;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.Visible = value;
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x060079F6 RID: 31222 RVA: 0x006ECD88 File Offset: 0x006EAF88
		// (set) Token: 0x060079F7 RID: 31223 RVA: 0x006ECE3C File Offset: 0x006EB03C
		public bool RadVipOutputFeature_A20947_Editable
		{
			get
			{
				short num = (short)1907791003;
				short num2 = num;
				num = (short)894473371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198718976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)26148864;
				if (num != 0)
				{
				}
				num = (short)2113470465;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.Editable;
			}
			set
			{
				short num = (short)1792658327;
				short num2 = num;
				num = (short)2116144023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)140771328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056585216;
				if (num != 0)
				{
				}
				num = (short)1032912897;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.Editable = value;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x060079F8 RID: 31224 RVA: 0x006ECEF4 File Offset: 0x006EB0F4
		internal string RadVipOutputFeature_A20947_UILabel
		{
			get
			{
				short num = (short)698754488;
				short num2 = num;
				num = (short)387065272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244449280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957232641;
				if (num != 0)
				{
				}
				num = (short)721027072;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.UIName;
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x060079F9 RID: 31225 RVA: 0x006ECFAC File Offset: 0x006EB1AC
		// (set) Token: 0x060079FA RID: 31226 RVA: 0x006ED060 File Offset: 0x006EB260
		internal bool RadVipOutputFeature_A20947_HiddenStatic
		{
			get
			{
				short num = (short)557753113;
				short num2 = num;
				num = (short)563061529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494206976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355729409;
				if (num != 0)
				{
				}
				num = (short)1060372480;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.HiddenStatic;
			}
			set
			{
				short num = (short)1124793397;
				short num2 = num;
				num = (short)169278517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709165056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)823853057;
				if (num != 0)
				{
				}
				num = (short)1051066368;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.HiddenStatic = value;
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x006ED114 File Offset: 0x006EB314
		// (set) Token: 0x060079FC RID: 31228 RVA: 0x006ED1C8 File Offset: 0x006EB3C8
		internal bool RadVipOutputFeature_A20947_HiddenDynamic
		{
			get
			{
				short num = (short)635437057;
				if (num != 0)
				{
				}
				num = (short)459735040;
				short num2 = num;
				num = (short)1724860240;
				short num3 = num;
				num = (short)918243152;
				switch (num3 == num)
				{
				}
				num = (short)557383680;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947.HiddenDynamic;
			}
			set
			{
				short num = (short)1606923461;
				short num2 = num;
				num = (short)1422533;
				switch (num2 == num)
				{
				}
				num = (short)1348337664;
				short num3 = num;
				num = (short)1474428928;
				if (num != 0)
				{
				}
				num = (short)1415446529;
				if (num != 0)
				{
				}
				this.radVipOutputFeature_A20947.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x006ED27C File Offset: 0x006EB47C
		public bool RadVipOutputFeature_A20947_HasDiffs
		{
			get
			{
				short num = (short)1705686915;
				short num2 = num;
				num = (short)1829156739;
				switch (num2 == num)
				{
				}
				num = (short)2047672320;
				short num3 = num;
				num = (short)2043805697;
				if (num != 0)
				{
				}
				num = (short)92798976;
				if (num != 0)
				{
				}
				return this.radVipOutputFeature_A20947._HasDiffs;
			}
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x060079FE RID: 31230 RVA: 0x006ED330 File Offset: 0x006EB530
		// (set) Token: 0x060079FF RID: 31231 RVA: 0x006ED3E4 File Offset: 0x006EB5E4
		public int RadioVIPShortPressTimeValue
		{
			get
			{
				short num = (short)533163963;
				short num2 = num;
				num = (short)442593211;
				switch (num2 == num)
				{
				}
				num = (short)1392115712;
				short num3 = num;
				num = (short)1691156481;
				if (num != 0)
				{
				}
				num = (short)424869888;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Value;
			}
			set
			{
				short num = (short)67774505;
				short num2 = num;
				num = (short)364849193;
				switch (num2 == num)
				{
				}
				num = (short)863567872;
				short num3 = num;
				num = (short)1938751489;
				if (num != 0)
				{
				}
				num = (short)80936960;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Value = value;
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x006ED498 File Offset: 0x006EB698
		// (set) Token: 0x06007A01 RID: 31233 RVA: 0x006ED54C File Offset: 0x006EB74C
		public string RadioVIPShortPressTime_UIValue
		{
			get
			{
				short num = (short)565621096;
				short num2 = num;
				num = (short)254521704;
				switch (num2 == num)
				{
				}
				num = (short)1359216640;
				short num3 = num;
				num = (short)2110455809;
				if (num != 0)
				{
				}
				num = (short)1744175104;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.UIValue;
			}
			set
			{
				short num = (short)1807388434;
				short num2 = num;
				num = (short)1495174930;
				switch (num2 == num)
				{
				}
				num = (short)2021457920;
				short num3 = num;
				num = (short)233701377;
				if (num != 0)
				{
				}
				num = (short)1718616064;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x006ED600 File Offset: 0x006EB800
		public global::AcpBusinessLayer.AcpSimpleRangeField RadioVIPShortPressTime
		{
			get
			{
				short num = (short)190372574;
				short num2 = num;
				num = (short)1116527326;
				switch (num2 == num)
				{
				}
				num = (short)21430272;
				short num3 = num;
				num = (short)1582891009;
				if (num != 0)
				{
				}
				num = (short)1779957760;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime;
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x06007A03 RID: 31235 RVA: 0x006ED6B0 File Offset: 0x006EB8B0
		// (set) Token: 0x06007A04 RID: 31236 RVA: 0x006ED768 File Offset: 0x006EB968
		internal int RadioVIPShortPressTimeMin
		{
			get
			{
				short num = (short)962723841;
				if (num != 0)
				{
				}
				num = (short)581916767;
				short num2 = num;
				num = (short)992106591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364380160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2039873536;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Min;
			}
			set
			{
				short num = (short)725289139;
				short num2 = num;
				num = (short)1493567667;
				switch (num2 == num)
				{
				}
				num = (short)1080557568;
				short num3 = num;
				num = (short)778960897;
				if (num != 0)
				{
				}
				num = (short)2060124160;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Min = value;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x06007A05 RID: 31237 RVA: 0x006ED81C File Offset: 0x006EBA1C
		// (set) Token: 0x06007A06 RID: 31238 RVA: 0x006ED8D4 File Offset: 0x006EBAD4
		internal int RadioVIPShortPressTimeMax
		{
			get
			{
				short num = (short)518156941;
				short num2 = num;
				num = (short)1829991053;
				switch (num2 == num)
				{
				}
				num = (short)1109196800;
				short num3 = num;
				num = (short)1105461248;
				if (num != 0)
				{
				}
				num = (short)595001345;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Max;
			}
			set
			{
				short num = (short)659535930;
				short num2 = num;
				num = (short)1326037050;
				switch (num2 == num)
				{
				}
				num = (short)692912128;
				short num3 = num;
				num = (short)1379532801;
				if (num != 0)
				{
				}
				num = (short)500236288;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Max = value;
			}
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x006ED988 File Offset: 0x006EBB88
		// (set) Token: 0x06007A08 RID: 31240 RVA: 0x006EDA3C File Offset: 0x006EBC3C
		internal int RadioVIPShortPressTimeStep
		{
			get
			{
				short num = (short)617430405;
				short num2 = num;
				num = (short)275398021;
				switch (num2 == num)
				{
				}
				num = (short)422641664;
				short num3 = num;
				num = (short)634126337;
				if (num != 0)
				{
				}
				num = (short)198180864;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.StepSize;
			}
			set
			{
				short num = (short)996573680;
				short num2 = num;
				num = (short)1641054704;
				switch (num2 == num)
				{
				}
				num = (short)1321467904;
				short num3 = num;
				num = (short)1545142272;
				if (num != 0)
				{
				}
				num = (short)1249640449;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.StepSize = value;
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x06007A09 RID: 31241 RVA: 0x006EDAF0 File Offset: 0x006EBCF0
		// (set) Token: 0x06007A0A RID: 31242 RVA: 0x006EDBA4 File Offset: 0x006EBDA4
		public bool RadioVIPShortPressTime_Applicable
		{
			get
			{
				short num = (short)1258618881;
				if (num != 0)
				{
				}
				num = (short)2024596129;
				short num2 = num;
				num = (short)731767457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1910505472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1308557312;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Applicable;
			}
			set
			{
				short num = (short)1594626507;
				short num2 = num;
				num = (short)1559105995;
				switch (num2 == num)
				{
				}
				num = (short)334954496;
				short num3 = num;
				num = (short)955514880;
				if (num != 0)
				{
				}
				num = (short)1081278465;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x06007A0B RID: 31243 RVA: 0x006EDC58 File Offset: 0x006EBE58
		// (set) Token: 0x06007A0C RID: 31244 RVA: 0x006EDD08 File Offset: 0x006EBF08
		public bool RadioVIPShortPressTime_Valid
		{
			get
			{
				short num = (short)1005906808;
				short num2 = num;
				num = (short)63957880;
				switch (num2 == num)
				{
				}
				num = (short)1118175232;
				short num3 = num;
				num = (short)661258241;
				if (num != 0)
				{
				}
				num = (short)1216675840;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Valid;
			}
			set
			{
				short num = (short)1688318631;
				short num2 = num;
				num = (short)752136871;
				switch (num2 == num)
				{
				}
				num = (short)64421888;
				short num3 = num;
				num = (short)716701696;
				if (num != 0)
				{
				}
				num = (short)587661313;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Valid = value;
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x06007A0D RID: 31245 RVA: 0x006EDDBC File Offset: 0x006EBFBC
		// (set) Token: 0x06007A0E RID: 31246 RVA: 0x006EDE70 File Offset: 0x006EC070
		public bool RadioVIPShortPressTime_Visible
		{
			get
			{
				short num = (short)1782308739;
				short num2 = num;
				num = (short)888528771;
				switch (num2 == num)
				{
				}
				num = (short)1926627328;
				short num3 = num;
				num = (short)1368653825;
				if (num != 0)
				{
				}
				num = (short)2040528896;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Visible;
			}
			set
			{
				short num = (short)1663537788;
				short num2 = num;
				num = (short)1074303612;
				switch (num2 == num)
				{
				}
				num = (short)1772879872;
				short num3 = num;
				num = (short)1482817537;
				if (num != 0)
				{
				}
				num = (short)1577451520;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Visible = value;
			}
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x06007A0F RID: 31247 RVA: 0x006EDF24 File Offset: 0x006EC124
		// (set) Token: 0x06007A10 RID: 31248 RVA: 0x006EDFD8 File Offset: 0x006EC1D8
		public bool RadioVIPShortPressTime_Editable
		{
			get
			{
				short num = (short)1415643137;
				if (num != 0)
				{
				}
				num = (short)606058424;
				short num2 = num;
				num = (short)1544009656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)688062464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2034761728;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.Editable;
			}
			set
			{
				short num = (short)39621393;
				short num2 = num;
				num = (short)1261736721;
				switch (num2 == num)
				{
				}
				num = (short)518651904;
				short num3 = num;
				num = (short)1392181249;
				if (num != 0)
				{
				}
				num = (short)2038235136;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.Editable = value;
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x06007A11 RID: 31249 RVA: 0x006EE08C File Offset: 0x006EC28C
		internal string RadioVIPShortPressTime_UILabel
		{
			get
			{
				short num = (short)1797914697;
				short num2 = num;
				num = (short)628490313;
				switch (num2 == num)
				{
				}
				num = (short)315359232;
				short num3 = num;
				num = (short)1208090624;
				if (num != 0)
				{
				}
				num = (short)568918017;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.UIName;
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x06007A12 RID: 31250 RVA: 0x006EE144 File Offset: 0x006EC344
		// (set) Token: 0x06007A13 RID: 31251 RVA: 0x006EE1F8 File Offset: 0x006EC3F8
		internal bool RadioVIPShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1548793574;
				short num2 = num;
				num = (short)2018686694;
				switch (num2 == num)
				{
				}
				num = (short)802357248;
				short num3 = num;
				num = (short)1173749761;
				if (num != 0)
				{
				}
				num = (short)1829502976;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)798346743;
				short num2 = num;
				num = (short)49663479;
				switch (num2 == num)
				{
				}
				num = (short)1524170752;
				short num3 = num;
				num = (short)1612709889;
				if (num != 0)
				{
				}
				num = (short)213057536;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x06007A14 RID: 31252 RVA: 0x006EE2AC File Offset: 0x006EC4AC
		// (set) Token: 0x06007A15 RID: 31253 RVA: 0x006EE364 File Offset: 0x006EC564
		internal bool RadioVIPShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1302984079;
				short num2 = num;
				num = (short)24901007;
				switch (num2 == num)
				{
				}
				num = (short)803274752;
				short num3 = num;
				num = (short)230293505;
				if (num != 0)
				{
				}
				num = (short)69009408;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)2066889646;
				short num2 = num;
				num = (short)1307851694;
				switch (num2 == num)
				{
				}
				num = (short)1846083584;
				short num3 = num;
				num = (short)828964864;
				if (num != 0)
				{
				}
				num = (short)1471873025;
				if (num != 0)
				{
				}
				this.radioVIPShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x006EE41C File Offset: 0x006EC61C
		public bool RadioVIPShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)803314994;
				short num2 = num;
				num = (short)1600167218;
				switch (num2 == num)
				{
				}
				num = (short)572653568;
				short num3 = num;
				num = (short)1694498817;
				if (num != 0)
				{
				}
				num = (short)1448148992;
				if (num != 0)
				{
				}
				return this.radioVIPShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x06007A17 RID: 31255 RVA: 0x006EE4D0 File Offset: 0x006EC6D0
		// (set) Token: 0x06007A18 RID: 31256 RVA: 0x006EE584 File Offset: 0x006EC784
		public int RadioVIPLongPressTimeValue
		{
			get
			{
				short num = (short)2049907938;
				short num2 = num;
				num = (short)1979129058;
				switch (num2 == num)
				{
				}
				num = (short)1403715584;
				short num3 = num;
				num = (short)215810048;
				if (num != 0)
				{
				}
				num = (short)155844609;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.Value;
			}
			set
			{
				short num = (short)2135415953;
				short num2 = num;
				num = (short)743955601;
				switch (num2 == num)
				{
				}
				num = (short)2070740992;
				short num3 = num;
				num = (short)1125515264;
				if (num != 0)
				{
				}
				num = (short)983041;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.Value = value;
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x06007A19 RID: 31257 RVA: 0x006EE638 File Offset: 0x006EC838
		// (set) Token: 0x06007A1A RID: 31258 RVA: 0x006EE6EC File Offset: 0x006EC8EC
		public string RadioVIPLongPressTime_UIValue
		{
			get
			{
				short num = (short)1667769475;
				short num2 = num;
				num = (short)1025582211;
				switch (num2 == num)
				{
				}
				num = (short)1034354688;
				short num3 = num;
				num = (short)1384120320;
				if (num != 0)
				{
				}
				num = (short)1155399681;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.UIValue;
			}
			set
			{
				short num = (short)2107626727;
				short num2 = num;
				num = (short)818992359;
				switch (num2 == num)
				{
				}
				num = (short)66912256;
				short num3 = num;
				num = (short)411107329;
				if (num != 0)
				{
				}
				num = (short)1572667392;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x006EE7A4 File Offset: 0x006EC9A4
		public global::AcpBusinessLayer.AcpCustomRangeField RadioVIPLongPressTime
		{
			get
			{
				short num = (short)385317258;
				short num2 = num;
				num = (short)341342602;
				switch (num2 == num)
				{
				}
				num = (short)2103771136;
				short num3 = num;
				num = (short)547028993;
				if (num != 0)
				{
				}
				num = (short)1953628160;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime;
			}
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x06007A1C RID: 31260 RVA: 0x006EE854 File Offset: 0x006ECA54
		// (set) Token: 0x06007A1D RID: 31261 RVA: 0x006EE90C File Offset: 0x006ECB0C
		public bool RadioVIPLongPressTime_Applicable
		{
			get
			{
				short num = (short)1922150777;
				short num2 = num;
				num = (short)17215865;
				switch (num2 == num)
				{
				}
				num = (short)1761083392;
				short num3 = num;
				num = (short)792788993;
				if (num != 0)
				{
				}
				num = (short)668794880;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.Applicable;
			}
			set
			{
				short num = (short)533606850;
				short num2 = num;
				num = (short)666513858;
				switch (num2 == num)
				{
				}
				num = (short)1387200512;
				short num3 = num;
				num = (short)776142848;
				if (num != 0)
				{
				}
				num = (short)1190592513;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x06007A1E RID: 31262 RVA: 0x006EE9C4 File Offset: 0x006ECBC4
		// (set) Token: 0x06007A1F RID: 31263 RVA: 0x006EEA78 File Offset: 0x006ECC78
		public bool RadioVIPLongPressTime_Valid
		{
			get
			{
				short num = (short)1193652627;
				short num2 = num;
				num = (short)105034131;
				switch (num2 == num)
				{
				}
				num = (short)1979449344;
				short num3 = num;
				num = (short)644218880;
				if (num != 0)
				{
				}
				num = (short)952041473;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.Valid;
			}
			set
			{
				short num = (short)1082687646;
				short num2 = num;
				num = (short)483819678;
				switch (num2 == num)
				{
				}
				num = (short)153419776;
				short num3 = num;
				num = (short)2138046464;
				if (num != 0)
				{
				}
				num = (short)1804992513;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.Valid = value;
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x06007A20 RID: 31264 RVA: 0x006EEB2C File Offset: 0x006ECD2C
		// (set) Token: 0x06007A21 RID: 31265 RVA: 0x006EEBE0 File Offset: 0x006ECDE0
		public bool RadioVIPLongPressTime_Visible
		{
			get
			{
				short num = (short)962063704;
				short num2 = num;
				num = (short)2072702296;
				switch (num2 == num)
				{
				}
				num = (short)1109786624;
				short num3 = num;
				num = (short)150339585;
				if (num != 0)
				{
				}
				num = (short)863109120;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.Visible;
			}
			set
			{
				short num = (short)1627792043;
				short num2 = num;
				num = (short)173220523;
				switch (num2 == num)
				{
				}
				num = (short)1820393472;
				short num3 = num;
				num = (short)1617428481;
				if (num != 0)
				{
				}
				num = (short)2105147392;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.Visible = value;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x006EEC98 File Offset: 0x006ECE98
		// (set) Token: 0x06007A23 RID: 31267 RVA: 0x006EED50 File Offset: 0x006ECF50
		public bool RadioVIPLongPressTime_Editable
		{
			get
			{
				short num = (short)1803072680;
				short num2 = num;
				num = (short)1428206760;
				switch (num2 == num)
				{
				}
				num = (short)1344929792;
				short num3 = num;
				num = (short)124649473;
				if (num != 0)
				{
				}
				num = (short)1156186112;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.Editable;
			}
			set
			{
				short num = (short)1692859184;
				short num2 = num;
				num = (short)2090728240;
				switch (num2 == num)
				{
				}
				num = (short)517931008;
				short num3 = num;
				num = (short)612237313;
				if (num != 0)
				{
				}
				num = (short)1394343936;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.Editable = value;
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x06007A24 RID: 31268 RVA: 0x006EEE08 File Offset: 0x006ED008
		internal string RadioVIPLongPressTime_UILabel
		{
			get
			{
				short num = (short)332607497;
				short num2 = num;
				num = (short)89862153;
				switch (num2 == num)
				{
				}
				num = (short)730660864;
				short num3 = num;
				num = (short)692977664;
				if (num != 0)
				{
				}
				num = (short)1326252033;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.UIName;
			}
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x06007A25 RID: 31269 RVA: 0x006EEEC0 File Offset: 0x006ED0C0
		// (set) Token: 0x06007A26 RID: 31270 RVA: 0x006EEF78 File Offset: 0x006ED178
		internal bool RadioVIPLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1808691084;
				short num2 = num;
				num = (short)10252172;
				switch (num2 == num)
				{
				}
				num = (short)415301632;
				short num3 = num;
				num = (short)64946177;
				if (num != 0)
				{
				}
				num = (short)1881407488;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1018807799;
				short num2 = num;
				num = (short)1064682999;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889061376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1824980992;
				if (num != 0)
				{
				}
				num = (short)992870401;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x06007A27 RID: 31271 RVA: 0x006EF02C File Offset: 0x006ED22C
		// (set) Token: 0x06007A28 RID: 31272 RVA: 0x006EF0E0 File Offset: 0x006ED2E0
		internal bool RadioVIPLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1288952443;
				short num2 = num;
				num = (short)1188027003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97255424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1723465728;
				if (num != 0)
				{
				}
				num = (short)351928321;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)648666512;
				short num2 = num;
				num = (short)870702480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)239009792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)421003265;
				if (num != 0)
				{
				}
				num = (short)595329024;
				if (num != 0)
				{
				}
				this.radioVIPLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x06007A29 RID: 31273 RVA: 0x006EF198 File Offset: 0x006ED398
		public bool RadioVIPLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)1719778197;
				short num2 = num;
				num = (short)513915797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892600320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554448385;
				if (num != 0)
				{
				}
				num = (short)1709703168;
				if (num != 0)
				{
				}
				return this.radioVIPLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x006EF24C File Offset: 0x006ED44C
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK RefDEK
		{
			get
			{
				short num = (short)653846231;
				short num2 = num;
				num = (short)1194387159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)201129984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)178716673;
				if (num != 0)
				{
				}
				num = (short)213188608;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2129)[0] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK;
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x06007A2B RID: 31275 RVA: 0x006EF30C File Offset: 0x006ED50C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1686574349;
				short num2 = num;
				num = (short)1199379725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1288110080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269680641;
				if (num != 0)
				{
				}
				num = (short)133431296;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x06007A2C RID: 31276 RVA: 0x006EF3C8 File Offset: 0x006ED5C8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)843099832;
				short num2 = num;
				num = (short)1332719288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)387842048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1313079297;
				if (num != 0)
				{
				}
				num = (short)154796032;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x06007A2D RID: 31277 RVA: 0x006EF488 File Offset: 0x006ED688
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1780656419;
				short num2 = num;
				num = (short)220178723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1312030720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)706478081;
				if (num != 0)
				{
				}
				num = (short)858193920;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x06007A2E RID: 31278 RVA: 0x006EF548 File Offset: 0x006ED748
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)1468661761;
				if (num != 0)
				{
				}
				num = (short)1107558400;
				short num2 = num;
				num = (short)164501743;
				short num3 = num;
				num = (short)1678383343;
				switch (num3 == num)
				{
				}
				num = (short)2106195968;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x006EF608 File Offset: 0x006ED808
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_BE;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1994212917;
				short num2 = num;
				num = (short)1612138037;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FB;
				case 1:
					break;
				default:
				{
					num = (short)1983053824;
					short num3 = num;
					break;
				}
				}
				num = (short)345702401;
				if (num != 0)
				{
				}
				num = (short)616431616;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					num = (short)1199046659;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)944504832;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)317128708;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					goto IL_FB;
				}
				goto IL_BE;
				IL_FB:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num = (short)465895426;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_BE:
			result = null;
			num = (short)969277441;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400335B RID: 13147
		private global::AcpBusinessLayer.AcpListField radVipOutputBCO_A20946;

		// Token: 0x0400335C RID: 13148
		private global::AcpBusinessLayer.AcpListField radVipInputBCO_A21328;

		// Token: 0x0400335D RID: 13149
		private global::AcpBusinessLayer.AcpListField radVipInputFeature_A21329;

		// Token: 0x0400335E RID: 13150
		private global::AcpBusinessLayer.AcpKeyField radVipKey_A22500;

		// Token: 0x0400335F RID: 13151
		private global::AcpBusinessLayer.AcpField<string> radVipName_A22501;

		// Token: 0x04003360 RID: 13152
		private global::AcpBusinessLayer.AcpListField radVipOutputFeature_A20947;

		// Token: 0x04003361 RID: 13153
		private global::AcpBusinessLayer.AcpSimpleRangeField radioVIPShortPressTime;

		// Token: 0x04003362 RID: 13154
		private global::AcpBusinessLayer.AcpCustomRangeField radioVIPLongPressTime;
	}
}
