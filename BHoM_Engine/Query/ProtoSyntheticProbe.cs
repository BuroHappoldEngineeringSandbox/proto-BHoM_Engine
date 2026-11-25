using System.ComponentModel;

namespace BH.Engine.Base
{
    public static partial class Query
    {
        [Description("Stage 4b synthetic probe: used by one toolkit only, removed in test (f).")]
        public static string ProtoSyntheticProbe()
        {
            return "probe";
        }
    }
}
