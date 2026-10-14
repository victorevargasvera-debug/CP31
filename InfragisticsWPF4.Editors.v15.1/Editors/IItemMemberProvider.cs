using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000019 RID: 25
	public interface IItemMemberProvider
	{
		// Token: 0x060000DE RID: 222
		object GetValue(object dataItem);

		// Token: 0x060000DF RID: 223
		string GetDisplayText(object dataItem);
	}
}
