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
	// Token: 0x02000007 RID: 7
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "JobMainRegion")]
	public class ProgrammingDetailsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002A6C File Offset: 0x00000C6C
		public ProgrammingDetailsView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002A88 File Offset: 0x00000C88
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Job.JobDetailsViewModel ViewModel
		{
			set
			{
				short num = (short)865402881;
				if (num != 0)
				{
				}
				num = (short)1472002208;
				short num2 = num;
				num = (short)1923741856;
				switch (num2 == num)
				{
				}
				num = (short)1338703872;
				short num3 = num;
				num = (short)815071232;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B38 File Offset: 0x00000D38
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)1804402689;
			if (num != 0)
			{
			}
			num = (short)1348054722;
			short num2 = num;
			num = (short)1839967938;
			switch (num2 == num)
			{
			}
			num = (short)998047744;
			short num3 = num;
			num = (short)713687040;
			if (num != 0)
			{
			}
			this.dgrConfigurationProgrammingJobs.HideColumn(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("焠儢䨤䌦尨䠪夬昮唰嘲嬴䌶倸崺吼娾㍀", a_));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C00 File Offset: 0x00000E00
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)837419009;
			if (num != 0)
			{
			}
			num = (short)927114742;
			short num2 = num;
			num = (short)320841206;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1573650432;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					num = (short)2035548160;
					short num3 = num;
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("㌛匝伟嘡䬣吥䜧䘩䴫-猯崱夳嬵圷吹缻渽ጿ汁ᙃ❅ⱇ⍉⍋͍ㅏ㱑㕓ㅕ㵗㝙㥛そᑟ䱡⹣॥੧兩ཫŭᵯɱ᭳ᡵᵷᑹࡻ兽ﾋ憐릕劣튟쎡즣쮥솧쒩쮫쪭햯욱햳\udfb5풷즹쪻ힽꖿ뗁뻅꧇Ꟊꃋ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CE0 File Offset: 0x00000EE0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1399062529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)1673199616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_89;
				case 2:
					goto IL_188;
				case 3:
					goto IL_17B;
				case 4:
					goto IL_7C;
				case 5:
					goto IL_161;
				case 6:
					goto IL_6F;
				case 7:
					goto IL_C9;
				case 8:
					goto IL_16E;
				default:
					num = (short)2122252290;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_6F:
			this.JobType = (global::System.Windows.Controls.Label)target;
			return;
			IL_7C:
			this.StartTime = (global::System.Windows.Controls.Label)target;
			return;
			IL_89:
			num = (short)11730944;
			short num3 = num;
			((global::Motorola.CommonCPS.RadioManagement.Job.ProgrammingDetailsView)target).Loaded += this.a;
			return;
			IL_C9:
			this.dgrTemplateProgrammingJobs = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_EE:
			num = (short)350158849;
			if (num != 0)
			{
			}
			num = (short)1219103019;
			short num4 = num;
			num = (short)2085423403;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6F;
			default:
				num = (short)1890385920;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				return;
			}
			IL_161:
			this.EndTime = (global::System.Windows.Controls.Label)target;
			return;
			IL_16E:
			this.dgrConfigurationProgrammingJobs = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_17B:
			this.CreatedTime = (global::System.Windows.Controls.Label)target;
			return;
			IL_188:
			this.JobName = (global::System.Windows.Controls.Label)target;
		}

		// Token: 0x04000009 RID: 9
		internal global::System.Windows.Controls.Label JobName;

		// Token: 0x0400000A RID: 10
		internal global::System.Windows.Controls.Label CreatedTime;

		// Token: 0x0400000B RID: 11
		internal global::System.Windows.Controls.Label StartTime;

		// Token: 0x0400000C RID: 12
		internal global::System.Windows.Controls.Label EndTime;

		// Token: 0x0400000D RID: 13
		internal global::System.Windows.Controls.Label JobType;

		// Token: 0x0400000E RID: 14
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrTemplateProgrammingJobs;

		// Token: 0x0400000F RID: 15
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrConfigurationProgrammingJobs;

		// Token: 0x04000010 RID: 16
		private bool _contentLoaded;
	}
}
