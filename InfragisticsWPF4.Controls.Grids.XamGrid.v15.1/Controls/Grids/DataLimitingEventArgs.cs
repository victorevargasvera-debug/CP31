using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001B9 RID: 441
	public class DataLimitingEventArgs : global::System.EventArgs
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002A5B3 File Offset: 0x000287B3
		public DataLimitingEventArgs(global::Infragistics.DataAcquisitionEventArgs args)
		{
			this._baseEventArgs = args;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0002A5C2 File Offset: 0x000287C2
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0002A5D9 File Offset: 0x000287D9
		public global::System.Collections.IList DataSource
		{
			get
			{
				if (this._baseEventArgs != null)
				{
					return this._baseEventArgs.DataSource;
				}
				return null;
			}
			set
			{
				this._baseEventArgs.DataSource = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0002A5E7 File Offset: 0x000287E7
		public bool EnablePaging
		{
			get
			{
				return this._baseEventArgs != null && this._baseEventArgs.EnablePaging;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0002A5FE File Offset: 0x000287FE
		public int PageSize
		{
			get
			{
				if (this._baseEventArgs != null)
				{
					return this._baseEventArgs.PageSize;
				}
				return 0;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0002A615 File Offset: 0x00028815
		public int CurrentPage
		{
			get
			{
				if (this._baseEventArgs != null)
				{
					return this._baseEventArgs.CurrentPage;
				}
				return 0;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0002A62C File Offset: 0x0002882C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.SortContext> CurrentSort
		{
			get
			{
				if (this._baseEventArgs != null)
				{
					return this._baseEventArgs.CurrentSort;
				}
				return null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0002A643 File Offset: 0x00028843
		public global::Infragistics.GroupByContext GroupByContext
		{
			get
			{
				if (this._baseEventArgs != null)
				{
					return this._baseEventArgs.GroupByContext;
				}
				return null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0002A65A File Offset: 0x0002885A
		public global::Infragistics.RecordFilterCollection Filters
		{
			get
			{
				if (this._baseEventArgs != null)
				{
					return this._baseEventArgs.Filters;
				}
				return null;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0002A671 File Offset: 0x00028871
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0002A679 File Offset: 0x00028879
		public global::Infragistics.Controls.Grids.Row ParentRow { get; protected internal set; }

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0002A682 File Offset: 0x00028882
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0002A68A File Offset: 0x0002888A
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout { get; protected internal set; }

		// Token: 0x040003E3 RID: 995
		private global::Infragistics.DataAcquisitionEventArgs _baseEventArgs;
	}
}
