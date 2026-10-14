using System;
using System.Collections;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000089 RID: 137
	internal class DecimalComparer : global::System.Collections.IComparer
	{
		// Token: 0x06000345 RID: 837 RVA: 0x00036A78 File Offset: 0x00034C78
		public int Compare(object x, object y)
		{
			short num = (short)15007744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
				decimal value;
				global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
				decimal num5;
				for (;;)
				{
					IL_28:
					num = (short)884736000;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_185;
					case 1:
					{
						num = (short)1105860746;
						short num4 = num;
						num = (short)1742149770;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D;
						default:
							num = (short)2001403904;
							if (num != 0)
							{
							}
							num = (short)524156930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (decimal.TryParse(fieldBase.ToString(), out value))
						{
							num = (short)1169031168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187;
					case 3:
						if (decimal.TryParse(fieldBase2.ToString(), out num5))
						{
							num = (short)1948844033;
							if (num != 0)
							{
							}
							num = (short)1302986753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187;
					}
					goto IL_6B;
				}
				IL_13D:
				return num5.CompareTo(value);
				IL_185:
				goto IL_13D;
				IL_187:
				return string.Compare(x.ToString(), y.ToString(), global::System.StringComparison.CurrentCulture);
				IL_6B:
				fieldBase2 = (x as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
				fieldBase = (y as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
				num5 = 0m;
				value = 0m;
				num = (short)2012741635;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
