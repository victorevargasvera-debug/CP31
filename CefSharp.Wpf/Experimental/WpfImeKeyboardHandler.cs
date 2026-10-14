using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;
using CefSharp.Internals;
using CefSharp.Structs;
using CefSharp.Wpf.Internals;

namespace CefSharp.Wpf.Experimental
{
	// Token: 0x02000027 RID: 39
	public class WpfImeKeyboardHandler : global::CefSharp.Wpf.Internals.WpfKeyboardHandler
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00006FEC File Offset: 0x000051EC
		public WpfImeKeyboardHandler(global::CefSharp.Wpf.ChromiumWebBrowser owner) : base(owner)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00007000 File Offset: 0x00005200
		public void ChangeCompositionRange(global::CefSharp.Structs.Range selectionRange, global::CefSharp.Structs.Rect[] characterBounds)
		{
			if (!this.isActive)
			{
				return;
			}
			global::CefSharp.Structs.ScreenInfo? screenInfo = ((global::CefSharp.Internals.IRenderWebBrowser)this.owner).GetScreenInfo();
			float scaleFactor = (screenInfo != null) ? screenInfo.Value.DeviceScaleFactor : 1f;
			this.owner.UiThreadRunAsync(delegate
			{
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this.owner);
				if (window != null)
				{
					global::System.Windows.Point point = this.owner.TransformToAncestor(window).Transform(new global::System.Windows.Point(0.0, 0.0));
					global::System.Collections.Generic.List<global::CefSharp.Structs.Rect> list = new global::System.Collections.Generic.List<global::CefSharp.Structs.Rect>();
					foreach (global::CefSharp.Structs.Rect rect in characterBounds)
					{
						list.Add(new global::CefSharp.Structs.Rect((int)((point.X + (double)rect.X) * (double)scaleFactor), (int)((point.Y + (double)rect.Y) * (double)scaleFactor), (int)((float)rect.Width * scaleFactor), (int)((float)rect.Height * scaleFactor)));
					}
					this.compositionBounds = list;
					this.MoveImeWindow(this.source.Handle);
				}
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00007074 File Offset: 0x00005274
		public override void Setup(global::System.Windows.Interop.HwndSource source)
		{
			if (this.isSetup)
			{
				return;
			}
			this.isSetup = true;
			this.source = source;
			this.sourceHook = new global::System.Windows.Interop.HwndSourceHook(this.SourceHook);
			source.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.SourceHook));
			this.owner.GotFocus += this.OwnerGotFocus;
			this.owner.LostFocus += this.OwnerLostFocus;
			this.mouseDownEventHandler = new global::System.Windows.Input.MouseButtonEventHandler(this.OwnerMouseDown);
			this.owner.AddHandler(global::System.Windows.UIElement.MouseDownEvent, this.mouseDownEventHandler, true);
			if (this.owner.IsFocused)
			{
				this.SetActive();
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007128 File Offset: 0x00005328
		public override void Dispose()
		{
			if (!this.isSetup)
			{
				return;
			}
			this.isSetup = false;
			this.owner.GotFocus -= this.OwnerGotFocus;
			this.owner.LostFocus -= this.OwnerLostFocus;
			this.owner.RemoveHandler(global::System.Windows.UIElement.MouseDownEvent, this.mouseDownEventHandler);
			if (this.source != null && this.sourceHook != null)
			{
				this.source.RemoveHook(this.sourceHook);
				this.source = null;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000071B1 File Offset: 0x000053B1
		private void OwnerMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.CloseImeComposition();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000071B9 File Offset: 0x000053B9
		private void OwnerGotFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.SetActive();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000071C1 File Offset: 0x000053C1
		private void OwnerLostFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.SetInactive();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000071CC File Offset: 0x000053CC
		private void SetActive()
		{
			if (global::System.Windows.Input.InputMethod.GetIsInputMethodEnabled(this.owner))
			{
				global::System.Windows.Input.InputMethod.SetIsInputMethodEnabled(this.owner, false);
			}
			if (global::System.Windows.Input.InputMethod.GetIsInputMethodSuspended(this.owner))
			{
				global::System.Windows.Input.InputMethod.SetIsInputMethodSuspended(this.owner, false);
			}
			global::System.Windows.Input.InputMethod.SetIsInputMethodEnabled(this.owner, true);
			global::System.Windows.Input.InputMethod.SetIsInputMethodSuspended(this.owner, true);
			this.isActive = true;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000722A File Offset: 0x0000542A
		private void SetInactive()
		{
			this.isActive = false;
			global::System.Windows.Input.InputMethod.SetIsInputMethodEnabled(this.owner, false);
			global::System.Windows.Input.InputMethod.SetIsInputMethodSuspended(this.owner, false);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000724C File Offset: 0x0000544C
		private global::System.IntPtr SourceHook(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			handled = false;
			if (!this.isActive || !this.isSetup || this.owner == null || this.owner.IsDisposed || !this.owner.IsBrowserInitialized)
			{
				return global::System.IntPtr.Zero;
			}
			global::CefSharp.IBrowserHost browserHost = this.owner.GetBrowserHost();
			if (browserHost == null)
			{
				return global::System.IntPtr.Zero;
			}
			switch (msg)
			{
			case 269:
				this.OnIMEStartComposition(hwnd);
				this.hasImeComposition = true;
				handled = true;
				break;
			case 270:
				this.OnImeEndComposition(browserHost, hwnd);
				this.hasImeComposition = false;
				handled = true;
				break;
			case 271:
				this.OnImeComposition(browserHost, hwnd, lParam.ToInt32());
				handled = true;
				break;
			default:
				if (msg == 641)
				{
					this.OnImeSetContext(hwnd, (uint)msg, wParam, lParam);
					handled = true;
				}
				break;
			}
			if (!handled)
			{
				return new global::System.IntPtr(1);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000732A File Offset: 0x0000552A
		private void CloseImeComposition()
		{
			if (this.hasImeComposition)
			{
				global::CefSharp.Wpf.Internals.ImeNative.SetFocus(global::System.IntPtr.Zero);
				global::CefSharp.Wpf.Internals.ImeNative.SetFocus(this.source.Handle);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007350 File Offset: 0x00005550
		private void OnImeComposition(global::CefSharp.IBrowserHost browserHost, global::System.IntPtr hwnd, int lParam)
		{
			string empty = string.Empty;
			if (global::CefSharp.Wpf.Internals.ImeHandler.GetResult(hwnd, (uint)lParam, out empty))
			{
				browserHost.ImeCommitText(empty, new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(int.MaxValue, int.MaxValue)), 0);
				browserHost.ImeSetComposition(empty, new global::CefSharp.Structs.CompositionUnderline[0], new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(int.MaxValue, int.MaxValue)), new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(0, 0)));
				browserHost.ImeFinishComposingText(false);
				return;
			}
			global::System.Collections.Generic.List<global::CefSharp.Structs.CompositionUnderline> list = new global::System.Collections.Generic.List<global::CefSharp.Structs.CompositionUnderline>();
			int num = 0;
			if (global::CefSharp.Wpf.Internals.ImeHandler.GetComposition(hwnd, (uint)lParam, list, ref num, out empty))
			{
				if ((long)this.languageCodeId == 18L)
				{
					browserHost.ImeSetComposition(empty, list.ToArray(), new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(int.MaxValue, int.MaxValue)), new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(num + list.Count, num + list.Count)));
				}
				else
				{
					browserHost.ImeSetComposition(empty, list.ToArray(), new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(int.MaxValue, int.MaxValue)), new global::CefSharp.Structs.Range?(new global::CefSharp.Structs.Range(num, num)));
				}
				this.UpdateCaretPosition(num - 1);
				return;
			}
			this.CancelComposition(browserHost, hwnd);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007460 File Offset: 0x00005660
		private void CancelComposition(global::CefSharp.IBrowserHost browserHost, global::System.IntPtr hwnd)
		{
			browserHost.ImeCancelComposition();
			this.DestroyImeWindow(hwnd);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000746F File Offset: 0x0000566F
		private void OnImeEndComposition(global::CefSharp.IBrowserHost browserHost, global::System.IntPtr hwnd)
		{
			if ((long)this.languageCodeId != 18L)
			{
				browserHost.ImeFinishComposingText(false);
			}
			this.DestroyImeWindow(hwnd);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000748B File Offset: 0x0000568B
		private void OnImeSetContext(global::System.IntPtr hwnd, uint msg, global::System.IntPtr wParam, global::System.IntPtr lParam)
		{
			global::CefSharp.Wpf.Internals.ImeNative.DefWindowProc(hwnd, msg, wParam, (global::System.IntPtr)(lParam.ToInt64() & 2147483647L));
			this.CreateImeWindow(hwnd);
			this.MoveImeWindow(hwnd);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000074B7 File Offset: 0x000056B7
		private void OnIMEStartComposition(global::System.IntPtr hwnd)
		{
			this.CreateImeWindow(hwnd);
			this.MoveImeWindow(hwnd);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000074C8 File Offset: 0x000056C8
		private void CreateImeWindow(global::System.IntPtr hwnd)
		{
			this.languageCodeId = this.PrimaryLangId(global::System.Windows.Input.InputLanguageManager.Current.CurrentInputLanguage.KeyboardLayoutId);
			if (((long)this.languageCodeId == 17L || (long)this.languageCodeId == 4L) && !this.systemCaret && global::CefSharp.Wpf.Internals.ImeNative.CreateCaret(hwnd, global::System.IntPtr.Zero, 1, 1))
			{
				this.systemCaret = true;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007525 File Offset: 0x00005725
		private int PrimaryLangId(int lgid)
		{
			return lgid & 1023;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007530 File Offset: 0x00005730
		private void MoveImeWindow(global::System.IntPtr hwnd)
		{
			if (this.compositionBounds.Count == 0)
			{
				return;
			}
			global::System.IntPtr hIMC = global::CefSharp.Wpf.Internals.ImeNative.ImmGetContext(hwnd);
			global::CefSharp.Structs.Rect rect = this.compositionBounds[0];
			int num = rect.X + rect.Width;
			int num2 = rect.Y + rect.Height;
			global::CefSharp.Wpf.Internals.ImeNative.CANDIDATEFORM candidateform = new global::CefSharp.Wpf.Internals.ImeNative.CANDIDATEFORM
			{
				dwIndex = 0,
				dwStyle = 64,
				ptCurrentPos = new global::CefSharp.Wpf.Internals.ImeNative.POINT(num, num2),
				rcArea = new global::CefSharp.Wpf.Internals.ImeNative.RECT(0, 0, 0, 0)
			};
			global::CefSharp.Wpf.Internals.ImeNative.ImmSetCandidateWindow(hIMC, ref candidateform);
			if (this.systemCaret)
			{
				global::CefSharp.Wpf.Internals.ImeNative.SetCaretPos(num, num2);
			}
			if ((long)this.languageCodeId == 4L)
			{
				global::CefSharp.Wpf.Internals.ImeNative.COMPOSITIONFORM compositionform = new global::CefSharp.Wpf.Internals.ImeNative.COMPOSITIONFORM
				{
					dwStyle = 2,
					ptCurrentPos = new global::CefSharp.Wpf.Internals.ImeNative.POINT(num, num2),
					rcArea = new global::CefSharp.Wpf.Internals.ImeNative.RECT(0, 0, 0, 0)
				};
				global::CefSharp.Wpf.Internals.ImeNative.ImmSetCompositionWindow(hIMC, ref compositionform);
			}
			if ((long)this.languageCodeId == 18L)
			{
				num2++;
			}
			global::CefSharp.Wpf.Internals.ImeNative.CANDIDATEFORM candidateform2 = new global::CefSharp.Wpf.Internals.ImeNative.CANDIDATEFORM
			{
				dwIndex = 0,
				dwStyle = 128,
				ptCurrentPos = new global::CefSharp.Wpf.Internals.ImeNative.POINT(num, num2),
				rcArea = new global::CefSharp.Wpf.Internals.ImeNative.RECT(rect.X, rect.Y, num, num2 + 1)
			};
			global::CefSharp.Wpf.Internals.ImeNative.ImmSetCandidateWindow(hIMC, ref candidateform2);
			global::CefSharp.Wpf.Internals.ImeNative.ImmReleaseContext(hwnd, hIMC);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007686 File Offset: 0x00005886
		private void DestroyImeWindow(global::System.IntPtr hwnd)
		{
			if (this.systemCaret)
			{
				global::CefSharp.Wpf.Internals.ImeNative.DestroyCaret();
				this.systemCaret = false;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000769D File Offset: 0x0000589D
		private void UpdateCaretPosition(int index)
		{
			this.MoveImeWindow(this.source.Handle);
		}

		// Token: 0x0400019F RID: 415
		private int languageCodeId;

		// Token: 0x040001A0 RID: 416
		private bool systemCaret;

		// Token: 0x040001A1 RID: 417
		private bool isSetup;

		// Token: 0x040001A2 RID: 418
		private global::System.Collections.Generic.List<global::CefSharp.Structs.Rect> compositionBounds = new global::System.Collections.Generic.List<global::CefSharp.Structs.Rect>();

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Interop.HwndSource source;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.Interop.HwndSourceHook sourceHook;

		// Token: 0x040001A5 RID: 421
		private bool hasImeComposition;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Input.MouseButtonEventHandler mouseDownEventHandler;

		// Token: 0x040001A7 RID: 423
		private bool isActive;
	}
}
