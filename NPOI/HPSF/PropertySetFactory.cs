using System;
using System.IO;
using NPOI.HPSF.Wellknown;
using NPOI.POIFS.FileSystem;

namespace NPOI.HPSF
{
	// Token: 0x02000519 RID: 1305
	public class PropertySetFactory
	{
		// Token: 0x060030E6 RID: 12518 RVA: 0x00093D4C File Offset: 0x00091F4C
		public static global::NPOI.HPSF.PropertySet Create(global::NPOI.POIFS.FileSystem.DirectoryEntry dir, string name)
		{
			global::System.IO.Stream stream = null;
			global::NPOI.HPSF.PropertySet result;
			try
			{
				stream = new global::NPOI.POIFS.FileSystem.DocumentInputStream((global::NPOI.POIFS.FileSystem.DocumentEntry)dir.GetEntry(name));
				try
				{
					result = global::NPOI.HPSF.PropertySetFactory.Create(stream);
				}
				catch (global::NPOI.HPSF.MarkUnsupportedException)
				{
					result = null;
				}
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			return result;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x00093DA4 File Offset: 0x00091FA4
		public static global::NPOI.HPSF.PropertySet Create(global::System.IO.Stream stream)
		{
			global::NPOI.HPSF.PropertySet propertySet = new global::NPOI.HPSF.PropertySet(stream);
			global::NPOI.HPSF.PropertySet result;
			try
			{
				if (propertySet.IsSummaryInformation)
				{
					result = new global::NPOI.HPSF.SummaryInformation(propertySet);
				}
				else if (propertySet.IsDocumentSummaryInformation)
				{
					result = new global::NPOI.HPSF.DocumentSummaryInformation(propertySet);
				}
				else
				{
					result = propertySet;
				}
			}
			catch (global::NPOI.HPSF.UnexpectedPropertySetTypeException ex)
			{
				throw new global::System.InvalidOperationException(ex.Message, ex);
			}
			return result;
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x00093E00 File Offset: 0x00092000
		public static global::NPOI.HPSF.SummaryInformation CreateSummaryInformation()
		{
			global::NPOI.HPSF.MutablePropertySet mutablePropertySet = new global::NPOI.HPSF.MutablePropertySet();
			((global::NPOI.HPSF.MutableSection)mutablePropertySet.FirstSection).SetFormatID(global::NPOI.HPSF.Wellknown.SectionIDMap.SUMMARY_INFORMATION_ID);
			global::NPOI.HPSF.SummaryInformation result;
			try
			{
				result = new global::NPOI.HPSF.SummaryInformation(mutablePropertySet);
			}
			catch (global::NPOI.HPSF.UnexpectedPropertySetTypeException reason)
			{
				throw new global::NPOI.HPSF.HPSFRuntimeException(reason);
			}
			return result;
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x00093E48 File Offset: 0x00092048
		public static global::NPOI.HPSF.DocumentSummaryInformation CreateDocumentSummaryInformation()
		{
			global::NPOI.HPSF.MutablePropertySet mutablePropertySet = new global::NPOI.HPSF.MutablePropertySet();
			((global::NPOI.HPSF.MutableSection)mutablePropertySet.FirstSection).SetFormatID(global::NPOI.HPSF.Wellknown.SectionIDMap.DOCUMENT_SUMMARY_INFORMATION_ID1);
			global::NPOI.HPSF.DocumentSummaryInformation result;
			try
			{
				result = new global::NPOI.HPSF.DocumentSummaryInformation(mutablePropertySet);
			}
			catch (global::NPOI.HPSF.UnexpectedPropertySetTypeException reason)
			{
				throw new global::NPOI.HPSF.HPSFRuntimeException(reason);
			}
			return result;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x00093E90 File Offset: 0x00092090
		internal static global::NPOI.HPSF.DocumentSummaryInformation NewDocumentSummaryInformation()
		{
			global::NPOI.HPSF.MutablePropertySet mutablePropertySet = new global::NPOI.HPSF.MutablePropertySet();
			((global::NPOI.HPSF.MutableSection)mutablePropertySet.FirstSection).SetFormatID(global::NPOI.HPSF.Wellknown.SectionIDMap.DOCUMENT_SUMMARY_INFORMATION_ID1);
			global::NPOI.HPSF.DocumentSummaryInformation result;
			try
			{
				result = new global::NPOI.HPSF.DocumentSummaryInformation(mutablePropertySet);
			}
			catch (global::NPOI.HPSF.UnexpectedPropertySetTypeException reason)
			{
				throw new global::NPOI.HPSF.HPSFRuntimeException(reason);
			}
			return result;
		}
	}
}
