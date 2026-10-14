using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000F0 RID: 240
	[global::System.Serializable]
	public class DataTransport : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600242B RID: 9259 RVA: 0x00238F78 File Offset: 0x00237178
		public DataTransport(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00238F94 File Offset: 0x00237194
		protected DataTransport(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00238FAC File Offset: 0x002371AC
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1713293580;
			short num2 = num;
			num = (short)702662924;
			switch (num2 == num)
			{
			}
			num = (short)2050949120;
			short num3 = num;
			num = (short)1091960832;
			if (num != 0)
			{
			}
			num = (short)727121921;
			if (num != 0)
			{
			}
			this.secKmfProfDataTransportKMFUDPPort_A8384 = new global::AcpBusinessLayer.AcpSimpleRangeField(64414, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵귷뻹곻껽濿瀁瀃夅䤇㈉㼋㘍␏", a_), global::CommonResources.AcgResources.ID_KMFUDPPORT, 0, 65535, null, null, 0, 1);
			this.secKmfProfDataTransportKMFUDPPort_A8384.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfDataTransportKMFUDPPort_A8384.DataTransferOrder = 12;
			this.secKmfProfDataTransportKMFUDPPort_A8384.ShowHexValue = false;
			this.secKmfProfDataTransportSubscriberOTARPort_A9226 = new global::AcpBusinessLayer.AcpSimpleRangeField(64414, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯ꇱ至铵请駹軻韽拿朁瘃䤅將䬉帋帍缏怑怓䤕夗⌙⸛Ⱍᘟ", a_), global::CommonResources.AcgResources.ID_SUBSCRIBEROTARPORT, 0, 65535, null, null, 0, 1);
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.DataTransferOrder = 13;
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.ShowHexValue = false;
			this.secKmfProfDataTransportKMFIPAddress_A8375 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵뇷꫹뷻髽擿瀁愃甅笇唉䴋㘍⌏┑ℓ", a_), global::CommonResources.AcgResources.ID_KMFIPADDRESS);
			this.secKmfProfDataTransportKMFIPAddress_A8375.SkipValidation = true;
			this.secKmfProfDataTransportKMFIPAddress_A8375.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfDataTransportKMFIPAddress_A8375.DataTransferOrder = 14;
			this.secKmfProfDataTransportKMFIPAddress_A8375.EvaluateRecRefs = true;
			this.secKmfProfDataTransportOTARTransport = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯뷱ꃳ럵꫷껹軻鿽滿焁球椅稇縉", a_), global::CommonResources.AcgResources.ID_OTAR_TRANSPORT, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfDataTransportOTARTransportLovStrs);
			this.secKmfProfDataTransportOTARTransport.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfDataTransportOTARTransport.DataTransferOrder = 15;
			this.secKmfProfDataTransportKMFBroadbandId = new global::AcpBusinessLayer.AcpStringField("", this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵뫷裹鏻鿽擿态攃栅氇䌉栋", a_), global::CommonResources.AcgResources.ID_KMF_BROADBAND_ID, 32);
			this.secKmfProfDataTransportKMFBroadbandId.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfDataTransportKMFBroadbandId.DataTransferOrder = 16;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ髍ꋏ돑뫓ꗕ꣗뗙껛ꫝ", a_);
			base.Id = 10125;
			base.UIName = global::CommonResources.AcgResources.ID_DATATRANSPORT;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00239208 File Offset: 0x00237408
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)1150353416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.secKmfProfDataTransportKMFBroadbandId = new global::AcpBusinessLayer.AcpStringField("", this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵뫷裹鏻鿽擿态攃栅氇䌉栋", a_), global::CommonResources.AcgResources.ID_KMF_BROADBAND_ID, 32);
					this.secKmfProfDataTransportKMFBroadbandId.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfDataTransportKMFBroadbandId.DataTransferOrder = 16;
					num = (short)1815871500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_9F;
				case 2:
					goto IL_1D7;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵뇷꫹뷻髽擿瀁愃甅笇唉䴋㘍⌏┑ℓ", a_)))
					{
						num = (short)1822490640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵뫷裹鏻鿽擿态攃栅氇䌉栋", a_)))
					{
						num = (short)1043529728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4EE;
				case 5:
					this.secKmfProfDataTransportKMFUDPPort_A8384 = new global::AcpBusinessLayer.AcpSimpleRangeField(64414, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵귷뻹곻껽濿瀁瀃夅䤇㈉㼋㘍␏", a_), global::CommonResources.AcgResources.ID_KMFUDPPORT, null, null, 0, 1);
					this.secKmfProfDataTransportKMFUDPPort_A8384.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfDataTransportKMFUDPPort_A8384.DataTransferOrder = 12;
					this.secKmfProfDataTransportKMFUDPPort_A8384.ShowHexValue = false;
					num = (short)1980891150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.secKmfProfDataTransportSubscriberOTARPort_A9226 = new global::AcpBusinessLayer.AcpSimpleRangeField(64414, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯ꇱ至铵请駹軻韽拿朁瘃䤅將䬉帋帍缏怑怓䤕夗⌙⸛Ⱍᘟ", a_), global::CommonResources.AcgResources.ID_SUBSCRIBEROTARPORT, null, null, 0, 1);
					this.secKmfProfDataTransportSubscriberOTARPort_A9226.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfDataTransportSubscriberOTARPort_A9226.DataTransferOrder = 13;
					this.secKmfProfDataTransportSubscriberOTARPort_A9226.ShowHexValue = false;
					num = (short)1707081746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯ꇱ至铵请駹軻韽拿朁瘃䤅將䬉帋帍缏怑怓䤕夗⌙⸛Ⱍᘟ", a_)))
					{
						num = (short)1931935750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 9:
					num = (short)114819083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵귷뻹곻껽濿瀁瀃夅䤇㈉㼋㘍␏", a_)))
					{
						num = (short)413073413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A1;
				case 11:
					if (producerFields != null)
					{
						goto IL_243;
					}
					goto IL_4EE;
				case 12:
					goto IL_35C;
				case 13:
					num = (short)694943754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_4A1;
				case 15:
				{
					this.secKmfProfDataTransportOTARTransport = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯뷱ꃳ럵꫷껹軻鿽滿焁球椅稇縉", a_), global::CommonResources.AcgResources.ID_OTAR_TRANSPORT, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LOVs.SecKmfProfDataTransportOTARTransportLovStrs);
					this.secKmfProfDataTransportOTARTransport.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secKmfProfDataTransportOTARTransport.DataTransferOrder = 15;
					num = (short)683148395;
					short num3 = num;
					num = (short)2047870059;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_243;
					default:
						num = (short)124452864;
						if (num != 0)
						{
						}
						num = (short)1158873090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					this.secKmfProfDataTransportKMFIPAddress_A8375 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯맱맳냵뇷꫹뷻髽擿瀁愃甅笇唉䴋㘍⌏┑ℓ", a_), global::CommonResources.AcgResources.ID_KMFIPADDRESS);
					this.secKmfProfDataTransportKMFIPAddress_A8375.SkipValidation = true;
					this.secKmfProfDataTransportKMFIPAddress_A8375.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfDataTransportKMFIPAddress_A8375.DataTransferOrder = 14;
					this.secKmfProfDataTransportKMFIPAddress_A8375.EvaluateRecRefs = true;
					num = (short)862060545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					num = (short)1713242113;
					if (num != 0)
					{
					}
					num = (short)2051473408;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韃ꏅꯇ臉ꇋ꣍胏ꃑ믓냕鳗믙꣛뿝듟郡藣裥鯧髩菫鳭蓯뷱ꃳ럵꫷껹軻鿽滿焁球椅稇縉", a_)))
					{
						num = (short)1561133071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D7;
				}
				case 18:
					goto IL_13D;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1291386889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9F:
				num = (short)1721630737;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13D:
				num = (short)1271857155;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D7:
				num = (short)1363935236;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_243:
				num = (short)568131597;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A1:
				num = (short)1622147079;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_35C:
			IL_4EE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ髍ꋏ돑뫓ꗕ꣗뗙껛ꫝ", a_);
			base.Id = 10125;
			base.UIName = global::CommonResources.AcgResources.ID_DATATRANSPORT;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00239734 File Offset: 0x00237934
		public override void PopulateReferences()
		{
			short num = (short)1967956348;
			short num2 = num;
			num = (short)2139136380;
			switch (num2 == num)
			{
			}
			num = (short)304414720;
			short num3 = num;
			num = (short)1346109440;
			if (num != 0)
			{
			}
			num = (short)634978305;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x002397DC File Offset: 0x002379DC
		public override void DropReferences()
		{
			short num = (short)1427774479;
			short num2 = num;
			num = (short)2103581711;
			switch (num2 == num)
			{
			}
			num = (short)339804160;
			short num3 = num;
			num = (short)1274544128;
			if (num != 0)
			{
			}
			num = (short)419037185;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00239888 File Offset: 0x00237A88
		public override void SetConstraints()
		{
			short num = (short)200426117;
			short num2 = num;
			num = (short)1297891973;
			switch (num2 == num)
			{
			}
			num = (short)2043936768;
			short num3 = num;
			num = (short)1891500033;
			if (num != 0)
			{
			}
			num = (short)783941632;
			if (num != 0)
			{
			}
			this.secKmfProfDataTransportKMFUDPPort_A8384.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConTriggerPortNumValid);
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConTriggerPortNumValid);
			this.secKmfProfDataTransportKMFIPAddress_A8375.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConRadWideAstroOtarEnabledAndOtarEnabledAndSecureOpIsHardware);
			this.secKmfProfDataTransportKMFIPAddress_A8375.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.conIPAddressValidate);
			this.secKmfProfDataTransportOTARTransport.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConOTARTransportIsApplicable);
			this.secKmfProfDataTransportKMFBroadbandId.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConKMFBroadbandIdIsApplicableIsEditable);
			this.secKmfProfDataTransportKMFBroadbandId.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConKMFBroadbandIdIsApplicableIsEditable);
			this.secKmfProfDataTransportKMFBroadbandId.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConKMFBroadbandIdIsValid);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x002399E8 File Offset: 0x00237BE8
		public override void SetupDependencies()
		{
			short num = (short)1943290541;
			short num2 = num;
			num = (short)835601069;
			switch (num2 == num)
			{
			}
			num = (short)1766653952;
			short num3 = num;
			num = (short)643694593;
			if (num != 0)
			{
			}
			num = (short)1772421120;
			if (num != 0)
			{
			}
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfDataTransportKMFUDPPort_A8384);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfDataTransportKMFUDPPort_A8384);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfDataTransportKMFUDPPort_A8384);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfDataTransportKMFUDPPort_A8384);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfDataTransportSubscriberOTARPort_A9226);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfDataTransportSubscriberOTARPort_A9226);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfDataTransportSubscriberOTARPort_A9226);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfDataTransportSubscriberOTARPort_A9226);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfDataTransportKMFIPAddress_A8375);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfDataTransportKMFIPAddress_A8375);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfDataTransportKMFIPAddress_A8375);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfDataTransportKMFIPAddress_A8375);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.secKmfProfDataTransportKMFIPAddress_A8375);
			this.secKmfProfDataTransportKMFUDPPort_A8384.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413);
			this.secKmfProfDataTransportKMFUDPPort_A8384.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627);
			this.secKmfProfDataTransportKMFUDPPort_A8384.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022);
			this.secKmfProfDataTransportKMFUDPPort_A8384.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205);
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413);
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627);
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022);
			this.secKmfProfDataTransportSubscriberOTARPort_A9226.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfDataTransportOTARTransport);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfDataTransportOTARTransport);
			this.RefSecureWide.General.SecWideGeneralOTAROperation_43700.AddDependentObject(this.secKmfProfDataTransportOTARTransport);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfDataTransportKMFBroadbandId);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfDataTransportKMFBroadbandId);
			this.RefSecureWide.General.SecWideGeneralOTAROperation_43700.AddDependentObject(this.secKmfProfDataTransportKMFBroadbandId);
			this.secKmfProfDataTransportOTARTransport.AddDependentObject(this.secKmfProfDataTransportKMFBroadbandId);
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x00239E38 File Offset: 0x00238038
		public bool HasDiffs
		{
			get
			{
				short num = (short)1726714674;
				short num2 = num;
				num = (short)397906738;
				switch (num2 == num)
				{
				}
				num = (short)683671552;
				short num3 = num;
				num = (short)1609891841;
				if (num != 0)
				{
				}
				num = (short)226361344;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x00239EE8 File Offset: 0x002380E8
		// (set) Token: 0x06002435 RID: 9269 RVA: 0x00239F9C File Offset: 0x0023819C
		public int SecKmfProfDataTransportKMFUDPPort_A8384Value
		{
			get
			{
				short num = (short)1424498898;
				short num2 = num;
				num = (short)697508050;
				switch (num2 == num)
				{
				}
				num = (short)2121269248;
				short num3 = num;
				num = (short)334888961;
				if (num != 0)
				{
				}
				num = (short)341442560;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Value;
			}
			set
			{
				short num = (short)1919960810;
				short num2 = num;
				num = (short)1882277610;
				switch (num2 == num)
				{
				}
				num = (short)1426784256;
				short num3 = num;
				num = (short)555941888;
				if (num != 0)
				{
				}
				num = (short)1270218753;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Value = value;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x0023A054 File Offset: 0x00238254
		public global::AcpBusinessLayer.AcpSimpleRangeField SecKmfProfDataTransportKMFUDPPort_A8384
		{
			get
			{
				short num = (short)1237066767;
				short num2 = num;
				num = (short)390276111;
				switch (num2 == num)
				{
				}
				num = (short)1286602752;
				short num3 = num;
				num = (short)688390145;
				if (num != 0)
				{
				}
				num = (short)292421632;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x0023A100 File Offset: 0x00238300
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x0023A1B4 File Offset: 0x002383B4
		public string SecKmfProfDataTransportKMFUDPPort_A8384_UIValue
		{
			get
			{
				short num = (short)1592478662;
				short num2 = num;
				num = (short)696601542;
				switch (num2 == num)
				{
				}
				num = (short)1351614464;
				short num3 = num;
				num = (short)891289600;
				if (num != 0)
				{
				}
				num = (short)1387855873;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.UIValue;
			}
			set
			{
				short num = (short)552234015;
				short num2 = num;
				num = (short)78801951;
				switch (num2 == num)
				{
				}
				num = (short)744751104;
				short num3 = num;
				num = (short)1700462593;
				if (num != 0)
				{
				}
				num = (short)70844416;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.UIValue = value;
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x0023A26C File Offset: 0x0023846C
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x0023A320 File Offset: 0x00238520
		internal int SecKmfProfDataTransportKMFUDPPort_A8384Min
		{
			get
			{
				short num = (short)1623540273;
				short num2 = num;
				num = (short)1869955633;
				switch (num2 == num)
				{
				}
				num = (short)38862848;
				short num3 = num;
				num = (short)358023169;
				if (num != 0)
				{
				}
				num = (short)1339817984;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Min;
			}
			set
			{
				short num = (short)769139108;
				short num2 = num;
				num = (short)2060067236;
				switch (num2 == num)
				{
				}
				num = (short)605028352;
				short num3 = num;
				num = (short)1481637889;
				if (num != 0)
				{
				}
				num = (short)989921280;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Min = value;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x0023A3D4 File Offset: 0x002385D4
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x0023A488 File Offset: 0x00238688
		internal int SecKmfProfDataTransportKMFUDPPort_A8384Max
		{
			get
			{
				short num = (short)521753330;
				short num2 = num;
				num = (short)967135986;
				switch (num2 == num)
				{
				}
				num = (short)1328807936;
				short num3 = num;
				num = (short)1121255425;
				if (num != 0)
				{
				}
				num = (short)849870848;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Max;
			}
			set
			{
				short num = (short)801242711;
				short num2 = num;
				num = (short)1285226071;
				switch (num2 == num)
				{
				}
				num = (short)168624128;
				short num3 = num;
				num = (short)533069824;
				if (num != 0)
				{
				}
				num = (short)275972097;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Max = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x0023A540 File Offset: 0x00238740
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x0023A5F4 File Offset: 0x002387F4
		internal int SecKmfProfDataTransportKMFUDPPort_A8384Step
		{
			get
			{
				short num = (short)384139630;
				short num2 = num;
				num = (short)1354858862;
				switch (num2 == num)
				{
				}
				num = (short)629997568;
				short num3 = num;
				num = (short)464519168;
				if (num != 0)
				{
				}
				num = (short)1679622145;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.StepSize;
			}
			set
			{
				short num = (short)829119120;
				short num2 = num;
				num = (short)906713744;
				switch (num2 == num)
				{
				}
				num = (short)2144468992;
				short num3 = num;
				num = (short)517275649;
				if (num != 0)
				{
				}
				num = (short)1950351360;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.StepSize = value;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x0023A6AC File Offset: 0x002388AC
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x0023A760 File Offset: 0x00238960
		public bool SecKmfProfDataTransportKMFUDPPort_A8384_Applicable
		{
			get
			{
				short num = (short)285620094;
				short num2 = num;
				num = (short)1920808830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526857728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112684033;
				if (num != 0)
				{
				}
				num = (short)592904192;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Applicable;
			}
			set
			{
				short num = (short)1943955601;
				short num2 = num;
				num = (short)634022033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139684864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)872808449;
				if (num != 0)
				{
				}
				num = (short)118095872;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Applicable = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0023A814 File Offset: 0x00238A14
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x0023A8C8 File Offset: 0x00238AC8
		public bool SecKmfProfDataTransportKMFUDPPort_A8384_Valid
		{
			get
			{
				short num = (short)761157312;
				short num2 = num;
				num = (short)2062964416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)860422144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1377566720;
				if (num != 0)
				{
				}
				num = (short)1583808513;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Valid;
			}
			set
			{
				short num = (short)323289089;
				if (num != 0)
				{
				}
				num = (short)880607232;
				short num2 = num;
				num = (short)1189137618;
				short num3 = num;
				num = (short)1422576850;
				switch (num3 == num)
				{
				}
				num = (short)1730805760;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Valid = value;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0023A980 File Offset: 0x00238B80
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x0023AA34 File Offset: 0x00238C34
		public bool SecKmfProfDataTransportKMFUDPPort_A8384_Visible
		{
			get
			{
				short num = (short)467085261;
				short num2 = num;
				num = (short)391718861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202716672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61079553;
				if (num != 0)
				{
				}
				num = (short)1256456192;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Visible;
			}
			set
			{
				short num = (short)1518132308;
				short num2 = num;
				num = (short)133553236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)661127168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790495232;
				if (num != 0)
				{
				}
				num = (short)329711617;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Visible = value;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0023AAE8 File Offset: 0x00238CE8
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0023AB9C File Offset: 0x00238D9C
		public bool SecKmfProfDataTransportKMFUDPPort_A8384_Editable
		{
			get
			{
				short num = (short)470714228;
				short num2 = num;
				num = (short)2046986100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309671424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624571905;
				if (num != 0)
				{
				}
				num = (short)31784960;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.Editable;
			}
			set
			{
				short num = (short)274333697;
				if (num != 0)
				{
				}
				num = (short)1378746368;
				short num2 = num;
				num = (short)532636876;
				short num3 = num;
				num = (short)914253004;
				switch (num3 == num)
				{
				}
				num = (short)1676607488;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.Editable = value;
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0023AC50 File Offset: 0x00238E50
		internal string SecKmfProfDataTransportKMFUDPPort_A8384_UILabel
		{
			get
			{
				short num = (short)1391584435;
				short num2 = num;
				num = (short)119727283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)805044224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1332346881;
				if (num != 0)
				{
				}
				num = (short)1716060160;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.UIName;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0023AD04 File Offset: 0x00238F04
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0023ADBC File Offset: 0x00238FBC
		internal bool SecKmfProfDataTransportKMFUDPPort_A8384_HiddenStatic
		{
			get
			{
				short num = (short)732075548;
				short num2 = num;
				num = (short)177051164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1609105408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1864368128;
				if (num != 0)
				{
				}
				num = (short)2042363905;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.HiddenStatic;
			}
			set
			{
				short num = (short)991629943;
				short num2 = num;
				num = (short)265818743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091188224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672137217;
				if (num != 0)
				{
				}
				num = (short)1329922048;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.HiddenStatic = value;
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0023AE74 File Offset: 0x00239074
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0023AF28 File Offset: 0x00239128
		internal bool SecKmfProfDataTransportKMFUDPPort_A8384_HiddenDynamic
		{
			get
			{
				short num = (short)1732125508;
				short num2 = num;
				num = (short)1427645252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1946419200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)112132097;
				if (num != 0)
				{
				}
				num = (short)710279168;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384.HiddenDynamic;
			}
			set
			{
				short num = (short)976859826;
				short num2 = num;
				num = (short)1545253554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)705232896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684930561;
				if (num != 0)
				{
				}
				num = (short)1495269376;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFUDPPort_A8384.HiddenDynamic = value;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x0023AFE0 File Offset: 0x002391E0
		public bool SecKmfProfDataTransportKMFUDPPort_A8384_HasDiffs
		{
			get
			{
				short num = (short)545810786;
				short num2 = num;
				num = (short)609315170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034092544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)561577985;
				if (num != 0)
				{
				}
				num = (short)553320448;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFUDPPort_A8384._HasDiffs;
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x0023B098 File Offset: 0x00239298
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x0023B150 File Offset: 0x00239350
		public int SecKmfProfDataTransportSubscriberOTARPort_A9226Value
		{
			get
			{
				short num = (short)1243613314;
				short num2 = num;
				num = (short)821299330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1160970240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649068545;
				if (num != 0)
				{
				}
				num = (short)619249664;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Value;
			}
			set
			{
				short num = (short)1452157151;
				short num2 = num;
				num = (short)886384863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611661312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2096889856;
				if (num != 0)
				{
				}
				num = (short)1127284737;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Value = value;
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0023B204 File Offset: 0x00239404
		public global::AcpBusinessLayer.AcpSimpleRangeField SecKmfProfDataTransportSubscriberOTARPort_A9226
		{
			get
			{
				short num = (short)849674241;
				if (num != 0)
				{
				}
				num = (short)625803264;
				short num2 = num;
				num = (short)518737964;
				short num3 = num;
				num = (short)247025708;
				switch (num3 == num)
				{
				}
				num = (short)1872560128;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226;
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x0023B2B4 File Offset: 0x002394B4
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x0023B36C File Offset: 0x0023956C
		public string SecKmfProfDataTransportSubscriberOTARPort_A9226_UIValue
		{
			get
			{
				short num = (short)1249947044;
				short num2 = num;
				num = (short)659467684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)130023424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)792920064;
				if (num != 0)
				{
				}
				num = (short)2040791041;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.UIValue;
			}
			set
			{
				short num = (short)1135036915;
				short num2 = num;
				num = (short)962218483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)585498624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120351745;
				if (num != 0)
				{
				}
				num = (short)896532480;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.UIValue = value;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x0023B428 File Offset: 0x00239628
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x0023B4E0 File Offset: 0x002396E0
		internal int SecKmfProfDataTransportSubscriberOTARPort_A9226Min
		{
			get
			{
				short num = (short)1486487553;
				if (num != 0)
				{
				}
				num = (short)1652621312;
				short num2 = num;
				num = (short)1329878899;
				short num3 = num;
				num = (short)2114213747;
				switch (num3 == num)
				{
				}
				num = (short)1724317696;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Min;
			}
			set
			{
				short num = (short)721223681;
				if (num != 0)
				{
				}
				num = (short)1677131776;
				short num2 = num;
				num = (short)702533520;
				short num3 = num;
				num = (short)592826256;
				switch (num3 == num)
				{
				}
				num = (short)1567031296;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Min = value;
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x0023B598 File Offset: 0x00239798
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0023B648 File Offset: 0x00239848
		internal int SecKmfProfDataTransportSubscriberOTARPort_A9226Max
		{
			get
			{
				short num = (short)2079783228;
				short num2 = num;
				num = (short)1950415164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1855782912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129920001;
				if (num != 0)
				{
				}
				num = (short)2042101760;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Max;
			}
			set
			{
				short num = (short)782817350;
				short num2 = num;
				num = (short)901044294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637599744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422852096;
				if (num != 0)
				{
				}
				num = (short)1091502081;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Max = value;
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x0023B6FC File Offset: 0x002398FC
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x0023B7B4 File Offset: 0x002399B4
		internal int SecKmfProfDataTransportSubscriberOTARPort_A9226Step
		{
			get
			{
				short num = (short)666410780;
				short num2 = num;
				num = (short)561684252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1349124096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788463617;
				if (num != 0)
				{
				}
				num = (short)659750912;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.StepSize;
			}
			set
			{
				short num = (short)1978138625;
				if (num != 0)
				{
				}
				num = (short)1317732352;
				short num2 = num;
				num = (short)916628835;
				short num3 = num;
				num = (short)282502499;
				switch (num3 == num)
				{
				}
				num = (short)1060175872;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.StepSize = value;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0023B868 File Offset: 0x00239A68
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x0023B91C File Offset: 0x00239B1C
		public bool SecKmfProfDataTransportSubscriberOTARPort_A9226_Applicable
		{
			get
			{
				short num = (short)316976472;
				short num2 = num;
				num = (short)1027190104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418723328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1072037889;
				if (num != 0)
				{
				}
				num = (short)223150080;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Applicable;
			}
			set
			{
				short num = (short)1640599056;
				short num2 = num;
				num = (short)309890576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38076416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1329070080;
				if (num != 0)
				{
				}
				num = (short)552534017;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Applicable = value;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x0023B9D4 File Offset: 0x00239BD4
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x0023BA88 File Offset: 0x00239C88
		public bool SecKmfProfDataTransportSubscriberOTARPort_A9226_Valid
		{
			get
			{
				short num = (short)1456784627;
				short num2 = num;
				num = (short)1194312947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1546518528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1663893505;
				if (num != 0)
				{
				}
				num = (short)1573453824;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Valid;
			}
			set
			{
				short num = (short)1354027115;
				short num2 = num;
				num = (short)1325781099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2045181952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523173888;
				if (num != 0)
				{
				}
				num = (short)899481601;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Valid = value;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x0023BB3C File Offset: 0x00239D3C
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x0023BBF0 File Offset: 0x00239DF0
		public bool SecKmfProfDataTransportSubscriberOTARPort_A9226_Visible
		{
			get
			{
				short num = (short)1727026390;
				short num2 = num;
				num = (short)2133021910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39714816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697054721;
				if (num != 0)
				{
				}
				num = (short)1245184000;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Visible;
			}
			set
			{
				short num = (short)32423653;
				short num2 = num;
				num = (short)1178844901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098186752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1161953281;
				if (num != 0)
				{
				}
				num = (short)1150943232;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Visible = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x0023BCA4 File Offset: 0x00239EA4
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x0023BD58 File Offset: 0x00239F58
		public bool SecKmfProfDataTransportSubscriberOTARPort_A9226_Editable
		{
			get
			{
				short num = (short)814700702;
				short num2 = num;
				num = (short)43800734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1807941632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939196416;
				if (num != 0)
				{
				}
				num = (short)78446593;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.Editable;
			}
			set
			{
				short num = (short)54129187;
				short num2 = num;
				num = (short)425652771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)939720704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331757057;
				if (num != 0)
				{
				}
				num = (short)2058485760;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.Editable = value;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0023BE10 File Offset: 0x0023A010
		internal string SecKmfProfDataTransportSubscriberOTARPort_A9226_UILabel
		{
			get
			{
				short num = (short)1575550977;
				if (num != 0)
				{
				}
				num = (short)550961152;
				short num2 = num;
				num = (short)358636337;
				short num3 = num;
				num = (short)794778417;
				switch (num3 == num)
				{
				}
				num = (short)1360527360;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.UIName;
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x0023BEC4 File Offset: 0x0023A0C4
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0023BF78 File Offset: 0x0023A178
		internal bool SecKmfProfDataTransportSubscriberOTARPort_A9226_HiddenStatic
		{
			get
			{
				short num = (short)1590820865;
				if (num != 0)
				{
				}
				num = (short)1292566528;
				short num2 = num;
				num = (short)1212068148;
				short num3 = num;
				num = (short)429961524;
				switch (num3 == num)
				{
				}
				num = (short)381485056;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.HiddenStatic;
			}
			set
			{
				short num = (short)479945251;
				short num2 = num;
				num = (short)2046911011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1405222912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1960640512;
				if (num != 0)
				{
				}
				num = (short)1848705025;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.HiddenStatic = value;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x0023C02C File Offset: 0x0023A22C
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0023C0E4 File Offset: 0x0023A2E4
		internal bool SecKmfProfDataTransportSubscriberOTARPort_A9226_HiddenDynamic
		{
			get
			{
				short num = (short)1546649601;
				if (num != 0)
				{
				}
				num = (short)1082982400;
				short num2 = num;
				num = (short)708621621;
				short num3 = num;
				num = (short)1793897781;
				switch (num3 == num)
				{
				}
				num = (short)1747779584;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226.HiddenDynamic;
			}
			set
			{
				short num = (short)2127166521;
				short num2 = num;
				num = (short)579009593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010185728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1247543296;
				if (num != 0)
				{
				}
				num = (short)1562968065;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportSubscriberOTARPort_A9226.HiddenDynamic = value;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x0023C19C File Offset: 0x0023A39C
		public bool SecKmfProfDataTransportSubscriberOTARPort_A9226_HasDiffs
		{
			get
			{
				short num = (short)276421790;
				short num2 = num;
				num = (short)942660766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)347734016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365180416;
				if (num != 0)
				{
				}
				num = (short)1781858305;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportSubscriberOTARPort_A9226._HasDiffs;
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x0023C250 File Offset: 0x0023A450
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x0023C304 File Offset: 0x0023A504
		public long SecKmfProfDataTransportKMFIPAddress_A8375Value
		{
			get
			{
				short num = (short)670811431;
				short num2 = num;
				num = (short)88130855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1629290496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1080950784;
				if (num != 0)
				{
				}
				num = (short)215613441;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.Value;
			}
			set
			{
				short num = (short)48600218;
				short num2 = num;
				num = (short)1726518426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187432960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933377537;
				if (num != 0)
				{
				}
				num = (short)1757872128;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.Value = value;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x0023C3B8 File Offset: 0x0023A5B8
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x0023C46C File Offset: 0x0023A66C
		public string SecKmfProfDataTransportKMFIPAddress_A8375_UIValue
		{
			get
			{
				short num = (short)1071906817;
				if (num != 0)
				{
				}
				num = (short)1495334912;
				short num2 = num;
				num = (short)1877466552;
				short num3 = num;
				num = (short)322756024;
				switch (num3 == num)
				{
				}
				num = (short)2138112000;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.UIValue;
			}
			set
			{
				short num = (short)1490902521;
				short num2 = num;
				num = (short)397565433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1267859456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1955004417;
				if (num != 0)
				{
				}
				num = (short)970260480;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.UIValue = value;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0023C520 File Offset: 0x0023A720
		public global::AcpBusinessLayer.AcpIPAddressField SecKmfProfDataTransportKMFIPAddress_A8375
		{
			get
			{
				short num = (short)538705174;
				short num2 = num;
				num = (short)151256342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1534328832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)965738496;
				if (num != 0)
				{
				}
				num = (short)165675009;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0023C5D0 File Offset: 0x0023A7D0
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x0023C684 File Offset: 0x0023A884
		public bool SecKmfProfDataTransportKMFIPAddress_A8375_Applicable
		{
			get
			{
				short num = (short)523501569;
				if (num != 0)
				{
				}
				num = (short)1475608576;
				short num2 = num;
				num = (short)121048666;
				short num3 = num;
				num = (short)1083838042;
				switch (num3 == num)
				{
				}
				num = (short)1821638656;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.Applicable;
			}
			set
			{
				short num = (short)1977361317;
				short num2 = num;
				num = (short)1152132005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701838848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)170524673;
				if (num != 0)
				{
				}
				num = (short)1701314560;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.Applicable = value;
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x0023C738 File Offset: 0x0023A938
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x0023C7EC File Offset: 0x0023A9EC
		public bool SecKmfProfDataTransportKMFIPAddress_A8375_Valid
		{
			get
			{
				short num = (short)980250973;
				short num2 = num;
				num = (short)604664157;
				switch (num2 == num)
				{
				}
				num = (short)468451328;
				short num3 = num;
				num = (short)340197376;
				if (num != 0)
				{
				}
				num = (short)1403912193;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.Valid;
			}
			set
			{
				short num = (short)1065149028;
				short num2 = num;
				num = (short)964420196;
				switch (num2 == num)
				{
				}
				num = (short)431685632;
				short num3 = num;
				num = (short)1459421185;
				if (num != 0)
				{
				}
				num = (short)1768882176;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.Valid = value;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0023C8A4 File Offset: 0x0023AAA4
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x0023C958 File Offset: 0x0023AB58
		public bool SecKmfProfDataTransportKMFIPAddress_A8375_Visible
		{
			get
			{
				short num = (short)1280049153;
				if (num != 0)
				{
				}
				num = (short)1707893660;
				short num2 = num;
				num = (short)2013815708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820983296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)271253504;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.Visible;
			}
			set
			{
				short num = (short)42801489;
				short num2 = num;
				num = (short)1303517521;
				switch (num2 == num)
				{
				}
				num = (short)1682178048;
				short num3 = num;
				num = (short)1805975553;
				if (num != 0)
				{
				}
				num = (short)1444675584;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.Visible = value;
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0023CA0C File Offset: 0x0023AC0C
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x0023CAC4 File Offset: 0x0023ACC4
		public bool SecKmfProfDataTransportKMFIPAddress_A8375_Editable
		{
			get
			{
				short num = (short)963629431;
				short num2 = num;
				num = (short)1119211895;
				switch (num2 == num)
				{
				}
				num = (short)1807876096;
				short num3 = num;
				num = (short)976879617;
				if (num != 0)
				{
				}
				num = (short)186712064;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.Editable;
			}
			set
			{
				short num = (short)638035277;
				short num2 = num;
				num = (short)1668326733;
				switch (num2 == num)
				{
				}
				num = (short)1872363520;
				short num3 = num;
				num = (short)1177550849;
				if (num != 0)
				{
				}
				num = (short)2132410368;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.Editable = value;
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0023CB7C File Offset: 0x0023AD7C
		internal string SecKmfProfDataTransportKMFIPAddress_A8375_UILabel
		{
			get
			{
				short num = (short)640463971;
				short num2 = num;
				num = (short)1399174243;
				switch (num2 == num)
				{
				}
				num = (short)2030174208;
				short num3 = num;
				num = (short)1161560065;
				if (num != 0)
				{
				}
				num = (short)717946880;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.UIName;
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0023CC30 File Offset: 0x0023AE30
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0023CCE0 File Offset: 0x0023AEE0
		internal bool SecKmfProfDataTransportKMFIPAddress_A8375_HiddenStatic
		{
			get
			{
				short num = (short)435104250;
				short num2 = num;
				num = (short)1914972666;
				switch (num2 == num)
				{
				}
				num = (short)1954742272;
				short num3 = num;
				num = (short)893321216;
				if (num != 0)
				{
				}
				num = (short)991100929;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.HiddenStatic;
			}
			set
			{
				short num = (short)2070216705;
				if (num != 0)
				{
				}
				num = (short)2005437184;
				short num2 = num;
				num = (short)343182080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947205632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275906560;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.HiddenStatic = value;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x0023CD98 File Offset: 0x0023AF98
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x0023CE50 File Offset: 0x0023B050
		internal bool SecKmfProfDataTransportKMFIPAddress_A8375_HiddenDynamic
		{
			get
			{
				short num = (short)154353217;
				short num2 = num;
				num = (short)143146561;
				switch (num2 == num)
				{
				}
				num = (short)1303379968;
				short num3 = num;
				num = (short)274268161;
				if (num != 0)
				{
				}
				num = (short)65863680;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375.HiddenDynamic;
			}
			set
			{
				short num = (short)844140618;
				short num2 = num;
				num = (short)198807626;
				switch (num2 == num)
				{
				}
				num = (short)304742400;
				short num3 = num;
				num = (short)878837761;
				if (num != 0)
				{
				}
				num = (short)1633419264;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFIPAddress_A8375.HiddenDynamic = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x0023CF04 File Offset: 0x0023B104
		public bool SecKmfProfDataTransportKMFIPAddress_A8375_HasDiffs
		{
			get
			{
				short num = (short)901822371;
				short num2 = num;
				num = (short)1913698211;
				switch (num2 == num)
				{
				}
				num = (short)540475392;
				short num3 = num;
				num = (short)1557331969;
				if (num != 0)
				{
				}
				num = (short)1089339392;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFIPAddress_A8375._HasDiffs;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x0023CFB8 File Offset: 0x0023B1B8
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0023D070 File Offset: 0x0023B270
		public int SecKmfProfDataTransportOTARTransportValue
		{
			get
			{
				short num = (short)1961043822;
				short num2 = num;
				num = (short)1311123310;
				switch (num2 == num)
				{
				}
				num = (short)1902772224;
				short num3 = num;
				num = (short)1374814208;
				if (num != 0)
				{
				}
				num = (short)1130102785;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.Value;
			}
			set
			{
				short num = (short)1687583349;
				short num2 = num;
				num = (short)2125036149;
				switch (num2 == num)
				{
				}
				num = (short)397541376;
				short num3 = num;
				num = (short)491192320;
				if (num != 0)
				{
				}
				num = (short)1450704897;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.Value = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x0023D128 File Offset: 0x0023B328
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0023D1DC File Offset: 0x0023B3DC
		public string SecKmfProfDataTransportOTARTransport_UIValue
		{
			get
			{
				short num = (short)1738735617;
				if (num != 0)
				{
				}
				num = (short)823021123;
				short num2 = num;
				num = (short)1513901635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776929280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395720192;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.UIValue;
			}
			set
			{
				short num = (short)662618753;
				short num2 = num;
				num = (short)1265877633;
				switch (num2 == num)
				{
				}
				num = (short)308346880;
				short num3 = num;
				num = (short)910557185;
				if (num != 0)
				{
				}
				num = (short)974979072;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.UIValue = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x0023D294 File Offset: 0x0023B494
		public global::AcpBusinessLayer.AcpListField SecKmfProfDataTransportOTARTransport
		{
			get
			{
				short num = (short)1205310561;
				short num2 = num;
				num = (short)197104737;
				switch (num2 == num)
				{
				}
				num = (short)859766784;
				short num3 = num;
				num = (short)1507329;
				if (num != 0)
				{
				}
				num = (short)95223808;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0023D344 File Offset: 0x0023B544
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0023D3F8 File Offset: 0x0023B5F8
		public bool SecKmfProfDataTransportOTARTransport_Applicable
		{
			get
			{
				short num = (short)524849117;
				short num2 = num;
				num = (short)1532137437;
				switch (num2 == num)
				{
				}
				num = (short)949223424;
				short num3 = num;
				num = (short)1895563264;
				if (num != 0)
				{
				}
				num = (short)1332084737;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.Applicable;
			}
			set
			{
				short num = (short)1137825590;
				short num2 = num;
				num = (short)1289017142;
				switch (num2 == num)
				{
				}
				num = (short)1582825472;
				short num3 = num;
				num = (short)391643137;
				if (num != 0)
				{
				}
				num = (short)134479872;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.Applicable = value;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x0023D4AC File Offset: 0x0023B6AC
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x0023D560 File Offset: 0x0023B760
		public bool SecKmfProfDataTransportOTARTransport_Valid
		{
			get
			{
				short num = (short)1118288345;
				short num2 = num;
				num = (short)1143781849;
				switch (num2 == num)
				{
				}
				num = (short)1918369792;
				short num3 = num;
				num = (short)438173697;
				if (num != 0)
				{
				}
				num = (short)1924595712;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.Valid;
			}
			set
			{
				short num = (short)2072457505;
				short num2 = num;
				num = (short)989147425;
				switch (num2 == num)
				{
				}
				num = (short)355598336;
				short num3 = num;
				num = (short)1349124096;
				if (num != 0)
				{
				}
				num = (short)486670337;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.Valid = value;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x0023D614 File Offset: 0x0023B814
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x0023D6CC File Offset: 0x0023B8CC
		public bool SecKmfProfDataTransportOTARTransport_Visible
		{
			get
			{
				short num = (short)2139445120;
				short num2 = num;
				num = (short)1264342912;
				switch (num2 == num)
				{
				}
				num = (short)279511040;
				short num3 = num;
				num = (short)551157761;
				if (num != 0)
				{
				}
				num = (short)1678835712;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.Visible;
			}
			set
			{
				short num = (short)1029224493;
				short num2 = num;
				num = (short)1974319149;
				switch (num2 == num)
				{
				}
				num = (short)460390400;
				short num3 = num;
				num = (short)217317377;
				if (num != 0)
				{
				}
				num = (short)261947392;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.Visible = value;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x0023D784 File Offset: 0x0023B984
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x0023D83C File Offset: 0x0023BA3C
		public bool SecKmfProfDataTransportOTARTransport_Editable
		{
			get
			{
				short num = (short)1126803039;
				short num2 = num;
				num = (short)263824991;
				switch (num2 == num)
				{
				}
				num = (short)546766848;
				short num3 = num;
				num = (short)839778305;
				if (num != 0)
				{
				}
				num = (short)368705536;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.Editable;
			}
			set
			{
				short num = (short)1455387561;
				short num2 = num;
				num = (short)1972925353;
				switch (num2 == num)
				{
				}
				num = (short)476643328;
				short num3 = num;
				num = (short)1989279744;
				if (num != 0)
				{
				}
				num = (short)787021825;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.Editable = value;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x0023D8F0 File Offset: 0x0023BAF0
		internal string SecKmfProfDataTransportOTARTransport_UILabel
		{
			get
			{
				short num = (short)56972275;
				short num2 = num;
				num = (short)389633011;
				switch (num2 == num)
				{
				}
				num = (short)1318125568;
				short num3 = num;
				num = (short)1246101505;
				if (num != 0)
				{
				}
				num = (short)2104360960;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.UIName;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x0023D9A8 File Offset: 0x0023BBA8
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x0023DA5C File Offset: 0x0023BC5C
		internal bool SecKmfProfDataTransportOTARTransport_HiddenStatic
		{
			get
			{
				short num = (short)1733873926;
				short num2 = num;
				num = (short)1168429318;
				switch (num2 == num)
				{
				}
				num = (short)143589376;
				short num3 = num;
				num = (short)171442176;
				if (num != 0)
				{
				}
				num = (short)1140719617;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.HiddenStatic;
			}
			set
			{
				short num = (short)464422091;
				short num2 = num;
				num = (short)3704011;
				switch (num2 == num)
				{
				}
				num = (short)56098816;
				short num3 = num;
				num = (short)936574977;
				if (num != 0)
				{
				}
				num = (short)1866268672;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.HiddenStatic = value;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x0023DB10 File Offset: 0x0023BD10
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x0023DBC4 File Offset: 0x0023BDC4
		internal bool SecKmfProfDataTransportOTARTransport_HiddenDynamic
		{
			get
			{
				short num = (short)1752875736;
				short num2 = num;
				num = (short)821478104;
				switch (num2 == num)
				{
				}
				num = (short)1898381312;
				short num3 = num;
				num = (short)1227554816;
				if (num != 0)
				{
				}
				num = (short)753074177;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport.HiddenDynamic;
			}
			set
			{
				short num = (short)1500446721;
				if (num != 0)
				{
				}
				num = (short)147780055;
				short num2 = num;
				num = (short)1708913111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76218368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)749207552;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportOTARTransport.HiddenDynamic = value;
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x0023DC7C File Offset: 0x0023BE7C
		public bool SecKmfProfDataTransportOTARTransport_HasDiffs
		{
			get
			{
				short num = (short)233282371;
				short num2 = num;
				num = (short)1987091267;
				switch (num2 == num)
				{
				}
				num = (short)791609344;
				short num3 = num;
				num = (short)1542258689;
				if (num != 0)
				{
				}
				num = (short)1819607040;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportOTARTransport._HasDiffs;
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x0023DD30 File Offset: 0x0023BF30
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x0023DDE4 File Offset: 0x0023BFE4
		public string SecKmfProfDataTransportKMFBroadbandIdValue
		{
			get
			{
				short num = (short)1801125889;
				if (num != 0)
				{
				}
				num = (short)1661459248;
				short num2 = num;
				num = (short)365026096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1194524672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)969474048;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.Value;
			}
			set
			{
				short num = (short)930386114;
				short num2 = num;
				num = (short)2125828290;
				switch (num2 == num)
				{
				}
				num = (short)1863450624;
				short num3 = num;
				num = (short)372506625;
				if (num != 0)
				{
				}
				num = (short)2135359488;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.Value = value;
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x0023DE98 File Offset: 0x0023C098
		public global::AcpBusinessLayer.AcpField<string> SecKmfProfDataTransportKMFBroadbandId
		{
			get
			{
				short num = (short)740327869;
				short num2 = num;
				num = (short)614236605;
				switch (num2 == num)
				{
				}
				num = (short)1718484992;
				short num3 = num;
				num = (short)1296695297;
				if (num != 0)
				{
				}
				num = (short)937426944;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId;
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x0023DF4C File Offset: 0x0023C14C
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0023E000 File Offset: 0x0023C200
		public string SecKmfProfDataTransportKMFBroadbandId_UIValue
		{
			get
			{
				short num = (short)1595161595;
				short num2 = num;
				num = (short)1196571643;
				switch (num2 == num)
				{
				}
				num = (short)1844314112;
				short num3 = num;
				num = (short)1691484161;
				if (num != 0)
				{
				}
				num = (short)1635647488;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.Value;
			}
			set
			{
				short num = (short)863218604;
				short num2 = num;
				num = (short)717138860;
				switch (num2 == num)
				{
				}
				num = (short)2071003136;
				short num3 = num;
				num = (short)223608833;
				if (num != 0)
				{
				}
				num = (short)1614807040;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.Value = value;
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0023E0B8 File Offset: 0x0023C2B8
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0023E16C File Offset: 0x0023C36C
		public bool SecKmfProfDataTransportKMFBroadbandId_Applicable
		{
			get
			{
				short num = (short)1588199425;
				if (num != 0)
				{
				}
				num = (short)707420502;
				short num2 = num;
				num = (short)1480941910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16646144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928776192;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.Applicable;
			}
			set
			{
				short num = (short)1727051545;
				short num2 = num;
				num = (short)1130477337;
				switch (num2 == num)
				{
				}
				num = (short)1027211264;
				short num3 = num;
				num = (short)1040318465;
				if (num != 0)
				{
				}
				num = (short)607780864;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.Applicable = value;
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0023E224 File Offset: 0x0023C424
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0023E2D8 File Offset: 0x0023C4D8
		public bool SecKmfProfDataTransportKMFBroadbandId_Valid
		{
			get
			{
				short num = (short)672957279;
				short num2 = num;
				num = (short)1054638943;
				switch (num2 == num)
				{
				}
				num = (short)2023227393;
				if (num != 0)
				{
				}
				num = (short)389349376;
				short num3 = num;
				num = (short)1930493952;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.Valid;
			}
			set
			{
				short num = (short)293804439;
				short num2 = num;
				num = (short)639310231;
				switch (num2 == num)
				{
				}
				num = (short)1798963200;
				if (num != 0)
				{
				}
				num = (short)408289280;
				short num3 = num;
				num = (short)462618625;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.Valid = value;
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x0023E38C File Offset: 0x0023C58C
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0023E444 File Offset: 0x0023C644
		public bool SecKmfProfDataTransportKMFBroadbandId_Visible
		{
			get
			{
				short num = (short)471573562;
				short num2 = num;
				num = (short)230138938;
				switch (num2 == num)
				{
				}
				num = (short)1675165697;
				if (num != 0)
				{
				}
				num = (short)2106130432;
				short num3 = num;
				num = (short)1481834496;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.Visible;
			}
			set
			{
				short num = (short)311281704;
				short num2 = num;
				num = (short)402769960;
				switch (num2 == num)
				{
				}
				num = (short)1005649920;
				if (num != 0)
				{
				}
				num = (short)452591616;
				short num3 = num;
				num = (short)1023541249;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.Visible = value;
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0023E4F8 File Offset: 0x0023C6F8
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0023E5B0 File Offset: 0x0023C7B0
		public bool SecKmfProfDataTransportKMFBroadbandId_Editable
		{
			get
			{
				short num = (short)774193;
				short num2 = num;
				num = (short)1921175601;
				switch (num2 == num)
				{
				}
				num = (short)1240530944;
				if (num != 0)
				{
				}
				num = (short)1510146048;
				short num3 = num;
				num = (short)900202497;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.Editable;
			}
			set
			{
				short num = (short)748122866;
				short num2 = num;
				num = (short)904884978;
				switch (num2 == num)
				{
				}
				num = (short)1209860097;
				if (num != 0)
				{
				}
				num = (short)307822592;
				short num3 = num;
				num = (short)341245952;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.Editable = value;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0023E668 File Offset: 0x0023C868
		internal string SecKmfProfDataTransportKMFBroadbandId_UILabel
		{
			get
			{
				short num = (short)55038424;
				short num2 = num;
				num = (short)177918424;
				switch (num2 == num)
				{
				}
				num = (short)25755649;
				if (num != 0)
				{
				}
				num = (short)336789504;
				short num3 = num;
				num = (short)1620901888;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.UIName;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0023E71C File Offset: 0x0023C91C
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x0023E7D0 File Offset: 0x0023C9D0
		internal bool SecKmfProfDataTransportKMFBroadbandId_HiddenStatic
		{
			get
			{
				short num = (short)1382940050;
				short num2 = num;
				num = (short)514391442;
				switch (num2 == num)
				{
				}
				num = (short)486473729;
				if (num != 0)
				{
				}
				num = (short)1398603776;
				short num3 = num;
				num = (short)1464598528;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.HiddenStatic;
			}
			set
			{
				short num = (short)1184552138;
				short num2 = num;
				num = (short)1428214986;
				switch (num2 == num)
				{
				}
				num = (short)4063232;
				if (num != 0)
				{
				}
				num = (short)192479232;
				short num3 = num;
				num = (short)1506541569;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.HiddenStatic = value;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x0023E884 File Offset: 0x0023CA84
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x0023E938 File Offset: 0x0023CB38
		internal bool SecKmfProfDataTransportKMFBroadbandId_HiddenDynamic
		{
			get
			{
				short num = (short)1041301505;
				if (num != 0)
				{
				}
				num = (short)775774760;
				short num2 = num;
				num = (short)433349160;
				switch (num2 == num)
				{
				}
				num = (short)588972032;
				short num3 = num;
				num = (short)1140850688;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId.HiddenDynamic;
			}
			set
			{
				short num = (short)2079684323;
				short num2 = num;
				num = (short)199194339;
				switch (num2 == num)
				{
				}
				num = (short)1790312448;
				if (num != 0)
				{
				}
				num = (short)1919483904;
				short num3 = num;
				num = (short)1269956609;
				if (num != 0)
				{
				}
				this.secKmfProfDataTransportKMFBroadbandId.HiddenDynamic = value;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x0023E9F0 File Offset: 0x0023CBF0
		public bool SecKmfProfDataTransportKMFBroadbandId_HasDiffs
		{
			get
			{
				short num = (short)2109014017;
				if (num != 0)
				{
				}
				num = (short)1106367001;
				short num2 = num;
				num = (short)289788441;
				switch (num2 == num)
				{
				}
				num = (short)944177152;
				short num3 = num;
				num = (short)671023104;
				if (num != 0)
				{
				}
				return this.secKmfProfDataTransportKMFBroadbandId._HasDiffs;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x0023EAA8 File Offset: 0x0023CCA8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1589725527;
				short num2 = num;
				num = (short)172378455;
				switch (num2 == num)
				{
				}
				num = (short)1681326080;
				if (num != 0)
				{
				}
				num = (short)148570112;
				short num3 = num;
				num = (short)329646081;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0023EB6C File Offset: 0x0023CD6C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)669371931;
				short num2 = num;
				num = (short)2035797531;
				switch (num2 == num)
				{
				}
				num = (short)250085377;
				if (num != 0)
				{
				}
				num = (short)1246691328;
				short num3 = num;
				num = (short)2124218368;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0023EC28 File Offset: 0x0023CE28
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1286733826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)50013663;
					short num3 = num2;
					num2 = (short)990324191;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E3;
					default:
						num2 = (short)382402560;
						if (num2 != 0)
						{
						}
						num2 = (short)699727872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_E3;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1731133441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
				IL_E3:
				num2 = (short)19857408;
				short num4 = num2;
				num2 = (short)670105604;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)66191361;
			if (num2 != 0)
			{
			}
			num2 = (short)858587139;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000D49 RID: 3401
		private global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfDataTransportKMFUDPPort_A8384;

		// Token: 0x04000D4A RID: 3402
		private global::AcpBusinessLayer.AcpSimpleRangeField secKmfProfDataTransportSubscriberOTARPort_A9226;

		// Token: 0x04000D4B RID: 3403
		private global::AcpBusinessLayer.AcpIPAddressField secKmfProfDataTransportKMFIPAddress_A8375;

		// Token: 0x04000D4C RID: 3404
		private global::AcpBusinessLayer.AcpListField secKmfProfDataTransportOTARTransport;

		// Token: 0x04000D4D RID: 3405
		private global::AcpBusinessLayer.AcpField<string> secKmfProfDataTransportKMFBroadbandId;
	}
}
