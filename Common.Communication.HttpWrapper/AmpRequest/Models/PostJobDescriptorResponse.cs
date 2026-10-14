using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Motorola.Common.Communication.AmpRequest.Models
{
	// Token: 0x02000049 RID: 73
	public class PostJobDescriptorResponse
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0001056C File Offset: 0x0000E76C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0001061C File Offset: 0x0000E81C
		[global::Newtonsoft.Json.JsonProperty(Required = global::Newtonsoft.Json.Required.Always)]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> Files
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)791295744;
				short num2 = num;
				num = (short)1337079552;
				switch (num2 == num)
				{
				}
				num = (short)736821249;
				if (num != 0)
				{
				}
				num = (short)1481441280;
				short num3 = num;
				num = (short)478937088;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)668760470;
				short num2 = num;
				num = (short)816347542;
				switch (num2 == num)
				{
				}
				num = (short)1671299073;
				if (num != 0)
				{
				}
				num = (short)40042496;
				short num3 = num;
				num = (short)892796928;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000106E4 File Offset: 0x0000E8E4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1291829576 + A_1) + (global::System.IntPtr)31 + (global::System.IntPtr)83);
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

		// Token: 0x040000AA RID: 170
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> a;
	}
}
