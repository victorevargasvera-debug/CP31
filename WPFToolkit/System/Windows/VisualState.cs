using System;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace System.Windows
{
	// Token: 0x02000002 RID: 2
	[global::System.Windows.Markup.ContentProperty("Storyboard")]
	[global::System.Windows.Markup.RuntimeNameProperty("Name")]
	public class VisualState : global::System.Windows.DependencyObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public string Name { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020F3 File Offset: 0x000002F3
		public global::System.Windows.Media.Animation.Storyboard Storyboard
		{
			get
			{
				return (global::System.Windows.Media.Animation.Storyboard)base.GetValue(global::System.Windows.VisualState.StoryboardProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.VisualState.StoryboardProperty, value);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly global::System.Windows.DependencyProperty StoryboardProperty = global::System.Windows.DependencyProperty.Register("Storyboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::System.Windows.VisualState));
	}
}
