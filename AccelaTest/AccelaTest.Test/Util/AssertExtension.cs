using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AccelaTest.Test.Util
{
    public static class AssertExtension
    {
        public static void MessageExt(this ArgumentException ex, string message)
        {
            if (ex.Message ==message)
            {
                Assert.True(true);
            }
            else
            {
                Assert.False(true, string.Format("Message expected: {0} but receive message: {1}", ex.Message, message));
            }
        }
    }
}
