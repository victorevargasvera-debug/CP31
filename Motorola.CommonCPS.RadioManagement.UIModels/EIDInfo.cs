using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000D3 RID: 211
	public class EIDInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060009F6 RID: 2550 RVA: 0x00097188 File Offset: 0x00095388
		public EIDInfo()
		{
			this.a = string.Empty;
			this.b = string.Empty;
			this.c = string.Empty;
			this.d = string.Empty;
			this.e = string.Empty;
			this.f = string.Empty;
			this.g = string.Empty;
			this.h = false;
			this.i = 0;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000971F8 File Offset: 0x000953F8
		public EIDInfo(string newEntitlement, string newActivationID, string newProductName, string newFeatureName, string newQtyPurchased, string newAvailable, string newRadioCount)
		{
			this.a = newEntitlement;
			this.b = newActivationID;
			this.c = newProductName;
			this.d = newFeatureName;
			this.e = newQtyPurchased;
			this.f = newAvailable;
			this.g = newRadioCount;
			this.IsRadioCountUpdatesEditable = true;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00097248 File Offset: 0x00095448
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000972F4 File Offset: 0x000954F4
		public string Entitlement
		{
			get
			{
				short num = (short)1755068058;
				short num2 = num;
				num = (short)1387411098;
				switch (num2 == num)
				{
				}
				num = (short)695468033;
				if (num != 0)
				{
				}
				num = (short)1927872512;
				if (num != 0)
				{
				}
				num = (short)2093154304;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)2024603648;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)246480901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1049484276;
						short num3 = num;
						num = (short)1861409780;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1798242305;
							if (num != 0)
							{
							}
							num = (short)1141178368;
							if (num != 0)
							{
							}
							if (value == this.a)
							{
								num = (short)1715863558;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.a = value;
							num = (short)1056768002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)1241120768;
						short num4 = num;
						num = (short)11206659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_Entitlement())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1195704321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_41:
					if (value == null)
					{
						return;
					}
					num = (short)163250180;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x000974D8 File Offset: 0x000956D8
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00097588 File Offset: 0x00095788
		public string ActivationID
		{
			get
			{
				short num = (short)856023241;
				short num2 = num;
				num = (short)370532553;
				switch (num2 == num)
				{
				}
				num = (short)1541406721;
				if (num != 0)
				{
				}
				num = (short)810221568;
				if (num != 0)
				{
				}
				num = (short)1525284864;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)431620096;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)169869317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1858443511;
						short num3 = num;
						num = (short)1663277303;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1447428096;
							if (num != 0)
							{
							}
							if (value == this.b)
							{
								num = (short)1870790662;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b = value;
							num = (short)788004866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)277217280;
						short num4 = num;
						num = (short)1083768833;
						if (num != 0)
						{
						}
						num = (short)557514755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_ActivationID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)909508609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_40:
					if (value == null)
					{
						return;
					}
					num = (short)1079312388;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00097768 File Offset: 0x00095968
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00097818 File Offset: 0x00095A18
		public string ProductName
		{
			get
			{
				short num = (short)441049650;
				short num2 = num;
				num = (short)2104025650;
				switch (num2 == num)
				{
				}
				num = (short)1561919489;
				if (num != 0)
				{
				}
				num = (short)430374912;
				if (num != 0)
				{
				}
				num = (short)983040;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1111752704;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)1017380869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)2023449376;
						short num3 = num;
						num = (short)248210208;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)373620736;
							if (num != 0)
							{
							}
							if (value == this.c)
							{
								num = (short)1604845574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1504772097;
							if (num != 0)
							{
							}
							this.c = value;
							num = (short)12779522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)1966407680;
						short num4 = num;
						num = (short)1053032451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_ProductName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)56033281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_40:
					if (value == null)
					{
						return;
					}
					num = (short)94765060;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000979F8 File Offset: 0x00095BF8
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00097AA4 File Offset: 0x00095CA4
		public string FeatureName
		{
			get
			{
				short num = (short)1922689983;
				short num2 = num;
				num = (short)19262399;
				switch (num2 == num)
				{
				}
				num = (short)302841857;
				if (num != 0)
				{
				}
				num = (short)112459776;
				if (num != 0)
				{
				}
				num = (short)617414656;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1494024192;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)505675781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1825400665;
						short num3 = num;
						num = (short)948266841;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1938227200;
							if (num != 0)
							{
							}
							num = (short)1809973249;
							if (num != 0)
							{
							}
							if (value == this.d)
							{
								num = (short)462356486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.d = value;
							num = (short)1565589506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)1265958912;
						short num4 = num;
						num = (short)36044803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_FeatureName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)736755713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_41:
					if (value == null)
					{
						return;
					}
					num = (short)1691484164;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00097C84 File Offset: 0x00095E84
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00097D34 File Offset: 0x00095F34
		public string QtyPurchased
		{
			get
			{
				short num = (short)1773993985;
				if (num != 0)
				{
				}
				num = (short)1061050888;
				short num2 = num;
				num = (short)318986760;
				switch (num2 == num)
				{
				}
				num = (short)515047424;
				if (num != 0)
				{
				}
				num = (short)132251648;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)526123008;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_42;
						}
						continue;
					case 1:
						return;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)1441005573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1025529163;
						short num3 = num;
						num = (short)1680495947;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1566441472;
							if (num != 0)
							{
							}
							if (value == this.e)
							{
								num = (short)1767636998;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.e = value;
							num = (short)1658257410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1734148099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_QtyPurchased())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)433651713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_42:
					num = (short)1140195329;
					if (num != 0)
					{
					}
					if (value == null)
					{
						return;
					}
					num = (short)1626144768;
					short num4 = num;
					num = (short)1356791812;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00097F1C File Offset: 0x0009611C
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00097FD0 File Offset: 0x000961D0
		public string Available
		{
			get
			{
				short num = (short)414408260;
				short num2 = num;
				num = (short)654663236;
				switch (num2 == num)
				{
				}
				num = (short)1782579201;
				if (num != 0)
				{
				}
				num = (short)481820672;
				if (num != 0)
				{
				}
				num = (short)1643511808;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)1584332802;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (value == this.e)
						{
							num = (short)1050148864;
							short num3 = num;
							num = (short)457965569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f = value;
						num = (short)1712779757;
						short num4 = num;
						num = (short)1776021997;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)505085952;
							if (num != 0)
							{
							}
							num = (short)1350303748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_15F;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_42;
						}
						continue;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_Available())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)957546501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)744751107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						return;
					case 6:
						num = (short)163905536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_42:
					if (value == null)
					{
						return;
					}
					num = (short)67174406;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15F:
				num = (short)312934401;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000981B8 File Offset: 0x000963B8
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00098268 File Offset: 0x00096468
		public string RadioCount
		{
			get
			{
				short num = (short)96137418;
				short num2 = num;
				num = (short)1778381002;
				switch (num2 == num)
				{
				}
				num = (short)471793665;
				if (num != 0)
				{
				}
				num = (short)2001666048;
				if (num != 0)
				{
				}
				num = (short)820183040;
				short num3 = num;
				return this.g;
			}
			set
			{
				short num = (short)524288002;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1944322048;
						short num3 = num;
						if (value == this.g)
						{
							num = (short)332005377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.g = value;
						num = (short)1015197357;
						short num4 = num;
						num = (short)2045619885;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2033647617;
							if (num != 0)
							{
							}
							num = (short)1620377600;
							if (num != 0)
							{
							}
							num = (short)306380804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_RadioCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1528758277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1319305219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						return;
					case 6:
						num = (short)1340014592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_40:
					if (value == null)
					{
						return;
					}
					num = (short)1311375366;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00098448 File Offset: 0x00096648
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000984F8 File Offset: 0x000966F8
		public bool EnterQtyFocus
		{
			get
			{
				short num = (short)963570650;
				short num2 = num;
				num = (short)880339930;
				switch (num2 == num)
				{
				}
				num = (short)797704192;
				if (num != 0)
				{
				}
				num = (short)643891201;
				if (num != 0)
				{
				}
				num = (short)268632064;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)2068316164;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_EnterQtyFocus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1130168320;
						short num3 = num;
						num = (short)1562705921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_D5;
					case 2:
						if (!base.IsLoading)
						{
							goto IL_103;
						}
						return;
					case 3:
					{
						num = (short)990257705;
						short num4 = num;
						num = (short)1340219945;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_103;
						default:
							goto IL_154;
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (value == this.h)
					{
						num = (short)694288387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.h = value;
					num = (short)640548866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103:
					num = (short)248446976;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D5:
				return;
				IL_154:
				num = (short)1790443521;
				if (num != 0)
				{
				}
				num = (short)326041600;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00098698 File Offset: 0x00096898
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00098744 File Offset: 0x00096944
		public int RadioCountUpdates
		{
			get
			{
				short num = (short)1132265473;
				if (num != 0)
				{
				}
				num = (short)178854515;
				short num2 = num;
				num = (short)1481972339;
				switch (num2 == num)
				{
				}
				num = (short)1771372544;
				if (num != 0)
				{
				}
				num = (short)1571553280;
				short num3 = num;
				return this.i;
			}
			set
			{
				short num = (short)265748481;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 2:
						if (value > 1)
						{
							num = (short)802291718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76;
					case 3:
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo.get_RadioCountUpdates())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)958660608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)807206912;
						short num3 = num;
						goto IL_1E1;
					}
					case 5:
						num = (short)768933890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						this.i = 1;
						num = (short)1366884356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!base.IsLoading)
						{
							num = (short)1099169795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						num = (short)1417771234;
						short num4 = num;
						num = (short)1669822690;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)852426753;
							if (num != 0)
							{
							}
							num = (short)924909568;
							if (num != 0)
							{
							}
							if (this.IsSingleRegister)
							{
								num = (short)641400837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_76;
						}
						break;
					}
					case 9:
						goto IL_1E1;
					case 10:
						return;
					}
					IL_50:
					if (value == this.i)
					{
						num = (short)2002124810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)259653640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76:
					this.i = value;
					num = (short)1823342601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E1:
					num = (short)1155661831;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000989A8 File Offset: 0x00096BA8
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00098A5C File Offset: 0x00096C5C
		public bool IsRadioCountUpdatesEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1348016059;
				short num2 = num;
				num = (short)1508513723;
				switch (num2 == num)
				{
				}
				num = (short)2107047936;
				if (num != 0)
				{
				}
				num = (short)873922561;
				if (num != 0)
				{
				}
				num = (short)246808576;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)924385281;
				if (num != 0)
				{
				}
				num = (short)1869695757;
				short num2 = num;
				num = (short)1187793677;
				switch (num2 == num)
				{
				}
				num = (short)1523056640;
				if (num != 0)
				{
				}
				num = (short)1077411840;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00098B0C File Offset: 0x00096D0C
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00098BBC File Offset: 0x00096DBC
		public bool IsSingleRegister
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)667424821;
				short num2 = num;
				num = (short)1587091509;
				switch (num2 == num)
				{
				}
				num = (short)707395585;
				if (num != 0)
				{
				}
				num = (short)229048320;
				if (num != 0)
				{
				}
				num = (short)93192192;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)267223060;
				short num2 = num;
				num = (short)1680310292;
				switch (num2 == num)
				{
				}
				num = (short)1610481665;
				if (num != 0)
				{
				}
				num = (short)2057306112;
				if (num != 0)
				{
				}
				num = (short)1960378368;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00098C6C File Offset: 0x00096E6C
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00098D18 File Offset: 0x00096F18
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? Region
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)360203786;
				short num2 = num;
				num = (short)906184202;
				switch (num2 == num)
				{
				}
				num = (short)1413677057;
				if (num != 0)
				{
				}
				num = (short)1244200960;
				if (num != 0)
				{
				}
				num = (short)1791754240;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)619697790;
				short num2 = num;
				num = (short)1301010046;
				switch (num2 == num)
				{
				}
				num = (short)803536897;
				if (num != 0)
				{
				}
				num = (short)679084032;
				if (num != 0)
				{
				}
				num = (short)1691025408;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x04000397 RID: 919
		private string a;

		// Token: 0x04000398 RID: 920
		private string b;

		// Token: 0x04000399 RID: 921
		private string c;

		// Token: 0x0400039A RID: 922
		private string d;

		// Token: 0x0400039B RID: 923
		private string e;

		// Token: 0x0400039C RID: 924
		private string f;

		// Token: 0x0400039D RID: 925
		private string g;

		// Token: 0x0400039E RID: 926
		private bool h;

		// Token: 0x0400039F RID: 927
		private int i;

		// Token: 0x040003A0 RID: 928
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x040003A1 RID: 929
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x040003A2 RID: 930
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? l;
	}
}
