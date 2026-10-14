using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000556 RID: 1366
	[global::System.Serializable]
	public class SmartPTT : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B6EA RID: 46826 RVA: 0x00A93D44 File Offset: 0x00A91F44
		public SmartPTT(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x00A93D60 File Offset: 0x00A91F60
		protected SmartPTT(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x00A93D78 File Offset: 0x00A91F78
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1023622299;
			short num2 = num;
			num = (short)858799259;
			switch (num2 == num)
			{
			}
			num = (short)1574043649;
			if (num != 0)
			{
			}
			num = (short)180224000;
			short num3 = num;
			num = (short)936312832;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苐뻒듔ꗖ귘ﯚ跜诞뗠", a_);
			base.Id = 10222;
			base.UIName = global::CommonResources.AcgResources.ID_SMARTPTT;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x00A93E5C File Offset: 0x00A9205C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)410208314;
			short num2 = num;
			num = (short)902055994;
			switch (num2 == num)
			{
			}
			num = (short)1829437441;
			if (num != 0)
			{
			}
			num = (short)1737097216;
			short num3 = num;
			num = (short)1802633216;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苐뻒듔ꗖ귘ﯚ跜诞뗠", a_);
			base.Id = 10222;
			base.UIName = global::CommonResources.AcgResources.ID_SMARTPTT;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x00A93F40 File Offset: 0x00A92140
		public override void PopulateReferences()
		{
			short num = (short)1293837661;
			short num2 = num;
			num = (short)356410717;
			switch (num2 == num)
			{
			}
			num = (short)1930821632;
			if (num != 0)
			{
			}
			num = (short)590610432;
			short num3 = num;
			num = (short)1550450689;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x00A93FE8 File Offset: 0x00A921E8
		public override void DropReferences()
		{
			short num = (short)1524936023;
			short num2 = num;
			num = (short)185249111;
			switch (num2 == num)
			{
			}
			num = (short)124715009;
			if (num != 0)
			{
			}
			num = (short)1189150720;
			short num3 = num;
			num = (short)287309824;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x00A94090 File Offset: 0x00A92290
		public override void SetConstraints()
		{
			short num = (short)103194411;
			short num2 = num;
			num = (short)1080925995;
			switch (num2 == num)
			{
			}
			num = (short)1962344448;
			if (num != 0)
			{
			}
			num = (short)559022080;
			short num3 = num;
			num = (short)1439629313;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x00A9413C File Offset: 0x00A9233C
		public override void SetupDependencies()
		{
			short num = (short)1833959764;
			short num2 = num;
			num = (short)1296630100;
			switch (num2 == num)
			{
			}
			num = (short)1761869825;
			if (num != 0)
			{
			}
			num = (short)475136000;
			short num3 = num;
			num = (short)241565696;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005BAF RID: 23471
		// (get) Token: 0x0600B6F2 RID: 46834 RVA: 0x00A941E4 File Offset: 0x00A923E4
		public bool HasDiffs
		{
			get
			{
				short num = (short)763361706;
				short num2 = num;
				num = (short)2000484778;
				switch (num2 == num)
				{
				}
				num = (short)2045444097;
				if (num != 0)
				{
				}
				num = (short)40173568;
				short num3 = num;
				num = (short)1627193344;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x00A94294 File Offset: 0x00A92494
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
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1794181454;
					short num3 = num2;
					num2 = (short)745998670;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)94568448;
						if (num2 != 0)
						{
						}
						num2 = (short)1807745025;
						if (num2 != 0)
						{
						}
						num2 = (short)537264132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						goto IL_6F;
					}
					return result;
				case 2:
					return result;
				case 3:
					num2 = (short)1718616064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1792344066;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_6F:
				num2 = (short)1408434179;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)1689518080;
			short num4 = num2;
			result = null;
			num2 = (short)1710096385;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
