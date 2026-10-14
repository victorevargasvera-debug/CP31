using System;
using System.Runtime.InteropServices;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000015 RID: 21
	public class TMEXAPI_32
	{
		// Token: 0x06000093 RID: 147
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMReadFile(int session_handle, byte[] state_buffer, short file_handle, byte[] read_buffer, short buff_size);

		// Token: 0x06000094 RID: 148
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern int TMExtendedStartSession(short PortNum, short PortType, int[] EnhancedOptions);

		// Token: 0x06000095 RID: 149
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMEndSession(int sessionHandle);

		// Token: 0x06000096 RID: 150
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMValidSession(int sessionHandle);

		// Token: 0x06000097 RID: 151
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMSetup(int session_handle);

		// Token: 0x06000098 RID: 152
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMFamilySearchSetup(int session_handle, byte[] state_buffer, short family_type);

		// Token: 0x06000099 RID: 153
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMCreateFile(int session_handle, byte[] state_buffer, out short maxwrite, byte[] fentry);

		// Token: 0x0600009A RID: 154
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMWriteFile(int session_handle, byte[] state_buffer, short file_handle, byte[] write_buffer, short num_write);

		// Token: 0x0600009B RID: 155
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMFirst(int session_handle, byte[] state_buffer);

		// Token: 0x0600009C RID: 156
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMNext(int session_handle, byte[] state_buffer);

		// Token: 0x0600009D RID: 157
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMRom(int session_handle, byte[] state_buffer, short[] ROM);

		// Token: 0x0600009E RID: 158
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMOpenFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x0600009F RID: 159
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMCloseFile(int session_handle, byte[] state_buffer, short file_handle);

		// Token: 0x060000A0 RID: 160
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMDeleteFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000A1 RID: 161
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMFormat(int session_handle, byte[] state_buffer);

		// Token: 0x060000A2 RID: 162
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMFirstFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000A3 RID: 163
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMNextFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000A4 RID: 164
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMStrongAccess(int session_handle, byte[] state_buffer);

		// Token: 0x060000A5 RID: 165
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMBlockStream(int sessionHandle, byte[] dataBlock, short len);

		// Token: 0x060000A6 RID: 166
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMOneWireCom(int sessionHandle, short command, short argument);

		// Token: 0x060000A7 RID: 167
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMTouchReset(int session_handle);

		// Token: 0x060000A8 RID: 168
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMTouchByte(int session_handle, short outbyte);

		// Token: 0x060000A9 RID: 169
		[global::System.Runtime.InteropServices.DllImport("ibfs32.dll", SetLastError = true)]
		public static extern short TMCRC(short length, byte[] buf, ushort seed, short Type);

		// Token: 0x040000B4 RID: 180
		public const string tmexapi = "ibfs32.dll";
	}
}
