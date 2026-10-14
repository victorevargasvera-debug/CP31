using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200033D RID: 829
	[global::System.Serializable]
	public class DirectStatus : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007FB4 RID: 32692 RVA: 0x00757A50 File Offset: 0x00755C50
		public DirectStatus(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007FB5 RID: 32693 RVA: 0x00757A90 File Offset: 0x00755C90
		protected DirectStatus(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x00757AA8 File Offset: 0x00755CA8
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1667841563;
			short num2 = num;
			num = (short)1011367451;
			switch (num2 == num)
			{
			}
			num = (short)922746881;
			if (num != 0)
			{
			}
			num = (short)1638006784;
			if (num != 0)
			{
			}
			num = (short)1127809024;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍맏ꃑ뇓뗕곗龎进ꫝ臟雡釣闥", a_);
			base.Id = 10219;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTSTATUS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x00757B8C File Offset: 0x00755D8C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)35287359;
			short num2 = num;
			num = (short)726954303;
			switch (num2 == num)
			{
			}
			num = (short)1752498177;
			if (num != 0)
			{
			}
			num = (short)1298661376;
			if (num != 0)
			{
			}
			num = (short)1784676352;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苅ꇇ룉꧋귍꓏蟓ꋕ맗껙꧛귝", a_);
			base.Id = 10219;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTSTATUS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x00757C70 File Offset: 0x00755E70
		public override void PopulateReferences()
		{
			short num = (short)350551308;
			short num2 = num;
			num = (short)1596521740;
			switch (num2 == num)
			{
			}
			num = (short)1727070209;
			if (num != 0)
			{
			}
			num = (short)1667170304;
			if (num != 0)
			{
			}
			num = (short)217448448;
			short num3 = num;
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x00757D18 File Offset: 0x00755F18
		public override void DropReferences()
		{
			short num = (short)927861426;
			short num2 = num;
			num = (short)1584073394;
			switch (num2 == num)
			{
			}
			num = (short)982908928;
			if (num != 0)
			{
			}
			num = (short)99090433;
			if (num != 0)
			{
			}
			num = (short)1179648;
			short num3 = num;
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x00757DC4 File Offset: 0x00755FC4
		public override void SetConstraints()
		{
			short num = (short)101416202;
			short num2 = num;
			num = (short)1339260170;
			switch (num2 == num)
			{
			}
			num = (short)1002831873;
			if (num != 0)
			{
			}
			num = (short)1219231744;
			if (num != 0)
			{
			}
			num = (short)135462912;
			short num3 = num;
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x00757E6C File Offset: 0x0075606C
		public override void SetupDependencies()
		{
			short num = (short)2143340843;
			short num2 = num;
			num = (short)334547243;
			switch (num2 == num)
			{
			}
			num = (short)315752449;
			if (num != 0)
			{
			}
			num = (short)859111424;
			if (num != 0)
			{
			}
			num = (short)1256783872;
			short num3 = num;
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x06007FBC RID: 32700 RVA: 0x00757F18 File Offset: 0x00756118
		public bool HasDiffs
		{
			get
			{
				short num = (short)646260136;
				short num2 = num;
				num = (short)538322344;
				switch (num2 == num)
				{
				}
				num = (short)1920598016;
				if (num != 0)
				{
				}
				num = (short)2056978433;
				if (num != 0)
				{
				}
				num = (short)1104084992;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x00757FC8 File Offset: 0x007561C8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)405864451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)2001731586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)1931608068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_102;
				case 4:
					goto IL_11B;
				}
				goto IL_24;
			}
			IL_102:
			return result;
			IL_24:
			result = null;
			num2 = (short)507416338;
			short num3 = num2;
			num2 = (short)2036240146;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11B:
				if (base.ParentRecset.ContainerDoc != null)
				{
					num2 = (short)1359478785;
					if (num2 != 0)
					{
					}
					num2 = (short)1636302848;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return result;
			case 1:
				break;
			default:
			{
				num2 = (short)832241664;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)403898368;
			if (num2 != 0)
			{
			}
			num2 = (short)928645121;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039B1 RID: 14769
		private global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset innerRecset;
	}
}
