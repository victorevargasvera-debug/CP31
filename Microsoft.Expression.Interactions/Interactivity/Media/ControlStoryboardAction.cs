using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Microsoft.Expression.Interactivity.Media
{
	// Token: 0x02000028 RID: 40
	[global::System.CLSCompliant(false)]
	public class ControlStoryboardAction : global::Microsoft.Expression.Interactivity.Media.StoryboardAction
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00008A02 File Offset: 0x00006C02
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00008A14 File Offset: 0x00006C14
		public global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption ControlStoryboardOption
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption)base.GetValue(global::Microsoft.Expression.Interactivity.Media.ControlStoryboardAction.ControlStoryboardProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Media.ControlStoryboardAction.ControlStoryboardProperty, value);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008A28 File Offset: 0x00006C28
		protected override void Invoke(object parameter)
		{
			if (base.AssociatedObject != null && base.Storyboard != null)
			{
				switch (this.ControlStoryboardOption)
				{
				case global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption.Play:
					base.Storyboard.Begin();
					return;
				case global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption.Stop:
					base.Storyboard.Stop();
					return;
				case global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption.TogglePlayPause:
				{
					global::System.Windows.Media.Animation.ClockState clockState = global::System.Windows.Media.Animation.ClockState.Stopped;
					bool flag = false;
					try
					{
						clockState = base.Storyboard.GetCurrentState();
						flag = base.Storyboard.GetIsPaused();
					}
					catch (global::System.InvalidOperationException)
					{
					}
					if (clockState == global::System.Windows.Media.Animation.ClockState.Stopped)
					{
						base.Storyboard.Begin();
						return;
					}
					if (flag)
					{
						base.Storyboard.Resume();
						return;
					}
					base.Storyboard.Pause();
					return;
				}
				case global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption.Pause:
					base.Storyboard.Pause();
					return;
				case global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption.Resume:
					base.Storyboard.Resume();
					return;
				case global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption.SkipToFill:
					base.Storyboard.SkipToFill();
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0400007E RID: 126
		public static readonly global::System.Windows.DependencyProperty ControlStoryboardProperty = global::System.Windows.DependencyProperty.Register("ControlStoryboardOption", typeof(global::Microsoft.Expression.Interactivity.Media.ControlStoryboardOption), typeof(global::Microsoft.Expression.Interactivity.Media.ControlStoryboardAction));
	}
}
