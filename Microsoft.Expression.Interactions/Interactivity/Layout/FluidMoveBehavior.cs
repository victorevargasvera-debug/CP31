using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Microsoft.Expression.Interactivity.Layout
{
	// Token: 0x0200001C RID: 28
	public sealed class FluidMoveBehavior : global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00006775 File Offset: 0x00004975
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00006787 File Offset: 0x00004987
		public global::System.Windows.Duration Duration
		{
			get
			{
				return (global::System.Windows.Duration)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.DurationProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.DurationProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000679A File Offset: 0x0000499A
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000067AC File Offset: 0x000049AC
		public global::Microsoft.Expression.Interactivity.Layout.TagType InitialTag
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Layout.TagType)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialTagProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialTagProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000067BF File Offset: 0x000049BF
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000067D1 File Offset: 0x000049D1
		public string InitialTagPath
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialTagPathProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialTagPathProperty, value);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000067DF File Offset: 0x000049DF
		private static object GetInitialIdentityTag(global::System.Windows.DependencyObject obj)
		{
			return obj.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialIdentityTagProperty);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000067EC File Offset: 0x000049EC
		private static void SetInitialIdentityTag(global::System.Windows.DependencyObject obj, object value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialIdentityTagProperty, value);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000067FA File Offset: 0x000049FA
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000680C File Offset: 0x00004A0C
		public bool FloatAbove
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.FloatAboveProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.FloatAboveProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000681F File Offset: 0x00004A1F
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00006831 File Offset: 0x00004A31
		public global::System.Windows.Media.Animation.IEasingFunction EaseX
		{
			get
			{
				return (global::System.Windows.Media.Animation.IEasingFunction)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.EaseXProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.EaseXProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000683F File Offset: 0x00004A3F
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00006851 File Offset: 0x00004A51
		public global::System.Windows.Media.Animation.IEasingFunction EaseY
		{
			get
			{
				return (global::System.Windows.Media.Animation.IEasingFunction)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.EaseYProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.EaseYProperty, value);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000685F File Offset: 0x00004A5F
		private static object GetOverlay(global::System.Windows.DependencyObject obj)
		{
			return obj.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.OverlayProperty);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000686C File Offset: 0x00004A6C
		private static void SetOverlay(global::System.Windows.DependencyObject obj, object value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.OverlayProperty, value);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000687A File Offset: 0x00004A7A
		private static object GetCacheDuringOverlay(global::System.Windows.DependencyObject obj)
		{
			return obj.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.CacheDuringOverlayProperty);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006887 File Offset: 0x00004A87
		private static void SetCacheDuringOverlay(global::System.Windows.DependencyObject obj, object value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.CacheDuringOverlayProperty, value);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006895 File Offset: 0x00004A95
		private static bool GetHasTransformWrapper(global::System.Windows.DependencyObject obj)
		{
			return (bool)obj.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.HasTransformWrapperProperty);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000068A7 File Offset: 0x00004AA7
		private static void SetHasTransformWrapper(global::System.Windows.DependencyObject obj, bool value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.HasTransformWrapperProperty, value);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000068BA File Offset: 0x00004ABA
		protected override bool ShouldSkipInitialLayout
		{
			get
			{
				return base.ShouldSkipInitialLayout || this.InitialTag == global::Microsoft.Expression.Interactivity.Layout.TagType.DataContext;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000068D0 File Offset: 0x00004AD0
		protected override void EnsureTags(global::System.Windows.FrameworkElement child)
		{
			base.EnsureTags(child);
			if (this.InitialTag == global::Microsoft.Expression.Interactivity.Layout.TagType.DataContext)
			{
				object obj = child.ReadLocalValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialIdentityTagProperty);
				if (!(obj is global::System.Windows.Data.BindingExpression))
				{
					child.SetBinding(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.InitialIdentityTagProperty, new global::System.Windows.Data.Binding(this.InitialTagPath));
				}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000069F4 File Offset: 0x00004BF4
		internal override void UpdateLayoutTransitionCore(global::System.Windows.FrameworkElement child, global::System.Windows.FrameworkElement root, object tag, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData newTagData)
		{
			bool flag = false;
			bool flag2 = false;
			object initialIdentityTag = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.GetInitialIdentityTag(child);
			global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData tagData;
			bool flag3 = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.TryGetValue(tag, out tagData);
			if (flag3 && tagData.InitialTag != initialIdentityTag)
			{
				flag3 = false;
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.Remove(tag);
			}
			global::System.Windows.Rect rect;
			if (!flag3)
			{
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData tagData2;
				if (initialIdentityTag != null && global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.TryGetValue(initialIdentityTag, out tagData2))
				{
					rect = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TranslateRect(tagData2.AppRect, root, newTagData.Parent);
					flag = true;
					flag2 = true;
				}
				else
				{
					rect = global::System.Windows.Rect.Empty;
				}
				tagData = new global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData
				{
					ParentRect = global::System.Windows.Rect.Empty,
					AppRect = global::System.Windows.Rect.Empty,
					Parent = newTagData.Parent,
					Child = child,
					Timestamp = global::System.DateTime.Now,
					InitialTag = initialIdentityTag
				};
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.Add(tag, tagData);
			}
			else if (tagData.Parent != global::System.Windows.Media.VisualTreeHelper.GetParent(child))
			{
				rect = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TranslateRect(tagData.AppRect, root, newTagData.Parent);
				flag = true;
			}
			else
			{
				rect = tagData.ParentRect;
			}
			global::System.Windows.FrameworkElement originalChild = child;
			if ((!global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.IsEmptyRect(rect) && !global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.IsEmptyRect(newTagData.ParentRect) && (!global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.IsClose(rect.Left, newTagData.ParentRect.Left) || !global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.IsClose(rect.Top, newTagData.ParentRect.Top))) || (child != tagData.Child && global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransitionStoryboardDictionary.ContainsKey(tag)))
			{
				global::System.Windows.Rect rect2 = rect;
				bool flag4 = false;
				global::System.Windows.Media.Animation.Storyboard storyboard = null;
				if (global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransitionStoryboardDictionary.TryGetValue(tag, out storyboard))
				{
					object overlay2 = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.GetOverlay(tagData.Child);
					global::Microsoft.Expression.Interactivity.Layout.AdornerContainer adornerContainer = (global::Microsoft.Expression.Interactivity.Layout.AdornerContainer)overlay2;
					flag4 = (overlay2 != null);
					global::System.Windows.FrameworkElement child2 = tagData.Child;
					if (overlay2 != null)
					{
						global::System.Windows.Controls.Canvas canvas = adornerContainer.Child as global::System.Windows.Controls.Canvas;
						if (canvas != null)
						{
							child2 = (canvas.Children[0] as global::System.Windows.FrameworkElement);
						}
					}
					if (!flag2)
					{
						global::System.Windows.Media.Transform transform = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.GetTransform(child2);
						rect2 = transform.TransformBounds(rect2);
					}
					global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransitionStoryboardDictionary.Remove(tag);
					storyboard.Stop();
					storyboard = null;
					global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.RemoveTransform(child2);
					if (overlay2 != null)
					{
						global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(root).Remove(adornerContainer);
						global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransferLocalValue(tagData.Child, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.CacheDuringOverlayProperty, global::System.Windows.UIElement.RenderTransformProperty);
						global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.SetOverlay(tagData.Child, null);
					}
				}
				object overlay = null;
				if (flag4 || (flag && this.FloatAbove))
				{
					global::System.Windows.Controls.Canvas canvas2 = new global::System.Windows.Controls.Canvas
					{
						Width = newTagData.ParentRect.Width,
						Height = newTagData.ParentRect.Height,
						IsHitTestVisible = false
					};
					global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle
					{
						Width = newTagData.ParentRect.Width,
						Height = newTagData.ParentRect.Height,
						IsHitTestVisible = false
					};
					rectangle.Fill = new global::System.Windows.Media.VisualBrush(child);
					canvas2.Children.Add(rectangle);
					global::Microsoft.Expression.Interactivity.Layout.AdornerContainer adornerContainer2 = new global::Microsoft.Expression.Interactivity.Layout.AdornerContainer(child)
					{
						Child = canvas2
					};
					overlay = adornerContainer2;
					global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.SetOverlay(originalChild, overlay);
					global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(root);
					adornerLayer.Add(adornerContainer2);
					global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransferLocalValue(child, global::System.Windows.UIElement.RenderTransformProperty, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.CacheDuringOverlayProperty);
					child.RenderTransform = new global::System.Windows.Media.TranslateTransform(-10000.0, -10000.0);
					canvas2.RenderTransform = new global::System.Windows.Media.TranslateTransform(10000.0, 10000.0);
					child = rectangle;
				}
				global::System.Windows.Rect parentRect = newTagData.ParentRect;
				global::System.Windows.Media.Animation.Storyboard transitionStoryboard = this.CreateTransitionStoryboard(child, flag2, ref parentRect, ref rect2);
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransitionStoryboardDictionary.Add(tag, transitionStoryboard);
				transitionStoryboard.Completed += delegate(object sender, global::System.EventArgs e)
				{
					global::System.Windows.Media.Animation.Storyboard storyboard2;
					if (global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransitionStoryboardDictionary.TryGetValue(tag, out storyboard2) && storyboard2 == transitionStoryboard)
					{
						global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransitionStoryboardDictionary.Remove(tag);
						transitionStoryboard.Stop();
						global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.RemoveTransform(child);
						child.InvalidateMeasure();
						if (overlay != null)
						{
							global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(root).Remove((global::Microsoft.Expression.Interactivity.Layout.AdornerContainer)overlay);
							global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.TransferLocalValue(originalChild, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.CacheDuringOverlayProperty, global::System.Windows.UIElement.RenderTransformProperty);
							global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.SetOverlay(originalChild, null);
						}
					}
				};
				transitionStoryboard.Begin();
			}
			tagData.ParentRect = newTagData.ParentRect;
			tagData.AppRect = newTagData.AppRect;
			tagData.Parent = newTagData.Parent;
			tagData.Child = newTagData.Child;
			tagData.Timestamp = newTagData.Timestamp;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006EE0 File Offset: 0x000050E0
		private global::System.Windows.Media.Animation.Storyboard CreateTransitionStoryboard(global::System.Windows.FrameworkElement child, bool usingBeforeLoaded, ref global::System.Windows.Rect layoutRect, ref global::System.Windows.Rect currentRect)
		{
			global::System.Windows.Duration duration = this.Duration;
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.Duration = duration;
			double num = (!usingBeforeLoaded || layoutRect.Width == 0.0) ? 1.0 : (currentRect.Width / layoutRect.Width);
			double num2 = (!usingBeforeLoaded || layoutRect.Height == 0.0) ? 1.0 : (currentRect.Height / layoutRect.Height);
			double num3 = currentRect.Left - layoutRect.Left;
			double num4 = currentRect.Top - layoutRect.Top;
			global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.AddTransform(child, new global::System.Windows.Media.TransformGroup
			{
				Children = 
				{
					new global::System.Windows.Media.ScaleTransform
					{
						ScaleX = num,
						ScaleY = num2
					},
					new global::System.Windows.Media.TranslateTransform
					{
						X = num3,
						Y = num4
					}
				}
			});
			string text = "(FrameworkElement.RenderTransform).";
			global::System.Windows.Media.TransformGroup transformGroup = child.RenderTransform as global::System.Windows.Media.TransformGroup;
			if (transformGroup != null && global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.GetHasTransformWrapper(child))
			{
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					"(TransformGroup.Children)[",
					transformGroup.Children.Count - 1,
					"]."
				});
			}
			if (usingBeforeLoaded)
			{
				if (num != 1.0)
				{
					global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation
					{
						Duration = duration,
						From = new double?(num),
						To = new double?(1.0)
					};
					global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation, child);
					global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(text + "(TransformGroup.Children)[0].(ScaleTransform.ScaleX)", new object[0]));
					doubleAnimation.EasingFunction = this.EaseX;
					storyboard.Children.Add(doubleAnimation);
				}
				if (num2 != 1.0)
				{
					global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation2 = new global::System.Windows.Media.Animation.DoubleAnimation
					{
						Duration = duration,
						From = new double?(num2),
						To = new double?(1.0)
					};
					global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation2, child);
					global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation2, new global::System.Windows.PropertyPath(text + "(TransformGroup.Children)[0].(ScaleTransform.ScaleY)", new object[0]));
					doubleAnimation2.EasingFunction = this.EaseY;
					storyboard.Children.Add(doubleAnimation2);
				}
			}
			if (num3 != 0.0)
			{
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation3 = new global::System.Windows.Media.Animation.DoubleAnimation
				{
					Duration = duration,
					From = new double?(num3),
					To = new double?(0.0)
				};
				global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation3, child);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation3, new global::System.Windows.PropertyPath(text + "(TransformGroup.Children)[1].(TranslateTransform.X)", new object[0]));
				doubleAnimation3.EasingFunction = this.EaseX;
				storyboard.Children.Add(doubleAnimation3);
			}
			if (num4 != 0.0)
			{
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation4 = new global::System.Windows.Media.Animation.DoubleAnimation
				{
					Duration = duration,
					From = new double?(num4),
					To = new double?(0.0)
				};
				global::System.Windows.Media.Animation.Storyboard.SetTarget(doubleAnimation4, child);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation4, new global::System.Windows.PropertyPath(text + "(TransformGroup.Children)[1].(TranslateTransform.Y)", new object[0]));
				doubleAnimation4.EasingFunction = this.EaseY;
				storyboard.Children.Add(doubleAnimation4);
			}
			return storyboard;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000724C File Offset: 0x0000544C
		private static void AddTransform(global::System.Windows.FrameworkElement child, global::System.Windows.Media.Transform transform)
		{
			global::System.Windows.Media.TransformGroup transformGroup = child.RenderTransform as global::System.Windows.Media.TransformGroup;
			if (transformGroup == null)
			{
				transformGroup = new global::System.Windows.Media.TransformGroup();
				transformGroup.Children.Add(child.RenderTransform);
				child.RenderTransform = transformGroup;
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.SetHasTransformWrapper(child, true);
			}
			transformGroup.Children.Add(transform);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000729C File Offset: 0x0000549C
		private static global::System.Windows.Media.Transform GetTransform(global::System.Windows.FrameworkElement child)
		{
			global::System.Windows.Media.TransformGroup transformGroup = child.RenderTransform as global::System.Windows.Media.TransformGroup;
			if (transformGroup != null && transformGroup.Children.Count > 0)
			{
				return transformGroup.Children[transformGroup.Children.Count - 1];
			}
			return new global::System.Windows.Media.TranslateTransform();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000072E4 File Offset: 0x000054E4
		private static void RemoveTransform(global::System.Windows.FrameworkElement child)
		{
			global::System.Windows.Media.TransformGroup transformGroup = child.RenderTransform as global::System.Windows.Media.TransformGroup;
			if (transformGroup != null)
			{
				if (global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.GetHasTransformWrapper(child))
				{
					child.RenderTransform = transformGroup.Children[0];
					global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior.SetHasTransformWrapper(child, false);
					return;
				}
				transformGroup.Children.RemoveAt(transformGroup.Children.Count - 1);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000733C File Offset: 0x0000553C
		private static void TransferLocalValue(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty source, global::System.Windows.DependencyProperty dest)
		{
			object obj = element.ReadLocalValue(source);
			global::System.Windows.Data.BindingExpressionBase bindingExpressionBase = obj as global::System.Windows.Data.BindingExpressionBase;
			if (bindingExpressionBase != null)
			{
				element.SetBinding(dest, bindingExpressionBase.ParentBindingBase);
			}
			else if (obj == global::System.Windows.DependencyProperty.UnsetValue)
			{
				element.ClearValue(dest);
			}
			else
			{
				element.SetValue(dest, element.GetAnimationBaseValue(source));
			}
			element.ClearValue(source);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00007391 File Offset: 0x00005591
		private static bool IsClose(double a, double b)
		{
			return global::System.Math.Abs(a - b) < 1E-07;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000073A7 File Offset: 0x000055A7
		private static bool IsEmptyRect(global::System.Windows.Rect rect)
		{
			return rect.IsEmpty || double.IsNaN(rect.Left) || double.IsNaN(rect.Top);
		}

		// Token: 0x04000053 RID: 83
		public static readonly global::System.Windows.DependencyProperty DurationProperty = global::System.Windows.DependencyProperty.Register("Duration", typeof(global::System.Windows.Duration), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(1.0))));

		// Token: 0x04000054 RID: 84
		public static readonly global::System.Windows.DependencyProperty InitialTagProperty = global::System.Windows.DependencyProperty.Register("InitialTag", typeof(global::Microsoft.Expression.Interactivity.Layout.TagType), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(global::Microsoft.Expression.Interactivity.Layout.TagType.Element));

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty InitialTagPathProperty = global::System.Windows.DependencyProperty.Register("InitialTagPath", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(string.Empty));

		// Token: 0x04000056 RID: 86
		private static readonly global::System.Windows.DependencyProperty InitialIdentityTagProperty = global::System.Windows.DependencyProperty.RegisterAttached("InitialIdentityTag", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty FloatAboveProperty = global::System.Windows.DependencyProperty.Register("FloatAbove", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty EaseXProperty = global::System.Windows.DependencyProperty.Register("EaseX", typeof(global::System.Windows.Media.Animation.IEasingFunction), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty EaseYProperty = global::System.Windows.DependencyProperty.Register("EaseY", typeof(global::System.Windows.Media.Animation.IEasingFunction), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400005A RID: 90
		private static readonly global::System.Windows.DependencyProperty OverlayProperty = global::System.Windows.DependencyProperty.RegisterAttached("Overlay", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400005B RID: 91
		private static readonly global::System.Windows.DependencyProperty CacheDuringOverlayProperty = global::System.Windows.DependencyProperty.RegisterAttached("CacheDuringOverlay", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x0400005C RID: 92
		private static readonly global::System.Windows.DependencyProperty HasTransformWrapperProperty = global::System.Windows.DependencyProperty.RegisterAttached("HasTransformWrapper", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x0400005D RID: 93
		private static global::System.Collections.Generic.Dictionary<object, global::System.Windows.Media.Animation.Storyboard> TransitionStoryboardDictionary = new global::System.Collections.Generic.Dictionary<object, global::System.Windows.Media.Animation.Storyboard>();
	}
}
