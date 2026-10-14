using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200007C RID: 124
	public class SelectFirmwareContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00036138 File Offset: 0x00034338
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000361E8 File Offset: 0x000343E8
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer JobContainer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)980540985;
				short num2 = num;
				num = (short)1359273529;
				switch (num2 == num)
				{
				}
				num = (short)1228996608;
				if (num != 0)
				{
				}
				num = (short)644939776;
				short num3 = num;
				num = (short)341180417;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1697503321;
				short num2 = num;
				num = (short)1116919897;
				switch (num2 == num)
				{
				}
				num = (short)651755520;
				if (num != 0)
				{
				}
				num = (short)413597696;
				short num3 = num;
				num = (short)1711407105;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00036298 File Offset: 0x00034498
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00036348 File Offset: 0x00034548
		public bool IsRecover
		{
			get
			{
				short num = (short)259972273;
				short num2 = num;
				num = (short)756997297;
				switch (num2 == num)
				{
				}
				num = (short)1729626113;
				if (num != 0)
				{
				}
				num = (short)133496832;
				short num3 = num;
				num = (short)2026307584;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)869531649;
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
							goto IL_30;
						}
						continue;
					case 2:
						num = (short)609943553;
						if (num != 0)
						{
						}
						this.a = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_IsRecover())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)607322112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)114525153;
					short num3 = num;
					num = (short)341869537;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1673003008;
						if (num != 0)
						{
						}
						if (value == this.a)
						{
							return;
						}
						num = (short)152829952;
						short num4 = num;
						num = (short)1065353218;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0003649C File Offset: 0x0003469C
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0003654C File Offset: 0x0003474C
		public bool OKCommandExecuted
		{
			get
			{
				short num = (short)1339894763;
				short num2 = num;
				num = (short)946285547;
				switch (num2 == num)
				{
				}
				num = (short)427556865;
				if (num != 0)
				{
				}
				num = (short)370278400;
				short num3 = num;
				num = (short)831848448;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)609353729;
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
							goto IL_30;
						}
						continue;
					case 2:
						this.k = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_OKCommandExecuted())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1060438016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)1158414337;
					if (num != 0)
					{
					}
					num = (short)1738266810;
					short num3 = num;
					num = (short)48486586;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)765853696;
						if (num != 0)
						{
						}
						num = (short)1403322368;
						short num4 = num;
						if (value == this.k)
						{
							return;
						}
						num = (short)2011299842;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x000366A0 File Offset: 0x000348A0
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00036750 File Offset: 0x00034950
		public bool CancelCommandExecuted
		{
			get
			{
				short num = (short)1785994969;
				short num2 = num;
				num = (short)1375477465;
				switch (num2 == num)
				{
				}
				num = (short)544538624;
				if (num != 0)
				{
				}
				num = (short)2139291648;
				short num3 = num;
				num = (short)102891521;
				if (num != 0)
				{
				}
				return this.l;
			}
			set
			{
				short num = (short)1174470657;
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
							goto IL_31;
						}
						continue;
					case 2:
						num = (short)984088577;
						if (num != 0)
						{
						}
						this.l = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_CancelCommandExecuted())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)210698240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)224959527;
					short num3 = num;
					num = (short)146250791;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1850605568;
						if (num != 0)
						{
						}
						if (value == this.l)
						{
							return;
						}
						num = (short)2025390080;
						short num4 = num;
						num = (short)1756889090;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003AB RID: 939 RVA: 0x000368A8 File Offset: 0x00034AA8
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00036958 File Offset: 0x00034B58
		public global::System.Collections.ObjectModel.ObservableCollection<string> Codeplugs
		{
			get
			{
				short num = (short)1546841699;
				short num2 = num;
				num = (short)85454435;
				switch (num2 == num)
				{
				}
				num = (short)701366273;
				if (num != 0)
				{
				}
				num = (short)898433024;
				short num3 = num;
				num = (short)1692467200;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1544486913;
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
							goto IL_31;
						}
						continue;
					case 2:
						this.b = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_Codeplugs())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1570373632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)1680998401;
					if (num != 0)
					{
					}
					num = (short)702396455;
					short num3 = num;
					num = (short)1395832871;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1146552320;
						if (num != 0)
						{
						}
						num = (short)332267520;
						short num4 = num;
						if (value == this.b)
						{
							return;
						}
						num = (short)1052508162;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00036AA8 File Offset: 0x00034CA8
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00036B54 File Offset: 0x00034D54
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> Firmwares
		{
			get
			{
				short num = (short)2038808110;
				short num2 = num;
				num = (short)1017953838;
				switch (num2 == num)
				{
				}
				num = (short)590348288;
				if (num != 0)
				{
				}
				num = (short)1424424960;
				short num3 = num;
				num = (short)245628929;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)521535489;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						this.c = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_Firmwares())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)211943424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)1146974716;
					short num3 = num;
					num = (short)973173244;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)151715840;
						if (num != 0)
						{
						}
						if (value == this.c)
						{
							goto IL_121;
						}
						num = (short)1950613504;
						short num4 = num;
						num = (short)2069495810;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_11F:
				IL_121:
				num = (short)1656619009;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00036CAC File Offset: 0x00034EAC
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00036D5C File Offset: 0x00034F5C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> FirmwaresForMaxCodeplugVersion
		{
			get
			{
				short num = (short)882889412;
				short num2 = num;
				num = (short)751293124;
				switch (num2 == num)
				{
				}
				num = (short)851378177;
				if (num != 0)
				{
				}
				num = (short)197591040;
				short num3 = num;
				num = (short)786497536;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1576534017;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2100428801;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 2:
						this.d = value;
						num = (short)293470208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_57:
					num = (short)1847594011;
					short num3 = num;
					num = (short)845941787;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1816461312;
						if (num != 0)
						{
						}
						num = (short)525467648;
						short num4 = num;
						if (value == this.d)
						{
							return;
						}
						num = (short)812515330;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00036E78 File Offset: 0x00035078
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00036F2C File Offset: 0x0003512C
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> SystemIDs
		{
			get
			{
				short num = (short)1407320060;
				short num2 = num;
				num = (short)129564668;
				switch (num2 == num)
				{
				}
				num = (short)1581514752;
				if (num != 0)
				{
				}
				num = (short)634454016;
				short num3 = num;
				num = (short)1558052865;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)192348161;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1851588609;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						this.e = value;
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_SystemIDs())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)462815232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_58:
					num = (short)1360314384;
					short num3 = num;
					num = (short)453099536;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)437911552;
						if (num != 0)
						{
						}
						num = (short)1980694528;
						short num4 = num;
						if (value == this.e)
						{
							return;
						}
						num = (short)1057554434;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00037080 File Offset: 0x00035280
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00037130 File Offset: 0x00035330
		public string SelectedCodeplug
		{
			get
			{
				short num = (short)1889468423;
				short num2 = num;
				num = (short)981532679;
				switch (num2 == num)
				{
				}
				num = (short)1738932225;
				if (num != 0)
				{
				}
				num = (short)216203264;
				short num3 = num;
				num = (short)281280512;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)172294145;
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
							goto IL_31;
						}
						continue;
					case 2:
						this.f = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_SelectedCodeplug())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1887043584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)286125314;
					short num3 = num;
					num = (short)1316941058;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)780271616;
						if (num != 0)
						{
						}
						if (!(value != this.f))
						{
							return;
						}
						num = (short)1477902336;
						short num4 = num;
						num = (short)288489473;
						if (num != 0)
						{
						}
						num = (short)1355743234;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0003728C File Offset: 0x0003548C
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00037338 File Offset: 0x00035538
		public string MaxCodeplugVersion
		{
			get
			{
				short num = (short)1204682753;
				if (num != 0)
				{
				}
				num = (short)428064414;
				short num2 = num;
				num = (short)908639902;
				switch (num2 == num)
				{
				}
				num = (short)981270528;
				short num3 = num;
				num = (short)761528320;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)123011073;
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
							goto IL_31;
						}
						continue;
					case 2:
						num = (short)2020212737;
						if (num != 0)
						{
						}
						this.g = value;
						num = (short)1794179072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_31:
					num = (short)787497526;
					short num3 = num;
					num = (short)391266870;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1552482304;
						if (num != 0)
						{
						}
						if (!(value != this.g))
						{
							return;
						}
						num = (short)751370240;
						short num4 = num;
						num = (short)623902722;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00037460 File Offset: 0x00035660
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00037514 File Offset: 0x00035714
		public global::ASK.Interface.ISystemKeyData SelectedSystemID
		{
			get
			{
				short num = (short)1481002061;
				short num2 = num;
				num = (short)956255309;
				switch (num2 == num)
				{
				}
				num = (short)1564344321;
				if (num != 0)
				{
				}
				num = (short)1405878272;
				short num3 = num;
				num = (short)489291776;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1256849409;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1689124865;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
						this.j = value;
						base.RaisePropertyChanged<global::ASK.Interface.ISystemKeyData>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::ASK.Interface.ISystemKeyData>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_SelectedSystemID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)621674496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5B:
					num = (short)1233949357;
					short num3 = num;
					num = (short)947622573;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1372389376;
						if (num != 0)
						{
						}
						num = (short)1494220800;
						short num4 = num;
						if (value == this.j)
						{
							return;
						}
						num = (short)451870722;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00037668 File Offset: 0x00035868
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00037718 File Offset: 0x00035918
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2022634695;
				short num2 = num;
				num = (short)1507587271;
				switch (num2 == num)
				{
				}
				num = (short)269942785;
				if (num != 0)
				{
				}
				num = (short)317128704;
				short num3 = num;
				num = (short)1622278144;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)878261763;
				short num2 = num;
				num = (short)1093350915;
				switch (num2 == num)
				{
				}
				num = (short)1815281664;
				if (num != 0)
				{
				}
				num = (short)1148715008;
				short num3 = num;
				num = (short)1404633089;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000377C8 File Offset: 0x000359C8
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00037878 File Offset: 0x00035A78
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> Templates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)333709313;
				if (num != 0)
				{
				}
				num = (short)627887476;
				short num2 = num;
				num = (short)1668140404;
				switch (num2 == num)
				{
				}
				num = (short)923074560;
				short num3 = num;
				num = (short)295239680;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1651594121;
				short num2 = num;
				num = (short)798446473;
				switch (num2 == num)
				{
				}
				num = (short)1598750721;
				if (num != 0)
				{
				}
				num = (short)1823932416;
				short num3 = num;
				num = (short)1488912384;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00037928 File Offset: 0x00035B28
		// (set) Token: 0x060003BE RID: 958 RVA: 0x000379D8 File Offset: 0x00035BD8
		public bool IsASKDialogVisible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)829544053;
				short num2 = num;
				num = (short)980538997;
				switch (num2 == num)
				{
				}
				num = (short)2064056321;
				if (num != 0)
				{
				}
				num = (short)794034176;
				short num3 = num;
				num = (short)1736441856;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)450098984;
				short num2 = num;
				num = (short)255653672;
				switch (num2 == num)
				{
				}
				num = (short)591986688;
				if (num != 0)
				{
				}
				num = (short)881983488;
				short num3 = num;
				num = (short)113049601;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00037A88 File Offset: 0x00035C88
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00037B38 File Offset: 0x00035D38
		public bool IsRefresh
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)583880150;
				short num2 = num;
				num = (short)153636310;
				switch (num2 == num)
				{
				}
				num = (short)1423114240;
				if (num != 0)
				{
				}
				num = (short)1139343360;
				short num3 = num;
				num = (short)566493185;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1575741443;
				short num2 = num;
				num = (short)997451779;
				switch (num2 == num)
				{
				}
				num = (short)565510144;
				if (num != 0)
				{
				}
				num = (short)172359680;
				short num3 = num;
				num = (short)781844481;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00037BE8 File Offset: 0x00035DE8
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00037C9C File Offset: 0x00035E9C
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1683452577;
				short num2 = num;
				num = (short)1487827617;
				switch (num2 == num)
				{
				}
				num = (short)251330560;
				short num3 = num;
				num = (short)1536163840;
				if (num != 0)
				{
				}
				num = (short)323223553;
				if (num != 0)
				{
				}
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1171193857;
				if (num != 0)
				{
				}
				num = (short)176011547;
				short num2 = num;
				num = (short)1592244507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172307968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1991835648;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00037D4C File Offset: 0x00035F4C
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00037DFC File Offset: 0x00035FFC
		public string SelectedFirmwareInfo
		{
			get
			{
				short num = (short)1755643905;
				if (num != 0)
				{
				}
				num = (short)1680678362;
				short num2 = num;
				num = (short)312090074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824508416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1689976832;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)920322050;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1784414208;
						short num3 = num;
						this.h = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_SelectedFirmwareInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)11272193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
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
					if (!(value != this.h))
					{
						break;
					}
					num = (short)1229875993;
					short num4 = num;
					num = (short)1956277017;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)522321921;
						if (num != 0)
						{
						}
						num = (short)687013888;
						if (num != 0)
						{
						}
						num = (short)2082406400;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00037F54 File Offset: 0x00036154
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0003837C File Offset: 0x0003657C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware SelectedFirmware
		{
			get
			{
				short num = (short)1407451138;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1317011457;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3D1;
					case 1:
						try
						{
							num = (short)1934163981;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_365;
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									if (this.SelectedFirmwareInfo.Contains(firmware.Version))
									{
										num = (short)1040908300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1754071040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									if (this.SelectedFirmwareInfo.Contains(firmware.Codeplug))
									{
										num = (short)1749024783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_21E;
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									if (this.SelectedFirmwareInfo.Contains(firmware.Version))
									{
										num = (short)1129578502;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1722744843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									if (string.IsNullOrEmpty(firmware.Codeplug))
									{
										num = (short)513015818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)745340929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									this.i = firmware;
									num = (short)1091829764;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									num = (short)2040262350;
									short num3 = num;
									num = (short)20901582;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_116;
									default:
										num = (short)896335872;
										if (num != 0)
										{
										}
										num = (short)1569390597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									if (this.SelectedFirmwareInfo.Contains(firmware.Name))
									{
										num = (short)1468465160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1929838595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_10A;
									}
									continue;
								case 14:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1355939842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware = enumerator.Current;
									num = (short)452722695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
									this.i = firmware;
									goto IL_116;
								}
								}
								goto IL_10A;
								IL_116:
								num = (short)100925449;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C1:
								num = (short)1041629198;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A:
								goto IL_1C1;
							}
							IL_21E:
							IL_365:
							goto IL_3F9;
						}
						finally
						{
							num = (short)1561722882;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1285881857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3CE;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_39A;
									}
									continue;
								}
								IL_39A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1410007040;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3CE:;
						}
						goto IL_3D1;
					case 2:
					{
						num = (short)1929510912;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					}
					IL_80:
					if (this.SelectedFirmwareInfo != null)
					{
						num = (short)675151872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_3D1:
					enumerator = this.Firmwares.GetEnumerator();
					num = (short)729088001;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3F9:
				return this.i;
			}
			set
			{
				int a_ = 18;
				short num = (short)1447165959;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.SelectedFirmwareInfo = string.Concat(new string[]
						{
							global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Firmware,
							global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("睌", a_),
							this.i.Version,
							global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("浌扎煐", a_),
							this.i.Name
						});
						num = (short)1220935688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)47316993;
						if (num != 0)
						{
						}
						goto IL_1E0;
					case 2:
						goto IL_1E0;
					case 3:
						if (this.i == null)
						{
							num = (short)1400242182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)576192521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						this.i = value;
						num = (short)315136072;
						short num3 = num;
						num = (short)1115330632;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1327497216;
							if (num != 0)
							{
							}
							num = (short)1246363651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						return;
					case 6:
						this.SelectedFirmwareInfo = null;
						num = (short)1519648769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					case 8:
					{
						num = (short)2101936128;
						short num4 = num;
						goto IL_1E0;
					}
					case 9:
						if (string.IsNullOrEmpty(this.i.Codeplug))
						{
							num = (short)30605312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectedFirmwareInfo = string.Concat(new string[]
						{
							global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Firmware,
							global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("睌", a_),
							this.i.Version,
							global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("浌扎煐", a_),
							global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Codeplug,
							global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("睌", a_),
							this.i.Codeplug
						});
						num = (short)352190466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_55:
					if (value != this.i)
					{
						num = (short)1990721540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1E0:
					base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_SelectedFirmware())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext.get_SelectedFirmwareInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1225981957;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000386D8 File Offset: 0x000368D8
		public global::System.Windows.Visibility ErrorVisibility
		{
			get
			{
				short num = (short)1867579393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.SystemIDs.Count == 0)
						{
							num = (short)1955266562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_36;
						}
						continue;
					case 2:
						goto IL_56;
					case 3:
						goto IL_C8;
					}
					IL_36:
					if (this.SystemIDs != null)
					{
						num = (short)1355808771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
					IL_C8:
					num = (short)308019200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56:
					num = (short)1950744577;
					if (num != 0)
					{
					}
					num = (short)137946507;
					short num3 = num;
					num = (short)2063721867;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
						goto IL_B1;
					}
				}
				IL_B1:
				num = (short)278069248;
				if (num != 0)
				{
				}
				return global::System.Windows.Visibility.Visible;
				IL_109:
				num = (short)617807872;
				short num4 = num;
				return global::System.Windows.Visibility.Hidden;
			}
		}

		// Token: 0x040001B2 RID: 434
		private bool a;

		// Token: 0x040001B3 RID: 435
		private global::System.Collections.ObjectModel.ObservableCollection<string> b;

		// Token: 0x040001B4 RID: 436
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> c;

		// Token: 0x040001B5 RID: 437
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> d;

		// Token: 0x040001B6 RID: 438
		private global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> e;

		// Token: 0x040001B7 RID: 439
		private string f;

		// Token: 0x040001B8 RID: 440
		private string g;

		// Token: 0x040001B9 RID: 441
		private string h;

		// Token: 0x040001BA RID: 442
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware i;

		// Token: 0x040001BB RID: 443
		private global::ASK.Interface.ISystemKeyData j;

		// Token: 0x040001BC RID: 444
		private bool k;

		// Token: 0x040001BD RID: 445
		private bool l;

		// Token: 0x040001BE RID: 446
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer m;

		// Token: 0x040001BF RID: 447
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> n;

		// Token: 0x040001C0 RID: 448
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> o;

		// Token: 0x040001C1 RID: 449
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p;

		// Token: 0x040001C2 RID: 450
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool q;

		// Token: 0x040001C3 RID: 451
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string r;
	}
}
