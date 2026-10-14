using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200009C RID: 156
	[global::System.Serializable]
	public class OneTouch : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060011E6 RID: 4582 RVA: 0x00112340 File Offset: 0x00110540
		public OneTouch(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00112380 File Offset: 0x00110580
		protected OneTouch(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00112398 File Offset: 0x00110598
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1630273536;
			short num2 = num;
			num = (short)1438649971;
			short num3 = num;
			num = (short)2047872627;
			switch (num3 == num)
			{
			}
			num = (short)1661796353;
			if (num != 0)
			{
			}
			num = (short)1067319296;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諄꧆곈駌ꃎꓐ냒뷔", a_);
			base.Id = 10165;
			base.UIName = global::CommonResources.AcgResources.ID_ONETOUCH;
			base.DataTransferOrder = 13;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00112478 File Offset: 0x00110678
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)974651392;
			short num2 = num;
			num = (short)2094093472;
			short num3 = num;
			num = (short)1665094816;
			switch (num3 == num)
			{
			}
			num = (short)1048379393;
			if (num != 0)
			{
			}
			num = (short)141426688;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷑뫓돕軙돛ꯝ菟諡", a_);
			base.Id = 10165;
			base.UIName = global::CommonResources.AcgResources.ID_ONETOUCH;
			base.DataTransferOrder = 13;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0011255C File Offset: 0x0011075C
		public override void PopulateReferences()
		{
			short num = (short)306905088;
			short num2 = num;
			num = (short)648516494;
			short num3 = num;
			num = (short)42570638;
			switch (num3 == num)
			{
			}
			num = (short)1696464896;
			if (num != 0)
			{
			}
			num = (short)1784610817;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00112608 File Offset: 0x00110808
		public override void DropReferences()
		{
			short num = (short)123207680;
			short num2 = num;
			num = (short)591331329;
			if (num != 0)
			{
			}
			num = (short)1325727552;
			short num3 = num;
			num = (short)64945984;
			switch (num3 == num)
			{
			}
			num = (short)1003945984;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x001126B0 File Offset: 0x001108B0
		public override void SetConstraints()
		{
			short num = (short)1799356416;
			short num2 = num;
			num = (short)829046834;
			short num3 = num;
			num = (short)264847410;
			switch (num3 == num)
			{
			}
			num = (short)1362558977;
			if (num != 0)
			{
			}
			num = (short)2082013184;
			if (num != 0)
			{
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0011275C File Offset: 0x0011095C
		public override void SetupDependencies()
		{
			short num = (short)1418330112;
			short num2 = num;
			num = (short)808675807;
			short num3 = num;
			num = (short)1627089375;
			switch (num3 == num)
			{
			}
			num = (short)2080833536;
			if (num != 0)
			{
			}
			num = (short)1406205953;
			if (num != 0)
			{
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0011280C File Offset: 0x00110A0C
		public bool HasDiffs
		{
			get
			{
				short num = (short)564789248;
				short num2 = num;
				num = (short)1335930470;
				short num3 = num;
				num = (short)732933734;
				switch (num3 == num)
				{
				}
				num = (short)1295646721;
				if (num != 0)
				{
				}
				num = (short)1386872832;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x001128BC File Offset: 0x00110ABC
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
					num2 = (short)1011089408;
					short num3 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)595001348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_119;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)197328899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_119;
				case 2:
					goto IL_119;
				case 3:
					IL_117:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)74448898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1941897217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_119:
				num2 = (short)2087423874;
				short num4 = num2;
				num2 = (short)2038468482;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_117;
				default:
					goto IL_150;
				}
			}
			IL_150:
			num2 = (short)826605568;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1053753345;
			if (num2 != 0)
			{
			}
			num2 = (short)1416364032;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400044A RID: 1098
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset innerRecset;
	}
}
