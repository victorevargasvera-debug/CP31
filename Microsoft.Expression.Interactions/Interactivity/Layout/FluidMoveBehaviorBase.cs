using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Interactivity;
using System.Windows.Media;
using Microsoft.Expression.Interactivity.Core;

namespace Microsoft.Expression.Interactivity.Layout
{
	// Token: 0x02000019 RID: 25
	public abstract class FluidMoveBehaviorBase : global::System.Windows.Interactivity.Behavior<global::System.Windows.FrameworkElement>
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000617A File Offset: 0x0000437A
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000618C File Offset: 0x0000438C
		public global::Microsoft.Expression.Interactivity.Layout.FluidMoveScope AppliesTo
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Layout.FluidMoveScope)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.AppliesToProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.AppliesToProperty, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000619F File Offset: 0x0000439F
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000061B1 File Offset: 0x000043B1
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.IsActiveProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.IsActiveProperty, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000061C4 File Offset: 0x000043C4
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000061D6 File Offset: 0x000043D6
		public global::Microsoft.Expression.Interactivity.Layout.TagType Tag
		{
			get
			{
				return (global::Microsoft.Expression.Interactivity.Layout.TagType)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagProperty, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000061E9 File Offset: 0x000043E9
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000061FB File Offset: 0x000043FB
		public string TagPath
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagPathProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagPathProperty, value);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006209 File Offset: 0x00004409
		protected static object GetIdentityTag(global::System.Windows.DependencyObject obj)
		{
			return obj.GetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.IdentityTagProperty);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006216 File Offset: 0x00004416
		protected static void SetIdentityTag(global::System.Windows.DependencyObject obj, object value)
		{
			obj.SetValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.IdentityTagProperty, value);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006224 File Offset: 0x00004424
		protected override void OnAttached()
		{
			base.OnAttached();
			base.AssociatedObject.LayoutUpdated += this.AssociatedObject_LayoutUpdated;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006243 File Offset: 0x00004443
		protected override void OnDetaching()
		{
			base.OnDetaching();
			base.AssociatedObject.LayoutUpdated -= this.AssociatedObject_LayoutUpdated;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006264 File Offset: 0x00004464
		private void AssociatedObject_LayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (!this.IsActive)
			{
				return;
			}
			if (global::System.DateTime.Now - global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.LastPurgeTick >= global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.MinTickDelta)
			{
				global::System.Collections.Generic.List<object> list = null;
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData> keyValuePair in global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary)
				{
					if (keyValuePair.Value.Timestamp < global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.NextToLastPurgeTick)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<object>();
						}
						list.Add(keyValuePair.Key);
					}
				}
				if (list != null)
				{
					foreach (object key in list)
					{
						global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.Remove(key);
					}
				}
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.NextToLastPurgeTick = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.LastPurgeTick;
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.LastPurgeTick = global::System.DateTime.Now;
			}
			if (this.AppliesTo == global::Microsoft.Expression.Interactivity.Layout.FluidMoveScope.Self)
			{
				this.UpdateLayoutTransition(base.AssociatedObject);
				return;
			}
			global::System.Windows.Controls.Panel panel = base.AssociatedObject as global::System.Windows.Controls.Panel;
			if (panel != null)
			{
				foreach (object obj in panel.Children)
				{
					global::System.Windows.FrameworkElement child = (global::System.Windows.FrameworkElement)obj;
					this.UpdateLayoutTransition(child);
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000063D8 File Offset: 0x000045D8
		private void UpdateLayoutTransition(global::System.Windows.FrameworkElement child)
		{
			if ((child.Visibility == global::System.Windows.Visibility.Collapsed || !child.IsLoaded) && this.ShouldSkipInitialLayout)
			{
				return;
			}
			global::System.Windows.FrameworkElement visualRoot = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.GetVisualRoot(child);
			global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData tagData = new global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData();
			tagData.Parent = (global::System.Windows.Media.VisualTreeHelper.GetParent(child) as global::System.Windows.FrameworkElement);
			tagData.ParentRect = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetLayoutRect(child);
			tagData.Child = child;
			tagData.Timestamp = global::System.DateTime.Now;
			try
			{
				tagData.AppRect = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TranslateRect(tagData.ParentRect, tagData.Parent, visualRoot);
			}
			catch (global::System.ArgumentException)
			{
				if (this.ShouldSkipInitialLayout)
				{
					return;
				}
			}
			this.EnsureTags(child);
			object obj = global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.GetIdentityTag(child);
			if (obj == null)
			{
				obj = child;
			}
			this.UpdateLayoutTransitionCore(child, visualRoot, obj, tagData);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00006490 File Offset: 0x00004690
		protected virtual bool ShouldSkipInitialLayout
		{
			get
			{
				return this.Tag == global::Microsoft.Expression.Interactivity.Layout.TagType.DataContext;
			}
		}

		// Token: 0x060000DF RID: 223
		internal abstract void UpdateLayoutTransitionCore(global::System.Windows.FrameworkElement child, global::System.Windows.FrameworkElement root, object tag, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData newTagData);

		// Token: 0x060000E0 RID: 224 RVA: 0x0000649C File Offset: 0x0000469C
		protected virtual void EnsureTags(global::System.Windows.FrameworkElement child)
		{
			if (this.Tag == global::Microsoft.Expression.Interactivity.Layout.TagType.DataContext)
			{
				object obj = child.ReadLocalValue(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.IdentityTagProperty);
				if (!(obj is global::System.Windows.Data.BindingExpression))
				{
					child.SetBinding(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.IdentityTagProperty, new global::System.Windows.Data.Binding(this.TagPath));
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000064E0 File Offset: 0x000046E0
		private static global::System.Windows.FrameworkElement GetVisualRoot(global::System.Windows.FrameworkElement child)
		{
			for (;;)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetParent(child) as global::System.Windows.FrameworkElement;
				if (frameworkElement == null)
				{
					break;
				}
				if (global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(frameworkElement) == null)
				{
					return child;
				}
				child = frameworkElement;
			}
			return child;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000650C File Offset: 0x0000470C
		internal static global::System.Windows.Rect TranslateRect(global::System.Windows.Rect rect, global::System.Windows.FrameworkElement from, global::System.Windows.FrameworkElement to)
		{
			if (from == null || to == null)
			{
				return rect;
			}
			global::System.Windows.Point point = new global::System.Windows.Point(rect.Left, rect.Top);
			point = from.TransformToVisual(to).Transform(point);
			return new global::System.Windows.Rect(point.X, point.Y, rect.Width, rect.Height);
		}

		// Token: 0x04000044 RID: 68
		public static readonly global::System.Windows.DependencyProperty AppliesToProperty = global::System.Windows.DependencyProperty.Register("AppliesTo", typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveScope), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase), new global::System.Windows.PropertyMetadata(global::Microsoft.Expression.Interactivity.Layout.FluidMoveScope.Self));

		// Token: 0x04000045 RID: 69
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x04000046 RID: 70
		public static readonly global::System.Windows.DependencyProperty TagProperty = global::System.Windows.DependencyProperty.Register("Tag", typeof(global::Microsoft.Expression.Interactivity.Layout.TagType), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase), new global::System.Windows.PropertyMetadata(global::Microsoft.Expression.Interactivity.Layout.TagType.Element));

		// Token: 0x04000047 RID: 71
		public static readonly global::System.Windows.DependencyProperty TagPathProperty = global::System.Windows.DependencyProperty.Register("TagPath", typeof(string), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase), new global::System.Windows.PropertyMetadata(string.Empty));

		// Token: 0x04000048 RID: 72
		protected static readonly global::System.Windows.DependencyProperty IdentityTagProperty = global::System.Windows.DependencyProperty.RegisterAttached("IdentityTag", typeof(object), typeof(global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000049 RID: 73
		internal static global::System.Collections.Generic.Dictionary<object, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData> TagDictionary = new global::System.Collections.Generic.Dictionary<object, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData>();

		// Token: 0x0400004A RID: 74
		private static global::System.DateTime NextToLastPurgeTick = global::System.DateTime.MinValue;

		// Token: 0x0400004B RID: 75
		private static global::System.DateTime LastPurgeTick = global::System.DateTime.MinValue;

		// Token: 0x0400004C RID: 76
		private static global::System.TimeSpan MinTickDelta = global::System.TimeSpan.FromSeconds(0.5);

		// Token: 0x0200001A RID: 26
		internal class TagData
		{
			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000668E File Offset: 0x0000488E
			// (set) Token: 0x060000E6 RID: 230 RVA: 0x00006696 File Offset: 0x00004896
			public global::System.Windows.FrameworkElement Child { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000669F File Offset: 0x0000489F
			// (set) Token: 0x060000E8 RID: 232 RVA: 0x000066A7 File Offset: 0x000048A7
			public global::System.Windows.FrameworkElement Parent { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000E9 RID: 233 RVA: 0x000066B0 File Offset: 0x000048B0
			// (set) Token: 0x060000EA RID: 234 RVA: 0x000066B8 File Offset: 0x000048B8
			public global::System.Windows.Rect ParentRect { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000EB RID: 235 RVA: 0x000066C1 File Offset: 0x000048C1
			// (set) Token: 0x060000EC RID: 236 RVA: 0x000066C9 File Offset: 0x000048C9
			public global::System.Windows.Rect AppRect { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000ED RID: 237 RVA: 0x000066D2 File Offset: 0x000048D2
			// (set) Token: 0x060000EE RID: 238 RVA: 0x000066DA File Offset: 0x000048DA
			public global::System.DateTime Timestamp { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000EF RID: 239 RVA: 0x000066E3 File Offset: 0x000048E3
			// (set) Token: 0x060000F0 RID: 240 RVA: 0x000066EB File Offset: 0x000048EB
			public object InitialTag { get; set; }
		}
	}
}
