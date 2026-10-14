using System;
using System.Runtime.InteropServices;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000016 RID: 22
	public class TMEXAPI_64
	{
		// Token: 0x060000AB RID: 171
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMReadFile(int session_handle, byte[] state_buffer, short file_handle, byte[] read_buffer, short buff_size);

		// Token: 0x060000AC RID: 172
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern int TMExtendedStartSession(short PortNum, short PortType, int[] EnhancedOptions);

		// Token: 0x060000AD RID: 173
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMEndSession(int sessionHandle);

		// Token: 0x060000AE RID: 174
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMValidSession(int sessionHandle);

		// Token: 0x060000AF RID: 175
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMSetup(int session_handle);

		// Token: 0x060000B0 RID: 176
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMFamilySearchSetup(int session_handle, byte[] state_buffer, short family_type);

		// Token: 0x060000B1 RID: 177
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMCreateFile(int session_handle, byte[] state_buffer, out short maxwrite, byte[] fentry);

		// Token: 0x060000B2 RID: 178
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMWriteFile(int session_handle, byte[] state_buffer, short file_handle, byte[] write_buffer, short num_write);

		// Token: 0x060000B3 RID: 179
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMFirst(int session_handle, byte[] state_buffer);

		// Token: 0x060000B4 RID: 180
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMNext(int session_handle, byte[] state_buffer);

		// Token: 0x060000B5 RID: 181
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMRom(int session_handle, byte[] state_buffer, short[] ROM);

		// Token: 0x060000B6 RID: 182
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMOpenFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000B7 RID: 183
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMCloseFile(int session_handle, byte[] state_buffer, short file_handle);

		// Token: 0x060000B8 RID: 184
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMDeleteFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000B9 RID: 185
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMFormat(int session_handle, byte[] state_buffer);

		// Token: 0x060000BA RID: 186
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMFirstFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000BB RID: 187
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMNextFile(int session_handle, byte[] state_buffer, byte[] fentry);

		// Token: 0x060000BC RID: 188
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMStrongAccess(int session_handle, byte[] state_buffer);

		// Token: 0x060000BD RID: 189
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMBlockStream(int sessionHandle, byte[] dataBlock, short len);

		// Token: 0x060000BE RID: 190
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMOneWireCom(int sessionHandle, short command, short argument);

		// Token: 0x060000BF RID: 191
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMTouchReset(int session_handle);

		// Token: 0x060000C0 RID: 192
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMTouchByte(int session_handle, short outbyte);

		// Token: 0x060000C1 RID: 193
		[global::System.Runtime.InteropServices.DllImport("ibfs64.dll", SetLastError = true)]
		public static extern short TMCRC(short length, byte[] buf, ushort seed, short Type);

		// Token: 0x040000B5 RID: 181
		public const string tmexapi = "ibfs64.dll";
	}
}
