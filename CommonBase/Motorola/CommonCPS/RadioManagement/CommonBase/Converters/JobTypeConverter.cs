using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Converters
{
	// Token: 0x02000020 RID: 32
	public class JobTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00017CEC File Offset: 0x00015EEC
		public JobTypeConverter(global::Motorola.CommonCPS.ResourceRepository.IResourceResolver resourceResolver)
		{
			int a_ = 6;
			this.b = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.JobType, string>
			{
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read,
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ၙ㍛㱝㑟᭡ᑣͥ㝧㡩५཭ᑯ", a_)
				},
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Switchover,
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ၙ㍛㱝㑟᭡ᑣͥ㝧㥩᭫ݭѯᅱᱳ᥵๷ό๻", a_)
				},
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset,
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ၙ㍛㱝㑟᭡ᑣͥ㝧Ⱪ൫൭ѯᵱٳཱུ⩷όཻ᭽", a_)
				},
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover,
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ၙ㍛㱝㑟᭡ᑣͥ㝧㵩ṫݭѯ᝱㩳᥵⭷൹ᕻ੽", a_)
				},
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover,
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ၙ㍛㱝㑟᭡ᑣͥ㝧㵩ṫݭѯ᝱㕳ᡵᱷ⥹୻᝽ﺇﺋ", a_)
				}
			};
			base..ctor();
			this.a = resourceResolver;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00017D84 File Offset: 0x00015F84
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			while (!(value is global::Motorola.CommonCPS.Server.CommonDBConstants.JobType))
			{
				short num = (short)1695186699;
				short num2 = num;
				num = (short)2033745675;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)555876353;
					if (num != 0)
					{
					}
					num = (short)827916288;
					if (num != 0)
					{
					}
					num = (short)850132992;
					short num3 = num;
					return null;
				}
				}
			}
			return this.ConvertJobTypeToString((global::Motorola.CommonCPS.Server.CommonDBConstants.JobType)value);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00017E48 File Offset: 0x00016048
		public string ConvertJobTypeToString(global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType)
		{
			int a_ = 15;
			short num = (short)1009778689;
			int num2 = (int)((global::System.IntPtr)num);
			string key;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_57;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					if (!this.b.TryGetValue(jobType, out key))
					{
						goto IL_16A;
					}
					num = (short)1734485858;
					short num3 = num;
					num = (short)2086086498;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16A;
					default:
						num = (short)972881920;
						if (num != 0)
						{
						}
						num = (short)588578819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_14B;
				}
				IL_3D:
				if (jobType == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover)
				{
					num = (short)1982922752;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)651689984;
					short num4 = num;
					num = (short)694878210;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_57:
			num = (short)1125777409;
			if (num != 0)
			{
			}
			return this.a.GetString(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⥢੤զ㵨ቪᵬ੮⹰⑲ݴṶ൸Ṻ", a_));
			IL_14B:
			return this.a.GetString(key);
			IL_16A:
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00017FC0 File Offset: 0x000161C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1795698593;
			short num2 = num;
			num = (short)1411133345;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1106116608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)524353537;
			if (num != 0)
			{
			}
			num = (short)416415744;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x04000045 RID: 69
		private readonly global::Motorola.CommonCPS.ResourceRepository.IResourceResolver a;

		// Token: 0x04000046 RID: 70
		private readonly global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.JobType, string> b;
	}
}
