using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Practices.Prism;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000EC RID: 236
	public class RMRadioDetail : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x00068D28 File Offset: 0x00066F28
		public RMRadioDetail()
		{
			this.InitializeComponent();
			this.dgrDetails.SelectedItems.Records.CollectionChanged += this.Records_CollectionChanged;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00068D64 File Offset: 0x00066F64
		private void a()
		{
			short num = (short)809369600;
			short num2 = num;
			num = (short)629525326;
			short num3 = num;
			num = (short)1784138574;
			switch (num3 == num)
			{
			}
			num = (short)719912960;
			if (num != 0)
			{
			}
			num = (short)1414004737;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00068E0C File Offset: 0x0006700C
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00068EC4 File Offset: 0x000670C4
		public bool AllowDoOperation
		{
			get
			{
				short num = (short)1725300736;
				short num2 = num;
				num = (short)1600165182;
				short num3 = num;
				num = (short)899323198;
				switch (num3 == num)
				{
				}
				num = (short)1015742464;
				if (num != 0)
				{
				}
				num = (short)1754202113;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail.AllowDoOperationProperty);
			}
			set
			{
				short num = (short)1477640192;
				short num2 = num;
				num = (short)531870622;
				short num3 = num;
				num = (short)410497950;
				switch (num3 == num)
				{
				}
				num = (short)721158145;
				if (num != 0)
				{
				}
				num = (short)1430323200;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail.AllowDoOperationProperty, value);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00068F80 File Offset: 0x00067180
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00069038 File Offset: 0x00067238
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> SelectedJobs
		{
			get
			{
				short num = (short)1522335744;
				short num2 = num;
				num = (short)1731133441;
				if (num != 0)
				{
				}
				num = (short)1563007425;
				short num3 = num;
				num = (short)40868289;
				switch (num3 == num)
				{
				}
				num = (short)1705377792;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail.SelectedJobsProperty);
			}
			set
			{
				short num = (short)1327038464;
				short num2 = num;
				num = (short)1090000993;
				short num3 = num;
				num = (short)1942493281;
				switch (num3 == num)
				{
				}
				num = (short)1104609281;
				if (num != 0)
				{
				}
				num = (short)2141126656;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail.SelectedJobsProperty, value);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000690EC File Offset: 0x000672EC
		private void Records_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1516371968;
			short num2 = num;
			num = (short)1769537653;
			short num3 = num;
			num = (short)1275199605;
			switch (num3 == num)
			{
			}
			num = (short)505872385;
			if (num != 0)
			{
			}
			num = (short)1861025792;
			if (num != 0)
			{
			}
			this.SelectedJobs.Clear();
			this.SelectedJobs.AddRange(this.dgrDetails.SelectedItems.GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>());
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000691BC File Offset: 0x000673BC
		private void DgrDetails_OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)402980869;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)67829761;
					if (num != 0)
					{
					}
					num = (short)392629342;
					short num3 = num;
					num = (short)1264651358;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_152;
					default:
						num = (short)782368768;
						if (num != 0)
						{
						}
						this.dgrDetails.ContextMenu.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)1429274627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.AllowDoOperation)
					{
						num = (short)202833920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.dgrDetails.ContextMenu.Visibility = global::System.Windows.Visibility.Collapsed;
					goto IL_152;
				case 2:
					return;
				case 3:
					goto IL_D8;
				case 4:
					goto IL_169;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (this.dgrDetails.ContextMenu == null)
				{
					num = (short)1257439234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1872297985;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_152:
				num = (short)1392443396;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_D8:
			goto IL_194;
			IL_169:
			num = (short)975568896;
			short num4 = num;
			IL_194:
			this.a();
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00069364 File Offset: 0x00067564
		private void JobHistory_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)404422657;
			if (num != 0)
			{
			}
			num = (short)1958414731;
			short num2 = num;
			num = (short)978651531;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1387134976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1994391552;
			if (num != 0)
			{
			}
			this.lblRadioAlias.Visibility = global::System.Windows.Visibility.Visible;
			this.txtRadioAlias.Visibility = global::System.Windows.Visibility.Visible;
			this.lblConfiguration.Visibility = global::System.Windows.Visibility.Collapsed;
			this.txtConfiguration.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00069440 File Offset: 0x00067640
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			if ((bool)A_1.NewValue)
			{
				short num;
				for (;;)
				{
					num = (short)107216897;
					if (num != 0)
					{
					}
					num = (short)276789105;
					short num2 = num;
					num = (short)2094692209;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_96;
					}
					break;
				}
				num = (short)1738276864;
				short num3 = num;
				IL_96:
				num = (short)1762656256;
				if (num != 0)
				{
				}
				this.lbRadioInfo.IsSelected = true;
				return;
			}
			this.lbJobHistory.IsSelected = true;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00069514 File Offset: 0x00067714
		private void lsbGroup_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)1955659777;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			int num2;
			global::System.Windows.Controls.ListBox listBox;
			for (;;)
			{
				IL_30:
				object obj;
				switch (num2)
				{
				case 0:
					goto IL_14E;
				case 1:
					obj = A_1.RemovedItems[0];
					num = (short)1896218624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)981815340;
					short num3 = num;
					num = (short)970674220;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14E;
					default:
					{
						num = (short)69074944;
						short num4 = num;
						num = (short)263389184;
						if (num != 0)
						{
						}
						listBox.SelectedItem = obj;
						num = (short)170131460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					if (A_1.RemovedItems.Count > 0)
					{
						num = (short)1123090433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					num = (short)1178599427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (listBox.SelectedItem == null)
					{
						num = (short)100204549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_52;
				IL_14E:
				if (!listBox.Items.Contains(obj))
				{
					break;
				}
				num = (short)884408322;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_52:
			listBox = (global::System.Windows.Controls.ListBox)A_0;
			num = (short)1214775302;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000696E0 File Offset: 0x000678E0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 19;
			if (this._contentLoaded)
			{
				short num;
				for (;;)
				{
					num = (short)315383587;
					short num2 = num;
					num = (short)2041012003;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4C;
					}
				}
				IL_4C:
				num = (short)18153472;
				short num3 = num;
				num = (short)1377697793;
				if (num != 0)
				{
				}
				num = (short)491192320;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("蒪삮얰\udcb2잴\ud8b6햸\udaba鎼ﲾ껀껂꣄꣆ꟈ裊鷌鳎￐臒듔돖냘듚郜뻞迠苢苤苦蓨軪菬鯮\udff0냲髴駶跸觺鋼鏾爀㠂昄栆搈笊戌愎琐紒愔㠖氘栚砜洞䈠䰢䬤匦嬨䐪䄬尮Ḱ䄲場䔶堸强吼倾╀♂ㅄ♆⁈❊捌㝎ぐ㹒㥔", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000697C4 File Offset: 0x000679C4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1523553952;
			short num2 = num;
			num = (short)237016736;
			switch (num2 == num)
			{
			}
			num = (short)300089344;
			short num3 = num;
			num = (short)1554382849;
			if (num != 0)
			{
			}
			num = (short)2118909952;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00069874 File Offset: 0x00067A74
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1499398146;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)727252993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_20C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_D6;
				case 2:
					goto IL_A5;
				case 3:
					goto IL_121;
				case 4:
					goto IL_1E7;
				case 5:
					goto IL_211;
				case 6:
					goto IL_114;
				case 7:
					goto IL_229;
				case 8:
					goto IL_98;
				case 9:
					goto IL_FA;
				case 10:
					goto IL_8B;
				case 11:
					goto IL_1DA;
				case 12:
					goto IL_C9;
				case 13:
					goto IL_1CD;
				case 14:
					goto IL_107;
				default:
					num = (short)111607808;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_8B:
			this.lblModelNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_98:
			this.lblRadioAlias = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_A5:
			this.lbRadioInfo = (global::System.Windows.Controls.ListBoxItem)target;
			this.lbRadioInfo.IsVisibleChanged += this.a;
			return;
			IL_C9:
			this.lblConfiguration = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_D6:
			this.lsbGroup = (global::System.Windows.Controls.ListBox)target;
			this.lsbGroup.SelectionChanged += this.lsbGroup_SelectionChanged;
			return;
			IL_FA:
			this.txtRadioAlias = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_107:
			this.dgrDetails = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_114:
			this.bdJobHistory = (global::System.Windows.Controls.Border)target;
			return;
			IL_121:
			num = (short)400469459;
			short num3 = num;
			num = (short)598519251;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1E7:
				this.lbFeatures = (global::System.Windows.Controls.ListBoxItem)target;
				return;
			default:
			{
				num = (short)643366913;
				if (num != 0)
				{
				}
				num = (short)875298816;
				short num4 = num;
				num = (short)1885405184;
				if (num != 0)
				{
				}
				this.lbJobHistory = (global::System.Windows.Controls.ListBoxItem)target;
				return;
			}
			}
			IL_1CD:
			this.txtConfiguration = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_1DA:
			this.txtModelNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_20C:
			this._contentLoaded = true;
			return;
			IL_211:
			((global::System.Windows.Controls.Grid)target).Loaded += this.JobHistory_Loaded;
			return;
			IL_229:
			this.gridDetails = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00069AC0 File Offset: 0x00067CC0
		// Note: this type is marked as 'beforefieldinit'.
		static RMRadioDetail()
		{
			int a_ = 5;
			short num = (short)1876633646;
			short num2 = num;
			num = (short)381036590;
			switch (num2 == num)
			{
			}
			num = (short)1608450048;
			short num3 = num;
			num = (short)1170669568;
			if (num != 0)
			{
			}
			num = (short)1537081345;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail.AllowDoOperationProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udc9c춠첢튤욨\uddac쪮쎰튲솴\udeb6횸햺", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail.SelectedJobsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캜爵춠욢욤펦첨쾪삮펰삲", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMRadioDetail), new global::System.Windows.PropertyMetadata(new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>()));
		}

		// Token: 0x040002DF RID: 735
		public static readonly global::System.Windows.DependencyProperty AllowDoOperationProperty;

		// Token: 0x040002E0 RID: 736
		public static readonly global::System.Windows.DependencyProperty SelectedJobsProperty;

		// Token: 0x040002E1 RID: 737
		internal global::System.Windows.Controls.ListBox lsbGroup;

		// Token: 0x040002E2 RID: 738
		internal global::System.Windows.Controls.ListBoxItem lbRadioInfo;

		// Token: 0x040002E3 RID: 739
		internal global::System.Windows.Controls.ListBoxItem lbJobHistory;

		// Token: 0x040002E4 RID: 740
		internal global::System.Windows.Controls.ListBoxItem lbFeatures;

		// Token: 0x040002E5 RID: 741
		internal global::System.Windows.Controls.Border bdJobHistory;

		// Token: 0x040002E6 RID: 742
		internal global::System.Windows.Controls.Grid gridDetails;

		// Token: 0x040002E7 RID: 743
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock lblRadioAlias;

		// Token: 0x040002E8 RID: 744
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock txtRadioAlias;

		// Token: 0x040002E9 RID: 745
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock lblModelNumber;

		// Token: 0x040002EA RID: 746
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock txtModelNumber;

		// Token: 0x040002EB RID: 747
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock lblConfiguration;

		// Token: 0x040002EC RID: 748
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock txtConfiguration;

		// Token: 0x040002ED RID: 749
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrDetails;

		// Token: 0x040002EE RID: 750
		private bool _contentLoaded;
	}
}
