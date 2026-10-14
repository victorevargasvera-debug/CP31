using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200045D RID: 1117
	[global::System.Serializable]
	public class RxSSIRateTXMode : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060094B6 RID: 38070 RVA: 0x008BF970 File Offset: 0x008BDB70
		public RxSSIRateTXMode(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x008BF9B0 File Offset: 0x008BDBB0
		protected RxSSIRateTXMode(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x008BF9C8 File Offset: 0x008BDBC8
		public override void Init()
		{
			int a_ = 10;
			short num = (short)200146945;
			if (num != 0)
			{
			}
			num = (short)11716184;
			short num2 = num;
			num = (short)1002358360;
			switch (num2 == num)
			{
			default:
			{
				num = (short)522059776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1880162304;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駊뗌苐胒鳔高럚닜볞諠쏢럤蛦鷨軪췬ꏮ飰胲致ퟶ쏸\udbfaꧼ蟾℀丂樄挆氈", a_);
			base.Id = 10801;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE;
			base.DataTransferOrder = 8;
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x008BFAAC File Offset: 0x008BDCAC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)674889183;
			short num2 = num;
			num = (short)1897987551;
			switch (num2 == num)
			{
			}
			num = (short)1725169664;
			short num3 = num;
			num = (short)582352897;
			if (num != 0)
			{
			}
			num = (short)1561788416;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郁볃鯇駉藋鏏뻑믓뗕돗龎軛뿝铟蟡쓣ꫥ臧駩飫컭쫯틱ꃳ軵\ud8f7럹鏻髽旿", a_);
			base.Id = 10801;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE;
			base.DataTransferOrder = 8;
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x008BFB90 File Offset: 0x008BDD90
		public override void PopulateReferences()
		{
			short num = (short)1867579393;
			if (num != 0)
			{
			}
			num = (short)59526210;
			short num2 = num;
			num = (short)81153090;
			switch (num2 == num)
			{
			default:
			{
				num = (short)549191680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)595197952;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x008BFC3C File Offset: 0x008BDE3C
		public override void DropReferences()
		{
			short num = (short)918322505;
			short num2 = num;
			num = (short)565280073;
			switch (num2 == num)
			{
			}
			num = (short)1562836992;
			short num3 = num;
			num = (short)785842177;
			if (num != 0)
			{
			}
			num = (short)880607232;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x008BFCE8 File Offset: 0x008BDEE8
		public override void SetConstraints()
		{
			short num = (short)1400912291;
			short num2 = num;
			num = (short)1038629283;
			switch (num2 == num)
			{
			}
			num = (short)1782513664;
			short num3 = num;
			num = (short)942866432;
			if (num != 0)
			{
			}
			num = (short)937623553;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x008BFD90 File Offset: 0x008BDF90
		public override void SetupDependencies()
		{
			short num = (short)1527809794;
			short num2 = num;
			num = (short)1808107266;
			switch (num2 == num)
			{
			}
			num = (short)1375666176;
			short num3 = num;
			num = (short)1038090240;
			if (num != 0)
			{
			}
			num = (short)900792321;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x060094BE RID: 38078 RVA: 0x008BFE3C File Offset: 0x008BE03C
		public bool HasDiffs
		{
			get
			{
				short num = (short)112001025;
				if (num != 0)
				{
				}
				num = (short)272263277;
				short num2 = num;
				num = (short)1736599661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60948480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824770560;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x008BFEEC File Offset: 0x008BE0EC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_97;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1263337473;
				if (num != 0)
				{
				}
				num = (short)1598589355;
				short num2 = num;
				num = (short)1685162411;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)551026688;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
					{
						num = (short)1603141632;
						short num4 = num;
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)852164610;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)818151424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset != null)
						{
							num = (short)1568931844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						goto IL_D3;
					}
					goto IL_97;
				}
				IL_D3:
				num = (short)773652481;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_97:
			result = null;
			num = (short)678363139;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040049F3 RID: 18931
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerRecset innerRecset;
	}
}
