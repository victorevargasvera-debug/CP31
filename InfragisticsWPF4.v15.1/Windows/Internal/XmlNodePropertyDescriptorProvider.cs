using System;
using System.ComponentModel;
using System.Xml;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001FE RID: 510
	public class XmlNodePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x060012F4 RID: 4852 RVA: 0x000439C2 File Offset: 0x00041BC2
		public XmlNodePropertyDescriptorProvider(global::System.Xml.XmlNode node) : base(node)
		{
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000439CB File Offset: 0x00041BCB
		public global::System.Xml.XmlNode Node
		{
			get
			{
				return base.Source as global::System.Xml.XmlNode;
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000439D8 File Offset: 0x00041BD8
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			if (this._properties == null)
			{
				this._properties = global::Infragistics.Windows.Internal.DataBindingUtilities.GetXmlNodeProperties(this.Node);
			}
			return this._properties;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000439FC File Offset: 0x00041BFC
		public override bool IsCompatibleProvider(global::Infragistics.Windows.Internal.PropertyDescriptorProvider provider)
		{
			global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider xmlNodePropertyDescriptorProvider = provider as global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider;
			if (xmlNodePropertyDescriptorProvider == null)
			{
				return false;
			}
			if (this.Node.GetType() != xmlNodePropertyDescriptorProvider.Node.GetType())
			{
				return false;
			}
			if (this.Node.SchemaInfo != null || xmlNodePropertyDescriptorProvider.Node.SchemaInfo != null)
			{
				return this.Node.SchemaInfo == xmlNodePropertyDescriptorProvider.Node.SchemaInfo;
			}
			return this.Node.Name == xmlNodePropertyDescriptorProvider.Node.Name;
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00043A82 File Offset: 0x00041C82
		public override object Key
		{
			get
			{
				return this.Node.Name;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00043A8F File Offset: 0x00041C8F
		public override string Name
		{
			get
			{
				return this.Node.LocalName;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00043A9C File Offset: 0x00041C9C
		public override bool RaisesPropertyDescriptorsChangedEvent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00043AA0 File Offset: 0x00041CA0
		public void MergePropertiesFromNode(global::System.Xml.XmlNode node)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(node, "node");
			global::System.ComponentModel.PropertyDescriptorCollection properties = this.GetProperties();
			global::System.ComponentModel.PropertyDescriptorCollection xmlNodeProperties = global::Infragistics.Windows.Internal.DataBindingUtilities.GetXmlNodeProperties(node);
			global::Infragistics.Windows.Helpers.HashSet hashSet = this._propertyDescriptorHash;
			if (hashSet == null)
			{
				hashSet = new global::Infragistics.Windows.Helpers.HashSet(properties.Count, 0.5f, global::Infragistics.Windows.Internal.PropertyDescriptorProvider.PropertyDescriptorComparer.Instance);
				hashSet.AddItems(properties);
				this._propertyDescriptorHash = hashSet;
			}
			global::Infragistics.Windows.Helpers.HashSet hashSet2 = new global::Infragistics.Windows.Helpers.HashSet(xmlNodeProperties.Count, 0.5f, global::Infragistics.Windows.Internal.PropertyDescriptorProvider.PropertyDescriptorComparer.Instance);
			hashSet2.AddItems(xmlNodeProperties);
			if (hashSet2.IsSubsetOf(hashSet))
			{
				return;
			}
			this._propertyDescriptorHash = hashSet2;
			global::Infragistics.Windows.Helpers.HashSet union = global::Infragistics.Windows.Helpers.HashSet.GetUnion(hashSet, hashSet2);
			global::System.ComponentModel.PropertyDescriptor[] array = new global::System.ComponentModel.PropertyDescriptor[union.Count];
			int num = 0;
			foreach (object obj in union)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
				array[num] = propertyDescriptor;
				num++;
			}
			this._properties = new global::System.ComponentModel.PropertyDescriptorCollection(array, true);
			base.OnPropertiesChangedHelper(properties, this._properties);
		}

		// Token: 0x040009C5 RID: 2501
		private global::Infragistics.Windows.Helpers.HashSet _propertyDescriptorHash;

		// Token: 0x040009C6 RID: 2502
		private global::System.ComponentModel.PropertyDescriptorCollection _properties;
	}
}
