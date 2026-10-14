using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001BA RID: 442
	public class VersionInfoHelper
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x000F5064 File Offset: 0x000F3264
		public VersionInfoHelper()
		{
			int a_ = 8;
			this.a = global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("瀅洇砉缋服缏簑朓㠕怗眙瀛", a_));
			base..ctor();
			if (!global::System.IO.File.Exists(this.a))
			{
				throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("倅洇砉缋服缏簑㐓瀕焗瘙礛㸝嘟䜡嘣唥䄧䔩䈫崭ḯ䨱夳娵ᠷ吹医䨽怿⑁⭃㍅♇⹉测", a_));
			}
			this.c = global::System.Xml.Linq.XElement.Load(this.a);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000F50D8 File Offset: 0x000F32D8
		public static string GetRMVersion()
		{
			short num = (short)725915774;
			short num2 = num;
			num = (short)480614526;
			switch (num2 == num)
			{
			default:
			{
				num = (short)397344768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1353121793;
			if (num != 0)
			{
			}
			num = (short)976486400;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.b;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000F5188 File Offset: 0x000F3388
		public global::Motorola.CommonCPS.Server.EntityModel.ServerVersion GetServerVersion()
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ServerVersion serverVersion;
			global::System.Xml.Linq.XElement xelement;
			global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.a a;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1881931776;
					short num3 = num2;
					num2 = (short)1751916433;
					short num4 = num2;
					num2 = (short)835657617;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return serverVersion;
					default:
						num2 = (short)1092026368;
						if (num2 != 0)
						{
						}
						if (xelement != null)
						{
							num2 = (short)2068054018;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17B;
					}
					break;
				}
				case 1:
					return serverVersion;
				case 2:
					serverVersion = new global::Motorola.CommonCPS.Server.EntityModel.ServerVersion();
					serverVersion.ID = a.a;
					serverVersion.RMVersion = xelement.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("堉䄋堍甏怑朓缕眗琙", a_)).Value;
					serverVersion.ProductVersion = xelement.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("娉縋愍琏朑眓戕丗缙減洝䤟䴡䨣", a_)).Value;
					num2 = (short)1490550785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_25;
			}
			IL_17B:
			num2 = (short)1419968513;
			if (num2 != 0)
			{
			}
			throw new global::System.Exception(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("変椋簍昏眑易㘕渗缙減洝䤟䴡䨣إ䴧䘩䤫䌭唯就䀳ᘵ嬷嬹刻倽⼿㙁摃⑅ⵇ橉⩋⅍╏㱑こ睕", a_));
			IL_25:
			a = new global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.a();
			serverVersion = null;
			a.a = this.c.Element(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䤉礋簍戏眑稓戕丗缙減洝䤟䴡䨣", a_)).Element(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䤉礋簍戏眑稓戕䬗缙減栝䔟倡爣䌥娧天䔫䄭帯", a_)).Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("変椋簍昏眑易䀕紗栙漛眝伟䰡洣戥", a_)).Value;
			xelement = this.c.Element(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("変椋簍昏眑易䀕紗栙漛眝伟䰡圣", a_)).Elements(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("変椋簍昏眑易䀕紗栙漛眝伟䰡", a_)).Where(new global::System.Func<global::System.Xml.Linq.XElement, bool>(a.b)).FirstOrDefault<global::System.Xml.Linq.XElement>();
			num2 = (short)1883045888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000F53C4 File Offset: 0x000F35C4
		public static bool IsDFlagExisted(global::Motorola.Common.Communication.CommonUtil.DFlagType dft)
		{
			short num = (short)1604481678;
			short num2 = num;
			num = (short)218133134;
			switch (num2 == num)
			{
			default:
			{
				num = (short)890372096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1223819265;
			if (num != 0)
			{
			}
			num = (short)639565824;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.DFlagInfo.IsDFlagExisted(dft);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000F5474 File Offset: 0x000F3674
		// Note: this type is marked as 'beforefieldinit'.
		static VersionInfoHelper()
		{
			int a_ = 1;
			short num = (short)335265598;
			short num2 = num;
			num = (short)1407762238;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1336803328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)21889025;
			if (num != 0)
			{
			}
			num = (short)798752768;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.VersionInfoHelper.b = global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("쿾㌀ⴂ㔄㘆", a_);
		}

		// Token: 0x04000AAE RID: 2734
		private string a;

		// Token: 0x04000AAF RID: 2735
		private static readonly string b;

		// Token: 0x04000AB0 RID: 2736
		private global::System.Xml.Linq.XElement c;

		// Token: 0x020001BB RID: 443
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060016C9 RID: 5833 RVA: 0x000F5550 File Offset: 0x000F3750
			internal bool b(global::System.Xml.Linq.XElement A_0)
			{
				int a_ = 8;
				short num = (short)1610186143;
				short num2 = num;
				num = (short)409107871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)547028992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1461256193;
				if (num != 0)
				{
				}
				num = (short)942997504;
				if (num != 0)
				{
				}
				return A_0.Attribute(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("伅䰇", a_)).Value.Equals(this.a);
			}

			// Token: 0x04000AB1 RID: 2737
			public string a;
		}
	}
}
