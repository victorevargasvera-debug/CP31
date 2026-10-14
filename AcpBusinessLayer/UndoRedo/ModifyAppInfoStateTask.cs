using System;
using System.Collections.Generic;
using System.Reflection;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000057 RID: 87
	public class ModifyAppInfoStateTask : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x0006CCAC File Offset: 0x0006AEAC
		public ModifyAppInfoStateTask(global::System.Collections.Generic.Dictionary<string, bool> newStates)
		{
			int a_ = 3;
			base..ctor();
			if (newStates == null)
			{
				throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("믔닖께裚꧜뻞闠蛢雤", a_));
			}
			for (;;)
			{
				this.a = newStates;
				this.b = new global::System.Collections.Generic.Dictionary<string, bool>(newStates.Count);
				base.Description = global::AcpCommonResources.AcpResources.Modify_AppInfoManager_State;
				this.c = global::System.Type.GetType(typeof(global::AcpCommonLib.AppInfoManager).AssemblyQualifiedName);
				using (global::System.Collections.Generic.Dictionary<string, bool>.Enumerator enumerator = newStates.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair = enumerator.Current;
						global::System.Reflection.PropertyInfo property = this.c.GetProperty(keyValuePair.Key, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
						if (property == null)
						{
							throw new global::System.InvalidOperationException();
						}
						bool value = (bool)property.GetValue(null, null);
						this.b.Add(keyValuePair.Key, value);
					}
					break;
				}
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0006CDAC File Offset: 0x0006AFAC
		public override void Do()
		{
			short num = (short)1319564997;
			short num2 = num;
			num = (short)928773829;
			switch (num2 == num)
			{
			}
			num = (short)225116161;
			if (num != 0)
			{
			}
			num = (short)1271660544;
			short num3 = num;
			num = (short)70975488;
			if (num != 0)
			{
			}
			this.SetValues(false);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0006CE60 File Offset: 0x0006B060
		public override void Undo()
		{
			short num = (short)949115569;
			short num2 = num;
			num = (short)32004785;
			switch (num2 == num)
			{
			}
			num = (short)984940545;
			if (num != 0)
			{
			}
			num = (short)2108686336;
			short num3 = num;
			num = (short)990838784;
			if (num != 0)
			{
			}
			this.SetValues(true);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0006CF10 File Offset: 0x0006B110
		protected virtual void SetValues(bool isUndo)
		{
			short num = (short)962134020;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<string, bool> dictionary;
				global::System.Collections.Generic.Dictionary<string, bool>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					dictionary = this.a;
					goto IL_21C;
				case 1:
					num = (short)1246625793;
					if (num != 0)
					{
					}
					dictionary = this.b;
					goto IL_21C;
				case 2:
					try
					{
						num = (short)1329594372;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_163;
							case 2:
								goto IL_17A;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1705050113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)487022026;
								short num3 = num;
								num = (short)660561354;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_163;
								default:
								{
									num = (short)1049034752;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.KeyValuePair<string, bool> keyValuePair = enumerator.Current;
									this.c.GetProperty(keyValuePair.Key, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public).SetValue(null, keyValuePair.Value, null);
									num = (short)639959040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_90;
								}
								continue;
							}
							IL_92:
							num = (short)171769859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_90:
							goto IL_92;
							IL_163:
							num = (short)1685389314;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_17A:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_18D;
				case 3:
				{
					num = (short)1567555584;
					short num4 = num;
					num = (short)38404096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (!isUndo)
				{
					num = (short)1410138115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_18D:
				num = (short)1579220993;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21C:
				enumerator = dictionary.GetEnumerator();
				num = (short)2010316802;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000168 RID: 360
		private global::System.Collections.Generic.Dictionary<string, bool> a;

		// Token: 0x04000169 RID: 361
		private global::System.Collections.Generic.Dictionary<string, bool> b;

		// Token: 0x0400016A RID: 362
		private global::System.Type c;
	}
}
