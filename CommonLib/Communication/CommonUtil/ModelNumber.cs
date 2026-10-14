using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004F RID: 79
	public static class ModelNumber
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00026DB0 File Offset: 0x00024FB0
		public static bool IsAmp(string modelNumber)
		{
			global::Motorola.Common.Communication.CommonUtil.ModelNumber.a a = new global::Motorola.Common.Communication.CommonUtil.ModelNumber.a();
			a.a = modelNumber;
			if (!string.IsNullOrWhiteSpace(a.a))
			{
				short num = (short)596837520;
				short num2 = num;
				num = (short)2060125328;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1283260416;
					short num3 = num;
					num = (short)1447493632;
					if (num != 0)
					{
					}
					num = (short)1532755969;
					if (num != 0)
					{
					}
					return global::Motorola.Common.Communication.CommonUtil.ModelNumber.c.Any(new global::System.Func<string, bool>(a.b));
				}
				}
			}
			return false;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00026E90 File Offset: 0x00025090
		public static bool IsNext(string modelNumber)
		{
			global::Motorola.Common.Communication.CommonUtil.ModelNumber.b b = new global::Motorola.Common.Communication.CommonUtil.ModelNumber.b();
			b.a = modelNumber;
			short num;
			if (string.IsNullOrWhiteSpace(b.a))
			{
				num = (short)1902313473;
				if (num != 0)
				{
				}
				num = (short)2054688452;
				short num2 = num;
				num = (short)1572146884;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)472842240;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)575668224;
			short num3 = num;
			return global::Motorola.Common.Communication.CommonUtil.ModelNumber.a.Any(new global::System.Func<string, bool>(b.b));
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00026F70 File Offset: 0x00025170
		public static bool IsAloha(string modelNumber)
		{
			short num = (short)1461321729;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.ModelNumber.c c = new global::Motorola.Common.Communication.CommonUtil.ModelNumber.c();
			c.a = modelNumber;
			if (string.IsNullOrWhiteSpace(c.a))
			{
				num = (short)1062079082;
				short num2 = num;
				num = (short)1324812906;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1176371200;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)113704960;
			short num3 = num;
			return global::Motorola.Common.Communication.CommonUtil.ModelNumber.b.Any(new global::System.Func<string, bool>(c.b));
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0002704C File Offset: 0x0002524C
		// Note: this type is marked as 'beforefieldinit'.
		static ModelNumber()
		{
			int a_ = 14;
			short num = (short)913702912;
			short num2 = num;
			num = (short)242417665;
			if (num != 0)
			{
			}
			num = (short)581459869;
			short num3 = num;
			num = (short)42164125;
			switch (num3 == num)
			{
			}
			num = (short)884146176;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.ModelNumber.a = new string[]
			{
				global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("娑–⌕", a_),
				global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("娑ℓ⌕", a_)
			};
			global::Motorola.Common.Communication.CommonUtil.ModelNumber.b = new string[]
			{
				global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("娑✓⌕", a_)
			};
			global::Motorola.Common.Communication.CommonUtil.ModelNumber.c = global::Motorola.Common.Communication.CommonUtil.ModelNumber.a.Union(global::Motorola.Common.Communication.CommonUtil.ModelNumber.b).Distinct<string>().ToArray<string>();
		}

		// Token: 0x040001E4 RID: 484
		private static readonly string[] a;

		// Token: 0x040001E5 RID: 485
		private static readonly string[] b;

		// Token: 0x040001E6 RID: 486
		private static readonly string[] c;

		// Token: 0x02000050 RID: 80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060001EE RID: 494 RVA: 0x0002717C File Offset: 0x0002537C
			internal bool b(string A_0)
			{
				short num = (short)1505689600;
				short num2 = num;
				num = (short)1854715892;
				short num3 = num;
				num = (short)1470085108;
				switch (num3 == num)
				{
				}
				num = (short)1343422465;
				if (num != 0)
				{
				}
				num = (short)333119488;
				if (num != 0)
				{
				}
				return this.a.StartsWith(A_0);
			}

			// Token: 0x040001E7 RID: 487
			public string a;
		}

		// Token: 0x02000051 RID: 81
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060001F0 RID: 496 RVA: 0x00027248 File Offset: 0x00025448
			internal bool b(string A_0)
			{
				short num = (short)862060544;
				short num2 = num;
				num = (short)1153534745;
				short num3 = num;
				num = (short)1381862169;
				switch (num3 == num)
				{
				}
				num = (short)1641414656;
				if (num != 0)
				{
				}
				num = (short)1250492417;
				if (num != 0)
				{
				}
				return this.a.StartsWith(A_0);
			}

			// Token: 0x040001E8 RID: 488
			public string a;
		}

		// Token: 0x02000052 RID: 82
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00027314 File Offset: 0x00025514
			internal bool b(string A_0)
			{
				short num = (short)542179328;
				short num2 = num;
				num = (short)1650724815;
				short num3 = num;
				num = (short)1889996751;
				switch (num3 == num)
				{
				}
				num = (short)1290076161;
				if (num != 0)
				{
				}
				num = (short)1591410688;
				if (num != 0)
				{
				}
				return this.a.StartsWith(A_0);
			}

			// Token: 0x040001E9 RID: 489
			public string a;
		}
	}
}
