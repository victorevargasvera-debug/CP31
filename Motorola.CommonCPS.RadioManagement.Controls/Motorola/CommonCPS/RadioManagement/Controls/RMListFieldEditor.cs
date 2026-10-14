using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000105 RID: 261
	public class RMListFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x0007D914 File Offset: 0x0007BB14
		public RMListFieldEditor()
		{
			this.InitializeComponent();
			base.AlignMainGridMaxWithEditor(this, this.grdMain);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0007D93C File Offset: 0x0007BB3C
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)1132003328;
				short num2 = num;
				num = (short)1747323003;
				short num3 = num;
				num = (short)617089147;
				switch (num3 == num)
				{
				}
				num = (short)468058113;
				if (num != 0)
				{
				}
				num = (short)982515712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)1710948352;
				short num2 = num;
				num = (short)2051661063;
				short num3 = num;
				num = (short)1777261831;
				switch (num3 == num)
				{
				}
				num = (short)1264386048;
				if (num != 0)
				{
				}
				num = (short)422445057;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0007DAAC File Offset: 0x0007BCAC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)751130213;
			short num2 = num;
			num = (short)23877221;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1902575616;
				if (num != 0)
				{
				}
				if ((bool)A_1.NewValue)
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor rmlistFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)A_0;
					global::System.Windows.Data.BindingOperations.ClearBinding(rmlistFieldEditor.grdMain, global::System.Windows.FrameworkElement.MaxWidthProperty);
					rmlistFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
					rmlistFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
					rmlistFieldEditor.grdMain.ColumnDefinitions[3].Width = global::System.Windows.GridLength.Auto;
					return;
				}
				break;
			}
			num = (short)25231360;
			short num3 = num;
			num = (short)398655489;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0007DBE4 File Offset: 0x0007BDE4
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x0007DC9C File Offset: 0x0007BE9C
		public bool? IsSortRequired
		{
			get
			{
				short num = (short)1297940480;
				short num2 = num;
				num = (short)1569166094;
				short num3 = num;
				num = (short)2095354638;
				switch (num3 == num)
				{
				}
				num = (short)199950337;
				if (num != 0)
				{
				}
				num = (short)2077229056;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsSortRequiredProperty);
			}
			set
			{
				short num = (short)416940032;
				short num2 = num;
				num = (short)1898971137;
				if (num != 0)
				{
				}
				num = (short)1537389488;
				short num3 = num;
				num = (short)1303884720;
				switch (num3 == num)
				{
				}
				num = (short)1367670784;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsSortRequiredProperty, value);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060007C3 RID: 1987 RVA: 0x0007DD58 File Offset: 0x0007BF58
		// (remove) Token: 0x060007C4 RID: 1988 RVA: 0x0007DE10 File Offset: 0x0007C010
		public event global::System.Windows.RoutedEventHandler SelectSetRequested
		{
			add
			{
				short num = (short)576323584;
				short num2 = num;
				num = (short)2081886193;
				short num3 = num;
				num = (short)2012942321;
				switch (num3 == num)
				{
				}
				num = (short)928382977;
				if (num != 0)
				{
				}
				num = (short)1443037184;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.SelectSetRequestedEvent, value);
			}
			remove
			{
				short num = (short)34340864;
				short num2 = num;
				num = (short)571801601;
				if (num != 0)
				{
				}
				num = (short)605242600;
				short num3 = num;
				num = (short)1856980200;
				switch (num3 == num)
				{
				}
				num = (short)683802624;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.SelectSetRequestedEvent, value);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0007DEC8 File Offset: 0x0007C0C8
		private void cbbList_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)78446592;
			switch (num)
			{
			default:
			{
				num = (short)607780864;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 1:
						num = (short)1782251530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_1.AddedItems.Count == 0)
						{
							num = (short)1137901572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2030043147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.cbbList.SelectedItem = null;
						num = (short)1974272006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1E5;
					case 5:
						return;
					case 6:
						goto IL_230;
					case 7:
						goto IL_DD;
					case 8:
						if (((global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem)A_1.AddedItems[0]).Name == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Show_Sets)
						{
							num = (short)1676738573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)1007484930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (base.DataContext != null)
						{
							num = (short)1837694993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 11:
					{
						if (A_1.AddedItems.Count <= 0)
						{
							goto IL_DD;
						}
						num = (short)956170241;
						if (num != 0)
						{
						}
						num = (short)1097319811;
						short num3 = num;
						num = (short)1461044611;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)766312448;
							if (num != 0)
							{
							}
							num = (short)831586305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_230;
					case 13:
					{
						this.cbbList.SelectionChanged -= this.cbbList_SelectionChanged;
						global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit;
						int count = listEdit.Items.Count;
						base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.SelectSetRequestedEvent, listEdit));
						num = (short)1966080016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit;
						int count;
						if (count != listEdit.Items.Count)
						{
							num = (short)1565851663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_230;
					}
					case 15:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit;
						listEdit.SelectedIndex = listEdit.Items.Count - 1;
						listEdit.SelectedIndex = listEdit.Items.Count - 2;
						num = (short)355139596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (this.cbbList.SelectedIndex == -1)
						{
							num = (short)619315203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)135397390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit2 = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit;
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> items = listEdit2.Items;
						num = (short)2107310087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8F:
					if (A_1.AddedItems != null)
					{
						num = (short)1628766217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_DD:
					num = (short)631046144;
					short num4 = num;
					num = (short)1764491272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_230:
					this.cbbList.SelectionChanged += this.cbbList_SelectionChanged;
					num = (short)117309445;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1E5:
				return;
			}
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0007E2E8 File Offset: 0x0007C4E8
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1830158337;
			if (num != 0)
			{
			}
			num = (short)1775563078;
			short num2 = num;
			num = (short)1288237382;
			switch (num2 == num)
			{
			default:
			{
				num = (short)688259072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1993211904;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0007E3B4 File Offset: 0x0007C5B4
		public void fedList_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)55574528;
			short num2 = num;
			num = (short)1851916289;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					num = (short)1076887553;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit;
					goto IL_FA;
				}
				}
				IL_82:
				num = (short)123726755;
				short num4 = num;
				num = (short)875424675;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_FA:
					num = (short)1930362880;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)138674176;
					if (num != 0)
					{
					}
					if (base.DataContext == null)
					{
						return;
					}
					num = (short)491782146;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
		private void cbbList_GotFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1378353152;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool isSortRequired2;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 1:
				{
					bool? isSortRequired;
					if (isSortRequired != null)
					{
						num = (short)479789069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				}
				case 2:
				{
					num = (short)528875520;
					short num3 = num;
					if (((global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)A_0).IsDropDownOpen)
					{
						num = (short)3538954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B1;
				}
				case 3:
					num = (short)375455745;
					if (num != 0)
					{
					}
					(base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit).RefreshChoices(isSortRequired2);
					num = (short)10223627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1579089922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (!(base.DataContext is global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit))
					{
						num = (short)2036793351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					isSortRequired2 = false;
					bool? isSortRequired = this.IsSortRequired;
					num = (short)1106837505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (!(base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit).IsReferField)
					{
						num = (short)1817640963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					return;
				case 8:
					goto IL_141;
				case 9:
					num = (short)426508293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return;
				case 11:
					goto IL_26F;
				case 12:
					if (base.DataContext != null)
					{
						num = (short)1909850121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
				{
					bool? isSortRequired = this.IsSortRequired;
					isSortRequired2 = isSortRequired.Value;
					num = (short)1889009678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_141;
				}
				IL_61:
				if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox))
				{
					goto IL_2B1;
				}
				num = (short)486851233;
				short num4 = num;
				num = (short)1970389665;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2013724672;
					if (num != 0)
					{
					}
					num = (short)1213267972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D1:
				isSortRequired2 = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit).SortedDefaultValue;
				num = (short)469368840;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_141:
				num = (short)1402994694;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B1:
				num = (short)24182796;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_26F:;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0007E7CC File Offset: 0x0007C9CC
		public override void SetFocus()
		{
			short num = (short)2141910170;
			short num2 = num;
			num = (short)459011226;
			switch (num2 == num)
			{
			}
			num = (short)1291190272;
			short num3 = num;
			num = (short)157745153;
			if (num != 0)
			{
			}
			num = (short)1890844672;
			if (num != 0)
			{
			}
			this.cbbList.Focus();
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0007E880 File Offset: 0x0007CA80
		public override void SetCellValuePresenterMode()
		{
			short num = (short)1252273055;
			short num2 = num;
			num = (short)754199455;
			switch (num2 == num)
			{
			}
			num = (short)1231028224;
			short num3 = num;
			num = (short)1227096065;
			if (num != 0)
			{
			}
			num = (short)368705536;
			if (num != 0)
			{
			}
			this.cbbList.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.cbbList.Background = global::System.Windows.Media.Brushes.Transparent;
			this.borderfreeze.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0007E954 File Offset: 0x0007CB54
		public override void HideBorder()
		{
			short num = (short)1124098779;
			short num2 = num;
			num = (short)1956340443;
			switch (num2 == num)
			{
			}
			num = (short)524812288;
			short num3 = num;
			num = (short)22282241;
			if (num != 0)
			{
			}
			num = (short)1745813504;
			if (num != 0)
			{
			}
			this.cbbList.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.cbbList.Background = global::System.Windows.Media.Brushes.Transparent;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0007EA20 File Offset: 0x0007CC20
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			short num;
			if (this._contentLoaded)
			{
				num = (short)368294104;
				short num2 = num;
				num = (short)1921890520;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1157955584;
					if (num != 0)
					{
					}
					num = (short)923598848;
					short num3 = num;
					return;
				}
				}
			}
			num = (short)23068673;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("놝춡킣즥\udaa7얩삫쾭麯\udbb3\udbb5햷햹튻ﶽ邿釁铅꧇껉ꗋꇍ鷏돑뫓럕뿗뿙뇛믝軟雡쫣ꗥ蟧蓩飫鳭鿯黱蟳췵鯷闹釻軽濿氁愃栅簇┉礋納甏怑眓礕瘗渙減焝䰟儡ଣ䀥䄧伩䀫䨭唯嘱崳䈵圷䠹伻ᄽ㈿⽁⡃⽅㭇㹉⩋❍㕏㹑こ㍕㱗㍙⡛ㅝ቟䱡ᱣݥէ٩", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0007EB00 File Offset: 0x0007CD00
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)512214128;
			short num2 = num;
			num = (short)1208730736;
			switch (num2 == num)
			{
			}
			num = (short)1048117248;
			short num3 = num;
			num = (short)1365704705;
			if (num != 0)
			{
			}
			num = (short)304087040;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0007EBB4 File Offset: 0x0007CDB4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1623326721;
			if (num != 0)
			{
			}
			num = (short)5319168;
			short num2 = num;
			num = (short)1984506368;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A0:
				switch (connectionId)
				{
				case 1:
					this.fedList = (global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor)target;
					return;
				case 2:
					this.grdMain = (global::System.Windows.Controls.Grid)target;
					return;
				case 3:
					this.tblLabel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
					return;
				case 4:
					this.cbbList = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
					return;
				case 5:
					this.borderfreeze = (global::System.Windows.Controls.Border)target;
					return;
				case 6:
					this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
					return;
				default:
					num = (short)268959746;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			default:
				num = (short)767557632;
				if (num != 0)
				{
				}
				num = (short)1539047425;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_14F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A0;
					}
					continue;
				case 2:
				{
					num = (short)1908277248;
					short num4 = num;
					num = (short)904331264;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_A0;
			}
			IL_14F:
			this._contentLoaded = true;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0007ED34 File Offset: 0x0007CF34
		// Note: this type is marked as 'beforefieldinit'.
		static RMListFieldEditor()
		{
			int a_ = 17;
			short num = (short)2139662957;
			short num2 = num;
			num = (short)1310632557;
			switch (num2 == num)
			{
			}
			num = (short)1066401792;
			short num3 = num;
			num = (short)349831169;
			if (num != 0)
			{
			}
			num = (short)792854528;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8aa쮮\ud8b0잲\udab4얶햺톼욾", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.IsSortRequiredProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8aaﺬ삮쎰잲튶좸캺풼춾꓀Ꟃ", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.SelectSetRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("直캪솬쪮튰잲튶춸\ud8bc캾듀ꛂ뛄돆곈꿊", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor));
		}

		// Token: 0x04000383 RID: 899
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x04000384 RID: 900
		public static readonly global::System.Windows.DependencyProperty IsSortRequiredProperty;

		// Token: 0x04000386 RID: 902
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor fedList;

		// Token: 0x04000387 RID: 903
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x04000388 RID: 904
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock tblLabel;

		// Token: 0x04000389 RID: 905
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbbList;

		// Token: 0x0400038A RID: 906
		internal global::System.Windows.Controls.Border borderfreeze;

		// Token: 0x0400038B RID: 907
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x0400038C RID: 908
		private bool _contentLoaded;
	}
}
