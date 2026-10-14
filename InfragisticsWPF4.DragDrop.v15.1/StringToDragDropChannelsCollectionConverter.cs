using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.DragDrop
{
	// Token: 0x02000012 RID: 18
	public class StringToDragDropChannelsCollectionConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x000061CE File Offset: 0x000043CE
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000061E0 File Offset: 0x000043E0
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
