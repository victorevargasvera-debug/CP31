using System;
using System.Runtime.CompilerServices;
using AcpASKLib;

namespace AcpBusinessLayer
{
	// Token: 0x0200003D RID: 61
	public static class TrunkingSystemData
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00064984 File Offset: 0x00062B84
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00064A34 File Offset: 0x00062C34
		public static bool PartialXmlExport
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1933297720;
				short num2 = num;
				num = (short)1661782072;
				switch (num2 == num)
				{
				}
				num = (short)1376321536;
				short num3 = num;
				num = (short)337641473;
				if (num != 0)
				{
				}
				num = (short)864681984;
				if (num != 0)
				{
				}
				return global::AcpBusinessLayer.TrunkingSystemData.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1286311552;
				short num2 = num;
				num = (short)496078464;
				switch (num2 == num)
				{
				}
				num = (short)1604386816;
				short num3 = num;
				num = (short)533266432;
				if (num != 0)
				{
				}
				num = (short)1824260097;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.TrunkingSystemData.a = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00064AE4 File Offset: 0x00062CE4
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00064B90 File Offset: 0x00062D90
		public static global::AcpASKLib.ISystemKeyMgr SystemKeyManager
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1727791105;
				if (num != 0)
				{
				}
				num = (short)1699428588;
				short num2 = num;
				num = (short)1359624428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1375207424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1048182784;
				if (num != 0)
				{
				}
				return global::AcpBusinessLayer.TrunkingSystemData.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)388038657;
				if (num != 0)
				{
				}
				num = (short)847606905;
				short num2 = num;
				num = (short)607876217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80019456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331087872;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.TrunkingSystemData.b = value;
			}
		}

		// Token: 0x0400013F RID: 319
		public const string RECSET_ID = "2064";

		// Token: 0x04000140 RID: 320
		public const string ASK_REQUIRED_FIELD_NAME = "TrkSysGeneralAskRequired_A44909";

		// Token: 0x04000141 RID: 321
		public const string SYSTEM_ID_FIELD_NAME = "TrkSysGeneralSystemID_A9239";

		// Token: 0x04000142 RID: 322
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool a;

		// Token: 0x04000143 RID: 323
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpASKLib.ISystemKeyMgr b;
	}
}
