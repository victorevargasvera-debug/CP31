using System;
using System.Linq;
using System.Reflection;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x02000010 RID: 16
	public static class ModuleNames
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003908 File Offset: 0x00001B08
		public static bool IsModuleNameMatched(string fieldName, global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier modeInfo)
		{
			short num = (short)753139713;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Reflection.FieldInfo field;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (fieldName.Contains('?'))
					{
						num = (short)1709506565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
					goto IL_5B;
				case 3:
					goto IL_AA;
				case 4:
					goto IL_F6;
				case 5:
				{
					fieldName = fieldName.Replace('?', '_');
					num = (short)1602289664;
					short num3 = num;
					num = (short)1872166915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (field == null)
					{
						num = (short)1083703300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B6;
				}
				IL_40:
				if (fieldName == null)
				{
					num = (short)1450311682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1716584448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AA:
				field = typeof(global::Motorola.CommonCPS.RadioManagement.Global.ModuleNames).GetField(fieldName);
				num = (short)664600582;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5B:
			num = (short)689624192;
			short num4 = num;
			num = (short)1698944128;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14A:
				num = (short)644415489;
				if (num != 0)
				{
				}
				return true;
			default:
				num = (short)1281687552;
				if (num != 0)
				{
				}
				return true;
			}
			IL_F6:
			goto IL_14A;
			IL_1B6:
			return field.GetCustomAttribute<global::Motorola.CommonCPS.RadioManagement.Global.ModeAttribute>().Modes.Contains(modeInfo);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003ADC File Offset: 0x00001CDC
		// Note: this type is marked as 'beforefieldinit'.
		static ModuleNames()
		{
			int a_ = 18;
			short num = (short)1173618688;
			short num2 = num;
			num = (short)1465142230;
			short num3 = num;
			num = (short)701647830;
			switch (num3 == num)
			{
			}
			num = (short)760283136;
			if (num != 0)
			{
			}
			num = (short)380436481;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Global.ModuleNames.TemplateLandPageArray = new string[]
			{
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("蛓럕볗동돛", a_),
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("闓藕賗裙鏛距駟釡郣菥藧", a_),
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("闓藕賗裙鏛髝臟雡藣뛥髧藩諫蟭鳯韱", a_),
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("闓藕賗裙鏛針铟菡難뛥髧藩諫蟭鳯韱", a_),
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.b("黓맕뫗", a_)
			};
		}

		// Token: 0x04000052 RID: 82
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string ApplicationLicense = "ApplicationLicense";

		// Token: 0x04000053 RID: 83
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string ASTRODataProfile = "ASTRODataProfile";

		// Token: 0x04000054 RID: 84
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string ASTROOtarProfile = "ASTROOtarProfile";

		// Token: 0x04000055 RID: 85
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string ASTROSystem = "ASTROSystem";

		// Token: 0x04000056 RID: 86
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string ASTROTemplate = "ASTROTemplate";

		// Token: 0x04000057 RID: 87
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string Firmware = "Firmware";

		// Token: 0x04000058 RID: 88
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string Job = "Job";

		// Token: 0x04000059 RID: 89
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string LanguagePack = "LanguagePack";

		// Token: 0x0400005A RID: 90
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string Radio = "Radio";

		// Token: 0x0400005B RID: 91
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string Template = "Template";

		// Token: 0x0400005C RID: 92
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string RadioLicense = "RadioLicense";

		// Token: 0x0400005D RID: 93
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string VoiceAnnouncement = "VoiceAnnouncement";

		// Token: 0x0400005E RID: 94
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration,
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string CACertificates = "CACertificates";

		// Token: 0x0400005F RID: 95
		[global::Motorola.CommonCPS.RadioManagement.Global.Mode(new global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier[]
		{
			global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template
		})]
		public const string DVRSFiles = "DVRSFiles";

		// Token: 0x04000060 RID: 96
		public const string HomeScreen = "Home";

		// Token: 0x04000061 RID: 97
		public static readonly string[] TemplateLandPageArray;
	}
}
