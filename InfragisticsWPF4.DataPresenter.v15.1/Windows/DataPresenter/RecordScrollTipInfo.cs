using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E7 RID: 487
	public class RecordScrollTipInfo
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x0008696F File Offset: 0x00084B6F
		private RecordScrollTipInfo(global::Infragistics.Windows.DataPresenter.Record record, global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> children)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			this._children = children;
			this._record = new global::System.WeakReference(record);
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00086998 File Offset: 0x00084B98
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._record) as global::Infragistics.Windows.DataPresenter.Record;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000869AA File Offset: 0x00084BAA
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> Children
		{
			get
			{
				return this._children;
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000869B4 File Offset: 0x00084BB4
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

		// Token: 0x04000CD3 RID: 3283
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.RecordScrollTipInfo> _children;

		// Token: 0x04000CD4 RID: 3284
		private global::System.WeakReference _record;
	}
}
