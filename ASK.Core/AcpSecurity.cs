using System;
using System.Security.Cryptography;
using System.Text;

namespace ASK.Core
{
	// Token: 0x02000027 RID: 39
	public static class AcpSecurity
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00029F84 File Offset: 0x00028184
		internal static bool a()
		{
			short num = (short)1484754909;
			short num2 = num;
			num = (short)674140125;
			switch (num2 == num)
			{
			}
			num = (short)188678145;
			if (num != 0)
			{
			}
			num = (short)1385824256;
			short num3 = num;
			num = (short)978649088;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0002A030 File Offset: 0x00028230
		public static byte[] CalculateCheckSum(params string[] list)
		{
			short num = (short)12058624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_93;
					case 1:
						goto IL_61;
					case 2:
					{
						if (num3 >= list.Length)
						{
							num = (short)352387072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1941635073;
						if (num != 0)
						{
						}
						num = (short)240381461;
						short num4 = num;
						num = (short)1637936661;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)655687680;
							if (num != 0)
							{
							}
							string str = list[num3];
							text += str;
							num3++;
							num = (short)1182990339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_61;
					}
					goto IL_40;
					IL_61:
					num = (short)664076290;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_93:
				num = (short)585302016;
				short num5 = num;
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(text);
				return new global::System.Security.Cryptography.SHA256Managed().ComputeHash(bytes);
				IL_40:
				text = string.Empty;
				num3 = 0;
				num = (short)2127101953;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}
	}
}
