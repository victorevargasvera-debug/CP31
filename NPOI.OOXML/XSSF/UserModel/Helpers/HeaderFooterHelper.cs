using System;
using System.Text;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000AA RID: 170
	public class HeaderFooterHelper
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x00029411 File Offset: 0x00027611
		public string GetLeftSection(string str)
		{
			return this.GetParts(str)[0];
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002941C File Offset: 0x0002761C
		public string GetCenterSection(string str)
		{
			return this.GetParts(str)[1];
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00029427 File Offset: 0x00027627
		public string GetRightSection(string str)
		{
			return this.GetParts(str)[2];
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00029434 File Offset: 0x00027634
		public string SetLeftSection(string str, string newLeft)
		{
			string[] parts = this.GetParts(str);
			parts[0] = newLeft;
			return this.JoinParts(parts);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00029454 File Offset: 0x00027654
		public string SetCenterSection(string str, string newCenter)
		{
			string[] parts = this.GetParts(str);
			parts[1] = newCenter;
			return this.JoinParts(parts);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00029474 File Offset: 0x00027674
		public string SetRightSection(string str, string newRight)
		{
			string[] parts = this.GetParts(str);
			parts[2] = newRight;
			return this.JoinParts(parts);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00029494 File Offset: 0x00027694
		private string[] GetParts(string str)
		{
			string[] array = new string[]
			{
				"",
				"",
				""
			};
			if (str == null)
			{
				return array;
			}
			int num;
			int num2;
			int num3;
			while ((num = str.IndexOf(global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_L)) > -2 && (num2 = str.IndexOf(global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_C)) > -2 && (num3 = str.IndexOf(global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_R)) > -2 && (num > -1 || num2 > -1 || num3 > -1))
			{
				if (num3 > num2 && num3 > num)
				{
					array[2] = str.Substring(num3 + global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_R.Length);
					str = str.Substring(0, num3);
				}
				else if (num2 > num3 && num2 > num)
				{
					array[1] = str.Substring(num2 + global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_C.Length);
					str = str.Substring(0, num2);
				}
				else
				{
					array[0] = str.Substring(num + global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_L.Length);
					str = str.Substring(0, num);
				}
			}
			return array;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00029587 File Offset: 0x00027787
		private string JoinParts(string[] parts)
		{
			return this.JoinParts(parts[0], parts[1], parts[2]);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00029598 File Offset: 0x00027798
		private string JoinParts(string l, string c, string r)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (c.Length > 0)
			{
				stringBuilder.Append(global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_C);
				stringBuilder.Append(c);
			}
			if (l.Length > 0)
			{
				stringBuilder.Append(global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_L);
				stringBuilder.Append(l);
			}
			if (r.Length > 0)
			{
				stringBuilder.Append(global::NPOI.XSSF.UserModel.Helpers.HeaderFooterHelper.HeaderFooterEntity_R);
				stringBuilder.Append(r);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040003A3 RID: 931
		private static string HeaderFooterEntity_L = "&L";

		// Token: 0x040003A4 RID: 932
		private static string HeaderFooterEntity_C = "&C";

		// Token: 0x040003A5 RID: 933
		private static string HeaderFooterEntity_R = "&R";

		// Token: 0x040003A6 RID: 934
		public static string HeaderFooterEntity_File = "&F";

		// Token: 0x040003A7 RID: 935
		public static string HeaderFooterEntity_Date = "&D";

		// Token: 0x040003A8 RID: 936
		public static string HeaderFooterEntity_Time = "&T";
	}
}
