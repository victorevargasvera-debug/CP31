using System;
using System.Globalization;
using System.Windows.Controls;
using CommonResources;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x020000A0 RID: 160
	public class DataGridRadioIDValidation : global::System.Windows.Controls.ValidationRule
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000D5318 File Offset: 0x000D3518
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x000D53C4 File Offset: 0x000D35C4
		internal int MIN
		{
			get
			{
				short num = (short)657573647;
				short num2 = num;
				num = (short)1136510735;
				switch (num2 == num)
				{
				}
				num = (short)517603329;
				if (num != 0)
				{
				}
				num = (short)1458241536;
				if (num != 0)
				{
				}
				num = (short)909443072;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)352734238;
				short num2 = num;
				num = (short)410799134;
				switch (num2 == num)
				{
				}
				num = (short)35782657;
				if (num != 0)
				{
				}
				num = (short)1298202624;
				if (num != 0)
				{
				}
				num = (short)889257984;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000D5474 File Offset: 0x000D3674
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000D5520 File Offset: 0x000D3720
		internal int MAX
		{
			get
			{
				short num = (short)497097332;
				short num2 = num;
				num = (short)52238964;
				switch (num2 == num)
				{
				}
				num = (short)783155201;
				if (num != 0)
				{
				}
				num = (short)1047134208;
				if (num != 0)
				{
				}
				num = (short)1450573824;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1809788735;
				short num2 = num;
				num = (short)2123640639;
				switch (num2 == num)
				{
				}
				num = (short)106430465;
				if (num != 0)
				{
				}
				num = (short)1129775104;
				if (num != 0)
				{
				}
				num = (short)1656029184;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000D55D0 File Offset: 0x000D37D0
		public override global::System.Windows.Controls.ValidationResult Validate(object value, global::System.Globalization.CultureInfo cultureInfo)
		{
			short num = (short)1945501696;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
					goto IL_C6;
				case 2:
					goto IL_89;
				case 3:
					num = (short)462946308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (num3 > this.b)
					{
						num = (short)1762918401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 5:
					if (num3 >= this.a)
					{
						num = (short)1827078147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F;
				}
				IL_3D:
				num = (short)1111228417;
				if (num != 0)
				{
				}
				if (!int.TryParse((string)value, out num3))
				{
					num = (short)1454637058;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2141454341;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_89:
			return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Please_Enter_A_Valid_Radio_ID);
			IL_C6:
			IL_10F:
			num = (short)223229443;
			short num4 = num;
			num = (short)1405564419;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_195:
				return global::System.Windows.Controls.ValidationResult.ValidResult;
			default:
			{
				num = (short)685572096;
				if (num != 0)
				{
				}
				num = (short)2076442624;
				short num5 = num;
				return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Please_Enter_A_Valid_Radio_ID);
			}
			}
		}

		// Token: 0x040004C6 RID: 1222
		private int a = 1;

		// Token: 0x040004C7 RID: 1223
		private int b = 16777211;
	}
}
