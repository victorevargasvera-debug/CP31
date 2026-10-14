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

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001C7 RID: 455
	public class PageToneSignalingListTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060052FE RID: 21246 RVA: 0x004B5D28 File Offset: 0x004B3F28
		public PageToneSignalingListTbl()
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

		// Token: 0x060052FF RID: 21247 RVA: 0x004B5D60 File Offset: 0x004B3F60
		public override void SetDataContext()
		{
			short num = (short)829554693;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_61;
				case 1:
					goto IL_E5;
				case 2:
				{
					num = (short)1429831653;
					short num3 = num;
					num = (short)531988453;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_188;
					default:
						num = (short)676921344;
						if (num != 0)
						{
						}
						num = (short)88408065;
						if (num != 0)
						{
						}
						goto IL_61;
					}
					break;
				}
				case 3:
					goto IL_188;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)111083521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_205;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1381171203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4156);
				num = (short)708116482;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_61:
				this.ToneSignalingListList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageToneSignalingList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageToneSignalingList.MyDataPresenter = this.ToneSignalingListList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageToneSignalingList;
				num = (short)1369243652;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_188:
				base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4156);
				num = (short)1830813696;
				short num4 = num;
				num = (short)1415512064;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4156);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageToneSignalingList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_205:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageToneSignalingList).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x004B5F80 File Offset: 0x004B4180
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1549664258;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1854906058;
					short num3 = num;
					num = (short)592879306;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1484980224;
						if (num != 0)
						{
						}
						num = (short)702152705;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_109;
						case 1:
						{
							object myRecordsetDataSource = this.RecNavToolbarPageToneSignalingList.MyRecordsetDataSource;
							this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
							base.OnLoaded(sender, e);
							this.b = true;
							num = (short)1968570368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A5;
							}
							continue;
						}
						IL_A5:
						if (this.b)
						{
							goto IL_10B;
						}
						num = (short)799997953;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_109:
			IL_10B:
			num = (short)1672871936;
			short num4 = num;
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x004B60C4 File Offset: 0x004B42C4
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
					goto IL_109;
				case 1:
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)42729472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.b)
					{
						num2 = (short)41025537;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_109:
			num2 = (short)1962409985;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1614151680;
			short num3 = num2;
			this.RecNavToolbarPageToneSignalingList.DataContext = null;
			this.RecNavToolbarPageToneSignalingList.MyDataPresenter = null;
			num2 = (short)1904483882;
			short num4 = num2;
			num2 = (short)237575722;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)883752960;
				if (num2 != 0)
				{
				}
				num2 = (short)856752130;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x004B6204 File Offset: 0x004B4404
		internal void OnToneSignalingListFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2003520310;
			short num2 = num;
			num = (short)1987922742;
			switch (num2 == num)
			{
			}
			num = (short)1653014529;
			if (num != 0)
			{
			}
			num = (short)1418395648;
			if (num != 0)
			{
			}
			num = (short)754122752;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList a_ = (global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x004B62D8 File Offset: 0x004B44D8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1872560358;
			short num2 = num;
			num = (short)1121124582;
			switch (num2 == num)
			{
			}
			num = (short)352780288;
			if (num != 0)
			{
			}
			num = (short)1471283201;
			if (num != 0)
			{
			}
			num = (short)527368192;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x004B638C File Offset: 0x004B458C
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
					goto IL_137;
				case 1:
					this.a.MoveCurrentToFirst();
					num2 = (short)1348665344;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1045692417;
					if (num2 != 0)
					{
					}
					if (this.a.CurrentItem == null)
					{
						num2 = (short)1669464065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				}
				goto IL_1C;
			}
			IL_137:
			goto IL_139;
			IL_1C:
			num2 = (short)456654848;
			short num3 = num2;
			object myRecordsetDataSource = this.RecNavToolbarPageToneSignalingList.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)290193130;
			short num4 = num2;
			num2 = (short)226754282;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_139:
				global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList a_ = (global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList)this.a.CurrentItem;
				this.a(a_);
				return;
			}
			default:
			{
				num2 = (short)1431830528;
				if (num2 != 0)
				{
				}
				num2 = (short)74317826;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x004B64EC File Offset: 0x004B46EC
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList A_0)
		{
			short num = (short)1703477249;
			if (num != 0)
			{
			}
			num = (short)1389780020;
			short num2 = num;
			num = (short)1185700916;
			switch (num2 == num)
			{
			}
			num = (short)1047199744;
			if (num != 0)
			{
			}
			num = (short)966262784;
			short num3 = num;
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x004B65B8 File Offset: 0x004B47B8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 1;
			short num;
			if (this.c)
			{
				num = (short)478478336;
				short num2 = num;
				num = (short)283893921;
				short num3 = num;
				num = (short)1309139105;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)770113536;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)997851137;
			if (num != 0)
			{
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ뿛뇝跟鋡诣裥跧蓩飫쇭苯鏱郳鿵韷\udff9컻컽旿瀁挃椅昇攉愋服猏愑ㄓ␕⠗礙猛瀝䘟䬡䌣匥娧䬩堫䜭弯就ᬳ䈵圷吹夻ᬽ爿牁㝃⽅⽇⑉ⵋ≍㥏㱑㍓獕橗橙㽛ㅝ๟ѡൣťᵧᡩ൫ᩭ᥯ᵱᩳ奵౷ᕹቻ᭽ꕿ낁뒃ﲏﮑ望붗ꢙ겛즟톡킣覥\udca7얩슫쮭쎯\udbb1펳\ud8b5\ud9b7횹햻킽ꞿ껁귃뗅볇뻉껋ꋍﻏ꫑뗓믕듗", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x004B6698 File Offset: 0x004B4898
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1718419458;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16E;
				case 1:
					num = (short)836894720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1271398401;
				if (num != 0)
				{
				}
				num = (short)1744936866;
				short num3 = num;
				num = (short)253403042;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_17D;
				default:
					num = (short)1985609728;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_124;
					case 2:
						goto IL_100;
					case 3:
					case 4:
						goto IL_17D;
					case 5:
						goto IL_170;
					default:
					{
						num = (short)1830354944;
						short num4 = num;
						num = (short)319029249;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
			}
			IL_100:
			this.RecNavToolbarPageToneSignalingList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageToneSignalingList.ModeClick += this.OnModeClick;
			return;
			IL_124:
			((global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.PageToneSignalingListTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.PageToneSignalingListTbl)target).Unloaded += this.OnUnloaded;
			return;
			IL_16E:
			goto IL_17D;
			IL_170:
			this.ToneSignalingListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_17D:
			this.c = true;
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x004B682C File Offset: 0x004B4A2C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1474297856;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1805320193;
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
					goto IL_72;
				case 2:
				{
					num = (short)1881473024;
					short num3 = num;
					num = (short)1429309816;
					short num4 = num;
					num = (short)1291028856;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_72;
					default:
						num = (short)618397696;
						if (num != 0)
						{
						}
						if (connectionId != 4)
						{
							num = (short)1284898819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136;
					}
					break;
				}
				case 3:
					return;
				}
				IL_5A:
				if (connectionId != 3)
				{
					num = (short)1224409089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_72:
				num = (short)1249771522;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_136:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04001FA2 RID: 8098
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04001FA3 RID: 8099
		private bool b;

		// Token: 0x04001FA4 RID: 8100
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageToneSignalingList;

		// Token: 0x04001FA5 RID: 8101
		internal global::AcpUI.AcpXamDataPresenter ToneSignalingListList;

		// Token: 0x04001FA6 RID: 8102
		private bool c;
	}
}
