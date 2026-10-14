using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C2 RID: 450
	[global::System.Serializable]
	public class MDCCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x001E4CD0 File Offset: 0x001E2ED0
		public global::SpecialFeatures.Ucl.HotList.MDCCallHotListHotListSection HotListMDC
		{
			get
			{
				short num = (short)1149695078;
				short num2 = num;
				num = (short)1604252774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1160249344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2022506497;
				if (num != 0)
				{
				}
				num = (short)1445920768;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.MDCCallHotListHotListSection)base[10420];
			}
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00003922 File Offset: 0x00001B22
		private MDCCallHotList() : this(null)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x001E4D88 File Offset: 0x001E2F88
		internal MDCCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎍풏톑뒓햕ﮝ캟횡춣즥욧쮩삫躭\uddb1삳隵펹쾻쪽", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.MDCCallHotListHotListSection(this));
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x001E4DD0 File Offset: 0x001E2FD0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1250426881;
			if (num != 0)
			{
			}
			num = (short)1617166336;
			short num2 = num;
			num = (short)596202767;
			short num3 = num;
			num = (short)1493914895;
			switch (num3 == num)
			{
			}
			num = (short)1779761152;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000038AD File Offset: 0x00001AAD
		protected MDCCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x001E4E84 File Offset: 0x001E3084
		internal static global::AcpCommonLib.IAcpFeatureNode GetMDCCallHotList()
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
					return result;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1561198594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2212)[0][10419].EmbeddedRecset[0];
					num2 = (short)2080178182;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1144651776;
					short num3 = num2;
					num2 = (short)1517727146;
					short num4 = num2;
					num2 = (short)1591061930;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5F;
					default:
						num2 = (short)1365966849;
						if (num2 != 0)
						{
						}
						num2 = (short)2087321600;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2212)[0][10419].EmbeddedRecset[0];
						num2 = (short)202047488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1080950789;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1464401921;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					goto IL_5F;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_5F:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2212)[0][10419].EmbeddedRecset[0];
				num2 = (short)2055733252;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)1595736067;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
