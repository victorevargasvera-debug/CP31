using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000456 RID: 1110
	[global::System.Serializable]
	public class RxSSIClockRateList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009421 RID: 37921 RVA: 0x008B8E7C File Offset: 0x008B707C
		public RxSSIClockRateList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x008B8EBC File Offset: 0x008B70BC
		protected RxSSIClockRateList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x008B8ED4 File Offset: 0x008B70D4
		public override void Init()
		{
			int a_ = 4;
			short num = (short)144048128;
			short num2 = num;
			num = (short)1526388106;
			short num3 = num;
			num = (short)754439562;
			switch (num3 == num)
			{
			}
			num = (short)1936850945;
			if (num != 0)
			{
			}
			num = (short)357171200;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韄뿆飊黌蛎郒맔룖뫘냚﷜跞胠韢胤쟦ꗨ苪黬鯮", a_);
			base.Id = 10791;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x008B8FBC File Offset: 0x008B71BC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1689124864;
			short num2 = num;
			num = (short)1929550803;
			short num3 = num;
			num = (short)1065524179;
			switch (num3 == num)
			{
			}
			num = (short)89260032;
			if (num != 0)
			{
			}
			num = (short)979894273;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臒귔諘裚铜￞ꋠ迢諤蓦苨쯪뿬軮藰雲헴믶郸裺觼", a_);
			base.Id = 10791;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x008B90A0 File Offset: 0x008B72A0
		public override void PopulateReferences()
		{
			short num = (short)1643446272;
			short num2 = num;
			num = (short)182458311;
			short num3 = num;
			num = (short)185931719;
			switch (num3 == num)
			{
			}
			num = (short)1165557761;
			if (num != 0)
			{
			}
			num = (short)2041839616;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x008B9144 File Offset: 0x008B7344
		public override void DropReferences()
		{
			short num = (short)93388800;
			short num2 = num;
			num = (short)339713157;
			short num3 = num;
			num = (short)1382325381;
			switch (num3 == num)
			{
			}
			num = (short)1951137792;
			if (num != 0)
			{
			}
			num = (short)386072577;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x008B91EC File Offset: 0x008B73EC
		public override void SetConstraints()
		{
			short num = (short)111935488;
			short num2 = num;
			num = (short)477167048;
			short num3 = num;
			num = (short)1117781448;
			switch (num3 == num)
			{
			}
			num = (short)1881014272;
			if (num != 0)
			{
			}
			num = (short)572391425;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x008B9294 File Offset: 0x008B7494
		public override void SetupDependencies()
		{
			short num = (short)1087766528;
			short num2 = num;
			num = (short)453625706;
			short num3 = num;
			num = (short)900515690;
			switch (num3 == num)
			{
			}
			num = (short)1266221056;
			if (num != 0)
			{
			}
			num = (short)1174536193;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x06009429 RID: 37929 RVA: 0x008B933C File Offset: 0x008B753C
		public bool HasDiffs
		{
			get
			{
				short num = (short)584908800;
				short num2 = num;
				num = (short)334839822;
				short num3 = num;
				num = (short)856309774;
				switch (num3 == num)
				{
				}
				num = (short)131399681;
				if (num != 0)
				{
				}
				num = (short)881655808;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x008B93F0 File Offset: 0x008B75F0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)2130247680;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)288686082;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1737621507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 2:
					num = (short)1933312001;
					if (num != 0)
					{
					}
					goto IL_D8;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)792985604;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_115;
				}
				goto IL_4C;
				IL_D8:
				num = (short)2107047937;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_115:
				num = (short)1014057334;
				short num4 = num;
				num = (short)71584118;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D8;
				default:
					goto IL_14B;
				}
			}
			IL_14B:
			num = (short)17301504;
			if (num != 0)
			{
			}
			return result;
			IL_4C:
			result = null;
			num = (short)950730752;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x040049E4 RID: 18916
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerRecset innerRecset;
	}
}
