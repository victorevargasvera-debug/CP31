using System;
using Autofac;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.Operation.RadioConversion;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule
{
	// Token: 0x02000003 RID: 3
	public class CommandHandlerModule : global::Autofac.Module
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					builder.Register(delegate(global::Autofac.IComponentContext c)
					{
						short num5 = (short)1809504502;
						short num6 = num5;
						num5 = (short)1570953462;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)341049344;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)1192689665;
						if (num5 != 0)
						{
						}
						num5 = (short)371326976;
						if (num5 != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
					}).As<global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor>();
					num2 = (short)1109852164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					builder.Register(delegate(global::Autofac.IComponentContext c)
					{
						short num5 = (short)969605121;
						if (num5 != 0)
						{
						}
						num5 = (short)1653211136;
						short num6 = num5;
						num5 = (short)1923604688;
						short num7 = num5;
						num5 = (short)472375504;
						switch (num7 == num5)
						{
						}
						num5 = (short)829161472;
						if (num5 != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService;
					}).As<global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase>();
					num2 = (short)1946508763;
					short num3 = num2;
					num2 = (short)1380015579;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_294;
					default:
						num2 = (short)1097334784;
						if (num2 != 0)
						{
						}
						num2 = (short)1759379456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					builder.Register(delegate(global::Autofac.IComponentContext c)
					{
						short num5 = (short)220092097;
						short num6 = num5;
						num5 = (short)1088050881;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)372572160;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)720568321;
						if (num5 != 0)
						{
						}
						num5 = (short)1501954048;
						if (num5 != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance;
					}).As<global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOpManager>();
					num2 = (short)101777409;
					if (num2 != 0)
					{
					}
					num2 = (short)1232994305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					builder.Register(delegate(global::Autofac.IComponentContext c)
					{
						short num5 = (short)991535534;
						short num6 = num5;
						num5 = (short)871866798;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)365887488;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)910557184;
						if (num5 != 0)
						{
						}
						num5 = (short)305725441;
						if (num5 != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.InstanceResolver.GetInstance;
					}).As<global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver>();
					builder.RegisterType<global::Motorola.CommonCPS.RadioManagement.Command.ASTROCommandHandler>();
					builder.RegisterType<global::Motorola.CommonCPS.RadioManagement.Command.ConvertRadioInBackgroundCommand>();
					num2 = (short)446758914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					builder.Register(delegate(global::Autofac.IComponentContext c)
					{
						short num5 = (short)316788896;
						short num6 = num5;
						num5 = (short)435146912;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)709623808;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)1709834240;
						if (num5 != 0)
						{
						}
						num5 = (short)193855489;
						if (num5 != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance();
					}).As<global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction>();
					num2 = (short)1355808768;
					short num4 = num2;
					num2 = (short)1117192198;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_294;
				case 6:
					builder.Register(delegate(global::Autofac.IComponentContext c)
					{
						short num5 = (short)1130591778;
						short num6 = num5;
						num5 = (short)1484486178;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)1197211648;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)308543489;
						if (num5 != 0)
						{
						}
						num5 = (short)2136276992;
						if (num5 != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance;
					}).As<global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer>();
					num2 = (short)1578893317;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
			}
			IL_294:
			builder.Register(delegate(global::Autofac.IComponentContext c)
			{
				short num5 = (short)979697665;
				if (num5 != 0)
				{
				}
				num5 = (short)1498349568;
				short num6 = num5;
				num5 = (short)382436953;
				short num7 = num5;
				num5 = (short)359892569;
				switch (num7 == num5)
				{
				}
				num5 = (short)5898240;
				if (num5 != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance;
			}).As<global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IMigrationOpUtility>();
			return;
			IL_2C:
			base.Load(builder);
			num2 = (short)475856899;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
