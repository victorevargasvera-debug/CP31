using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E8 RID: 488
	[global::System.Serializable]
	public class TrunkingProductIndependentButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005530 RID: 21808 RVA: 0x004D4DF0 File Offset: 0x004D2FF0
		public TrunkingProductIndependentButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x004D4E30 File Offset: 0x004D3030
		protected TrunkingProductIndependentButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x004D4E48 File Offset: 0x004D3048
		public override void Init()
		{
			int a_ = 14;
			short num = (short)392802593;
			short num2 = num;
			num = (short)676376865;
			switch (num2 == num)
			{
			default:
			{
				num = (short)621084672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)366280705;
			if (num != 0)
			{
			}
			num = (short)521928704;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯎ꏐꛒ믔볖냘뗚뫜￞뇠釢諤菦鳨裪駬쿮룰鷲釴鋶觸黺鏼鯾搀洂焄✆䬈縊礌笎縐紒", a_);
			base.Id = 10027;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTON;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x004D4F30 File Offset: 0x004D3130
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1925933753;
			short num2 = num;
			num = (short)519858873;
			switch (num2 == num)
			{
			default:
			{
				num = (short)257687552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1505951744;
			if (num != 0)
			{
			}
			num = (short)842727425;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駌뷎ꓐ뷒뻔뻖럘볚﷜连鏠賢臤鋦諨鿪췬ꛮ鿰韲郴蟶鳸闺駼髾漀眂┄䔆簈缊礌怎缐", a_);
			base.Id = 10027;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTON;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x004D5014 File Offset: 0x004D3214
		public override void PopulateReferences()
		{
			short num = (short)877747054;
			short num2 = num;
			num = (short)1117084526;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1858404352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1008599041;
			if (num != 0)
			{
			}
			num = (short)1549860864;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x004D50C0 File Offset: 0x004D32C0
		public override void DropReferences()
		{
			short num = (short)1296300101;
			short num2 = num;
			num = (short)666630213;
			switch (num2 == num)
			{
			default:
			{
				num = (short)169148416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)781844480;
			if (num != 0)
			{
			}
			num = (short)270467073;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x004D516C File Offset: 0x004D336C
		public override void SetConstraints()
		{
			short num = (short)1278617041;
			short num2 = num;
			num = (short)89007569;
			switch (num2 == num)
			{
			}
			num = (short)1936326656;
			short num3 = num;
			num = (short)979763200;
			if (num != 0)
			{
			}
			num = (short)926089217;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x004D5218 File Offset: 0x004D3418
		public override void SetupDependencies()
		{
			short num = (short)494272916;
			short num2 = num;
			num = (short)1124073876;
			switch (num2 == num)
			{
			}
			num = (short)416415744;
			short num3 = num;
			num = (short)1452212225;
			if (num != 0)
			{
			}
			num = (short)1809252352;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06005538 RID: 21816 RVA: 0x004D52C4 File Offset: 0x004D34C4
		public bool HasDiffs
		{
			get
			{
				short num = (short)2104819713;
				if (num != 0)
				{
				}
				num = (short)1236651646;
				short num2 = num;
				num = (short)1516555902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2006908928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1079312384;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x004D5374 File Offset: 0x004D3574
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
				{
					num2 = (short)1928719317;
					short num3 = num2;
					num2 = (short)2135747541;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)1319043072;
						if (num2 != 0)
						{
						}
						num2 = (short)521207808;
						short num4 = num2;
						num2 = (short)1518731265;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1575878656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)805044225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)440336388;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1901264898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)384172035;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002173 RID: 8563
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerRecset innerRecset;
	}
}
