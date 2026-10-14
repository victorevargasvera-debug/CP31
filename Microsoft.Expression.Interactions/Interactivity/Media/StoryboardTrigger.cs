using System;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Media.Animation;

namespace Microsoft.Expression.Interactivity.Media
{
	// Token: 0x02000029 RID: 41
	public abstract class StoryboardTrigger : global::System.Windows.Interactivity.TriggerBase<global::System.Windows.DependencyObject>
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00008B2D File Offset: 0x00006D2D
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00008B3F File Offset: 0x00006D3F
		public global::System.Windows.Media.Animation.Storyboard Storyboard
		{
			get
			{
				return (global::System.Windows.Media.Animation.Storyboard)base.GetValue(global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger.StoryboardProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger.StoryboardProperty, value);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008B50 File Offset: 0x00006D50
		private static void OnStoryboardChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger storyboardTrigger = sender as global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger;
			if (storyboardTrigger != null)
			{
				storyboardTrigger.OnStoryboardChanged(args);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008B6E File Offset: 0x00006D6E
		protected virtual void OnStoryboardChanged(global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
		}

		// Token: 0x0400007F RID: 127
		public static readonly global::System.Windows.DependencyProperty StoryboardProperty = global::System.Windows.DependencyProperty.Register("Storyboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger.OnStoryboardChanged)));
	}
}
