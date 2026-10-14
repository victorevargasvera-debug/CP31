using System;
using System.IO;
using System.Reflection;

namespace Common.Communication.Simulator
{
	// Token: 0x02000010 RID: 16
	public static class VRDefinitions
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000AD90 File Offset: 0x00008F90
		// Note: this type is marked as 'beforefieldinit'.
		static VRDefinitions()
		{
			int a_ = 9;
			short num = (short)1371432166;
			short num2 = num;
			num = (short)699753702;
			switch (num2 == num)
			{
			}
			num = (short)346030080;
			short num3 = num;
			num = (short)279183361;
			if (num != 0)
			{
			}
			num = (short)641531904;
			if (num != 0)
			{
			}
			global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolderName = global::Common.Communication.Simulator.VirtualLEDevices.b("ṇ⍉㹋㩍╏㍑㡓ѕ㥗㹙㕛ㅝ፟", a_);
			global::Common.Communication.Simulator.VRDefinitions.BaseFolder = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetEntryAssembly().Location);
			global::Common.Communication.Simulator.VRDefinitions.WriteTime = 6;
			global::Common.Communication.Simulator.VRDefinitions.ReadTime = 3;
			global::Common.Communication.Simulator.VRDefinitions.UpgradeTime = 48;
			global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder = global::System.IO.Path.Combine(global::Common.Communication.Simulator.VRDefinitions.BaseFolder, global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolderName);
			global::Common.Communication.Simulator.VRDefinitions.UTBaseFolder = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
		}

		// Token: 0x04000025 RID: 37
		public static readonly string VirtualDeviceFolderName;

		// Token: 0x04000026 RID: 38
		public static readonly string BaseFolder;

		// Token: 0x04000027 RID: 39
		public static readonly int WriteTime;

		// Token: 0x04000028 RID: 40
		public static readonly int ReadTime;

		// Token: 0x04000029 RID: 41
		public static readonly int UpgradeTime;

		// Token: 0x0400002A RID: 42
		public static string VirtualDeviceFolder;

		// Token: 0x0400002B RID: 43
		public static readonly string UTBaseFolder;
	}
}
