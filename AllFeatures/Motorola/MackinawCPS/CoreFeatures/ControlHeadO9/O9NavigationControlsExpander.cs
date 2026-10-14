using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000376 RID: 886
	[global::System.Serializable]
	public class O9NavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600836C RID: 33644 RVA: 0x007A3F4C File Offset: 0x007A214C
		public O9NavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x007A3F8C File Offset: 0x007A218C
		protected O9NavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x007A3FA4 File Offset: 0x007A21A4
		public override void Init()
		{
			int a_ = 2;
			short num = (short)111280128;
			short num2 = num;
			num = (short)917813093;
			short num3 = num;
			num = (short)1851242341;
			switch (num3 == num)
			{
			}
			num = (short)2128674817;
			if (num != 0)
			{
			}
			num = (short)708444160;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跂꓄뇆ꃈ곊곌믎룐볒믔高듚돜ꯞ鏠賢觤铦", a_);
			base.Id = 10731;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 11;
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x007A4084 File Offset: 0x007A2284
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1552809984;
			short num2 = num;
			num = (short)1565965423;
			short num3 = num;
			num = (short)1939782767;
			switch (num3 == num)
			{
			}
			num = (short)718995457;
			if (num != 0)
			{
			}
			num = (short)538378240;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛇ꯉ뫋ꟍ럏돑ꃓ뿕럗듙ﳛ鷝迟賡郣铥蟧蛩鿫", a_);
			base.Id = 10731;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x007A4168 File Offset: 0x007A2368
		public override void PopulateReferences()
		{
			short num = (short)659292160;
			short num2 = num;
			num = (short)46562013;
			short num3 = num;
			num = (short)413039325;
			switch (num3 == num)
			{
			}
			num = (short)124911616;
			if (num != 0)
			{
			}
			num = (short)848494593;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x007A4210 File Offset: 0x007A2410
		public override void DropReferences()
		{
			short num = (short)1009123328;
			short num2 = num;
			num = (short)267589868;
			short num3 = num;
			num = (short)919410924;
			switch (num3 == num)
			{
			}
			num = (short)700252161;
			if (num != 0)
			{
			}
			num = (short)403832832;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x007A42B8 File Offset: 0x007A24B8
		public override void SetConstraints()
		{
			short num = (short)1672478720;
			short num2 = num;
			num = (short)1750114133;
			short num3 = num;
			num = (short)370843477;
			switch (num3 == num)
			{
			}
			num = (short)421265408;
			if (num != 0)
			{
			}
			num = (short)2059468801;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x007A4364 File Offset: 0x007A2564
		public override void SetupDependencies()
		{
			short num = (short)1452867584;
			short num2 = num;
			num = (short)1037715362;
			short num3 = num;
			num = (short)1735608226;
			switch (num3 == num)
			{
			}
			num = (short)2011234304;
			if (num != 0)
			{
			}
			num = (short)788529153;
			if (num != 0)
			{
			}
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x06008374 RID: 33652 RVA: 0x007A440C File Offset: 0x007A260C
		public bool HasDiffs
		{
			get
			{
				short num = (short)711131136;
				short num2 = num;
				num = (short)707320714;
				short num3 = num;
				num = (short)57924490;
				switch (num3 == num)
				{
				}
				num = (short)1989672960;
				if (num != 0)
				{
				}
				num = (short)35061761;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x007A44B8 File Offset: 0x007A26B8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1381564416;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1038313808;
					short num4 = num;
					num = (short)703686992;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						num = (short)884080640;
						if (num != 0)
						{
						}
						num = (short)1457782785;
						if (num != 0)
						{
						}
						num = (short)164036610;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)276365315;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					num = (short)393478148;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_13E;
				}
				goto IL_4E;
				IL_13E:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num = (short)261685248;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4E:
			result = null;
			num = (short)1351942145;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x04003E59 RID: 15961
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset innerRecset;
	}
}
