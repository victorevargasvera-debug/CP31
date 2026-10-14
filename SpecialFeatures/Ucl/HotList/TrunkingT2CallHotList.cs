using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001CE RID: 462
	[global::System.Serializable]
	public class TrunkingT2CallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x001EFD70 File Offset: 0x001EDF70
		public global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListHotListSection HotListT2
		{
			get
			{
				short num = (short)1753743361;
				if (num != 0)
				{
				}
				num = (short)1088749568;
				short num2 = num;
				num = (short)1111347150;
				short num3 = num;
				num = (short)1501417422;
				switch (num3 == num)
				{
				}
				num = (short)612237312;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListHotListSection)base[10422];
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000039D2 File Offset: 0x00001BD2
		private TrunkingT2CallHotList() : this(null)
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x001EFE28 File Offset: 0x001EE028
		internal TrunkingT2CallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏뢗펙햛뺝킡톣좥쎧쎩슫즭邯缾\udbb3습颷햻춽뒿", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListHotListSection(this));
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x001EFE70 File Offset: 0x001EE070
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)220383098;
			short num2 = num;
			num = (short)478791546;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1201274880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)687341569;
			if (num != 0)
			{
			}
			num = (short)2130706432;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000038AD File Offset: 0x00001AAD
		protected TrunkingT2CallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x001EFF24 File Offset: 0x001EE124
		internal static global::AcpCommonLib.IAcpFeatureNode GetTrunkingT2CallHotList()
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
					goto IL_5E;
				case 1:
					return result;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1494417413;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2214)[0][10421].EmbeddedRecset[0];
					num2 = (short)945946627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
				{
					num2 = (short)1372454912;
					short num3 = num2;
					num2 = (short)647248684;
					short num4 = num2;
					num2 = (short)1591163692;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
						num2 = (short)2128412672;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2214)[0][10421].EmbeddedRecset[0];
						num2 = (short)154075137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1045233664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2127233025;
					if (num2 != 0)
					{
					}
					num2 = (short)1079836674;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_5E:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2214)[0][10421].EmbeddedRecset[0];
				num2 = (short)625737732;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)124518406;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
