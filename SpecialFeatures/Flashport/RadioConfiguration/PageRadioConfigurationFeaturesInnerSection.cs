using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using AcpUI;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000CF RID: 207
	public class PageRadioConfigurationFeaturesInnerSection : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00106F58 File Offset: 0x00105158
		internal PageRadioConfigurationFeaturesInnerSection(global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInner record)
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine(ex.Message);
			}
			base.DataContext = record;
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00106FA0 File Offset: 0x001051A0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)251551188;
			short num2 = num;
			num = (short)707681748;
			switch (num2 == num)
			{
			}
			num = (short)1247739904;
			if (num != 0)
			{
			}
			num = (short)625868801;
			if (num != 0)
			{
			}
			num = (short)1946288128;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00107050 File Offset: 0x00105250
		public override void SetDataContext()
		{
			short num = (short)1332957154;
			short num2 = num;
			num = (short)1683247074;
			switch (num2 == num)
			{
			}
			num = (short)819986432;
			if (num != 0)
			{
			}
			num = (short)1625227265;
			if (num != 0)
			{
			}
			num = (short)829751296;
			short num3 = num;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x001070FC File Offset: 0x001052FC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num;
			if (!this.a)
			{
				num = (short)1813537441;
				short num2 = num;
				num = (short)1795056289;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)93519872;
					if (num != 0)
					{
					}
					num = (short)751435776;
					short num3 = num;
					this.a = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꢆ\uda88ﮊ璉톖ﲘ漢펠욢횤鲦쪨쒪사\udfae\udeb0\uddb2킴\ud9b6춸钺\udbbc펾ꃀ냂귄럆ꛈ맊만ꏐ닒뇔뻖뛘룚닜뇞蟠諢苤鋦鯨諪駬蛮黰鷲\udaf4藶飸鿺铼郾戀氂欄愆怈氊砌紎瀐朒簔砖眘級砜縞唠嘢圤䈦娨䈪䌬䄮吰䄲䘴制娸伺吼倾⽀浂㵄♆⑈❊", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1536032769;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x001071DC File Offset: 0x001053DC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1841430530;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_144;
				case 1:
					num = (short)1248919553;
					if (num != 0)
					{
					}
					num = (short)1176043520;
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
				switch (connectionId)
				{
				case 1:
					goto IL_FA;
				case 2:
					goto IL_D6;
				case 3:
					goto IL_146;
				default:
				{
					num = (short)1188102144;
					short num3 = num;
					num = (short)1300105009;
					short num4 = num;
					num = (short)1997342513;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16A;
					default:
						num = (short)1541996544;
						if (num != 0)
						{
						}
						num = (short)980418561;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_D6:
			this.FkeyConfigFeatureName = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigFeatureName.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FA:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_144:
			goto IL_16A;
			IL_146:
			this.LblRadioCfgFeaturesFeatureName = (global::AcpUI.AcpLabel)target;
			this.LblRadioCfgFeaturesFeatureName.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16A:
			this.a = true;
		}

		// Token: 0x04000632 RID: 1586
		public global::System.Windows.Data.CollectionView myCollectionView;

		// Token: 0x04000633 RID: 1587
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000634 RID: 1588
		internal global::AcpUI.AcpTextBox FkeyConfigFeatureName;

		// Token: 0x04000635 RID: 1589
		internal global::AcpUI.AcpLabel LblRadioCfgFeaturesFeatureName;

		// Token: 0x04000636 RID: 1590
		private bool a;
	}
}
