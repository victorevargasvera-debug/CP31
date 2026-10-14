using System;
using System.Windows;
using AcpCommonLib;

namespace AcpUI.DragDrop
{
	// Token: 0x02000064 RID: 100
	public interface IDropTargetAdvisor
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000531 RID: 1329
		// (set) Token: 0x06000532 RID: 1330
		global::System.Windows.UIElement TargetUI { get; set; }

		// Token: 0x06000533 RID: 1331
		bool IsDropAllowed(global::System.Windows.DragEventArgs e);

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000534 RID: 1332
		// (set) Token: 0x06000535 RID: 1333
		global::AcpUI.AcpTreeViewItem ConsumerNode { get; set; }

		// Token: 0x06000536 RID: 1334
		bool IsDropAllowedByApp(global::System.Windows.IDataObject obj);

		// Token: 0x06000537 RID: 1335
		bool IsDropAllowedByLocalApp(global::System.Windows.IDataObject obj);

		// Token: 0x06000538 RID: 1336
		bool IsValidDataObject(global::System.Windows.IDataObject obj);

		// Token: 0x06000539 RID: 1337
		bool IsDropAllowedByApplicationLanguage(global::System.Windows.IDataObject obj);

		// Token: 0x0600053A RID: 1338
		global::AcpUI.AcpTreeViewItem IsValidConsumerNode(object uiObj, global::System.Windows.DragEventArgs e);

		// Token: 0x0600053B RID: 1339
		void OnDropCompleted(global::System.Windows.IDataObject obj, global::System.Windows.Point dropPoint, global::AcpUI.AcpTreeViewItem consumerNode);

		// Token: 0x0600053C RID: 1340
		global::System.Windows.UIElement GetVisualFeedback(global::System.Windows.IDataObject obj);

		// Token: 0x0600053D RID: 1341
		void SetProcess(global::AcpCommonLib.IAcpBatchOperation process);
	}
}
