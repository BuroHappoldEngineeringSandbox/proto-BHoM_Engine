using System.ComponentModel;

namespace BH.Engine.Base
{
    public static partial class Query
    {
        [Description("Re-run 3b synthetic probe: used by one toolkit only, removed to force a held core change.")]
        public static string ProtoRegressionProbe()
        {
            return "regression";
        }
    }
}
