using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000083 RID: 131
	public class SystemResourceProvider : global::Infragistics.Controls.Primitives.ResourceProvider<global::Infragistics.Controls.Primitives.SystemResourceId>
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x00013A3C File Offset: 0x00011C3C
		public SystemResourceProvider()
		{
			lock (global::Infragistics.Controls.Primitives.SystemResourceProvider._SystemProviders)
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider._SystemProviders.Add(this);
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00013A88 File Offset: 0x00011C88
		protected override object GetResource(global::Infragistics.Controls.Primitives.SystemResourceId id)
		{
			object obj = null;
			if (global::Infragistics.Controls.Primitives.SystemResourceProvider._Map == null)
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider._Map = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Primitives.SystemResourceId, object>();
			}
			else
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider._Map.TryGetValue(id, out obj);
			}
			global::System.Type left;
			global::System.Windows.Media.Color color = global::Infragistics.Controls.Primitives.SystemResourceProvider.ColorFromId(id, out left);
			bool flag = obj != null;
			if (flag)
			{
				if (left == typeof(global::System.Windows.Media.Brush))
				{
					global::System.Windows.Media.SolidColorBrush solidColorBrush = obj as global::System.Windows.Media.SolidColorBrush;
					if (solidColorBrush != null || solidColorBrush.Color == color)
					{
						return obj;
					}
				}
				else
				{
					if (!(left == typeof(global::System.Windows.Media.Color)))
					{
						return obj;
					}
					if (obj is global::System.Windows.Media.Color && color == (global::System.Windows.Media.Color)obj)
					{
						return obj;
					}
				}
			}
			if (left == typeof(global::System.Windows.Media.Brush))
			{
				global::System.Windows.Media.Brush brush = new global::System.Windows.Media.SolidColorBrush(color);
				brush.Freeze();
				obj = brush;
			}
			else if (left == typeof(global::System.Windows.Media.Color))
			{
				obj = color;
			}
			if (flag)
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider._Map[id] = obj;
				global::Infragistics.Controls.Primitives.SystemResourceProvider.VerifyHelper(false);
				global::Infragistics.Controls.Primitives.SystemResourceProvider.NotifyAllProviders();
			}
			else
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider._Map.Add(id, obj);
			}
			return obj;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00013B90 File Offset: 0x00011D90
		public override void InvalidateResources()
		{
			global::Infragistics.Controls.Primitives.SystemResourceProvider.VerifyCachedResources();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00013B98 File Offset: 0x00011D98
		protected override void OnSystemColorsChanged()
		{
			base.BumpResourceVersion();
			base.RaisePropertyChangedEvent("Item[]");
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00013BAB File Offset: 0x00011DAB
		public static bool VerifyCachedResources()
		{
			return global::Infragistics.Controls.Primitives.SystemResourceProvider.VerifyHelper(true);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00013BB4 File Offset: 0x00011DB4
		private static global::System.Windows.Media.Color ColorFromId(global::Infragistics.Controls.Primitives.SystemResourceId id, out global::System.Type type)
		{
			type = typeof(global::System.Windows.Media.Brush);
			switch (id)
			{
			case global::Infragistics.Controls.Primitives.SystemResourceId.ActiveBorderBrush:
				return global::System.Windows.SystemColors.ActiveBorderColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ActiveBorderColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ActiveBorderColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ActiveCaptionBrush:
				return global::System.Windows.SystemColors.ActiveCaptionColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ActiveCaptionColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ActiveCaptionColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ActiveCaptionTextBrush:
				return global::System.Windows.SystemColors.ActiveCaptionTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ActiveCaptionTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ActiveCaptionTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.AppWorkspaceBrush:
				return global::System.Windows.SystemColors.AppWorkspaceColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.AppWorkspaceColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.AppWorkspaceColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlBrush:
				return global::System.Windows.SystemColors.ControlColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ControlColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlDarkBrush:
				return global::System.Windows.SystemColors.ControlDarkColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlDarkColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ControlDarkColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlDarkDarkBrush:
				return global::System.Windows.SystemColors.ControlDarkDarkColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlDarkDarkColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ControlDarkDarkColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlLightBrush:
				return global::System.Windows.SystemColors.ControlLightColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlLightColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ControlLightColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlLightLightBrush:
				return global::System.Windows.SystemColors.ControlLightLightColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlLightLightColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ControlLightLightColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlTextBrush:
				return global::System.Windows.SystemColors.ControlTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ControlTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ControlTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.DesktopBrush:
				return global::System.Windows.SystemColors.DesktopColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.DesktopColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.DesktopColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.GrayTextBrush:
				return global::System.Windows.SystemColors.GrayTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.GrayTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.GrayTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.HighlightBrush:
				return global::System.Windows.SystemColors.HighlightColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.HighlightColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.HighlightColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.HighlightTextBrush:
				return global::System.Windows.SystemColors.HighlightTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.HighlightTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.HighlightTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InfoBrush:
				return global::System.Windows.SystemColors.InfoColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InfoColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.InfoColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InfoTextBrush:
				return global::System.Windows.SystemColors.InfoTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InfoTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.InfoTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InactiveBorderBrush:
				return global::System.Windows.SystemColors.InactiveBorderColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InactiveBorderColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.InactiveBorderColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InactiveCaptionBrush:
				return global::System.Windows.SystemColors.InactiveCaptionColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InactiveCaptionColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.InactiveCaptionColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InactiveCaptionTextBrush:
				return global::System.Windows.SystemColors.InactiveCaptionTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.InactiveCaptionTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.InactiveCaptionTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.MenuBrush:
				return global::System.Windows.SystemColors.MenuColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.MenuColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.MenuColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.MenuTextBrush:
				return global::System.Windows.SystemColors.MenuTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.MenuTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.MenuTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ScrollBarBrush:
				return global::System.Windows.SystemColors.ScrollBarColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.ScrollBarColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.ScrollBarColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.WindowBrush:
				return global::System.Windows.SystemColors.WindowColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.WindowColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.WindowColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.WindowFrameBrush:
				return global::System.Windows.SystemColors.WindowFrameColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.WindowFrameColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.WindowFrameColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.WindowTextBrush:
				return global::System.Windows.SystemColors.WindowTextColor;
			case global::Infragistics.Controls.Primitives.SystemResourceId.WindowTextColor:
				type = typeof(global::System.Windows.Media.Color);
				return global::System.Windows.SystemColors.WindowTextColor;
			default:
				return global::System.Windows.SystemColors.WindowColor;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00013F00 File Offset: 0x00012100
		private static void NotifyAllProviders()
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.SystemResourceProvider> list = null;
			lock (global::Infragistics.Controls.Primitives.SystemResourceProvider._SystemProviders)
			{
				list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.SystemResourceProvider>(global::Infragistics.Controls.Primitives.SystemResourceProvider._SystemProviders);
			}
			foreach (global::Infragistics.Controls.Primitives.SystemResourceProvider systemResourceProvider in list)
			{
				systemResourceProvider.OnSystemColorsChangedInternal();
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00013F84 File Offset: 0x00012184
		private static bool VerifyHelper(bool notify)
		{
			if (global::Infragistics.Controls.Primitives.SystemResourceProvider._Map == null)
			{
				return true;
			}
			global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.SystemResourceId> list = null;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Primitives.SystemResourceId, object> keyValuePair in global::Infragistics.Controls.Primitives.SystemResourceProvider._Map)
			{
				global::System.Type left;
				global::System.Windows.Media.Color color = global::Infragistics.Controls.Primitives.SystemResourceProvider.ColorFromId(keyValuePair.Key, out left);
				bool flag = false;
				if (left == typeof(global::System.Windows.Media.Brush))
				{
					global::System.Windows.Media.SolidColorBrush solidColorBrush = keyValuePair.Value as global::System.Windows.Media.SolidColorBrush;
					if (solidColorBrush != null)
					{
						if (solidColorBrush.Color != color)
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				else if (left == typeof(global::System.Windows.Media.Color))
				{
					if (keyValuePair.Value is global::System.Windows.Media.Color)
					{
						if ((global::System.Windows.Media.Color)keyValuePair.Value != color)
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				if (flag)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.SystemResourceId>();
					}
					list.Add(keyValuePair.Key);
				}
			}
			if (list == null)
			{
				return true;
			}
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider._Map.Remove(list[i]);
			}
			if (notify)
			{
				global::Infragistics.Controls.Primitives.SystemResourceProvider.NotifyAllProviders();
			}
			return false;
		}

		// Token: 0x040001E7 RID: 487
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Primitives.SystemResourceId, object> _Map;

		// Token: 0x040001E8 RID: 488
		private static readonly global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.Primitives.SystemResourceProvider> _SystemProviders = new global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.Primitives.SystemResourceProvider>();
	}
}
