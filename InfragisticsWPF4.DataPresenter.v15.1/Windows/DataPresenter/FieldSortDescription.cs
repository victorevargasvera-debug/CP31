using System;
using System.ComponentModel;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000313 RID: 787
	public class FieldSortDescription
	{
		// Token: 0x060025FB RID: 9723 RVA: 0x000A9CA6 File Offset: 0x000A7EA6
		public FieldSortDescription()
		{
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000A9CAE File Offset: 0x000A7EAE
		public FieldSortDescription(string fieldName, global::System.ComponentModel.ListSortDirection direction, bool isGroupBy)
		{
			this._fieldName = fieldName;
			this._direction = direction;
			this._isGroupBy = isGroupBy;
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x000A9CCB File Offset: 0x000A7ECB
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x000A9CD3 File Offset: 0x000A7ED3
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

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x000A9CE2 File Offset: 0x000A7EE2
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x000A9CEA File Offset: 0x000A7EEA
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

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x000A9CF9 File Offset: 0x000A7EF9
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x000A9D15 File Offset: 0x000A7F15
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

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000A9D24 File Offset: 0x000A7F24
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x000A9D2C File Offset: 0x000A7F2C
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

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000A9D3B File Offset: 0x000A7F3B
		public bool IsSealed
		{
			get
			{
				return this._isSealed;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000A9D43 File Offset: 0x000A7F43
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x000A9D4B File Offset: 0x000A7F4B
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

		// Token: 0x06002608 RID: 9736 RVA: 0x000A9D54 File Offset: 0x000A7F54
		internal static bool AreEqual(global::Infragistics.Windows.DataPresenter.FieldSortDescription x, global::Infragistics.Windows.DataPresenter.FieldSortDescription y)
		{
			return x._direction == y._direction && x._field == y._field && x._fieldName == y._fieldName && x._isGroupBy == y._isGroupBy;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000A9DA0 File Offset: 0x000A7FA0
		internal global::Infragistics.Windows.DataPresenter.FieldSortDescription Clone()
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = (global::Infragistics.Windows.DataPresenter.FieldSortDescription)base.MemberwiseClone();
			fieldSortDescription._isSealed = false;
			fieldSortDescription._preSortIndex = 0;
			return fieldSortDescription;
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000A9DC8 File Offset: 0x000A7FC8
		internal global::System.ComponentModel.ListSortDirection GetToggleDirection()
		{
			if (this._direction != global::System.ComponentModel.ListSortDirection.Ascending)
			{
				return global::System.ComponentModel.ListSortDirection.Ascending;
			}
			return global::System.ComponentModel.ListSortDirection.Descending;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000A9DD8 File Offset: 0x000A7FD8
		internal void ToggleDirection()
		{
			global::Infragistics.Windows.Controls.SortStatus sortStatus;
			if (this._direction == global::System.ComponentModel.ListSortDirection.Ascending)
			{
				this._direction = global::System.ComponentModel.ListSortDirection.Descending;
				sortStatus = global::Infragistics.Windows.Controls.SortStatus.Descending;
			}
			else
			{
				this._direction = global::System.ComponentModel.ListSortDirection.Ascending;
				sortStatus = global::Infragistics.Windows.Controls.SortStatus.Ascending;
			}
			if (this._isGroupBy)
			{
				this._field.SortStatusGroupBy = sortStatus;
				return;
			}
			this._field.SortStatus = sortStatus;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000A9E22 File Offset: 0x000A8022
		internal void Seal()
		{
			this._isSealed = true;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000A9E2B File Offset: 0x000A802B
		private void VerifyNotSealed()
		{
			if (this._isSealed)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_22"));
			}
		}

		// Token: 0x040012EA RID: 4842
		private string _fieldName;

		// Token: 0x040012EB RID: 4843
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040012EC RID: 4844
		private global::System.ComponentModel.ListSortDirection _direction;

		// Token: 0x040012ED RID: 4845
		private bool _isGroupBy;

		// Token: 0x040012EE RID: 4846
		private bool _isSealed;

		// Token: 0x040012EF RID: 4847
		private int _preSortIndex;
	}
}
