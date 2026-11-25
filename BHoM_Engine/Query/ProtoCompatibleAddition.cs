using System.ComponentModel;

namespace BH.Engine.Base
{
    public static partial class Query
    {
        [Description("Stage 4b test (e): a new public method; binary-compatible for every dependent.")]
        public static int ProtoCompatibleAddition(int value)
        {
            return value + 1;
        }
    }
}
