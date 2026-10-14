using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000191 RID: 401
	internal class CPGridBagLayoutManager : global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager, global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x06001954 RID: 6484 RVA: 0x000751FF File Offset: 0x000733FF
		internal CPGridBagLayoutManager(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Size constrainedSize)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
			this._constrainedSize = constrainedSize;
			this._label = new global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem(this, true);
			this._cell = new global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem(this, false);
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00075235 File Offset: 0x00073435
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x0007523D File Offset: 0x0007343D
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00075248 File Offset: 0x00073448
		internal global::System.Windows.Size ConstrainedSize
		{
			get
			{
				return this._constrainedSize;
			}
			set
			{
				if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(this._constrainedSize.Width, value.Width) || !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(this._constrainedSize.Height, value.Height))
				{
					this._constrainedSize = value;
					this.InvalidateLayout();
				}
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00075294 File Offset: 0x00073494
		internal global::System.Windows.Rect CellRect
		{
			get
			{
				return this._cellRect;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x0007529C File Offset: 0x0007349C
		internal global::System.Windows.Rect LabelRect
		{
			get
			{
				return this._labelRect;
			}
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000752A4 File Offset: 0x000734A4
		internal void Initialize(global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase cp, global::System.Windows.Rect availableRect, global::System.Windows.Rect preferredCellRect, global::System.Windows.Rect preferredLabelRect)
		{
			this._cp = cp;
			base.LayoutItems.Clear();
			if (cp != null)
			{
				this._label.PreferredRect = preferredLabelRect;
				this._cell.PreferredRect = preferredCellRect;
				base.LayoutItems.Add(this._label, this._label);
				base.LayoutItems.Add(this._cell, this._cell);
				if (this._field.Owner != null)
				{
					this._field.Owner.CellLayoutManager.VerifyLayout();
				}
				global::System.Windows.Size size = this.CalculatePreferredSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, availableRect);
				if (double.IsPositiveInfinity(availableRect.Width))
				{
					availableRect.Width = size.Width;
				}
				if (double.IsPositiveInfinity(availableRect.Height))
				{
					availableRect.Height = size.Height;
				}
				this.LayoutContainer(this, availableRect);
				return;
			}
			global::System.Windows.Rect labelRect = default(global::System.Windows.Rect);
			this._labelRect = labelRect;
			this._cellRect = (this._labelRect = labelRect);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000753A9 File Offset: 0x000735A9
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x000753B1 File Offset: 0x000735B1
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
			if (item == this._cell)
			{
				this._cellRect = rect;
				return;
			}
			this._labelRect = rect;
		}

		// Token: 0x04000A5F RID: 2655
		private global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase _cp;

		// Token: 0x04000A60 RID: 2656
		private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem _label;

		// Token: 0x04000A61 RID: 2657
		private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem _cell;

		// Token: 0x04000A62 RID: 2658
		private global::System.Windows.Rect _cellRect;

		// Token: 0x04000A63 RID: 2659
		private global::System.Windows.Rect _labelRect;

		// Token: 0x04000A64 RID: 2660
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000A65 RID: 2661
		private global::System.Windows.Size _constrainedSize;

		// Token: 0x02000192 RID: 402
		private class CPLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
		{
			// Token: 0x0600195D RID: 6493 RVA: 0x000753CB File Offset: 0x000735CB
			internal CPLayoutItem(global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager owner, bool isLabel)
			{
				this._owner = owner;
				this._isLabel = isLabel;
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x0600195E RID: 6494 RVA: 0x000753E4 File Offset: 0x000735E4
			private global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint BaseConstraint
			{
				get
				{
					global::Infragistics.Windows.DataPresenter.Field field = this._owner.Field;
					if (!this._isLabel)
					{
						return field.CellLayoutItem;
					}
					return field.LabelLayoutItem;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x0600195F RID: 6495 RVA: 0x00075414 File Offset: 0x00073614
			private global::Infragistics.Controls.Layouts.Primitives.ILayoutItem BaseLayoutItem
			{
				get
				{
					global::Infragistics.Windows.DataPresenter.Field field = this._owner.Field;
					if (!this._isLabel)
					{
						return field.CellLayoutItem;
					}
					return field.LabelLayoutItem;
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x06001960 RID: 6496 RVA: 0x00075442 File Offset: 0x00073642
			private global::System.Windows.FrameworkElement Element
			{
				get
				{
					if (this._owner._cp == null)
					{
						return null;
					}
					if (!this._isLabel)
					{
						return this._owner._cp.CellValuePresenter;
					}
					return this._owner._cp.LabelPresenter;
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x06001961 RID: 6497 RVA: 0x0007547C File Offset: 0x0007367C
			// (set) Token: 0x06001962 RID: 6498 RVA: 0x00075484 File Offset: 0x00073684
			internal global::System.Windows.Rect PreferredRect
			{
				get
				{
					return this._preferredRect;
				}
				set
				{
					this._preferredRect = value;
				}
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x06001963 RID: 6499 RVA: 0x0007548D File Offset: 0x0007368D
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this.BaseLayoutItem.MaximumSize;
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06001964 RID: 6500 RVA: 0x0007549A File Offset: 0x0007369A
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this.BaseLayoutItem.MinimumSize;
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06001965 RID: 6501 RVA: 0x000754A8 File Offset: 0x000736A8
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.PreferredSize
			{
				get
				{
					if (!this._preferredRect.IsEmpty)
					{
						return this._preferredRect.Size;
					}
					global::System.Windows.FrameworkElement element = this.Element;
					if (element == null)
					{
						return default(global::System.Windows.Size);
					}
					global::System.Windows.Size constrainedSize = this._owner.ConstrainedSize;
					if (this._isLabel && this._owner._cp.Record is global::Infragistics.Windows.DataPresenter.TemplateDataRecord)
					{
						double labelWidthResolvedHelper = this._owner._field.GetLabelWidthResolvedHelper(false, false);
						if (!double.IsNaN(labelWidthResolvedHelper))
						{
							constrainedSize.Width = labelWidthResolvedHelper;
						}
					}
					element.Measure(constrainedSize);
					return element.DesiredSize;
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06001966 RID: 6502 RVA: 0x0007553D File Offset: 0x0007373D
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return this.BaseLayoutItem.Visibility;
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x06001967 RID: 6503 RVA: 0x0007554A File Offset: 0x0007374A
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					return this.BaseConstraint.Column;
				}
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x06001968 RID: 6504 RVA: 0x00075557 File Offset: 0x00073757
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return this.BaseConstraint.ColumnSpan;
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06001969 RID: 6505 RVA: 0x00075564 File Offset: 0x00073764
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return this.BaseConstraint.ColumnWeight;
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x0600196A RID: 6506 RVA: 0x00075571 File Offset: 0x00073771
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					return this.BaseConstraint.HorizontalAlignment;
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x0600196B RID: 6507 RVA: 0x00075580 File Offset: 0x00073780
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x0600196C RID: 6508 RVA: 0x00075596 File Offset: 0x00073796
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					return this.BaseConstraint.Row;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x0600196D RID: 6509 RVA: 0x000755A3 File Offset: 0x000737A3
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return this.BaseConstraint.RowSpan;
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x0600196E RID: 6510 RVA: 0x000755B0 File Offset: 0x000737B0
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return this.BaseConstraint.RowWeight;
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x0600196F RID: 6511 RVA: 0x000755BD File Offset: 0x000737BD
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					return this.BaseConstraint.VerticalAlignment;
				}
			}

			// Token: 0x04000A66 RID: 2662
			private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager _owner;

			// Token: 0x04000A67 RID: 2663
			private bool _isLabel;

			// Token: 0x04000A68 RID: 2664
			private global::System.Windows.Rect _preferredRect;
		}
	}
}
