using System;
using System.ServiceModel.Description;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000FC RID: 252
	internal static class WcfExtensions
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x0000C338 File Offset: 0x0000A538
		public static void ApplyOperationBehavior<T>(this global::System.ServiceModel.Description.ServiceDescription description, global::System.Func<global::System.ServiceModel.Description.OperationDescription, T> behaviorFactory, global::System.Action<T> behaviorManipulation) where T : class, global::System.ServiceModel.Description.IOperationBehavior
		{
			foreach (global::System.ServiceModel.Description.ServiceEndpoint endpoint in description.Endpoints)
			{
				endpoint.ApplyOperationBehavior(behaviorFactory, behaviorManipulation);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000C388 File Offset: 0x0000A588
		public static void ApplyOperationBehavior<T>(this global::System.ServiceModel.Description.ServiceEndpoint endpoint, global::System.Func<global::System.ServiceModel.Description.OperationDescription, T> behaviorFactory, global::System.Action<T> behaviorManipulation) where T : class, global::System.ServiceModel.Description.IOperationBehavior
		{
			foreach (global::System.ServiceModel.Description.OperationDescription operationDescription in endpoint.Contract.Operations)
			{
				T t = operationDescription.Behaviors.Find<T>();
				if (t == null)
				{
					t = behaviorFactory(operationDescription);
					operationDescription.Behaviors.Add(t);
				}
				behaviorManipulation(t);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000C408 File Offset: 0x0000A608
		public static void ApplyServiceBehavior<T>(this global::System.ServiceModel.Description.ServiceDescription description, global::System.Func<T> behaviorFactory, global::System.Action<T> behaviorManipulation) where T : class, global::System.ServiceModel.Description.IServiceBehavior
		{
			T t = description.Behaviors.Find<T>();
			if (t == null)
			{
				t = behaviorFactory();
				description.Behaviors.Add(t);
			}
			behaviorManipulation(t);
		}
	}
}
