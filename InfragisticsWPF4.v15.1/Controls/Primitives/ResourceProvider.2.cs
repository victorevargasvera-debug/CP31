using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000090 RID: 144
	public abstract class ResourceProvider<T> : global::Infragistics.Controls.Primitives.ResourceProvider where T : struct
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00015AA8 File Offset: 0x00013CA8
		static ResourceProvider()
		{
			if (!typeof(T).IsEnum)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage = global::SR.GetString("Provider_TypeNotEnum", new object[]
				{
					typeof(T)
				});
				return;
			}
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(from f in typeof(T).GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public)
			where f.IsLiteral
			select (T)((object)f.GetValue(null)));
			list.Sort();
			global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count = list.Count;
			if (global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count < 1)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage = global::SR.GetString("Provider_EnumEmpty", new object[]
				{
					typeof(T)
				});
				return;
			}
			int num = 0;
			foreach (T id in list)
			{
				int num2 = global::Infragistics.Controls.Primitives.ResourceProvider<T>.KeyToInt32(id);
				if (num2 != num)
				{
					global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage = global::SR.GetString("Provider_SparseEnumValues", new object[]
					{
						typeof(T)
					});
					return;
				}
				num++;
			}
			global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids = list.ToArray();
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00015C0C File Offset: 0x00013E0C
		protected ResourceProvider()
		{
			if (global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage != null)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Controls.Primitives.ResourceProvider<T>._TypeExceptionMessage);
			}
		}

		// Token: 0x170000D6 RID: 214
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override object this[object key]
		{
			get
			{
				T id;
				if (!global::Infragistics.Controls.Primitives.ResourceProvider<T>.TryGetEnumValueFromObject(key, out id))
				{
					throw new global::System.Collections.Generic.KeyNotFoundException(global::SR.GetString("Provider_KeyNotFound", new object[]
					{
						typeof(T),
						key
					}));
				}
				return this.GetResource(id);
			}
		}

		// Token: 0x170000D7 RID: 215
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override object this[string key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x170000D8 RID: 216
		public object this[T key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x060005B2 RID: 1458
		protected abstract object GetResource(T id);

		// Token: 0x060005B3 RID: 1459 RVA: 0x00015C88 File Offset: 0x00013E88
		internal static bool TryGetEnumValueFromObject(object key, out T id)
		{
			if (key is T)
			{
				id = (T)((object)key);
			}
			else
			{
				id = global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids[0];
				string text = key as string;
				if (text == null || !global::System.Enum.TryParse<T>(text, out id))
				{
					global::System.IConvertible convertible = key as global::System.IConvertible;
					if (convertible == null)
					{
						return false;
					}
					int num;
					try
					{
						num = convertible.ToInt32(null);
					}
					catch (global::System.Exception)
					{
						return false;
					}
					if (num >= 0 && num < global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count)
					{
						id = global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids[num];
						return true;
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00015D20 File Offset: 0x00013F20
		internal static int KeyToInt32(T id)
		{
			return ((global::System.IConvertible)((object)id)).ToInt32(null);
		}

		// Token: 0x0400020F RID: 527
		private static string _TypeExceptionMessage;

		// Token: 0x04000210 RID: 528
		internal static readonly int _Count;

		// Token: 0x04000211 RID: 529
		internal static readonly T[] _Ids;
	}
}
