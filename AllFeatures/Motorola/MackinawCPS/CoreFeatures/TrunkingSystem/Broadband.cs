using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000068 RID: 104
	[global::System.Serializable]
	public class Broadband : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x0009AE14 File Offset: 0x00099014
		public Broadband(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0009AE30 File Offset: 0x00099030
		protected Broadband(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0009AE48 File Offset: 0x00099048
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1861550080;
			short num2 = num;
			num = (short)1908922662;
			short num3 = num;
			num = (short)2044909862;
			switch (num3 == num)
			{
			}
			num = (short)235601920;
			if (num != 0)
			{
			}
			num = (short)217972737;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臂럄꣆꣈꿊꿌껎뿐럒", a_);
			base.Id = 10889;
			base.UIName = global::CommonResources.AcgResources.ID_BROADBAND;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0009AF2C File Offset: 0x0009912C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1956052992;
			short num2 = num;
			num = (short)1094178033;
			short num3 = num;
			num = (short)1684460785;
			switch (num3 == num)
			{
			}
			num = (short)679804928;
			if (num != 0)
			{
			}
			num = (short)1395982337;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诈맊ꋌ껎뗐뇒듔맖뷘", a_);
			base.Id = 10889;
			base.UIName = global::CommonResources.AcgResources.ID_BROADBAND;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0009B010 File Offset: 0x00099210
		public override void PopulateReferences()
		{
			short num = (short)1522139136;
			short num2 = num;
			num = (short)2126359952;
			short num3 = num;
			num = (short)2097458576;
			switch (num3 == num)
			{
			}
			num = (short)646447105;
			if (num != 0)
			{
			}
			num = (short)243597312;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0009B0B8 File Offset: 0x000992B8
		public override void DropReferences()
		{
			short num = (short)1032126464;
			short num2 = num;
			num = (short)1248195877;
			short num3 = num;
			num = (short)6550821;
			switch (num3 == num)
			{
			}
			num = (short)1083244545;
			if (num != 0)
			{
			}
			num = (short)472383488;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0009B164 File Offset: 0x00099364
		public override void SetConstraints()
		{
			short num = (short)372572160;
			short num2 = num;
			num = (short)869103402;
			short num3 = num;
			num = (short)1361803050;
			switch (num3 == num)
			{
			}
			num = (short)1604321281;
			if (num != 0)
			{
			}
			num = (short)950599680;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0009B20C File Offset: 0x0009940C
		public override void SetupDependencies()
		{
			short num = (short)491913216;
			short num2 = num;
			num = (short)698699750;
			short num3 = num;
			num = (short)2097237990;
			switch (num3 == num)
			{
			}
			num = (short)2005336065;
			if (num != 0)
			{
			}
			num = (short)813498368;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0009B2B8 File Offset: 0x000994B8
		public bool HasDiffs
		{
			get
			{
				short num = (short)480182272;
				short num2 = num;
				num = (short)101895954;
				short num3 = num;
				num = (short)1835781906;
				switch (num3 == num)
				{
				}
				num = (short)1673461761;
				if (num != 0)
				{
				}
				num = (short)2133655552;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0009B368 File Offset: 0x00099568
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
						num2 = (short)1416953858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1654566605;
					short num3 = num2;
					num2 = (short)2069999309;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1906704384;
						if (num2 != 0)
						{
						}
						num2 = (short)1974534148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)1804271617;
					if (num2 != 0)
					{
					}
					num2 = (short)562233347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1681457153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)1224212480;
			short num4 = num2;
			result = null;
			num2 = (short)957480960;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
