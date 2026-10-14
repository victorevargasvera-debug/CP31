using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.IO;
using NPOI.Util.Collections;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000391 RID: 913
	internal class StaticFontMetrics
	{
		// Token: 0x06001F1F RID: 7967 RVA: 0x0005FB20 File Offset: 0x0005DD20
		public static global::NPOI.HSSF.UserModel.FontDetails GetFontDetails(global::System.Drawing.Font font)
		{
			if (global::NPOI.HSSF.UserModel.StaticFontMetrics.fontMetricsProps == null)
			{
				global::System.IO.Stream stream = null;
				try
				{
					global::NPOI.HSSF.UserModel.StaticFontMetrics.fontMetricsProps = new global::NPOI.Util.Collections.Properties();
					string text = null;
					try
					{
						text = global::System.Configuration.ConfigurationManager.AppSettings["font.metrics.filename"];
					}
					catch (global::System.Exception)
					{
					}
					if (text != null)
					{
						if (!global::System.IO.File.Exists(text))
						{
							throw new global::System.IO.FileNotFoundException("font_metrics.properties not found at path " + global::System.IO.Path.GetFullPath(text));
						}
						stream = typeof(global::NPOI.HSSF.UserModel.StaticFontMetrics).Assembly.GetManifestResourceStream("font_metrics.properties");
					}
					else
					{
						stream = typeof(global::NPOI.HSSF.UserModel.StaticFontMetrics).Assembly.GetManifestResourceStream("font_metrics.properties");
						if (stream == null)
						{
							throw new global::System.IO.FileNotFoundException("font_metrics.properties not found in classpath");
						}
					}
					global::NPOI.HSSF.UserModel.StaticFontMetrics.fontMetricsProps.Load(stream);
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::System.Exception("Could not Load font metrics: " + ex.Message);
				}
				finally
				{
					if (stream != null)
					{
						try
						{
							stream.Close();
						}
						catch (global::System.IO.IOException)
						{
						}
					}
				}
			}
			string text2 = font.FontFamily.Name;
			string text3 = "";
			if (font.Bold)
			{
				text3 += "bold";
			}
			if (font.Italic)
			{
				text3 += "italic";
			}
			if (global::NPOI.HSSF.UserModel.StaticFontMetrics.fontMetricsProps[global::NPOI.HSSF.UserModel.FontDetails.BuildFontHeightProperty(text2)] == null && global::NPOI.HSSF.UserModel.StaticFontMetrics.fontMetricsProps[global::NPOI.HSSF.UserModel.FontDetails.BuildFontHeightProperty(text2 + "." + text3)] != null)
			{
				text2 = text2 + "." + text3;
			}
			if (global::NPOI.HSSF.UserModel.StaticFontMetrics.fontDetailsMap[text2] == null)
			{
				global::NPOI.HSSF.UserModel.FontDetails fontDetails = global::NPOI.HSSF.UserModel.FontDetails.Create(text2, global::NPOI.HSSF.UserModel.StaticFontMetrics.fontMetricsProps);
				global::NPOI.HSSF.UserModel.StaticFontMetrics.fontDetailsMap[text2] = fontDetails;
				return fontDetails;
			}
			return (global::NPOI.HSSF.UserModel.FontDetails)global::NPOI.HSSF.UserModel.StaticFontMetrics.fontDetailsMap[text2];
		}

		// Token: 0x04000BC9 RID: 3017
		private const string FONT_METRICS_PROPERTIES_FILE_NAME = "font_metrics.properties";

		// Token: 0x04000BCA RID: 3018
		private static global::NPOI.Util.Collections.Properties fontMetricsProps;

		// Token: 0x04000BCB RID: 3019
		private static global::System.Collections.Hashtable fontDetailsMap = new global::System.Collections.Hashtable();
	}
}
