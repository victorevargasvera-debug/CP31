using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200009B RID: 155
	[global::System.Serializable]
	public class OBTChannelAssignment : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060011DC RID: 4572 RVA: 0x00111C5C File Offset: 0x0010FE5C
		public OBTChannelAssignment(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00111C9C File Offset: 0x0010FE9C
		protected OBTChannelAssignment(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00111CB4 File Offset: 0x0010FEB4
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1671626752;
			short num2 = num;
			num = (short)195044724;
			short num3 = num;
			num = (short)1613571444;
			switch (num3 == num)
			{
			}
			num = (short)2023292929;
			if (num != 0)
			{
			}
			num = (short)1082064896;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裆诈鿊賎말닒믔맖볘럚﷜點鋠郢賤胦蟨蛪裬臮藰", a_);
			base.Id = 10167;
			base.UIName = global::CommonResources.AcgResources.ID_OBTCHANNELASSIGNMENT;
			base.DataTransferOrder = 9;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00111D98 File Offset: 0x0010FF98
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1867644928;
			short num2 = num;
			num = (short)1531712817;
			short num3 = num;
			num = (short)1400050993;
			switch (num3 == num)
			{
			}
			num = (short)593821696;
			if (num != 0)
			{
			}
			num = (short)263716865;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷑雓苕駙듛뿝軟賡臣諥죧ꯩ鿫鷭駯闱髳鯵鷷铹裻", a_);
			base.Id = 10167;
			base.UIName = global::CommonResources.AcgResources.ID_OBTCHANNELASSIGNMENT;
			base.DataTransferOrder = 9;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00111E80 File Offset: 0x00110080
		public override void PopulateReferences()
		{
			short num = (short)627638272;
			short num2 = num;
			num = (short)61158053;
			short num3 = num;
			num = (short)984167077;
			switch (num3 == num)
			{
			}
			num = (short)1574961153;
			if (num != 0)
			{
			}
			num = (short)915275776;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00111F28 File Offset: 0x00110128
		public override void DropReferences()
		{
			short num = (short)1158807552;
			short num2 = num;
			num = (short)1674863802;
			short num3 = num;
			num = (short)380003514;
			switch (num3 == num)
			{
			}
			num = (short)1454768129;
			if (num != 0)
			{
			}
			num = (short)687341568;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00111FD0 File Offset: 0x001101D0
		public override void SetConstraints()
		{
			short num = (short)521928704;
			short num2 = num;
			num = (short)2122690771;
			short num3 = num;
			num = (short)1383575763;
			switch (num3 == num)
			{
			}
			num = (short)695730177;
			if (num != 0)
			{
			}
			num = (short)156041216;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00112078 File Offset: 0x00110278
		public override void SetupDependencies()
		{
			short num = (short)1443430400;
			short num2 = num;
			num = (short)1257838820;
			short num3 = num;
			num = (short)2000558308;
			switch (num3 == num)
			{
			}
			num = (short)1394147329;
			if (num != 0)
			{
			}
			num = (short)1705639936;
			if (num != 0)
			{
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00112120 File Offset: 0x00110320
		public bool HasDiffs
		{
			get
			{
				short num = (short)1382023168;
				short num2 = num;
				num = (short)489648339;
				short num3 = num;
				num = (short)583299283;
				switch (num3 == num)
				{
				}
				num = (short)205848577;
				if (num != 0)
				{
				}
				num = (short)1968832512;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x001121D0 File Offset: 0x001103D0
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
					if (base.ParentRecset != null)
					{
						num2 = (short)1689321472;
						short num3 = num2;
						num2 = (short)549060612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F0;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2138898435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F0;
				case 2:
					goto IL_F0;
				case 3:
					IL_EE:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1616248834;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)259457025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_F0:
				num2 = (short)213958246;
				short num4 = num2;
				num2 = (short)322354790;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_EE;
				default:
					goto IL_126;
				}
			}
			IL_126:
			num2 = (short)578355201;
			if (num2 != 0)
			{
			}
			num2 = (short)999882752;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2144665600;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000449 RID: 1097
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset innerRecset;
	}
}
