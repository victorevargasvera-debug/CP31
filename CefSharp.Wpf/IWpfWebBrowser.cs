using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CefSharp.Wpf
{
	// Token: 0x02000007 RID: 7
	public interface IWpfWebBrowser : global::CefSharp.IWebBrowser, global::CefSharp.IChromiumWebBrowserBase, global::System.IDisposable, global::System.Windows.IInputElement
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000122 RID: 290
		global::System.Windows.Input.ICommand BackCommand { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000123 RID: 291
		global::System.Windows.Input.ICommand ForwardCommand { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000124 RID: 292
		global::System.Windows.Input.ICommand ReloadCommand { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000125 RID: 293
		global::System.Windows.Input.ICommand PrintCommand { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000126 RID: 294
		global::System.Windows.Input.ICommand ZoomInCommand { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000127 RID: 295
		global::System.Windows.Input.ICommand ZoomOutCommand { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000128 RID: 296
		global::System.Windows.Input.ICommand ZoomResetCommand { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000129 RID: 297
		global::System.Windows.Input.ICommand ViewSourceCommand { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012A RID: 298
		global::System.Windows.Input.ICommand CleanupCommand { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012B RID: 299
		global::System.Windows.Input.ICommand StopCommand { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012C RID: 300
		global::System.Windows.Input.ICommand CutCommand { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012D RID: 301
		global::System.Windows.Input.ICommand CopyCommand { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012E RID: 302
		global::System.Windows.Input.ICommand PasteCommand { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012F RID: 303
		global::System.Windows.Input.ICommand SelectAllCommand { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000130 RID: 304
		global::System.Windows.Input.ICommand UndoCommand { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000131 RID: 305
		global::System.Windows.Input.ICommand RedoCommand { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000132 RID: 306
		global::System.Windows.Input.ICommand ToggleAudioMuteCommand { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000133 RID: 307
		global::System.Windows.Threading.Dispatcher Dispatcher { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000134 RID: 308
		// (set) Token: 0x06000135 RID: 309
		double ZoomLevel { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000136 RID: 310
		// (set) Token: 0x06000137 RID: 311
		double ZoomLevelIncrement { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000138 RID: 312
		string Title { get; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000139 RID: 313
		// (remove) Token: 0x0600013A RID: 314
		event global::System.EventHandler<global::CefSharp.Wpf.PaintEventArgs> Paint;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600013B RID: 315
		// (remove) Token: 0x0600013C RID: 316
		event global::System.EventHandler<global::CefSharp.Wpf.VirtualKeyboardRequestedEventArgs> VirtualKeyboardRequested;
	}
}
