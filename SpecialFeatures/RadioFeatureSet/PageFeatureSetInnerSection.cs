using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpUI;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200007D RID: 125
	public class PageFeatureSetInnerSection : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x000AE04C File Offset: 0x000AC24C
		internal PageFeatureSetInnerSection(global::SpecialFeatures.RadioFeatureSet.FeatureSetInner record)
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

		// Token: 0x060009DA RID: 2522 RVA: 0x000AE094 File Offset: 0x000AC294
		public override void SetDataContext()
		{
			short num = (short)368312320;
			short num2 = num;
			num = (short)95920939;
			short num3 = num;
			num = (short)1399497515;
			switch (num3 == num)
			{
			}
			num = (short)1044643840;
			if (num != 0)
			{
			}
			num = (short)1982595073;
			if (num != 0)
			{
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000AE13C File Offset: 0x000AC33C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1845821440;
			short num2 = num;
			num = (short)43862672;
			short num3 = num;
			num = (short)100944528;
			switch (num3 == num)
			{
			}
			num = (short)1533804545;
			if (num != 0)
			{
			}
			num = (short)1462173696;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000AE1EC File Offset: 0x000AC3EC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			short num = (short)606895533;
			short num2 = num;
			num = (short)2076999085;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)690487297;
				if (num != 0)
				{
				}
				num = (short)1793196032;
				if (num != 0)
				{
				}
				if (!this.a)
				{
					num = (short)1900675072;
					short num3 = num;
					this.a = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺐삒滛ﲜ욢쒤펦\udca8\ud9aa좬\udcae誰킲\udab4\udab6즸풺펼\udabe꿀럂뗆꣈꿊꓌ꃎ럐뛒듔ꏖ곘꧚룜곞蓠韢쫤臦賨諪駬髮菰雲蛴鋶跸鋺鏼釾搀焂瘄戆樈缊搌怎缐㴒洔瘖琘眚", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000AE2CC File Offset: 0x000AC4CC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1901985792;
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
					goto IL_193;
				case 2:
				{
					num = (short)153142188;
					short num3 = num;
					num = (short)1479852972;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_158;
					default:
					{
						num = (short)941686784;
						if (num != 0)
						{
						}
						num = (short)1213661184;
						short num4 = num;
						num = (short)1327366145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_30:
				num = (short)1231814657;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_14B;
				case 2:
					goto IL_1BC;
				case 3:
					goto IL_127;
				case 4:
					goto IL_103;
				case 5:
					goto IL_198;
				case 6:
					goto IL_158;
				default:
					num = (short)1248067586;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_103:
			this.LblFeatureSetPurchasedFeatureName = (global::AcpUI.AcpLabel)target;
			this.LblFeatureSetPurchasedFeatureName.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_127:
			this.FeatureSetPurchasedFeatureName = (global::AcpUI.AcpTextBox)target;
			this.FeatureSetPurchasedFeatureName.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14B:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_158:
			this.LblFeatureSetEnabledInUsedFlashcode = (global::AcpUI.AcpLabel)target;
			this.LblFeatureSetEnabledInUsedFlashcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_193:
			this.a = true;
			return;
			IL_198:
			this.FeatureSetEnabledInUsedFlashcode = (global::AcpUI.AcpTextBox)target;
			this.FeatureSetEnabledInUsedFlashcode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BC:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x040003DC RID: 988
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x040003DD RID: 989
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x040003DE RID: 990
		internal global::AcpUI.AcpTextBox FeatureSetPurchasedFeatureName;

		// Token: 0x040003DF RID: 991
		internal global::AcpUI.AcpLabel LblFeatureSetPurchasedFeatureName;

		// Token: 0x040003E0 RID: 992
		internal global::AcpUI.AcpTextBox FeatureSetEnabledInUsedFlashcode;

		// Token: 0x040003E1 RID: 993
		internal global::AcpUI.AcpLabel LblFeatureSetEnabledInUsedFlashcode;

		// Token: 0x040003E2 RID: 994
		private bool a;
	}
}
