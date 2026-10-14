using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200018E RID: 398
	public sealed class BindingListChangedEventManager : global::System.Windows.WeakEventManager
	{
		// Token: 0x06000D52 RID: 3410 RVA: 0x0002BE34 File Offset: 0x0002A034
		private BindingListChangedEventManager()
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0002BE3C File Offset: 0x0002A03C
		private static global::Infragistics.Windows.Helpers.BindingListChangedEventManager Instance
		{
			get
			{
				global::System.Type typeFromHandle = typeof(global::Infragistics.Windows.Helpers.BindingListChangedEventManager);
				global::Infragistics.Windows.Helpers.BindingListChangedEventManager bindingListChangedEventManager = (global::Infragistics.Windows.Helpers.BindingListChangedEventManager)global::System.Windows.WeakEventManager.GetCurrentManager(typeFromHandle);
				if (bindingListChangedEventManager == null)
				{
					bindingListChangedEventManager = new global::Infragistics.Windows.Helpers.BindingListChangedEventManager();
					global::System.Windows.WeakEventManager.SetCurrentManager(typeFromHandle, bindingListChangedEventManager);
				}
				return bindingListChangedEventManager;
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0002BE71 File Offset: 0x0002A071
		public static void AddListener(global::System.ComponentModel.IBindingList bindingList, global::System.Windows.IWeakEventListener listener)
		{
			global::Infragistics.Windows.Helpers.BindingListChangedEventManager.Instance.ProtectedAddListener(bindingList, listener);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0002BE7F File Offset: 0x0002A07F
		public static void RemoveListener(global::System.ComponentModel.IBindingList bindingList, global::System.Windows.IWeakEventListener listener)
		{
			global::Infragistics.Windows.Helpers.BindingListChangedEventManager.Instance.ProtectedRemoveListener(bindingList, listener);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0002BE90 File Offset: 0x0002A090
		protected override void StartListening(object source)
		{
			global::System.ComponentModel.IBindingList bindingList = source as global::System.ComponentModel.IBindingList;
			bindingList.ListChanged += this.OnListChanged;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
		protected override void StopListening(object source)
		{
			global::System.ComponentModel.IBindingList bindingList = source as global::System.ComponentModel.IBindingList;
			bindingList.ListChanged -= this.OnListChanged;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0002BEDE File Offset: 0x0002A0DE
		private void OnListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			base.DeliverEvent(sender, e);
		}
	}
}
