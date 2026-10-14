using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200002B RID: 43
	public class TasksView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00014DF4 File Offset: 0x00012FF4
		public TasksView()
		{
			this.InitializeComponent();
			this.dgrJobContainer.Records.CollectionChanged += this.a;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00014E2C File Offset: 0x0001302C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num;
			try
			{
				num = (short)614218103;
				short num2 = num;
				num = (short)1652373879;
				switch (num2 == num)
				{
				}
				num = (short)188416001;
				if (num != 0)
				{
				}
				num = (short)807272448;
				if (num != 0)
				{
				}
				global::Microsoft.Practices.Prism.Events.IEventAggregator instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
				int count = this.dgrJobContainer.Records.Count;
				global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames, int> payload = new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames, int>(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames.TaskView, count);
				instance.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.OutputPaneItemChangedEvent>().Publish(payload);
			}
			catch
			{
			}
			num = (short)2022047744;
			short num3 = num;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00014F18 File Offset: 0x00013118
		public void OnMouseDoubleClick(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer parameter;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> delegateCommand;
				global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> delegateCommand2;
				switch (num)
				{
				case 0:
					delegateCommand.Execute(parameter);
					num2 = (short)1258356739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (delegateCommand.CanExecute(parameter))
					{
						num2 = (short)768475136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.Common.TasksViewModel tasksViewModel = base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.TasksViewModel;
					if (tasksViewModel == null)
					{
						num2 = (short)45285376;
						short num3 = num2;
						num2 = (short)1614217221;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					delegateCommand2 = tasksViewModel.ShowJobDetailCommand;
					goto IL_18D;
				}
				case 3:
					return;
				case 4:
					goto IL_6C;
				case 5:
				{
					num2 = (short)476703677;
					short num4 = num2;
					num2 = (short)1180363709;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
						num2 = (short)511967232;
						if (num2 != 0)
						{
						}
						delegateCommand2 = null;
						goto IL_18D;
					}
					break;
				}
				case 6:
					if (delegateCommand != null)
					{
						num2 = (short)812974084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_2C;
				IL_6C:
				num2 = (short)11993089;
				if (num2 != 0)
				{
				}
				num2 = (short)926351361;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18D:
				delegateCommand = delegateCommand2;
				num2 = (short)1932918790;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			parameter = (global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)((global::Infragistics.Windows.DataPresenter.DataRecordPresenter)sender).DataRecord.DataItem;
			num2 = (short)908197890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000150EC File Offset: 0x000132EC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num = (short)826605568;
			short num2 = num;
			num = (short)26464507;
			short num3 = num;
			num = (short)226939131;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1032257537;
				if (num != 0)
				{
				}
				num = (short)1452343296;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("쳢꣤裦鷨蓪鿬胮鷰鋲\udbf4듶雸雺郼郾漀䀂唄吆✈夊氌欎砐簒堔瘖眘稚稜稞䰠䘢䬤匦ܨ株䈬䈮尰尲嬴శ娸吺值伾⹀ⵂ⁄⥆㵈摊㥌⹎≐㡒♔⅖じ㹚⩜灞ᕠɢᙤ౦ᩨᵪѬ੮ٰ嵲൴ᙶᑸ᝺", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000151CC File Offset: 0x000133CC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1948319744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					num = (short)711393282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_F4;
				}
				goto IL_57;
				IL_14:
				num = (short)171835393;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_57:
					switch (connectionId)
					{
					case 1:
						goto IL_CF;
					case 2:
						goto IL_AB;
					case 3:
					{
						num = (short)1901831623;
						short num3 = num;
						num = (short)345155015;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							goto IL_12B;
						}
						break;
					}
					default:
					{
						num = (short)354287616;
						short num4 = num;
						num = (short)448004097;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
			}
			IL_AB:
			this.dgrJobContainer = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			this.dgrJobContainer.DataRecordPresenterMouseDoubleClicked += this.OnMouseDoubleClick;
			return;
			IL_CF:
			this.uclTaskView = (global::Motorola.CommonCPS.RadioManagement.Common.TasksView)target;
			return;
			IL_F4:
			this._contentLoaded = true;
			return;
			IL_12B:
			num = (short)1489108992;
			if (num != 0)
			{
			}
			this.btnClear = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x040000DD RID: 221
		internal global::Motorola.CommonCPS.RadioManagement.Common.TasksView uclTaskView;

		// Token: 0x040000DE RID: 222
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrJobContainer;

		// Token: 0x040000DF RID: 223
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnClear;

		// Token: 0x040000E0 RID: 224
		private bool _contentLoaded;
	}
}
