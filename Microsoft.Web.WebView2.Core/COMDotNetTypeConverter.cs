using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200000F RID: 15
	internal static class COMDotNetTypeConverter
	{
		// Token: 0x060000CD RID: 205 RVA: 0x0000699C File Offset: 0x00004B9C
		public static global::System.Drawing.Rectangle RectangleCOMToNet(global::Microsoft.Web.WebView2.Core.Raw.tagRECT rect)
		{
			int left = rect.left;
			int top = rect.top;
			int width = rect.right - rect.left;
			int height = rect.bottom - rect.top;
			return new global::System.Drawing.Rectangle(left, top, width, height);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000069E4 File Offset: 0x00004BE4
		public static global::Microsoft.Web.WebView2.Core.Raw.tagRECT RectangleNetToCOM(global::System.Drawing.Rectangle dotNetRect)
		{
			return new global::Microsoft.Web.WebView2.Core.Raw.tagRECT
			{
				top = dotNetRect.Top,
				left = dotNetRect.Left,
				right = dotNetRect.Right,
				bottom = dotNetRect.Bottom
			};
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006A3C File Offset: 0x00004C3C
		public static global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie> CookieListCOMToNet(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieList rawCookieList)
		{
			global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie> list = new global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie>(global::System.Convert.ToInt32(rawCookieList.Count));
			for (uint num = 0U; num < rawCookieList.Count; num += 1U)
			{
				list.Add(new global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie(rawCookieList.GetValueAtIndex(num)));
			}
			return list;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006A8C File Offset: 0x00004C8C
		public static global::System.Collections.Generic.IReadOnlyList<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo> CoreWebView2FrameInfoCollectionCOMToNet(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfoCollection rawFrameInfoCollection)
		{
			bool flag = rawFrameInfoCollection == null;
			global::System.Collections.Generic.IReadOnlyList<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo> list = new global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo>();
				global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfoCollectionIterator iterator = rawFrameInfoCollection.GetIterator();
				while (iterator.HasCurrent != 0)
				{
					list.Add(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo(iterator.GetCurrent()));
					iterator.MoveNext();
				}
				result = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo>(list);
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006AEC File Offset: 0x00004CEC
		public static global::System.Drawing.Color ColorCOMToNet(global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COLOR color)
		{
			return global::System.Drawing.Color.FromArgb((int)color.A, (int)color.R, (int)color.G, (int)color.B);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006B1C File Offset: 0x00004D1C
		public static global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COLOR ColorNetToCOM(global::System.Drawing.Color dotNetColor)
		{
			return new global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COLOR
			{
				A = dotNetColor.A,
				R = dotNetColor.R,
				G = dotNetColor.G,
				B = dotNetColor.B
			};
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006B74 File Offset: 0x00004D74
		public static global::System.Drawing.Point PointCOMToNet(global::Microsoft.Web.WebView2.Core.Raw.tagPOINT point)
		{
			return new global::System.Drawing.Point(point.x, point.y);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006B98 File Offset: 0x00004D98
		public static global::Microsoft.Web.WebView2.Core.Raw.tagPOINT PointNetToCOM(global::System.Drawing.Point dotNetPoint)
		{
			return new global::Microsoft.Web.WebView2.Core.Raw.tagPOINT
			{
				x = global::System.Convert.ToInt32(dotNetPoint.X),
				y = global::System.Convert.ToInt32(dotNetPoint.Y)
			};
		}
	}
}
