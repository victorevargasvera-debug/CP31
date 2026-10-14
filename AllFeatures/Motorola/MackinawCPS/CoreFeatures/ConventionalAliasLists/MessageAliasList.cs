using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D4 RID: 1492
	[global::System.Serializable]
	public class MessageAliasList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CE78 RID: 52856 RVA: 0x00C027E0 File Offset: 0x00C009E0
		public MessageAliasList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600CE79 RID: 52857 RVA: 0x00C02820 File Offset: 0x00C00A20
		protected MessageAliasList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CE7A RID: 52858 RVA: 0x00C02838 File Offset: 0x00C00A38
		public override void Init()
		{
			int a_ = 8;
			short num = (short)527172061;
			short num2 = num;
			num = (short)566362589;
			switch (num2 == num)
			{
			}
			num = (short)1847525377;
			if (num != 0)
			{
			}
			num = (short)1033568256;
			if (num != 0)
			{
			}
			num = (short)1555628032;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓈껊뻌볎냐듒냔飘럚드뻞鋠쏢ꧤ軦髨鿪", a_);
			base.Id = 10012;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIASLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CE7B RID: 52859 RVA: 0x00C0291C File Offset: 0x00C00B1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)28722136;
			short num2 = num;
			num = (short)347227096;
			switch (num2 == num)
			{
			}
			num = (short)327221249;
			if (num != 0)
			{
			}
			num = (short)126353408;
			if (num != 0)
			{
			}
			num = (short)655556608;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藇꿉뿋뷍뇏뗑뇓駗뛙뗛뿝鏟싡꣣迥鯧黩", a_);
			base.Id = 10012;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIASLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CE7C RID: 52860 RVA: 0x00C02A00 File Offset: 0x00C00C00
		public override void PopulateReferences()
		{
			short num = (short)2117932847;
			short num2 = num;
			num = (short)771299119;
			switch (num2 == num)
			{
			}
			num = (short)1995964417;
			if (num != 0)
			{
			}
			num = (short)882573312;
			if (num != 0)
			{
			}
			num = (short)1978662912;
			short num3 = num;
		}

		// Token: 0x0600CE7D RID: 52861 RVA: 0x00C02AAC File Offset: 0x00C00CAC
		public override void DropReferences()
		{
			short num = (short)571430655;
			short num2 = num;
			num = (short)1146640127;
			switch (num2 == num)
			{
			}
			num = (short)13041665;
			if (num != 0)
			{
			}
			num = (short)2072444928;
			if (num != 0)
			{
			}
			num = (short)2133655552;
			short num3 = num;
		}

		// Token: 0x0600CE7E RID: 52862 RVA: 0x00C02B58 File Offset: 0x00C00D58
		public override void SetConstraints()
		{
			short num = (short)677697283;
			short num2 = num;
			num = (short)48748291;
			switch (num2 == num)
			{
			}
			num = (short)1934295041;
			if (num != 0)
			{
			}
			num = (short)1236402176;
			if (num != 0)
			{
			}
			num = (short)1368981504;
			short num3 = num;
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x00C02C04 File Offset: 0x00C00E04
		public override void SetupDependencies()
		{
			short num = (short)184076686;
			short num2 = num;
			num = (short)1695402382;
			switch (num2 == num)
			{
			default:
			{
				num = (short)745209856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2131755008;
			if (num != 0)
			{
			}
			num = (short)1581252609;
			if (num != 0)
			{
			}
		}

		// Token: 0x170067DB RID: 26587
		// (get) Token: 0x0600CE80 RID: 52864 RVA: 0x00C02CB0 File Offset: 0x00C00EB0
		public bool HasDiffs
		{
			get
			{
				short num = (short)941539340;
				short num2 = num;
				num = (short)641384460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089142784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1050804225;
				if (num != 0)
				{
				}
				num = (short)363069440;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x00C02D60 File Offset: 0x00C00F60
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
					num2 = (short)651821060;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_B5;
				case 2:
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1453981698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1590689795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_B5:
			num2 = (short)1425932289;
			if (num2 != 0)
			{
			}
			if (base.ParentRecset != null)
			{
				goto IL_E7;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1910893413;
			short num3 = num2;
			num2 = (short)138996581;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E7:
				num2 = (short)713818112;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1442381824;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)338690048;
			if (num2 != 0)
			{
			}
			num2 = (short)2137260033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400653A RID: 25914
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerRecset innerRecset;
	}
}
