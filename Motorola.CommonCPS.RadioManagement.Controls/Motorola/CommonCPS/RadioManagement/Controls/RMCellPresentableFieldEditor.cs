using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000091 RID: 145
	public class RMCellPresentableFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00037E94 File Offset: 0x00036094
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00037F50 File Offset: 0x00036150
		public bool IsCellValuePresenter
		{
			get
			{
				short num = (short)341099043;
				short num2 = num;
				num = (short)285131299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1120731136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)960954369;
				if (num != 0)
				{
				}
				num = (short)1775697920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty);
			}
			set
			{
				short num = (short)1376351566;
				short num2 = num;
				num = (short)252081486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499384320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644087808;
				if (num != 0)
				{
				}
				num = (short)1087307777;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty, value);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0003800C File Offset: 0x0003620C
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F2;
				case 1:
				{
					num2 = (short)1368981504;
					short num3 = num2;
					rmcellPresentableFieldEditor.SetCellValuePresenterMode();
					num2 = (short)213843968;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					if (!(bool)A_1.NewValue)
					{
						return;
					}
					num2 = (short)1104572822;
					short num4 = num2;
					num2 = (short)1100050838;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)484769792;
						if (num2 != 0)
						{
						}
						num2 = (short)1907818497;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_F2:
			num2 = (short)1390280705;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			rmcellPresentableFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)A_0;
			num2 = (short)1753612290;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00038134 File Offset: 0x00036334
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000381F0 File Offset: 0x000363F0
		public bool IsShowingOnDataGrid
		{
			get
			{
				short num = (short)937002869;
				short num2 = num;
				num = (short)535136117;
				switch (num2 == num)
				{
				}
				num = (short)1301872641;
				if (num != 0)
				{
				}
				num = (short)989790208;
				if (num != 0)
				{
				}
				num = (short)1694498816;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsShowingOnDataGridProperty);
			}
			set
			{
				short num = (short)1615724923;
				short num2 = num;
				num = (short)915538299;
				switch (num2 == num)
				{
				}
				num = (short)1000800257;
				if (num != 0)
				{
				}
				num = (short)223674368;
				if (num != 0)
				{
				}
				num = (short)1140326400;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsShowingOnDataGridProperty, value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000382AC File Offset: 0x000364AC
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00038364 File Offset: 0x00036564
		public bool IsHideBorder
		{
			get
			{
				short num = (short)410522810;
				short num2 = num;
				num = (short)233247930;
				switch (num2 == num)
				{
				}
				num = (short)1285029889;
				if (num != 0)
				{
				}
				num = (short)2042167296;
				if (num != 0)
				{
				}
				num = (short)1676804096;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty);
			}
			set
			{
				short num = (short)1046284143;
				short num2 = num;
				num = (short)1287391087;
				switch (num2 == num)
				{
				}
				num = (short)968294401;
				if (num != 0)
				{
				}
				num = (short)129630208;
				if (num != 0)
				{
				}
				num = (short)1737424896;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty, value);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00038424 File Offset: 0x00036624
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					rmcellPresentableFieldEditor.HideBorder();
					num2 = (short)1345847296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1718419457;
					if (num2 != 0)
					{
					}
					if (!(bool)A_1.NewValue)
					{
						return;
					}
					num2 = (short)414089754;
					short num3 = num2;
					num2 = (short)340165146;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)665714688;
						if (num2 != 0)
						{
						}
						num2 = (short)1031798784;
						short num4 = num2;
						num2 = (short)2090532865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			rmcellPresentableFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)A_0;
			num2 = (short)1848573954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00038554 File Offset: 0x00036754
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00038610 File Offset: 0x00036810
		public bool IsPreviewModeSupport
		{
			get
			{
				short num = (short)196180879;
				short num2 = num;
				num = (short)2058779535;
				switch (num2 == num)
				{
				}
				num = (short)1986985985;
				if (num != 0)
				{
				}
				num = (short)1955004416;
				if (num != 0)
				{
				}
				num = (short)1458569216;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeSupportProperty);
			}
			set
			{
				short num = (short)1212886370;
				short num2 = num;
				num = (short)1837051234;
				switch (num2 == num)
				{
				}
				num = (short)1119092736;
				if (num != 0)
				{
				}
				num = (short)528220161;
				if (num != 0)
				{
				}
				num = (short)461701120;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeSupportProperty, value);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000369 RID: 873 RVA: 0x000386CC File Offset: 0x000368CC
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00038784 File Offset: 0x00036984
		public bool IsPreviewMode
		{
			get
			{
				short num = (short)1131477116;
				short num2 = num;
				num = (short)1531639932;
				switch (num2 == num)
				{
				}
				num = (short)227868673;
				if (num != 0)
				{
				}
				num = (short)1006632960;
				if (num != 0)
				{
				}
				num = (short)1305214976;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeProperty);
			}
			set
			{
				short num = (short)367222896;
				short num2 = num;
				num = (short)821911664;
				switch (num2 == num)
				{
				}
				num = (short)1843134464;
				if (num != 0)
				{
				}
				num = (short)1209794561;
				if (num != 0)
				{
				}
				num = (short)1870528512;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeProperty, value);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0003883C File Offset: 0x00036A3C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor rmcellPresentableFieldEditor;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					rmcellPresentableFieldEditor.SetPreviewMode();
					num2 = (short)2066612224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (!(bool)A_1.NewValue)
					{
						return;
					}
					num2 = (short)576592918;
					short num3 = num2;
					num2 = (short)2047286294;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)993263616;
						if (num2 != 0)
						{
						}
						num2 = (short)421593089;
						if (num2 != 0)
						{
						}
						num2 = (short)507445248;
						short num4 = num2;
						num2 = (short)632291329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			rmcellPresentableFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)A_0;
			num2 = (short)1131937794;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00038968 File Offset: 0x00036B68
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00038A20 File Offset: 0x00036C20
		public string ContentText
		{
			get
			{
				short num = (short)561321936;
				short num2 = num;
				num = (short)1504057296;
				switch (num2 == num)
				{
				}
				num = (short)844169216;
				if (num != 0)
				{
				}
				num = (short)341835777;
				if (num != 0)
				{
				}
				num = (short)1896939520;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.ContentTextProperty);
			}
			set
			{
				short num = (short)1869400138;
				short num2 = num;
				num = (short)962709578;
				switch (num2 == num)
				{
				}
				num = (short)676069376;
				if (num != 0)
				{
				}
				num = (short)1465778177;
				if (num != 0)
				{
				}
				num = (short)502005760;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.ContentTextProperty, value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00038AD4 File Offset: 0x00036CD4
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00038B90 File Offset: 0x00036D90
		public global::Infragistics.Windows.DataPresenter.FieldLength FieldWidth
		{
			get
			{
				short num = (short)1299629426;
				short num2 = num;
				num = (short)1577698674;
				switch (num2 == num)
				{
				}
				num = (short)758841345;
				if (num != 0)
				{
				}
				num = (short)1225457664;
				if (num != 0)
				{
				}
				num = (short)320602112;
				short num3 = num;
				return (global::Infragistics.Windows.DataPresenter.FieldLength)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.FieldWidthProperty);
			}
			set
			{
				short num = (short)795341084;
				short num2 = num;
				num = (short)1784475932;
				switch (num2 == num)
				{
				}
				num = (short)491126785;
				if (num != 0)
				{
				}
				num = (short)1858273280;
				if (num != 0)
				{
				}
				num = (short)353959936;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.FieldWidthProperty, value);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00038C4C File Offset: 0x00036E4C
		public virtual void SetPreviewMode()
		{
			int a_ = 13;
			short num = (short)629932033;
			if (num != 0)
			{
			}
			num = (short)1112381559;
			short num2 = num;
			num = (short)1955502199;
			switch (num2 == num)
			{
			}
			num = (short)1444675584;
			if (num != 0)
			{
			}
			num = (short)965672960;
			short num3 = num;
			global::System.Windows.FrameworkElement newItem = base.Content as global::System.Windows.FrameworkElement;
			base.Content = null;
			global::System.Windows.Controls.ItemsControl itemsControl = new global::System.Windows.Controls.ItemsControl();
			itemsControl.Background = global::System.Windows.Media.Brushes.White;
			itemsControl.BorderThickness = new global::System.Windows.Thickness(1.0);
			itemsControl.BorderBrush = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햦\udca8\ud8aa얬\udcb2잴펶\udcb8즺", a_)] as global::System.Windows.Media.SolidColorBrush);
			itemsControl.Items.Add(newItem);
			global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost popupNonTopmost = new global::Motorola.CommonCPS.RadioManagement.Controls.PopupNonTopmost();
			popupNonTopmost.Child = itemsControl;
			popupNonTopmost.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Right;
			popupNonTopmost.VerticalOffset = 24.0;
			popupNonTopmost.AllowsTransparency = true;
			popupNonTopmost.PopupAnimation = global::System.Windows.Controls.Primitives.PopupAnimation.Slide;
			popupNonTopmost.Topmost = false;
			global::System.Windows.Controls.Primitives.ToggleButton toggleButton = new global::System.Windows.Controls.Primitives.ToggleButton();
			toggleButton.Content = popupNonTopmost;
			toggleButton.Checked += delegate(object A_0, global::System.Windows.RoutedEventArgs A_1)
			{
				short num4 = (short)2112421889;
				if (num4 != 0)
				{
				}
				num4 = (short)712733352;
				short num5 = num4;
				num4 = (short)1960866472;
				switch (num5 == num4)
				{
				}
				num4 = (short)2099773440;
				if (num4 != 0)
				{
				}
				num4 = (short)1737424896;
				short num6 = num4;
				((global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)base.DataContext).RaisePropertyChanged();
			};
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
			{
				RelativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor)
				{
					AncestorType = typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)
				},
				Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좦잨\udfaa좬솮얰킴쾶춸", a_), global::System.Array.Empty<object>())
			};
			toggleButton.SetBinding(global::System.Windows.FrameworkElement.TagProperty, binding);
			toggleButton.Style = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햦첨\uddaa쒬쪮우\udab4킶\udeb8ힺ\ud8bcﶾ듀럂뇄꣆ꟈ飊만뛎뷐뛒", a_)] as global::System.Windows.Style);
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding
			{
				RelativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor)
				{
					AncestorType = typeof(global::System.Windows.Controls.Primitives.ToggleButton)
				},
				Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풦쎪좬첮\udab0횲톴", a_), global::System.Array.Empty<object>())
			};
			popupNonTopmost.SetBinding(global::System.Windows.Controls.Primitives.Popup.IsOpenProperty, binding2);
			global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding
			{
				RelativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor)
				{
					AncestorType = typeof(global::System.Windows.Controls.Primitives.ToggleButton)
				},
				Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("认", a_), global::System.Array.Empty<object>())
			};
			popupNonTopmost.SetBinding(global::System.Windows.Controls.Primitives.Popup.PlacementTargetProperty, binding3);
			base.Content = toggleButton;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00038EFC File Offset: 0x000370FC
		public virtual void SetPreviewModeProperties(global::System.Windows.FrameworkElementFactory cellFieldEditorFactory)
		{
			short num = (short)1909040423;
			short num2 = num;
			num = (short)305112359;
			switch (num2 == num)
			{
			}
			num = (short)2030632960;
			if (num != 0)
			{
			}
			num = (short)2011955201;
			if (num != 0)
			{
			}
			num = (short)752746496;
			short num3 = num;
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.LabelProperty, base.Label);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor.VisibleInProperty, base.VisibleIn);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeProperty, true);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00038FDC File Offset: 0x000371DC
		public virtual void SetCellValuePresenterMode()
		{
			short num = (short)1915914548;
			short num2 = num;
			num = (short)1138264372;
			switch (num2 == num)
			{
			}
			num = (short)1556611072;
			if (num != 0)
			{
			}
			num = (short)530776065;
			if (num != 0)
			{
			}
			num = (short)1321926656;
			short num3 = num;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00039084 File Offset: 0x00037284
		public virtual void HideBorder()
		{
			short num = (short)58833103;
			short num2 = num;
			num = (short)1005238479;
			switch (num2 == num)
			{
			}
			num = (short)1167261697;
			if (num != 0)
			{
			}
			num = (short)1725366272;
			if (num != 0)
			{
			}
			num = (short)317587456;
			short num3 = num;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00039140 File Offset: 0x00037340
		// Note: this type is marked as 'beforefieldinit'.
		static RMCellPresentableFieldEditor()
		{
			int a_ = 12;
			short num = (short)1615003649;
			if (num != 0)
			{
			}
			num = (short)403740925;
			short num2 = num;
			num = (short)511088893;
			switch (num2 == num)
			{
			}
			num = (short)660471808;
			if (num != 0)
			{
			}
			num = (short)1610547200;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsCellValuePresenterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향쾩삫슭펱\ud8b3쎵\uddb7캻\udbbd뎿ꟁ꫃닅귇룉", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.c)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsShowingOnDataGridProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향ﮧ슩쎫\ud9ad\ud9af\udcb1펳例횷ﺹ\uddbb쪽ꆿ藁뛃꿅곇", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsHideBorderProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향쎩좫쮭\uddb1욳튵\uddb7좹", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeSupportProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향\ud8a9즫\ud8ad\ud9afힱ쎳﮵ힷ\udeb9\ud9bb떿닁듃꧅뫇뻉", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.IsPreviewModeProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("향\ud8a9즫\ud8ad\ud9afힱ쎳﮵ힷ\udeb9\ud9bb", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.ContentTextProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즥욧\udea9즫삭쒯톳캵첷", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor.FieldWidthProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾥춧용좫玲\ud9af횱삳\udeb5", a_), typeof(global::Infragistics.Windows.DataPresenter.FieldLength), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000115 RID: 277
		public static readonly global::System.Windows.DependencyProperty IsCellValuePresenterProperty;

		// Token: 0x04000116 RID: 278
		public static readonly global::System.Windows.DependencyProperty IsShowingOnDataGridProperty;

		// Token: 0x04000117 RID: 279
		public static readonly global::System.Windows.DependencyProperty IsHideBorderProperty;

		// Token: 0x04000118 RID: 280
		public static readonly global::System.Windows.DependencyProperty IsPreviewModeSupportProperty;

		// Token: 0x04000119 RID: 281
		public static readonly global::System.Windows.DependencyProperty IsPreviewModeProperty;

		// Token: 0x0400011A RID: 282
		public static readonly global::System.Windows.DependencyProperty ContentTextProperty;

		// Token: 0x0400011B RID: 283
		public static readonly global::System.Windows.DependencyProperty FieldWidthProperty;
	}
}
