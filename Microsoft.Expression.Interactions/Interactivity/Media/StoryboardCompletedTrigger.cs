using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Microsoft.Expression.Interactivity.Media
{
	// Token: 0x0200002A RID: 42
	public class StoryboardCompletedTrigger : global::Microsoft.Expression.Interactivity.Media.StoryboardTrigger
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00008BB6 File Offset: 0x00006DB6
		protected override void OnDetaching()
		{
			base.OnDetaching();
			if (base.Storyboard != null)
			{
				base.Storyboard.Completed -= this.Storyboard_Completed;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008BE0 File Offset: 0x00006DE0
		protected override void OnStoryboardChanged(global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = args.OldValue as global::System.Windows.Media.Animation.Storyboard;
			global::System.Windows.Media.Animation.Storyboard storyboard2 = args.NewValue as global::System.Windows.Media.Animation.Storyboard;
			if (storyboard != storyboard2)
			{
				if (storyboard != null)
				{
					storyboard.Completed -= this.Storyboard_Completed;
				}
				if (storyboard2 != null)
				{
					storyboard2.Completed += this.Storyboard_Completed;
				}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00008C35 File Offset: 0x00006E35
		private void Storyboard_Completed(object sender, global::System.EventArgs e)
		{
			base.InvokeActions(e);
		}
	}
}
