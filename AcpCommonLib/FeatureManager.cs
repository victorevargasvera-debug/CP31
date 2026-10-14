using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AcpCommonLib
{
	// Token: 0x0200001E RID: 30
	public static class FeatureManager
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000E990 File Offset: 0x0000CB90
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000EA40 File Offset: 0x0000CC40
		public static global::AcpCommonLib.Document ActiveDocument
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1479616474;
				short num2 = num;
				num = (short)997337050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032912896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2002386945;
				if (num != 0)
				{
				}
				num = (short)851968000;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1777952467;
				short num2 = num;
				num = (short)1052796627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1200160768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)442433537;
				if (num != 0)
				{
				}
				num = (short)876019712;
				if (num != 0)
				{
				}
				global::AcpCommonLib.FeatureManager.c = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		public static bool IsInitialized
		{
			get
			{
				short num = (short)599195649;
				if (num != 0)
				{
				}
				num = (short)1849294848;
				short num2 = num;
				num = (short)1299171286;
				short num3 = num;
				num = (short)1254737878;
				switch (num3 == num)
				{
				}
				num = (short)2126512128;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.b;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		public static global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> Features
		{
			get
			{
				short num = (short)1271840724;
				short num2 = num;
				num = (short)1397800916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029505024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1573715969;
				if (num != 0)
				{
				}
				num = (short)692715520;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.ActiveDocument.Features;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000EC54 File Offset: 0x0000CE54
		public static void AddFeature(global::AcpCommonLib.IAcpRecordset recset)
		{
			short num = (short)559455821;
			short num2 = num;
			num = (short)1915002445;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1559756800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)229638144;
			if (num != 0)
			{
			}
			num = (short)2040791041;
			if (num != 0)
			{
			}
			global::AcpCommonLib.FeatureManager.ActiveDocument.AddFeature(recset);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000ED08 File Offset: 0x0000CF08
		public static global::AcpCommonLib.IAcpRecordset GetFeature(int id)
		{
			while (!(bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
			{
				short num = (short)113790338;
				short num2 = num;
				num = (short)1830178178;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)347340800;
					short num3 = num;
					num = (short)1632108544;
					if (num != 0)
					{
					}
					num = (short)806354945;
					if (num != 0)
					{
					}
					return global::AcpCommonLib.FeatureManager.ActiveDocument.GetFeature(id);
				}
				}
			}
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public static void BeginAddFeatures()
		{
			short num = (short)1601790243;
			short num2 = num;
			num = (short)547512611;
			switch (num2 == num)
			{
			}
			num = (short)814743552;
			short num3 = num;
			num = (short)201785345;
			if (num != 0)
			{
			}
			num = (short)72351744;
			if (num != 0)
			{
			}
			global::AcpCommonLib.ConstraintManager.Suspend();
			global::AcpCommonLib.FeatureManager.ActiveDocument.Clear();
			global::AcpCommonLib.FeatureManager.a = true;
			global::AcpCommonLib.FeatureManager.b = false;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		public static void BeginAddFeatures(global::AcpCommonLib.Document doc)
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
					num2 = (short)103350273;
					if (num2 != 0)
					{
					}
					goto IL_FE;
				case 1:
					if (doc.DocType == global::AcpCommonLib.DocumentType.Default)
					{
						num2 = (short)508546887;
						short num3 = num2;
						num2 = (short)2101727047;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FE;
						case 1:
							break;
						default:
						{
							num2 = (short)1974140928;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)88080384;
						if (num2 != 0)
						{
						}
						num2 = (short)395968512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11E;
				case 2:
					goto IL_11C;
				}
				goto IL_1C;
				IL_FE:
				global::AcpCommonLib.AppInfoManager.InitializingDefaultDoc = true;
				num2 = (short)774569986;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_11C:
			IL_11E:
			global::AcpCommonLib.FeatureManager.a = true;
			global::AcpCommonLib.FeatureManager.b = false;
			return;
			IL_1C:
			global::AcpCommonLib.ConstraintManager.Suspend();
			doc.Clear();
			num2 = (short)1294532609;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		public static void AddFeature(global::AcpCommonLib.Document doc, global::AcpCommonLib.IAcpRecordset recset)
		{
			short num = (short)1263216267;
			short num2 = num;
			num = (short)1817650827;
			switch (num2 == num)
			{
			}
			num = (short)960430080;
			short num3 = num;
			num = (short)342556672;
			if (num != 0)
			{
			}
			num = (short)789708801;
			if (num != 0)
			{
			}
			doc.AddFeature(recset);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000F08C File Offset: 0x0000D28C
		public static void EndAddFeatures()
		{
			short num = (short)1848050157;
			short num2 = num;
			num = (short)1663631853;
			switch (num2 == num)
			{
			}
			num = (short)1268514816;
			short num3 = num;
			num = (short)1463025664;
			if (num != 0)
			{
			}
			num = (short)158269441;
			if (num != 0)
			{
			}
			global::AcpCommonLib.FeatureManager.a = false;
			global::AcpCommonLib.FeatureManager.b = true;
			global::AcpCommonLib.ConstraintManager.Resume();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000F148 File Offset: 0x0000D348
		public static void EndAddFeatures(global::AcpCommonLib.Document doc)
		{
			short num = (short)797048832;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			int num3;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					if (doc.IsMainDocument)
					{
						num = (short)948633604;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D8;
				case 1:
					goto IL_AD;
				case 2:
					if (doc.DocType == global::AcpCommonLib.DocumentType.Default)
					{
						num = (short)569442307;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)761258471;
					short num4 = num;
					num = (short)76472807;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AD;
					default:
						num = (short)780926976;
						if (num != 0)
						{
						}
						global::AcpCommonLib.AppInfoManager.InitializingDefaultDoc = false;
						num = (short)1451753473;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					global::AcpCommonLib.ConstraintManager.Resume();
					num = (short)1340473349;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_D8;
				}
				goto IL_52;
				IL_D8:
				num = (short)2000355330;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_AD:
			num = (short)1186398209;
			if (num != 0)
			{
			}
			return;
			IL_52:
			global::AcpCommonLib.FeatureManager.a = false;
			global::AcpCommonLib.FeatureManager.b = true;
			num = (short)2017460224;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x04000082 RID: 130
		private static bool a;

		// Token: 0x04000083 RID: 131
		private static bool b;

		// Token: 0x04000084 RID: 132
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.Document c;
	}
}
