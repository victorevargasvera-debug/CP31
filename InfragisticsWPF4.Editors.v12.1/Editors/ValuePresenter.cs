using System;
using System.ComponentModel;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Editors.Events;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000B3 RID: 179
	[global::System.Windows.TemplatePart(Name = "PART_EditorSite", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	public abstract class ValuePresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060009B1 RID: 2481 RVA: 0x0002CCFC File Offset: 0x0002AEFC
		static ValuePresenter()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValueEditor), global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeStarting));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValueEditor), global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeStarted));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValueEditor), global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeEnding));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValueEditor), global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeEnded));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValueEditor), global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_EditModeValidationError));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValuePresenter), global::Infragistics.Windows.Editors.ValueEditor.EditModeStartingEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_EditModeStarting));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValuePresenter), global::Infragistics.Windows.Editors.ValueEditor.EditModeStartedEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_EditModeStarted));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValuePresenter), global::Infragistics.Windows.Editors.ValueEditor.EditModeEndingEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_EditModeEnding));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValuePresenter), global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_EditModeEnded));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Editors.ValuePresenter), global::Infragistics.Windows.Editors.ValueEditor.EditModeValidationErrorEvent, new global::System.EventHandler<global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs>(global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_EditModeValidationError));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.ValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValuePresenter.OnHorizontalContentAlignmentChanged)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.ValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValuePresenter.OnHorizontalAlignmentChanged)));
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002CED5 File Offset: 0x0002B0D5
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ValidateEditorIsSited(true);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			global::Infragistics.Windows.Editors.ValueEditor editor = this.Editor;
			if (editor == null)
			{
				return;
			}
			bool isInEditMode = editor.IsInEditMode;
			this.ProcessPreviewMouseLeftButtonDown(e);
			bool isInEditMode2 = editor.IsInEditMode;
			if (isInEditMode2 && !isInEditMode)
			{
				this._previewMouseLeftButtonDown_EnterEditMode_TimeStamp = e.Timestamp;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0002CF2A File Offset: 0x0002B12A
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009B6 RID: 2486
		public abstract bool IsEditingAllowed { get; }

		// Token: 0x060009B7 RID: 2487 RVA: 0x0002CF34 File Offset: 0x0002B134
		private static object CoerceIsInEditMode(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = target as global::Infragistics.Windows.Editors.ValuePresenter;
			if (valuePresenter == null || !(value is bool))
			{
				return value;
			}
			bool flag = (bool)value;
			if (valuePresenter._editor == null)
			{
				return false;
			}
			if (flag != valuePresenter._editor.IsInEditMode)
			{
				valuePresenter._editor.IsInEditMode = false;
			}
			return valuePresenter._editor.IsInEditMode;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0002CF95 File Offset: 0x0002B195
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0002CFA7 File Offset: 0x0002B1A7
		[global::System.ComponentModel.Bindable(true)]
		public bool IsInEditMode
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.ValuePresenter.IsInEditModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValuePresenter.IsInEditModeProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0002CFBA File Offset: 0x0002B1BA
		protected internal virtual bool AlwaysValidate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0002CFBD File Offset: 0x0002B1BD
		protected internal virtual global::Infragistics.Windows.Editors.InvalidValueBehavior DefaultInvalidValueBehavior
		{
			get
			{
				return global::Infragistics.Windows.Editors.InvalidValueBehavior.Default;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0002CFC0 File Offset: 0x0002B1C0
		protected global::System.Windows.Controls.ContentPresenter EditorSite
		{
			get
			{
				return this._editorSite;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		protected global::System.Windows.Style EditorStyle
		{
			get
			{
				return this._editorStyle;
			}
			set
			{
				this.SetEditorStyle(value, true);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0002CFDA File Offset: 0x0002B1DA
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0002CFE2 File Offset: 0x0002B1E2
		protected global::System.Type EditorType
		{
			get
			{
				return this._editorType;
			}
			set
			{
				this.SetEditorType(value, true);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		protected global::System.Type EditorTypeResolved
		{
			get
			{
				global::System.Type type = this._editorType;
				if (this._editorStyle != null)
				{
					global::System.Type targetType = this._editorStyle.TargetType;
					if (null == type || (null != targetType && !targetType.IsAssignableFrom(type)))
					{
						type = targetType;
					}
				}
				return type;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002D032 File Offset: 0x0002B232
		protected internal virtual bool SupportsAsyncOperations
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0002D035 File Offset: 0x0002B235
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x0002D03D File Offset: 0x0002B23D
		public global::System.Type ValueType
		{
			get
			{
				return this._valueType;
			}
			set
			{
				this.SetValueType(value, true);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002D047 File Offset: 0x0002B247
		public void EndEditMode(bool acceptChanges, bool force)
		{
			if (this._editor == null)
			{
				return;
			}
			this._editor.EndEditMode(acceptChanges, force);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002D05F File Offset: 0x0002B25F
		public bool StartEditMode()
		{
			if (this._editor == null)
			{
				return false;
			}
			base.UpdateLayout();
			return this._editor.StartEditMode();
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0002D07C File Offset: 0x0002B27C
		protected void InitializeEditorSettings(global::System.Type editorType, global::System.Type valueType, global::System.Windows.Style editorStyle)
		{
			this.SetValueType(valueType, false);
			this.SetEditorType(editorType, false);
			this.SetEditorStyle(editorStyle, false);
			if (this._editorSite != null)
			{
				this.ValidateEditorIsSited();
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		protected internal virtual bool IsCurrentValueValid(out global::System.Exception error)
		{
			error = null;
			return true;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002D0AA File Offset: 0x0002B2AA
		protected virtual void OnEditorCreated(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
		}

		// Token: 0x060009CA RID: 2506
		protected abstract void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e);

		// Token: 0x060009CB RID: 2507
		protected abstract void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e);

		// Token: 0x060009CC RID: 2508
		protected abstract void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e);

		// Token: 0x060009CD RID: 2509
		protected abstract void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e);

		// Token: 0x060009CE RID: 2510
		protected abstract void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e);

		// Token: 0x060009CF RID: 2511 RVA: 0x0002D0AC File Offset: 0x0002B2AC
		protected internal virtual void OnEditorValueChanged(global::System.Windows.RoutedEventArgs args)
		{
		}

		// Token: 0x060009D0 RID: 2512
		protected internal abstract bool CommitEditValue(object editedValue, out bool stayInEditMode);

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002D0AE File Offset: 0x0002B2AE
		protected internal virtual void OnValueChanged()
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
		protected internal virtual bool OnValueEditorKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			return false;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002D0B3 File Offset: 0x0002B2B3
		protected internal virtual void OnValueValidated()
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002D0B5 File Offset: 0x0002B2B5
		protected virtual void ProcessPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0002D0B7 File Offset: 0x0002B2B7
		protected internal virtual bool ShouldSuppressEvent(global::System.Windows.RoutedEventArgs args)
		{
			return false;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		internal static void ClassHandler_EditModeStarting(object sender, global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				global::Infragistics.Windows.Editors.ValuePresenter host = valueEditor.Host;
				if (host != null)
				{
					host.OnEditModeStarting(e);
				}
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		internal static void ClassHandler_EditModeStarted(object sender, global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				global::Infragistics.Windows.Editors.ValuePresenter host = valueEditor.Host;
				if (host != null)
				{
					host.IsInEditMode = true;
					host.OnEditModeStarted(e);
				}
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002D120 File Offset: 0x0002B320
		internal static void ClassHandler_EditModeEnding(object sender, global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				global::Infragistics.Windows.Editors.ValuePresenter host = valueEditor.Host;
				if (host != null)
				{
					host.OnEditModeEnding(e);
				}
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002D150 File Offset: 0x0002B350
		internal static void ClassHandler_EditModeEnded(object sender, global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				global::Infragistics.Windows.Editors.ValuePresenter host = valueEditor.Host;
				if (host != null)
				{
					host.IsInEditMode = false;
					host.OnEditModeEnded(e);
				}
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002D184 File Offset: 0x0002B384
		internal static void ClassHandler_EditModeValidationError(object sender, global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			if (valueEditor != null)
			{
				global::Infragistics.Windows.Editors.ValuePresenter host = valueEditor.Host;
				if (host != null)
				{
					host.OnEditModeValidationError(e);
				}
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002D1B4 File Offset: 0x0002B3B4
		private static void ClassHandler_ValuePresenter_MarkHandledHelper(global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = (valueEditor != null) ? valueEditor.Host : null;
			if (valuePresenter != null)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		private static void ClassHandler_ValuePresenter_EditModeStarting(object sender, global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002D1EC File Offset: 0x0002B3EC
		private static void ClassHandler_ValuePresenter_EditModeStarted(object sender, global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002D1F4 File Offset: 0x0002B3F4
		private static void ClassHandler_ValuePresenter_EditModeEnding(object sender, global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002D1FC File Offset: 0x0002B3FC
		private static void ClassHandler_ValuePresenter_EditModeEnded(object sender, global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002D204 File Offset: 0x0002B404
		private static void ClassHandler_ValuePresenter_EditModeValidationError(object sender, global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002D20C File Offset: 0x0002B40C
		private void DirtyEditor(bool validateEditorIsSited)
		{
			this._editor = null;
			this._isEditorSited = false;
			if (validateEditorIsSited)
			{
				this.ValidateEditorIsSited();
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002D228 File Offset: 0x0002B428
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = (global::Infragistics.Windows.Editors.ValuePresenter)target;
			valuePresenter.VerfiyOptimizedWidthMeasurement();
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002D244 File Offset: 0x0002B444
		private static void OnHorizontalAlignmentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = (global::Infragistics.Windows.Editors.ValuePresenter)target;
			valuePresenter.VerfiyOptimizedWidthMeasurement();
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002D260 File Offset: 0x0002B460
		private void SetEditorType(global::System.Type value, bool validateEditorIsSited)
		{
			if (this._editorType != value)
			{
				if (value != null && !typeof(global::Infragistics.Windows.Editors.ValueEditor).IsAssignableFrom(value))
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_9"), "value");
				}
				this._editorType = value;
				if (this._editor != null && (this._editorType == null || this.EditorTypeResolved != this._editor.GetType()))
				{
					this.DirtyEditor(validateEditorIsSited);
				}
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		private void SetEditorStyle(global::System.Windows.Style value, bool validateEditorIsSited)
		{
			if (this._editorStyle != value)
			{
				if (value != null)
				{
					global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(value, typeof(global::Infragistics.Windows.Editors.ValueEditor), "EditorStyle");
				}
				this._editorStyle = value;
				if (this._editor != null && (this._editorStyle != this._editor.Style || this.EditorTypeResolved != this._editor.GetType()))
				{
					this._editor = null;
					this._isEditorSited = false;
				}
				if (validateEditorIsSited)
				{
					this.ValidateEditorIsSited();
				}
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002D367 File Offset: 0x0002B567
		private void SetValueType(global::System.Type value, bool validateEditorIsSited)
		{
			if (this._valueType != value)
			{
				this._valueType = value;
				if (this._isEditorSited)
				{
					this.DirtyEditor(validateEditorIsSited);
				}
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002D38D File Offset: 0x0002B58D
		private void ValidateEditorIsSited()
		{
			this.ValidateEditorIsSited(false);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002D398 File Offset: 0x0002B598
		private void ValidateEditorIsSited(bool templateApplied)
		{
			bool flag = false;
			if (this._editorSite == null || templateApplied)
			{
				global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_EditorSite");
				global::System.Windows.Controls.ContentPresenter contentPresenter = templateChild as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != this._editorSite)
				{
					this._editorSite = contentPresenter;
					this._isEditorSited = false;
					flag = true;
				}
				if (this._editorSite == null && templateChild != null)
				{
					throw new global::System.NotSupportedException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_NotSupportedException_4"));
				}
			}
			global::System.Type editorTypeResolved = this.EditorTypeResolved;
			if (this._isEditorSited || editorTypeResolved == null || this._editorSite == null)
			{
				return;
			}
			this._isEditorSited = true;
			try
			{
				if (this._editor == null)
				{
					flag = true;
					if (editorTypeResolved == typeof(global::Infragistics.Windows.Editors.XamTextEditor))
					{
						this._editor = new global::Infragistics.Windows.Editors.XamTextEditor();
					}
					else if (editorTypeResolved == typeof(global::Infragistics.Windows.Editors.XamMaskedEditor))
					{
						this._editor = new global::Infragistics.Windows.Editors.XamMaskedEditor();
					}
					else if (editorTypeResolved == typeof(global::Infragistics.Windows.Editors.XamCheckEditor))
					{
						this._editor = new global::Infragistics.Windows.Editors.XamCheckEditor();
					}
					else if (editorTypeResolved == typeof(global::Infragistics.Windows.Editors.XamNumericEditor))
					{
						this._editor = new global::Infragistics.Windows.Editors.XamNumericEditor();
					}
					else if (editorTypeResolved == typeof(global::Infragistics.Windows.Editors.XamDateTimeEditor))
					{
						this._editor = new global::Infragistics.Windows.Editors.XamDateTimeEditor();
					}
					else if (editorTypeResolved == typeof(global::Infragistics.Windows.Editors.XamCurrencyEditor))
					{
						this._editor = new global::Infragistics.Windows.Editors.XamCurrencyEditor();
					}
					else
					{
						this._editor = (global::System.Activator.CreateInstance(editorTypeResolved) as global::Infragistics.Windows.Editors.ValueEditor);
					}
				}
				if (flag)
				{
					this._editor.InitializeHostInfo(this, this);
					this._editor.ValueType = this.ValueType;
					this.OnEditorCreated(this._editor);
					if (this._editorStyle != null)
					{
						this._editor.Style = this._editorStyle;
					}
					this._editor.Value = base.Content;
					this._editorSite.Content = this._editor;
					this.VerfiyOptimizedWidthMeasurement();
				}
			}
			catch (global::System.Security.SecurityException)
			{
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002D590 File Offset: 0x0002B790
		private void ValidateHostContext(object hostContext)
		{
			if (hostContext == null)
			{
				throw new global::System.ArgumentNullException("hostContext");
			}
			if (hostContext != this)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_10"), "hostContext");
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002D5BC File Offset: 0x0002B7BC
		private void VerfiyOptimizedWidthMeasurement()
		{
			bool flag = true;
			switch (base.HorizontalContentAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Center:
			case global::System.Windows.HorizontalAlignment.Right:
				flag = false;
				break;
			}
			if (flag)
			{
				switch (base.HorizontalAlignment)
				{
				case global::System.Windows.HorizontalAlignment.Center:
				case global::System.Windows.HorizontalAlignment.Right:
					flag = false;
					break;
				}
			}
			base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty, global::Infragistics.KnownBoxes.FromValue(flag));
		}

		// Token: 0x04000371 RID: 881
		private bool _isEditorSited;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Controls.ContentPresenter _editorSite;

		// Token: 0x04000373 RID: 883
		private global::Infragistics.Windows.Editors.ValueEditor _editor;

		// Token: 0x04000374 RID: 884
		private global::System.Windows.Style _editorStyle;

		// Token: 0x04000375 RID: 885
		private global::System.Type _editorType;

		// Token: 0x04000376 RID: 886
		private global::System.Type _valueType;

		// Token: 0x04000377 RID: 887
		internal int _previewMouseLeftButtonDown_EnterEditMode_TimeStamp;

		// Token: 0x04000378 RID: 888
		public static readonly global::System.Windows.DependencyProperty IsInEditModeProperty = global::System.Windows.DependencyProperty.Register("IsInEditMode", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.ValuePresenter.CoerceIsInEditMode)));
	}
}
