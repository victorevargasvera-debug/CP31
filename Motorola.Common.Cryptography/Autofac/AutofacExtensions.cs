using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Core;
using Autofac.Core.Resolving;

namespace Motorola.Common.Cryptography.Autofac
{
	// Token: 0x02000032 RID: 50
	public static class AutofacExtensions
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00007458 File Offset: 0x00005658
		static AutofacExtensions()
		{
			int a_ = 8;
			short num = (short)1734213633;
			if (num != 0)
			{
			}
			num = (short)2114132936;
			short num2 = num;
			num = (short)1505237960;
			switch (num2 == num)
			{
			}
			num = (short)692125696;
			short num3 = num;
			num = (short)823853056;
			if (num != 0)
			{
			}
			global::System.Reflection.Assembly assembly = typeof(global::Autofac.Core.Resolving.IInstanceLookup).Assembly;
			global::Motorola.Common.Cryptography.Autofac.AutofacExtensions.a = assembly.GetType(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ὕᕟᙡୣe१३䉫⵭Ὧqᅳ塵⩷όཻᅽꒉ얋ﮗﾙ킛쾟즡톣횥", a_)).GetField(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ŝ͟ൡ੣ብ൧ቩᡫ", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			global::Motorola.Common.Cryptography.Autofac.AutofacExtensions.b = assembly.GetType(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ὕᕟᙡୣe१३䉫⵭Ὧqᅳ塵⩷όཻᅽꒉ\ude8b﶑ﶗ햙ﮝ튟쎡킣쾥잧쒩", a_)).GetField(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ŝşšၣཥṧ୩ᡫݭὯᱱ❳ɵ᥷᥹᝻", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007578 File Offset: 0x00005778
		public static global::Autofac.Core.Resolving.IResolveOperation Context(this global::Autofac.Core.Resolving.IInstanceLookup instanceLookup)
		{
			short num = (short)1290075132;
			short num2 = num;
			num = (short)1454308348;
			switch (num2 == num)
			{
			}
			num = (short)1035665409;
			if (num != 0)
			{
			}
			num = (short)741736448;
			short num3 = num;
			num = (short)1627783168;
			if (num != 0)
			{
			}
			return (global::Autofac.Core.Resolving.IResolveOperation)global::Motorola.Common.Cryptography.Autofac.AutofacExtensions.a.GetValue(instanceLookup);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007630 File Offset: 0x00005830
		public static global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Resolving.IInstanceLookup> ActivationStack(this global::Autofac.Core.Resolving.IResolveOperation resolveOperation)
		{
			short num = (short)487772753;
			short num2 = num;
			num = (short)1459212881;
			switch (num2 == num)
			{
			}
			num = (short)1067057152;
			if (num != 0)
			{
			}
			num = (short)135331840;
			short num3 = num;
			num = (short)119996417;
			if (num != 0)
			{
			}
			return (global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Resolving.IInstanceLookup>)global::Motorola.Common.Cryptography.Autofac.AutofacExtensions.b.GetValue(resolveOperation);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000076E8 File Offset: 0x000058E8
		public static void ForwardFactoryParameters(global::Autofac.Core.PreparingEventArgs e)
		{
			short num = (short)612189859;
			short num2 = num;
			num = (short)1933067939;
			switch (num2 == num)
			{
			}
			num = (short)56819713;
			if (num != 0)
			{
			}
			num = (short)759431168;
			short num3 = num;
			num = (short)877002752;
			if (num != 0)
			{
			}
			global::Autofac.Core.Resolving.IInstanceLookup instanceLookup = ((global::Autofac.Core.Resolving.IInstanceLookup)e.Context).Context().ActivationStack().Last<global::Autofac.Core.Resolving.IInstanceLookup>();
			e.Parameters = e.Parameters.Concat(instanceLookup.Parameters);
		}

		// Token: 0x04000032 RID: 50
		private static readonly global::System.Reflection.FieldInfo a;

		// Token: 0x04000033 RID: 51
		private static readonly global::System.Reflection.FieldInfo b;
	}
}
