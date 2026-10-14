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
	// Token: 0x02000013 RID: 19
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "ASTRODataProfileMainRegion")]
	public class RadioDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00006B34 File Offset: 0x00004D34
		public RadioDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00006B50 File Offset: 0x00004D50
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)391577600;
				short num2 = num;
				num = (short)2102548544;
				short num3 = num;
				num = (short)1728927808;
				switch (num3 == num)
				{
				}
				num = (short)266338305;
				if (num != 0)
				{
				}
				num = (short)933363712;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006C00 File Offset: 0x00004E00
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1029046272;
			short num2 = num;
			num = (short)1127743490;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)2029846529;
					if (num != 0)
					{
					}
					goto IL_90;
				case 1:
					this.dgrDataProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("잡즣횥쒧쮩\ud8ab쮭ﺯ펱\ud9b3펵", a_));
					num = (short)1523384320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				case 3:
					goto IL_184;
				case 4:
					goto IL_90;
				case 5:
					this.fillManager = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.b.a(this.dgrDataProfiles);
					num = (short)831848451;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.fillManager == null)
					{
						num = (short)1319239685;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				}
				IL_72:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)2062417921;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.dgrDataProfiles.HideColumn(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("춡쪣삥솧충\ud9ab\udcad톯욱\uddb3\ud9b5횷\uddbb펽ꖿ", a_));
				num = (short)1933443076;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_184:
				num = (short)1266281037;
				short num4 = num;
				num = (short)1403316813;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_72;
				default:
					goto IL_1B9;
				}
				IL_90:
				num = (short)976224262;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1B9:
			num = (short)1835008000;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006DDC File Offset: 0x00004FDC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 15;
			short num = (short)1192251235;
			short num2 = num;
			num = (short)757616483;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)91422720;
				short num3 = num;
				break;
			}
			}
			num = (short)1269104641;
			if (num != 0)
			{
			}
			num = (short)2077884416;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("莫\udfaf욱\udbb3쒵ힷ횹\uddbb邽莿귁꧃ꯅꟇ꓉迋黍菏ﳑ蛓럕볗동돛鏝臟賡藣臥跧蟩觫胭蓯\udcf1뗳ꗵ곷꣹돻뫽懿瘁攃嘅稇攉樋服簏眑⼓甕眗眙氛焝丟䜡䨣別ܧ堩䴫䨭夯崱倳匵䰷嬹唻刽㌿㑁ⵃ⍅㽇敉㹋⽍㑏㭑㭓㉕㵗⹙㵛㝝౟ᅡባཥ൧ᵩ䉫᙭ᅯάᡳ", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006EBC File Offset: 0x000050BC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)379322368;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					num = (short)450560003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (connectionId == 2)
					{
						goto IL_15B;
					}
					num = (short)407371776;
					short num3 = num;
					num = (short)1937698731;
					short num4 = num;
					num = (short)768274347;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1206976512;
						if (num != 0)
						{
						}
						num = (short)311689217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_7F;
				case 4:
					num = (short)499908610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1032716292;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDetailsView)target).Loaded += this.a;
			return;
			IL_7F:
			num = (short)935133185;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			return;
			IL_15B:
			this.dgrDataProfiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000024 RID: 36
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager fillManager;

		// Token: 0x04000025 RID: 37
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrDataProfiles;

		// Token: 0x04000026 RID: 38
		private bool _contentLoaded;
	}
}
