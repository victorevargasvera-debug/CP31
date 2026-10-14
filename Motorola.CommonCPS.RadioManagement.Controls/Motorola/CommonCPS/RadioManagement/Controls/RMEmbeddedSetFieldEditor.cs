using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000D0 RID: 208
	public class RMEmbeddedSetFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x0005B748 File Offset: 0x00059948
		public RMEmbeddedSetFieldEditor()
		{
			this.InitializeComponent();
			base.DataContextChanged += this.RMGridFieldEditor_DataContextChanged;
			base.PreviewKeyDown += this.RMEmbeddedSetFieldEditor_PreviewKeyDown;
			base.PreviewMouseRightButtonDown += this.RMEmbeddedSetFieldEditor_PreviewMouseRightButtonDown;
			base.Loaded += this.RMEmbeddedSetFieldEditor_Loaded;
			base.Unloaded += this.RMEmbeddedSetFieldEditor_Unloaded;
			this.a();
			global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>().GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.DisplaySettingsChangedEvent>().Subscribe(new global::System.Action<global::System.EventArgs>(this.SystemEvents_DisplaySettingsChanged));
			this.dgrSets.SelectedItems.Records.CollectionChanged += this.Records_CollectionChanged;
			this.dgrSets.PreviewMouseLeftButtonDown += this.dgrSets_PreviewMouseLeftButtonDown;
			this.EditCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.e), new global::System.Func<bool>(this.f));
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0005B854 File Offset: 0x00059A54
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0005B904 File Offset: 0x00059B04
		public global::System.Windows.Input.ICommand EditCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)595987186;
				short num2 = num;
				num = (short)537135858;
				switch (num2 == num)
				{
				}
				num = (short)690225153;
				if (num != 0)
				{
				}
				num = (short)1762328576;
				short num3 = num;
				num = (short)706871296;
				if (num != 0)
				{
				}
				return this.<EditCommand>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1706425612;
				short num2 = num;
				num = (short)1805647116;
				switch (num2 == num)
				{
				}
				num = (short)1733033984;
				if (num != 0)
				{
				}
				num = (short)2068054016;
				short num3 = num;
				num = (short)1498218497;
				if (num != 0)
				{
				}
				this.<EditCommand>k__BackingField = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0005B9B8 File Offset: 0x00059BB8
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter SetPresenter
		{
			get
			{
				short num = (short)153415207;
				short num2 = num;
				num = (short)1789914663;
				switch (num2 == num)
				{
				}
				num = (short)39124992;
				if (num != 0)
				{
				}
				num = (short)1487273984;
				short num3 = num;
				num = (short)1689255937;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetPresenterProperty);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0005BA70 File Offset: 0x00059C70
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0005BB28 File Offset: 0x00059D28
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory EmbeddedSetCategory
		{
			get
			{
				short num = (short)957127799;
				short num2 = num;
				num = (short)561945719;
				switch (num2 == num)
				{
				}
				num = (short)72220672;
				if (num != 0)
				{
				}
				num = (short)2089943040;
				short num3 = num;
				num = (short)1997733889;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.EmbeddedSetCategoryProperty);
			}
			set
			{
				short num = (short)786271146;
				short num2 = num;
				num = (short)1258326954;
				switch (num2 == num)
				{
				}
				num = (short)375914496;
				if (num != 0)
				{
				}
				num = (short)1919549440;
				short num3 = num;
				num = (short)521601025;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.EmbeddedSetCategoryProperty, value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0005BBDC File Offset: 0x00059DDC
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0005BC94 File Offset: 0x00059E94
		public double SetsDataGridMaxHeight
		{
			get
			{
				short num = (short)1083113473;
				if (num != 0)
				{
				}
				num = (short)2013068537;
				short num2 = num;
				num = (short)699464953;
				switch (num2 == num)
				{
				}
				num = (short)366018560;
				short num3 = num;
				num = (short)1208156160;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetsDataGridMaxHeightProperty);
			}
			set
			{
				short num = (short)705101825;
				if (num != 0)
				{
				}
				num = (short)2139367027;
				short num2 = num;
				num = (short)1766532723;
				switch (num2 == num)
				{
				}
				num = (short)585564160;
				short num3 = num;
				num = (short)43778048;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetsDataGridMaxHeightProperty, value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0005BD50 File Offset: 0x00059F50
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0005BE0C File Offset: 0x0005A00C
		public bool IsInGridEditingOnly
		{
			get
			{
				short num = (short)1385431041;
				if (num != 0)
				{
				}
				num = (short)1046671442;
				short num2 = num;
				num = (short)256634962;
				switch (num2 == num)
				{
				}
				num = (short)45613056;
				short num3 = num;
				num = (short)1900019712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsInGridEditingOnlyProperty);
			}
			set
			{
				short num = (short)52606913;
				short num2 = num;
				num = (short)483440577;
				switch (num2 == num)
				{
				}
				num = (short)461963265;
				if (num != 0)
				{
				}
				num = (short)264372224;
				short num3 = num;
				num = (short)1471479808;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsInGridEditingOnlyProperty, value);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0005BEC8 File Offset: 0x0005A0C8
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1134542374;
			short num2 = num;
			num = (short)284343846;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor rmembeddedSetFieldEditor;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CF:
				global::System.Windows.Data.BindingOperations.ClearBinding(rmembeddedSetFieldEditor.btnEdit, global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty);
				rmembeddedSetFieldEditor.btnEdit.IsEnabled = false;
				global::System.Windows.Data.BindingOperations.ClearBinding(rmembeddedSetFieldEditor.mniEdit, global::System.Windows.Controls.MenuItem.CommandProperty);
				rmembeddedSetFieldEditor.mniEdit.IsEnabled = false;
				rmembeddedSetFieldEditor.InputBindings.RemoveAt(2);
				num = (short)1409220610;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)408813568;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_65;
				}
				break;
			}
			for (;;)
			{
				IL_53:
				switch (num3)
				{
				case 0:
					if ((bool)A_1.NewValue)
					{
						num = (short)417923073;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_CF;
				case 2:
					goto IL_12C;
				}
				goto IL_65;
			}
			IL_12C:
			num = (short)46792704;
			short num4 = num;
			return;
			IL_65:
			num = (short)392495105;
			if (num != 0)
			{
			}
			rmembeddedSetFieldEditor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor);
			num = (short)635699200;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0005C030 File Offset: 0x0005A230
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x0005C0EC File Offset: 0x0005A2EC
		public bool IsShowingSetName
		{
			get
			{
				short num = (short)1896384564;
				short num2 = num;
				num = (short)603883572;
				switch (num2 == num)
				{
				}
				num = (short)976420865;
				if (num != 0)
				{
				}
				num = (short)1197342720;
				short num3 = num;
				num = (short)600571904;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsShowingSetNameProperty);
			}
			set
			{
				short num = (short)1398256096;
				short num2 = num;
				num = (short)1186574816;
				switch (num2 == num)
				{
				}
				num = (short)1891106817;
				if (num != 0)
				{
				}
				num = (short)1041956864;
				short num3 = num;
				num = (short)310640640;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsShowingSetNameProperty, value);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0005C1A8 File Offset: 0x0005A3A8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetGridInfo()
		{
			short num = (short)466055273;
			short num2 = num;
			num = (short)1684762729;
			switch (num2 == num)
			{
			}
			num = (short)1048641537;
			if (num != 0)
			{
			}
			num = (short)640155648;
			short num3 = num;
			num = (short)593625088;
			if (num != 0)
			{
			}
			return this.dgrSets.GetGridInfo();
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0005C25C File Offset: 0x0005A45C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0005C314 File Offset: 0x0005A514
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> FillDownSourceFields
		{
			get
			{
				short num = (short)662937907;
				short num2 = num;
				num = (short)908304691;
				switch (num2 == num)
				{
				}
				num = (short)374931457;
				if (num != 0)
				{
				}
				num = (short)1681129472;
				short num3 = num;
				num = (short)686424064;
				if (num != 0)
				{
				}
				return (global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.FillDownSourceFieldsProperty);
			}
			set
			{
				short num = (short)2127419503;
				short num2 = num;
				num = (short)327735407;
				switch (num2 == num)
				{
				}
				num = (short)875823105;
				if (num != 0)
				{
				}
				num = (short)1145831424;
				short num3 = num;
				num = (short)1139539968;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.FillDownSourceFieldsProperty, value);
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		private void RMEmbeddedSetFieldEditor_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1497830455;
			short num2 = num;
			num = (short)349443127;
			switch (num2 == num)
			{
			}
			num = (short)740032513;
			if (num != 0)
			{
			}
			num = (short)310640640;
			short num3 = num;
			num = (short)81199104;
			if (num != 0)
			{
			}
			base.Loaded -= this.RMEmbeddedSetFieldEditor_Loaded;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0005C484 File Offset: 0x0005A684
		private void RMEmbeddedSetFieldEditor_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1283784706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.EmbeddedSetCategory.Sets != null)
					{
						num = (short)549519364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)878641152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					goto IL_10C;
				case 4:
				{
					num = (short)718733312;
					short num3 = num;
					this.EmbeddedSetCategory.Sets.CollectionChanged += this.Sets_CollectionChanged1;
					this.d();
					num = (short)125108227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_38:
				if (this.EmbeddedSetCategory == null)
				{
					return;
				}
				num = (short)1439489542;
				short num4 = num;
				num = (short)518708742;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1544749056;
					if (num != 0)
					{
					}
					num = (short)1387986945;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10C:
			num = (short)1849032705;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0005C608 File Offset: 0x0005A808
		private void RMEmbeddedSetFieldEditor_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1884225540;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_144;
				case 1:
				{
					num = (short)16182693;
					short num3 = num;
					num = (short)1931931045;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144;
					default:
						num = (short)1675624448;
						if (num != 0)
						{
						}
						num = (short)1025507333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)144048134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 5:
					if (this.EmbeddedSetCategory.SelectedSets.Count == 1)
					{
						num = (short)1046085632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					if ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control)
					{
						num = (short)868483072;
						short num4 = num;
						num = (short)1952251905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_41:
				if (A_1.Key == global::System.Windows.Input.Key.E)
				{
					num = (short)614465538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_144:
				this.b();
				num = (short)2130051073;
				if (num != 0)
				{
				}
				num = (short)1782513667;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0005C7C8 File Offset: 0x0005A9C8
		private void RMEmbeddedSetFieldEditor_PreviewMouseRightButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)908066817;
			if (num != 0)
			{
			}
			num = (short)1232140809;
			short num2 = num;
			num = (short)1750858249;
			switch (num2 == num)
			{
			}
			num = (short)1219231744;
			short num3 = num;
			num = (short)336789504;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.dgrSets.ActiveCell;
			if (activeCell == null)
			{
				return;
			}
			activeCell.EndEditMode();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0005C88C File Offset: 0x0005AA8C
		private void btnEdit_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1433532302;
			short num2 = num;
			num = (short)1384314766;
			switch (num2 == num)
			{
			}
			num = (short)215154689;
			if (num != 0)
			{
			}
			num = (short)1180434432;
			short num3 = num;
			num = (short)713293824;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0005C93C File Offset: 0x0005AB3C
		private void mniEdit_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)447571387;
			short num2 = num;
			num = (short)409036219;
			switch (num2 == num)
			{
			}
			num = (short)380829697;
			if (num != 0)
			{
			}
			num = (short)1961426944;
			short num3 = num;
			num = (short)288030720;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0005C9EC File Offset: 0x0005ABEC
		private void dgrSets_InitializeRecord(object A_0, global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c__DisplayClass39_0 CS$<>8__locals1;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)537067520;
					short num3 = num2;
					if (CS$<>8__locals1.a.IsPreparingForSort)
					{
						num2 = (short)1795293188;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					num2 = (short)1176961025;
					if (num2 != 0)
					{
					}
					num2 = (short)719519750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (set != null)
					{
						num2 = (short)1804730369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AD;
				case 3:
				{
					num2 = (short)1367956720;
					short num4 = num2;
					num2 = (short)1947098352;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1D2;
					}
					break;
				}
				case 4:
					base.Dispatcher.BeginInvoke(new global::System.Action(CS$<>8__locals1.b), global::System.Windows.Threading.DispatcherPriority.Background, global::System.Array.Empty<object>());
					num2 = (short)753467395;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_165;
				case 6:
					if (!set.IsVisible)
					{
						num2 = (short)853803013;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AD;
				}
				goto IL_2C;
				IL_AD:
				num2 = (short)1949302784;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_165:
			CS$<>8__locals1.a.Record.Visibility = global::System.Windows.Visibility.Collapsed;
			return;
			IL_1D2:
			num2 = (short)333250560;
			if (num2 != 0)
			{
			}
			return;
			IL_2C:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c__DisplayClass39_0();
			CS$<>8__locals1.a = A_1;
			set = (((global::Infragistics.Windows.DataPresenter.DataRecord)CS$<>8__locals1.a.Record).DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
			num2 = (short)1786052610;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0005CBE4 File Offset: 0x0005ADE4
		public global::System.Collections.Generic.IEnumerable<string> GetFieldsInCorrectOrder
		{
			get
			{
				short num = (short)151519232;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_E4;
					case 2:
					{
						num = (short)1763770368;
						short num3 = num;
						num = (short)1074653921;
						short num4 = num;
						num = (short)1640032993;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)399638528;
							if (num != 0)
							{
							}
							num = (short)1181351937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (!this.dgrSets.FieldLayouts.Any<global::Infragistics.Windows.DataPresenter.FieldLayout>())
					{
						goto IL_173;
					}
					num = (short)7602178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E4:
				return this.dgrSets.FieldLayouts[0].Fields.Where(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.a)).OrderBy(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, int>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.b)).Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, string>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.c));
				IL_173:
				num = (short)1644756993;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0005CD8C File Offset: 0x0005AF8C
		public global::System.Collections.Generic.IEnumerable<string> TranslatedColumnName
		{
			get
			{
				short num = (short)1057882112;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_E7;
					case 2:
					{
						num = (short)2091188224;
						short num3 = num;
						num = (short)599691782;
						short num4 = num;
						num = (short)1831178758;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)620101632;
							if (num != 0)
							{
							}
							num = (short)1580728321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (!this.dgrSets.FieldLayouts.Any<global::Infragistics.Windows.DataPresenter.FieldLayout>())
					{
						goto IL_176;
					}
					num = (short)1088552962;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				return this.dgrSets.FieldLayouts[0].Fields.Where(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.d)).OrderBy(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, int>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.e)).Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.Field, string>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.f));
				IL_176:
				num = (short)1187184641;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0005CF38 File Offset: 0x0005B138
		private void dgrSets_PreviewMouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)142540802;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
					{
						num = (short)913440775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					if (this.dgrSets.ActiveCell.IsInEditMode)
					{
						num = (short)519831555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1720123393;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 3:
					this.dgrSets.ActiveCell.EndEditMode();
					this.dgrSets.ActiveCell.IsSelected = true;
					num = (short)97714181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)217645056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1380024820;
					short num3 = num;
					num = (short)1038975476;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_79;
					default:
						goto IL_1F4;
					}
					break;
				}
				case 6:
					if (this.dgrSets.ActiveCell != null)
					{
						num = (short)1867841544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_D7;
				case 8:
				{
					num = (short)1587675136;
					short num4 = num;
					num = (short)1822621697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_71;
				IL_79:
				num = (short)1028128772;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_71:
				if (global::System.Windows.Input.Keyboard.Modifiers != global::System.Windows.Input.ModifierKeys.Shift)
				{
					goto IL_79;
				}
				IL_D7:
				num = (short)1140850694;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F4:
			num = (short)523370496;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0005D154 File Offset: 0x0005B354
		private void ctmSets_Opened(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1709244416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1238293472;
				short num3 = num;
				num = (short)978115552;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E9;
				default:
				{
					num = (short)1693777920;
					if (num != 0)
					{
					}
					num = (short)441057280;
					short num4 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 1:
						num = (short)883752961;
						if (num != 0)
						{
						}
						num = (short)108658690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						goto IL_E9;
					}
					IL_AA:
					if (!this.ctmSets.IsVisible)
					{
						num = (short)1458241537;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)185204739;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_E9:
			this.FillDownSourceFields = this.dgrSets.SelectedItems.Cells.Cast<global::Infragistics.Windows.DataPresenter.Cell>().OrderBy(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, int>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.a)).Select(new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c.<>9.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>();
			this.SetPresenter.FillDownCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0005D30C File Offset: 0x0005B50C
		private void SystemEvents_DisplaySettingsChanged(global::System.EventArgs A_0)
		{
			short num = (short)173670400;
			short num2 = num;
			num = (short)169832629;
			short num3 = num;
			num = (short)524054709;
			switch (num3 == num)
			{
			}
			num = (short)220725248;
			if (num != 0)
			{
			}
			num = (short)1357709313;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0005D3BC File Offset: 0x0005B5BC
		private void Records_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)944111634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1487011841;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
				switch (num2)
				{
				case 0:
					if (this.SetPresenter != null)
					{
						num = (short)503119892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 1:
					if (this.SetPresenter.SelectedSets.Count == 0)
					{
						num = (short)876806166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_339;
				case 2:
					if (this.dgrSets.SelectedItems.Records.Count == 0)
					{
						num = (short)703201285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 3:
					if (set.Parent.Equals(this.EmbeddedSetCategory))
					{
						num = (short)357171211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C9;
				case 4:
					goto IL_3C9;
				case 5:
				{
					num = (short)1794641806;
					short num3 = num;
					num = (short)1198395278;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_495;
					default:
						num = (short)575995904;
						if (num != 0)
						{
						}
						base.RaiseLeaveField();
						num = (short)19005455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (this.SetPresenter != null)
					{
						num = (short)1253769240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					goto IL_225;
				case 8:
					num = (short)1363410965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1116078083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)538443778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.EmbeddedSetCategory.PreventInvokeActiveSetChangedEvent = true;
					this.EmbeddedSetCategory.ActiveSet = set;
					this.EmbeddedSetCategory.PreventInvokeActiveSetChangedEvent = false;
					num = (short)440664076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_3C9;
				case 13:
					goto IL_334;
				case 14:
					if (set != null)
					{
						num = (short)312541193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.EmbeddedSetCategory.ActiveSet = null;
					num = (short)1432420356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_225;
				case 16:
					if (this.SetPresenter.SelectedSets.Count > 0)
					{
						num = (short)34996234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 17:
					goto IL_495;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 19:
					base.RaiseEnterField();
					num = (short)2029518855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
				{
					num = (short)508624896;
					short num4 = num;
					num = (short)918290433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 21:
					if (!base.IsLoaded)
					{
						num = (short)2058223639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)661323776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1143078929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_503;
				case 24:
					this.SetPresenter.DeleteEmbeddedSetsCommand.RaiseCanExecuteChanged();
					this.SetPresenter.EditEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.MoveEmbeddedSetDownCommand.RaiseCanExecuteChanged();
					this.SetPresenter.MoveEmbeddedSetUpCommand.RaiseCanExecuteChanged();
					this.SetPresenter.PrepareCopyEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.PrepareShowEmbeddedSetRelatedSetsCommand.RaiseCanExecuteChanged();
					num = (short)163184653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				if (this.dgrSets.DataSource != null)
				{
					num = (short)1672085512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_225:
				this.EmbeddedSetCategory.SelectedSets.Clear();
				this.EmbeddedSetCategory.Sets.CollectionChanged += this.Sets_CollectionChanged1;
				this.EmbeddedSetCategory.SelectedSets.AddRange(this.dgrSets.SelectedItems.GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>());
				set = (this.dgrSets.ActiveDataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
				num = (short)1486028814;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_339:
				num = (short)779550736;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_495:
				if (this.dgrSets.SelectedItems.Records.Count > 0)
				{
					num = (short)533856275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_339;
				IL_3C9:
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> observableCollection = this.dgrSets.DataSource as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>;
				observableCollection.CollectionChanged -= this.Sets_CollectionChanged;
				observableCollection.CollectionChanged += this.Sets_CollectionChanged;
				num = (short)1208549382;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_334:
			return;
			IL_503:;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0005D944 File Offset: 0x0005BB44
		private void Sets_CollectionChanged1(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)598736896;
			short num2 = num;
			num = (short)1811654737;
			short num3 = num;
			num = (short)1217112145;
			switch (num3 == num)
			{
			}
			num = (short)2042232833;
			if (num != 0)
			{
			}
			num = (short)1980563456;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0005D9F4 File Offset: 0x0005BBF4
		private void DoDataContextChangedJobAfterLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)63635456;
			short num2 = num;
			num = (short)989240698;
			short num3 = num;
			num = (short)1658232186;
			switch (num3 == num)
			{
			}
			num = (short)208404481;
			if (num != 0)
			{
			}
			num = (short)1050869760;
			if (num != 0)
			{
			}
			this.Do_RMGridFieldEditor_DataContextChanged(this, this.DataContextChangedArgs);
			base.Loaded -= this.DoDataContextChangedJobAfterLoaded;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0005DABC File Offset: 0x0005BCBC
		public void Do_RMGridFieldEditor_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1839464465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1952251909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_453;
				case 2:
					goto IL_1AB;
				case 3:
					goto IL_10B;
				case 4:
					goto IL_3A5;
				case 5:
					if (e.OldValue is global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)
					{
						num = (short)2005925911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57D;
				case 6:
					goto IL_2D3;
				case 7:
				{
					num = (short)1786773504;
					short num3 = num;
					num = (short)1282474006;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_2D8;
				case 9:
					goto IL_319;
				case 10:
					if (this.dgrSets.FieldLayouts[0].Fields.Count == 0)
					{
						num = (short)841482254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_319;
				case 11:
					if (this.SetPresenter != null)
					{
						num = (short)170917904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.ToolBarStackPanel.Visibility = global::System.Windows.Visibility.Collapsed;
					this.ctmSets.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)225902596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.EmbeddedSetCategory != null)
					{
						num = (short)1257570319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_453;
				case 13:
					if (e.OldValue != null)
					{
						num = (short)12910592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_57D;
				case 14:
					this.c();
					num = (short)507314185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.EmbeddedSetCategory.FieldVisibilityChanged -= this.SetCategory_FieldVisibilityChanged;
					num = (short)1796407297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.ToolBarStackPanel.Visibility = global::System.Windows.Visibility.Visible;
					this.ctmSets.Visibility = global::System.Windows.Visibility.Visible;
					this.SetPresenter.AddEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.AddMultipleSetsCommand.RaiseCanExecuteChanged();
					this.SetPresenter.EditEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.DeleteEmbeddedSetsCommand.RaiseCanExecuteChanged();
					this.SetPresenter.MoveEmbeddedSetDownCommand.RaiseCanExecuteChanged();
					this.SetPresenter.MoveEmbeddedSetUpCommand.RaiseCanExecuteChanged();
					this.SetPresenter.PrepareCopyEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.PrepareShowEmbeddedSetRelatedSetsCommand.RaiseCanExecuteChanged();
					num = (short)890109971;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 18:
					if (base.IsPreviewMode)
					{
						num = (short)1748893716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetPresenterProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b(this));
					num = (short)1935474709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
				{
					if (this._lastActiveSetId == null)
					{
						return;
					}
					num = (short)1294629380;
					short num4 = num;
					num = (short)1798273540;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_453;
					default:
						num = (short)1525415936;
						if (num != 0)
						{
						}
						num = (short)494206982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 20:
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetPresenterProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(this));
					num = (short)1328087043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_10B;
				case 22:
					if (!(base.DataContext is global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField))
					{
						num = (short)335806472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1852178450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField = (global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)e.OldValue;
					collectionField.PropertyChanged -= this.collectionField_PropertyChanged;
					collectionField.SetCategory.FieldVisibilityChanged -= this.SetCategory_FieldVisibilityChanged;
					num = (short)85655554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_85:
				num = (short)1823670273;
				if (num != 0)
				{
				}
				if (base.DataContext != null)
				{
					num = (short)39911431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2D8;
				IL_10B:
				num = (short)7602186;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D8:
				num = (short)411303949;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_319:
				global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)base.DataContext;
				collectionField2.PropertyChanged += this.collectionField_PropertyChanged;
				num = (short)604241932;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_453:
				collectionField2.SetCategory.FieldVisibilityChanged += this.SetCategory_FieldVisibilityChanged;
				this.EmbeddedSetCategory = collectionField2.SetCategory;
				this.EmbeddedSetCategory.SelectedSets.Clear();
				this.EmbeddedSetCategory.RaisePropertyChanged();
				num = (short)637861899;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1AB:
			goto IL_57D;
			IL_2D3:
			this.SetActiveRow(this._lastActiveSetId.ToString());
			this.SetPresenter.ScrollTofieldEditor(base.Name);
			this._lastActiveSetId = null;
			return;
			IL_3A5:
			return;
			IL_57D:
			this.EmbeddedSetCategory = null;
			base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetPresenterProperty, null);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0005E0AC File Offset: 0x0005C2AC
		public void RMGridFieldEditor_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			this.DataContextChangedArgs = e;
			if (global::System.Windows.Window.GetWindow(this) != null)
			{
				short num = (short)548685084;
				short num2 = num;
				num = (short)1985234204;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)765853696;
					short num3 = num;
					num = (short)590282753;
					if (num != 0)
					{
					}
					num = (short)1712521216;
					if (num != 0)
					{
					}
					this.Do_RMGridFieldEditor_DataContextChanged(sender, e);
					return;
				}
				}
			}
			base.Loaded += this.DoDataContextChangedJobAfterLoaded;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0005E180 File Offset: 0x0005C380
		private void SetCategory_FieldVisibilityChanged(object A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldVisibilityChangedEventArgs A_1)
		{
			short num = (short)1251737601;
			if (num != 0)
			{
			}
			num = (short)142278656;
			switch (num)
			{
			default:
			{
				num = (short)846725123;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_30A;
					case 1:
						try
						{
							num = (short)975372294;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text;
								switch (num2)
								{
								case 0:
									goto IL_295;
								case 1:
									if (this._fieldDic.Keys.Contains(text))
									{
										num = (short)1209335813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									num = (short)353632256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (enumerator.MoveNext())
									{
										text = enumerator.Current;
										num = (short)69533697;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1355192088;
									short num3 = num;
									num = (short)1524471576;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_17B;
									default:
										num = (short)1711276032;
										if (num != 0)
										{
										}
										num = (short)43909122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_17B;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_179;
									}
									continue;
								}
								goto IL_179;
								IL_17B:
								this._fieldDic[text].Visibility = global::System.Windows.Visibility.Collapsed;
								num = (short)906428419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F5:
								num = (short)1435107332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_179:
								goto IL_1F5;
							}
							IL_295:
							goto IL_487;
						}
						finally
						{
							num = (short)961282050;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_307;
								case 1:
									enumerator.Dispose();
									num = (short)578224128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2CE;
									}
									continue;
								}
								IL_2CE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)938999809;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_307:;
						}
						goto Block_3;
					case 2:
						goto IL_A0;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					if (this.EmbeddedSetCategory != A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory)
					{
						num = (short)975241218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerable<string> enumerable = A_1.VisibleItems.Except(this._visibleFieldList);
					global::System.Collections.Generic.IEnumerable<string> enumerable2 = this._visibleFieldList.Except(A_1.VisibleItems);
					global::System.Collections.Generic.IEnumerator<string> enumerator2 = enumerable.GetEnumerator();
					num = (short)856817664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_30A:
						num = (short)891813894;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_416;
							case 1:
								num = (short)974520320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)91291649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text2 = enumerator2.Current;
								num = (short)877854725;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								string text2;
								this._fieldDic[text2].Visibility = global::System.Windows.Visibility.Visible;
								num = (short)1027342338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								string text2;
								if (this._fieldDic.Keys.Contains(text2))
								{
									num = (short)2098135044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_34C;
								}
								continue;
							}
							IL_34E:
							num = (short)525533187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_34C:
							goto IL_34E;
						}
						IL_416:
						goto IL_CA;
					}
					finally
					{
						num = (short)154796034;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_484;
							case 1:
								enumerator2.Dispose();
								num = (short)1848115200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_44E;
								}
								continue;
							}
							IL_44E:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)1829699585;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_484:;
					}
					goto IL_487;
					IL_CA:
					enumerator = enumerable2.GetEnumerator();
					num = (short)2142568449;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A0:
				num = (short)1678442496;
				short num4 = num;
				return;
				IL_487:
				this._visibleFieldList = A_1.VisibleItems;
				return;
			}
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0005E654 File Offset: 0x0005C854
		private bool f()
		{
			short num = (short)1377173510;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					goto IL_1A6;
				case 1:
					num = (short)557711365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)750452737;
					if (num != 0)
					{
					}
					num = (short)1485384242;
					short num3 = num;
					num = (short)857156146;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_76;
					default:
						num = (short)394592256;
						if (num != 0)
						{
						}
						if (!this.IsInGridEditingOnly)
						{
							num = (short)1154940928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 3:
					flag = (null != null);
					goto IL_94;
				case 4:
					num = (short)1748107266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.EmbeddedSetCategory != null)
					{
						num = (short)390463492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
				{
					num = (short)1286471680;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				}
				}
				goto IL_6A;
				IL_76:
				num = (short)842399747;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6A:
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter = this.SetPresenter;
				if (setPresenter == null)
				{
					goto IL_76;
				}
				flag = (setPresenter.EditEmbeddedSetCommand != null);
				IL_94:
				if (!flag)
				{
					return false;
				}
				num = (short)790429697;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A6:
			return this.SetPresenter.EditEmbeddedSetCommand.CanExecute(this.EmbeddedSetCategory);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0005E810 File Offset: 0x0005CA10
		private void e()
		{
			short num = (short)1897443884;
			short num2 = num;
			num = (short)1149743660;
			switch (num2 == num)
			{
			default:
			{
				num = (short)476250112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)358481921;
			if (num != 0)
			{
			}
			num = (short)1322450944;
			if (num != 0)
			{
			}
			this.b();
			this.SetPresenter.EditEmbeddedSetCommand.Execute(this.EmbeddedSetCategory);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0005E8D4 File Offset: 0x0005CAD4
		private void collectionField_PropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1584332804;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)398983170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.SetPresenter.AddEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.AddMultipleSetsCommand.RaiseCanExecuteChanged();
					this.SetPresenter.EditEmbeddedSetCommand.RaiseCanExecuteChanged();
					this.SetPresenter.DeleteEmbeddedSetsCommand.RaiseCanExecuteChanged();
					num = (short)1863647235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)616953140;
					short num3 = num;
					num = (short)2027353396;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1749155840;
						if (num != 0)
						{
						}
						num = (short)404160512;
						short num4 = num;
						if (this.SetPresenter != null)
						{
							num = (short)1186398209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 3:
					goto IL_D2;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (!(A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ풟얣튥춧충쎫\udcad즯", a_)))
				{
					return;
				}
				num = (short)19791872;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D2:
			num = (short)709361665;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0005EA90 File Offset: 0x0005CC90
		private void Sets_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set> observableCollection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1975386121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (observableCollection.Contains(this.EmbeddedSetCategory.ActiveSet))
					{
						num2 = (short)70320132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					if (this.dgrSets.ActiveDataItem == null)
					{
						num2 = (short)1337393157;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)985071619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)747503617;
					if (num2 != 0)
					{
					}
					goto IL_F2;
				case 6:
					this.dgrSets.ActiveDataItem = this.EmbeddedSetCategory.ActiveSet;
					num2 = (short)907280386;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (A_1.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num2 = (short)1620246534;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					num2 = (short)1307639809;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.EmbeddedSetCategory.ActiveSet != null)
					{
						num2 = (short)2109079560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					if (this.EmbeddedSetCategory != null)
					{
						num2 = (short)1723566950;
						short num3 = num2;
						num2 = (short)1862962022;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F2;
						case 1:
							break;
						default:
						{
							num2 = (short)1639710720;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)41222144;
						if (num2 != 0)
						{
						}
						num2 = (short)1199243264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_3C;
				IL_F2:
				num2 = (short)531759111;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			observableCollection = (A_0 as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>);
			num2 = (short)84279306;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0005ECF4 File Offset: 0x0005CEF4
		private void d()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Windows.Data.BindingExpression bindingExpression;
			for (;;)
			{
				IL_0A:
				global::Microsoft.Practices.Prism.Commands.DelegateCommandBase delegateCommandBase;
				switch (num)
				{
				case 0:
					delegateCommandBase.RaiseCanExecuteChanged();
					num2 = (short)1763573764;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					goto IL_DF;
				case 3:
					num2 = (short)1244397569;
					if (num2 != 0)
					{
					}
					if (delegateCommandBase != null)
					{
						num2 = (short)1056702464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E1;
				case 4:
					goto IL_E1;
				case 5:
				{
					num2 = (short)186121941;
					short num3 = num2;
					num2 = (short)598539989;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DF;
					default:
						num2 = (short)1160839168;
						if (num2 != 0)
						{
						}
						if (bindingExpression != null)
						{
							num2 = (short)710475776;
							short num4 = num2;
							num2 = (short)1880293378;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_28;
				IL_DF:
				delegateCommandBase = (this.btnGridToFile.Command as global::Microsoft.Practices.Prism.Commands.DelegateCommandBase);
				num2 = (short)1429405699;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E1:
				bindingExpression.UpdateTarget();
				num2 = (short)1026818049;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			bindingExpression = this.btnGridToFile.GetBindingExpression(global::System.Windows.Controls.Primitives.ButtonBase.CommandProperty);
			num2 = (short)939393029;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0005EE98 File Offset: 0x0005D098
		private void c()
		{
			int a_ = 1;
			short num = (short)2002321408;
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
				int num4;
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSetEditor setEditor;
				global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string>.KeyCollection.Enumerator enumerator;
					global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, string> fieldEditorAndGroupList;
					switch (num2)
					{
					case 0:
						goto IL_552;
					case 1:
						goto IL_1AD;
					case 2:
						num = (short)1173684225;
						if (num != 0)
						{
						}
						goto IL_17B;
					case 3:
					{
						num = (short)852754432;
						short num3 = num;
						this.dgrSets.FieldLayouts[0].Fields.Add(global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.GetUnboundFieldByFieldName(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪘ﺚ톞삠캢삤", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Name, num4++, 120, true));
						num = (short)448987138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1AD;
					case 5:
						if (setEditor.AllowMoveSet)
						{
							num = (short)492371977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.btnUp.Visibility = global::System.Windows.Visibility.Collapsed;
						this.btnDown.Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1572536321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.IsShowingSetName)
						{
							num = (short)1371799555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17B;
					case 7:
						try
						{
							num = (short)1677197327;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
								global::Infragistics.Windows.DataPresenter.Field unboundField;
								switch (num2)
								{
								case 1:
									goto IL_2F7;
								case 3:
								{
									string text;
									if (text != null)
									{
										num = (short)2122776590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_494;
								}
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)680984582;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									rmfieldEditor = enumerator.Current;
									num = (short)1316945929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)386269185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1472397320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (unboundField == null)
									{
										num = (short)1601765387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = fieldEditorAndGroupList[rmfieldEditor];
									num = (short)872546307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_53F;
								case 9:
									if (rmfieldEditor is global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)
									{
										num = (short)364249093;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::Infragistics.Windows.DataPresenter.Field field = unboundField;
									string text;
									string str = text;
									string str2 = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꎘ", a_);
									object label = unboundField.Label;
									field.Label = str + str2 + ((label != null) ? label.ToString() : null);
									num = (short)920846349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num4--;
									num = (short)1672871936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									num = (short)1207350559;
									short num5 = num;
									num = (short)204453151;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2F7;
									default:
										num = (short)1175060480;
										if (num != 0)
										{
										}
										unboundField = global::Motorola.CommonCPS.RadioManagement.Controls.DatagridFieldCreator.GetUnboundField((global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor)rmfieldEditor, num4++, true);
										num = (short)51642375;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									goto IL_494;
								case 14:
									num = (short)1137836042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									switch (0)
									{
									case 0:
										goto IL_296;
									}
									continue;
								}
								goto IL_296;
								IL_2F7:
								if (collectionField.SetCategory.IsFieldAllowDisplay(collectionField.SetCategory.Name, rmfieldEditor.Name))
								{
									num = (short)275972108;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4E7;
								IL_494:
								this.dgrSets.FieldLayouts[0].Fields.Add(unboundField);
								unboundField.Visibility = global::System.Windows.Visibility.Collapsed;
								this._fieldDic.Add(unboundField.Name, unboundField);
								num = (short)1596719106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4E7:
								num = (short)1652097028;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_296:
								goto IL_4E7;
							}
							IL_53F:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_552;
					case 8:
						goto IL_1EB;
					case 9:
						this.btnUp.Visibility = global::System.Windows.Visibility.Visible;
						this.btnDown.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)475463684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (setEditor.OrderStartIndex != -1)
						{
							num = (short)910688256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EB;
					}
					goto IL_64;
					IL_17B:
					fieldEditorAndGroupList = setEditor.GetFieldEditorAndGroupList();
					enumerator = fieldEditorAndGroupList.Keys.GetEnumerator();
					num = (short)481755143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AD:
					num = (short)842072070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EB:
					num = (short)394133509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_552:
					global::Infragistics.Windows.DataPresenter.Field item = new global::Infragistics.Windows.DataPresenter.Field
					{
						Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.PostitionConverter(),
						ConverterParameter = setEditor.OrderStartIndex,
						Name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즘햠쪢쪤즦", a_),
						Label = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_Set_Position
					};
					this.dgrSets.FieldLayouts[0].Fields.Insert(num4++, item);
					num = (short)755105800;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_64:
				num4 = 0;
				this.dgrSets.FieldLayouts[0].Fields.Clear();
				this._fieldDic.Clear();
				collectionField = (global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)base.DataContext;
				setEditor = global::Motorola.CommonCPS.RadioManagement.Controls.SetEditorLibrary.GetSetEditor(collectionField.SetCategory.Name, collectionField.SetCategory.TelePortMode, false);
				this.dgrSets.FieldLayouts[0].Fields.Add(new global::Infragistics.Windows.DataPresenter.Field
				{
					BindingType = global::Infragistics.Windows.DataPresenter.BindingType.Unbound,
					Column = num4++,
					Settings = new global::Infragistics.Windows.DataPresenter.FieldSettings
					{
						AllowHiding = global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never,
						CellValuePresenterStyle = (global::System.Windows.Style)global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킘ﺞ춠쪢솤첨잪솬瑩킰\udfb2살튶즺\ud8bc첾꓀귂뇄ꋆ믈飊만뛎뷐뛒", a_)],
						LabelClickAction = global::Infragistics.Windows.DataPresenter.LabelClickAction.Nothing,
						CellMinWidth = 20.0
					}
				});
				num = (short)1981480970;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0005F5AC File Offset: 0x0005D7AC
		private void a(string A_0, string A_1)
		{
			short num = (short)2102722560;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c__DisplayClass60_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c__DisplayClass60_0();
				CS$<>8__locals1.a = A_1;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrSets.Records).GetEnumerator();
				try
				{
					num = (short)201588746;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (CS$<>8__locals1.a == null)
							{
								num = (short)1178664967;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)287244293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1422983174;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = ((global::Infragistics.Windows.DataPresenter.DataRecord)record).DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
							num = (short)1443430412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_2B5;
						case 3:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
							global::System.Guid? id = set.ID;
							num = (short)1961558024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_27E;
						case 5:
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = this.dgrSets;
							global::Infragistics.Windows.DataPresenter.Record record;
							global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell> cells = ((global::Infragistics.Windows.DataPresenter.DataRecord)record).Cells;
							global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, bool> predicate;
							if ((predicate = CS$<>8__locals1.b) == null)
							{
								predicate = (CS$<>8__locals1.b = new global::System.Func<global::Infragistics.Windows.DataPresenter.Cell, bool>(CS$<>8__locals1.c));
							}
							dataPresenterBase.ActiveCell = cells.FirstOrDefault(predicate);
							this.dgrSets.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.StartEditMode);
							num = (short)130285572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1455161346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Infragistics.Windows.DataPresenter.Record record;
							record.IsSelected = true;
							record.IsActive = true;
							num = (short)302579723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Guid? id;
							if (id.ToString() == A_0)
							{
								num = (short)882901001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::Infragistics.Windows.DataPresenter.Record record;
							this.dgrSets.BringRecordIntoView(record);
							num = (short)1707212800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							num = (short)1828651009;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_C0;
							}
							continue;
						case 11:
							goto IL_125;
						case 12:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
							if (set != null)
							{
								num = (short)751566851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_C5:
						num = (short)715849729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C0:
						goto IL_C5;
					}
					IL_125:
					IL_27E:
					IL_2B5:;
				}
				finally
				{
					num = (short)31457281;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_326;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2EC;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)115867648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2EC:
						if (enumerator == null)
						{
							goto IL_371;
						}
						num = (short)1698496514;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_326:
					num = (short)512735417;
					short num3 = num;
					num = (short)377075897;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2097217536;
						if (num != 0)
						{
						}
						break;
					}
					IL_371:;
				}
				num = (short)1184628736;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0005F974 File Offset: 0x0005DB74
		private void b()
		{
			short num = (short)1103888385;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D3;
				case 1:
				{
					num = (short)742326272;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = ((global::Infragistics.Windows.DataPresenter.DataRecord)this.dgrSets.SelectedItems.Records[0]).DataItem as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
					this._lastActiveSetId = set.ID;
					num = (short)1753546752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_58:
				if (this.dgrSets.SelectedItems.Records.Count <= 0)
				{
					return;
				}
				num = (short)704053250;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D3:
			num = (short)1558458943;
			short num4 = num;
			num = (short)1736061503;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1669464064;
				if (num != 0)
				{
				}
				num = (short)221446145;
				if (num != 0)
				{
				}
				break;
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0005FACC File Offset: 0x0005DCCC
		private void a()
		{
			if (global::System.Windows.SystemParameters.PrimaryScreenWidth > 1200.0)
			{
				short num = (short)1741881344;
				short num2 = num;
			}
			else
			{
				short num = (short)723124225;
				if (num != 0)
				{
				}
				num = (short)2143398308;
				short num3 = num;
				num = (short)426617252;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)569507840;
					if (num != 0)
					{
					}
					base.MaxWidth = global::System.Windows.SystemParameters.PrimaryScreenWidth * 0.9;
					return;
				}
			}
			base.MaxWidth = global::System.Windows.SystemParameters.PrimaryScreenWidth - 510.0;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0005FBB0 File Offset: 0x0005DDB0
		public void SetActiveRow(string activeSetId)
		{
			short num = (short)169791943;
			short num2 = num;
			num = (short)450810311;
			switch (num2 == num)
			{
			}
			num = (short)1118896128;
			short num3 = num;
			num = (short)284819457;
			if (num != 0)
			{
			}
			num = (short)381222912;
			if (num != 0)
			{
			}
			this.SetActiveCell(activeSetId, null);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0005FC60 File Offset: 0x0005DE60
		public void SetActiveCell(string activeSetID, string activeFieldName)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c__DisplayClass64_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.<>c__DisplayClass64_0();
			CS$<>8__locals1.a = this;
			CS$<>8__locals1.b = activeSetID;
			CS$<>8__locals1.c = activeFieldName;
			if (!this.dgrSets.IsLoaded)
			{
				short num = (short)1109393408;
				short num2 = num;
				num = (short)301137921;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)1327575809;
				short num3 = num;
				num = (short)416428801;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)431095808;
					if (num != 0)
					{
					}
					this.a(CS$<>8__locals1.b, CS$<>8__locals1.c);
					return;
				}
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.d), new global::System.Action<global::System.Windows.RoutedEventHandler>(CS$<>8__locals1.e), new global::System.Windows.RoutedEventHandler(CS$<>8__locals1.d));
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0005FD70 File Offset: 0x0005DF70
		public override void SetPreviewModeProperties(global::System.Windows.FrameworkElementFactory cellFieldEditorFactory)
		{
			short num = (short)768629708;
			short num2 = num;
			num = (short)1968790476;
			switch (num2 == num)
			{
			}
			num = (short)313196544;
			short num3 = num;
			num = (short)1668415489;
			if (num != 0)
			{
			}
			num = (short)278200320;
			if (num != 0)
			{
			}
			base.SetPreviewModeProperties(cellFieldEditorFactory);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsInGridEditingOnlyProperty, this.IsInGridEditingOnly);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsShowingSetNameProperty, this.IsShowingSetName);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0005FE4C File Offset: 0x0005E04C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 9;
			if (this._contentLoaded)
			{
				short num = (short)269025280;
				short num2 = num;
			}
			else
			{
				short num = (short)147304454;
				short num3 = num;
				num = (short)1738125318;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)731971585;
					if (num != 0)
					{
					}
					num = (short)249888768;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("躠쪤펦욨\ud9aa슬쎮킰鶲\ud8b6풸횺튼톾苀鏂雄鯈꫊꧌ꛎ뻐黒듔맖룘볚룜닞蓠跢釤짦ꫨ蓪菬鯮菰鳲駴蓶싸飺鋼鋾焀氂欄戆月缊∌税成瘒朔琖瘘甚検洞丠伢嘤ࠦ伨䈪䠬䌮唰嘲儴帶䴸吺似䰾湀ㅂ⡄≆⑈⥊⡌⭎㕐㙒ㅔ⑖㱘⽚㭜㙞ѠརŤɦ൨ɪᥬnͰ嵲൴ᙶᑸ᝺", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0005FF2C File Offset: 0x0005E12C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1122211032;
			short num2 = num;
			num = (short)1665766616;
			switch (num2 == num)
			{
			}
			num = (short)1910636544;
			short num3 = num;
			num = (short)1891827712;
			if (num != 0)
			{
			}
			num = (short)712245249;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0005FFE0 File Offset: 0x0005E1E0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1125384193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_195;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_17C;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_2C7;
				case 2:
					goto IL_ED;
				case 3:
					goto IL_1BE;
				case 4:
					goto IL_19A;
				case 5:
					goto IL_D3;
				case 6:
					goto IL_121;
				case 7:
					goto IL_2BA;
				case 8:
					goto IL_1CB;
				case 9:
					goto IL_148;
				case 10:
				{
					num = (short)940179456;
					short num3 = num;
					num = (short)910076381;
					short num4 = num;
					num = (short)674605533;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_28B;
					}
					break;
				}
				case 11:
					goto IL_220;
				case 12:
					goto IL_2E1;
				case 13:
					goto IL_114;
				case 14:
					goto IL_C6;
				case 15:
					goto IL_2AD;
				case 16:
					goto IL_2EE;
				case 17:
					goto IL_FA;
				case 18:
					goto IL_B9;
				case 19:
					goto IL_1FC;
				case 20:
					goto IL_1D8;
				case 21:
					goto IL_E0;
				case 22:
					goto IL_12E;
				case 23:
					goto IL_2D4;
				case 24:
					goto IL_107;
				case 25:
					goto IL_13B;
				default:
					num = (short)1870135298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_17C:
				num = (short)1545732096;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			this.dgrSets = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_C6:
			this.btnUp = (global::System.Windows.Controls.Button)target;
			return;
			IL_D3:
			this.btnAdd = (global::System.Windows.Controls.Button)target;
			return;
			IL_E0:
			this.mniDelete = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_ED:
			this.borderInvalid = (global::System.Windows.Controls.Border)target;
			return;
			IL_FA:
			this.btnFileToGrid = (global::System.Windows.Controls.Button)target;
			return;
			IL_107:
			this.mniShowRelatedSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_114:
			this.mniImportFromXML = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_121:
			this.btnDelete = (global::System.Windows.Controls.Button)target;
			return;
			IL_12E:
			this.mniAddCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_13B:
			this.roundProgressCtrl = (global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator)target;
			return;
			IL_148:
			num = (short)1366425601;
			if (num != 0)
			{
			}
			this.mniAddSet = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_195:
			this._contentLoaded = true;
			return;
			IL_19A:
			this.btnEdit = (global::System.Windows.Controls.Button)target;
			this.btnEdit.Click += this.btnEdit_Click;
			return;
			IL_1BE:
			this.ToolBarStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1CB:
			this.ctmExtended = (global::System.Windows.Controls.ContextMenu)target;
			return;
			IL_1D8:
			this.mniEdit = (global::System.Windows.Controls.MenuItem)target;
			this.mniEdit.Click += this.mniEdit_Click;
			return;
			IL_1FC:
			this.ctmSets = (global::System.Windows.Controls.ContextMenu)target;
			this.ctmSets.Opened += this.ctmSets_Opened;
			return;
			IL_220:
			this.mniAddSetCopies = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_28B:
			num = (short)1632632832;
			if (num != 0)
			{
			}
			this.mniAddMultipleSets = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2AD:
			this.btnDown = (global::System.Windows.Controls.Button)target;
			return;
			IL_2BA:
			this.btnAdditional = (global::System.Windows.Controls.Button)target;
			return;
			IL_2C7:
			this.tblLabel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_2D4:
			this.mniFillDown = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2E1:
			this.mniImportFromAPK = (global::System.Windows.Controls.MenuItem)target;
			return;
			IL_2EE:
			this.btnGridToFile = (global::System.Windows.Controls.Button)target;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000602F0 File Offset: 0x0005E4F0
		// Note: this type is marked as 'beforefieldinit'.
		static RMEmbeddedSetFieldEditor()
		{
			int a_ = 4;
			short num = (short)165515840;
			short num2 = num;
			num = (short)1979617856;
			switch (num2 == num)
			{
			}
			num = (short)1443037184;
			short num3 = num;
			num = (short)1757478913;
			if (num != 0)
			{
			}
			num = (short)884932608;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetPresenterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ풟횣쎥\udba7쾩슫\udaad햯삱", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.EmbeddedSetCategoryProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud99b슟잡삣슥춧캩ﾫ쮭쒯햳습\uddb7\uddb9펻첽릿", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.SetsDataGridMaxHeightProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ풟톡장\udca7쮩\udcad\ud9af횱靈ힵ삷\ud9bbힽꞿ꫁냃", a_), typeof(double), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(350.0));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsInGridEditingOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햛첡풥솧캩쪭\ud9af욱\uddb3\ud8b5\udfb7튻튽릿", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.IsShowingSetNameProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햛쪡쮣톥솧쒩쮫ﶭ햯욱荒ힵ햷\udfb9", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor.FillDownSourceFieldsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b첟캡즥\udfa7쒩ﾫ솭얯삱ힳ펵ﺷ펹\ud9bb튽꒿뇁", a_), typeof(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMEmbeddedSetFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000266 RID: 614
		private readonly global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field> _fieldDic = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.DataPresenter.Field>();

		// Token: 0x04000267 RID: 615
		private global::System.Collections.Generic.IEnumerable<string> _visibleFieldList = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000268 RID: 616
		private global::System.Guid? _lastActiveSetId;

		// Token: 0x0400026A RID: 618
		public static readonly global::System.Windows.DependencyProperty SetPresenterProperty;

		// Token: 0x0400026B RID: 619
		public static readonly global::System.Windows.DependencyProperty EmbeddedSetCategoryProperty;

		// Token: 0x0400026C RID: 620
		public static readonly global::System.Windows.DependencyProperty SetsDataGridMaxHeightProperty;

		// Token: 0x0400026D RID: 621
		public static readonly global::System.Windows.DependencyProperty IsInGridEditingOnlyProperty;

		// Token: 0x0400026E RID: 622
		public static readonly global::System.Windows.DependencyProperty IsShowingSetNameProperty;

		// Token: 0x0400026F RID: 623
		public static readonly global::System.Windows.DependencyProperty FillDownSourceFieldsProperty;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.DependencyPropertyChangedEventArgs DataContextChangedArgs;

		// Token: 0x04000271 RID: 625
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock tblLabel;

		// Token: 0x04000272 RID: 626
		internal global::System.Windows.Controls.Border borderInvalid;

		// Token: 0x04000273 RID: 627
		internal global::System.Windows.Controls.StackPanel ToolBarStackPanel;

		// Token: 0x04000274 RID: 628
		internal global::System.Windows.Controls.Button btnEdit;

		// Token: 0x04000275 RID: 629
		internal global::System.Windows.Controls.Button btnAdd;

		// Token: 0x04000276 RID: 630
		internal global::System.Windows.Controls.Button btnDelete;

		// Token: 0x04000277 RID: 631
		internal global::System.Windows.Controls.Button btnAdditional;

		// Token: 0x04000278 RID: 632
		internal global::System.Windows.Controls.ContextMenu ctmExtended;

		// Token: 0x04000279 RID: 633
		internal global::System.Windows.Controls.MenuItem mniAddSet;

		// Token: 0x0400027A RID: 634
		internal global::System.Windows.Controls.MenuItem mniAddMultipleSets;

		// Token: 0x0400027B RID: 635
		internal global::System.Windows.Controls.MenuItem mniAddSetCopies;

		// Token: 0x0400027C RID: 636
		internal global::System.Windows.Controls.MenuItem mniImportFromAPK;

		// Token: 0x0400027D RID: 637
		internal global::System.Windows.Controls.MenuItem mniImportFromXML;

		// Token: 0x0400027E RID: 638
		internal global::System.Windows.Controls.Button btnUp;

		// Token: 0x0400027F RID: 639
		internal global::System.Windows.Controls.Button btnDown;

		// Token: 0x04000280 RID: 640
		internal global::System.Windows.Controls.Button btnGridToFile;

		// Token: 0x04000281 RID: 641
		internal global::System.Windows.Controls.Button btnFileToGrid;

		// Token: 0x04000282 RID: 642
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrSets;

		// Token: 0x04000283 RID: 643
		internal global::System.Windows.Controls.ContextMenu ctmSets;

		// Token: 0x04000284 RID: 644
		internal global::System.Windows.Controls.MenuItem mniEdit;

		// Token: 0x04000285 RID: 645
		internal global::System.Windows.Controls.MenuItem mniDelete;

		// Token: 0x04000286 RID: 646
		internal global::System.Windows.Controls.MenuItem mniAddCopies;

		// Token: 0x04000287 RID: 647
		internal global::System.Windows.Controls.MenuItem mniFillDown;

		// Token: 0x04000288 RID: 648
		internal global::System.Windows.Controls.MenuItem mniShowRelatedSets;

		// Token: 0x04000289 RID: 649
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator roundProgressCtrl;

		// Token: 0x0400028A RID: 650
		private bool _contentLoaded;
	}
}
