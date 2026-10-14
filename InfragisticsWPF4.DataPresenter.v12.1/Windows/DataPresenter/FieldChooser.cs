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
	// Token: 0x0200010B RID: 267
	[global::System.Windows.TemplatePart(Name = "PART_FieldsListBox", Type = typeof(global::System.Windows.Controls.ListBox))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FieldChooser : global::Infragistics.Windows.Controls.IGControlBase, global::Infragistics.Windows.Commands.ICommandHost
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x0003BEF4 File Offset: 0x0003A0F4
		static FieldChooser()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldChooser)));
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0003C29C File Offset: 0x0003A49C
		public FieldChooser()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldFiltersPropertyKey, new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>());
			this._pvtTrackers = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>();
			global::Infragistics.Windows.Internal.PropertyValueTracker item = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "DataPresenter.FieldLayouts.Count", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.InitializeFieldGroups), true);
			this._pvtTrackers.Add(item);
			item = new global::Infragistics.Windows.Internal.PropertyValueTracker(this, "CurrentFieldGroup.FieldLayout.Fields.Version", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.ReInitializeCurrentFields), true);
			this._pvtTrackers.Add(item);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0003C314 File Offset: 0x0003A514
		protected internal override global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.FieldChooserCommands.Instance;
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0003C31C File Offset: 0x0003A51C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::System.Windows.Controls.ListBox listBox = base.GetTemplateChild("PART_FieldsListBox") as global::System.Windows.Controls.ListBox;
			if (listBox != null)
			{
				global::System.Windows.Controls.ScrollViewer.SetPanningMode(listBox, global::System.Windows.Controls.PanningMode.None);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0003C34A File Offset: 0x0003A54A
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnDragEnd(e, true);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0003C368 File Offset: 0x0003A568
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnMouseMove(e);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0003C385 File Offset: 0x0003A585
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnDragEnd(e, false);
				base.ReleaseMouseCapture();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0003C3A9 File Offset: 0x0003A5A9
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x0003C3BB File Offset: 0x0003A5BB
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000E04 RID: 3588 RVA: 0x0003C3D0 File Offset: 0x0003A5D0
		private static void OnAllCurrentFieldsVisibleChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			bool? flag = (bool?)e.NewValue;
			if (!fieldChooser._settingAllCurrentFieldsVisible)
			{
				fieldChooser.SyncWithAllCurrentFieldsVisible();
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0003C3FF File Offset: 0x0003A5FF
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x0003C411 File Offset: 0x0003A611
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000E07 RID: 3591 RVA: 0x0003C420 File Offset: 0x0003A620
		private static void OnCurrentFieldGroupChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.InitializeCurrentFields();
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0003C43A File Offset: 0x0003A63A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> CurrentFields
		{
			get
			{
				return (global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldsProperty);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0003C44C File Offset: 0x0003A64C
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0003C45E File Offset: 0x0003A65E
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

		// Token: 0x06000E0B RID: 3595 RVA: 0x0003C46C File Offset: 0x0003A66C
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

		// Token: 0x06000E0C RID: 3596 RVA: 0x0003C4EC File Offset: 0x0003A6EC
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0003C541 File Offset: 0x0003A741
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0003C553 File Offset: 0x0003A753
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

		// Token: 0x06000E0F RID: 3599 RVA: 0x0003C568 File Offset: 0x0003A768
		private static void OnDisplayHiddenFieldsOnlyChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.ReInitializeCurrentFields();
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0003C582 File Offset: 0x0003A782
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeDisplayHiddenFieldsOnly()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldChooser.DisplayHiddenFieldsOnlyProperty, this);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0003C58F File Offset: 0x0003A78F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayHiddenFieldsOnly()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldChooser.DisplayHiddenFieldsOnlyProperty);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0003C59C File Offset: 0x0003A79C
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x0003C5AE File Offset: 0x0003A7AE
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

		// Token: 0x06000E14 RID: 3604 RVA: 0x0003C5C4 File Offset: 0x0003A7C4
		private static void OnFieldDisplayOrderChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.ReInitializeCurrentFields();
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0003C5DE File Offset: 0x0003A7DE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldDisplayOrder()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderProperty, this);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0003C5EB File Offset: 0x0003A7EB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldDisplayOrder()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldDisplayOrderProperty);
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x0003C60A File Offset: 0x0003A80A
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

		// Token: 0x06000E19 RID: 3609 RVA: 0x0003C618 File Offset: 0x0003A818
		private static void OnFieldDisplayOrderComparerChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.ReInitializeCurrentFields();
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0003C632 File Offset: 0x0003A832
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter> FieldFilters
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldFiltersProperty);
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0003C644 File Offset: 0x0003A844
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

		// Token: 0x06000E1C RID: 3612 RVA: 0x0003C69C File Offset: 0x0003A89C
		private void OnFieldFilters_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InitializeFieldGroups();
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0003C6A4 File Offset: 0x0003A8A4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> FieldGroups
		{
			get
			{
				return (global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupsProperty);
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0003C6B8 File Offset: 0x0003A8B8
		private static void OnFieldGroupsChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.InitializeCurrentGroup();
			fieldChooser.InitializeFieldGroupSelectorVisibilityResolved();
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x0003C6EA File Offset: 0x0003A8EA
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

		// Token: 0x06000E21 RID: 3617 RVA: 0x0003C700 File Offset: 0x0003A900
		private static void OnFieldGroupSelectorVisibilityResolvedChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = (global::Infragistics.Windows.DataPresenter.FieldChooser)dependencyObject;
			fieldChooser.InitializeFieldGroupSelectorVisibilityResolved();
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0003C71A File Offset: 0x0003A91A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldGroupSelectorVisibility()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityProperty, this);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0003C727 File Offset: 0x0003A927
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetDisplayFieldLayoutSelector()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityProperty);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0003C734 File Offset: 0x0003A934
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility FieldGroupSelectorVisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityResolvedProperty);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0003C746 File Offset: 0x0003A946
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDragItemOver
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverProperty);
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0003C758 File Offset: 0x0003A958
		internal void InternalSetIsDragItemOver(bool value)
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0003C76B File Offset: 0x0003A96B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDraggingItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemProperty);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0003C77D File Offset: 0x0003A97D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDraggingItemFromDataPresenter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemFromDataPresenterProperty);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0003C78F File Offset: 0x0003A98F
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x0003C7A1 File Offset: 0x0003A9A1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000E2B RID: 3627 RVA: 0x0003C7B0 File Offset: 0x0003A9B0
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

		// Token: 0x06000E2C RID: 3628 RVA: 0x0003C7EC File Offset: 0x0003A9EC
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

		// Token: 0x06000E2D RID: 3629 RVA: 0x0003C82D File Offset: 0x0003AA2D
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommand(commandWrapper.Command);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0003C849 File Offset: 0x0003AA49
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommand(command, null);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0003C853 File Offset: 0x0003AA53
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			return this.ExecuteCommandImpl(command, parameter);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0003C860 File Offset: 0x0003AA60
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

		// Token: 0x06000E31 RID: 3633 RVA: 0x0003C8CC File Offset: 0x0003AACC
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

		// Token: 0x06000E32 RID: 3634 RVA: 0x0003C970 File Offset: 0x0003AB70
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

		// Token: 0x06000E33 RID: 3635 RVA: 0x0003C9E8 File Offset: 0x0003ABE8
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command, commandParameter, null));
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0003C9F8 File Offset: 0x0003ABF8
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

		// Token: 0x06000E35 RID: 3637 RVA: 0x0003CA54 File Offset: 0x0003AC54
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

		// Token: 0x06000E36 RID: 3638 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
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

		// Token: 0x06000E37 RID: 3639 RVA: 0x0003CB24 File Offset: 0x0003AD24
		private void InitializeCurrentFields()
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup currentFieldGroup = this.CurrentFieldGroup;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> fieldsList = (currentFieldGroup != null) ? this.CreateFieldEntries(currentFieldGroup) : null;
			this.InitializeCurrentFieldsHelper(fieldsList);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0003CB50 File Offset: 0x0003AD50
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

		// Token: 0x06000E39 RID: 3641 RVA: 0x0003CBF0 File Offset: 0x0003ADF0
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

		// Token: 0x06000E3A RID: 3642 RVA: 0x0003CC58 File Offset: 0x0003AE58
		private void InitializeFieldGroups()
		{
			global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> list = this.CreateFieldGroups();
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> value = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>(list);
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupsPropertyKey, value);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0003CC80 File Offset: 0x0003AE80
		private void InitializeFieldGroupSelectorVisibilityResolved()
		{
			global::System.Windows.Visibility? fieldGroupSelectorVisibility = this.FieldGroupSelectorVisibility;
			if (fieldGroupSelectorVisibility == null)
			{
				fieldGroupSelectorVisibility = new global::System.Windows.Visibility?((this.FieldGroups != null && 1 == this.FieldGroups.Count) ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityResolvedPropertyKey, fieldGroupSelectorVisibility);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0003CCD0 File Offset: 0x0003AED0
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

		// Token: 0x06000E3D RID: 3645 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		private bool IsGroupValid(global::Infragistics.Windows.DataPresenter.FieldChooserGroup group)
		{
			global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup> fieldGroups = this.FieldGroups;
			return fieldGroups != null && fieldGroups.IndexOf(group) >= 0;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0003CD32 File Offset: 0x0003AF32
		internal void OnFieldVisibilityChanged(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this.DisplayHiddenFieldsOnly)
			{
				this.InitializeCurrentFieldsHelper(this._currentGroupFields);
				return;
			}
			this.SyncAllCurrentFieldsVisible();
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003CD4F File Offset: 0x0003AF4F
		internal void ReInitializeCurrentFields()
		{
			this.InitializeCurrentFields();
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003CD58 File Offset: 0x0003AF58
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

		// Token: 0x06000E41 RID: 3649 RVA: 0x0003CD9B File Offset: 0x0003AF9B
		private void ReInitializeCurrentFieldsAsyncCallback()
		{
			this._pendingReInitializeCurrentFields = false;
			this.ReInitializeCurrentFields();
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		internal void SelectFieldHelper(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry = this.FindFieldChooserEntry(field);
			if (fieldChooserEntry != null)
			{
				this.SelectedField = fieldChooserEntry;
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003CDCC File Offset: 0x0003AFCC
		internal void SetFieldDragManagerHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager fieldDragManager)
		{
			this._fieldDragManager = fieldDragManager;
			bool value = null != this._fieldDragManager;
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003CE00 File Offset: 0x0003B000
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

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003CE9C File Offset: 0x0003B09C
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
					foreach (global::Infragistics.Windows.DataPresenter.FieldChooserEntry fieldChooserEntry in list)
					{
						fieldChooserEntry.IsVisible = allCurrentFieldsVisible.Value;
					}
				}
			}
			finally
			{
				this._processingAllCurrentFieldsVisiblePropChange = false;
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003CF3C File Offset: 0x0003B13C
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

		// Token: 0x06000E47 RID: 3655 RVA: 0x0003CF84 File Offset: 0x0003B184
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

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
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

		// Token: 0x06000E49 RID: 3657 RVA: 0x0003D000 File Offset: 0x0003B200
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x04000568 RID: 1384
		private global::Infragistics.Windows.DataPresenter.FieldDragManager _fieldDragManager;

		// Token: 0x04000569 RID: 1385
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker> _pvtTrackers;

		// Token: 0x0400056A RID: 1386
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> _currentGroupFields;

		// Token: 0x0400056B RID: 1387
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry> _currentFieldsObservableList;

		// Token: 0x0400056C RID: 1388
		private bool _settingAllCurrentFieldsVisible;

		// Token: 0x0400056D RID: 1389
		private bool _processingAllCurrentFieldsVisiblePropChange;

		// Token: 0x0400056E RID: 1390
		private bool _pendingReInitializeCurrentFields;

		// Token: 0x0400056F RID: 1391
		public static readonly global::System.Windows.DependencyProperty AllCurrentFieldsVisibleProperty = global::System.Windows.DependencyProperty.Register("AllCurrentFieldsVisible", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnAllCurrentFieldsVisibleChanged)));

		// Token: 0x04000570 RID: 1392
		public static readonly global::System.Windows.DependencyProperty CurrentFieldGroupProperty = global::System.Windows.DependencyProperty.Register("CurrentFieldGroup", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserGroup), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnCurrentFieldGroupChanged)));

		// Token: 0x04000571 RID: 1393
		private static readonly global::System.Windows.DependencyPropertyKey CurrentFieldsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CurrentFields", typeof(global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000572 RID: 1394
		public static readonly global::System.Windows.DependencyProperty CurrentFieldsProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.CurrentFieldsPropertyKey.DependencyProperty;

		// Token: 0x04000573 RID: 1395
		public static readonly global::System.Windows.DependencyProperty DataPresenterProperty = global::System.Windows.DependencyProperty.Register("DataPresenter", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnDataPresenterChanged)));

		// Token: 0x04000574 RID: 1396
		private global::System.Windows.ResourceDictionary _lastDPResources;

		// Token: 0x04000575 RID: 1397
		private global::System.Collections.ObjectModel.Collection<global::System.Windows.ResourceDictionary> _lastFCMergedDictionaries;

		// Token: 0x04000576 RID: 1398
		public static readonly global::System.Windows.DependencyProperty DisplayHiddenFieldsOnlyProperty = global::System.Windows.DependencyProperty.Register("DisplayHiddenFieldsOnly", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnDisplayHiddenFieldsOnlyChanged)));

		// Token: 0x04000577 RID: 1399
		public static readonly global::System.Windows.DependencyProperty FieldDisplayOrderProperty = global::System.Windows.DependencyProperty.Register("FieldDisplayOrder", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder.Alphabetical, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldDisplayOrderChanged)));

		// Token: 0x04000578 RID: 1400
		public static readonly global::System.Windows.DependencyProperty FieldDisplayOrderComparerProperty = global::System.Windows.DependencyProperty.Register("FieldDisplayOrderComparer", typeof(global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldDisplayOrderComparerChanged)));

		// Token: 0x04000579 RID: 1401
		private static readonly global::System.Windows.DependencyPropertyKey FieldFiltersPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldFilters", typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserFilter>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldFiltersChanged)));

		// Token: 0x0400057A RID: 1402
		public static readonly global::System.Windows.DependencyProperty FieldFiltersProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.FieldFiltersPropertyKey.DependencyProperty;

		// Token: 0x0400057B RID: 1403
		private static readonly global::System.Windows.DependencyPropertyKey FieldGroupsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldGroups", typeof(global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldChooserGroup>), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldGroupsChanged)));

		// Token: 0x0400057C RID: 1404
		public static readonly global::System.Windows.DependencyProperty FieldGroupsProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupsPropertyKey.DependencyProperty;

		// Token: 0x0400057D RID: 1405
		public static readonly global::System.Windows.DependencyProperty FieldGroupSelectorVisibilityProperty = global::System.Windows.DependencyProperty.Register("FieldGroupSelectorVisibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnFieldGroupSelectorVisibilityResolvedChanged)));

		// Token: 0x0400057E RID: 1406
		private static readonly global::System.Windows.DependencyPropertyKey FieldGroupSelectorVisibilityResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldGroupSelectorVisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x0400057F RID: 1407
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty FieldGroupSelectorVisibilityResolvedProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.FieldGroupSelectorVisibilityResolvedPropertyKey.DependencyProperty;

		// Token: 0x04000580 RID: 1408
		private static readonly global::System.Windows.DependencyPropertyKey IsDragItemOverPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDragItemOver", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000581 RID: 1409
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty IsDragItemOverProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.IsDragItemOverPropertyKey.DependencyProperty;

		// Token: 0x04000582 RID: 1410
		private static readonly global::System.Windows.DependencyPropertyKey IsDraggingItemPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDraggingItem", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000583 RID: 1411
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty IsDraggingItemProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemPropertyKey.DependencyProperty;

		// Token: 0x04000584 RID: 1412
		private static readonly global::System.Windows.DependencyPropertyKey IsDraggingItemFromDataPresenterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDraggingItemFromDataPresenter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000585 RID: 1413
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static readonly global::System.Windows.DependencyProperty IsDraggingItemFromDataPresenterProperty = global::Infragistics.Windows.DataPresenter.FieldChooser.IsDraggingItemFromDataPresenterPropertyKey.DependencyProperty;

		// Token: 0x04000586 RID: 1414
		public static readonly global::System.Windows.DependencyProperty SelectedFieldProperty = global::System.Windows.DependencyProperty.Register("SelectedField", typeof(global::Infragistics.Windows.DataPresenter.FieldChooserEntry), typeof(global::Infragistics.Windows.DataPresenter.FieldChooser), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnSelectedFieldChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.FieldChooser.OnCoerceSelectedField)));

		// Token: 0x0200010C RID: 268
		private class FieldComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.FieldChooserEntry>
		{
			// Token: 0x06000E4A RID: 3658 RVA: 0x0003D009 File Offset: 0x0003B209
			internal FieldComparer(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
			{
				this._fieldChooser = fieldChooser;
				this._displayOrder = fieldChooser.FieldDisplayOrder;
				this._customComparer = fieldChooser.FieldDisplayOrderComparer;
			}

			// Token: 0x06000E4B RID: 3659 RVA: 0x0003D030 File Offset: 0x0003B230
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
						num = field.Index.CompareTo(field2.Index);
					}
					return num;
				}
				string xx = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(field.Label, field.Name);
				string yy = global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(field2.Label, field2.Name);
				return global::Infragistics.Windows.DataPresenter.GridUtilities.Compare(xx, yy, false);
			}

			// Token: 0x04000587 RID: 1415
			private global::Infragistics.Windows.DataPresenter.FieldChooser _fieldChooser;

			// Token: 0x04000588 RID: 1416
			private global::Infragistics.Windows.DataPresenter.FieldChooserDisplayOrder _displayOrder;

			// Token: 0x04000589 RID: 1417
			private global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Field> _customComparer;
		}
	}
}
