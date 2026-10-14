using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000401 RID: 1025
	[global::System.Serializable]
	public class DataButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008DE6 RID: 36326 RVA: 0x0085F68C File Offset: 0x0085D88C
		public DataButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x0085F6CC File Offset: 0x0085D8CC
		protected DataButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x0085F6E4 File Offset: 0x0085D8E4
		public override void Init()
		{
			int a_ = 4;
			short num = (short)847708161;
			if (num != 0)
			{
			}
			num = (short)218803141;
			short num2 = num;
			num = (short)1075489733;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1012334592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1728905216;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊", a_);
			base.Id = 10089;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x0085F7C8 File Offset: 0x0085D9C8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)555548673;
			if (num != 0)
			{
			}
			num = (short)1778316438;
			short num2 = num;
			num = (short)368768150;
			switch (num2 == num)
			{
			default:
			{
				num = (short)882049024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1987641344;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跈꫊만껎", a_);
			base.Id = 10089;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x0085F8AC File Offset: 0x0085DAAC
		public override void PopulateReferences()
		{
			short num = (short)1657085427;
			short num2 = num;
			num = (short)656088563;
			switch (num2 == num)
			{
			}
			num = (short)1688993792;
			short num3 = num;
			num = (short)1255866369;
			if (num != 0)
			{
			}
			num = (short)1120468992;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x0085F958 File Offset: 0x0085DB58
		public override void DropReferences()
		{
			short num = (short)707161179;
			short num2 = num;
			num = (short)786656347;
			switch (num2 == num)
			{
			}
			num = (short)257228800;
			short num3 = num;
			num = (short)2050621441;
			if (num != 0)
			{
			}
			num = (short)578617344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x0085FA00 File Offset: 0x0085DC00
		public override void SetConstraints()
		{
			short num = (short)1174604201;
			short num2 = num;
			num = (short)1380780457;
			switch (num2 == num)
			{
			}
			num = (short)58392576;
			short num3 = num;
			num = (short)1879244801;
			if (num != 0)
			{
			}
			num = (short)1849819136;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x0085FAA8 File Offset: 0x0085DCA8
		public override void SetupDependencies()
		{
			short num = (short)1753953475;
			short num2 = num;
			num = (short)1872835779;
			switch (num2 == num)
			{
			}
			num = (short)2065170432;
			short num3 = num;
			num = (short)1246167041;
			if (num != 0)
			{
			}
			num = (short)997916672;
			if (num != 0)
			{
			}
		}

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x0085FB54 File Offset: 0x0085DD54
		public bool HasDiffs
		{
			get
			{
				short num = (short)1756269604;
				short num2 = num;
				num = (short)462851108;
				switch (num2 == num)
				{
				}
				num = (short)2116616192;
				short num3 = num;
				num = (short)1816002560;
				if (num != 0)
				{
				}
				num = (short)816513025;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x0085FC04 File Offset: 0x0085DE04
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
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)915275776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_D2;
				case 3:
					num2 = (short)1931280385;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)2139029506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1574043649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)305114086;
			short num3 = num2;
			num2 = (short)2001513446;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D2:
				num2 = (short)1157627904;
				short num4 = num2;
				num2 = (short)1968373764;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1280442368;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)477822979;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04004638 RID: 17976
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset innerRecset;
	}
}
