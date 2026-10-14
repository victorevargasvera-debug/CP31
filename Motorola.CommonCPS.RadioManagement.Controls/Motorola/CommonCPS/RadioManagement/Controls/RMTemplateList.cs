using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000ED RID: 237
	public class RMTemplateList : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x00069BDC File Offset: 0x00067DDC
		public RMTemplateList()
		{
			this.InitializeComponent();
			this.dgrTemplates.SelectedItems.Records.CollectionChanged += new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.Records_CollectionChanged);
			this.dgrTemplates.SelectedItems.Cells.CollectionChanged += new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.Records_CollectionChanged);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00069C38 File Offset: 0x00067E38
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00069CF4 File Offset: 0x00067EF4
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> SelectedTemplates
		{
			get
			{
				short num = (short)1607794689;
				if (num != 0)
				{
				}
				num = (short)1215320079;
				short num2 = num;
				num = (short)1497976847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441843712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2097152000;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.SelectedTemplatesProperty);
			}
			set
			{
				short num = (short)1014529906;
				short num2 = num;
				num = (short)971145074;
				switch (num2 == num)
				{
				}
				num = (short)1750073344;
				short num3 = num;
				num = (short)630456320;
				if (num != 0)
				{
				}
				num = (short)956235777;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.SelectedTemplatesProperty, value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00069DAC File Offset: 0x00067FAC
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00069E68 File Offset: 0x00068068
		public global::System.ComponentModel.ICollectionView Templates
		{
			get
			{
				short num = (short)1001530614;
				short num2 = num;
				num = (short)1759847670;
				switch (num2 == num)
				{
				}
				num = (short)1861746688;
				short num3 = num;
				num = (short)1973157889;
				if (num != 0)
				{
				}
				num = (short)1690828800;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.TemplatesProperty) as global::System.ComponentModel.ICollectionView;
			}
			set
			{
				short num = (short)1267859457;
				if (num != 0)
				{
				}
				num = (short)1275672682;
				short num2 = num;
				num = (short)1715419242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)53477376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)62652416;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.TemplatesProperty, value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00069F20 File Offset: 0x00068120
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00069FD8 File Offset: 0x000681D8
		public global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode WorkMode
		{
			get
			{
				short num = (short)1589102809;
				short num2 = num;
				num = (short)1466878169;
				switch (num2 == num)
				{
				}
				num = (short)1825374208;
				short num3 = num;
				num = (short)327483393;
				if (num != 0)
				{
				}
				num = (short)456982528;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.WorkModeProperty);
			}
			set
			{
				short num = (short)1050742102;
				short num2 = num;
				num = (short)7736662;
				switch (num2 == num)
				{
				}
				num = (short)1830092800;
				short num3 = num;
				num = (short)1889730561;
				if (num != 0)
				{
				}
				num = (short)718733312;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.WorkModeProperty, value);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0006A090 File Offset: 0x00068290
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0006A148 File Offset: 0x00068348
		public global::System.Windows.Input.ICommand AddTemplatesCommand
		{
			get
			{
				short num = (short)2146647047;
				short num2 = num;
				num = (short)1281506311;
				switch (num2 == num)
				{
				}
				num = (short)5898240;
				short num3 = num;
				num = (short)204537856;
				if (num != 0)
				{
				}
				num = (short)1205469185;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.AddTemplatesCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)639508339;
				short num2 = num;
				num = (short)94117747;
				switch (num2 == num)
				{
				}
				num = (short)114098176;
				short num3 = num;
				num = (short)470089728;
				if (num != 0)
				{
				}
				num = (short)405471233;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.AddTemplatesCommandProperty, value);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0006A1FC File Offset: 0x000683FC
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x0006A2B4 File Offset: 0x000684B4
		public global::System.Windows.Input.ICommand DeleteTemplatesCommand
		{
			get
			{
				short num = (short)1701440717;
				short num2 = num;
				num = (short)93187277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)109379584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799684097;
				if (num != 0)
				{
				}
				num = (short)1433206784;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.DeleteTemplatesCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1720361790;
				short num2 = num;
				num = (short)619029310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110100480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811728897;
				if (num != 0)
				{
				}
				num = (short)1215102976;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.DeleteTemplatesCommandProperty, value);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x0006A36C File Offset: 0x0006856C
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x0006A424 File Offset: 0x00068624
		public global::System.Windows.Input.ICommand EditTemplateCommand
		{
			get
			{
				short num = (short)671325202;
				short num2 = num;
				num = (short)6200338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)700252160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)280559616;
				if (num != 0)
				{
				}
				num = (short)31195137;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditTemplateCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)163396550;
				short num2 = num;
				num = (short)1488141254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1853292544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1403453441;
				if (num != 0)
				{
				}
				num = (short)1597374464;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditTemplateCommandProperty, value);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060006A1 RID: 1697 RVA: 0x0006A4DC File Offset: 0x000686DC
		// (remove) Token: 0x060006A2 RID: 1698 RVA: 0x0006A590 File Offset: 0x00068790
		public event global::System.Windows.RoutedEventHandler EditModeEnding
		{
			add
			{
				short num = (short)1689252474;
				short num2 = num;
				num = (short)1737028218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526726656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1934819329;
				if (num != 0)
				{
				}
				num = (short)1912995840;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditModeEndingEvent, value);
			}
			remove
			{
				short num = (short)1607018033;
				short num2 = num;
				num = (short)1612391985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126643200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1117650944;
				if (num != 0)
				{
				}
				num = (short)1120534529;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditModeEndingEvent, value);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0006A644 File Offset: 0x00068844
		private void Records_CollectionChanged(object A_0, global::System.EventArgs A_1)
		{
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> observableCollectionFast;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> dataItemsFromSelectedCellsOrRecords;
			short num;
			for (;;)
			{
				observableCollectionFast = (this.SelectedTemplates as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>);
				dataItemsFromSelectedCellsOrRecords = this.dgrTemplates.SelectedItems.GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>();
				if (observableCollectionFast != null)
				{
					goto IL_D7;
				}
				num = (short)1076728352;
				short num2 = num;
				num = (short)226726432;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_57;
				}
			}
			IL_57:
			num = (short)1663238144;
			short num3 = num;
			num = (short)1710358529;
			if (num != 0)
			{
			}
			num = (short)1623982080;
			if (num != 0)
			{
			}
			this.SelectedTemplates.Clear();
			this.SelectedTemplates.AddRange(dataItemsFromSelectedCellsOrRecords);
			return;
			IL_D7:
			observableCollectionFast.Reset(dataItemsFromSelectedCellsOrRecords);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0006A730 File Offset: 0x00068930
		private void UserControl_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)2106785792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					goto IL_5B;
				case 2:
				{
					num = (short)1980168052;
					short num3 = num;
					num = (short)1225914228;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						goto IL_127;
					}
					break;
				}
				}
				IL_39:
				if (this.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode.Picking)
				{
					num = (short)786628609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_5B:
				num = (short)545259521;
				if (num != 0)
				{
				}
				this.dgrTemplates.HideColumn(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즧쒩쮫\udbad톯햱톳\ud9b7\ud9b9ힻ춽覿곁ꋃ꧅", a_));
				this.dgrTemplates.HideColumn(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얫슭햯솱", a_));
				this.dgrTemplates.FieldLayoutSettings.SelectionTypeRecord = global::Infragistics.Windows.Controls.SelectionType.Single;
				this.dgrTemplates.FieldSettings.CellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord;
				num = (short)1255342082;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_127:
			num = (short)844496896;
			short num4 = num;
			num = (short)1646067712;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0006A8A8 File Offset: 0x00068AA8
		private void dgrTemplates_EditModeEnding(object A_0, global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs A_1)
		{
			short num = (short)1010368766;
			short num2 = num;
			num = (short)183238910;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1697382400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)98304001;
			if (num != 0)
			{
			}
			num = (short)1947664384;
			if (num != 0)
			{
			}
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditModeEndingEvent, A_1));
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0006A964 File Offset: 0x00068B64
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			while (this._contentLoaded)
			{
				short num = (short)1944031189;
				short num2 = num;
				num = (short)1862635477;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2141126656;
					short num3 = num;
					num = (short)753991681;
					if (num != 0)
					{
					}
					num = (short)470089728;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ娧䜩堫䬭崯䈱堳圵䰷弹倻圽㌿㙁橃㹅⥇❉⁋", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0006AA48 File Offset: 0x00068C48
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)393489460;
			short num2 = num;
			num = (short)2033331252;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1130037248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1199505408;
			if (num != 0)
			{
			}
			num = (short)1338245121;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0006AAFC File Offset: 0x00068CFC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1984036866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)170065924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_109;
				case 2:
					num = (short)234291201;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 3:
					goto IL_121;
				case 4:
					if (connectionId != 2)
					{
						num = (short)22544385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_159;
				}
				IL_60:
				if (connectionId != 1)
				{
					num = (short)615710720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1760210332;
				short num3 = num;
				num = (short)463449500;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B3;
				}
				IL_109:
				num = (short)2041118723;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B3:
			num = (short)564985856;
			if (num != 0)
			{
			}
			num = (short)1210056704;
			short num4 = num;
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList)target).Loaded += this.UserControl_Loaded;
			return;
			IL_121:
			this._contentLoaded = true;
			return;
			IL_159:
			this.dgrTemplates = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0006AC78 File Offset: 0x00068E78
		// Note: this type is marked as 'beforefieldinit'.
		static RMTemplateList()
		{
			int a_ = 18;
			short num = (short)2003351158;
			short num2 = num;
			num = (short)77444726;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1250295808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1128726529;
			if (num != 0)
			{
			}
			num = (short)699531264;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.SelectedTemplatesProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("囹즫슭햯톱삳펵\udcb7\ud9bb펽낿껁ꗃ닅귇막", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList), new global::System.Windows.PropertyMetadata(new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>()));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.TemplatesProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺩ즫쎭삯\udeb1햳습\uddb7즹", a_), typeof(global::System.ComponentModel.ICollectionView), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.WorkModeProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﶩ쎫\udcad\udbafﾱ\udbb3튵\uddb7", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList), new global::System.Windows.FrameworkPropertyMetadata(global::Motorola.CommonCPS.RadioManagement.Controls.TemplateListWorkMode.Editing));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.AddTemplatesCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좫쪭ힱ\ud9b3욵풷\udbb9좻\udbbd뎿臁ꯃꯅꗇꯉꋋ꫍", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.DeleteTemplatesCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즫슭햯욱톳\uddb7ힹ첻튽ꆿ뛁ꇃ뗅诇ꗉꇋꏍ뇏병냓", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditTemplateCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좫잭쒯톳\udbb5좷횹\uddbb쪽ꖿ臁ꯃꯅꗇꯉꋋ꫍", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList.EditModeEndingEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좫잭쒯ﾱ\udbb3튵\uddb7ﾹ튻\udabdꦿ곁ꏃ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList));
		}

		// Token: 0x040002EF RID: 751
		public static readonly global::System.Windows.DependencyProperty SelectedTemplatesProperty;

		// Token: 0x040002F0 RID: 752
		public static readonly global::System.Windows.DependencyProperty TemplatesProperty;

		// Token: 0x040002F1 RID: 753
		public static readonly global::System.Windows.DependencyProperty WorkModeProperty;

		// Token: 0x040002F2 RID: 754
		public static readonly global::System.Windows.DependencyProperty AddTemplatesCommandProperty;

		// Token: 0x040002F3 RID: 755
		public static readonly global::System.Windows.DependencyProperty DeleteTemplatesCommandProperty;

		// Token: 0x040002F4 RID: 756
		public static readonly global::System.Windows.DependencyProperty EditTemplateCommandProperty;

		// Token: 0x040002F6 RID: 758
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrTemplates;

		// Token: 0x040002F7 RID: 759
		private bool _contentLoaded;
	}
}
