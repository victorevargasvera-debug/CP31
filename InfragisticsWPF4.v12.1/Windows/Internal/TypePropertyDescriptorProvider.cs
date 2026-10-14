using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Infragistics.Collections;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001CF RID: 463
	public class TypePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x06001119 RID: 4377 RVA: 0x0003E014 File Offset: 0x0003C214
		public TypePropertyDescriptorProvider(global::System.Type type) : base(type)
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0003E01D File Offset: 0x0003C21D
		public global::System.Type Type
		{
			get
			{
				return base.Source as global::System.Type;
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0003E02C File Offset: 0x0003C22C
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

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0003E0AC File Offset: 0x0003C2AC
		public override object Key
		{
			get
			{
				return base.Source;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0003E0B4 File Offset: 0x0003C2B4
		public override string Name
		{
			get
			{
				return this.Type.Name;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0003E0C1 File Offset: 0x0003C2C1
		public override bool RaisesPropertyDescriptorsChangedEvent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0003E0C4 File Offset: 0x0003C2C4
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

		// Token: 0x06001120 RID: 4384 RVA: 0x0003E140 File Offset: 0x0003C340
		private void OnPropertiesChanged()
		{
			global::System.ComponentModel.PropertyDescriptorCollection properties = this._properties;
			this._properties = null;
			global::System.ComponentModel.PropertyDescriptorCollection properties2 = this.GetProperties();
			base.OnPropertiesChangedHelper(properties, properties2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0003E16C File Offset: 0x0003C36C
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

		// Token: 0x04000881 RID: 2177
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider> s_ActiveTypeProviders = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.Internal.TypePropertyDescriptorProvider>();

		// Token: 0x04000882 RID: 2178
		private static global::System.ComponentModel.RefreshEventHandler s_RefreshHandler = null;

		// Token: 0x04000883 RID: 2179
		private global::System.ComponentModel.PropertyDescriptorCollection _properties;
	}
}
