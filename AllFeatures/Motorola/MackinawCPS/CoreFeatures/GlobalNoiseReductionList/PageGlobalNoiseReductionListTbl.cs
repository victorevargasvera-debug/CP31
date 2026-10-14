using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList
{
	// Token: 0x0200025C RID: 604
	public class PageGlobalNoiseReductionListTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06006C00 RID: 27648 RVA: 0x0060606C File Offset: 0x0060426C
		public PageGlobalNoiseReductionListTbl()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x006060A4 File Offset: 0x006042A4
		public override void SetDataContext()
		{
			short num = (short)888471557;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_61;
				case 1:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_1DA;
					}
					num = (short)204749029;
					short num3 = num;
					num = (short)1840068837;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_160;
					default:
						num = (short)490340352;
						if (num != 0)
						{
						}
						num = (short)862846978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_12F;
				case 3:
					goto IL_160;
				case 4:
					num = (short)1672478721;
					if (num != 0)
					{
					}
					goto IL_61;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)924909571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2131);
				num = (short)1099497472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_61:
				this.GlobalNoiseReductionListList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageGlobalNoiseReductionList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageGlobalNoiseReductionList.MyDataPresenter = this.GlobalNoiseReductionListList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageGlobalNoiseReductionList;
				num = (short)911933441;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_160:
				base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2131);
				num = (short)863567876;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12F:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2131);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageGlobalNoiseReductionList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_1DA:
			num = (short)1984036864;
			short num4 = num;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageGlobalNoiseReductionList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x006062C0 File Offset: 0x006044C0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)613875712;
			short num2 = num;
			num = (short)893845504;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_3E;
				case 1:
				{
					num = (short)393277574;
					short num4 = num;
					num = (short)871428230;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_11C;
					}
					break;
				}
				case 2:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageGlobalNoiseReductionList.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)411697153;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_5A;
				IL_3E:
				switch (0)
				{
				case 0:
					IL_5A:
					num = (short)1551892481;
					if (num != 0)
					{
					}
					if (this.b)
					{
						return;
					}
					num = (short)1908736002;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_11C:
			num = (short)11010048;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x00606400 File Offset: 0x00604600
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.b)
					{
						num2 = (short)548929538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_93;
				case 2:
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)779747329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_93:
			num2 = (short)1047199745;
			if (num2 != 0)
			{
			}
			num2 = (short)1750466560;
			short num3 = num2;
			num2 = (short)1610523785;
			short num4 = num2;
			num2 = (short)1652204681;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				this.RecNavToolbarPageGlobalNoiseReductionList.DataContext = null;
				this.RecNavToolbarPageGlobalNoiseReductionList.MyDataPresenter = null;
				num2 = (short)60686336;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)73007104;
				if (num2 != 0)
				{
				}
				break;
			}
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x0060653C File Offset: 0x0060473C
		internal void OnGlobalNoiseReductionListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)970457088;
			short num2 = num;
			num = (short)1978268403;
			short num3 = num;
			num = (short)442432243;
			switch (num3 == num)
			{
			}
			num = (short)1365377024;
			if (num != 0)
			{
			}
			num = (short)1767964673;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList a_ = (global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x00606610 File Offset: 0x00604810
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1649803264;
			short num2 = num;
			num = (short)1575830289;
			short num3 = num;
			num = (short)170803985;
			switch (num3 == num)
			{
			}
			num = (short)1824260097;
			if (num != 0)
			{
			}
			num = (short)363921408;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x006066BC File Offset: 0x006048BC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1014104066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 1:
					goto IL_9C;
				case 2:
					this.a.MoveCurrentToFirst();
					num2 = (short)368640001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_9C:
			num2 = (short)1566052779;
			short num3 = num2;
			num2 = (short)1397756331;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				object myRecordsetDataSource = this.RecNavToolbarPageGlobalNoiseReductionList.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)785973248;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			case 1:
				break;
			default:
			{
				num2 = (short)580190208;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1836253184;
			if (num2 != 0)
			{
			}
			num2 = (short)1640169473;
			if (num2 != 0)
			{
			}
			IL_13B:
			global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList a_ = (global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList)this.a.CurrentItem;
			this.a(a_);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x0060681C File Offset: 0x00604A1C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList A_0)
		{
			short num = (short)428802048;
			short num2 = num;
			num = (short)521215392;
			short num3 = num;
			num = (short)178593184;
			switch (num3 == num)
			{
			}
			num = (short)1954676737;
			if (num != 0)
			{
			}
			num = (short)799604736;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x006068EC File Offset: 0x00604AEC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num = (short)1119576158;
			short num2 = num;
			num = (short)1680498782;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1125515264;
				if (num != 0)
				{
				}
				if (this.c)
				{
					return;
				}
				break;
			}
			num = (short)706019329;
			if (num != 0)
			{
			}
			num = (short)1651376128;
			short num3 = num;
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﻐ鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨裪苬苮臰鳲鯴鋶韸迺틼跾怀朂氄栆Ⰸ㤊㴌樎挐琒稔礖瘘瘚琜簞删آᜤᜦ䨨䐪䌬䤮堰吲䀴䔶堸伺吼倾⽀求⭄⡆⁈㡊⡌橎捐捒❔㉖㵘⹚㹜⭞ࡠౢ୤䉦孨孪๬nὰᕲᱴၶ౸ॺᱼ୾ꢆﾒ낔ꖖꦘ튠욢肤閦馨\ud9aa좬쮮쒰킲솴\udeb6횸햺颼趾꿂계듆뷈꫌ꏎ뻐뇒듔믖럘듚드곞蓠釢胤菦鳨裪駬蛮黰鷲駴黶諸迺觼鷾洀ⴂ約昆搈朊", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x006069CC File Offset: 0x00604BCC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1508573186;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_134;
				case 1:
				{
					num = (short)478781447;
					short num3 = num;
					num = (short)1366925319;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)427098112;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)2015690758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)842203137;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 3:
					if (connectionId != 12)
					{
						num = (short)1013907460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16E;
				case 4:
					num = (short)593625088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)959971331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (connectionId != 2)
					{
						num = (short)1158545413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F9;
				}
				IL_66:
				num = (short)1565917184;
				short num4 = num;
				if (connectionId == 1)
				{
					goto IL_1B3;
				}
				num = (short)163840001;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			this.RecNavToolbarPageGlobalNoiseReductionList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageGlobalNoiseReductionList.ModeClick += this.OnModeClick;
			return;
			IL_134:
			this.c = true;
			return;
			IL_16E:
			this.GlobalNoiseReductionListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1B3:
			((global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.PageGlobalNoiseReductionListTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.PageGlobalNoiseReductionListTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x00606BC4 File Offset: 0x00604DC4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				switch (connectionId)
				{
				case 3:
					goto IL_61;
				case 4:
					goto IL_14B;
				case 5:
					goto IL_133;
				case 6:
					goto IL_49;
				case 7:
					goto IL_B8;
				case 8:
					goto IL_31;
				case 9:
					goto IL_79;
				case 10:
				{
					num = (short)1752972716;
					short num2 = num;
					num = (short)371604908;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_106;
					}
					break;
				}
				case 11:
					goto IL_163;
				}
				break;
			}
			return;
			IL_31:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_49:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_61:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_79:
			num = (short)2011168769;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B8:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_106:
			num = (short)2116812800;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_133:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14B:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_163:
			num = (short)1145700352;
			short num3 = num;
			((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04002A41 RID: 10817
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04002A42 RID: 10818
		private bool b;

		// Token: 0x04002A43 RID: 10819
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageGlobalNoiseReductionList;

		// Token: 0x04002A44 RID: 10820
		internal global::AcpUI.AcpXamDataPresenter GlobalNoiseReductionListList;

		// Token: 0x04002A45 RID: 10821
		private bool c;
	}
}
