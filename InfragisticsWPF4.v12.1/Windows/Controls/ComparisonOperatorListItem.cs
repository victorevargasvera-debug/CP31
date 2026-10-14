using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Infragistics.Shared;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000140 RID: 320
	public class ComparisonOperatorListItem : global::System.Windows.DependencyObject
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x00023344 File Offset: 0x00021544
		public ComparisonOperatorListItem(global::Infragistics.Windows.Controls.ComparisonOperator value)
		{
			this._operator = value;
			this._dynamicString = global::Infragistics.Windows.Resources.GetDynamicResourceString("ComparisonOperator_" + this._operator.ToString());
			this._dynamicStringTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._dynamicString, "Value", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.UpdateDisplayText));
			this.UpdateDisplayText();
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000233AB File Offset: 0x000215AB
		public ComparisonOperatorListItem() : this(global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000233B4 File Offset: 0x000215B4
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000233BC File Offset: 0x000215BC
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x000233CE File Offset: 0x000215CE
		public global::System.Windows.Media.ImageSource Image
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorListItem.ImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorListItem.ImageProperty, value);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000233DC File Offset: 0x000215DC
		[global::System.ComponentModel.Bindable(true)]
		public string Description
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorListItem.DescriptionProperty);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000233EE File Offset: 0x000215EE
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Controls.ComparisonOperator Operator
		{
			get
			{
				return this._operator;
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000233F6 File Offset: 0x000215F6
		private void UpdateDisplayText()
		{
			base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorListItem.DescriptionPropertyKey, this._dynamicString.Value);
		}

		// Token: 0x040004DC RID: 1244
		private global::Infragistics.Windows.Controls.ComparisonOperator _operator;

		// Token: 0x040004DD RID: 1245
		private global::Infragistics.Shared.DynamicResourceString _dynamicString;

		// Token: 0x040004DE RID: 1246
		private global::Infragistics.Windows.Internal.PropertyValueTracker _dynamicStringTracker;

		// Token: 0x040004DF RID: 1247
		public static readonly global::System.Windows.DependencyProperty ImageProperty = global::System.Windows.DependencyProperty.Register("Image", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040004E0 RID: 1248
		private static readonly global::System.Windows.DependencyPropertyKey DescriptionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Description", typeof(string), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040004E1 RID: 1249
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty = global::Infragistics.Windows.Controls.ComparisonOperatorListItem.DescriptionPropertyKey.DependencyProperty;
	}
}
