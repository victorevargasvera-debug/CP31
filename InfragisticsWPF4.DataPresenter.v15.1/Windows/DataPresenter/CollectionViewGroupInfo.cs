using System;
using System.ComponentModel;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000219 RID: 537
	internal class CollectionViewGroupInfo : global::Infragistics.Windows.DataPresenter.GroupInfo
	{
		// Token: 0x06002028 RID: 8232 RVA: 0x0008BD79 File Offset: 0x00089F79
		public CollectionViewGroupInfo(global::System.Windows.Data.CollectionViewGroup cvg)
		{
			this._cvg = cvg;
			this.HookUnhook(true);
			this.Init();
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0008BD98 File Offset: 0x00089F98
		private void Init()
		{
			base.Value = this._cvg.Name;
			base.ChildDataRecordCount = this._cvg.ItemCount;
			base.ChildGroupCount = (this._cvg.IsBottomLevel ? 0 : this._cvg.Items.Count);
			if (base.GroupByRecord != null)
			{
				base.GroupByRecord.DirtyDescriptionWithSummaries();
			}
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0008BE00 File Offset: 0x0008A000
		private void OnGroupPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.Init();
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0008BE08 File Offset: 0x0008A008
		public global::System.Windows.Data.CollectionViewGroup CollectionViewGroup
		{
			get
			{
				return this._cvg;
			}
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0008BE10 File Offset: 0x0008A010
		internal void Dispose()
		{
			this.HookUnhook(false);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0008BE1C File Offset: 0x0008A01C
		private void HookUnhook(bool hook)
		{
			global::System.ComponentModel.INotifyPropertyChanged cvg = this._cvg;
			if (cvg != null)
			{
				if (hook)
				{
					cvg.PropertyChanged += this.OnGroupPropertyChanged;
					return;
				}
				cvg.PropertyChanged -= this.OnGroupPropertyChanged;
			}
		}

		// Token: 0x04000D86 RID: 3462
		private readonly global::System.Windows.Data.CollectionViewGroup _cvg;
	}
}
