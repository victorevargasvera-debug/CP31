using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000042 RID: 66
	public class LogSetting : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00016698 File Offset: 0x00014898
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00016748 File Offset: 0x00014948
		public bool UploadToServer
		{
			get
			{
				short num = (short)793347297;
				short num2 = num;
				num = (short)1401062625;
				switch (num2 == num)
				{
				}
				num = (short)1910112256;
				short num3 = num;
				num = (short)432078849;
				if (num != 0)
				{
				}
				num = (short)426639360;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1025245187;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.a = value;
						num = (short)1387593729;
						if (num != 0)
						{
						}
						num = (short)1549205506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (base.IsLoading)
						{
							return;
						}
						num = (short)852619208;
						short num3 = num;
						num = (short)1900343240;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)1408172032;
							short num4 = num;
							num = (short)1988034560;
							if (num != 0)
							{
							}
							num = (short)712310788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting.get_UploadToServer())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)813957120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					if (value == this.a)
					{
						break;
					}
					num = (short)904200193;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000168E4 File Offset: 0x00014AE4
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00016994 File Offset: 0x00014B94
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RestartOptions RestartOption
		{
			get
			{
				short num = (short)121010370;
				short num2 = num;
				num = (short)694057154;
				switch (num2 == num)
				{
				}
				num = (short)2059796480;
				short num3 = num;
				num = (short)446889984;
				if (num != 0)
				{
				}
				num = (short)968294401;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)459145219;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)1408499713;
						if (num != 0)
						{
						}
						this.b = value;
						num = (short)1355939842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (base.IsLoading)
						{
							return;
						}
						num = (short)224158511;
						short num3 = num;
						num = (short)775906095;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)743964672;
							short num4 = num;
							num = (short)1375141888;
							if (num != 0)
							{
							}
							num = (short)426115076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 4:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RestartOptions>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RestartOptions>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting.get_RestartOption())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1875116032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					if (value == this.b)
					{
						break;
					}
					num = (short)999686145;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00016B30 File Offset: 0x00014D30
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00016BE0 File Offset: 0x00014DE0
		public bool HideDialogChecked
		{
			get
			{
				short num = (short)1657995265;
				if (num != 0)
				{
				}
				num = (short)175203988;
				short num2 = num;
				num = (short)1170957972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)22413312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1346502656;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)135397379;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.c = value;
						num = (short)986251266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (base.IsLoading)
						{
							return;
						}
						num = (short)2024656528;
						short num3 = num;
						num = (short)58773136;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)2145779712;
							short num4 = num;
							num = (short)2031484928;
							if (num != 0)
							{
							}
							num = (short)963379204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
						num = (short)1716649985;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting.get_HideDialogChecked())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)135921664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_39:
					if (value == this.c)
					{
						break;
					}
					num = (short)566624257;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x040000B4 RID: 180
		private bool a;

		// Token: 0x040000B5 RID: 181
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RestartOptions b;

		// Token: 0x040000B6 RID: 182
		private bool c;
	}
}
