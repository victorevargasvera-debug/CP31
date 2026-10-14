using System;

namespace System.Windows.Controls.Primitives
{
	// Token: 0x02000004 RID: 4
	[global::System.Windows.TemplateVisualState(Name = "ExpandDown", GroupName = "ExpandDirectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandRight", GroupName = "ExpandDirectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Expanded", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Collapsed", GroupName = "ExpansionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandUp", GroupName = "ExpandDirectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "ExpandLeft", GroupName = "ExpandDirectionStates")]
	public class AccordionButton : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002603 File Offset: 0x00000803
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000260B File Offset: 0x0000080B
		internal global::System.Windows.Controls.AccordionItem ParentAccordionItem { get; set; }

		// Token: 0x0600001F RID: 31 RVA: 0x00002614 File Offset: 0x00000814
		static AccordionButton()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.Primitives.AccordionButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.Primitives.AccordionButton)));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002644 File Offset: 0x00000844
		internal virtual void UpdateVisualState(bool useTransitions)
		{
			if (this.ParentAccordionItem == null)
			{
				return;
			}
			if (this.ParentAccordionItem.IsSelected)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Expanded"
				});
			}
			else
			{
				global::System.Windows.Controls.VisualStates.GoToState(this, useTransitions, new string[]
				{
					"Collapsed"
				});
			}
			switch (this.ParentAccordionItem.ExpandDirection)
			{
			case global::System.Windows.Controls.ExpandDirection.Down:
				global::System.Windows.Controls.VisualStates.GoToState(this, false, new string[]
				{
					"ExpandDown"
				});
				return;
			case global::System.Windows.Controls.ExpandDirection.Up:
				global::System.Windows.Controls.VisualStates.GoToState(this, false, new string[]
				{
					"ExpandUp"
				});
				return;
			case global::System.Windows.Controls.ExpandDirection.Left:
				global::System.Windows.Controls.VisualStates.GoToState(this, false, new string[]
				{
					"ExpandLeft"
				});
				return;
			default:
				global::System.Windows.Controls.VisualStates.GoToState(this, false, new string[]
				{
					"ExpandRight"
				});
				return;
			}
		}
	}
}
