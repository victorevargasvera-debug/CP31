using System;
using System.Globalization;
using System.Linq;
using System.Windows.Controls.Properties;
using System.Windows.Media.Animation;

namespace System.Windows.Controls
{
	// Token: 0x02000003 RID: 3
	[global::System.Windows.TemplatePart(Name = "PreviousContentPresentationSite", Type = typeof(global::System.Windows.Controls.ContentControl))]
	[global::System.Windows.TemplateVisualState(GroupName = "PresentationStates", Name = "Normal")]
	[global::System.Windows.TemplateVisualState(GroupName = "PresentationStates", Name = "DefaultTransition")]
	[global::System.Windows.TemplatePart(Name = "CurrentContentPresentationSite", Type = typeof(global::System.Windows.Controls.ContentControl))]
	public class TransitioningContentControl : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020D9 File Offset: 0x000002D9
		// (set) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		private global::System.Windows.Controls.ContentPresenter CurrentContentPresentationSite { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020EA File Offset: 0x000002EA
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000002F2
		private global::System.Windows.Controls.ContentPresenter PreviousContentPresentationSite { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020FB File Offset: 0x000002FB
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000210D File Offset: 0x0000030D
		public bool IsTransitioning
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.TransitioningContentControl.IsTransitioningProperty);
			}
			private set
			{
				this._allowIsTransitioningWrite = true;
				base.SetValue(global::System.Windows.Controls.TransitioningContentControl.IsTransitioningProperty, value);
				this._allowIsTransitioningWrite = false;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002130 File Offset: 0x00000330
		private static void OnIsTransitioningPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.TransitioningContentControl transitioningContentControl = (global::System.Windows.Controls.TransitioningContentControl)d;
			if (!transitioningContentControl._allowIsTransitioningWrite)
			{
				transitioningContentControl.IsTransitioning = (bool)e.OldValue;
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.TransitiotioningContentControl_IsTransitioningReadOnly);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002169 File Offset: 0x00000369
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002174 File Offset: 0x00000374
		private global::System.Windows.Media.Animation.Storyboard CurrentTransition
		{
			get
			{
				return this._currentTransition;
			}
			set
			{
				if (this._currentTransition != null)
				{
					this._currentTransition.Completed -= this.OnTransitionCompleted;
				}
				this._currentTransition = value;
				if (this._currentTransition != null)
				{
					this._currentTransition.Completed += this.OnTransitionCompleted;
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000021C6 File Offset: 0x000003C6
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000021D8 File Offset: 0x000003D8
		public string Transition
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.TransitioningContentControl.TransitionProperty) as string;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.TransitioningContentControl.TransitionProperty, value);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021E8 File Offset: 0x000003E8
		private static void OnTransitionPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.TransitioningContentControl transitioningContentControl = (global::System.Windows.Controls.TransitioningContentControl)d;
			string value = e.NewValue as string;
			string text = e.NewValue as string;
			if (transitioningContentControl.IsTransitioning)
			{
				transitioningContentControl.AbortTransition();
			}
			global::System.Windows.Media.Animation.Storyboard storyboard = transitioningContentControl.GetStoryboard(text);
			if (storyboard != null)
			{
				transitioningContentControl.CurrentTransition = storyboard;
				return;
			}
			if (global::System.Windows.Controls.VisualStates.TryGetVisualStateGroup(transitioningContentControl, "PresentationStates") == null)
			{
				transitioningContentControl.CurrentTransition = null;
				return;
			}
			transitioningContentControl.SetValue(global::System.Windows.Controls.TransitioningContentControl.TransitionProperty, value);
			throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::System.Windows.Controls.Properties.Resources.TransitioningContentControl_TransitionNotFound, new object[]
			{
				text
			}));
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000227B File Offset: 0x0000047B
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000228D File Offset: 0x0000048D
		public bool RestartTransitionOnContentChange
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.TransitioningContentControl.RestartTransitionOnContentChangeProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.TransitioningContentControl.RestartTransitionOnContentChangeProperty, value);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022A0 File Offset: 0x000004A0
		private static void OnRestartTransitionOnContentChangePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::System.Windows.Controls.TransitioningContentControl)d).OnRestartTransitionOnContentChangeChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022C5 File Offset: 0x000004C5
		protected virtual void OnRestartTransitionOnContentChangeChanged(bool oldValue, bool newValue)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000012 RID: 18 RVA: 0x000022C7 File Offset: 0x000004C7
		// (remove) Token: 0x06000013 RID: 19 RVA: 0x000022E0 File Offset: 0x000004E0
		public event global::System.Windows.RoutedEventHandler TransitionCompleted;

		// Token: 0x06000014 RID: 20 RVA: 0x000022FC File Offset: 0x000004FC
		static TransitioningContentControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.TransitioningContentControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.TransitioningContentControl)));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023DC File Offset: 0x000005DC
		public override void OnApplyTemplate()
		{
			if (this.IsTransitioning)
			{
				this.AbortTransition();
			}
			base.OnApplyTemplate();
			this.PreviousContentPresentationSite = (base.GetTemplateChild("PreviousContentPresentationSite") as global::System.Windows.Controls.ContentPresenter);
			this.CurrentContentPresentationSite = (base.GetTemplateChild("CurrentContentPresentationSite") as global::System.Windows.Controls.ContentPresenter);
			if (this.CurrentContentPresentationSite != null)
			{
				this.CurrentContentPresentationSite.Content = base.Content;
			}
			global::System.Windows.Media.Animation.Storyboard storyboard = this.GetStoryboard(this.Transition);
			this.CurrentTransition = storyboard;
			if (storyboard == null)
			{
				string transition = this.Transition;
				this.Transition = "DefaultTransition";
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::System.Windows.Controls.Properties.Resources.TransitioningContentControl_TransitionNotFound, new object[]
				{
					transition
				}));
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Normal", false);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002499 File Offset: 0x00000699
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			this.StartTransition(oldContent, newContent);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024AC File Offset: 0x000006AC
		private void StartTransition(object oldContent, object newContent)
		{
			if (this.CurrentContentPresentationSite != null && this.PreviousContentPresentationSite != null)
			{
				this.CurrentContentPresentationSite.Content = newContent;
				this.PreviousContentPresentationSite.Content = oldContent;
				if (!this.IsTransitioning || this.RestartTransitionOnContentChange)
				{
					this.IsTransitioning = true;
					global::System.Windows.VisualStateManager.GoToState(this, "Normal", false);
					global::System.Windows.VisualStateManager.GoToState(this, this.Transition, true);
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002514 File Offset: 0x00000714
		private void OnTransitionCompleted(object sender, global::System.EventArgs e)
		{
			this.AbortTransition();
			global::System.Windows.RoutedEventHandler transitionCompleted = this.TransitionCompleted;
			if (transitionCompleted != null)
			{
				transitionCompleted(this, new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000253D File Offset: 0x0000073D
		public void AbortTransition()
		{
			global::System.Windows.VisualStateManager.GoToState(this, "Normal", false);
			this.IsTransitioning = false;
			if (this.PreviousContentPresentationSite != null)
			{
				this.PreviousContentPresentationSite.Content = null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000258C File Offset: 0x0000078C
		private global::System.Windows.Media.Animation.Storyboard GetStoryboard(string newTransition)
		{
			global::System.Windows.VisualStateGroup visualStateGroup = global::System.Windows.Controls.VisualStates.TryGetVisualStateGroup(this, "PresentationStates");
			global::System.Windows.Media.Animation.Storyboard result = null;
			if (visualStateGroup != null)
			{
				result = (from state in visualStateGroup.States.OfType<global::System.Windows.VisualState>()
				where state.Name == newTransition
				select state.Storyboard).FirstOrDefault<global::System.Windows.Media.Animation.Storyboard>();
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private const string PresentationGroup = "PresentationStates";

		// Token: 0x04000002 RID: 2
		private const string NormalState = "Normal";

		// Token: 0x04000003 RID: 3
		public const string DefaultTransitionState = "DefaultTransition";

		// Token: 0x04000004 RID: 4
		internal const string PreviousContentPresentationSitePartName = "PreviousContentPresentationSite";

		// Token: 0x04000005 RID: 5
		internal const string CurrentContentPresentationSitePartName = "CurrentContentPresentationSite";

		// Token: 0x04000006 RID: 6
		private bool _allowIsTransitioningWrite;

		// Token: 0x04000007 RID: 7
		public static readonly global::System.Windows.DependencyProperty IsTransitioningProperty = global::System.Windows.DependencyProperty.Register("IsTransitioning", typeof(bool), typeof(global::System.Windows.Controls.TransitioningContentControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.TransitioningContentControl.OnIsTransitioningPropertyChanged)));

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Media.Animation.Storyboard _currentTransition;

		// Token: 0x04000009 RID: 9
		public static readonly global::System.Windows.DependencyProperty TransitionProperty = global::System.Windows.DependencyProperty.Register("Transition", typeof(string), typeof(global::System.Windows.Controls.TransitioningContentControl), new global::System.Windows.PropertyMetadata("DefaultTransition", new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.TransitioningContentControl.OnTransitionPropertyChanged)));

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty RestartTransitionOnContentChangeProperty = global::System.Windows.DependencyProperty.Register("RestartTransitionOnContentChange", typeof(bool), typeof(global::System.Windows.Controls.TransitioningContentControl), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.TransitioningContentControl.OnRestartTransitionOnContentChangePropertyChanged)));
	}
}
