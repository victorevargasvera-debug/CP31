using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Controls.SetsImportExport;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000108 RID: 264
	public class RMSetPresenter : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x000801C4 File Offset: 0x0007E3C4
		public RMSetPresenter()
		{
			this.InitializeComponent();
			this.ShowFieldIdCommmand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.d));
			this.dgrSets.Records.CollectionChanged += this.Records_CollectionChanged;
			this.grdEditor.PreviewMouseWheel += this.grdEditor_PreviewMouseWheel;
			this.gridSets.PreviewMouseWheel += this.gridSets_PreviewMouseWheel_Grid;
			this.dgrSets.SelectedItems.Records.CollectionChanged += this.SelectedRecords_CollectionChanged;
			base.PreviewKeyDown += this.RMSetPresenter_PreviewKeyDown;
			this.dgrSets.PreviewMouseLeftButtonDown += this.dgrSets_PreviewMouseLeftButtonDown;
			this.EditCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.o), new global::System.Func<bool>(this.p));
			global::Microsoft.Practices.Prism.Events.IEventAggregator instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
			instance.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DisplaySettingsChangedEvent>().Subscribe(new global::System.Action<global::System.EventArgs>(this.SystemEvents_DisplaySettingsChanged));
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000802FC File Offset: 0x0007E4FC
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x000803AC File Offset: 0x0007E5AC
		public global::System.Windows.Input.ICommand EditCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1296058446;
				short num2 = num;
				num = (short)991840334;
				switch (num2 == num)
				{
				}
				num = (short)1232207873;
				if (num != 0)
				{
				}
				num = (short)1459290112;
				if (num != 0)
				{
				}
				num = (short)1515913216;
				short num3 = num;
				return this.<EditCommand>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)800214799;
				short num2 = num;
				num = (short)1956204303;
				switch (num2 == num)
				{
				}
				num = (short)547684353;
				if (num != 0)
				{
				}
				num = (short)1947271168;
				if (num != 0)
				{
				}
				num = (short)782761984;
				short num3 = num;
				this.<EditCommand>k__BackingField = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0008045C File Offset: 0x0007E65C
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00080514 File Offset: 0x0007E714
		public bool IsShowingFields
		{
			get
			{
				short num = (short)1698265215;
				short num2 = num;
				num = (short)1675720831;
				switch (num2 == num)
				{
				}
				num = (short)242286592;
				if (num != 0)
				{
				}
				num = (short)1913192449;
				if (num != 0)
				{
				}
				num = (short)1641480192;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.IsShowingFieldsProperty);
			}
			set
			{
				short num = (short)830865409;
				if (num != 0)
				{
				}
				num = (short)878623183;
				short num2 = num;
				num = (short)232110543;
				switch (num2 == num)
				{
				}
				num = (short)1394999296;
				if (num != 0)
				{
				}
				num = (short)569311232;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.IsShowingFieldsProperty, value);
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000805CC File Offset: 0x0007E7CC
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)A_0;
			if (rmsetPresenter.IsShowingFields)
			{
				short num = (short)1969450096;
				short num2 = num;
				num = (short)695692400;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)237436928;
					short num3 = num;
					num = (short)992018433;
					if (num != 0)
					{
					}
					num = (short)349765632;
					if (num != 0)
					{
					}
					rmsetPresenter.ShowFields();
					return;
				}
				}
			}
			rmsetPresenter.ResetLayout();
			rmsetPresenter.n();
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x0008069C File Offset: 0x0007E89C
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00080758 File Offset: 0x0007E958
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> SelectedSets
		{
			get
			{
				short num = (short)604034657;
				short num2 = num;
				num = (short)1414518369;
				switch (num2 == num)
				{
				}
				num = (short)1329790977;
				if (num != 0)
				{
				}
				num = (short)1541472256;
				if (num != 0)
				{
				}
				num = (short)200015872;
				short num3 = num;
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectedSetsProperty);
			}
			set
			{
				short num = (short)915560958;
				short num2 = num;
				num = (short)389175806;
				switch (num2 == num)
				{
				}
				num = (short)816906241;
				if (num != 0)
				{
				}
				num = (short)2117468160;
				if (num != 0)
				{
				}
				num = (short)1609498624;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectedSetsProperty, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00080810 File Offset: 0x0007EA10
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x000808CC File Offset: 0x0007EACC
		public bool UseGlueWindow
		{
			get
			{
				short num = (short)1457540972;
				short num2 = num;
				num = (short)320884588;
				switch (num2 == num)
				{
				}
				num = (short)1696071681;
				if (num != 0)
				{
				}
				num = (short)806420480;
				if (num != 0)
				{
				}
				num = (short)1494876160;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.UseGlueWindowProperty);
			}
			set
			{
				short num = (short)852426753;
				if (num != 0)
				{
				}
				num = (short)1902784039;
				short num2 = num;
				num = (short)273231399;
				switch (num2 == num)
				{
				}
				num = (short)2020081664;
				if (num != 0)
				{
				}
				num = (short)373620736;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.UseGlueWindowProperty, value);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00080984 File Offset: 0x0007EB84
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00080A40 File Offset: 0x0007EC40
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory SetCategory
		{
			get
			{
				short num = (short)105190844;
				short num2 = num;
				num = (short)183506364;
				switch (num2 == num)
				{
				}
				num = (short)552992769;
				if (num != 0)
				{
				}
				num = (short)2139357184;
				if (num != 0)
				{
				}
				num = (short)913375232;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SetCategoryProperty);
			}
			set
			{
				short num = (short)1190054323;
				short num2 = num;
				num = (short)1358743987;
				switch (num2 == num)
				{
				}
				num = (short)62259200;
				if (num != 0)
				{
				}
				num = (short)796917761;
				if (num != 0)
				{
				}
				num = (short)663093248;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SetCategoryProperty, value);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00080AF4 File Offset: 0x0007ECF4
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_C8;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_74C;
				case 1:
					if (rmsetPresenter.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Picking)
					{
						num2 = (short)883687437;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_114;
				case 2:
					if (rmsetPresenter.SetCategory == null)
					{
						num2 = (short)568393736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)33161254;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (rmsetPresenter.SetCategory.MaxCapacity == 1)
					{
						num2 = (short)1482096658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_357;
				case 4:
					rmsetPresenter.ShowFields();
					num2 = (short)200867840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_114;
				case 6:
					goto IL_584;
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
					if (setCategory != null)
					{
						num2 = (short)2113994787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_544;
				}
				case 8:
					return;
				case 9:
					if (rmsetPresenter.SetCategory == null)
					{
						num2 = (short)291897380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)194576395;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (rmsetPresenter.SetCategory.IsExpandEmbeddedSet)
					{
						num2 = (short)1551564812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)710541328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					rmsetPresenter.dgrSets.FieldLayoutSettings.SelectionTypeRecord = ((rmsetPresenter.SetCategory.MaxCapacity == 1) ? global::Infragistics.Windows.Controls.SelectionType.Single : global::Infragistics.Windows.Controls.SelectionType.Default);
					num2 = (short)1526202398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)751829018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					rmsetPresenter.gridToolBar.Visibility = global::System.Windows.Visibility.Collapsed;
					num2 = (short)531365911;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (rmsetPresenter.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Editing)
					{
						num2 = (short)1523056661;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					rmsetPresenter.ResetLayout();
					num2 = (short)1986461705;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_562;
				case 16:
					if (rmsetPresenter.IsShowingFields)
					{
						num2 = (short)2141323288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					rmsetPresenter.ResetLayout();
					num2 = (short)1574502406;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					rmsetPresenter.ShowFields();
					num2 = (short)1678901275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)695468071;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					rmsetPresenter.SetCategory.ActiveSet = rmsetPresenter.SetCategory.Sets[0];
					num2 = (short)339542061;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)1950351385;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)2139881500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)2049703939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_114;
				case 24:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = A_1.OldValue as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
					num2 = (short)189988871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 25:
					if (!rmsetPresenter.SetCategory.TelePortMode)
					{
						num2 = (short)1167392805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E1;
				case 26:
					if (rmsetPresenter.IsShowingFields)
					{
						num2 = (short)332267524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					rmsetPresenter.IsShowingFields = true;
					num2 = (short)219873321;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_728;
				case 28:
					if (rmsetPresenter.SetCategory.IsTopSet)
					{
						num2 = (short)1546190870;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_357;
				case 29:
					num2 = (short)896401451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					goto IL_6BC;
				case 31:
					goto IL_5F2;
				case 32:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
					if (setCategory.IsExpandEmbeddedSet)
					{
						num2 = (short)1234305053;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_544;
				}
				case 33:
					goto IL_114;
				case 34:
					goto IL_233;
				case 35:
					num2 = (short)1676476448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					return;
				case 37:
					num2 = (short)680132648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					if (rmsetPresenter.SetCategory.IsTopSet)
					{
						num2 = (short)1345585172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					rmsetPresenter.dgrSets.FieldSettings.AllowEdit = new bool?(true);
					num2 = (short)994443269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					if (rmsetPresenter.SetCategory.Sets.Count > 0)
					{
						num2 = (short)213581843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_357;
				case 40:
					if (rmsetPresenter.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Picking)
					{
						num2 = (short)1592000556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					rmsetPresenter.dgrSets.FieldSettings.AllowEdit = new bool?(true);
					num2 = (short)1440350241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					goto IL_656;
				case 42:
					rmsetPresenter.ShowFields();
					num2 = (short)431226914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
					if (setCategory.ParentSetCategory == rmsetPresenter.SetCategory)
					{
						num2 = (short)2039021585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_544;
				}
				case 44:
					goto IL_3E1;
				case 45:
					if (rmsetPresenter.IsShowingFields)
					{
						num2 = (short)1512570922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					rmsetPresenter.IsShowingFields = true;
					num2 = (short)1823277087;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_C8;
				IL_114:
				num2 = (short)936509454;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_357:
				num2 = (short)45023242;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3E1:
				rmsetPresenter.dgrSets.FieldSettings.AllowEdit = new bool?(false);
				rmsetPresenter.dgrSets.FieldSettings.CellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord;
				num2 = (short)618463233;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_544:
				rmsetPresenter.IsShowingFields = false;
				num2 = (short)2100559887;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_233:
			num2 = (short)1717370880;
			short num3 = num2;
			IL_562:
			goto IL_80A;
			IL_584:
			num2 = (short)2016950290;
			short num4 = num2;
			num2 = (short)156186642;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_728:
				break;
			default:
				num2 = (short)1988558848;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_5F2:
			IL_656:
			IL_6BC:
			goto IL_80A;
			IL_74C:
			num2 = (short)1223688193;
			if (num2 != 0)
			{
			}
			IL_80A:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.a(rmsetPresenter);
			return;
			IL_C8:
			rmsetPresenter = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)A_0;
			rmsetPresenter.currentSetCategoryForTopSetEditing = null;
			num2 = (short)1351745538;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00081314 File Offset: 0x0007F514
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x000813D0 File Offset: 0x0007F5D0
		public global::System.Windows.Data.IValueConverter FlatSetConverter
		{
			get
			{
				short num = (short)1603879539;
				short num2 = num;
				num = (short)18760307;
				switch (num2 == num)
				{
				}
				num = (short)1523122177;
				if (num != 0)
				{
				}
				num = (short)37027840;
				if (num != 0)
				{
				}
				num = (short)1428815872;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FlatSetConverterProperty) as global::System.Windows.Data.IValueConverter;
			}
			set
			{
				short num = (short)2059778006;
				short num2 = num;
				num = (short)1720235990;
				switch (num2 == num)
				{
				}
				num = (short)947126273;
				if (num != 0)
				{
				}
				num = (short)16646144;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FlatSetConverterProperty, value);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00081488 File Offset: 0x0007F688
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00081540 File Offset: 0x0007F740
		public global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode WorkMode
		{
			get
			{
				short num = (short)527645248;
				short num2 = num;
				num = (short)1951218240;
				switch (num2 == num)
				{
				}
				num = (short)790691840;
				if (num != 0)
				{
				}
				num = (short)1144127489;
				if (num != 0)
				{
				}
				num = (short)1310523392;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.WorkModeProperty);
			}
			set
			{
				short num = (short)166952051;
				short num2 = num;
				num = (short)1702329459;
				switch (num2 == num)
				{
				}
				num = (short)147652608;
				if (num != 0)
				{
				}
				num = (short)1742209025;
				if (num != 0)
				{
				}
				num = (short)1901789184;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.WorkModeProperty, value);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000815FC File Offset: 0x0007F7FC
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000816B8 File Offset: 0x0007F8B8
		public string AddButtonToolTip
		{
			get
			{
				short num = (short)842616783;
				short num2 = num;
				num = (short)1177636815;
				switch (num2 == num)
				{
				}
				num = (short)143720449;
				if (num != 0)
				{
				}
				num = (short)749469696;
				if (num != 0)
				{
				}
				num = (short)983236608;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddButtonToolTipProperty);
			}
			set
			{
				short num = (short)422685587;
				short num2 = num;
				num = (short)97823635;
				switch (num2 == num)
				{
				}
				num = (short)94371841;
				if (num != 0)
				{
				}
				num = (short)989528064;
				if (num != 0)
				{
				}
				num = (short)1844969472;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddButtonToolTipProperty, value);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00081774 File Offset: 0x0007F974
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0008182C File Offset: 0x0007FA2C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> AddEmbeddedSetCommand
		{
			get
			{
				short num = (short)935487294;
				short num2 = num;
				num = (short)1347053374;
				switch (num2 == num)
				{
				}
				num = (short)1712324609;
				if (num != 0)
				{
				}
				num = (short)1782513664;
				if (num != 0)
				{
				}
				num = (short)1993015296;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddEmbeddedSetCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)888838939;
				short num2 = num;
				num = (short)1686608667;
				switch (num2 == num)
				{
				}
				num = (short)749600769;
				if (num != 0)
				{
				}
				num = (short)683212800;
				if (num != 0)
				{
				}
				num = (short)123928576;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddEmbeddedSetCommandProperty, value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000818E0 File Offset: 0x0007FAE0
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00081998 File Offset: 0x0007FB98
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> AddMultipleSetsCommand
		{
			get
			{
				short num = (short)1706506519;
				short num2 = num;
				num = (short)397949207;
				switch (num2 == num)
				{
				}
				num = (short)1038811137;
				if (num != 0)
				{
				}
				num = (short)956432384;
				if (num != 0)
				{
				}
				num = (short)907739136;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddMultipleSetsCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)876939036;
				short num2 = num;
				num = (short)1284048668;
				switch (num2 == num)
				{
				}
				num = (short)1003356161;
				if (num != 0)
				{
				}
				num = (short)78839808;
				if (num != 0)
				{
				}
				num = (short)699858944;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddMultipleSetsCommandProperty, value);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00081A4C File Offset: 0x0007FC4C
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00081B04 File Offset: 0x0007FD04
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareImportEmbeddedSetFromXMLCommand
		{
			get
			{
				short num = (short)1981100522;
				short num2 = num;
				num = (short)873542122;
				switch (num2 == num)
				{
				}
				num = (short)1295056897;
				if (num != 0)
				{
				}
				num = (short)905969664;
				if (num != 0)
				{
				}
				num = (short)1103626240;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportEmbeddedSetFromXMLCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)2022765049;
				short num2 = num;
				num = (short)106951161;
				switch (num2 == num)
				{
				}
				num = (short)752091136;
				if (num != 0)
				{
				}
				num = (short)940703745;
				if (num != 0)
				{
				}
				num = (short)1922564096;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportEmbeddedSetFromXMLCommandProperty, value);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00081BB8 File Offset: 0x0007FDB8
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00081C70 File Offset: 0x0007FE70
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareImportEmbeddedSetFromAPKCommand
		{
			get
			{
				short num = (short)1923724648;
				short num2 = num;
				num = (short)513324392;
				switch (num2 == num)
				{
				}
				num = (short)489488384;
				if (num != 0)
				{
				}
				num = (short)999096321;
				if (num != 0)
				{
				}
				num = (short)74383360;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportEmbeddedSetFromAPKCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)688808096;
				short num2 = num;
				num = (short)88563872;
				switch (num2 == num)
				{
				}
				num = (short)11993089;
				if (num != 0)
				{
				}
				num = (short)1818296320;
				if (num != 0)
				{
				}
				num = (short)1709637632;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportEmbeddedSetFromAPKCommandProperty, value);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00081D24 File Offset: 0x0007FF24
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00081DE0 File Offset: 0x0007FFE0
		public global::System.Windows.Input.ICommand AddSetCommand
		{
			get
			{
				short num = (short)1226768385;
				if (num != 0)
				{
				}
				num = (short)454385424;
				short num2 = num;
				num = (short)921788176;
				switch (num2 == num)
				{
				}
				num = (short)1565261824;
				if (num != 0)
				{
				}
				num = (short)1490092032;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddSetCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1788999487;
				short num2 = num;
				num = (short)278853439;
				switch (num2 == num)
				{
				}
				num = (short)404094976;
				if (num != 0)
				{
				}
				num = (short)1188954113;
				if (num != 0)
				{
				}
				num = (short)976683008;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddSetCommandProperty, value);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00081E98 File Offset: 0x00080098
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00081F54 File Offset: 0x00080154
		public global::System.Windows.Input.ICommand AddSetAndEditCommand
		{
			get
			{
				short num = (short)865533377;
				short num2 = num;
				num = (short)1607073217;
				switch (num2 == num)
				{
				}
				num = (short)1486290945;
				if (num != 0)
				{
				}
				num = (short)942145536;
				if (num != 0)
				{
				}
				num = (short)249757696;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddSetAndEditCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1375912254;
				short num2 = num;
				num = (short)2062008638;
				switch (num2 == num)
				{
				}
				num = (short)1713438721;
				if (num != 0)
				{
				}
				num = (short)931004416;
				if (num != 0)
				{
				}
				num = (short)1849753600;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddSetAndEditCommandProperty, value);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00082008 File Offset: 0x00080208
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x000820C8 File Offset: 0x000802C8
		public global::System.Windows.Input.ICommand SaveSetCommand
		{
			get
			{
				short num = (short)1295253505;
				if (num != 0)
				{
				}
				num = (short)1394716668;
				short num2 = num;
				num = (short)2273276;
				switch (num2 == num)
				{
				}
				num = (short)734724096;
				if (num != 0)
				{
				}
				num = (short)585302016;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SaveSetCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)2002684439;
				short num2 = num;
				num = (short)542214679;
				switch (num2 == num)
				{
				}
				num = (short)1870266369;
				if (num != 0)
				{
				}
				num = (short)821100544;
				if (num != 0)
				{
				}
				num = (short)405143552;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SaveSetCommandProperty, value);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0008217C File Offset: 0x0008037C
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00082238 File Offset: 0x00080438
		public global::System.Windows.Input.ICommand SaveSetAsCommand
		{
			get
			{
				short num = (short)152601396;
				short num2 = num;
				num = (short)21332788;
				switch (num2 == num)
				{
				}
				num = (short)459538433;
				if (num != 0)
				{
				}
				num = (short)246743040;
				if (num != 0)
				{
				}
				num = (short)1516306432;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SaveSetAsCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)442036147;
				short num2 = num;
				num = (short)1488383923;
				switch (num2 == num)
				{
				}
				num = (short)1857683456;
				if (num != 0)
				{
				}
				num = (short)50528257;
				if (num != 0)
				{
				}
				num = (short)768016384;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SaveSetAsCommandProperty, value);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x000822F0 File Offset: 0x000804F0
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000823AC File Offset: 0x000805AC
		public global::System.Windows.Input.ICommand DiscardChangesCommand
		{
			get
			{
				short num = (short)1737190278;
				short num2 = num;
				num = (short)895511430;
				switch (num2 == num)
				{
				}
				num = (short)2084634625;
				if (num != 0)
				{
				}
				num = (short)664928256;
				if (num != 0)
				{
				}
				num = (short)13762560;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DiscardChangesCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1015643947;
				short num2 = num;
				num = (short)184319787;
				switch (num2 == num)
				{
				}
				num = (short)833880065;
				if (num != 0)
				{
				}
				num = (short)769720320;
				if (num != 0)
				{
				}
				num = (short)1552089088;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DiscardChangesCommandProperty, value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00082460 File Offset: 0x00080660
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0008251C File Offset: 0x0008071C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> DeleteEmbeddedSetsCommand
		{
			get
			{
				short num = (short)1765140499;
				short num2 = num;
				num = (short)490399763;
				switch (num2 == num)
				{
				}
				num = (short)2005860353;
				if (num != 0)
				{
				}
				num = (short)1130364928;
				if (num != 0)
				{
				}
				num = (short)304676864;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteEmbeddedSetsCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)610749639;
				short num2 = num;
				num = (short)448679111;
				switch (num2 == num)
				{
				}
				num = (short)987889665;
				if (num != 0)
				{
				}
				num = (short)1195769856;
				if (num != 0)
				{
				}
				num = (short)1169686528;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteEmbeddedSetsCommandProperty, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000825D0 File Offset: 0x000807D0
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0008268C File Offset: 0x0008088C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> DeleteEmbeddedSetsForListBoxCommand
		{
			get
			{
				short num = (short)519731978;
				short num2 = num;
				num = (short)1179613962;
				switch (num2 == num)
				{
				}
				num = (short)733478913;
				if (num != 0)
				{
				}
				num = (short)542769152;
				if (num != 0)
				{
				}
				num = (short)401145856;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteEmbeddedSetsForListBoxCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>;
			}
			set
			{
				short num = (short)1929213455;
				short num2 = num;
				num = (short)1524266511;
				switch (num2 == num)
				{
				}
				num = (short)404553729;
				if (num != 0)
				{
				}
				num = (short)1107755008;
				if (num != 0)
				{
				}
				num = (short)362610688;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteEmbeddedSetsForListBoxCommandProperty, value);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00082740 File Offset: 0x00080940
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x000827FC File Offset: 0x000809FC
		public global::System.Windows.Input.ICommand DeleteSetsCommand
		{
			get
			{
				short num = (short)2135562967;
				short num2 = num;
				num = (short)966138583;
				switch (num2 == num)
				{
				}
				num = (short)1227751424;
				if (num != 0)
				{
				}
				num = (short)1215102977;
				if (num != 0)
				{
				}
				num = (short)591790080;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteSetsCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)630635621;
				short num2 = num;
				num = (short)688110693;
				switch (num2 == num)
				{
				}
				num = (short)1180172288;
				if (num != 0)
				{
				}
				num = (short)1401487361;
				if (num != 0)
				{
				}
				num = (short)333905920;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteSetsCommandProperty, value);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000828B0 File Offset: 0x00080AB0
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0008296C File Offset: 0x00080B6C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> EditEmbeddedSetCommand
		{
			get
			{
				short num = (short)472354879;
				short num2 = num;
				num = (short)1828884543;
				switch (num2 == num)
				{
				}
				num = (short)1627717633;
				if (num != 0)
				{
				}
				num = (short)27131904;
				if (num != 0)
				{
				}
				num = (short)412549120;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditEmbeddedSetCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)1278935041;
				if (num != 0)
				{
				}
				num = (short)837986720;
				short num2 = num;
				num = (short)173648288;
				switch (num2 == num)
				{
				}
				num = (short)860487680;
				if (num != 0)
				{
				}
				num = (short)1480392704;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditEmbeddedSetCommandProperty, value);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00082A20 File Offset: 0x00080C20
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00082AD8 File Offset: 0x00080CD8
		public global::System.Windows.Input.ICommand GridSearchCommand
		{
			get
			{
				short num = (short)359280630;
				short num2 = num;
				num = (short)2014195702;
				switch (num2 == num)
				{
				}
				num = (short)716046337;
				if (num != 0)
				{
				}
				num = (short)466944000;
				if (num != 0)
				{
				}
				num = (short)714604544;
				short num3 = num;
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.GridSearchCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1701238054;
				short num2 = num;
				num = (short)1789777190;
				switch (num2 == num)
				{
				}
				num = (short)1027997696;
				if (num != 0)
				{
				}
				num = (short)54198273;
				if (num != 0)
				{
				}
				num = (short)543031296;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.GridSearchCommandProperty, value);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00082B8C File Offset: 0x00080D8C
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00082C44 File Offset: 0x00080E44
		public global::System.Windows.Input.ICommand EditSetCommand
		{
			get
			{
				short num = (short)651296768;
				short num2 = num;
				num = (short)647516550;
				short num3 = num;
				num = (short)1971999110;
				switch (num3 == num)
				{
				}
				num = (short)1714094081;
				if (num != 0)
				{
				}
				num = (short)1687486464;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditSetCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)4128768;
				short num2 = num;
				num = (short)1657607351;
				short num3 = num;
				num = (short)648156343;
				switch (num3 == num)
				{
				}
				num = (short)1479999488;
				if (num != 0)
				{
				}
				num = (short)1007681537;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditSetCommandProperty, value);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00082CF4 File Offset: 0x00080EF4
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00082DB0 File Offset: 0x00080FB0
		public global::System.Windows.Input.ICommand EditSetColumnCommand
		{
			get
			{
				short num = (short)2024931328;
				short num2 = num;
				num = (short)1994784769;
				if (num != 0)
				{
				}
				num = (short)84160859;
				short num3 = num;
				num = (short)1333014875;
				switch (num3 == num)
				{
				}
				num = (short)327352320;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditSetColumnCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)19595264;
				short num2 = num;
				num = (short)1942044323;
				short num3 = num;
				num = (short)23412387;
				switch (num3 == num)
				{
				}
				num = (short)223674369;
				if (num != 0)
				{
				}
				num = (short)373293056;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditSetColumnCommandProperty, value);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00082E64 File Offset: 0x00081064
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00082F1C File Offset: 0x0008111C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>> FillDownCommand
		{
			get
			{
				short num = (short)1986199552;
				short num2 = num;
				num = (short)788181858;
				short num3 = num;
				num = (short)855880546;
				switch (num3 == num)
				{
				}
				num = (short)640942081;
				if (num != 0)
				{
				}
				num = (short)864813056;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FillDownCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>>;
			}
			set
			{
				short num = (short)1949040640;
				short num2 = num;
				num = (short)1316146800;
				short num3 = num;
				num = (short)51564144;
				switch (num3 == num)
				{
				}
				num = (short)243073025;
				if (num != 0)
				{
				}
				num = (short)21692416;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FillDownCommandProperty, value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00082FD4 File Offset: 0x000811D4
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00083090 File Offset: 0x00081290
		public global::System.Windows.Input.ICommand HideFieldsCommand
		{
			get
			{
				short num = (short)607256576;
				short num2 = num;
				num = (short)1728493847;
				short num3 = num;
				num = (short)1502394647;
				switch (num3 == num)
				{
				}
				num = (short)1449852928;
				if (num != 0)
				{
				}
				num = (short)869990401;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.HideFieldsCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)843644928;
				short num2 = num;
				num = (short)647854672;
				short num3 = num;
				num = (short)1939372624;
				switch (num3 == num)
				{
				}
				num = (short)1297743873;
				if (num != 0)
				{
				}
				num = (short)994508800;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.HideFieldsCommandProperty, value);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00083144 File Offset: 0x00081344
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00083200 File Offset: 0x00081400
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand MoveSetDownCommand
		{
			get
			{
				short num = (short)1496645632;
				short num2 = num;
				num = (short)1793162472;
				short num3 = num;
				num = (short)739409128;
				switch (num3 == num)
				{
				}
				num = (short)779812865;
				if (num != 0)
				{
				}
				num = (short)1000079360;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveSetDownCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)359858176;
				short num2 = num;
				num = (short)755450162;
				short num3 = num;
				num = (short)796410162;
				switch (num3 == num)
				{
				}
				num = (short)1683750913;
				if (num != 0)
				{
				}
				num = (short)305004544;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveSetDownCommandProperty, value);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000832B4 File Offset: 0x000814B4
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x0008336C File Offset: 0x0008156C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> MoveEmbeddedSetDownCommand
		{
			get
			{
				short num = (short)270729216;
				short num2 = num;
				num = (short)1096810497;
				if (num != 0)
				{
				}
				num = (short)2055478565;
				short num3 = num;
				num = (short)1081482533;
				switch (num3 == num)
				{
				}
				num = (short)1085210624;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveEmbeddedSetDownCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)1134297088;
				short num2 = num;
				num = (short)1577748102;
				short num3 = num;
				num = (short)85296774;
				switch (num3 == num)
				{
				}
				num = (short)632291328;
				if (num != 0)
				{
				}
				num = (short)969342977;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveEmbeddedSetDownCommandProperty, value);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00083424 File Offset: 0x00081624
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000834DC File Offset: 0x000816DC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand MoveSetUpCommand
		{
			get
			{
				short num = (short)372899840;
				short num2 = num;
				num = (short)1908409446;
				short num3 = num;
				num = (short)756745318;
				switch (num3 == num)
				{
				}
				num = (short)172097537;
				if (num != 0)
				{
				}
				num = (short)895156224;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveSetUpCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)1791426560;
				short num2 = num;
				num = (short)1815153616;
				short num3 = num;
				num = (short)729287632;
				switch (num3 == num)
				{
				}
				num = (short)1341980672;
				if (num != 0)
				{
				}
				num = (short)922025985;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveSetUpCommandProperty, value);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00083594 File Offset: 0x00081794
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x0008364C File Offset: 0x0008184C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> MoveEmbeddedSetUpCommand
		{
			get
			{
				short num = (short)570490880;
				short num2 = num;
				num = (short)1051621200;
				short num3 = num;
				num = (short)443184976;
				switch (num3 == num)
				{
				}
				num = (short)1480785921;
				if (num != 0)
				{
				}
				num = (short)416546816;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveEmbeddedSetUpCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)1478164480;
				short num2 = num;
				num = (short)1781621439;
				short num3 = num;
				num = (short)2090951359;
				switch (num3 == num)
				{
				}
				num = (short)915603456;
				if (num != 0)
				{
				}
				num = (short)709951489;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveEmbeddedSetUpCommandProperty, value);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00083700 File Offset: 0x00081900
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x000837BC File Offset: 0x000819BC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Controls.SetsImportExport.SetExportArgs> GridToFileEmbeddedCommand
		{
			get
			{
				short num = (short)1463091200;
				short num2 = num;
				num = (short)1380405674;
				short num3 = num;
				num = (short)1321161130;
				switch (num3 == num)
				{
				}
				num = (short)904658944;
				if (num != 0)
				{
				}
				num = (short)1834352641;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.GridToFileEmbeddedCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Controls.SetsImportExport.SetExportArgs>;
			}
			set
			{
				short num = (short)179699712;
				short num2 = num;
				num = (short)2094951657;
				short num3 = num;
				num = (short)2084138217;
				switch (num3 == num)
				{
				}
				num = (short)437649409;
				if (num != 0)
				{
				}
				num = (short)1772814336;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.GridToFileEmbeddedCommandProperty, value);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00083870 File Offset: 0x00081A70
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00083928 File Offset: 0x00081B28
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Controls.SetsImportExport.SetImportArgs> FileToGridEmbeddedCommand
		{
			get
			{
				short num = (short)402849792;
				short num2 = num;
				num = (short)900425151;
				short num3 = num;
				num = (short)1254516159;
				switch (num3 == num)
				{
				}
				num = (short)1574305793;
				if (num != 0)
				{
				}
				num = (short)213909504;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FileToGridEmbeddedCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Controls.SetsImportExport.SetImportArgs>;
			}
			set
			{
				short num = (short)1860435968;
				short num2 = num;
				num = (short)839794587;
				short num3 = num;
				num = (short)987119515;
				switch (num3 == num)
				{
				}
				num = (short)245825537;
				if (num != 0)
				{
				}
				num = (short)642187264;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FileToGridEmbeddedCommandProperty, value);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000839DC File Offset: 0x00081BDC
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00083A98 File Offset: 0x00081C98
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareCopyAndAssginCommand
		{
			get
			{
				short num = (short)1071251456;
				short num2 = num;
				num = (short)739488989;
				short num3 = num;
				num = (short)2068100317;
				switch (num3 == num)
				{
				}
				num = (short)447414273;
				if (num != 0)
				{
				}
				num = (short)47448064;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareCopyAndAssginCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)229834752;
				short num2 = num;
				num = (short)1608995520;
				short num3 = num;
				num = (short)1139954368;
				switch (num3 == num)
				{
				}
				num = (short)1226047489;
				if (num != 0)
				{
				}
				num = (short)1050935296;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareCopyAndAssginCommandProperty, value);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00083B4C File Offset: 0x00081D4C
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00083C04 File Offset: 0x00081E04
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PrepareAddSetCopiesCommand
		{
			get
			{
				short num = (short)525074432;
				short num2 = num;
				num = (short)335629392;
				short num3 = num;
				num = (short)28789840;
				switch (num3 == num)
				{
				}
				num = (short)1948319745;
				if (num != 0)
				{
				}
				num = (short)722272256;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareAddSetCopiesCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)1281228800;
				short num2 = num;
				num = (short)1087355668;
				short num3 = num;
				num = (short)469941012;
				switch (num3 == num)
				{
				}
				num = (short)398917633;
				if (num != 0)
				{
				}
				num = (short)554893312;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareAddSetCopiesCommandProperty, value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00083CBC File Offset: 0x00081EBC
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00083D78 File Offset: 0x00081F78
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareImportSetCommand
		{
			get
			{
				short num = (short)754384896;
				short num2 = num;
				num = (short)1019909216;
				short num3 = num;
				num = (short)1033147488;
				switch (num3 == num)
				{
				}
				num = (short)516947969;
				if (num != 0)
				{
				}
				num = (short)247201792;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportSetCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)1938685952;
				short num2 = num;
				num = (short)585040648;
				short num3 = num;
				num = (short)1642398472;
				switch (num3 == num)
				{
				}
				num = (short)1357512704;
				if (num != 0)
				{
				}
				num = (short)1530462209;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportSetCommandProperty, value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00083E30 File Offset: 0x00082030
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00083EEC File Offset: 0x000820EC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareExportSetCommand
		{
			get
			{
				short num = (short)1867579392;
				short num2 = num;
				num = (short)1079586952;
				short num3 = num;
				num = (short)985215112;
				switch (num3 == num)
				{
				}
				num = (short)1818034177;
				if (num != 0)
				{
				}
				num = (short)498139136;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareExportSetCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)1257504768;
				short num2 = num;
				num = (short)1989669166;
				short num3 = num;
				num = (short)1566306606;
				switch (num3 == num)
				{
				}
				num = (short)1838415872;
				if (num != 0)
				{
				}
				num = (short)337313793;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareExportSetCommandProperty, value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00083FA0 File Offset: 0x000821A0
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x00084058 File Offset: 0x00082258
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareCopyEmbeddedSetCommand
		{
			get
			{
				short num = (short)593166336;
				short num2 = num;
				num = (short)1495760963;
				short num3 = num;
				num = (short)289374275;
				switch (num3 == num)
				{
				}
				num = (short)1020461057;
				if (num != 0)
				{
				}
				num = (short)2045902848;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareCopyEmbeddedSetCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)889389056;
				short num2 = num;
				num = (short)2137291954;
				short num3 = num;
				num = (short)1753906354;
				switch (num3 == num)
				{
				}
				num = (short)311492608;
				if (num != 0)
				{
				}
				num = (short)1016266753;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareCopyEmbeddedSetCommandProperty, value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00084110 File Offset: 0x00082310
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x000841C8 File Offset: 0x000823C8
		public global::System.Windows.Input.ICommand PrepareShowRelatedSetsCommand
		{
			get
			{
				short num = (short)345374720;
				short num2 = num;
				num = (short)1830975196;
				short num3 = num;
				num = (short)997422812;
				switch (num3 == num)
				{
				}
				num = (short)1641676801;
				if (num != 0)
				{
				}
				num = (short)658046976;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowRelatedSetsCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1739849728;
				short num2 = num;
				num = (short)475498569;
				short num3 = num;
				num = (short)2079164489;
				switch (num3 == num)
				{
				}
				num = (short)1329201153;
				if (num != 0)
				{
				}
				num = (short)121110528;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowRelatedSetsCommandProperty, value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00084280 File Offset: 0x00082480
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0008433C File Offset: 0x0008253C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareShowEmbeddedSetRelatedConfigurationsCommand
		{
			get
			{
				short num = (short)869007360;
				short num2 = num;
				num = (short)1709097475;
				short num3 = num;
				num = (short)1835581955;
				switch (num3 == num)
				{
				}
				num = (short)494796801;
				if (num != 0)
				{
				}
				num = (short)2135359488;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowEmbeddedSetRelatedConfigurationsCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)1803550720;
				short num2 = num;
				num = (short)130678785;
				if (num != 0)
				{
				}
				num = (short)144957505;
				short num3 = num;
				num = (short)1429594177;
				switch (num3 == num)
				{
				}
				num = (short)42926080;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowEmbeddedSetRelatedConfigurationsCommandProperty, value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x000843F0 File Offset: 0x000825F0
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000844A8 File Offset: 0x000826A8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> PrepareShowEmbeddedSetRelatedSetsCommand
		{
			get
			{
				short num = (short)1998782464;
				short num2 = num;
				num = (short)1147604761;
				short num3 = num;
				num = (short)1742540569;
				switch (num3 == num)
				{
				}
				num = (short)1966997505;
				if (num != 0)
				{
				}
				num = (short)1560674304;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowEmbeddedSetRelatedSetsCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)111017984;
				short num2 = num;
				num = (short)51249153;
				if (num != 0)
				{
				}
				num = (short)1613187673;
				short num3 = num;
				num = (short)1845381721;
				switch (num3 == num)
				{
				}
				num = (short)738918400;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowEmbeddedSetRelatedSetsCommandProperty, value);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0008455C File Offset: 0x0008275C
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00084618 File Offset: 0x00082818
		public global::System.Windows.Input.ICommand PrepareShowRelatedConfigurationsCommand
		{
			get
			{
				short num = (short)1331429376;
				short num2 = num;
				num = (short)82167267;
				short num3 = num;
				num = (short)426493411;
				switch (num3 == num)
				{
				}
				num = (short)1423704064;
				if (num != 0)
				{
				}
				num = (short)1891631105;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowRelatedConfigurationsCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)842530816;
				short num2 = num;
				num = (short)1535115265;
				if (num != 0)
				{
				}
				num = (short)846905117;
				short num3 = num;
				num = (short)1640021789;
				switch (num3 == num)
				{
				}
				num = (short)1471479808;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowRelatedConfigurationsCommandProperty, value);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x000846D0 File Offset: 0x000828D0
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00084788 File Offset: 0x00082988
		public global::System.Windows.Input.ICommand ShowFieldsCommand
		{
			get
			{
				short num = (short)155779072;
				short num2 = num;
				num = (short)1727139291;
				short num3 = num;
				num = (short)1774718427;
				switch (num3 == num)
				{
				}
				num = (short)1350434817;
				if (num != 0)
				{
				}
				num = (short)309329920;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.ShowFieldsCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1892155392;
				short num2 = num;
				num = (short)726131083;
				short num3 = num;
				num = (short)89842059;
				switch (num3 == num)
				{
				}
				num = (short)1497038848;
				if (num != 0)
				{
				}
				num = (short)1167392769;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.ShowFieldsCommandProperty, value);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00084840 File Offset: 0x00082A40
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x000848F8 File Offset: 0x00082AF8
		public global::System.Windows.Input.ICommand ShowFieldHelpCommand
		{
			get
			{
				short num = (short)1431896064;
				short num2 = num;
				num = (short)961859840;
				short num3 = num;
				num = (short)1006620928;
				switch (num3 == num)
				{
				}
				num = (short)1189216256;
				if (num != 0)
				{
				}
				num = (short)2129068033;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.ShowFieldHelpCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1132593152;
				short num2 = num;
				num = (short)1098317825;
				if (num != 0)
				{
				}
				num = (short)327026915;
				short num3 = num;
				num = (short)938674403;
				switch (num3 == num)
				{
				}
				num = (short)1139277824;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.ShowFieldHelpCommandProperty, value);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000849AC File Offset: 0x00082BAC
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00084A68 File Offset: 0x00082C68
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory> RecalculateEmbeddedSetCommand
		{
			get
			{
				short num = (short)607846400;
				short num2 = num;
				num = (short)437220042;
				short num3 = num;
				num = (short)580350666;
				switch (num3 == num)
				{
				}
				num = (short)1950875648;
				if (num != 0)
				{
				}
				num = (short)866844673;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.RecalculateEmbeddedSetCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>;
			}
			set
			{
				short num = (short)550895616;
				short num2 = num;
				num = (short)1048848979;
				short num3 = num;
				num = (short)1648241235;
				switch (num3 == num)
				{
				}
				num = (short)908001280;
				if (num != 0)
				{
				}
				num = (short)202964993;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.RecalculateEmbeddedSetCommandProperty, value);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00084B20 File Offset: 0x00082D20
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00084BCC File Offset: 0x00082DCC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ShowFieldIdCommmand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)303038464;
				short num2 = num;
				num = (short)697655814;
				short num3 = num;
				num = (short)1455448582;
				switch (num3 == num)
				{
				}
				num = (short)152698881;
				if (num != 0)
				{
				}
				num = (short)482541568;
				if (num != 0)
				{
				}
				return this.<ShowFieldIdCommmand>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)583204864;
				short num2 = num;
				num = (short)1932026252;
				short num3 = num;
				num = (short)1994940812;
				switch (num3 == num)
				{
				}
				num = (short)1797455873;
				if (num != 0)
				{
				}
				num = (short)889913344;
				if (num != 0)
				{
				}
				this.<ShowFieldIdCommmand>k__BackingField = value;
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000846 RID: 2118 RVA: 0x00084C7C File Offset: 0x00082E7C
		// (remove) Token: 0x06000847 RID: 2119 RVA: 0x00084D30 File Offset: 0x00082F30
		public event global::System.Windows.RoutedEventHandler EditorClosing
		{
			add
			{
				short num = (short)317194240;
				short num2 = num;
				num = (short)35473504;
				short num3 = num;
				num = (short)1109411936;
				switch (num3 == num)
				{
				}
				num = (short)524746753;
				if (num != 0)
				{
				}
				num = (short)1893859328;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditorClosingEvent, value);
			}
			remove
			{
				short num = (short)977207296;
				short num2 = num;
				num = (short)938831674;
				short num3 = num;
				num = (short)1164209978;
				switch (num3 == num)
				{
				}
				num = (short)1972830209;
				if (num != 0)
				{
				}
				num = (short)732626944;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditorClosingEvent, value);
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000848 RID: 2120 RVA: 0x00084DE8 File Offset: 0x00082FE8
		// (remove) Token: 0x06000849 RID: 2121 RVA: 0x00084E9C File Offset: 0x0008309C
		public event global::System.Windows.RoutedEventHandler SelectSetRequested
		{
			add
			{
				short num = (short)625737728;
				short num2 = num;
				num = (short)1518010369;
				if (num != 0)
				{
				}
				num = (short)1601961663;
				short num3 = num;
				num = (short)472579775;
				switch (num3 == num)
				{
				}
				num = (short)794296320;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectSetRequestedEvent, value);
			}
			remove
			{
				short num = (short)1754464257;
				if (num != 0)
				{
				}
				num = (short)1119336472;
				short num2 = num;
				num = (short)347519000;
				switch (num2 == num)
				{
				}
				num = (short)52887552;
				if (num != 0)
				{
				}
				num = (short)11796480;
				short num3 = num;
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectSetRequestedEvent, value);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00084F50 File Offset: 0x00083150
		private void dgrSets_PreviewMouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1633746946;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1249640449;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (this.dgrSets.ActiveCell.IsInEditMode)
						{
							num = (short)1604255751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_DC;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 3:
						num = (short)1031471104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.dgrSets.ActiveCell != null)
						{
							num = (short)666697731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						num = (short)366215168;
						short num3 = num;
						num = (short)1385824264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						this.dgrSets.ActiveCell.EndEditMode();
						this.dgrSets.ActiveCell.IsSelected = true;
						num = (short)1718026246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)786852538;
						short num4 = num;
						num = (short)1649109690;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1126432768;
							if (num != 0)
							{
							}
							if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
							{
								num = (short)497549313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					}
					IL_70:
					if (global::System.Windows.Input.Keyboard.Modifiers != global::System.Windows.Input.ModifierKeys.Shift)
					{
						num = (short)852688901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DC:
					num = (short)1857945604;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0008516C File Offset: 0x0008336C
		private void SelectedRecords_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)2136482646;
			short num2 = num;
			num = (short)283255638;
			switch (num2 == num)
			{
			}
			num = (short)1719074817;
			if (num != 0)
			{
			}
			num = (short)1941897216;
			if (num != 0)
			{
			}
			num = (short)1835270144;
			short num3 = num;
			this.n();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00085218 File Offset: 0x00083418
		private void grdEditor_PreviewMouseWheel(object A_0, global::System.Windows.Input.MouseWheelEventArgs A_1)
		{
			short num = (short)1743192065;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)511656928;
					short num3 = num;
					num = (short)2010137568;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
						num = (short)1136328705;
						if (num != 0)
						{
						}
						num = (short)432078848;
						if (num != 0)
						{
						}
						goto IL_59;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_57;
				case 4:
				{
					num = (short)320274432;
					short num4 = num;
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)1824980992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_39:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
				{
					num = (short)1176436739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_59;
				IL_57:
				num = (short)1481703428;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_59:
				global::System.Windows.Controls.Grid a_ = A_0 as global::System.Windows.Controls.Grid;
				global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(a_, (double)A_1.Delta);
				num = (short)857210882;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00085388 File Offset: 0x00083588
		private void gridSets_PreviewMouseWheel_Grid(object A_0, global::System.Windows.Input.MouseWheelEventArgs A_1)
		{
			short num = (short)558563329;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1919479898;
					short num3 = num;
					num = (short)73199706;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
						num = (short)371392512;
						if (num != 0)
						{
						}
						num = (short)238092289;
						if (num != 0)
						{
						}
						goto IL_59;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_57;
				case 4:
				{
					num = (short)1725890560;
					short num4 = num;
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num = (short)208142336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_39:
				if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
				{
					num = (short)389677059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_59;
				IL_57:
				num = (short)512032772;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_59:
				global::System.Windows.Controls.Grid a_ = A_0 as global::System.Windows.Controls.Grid;
				global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(a_, (double)A_1.Delta);
				num = (short)1900675074;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000854F4 File Offset: 0x000836F4
		private bool p()
		{
			short num = (short)826744904;
			short num2 = num;
			num = (short)1311973448;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1524432896;
				short num3 = num;
				num = (short)742588417;
				if (num != 0)
				{
				}
				num = (short)890503168;
				if (num != 0)
				{
				}
				if (this.EditSetCommand == null)
				{
					return false;
				}
				break;
			}
			}
			return this.EditSetCommand.CanExecute(null);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000855B8 File Offset: 0x000837B8
		private void o()
		{
			short num = (short)121765573;
			short num2 = num;
			num = (short)47316677;
			switch (num2 == num)
			{
			}
			num = (short)958988288;
			if (num != 0)
			{
			}
			num = (short)477691905;
			if (num != 0)
			{
			}
			num = (short)1769340928;
			short num3 = num;
			this.EditSetCommand.Execute(null);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0008566C File Offset: 0x0008386C
		private void OnMouseDoubleClick(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_18B;
				case 1:
					num2 = (short)1575354369;
					if (num2 != 0)
					{
					}
					num2 = (short)1967390725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.SetCategory != null)
					{
						num2 = (short)1873739777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					if (set == null)
					{
						num2 = (short)2109014019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18E;
				case 5:
				{
					if (!this.SetCategory.TelePortMode)
					{
						num2 = (short)2122317824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)39780352;
					short num3 = num2;
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
					set = (dataRecordPresenter.DataRecord.DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
					num2 = (short)1538326532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			return;
			IL_18B:
			return;
			IL_18E:
			this.SetCategory.ActiveSet = set;
			return;
			IL_28:
			num2 = (short)466012263;
			short num4 = num2;
			num2 = (short)284018791;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)1074790400;
				if (num2 != 0)
				{
				}
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = (global::Infragistics.Windows.DataPresenter.DataRecordPresenter)A_0;
				num2 = (short)1195442178;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00085814 File Offset: 0x00083A14
		private void RMLinkButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1794637824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton rmlinkButton;
				global::System.Windows.FrameworkElement frameworkElement;
				global::System.Windows.Controls.ItemsControl a_;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_1B9;
					case 1:
					{
						if (rmlinkButton.RMLinkFieldEditor == null)
						{
							num = (short)547946499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor rmlinkFieldEditor = rmlinkButton.RMLinkFieldEditor;
						global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField = (global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)rmlinkFieldEditor.DataContext;
						this.SetCategory = collectionField.SetCategory;
						this.HideFieldsCommand.Execute(null);
						num = (short)1493499906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1629189703;
						short num3 = num;
						num = (short)36009543;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_172;
						default:
							goto IL_103;
						}
						break;
					}
					case 3:
						goto IL_172;
					case 4:
						if (frameworkElement != null)
						{
							num = (short)1343619072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_42;
					IL_172:
					frameworkElement = (rmlinkButton.Tag as global::System.Windows.FrameworkElement);
					a_ = this.q();
					num = (short)852754436;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_103:
				num = (short)637468672;
				if (num != 0)
				{
				}
				num = (short)248905729;
				if (num != 0)
				{
				}
				return;
				IL_1B9:
				num = (short)1694367744;
				short num4 = num;
				this.a(frameworkElement, a_);
				return;
				IL_42:
				rmlinkButton = (global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton)A_1.OriginalSource;
				num = (short)881786881;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000859DC File Offset: 0x00083BDC
		internal void a(global::System.Windows.FrameworkElement A_0, global::System.Windows.FrameworkElement A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c__DisplayClass199_0 CS$<>8__locals1;
			for (;;)
			{
				IL_0A:
				global::System.Windows.Threading.DispatcherPriority dispatcherPriority;
				switch (num)
				{
				case 0:
				{
					num2 = (short)711567938;
					short num3 = num2;
					num2 = (short)107063874;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_172;
					default:
						num2 = (short)1153630208;
						if (num2 != 0)
						{
						}
						dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.ApplicationIdle;
						goto IL_1A0;
					}
					break;
				}
				case 1:
					if (CS$<>8__locals1.c != null)
					{
						num2 = (short)988938243;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
				{
					num2 = (short)1427374080;
					short num4 = num2;
					num2 = (short)431357956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_172;
				case 5:
					dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Normal;
					goto IL_1A0;
				case 6:
					num2 = (short)397934592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_172:
				if (!CS$<>8__locals1.a.IsLoaded)
				{
					num2 = (short)580124678;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1657012229;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A0:
				global::System.Windows.Threading.DispatcherPriority priority = dispatcherPriority;
				CS$<>8__locals1.c.Dispatcher.BeginInvoke(new global::System.Action(CS$<>8__locals1.d), priority, global::System.Array.Empty<object>());
				num2 = (short)420151298;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c__DisplayClass199_0();
			CS$<>8__locals1.a = A_0;
			CS$<>8__locals1.b = A_1;
			CS$<>8__locals1.c = this.l();
			num2 = (short)387186689;
			if (num2 != 0)
			{
			}
			num2 = (short)262602753;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00085BC8 File Offset: 0x00083DC8
		private void RMLinkFieldEditor_RelocateRequested(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1894101082;
			short num2 = num;
			num = (short)1287434330;
			switch (num2 == num)
			{
			}
			num = (short)1122172929;
			if (num != 0)
			{
			}
			num = (short)1761804288;
			if (num != 0)
			{
			}
			num = (short)1972633600;
			short num3 = num;
			this.HideFieldsCommand.Execute(null);
			this.SetCategory = (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)A_1.OriginalSource;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00085C8C File Offset: 0x00083E8C
		private void RMRelocatableFieldEditor_RelocateRequested(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1437834728;
			short num2 = num;
			num = (short)247438824;
			switch (num2 == num)
			{
			}
			num = (short)454426625;
			if (num != 0)
			{
			}
			num = (short)781713408;
			if (num != 0)
			{
			}
			num = (short)914817024;
			short num3 = num;
			global::System.Windows.Input.ICommand showFieldHelpCommand = this.ShowFieldHelpCommand;
			if (showFieldHelpCommand == null)
			{
				return;
			}
			showFieldHelpCommand.Execute(A_1.OriginalSource);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00085D50 File Offset: 0x00083F50
		private void RMLabelFieldEditor_RelocateHelpWindowRequested(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1735509992;
			short num2 = num;
			num = (short)929941480;
			switch (num2 == num)
			{
			}
			num = (short)40763392;
			if (num != 0)
			{
			}
			num = (short)1187119105;
			if (num != 0)
			{
			}
			num = (short)1616838656;
			short num3 = num;
			global::Microsoft.Practices.Prism.Events.IEventAggregator instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
			instance.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowHelpWindowRequestedEvent>().Publish(A_1.OriginalSource as string);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00085E18 File Offset: 0x00084018
		private void RMSetEditor_RelocateRequested(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)954006029;
			short num2 = num;
			num = (short)1724905997;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)51052544;
				short num3 = num;
				num = (short)833159168;
				if (num != 0)
				{
				}
				if (this.ShowFieldHelpCommand != null)
				{
					this.ShowFieldHelpCommand.Execute(A_1.OriginalSource);
					return;
				}
				break;
			}
			}
			num = (short)191561729;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00085EDC File Offset: 0x000840DC
		private void RMListFieldEditor_SelectSetRequested(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1677918262;
			short num2 = num;
			num = (short)602734646;
			switch (num2 == num)
			{
			}
			num = (short)108724225;
			if (num != 0)
			{
			}
			num = (short)360054784;
			if (num != 0)
			{
			}
			num = (short)922746880;
			short num3 = num;
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectSetRequestedEvent, A_1.OriginalSource));
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00085F9C File Offset: 0x0008419C
		private void RMComboBox_SelectSetRequested(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)390646358;
			short num2 = num;
			num = (short)947374678;
			switch (num2 == num)
			{
			}
			num = (short)1505427456;
			if (num != 0)
			{
			}
			num = (short)932708353;
			if (num != 0)
			{
			}
			num = (short)1026883584;
			short num3 = num;
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectSetRequestedEvent, A_1.OriginalSource));
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0008605C File Offset: 0x0008425C
		private void ctmSets_Opened(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)508531931;
			short num2 = num;
			num = (short)794924251;
			switch (num2 == num)
			{
			}
			num = (short)353107969;
			if (num != 0)
			{
			}
			num = (short)1794048000;
			if (num != 0)
			{
			}
			num = (short)340983808;
			short num3 = num;
			this.ctmSets.DataContext = this;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00086110 File Offset: 0x00084310
		private void dgrSets_InitializeRecord(object A_0, global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs A_1)
		{
			short num = (short)1606534275;
			short num2 = num;
			num = (short)1745208451;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A2:
				num = (short)703135745;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)688390145;
				if (num != 0)
				{
				}
				num = (short)1002569728;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					A_1.Record.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1620443138;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!set.IsVisible)
					{
						num = (short)473235456;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_F7;
				}
				goto IL_8C;
			}
			IL_F7:
			num = (short)379322368;
			short num4 = num;
			return;
			IL_8C:
			set = (((global::Infragistics.Windows.DataPresenter.DataRecord)A_1.Record).DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
			goto IL_A2;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00086240 File Offset: 0x00084440
		private void dgrSets_EditModeEnded(object A_0, global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs A_1)
		{
			short num = (short)764149760;
			switch (num)
			{
			default:
			{
				num = (short)1625882626;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object dataItem;
					string name;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_ED;
					case 2:
					{
						num = (short)1630348324;
						short num3 = num;
						num = (short)639312932;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_157;
						default:
							num = (short)82640897;
							if (num != 0)
							{
							}
							num = (short)1911750656;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CB;
							}
							continue;
						}
						break;
					}
					case 3:
					{
						bool flag = false;
						object[] parameter = new object[]
						{
							dataItem,
							name,
							flag
						};
						num = (short)612433925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (dataItem != null)
						{
							goto IL_157;
						}
						return;
					case 5:
					{
						global::System.Windows.Input.ICommand editSetColumnCommand = this.EditSetColumnCommand;
						if (editSetColumnCommand == null)
						{
							return;
						}
						object[] parameter;
						editSetColumnCommand.Execute(parameter);
						num = (short)477626368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_CB:
					if (!A_1.Cell.IsDataChanged)
					{
						num = (short)1243348993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					name = A_1.Cell.Field.Name;
					dataItem = A_1.Cell.Record.DataItem;
					num = (short)2103508996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					num = (short)1681850371;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_ED:
				num = (short)2136276992;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00086420 File Offset: 0x00084620
		private void n()
		{
			short num = (short)1354235062;
			short num2 = num;
			num = (short)1556413622;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> dataItemsFromSelectedCellsOrRecords;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)22413312;
				short num3 = num;
				num = (short)241172481;
				if (num != 0)
				{
				}
				num = (short)1623588864;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> observableCollectionFast = this.SelectedSets as global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>;
				dataItemsFromSelectedCellsOrRecords = this.dgrSets.SelectedItems.GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>();
				if (observableCollectionFast != null)
				{
					observableCollectionFast.Reset(dataItemsFromSelectedCellsOrRecords);
					return;
				}
				break;
			}
			}
			this.SelectedSets.Clear();
			this.SelectedSets.AddRange(dataItemsFromSelectedCellsOrRecords);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0008650C File Offset: 0x0008470C
		private void lkbHideDetails_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorClosingRoutedEventArgs setEditorClosingRoutedEventArgs;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1961635063;
					short num3 = num2;
					num2 = (short)670117111;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_156;
					case 1:
						break;
					default:
					{
						num2 = (short)762707968;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)149618688;
					if (num2 != 0)
					{
					}
					if (this.SetCategory.IsExpandEmbeddedSet)
					{
						num2 = (short)206831618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15C;
				}
				case 2:
					goto IL_156;
				case 3:
					if (setEditorClosingRoutedEventArgs.IsCancelled)
					{
						num2 = (short)2038759424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1962541057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return;
			IL_156:
			this.SetCategory = this.SetCategory.ParentSetCategory;
			return;
			IL_15C:
			this.IsShowingFields = false;
			return;
			IL_20:
			setEditorClosingRoutedEventArgs = new global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorClosingRoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditorClosingEvent, A_1.OriginalSource);
			base.RaiseEvent(setEditorClosingRoutedEventArgs);
			num2 = (short)256770049;
			if (num2 != 0)
			{
			}
			num2 = (short)1397293059;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0008667C File Offset: 0x0008487C
		private void lkbShowDetails_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1466932443;
			short num2 = num;
			num = (short)331390171;
			switch (num2 == num)
			{
			}
			num = (short)273940480;
			short num3 = num;
			num = (short)1578631168;
			if (num != 0)
			{
			}
			num = (short)620167169;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::System.Windows.FrameworkElement)A_0).TemplatedParent;
			cellValuePresenter.IsSelected = true;
			this.IsShowingFields = true;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00086744 File Offset: 0x00084944
		private void Records_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1674809996;
			short num2 = num;
			num = (short)1618973324;
			switch (num2 == num)
			{
			}
			num = 0;
			short num3 = num;
			num = (short)1214971904;
			if (num != 0)
			{
			}
			num = (short)485163009;
			if (num != 0)
			{
			}
			this.n();
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000867F4 File Offset: 0x000849F4
		private void setEditor_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1019674625;
			if (num != 0)
			{
			}
			num = (short)1865047822;
			short num2 = num;
			num = (short)1850040078;
			switch (num2 == num)
			{
			default:
			{
				num = (short)205389824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1571749888;
			if (num != 0)
			{
			}
			this.k();
			this.a(true);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000868A8 File Offset: 0x00084AA8
		private void setEditor_SizeChanged(object A_0, global::System.Windows.SizeChangedEventArgs A_1)
		{
			short num = (short)1740604468;
			short num2 = num;
			num = (short)543065140;
			switch (num2 == num)
			{
			}
			num = (short)284688384;
			short num3 = num;
			num = (short)393347073;
			if (num != 0)
			{
			}
			num = (short)108462080;
			if (num != 0)
			{
			}
			this.a(false);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00086958 File Offset: 0x00084B58
		private void SystemEvents_DisplaySettingsChanged(global::System.EventArgs A_0)
		{
			short num = (short)2101767835;
			short num2 = num;
			num = (short)1652911771;
			switch (num2 == num)
			{
			}
			num = (short)1661140992;
			short num3 = num;
			num = (short)1388314625;
			if (num != 0)
			{
			}
			num = (short)840368128;
			if (num != 0)
			{
			}
			this.scwSetEditor.MaxWidth = global::System.Windows.SystemParameters.PrimaryScreenWidth * 0.75;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00086A1C File Offset: 0x00084C1C
		private void a(object A_0)
		{
			short num = (short)2023926777;
			short num2 = num;
			num = (short)184265721;
			switch (num2 == num)
			{
			}
			num = (short)1428422656;
			short num3 = num;
			num = (short)383123457;
			if (num != 0)
			{
			}
			num = (short)1966473216;
			if (num != 0)
			{
			}
			this.fieldDicForTopSetEditing.Clear();
			this.visibleFieldListDict.Clear();
			this.setCategoryFieldCache.Clear();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00086AE4 File Offset: 0x00084CE4
		private void RMSetPresenter_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1424293892;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)465100790;
					short num3 = num;
					num = (short)134995958;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
					{
						num = (short)731906048;
						short num4 = num;
						num = (short)605290497;
						if (num != 0)
						{
						}
						num = (short)52887552;
						if (num != 0)
						{
						}
						num = (short)2089091074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
					{
						goto IL_13C;
					}
					return;
				case 3:
					this.scwSetEditor.Focus();
					num = (short)1282277376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (A_1.Key == global::System.Windows.Input.Key.S)
				{
					num = (short)1163198465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13C:
				num = (short)652804099;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00086C4C File Offset: 0x00084E4C
		private void a(bool A_0)
		{
			short num = (short)779747328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor;
				for (;;)
				{
					IL_27:
					global::System.Windows.Controls.ItemsControl itemsControl;
					global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
					switch (num2)
					{
					case 0:
						goto IL_1C9;
					case 1:
						num = (short)1713635331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						rmfieldEditor = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.FindChildByName<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(itemsControl, this.SetCategory.ActiveSet.ActiveFieldName);
						num = (short)544547324;
						short num3 = num;
						num = (short)380510716;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32D;
						default:
							num = (short)2129592320;
							if (num != 0)
							{
							}
							num = (short)1487470602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_32D;
					case 4:
						if (this.SetCategory != null)
						{
							num = (short)1038811137;
							if (num != 0)
							{
							}
							num = (short)1675755529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (itemsControl != null)
						{
							num = (short)2002059266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (this.SetCategory.ActiveSet != null)
						{
							num = (short)240582657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(rmfieldEditor);
						num = (short)718798848;
						short num4 = num;
						num = (short)222691328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1223098382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)305135622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (rmfieldEditor != null)
						{
							num = (short)2094989320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						if (rmsetEditor != null)
						{
							num = (short)492961807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						return;
					case 13:
						itemsControl = this.q();
						num = (short)1821376517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (A_0)
						{
							num = (short)980680711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C9;
					case 15:
						num = (short)911147012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E;
					IL_1C9:
					double y = rmfieldEditor.TranslatePoint(default(global::System.Windows.Point), itemsControl).Y;
					this.a(rmfieldEditor, itemsControl);
					this.SetCategory.ActiveSet.ActiveFieldName = string.Empty;
					num = (short)1075707916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					if (string.IsNullOrEmpty(this.SetCategory.ActiveSet.ActiveFieldName))
					{
						break;
					}
					num = (short)724500493;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6E:
				rmsetEditor = this.m();
				num = (short)1344733195;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00086FBC File Offset: 0x000851BC
		internal global::System.Windows.Controls.ItemsControl q()
		{
			short num;
			int num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor;
			global::System.Windows.Controls.ItemsControl result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1956642817;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1204967693;
						short num3 = num;
						num = (short)1436899597;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4B;
						default:
						{
							num = (short)192282624;
							if (num != 0)
							{
							}
							num = (short)1480523776;
							short num4 = num;
							result = (rmsetEditor.Content as global::System.Windows.Controls.ItemsControl);
							num = (short)1425080321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						if (rmsetEditor != null)
						{
							num = (short)1293811712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_42;
				}
				return result;
			}
			IL_42:
			result = null;
			rmsetEditor = this.m();
			IL_4B:
			num = (short)809697282;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000870E0 File Offset: 0x000852E0
		private global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor m()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					string key = this.a(this.SetCategory.ActiveSet);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.GetAttachedGlueWindowByKey(key);
					num2 = (short)1636499456;
					short num3 = num2;
					num2 = (short)1430454276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey;
					result = (attachedGlueWindowByKey.InnerContent as global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor);
					num2 = (short)1148452869;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1381302273;
					if (num2 != 0)
					{
					}
					if (this.SetCategory != null)
					{
						num2 = (short)962854920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey;
					if (attachedGlueWindowByKey != null)
					{
						num2 = (short)1242824706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 5:
					return result;
				case 6:
				{
					num2 = (short)147862228;
					short num4 = num2;
					num2 = (short)1209807572;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)453967872;
						if (num2 != 0)
						{
						}
						if (this.SetCategory.ActiveSet != null)
						{
							num2 = (short)1401290753;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 7:
					if (!this.isUsingGlueWindowForscwSetEditorContent)
					{
						num2 = (short)1597898761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1733230595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1152843782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					result = (this.scwSetEditor.Content as global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor);
					num2 = (short)1788018688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
			}
			return result;
			IL_38:
			result = null;
			num2 = (short)1145503751;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00087320 File Offset: 0x00085520
		private global::System.Windows.Controls.ScrollViewer l()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Windows.Controls.ScrollViewer result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					result = this.scwSetEditor;
					num2 = (short)1853536936;
					short num3 = num2;
					num2 = (short)1007270568;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_99;
					default:
						num2 = (short)683999232;
						if (num2 != 0)
						{
						}
						num2 = (short)36634628;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey;
					if (attachedGlueWindowByKey != null)
					{
						num2 = (short)1637482499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
					return result;
				case 3:
				{
					num2 = (short)138149888;
					short num4 = num2;
					num2 = (short)1179516929;
					if (num2 != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey;
					result = attachedGlueWindowByKey.InnerScrollViewer;
					num2 = (short)1549205506;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return result;
				case 5:
				{
					if (!this.isUsingGlueWindowForscwSetEditorContent)
					{
						num2 = (short)1664811008;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string key = this.a(this.SetCategory.ActiveSet);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.GetAttachedGlueWindowByKey(key);
					goto IL_99;
				}
				}
				goto IL_28;
				IL_99:
				num2 = (short)904593409;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_28:
			result = null;
			num2 = (short)103809029;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000874C0 File Offset: 0x000856C0
		private void k()
		{
			short num = (short)960561152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				global::System.Windows.Controls.ItemsControl itemsControl;
				global::System.Collections.Generic.List<object[]> list;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor> enumerator;
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor> enumerable2;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						try
						{
							num = (short)658243588;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1010958339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)907149312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor rmlinkFieldEditor = enumerator.Current;
									object[] item = new object[]
									{
										rmlinkFieldEditor.Label,
										rmlinkFieldEditor.TranslatePoint(default(global::System.Windows.Point), itemsControl).Y.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
										rmlinkFieldEditor,
										rmlinkFieldEditor
									};
									list.Add(item);
									num = (short)1638596610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_22C;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_163;
									}
									continue;
								}
								IL_165:
								num = (short)3670017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_163:
								goto IL_165;
							}
							IL_22C:
							goto IL_45A;
						}
						finally
						{
							num = (short)1608777730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									for (;;)
									{
										num = (short)1675739470;
										short num3 = num;
										num = (short)472301902;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_2B6;
										}
									}
									IL_2B6:
									num = (short)240058368;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)1109393409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2EC;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_263;
									}
									continue;
								}
								IL_263:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1096351744;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EC:;
						}
						goto Block_3;
					case 2:
					{
						num = (short)1461321728;
						short num4 = num;
						goto IL_2EF;
					}
					case 3:
					{
						if (itemsControl == null)
						{
							num = (short)1028915200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<object[]>();
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor> enumerable = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor>(itemsControl);
						enumerable2 = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor>(itemsControl);
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor> enumerator2 = enumerable.GetEnumerator();
						num = (short)393871361;
						if (num != 0)
						{
						}
						num = (short)372637698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_40;
					Block_3:
					try
					{
						IL_2EF:
						num = (short)655818756;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1878327299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor> enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)1059323904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor rmanchor = enumerator2.Current;
								object[] item2 = new object[]
								{
									rmanchor.Caption,
									rmanchor.TranslatePoint(default(global::System.Windows.Point), itemsControl).Y.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
									null,
									rmanchor
								};
								list.Add(item2);
								num = (short)1289617410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_3E9;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_329;
								}
								continue;
							}
							IL_32B:
							num = (short)899809281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_329:
							goto IL_32B;
						}
						IL_3E9:
						goto IL_7B;
					}
					finally
					{
						num = (short)307429378;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor> enumerator2;
							switch (num2)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)126418945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_457;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_420;
								}
								continue;
							}
							IL_420:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)941686784;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_457:;
					}
					goto IL_45A;
					IL_7B:
					enumerator = enumerable2.GetEnumerator();
					num = (short)1459093505;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_45A:
				this.ictAnchors.ItemsSource = list;
				return;
				IL_40:
				itemsControl = this.q();
				num = (short)1269235715;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00087968 File Offset: 0x00085B68
		public void ResetLayout()
		{
			int a_ = 17;
			short num = (short)244776960;
			switch (num)
			{
			default:
			{
				num = (short)645529627;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>.Enumerator enumerator2;
					global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor;
					global::System.Windows.UIElement uielement;
					global::System.Windows.Visibility visibility;
					switch (num2)
					{
					case 0:
						this.gridSets.Visibility = global::System.Windows.Visibility.Hidden;
						this.dgrZonelist.Visibility = global::System.Windows.Visibility.Hidden;
						num = (short)308019235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1174;
					case 2:
						try
						{
							num = (short)30736384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_974;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1056571395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo preloadFieldInfo = enumerator.Current;
									global::Infragistics.Windows.DataPresenter.Field unboundPreloadFieldByFieldName = global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.GetUnboundPreloadFieldByFieldName(preloadFieldInfo.FieldName, global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.Instance().GetStringByResourceID(preloadFieldInfo.ResourceID, null), 1, 1024, false);
									unboundPreloadFieldByFieldName.AllowEdit = new bool?(false);
									this.dgrSets.FieldLayouts[0].Fields.Add(unboundPreloadFieldByFieldName);
									num = (short)1071054849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)205914116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_A38;
								}
								IL_976:
								num = (short)399179778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_974:
								goto IL_976;
							}
							IL_A38:
							goto IL_6B1;
						}
						finally
						{
							num = (short)45350912;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A6F;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)398524418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_AA4;
								}
								IL_A6F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2490369;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AA4:;
						}
						goto IL_AA7;
						IL_6B1:
						this.dgrSets.FieldLayouts[0].Fields.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪사쪮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Name));
						this.dgrSets.FieldLayouts[0].Fields.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪪\ud9ac쪮", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_LastModifiedDate)
						{
							EditAsType = typeof(global::System.DateTime),
							AllowEdit = new bool?(false)
						});
						this.dgrSets.FieldLayouts[0].Fields.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪사슮풰\uddb2솴쒶", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Comments));
						num = (short)236650549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!flag)
						{
							num = (short)214302762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ADE;
					case 4:
						goto IL_ADE;
					case 5:
						goto IL_1099;
					case 6:
						if (!this.SetCategory.TelePortMode)
						{
							goto IL_8CB;
						}
						goto IL_4DF;
					case 7:
						try
						{
							num = (short)1879441411;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Infragistics.Windows.DataPresenter.Field unboundField;
									this.dgrSets.FieldLayouts[0].Fields.Add(unboundField);
									num = (short)1945239560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									global::Infragistics.Windows.DataPresenter.Field unboundField = global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.GetUnboundField((global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)rmfieldEditor);
									num = (short)2113863684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)909967369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_D4F;
									}
									continue;
								case 4:
								{
									global::Infragistics.Windows.DataPresenter.Field unboundField;
									if (unboundField != null)
									{
										num = (short)1686437888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (!this.SetCategory.IsFieldTiedOut(rmfieldEditor.Name, null))
									{
										num = (short)428933122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)878575626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)3276806;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor = enumerator2.Current;
									num = (short)1062797317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (rmfieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)
									{
										num = (short)1877147649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_EBA;
								}
								IL_E2A:
								num = (short)1069350919;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D4F:
								goto IL_E2A;
							}
							IL_EBA:
							goto IL_101B;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_ECD;
					case 8:
						this.codList.Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
						this.codEditor.Width = global::System.Windows.GridLength.Auto;
						num = (short)1146748977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)980484158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1992359991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_1F1;
					case 12:
						num = (short)552206353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_7B2;
					case 14:
						num = (short)1112014854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.FlatSetConverter != null)
						{
							num = (short)1380777984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1174;
					case 16:
						if (!rmsetEditor.GetType().ToString().EndsWith(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螨", a_) + this.SetCategory.Name, global::System.StringComparison.Ordinal))
						{
							num = (short)2026373170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C21;
					case 17:
						if (this.FlatSetConverter != null)
						{
							num = (short)407699457;
							if (num != 0)
							{
							}
							num = (short)1793589286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1174;
					case 18:
						if (this.SetCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("令ﾬ\udeb0\uddb2솴횶\udab8쾺캼", a_))
						{
							num = (short)1078591502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					case 19:
						goto IL_1174;
					case 20:
						goto IL_1174;
					case 21:
						num = (short)530776118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						uielement = this.mniShowRelatedConfigurations;
						if (!this.SetCategory.IsShareable)
						{
							visibility = global::System.Windows.Visibility.Collapsed;
							goto IL_1268;
						}
						goto IL_ECD;
					case 23:
						if (flag)
						{
							num = (short)1711669257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 24:
						num = (short)538247220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						return;
					case 26:
						goto IL_C21;
					case 27:
						switch (0)
						{
						case 0:
							goto IL_15D;
						}
						continue;
					case 28:
					{
						if (this.WorkMode != global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Editing)
						{
							goto IL_11CB;
						}
						num = (short)696840815;
						short num3 = num;
						num = (short)1857221231;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8CB;
						default:
							num = (short)202506240;
							if (num != 0)
							{
							}
							num = (short)152174604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 29:
						if (this.SetCategory.IsTopSet)
						{
							num = (short)988741675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1782710302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (this.SetCategory.IsShowingSetName)
						{
							num = (short)535560255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1099;
					case 31:
						num = (short)1693384770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (rmsetEditor != null)
						{
							num = (short)1648164928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC;
					case 33:
						goto IL_398;
					case 34:
						this.btnUp.Visibility = global::System.Windows.Visibility.Visible;
						this.btnDown.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)559284283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_1174;
					case 36:
						goto IL_10EA;
					case 37:
						if (this.SetCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪쎬쪮슰", a_))
						{
							num = (short)1398341645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11CB;
					case 38:
						this.gridSets.Visibility = global::System.Windows.Visibility.Hidden;
						this.dgrZonelist.ReBindingItemsSource(this.FlatSetConverter, this.SetCategory);
						this.dgrZonelist.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)190316564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_AA7;
					case 40:
						this.dgrSets.FieldLayouts[0].Fields.Clear();
						this.dgrSets.FieldLayouts[0].Fields.Add(new global::Infragistics.Windows.DataPresenter.Field
						{
							BindingType = global::Infragistics.Windows.DataPresenter.BindingType.Unbound,
							Settings = new global::Infragistics.Windows.DataPresenter.FieldSettings
							{
								AllowHiding = global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never,
								CellValuePresenterStyle = (global::System.Windows.Style)global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얪\udbac캮\uddb0\udab2톴\udcb8ힺ톼ꃀ꿂냄ꋆ駈맊꣌볎듐뷒ꇔ닖ꯘ裚꧜ꛞ跠蛢", a_)],
								LabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing,
								CellWidth = 20.0,
								CellMinWidth = 20.0,
								CellMaxWidth = 20.0
							}
						});
						num = (short)1267728417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_101B;
					case 42:
					{
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo> preloadFieldNameList = this.SetCategory.GetPreloadFieldNameList();
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo> enumerator = preloadFieldNameList.GetEnumerator();
						num = (short)2034171906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						num = (short)858128387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)1332084803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (rmsetEditor.OrderStartIndex != -1)
						{
							num = (short)187432970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F1;
					case 46:
						this.currentSetCategoryForTopSetEditing = this.SetCategory;
						this.e();
						this.a(null, this.SetCategory);
						this.j();
						num = (short)314966073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_1F1;
					case 48:
						this.dgrSets.FieldLayouts[0].Fields.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪쎬즮\ud8b0풲살얶\ud8b8쾺풼킾꿀胂꫄닆ꟈ뿊", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_ConfigurationCount));
						num = (short)1459290116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (!(this.SetCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒪쎬쪮", a_)))
						{
							num = (short)2002714685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B2;
					case 50:
						goto IL_1CC;
					case 51:
						if (!flag)
						{
							num = (short)1027014696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_398;
					case 52:
						if (this.SetCategory.TelePortMode)
						{
							num = (short)712114215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					case 53:
						if (this.SetCategory.TelePortMode)
						{
							num = (short)1864564784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ADE;
					case 54:
						if (!this.SetCategory.IsExpandEmbeddedSet)
						{
							num = (short)938147871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					case 55:
						if (this.SetCategory.IsTopSet)
						{
							num = (short)608043032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					case 56:
						num = (short)1823408156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_7F9;
					case 58:
						if (!this.SetCategory.TelePortMode)
						{
							num = (short)1962344492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11CB;
					case 59:
						goto IL_10EA;
					case 60:
						if (rmsetEditor.AllowMoveSet)
						{
							num = (short)89522210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.btnUp.Visibility = global::System.Windows.Visibility.Hidden;
						this.btnDown.Visibility = global::System.Windows.Visibility.Hidden;
						num = (short)97452068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1649606693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (!this.SetCategory.Equals(this.currentSetCategoryForTopSetEditing))
						{
							num = (short)1905000494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F9;
					case 63:
					{
						num = (short)1620180992;
						short num4 = num;
						this.dgrSets.FieldLayouts[0].Fields.Add(global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.GetUnboundFieldByFieldName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("直캪\ud9ac킰\udeb2킴", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Name, 0, 120, true));
						num = (short)1585446917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						num = (short)729481232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num = (short)381550607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (this.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Editing)
						{
							num = (short)126419009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					case 67:
						if (!this.SetCategory.IsExpandEmbeddedSet)
						{
							num = (short)220397624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11CB;
					}
					IL_15D:
					if (this.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Editing)
					{
						num = (short)1631256584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Data.BindingOperations.ClearBinding(this.dgrSets, global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedTotalCountProperty);
					this.codList.Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
					this.codEditor.Width = global::System.Windows.GridLength.Auto;
					this.grdSplitter.Visibility = global::System.Windows.Visibility.Collapsed;
					this.ctmSets.Visibility = global::System.Windows.Visibility.Hidden;
					this.btnAdditional.IsEnabled = false;
					num = (short)1892941825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					rmsetEditor = this.LoadSetEditor();
					num = (short)2095120410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F1:
					num = (short)1183187004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_301:
					global::Infragistics.Windows.DataPresenter.Field item = new global::Infragistics.Windows.DataPresenter.Field
					{
						Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.PostitionConverter(),
						ConverterParameter = rmsetEditor.OrderStartIndex,
						Name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("令쒪\udeac욮얰\udab2\udab4\ud9b6", a_),
						Label = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Position
					};
					this.btnUp.Visibility = global::System.Windows.Visibility.Visible;
					this.btnDown.Visibility = global::System.Windows.Visibility.Visible;
					this.dgrSets.FieldLayouts[0].Fields.Insert(0, item);
					num = (short)211615791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_398:
					num = (short)176160797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DF:
					this.gridSets.Visibility = global::System.Windows.Visibility.Visible;
					this.dgrZonelist.Visibility = global::System.Windows.Visibility.Hidden;
					num = (short)1131872275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B2:
					num = (short)1489436730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F9:
					this.i();
					num = (short)60227609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8CB:
					num = (short)595591189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA7:
					this.btnUp.Visibility = global::System.Windows.Visibility.Hidden;
					this.btnDown.Visibility = global::System.Windows.Visibility.Hidden;
					num = (short)192086027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ADE:
					this.btnUp.Visibility = global::System.Windows.Visibility.Hidden;
					this.btnDown.Visibility = global::System.Windows.Visibility.Hidden;
					num = (short)188022806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C21:
					num = (short)1029242925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101B:
					num = (short)1390805015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1099:
					this.mniShowRelatedConfigurations.Visibility = global::System.Windows.Visibility.Collapsed;
					rmsetEditor = this.m();
					num = (short)103612448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10EA:
					global::System.Windows.Controls.ItemCollection items = ((global::System.Windows.Controls.ItemsControl)rmsetEditor.Content).Items;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> fieldEditorList = rmsetEditor.GetFieldEditorList();
					enumerator2 = fieldEditorList.GetEnumerator();
					num = (short)536412167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1174:
					this.grdBorder.Visibility = global::System.Windows.Visibility.Collapsed;
					flag = this.g();
					this.f();
					num = (short)641990707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11CB:
					num = (short)473038866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1268:
					uielement.Visibility = visibility;
					num = (short)2069495849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ECD:
					visibility = global::System.Windows.Visibility.Visible;
					goto IL_1268;
				}
				return;
			}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00088C34 File Offset: 0x00086E34
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00088CF0 File Offset: 0x00086EF0
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> FillDownSourceFields
		{
			get
			{
				short num = (short)1939851306;
				short num2 = num;
				num = (short)115132458;
				switch (num2 == num)
				{
				}
				num = (short)1838940161;
				if (num != 0)
				{
				}
				num = (short)1810300928;
				short num3 = num;
				num = (short)190447616;
				if (num != 0)
				{
				}
				return (global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FillDownSourceFieldsProperty);
			}
			set
			{
				short num = (short)1669534200;
				short num2 = num;
				num = (short)1517031928;
				switch (num2 == num)
				{
				}
				num = (short)226689025;
				if (num != 0)
				{
				}
				num = (short)225837056;
				short num3 = num;
				num = (short)1114112000;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FillDownSourceFieldsProperty, value);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00088DA4 File Offset: 0x00086FA4
		private void j()
		{
			short num = (short)2136735746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)575143937;
					if (num != 0)
					{
					}
					this.mniFillDown.Visibility = global::System.Windows.Visibility.Visible;
					this.ctmSets.Opened -= this.OnFillDownContextMenuOpen;
					this.ctmSets.Opened += this.OnFillDownContextMenuOpen;
					num = (short)50331648;
					short num3 = num;
					num = (short)548012033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_FD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				goto IL_32;
				IL_42:
				num = (short)101711872;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FD:
				num = (short)1314804614;
				short num4 = num;
				num = (short)921260934;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_42;
				default:
					goto IL_132;
				}
				IL_32:
				if (this.ctmSets.Visibility == global::System.Windows.Visibility.Visible)
				{
					goto IL_42;
				}
				goto IL_FD;
			}
			IL_132:
			num = (short)1405353984;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00088EFC File Offset: 0x000870FC
		private void OnFillDownContextMenuOpen(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1869152257;
			if (num != 0)
			{
			}
			num = (short)1947157609;
			short num2 = num;
			num = (short)943015017;
			switch (num2 == num)
			{
			}
			num = (short)1603796992;
			short num3 = num;
			num = (short)36896768;
			if (num != 0)
			{
			}
			this.FillDownSourceFields = this.dgrSets.SelectedItems.Cells.Cast<global::Infragistics.Windows.DataPresenter.Cell>().OrderBy(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, int>(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c.<>9.a)).Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c.<>9.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>();
			this.FillDownCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00089020 File Offset: 0x00087220
		private void i()
		{
			short num = (short)374264232;
			short num2 = num;
			num = (short)618713512;
			switch (num2 == num)
			{
			}
			num = (short)249233408;
			if (num != 0)
			{
			}
			num = (short)727842816;
			short num3 = num;
			num = (short)187564033;
			if (num != 0)
			{
			}
			this.currentSetCategoryForTopSetEditing.RaisePropertyChanged();
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x000890D4 File Offset: 0x000872D4
		private bool IsTopSetEditingFeatureEnabled
		{
			get
			{
				short num = (short)887537656;
				short num2 = num;
				num = (short)552779768;
				switch (num2 == num)
				{
				}
				num = (short)1603076096;
				if (num != 0)
				{
				}
				num = (short)1536229376;
				short num3 = num;
				num = (short)138608641;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00089180 File Offset: 0x00087380
		private bool g()
		{
			short num = (short)1601306626;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					if (this.gridSets.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)1643184132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					while (!this.SetCategory.TelePortMode)
					{
						num = (short)1504509952;
						short num3 = num;
						num = (short)1570639955;
						short num4 = num;
						num = (short)1224085587;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)963117057;
							if (num != 0)
							{
							}
							num = (short)513933312;
							if (num != 0)
							{
							}
							num = (short)1772486659;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					return false;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					goto IL_14B;
				case 4:
					num = (short)1180827649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)650313728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (!this.IsTopSetEditingFeatureEnabled)
				{
					return false;
				}
				num = (short)304873477;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14B:
			return this.SetCategory.MaxCapacity > 1;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00089324 File Offset: 0x00087524
		private void f()
		{
			short num;
			if (this.g())
			{
				num = (short)494371313;
				short num2 = num;
				num = (short)1996718577;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1388969985;
					if (num != 0)
					{
					}
					num = (short)1674510336;
					if (num != 0)
					{
					}
					this.panelSaveDiscardTopsets.Visibility = global::System.Windows.Visibility.Collapsed;
					this.mniFillDown.Visibility = global::System.Windows.Visibility.Visible;
					this.dgrSets.FieldSettings.ForceCellVirtualization = new bool?(true);
					this.dgrSets.FieldSettings.CellMinWidth = 100.0;
					this.dgrSets.FieldSettings.AutoSizeOptions = new global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions?(global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.DataCells);
					this.gridSets.IsVisibleChanged += this.a;
					return;
				}
			}
			num = (short)2095841280;
			short num3 = num;
			this.panelSaveDiscardTopsets.Visibility = global::System.Windows.Visibility.Collapsed;
			this.mniFillDown.Visibility = global::System.Windows.Visibility.Collapsed;
			this.dgrSets.FieldSettings.ForceCellVirtualization = new bool?(false);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0008947C File Offset: 0x0008767C
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)704577537;
			if (num != 0)
			{
			}
			num = (short)1193299868;
			short num2 = num;
			num = (short)953503644;
			switch (num2 == num)
			{
			}
			num = (short)1427898368;
			short num3 = num;
			num = (short)1977155584;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsRefreshWholeSetWhenNotifyAllTopLevelSetCategorysRefresh = this.gridSets.IsVisible;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00089534 File Offset: 0x00087734
		private void e()
		{
			int a_ = 15;
			short num = (short)1508704256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor setEditor;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list;
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_BC;
					case 1:
						list = this.setCategoryFieldCache[this.currentSetCategoryForTopSetEditing];
						num = (short)915406848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_38A;
					case 3:
						if (this.visibleFieldListDict.ContainsKey(this.currentSetCategoryForTopSetEditing))
						{
							num = (short)1017905159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 4:
						num = (short)1424752648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_BC;
					case 6:
						if (setEditor != null)
						{
							num = (short)1689714692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_469;
					case 8:
					{
						num = (short)1794637824;
						short num3 = num;
						if (this.setCategoryFieldCache.ContainsKey(this.currentSetCategoryForTopSetEditing))
						{
							num = (short)828702721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::Infragistics.Windows.DataPresenter.Field> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::Infragistics.Windows.DataPresenter.Field>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> allFieldEditors = setEditor.GetAllFieldEditors(true);
						list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
						list.Add(new global::Infragistics.Windows.DataPresenter.Field
						{
							BindingType = global::Infragistics.Windows.DataPresenter.BindingType.Unbound,
							Settings = new global::Infragistics.Windows.DataPresenter.FieldSettings
							{
								AllowHiding = global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never,
								CellValuePresenterStyle = (global::System.Windows.Style)global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잨\uddaa첬쎮\ud8b0ힲ튶햸ힺ\udebe귀뛂ꃄ韆믈껊뻌꫎뿐꟒냔ꗖ諘꿚ꓜ돞蓠", a_)],
								LabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing,
								CellWidth = 20.0,
								CellMinWidth = 20.0,
								CellMaxWidth = 20.0
							}
						});
						list.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좨욪좬", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Name));
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>.Enumerator enumerator = allFieldEditors.GetEnumerator();
						num = (short)2054619146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							num = (short)868417537;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1596593370;
									short num4 = num;
									num = (short)1066210522;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_298;
									default:
										num = (short)1485832192;
										if (num != 0)
										{
										}
										num = (short)1156317187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_270;
									}
									continue;
								case 2:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)454950912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.Field item = enumerator2.Current;
									this.dgrSets.FieldLayouts[0].Fields.Add(item);
									goto IL_298;
								}
								case 3:
									goto IL_349;
								}
								goto IL_270;
								IL_298:
								num = (short)231931908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2AF:
								num = (short)1311703042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_270:
								goto IL_2AF;
							}
							IL_349:
							goto IL_405;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_35C;
						IL_405:
						this.dgrSets.FieldLayouts[0].Fields.EndUpdate();
						num = (short)1361379331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::Infragistics.Windows.DataPresenter.Field> dictionary;
						try
						{
							num = (short)1005781007;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									string a_2 = this.b(rmfieldEditor);
									global::Infragistics.Windows.DataPresenter.Field field = global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a(rmfieldEditor, a_2);
									num = (short)546897925;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (!string.IsNullOrEmpty(rmfieldEditor.Name))
									{
										num = (short)374079495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_833;
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (rmfieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)
									{
										num = (short)1452343312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_634;
								}
								case 4:
								{
									global::Infragistics.Windows.DataPresenter.Field field = null;
									num = (short)1397948424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_634;
								case 7:
									num = (short)812974092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (rmfieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)
									{
										num = (short)1948319761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1853620238;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Infragistics.Windows.DataPresenter.Field field;
									field.Visibility = global::System.Windows.Visibility.Visible;
									list.Add(field);
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									dictionary.Add(rmfieldEditor, field);
									num = (short)1666908166;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_634;
								case 11:
									goto IL_634;
								case 12:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (!this.currentSetCategoryForTopSetEditing.IsFieldTiedOut(rmfieldEditor.Name, null))
									{
										num = (short)507510788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)1427636226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									if (this.a(rmfieldEditor))
									{
										num = (short)1540292608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)885129219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									switch (0)
									{
									case 0:
										goto IL_579;
									}
									continue;
								case 16:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									global::Infragistics.Windows.DataPresenter.Field field = global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.GetUnboundField((global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)rmfieldEditor);
									num = (short)2108948490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									global::Infragistics.Windows.DataPresenter.Field field = global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.a((global::Motorola.CommonCPS.RadioManagement.Controls.RMBoolFieldEditor)rmfieldEditor, true);
									num = (short)1721499659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)462159885;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor = enumerator.Current;
									num = (short)1255800833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									global::Infragistics.Windows.DataPresenter.Field field;
									if (field != null)
									{
										num = (short)478609417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_5F1:
								num = (short)1084358674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_579:
								goto IL_5F1;
								IL_634:
								num = (short)1833631763;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_833:
							goto IL_46E;
						}
						finally
						{
							num = (short)1083441153;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						return;
						IL_46E:
						list.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좨\udfaa좬", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_LastModifiedDate)
						{
							EditAsType = typeof(global::System.DateTime),
							AllowEdit = new bool?(false)
						});
						list.Add(new global::Infragistics.Windows.DataPresenter.Field(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욨욪사쪮\udfb0잲운", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Comments));
						this.setCategoryFieldCache.Add(this.currentSetCategoryForTopSetEditing, list);
						this.a(dictionary);
						num = (short)1309409285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_64;
					IL_BC:
					this.dgrSets.FieldLayouts[0].Fields.BeginUpdate();
					this.dgrSets.FieldLayouts[0].Fields.Clear();
					enumerator2 = list.GetEnumerator();
					num = (short)26017801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					this.visibleFieldListDict.Add(this.currentSetCategoryForTopSetEditing, new global::System.Collections.Generic.List<string>());
					num = (short)1408565250;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_38A:
				return;
				IL_469:
				this.visibleFieldListDict[this.currentSetCategoryForTopSetEditing] = new global::System.Collections.Generic.List<string>();
				return;
				IL_64:
				setEditor = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.GetSetEditor(this.currentSetCategoryForTopSetEditing.Name, this.currentSetCategoryForTopSetEditing.TelePortMode, true);
				num = (short)852492294;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00089DE4 File Offset: 0x00087FE4
		private string b(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1855586305;
					if (num2 != 0)
					{
					}
					goto IL_F3;
				case 1:
					return text;
				case 2:
				{
					num2 = (short)523984256;
					short num3 = num2;
					num2 = (short)722230656;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
					{
						num2 = (short)1387528192;
						short num4 = num2;
						num2 = (short)526581760;
						if (num2 != 0)
						{
						}
						if (string.IsNullOrEmpty(text))
						{
							num2 = (short)1373175808;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return text;
					}
					}
					break;
				}
				}
				goto IL_1C;
				IL_F3:
				string fieldUiLabel = this.currentSetCategoryForTopSetEditing.GetFieldUiLabel(A_0.Name, this.currentSetCategoryForTopSetEditing.Name);
				text = fieldUiLabel;
				num2 = (short)1587544065;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_1C:
			text = A_0.Label;
			num2 = (short)1109590018;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00089F20 File Offset: 0x00088120
		private bool a(global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor A_0)
		{
			short num = (short)1013645315;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)644546561;
					if (num != 0)
					{
					}
					num = (short)247726085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1386365859;
					short num3 = num;
					num = (short)590496675;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15A;
					default:
						goto IL_D4;
					}
					break;
				}
				case 2:
					num = (short)2110193671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 4:
					if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor))
					{
						num = (short)550436864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover))
					{
						num = (short)103350274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					goto IL_15A;
				case 7:
					if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor))
					{
						num = (short)1107689473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_46:
				if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor))
				{
					num = (short)1492713478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_15A:
				num = (short)249692164;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			num = (short)92012544;
			short num4 = num;
			num = (short)263061504;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0008A0F0 File Offset: 0x000882F0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory A_1)
		{
			short num = (short)152240130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					A_1.FieldVisibilityChanged -= this.OnSetCategoryFieldVisibilityChanged;
					A_1.FieldVisibilityChanged += this.OnSetCategoryFieldVisibilityChanged;
					num = (short)1455554561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
				{
					num = (short)176228631;
					short num3 = num;
					num = (short)736823575;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1834221568;
						if (num != 0)
						{
						}
						if (A_1 != null)
						{
							num = (short)1943601152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					goto IL_BF;
				case 5:
					A_0.FieldVisibilityChanged -= this.OnSetCategoryFieldVisibilityChanged;
					num = (short)204341252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				num = (short)7471105;
				if (num != 0)
				{
				}
				if (A_0 != null)
				{
					num = (short)1858928645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BF:
				num = (short)55771136;
				short num4 = num;
				num = (short)664993795;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0008A29C File Offset: 0x0008849C
		private void OnSetCategoryFieldVisibilityChanged(object A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldVisibilityChangedEventArgs A_1)
		{
			short num = (short)125304832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					global::System.Collections.Generic.IEnumerable<string> enumerable;
					global::System.Collections.Generic.IEnumerable<string> enumerable2;
					global::System.Collections.Generic.IEnumerable<string> enumerable3;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)1159921666;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string text;
									this.fieldDicForTopSetEditing[text].Visibility = global::System.Windows.Visibility.Visible;
									num = (short)1165623297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7F4;
									}
									continue;
								case 3:
								{
									string text;
									if (this.fieldDicForTopSetEditing.Keys.Contains(text))
									{
										num = (short)324272128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_8C5;
								case 5:
									num = (short)451739652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1795817477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									num = (short)1771438083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_870:
								num = (short)976748550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7F4:
								goto IL_870;
							}
							IL_8C5:;
						}
						finally
						{
							num = (short)86376448;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8FB;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)110493698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_934;
								}
								IL_8FB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)45088769;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_934:;
						}
						global::System.Collections.Generic.IEnumerator<string> enumerator2 = enumerable.GetEnumerator();
						num = (short)1929314313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.visibleFieldListDict.ContainsKey(this.currentSetCategoryForTopSetEditing))
						{
							num = (short)2084503560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F9;
					case 2:
						enumerable2 = this.visibleFieldListDict[this.currentSetCategoryForTopSetEditing];
						num = (short)384827403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						if (this.currentSetCategoryForTopSetEditing != setCategory)
						{
							num = (short)1389166595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)200736769;
						if (num != 0)
						{
						}
						num = (short)200474630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						try
						{
							num = (short)144572417;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								case 2:
									num = (short)608567302;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									string text2;
									this.fieldDicForTopSetEditing[text2].Visibility = global::System.Windows.Visibility.Visible;
									num = (short)515178496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.List<string> childFields;
									if (childFields.Intersect(enumerable3).Any<string>())
									{
										num = (short)676331523;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator3;
									if (!enumerator3.MoveNext())
									{
										num = (short)1960116226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text2 = enumerator3.Current;
									global::System.Collections.Generic.List<string> childFields = this.currentSetCategoryForTopSetEditing.GetChildFields(text2, this.currentSetCategoryForTopSetEditing.Name);
									num = (short)434372616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2A6;
								case 7:
									num = (short)392560644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.List<string> childFields;
									if (childFields.Count != 0)
									{
										num = (short)822870023;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1EC:
								num = (short)508887045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_180:
								goto IL_1EC;
							}
							IL_2A6:
							goto IL_95C;
						}
						finally
						{
							num = (short)1757806592;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator3;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2DE;
									}
									continue;
								case 1:
									enumerator3.Dispose();
									num = (short)772014082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_316;
								}
								IL_2DE:
								if (enumerator3 == null)
								{
									break;
								}
								num = (short)1285292033;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_316:;
						}
						goto IL_319;
						IL_95C:
						global::System.Collections.Generic.IEnumerable<string> enumerable4 = this.fieldDicForTopSetEditing.Keys.Except(enumerable);
						global::System.Collections.Generic.IEnumerator<string> enumerator4 = enumerable4.GetEnumerator();
						num = (short)1285816330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (this.visibleFieldListDict.ContainsKey(this.currentSetCategoryForTopSetEditing))
						{
							num = (short)1523580930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerable2 = new global::System.Collections.Generic.List<string>();
						num = (short)51314695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_53D;
					case 8:
						goto IL_361;
					case 9:
					{
						try
						{
							num = (short)727318530;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator2;
									if (enumerator2.MoveNext())
									{
										string text3 = enumerator2.Current;
										num = (short)1046806529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1829441238;
									short num3 = num;
									num = (short)1124798166;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)93257728;
										if (num != 0)
										{
										}
										num = (short)495386630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									string text3;
									if (this.fieldDicForTopSetEditing.Keys.Contains(text3))
									{
										num = (short)2128281603;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3A9;
									}
									continue;
								case 3:
								{
									string text3;
									this.fieldDicForTopSetEditing[text3].Visibility = global::System.Windows.Visibility.Collapsed;
									num = (short)741801989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_4C8;
								case 6:
									num = (short)147193860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3FA:
								num = (short)747044864;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3A9:
								goto IL_3FA;
							}
							IL_4C8:
							goto IL_9C0;
						}
						finally
						{
							num = (short)1428619264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_500;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1277952002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_53A;
								}
								IL_500:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)70909953;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_53A:;
						}
						goto IL_53D;
						IL_9C0:
						global::System.Collections.Generic.IEnumerable<string> enumerable4 = this.fieldDicForTopSetEditing.Keys.Except(enumerable3);
						global::System.Collections.Generic.IEnumerator<string> enumerator3 = enumerable4.GetEnumerator();
						num = (short)217513989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)2067726336;
						short num4 = num;
						try
						{
							num = (short)1728184321;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<string> childFields2;
									if (childFields2.Count != 0)
									{
										num = (short)174391301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5C8;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator4;
									if (!enumerator4.MoveNext())
									{
										num = (short)1150615560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text4 = enumerator4.Current;
									global::System.Collections.Generic.List<string> childFields2 = this.currentSetCategoryForTopSetEditing.GetChildFields(text4, this.currentSetCategoryForTopSetEditing.Name);
									num = (short)1427636224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									string text4;
									this.fieldDicForTopSetEditing[text4].Visibility = global::System.Windows.Visibility.Collapsed;
									num = (short)664535047;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.List<string> childFields2;
									if (!childFields2.Except(enumerable).Any<string>())
									{
										num = (short)1429012483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)433717252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_6F4;
								case 8:
									num = (short)833421318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_66E:
								num = (short)722796546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5C8:
								goto IL_66E;
							}
							IL_6F4:
							goto IL_319;
						}
						finally
						{
							num = (short)775618560;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<string> enumerator4;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_72B;
									}
									continue;
								case 1:
									enumerator4.Dispose();
									num = (short)1446772738;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_763;
								}
								IL_72B:
								if (enumerator4 == null)
								{
									break;
								}
								num = (short)1226964993;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_763:;
						}
						goto IL_766;
					}
					case 11:
						goto IL_53D;
					}
					goto IL_5F;
					IL_319:
					num = (short)652083201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53D:
					enumerable3 = A_1.VisibleItems.Except(enumerable2);
					enumerable = enumerable2.Except(A_1.VisibleItems);
					enumerator = enumerable3.GetEnumerator();
					num = (short)2144862208;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_361:
				IL_766:
				this.visibleFieldListDict[this.currentSetCategoryForTopSetEditing] = A_1.VisibleItems;
				return;
				IL_9F9:
				this.visibleFieldListDict.Add(this.currentSetCategoryForTopSetEditing, A_1.VisibleItems);
				return;
				IL_5F:
				setCategory = (A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
				num = (short)1926955012;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0008AD20 File Offset: 0x00088F20
		private void a(global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::Infragistics.Windows.DataPresenter.Field> A_0)
		{
			short num = (short)1913221780;
			short num2 = num;
			num = (short)1321824916;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_23E;
			case 1:
				break;
			default:
			{
				num = (short)2097479680;
				short num3 = num;
				break;
			}
			}
			num = (short)1754726400;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::Infragistics.Windows.DataPresenter.Field>.KeyCollection.Enumerator enumerator = A_0.Keys.GetEnumerator())
			{
				num = (short)1875181570;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
						if (this.currentSetCategoryForTopSetEditing.IsFieldAllowDisplay(this.currentSetCategoryForTopSetEditing.Name, rmfieldEditor.Name))
						{
							num = (short)1410859017;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)858062854;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor = enumerator.Current;
						num = (short)1028915200;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_D2;
						}
						continue;
					case 3:
						goto IL_22E;
					case 4:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						this.fieldDicForTopSetEditing.Add(field.Name, field);
						num = (short)1699741704;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						if (!this.fieldDicForTopSetEditing.ContainsKey(field.Name))
						{
							num = (short)2024734724;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.fieldDicForTopSetEditing[field.Name] = field;
						num = (short)730529799;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)868352003;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
						global::Infragistics.Windows.DataPresenter.Field field = A_0[rmfieldEditor];
						num = (short)1368391685;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_121:
					num = (short)1357119489;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_D2:
					goto IL_121;
				}
				IL_22E:;
			}
			IL_23E:
			num = (short)400424961;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0008AFB0 File Offset: 0x000891B0
		public static bool GetIsExtendedForTopSetEditing(global::System.Windows.DependencyObject obj)
		{
			short num = (short)959447040;
			short num2 = num;
			num = (short)127164413;
			short num3 = num;
			num = (short)238051325;
			switch (num3 == num)
			{
			}
			num = (short)1681915905;
			if (num != 0)
			{
			}
			num = (short)1758265344;
			if (num != 0)
			{
			}
			return (bool)obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.IsExtendedForTopSetEditingProperty);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0008B068 File Offset: 0x00089268
		public static void SetIsExtendedForTopSetEditing(global::System.Windows.DependencyObject obj, bool value)
		{
			short num = (short)570032128;
			short num2 = num;
			num = (short)934268203;
			short num3 = num;
			num = (short)76074283;
			switch (num3 == num)
			{
			}
			num = (short)130285569;
			if (num != 0)
			{
			}
			num = (short)2096758784;
			if (num != 0)
			{
			}
			obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.IsExtendedForTopSetEditingProperty, value);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0008B120 File Offset: 0x00089320
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1686044672;
			short num2 = num;
			num = (short)447741953;
			if (num != 0)
			{
			}
			num = (short)836148488;
			short num3 = num;
			num = (short)511221000;
			switch (num3 == num)
			{
			}
			num = (short)742850560;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox rmcheckBox = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)A_0;
			rmcheckBox.PreviewMouseLeftButtonDown += global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.CheckBox_PreviewMouseLeftButtonDown;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0008B1E4 File Offset: 0x000893E4
		private static void CheckBox_PreviewMouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			short num;
			int num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.BoolField boolField;
			bool flag;
			for (;;)
			{
				IL_0A:
				num = (short)658440193;
				if (num != 0)
				{
				}
				bool flag2;
				switch (num2)
				{
				case 0:
				{
					num = (short)1287258112;
					short num3 = num;
					boolField.IsChecked = !boolField.IsChecked;
					A_1.Handled = true;
					num = (short)119930887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_132;
				case 2:
					if (boolField.IsEditable)
					{
						num = (short)272826378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)276496395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (boolField == null || !flag)
					{
						return;
					}
					num = (short)2040144955;
					short num4 = num;
					num = (short)1924408379;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E2;
					default:
						num = (short)2008612864;
						if (num != 0)
						{
						}
						num = (short)145817600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					flag = false;
					num = (short)1757151244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!boolField.IsApplicable)
					{
						num = (short)1110769668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)946733064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1175519234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return;
				case 8:
					if (boolField.IsMVODynamic)
					{
						num = (short)224395270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_132;
				case 9:
					flag2 = !boolField.UseMVODefault;
					goto IL_277;
				case 10:
					goto IL_1E2;
				case 11:
					flag2 = false;
					goto IL_277;
				case 12:
					goto IL_132;
				}
				goto IL_6D;
				IL_132:
				num = (short)410910723;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E2:
				num = (short)2020081673;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_277:
				flag = flag2;
				num = (short)1228865537;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_6D:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox rmcheckBox = (global::Motorola.CommonCPS.RadioManagement.Controls.RMCheckBox)A_0;
			boolField = (rmcheckBox.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.BoolField);
			flag = boolField.IsEditable;
			num = (short)837156869;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0008B488 File Offset: 0x00089688
		private static void d()
		{
			short num = (short)332267521;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F2;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor.CurrentFieldName);
					num = (short)1671102464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				if (string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor.CurrentFieldName))
				{
					break;
				}
				num = (short)872247939;
				short num3 = num;
				num = (short)874082947;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F4;
				default:
				{
					num = (short)1181417472;
					short num4 = num;
					num = (short)97517568;
					if (num != 0)
					{
					}
					num = (short)1503526914;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_F2:
			IL_F4:
			num = (short)1537474561;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0008B5B4 File Offset: 0x000897B4
		private static void a(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter A_0)
		{
			short num = (short)426639360;
			short num2 = num;
			num = (short)1217658881;
			if (num != 0)
			{
			}
			num = (short)1987760583;
			short num3 = num;
			num = (short)717476295;
			switch (num3 == num)
			{
			}
			num = (short)1375404032;
			if (num != 0)
			{
			}
			A_0.lnkClose.Visibility = (A_0.SetCategory.IsRoot ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0008B680 File Offset: 0x00089880
		public void ScrollTofieldEditor(string fieldEditorName)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c__DisplayClass253_0 CS$<>8__locals1;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_28B;
				case 1:
					if (this.SetCategory != null)
					{
						num2 = (short)1399390218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_1B6;
				case 3:
					if (!string.IsNullOrEmpty(CS$<>8__locals1.c))
					{
						num2 = (short)1557331968;
						short num3 = num2;
						num2 = (short)341377033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)763035649;
					if (num2 != 0)
					{
					}
					num2 = (short)1251803137;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)183697411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (CS$<>8__locals1.a != null)
					{
						num2 = (short)1360986116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					goto IL_1D3;
				case 8:
					if (!CS$<>8__locals1.a.IsLoaded)
					{
						num2 = (short)1845166080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.b(CS$<>8__locals1.c);
					num2 = (short)1907818498;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)1907628861;
					short num4 = num2;
					num2 = (short)1682578237;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D3;
					default:
						num2 = (short)1264386048;
						if (num2 != 0)
						{
						}
						num2 = (short)845742088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					num2 = (short)1288830983;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_1D3:
				if (this.SetCategory.ActiveSet == null)
				{
					break;
				}
				num2 = (short)574095365;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1B6:
			return;
			IL_28B:
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.d), new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.e), new global::System.Windows.RoutedEventHandler(CS$<>8__locals1.d));
			return;
			IL_3C:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c__DisplayClass253_0();
			CS$<>8__locals1.b = this;
			CS$<>8__locals1.c = fieldEditorName;
			CS$<>8__locals1.a = this.m();
			num2 = (short)524288006;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0008B920 File Offset: 0x00089B20
		private void b(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (rmsetEditor != null)
					{
						num2 = (short)539426819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EC;
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
					global::System.Windows.Controls.ItemsControl itemsControl;
					this.a(rmfieldEditor, itemsControl);
					num2 = (short)819986436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					IL_D0:
					global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
					if (rmfieldEditor != null)
					{
						num2 = (short)1151336449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EC;
				}
				case 3:
				{
					global::System.Windows.Controls.ItemsControl itemsControl = (global::System.Windows.Controls.ItemsControl)rmsetEditor.Content;
					global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.FindChildByName<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(itemsControl, A_0);
					num2 = (short)1488977922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_EC;
				}
				goto IL_24;
				IL_EC:
				num2 = (short)1146869805;
				short num3 = num2;
				num2 = (short)1950079021;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D0;
				default:
					goto IL_121;
				}
			}
			IL_121:
			num2 = (short)873005056;
			if (num2 != 0)
			{
			}
			num2 = (short)757268480;
			short num4 = num2;
			return;
			IL_24:
			num2 = (short)748421121;
			if (num2 != 0)
			{
			}
			rmsetEditor = this.m();
			num2 = (short)1462829056;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0008BA8C File Offset: 0x00089C8C
		private void a(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor A_0, bool A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c__DisplayClass256_0 CS$<>8__locals1;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					string text = this.a(this.SetCategory.ActiveSet);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.GlueIt(this.scwSetEditor, CS$<>8__locals1.a, text, this);
					this.a(text);
					this.k();
					this.a(true);
					num2 = (short)198180864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)199738439;
					short num3 = num2;
					num2 = (short)663340103;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
						goto IL_187;
					}
					break;
				}
				case 3:
					if (!A_1)
					{
						goto IL_5E;
					}
					CS$<>8__locals1.a.DataContext = this.SetCategory.ActiveSet;
					num2 = (short)738590725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					this.a(this.SetCategory);
					this.SetCategory.ActiveSetChanged += CS$<>8__locals1.c;
					num2 = (short)1221656583;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!this.b(this.SetCategory))
					{
						num2 = (short)656343044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_78;
				case 6:
					num2 = (short)1187053569;
					if (num2 != 0)
					{
					}
					if (CS$<>8__locals1.a.DataContext != null)
					{
						num2 = (short)1019805697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					goto IL_78;
				}
				goto IL_30;
				IL_5E:
				num2 = (short)2121072642;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_78:
				num2 = (short)1160904704;
				short num4 = num2;
				this.isUsingGlueWindowForscwSetEditorContent = true;
				num2 = (short)1603862534;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_187:
			num2 = (short)2123694080;
			if (num2 != 0)
			{
			}
			this.scwSetEditor.Content = CS$<>8__locals1.a;
			this.isUsingGlueWindowForscwSetEditorContent = false;
			return;
			IL_30:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.<>c__DisplayClass256_0();
			CS$<>8__locals1.a = A_0;
			CS$<>8__locals1.b = this;
			num2 = (short)12779523;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0008BCFC File Offset: 0x00089EFC
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory A_0)
		{
			short num;
			for (;;)
			{
				int hashCode = this.SetCategory.GetHashCode();
				if (this.SetCategory_ActiveSetChanged_RegisterCache.Contains(hashCode))
				{
					break;
				}
				num = (short)920305579;
				short num2 = num;
				num = (short)1907277739;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_52;
				}
			}
			return true;
			IL_52:
			num = (short)2013134848;
			short num3 = num;
			num = (short)828768257;
			if (num != 0)
			{
			}
			num = (short)1272381440;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0008BDC4 File Offset: 0x00089FC4
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int hashCode;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_83;
				case 1:
					IL_3C:
					if (!this.SetCategory_ActiveSetChanged_RegisterCache.Contains(hashCode))
					{
						num2 = (short)1971847170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_83;
				case 2:
					this.SetCategory_ActiveSetChanged_RegisterCache.Add(hashCode);
					num2 = (short)217972736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_83:
				num2 = (short)1394639294;
				short num3 = num2;
				num2 = (short)97288638;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3C;
				case 1:
					goto IL_E2;
				}
				break;
			}
			num2 = (short)1445920768;
			short num4 = num2;
			IL_E2:
			num2 = (short)1622474753;
			if (num2 != 0)
			{
			}
			num2 = (short)703070208;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			hashCode = this.SetCategory.GetHashCode();
			num2 = (short)976551937;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0008BEF0 File Offset: 0x0008A0F0
		private string a(global::Motorola.CommonCPS.RadioManagement.UIModels.Set A_0)
		{
			short num;
			while (A_0 != null)
			{
				num = (short)1490777166;
				short num2 = num;
				num = (short)1533441102;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)444923904;
					short num3 = num;
					break;
				}
				}
				num = (short)1666318336;
				if (num != 0)
				{
				}
				return A_0.GetHashCode().ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}
			num = (short)1155399681;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0008BFB8 File Offset: 0x0008A1B8
		private void a(string A_0)
		{
			short num = (short)1754857472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow attachedGlueWindowByKey;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator;
					global::System.Windows.Input.InputBindingCollection inputBindingCollection;
					switch (num2)
					{
					case 0:
						if (attachedGlueWindowByKey.IsFirstTimeToShow)
						{
							num = (short)2026307587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						num = (short)583008256;
						short num3 = num;
						try
						{
							num = (short)1782185984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_EC;
									}
									continue;
								case 1:
									goto IL_174;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2022113284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Input.InputBinding inputBinding = (global::System.Windows.Input.InputBinding)enumerator.Current;
									attachedGlueWindowByKey.InputBindings.Add(inputBinding);
									num = (short)56164354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)893386753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EE:
								num = (short)625934339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EC:
								goto IL_EE;
							}
							IL_174:
							goto IL_84;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_196;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_183:
								switch (num2)
								{
								case 0:
									goto IL_1ED;
								case 1:
									if (disposable != null)
									{
										num = (short)1274806274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1EF;
								case 2:
									disposable.Dispose();
									num = (short)293994496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_196;
							}
							IL_1ED:
							IL_1EF:
							goto EndFinally_16;
							IL_196:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1683619841;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_183;
							EndFinally_16:;
						}
						goto Block_3;
						IL_84:
						inputBindingCollection = this.b();
						global::System.Collections.IEnumerator enumerator2 = inputBindingCollection.GetEnumerator();
						num = (short)402325508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)410320897;
						if (num != 0)
						{
						}
						goto IL_1F0;
					case 3:
						goto IL_4B4;
					case 4:
						goto IL_375;
					}
					goto IL_42;
					IL_4B4:
					attachedGlueWindowByKey.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor.RelocateRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMLinkFieldEditor_RelocateRequested));
					attachedGlueWindowByKey.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor.RelocateRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMLinkFieldEditor_RelocateRequested));
					attachedGlueWindowByKey.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.SelectSetRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMListFieldEditor_SelectSetRequested));
					attachedGlueWindowByKey.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMListFieldEditor.SelectSetRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMListFieldEditor_SelectSetRequested));
					attachedGlueWindowByKey.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMRelocatableFieldEditor_RelocateRequested));
					attachedGlueWindowByKey.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMRelocatableFieldEditor_RelocateRequested));
					attachedGlueWindowByKey.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor.RelocateHelpWindowRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMLabelFieldEditor_RelocateHelpWindowRequested));
					attachedGlueWindowByKey.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLabelFieldEditor.RelocateHelpWindowRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMLabelFieldEditor_RelocateHelpWindowRequested));
					attachedGlueWindowByKey.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.RelocateHelpWindowRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMSetEditor_RelocateRequested));
					attachedGlueWindowByKey.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor.RelocateHelpWindowRequestedEvent, new global::System.Windows.RoutedEventHandler(this.RMSetEditor_RelocateRequested));
					global::System.Collections.IEnumerator enumerator3 = base.InputBindings.GetEnumerator();
					num = (short)1662058498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_375:
						num = (short)655360;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3AF;
								}
								continue;
							case 1:
								goto IL_437;
							case 2:
								num = (short)1033764865;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.IEnumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)996540418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.Input.InputBinding inputBinding2 = (global::System.Windows.Input.InputBinding)enumerator2.Current;
								attachedGlueWindowByKey.InputBindings.Add(inputBinding2);
								num = (short)97714179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_3E5:
							num = (short)467730436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3AF:
							goto IL_3E5;
						}
						IL_437:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_459;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_446:
							switch (num2)
							{
							case 0:
								goto IL_4B1;
							case 1:
								if (disposable != null)
								{
									num = (short)21757954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4B3;
							case 2:
								disposable.Dispose();
								num = (short)81920000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_459;
						}
						IL_4B1:
						IL_4B3:
						goto EndFinally_15;
						IL_459:
						global::System.Collections.IEnumerator enumerator2;
						disposable = (enumerator2 as global::System.IDisposable);
						num = (short)1127612417;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_446;
						EndFinally_15:;
					}
					goto IL_4B4;
					Block_3:
					try
					{
						IL_1F0:
						num = (short)350552064;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_22A;
								}
								continue;
							case 1:
								goto IL_2AD;
							case 2:
								num = (short)618397697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator3.MoveNext())
								{
									num = (short)1312161794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.Input.InputBinding inputBinding3 = (global::System.Windows.Input.InputBinding)enumerator3.Current;
								attachedGlueWindowByKey.InputBindings.Add(inputBinding3);
								num = (short)574357507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_25C:
							num = (short)771751940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_22A:
							goto IL_25C;
						}
						IL_2AD:
						goto IL_5EC;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2CF;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2BC:
							switch (num2)
							{
							case 0:
								goto IL_328;
							case 1:
								IL_2ED:
								if (disposable != null)
								{
									num = (short)1555300354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_328;
							case 2:
								disposable.Dispose();
								num = (short)903610368;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CF;
							IL_328:
							num = (short)1014963919;
							short num4 = num;
							num = (short)468983503;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2ED;
							default:
								goto IL_35E;
							}
						}
						IL_35E:
						num = (short)821428224;
						if (num != 0)
						{
						}
						goto EndFinally_14;
						IL_2CF:
						disposable = (enumerator3 as global::System.IDisposable);
						num = (short)492896257;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2BC;
						EndFinally_14:;
					}
					goto Block_4;
					IL_5EC:
					inputBindingCollection = this.c();
					enumerator = inputBindingCollection.GetEnumerator();
					num = (short)1758527489;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				attachedGlueWindowByKey = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.GetAttachedGlueWindowByKey(A_0);
				num = (short)409272320;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0008C630 File Offset: 0x0008A830
		private global::System.Windows.Input.InputBindingCollection c()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Input.InputBindingCollection result;
			global::System.Windows.Controls.UserControl userControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (userControl != null)
					{
						num2 = (short)1746337794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					for (;;)
					{
						result = userControl.InputBindings;
						num2 = (short)1462281835;
						short num3 = num2;
						num2 = (short)847292011;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_95;
						}
					}
					IL_95:
					num2 = (short)311099392;
					short num4 = num2;
					num2 = (short)767557633;
					if (num2 != 0)
					{
					}
					num2 = (short)1128005632;
					if (num2 != 0)
					{
					}
					num2 = (short)358023168;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = new global::System.Windows.Input.InputBindingCollection();
			userControl = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.c<global::System.Windows.Controls.UserControl>(this);
			num2 = (short)1758330881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0008C754 File Offset: 0x0008A954
		private global::System.Windows.Input.InputBindingCollection b()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::System.Windows.UIElement uielement;
			global::System.Windows.Input.InputBindingCollection result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						result = uielement.InputBindings;
						num2 = (short)1586175289;
						short num3 = num2;
						num2 = (short)2058427705;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_107;
						}
						goto Block_2;
					}
					IL_107:
					num2 = (short)1568342016;
					if (num2 != 0)
					{
					}
					num2 = (short)461897730;
					num = (int)((global::System.IntPtr)num2);
					continue;
					Block_2:
					num2 = (short)143589376;
					short num4 = num2;
					goto IL_107;
				}
				case 1:
					num2 = (short)969146369;
					if (num2 != 0)
					{
					}
					if (uielement != null)
					{
						num2 = (short)685703168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				}
				goto IL_25;
			}
			return result;
			IL_25:
			result = new global::System.Windows.Input.InputBindingCollection();
			uielement = (global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(this, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햗튟춡좣장蚧쎫쎭\uddaf\uddb1\udab3銻ꆿꛁ귃꧅藇ꯉꋋ꿍럏럑맓돕뛗껙鷝迟郡臣죥뫧诩裫蟭鿯뿱闳飵駷鷹駻鏽旿氁瀃䔅朇搉砋簍缏縑", a_)) as global::System.Windows.UIElement);
			num2 = (short)1005780993;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0008C89C File Offset: 0x0008AA9C
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor LoadSetEditor()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor setEditor;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_129;
				case 1:
				{
					num2 = (short)54359918;
					short num3 = num2;
					num2 = (short)822441838;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
					{
						num2 = (short)1425080320;
						if (num2 != 0)
						{
						}
						setEditor.IsEnabled = false;
						num2 = (short)13565952;
						short num4 = num2;
						num2 = (short)697106435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (this.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Picking)
					{
						num2 = (short)1635516417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					setEditor.Loaded -= this.setEditor_Loaded;
					setEditor.SizeChanged -= this.setEditor_SizeChanged;
					setEditor.Loaded += this.setEditor_Loaded;
					setEditor.SizeChanged += this.setEditor_SizeChanged;
					goto IL_110;
				case 3:
					goto IL_175;
				}
				goto IL_20;
				IL_110:
				num2 = (short)1440088064;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_129:
			return setEditor;
			IL_175:
			num2 = (short)143982593;
			if (num2 != 0)
			{
			}
			return setEditor;
			IL_20:
			setEditor = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.GetSetEditor(this.SetCategory.Name, this.SetCategory.TelePortMode, true);
			this.a(setEditor, this.UseGlueWindow);
			num2 = (short)351666178;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0008CA4C File Offset: 0x0008AC4C
		public void ShowFields()
		{
			int a_ = 17;
			short num = (short)2068840466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor rmsetEditor;
				switch (num2)
				{
				case 0:
					if (rmsetEditor != null)
					{
						num = (short)1319501830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6;
				case 1:
					goto IL_A6;
				case 2:
					goto IL_413;
				case 3:
					this.k();
					this.a(true);
					num = (short)1747255309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (rmsetEditor.IsLoaded)
					{
						num = (short)621740035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_335;
				case 5:
					this.codList.Width = global::System.Windows.GridLength.Auto;
					this.gridSets.Visibility = global::System.Windows.Visibility.Collapsed;
					this.dgrZonelist.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)467271696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)279049649;
					short num3 = num;
					num = (short)1786115505;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26B;
					default:
						num = (short)1764753408;
						if (num != 0)
						{
						}
						num = (short)418447369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_3CF;
				case 8:
					num = (short)2054750209;
					if (num != 0)
					{
					}
					if (this.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Editing)
					{
						num = (short)159645701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.codList.Width = new global::System.Windows.GridLength(250.0);
					this.grdSplitter.Visibility = global::System.Windows.Visibility.Visible;
					this.ctmSets.Visibility = global::System.Windows.Visibility.Hidden;
					num = (short)1704787970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (rmsetEditor.GetType().ToString().EndsWith(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螨", a_) + this.SetCategory.Name, global::System.StringComparison.Ordinal))
					{
						num = (short)858718223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6;
				case 10:
					if (this.SetCategory.ActiveSet != null)
					{
						num = (short)834928652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					return;
				case 12:
				{
					num = (short)1207042048;
					short num4 = num;
					this.SetCategory.ActiveSet.PropertyChanged -= this.ActiveSet_PropertyChanged;
					this.SetCategory.ActiveSet.PropertyChanged += this.ActiveSet_PropertyChanged;
					num = (short)1138098193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_335;
				case 14:
					goto IL_26B;
				case 15:
					num = (short)1396113422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_413;
				case 17:
					return;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					continue;
				case 19:
					try
					{
						num = (short)409600003;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (this.SetCategory.ActiveSet.Fields == null)
								{
									num = (short)956104705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_509;
							case 1:
								goto IL_4EE;
							case 2:
								num = (short)1536688128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_48C;
								}
								continue;
							case 4:
								goto IL_520;
							}
							IL_48C:
							if (this.SetCategory.ActiveSet != null)
							{
								num = (short)1757937666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_509:
							num = (short)725221380;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4EE:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_LoadSet_Error, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾨쪪쒬쎮풰ힲ閴\udbb6횸\udaba\ud9bc龾뗀ꯂꃄ뫈껊만럐뫒냔믖뷘꣚", a_));
						IL_520:;
					}
					catch
					{
						this.scwSetEditor.Content = null;
						this.ictAnchors.ItemsSource = null;
						throw;
					}
					rmsetEditor = this.m();
					num = (short)2014642176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7D:
				if (this.SetCategory.SetsReadOnly)
				{
					num = (short)261685259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)168951816;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A6:
				rmsetEditor = this.LoadSetEditor();
				num = (short)1288503303;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26B:
				if (this.isUsingGlueWindowForscwSetEditorContent)
				{
					num = (short)1535377409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3CF;
				IL_335:
				this.SetCategory.PropertyChanged -= this.SetCategory_PropertyChanged;
				this.SetCategory.PropertyChanged += this.SetCategory_PropertyChanged;
				num = (short)1955528714;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CF:
				this.a();
				num = (short)588644356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_413:
				this.codEditor.Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
				this.grdBorder.Visibility = global::System.Windows.Visibility.Visible;
				num = (short)1470300179;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0008CFE8 File Offset: 0x0008B1E8
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_80;
			}
			int num;
			short num2;
			global::System.Windows.Controls.ScrollViewer scrollViewer;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)2027421712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (((global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)this.lastSetOfIsExpandEmbeddedSet.Parent).ParentSet.Equals(this.SetCategory.ActiveSet))
					{
						num2 = (short)447414286;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32B;
				case 2:
					if (scrollViewer != null)
					{
						num2 = (short)1072693274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_4D1;
				case 4:
				{
					this.lastSetOfIsExpandEmbeddedSet = null;
					num2 = (short)348380313;
					short num3 = num2;
					num2 = (short)967433369;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DA;
					default:
						num2 = (short)1855848448;
						if (num2 != 0)
						{
						}
						num2 = (short)1406468099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					num2 = (short)1439170561;
					if (num2 != 0)
					{
					}
					num2 = (short)489160705;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!this.SetCategory.IsExpandEmbeddedSet)
					{
						num2 = (short)290521099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32B;
				case 7:
					if (this.lastSetOfIsExpandEmbeddedSet != null)
					{
						num2 = (short)1707212815;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32B;
				case 8:
					num2 = (short)1025572886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.lastSetOfIsExpandEmbeddedSet.Parent is global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)
					{
						num2 = (short)190709772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32B;
				case 10:
					num2 = (short)1390084123;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)290193415;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)624885779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					scrollViewer.ScrollToTop();
					num2 = (short)646250514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					flag = true;
					this.lastSetOfIsExpandEmbeddedSet = null;
					num2 = (short)653131800;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1956642825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (((global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)this.lastSetOfIsExpandEmbeddedSet.Parent).ParentSet != null)
					{
						num2 = (short)1359478794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4D1;
				case 17:
				{
					num2 = (short)1258815488;
					short num4 = num2;
					this.lastSetOfIsExpandEmbeddedSet = this.SetCategory.ActiveSet;
					num2 = (short)455213077;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					return;
				case 19:
					if (((global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)this.lastSetOfIsExpandEmbeddedSet.Parent).ParentSet != null)
					{
						num2 = (short)43581445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32B;
				case 20:
					if (this.SetCategory.IsExpandEmbeddedSet)
					{
						num2 = (short)921042961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1187250199;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					goto IL_4D1;
				case 22:
					if (this.lastSetOfIsExpandEmbeddedSet.Parent is global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)
					{
						num2 = (short)1825832960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4D1;
				case 23:
					if (this.lastSetOfIsExpandEmbeddedSet != null)
					{
						num2 = (short)261685256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4D1;
				case 24:
					goto IL_1DA;
				case 25:
					if (!flag)
					{
						num2 = (short)1662124045;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 26:
					num2 = (short)134152212;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (!((global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)this.lastSetOfIsExpandEmbeddedSet.Parent).ParentSet.Equals(this.SetCategory.ActiveSet))
					{
						num2 = (short)81199108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4D1;
				}
				goto IL_80;
				IL_32B:
				num2 = (short)141492249;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DA:
				goto IL_32B;
				IL_4D1:
				flag = false;
				num2 = (short)857538566;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_80:
			scrollViewer = this.l();
			num2 = (short)1453326338;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0008D50C File Offset: 0x0008B70C
		private void SetCategory_PropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)169541635;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1010565120;
					short num3 = num;
					if (this.SetCategory.ActiveSet != null)
					{
						num = (short)1143734276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					num = (short)564723713;
					if (num != 0)
					{
					}
					num = (short)682426369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 4:
				{
					num = (short)182834553;
					short num4 = num;
					num = (short)762959225;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)208601088;
						if (num != 0)
						{
						}
						this.a(true);
						this.SetCategory.ActiveSet.PropertyChanged -= this.ActiveSet_PropertyChanged;
						this.SetCategory.ActiveSet.PropertyChanged += this.ActiveSet_PropertyChanged;
						num = (short)1104805888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_42:
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udc9cﲞ햠쪢펤슦直캪\ud9ac", a_)))
				{
					break;
				}
				num = (short)448724994;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0008D6CC File Offset: 0x0008B8CC
		private void ActiveSet_PropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 9;
			short num = (short)1946943489;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1214251008;
					short num3 = num;
					this.a(true);
					num = (short)459289058;
					short num4 = num;
					num = (short)1117139426;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1051000832;
						if (num != 0)
						{
						}
						num = (short)31653889;
						if (num != 0)
						{
						}
						num = (short)180289538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					return;
				}
				IL_39:
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삢톤캦\udfa8캪욮풰\udfb2톴禮\ud8b8횺\ud8bc", a_)))
				{
					break;
				}
				num = (short)1612578816;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0008D804 File Offset: 0x0008BA04
		private void UserControl_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 0;
			short num = (short)715980800;
			short num2 = num;
			num = (short)1561133060;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.dgrSets.FieldSettings.CellClickAction = global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord;
					num = (short)1505492997;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!this.UseGlueWindow)
					{
						num = (short)2050031618;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)49868350;
					short num4 = num;
					num = (short)1932324414;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2091909120;
						if (num != 0)
						{
						}
						num = (short)589758465;
						if (num != 0)
						{
						}
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
						binding.Source = this;
						binding.Path = new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮗ﾙ\udd9d솟횡솣솥잧\ud8a9햫肭톱삳\udfb5캷\udfb9\udbbd뒿", a_), global::System.Array.Empty<object>());
						this.scwSetEditor.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding);
						num = (short)1782710275;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 5:
					goto IL_117;
				}
				IL_6E:
				if (this.WorkMode == global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Picking)
				{
					num = (short)958070784;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_117:
				num = (short)324403201;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0008D9E4 File Offset: 0x0008BBE4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 3;
			short num;
			if (this._contentLoaded)
			{
				for (;;)
				{
					num = (short)1467875328;
					short num2 = num;
					num = (short)347567823;
					short num3 = num;
					num = (short)224622287;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				IL_71:
				num = (short)736821248;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)135921665;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("뒚킜햠첢힤좦얨쪪莬\udeb0\udeb2\ud8b4\ud8b6ힸ釂꓄ꏆꃈ꓊背껎뿐닒닔닖듘뻚돜ꯞ쿠ꃢ諤触鷨駪苬菮苰죲雴飶铸诺鋼釾搀洂焄⠆簈砊栌紎爐簒笔挖欘琚焜氞ภ儢䠤否䰨弪崬崮吰䀲倴夶䴸帺似ᄾ㥀≂⡄⭆", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0008DAC4 File Offset: 0x0008BCC4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)974213233;
			short num2 = num;
			num = (short)2145144945;
			switch (num2 == num)
			{
			}
			num = (short)1339359232;
			short num3 = num;
			num = (short)353501185;
			if (num != 0)
			{
			}
			num = (short)625082368;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0008DB74 File Offset: 0x0008BD74
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2130378754;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1913520129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_235;
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
					goto IL_326;
				case 2:
					goto IL_3A3;
				case 3:
					goto IL_396;
				case 4:
					goto IL_129;
				case 5:
					goto IL_2E3;
				case 6:
					goto IL_247;
				case 7:
					goto IL_23A;
				case 8:
					goto IL_10F;
				case 9:
					goto IL_174;
				case 10:
					goto IL_2AF;
				case 11:
					goto IL_254;
				case 12:
					goto IL_2C9;
				case 13:
					goto IL_2A2;
				case 14:
					goto IL_2D6;
				case 15:
					goto IL_288;
				case 16:
					goto IL_211;
				case 17:
					goto IL_27B;
				case 18:
					goto IL_3BD;
				case 19:
					goto IL_34B;
				case 20:
					goto IL_365;
				case 21:
					goto IL_33E;
				case 22:
					goto IL_102;
				case 23:
					goto IL_150;
				case 24:
					goto IL_319;
				case 25:
					goto IL_295;
				case 26:
					goto IL_3CA;
				case 27:
					goto IL_136;
				case 28:
					goto IL_F5;
				case 29:
					goto IL_3E4;
				case 30:
					goto IL_3D7;
				case 31:
					goto IL_26E;
				case 32:
					goto IL_2BC;
				case 33:
					goto IL_11C;
				case 34:
					goto IL_358;
				case 35:
					goto IL_181;
				case 36:
					goto IL_261;
				case 37:
					goto IL_143;
				case 38:
					goto IL_372;
				case 39:
					goto IL_3B0;
				case 40:
					goto IL_1DC;
				default:
					num = (short)240517120;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F5:
			this.mniFillDown = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_102:
			this.dgrSets = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_10F:
			this.ctmExtended = (global::System.Windows.Controls.ContextMenu)target;
			return;
			IL_11C:
			this.grdBorder = (global::System.Windows.Controls.Border)target;
			return;
			IL_129:
			this.gridSets = (global::System.Windows.Controls.Grid)target;
			return;
			IL_136:
			this.mniAddCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_143:
			this.lnkDiscard = (global::System.Windows.Controls.Button)target;
			return;
			IL_150:
			this.ctmSets = (global::System.Windows.Controls.ContextMenu)target;
			this.ctmSets.Opened += this.ctmSets_Opened;
			return;
			IL_174:
			this.mniAddSet = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_181:
			num = (short)1717301978;
			short num3 = num;
			num = (short)1336865498;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_319:
				this.mniEdit = (global::System.Windows.Controls.MenuItem)target;
				return;
			default:
				num = (short)1248198656;
				if (num != 0)
				{
				}
				this.lnkSave = (global::System.Windows.Controls.Button)target;
				return;
			}
			IL_1DC:
			num = (short)474021889;
			if (num != 0)
			{
			}
			this.scwSetEditor = (global::System.Windows.Controls.ScrollViewer)target;
			return;
			IL_211:
			this.btnDelete = (global::System.Windows.Controls.Button)target;
			return;
			IL_235:
			this._contentLoaded = true;
			return;
			IL_23A:
			this.btnAdditional = (global::System.Windows.Controls.Button)target;
			return;
			IL_247:
			this.btnAdd = (global::System.Windows.Controls.Button)target;
			return;
			IL_254:
			this.mniCopySet1 = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_261:
			this.lnkSaveAs = (global::System.Windows.Controls.Button)target;
			return;
			IL_26E:
			this.dgrZonelist = (global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1)target;
			return;
			IL_27B:
			this.btnUp = (global::System.Windows.Controls.Button)target;
			return;
			IL_288:
			this.btnEdit = (global::System.Windows.Controls.Button)target;
			return;
			IL_295:
			this.mniDelete = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2A2:
			this.mniImport = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2AF:
			this.mniAddMultipleSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2BC:
			this.grdSplitter = (global::System.Windows.Controls.GridSplitter)target;
			return;
			IL_2C9:
			this.mniAddSetCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2D6:
			this.mniExport = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2E3:
			num = (short)1517813760;
			short num4 = num;
			this.gridToolBar = (global::System.Windows.Controls.Grid)target;
			return;
			IL_326:
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)target).Loaded += this.UserControl_Loaded;
			return;
			IL_33E:
			this.lnkDiscardTopSet = (global::System.Windows.Controls.Button)target;
			return;
			IL_34B:
			this.panelSaveDiscardTopsets = (global::System.Windows.Controls.WrapPanel)target;
			return;
			IL_358:
			this.grdEditor = (global::System.Windows.Controls.Grid)target;
			return;
			IL_365:
			this.lnkSaveTopSets = (global::System.Windows.Controls.Button)target;
			return;
			IL_372:
			this.lnkClose = (global::System.Windows.Controls.Button)target;
			this.lnkClose.Click += this.lkbHideDetails_Click;
			return;
			IL_396:
			this.codEditor = (global::System.Windows.Controls.ColumnDefinition)target;
			return;
			IL_3A3:
			this.codList = (global::System.Windows.Controls.ColumnDefinition)target;
			return;
			IL_3B0:
			this.ictAnchors = (global::System.Windows.Controls.ItemsControl)target;
			return;
			IL_3BD:
			this.btnDown = (global::System.Windows.Controls.Button)target;
			return;
			IL_3CA:
			this.mniCopySet = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_3D7:
			this.mniShowRelatedConfigurations = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_3E4:
			this.mniShowRelatedSets = (global::System.Windows.Controls.MenuItem)target;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0008DF7C File Offset: 0x0008C17C
		// Note: this type is marked as 'beforefieldinit'.
		static RMSetPresenter()
		{
			int a_ = 4;
			short num = (short)11822123;
			short num2 = num;
			num = (short)1153917995;
			switch (num2 == num)
			{
			}
			num = (short)1581645824;
			short num3 = num;
			num = (short)1966473216;
			if (num != 0)
			{
			}
			num = (short)1063321601;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.IsShowingFieldsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햛쪡쮣톥솧쒩쮫\ud9afힱ\ud8b3튵쮷", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.c)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectedSetsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ첟잡잣튥춧캩ﾫ쮭쒯솱", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.PropertyMetadata(new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>()));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.UseGlueWindowProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즛얟좣펥춧ﶩ얫삭풯\uddb1쎳", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.PropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SetCategoryProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ풟얣튥춧충쎫\udcad즯", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FlatSetConverterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b솟횡쎥\udca7쎫삭욯ힱ욳습\uddb7좹", a_), typeof(global::System.Windows.Data.IValueConverter), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.WorkModeProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮛튟즡즥첧쾩", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Motorola.CommonCPS.RadioManagement.Controls.SetPresenterWorkMode.Editing));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddButtonToolTipProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9b瞧쒟톣튥\udca7얩슫節\udfaf\uddb1\ud8b3톷쪹", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ToolTip_Grid_Add));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddEmbeddedSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9b瞧쒟즣쒥춧캩좫쮭풯톳습﮷햹톻펽ꆿ곁ꃃ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddMultipleSetsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9b瞧쒟톣쪥\udca7쎩\udcab슭햯톳습쮷惡펻펽궿ꏁ꫃ꋅ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportEmbeddedSetFromXMLCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧솫\udead\udfaf삱삳햷\ud8b9\ud9bb\udabd꒿ꟁꃃ闅귇뻉請볍뿏뿑賓鯕铗駙돛돝跟菡諣若", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportEmbeddedSetFromAPKCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧솫\udead\udfaf삱삳햷\ud8b9\ud9bb\udabd꒿ꟁꃃ闅귇뻉請볍뿏뿑闓蛕鏗駙돛돝跟菡諣若", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9b瞧쒟솣튥얩솫쎭톯\udcb1킳", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.AddSetAndEditCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udd9b瞧쒟솣튥쒩좫풯\udbb1삳ힷힹ톻\udfbd꺿ꛁ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SaveSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﾝ횟잡쎥\udca7쎫쎭\uddaf펱\udab3튵", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SaveSetAsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﾝ횟잡쎥\udca7\udfab\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DiscardChangesCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud89b펟송얣풥첧쒫쾭\udeaf햱톳억﮷햹톻펽ꆿ곁ꃃ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteEmbeddedSetsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud89bﮝ첟잡킣쎥잩캫쮭풯횱톳튵\udfb9좻춽莿귁꧃ꯅ꧇꓉꣋", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteEmbeddedSetsForListBoxCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud89bﮝ첟잡킣쎥잩캫쮭풯횱톳튵\udfb9좻춽蚿귁뛃諅ꇇ막룋賍뿏꫑韓맕뗗럙뷛냝蓟", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.DeleteSetsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud89bﮝ첟잡킣쎥ﮧ쾩\ud8ab\uddad\uddb1\ud9b3\udbb5\ud9b7풹\ud8bb", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditEmbeddedSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud99b瞧즟횡쮥쪧쾩좫쪭햯횱펵첷惡펻펽궿ꏁ꫃ꋅ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.GridSearchCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udb9b즟욡쎥즧\ud8a9쾫욭\uddb1\ud9b3\udbb5\ud9b7풹\ud8bb", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud99b瞧즟횡쎥\udca7쎫쎭\uddaf펱\udab3튵", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditSetColumnCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud99b瞧즟횡쎥\udca7쎫슭얯\udfb1\udab3ힷힹ톻\udfbd꺿ꛁ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FillDownCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b첟캡즥\udfa7쒩솭\uddaf\udfb1햳\ud8b5\udcb7", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.HideFieldsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풛쒟잡쾥춧용좫\uddad\uddb1\ud9b3\udbb5\ud9b7풹\ud8bb", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveSetDownCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톛횟잡쎥\udca7쎫\ud9ad\udeaf\udbb3\udbb5햷\udbb9튻\udabd", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveEmbeddedSetDownCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톛횟잡쮥쪧쾩좫쪭햯횱펵첷ﺹ펻즽꺿臁ꯃꯅꗇꯉꋋ꫍", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveSetUpCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톛횟잡쎥\udca7ﾩ\udcab\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.MoveEmbeddedSetUpCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톛횟잡쮥쪧쾩좫쪭햯횱펵첷첻ﶽ꾿꿁꧃Ʂꛇ껉", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.GridToFileEmbeddedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udb9b즟욡즥쎩삫쮭\udfb1횳펵\udcb7\udeb9\ud9bb\udabd莿귁꧃ꯅ꧇꓉꣋", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Controls.SetsImportExport.SetExportArgs>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FileToGridEmbeddedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b첟잡즥\ud8a9얫쪭\udfb1횳펵\udcb7\udeb9\ud9bb\udabd莿귁꧃ꯅ꧇꓉꣋", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Controls.SetsImportExport.SetImportArgs>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareCopyAndAssginCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧쎫\udead즯\udab3튵醴즹쾻\ud9bdꦿ곁蟃꧅ꗇꟉ귋ꃍ듏", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareAddSetCopiesCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧좫쪭ힱ삳ힷ쪹햻\udbbd뎿臁ꯃꯅꗇꯉꋋ꫍", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareImportSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧솫\udead\udfaf삱삳\uddb7캹ﾻ톽궿꿁ꗃꣅ곇", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareExportSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧풫\udead\udfaf삱삳\uddb7캹ﾻ톽궿꿁ꗃꣅ곇", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareCopyEmbeddedSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧쎫\udead즯\ud9b3풵\uddb7\udeb9\ud8bb\udbbd꒿釁ꇃ닅诇ꗉꇋꏍ뇏병냓", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowRelatedSetsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧囹쒫솭잯톳\udab5\ud9b7캹\ud9bb\udabd鎿ꟁ냃뗅诇ꗉꇋꏍ뇏병냓", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowEmbeddedSetRelatedConfigurationsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧囹쒫솭잯\ud9b3풵\uddb7\udeb9\ud8bb\udbbd꒿釁ꇃ닅髇꿉ꃋ꿍꓏럑냓闕럗듙뫛럝蟟韡難蟥鳧菩菫胭華뇱鯳鯵闷鯹鋻髽", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowEmbeddedSetRelatedSetsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧囹쒫솭잯\ud9b3풵\uddb7\udeb9\ud8bb\udbbd꒿釁ꇃ닅髇꿉ꃋ꿍꓏럑냓藕뷗껙꿛鷝迟迡解蟥蛧軩", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.PrepareShowRelatedConfigurationsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첛얟튡얣풥춧囹쒫솭잯톳\udab5\ud9b7캹\ud9bb\udabd莿귁꫃ꃅꇇ귉맋볍뇏ꛑ뷓맕뛗꧙鿛뇝跟迡藣裥賧", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.ShowFieldsCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛쾟햡쾥춧용좫\uddad\uddb1\ud9b3\udbb5\ud9b7풹\ud8bb", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.ShowFieldHelpCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛쾟햡쾥춧용좫햯\udeb1쒳ힷힹ톻\udfbd꺿ꛁ", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.RecalculateEmbeddedSetCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캛ﮝ쎟쎡좣얥\udda7용춫\udaad햯\ud9b3풵\uddb7\udeb9\ud8bb\udbbd꒿釁ꇃ닅诇ꗉꇋꏍ뇏병냓", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.EditorClosingEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud99b瞧즟횡쮣풥용쎫\uddad\ud9af\udcb1펳", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorClosingRoutedEventArgs), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.SelectSetRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ첟잡잣튥ﮧ쾩\ud8abﲭ햯쎱솳펵쮷캹\ud9bb\udabd", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.FillDownSourceFieldsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b첟캡즥\udfa7쒩ﾫ솭얯삱ힳ펵ﺷ펹\ud9bb튽꒿뇁", a_), typeof(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.IsExtendedForTopSetEditingProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햛\udaa1킣쎥욧캩즫쪭\uddb1욳ힷ쪹\udbbd뒿蟁ꃃ꿅볇ꏉꋋ꧍", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter.a)));
		}

		// Token: 0x04000399 RID: 921
		public static readonly global::System.Windows.DependencyProperty IsShowingFieldsProperty;

		// Token: 0x0400039A RID: 922
		public static readonly global::System.Windows.DependencyProperty SelectedSetsProperty;

		// Token: 0x0400039B RID: 923
		public static readonly global::System.Windows.DependencyProperty UseGlueWindowProperty;

		// Token: 0x0400039C RID: 924
		public static readonly global::System.Windows.DependencyProperty SetCategoryProperty;

		// Token: 0x0400039D RID: 925
		public static readonly global::System.Windows.DependencyProperty FlatSetConverterProperty;

		// Token: 0x0400039E RID: 926
		public static readonly global::System.Windows.DependencyProperty WorkModeProperty;

		// Token: 0x0400039F RID: 927
		public static readonly global::System.Windows.DependencyProperty AddButtonToolTipProperty;

		// Token: 0x040003A0 RID: 928
		public static readonly global::System.Windows.DependencyProperty AddEmbeddedSetCommandProperty;

		// Token: 0x040003A1 RID: 929
		public static readonly global::System.Windows.DependencyProperty AddMultipleSetsCommandProperty;

		// Token: 0x040003A2 RID: 930
		public static readonly global::System.Windows.DependencyProperty PrepareImportEmbeddedSetFromXMLCommandProperty;

		// Token: 0x040003A3 RID: 931
		public static readonly global::System.Windows.DependencyProperty PrepareImportEmbeddedSetFromAPKCommandProperty;

		// Token: 0x040003A4 RID: 932
		public static readonly global::System.Windows.DependencyProperty AddSetCommandProperty;

		// Token: 0x040003A5 RID: 933
		public static readonly global::System.Windows.DependencyProperty AddSetAndEditCommandProperty;

		// Token: 0x040003A6 RID: 934
		public static readonly global::System.Windows.DependencyProperty SaveSetCommandProperty;

		// Token: 0x040003A7 RID: 935
		public static readonly global::System.Windows.DependencyProperty SaveSetAsCommandProperty;

		// Token: 0x040003A8 RID: 936
		public static readonly global::System.Windows.DependencyProperty DiscardChangesCommandProperty;

		// Token: 0x040003A9 RID: 937
		public static readonly global::System.Windows.DependencyProperty DeleteEmbeddedSetsCommandProperty;

		// Token: 0x040003AA RID: 938
		public static readonly global::System.Windows.DependencyProperty DeleteEmbeddedSetsForListBoxCommandProperty;

		// Token: 0x040003AB RID: 939
		public static readonly global::System.Windows.DependencyProperty DeleteSetsCommandProperty;

		// Token: 0x040003AC RID: 940
		public static readonly global::System.Windows.DependencyProperty EditEmbeddedSetCommandProperty;

		// Token: 0x040003AD RID: 941
		public static readonly global::System.Windows.DependencyProperty GridSearchCommandProperty;

		// Token: 0x040003AE RID: 942
		public static readonly global::System.Windows.DependencyProperty EditSetCommandProperty;

		// Token: 0x040003AF RID: 943
		public static readonly global::System.Windows.DependencyProperty EditSetColumnCommandProperty;

		// Token: 0x040003B0 RID: 944
		public static readonly global::System.Windows.DependencyProperty FillDownCommandProperty;

		// Token: 0x040003B1 RID: 945
		public static readonly global::System.Windows.DependencyProperty HideFieldsCommandProperty;

		// Token: 0x040003B2 RID: 946
		public static readonly global::System.Windows.DependencyProperty MoveSetDownCommandProperty;

		// Token: 0x040003B3 RID: 947
		public static readonly global::System.Windows.DependencyProperty MoveEmbeddedSetDownCommandProperty;

		// Token: 0x040003B4 RID: 948
		public static readonly global::System.Windows.DependencyProperty MoveSetUpCommandProperty;

		// Token: 0x040003B5 RID: 949
		public static readonly global::System.Windows.DependencyProperty MoveEmbeddedSetUpCommandProperty;

		// Token: 0x040003B6 RID: 950
		public static readonly global::System.Windows.DependencyProperty GridToFileEmbeddedCommandProperty;

		// Token: 0x040003B7 RID: 951
		public static readonly global::System.Windows.DependencyProperty FileToGridEmbeddedCommandProperty;

		// Token: 0x040003B8 RID: 952
		public static readonly global::System.Windows.DependencyProperty PrepareCopyAndAssginCommandProperty;

		// Token: 0x040003B9 RID: 953
		public static readonly global::System.Windows.DependencyProperty PrepareAddSetCopiesCommandProperty;

		// Token: 0x040003BA RID: 954
		public static readonly global::System.Windows.DependencyProperty PrepareImportSetCommandProperty;

		// Token: 0x040003BB RID: 955
		public static readonly global::System.Windows.DependencyProperty PrepareExportSetCommandProperty;

		// Token: 0x040003BC RID: 956
		public static readonly global::System.Windows.DependencyProperty PrepareCopyEmbeddedSetCommandProperty;

		// Token: 0x040003BD RID: 957
		public static readonly global::System.Windows.DependencyProperty PrepareShowRelatedSetsCommandProperty;

		// Token: 0x040003BE RID: 958
		public static readonly global::System.Windows.DependencyProperty PrepareShowEmbeddedSetRelatedConfigurationsCommandProperty;

		// Token: 0x040003BF RID: 959
		public static readonly global::System.Windows.DependencyProperty PrepareShowEmbeddedSetRelatedSetsCommandProperty;

		// Token: 0x040003C0 RID: 960
		public static readonly global::System.Windows.DependencyProperty PrepareShowRelatedConfigurationsCommandProperty;

		// Token: 0x040003C1 RID: 961
		public static readonly global::System.Windows.DependencyProperty ShowFieldsCommandProperty;

		// Token: 0x040003C2 RID: 962
		public static readonly global::System.Windows.DependencyProperty ShowFieldHelpCommandProperty;

		// Token: 0x040003C3 RID: 963
		public static readonly global::System.Windows.DependencyProperty RecalculateEmbeddedSetCommandProperty;

		// Token: 0x040003C7 RID: 967
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory currentSetCategoryForTopSetEditing;

		// Token: 0x040003C8 RID: 968
		public static readonly global::System.Windows.DependencyProperty FillDownSourceFieldsProperty;

		// Token: 0x040003C9 RID: 969
		private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> fieldDicForTopSetEditing = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x040003CA RID: 970
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.IEnumerable<string>> visibleFieldListDict = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.IEnumerable<string>>();

		// Token: 0x040003CB RID: 971
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>> setCategoryFieldCache = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>>();

		// Token: 0x040003CC RID: 972
		public static readonly global::System.Windows.DependencyProperty IsExtendedForTopSetEditingProperty;

		// Token: 0x040003CD RID: 973
		private bool isUsingGlueWindowForscwSetEditorContent;

		// Token: 0x040003CE RID: 974
		private global::System.Collections.Generic.List<int> SetCategory_ActiveSetChanged_RegisterCache = new global::System.Collections.Generic.List<int>();

		// Token: 0x040003CF RID: 975
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set lastSetOfIsExpandEmbeddedSet;

		// Token: 0x040003D0 RID: 976
		internal global::System.Windows.Controls.ColumnDefinition codList;

		// Token: 0x040003D1 RID: 977
		internal global::System.Windows.Controls.ColumnDefinition codEditor;

		// Token: 0x040003D2 RID: 978
		internal global::System.Windows.Controls.Grid gridSets;

		// Token: 0x040003D3 RID: 979
		internal global::System.Windows.Controls.Grid gridToolBar;

		// Token: 0x040003D4 RID: 980
		internal global::System.Windows.Controls.Button btnAdd;

		// Token: 0x040003D5 RID: 981
		internal global::System.Windows.Controls.Button btnAdditional;

		// Token: 0x040003D6 RID: 982
		internal global::System.Windows.Controls.ContextMenu ctmExtended;

		// Token: 0x040003D7 RID: 983
		internal global::System.Windows.Controls.MenuItem mniAddSet;

		// Token: 0x040003D8 RID: 984
		internal global::System.Windows.Controls.MenuItem mniAddMultipleSets;

		// Token: 0x040003D9 RID: 985
		internal global::System.Windows.Controls.MenuItem mniCopySet1;

		// Token: 0x040003DA RID: 986
		internal global::System.Windows.Controls.MenuItem mniAddSetCopies;

		// Token: 0x040003DB RID: 987
		internal global::System.Windows.Controls.MenuItem mniImport;

		// Token: 0x040003DC RID: 988
		internal global::System.Windows.Controls.MenuItem mniExport;

		// Token: 0x040003DD RID: 989
		internal global::System.Windows.Controls.Button btnEdit;

		// Token: 0x040003DE RID: 990
		internal global::System.Windows.Controls.Button btnDelete;

		// Token: 0x040003DF RID: 991
		internal global::System.Windows.Controls.Button btnUp;

		// Token: 0x040003E0 RID: 992
		internal global::System.Windows.Controls.Button btnDown;

		// Token: 0x040003E1 RID: 993
		internal global::System.Windows.Controls.WrapPanel panelSaveDiscardTopsets;

		// Token: 0x040003E2 RID: 994
		internal global::System.Windows.Controls.Button lnkSaveTopSets;

		// Token: 0x040003E3 RID: 995
		internal global::System.Windows.Controls.Button lnkDiscardTopSet;

		// Token: 0x040003E4 RID: 996
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrSets;

		// Token: 0x040003E5 RID: 997
		internal global::System.Windows.Controls.ContextMenu ctmSets;

		// Token: 0x040003E6 RID: 998
		internal global::System.Windows.Controls.MenuItem mniEdit;

		// Token: 0x040003E7 RID: 999
		internal global::System.Windows.Controls.MenuItem mniDelete;

		// Token: 0x040003E8 RID: 1000
		internal global::System.Windows.Controls.MenuItem mniCopySet;

		// Token: 0x040003E9 RID: 1001
		internal global::System.Windows.Controls.MenuItem mniAddCopies;

		// Token: 0x040003EA RID: 1002
		internal global::System.Windows.Controls.MenuItem mniFillDown;

		// Token: 0x040003EB RID: 1003
		internal global::System.Windows.Controls.MenuItem mniShowRelatedSets;

		// Token: 0x040003EC RID: 1004
		internal global::System.Windows.Controls.MenuItem mniShowRelatedConfigurations;

		// Token: 0x040003ED RID: 1005
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMZoneList1 dgrZonelist;

		// Token: 0x040003EE RID: 1006
		internal global::System.Windows.Controls.GridSplitter grdSplitter;

		// Token: 0x040003EF RID: 1007
		internal global::System.Windows.Controls.Border grdBorder;

		// Token: 0x040003F0 RID: 1008
		internal global::System.Windows.Controls.Grid grdEditor;

		// Token: 0x040003F1 RID: 1009
		internal global::System.Windows.Controls.Button lnkSave;

		// Token: 0x040003F2 RID: 1010
		internal global::System.Windows.Controls.Button lnkSaveAs;

		// Token: 0x040003F3 RID: 1011
		internal global::System.Windows.Controls.Button lnkDiscard;

		// Token: 0x040003F4 RID: 1012
		internal global::System.Windows.Controls.Button lnkClose;

		// Token: 0x040003F5 RID: 1013
		internal global::System.Windows.Controls.ItemsControl ictAnchors;

		// Token: 0x040003F6 RID: 1014
		internal global::System.Windows.Controls.ScrollViewer scwSetEditor;

		// Token: 0x040003F7 RID: 1015
		private bool _contentLoaded;
	}
}
