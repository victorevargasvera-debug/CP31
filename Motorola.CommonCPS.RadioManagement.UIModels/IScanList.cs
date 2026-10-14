using System;
using System.Windows.Input;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000016 RID: 22
	public interface IScanList : global::Motorola.CommonCPS.RadioManagement.UIModels.IMultiSelectionListEdit
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600009B RID: 155
		global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem FirstPriority { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009C RID: 156
		global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem SecondPriority { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009D RID: 157
		global::System.Windows.Input.ICommand SetFirstPriorityCommand { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009E RID: 158
		global::System.Windows.Input.ICommand SetSecondPriorityCommand { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009F RID: 159
		bool IsCanSetPriority { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A0 RID: 160
		bool IsShowAffiliation { get; }
	}
}
