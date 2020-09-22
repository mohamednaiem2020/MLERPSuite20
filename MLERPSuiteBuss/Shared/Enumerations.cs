using System;
using System.Collections.Generic;
using System.Text;

namespace MLERPSuiteBuss.Shared
{
    public class Enumerations
    {
        public enum Workflow
        {
            POSSales = 10101
        };


        public enum ObjectType
        {
            Package_name = 10000001,
            Package_description = 10000002,
            Module = 10000003,
            Right = 10000004,
            Screen_level = 10000005,
            Screen = 10000006,
            Workflow_master = 10000007,
            Step_Status = 10000008,
            Trans_Status = 10000009,
            Return_type = 10100001,
            Sales_type = 10100002,
            Customer = 10100003,
            Item = 10100004,
            Document = 10000010
        };
    }
}
