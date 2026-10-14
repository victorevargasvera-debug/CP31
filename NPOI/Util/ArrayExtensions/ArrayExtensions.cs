using System;

namespace NPOI.Util.ArrayExtensions
{
	// Token: 0x02000296 RID: 662
	public static class ArrayExtensions
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x00036570 File Offset: 0x00034770
		public static void ForEach(this global::System.Array array, global::System.Action<global::System.Array, int[]> action)
		{
			if (array.LongLength == 0L)
			{
				return;
			}
			global::NPOI.Util.ArrayExtensions.ArrayTraverse arrayTraverse = new global::NPOI.Util.ArrayExtensions.ArrayTraverse(array);
			do
			{
				action(array, arrayTraverse.Position);
			}
			while (arrayTraverse.Step());
		}
	}
}
