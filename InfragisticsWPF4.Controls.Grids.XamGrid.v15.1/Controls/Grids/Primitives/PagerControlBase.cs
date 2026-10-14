using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200010E RID: 270
	public abstract class PagerControlBase : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x000245DD File Offset: 0x000227DD
		protected PagerControlBase()
		{
			base.DataContext = this;
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x000245EC File Offset: 0x000227EC
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x000245F4 File Offset: 0x000227F4
		public int CurrentPageIndex
		{
			get
			{
				return this._currentPageIndex;
			}
			set
			{
				this._currentPageIndex = value;
				this.EnsureContent();
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00024603 File Offset: 0x00022803
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00024615 File Offset: 0x00022815
		public int TotalPages
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.Primitives.PagerControlBase.TotalPagesProperty);
			}
			protected internal set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.PagerControlBase.TotalPagesProperty, value);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00024628 File Offset: 0x00022828
		private static void TotalPagesPropertyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.PagerControl pagerControl = (global::Infragistics.Controls.Grids.Primitives.PagerControl)obj;
			pagerControl.EnsureContent();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00024642 File Offset: 0x00022842
		protected internal void SetCurrentPageIndexSilent(int value)
		{
			this._currentPageIndex = value;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002464B File Offset: 0x0002284B
		protected internal void SetRowsManagerMaximumPagesSilent(int value)
		{
			this.TotalPages = value;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00024654 File Offset: 0x00022854
		protected internal virtual void EnsureContent()
		{
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00024658 File Offset: 0x00022858
		protected virtual void CheckButtonState()
		{
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.FirstPageControlCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.NextPageControlCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.PreviousPageControlCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.LastPageControlCommand));
			global::Infragistics.CommandSourceManager.NotifyCanExecuteChanged(typeof(global::Infragistics.Controls.Grids.Primitives.GoToPageControlCommand));
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000246B0 File Offset: 0x000228B0
		protected internal virtual void InvalidateItems()
		{
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600091D RID: 2333 RVA: 0x000246B4 File Offset: 0x000228B4
		// (remove) Token: 0x0600091E RID: 2334 RVA: 0x000246EC File Offset: 0x000228EC
		public event global::System.EventHandler FirstPage;

		// Token: 0x0600091F RID: 2335 RVA: 0x00024721 File Offset: 0x00022921
		protected internal virtual void OnFirstPage()
		{
			if (this.FirstPage != null)
			{
				this.FirstPage(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000920 RID: 2336 RVA: 0x0002473C File Offset: 0x0002293C
		// (remove) Token: 0x06000921 RID: 2337 RVA: 0x00024774 File Offset: 0x00022974
		public event global::System.EventHandler LastPage;

		// Token: 0x06000922 RID: 2338 RVA: 0x000247A9 File Offset: 0x000229A9
		protected internal virtual void OnLastPage()
		{
			if (this.LastPage != null)
			{
				this.LastPage(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000923 RID: 2339 RVA: 0x000247C4 File Offset: 0x000229C4
		// (remove) Token: 0x06000924 RID: 2340 RVA: 0x000247FC File Offset: 0x000229FC
		public event global::System.EventHandler PreviousPage;

		// Token: 0x06000925 RID: 2341 RVA: 0x00024831 File Offset: 0x00022A31
		protected internal virtual void OnPreviousPage()
		{
			if (this.PreviousPage != null)
			{
				this.PreviousPage(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000926 RID: 2342 RVA: 0x0002484C File Offset: 0x00022A4C
		// (remove) Token: 0x06000927 RID: 2343 RVA: 0x00024884 File Offset: 0x00022A84
		public event global::System.EventHandler NextPage;

		// Token: 0x06000928 RID: 2344 RVA: 0x000248B9 File Offset: 0x00022AB9
		protected internal virtual void OnNextPage()
		{
			if (this.NextPage != null)
			{
				this.NextPage(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000929 RID: 2345 RVA: 0x000248D4 File Offset: 0x00022AD4
		// (remove) Token: 0x0600092A RID: 2346 RVA: 0x0002490C File Offset: 0x00022B0C
		public event global::System.EventHandler GoToPage;

		// Token: 0x0600092B RID: 2347 RVA: 0x00024944 File Offset: 0x00022B44
		protected internal virtual void OnGoToPage(int nextPage)
		{
			if (this.GoToPage != null)
			{
				this.GoToPage(this, new global::Infragistics.Controls.Grids.Primitives.PagingEventArgs
				{
					NextPage = nextPage
				});
			}
		}

		// Token: 0x04000243 RID: 579
		private int _currentPageIndex;

		// Token: 0x04000244 RID: 580
		public static readonly global::System.Windows.DependencyProperty TotalPagesProperty = global::System.Windows.DependencyProperty.Register("TotalPages", typeof(int), typeof(global::Infragistics.Controls.Grids.Primitives.PagerControlBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.PagerControlBase.TotalPagesPropertyChanged)));
	}
}
