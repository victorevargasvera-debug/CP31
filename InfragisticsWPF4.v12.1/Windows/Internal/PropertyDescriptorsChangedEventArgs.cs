using System;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001D2 RID: 466
	public class PropertyDescriptorsChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x0003E4DD File Offset: 0x0003C6DD
		internal PropertyDescriptorsChangedEventArgs(global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider, global::System.ComponentModel.PropertyDescriptor[] propertiesAdded, global::System.ComponentModel.PropertyDescriptor[] propertiesChanged, global::System.ComponentModel.PropertyDescriptor[] propertiesRemoved)
		{
			this._provider = provider;
			this._propertiesAdded = propertiesAdded;
			this._propertiesChanged = propertiesChanged;
			this._propertiesRemoved = propertiesRemoved;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0003E502 File Offset: 0x0003C702
		public global::Infragistics.Windows.Internal.PropertyDescriptorProvider Provider
		{
			get
			{
				return this._provider;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0003E50A File Offset: 0x0003C70A
		public global::System.ComponentModel.PropertyDescriptor[] PropertiesAdded
		{
			get
			{
				return this._propertiesAdded;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0003E512 File Offset: 0x0003C712
		public global::System.ComponentModel.PropertyDescriptor[] PropertiesChanged
		{
			get
			{
				return this._propertiesChanged;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0003E51A File Offset: 0x0003C71A
		public global::System.ComponentModel.PropertyDescriptor[] PropertiesRemoved
		{
			get
			{
				return this._propertiesRemoved;
			}
		}

		// Token: 0x04000887 RID: 2183
		private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _provider;

		// Token: 0x04000888 RID: 2184
		private global::System.ComponentModel.PropertyDescriptor[] _propertiesAdded;

		// Token: 0x04000889 RID: 2185
		private global::System.ComponentModel.PropertyDescriptor[] _propertiesChanged;

		// Token: 0x0400088A RID: 2186
		private global::System.ComponentModel.PropertyDescriptor[] _propertiesRemoved;
	}
}
