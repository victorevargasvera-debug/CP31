using System;
using System.IO;
using System.Net.Mail;
using System.Reflection;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000042 RID: 66
	public static class MailMessageExtension
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00018738 File Offset: 0x00016938
		public static void Write(this global::System.Net.Mail.MailMessage message, global::System.IO.MemoryStream ms)
		{
			int a_ = 8;
			short num = (short)2033254400;
			short num2 = num;
			num = (short)633828443;
			short num3 = num;
			num = (short)2108453979;
			switch (num3 == num)
			{
			}
			num = (short)1574174720;
			if (num != 0)
			{
			}
			num = (short)1236598785;
			if (num != 0)
			{
			}
			typeof(global::System.Net.Mail.MailMessage).GetMethod(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("猟䜡䨣䈥", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic).Invoke(message, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic, null, new object[]
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.MailMessageExtension.a(ms),
				false,
				true
			}, null);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00018834 File Offset: 0x00016A34
		private static object a(global::System.IO.MemoryStream A_0)
		{
			int a_ = 10;
			short num = (short)1550319616;
			short num2 = num;
			num = (short)1558357621;
			short num3 = num;
			num = (short)1618126453;
			switch (num3 == num)
			{
			}
			num = (short)1234501632;
			if (num != 0)
			{
			}
			num = (short)82640897;
			if (num != 0)
			{
			}
			return typeof(global::System.Net.Mail.MailMessage).Assembly.GetType(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("無崣唥尧伩䄫-縯圱䀳ᠵ男嬹唻刽渿ཁ╃⽅⑇ᵉ㹋❍⑏㝑♓", a_)).GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic, null, new global::System.Type[]
			{
				typeof(global::System.IO.Stream)
			}, null).Invoke(new object[]
			{
				A_0
			});
		}
	}
}
