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
	// Token: 0x020000BA RID: 186
	[global::System.Windows.TemplatePart(Name = "PART_EditorSite", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	public abstract class ValuePresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x0002ED08 File Offset: 0x0002CF08
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

		// Token: 0x06000A21 RID: 2593 RVA: 0x0002EEE1 File Offset: 0x0002D0E1
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ValidateEditorIsSited(true);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			global::Infragistics.Windows.Editors.ValueEditor editor = this.Editor;
			if (editor == null)
			{
				this.ProcessPreviewMouseLeftButtonDown(e);
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0002EF3D File Offset: 0x0002D13D
		public bool AcceptsArrowKeysInEditMode
		{
			get
			{
				return this._editor != null && this._editor.AcceptsArrowKeysInEditModeResolved;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0002EF54 File Offset: 0x0002D154
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A25 RID: 2597
		public abstract bool IsEditingAllowed { get; }

		// Token: 0x06000A26 RID: 2598 RVA: 0x0002EF5C File Offset: 0x0002D15C
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002EFBD File Offset: 0x0002D1BD
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0002EFCF File Offset: 0x0002D1CF
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002EFE2 File Offset: 0x0002D1E2
		protected internal virtual bool AlwaysValidate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002EFE5 File Offset: 0x0002D1E5
		protected internal virtual bool BypassValidationOnLostFocus
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		protected internal virtual global::Infragistics.Windows.Editors.InvalidValueBehavior DefaultInvalidValueBehavior
		{
			get
			{
				return global::Infragistics.Windows.Editors.InvalidValueBehavior.Default;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002EFEB File Offset: 0x0002D1EB
		protected global::System.Windows.Controls.ContentPresenter EditorSite
		{
			get
			{
				return this._editorSite;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002EFF3 File Offset: 0x0002D1F3
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0002EFFB File Offset: 0x0002D1FB
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002F005 File Offset: 0x0002D205
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0002F00D File Offset: 0x0002D20D
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002F018 File Offset: 0x0002D218
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002F05E File Offset: 0x0002D25E
		protected virtual bool HasValueType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002F061 File Offset: 0x0002D261
		protected internal virtual bool SupportsAsyncOperations
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0002F064 File Offset: 0x0002D264
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x0002F06C File Offset: 0x0002D26C
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

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002F076 File Offset: 0x0002D276
		public void EndEditMode(bool acceptChanges, bool force)
		{
			if (this._editor == null)
			{
				return;
			}
			this._editor.EndEditMode(acceptChanges, force);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002F08E File Offset: 0x0002D28E
		public bool StartEditMode()
		{
			if (this._editor == null)
			{
				return false;
			}
			base.UpdateLayout();
			return this._editor.StartEditMode();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002F0AB File Offset: 0x0002D2AB
		protected void InitializeEditorSettings(global::System.Type editorType, global::System.Type valueType, global::System.Windows.Style editorStyle)
		{
			if (this.HasValueType)
			{
				this.SetValueType(valueType, false);
			}
			this.SetEditorType(editorType, false);
			this.SetEditorStyle(editorStyle, false);
			if (this._editorSite != null)
			{
				this.ValidateEditorIsSited();
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002F0DB File Offset: 0x0002D2DB
		protected internal virtual bool IsCurrentValueValid(out global::System.Exception error)
		{
			error = null;
			return true;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002F0E1 File Offset: 0x0002D2E1
		protected virtual void OnEditorCreated(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
		}

		// Token: 0x06000A3B RID: 2619
		protected abstract void OnEditModeStarting(global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e);

		// Token: 0x06000A3C RID: 2620
		protected abstract void OnEditModeStarted(global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e);

		// Token: 0x06000A3D RID: 2621
		protected abstract void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e);

		// Token: 0x06000A3E RID: 2622
		protected abstract void OnEditModeEnded(global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e);

		// Token: 0x06000A3F RID: 2623
		protected abstract void OnEditModeValidationError(global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e);

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002F0E3 File Offset: 0x0002D2E3
		protected internal virtual void OnEditorValueChanged(global::System.Windows.RoutedEventArgs args)
		{
		}

		// Token: 0x06000A41 RID: 2625
		protected internal abstract bool CommitEditValue(object editedValue, out bool stayInEditMode);

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002F0E5 File Offset: 0x0002D2E5
		protected internal virtual void OnValueChanged()
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002F0E7 File Offset: 0x0002D2E7
		protected internal virtual bool OnValueEditorKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			return false;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002F0EA File Offset: 0x0002D2EA
		protected internal virtual void OnValueValidated()
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002F0EC File Offset: 0x0002D2EC
		protected virtual void ProcessPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		protected internal virtual bool ShouldSuppressEvent(global::System.Windows.RoutedEventArgs args)
		{
			return false;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002F0F1 File Offset: 0x0002D2F1
		protected void UpdateOriginalValue(object newOriginalValue)
		{
			if (this._editor != null)
			{
				this._editor.UpdateOriginalValue(newOriginalValue);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002F108 File Offset: 0x0002D308
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

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002F138 File Offset: 0x0002D338
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

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002F16C File Offset: 0x0002D36C
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

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002F19C File Offset: 0x0002D39C
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

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
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

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002F200 File Offset: 0x0002D400
		private static void ClassHandler_ValuePresenter_MarkHandledHelper(global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueEditor valueEditor = e.OriginalSource as global::Infragistics.Windows.Editors.ValueEditor;
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = (valueEditor != null) ? valueEditor.Host : null;
			if (valuePresenter != null)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002F230 File Offset: 0x0002D430
		private static void ClassHandler_ValuePresenter_EditModeStarting(object sender, global::Infragistics.Windows.Editors.Events.EditModeStartingEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002F238 File Offset: 0x0002D438
		private static void ClassHandler_ValuePresenter_EditModeStarted(object sender, global::Infragistics.Windows.Editors.Events.EditModeStartedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002F240 File Offset: 0x0002D440
		private static void ClassHandler_ValuePresenter_EditModeEnding(object sender, global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002F248 File Offset: 0x0002D448
		private static void ClassHandler_ValuePresenter_EditModeEnded(object sender, global::Infragistics.Windows.Editors.Events.EditModeEndedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002F250 File Offset: 0x0002D450
		private static void ClassHandler_ValuePresenter_EditModeValidationError(object sender, global::Infragistics.Windows.Editors.Events.EditModeValidationErrorEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter.ClassHandler_ValuePresenter_MarkHandledHelper(e);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0002F258 File Offset: 0x0002D458
		private void DirtyEditor(bool validateEditorIsSited)
		{
			this._editor = null;
			this._isEditorSited = false;
			if (validateEditorIsSited)
			{
				this.ValidateEditorIsSited();
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0002F274 File Offset: 0x0002D474
		private static void OnHorizontalContentAlignmentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = (global::Infragistics.Windows.Editors.ValuePresenter)target;
			valuePresenter.VerfiyOptimizedWidthMeasurement();
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002F290 File Offset: 0x0002D490
		private static void OnHorizontalAlignmentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValuePresenter valuePresenter = (global::Infragistics.Windows.Editors.ValuePresenter)target;
			valuePresenter.VerfiyOptimizedWidthMeasurement();
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002F2AC File Offset: 0x0002D4AC
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

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002F334 File Offset: 0x0002D534
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

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002F3B3 File Offset: 0x0002D5B3
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

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002F3D9 File Offset: 0x0002D5D9
		private void ValidateEditorIsSited()
		{
			this.ValidateEditorIsSited(false);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
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
					if (this.HasValueType)
					{
						this._editor.ValueType = this.ValueType;
					}
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

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
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

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002F610 File Offset: 0x0002D810
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
			if (!flag)
			{
				base.SetValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty, global::Infragistics.KnownBoxes.FalseBox);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.Controls.SimpleTextBlock.OptimizeWidthMeasurementProperty);
		}

		// Token: 0x040003A8 RID: 936
		private bool _isEditorSited;

		// Token: 0x040003A9 RID: 937
		private global::System.Windows.Controls.ContentPresenter _editorSite;

		// Token: 0x040003AA RID: 938
		private global::Infragistics.Windows.Editors.ValueEditor _editor;

		// Token: 0x040003AB RID: 939
		private global::System.Windows.Style _editorStyle;

		// Token: 0x040003AC RID: 940
		private global::System.Type _editorType;

		// Token: 0x040003AD RID: 941
		private global::System.Type _valueType;

		// Token: 0x040003AE RID: 942
		internal int _previewMouseLeftButtonDown_EnterEditMode_TimeStamp;

		// Token: 0x040003AF RID: 943
		public static readonly global::System.Windows.DependencyProperty IsInEditModeProperty = global::System.Windows.DependencyProperty.Register("IsInEditMode", typeof(bool), typeof(global::Infragistics.Windows.Editors.ValuePresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.ValuePresenter.CoerceIsInEditMode)));
	}
}
