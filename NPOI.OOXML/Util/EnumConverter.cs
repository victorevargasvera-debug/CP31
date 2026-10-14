using System;
using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;

namespace NPOI.Util
{
	// Token: 0x020000EF RID: 239
	public static class EnumConverter
	{
		// Token: 0x06000EBE RID: 3774 RVA: 0x00033B94 File Offset: 0x00031D94
		public static global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc ValueOf(global::NPOI.XWPF.UserModel.ParagraphAlignment val)
		{
			switch (val)
			{
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.CENTER:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.center;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.RIGHT:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.right;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.BOTH:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.both;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.MEDIUM_KASHIDA:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.mediumKashida;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.DISTRIBUTE:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.distribute;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.NUM_TAB:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.numTab;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.HIGH_KASHIDA:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.highKashida;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.LOW_KASHIDA:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.lowKashida;
			case global::NPOI.XWPF.UserModel.ParagraphAlignment.THAI_DISTRIBUTE:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.thaiDistribute;
			default:
				return global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.left;
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00033BE3 File Offset: 0x00031DE3
		public static global::NPOI.XWPF.UserModel.ParagraphAlignment ValueOf(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc val)
		{
			switch (val)
			{
			case global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.center:
				return global::NPOI.XWPF.UserModel.ParagraphAlignment.CENTER;
			case global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.both:
				return global::NPOI.XWPF.UserModel.ParagraphAlignment.BOTH;
			case global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc.distribute:
				return global::NPOI.XWPF.UserModel.ParagraphAlignment.DISTRIBUTE;
			}
			return global::NPOI.XWPF.UserModel.ParagraphAlignment.LEFT;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00033C0C File Offset: 0x00031E0C
		public static T ValueOf<T, F>(F val)
		{
			string name = global::System.Enum.GetName(val.GetType(), val);
			return (T)((object)global::System.Enum.Parse(typeof(T), name, true));
		}
	}
}
