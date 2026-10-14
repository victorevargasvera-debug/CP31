using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Org.BouncyCastle.OpenSsl;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200000E RID: 14
	internal class Password : global::Org.BouncyCastle.OpenSsl.IPasswordFinder, global::System.IDisposable
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000431C File Offset: 0x0000251C
		public Password(global::System.Security.SecureString password)
		{
			this.a = password.Copy();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000433C File Offset: 0x0000253C
		public Password(string password)
		{
			this.a = new global::System.Security.SecureString();
			password.ToList<char>().ForEach(new global::System.Action<char>(this.b));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004374 File Offset: 0x00002574
		public Password(global::System.Collections.Generic.IEnumerable<char> password)
		{
			this.a = new global::System.Security.SecureString();
			password.ToList<char>().ForEach(new global::System.Action<char>(this.a));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000043AC File Offset: 0x000025AC
		public char[] GetPassword()
		{
			short num = (short)1910329557;
			short num2 = num;
			num = (short)1276858581;
			char[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2022113281;
				if (num != 0)
				{
				}
				num = (short)15269888;
				if (num != 0)
				{
				}
				global::System.IntPtr intPtr = global::System.IntPtr.Zero;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_97;
					}
					int num3;
					for (;;)
					{
						IL_85:
						char[] array;
						switch (num3)
						{
						case 0:
							goto IL_F8;
						case 1:
						{
							string text = global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(intPtr);
							if (text == null)
							{
								num = (short)1176895490;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = text.ToCharArray();
							goto IL_E3;
						}
						case 2:
							array = null;
							goto IL_E3;
						}
						goto IL_97;
						IL_E3:
						result = array;
						num = (short)620232704;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_F8:
					break;
					IL_97:
					intPtr = global::System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocAnsi(this.a);
					num = (short)1196294145;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_85;
				}
				finally
				{
					global::System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocAnsi(intPtr);
				}
				break;
			}
			}
			num = (short)100859904;
			short num4 = num;
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000044F4 File Offset: 0x000026F4
		public void Dispose()
		{
			short num = (short)352845825;
			if (num != 0)
			{
			}
			num = (short)701962987;
			short num2 = num;
			num = (short)162470635;
			switch (num2 == num)
			{
			}
			num = (short)1759248384;
			if (num != 0)
			{
			}
			num = (short)602079232;
			short num3 = num;
			this.a.Dispose();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000045A8 File Offset: 0x000027A8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(char A_0)
		{
			short num = (short)964808673;
			short num2 = num;
			num = (short)127913953;
			switch (num2 == num)
			{
			}
			num = (short)1028194305;
			if (num != 0)
			{
			}
			num = (short)1462173696;
			if (num != 0)
			{
			}
			num = (short)1999831040;
			short num3 = num;
			this.a.AppendChar(A_0);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000465C File Offset: 0x0000285C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(char A_0)
		{
			short num = (short)247787344;
			short num2 = num;
			num = (short)315354960;
			switch (num2 == num)
			{
			}
			num = (short)1135935489;
			if (num != 0)
			{
			}
			num = (short)1661272064;
			if (num != 0)
			{
			}
			num = (short)2006974464;
			short num3 = num;
			this.a.AppendChar(A_0);
		}

		// Token: 0x0400001D RID: 29
		private readonly global::System.Security.SecureString a;
	}
}
