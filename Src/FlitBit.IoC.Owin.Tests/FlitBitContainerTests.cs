using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlitBit.IoC.Owin.Tests
{
    [TestClass]
    public class FlitBitContainerTests : AbstractTest
    {
        [TestMethod]
        public void Container_Current_Is_Scoped_Properly()
        {
            using (Create.SharedOrNewContainer())
            {
                var first = Container.Current;
                Assert.AreNotEqual(Container.Root.Key, first.Key);
                Assert.AreEqual(Container.Current.Key, first.Key);

                // Simulating a Request
                Trace.WriteLine("Current Container Key: " + Container.Current.Key);
                Trace.WriteLine("Root Container Key: " + Container.Root.Key);
                var second = first.MakeChildContainer(CreationContextOptions.None);
                Trace.WriteLine("After MakeChildCalled Current Container Key: " + Container.Current.Key);
                Trace.WriteLine("Root Container Key: " + Container.Root.Key);
                Assert.AreNotEqual(first.Key, second.Key);
                Assert.AreNotEqual(Container.Root.Key, second.Key);
                Assert.AreEqual(Container.Current.Key, second.Key);
            }
        }

        //[TestMethod]
        //public void Ensure_Each_Request_Has_New_Container()
        //{

        //}
    }
}
