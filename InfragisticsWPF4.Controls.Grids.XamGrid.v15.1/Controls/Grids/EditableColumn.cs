using System;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000234 RID: 564
	public abstract class EditableColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0003E0C2 File Offset: 0x0003C2C2
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x0003E0CC File Offset: 0x0003C2CC
		public global::System.Windows.Style EditorStyle
		{
			get
			{
				return this._editorStyle;
			}
			set
			{
				if (this._editorStyle != value)
				{
					this._editorStyle = value;
					this.OnPropertyChanged("EditorStyle");
					if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
					{
						base.ColumnLayout.Grid.ResetPanelRows(this.RequiresFullRedrawOnEditorStyleUpdate);
					}
				}
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0003E11F File Offset: 0x0003C31F
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x0003E131 File Offset: 0x0003C331
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.EditableColumn.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditableColumn.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0003E144 File Offset: 0x0003C344
		private static void IsReadOnlyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditableColumn editableColumn = (global::Infragistics.Controls.Grids.EditableColumn)obj;
			editableColumn.OnPropertyChanged("IsReadOnly");
			editableColumn.IsReadOnlyDirtyFlag++;
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0003E171 File Offset: 0x0003C371
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0003E183 File Offset: 0x0003C383
		public global::System.Windows.Data.IValueConverter EditorValueConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterProperty, value);
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0003E194 File Offset: 0x0003C394
		private static void EditorValueConverterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditableColumn editableColumn = (global::Infragistics.Controls.Grids.EditableColumn)obj;
			editableColumn.OnPropertyChanged("EditorValueConverter");
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0003E1B3 File Offset: 0x0003C3B3
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		public object EditorValueConverterParameter
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterParameterProperty, value);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0003E1D0 File Offset: 0x0003C3D0
		private static void EditorValueConverterParameterChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditableColumn editableColumn = (global::Infragistics.Controls.Grids.EditableColumn)obj;
			editableColumn.OnPropertyChanged("EditorValueConverterParameter");
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0003E1EF File Offset: 0x0003C3EF
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0003E201 File Offset: 0x0003C401
		public bool AllowEditingValidation
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.EditableColumn.AllowEditingValidationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditableColumn.AllowEditingValidationProperty, value);
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0003E214 File Offset: 0x0003C414
		private static void AllowEditingValidationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0003E216 File Offset: 0x0003C416
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x0003E21E File Offset: 0x0003C41E
		public global::System.Windows.HorizontalAlignment EditorHorizontalContentAlignment
		{
			get
			{
				return this._editorHAlign;
			}
			set
			{
				this._editorHAlign = value;
				this.OnPropertyChanged("EditorHorizontalContentAlignment");
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0003E232 File Offset: 0x0003C432
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x0003E23A File Offset: 0x0003C43A
		public global::System.Windows.VerticalAlignment EditorVerticalContentAlignment
		{
			get
			{
				return this._editorVAlign;
			}
			set
			{
				this._editorVAlign = value;
				this.OnPropertyChanged("EditorVerticalContentAlignment");
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0003E24E File Offset: 0x0003C44E
		protected internal override bool IsEditable
		{
			get
			{
				if (this._cachedIsReadOnlyDirtyFlag != this.IsReadOnlyDirtyFlag)
				{
					this._cachedIsEditable = !this.IsReadOnly;
					this._cachedIsReadOnlyDirtyFlag = this.IsReadOnlyDirtyFlag;
				}
				return this._cachedIsEditable;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0003E27F File Offset: 0x0003C47F
		protected internal virtual bool RequiresFullRedrawOnEditorStyleUpdate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0003E282 File Offset: 0x0003C482
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x0003E28A File Offset: 0x0003C48A
		internal int IsReadOnlyDirtyFlag { get; set; }

		// Token: 0x0400053E RID: 1342
		private bool _cachedIsEditable;

		// Token: 0x0400053F RID: 1343
		private int _cachedIsReadOnlyDirtyFlag = int.MinValue;

		// Token: 0x04000540 RID: 1344
		private global::System.Windows.HorizontalAlignment _editorHAlign = global::System.Windows.HorizontalAlignment.Stretch;

		// Token: 0x04000541 RID: 1345
		private global::System.Windows.VerticalAlignment _editorVAlign = global::System.Windows.VerticalAlignment.Stretch;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Style _editorStyle;

		// Token: 0x04000543 RID: 1347
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(global::Infragistics.Controls.Grids.EditableColumn), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditableColumn.IsReadOnlyChanged)));

		// Token: 0x04000544 RID: 1348
		public static readonly global::System.Windows.DependencyProperty EditorValueConverterProperty = global::System.Windows.DependencyProperty.Register("EditorValueConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Controls.Grids.EditableColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterChanged)));

		// Token: 0x04000545 RID: 1349
		public static readonly global::System.Windows.DependencyProperty EditorValueConverterParameterProperty = global::System.Windows.DependencyProperty.Register("EditorValueConverterParameter", typeof(object), typeof(global::Infragistics.Controls.Grids.EditableColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterParameterChanged)));

		// Token: 0x04000546 RID: 1350
		public static readonly global::System.Windows.DependencyProperty AllowEditingValidationProperty = global::System.Windows.DependencyProperty.Register("AllowEditingValidation", typeof(bool), typeof(global::Infragistics.Controls.Grids.EditableColumn), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditableColumn.AllowEditingValidationChanged)));
	}
}
