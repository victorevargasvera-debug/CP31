using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C1 RID: 193
	internal class DeletePackageCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00044938 File Offset: 0x00042B38
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1341194132;
			short num2 = num;
			num = (short)78774164;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)826933248;
				if (num != 0)
				{
				}
				num = (short)203096064;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)1054212097;
					if (num != 0)
					{
					}
					global::System.Collections.ICollection collection = paras[0] as global::System.Collections.ICollection;
					try
					{
						num = (short)295698434;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.IEnumerator enumerator;
							switch (num3)
							{
							case 0:
								goto IL_2F9;
							case 1:
								num = (short)883818502;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_DB;
								}
								continue;
							case 3:
								try
								{
									num = (short)715128834;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_243;
										case 1:
											goto IL_1AA;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_191;
											}
											continue;
										case 3:
											num = (short)219807744;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											if (((global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase)enumerator.Current).References > 0)
											{
												num = (short)1728249862;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 5:
											if (!enumerator.MoveNext())
											{
												num = (short)867500035;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)931135492;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											result = false;
											num = (short)1291452417;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1F0:
										num = (short)1083441157;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_191:
										goto IL_1F0;
									}
									IL_1AA:
									goto IL_300;
									IL_243:
									goto IL_2DF;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_265;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_252:
										switch (num3)
										{
										case 0:
											if (disposable != null)
											{
												num = (short)540737538;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_2BA;
										case 1:
											goto IL_2B8;
										case 2:
											disposable.Dispose();
											num = (short)438304769;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_265;
									}
									IL_2B8:
									IL_2BA:
									goto EndFinally_10;
									IL_265:
									disposable = (enumerator as global::System.IDisposable);
									num = (short)755105792;
									num3 = (int)((global::System.IntPtr)num);
									goto IL_252;
									EndFinally_10:;
								}
								goto IL_2BB;
								IL_2DF:
								result = true;
								num = (short)1007091712;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_10E;
							case 5:
								goto IL_F6;
							case 6:
								if (collection.Count == 0)
								{
									num = (short)1680146437;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2BB;
							}
							IL_DB:
							if (collection != null)
							{
								num = (short)2072576001;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F6:
							result = false;
							num = (short)1616642052;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2BB:
							enumerator = collection.GetEnumerator();
							num = (short)943915011;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_10E:
						IL_2F9:;
					}
					catch (global::System.Exception)
					{
						result = true;
					}
					break;
				}
				}
				break;
			}
			}
			IL_300:
			num = (short)1015676928;
			short num4 = num;
			return result;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00044CA8 File Offset: 0x00042EA8
		protected override object ExecuteCmd(params object[] paras)
		{
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase> list;
			for (;;)
			{
				IL_00:
				short num = (short)90963968;
				short num2 = num;
				num = (short)109117440;
				int num3 = (int)num;
				switch (num3)
				{
				default:
					num = (short)1040842754;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.ICollection collection;
						global::System.Collections.IEnumerator enumerator;
						switch (num3)
						{
						case 0:
							goto IL_21F;
						case 1:
						{
							num = (short)2111405602;
							short num4 = num;
							num = (short)771128866;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)718667776;
								if (num != 0)
								{
								}
								num = (short)943783942;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_89;
							}
							continue;
						case 3:
							if (base.Interaction.ShowDeletePackagesConfirmationDialog(collection.Count))
							{
								num = (short)72744960;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_31C;
						case 4:
							try
							{
								num = (short)1948844032;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_12C;
										}
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1442906116;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase item = (global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase)enumerator.Current;
										list.Add(item);
										num = (short)2054094849;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_1A6;
									case 4:
										num = (short)1286995971;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_12E:
									num = (short)787677186;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_12C:
									goto IL_12E;
								}
								IL_1A6:
								goto IL_251;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1C8;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1B5:
									switch (num3)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1406074882;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_21E;
									case 1:
										goto IL_21C;
									case 2:
										disposable.Dispose();
										num = (short)354418689;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C8;
								}
								IL_21C:
								IL_21E:
								goto EndFinally_7;
								IL_1C8:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1431502848;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_1B5;
								EndFinally_7:;
							}
							goto IL_21F;
						case 5:
							goto IL_2C8;
						case 6:
							num = (short)1307967489;
							if (num != 0)
							{
							}
							if (paras.Count<object>() <= 0)
							{
								num = (short)591986693;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							collection = (paras[0] as global::System.Collections.ICollection);
							num = (short)828243971;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_89:
						if (paras != null)
						{
							num = (short)1400111105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
						IL_21F:
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase>();
						enumerator = collection.GetEnumerator();
						num = (short)1202651140;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_24B:
			throw new global::System.ArgumentNullException();
			IL_251:
			global::Motorola.CommonCPS.RadioManagement.BatchOp.DeletePackageBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.DeletePackageBatchOp(list);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase>(op);
			return true;
			IL_2C8:
			goto IL_24B;
			IL_31C:
			return false;
		}
	}
}
