using System;
using System.Collections.ObjectModel;

namespace AcpASKLib
{
	// Token: 0x0200003C RID: 60
	public class SystemKeyLoadedEventArgs : global::System.EventArgs
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0002EDE0 File Offset: 0x0002CFE0
		internal SystemKeyLoadedEventArgs(global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> A_0, global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData> A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0002EE04 File Offset: 0x0002D004
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> LoadedSystemKeys
		{
			get
			{
				short num = (short)1106968577;
				if (num != 0)
				{
				}
				num = (short)968425472;
				short num2 = num;
				num = (short)1452044902;
				short num3 = num;
				num = (short)1974039142;
				switch (num3 == num)
				{
				}
				num = (short)1962344448;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		public global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData> LoadedSpecialKeys
		{
			get
			{
				short num = (short)531169281;
				if (num != 0)
				{
				}
				num = (short)2034565120;
				short num2 = num;
				num = (short)732056070;
				short num3 = num;
				num = (short)2070759942;
				switch (num3 == num)
				{
				}
				num = (short)1460994048;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002EF64 File Offset: 0x0002D164
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(2056081205 + A_1) + (global::System.IntPtr)14 + (global::System.IntPtr)25);
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

		// Token: 0x040001D3 RID: 467
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SystemKeyData> a;

		// Token: 0x040001D4 RID: 468
		private global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.SpecialKeyData> b;
	}
}
