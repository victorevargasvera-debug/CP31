using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C5 RID: 453
	[global::System.Serializable]
	public class PhoneCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x001E7E20 File Offset: 0x001E6020
		public global::SpecialFeatures.Ucl.HotList.PhoneCallHotListHotListSection HotListPhone
		{
			get
			{
				short num = (short)2136476728;
				short num2 = num;
				num = (short)973671480;
				switch (num2 == num)
				{
				}
				num = (short)1468137472;
				if (num != 0)
				{
				}
				num = (short)439222273;
				if (num != 0)
				{
				}
				num = (short)980680704;
				short num3 = num;
				return (global::SpecialFeatures.Ucl.HotList.PhoneCallHotListHotListSection)base[10428];
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000394E File Offset: 0x00001B4E
		private PhoneCallHotList() : this(null)
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x001E7ED8 File Offset: 0x001E60D8
		internal PhoneCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8aﾐ떔\udf96붜펞좠킢톤", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.PhoneCallHotListHotListSection(this));
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x001E7F20 File Offset: 0x001E6120
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1241938199;
			short num2 = num;
			num = (short)983988503;
			switch (num2 == num)
			{
			}
			num = (short)1991311361;
			if (num != 0)
			{
			}
			num = (short)1033633792;
			if (num != 0)
			{
			}
			num = (short)10485760;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000038AD File Offset: 0x00001AAD
		protected PhoneCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x001E7FD0 File Offset: 0x001E61D0
		internal static global::AcpCommonLib.IAcpFeatureNode GetPhoneCallHotList()
		{
			short num = (short)1677066240;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_56;
			}
			int num3;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
				{
					num = (short)359316443;
					short num4 = num;
					num = (short)686144475;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						goto IL_106;
					}
					break;
				}
				case 1:
					goto IL_1E1;
				case 2:
					goto IL_1A1;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)515047428;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2220)[0][10427].EmbeddedRecset[0];
					num = (short)1160249345;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_90;
				case 5:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2220)[0][10427].EmbeddedRecset[0];
					num = (short)1285554178;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1540554757;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)689897475;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_56;
				IL_90:
				result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2220)[0][10427].EmbeddedRecset[0];
				num = (short)1332805632;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_106:
			num = (short)550240256;
			if (num != 0)
			{
			}
			IL_1A1:
			IL_1E1:
			num = (short)648675329;
			if (num != 0)
			{
			}
			return result;
			IL_56:
			result = null;
			num = (short)1826684934;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}
	}
}
