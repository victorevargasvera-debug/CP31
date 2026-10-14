using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F5 RID: 1013
	[global::System.Serializable]
	public class E5GeneralExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008D19 RID: 36121 RVA: 0x00845CDC File Offset: 0x00843EDC
		public E5GeneralExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x00845D1C File Offset: 0x00843F1C
		protected E5GeneralExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008D1B RID: 36123 RVA: 0x00845D34 File Offset: 0x00843F34
		public override void Init()
		{
			int a_ = 1;
			short num = (short)998565228;
			short num2 = num;
			num = (short)418571628;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1984299008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1492189184;
			if (num != 0)
			{
			}
			num = (short)187236353;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藁ꇃꣅ귇룉귋ꋍ", a_);
			base.Id = 10902;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00845E14 File Offset: 0x00844014
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)919048131;
			short num2 = num;
			num = (short)1709608899;
			switch (num2 == num)
			{
			default:
			{
				num = (short)677576704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1818230784;
			if (num != 0)
			{
			}
			num = (short)1595211777;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闑뇓룕뷗꣙뷛닝", a_);
			base.Id = 10902;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00845EF8 File Offset: 0x008440F8
		public override void PopulateReferences()
		{
			short num = (short)1549694584;
			short num2 = num;
			num = (short)1377531512;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1655504896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2061238273;
			if (num != 0)
			{
			}
			num = (short)116719616;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x00845FA4 File Offset: 0x008441A4
		public override void DropReferences()
		{
			short num = (short)1091829761;
			if (num != 0)
			{
			}
			num = (short)347602944;
			short num2 = num;
			num = (short)738421835;
			short num3 = num;
			num = (short)1457351755;
			switch (num3 == num)
			{
			}
			num = (short)2089877504;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x00846050 File Offset: 0x00844250
		public override void SetConstraints()
		{
			short num = (short)864288769;
			if (num != 0)
			{
			}
			num = (short)124583936;
			short num2 = num;
			num = (short)577863841;
			short num3 = num;
			num = (short)1042776225;
			switch (num3 == num)
			{
			}
			num = (short)1208352768;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x008460FC File Offset: 0x008442FC
		public override void SetupDependencies()
		{
			short num = (short)1276968223;
			short num2 = num;
			num = (short)1599143199;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2098135040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)336789505;
			if (num != 0)
			{
			}
			num = (short)581894144;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x008461A8 File Offset: 0x008443A8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1080488094;
				short num2 = num;
				num = (short)601485470;
				switch (num2 == num)
				{
				}
				num = (short)1185153024;
				short num3 = num;
				num = (short)255131649;
				if (num != 0)
				{
				}
				num = (short)1729429504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0400457E RID: 17790
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset innerRecset;
	}
}
