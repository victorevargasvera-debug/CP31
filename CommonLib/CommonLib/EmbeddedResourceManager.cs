using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x02000014 RID: 20
	public class EmbeddedResourceManager
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000109F4 File Offset: 0x0000EBF4
		public static global::System.IO.StreamReader GetStreamReader(global::System.Reflection.Assembly assembly, string resourceName)
		{
			global::System.IO.Stream stream;
			short num;
			for (;;)
			{
				stream = global::Motorola.Common.CommonLib.EmbeddedResourceManager.a(assembly, resourceName);
				if (stream != null)
				{
					break;
				}
				num = (short)2022834177;
				if (num != 0)
				{
				}
				num = (short)818530339;
				short num2 = num;
				num = (short)1644349475;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_98;
				}
			}
			num = (short)946798592;
			short num3 = num;
			return new global::System.IO.StreamReader(stream);
			IL_98:
			num = (short)558628864;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		public static global::System.IO.Stream GetStream(global::System.Reflection.Assembly assembly, string resourceName)
		{
			short num = (short)215846879;
			short num2 = num;
			num = (short)153653215;
			switch (num2 == num)
			{
			}
			num = (short)33947649;
			if (num != 0)
			{
			}
			num = (short)330629120;
			if (num != 0)
			{
			}
			num = (short)1017446400;
			short num3 = num;
			return global::Motorola.Common.CommonLib.EmbeddedResourceManager.a(assembly, resourceName);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00010B60 File Offset: 0x0000ED60
		public static T GetResource<T>(global::System.Reflection.Assembly assembly, string resourceName) where T : class
		{
			short num = (short)2009399296;
			short num2 = num;
			global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EmbeddedResourceManager.a(assembly, resourceName);
			T t;
			try
			{
				num = (short)1824784385;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_D7;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 2:
						t = default(T);
						t = t;
						num = (short)2130509827;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_A0;
					}
					IL_68:
					if (stream == null)
					{
						num = (short)1379139586;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						t = (T)((object)new global::System.Xml.Serialization.XmlSerializer(typeof(T)).Deserialize(stream));
						num = (short)797835264;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A0:
				IL_D7:;
			}
			finally
			{
				num = (short)1976790126;
				short num4 = num;
				num = (short)1383427182;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)614662145;
					if (num != 0)
					{
					}
					num = (short)1769668608;
					if (num != 0)
					{
					}
					num = (short)930676737;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1B5;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_180;
							}
							continue;
						case 2:
							((global::System.IDisposable)stream).Dispose();
							num = (short)755105792;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_180:
						if (stream == null)
						{
							break;
						}
						num = (short)1499922434;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1B5:
					break;
				}
				}
			}
			return t;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00010D38 File Offset: 0x0000EF38
		private static global::System.IO.Stream a(global::System.Reflection.Assembly A_0, string A_1)
		{
			int a_ = 3;
			short num = (short)820641792;
			switch (num)
			{
			default:
			{
				num = (short)748093441;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.IO.Stream stream;
				for (;;)
				{
					num = (short)661061632;
					short num3 = num;
					string name;
					switch (num2)
					{
					case 0:
						return stream;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					case 2:
					{
						num = (short)914817025;
						if (num != 0)
						{
						}
						name = A_1;
						string text = A_1.Replace(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⤆䀈䨊", a_), string.Empty).Replace(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⤆笈昊", a_), string.Empty);
						num = (short)935723011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_10D;
					case 4:
					{
						string text;
						stream = A_0.GetManifestResourceStream(text);
						num = (short)1692794880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)703594500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0;
					}
					case 6:
						goto IL_1C5;
					case 7:
						goto IL_10D;
					case 8:
						if (stream == null)
						{
							num = (short)873529354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0;
					case 9:
					{
						num = (short)2101789871;
						short num4 = num;
						num = (short)203932847;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10D;
						default:
							goto IL_1FF;
						}
						break;
					}
					case 10:
						num = (short)1644101637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (A_1.EndsWith(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⤆笈昊", a_), global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)1420296194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string name2 = A_0.GetName().Name;
						name = A_1.Replace(name2, name2 + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⤆䀈䨊", a_)) + global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("⤆笈昊", a_);
						string text = A_1;
						num = (short)1742667783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A7:
					if (string.IsNullOrEmpty(A_1))
					{
						num = (short)578682889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)410714123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D:
					stream = A_0.GetManifestResourceStream(name);
					num = (short)1346633736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A0:
					stream = global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.Instance.DecryptStreamToStream(stream, false);
					num = (short)1569128454;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C5:
				return stream;
				IL_1FF:
				num = (short)701759488;
				if (num != 0)
				{
				}
				return null;
			}
			}
		}

		// Token: 0x0400005E RID: 94
		private const string a = ".IA";

		// Token: 0x0400005F RID: 95
		private const string b = ".rm";
	}
}
