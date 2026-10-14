using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E4 RID: 484
	[global::System.Serializable]
	public class SignalIndependentProductIndependentProgrammableButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060054AC RID: 21676 RVA: 0x004CEA24 File Offset: 0x004CCC24
		public SignalIndependentProductIndependentProgrammableButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x004CEA64 File Offset: 0x004CCC64
		protected SignalIndependentProductIndependentProgrammableButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x004CEA7C File Offset: 0x004CCC7C
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1118699521;
			if (num != 0)
			{
			}
			num = (short)697917489;
			short num2 = num;
			num = (short)1716936753;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2070544384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)770113536;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臑뷓뇕뛗믙냛ﻝ꧟賡胣菥飧迩苫諭闯鳱胳훵ꣷ裹鏻髽痿愁瀃★䄇搉栋欍怏眑稓爕紗琙栛㸝瀟倡䬣䄥娧䬩䄫䌭儯倱堳匵ᠷ砹䤻䨽㐿ⵁ⩃", a_);
			base.Id = 10029;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x004CEB60 File Offset: 0x004CCD60
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1272250369;
			if (num != 0)
			{
			}
			num = (short)2012146550;
			short num2 = num;
			num = (short)1543039862;
			switch (num2 == num)
			{
			default:
			{
				num = (short)942342144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1638989824;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胒볔냖럘뫚뇜￞꣠跢臤苦駨軪菬诮铰鷲致ퟶ꧸觺鋼鯾琀怂焄✆䀈攊椌樎愐瘒笔猖簘甚検㼞焠儢䨤䀦嬨䨪䀬䈮倰儲头制ᤸ示䠼䬾㕀ⱂ⭄", a_);
			base.Id = 10029;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x004CEC44 File Offset: 0x004CCE44
		public override void PopulateReferences()
		{
			short num = (short)1798438913;
			if (num != 0)
			{
			}
			num = (short)1692185315;
			short num2 = num;
			num = (short)912175843;
			switch (num2 == num)
			{
			default:
			{
				num = (short)529203200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)198836224;
			if (num != 0)
			{
			}
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x004CECF0 File Offset: 0x004CCEF0
		public override void DropReferences()
		{
			short num = (short)1951051197;
			short num2 = num;
			num = (short)153923005;
			switch (num2 == num)
			{
			}
			num = (short)1852047360;
			short num3 = num;
			num = (short)1966014465;
			if (num != 0)
			{
			}
			num = (short)217317376;
			if (num != 0)
			{
			}
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x004CED98 File Offset: 0x004CCF98
		public override void SetConstraints()
		{
			short num = (short)1402563340;
			short num2 = num;
			num = (short)1258908428;
			switch (num2 == num)
			{
			}
			num = (short)470482944;
			short num3 = num;
			num = (short)375062529;
			if (num != 0)
			{
			}
			num = (short)1093337088;
			if (num != 0)
			{
			}
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x004CEE40 File Offset: 0x004CD040
		public override void SetupDependencies()
		{
			short num = (short)258132210;
			short num2 = num;
			num = (short)1649592562;
			switch (num2 == num)
			{
			}
			num = (short)1398407168;
			short num3 = num;
			num = (short)242024449;
			if (num != 0)
			{
			}
			num = (short)1614479360;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x004CEEE8 File Offset: 0x004CD0E8
		public bool HasDiffs
		{
			get
			{
				short num = (short)834767367;
				short num2 = num;
				num = (short)1910934023;
				switch (num2 == num)
				{
				}
				num = (short)1289748480;
				short num3 = num;
				num = (short)1188626432;
				if (num != 0)
				{
				}
				num = (short)1043398657;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x004CEF98 File Offset: 0x004CD198
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
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1225588740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1932722179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)2142948147;
					short num3 = num2;
					num2 = (short)345033523;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)395837440;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)131268609;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1847656448;
					short num4 = num2;
					num2 = (short)157089792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)883556353;
			if (num2 != 0)
			{
			}
			num2 = (short)1959395330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002168 RID: 8552
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset innerRecset;
	}
}
