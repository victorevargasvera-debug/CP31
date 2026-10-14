using System;
using System.Runtime.CompilerServices;

namespace AcpBusinessLayer.Impl
{
	// Token: 0x02000063 RID: 99
	internal class AcpRangeFieldImpl : global::AcpBusinessLayer.Impl.AcpFieldImpl<int>
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00071D30 File Offset: 0x0006FF30
		internal AcpRangeFieldImpl(string uiName) : base(uiName)
		{
			this.Min = 0;
			this.Max = int.MaxValue;
			this.StepSize = 1;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00071D60 File Offset: 0x0006FF60
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00071E10 File Offset: 0x00070010
		internal int Min
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1128005633;
				if (num != 0)
				{
				}
				num = (short)1429995520;
				short num2 = num;
				num = (short)1198849765;
				short num3 = num;
				num = (short)273350373;
				switch (num3 == num)
				{
				}
				num = (short)2082471936;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)959493221;
				short num2 = num;
				num = (short)2145825893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1925709824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725352448;
				if (num != 0)
				{
				}
				num = (short)1614544897;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00071EC0 File Offset: 0x000700C0
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00071F70 File Offset: 0x00070170
		internal int Max
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1388695167;
				short num2 = num;
				num = (short)311086719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135280128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)673251329;
				if (num != 0)
				{
				}
				num = (short)1266876416;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)526344471;
				short num2 = num;
				num = (short)2114216215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1698562048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983447041;
				if (num != 0)
				{
				}
				num = (short)136380416;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00072020 File Offset: 0x00070220
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x000720D0 File Offset: 0x000702D0
		internal int StepSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2001605109;
				short num2 = num;
				num = (short)409145845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192937984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330432513;
				if (num != 0)
				{
				}
				num = (short)337379328;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)52401219;
				short num2 = num;
				num = (short)1852347459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1011351552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268449280;
				if (num != 0)
				{
				}
				num = (short)1598881793;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x04000194 RID: 404
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x04000195 RID: 405
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x04000196 RID: 406
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
