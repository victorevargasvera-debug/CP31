using System;
using System.Diagnostics;

namespace DevAge.Shell
{
	// Token: 0x020002AA RID: 682
	internal class Utilities
	{
		// Token: 0x060021EC RID: 8684 RVA: 0x000782E8 File Offset: 0x000764E8
		public static void OpenFile(string p_File)
		{
			global::DevAge.Shell.Utilities.ExecCommand(p_File);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000782F0 File Offset: 0x000764F0
		public static void ExecCommand(string p_Command)
		{
			global::System.Diagnostics.ProcessStartInfo processStartInfo = new global::System.Diagnostics.ProcessStartInfo(p_Command);
			processStartInfo.UseShellExecute = true;
			new global::System.Diagnostics.Process
			{
				StartInfo = processStartInfo
			}.Start();
		}
	}
}
