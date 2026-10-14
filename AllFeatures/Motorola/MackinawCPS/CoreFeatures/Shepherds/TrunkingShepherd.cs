using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001EC RID: 492
	[global::System.Serializable]
	public class TrunkingShepherd : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005566 RID: 21862 RVA: 0x004D73B8 File Offset: 0x004D55B8
		public TrunkingShepherd(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x004D73F8 File Offset: 0x004D55F8
		protected TrunkingShepherd(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x004D7410 File Offset: 0x004D5610
		public override void Init()
		{
			int a_ = 11;
			short num = (short)384007154;
			short num2 = num;
			num = (short)2105834482;
			switch (num2 == num)
			{
			}
			num = (short)1746206720;
			short num3 = num;
			num = (short)2135425024;
			if (num != 0)
			{
			}
			num = (short)1451163649;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飋볍ꗏ병뿓뿕뛗뷙ﳛ距裟蟡铣軥跧飩裫", a_);
			base.Id = 10037;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERD;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x004D74F4 File Offset: 0x004D56F4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)914420450;
			short num2 = num;
			num = (short)1118827234;
			switch (num2 == num)
			{
			}
			num = (short)526712832;
			short num3 = num;
			num = (short)851574785;
			if (num != 0)
			{
			}
			num = (short)1008730112;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯎ꏐꛒ믔볖냘뗚뫜￞닠询胤韦臨軪鿬诮", a_);
			base.Id = 10037;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERD;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x004D75D8 File Offset: 0x004D57D8
		public override void PopulateReferences()
		{
			short num = (short)120789072;
			short num2 = num;
			num = (short)788994128;
			switch (num2 == num)
			{
			}
			num = (short)1979908096;
			short num3 = num;
			num = (short)1514471425;
			if (num != 0)
			{
			}
			num = (short)1717305344;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x004D7680 File Offset: 0x004D5880
		public override void DropReferences()
		{
			short num = (short)1084569725;
			short num2 = num;
			num = (short)360986749;
			switch (num2 == num)
			{
			}
			num = (short)1637941248;
			short num3 = num;
			num = (short)848429057;
			if (num != 0)
			{
			}
			num = (short)1932132352;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x004D7728 File Offset: 0x004D5928
		public override void SetConstraints()
		{
			short num = (short)78239612;
			short num2 = num;
			num = (short)1727649660;
			switch (num2 == num)
			{
			}
			num = (short)1384251392;
			short num3 = num;
			num = (short)1769668608;
			if (num != 0)
			{
			}
			num = (short)513277953;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x004D77D0 File Offset: 0x004D59D0
		public override void SetupDependencies()
		{
			short num = (short)1156361783;
			short num2 = num;
			num = (short)1250799159;
			switch (num2 == num)
			{
			}
			num = (short)1818165248;
			short num3 = num;
			num = (short)1671168001;
			if (num != 0)
			{
			}
			num = (short)129957888;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0600556E RID: 21870 RVA: 0x004D787C File Offset: 0x004D5A7C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1814046775;
				short num2 = num;
				num = (short)1388193847;
				switch (num2 == num)
				{
				}
				num = (short)835256320;
				short num3 = num;
				num = (short)108724224;
				if (num != 0)
				{
				}
				num = (short)1001062401;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x004D792C File Offset: 0x004D5B2C
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
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						goto IL_45;
					}
					return result;
				case 2:
					num2 = (short)1978400772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1258431481;
					short num3 = num2;
					num2 = (short)864297977;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45;
					case 1:
						break;
					default:
					{
						num2 = (short)1607991296;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)220397569;
					if (num2 != 0)
					{
					}
					num2 = (short)1723465728;
					if (num2 != 0)
					{
					}
					num2 = (short)1661927424;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1606942723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_45:
				num2 = (short)573112322;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1686962177;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400217A RID: 8570
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset innerRecset;
	}
}
