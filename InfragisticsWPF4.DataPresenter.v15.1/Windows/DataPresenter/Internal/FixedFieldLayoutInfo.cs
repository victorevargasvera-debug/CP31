using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000305 RID: 773
	internal class FixedFieldLayoutInfo
	{
		// Token: 0x0600254F RID: 9551 RVA: 0x000A5B35 File Offset: 0x000A3D35
		internal FixedFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout owner) : this(owner, null)
		{
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000A5B3F File Offset: 0x000A3D3F
		internal FixedFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout owner, global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(owner);
			this._owner = owner;
			this._layoutInfo = layoutInfo;
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000A5B78 File Offset: 0x000A3D78
		internal int ColumnCount
		{
			get
			{
				this.VerifyFixedInfo();
				return this._columnCount;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x000A5B86 File Offset: 0x000A3D86
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> FarFixedFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._farFixedFields;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x000A5B94 File Offset: 0x000A3D94
		internal int FarFixedOrigin
		{
			get
			{
				this.VerifyFixedInfo();
				return this._farFixedOrigin;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000A5BA2 File Offset: 0x000A3DA2
		internal int FarFixedSpan
		{
			get
			{
				this.VerifyFixedInfo();
				return this._farFixedSpan;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000A5BB0 File Offset: 0x000A3DB0
		internal global::System.Windows.Visibility FarSplitterVisibility
		{
			get
			{
				this.VerifyFixedInfo();
				if ((this._fixableFarFieldCount <= 0 && this._farFixedFields.Count <= 0) || !global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo.IncludeSplitter(this._fixedUIType))
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000A5BDF File Offset: 0x000A3DDF
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000A5BE7 File Offset: 0x000A3DE7
		internal bool HasFixableFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._fixableNearFieldCount > 0 || this._fixableFarFieldCount > 0;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000A5C03 File Offset: 0x000A3E03
		internal bool HasFixedFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedFields.Count > 0 || this._farFixedFields.Count > 0;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000A5C29 File Offset: 0x000A3E29
		internal bool IncludeSplitterElements
		{
			get
			{
				this.VerifyFixedInfo();
				return global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo.IncludeSplitter(this._fixedUIType);
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000A5C3C File Offset: 0x000A3E3C
		internal bool IsFarSplitterEnabled
		{
			get
			{
				this.VerifyFixedInfo();
				return this._fixableFarFieldCount > 0 || this._farUnfixableCount > 0;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x000A5C58 File Offset: 0x000A3E58
		internal bool IsNearSplitterEnabled
		{
			get
			{
				this.VerifyFixedInfo();
				return this._fixableNearFieldCount > 0 || this._nearUnfixableCount > 0;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000A5C74 File Offset: 0x000A3E74
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> NearFixedFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedFields;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x000A5C82 File Offset: 0x000A3E82
		internal int NearFixedOrigin
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedOrigin;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000A5C90 File Offset: 0x000A3E90
		internal int NearFixedSpan
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedSpan;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x000A5C9E File Offset: 0x000A3E9E
		internal global::System.Windows.Visibility NearSplitterVisibility
		{
			get
			{
				this.VerifyFixedInfo();
				if ((this._fixableNearFieldCount <= 0 && this._nearFixedFields.Count <= 0) || !global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo.IncludeSplitter(this._fixedUIType))
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000A5CCD File Offset: 0x000A3ECD
		internal int RowCount
		{
			get
			{
				this.VerifyFixedInfo();
				return this._rowCount;
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000A5CDC File Offset: 0x000A3EDC
		internal void FlipFieldPositions()
		{
			if (this._layoutInfo != null)
			{
				this._layoutInfo.FlipFieldPositions();
			}
			int rowCount = this._rowCount;
			this._rowCount = this._columnCount;
			this._columnCount = rowCount;
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000A5D18 File Offset: 0x000A3F18
		private void GetFieldInfo(global::Infragistics.Windows.DataPresenter.Field field, out int column, out int row, out int columnSpan, out int rowSpan, out global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation)
		{
			if (this._layoutInfo != null)
			{
				global::Infragistics.Windows.DataPresenter.ItemLayoutInfo itemLayoutInfo = this._layoutInfo[field];
				if (itemLayoutInfo != null)
				{
					column = itemLayoutInfo.Column;
					row = itemLayoutInfo.Row;
					columnSpan = itemLayoutInfo.ColumnSpan;
					rowSpan = itemLayoutInfo.RowSpan;
					fixedLocation = itemLayoutInfo._fixedLocation;
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.GridBagConstraint layoutConstraint = field.LayoutConstraint;
			column = layoutConstraint.Column;
			columnSpan = layoutConstraint.ColumnSpan;
			row = layoutConstraint.Row;
			rowSpan = layoutConstraint.RowSpan;
			fixedLocation = field.FixedLocation;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000A5D9B File Offset: 0x000A3F9B
		internal static bool IncludeSplitter(global::Infragistics.Windows.DataPresenter.FixedFieldUIType type)
		{
			return type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.ButtonAndSplitter || type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Splitter;
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
		private void UpdateFixedInfo()
		{
			this._verifiedFixedFieldVersion = this._owner.FixedFieldVersion;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._owner.DataPresenter;
			this._fixableNearFieldCount = 0;
			this._fixableFarFieldCount = 0;
			this._nearFixedFields.Clear();
			this._farFixedFields.Clear();
			this._nearFixedOrigin = (this._nearFixedSpan = 0);
			this._farFixedOrigin = (this._farFixedSpan = 0);
			this._columnCount = 0;
			this._rowCount = 0;
			this._farUnfixableCount = 0;
			this._nearUnfixableCount = 0;
			if (dataPresenter != null && dataPresenter.IsFixedFieldsSupportedResolved)
			{
				bool isHorizontal = this._owner.IsHorizontal;
				int num = 0;
				int columnCount = 0;
				int rowCount = 0;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._owner.Fields)
				{
					if (field.IsInLayout)
					{
						this.UpdateFixedInfoHelper(isHorizontal, ref num, ref columnCount, ref rowCount, field);
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = this._owner.AlignmentFieldLayout;
				if (alignmentFieldLayout != null && this._owner.PlaceholderFields != null)
				{
					foreach (global::Infragistics.Windows.DataPresenter.PlaceholderField field2 in this._owner.PlaceholderFields)
					{
						if (field2.IsInLayout)
						{
							this.UpdateFixedInfoHelper(isHorizontal, ref num, ref columnCount, ref rowCount, field2);
						}
					}
				}
				this._farFixedSpan = num - this._farFixedOrigin;
				this._columnCount = columnCount;
				this._rowCount = rowCount;
			}
			this._fixedUIType = this._owner.GetFixedFieldUITypeResolved(this.HasFixedFields, this.HasFixableFields);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000A5F50 File Offset: 0x000A4150
		private void UpdateFixedInfoHelper(bool isHorizontal, ref int maxFieldEnd, ref int colCount, ref int rowCount, global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.AllowFieldFixing allowFixingResolved = field.AllowFixingResolved;
			switch (allowFixingResolved)
			{
			case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Near:
				this._fixableNearFieldCount++;
				break;
			case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.Far:
				this._fixableFarFieldCount++;
				break;
			case global::Infragistics.Windows.DataPresenter.AllowFieldFixing.NearOrFar:
				this._fixableNearFieldCount++;
				this._fixableFarFieldCount++;
				break;
			}
			int num;
			int num2;
			int num3;
			int num4;
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation;
			this.GetFieldInfo(field, out num, out num2, out num3, out num4, out fixedFieldLocation);
			int num5 = isHorizontal ? num2 : num;
			int val = num5 + (isHorizontal ? num4 : num3);
			maxFieldEnd = global::System.Math.Max(maxFieldEnd, val);
			colCount = global::System.Math.Max(colCount, num + num3);
			rowCount = global::System.Math.Max(rowCount, num2 + num4);
			switch (fixedFieldLocation)
			{
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable:
				this._farFixedOrigin = global::System.Math.Max(this._farFixedOrigin, val);
				return;
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
				this._nearFixedFields.Add(field);
				this._nearFixedSpan = global::System.Math.Max(this._nearFixedSpan, val);
				this._farFixedOrigin = global::System.Math.Max(this._farFixedOrigin, val);
				if (allowFixingResolved != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.No)
				{
					this._nearUnfixableCount++;
					return;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
				this._farFixedFields.Add(field);
				this._farFixedOrigin = global::System.Math.Min(this._farFixedOrigin, num5);
				if (allowFixingResolved != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.No)
				{
					this._farUnfixableCount++;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000A60AD File Offset: 0x000A42AD
		private void VerifyFixedInfo()
		{
			if (this._verifiedFixedFieldVersion != this._owner.FixedFieldVersion)
			{
				this.UpdateFixedInfo();
			}
		}

		// Token: 0x04001292 RID: 4754
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x04001293 RID: 4755
		private int _verifiedFixedFieldVersion = -1;

		// Token: 0x04001294 RID: 4756
		private int _fixableNearFieldCount;

		// Token: 0x04001295 RID: 4757
		private int _fixableFarFieldCount;

		// Token: 0x04001296 RID: 4758
		private global::Infragistics.Windows.DataPresenter.FixedFieldUIType _fixedUIType;

		// Token: 0x04001297 RID: 4759
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _nearFixedFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04001298 RID: 4760
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _farFixedFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04001299 RID: 4761
		private int _nearFixedOrigin;

		// Token: 0x0400129A RID: 4762
		private int _nearFixedSpan;

		// Token: 0x0400129B RID: 4763
		private int _farFixedOrigin;

		// Token: 0x0400129C RID: 4764
		private int _farFixedSpan;

		// Token: 0x0400129D RID: 4765
		private int _rowCount;

		// Token: 0x0400129E RID: 4766
		private int _columnCount;

		// Token: 0x0400129F RID: 4767
		private int _farUnfixableCount;

		// Token: 0x040012A0 RID: 4768
		private int _nearUnfixableCount;

		// Token: 0x040012A1 RID: 4769
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;
	}
}
