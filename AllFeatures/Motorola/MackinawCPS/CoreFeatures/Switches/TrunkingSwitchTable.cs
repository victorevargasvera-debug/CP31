using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002C0 RID: 704
	[global::System.Serializable]
	public class TrunkingSwitchTable : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007652 RID: 30290 RVA: 0x006AC390 File Offset: 0x006AA590
		public TrunkingSwitchTable(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x006AC3D0 File Offset: 0x006AA5D0
		protected TrunkingSwitchTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x006AC3E8 File Offset: 0x006AA5E8
		public override void Init()
		{
			int a_ = 6;
			short num = (short)401670232;
			short num2 = num;
			num = (short)1152057432;
			switch (num2 == num)
			{
			}
			num = (short)343539712;
			short num3 = num;
			num = (short)183238656;
			if (num != 0)
			{
			}
			num = (short)984875009;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏆믈뻊ꏌ꓎룐뷒닔諘곚드ꯞ苠询엤돦裨觪臬諮", a_);
			base.Id = 10083;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x006AC4CC File Offset: 0x006AA6CC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1660536282;
			short num2 = num;
			num = (short)1450558938;
			switch (num2 == num)
			{
			}
			num = (short)2071003136;
			short num3 = num;
			num = (short)300941313;
			if (num != 0)
			{
			}
			num = (short)1010302976;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋅뫇뿉ꋋꗍ맏병돓诗귙뗛ꫝ菟諡쓣닥觧裩胫语", a_);
			base.Id = 10083;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x006AC5B0 File Offset: 0x006AA7B0
		public override void PopulateReferences()
		{
			short num = (short)113690914;
			short num2 = num;
			num = (short)1275709730;
			switch (num2 == num)
			{
			}
			num = (short)1407516672;
			short num3 = num;
			num = (short)613285888;
			if (num != 0)
			{
			}
			num = (short)1069416449;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x006AC658 File Offset: 0x006AA858
		public override void DropReferences()
		{
			short num = (short)910971671;
			short num2 = num;
			num = (short)1775850263;
			switch (num2 == num)
			{
			}
			num = (short)1522991104;
			short num3 = num;
			num = (short)179765249;
			if (num != 0)
			{
			}
			num = (short)1786052608;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x006AC704 File Offset: 0x006AA904
		public override void SetConstraints()
		{
			short num = (short)2093865532;
			short num2 = num;
			num = (short)1567218236;
			switch (num2 == num)
			{
			}
			num = (short)1107623936;
			short num3 = num;
			num = (short)1194328065;
			if (num != 0)
			{
			}
			num = (short)703135744;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x006AC7B0 File Offset: 0x006AA9B0
		public override void SetupDependencies()
		{
			short num = (short)1375147662;
			short num2 = num;
			num = (short)264312462;
			switch (num2 == num)
			{
			}
			num = (short)290783232;
			short num3 = num;
			num = (short)2044329985;
			if (num != 0)
			{
			}
			num = (short)1685389312;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600765A RID: 30298 RVA: 0x006AC85C File Offset: 0x006AAA5C
		public bool HasDiffs
		{
			get
			{
				short num = (short)979110353;
				short num2 = num;
				num = (short)524028369;
				switch (num2 == num)
				{
				}
				num = (short)1260519424;
				short num3 = num;
				num = (short)471597057;
				if (num != 0)
				{
				}
				num = (short)861405184;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x006AC910 File Offset: 0x006AAB10
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_97;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1927086080;
				short num2 = num;
				num = (short)1218938202;
				short num3 = num;
				num = (short)1988724058;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1988100096;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						return result;
					case 1:
						num = (short)1835139075;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							goto IL_BB;
						}
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)344260612;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						num = (short)674824193;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)919273472;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
				}
				IL_BB:
				num = (short)377159681;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_97:
			result = null;
			num = (short)875560962;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04003085 RID: 12421
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset innerRecset;
	}
}
