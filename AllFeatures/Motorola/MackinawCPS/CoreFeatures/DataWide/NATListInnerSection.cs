using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E8 RID: 1256
	[global::System.Serializable]
	public class NATListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A84E RID: 43086 RVA: 0x009C64C8 File Offset: 0x009C46C8
		public NATListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x009C64E4 File Offset: 0x009C46E4
		protected NATListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x009C64FC File Offset: 0x009C46FC
		public override void Init()
		{
			int a_ = 1;
			short num = (short)301645670;
			short num2 = num;
			num = (short)1599913830;
			switch (num2 == num)
			{
			}
			num = (short)952172544;
			if (num != 0)
			{
			}
			num = (short)1696792576;
			short num3 = num;
			num = (short)1049493505;
			if (num != 0)
			{
			}
			this.dataWideNATListLANPort_A8385 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蛁ꗃ닅꧇鷉ꗋ꫍뗏鳑闓苕铗동꿛ꫝ곟ꏡꫣ뛥蟧飩飫뇭뇯쫱쟳컵췷", a_), global::CommonResources.AcgResources.ID_LANPORT, 0, 65535, null, null, 0, 1);
			this.dataWideNATListLANPort_A8385.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataWideNATListLANPort_A8385.DataTransferOrder = 9;
			this.dataWideNATListLANPort_A8385.ShowHexValue = false;
			this.dataWideNATListStaticNATIPAddress_A9181 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("蛁ꗃ닅꧇鷉ꗋ꫍뗏鳑闓苕铗동꿛ꫝ돟雡藣鋥臧觩ꋫ꿭ꓯ믱ꓳ럵鳷黹軻鯽珿焁嬃䜅ㄇ㬉㐋㼍", a_), global::CommonResources.AcgResources.ID_STATICNATIPADDRESS);
			this.dataWideNATListStaticNATIPAddress_A9181.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataWideNATListStaticNATIPAddress_A9181.DataTransferOrder = 11;
			this.dataWideNATListWANPort_A9677 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蛁ꗃ닅꧇鷉ꗋ꫍뗏鳑闓苕铗동꿛ꫝ럟ꏡꫣ뛥蟧飩飫뇭뇯쯱싳쇵쿷", a_), global::CommonResources.AcgResources.ID_WANPORT, 0, 65535, null, null, 0, 1);
			this.dataWideNATListWANPort_A9677.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dataWideNATListWANPort_A9677.DataTransferOrder = 10;
			this.dataWideNATListWANPort_A9677.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賁藃鋅蛉ꗋ뷍꓏", a_);
			base.Id = 10068;
			base.UIName = global::CommonResources.AcgResources.ID_NATLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x009C66B8 File Offset: 0x009C48B8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)1362952195;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.dataWideNATListWANPort_A9677 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑髓韕賗雙뗛귝铟뗡ꗣ꣥룧藩黫髭꿯돱췳샵쿷췹", a_), global::CommonResources.AcgResources.ID_WANPORT, null, null, 0, 1);
					this.dataWideNATListWANPort_A9677.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataWideNATListWANPort_A9677.DataTransferOrder = 10;
					this.dataWideNATListWANPort_A9677.ShowHexValue = false;
					num = (short)871759874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)643235841;
					if (num != 0)
					{
					}
					num = (short)1662320651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1FF;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 4:
					if (producerFields != null)
					{
						num = (short)2127757313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_361;
				case 5:
					this.dataWideNATListLANPort_A8385 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑髓韕賗雙뗛귝铟껡ꗣ꣥룧藩黫髭꿯돱쳳엵샷쿹", a_), global::CommonResources.AcgResources.ID_LANPORT, null, null, 0, 1);
					this.dataWideNATListLANPort_A8385.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataWideNATListLANPort_A8385.DataTransferOrder = 9;
					this.dataWideNATListLANPort_A8385.ShowHexValue = false;
					num = (short)1158676492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_F4;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑髓韕賗雙뗛귝铟뗡ꗣ꣥룧藩黫髭꿯돱췳샵쿷췹", a_)))
					{
						num = (short)319160320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_361;
				case 8:
				{
					num = (short)1214115393;
					short num3 = num;
					num = (short)689303105;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F4;
					default:
						num = (short)1994850304;
						if (num != 0)
						{
						}
						num = (short)391118852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					this.dataWideNATListStaticNATIPAddress_A9181 = new global::AcpBusinessLayer.AcpIPAddressField(0L, this, global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑髓韕賗雙뗛귝铟뇡郣蟥鳧菩迫ꃭ뇯꛱뷳꛵맷黹飻賽旿焁眃夅䤇㌉㴋㘍ℏ", a_), global::CommonResources.AcgResources.ID_STATICNATIPADDRESS);
					this.dataWideNATListStaticNATIPAddress_A9181.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dataWideNATListStaticNATIPAddress_A9181.DataTransferOrder = 11;
					num = (short)46071818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_2B0;
				case 11:
				{
					num = (short)725614592;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑髓韕賗雙뗛귝铟껡ꗣ꣥룧藩黫髭꿯돱쳳엵샷쿹", a_)))
					{
						num = (short)368377861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC;
				}
				case 12:
					goto IL_DC;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1096155144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DC:
				num = (short)217120774;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F4:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ鯋ꟍ듏럑髓韕賗雙뗛귝铟뇡郣蟥鳧菩迫ꃭ뇯꛱뷳꛵맷黹飻賽旿焁眃夅䤇㌉㴋㘍ℏ", a_)))
				{
					num = (short)1889075209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2B0:
				num = (short)621346823;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1FF:
			IL_361:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諃蟅鳇胋ꟍꏏꛑ", a_);
			base.Id = 10068;
			base.UIName = global::CommonResources.AcgResources.ID_NATLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x009C6A58 File Offset: 0x009C4C58
		public override void PopulateReferences()
		{
			short num = (short)131161285;
			short num2 = num;
			num = (short)2143444165;
			switch (num2 == num)
			{
			}
			num = (short)1106182144;
			if (num != 0)
			{
			}
			num = (short)635240448;
			short num3 = num;
			num = (short)1298202625;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A853 RID: 43091 RVA: 0x009C6B00 File Offset: 0x009C4D00
		public override void DropReferences()
		{
			short num = (short)393669575;
			short num2 = num;
			num = (short)531426247;
			switch (num2 == num)
			{
			}
			num = (short)291569664;
			if (num != 0)
			{
			}
			num = (short)442499072;
			short num3 = num;
			num = (short)1728512001;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x009C6BA8 File Offset: 0x009C4DA8
		public override void SetConstraints()
		{
			short num = (short)1019601465;
			short num2 = num;
			num = (short)1334764089;
			switch (num2 == num)
			{
			}
			num = (short)2119172096;
			if (num != 0)
			{
			}
			num = (short)611057664;
			short num3 = num;
			num = (short)1177485313;
			if (num != 0)
			{
			}
			this.dataWideNATListLANPort_A8385.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conLanPortNotZero);
			this.dataWideNATListStaticNATIPAddress_A9181.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conStaticNatIPAddressValid);
			this.dataWideNATListWANPort_A9677.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.conWanPortNotZero);
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x009C6C98 File Offset: 0x009C4E98
		public override void SetupDependencies()
		{
			short num = (short)2143805183;
			short num2 = num;
			num = (short)1568202495;
			switch (num2 == num)
			{
			}
			num = (short)1224474625;
			if (num != 0)
			{
			}
			num = (short)1857355776;
			short num3 = num;
			num = (short)1777532928;
			if (num != 0)
			{
			}
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.dataWideNATListStaticNATIPAddress_A9181);
			this.dataWideNATListLANPort_A8385.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413);
			this.dataWideNATListLANPort_A8385.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627);
			this.dataWideNATListLANPort_A8385.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022);
			this.dataWideNATListLANPort_A8385.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205);
			this.dataWideNATListWANPort_A9677.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413);
			this.dataWideNATListWANPort_A9677.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627);
			this.dataWideNATListWANPort_A9677.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022);
			this.dataWideNATListWANPort_A9677.AddDependentObject((base.ParentRecset.ParentSection.Parent[10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205);
		}

		// Token: 0x17005484 RID: 21636
		// (get) Token: 0x0600A856 RID: 43094 RVA: 0x009C6EE0 File Offset: 0x009C50E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)259822900;
				short num2 = num;
				num = (short)375690548;
				switch (num2 == num)
				{
				}
				num = (short)533594113;
				if (num != 0)
				{
				}
				num = (short)428802048;
				short num3 = num;
				num = (short)583991296;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005485 RID: 21637
		// (get) Token: 0x0600A857 RID: 43095 RVA: 0x009C6F90 File Offset: 0x009C5190
		// (set) Token: 0x0600A858 RID: 43096 RVA: 0x009C7044 File Offset: 0x009C5244
		public int DataWideNATListLANPort_A8385Value
		{
			get
			{
				short num = (short)1437128233;
				short num2 = num;
				num = (short)416732713;
				switch (num2 == num)
				{
				}
				num = (short)811466752;
				if (num != 0)
				{
				}
				num = (short)985006080;
				short num3 = num;
				num = (short)1813446657;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Value;
			}
			set
			{
				short num = (short)1779860250;
				short num2 = num;
				num = (short)113279770;
				switch (num2 == num)
				{
				}
				num = (short)1749417984;
				if (num != 0)
				{
				}
				num = (short)744357888;
				short num3 = num;
				num = (short)1052901377;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Value = value;
			}
		}

		// Token: 0x17005486 RID: 21638
		// (get) Token: 0x0600A859 RID: 43097 RVA: 0x009C70F8 File Offset: 0x009C52F8
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideNATListLANPort_A8385
		{
			get
			{
				short num = (short)159788074;
				short num2 = num;
				num = (short)504966186;
				switch (num2 == num)
				{
				}
				num = (short)1426522112;
				if (num != 0)
				{
				}
				num = (short)1774256128;
				short num3 = num;
				num = (short)1996685313;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385;
			}
		}

		// Token: 0x17005487 RID: 21639
		// (get) Token: 0x0600A85A RID: 43098 RVA: 0x009C71A8 File Offset: 0x009C53A8
		// (set) Token: 0x0600A85B RID: 43099 RVA: 0x009C725C File Offset: 0x009C545C
		public string DataWideNATListLANPort_A8385_UIValue
		{
			get
			{
				short num = (short)598767033;
				short num2 = num;
				num = (short)2030663097;
				switch (num2 == num)
				{
				}
				num = (short)1262223361;
				if (num != 0)
				{
				}
				num = (short)472449024;
				short num3 = num;
				num = (short)65667072;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.UIValue;
			}
			set
			{
				short num = (short)410517505;
				if (num != 0)
				{
				}
				num = (short)1719840067;
				short num2 = num;
				num = (short)633646403;
				switch (num2 == num)
				{
				}
				num = (short)602669056;
				short num3 = num;
				num = (short)1180696576;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.UIValue = value;
			}
		}

		// Token: 0x17005488 RID: 21640
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x009C7318 File Offset: 0x009C5518
		// (set) Token: 0x0600A85D RID: 43101 RVA: 0x009C73CC File Offset: 0x009C55CC
		internal int DataWideNATListLANPort_A8385Min
		{
			get
			{
				short num = (short)1865415395;
				short num2 = num;
				num = (short)146930403;
				switch (num2 == num)
				{
				}
				num = (short)1245446144;
				if (num != 0)
				{
				}
				num = (short)1807745024;
				short num3 = num;
				num = (short)1947009025;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Min;
			}
			set
			{
				short num = (short)816605791;
				short num2 = num;
				num = (short)2011327071;
				switch (num2 == num)
				{
				}
				num = (short)663224320;
				if (num != 0)
				{
				}
				num = (short)1284833280;
				short num3 = num;
				num = (short)1576730625;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Min = value;
			}
		}

		// Token: 0x17005489 RID: 21641
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x009C7484 File Offset: 0x009C5684
		// (set) Token: 0x0600A85F RID: 43103 RVA: 0x009C753C File Offset: 0x009C573C
		internal int DataWideNATListLANPort_A8385Max
		{
			get
			{
				short num = (short)2006060771;
				short num2 = num;
				num = (short)392629987;
				switch (num2 == num)
				{
				}
				num = (short)1201995777;
				if (num != 0)
				{
				}
				num = (short)1998716928;
				short num3 = num;
				num = (short)2017132544;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Max;
			}
			set
			{
				short num = (short)1462960621;
				short num2 = num;
				num = (short)878838253;
				switch (num2 == num)
				{
				}
				num = (short)338755584;
				if (num != 0)
				{
				}
				num = (short)39714816;
				short num3 = num;
				num = (short)953352193;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Max = value;
			}
		}

		// Token: 0x1700548A RID: 21642
		// (get) Token: 0x0600A860 RID: 43104 RVA: 0x009C75F0 File Offset: 0x009C57F0
		// (set) Token: 0x0600A861 RID: 43105 RVA: 0x009C76A8 File Offset: 0x009C58A8
		internal int DataWideNATListLANPort_A8385Step
		{
			get
			{
				short num = (short)1355720967;
				short num2 = num;
				num = (short)1169533191;
				switch (num2 == num)
				{
				}
				num = (short)156106753;
				if (num != 0)
				{
				}
				num = (short)1244594176;
				short num3 = num;
				num = (short)677380096;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.StepSize;
			}
			set
			{
				short num = (short)630784001;
				if (num != 0)
				{
				}
				num = (short)2007647780;
				short num2 = num;
				num = (short)1538344484;
				switch (num2 == num)
				{
				}
				num = (short)927465472;
				short num3 = num;
				num = (short)1311899648;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.StepSize = value;
			}
		}

		// Token: 0x1700548B RID: 21643
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x009C775C File Offset: 0x009C595C
		// (set) Token: 0x0600A863 RID: 43107 RVA: 0x009C7810 File Offset: 0x009C5A10
		public bool DataWideNATListLANPort_A8385_Applicable
		{
			get
			{
				short num = (short)1500081411;
				short num2 = num;
				num = (short)1638690051;
				switch (num2 == num)
				{
				}
				num = (short)1973878785;
				if (num != 0)
				{
				}
				num = (short)97320960;
				short num3 = num;
				num = (short)309329920;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Applicable;
			}
			set
			{
				short num = (short)2068539904;
				short num2 = num;
				num = (short)513894912;
				switch (num2 == num)
				{
				}
				num = (short)1841430529;
				if (num != 0)
				{
				}
				num = (short)1205338112;
				short num3 = num;
				num = (short)127205376;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Applicable = value;
			}
		}

		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x0600A864 RID: 43108 RVA: 0x009C78C8 File Offset: 0x009C5AC8
		// (set) Token: 0x0600A865 RID: 43109 RVA: 0x009C797C File Offset: 0x009C5B7C
		public bool DataWideNATListLANPort_A8385_Valid
		{
			get
			{
				short num = (short)228589569;
				if (num != 0)
				{
				}
				num = (short)599117305;
				short num2 = num;
				num = (short)742247929;
				switch (num2 == num)
				{
				}
				num = (short)993001472;
				short num3 = num;
				num = (short)1480523776;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Valid;
			}
			set
			{
				short num = (short)811618874;
				short num2 = num;
				num = (short)2057392698;
				switch (num2 == num)
				{
				}
				num = (short)1231880192;
				if (num != 0)
				{
				}
				num = (short)2111111168;
				short num3 = num;
				num = (short)900792321;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Valid = value;
			}
		}

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x0600A866 RID: 43110 RVA: 0x009C7A34 File Offset: 0x009C5C34
		// (set) Token: 0x0600A867 RID: 43111 RVA: 0x009C7AEC File Offset: 0x009C5CEC
		public bool DataWideNATListLANPort_A8385_Visible
		{
			get
			{
				short num = (short)647607995;
				short num2 = num;
				num = (short)363050683;
				switch (num2 == num)
				{
				}
				num = (short)1123155968;
				if (num != 0)
				{
				}
				num = (short)1929314304;
				short num3 = num;
				num = (short)833683457;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Visible;
			}
			set
			{
				short num = (short)382337025;
				if (num != 0)
				{
				}
				num = (short)73056717;
				short num2 = num;
				num = (short)461816269;
				switch (num2 == num)
				{
				}
				num = (short)1131479040;
				short num3 = num;
				num = (short)853082112;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Visible = value;
			}
		}

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x0600A868 RID: 43112 RVA: 0x009C7BA0 File Offset: 0x009C5DA0
		// (set) Token: 0x0600A869 RID: 43113 RVA: 0x009C7C54 File Offset: 0x009C5E54
		public bool DataWideNATListLANPort_A8385_Editable
		{
			get
			{
				short num = (short)1325901174;
				short num2 = num;
				num = (short)1503569270;
				switch (num2 == num)
				{
				}
				num = (short)481230848;
				if (num != 0)
				{
				}
				num = (short)583467008;
				short num3 = num;
				num = (short)1957691393;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.Editable;
			}
			set
			{
				short num = (short)1323204768;
				short num2 = num;
				num = (short)406552736;
				switch (num2 == num)
				{
				}
				num = (short)910360577;
				if (num != 0)
				{
				}
				num = (short)1472266240;
				short num3 = num;
				num = (short)1291714560;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.Editable = value;
			}
		}

		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x0600A86A RID: 43114 RVA: 0x009C7D08 File Offset: 0x009C5F08
		internal string DataWideNATListLANPort_A8385_UILabel
		{
			get
			{
				short num = (short)1553858561;
				if (num != 0)
				{
				}
				num = (short)1087281985;
				short num2 = num;
				num = (short)127245121;
				switch (num2 == num)
				{
				}
				num = (short)1912799232;
				short num3 = num;
				num = (short)1548746752;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.UIName;
			}
		}

		// Token: 0x17005490 RID: 21648
		// (get) Token: 0x0600A86B RID: 43115 RVA: 0x009C7DC0 File Offset: 0x009C5FC0
		// (set) Token: 0x0600A86C RID: 43116 RVA: 0x009C7E74 File Offset: 0x009C6074
		internal bool DataWideNATListLANPort_A8385_HiddenStatic
		{
			get
			{
				short num = (short)1012924417;
				if (num != 0)
				{
				}
				num = (short)1587226080;
				short num2 = num;
				num = (short)1813325280;
				switch (num2 == num)
				{
				}
				num = (short)697696256;
				short num3 = num;
				num = (short)722272256;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.HiddenStatic;
			}
			set
			{
				short num = (short)426003787;
				short num2 = num;
				num = (short)476400971;
				switch (num2 == num)
				{
				}
				num = (short)1515520001;
				if (num != 0)
				{
				}
				num = (short)442761216;
				short num3 = num;
				num = (short)943456256;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.HiddenStatic = value;
			}
		}

		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x0600A86D RID: 43117 RVA: 0x009C7F28 File Offset: 0x009C6128
		// (set) Token: 0x0600A86E RID: 43118 RVA: 0x009C7FDC File Offset: 0x009C61DC
		internal bool DataWideNATListLANPort_A8385_HiddenDynamic
		{
			get
			{
				short num = (short)1692333339;
				short num2 = num;
				num = (short)1989997851;
				switch (num2 == num)
				{
				}
				num = (short)1133379585;
				if (num != 0)
				{
				}
				num = (short)1287323648;
				short num3 = num;
				num = (short)1049165824;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385.HiddenDynamic;
			}
			set
			{
				short num = (short)1590650234;
				short num2 = num;
				num = (short)484664698;
				switch (num2 == num)
				{
				}
				num = (short)1943863297;
				if (num != 0)
				{
				}
				num = (short)1733820416;
				short num3 = num;
				num = (short)1839661056;
				if (num != 0)
				{
				}
				this.dataWideNATListLANPort_A8385.HiddenDynamic = value;
			}
		}

		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x009C8090 File Offset: 0x009C6290
		public bool DataWideNATListLANPort_A8385_HasDiffs
		{
			get
			{
				short num = (short)473797893;
				short num2 = num;
				num = (short)434148613;
				switch (num2 == num)
				{
				}
				num = (short)317521921;
				if (num != 0)
				{
				}
				num = (short)1803354112;
				short num3 = num;
				num = (short)1352269824;
				if (num != 0)
				{
				}
				return this.dataWideNATListLANPort_A8385._HasDiffs;
			}
		}

		// Token: 0x17005493 RID: 21651
		// (get) Token: 0x0600A870 RID: 43120 RVA: 0x009C8144 File Offset: 0x009C6344
		// (set) Token: 0x0600A871 RID: 43121 RVA: 0x009C81F8 File Offset: 0x009C63F8
		public long DataWideNATListStaticNATIPAddress_A9181Value
		{
			get
			{
				short num = (short)342657627;
				short num2 = num;
				num = (short)630688347;
				switch (num2 == num)
				{
				}
				num = (short)27459585;
				if (num != 0)
				{
				}
				num = (short)1481900032;
				short num3 = num;
				num = (short)560791552;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.Value;
			}
			set
			{
				short num = (short)1034707565;
				short num2 = num;
				num = (short)1944019565;
				switch (num2 == num)
				{
				}
				num = (short)238419969;
				if (num != 0)
				{
				}
				num = (short)1956052992;
				short num3 = num;
				num = (short)956694528;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.Value = value;
			}
		}

		// Token: 0x17005494 RID: 21652
		// (get) Token: 0x0600A872 RID: 43122 RVA: 0x009C82B0 File Offset: 0x009C64B0
		// (set) Token: 0x0600A873 RID: 43123 RVA: 0x009C8364 File Offset: 0x009C6564
		public string DataWideNATListStaticNATIPAddress_A9181_UIValue
		{
			get
			{
				short num = (short)385178701;
				short num2 = num;
				num = (short)1622170701;
				switch (num2 == num)
				{
				}
				num = (short)362020864;
				if (num != 0)
				{
				}
				num = (short)641925120;
				short num3 = num;
				num = (short)537591809;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.UIValue;
			}
			set
			{
				short num = (short)1189281793;
				if (num != 0)
				{
				}
				num = (short)204868933;
				short num2 = num;
				num = (short)956894533;
				switch (num2 == num)
				{
				}
				num = (short)271450112;
				short num3 = num;
				num = (short)94109696;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.UIValue = value;
			}
		}

		// Token: 0x17005495 RID: 21653
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x009C841C File Offset: 0x009C661C
		public global::AcpBusinessLayer.AcpIPAddressField DataWideNATListStaticNATIPAddress_A9181
		{
			get
			{
				short num = (short)1002818762;
				short num2 = num;
				num = (short)376294602;
				switch (num2 == num)
				{
				}
				num = (short)1734410241;
				if (num != 0)
				{
				}
				num = (short)1672675328;
				short num3 = num;
				num = (short)1225785344;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181;
			}
		}

		// Token: 0x17005496 RID: 21654
		// (get) Token: 0x0600A875 RID: 43125 RVA: 0x009C84CC File Offset: 0x009C66CC
		// (set) Token: 0x0600A876 RID: 43126 RVA: 0x009C8580 File Offset: 0x009C6780
		public bool DataWideNATListStaticNATIPAddress_A9181_Applicable
		{
			get
			{
				short num = (short)1955588377;
				short num2 = num;
				num = (short)1607330073;
				switch (num2 == num)
				{
				}
				num = (short)2014183424;
				if (num != 0)
				{
				}
				num = (short)1092681728;
				short num3 = num;
				num = (short)1379270657;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.Applicable;
			}
			set
			{
				short num = (short)368827677;
				short num2 = num;
				num = (short)95935773;
				switch (num2 == num)
				{
				}
				num = (short)1546911745;
				if (num != 0)
				{
				}
				num = (short)343736320;
				short num3 = num;
				num = (short)914489344;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.Applicable = value;
			}
		}

		// Token: 0x17005497 RID: 21655
		// (get) Token: 0x0600A877 RID: 43127 RVA: 0x009C8638 File Offset: 0x009C6838
		// (set) Token: 0x0600A878 RID: 43128 RVA: 0x009C86EC File Offset: 0x009C68EC
		public bool DataWideNATListStaticNATIPAddress_A9181_Valid
		{
			get
			{
				short num = (short)1112866342;
				short num2 = num;
				num = (short)1427045926;
				switch (num2 == num)
				{
				}
				num = (short)931463168;
				if (num != 0)
				{
				}
				num = (short)63897600;
				short num3 = num;
				num = (short)1641218049;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.Valid;
			}
			set
			{
				short num = (short)1644982668;
				short num2 = num;
				num = (short)711029132;
				switch (num2 == num)
				{
				}
				num = (short)643563521;
				if (num != 0)
				{
				}
				num = (short)716636160;
				short num3 = num;
				num = (short)1490812928;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.Valid = value;
			}
		}

		// Token: 0x17005498 RID: 21656
		// (get) Token: 0x0600A879 RID: 43129 RVA: 0x009C87A4 File Offset: 0x009C69A4
		// (set) Token: 0x0600A87A RID: 43130 RVA: 0x009C8858 File Offset: 0x009C6A58
		public bool DataWideNATListStaticNATIPAddress_A9181_Visible
		{
			get
			{
				short num = (short)698865002;
				short num2 = num;
				num = (short)805164394;
				switch (num2 == num)
				{
				}
				num = (short)1981153280;
				if (num != 0)
				{
				}
				num = (short)2051866624;
				short num3 = num;
				num = (short)1576468481;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.Visible;
			}
			set
			{
				short num = (short)854598378;
				short num2 = num;
				num = (short)1876632298;
				switch (num2 == num)
				{
				}
				num = (short)1163329537;
				if (num != 0)
				{
				}
				num = (short)1142620160;
				short num3 = num;
				num = (short)1446248448;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.Visible = value;
			}
		}

		// Token: 0x17005499 RID: 21657
		// (get) Token: 0x0600A87B RID: 43131 RVA: 0x009C8910 File Offset: 0x009C6B10
		// (set) Token: 0x0600A87C RID: 43132 RVA: 0x009C89C4 File Offset: 0x009C6BC4
		public bool DataWideNATListStaticNATIPAddress_A9181_Editable
		{
			get
			{
				short num = (short)1033981269;
				short num2 = num;
				num = (short)675958101;
				switch (num2 == num)
				{
				}
				num = (short)1508966401;
				if (num != 0)
				{
				}
				num = (short)1461256192;
				short num3 = num;
				num = (short)691798016;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.Editable;
			}
			set
			{
				short num = (short)354222081;
				if (num != 0)
				{
				}
				num = (short)847050775;
				short num2 = num;
				num = (short)435615767;
				switch (num2 == num)
				{
				}
				num = (short)1408958464;
				short num3 = num;
				num = (short)635961344;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.Editable = value;
			}
		}

		// Token: 0x1700549A RID: 21658
		// (get) Token: 0x0600A87D RID: 43133 RVA: 0x009C8A7C File Offset: 0x009C6C7C
		internal string DataWideNATListStaticNATIPAddress_A9181_UILabel
		{
			get
			{
				short num = (short)318759689;
				short num2 = num;
				num = (short)175956745;
				switch (num2 == num)
				{
				}
				num = (short)176947200;
				if (num != 0)
				{
				}
				num = (short)1038942208;
				short num3 = num;
				num = (short)397082625;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.UIName;
			}
		}

		// Token: 0x1700549B RID: 21659
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x009C8B2C File Offset: 0x009C6D2C
		// (set) Token: 0x0600A87F RID: 43135 RVA: 0x009C8BE0 File Offset: 0x009C6DE0
		internal bool DataWideNATListStaticNATIPAddress_A9181_HiddenStatic
		{
			get
			{
				short num = (short)567888680;
				short num2 = num;
				num = (short)902318888;
				switch (num2 == num)
				{
				}
				num = (short)831127553;
				if (num != 0)
				{
				}
				num = (short)370737152;
				short num3 = num;
				num = (short)1819475968;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.HiddenStatic;
			}
			set
			{
				short num = (short)2114837976;
				short num2 = num;
				num = (short)715775448;
				switch (num2 == num)
				{
				}
				num = (short)84148224;
				if (num != 0)
				{
				}
				num = (short)1824522240;
				short num3 = num;
				num = (short)926023681;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.HiddenStatic = value;
			}
		}

		// Token: 0x1700549C RID: 21660
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x009C8C94 File Offset: 0x009C6E94
		// (set) Token: 0x0600A881 RID: 43137 RVA: 0x009C8D48 File Offset: 0x009C6F48
		internal bool DataWideNATListStaticNATIPAddress_A9181_HiddenDynamic
		{
			get
			{
				short num = (short)1848655969;
				short num2 = num;
				num = (short)1333739617;
				switch (num2 == num)
				{
				}
				num = (short)656080896;
				if (num != 0)
				{
				}
				num = (short)574816256;
				short num3 = num;
				num = (short)715849729;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181.HiddenDynamic;
			}
			set
			{
				short num = (short)1157496833;
				if (num != 0)
				{
				}
				num = (short)1327100296;
				short num2 = num;
				num = (short)1171714440;
				switch (num2 == num)
				{
				}
				num = (short)1679425536;
				short num3 = num;
				num = (short)221118464;
				if (num != 0)
				{
				}
				this.dataWideNATListStaticNATIPAddress_A9181.HiddenDynamic = value;
			}
		}

		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x0600A882 RID: 43138 RVA: 0x009C8E00 File Offset: 0x009C7000
		public bool DataWideNATListStaticNATIPAddress_A9181_HasDiffs
		{
			get
			{
				short num = (short)1169943690;
				short num2 = num;
				num = (short)1979313290;
				switch (num2 == num)
				{
				}
				num = (short)1783758849;
				if (num != 0)
				{
				}
				num = (short)1145962496;
				short num3 = num;
				num = (short)1564082176;
				if (num != 0)
				{
				}
				return this.dataWideNATListStaticNATIPAddress_A9181._HasDiffs;
			}
		}

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x0600A883 RID: 43139 RVA: 0x009C8EB4 File Offset: 0x009C70B4
		// (set) Token: 0x0600A884 RID: 43140 RVA: 0x009C8F68 File Offset: 0x009C7168
		public int DataWideNATListWANPort_A9677Value
		{
			get
			{
				short num = (short)394292213;
				short num2 = num;
				num = (short)846752757;
				switch (num2 == num)
				{
				}
				num = (short)488833025;
				if (num != 0)
				{
				}
				num = (short)1059717120;
				short num3 = num;
				num = (short)365756416;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.Value;
			}
			set
			{
				short num = (short)356818636;
				short num2 = num;
				num = (short)17407692;
				switch (num2 == num)
				{
				}
				num = (short)541720577;
				if (num != 0)
				{
				}
				num = (short)214695936;
				short num3 = num;
				num = (short)2071265280;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.Value = value;
			}
		}

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x0600A885 RID: 43141 RVA: 0x009C901C File Offset: 0x009C721C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideNATListWANPort_A9677
		{
			get
			{
				short num = (short)1706138354;
				short num2 = num;
				num = (short)1631951602;
				switch (num2 == num)
				{
				}
				num = (short)41811969;
				if (num != 0)
				{
				}
				num = (short)316276736;
				short num3 = num;
				num = (short)932970496;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677;
			}
		}

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x009C90CC File Offset: 0x009C72CC
		// (set) Token: 0x0600A887 RID: 43143 RVA: 0x009C9180 File Offset: 0x009C7380
		public string DataWideNATListWANPort_A9677_UIValue
		{
			get
			{
				short num = (short)1313133398;
				short num2 = num;
				num = (short)61002582;
				switch (num2 == num)
				{
				}
				num = (short)1401094144;
				if (num != 0)
				{
				}
				num = (short)1209991168;
				short num3 = num;
				num = (short)22872065;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.UIValue;
			}
			set
			{
				short num = (short)1633774892;
				short num2 = num;
				num = (short)318401836;
				switch (num2 == num)
				{
				}
				num = (short)244121600;
				if (num != 0)
				{
				}
				num = (short)1853292544;
				short num3 = num;
				num = (short)2143354881;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.UIValue = value;
			}
		}

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x0600A888 RID: 43144 RVA: 0x009C9234 File Offset: 0x009C7434
		// (set) Token: 0x0600A889 RID: 43145 RVA: 0x009C92E8 File Offset: 0x009C74E8
		internal int DataWideNATListWANPort_A9677Min
		{
			get
			{
				short num = (short)430258053;
				short num2 = num;
				num = (short)1325217669;
				switch (num2 == num)
				{
				}
				num = (short)1767440384;
				if (num != 0)
				{
				}
				num = (short)2063335424;
				short num3 = num;
				num = (short)1610416129;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.Min;
			}
			set
			{
				short num = (short)193829623;
				short num2 = num;
				num = (short)351378167;
				switch (num2 == num)
				{
				}
				num = (short)818544640;
				if (num != 0)
				{
				}
				num = (short)1531248640;
				short num3 = num;
				num = (short)1972109313;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.Min = value;
			}
		}

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x0600A88A RID: 43146 RVA: 0x009C939C File Offset: 0x009C759C
		// (set) Token: 0x0600A88B RID: 43147 RVA: 0x009C9450 File Offset: 0x009C7650
		internal int DataWideNATListWANPort_A9677Max
		{
			get
			{
				short num = (short)1404847697;
				short num2 = num;
				num = (short)1194608209;
				switch (num2 == num)
				{
				}
				num = (short)2093547521;
				if (num != 0)
				{
				}
				num = (short)1372782592;
				short num3 = num;
				num = (short)1067909120;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.Max;
			}
			set
			{
				short num = (short)623337881;
				short num2 = num;
				num = (short)2145542553;
				switch (num2 == num)
				{
				}
				num = (short)1526988801;
				if (num != 0)
				{
				}
				num = (short)1851260928;
				short num3 = num;
				num = (short)53673984;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.Max = value;
			}
		}

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x0600A88C RID: 43148 RVA: 0x009C9508 File Offset: 0x009C7708
		// (set) Token: 0x0600A88D RID: 43149 RVA: 0x009C95C0 File Offset: 0x009C77C0
		internal int DataWideNATListWANPort_A9677Step
		{
			get
			{
				short num = (short)1835025342;
				short num2 = num;
				num = (short)1538409406;
				switch (num2 == num)
				{
				}
				num = (short)1387528193;
				if (num != 0)
				{
				}
				num = (short)1423638528;
				short num3 = num;
				num = (short)187367424;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.StepSize;
			}
			set
			{
				short num = (short)458649428;
				short num2 = num;
				num = (short)949710676;
				switch (num2 == num)
				{
				}
				num = (short)1257439233;
				if (num != 0)
				{
				}
				num = (short)190709760;
				short num3 = num;
				num = (short)170721280;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.StepSize = value;
			}
		}

		// Token: 0x170054A4 RID: 21668
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x009C9674 File Offset: 0x009C7874
		// (set) Token: 0x0600A88F RID: 43151 RVA: 0x009C9728 File Offset: 0x009C7928
		public bool DataWideNATListWANPort_A9677_Applicable
		{
			get
			{
				short num = (short)1410042077;
				short num2 = num;
				num = (short)402884829;
				switch (num2 == num)
				{
				}
				num = (short)694550529;
				if (num != 0)
				{
				}
				num = (short)1248002048;
				short num3 = num;
				num = (short)347602944;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.Applicable;
			}
			set
			{
				short num = (short)1193971198;
				short num2 = num;
				num = (short)1917029886;
				switch (num2 == num)
				{
				}
				num = (short)266076160;
				if (num != 0)
				{
				}
				num = (short)1753546752;
				short num3 = num;
				num = (short)263454721;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.Applicable = value;
			}
		}

		// Token: 0x170054A5 RID: 21669
		// (get) Token: 0x0600A890 RID: 43152 RVA: 0x009C97E0 File Offset: 0x009C79E0
		// (set) Token: 0x0600A891 RID: 43153 RVA: 0x009C9894 File Offset: 0x009C7A94
		public bool DataWideNATListWANPort_A9677_Valid
		{
			get
			{
				short num = (short)744736432;
				short num2 = num;
				num = (short)118998704;
				switch (num2 == num)
				{
				}
				num = (short)327352321;
				if (num != 0)
				{
				}
				num = (short)703660032;
				short num3 = num;
				num = (short)472383488;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.Valid;
			}
			set
			{
				short num = (short)641523891;
				short num2 = num;
				num = (short)1999757491;
				switch (num2 == num)
				{
				}
				num = (short)2102394881;
				if (num != 0)
				{
				}
				num = (short)1931739136;
				short num3 = num;
				num = (short)1221656576;
				if (num != 0)
				{
				}
				this.dataWideNATListWANPort_A9677.Valid = value;
			}
		}

		// Token: 0x170054A6 RID: 21670
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x009C994C File Offset: 0x009C7B4C
		// (set) Token: 0x0600A893 RID: 43155 RVA: 0x009C9A04 File Offset: 0x009C7C04
		public bool DataWideNATListWANPort_A9677_Visible
		{
			get
			{
				short num = (short)515056360;
				short num2 = num;
				num = (short)509616872;
				switch (num2 == num)
				{
				}
				num = (short)544473088;
				if (num != 0)
				{
				}
				num = (short)217972736;
				short num3 = num;
				num = (short)1060962305;
				if (num != 0)
				{
				}
				return this.dataWideNATListWANPort_A9677.Visible;
			}
			set
			{
				short num = (short)360224886;
				short num2 = num;
				num = (short)1160026230;
				switch (num2 == num)
				{
				}
				num = (short)252772353;
				if (num != 0)
				{
				}
				num = (short)627965952;
				if (num != 0)
				{
				}
				num = (short)312672256;
				short num3 = num;
				this.dataWideNATListWANPort_A9677.Visible = value;
			}
		}

		// Token: 0x170054A7 RID: 21671
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x009C9AB8 File Offset: 0x009C7CB8
		// (set) Token: 0x0600A895 RID: 43157 RVA: 0x009C9B6C File Offset: 0x009C7D6C
		public bool DataWideNATListWANPort_A9677_Editable
		{
			get
			{
				short num = (short)7208961;
				if (num != 0)
				{
				}
				num = (short)1967853074;
				short num2 = num;
				num = (short)149032466;
				switch (num2 == num)
				{
				}
				num = (short)1614020608;
				if (num != 0)
				{
				}
				num = (short)1089011712;
				short num3 = num;
				return this.dataWideNATListWANPort_A9677.Editable;
			}
			set
			{
				short num = (short)1871315358;
				short num2 = num;
				num = (short)664338846;
				switch (num2 == num)
				{
				}
				num = (short)1594884097;
				if (num != 0)
				{
				}
				num = (short)889913344;
				if (num != 0)
				{
				}
				num = (short)2116943872;
				short num3 = num;
				this.dataWideNATListWANPort_A9677.Editable = value;
			}
		}

		// Token: 0x170054A8 RID: 21672
		// (get) Token: 0x0600A896 RID: 43158 RVA: 0x009C9C20 File Offset: 0x009C7E20
		internal string DataWideNATListWANPort_A9677_UILabel
		{
			get
			{
				short num = (short)655176995;
				short num2 = num;
				num = (short)76625187;
				switch (num2 == num)
				{
				}
				num = (short)2143944705;
				if (num != 0)
				{
				}
				num = (short)1955463168;
				if (num != 0)
				{
				}
				num = (short)1422524416;
				short num3 = num;
				return this.dataWideNATListWANPort_A9677.UIName;
			}
		}

		// Token: 0x170054A9 RID: 21673
		// (get) Token: 0x0600A897 RID: 43159 RVA: 0x009C9CD8 File Offset: 0x009C7ED8
		// (set) Token: 0x0600A898 RID: 43160 RVA: 0x009C9D8C File Offset: 0x009C7F8C
		internal bool DataWideNATListWANPort_A9677_HiddenStatic
		{
			get
			{
				short num = (short)524140525;
				short num2 = num;
				num = (short)1088667629;
				switch (num2 == num)
				{
				}
				num = (short)519634945;
				if (num != 0)
				{
				}
				num = (short)1489567744;
				if (num != 0)
				{
				}
				num = (short)2126315520;
				short num3 = num;
				return this.dataWideNATListWANPort_A9677.HiddenStatic;
			}
			set
			{
				short num = (short)354511111;
				short num2 = num;
				num = (short)219244807;
				switch (num2 == num)
				{
				}
				num = (short)250281985;
				if (num != 0)
				{
				}
				num = (short)1815609344;
				if (num != 0)
				{
				}
				num = (short)222298112;
				short num3 = num;
				this.dataWideNATListWANPort_A9677.HiddenStatic = value;
			}
		}

		// Token: 0x170054AA RID: 21674
		// (get) Token: 0x0600A899 RID: 43161 RVA: 0x009C9E40 File Offset: 0x009C8040
		// (set) Token: 0x0600A89A RID: 43162 RVA: 0x009C9EF4 File Offset: 0x009C80F4
		internal bool DataWideNATListWANPort_A9677_HiddenDynamic
		{
			get
			{
				short num = (short)965897948;
				short num2 = num;
				num = (short)1828613852;
				switch (num2 == num)
				{
				}
				num = (short)49152000;
				if (num != 0)
				{
				}
				num = (short)208076801;
				if (num != 0)
				{
				}
				num = (short)1417805824;
				short num3 = num;
				return this.dataWideNATListWANPort_A9677.HiddenDynamic;
			}
			set
			{
				short num = (short)45152371;
				short num2 = num;
				num = (short)939063411;
				switch (num2 == num)
				{
				}
				num = (short)1061224448;
				if (num != 0)
				{
				}
				num = (short)1116602369;
				if (num != 0)
				{
				}
				num = (short)868745216;
				short num3 = num;
				this.dataWideNATListWANPort_A9677.HiddenDynamic = value;
			}
		}

		// Token: 0x170054AB RID: 21675
		// (get) Token: 0x0600A89B RID: 43163 RVA: 0x009C9FAC File Offset: 0x009C81AC
		public bool DataWideNATListWANPort_A9677_HasDiffs
		{
			get
			{
				short num = (short)919271567;
				short num2 = num;
				num = (short)1568143503;
				switch (num2 == num)
				{
				}
				num = (short)1828519937;
				if (num != 0)
				{
				}
				num = (short)394264576;
				if (num != 0)
				{
				}
				num = (short)1001652224;
				short num3 = num;
				return this.dataWideNATListWANPort_A9677._HasDiffs;
			}
		}

		// Token: 0x170054AC RID: 21676
		// (get) Token: 0x0600A89C RID: 43164 RVA: 0x009CA064 File Offset: 0x009C8264
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1391144784;
				short num2 = num;
				num = (short)1917988688;
				switch (num2 == num)
				{
				}
				num = (short)1718026241;
				if (num != 0)
				{
				}
				num = (short)115867648;
				if (num != 0)
				{
				}
				num = (short)1242431488;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x009CA124 File Offset: 0x009C8324
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1358626820;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)147390467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)997785601;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)640352257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1513422848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_129;
				}
				goto IL_24;
			}
			IL_129:
			return result;
			IL_24:
			num2 = (short)736100352;
			short num3 = num2;
			num2 = (short)1107519846;
			short num4 = num2;
			num2 = (short)903178598;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num2 = (short)272957440;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)57671682;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04005139 RID: 20793
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideNATListLANPort_A8385;

		// Token: 0x0400513A RID: 20794
		private global::AcpBusinessLayer.AcpIPAddressField dataWideNATListStaticNATIPAddress_A9181;

		// Token: 0x0400513B RID: 20795
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideNATListWANPort_A9677;
	}
}
