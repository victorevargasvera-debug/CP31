using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000103 RID: 259
	[global::System.Windows.StyleTypedProperty(Property = "FieldLayoutDescriptionTemplate", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	public class FieldLayoutGroupByInfo : global::System.Windows.DependencyObject
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0003B1D6 File Offset: 0x000393D6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldLayout)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutProperty);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0003B1E8 File Offset: 0x000393E8
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x0003B1FA File Offset: 0x000393FA
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate FieldLayoutDescriptionTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionTemplateProperty, value);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0003B208 File Offset: 0x00039408
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FieldLayoutDescriptionVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionVisibilityProperty);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0003B21A File Offset: 0x0003941A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.GroupByFieldCollection GroupByFields
		{
			get
			{
				if (this._groupByFields == null)
				{
					this._groupByFields = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.Field>();
					this._readOnlyGroupByFields = new global::Infragistics.Windows.DataPresenter.GroupByFieldCollection(this._groupByFields);
				}
				return this._readOnlyGroupByFields;
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003B248 File Offset: 0x00039448
		internal void InitializeFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fl, bool displayDescription)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (displayDescription)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionVisibilityPropertyKey, global::Infragistics.KnownBoxes.VisibilityVisibleBox);
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionVisibilityPropertyKey);
			}
			if (fl == fieldLayout)
			{
				return;
			}
			if (this._groupByFields != null)
			{
				this._groupByFields.Clear();
			}
			this._recordIndentVersionTracker = null;
			this._fieldLayoutVersionTracker = null;
			if (fl == null)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutPropertyKey);
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutPropertyKey, fl);
			this._recordIndentVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, "RecordIndentVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnGroupByVersionChanged));
			this._fieldLayoutVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldLayoutVersionChanged));
			this.SynchronizeGroupByFields(false);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0003B300 File Offset: 0x00039500
		internal void SynchronizeGroupByFields(bool reload)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (fieldLayout != null)
			{
				int countOfGroupByFields = fieldLayout.SortedFields.CountOfGroupByFields;
				for (int i = 0; i < countOfGroupByFields; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldLayout.SortedFields[i].Field;
					if (field != null)
					{
						list.Add(field);
					}
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this.GroupByFields)
			{
				field2.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey);
				field2.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey);
			}
			bool flag = false;
			if (reload && this._groupByFields.Count > 0)
			{
				flag = true;
				this._groupByFields.BeginUpdate();
				this._groupByFields.Clear();
			}
			try
			{
				bool flag2 = false;
				int count = list.Count;
				if (count == this.GroupByFields.Count)
				{
					flag2 = true;
					for (int j = 0; j < count; j++)
					{
						if (list[j] != this._groupByFields[j])
						{
							flag2 = false;
							break;
						}
					}
				}
				for (int k = 0; k < count; k++)
				{
					global::Infragistics.Windows.DataPresenter.Field field3 = list[k];
					if (k == 0)
					{
						field3.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						field3.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsFirstInListPropertyKey);
					}
					if (k == count - 1)
					{
						field3.SetValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						field3.ClearValue(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.IsLastInListPropertyKey);
					}
				}
				if (!flag2)
				{
					if (!flag)
					{
						this._groupByFields.BeginUpdate();
						flag = true;
					}
					this._groupByFields.Clear();
					this._groupByFields.AddRange(list);
				}
			}
			finally
			{
				if (flag)
				{
					this._groupByFields.EndUpdate();
				}
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0003B4D4 File Offset: 0x000396D4
		private void OnFieldLayoutVersionChanged()
		{
			this.SynchronizeGroupByFields(true);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0003B4DD File Offset: 0x000396DD
		private void OnGroupByVersionChanged()
		{
			this.SynchronizeGroupByFields(false);
		}

		// Token: 0x0400054C RID: 1356
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.Field> _groupByFields;

		// Token: 0x0400054D RID: 1357
		private global::Infragistics.Windows.DataPresenter.GroupByFieldCollection _readOnlyGroupByFields;

		// Token: 0x0400054E RID: 1358
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordIndentVersionTracker;

		// Token: 0x0400054F RID: 1359
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldLayoutVersionTracker;

		// Token: 0x04000550 RID: 1360
		private static readonly global::System.Windows.DependencyPropertyKey FieldLayoutPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000551 RID: 1361
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutPropertyKey.DependencyProperty;

		// Token: 0x04000552 RID: 1362
		public static readonly global::System.Windows.DependencyProperty FieldLayoutDescriptionTemplateProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutDescriptionTemplateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo));

		// Token: 0x04000553 RID: 1363
		private static readonly global::System.Windows.DependencyPropertyKey FieldLayoutDescriptionVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLayoutDescriptionVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x04000554 RID: 1364
		public static readonly global::System.Windows.DependencyProperty FieldLayoutDescriptionVisibilityProperty = global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionVisibilityPropertyKey.DependencyProperty;
	}
}
