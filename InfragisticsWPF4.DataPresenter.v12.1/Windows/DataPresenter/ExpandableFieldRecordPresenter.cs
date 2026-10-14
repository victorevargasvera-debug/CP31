using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000328 RID: 808
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpandableFieldRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x060026D3 RID: 9939 RVA: 0x000A96FC File Offset: 0x000A78FC
		static ExpandableFieldRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Top));
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000A97C0 File Offset: 0x000A79C0
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

		// Token: 0x060026D5 RID: 9941 RVA: 0x000A988C File Offset: 0x000A7A8C
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

		// Token: 0x060026D6 RID: 9942 RVA: 0x000A98B4 File Offset: 0x000A7AB4
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

		// Token: 0x060026D7 RID: 9943 RVA: 0x000A9900 File Offset: 0x000A7B00
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000A9965 File Offset: 0x000A7B65
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.HeaderVisibilityProperty);
			}
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x000A9978 File Offset: 0x000A7B78
		private void SetHeaderVisibility()
		{
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = base.Record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			if (expandableFieldRecord != null)
			{
				bool isHeaderVisible = expandableFieldRecord.IsHeaderVisible;
				base.SetValue(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.HeaderVisibilityPropertyKey, isHeaderVisible ? global::Infragistics.KnownBoxes.VisibilityVisibleBox : global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
			}
		}

		// Token: 0x04001269 RID: 4713
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x0400126A RID: 4714
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x0400126B RID: 4715
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x0400126C RID: 4716
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x0400126D RID: 4717
		private static readonly global::System.Windows.DependencyPropertyKey HeaderVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x0400126E RID: 4718
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter.HeaderVisibilityPropertyKey.DependencyProperty;
	}
}
