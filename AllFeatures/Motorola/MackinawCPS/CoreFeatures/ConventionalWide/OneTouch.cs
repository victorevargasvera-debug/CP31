using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000552 RID: 1362
	[global::System.Serializable]
	public class OneTouch : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B68C RID: 46732 RVA: 0x00A8F884 File Offset: 0x00A8DA84
		public OneTouch(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x00A8F8A0 File Offset: 0x00A8DAA0
		protected OneTouch(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x00A8F8B8 File Offset: 0x00A8DAB8
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1769252418;
			short num2 = num;
			num = (short)1839441474;
			switch (num2 == num)
			{
			}
			num = (short)401211392;
			short num3 = num;
			num = (short)1492779009;
			if (num != 0)
			{
			}
			num = (short)1175977984;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軀귂ꃄ鷈꓊료곎말", a_);
			base.Id = 10226;
			base.UIName = global::CommonResources.AcgResources.ID_ONETOUCH;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x00A8F99C File Offset: 0x00A8DB9C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)1629013668;
			short num2 = num;
			num = (short)546752164;
			switch (num2 == num)
			{
			}
			num = (short)2097741824;
			short num3 = num;
			num = (short)1389232129;
			if (num != 0)
			{
			}
			num = (short)1932656640;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裆ꟈ껊鯎뻐ꛒ뛔뿖", a_);
			base.Id = 10226;
			base.UIName = global::CommonResources.AcgResources.ID_ONETOUCH;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x00A8FA80 File Offset: 0x00A8DC80
		public override void PopulateReferences()
		{
			short num = (short)477364225;
			if (num != 0)
			{
			}
			num = (short)1539269850;
			short num2 = num;
			num = (short)1668703450;
			switch (num2 == num)
			{
			default:
			{
				num = (short)78249984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1890516992;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x00A8FB28 File Offset: 0x00A8DD28
		public override void DropReferences()
		{
			short num = (short)271074887;
			short num2 = num;
			num = (short)2024687175;
			switch (num2 == num)
			{
			}
			num = (short)1565982720;
			short num3 = num;
			num = (short)97714176;
			if (num != 0)
			{
			}
			num = (short)719388673;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x00A8FBD0 File Offset: 0x00A8DDD0
		public override void SetConstraints()
		{
			short num = (short)393139733;
			short num2 = num;
			num = (short)1040897557;
			switch (num2 == num)
			{
			}
			num = (short)1181614080;
			short num3 = num;
			num = (short)1097859073;
			if (num != 0)
			{
			}
			num = (short)1588002816;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x00A8FC7C File Offset: 0x00A8DE7C
		public override void SetupDependencies()
		{
			short num = (short)1751723498;
			short num2 = num;
			num = (short)481701354;
			switch (num2 == num)
			{
			}
			num = (short)981270528;
			short num3 = num;
			num = (short)1535836160;
			if (num != 0)
			{
			}
			num = (short)1718419457;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x0600B694 RID: 46740 RVA: 0x00A8FD28 File Offset: 0x00A8DF28
		public bool HasDiffs
		{
			get
			{
				short num = (short)83857803;
				short num2 = num;
				num = (short)1969066379;
				switch (num2 == num)
				{
				}
				num = (short)1964179456;
				short num3 = num;
				num = (short)1204486145;
				if (num != 0)
				{
				}
				num = (short)1921581056;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B695 RID: 46741 RVA: 0x00A8FDD8 File Offset: 0x00A8DFD8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)915341312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_85;
				case 3:
					num2 = (short)2039939073;
					if (num2 != 0)
					{
					}
					num2 = (short)1231814660;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1242890240;
						short num3 = num2;
						num2 = (short)1880162305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_85:
			if (base.ParentRecset != null)
			{
				goto IL_90;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)288946434;
			short num4 = num2;
			num2 = (short)1196685570;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_90:
				num2 = (short)179240963;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)283639808;
				if (num2 != 0)
				{
				}
				num2 = (short)111738882;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
