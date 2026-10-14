using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.DragDrop
{
	// Token: 0x02000012 RID: 18
	public class StringToDragDropChannelsCollectionConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x0000603A File Offset: 0x0000423A
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000604C File Offset: 0x0000424C
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				string[] array = text.Split(new char[]
				{
					','
				});
				global::System.Collections.ObjectModel.ObservableCollection<string> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<string>();
				foreach (string text2 in array)
				{
					observableCollection.Add(text2.Trim());
				}
				return observableCollection;
			}
			return null;
		}
	}
}
