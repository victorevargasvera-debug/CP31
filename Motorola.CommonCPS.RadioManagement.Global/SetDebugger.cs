using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x0200000A RID: 10
	public static class SetDebugger
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002C54 File Offset: 0x00000E54
		static SetDebugger()
		{
			global::System.Xml.XmlDocument xmlDocument = null;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				for (;;)
				{
					IL_0E:
					switch (num)
					{
					case 0:
						goto IL_F6;
					case 1:
						if (xmlDocument.DocumentElement != null)
						{
							num2 = (short)1614479365;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_DF;
					case 2:
						if (xmlDocument != null)
						{
							num2 = (short)1816133635;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_DF;
					case 3:
						num2 = (short)687276033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_DF;
					case 5:
						bool.TryParse(xmlDocument.DocumentElement.LastChild.LastChild.Value, out global::Motorola.CommonCPS.RadioManagement.Global.SetDebugger.a);
						num2 = (short)2094202884;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C;
					IL_DF:
					num2 = (short)892076032;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_F6:
				goto IL_1E3;
				IL_2C:
				xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(global::Motorola.CommonCPS.RadioManagement.Global.SetDebugger.ConfigFilePath);
				num2 = (short)250478594;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0E;
			}
			catch
			{
			}
			finally
			{
				num2 = (short)145883136;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					num2 = (short)1501822977;
					if (num2 != 0)
					{
					}
					switch (num)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_159;
						}
						continue;
					case 1:
						goto IL_1E0;
					case 2:
					{
						num2 = (short)87536817;
						short num3 = num2;
						num2 = (short)1877652657;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15F;
						default:
							num2 = (short)684589056;
							if (num2 != 0)
							{
							}
							xmlDocument.RemoveAll();
							xmlDocument = null;
							num2 = (short)845348865;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_159;
					IL_15F:
					num2 = (short)1238695938;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_159:
					if (xmlDocument != null)
					{
						goto IL_15F;
					}
					break;
				}
				IL_1E0:;
			}
			IL_1E3:
			num2 = (short)353304576;
			short num4 = num2;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002E8C File Offset: 0x0000108C
		public static bool IsShowAllSetsInSetMode
		{
			get
			{
				short num = (short)313309008;
				short num2 = num;
				num = (short)313702224;
				switch (num2 == num)
				{
				}
				num = (short)1768685568;
				if (num != 0)
				{
				}
				num = (short)138018816;
				short num3 = num;
				num = (short)863371265;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.SetDebugger.a;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002F3C File Offset: 0x0000113C
		private static string ConfigFilePath
		{
			get
			{
				int a_ = 2;
				short num = (short)914516244;
				short num2 = num;
				num = (short)390162708;
				switch (num2 == num)
				{
				}
				num = (short)635174913;
				if (num != 0)
				{
				}
				num = (short)1968701440;
				short num3 = num;
				num = (short)103022592;
				if (num != 0)
				{
				}
				return global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("闅귇뻉裋ꯍ닏ꟑ돓ꃗ럙냛", a_);
			}
		}

		// Token: 0x04000017 RID: 23
		private static bool a;
	}
}
