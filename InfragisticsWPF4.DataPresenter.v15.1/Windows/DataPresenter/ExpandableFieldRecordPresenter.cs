using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000369 RID: 873
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpandableFieldRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x06002A94 RID: 10900 RVA: 0x000BE098 File Offset: 0x000BC298
		static ExpandableFieldRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Top));
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x000BE15C File Offset: 0x000BC35C
		internal override global::System.Windows.Controls.ControlTemplate GetDefaultTemplateProperty(global::System.Windows.DependencyProperty templateProperty)
		{
			if (!global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplatesCached)
			{
				lock (typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter))
				{
					if (!global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplatesCached)
					{
						global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplatesCached = true;
						global::System.Windows.Style expandableFieldRecordPresenter = global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.ExpandableFieldRecordPresenter;
						if (expandableFieldRecordPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplate = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(expandableFieldRecordPresenter, global::System.Windows.Controls.Control.TemplateProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplateTabluar = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(expandableFieldRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplateCardView = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(expandableFieldRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
						}
					}
				}
			}
			if (templateProperty == global::System.Windows.Controls.Control.TemplateProperty)
			{
				return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplate;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplateTabluar;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.s_DefaultTemplateCardView;
			}
			return null;
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x000BE228 File Offset: 0x000BC428
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (base.IsClearingBindings)
			{
				return;
			}
			if (e.Property == global::Infragistics.Windows.DataPresenter.RecordPresenter.IsExpandedProperty)
			{
				this.SetHeaderVisibility();
			}
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000BE250 File Offset: 0x000BC450
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnRecordPropertyChanged(e);
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "IsExpanded"))
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = base.Record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				if (expandableFieldRecord != null && !expandableFieldRecord.HasVisibleChildren)
				{
					base.InvalidateGridViewPanelFlat();
				}
			}
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000BE29C File Offset: 0x000BC49C
		internal override void PrepareContainerForItem(object item, bool isUsedForHeaderOnly)
		{
			base.PrepareContainerForItem(item, isUsedForHeaderOnly);
			if (item == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = base.Record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			if (expandableFieldRecord != null)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath("ExpansionIndicatorVisibility", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = expandableFieldRecord;
				base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty, binding);
				this.SetHeaderVisibility();
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000BE301 File Offset: 0x000BC501
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.HeaderVisibilityProperty);
			}
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000BE314 File Offset: 0x000BC514
		private void SetHeaderVisibility()
		{
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = base.Record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			if (expandableFieldRecord != null)
			{
				bool isHeaderVisible = expandableFieldRecord.IsHeaderVisible;
				base.SetValue(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.HeaderVisibilityPropertyKey, isHeaderVisible ? global::Infragistics.KnownBoxes.VisibilityVisibleBox : global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
			}
		}

		// Token: 0x0400148C RID: 5260
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x0400148D RID: 5261
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x0400148E RID: 5262
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x0400148F RID: 5263
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x04001490 RID: 5264
		private static readonly global::System.Windows.DependencyPropertyKey HeaderVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04001491 RID: 5265
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.HeaderVisibilityPropertyKey.DependencyProperty;
	}
}
