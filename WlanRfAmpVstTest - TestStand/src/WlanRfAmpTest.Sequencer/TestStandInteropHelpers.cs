using System;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.TestStand.Interop.AdapterAPI;

namespace WlanRfAmpTest.Sequencer
{
    static class TestStandInteropHelpers
    {
        internal static bool TrySetStringPropertyRecursive(PropertyObject root, string leafName, string value, int depth = 0)
        {
            if (root == null || depth > 48)
                return false;

            try
            {
                if (root.Exists(leafName, PropertyOptions.PropOption_NoOptions))
                {
                    root.SetValString(leafName, PropertyOptions.PropOption_NoOptions, value);
                    return true;
                }
            }
            catch
            {
                // Continue searching other branches.
            }

            int n;
            try
            {
                n = root.GetNumSubProperties("");
            }
            catch
            {
                return false;
            }

            for (int i = 0; i < n; i++)
            {
                PropertyObject child = null;
                try
                {
                    child = root.GetNthSubProperty("", i, PropertyOptions.PropOption_NoOptions);
                    if (TrySetStringPropertyRecursive(child, leafName, value, depth + 1))
                        return true;
                }
                catch
                {
                    // ignore
                }
                finally
                {
                    if (child != null && System.Runtime.InteropServices.Marshal.IsComObject(child))
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(child);
                }
            }

            return false;
        }

        internal static bool TrySetNumberPropertyRecursive(PropertyObject root, string leafName, double value, int depth = 0)
        {
            if (root == null || depth > 48)
                return false;

            try
            {
                if (root.Exists(leafName, PropertyOptions.PropOption_NoOptions))
                {
                    root.SetValNumber(leafName, PropertyOptions.PropOption_NoOptions, value);
                    return true;
                }
            }
            catch
            {
                // Continue searching other branches.
            }

            int n;
            try
            {
                n = root.GetNumSubProperties("");
            }
            catch
            {
                return false;
            }

            for (int i = 0; i < n; i++)
            {
                PropertyObject child = null;
                try
                {
                    child = root.GetNthSubProperty("", i, PropertyOptions.PropOption_NoOptions);
                    if (TrySetNumberPropertyRecursive(child, leafName, value, depth + 1))
                        return true;
                }
                catch
                {
                    // ignore
                }
                finally
                {
                    if (child != null && System.Runtime.InteropServices.Marshal.IsComObject(child))
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(child);
                }
            }

            return false;
        }

        internal static void ConfigureDotNetAction(
            Step step,
            string assemblyPath,
            string className,
            string methodNameForPrototype,
            string[] parameterValueExpressionsInOrder)
        {
            if (step == null)
                throw new ArgumentNullException(nameof(step));

            step.Module.Step.ChangeAdapter(AdapterKeyNames.DotNetAdapterKeyname);
            var dn = (DotNetModule)step.Module;
            dn.SetAssembly(DotNetModuleAssemblyLocations.DotNetModule_AssemblyLocation_File, assemblyPath);
            dn.ClassName = className;

            if (dn.Calls.Count == 0)
                dn.Calls.New(0);
            DotNetCall call = dn.Calls[0];
            call.LoadPrototypeFromSignature(methodNameForPrototype, true, 0);
            ApplyDotNetInputParameterExpressions(call, parameterValueExpressionsInOrder);
        }

        /// <summary>
        /// Numeric Limit Test + .NET module: measurement is the method return value (double). Limits are wide defaults; tighten in the editor for production limits.
        /// </summary>
        internal static void ConfigureDotNetNumericLimitTest(
            Step step,
            string assemblyPath,
            string className,
            string methodNameForPrototype,
            string[] parameterValueExpressionsInOrder,
            double limitLow,
            double limitHigh,
            string comparisonComp,
            string measurementUnits = null)
        {
            if (step == null)
                throw new ArgumentNullException(nameof(step));

            step.Module.Step.ChangeAdapter(AdapterKeyNames.DotNetAdapterKeyname);
            var dn = (DotNetModule)step.Module;
            dn.SetAssembly(DotNetModuleAssemblyLocations.DotNetModule_AssemblyLocation_File, assemblyPath);
            dn.ClassName = className;

            if (dn.Calls.Count == 0)
                dn.Calls.New(0);
            DotNetCall call = dn.Calls[0];
            call.LoadPrototypeFromSignature(methodNameForPrototype, true, 0);
            ApplyDotNetInputParameterExpressions(call, parameterValueExpressionsInOrder);
            TryApplyNumericLimitSettings(step, limitLow, limitHigh, comparisonComp, measurementUnits);
        }

        static void ApplyDotNetInputParameterExpressions(DotNetCall call, string[] parameterValueExpressionsInOrder)
        {
            if (parameterValueExpressionsInOrder == null)
                parameterValueExpressionsInOrder = Array.Empty<string>();

            int e = 0;
            for (int i = 0; i < call.Parameters.Count; i++)
            {
                DotNetParameter p = call.Parameters[i];
                if (IsDotNetReturnParameter(p))
                    continue;
                if (e >= parameterValueExpressionsInOrder.Length)
                    break;
                p.ValueExpr = parameterValueExpressionsInOrder[e++];
            }
        }

        static bool IsDotNetReturnParameter(DotNetParameter p)
        {
            try
            {
                string name = p.ParameterName ?? "";
                if (name.IndexOf("Return", StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
                // COM interop often uses 3 for the method return value (not an argument).
                if ((int)p.Direction == 3)
                    return true;
            }
            catch
            {
                // ignore
            }

            return false;
        }

        static void TryApplyNumericLimitSettings(Step step, double low, double high, string comp, string measurementUnits)
        {
            PropertyObject po = step.AsPropertyObject();
            TrySetStringPropertyRecursive(po, "Comp", comp);
            TrySetNumberPropertyRecursive(po, "Limits.Low", low);
            TrySetNumberPropertyRecursive(po, "Limits.High", high);
            if (!string.IsNullOrEmpty(measurementUnits))
                TrySetStringPropertyRecursive(po, "Result.Units", measurementUnits);
        }
    }
}
