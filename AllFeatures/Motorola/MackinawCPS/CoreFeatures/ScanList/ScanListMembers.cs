using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200011F RID: 287
	[global::System.Serializable]
	public class ScanListMembers : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002A70 RID: 10864 RVA: 0x00295DE0 File Offset: 0x00293FE0
		public ScanListMembers(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00295E20 File Offset: 0x00294020
		protected ScanListMembers(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00295E38 File Offset: 0x00294038
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1165976904;
			short num2 = num;
			num = (short)407135560;
			switch (num2 == num)
			{
			}
			num = (short)295501824;
			if (num != 0)
			{
			}
			num = (short)428670976;
			short num3 = num;
			num = (short)132513793;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ鳏믑ꟓꋕ韙맛돝苟蟡難闥", a_);
			base.Id = 10132;
			base.UIName = global::CommonResources.AcgResources.ID_SCANLISTMEMBERS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00295F1C File Offset: 0x0029411C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1519386625;
			if (num != 0)
			{
			}
			num = (short)669291796;
			short num2 = num;
			num = (short)1440978196;
			switch (num2 == num)
			{
			}
			num = (short)1018232832;
			short num3 = num;
			num = (short)951058432;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷍돏돑뫓铗동꿛ꫝ샟꿡臣该諧迩黫鷭", a_);
			base.Id = 10132;
			base.UIName = global::CommonResources.AcgResources.ID_SCANLISTMEMBERS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00296000 File Offset: 0x00294200
		public override void PopulateReferences()
		{
			short num = (short)1576070587;
			short num2 = num;
			num = (short)1706814907;
			switch (num2 == num)
			{
			}
			num = (short)2147155968;
			if (num != 0)
			{
			}
			num = (short)1725628416;
			short num3 = num;
			num = (short)136314881;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x002960A8 File Offset: 0x002942A8
		public override void DropReferences()
		{
			short num = (short)73776843;
			short num2 = num;
			num = (short)410828491;
			switch (num2 == num)
			{
			}
			num = (short)848101377;
			if (num != 0)
			{
			}
			num = (short)400097280;
			short num3 = num;
			num = (short)619970560;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00296150 File Offset: 0x00294350
		public override void SetConstraints()
		{
			short num = (short)450717712;
			short num2 = num;
			num = (short)1479043088;
			switch (num2 == num)
			{
			}
			num = (short)1706295297;
			if (num != 0)
			{
			}
			num = (short)288555008;
			short num3 = num;
			num = (short)1287520256;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x002961FC File Offset: 0x002943FC
		public override void SetupDependencies()
		{
			short num = (short)1380459222;
			short num2 = num;
			num = (short)1777607382;
			switch (num2 == num)
			{
			}
			num = (short)1625620480;
			if (num != 0)
			{
			}
			num = (short)157548544;
			short num3 = num;
			num = (short)647561217;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x002962A8 File Offset: 0x002944A8
		public bool HasDiffs
		{
			get
			{
				short num = (short)403518457;
				short num2 = num;
				num = (short)1429812217;
				switch (num2 == num)
				{
				}
				num = (short)1087307777;
				if (num != 0)
				{
				}
				num = (short)109182976;
				short num3 = num;
				num = (short)2065367040;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00296358 File Offset: 0x00294558
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
					num2 = (short)221222497;
					short num3 = num2;
					num2 = (short)1956812385;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)961544192;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1065287683;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)65470466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)954204160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1559756801;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)22609924;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)766115840;
			short num4 = num2;
			result = null;
			num2 = (short)1921908737;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000FC6 RID: 4038
		private global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset innerRecset;
	}
}
