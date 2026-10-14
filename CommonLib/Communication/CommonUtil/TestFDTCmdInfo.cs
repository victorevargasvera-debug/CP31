using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000080 RID: 128
	[global::System.Serializable]
	public struct TestFDTCmdInfo
	{
		// Token: 0x04000389 RID: 905
		public global::Motorola.Common.Communication.CommonUtil.FDT_CMD _fdtCmd;

		// Token: 0x0400038A RID: 906
		public global::Motorola.Common.Communication.CommonUtil.FDTType _fdtType;

		// Token: 0x0400038B RID: 907
		public ushort _modelType;

		// Token: 0x0400038C RID: 908
		public string _unitVersion;

		// Token: 0x0400038D RID: 909
		public string _forceCpVer;
	}
}
