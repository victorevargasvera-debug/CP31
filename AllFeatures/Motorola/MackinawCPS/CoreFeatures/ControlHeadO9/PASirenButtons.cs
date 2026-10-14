using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200037A RID: 890
	[global::System.Serializable]
	public class PASirenButtons : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060083B6 RID: 33718 RVA: 0x007A743C File Offset: 0x007A563C
		public PASirenButtons(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x007A747C File Offset: 0x007A567C
		protected PASirenButtons(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x007A7494 File Offset: 0x007A5694
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1526792192;
			short num2 = num;
			num = (short)1333395457;
			if (num != 0)
			{
			}
			num = (short)1279451843;
			short num3 = num;
			num = (short)1639834307;
			switch (num3 == num)
			{
			}
			num = (short)765853696;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铃蟅鷍맏ꃑ뇓룕飙꧛ꫝ铟跡諣闥", a_);
			base.Id = 10743;
			base.UIName = global::CommonResources.AcgResources.ID_PASIRENBUTTONS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x007A7578 File Offset: 0x007A5778
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1419706368;
			short num2 = num;
			num = (short)1411561999;
			short num3 = num;
			num = (short)1698150927;
			switch (num3 == num)
			{
			}
			num = (short)1582759937;
			if (num != 0)
			{
			}
			num = (short)910426112;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闄蛆鳎룐ꇒ냔맖律駚꣜ꯞ闠賢诤铦", a_);
			base.Id = 10743;
			base.UIName = global::CommonResources.AcgResources.ID_PASIRENBUTTONS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x007A765C File Offset: 0x007A585C
		public override void PopulateReferences()
		{
			short num = (short)1152319488;
			short num2 = num;
			num = (short)1588371939;
			short num3 = num;
			num = (short)1350410723;
			switch (num3 == num)
			{
			}
			num = (short)1284964352;
			if (num != 0)
			{
			}
			num = (short)319619073;
			if (num != 0)
			{
			}
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x007A7704 File Offset: 0x007A5904
		public override void DropReferences()
		{
			short num = (short)453050368;
			short num2 = num;
			num = (short)258169146;
			short num3 = num;
			num = (short)1189959994;
			switch (num3 == num)
			{
			}
			num = (short)315359233;
			if (num != 0)
			{
			}
			num = (short)221773824;
			if (num != 0)
			{
			}
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x007A77B0 File Offset: 0x007A59B0
		public override void SetConstraints()
		{
			short num = (short)275578880;
			short num2 = num;
			num = (short)56098817;
			if (num != 0)
			{
			}
			num = (short)1616736116;
			short num3 = num;
			num = (short)965635956;
			switch (num3 == num)
			{
			}
			num = (short)661323776;
			if (num != 0)
			{
			}
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x007A7858 File Offset: 0x007A5A58
		public override void SetupDependencies()
		{
			short num = (short)2004746240;
			short num2 = num;
			num = (short)528557022;
			short num3 = num;
			num = (short)1966679006;
			switch (num3 == num)
			{
			}
			num = (short)218824705;
			if (num != 0)
			{
			}
			num = (short)871497728;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x007A7904 File Offset: 0x007A5B04
		public bool HasDiffs
		{
			get
			{
				short num = (short)1822818304;
				short num2 = num;
				num = (short)69471251;
				short num3 = num;
				num = (short)1569917971;
				switch (num3 == num)
				{
				}
				num = (short)1842610177;
				if (num != 0)
				{
				}
				num = (short)490536960;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x007A79B8 File Offset: 0x007A5BB8
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
					if (base.ParentRecset == null)
					{
						goto IL_139;
					}
					num2 = (short)804164513;
					short num3 = num2;
					num2 = (short)705336225;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_139;
					default:
						num2 = (short)1159725056;
						if (num2 != 0)
						{
						}
						num2 = (short)789446657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1447952388;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_F9;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)818151426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1219624963;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				}
				goto IL_24;
			}
			IL_F9:
			IL_139:
			num2 = (short)1358168064;
			short num4 = num2;
			return result;
			IL_24:
			num2 = (short)1581252609;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1407320064;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003E61 RID: 15969
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset innerRecset;
	}
}
