using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Grids.Primitives;
using Infragistics.Windows;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000F4 RID: 244
	public class RMZoneList1 : global::Motorola.CommonCPS.RadioManagement.Controls.XamGridContainer, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x0006CD48 File Offset: 0x0006AF48
		public RMZoneList1()
		{
			this.InitializeComponent();
			base.Unloaded += this.RMZoneList1_Unloaded;
			this.gridVoiceFileCommand.IsVisibleChanged += this.a;
			this.grdZones.PreviewMouseWheel += this.ScrollViewer_PreviewMouseWheel;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0006CDAC File Offset: 0x0006AFAC
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter SetPresenter
		{
			get
			{
				short num = (short)842924087;
				short num2 = num;
				num = (short)1874722871;
				switch (num2 == num)
				{
				}
				num = (short)1872625665;
				if (num != 0)
				{
				}
				num = (short)1376518144;
				if (num != 0)
				{
				}
				num = (short)144244736;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.SetPresenterProperty);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0006CE68 File Offset: 0x0006B068
		public global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase ActiveField
		{
			get
			{
				short num = (short)119828919;
				short num2 = num;
				num = (short)831746487;
				switch (num2 == num)
				{
				}
				num = (short)363921409;
				if (num != 0)
				{
				}
				num = (short)1567293440;
				if (num != 0)
				{
				}
				num = (short)459276288;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.ActiveFieldProperty);
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0006CF20 File Offset: 0x0006B120
		public void UserControl_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)472439530;
			short num2 = num;
			num = (short)805624554;
			switch (num2 == num)
			{
			default:
			{
				num = (short)699072512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)474939393;
			if (num != 0)
			{
			}
			num = (short)192413696;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter value = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b(this);
			base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.SetPresenterProperty, value);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0006CFDC File Offset: 0x0006B1DC
		private void grdZones_ActiveCellChanged(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 16;
			short num = (short)1540161542;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1132724225;
					if (num != 0)
					{
					}
					num = (short)1898643457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.grdZones.ActiveCell.Value is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
					{
						num = (short)592969731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)466092039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = ((this.grdZones.ActiveCell.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
					setCategory.SelectedSets.Clear();
					setCategory.SelectedSets.Add((this.grdZones.ActiveCell.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.ActiveFieldProperty, this.grdZones.ActiveCell.Value);
					num = (short)105775112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_2AA;
				case 4:
					goto IL_2A8;
				case 5:
					goto IL_2F6;
				case 6:
				{
					num = (short)88006362;
					short num3 = num;
					num = (short)1494146778;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)676331520;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9B;
						}
						continue;
					}
					break;
				}
				case 7:
				{
					if (this.grdZones.ActiveCell.Value is global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)
					{
						num = (short)1382154242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet = this.grdZones.ActiveCell.Row.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory2 = flatParentChildSet.ParentSet.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
					setCategory2.SelectedSets.Clear();
					setCategory2.SelectedSets.Add(flatParentChildSet.ParentSet);
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.ActiveFieldProperty, flatParentChildSet.ParentSet.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﮧ쾩\ud8ab톯\udfb1톳", a_)]);
					num = (short)449183748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_181;
				}
				IL_9B:
				if (this.grdZones.ActiveCell != null)
				{
					num = (short)83886080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2AA:
				num = (short)655491072;
				short num4 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.ActiveFieldProperty, null);
				num = (short)2055733253;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_181:
			IL_2A8:
			IL_2F6:
			this.SetPresenter.AddEmbeddedSetCommand.RaiseCanExecuteChanged();
			this.SetPresenter.AddMultipleSetsCommand.RaiseCanExecuteChanged();
			this.SetPresenter.DeleteEmbeddedSetsCommand.RaiseCanExecuteChanged();
			this.SetPresenter.EditEmbeddedSetCommand.RaiseCanExecuteChanged();
			this.SetPresenter.MoveEmbeddedSetDownCommand.RaiseCanExecuteChanged();
			this.SetPresenter.MoveEmbeddedSetUpCommand.RaiseCanExecuteChanged();
			this.SetPresenter.PrepareCopyEmbeddedSetCommand.RaiseCanExecuteChanged();
			this.SetPresenter.PrepareShowEmbeddedSetRelatedSetsCommand.RaiseCanExecuteChanged();
			this.SetPresenter.PrepareShowEmbeddedSetRelatedConfigurationsCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0006D374 File Offset: 0x0006B574
		private void grdZones_MouseRightButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.DependencyObject ancestorFromType;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2035554990;
					short num3 = num2;
					num2 = (short)443292334;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)358350849;
						if (num2 != 0)
						{
						}
						num2 = (short)448397312;
						if (num2 != 0)
						{
						}
						break;
					}
					this.grdZones.ShowColumnChooser();
					num2 = (short)242679809;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (ancestorFromType != null)
					{
						num2 = (short)2140078080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			global::System.Windows.DependencyObject descendant = A_1.OriginalSource as global::System.Windows.DependencyObject;
			ancestorFromType = global::Infragistics.Windows.Utilities.GetAncestorFromType(descendant, typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl), true);
			num2 = (short)1099038720;
			short num4 = num2;
			num2 = (short)2093744130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0006D4B4 File Offset: 0x0006B6B4
		private void RMZoneList1_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)619080624;
			short num2 = num;
			num = (short)1430547376;
			switch (num2 == num)
			{
			}
			num = (short)1042415616;
			if (num != 0)
			{
			}
			num = (short)192217088;
			short num3 = num;
			num = (short)2142306305;
			if (num != 0)
			{
			}
			this.grdZones.ItemsSource = null;
			this.grdZones.GroupBySettings.GroupByColumns.Clear();
			this.groupColumns.Clear();
			this.grdZones.Columns.Clear();
			this.isLoadedFieldLayout = false;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0006D5A4 File Offset: 0x0006B7A4
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)151868792;
			short num2 = num;
			num = (short)1559516536;
			switch (num2 == num)
			{
			}
			num = (short)1582497793;
			if (num != 0)
			{
			}
			num = (short)1378156544;
			short num3 = num;
			num = (short)1367080960;
			if (num != 0)
			{
			}
			this.a((bool)A_1.NewValue);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0006D660 File Offset: 0x0006B860
		private void a(bool A_0)
		{
			int a_ = 17;
			short num = (short)1996423169;
			if (num != 0)
			{
			}
			num = (short)1307443200;
			switch (num)
			{
			default:
			{
				num = (short)420806657;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)590032548;
						short num3 = num;
						num = (short)177548964;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_190;
						default:
							num = (short)462618624;
							if (num != 0)
							{
							}
							if (base.DataContext == null)
							{
								num = (short)1058209794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_195;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 2:
						goto IL_190;
					case 3:
					{
						num = (short)729219072;
						short num4 = num;
						num = (short)219480064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_85:
					if (!A_0)
					{
						break;
					}
					num = (short)852754435;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A0:
				global::System.Windows.Data.BindingOperations.ClearBinding(this.btnSetVa, global::System.Windows.UIElement.VisibilityProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this.btnSetVa, global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this.btnClearVa, global::System.Windows.UIElement.VisibilityProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this.btnClearVa, global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty);
				return;
				IL_190:
				goto IL_A0;
				IL_195:
				global::System.Windows.Data.IValueConverter converter = (global::System.Windows.Data.IValueConverter)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪슬쎮\udcb2\udeb6쪸튺\udfbc횾귀ꫂ뇄뻆諈꓊ꏌ많듐ꇒꇔ닖ꯘ", a_)];
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Source = this;
				binding.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪\ud9ac캮\udcb2\udbb4쎶\udcb8쎺즼醾苀곂ꯄꇆꃈ곊료뷎냐꟒볔룖럘鳜볞闠諢鏤苦뫨軪駬곮郰蟲郴郶雸觺蓼퇾刀昂焄儆昈戊渌樎圐稒礔爖娘琚瀜爞䀠䴢䄤द怨堪第䘮䈰娲圴嬶尸", a_), global::System.Array.Empty<object>());
				binding.Converter = converter;
				this.btnSetVa.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
				global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding();
				binding2.Source = this;
				binding2.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪\ud9ac캮\udcb2\udbb4쎶\udcb8쎺즼醾苀곂ꯄꇆꃈ곊료뷎냐꟒볔룖럘鳜볞闠諢鏤苦뫨軪駬곮郰蟲郴郶雸觺蓼퇾刀昂焄儆昈戊渌樎圐稒礔爖娘琚瀜爞䀠䴢䄤", a_), global::System.Array.Empty<object>());
				this.btnSetVa.SetBinding(global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty, binding2);
				global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding();
				binding3.Source = this;
				binding3.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪\ud9ac캮\udcb2\udbb4쎶\udcb8쎺즼醾苀곂ꯄꇆꃈ곊료뷎냐꟒볔룖럘鳜볞闠諢鏤苦뫨軪駬곮郰蟲郴郶雸觺蓼퇾䈀漂怄昆笈崊戌明爐瘒匔縖甘縚帜瀞䰠丢䐤䤦䴨Ԫ搬尮朰娲䘴帶嬸场堼", a_), global::System.Array.Empty<object>());
				binding3.Converter = converter;
				this.btnClearVa.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding3);
				global::System.Windows.Data.Binding binding4 = new global::System.Windows.Data.Binding();
				binding4.Source = this;
				binding4.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪\ud9ac캮\udcb2\udbb4쎶\udcb8쎺즼醾苀곂ꯄꇆꃈ곊료뷎냐꟒볔룖럘鳜볞闠諢鏤苦뫨軪駬곮郰蟲郴郶雸觺蓼퇾䈀漂怄昆笈崊戌明爐瘒匔縖甘縚帜瀞䰠丢䐤䤦䴨", a_), global::System.Array.Empty<object>());
				this.btnClearVa.SetBinding(global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty, binding4);
				return;
			}
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0006D928 File Offset: 0x0006BB28
		private void ScrollViewer_PreviewMouseWheel(object A_0, global::System.Windows.Input.MouseWheelEventArgs A_1)
		{
			short num = (short)350355458;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_116:
					num = (short)193855489;
					if (num != 0)
					{
					}
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)656474115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					goto IL_5B;
				case 4:
					num = (short)1708064768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
				{
					num = (short)375980036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				global::Infragistics.Controls.Grids.XamGrid a_ = A_0 as global::Infragistics.Controls.Grids.XamGrid;
				global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(a_, (double)A_1.Delta);
				num = (short)468678040;
				short num3 = num;
				num = (short)1948284312;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_116;
				default:
				{
					num = (short)1084030976;
					if (num != 0)
					{
					}
					num = (short)1186070528;
					short num4 = num;
					num = (short)1690304513;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		private void a(string A_0, string A_1, int A_2, global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory A_3)
		{
			int a_ = 8;
			short num = (short)510263296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)357367808;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_79;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.<>c__DisplayClass21_0 CS$<>8__locals1;
				for (;;)
				{
					IL_5A:
					switch (num2)
					{
					case 0:
						if (this.grdZones.GroupBySettings.GroupByColumns.Count == 0)
						{
							num = (short)433455105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.groupColumns.ForEach(new global::System.Action<global::Infragistics.Controls.Grids.Column>(CS$<>8__locals1.e));
						num = (short)961871876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1605959681;
						if (num != 0)
						{
						}
						goto IL_10C;
					case 3:
						if (!this.isLoadedFieldLayout)
						{
							goto IL_BD;
						}
						goto IL_10C;
					case 4:
						return;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor setEditor = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.GetSetEditor(A_0, false, false);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> fieldEditorList = setEditor.GetFieldEditorList();
						global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = new global::Infragistics.Controls.Grids.UnboundColumn
						{
							Key = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡힣쾥\udca7쎩쎫삭", a_),
							IsSortable = true,
							SortComparer = new global::Motorola.CommonCPS.RadioManagement.Controls.PositionSortComparer(),
							HeaderText = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Position,
							ItemTemplate = (global::System.Windows.DataTemplate)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첡튣장쒧쎩좫\udeaf횱\ud9b5쮷펹좻ힽ꾿곁蟃ꏅ꓇ꛉ迋ꇍ볏ꟑ맓룕鳗믙꣛뿝듟蟡解雥蓧诩飫语", a_)],
							MergedItemTemplate = (global::System.Windows.DataTemplate)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첡튣장쒧쎩좫\udeaf횱\ud9b5쮷펹좻ힽ꾿곁觃ꏅ뫇귉꧋꫍鏏럑룓뫕鯗뗙냛ꯝ跟賡ꃣ蟥鳧诩룫语鷯英飳韵賷鿹", a_)]
						};
						unboundColumn.ValueConverter = new global::Motorola.CommonCPS.RadioManagement.Controls.UnboundColumnPoisitionValueConverter();
						unboundColumn.ValueConverterParameter = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎡횣쎥욧\udea9ﾫ쮭쒯", a_);
						this.grdZones.Columns.Add(unboundColumn);
						this.groupColumns.Add(unboundColumn);
						fieldEditorList.ForEach(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(CS$<>8__locals1.e));
						global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor setEditor2 = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.GetSetEditor(CS$<>8__locals1.d, false, false);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> fieldEditorList2 = setEditor2.GetFieldEditorList();
						global::Infragistics.Controls.Grids.UnboundColumn unboundColumn2 = new global::Infragistics.Controls.Grids.UnboundColumn
						{
							Key = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾡욣쎥첧캩즫쪭ힱ삳ﾵ횷첹\uddbbힽ겿ꛁ", a_),
							IsHideable = false,
							HeaderText = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("肟", a_),
							IsSortable = false,
							ItemTemplate = (global::System.Windows.DataTemplate)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첡튣장쒧쎩좫\uddaf킱톳튵\udcb7\udfb9\ud8bbꖿ뛁蟃ꏅ꓇ꛉ迋ꇍ볏ꟑ맓룕鳗믙꣛뿝듟蟡解雥蓧诩飫语", a_)],
							MergedItemTemplate = (global::System.Windows.DataTemplate)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첡튣장쒧쎩좫\uddaf킱톳튵\udcb7\udfb9\ud8bbꖿ뛁觃ꏅ뫇귉꧋꫍鏏럑룓뫕鯗뗙냛ꯝ跟賡ꃣ蟥鳧诩룫语鷯英飳韵賷鿹", a_)]
						};
						unboundColumn2.ValueConverter = new global::Motorola.CommonCPS.RadioManagement.Controls.UnboundColumnValueConverter();
						unboundColumn2.ValueConverterParameter = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪡춣쪥첧囹즫\udaad첯톳습\udbb9톻\udbbd", a_);
						this.grdZones.Columns.Add(unboundColumn2);
						global::Infragistics.Controls.Grids.UnboundColumn unboundColumn3 = new global::Infragistics.Controls.Grids.UnboundColumn
						{
							Key = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾡욣쎥첧캩즫쪭ힱ삳ힷ즹햻쪽ꦿ귁꫃", a_),
							HeaderText = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Position,
							ItemTemplate = (global::System.Windows.DataTemplate)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡춣향\udca7쎩쎫삭\udfb1횳펵\udcb7\udeb9\ud9bb\udabd鎿ꟁ냃藅귇ꛉꃋ跍뿏뻑ꇓ믕뛗黙뷛ꫝ臟뛡臣该飧蛩跫髭闯", a_)],
							MergedItemTemplate = (global::System.Windows.DataTemplate)base.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡춣향\udca7쎩쎫삭\udfb1횳펵\udcb7\udeb9\ud9bb\udabd鎿ꟁ냃诅귇룉ꯋꯍ듏金뇓뫕듗駙돛닝闟迡諣ꋥ觧黩跫뫭闯鿱蓳髵駷軹駻", a_)]
						};
						unboundColumn3.ValueConverter = new global::Motorola.CommonCPS.RadioManagement.Controls.UnboundColumnValueConverter();
						unboundColumn3.ValueConverterParameter = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪡춣쪥첧囹즫\udaad첯톳습\udbb9톻\udbbd", a_);
						this.grdZones.Columns.Add(unboundColumn3);
						fieldEditorList2.ForEach(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(CS$<>8__locals1.f));
						this.isLoadedFieldLayout = true;
						num = (short)1436942338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_79;
					IL_BD:
					num = (short)1239875589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10C:
					num = (short)653322255;
					short num4 = num;
					num = (short)1381099535;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BD;
					default:
						num = (short)1707409408;
						if (num != 0)
						{
						}
						num = (short)2089287680;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return;
				IL_79:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.<>c__DisplayClass21_0();
				CS$<>8__locals1.a = A_3;
				CS$<>8__locals1.b = A_2;
				CS$<>8__locals1.c = this;
				CS$<>8__locals1.d = A_1;
				num = (short)483852291;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0006DF00 File Offset: 0x0006C100
		public void ReBindingItemsSource(global::System.Windows.Data.IValueConverter datasrouceConverter, global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory activeSetCategory)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> observableCollection;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> observableCollectionFast;
				switch (num)
				{
				case 0:
					this.a(observableCollectionFast);
					observableCollection = (this.grdZones.ItemsSource as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>);
					num2 = (short)1043726337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (observableCollection != null)
					{
						num2 = (short)1974730755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_110;
				case 2:
					num2 = (short)857079809;
					if (num2 != 0)
					{
					}
					observableCollectionFast.CollectionChanged += this.ItemsSource_CollectionChanged;
					num2 = (short)605880328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1E6;
				case 4:
					goto IL_20C;
				case 5:
					goto IL_110;
				case 6:
					if (this.grdZones.ItemsSource != observableCollectionFast)
					{
						num2 = (short)1412038656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23C;
				case 7:
					if (observableCollectionFast != null)
					{
						num2 = (short)835977216;
						short num3 = num2;
						num2 = (short)211156994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E8;
				case 8:
					goto IL_1E8;
				}
				goto IL_3D;
				IL_110:
				num2 = (short)1648885767;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E8:
				this.grdZones.ItemsSource = observableCollectionFast;
				num2 = (short)1738276868;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1E6:
			goto IL_20E;
			IL_20C:
			IL_23C:
			this.a(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺣ즥욧쾩\udfab", a_), global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캥즧쒩슫쮭\udcaf", a_), 2, activeSetCategory);
			return;
			IL_3D:
			num2 = (short)900425669;
			short num4 = num2;
			num2 = (short)718170053;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20E:
				observableCollection.CollectionChanged -= this.ItemsSource_CollectionChanged;
				num2 = (short)269549573;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)1198718976;
				if (num2 != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> observableCollectionFast = datasrouceConverter.Convert(activeSetCategory.Sets, null, null, null) as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>;
				num2 = (short)256573446;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0006E170 File Offset: 0x0006C370
		private void ItemsSource_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)548140530;
			short num2 = num;
			num = (short)378926578;
			switch (num2 == num)
			{
			}
			num = (short)539033601;
			if (num != 0)
			{
			}
			num = (short)2072117248;
			short num3 = num;
			num = (short)1457848320;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> a_ = A_0 as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>;
			this.a(a_);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0006E228 File Offset: 0x0006C428
		private void a(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> A_0)
		{
			short num = (short)1345388545;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> enumerator;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet> list;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)1041891332;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1564810671;
								short num3 = num;
								num = (short)1399791023;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1B5;
								default:
								{
									num = (short)545456128;
									if (num != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num = (short)1851719681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet = enumerator.Current;
									num = (short)106692611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 1:
								num = (short)1666514949;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet;
								if (!flatParentChildSet.IsVisible)
								{
									num = (short)1047396358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 5:
								goto IL_1B5;
							case 6:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet;
								list.Add(flatParentChildSet);
								num = (short)1248788482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_F8:
							num = (short)1428029440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA:
							goto IL_F8;
						}
						IL_1B5:
						goto IL_275;
					}
					finally
					{
						num = (short)597622786;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)243269633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_21E;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1EA;
								}
								continue;
							}
							IL_1EA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1388314624;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_21E:;
					}
					goto IL_221;
					IL_275:
					A_0.RemoveRange(list);
					num = (short)32636930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1658978305;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_221;
				}
				IL_5A:
				if (A_0 != null)
				{
					num = (short)1386545155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_221:
				num = (short)1008926720;
				short num4 = num;
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet>();
				enumerator = A_0.GetEnumerator();
				num = (short)620167168;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0006E4E8 File Offset: 0x0006C6E8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			while (this._contentLoaded)
			{
				short num = (short)2136014848;
				short num2 = num;
				num = (short)198117930;
				short num3 = num;
				num = (short)2012219946;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)7733248;
					if (num != 0)
					{
					}
					num = (short)671285249;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螧쎫\udaad\udfaf삱\udbb3\udab5\ud9b7钹ﾻ톽궿꿁ꯃꣅ诇髉鿋苏돑냓뿕럗韙뷛냝臟藡臣该跧蓩飫샭돯鷱髳苵諷闹郻跽㯿愁欃欅砇攉戋欍縏昑㬓挕欗缙減紝伟䰡倣吥䜧䘩弫ĭ䈯弱丳夵嘷弹倻圽㌿㙁慃瑅硇等手㙍ㅏ㽑㡓", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0006E5CC File Offset: 0x0006C7CC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)659549232;
			short num2 = num;
			num = (short)1684532272;
			switch (num2 == num)
			{
			}
			num = (short)337313793;
			if (num != 0)
			{
			}
			num = (short)189530112;
			short num3 = num;
			num = (short)1967980544;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0006E67C File Offset: 0x0006C87C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1961558018;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CC;
				case 1:
					goto IL_1F6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)2061500416;
				short num3 = num;
				switch (connectionId)
				{
				case 1:
					goto IL_291;
				case 2:
					goto IL_12D;
				case 3:
					goto IL_1FB;
				case 4:
					goto IL_113;
				case 5:
					goto IL_161;
				case 6:
					goto IL_208;
				case 7:
					goto IL_215;
				case 8:
					goto IL_1D2;
				case 9:
					goto IL_26A;
				case 10:
					goto IL_154;
				case 11:
					goto IL_277;
				case 12:
					goto IL_DE;
				case 13:
					goto IL_284;
				case 14:
					goto IL_13A;
				case 15:
					goto IL_D1;
				case 16:
					goto IL_22F;
				case 17:
					goto IL_222;
				case 18:
					goto IL_120;
				case 19:
				{
					num = (short)1241466175;
					short num4 = num;
					num = (short)422724927;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1A2;
					}
					break;
				}
				case 20:
					goto IL_147;
				case 21:
					goto IL_1C5;
				default:
					num = (short)741408768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CC:
				num = (short)1252720641;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			this.lnkDiscard = (global::System.Windows.Controls.Button)target;
			return;
			IL_DE:
			num = (short)1171587073;
			if (num != 0)
			{
			}
			this.btnSetVa = (global::System.Windows.Controls.Button)target;
			return;
			IL_113:
			this.mniAddSet = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_120:
			this.mniDelete = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_12D:
			this.btnAdditional = (global::System.Windows.Controls.Button)target;
			return;
			IL_13A:
			this.lnkSave = (global::System.Windows.Controls.Button)target;
			return;
			IL_147:
			this.mniShowRelatedSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_154:
			this.btnDown = (global::System.Windows.Controls.Button)target;
			return;
			IL_161:
			this.mniAddMultipleSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_1A2:
			num = (short)102694912;
			if (num != 0)
			{
			}
			this.mniAddCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_1C5:
			this.mniAddChannel = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_1D2:
			this.btnDelete = (global::System.Windows.Controls.Button)target;
			return;
			IL_1F6:
			this._contentLoaded = true;
			return;
			IL_1FB:
			this.ctmExtended = (global::System.Windows.Controls.ContextMenu)target;
			return;
			IL_208:
			this.mniAddSetCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_215:
			this.btnEdit = (global::System.Windows.Controls.Button)target;
			return;
			IL_222:
			this.mniEdit = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_22F:
			this.grdZones = (global::Infragistics.Controls.Grids.XamGrid)target;
			this.grdZones.ActiveCellChanged += this.grdZones_ActiveCellChanged;
			this.grdZones.MouseRightButtonDown += this.grdZones_MouseRightButtonDown;
			return;
			IL_26A:
			this.btnUp = (global::System.Windows.Controls.Button)target;
			return;
			IL_277:
			this.gridVoiceFileCommand = (global::System.Windows.Controls.Grid)target;
			return;
			IL_284:
			this.btnClearVa = (global::System.Windows.Controls.Button)target;
			return;
			IL_291:
			this.btnAdd = (global::System.Windows.Controls.Button)target;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0006E930 File Offset: 0x0006CB30
		// Note: this type is marked as 'beforefieldinit'.
		static RMZoneList1()
		{
			int a_ = 3;
			short num = (short)832241665;
			if (num != 0)
			{
			}
			num = (short)1406452321;
			short num2 = num;
			num = (short)1899872865;
			switch (num2 == num)
			{
			}
			num = (short)102301696;
			short num3 = num;
			num = (short)768344064;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.SetPresenterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚톢삤풦첨얪\ud9ac쪮쎰", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1.ActiveFieldProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9aﺜ좠햢삤삨캪솬쮮", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000311 RID: 785
		private const string ASTRO_ZONE_SETCATEGORY_NAME = "Zones";

		// Token: 0x04000312 RID: 786
		private const string ASTRO_CHANNEL_SETCATEGORY_NAME = "Channel";

		// Token: 0x04000313 RID: 787
		private const string PCR_ZONE_SETCATEGORY_NAME = "Zone";

		// Token: 0x04000314 RID: 788
		private const string PCR_CHANNEL_SETCATEGORY_NAME = "ConventionalPersonality";

		// Token: 0x04000315 RID: 789
		private const string SET_LIBRARY = "Motorola.CommonCPS.RadioManagement.SetLibrary";

		// Token: 0x04000316 RID: 790
		public static readonly global::System.Windows.DependencyProperty SetPresenterProperty;

		// Token: 0x04000317 RID: 791
		public static readonly global::System.Windows.DependencyProperty ActiveFieldProperty;

		// Token: 0x04000318 RID: 792
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> groupColumns = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();

		// Token: 0x04000319 RID: 793
		private bool isLoadedFieldLayout;

		// Token: 0x0400031A RID: 794
		internal global::System.Windows.Controls.Button btnAdd;

		// Token: 0x0400031B RID: 795
		internal global::System.Windows.Controls.Button btnAdditional;

		// Token: 0x0400031C RID: 796
		internal global::System.Windows.Controls.ContextMenu ctmExtended;

		// Token: 0x0400031D RID: 797
		internal global::System.Windows.Controls.MenuItem mniAddSet;

		// Token: 0x0400031E RID: 798
		internal global::System.Windows.Controls.MenuItem mniAddMultipleSets;

		// Token: 0x0400031F RID: 799
		internal global::System.Windows.Controls.MenuItem mniAddSetCopies;

		// Token: 0x04000320 RID: 800
		internal global::System.Windows.Controls.Button btnEdit;

		// Token: 0x04000321 RID: 801
		internal global::System.Windows.Controls.Button btnDelete;

		// Token: 0x04000322 RID: 802
		internal global::System.Windows.Controls.Button btnUp;

		// Token: 0x04000323 RID: 803
		internal global::System.Windows.Controls.Button btnDown;

		// Token: 0x04000324 RID: 804
		internal global::System.Windows.Controls.Grid gridVoiceFileCommand;

		// Token: 0x04000325 RID: 805
		internal global::System.Windows.Controls.Button btnSetVa;

		// Token: 0x04000326 RID: 806
		internal global::System.Windows.Controls.Button btnClearVa;

		// Token: 0x04000327 RID: 807
		internal global::System.Windows.Controls.Button lnkSave;

		// Token: 0x04000328 RID: 808
		internal global::System.Windows.Controls.Button lnkDiscard;

		// Token: 0x04000329 RID: 809
		internal global::Infragistics.Controls.Grids.XamGrid grdZones;

		// Token: 0x0400032A RID: 810
		internal global::System.Windows.Controls.MenuItem mniEdit;

		// Token: 0x0400032B RID: 811
		internal global::System.Windows.Controls.MenuItem mniDelete;

		// Token: 0x0400032C RID: 812
		internal global::System.Windows.Controls.MenuItem mniAddCopies;

		// Token: 0x0400032D RID: 813
		internal global::System.Windows.Controls.MenuItem mniShowRelatedSets;

		// Token: 0x0400032E RID: 814
		internal global::System.Windows.Controls.MenuItem mniAddChannel;

		// Token: 0x0400032F RID: 815
		private bool _contentLoaded;
	}
}
