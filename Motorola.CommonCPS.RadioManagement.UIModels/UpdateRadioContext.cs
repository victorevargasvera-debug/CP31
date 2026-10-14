using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ASK.Interface;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000094 RID: 148
	public class UpdateRadioContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0004E6E4 File Offset: 0x0004C8E4
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0004E798 File Offset: 0x0004C998
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> ToUpdateRadioList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)27459584;
				short num2 = num;
				num = (short)1435436436;
				short num3 = num;
				num = (short)577570196;
				switch (num3 == num)
				{
				}
				num = (short)824508416;
				if (num != 0)
				{
				}
				num = (short)842399745;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1221787648;
				short num2 = num;
				num = (short)139638793;
				short num3 = num;
				num = (short)1492957193;
				switch (num3 == num)
				{
				}
				num = (short)1066139649;
				if (num != 0)
				{
				}
				num = (short)2124742656;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0004E84C File Offset: 0x0004CA4C
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0004E8FC File Offset: 0x0004CAFC
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.KeyType> KeyTypes
		{
			get
			{
				short num = (short)1395720192;
				short num2 = num;
				num = (short)825753601;
				if (num != 0)
				{
				}
				num = (short)1800662945;
				short num3 = num;
				num = (short)1190064033;
				switch (num3 == num)
				{
				}
				num = (short)695730176;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1560936448;
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
						{
							num = (short)662831104;
							short num3 = num;
							num = (short)1889728058;
							short num4 = num;
							num = (short)1205925434;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)2005467136;
								if (num != 0)
								{
								}
								this.g = value;
								base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.KeyType>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.KeyType>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_KeyTypes())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)638320642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						IL_30:
						if (value == this.g)
						{
							return;
						}
						num = (short)1183383553;
						if (num != 0)
						{
						}
						num = (short)1716191233;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0004EA4C File Offset: 0x0004CC4C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> AllSystemKeys
		{
			get
			{
				short num = (short)893648896;
				short num2 = num;
				num = (short)435224577;
				if (num != 0)
				{
				}
				num = (short)802600211;
				short num3 = num;
				num = (short)1179366675;
				switch (num3 == num)
				{
				}
				num = (short)1159593984;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)997392384;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_32;
							}
							continue;
						case 1:
						{
							num = (short)1638505260;
							short num3 = num;
							num = (short)102734636;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1272119296;
								short num4 = num;
								break;
							}
							}
							num = (short)813105152;
							if (num != 0)
							{
							}
							num = (short)1309802497;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)481492994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return;
						}
						IL_32:
						if (value == this.a)
						{
							return;
						}
						num = (short)1772683265;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0004EC18 File Offset: 0x0004CE18
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> AttachedKeys
		{
			get
			{
				short num = (short)1919025152;
				short num2 = num;
				num = (short)2015000374;
				short num3 = num;
				num = (short)946304822;
				switch (num3 == num)
				{
				}
				num = (short)1714421761;
				if (num != 0)
				{
				}
				num = (short)1672806400;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1433534464;
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
						{
							num = (short)226689024;
							short num3 = num;
							num = (short)1807200145;
							short num4 = num;
							num = (short)941404049;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)894238720;
								if (num != 0)
								{
								}
								this.b = value;
								num = (short)1347485698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						IL_30:
						if (value == this.b)
						{
							return;
						}
						num = (short)934805505;
						if (num != 0)
						{
						}
						num = (short)1118502913;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0004EDE4 File Offset: 0x0004CFE4
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0004EE94 File Offset: 0x0004D094
		public global::ASK.Interface.ISystemKeyData SystemKeyFormRadio
		{
			get
			{
				short num = (short)935723008;
				short num2 = num;
				num = (short)1542733316;
				short num3 = num;
				num = (short)2069249540;
				switch (num3 == num)
				{
				}
				num = (short)1645281281;
				if (num != 0)
				{
				}
				num = (short)1522335744;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)889454592;
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
						{
							num = (short)575660480;
							short num3 = num;
							num = (short)1414848960;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)574816256;
								short num4 = num;
								break;
							}
							}
							num = (short)432013312;
							if (num != 0)
							{
							}
							this.d = value;
							base.RaisePropertyChanged<global::ASK.Interface.ISystemKeyData>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_SystemKeyFormRadio())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)787021825;
							if (num != 0)
							{
							}
							num = (short)1553858562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return;
						}
						IL_30:
						if (value == this.d)
						{
							return;
						}
						num = (short)878903297;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0004EFE4 File Offset: 0x0004D1E4
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x0004F094 File Offset: 0x0004D294
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> SystemKeysByType
		{
			get
			{
				short num = (short)86310912;
				short num2 = num;
				num = (short)1846338403;
				short num3 = num;
				num = (short)659153763;
				switch (num3 == num)
				{
				}
				num = (short)601161729;
				if (num != 0)
				{
				}
				num = (short)978780160;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num;
				for (;;)
				{
					IL_00:
					num = (short)1902903296;
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
						{
							num = (short)58353105;
							short num3 = num;
							num = (short)1790469585;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1461583872;
								short num4 = num;
								break;
							}
							}
							num = (short)955711488;
							if (num != 0)
							{
							}
							this.c = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_SystemKeysByType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1309147138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_11B;
						}
						IL_30:
						if (value == this.c)
						{
							goto IL_11D;
						}
						num = (short)81461249;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_11B:
				IL_11D:
				num = (short)1649868801;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0004F1E8 File Offset: 0x0004D3E8
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0004F298 File Offset: 0x0004D498
		public global::ASK.Interface.ISystemKeyData SelectSystemKeyData
		{
			get
			{
				short num = (short)28770304;
				short num2 = num;
				num = (short)1141637121;
				if (num != 0)
				{
				}
				num = (short)1178915332;
				short num3 = num;
				num = (short)1716244996;
				switch (num3 == num)
				{
				}
				num = (short)1882128384;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)92143617;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1419568474;
						short num3 = num;
						num = (short)1987831130;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_255;
						default:
							num = (short)1916207104;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_15B;
					case 3:
						goto IL_15B;
					case 4:
						this.WriteProtect = false;
						this.e = value;
						num = (short)690356225;
						if (num != 0)
						{
						}
						num = (short)295239685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (this.e != null)
						{
							num = (short)348127238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)609615872;
						short num4 = num;
						this.WriteProtectEnable = false;
						this.UpdateRadioEnable = false;
						goto IL_255;
					}
					case 6:
						num = (short)541130762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.e.SystemID == 1)
						{
							num = (short)1079640075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.WriteProtectEnable = true;
						this.UpdateRadioEnable = true;
						num = (short)91619331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_15B;
					case 9:
						this.WriteProtectEnable = false;
						this.UpdateRadioEnable = false;
						num = (short)1875574796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.e.SystemID == 0)
						{
							num = (short)167182345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1592393735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						this.WriteProtectEnable = false;
						this.UpdateRadioEnable = true;
						num = (short)795738120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_15B;
					}
					IL_A4:
					if (value != this.e)
					{
						num = (short)1678835716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_15B:
					base.RaisePropertyChanged<global::ASK.Interface.ISystemKeyData>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_SelectSystemKeyData())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)147980288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_255:
					num = (short)983826434;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0004F588 File Offset: 0x0004D788
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x0004F634 File Offset: 0x0004D834
		public global::ASK.Interface.KeyType SelectedkeyType
		{
			get
			{
				short num = (short)1182466048;
				short num2 = num;
				num = (short)734731177;
				short num3 = num;
				num = (short)1514937257;
				switch (num3 == num)
				{
				}
				num = (short)280231936;
				if (num != 0)
				{
				}
				num = (short)2028142593;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)675020800;
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
						goto IL_1CD;
					case 2:
						this.h = value;
						this.WriteProtect = false;
						this.SystemKeysByType = this.a(this.a, this.h);
						this.SelectSystemKeyData = this.SystemKeysByType[0];
						goto IL_11B;
					case 3:
					{
						num = (short)747803142;
						short num3 = num;
						num = (short)485659142;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11B;
						default:
							num = (short)1318715392;
							if (num != 0)
							{
							}
							if (this.h == global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
							{
								num = (short)1182531589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.WriteProtectEnable = false;
							this.UpdateRadioEnable = false;
							num = (short)39124996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_1CD;
					case 5:
						this.WriteProtectEnable = false;
						this.UpdateRadioEnable = true;
						num = (short)1807679489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_40:
					num = (short)449314816;
					short num4 = num;
					if (value != this.h)
					{
						num = (short)600637442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_11B:
					num = (short)1095565313;
					if (num != 0)
					{
					}
					num = (short)1849360387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CD:
					base.RaisePropertyChanged<global::ASK.Interface.KeyType>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::ASK.Interface.KeyType>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_SelectedkeyType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)724107270;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0004F85C File Offset: 0x0004DA5C
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0004F908 File Offset: 0x0004DB08
		public bool WriteProtect
		{
			get
			{
				short num = (short)1569521664;
				short num2 = num;
				num = (short)1320119389;
				short num3 = num;
				num = (short)997616733;
				switch (num3 == num)
				{
				}
				num = (short)1423114241;
				if (num != 0)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)356515840;
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
						{
							num = (short)1635334029;
							short num3 = num;
							num = (short)1855141773;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)236584960;
								short num4 = num;
								break;
							}
							}
							num = (short)1652424704;
							if (num != 0)
							{
							}
							this.f = value;
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_WriteProtect())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1574371329;
							if (num != 0)
							{
							}
							num = (short)1130823682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return;
						}
						IL_30:
						if (value == this.f)
						{
							return;
						}
						num = (short)781582337;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0004FA58 File Offset: 0x0004DC58
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x0004FB08 File Offset: 0x0004DD08
		public string StrProcStatus
		{
			get
			{
				short num = (short)668205056;
				short num2 = num;
				num = (short)666850282;
				short num3 = num;
				num = (short)232149994;
				switch (num3 == num)
				{
				}
				num = (short)1789198336;
				if (num != 0)
				{
				}
				num = (short)1875509249;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)959840256;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)800456705;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						case 1:
						{
							num = (short)1211170816;
							short num3 = num;
							num = (short)1359653763;
							short num4 = num;
							num = (short)168471427;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)910950400;
								if (num != 0)
								{
								}
								this.i = value;
								base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_StrProcStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)1109327874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						IL_57:
						if (!(value != this.i))
						{
							return;
						}
						num = (short)504954881;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0004FC60 File Offset: 0x0004DE60
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0004FD10 File Offset: 0x0004DF10
		public bool WriteProtectEnable
		{
			get
			{
				short num = (short)1801191424;
				short num2 = num;
				num = (short)365559809;
				if (num != 0)
				{
				}
				num = (short)827817838;
				short num3 = num;
				num = (short)1331855214;
				switch (num3 == num)
				{
				}
				num = (short)1794572288;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1919811585;
					if (num != 0)
					{
					}
					num = (short)693698560;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_59;
							}
							continue;
						case 1:
						{
							num = (short)555286528;
							short num3 = num;
							num = (short)1954464093;
							short num4 = num;
							num = (short)439599453;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1252851712;
								if (num != 0)
								{
								}
								this.j = value;
								base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_WriteProtectEnable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)262144002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							return;
						}
						IL_59:
						if (value == this.j)
						{
							return;
						}
						num = (short)52625409;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0004FE60 File Offset: 0x0004E060
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0004FF10 File Offset: 0x0004E110
		public bool UpdateRadioEnable
		{
			get
			{
				short num = (short)1875968000;
				short num2 = num;
				num = (short)1867761920;
				short num3 = num;
				num = (short)803719424;
				switch (num3 == num)
				{
				}
				num = (short)523698177;
				if (num != 0)
				{
				}
				num = (short)1260060672;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)192479232;
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
						{
							num = (short)2098852642;
							short num3 = num;
							num = (short)924840738;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)2026176512;
								short num4 = num;
								break;
							}
							}
							num = (short)1232404480;
							if (num != 0)
							{
							}
							this.k = value;
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext.get_UpdateRadioEnable())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1348665345;
							if (num != 0)
							{
							}
							num = (short)256442370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return;
						}
						IL_30:
						if (value == this.k)
						{
							return;
						}
						num = (short)2082865153;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00050064 File Offset: 0x0004E264
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> a(global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> A_0, global::ASK.Interface.KeyType A_1)
		{
			short num = (short)760938496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_60;
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> observableCollection;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						observableCollection.Add(A_0.Where(delegate(global::ASK.Interface.ISystemKeyData item)
						{
							short num5 = (short)1210712064;
							short num6 = num5;
							num5 = (short)1895936412;
							short num7 = num5;
							num5 = (short)1790161308;
							switch (num7 == num5)
							{
							}
							num5 = (short)533200897;
							if (num5 != 0)
							{
							}
							num5 = (short)368050176;
							if (num5 != 0)
							{
							}
							return item.Type == global::ASK.Interface.KeyType.NONE;
						}).FirstOrDefault<global::ASK.Interface.ISystemKeyData>());
						num = (short)1321271307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (A_1 == global::ASK.Interface.KeyType.NONE)
						{
							num = (short)2033254403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)689504258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_1 == global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
						{
							num = (short)446889991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 3:
						num = (short)113967104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator = A_0.Where(delegate(global::ASK.Interface.ISystemKeyData item)
						{
							short num5 = (short)455147520;
							short num6 = num5;
							num5 = (short)1894525643;
							short num7 = num5;
							num5 = (short)343288523;
							switch (num7 == num5)
							{
							}
							num5 = (short)265355265;
							if (num5 != 0)
							{
							}
							num5 = (short)695336960;
							if (num5 != 0)
							{
							}
							return item.Type == global::ASK.Interface.KeyType.ADVANCED_WACN_KEY;
						}).ToList<global::ASK.Interface.ISystemKeyData>().GetEnumerator();
						num = (short)2013462529;
						if (num != 0)
						{
						}
						num = (short)1359347718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1321730052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_35D;
					case 7:
						num = (short)37814281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)1844183040;
						short num3 = num;
						if (A_1 == global::ASK.Interface.KeyType.ADVANCED_WACN_KEY)
						{
							num = (short)266600453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return observableCollection;
					}
					case 9:
					{
						global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator2 = A_0.Where(delegate(global::ASK.Interface.ISystemKeyData item)
						{
							short num5 = (short)512950272;
							short num6 = num5;
							num5 = (short)803608745;
							short num7 = num5;
							num5 = (short)1490884777;
							switch (num7 == num5)
							{
							}
							num5 = (short)815267841;
							if (num5 != 0)
							{
							}
							num5 = (short)1068367872;
							if (num5 != 0)
							{
							}
							return item.Type == global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
						}).ToList<global::ASK.Interface.ISystemKeyData>().GetEnumerator();
						num = (short)553517066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						try
						{
							num = (short)341180416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E4;
									}
									continue;
								case 2:
									goto IL_25B;
								case 3:
									num = (short)512098306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1260847107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Interface.ISystemKeyData item3 = enumerator2.Current;
									observableCollection.Add(item3);
									num = (short)128122881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1E6:
								num = (short)1689976836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E4:
								goto IL_1E6;
							}
							IL_25B:
							return observableCollection;
						}
						finally
						{
							global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_26E;
					case 11:
						goto IL_102;
					}
					goto IL_60;
					IL_26E:
					num = (short)126615560;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_102:
				return observableCollection;
				IL_35D:
				try
				{
					num = (short)1003618304;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1886059481;
						short num4 = num;
						num = (short)734460889;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1461583872;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3E6;
								}
								continue;
							case 2:
								goto IL_464;
							case 3:
								num = (short)181993474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1539112963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ASK.Interface.ISystemKeyData item2 = enumerator.Current;
								observableCollection.Add(item2);
								num = (short)1003356161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						IL_3E8:
						num = (short)927399940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E6:
						goto IL_3E8;
					}
					IL_464:;
				}
				finally
				{
					global::System.Collections.Generic.List<global::ASK.Interface.ISystemKeyData>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				return observableCollection;
				IL_60:
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
				num = (short)999751681;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x04000277 RID: 631
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> a;

		// Token: 0x04000278 RID: 632
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> b;

		// Token: 0x04000279 RID: 633
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> c;

		// Token: 0x0400027A RID: 634
		private global::ASK.Interface.ISystemKeyData d;

		// Token: 0x0400027B RID: 635
		private global::ASK.Interface.ISystemKeyData e;

		// Token: 0x0400027C RID: 636
		private bool f;

		// Token: 0x0400027D RID: 637
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.KeyType> g;

		// Token: 0x0400027E RID: 638
		private global::ASK.Interface.KeyType h;

		// Token: 0x0400027F RID: 639
		private string i;

		// Token: 0x04000280 RID: 640
		private bool j;

		// Token: 0x04000281 RID: 641
		private bool k;

		// Token: 0x04000282 RID: 642
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> l;
	}
}
