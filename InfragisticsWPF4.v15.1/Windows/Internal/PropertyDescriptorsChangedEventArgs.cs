using System;
using System.ComponentModel;

namespace Infragistics.Windows.Internal
{
	// Token: 0x02000200 RID: 512
	public class PropertyDescriptorsChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06001300 RID: 4864 RVA: 0x00043C1D File Offset: 0x00041E1D
		internal PropertyDescriptorsChangedEventArgs(global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider, global::System.ComponentModel.PropertyDescriptor[] propertiesAdded, global::System.ComponentModel.PropertyDescriptor[] propertiesChanged, global::System.ComponentModel.PropertyDescriptor[] propertiesRemoved)
		{
			this._provider = provider;
			this._propertiesAdded = propertiesAdded;
			this._propertiesChanged = propertiesChanged;
			this._propertiesRemoved = propertiesRemoved;
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00043C42 File Offset: 0x00041E42
		public global::Infragistics.Windows.Internal.PropertyDescriptorProvider Provider
		{
			get
			{
				return this._provider;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00043C4A File Offset: 0x00041E4A
		public global::System.ComponentModel.PropertyDescriptor[] PropertiesAdded
		{
			get
			{
				return this._propertiesAdded;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00043C52 File Offset: 0x00041E52
		public global::System.ComponentModel.PropertyDescriptor[] PropertiesChanged
		{
			get
			{
				return this._propertiesChanged;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00043C5A File Offset: 0x00041E5A
		public global::System.ComponentModel.PropertyDescriptor[] PropertiesRemoved
		{
			get
			{
				return this._propertiesRemoved;
			}
		}

		// Token: 0x040009C8 RID: 2504
		private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _provider;

		// Token: 0x040009C9 RID: 2505
		private global::System.ComponentModel.PropertyDescriptor[] _propertiesAdded;

		// Token: 0x040009CA RID: 2506
		private global::System.ComponentModel.PropertyDescriptor[] _propertiesChanged;

		// Token: 0x040009CB RID: 2507
		private global::System.ComponentModel.PropertyDescriptor[] _propertiesRemoved;
	}
}
