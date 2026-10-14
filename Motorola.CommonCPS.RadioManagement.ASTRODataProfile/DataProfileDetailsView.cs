using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.UI.CellRangeFill;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000008 RID: 8
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTRODataProfileMainRegion")]
	public class DataProfileDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000030F4 File Offset: 0x000012F4
		public DataProfileDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00003110 File Offset: 0x00001310
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.DataProfileDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)749022260;
				short num2 = num;
				num = (short)1517038644;
				switch (num2 == num)
				{
				}
				num = (short)1215758336;
				if (num != 0)
				{
				}
				num = (short)611909632;
				short num3 = num;
				num = (short)175570945;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031C0 File Offset: 0x000013C0
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)555810820;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6C;
				case 1:
					return;
				case 2:
				{
					this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.b.a(this.dgrRadios);
					num = (short)128312003;
					short num3 = num;
					num = (short)1957683907;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2016739328;
						if (num != 0)
						{
						}
						num = (short)2104950785;
						if (num != 0)
						{
						}
						num = (short)479920129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_6C;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 5:
				{
					num = (short)381681664;
					short num4 = num;
					if (this.fillManager == null)
					{
						num = (short)1452670978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
					this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﮮ풰\udeb2어\udbb6\ud8b8쾺\ud8bcꃀ껂ꃄ", a_));
					num = (short)269877248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4A:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)1834680326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.dgrRadios.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udeb0\uddb2펴\udeb6\udeb8캺쾼\udebe뗀ꫂ꫄꧆蟈꫊ꃌ꫎", a_));
				num = (short)2103050243;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C:
				num = (short)1783169029;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000033A0 File Offset: 0x000015A0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 15;
			if (this._contentLoaded)
			{
				short num = (short)912392193;
				if (num != 0)
				{
				}
				num = (short)556636183;
				short num2 = num;
				num = (short)915249175;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)161284096;
					if (num != 0)
					{
					}
					num = (short)1448214528;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("莫\udfaf욱\udbb3쒵ힷ횹\uddbb邽莿귁꧃ꯅꟇ꓉迋黍菏ﳑ蛓럕볗동돛鏝臟賡藣臥跧蟩觫胭蓯\udcf1뗳ꗵ곷꣹돻뫽懿瘁攃嘅稇攉樋服簏眑⼓甕眗眙氛焝丟䜡䨣別ܧ丩䴫娭儯䈱䘳夵帷匹倻嬽␿❁ぃ❅ⅇ♉㽋㡍㥏㝑⍓祕㱗㭙⡛㽝ၟၡୣeŧ٩५੭ᕯٱᕳήᑷॹ੻᝽ꪃﺅ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003484 File Offset: 0x00001684
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)944046084;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 2)
					{
						num = (short)1848573954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16C;
				case 1:
					goto IL_B5;
				case 2:
				{
					num = (short)2056152755;
					short num3 = num;
					num = (short)1150052019;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)521273344;
						if (num != 0)
						{
						}
						num = (short)1045954560;
						short num4 = num;
						num = (short)1274216449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					num = (short)1356136448;
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
				num = (short)1989935105;
				if (num != 0)
				{
				}
				if (connectionId == 1)
				{
					break;
				}
				num = (short)527368195;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.uscDataProfileDetails = (global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.DataProfileDetailsView)target;
			this.uscDataProfileDetails.Loaded += this.a;
			return;
			IL_B5:
			this._contentLoaded = true;
			return;
			IL_16C:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000004 RID: 4
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x04000005 RID: 5
		internal global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.DataProfileDetailsView uscDataProfileDetails;

		// Token: 0x04000006 RID: 6
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x04000007 RID: 7
		private bool _contentLoaded;
	}
}
