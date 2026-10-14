using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Org.BouncyCastle.OpenSsl;

namespace SSLMangrComp
{
	// Token: 0x02000019 RID: 25
	internal class b : global::Org.BouncyCastle.OpenSsl.IPasswordFinder, global::System.IDisposable
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000C234 File Offset: 0x0000A434
		public b(global::System.Security.SecureString A_0)
		{
			this.a = A_0.Copy();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000C254 File Offset: 0x0000A454
		public b(string A_0)
		{
			this.a = new global::System.Security.SecureString();
			A_0.ToList<char>().ForEach(new global::System.Action<char>(this.b));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000C28C File Offset: 0x0000A48C
		public b(global::System.Collections.Generic.IEnumerable<char> A_0)
		{
			this.a = new global::System.Security.SecureString();
			A_0.ToList<char>().ForEach(new global::System.Action<char>(this.a));
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		public char[] GetPassword()
		{
			short num = (short)249283236;
			short num2 = num;
			num = (short)963756708;
			char[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1500446720;
				if (num != 0)
				{
				}
				num = (short)107675649;
				if (num != 0)
				{
				}
				num = (short)512688128;
				short num3 = num;
				global::System.IntPtr intPtr = global::System.IntPtr.Zero;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_C1;
					}
					int num4;
					for (;;)
					{
						IL_AF:
						char[] array;
						switch (num4)
						{
						case 0:
							goto IL_121;
						case 1:
						{
							string text = global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(intPtr);
							if (text == null)
							{
								num = (short)1478164482;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = text.ToCharArray();
							goto IL_10C;
						}
						case 2:
							array = null;
							goto IL_10C;
						}
						goto IL_C1;
						IL_10C:
						result = array;
						num = (short)1551826944;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_121:
					break;
					IL_C1:
					intPtr = global::System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocAnsi(this.a);
					num = (short)2115502081;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_AF;
				}
				finally
				{
					global::System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocAnsi(intPtr);
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000C40C File Offset: 0x0000A60C
		public void Dispose()
		{
			short num = (short)884730814;
			short num2 = num;
			num = (short)510716862;
			switch (num2 == num)
			{
			}
			num = (short)1666777089;
			if (num != 0)
			{
			}
			num = (short)305135616;
			short num3 = num;
			num = (short)365101056;
			if (num != 0)
			{
			}
			this.a.Dispose();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(char A_0)
		{
			short num = (short)1013710598;
			short num2 = num;
			num = (short)1643249414;
			switch (num2 == num)
			{
			}
			num = (short)278265857;
			if (num != 0)
			{
			}
			num = (short)950468608;
			short num3 = num;
			num = (short)1950285824;
			if (num != 0)
			{
			}
			this.a.AppendChar(A_0);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000C578 File Offset: 0x0000A778
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(char A_0)
		{
			short num = (short)2053364285;
			short num2 = num;
			num = (short)1550506557;
			switch (num2 == num)
			{
			}
			num = (short)1840709633;
			if (num != 0)
			{
			}
			num = (short)1170669568;
			short num3 = num;
			num = (short)160301056;
			if (num != 0)
			{
			}
			this.a.AppendChar(A_0);
		}

		// Token: 0x0400005A RID: 90
		private readonly global::System.Security.SecureString a;
	}
}
