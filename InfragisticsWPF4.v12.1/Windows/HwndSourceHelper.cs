using System;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Interop;
using Infragistics.Collections;

namespace Infragistics.Windows
{
	// Token: 0x02000172 RID: 370
	internal class HwndSourceHelper
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x000286CC File Offset: 0x000268CC
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

		// Token: 0x06000C7B RID: 3195 RVA: 0x00028720 File Offset: 0x00026920
		private void OnElementSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			global::System.Windows.UIElement element = sender as global::System.Windows.UIElement;
			this.RemoveElementFromSource(element, e.OldSource as global::System.Windows.Interop.HwndSource);
			this.AddElementToSource(element, e.NewSource as global::System.Windows.Interop.HwndSource);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00028758 File Offset: 0x00026958
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

		// Token: 0x06000C7D RID: 3197 RVA: 0x000287A8 File Offset: 0x000269A8
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

		// Token: 0x06000C7E RID: 3198 RVA: 0x000287E0 File Offset: 0x000269E0
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

		// Token: 0x06000C7F RID: 3199 RVA: 0x00028840 File Offset: 0x00026A40
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

		// Token: 0x040005AE RID: 1454
		private global::Infragistics.Collections.WeakDictionary<global::System.Windows.Interop.HwndSource, global::Infragistics.Windows.HwndSourceHelper.HwndSourceWrapper> _sourceElements;

		// Token: 0x040005AF RID: 1455
		private global::Infragistics.Collections.WeakList<global::System.Windows.UIElement> _noSourceList;

		// Token: 0x040005B0 RID: 1456
		private global::Infragistics.Collections.WeakDictionary<global::System.Windows.UIElement, int> _elementRefCount;

		// Token: 0x040005B1 RID: 1457
		private global::System.Windows.Interop.HwndSourceHook _hook;

		// Token: 0x040005B2 RID: 1458
		private static global::System.Security.Permissions.UIPermission _permission = new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.UIPermissionWindow.AllWindows);

		// Token: 0x02000173 RID: 371
		private class HwndSourceWrapper
		{
			// Token: 0x06000C81 RID: 3201 RVA: 0x000288BD File Offset: 0x00026ABD
			internal HwndSourceWrapper(global::System.Windows.Interop.HwndSource hs, global::System.Windows.Interop.HwndSourceHook hook)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(hs);
				global::Infragistics.CoreUtilities.ValidateNotNull(hook);
				this._hs = new global::System.WeakReference(hs);
				this._hook = hook;
				this._elementList = new global::Infragistics.Collections.WeakList<global::System.Windows.UIElement>();
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x000288EF File Offset: 0x00026AEF
			public void AddElement(global::System.Windows.UIElement element)
			{
				this._elementList.Add(element);
				this._elementList.Compact();
				this.VerifyIsEnabled();
			}

			// Token: 0x06000C83 RID: 3203 RVA: 0x0002890F File Offset: 0x00026B0F
			public void RemoveElement(global::System.Windows.UIElement element)
			{
				this._elementList.Remove(element);
				this._elementList.Compact();
				this.VerifyIsEnabled();
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x00028930 File Offset: 0x00026B30
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

			// Token: 0x040005B3 RID: 1459
			private global::System.WeakReference _hs;

			// Token: 0x040005B4 RID: 1460
			private global::System.Windows.Interop.HwndSourceHook _hook;

			// Token: 0x040005B5 RID: 1461
			private global::Infragistics.Collections.WeakList<global::System.Windows.UIElement> _elementList;

			// Token: 0x040005B6 RID: 1462
			private bool _isEnabled;
		}
	}
}
