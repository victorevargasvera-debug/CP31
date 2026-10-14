using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B4 RID: 948
	[global::System.Serializable]
	public class O5NavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008925 RID: 35109 RVA: 0x007FB434 File Offset: 0x007F9634
		public O5NavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x007FB474 File Offset: 0x007F9674
		protected O5NavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x007FB48C File Offset: 0x007F968C
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1353843754;
			short num2 = num;
			num = (short)1291977770;
			switch (num2 == num)
			{
			}
			num = (short)841678848;
			if (num != 0)
			{
			}
			num = (short)348913664;
			short num3 = num;
			num = (short)137363457;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跂꓄뇆ꃈ곊곌믎룐볒믔高듚돜ꯞ鏠賢觤铦", a_);
			base.Id = 10735;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x007FB574 File Offset: 0x007F9774
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)507064614;
			short num2 = num;
			num = (short)326054182;
			switch (num2 == num)
			{
			}
			num = (short)2038628353;
			if (num != 0)
			{
			}
			num = (short)319160320;
			short num3 = num;
			num = (short)159842304;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳑뗓ꃕ뇗뷙뷛ꫝ觟跡諣웥ꯧ藩苫髭苯鷱飳藵", a_);
			base.Id = 10735;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x007FB654 File Offset: 0x007F9854
		public override void PopulateReferences()
		{
			short num = (short)1629220847;
			short num2 = num;
			num = (short)658042863;
			switch (num2 == num)
			{
			}
			num = (short)1462829057;
			if (num != 0)
			{
			}
			num = (short)439746560;
			short num3 = num;
			num = (short)1716191232;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x007FB6FC File Offset: 0x007F98FC
		public override void DropReferences()
		{
			short num = (short)687705016;
			short num2 = num;
			num = (short)1296731064;
			switch (num2 == num)
			{
			}
			num = (short)1476788225;
			if (num != 0)
			{
			}
			num = (short)1994063872;
			short num3 = num;
			num = (short)936247296;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x007FB7A8 File Offset: 0x007F99A8
		public override void SetConstraints()
		{
			short num = (short)1964366228;
			short num2 = num;
			num = (short)726522260;
			switch (num2 == num)
			{
			}
			num = (short)2122383361;
			if (num != 0)
			{
			}
			num = (short)1602813952;
			short num3 = num;
			num = (short)1796145152;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x007FB854 File Offset: 0x007F9A54
		public override void SetupDependencies()
		{
			short num = (short)283836417;
			if (num != 0)
			{
			}
			num = (short)1149568349;
			short num2 = num;
			num = (short)223479133;
			switch (num2 == num)
			{
			}
			num = (short)1103495168;
			short num3 = num;
			num = (short)1291321344;
			if (num != 0)
			{
			}
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x0600892D RID: 35117 RVA: 0x007FB900 File Offset: 0x007F9B00
		public bool HasDiffs
		{
			get
			{
				short num = (short)2041053185;
				if (num != 0)
				{
				}
				num = (short)1454913292;
				short num2 = num;
				num = (short)586364684;
				switch (num2 == num)
				{
				}
				num = (short)933756928;
				short num3 = num;
				num = (short)1344077824;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x007FB9AC File Offset: 0x007F9BAC
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
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1504903170;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F0;
					case 1:
						if (base.ParentRecset != null)
						{
							num2 = (short)703594499;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F0;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)151453700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1224343552;
						short num3 = num2;
						num2 = (short)1966211072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						goto IL_AF;
					}
					goto IL_24;
				}
				IL_AF:
				IL_F0:
				num2 = (short)2091856234;
				short num4 = num2;
				num2 = (short)1308569962;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_26;
				default:
					num2 = (short)2040922112;
					if (num2 != 0)
					{
					}
					num2 = (short)2114256897;
					if (num2 != 0)
					{
					}
					return result;
				}
				break;
			}
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)434372609;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040040E7 RID: 16615
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset innerRecset;
	}
}
