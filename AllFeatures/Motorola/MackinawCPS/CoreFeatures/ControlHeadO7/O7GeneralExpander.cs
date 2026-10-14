using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200039C RID: 924
	[global::System.Serializable]
	public class O7GeneralExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008768 RID: 34664 RVA: 0x007E2A4C File Offset: 0x007E0C4C
		public O7GeneralExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x007E2A8C File Offset: 0x007E0C8C
		protected O7GeneralExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x007E2AA4 File Offset: 0x007E0CA4
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1691748536;
			short num2 = num;
			num = (short)1776945336;
			switch (num2 == num)
			{
			}
			num = (short)1155268608;
			short num3 = num;
			num = (short)1351680000;
			if (num != 0)
			{
			}
			num = (short)482803713;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裎듐뷒냔ꗖ룘럚", a_);
			base.Id = 10719;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x007E2B84 File Offset: 0x007E0D84
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)1497914246;
			short num2 = num;
			num = (short)583818118;
			switch (num2 == num)
			{
			}
			num = (short)331415552;
			short num3 = num;
			num = (short)605290496;
			if (num != 0)
			{
			}
			num = (short)1961754625;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诋ꯍ뻏럑ꛓ럕듗", a_);
			base.Id = 10719;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x007E2C68 File Offset: 0x007E0E68
		public override void PopulateReferences()
		{
			short num = (short)1972796998;
			short num2 = num;
			num = (short)815824454;
			switch (num2 == num)
			{
			}
			num = (short)1156841472;
			short num3 = num;
			num = (short)1429405697;
			if (num != 0)
			{
			}
			num = (short)335020032;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x007E2D14 File Offset: 0x007E0F14
		public override void DropReferences()
		{
			short num = (short)1118002012;
			short num2 = num;
			num = (short)1321818972;
			switch (num2 == num)
			{
			}
			num = (short)1072889856;
			short num3 = num;
			num = (short)1550581760;
			if (num != 0)
			{
			}
			num = (short)1029767169;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x007E2DC0 File Offset: 0x007E0FC0
		public override void SetConstraints()
		{
			short num = (short)173140053;
			short num2 = num;
			num = (short)233891925;
			switch (num2 == num)
			{
			}
			num = (short)634388480;
			short num3 = num;
			num = (short)1716125696;
			if (num != 0)
			{
			}
			num = (short)866910209;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x007E2E68 File Offset: 0x007E1068
		public override void SetupDependencies()
		{
			short num = (short)1675530948;
			short num2 = num;
			num = (short)798724804;
			switch (num2 == num)
			{
			}
			num = (short)1464991745;
			if (num != 0)
			{
			}
			num = (short)1538392064;
			if (num != 0)
			{
			}
			num = (short)715522048;
			short num3 = num;
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x06008770 RID: 34672 RVA: 0x007E2F10 File Offset: 0x007E1110
		public bool HasDiffs
		{
			get
			{
				short num = (short)1258244868;
				short num2 = num;
				num = (short)1590774532;
				switch (num2 == num)
				{
				}
				num = (short)539230209;
				if (num != 0)
				{
				}
				num = (short)468910080;
				if (num != 0)
				{
				}
				num = (short)1124073472;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x007E2FC0 File Offset: 0x007E11C0
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1353318403;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)364445698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_D4;
					}
					goto IL_ED;
				case 3:
					goto IL_ED;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)520355841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_ED;
				}
				goto IL_24;
				IL_D4:
				num2 = (short)1740046336;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_ED:
				num2 = (short)1974453725;
				short num3 = num2;
				num2 = (short)171492829;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D4;
				default:
					goto IL_121;
				}
			}
			IL_121:
			num2 = (short)1931804672;
			if (num2 != 0)
			{
			}
			num2 = (short)174129153;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)655360000;
			short num4 = num2;
			num2 = (short)131465220;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003FEE RID: 16366
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset innerRecset;
	}
}
