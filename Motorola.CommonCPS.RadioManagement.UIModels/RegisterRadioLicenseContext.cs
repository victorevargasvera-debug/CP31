using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000074 RID: 116
	public class RegisterRadioLicenseContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600034A RID: 842 RVA: 0x00031854 File Offset: 0x0002FA54
		// (remove) Token: 0x0600034B RID: 843 RVA: 0x00031984 File Offset: 0x0002FB84
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler boolValueChanaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler boolValueEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler boolValueEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1322647553;
						if (num2 != 0)
						{
						}
						if (boolValueEventHandler != boolValueEventHandler2)
						{
							goto IL_3A;
						}
						num2 = (short)1691097589;
						short num3 = num2;
						num2 = (short)763959797;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)2038431744;
							short num4 = num2;
							num2 = (short)904003584;
							if (num2 != 0)
							{
							}
							num2 = (short)184352769;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_3A:
					boolValueEventHandler2 = boolValueEventHandler;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler)global::System.Delegate.Combine(boolValueEventHandler2, value);
					boolValueEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler>(ref this.t, value2, boolValueEventHandler2);
					num2 = (short)98893824;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				boolValueEventHandler = this.t;
				num2 = (short)657850370;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler boolValueEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler boolValueEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (boolValueEventHandler != boolValueEventHandler2)
						{
							goto IL_3B;
						}
						num2 = (short)1330039000;
						short num3 = num2;
						num2 = (short)310954200;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)1147273216;
							if (num2 != 0)
							{
							}
							num2 = (short)801177600;
							short num4 = num2;
							num2 = (short)499580929;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_FB;
					case 2:
						goto IL_3B;
					}
					goto IL_1C;
					IL_3B:
					boolValueEventHandler2 = boolValueEventHandler;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler)global::System.Delegate.Remove(boolValueEventHandler2, value);
					boolValueEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler>(ref this.t, value2, boolValueEventHandler2);
					num2 = (short)523698176;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_FB:
				num2 = (short)1632894977;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				boolValueEventHandler = this.t;
				num2 = (short)1818951682;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600034C RID: 844 RVA: 0x00031AB4 File Offset: 0x0002FCB4
		// (remove) Token: 0x0600034D RID: 845 RVA: 0x00031BE4 File Offset: 0x0002FDE4
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler EidSelectChanaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler eidselectEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler eidselectEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (eidselectEventHandler != eidselectEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)332002019;
						short num3 = num2;
						num2 = (short)164885219;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)1398341633;
							if (num2 != 0)
							{
							}
							num2 = (short)1771110400;
							short num4 = num2;
							num2 = (short)1632960512;
							if (num2 != 0)
							{
							}
							num2 = (short)2068119553;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					eidselectEventHandler2 = eidselectEventHandler;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler)global::System.Delegate.Combine(eidselectEventHandler2, value);
					eidselectEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler>(ref this.u, value2, eidselectEventHandler2);
					num2 = (short)1840316416;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eidselectEventHandler = this.u;
				num2 = (short)1577910274;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler eidselectEventHandler;
				for (;;)
				{
					IL_0A:
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler eidselectEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)706215937;
						if (num2 != 0)
						{
						}
						if (eidselectEventHandler != eidselectEventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)162404545;
						short num3 = num2;
						num2 = (short)1273567425;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)601030656;
							short num4 = num2;
							num2 = (short)1493172224;
							if (num2 != 0)
							{
							}
							num2 = (short)973275137;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					eidselectEventHandler2 = eidselectEventHandler;
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler)global::System.Delegate.Remove(eidselectEventHandler2, value);
					eidselectEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler>(ref this.u, value2, eidselectEventHandler2);
					num2 = (short)1178075136;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eidselectEventHandler = this.u;
				num2 = (short)195231746;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00031D18 File Offset: 0x0002FF18
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00031DC4 File Offset: 0x0002FFC4
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer JobContainer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)128669593;
				short num2 = num;
				num = (short)367286169;
				switch (num2 == num)
				{
				}
				num = (short)1738145793;
				if (num != 0)
				{
				}
				num = (short)1847984128;
				short num3 = num;
				num = (short)853540864;
				if (num != 0)
				{
				}
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)75522743;
				short num2 = num;
				num = (short)2105369271;
				switch (num2 == num)
				{
				}
				num = (short)20054017;
				if (num != 0)
				{
				}
				num = (short)2098069504;
				short num3 = num;
				num = (short)273874944;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00031E74 File Offset: 0x00030074
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00031F24 File Offset: 0x00030124
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> AvailableListBoxSelectedItems
		{
			get
			{
				short num = (short)900202497;
				if (num != 0)
				{
				}
				num = (short)1818623109;
				short num2 = num;
				num = (short)340196485;
				switch (num2 == num)
				{
				}
				num = (short)174915584;
				short num3 = num;
				num = (short)1036713984;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)557286291;
				short num2 = num;
				num = (short)10388371;
				switch (num2 == num)
				{
				}
				num = (short)657195009;
				if (num != 0)
				{
				}
				num = (short)2098135040;
				short num3 = num;
				num = (short)1662058496;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00031FD4 File Offset: 0x000301D4
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00032084 File Offset: 0x00030284
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> SelectedListBoxSelctedItems
		{
			get
			{
				short num = (short)968816449;
				short num2 = num;
				num = (short)238745409;
				switch (num2 == num)
				{
				}
				num = (short)1690304512;
				if (num != 0)
				{
				}
				num = (short)34144256;
				short num3 = num;
				num = (short)762773505;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1704142631;
				short num2 = num;
				num = (short)1867327271;
				switch (num2 == num)
				{
				}
				num = (short)867827712;
				if (num != 0)
				{
				}
				num = (short)354811904;
				short num3 = num;
				num = (short)1710620673;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00032134 File Offset: 0x00030334
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000321E4 File Offset: 0x000303E4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group SelectedGroup
		{
			get
			{
				short num = (short)796461234;
				short num2 = num;
				num = (short)918227122;
				switch (num2 == num)
				{
				}
				num = (short)99811329;
				if (num != 0)
				{
				}
				num = (short)22675456;
				short num3 = num;
				num = (short)1820655616;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)660865026;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_SelectedGroup())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						goto IL_12D;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1847007858;
					short num3 = num;
					num = (short)1233394290;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_12D:
						num = (short)1920401409;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)1186201600;
						if (num != 0)
						{
						}
						num = (short)657457153;
						if (num != 0)
						{
						}
						if (value == this.a)
						{
							return;
						}
						num = (short)1748762624;
						short num4 = num;
						num = (short)1062600704;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00032338 File Offset: 0x00030538
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000323E8 File Offset: 0x000305E8
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> Groups
		{
			get
			{
				short num = (short)1031855839;
				short num2 = num;
				num = (short)417390303;
				switch (num2 == num)
				{
				}
				num = (short)1863319553;
				if (num != 0)
				{
				}
				num = (short)1652555776;
				if (num != 0)
				{
				}
				num = (short)494862336;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1374158850;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1F:
					switch (num2)
					{
					case 0:
						goto IL_122;
					case 1:
						this.b = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_Groups())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)539492352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					while (value != this.b)
					{
						num = (short)1363501559;
						short num3 = num;
						num = (short)802972151;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)456523776;
							short num4 = num;
							break;
						}
						}
						num = (short)19398656;
						if (num != 0)
						{
						}
						num = (short)676986881;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1F;
					}
					break;
				}
				IL_122:
				num = (short)1624834049;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00032544 File Offset: 0x00030744
		// (set) Token: 0x06000359 RID: 857 RVA: 0x000325F8 File Offset: 0x000307F8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail SelectChangeSource
		{
			get
			{
				short num = (short)1399523718;
				short num2 = num;
				num = (short)655231366;
				switch (num2 == num)
				{
				}
				num = (short)611057665;
				if (num != 0)
				{
				}
				num = (short)2107834368;
				if (num != 0)
				{
				}
				num = (short)1723990016;
				short num3 = num;
				return this.s;
			}
			set
			{
				short num = (short)518455296;
				short num2 = num;
				num = (short)1202231732;
				short num3 = num;
				num = (short)1987418548;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12E:
					num = (short)1674706946;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1653080065;
					if (num != 0)
					{
					}
					num = (short)926547968;
					if (num != 0)
					{
					}
					num = (short)1728970753;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_197;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					case 2:
						goto IL_146;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)31326208;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.s = value;
						this.u(this.s);
						num = (short)403243011;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D7:
					if (value == this.s)
					{
						break;
					}
					num = (short)915996676;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				return;
				IL_197:
				base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_SelectChangeSource())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_12E;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000327A4 File Offset: 0x000309A4
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00032854 File Offset: 0x00030A54
		public string EIDString
		{
			get
			{
				short num = (short)1226089417;
				short num2 = num;
				num = (short)191210441;
				switch (num2 == num)
				{
				}
				num = (short)87359489;
				if (num != 0)
				{
				}
				num = (short)1980301312;
				if (num != 0)
				{
				}
				num = (short)1136721920;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1046740992;
				short num2 = num;
				num = (short)557963893;
				short num3 = num;
				num = (short)929094261;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_130:
					num = (short)889716738;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1718681601;
					if (num != 0)
					{
					}
					num = (short)1309081600;
					if (num != 0)
					{
					}
					num = (short)1052508161;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_187;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D4;
						}
						continue;
					case 2:
						goto IL_147;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)55705600;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.c = value;
						num = (short)998834179;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D4:
					if (!(value != this.c))
					{
						break;
					}
					num = (short)1946550276;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_147:
				return;
				IL_187:
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_EIDString())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_130;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000329F0 File Offset: 0x00030BF0
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00032AA0 File Offset: 0x00030CA0
		public string NoDeviceWarning
		{
			get
			{
				short num = (short)2033946710;
				short num2 = num;
				num = (short)1538822230;
				switch (num2 == num)
				{
				}
				num = (short)1623982081;
				if (num != 0)
				{
				}
				num = (short)904069120;
				if (num != 0)
				{
				}
				num = (short)1722875904;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)733085696;
				short num2 = num;
				num = (short)1102723817;
				short num3 = num;
				num = (short)850213609;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12F:
					num = (short)1763115010;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1927413760;
					if (num != 0)
					{
					}
					num = (short)2006712321;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_187;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 2:
						goto IL_147;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1146224640;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)64421889;
						if (num != 0)
						{
						}
						this.d = value;
						num = (short)1038680067;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AB:
					if (!(value != this.d))
					{
						break;
					}
					num = (short)1647771652;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_147:
				return;
				IL_187:
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_NoDeviceWarning())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_12F;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00032C3C File Offset: 0x00030E3C
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00032CEC File Offset: 0x00030EEC
		public global::System.Collections.Generic.List<string> EIDHistory
		{
			get
			{
				short num = (short)10609679;
				short num2 = num;
				num = (short)1806033935;
				switch (num2 == num)
				{
				}
				num = (short)71892992;
				if (num != 0)
				{
				}
				num = (short)353107969;
				if (num != 0)
				{
				}
				num = (short)533594112;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)318701568;
				short num2 = num;
				num = (short)975500152;
				short num3 = num;
				num = (short)1912664952;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12C:
					num = (short)1938423810;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)926744576;
					if (num != 0)
					{
					}
					num = (short)74711041;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_184;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 2:
						goto IL_143;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1842741248;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1426718721;
						if (num != 0)
						{
						}
						this.e = value;
						num = (short)2013986819;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AD:
					if (value == this.e)
					{
						break;
					}
					num = (short)400162820;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_143:
				return;
				IL_184:
				base.RaisePropertyChanged<global::System.Collections.Generic.List<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.List<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_EIDHistory())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_12C;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00032E84 File Offset: 0x00031084
		public global::System.ComponentModel.ICollectionView UIEIDDetails
		{
			get
			{
				short num = (short)2124938191;
				short num2 = num;
				num = (short)801307599;
				switch (num2 == num)
				{
				}
				num = (short)1428422656;
				if (num != 0)
				{
				}
				num = (short)1077673985;
				if (num != 0)
				{
				}
				num = (short)725811200;
				short num3 = num;
				return global::System.Windows.Data.CollectionViewSource.GetDefaultView(this.EIDDetails);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00032F3C File Offset: 0x0003113C
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00032FEC File Offset: 0x000311EC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> EIDDetails
		{
			get
			{
				short num = (short)361136705;
				short num2 = num;
				num = (short)1916633665;
				switch (num2 == num)
				{
				}
				num = (short)1747910656;
				if (num != 0)
				{
				}
				num = (short)465502209;
				if (num != 0)
				{
				}
				num = (short)1436942336;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)1379860480;
				short num2 = num;
				num = (short)1755600516;
				short num3 = num;
				num = (short)1155749508;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_107:
					num = (short)1240596482;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1358168064;
					if (num != 0)
					{
					}
					num = (short)246808577;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_185;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 2:
						goto IL_11F;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)2098397184;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.f = value;
						num = (short)1874722819;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B0:
					if (value == this.f)
					{
						return;
					}
					num = (short)2006319108;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_11F:
				num = (short)922615809;
				if (num != 0)
				{
				}
				return;
				IL_185:
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_EIDDetails())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_107;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00033184 File Offset: 0x00031384
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00033234 File Offset: 0x00031434
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> AvailableDevices
		{
			get
			{
				short num = (short)1399866113;
				short num2 = num;
				num = (short)1527857921;
				switch (num2 == num)
				{
				}
				num = (short)1641676801;
				if (num != 0)
				{
				}
				num = (short)712572928;
				if (num != 0)
				{
				}
				num = (short)496107520;
				short num3 = num;
				return this.g;
			}
			set
			{
				short num = (short)1440219136;
				short num2 = num;
				num = (short)1621551146;
				short num3 = num;
				num = (short)494266410;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_103:
					num = (short)522125314;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1784348672;
					if (num != 0)
					{
					}
					num = (short)1313865729;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_183;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 2:
						goto IL_11C;
					case 3:
						num = (short)689438721;
						if (num != 0)
						{
						}
						if (!base.IsLoading)
						{
							num = (short)233242624;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.g = value;
						num = (short)35651587;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (value == this.g)
					{
						break;
					}
					num = (short)1982005252;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_11C:
				return;
				IL_183:
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_AvailableDevices())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_103;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000333CC File Offset: 0x000315CC
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0003347C File Offset: 0x0003167C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> SelectedDevices
		{
			get
			{
				short num = (short)1525014419;
				short num2 = num;
				num = (short)1825103763;
				switch (num2 == num)
				{
				}
				num = (short)458162177;
				if (num != 0)
				{
				}
				num = (short)279117824;
				if (num != 0)
				{
				}
				num = (short)1192624128;
				short num3 = num;
				return this.h;
			}
			set
			{
				short num = (short)2108686336;
				short num2 = num;
				num = (short)746471191;
				short num3 = num;
				num = (short)1912160023;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12E:
					num = (short)1543766018;
					num4 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)42598400;
					if (num != 0)
					{
					}
					num = (short)740556801;
					if (num != 0)
					{
					}
					num = (short)203423745;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_186;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					case 2:
						goto IL_146;
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1071316992;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						this.h = value;
						num = (short)1282408451;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D7:
					if (value == this.h)
					{
						break;
					}
					num = (short)538968068;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				return;
				IL_186:
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_SelectedDevices())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				goto IL_12E;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00033614 File Offset: 0x00031814
		// (set) Token: 0x06000368 RID: 872 RVA: 0x000336C4 File Offset: 0x000318C4
		public global::System.Windows.Visibility AstroVisibility
		{
			get
			{
				short num = (short)514198394;
				short num2 = num;
				num = (short)1541147514;
				switch (num2 == num)
				{
				}
				num = (short)1061945345;
				if (num != 0)
				{
				}
				num = (short)995360768;
				if (num != 0)
				{
				}
				num = (short)1804533760;
				short num3 = num;
				return this.k;
			}
			set
			{
				short num = (short)1104216066;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.k = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_AstroVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)257425408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					for (;;)
					{
						IL_31:
						num = (short)343474177;
						if (num != 0)
						{
						}
						if (value == this.k)
						{
							return;
						}
						num = (short)158728192;
						short num3 = num;
						num = (short)1420008510;
						short num4 = num;
						num = (short)165846078;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C3;
						}
					}
					IL_C3:
					num = (short)127336448;
					if (num != 0)
					{
					}
					num = (short)527892481;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00033818 File Offset: 0x00031A18
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000338C4 File Offset: 0x00031AC4
		public global::System.Windows.Visibility AstroPCRVisibility
		{
			get
			{
				short num = (short)343823248;
				short num2 = num;
				num = (short)1146311568;
				switch (num2 == num)
				{
				}
				num = (short)1584136193;
				if (num != 0)
				{
				}
				num = (short)381681664;
				if (num != 0)
				{
				}
				num = (short)1278607360;
				short num3 = num;
				return this.l;
			}
			set
			{
				short num = (short)1381761025;
				if (num != 0)
				{
				}
				num = (short)311361538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_48:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.l = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_AstroPCRVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1361313792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					while (value != this.l)
					{
						num = (short)1857290240;
						short num3 = num;
						num = (short)1294390946;
						short num4 = num;
						num = (short)393008802;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)995098624;
							if (num != 0)
							{
							}
							num = (short)273612801;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_48;
						}
					}
					break;
				}
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00033A1C File Offset: 0x00031C1C
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00033ACC File Offset: 0x00031CCC
		public bool MainViewEnable
		{
			get
			{
				short num = (short)342158643;
				short num2 = num;
				num = (short)198896947;
				switch (num2 == num)
				{
				}
				num = (short)1383530496;
				if (num != 0)
				{
				}
				num = (short)2061631489;
				if (num != 0)
				{
				}
				num = (short)2010447872;
				short num3 = num;
				return this.n;
			}
			set
			{
				short num = (short)1707409410;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1E:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.n = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_MainViewEnable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)260046848;
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
					while (value != this.n)
					{
						num = (short)148045825;
						if (num != 0)
						{
						}
						num = (short)12255232;
						short num3 = num;
						num = (short)1407908161;
						short num4 = num;
						num = (short)2041837889;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1759903744;
							if (num != 0)
							{
							}
							num = (short)436076545;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					break;
				}
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00033C24 File Offset: 0x00031E24
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00033CD4 File Offset: 0x00031ED4
		public global::System.Windows.Visibility WaitingIndicatorVisibility
		{
			get
			{
				short num = (short)1747310883;
				short num2 = num;
				num = (short)1617484067;
				switch (num2 == num)
				{
				}
				num = (short)62652417;
				if (num != 0)
				{
				}
				num = (short)256442368;
				if (num != 0)
				{
				}
				num = (short)2067464192;
				short num3 = num;
				return this.o;
			}
			set
			{
				short num = (short)443875330;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1F:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.o = value;
						base.RaisePropertyChanged<global::System.Windows.Visibility>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Windows.Visibility>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_WaitingIndicatorVisibility())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1816657920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					while (value != this.o)
					{
						num = (short)83849374;
						short num3 = num;
						num = (short)554987678;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)965148672;
							short num4 = num;
							break;
						}
						}
						num = (short)22151168;
						if (num != 0)
						{
						}
						num = (short)593690625;
						if (num != 0)
						{
						}
						num = (short)302514177;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1F;
					}
					break;
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00033E28 File Offset: 0x00032028
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00033ED8 File Offset: 0x000320D8
		public bool OKCommandExecuted
		{
			get
			{
				short num = (short)169050700;
				short num2 = num;
				num = (short)798130764;
				switch (num2 == num)
				{
				}
				num = (short)815071232;
				if (num != 0)
				{
				}
				num = (short)1721565185;
				if (num != 0)
				{
				}
				num = (short)1038745600;
				short num3 = num;
				return this.p;
			}
			set
			{
				short num = (short)962068482;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1E:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.p = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_OKCommandExecuted())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)92733440;
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
					while (value != this.p)
					{
						num = (short)1773010945;
						if (num != 0)
						{
						}
						num = (short)155254784;
						short num3 = num;
						num = (short)441324703;
						short num4 = num;
						num = (short)41817247;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1515978752;
							if (num != 0)
							{
							}
							num = (short)1134231553;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					break;
				}
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0003402C File Offset: 0x0003222C
		// (set) Token: 0x06000372 RID: 882 RVA: 0x000340D8 File Offset: 0x000322D8
		public bool CancelCommandExecuted
		{
			get
			{
				short num = (short)1237411727;
				short num2 = num;
				num = (short)335832975;
				switch (num2 == num)
				{
				}
				num = (short)915079169;
				if (num != 0)
				{
				}
				num = (short)1121320960;
				if (num != 0)
				{
				}
				num = (short)2032271360;
				short num3 = num;
				return this.q;
			}
			set
			{
				short num = (short)1871839234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1E:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.q = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.get_CancelCommandExecuted())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1013055488;
						short num3 = num;
						num = (short)1844903936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					while (value != this.q)
					{
						num = (short)1599003537;
						short num4 = num;
						num = (short)160553873;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)292487169;
							if (num != 0)
							{
							}
							num = (short)963117056;
							if (num != 0)
							{
							}
							num = (short)1042022401;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					break;
				}
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0003422C File Offset: 0x0003242C
		// (set) Token: 0x06000374 RID: 884 RVA: 0x000342E0 File Offset: 0x000324E0
		public bool IsCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1222770689;
				if (num != 0)
				{
				}
				num = (short)1838974642;
				short num2 = num;
				num = (short)460097202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019543552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)971636736;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1101281300;
				short num2 = num;
				num = (short)1466775572;
				switch (num2 == num)
				{
				}
				num = (short)1235877888;
				short num3 = num;
				num = (short)1520107520;
				if (num != 0)
				{
				}
				num = (short)287047681;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00034390 File Offset: 0x00032590
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0003443C File Offset: 0x0003263C
		public bool IsExecuted
		{
			get
			{
				short num = (short)530914710;
				short num2 = num;
				num = (short)741809558;
				switch (num2 == num)
				{
				}
				num = (short)1152122880;
				short num3 = num;
				num = (short)1678376960;
				if (num != 0)
				{
				}
				num = (short)1336803329;
				if (num != 0)
				{
				}
				return this.r;
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
					{
						num2 = (short)49326568;
						short num3 = num2;
						num2 = (short)1307159016;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)870514688;
							if (num2 != 0)
							{
							}
							this.t(value);
							break;
						}
						num2 = (short)140509185;
						if (num2 != 0)
						{
						}
						num2 = (short)264503297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						return;
					case 2:
						if (this.t != null)
						{
							num2 = (short)351535104;
							short num4 = num2;
							num2 = (short)327024640;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				this.r = value;
				num2 = (short)540344322;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x04000185 RID: 389
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group a;

		// Token: 0x04000186 RID: 390
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> b;

		// Token: 0x04000187 RID: 391
		private string c;

		// Token: 0x04000188 RID: 392
		private string d;

		// Token: 0x04000189 RID: 393
		private global::System.Collections.Generic.List<string> e;

		// Token: 0x0400018A RID: 394
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> f;

		// Token: 0x0400018B RID: 395
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> g;

		// Token: 0x0400018C RID: 396
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> h;

		// Token: 0x0400018D RID: 397
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> i = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();

		// Token: 0x0400018E RID: 398
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> j = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Visibility k = global::System.Windows.Visibility.Collapsed;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Visibility l = global::System.Windows.Visibility.Collapsed;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Visibility m;

		// Token: 0x04000192 RID: 402
		private bool n = true;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Visibility o = global::System.Windows.Visibility.Hidden;

		// Token: 0x04000194 RID: 404
		private bool p;

		// Token: 0x04000195 RID: 405
		private bool q;

		// Token: 0x04000196 RID: 406
		private bool r;

		// Token: 0x04000197 RID: 407
		private global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail s;

		// Token: 0x04000198 RID: 408
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.BoolValueEventHandler t;

		// Token: 0x04000199 RID: 409
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext.EIDSelectEventHandler u;

		// Token: 0x0400019A RID: 410
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer v;

		// Token: 0x0400019B RID: 411
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool w;

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000379 RID: 889
		public delegate void BoolValueEventHandler(bool value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x0600037D RID: 893
		public delegate void EIDSelectEventHandler(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail value);
	}
}
