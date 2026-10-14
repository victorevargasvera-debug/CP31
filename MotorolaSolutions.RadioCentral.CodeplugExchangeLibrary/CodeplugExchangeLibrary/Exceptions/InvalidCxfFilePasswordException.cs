using System;
using System.Runtime.Serialization;

namespace CodeplugExchangeLibrary.Exceptions
{
	// Token: 0x0200000C RID: 12
	[global::System.Serializable]
	public class InvalidCxfFilePasswordException : global::System.Exception
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000044BC File Offset: 0x000026BC
		public InvalidCxfFilePasswordException()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000044D0 File Offset: 0x000026D0
		public InvalidCxfFilePasswordException(string message) : base(message)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000044E4 File Offset: 0x000026E4
		public InvalidCxfFilePasswordException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000044FC File Offset: 0x000026FC
		protected InvalidCxfFilePasswordException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004514 File Offset: 0x00002714
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(223762444 + A_1) + (global::System.IntPtr)88 + (global::System.IntPtr)88);
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
	}
}
