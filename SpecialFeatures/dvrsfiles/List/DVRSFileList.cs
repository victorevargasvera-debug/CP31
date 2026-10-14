using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000133 RID: 307
	[global::System.Serializable]
	public class DVRSFileList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06001028 RID: 4136 RVA: 0x00167C34 File Offset: 0x00165E34
		internal DVRSFileList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횑슓쒕쮗몙\uda9b첟잡蒣솧\ud9a9\ud8ab", a_);
			base.UIName = global::CommonResources.AppResources.DVRS_File_List_ID;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯\udbb3\udbb5좷햹튻\udbbd꺿뛁飃苅黇飉鿋裍맏뻑뇓ꗕ蓗黙諛賝돟ꓡ跣諥跧ꛩ藫鷭蓯껱냳ꃵ꫷꧹뫻韽泿朁䠃漅笇縉∋瘍焏缑砓", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00167CA0 File Offset: 0x00165EA0
		protected DVRSFileList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솄톆\udb88\ud88a권즎ﾒ랖햘", a_);
			base.UIName = global::CommonResources.AppResources.DVRS_File_List_ID;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횄﶐햒爵튠颢좦쒨\udbaa슬솮풰\uddb2솴ﶸ蟀ꫂ꧄ꋆ뫈韊觌駎菐胒鏔뻖뗘뻚釜뛞鋠韢매ꏦ뿨맪뻬ꧮ飰鿲郴믶郸裺觼퇾礀戂栄欆", a_);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00167CF4 File Offset: 0x00165EF4
		public global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection Labtool
		{
			get
			{
				short num = (short)197471936;
				short num2 = num;
				num = (short)1362570944;
				switch (num2 == num)
				{
				}
				num = (short)910753792;
				short num3 = num;
				num = (short)486801409;
				if (num != 0)
				{
				}
				num = (short)1180237824;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection)base[10893];
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00167DB0 File Offset: 0x00165FB0
		internal static global::AcpCommonLib.IAcpFeatureNode GetDVRSFile()
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
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4234)[0];
					num2 = (short)1192034304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1937637381;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A1;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)438566912;
					short num3 = num2;
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)2083520513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)475780600;
					short num4 = num2;
					num2 = (short)917558776;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A1;
					default:
						num2 = (short)831520768;
						if (num2 != 0)
						{
						}
						num2 = (short)1790902273;
						if (num2 != 0)
						{
						}
						num2 = (short)2011430914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					result = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4234)[0];
					num2 = (short)1287913478;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_1A1:
				result = global::AcpCommonLib.FeatureManager.GetFeature(4234)[0];
				num2 = (short)1717501955;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			result = null;
			num2 = (short)787742724;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
