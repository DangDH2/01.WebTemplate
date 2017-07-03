using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM
{
    public class CONST
    {
        public static class PARAM
        {
            public const string PRODUCT = "ProductId";
            public const string CATEGORY = "CategoryId";
            public const string USER = "UserId";
        }
        public static class ROLE
        {
            public const int SADMIN = 0;
            public const int ADMIN = 10;
            public const int MOD = 20;
            public const int NORMALUSER = 30;
            public const int GUEST = 40;
        }
        public class CUSTOMER
        {

        }
        public static class STATUS
        {
            public const string ACTIVE = "Active";
            public const string DELETE = "Delete";
            public const string PENDING = "Pending";

        }


    }
}
