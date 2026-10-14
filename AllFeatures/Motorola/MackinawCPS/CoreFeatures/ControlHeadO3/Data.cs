using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003BB RID: 955
	[global::System.Serializable]
	public class Data : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600898E RID: 35214 RVA: 0x0080B848 File Offset: 0x00809A48
		public Data(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x0080B888 File Offset: 0x00809A88
		protected Data(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x0080B8A0 File Offset: 0x00809AA0
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1426456576;
			short num2 = num;
			num = (short)1782251521;
			if (num != 0)
			{
			}
			num = (short)419099929;
			short num3 = num;
			num = (short)1444214041;
			switch (num3 == num)
			{
			}
			num = (short)1328676864;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊", a_);
			base.Id = 10234;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x0080B984 File Offset: 0x00809B84
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1040449536;
			short num2 = num;
			num = (short)714868037;
			short num3 = num;
			num = (short)320406853;
			switch (num3 == num)
			{
			}
			num = (short)1646788608;
			if (num != 0)
			{
			}
			num = (short)225181697;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗", a_);
			base.Id = 10234;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x0080BA68 File Offset: 0x00809C68
		public override void PopulateReferences()
		{
			short num = (short)852099072;
			short num2 = num;
			num = (short)5640892;
			short num3 = num;
			num = (short)1383207612;
			switch (num3 == num)
			{
			}
			num = (short)1367998465;
			if (num != 0)
			{
			}
			num = (short)716505088;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x0080BB14 File Offset: 0x00809D14
		public override void DropReferences()
		{
			short num = (short)2145124352;
			short num2 = num;
			num = (short)2021433;
			short num3 = num;
			num = (short)1186912313;
			switch (num3 == num)
			{
			}
			num = (short)909115392;
			if (num != 0)
			{
			}
			num = (short)1333592065;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x0080BBC0 File Offset: 0x00809DC0
		public override void SetConstraints()
		{
			short num = (short)1907490816;
			short num2 = num;
			num = (short)1019805697;
			if (num != 0)
			{
			}
			num = (short)473543733;
			short num3 = num;
			num = (short)2059318325;
			switch (num3 == num)
			{
			}
			num = (short)2076311552;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x0080BC68 File Offset: 0x00809E68
		public override void SetupDependencies()
		{
			short num = (short)542638080;
			short num2 = num;
			num = (short)73468451;
			short num3 = num;
			num = (short)773589539;
			switch (num3 == num)
			{
			}
			num = (short)1786839041;
			if (num != 0)
			{
			}
			num = (short)468385792;
			if (num != 0)
			{
			}
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x06008996 RID: 35222 RVA: 0x0080BD10 File Offset: 0x00809F10
		public bool HasDiffs
		{
			get
			{
				short num = (short)2056650752;
				short num2 = num;
				num = (short)1504375171;
				short num3 = num;
				num = (short)1211167107;
				switch (num3 == num)
				{
				}
				num = (short)179175424;
				if (num != 0)
				{
				}
				num = (short)610926593;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x0080BDC0 File Offset: 0x00809FC0
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
					goto IL_10B;
				case 1:
					return result;
				case 2:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)404308965;
					short num3 = num2;
					num2 = (short)1012614117;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						num2 = (short)1039794176;
						if (num2 != 0)
						{
						}
						num2 = (short)2037383171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					num2 = (short)768475136;
					short num4 = num2;
					num2 = (short)256311300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1720320000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_10B:
				num2 = (short)306970625;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)1894973441;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)1178009602;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400417F RID: 16767
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset innerRecset;
	}
}
