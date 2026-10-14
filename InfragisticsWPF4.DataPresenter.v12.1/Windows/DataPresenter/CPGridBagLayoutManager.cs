using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000175 RID: 373
	internal class CPGridBagLayoutManager : global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutManager, global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x060015D0 RID: 5584 RVA: 0x00062F4F File Offset: 0x0006114F
		internal CPGridBagLayoutManager(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Size constrainedSize)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field);
			this._field = field;
			this._constrainedSize = constrainedSize;
			this._label = new global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem(this, true);
			this._cell = new global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem(this, false);
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00062F85 File Offset: 0x00061185
		internal global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00062F8D File Offset: 0x0006118D
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x00062F98 File Offset: 0x00061198
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00062FE4 File Offset: 0x000611E4
		internal global::System.Windows.Rect CellRect
		{
			get
			{
				return this._cellRect;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00062FEC File Offset: 0x000611EC
		internal global::System.Windows.Rect LabelRect
		{
			get
			{
				return this._labelRect;
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00062FF4 File Offset: 0x000611F4
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

		// Token: 0x060015D7 RID: 5591 RVA: 0x000630F9 File Offset: 0x000612F9
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00063101 File Offset: 0x00061301
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
			if (item == this._cell)
			{
				this._cellRect = rect;
				return;
			}
			this._labelRect = rect;
		}

		// Token: 0x040008A9 RID: 2217
		private global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase _cp;

		// Token: 0x040008AA RID: 2218
		private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem _label;

		// Token: 0x040008AB RID: 2219
		private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager.CPLayoutItem _cell;

		// Token: 0x040008AC RID: 2220
		private global::System.Windows.Rect _cellRect;

		// Token: 0x040008AD RID: 2221
		private global::System.Windows.Rect _labelRect;

		// Token: 0x040008AE RID: 2222
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040008AF RID: 2223
		private global::System.Windows.Size _constrainedSize;

		// Token: 0x02000176 RID: 374
		private class CPLayoutItem : global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
		{
			// Token: 0x060015D9 RID: 5593 RVA: 0x0006311B File Offset: 0x0006131B
			internal CPLayoutItem(global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager owner, bool isLabel)
			{
				this._owner = owner;
				this._isLabel = isLabel;
			}

			// Token: 0x1700056B RID: 1387
			// (get) Token: 0x060015DA RID: 5594 RVA: 0x00063134 File Offset: 0x00061334
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

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x060015DB RID: 5595 RVA: 0x00063164 File Offset: 0x00061364
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

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x060015DC RID: 5596 RVA: 0x00063192 File Offset: 0x00061392
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

			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x060015DD RID: 5597 RVA: 0x000631CC File Offset: 0x000613CC
			// (set) Token: 0x060015DE RID: 5598 RVA: 0x000631D4 File Offset: 0x000613D4
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

			// Token: 0x1700056F RID: 1391
			// (get) Token: 0x060015DF RID: 5599 RVA: 0x000631DD File Offset: 0x000613DD
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MaximumSize
			{
				get
				{
					return this.BaseLayoutItem.MaximumSize;
				}
			}

			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000631EA File Offset: 0x000613EA
			global::System.Windows.Size global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.MinimumSize
			{
				get
				{
					return this.BaseLayoutItem.MinimumSize;
				}
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x060015E1 RID: 5601 RVA: 0x000631F8 File Offset: 0x000613F8
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

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0006328D File Offset: 0x0006148D
			global::System.Windows.Visibility global::Infragistics.Controls.Layouts.Primitives.ILayoutItem.Visibility
			{
				get
				{
					return this.BaseLayoutItem.Visibility;
				}
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0006329A File Offset: 0x0006149A
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
			{
				get
				{
					return this.BaseConstraint.Column;
				}
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x060015E4 RID: 5604 RVA: 0x000632A7 File Offset: 0x000614A7
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
			{
				get
				{
					return this.BaseConstraint.ColumnSpan;
				}
			}

			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x060015E5 RID: 5605 RVA: 0x000632B4 File Offset: 0x000614B4
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
			{
				get
				{
					return this.BaseConstraint.ColumnWeight;
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x060015E6 RID: 5606 RVA: 0x000632C1 File Offset: 0x000614C1
			global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
			{
				get
				{
					return this.BaseConstraint.HorizontalAlignment;
				}
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000632D0 File Offset: 0x000614D0
			global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
			{
				get
				{
					return default(global::System.Windows.Thickness);
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x060015E8 RID: 5608 RVA: 0x000632E6 File Offset: 0x000614E6
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
			{
				get
				{
					return this.BaseConstraint.Row;
				}
			}

			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000632F3 File Offset: 0x000614F3
			int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
			{
				get
				{
					return this.BaseConstraint.RowSpan;
				}
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x060015EA RID: 5610 RVA: 0x00063300 File Offset: 0x00061500
			float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
			{
				get
				{
					return this.BaseConstraint.RowWeight;
				}
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x060015EB RID: 5611 RVA: 0x0006330D File Offset: 0x0006150D
			global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
			{
				get
				{
					return this.BaseConstraint.VerticalAlignment;
				}
			}

			// Token: 0x040008B0 RID: 2224
			private global::Infragistics.Windows.DataPresenter.CPGridBagLayoutManager _owner;

			// Token: 0x040008B1 RID: 2225
			private bool _isLabel;

			// Token: 0x040008B2 RID: 2226
			private global::System.Windows.Rect _preferredRect;
		}
	}
}
