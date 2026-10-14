using System;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A2 RID: 162
	public class LoadingInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x000558E0 File Offset: 0x00053AE0
		public LoadingInfo(string productVersion)
		{
			int a_ = 17;
			base..ctor();
			this.a = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Loading_StartAppliction;
			this.d = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SplashVersion + global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("汋", a_) + productVersion;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00055928 File Offset: 0x00053B28
		public LoadingInfo(string status, string productVersion)
		{
			int a_ = 6;
			base..ctor();
			this.a = status;
			this.d = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SplashVersion + global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("慀", a_) + productVersion;
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0005596C File Offset: 0x00053B6C
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00055A1C File Offset: 0x00053C1C
		public string Status
		{
			get
			{
				short num = (short)513332123;
				short num2 = num;
				num = (short)702403483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)124256256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819607041;
				if (num != 0)
				{
				}
				num = (short)1340276736;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)2134507524;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						return;
					case 2:
						num = (short)2070806529;
						if (num != 0)
						{
						}
						if (!base.IsLoading)
						{
							num = (short)1084489731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo.get_Status())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1373503489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					if (value == this.a)
					{
						num = (short)1177593504;
						short num3 = num;
						num = (short)1048749728;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)741539840;
							if (num != 0)
							{
							}
							num = (short)937033728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					else
					{
						this.a = value;
					}
					num = (short)1311047680;
					short num4 = num;
					num = (short)1731133442;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00055BC0 File Offset: 0x00053DC0
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00055C70 File Offset: 0x00053E70
		public int Progress
		{
			get
			{
				short num = (short)1060691381;
				short num2 = num;
				num = (short)1890508213;
				switch (num2 == num)
				{
				default:
				{
					num = (short)732954624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071396353;
				if (num != 0)
				{
				}
				num = (short)2050883584;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)362086402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)288161792;
						short num3 = num;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo.get_Progress())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)894959620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)890523175;
						short num4 = num;
						num = (short)3362343;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)370933761;
							if (num != 0)
							{
							}
							num = (short)1164247040;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AC;
							}
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1287782400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					}
					IL_AC:
					if (value == this.b)
					{
						num = (short)282591233;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.b = value;
						num = (short)1636040707;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00055E08 File Offset: 0x00054008
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00055EB8 File Offset: 0x000540B8
		public string ProductName
		{
			get
			{
				short num = (short)726892351;
				short num2 = num;
				num = (short)1807253311;
				switch (num2 == num)
				{
				}
				num = (short)499646465;
				if (num != 0)
				{
				}
				num = (short)710017024;
				if (num != 0)
				{
				}
				num = (short)1183973376;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)50331650;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1125384192;
						short num3 = num;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo.get_ProductName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)535166977;
						if (num != 0)
						{
						}
						num = (short)453181444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)1814099217;
						short num4 = num;
						num = (short)1274803473;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)706936832;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_84;
							}
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1194852352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					}
					IL_84:
					if (value == this.c)
					{
						num = (short)2024800257;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.c = value;
						num = (short)428605443;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00056058 File Offset: 0x00054258
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00056104 File Offset: 0x00054304
		public string Version
		{
			get
			{
				short num = (short)1483407361;
				if (num != 0)
				{
				}
				num = (short)2014675355;
				short num2 = num;
				num = (short)1611628955;
				switch (num2 == num)
				{
				}
				num = (short)2015559680;
				if (num != 0)
				{
				}
				num = (short)509149184;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)1604911106;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1680015360;
						short num3 = num;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LoadingInfo.get_Version())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1066467332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)1549841143;
						short num4 = num;
						num = (short)1582281463;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1507524608;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_84;
							}
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1635844096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_FA;
					}
					IL_84:
					if (value == this.d)
					{
						num = (short)949223425;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.d = value;
						num = (short)79495171;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_FA:
				num = (short)292814849;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x040002A8 RID: 680
		private string a;

		// Token: 0x040002A9 RID: 681
		private int b;

		// Token: 0x040002AA RID: 682
		private string c;

		// Token: 0x040002AB RID: 683
		private string d;
	}
}
