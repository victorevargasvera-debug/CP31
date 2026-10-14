using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011F RID: 287
	[global::System.Windows.StyleTypedProperty(Property = "FieldLayoutDescriptionTemplate", StyleTargetType = typeof(global::System.Windows.Controls.ContentControl))]
	public class FieldLayoutGroupByInfo : global::System.Windows.DependencyObject
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0004BC96 File Offset: 0x00049E96
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FieldLayout)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutProperty);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0004BCA8 File Offset: 0x00049EA8
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x0004BCBA File Offset: 0x00049EBA
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

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0004BCC8 File Offset: 0x00049EC8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility FieldLayoutDescriptionVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionVisibilityProperty);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0004BCDA File Offset: 0x00049EDA
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

		// Token: 0x0600111A RID: 4378 RVA: 0x0004BD08 File Offset: 0x00049F08
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

		// Token: 0x0600111B RID: 4379 RVA: 0x0004BDC0 File Offset: 0x00049FC0
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

		// Token: 0x0600111C RID: 4380 RVA: 0x0004BF94 File Offset: 0x0004A194
		private void OnFieldLayoutVersionChanged()
		{
			this.SynchronizeGroupByFields(true);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0004BF9D File Offset: 0x0004A19D
		private void OnGroupByVersionChanged()
		{
			this.SynchronizeGroupByFields(false);
		}

		// Token: 0x040006EB RID: 1771
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.Field> _groupByFields;

		// Token: 0x040006EC RID: 1772
		private global::Infragistics.Windows.DataPresenter.GroupByFieldCollection _readOnlyGroupByFields;

		// Token: 0x040006ED RID: 1773
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordIndentVersionTracker;

		// Token: 0x040006EE RID: 1774
		private global::Infragistics.Windows.Internal.PropertyValueTracker _fieldLayoutVersionTracker;

		// Token: 0x040006EF RID: 1775
		private static readonly global::System.Windows.DependencyPropertyKey FieldLayoutPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040006F0 RID: 1776
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutPropertyKey.DependencyProperty;

		// Token: 0x040006F1 RID: 1777
		public static readonly global::System.Windows.DependencyProperty FieldLayoutDescriptionTemplateProperty = global::Infragistics.Windows.DataPresenter.GroupByAreaMulti.FieldLayoutDescriptionTemplateProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo));

		// Token: 0x040006F2 RID: 1778
		private static readonly global::System.Windows.DependencyPropertyKey FieldLayoutDescriptionVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FieldLayoutDescriptionVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x040006F3 RID: 1779
		public static readonly global::System.Windows.DependencyProperty FieldLayoutDescriptionVisibilityProperty = global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo.FieldLayoutDescriptionVisibilityPropertyKey.DependencyProperty;
	}
}
