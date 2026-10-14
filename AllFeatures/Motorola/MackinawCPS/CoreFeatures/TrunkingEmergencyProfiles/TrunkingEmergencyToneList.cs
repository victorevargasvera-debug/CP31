using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200047F RID: 1151
	[global::System.Serializable]
	public class TrunkingEmergencyToneList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060097DD RID: 38877 RVA: 0x008E9538 File Offset: 0x008E7738
		public TrunkingEmergencyToneList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x008E9578 File Offset: 0x008E7778
		protected TrunkingEmergencyToneList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x008E9590 File Offset: 0x008E7790
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1538693128;
			short num2 = num;
			num = (short)1683068936;
			switch (num2 == num)
			{
			}
			num = (short)1612972033;
			if (num != 0)
			{
			}
			num = (short)1847066624;
			short num3 = num;
			num = (short)1757544448;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諎볐뛒꟔냖볘뗚뻜ꛞ쇠럢諤触賨쯪ꇬ蛮苰蟲", a_);
			base.Id = 10775;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONELIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x008E9674 File Offset: 0x008E7874
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)2068179028;
			short num2 = num;
			num = (short)861726804;
			switch (num2 == num)
			{
			}
			num = (short)1782317057;
			if (num != 0)
			{
			}
			num = (short)1064239104;
			short num3 = num;
			num = (short)1306198016;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韑맓돕꫗뷙맛냝菟鯡쓣닥蟧蓩觫컭볯鯱蟳苵", a_);
			base.Id = 10775;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONELIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x008E9758 File Offset: 0x008E7958
		public override void PopulateReferences()
		{
			short num = (short)1318817824;
			short num2 = num;
			num = (short)699174944;
			switch (num2 == num)
			{
			}
			num = (short)1057816577;
			if (num != 0)
			{
			}
			num = (short)1217658880;
			short num3 = num;
			num = (short)1119748096;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x008E9804 File Offset: 0x008E7A04
		public override void DropReferences()
		{
			short num = (short)2127082133;
			short num2 = num;
			num = (short)1174450837;
			switch (num2 == num)
			{
			}
			num = (short)316801025;
			if (num != 0)
			{
			}
			num = (short)19070976;
			short num3 = num;
			num = (short)1356005376;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x008E98AC File Offset: 0x008E7AAC
		public override void SetConstraints()
		{
			short num = (short)1067909121;
			if (num != 0)
			{
			}
			num = (short)391639456;
			short num2 = num;
			num = (short)130740640;
			switch (num2 == num)
			{
			}
			num = (short)120979456;
			short num3 = num;
			num = (short)510590976;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x008E9958 File Offset: 0x008E7B58
		public override void SetupDependencies()
		{
			short num = (short)1809425220;
			short num2 = num;
			num = (short)695771972;
			switch (num2 == num)
			{
			}
			num = (short)2042363904;
			if (num != 0)
			{
			}
			num = (short)675282944;
			short num3 = num;
			num = (short)1182072833;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x060097E5 RID: 38885 RVA: 0x008E9A00 File Offset: 0x008E7C00
		public bool HasDiffs
		{
			get
			{
				short num = (short)1981096994;
				short num2 = num;
				num = (short)566830114;
				switch (num2 == num)
				{
				}
				num = (short)1819475969;
				if (num != 0)
				{
				}
				num = (short)1033961472;
				short num3 = num;
				num = (short)1452343296;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x008E9AB0 File Offset: 0x008E7CB0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				num = (short)1429012480;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				int num3;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)805961729;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117;
					case 1:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1602027524;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							num = (short)1896218627;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117;
					case 3:
						num = (short)1034289152;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_D7;
					}
					goto IL_4D;
				}
				IL_117:
				num = (short)2025491748;
				short num4 = num;
				num = (short)1446677796;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_14E;
				}
				IL_D7:
				goto IL_117;
				IL_4D:
				num = (short)1834024961;
				if (num != 0)
				{
				}
				result = null;
				num = (short)295043074;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			IL_14E:
			num = (short)1594032128;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x04004B0E RID: 19214
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerRecset innerRecset;
	}
}
