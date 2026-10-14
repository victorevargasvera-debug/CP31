using System;
using System.Xml;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D9 RID: 473
	internal class DataPresenterObjectSerializer : global::Infragistics.Windows.Internal.ObjectSerializerBase
	{
		// Token: 0x06001B61 RID: 7009 RVA: 0x00075208 File Offset: 0x00073408
		internal DataPresenterObjectSerializer()
		{
			base.RegisterInfo(typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::Infragistics.Windows.DataPresenter.SummaryDefinition.SerializationInfo());
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00075228 File Offset: 0x00073428
		private static void Copy(global::Infragistics.Windows.Controls.ConditionGroup source, global::Infragistics.Windows.Controls.ConditionGroup dest)
		{
			dest.LogicalOperator = source.LogicalOperator;
			dest.Clear();
			foreach (global::Infragistics.Windows.Controls.ICondition item in source)
			{
				dest.Add(item);
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00075284 File Offset: 0x00073484
		private global::System.Xml.XmlElement SaveHelper(object obj)
		{
			global::System.Type type = obj.GetType();
			if (typeof(global::Infragistics.Windows.DataPresenter.RecordFilter) == type)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = (global::Infragistics.Windows.DataPresenter.RecordFilter)obj;
				global::System.Xml.XmlElement xmlElement = base.CreateNewElement("RecordFilter");
				if (base.AppendValueHelper(xmlElement, "FieldName", null, recordFilter.FieldName, typeof(string)) && base.AppendValueHelper(xmlElement, null, null, recordFilter.Conditions, typeof(global::Infragistics.Windows.Controls.ConditionGroup)))
				{
					return xmlElement;
				}
			}
			return null;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000752FC File Offset: 0x000734FC
		private object LoadHelper(global::System.Xml.XmlElement elem)
		{
			string name = elem.Name;
			string a;
			if ((a = name) != null && a == "RecordFilter")
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = new global::Infragistics.Windows.DataPresenter.RecordFilter();
				object obj;
				if (base.ParseAttribute(elem, "FieldName", typeof(string), out obj))
				{
					recordFilter.FieldName = (string)obj;
				}
				if (base.ParseElement(elem.SelectSingleNode("ConditionGroup") as global::System.Xml.XmlElement, typeof(global::Infragistics.Windows.Controls.ConditionGroup), out obj))
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterObjectSerializer.Copy((global::Infragistics.Windows.Controls.ConditionGroup)obj, recordFilter.Conditions);
				}
				return recordFilter;
			}
			return null;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00075386 File Offset: 0x00073586
		protected override bool SaveAsElementOverride(object obj, global::System.Type propertyType, out global::System.Xml.XmlElement element)
		{
			element = this.SaveHelper(obj);
			return element != null || base.SaveAsElementOverride(obj, propertyType, out element);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000753A0 File Offset: 0x000735A0
		protected override bool ParseElementOverride(global::System.Xml.XmlElement element, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = this.LoadHelper(element);
			return (parsedValue != null && (null == propertyType || global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(parsedValue, propertyType))) || base.ParseElementOverride(element, propertyType, out parsedValue);
		}
	}
}
