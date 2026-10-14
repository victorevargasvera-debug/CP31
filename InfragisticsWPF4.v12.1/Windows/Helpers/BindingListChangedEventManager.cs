using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200016C RID: 364
	public sealed class BindingListChangedEventManager : global::System.Windows.WeakEventManager
	{
		// Token: 0x06000C3D RID: 3133 RVA: 0x00027CAC File Offset: 0x00025EAC
		private BindingListChangedEventManager()
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00027CB4 File Offset: 0x00025EB4
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

		// Token: 0x06000C3F RID: 3135 RVA: 0x00027CE9 File Offset: 0x00025EE9
		public static void AddListener(global::System.ComponentModel.IBindingList bindingList, global::System.Windows.IWeakEventListener listener)
		{
			global::Infragistics.Windows.Helpers.BindingListChangedEventManager.Instance.ProtectedAddListener(bindingList, listener);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00027CF7 File Offset: 0x00025EF7
		public static void RemoveListener(global::System.ComponentModel.IBindingList bindingList, global::System.Windows.IWeakEventListener listener)
		{
			global::Infragistics.Windows.Helpers.BindingListChangedEventManager.Instance.ProtectedRemoveListener(bindingList, listener);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00027D08 File Offset: 0x00025F08
		protected override void StartListening(object source)
		{
			global::System.ComponentModel.IBindingList bindingList = source as global::System.ComponentModel.IBindingList;
			bindingList.ListChanged += this.OnListChanged;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00027D30 File Offset: 0x00025F30
		protected override void StopListening(object source)
		{
			global::System.ComponentModel.IBindingList bindingList = source as global::System.ComponentModel.IBindingList;
			bindingList.ListChanged -= this.OnListChanged;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00027D56 File Offset: 0x00025F56
		private void OnListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			base.DeliverEvent(sender, e);
		}
	}
}
