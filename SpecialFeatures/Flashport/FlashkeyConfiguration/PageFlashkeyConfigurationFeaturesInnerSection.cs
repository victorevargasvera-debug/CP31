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

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x0200010B RID: 267
	public class PageFlashkeyConfigurationFeaturesInnerSection : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000E9F RID: 3743 RVA: 0x00149648 File Offset: 0x00147848
		internal PageFlashkeyConfigurationFeaturesInnerSection(global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInner record)
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

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00149690 File Offset: 0x00147890
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1174208512;
			short num2 = num;
			num = (short)942997505;
			if (num != 0)
			{
			}
			num = (short)2013604857;
			short num3 = num;
			num = (short)1143745529;
			switch (num3 == num)
			{
			}
			num = (short)548470784;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00149740 File Offset: 0x00147940
		public override void SetDataContext()
		{
			short num = (short)1943207936;
			short num2 = num;
			num = (short)1982005249;
			if (num != 0)
			{
			}
			num = (short)1680134839;
			short num3 = num;
			num = (short)1525600951;
			switch (num3 == num)
			{
			}
			num = (short)1447755776;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x001497E8 File Offset: 0x001479E8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (!this.a)
			{
				short num = (short)1831403520;
				short num2 = num;
				num = (short)2068990756;
				short num3 = num;
				num = (short)838683428;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)265814017;
					if (num != 0)
					{
					}
					num = (short)800063488;
					if (num != 0)
					{
					}
					this.a = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊌ\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬첮\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾ꗂ꧄ꛆ뫈ꏊ뷌ꃎꏐ꟒䀹뇖뗘뫚껜럞諠蛢鳤蓦蛨藪诬蛮雰蛲蟴零跸鋺鋼釾⸀攂椄昆稈挊昌樎栐瀒稔礖缘爚稜樞匠䈢儤並䘨䔪䬬䨮倰䜲䀴䔶尸䠺吼儾⽀♂㝄㑆ⱈ⡊㥌♎㹐㵒答⽖㡘㙚ㅜ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x001498C8 File Offset: 0x00147AC8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)632881154;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)311195663;
					short num3 = num;
					num = (short)1159493647;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						goto IL_1CC;
					}
					break;
				}
				case 1:
					goto IL_6A;
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
					goto IL_B4;
				case 2:
					goto IL_173;
				case 3:
					goto IL_125;
				case 4:
					goto IL_90;
				case 5:
					goto IL_6C;
				case 6:
					goto IL_101;
				case 7:
					goto IL_C1;
				default:
					num = (short)1689518081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6A:
				num = (short)1979777024;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6C:
			this.LblFlashkeyCfgCurrentFlashcode = (global::AcpUI.AcpLabel)target;
			this.LblFlashkeyCfgCurrentFlashcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_90:
			this.FkeyConfigCurrentFlashcodeValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigCurrentFlashcodeValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B4:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C1:
			this.LblFlashkeyCfgNewFlashcode = (global::AcpUI.AcpLabel)target;
			this.LblFlashkeyCfgNewFlashcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_101:
			this.FkeyConfigNewFlashcodeValue = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigNewFlashcodeValue.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_125:
			num = (short)1311506432;
			short num4 = num;
			this.LblFlashkeyCfgFeatureName = (global::AcpUI.AcpLabel)target;
			this.LblFlashkeyCfgFeatureName.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_173:
			this.FkeyConfigFeatureName = (global::AcpUI.AcpTextBox)target;
			this.FkeyConfigFeatureName.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CC:
			num = (short)1453457409;
			if (num != 0)
			{
			}
			num = (short)934281216;
			if (num != 0)
			{
			}
			this.a = true;
		}

		// Token: 0x040007BC RID: 1980
		internal global::System.Windows.Data.CollectionView myCollectionView;

		// Token: 0x040007BD RID: 1981
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x040007BE RID: 1982
		internal global::AcpUI.AcpTextBox FkeyConfigFeatureName;

		// Token: 0x040007BF RID: 1983
		internal global::AcpUI.AcpLabel LblFlashkeyCfgFeatureName;

		// Token: 0x040007C0 RID: 1984
		internal global::AcpUI.AcpTextBox FkeyConfigCurrentFlashcodeValue;

		// Token: 0x040007C1 RID: 1985
		internal global::AcpUI.AcpLabel LblFlashkeyCfgCurrentFlashcode;

		// Token: 0x040007C2 RID: 1986
		internal global::AcpUI.AcpTextBox FkeyConfigNewFlashcodeValue;

		// Token: 0x040007C3 RID: 1987
		internal global::AcpUI.AcpLabel LblFlashkeyCfgNewFlashcode;

		// Token: 0x040007C4 RID: 1988
		private bool a;
	}
}
