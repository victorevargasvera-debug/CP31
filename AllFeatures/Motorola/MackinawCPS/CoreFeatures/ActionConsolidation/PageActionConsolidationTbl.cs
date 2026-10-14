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

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200041C RID: 1052
	public class PageActionConsolidationTbl : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008FFA RID: 36858 RVA: 0x0087C5C0 File Offset: 0x0087A7C0
		public PageActionConsolidationTbl()
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

		// Token: 0x06008FFB RID: 36859 RVA: 0x0087C5F8 File Offset: 0x0087A7F8
		public override void SetDataContext()
		{
			short num = (short)773849088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15;
				case 1:
				{
					num = (short)48431104;
					short num3 = num;
					num = (short)690137042;
					short num4 = num;
					num = (short)1608493010;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1080557568;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1809383429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					}
					break;
				}
				case 2:
					goto IL_89;
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4008);
					num = (short)569704452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_89;
				case 5:
					goto IL_182;
				}
				goto IL_3D;
				IL_15:
				switch (0)
				{
				case 0:
					IL_3D:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1105199105;
						if (num != 0)
						{
						}
						num = (short)1452605443;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4008);
						num = (short)1619525634;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_89:
				this.ActionConsolidationList.DataSource = (global::System.Collections.IEnumerable)base.DataContext;
				this.RecNavToolbarPageActionConsolidation.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				this.RecNavToolbarPageActionConsolidation.MyDataPresenter = this.ActionConsolidationList;
				base.MyBaseRecNavToolbar = this.RecNavToolbarPageActionConsolidation;
				num = (short)119930881;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_182:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4008);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageActionConsolidation).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_204:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageActionConsolidation).MySecondaryRecordsetDataSource = null;
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0087C818 File Offset: 0x0087AA18
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)260046848;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1299152457;
				short num3 = num;
				num = (short)358514249;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2018705408;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 1:
						goto IL_106;
					case 2:
						goto IL_9A;
					}
					IL_7A:
					if (!this.b)
					{
						num = (short)550436866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_9A:
				num = (short)971046913;
				if (num != 0)
				{
				}
				object myRecordsetDataSource = this.RecNavToolbarPageActionConsolidation.MyRecordsetDataSource;
				this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				base.OnLoaded(sender, e);
				this.b = true;
				num = (short)305266689;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_106:
			num = (short)1264779264;
			short num4 = num;
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0087C958 File Offset: 0x0087AB58
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)829704789;
					short num3 = num2;
					num2 = (short)1668696661;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						num2 = (short)429916160;
						if (num2 != 0)
						{
						}
						if (this.b)
						{
							num2 = (short)884342786;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					goto IL_103;
				case 2:
					base.OnUnloaded(sender, e);
					this.b = false;
					num2 = (short)1619329025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_103:
			num2 = (short)812318720;
			short num4 = num2;
			return;
			IL_1C:
			this.RecNavToolbarPageActionConsolidation.DataContext = null;
			this.RecNavToolbarPageActionConsolidation.MyDataPresenter = null;
			num2 = (short)1081344001;
			if (num2 != 0)
			{
			}
			num2 = (short)1446641664;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0087CA94 File Offset: 0x0087AC94
		internal void OnActionConsolidationFlyInClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)237205890;
			short num2 = num;
			num = (short)62814594;
			switch (num2 == num)
			{
			}
			num = (short)507052032;
			short num3 = num;
			num = (short)876478465;
			if (num != 0)
			{
			}
			num = (short)137691136;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation a_ = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			this.a(a_);
		}

		// Token: 0x06008FFF RID: 36863 RVA: 0x0087CB6C File Offset: 0x0087AD6C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)698978210;
			short num2 = num;
			num = (short)340823970;
			switch (num2 == num)
			{
			}
			num = (short)2086797312;
			short num3 = num;
			num = (short)1563951105;
			if (num != 0)
			{
			}
			num = (short)428212224;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x0087CC1C File Offset: 0x0087AE1C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)194689590;
					short num3 = num2;
					num2 = (short)2027862582;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10D;
					default:
						num2 = (short)1513160705;
						if (num2 != 0)
						{
						}
						num2 = (short)765329408;
						if (num2 != 0)
						{
						}
						if (this.a.CurrentItem == null)
						{
							num2 = (short)1280901122;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_139;
					}
					break;
				}
				case 1:
					goto IL_10D;
				case 2:
					this.a.MoveCurrentToFirst();
					num2 = (short)1245708289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_10D:
			num2 = (short)2035679232;
			short num4 = num2;
			IL_139:
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation a_ = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)this.a.CurrentItem;
			this.a(a_);
			return;
			IL_1C:
			object myRecordsetDataSource = this.RecNavToolbarPageActionConsolidation.MyRecordsetDataSource;
			this.a = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
			num2 = (short)1924923392;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x0087CD7C File Offset: 0x0087AF7C
		private void a(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation A_0)
		{
			short num = (short)81209863;
			short num2 = num;
			num = (short)1897933319;
			switch (num2 == num)
			{
			}
			num = (short)1792868352;
			short num3 = num;
			num = (short)1197473792;
			if (num != 0)
			{
			}
			num = (short)1924988929;
			if (num != 0)
			{
			}
			this.a.MoveCurrentTo(A_0);
			base.NavigationService.Navigate(new global::System.Uri(A_0.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x0087CE4C File Offset: 0x0087B04C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 15;
			while (this.c)
			{
				short num = (short)1420165121;
				if (num != 0)
				{
				}
				num = (short)622103777;
				short num2 = num;
				num = (short)2049150177;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)301596672;
					short num3 = num;
					num = (short)204472320;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ￏ鏑룓뫕黗뿙뷛ꫝ闟郡臣闥폧觩菫菭胯鷱髳鏵雷軹폻賽懿昁洃椅ⴇ㠉㰋欍戏甑笓砕眗眙甛紝匟ܡᘣᘥ䬧䔩䈫䠭夯唱䄳䐵夷丹唻儽⸿流╃╅㱇⍉⍋⁍畏恑摓㕕㝗㑙⽛ㅝ౟ୡcݥᱧͩͫm彯፱ᝳɵᅷᕹቻᵽﮑﮓ낝\ud89f쎡즣쪥", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x0087CF30 File Offset: 0x0087B130
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)978583553;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 2)
					{
						num = (short)39976966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 1:
				{
					num = (short)1629104381;
					short num3 = num;
					num = (short)353773821;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					default:
						num = (short)1413545984;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_10F;
				case 3:
					if (connectionId != 15)
					{
						num = (short)1153564677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 4:
					goto IL_114;
				case 5:
				{
					num = (short)891355136;
					short num4 = num;
					num = (short)862060546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)2103836673;
					if (num != 0)
					{
					}
					num = (short)1392967683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8C:
				if (connectionId != 1)
				{
					num = (short)1421803524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1BC;
				IL_114:
				num = (short)1839005696;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AA:
			this.RecNavToolbarPageActionConsolidation = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarPageActionConsolidation.ModeClick += this.OnModeClick;
			return;
			IL_10F:
			this.c = true;
			return;
			IL_173:
			this.ActionConsolidationList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1BC:
			((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.PageActionConsolidationTbl)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.PageActionConsolidationTbl)target).Unloaded += this.OnUnloaded;
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x0087D134 File Offset: 0x0087B334
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
			{
				short num = (short)1763807317;
				short num2 = num;
				num = (short)1797492821;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)380370944;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				break;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
			{
				short num = (short)791805953;
				if (num != 0)
				{
				}
				num = (short)103219200;
				short num3 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004830 RID: 18480
		private global::System.Windows.Data.CollectionView a;

		// Token: 0x04004831 RID: 18481
		private bool b;

		// Token: 0x04004832 RID: 18482
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarPageActionConsolidation;

		// Token: 0x04004833 RID: 18483
		internal global::AcpUI.AcpXamDataPresenter ActionConsolidationList;

		// Token: 0x04004834 RID: 18484
		private bool c;
	}
}
