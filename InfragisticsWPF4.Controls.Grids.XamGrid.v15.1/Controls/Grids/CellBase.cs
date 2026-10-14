using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001DF RID: 479
	public abstract class CellBase : global::Infragistics.RecyclingContainer<global::Infragistics.Controls.Grids.Primitives.CellControlBase>, global::Infragistics.ISelectableObject
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x0002FBA7 File Offset: 0x0002DDA7
		protected CellBase(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column)
		{
			this.Row = row;
			this.Column = column;
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		public object Content { get; set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0002FBD9 File Offset: 0x0002DDD9
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x0002FBE1 File Offset: 0x0002DDE1
		public global::Infragistics.Controls.Grids.RowBase Row { get; internal set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0002FBEA File Offset: 0x0002DDEA
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x0002FBF2 File Offset: 0x0002DDF2
		public global::Infragistics.Controls.Grids.Column Column { get; private set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0002FBFB File Offset: 0x0002DDFB
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0002FC03 File Offset: 0x0002DE03
		public global::Infragistics.Controls.Grids.Primitives.CellControlBase Control
		{
			get
			{
				return this._control;
			}
			protected internal set
			{
				this._control = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0002FC0C File Offset: 0x0002DE0C
		public virtual object Value
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0002FC0F File Offset: 0x0002DE0F
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x0002FC29 File Offset: 0x0002DE29
		public bool IsActive
		{
			get
			{
				return this.Row.ColumnLayout.Grid.ActiveCell == this;
			}
			set
			{
				if (value)
				{
					this.Row.ColumnLayout.Grid.ActiveCell = this;
					return;
				}
				this.Row.ColumnLayout.Grid.ActiveCell = null;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0002FC5B File Offset: 0x0002DE5B
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x0002FC5E File Offset: 0x0002DE5E
		public virtual bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002FC60 File Offset: 0x0002DE60
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x0002FC68 File Offset: 0x0002DE68
		public virtual global::System.Windows.Style Style
		{
			get
			{
				return this._style;
			}
			set
			{
				if (this._style != value)
				{
					this._style = value;
					if (this.Column.ColumnLayout != null && this.Column.ColumnLayout.Grid != null)
					{
						this.Column.ColumnLayout.Grid.InvalidateScrollPanel(false);
					}
					this.ApplyStyle();
				}
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0002FCC0 File Offset: 0x0002DEC0
		public virtual bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0002FCC3 File Offset: 0x0002DEC3
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x0002FCCB File Offset: 0x0002DECB
		public object Tag { get; set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0002FCD4 File Offset: 0x0002DED4
		protected virtual global::System.Windows.Style ResolveStyle
		{
			get
			{
				return this.Style;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0002FCDC File Offset: 0x0002DEDC
		protected internal virtual global::System.Windows.Data.BindingMode BindingMode
		{
			get
			{
				if (this.IsEditable)
				{
					return global::System.Windows.Data.BindingMode.Default;
				}
				return global::System.Windows.Data.BindingMode.OneWay;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0002FCE9 File Offset: 0x0002DEE9
		protected internal virtual global::Infragistics.Controls.Grids.EditingSettingsBaseOverride EditingSettings
		{
			get
			{
				return this.Row.ColumnLayout.EditingSettings;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0002FCFB File Offset: 0x0002DEFB
		protected internal virtual bool ShouldClearDataContext
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0002FCFE File Offset: 0x0002DEFE
		protected internal virtual bool SupportsActivation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0002FD01 File Offset: 0x0002DF01
		protected internal virtual bool EnableCustomEditorBehaviors
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0002FD04 File Offset: 0x0002DF04
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0002FD0C File Offset: 0x0002DF0C
		internal global::System.Windows.Size MeasuringSize
		{
			get
			{
				return this._measuringSize;
			}
			set
			{
				this._measuringSize = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0002FD15 File Offset: 0x0002DF15
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x0002FD1D File Offset: 0x0002DF1D
		internal double ActualMergedHeight { get; set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0002FD26 File Offset: 0x0002DF26
		internal virtual object RawValue
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0002FD29 File Offset: 0x0002DF29
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x0002FD31 File Offset: 0x0002DF31
		internal bool SuppressCellControlAttached { get; set; }

		// Token: 0x06000D13 RID: 3347 RVA: 0x0002FD3A File Offset: 0x0002DF3A
		protected override void OnElementAttached(global::Infragistics.Controls.Grids.Primitives.CellControlBase element)
		{
			this._control = element;
			this.ApplyStyle();
			element.OnAttached(this);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0002FD50 File Offset: 0x0002DF50
		protected override bool OnElementReleasing(global::Infragistics.Controls.Grids.Primitives.CellControlBase element)
		{
			return element.OnReleasing(this);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0002FD59 File Offset: 0x0002DF59
		protected override void OnElementReleased(global::Infragistics.Controls.Grids.Primitives.CellControlBase element)
		{
			this._control = null;
			element.OnReleased(this);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0002FD69 File Offset: 0x0002DF69
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0002FD6C File Offset: 0x0002DF6C
		protected override string RecyclingIdentifier
		{
			get
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.Column.ColumnLayout;
				if (columnLayout.Grid != null && columnLayout.Grid.Panel != null && ((columnLayout.Grid.CellControlGenerationModeInternal == global::Infragistics.Controls.Grids.CellControlGenerationMode.Recycle && !columnLayout.Grid.IsCellControlGenerationModeJustChanged) || (columnLayout.Grid.CellControlGenerationMode == global::Infragistics.Controls.Grids.CellControlGenerationMode.Virtualize && columnLayout.Grid.IsCellControlGenerationModeJustChanged)))
				{
					return string.Concat(new string[]
					{
						this.Row.RowType.ToString(),
						"_",
						this.Column.TypeName,
						"_",
						this.Column.ColumnLayout.Key
					});
				}
				return string.Concat(new string[]
				{
					this.Row.RowType.ToString(),
					"_",
					this.Column.Key,
					"_",
					this.Column.ColumnLayout.Key
				});
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0002FE84 File Offset: 0x0002E084
		protected internal virtual void EnsureCurrentState()
		{
			if (this.Control != null)
			{
				if (this.Row.IsMouseOverInternal && this.Row.ResolveRowHover != global::Infragistics.Controls.Grids.RowHoverType.None && (this.Row.ResolveRowHover == global::Infragistics.Controls.Grids.RowHoverType.Row || this == this.Row.ColumnLayout.Grid.MouseOverCellInternal))
				{
					this.Control.GoToState(this.MouseOverState, true);
				}
				else
				{
					this.Control.GoToState(this.NormalState, false);
				}
				if (this == this.Row.ColumnLayout.Grid.ActiveCell)
				{
					this.Control.GoToState("Active", false);
					return;
				}
				this.Control.GoToState("InActive", false);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0002FF42 File Offset: 0x0002E142
		protected internal virtual bool HandleKeyDown(global::System.Windows.Input.Key key, int platformKey)
		{
			return false;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0002FF45 File Offset: 0x0002E145
		protected internal virtual global::Infragistics.Controls.Grids.DragSelectType OnCellMouseDown(global::System.Windows.Input.MouseEventArgs e)
		{
			return global::Infragistics.Controls.Grids.DragSelectType.None;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0002FF48 File Offset: 0x0002E148
		protected internal virtual void OnCellClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0002FF4A File Offset: 0x0002E14A
		protected internal virtual void OnCellDoubleClick()
		{
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0002FF4C File Offset: 0x0002E14C
		protected internal virtual void OnCellDragging(global::Infragistics.Controls.Grids.DragSelectType type)
		{
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0002FF4E File Offset: 0x0002E14E
		protected internal virtual void OnCellMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0002FF50 File Offset: 0x0002E150
		protected internal virtual void OnCellMouseUp(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0002FF52 File Offset: 0x0002E152
		protected internal virtual void SetSelected(bool isSelected)
		{
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0002FF54 File Offset: 0x0002E154
		protected internal virtual void ApplyStyle()
		{
			if (this.Control != null)
			{
				global::System.Windows.Style resolveStyle = this.ResolveStyle;
				if (this.Control.Style != resolveStyle)
				{
					if (resolveStyle != null)
					{
						this.Control.Style = resolveStyle;
						return;
					}
					this.Control.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
				}
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0002FF9E File Offset: 0x0002E19E
		protected internal virtual void EditorValueChanged(object value)
		{
			this.Row.CellEditorValueChanged(this, value);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0002FFAD File Offset: 0x0002E1AD
		public virtual void Refresh()
		{
			if (this.Control != null)
			{
				this.Control.Refresh();
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0002FFC2 File Offset: 0x0002E1C2
		protected internal virtual string NormalState
		{
			get
			{
				if (this.Row.IsAlternateRow)
				{
					return "Alternate";
				}
				return "Normal";
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0002FFDC File Offset: 0x0002E1DC
		protected internal virtual string MouseOverState
		{
			get
			{
				return "MouseOver";
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0002FFE3 File Offset: 0x0002E1E3
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0002FFEB File Offset: 0x0002E1EB
		bool global::Infragistics.ISelectableObject.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
			set
			{
				this.IsSelected = value;
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0002FFF4 File Offset: 0x0002E1F4
		void global::Infragistics.ISelectableObject.SetSelected(bool isSelected)
		{
			this.SetSelected(isSelected);
		}

		// Token: 0x0400045A RID: 1114
		private global::Infragistics.Controls.Grids.Primitives.CellControlBase _control;

		// Token: 0x0400045B RID: 1115
		private global::System.Windows.Style _style;

		// Token: 0x0400045C RID: 1116
		private global::System.Windows.Size _measuringSize = global::System.Windows.Size.Empty;
	}
}
