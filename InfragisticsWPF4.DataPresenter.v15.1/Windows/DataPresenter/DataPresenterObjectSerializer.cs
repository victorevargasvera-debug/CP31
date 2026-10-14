using System;
using System.Xml;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000202 RID: 514
	internal class DataPresenterObjectSerializer : global::Infragistics.Windows.Internal.ObjectSerializerBase
	{
		// Token: 0x06001F71 RID: 8049 RVA: 0x0008904C File Offset: 0x0008724C
		internal DataPresenterObjectSerializer()
		{
			base.RegisterInfo(typeof(global::Infragistics.Windows.DataPresenter.SummaryDefinition), new global::Infragistics.Windows.DataPresenter.SummaryDefinition.SerializationInfo());
			base.RegisterInfo(typeof(global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings), new global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo(typeof(global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings), () => new global::Infragistics.Windows.DataPresenter.Calculations.FieldCalculationSettings(), false));
			base.RegisterInfo(typeof(global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings), new global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo(typeof(global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings), () => new global::Infragistics.Windows.DataPresenter.Calculations.SummaryCalculationSettings(), false));
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000890F0 File Offset: 0x000872F0
		private static void Copy(global::Infragistics.Windows.Controls.ConditionGroup source, global::Infragistics.Windows.Controls.ConditionGroup dest)
		{
			dest.LogicalOperator = source.LogicalOperator;
			dest.Clear();
			foreach (global::Infragistics.Windows.Controls.ICondition item in source)
			{
				dest.Add(item);
			}
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0008914C File Offset: 0x0008734C
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

		// Token: 0x06001F74 RID: 8052 RVA: 0x000891C4 File Offset: 0x000873C4
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

		// Token: 0x06001F75 RID: 8053 RVA: 0x0008924E File Offset: 0x0008744E
		internal void RegisterFieldTypeForAttributeParsing(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.RegisterType(field.DataType);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0008925B File Offset: 0x0008745B
		protected override bool SaveAsElementOverride(object obj, global::System.Type propertyType, out global::System.Xml.XmlElement element)
		{
			element = this.SaveHelper(obj);
			return element != null || base.SaveAsElementOverride(obj, propertyType, out element);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00089275 File Offset: 0x00087475
		protected override bool ParseElementOverride(global::System.Xml.XmlElement element, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = this.LoadHelper(element);
			return (parsedValue != null && (null == propertyType || global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(parsedValue, propertyType))) || base.ParseElementOverride(element, propertyType, out parsedValue);
		}
	}
}
