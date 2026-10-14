using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200003C RID: 60
	public class RadioPair : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00014CC0 File Offset: 0x00012EC0
		public RadioPair(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, string warningInfo)
		{
			this.a = radio;
			this.b = warningInfo;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00014CE4 File Offset: 0x00012EE4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			get
			{
				short num = (short)218767278;
				short num2 = num;
				num = (short)273686446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110952448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063597569;
				if (num != 0)
				{
				}
				num = (short)162594816;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00014D90 File Offset: 0x00012F90
		public string SerialNumber
		{
			get
			{
				short num = (short)361237883;
				short num2 = num;
				num = (short)1494551931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67895296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727791105;
				if (num != 0)
				{
				}
				num = (short)74252288;
				if (num != 0)
				{
				}
				return this.a.SerialNumber;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00014E44 File Offset: 0x00013044
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00014EF8 File Offset: 0x000130F8
		public string Reason
		{
			get
			{
				short num = (short)1034609305;
				short num2 = num;
				num = (short)2055725721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)116260864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980156417;
				if (num != 0)
				{
				}
				num = (short)2005204992;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1871118338;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1094499486;
					short num3 = num;
					num = (short)8043678;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)387710976;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							return;
						case 1:
							num = (short)1666514945;
							if (num != 0)
							{
							}
							goto IL_F8;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7C;
							}
							continue;
						}
						IL_7C:
						if (this.b != value)
						{
							num = (short)1395195904;
							short num4 = num;
							num = (short)1524170753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_F8:
					this.b = value;
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair.get_Reason())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)538312704;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x040000A3 RID: 163
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;

		// Token: 0x040000A4 RID: 164
		private string b;
	}
}
