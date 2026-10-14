using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000E7 RID: 231
	public static class VisualStates
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x0002AA50 File Offset: 0x00028C50
		public static void GoToState(global::System.Windows.Controls.Control control, bool useTransitions, params string[] stateNames)
		{
			foreach (string stateName in stateNames)
			{
				if (global::System.Windows.VisualStateManager.GoToState(control, stateName, useTransitions))
				{
					return;
				}
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0002AA7C File Offset: 0x00028C7C
		public static global::System.Windows.FrameworkElement GetImplementationRoot(global::System.Windows.DependencyObject dependencyObject)
		{
			if (1 != global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(dependencyObject))
			{
				return null;
			}
			return global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, 0) as global::System.Windows.FrameworkElement;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0002AAB4 File Offset: 0x00028CB4
		public static global::System.Windows.VisualStateGroup TryGetVisualStateGroup(global::System.Windows.DependencyObject dependencyObject, string groupName)
		{
			global::System.Windows.FrameworkElement implementationRoot = global::Infragistics.VisualStates.GetImplementationRoot(dependencyObject);
			if (implementationRoot == null)
			{
				return null;
			}
			return (from @group in global::System.Windows.VisualStateManager.GetVisualStateGroups(implementationRoot).OfType<global::System.Windows.VisualStateGroup>()
			where string.CompareOrdinal(groupName, @group.Name) == 0
			select @group).FirstOrDefault<global::System.Windows.VisualStateGroup>();
		}

		// Token: 0x04000364 RID: 868
		public const string GroupCommon = "CommonStates";

		// Token: 0x04000365 RID: 869
		public const string StateNormal = "Normal";

		// Token: 0x04000366 RID: 870
		public const string StateReadOnly = "ReadOnly";

		// Token: 0x04000367 RID: 871
		public const string StateMouseOver = "MouseOver";

		// Token: 0x04000368 RID: 872
		public const string StatePressed = "Pressed";

		// Token: 0x04000369 RID: 873
		public const string StateDisabled = "Disabled";

		// Token: 0x0400036A RID: 874
		public const string GroupFocus = "FocusStates";

		// Token: 0x0400036B RID: 875
		public const string StateUnfocused = "Unfocused";

		// Token: 0x0400036C RID: 876
		public const string StateFocused = "Focused";

		// Token: 0x0400036D RID: 877
		public const string GroupSelection = "SelectionStates";

		// Token: 0x0400036E RID: 878
		public const string StateSelected = "Selected";

		// Token: 0x0400036F RID: 879
		public const string StateUnselected = "Unselected";

		// Token: 0x04000370 RID: 880
		public const string StateSelectedInactive = "SelectedInactive";

		// Token: 0x04000371 RID: 881
		public const string GroupVisibility = "VisibilityStates";

		// Token: 0x04000372 RID: 882
		public const string StateVisible = "Visible";

		// Token: 0x04000373 RID: 883
		public const string StateHidden = "Hidden";
	}
}
