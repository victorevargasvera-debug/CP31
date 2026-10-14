using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000419 RID: 1049
	[global::System.Serializable]
	public class SideArrowButtons : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008FDA RID: 36826 RVA: 0x008795F0 File Offset: 0x008777F0
		public SideArrowButtons(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x00879630 File Offset: 0x00877830
		protected SideArrowButtons(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x00879648 File Offset: 0x00877848
		public override void Init()
		{
			int a_ = 11;
			short num = (short)697932282;
			short num2 = num;
			num = (short)550869498;
			switch (num2 == num)
			{
			}
			num = (short)1879179264;
			short num3 = num;
			num = (short)941031424;
			if (num != 0)
			{
			}
			num = (short)1943797761;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿋ꟍ듏럑韕꫗꣙돛꧝샟ꃡ釣鋥鳧藩苫鷭", a_);
			base.Id = 10745;
			base.UIName = global::CommonResources.AcgResources.ID_SIDEARROWBUTTONS;
			base.DataTransferOrder = 150;
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x00879734 File Offset: 0x00877934
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1517650604;
			short num2 = num;
			num = (short)1578599084;
			switch (num2 == num)
			{
			}
			num = (short)2020933632;
			short num3 = num;
			num = (short)630980609;
			if (num != 0)
			{
			}
			num = (short)2048065536;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駉ꗋ꫍뗏闓ꓕ꫗뗙ꯛﻝꋟ韡郣鋥蟧蓩鿫", a_);
			base.Id = 10745;
			base.UIName = global::CommonResources.AcgResources.ID_SIDEARROWBUTTONS;
			base.DataTransferOrder = 150;
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x00879820 File Offset: 0x00877A20
		public override void PopulateReferences()
		{
			short num = (short)1355357426;
			short num2 = num;
			num = (short)694951154;
			switch (num2 == num)
			{
			}
			num = (short)876085248;
			short num3 = num;
			num = (short)1449852929;
			if (num != 0)
			{
			}
			num = (short)1878917120;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x008798CC File Offset: 0x00877ACC
		public override void DropReferences()
		{
			short num = (short)575471617;
			if (num != 0)
			{
			}
			num = (short)1693339354;
			short num2 = num;
			num = (short)2122010330;
			switch (num2 == num)
			{
			default:
			{
				num = (short)515375104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)208076800;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x0087997C File Offset: 0x00877B7C
		public override void SetConstraints()
		{
			short num = (short)1301637184;
			short num2 = num;
			num = (short)898984000;
			switch (num2 == num)
			{
			}
			num = (short)612630528;
			short num3 = num;
			num = (short)986316801;
			if (num != 0)
			{
			}
			num = (short)1362165760;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008FE1 RID: 36833 RVA: 0x00879A24 File Offset: 0x00877C24
		public override void SetupDependencies()
		{
			short num = (short)1699938986;
			short num2 = num;
			num = (short)1333199530;
			switch (num2 == num)
			{
			}
			num = (short)966393856;
			short num3 = num;
			num = (short)1777467393;
			if (num != 0)
			{
			}
			num = (short)952369152;
			if (num != 0)
			{
			}
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x06008FE2 RID: 36834 RVA: 0x00879ACC File Offset: 0x00877CCC
		public bool HasDiffs
		{
			get
			{
				short num = (short)534928233;
				short num2 = num;
				num = (short)520248169;
				switch (num2 == num)
				{
				}
				num = (short)1494810624;
				short num3 = num;
				num = (short)1557135361;
				if (num != 0)
				{
				}
				num = (short)1829896192;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x00879B7C File Offset: 0x00877D7C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1406271489;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)57737216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)130765495;
					short num3 = num;
					num = (short)1799312055;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1282473984;
						if (num != 0)
						{
						}
						num = (short)1752891395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1262747649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)1205403650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4C;
			}
			return result;
			IL_4C:
			result = null;
			num = (short)1171587072;
			short num4 = num;
			num = (short)598147076;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0400478E RID: 18318
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset innerRecset;
	}
}
