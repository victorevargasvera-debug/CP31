using System;
using System.ComponentModel;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D4 RID: 724
	public class FieldSortDescription
	{
		// Token: 0x06002263 RID: 8803 RVA: 0x0009664E File Offset: 0x0009484E
		public FieldSortDescription()
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00096656 File Offset: 0x00094856
		public FieldSortDescription(string fieldName, global::System.ComponentModel.ListSortDirection direction, bool isGroupBy)
		{
			this._fieldName = fieldName;
			this._direction = direction;
			this._isGroupBy = isGroupBy;
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00096673 File Offset: 0x00094873
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x0009667B File Offset: 0x0009487B
		public global::System.ComponentModel.ListSortDirection Direction
		{
			get
			{
				return this._direction;
			}
			set
			{
				this.VerifyNotSealed();
				this._direction = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x0009668A File Offset: 0x0009488A
		// (set) Token: 0x06002268 RID: 8808 RVA: 0x00096692 File Offset: 0x00094892
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
			set
			{
				this.VerifyNotSealed();
				this._field = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x000966A1 File Offset: 0x000948A1
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x000966BD File Offset: 0x000948BD
		public string FieldName
		{
			get
			{
				if (this._field != null)
				{
					return this.Field.Name;
				}
				return this._fieldName;
			}
			set
			{
				this.VerifyNotSealed();
				this._fieldName = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000966CC File Offset: 0x000948CC
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x000966D4 File Offset: 0x000948D4
		public bool IsGroupBy
		{
			get
			{
				return this._isGroupBy;
			}
			set
			{
				this.VerifyNotSealed();
				this._isGroupBy = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000966E3 File Offset: 0x000948E3
		public bool IsSealed
		{
			get
			{
				return this._isSealed;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000966EB File Offset: 0x000948EB
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x000966F3 File Offset: 0x000948F3
		internal int PreSortIndex
		{
			get
			{
				return this._preSortIndex;
			}
			set
			{
				this._preSortIndex = value;
			}
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x000966FC File Offset: 0x000948FC
		internal static bool AreEqual(global::Infragistics.Windows.DataPresenter.FieldSortDescription x, global::Infragistics.Windows.DataPresenter.FieldSortDescription y)
		{
			return x._direction == y._direction && x._field == y._field && x._fieldName == y._fieldName && x._isGroupBy == y._isGroupBy;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00096748 File Offset: 0x00094948
		internal global::Infragistics.Windows.DataPresenter.FieldSortDescription Clone()
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = (global::Infragistics.Windows.DataPresenter.FieldSortDescription)base.MemberwiseClone();
			fieldSortDescription._isSealed = false;
			fieldSortDescription._preSortIndex = 0;
			return fieldSortDescription;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x00096770 File Offset: 0x00094970
		internal global::System.ComponentModel.ListSortDirection GetToggleDirection()
		{
			if (this._direction != global::System.ComponentModel.ListSortDirection.Ascending)
			{
				return global::System.ComponentModel.ListSortDirection.Ascending;
			}
			return global::System.ComponentModel.ListSortDirection.Descending;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0009677D File Offset: 0x0009497D
		internal void ToggleDirection()
		{
			if (this._direction == global::System.ComponentModel.ListSortDirection.Ascending)
			{
				this._direction = global::System.ComponentModel.ListSortDirection.Descending;
				this._field.SetSortingStatus(global::Infragistics.Windows.Controls.SortStatus.Descending, this._isGroupBy);
				return;
			}
			this._direction = global::System.ComponentModel.ListSortDirection.Ascending;
			this._field.SetSortingStatus(global::Infragistics.Windows.Controls.SortStatus.Ascending, this._isGroupBy);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000967BA File Offset: 0x000949BA
		internal void Seal()
		{
			this._isSealed = true;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000967C3 File Offset: 0x000949C3
		private void VerifyNotSealed()
		{
			if (this._isSealed)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_22"));
			}
		}

		// Token: 0x040010D1 RID: 4305
		private string _fieldName;

		// Token: 0x040010D2 RID: 4306
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040010D3 RID: 4307
		private global::System.ComponentModel.ListSortDirection _direction;

		// Token: 0x040010D4 RID: 4308
		private bool _isGroupBy;

		// Token: 0x040010D5 RID: 4309
		private bool _isSealed;

		// Token: 0x040010D6 RID: 4310
		private int _preSortIndex;
	}
}
