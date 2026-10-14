using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200003B RID: 59
	public class SelectRadiosContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x0600015A RID: 346 RVA: 0x000144F0 File Offset: 0x000126F0
		public SelectRadiosContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> radioWithWarningReason, string message, bool canConfirmAnyway)
		{
			this.RadioPairs = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair>(radioWithWarningReason);
			this.SelectedRadioPairs = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair>();
			this.IsConfirmed = false;
			this.Message = message;
			this.CanConfirmAnyway = canConfirmAnyway;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00014530 File Offset: 0x00012730
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000145E0 File Offset: 0x000127E0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> RadioPairs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1478513408;
				short num2 = num;
				num = (short)1395544832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289734656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1227227137;
				if (num != 0)
				{
				}
				num = (short)1960640512;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1062338561;
				if (num != 0)
				{
				}
				num = (short)469630976;
				short num2 = num;
				num = (short)250671655;
				short num3 = num;
				num = (short)1986851367;
				switch (num3 == num)
				{
				}
				num = (short)127205376;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00014694 File Offset: 0x00012894
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00014744 File Offset: 0x00012944
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> SelectedRadioPairs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1229556496;
				short num2 = num;
				num = (short)2031520528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)482803712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222377473;
				if (num != 0)
				{
				}
				num = (short)1932460032;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1312128847;
				short num2 = num;
				num = (short)446725967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042677760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951334401;
				if (num != 0)
				{
				}
				num = (short)1916207104;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000147F4 File Offset: 0x000129F4
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000148A0 File Offset: 0x00012AA0
		public bool IsConfirmed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2106771765;
				short num2 = num;
				num = (short)1320470837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413925376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417805824;
				if (num != 0)
				{
				}
				num = (short)690683905;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1601720704;
				short num2 = num;
				num = (short)1343902080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1407647744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2087321600;
				if (num != 0)
				{
				}
				num = (short)513605633;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00014950 File Offset: 0x00012B50
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00014A00 File Offset: 0x00012C00
		public bool CanConfirmAnyway
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)980230460;
				short num2 = num;
				num = (short)1990861116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)98369536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665269761;
				if (num != 0)
				{
				}
				num = (short)899481600;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1562023180;
				short num2 = num;
				num = (short)916362508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)662568960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2077753345;
				if (num != 0)
				{
				}
				num = (short)1510801408;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00014AB4 File Offset: 0x00012CB4
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00014B64 File Offset: 0x00012D64
		public string Message
		{
			get
			{
				short num = (short)925473302;
				short num2 = num;
				num = (short)1408801302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746731008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1036517377;
				if (num != 0)
				{
				}
				num = (short)304283648;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1728643074;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)778109744;
					short num3 = num;
					num = (short)680198960;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)335216640;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							return;
						case 1:
							goto IL_F8;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7D;
							}
							continue;
						}
						IL_7D:
						if (value != this.a)
						{
							num = (short)953090048;
							short num4 = num;
							num = (short)412876801;
							if (num != 0)
							{
							}
							num = (short)132186113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_F8:
					this.a = value;
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext.get_Message())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1880293376;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0400009E RID: 158
		private string a;

		// Token: 0x0400009F RID: 159
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> b;

		// Token: 0x040000A0 RID: 160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> c;

		// Token: 0x040000A1 RID: 161
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x040000A2 RID: 162
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;
	}
}
