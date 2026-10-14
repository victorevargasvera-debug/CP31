using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000047 RID: 71
	public class ClearDataProgressUIItem : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0001A934 File Offset: 0x00018B34
		public ClearDataProgressUIItem(global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataType type)
		{
			this.DataType = type;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0001A970 File Offset: 0x00018B70
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0001AA24 File Offset: 0x00018C24
		public string TaskName
		{
			get
			{
				short num = (short)361857136;
				short num2 = num;
				num = (short)1067090032;
				switch (num2 == num)
				{
				}
				num = (short)563609601;
				if (num != 0)
				{
				}
				num = (short)1019543552;
				if (num != 0)
				{
				}
				num = (short)484966400;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1461051349;
				short num2 = num;
				num = (short)1624629205;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1323433984;
					if (num != 0)
					{
					}
					num = (short)472121345;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_TaskName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1564803075;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					case 2:
						num = (short)1325662209;
						if (num != 0)
						{
						}
						this.a = value;
						num = (short)1810235396;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)1125122048;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_86:
					num = (short)1872363520;
					short num4 = num;
					if (!(value != this.a))
					{
						break;
					}
					num = (short)1182203906;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0001ABC0 File Offset: 0x00018DC0
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0001AC70 File Offset: 0x00018E70
		public global::System.DateTime CreateTime
		{
			get
			{
				short num = (short)269989904;
				short num2 = num;
				num = (short)1160362000;
				switch (num2 == num)
				{
				}
				num = (short)871170049;
				if (num != 0)
				{
				}
				num = (short)1194786816;
				if (num != 0)
				{
				}
				num = (short)2133196800;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)5006907;
				short num2 = num;
				num = (short)433415739;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)437780480;
					if (num != 0)
					{
					}
					num = (short)1243283457;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<global::System.DateTime>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.DateTime>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_CreateTime())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1723400195;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 2:
						this.b = value;
						num = (short)983236612;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)348127232;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_85:
					num = (short)651034624;
					short num4 = num;
					num = (short)205783041;
					if (num != 0)
					{
					}
					if (!(value != this.b))
					{
						break;
					}
					num = (short)2076114946;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001AE10 File Offset: 0x00019010
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0001AEC0 File Offset: 0x000190C0
		public int ProgressPercentage
		{
			get
			{
				short num = (short)875338419;
				short num2 = num;
				num = (short)847682227;
				switch (num2 == num)
				{
				}
				num = (short)1373372417;
				if (num != 0)
				{
				}
				num = (short)824639488;
				if (num != 0)
				{
				}
				num = (short)172883968;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1048346887;
				short num2 = num;
				num = (short)494305543;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)145031168;
					if (num != 0)
					{
					}
					num = (short)720830465;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_ProgressPercentage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)939786243;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 2:
						this.c = value;
						num = (short)915210244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)331153408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_83:
					num = (short)1544683520;
					short num4 = num;
					num = (short)1990328321;
					if (num != 0)
					{
					}
					if (value == this.c)
					{
						break;
					}
					num = (short)665583618;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0001B058 File Offset: 0x00019258
		public string ProgressSummary
		{
			get
			{
				int a_ = 4;
				short num = (short)2014006582;
				short num2 = num;
				num = (short)2111982902;
				switch (num2 == num)
				{
				}
				num = (short)100007937;
				if (num != 0)
				{
				}
				num = (short)749731840;
				if (num != 0)
				{
				}
				num = (short)1659437056;
				short num3 = num;
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("䐾煀㹂敄⡆⽈歊㙌繎ⱐ獒", a_), this.FinishedCount, this.TotalCount);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0001B138 File Offset: 0x00019338
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0001B1E8 File Offset: 0x000193E8
		public string Reason
		{
			get
			{
				short num = (short)1815136500;
				short num2 = num;
				num = (short)840354036;
				switch (num2 == num)
				{
				}
				num = (short)952565761;
				if (num != 0)
				{
				}
				num = (short)1421737984;
				if (num != 0)
				{
				}
				num = (short)1983971328;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)751501313;
				if (num != 0)
				{
				}
				num = (short)2034180717;
				short num2 = num;
				num = (short)2092180077;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1251147776;
					if (num != 0)
					{
					}
					num = (short)87359489;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					num = (short)1248198656;
					short num4 = num;
					switch (num3)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_Reason())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2119041027;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D4;
						}
						continue;
					case 2:
						this.d = value;
						num = (short)620036100;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (!base.IsLoading)
						{
							num = (short)2133262336;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_D4:
					if (!(value != this.d))
					{
						break;
					}
					num = (short)1509687298;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001B384 File Offset: 0x00019584
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0001B434 File Offset: 0x00019634
		public int TotalCount
		{
			get
			{
				short num = (short)1342002852;
				short num2 = num;
				num = (short)968382116;
				switch (num2 == num)
				{
				}
				num = (short)55967745;
				if (num != 0)
				{
				}
				num = (short)323026944;
				if (num != 0)
				{
				}
				num = (short)1170997248;
				short num3 = num;
				return this.e;
			}
			set
			{
				short num = (short)1076690945;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_62;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 2:
						this.e = value;
						num = (short)683737093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_TotalCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1392902144;
						short num3 = num;
						num = (short)1633353729;
						if (num != 0)
						{
						}
						num = (short)2010042804;
						short num4 = num;
						num = (short)909169076;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
							num = (short)224067584;
							if (num != 0)
							{
							}
							num = (short)1223229440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return;
					case 5:
						if (!base.IsLoading)
						{
							num = (short)432799747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62;
					}
					IL_3C:
					if (value != this.e)
					{
						num = (short)42598402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_62:
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_ProgressSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					this.ProgressPercentage = this.FinishedCount * 100 / this.TotalCount;
					num = (short)779026436;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0001B640 File Offset: 0x00019840
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0001B6F4 File Offset: 0x000198F4
		public int FinishedCount
		{
			get
			{
				short num = (short)1488724523;
				short num2 = num;
				num = (short)1397957163;
				switch (num2 == num)
				{
				}
				num = (short)1255145473;
				if (num != 0)
				{
				}
				num = (short)1572012032;
				if (num != 0)
				{
				}
				num = (short)421920768;
				short num3 = num;
				return this.f;
			}
			set
			{
				short num = (short)677773313;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_8A;
					case 1:
						num = (short)1057423361;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 2:
						this.f = value;
						num = (short)1996226565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)301989888;
						short num3 = num;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_FinishedCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)535874816;
						short num4 = num;
						num = (short)1310444800;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8A;
						default:
							num = (short)974389248;
							if (num != 0)
							{
							}
							num = (short)930283520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return;
					case 5:
						if (!base.IsLoading)
						{
							num = (short)1306525699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A;
					}
					IL_64:
					if (value != this.f)
					{
						num = (short)435683330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_8A:
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ClearDataProgressUIItem.get_ProgressSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					this.ProgressPercentage = this.FinishedCount * 100 / this.TotalCount;
					num = (short)2113404932;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0001B8FC File Offset: 0x00019AFC
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataType DataType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)188940289;
				if (num != 0)
				{
				}
				num = (short)278232933;
				short num2 = num;
				num = (short)1849786213;
				switch (num2 == num)
				{
				}
				num = (short)1720647680;
				if (num != 0)
				{
				}
				num = (short)575340544;
				short num3 = num;
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)254324836;
				short num2 = num;
				num = (short)469413988;
				switch (num2 == num)
				{
				}
				num = (short)2115108864;
				if (num != 0)
				{
				}
				num = (short)1347682305;
				if (num != 0)
				{
				}
				num = (short)1758330880;
				short num3 = num;
				this.g = value;
			}
		}

		// Token: 0x040000BE RID: 190
		private string a = "";

		// Token: 0x040000BF RID: 191
		private global::System.DateTime b = global::System.DateTime.Now;

		// Token: 0x040000C0 RID: 192
		private int c;

		// Token: 0x040000C1 RID: 193
		private string d = "";

		// Token: 0x040000C2 RID: 194
		private int e;

		// Token: 0x040000C3 RID: 195
		private int f;

		// Token: 0x040000C4 RID: 196
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataType g;
	}
}
