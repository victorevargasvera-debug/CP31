using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Infragistics.Collections;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001FD RID: 509
	public class TypePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x060012EA RID: 4842 RVA: 0x00043754 File Offset: 0x00041954
		public TypePropertyDescriptorProvider(global::System.Type type) : base(type)
		{
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x0004375D File Offset: 0x0004195D
		public global::System.Type Type
		{
			get
			{
				return base.Source as global::System.Type;
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0004376C File Offset: 0x0004196C
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			if (this._properties != null)
			{
				return this._properties;
			}
			global::System.Type type = this.Type;
			if (type == typeof(object) || global::Infragistics.Windows.Internal.DataBindingUtilities.IsKnownType(type))
			{
				this._properties = new global::System.ComponentModel.PropertyDescriptorCollection(new global::System.ComponentModel.PropertyDescriptor[]
				{
					new global::Infragistics.Windows.Internal.ValuePropertyDescriptor(type, "Value")
				}, true);
				return this._properties;
			}
			global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.AddToNotifyList(this);
			return this._properties = global::System.ComponentModel.TypeDescriptor.GetProperties(global::Infragistics.CoreUtilities.GetUnderlyingType(type));
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000437EC File Offset: 0x000419EC
		public override object Key
		{
			get
			{
				return base.Source;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000437F4 File Offset: 0x000419F4
		public override string Name
		{
			get
			{
				return this.Type.Name;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00043801 File Offset: 0x00041A01
		public override bool RaisesPropertyDescriptorsChangedEvent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00043804 File Offset: 0x00041A04
		private static void AddToNotifyList(global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider provider)
		{
			try
			{
				global::System.Threading.Monitor.Enter(typeof(global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider));
				if (!global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_ActiveTypeProviders.Contains(provider))
				{
					global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_ActiveTypeProviders.Add(provider);
					if (global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_RefreshHandler == null)
					{
						global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_RefreshHandler = new global::System.ComponentModel.RefreshEventHandler(global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.OnTypeDescriptorRefreshed);
						global::System.ComponentModel.TypeDescriptor.Refreshed += global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_RefreshHandler;
					}
				}
			}
			finally
			{
				global::System.Threading.Monitor.Exit(typeof(global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider));
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00043880 File Offset: 0x00041A80
		private void OnPropertiesChanged()
		{
			global::System.ComponentModel.PropertyDescriptorCollection properties = this._properties;
			this._properties = null;
			global::System.ComponentModel.PropertyDescriptorCollection properties2 = this.GetProperties();
			base.OnPropertiesChangedHelper(properties, properties2);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000438AC File Offset: 0x00041AAC
		private static void OnTypeDescriptorRefreshed(global::System.ComponentModel.RefreshEventArgs e)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider>();
			try
			{
				global::System.Threading.Monitor.Enter(typeof(global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider));
				int num = 0;
				foreach (global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider typePropertyDescriptorProvider in global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_ActiveTypeProviders)
				{
					if (typePropertyDescriptorProvider != null)
					{
						num++;
						if (typePropertyDescriptorProvider.Type == e.TypeChanged)
						{
							list.Add(typePropertyDescriptorProvider);
						}
					}
				}
				if (num == 0)
				{
					if (global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_RefreshHandler != null)
					{
						global::System.ComponentModel.TypeDescriptor.Refreshed -= global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_RefreshHandler;
						global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider.s_RefreshHandler = null;
					}
					return;
				}
			}
			finally
			{
				global::System.Threading.Monitor.Exit(typeof(global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider));
			}
			if (list.Count > 0)
			{
				foreach (global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider typePropertyDescriptorProvider2 in list)
				{
					typePropertyDescriptorProvider2.OnPropertiesChanged();
				}
			}
		}

		// Token: 0x040009C2 RID: 2498
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider> s_ActiveTypeProviders = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider>();

		// Token: 0x040009C3 RID: 2499
		private static global::System.ComponentModel.RefreshEventHandler s_RefreshHandler = null;

		// Token: 0x040009C4 RID: 2500
		private global::System.ComponentModel.PropertyDescriptorCollection _properties;
	}
}
