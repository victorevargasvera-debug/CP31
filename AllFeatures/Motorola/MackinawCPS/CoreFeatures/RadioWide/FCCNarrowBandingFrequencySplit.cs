using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200016C RID: 364
	[global::System.Serializable]
	public class FCCNarrowBandingFrequencySplit : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002FC0 RID: 12224 RVA: 0x002ECB68 File Offset: 0x002EAD68
		public FCCNarrowBandingFrequencySplit(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x002ECBA8 File Offset: 0x002EADA8
		protected FCCNarrowBandingFrequencySplit(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x002ECBC0 File Offset: 0x002EADC0
		public override void Init()
		{
			int a_ = 6;
			short num = (short)253165568;
			short num2 = num;
			num = (short)1530996560;
			short num3 = num;
			num = (short)795354960;
			switch (num3 == num)
			{
			}
			num = (short)787546113;
			if (num != 0)
			{
			}
			num = (short)1298071552;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臆諈裊臎냐ꇒ꟔룖께ﯚ鿜뻞迠蟢賤触軨쯪꯬鷮铰苲胴鋶韸飺蓼\udffe刀猂椄渆紈", a_);
			base.Id = 10636;
			base.UIName = global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT;
			base.DataTransferOrder = 16;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x002ECCA4 File Offset: 0x002EAEA4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)459276288;
			short num2 = num;
			num = (short)1349804810;
			short num3 = num;
			num = (short)580739850;
			switch (num3 == num)
			{
			}
			num = (short)1224343553;
			if (num != 0)
			{
			}
			num = (short)1722679296;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迈裊軌鿐닒꟔ꗖ뛘곚﷜鷞胠跢臤軦蟨質췬ꧮ菰雲蓴苶鳸闺黼蛾℀倂甄欆怈缊", a_);
			base.Id = 10636;
			base.UIName = global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT;
			base.DataTransferOrder = 16;
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x002ECD88 File Offset: 0x002EAF88
		public override void PopulateReferences()
		{
			short num = (short)501022720;
			short num2 = num;
			num = (short)526299921;
			short num3 = num;
			num = (short)1401664273;
			switch (num3 == num)
			{
			}
			num = (short)454033409;
			if (num != 0)
			{
			}
			num = (short)657784832;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x002ECE30 File Offset: 0x002EB030
		public override void DropReferences()
		{
			short num = (short)1880031232;
			short num2 = num;
			num = (short)1870495359;
			short num3 = num;
			num = (short)1259110015;
			switch (num3 == num)
			{
			}
			num = (short)468451329;
			if (num != 0)
			{
			}
			num = (short)860160000;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x002ECED8 File Offset: 0x002EB0D8
		public override void SetConstraints()
		{
			short num = (short)2003501056;
			short num2 = num;
			num = (short)1903886337;
			if (num != 0)
			{
			}
			num = (short)2015802732;
			short num3 = num;
			num = (short)1784788332;
			switch (num3 == num)
			{
			}
			num = (short)629932032;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x002ECF80 File Offset: 0x002EB180
		public override void SetupDependencies()
		{
			short num = (short)1925251072;
			short num2 = num;
			num = (short)1017680482;
			short num3 = num;
			num = (short)751932002;
			switch (num3 == num)
			{
			}
			num = (short)1717501953;
			if (num != 0)
			{
			}
			num = (short)1256062976;
			if (num != 0)
			{
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x002ED028 File Offset: 0x002EB228
		public bool HasDiffs
		{
			get
			{
				short num = (short)48234496;
				short num2 = num;
				num = (short)1339555841;
				if (num != 0)
				{
				}
				num = (short)2128542658;
				short num3 = num;
				num = (short)1895824322;
				switch (num3 == num)
				{
				}
				num = (short)1526923264;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x002ED0D8 File Offset: 0x002EB2D8
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
					num2 = (short)1743519745;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)1872691203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_84;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)23937970;
					short num3 = num2;
					num2 = (short)297747378;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						num2 = (short)1509949440;
						if (num2 != 0)
						{
						}
						num2 = (short)844890116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1105461248;
						short num4 = num2;
						num2 = (short)368115713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_84:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)280559618;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1371078656;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001163 RID: 4451
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset innerRecset;
	}
}
