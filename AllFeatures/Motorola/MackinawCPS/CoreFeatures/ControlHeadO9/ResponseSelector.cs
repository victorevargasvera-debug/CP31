using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000382 RID: 898
	[global::System.Serializable]
	public class ResponseSelector : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008460 RID: 33888 RVA: 0x007AEF60 File Offset: 0x007AD160
		public ResponseSelector(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x007AEFA0 File Offset: 0x007AD1A0
		protected ResponseSelector(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x007AEFB8 File Offset: 0x007AD1B8
		public override void Init()
		{
			int a_ = 11;
			short num = (short)409141249;
			if (num != 0)
			{
			}
			num = (short)1590860922;
			short num2 = num;
			num = (short)1004182650;
			switch (num2 == num)
			{
			}
			num = (short)789184512;
			if (num != 0)
			{
			}
			num = (short)1674969088;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黋ꯍꏏꋑ믓룕ꯗ뿙ﳛ距藟軡臣藥鳧藩黫", a_);
			base.Id = 10624;
			base.UIName = global::CommonResources.AcgResources.ID_RESPONSESELECTOR;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x007AF098 File Offset: 0x007AD298
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)172228609;
			if (num != 0)
			{
			}
			num = (short)296214117;
			short num2 = num;
			num = (short)2024726117;
			switch (num2 == num)
			{
			}
			num = (short)1730150400;
			if (num != 0)
			{
			}
			num = (short)1590558720;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飉꧋뷍ꃏ뷑뫓ꗕ뷗龎进믝賟蟡蟣鋥蟧飩", a_);
			base.Id = 10624;
			base.UIName = global::CommonResources.AcgResources.ID_RESPONSESELECTOR;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06008464 RID: 33892 RVA: 0x007AF17C File Offset: 0x007AD37C
		public override void PopulateReferences()
		{
			short num = (short)271104297;
			short num2 = num;
			num = (short)1653455145;
			switch (num2 == num)
			{
			}
			num = (short)1970274305;
			if (num != 0)
			{
			}
			num = (short)400490496;
			if (num != 0)
			{
			}
			num = (short)1722482688;
			short num3 = num;
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x007AF228 File Offset: 0x007AD428
		public override void DropReferences()
		{
			short num = (short)712746923;
			short num2 = num;
			num = (short)1134995371;
			switch (num2 == num)
			{
			}
			num = (short)666632193;
			if (num != 0)
			{
			}
			num = (short)707919872;
			if (num != 0)
			{
			}
			num = (short)1662648320;
			short num3 = num;
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x007AF2D0 File Offset: 0x007AD4D0
		public override void SetConstraints()
		{
			short num = (short)780309355;
			short num2 = num;
			num = (short)1652593515;
			switch (num2 == num)
			{
			}
			num = (short)1028456448;
			if (num != 0)
			{
			}
			num = (short)1471021057;
			if (num != 0)
			{
			}
			num = (short)350552064;
			short num3 = num;
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x007AF37C File Offset: 0x007AD57C
		public override void SetupDependencies()
		{
			short num = (short)109806184;
			short num2 = num;
			num = (short)1111327336;
			switch (num2 == num)
			{
			}
			num = (short)2108620801;
			if (num != 0)
			{
			}
			num = (short)1617625088;
			if (num != 0)
			{
			}
			num = (short)1893138432;
			short num3 = num;
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x06008468 RID: 33896 RVA: 0x007AF424 File Offset: 0x007AD624
		public bool HasDiffs
		{
			get
			{
				short num = (short)1651239138;
				short num2 = num;
				num = (short)1196681442;
				switch (num2 == num)
				{
				}
				num = (short)1649541121;
				if (num != 0)
				{
				}
				num = (short)861536256;
				if (num != 0)
				{
				}
				num = (short)1869676544;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x007AF4D4 File Offset: 0x007AD6D4
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
				{
					num2 = (short)353304576;
					short num3 = num2;
					num2 = (short)879887613;
					short num4 = num2;
					num2 = (short)2064057597;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						num2 = (short)1210056705;
						if (num2 != 0)
						{
						}
						num2 = (short)48365568;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1707540483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_3A;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)319291392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)1449459714;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)194445316;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1237057537;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003E72 RID: 15986
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset innerRecset;
	}
}
