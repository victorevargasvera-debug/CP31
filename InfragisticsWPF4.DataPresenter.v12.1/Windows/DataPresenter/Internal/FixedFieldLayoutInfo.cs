using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x020002C6 RID: 710
	internal class FixedFieldLayoutInfo
	{
		// Token: 0x060021BD RID: 8637 RVA: 0x00092AE9 File Offset: 0x00090CE9
		internal FixedFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout owner) : this(owner, null)
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00092AF3 File Offset: 0x00090CF3
		internal FixedFieldLayoutInfo(global::Infragistics.Windows.DataPresenter.FieldLayout owner, global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(owner);
			this._owner = owner;
			this._layoutInfo = layoutInfo;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x00092B2C File Offset: 0x00090D2C
		internal int ColumnCount
		{
			get
			{
				this.VerifyFixedInfo();
				return this._columnCount;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00092B3A File Offset: 0x00090D3A
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> FarFixedFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._farFixedFields;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00092B48 File Offset: 0x00090D48
		internal int FarFixedOrigin
		{
			get
			{
				this.VerifyFixedInfo();
				return this._farFixedOrigin;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00092B56 File Offset: 0x00090D56
		internal int FarFixedSpan
		{
			get
			{
				this.VerifyFixedInfo();
				return this._farFixedSpan;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00092B64 File Offset: 0x00090D64
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00092B93 File Offset: 0x00090D93
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00092B9B File Offset: 0x00090D9B
		internal bool HasFixableFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._fixableNearFieldCount > 0 || this._fixableFarFieldCount > 0;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x00092BB7 File Offset: 0x00090DB7
		internal bool HasFixedFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedFields.Count > 0 || this._farFixedFields.Count > 0;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00092BDD File Offset: 0x00090DDD
		internal bool IncludeSplitterElements
		{
			get
			{
				this.VerifyFixedInfo();
				return global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo.IncludeSplitter(this._fixedUIType);
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00092BF0 File Offset: 0x00090DF0
		internal bool IsFarSplitterEnabled
		{
			get
			{
				this.VerifyFixedInfo();
				return this._fixableFarFieldCount > 0 || this._farUnfixableCount > 0;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00092C0C File Offset: 0x00090E0C
		internal bool IsNearSplitterEnabled
		{
			get
			{
				this.VerifyFixedInfo();
				return this._fixableNearFieldCount > 0 || this._nearUnfixableCount > 0;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x00092C28 File Offset: 0x00090E28
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> NearFixedFields
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedFields;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00092C36 File Offset: 0x00090E36
		internal int NearFixedOrigin
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedOrigin;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00092C44 File Offset: 0x00090E44
		internal int NearFixedSpan
		{
			get
			{
				this.VerifyFixedInfo();
				return this._nearFixedSpan;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x00092C52 File Offset: 0x00090E52
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

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00092C81 File Offset: 0x00090E81
		internal int RowCount
		{
			get
			{
				this.VerifyFixedInfo();
				return this._rowCount;
			}
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00092C90 File Offset: 0x00090E90
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

		// Token: 0x060021D0 RID: 8656 RVA: 0x00092D13 File Offset: 0x00090F13
		internal static bool IncludeSplitter(global::Infragistics.Windows.DataPresenter.FixedFieldUIType type)
		{
			return type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.ButtonAndSplitter || type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Splitter;
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00092D20 File Offset: 0x00090F20
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
				int num2 = 0;
				int num3 = 0;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._owner.Fields)
				{
					if (field.IsInLayout)
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
						int num4;
						int num5;
						int num6;
						int num7;
						global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation;
						this.GetFieldInfo(field, out num4, out num5, out num6, out num7, out fixedFieldLocation);
						int num8 = isHorizontal ? num5 : num4;
						int val = num8 + (isHorizontal ? num7 : num6);
						num = global::System.Math.Max(num, val);
						num2 = global::System.Math.Max(num2, num4 + num6);
						num3 = global::System.Math.Max(num3, num5 + num7);
						switch (fixedFieldLocation)
						{
						case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable:
							this._farFixedOrigin = global::System.Math.Max(this._farFixedOrigin, val);
							break;
						case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
							this._nearFixedFields.Add(field);
							this._nearFixedSpan = global::System.Math.Max(this._nearFixedSpan, val);
							this._farFixedOrigin = global::System.Math.Max(this._farFixedOrigin, val);
							if (allowFixingResolved != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.No)
							{
								this._nearUnfixableCount++;
							}
							break;
						case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
							this._farFixedFields.Add(field);
							this._farFixedOrigin = global::System.Math.Min(this._farFixedOrigin, num8);
							if (allowFixingResolved != global::Infragistics.Windows.DataPresenter.AllowFieldFixing.No)
							{
								this._farUnfixableCount++;
							}
							break;
						}
					}
				}
				this._farFixedSpan = num - this._farFixedOrigin;
				this._columnCount = num2;
				this._rowCount = num3;
			}
			this._fixedUIType = this._owner.GetFixedFieldUITypeResolved(this.HasFixedFields, this.HasFixableFields);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00092FC8 File Offset: 0x000911C8
		private void VerifyFixedInfo()
		{
			if (this._verifiedFixedFieldVersion != this._owner.FixedFieldVersion)
			{
				this.UpdateFixedInfo();
			}
		}

		// Token: 0x0400107F RID: 4223
		private global::Infragistics.Windows.DataPresenter.FieldLayout _owner;

		// Token: 0x04001080 RID: 4224
		private int _verifiedFixedFieldVersion = -1;

		// Token: 0x04001081 RID: 4225
		private int _fixableNearFieldCount;

		// Token: 0x04001082 RID: 4226
		private int _fixableFarFieldCount;

		// Token: 0x04001083 RID: 4227
		private global::Infragistics.Windows.DataPresenter.FixedFieldUIType _fixedUIType;

		// Token: 0x04001084 RID: 4228
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _nearFixedFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04001085 RID: 4229
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> _farFixedFields = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04001086 RID: 4230
		private int _nearFixedOrigin;

		// Token: 0x04001087 RID: 4231
		private int _nearFixedSpan;

		// Token: 0x04001088 RID: 4232
		private int _farFixedOrigin;

		// Token: 0x04001089 RID: 4233
		private int _farFixedSpan;

		// Token: 0x0400108A RID: 4234
		private int _rowCount;

		// Token: 0x0400108B RID: 4235
		private int _columnCount;

		// Token: 0x0400108C RID: 4236
		private int _farUnfixableCount;

		// Token: 0x0400108D RID: 4237
		private int _nearUnfixableCount;

		// Token: 0x0400108E RID: 4238
		private global::Infragistics.Windows.DataPresenter.LayoutInfo _layoutInfo;
	}
}
