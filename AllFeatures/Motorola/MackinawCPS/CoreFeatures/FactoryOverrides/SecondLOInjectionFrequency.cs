using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000462 RID: 1122
	[global::System.Serializable]
	public class SecondLOInjectionFrequency : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009510 RID: 38160 RVA: 0x008C39B0 File Offset: 0x008C1BB0
		public SecondLOInjectionFrequency(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x008C39F0 File Offset: 0x008C1BF0
		protected SecondLOInjectionFrequency(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x008C3A08 File Offset: 0x008C1C08
		public override void Init()
		{
			int a_ = 8;
			short num = (short)403470392;
			short num2 = num;
			num = (short)1183217720;
			switch (num2 == num)
			{
			}
			num = (short)1313800192;
			if (num != 0)
			{
			}
			num = (short)1387659264;
			short num3 = num;
			num = (short)1868365825;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髈껊껌ꃎ뿐럒鯖雘ﯚ铜뇞诠蛢蛤鏦胨蓪菬쿮런臲郴蛶賸黺鏼鳾砀", a_);
			base.Id = 10010;
			base.UIName = global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCY;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x008C3AEC File Offset: 0x008C1CEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1907407638;
			short num2 = num;
			num = (short)104839958;
			switch (num2 == num)
			{
			}
			num = (short)1550450689;
			if (num != 0)
			{
			}
			num = (short)251265024;
			short num3 = num;
			num = (short)1856110592;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雄ꋆ꫈꓊ꏌꯎ鿒體郘뗚럜뫞苠韢賤裦蟨쯪꯬鷮铰苲胴鋶韸飺蓼", a_);
			base.Id = 10010;
			base.UIName = global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCY;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x008C3BD0 File Offset: 0x008C1DD0
		public override void PopulateReferences()
		{
			short num = (short)253299792;
			short num2 = num;
			num = (short)1009912912;
			switch (num2 == num)
			{
			}
			num = (short)1171521536;
			if (num != 0)
			{
			}
			num = (short)1321992192;
			short num3 = num;
			num = (short)1642856449;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x008C3C80 File Offset: 0x008C1E80
		public override void DropReferences()
		{
			short num = (short)509494908;
			short num2 = num;
			num = (short)1928939132;
			switch (num2 == num)
			{
			}
			num = (short)962920449;
			if (num != 0)
			{
			}
			num = (short)1574764544;
			if (num != 0)
			{
			}
			num = (short)1151401984;
			short num3 = num;
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x008C3D2C File Offset: 0x008C1F2C
		public override void SetConstraints()
		{
			short num = (short)1557142944;
			short num2 = num;
			num = (short)2090671520;
			switch (num2 == num)
			{
			}
			num = (short)1704263681;
			if (num != 0)
			{
			}
			num = (short)271712256;
			if (num != 0)
			{
			}
			num = (short)1992032256;
			short num3 = num;
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x008C3DD4 File Offset: 0x008C1FD4
		public override void SetupDependencies()
		{
			short num = (short)564362522;
			short num2 = num;
			num = (short)1049394458;
			switch (num2 == num)
			{
			}
			num = (short)1216479232;
			if (num != 0)
			{
			}
			num = (short)819396609;
			if (num != 0)
			{
			}
			num = (short)2132738048;
			short num3 = num;
		}

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x06009518 RID: 38168 RVA: 0x008C3E7C File Offset: 0x008C207C
		public bool HasDiffs
		{
			get
			{
				short num = (short)549191681;
				if (num != 0)
				{
				}
				num = (short)811660853;
				short num2 = num;
				num = (short)2146891317;
				switch (num2 == num)
				{
				}
				num = (short)1832321024;
				if (num != 0)
				{
				}
				num = (short)486604800;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x008C3F2C File Offset: 0x008C212C
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
					num2 = (short)1868824577;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)559153156;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_5C;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1406730240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1925971969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)350692323;
					short num3 = num2;
					num2 = (short)854467555;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5C;
					case 1:
						goto IL_112;
					}
					goto Block_2;
				}
				}
				goto IL_24;
				IL_5C:
				num2 = (short)1604452354;
				num = (int)((global::System.IntPtr)num2);
			}
			Block_2:
			num2 = (short)741081088;
			short num4 = num2;
			IL_112:
			num2 = (short)1483931648;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)182386691;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040049FC RID: 18940
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerRecset innerRecset;
	}
}
