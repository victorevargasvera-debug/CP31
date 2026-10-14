using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200006D RID: 109
	[global::System.Serializable]
	public class ControlChannels : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000C1A RID: 3098 RVA: 0x000CA7A8 File Offset: 0x000C89A8
		public ControlChannels(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000CA7E8 File Offset: 0x000C89E8
		protected ControlChannels(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000CA800 File Offset: 0x000C8A00
		public override void Init()
		{
			int a_ = 1;
			short num = (short)385270033;
			short num2 = num;
			num = (short)55230737;
			switch (num2 == num)
			{
			}
			num = (short)1706950657;
			if (num != 0)
			{
			}
			num = (short)1989541888;
			if (num != 0)
			{
			}
			num = (short)1848967168;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ볇룉ꏋꋍ金볓럕뛗듙맛닝鏟", a_);
			base.Id = 10169;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLCHANNELS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000CA8E4 File Offset: 0x000C8AE4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)353210239;
			short num2 = num;
			num = (short)790335359;
			switch (num2 == num)
			{
			}
			num = (short)959840257;
			if (num != 0)
			{
			}
			num = (short)742391808;
			if (num != 0)
			{
			}
			num = (short)181469184;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郒뫔맖귘꧚닜돞쇠ꃢ跤蛦蟨藪裬菮苰", a_);
			base.Id = 10169;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLCHANNELS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000CA9C8 File Offset: 0x000C8BC8
		public override void PopulateReferences()
		{
			short num = (short)1959308235;
			short num2 = num;
			num = (short)1431743435;
			switch (num2 == num)
			{
			}
			num = (short)264044545;
			if (num != 0)
			{
			}
			num = (short)2092367872;
			if (num != 0)
			{
			}
			num = (short)1604452352;
			short num3 = num;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000CAA70 File Offset: 0x000C8C70
		public override void DropReferences()
		{
			short num = (short)1788544019;
			short num2 = num;
			num = (short)1347945491;
			switch (num2 == num)
			{
			}
			num = (short)2092761089;
			if (num != 0)
			{
			}
			num = (short)1162084352;
			if (num != 0)
			{
			}
			num = (short)285212672;
			short num3 = num;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000CAB18 File Offset: 0x000C8D18
		public override void SetConstraints()
		{
			short num = (short)2025939276;
			short num2 = num;
			num = (short)186933580;
			switch (num2 == num)
			{
			}
			num = (short)1286930432;
			if (num != 0)
			{
			}
			num = (short)1459290113;
			if (num != 0)
			{
			}
			num = (short)184745984;
			short num3 = num;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000CABC8 File Offset: 0x000C8DC8
		public override void SetupDependencies()
		{
			short num = (short)231508424;
			short num2 = num;
			num = (short)1892125128;
			switch (num2 == num)
			{
			}
			num = (short)1236598784;
			if (num != 0)
			{
			}
			num = (short)1135542273;
			if (num != 0)
			{
			}
			num = (short)1278279680;
			short num3 = num;
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000CAC74 File Offset: 0x000C8E74
		public bool HasDiffs
		{
			get
			{
				short num = (short)830403943;
				short num2 = num;
				num = (short)1475081575;
				switch (num2 == num)
				{
				}
				num = (short)476971009;
				if (num != 0)
				{
				}
				num = (short)814153728;
				if (num != 0)
				{
				}
				num = (short)1042022400;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000CAD24 File Offset: 0x000C8F24
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_16A;
				case 1:
					num2 = (short)219348994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1680146432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_101;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1093664769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_101:
			num2 = (short)1694826497;
			if (num2 != 0)
			{
			}
			return result;
			IL_16A:
			goto IL_D6;
			IL_24:
			num2 = (short)1664877486;
			short num3 = num2;
			num2 = (short)1367999406;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D6:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)72876035;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1385693184;
				short num4 = num2;
				num2 = (short)1138753536;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)311885828;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000352 RID: 850
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset innerRecset;
	}
}
