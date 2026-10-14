using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000319 RID: 793
	[global::System.Serializable]
	public class KMANavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007C2B RID: 31787 RVA: 0x0071EBA8 File Offset: 0x0071CDA8
		public KMANavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x0071EBE8 File Offset: 0x0071CDE8
		protected KMANavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x0071EC00 File Offset: 0x0071CE00
		public override void Init()
		{
			int a_ = 11;
			short num = (short)1025660566;
			short num2 = num;
			num = (short)122574486;
			switch (num2 == num)
			{
			}
			num = (short)1410924545;
			if (num != 0)
			{
			}
			num = (short)1595211776;
			short num3 = num;
			num = (short)1893990400;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苋꿍ꛏ믑돓럕곗동돛냝샟ꇡ诣裥鳧飩菫苭華", a_);
			base.Id = 10753;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x0071ECE8 File Offset: 0x0071CEE8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)619435754;
			short num2 = num;
			num = (short)2111035114;
			switch (num2 == num)
			{
			}
			num = (short)1298792448;
			if (num != 0)
			{
			}
			num = (short)1221787648;
			short num3 = num;
			num = (short)313196545;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳑뗓ꃕ뇗뷙뷛ꫝ觟跡諣웥ꯧ藩苫髭苯鷱飳藵", a_);
			base.Id = 10753;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x0071EDD0 File Offset: 0x0071CFD0
		public override void PopulateReferences()
		{
			short num = (short)875823105;
			if (num != 0)
			{
			}
			num = (short)1877921954;
			short num2 = num;
			num = (short)1127141538;
			switch (num2 == num)
			{
			}
			num = (short)1368129536;
			short num3 = num;
			num = (short)1205141504;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x0071EE78 File Offset: 0x0071D078
		public override void DropReferences()
		{
			short num = (short)1940153800;
			short num2 = num;
			num = (short)1951032776;
			switch (num2 == num)
			{
			}
			num = (short)1085341697;
			if (num != 0)
			{
			}
			num = (short)1243807744;
			short num3 = num;
			num = (short)1011482624;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x0071EF20 File Offset: 0x0071D120
		public override void SetConstraints()
		{
			short num = (short)1662016731;
			short num2 = num;
			num = (short)95116507;
			switch (num2 == num)
			{
			}
			num = (short)976158721;
			if (num != 0)
			{
			}
			num = (short)563871744;
			short num3 = num;
			num = (short)510197760;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x0071EFCC File Offset: 0x0071D1CC
		public override void SetupDependencies()
		{
			short num = (short)787862551;
			short num2 = num;
			num = (short)801100823;
			switch (num2 == num)
			{
			}
			num = (short)1668284417;
			if (num != 0)
			{
			}
			num = (short)1695678464;
			short num3 = num;
			num = (short)1374879744;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x06007C33 RID: 31795 RVA: 0x0071F074 File Offset: 0x0071D274
		public bool HasDiffs
		{
			get
			{
				short num = (short)749771233;
				short num2 = num;
				num = (short)656513505;
				switch (num2 == num)
				{
				}
				num = (short)111804417;
				if (num != 0)
				{
				}
				num = (short)651886592;
				short num3 = num;
				num = (short)424673280;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x0071F124 File Offset: 0x0071D324
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)329973760;
						short num3 = num2;
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1401683970;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 1:
						return result;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1699282945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)1840578560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						num2 = (short)519809939;
						short num4 = num2;
						num2 = (short)156085139;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D;
						default:
							num2 = (short)2133983232;
							if (num2 != 0)
							{
							}
							if (base.ParentRecset != null)
							{
								num2 = (short)326369283;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						break;
					}
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			num2 = (short)53346305;
			if (num2 != 0)
			{
			}
			result = null;
			IL_4D:
			num2 = (short)1189281796;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040037C2 RID: 14274
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset innerRecset;
	}
}
