using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000019 RID: 25
	public interface IItemMemberProvider
	{
		// Token: 0x060000DC RID: 220
		object GetValue(object dataItem);

		// Token: 0x060000DD RID: 221
		string GetDisplayText(object dataItem);
	}
}
