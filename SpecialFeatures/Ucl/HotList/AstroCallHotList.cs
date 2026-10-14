using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001BB RID: 443
	[global::System.Serializable]
	public class AstroCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x001DFCD8 File Offset: 0x001DDED8
		public global::SpecialFeatures.Ucl.HotList.AstroCallHotListHotListSection HotListAstro
		{
			get
			{
				short num = (short)692584326;
				short num2 = num;
				num = (short)50003846;
				switch (num2 == num)
				{
				}
				num = (short)1921581056;
				if (num != 0)
				{
				}
				num = (short)510197761;
				if (num != 0)
				{
				}
				num = (short)2034237440;
				short num3 = num;
				return (global::SpecialFeatures.Ucl.HotList.AstroCallHotListHotListSection)base[10418];
			}
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000038CA File Offset: 0x00001ACA
		private AstroCallHotList() : this(null)
		{
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x001DFD90 File Offset: 0x001DDF90
		internal AstroCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾍쎏욑욓\ud995뢗\ud999횟잡쪣튥솧얩슫쾭\udcaf銱ﲳ\ud9b5첷骹ힽ뎿뛁", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.AstroCallHotListHotListSection(this));
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x001DFDD8 File Offset: 0x001DDFD8
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)270409563;
			short num2 = num;
			num = (short)556867419;
			switch (num2 == num)
			{
			}
			num = (short)2056781825;
			if (num != 0)
			{
			}
			num = (short)166395904;
			if (num != 0)
			{
			}
			num = (short)562757632;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000038AD File Offset: 0x00001AAD
		protected AstroCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x001DFE8C File Offset: 0x001DE08C
		internal static global::AcpCommonLib.IAcpFeatureNode GetAstroCallHotList()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1C4;
				case 1:
					goto IL_1C4;
				case 2:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2210)[0][10417].EmbeddedRecset[0];
					num2 = (short)952827905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)177078272;
					short num3 = num2;
					goto IL_1C4;
				}
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)874708998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2210)[0][10417].EmbeddedRecset[0];
					num2 = (short)1256259584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_4E;
					}
					num2 = (short)722927620;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)852164609;
					if (num2 != 0)
					{
					}
					result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2210)[0][10417].EmbeddedRecset[0];
					num2 = (short)1238564867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_4E:
				num2 = (short)1011875842;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C4:
				num2 = (short)1184393457;
				short num4 = num2;
				num2 = (short)588671217;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4E;
				default:
					goto IL_1FA;
				}
			}
			IL_1FA:
			num2 = (short)884473856;
			if (num2 != 0)
			{
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)643104773;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
