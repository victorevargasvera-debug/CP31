using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000127 RID: 295
	[global::System.Windows.TemplatePart(Name = "PART_FieldsListBox", Type = typeof(global::System.Windows.Controls.ListBox))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FieldChooser : global::Infragistics.Windows.Controls.IGControlBase, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x0004C9B4 File Offset: 0x0004ABB4
		static FieldChooser()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldChooser)));
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0004CD5C File Offset: 0x0004AF5C
		public FieldChooser()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldFiltersPropertyKey, new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>());
			this._pvtTrackers = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>();
			global::Infragistics.Windows.Internal.PropertyValueTracker item = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "DataPresenter.FieldLayouts.Count", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.InitializeFieldGroups), true);
			this._pvtTrackers.Add(item);
			item = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "CurrentFieldGroup.FieldLayout.Fields.Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ReInitializeCurrentFields), true);
			this._pvtTrackers.Add(item);
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
		protected internal override global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldChooserCommands.Instance;
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0004CDDC File Offset: 0x0004AFDC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::System.Windows.Controls.ListBox listBox = base.GetTemplateChild("PART_FieldsListBox") as global::System.Windows.Controls.ListBox;
			if (listBox != null)
			{
				global::System.Windows.Controls.ScrollViewer.SetPanningMode(listBox, global::System.Windows.Controls.PanningMode.None);
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0004CE0A File Offset: 0x0004B00A
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnDragEnd(e, true);
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0004CE28 File Offset: 0x0004B028
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnMouseMove(e);
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0004CE45 File Offset: 0x0004B045
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnDragEnd(e, false);
				base.ReleaseMouseCapture();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0004CE69 File Offset: 0x0004B069
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0004CE7B File Offset: 0x0004B07B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool? AllCurrentFieldsVisible
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.AllCurrentFieldsVisibleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.AllCurrentFieldsVisibleProperty, value);
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0004CE90 File Offset: 0x0004B090
		private static void OnAllCurrentFieldsVisibleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			bool? flag = (bool?)e.NewValue;
			if (!fieldChooser._settingAllCurrentFieldsVisible)
			{
				fieldChooser.SyncWithAllCurrentFieldsVisible();
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0004CEBF File Offset: 0x0004B0BF
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0004CED1 File Offset: 0x0004B0D1
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FieldChooserGroup CurrentFieldGroup
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldChooserGroup)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldGroupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldGroupProperty, value);
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0004CEE0 File Offset: 0x0004B0E0
		private static void OnCurrentFieldGroupChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.InitializeCurrentFields();
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0004CEFA File Offset: 0x0004B0FA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> CurrentFields
		{
			get
			{
				return (global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldsProperty);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0004CF0C File Offset: 0x0004B10C
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x0004CF1E File Offset: 0x0004B11E
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DataPresenterBase)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.DataPresenterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.DataPresenterProperty, value);
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0004CF2C File Offset: 0x0004B12C
		private void MergeDPResources(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (this._lastDPResources != null && this._lastFCMergedDictionaries != null)
			{
				this._lastFCMergedDictionaries.Remove(this._lastDPResources);
			}
			this._lastDPResources = ((dp != null) ? dp.Resources : null);
			this._lastFCMergedDictionaries = ((base.Resources != null) ? base.Resources.MergedDictionaries : null);
			if (this._lastDPResources != null && this._lastFCMergedDictionaries != null)
			{
				this._lastFCMergedDictionaries.Add(this._lastDPResources);
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0004CFAC File Offset: 0x0004B1AC
		private static void OnDataPresenterChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)e.OldValue;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase2 = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)e.NewValue;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.UnregisterFieldChooser(fieldChooser);
			}
			if (dataPresenterBase2 != null)
			{
				dataPresenterBase2.RegisterFieldChooser(fieldChooser);
			}
			fieldChooser.MergeDPResources(dataPresenterBase2);
			fieldChooser.UpdateIsDraggingItemFromDataPresenter();
			fieldChooser.InitializeFieldGroups();
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0004D001 File Offset: 0x0004B201
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x0004D013 File Offset: 0x0004B213
		[global::System.ComponentModel.Bindable(true)]
		public bool DisplayHiddenFieldsOnly
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.DisplayHiddenFieldsOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.DisplayHiddenFieldsOnlyProperty, value);
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0004D028 File Offset: 0x0004B228
		private static void OnDisplayHiddenFieldsOnlyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.ReInitializeCurrentFields();
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0004D042 File Offset: 0x0004B242
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayHiddenFieldsOnly()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldChooser.DisplayHiddenFieldsOnlyProperty, this);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0004D04F File Offset: 0x0004B24F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayHiddenFieldsOnly()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldChooser.DisplayHiddenFieldsOnlyProperty);
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0004D05C File Offset: 0x0004B25C
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0004D06E File Offset: 0x0004B26E
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder FieldDisplayOrder
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderProperty, value);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0004D084 File Offset: 0x0004B284
		private static void OnFieldDisplayOrderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.ReInitializeCurrentFields();
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0004D09E File Offset: 0x0004B29E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldDisplayOrder()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderProperty, this);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0004D0AB File Offset: 0x0004B2AB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldDisplayOrder()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderProperty);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0004D0CA File Offset: 0x0004B2CA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> FieldDisplayOrderComparer
		{
			get
			{
				return (global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderComparerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderComparerProperty, value);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0004D0D8 File Offset: 0x0004B2D8
		private static void OnFieldDisplayOrderComparerChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.ReInitializeCurrentFields();
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0004D0F2 File Offset: 0x0004B2F2
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter> FieldFilters
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldFiltersProperty);
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0004D104 File Offset: 0x0004B304
		private static void OnFieldFiltersChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser @object = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter> observableCollection = (global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>)e.OldValue;
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter> observableCollection2 = (global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>)e.NewValue;
			if (observableCollection != null)
			{
				observableCollection.CollectionChanged -= @object.OnFieldFilters_CollectionChanged;
			}
			if (observableCollection2 != null)
			{
				observableCollection2.CollectionChanged += @object.OnFieldFilters_CollectionChanged;
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0004D15C File Offset: 0x0004B35C
		private void OnFieldFilters_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InitializeFieldGroups();
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0004D164 File Offset: 0x0004B364
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> FieldGroups
		{
			get
			{
				return (global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupsProperty);
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0004D178 File Offset: 0x0004B378
		private static void OnFieldGroupsChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.InitializeCurrentGroup();
			fieldChooser.InitializeFieldGroupSelectorVisibilityResolved();
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0004D198 File Offset: 0x0004B398
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x0004D1AA File Offset: 0x0004B3AA
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility? FieldGroupSelectorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityProperty, value);
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
		private static void OnFieldGroupSelectorVisibilityResolvedChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.InitializeFieldGroupSelectorVisibilityResolved();
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0004D1DA File Offset: 0x0004B3DA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldGroupSelectorVisibility()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityProperty, this);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0004D1E7 File Offset: 0x0004B3E7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayFieldLayoutSelector()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityProperty);
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0004D1F4 File Offset: 0x0004B3F4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility FieldGroupSelectorVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityResolvedProperty);
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0004D206 File Offset: 0x0004B406
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool IsDragItemOver
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverProperty);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0004D218 File Offset: 0x0004B418
		internal void InternalSetIsDragItemOver(bool value)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0004D22B File Offset: 0x0004B42B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsDraggingItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemProperty);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0004D23D File Offset: 0x0004B43D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool IsDraggingItemFromDataPresenter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemFromDataPresenterProperty);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0004D24F File Offset: 0x0004B44F
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x0004D261 File Offset: 0x0004B461
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::Infragistics.Windows.DataPresenter.FieldChooserEntry SelectedField
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldChooserEntry)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.SelectedFieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.SelectedFieldProperty, value);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0004D270 File Offset: 0x0004B470
		private static void OnSelectedFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry = (global::Infragistics.Windows.DataPresenter.FieldChooserEntry)e.OldValue;
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry2 = (global::Infragistics.Windows.DataPresenter.FieldChooserEntry)e.NewValue;
			if (fieldChooserEntry != null)
			{
				fieldChooserEntry.InternalSetIsSelected(false);
			}
			if (fieldChooserEntry2 != null)
			{
				fieldChooserEntry2.InternalSetIsSelected(true);
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		private static object OnCoerceSelectedField(global::System.Windows.DependencyObject dependencyObject, object valueAsObject)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry = (global::Infragistics.Windows.DataPresenter.FieldChooserEntry)valueAsObject;
			if (fieldChooserEntry != null)
			{
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> currentFields = fieldChooser.CurrentFields;
				if (currentFields != null)
				{
					if (currentFields.Contains(fieldChooserEntry))
					{
						return fieldChooserEntry;
					}
					return fieldChooser.FindFieldChooserEntry(fieldChooserEntry.Field);
				}
			}
			return null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0004D2ED File Offset: 0x0004B4ED
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommand(commandWrapper.Command);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0004D309 File Offset: 0x0004B509
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommand(command, null);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0004D313 File Offset: 0x0004B513
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			return this.ExecuteCommandImpl(command, parameter);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0004D320 File Offset: 0x0004B520
		private void AddSubGroups(global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> groups)
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter> fieldFilters = this.FieldFilters;
			if (fieldFilters != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldChooserFilter fieldChooserFilter in fieldFilters)
				{
					if (fieldChooserFilter != null)
					{
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> matchingFields = fieldChooserFilter.GetMatchingFields(fl);
						if (global::Infragistics.Windows.DataPresenter.GridUtilities.GetCount(matchingFields) > 0)
						{
							groups.Add(new global::Infragistics.Windows.DataPresenter.FieldChooserGroup(fl, fieldChooserFilter));
						}
					}
				}
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0004D38C File Offset: 0x0004B58C
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> CreateFieldEntries(global::Infragistics.Windows.DataPresenter.FieldChooserGroup group)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> list = null;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list2 = global::Infragistics.Windows.DataPresenter.GridUtilities.ToList<global::Infragistics.Windows.DataPresenter.Field>(group.GetMatchingFields(), true);
			if (list2 != null)
			{
				list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>();
				foreach (global::Infragistics.Windows.DataPresenter.Field field in list2)
				{
					if (!field.IsExpandableResolved && global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never != field.AllowHidingResolved && field.DataPresenter == this.DataPresenter)
					{
						global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry = new global::Infragistics.Windows.DataPresenter.FieldChooserEntry(field);
						list.Add(fieldChooserEntry);
						fieldChooserEntry.InitializeFieldChooser(this);
					}
				}
				list.Sort(new global::Infragistics.Windows.DataPresenter.FieldChooser.FieldComparer(this));
			}
			return list;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0004D430 File Offset: 0x0004B630
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> CreateFieldGroups()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>();
			if (dataPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayouts = dataPresenter.FieldLayouts;
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in fieldLayouts)
				{
					global::Infragistics.Windows.DataPresenter.FieldChooserGroup item = new global::Infragistics.Windows.DataPresenter.FieldChooserGroup(fieldLayout, null);
					observableCollection.Add(item);
					this.AddSubGroups(fieldLayout, observableCollection);
				}
			}
			return observableCollection;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0004D4A8 File Offset: 0x0004B6A8
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command, commandParameter, null));
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0004D4B8 File Offset: 0x0004B6B8
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.ICommand command = commandInfo.Command;
			object parameter = commandInfo.Parameter;
			if (global::Infragistics.Windows.DataPresenter.FieldChooserCommands.ToggleVisibility == command)
			{
				global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldFromCommandInfo = this.GetFieldFromCommandInfo(commandInfo, true);
				if (fieldFromCommandInfo != null)
				{
					fieldFromCommandInfo.IsVisible = !fieldFromCommandInfo.IsVisible;
					return true;
				}
			}
			else if (global::Infragistics.Windows.DataPresenter.FieldChooserCommands.Stop == command && base.IsMouseCaptureWithin)
			{
				base.ReleaseMouseCapture();
				return true;
			}
			return false;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0004D514 File Offset: 0x0004B714
		public global::Infragistics.Windows.DataPresenter.FieldChooserEntry FindFieldChooserEntry(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> currentFields = this.CurrentFields;
			if (currentFields != null && field != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry in currentFields)
				{
					if (fieldChooserEntry.Field == field)
					{
						return fieldChooserEntry;
					}
				}
			}
			return null;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0004D574 File Offset: 0x0004B774
		private global::Infragistics.Windows.DataPresenter.FieldChooserEntry GetFieldFromCommandInfo(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo, bool fallbackToSelectedField)
		{
			global::Infragistics.Windows.DataPresenter.Field field = null;
			object parameter = commandInfo.Parameter;
			if (parameter is global::Infragistics.Windows.DataPresenter.Field)
			{
				field = (global::Infragistics.Windows.DataPresenter.Field)parameter;
			}
			else if (parameter is global::Infragistics.Windows.DataPresenter.FieldChooserEntry)
			{
				field = ((global::Infragistics.Windows.DataPresenter.FieldChooserEntry)parameter).Field;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = commandInfo.OriginalSource as global::Infragistics.Windows.DataPresenter.LabelPresenter;
				if (labelPresenter != null)
				{
					field = labelPresenter.Field;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry = (field != null) ? this.FindFieldChooserEntry(field) : null;
			if (fieldChooserEntry == null && fallbackToSelectedField)
			{
				fieldChooserEntry = this.SelectedField;
			}
			return fieldChooserEntry;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0004D5E4 File Offset: 0x0004B7E4
		private void InitializeCurrentFields()
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup currentFieldGroup = this.CurrentFieldGroup;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> fieldsList = (currentFieldGroup != null) ? this.CreateFieldEntries(currentFieldGroup) : null;
			this.InitializeCurrentFieldsHelper(fieldsList);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0004D610 File Offset: 0x0004B810
		private void InitializeCurrentFieldsHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> fieldsList)
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>();
			if (fieldsList != null && fieldsList.Count > 0)
			{
				bool displayHiddenFieldsOnly = this.DisplayHiddenFieldsOnly;
				foreach (global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry in fieldsList)
				{
					if (!displayHiddenFieldsOnly || !fieldChooserEntry.IsVisible)
					{
						observableCollection.Add(fieldChooserEntry);
					}
				}
			}
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> value = (observableCollection != null) ? new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>(observableCollection) : null;
			this._currentGroupFields = fieldsList;
			this._currentFieldsObservableList = observableCollection;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldsPropertyKey, value);
			this.SyncAllCurrentFieldsVisible();
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		private void InitializeCurrentGroup()
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup fieldChooserGroup = null;
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup currentFieldGroup = this.CurrentFieldGroup;
			if (currentFieldGroup != null)
			{
				if (this.IsGroupValid(currentFieldGroup))
				{
					fieldChooserGroup = currentFieldGroup;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldChooserGroup fieldChooserGroup2 = new global::Infragistics.Windows.DataPresenter.FieldChooserGroup(currentFieldGroup.FieldLayout, null);
					if (this.IsGroupValid(fieldChooserGroup2))
					{
						fieldChooserGroup = fieldChooserGroup2;
					}
				}
			}
			if (fieldChooserGroup == null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> fieldGroups = this.FieldGroups;
				fieldChooserGroup = ((fieldGroups != null && fieldGroups.Count > 0) ? fieldGroups[0] : null);
			}
			this.CurrentFieldGroup = fieldChooserGroup;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0004D718 File Offset: 0x0004B918
		private void InitializeFieldGroups()
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> list = this.CreateFieldGroups();
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> value = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>(list);
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupsPropertyKey, value);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0004D740 File Offset: 0x0004B940
		private void InitializeFieldGroupSelectorVisibilityResolved()
		{
			global::System.Windows.Visibility? fieldGroupSelectorVisibility = this.FieldGroupSelectorVisibility;
			if (fieldGroupSelectorVisibility == null)
			{
				fieldGroupSelectorVisibility = new global::System.Windows.Visibility?((this.FieldGroups != null && 1 == this.FieldGroups.Count) ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityResolvedPropertyKey, fieldGroupSelectorVisibility);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0004D790 File Offset: 0x0004B990
		private void InternalSetAllCurrentFieldsVisible(bool? newVal)
		{
			bool settingAllCurrentFieldsVisible = this._settingAllCurrentFieldsVisible;
			this._settingAllCurrentFieldsVisible = true;
			try
			{
				this.AllCurrentFieldsVisible = newVal;
			}
			finally
			{
				this._settingAllCurrentFieldsVisible = settingAllCurrentFieldsVisible;
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0004D7CC File Offset: 0x0004B9CC
		private bool IsGroupValid(global::Infragistics.Windows.DataPresenter.FieldChooserGroup group)
		{
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> fieldGroups = this.FieldGroups;
			return fieldGroups != null && fieldGroups.IndexOf(group) >= 0;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0004D7F2 File Offset: 0x0004B9F2
		internal void OnFieldVisibilityChanged(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this.DisplayHiddenFieldsOnly)
			{
				this.InitializeCurrentFieldsHelper(this._currentGroupFields);
				return;
			}
			this.SyncAllCurrentFieldsVisible();
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0004D80F File Offset: 0x0004BA0F
		internal void ReInitializeCurrentFields()
		{
			this.InitializeCurrentFields();
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0004D818 File Offset: 0x0004BA18
		internal void ReInitializeCurrentFieldsAsync()
		{
			if (this._pendingReInitializeCurrentFields)
			{
				return;
			}
			global::System.Windows.Threading.Dispatcher dispatcher = base.Dispatcher;
			if (dispatcher != null)
			{
				dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ReInitializeCurrentFieldsAsyncCallback));
				this._pendingReInitializeCurrentFields = true;
				return;
			}
			this.InitializeCurrentFields();
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0004D85B File Offset: 0x0004BA5B
		private void ReInitializeCurrentFieldsAsyncCallback()
		{
			this._pendingReInitializeCurrentFields = false;
			this.ReInitializeCurrentFields();
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0004D86C File Offset: 0x0004BA6C
		internal void SelectFieldHelper(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry = this.FindFieldChooserEntry(field);
			if (fieldChooserEntry != null)
			{
				this.SelectedField = fieldChooserEntry;
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0004D88C File Offset: 0x0004BA8C
		internal void SetFieldDragManagerHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager fieldDragManager)
		{
			this._fieldDragManager = fieldDragManager;
			bool value = null != this._fieldDragManager;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0004D8C0 File Offset: 0x0004BAC0
		private void SyncAllCurrentFieldsVisible()
		{
			int num = 0;
			int num2 = 0;
			if (this.CurrentFields != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry in this.CurrentFields)
				{
					if (fieldChooserEntry.IsVisible)
					{
						num++;
					}
					else
					{
						num2++;
					}
				}
			}
			bool? newVal = (0 != num ^ 0 != num2) ? new bool?(0 != num) : null;
			this.InternalSetAllCurrentFieldsVisible(newVal);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0004D95C File Offset: 0x0004BB5C
		private void SyncWithAllCurrentFieldsVisible()
		{
			if (this._processingAllCurrentFieldsVisiblePropChange)
			{
				return;
			}
			this._processingAllCurrentFieldsVisiblePropChange = true;
			try
			{
				bool? allCurrentFieldsVisible = this.AllCurrentFieldsVisible;
				if (allCurrentFieldsVisible != null && this.CurrentFields != null)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>(this.CurrentFields);
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					global::Infragistics.Windows.DataPresenter.DataPresenterHistory dataPresenterHistory = (dataPresenter != null) ? dataPresenter.History : null;
					if (dataPresenterHistory != null)
					{
						dataPresenterHistory.BeginCompositeAction();
					}
					try
					{
						foreach (global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry in list)
						{
							fieldChooserEntry.IsVisible = allCurrentFieldsVisible.Value;
						}
					}
					finally
					{
						if (dataPresenterHistory != null)
						{
							dataPresenterHistory.EndCompositeAction();
						}
					}
				}
			}
			finally
			{
				this._processingAllCurrentFieldsVisiblePropChange = false;
			}
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0004DA34 File Offset: 0x0004BC34
		internal void UpdateIsDraggingItemFromDataPresenter()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			bool flag = dataPresenter != null && dataPresenter.IsDraggingField;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemFromDataPresenterPropertyKey, global::Infragistics.KnownBoxes.FromValue(flag));
			if (!flag)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.ICommand command = commandInfo.Command;
			if (global::Infragistics.Windows.DataPresenter.FieldChooserCommands.ToggleVisibility == command)
			{
				global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldFromCommandInfo = this.GetFieldFromCommandInfo(commandInfo, true);
				if (fieldFromCommandInfo != null)
				{
					return true;
				}
			}
			else if (global::Infragistics.Windows.DataPresenter.FieldChooserCommands.Stop == command && base.IsMouseCaptureWithin)
			{
				return true;
			}
			return false;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0004DABC File Offset: 0x0004BCBC
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserStates fieldChooserStates = (global::Infragistics.Windows.DataPresenter.FieldChooserStates)0L;
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry selectedField = this.SelectedField;
			if (selectedField != null)
			{
				fieldChooserStates |= global::Infragistics.Windows.DataPresenter.FieldChooserStates.ItemSelected;
				if (selectedField.IsVisible)
				{
					fieldChooserStates |= global::Infragistics.Windows.DataPresenter.FieldChooserStates.SelectedItemVisible;
				}
			}
			if (this.IsDraggingItem)
			{
				fieldChooserStates |= global::Infragistics.Windows.DataPresenter.FieldChooserStates.IsDraggingItem;
			}
			return (long)(fieldChooserStates & (global::Infragistics.Windows.DataPresenter.FieldChooserStates)statesToQuery);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x04000707 RID: 1799
		private global::Infragistics.Windows.DataPresenter.FieldDragManager _fieldDragManager;

		// Token: 0x04000708 RID: 1800
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker> _pvtTrackers;

		// Token: 0x04000709 RID: 1801
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> _currentGroupFields;

		// Token: 0x0400070A RID: 1802
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> _currentFieldsObservableList;

		// Token: 0x0400070B RID: 1803
		private bool _settingAllCurrentFieldsVisible;

		// Token: 0x0400070C RID: 1804
		private bool _processingAllCurrentFieldsVisiblePropChange;

		// Token: 0x0400070D RID: 1805
		private bool _pendingReInitializeCurrentFields;

		// Token: 0x0400070E RID: 1806
		public static readonly global::System.Windows.DependencyProperty AllCurrentFieldsVisibleProperty = global::System.Windows.DependencyProperty.Register("AllCurrentFieldsVisible", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnAllCurrentFieldsVisibleChanged)));

		// Token: 0x0400070F RID: 1807
		public static readonly global::System.Windows.DependencyProperty CurrentFieldGroupProperty = global::System.Windows.DependencyProperty.Register("CurrentFieldGroup", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserGroup), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnCurrentFieldGroupChanged)));

		// Token: 0x04000710 RID: 1808
		private static readonly global::System.Windows.DependencyPropertyKey CurrentFieldsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CurrentFields", typeof(global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000711 RID: 1809
		public static readonly global::System.Windows.DependencyProperty CurrentFieldsProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldsPropertyKey.DependencyProperty;

		// Token: 0x04000712 RID: 1810
		public static readonly global::System.Windows.DependencyProperty DataPresenterProperty = global::System.Windows.DependencyProperty.Register("DataPresenter", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnDataPresenterChanged)));

		// Token: 0x04000713 RID: 1811
		private global::System.Windows.ResourceDictionary _lastDPResources;

		// Token: 0x04000714 RID: 1812
		private global::System.Collections.ObjectModel.Collection<global::System.Windows.ResourceDictionary> _lastFCMergedDictionaries;

		// Token: 0x04000715 RID: 1813
		public static readonly global::System.Windows.DependencyProperty DisplayHiddenFieldsOnlyProperty = global::System.Windows.DependencyProperty.Register("DisplayHiddenFieldsOnly", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnDisplayHiddenFieldsOnlyChanged)));

		// Token: 0x04000716 RID: 1814
		public static readonly global::System.Windows.DependencyProperty FieldDisplayOrderProperty = global::System.Windows.DependencyProperty.Register("FieldDisplayOrder", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder.Alphabetical, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldDisplayOrderChanged)));

		// Token: 0x04000717 RID: 1815
		public static readonly global::System.Windows.DependencyProperty FieldDisplayOrderComparerProperty = global::System.Windows.DependencyProperty.Register("FieldDisplayOrderComparer", typeof(global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldDisplayOrderComparerChanged)));

		// Token: 0x04000718 RID: 1816
		private static readonly global::System.Windows.DependencyPropertyKey FieldFiltersPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldFilters", typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldFiltersChanged)));

		// Token: 0x04000719 RID: 1817
		public static readonly global::System.Windows.DependencyProperty FieldFiltersProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.FieldFiltersPropertyKey.DependencyProperty;

		// Token: 0x0400071A RID: 1818
		private static readonly global::System.Windows.DependencyPropertyKey FieldGroupsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldGroups", typeof(global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldGroupsChanged)));

		// Token: 0x0400071B RID: 1819
		public static readonly global::System.Windows.DependencyProperty FieldGroupsProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupsPropertyKey.DependencyProperty;

		// Token: 0x0400071C RID: 1820
		public static readonly global::System.Windows.DependencyProperty FieldGroupSelectorVisibilityProperty = global::System.Windows.DependencyProperty.Register("FieldGroupSelectorVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldGroupSelectorVisibilityResolvedChanged)));

		// Token: 0x0400071D RID: 1821
		private static readonly global::System.Windows.DependencyPropertyKey FieldGroupSelectorVisibilityResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldGroupSelectorVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x0400071E RID: 1822
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty FieldGroupSelectorVisibilityResolvedProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400071F RID: 1823
		private static readonly global::System.Windows.DependencyPropertyKey IsDragItemOverPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDragItemOver", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000720 RID: 1824
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty IsDragItemOverProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverPropertyKey.DependencyProperty;

		// Token: 0x04000721 RID: 1825
		private static readonly global::System.Windows.DependencyPropertyKey IsDraggingItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDraggingItem", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000722 RID: 1826
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty IsDraggingItemProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemPropertyKey.DependencyProperty;

		// Token: 0x04000723 RID: 1827
		private static readonly global::System.Windows.DependencyPropertyKey IsDraggingItemFromDataPresenterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDraggingItemFromDataPresenter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000724 RID: 1828
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty IsDraggingItemFromDataPresenterProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemFromDataPresenterPropertyKey.DependencyProperty;

		// Token: 0x04000725 RID: 1829
		public static readonly global::System.Windows.DependencyProperty SelectedFieldProperty = global::System.Windows.DependencyProperty.Register("SelectedField", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserEntry), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnSelectedFieldChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnCoerceSelectedField)));

		// Token: 0x02000128 RID: 296
		private class FieldComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>
		{
			// Token: 0x060011AB RID: 4523 RVA: 0x0004DB01 File Offset: 0x0004BD01
			internal FieldComparer(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
			{
				this._fieldChooser = fieldChooser;
				this._displayOrder = fieldChooser.FieldDisplayOrder;
				this._customComparer = fieldChooser.FieldDisplayOrderComparer;
			}

			// Token: 0x060011AC RID: 4524 RVA: 0x0004DB28 File Offset: 0x0004BD28
			public int Compare(global::Infragistics.Windows.DataPresenter.FieldChooserEntry x, global::Infragistics.Windows.DataPresenter.FieldChooserEntry y)
			{
				global::Infragistics.Windows.DataPresenter.Field field = x.Field;
				global::Infragistics.Windows.DataPresenter.Field field2 = y.Field;
				if (this._customComparer != null)
				{
					return this._customComparer.Compare(field, field2);
				}
				if (global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder.SameAsDataPresenter == this._displayOrder)
				{
					global::Infragistics.Windows.DataPresenter.FieldPosition actualPosition = field.ActualPosition;
					global::Infragistics.Windows.DataPresenter.FieldPosition actualPosition2 = field2.ActualPosition;
					int num = actualPosition.Row.CompareTo(actualPosition2.Row);
					if (num == 0)
					{
						num = actualPosition.Column.CompareTo(actualPosition2.Column);
					}
					if (num == 0 && field.IsVisibleInCellArea != field2.IsVisibleInCellArea)
					{
						num = ((!field.IsVisibleInCellArea) ? -1 : 1);
					}
					if (num == 0)
					{
						num = field.IndexForCompare.CompareTo(field2.IndexForCompare);
					}
					return num;
				}
				string xx = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(field.Label, field.Name);
				string yy = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(field2.Label, field2.Name);
				return global::Infragistics.Windows.DataPresenter.GridUtilities.Compare(xx, yy, false);
			}

			// Token: 0x04000726 RID: 1830
			private global::Infragistics.Windows.DataPresenter.FieldChooser _fieldChooser;

			// Token: 0x04000727 RID: 1831
			private global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder _displayOrder;

			// Token: 0x04000728 RID: 1832
			private global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> _customComparer;
		}
	}
}
