using System;
using System.Collections;
using System.IO;
using System.Text;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.Dev
{
	// Token: 0x0200029D RID: 669
	public class POIFSViewEngine
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00036F20 File Offset: 0x00035120
		public static global::System.Collections.IList InspectViewable(object viewable, bool drilldown, int indentLevel, string indentString)
		{
			global::System.Collections.IList list = new global::System.Collections.ArrayList();
			if (viewable is global::System.Collections.DictionaryEntry)
			{
				global::NPOI.POIFS.Dev.POIFSViewEngine.ProcessViewable(((global::System.Collections.DictionaryEntry)viewable).Value, drilldown, indentLevel, indentString, list);
			}
			else if (viewable is global::NPOI.POIFS.Dev.POIFSViewable)
			{
				global::NPOI.POIFS.Dev.POIFSViewEngine.ProcessViewable(viewable, drilldown, indentLevel, indentString, list);
			}
			else
			{
				list.Add(global::NPOI.POIFS.Dev.POIFSViewEngine.Indent(indentLevel, indentString, viewable.ToString()));
			}
			return list;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00036F80 File Offset: 0x00035180
		internal static void ProcessViewable(object viewable, bool drilldown, int indentLevel, string indentString, global::System.Collections.IList objects)
		{
			global::NPOI.POIFS.Dev.POIFSViewable poifsviewable = (global::NPOI.POIFS.Dev.POIFSViewable)viewable;
			objects.Add(global::NPOI.POIFS.Dev.POIFSViewEngine.Indent(indentLevel, indentString, poifsviewable.ShortDescription));
			if (drilldown)
			{
				if (poifsviewable is global::NPOI.POIFS.FileSystem.OPOIFSDocument)
				{
					((global::System.Collections.ArrayList)objects).AddRange(global::NPOI.POIFS.Dev.POIFSViewEngine.InspectViewable("POIFSDocument content is too long so ignored", drilldown, indentLevel + 1, indentString));
					return;
				}
				if (poifsviewable.PreferArray)
				{
					global::System.Array viewableArray = poifsviewable.ViewableArray;
					for (int i = 0; i < viewableArray.Length; i++)
					{
						((global::System.Collections.ArrayList)objects).AddRange(global::NPOI.POIFS.Dev.POIFSViewEngine.InspectViewable(viewableArray.GetValue(i), drilldown, indentLevel + 1, indentString));
					}
					return;
				}
				global::System.Collections.IEnumerator viewableIterator = poifsviewable.ViewableIterator;
				while (viewableIterator.MoveNext())
				{
					object viewable2 = viewableIterator.Current;
					((global::System.Collections.ArrayList)objects).AddRange(global::NPOI.POIFS.Dev.POIFSViewEngine.InspectViewable(viewable2, drilldown, indentLevel + 1, indentString));
				}
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00037040 File Offset: 0x00035240
		private static string Indent(int indentLevel, string indentString, string data)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			for (int i = 0; i < indentLevel; i++)
			{
				stringBuilder2.Append(indentString);
			}
			string result;
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(data))
			{
				for (string value = stringReader.ReadLine(); value != null; value = stringReader.ReadLine())
				{
					stringBuilder.Append(stringBuilder2).Append(value).Append(global::System.Environment.NewLine);
				}
				result = stringBuilder.ToString();
			}
			return result;
		}
	}
}
