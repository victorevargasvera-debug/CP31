using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats;

namespace NPOI
{
	// Token: 0x02000008 RID: 8
	public class CustomProperties
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000342C File Offset: 0x0000162C
		internal CustomProperties(global::NPOI.OpenXmlFormats.CustomPropertiesDocument props)
		{
			this.props = props;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000343B File Offset: 0x0000163B
		public global::NPOI.OpenXmlFormats.CT_CustomProperties GetUnderlyingProperties()
		{
			return this.props.GetProperties();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003448 File Offset: 0x00001648
		private global::NPOI.OpenXmlFormats.CT_Property Add(string name)
		{
			if (this.Contains(name))
			{
				throw new global::System.ArgumentException("A property with this name already exists in the custom properties");
			}
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = this.props.GetProperties().AddNewProperty();
			int pid = this.NextPid();
			ct_Property.pid = pid;
			ct_Property.fmtid = global::NPOI.CustomProperties.FORMAT_ID;
			ct_Property.name = name;
			return ct_Property;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003499 File Offset: 0x00001699
		public void AddProperty(string name, string value)
		{
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = this.Add(name);
			ct_Property.ItemElementName = global::NPOI.OpenXmlFormats.ItemChoiceType.lpwstr;
			ct_Property.Item = value;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000034B0 File Offset: 0x000016B0
		public void AddProperty(string name, double value)
		{
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = this.Add(name);
			ct_Property.ItemElementName = global::NPOI.OpenXmlFormats.ItemChoiceType.r8;
			ct_Property.Item = value;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000034CC File Offset: 0x000016CC
		public void AddProperty(string name, int value)
		{
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = this.Add(name);
			ct_Property.ItemElementName = global::NPOI.OpenXmlFormats.ItemChoiceType.i4;
			ct_Property.Item = value;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000034E8 File Offset: 0x000016E8
		public void AddProperty(string name, bool value)
		{
			global::NPOI.OpenXmlFormats.CT_Property ct_Property = this.Add(name);
			ct_Property.ItemElementName = global::NPOI.OpenXmlFormats.ItemChoiceType.@bool;
			ct_Property.Item = value;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003504 File Offset: 0x00001704
		protected int NextPid()
		{
			int num = 1;
			foreach (global::NPOI.OpenXmlFormats.CT_Property ct_Property in this.props.GetProperties().GetPropertyList())
			{
				if (ct_Property.pid > num)
				{
					num = ct_Property.pid;
				}
			}
			return num + 1;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003570 File Offset: 0x00001770
		public bool Contains(string name)
		{
			using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.CT_Property>.Enumerator enumerator = this.props.GetProperties().GetPropertyList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.name.Equals(name))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000035DC File Offset: 0x000017DC
		public global::NPOI.OpenXmlFormats.CT_Property GetProperty(string name)
		{
			foreach (global::NPOI.OpenXmlFormats.CT_Property ct_Property in this.props.GetProperties().GetPropertyList())
			{
				if (ct_Property.name.Equals(name))
				{
					return ct_Property;
				}
			}
			return null;
		}

		// Token: 0x04000013 RID: 19
		public static string FORMAT_ID = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}";

		// Token: 0x04000014 RID: 20
		public global::NPOI.OpenXmlFormats.CustomPropertiesDocument props;
	}
}
