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

namespace Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile
{
	// Token: 0x02000255 RID: 597
	public class PageInternalMicNoiseReductionProfileTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06006B11 RID: 27409 RVA: 0x005F9AA8 File Offset: 0x005F7CA8
		public PageInternalMicNoiseReductionProfileTbl()
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

		// Token: 0x06006B12 RID: 27410 RVA: 0x005F9AE0 File Offset: 0x005F7CE0
		public override void SetDataContext()
		{
			short num = (short)806354944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1539768321;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 1:
					goto IL_89;
				case 2:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2086);
					num = (short)129957892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)883914836;
					short num3 = num;
					num = (short)1131116628;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						goto IL_16B;
					}
					break;
				}
				case 4:
					goto IL_89;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)2082603008;
						short num4 = num;
						num = (short)80478211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				}
				goto IL_65;
				IL_70:
				num = (short)1650720770;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_65:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					goto IL_70;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2086);
				num = (short)1352728577;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				this.InternalMicNoiseReductionProfileList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageInternalMicNoiseReductionProfile.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageInternalMicNoiseReductionProfile.MyDataPresenter = this.InternalMicNoiseReductionProfileList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageInternalMicNoiseReductionProfile;
				num = (short)853540869;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_16B:
			num = (short)1735917568;
			if (num != 0)
			{
			}
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2086);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageInternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_204:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageInternalMicNoiseReductionProfile).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x005F9D00 File Offset: 0x005F7F00
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)45683449;
			short num2 = num;
			num = (short)1068110585;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				break;
			default:
			{
				num = (short)60162048;
				short num3 = num;
				num = (short)1093664768;
				if (num != 0)
				{
				}
				num = (short)877461504;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num4)
				{
				case 0:
					goto IL_89;
				case 1:
					goto IL_133;
				case 2:
				{
					object myRecordsetDataSource = this.RecNavToolbarPageInternalMicNoiseReductionProfile.MyRecordsetDataSource;
					this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					base.OnLoaded(sender, e);
					this.b = true;
					num = (short)761397249;
					if (num != 0)
					{
					}
					num = (short)782237697;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_A5;
			}
			IL_133:
			return;
			IL_A5:
			if (!this.b)
			{
				num = (short)1017577474;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x005F9E44 File Offset: 0x005F8044
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.b)
						{
							num2 = (short)2042036226;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_104;
					case 2:
					{
						num2 = (short)1543061161;
						short num3 = num2;
						num2 = (short)1656110761;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1789460481;
							if (num2 != 0)
							{
							}
							num2 = (short)1557528576;
							if (num2 != 0)
							{
							}
							base.OnUnloaded(sender, e);
							this.b = false;
							num2 = (short)610729985;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				this.RecNavToolbarPageInternalMicNoiseReductionProfile.DataContext = null;
				this.RecNavToolbarPageInternalMicNoiseReductionProfile.MyDataPresenter = null;
				num2 = (short)1958936576;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_104:
			num2 = (short)616103936;
			short num4 = num2;
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x005F9F80 File Offset: 0x005F8180
		internal void OnInternalMicNoiseReductionProfileFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1274442260;
			short num2 = num;
			num = (short)1678995988;
			switch (num2 == num)
			{
			}
			num = (short)922746880;
			if (num != 0)
			{
			}
			num = (short)406519809;
			if (num != 0)
			{
			}
			num = (short)1948450816;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile a_ = (global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x005FA054 File Offset: 0x005F8254
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)357367809;
			if (num != 0)
			{
			}
			num = (short)276967621;
			short num2 = num;
			num = (short)20328645;
			switch (num2 == num)
			{
			}
			num = (short)1109590016;
			if (num != 0)
			{
			}
			num = (short)1539178496;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x005FA104 File Offset: 0x005F8304
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.a.CurrentItem == null)
						{
							num2 = (short)100007938;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13B;
					case 1:
						goto IL_10E;
					case 2:
					{
						num2 = (short)544351140;
						short num3 = num2;
						num2 = (short)201597860;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)2004221952;
							if (num2 != 0)
							{
							}
							num2 = (short)1531510785;
							if (num2 != 0)
							{
							}
							this.a.MoveCurrentToFirst();
							num2 = (short)597098497;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				object myRecordsetDataSource = this.RecNavToolbarPageInternalMicNoiseReductionProfile.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				num2 = (short)1743716352;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_10E:
			num2 = (short)1548812288;
			short num4 = num2;
			IL_13B:
			global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile a_ = (global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile)this.a.CurrentItem;
			this.a(a_);
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x005FA264 File Offset: 0x005F8464
		private void a(global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile A_0)
		{
			short num = (short)1876885505;
			if (num != 0)
			{
			}
			num = (short)949983245;
			short num2 = num;
			num = (short)1417123853;
			switch (num2 == num)
			{
			}
			num = (short)1060896768;
			if (num != 0)
			{
			}
			num = (short)695140352;
			short num3 = num;
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x005FA334 File Offset: 0x005F8534
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			short num = (short)1252786176;
			short num2 = num;
			num = (short)1084052704;
			short num3 = num;
			num = (short)1947161824;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1169031168;
				if (num != 0)
				{
				}
				num = (short)2031812609;
				if (num != 0)
				{
				}
				if (!this.c)
				{
					this.c = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘뻜냞賠鏢諤触賨藪駬샮菰鋲釴黶雸\udefa쿼쿾搀焂戄栆月搊怌明爐怒〔┖⤘砚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲ᨴ夶嘸刺丼娾摀煂畄㕆ⱈ⽊㡌ⱎ═㩒㩔㥖籘楚浜㱞๠ൢͤ๦๨ṪὬ๮հᩲᩴ᥶噸ቺ፼୾꺊뾌뾎ﲐ朗늖ꮘꮚ좠킢삤芦鮨鮪\udfac쪮햰욲횴쎶킸풺펼骾뗄뗆ꛈ귊꓌ꏎ듐ﳒ볔맖귘뻚꿜뇞胠迢裤軦諨藪苬蛮苰雲蟴鋶鷸軺黼课栀氂欄眆笈搊欌明紐瘒愔甖甘㔚攜縞䰠伢", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x005FA414 File Offset: 0x005F8614
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)693436417;
			if (num != 0)
			{
			}
			num = (short)1066401792;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				case 1:
					goto IL_19C;
				case 2:
				{
					num = (short)772669440;
					short num3 = num;
					num = (short)1227685894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)738494991;
					short num4 = num;
					num = (short)1971096079;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19C;
					default:
						num = (short)1677328384;
						if (num != 0)
						{
						}
						num = (short)265093125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)1063714817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (connectionId != 2)
					{
						num = (short)1835466756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 6:
					goto IL_138;
				}
				IL_68:
				if (connectionId != 1)
				{
					num = (short)1162477571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1BE;
				IL_19C:
				if (connectionId == 26)
				{
					goto IL_177;
				}
				num = (short)1612906498;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			this.RecNavToolbarPageInternalMicNoiseReductionProfile = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageInternalMicNoiseReductionProfile.ModeClick += this.OnModeClick;
			return;
			IL_138:
			this.c = true;
			return;
			IL_177:
			this.InternalMicNoiseReductionProfileList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BE:
			((global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.PageInternalMicNoiseReductionProfileTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.PageInternalMicNoiseReductionProfileTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x005FA618 File Offset: 0x005F8818
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)2122328329;
			short num2 = num;
			num = (short)1377904905;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2FC;
			case 1:
				break;
			default:
			{
				num = (short)1147797504;
				short num3 = num;
				break;
			}
			}
			num = (short)1545207809;
			if (num != 0)
			{
			}
			num = (short)783679488;
			if (num != 0)
			{
			}
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				IL_2FC:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
		}

		// Token: 0x040029F1 RID: 10737
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x040029F2 RID: 10738
		private bool b;

		// Token: 0x040029F3 RID: 10739
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageInternalMicNoiseReductionProfile;

		// Token: 0x040029F4 RID: 10740
		internal global::AcpUI.AcpXamDataPresenter InternalMicNoiseReductionProfileList;

		// Token: 0x040029F5 RID: 10741
		private bool c;
	}
}
