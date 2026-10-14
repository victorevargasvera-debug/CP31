using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200010D RID: 269
	public static class PCR_CFSFeatureCodeExtensions
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000A8F38 File Offset: 0x000A7138
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x000A8FE4 File Offset: 0x000A71E4
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> CapacityMaxFeatures
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)602983660;
				short num2 = num;
				num = (short)285265132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)877002752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1731657729;
				if (num != 0)
				{
				}
				num = (short)2146959360;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1518192779;
				short num2 = num;
				num = (short)934856843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246953472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1559166977;
				if (num != 0)
				{
				}
				num = (short)1377107968;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.b = value;
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000A9094 File Offset: 0x000A7294
		static PCR_CFSFeatureCodeExtensions()
		{
			short num = (short)357196790;
			short num2 = num;
			num = (short)661087222;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1643773952;
				short num3 = num;
				num = (short)958201856;
				if (num != 0)
				{
				}
				num = (short)60162049;
				if (num != 0)
				{
				}
				num = (short)2057240576;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute>();
			global::System.Collections.IEnumerator enumerator = global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode)).GetEnumerator();
			try
			{
				num = (short)318373889;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_112;
						}
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2084044803;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode pcr_CFSFeatureCode = (global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode)enumerator.Current;
						global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute value = pcr_CFSFeatureCode.a();
						global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a.Add(pcr_CFSFeatureCode, value);
						num = (short)435224576;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1879638020;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_19C;
					}
					IL_14B:
					num = (short)387317762;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_112:
					goto IL_14B;
				}
				IL_19C:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_1BB;
				}
				int num4;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1A8:
					switch (num4)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)1854668801;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20F;
					case 1:
						disposable.Dispose();
						num = (short)1734410242;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_20D;
					}
					goto IL_1BB;
				}
				IL_20D:
				IL_20F:
				goto EndFinally_5;
				IL_1BB:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1361510400;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_1A8;
				EndFinally_5:;
			}
			global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.CapacityMaxFeatures = global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute>, bool>(global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.<>c.<>9.a)).Select(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute>, global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>(global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.<>c.<>9.b)).ToList<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>();
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000A92FC File Offset: 0x000A74FC
		public static bool IsAppFeature(this global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode feature)
		{
			short num = (short)1066205185;
			if (num != 0)
			{
			}
			num = (short)1346961408;
			short num2 = num;
			num = (short)1203709515;
			short num3 = num;
			num = (short)267724363;
			switch (num3 == num)
			{
			}
			num = (short)1132986368;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a[feature].FeatureCodeType == global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType.Application;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000A93B8 File Offset: 0x000A75B8
		public static bool IsRadioCombinedFeature(this global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode feature)
		{
			short num = (short)1768751105;
			if (num != 0)
			{
			}
			num = (short)970676158;
			short num2 = num;
			num = (short)70670270;
			switch (num2 == num)
			{
			}
			num = (short)77398016;
			short num3 = num;
			num = (short)341770240;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a[feature].FeatureCodeType == global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType.RadioCombined;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000A9474 File Offset: 0x000A7674
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> GetCombinedFeatures(this global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode feature)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_EF;
				case 1:
					if (feature.IsRadioCombinedFeature())
					{
						num2 = (short)1970274307;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>
					{
						feature
					};
					num2 = (short)1806041088;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)85917696;
					short num3 = num2;
					result = global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a[feature].SubFeatureCodes;
					num2 = (short)1601961986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			IL_EF:
			num2 = (short)1189675009;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)1249622275;
			short num4 = num2;
			num2 = (short)791656707;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)854589440;
				if (num2 != 0)
				{
				}
				num2 = (short)1179058177;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000A95C8 File Offset: 0x000A77C8
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> GetCapacityMaxFeatures(this global::Motorola.CommonCPS.Server.EntityModel.BLVersion cpVersion)
		{
			short num = (short)6132607;
			short num2 = num;
			num = (short)82416511;
			switch (num2 == num)
			{
			}
			num = (short)256573441;
			if (num != 0)
			{
			}
			num = (short)1402994688;
			short num3 = num;
			num = (short)537067520;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a a = new global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a();
			a.a = cpVersion;
			return global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.a.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute>, bool>(a.b)).Select(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute>, global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>(global::Motorola.CommonCPS.Server.EntityModel.PCR_CFSFeatureCodeExtensions.<>c.<>9.c)).ToList<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>();
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000A96C0 File Offset: 0x000A78C0
		private static global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute a(this global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode A_0)
		{
			short num = (short)789138797;
			short num2 = num;
			num = (short)1187401069;
			switch (num2 == num)
			{
			}
			num = (short)1318060032;
			if (num != 0)
			{
			}
			num = (short)457441280;
			short num3 = num;
			num = (short)1510342657;
			if (num != 0)
			{
			}
			return global::System.Attribute.GetCustomAttribute(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode).GetMember(A_0.ToString())[0], typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute)) as global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute;
		}

		// Token: 0x0400075F RID: 1887
		private static global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute> a;

		// Token: 0x04000760 RID: 1888
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> b;

		// Token: 0x0200010F RID: 271
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000FD6 RID: 4054 RVA: 0x000A9A90 File Offset: 0x000A7C90
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeAttribute> A_0)
			{
				while (new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(A_0.Value.cpVersion) <= this.a)
				{
					short num = (short)673225196;
					short num2 = num;
					num = (short)506632684;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1958084608;
						if (num != 0)
						{
						}
						num = (short)1690828801;
						if (num != 0)
						{
						}
						num = (short)1526923264;
						short num3 = num;
						return A_0.Value.FeatureCodeType == global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType.CapacityMax;
					}
					}
				}
				return false;
			}

			// Token: 0x04000763 RID: 1891
			public global::Motorola.CommonCPS.Server.EntityModel.BLVersion a;
		}
	}
}
