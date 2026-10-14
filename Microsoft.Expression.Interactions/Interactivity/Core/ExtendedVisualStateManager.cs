using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using Microsoft.Expression.Media.Effects;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x02000013 RID: 19
	public class ExtendedVisualStateManager : global::System.Windows.VisualStateManager
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003C8D File Offset: 0x00001E8D
		public static bool IsRunningFluidLayoutTransition
		{
			get
			{
				return global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard != null;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003C9A File Offset: 0x00001E9A
		public static bool GetUseFluidLayout(global::System.Windows.DependencyObject obj)
		{
			return (bool)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.UseFluidLayoutProperty);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003CAC File Offset: 0x00001EAC
		public static void SetUseFluidLayout(global::System.Windows.DependencyObject obj, bool value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.UseFluidLayoutProperty, value);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003CBF File Offset: 0x00001EBF
		public static global::System.Windows.DependencyProperty GetRuntimeVisibilityProperty(global::System.Windows.DependencyObject obj)
		{
			return (global::System.Windows.DependencyProperty)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.RuntimeVisibilityPropertyProperty);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003CD1 File Offset: 0x00001ED1
		public static void SetRuntimeVisibilityProperty(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyProperty value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.RuntimeVisibilityPropertyProperty, value);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003CDF File Offset: 0x00001EDF
		internal static global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord> GetOriginalLayoutValues(global::System.Windows.DependencyObject obj)
		{
			return (global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord>)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValuesProperty);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003CF1 File Offset: 0x00001EF1
		internal static void SetOriginalLayoutValues(global::System.Windows.DependencyObject obj, global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord> value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValuesProperty, value);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003CFF File Offset: 0x00001EFF
		internal static global::System.Windows.Media.Animation.Storyboard GetLayoutStoryboard(global::System.Windows.DependencyObject obj)
		{
			return (global::System.Windows.Media.Animation.Storyboard)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutStoryboardProperty);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003D11 File Offset: 0x00001F11
		internal static void SetLayoutStoryboard(global::System.Windows.DependencyObject obj, global::System.Windows.Media.Animation.Storyboard value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutStoryboardProperty, value);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003D1F File Offset: 0x00001F1F
		internal static global::System.Windows.VisualState GetCurrentState(global::System.Windows.DependencyObject obj)
		{
			return (global::System.Windows.VisualState)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CurrentStateProperty);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003D31 File Offset: 0x00001F31
		internal static void SetCurrentState(global::System.Windows.DependencyObject obj, global::System.Windows.VisualState value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CurrentStateProperty, value);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003D3F File Offset: 0x00001F3F
		public static global::Microsoft.Expression.Media.Effects.TransitionEffect GetTransitionEffect(global::System.Windows.DependencyObject obj)
		{
			return (global::Microsoft.Expression.Media.Effects.TransitionEffect)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransitionEffectProperty);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003D51 File Offset: 0x00001F51
		public static void SetTransitionEffect(global::System.Windows.DependencyObject obj, global::Microsoft.Expression.Media.Effects.TransitionEffect value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransitionEffectProperty, value);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003D5F File Offset: 0x00001F5F
		internal static global::System.Windows.Media.Animation.Storyboard GetTransitionEffectStoryboard(global::System.Windows.DependencyObject obj)
		{
			return (global::System.Windows.Media.Animation.Storyboard)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransitionEffectStoryboardProperty);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003D71 File Offset: 0x00001F71
		internal static void SetTransitionEffectStoryboard(global::System.Windows.DependencyObject obj, global::System.Windows.Media.Animation.Storyboard value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransitionEffectStoryboardProperty, value);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003D7F File Offset: 0x00001F7F
		internal static bool GetDidCacheBackground(global::System.Windows.DependencyObject obj)
		{
			return (bool)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DidCacheBackgroundProperty);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003D91 File Offset: 0x00001F91
		internal static void SetDidCacheBackground(global::System.Windows.DependencyObject obj, bool value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DidCacheBackgroundProperty, value);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003DA4 File Offset: 0x00001FA4
		internal static object GetCachedBackground(global::System.Windows.DependencyObject obj)
		{
			return obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedBackgroundProperty);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003DB1 File Offset: 0x00001FB1
		internal static void SetCachedBackground(global::System.Windows.DependencyObject obj, object value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedBackgroundProperty, value);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003DBF File Offset: 0x00001FBF
		internal static global::System.Windows.Media.Effects.Effect GetCachedEffect(global::System.Windows.DependencyObject obj)
		{
			return (global::System.Windows.Media.Effects.Effect)obj.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedEffectProperty);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003DD1 File Offset: 0x00001FD1
		internal static void SetCachedEffect(global::System.Windows.DependencyObject obj, global::System.Windows.Media.Effects.Effect value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedEffectProperty, value);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003DDF File Offset: 0x00001FDF
		private static bool IsVisibilityProperty(global::System.Windows.DependencyProperty property)
		{
			return property == global::System.Windows.UIElement.VisibilityProperty || property.Name == "RuntimeVisibility";
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003DFC File Offset: 0x00001FFC
		private static global::System.Windows.DependencyProperty LayoutPropertyFromTimeline(global::System.Windows.Media.Animation.Timeline timeline, bool forceRuntimeProperty)
		{
			global::System.Windows.PropertyPath targetProperty = global::System.Windows.Media.Animation.Storyboard.GetTargetProperty(timeline);
			if (targetProperty == null || targetProperty.PathParameters == null || targetProperty.PathParameters.Count == 0)
			{
				return null;
			}
			global::System.Windows.DependencyProperty dependencyProperty = targetProperty.PathParameters[0] as global::System.Windows.DependencyProperty;
			if (dependencyProperty != null)
			{
				if (dependencyProperty.Name == "RuntimeVisibility" && dependencyProperty.OwnerType.Name.EndsWith("DesignTimeProperties", global::System.StringComparison.Ordinal))
				{
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Contains(dependencyProperty))
					{
						global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Add(dependencyProperty);
					}
					if (!forceRuntimeProperty)
					{
						return global::System.Windows.UIElement.VisibilityProperty;
					}
					return dependencyProperty;
				}
				else if (dependencyProperty.Name == "RuntimeWidth" && dependencyProperty.OwnerType.Name.EndsWith("DesignTimeProperties", global::System.StringComparison.Ordinal))
				{
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Contains(dependencyProperty))
					{
						global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Add(dependencyProperty);
					}
					if (!forceRuntimeProperty)
					{
						return global::System.Windows.FrameworkElement.WidthProperty;
					}
					return dependencyProperty;
				}
				else if (dependencyProperty.Name == "RuntimeHeight" && dependencyProperty.OwnerType.Name.EndsWith("DesignTimeProperties", global::System.StringComparison.Ordinal))
				{
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Contains(dependencyProperty))
					{
						global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Add(dependencyProperty);
					}
					if (!forceRuntimeProperty)
					{
						return global::System.Windows.FrameworkElement.HeightProperty;
					}
					return dependencyProperty;
				}
				else if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties.Contains(dependencyProperty))
				{
					return dependencyProperty;
				}
			}
			return null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003F60 File Offset: 0x00002160
		protected override bool GoToStateCore(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement stateGroupsRoot, string stateName, global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState state, bool useTransitions)
		{
			if (this.changingState)
			{
				return false;
			}
			if (group == null || state == null)
			{
				return false;
			}
			global::System.Windows.VisualState currentState = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetCurrentState(group);
			if (currentState == state)
			{
				return true;
			}
			global::System.Windows.VisualTransition transition = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.FindTransition(group, currentState, state);
			bool animateWithTransitionEffect = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.PrepareTransitionEffectImage(stateGroupsRoot, useTransitions, transition);
			if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetUseFluidLayout(group))
			{
				return this.TransitionEffectAwareGoToStateCore(control, stateGroupsRoot, stateName, group, state, useTransitions, transition, animateWithTransitionEffect, currentState);
			}
			global::System.Windows.Media.Animation.Storyboard storyboard = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ExtractLayoutStoryboard(state);
			global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord> list = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetOriginalLayoutValues(group);
			if (list == null)
			{
				list = new global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord>();
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetOriginalLayoutValues(group, list);
			}
			if (!useTransitions)
			{
				if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard != null)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.StopAnimations();
				}
				bool result = this.TransitionEffectAwareGoToStateCore(control, stateGroupsRoot, stateName, group, state, useTransitions, transition, animateWithTransitionEffect, currentState);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetLayoutStoryboardProperties(control, stateGroupsRoot, storyboard, list);
				return result;
			}
			if (storyboard.Children.Count == 0 && list.Count == 0)
			{
				return this.TransitionEffectAwareGoToStateCore(control, stateGroupsRoot, stateName, group, state, useTransitions, transition, animateWithTransitionEffect, currentState);
			}
			try
			{
				this.changingState = true;
				stateGroupsRoot.UpdateLayout();
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list2 = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.FindTargetElements(control, stateGroupsRoot, storyboard, list, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements);
				global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect> rectsOfTargets = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetRectsOfTargets(list2, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements);
				global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, double> oldOpacities = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetOldOpacities(control, stateGroupsRoot, storyboard, list, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements);
				if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard != null)
				{
					stateGroupsRoot.LayoutUpdated -= global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.control_LayoutUpdated;
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.StopAnimations();
					stateGroupsRoot.UpdateLayout();
				}
				this.TransitionEffectAwareGoToStateCore(control, stateGroupsRoot, stateName, group, state, useTransitions, transition, animateWithTransitionEffect, currentState);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetLayoutStoryboardProperties(control, stateGroupsRoot, storyboard, list);
				stateGroupsRoot.UpdateLayout();
				global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect> rectsOfTargets2 = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetRectsOfTargets(list2, null);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				foreach (global::System.Windows.FrameworkElement frameworkElement in list2)
				{
					if (rectsOfTargets[frameworkElement] != rectsOfTargets2[frameworkElement])
					{
						global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements.Add(frameworkElement);
					}
				}
				foreach (global::System.Windows.FrameworkElement item in oldOpacities.Keys)
				{
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements.Contains(item))
					{
						global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements.Add(item);
					}
				}
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapMovingElementsInCanvases(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements, rectsOfTargets, rectsOfTargets2);
				stateGroupsRoot.LayoutUpdated += global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.control_LayoutUpdated;
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CreateLayoutTransitionStoryboard(transition, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements, oldOpacities);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard.Completed += delegate(object sender, global::System.EventArgs args)
				{
					stateGroupsRoot.LayoutUpdated -= global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.control_LayoutUpdated;
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.StopAnimations();
				};
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard.Begin();
			}
			finally
			{
				this.changingState = false;
			}
			return true;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004298 File Offset: 0x00002498
		private static void control_LayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard != null)
			{
				foreach (global::System.Windows.FrameworkElement frameworkElement in global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = frameworkElement.Parent as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
					if (wrapperCanvas != null)
					{
						global::System.Windows.Rect layoutRect = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetLayoutRect(wrapperCanvas);
						global::System.Windows.Rect newRect = wrapperCanvas.NewRect;
						global::System.Windows.Media.TranslateTransform translateTransform = wrapperCanvas.RenderTransform as global::System.Windows.Media.TranslateTransform;
						double num = (translateTransform == null) ? 0.0 : translateTransform.X;
						double num2 = (translateTransform == null) ? 0.0 : translateTransform.Y;
						double num3 = newRect.Left - layoutRect.Left;
						double num4 = newRect.Top - layoutRect.Top;
						if (num != num3 || num2 != num4)
						{
							if (translateTransform == null)
							{
								translateTransform = new global::System.Windows.Media.TranslateTransform();
								wrapperCanvas.RenderTransform = translateTransform;
							}
							translateTransform.X = num3;
							translateTransform.Y = num4;
						}
					}
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000043A4 File Offset: 0x000025A4
		private static void StopAnimations()
		{
			if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard != null)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard.Stop();
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutTransitionStoryboard = null;
			}
			if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements != null)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.UnwrapMovingElementsFromCanvases(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.MovingElements = null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000043D4 File Offset: 0x000025D4
		private static bool PrepareTransitionEffectImage(global::System.Windows.FrameworkElement stateGroupsRoot, bool useTransitions, global::System.Windows.VisualTransition transition)
		{
			global::Microsoft.Expression.Media.Effects.TransitionEffect transitionEffect = (transition == null) ? null : global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTransitionEffect(transition);
			bool result = false;
			if (transitionEffect != null)
			{
				transitionEffect = transitionEffect.CloneCurrentValue();
				if (useTransitions)
				{
					result = true;
					int pixelWidth = (int)global::System.Math.Max(1.0, stateGroupsRoot.ActualWidth);
					int pixelHeight = (int)global::System.Math.Max(1.0, stateGroupsRoot.ActualHeight);
					global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap(pixelWidth, pixelHeight, 96.0, 96.0, global::System.Windows.Media.PixelFormats.Pbgra32);
					renderTargetBitmap.Render(stateGroupsRoot);
					transitionEffect.OldImage = new global::System.Windows.Media.ImageBrush
					{
						ImageSource = renderTargetBitmap
					};
				}
				global::System.Windows.Media.Animation.Storyboard transitionEffectStoryboard = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTransitionEffectStoryboard(stateGroupsRoot);
				if (transitionEffectStoryboard != null)
				{
					transitionEffectStoryboard.Stop();
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.FinishTransitionEffectAnimation(stateGroupsRoot);
				}
				if (useTransitions)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransferLocalValue(stateGroupsRoot, global::System.Windows.UIElement.EffectProperty, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedEffectProperty);
					stateGroupsRoot.Effect = transitionEffect;
				}
			}
			return result;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000044A4 File Offset: 0x000026A4
		private bool TransitionEffectAwareGoToStateCore(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement stateGroupsRoot, string stateName, global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState state, bool useTransitions, global::System.Windows.VisualTransition transition, bool animateWithTransitionEffect, global::System.Windows.VisualState previousState)
		{
			global::System.Windows.Media.Animation.IEasingFunction generatedEasingFunction = null;
			if (animateWithTransitionEffect)
			{
				generatedEasingFunction = transition.GeneratedEasingFunction;
				transition.GeneratedEasingFunction = new global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DummyEasingFunction
				{
					DummyValue = (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.FinishesWithZeroOpacity(control, stateGroupsRoot, state, previousState) ? 0.01 : 0.0)
				};
			}
			bool flag = base.GoToStateCore(control, stateGroupsRoot, stateName, group, state, useTransitions);
			if (animateWithTransitionEffect)
			{
				transition.GeneratedEasingFunction = generatedEasingFunction;
				if (flag)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.AnimateTransitionEffect(stateGroupsRoot, transition);
				}
			}
			global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetCurrentState(group, state);
			return flag;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004528 File Offset: 0x00002728
		private static bool FinishesWithZeroOpacity(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement stateGroupsRoot, global::System.Windows.VisualState state, global::System.Windows.VisualState previousState)
		{
			if (state.Storyboard != null)
			{
				foreach (global::System.Windows.Media.Animation.Timeline timeline in state.Storyboard.Children)
				{
					if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TimelineIsAnimatingRootOpacity(timeline, control, stateGroupsRoot))
					{
						bool flag;
						object valueFromTimeline = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetValueFromTimeline(timeline, out flag);
						return flag && valueFromTimeline is double && (double)valueFromTimeline == 0.0;
					}
				}
			}
			if (previousState != null && previousState.Storyboard != null)
			{
				foreach (global::System.Windows.Media.Animation.Timeline timeline2 in previousState.Storyboard.Children)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TimelineIsAnimatingRootOpacity(timeline2, control, stateGroupsRoot);
				}
				double num = (double)stateGroupsRoot.GetAnimationBaseValue(global::System.Windows.UIElement.OpacityProperty);
				return num == 0.0;
			}
			return stateGroupsRoot.Opacity == 0.0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004644 File Offset: 0x00002844
		private static bool TimelineIsAnimatingRootOpacity(global::System.Windows.Media.Animation.Timeline timeline, global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement stateGroupsRoot)
		{
			if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTimelineTarget(control, stateGroupsRoot, timeline) != stateGroupsRoot)
			{
				return false;
			}
			global::System.Windows.PropertyPath targetProperty = global::System.Windows.Media.Animation.Storyboard.GetTargetProperty(timeline);
			return targetProperty != null && targetProperty.PathParameters != null && targetProperty.PathParameters.Count != 0 && targetProperty.PathParameters[0] == global::System.Windows.UIElement.OpacityProperty;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000046CC File Offset: 0x000028CC
		private static void AnimateTransitionEffect(global::System.Windows.FrameworkElement stateGroupsRoot, global::System.Windows.VisualTransition transition)
		{
			global::System.Windows.Media.Effects.Effect effect = stateGroupsRoot.Effect;
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			doubleAnimation.Duration = transition.GeneratedDuration;
			doubleAnimation.EasingFunction = transition.GeneratedEasingFunction;
			doubleAnimation.From = new double?(0.0);
			doubleAnimation.To = new double?(1.0);
			global::System.Windows.Media.Animation.Storyboard sb = new global::System.Windows.Media.Animation.Storyboard();
			sb.Duration = transition.GeneratedDuration;
			sb.Children.Add(doubleAnimation);
			global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation, stateGroupsRoot);
			global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath("(0).(1)", new global::System.Windows.DependencyProperty[]
			{
				global::System.Windows.UIElement.EffectProperty,
				global::Microsoft.Expression.Media.Effects.TransitionEffect.ProgressProperty
			}));
			global::System.Windows.Controls.Panel panel = stateGroupsRoot as global::System.Windows.Controls.Panel;
			if (panel != null && panel.Background == null)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetDidCacheBackground(panel, true);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransferLocalValue(panel, global::System.Windows.Controls.Panel.BackgroundProperty, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedBackgroundProperty);
				panel.Background = global::System.Windows.Media.Brushes.Transparent;
			}
			sb.Completed += delegate(object sender, global::System.EventArgs e)
			{
				global::System.Windows.Media.Animation.Storyboard transitionEffectStoryboard = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTransitionEffectStoryboard(stateGroupsRoot);
				if (transitionEffectStoryboard == sb)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.FinishTransitionEffectAnimation(stateGroupsRoot);
				}
			};
			global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetTransitionEffectStoryboard(stateGroupsRoot, sb);
			sb.Begin();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004805 File Offset: 0x00002A05
		private static void FinishTransitionEffectAnimation(global::System.Windows.FrameworkElement stateGroupsRoot)
		{
			global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetTransitionEffectStoryboard(stateGroupsRoot, null);
			global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransferLocalValue(stateGroupsRoot, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedEffectProperty, global::System.Windows.UIElement.EffectProperty);
			if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetDidCacheBackground(stateGroupsRoot))
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.TransferLocalValue(stateGroupsRoot, global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CachedBackgroundProperty, global::System.Windows.Controls.Panel.BackgroundProperty);
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetDidCacheBackground(stateGroupsRoot, false);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004840 File Offset: 0x00002A40
		private static global::System.Windows.VisualTransition FindTransition(global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState previousState, global::System.Windows.VisualState state)
		{
			string b = (previousState != null) ? previousState.Name : string.Empty;
			string b2 = (state != null) ? state.Name : string.Empty;
			int num = -1;
			global::System.Windows.VisualTransition result = null;
			if (group.Transitions != null)
			{
				foreach (object obj in group.Transitions)
				{
					global::System.Windows.VisualTransition visualTransition = (global::System.Windows.VisualTransition)obj;
					int num2 = 0;
					if (visualTransition.From == b)
					{
						num2++;
					}
					else if (!string.IsNullOrEmpty(visualTransition.From))
					{
						continue;
					}
					if (visualTransition.To == b2)
					{
						num2 += 2;
					}
					else if (!string.IsNullOrEmpty(visualTransition.To))
					{
						continue;
					}
					if (num2 > num)
					{
						num = num2;
						result = visualTransition;
					}
				}
			}
			return result;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004924 File Offset: 0x00002B24
		private static global::System.Windows.Media.Animation.Storyboard ExtractLayoutStoryboard(global::System.Windows.VisualState state)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = null;
			if (state.Storyboard != null)
			{
				storyboard = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetLayoutStoryboard(state.Storyboard);
				if (storyboard == null)
				{
					storyboard = new global::System.Windows.Media.Animation.Storyboard();
					for (int i = state.Storyboard.Children.Count - 1; i >= 0; i--)
					{
						global::System.Windows.Media.Animation.Timeline timeline = state.Storyboard.Children[i];
						if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutPropertyFromTimeline(timeline, false) != null)
						{
							state.Storyboard.Children.RemoveAt(i);
							storyboard.Children.Add(timeline);
						}
					}
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.SetLayoutStoryboard(state.Storyboard, storyboard);
				}
			}
			if (storyboard == null)
			{
				return new global::System.Windows.Media.Animation.Storyboard();
			}
			return storyboard;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000049BC File Offset: 0x00002BBC
		private static global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> FindTargetElements(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement templateRoot, global::System.Windows.Media.Animation.Storyboard layoutStoryboard, global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord> originalValueRecords, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> movingElements)
		{
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
			if (movingElements != null)
			{
				list.AddRange(movingElements);
			}
			foreach (global::System.Windows.Media.Animation.Timeline timeline in layoutStoryboard.Children)
			{
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTimelineTarget(control, templateRoot, timeline);
				if (frameworkElement != null)
				{
					if (!list.Contains(frameworkElement))
					{
						list.Add(frameworkElement);
					}
					if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ChildAffectingLayoutProperties.Contains(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutPropertyFromTimeline(timeline, false)))
					{
						global::System.Windows.Controls.Panel panel = frameworkElement as global::System.Windows.Controls.Panel;
						if (panel != null)
						{
							foreach (object obj in panel.Children)
							{
								global::System.Windows.FrameworkElement frameworkElement2 = (global::System.Windows.FrameworkElement)obj;
								if (!list.Contains(frameworkElement2) && !(frameworkElement2 is global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas))
								{
									list.Add(frameworkElement2);
								}
							}
						}
					}
				}
			}
			foreach (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord originalLayoutValueRecord in originalValueRecords)
			{
				if (!list.Contains(originalLayoutValueRecord.Element))
				{
					list.Add(originalLayoutValueRecord.Element);
				}
				if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ChildAffectingLayoutProperties.Contains(originalLayoutValueRecord.Property))
				{
					global::System.Windows.Controls.Panel panel2 = originalLayoutValueRecord.Element as global::System.Windows.Controls.Panel;
					if (panel2 != null)
					{
						foreach (object obj2 in panel2.Children)
						{
							global::System.Windows.FrameworkElement frameworkElement3 = (global::System.Windows.FrameworkElement)obj2;
							if (!list.Contains(frameworkElement3) && !(frameworkElement3 is global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas))
							{
								list.Add(frameworkElement3);
							}
						}
					}
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement4 = list[i];
				global::System.Windows.FrameworkElement frameworkElement5 = global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement4) as global::System.Windows.FrameworkElement;
				if (movingElements != null && movingElements.Contains(frameworkElement4) && frameworkElement5 is global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas)
				{
					frameworkElement5 = (global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement5) as global::System.Windows.FrameworkElement);
				}
				if (frameworkElement5 != null)
				{
					if (!list.Contains(frameworkElement5))
					{
						list.Add(frameworkElement5);
					}
					for (int j = 0; j < global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(frameworkElement5); j++)
					{
						global::System.Windows.FrameworkElement frameworkElement6 = global::System.Windows.Media.VisualTreeHelper.GetChild(frameworkElement5, j) as global::System.Windows.FrameworkElement;
						if (frameworkElement6 != null && !list.Contains(frameworkElement6) && !(frameworkElement6 is global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas))
						{
							list.Add(frameworkElement6);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004C60 File Offset: 0x00002E60
		private static object GetTimelineTarget(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement templateRoot, global::System.Windows.Media.Animation.Timeline timeline)
		{
			string targetName = global::System.Windows.Media.Animation.Storyboard.GetTargetName(timeline);
			if (string.IsNullOrEmpty(targetName))
			{
				return null;
			}
			if (control is global::System.Windows.Controls.UserControl)
			{
				return control.FindName(targetName);
			}
			return templateRoot.FindName(targetName);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004C98 File Offset: 0x00002E98
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect> GetRectsOfTargets(global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> targets, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> movingElements)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect>();
			foreach (global::System.Windows.FrameworkElement frameworkElement in targets)
			{
				global::System.Windows.Rect layoutRect;
				if (movingElements != null && movingElements.Contains(frameworkElement) && frameworkElement.Parent is global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = frameworkElement.Parent as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
					layoutRect = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetLayoutRect(wrapperCanvas);
					global::System.Windows.Media.TranslateTransform translateTransform = wrapperCanvas.RenderTransform as global::System.Windows.Media.TranslateTransform;
					double left = global::System.Windows.Controls.Canvas.GetLeft(frameworkElement);
					double top = global::System.Windows.Controls.Canvas.GetTop(frameworkElement);
					layoutRect = new global::System.Windows.Rect(layoutRect.Left + (double.IsNaN(left) ? 0.0 : left) + ((translateTransform == null) ? 0.0 : translateTransform.X), layoutRect.Top + (double.IsNaN(top) ? 0.0 : top) + ((translateTransform == null) ? 0.0 : translateTransform.Y), frameworkElement.ActualWidth, frameworkElement.ActualHeight);
				}
				else
				{
					layoutRect = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetLayoutRect(frameworkElement);
				}
				dictionary.Add(frameworkElement, layoutRect);
			}
			return dictionary;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004DD0 File Offset: 0x00002FD0
		internal static global::System.Windows.Rect GetLayoutRect(global::System.Windows.FrameworkElement element)
		{
			double num = element.ActualWidth;
			double num2 = element.ActualHeight;
			if (element is global::System.Windows.Controls.Image || element is global::System.Windows.Controls.MediaElement)
			{
				if (element.Parent.GetType() == typeof(global::System.Windows.Controls.Canvas))
				{
					num = (double.IsNaN(element.Width) ? num : element.Width);
					num2 = (double.IsNaN(element.Height) ? num2 : element.Height);
				}
				else
				{
					num = element.RenderSize.Width;
					num2 = element.RenderSize.Height;
				}
			}
			num = ((element.Visibility == global::System.Windows.Visibility.Collapsed) ? 0.0 : num);
			num2 = ((element.Visibility == global::System.Windows.Visibility.Collapsed) ? 0.0 : num2);
			global::System.Windows.Thickness margin = element.Margin;
			global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(element);
			double x = 0.0;
			double y = 0.0;
			switch (element.HorizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				x = layoutSlot.Left + margin.Left;
				break;
			case global::System.Windows.HorizontalAlignment.Center:
				x = (layoutSlot.Left + margin.Left + layoutSlot.Right - margin.Right) / 2.0 - num / 2.0;
				break;
			case global::System.Windows.HorizontalAlignment.Right:
				x = layoutSlot.Right - margin.Right - num;
				break;
			case global::System.Windows.HorizontalAlignment.Stretch:
				x = global::System.Math.Max(layoutSlot.Left + margin.Left, (layoutSlot.Left + margin.Left + layoutSlot.Right - margin.Right) / 2.0 - num / 2.0);
				break;
			}
			switch (element.VerticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Top:
				y = layoutSlot.Top + margin.Top;
				break;
			case global::System.Windows.VerticalAlignment.Center:
				y = (layoutSlot.Top + margin.Top + layoutSlot.Bottom - margin.Bottom) / 2.0 - num2 / 2.0;
				break;
			case global::System.Windows.VerticalAlignment.Bottom:
				y = layoutSlot.Bottom - margin.Bottom - num2;
				break;
			case global::System.Windows.VerticalAlignment.Stretch:
				y = global::System.Math.Max(layoutSlot.Top + margin.Top, (layoutSlot.Top + margin.Top + layoutSlot.Bottom - margin.Bottom) / 2.0 - num2 / 2.0);
				break;
			}
			return new global::System.Windows.Rect(x, y, num, num2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000506C File Offset: 0x0000326C
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, double> GetOldOpacities(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement templateRoot, global::System.Windows.Media.Animation.Storyboard layoutStoryboard, global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord> originalValueRecords, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> movingElements)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, double> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, double>();
			if (movingElements != null)
			{
				foreach (global::System.Windows.FrameworkElement frameworkElement in movingElements)
				{
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = frameworkElement.Parent as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
					if (wrapperCanvas != null)
					{
						dictionary.Add(frameworkElement, wrapperCanvas.Opacity);
					}
				}
			}
			for (int i = originalValueRecords.Count - 1; i >= 0; i--)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord originalLayoutValueRecord = originalValueRecords[i];
				double value;
				if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsVisibilityProperty(originalLayoutValueRecord.Property) && !dictionary.TryGetValue(originalLayoutValueRecord.Element, out value))
				{
					value = (((global::System.Windows.Visibility)originalLayoutValueRecord.Element.GetValue(originalLayoutValueRecord.Property) == global::System.Windows.Visibility.Visible) ? 1.0 : 0.0);
					dictionary.Add(originalLayoutValueRecord.Element, value);
				}
			}
			foreach (global::System.Windows.Media.Animation.Timeline timeline in layoutStoryboard.Children)
			{
				global::System.Windows.FrameworkElement frameworkElement2 = (global::System.Windows.FrameworkElement)global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTimelineTarget(control, templateRoot, timeline);
				global::System.Windows.DependencyProperty dependencyProperty = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutPropertyFromTimeline(timeline, true);
				double value2;
				if (frameworkElement2 != null && global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsVisibilityProperty(dependencyProperty) && !dictionary.TryGetValue(frameworkElement2, out value2))
				{
					value2 = (((global::System.Windows.Visibility)frameworkElement2.GetValue(dependencyProperty) == global::System.Windows.Visibility.Visible) ? 1.0 : 0.0);
					dictionary.Add(frameworkElement2, value2);
				}
			}
			return dictionary;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000051F8 File Offset: 0x000033F8
		private static void SetLayoutStoryboardProperties(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement templateRoot, global::System.Windows.Media.Animation.Storyboard layoutStoryboard, global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord> originalValueRecords)
		{
			foreach (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord originalLayoutValueRecord in originalValueRecords)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ReplaceCachedLocalValueHelper(originalLayoutValueRecord.Element, originalLayoutValueRecord.Property, originalLayoutValueRecord.Value);
			}
			originalValueRecords.Clear();
			foreach (global::System.Windows.Media.Animation.Timeline timeline in layoutStoryboard.Children)
			{
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetTimelineTarget(control, templateRoot, timeline);
				global::System.Windows.DependencyProperty dependencyProperty = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutPropertyFromTimeline(timeline, true);
				if (frameworkElement != null && dependencyProperty != null)
				{
					bool flag;
					object valueFromTimeline = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetValueFromTimeline(timeline, out flag);
					if (flag)
					{
						originalValueRecords.Add(new global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord
						{
							Element = frameworkElement,
							Property = dependencyProperty,
							Value = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CacheLocalValueHelper(frameworkElement, dependencyProperty)
						});
						frameworkElement.SetValue(dependencyProperty, valueFromTimeline);
					}
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000052FC File Offset: 0x000034FC
		private static object GetValueFromTimeline(global::System.Windows.Media.Animation.Timeline timeline, out bool gotValue)
		{
			global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames;
			if (objectAnimationUsingKeyFrames != null)
			{
				gotValue = true;
				return objectAnimationUsingKeyFrames.KeyFrames[0].Value;
			}
			global::System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames;
			if (doubleAnimationUsingKeyFrames != null)
			{
				gotValue = true;
				return doubleAnimationUsingKeyFrames.KeyFrames[0].Value;
			}
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = timeline as global::System.Windows.Media.Animation.DoubleAnimation;
			if (doubleAnimation != null)
			{
				gotValue = true;
				return doubleAnimation.To;
			}
			global::System.Windows.Media.Animation.ThicknessAnimationUsingKeyFrames thicknessAnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.ThicknessAnimationUsingKeyFrames;
			if (thicknessAnimationUsingKeyFrames != null)
			{
				gotValue = true;
				return thicknessAnimationUsingKeyFrames.KeyFrames[0].Value;
			}
			global::System.Windows.Media.Animation.ThicknessAnimation thicknessAnimation = timeline as global::System.Windows.Media.Animation.ThicknessAnimation;
			if (thicknessAnimation != null)
			{
				gotValue = true;
				return thicknessAnimation.To;
			}
			global::System.Windows.Media.Animation.Int32AnimationUsingKeyFrames int32AnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.Int32AnimationUsingKeyFrames;
			if (int32AnimationUsingKeyFrames != null)
			{
				gotValue = true;
				return int32AnimationUsingKeyFrames.KeyFrames[0].Value;
			}
			global::System.Windows.Media.Animation.Int32Animation int32Animation = timeline as global::System.Windows.Media.Animation.Int32Animation;
			if (int32Animation != null)
			{
				gotValue = true;
				return int32Animation.To;
			}
			gotValue = false;
			return null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000053EC File Offset: 0x000035EC
		private static void WrapMovingElementsInCanvases(global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> movingElements, global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect> oldRects, global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::System.Windows.Rect> newRects)
		{
			foreach (global::System.Windows.FrameworkElement frameworkElement in movingElements)
			{
				global::System.Windows.FrameworkElement frameworkElement2 = global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement) as global::System.Windows.FrameworkElement;
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = new global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas();
				wrapperCanvas.OldRect = oldRects[frameworkElement];
				wrapperCanvas.NewRect = newRects[frameworkElement];
				object value = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CacheLocalValueHelper(frameworkElement, global::System.Windows.FrameworkElement.DataContextProperty);
				frameworkElement.DataContext = frameworkElement.DataContext;
				bool flag = true;
				global::System.Windows.Controls.Panel panel = frameworkElement2 as global::System.Windows.Controls.Panel;
				if (panel != null && !panel.IsItemsHost)
				{
					int index = panel.Children.IndexOf(frameworkElement);
					panel.Children.RemoveAt(index);
					panel.Children.Insert(index, wrapperCanvas);
				}
				else
				{
					global::System.Windows.Controls.Decorator decorator = frameworkElement2 as global::System.Windows.Controls.Decorator;
					if (decorator != null)
					{
						decorator.Child = wrapperCanvas;
					}
					else
					{
						flag = false;
					}
				}
				if (flag)
				{
					wrapperCanvas.Children.Add(frameworkElement);
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CopyLayoutProperties(frameworkElement, wrapperCanvas, false);
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ReplaceCachedLocalValueHelper(frameworkElement, global::System.Windows.FrameworkElement.DataContextProperty, value);
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005504 File Offset: 0x00003704
		private static void UnwrapMovingElementsFromCanvases(global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> movingElements)
		{
			foreach (global::System.Windows.FrameworkElement frameworkElement in movingElements)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = frameworkElement.Parent as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
				if (wrapperCanvas != null)
				{
					object value = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CacheLocalValueHelper(frameworkElement, global::System.Windows.FrameworkElement.DataContextProperty);
					frameworkElement.DataContext = frameworkElement.DataContext;
					global::System.Windows.FrameworkElement frameworkElement2 = global::System.Windows.Media.VisualTreeHelper.GetParent(wrapperCanvas) as global::System.Windows.FrameworkElement;
					wrapperCanvas.Children.Remove(frameworkElement);
					global::System.Windows.Controls.Panel panel = frameworkElement2 as global::System.Windows.Controls.Panel;
					if (panel != null)
					{
						int index = panel.Children.IndexOf(wrapperCanvas);
						panel.Children.RemoveAt(index);
						panel.Children.Insert(index, frameworkElement);
					}
					else
					{
						global::System.Windows.Controls.Decorator decorator = frameworkElement2 as global::System.Windows.Controls.Decorator;
						if (decorator != null)
						{
							decorator.Child = frameworkElement;
						}
					}
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CopyLayoutProperties(wrapperCanvas, frameworkElement, true);
					global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ReplaceCachedLocalValueHelper(frameworkElement, global::System.Windows.FrameworkElement.DataContextProperty, value);
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000055F8 File Offset: 0x000037F8
		private static void CopyLayoutProperties(global::System.Windows.FrameworkElement source, global::System.Windows.FrameworkElement target, bool restoring)
		{
			global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = (restoring ? source : target) as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
			if (wrapperCanvas.LocalValueCache == null)
			{
				wrapperCanvas.LocalValueCache = new global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, object>();
			}
			foreach (global::System.Windows.DependencyProperty dependencyProperty in global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.LayoutProperties)
			{
				if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ChildAffectingLayoutProperties.Contains(dependencyProperty))
				{
					if (restoring)
					{
						global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ReplaceCachedLocalValueHelper(target, dependencyProperty, wrapperCanvas.LocalValueCache[dependencyProperty]);
					}
					else
					{
						object value = target.GetValue(dependencyProperty);
						object value2 = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CacheLocalValueHelper(source, dependencyProperty);
						wrapperCanvas.LocalValueCache[dependencyProperty] = value2;
						if (global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsVisibilityProperty(dependencyProperty))
						{
							wrapperCanvas.DestinationVisibilityCache = (global::System.Windows.Visibility)source.GetValue(dependencyProperty);
						}
						else
						{
							target.SetValue(dependencyProperty, source.GetValue(dependencyProperty));
						}
						source.SetValue(dependencyProperty, value);
					}
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000056DC File Offset: 0x000038DC
		private static global::System.Windows.Media.Animation.Storyboard CreateLayoutTransitionStoryboard(global::System.Windows.VisualTransition transition, global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> movingElements, global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, double> oldOpacities)
		{
			global::System.Windows.Duration duration = (transition != null) ? transition.GeneratedDuration : new global::System.Windows.Duration(global::System.TimeSpan.Zero);
			global::System.Windows.Media.Animation.IEasingFunction easingFunction = (transition != null) ? transition.GeneratedEasingFunction : null;
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.Duration = duration;
			foreach (global::System.Windows.FrameworkElement frameworkElement in movingElements)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = frameworkElement.Parent as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
				if (wrapperCanvas != null)
				{
					global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation
					{
						From = new double?(1.0),
						To = new double?(0.0),
						Duration = duration
					};
					doubleAnimation.EasingFunction = easingFunction;
					global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation, wrapperCanvas);
					global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas.SimulationProgressProperty));
					storyboard.Children.Add(doubleAnimation);
					wrapperCanvas.SimulationProgress = 1.0;
					global::System.Windows.Rect newRect = wrapperCanvas.NewRect;
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(wrapperCanvas.Width, newRect.Width))
					{
						global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation2 = new global::System.Windows.Media.Animation.DoubleAnimation
						{
							From = new double?(newRect.Width),
							To = new double?(newRect.Width),
							Duration = duration
						};
						global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation2, wrapperCanvas);
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation2, new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.WidthProperty));
						storyboard.Children.Add(doubleAnimation2);
					}
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(wrapperCanvas.Height, newRect.Height))
					{
						global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation3 = new global::System.Windows.Media.Animation.DoubleAnimation
						{
							From = new double?(newRect.Height),
							To = new double?(newRect.Height),
							Duration = duration
						};
						global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation3, wrapperCanvas);
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation3, new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.HeightProperty));
						storyboard.Children.Add(doubleAnimation3);
					}
					if (wrapperCanvas.DestinationVisibilityCache == global::System.Windows.Visibility.Collapsed)
					{
						global::System.Windows.Thickness margin = wrapperCanvas.Margin;
						if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(margin.Left, 0.0) || !global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(margin.Top, 0.0) || !global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(margin.Right, 0.0) || !global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(margin.Bottom, 0.0))
						{
							global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames objectAnimationUsingKeyFrames = new global::System.Windows.Media.Animation.ObjectAnimationUsingKeyFrames
							{
								Duration = duration
							};
							global::System.Windows.Media.Animation.DiscreteObjectKeyFrame keyFrame = new global::System.Windows.Media.Animation.DiscreteObjectKeyFrame
							{
								KeyTime = global::System.TimeSpan.Zero,
								Value = default(global::System.Windows.Thickness)
							};
							objectAnimationUsingKeyFrames.KeyFrames.Add(keyFrame);
							global::System.Windows.Media.Animation.Storyboard.SetTarget(objectAnimationUsingKeyFrames, wrapperCanvas);
							global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(objectAnimationUsingKeyFrames, new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.MarginProperty));
							storyboard.Children.Add(objectAnimationUsingKeyFrames);
						}
						if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(wrapperCanvas.MinWidth, 0.0))
						{
							global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation4 = new global::System.Windows.Media.Animation.DoubleAnimation
							{
								From = new double?(0.0),
								To = new double?(0.0),
								Duration = duration
							};
							global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation4, wrapperCanvas);
							global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation4, new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.MinWidthProperty));
							storyboard.Children.Add(doubleAnimation4);
						}
						if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(wrapperCanvas.MinHeight, 0.0))
						{
							global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation5 = new global::System.Windows.Media.Animation.DoubleAnimation
							{
								From = new double?(0.0),
								To = new double?(0.0),
								Duration = duration
							};
							global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation5, wrapperCanvas);
							global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation5, new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.MinHeightProperty));
							storyboard.Children.Add(doubleAnimation5);
						}
					}
				}
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement2 in oldOpacities.Keys)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas2 = frameworkElement2.Parent as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
				if (wrapperCanvas2 != null)
				{
					double num = oldOpacities[frameworkElement2];
					double num2 = (wrapperCanvas2.DestinationVisibilityCache == global::System.Windows.Visibility.Visible) ? 1.0 : 0.0;
					if (!global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(num, 1.0) || !global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.IsClose(num2, 1.0))
					{
						global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation6 = new global::System.Windows.Media.Animation.DoubleAnimation
						{
							From = new double?(num),
							To = new double?(num2),
							Duration = duration
						};
						doubleAnimation6.EasingFunction = easingFunction;
						global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation6, wrapperCanvas2);
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation6, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
						storyboard.Children.Add(doubleAnimation6);
					}
				}
			}
			return storyboard;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005BDC File Offset: 0x00003DDC
		private static void TransferLocalValue(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty sourceProperty, global::System.Windows.DependencyProperty destProperty)
		{
			object value = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.CacheLocalValueHelper(element, sourceProperty);
			global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.ReplaceCachedLocalValueHelper(element, destProperty, value);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005BF9 File Offset: 0x00003DF9
		private static object CacheLocalValueHelper(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyProperty property)
		{
			return dependencyObject.ReadLocalValue(property);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005C04 File Offset: 0x00003E04
		private static void ReplaceCachedLocalValueHelper(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty property, object value)
		{
			if (value == global::System.Windows.DependencyProperty.UnsetValue)
			{
				element.ClearValue(property);
				return;
			}
			global::System.Windows.Data.BindingExpressionBase bindingExpressionBase = value as global::System.Windows.Data.BindingExpressionBase;
			if (bindingExpressionBase != null)
			{
				element.SetBinding(property, bindingExpressionBase.ParentBindingBase);
				return;
			}
			element.SetValue(property, value);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005C42 File Offset: 0x00003E42
		private static bool IsClose(double a, double b)
		{
			return global::System.Math.Abs(a - b) < 1E-07;
		}

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty UseFluidLayoutProperty = global::System.Windows.DependencyProperty.RegisterAttached("UseFluidLayout", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x04000027 RID: 39
		public static readonly global::System.Windows.DependencyProperty RuntimeVisibilityPropertyProperty = global::System.Windows.DependencyProperty.RegisterAttached("RuntimeVisibilityProperty", typeof(global::System.Windows.DependencyProperty), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000028 RID: 40
		internal static readonly global::System.Windows.DependencyProperty OriginalLayoutValuesProperty = global::System.Windows.DependencyProperty.RegisterAttached("OriginalLayoutValues", typeof(global::System.Collections.Generic.List<global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.OriginalLayoutValueRecord>), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000029 RID: 41
		internal static readonly global::System.Windows.DependencyProperty LayoutStoryboardProperty = global::System.Windows.DependencyProperty.RegisterAttached("LayoutStoryboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400002A RID: 42
		internal static readonly global::System.Windows.DependencyProperty CurrentStateProperty = global::System.Windows.DependencyProperty.RegisterAttached("CurrentState", typeof(global::System.Windows.VisualState), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400002B RID: 43
		public static readonly global::System.Windows.DependencyProperty TransitionEffectProperty = global::System.Windows.DependencyProperty.RegisterAttached("TransitionEffect", typeof(global::Microsoft.Expression.Media.Effects.TransitionEffect), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400002C RID: 44
		internal static readonly global::System.Windows.DependencyProperty TransitionEffectStoryboardProperty = global::System.Windows.DependencyProperty.RegisterAttached("TransitionEffectStoryboard", typeof(global::System.Windows.Media.Animation.Storyboard), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400002D RID: 45
		internal static readonly global::System.Windows.DependencyProperty DidCacheBackgroundProperty = global::System.Windows.DependencyProperty.RegisterAttached("DidCacheBackground", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x0400002E RID: 46
		internal static readonly global::System.Windows.DependencyProperty CachedBackgroundProperty = global::System.Windows.DependencyProperty.RegisterAttached("CachedBackground", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400002F RID: 47
		internal static readonly global::System.Windows.DependencyProperty CachedEffectProperty = global::System.Windows.DependencyProperty.RegisterAttached("CachedEffect", typeof(global::System.Windows.Media.Effects.Effect), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000030 RID: 48
		private static global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> MovingElements;

		// Token: 0x04000031 RID: 49
		private static global::System.Windows.Media.Animation.Storyboard LayoutTransitionStoryboard;

		// Token: 0x04000032 RID: 50
		private static global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> LayoutProperties = new global::System.Collections.Generic.List<global::System.Windows.DependencyProperty>
		{
			global::System.Windows.Controls.Grid.ColumnProperty,
			global::System.Windows.Controls.Grid.ColumnSpanProperty,
			global::System.Windows.Controls.Grid.RowProperty,
			global::System.Windows.Controls.Grid.RowSpanProperty,
			global::System.Windows.Controls.Canvas.LeftProperty,
			global::System.Windows.Controls.Canvas.TopProperty,
			global::System.Windows.FrameworkElement.WidthProperty,
			global::System.Windows.FrameworkElement.HeightProperty,
			global::System.Windows.FrameworkElement.MinWidthProperty,
			global::System.Windows.FrameworkElement.MinHeightProperty,
			global::System.Windows.FrameworkElement.MaxWidthProperty,
			global::System.Windows.FrameworkElement.MaxHeightProperty,
			global::System.Windows.FrameworkElement.MarginProperty,
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty,
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty,
			global::System.Windows.UIElement.VisibilityProperty,
			global::System.Windows.Controls.StackPanel.OrientationProperty
		};

		// Token: 0x04000033 RID: 51
		private static global::System.Collections.Generic.List<global::System.Windows.DependencyProperty> ChildAffectingLayoutProperties = new global::System.Collections.Generic.List<global::System.Windows.DependencyProperty>
		{
			global::System.Windows.Controls.StackPanel.OrientationProperty
		};

		// Token: 0x04000034 RID: 52
		private bool changingState;

		// Token: 0x02000014 RID: 20
		internal class WrapperCanvas : global::System.Windows.Controls.Canvas
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005EEF File Offset: 0x000040EF
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x00005EF7 File Offset: 0x000040F7
			public global::System.Windows.Rect OldRect { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00005F00 File Offset: 0x00004100
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00005F08 File Offset: 0x00004108
			public global::System.Windows.Rect NewRect { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00005F11 File Offset: 0x00004111
			// (set) Token: 0x060000BB RID: 187 RVA: 0x00005F19 File Offset: 0x00004119
			public global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, object> LocalValueCache { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00005F22 File Offset: 0x00004122
			// (set) Token: 0x060000BD RID: 189 RVA: 0x00005F2A File Offset: 0x0000412A
			public global::System.Windows.Visibility DestinationVisibilityCache { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00005F33 File Offset: 0x00004133
			// (set) Token: 0x060000BF RID: 191 RVA: 0x00005F45 File Offset: 0x00004145
			public double SimulationProgress
			{
				get
				{
					return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas.SimulationProgressProperty);
				}
				set
				{
					base.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas.SimulationProgressProperty, value);
				}
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00005F58 File Offset: 0x00004158
			private static void SimulationProgressChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas wrapperCanvas = d as global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas;
				double num = (double)e.NewValue;
				if (wrapperCanvas != null && wrapperCanvas.Children.Count > 0)
				{
					global::System.Windows.FrameworkElement frameworkElement = wrapperCanvas.Children[0] as global::System.Windows.FrameworkElement;
					frameworkElement.Width = global::System.Math.Max(0.0, wrapperCanvas.OldRect.Width * num + wrapperCanvas.NewRect.Width * (1.0 - num));
					frameworkElement.Height = global::System.Math.Max(0.0, wrapperCanvas.OldRect.Height * num + wrapperCanvas.NewRect.Height * (1.0 - num));
					global::System.Windows.Controls.Canvas.SetLeft(frameworkElement, num * (wrapperCanvas.OldRect.Left - wrapperCanvas.NewRect.Left));
					global::System.Windows.Controls.Canvas.SetTop(frameworkElement, num * (wrapperCanvas.OldRect.Top - wrapperCanvas.NewRect.Top));
				}
			}

			// Token: 0x04000035 RID: 53
			internal static readonly global::System.Windows.DependencyProperty SimulationProgressProperty = global::System.Windows.DependencyProperty.Register("SimulationProgress", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.WrapperCanvas.SimulationProgressChanged)));
		}

		// Token: 0x02000015 RID: 21
		internal class OriginalLayoutValueRecord
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x000060CB File Offset: 0x000042CB
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x000060D3 File Offset: 0x000042D3
			public global::System.Windows.FrameworkElement Element { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x000060DC File Offset: 0x000042DC
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x000060E4 File Offset: 0x000042E4
			public global::System.Windows.DependencyProperty Property { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x000060ED File Offset: 0x000042ED
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x000060F5 File Offset: 0x000042F5
			public object Value { get; set; }
		}

		// Token: 0x02000016 RID: 22
		private class DummyEasingFunction : global::System.Windows.Media.Animation.EasingFunctionBase
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000CA RID: 202 RVA: 0x00006106 File Offset: 0x00004306
			// (set) Token: 0x060000CB RID: 203 RVA: 0x00006118 File Offset: 0x00004318
			public double DummyValue
			{
				get
				{
					return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DummyEasingFunction.DummyValueProperty);
				}
				set
				{
					base.SetValue(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DummyEasingFunction.DummyValueProperty, value);
				}
			}

			// Token: 0x060000CC RID: 204 RVA: 0x0000612B File Offset: 0x0000432B
			protected override global::System.Windows.Freezable CreateInstanceCore()
			{
				return new global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DummyEasingFunction();
			}

			// Token: 0x060000CE RID: 206 RVA: 0x0000613A File Offset: 0x0000433A
			protected override double EaseInCore(double normalizedTime)
			{
				return this.DummyValue;
			}

			// Token: 0x0400003D RID: 61
			public static readonly global::System.Windows.DependencyProperty DummyValueProperty = global::System.Windows.DependencyProperty.Register("DummyValue", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.DummyEasingFunction), new global::System.Windows.PropertyMetadata(0.0));
		}
	}
}
