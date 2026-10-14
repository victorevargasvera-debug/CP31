using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Microsoft.Windows.Controls;

namespace System.Windows
{
	// Token: 0x0200001F RID: 31
	public class VisualStateManager : global::System.Windows.DependencyObject
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public static bool GoToState(global::System.Windows.Controls.Control control, string stateName, bool useTransitions)
		{
			if (control == null)
			{
				throw new global::System.ArgumentNullException("control");
			}
			if (stateName == null)
			{
				throw new global::System.ArgumentNullException("stateName");
			}
			global::System.Windows.FrameworkElement templateRoot = global::System.Windows.VisualStateManager.GetTemplateRoot(control);
			if (templateRoot == null)
			{
				return false;
			}
			global::System.Collections.Generic.IList<global::System.Windows.VisualStateGroup> visualStateGroupsInternal = global::System.Windows.VisualStateManager.GetVisualStateGroupsInternal(templateRoot);
			if (visualStateGroupsInternal == null)
			{
				return false;
			}
			global::System.Windows.VisualStateGroup group;
			global::System.Windows.VisualState visualState;
			global::System.Windows.VisualStateManager.TryGetState(visualStateGroupsInternal, stateName, out group, out visualState);
			global::System.Windows.VisualStateManager customVisualStateManager = global::System.Windows.VisualStateManager.GetCustomVisualStateManager(templateRoot);
			if (customVisualStateManager != null)
			{
				return customVisualStateManager.GoToStateCore(control, templateRoot, stateName, group, visualState, useTransitions);
			}
			return visualState != null && global::System.Windows.VisualStateManager.GoToStateInternal(control, templateRoot, group, visualState, useTransitions);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00007E5E File Offset: 0x0000605E
		protected virtual bool GoToStateCore(global::System.Windows.Controls.Control control, global::System.Windows.FrameworkElement templateRoot, string stateName, global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState state, bool useTransitions)
		{
			return global::System.Windows.VisualStateManager.GoToStateInternal(control, templateRoot, group, state, useTransitions);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007E6D File Offset: 0x0000606D
		public static global::System.Windows.VisualStateManager GetCustomVisualStateManager(global::System.Windows.FrameworkElement obj)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			return obj.GetValue(global::System.Windows.VisualStateManager.CustomVisualStateManagerProperty) as global::System.Windows.VisualStateManager;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007E8D File Offset: 0x0000608D
		public static void SetCustomVisualStateManager(global::System.Windows.FrameworkElement obj, global::System.Windows.VisualStateManager value)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			obj.SetValue(global::System.Windows.VisualStateManager.CustomVisualStateManagerProperty, value);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007EAC File Offset: 0x000060AC
		internal static global::System.Collections.ObjectModel.Collection<global::System.Windows.VisualStateGroup> GetVisualStateGroupsInternal(global::System.Windows.FrameworkElement obj)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			global::System.Collections.ObjectModel.Collection<global::System.Windows.VisualStateGroup> collection = obj.GetValue(global::System.Windows.VisualStateManager.VisualStateGroupsProperty) as global::System.Collections.ObjectModel.Collection<global::System.Windows.VisualStateGroup>;
			if (collection == null)
			{
				collection = new global::System.Collections.ObjectModel.Collection<global::System.Windows.VisualStateGroup>();
				global::System.Windows.VisualStateManager.SetVisualStateGroups(obj, collection);
			}
			return collection;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007EE9 File Offset: 0x000060E9
		public static global::System.Collections.IList GetVisualStateGroups(global::System.Windows.FrameworkElement obj)
		{
			return global::System.Windows.VisualStateManager.GetVisualStateGroupsInternal(obj);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007EF1 File Offset: 0x000060F1
		internal static void SetVisualStateGroups(global::System.Windows.FrameworkElement obj, global::System.Collections.ObjectModel.Collection<global::System.Windows.VisualStateGroup> value)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			obj.SetValue(global::System.Windows.VisualStateManager.VisualStateGroupsProperty, value);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00007F10 File Offset: 0x00006110
		private static void OnVisualStateGroupsChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = obj as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				global::System.Windows.Controls.Control templatedParent = global::System.Windows.VisualStateManager.GetTemplatedParent(frameworkElement);
				if (templatedParent != null)
				{
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.AttachBehavior(templatedParent);
				}
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007F38 File Offset: 0x00006138
		internal static bool TryGetState(global::System.Collections.Generic.IList<global::System.Windows.VisualStateGroup> groups, string stateName, out global::System.Windows.VisualStateGroup group, out global::System.Windows.VisualState state)
		{
			for (int i = 0; i < groups.Count; i++)
			{
				global::System.Windows.VisualStateGroup visualStateGroup = groups[i];
				global::System.Windows.VisualState state2 = visualStateGroup.GetState(stateName);
				if (state2 != null)
				{
					group = visualStateGroup;
					state = state2;
					return true;
				}
			}
			group = null;
			state = null;
			return false;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00008118 File Offset: 0x00006318
		private static bool GoToStateInternal(global::System.Windows.Controls.Control control, global::System.Windows.FrameworkElement element, global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState state, bool useTransitions)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			if (state == null)
			{
				throw new global::System.ArgumentNullException("state");
			}
			if (group == null)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.Windows.VisualState lastState = group.CurrentState;
			if (lastState == state)
			{
				return true;
			}
			global::System.Windows.VisualTransition transition = useTransitions ? global::System.Windows.VisualStateManager.GetTransition(element, group, lastState, state) : null;
			global::System.Windows.Media.Animation.Storyboard storyboard = global::System.Windows.VisualStateManager.GenerateDynamicTransitionAnimations(element, group, state, transition);
			if (transition == null || (transition.GeneratedDuration == global::System.Windows.VisualStateManager.DurationZero && (transition.Storyboard == null || transition.Storyboard.Duration == global::System.Windows.VisualStateManager.DurationZero)))
			{
				if (transition != null && transition.Storyboard != null)
				{
					group.StartNewThenStopOld(element, new global::System.Windows.Media.Animation.Storyboard[]
					{
						transition.Storyboard,
						state.Storyboard
					});
				}
				else
				{
					group.StartNewThenStopOld(element, new global::System.Windows.Media.Animation.Storyboard[]
					{
						state.Storyboard
					});
				}
				group.RaiseCurrentStateChanging(element, lastState, state, control);
				group.RaiseCurrentStateChanged(element, lastState, state, control);
			}
			else
			{
				transition.DynamicStoryboardCompleted = false;
				storyboard.Completed += delegate(object sender, global::System.EventArgs e)
				{
					if (transition.Storyboard == null || transition.ExplicitStoryboardCompleted)
					{
						if (global::System.Windows.VisualStateManager.ShouldRunStateStoryboard(control, element, state, group))
						{
							group.StartNewThenStopOld(element, new global::System.Windows.Media.Animation.Storyboard[]
							{
								state.Storyboard
							});
						}
						group.RaiseCurrentStateChanged(element, lastState, state, control);
					}
					transition.DynamicStoryboardCompleted = true;
				};
				if (transition.Storyboard != null && transition.ExplicitStoryboardCompleted)
				{
					global::System.EventHandler transitionCompleted = null;
					transitionCompleted = delegate(object sender, global::System.EventArgs e)
					{
						if (transition.DynamicStoryboardCompleted)
						{
							if (global::System.Windows.VisualStateManager.ShouldRunStateStoryboard(control, element, state, group))
							{
								group.StartNewThenStopOld(element, new global::System.Windows.Media.Animation.Storyboard[]
								{
									state.Storyboard
								});
							}
							group.RaiseCurrentStateChanged(element, lastState, state, control);
						}
						transition.Storyboard.Completed -= transitionCompleted;
						transition.ExplicitStoryboardCompleted = true;
					};
					transition.ExplicitStoryboardCompleted = false;
					transition.Storyboard.Completed += transitionCompleted;
				}
				group.StartNewThenStopOld(element, new global::System.Windows.Media.Animation.Storyboard[]
				{
					transition.Storyboard,
					storyboard
				});
				group.RaiseCurrentStateChanging(element, lastState, state, control);
			}
			group.CurrentState = state;
			return true;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000083E4 File Offset: 0x000065E4
		private static bool ShouldRunStateStoryboard(global::System.Windows.FrameworkElement control, global::System.Windows.FrameworkElement stateGroupsRoot, global::System.Windows.VisualState state, global::System.Windows.VisualStateGroup group)
		{
			bool flag = true;
			bool flag2 = true;
			if (control != null && !control.IsVisible)
			{
				flag = (global::System.Windows.PresentationSource.FromVisual(control) != null);
			}
			if (stateGroupsRoot != null && !stateGroupsRoot.IsVisible)
			{
				flag2 = (global::System.Windows.PresentationSource.FromVisual(stateGroupsRoot) != null);
			}
			return flag && flag2 && state == group.CurrentState;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00008438 File Offset: 0x00006638
		protected void RaiseCurrentStateChanging(global::System.Windows.VisualStateGroup stateGroup, global::System.Windows.VisualState oldState, global::System.Windows.VisualState newState, global::System.Windows.Controls.Control control)
		{
			if (stateGroup == null)
			{
				throw new global::System.ArgumentNullException("stateGroup");
			}
			if (newState == null)
			{
				throw new global::System.ArgumentNullException("newState");
			}
			if (control == null)
			{
				throw new global::System.ArgumentNullException("control");
			}
			global::System.Windows.FrameworkElement templateRoot = global::System.Windows.VisualStateManager.GetTemplateRoot(control);
			if (templateRoot == null)
			{
				return;
			}
			stateGroup.RaiseCurrentStateChanging(templateRoot, oldState, newState, control);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00008488 File Offset: 0x00006688
		protected void RaiseCurrentStateChanged(global::System.Windows.VisualStateGroup stateGroup, global::System.Windows.VisualState oldState, global::System.Windows.VisualState newState, global::System.Windows.Controls.Control control)
		{
			if (stateGroup == null)
			{
				throw new global::System.ArgumentNullException("stateGroup");
			}
			if (newState == null)
			{
				throw new global::System.ArgumentNullException("newState");
			}
			if (control == null)
			{
				throw new global::System.ArgumentNullException("control");
			}
			global::System.Windows.FrameworkElement templateRoot = global::System.Windows.VisualStateManager.GetTemplateRoot(control);
			if (templateRoot == null)
			{
				return;
			}
			stateGroup.RaiseCurrentStateChanged(templateRoot, oldState, newState, control);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000084D8 File Offset: 0x000066D8
		private static global::System.Windows.Media.Animation.Storyboard GenerateDynamicTransitionAnimations(global::System.Windows.FrameworkElement root, global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState newState, global::System.Windows.VisualTransition transition)
		{
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			if (transition != null)
			{
				global::System.Windows.Duration generatedDuration = transition.GeneratedDuration;
				storyboard.Duration = transition.GeneratedDuration;
			}
			else
			{
				storyboard.Duration = new global::System.Windows.Duration(global::System.TimeSpan.Zero);
			}
			global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> dictionary = global::System.Windows.VisualStateManager.FlattenTimelines(group.CurrentStoryboards);
			global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> dictionary2 = global::System.Windows.VisualStateManager.FlattenTimelines((transition != null) ? transition.Storyboard : null);
			global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> dictionary3 = global::System.Windows.VisualStateManager.FlattenTimelines(newState.Storyboard);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> keyValuePair in dictionary2)
			{
				dictionary.Remove(keyValuePair.Key);
				dictionary3.Remove(keyValuePair.Key);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> keyValuePair2 in dictionary3)
			{
				global::System.Windows.Media.Animation.Timeline timeline = global::System.Windows.VisualStateManager.GenerateToAnimation(root, keyValuePair2.Value, true);
				if (timeline != null)
				{
					timeline.Duration = storyboard.Duration;
					storyboard.Children.Add(timeline);
				}
				dictionary.Remove(keyValuePair2.Key);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> keyValuePair3 in dictionary)
			{
				global::System.Windows.Media.Animation.Timeline timeline2 = global::System.Windows.VisualStateManager.GenerateFromAnimation(root, keyValuePair3.Value);
				if (timeline2 != null)
				{
					timeline2.Duration = storyboard.Duration;
					storyboard.Children.Add(timeline2);
				}
			}
			return storyboard;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00008670 File Offset: 0x00006870
		private static global::System.Windows.Media.Animation.Timeline GenerateFromAnimation(global::System.Windows.FrameworkElement root, global::System.Windows.Media.Animation.Timeline timeline)
		{
			global::System.Windows.Media.Animation.Timeline timeline2 = null;
			if (timeline is global::System.Windows.Media.Animation.ColorAnimation || timeline is global::System.Windows.Media.Animation.ColorAnimationUsingKeyFrames)
			{
				timeline2 = new global::System.Windows.Media.Animation.ColorAnimation();
			}
			else if (timeline is global::System.Windows.Media.Animation.DoubleAnimation || timeline is global::System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames)
			{
				timeline2 = new global::System.Windows.Media.Animation.DoubleAnimation();
			}
			else if (timeline is global::System.Windows.Media.Animation.PointAnimation || timeline is global::System.Windows.Media.Animation.PointAnimationUsingKeyFrames)
			{
				timeline2 = new global::System.Windows.Media.Animation.PointAnimation();
			}
			if (timeline2 != null)
			{
				global::System.Windows.VisualStateManager.CopyStoryboardTargetProperties(root, timeline, timeline2);
			}
			return timeline2;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000086D4 File Offset: 0x000068D4
		private static global::System.Windows.Media.Animation.Timeline GenerateToAnimation(global::System.Windows.FrameworkElement root, global::System.Windows.Media.Animation.Timeline timeline, bool isEntering)
		{
			global::System.Windows.Media.Animation.Timeline timeline2 = null;
			global::System.Windows.Media.Color? targetColor = global::System.Windows.VisualStateManager.GetTargetColor(timeline, isEntering);
			if (targetColor != null)
			{
				global::System.Windows.Media.Animation.ColorAnimation colorAnimation = new global::System.Windows.Media.Animation.ColorAnimation
				{
					To = targetColor
				};
				timeline2 = colorAnimation;
			}
			if (timeline2 == null)
			{
				double? targetDouble = global::System.Windows.VisualStateManager.GetTargetDouble(timeline, isEntering);
				if (targetDouble != null)
				{
					global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation
					{
						To = targetDouble
					};
					timeline2 = doubleAnimation;
				}
			}
			if (timeline2 == null)
			{
				global::System.Windows.Point? targetPoint = global::System.Windows.VisualStateManager.GetTargetPoint(timeline, isEntering);
				if (targetPoint != null)
				{
					global::System.Windows.Media.Animation.PointAnimation pointAnimation = new global::System.Windows.Media.Animation.PointAnimation
					{
						To = targetPoint
					};
					timeline2 = pointAnimation;
				}
			}
			if (timeline2 != null)
			{
				global::System.Windows.VisualStateManager.CopyStoryboardTargetProperties(root, timeline, timeline2);
			}
			return timeline2;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000876C File Offset: 0x0000696C
		private static void CopyStoryboardTargetProperties(global::System.Windows.FrameworkElement root, global::System.Windows.Media.Animation.Timeline source, global::System.Windows.Media.Animation.Timeline destination)
		{
			if (source != null || destination != null)
			{
				string targetName = global::System.Windows.Media.Animation.Storyboard.GetTargetName(source);
				global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Media.Animation.Storyboard.GetTarget(source);
				global::System.Windows.PropertyPath targetProperty = global::System.Windows.Media.Animation.Storyboard.GetTargetProperty(source);
				if (dependencyObject == null && !string.IsNullOrEmpty(targetName))
				{
					dependencyObject = (root.FindName(targetName) as global::System.Windows.DependencyObject);
				}
				if (targetName != null)
				{
					global::System.Windows.Media.Animation.Storyboard.SetTargetName(destination, targetName);
				}
				if (dependencyObject != null)
				{
					global::System.Windows.Media.Animation.Storyboard.SetTarget(destination, dependencyObject);
				}
				if (targetProperty != null)
				{
					global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(destination, targetProperty);
				}
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000087CC File Offset: 0x000069CC
		internal static global::System.Windows.VisualTransition GetTransition(global::System.Windows.FrameworkElement element, global::System.Windows.VisualStateGroup group, global::System.Windows.VisualState from, global::System.Windows.VisualState to)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			if (group == null)
			{
				throw new global::System.ArgumentNullException("group");
			}
			if (to == null)
			{
				throw new global::System.ArgumentNullException("to");
			}
			global::System.Windows.VisualTransition visualTransition = null;
			global::System.Windows.VisualTransition visualTransition2 = null;
			int num = -1;
			global::System.Collections.Generic.IList<global::System.Windows.VisualTransition> list = (global::System.Collections.Generic.IList<global::System.Windows.VisualTransition>)group.Transitions;
			if (list != null)
			{
				foreach (global::System.Windows.VisualTransition visualTransition3 in list)
				{
					if (visualTransition2 == null && visualTransition3.IsDefault)
					{
						visualTransition2 = visualTransition3;
					}
					else
					{
						int num2 = -1;
						global::System.Windows.VisualState state = group.GetState(visualTransition3.From);
						global::System.Windows.VisualState state2 = group.GetState(visualTransition3.To);
						if (from == state)
						{
							num2++;
						}
						else if (state != null)
						{
							continue;
						}
						if (to == state2)
						{
							num2 += 2;
						}
						else if (state2 != null)
						{
							continue;
						}
						if (num2 > num)
						{
							num = num2;
							visualTransition = visualTransition3;
						}
					}
				}
			}
			return visualTransition ?? visualTransition2;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000088BC File Offset: 0x00006ABC
		private static global::System.Windows.Media.Color? GetTargetColor(global::System.Windows.Media.Animation.Timeline timeline, bool isEntering)
		{
			global::System.Windows.Media.Animation.ColorAnimation colorAnimation = timeline as global::System.Windows.Media.Animation.ColorAnimation;
			if (colorAnimation != null)
			{
				if (colorAnimation.From == null)
				{
					return colorAnimation.To;
				}
				return colorAnimation.From;
			}
			else
			{
				global::System.Windows.Media.Animation.ColorAnimationUsingKeyFrames colorAnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.ColorAnimationUsingKeyFrames;
				if (colorAnimationUsingKeyFrames == null)
				{
					return null;
				}
				if (colorAnimationUsingKeyFrames.KeyFrames.Count == 0)
				{
					return null;
				}
				global::System.Windows.Media.Animation.ColorKeyFrame colorKeyFrame = colorAnimationUsingKeyFrames.KeyFrames[isEntering ? 0 : (colorAnimationUsingKeyFrames.KeyFrames.Count - 1)];
				return new global::System.Windows.Media.Color?(colorKeyFrame.Value);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00008948 File Offset: 0x00006B48
		private static double? GetTargetDouble(global::System.Windows.Media.Animation.Timeline timeline, bool isEntering)
		{
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = timeline as global::System.Windows.Media.Animation.DoubleAnimation;
			if (doubleAnimation != null)
			{
				if (doubleAnimation.From == null)
				{
					return doubleAnimation.To;
				}
				return doubleAnimation.From;
			}
			else
			{
				global::System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames;
				if (doubleAnimationUsingKeyFrames == null)
				{
					return null;
				}
				if (doubleAnimationUsingKeyFrames.KeyFrames.Count == 0)
				{
					return null;
				}
				global::System.Windows.Media.Animation.DoubleKeyFrame doubleKeyFrame = doubleAnimationUsingKeyFrames.KeyFrames[isEntering ? 0 : (doubleAnimationUsingKeyFrames.KeyFrames.Count - 1)];
				return new double?(doubleKeyFrame.Value);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000089D4 File Offset: 0x00006BD4
		private static global::System.Windows.Point? GetTargetPoint(global::System.Windows.Media.Animation.Timeline timeline, bool isEntering)
		{
			global::System.Windows.Media.Animation.PointAnimation pointAnimation = timeline as global::System.Windows.Media.Animation.PointAnimation;
			if (pointAnimation != null)
			{
				if (pointAnimation.From == null)
				{
					return pointAnimation.To;
				}
				return pointAnimation.From;
			}
			else
			{
				global::System.Windows.Media.Animation.PointAnimationUsingKeyFrames pointAnimationUsingKeyFrames = timeline as global::System.Windows.Media.Animation.PointAnimationUsingKeyFrames;
				if (pointAnimationUsingKeyFrames == null)
				{
					return null;
				}
				if (pointAnimationUsingKeyFrames.KeyFrames.Count == 0)
				{
					return null;
				}
				global::System.Windows.Media.Animation.PointKeyFrame pointKeyFrame = pointAnimationUsingKeyFrames.KeyFrames[isEntering ? 0 : (pointAnimationUsingKeyFrames.KeyFrames.Count - 1)];
				return new global::System.Windows.Point?(pointKeyFrame.Value);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00008A60 File Offset: 0x00006C60
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> FlattenTimelines(global::System.Windows.Media.Animation.Storyboard storyboard)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> result = new global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline>();
			global::System.Windows.VisualStateManager.FlattenTimelines(storyboard, result);
			return result;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008A7C File Offset: 0x00006C7C
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> FlattenTimelines(global::System.Collections.ObjectModel.Collection<global::System.Windows.Media.Animation.Storyboard> storyboards)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> result = new global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline>();
			for (int i = 0; i < storyboards.Count; i++)
			{
				global::System.Windows.VisualStateManager.FlattenTimelines(storyboards[i], result);
			}
			return result;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00008AB0 File Offset: 0x00006CB0
		private static void FlattenTimelines(global::System.Windows.Media.Animation.Storyboard storyboard, global::System.Collections.Generic.Dictionary<global::System.Windows.VisualStateManager.TimelineDataToken, global::System.Windows.Media.Animation.Timeline> result)
		{
			if (storyboard == null)
			{
				return;
			}
			for (int i = 0; i < storyboard.Children.Count; i++)
			{
				global::System.Windows.Media.Animation.Timeline timeline = storyboard.Children[i];
				global::System.Windows.Media.Animation.Storyboard storyboard2 = timeline as global::System.Windows.Media.Animation.Storyboard;
				if (storyboard2 != null)
				{
					global::System.Windows.VisualStateManager.FlattenTimelines(storyboard2, result);
				}
				else
				{
					result[new global::System.Windows.VisualStateManager.TimelineDataToken(timeline)] = timeline;
				}
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008B04 File Offset: 0x00006D04
		private static global::System.Windows.FrameworkElement GetTemplateRoot(global::System.Windows.Controls.Control control)
		{
			global::System.Windows.Controls.UserControl userControl = control as global::System.Windows.Controls.UserControl;
			if (userControl != null)
			{
				return userControl.Content as global::System.Windows.FrameworkElement;
			}
			if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(control) > 0)
			{
				return global::System.Windows.Media.VisualTreeHelper.GetChild(control, 0) as global::System.Windows.FrameworkElement;
			}
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008B40 File Offset: 0x00006D40
		private static global::System.Windows.Controls.Control GetTemplatedParent(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.DependencyObject templatedParent = element.TemplatedParent;
			if (templatedParent != null)
			{
				return templatedParent as global::System.Windows.Controls.Control;
			}
			global::System.Windows.Controls.UserControl userControl = element.Parent as global::System.Windows.Controls.UserControl;
			if (userControl != null)
			{
				return userControl;
			}
			return null;
		}

		// Token: 0x0400007B RID: 123
		public static readonly global::System.Windows.DependencyProperty CustomVisualStateManagerProperty = global::System.Windows.DependencyProperty.RegisterAttached("CustomVisualStateManager", typeof(global::System.Windows.VisualStateManager), typeof(global::System.Windows.VisualStateManager), null);

		// Token: 0x0400007C RID: 124
		internal static readonly global::System.Windows.DependencyProperty VisualStateGroupsProperty = global::System.Windows.DependencyProperty.RegisterAttached("InternalVisualStateGroups", typeof(global::System.Collections.ObjectModel.Collection<global::System.Windows.VisualStateGroup>), typeof(global::System.Windows.VisualStateManager), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::System.Windows.VisualStateManager.OnVisualStateGroupsChanged)));

		// Token: 0x0400007D RID: 125
		private static readonly global::System.Windows.Duration DurationZero = new global::System.Windows.Duration(global::System.TimeSpan.Zero);

		// Token: 0x02000020 RID: 32
		private struct TimelineDataToken : global::System.IEquatable<global::System.Windows.VisualStateManager.TimelineDataToken>
		{
			// Token: 0x06000212 RID: 530 RVA: 0x00008BED File Offset: 0x00006DED
			public TimelineDataToken(global::System.Windows.Media.Animation.Timeline timeline)
			{
				this._target = global::System.Windows.Media.Animation.Storyboard.GetTarget(timeline);
				this._targetName = global::System.Windows.Media.Animation.Storyboard.GetTargetName(timeline);
				this._targetProperty = global::System.Windows.Media.Animation.Storyboard.GetTargetProperty(timeline);
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00008C14 File Offset: 0x00006E14
			public bool Equals(global::System.Windows.VisualStateManager.TimelineDataToken other)
			{
				if (other._target == this._target && other._targetName == this._targetName && other._targetProperty.Path == this._targetProperty.Path && other._targetProperty.PathParameters.Count == this._targetProperty.PathParameters.Count)
				{
					bool result = true;
					int i = 0;
					int count = this._targetProperty.PathParameters.Count;
					while (i < count)
					{
						if (other._targetProperty.PathParameters[i] != this._targetProperty.PathParameters[i])
						{
							result = false;
							break;
						}
						i++;
					}
					return result;
				}
				return false;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00008CD8 File Offset: 0x00006ED8
			public override int GetHashCode()
			{
				int num = (this._target != null) ? this._target.GetHashCode() : 0;
				int num2 = (this._targetName != null) ? this._targetName.GetHashCode() : 0;
				int num3 = (this._targetProperty != null) ? this._targetProperty.GetHashCode() : 0;
				return num ^ num2 ^ num3;
			}

			// Token: 0x0400007E RID: 126
			private global::System.Windows.DependencyObject _target;

			// Token: 0x0400007F RID: 127
			private string _targetName;

			// Token: 0x04000080 RID: 128
			private global::System.Windows.PropertyPath _targetProperty;
		}
	}
}
