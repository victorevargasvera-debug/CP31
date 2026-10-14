using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000078 RID: 120
	public class LeaveSetConfirmationContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x06000380 RID: 896 RVA: 0x000345AC File Offset: 0x000327AC
		public LeaveSetConfirmationContext(bool isNewSet, bool isGlobalSet, bool isSharableSet) : this(isNewSet, isGlobalSet, isSharableSet, false)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000345C4 File Offset: 0x000327C4
		public LeaveSetConfirmationContext(bool isNewSet, bool isGlobalSet, bool isSharableSet, bool isRootSet) : this(isNewSet, isGlobalSet, isSharableSet, isRootSet, false)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000345E0 File Offset: 0x000327E0
		public LeaveSetConfirmationContext(bool isNewSet, bool isGlobalSet, bool isSharableSet, bool isRootSet, bool isNotInEditor)
		{
			this.IsNewSet = isNewSet;
			this.IsRootSet = isRootSet;
			this.IsGlobalSet = isGlobalSet;
			this.IsNotInEditor = isNotInEditor;
			this.IsSharableSet = isSharableSet;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00034618 File Offset: 0x00032818
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000346CC File Offset: 0x000328CC
		public bool IsConfirmed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)993901631;
				short num2 = num;
				num = (short)903789631;
				switch (num2 == num)
				{
				}
				num = (short)855638016;
				short num3 = num;
				num = (short)453640193;
				if (num != 0)
				{
				}
				num = (short)94765056;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1188628184;
				short num2 = num;
				num = (short)1616578264;
				switch (num2 == num)
				{
				}
				num = (short)852688896;
				short num3 = num;
				num = (short)435748865;
				if (num != 0)
				{
				}
				num = (short)1960050688;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0003477C File Offset: 0x0003297C
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0003482C File Offset: 0x00032A2C
		public bool IsNewSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)272965694;
				short num2 = num;
				num = (short)1427972158;
				switch (num2 == num)
				{
				}
				num = (short)1011220480;
				short num3 = num;
				num = (short)158203905;
				if (num != 0)
				{
				}
				num = (short)1978793984;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)138571603;
				short num2 = num;
				num = (short)750481235;
				switch (num2 == num)
				{
				}
				num = (short)541130752;
				short num3 = num;
				num = (short)71303169;
				if (num != 0)
				{
				}
				num = (short)464584704;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000348DC File Offset: 0x00032ADC
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00034990 File Offset: 0x00032B90
		public bool IsRootSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1027255770;
				short num2 = num;
				num = (short)828485082;
				switch (num2 == num)
				{
				}
				num = (short)44695552;
				short num3 = num;
				num = (short)1252458497;
				if (num != 0)
				{
				}
				num = (short)348454912;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)1343658857;
				short num2 = num;
				num = (short)77175657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126577664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452395008;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00034A40 File Offset: 0x00032C40
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00034AF0 File Offset: 0x00032CF0
		public bool IsGlobalSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1619269748;
				short num2 = num;
				num = (short)176887924;
				switch (num2 == num)
				{
				}
				num = (short)1967325184;
				short num3 = num;
				num = (short)2063335425;
				if (num != 0)
				{
				}
				num = (short)18612224;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1582070583;
				short num2 = num;
				num = (short)2121104183;
				switch (num2 == num)
				{
				}
				num = (short)2096627712;
				short num3 = num;
				num = (short)1115291648;
				if (num != 0)
				{
				}
				num = (short)1576402945;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00034BA0 File Offset: 0x00032DA0
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00034C50 File Offset: 0x00032E50
		public bool IsNotInEditor
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)768681597;
				short num2 = num;
				num = (short)348399229;
				switch (num2 == num)
				{
				}
				num = (short)675872768;
				short num3 = num;
				num = (short)1633746944;
				if (num != 0)
				{
				}
				num = (short)60162049;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1047252232;
				short num2 = num;
				num = (short)1002556680;
				switch (num2 == num)
				{
				}
				num = (short)450625536;
				short num3 = num;
				num = (short)2107768833;
				if (num != 0)
				{
				}
				num = (short)1951268864;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00034D00 File Offset: 0x00032F00
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00034DB0 File Offset: 0x00032FB0
		public bool IsSharableSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1404465313;
				short num2 = num;
				num = (short)1915711649;
				switch (num2 == num)
				{
				}
				num = (short)389349376;
				short num3 = num;
				num = (short)607453184;
				if (num != 0)
				{
				}
				num = (short)348061697;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)127975996;
				short num2 = num;
				num = (short)1631044156;
				switch (num2 == num)
				{
				}
				num = (short)954990592;
				short num3 = num;
				num = (short)799604736;
				if (num != 0)
				{
				}
				num = (short)743374849;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00034E5C File Offset: 0x0003305C
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00034F0C File Offset: 0x0003310C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption Option
		{
			get
			{
				short num = (short)1261305857;
				if (num != 0)
				{
				}
				num = (short)509809815;
				short num2 = num;
				num = (short)510858391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479920128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682754048;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)612630530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						for (;;)
						{
							this.a = value;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetConfirmationContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetConfirmationContext.get_Option())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1683913356;
							short num3 = num;
							num = (short)1974041228;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_C4;
							}
						}
						IL_C4:
						num = (short)1959854080;
						if (num != 0)
						{
						}
						num = (short)733609985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_F1;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (value == this.a)
					{
						return;
					}
					num = (short)81461248;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F1:
				num = (short)2621440;
				short num4 = num;
				num = (short)1766195201;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x0400019F RID: 415
		private global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption a;

		// Token: 0x040001A0 RID: 416
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x040001A1 RID: 417
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x040001A2 RID: 418
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;

		// Token: 0x040001A3 RID: 419
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;

		// Token: 0x040001A4 RID: 420
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f;

		// Token: 0x040001A5 RID: 421
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;
	}
}
