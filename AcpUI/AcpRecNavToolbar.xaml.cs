using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;
using AcpUtility;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;

namespace AcpUI
{
	// Token: 0x02000009 RID: 9
	public partial class AcpRecNavToolbar : UserControl, IAcpRecNavToolbar, IDisposable, INotifyPropertyChanged
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00006298 File Offset: 0x00004498
		public AcpRecNavToolbar()
		{
			int a_ = 1;
			this.c = 1;
			this.d = AcpUI.Common.Utility.c("練", a_);
			this.e = AcpUI.Common.Utility.c("ꎖ", a_);
			this.g = "";
			base..ctor();
			this.InitializeComponent();
			base.DataContextChanged += this.OnDataContextChanged;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006308 File Offset: 0x00004508
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1759209371;
				short num2 = num;
				num = (short)1406691227;
				switch (num2 == num)
				{
				}
				num = (short)444530689;
				if (num != 0)
				{
				}
				num = (short)1823408128;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)1567555584;
			short num3 = num;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000063D4 File Offset: 0x000045D4
		protected virtual void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			short num = (short)182452236;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1082130442;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					if (e.NewValue != null)
					{
						num = (short)1921515523;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7D;
				case 2:
					if (e.NewValue == null)
					{
						num = (short)395902982;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_286;
				case 4:
					num = (short)791674882;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					goto IL_19C;
				case 6:
				{
					this.UnsubscribeFromRecordsetEvents((Recordset)e.OldValue);
					num = (short)1084762181;
					short num3 = num;
					num = (short)849750085;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1195114496;
						if (num != 0)
						{
						}
						num = (short)86966277;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (e.OldValue == null)
					{
						num = (short)1344208905;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7D;
				case 8:
					goto IL_1DB;
				case 9:
					num = (short)1973551105;
					num2 = (int)((IntPtr)num);
					continue;
				case 10:
					if (e.NewValue != null)
					{
						num = (short)266928136;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_28B;
				case 11:
					if (e.OldValue != null)
					{
						num = (short)843644932;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 12:
					goto IL_14;
				}
				goto IL_58;
				IL_14:
				switch (0)
				{
				case 0:
					IL_58:
					if (e.OldValue == null)
					{
						goto IL_28B;
					}
					num = (short)1211105280;
					num2 = (int)((IntPtr)num);
					break;
				}
				continue;
				IL_7D:
				num = (short)174260235;
				num2 = (int)((IntPtr)num);
				continue;
				IL_28B:
				num = (short)1686962183;
				num2 = (int)((IntPtr)num);
			}
			IL_19C:
			return;
			IL_1DB:
			num = (short)142278657;
			if (num != 0)
			{
			}
			num = (short)2086273024;
			short num4 = num;
			this.UnsubscribeFromRecordsetEvents((Recordset)e.OldValue);
			this.SubscribeToRecordsetEvents((Recordset)e.NewValue);
			this.a();
			return;
			IL_286:
			this.SubscribeToRecordsetEvents((Recordset)e.NewValue);
			this.a();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000066AC File Offset: 0x000048AC
		protected virtual void OnRecordsetPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			int a_ = 4;
			short num = (short)704512002;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					for (;;)
					{
						num = (short)25949845;
						short num3 = num;
						num = (short)1086781077;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A2;
						}
					}
					IL_A2:
					num = (short)1085865984;
					short num4 = num;
					num = (short)1588854784;
					if (num != 0)
					{
					}
					this.UpdateRecordOperationButtons();
					num = (short)408944641;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 1:
					goto IL_FE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (!(e.PropertyName == AcpUI.Common.Utility.c("\ud999ﶛ욡삣", a_)))
				{
					break;
				}
				num = (short)1992491008;
				num2 = (int)((IntPtr)num);
			}
			IL_FE:
			num = (short)476905473;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000067E0 File Offset: 0x000049E0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00006890 File Offset: 0x00004A90
		public AcpXamDataPresenter MyDataPresenter
		{
			get
			{
				short num = (short)1965342675;
				short num2 = num;
				num = (short)1892925395;
				switch (num2 == num)
				{
				}
				num = (short)1560281088;
				short num3 = num;
				num = (short)853278721;
				if (num != 0)
				{
				}
				num = (short)1543241728;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1818034187;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == null)
						{
							num = (short)451018754;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 1:
						if (value != null)
						{
							num = (short)1734017029;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_221;
					case 3:
						if (this.a != null)
						{
							num = (short)318308360;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 4:
						num = (short)1824456705;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						goto IL_1E8;
					case 6:
						num = (short)1554907145;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						goto IL_1B0;
					case 8:
						num = (short)1321205761;
						if (num != 0)
						{
						}
						num = (short)1571160064;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						if (value != null)
						{
							num = (short)341508103;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_226;
					case 10:
						if (this.a != null)
						{
							num = (short)1152647172;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						num = (short)1106445036;
						short num3 = num;
						num = (short)2135884524;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_221;
						default:
							num = (short)1484587008;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A0;
							}
							continue;
						}
						break;
					}
					}
					IL_A0:
					if (this.a == null)
					{
						num = (short)1206255622;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_226;
					IL_C4:
					num = (short)400818176;
					short num4 = num;
					num = (short)1135214602;
					num2 = (int)((IntPtr)num);
					continue;
					IL_226:
					num = (short)16515075;
					num2 = (int)((IntPtr)num);
				}
				IL_1B0:
				this.SubscribeToDataPresenterEvents(value);
				this.a = value;
				this.SelectAndActivateCurrentViewRecord();
				return;
				IL_1E8:
				this.UnsubscribeFromDataPresenterEvents(this.a);
				this.SubscribeToDataPresenterEvents(value);
				this.a = value;
				this.SelectAndActivateCurrentViewRecord();
				return;
				IL_221:
				this.UnsubscribeFromDataPresenterEvents(this.a);
				this.a = null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00006B2C File Offset: 0x00004D2C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)643180938;
				short num2 = num;
				num = (short)1310140810;
				switch (num2 == num)
				{
				}
				num = (short)64487424;
				short num3 = num;
				num = (short)471334913;
				if (num != 0)
				{
				}
				num = (short)321781760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpRecNavToolbar.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1802615046;
				short num2 = num;
				num = (short)243185926;
				switch (num2 == num)
				{
				}
				num = (short)1809448960;
				short num3 = num;
				num = (short)1571880961;
				if (num != 0)
				{
				}
				num = (short)629080064;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006CA0 File Offset: 0x00004EA0
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00006D58 File Offset: 0x00004F58
		public bool IsAddMultQtyEn
		{
			get
			{
				short num = (short)89953467;
				short num2 = num;
				num = (short)859870395;
				switch (num2 == num)
				{
				}
				num = (short)1699086336;
				short num3 = num;
				num = (short)1985675264;
				if (num != 0)
				{
				}
				num = (short)103809025;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpRecNavToolbar.IsAddMultQtyEnProperty);
			}
			set
			{
				short num = (short)975616868;
				short num2 = num;
				num = (short)1277737828;
				switch (num2 == num)
				{
				}
				num = (short)2142830592;
				short num3 = num;
				num = (short)125632513;
				if (num != 0)
				{
				}
				num = (short)367067136;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.IsAddMultQtyEnProperty, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00006E14 File Offset: 0x00005014
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00006ECC File Offset: 0x000050CC
		public bool IsDefaultMaskTypeEn
		{
			get
			{
				short num = (short)915271139;
				short num2 = num;
				num = (short)367717859;
				switch (num2 == num)
				{
				}
				num = (short)656408576;
				short num3 = num;
				num = (short)1960902657;
				if (num != 0)
				{
				}
				num = (short)2089156608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpRecNavToolbar.IsDefaultMaskTypeEnProperty);
			}
			set
			{
				short num = (short)2020785145;
				short num2 = num;
				num = (short)182696953;
				switch (num2 == num)
				{
				}
				num = (short)303104000;
				short num3 = num;
				num = (short)1292238849;
				if (num != 0)
				{
				}
				num = (short)1657995264;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.IsDefaultMaskTypeEnProperty, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00006F84 File Offset: 0x00005184
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00007040 File Offset: 0x00005240
		public bool IsMaskMaxLengthEn
		{
			get
			{
				short num = (short)2109335698;
				short num2 = num;
				num = (short)660859026;
				switch (num2 == num)
				{
				}
				num = (short)607518720;
				short num3 = num;
				num = (short)2059141120;
				if (num != 0)
				{
				}
				num = (short)545062913;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpRecNavToolbar.IsMaskMaxLengthEnProperty);
			}
			set
			{
				short num = (short)1836476314;
				short num2 = num;
				num = (short)2041866138;
				switch (num2 == num)
				{
				}
				num = (short)1387134976;
				short num3 = num;
				num = (short)1237909504;
				if (num != 0)
				{
				}
				num = (short)1120141313;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.IsMaskMaxLengthEnProperty, value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000070F8 File Offset: 0x000052F8
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000071B0 File Offset: 0x000053B0
		public IAcpRecordset MyRecordsetDataSource
		{
			get
			{
				short num = (short)1111495292;
				short num2 = num;
				num = (short)1113723516;
				switch (num2 == num)
				{
				}
				num = (short)691339264;
				short num3 = num;
				num = (short)1871052801;
				if (num != 0)
				{
				}
				num = (short)135725056;
				if (num != 0)
				{
				}
				return (IAcpRecordset)base.DataContext;
			}
			set
			{
				short num = (short)1778967336;
				short num2 = num;
				num = (short)660988712;
				switch (num2 == num)
				{
				}
				num = (short)945618944;
				short num3 = num;
				num = (short)1502478336;
				if (num != 0)
				{
				}
				num = (short)330629121;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.MyRecordsetDataSourceProperty, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00007268 File Offset: 0x00005468
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00007320 File Offset: 0x00005520
		public virtual IAcpRecordset MySecondaryRecordsetDataSource
		{
			get
			{
				short num = (short)856031233;
				if (num != 0)
				{
				}
				num = (short)403131461;
				short num2 = num;
				num = (short)2110803013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074855936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)854851584;
				if (num != 0)
				{
				}
				return (IAcpRecordset)base.GetValue(AcpRecNavToolbar.MySecondaryRecordsetDataSourceProperty);
			}
			set
			{
				short num = (short)1522991105;
				if (num != 0)
				{
				}
				num = (short)1413075269;
				short num2 = num;
				num = (short)1218040133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060175872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467206144;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.MySecondaryRecordsetDataSourceProperty, value);
				this.a();
				this.SyncDataSources();
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000073E0 File Offset: 0x000055E0
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00007498 File Offset: 0x00005698
		public int GoToRecNum
		{
			get
			{
				short num = (short)522605102;
				short num2 = num;
				num = (short)1780961838;
				switch (num2 == num)
				{
				}
				num = (short)67698688;
				short num3 = num;
				num = (short)1798897665;
				if (num != 0)
				{
				}
				num = (short)1006829568;
				if (num != 0)
				{
				}
				return (int)base.GetValue(AcpRecNavToolbar.GoToRecNumProperty);
			}
			set
			{
				short num = (short)1260909147;
				short num2 = num;
				num = (short)1120399963;
				switch (num2 == num)
				{
				}
				num = (short)7929856;
				short num3 = num;
				num = (short)1410859008;
				if (num != 0)
				{
				}
				num = (short)921632769;
				if (num != 0)
				{
				}
				base.SetValue(AcpRecNavToolbar.GoToRecNumProperty, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00007550 File Offset: 0x00005750
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00007600 File Offset: 0x00005800
		public int AddMultQty
		{
			get
			{
				short num = (short)42103279;
				short num2 = num;
				num = (short)1422750191;
				switch (num2 == num)
				{
				}
				num = (short)1364459520;
				short num3 = num;
				num = (short)106627073;
				if (num != 0)
				{
				}
				num = (short)1837957120;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				int a_ = 5;
				short num = (short)702873601;
				if (num != 0)
				{
				}
				num = (short)1551060427;
				short num2 = num;
				num = (short)2058505675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042953728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546045952;
				if (num != 0)
				{
				}
				this.c = value;
				this.RaisePropertyChanged(AcpUI.Common.Utility.c("\uda9a列ﮞ횢즤펦\udfaa풬", a_));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000076CC File Offset: 0x000058CC
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00007778 File Offset: 0x00005978
		public string DefaultMaskType
		{
			get
			{
				short num = (short)1036648449;
				if (num != 0)
				{
				}
				num = (short)687726792;
				short num2 = num;
				num = (short)2105073864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)537526272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933967360;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 18;
				short num = (short)919006736;
				short num2 = num;
				num = (short)428338704;
				switch (num2 == num)
				{
				}
				num = (short)414056448;
				short num3 = num;
				num = (short)1907884033;
				if (num != 0)
				{
				}
				num = (short)579141632;
				if (num != 0)
				{
				}
				this.d = value;
				this.RaisePropertyChanged(AcpUI.Common.Utility.c("쾩쪫쾭얯\udeb1삳﮵\ud9b7즹ힻ릿닁ꇃ", a_));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00007848 File Offset: 0x00005A48
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000078F8 File Offset: 0x00005AF8
		public string MaskMaxLength
		{
			get
			{
				short num = (short)2027494172;
				short num2 = num;
				num = (short)1917066012;
				switch (num2 == num)
				{
				}
				num = (short)150601728;
				short num3 = num;
				num = (short)277479425;
				if (num != 0)
				{
				}
				num = (short)1686110208;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				int a_ = 8;
				short num = (short)930617288;
				short num2 = num;
				num = (short)286070728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)888602624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095237632;
				if (num != 0)
				{
				}
				num = (short)266207233;
				if (num != 0)
				{
				}
				this.e = value;
				this.RaisePropertyChanged(AcpUI.Common.Utility.c("펝솟톡쾣즧튩쮭\udeaf햱삳\udeb5", a_));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000079C8 File Offset: 0x00005BC8
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00007A78 File Offset: 0x00005C78
		public int RecordTypeToAdd
		{
			get
			{
				short num = (short)1684325421;
				short num2 = num;
				num = (short)207143981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1126301696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770520577;
				if (num != 0)
				{
				}
				num = (short)132251648;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				int a_ = 18;
				short num = (short)730001388;
				short num2 = num;
				num = (short)1260974060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300154880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1456078849;
				if (num != 0)
				{
				}
				num = (short)355401728;
				if (num != 0)
				{
				}
				this.f = value;
				this.RaisePropertyChanged(AcpUI.Common.Utility.c("盛쾩쾫솭슯횱쾵좷\udfb9톽膿ꛁꃃ", a_));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00007B44 File Offset: 0x00005D44
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00007C00 File Offset: 0x00005E00
		public bool TableMode
		{
			get
			{
				short num = (short)1368544614;
				short num2 = num;
				num = (short)2088392038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900019712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1555693569;
				if (num != 0)
				{
				}
				num = (short)409927680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpRecNavToolbar.TableModeProperty);
			}
			set
			{
				short num = (short)331481095;
				int num2 = (int)((IntPtr)num);
				RecordPresenter recordPresenter;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_36C;
					case 1:
						return;
					case 2:
						if (this.a != null)
						{
							num = (short)1924399117;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 3:
						goto IL_543;
					case 4:
						goto IL_215;
					case 5:
						num = (short)961282064;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
					{
						if (this.MyRecordsetDataSource.IsEmbeddedRecset)
						{
							goto IL_543;
						}
						num = (short)2095348285;
						short num3 = num;
						num = (short)1156086333;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_443;
						default:
							num = (short)822738944;
							if (num != 0)
							{
							}
							num = (short)1083310109;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 8:
						recordPresenter = null;
						num = (short)1925775374;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						if (this.a != null)
						{
							num = (short)1129840673;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_215;
					case 10:
						if (!this.TableMode && value)
						{
							num = (short)1628569632;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_215;
					case 11:
						goto IL_215;
					case 12:
						if (!(this is AcpChildRecNavToolbar))
						{
							num = (short)577568786;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_443;
					case 13:
						this.UnsubscribeFromDataPresenterEvents(this.a);
						num = (short)1862336524;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						if (this.a.Records.Count > 0)
						{
							num = (short)1918107679;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 15:
						if (recordPresenter != null)
						{
							num = (short)576258070;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.a.Focus();
						num = (short)1195638785;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						if (!value)
						{
							num = (short)302383127;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 17:
						if (this.MyRecordsetDataSource.HideRecordsFromTree)
						{
							num = (short)89653251;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_215;
					case 18:
						num = (short)647888926;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if (!(this is AcpChildRecNavToolbar))
						{
							num = (short)1016725505;
							if (num != 0)
							{
							}
							num = (short)332333080;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_543;
					case 20:
						num = (short)1956446229;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						if (this.a != null)
						{
							num = (short)64225288;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 22:
						goto IL_39E;
					case 23:
						num = (short)1451950082;
						num2 = (int)((IntPtr)num);
						continue;
					case 24:
						num = (short)41418758;
						num2 = (int)((IntPtr)num);
						continue;
					case 25:
						if (this.MyRecordsetDataSource.HideRecordsFromTree)
						{
							num = (short)1905066011;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_215;
					case 26:
						num = (short)465960985;
						num2 = (int)((IntPtr)num);
						continue;
					case 27:
						goto IL_443;
					case 28:
					{
						num = (short)815202304;
						short num4 = num;
						if (this.TableMode && value)
						{
							num = (short)2059272212;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 29:
						num = (short)1170604049;
						num2 = (int)((IntPtr)num);
						continue;
					case 30:
						if (!this.MyRecordsetDataSource.IsEmbeddedRecset)
						{
							num = (short)2073296922;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_443;
					case 31:
						recordPresenter = RecordPresenter.FromRecord(this.a.ActiveRecord);
						num = (short)596377600;
						num2 = (int)((IntPtr)num);
						continue;
					case 32:
						num = (short)226361353;
						num2 = (int)((IntPtr)num);
						continue;
					case 33:
						this.SubscribeToDataPresenterEvents(this.a);
						this.SelectAndActivateCurrentViewRecord();
						num = (short)116654099;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_AD:
					if (this.TableMode)
					{
						num = (short)9109509;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3CC;
					IL_215:
					base.SetValue(AcpRecNavToolbar.TableModeProperty, value);
					num = (short)540147740;
					num2 = (int)((IntPtr)num);
					continue;
					IL_36C:
					num = (short)818675727;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3CC:
					num = (short)1972174858;
					num2 = (int)((IntPtr)num);
					continue;
					IL_443:
					this.i.Visibility = Visibility.Visible;
					this.p.Visibility = Visibility.Collapsed;
					num = (short)1771569163;
					num2 = (int)((IntPtr)num);
					continue;
					IL_543:
					this.i.Visibility = Visibility.Collapsed;
					this.p.Visibility = Visibility.Visible;
					num = (short)755433476;
					num2 = (int)((IntPtr)num);
				}
				IL_39E:
				recordPresenter.Focus();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000081FC File Offset: 0x000063FC
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000082A8 File Offset: 0x000064A8
		public string SMaxVal
		{
			get
			{
				short num = (short)1026483127;
				short num2 = num;
				num = (short)1962992567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174929408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)889782273;
				if (num != 0)
				{
				}
				num = (short)802226176;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				int a_ = 11;
				short num = (short)1301086209;
				if (num != 0)
				{
				}
				num = (short)1711210496;
				short num2 = num;
				num = (short)124270912;
				short num3 = num;
				num = (short)1124088128;
				switch (num3 == num)
				{
				}
				num = (short)447479808;
				if (num != 0)
				{
				}
				this.g = value;
				this.RaisePropertyChanged(AcpUI.Common.Utility.c("쒤\udfa6ﾨ쪪솬", a_));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600006D RID: 109 RVA: 0x00008374 File Offset: 0x00006574
		// (remove) Token: 0x0600006E RID: 110 RVA: 0x0000842C File Offset: 0x0000662C
		public event RoutedEventHandler ModeClick
		{
			add
			{
				short num = (short)1425887804;
				short num2 = num;
				num = (short)102257212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199360512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396375552;
				if (num != 0)
				{
				}
				num = (short)1652686849;
				if (num != 0)
				{
				}
				base.AddHandler(AcpRecNavToolbar.ModeClickEvent, value);
			}
			remove
			{
				short num = (short)303548505;
				short num2 = num;
				num = (short)613599321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)211681280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1915027456;
				if (num != 0)
				{
				}
				num = (short)264175617;
				if (num != 0)
				{
				}
				base.RemoveHandler(AcpRecNavToolbar.ModeClickEvent, value);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000084E4 File Offset: 0x000066E4
		protected CollectionView GetCollectionViewForDataSource()
		{
			short num = (short)1782185984;
			short num2 = num;
			num = (short)1583037838;
			short num3 = num;
			num = (short)1005862286;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)178651137;
				if (num != 0)
				{
				}
				num = (short)889978880;
				if (num != 0)
				{
				}
				Recordset dataSource = this.GetDataSource();
				if (dataSource != null)
				{
					return (CollectionView)CollectionViewSource.GetDefaultView(dataSource);
				}
				break;
			}
			}
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000085A8 File Offset: 0x000067A8
		protected Recordset GetDataSource()
		{
			short num = (short)596830547;
			short num2 = num;
			num = (short)679536979;
			switch (num2 == num)
			{
			default:
			{
				num = (short)982056960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)548732928;
			if (num != 0)
			{
			}
			num = (short)1917124609;
			if (num != 0)
			{
			}
			return (Recordset)base.DataContext;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00008660 File Offset: 0x00006860
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00008710 File Offset: 0x00006910
		protected bool DeferToolbarUpdate
		{
			get
			{
				short num = (short)757535494;
				short num2 = num;
				num = (short)933303046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570635776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)627703809;
				if (num != 0)
				{
				}
				num = (short)1716060160;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1744437249;
				if (num != 0)
				{
				}
				num = (short)976093184;
				short num2 = num;
				num = (short)1393237695;
				short num3 = num;
				num = (short)2079727295;
				switch (num3 == num)
				{
				}
				num = (short)371982336;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000087C4 File Offset: 0x000069C4
		protected void SubscribeToRecordsetEvents(Recordset recset)
		{
			short num = (short)605487105;
			if (num != 0)
			{
			}
			num = (short)354746368;
			short num2 = num;
			num = (short)450995947;
			short num3 = num;
			num = (short)1971300075;
			switch (num3 == num)
			{
			}
			num = (short)135135232;
			if (num != 0)
			{
			}
			CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(recset);
			recset.CollectionChanged += this.OnRecsetCollectionChanged;
			collectionView.CurrentChanged += this.OnCollectionViewCurrentChanged;
			recset.SubscribeToPropertyChangedEvent(new PropertyChangedEventHandler(this.OnRecordsetPropertyChanged));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000088B0 File Offset: 0x00006AB0
		protected void UnsubscribeFromRecordsetEvents(Recordset recset)
		{
			short num = (short)1783823547;
			short num2 = num;
			num = (short)60161211;
			switch (num2 == num)
			{
			default:
			{
				num = (short)488308736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)448200705;
			if (num != 0)
			{
			}
			num = (short)240320512;
			if (num != 0)
			{
			}
			recset.CollectionChanged -= this.OnRecsetCollectionChanged;
			((CollectionView)CollectionViewSource.GetDefaultView(recset)).CurrentChanged -= this.OnCollectionViewCurrentChanged;
			recset.UnSubscribeFromPropertyChangedEvent(new PropertyChangedEventHandler(this.OnRecordsetPropertyChanged));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000899C File Offset: 0x00006B9C
		protected void SubscribeToDataPresenterEvents(AcpXamDataPresenter dataPresenter)
		{
			short num = (short)1678247839;
			short num2 = num;
			num = (short)1461323679;
			switch (num2 == num)
			{
			default:
			{
				num = (short)749993984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1116930048;
			if (num != 0)
			{
			}
			num = (short)1763246081;
			if (num != 0)
			{
			}
			dataPresenter.SelectedItemsChanged += this.OnDataPresenterSelectedItemsChanged;
			dataPresenter.Records.CollectionChanged += this.OnDataPresenterRecordsChanged;
			dataPresenter.CellActivated += this.OnDataPresenterCellActivated;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008A80 File Offset: 0x00006C80
		protected void UnsubscribeFromDataPresenterEvents(AcpXamDataPresenter dataPresenter)
		{
			short num = (short)1535597159;
			short num2 = num;
			num = (short)1121475175;
			switch (num2 == num)
			{
			default:
			{
				num = (short)301072384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)907542528;
			if (num != 0)
			{
			}
			num = (short)615186433;
			if (num != 0)
			{
			}
			dataPresenter.SelectedItemsChanged -= this.OnDataPresenterSelectedItemsChanged;
			dataPresenter.Records.CollectionChanged -= this.OnDataPresenterRecordsChanged;
			dataPresenter.CellActivated -= this.OnDataPresenterCellActivated;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00008B64 File Offset: 0x00006D64
		protected virtual bool CanMoveToFirst
		{
			get
			{
				short num;
				CollectionView collectionViewForDataSource;
				for (;;)
				{
					num = (short)567410688;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						num = (short)1735786496;
						short num3 = num;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_5D;
							}
							continue;
						case 1:
							if (collectionViewForDataSource.CurrentPosition != 0)
							{
								num = (short)768475139;
								num2 = (int)((IntPtr)num);
								continue;
							}
							return false;
						case 2:
							return false;
						case 3:
							goto IL_13C;
						}
						IL_5D:
						if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)1828847618;
							num2 = (int)((IntPtr)num);
						}
						else
						{
							collectionViewForDataSource = this.GetCollectionViewForDataSource();
							num = (short)1912078337;
							num2 = (int)((IntPtr)num);
						}
					}
					IL_13C:
					num = (short)1843945230;
					short num4 = num;
					num = (short)1450270478;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B9;
					}
				}
				return false;
				IL_B9:
				num = (short)949288961;
				if (num != 0)
				{
				}
				num = (short)1964900352;
				if (num != 0)
				{
				}
				return !collectionViewForDataSource.IsCurrentBeforeFirst;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00008CB8 File Offset: 0x00006EB8
		protected virtual bool CanMoveToLast
		{
			get
			{
				short num;
				CollectionView collectionViewForDataSource;
				for (;;)
				{
					num = (short)1067319296;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						num = (short)205586432;
						short num3 = num;
						num = (short)1964900353;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_85;
							}
							continue;
						case 1:
							if (collectionViewForDataSource.CurrentPosition != collectionViewForDataSource.Count - 1)
							{
								num = (short)1517289475;
								num2 = (int)((IntPtr)num);
								continue;
							}
							return false;
						case 2:
							return false;
						case 3:
							goto IL_146;
						}
						IL_85:
						if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)888471554;
							num2 = (int)((IntPtr)num);
						}
						else
						{
							collectionViewForDataSource = this.GetCollectionViewForDataSource();
							num = (short)1612513281;
							num2 = (int)((IntPtr)num);
						}
					}
					IL_146:
					num = (short)1861056442;
					short num4 = num;
					num = (short)540964794;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E0;
					}
				}
				return false;
				IL_E0:
				num = (short)688848896;
				if (num != 0)
				{
				}
				return !collectionViewForDataSource.IsCurrentAfterLast;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00008E14 File Offset: 0x00007014
		protected virtual bool CanAdd
		{
			get
			{
				short num = (short)1617821697;
				if (num != 0)
				{
				}
				num = (short)398000131;
				int num2 = (int)((IntPtr)num);
				Recordset dataSource;
				CollectionView collectionViewForDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)301989888;
						short num3 = num;
						if (AppInfoManager.AppMode == ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1842282510;
							num2 = (int)((IntPtr)num);
							continue;
						}
						dataSource = this.GetDataSource();
						num = (short)605028359;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						if (Permission.Have(Permissions.AddCurrentDisabled, dataSource.Permissions))
						{
							num = (short)1409155076;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_302;
					case 2:
						num = (short)1884684288;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 4:
						return false;
					case 5:
						if (Permission.Have(Permissions.AddDefaultDisabled, dataSource.Permissions))
						{
							num = (short)873529357;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 6:
						goto IL_E8;
					case 7:
						if (this.RecordTypeToAdd == 0)
						{
							num = (short)1264254985;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 8:
						if (collectionViewForDataSource != null)
						{
							num = (short)1024917519;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_179;
					case 9:
						num = (short)1482227717;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1656029523;
						short num4 = num;
						num = (short)581370195;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D1;
						default:
							num = (short)163512320;
							if (num != 0)
							{
							}
							if (this.RecordTypeToAdd == 1)
							{
								num = (short)1303642123;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_302;
						}
						break;
					}
					case 11:
						collectionViewForDataSource = this.GetCollectionViewForDataSource();
						num = (short)1576140808;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						if (collectionViewForDataSource.CurrentPosition >= 0)
						{
							goto IL_D1;
						}
						goto IL_179;
					case 13:
						return false;
					case 14:
						goto IL_21C;
					case 15:
						num = (short)437321740;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_8B:
					if (AppInfoManager.AppMode != ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1197539330;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return false;
					IL_D1:
					num = (short)2131886086;
					num2 = (int)((IntPtr)num);
					continue;
					IL_ED:
					num = (short)1624440842;
					num2 = (int)((IntPtr)num);
					continue;
					IL_179:
					num = (short)213123073;
					num2 = (int)((IntPtr)num);
				}
				IL_E8:
				return dataSource.GetCounterToMaxCopiesOf(collectionViewForDataSource.CurrentPosition) > 0;
				IL_21C:
				return false;
				IL_302:
				return dataSource.CanAdd;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000912C File Offset: 0x0000732C
		protected virtual bool CanDelete
		{
			get
			{
				short num = (short)378077184;
				switch (num)
				{
				default:
				{
					num = (short)1102774276;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return false;
						case 1:
						{
							Recordset dataSource;
							if (this.MyDataPresenter.SelectedItems.Records.Count == dataSource.Count)
							{
								num = (short)794689536;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_FF;
						}
						case 2:
						{
							if (AppInfoManager.AppMode == ApplicationMode.CodeplugComparisonMode)
							{
								num = (short)391577603;
								num2 = (int)((IntPtr)num);
								continue;
							}
							Recordset dataSource = this.GetDataSource();
							num = (short)862388234;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 3:
							goto IL_561;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_88;
							}
							continue;
						case 5:
							num = (short)891813890;
							num2 = (int)((IntPtr)num);
							continue;
						case 6:
							goto IL_51E;
						case 7:
							return false;
						case 8:
						{
							Recordset dataSource;
							if (!dataSource.CanBeEmpty)
							{
								num = (short)731447305;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_FF;
						}
						case 9:
							num = (short)933298177;
							num2 = (int)((IntPtr)num);
							continue;
						case 10:
						{
							Recordset dataSource;
							if (!dataSource.CanDelete)
							{
								num = (short)797442055;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)1468596225;
							if (num != 0)
							{
							}
							num = (short)1710030861;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 11:
						{
							Recordset dataSource;
							if (this.MyDataPresenter.Records.Count - this.MyDataPresenter.SelectedItems.Records.Count < dataSource.Min)
							{
								num = (short)1379467279;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)2001862670;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 12:
							return true;
						case 13:
							if (this.MyDataPresenter == null)
							{
								num = (short)1120206860;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)1839136776;
							num2 = (int)((IntPtr)num);
							continue;
						case 14:
						{
							if (this.MyDataPresenter.SelectedItems.Records.Count <= 0)
							{
								num = (short)1642004496;
								num2 = (int)((IntPtr)num);
								continue;
							}
							IEnumerator<Record> enumerator = this.MyDataPresenter.SelectedItems.Records.GetEnumerator();
							num = (short)1648558080;
							short num3 = num;
							num = (short)1946681350;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 15:
							return false;
						case 16:
							return false;
						}
						IL_88:
						if (AppInfoManager.AppMode != ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)1199570949;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return false;
						IL_FF:
						num = (short)382271499;
						num2 = (int)((IntPtr)num);
					}
					return false;
					IL_51E:
					try
					{
						num = (short)1910505473;
						num2 = (int)((IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1318715399;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								IL_17E:
								switch (0)
								{
								case 0:
									goto IL_1C3;
								}
								continue;
							case 2:
								if (!AppInfoManager.UndoRedoInProgress)
								{
									num = (short)2141388806;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							case 3:
								if (AppInfoManager.SkipValueSetter)
								{
									num = (short)1947467784;
									num2 = (int)((IntPtr)num);
									continue;
								}
								goto IL_21F;
							case 4:
								result = false;
								num = (short)1978073098;
								num2 = (int)((IntPtr)num);
								continue;
							case 5:
							{
								IEnumerator<Record> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1212284928;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IAcpFeatureNode acpFeatureNode = ((DataRecord)enumerator.Current).DataItem as IAcpFeatureNode;
								num = (short)981925891;
								num2 = (int)((IntPtr)num);
								continue;
							}
							case 6:
								num = (short)1779630089;
								num2 = (int)((IntPtr)num);
								continue;
							case 7:
								goto IL_397;
							case 8:
								num = (short)1524105228;
								num2 = (int)((IntPtr)num);
								continue;
							case 9:
							{
								IAcpFeatureNode acpFeatureNode;
								if (Permission.Have(Permissions.Undeletable, acpFeatureNode.Permissions))
								{
									num = (short)1785921540;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								goto IL_1E0;
							case 11:
								goto IL_21F;
							case 12:
								if (!AppInfoManager.DropOperation)
								{
									num = (short)195756043;
									num2 = (int)((IntPtr)num);
									continue;
								}
								break;
							}
							IL_343:
							num = (short)1945698309;
							num2 = (int)((IntPtr)num);
							continue;
							IL_1C3:
							goto IL_343;
							IL_21F:
							num = (short)1306909108;
							short num4 = num;
							num = (short)2077678004;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17E;
							default:
								num = (short)614727680;
								if (num != 0)
								{
								}
								num = (short)1638137858;
								num2 = (int)((IntPtr)num);
								break;
							}
						}
						IL_1E0:
						return result;
						IL_397:
						return true;
					}
					finally
					{
						num = (short)1550057474;
						num2 = (int)((IntPtr)num);
						for (;;)
						{
							IEnumerator<Record> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)703528961;
								num2 = (int)((IntPtr)num);
								continue;
							case 1:
								goto IL_405;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_3CF;
								}
								continue;
							}
							IL_3CF:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1826095104;
							num2 = (int)((IntPtr)num);
						}
						IL_405:;
					}
					return false;
					IL_561:
					return false;
				}
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000974C File Offset: 0x0000794C
		protected virtual bool CanGoTo
		{
			get
			{
				short num;
				if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)453304437;
					short num2 = num;
					num = (short)188342389;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)941621248;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1437859840;
					short num3 = num;
					return false;
				}
				num = (short)469499905;
				if (num != 0)
				{
				}
				return this.GetCollectionViewForDataSource().Count > 1;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00009810 File Offset: 0x00007A10
		protected virtual bool CanAddMultiple
		{
			get
			{
				short num = (short)2007236610;
				int num2 = (int)((IntPtr)num);
				Recordset dataSource;
				for (;;)
				{
					CollectionView collectionViewForDataSource;
					switch (num2)
					{
					case 0:
						if (collectionViewForDataSource.CurrentPosition >= 0)
						{
							num = (short)1633681423;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 1:
						if (AppInfoManager.AppMode == ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)965935111;
							num2 = (int)((IntPtr)num);
							continue;
						}
						dataSource = this.GetDataSource();
						num = (short)2090270740;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 3:
					{
						num = (short)557645824;
						short num3 = num;
						IAcpFeatureNode acpFeatureNode = (FeatureNode)dataSource[this.MyDataPresenter.ActiveRecord.Index];
						num = (short)1942421523;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						collectionViewForDataSource = this.GetCollectionViewForDataSource();
						num = (short)107347985;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						num = (short)323026956;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						if (this.MyDataPresenter.ActiveRecord != null)
						{
							num = (short)1777991698;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					case 7:
						goto IL_38A;
					case 8:
					{
						num = (short)1886894186;
						short num4 = num;
						num = (short)419477610;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_235;
						default:
							num = (short)1798963200;
							if (num != 0)
							{
							}
							num = (short)875102208;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)1903951873;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						num = (short)1707343885;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						return false;
					case 12:
						if (dataSource.Count > this.MyDataPresenter.ActiveRecord.Index)
						{
							num = (short)1796276227;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					case 13:
					{
						IAcpFeatureNode acpFeatureNode;
						if (Permission.Have(Permissions.AddCurrentDisabled, acpFeatureNode.Permissions))
						{
							num = (short)1703477259;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					}
					case 14:
						num = (short)1057357830;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						num = (short)998047760;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						if (dataSource.GetCounterToMaxCopiesOf(collectionViewForDataSource.CurrentPosition) > 0)
						{
							num = (short)2083454977;
							if (num != 0)
							{
							}
							num = (short)133693454;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return false;
					case 17:
						goto IL_235;
					case 18:
						num = (short)1910964245;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
					{
						IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode != null)
						{
							num = (short)786366474;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					}
					case 20:
						if (this.RecordTypeToAdd == 1)
						{
							num = (short)675872772;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 21:
						if (this.MyDataPresenter.ActiveRecord.Index != -1)
						{
							num = (short)2101280773;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return true;
					}
					IL_7D:
					if (AppInfoManager.AppMode != ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1346043913;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_235:
					if (collectionViewForDataSource == null)
					{
						goto IL_3FB;
					}
					num = (short)667680776;
					num2 = (int)((IntPtr)num);
				}
				return false;
				IL_38A:
				return false;
				IL_3FB:
				return dataSource.CanAdd;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00009C20 File Offset: 0x00007E20
		protected virtual bool CanSelectAddMode
		{
			get
			{
				short num = (short)868548611;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_138;
					case 1:
					{
						num = (short)391103057;
						short num3 = num;
						num = (short)2048508497;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_88;
						default:
						{
							num = (short)1975975936;
							short num4 = num;
							num = (short)889323520;
							if (num != 0)
							{
							}
							if (this.GetCollectionViewForDataSource().Count == 0)
							{
								num = (short)1984233472;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_183;
						}
						}
						break;
					}
					case 2:
						if (AppInfoManager.AppMode == ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1921122308;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_88;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 4:
						goto IL_178;
					case 5:
						num = (short)115474433;
						if (num != 0)
						{
						}
						num = (short)2010185730;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_3C:
					if (AppInfoManager.AppMode != ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)34603013;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return false;
					IL_88:
					num = (short)38207489;
					num2 = (int)((IntPtr)num);
				}
				IL_138:
				this.RecordTypeToAdd = 0;
				return false;
				IL_178:
				return false;
				IL_183:
				return this.GetDataSource().CanAdd;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00009DBC File Offset: 0x00007FBC
		protected virtual bool CanEnableCurrentRecord
		{
			get
			{
				short num = (short)82860894;
				short num2 = num;
				num = (short)1793284958;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)900333568;
					if (num != 0)
					{
					}
					num = (short)1503461379;
					int num3 = (int)((IntPtr)num);
					for (;;)
					{
						num = (short)1558511616;
						short num4 = num;
						switch (num3)
						{
						case 0:
							num = (short)1087897601;
							num3 = (int)((IntPtr)num);
							continue;
						case 1:
							if (AppInfoManager.AppMode == ApplicationMode.CodeplugComparisonMode)
							{
								num = (short)1256456194;
								num3 = (int)((IntPtr)num);
								continue;
							}
							return true;
						case 2:
							goto IL_129;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						}
						IL_A9:
						if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
						{
							return false;
						}
						num = (short)2051997697;
						if (num != 0)
						{
						}
						num = (short)1347551232;
						num3 = (int)((IntPtr)num);
					}
					return true;
				}
				}
				return false;
				IL_129:
				return false;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00009EF8 File Offset: 0x000080F8
		protected virtual bool CanChangeMode
		{
			get
			{
				if (AppInfoManager.AppMode == ApplicationMode.CustomViewConfigurationMode)
				{
					short num = (short)2045995179;
					short num2 = num;
					num = (short)456485035;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)910098433;
						if (num != 0)
						{
						}
						num = (short)15073280;
						if (num != 0)
						{
						}
						num = (short)1756889088;
						short num3 = num;
						break;
					}
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009FB0 File Offset: 0x000081B0
		internal virtual void OnRecNavChangeModeClick(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)681864347;
			short num2 = num;
			num = (short)55995547;
			switch (num2 == num)
			{
			}
			num = (short)491061248;
			short num3 = num;
			num = (short)638713856;
			if (num != 0)
			{
			}
			num = (short)948633601;
			if (num != 0)
			{
			}
			this.UpdateChangeModeButton();
			base.RaiseEvent(new RoutedEventArgs(AcpRecNavToolbar.ModeClickEvent));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000A074 File Offset: 0x00008274
		protected virtual void OnClick(object sender, RoutedEventArgs e)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_99;
			}
			int num;
			short num2;
			uint num3;
			string name;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1260257302;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					if (num3 != 3095855326U)
					{
						num2 = (short)702021647;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1642201117;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab쒯\udcb1쒵\uddb7첹햻톽떿뇁", a_)))
					{
						num2 = (short)414777371;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_331;
				case 3:
					if (num3 <= 2911352448U)
					{
						num2 = (short)1366949911;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)904265744;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					if (num3 <= 1629929263U)
					{
						num2 = (short)1157824512;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1391198211;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					return;
				case 6:
					if (num3 != 568589477U)
					{
						num2 = (short)249954324;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1019543565;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					return;
				case 8:
					return;
				case 9:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab쒯\udcb1\udfb5쪷즹좻", a_)))
					{
						num2 = (short)2128085010;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_208;
				case 10:
					num2 = (short)887029791;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					if (num3 != 1629929263U)
					{
						num2 = (short)1516240908;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1617362946;
					num = (int)((IntPtr)num2);
					continue;
				case 12:
					return;
				case 13:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab쒯\udcb1펵풷\udfb9좻\udbbd", a_)))
					{
						num2 = (short)1763377180;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_5DB;
				case 14:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab쒯\udcb1\ud9b5햹", a_)))
					{
						num2 = (short)417464325;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_5D2;
				case 15:
					return;
				case 16:
					if (num3 != 3081911153U)
					{
						num2 = (short)1202585625;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)361562126;
					num = (int)((IntPtr)num2);
					continue;
				case 17:
					return;
				case 18:
					return;
				case 19:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab풯횱靈쎵풷캹햻캽겿ꟁ", a_)))
					{
						num2 = (short)177602568;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 20:
					num2 = (short)326959115;
					num = (int)((IntPtr)num2);
					continue;
				case 21:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab쒯\udcb1荒펵삷캹", a_)))
					{
						num2 = (short)1063059463;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_21E;
				case 22:
					if (num3 != 465648375U)
					{
						num2 = (short)575537178;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)586612757;
					num = (int)((IntPtr)num2);
					continue;
				case 23:
					num2 = (short)66715678;
					num = (int)((IntPtr)num2);
					continue;
				case 24:
					return;
				case 25:
					goto IL_513;
				case 26:
				{
					num2 = (short)645070848;
					short num4 = num2;
					num2 = (short)1855979526;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 27:
					return;
				case 28:
					return;
				case 29:
					if (!(name == AcpUI.Common.Utility.c("솣얥쮩\udaab쒯\udcb1ힵ쮷캹", a_)))
					{
						num2 = (short)1742471185;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_213;
				case 30:
				{
					if (num3 != 2483301065U)
					{
						num2 = (short)701038602;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1931190625;
					short num5 = num2;
					num2 = (short)755802465;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_513;
					default:
						num2 = (short)1787363328;
						if (num2 != 0)
						{
						}
						num2 = (short)1419640851;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 31:
					if (num3 != 2911352448U)
					{
						num2 = (short)226295832;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1368326153;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_99;
				IL_513:
				num2 = (short)1023475713;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_208:
			this.OnRecNavBtnFirstClick(sender, e);
			return;
			IL_213:
			this.OnRecNavBtnLastClick(sender, e);
			return;
			IL_21E:
			this.OnRecNavBtnNextClick(sender, e);
			return;
			IL_227:
			this.OnRecNavBtnAddMultipleClick(sender, e);
			return;
			IL_331:
			num2 = (short)914161665;
			if (num2 != 0)
			{
			}
			this.OnRecNavBtnPreviousClick(sender, e);
			return;
			IL_5D2:
			this.OnRecNavBtnGoToClick(sender, e);
			return;
			IL_5DB:
			this.OnRecNavBtnDeleteClick(sender, e);
			return;
			IL_99:
			name = ((AcpButton)sender).Name;
			num3 = global::d.a(name);
			num2 = (short)1604386820;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000A664 File Offset: 0x00008864
		protected virtual void OnRecNavBtnFirstClick(object sender, RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				CollectionView collectionViewForDataSource;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.MyDataPresenter.BringRecordIntoView(collectionViewForDataSource.CurrentPosition);
						num2 = (short)313524225;
						num = (int)((IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
					{
						if (this.MyDataPresenter == null)
						{
							return;
						}
						num2 = (short)324206592;
						short num3 = num2;
						num2 = (short)1702328441;
						short num4 = num2;
						num2 = (short)1987737721;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)328007680;
							if (num2 != 0)
							{
							}
							num2 = (short)1614348289;
							if (num2 != 0)
							{
							}
							num2 = (short)1171718144;
							num = (int)((IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				collectionViewForDataSource = this.GetCollectionViewForDataSource();
				collectionViewForDataSource.MoveCurrentToFirst();
				num2 = (short)1912864770;
				num = (int)((IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000A7A0 File Offset: 0x000089A0
		protected virtual void OnRecNavBtnPreviousClick(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			CollectionView collectionViewForDataSource;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					if (this.MyDataPresenter == null)
					{
						return;
					}
					num2 = (short)2096889856;
					short num3 = num2;
					num2 = (short)894087989;
					short num4 = num2;
					num2 = (short)705606453;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
						num2 = (short)477626369;
						if (num2 != 0)
						{
						}
						num2 = (short)894042112;
						if (num2 != 0)
						{
						}
						num2 = (short)2120286210;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_FE;
				}
				goto IL_1C;
				IL_FE:
				this.MyDataPresenter.BringRecordIntoView(collectionViewForDataSource.CurrentPosition);
				num2 = (short)1285488640;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_1C:
			collectionViewForDataSource = this.GetCollectionViewForDataSource();
			collectionViewForDataSource.MoveCurrentToPrevious();
			num2 = (short)1947271169;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		protected virtual void OnRecNavBtnNextClick(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			CollectionView collectionViewForDataSource;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)42598400;
					short num3 = num2;
					if (this.MyDataPresenter == null)
					{
						return;
					}
					num2 = (short)226257462;
					short num4 = num2;
					num2 = (short)491219510;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num2 = (short)1963393024;
						if (num2 != 0)
						{
						}
						num2 = (short)1581711362;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_FD;
				}
				goto IL_1C;
				IL_FD:
				this.MyDataPresenter.BringRecordIntoView(collectionViewForDataSource.CurrentPosition);
				num2 = (short)486014976;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)335806465;
			if (num2 != 0)
			{
			}
			collectionViewForDataSource = this.GetCollectionViewForDataSource();
			collectionViewForDataSource.MoveCurrentToNext();
			num2 = (short)764542977;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000AA0C File Offset: 0x00008C0C
		protected virtual void OnRecNavBtnLastClick(object sender, RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			CollectionView collectionViewForDataSource;
			for (;;)
			{
				IL_0A:
				num = (short)2138767361;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1687945216;
					short num3 = num;
					if (this.MyDataPresenter == null)
					{
						return;
					}
					num = (short)1352566482;
					short num4 = num;
					num = (short)2017756882;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num = (short)2029715456;
						if (num != 0)
						{
						}
						num = (short)1968832514;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_101;
				}
				goto IL_43;
				IL_101:
				this.MyDataPresenter.BringRecordIntoView(collectionViewForDataSource.CurrentPosition);
				num = (short)359596032;
				num2 = (int)((IntPtr)num);
			}
			return;
			IL_43:
			collectionViewForDataSource = this.GetCollectionViewForDataSource();
			collectionViewForDataSource.MoveCurrentToLast();
			num = (short)1767768065;
			num2 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000AB48 File Offset: 0x00008D48
		protected virtual void OnRecNavBtnGoToClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1512701952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				int goToRecNum;
				int count;
				CollectionView collectionViewForDataSource;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						if (goToRecNum > count)
						{
							num = (short)2121596931;
							num2 = (int)((IntPtr)num);
							continue;
						}
						int num3 = goToRecNum - 1;
						collectionViewForDataSource.MoveCurrentToPosition(num3);
						num = (short)629276674;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)266797057;
						if (num != 0)
						{
						}
						if (this.MyDataPresenter == null)
						{
							return;
						}
						num = (short)574896693;
						short num4 = num;
						num = (short)222968373;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E4;
						default:
							num = (short)1192296448;
							if (num != 0)
							{
							}
							num = (short)1479213062;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_1E4;
					case 4:
						num = (short)1850671104;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						if (goToRecNum >= 1)
						{
							num = (short)1478492164;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_157;
					case 6:
					{
						int num3;
						this.MyDataPresenter.BringRecordIntoView(num3);
						num = (short)1212612609;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_4A;
				}
				IL_157:
				num = (short)1092485120;
				short num5 = num;
				string message = AcpResources.Please_Enter_Number.AcpStringFormat(new object[]
				{
					count
				});
				AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, message);
				return;
				IL_1E4:
				goto IL_157;
				IL_4A:
				goToRecNum = this.GoToRecNum;
				collectionViewForDataSource = this.GetCollectionViewForDataSource();
				count = collectionViewForDataSource.Count;
				num = (short)611319813;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000AD64 File Offset: 0x00008F64
		protected virtual void OnRecNavBtnAddMultipleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)370540544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				int addMultQty;
				int num3;
				Recordset dataSource;
				CollectionView collectionViewForDataSource;
				string message;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_1E0;
					case 1:
						goto IL_334;
					case 2:
						if (addMultQty == 0)
						{
							num = (short)580059143;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1604190211;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						if (addMultQty <= num3)
						{
							num = (short)613548050;
							num2 = (int)((IntPtr)num);
							continue;
						}
						dataSource.AddMultipleDefaultRecords(num3);
						num = (short)1941241856;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
					{
						int currentPosition;
						dataSource.AddMultipleCopiesOf(addMultQty, currentPosition);
						num = (short)1136525329;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1A5;
					case 6:
					{
						if (addMultQty <= num3)
						{
							num = (short)377749508;
							num2 = (int)((IntPtr)num);
							continue;
						}
						int currentPosition;
						dataSource.AddMultipleCopiesOf(num3, currentPosition);
						num = (short)1143210008;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 7:
						goto IL_2C6;
					case 8:
						goto IL_1E0;
					case 9:
					{
						int currentPosition;
						if (currentPosition >= 0)
						{
							num = (short)124059661;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num3 = dataSource.CounterToMax;
						num = (short)2077491221;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						if (this.RecordTypeToAdd == 0)
						{
							num = (short)24707092;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_197;
					case 11:
					{
						if (this.RecordTypeToAdd == 0)
						{
							num = (short)1800470543;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1597243393;
						if (num != 0)
						{
						}
						int currentPosition = collectionViewForDataSource.CurrentPosition;
						num = (short)710541321;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 12:
						num = (short)496959498;
						num2 = (int)((IntPtr)num);
						continue;
					case 13:
					{
						int currentPosition;
						num3 = dataSource.GetCounterToMaxCopiesOf(currentPosition);
						num = (short)123011077;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
						if (addMultQty > num3)
						{
							num = (short)236257296;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 15:
						num3 = dataSource.CounterToMax;
						num = (short)182321154;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						message = AcpResources.Unable_to_Add_Recs.AcpStringFormat(new object[]
						{
							dataSource.UIName
						});
						AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, message);
						num = (short)163577857;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						goto IL_1E0;
					case 18:
					{
						num = (short)2093538169;
						short num4 = num;
						num = (short)1644288889;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4DC;
						default:
							num = (short)1393885184;
							if (num != 0)
							{
							}
							dataSource.AddMultipleDefaultRecords(addMultQty);
							num = (short)1826553864;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						if (addMultQty == 0)
						{
							num = (short)1297743894;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)312606726;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						goto IL_3D8;
					case 21:
						goto IL_4DC;
					case 22:
						goto IL_1DB;
					case 23:
						if (addMultQty == 1)
						{
							num = (short)375783436;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1133117451;
						num2 = (int)((IntPtr)num);
						continue;
					case 24:
						goto IL_1E0;
					}
					goto IL_93;
					IL_1A5:
					num = (short)94109715;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4DC:
					goto IL_1A5;
					IL_1E0:
					num = (short)1924726798;
					num2 = (int)((IntPtr)num);
				}
				IL_197:
				dataSource.AddCopyOf(collectionViewForDataSource.CurrentPosition);
				return;
				IL_1DB:
				message = AcpResources.Please_Enter_Number.AcpStringFormat(new object[]
				{
					num3
				});
				AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, message);
				return;
				IL_2C6:
				message = AcpResources.Please_Enter_Number.AcpStringFormat(new object[]
				{
					num3
				});
				AppInfoManager.StatusMsgReport.RegisterMessage(StatusMsgType.Error, message);
				return;
				IL_334:
				num = (short)1091633152;
				short num5 = num;
				return;
				IL_3D8:
				dataSource.AddDefaultRecord();
				return;
				IL_93:
				collectionViewForDataSource = this.GetCollectionViewForDataSource();
				dataSource = this.GetDataSource();
				addMultQty = this.AddMultQty;
				num = (short)1150615575;
				num2 = (int)((IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000B278 File Offset: 0x00009478
		protected virtual void OnTableModeDeleteClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1291190272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				Recordset dataSource;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (this.MyDataPresenter.Records.Count == 0)
						{
							num = (short)1130364938;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						try
						{
							num = (short)48824323;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									IEnumerator<Record> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)920453124;
										num2 = (int)((IntPtr)num);
										continue;
									}
									Record record = enumerator.Current;
									SortedList<int, FeatureNode> sortedList;
									sortedList.Add(record.Index, (FeatureNode)dataSource[record.Index]);
									num = (short)162594818;
									num2 = (int)((IntPtr)num);
									continue;
								}
								case 1:
									goto IL_230;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_19F;
									}
									continue;
								case 4:
									num = (short)1571225601;
									num2 = (int)((IntPtr)num);
									continue;
								}
								IL_1A1:
								num = (short)1258684416;
								num2 = (int)((IntPtr)num);
								continue;
								IL_19F:
								goto IL_1A1;
							}
							IL_230:
							goto IL_3C1;
						}
						finally
						{
							num = (short)885194753;
							num2 = (int)((IntPtr)num);
							for (;;)
							{
								IEnumerator<Record> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2F1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_269;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)414099466;
									short num3 = num;
									num = (short)2136647690;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_26F;
									default:
										num = (short)472973312;
										if (num != 0)
										{
										}
										num = (short)109445120;
										num2 = (int)((IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_269;
								IL_26F:
								num = (short)1552220162;
								num2 = (int)((IntPtr)num);
								continue;
								IL_269:
								if (enumerator != null)
								{
									goto IL_26F;
								}
								break;
							}
							IL_2F1:;
						}
						goto IL_2F4;
						IL_3C1:
						int num4 = 0;
						num = (short)180879367;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
					{
						SortedList<int, FeatureNode> sortedList;
						int num4;
						if (num4 >= sortedList.Values.Count)
						{
							num = (short)687865860;
							num2 = (int)((IntPtr)num);
							continue;
						}
						FeatureNode[] array;
						array[num4] = sortedList.Values[sortedList.Values.Count - num4 - 1];
						num4++;
						num = (short)2038300678;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 3:
					{
						FeatureNode[] array = new FeatureNode[this.MyDataPresenter.SelectedItems.Records.Count];
						SortedList<int, FeatureNode> sortedList = new SortedList<int, FeatureNode>(array.Length);
						IEnumerator<Record> enumerator = this.MyDataPresenter.SelectedItems.Records.GetEnumerator();
						num = (short)1590755329;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
					{
						FeatureNode[] array;
						dataSource.RemoveMultipleRecords(array);
						num = (short)492896261;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2F4;
					case 6:
						goto IL_11C;
					case 7:
						num = (short)696057857;
						if (num != 0)
						{
						}
						goto IL_11C;
					case 8:
						goto IL_2F4;
					case 9:
					{
						if (this.MyDataPresenter.SelectedItems.Records.Count > 1)
						{
							num = (short)821755907;
							num2 = (int)((IntPtr)num);
							continue;
						}
						Record record2 = this.MyDataPresenter.SelectedItems.Records[0];
						dataSource.RemoveRecordAt(record2.Index);
						num = (short)279576584;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
						goto IL_33A;
					}
					goto IL_5A;
					IL_11C:
					num = (short)870580226;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2F4:
					num = (short)592969728;
					num2 = (int)((IntPtr)num);
				}
				IL_33A:
				this.Update(UpdateToolbarEventType.RecordOperation);
				return;
				IL_5A:
				num = (short)580845568;
				short num5 = num;
				dataSource = this.GetDataSource();
				num = (short)440664073;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000B6E0 File Offset: 0x000098E0
		protected virtual void OnSingleRecordModeDeleteClick(object sender, RoutedEventArgs e)
		{
			short num = (short)11943615;
			short num2 = num;
			num = (short)1850818239;
			switch (num2 == num)
			{
			default:
			{
				num = (short)316932096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)419495937;
			if (num != 0)
			{
			}
			num = (short)396689408;
			if (num != 0)
			{
			}
			Recordset dataSource = this.GetDataSource();
			CollectionView collectionViewForDataSource = this.GetCollectionViewForDataSource();
			dataSource.RemoveRecordAt(collectionViewForDataSource.CurrentPosition);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000B7A0 File Offset: 0x000099A0
		protected virtual void OnRecNavBtnDeleteClick(object sender, RoutedEventArgs e)
		{
			short num = (short)449839109;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B7;
				case 1:
					return;
				case 2:
					if (this.TableMode)
					{
						num = (short)1510604806;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_B7;
				case 4:
					this.OnTableModeDeleteClick(sender, e);
					num = (short)1886060547;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1220345857;
					if (num != 0)
					{
					}
					num = (short)306905088;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				}
				case 6:
				{
					num = (short)1582512542;
					short num4 = num;
					num = (short)429537694;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2074804224;
						if (num != 0)
						{
						}
						break;
					}
					this.SelectAndActivateCurrentViewRecord();
					num = (short)1565917185;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_91:
				if (this.TableMode)
				{
					num = (short)339148804;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.OnSingleRecordModeDeleteClick(sender, e);
				num = (short)448069632;
				num2 = (int)((IntPtr)num);
				continue;
				IL_B7:
				num = (short)1264517122;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000B950 File Offset: 0x00009B50
		public void SyncDataSources()
		{
			short num = (short)1325858816;
			switch (num)
			{
			default:
			{
				num = (short)360775688;
				int num2 = (int)((IntPtr)num);
				IAcpFeatureNode acpFeatureNode;
				int num4;
				CollectionView collectionView2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_280;
					case 1:
						num = (short)786038795;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						acpFeatureNode = null;
						num = (short)1815543822;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
					{
						num = (short)659881984;
						short num3 = num;
						IAcpFeatureNode acpFeatureNode2;
						if (acpFeatureNode2 != null)
						{
							num = (short)590938116;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1B3;
					}
					case 4:
						num = (short)274399242;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						if (acpFeatureNode != null)
						{
							num = (short)2035154961;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_118;
					case 6:
						if (this.MySecondaryRecordsetDataSource != null)
						{
							num = (short)1821376528;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 7:
						num = (short)388104198;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_9C;
						}
						continue;
					case 9:
					{
						IAcpFeatureNode acpFeatureNode2;
						acpFeatureNode = this.MySecondaryRecordsetDataSource.NodeFromKey(acpFeatureNode2.ReferenceKey);
						num = (short)2140078100;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 10:
					{
						IAcpFeatureNode acpFeatureNode2;
						if (acpFeatureNode2.Parent.HasKeyField)
						{
							num = (short)1722810370;
							num2 = (int)((IntPtr)num);
							continue;
						}
						CollectionView collectionView;
						num4 = collectionView.IndexOf(acpFeatureNode2);
						num = (short)544407573;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 11:
						if (this.GetDataSource() != null)
						{
							num = (short)411893767;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (collectionView2 != null)
						{
							num = (short)91291667;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 13:
						num = (short)1074790412;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						num = (short)606535681;
						if (num != 0)
						{
						}
						if (this.MySecondaryRecordsetDataSource.Count > 0)
						{
							num = (short)1091305481;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2AA;
					case 15:
						goto IL_2A5;
					case 16:
					{
						CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(this.GetDataSource());
						collectionView2 = (CollectionView)CollectionViewSource.GetDefaultView(this.MySecondaryRecordsetDataSource);
						IAcpFeatureNode acpFeatureNode2 = (IAcpFeatureNode)collectionView.CurrentItem;
						num = (short)73662467;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2E1;
					case 18:
						if (this.GetDataSource().CanBeEmpty)
						{
							num = (short)1823801357;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 19:
						collectionView2.MoveCurrentToPosition(-1);
						num = (short)112721935;
						num2 = (int)((IntPtr)num);
						continue;
					case 20:
						goto IL_2AA;
					case 21:
						if (num4 < collectionView2.Count)
						{
							num = (short)211353600;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_365;
					}
					IL_9C:
					if (AppInfoManager.AppMode != ApplicationMode.CodeplugComparisonMode)
					{
						return;
					}
					num = (short)1325425567;
					short num5 = num;
					num = (short)606495647;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)722010112;
						if (num != 0)
						{
						}
						num = (short)1081671681;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_1B3:
					num = (short)1239744530;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2AA:
					num = (short)1731133445;
					num2 = (int)((IntPtr)num);
				}
				IL_118:
				collectionView2.MoveCurrentToPosition(-1);
				return;
				IL_280:
				collectionView2.MoveCurrentToPosition(num4);
				return;
				IL_2A5:
				return;
				IL_2E1:
				collectionView2.MoveCurrentTo(acpFeatureNode);
				return;
				IL_365:
				collectionView2.MoveCurrentToPosition(-1);
				return;
			}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		protected virtual void OnLoaded(object sender, RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1763573761;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						this.a();
						num = (short)888674942;
						short num3 = num;
						num = (short)1168185982;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						case 1:
							break;
						default:
						{
							num = (short)1129906176;
							short num4 = num;
							break;
						}
						}
						num = (short)2020868096;
						if (num != 0)
						{
						}
						num = (short)158334977;
						if (num != 0)
						{
						}
						num = (short)1405157376;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (base.DataContext == null)
					{
						goto IL_10E;
					}
					num = (short)1771372546;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_10C:
			IL_10E:
			this.i.Visibility = Visibility.Collapsed;
			this.p.Visibility = Visibility.Visible;
			this.t.Visibility = Visibility.Visible;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		protected virtual void OnUnloaded(object sender, RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)766836737;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_123;
					case 1:
						num = (short)1744568321;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					case 2:
					{
						base.DataContextChanged -= this.OnDataContextChanged;
						this.UnsubscribeFromRecordsetEvents(this.GetDataSource());
						num = (short)859176960;
						short num3 = num;
						num = (short)1885984685;
						short num4 = num;
						num = (short)1772738477;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)398262272;
							if (num != 0)
							{
							}
							num = (short)215875584;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_56:
					if (base.DataContext == null)
					{
						goto IL_125;
					}
					num = (short)1096613890;
					num2 = (int)((IntPtr)num);
				}
			}
			IL_123:
			IL_125:
			this.MyDataPresenter = null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000C034 File Offset: 0x0000A234
		private void OnLostFocus(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			AcpTextBox acpTextBox;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (acpTextBox.Name == AcpUI.Common.Utility.c("\udca3튥\udfa9솫節\udfaf킳튵", a_))
					{
						num2 = (short)1703608325;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_178;
				case 1:
					if (acpTextBox.Value == "")
					{
						num2 = (short)2139553800;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (acpTextBox.Name == AcpUI.Common.Utility.c("\udca3튥얩솭", a_))
					{
						num2 = (short)2044854278;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (acpTextBox.Value == "")
					{
						num2 = (short)248381444;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_178;
				case 4:
					goto IL_20D;
				case 5:
					num2 = (short)813236227;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1070661633;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					return;
				case 8:
					this.GoToRecNum = 0;
					this.GoToRecNum = 1;
					num2 = (short)798883847;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_3D;
				IL_178:
				num2 = (short)1641742338;
				num = (int)((IntPtr)num2);
			}
			IL_20D:
			acpTextBox.Value = AcpUI.Common.Utility.c("鎡", a_);
			this.c = 0;
			this.c = 1;
			return;
			IL_3D:
			num2 = (short)1055175843;
			short num3 = num2;
			num2 = (short)323138723;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			case 1:
				break;
			default:
			{
				num2 = (short)303431680;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1545601025;
			if (num2 != 0)
			{
			}
			num2 = (short)1317011456;
			if (num2 != 0)
			{
			}
			acpTextBox = (AcpTextBox)A_0;
			num2 = (short)1210777600;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000C29C File Offset: 0x0000A49C
		protected void UpdateCurrentRecordLabel()
		{
			short num = (short)1554409917;
			short num2 = num;
			num = (short)1995532733;
			switch (num2 == num)
			{
			}
			num = (short)6094848;
			if (num != 0)
			{
			}
			num = (short)386727936;
			short num3 = num;
			num = (short)1670971393;
			if (num != 0)
			{
			}
			CollectionView collectionViewForDataSource = this.GetCollectionViewForDataSource();
			this.j.Content = AcpResources.Of_Id.AcpStringFormat(new object[]
			{
				collectionViewForDataSource.CurrentPosition + 1,
				collectionViewForDataSource.Count
			});
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000C388 File Offset: 0x0000A588
		protected void UpdateNavigationButtons()
		{
			short num = (short)694484993;
			if (num != 0)
			{
			}
			num = (short)855187513;
			short num2 = num;
			num = (short)964108345;
			switch (num2 == num)
			{
			}
			num = (short)50069504;
			short num3 = num;
			num = (short)1132658688;
			if (num != 0)
			{
			}
			this.k.IsEnabled = this.CanMoveToFirst;
			this.l.IsEnabled = this.k.IsEnabled;
			this.n.IsEnabled = this.CanMoveToLast;
			this.m.IsEnabled = this.n.IsEnabled;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000C480 File Offset: 0x0000A680
		protected void UpdateRecordOperationButtons()
		{
			short num = (short)438708748;
			short num2 = num;
			num = (short)1372072460;
			switch (num2 == num)
			{
			}
			num = (short)2074148865;
			if (num != 0)
			{
			}
			num = (short)767950848;
			short num3 = num;
			num = (short)804257792;
			if (num != 0)
			{
			}
			this.o.IsEnabled = this.CanGoTo;
			this.s.IsEnabled = this.CanDelete;
			this.r.IsEnabled = this.CanAddMultiple;
			this.q.IsEnabled = this.CanSelectAddMode;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000C56C File Offset: 0x0000A76C
		protected void UpdateChangeModeButton()
		{
			short num = (short)1228613928;
			short num2 = num;
			num = (short)1270753576;
			switch (num2 == num)
			{
			}
			num = (short)1279787008;
			if (num != 0)
			{
			}
			num = (short)1560215552;
			short num3 = num;
			num = (short)692781057;
			if (num != 0)
			{
			}
			this.u.IsEnabled = this.CanChangeMode;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000C628 File Offset: 0x0000A828
		internal void a()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1015611393;
				int num2 = (int)((IntPtr)num);
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
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)1716322305;
						if (num != 0)
						{
						}
						this.Update(UpdateToolbarEventType.ForcedUpdate);
						num = (short)1614938112;
						short num3 = num;
						num = (short)1019269154;
						short num4 = num;
						num = (short)1886703650;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1005191168;
							if (num != 0)
							{
							}
							num = (short)1317732352;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (this.DeferToolbarUpdate)
					{
						return;
					}
					num = (short)176029698;
					num2 = (int)((IntPtr)num);
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000C748 File Offset: 0x0000A948
		internal virtual void Update(UpdateToolbarEventType eventType)
		{
			short num = (short)272891904;
			short num2 = num;
			num = (short)661454849;
			if (num != 0)
			{
			}
			switch (eventType)
			{
			case UpdateToolbarEventType.Navigation:
				break;
			case UpdateToolbarEventType.RecordOperation:
				this.UpdateCurrentRecordLabel();
				this.UpdateNavigationButtons();
				this.UpdateRecordOperationButtons();
				return;
			case UpdateToolbarEventType.ModeChange:
				this.UpdateChangeModeButton();
				return;
			case UpdateToolbarEventType.ForcedUpdate:
				this.UpdateCurrentRecordLabel();
				this.UpdateNavigationButtons();
				this.UpdateRecordOperationButtons();
				this.UpdateChangeModeButton();
				return;
			default:
			{
				num = (short)2088971653;
				short num3 = num;
				num = (short)985542021;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)579338240;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			this.UpdateCurrentRecordLabel();
			this.UpdateNavigationButtons();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000C848 File Offset: 0x0000AA48
		protected virtual void OnRecordAdded(object sender, NotifyCollectionChangedEventArgs e)
		{
			short num = (short)716832769;
			if (num != 0)
			{
			}
			num = (short)983575130;
			short num2 = num;
			num = (short)104344154;
			switch (num2 == num)
			{
			}
			num = (short)1710424064;
			short num3 = num;
			num = (short)1482031104;
			if (num != 0)
			{
			}
			bool deferToolbarUpdate = this.DeferToolbarUpdate;
			this.UpdateViewCurrentPosition(e);
			this.DeferToolbarUpdate = deferToolbarUpdate;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000C904 File Offset: 0x0000AB04
		protected virtual void OnRecordDeleted(object sender, NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1183012210;
			short num2 = num;
			num = (short)1758942578;
			switch (num2 == num)
			{
			}
			num = (short)841154560;
			if (num != 0)
			{
			}
			num = (short)1512964096;
			short num3 = num;
			num = (short)1831600129;
			if (num != 0)
			{
			}
			bool deferToolbarUpdate = this.DeferToolbarUpdate;
			this.UpdateViewCurrentPosition(e);
			this.DeferToolbarUpdate = deferToolbarUpdate;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		protected virtual void OnRecordPositionMoved(object sender, NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1876552379;
			short num2 = num;
			num = (short)91089595;
			switch (num2 == num)
			{
			}
			num = (short)5242880;
			if (num != 0)
			{
			}
			num = (short)1341325312;
			short num3 = num;
			num = (short)311689217;
			if (num != 0)
			{
			}
			bool deferToolbarUpdate = this.DeferToolbarUpdate;
			this.UpdateViewCurrentPosition(e);
			this.DeferToolbarUpdate = deferToolbarUpdate;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000CA84 File Offset: 0x0000AC84
		protected virtual void UpdateViewCurrentPosition(NotifyCollectionChangedEventArgs e)
		{
			short num = (short)406061056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				Recordset dataSource;
				int position;
				NotifyCollectionChangedAction action;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_159;
					case 1:
						num = (short)1409875975;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1474953217;
						if (num != 0)
						{
						}
						if (dataSource.Count > 0)
						{
							num = (short)436731918;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)2134310912;
						short num3 = num;
						position = -1;
						num = (short)1778915208;
						short num4 = num;
						num = (short)404494216;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_212;
						default:
							num = (short)1196752896;
							if (num != 0)
							{
							}
							num = (short)1623261184;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						position = dataSource.Count - 1;
						num = (short)1307508751;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
						position = e.NewStartingIndex;
						num = (short)135331853;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						if (action == NotifyCollectionChangedAction.Add)
						{
							num = (short)696516609;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1337720841;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						if (e.OldStartingIndex >= dataSource.Count)
						{
							num = (short)360316931;
							num2 = (int)((IntPtr)num);
							continue;
						}
						position = e.OldStartingIndex;
						num = (short)920256530;
						num2 = (int)((IntPtr)num);
						continue;
					case 7:
						if (e.NewStartingIndex != -1)
						{
							num = (short)338100228;
							num2 = (int)((IntPtr)num);
							continue;
						}
						position = dataSource.Count - 1;
						num = (short)383713290;
						num2 = (int)((IntPtr)num);
						continue;
					case 8:
						goto IL_1CA;
					case 9:
						if (action == NotifyCollectionChangedAction.Remove)
						{
							num = (short)406716433;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)961019920;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						goto IL_1A6;
					case 11:
						position = e.NewStartingIndex;
						num = (short)1537671176;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_231;
					case 13:
						goto IL_1EE;
					case 14:
						num = (short)18087942;
						num2 = (int)((IntPtr)num);
						continue;
					case 15:
						goto IL_180;
					case 16:
						if (action == NotifyCollectionChangedAction.Move)
						{
							num = (short)1441792011;
							num2 = (int)((IntPtr)num);
							continue;
						}
						position = -1;
						num = (short)485228556;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						num = (short)649854978;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						goto IL_212;
					}
					goto IL_7A;
				}
				IL_159:
				IL_180:
				IL_1A6:
				IL_1CA:
				IL_1EE:
				IL_212:
				IL_231:
				CollectionView collectionViewForDataSource;
				collectionViewForDataSource.MoveCurrentToPosition(position);
				return;
				IL_7A:
				action = e.Action;
				dataSource = this.GetDataSource();
				collectionViewForDataSource = this.GetCollectionViewForDataSource();
				num = (short)734986245;
				num2 = (int)((IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000CE40 File Offset: 0x0000B040
		protected virtual void OnRecsetCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			short num = (short)256049155;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.OnRecordPositionMoved(sender, e);
					num = (short)626720772;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					num = (short)1128267786;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
				{
					num = (short)985329340;
					short num3 = num;
					num = (short)1167650492;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B8;
					default:
						num = (short)353763328;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B5;
						}
						continue;
					}
					break;
				}
				case 4:
					goto IL_140;
				case 5:
					this.OnRecordDeleted(sender, e);
					num = (short)1932132366;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					goto IL_140;
				case 7:
					if (e.Action == NotifyCollectionChangedAction.Move)
					{
						num = (short)1372848143;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_140;
				case 8:
					if (e.Action == NotifyCollectionChangedAction.Remove)
					{
						goto IL_2B8;
					}
					num = (short)1280376839;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					this.OnRecordAdded(sender, e);
					num = (short)1566310406;
					num2 = (int)((IntPtr)num);
					continue;
				case 10:
					num = (short)417398785;
					if (num != 0)
					{
					}
					if (e.Action == NotifyCollectionChangedAction.Add)
					{
						num = (short)1593507849;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)177930248;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					if (!this.DeferToolbarUpdate)
					{
						num = (short)279773200;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (e.Action == NotifyCollectionChangedAction.Move)
					{
						num = (short)1770455040;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_140;
				case 13:
					goto IL_140;
				case 14:
					goto IL_140;
				case 15:
					this.OnRecordPositionMoved(sender, e);
					num = (short)1142226957;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
				{
					this.Update(UpdateToolbarEventType.RecordOperation);
					num = (short)429785088;
					short num4 = num;
					num = (short)480575490;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_B5:
				if (!this.TableMode)
				{
					num = (short)2020802561;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)985202700;
				num2 = (int)((IntPtr)num);
				continue;
				IL_140:
				num = (short)395313163;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2B8:
				num = (short)83427333;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D164 File Offset: 0x0000B364
		protected virtual void OnCollectionViewCurrentChanged(object sender, EventArgs e)
		{
			short num = (short)285147139;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)866648065;
					if (num != 0)
					{
					}
					num = (short)796748046;
					short num3 = num;
					num = (short)1988782350;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_39;
					case 1:
						break;
					default:
					{
						num = (short)1776746496;
						short num4 = num;
						break;
					}
					}
					num = (short)1182859264;
					if (num != 0)
					{
					}
					this.DeferToolbarUpdate = true;
					this.SelectAndActivateCurrentViewRecord();
					this.DeferToolbarUpdate = false;
					num = (short)1951006722;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 1:
					this.SyncDataSources();
					this.Update(UpdateToolbarEventType.Navigation);
					num = (short)384958468;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					if (this.TableMode)
					{
						num = (short)1530462208;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				IL_39:
				if (this.DeferToolbarUpdate)
				{
					break;
				}
				num = (short)244973569;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		protected internal virtual void OnUpdate(object sender, ToolbarUpdateEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)275447809;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.Update(e.Event);
						num = (short)1486422018;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_CB;
					}
					IL_30:
					num = (short)925827073;
					if (num != 0)
					{
					}
					num = (short)849412096;
					short num3 = num;
					if (this.DeferToolbarUpdate)
					{
						return;
					}
					num = (short)1125056512;
					num2 = (int)((IntPtr)num);
				}
				IL_CB:
				num = (short)1446833340;
				short num4 = num;
				num = (short)1566502076;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_FF;
				}
			}
			IL_FF:
			num = (short)1582039040;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000D404 File Offset: 0x0000B604
		protected virtual void OnDataPresenterRecordsChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1883832334;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)418971650;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_31D;
				case 2:
					if (((RecordCollectionBase)sender).Count > 0)
					{
						num = (short)1384841234;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_31D;
				case 3:
					if (e.Action == NotifyCollectionChangedAction.Add)
					{
						num = (short)1144651796;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1811283980;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					return;
				case 6:
				{
					CollectionView collectionViewForDataSource;
					if (collectionViewForDataSource.Count > 0)
					{
						num = (short)976224281;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_31D;
				}
				case 7:
				{
					CollectionView collectionViewForDataSource;
					if (collectionViewForDataSource.CurrentPosition != -1)
					{
						num = (short)1232470032;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1668677638;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 8:
					if (e.Action == NotifyCollectionChangedAction.Reset)
					{
						num = (short)307626006;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_31D;
				case 9:
					this.Update(UpdateToolbarEventType.RecordOperation);
					goto IL_2A3;
				case 10:
					this.OnRecordPositionMoved(sender, e);
					num = (short)401473559;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					goto IL_31D;
				case 12:
					if (e.Action == NotifyCollectionChangedAction.Remove)
					{
						num = (short)1831141391;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1054146581;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					goto IL_31D;
				case 14:
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					continue;
				case 15:
					this.OnRecordDeleted(sender, e);
					num = (short)1659961345;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
					this.SelectAndActivateCurrentViewRecord();
					num = (short)175112203;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					goto IL_31D;
				case 18:
				{
					num = (short)150487400;
					short num3 = num;
					num = (short)1848197480;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A3;
					default:
					{
						num = (short)1781268480;
						if (num != 0)
						{
						}
						CollectionView collectionViewForDataSource = this.GetCollectionViewForDataSource();
						num = (short)697368576;
						short num4 = num;
						num = (short)714539015;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 19:
					if (this.CanUpdate)
					{
						num = (short)428605449;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 20:
					this.OnRecordAdded(sender, e);
					num = (short)513998861;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					if (e.Action == NotifyCollectionChangedAction.Move)
					{
						num = (short)540934154;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1892024328;
					num2 = (int)((IntPtr)num);
					continue;
				case 22:
					num = (short)2008088600;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					goto IL_31D;
				case 24:
					if (this.CanUpdate)
					{
						num = (short)1310195712;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_31D;
				case 25:
				{
					CollectionView collectionViewForDataSource;
					collectionViewForDataSource.MoveCurrentToPosition(0);
					num = (short)860815377;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_8D:
				if (this.DeferToolbarUpdate)
				{
					num = (short)965345281;
					if (num != 0)
					{
					}
					num = (short)1176109060;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)490668035;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2A3:
				num = (short)1274609669;
				num2 = (int)((IntPtr)num);
				continue;
				IL_31D:
				num = (short)1891303443;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000D878 File Offset: 0x0000BA78
		private void OnDataPresenterSelectedItemsChanged(object A_0, SelectedItemsChangedEventArgs A_1)
		{
			short num = (short)1985871876;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					CollectionView collectionViewForDataSource;
					collectionViewForDataSource.MoveCurrentToPosition(this.MyDataPresenter.ActiveRecord.Index);
					num = (short)555417603;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
				{
					CollectionView collectionViewForDataSource = this.GetCollectionViewForDataSource();
					this.DeferToolbarUpdate = true;
					num = (short)1674313729;
					if (num != 0)
					{
					}
					num = (short)52887557;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 3:
					goto IL_60;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					if (this.MyDataPresenter.ActiveRecord != null)
					{
						num = (short)578486272;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_60;
				}
				goto IL_3C;
				IL_47:
				num = (short)1810366466;
				num2 = (int)((IntPtr)num);
				continue;
				IL_60:
				this.DeferToolbarUpdate = false;
				this.Update(UpdateToolbarEventType.RecordOperation);
				num = (short)1513895763;
				short num3 = num;
				num = (short)2055026515;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_47;
				default:
				{
					num = (short)1217069056;
					if (num != 0)
					{
					}
					num = (short)650641408;
					short num4 = num;
					num = (short)1891041281;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_3C:
				if (!this.DeferToolbarUpdate)
				{
					goto IL_47;
				}
				break;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000DA30 File Offset: 0x0000BC30
		private void OnDataPresenterCellActivated(object A_0, CellActivatedEventArgs A_1)
		{
			short num = (short)413401092;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					CollectionView collectionViewForDataSource;
					collectionViewForDataSource.MoveCurrentToPosition(this.MyDataPresenter.ActiveRecord.Index);
					num = (short)1221591043;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
				{
					CollectionView collectionViewForDataSource = this.GetCollectionViewForDataSource();
					this.DeferToolbarUpdate = true;
					num = (short)817364997;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 3:
					goto IL_61;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					if (this.MyDataPresenter.ActiveRecord != null)
					{
						num = (short)378470400;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_61;
				}
				goto IL_3C;
				IL_47:
				num = (short)2057437186;
				num2 = (int)((IntPtr)num);
				continue;
				IL_61:
				this.DeferToolbarUpdate = false;
				this.Update(UpdateToolbarEventType.RecordOperation);
				num = (short)95226819;
				short num3 = num;
				num = (short)1909853123;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_47;
				default:
				{
					num = (short)284426240;
					if (num != 0)
					{
					}
					num = (short)1833566208;
					short num4 = num;
					num = (short)1386151937;
					if (num != 0)
					{
					}
					num = (short)185139201;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_3C:
				if (!this.DeferToolbarUpdate)
				{
					goto IL_47;
				}
				break;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		protected bool CanUpdate
		{
			get
			{
				short num = (short)1779957761;
				if (num != 0)
				{
				}
				if (this.GetDataSource() != null)
				{
					for (;;)
					{
						num = (short)1942498714;
						short num2 = num;
						num = (short)1986145690;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_67;
						}
					}
					IL_67:
					num = (short)1380646912;
					if (num != 0)
					{
					}
					return this.GetCollectionViewForDataSource() != null;
				}
				num = (short)1293090816;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public void Dispose()
		{
			short num = (short)2094332424;
			short num2 = num;
			num = (short)1906899464;
			switch (num2 == num)
			{
			}
			num = (short)1762918400;
			if (num != 0)
			{
			}
			num = (short)97255425;
			if (num != 0)
			{
			}
			num = (short)1358430208;
			short num3 = num;
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)119804305;
			short num2 = num;
			num = (short)1593840017;
			switch (num2 == num)
			{
			}
			num = (short)1486684161;
			if (num != 0)
			{
			}
			num = (short)1833893888;
			if (num != 0)
			{
			}
			num = (short)12845056;
			short num3 = num;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000DE08 File Offset: 0x0000C008
		private void OnAddModeSelectionChanged(object A_0, SelectionChangedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)1976041473;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)94240769;
						if (num != 0)
						{
						}
						this.Update(UpdateToolbarEventType.RecordOperation);
						num = (short)863043586;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_DA;
					}
					IL_31:
					if ((bool)DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue)
					{
						return;
					}
					num = (short)2024603648;
					short num3 = num;
					num = (short)1870921728;
					num2 = (int)((IntPtr)num);
				}
				IL_DA:
				num = (short)1860269852;
				short num4 = num;
				num = (short)430798620;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_111;
				}
			}
			IL_111:
			num = (short)999817216;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000DF40 File Offset: 0x0000C140
		protected void SelectAndActivateCurrentViewRecord()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			CollectionView collectionViewForDataSource;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					collectionViewForDataSource.MoveCurrentToFirst();
					num2 = (short)1440153603;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					num2 = (short)1844248581;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					goto IL_68;
				case 4:
					IL_43:
					if (collectionViewForDataSource.Count > 0)
					{
						num2 = (short)319619074;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (collectionViewForDataSource.CurrentPosition == -1)
					{
						num2 = (short)1110704128;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_68;
				}
				goto IL_28;
				IL_68:
				num2 = (short)107911134;
				short num3 = num2;
				num2 = (short)1307875294;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_43;
				default:
				{
					num2 = (short)1120075776;
					if (num2 != 0)
					{
					}
					num2 = (short)634191872;
					short num4 = num2;
					num2 = (short)1306656769;
					if (num2 != 0)
					{
					}
					this.SelectAndActivateRecord(collectionViewForDataSource.CurrentPosition);
					num2 = (short)434765825;
					num = (int)((IntPtr)num2);
					break;
				}
				}
			}
			return;
			IL_28:
			collectionViewForDataSource = this.GetCollectionViewForDataSource();
			num2 = (short)1448869892;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		protected void SelectAndActivateRecord(int index)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				RecordPresenter recordPresenter;
				switch (num)
				{
				case 0:
				{
					num2 = (short)64290816;
					short num3 = num2;
					if (this.MyDataPresenter.MyExpander != null)
					{
						num2 = (short)1986985995;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					if (recordPresenter != null)
					{
						num2 = (short)1736441870;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_119;
				case 2:
					this.MyDataPresenter.BringRecordIntoView(this.MyDataPresenter.Records[index]);
					num2 = (short)502857744;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
					goto IL_2DF;
				case 4:
				{
					Recordset dataSource;
					if (dataSource.LastRecordInOperation)
					{
						num2 = (short)1193803778;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 5:
					if (index >= this.MyDataPresenter.Records.Count)
					{
						num2 = (short)203292687;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_2DF;
				case 6:
				{
					num2 = (short)1909784577;
					if (num2 != 0)
					{
					}
					Recordset dataSource;
					if (dataSource != null)
					{
						num2 = (short)1472921608;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 7:
				{
					Recordset dataSource = this.GetDataSource();
					num2 = (short)757923846;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 8:
					num2 = (short)1837301764;
					num = (int)((IntPtr)num2);
					continue;
				case 9:
					if (this.MyDataPresenter.MyExpander.Visibility != Visibility.Collapsed)
					{
						num2 = (short)699269127;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 10:
					if (this.MyDataPresenter.Records.Count == 0)
					{
						num2 = (short)2089418765;
						num = (int)((IntPtr)num2);
						continue;
					}
					index = this.MyDataPresenter.Records.Count - 1;
					num2 = (short)499187715;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					goto IL_182;
				case 12:
					goto IL_119;
				case 13:
				{
					num2 = (short)1402132931;
					short num4 = num2;
					num2 = (short)1766578627;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_182;
					default:
						goto IL_1BD;
					}
					break;
				}
				case 14:
					recordPresenter.Focus();
					num2 = (short)51380236;
					num = (int)((IntPtr)num2);
					continue;
				case 15:
					num2 = (short)705101834;
					num = (int)((IntPtr)num2);
					continue;
				case 16:
					return;
				}
				goto IL_54;
				IL_119:
				num2 = (short)963182592;
				num = (int)((IntPtr)num2);
				continue;
				IL_182:
				num2 = (short)698613769;
				num = (int)((IntPtr)num2);
				continue;
				IL_2DF:
				Record record = this.MyDataPresenter.Records[index];
				record.IsActive = true;
				record.IsSelected = true;
				recordPresenter = RecordPresenter.FromRecord(record);
				num2 = (short)1420754945;
				num = (int)((IntPtr)num2);
			}
			IL_1BD:
			num2 = (short)1677262848;
			if (num2 != 0)
			{
			}
			return;
			IL_54:
			this.MyDataPresenter.SelectedItems.Records.Clear();
			num2 = (short)46530565;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000A5 RID: 165 RVA: 0x0000E478 File Offset: 0x0000C678
		// (remove) Token: 0x060000A6 RID: 166 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				short num = (short)1635456291;
				short num2 = num;
				num = (short)1070339363;
				PropertyChangedEventHandler propertyChangedEventHandler;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_109:
					if (propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						goto IL_D5;
					}
					num = (short)1828323330;
					num3 = (int)((IntPtr)num);
					break;
				default:
					num = (short)1031012352;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_109;
				case 1:
					break;
				case 2:
					return;
				default:
				{
					IL_67:
					num = (short)1036648449;
					if (num != 0)
					{
					}
					num = (short)84738048;
					short num4 = num;
					propertyChangedEventHandler = this.h;
					num = (short)338165761;
					num3 = (int)((IntPtr)num);
					goto IL_55;
				}
				}
				IL_D5:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.h, value2, propertyChangedEventHandler2);
				num = (short)1725104128;
				num3 = (int)((IntPtr)num);
				goto IL_55;
			}
			[CompilerGenerated]
			remove
			{
				short num = (short)784520024;
				short num2 = num;
				num = (short)208655192;
				PropertyChangedEventHandler propertyChangedEventHandler;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_109:
					if (propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						goto IL_D3;
					}
					num = (short)885915650;
					num3 = (int)((IntPtr)num);
					break;
				default:
					num = (short)703725569;
					if (num != 0)
					{
					}
					num = (short)1077673984;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					break;
				}
				IL_7B:
				switch (num3)
				{
				case 0:
					goto IL_109;
				case 1:
					break;
				case 2:
					return;
				default:
				{
					IL_8D:
					num = (short)595722240;
					short num4 = num;
					propertyChangedEventHandler = this.h;
					num = (short)1435828225;
					num3 = (int)((IntPtr)num);
					goto IL_7B;
				}
				}
				IL_D3:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.h, value2, propertyChangedEventHandler2);
				num = (short)292552704;
				num3 = (int)((IntPtr)num);
				goto IL_7B;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		protected void RaisePropertyChanged(string propertyName)
		{
			short num;
			for (;;)
			{
				num = (short)946798593;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.h(this, new PropertyChangedEventArgs(propertyName));
						num = (short)638976002;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_A7;
					}
					IL_30:
					if (this.h == null)
					{
						return;
					}
					num = (short)1531052032;
					short num3 = num;
					num = (short)1288568832;
					num2 = (int)((IntPtr)num);
				}
				IL_A7:
				num = (short)322527872;
				short num4 = num;
				num = (short)1487299200;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_DD;
				}
			}
			IL_DD:
			num = (short)282984449;
			if (num != 0)
			{
			}
			num = (short)674430976;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000E80C File Offset: 0x0000CA0C
		private void TxtGoToTxtNumToAdd_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)971243521;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					num = (short)1098973185;
					if (num != 0)
					{
					}
					BindingExpression bindingExpression;
					switch (num2)
					{
					case 0:
						A_1.Handled = true;
						bindingExpression.UpdateTarget();
						num = (short)403570690;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 2:
						goto IL_E1;
					}
					IL_57:
					num = (short)1620180992;
					short num3 = num;
					AcpTextBox acpTextBox = (AcpTextBox)A_0;
					bindingExpression = acpTextBox.GetBindingExpression(TextBox.TextProperty);
					int num4;
					if (int.TryParse(acpTextBox.Value, out num4))
					{
						return;
					}
					num = (short)1816723456;
					num2 = (int)((IntPtr)num);
				}
				IL_E1:
				num = (short)1967118544;
				short num5 = num;
				num = (short)50059472;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_116;
				}
			}
			IL_116:
			num = (short)101580800;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000E948 File Offset: 0x0000CB48
		private void TxtNumToAdd_MouseMove(object A_0, MouseEventArgs A_1)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			Recordset dataSource;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_16E;
				case 2:
					if (this.RecordTypeToAdd == 0)
					{
						num2 = (short)42139649;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_174;
				case 3:
				{
					num2 = (short)1925775360;
					short num3 = num2;
					num2 = (short)326255430;
					short num4 = num2;
					num2 = (short)1427325766;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1209270272;
						if (num2 != 0)
						{
						}
						if (dataSource == null)
						{
							num2 = (short)320339968;
							num = (int)((IntPtr)num2);
							continue;
						}
						break;
					}
					num2 = (short)593887234;
					num = (int)((IntPtr)num2);
					continue;
				}
				}
				goto IL_29;
			}
			return;
			IL_16E:
			num2 = (short)1903230977;
			if (num2 != 0)
			{
			}
			this.SMaxVal = AcpResources.ResourceManager.GetString(AcpUI.Common.Utility.c("삣슥\ud9ab슭쒯\udbb1쒳\udab5\uddb7ﾻ톽떿곁냃ꏅ뫇闉룋ꇍ迏鿑闓軕", a_), AcpResources.Culture) + dataSource.CounterToMax.ToString();
			return;
			IL_174:
			CollectionView collectionViewForDataSource = this.GetCollectionViewForDataSource();
			this.SMaxVal = AcpResources.ResourceManager.GetString(AcpUI.Common.Utility.c("삣슥\ud9ab슭쒯\udbb1쒳\udab5\uddb7ﾻ톽떿곁냃ꏅ뫇闉룋ꇍ迏鿑闓軕", a_), AcpResources.Culture) + dataSource.GetCounterToMaxCopiesOf(collectionViewForDataSource.CurrentPosition).ToString();
			return;
			IL_29:
			dataSource = this.GetDataSource();
			num2 = (short)331874307;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)1971174908;
			short num2 = num;
			num = (short)293387772;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1290469376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1904869376;
			if (num != 0)
			{
			}
			num = (short)1462239233;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		// Note: this type is marked as 'beforefieldinit'.
		static AcpRecNavToolbar()
		{
			int a_ = 11;
			short num = (short)545325057;
			if (num != 0)
			{
			}
			num = (short)1693581312;
			short num2 = num;
			num = (short)855439048;
			short num3 = num;
			num = (short)1805842120;
			switch (num3 == num)
			{
			}
			num = (short)1800732672;
			if (num != 0)
			{
			}
			AcpRecNavToolbar.IsAcpVisibleProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("킢쒦\ud9a8ﶪ쒬\udcae\ud8b0톲\ud9b4튶", a_), typeof(bool), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.IsAddMultQtyEnProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("킢쎦춨\ud8ac쎮얰솴캶ﲸ햺", a_), typeof(bool), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.IsDefaultMaskTypeEnProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("킢슦쾨쪪\ud8ac쎮얰ﺲ풴쒶트쒼쾾꓀蛂ꯄ", a_), typeof(bool), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.IsMaskMaxLengthEnProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("킢욦\udaa8삪캮즰ﾲ킴\ud9b6\udeb8쾺햼諭꿀", a_), typeof(bool), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.MySecondaryRecordsetDataSourceProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("\udaa2슦쪨쒪쎬쮮킰솲체\udcb8\ud8ba튼춾ꗀ냂ꃄ돆跈꫊만껎苐볒ꃔꗖ뫘뻚", a_), typeof(IAcpRecordset), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.GoToRecNumProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("첢좦ﮨ캪캬쒰\udeb2", a_), typeof(int), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.TableModeProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("슢잤쮦첨슬쮮풰", a_), typeof(bool), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.MyRecordsetDataSourceProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("\udaa2슦쪨쒪\udfac쮮슰횲솴\ud8b8쾺\udcbc껀뛂럄꓆곈", a_), typeof(IAcpRecordset), typeof(AcpRecNavToolbar), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpRecNavToolbar.ModeClickEvent = EventManager.RegisterRoutedEvent(AcpUI.Common.Utility.c("첢솤슦잪쒬첮\udab0", a_), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(AcpRecNavToolbar));
		}

		// Token: 0x04000024 RID: 36
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000025 RID: 37
		public static readonly DependencyProperty IsAddMultQtyEnProperty;

		// Token: 0x04000026 RID: 38
		public static readonly DependencyProperty IsDefaultMaskTypeEnProperty;

		// Token: 0x04000027 RID: 39
		public static readonly DependencyProperty IsMaskMaxLengthEnProperty;

		// Token: 0x04000028 RID: 40
		public static readonly DependencyProperty MySecondaryRecordsetDataSourceProperty;

		// Token: 0x04000029 RID: 41
		public static readonly DependencyProperty GoToRecNumProperty;

		// Token: 0x0400002A RID: 42
		public static readonly DependencyProperty TableModeProperty;

		// Token: 0x0400002B RID: 43
		public static readonly DependencyProperty MyRecordsetDataSourceProperty;

		// Token: 0x0400002D RID: 45
		private AcpXamDataPresenter a;

		// Token: 0x0400002E RID: 46
		private bool b;

		// Token: 0x0400002F RID: 47
		private int c;

		// Token: 0x04000030 RID: 48
		private string d;

		// Token: 0x04000031 RID: 49
		private string e;

		// Token: 0x04000032 RID: 50
		private int f;

		// Token: 0x04000033 RID: 51
		private string g;

		// Token: 0x04000034 RID: 52
		[CompilerGenerated]
		private PropertyChangedEventHandler h;
	}
}
