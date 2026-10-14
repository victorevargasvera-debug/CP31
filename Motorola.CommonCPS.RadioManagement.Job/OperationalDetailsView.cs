using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x02000006 RID: 6
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "JobMainRegion")]
	public class OperationalDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000027F8 File Offset: 0x000009F8
		public OperationalDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002814 File Offset: 0x00000A14
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Job.JobDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)1217797619;
				short num2 = num;
				num = (short)1559174643;
				switch (num2 == num)
				{
				}
				num = (short)1174470656;
				if (num != 0)
				{
				}
				num = (short)977141760;
				short num3 = num;
				num = (short)1285292033;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028C4 File Offset: 0x00000AC4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num = (short)482202200;
			short num2 = num;
			num = (short)1634652760;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1425932289;
				if (num != 0)
				{
				}
				num = (short)1955004416;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					num = (short)223084544;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("ภ渢䨤匦䘨太䈬䌮倰ᴲ瘴堶吸嘺刼儾ɀፂᙄ楆ᭈ⩊⥌♎㹐Ṓ㑔㥖㡘㱚㡜㉞Ѡൢᅤ䥦⍨Ѫཬ呮ተᱲᡴݶᙸᕺ᡼ᅾ겂ﶈﲔ뒚쒠톢쒤펦삨쒪쎬캮\uddb0ힲ킴쎶\ud8b8튺톼첾럀ꫂꃄ냆돊곌ꋎ뷐", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000029A8 File Offset: 0x00000BA8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)796146763;
			short num2 = num;
			num = (short)1837972555;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1853030400;
				if (num != 0)
				{
				}
				num = (short)1543241729;
				if (num != 0)
				{
				}
				if (connectionId != 1)
				{
					num = (short)1483210752;
					short num3 = num;
					this._contentLoaded = true;
					return;
				}
				break;
			}
			this.dgrOperationalJobs = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000007 RID: 7
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrOperationalJobs;

		// Token: 0x04000008 RID: 8
		private bool _contentLoaded;
	}
}
