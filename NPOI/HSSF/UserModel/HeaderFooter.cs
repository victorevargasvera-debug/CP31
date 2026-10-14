using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000366 RID: 870
	public abstract class HeaderFooter : global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001A48 RID: 6728
		public abstract string RawText { get; }

		// Token: 0x06001A49 RID: 6729 RVA: 0x00050F34 File Offset: 0x0004F134
		private string[] SplitParts()
		{
			string text = this.RawText;
			string text2 = "";
			string text3 = "";
			string text4 = "";
			while (text.Length > 1)
			{
				if (text[0] != '&')
				{
					text3 = text;
					break;
				}
				int num = text.Length;
				char c = text[1];
				if (c != 'C')
				{
					if (c != 'L')
					{
						if (c != 'R')
						{
							text3 = text;
						}
						else
						{
							if (text.IndexOf("&C", global::System.StringComparison.Ordinal) >= 0)
							{
								num = global::System.Math.Min(num, text.IndexOf("&C", global::System.StringComparison.Ordinal));
							}
							if (text.IndexOf("&L", global::System.StringComparison.Ordinal) >= 0)
							{
								num = global::System.Math.Min(num, text.IndexOf("&L", global::System.StringComparison.Ordinal));
							}
							text4 = text.Substring(2, num - 2);
							text = text.Substring(num);
						}
					}
					else
					{
						if (text.IndexOf("&C", global::System.StringComparison.Ordinal) >= 0)
						{
							num = global::System.Math.Min(num, text.IndexOf("&C", global::System.StringComparison.Ordinal));
						}
						if (text.IndexOf("&R", global::System.StringComparison.Ordinal) >= 0)
						{
							num = global::System.Math.Min(num, text.IndexOf("&R", global::System.StringComparison.Ordinal));
						}
						text2 = text.Substring(2, num - 2);
						text = text.Substring(num);
					}
				}
				else
				{
					if (text.IndexOf("&L", global::System.StringComparison.Ordinal) >= 0)
					{
						num = global::System.Math.Min(num, text.IndexOf("&L", global::System.StringComparison.Ordinal));
					}
					if (text.IndexOf("&R", global::System.StringComparison.Ordinal) >= 0)
					{
						num = global::System.Math.Min(num, text.IndexOf("&R", global::System.StringComparison.Ordinal));
					}
					text3 = text.Substring(2, num - 2);
					text = text.Substring(num);
				}
			}
			return new string[]
			{
				text2,
				text3,
				text4
			};
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000510DC File Offset: 0x0004F2DC
		private void UpdatePart(int partIndex, string newValue)
		{
			string[] array = this.SplitParts();
			array[partIndex] = ((newValue == null) ? "" : newValue);
			this.UpdateHeaderFooterText(array);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00051108 File Offset: 0x0004F308
		private void UpdateHeaderFooterText(string[] parts)
		{
			string text = parts[0];
			string text2 = parts[1];
			string text3 = parts[2];
			if (text2.Length < 1 && text.Length < 1 && text3.Length < 1)
			{
				this.SetHeaderFooterText(string.Empty);
				return;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append("&C");
			stringBuilder.Append(text2);
			stringBuilder.Append("&L");
			stringBuilder.Append(text);
			stringBuilder.Append("&R");
			stringBuilder.Append(text3);
			string headerFooterText = stringBuilder.ToString();
			this.SetHeaderFooterText(headerFooterText);
		}

		// Token: 0x06001A4D RID: 6733
		protected abstract void SetHeaderFooterText(string text);

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00051198 File Offset: 0x0004F398
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x000511A2 File Offset: 0x0004F3A2
		public string Left
		{
			get
			{
				return this.SplitParts()[0];
			}
			set
			{
				this.UpdatePart(0, value);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000511AC File Offset: 0x0004F3AC
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x000511B6 File Offset: 0x0004F3B6
		public string Center
		{
			get
			{
				return this.SplitParts()[1];
			}
			set
			{
				this.UpdatePart(1, value);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000511C0 File Offset: 0x0004F3C0
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x000511CA File Offset: 0x0004F3CA
		public string Right
		{
			get
			{
				return this.SplitParts()[2];
			}
			set
			{
				this.UpdatePart(2, value);
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000511D4 File Offset: 0x0004F3D4
		public static string FontSize(short size)
		{
			return "&" + size.ToString();
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000511E7 File Offset: 0x0004F3E7
		public static string Font(string font, string style)
		{
			return string.Concat(new string[]
			{
				"&\"",
				font,
				",",
				style,
				"\""
			});
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00051214 File Offset: 0x0004F414
		public static string Page
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.PAGE_FIELD.sequence;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00051220 File Offset: 0x0004F420
		public static string NumPages
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.NUM_PAGES_FIELD.sequence;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0005122C File Offset: 0x0004F42C
		public static string Date
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.DATE_FIELD.sequence;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00051238 File Offset: 0x0004F438
		public static string Time
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.TIME_FIELD.sequence;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00051244 File Offset: 0x0004F444
		public static string File
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.FILE_FIELD.sequence;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00051250 File Offset: 0x0004F450
		public static string Tab
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.SHEET_NAME_FIELD.sequence;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0005125C File Offset: 0x0004F45C
		public static string StartBold
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.BOLD_FIELD.sequence;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x0005125C File Offset: 0x0004F45C
		public static string EndBold
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.BOLD_FIELD.sequence;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00051268 File Offset: 0x0004F468
		public static string StartUnderline
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.UNDERLINE_FIELD.sequence;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x00051268 File Offset: 0x0004F468
		public static string EndUnderline
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.UNDERLINE_FIELD.sequence;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00051274 File Offset: 0x0004F474
		public static string StartDoubleUnderline
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.DOUBLE_UNDERLINE_FIELD.sequence;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00051274 File Offset: 0x0004F474
		public static string EndDoubleUnderline
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.DOUBLE_UNDERLINE_FIELD.sequence;
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00051280 File Offset: 0x0004F480
		public static string StripFields(string text)
		{
			if (text == null || text.Length == 0)
			{
				return text;
			}
			foreach (global::NPOI.HSSF.UserModel.HeaderFooter.Field field in global::NPOI.HSSF.UserModel.HeaderFooter.Fields.AllFields)
			{
				string sequence = field.sequence;
				int num;
				while ((num = text.IndexOf(sequence, global::System.StringComparison.CurrentCulture)) > -1)
				{
					text = text.Substring(0, num) + text.Substring(num + sequence.Length);
				}
			}
			text = global::System.Text.RegularExpressions.Regex.Replace(text, "\\&\\d+", "");
			text = global::System.Text.RegularExpressions.Regex.Replace(text, "\\&\".*?,.*?\"", "");
			return text;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00051328 File Offset: 0x0004F528
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x00051330 File Offset: 0x0004F530
		public bool AreFieldsStripped
		{
			get
			{
				return this.stripFields;
			}
			set
			{
				this.stripFields = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00051339 File Offset: 0x0004F539
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.Field SHEET_NAME_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.SHEET_NAME_FIELD;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00051345 File Offset: 0x0004F545
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.Field DATE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.DATE_FIELD;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00051351 File Offset: 0x0004F551
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.Field FILE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.FILE_FIELD;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0005135D File Offset: 0x0004F55D
		public static global::NPOI.HSSF.UserModel.HeaderFooter.Field FULL_FILE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.FULL_FILE_FIELD;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x00051369 File Offset: 0x0004F569
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.Field PAGE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.PAGE_FIELD;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00051375 File Offset: 0x0004F575
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.Field TIME_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.TIME_FIELD;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00051381 File Offset: 0x0004F581
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.Field NUM_PAGES_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.NUM_PAGES_FIELD;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0005138D File Offset: 0x0004F58D
		public static global::NPOI.HSSF.UserModel.HeaderFooter.Field PICTURE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.PICTURE_FIELD;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00051399 File Offset: 0x0004F599
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.PairField BOLD_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.BOLD_FIELD;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x000513A5 File Offset: 0x0004F5A5
		public static global::NPOI.HSSF.UserModel.HeaderFooter.PairField ITALIC_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.ITALIC_FIELD;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x000513B1 File Offset: 0x0004F5B1
		public static global::NPOI.HSSF.UserModel.HeaderFooter.PairField STRIKETHROUGH_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.STRIKETHROUGH_FIELD;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x000513BD File Offset: 0x0004F5BD
		public static global::NPOI.HSSF.UserModel.HeaderFooter.PairField SUBSCRIPT_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.SUBSCRIPT_FIELD;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x000513C9 File Offset: 0x0004F5C9
		public static global::NPOI.HSSF.UserModel.HeaderFooter.PairField SUPERSCRIPT_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.SUPERSCRIPT_FIELD;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x000513D5 File Offset: 0x0004F5D5
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.PairField UNDERLINE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.UNDERLINE_FIELD;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x000513E1 File Offset: 0x0004F5E1
		internal static global::NPOI.HSSF.UserModel.HeaderFooter.PairField DOUBLE_UNDERLINE_FIELD
		{
			get
			{
				return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.DOUBLE_UNDERLINE_FIELD;
			}
		}

		// Token: 0x04000B19 RID: 2841
		protected bool stripFields;

		// Token: 0x020005FF RID: 1535
		public class Field
		{
			// Token: 0x17000DFB RID: 3579
			// (get) Token: 0x0600361E RID: 13854 RVA: 0x000A5992 File Offset: 0x000A3B92
			[global::System.Obsolete("Use the generic list Fields.AllFields instead.")]
			public static global::System.Collections.ArrayList ALL_FIELDS
			{
				get
				{
					return new global::System.Collections.ArrayList(global::NPOI.HSSF.UserModel.HeaderFooter.Fields.AllFields);
				}
			}

			// Token: 0x0600361F RID: 13855 RVA: 0x000A599E File Offset: 0x000A3B9E
			public Field(global::NPOI.HSSF.UserModel.HeaderFooter.Fields fields, string sequence)
			{
				this.sequence = sequence;
				fields.Add(this);
			}

			// Token: 0x04001A33 RID: 6707
			public string sequence;
		}

		// Token: 0x02000600 RID: 1536
		public class PairField : global::NPOI.HSSF.UserModel.HeaderFooter.Field
		{
			// Token: 0x06003620 RID: 13856 RVA: 0x000A59B4 File Offset: 0x000A3BB4
			public PairField(global::NPOI.HSSF.UserModel.HeaderFooter.Fields fields, string sequence) : base(fields, sequence)
			{
			}
		}

		// Token: 0x02000601 RID: 1537
		public class Fields
		{
			// Token: 0x17000DFC RID: 3580
			// (get) Token: 0x06003621 RID: 13857 RVA: 0x000A59BE File Offset: 0x000A3BBE
			public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::NPOI.HSSF.UserModel.HeaderFooter.Field> AllFields
			{
				get
				{
					return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.Instance.allFields.AsReadOnly();
				}
			}

			// Token: 0x17000DFD RID: 3581
			// (get) Token: 0x06003622 RID: 13858 RVA: 0x000A59CF File Offset: 0x000A3BCF
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field SHEET_NAME_FIELD
			{
				get
				{
					return this._sheetnamefield;
				}
			}

			// Token: 0x17000DFE RID: 3582
			// (get) Token: 0x06003623 RID: 13859 RVA: 0x000A59D7 File Offset: 0x000A3BD7
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field DATE_FIELD
			{
				get
				{
					return this._datefield;
				}
			}

			// Token: 0x17000DFF RID: 3583
			// (get) Token: 0x06003624 RID: 13860 RVA: 0x000A59DF File Offset: 0x000A3BDF
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field FILE_FIELD
			{
				get
				{
					return this._filefield;
				}
			}

			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x06003625 RID: 13861 RVA: 0x000A59E7 File Offset: 0x000A3BE7
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field FULL_FILE_FIELD
			{
				get
				{
					return this._fullfilefield;
				}
			}

			// Token: 0x17000E01 RID: 3585
			// (get) Token: 0x06003626 RID: 13862 RVA: 0x000A59EF File Offset: 0x000A3BEF
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field PAGE_FIELD
			{
				get
				{
					return this._pagefield;
				}
			}

			// Token: 0x17000E02 RID: 3586
			// (get) Token: 0x06003627 RID: 13863 RVA: 0x000A59F7 File Offset: 0x000A3BF7
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field TIME_FIELD
			{
				get
				{
					return this._timefield;
				}
			}

			// Token: 0x17000E03 RID: 3587
			// (get) Token: 0x06003628 RID: 13864 RVA: 0x000A59FF File Offset: 0x000A3BFF
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field NUM_PAGES_FIELD
			{
				get
				{
					return this._numpagesfield;
				}
			}

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x06003629 RID: 13865 RVA: 0x000A5A07 File Offset: 0x000A3C07
			public global::NPOI.HSSF.UserModel.HeaderFooter.Field PICTURE_FIELD
			{
				get
				{
					return this._picturefield;
				}
			}

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x0600362A RID: 13866 RVA: 0x000A5A0F File Offset: 0x000A3C0F
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField BOLD_FIELD
			{
				get
				{
					return this._boldfield;
				}
			}

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x0600362B RID: 13867 RVA: 0x000A5A17 File Offset: 0x000A3C17
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField ITALIC_FIELD
			{
				get
				{
					return this._italicfield;
				}
			}

			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x0600362C RID: 13868 RVA: 0x000A5A1F File Offset: 0x000A3C1F
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField STRIKETHROUGH_FIELD
			{
				get
				{
					return this._strikethroughfield;
				}
			}

			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x0600362D RID: 13869 RVA: 0x000A5A27 File Offset: 0x000A3C27
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField SUBSCRIPT_FIELD
			{
				get
				{
					return this._subscriptfield;
				}
			}

			// Token: 0x17000E09 RID: 3593
			// (get) Token: 0x0600362E RID: 13870 RVA: 0x000A5A2F File Offset: 0x000A3C2F
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField SUPERSCRIPT_FIELD
			{
				get
				{
					return this._superscriptfield;
				}
			}

			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x0600362F RID: 13871 RVA: 0x000A5A37 File Offset: 0x000A3C37
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField UNDERLINE_FIELD
			{
				get
				{
					return this._underlinefield;
				}
			}

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x06003630 RID: 13872 RVA: 0x000A5A3F File Offset: 0x000A3C3F
			public global::NPOI.HSSF.UserModel.HeaderFooter.PairField DOUBLE_UNDERLINE_FIELD
			{
				get
				{
					return this._doubleunderlinefield;
				}
			}

			// Token: 0x06003632 RID: 13874 RVA: 0x000A5A54 File Offset: 0x000A3C54
			private Fields()
			{
				this._sheetnamefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&A");
				this._datefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&D");
				this._filefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&F");
				this._fullfilefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&Z");
				this._pagefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&P");
				this._timefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&T");
				this._numpagesfield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&N");
				this._picturefield = new global::NPOI.HSSF.UserModel.HeaderFooter.Field(this, "&G");
				this._boldfield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&B");
				this._italicfield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&I");
				this._strikethroughfield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&S");
				this._subscriptfield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&Y");
				this._superscriptfield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&X");
				this._underlinefield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&U");
				this._doubleunderlinefield = new global::NPOI.HSSF.UserModel.HeaderFooter.PairField(this, "&E");
			}

			// Token: 0x17000E0C RID: 3596
			// (get) Token: 0x06003633 RID: 13875 RVA: 0x000A5B71 File Offset: 0x000A3D71
			public static global::NPOI.HSSF.UserModel.HeaderFooter.Fields Instance
			{
				get
				{
					return global::NPOI.HSSF.UserModel.HeaderFooter.Fields.instance;
				}
			}

			// Token: 0x06003634 RID: 13876 RVA: 0x000A5B78 File Offset: 0x000A3D78
			internal void Add(global::NPOI.HSSF.UserModel.HeaderFooter.Field field)
			{
				this.allFields.Add(field);
			}

			// Token: 0x04001A34 RID: 6708
			private global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HeaderFooter.Field> allFields = new global::System.Collections.Generic.List<global::NPOI.HSSF.UserModel.HeaderFooter.Field>();

			// Token: 0x04001A35 RID: 6709
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _sheetnamefield;

			// Token: 0x04001A36 RID: 6710
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _filefield;

			// Token: 0x04001A37 RID: 6711
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _fullfilefield;

			// Token: 0x04001A38 RID: 6712
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _pagefield;

			// Token: 0x04001A39 RID: 6713
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _datefield;

			// Token: 0x04001A3A RID: 6714
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _timefield;

			// Token: 0x04001A3B RID: 6715
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _numpagesfield;

			// Token: 0x04001A3C RID: 6716
			private global::NPOI.HSSF.UserModel.HeaderFooter.Field _picturefield;

			// Token: 0x04001A3D RID: 6717
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _boldfield;

			// Token: 0x04001A3E RID: 6718
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _italicfield;

			// Token: 0x04001A3F RID: 6719
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _strikethroughfield;

			// Token: 0x04001A40 RID: 6720
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _subscriptfield;

			// Token: 0x04001A41 RID: 6721
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _superscriptfield;

			// Token: 0x04001A42 RID: 6722
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _underlinefield;

			// Token: 0x04001A43 RID: 6723
			private global::NPOI.HSSF.UserModel.HeaderFooter.PairField _doubleunderlinefield;

			// Token: 0x04001A44 RID: 6724
			private static readonly global::NPOI.HSSF.UserModel.HeaderFooter.Fields instance = new global::NPOI.HSSF.UserModel.HeaderFooter.Fields();
		}
	}
}
