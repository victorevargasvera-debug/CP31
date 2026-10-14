using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.DVRSFiles
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.Composition.Export("DVRSFilesMainView")]
	public class DVRSFilesMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000212D File Offset: 0x0000032D
		public DVRSFilesMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000001 RID: 1
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000213B File Offset: 0x0000033B
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.DVRSFiles.MainViewModel ViewModel
		{
			set
			{
				base.DataContext = value;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002144 File Offset: 0x00000344
		private void uscDVRSFiles_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002148 File Offset: 0x00000348
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri("/Motorola.CommonCPS.RadioManagement.DVRSFiles;component/mainview.xaml", global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002178 File Offset: 0x00000378
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.uscDVRSFiles = (global::Motorola.CommonCPS.RadioManagement.DVRSFiles.DVRSFilesMainView)target;
				this.uscDVRSFiles.Loaded += this.uscDVRSFiles_Loaded;
				return;
			}
			if (connectionId != 2)
			{
				this._contentLoaded = true;
				return;
			}
			this.dgrDVRSFiles = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000001 RID: 1
		internal global::Motorola.CommonCPS.RadioManagement.DVRSFiles.DVRSFilesMainView uscDVRSFiles;

		// Token: 0x04000002 RID: 2
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrDVRSFiles;

		// Token: 0x04000003 RID: 3
		private bool _contentLoaded;
	}
}
