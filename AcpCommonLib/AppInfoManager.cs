using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using AcpCommonLib.Exceptions;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.FindResult;
using AcpCommonLib.StatusMessage;
using AcpCommonLib.UndoRedo;
using AcpUtility;

namespace AcpCommonLib
{
	// Token: 0x02000004 RID: 4
	public static class AppInfoManager
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002EF8 File Offset: 0x000010F8
		static AppInfoManager()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_18B;
				case 1:
					if (!(bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num2 = (short)1856831490;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
					num2 = (short)891561012;
					short num3 = num2;
					num2 = (short)407118900;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)227540992;
						if (num2 != 0)
						{
						}
						num2 = (short)2136342528;
						short num4 = num2;
						num2 = (short)1358692352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_25;
			}
			IL_18B:
			num2 = (short)2006515713;
			if (num2 != 0)
			{
			}
			return;
			IL_25:
			global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER = 7;
			global::AcpCommonLib.AppInfoManager.a = new global::AcpCommonLib.AcpAppInfoHelper();
			global::AcpCommonLib.AppInfoManager.b = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			global::AcpCommonLib.AppInfoManager.c = null;
			global::AcpCommonLib.AppInfoManager.d = new global::System.Collections.Generic.List<global::System.Type>();
			global::AcpCommonLib.AppInfoManager.e = global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode;
			global::AcpCommonLib.AppInfoManager.f = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			global::AcpCommonLib.AppInfoManager.g = false;
			global::AcpCommonLib.AppInfoManager.h = false;
			global::AcpCommonLib.AppInfoManager.i = true;
			global::AcpCommonLib.AppInfoManager.j = false;
			global::AcpCommonLib.AppInfoManager.k = false;
			global::AcpCommonLib.AppInfoManager.p = false;
			global::AcpCommonLib.AppInfoManager.q = global::AcpCommonLib.Exceptions.AcpSecurityException.b("韱髳", a_);
			global::AcpCommonLib.AppInfoManager.r = false;
			global::AcpCommonLib.AppInfoManager.s = false;
			global::AcpCommonLib.AppInfoManager.au = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.SortedSet<string>>();
			num2 = (short)2000420865;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000030B8 File Offset: 0x000012B8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003168 File Offset: 0x00001368
		public static global::AcpCommonLib.AcpAppInfoHelper AppInfoHelper
		{
			get
			{
				short num = (short)1423438562;
				short num2 = num;
				num = (short)1459876578;
				switch (num2 == num)
				{
				}
				num = (short)809762816;
				if (num != 0)
				{
				}
				num = (short)1167261697;
				if (num != 0)
				{
				}
				num = (short)1507262464;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.a;
			}
			private set
			{
				short num = (short)1539873438;
				short num2 = num;
				num = (short)2015074974;
				switch (num2 == num)
				{
				}
				num = (short)1460731905;
				if (num != 0)
				{
				}
				num = (short)120455168;
				if (num != 0)
				{
				}
				num = (short)957087744;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.a = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003218 File Offset: 0x00001418
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000032C4 File Offset: 0x000014C4
		public static global::AcpCommonLib.DifferentiatedUserViewType AppView
		{
			get
			{
				short num = (short)2132050879;
				short num2 = num;
				num = (short)775783359;
				switch (num2 == num)
				{
				}
				num = (short)976551937;
				if (num != 0)
				{
				}
				num = (short)1680408576;
				if (num != 0)
				{
				}
				num = (short)900268032;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.b;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						num2 = (short)813432833;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num2 = (short)752680962;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.AppView = value;
						num2 = (short)1832870722;
						short num3 = num2;
						num2 = (short)1911644994;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)832110592;
							short num4 = num2;
							num2 = (short)1126301696;
							if (num2 != 0)
							{
							}
							num2 = (short)1444413440;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				global::AcpCommonLib.AppInfoManager.b = value;
				num2 = (short)746717185;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000033E8 File Offset: 0x000015E8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00003498 File Offset: 0x00001698
		public static global::AcpCommonLib.UndoRedo.ContainerTask DndAndImportTask
		{
			get
			{
				short num = (short)1026466874;
				short num2 = num;
				num = (short)1521984570;
				switch (num2 == num)
				{
				}
				num = (short)321650689;
				if (num != 0)
				{
				}
				num = (short)1994260480;
				if (num != 0)
				{
				}
				num = (short)1131610112;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.c;
			}
			set
			{
				short num = (short)1767914624;
				short num2 = num;
				num = (short)483015808;
				switch (num2 == num)
				{
				}
				num = (short)1325989889;
				if (num != 0)
				{
				}
				num = (short)1286930432;
				if (num != 0)
				{
				}
				num = (short)989134848;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.c = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003548 File Offset: 0x00001748
		public static global::System.Collections.Generic.List<global::System.Type> DndAndImportSection
		{
			get
			{
				short num = (short)1077201720;
				short num2 = num;
				num = (short)1121438520;
				switch (num2 == num)
				{
				}
				num = (short)894435329;
				if (num != 0)
				{
				}
				num = (short)2053373952;
				if (num != 0)
				{
				}
				num = (short)717160448;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.d;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000035F8 File Offset: 0x000017F8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000036A8 File Offset: 0x000018A8
		public static global::AcpCommonLib.ApplicationMode AppMode
		{
			get
			{
				short num = (short)2063491520;
				short num2 = num;
				num = (short)287269312;
				switch (num2 == num)
				{
				}
				num = (short)588578817;
				if (num != 0)
				{
				}
				num = (short)1025638400;
				if (num != 0)
				{
				}
				num = (short)1146748928;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.e;
			}
			set
			{
				short num = (short)1220739082;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)891289614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)396492813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						global::AcpCommonLib.AppInfoManager.AppView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
						num = (short)635633667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_21E;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num = (short)1429274644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_21E;
					case 6:
						num = (short)79691777;
						if (num != 0)
						{
						}
						goto IL_1B4;
					case 7:
						if (global::AcpCommonLib.AppInfoManager.e == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)630456320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 8:
						goto IL_153;
					case 9:
						goto IL_21E;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 11:
						global::AcpCommonLib.AppInfoManager.AppView = global::AcpCommonLib.AppInfoManager.f;
						num = (short)1999110150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						global::AcpCommonLib.FeatureManager.ActiveDocument.ClearHasDiffs();
						num = (short)1757085704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (value != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1470889996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					case 14:
						if (value != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)603193355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4;
					case 15:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
						{
							num = (short)1114243091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.AppInfoManager.AppView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						num = (short)276430857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return;
					case 17:
					{
						num = (short)1719861248;
						short num3 = num;
						global::AcpCommonLib.AppInfoManager.f = global::AcpCommonLib.AppInfoManager.AppView;
						num = (short)483328018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.DEPOT)
						{
							num = (short)574423055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)241932900;
						short num4 = num;
						num = (short)1578670692;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_85;
						default:
							num = (short)1056112640;
							if (num != 0)
							{
							}
							num = (short)1467678722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						global::AcpCommonLib.AppInfoManager.AppView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						num = (short)591527941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.AppMode = value;
						num = (short)2083127312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (global::AcpCommonLib.AppInfoManager.e == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)716046337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					}
					goto IL_7E;
					IL_85:
					num = (short)1993211921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E:
					if (value == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_85;
					}
					goto IL_21E;
					IL_153:
					global::AcpCommonLib.AppInfoManager.e = value;
					num = (short)411303940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B4:
					num = (short)1951072277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					num = (short)486670343;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003A88 File Offset: 0x00001C88
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003B38 File Offset: 0x00001D38
		public static bool AppHideMatches
		{
			get
			{
				short num = (short)2098498124;
				short num2 = num;
				num = (short)1524468300;
				switch (num2 == num)
				{
				}
				num = (short)1401749505;
				if (num != 0)
				{
				}
				num = (short)957808640;
				if (num != 0)
				{
				}
				num = (short)441384960;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.g;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						num2 = (short)116785153;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num2 = (short)1774190594;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.AppHideMatches = value;
						num2 = (short)183497830;
						short num3 = num2;
						num2 = (short)502002790;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)577568768;
							short num4 = num2;
							num2 = (short)336592896;
							if (num2 != 0)
							{
							}
							num2 = (short)1673134080;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				global::AcpCommonLib.AppInfoManager.g = value;
				num2 = (short)684720129;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003C5C File Offset: 0x00001E5C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00003D0C File Offset: 0x00001F0C
		public static bool ShowRtdButtons
		{
			get
			{
				short num = (short)439880158;
				short num2 = num;
				num = (short)956697054;
				switch (num2 == num)
				{
				}
				num = (short)930152449;
				if (num != 0)
				{
				}
				num = (short)1499070464;
				if (num != 0)
				{
				}
				num = (short)881983488;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.h;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_F0;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num2 = (short)2065498114;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F2;
					case 2:
					{
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.ShowRtdButtons = value;
						num2 = (short)1566254423;
						short num3 = num2;
						num2 = (short)1678124375;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F2;
						default:
						{
							num2 = (short)1432223744;
							if (num2 != 0)
							{
							}
							num2 = (short)275251200;
							short num4 = num2;
							num2 = (short)1849491456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				IL_F0:
				IL_F2:
				num2 = (short)692453377;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				global::AcpCommonLib.AppInfoManager.h = value;
				num2 = (short)1300955137;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003EE4 File Offset: 0x000020E4
		public static bool ClonePageNotLoaded
		{
			get
			{
				short num = (short)2112019862;
				short num2 = num;
				num = (short)228056470;
				switch (num2 == num)
				{
				}
				num = (short)1405943809;
				if (num != 0)
				{
				}
				num = (short)1309147136;
				if (num != 0)
				{
				}
				num = (short)2100363264;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.i;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num2 = (short)1952251906;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.ClonePageNotLoaded = value;
						num2 = (short)693334831;
						short num3 = num2;
						num2 = (short)1166504751;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)1211236353;
							if (num2 != 0)
							{
							}
							num2 = (short)268173312;
							short num4 = num2;
							num2 = (short)1075576832;
							if (num2 != 0)
							{
							}
							num2 = (short)473694208;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				global::AcpCommonLib.AppInfoManager.i = value;
				num2 = (short)87162881;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000400C File Offset: 0x0000220C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000040BC File Offset: 0x000022BC
		public static bool DndOperationCompleted
		{
			get
			{
				short num = (short)2071976709;
				short num2 = num;
				num = (short)321968901;
				switch (num2 == num)
				{
				}
				num = (short)1922236417;
				if (num != 0)
				{
				}
				num = (short)1113522176;
				if (num != 0)
				{
				}
				num = (short)1066336256;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.j;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num2 = (short)1414922242;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.DndOperationCompleted = value;
						num2 = (short)1500116088;
						short num3 = num2;
						num2 = (short)508097656;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)1086455809;
							if (num2 != 0)
							{
							}
							num2 = (short)370278400;
							short num4 = num2;
							num2 = (short)1580793856;
							if (num2 != 0)
							{
							}
							num2 = (short)319356928;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				global::AcpCommonLib.AppInfoManager.j = value;
				num2 = (short)742326273;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000041DC File Offset: 0x000023DC
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000428C File Offset: 0x0000248C
		public static bool ImportOperationCompleted
		{
			get
			{
				short num = (short)1007362578;
				short num2 = num;
				num = (short)1115628050;
				switch (num2 == num)
				{
				}
				num = (short)1507328000;
				if (num != 0)
				{
				}
				num = (short)2103640065;
				if (num != 0)
				{
				}
				num = (short)371195904;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.k;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppInfoHelper != null)
						{
							num2 = (short)638451714;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						global::AcpCommonLib.AppInfoManager.AppInfoHelper.ImportOperationCompleted = value;
						num2 = (short)692629573;
						short num3 = num2;
						num2 = (short)332247109;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)186515456;
							short num4 = num2;
							num2 = (short)613613568;
							if (num2 != 0)
							{
							}
							num2 = (short)81723392;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				num2 = (short)508493825;
				if (num2 != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.k = value;
				num2 = (short)1314455553;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000043B0 File Offset: 0x000025B0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00004460 File Offset: 0x00002660
		public static global::AcpCommonLib.DragDropVersionManager DndVersionManager
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2140428376;
				short num2 = num;
				num = (short)1966954584;
				switch (num2 == num)
				{
				}
				num = (short)877461504;
				if (num != 0)
				{
				}
				num = (short)1272184833;
				if (num != 0)
				{
				}
				num = (short)286916608;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1163657217;
				if (num != 0)
				{
				}
				num = (short)1745722015;
				short num2 = num;
				num = (short)58563231;
				switch (num2 == num)
				{
				}
				num = (short)448331776;
				if (num != 0)
				{
				}
				num = (short)1997668352;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.l = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00004510 File Offset: 0x00002710
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000045C0 File Offset: 0x000027C0
		public static string AppVersion
		{
			get
			{
				short num = (short)651158216;
				short num2 = num;
				num = (short)1184883400;
				switch (num2 == num)
				{
				}
				num = (short)529268737;
				if (num != 0)
				{
				}
				num = (short)725221376;
				if (num != 0)
				{
				}
				num = (short)541130752;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.m;
			}
			set
			{
				short num = (short)417259934;
				short num2 = num;
				num = (short)1992221086;
				switch (num2 == num)
				{
				}
				num = (short)236716033;
				if (num != 0)
				{
				}
				num = (short)940244992;
				if (num != 0)
				{
				}
				num = (short)1737883648;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.m = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000466C File Offset: 0x0000286C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000471C File Offset: 0x0000291C
		public static int ProducerVersion
		{
			get
			{
				short num = (short)258227975;
				short num2 = num;
				num = (short)2003517191;
				switch (num2 == num)
				{
				}
				num = (short)1189543937;
				if (num != 0)
				{
				}
				num = (short)1425080320;
				if (num != 0)
				{
				}
				num = (short)1109065728;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.n;
			}
			set
			{
				short num = (short)1445155211;
				short num2 = num;
				num = (short)2023182731;
				switch (num2 == num)
				{
				}
				num = (short)660733953;
				if (num != 0)
				{
				}
				num = (short)902234112;
				if (num != 0)
				{
				}
				num = (short)661848064;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.n = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000047CC File Offset: 0x000029CC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000487C File Offset: 0x00002A7C
		public static string CodeplugVersion
		{
			get
			{
				short num = (short)1687027713;
				if (num != 0)
				{
				}
				num = (short)1925524714;
				short num2 = num;
				num = (short)435891434;
				switch (num2 == num)
				{
				}
				num = (short)301465600;
				if (num != 0)
				{
				}
				num = (short)1718943744;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.o;
			}
			set
			{
				short num = (short)602144769;
				if (num != 0)
				{
				}
				num = (short)1986156264;
				short num2 = num;
				num = (short)1117017832;
				switch (num2 == num)
				{
				}
				num = (short)1752432640;
				if (num != 0)
				{
				}
				num = (short)350617600;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.o = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000492C File Offset: 0x00002B2C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000049DC File Offset: 0x00002BDC
		public static bool IsOldCodeplug
		{
			get
			{
				short num = (short)1342242817;
				if (num != 0)
				{
				}
				num = (short)969148810;
				short num2 = num;
				num = (short)1626933642;
				switch (num2 == num)
				{
				}
				num = (short)832372736;
				if (num != 0)
				{
				}
				num = (short)1337655296;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.p;
			}
			set
			{
				short num = (short)675895536;
				short num2 = num;
				num = (short)409032944;
				switch (num2 == num)
				{
				}
				num = (short)711852033;
				if (num != 0)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				num = (short)1333198848;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.p = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004A88 File Offset: 0x00002C88
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004B34 File Offset: 0x00002D34
		public static string ReportsLangSelection
		{
			get
			{
				short num = (short)979286366;
				short num2 = num;
				num = (short)2136193374;
				switch (num2 == num)
				{
				}
				num = (short)1066598400;
				if (num != 0)
				{
				}
				num = (short)1737359361;
				if (num != 0)
				{
				}
				num = (short)900792320;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.q;
			}
			set
			{
				short num = (short)367853569;
				if (num != 0)
				{
				}
				num = (short)302482009;
				short num2 = num;
				num = (short)563380825;
				switch (num2 == num)
				{
				}
				num = (short)1628766208;
				if (num != 0)
				{
				}
				num = (short)1300496384;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.q = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004BE4 File Offset: 0x00002DE4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004C90 File Offset: 0x00002E90
		public static bool NonEngOldCodeplug
		{
			get
			{
				short num = (short)511225983;
				short num2 = num;
				num = (short)144945279;
				switch (num2 == num)
				{
				}
				num = (short)933167104;
				if (num != 0)
				{
				}
				num = (short)1531510785;
				if (num != 0)
				{
				}
				num = (short)647430144;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.r;
			}
			set
			{
				short num = (short)350804458;
				short num2 = num;
				num = (short)1676859882;
				switch (num2 == num)
				{
				}
				num = (short)305594369;
				if (num != 0)
				{
				}
				num = (short)1054539776;
				if (num != 0)
				{
				}
				num = (short)1763639296;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.r = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004D40 File Offset: 0x00002F40
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004DEC File Offset: 0x00002FEC
		public static bool IsCustomViewLanguageMismatch
		{
			get
			{
				short num = (short)1485482484;
				short num2 = num;
				num = (short)1372432884;
				switch (num2 == num)
				{
				}
				num = (short)566034433;
				if (num != 0)
				{
				}
				num = (short)1940127744;
				if (num != 0)
				{
				}
				num = (short)120127488;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.s;
			}
			set
			{
				short num = (short)1704650444;
				short num2 = num;
				num = (short)1157621452;
				switch (num2 == num)
				{
				}
				num = (short)2104754177;
				if (num != 0)
				{
				}
				num = (short)204275712;
				if (num != 0)
				{
				}
				num = (short)1047658496;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.s = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004E9C File Offset: 0x0000309C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00004F50 File Offset: 0x00003150
		public static global::AcpCommonLib.Document ComparatorDocument
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1886698980;
				short num2 = num;
				num = (short)1877327332;
				switch (num2 == num)
				{
				}
				num = (short)100597760;
				if (num != 0)
				{
				}
				num = (short)804323328;
				short num3 = num;
				num = (short)1263927297;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.t;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1127570513;
				short num2 = num;
				num = (short)985160785;
				switch (num2 == num)
				{
				}
				num = (short)988086272;
				if (num != 0)
				{
				}
				num = (short)354484224;
				short num3 = num;
				num = (short)1045889025;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.t = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00005000 File Offset: 0x00003200
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000050B0 File Offset: 0x000032B0
		public static global::AcpCommonLib.Document DefaultDocument
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1877853853;
				short num2 = num;
				num = (short)592627357;
				switch (num2 == num)
				{
				}
				num = (short)1114374144;
				if (num != 0)
				{
				}
				num = (short)19398656;
				short num3 = num;
				num = (short)167968769;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)990132376;
				short num2 = num;
				num = (short)112801944;
				switch (num2 == num)
				{
				}
				num = (short)215285760;
				if (num != 0)
				{
				}
				num = (short)946929664;
				short num3 = num;
				num = (short)1308491777;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.u = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005160 File Offset: 0x00003360
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005210 File Offset: 0x00003410
		public static global::AcpCommonLib.ApplicationType AppType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1355270047;
				short num2 = num;
				num = (short)377603999;
				switch (num2 == num)
				{
				}
				num = (short)1741750273;
				if (num != 0)
				{
				}
				num = (short)1274281984;
				short num3 = num;
				num = (short)1947402240;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)125610735;
				short num2 = num;
				num = (short)146320111;
				switch (num2 == num)
				{
				}
				num = (short)437911553;
				if (num != 0)
				{
				}
				num = (short)979435520;
				short num3 = num;
				num = (short)160628736;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.v = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000052C0 File Offset: 0x000034C0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000536C File Offset: 0x0000356C
		public static global::AcpCommonLib.DifferentiatedUserViewType CustomViewBaseView
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)73622712;
				short num2 = num;
				num = (short)2113561784;
				switch (num2 == num)
				{
				}
				num = (short)1768292352;
				if (num != 0)
				{
				}
				num = (short)1112473600;
				short num3 = num;
				num = (short)1440415745;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2116588743;
				short num2 = num;
				num = (short)676041927;
				switch (num2 == num)
				{
				}
				num = (short)1981546497;
				if (num != 0)
				{
				}
				num = (short)1178009600;
				short num3 = num;
				num = (short)2114781184;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.w = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00005418 File Offset: 0x00003618
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000054C8 File Offset: 0x000036C8
		public static int GuiVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)281421911;
				short num2 = num;
				num = (short)1942956119;
				switch (num2 == num)
				{
				}
				num = (short)113442817;
				if (num != 0)
				{
				}
				num = (short)2046689280;
				short num3 = num;
				num = (short)1462960128;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.x;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)650822065;
				short num2 = num;
				num = (short)283492785;
				switch (num2 == num)
				{
				}
				num = (short)677642241;
				if (num != 0)
				{
				}
				num = (short)404160512;
				short num3 = num;
				num = (short)18415616;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.x = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000557C File Offset: 0x0000377C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005628 File Offset: 0x00003828
		public static bool DndOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)572249528;
				short num2 = num;
				num = (short)114677176;
				switch (num2 == num)
				{
				}
				num = (short)1807745025;
				if (num != 0)
				{
				}
				num = (short)1991442432;
				short num3 = num;
				num = (short)1500577792;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.y;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1351395686;
				short num2 = num;
				num = (short)1915529574;
				switch (num2 == num)
				{
				}
				num = (short)1949499392;
				if (num != 0)
				{
				}
				num = (short)150470656;
				short num3 = num;
				num = (short)1280770049;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.y = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000056D8 File Offset: 0x000038D8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005788 File Offset: 0x00003988
		public static bool DragOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1221722113;
				if (num != 0)
				{
				}
				num = (short)717947948;
				short num2 = num;
				num = (short)1139147820;
				switch (num2 == num)
				{
				}
				num = (short)1985282048;
				short num3 = num;
				num = (short)11468800;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.z;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)628411718;
				short num2 = num;
				num = (short)683265350;
				switch (num2 == num)
				{
				}
				num = (short)1102839809;
				if (num != 0)
				{
				}
				num = (short)900595712;
				short num3 = num;
				num = (short)830210048;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.z = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005838 File Offset: 0x00003A38
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000058E4 File Offset: 0x00003AE4
		public static bool DropOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1588111278;
				short num2 = num;
				num = (short)743745454;
				switch (num2 == num)
				{
				}
				num = (short)2076966912;
				if (num != 0)
				{
				}
				num = (short)1621032960;
				short num3 = num;
				num = (short)1618083841;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.aa;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)739704833;
				if (num != 0)
				{
				}
				num = (short)1574762335;
				short num2 = num;
				num = (short)806221663;
				switch (num2 == num)
				{
				}
				num = (short)1355153408;
				short num3 = num;
				num = (short)1538129920;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.aa = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00005994 File Offset: 0x00003B94
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005A44 File Offset: 0x00003C44
		public static bool SkipValueSetter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1071162039;
				short num2 = num;
				num = (short)754623159;
				switch (num2 == num)
				{
				}
				num = (short)1483014145;
				if (num != 0)
				{
				}
				num = (short)2121662464;
				short num3 = num;
				num = (short)1561395200;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ab;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1010759650;
				short num2 = num;
				num = (short)353236962;
				switch (num2 == num)
				{
				}
				num = (short)288686080;
				if (num != 0)
				{
				}
				num = (short)755695616;
				short num3 = num;
				num = (short)1300561921;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ab = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005AF4 File Offset: 0x00003CF4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public static bool BackgroundDeserializeOpertaion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2082546465;
				short num2 = num;
				num = (short)1365779233;
				switch (num2 == num)
				{
				}
				num = (short)1106247681;
				if (num != 0)
				{
				}
				num = (short)172163072;
				short num3 = num;
				num = (short)681902080;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ac;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1053526420;
				short num2 = num;
				num = (short)1756727700;
				switch (num2 == num)
				{
				}
				num = (short)930873344;
				if (num != 0)
				{
				}
				num = (short)1750138880;
				short num3 = num;
				num = (short)746651649;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ac = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005C58 File Offset: 0x00003E58
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005D04 File Offset: 0x00003F04
		public static bool LoadingVoiceData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1033703450;
				short num2 = num;
				num = (short)1823346714;
				switch (num2 == num)
				{
				}
				num = (short)1547370497;
				if (num != 0)
				{
				}
				num = (short)1793523712;
				short num3 = num;
				num = (short)915865600;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ad;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)199735551;
				short num2 = num;
				num = (short)1731508479;
				switch (num2 == num)
				{
				}
				num = (short)1240399872;
				if (num != 0)
				{
				}
				num = (short)628752384;
				short num3 = num;
				num = (short)771620865;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ad = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public static bool CurrentModeSupportsUndo
		{
			get
			{
				short num = (short)468058112;
				short num2 = num;
				num = (short)1775435777;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
				{
					for (;;)
					{
						num = (short)225068216;
						short num3 = num;
						num = (short)1117603000;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_90;
						}
					}
					IL_90:
					num = (short)257359872;
					if (num != 0)
					{
					}
					return global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode;
				}
				return true;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005E74 File Offset: 0x00004074
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00005F20 File Offset: 0x00004120
		public static global::AcpCommonLib.FieldsReport.FieldsReportManager InvalidFieldsReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1676743094;
				short num2 = num;
				num = (short)1387991478;
				switch (num2 == num)
				{
				}
				num = (short)2052063232;
				if (num != 0)
				{
				}
				num = (short)950337536;
				short num3 = num;
				num = (short)122028033;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ae;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)471889744;
				short num2 = num;
				num = (short)939882320;
				switch (num2 == num)
				{
				}
				num = (short)1823866881;
				if (num != 0)
				{
				}
				num = (short)1077936128;
				short num3 = num;
				num = (short)1409024000;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ae = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005FD0 File Offset: 0x000041D0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000607C File Offset: 0x0000427C
		public static global::AcpCommonLib.FieldsReport.FieldsReportManager ComparatorFieldsReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1313334679;
				short num2 = num;
				num = (short)1955849623;
				switch (num2 == num)
				{
				}
				num = (short)1726349313;
				if (num != 0)
				{
				}
				num = (short)1582235648;
				short num3 = num;
				num = (short)1985609728;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.af;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)967507969;
				if (num != 0)
				{
				}
				num = (short)2029568429;
				short num2 = num;
				num = (short)382321069;
				switch (num2 == num)
				{
				}
				num = (short)1870987264;
				short num3 = num;
				num = (short)1751187456;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.af = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000612C File Offset: 0x0000432C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000061DC File Offset: 0x000043DC
		public static global::AcpCommonLib.FieldsReport.FieldsReportManager DragAndDropFieldsReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1485441231;
				short num2 = num;
				num = (short)471140559;
				switch (num2 == num)
				{
				}
				num = (short)951713792;
				if (num != 0)
				{
				}
				num = (short)110624768;
				short num3 = num;
				num = (short)1939472385;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ag;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)138084353;
				if (num != 0)
				{
				}
				num = (short)1112531206;
				short num2 = num;
				num = (short)873455878;
				switch (num2 == num)
				{
				}
				num = (short)330432512;
				short num3 = num;
				num = (short)1185087488;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ag = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000628C File Offset: 0x0000448C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00006338 File Offset: 0x00004538
		public static global::AcpCommonLib.FieldsReport.FieldsReportManager FillUpFillDownFieldsReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1095108595;
				short num2 = num;
				num = (short)458033139;
				switch (num2 == num)
				{
				}
				num = (short)2103771137;
				if (num != 0)
				{
				}
				num = (short)1394868224;
				short num3 = num;
				num = (short)1077673984;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ah;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)155861990;
				short num2 = num;
				num = (short)894387174;
				switch (num2 == num)
				{
				}
				num = (short)47120385;
				if (num != 0)
				{
				}
				num = (short)1816264704;
				short num3 = num;
				num = (short)1036451840;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ah = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000063E4 File Offset: 0x000045E4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00006494 File Offset: 0x00004694
		public static global::AcpCommonLib.FieldsReport.FieldsReportManager ImportExportFieldsReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1138753537;
				if (num != 0)
				{
				}
				num = (short)204091379;
				short num2 = num;
				num = (short)1249062899;
				switch (num2 == num)
				{
				}
				num = (short)313065472;
				short num3 = num;
				num = (short)433455104;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ai;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1283292003;
				short num2 = num;
				num = (short)1157397347;
				switch (num2 == num)
				{
				}
				num = (short)1974796289;
				if (num != 0)
				{
				}
				num = (short)1722286080;
				short num3 = num;
				num = (short)789446656;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ai = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000065F0 File Offset: 0x000047F0
		public static global::AcpCommonLib.StatusMessage.StatusMessagesManager StatusMsgReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1208219337;
				short num2 = num;
				num = (short)1548547785;
				switch (num2 == num)
				{
				}
				num = (short)1726808064;
				if (num != 0)
				{
				}
				num = (short)110428160;
				short num3 = num;
				num = (short)1694826497;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.aj;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)509588811;
				short num2 = num;
				num = (short)1669641547;
				switch (num2 == num)
				{
				}
				num = (short)1952645120;
				if (num != 0)
				{
				}
				num = (short)585170944;
				short num3 = num;
				num = (short)1527447553;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.aj = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000669C File Offset: 0x0000489C
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000674C File Offset: 0x0000494C
		public static global::AcpCommonLib.FindResult.FindResultsManager FindResultReport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)649363124;
				short num2 = num;
				num = (short)1327070900;
				switch (num2 == num)
				{
				}
				num = (short)1713045505;
				if (num != 0)
				{
				}
				num = (short)343867392;
				short num3 = num;
				num = (short)1759313920;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ak;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)195636698;
				short num2 = num;
				num = (short)1389702618;
				switch (num2 == num)
				{
				}
				num = (short)666107904;
				if (num != 0)
				{
				}
				num = (short)702873600;
				short num3 = num;
				num = (short)1095499777;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ak = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00006800 File Offset: 0x00004A00
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000068AC File Offset: 0x00004AAC
		public static bool DataTransferAppendRecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)37748737;
				if (num != 0)
				{
				}
				num = (short)1046473081;
				short num2 = num;
				num = (short)428861817;
				switch (num2 == num)
				{
				}
				num = (short)450232320;
				short num3 = num;
				num = (short)964493312;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.al;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)951380134;
				short num2 = num;
				num = (short)2140727462;
				switch (num2 == num)
				{
				}
				num = (short)1435500544;
				if (num != 0)
				{
				}
				num = (short)1123811328;
				short num3 = num;
				num = (short)586940417;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.al = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000695C File Offset: 0x00004B5C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00006A08 File Offset: 0x00004C08
		public static bool ClearNavigationHistory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)396143976;
				short num2 = num;
				num = (short)953527656;
				switch (num2 == num)
				{
				}
				num = (short)780468224;
				if (num != 0)
				{
				}
				num = (short)898629632;
				short num3 = num;
				num = (short)1252786177;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.am;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1459945473;
				if (num != 0)
				{
				}
				num = (short)195442151;
				short num2 = num;
				num = (short)1975858663;
				switch (num2 == num)
				{
				}
				num = (short)1889992704;
				short num3 = num;
				num = (short)148701184;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.am = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00006AB4 File Offset: 0x00004CB4
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00006B64 File Offset: 0x00004D64
		public static bool InitializingDefaultDoc
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)969559552;
				short num2 = num;
				num = (short)777145856;
				switch (num2 == num)
				{
				}
				num = (short)1416691713;
				if (num != 0)
				{
				}
				num = (short)1535836160;
				short num3 = num;
				num = (short)1582891008;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.an;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)912439623;
				short num2 = num;
				num = (short)1007270215;
				switch (num2 == num)
				{
				}
				num = (short)973864961;
				if (num != 0)
				{
				}
				num = (short)121307136;
				short num3 = num;
				num = (short)1571487744;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.an = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006C18 File Offset: 0x00004E18
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public static bool UndoRedoInProgress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1646755158;
				short num2 = num;
				num = (short)1102019926;
				switch (num2 == num)
				{
				}
				num = (short)425000961;
				if (num != 0)
				{
				}
				num = (short)1634467840;
				short num3 = num;
				num = (short)637861888;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ao;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)818772947;
				short num2 = num;
				num = (short)1645378515;
				switch (num2 == num)
				{
				}
				num = (short)1247543296;
				if (num != 0)
				{
				}
				num = (short)830734336;
				short num3 = num;
				num = (short)238157825;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ao = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00006D74 File Offset: 0x00004F74
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00006E24 File Offset: 0x00005024
		public static bool AddDefaultRecord
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1920532481;
				if (num != 0)
				{
				}
				num = (short)43090819;
				short num2 = num;
				num = (short)812614531;
				switch (num2 == num)
				{
				}
				num = (short)253820928;
				short num3 = num;
				num = (short)1654063104;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ap;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1475936257;
				if (num != 0)
				{
				}
				num = (short)1528844987;
				short num2 = num;
				num = (short)591090363;
				switch (num2 == num)
				{
				}
				num = (short)1860698112;
				short num3 = num;
				num = (short)1477967872;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ap = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00006ED4 File Offset: 0x000050D4
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00006F84 File Offset: 0x00005184
		public static bool ImportCopyOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1000094787;
				short num2 = num;
				num = (short)110312515;
				switch (num2 == num)
				{
				}
				num = (short)1038942209;
				if (num != 0)
				{
				}
				num = (short)832438272;
				short num3 = num;
				num = (short)58523648;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.aq;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)517976385;
				short num2 = num;
				num = (short)1319022913;
				switch (num2 == num)
				{
				}
				num = (short)921567233;
				if (num != 0)
				{
				}
				num = (short)311361536;
				short num3 = num;
				num = (short)1429405696;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.aq = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00007034 File Offset: 0x00005234
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000070E0 File Offset: 0x000052E0
		public static bool UnpackOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)27705855;
				short num2 = num;
				num = (short)1041482239;
				switch (num2 == num)
				{
				}
				num = (short)1218772993;
				if (num != 0)
				{
				}
				num = (short)286916608;
				short num3 = num;
				num = (short)465960960;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.ar;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)52354978;
				short num2 = num;
				num = (short)60809122;
				switch (num2 == num)
				{
				}
				num = (short)1242169345;
				if (num != 0)
				{
				}
				num = (short)202702848;
				short num3 = num;
				num = (short)1762525184;
				if (num != 0)
				{
				}
				global::AcpCommonLib.AppInfoManager.ar = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007190 File Offset: 0x00005390
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00007240 File Offset: 0x00005440
		public static bool PackOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)731381761;
				if (num != 0)
				{
				}
				num = (short)574273693;
				short num2 = num;
				num = (short)777566365;
				switch (num2 == num)
				{
				}
				num = (short)735838208;
				short num3 = num;
				num = (short)1502150656;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.AppInfoManager.@as;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)10532552;
				short num2 = num;
				num = (short)108050120;
				switch (num2 == num)
				{
				}
				num = (short)805109761;
				if (num != 0)
				{
				}
				num = (short)1479213056;
				if (num != 0)
				{
				}
				num = (short)1377566720;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.@as = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000072EC File Offset: 0x000054EC
		public static bool DndOrImportOperation
		{
			get
			{
				short num;
				while (global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					num = (short)2080514144;
					short num2 = num;
					num = (short)939270240;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1398472705;
						if (num != 0)
						{
						}
						num = (short)423100416;
						if (num != 0)
						{
						}
						return true;
					}
				}
				num = (short)382337024;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.ImportCopyOperation;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000073A4 File Offset: 0x000055A4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00007454 File Offset: 0x00005654
		public static bool AddCopyOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2136145921;
				if (num != 0)
				{
				}
				num = (short)2034816690;
				short num2 = num;
				num = (short)492754610;
				switch (num2 == num)
				{
				}
				num = (short)1857748992;
				if (num != 0)
				{
				}
				num = (short)1013841920;
				short num3 = num;
				return global::AcpCommonLib.AppInfoManager.at;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1510868197;
				short num2 = num;
				num = (short)999687397;
				switch (num2 == num)
				{
				}
				num = (short)161021952;
				if (num != 0)
				{
				}
				num = (short)1111359489;
				if (num != 0)
				{
				}
				num = (short)1462042624;
				short num3 = num;
				global::AcpCommonLib.AppInfoManager.at = value;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007504 File Offset: 0x00005704
		public static bool RegisterLegacyUIName(string internalName, string legacyName)
		{
			short num = (short)425066496;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_9E;
				case 2:
					goto IL_EF;
				}
				IL_30:
				num = (short)2103383960;
				short num3 = num;
				num = (short)2130581400;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_9E:
					global::AcpCommonLib.AppInfoManager.au[internalName] = new global::System.Collections.Generic.SortedSet<string>();
					num = (short)811270145;
					if (num != 0)
					{
					}
					num = (short)2139291650;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)124190720;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.au.ContainsKey(internalName))
					{
						goto IL_11A;
					}
					num = (short)1355677697;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EF:
			num = (short)2009071616;
			short num4 = num;
			IL_11A:
			return global::AcpCommonLib.AppInfoManager.au[internalName].Add(legacyName);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000763C File Offset: 0x0000583C
		public static global::System.Collections.Generic.IEnumerable<string> GetLegacyUINames(string internalName)
		{
			short num = (short)906867943;
			short num2 = num;
			num = (short)929412327;
			switch (num2 == num)
			{
			}
			num = (short)455278592;
			if (num != 0)
			{
			}
			num = (short)810090497;
			if (num != 0)
			{
			}
			num = (short)1158086656;
			short num3 = num;
			global::AcpCommonLib.AppInfoManager.a a = new global::AcpCommonLib.AppInfoManager.a(-2);
			a.e = internalName;
			return a;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000076F0 File Offset: 0x000058F0
		public static global::System.Collections.Generic.IEnumerable<string> GetInternalNamesByUIName(string uiName)
		{
			short num = (short)1609810248;
			short num2 = num;
			num = (short)674283848;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2002649088;
				short num3 = num;
				num = (short)1362886656;
				if (num != 0)
				{
				}
				num = (short)208076801;
				if (num != 0)
				{
				}
				num = (short)480116736;
				switch (num)
				{
				}
				break;
			}
			}
			global::System.Collections.Generic.SortedSet<string> sortedSet = new global::System.Collections.Generic.SortedSet<string>();
			using (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.SortedSet<string>>.Enumerator enumerator = global::AcpCommonLib.AppInfoManager.au.GetEnumerator())
			{
				num = (short)562167810;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_29C;
					case 1:
						try
						{
							num = (short)925433860;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									num = (short)511049731;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.SortedSet<string>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)343146496;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)577634306;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Collections.Generic.SortedSet<string>.Enumerator enumerator2;
									if (enumerator2.Current.Equals(uiName))
									{
										num = (short)1206583302;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_271;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1B4;
									}
									continue;
								case 5:
									goto IL_20E;
								case 6:
								{
									global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.SortedSet<string>> keyValuePair;
									sortedSet.Add(keyValuePair.Key);
									num = (short)1615724549;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1B6:
								num = (short)394067969;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B4:
								goto IL_1B6;
							}
							IL_20E:
							IL_271:
							break;
						}
						finally
						{
							global::System.Collections.Generic.SortedSet<string>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_284;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_106;
						}
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)869138436;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.SortedSet<string>> keyValuePair = enumerator.Current;
						global::System.Collections.Generic.SortedSet<string>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator();
						num = (short)942800897;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_284;
					}
					IL_136:
					num = (short)1737162755;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_106:
					goto IL_136;
					IL_284:
					num = (short)695009280;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_29C:;
			}
			return sortedSet;
		}

		// Token: 0x04000004 RID: 4
		public static int LOCALIZED_VERSION_NUMBER;

		// Token: 0x04000005 RID: 5
		private static global::AcpCommonLib.AcpAppInfoHelper a;

		// Token: 0x04000006 RID: 6
		private static global::AcpCommonLib.DifferentiatedUserViewType b;

		// Token: 0x04000007 RID: 7
		private static global::AcpCommonLib.UndoRedo.ContainerTask c;

		// Token: 0x04000008 RID: 8
		private static global::System.Collections.Generic.List<global::System.Type> d;

		// Token: 0x04000009 RID: 9
		private static global::AcpCommonLib.ApplicationMode e;

		// Token: 0x0400000A RID: 10
		private static global::AcpCommonLib.DifferentiatedUserViewType f;

		// Token: 0x0400000B RID: 11
		private static bool g;

		// Token: 0x0400000C RID: 12
		private static bool h;

		// Token: 0x0400000D RID: 13
		private static bool i;

		// Token: 0x0400000E RID: 14
		private static bool j;

		// Token: 0x0400000F RID: 15
		private static bool k;

		// Token: 0x04000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.DragDropVersionManager l;

		// Token: 0x04000011 RID: 17
		private static string m;

		// Token: 0x04000012 RID: 18
		private static int n;

		// Token: 0x04000013 RID: 19
		private static string o;

		// Token: 0x04000014 RID: 20
		private static bool p;

		// Token: 0x04000015 RID: 21
		private static string q;

		// Token: 0x04000016 RID: 22
		private static bool r;

		// Token: 0x04000017 RID: 23
		private static bool s;

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.Document t;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.Document u;

		// Token: 0x0400001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.ApplicationType v;

		// Token: 0x0400001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.DifferentiatedUserViewType w;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static int x;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool y;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool z;

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool aa;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool ab;

		// Token: 0x04000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool ac;

		// Token: 0x04000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool ad;

		// Token: 0x04000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FieldsReport.FieldsReportManager ae;

		// Token: 0x04000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FieldsReport.FieldsReportManager af;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FieldsReport.FieldsReportManager ag;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FieldsReport.FieldsReportManager ah;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FieldsReport.FieldsReportManager ai;

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.StatusMessage.StatusMessagesManager aj;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FindResult.FindResultsManager ak;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool al;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool am;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool an;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool ao;

		// Token: 0x0400002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool ap;

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool aq;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool ar;

		// Token: 0x04000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool @as;

		// Token: 0x04000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool at;

		// Token: 0x04000033 RID: 51
		private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.SortedSet<string>> au;
	}
}
