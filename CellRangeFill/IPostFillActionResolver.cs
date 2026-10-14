using System;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000023 RID: 35
	public interface IPostFillActionResolver
	{
		// Token: 0x060000C3 RID: 195
		global::Motorola.CommonCPS.UI.CellRangeFill.PostFillAction Resolve(bool changesPending, global::System.Exception fillExcpetion);
	}
}
