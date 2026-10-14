using System;
using System.Collections.Generic;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace AcpUI
{
	// Token: 0x02000015 RID: 21
	public static class AcpExpStatusManager
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0001723C File Offset: 0x0001543C
		static AcpExpStatusManager()
		{
			short num = (short)354613206;
			short num2 = num;
			num = (short)1932654550;
			switch (num2 == num)
			{
			}
			num = (short)1184366592;
			short num3 = num;
			num = (short)1510539264;
			if (num != 0)
			{
			}
			num = (short)345243649;
			if (num != 0)
			{
			}
			global::AcpUI.AcpExpStatusManager.a = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>>();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000172F0 File Offset: 0x000154F0
		public static void Add(int nodeId, global::AcpUI.AcpExpander expander)
		{
			short num = (short)910753792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<int> list;
				global::AcpBusinessLayer.FeatureSection featureSection;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 1:
					goto IL_15A;
				case 2:
					return;
				case 3:
					list = new global::System.Collections.Generic.List<int>();
					num = (short)1838022657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_131;
				case 5:
					num = (short)577896455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					global::AcpUI.AcpExpStatusManager.a.Add(nodeId, list);
					num = (short)201129988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (list.Count == 0)
					{
						goto IL_23D;
					}
					goto IL_131;
				case 8:
				{
					num = (short)810811392;
					short num3 = num;
					if (!list.Contains(featureSection.FeatureSectionId))
					{
						num = (short)844824581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 9:
					num = (short)420020232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)292642357;
					short num4 = num;
					num = (short)956718645;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23D;
					default:
						num = (short)1613561857;
						if (num != 0)
						{
						}
						num = (short)1404698624;
						if (num != 0)
						{
						}
						if (featureSection != null)
						{
							num = (short)1088552969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				}
				IL_51:
				if (!global::AcpUI.AcpExpStatusManager.a.TryGetValue(nodeId, out list))
				{
					num = (short)453509123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_15A;
				IL_131:
				list.Add(featureSection.FeatureSectionId);
				num = (short)974585858;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15A:
				featureSection = global::AcpUI.AcpExpStatusManager.a(global::AcpUI.AcpExpStatusManager.a(expander), expander.Header as string);
				num = (short)1204551690;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23D:
				num = (short)1216217094;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00017558 File Offset: 0x00015758
		public static void Remove(int nodeId)
		{
			short num = (short)217809248;
			short num2 = num;
			num = (short)1615167840;
			switch (num2 == num)
			{
			}
			num = (short)1594425344;
			if (num != 0)
			{
			}
			num = (short)1069416449;
			if (num != 0)
			{
			}
			num = (short)628359168;
			short num3 = num;
			global::AcpUI.AcpExpStatusManager.a.Remove(nodeId);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001760C File Offset: 0x0001580C
		public static void Remove(int nodeId, global::AcpUI.AcpExpander expander)
		{
			short num = (short)1774125063;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<int> list;
				switch (num2)
				{
				case 0:
					goto IL_1AF;
				case 1:
				{
					global::AcpBusinessLayer.FeatureSection featureSection = global::AcpUI.AcpExpStatusManager.a(global::AcpUI.AcpExpStatusManager.a(expander), expander.Header as string);
					num = (short)447414274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::AcpBusinessLayer.FeatureSection featureSection;
					if (featureSection != null)
					{
						num = (short)1111031812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				}
				case 3:
					if (list.Count == 0)
					{
						num = (short)1534263301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B1;
				case 4:
				{
					global::AcpBusinessLayer.FeatureSection featureSection;
					list.Remove(featureSection.FeatureSectionId);
					num = (short)157679622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::AcpUI.AcpExpStatusManager.Remove(nodeId);
					num = (short)68612389;
					short num3 = num;
					num = (short)1426321701;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1011220480;
						if (num != 0)
						{
						}
						num = (short)2095316992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_95;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				if (global::AcpUI.AcpExpStatusManager.a.TryGetValue(nodeId, out list))
				{
					num = (short)2024734720;
					short num4 = num;
					num = (short)710279169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_95:
				num = (short)398983171;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1AF:
			IL_1B1:
			num = (short)834338817;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000177F4 File Offset: 0x000159F4
		public static void Clear()
		{
			short num = (short)1660463044;
			short num2 = num;
			num = (short)1081714628;
			switch (num2 == num)
			{
			}
			num = (short)114688001;
			if (num != 0)
			{
			}
			num = (short)1730871296;
			if (num != 0)
			{
			}
			num = (short)953942016;
			short num3 = num;
			global::AcpUI.AcpExpStatusManager.a.Clear();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000178A8 File Offset: 0x00015AA8
		public static bool Contains(int nodeId, global::AcpUI.AcpExpander expander)
		{
			short num = (short)571211779;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.FeatureSection featureSection;
			global::System.Collections.Generic.List<int> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)733262024;
					short num3 = num;
					num = (short)358461640;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_BE;
					}
					break;
				}
				case 1:
					if (featureSection != null)
					{
						num = (short)1196752896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					featureSection = global::AcpUI.AcpExpStatusManager.a(global::AcpUI.AcpExpStatusManager.a(expander), expander.Header as string);
					num = (short)1671888897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				num = (short)170655745;
				if (num != 0)
				{
				}
				if (!global::AcpUI.AcpExpStatusManager.a.TryGetValue(nodeId, out list))
				{
					return false;
				}
				num = (short)2132803586;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BE:
			num = (short)255524864;
			if (num != 0)
			{
			}
			num = (short)1729560576;
			short num4 = num;
			return list.Contains(featureSection.FeatureSectionId);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00017A10 File Offset: 0x00015C10
		private static global::AcpBusinessLayer.FeatureNode a(global::AcpUI.AcpExpander A_0)
		{
			short num = (short)748392012;
			short num2 = num;
			num = (short)1971949132;
			switch (num2 == num)
			{
			}
			num = (short)133300225;
			if (num != 0)
			{
			}
			num = (short)2145189888;
			if (num != 0)
			{
			}
			num = (short)351731712;
			short num3 = num;
			return (global::AcpBusinessLayer.FeatureNode)((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView((global::AcpCommonLib.IAcpRecordset)A_0.DataContext)).CurrentItem;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00017AD4 File Offset: 0x00015CD4
		private static global::AcpBusinessLayer.FeatureSection a(global::AcpBusinessLayer.FeatureNode A_0, string A_1)
		{
			short num = (short)1716453377;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollection.GetEnumerator();
			global::AcpBusinessLayer.FeatureSection result;
			try
			{
				num = (short)929562630;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12B;
					case 1:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						result = featureSection;
						num = (short)790626307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1044709380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
						num = (short)290193413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_10D;
					case 4:
						num = (short)2093940736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						if (featureSection.UIName == A_1)
						{
							num = (short)941883393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_78;
						}
						continue;
					}
					IL_7A:
					num = (short)1399586818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78:
					goto IL_7A;
				}
				IL_10D:
				goto IL_1E5;
				IL_12B:
				goto IL_34;
			}
			finally
			{
				num = (short)398655490;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E2;
					case 1:
						enumerator.Dispose();
						goto IL_1CC;
					case 2:
					{
						num = (short)352790760;
						short num3 = num;
						num = (short)935209192;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CC;
						default:
							num = (short)695664640;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_1AC;
							}
							continue;
						}
						break;
					}
					}
					IL_1AC:
					if (enumerator != null)
					{
						num = (short)1204355073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1CC:
					num = (short)1527447552;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E2:;
			}
			goto IL_1E5;
			IL_34:
			return null;
			IL_1E5:
			num = (short)1884028928;
			short num4 = num;
			return result;
		}

		// Token: 0x04000133 RID: 307
		private static global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<int>> a;
	}
}
