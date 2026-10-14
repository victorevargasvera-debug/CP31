using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200045E RID: 1118
	[global::System.Serializable]
	public class RxSynthesizerReferenceDividerList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060094C0 RID: 38080 RVA: 0x008C0068 File Offset: 0x008BE268
		public RxSynthesizerReferenceDividerList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x008C00A8 File Offset: 0x008BE2A8
		protected RxSynthesizerReferenceDividerList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x008C00C0 File Offset: 0x008BE2C0
		public override void Init()
		{
			int a_ = 2;
			short num = (short)471899759;
			short num2 = num;
			num = (short)589733487;
			switch (num2 == num)
			{
			}
			num = (short)1361248256;
			short num3 = num;
			num = (short)678494208;
			if (num != 0)
			{
			}
			num = (short)1426325505;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釂뷄髈닊ꏌ믎말뛒ꛔ뻖ꏘ뻚꿜￞돠蛢菤苦鯨軪菬賮铰폲뇴黶迸鋺駼髾猀⌂䤄渆稈缊", a_);
			base.Id = 10006;
			base.UIName = global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x008C01A8 File Offset: 0x008BE3A8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1850715257;
			short num2 = num;
			num = (short)249408633;
			switch (num2 == num)
			{
			}
			num = (short)515375104;
			short num3 = num;
			num = (short)937820161;
			if (num != 0)
			{
			}
			num = (short)722927616;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳍꣏蟓꿕뛗껙듛믝鏟诡黣菥髧쫩뻫语雯韱蛳鏵雷駹駻\udefd䓿欁爃漅氇漉縋⸍小笑朓戕", a_);
			base.Id = 10006;
			base.UIName = global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x008C028C File Offset: 0x008BE48C
		public override void PopulateReferences()
		{
			short num = (short)803164908;
			short num2 = num;
			num = (short)1243239148;
			switch (num2 == num)
			{
			}
			num = (short)2147090432;
			short num3 = num;
			num = (short)2058027009;
			if (num != 0)
			{
			}
			num = (short)827064320;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x008C0338 File Offset: 0x008BE538
		public override void DropReferences()
		{
			short num = (short)519569409;
			if (num != 0)
			{
			}
			num = (short)2058653685;
			short num2 = num;
			num = (short)1231392757;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1231159296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)596049920;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x008C03E4 File Offset: 0x008BE5E4
		public override void SetConstraints()
		{
			short num = (short)915034106;
			short num2 = num;
			num = (short)1442205690;
			switch (num2 == num)
			{
			}
			num = (short)481165312;
			short num3 = num;
			num = (short)1276903424;
			if (num != 0)
			{
			}
			num = (short)535494657;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x008C0490 File Offset: 0x008BE690
		public override void SetupDependencies()
		{
			short num = (short)1366350735;
			short num2 = num;
			num = (short)1777523599;
			switch (num2 == num)
			{
			}
			num = (short)1221197824;
			short num3 = num;
			num = (short)173801473;
			if (num != 0)
			{
			}
			num = (short)98041856;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x060094C8 RID: 38088 RVA: 0x008C0538 File Offset: 0x008BE738
		public bool HasDiffs
		{
			get
			{
				short num = (short)430705160;
				short num2 = num;
				num = (short)1632373256;
				switch (num2 == num)
				{
				}
				num = (short)1030815744;
				short num3 = num;
				num = (short)1300430848;
				if (num != 0)
				{
				}
				num = (short)538443777;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x008C05E8 File Offset: 0x008BE7E8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)697921193;
				short num2 = num;
				num = (short)1354657449;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1101922304;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
					{
						num = (short)230621184;
						short num4 = num;
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1636958210;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1608777728;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset != null)
						{
							num = (short)743702532;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						goto IL_A8;
					}
					goto IL_70;
				}
				IL_A8:
				num = (short)472449025;
				if (num != 0)
				{
				}
				num = (short)1835270145;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_70:
			result = null;
			num = (short)127270915;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040049F4 RID: 18932
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerRecset innerRecset;
	}
}
