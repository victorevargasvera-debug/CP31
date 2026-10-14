using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002EB RID: 747
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600796A RID: 31082 RVA: 0x006E612C File Offset: 0x006E432C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x006E616C File Offset: 0x006E436C
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600796C RID: 31084 RVA: 0x006E6184 File Offset: 0x006E4384
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1516437504;
			short num2 = num;
			num = (short)803864577;
			if (num != 0)
			{
			}
			num = (short)781660109;
			short num3 = num;
			num = (short)1248735181;
			switch (num3 == num)
			{
			}
			num = (short)24182784;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跉꧋ꃍ뗏ꃑ뗓뫕", a_);
			base.Id = 10218;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x006E6268 File Offset: 0x006E4468
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1469251584;
			short num2 = num;
			num = (short)446211231;
			short num3 = num;
			num = (short)2139989151;
			switch (num3 == num)
			{
			}
			num = (short)1795751937;
			if (num != 0)
			{
			}
			num = (short)1733754880;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觍뗏병뇓ꓕ맗뛙", a_);
			base.Id = 10218;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x006E634C File Offset: 0x006E454C
		public override void PopulateReferences()
		{
			short num = (short)794296320;
			short num2 = num;
			num = (short)723313001;
			short num3 = num;
			num = (short)1959321961;
			switch (num3 == num)
			{
			}
			num = (short)2073100289;
			if (num != 0)
			{
			}
			num = (short)1204748288;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x006E63F8 File Offset: 0x006E45F8
		public override void DropReferences()
		{
			short num = (short)972226560;
			short num2 = num;
			num = (short)1810485946;
			short num3 = num;
			num = (short)989844154;
			switch (num3 == num)
			{
			}
			num = (short)1621884928;
			if (num != 0)
			{
			}
			num = (short)296747009;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x006E64A0 File Offset: 0x006E46A0
		public override void SetConstraints()
		{
			short num = (short)1002700800;
			short num2 = num;
			num = (short)8021835;
			short num3 = num;
			num = (short)1698522955;
			switch (num3 == num)
			{
			}
			num = (short)1874526209;
			if (num != 0)
			{
			}
			num = (short)416612352;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x006E6548 File Offset: 0x006E4748
		public override void SetupDependencies()
		{
			short num = (short)501415936;
			short num2 = num;
			num = (short)9810216;
			short num3 = num;
			num = (short)736669992;
			switch (num3 == num)
			{
			}
			num = (short)107937792;
			if (num != 0)
			{
			}
			num = (short)1144193025;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x006E65F4 File Offset: 0x006E47F4
		public bool HasDiffs
		{
			get
			{
				short num = (short)139395072;
				short num2 = num;
				num = (short)1209117225;
				short num3 = num;
				num = (short)236300841;
				switch (num3 == num)
				{
				}
				num = (short)1878196224;
				if (num != 0)
				{
				}
				num = (short)1721040897;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x006E66A4 File Offset: 0x006E48A4
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
					if (base.ParentRecset != null)
					{
						num2 = (short)568852482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)955121665;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)207683584;
					short num3 = num2;
					num2 = (short)1706098691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)766509060;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)963707962;
					short num4 = num2;
					num2 = (short)735970362;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1150681088;
						if (num2 != 0)
						{
						}
						num2 = (short)1438056449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1229389824;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003355 RID: 13141
		private global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset innerRecset;
	}
}
