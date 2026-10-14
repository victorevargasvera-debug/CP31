using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter.Internal
{
	// Token: 0x02000316 RID: 790
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RecordListItemContainer : global::System.Windows.Controls.Decorator, global::Infragistics.Windows.DataPresenter.IRecordPresenterContainer
	{
		// Token: 0x060025D3 RID: 9683 RVA: 0x000A28F9 File Offset: 0x000A0AF9
		internal RecordListItemContainer()
		{
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000A2901 File Offset: 0x000A0B01
		internal void InitializeWithItem(global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter)
		{
			this.Child = recordPresenter;
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x000A290A File Offset: 0x000A0B0A
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x000A2914 File Offset: 0x000A0B14
		public override global::System.Windows.UIElement Child
		{
			get
			{
				return base.Child;
			}
			set
			{
				global::System.Windows.UIElement child = this.Child;
				if (child != value)
				{
					base.Child = value;
					if (value != null)
					{
						value.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
						global::System.Windows.Data.Binding binding = global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, global::System.Windows.Data.BindingMode.TwoWay, value);
						global::System.Windows.Data.Binding binding2 = global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.VerticalAlignmentProperty, global::System.Windows.Data.BindingMode.TwoWay, value);
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.FrameworkElement.HorizontalAlignmentProperty, binding);
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.FrameworkElement.VerticalAlignmentProperty, binding2);
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.TwoWay, value));
						return;
					}
					global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
				}
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000A2994 File Offset: 0x000A0B94
		public global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordListControl.GetRecordPresenterFromContainer(this.Child);
			}
		}
	}
}
