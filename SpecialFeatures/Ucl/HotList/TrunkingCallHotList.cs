using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001CB RID: 459
	[global::System.Serializable]
	public class TrunkingCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x001ED4A0 File Offset: 0x001EB6A0
		public global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListHotListSection HotList
		{
			get
			{
				short num = (short)1112604673;
				if (num != 0)
				{
				}
				num = (short)561474239;
				short num2 = num;
				num = (short)715025087;
				switch (num2 == num)
				{
				}
				num = (short)131268608;
				if (num != 0)
				{
				}
				num = (short)1586429952;
				short num3 = num;
				return (global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListHotListSection)base[10416];
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000039A6 File Offset: 0x00001BA6
		private TrunkingCallHotList() : this(null)
		{
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x001ED55C File Offset: 0x001EB75C
		public TrunkingCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힕쮗캙캛톝肟邡醣蚥ﲧ\ud8a9\ud9ab삭\udbaf\udbb1\udab3통颷펻쪽軁귃뗅볇", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListHotListSection(this));
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x001ED5A4 File Offset: 0x001EB7A4
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1616445441;
			if (num != 0)
			{
			}
			num = (short)523515469;
			short num2 = num;
			num = (short)383530573;
			switch (num2 == num)
			{
			}
			num = (short)1963261952;
			if (num != 0)
			{
			}
			num = (short)1377566720;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000038AD File Offset: 0x00001AAD
		protected TrunkingCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x001ED654 File Offset: 0x001EB854
		internal static global::AcpCommonLib.IAcpFeatureNode GetTrunkingCallHotList()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2208)[0][10415].EmbeddedRecset[0];
					num2 = (short)2016477185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1A6;
				case 2:
					goto IL_F7;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)889782278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2208)[0][10415].EmbeddedRecset[0];
					num2 = (short)184483844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_1E5;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)895680512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2117861379;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)767819777;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2208)[0][10415].EmbeddedRecset[0];
					num2 = (short)146866178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
			}
			IL_F7:
			IL_1A6:
			IL_1E5:
			goto IL_1E7;
			IL_2C:
			result = null;
			num2 = (short)1734915145;
			short num3 = num2;
			num2 = (short)1944237129;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1E7:
				num2 = (short)2135359488;
				short num4 = num2;
				return result;
			}
			default:
			{
				num2 = (short)1113784320;
				if (num2 != 0)
				{
				}
				num2 = (short)1122631685;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
