using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000F1 RID: 241
	[global::System.Windows.TemplateVisualState(GroupName = "DisplayStates", Name = "MouseOver")]
	[global::System.Windows.TemplateVisualState(GroupName = "DisplayStates", Name = "DisplayFromLeft")]
	[global::System.Windows.TemplateVisualState(GroupName = "DisplayStates", Name = "DisplayFromRight")]
	[global::System.Windows.TemplateVisualState(GroupName = "DisplayStates", Name = "Hidden")]
	public class DropAreaIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x000207FC File Offset: 0x0001E9FC
		static DropAreaIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.DropAreaIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00020852 File Offset: 0x0001EA52
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0002085A File Offset: 0x0001EA5A
		public global::Infragistics.Controls.Grids.DropAreaIndicatorState CurrentState { get; protected set; }

		// Token: 0x060007F6 RID: 2038 RVA: 0x00020863 File Offset: 0x0001EA63
		public bool DisplayFromLeft()
		{
			this.CurrentState = global::Infragistics.Controls.Grids.DropAreaIndicatorState.Left;
			return global::System.Windows.VisualStateManager.GoToState(this, "DisplayFromLeft", true);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00020878 File Offset: 0x0001EA78
		public bool DisplayFromRight()
		{
			this.CurrentState = global::Infragistics.Controls.Grids.DropAreaIndicatorState.Right;
			return global::System.Windows.VisualStateManager.GoToState(this, "DisplayFromRight", true);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0002088D File Offset: 0x0001EA8D
		public bool Hide()
		{
			this.CurrentState = global::Infragistics.Controls.Grids.DropAreaIndicatorState.Hidden;
			return global::System.Windows.VisualStateManager.GoToState(this, "Hidden", true);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000208A2 File Offset: 0x0001EAA2
		public bool DisplayMouseOver()
		{
			this.CurrentState = global::Infragistics.Controls.Grids.DropAreaIndicatorState.MouseOver;
			return global::System.Windows.VisualStateManager.GoToState(this, "MouseOver", true);
		}
	}
}
