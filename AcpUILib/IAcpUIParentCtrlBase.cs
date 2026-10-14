using System;
using AcpBusinessLayer;

namespace AcpUILib
{
	// Token: 0x02000006 RID: 6
	public interface IAcpUIParentCtrlBase
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22
		// (set) Token: 0x06000017 RID: 23
		global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24
		// (set) Token: 0x06000019 RID: 25
		global::AcpBusinessLayer.AcpFieldBase MyBLObject { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26
		// (set) Token: 0x0600001B RID: 27
		bool AreValuesEqual { get; set; }
	}
}
