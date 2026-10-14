using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000540 RID: 1344
	[global::System.Serializable]
	public class ASTROGroupID : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B4A9 RID: 46249 RVA: 0x00A76010 File Offset: 0x00A74210
		public ASTROGroupID(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x00A76050 File Offset: 0x00A74250
		protected ASTROGroupID(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x00A76068 File Offset: 0x00A74268
		public override void Init()
		{
			int a_ = 12;
			short num = (short)386158144;
			short num2 = num;
			num = (short)309939776;
			switch (num2 == num)
			{
			}
			num = (short)1825964033;
			if (num != 0)
			{
			}
			num = (short)429522944;
			short num3 = num;
			num = (short)1296564224;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賌鳎藐臒體默꧚닜꫞釠쏢곤ꏦ", a_);
			base.Id = 10053;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROGROUPID;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x00A7614C File Offset: 0x00A7434C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)983765930;
			short num2 = num;
			num = (short)747049898;
			switch (num2 == num)
			{
			}
			num = (short)1386414081;
			if (num != 0)
			{
			}
			num = (short)1904345088;
			short num3 = num;
			num = (short)1534590976;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏑蟓苕諗闙ﳛ駝鋟跡釣雥죧ꏩ꣫", a_);
			base.Id = 10053;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROGROUPID;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x00A76230 File Offset: 0x00A74430
		public override void PopulateReferences()
		{
			short num = (short)250019841;
			if (num != 0)
			{
			}
			num = (short)680407829;
			short num2 = num;
			num = (short)1257255701;
			switch (num2 == num)
			{
			}
			num = (short)2111504384;
			short num3 = num;
			num = (short)624099328;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x00A762DC File Offset: 0x00A744DC
		public override void DropReferences()
		{
			short num = (short)1683489288;
			short num2 = num;
			num = (short)385221128;
			switch (num2 == num)
			{
			}
			num = (short)1613889537;
			if (num != 0)
			{
			}
			num = (short)1600913408;
			short num3 = num;
			num = (short)1934688256;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x00A76388 File Offset: 0x00A74588
		public override void SetConstraints()
		{
			short num = (short)526843905;
			if (num != 0)
			{
			}
			num = (short)132319413;
			short num2 = num;
			num = (short)468322485;
			switch (num2 == num)
			{
			}
			num = (short)1163526144;
			short num3 = num;
			num = (short)1930821632;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x00A76430 File Offset: 0x00A74630
		public override void SetupDependencies()
		{
			short num = (short)1201874144;
			short num2 = num;
			num = (short)1421944032;
			switch (num2 == num)
			{
			}
			num = (short)1018363905;
			if (num != 0)
			{
			}
			num = (short)1747451904;
			short num3 = num;
			num = (short)113442816;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005AA1 RID: 23201
		// (get) Token: 0x0600B4B1 RID: 46257 RVA: 0x00A764E0 File Offset: 0x00A746E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1705590039;
				short num2 = num;
				num = (short)5782807;
				switch (num2 == num)
				{
				}
				num = (short)1734737921;
				if (num != 0)
				{
				}
				num = (short)969211904;
				short num3 = num;
				num = (short)1020264448;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x00A7658C File Offset: 0x00A7478C
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
					num2 = (short)2085486593;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1612644353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					for (;;)
					{
						num2 = (short)1169616002;
						short num3 = num2;
						num2 = (short)771812482;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B8;
						}
					}
					IL_B8:
					num2 = (short)357957632;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1726808066;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1741553668;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1160839168;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)573964288;
			short num4 = num2;
			result = null;
			num2 = (short)1500905475;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040057B4 RID: 22452
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset innerRecset;
	}
}
