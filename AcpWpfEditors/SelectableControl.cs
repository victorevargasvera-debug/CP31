using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000010 RID: 16
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SelectableControl : global::System.Windows.Controls.Control
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000116EC File Offset: 0x0000F8EC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelected
		{
			get
			{
				short num = (short)1440145134;
				short num2 = num;
				num = (short)1925045998;
				switch (num2 == num)
				{
				}
				num = (short)968687616;
				short num3 = num;
				num = (short)1693646849;
				if (num != 0)
				{
				}
				num = (short)965083136;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SelectableControl.IsSelectedProperty);
			}
			set
			{
				short num = (short)1711011605;
				short num2 = num;
				num = (short)1672607509;
				switch (num2 == num)
				{
				}
				num = (short)1702232064;
				short num3 = num;
				num = (short)145096705;
				if (num != 0)
				{
				}
				num = (short)709558272;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SelectableControl.IsSelectedProperty, value);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00011864 File Offset: 0x0000FA64
		static SelectableControl()
		{
			short num = (short)1412572571;
			short num2 = num;
			num = (short)59450779;
			switch (num2 == num)
			{
			}
			num = (short)1189609472;
			short num3 = num;
			num = (short)1110441985;
			if (num != 0)
			{
			}
			num = (short)1009647616;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.SelectableControl.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::DevComponents.WpfEditors.SelectableControl), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SelectableControl.a)));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00011948 File Offset: 0x0000FB48
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)769113739;
			short num2 = num;
			num = (short)1250737803;
			switch (num2 == num)
			{
			}
			num = (short)1924071424;
			short num3 = num;
			num = (short)1373634560;
			if (num != 0)
			{
			}
			num = (short)1287258113;
			if (num != 0)
			{
			}
			(A_0 as global::DevComponents.WpfEditors.SelectableControl).OnIsSelectedChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00011A14 File Offset: 0x0000FC14
		protected virtual void OnIsSelectedChanged(bool oldValue, bool newValue)
		{
			if (newValue)
			{
				short num;
				for (;;)
				{
					num = (short)1706255417;
					short num2 = num;
					num = (short)2002019385;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_3C;
					}
				}
				IL_3C:
				num = (short)1963786241;
				if (num != 0)
				{
				}
				num = (short)1886912512;
				short num3 = num;
				num = (short)337641472;
				if (num != 0)
				{
				}
				this.OnSelected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.SelectedEvent, this));
				return;
			}
			this.OnUnselected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.UnselectedEvent, this));
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2110548466;
			short num2 = num;
			num = (short)22178290;
			switch (num2 == num)
			{
			}
			num = (short)590413824;
			short num3 = num;
			num = (short)1656684544;
			if (num != 0)
			{
			}
			num = (short)1775370241;
			if (num != 0)
			{
			}
			this.a(true, e);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00011B98 File Offset: 0x0000FD98
		protected virtual void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2098903081;
			short num2 = num;
			num = (short)1264171049;
			switch (num2 == num)
			{
			}
			num = (short)2023424000;
			short num3 = num;
			num = (short)142409729;
			if (num != 0)
			{
			}
			num = (short)677380096;
			if (num != 0)
			{
			}
			this.a(false, e);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00011C48 File Offset: 0x0000FE48
		private void a(bool A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)839032340;
			short num2 = num;
			num = (short)1239719444;
			switch (num2 == num)
			{
			}
			num = (short)1530855424;
			short num3 = num;
			num = (short)892862465;
			if (num != 0)
			{
			}
			num = (short)229769216;
			if (num != 0)
			{
			}
			base.RaiseEvent(A_1);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00011CF8 File Offset: 0x0000FEF8
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1631387649;
			if (num != 0)
			{
			}
			num = (short)1578011568;
			short num2 = num;
			num = (short)2070907824;
			switch (num2 == num)
			{
			default:
			{
				num = (short)428343296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)878968832;
			if (num != 0)
			{
			}
			this.IsSelected = true;
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;
	}
}
