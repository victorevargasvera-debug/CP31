using System;
using System.ComponentModel;
using System.Xml;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001D0 RID: 464
	public class XmlNodePropertyDescriptorProvider : global::Infragistics.Windows.Internal.PropertyDescriptorProvider
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x0003E282 File Offset: 0x0003C482
		public XmlNodePropertyDescriptorProvider(global::System.Xml.XmlNode node) : base(node)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0003E28B File Offset: 0x0003C48B
		public global::System.Xml.XmlNode Node
		{
			get
			{
				return base.Source as global::System.Xml.XmlNode;
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0003E298 File Offset: 0x0003C498
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties()
		{
			if (this._properties == null)
			{
				this._properties = global::Infragistics.Windows.Internal.DataBindingUtilities.GetXmlNodeProperties(this.Node);
			}
			return this._properties;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0003E2BC File Offset: 0x0003C4BC
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

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0003E342 File Offset: 0x0003C542
		public override object Key
		{
			get
			{
				return this.Node.Name;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0003E34F File Offset: 0x0003C54F
		public override string Name
		{
			get
			{
				return this.Node.LocalName;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0003E35C File Offset: 0x0003C55C
		public override bool RaisesPropertyDescriptorsChangedEvent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0003E360 File Offset: 0x0003C560
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

		// Token: 0x04000884 RID: 2180
		private global::Infragistics.Windows.Helpers.HashSet _propertyDescriptorHash;

		// Token: 0x04000885 RID: 2181
		private global::System.ComponentModel.PropertyDescriptorCollection _properties;
	}
}
