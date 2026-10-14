using System;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Interop;
using Infragistics.Collections;

namespace Infragistics.Windows
{
	// Token: 0x02000194 RID: 404
	internal class HwndSourceHelper
	{
		// Token: 0x06000D8F RID: 3471 RVA: 0x0002C854 File Offset: 0x0002AA54
		[global::System.Security.SecurityCritical]
		public HwndSourceHelper(global::System.Windows.Interop.HwndSourceHook hook)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(hook, "hook");
			global::Infragistics.Windows.HwndSourceHelper._permission.Demand();
			this._hook = hook;
			this._sourceElements = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.Interop.HwndSource, global::Infragistics.Windows.HwndSourceHelper.HwndSourceWrapper>(true, false);
			this._noSourceList = new global::Infragistics.Collections.WeakList<global::System.Windows.UIElement>();
			this._elementRefCount = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.UIElement, int>(true, false);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		private void OnElementSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			global::System.Windows.UIElement element = sender as global::System.Windows.UIElement;
			this.RemoveElementFromSource(element, e.OldSource as global::System.Windows.Interop.HwndSource);
			this.AddElementToSource(element, e.NewSource as global::System.Windows.Interop.HwndSource);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		private void AddElementToSource(global::System.Windows.UIElement element, global::System.Windows.Interop.HwndSource source)
		{
			if (source == null)
			{
				this._noSourceList.Add(element);
				return;
			}
			global::Infragistics.Windows.HwndSourceHelper.HwndSourceWrapper hwndSourceWrapper;
			if (!this._sourceElements.TryGetValue(source, out hwndSourceWrapper))
			{
				hwndSourceWrapper = (this._sourceElements[source] = new global::Infragistics.Windows.HwndSourceHelper.HwndSourceWrapper(source, this._hook));
			}
			hwndSourceWrapper.AddElement(element);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0002C930 File Offset: 0x0002AB30
		private void RemoveElementFromSource(global::System.Windows.UIElement element, global::System.Windows.Interop.HwndSource source)
		{
			if (source == null)
			{
				this._noSourceList.Remove(element);
				return;
			}
			global::Infragistics.Windows.HwndSourceHelper.HwndSourceWrapper hwndSourceWrapper;
			if (this._sourceElements.TryGetValue(source, out hwndSourceWrapper))
			{
				hwndSourceWrapper.RemoveElement(element);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0002C968 File Offset: 0x0002AB68
		public void AddElement(global::System.Windows.UIElement element)
		{
			int num;
			if (!this._elementRefCount.TryGetValue(element, out num) || num == 0)
			{
				global::System.Windows.PresentationSource.AddSourceChangedHandler(element, new global::System.Windows.SourceChangedEventHandler(this.OnElementSourceChanged));
				this.AddElementToSource(element, global::System.Windows.PresentationSource.FromVisual(element) as global::System.Windows.Interop.HwndSource);
			}
			this._elementRefCount[element] = num + 1;
			this._elementRefCount.Compact(true);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
		public void RemoveElement(global::System.Windows.UIElement element)
		{
			int num;
			if (!this._elementRefCount.TryGetValue(element, out num))
			{
				return;
			}
			if (num == 1)
			{
				global::System.Windows.PresentationSource.RemoveSourceChangedHandler(element, new global::System.Windows.SourceChangedEventHandler(this.OnElementSourceChanged));
				this._elementRefCount.Remove(element);
				this.RemoveElementFromSource(element, global::System.Windows.PresentationSource.FromVisual(element) as global::System.Windows.Interop.HwndSource);
			}
			else
			{
				this._elementRefCount[element] = num - 1;
			}
			this._elementRefCount.Compact(true);
		}

		// Token: 0x04000673 RID: 1651
		private global::Infragistics.Collections.WeakDictionary<global::System.Windows.Interop.HwndSource, global::Infragistics.Windows.HwndSourceHelper.HwndSourceWrapper> _sourceElements;

		// Token: 0x04000674 RID: 1652
		private global::Infragistics.Collections.WeakList<global::System.Windows.UIElement> _noSourceList;

		// Token: 0x04000675 RID: 1653
		private global::Infragistics.Collections.WeakDictionary<global::System.Windows.UIElement, int> _elementRefCount;

		// Token: 0x04000676 RID: 1654
		private global::System.Windows.Interop.HwndSourceHook _hook;

		// Token: 0x04000677 RID: 1655
		private static global::System.Security.Permissions.UIPermission _permission = new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.UIPermissionWindow.AllWindows);

		// Token: 0x02000195 RID: 405
		private class HwndSourceWrapper
		{
			// Token: 0x06000D96 RID: 3478 RVA: 0x0002CA45 File Offset: 0x0002AC45
			internal HwndSourceWrapper(global::System.Windows.Interop.HwndSource hs, global::System.Windows.Interop.HwndSourceHook hook)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(hs);
				global::Infragistics.CoreUtilities.ValidateNotNull(hook);
				this._hs = new global::System.WeakReference(hs);
				this._hook = hook;
				this._elementList = new global::Infragistics.Collections.WeakList<global::System.Windows.UIElement>();
			}

			// Token: 0x06000D97 RID: 3479 RVA: 0x0002CA77 File Offset: 0x0002AC77
			public void AddElement(global::System.Windows.UIElement element)
			{
				this._elementList.Add(element);
				this._elementList.Compact();
				this.VerifyIsEnabled();
			}

			// Token: 0x06000D98 RID: 3480 RVA: 0x0002CA97 File Offset: 0x0002AC97
			public void RemoveElement(global::System.Windows.UIElement element)
			{
				this._elementList.Remove(element);
				this._elementList.Compact();
				this.VerifyIsEnabled();
			}

			// Token: 0x06000D99 RID: 3481 RVA: 0x0002CAB8 File Offset: 0x0002ACB8
			private void VerifyIsEnabled()
			{
				bool flag = this._elementList.Count > 0;
				if (this._isEnabled != flag)
				{
					global::System.Windows.Interop.HwndSource hwndSource = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._hs) as global::System.Windows.Interop.HwndSource;
					if (hwndSource == null)
					{
						return;
					}
					if (hwndSource.IsDisposed && flag)
					{
						return;
					}
					this._isEnabled = flag;
					if (flag)
					{
						hwndSource.AddHook(this._hook);
						return;
					}
					hwndSource.RemoveHook(this._hook);
				}
			}

			// Token: 0x04000678 RID: 1656
			private global::System.WeakReference _hs;

			// Token: 0x04000679 RID: 1657
			private global::System.Windows.Interop.HwndSourceHook _hook;

			// Token: 0x0400067A RID: 1658
			private global::Infragistics.Collections.WeakList<global::System.Windows.UIElement> _elementList;

			// Token: 0x0400067B RID: 1659
			private bool _isEnabled;
		}
	}
}
