using System;
using System.Linq.Expressions;
using Microsoft.Practices.Prism.ViewModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000051 RID: 81
	public class WiFiRecord : global::Microsoft.Practices.Prism.ViewModel.NotificationObject
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00027F28 File Offset: 0x00026128
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00027FD8 File Offset: 0x000261D8
		public string NetworkSSID
		{
			get
			{
				short num = (short)2490368;
				short num2 = num;
				num = (short)881347248;
				short num3 = num;
				num = (short)850873008;
				switch (num3 == num)
				{
				}
				num = (short)1756692480;
				if (num != 0)
				{
				}
				num = (short)952631297;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)694353921;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)91059245;
					short num3 = num;
					num = (short)132084781;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)757137409;
						if (num != 0)
						{
						}
						num = (short)439156736;
						if (num != 0)
						{
						}
						num = (short)959119360;
						short num4 = num;
						switch (num2)
						{
						case 0:
							this.a = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord)), methodof(global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord.get_NetworkSSID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1889140738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CC;
							}
							continue;
						case 2:
							return;
						}
						IL_CC:
						if (!(value != this.a))
						{
							return;
						}
						num = (short)1272315904;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0002812C File Offset: 0x0002632C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x000281DC File Offset: 0x000263DC
		public string NetworkPWD
		{
			get
			{
				short num = (short)405471232;
				short num2 = num;
				num = (short)2054163219;
				short num3 = num;
				num = (short)1998981907;
				switch (num3 == num)
				{
				}
				num = (short)1957036033;
				if (num != 0)
				{
				}
				num = (short)530382848;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)290717696;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1101266945;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 1:
						return;
					case 2:
						this.IsValid = true;
						goto IL_8F;
					case 3:
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord)), methodof(global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord.get_NetworkPWD())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1792868356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!this.IsValid)
						{
							num = (short)1660023214;
							short num3 = num;
							num = (short)1518137774;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8F;
							case 1:
								break;
							default:
							{
								num = (short)656015360;
								short num4 = num;
								break;
							}
							}
							num = (short)259915776;
							if (num != 0)
							{
							}
							num = (short)1429340162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_60:
					if (value != this.b)
					{
						num = (short)1469317123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_8F:
					num = (short)120913921;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00028380 File Offset: 0x00026580
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00028430 File Offset: 0x00026630
		public bool IsValid
		{
			get
			{
				short num = (short)1934950400;
				short num2 = num;
				num = (short)1282876122;
				short num3 = num;
				num = (short)987767514;
				switch (num3 == num)
				{
				}
				num = (short)1587937280;
				if (num != 0)
				{
				}
				num = (short)2095579137;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)32833537;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)656693123;
					short num3 = num;
					num = (short)803166083;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
					{
						num = (short)1619394560;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							this.c = value;
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord)), methodof(global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord.get_IsValid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)494665730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7C;
							}
							continue;
						case 2:
							goto IL_118;
						}
						IL_7C:
						num = (short)581763072;
						short num4 = num;
						if (value == this.c)
						{
							goto IL_11A;
						}
						num = (short)1900609536;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_118:
				IL_11A:
				num = (short)154075137;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x04000057 RID: 87
		private string a;

		// Token: 0x04000058 RID: 88
		private string b;

		// Token: 0x04000059 RID: 89
		private bool c;
	}
}
