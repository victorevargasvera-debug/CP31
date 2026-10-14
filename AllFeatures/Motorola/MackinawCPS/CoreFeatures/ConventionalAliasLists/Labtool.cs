using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D3 RID: 1491
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CE6E RID: 52846 RVA: 0x00C02108 File Offset: 0x00C00308
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x00C02124 File Offset: 0x00C00324
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CE70 RID: 52848 RVA: 0x00C0213C File Offset: 0x00C0033C
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1629683712;
			short num2 = num;
			num = (short)1150263339;
			short num3 = num;
			num = (short)1707515947;
			switch (num3 == num)
			{
			}
			num = (short)932577281;
			if (num != 0)
			{
			}
			num = (short)2009006080;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軁ꗃ꓅볇ꗉꏋꋍ", a_);
			base.Id = 10016;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600CE71 RID: 52849 RVA: 0x00C02224 File Offset: 0x00C00424
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1784086528;
			short num2 = num;
			num = (short)583270401;
			if (num != 0)
			{
			}
			num = (short)1595423348;
			short num3 = num;
			num = (short)362232436;
			switch (num3 == num)
			{
			}
			num = (short)1511784448;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳏돑뛓ꋕ럗뗙냛", a_);
			base.Id = 10016;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600CE72 RID: 52850 RVA: 0x00C02308 File Offset: 0x00C00508
		public override void PopulateReferences()
		{
			short num = (short)1389821952;
			short num2 = num;
			num = (short)1740646497;
			short num3 = num;
			num = (short)722348129;
			switch (num3 == num)
			{
			}
			num = (short)240386048;
			if (num != 0)
			{
			}
			num = (short)430505985;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE73 RID: 52851 RVA: 0x00C023B4 File Offset: 0x00C005B4
		public override void DropReferences()
		{
			short num = (short)1171062784;
			short num2 = num;
			num = (short)138059169;
			short num3 = num;
			num = (short)559390113;
			switch (num3 == num)
			{
			}
			num = (short)584318976;
			if (num != 0)
			{
			}
			num = (short)1767899137;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE74 RID: 52852 RVA: 0x00C02460 File Offset: 0x00C00660
		public override void SetConstraints()
		{
			short num = (short)1742995456;
			short num2 = num;
			num = (short)1593555643;
			short num3 = num;
			num = (short)95271611;
			switch (num3 == num)
			{
			}
			num = (short)1933312001;
			if (num != 0)
			{
			}
			num = (short)92143616;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x00C02508 File Offset: 0x00C00708
		public override void SetupDependencies()
		{
			short num = (short)665649152;
			short num2 = num;
			num = (short)581318191;
			short num3 = num;
			num = (short)1914451503;
			switch (num3 == num)
			{
			}
			num = (short)442236929;
			if (num != 0)
			{
			}
			num = (short)768212992;
			if (num != 0)
			{
			}
		}

		// Token: 0x170067DA RID: 26586
		// (get) Token: 0x0600CE76 RID: 52854 RVA: 0x00C025B4 File Offset: 0x00C007B4
		public bool HasDiffs
		{
			get
			{
				short num = (short)293666816;
				short num2 = num;
				num = (short)1200849981;
				short num3 = num;
				num = (short)140084285;
				switch (num3 == num)
				{
				}
				num = (short)245235713;
				if (num != 0)
				{
				}
				num = (short)1281425408;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x00C02664 File Offset: 0x00C00864
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1649934337;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)216858626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					goto IL_FE;
				case 2:
					num = (short)254738435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_117;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)2106851329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4C;
			}
			IL_FE:
			return result;
			IL_4C:
			num = (short)1590182367;
			short num3 = num;
			num = (short)1695367647;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_117:
				num = (short)1563033600;
				short num4 = num;
				if (base.ParentRecset.ContainerDoc != null)
				{
					num = (short)924188676;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num = (short)1739718656;
				if (num != 0)
				{
				}
				result = null;
				num = (short)516751360;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
			return result;
		}
	}
}
