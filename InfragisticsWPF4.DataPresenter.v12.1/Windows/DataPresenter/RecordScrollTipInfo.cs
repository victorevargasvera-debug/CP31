using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C0 RID: 448
	public class RecordScrollTipInfo
	{
		// Token: 0x06001A56 RID: 6742 RVA: 0x00072D1F File Offset: 0x00070F1F
		private RecordScrollTipInfo(global::Infragistics.Windows.DataPresenter.Record record, global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> children)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			this._children = children;
			this._record = new global::System.WeakReference(record);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00072D48 File Offset: 0x00070F48
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._record) as global::Infragistics.Windows.DataPresenter.Record;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00072D5A File Offset: 0x00070F5A
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> Children
		{
			get
			{
				return this._children;
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00072D64 File Offset: 0x00070F64
		public static global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo Create(global::Infragistics.Windows.DataPresenter.Record topRecord)
		{
			global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo recordScrollTipInfo = new global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo(topRecord, null);
			while (topRecord.ParentRecord != null)
			{
				topRecord = topRecord.ParentRecord;
				if (topRecord.VisibilityResolved == global::System.Windows.Visibility.Visible && topRecord.OccupiesScrollPosition)
				{
					recordScrollTipInfo = new global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo(topRecord, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo>(new global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo[]
					{
						recordScrollTipInfo
					}));
				}
			}
			return recordScrollTipInfo;
		}

		// Token: 0x04000AE9 RID: 2793
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> _children;

		// Token: 0x04000AEA RID: 2794
		private global::System.WeakReference _record;
	}
}
