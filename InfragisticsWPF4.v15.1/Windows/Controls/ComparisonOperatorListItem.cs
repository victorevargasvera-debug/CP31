using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Infragistics.Shared;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200015E RID: 350
	public class ComparisonOperatorListItem : global::System.Windows.DependencyObject
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x00026DEC File Offset: 0x00024FEC
		public ComparisonOperatorListItem(global::Infragistics.Windows.Controls.ComparisonOperator value)
		{
			this._operator = value;
			this._dynamicString = global::Infragistics.Windows.Resources.GetDynamicResourceString("ComparisonOperator_" + this._operator.ToString());
			this._dynamicStringTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._dynamicString, "Value", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.UpdateDisplayText));
			this.UpdateDisplayText();
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00026E53 File Offset: 0x00025053
		public ComparisonOperatorListItem() : this(global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00026E5C File Offset: 0x0002505C
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00026E64 File Offset: 0x00025064
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00026E76 File Offset: 0x00025076
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00026E84 File Offset: 0x00025084
		[global::System.ComponentModel.Bindable(true)]
		public string Description
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorListItem.DescriptionProperty);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00026E96 File Offset: 0x00025096
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.ComparisonOperator Operator
		{
			get
			{
				return this._operator;
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00026E9E File Offset: 0x0002509E
		private void UpdateDisplayText()
		{
			base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorListItem.DescriptionPropertyKey, this._dynamicString.Value);
		}

		// Token: 0x0400058E RID: 1422
		private global::Infragistics.Windows.Controls.ComparisonOperator _operator;

		// Token: 0x0400058F RID: 1423
		private global::Infragistics.Shared.DynamicResourceString _dynamicString;

		// Token: 0x04000590 RID: 1424
		private global::Infragistics.Windows.Internal.PropertyValueTracker _dynamicStringTracker;

		// Token: 0x04000591 RID: 1425
		public static readonly global::System.Windows.DependencyProperty ImageProperty = global::System.Windows.DependencyProperty.Register("Image", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000592 RID: 1426
		private static readonly global::System.Windows.DependencyPropertyKey DescriptionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Description", typeof(string), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000593 RID: 1427
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty = global::Infragistics.Windows.Controls.ComparisonOperatorListItem.DescriptionPropertyKey.DependencyProperty;
	}
}
