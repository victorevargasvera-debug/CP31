using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000339 RID: 825
	[global::System.Serializable]
	public class DirectMode : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007F41 RID: 32577 RVA: 0x00752580 File Offset: 0x00750780
		public DirectMode(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x007525C0 File Offset: 0x007507C0
		protected DirectMode(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x007525D8 File Offset: 0x007507D8
		public override void Init()
		{
			int a_ = 14;
			short num = (short)618169450;
			short num2 = num;
			num = (short)582059114;
			switch (num2 == num)
			{
			}
			num = (short)862978049;
			if (num != 0)
			{
			}
			num = (short)1314848768;
			short num3 = num;
			num = (short)7733248;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诎룐ꇒ냔듖귘ﯚ郜냞藠蛢", a_);
			base.Id = 10220;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMODE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x007526BC File Offset: 0x007508BC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)1102945519;
			short num2 = num;
			num = (short)1115331823;
			switch (num2 == num)
			{
			}
			num = (short)1004863489;
			if (num != 0)
			{
			}
			num = (short)1119092736;
			short num3 = num;
			num = (short)1882849280;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郓뿕꫗뿙뿛ꫝ샟꿡诣若跧", a_);
			base.Id = 10220;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMODE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x007527A0 File Offset: 0x007509A0
		public override void PopulateReferences()
		{
			short num = (short)1434693306;
			short num2 = num;
			num = (short)1336651450;
			switch (num2 == num)
			{
			}
			num = (short)100597760;
			if (num != 0)
			{
			}
			num = (short)1515913216;
			short num3 = num;
			num = (short)845611009;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00752848 File Offset: 0x00750A48
		public override void DropReferences()
		{
			short num = (short)2096311618;
			short num2 = num;
			num = (short)1450716482;
			switch (num2 == num)
			{
			}
			num = (short)1376321536;
			if (num != 0)
			{
			}
			num = (short)172359680;
			short num3 = num;
			num = (short)381485057;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x007528F4 File Offset: 0x00750AF4
		public override void SetConstraints()
		{
			short num = (short)612371520;
			short num2 = num;
			num = (short)1736248384;
			switch (num2 == num)
			{
			}
			num = (short)968687616;
			if (num != 0)
			{
			}
			num = (short)1180762112;
			short num3 = num;
			num = (short)946339841;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x007529A0 File Offset: 0x00750BA0
		public override void SetupDependencies()
		{
			short num = (short)2077637190;
			short num2 = num;
			num = (short)2056927814;
			switch (num2 == num)
			{
			}
			num = (short)693239809;
			if (num != 0)
			{
			}
			num = (short)843710464;
			short num3 = num;
			num = (short)2145255424;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x06007F49 RID: 32585 RVA: 0x00752A4C File Offset: 0x00750C4C
		public bool HasDiffs
		{
			get
			{
				short num = (short)987150358;
				short num2 = num;
				num = (short)749516822;
				switch (num2 == num)
				{
				}
				num = (short)1723990016;
				if (num != 0)
				{
				}
				num = (short)2028470272;
				short num3 = num;
				num = (short)266731521;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x00752AFC File Offset: 0x00750CFC
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
					while (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)957694651;
						short num3 = num2;
						num2 = (short)1385317051;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num2 = (short)850329600;
							if (num2 != 0)
							{
							}
							num2 = (short)465043456;
							short num4 = num2;
							num2 = (short)348585988;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
						}
					}
					return result;
				case 1:
					return result;
				case 2:
					num2 = (short)530841601;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)350158851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1493106688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1992491009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)837025794;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039A7 RID: 14759
		private global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset innerRecset;
	}
}
