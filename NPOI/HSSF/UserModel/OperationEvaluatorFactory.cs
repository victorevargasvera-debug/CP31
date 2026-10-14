using System;
using System.Collections;
using System.Reflection;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.PTG;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000390 RID: 912
	internal class OperationEvaluatorFactory
	{
		// Token: 0x06001F1A RID: 7962 RVA: 0x0000253E File Offset: 0x0000073E
		private OperationEvaluatorFactory()
		{
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0005F810 File Offset: 0x0005DA10
		private static global::System.Collections.Hashtable InitialiseConstructorsMap()
		{
			return new global::System.Collections.Hashtable(32)
			{
				{
					typeof(global::NPOI.SS.Formula.PTG.AddPtg),
					typeof(global::NPOI.SS.Formula.Eval.AddEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.DividePtg),
					typeof(global::NPOI.SS.Formula.Eval.DivideEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.EqualPtg),
					typeof(global::NPOI.SS.Formula.Eval.EqualEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.MultiplyPtg),
					typeof(global::NPOI.SS.Formula.Eval.MultiplyEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.ConcatPtg),
					typeof(global::NPOI.SS.Formula.Eval.ConcatEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.GreaterEqualPtg),
					typeof(global::NPOI.SS.Formula.Eval.GreaterEqualEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.GreaterThanPtg),
					typeof(global::NPOI.SS.Formula.Eval.GreaterThanEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.LessEqualPtg),
					typeof(global::NPOI.SS.Formula.Eval.LessEqualEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.LessThanPtg),
					typeof(global::NPOI.SS.Formula.Eval.LessThanEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.NotEqualPtg),
					typeof(global::NPOI.SS.Formula.Eval.NotEqualEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.PercentPtg),
					typeof(global::NPOI.SS.Formula.Eval.PercentEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.PowerPtg),
					typeof(global::NPOI.SS.Formula.Eval.PowerEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.SubtractPtg),
					typeof(global::NPOI.SS.Formula.Eval.SubtractEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.UnaryMinusPtg),
					typeof(global::NPOI.SS.Formula.Eval.UnaryMinusEval)
				},
				{
					typeof(global::NPOI.SS.Formula.PTG.UnaryPlusPtg),
					typeof(global::NPOI.SS.Formula.Eval.UnaryPlusEval)
				}
			};
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0005F9AC File Offset: 0x0005DBAC
		private static void Add(global::System.Collections.Hashtable m, global::System.Type ptgClass, global::System.Type evalClass)
		{
			if (!typeof(global::NPOI.SS.Formula.PTG.Ptg).IsAssignableFrom(ptgClass))
			{
				throw new global::System.ArgumentException("Expected Ptg subclass");
			}
			if (!typeof(global::NPOI.SS.Formula.Eval.OperationEval).IsAssignableFrom(evalClass))
			{
				throw new global::System.ArgumentException("Expected OperationEval subclass");
			}
			if (!evalClass.IsPublic)
			{
				throw new global::System.Exception("Eval class must be public");
			}
			if (evalClass.IsAbstract)
			{
				throw new global::System.Exception("Eval class must not be abstract");
			}
			global::System.Reflection.ConstructorInfo constructor;
			try
			{
				constructor = evalClass.GetConstructor(global::NPOI.HSSF.UserModel.OperationEvaluatorFactory.OPERATION_CONSTRUCTOR_CLASS_ARRAY);
			}
			catch (global::System.Exception)
			{
				throw;
			}
			if (!constructor.IsPublic)
			{
				throw new global::System.Exception("Eval constructor must be public");
			}
			m[ptgClass] = constructor;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0005FA58 File Offset: 0x0005DC58
		public static global::NPOI.SS.Formula.Eval.OperationEval Create(global::NPOI.SS.Formula.PTG.OperationPtg ptg)
		{
			if (ptg == null)
			{
				throw new global::System.ArgumentException("ptg must not be null");
			}
			global::System.Type type = ptg.GetType();
			global::System.Reflection.ConstructorInfo constructorInfo = (global::System.Reflection.ConstructorInfo)global::NPOI.HSSF.UserModel.OperationEvaluatorFactory._constructorsByPtgClass[type];
			if (!(constructorInfo == null))
			{
				object[] parameters = new object[]
				{
					ptg
				};
				object obj;
				try
				{
					obj = constructorInfo.Invoke(parameters);
				}
				catch (global::System.Exception)
				{
					throw;
				}
				return (global::NPOI.SS.Formula.Eval.OperationEval)obj;
			}
			if (type == typeof(global::NPOI.SS.Formula.PTG.ExpPtg))
			{
				throw new global::System.Exception("ExpPtg currently not supported");
			}
			throw new global::System.Exception("Unexpected operation ptg class (" + type.Name + ")");
		}

		// Token: 0x04000BC7 RID: 3015
		private static global::System.Type[] OPERATION_CONSTRUCTOR_CLASS_ARRAY = new global::System.Type[]
		{
			typeof(global::NPOI.SS.Formula.PTG.Ptg)
		};

		// Token: 0x04000BC8 RID: 3016
		private static global::System.Collections.Hashtable _constructorsByPtgClass = global::NPOI.HSSF.UserModel.OperationEvaluatorFactory.InitialiseConstructorsMap();
	}
}
