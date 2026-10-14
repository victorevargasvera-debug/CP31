using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200007E RID: 126
	public class SelectGeneralPackageContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0003BD18 File Offset: 0x00039F18
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0003BDC8 File Offset: 0x00039FC8
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> Packages
		{
			get
			{
				short num = (short)547081743;
				short num2 = num;
				num = (short)712756751;
				switch (num2 == num)
				{
				}
				num = (short)1912274945;
				if (num != 0)
				{
				}
				num = (short)1247281152;
				if (num != 0)
				{
				}
				num = (short)226557952;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)861470722;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11A;
					case 1:
						this.b = value;
						base.RaisePropertyChanged<global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext.get_Packages())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1619329024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (this.b == value)
					{
						break;
					}
					num = (short)2144403457;
					if (num != 0)
					{
					}
					num = (short)398978153;
					short num3 = num;
					num = (short)347794537;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11C;
					default:
						num = (short)1457192960;
						if (num != 0)
						{
						}
						num = (short)2043674625;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_11A:
				IL_11C:
				num = (short)274923520;
				short num4 = num;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0003BF1C File Offset: 0x0003A11C
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0003BFC8 File Offset: 0x0003A1C8
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> Devices
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1544692277;
				short num2 = num;
				num = (short)616243765;
				switch (num2 == num)
				{
				}
				num = (short)2103443457;
				if (num != 0)
				{
				}
				num = (short)197722112;
				if (num != 0)
				{
				}
				num = (short)368377856;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1005270748;
				short num2 = num;
				num = (short)1748842204;
				switch (num2 == num)
				{
				}
				num = (short)365232129;
				if (num != 0)
				{
				}
				num = (short)1337327616;
				if (num != 0)
				{
				}
				num = (short)1751515136;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0003C078 File Offset: 0x0003A278
		public global::System.Collections.Generic.List<string> PackageNames
		{
			get
			{
				short num = (short)1333264386;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)178192385;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_8A;
					case 1:
						goto IL_73;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					}
					IL_57:
					if (this.Packages != null)
					{
						num = (short)823984129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)647305313;
					short num3 = num;
					num = (short)1804998753;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F3;
					}
					IL_73:
					num = (short)411828224;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8A:
				return this.Packages.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>().ConvertAll<string>(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage b)
				{
					short num5 = (short)1949843165;
					short num6 = num5;
					num5 = (short)1073757917;
					switch (num6 == num5)
					{
					}
					num5 = (short)96206848;
					if (num5 != 0)
					{
					}
					num5 = (short)685768705;
					if (num5 != 0)
					{
					}
					num5 = (short)696909824;
					short num7 = num5;
					return b.Name;
				});
				IL_F3:
				num = (short)749207552;
				if (num != 0)
				{
				}
				num = (short)436928512;
				short num4 = num;
				return null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0003C1B8 File Offset: 0x0003A3B8
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0003C470 File Offset: 0x0003A670
		public int SelectedPackageIndex
		{
			get
			{
				int a_ = 3;
				short num = (short)1016922124;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1838284801;
						if (num != 0)
						{
						}
						goto IL_1BB;
					case 1:
					{
						int num3 = 0;
						num = (short)500760576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1BB;
					case 3:
					{
						num = (short)560857780;
						short num4 = num;
						num = (short)637534900;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1984495616;
							if (num != 0)
							{
							}
							if (this.a == -1)
							{
								num = (short)1633026049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A4;
						}
						break;
					}
					case 4:
						num = (short)1218641931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1FB;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage;
						if (generalPackage.VValue == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⨚", a_))
						{
							num = (short)1889075200;
							short num5 = num;
							num = (short)996933642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)769261570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_A1;
					case 8:
						num = (short)1368850435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int num3;
						if (num3 >= this.b.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>())
						{
							num = (short)681967621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage generalPackage = this.b.ElementAt(num3);
						num = (short)1249574918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						int num3;
						this.a = num3;
						num = (short)1853947911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (this.b != null)
						{
							num = (short)452657160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A4;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					if (this.Devices != null)
					{
						num = (short)1852112900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1BB:
					num = (short)376832009;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A1:
				IL_1FB:
				IL_2A4:
				return this.a;
			}
			set
			{
				short num = (short)290193412;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.ExceptionMessage = string.Empty;
						num = (short)1839726593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)913571841;
						if (num != 0)
						{
						}
						this.a = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectGeneralPackageContext.get_SelectedPackageIndex())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2012544002;
						short num3 = num;
						num = (short)1377434626;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)194838528;
							if (num != 0)
							{
							}
							num = (short)481886211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (!string.IsNullOrEmpty(base.ExceptionMessage))
						{
							num = (short)2045902848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					num = (short)2077163520;
					short num4 = num;
					if (this.a == value)
					{
						break;
					}
					num = (short)1632174082;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0003C618 File Offset: 0x0003A818
		public global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage SelectedPackage
		{
			get
			{
				short num = (short)1554359106;
				short num2 = num;
				num = (short)1717150530;
				switch (num2 == num)
				{
				}
				num = (short)1203503105;
				if (num != 0)
				{
				}
				num = (short)40697856;
				if (num != 0)
				{
				}
				num = (short)1902772224;
				short num3 = num;
				return this.b.ElementAt(this.a);
			}
		}

		// Token: 0x040001DC RID: 476
		private int a = -1;

		// Token: 0x040001DD RID: 477
		private global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage> b;

		// Token: 0x040001DE RID: 478
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> c;
	}
}
