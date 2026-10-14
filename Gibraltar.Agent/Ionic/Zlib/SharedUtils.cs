using System;
using System.IO;
using System.Text;

namespace Ionic.Zlib
{
	// Token: 0x02000438 RID: 1080
	internal class SharedUtils
	{
		// Token: 0x06002EC1 RID: 11969 RVA: 0x000A3514 File Offset: 0x000A1714
		public static int URShift(int number, int bits)
		{
			return (int)((uint)number >> bits);
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000A351C File Offset: 0x000A171C
		public static int ReadInput(global::System.IO.TextReader sourceTextReader, byte[] target, int start, int count)
		{
			if (target.Length == 0)
			{
				return 0;
			}
			char[] array = new char[target.Length];
			int num = sourceTextReader.Read(array, start, count);
			if (num == 0)
			{
				return -1;
			}
			for (int i = start; i < start + num; i++)
			{
				target[i] = (byte)array[i];
			}
			return num;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000A356C File Offset: 0x000A176C
		internal static byte[] ToByteArray(string sourceString)
		{
			return global::System.Text.Encoding.UTF8.GetBytes(sourceString);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000A357C File Offset: 0x000A177C
		internal static char[] ToCharArray(byte[] byteArray)
		{
			return global::System.Text.Encoding.UTF8.GetChars(byteArray);
		}
	}
}
