using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001DA RID: 474
	[global::System.Serializable]
	public class GlobalShepherd : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060053AF RID: 21423 RVA: 0x004BF9F4 File Offset: 0x004BDBF4
		public GlobalShepherd(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x004BFA34 File Offset: 0x004BDC34
		protected GlobalShepherd(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x004BFA4C File Offset: 0x004BDC4C
		public override void Init()
		{
			int a_ = 3;
			short num = (short)553975808;
			short num2 = num;
			num = (short)1977473638;
			short num3 = num;
			num = (short)1349573222;
			switch (num3 == num)
			{
			}
			num = (short)1469579265;
			if (num != 0)
			{
			}
			num = (short)570425344;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菃꫅Ꟈ꣉귋ꋍ臑볓돕꣗닙맛곝蓟", a_);
			base.Id = 10033;
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALSHEPHERD;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x004BFB30 File Offset: 0x004BDD30
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)322371584;
			short num2 = num;
			num = (short)1578099599;
			short num3 = num;
			num = (short)298312591;
			switch (num3 == num)
			{
			}
			num = (short)1299447808;
			if (num != 0)
			{
			}
			num = (short)1679491073;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓂꧄꣆ꯈ꫊ꇌ苐믒냔Ꟗ뇘뻚꿜믞", a_);
			base.Id = 10033;
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALSHEPHERD;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x004BFC18 File Offset: 0x004BDE18
		public override void PopulateReferences()
		{
			short num = (short)75825152;
			short num2 = num;
			num = (short)1718035059;
			short num3 = num;
			num = (short)1082860147;
			switch (num3 == num)
			{
			}
			num = (short)1352466433;
			if (num != 0)
			{
			}
			num = (short)1275854848;
			if (num != 0)
			{
			}
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x004BFCC4 File Offset: 0x004BDEC4
		public override void DropReferences()
		{
			short num = (short)789184512;
			short num2 = num;
			num = (short)1693646849;
			if (num != 0)
			{
			}
			num = (short)508588205;
			short num3 = num;
			num = (short)736850093;
			switch (num3 == num)
			{
			}
			num = (short)515637248;
			if (num != 0)
			{
			}
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x004BFD6C File Offset: 0x004BDF6C
		public override void SetConstraints()
		{
			short num = (short)2134376448;
			short num2 = num;
			num = (short)2030628183;
			short num3 = num;
			num = (short)1447619927;
			switch (num3 == num)
			{
			}
			num = (short)1895038976;
			if (num != 0)
			{
			}
			num = (short)1631584257;
			if (num != 0)
			{
			}
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x004BFE14 File Offset: 0x004BE014
		public override void SetupDependencies()
		{
			short num = (short)1020592128;
			short num2 = num;
			num = (short)545175608;
			short num3 = num;
			num = (short)525383736;
			switch (num3 == num)
			{
			}
			num = (short)1917911041;
			if (num != 0)
			{
			}
			num = (short)1198915584;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x004BFEC0 File Offset: 0x004BE0C0
		public bool HasDiffs
		{
			get
			{
				short num = (short)491388928;
				short num2 = num;
				num = (short)842085939;
				short num3 = num;
				num = (short)53753395;
				switch (num3 == num)
				{
				}
				num = (short)396296193;
				if (num != 0)
				{
				}
				num = (short)1181810688;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x004BFF74 File Offset: 0x004BE174
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
					num2 = (short)1439411553;
					short num3 = num2;
					num2 = (short)1968287073;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D0;
					default:
					{
						num2 = (short)1254883328;
						short num4 = num2;
						num2 = (short)905969664;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)224985089;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					goto IL_D0;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1634664451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1300824068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
				IL_D0:
				num2 = (short)665059329;
				if (num2 != 0)
				{
				}
				num2 = (short)447873026;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1602420736;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040020A1 RID: 8353
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset innerRecset;
	}
}
