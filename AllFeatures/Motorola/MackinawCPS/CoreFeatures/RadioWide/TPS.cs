using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000186 RID: 390
	[global::System.Serializable]
	public class TPS : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003EEF RID: 16111 RVA: 0x003B46BC File Offset: 0x003B28BC
		public TPS(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x003B46D8 File Offset: 0x003B28D8
		protected TPS(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x003B46F0 File Offset: 0x003B28F0
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1438790176;
			short num2 = num;
			num = (short)1518744096;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1123549184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1569783808;
			if (num != 0)
			{
			}
			num = (short)1247019009;
			if (num != 0)
			{
			}
			this.radWideTPSAudibleEmergencyBeaconsec_A7502 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓韕귗뻙뗛볝賟蟡ꇣ该跧飩诫语黯釱跳듵鷷鯹鿻釽滿焁愃攅圇䬉㬋㬍‏‑", a_), global::CommonResources.AcgResources.ID_AUDIBLEEMERGENCYBEACONSEC, 0, 255, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.radWideTPSAudibleEmergencyBeaconsec_A7502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSAudibleEmergencyBeaconsec_A7502.DataTransferOrder = 76;
			this.radWideTPSAudibleEmergencyBeaconsec_A7502.ShowHexValue = false;
			this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧꿩臫语苯闱釳飵鯷菹뷻鋽懿瀁椃吅洇縉縋眍䈏猑怓猕欗缙缛䄝感ᔡᴣᐥᄧ", a_), global::CommonResources.AcgResources.ID_EMERGENCYALARMRETRYRATESEC, 4, 64, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.DataTransferOrder = 81;
			this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.ShowHexValue = false;
			this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧꿩臫语苯闱釳飵鯷菹뿻鿽泿渁䀃挅指漉甋崍礏瘑焓戕眗琙礛䄝感ᔡᴣᔥḧ", a_), global::CommonResources.AcgResources.ID_EMERGENCYCALLDEKEYSIDETONE);
			this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.DataTransferOrder = 23;
			this.radWideTPSFiregroundVoiceTxEndTone_A9655 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧볩菫蟭鏯韱ꃳ軵뷷铹飻꫽濿氁愃夅䤇㌉㨋㬍┏", a_), global::CommonResources.AcgResources.ID_VOICETXENDTONE);
			this.radWideTPSFiregroundVoiceTxEndTone_A9655.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundVoiceTxEndTone_A9655.DataTransferOrder = 43;
			this.radWideTPSEmergencyPTTTransmission_A41544 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideTPSEmergencyPTTTransmission_A41544LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideTPSEmergencyPTTTransmission_A41544LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓鏕뗗뿙껛망藟賡蟣鿥룧뻩룫뫭苯鏱髳藵闷鏹迻跽槿洁樃夅䤇㸉㴋㬍␏☑", a_), global::CommonResources.AcgResources.ID_TPSEMERGENCYPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSEmergencyPTTTransmission_A41544LovStrs);
			this.radWideTPSEmergencyPTTTransmission_A41544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSEmergencyPTTTransmission_A41544.DataTransferOrder = 22;
			this.radWideTPSPTTTransmission_A41545 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideTPSPTTTransmission_A41545LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideTPSPTTTransmission_A41545LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓蛕賗軙裛곝臟賡韣该臧駩鿫蟭鿯鳱꯳럵쳷쯹짻쫽㗿", a_), global::CommonResources.AcgResources.ID_TPSPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSPTTTransmission_A41545LovStrs);
			this.radWideTPSPTTTransmission_A41545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSPTTTransmission_A41545.DataTransferOrder = 46;
			this.radWideTPSAudibleEmergencyBeaconRouting_A41972 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓韕귗뻙뗛볝賟蟡ꇣ该跧飩诫语黯釱跳듵鷷鯹鿻釽滿倁欃猅簇按戋植伏匑–✕℗ⴙ⸛", a_), global::CommonResources.AcgResources.ID_AUDIBLEEMERGENCYBEACONROUTING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSAudibleEmergencyBeaconRouting_A41972LovStrs);
			this.radWideTPSAudibleEmergencyBeaconRouting_A41972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSAudibleEmergencyBeaconRouting_A41972.DataTransferOrder = 83;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雁ꗃꗅ볇ꏉ꿋꿍볏蓓ꏕ뫗뛙뗛뷝샟뇡藣胥跧黩闫", a_);
			base.Id = 10749;
			base.UIName = global::CommonResources.AcgResources.ID_TACTICALPUBLICSAFETY;
			base.DataTransferOrder = 17;
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x003B49C0 File Offset: 0x003B2BC0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)205979657;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓韕귗뻙뗛볝賟蟡ꇣ该跧飩诫语黯釱跳듵鷷鯹鿻釽滿倁欃猅簇按戋植伏匑–✕℗ⴙ⸛", a_)))
					{
						num = (short)124321812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64D;
				case 1:
					num = (short)1631584278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧꿩臫语苯闱釳飵鯷菹뷻鋽懿瀁椃吅洇縉縋眍䈏猑怓猕欗缙缛䄝感ᔡᴣᐥᄧ", a_)))
					{
						num = (short)1061421067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_564;
				case 3:
					goto IL_42C;
				case 4:
					goto IL_479;
				case 5:
					num = (short)67043329;
					if (num != 0)
					{
					}
					this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧꿩臫语苯闱釳飵鯷菹뿻鿽泿渁䀃挅指漉甋崍礏瘑焓戕眗琙礛䄝感ᔡᴣᔥḧ", a_), global::CommonResources.AcgResources.ID_EMERGENCYCALLDEKEYSIDETONE);
					this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.DataTransferOrder = 23;
					num = (short)86310928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.radWideTPSEmergencyPTTTransmission_A41544 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideTPSEmergencyPTTTransmission_A41544LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideTPSEmergencyPTTTransmission_A41544LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓鏕뗗뿙껛망藟賡蟣鿥룧뻩룫뫭苯鏱髳藵闷鏹迻跽槿洁樃夅䤇㸉㴋㬍␏☑", a_), global::CommonResources.AcgResources.ID_TPSEMERGENCYPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSEmergencyPTTTransmission_A41544LovStrs);
					this.radWideTPSEmergencyPTTTransmission_A41544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSEmergencyPTTTransmission_A41544.DataTransferOrder = 22;
					num = (short)1378091012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)987758600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields != null)
					{
						num = (short)1994194945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64D;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 10:
					goto IL_564;
				case 11:
					this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = new global::AcpBusinessLayer.AcpSimpleRangeField(4, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧꿩臫语苯闱釳飵鯷菹뷻鋽懿瀁椃吅洇縉縋眍䈏猑怓猕欗缙缛䄝感ᔡᴣᐥᄧ", a_), global::CommonResources.AcgResources.ID_EMERGENCYALARMRETRYRATESEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.DataTransferOrder = 81;
					this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.ShowHexValue = false;
					num = (short)1670774794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧볩菫蟭鏯韱ꃳ軵뷷铹飻꫽濿氁愃夅䤇㌉㨋㬍┏", a_)))
					{
						goto IL_630;
					}
					goto IL_2E0;
				case 13:
					this.radWideTPSAudibleEmergencyBeaconsec_A7502 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓韕귗뻙뗛볝賟蟡ꇣ该跧飩诫语黯釱跳듵鷷鯹鿻釽滿焁愃攅圇䬉㬋㬍‏‑", a_), global::CommonResources.AcgResources.ID_AUDIBLEEMERGENCYBEACONSEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
					this.radWideTPSAudibleEmergencyBeaconsec_A7502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSAudibleEmergencyBeaconsec_A7502.DataTransferOrder = 76;
					this.radWideTPSAudibleEmergencyBeaconsec_A7502.ShowHexValue = false;
					num = (short)1463615503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓鏕뗗뿙껛망藟賡蟣鿥룧뻩룫뫭苯鏱髳藵闷鏹迻跽槿洁樃夅䤇㸉㴋㬍␏☑", a_)))
					{
						num = (short)315293702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_479;
				case 15:
					goto IL_3DE;
				case 16:
					goto IL_600;
				case 17:
					goto IL_384;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓蛕賗軙裛곝臟賡韣该臧駩鿫蟭鿯鳱꯳럵쳷쯹짻쫽㗿", a_)))
					{
						num = (short)1243807763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42C;
				case 19:
					this.radWideTPSPTTTransmission_A41545 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideTPSPTTTransmission_A41545LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideTPSPTTTransmission_A41545LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓蛕賗軙裛곝臟賡韣该臧駩鿫蟭鿯鳱꯳럵쳷쯹짻쫽㗿", a_), global::CommonResources.AcgResources.ID_TPSPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSPTTTransmission_A41545LovStrs);
					this.radWideTPSPTTTransmission_A41545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSPTTTransmission_A41545.DataTransferOrder = 46;
					num = (short)571670531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.radWideTPSAudibleEmergencyBeaconRouting_A41972 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓韕귗뻙뗛볝賟蟡ꇣ该跧飩诫语黯釱跳듵鷷鯹鿻釽滿倁欃猅簇按戋植伏匑–✕℗ⴙ⸛", a_), global::CommonResources.AcgResources.ID_AUDIBLEEMERGENCYBEACONROUTING, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSAudibleEmergencyBeaconRouting_A41972LovStrs);
					this.radWideTPSAudibleEmergencyBeaconRouting_A41972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSAudibleEmergencyBeaconRouting_A41972.DataTransferOrder = 83;
					num = (short)1911881745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_2E0;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓韕귗뻙뗛볝賟蟡ꇣ该跧飩诫语黯釱跳듵鷷鯹鿻釽滿焁愃攅圇䬉㬋㬍‏‑", a_)))
					{
						num = (short)1379991565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DE;
				case 23:
				{
					this.radWideTPSFiregroundVoiceTxEndTone_A9655 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧볩菫蟭鏯韱ꃳ軵뷷铹飻꫽濿氁愃夅䤇㌉㨋㬍┏", a_), global::CommonResources.AcgResources.ID_VOICETXENDTONE);
					this.radWideTPSFiregroundVoiceTxEndTone_A9655.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundVoiceTxEndTone_A9655.DataTransferOrder = 43;
					num = (short)1128475491;
					short num3 = num;
					num = (short)496511843;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_630;
					default:
						num = (short)21692416;
						if (num != 0)
						{
						}
						num = (short)1220608021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ鿇ꏉ꣋ꯍ蓏苑蟓郕뇗꣙맛망鋟跡釣裥賧꿩臫语苯闱釳飵鯷菹뿻鿽泿渁䀃挅指漉甋崍礏瘑焓戕眗琙礛䄝感ᔡᴣᔥḧ", a_)))
					{
						num = (short)336330757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_600;
				}
				IL_91:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2074804231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2E0:
				num = (short)666894350;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3DE:
				num = (short)827588610;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_42C:
				num = (short)2005139456;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_479:
				num = (short)629669906;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_564:
				num = (short)114294784;
				short num4 = num;
				num = (short)1793130520;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_600:
				num = (short)68157452;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_630:
				num = (short)451280919;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_384:
			IL_64D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雁ꗃꗅ볇ꏉ꿋꿍볏蓓ꏕ뫗뛙뗛뷝샟뇡藣胥跧黩闫", a_);
			base.Id = 10749;
			base.UIName = global::CommonResources.AcgResources.ID_TACTICALPUBLICSAFETY;
			base.DataTransferOrder = 17;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x003B504C File Offset: 0x003B324C
		public override void PopulateReferences()
		{
			short num = (short)1471873024;
			short num2 = num;
			num = (short)1769996289;
			if (num != 0)
			{
			}
			num = (short)802802480;
			short num3 = num;
			num = (short)2077018928;
			switch (num3 == num)
			{
			}
			num = (short)580714496;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x003B50F8 File Offset: 0x003B32F8
		public override void DropReferences()
		{
			short num = (short)1503068160;
			short num2 = num;
			num = (short)2062833093;
			short num3 = num;
			num = (short)803689925;
			switch (num3 == num)
			{
			}
			num = (short)345505793;
			if (num != 0)
			{
			}
			num = (short)764149760;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x003B51A0 File Offset: 0x003B33A0
		public override void SetConstraints()
		{
			short num = (short)352387072;
			short num2 = num;
			num = (short)2088022471;
			short num3 = num;
			num = (short)1536274887;
			switch (num3 == num)
			{
			}
			num = (short)727711744;
			if (num != 0)
			{
			}
			num = (short)435486721;
			if (num != 0)
			{
			}
			this.radWideTPSAudibleEmergencyBeaconRouting_A41972.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAudibleEmergencyBeaconRoutingApplicable);
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x003B525C File Offset: 0x003B345C
		public override void SetupDependencies()
		{
			short num = (short)1282932736;
			short num2 = num;
			num = (short)1527371053;
			short num3 = num;
			num = (short)19846445;
			switch (num3 == num)
			{
			}
			num = (short)900333568;
			if (num != 0)
			{
			}
			num = (short)1843462145;
			if (num != 0)
			{
			}
			this.radWideTPSAudibleEmergencyBeaconsec_A7502.AddDependentObject(this.radWideTPSAudibleEmergencyBeaconRouting_A41972);
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x003B5314 File Offset: 0x003B3514
		public bool HasDiffs
		{
			get
			{
				short num = (short)1244332032;
				short num2 = num;
				num = (short)1365966847;
				short num3 = num;
				num = (short)1745747967;
				switch (num3 == num)
				{
				}
				num = (short)1442316289;
				if (num != 0)
				{
				}
				num = (short)880410624;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x003B53C4 File Offset: 0x003B35C4
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x003B5478 File Offset: 0x003B3678
		public int RadWideTPSAudibleEmergencyBeaconsec_A7502Value
		{
			get
			{
				short num = (short)1322254336;
				short num2 = num;
				num = (short)1326189496;
				short num3 = num;
				num = (short)1903954872;
				switch (num3 == num)
				{
				}
				num = (short)2030370816;
				if (num != 0)
				{
				}
				num = (short)1392312321;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Value;
			}
			set
			{
				short num = (short)730005504;
				short num2 = num;
				num = (short)1639241225;
				short num3 = num;
				num = (short)143644169;
				switch (num3 == num)
				{
				}
				num = (short)1252327425;
				if (num != 0)
				{
				}
				num = (short)226099200;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Value = value;
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x003B552C File Offset: 0x003B372C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideTPSAudibleEmergencyBeaconsec_A7502
		{
			get
			{
				short num = (short)2017591296;
				short num2 = num;
				num = (short)1173275076;
				short num3 = num;
				num = (short)98353604;
				switch (num3 == num)
				{
				}
				num = (short)406454273;
				if (num != 0)
				{
				}
				num = (short)269811712;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06003EFB RID: 16123 RVA: 0x003B55DC File Offset: 0x003B37DC
		// (set) Token: 0x06003EFC RID: 16124 RVA: 0x003B5694 File Offset: 0x003B3894
		public string RadWideTPSAudibleEmergencyBeaconsec_A7502_UIValue
		{
			get
			{
				short num = (short)163643392;
				short num2 = num;
				num = (short)231870583;
				short num3 = num;
				num = (short)216469623;
				switch (num3 == num)
				{
				}
				num = (short)1231880193;
				if (num != 0)
				{
				}
				num = (short)344129536;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.UIValue;
			}
			set
			{
				short num = (short)440598528;
				short num2 = num;
				num = (short)1671260844;
				short num3 = num;
				num = (short)232680108;
				switch (num3 == num)
				{
				}
				num = (short)135069697;
				if (num != 0)
				{
				}
				num = (short)1969946624;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.UIValue = value;
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x003B5748 File Offset: 0x003B3948
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x003B57FC File Offset: 0x003B39FC
		internal int RadWideTPSAudibleEmergencyBeaconsec_A7502Min
		{
			get
			{
				short num = (short)1944649728;
				short num2 = num;
				num = (short)855548726;
				short num3 = num;
				num = (short)900244278;
				switch (num3 == num)
				{
				}
				num = (short)1962147841;
				if (num != 0)
				{
				}
				num = (short)1904607232;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Min;
			}
			set
			{
				short num = (short)1721303040;
				short num2 = num;
				num = (short)835002130;
				short num3 = num;
				num = (short)1411456786;
				switch (num3 == num)
				{
				}
				num = (short)2108751873;
				if (num != 0)
				{
				}
				num = (short)343801856;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Min = value;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x003B58B0 File Offset: 0x003B3AB0
		// (set) Token: 0x06003F00 RID: 16128 RVA: 0x003B5964 File Offset: 0x003B3B64
		internal int RadWideTPSAudibleEmergencyBeaconsec_A7502Max
		{
			get
			{
				short num = (short)739770368;
				short num2 = num;
				num = (short)1570607825;
				short num3 = num;
				num = (short)1117688529;
				switch (num3 == num)
				{
				}
				num = (short)1523515392;
				if (num != 0)
				{
				}
				num = (short)570556417;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Max;
			}
			set
			{
				short num = (short)333774848;
				short num2 = num;
				num = (short)341358866;
				short num3 = num;
				num = (short)1858255122;
				switch (num3 == num)
				{
				}
				num = (short)1256390657;
				if (num != 0)
				{
				}
				num = (short)1036255232;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Max = value;
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x003B5A1C File Offset: 0x003B3C1C
		// (set) Token: 0x06003F02 RID: 16130 RVA: 0x003B5AD0 File Offset: 0x003B3CD0
		internal int RadWideTPSAudibleEmergencyBeaconsec_A7502Step
		{
			get
			{
				short num = (short)1795227648;
				short num2 = num;
				num = (short)933363713;
				if (num != 0)
				{
				}
				num = (short)1979857922;
				short num3 = num;
				num = (short)1787771906;
				switch (num3 == num)
				{
				}
				num = (short)1481637888;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.StepSize;
			}
			set
			{
				short num = (short)1857617920;
				short num2 = num;
				num = (short)1581080276;
				short num3 = num;
				num = (short)1980980948;
				switch (num3 == num)
				{
				}
				num = (short)1392115713;
				if (num != 0)
				{
				}
				num = (short)617349120;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.StepSize = value;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x003B5B88 File Offset: 0x003B3D88
		// (set) Token: 0x06003F04 RID: 16132 RVA: 0x003B5C3C File Offset: 0x003B3E3C
		public bool RadWideTPSAudibleEmergencyBeaconsec_A7502_Applicable
		{
			get
			{
				short num = (short)860684288;
				short num2 = num;
				num = (short)1200410698;
				short num3 = num;
				num = (short)1130352714;
				switch (num3 == num)
				{
				}
				num = (short)1125449729;
				if (num != 0)
				{
				}
				num = (short)587137024;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Applicable;
			}
			set
			{
				short num = (short)2106654720;
				short num2 = num;
				num = (short)527384313;
				short num3 = num;
				num = (short)199704313;
				switch (num3 == num)
				{
				}
				num = (short)831520768;
				if (num != 0)
				{
				}
				num = (short)711852033;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Applicable = value;
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x003B5CF4 File Offset: 0x003B3EF4
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x003B5DAC File Offset: 0x003B3FAC
		public bool RadWideTPSAudibleEmergencyBeaconsec_A7502_Valid
		{
			get
			{
				short num = (short)755564544;
				short num2 = num;
				num = (short)669037886;
				short num3 = num;
				num = (short)518239550;
				switch (num3 == num)
				{
				}
				num = (short)1282736128;
				if (num != 0)
				{
				}
				num = (short)1899298817;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Valid;
			}
			set
			{
				short num = (short)78446592;
				short num2 = num;
				num = (short)2004287489;
				if (num != 0)
				{
				}
				num = (short)678835663;
				short num3 = num;
				num = (short)39204303;
				switch (num3 == num)
				{
				}
				num = (short)40501248;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Valid = value;
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x003B5E60 File Offset: 0x003B4060
		// (set) Token: 0x06003F08 RID: 16136 RVA: 0x003B5F14 File Offset: 0x003B4114
		public bool RadWideTPSAudibleEmergencyBeaconsec_A7502_Visible
		{
			get
			{
				short num = (short)908394496;
				short num2 = num;
				num = (short)2066793612;
				short num3 = num;
				num = (short)1345307788;
				switch (num3 == num)
				{
				}
				num = (short)1909981184;
				if (num != 0)
				{
				}
				num = (short)1869348865;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Visible;
			}
			set
			{
				short num = (short)152436736;
				short num2 = num;
				num = (short)1576472461;
				short num3 = num;
				num = (short)1321930637;
				switch (num3 == num)
				{
				}
				num = (short)1827078145;
				if (num != 0)
				{
				}
				num = (short)1415249920;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Visible = value;
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x003B5FC8 File Offset: 0x003B41C8
		// (set) Token: 0x06003F0A RID: 16138 RVA: 0x003B607C File Offset: 0x003B427C
		public bool RadWideTPSAudibleEmergencyBeaconsec_A7502_Editable
		{
			get
			{
				short num = (short)1860829184;
				short num2 = num;
				num = (short)974585857;
				if (num != 0)
				{
				}
				num = (short)2100191410;
				short num3 = num;
				num = (short)739008690;
				switch (num3 == num)
				{
				}
				num = (short)1727070208;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.Editable;
			}
			set
			{
				short num = (short)1415970816;
				short num2 = num;
				num = (short)731626193;
				short num3 = num;
				num = (short)535608017;
				switch (num3 == num)
				{
				}
				num = (short)470220801;
				if (num != 0)
				{
				}
				num = (short)1383858176;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.Editable = value;
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x003B6130 File Offset: 0x003B4330
		internal string RadWideTPSAudibleEmergencyBeaconsec_A7502_UILabel
		{
			get
			{
				short num = (short)307625984;
				short num2 = num;
				num = (short)1774676220;
				short num3 = num;
				num = (short)261974268;
				switch (num3 == num)
				{
				}
				num = (short)35061761;
				if (num != 0)
				{
				}
				num = (short)1416626176;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.UIName;
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x003B61E4 File Offset: 0x003B43E4
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x003B6298 File Offset: 0x003B4498
		internal bool RadWideTPSAudibleEmergencyBeaconsec_A7502_HiddenStatic
		{
			get
			{
				short num = (short)868024320;
				short num2 = num;
				num = (short)1793946153;
				short num3 = num;
				num = (short)174813737;
				switch (num3 == num)
				{
				}
				num = (short)399441921;
				if (num != 0)
				{
				}
				num = (short)1477640192;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.HiddenStatic;
			}
			set
			{
				short num = (short)229441536;
				short num2 = num;
				num = (short)323394069;
				short num3 = num;
				num = (short)521050645;
				switch (num3 == num)
				{
				}
				num = (short)174784513;
				if (num != 0)
				{
				}
				num = (short)1911095296;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.HiddenStatic = value;
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x003B6350 File Offset: 0x003B4550
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x003B6404 File Offset: 0x003B4604
		internal bool RadWideTPSAudibleEmergencyBeaconsec_A7502_HiddenDynamic
		{
			get
			{
				short num = (short)271974400;
				short num2 = num;
				num = (short)1099591281;
				short num3 = num;
				num = (short)1892445809;
				switch (num3 == num)
				{
				}
				num = (short)836435968;
				if (num != 0)
				{
				}
				num = (short)1325072385;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502.HiddenDynamic;
			}
			set
			{
				short num = (short)1264123904;
				short num2 = num;
				num = (short)619011820;
				short num3 = num;
				num = (short)517496556;
				switch (num3 == num)
				{
				}
				num = (short)1947205633;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				this.radWideTPSAudibleEmergencyBeaconsec_A7502.HiddenDynamic = value;
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x003B64B8 File Offset: 0x003B46B8
		public bool RadWideTPSAudibleEmergencyBeaconsec_A7502_HasDiffs
		{
			get
			{
				short num = (short)470876160;
				short num2 = num;
				num = (short)102828564;
				short num3 = num;
				num = (short)2128742932;
				switch (num3 == num)
				{
				}
				num = (short)401866753;
				if (num != 0)
				{
				}
				num = (short)1202978816;
				if (num != 0)
				{
				}
				return this.radWideTPSAudibleEmergencyBeaconsec_A7502._HasDiffs;
			}
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x003B656C File Offset: 0x003B476C
		// (set) Token: 0x06003F12 RID: 16146 RVA: 0x003B6620 File Offset: 0x003B4820
		public int RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929Value
		{
			get
			{
				short num = (short)613810176;
				short num2 = num;
				num = (short)2093011727;
				short num3 = num;
				num = (short)1731580687;
				switch (num3 == num)
				{
				}
				num = (short)1917452289;
				if (num != 0)
				{
				}
				num = (short)419889152;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Value;
			}
			set
			{
				short num = (short)200409088;
				short num2 = num;
				num = (short)372294400;
				short num3 = num;
				num = (short)796312320;
				switch (num3 == num)
				{
				}
				num = (short)104202241;
				if (num != 0)
				{
				}
				num = (short)739180544;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Value = value;
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x003B66D4 File Offset: 0x003B48D4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929
		{
			get
			{
				short num = (short)578224128;
				short num2 = num;
				num = (short)1634134305;
				short num3 = num;
				num = (short)316860705;
				switch (num3 == num)
				{
				}
				num = (short)671481856;
				if (num != 0)
				{
				}
				num = (short)665190401;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x003B6784 File Offset: 0x003B4984
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x003B6838 File Offset: 0x003B4A38
		public string RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_UIValue
		{
			get
			{
				short num = (short)1636433920;
				short num2 = num;
				num = (short)1707147265;
				if (num != 0)
				{
				}
				num = (short)1898481424;
				short num3 = num;
				num = (short)722241296;
				switch (num3 == num)
				{
				}
				num = (short)1904607232;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.UIValue;
			}
			set
			{
				short num = (short)656474112;
				short num2 = num;
				num = (short)330056189;
				short num3 = num;
				num = (short)1538802173;
				switch (num3 == num)
				{
				}
				num = (short)248512512;
				if (num != 0)
				{
				}
				num = (short)865992705;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.UIValue = value;
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x003B68F0 File Offset: 0x003B4AF0
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x003B69A4 File Offset: 0x003B4BA4
		internal int RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929Min
		{
			get
			{
				short num = (short)381878272;
				short num2 = num;
				num = (short)72264742;
				short num3 = num;
				num = (short)2083892262;
				switch (num3 == num)
				{
				}
				num = (short)1832386561;
				if (num != 0)
				{
				}
				num = (short)79822848;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Min;
			}
			set
			{
				short num = (short)2011561984;
				short num2 = num;
				num = (short)205786225;
				short num3 = num;
				num = (short)640748657;
				switch (num3 == num)
				{
				}
				num = (short)415760385;
				if (num != 0)
				{
				}
				num = (short)1930493952;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Min = value;
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x003B6A58 File Offset: 0x003B4C58
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x003B6B0C File Offset: 0x003B4D0C
		internal int RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929Max
		{
			get
			{
				short num = (short)959315968;
				short num2 = num;
				num = (short)2008988349;
				short num3 = num;
				num = (short)941669053;
				switch (num3 == num)
				{
				}
				num = (short)1873543169;
				if (num != 0)
				{
				}
				num = (short)1929379840;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Max;
			}
			set
			{
				short num = (short)1414856704;
				short num2 = num;
				num = (short)780360500;
				short num3 = num;
				num = (short)1718180660;
				switch (num3 == num)
				{
				}
				num = (short)503644161;
				if (num != 0)
				{
				}
				num = (short)232128512;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Max = value;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x003B6BC0 File Offset: 0x003B4DC0
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x003B6C74 File Offset: 0x003B4E74
		internal int RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929Step
		{
			get
			{
				short num = (short)4587520;
				short num2 = num;
				num = (short)1555736408;
				short num3 = num;
				num = (short)83208024;
				switch (num3 == num)
				{
				}
				num = (short)1400963072;
				if (num != 0)
				{
				}
				num = (short)1726742529;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.StepSize;
			}
			set
			{
				short num = (short)432734208;
				short num2 = num;
				num = (short)1305970659;
				short num3 = num;
				num = (short)1816692707;
				switch (num3 == num)
				{
				}
				num = (short)1005322240;
				if (num != 0)
				{
				}
				num = (short)1096679425;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.StepSize = value;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x003B6D28 File Offset: 0x003B4F28
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x003B6DDC File Offset: 0x003B4FDC
		public bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_Applicable
		{
			get
			{
				short num = (short)2096168960;
				short num2 = num;
				num = (short)1180149219;
				short num3 = num;
				num = (short)1657054691;
				switch (num3 == num)
				{
				}
				num = (short)1027145729;
				if (num != 0)
				{
				}
				num = (short)1558118400;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Applicable;
			}
			set
			{
				short num = (short)603914240;
				short num2 = num;
				num = (short)863584213;
				short num3 = num;
				num = (short)1682653141;
				switch (num3 == num)
				{
				}
				num = (short)1133838337;
				if (num != 0)
				{
				}
				num = (short)1677066240;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Applicable = value;
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x003B6E94 File Offset: 0x003B5094
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x003B6F4C File Offset: 0x003B514C
		public bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_Valid
		{
			get
			{
				short num = (short)2133917696;
				short num2 = num;
				num = (short)1160577025;
				if (num != 0)
				{
				}
				num = (short)868800303;
				short num3 = num;
				num = (short)448386863;
				switch (num3 == num)
				{
				}
				num = (short)1763704832;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Valid;
			}
			set
			{
				short num = (short)1645740032;
				short num2 = num;
				num = (short)1458113150;
				short num3 = num;
				num = (short)289606270;
				switch (num3 == num)
				{
				}
				num = (short)683802625;
				if (num != 0)
				{
				}
				num = (short)401014784;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Valid = value;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x003B7000 File Offset: 0x003B5200
		// (set) Token: 0x06003F21 RID: 16161 RVA: 0x003B70B4 File Offset: 0x003B52B4
		public bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_Visible
		{
			get
			{
				short num = (short)919142400;
				short num2 = num;
				num = (short)1112429779;
				short num3 = num;
				num = (short)2088522963;
				switch (num3 == num)
				{
				}
				num = (short)1616642049;
				if (num != 0)
				{
				}
				num = (short)1160052736;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Visible;
			}
			set
			{
				short num = (short)830406656;
				short num2 = num;
				num = (short)629956819;
				short num3 = num;
				num = (short)499015891;
				switch (num3 == num)
				{
				}
				num = (short)1410793472;
				if (num != 0)
				{
				}
				num = (short)1159004161;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Visible = value;
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06003F22 RID: 16162 RVA: 0x003B7168 File Offset: 0x003B5368
		// (set) Token: 0x06003F23 RID: 16163 RVA: 0x003B7218 File Offset: 0x003B5418
		public bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_Editable
		{
			get
			{
				short num = (short)1630732288;
				short num2 = num;
				num = (short)361654228;
				short num3 = num;
				num = (short)1657366484;
				switch (num3 == num)
				{
				}
				num = (short)817168385;
				if (num != 0)
				{
				}
				num = (short)1448673280;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Editable;
			}
			set
			{
				short num = (short)1832845312;
				short num2 = num;
				num = (short)593821697;
				if (num != 0)
				{
				}
				num = (short)501655645;
				short num3 = num;
				num = (short)1543940189;
				switch (num3 == num)
				{
				}
				num = (short)2128150528;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Editable = value;
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06003F24 RID: 16164 RVA: 0x003B72CC File Offset: 0x003B54CC
		internal string RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_UILabel
		{
			get
			{
				short num = (short)1346830336;
				short num2 = num;
				num = (short)1622885175;
				short num3 = num;
				num = (short)1536574263;
				switch (num3 == num)
				{
				}
				num = (short)845479936;
				if (num != 0)
				{
				}
				num = (short)1521090561;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.UIName;
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x003B7384 File Offset: 0x003B5584
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x003B7438 File Offset: 0x003B5638
		internal bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_HiddenStatic
		{
			get
			{
				short num = (short)608043008;
				short num2 = num;
				num = (short)1599930646;
				short num3 = num;
				num = (short)75301142;
				switch (num3 == num)
				{
				}
				num = (short)866844672;
				if (num != 0)
				{
				}
				num = (short)886177793;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.HiddenStatic;
			}
			set
			{
				short num = (short)304218112;
				short num2 = num;
				num = (short)1192182880;
				short num3 = num;
				num = (short)1611154528;
				switch (num3 == num)
				{
				}
				num = (short)1671233536;
				if (num != 0)
				{
				}
				num = (short)799145985;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.HiddenStatic = value;
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x003B74F0 File Offset: 0x003B56F0
		// (set) Token: 0x06003F28 RID: 16168 RVA: 0x003B75A8 File Offset: 0x003B57A8
		internal bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_HiddenDynamic
		{
			get
			{
				short num = (short)1504641025;
				if (num != 0)
				{
				}
				num = (short)1359609386;
				short num2 = num;
				num = (short)1470955050;
				switch (num2 == num)
				{
				}
				num = (short)225640448;
				if (num != 0)
				{
				}
				num = (short)809500672;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.HiddenDynamic;
			}
			set
			{
				short num = (short)758971473;
				short num2 = num;
				num = (short)858192977;
				switch (num2 == num)
				{
				}
				num = (short)357892096;
				if (num != 0)
				{
				}
				num = (short)776142849;
				if (num != 0)
				{
				}
				num = (short)1638858752;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.HiddenDynamic = value;
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x003B765C File Offset: 0x003B585C
		public bool RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929_HasDiffs
		{
			get
			{
				short num = (short)1723295447;
				short num2 = num;
				num = (short)1404135127;
				switch (num2 == num)
				{
				}
				num = (short)542310400;
				if (num != 0)
				{
				}
				num = (short)708247553;
				if (num != 0)
				{
				}
				num = (short)282525696;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929._HasDiffs;
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x003B7714 File Offset: 0x003B5914
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x003B77C8 File Offset: 0x003B59C8
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936Value
		{
			get
			{
				short num = (short)2075245474;
				short num2 = num;
				num = (short)1977138082;
				switch (num2 == num)
				{
				}
				num = (short)1248722944;
				if (num != 0)
				{
				}
				num = (short)50069505;
				if (num != 0)
				{
				}
				num = (short)1785200640;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Value;
			}
			set
			{
				short num = (short)1193997587;
				short num2 = num;
				num = (short)194704659;
				switch (num2 == num)
				{
				}
				num = (short)1690894337;
				if (num != 0)
				{
				}
				num = (short)922550272;
				if (num != 0)
				{
				}
				num = (short)2050752512;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Value = value;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06003F2C RID: 16172 RVA: 0x003B7884 File Offset: 0x003B5A84
		public global::AcpBusinessLayer.AcpField<bool> RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936
		{
			get
			{
				short num = (short)1252456181;
				short num2 = num;
				num = (short)918746869;
				switch (num2 == num)
				{
				}
				num = (short)1184628737;
				if (num != 0)
				{
				}
				num = (short)1139671040;
				if (num != 0)
				{
				}
				num = (short)382599168;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936;
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x003B7938 File Offset: 0x003B5B38
		// (set) Token: 0x06003F2E RID: 16174 RVA: 0x003B79F0 File Offset: 0x003B5BF0
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_UIValue
		{
			get
			{
				short num = (short)1086483504;
				short num2 = num;
				num = (short)1916103728;
				switch (num2 == num)
				{
				}
				num = (short)1404698625;
				if (num != 0)
				{
				}
				num = (short)247726080;
				if (num != 0)
				{
				}
				num = (short)279642112;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Value;
			}
			set
			{
				short num = (short)59084245;
				short num2 = num;
				num = (short)2040696277;
				switch (num2 == num)
				{
				}
				num = (short)958726145;
				if (num != 0)
				{
				}
				num = (short)723189760;
				if (num != 0)
				{
				}
				num = (short)915734528;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Value = value;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x003B7AA8 File Offset: 0x003B5CA8
		// (set) Token: 0x06003F30 RID: 16176 RVA: 0x003B7B5C File Offset: 0x003B5D5C
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_Applicable
		{
			get
			{
				short num = (short)1142124962;
				short num2 = num;
				num = (short)1139437986;
				switch (num2 == num)
				{
				}
				num = (short)785645569;
				if (num != 0)
				{
				}
				num = (short)753401856;
				if (num != 0)
				{
				}
				num = (short)2077556736;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Applicable;
			}
			set
			{
				short num = (short)303458199;
				short num2 = num;
				num = (short)840394647;
				switch (num2 == num)
				{
				}
				num = (short)439287809;
				if (num != 0)
				{
				}
				num = (short)1012924416;
				if (num != 0)
				{
				}
				num = (short)1810169856;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Applicable = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06003F31 RID: 16177 RVA: 0x003B7C14 File Offset: 0x003B5E14
		// (set) Token: 0x06003F32 RID: 16178 RVA: 0x003B7CC8 File Offset: 0x003B5EC8
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_Valid
		{
			get
			{
				short num = (short)759431169;
				if (num != 0)
				{
				}
				num = (short)473719511;
				short num2 = num;
				num = (short)116024023;
				switch (num2 == num)
				{
				}
				num = (short)1974730752;
				if (num != 0)
				{
				}
				num = (short)959578112;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Valid;
			}
			set
			{
				short num = (short)2000355329;
				if (num != 0)
				{
				}
				num = (short)556533346;
				short num2 = num;
				num = (short)1033897570;
				switch (num2 == num)
				{
				}
				num = (short)1578303488;
				if (num != 0)
				{
				}
				num = (short)387907584;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Valid = value;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06003F33 RID: 16179 RVA: 0x003B7D80 File Offset: 0x003B5F80
		// (set) Token: 0x06003F34 RID: 16180 RVA: 0x003B7E38 File Offset: 0x003B6038
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_Visible
		{
			get
			{
				short num = (short)1257084828;
				short num2 = num;
				num = (short)22714268;
				switch (num2 == num)
				{
				}
				num = (short)484442112;
				if (num != 0)
				{
				}
				num = (short)1457520641;
				if (num != 0)
				{
				}
				num = (short)919666688;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Visible;
			}
			set
			{
				short num = (short)1502273590;
				short num2 = num;
				num = (short)401924150;
				switch (num2 == num)
				{
				}
				num = (short)622854145;
				if (num != 0)
				{
				}
				num = (short)2055274496;
				if (num != 0)
				{
				}
				num = (short)320864256;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Visible = value;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06003F35 RID: 16181 RVA: 0x003B7EEC File Offset: 0x003B60EC
		// (set) Token: 0x06003F36 RID: 16182 RVA: 0x003B7FA0 File Offset: 0x003B61A0
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_Editable
		{
			get
			{
				short num = (short)330118640;
				short num2 = num;
				num = (short)1581856240;
				switch (num2 == num)
				{
				}
				num = (short)527302656;
				if (num != 0)
				{
				}
				num = (short)815726593;
				if (num != 0)
				{
				}
				num = (short)233242624;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Editable;
			}
			set
			{
				short num = (short)296618944;
				short num2 = num;
				num = (short)26086336;
				switch (num2 == num)
				{
				}
				num = (short)1876688897;
				if (num != 0)
				{
				}
				num = (short)1574436864;
				if (num != 0)
				{
				}
				num = (short)1252196352;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.Editable = value;
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x06003F37 RID: 16183 RVA: 0x003B8054 File Offset: 0x003B6254
		internal string RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_UILabel
		{
			get
			{
				short num = (short)202209044;
				short num2 = num;
				num = (short)357922580;
				switch (num2 == num)
				{
				}
				num = (short)1733689344;
				if (num != 0)
				{
				}
				num = (short)1240793089;
				if (num != 0)
				{
				}
				num = (short)2145779712;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.UIName;
			}
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06003F38 RID: 16184 RVA: 0x003B8108 File Offset: 0x003B6308
		// (set) Token: 0x06003F39 RID: 16185 RVA: 0x003B81C0 File Offset: 0x003B63C0
		internal bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_HiddenStatic
		{
			get
			{
				short num = (short)1963954140;
				short num2 = num;
				num = (short)1111199708;
				switch (num2 == num)
				{
				}
				num = (short)1504509952;
				if (num != 0)
				{
				}
				num = (short)1180827649;
				if (num != 0)
				{
				}
				num = (short)674693120;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.HiddenStatic;
			}
			set
			{
				short num = (short)1295995491;
				short num2 = num;
				num = (short)1974030947;
				switch (num2 == num)
				{
				}
				num = (short)424607745;
				if (num != 0)
				{
				}
				num = (short)1033043968;
				if (num != 0)
				{
				}
				num = (short)184811520;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.HiddenStatic = value;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x003B8274 File Offset: 0x003B6474
		// (set) Token: 0x06003F3B RID: 16187 RVA: 0x003B8328 File Offset: 0x003B6528
		internal bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_HiddenDynamic
		{
			get
			{
				short num = (short)47650189;
				short num2 = num;
				num = (short)729159053;
				switch (num2 == num)
				{
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				num = (short)2104492033;
				if (num != 0)
				{
				}
				num = (short)689242112;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.HiddenDynamic;
			}
			set
			{
				short num = (short)1574298564;
				short num2 = num;
				num = (short)530375620;
				switch (num2 == num)
				{
				}
				num = (short)1838612481;
				if (num != 0)
				{
				}
				num = (short)825819136;
				if (num != 0)
				{
				}
				num = (short)1053491200;
				short num3 = num;
				this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936.HiddenDynamic = value;
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x003B83E0 File Offset: 0x003B65E0
		public bool RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936_HasDiffs
		{
			get
			{
				short num = (short)1248857574;
				short num2 = num;
				num = (short)574033382;
				switch (num2 == num)
				{
				}
				num = (short)467533824;
				if (num != 0)
				{
				}
				num = (short)1704394753;
				if (num != 0)
				{
				}
				num = (short)578027520;
				short num3 = num;
				return this.radWideTPSFiregroundEmergencyCallDekeySidetone_A7936._HasDiffs;
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x003B8494 File Offset: 0x003B6694
		// (set) Token: 0x06003F3E RID: 16190 RVA: 0x003B854C File Offset: 0x003B674C
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655Value
		{
			get
			{
				short num = (short)640134636;
				short num2 = num;
				num = (short)1733144044;
				switch (num2 == num)
				{
				}
				num = (short)445382657;
				if (num != 0)
				{
				}
				num = (short)863240192;
				if (num != 0)
				{
				}
				num = (short)1358823424;
				short num3 = num;
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.Value;
			}
			set
			{
				short num = (short)523378344;
				short num2 = num;
				num = (short)1403526824;
				switch (num2 == num)
				{
				}
				num = (short)2105147392;
				if (num != 0)
				{
				}
				num = (short)1109983233;
				if (num != 0)
				{
				}
				num = (short)1440546816;
				short num3 = num;
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.Value = value;
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06003F3F RID: 16191 RVA: 0x003B8604 File Offset: 0x003B6804
		public global::AcpBusinessLayer.AcpField<bool> RadWideTPSFiregroundVoiceTxEndTone_A9655
		{
			get
			{
				short num = (short)732155832;
				short num2 = num;
				num = (short)706596792;
				switch (num2 == num)
				{
				}
				num = (short)1248526337;
				if (num != 0)
				{
				}
				num = (short)1670512640;
				if (num != 0)
				{
				}
				num = (short)1621819392;
				short num3 = num;
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655;
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06003F40 RID: 16192 RVA: 0x003B86B8 File Offset: 0x003B68B8
		// (set) Token: 0x06003F41 RID: 16193 RVA: 0x003B876C File Offset: 0x003B696C
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655_UIValue
		{
			get
			{
				short num = (short)1892452739;
				short num2 = num;
				num = (short)1790413187;
				switch (num2 == num)
				{
				}
				num = (short)2085552128;
				if (num != 0)
				{
				}
				num = (short)1782185985;
				if (num != 0)
				{
				}
				num = (short)912064512;
				short num3 = num;
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.Value;
			}
			set
			{
				short num = (short)705691649;
				if (num != 0)
				{
				}
				num = (short)940093522;
				short num2 = num;
				num = (short)489402450;
				switch (num2 == num)
				{
				}
				num = (short)1452343296;
				if (num != 0)
				{
				}
				num = (short)984743936;
				short num3 = num;
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.Value = value;
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x003B8824 File Offset: 0x003B6A24
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x003B88D8 File Offset: 0x003B6AD8
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655_Applicable
		{
			get
			{
				short num = (short)834081833;
				short num2 = num;
				num = (short)1438389289;
				switch (num2 == num)
				{
				}
				num = (short)1600258049;
				if (num != 0)
				{
				}
				num = (short)117309440;
				if (num != 0)
				{
				}
				num = (short)533921792;
				short num3 = num;
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.Applicable;
			}
			set
			{
				short num = (short)684134742;
				short num2 = num;
				num = (short)788271446;
				switch (num2 == num)
				{
				}
				num = (short)1683357697;
				if (num != 0)
				{
				}
				num = (short)1233453056;
				if (num != 0)
				{
				}
				num = (short)678887424;
				short num3 = num;
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.Applicable = value;
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x003B8990 File Offset: 0x003B6B90
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x003B8A44 File Offset: 0x003B6C44
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655_Valid
		{
			get
			{
				short num = (short)1348075521;
				if (num != 0)
				{
				}
				num = (short)1076965952;
				short num2 = num;
				num = (short)834810432;
				switch (num2 == num)
				{
				}
				num = (short)1746206720;
				if (num != 0)
				{
				}
				num = (short)1258029056;
				short num3 = num;
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.Valid;
			}
			set
			{
				short num = (short)210945555;
				short num2 = num;
				num = (short)1262405139;
				switch (num2 == num)
				{
				}
				num = (short)1227358209;
				if (num != 0)
				{
				}
				num = (short)1158807552;
				if (num != 0)
				{
				}
				num = (short)1069613056;
				short num3 = num;
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.Valid = value;
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x003B8AFC File Offset: 0x003B6CFC
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x003B8BB0 File Offset: 0x003B6DB0
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655_Visible
		{
			get
			{
				short num = (short)59513781;
				short num2 = num;
				num = (short)1942297525;
				switch (num2 == num)
				{
				}
				num = (short)1177878529;
				if (num != 0)
				{
				}
				num = (short)1951662080;
				if (num != 0)
				{
				}
				num = (short)1250689024;
				short num3 = num;
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.Visible;
			}
			set
			{
				short num = (short)872483070;
				short num2 = num;
				num = (short)1471285502;
				switch (num2 == num)
				{
				}
				num = (short)732692480;
				short num3 = num;
				num = (short)797442049;
				if (num != 0)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.Visible = value;
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x003B8C68 File Offset: 0x003B6E68
		// (set) Token: 0x06003F49 RID: 16201 RVA: 0x003B8D1C File Offset: 0x003B6F1C
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655_Editable
		{
			get
			{
				short num = (short)1746833071;
				short num2 = num;
				num = (short)1741459119;
				switch (num2 == num)
				{
				}
				num = (short)708444160;
				short num3 = num;
				num = (short)505675777;
				if (num != 0)
				{
				}
				num = (short)1232338944;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.Editable;
			}
			set
			{
				short num = (short)1027392725;
				short num2 = num;
				num = (short)1176421589;
				switch (num2 == num)
				{
				}
				num = (short)4194304;
				short num3 = num;
				num = (short)842858497;
				if (num != 0)
				{
				}
				num = (short)667353088;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.Editable = value;
			}
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x003B8DD0 File Offset: 0x003B6FD0
		internal string RadWideTPSFiregroundVoiceTxEndTone_A9655_UILabel
		{
			get
			{
				short num = (short)229174480;
				short num2 = num;
				num = (short)1524624592;
				switch (num2 == num)
				{
				}
				num = (short)826212352;
				short num3 = num;
				num = (short)1083179008;
				if (num != 0)
				{
				}
				num = (short)795738113;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.UIName;
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x003B8E84 File Offset: 0x003B7084
		// (set) Token: 0x06003F4C RID: 16204 RVA: 0x003B8F38 File Offset: 0x003B7138
		internal bool RadWideTPSFiregroundVoiceTxEndTone_A9655_HiddenStatic
		{
			get
			{
				short num = (short)1116602369;
				if (num != 0)
				{
				}
				num = (short)865542200;
				short num2 = num;
				num = (short)436609080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1070792704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595263488;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.HiddenStatic;
			}
			set
			{
				short num = (short)1910212186;
				short num2 = num;
				num = (short)1274709594;
				switch (num2 == num)
				{
				}
				num = (short)1824980992;
				short num3 = num;
				num = (short)1116078080;
				if (num != 0)
				{
				}
				num = (short)1086062593;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.HiddenStatic = value;
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x003B8FEC File Offset: 0x003B71EC
		// (set) Token: 0x06003F4E RID: 16206 RVA: 0x003B90A0 File Offset: 0x003B72A0
		internal bool RadWideTPSFiregroundVoiceTxEndTone_A9655_HiddenDynamic
		{
			get
			{
				short num = (short)165721875;
				short num2 = num;
				num = (short)306624275;
				switch (num2 == num)
				{
				}
				num = (short)626720768;
				short num3 = num;
				num = (short)461307905;
				if (num != 0)
				{
				}
				num = (short)1850343424;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655.HiddenDynamic;
			}
			set
			{
				short num = (short)1075975548;
				short num2 = num;
				num = (short)1673532796;
				switch (num2 == num)
				{
				}
				num = (short)1809383424;
				short num3 = num;
				num = (short)2065629184;
				if (num != 0)
				{
				}
				num = (short)1567883265;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundVoiceTxEndTone_A9655.HiddenDynamic = value;
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06003F4F RID: 16207 RVA: 0x003B9154 File Offset: 0x003B7354
		public bool RadWideTPSFiregroundVoiceTxEndTone_A9655_HasDiffs
		{
			get
			{
				short num = (short)1639992973;
				short num2 = num;
				num = (short)926502541;
				switch (num2 == num)
				{
				}
				num = (short)2100559872;
				short num3 = num;
				num = (short)1048379393;
				if (num != 0)
				{
				}
				num = (short)1847853056;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundVoiceTxEndTone_A9655._HasDiffs;
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x003B9208 File Offset: 0x003B7408
		// (set) Token: 0x06003F51 RID: 16209 RVA: 0x003B92BC File Offset: 0x003B74BC
		public int RadWideTPSEmergencyPTTTransmission_A41544Value
		{
			get
			{
				short num = (short)1347747841;
				if (num != 0)
				{
				}
				num = (short)81251679;
				short num2 = num;
				num = (short)854248799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844641792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1043398656;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.Value;
			}
			set
			{
				short num = (short)323237301;
				short num2 = num;
				num = (short)879572405;
				switch (num2 == num)
				{
				}
				num = (short)2013200384;
				short num3 = num;
				num = (short)1735458817;
				if (num != 0)
				{
				}
				num = (short)423952384;
				if (num != 0)
				{
				}
				this.radWideTPSEmergencyPTTTransmission_A41544.Value = value;
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x003B9370 File Offset: 0x003B7570
		// (set) Token: 0x06003F53 RID: 16211 RVA: 0x003B9424 File Offset: 0x003B7624
		public string RadWideTPSEmergencyPTTTransmission_A41544_UIValue
		{
			get
			{
				short num = (short)2000429131;
				short num2 = num;
				num = (short)71049291;
				switch (num2 == num)
				{
				}
				num = (short)1568407552;
				short num3 = num;
				num = (short)2097938433;
				if (num != 0)
				{
				}
				num = (short)1161363456;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.UIValue;
			}
			set
			{
				short num = (short)193003521;
				if (num != 0)
				{
				}
				num = (short)1648050955;
				short num2 = num;
				num = (short)2071741195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834076672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)838795264;
				if (num != 0)
				{
				}
				this.radWideTPSEmergencyPTTTransmission_A41544.UIValue = value;
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x003B94D8 File Offset: 0x003B76D8
		public global::AcpBusinessLayer.AcpListField RadWideTPSEmergencyPTTTransmission_A41544
		{
			get
			{
				short num = (short)2012872705;
				if (num != 0)
				{
				}
				num = (short)368327026;
				short num2 = num;
				num = (short)354302322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277558784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358023168;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544;
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x003B958C File Offset: 0x003B778C
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x003B9640 File Offset: 0x003B7840
		public bool RadWideTPSEmergencyPTTTransmission_A41544_Applicable
		{
			get
			{
				short num = (short)688193537;
				if (num != 0)
				{
				}
				num = (short)906706835;
				short num2 = num;
				num = (short)1023754131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478609408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980746240;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.Applicable;
			}
			set
			{
				short num = (short)1394092616;
				short num2 = num;
				num = (short)1074145864;
				switch (num2 == num)
				{
				}
				num = (short)1257504768;
				short num3 = num;
				num = (short)129564672;
				if (num != 0)
				{
				}
				num = (short)985530369;
				if (num != 0)
				{
				}
				this.radWideTPSEmergencyPTTTransmission_A41544.Applicable = value;
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x003B96F4 File Offset: 0x003B78F4
		// (set) Token: 0x06003F58 RID: 16216 RVA: 0x003B97A8 File Offset: 0x003B79A8
		public bool RadWideTPSEmergencyPTTTransmission_A41544_Valid
		{
			get
			{
				short num = (short)450764515;
				short num2 = num;
				num = (short)955391715;
				switch (num2 == num)
				{
				}
				num = (short)873136128;
				short num3 = num;
				num = (short)575471617;
				if (num != 0)
				{
				}
				num = (short)1221328896;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.Valid;
			}
			set
			{
				short num = (short)878859538;
				short num2 = num;
				num = (short)879842578;
				switch (num2 == num)
				{
				}
				num = (short)474808320;
				short num3 = num;
				num = (short)286851073;
				if (num != 0)
				{
				}
				num = (short)267321344;
				if (num != 0)
				{
				}
				this.radWideTPSEmergencyPTTTransmission_A41544.Valid = value;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06003F59 RID: 16217 RVA: 0x003B985C File Offset: 0x003B7A5C
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x003B9914 File Offset: 0x003B7B14
		public bool RadWideTPSEmergencyPTTTransmission_A41544_Visible
		{
			get
			{
				short num = (short)1077473471;
				short num2 = num;
				num = (short)649457855;
				switch (num2 == num)
				{
				}
				num = (short)735248384;
				short num3 = num;
				num = (short)347865089;
				if (num != 0)
				{
				}
				num = (short)820379648;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.Visible;
			}
			set
			{
				short num = (short)1534269569;
				short num2 = num;
				num = (short)767891585;
				switch (num2 == num)
				{
				}
				num = (short)1324417024;
				short num3 = num;
				num = (short)1799094273;
				if (num != 0)
				{
				}
				num = (short)1208418304;
				if (num != 0)
				{
				}
				this.radWideTPSEmergencyPTTTransmission_A41544.Visible = value;
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x003B99CC File Offset: 0x003B7BCC
		// (set) Token: 0x06003F5C RID: 16220 RVA: 0x003B9A80 File Offset: 0x003B7C80
		public bool RadWideTPSEmergencyPTTTransmission_A41544_Editable
		{
			get
			{
				short num = (short)365949140;
				short num2 = num;
				num = (short)115208404;
				switch (num2 == num)
				{
				}
				num = (short)794165248;
				short num3 = num;
				num = (short)460718081;
				if (num != 0)
				{
				}
				num = (short)155254784;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.Editable;
			}
			set
			{
				short num = (short)355991553;
				if (num != 0)
				{
				}
				num = (short)789310345;
				short num2 = num;
				num = (short)1013377929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1640235008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1233649664;
				if (num != 0)
				{
				}
				this.radWideTPSEmergencyPTTTransmission_A41544.Editable = value;
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x003B9B34 File Offset: 0x003B7D34
		internal string RadWideTPSEmergencyPTTTransmission_A41544_UILabel
		{
			get
			{
				short num = (short)823550107;
				short num2 = num;
				num = (short)1325490331;
				switch (num2 == num)
				{
				}
				num = (short)2010316800;
				short num3 = num;
				num = (short)1058537473;
				if (num != 0)
				{
				}
				num = (short)1678311424;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.UIName;
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x003B9BE8 File Offset: 0x003B7DE8
		// (set) Token: 0x06003F5F RID: 16223 RVA: 0x003B9C9C File Offset: 0x003B7E9C
		internal bool RadWideTPSEmergencyPTTTransmission_A41544_HiddenStatic
		{
			get
			{
				short num = (short)1325793281;
				if (num != 0)
				{
				}
				num = (short)497348676;
				short num2 = num;
				num = (short)1206448196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)858456064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775304704;
				if (num != 0)
				{
				}
				return this.radWideTPSEmergencyPTTTransmission_A41544.HiddenStatic;
			}
			set
			{
				short num = (short)1917931108;
				short num2 = num;
				num = (short)1339969124;
				switch (num2 == num)
				{
				}
				num = (short)673251329;
				if (num != 0)
				{
				}
				num = (short)1132724224;
				if (num != 0)
				{
				}
				num = (short)817233920;
				short num3 = num;
				this.radWideTPSEmergencyPTTTransmission_A41544.HiddenStatic = value;
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x003B9D54 File Offset: 0x003B7F54
		// (set) Token: 0x06003F61 RID: 16225 RVA: 0x003B9E08 File Offset: 0x003B8008
		internal bool RadWideTPSEmergencyPTTTransmission_A41544_HiddenDynamic
		{
			get
			{
				short num = (short)212879406;
				short num2 = num;
				num = (short)586893358;
				switch (num2 == num)
				{
				}
				num = (short)29032449;
				if (num != 0)
				{
				}
				num = (short)1238368256;
				if (num != 0)
				{
				}
				num = (short)1262354432;
				short num3 = num;
				return this.radWideTPSEmergencyPTTTransmission_A41544.HiddenDynamic;
			}
			set
			{
				short num = (short)401992682;
				short num2 = num;
				num = (short)347859946;
				switch (num2 == num)
				{
				}
				num = (short)849412097;
				if (num != 0)
				{
				}
				num = (short)1950023680;
				if (num != 0)
				{
				}
				num = (short)13303808;
				short num3 = num;
				this.radWideTPSEmergencyPTTTransmission_A41544.HiddenDynamic = value;
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x003B9EBC File Offset: 0x003B80BC
		public bool RadWideTPSEmergencyPTTTransmission_A41544_HasDiffs
		{
			get
			{
				short num = (short)1056205711;
				short num2 = num;
				num = (short)389704591;
				switch (num2 == num)
				{
				}
				num = (short)2015232001;
				if (num != 0)
				{
				}
				num = (short)1367998464;
				if (num != 0)
				{
				}
				num = (short)343998464;
				short num3 = num;
				return this.radWideTPSEmergencyPTTTransmission_A41544._HasDiffs;
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x003B9F74 File Offset: 0x003B8174
		// (set) Token: 0x06003F64 RID: 16228 RVA: 0x003BA028 File Offset: 0x003B8228
		public int RadWideTPSPTTTransmission_A41545Value
		{
			get
			{
				short num = (short)1519863458;
				short num2 = num;
				num = (short)1407076002;
				switch (num2 == num)
				{
				}
				num = (short)1307181057;
				if (num != 0)
				{
				}
				num = (short)1128398848;
				if (num != 0)
				{
				}
				num = (short)1322778624;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.Value;
			}
			set
			{
				short num = (short)1409046535;
				short num2 = num;
				num = (short)85612551;
				switch (num2 == num)
				{
				}
				num = (short)124518401;
				if (num != 0)
				{
				}
				num = (short)791543808;
				if (num != 0)
				{
				}
				num = (short)628359168;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.Value = value;
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06003F65 RID: 16229 RVA: 0x003BA0DC File Offset: 0x003B82DC
		// (set) Token: 0x06003F66 RID: 16230 RVA: 0x003BA190 File Offset: 0x003B8390
		public string RadWideTPSPTTTransmission_A41545_UIValue
		{
			get
			{
				short num = (short)2127199358;
				short num2 = num;
				num = (short)1365212286;
				switch (num2 == num)
				{
				}
				num = (short)1517289472;
				if (num != 0)
				{
				}
				num = (short)501415937;
				if (num != 0)
				{
				}
				num = (short)1266352128;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.UIValue;
			}
			set
			{
				short num = (short)1767194465;
				short num2 = num;
				num = (short)855129953;
				switch (num2 == num)
				{
				}
				num = (short)846659585;
				if (num != 0)
				{
				}
				num = (short)1730347008;
				if (num != 0)
				{
				}
				num = (short)829620224;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.UIValue = value;
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x003BA244 File Offset: 0x003B8444
		public global::AcpBusinessLayer.AcpListField RadWideTPSPTTTransmission_A41545
		{
			get
			{
				short num = (short)379953539;
				short num2 = num;
				num = (short)22258051;
				switch (num2 == num)
				{
				}
				num = (short)503447552;
				if (num != 0)
				{
				}
				num = (short)1614544897;
				if (num != 0)
				{
				}
				num = (short)436797440;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545;
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x003BA2F4 File Offset: 0x003B84F4
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x003BA3A8 File Offset: 0x003B85A8
		public bool RadWideTPSPTTTransmission_A41545_Applicable
		{
			get
			{
				short num = (short)121653026;
				short num2 = num;
				num = (short)378947362;
				switch (num2 == num)
				{
				}
				num = (short)1367670785;
				if (num != 0)
				{
				}
				num = (short)2068447232;
				if (num != 0)
				{
				}
				num = (short)1852440576;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.Applicable;
			}
			set
			{
				short num = (short)1959263588;
				short num2 = num;
				num = (short)1174404452;
				switch (num2 == num)
				{
				}
				num = (short)1510604801;
				if (num != 0)
				{
				}
				num = (short)2041643008;
				if (num != 0)
				{
				}
				num = (short)1782972416;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.Applicable = value;
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x003BA460 File Offset: 0x003B8660
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x003BA514 File Offset: 0x003B8714
		public bool RadWideTPSPTTTransmission_A41545_Valid
		{
			get
			{
				short num = (short)1111165165;
				short num2 = num;
				num = (short)1201080557;
				switch (num2 == num)
				{
				}
				num = (short)712441857;
				if (num != 0)
				{
				}
				num = (short)1221328896;
				if (num != 0)
				{
				}
				num = (short)528285696;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.Valid;
			}
			set
			{
				short num = (short)1564744544;
				short num2 = num;
				num = (short)1066605408;
				switch (num2 == num)
				{
				}
				num = (short)776732673;
				if (num != 0)
				{
				}
				num = (short)744685568;
				if (num != 0)
				{
				}
				num = (short)1335558144;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.Valid = value;
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x003BA5CC File Offset: 0x003B87CC
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x003BA680 File Offset: 0x003B8880
		public bool RadWideTPSPTTTransmission_A41545_Visible
		{
			get
			{
				short num = (short)1158760736;
				short num2 = num;
				num = (short)1620134176;
				switch (num2 == num)
				{
				}
				num = (short)1986854912;
				if (num != 0)
				{
				}
				num = (short)870907905;
				if (num != 0)
				{
				}
				num = (short)891486208;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.Visible;
			}
			set
			{
				short num = (short)761654151;
				short num2 = num;
				num = (short)413854599;
				switch (num2 == num)
				{
				}
				num = (short)491323393;
				if (num != 0)
				{
				}
				num = (short)821821440;
				if (num != 0)
				{
				}
				num = (short)1065943040;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.Visible = value;
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x003BA738 File Offset: 0x003B8938
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x003BA7EC File Offset: 0x003B89EC
		public bool RadWideTPSPTTTransmission_A41545_Editable
		{
			get
			{
				short num = (short)65597625;
				short num2 = num;
				num = (short)967635129;
				switch (num2 == num)
				{
				}
				num = (short)1604190208;
				if (num != 0)
				{
				}
				num = (short)1880293377;
				if (num != 0)
				{
				}
				num = (short)1748959232;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.Editable;
			}
			set
			{
				short num = (short)1821563081;
				short num2 = num;
				num = (short)1031067849;
				switch (num2 == num)
				{
				}
				num = (short)1397948417;
				if (num != 0)
				{
				}
				num = (short)28180480;
				if (num != 0)
				{
				}
				num = (short)930742272;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.Editable = value;
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x003BA8A4 File Offset: 0x003B8AA4
		internal string RadWideTPSPTTTransmission_A41545_UILabel
		{
			get
			{
				short num = (short)1019362534;
				short num2 = num;
				num = (short)474692838;
				switch (num2 == num)
				{
				}
				num = (short)588906497;
				if (num != 0)
				{
				}
				num = (short)603717632;
				if (num != 0)
				{
				}
				num = (short)1360723968;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.UIName;
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x003BA95C File Offset: 0x003B8B5C
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x003BAA10 File Offset: 0x003B8C10
		internal bool RadWideTPSPTTTransmission_A41545_HiddenStatic
		{
			get
			{
				short num = (short)2144585472;
				short num2 = num;
				num = (short)983484160;
				switch (num2 == num)
				{
				}
				num = (short)352518145;
				if (num != 0)
				{
				}
				num = (short)1951858688;
				if (num != 0)
				{
				}
				num = (short)1494941696;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.HiddenStatic;
			}
			set
			{
				short num = (short)1584469605;
				short num2 = num;
				num = (short)808130149;
				switch (num2 == num)
				{
				}
				num = (short)1897398273;
				if (num != 0)
				{
				}
				num = (short)426967040;
				if (num != 0)
				{
				}
				num = (short)446758912;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.HiddenStatic = value;
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x003BAAC8 File Offset: 0x003B8CC8
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x003BAB80 File Offset: 0x003B8D80
		internal bool RadWideTPSPTTTransmission_A41545_HiddenDynamic
		{
			get
			{
				short num = (short)1702549552;
				short num2 = num;
				num = (short)918804528;
				switch (num2 == num)
				{
				}
				num = (short)2098266113;
				if (num != 0)
				{
				}
				num = (short)2042036224;
				if (num != 0)
				{
				}
				num = (short)1798963200;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545.HiddenDynamic;
			}
			set
			{
				short num = (short)572063745;
				if (num != 0)
				{
				}
				num = (short)292851104;
				short num2 = num;
				num = (short)1133940128;
				switch (num2 == num)
				{
				}
				num = (short)486014976;
				if (num != 0)
				{
				}
				num = (short)920977408;
				short num3 = num;
				this.radWideTPSPTTTransmission_A41545.HiddenDynamic = value;
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x003BAC38 File Offset: 0x003B8E38
		public bool RadWideTPSPTTTransmission_A41545_HasDiffs
		{
			get
			{
				short num = (short)963238813;
				short num2 = num;
				num = (short)1525210013;
				switch (num2 == num)
				{
				}
				num = (short)1044512768;
				if (num != 0)
				{
				}
				num = (short)1040318465;
				if (num != 0)
				{
				}
				num = (short)183435264;
				short num3 = num;
				return this.radWideTPSPTTTransmission_A41545._HasDiffs;
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x003BACE8 File Offset: 0x003B8EE8
		// (set) Token: 0x06003F77 RID: 16247 RVA: 0x003BAD9C File Offset: 0x003B8F9C
		public int RadWideTPSAudibleEmergencyBeaconRouting_A41972Value
		{
			get
			{
				short num = (short)1984299009;
				if (num != 0)
				{
				}
				num = (short)2016515653;
				short num2 = num;
				num = (short)682595909;
				switch (num2 == num)
				{
				}
				num = (short)1191706624;
				if (num != 0)
				{
				}
				num = (short)1341980672;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Value;
			}
			set
			{
				short num = (short)1914522095;
				short num2 = num;
				num = (short)1061243375;
				switch (num2 == num)
				{
				}
				num = (short)257294336;
				if (num != 0)
				{
				}
				num = (short)26542081;
				if (num != 0)
				{
				}
				num = (short)1364983808;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Value = value;
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x003BAE54 File Offset: 0x003B9054
		// (set) Token: 0x06003F79 RID: 16249 RVA: 0x003BAF08 File Offset: 0x003B9108
		public string RadWideTPSAudibleEmergencyBeaconRouting_A41972_UIValue
		{
			get
			{
				short num = (short)429391873;
				if (num != 0)
				{
				}
				num = (short)101877258;
				short num2 = num;
				num = (short)1629193738;
				switch (num2 == num)
				{
				}
				num = (short)1624440832;
				if (num != 0)
				{
				}
				num = (short)1634598912;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.UIValue;
			}
			set
			{
				short num = (short)2060711237;
				short num2 = num;
				num = (short)1716385093;
				switch (num2 == num)
				{
				}
				num = (short)75759616;
				if (num != 0)
				{
				}
				num = (short)325255169;
				if (num != 0)
				{
				}
				num = (short)110100480;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.UIValue = value;
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06003F7A RID: 16250 RVA: 0x003BAFBC File Offset: 0x003B91BC
		public global::AcpBusinessLayer.AcpListField RadWideTPSAudibleEmergencyBeaconRouting_A41972
		{
			get
			{
				short num = (short)453902337;
				if (num != 0)
				{
				}
				num = (short)1770634308;
				short num2 = num;
				num = (short)1013562436;
				switch (num2 == num)
				{
				}
				num = (short)1780940800;
				if (num != 0)
				{
				}
				num = (short)115867648;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972;
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x003BB068 File Offset: 0x003B9268
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x003BB120 File Offset: 0x003B9320
		public bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_Applicable
		{
			get
			{
				short num = (short)1499808128;
				short num2 = num;
				num = (short)1131233664;
				switch (num2 == num)
				{
				}
				num = (short)1609826305;
				if (num != 0)
				{
				}
				num = (short)652607488;
				if (num != 0)
				{
				}
				num = (short)479330304;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Applicable;
			}
			set
			{
				short num = (short)1626582418;
				short num2 = num;
				num = (short)567782802;
				switch (num2 == num)
				{
				}
				num = (short)1114374145;
				if (num != 0)
				{
				}
				num = (short)815464448;
				if (num != 0)
				{
				}
				num = (short)1537605632;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Applicable = value;
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06003F7D RID: 16253 RVA: 0x003BB1D8 File Offset: 0x003B93D8
		// (set) Token: 0x06003F7E RID: 16254 RVA: 0x003BB28C File Offset: 0x003B948C
		public bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_Valid
		{
			get
			{
				short num = (short)964362241;
				if (num != 0)
				{
				}
				num = (short)1021651680;
				short num2 = num;
				num = (short)999172832;
				switch (num2 == num)
				{
				}
				num = (short)768016384;
				if (num != 0)
				{
				}
				num = (short)1512833024;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Valid;
			}
			set
			{
				short num = (short)194846068;
				short num2 = num;
				num = (short)1556815220;
				switch (num2 == num)
				{
				}
				num = (short)971505665;
				if (num != 0)
				{
				}
				num = (short)47120384;
				if (num != 0)
				{
				}
				num = (short)1410138112;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Valid = value;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x003BB340 File Offset: 0x003B9540
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x003BB3F4 File Offset: 0x003B95F4
		public bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_Visible
		{
			get
			{
				short num = (short)81002497;
				if (num != 0)
				{
				}
				num = (short)1467821587;
				short num2 = num;
				num = (short)858992147;
				switch (num2 == num)
				{
				}
				num = (short)740884480;
				if (num != 0)
				{
				}
				num = (short)851836928;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Visible;
			}
			set
			{
				short num = (short)506975377;
				short num2 = num;
				num = (short)1722537105;
				switch (num2 == num)
				{
				}
				num = (short)262864897;
				if (num != 0)
				{
				}
				num = (short)1615069184;
				if (num != 0)
				{
				}
				num = (short)41156608;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Visible = value;
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x003BB4A8 File Offset: 0x003B96A8
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x003BB55C File Offset: 0x003B975C
		public bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_Editable
		{
			get
			{
				short num = (short)914923115;
				short num2 = num;
				num = (short)855613035;
				switch (num2 == num)
				{
				}
				num = (short)57016321;
				if (num != 0)
				{
				}
				num = (short)1907032064;
				if (num != 0)
				{
				}
				num = (short)1307115520;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Editable;
			}
			set
			{
				short num = (short)2021185545;
				short num2 = num;
				num = (short)1922553865;
				switch (num2 == num)
				{
				}
				num = (short)1491337216;
				if (num != 0)
				{
				}
				num = (short)998244353;
				if (num != 0)
				{
				}
				num = (short)1215037440;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.Editable = value;
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x003BB610 File Offset: 0x003B9810
		internal string RadWideTPSAudibleEmergencyBeaconRouting_A41972_UILabel
		{
			get
			{
				short num = (short)1566743152;
				short num2 = num;
				num = (short)1320589936;
				switch (num2 == num)
				{
				}
				num = (short)1461714945;
				if (num != 0)
				{
				}
				num = (short)935591936;
				if (num != 0)
				{
				}
				num = (short)1248395264;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.UIName;
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x003BB6C4 File Offset: 0x003B98C4
		// (set) Token: 0x06003F85 RID: 16261 RVA: 0x003BB778 File Offset: 0x003B9978
		internal bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_HiddenStatic
		{
			get
			{
				short num = (short)5327747;
				short num2 = num;
				num = (short)1900825475;
				switch (num2 == num)
				{
				}
				num = (short)211746816;
				if (num != 0)
				{
				}
				num = (short)1151401985;
				if (num != 0)
				{
				}
				num = (short)1108082688;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.HiddenStatic;
			}
			set
			{
				short num = (short)1018351321;
				short num2 = num;
				num = (short)1048301273;
				switch (num2 == num)
				{
				}
				num = (short)403505153;
				if (num != 0)
				{
				}
				num = (short)536215552;
				if (num != 0)
				{
				}
				num = (short)1361575936;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.HiddenStatic = value;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x003BB830 File Offset: 0x003B9A30
		// (set) Token: 0x06003F87 RID: 16263 RVA: 0x003BB8E8 File Offset: 0x003B9AE8
		internal bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_HiddenDynamic
		{
			get
			{
				short num = (short)1063581317;
				short num2 = num;
				num = (short)2100819589;
				switch (num2 == num)
				{
				}
				num = (short)2135949312;
				if (num != 0)
				{
				}
				num = (short)2066546689;
				if (num != 0)
				{
				}
				num = (short)1385824256;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972.HiddenDynamic;
			}
			set
			{
				short num = (short)924078304;
				short num2 = num;
				num = (short)230576352;
				switch (num2 == num)
				{
				}
				num = (short)796721153;
				if (num != 0)
				{
				}
				num = (short)50790400;
				if (num != 0)
				{
				}
				num = (short)490209280;
				short num3 = num;
				this.radWideTPSAudibleEmergencyBeaconRouting_A41972.HiddenDynamic = value;
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x003BB99C File Offset: 0x003B9B9C
		public bool RadWideTPSAudibleEmergencyBeaconRouting_A41972_HasDiffs
		{
			get
			{
				short num = (short)1828845139;
				short num2 = num;
				num = (short)1134360147;
				switch (num2 == num)
				{
				}
				num = (short)536608768;
				if (num != 0)
				{
				}
				num = (short)1069416449;
				if (num != 0)
				{
				}
				num = (short)538640384;
				short num3 = num;
				return this.radWideTPSAudibleEmergencyBeaconRouting_A41972._HasDiffs;
			}
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x003BBA54 File Offset: 0x003B9C54
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)899841736;
				short num2 = num;
				num = (short)1643937480;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FB;
				default:
					num = (short)164233216;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1435041795;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1512570880;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					case 2:
						num = (short)452984833;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_FB;
					case 4:
						if (base.ParentRecset != null)
						{
							num = (short)516096002;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					}
					goto IL_6E;
				}
			}
			IL_FB:
			IL_13B:
			num = (short)1402667008;
			short num4 = num;
			return result;
			IL_6E:
			result = null;
			num = (short)1324875777;
			if (num != 0)
			{
			}
			num = (short)539885572;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040019EE RID: 6638
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideTPSAudibleEmergencyBeaconsec_A7502;

		// Token: 0x040019EF RID: 6639
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;

		// Token: 0x040019F0 RID: 6640
		private global::AcpBusinessLayer.AcpField<bool> radWideTPSFiregroundEmergencyCallDekeySidetone_A7936;

		// Token: 0x040019F1 RID: 6641
		private global::AcpBusinessLayer.AcpField<bool> radWideTPSFiregroundVoiceTxEndTone_A9655;

		// Token: 0x040019F2 RID: 6642
		private global::AcpBusinessLayer.AcpListField radWideTPSEmergencyPTTTransmission_A41544;

		// Token: 0x040019F3 RID: 6643
		private global::AcpBusinessLayer.AcpListField radWideTPSPTTTransmission_A41545;

		// Token: 0x040019F4 RID: 6644
		private global::AcpBusinessLayer.AcpListField radWideTPSAudibleEmergencyBeaconRouting_A41972;
	}
}
