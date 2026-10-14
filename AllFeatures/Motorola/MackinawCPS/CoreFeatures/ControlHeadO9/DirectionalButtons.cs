using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000369 RID: 873
	[global::System.Serializable]
	public class DirectionalButtons : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060081B2 RID: 33202 RVA: 0x0078F524 File Offset: 0x0078D724
		public DirectionalButtons(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x0078F564 File Offset: 0x0078D764
		protected DirectionalButtons(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x0078F57C File Offset: 0x0078D77C
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1695560374;
			short num2 = num;
			num = (short)1479160502;
			switch (num2 == num)
			{
			}
			num = (short)190382081;
			if (num != 0)
			{
			}
			num = (short)941686784;
			short num3 = num;
			num = (short)1534263296;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藀ꫂ럄ꋆ꫈뿊꓌ꃎ뿐닒맔鯘껚꧜ꯞ軠跢雤", a_);
			base.Id = 10609;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x0078F660 File Offset: 0x0078D860
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1872245045;
			short num2 = num;
			num = (short)477442357;
			switch (num2 == num)
			{
			}
			num = (short)381222913;
			if (num != 0)
			{
			}
			num = (short)795082752;
			short num3 = num;
			num = (short)1284177920;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軉ꗋ볍뗏뇑ꃓ뿕럗듙뷛닝샟ꃡ釣鋥鳧藩苫鷭", a_);
			base.Id = 10609;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x0078F744 File Offset: 0x0078D944
		public override void PopulateReferences()
		{
			short num = (short)1148825880;
			short num2 = num;
			num = (short)120041752;
			switch (num2 == num)
			{
			}
			num = (short)1090781184;
			if (num != 0)
			{
			}
			num = (short)1541406720;
			short num3 = num;
			num = (short)1008402433;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x0078F7F0 File Offset: 0x0078D9F0
		public override void DropReferences()
		{
			short num = (short)438566913;
			if (num != 0)
			{
			}
			num = (short)72240054;
			short num2 = num;
			num = (short)1336298422;
			switch (num2 == num)
			{
			}
			num = (short)53477376;
			short num3 = num;
			num = (short)959512576;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x0078F898 File Offset: 0x0078DA98
		public override void SetConstraints()
		{
			short num = (short)1605249925;
			short num2 = num;
			num = (short)1255091077;
			switch (num2 == num)
			{
			}
			num = (short)1205469185;
			if (num != 0)
			{
			}
			num = (short)1823080448;
			short num3 = num;
			num = (short)1040056320;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x0078F940 File Offset: 0x0078DB40
		public override void SetupDependencies()
		{
			short num = (short)1860397697;
			short num2 = num;
			num = (short)432827009;
			switch (num2 == num)
			{
			}
			num = (short)50135041;
			if (num != 0)
			{
			}
			num = (short)1136459776;
			short num3 = num;
			num = (short)2108686336;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x060081BA RID: 33210 RVA: 0x0078F9EC File Offset: 0x0078DBEC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1242974167;
				short num2 = num;
				num = (short)2004633559;
				switch (num2 == num)
				{
				}
				num = (short)1025310720;
				if (num != 0)
				{
				}
				num = (short)136839168;
				short num3 = num;
				num = (short)1355743233;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x0078FA9C File Offset: 0x0078DC9C
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)479264772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)16638658;
					short num3 = num2;
					num2 = (short)1199825602;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1334575104;
						if (num2 != 0)
						{
						}
						num2 = (short)218365952;
						short num4 = num2;
						num2 = (short)1681391616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)219873281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)80412675;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)409337857;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)515178498;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003E37 RID: 15927
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset innerRecset;
	}
}
