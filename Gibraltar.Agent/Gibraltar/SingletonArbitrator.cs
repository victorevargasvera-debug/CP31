using System;
using System.Collections.Generic;

namespace Gibraltar
{
	// Token: 0x020000BC RID: 188
	internal static class SingletonArbitrator<T> where T : class
	{
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060007EE RID: 2030 RVA: 0x00010404 File Offset: 0x0000E604
		// (remove) Token: 0x060007EF RID: 2031 RVA: 0x0001043C File Offset: 0x0000E63C
		public static event global::System.EventHandler ActiveObjectChanged;

		// Token: 0x060007F0 RID: 2032 RVA: 0x00010474 File Offset: 0x0000E674
		public static bool Register(T newObject)
		{
			if (newObject == null)
			{
				throw new global::System.ArgumentNullException("newObject");
			}
			object @lock = global::Gibraltar.SingletonArbitrator<T>.m_Lock;
			bool result;
			lock (@lock)
			{
				if (!global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects.Contains(newObject))
				{
					global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects.Add(newObject);
				}
				if (global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects.Count == 1)
				{
					global::Gibraltar.SingletonArbitrator<T>.SetActiveObject(newObject);
				}
				result = (global::Gibraltar.SingletonArbitrator<T>.ActiveObject == newObject);
			}
			return result;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00010504 File Offset: 0x0000E704
		public static void Unregister(T closingObject)
		{
			if (closingObject == null)
			{
				throw new global::System.ArgumentNullException("closingObject");
			}
			object @lock = global::Gibraltar.SingletonArbitrator<T>.m_Lock;
			lock (@lock)
			{
				if (global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects.Contains(closingObject))
				{
					global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects.Remove(closingObject);
				}
				if (global::Gibraltar.SingletonArbitrator<T>.ActiveObject == closingObject)
				{
					T activeObject = default(T);
					if (global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects.Count > 0)
					{
						activeObject = global::Gibraltar.SingletonArbitrator<T>.m_RegisteredObjects[0];
					}
					global::Gibraltar.SingletonArbitrator<T>.SetActiveObject(activeObject);
				}
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000105AC File Offset: 0x0000E7AC
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x000105B4 File Offset: 0x0000E7B4
		public static T ActiveObject { get; private set; }

		// Token: 0x060007F4 RID: 2036 RVA: 0x000105BC File Offset: 0x0000E7BC
		private static void SetActiveObject(T newObject)
		{
			if (global::Gibraltar.SingletonArbitrator<T>.ActiveObject == newObject)
			{
				return;
			}
			global::Gibraltar.SingletonArbitrator<T>.ActiveObject = newObject;
			global::System.EventHandler activeObjectChanged = global::Gibraltar.SingletonArbitrator<T>.ActiveObjectChanged;
			if (activeObjectChanged != null)
			{
				activeObjectChanged(newObject, new global::System.EventArgs());
			}
		}

		// Token: 0x04000197 RID: 407
		private static readonly object m_Lock = new object();

		// Token: 0x04000198 RID: 408
		private static readonly global::System.Collections.Generic.List<T> m_RegisteredObjects = new global::System.Collections.Generic.List<T>();
	}
}
