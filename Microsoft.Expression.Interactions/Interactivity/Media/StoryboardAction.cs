using System;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Media.Animation;

namespace Microsoft.Expression.Interactivity.Media
{
	// Token: 0x02000026 RID: 38
	public abstract class StoryboardAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.DependencyObject>
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00008979 File Offset: 0x00006B79
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000898B File Offset: 0x00006B8B
		public global::System.Windows.Media.Animation.Storyboard Storyboard
		{
			get
			{
				return (global::System.Windows.Media.Animation.Storyboard)base.GetValue(global::Microsoft.Expression.Interactivity.Media.StoryboardAction.StoryboardProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Media.StoryboardAction.StoryboardProperty, value);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000899C File Offset: 0x00006B9C
		private static void OnStoryboardChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Media.StoryboardAction storyboardAction = sender as global::Microsoft.Expression.Interactivity.Media.StoryboardAction;
			if (storyboardAction != null)
			{
				storyboardAction.OnStoryboardChanged(args);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000089BA File Offset: 0x00006BBA
		protected virtual void OnStoryboardChanged(global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
		}

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty StoryboardProperty = global::System.Windows.DependencyProperty.Register("Storyboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::Microsoft.Expression.Interactivity.Media.StoryboardAction), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Media.StoryboardAction.OnStoryboardChanged)));
	}
}
