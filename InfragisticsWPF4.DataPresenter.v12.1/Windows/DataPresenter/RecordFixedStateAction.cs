using System;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000078 RID: 120
	internal class RecordFixedStateAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00017B86 File Offset: 0x00015D86
		internal RecordFixedStateAction(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> records, global::Infragistics.Windows.DataPresenter.FixedRecordLocation location) : base(records[0].DataPresenter)
		{
			this._fl = records[0].FieldLayout;
			this._records = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.Record>(records);
			this._location = location;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00017BC0 File Offset: 0x00015DC0
		protected internal override bool CanPerform(object context)
		{
			global::Infragistics.Windows.DataPresenter.Record[] records = this._records;
			int i = 0;
			while (i < records.Length)
			{
				global::Infragistics.Windows.DataPresenter.Record record = records[i];
				bool result;
				if (!record.IsStillValid)
				{
					result = false;
				}
				else
				{
					if (record.IsFixedLocationAllowed(this._location))
					{
						i++;
						continue;
					}
					result = false;
				}
				return result;
			}
			return true;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00017C08 File Offset: 0x00015E08
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			foreach (global::Infragistics.Windows.DataPresenter.Record record in this._records)
			{
				global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs recordFixedLocationChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs(record, this._location);
				dataPresenter.RaiseRecordFixedLocationChanging(recordFixedLocationChangingEventArgs);
				if (recordFixedLocationChangingEventArgs.Cancel)
				{
					return null;
				}
			}
			global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedLocation = this._records[0].FixedLocation;
			foreach (global::Infragistics.Windows.DataPresenter.Record record2 in this._records)
			{
				global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedLocation2 = record2.FixedLocation;
				if (fixedLocation2 != fixedLocation)
				{
					return null;
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordFixedStateAction result = new global::Infragistics.Windows.DataPresenter.RecordFixedStateAction(this._records, fixedLocation);
			foreach (global::Infragistics.Windows.DataPresenter.Record record3 in this._records)
			{
				record3.FixedLocation = this._location;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Record record4 in this._records)
			{
				dataPresenter.RaiseRecordFixedLocationChanged(new global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs(record4));
			}
			return result;
		}

		// Token: 0x040001CB RID: 459
		private global::Infragistics.Windows.DataPresenter.Record[] _records;

		// Token: 0x040001CC RID: 460
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fl;

		// Token: 0x040001CD RID: 461
		private global::Infragistics.Windows.DataPresenter.FixedRecordLocation _location;
	}
}
