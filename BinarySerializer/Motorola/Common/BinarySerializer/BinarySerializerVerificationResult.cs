using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x02000024 RID: 36
	public class BinarySerializerVerificationResult
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000D754 File Offset: 0x0000B954
		public bool CheckFailed
		{
			get
			{
				short num = (short)537259402;
				short num2 = num;
				num = (short)653192586;
				switch (num2 == num)
				{
				}
				num = (short)582615041;
				if (num != 0)
				{
				}
				num = (short)933036032;
				short num3 = num;
				num = (short)1467875328;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> notExpectedTypes = this.NotExpectedTypes;
				return notExpectedTypes != null && notExpectedTypes.Any<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>();
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000D814 File Offset: 0x0000BA14
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		public global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> NotExpectedTypes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1423441921;
				if (num != 0)
				{
				}
				num = (short)740799613;
				short num2 = num;
				num = (short)2034807933;
				switch (num2 == num)
				{
				}
				num = (short)1061355520;
				short num3 = num;
				num = (short)238092288;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)667228163;
				short num2 = num;
				num = (short)2049579011;
				switch (num2 == num)
				{
				}
				num = (short)1931608065;
				if (num != 0)
				{
				}
				num = (short)1665400832;
				short num3 = num;
				num = (short)1427374080;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000D978 File Offset: 0x0000BB78
		public override string ToString()
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.a a;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_16B;
				case 1:
				{
					num2 = (short)453246977;
					if (num2 != 0)
					{
					}
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> notExpectedTypes = this.NotExpectedTypes;
					if (notExpectedTypes == null)
					{
						num2 = (short)1718353920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					notExpectedTypes.ToList<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>().ForEach(new global::System.Action<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>(a.b));
					num2 = (short)22806532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (!this.CheckFailed)
					{
						num2 = (short)1713373187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					for (;;)
					{
						a.a = new global::System.Text.StringBuilder().AppendLine(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("瑩풰솲\udcb4톶킸\ud8ba\udcbc쮾ꣀ곂ꯄ믈껊뻌뫎뷐꟒鿘髚铜鏞ꓠ꟢쯤쟦골藪軬胮蓰鷲致鋶诸黺駼\udffe甀稂甄戆稈ㄊ", a_));
						num2 = (short)1503047883;
						short num3 = num2;
						num2 = (short)1272099019;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F3;
						}
					}
					IL_F3:
					num2 = (short)964624384;
					if (num2 != 0)
					{
					}
					num2 = (short)344981505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_8E;
				case 4:
					goto IL_19C;
				}
				goto IL_2D;
			}
			IL_8E:
			return global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("瑩풰솲\udcb4톶킸\ud8ba\udcbc쮾ꣀ곂ꯄ믈껊뻌뫎뷐꟒觘髚軜賞ꓠ꟢", a_);
			IL_16B:
			IL_19C:
			return a.a.ToString();
			IL_2D:
			a = new global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.a();
			num2 = (short)1331036160;
			short num4 = num2;
			num2 = (short)618856450;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000DB44 File Offset: 0x0000BD44
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(966963446 + A_1) + (global::System.IntPtr)53 + (global::System.IntPtr)75 + (global::System.IntPtr)40);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
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
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x0400007A RID: 122
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> a;

		// Token: 0x02000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000B9 RID: 185 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
			internal void b(global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo A_0)
			{
				short num = (short)601161729;
				if (num != 0)
				{
				}
				num = (short)1818398707;
				short num2 = num;
				num = (short)794791923;
				switch (num2 == num)
				{
				}
				num = (short)1716584448;
				short num3 = num;
				num = (short)1565065216;
				if (num != 0)
				{
				}
				this.a.AppendLine(A_0.ToString());
			}

			// Token: 0x0400007B RID: 123
			public global::System.Text.StringBuilder a;
		}
	}
}
