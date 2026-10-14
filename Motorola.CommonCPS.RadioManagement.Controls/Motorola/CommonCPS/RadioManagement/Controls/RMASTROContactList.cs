using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Controls.Grids;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000079 RID: 121
	public class RMASTROContactList : global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060002BA RID: 698 RVA: 0x0002CF00 File Offset: 0x0002B100
		public RMASTROContactList()
		{
			this.InitializeComponent();
			this.gridSets.PreviewMouseWheel += this.ScrollViewer_PreviewMouseWheel;
			base.Unloaded += this.RMASTROContactList_Unloaded;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0002CF44 File Offset: 0x0002B144
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory SetCategory
		{
			get
			{
				short num = (short)1981087744;
				short num2 = num;
				num = (short)500283538;
				short num3 = num;
				num = (short)1826535570;
				switch (num3 == num)
				{
				}
				num = (short)2052194305;
				if (num != 0)
				{
				}
				num = (short)278921216;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMASTROContactList.SetCategoryProperty);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0002D000 File Offset: 0x0002B200
		protected override string ContactAliasName
		{
			get
			{
				int a_ = 2;
				short num = (short)991035392;
				short num2 = num;
				num = (short)735906058;
				short num3 = num;
				num = (short)104466698;
				switch (num3 == num)
				{
				}
				num = (short)792592385;
				if (num != 0)
				{
				}
				num = (short)3735552;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾙ﾛ잡쪣殮얩슫\udaad톯톱삳풷펹\uddbb춽龿菁韛", a_);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		private void grdContacts_ActiveCellChanged(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1019346944;
			short num2 = num;
			num = (short)936247297;
			if (num != 0)
			{
			}
			num = (short)1636892675;
			short num3 = num;
			num = (short)1608581123;
			switch (num3 == num)
			{
			}
			num = (short)1179385856;
			if (num != 0)
			{
			}
			base.HandleActiveCellChanged(A_0);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0002D174 File Offset: 0x0002B374
		private void RMASTROContactList_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1533411328;
			short num2 = num;
			num = (short)286056086;
			short num3 = num;
			num = (short)672390806;
			switch (num3 == num)
			{
			}
			num = (short)753729536;
			if (num != 0)
			{
			}
			num = (short)696713217;
			if (num != 0)
			{
			}
			this.grdContacts.ItemsSource = null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0002D228 File Offset: 0x0002B428
		public void UserControl_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)574511116;
			short num2 = num;
			num = (short)1630492684;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_120:
				num = (short)1613299719;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1877540865;
				if (num != 0)
				{
				}
				num = (short)3276800;
				if (num != 0)
				{
				}
				num = (short)410845186;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.ReBindingItemsSource(rmsetPresenter.FlatSetConverter, ((global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)e.NewValue).SetCategory);
					num = (short)1280311300;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (rmsetPresenter != null)
					{
						num = (short)656801792;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_B4;
					}
					continue;
				case 3:
				{
					this.grdContacts.GroupBySettings.GroupByColumns.Clear();
					this.grdContacts.ItemsSource = null;
					this.grdContactNames.ItemsSource = null;
					this.rbtByName.IsChecked = new bool?(false);
					this.setCategory = null;
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMASTROContactList.SetCategoryProperty, null);
					num = (short)1713373184;
					short num4 = num;
					num = (short)1833041926;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					num = (short)801374209;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1F8;
				case 7:
					if (e.NewValue is global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)
					{
						num = (short)1793392645;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_B4:
				if (e.NewValue != null)
				{
					break;
				}
				num = (short)776273923;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			rmsetPresenter = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b(this);
			base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.SetPresenterProperty, rmsetPresenter);
			goto IL_120;
			IL_1F8:
			goto IL_10D;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0002D468 File Offset: 0x0002B668
		private void rbtNameOnly_Checked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1393688576;
			short num2 = num;
			num = (short)1976036996;
			short num3 = num;
			num = (short)1130360452;
			switch (num3 == num)
			{
			}
			num = (short)1081671681;
			if (num != 0)
			{
			}
			num = (short)1359347712;
			if (num != 0)
			{
			}
			this.grdContacts.ActiveCell = null;
			this.grdContactNames.ActiveCell = null;
			this.grdContacts.SelectionSettings.SelectedCells.Clear();
			this.grdContactNames.SelectionSettings.SelectedCells.Clear();
			this.grdContactNames.Visibility = global::System.Windows.Visibility.Visible;
			this.grdContacts.Visibility = global::System.Windows.Visibility.Collapsed;
			this.btnDelete.IsEnabled = true;
			this.rbtByName.IsChecked = new bool?(false);
			this.rbtByType.IsChecked = new bool?(false);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0002D598 File Offset: 0x0002B798
		private void rbtByName_Checked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)831782912;
			short num2 = num;
			num = (short)605159425;
			if (num != 0)
			{
			}
			num = (short)2031331978;
			short num3 = num;
			num = (short)1227926154;
			switch (num3 == num)
			{
			}
			num = (short)1459159040;
			if (num != 0)
			{
			}
			this.grdContacts.ActiveCell = null;
			this.grdContactNames.ActiveCell = null;
			this.grdContacts.SelectionSettings.SelectedCells.Clear();
			this.grdContactNames.SelectionSettings.SelectedCells.Clear();
			this.grdContacts.SortingSettings.AllowSorting = false;
			this.grdContacts.SortingSettings.ShowSortIndicator = false;
			this.grdContactNames.Visibility = global::System.Windows.Visibility.Collapsed;
			this.grdContacts.Visibility = global::System.Windows.Visibility.Visible;
			this.btnDelete.IsEnabled = true;
			this.mniDelete.Visibility = global::System.Windows.Visibility.Visible;
			this.mniAddCopies.Visibility = global::System.Windows.Visibility.Visible;
			this.grdContacts.GroupBySettings.GroupByColumns.Add((global::Infragistics.Controls.Grids.UnboundColumn)this.grdContacts.Columns[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾚첢쮤펦좨좪\ud9ac킰\udeb2킴", a_)]);
			this.rbtNameOnly.IsChecked = new bool?(false);
			this.rbtByType.IsChecked = new bool?(false);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0002D744 File Offset: 0x0002B944
		private void rbtByType_Checked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1774977024;
			short num2 = num;
			num = (short)46502613;
			short num3 = num;
			num = (short)1120572117;
			switch (num3 == num)
			{
			}
			num = (short)1550909441;
			if (num != 0)
			{
			}
			num = (short)665845760;
			if (num != 0)
			{
			}
			this.grdContacts.ActiveCell = null;
			this.grdContactNames.ActiveCell = null;
			this.grdContacts.SelectionSettings.SelectedCells.Clear();
			this.grdContactNames.SelectionSettings.SelectedCells.Clear();
			this.grdContacts.SortingSettings.AllowSorting = true;
			this.grdContacts.SortingSettings.ShowSortIndicator = true;
			this.grdContactNames.Visibility = global::System.Windows.Visibility.Collapsed;
			this.grdContacts.Visibility = global::System.Windows.Visibility.Visible;
			this.btnDelete.IsEnabled = false;
			this.mniDelete.Visibility = global::System.Windows.Visibility.Collapsed;
			this.mniAddCopies.Visibility = global::System.Windows.Visibility.Collapsed;
			this.grdContacts.GroupBySettings.GroupByColumns.Clear();
			this.rbtByName.IsChecked = new bool?(false);
			this.rbtNameOnly.IsChecked = new bool?(false);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0002D8C4 File Offset: 0x0002BAC4
		private void grdContacts_InitializeRow(object A_0, global::Infragistics.Controls.Grids.InitializeRowEventArgs A_1)
		{
			short num = (short)63176709;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!(A_1.Row.Data is global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet))
					{
						return;
					}
					num = (short)965010651;
					short num3 = num;
					num = (short)867624155;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E5;
					default:
						num = (short)1183186944;
						if (num != 0)
						{
						}
						num = (short)295174147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1E5;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = A_1.Row.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
					num = (short)95617034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)82640896;
					short num4 = num;
					global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet = A_1.Row.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet;
					num = (short)265420809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1E3;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet;
					if (!flatParentChildSet.IsVisible)
					{
						num = (short)954073089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 7:
					num = (short)1354366982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return;
				case 9:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet;
					if (flatParentChildSet != null)
					{
						num = (short)476250119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
				}
				case 10:
				{
					num = (short)1031012353;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
					if (!set.IsVisible)
					{
						num = (short)787218436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_51:
				if (A_1.Row.Data is global::Motorola.CommonCPS.RadioManagement.UIModels.Set)
				{
					num = (short)818479106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)713687040;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E5:
				A_1.Row.Height = new global::Infragistics.Controls.Grids.RowHeight?(new global::Infragistics.Controls.Grids.RowHeight(0.0));
				num = (short)877395976;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E3:
			A_1.Row.Height = new global::Infragistics.Controls.Grids.RowHeight?(new global::Infragistics.Controls.Grids.RowHeight(0.0));
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0002DB58 File Offset: 0x0002BD58
		private void btnExport_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)264076798;
			short num2 = num;
			num = (short)1993244158;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1810497536;
				if (num != 0)
				{
				}
				num = (short)734789632;
				short num3 = num;
				num = (short)1624702977;
				if (num != 0)
				{
				}
				bool? isChecked = this.rbtNameOnly.IsChecked;
				bool flag = true;
				if (!(isChecked.GetValueOrDefault() == flag & isChecked != null))
				{
					base.Export(this.grdContacts);
					return;
				}
				break;
			}
			}
			base.Export(this.grdContactNames);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0002DC3C File Offset: 0x0002BE3C
		private void ScrollViewer_PreviewMouseWheel(object A_0, global::System.Windows.Input.MouseWheelEventArgs A_1)
		{
			short num = (short)72417281;
			if (num != 0)
			{
			}
			num = (short)45744128;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 1:
				{
					num = (short)1672413184;
					short num3 = num;
					num = (short)358023461;
					short num4 = num;
					num = (short)395641125;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)577830912;
						if (num != 0)
						{
						}
						num = (short)1259929603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_F9;
				case 3:
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)529072130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				}
				IL_62:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
				{
					num = (short)1583284225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F9:
				global::System.Windows.Controls.Grid a_ = A_0 as global::System.Windows.Controls.Grid;
				global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(a_, (double)A_1.Delta);
				num = (short)886374404;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0002DDAC File Offset: 0x0002BFAC
		public override void ReBindingItemsSource(global::System.Windows.Data.IValueConverter datasrouceConverter, global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory activeSetCategory)
		{
			short num = (short)591134720;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)307822593;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					goto IL_14F;
				case 2:
					this.grdContactNames.ItemsSource = activeSetCategory.Sets;
					this.grdContacts.ItemsSource = (datasrouceConverter.Convert(activeSetCategory.Sets, null, null, null) as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>);
					this.setCategory = activeSetCategory;
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMASTROContactList.SetCategoryProperty, activeSetCategory);
					num = (short)1062404097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5A:
				num = (short)276685754;
				short num3 = num;
				num = (short)624485306;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1643839488;
					short num4 = num;
					break;
				}
				}
				num = (short)1466761216;
				if (num != 0)
				{
				}
				if (activeSetCategory.Equals(this.setCategory))
				{
					break;
				}
				num = (short)1716584450;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14F:
			this.rbtByName.IsChecked = new bool?(true);
			base.SetPresenter.AddEmbeddedSetCommand.RaiseCanExecuteChanged();
			base.SetPresenter.AddMultipleSetsCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0002DF3C File Offset: 0x0002C13C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)799373497;
			short num2 = num;
			num = (short)631011513;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1006370816;
				if (num != 0)
				{
				}
				num = (short)1425604608;
				short num3 = num;
				num = (short)1242562561;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뎛펝쾟횡쮣풥잧용춫肭\uddb1\ud9b3\udbb5ힷ풹ﾻ鎿雃Ʂ곇ꏉꏋ菍뇏병뗓뇕뷗럙맛냝铟쳡꟣觥蛧黩黫臭鳯臱쿳闵韷韹賻釽滿朁樃爅✇缉缋欍戏焑笓砕気栙猛爝匟ഡ䔣唥尧堩䌫ĭ䈯弱唳䔵䰷䠹医崽⼿ⱁぃ❅⭇㹉⁋❍⍏♑穓⹕㥗㝙せ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0002E020 File Offset: 0x0002C220
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)451215360;
			short num2 = num;
			num = (short)90479727;
			short num3 = num;
			num = (short)1830460527;
			switch (num3 == num)
			{
			}
			num = (short)1532493824;
			if (num != 0)
			{
			}
			num = (short)695664641;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002E0D4 File Offset: 0x0002C2D4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1053229056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_1E4;
				case 2:
					num = (short)1249640449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_2B7;
				case 2:
					goto IL_119;
				case 3:
					goto IL_1F6;
				case 4:
					goto IL_D1;
				case 5:
					goto IL_1E9;
				case 6:
					goto IL_14D;
				case 7:
					goto IL_2AA;
				case 8:
					goto IL_22E;
				case 9:
					goto IL_1BF;
				case 10:
					goto IL_255;
				case 11:
					goto IL_262;
				case 12:
					goto IL_140;
				case 13:
					goto IL_C4;
				case 14:
					goto IL_2F8;
				case 15:
					goto IL_26F;
				case 16:
					goto IL_126;
				case 17:
					goto IL_B7;
				case 18:
					goto IL_248;
				case 19:
					goto IL_2C4;
				case 20:
					goto IL_DE;
				case 21:
					goto IL_15A;
				case 22:
					goto IL_23B;
				case 23:
					goto IL_133;
				case 24:
					goto IL_167;
				default:
					num = (short)1162280962;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B7:
			this.mniDelete = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_C4:
			this.btnDelete = (global::System.Windows.Controls.Button)target;
			return;
			IL_D1:
			this.rbtNameOnly = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_DE:
			this.grdContactNames = (global::Infragistics.Controls.Grids.XamGrid)target;
			this.grdContactNames.ActiveCellChanged += this.grdContacts_ActiveCellChanged;
			this.grdContactNames.InitializeRow += this.grdContacts_InitializeRow;
			return;
			IL_119:
			this.rbtByName = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_126:
			this.mniEdit = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_133:
			this.mninAddCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_140:
			this.btnEdit = (global::System.Windows.Controls.Button)target;
			return;
			IL_14D:
			this.btnAdd = (global::System.Windows.Controls.Button)target;
			return;
			IL_15A:
			this.mninEdit = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_167:
			num = (short)761126754;
			short num3 = num;
			num = (short)1711071074;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_133;
			default:
				num = (short)967835648;
				if (num != 0)
				{
				}
				this.mninShowRelatedSets = (global::System.Windows.Controls.MenuItem)target;
				return;
			}
			IL_1BF:
			this.mniAddSet = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_1E4:
			this._contentLoaded = true;
			return;
			IL_1E9:
			this.gridSets = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1F6:
			num = (short)626524160;
			short num4 = num;
			this.rbtByType = (global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton)target;
			return;
			IL_22E:
			this.ctmExtended = (global::System.Windows.Controls.ContextMenu)target;
			return;
			IL_23B:
			this.mninDelete = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_248:
			this.mniAddCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_255:
			this.mniAddMultipleSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_262:
			this.mniAddSetCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_26F:
			this.grdContacts = (global::Infragistics.Controls.Grids.XamGrid)target;
			this.grdContacts.ActiveCellChanged += this.grdContacts_ActiveCellChanged;
			this.grdContacts.InitializeRow += this.grdContacts_InitializeRow;
			return;
			IL_2AA:
			this.btnAdditional = (global::System.Windows.Controls.Button)target;
			return;
			IL_2B7:
			this.borderInvalid = (global::System.Windows.Controls.Border)target;
			return;
			IL_2C4:
			num = (short)1697710081;
			if (num != 0)
			{
			}
			this.mniShowRelatedSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2F8:
			this.btnGridToFile = (global::System.Windows.Controls.Button)target;
			this.btnGridToFile.Click += this.btnExport_Click;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0002E404 File Offset: 0x0002C604
		// Note: this type is marked as 'beforefieldinit'.
		static RMASTROContactList()
		{
			int a_ = 1;
			short num = (short)1289730372;
			short num2 = num;
			num = (short)286308676;
			switch (num2 == num)
			{
			}
			num = (short)151650304;
			short num3 = num;
			num = (short)1005649921;
			if (num != 0)
			{
			}
			num = (short)1395195904;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMASTROContactList.SetCategoryProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪘ﺚ\udc9e삠힢삤삦욨\ud9aa풬", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMASTROContactList), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x040000C2 RID: 194
		public static readonly global::System.Windows.DependencyProperty SetCategoryProperty;

		// Token: 0x040000C3 RID: 195
		internal global::System.Windows.Controls.Border borderInvalid;

		// Token: 0x040000C4 RID: 196
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtByName;

		// Token: 0x040000C5 RID: 197
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtByType;

		// Token: 0x040000C6 RID: 198
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioButton rbtNameOnly;

		// Token: 0x040000C7 RID: 199
		internal global::System.Windows.Controls.Grid gridSets;

		// Token: 0x040000C8 RID: 200
		internal global::System.Windows.Controls.Button btnAdd;

		// Token: 0x040000C9 RID: 201
		internal global::System.Windows.Controls.Button btnAdditional;

		// Token: 0x040000CA RID: 202
		internal global::System.Windows.Controls.ContextMenu ctmExtended;

		// Token: 0x040000CB RID: 203
		internal global::System.Windows.Controls.MenuItem mniAddSet;

		// Token: 0x040000CC RID: 204
		internal global::System.Windows.Controls.MenuItem mniAddMultipleSets;

		// Token: 0x040000CD RID: 205
		internal global::System.Windows.Controls.MenuItem mniAddSetCopies;

		// Token: 0x040000CE RID: 206
		internal global::System.Windows.Controls.Button btnEdit;

		// Token: 0x040000CF RID: 207
		internal global::System.Windows.Controls.Button btnDelete;

		// Token: 0x040000D0 RID: 208
		internal global::System.Windows.Controls.Button btnGridToFile;

		// Token: 0x040000D1 RID: 209
		internal global::Infragistics.Controls.Grids.XamGrid grdContacts;

		// Token: 0x040000D2 RID: 210
		internal global::System.Windows.Controls.MenuItem mniEdit;

		// Token: 0x040000D3 RID: 211
		internal global::System.Windows.Controls.MenuItem mniDelete;

		// Token: 0x040000D4 RID: 212
		internal global::System.Windows.Controls.MenuItem mniAddCopies;

		// Token: 0x040000D5 RID: 213
		internal global::System.Windows.Controls.MenuItem mniShowRelatedSets;

		// Token: 0x040000D6 RID: 214
		internal global::Infragistics.Controls.Grids.XamGrid grdContactNames;

		// Token: 0x040000D7 RID: 215
		internal global::System.Windows.Controls.MenuItem mninEdit;

		// Token: 0x040000D8 RID: 216
		internal global::System.Windows.Controls.MenuItem mninDelete;

		// Token: 0x040000D9 RID: 217
		internal global::System.Windows.Controls.MenuItem mninAddCopies;

		// Token: 0x040000DA RID: 218
		internal global::System.Windows.Controls.MenuItem mninShowRelatedSets;

		// Token: 0x040000DB RID: 219
		private bool _contentLoaded;
	}
}
