using System;
using System.Runtime.CompilerServices;

namespace SharedUtility.Arguments
{
	// Token: 0x02000013 RID: 19
	public class ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII : global::SharedUtility.Arguments.IArgumentOfSharedConstraint
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0001409C File Offset: 0x0001229C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00014148 File Offset: 0x00012348
		public string UnitID_A12651
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)274298346;
				short num2 = num;
				num = (short)1470330346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2098724864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480785920;
				if (num != 0)
				{
				}
				num = (short)31719425;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)378258479;
				short num2 = num;
				num = (short)981058607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377487360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1108738049;
				if (num != 0)
				{
				}
				num = (short)1149173760;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000141F8 File Offset: 0x000123F8
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000142A8 File Offset: 0x000124A8
		public int Min
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)256809665;
				short num2 = num;
				num = (short)1247582913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618659840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563951104;
				if (num != 0)
				{
				}
				num = (short)1173356545;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)551061964;
				short num2 = num;
				num = (short)1157859788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)346161152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)722796545;
				if (num != 0)
				{
				}
				num = (short)901775360;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00014358 File Offset: 0x00012558
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00014408 File Offset: 0x00012608
		public int Max
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1048513538;
				short num2 = num;
				num = (short)1372392450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002780160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1427767296;
				if (num != 0)
				{
				}
				num = (short)1920008193;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)251507699;
				short num2 = num;
				num = (short)368489459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473970176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)228065280;
				if (num != 0)
				{
				}
				num = (short)870449153;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000144D0 File Offset: 0x000126D0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(565141015 + A_1) + (global::System.IntPtr)8 + (global::System.IntPtr)91);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x04000045 RID: 69
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000046 RID: 70
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x04000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
