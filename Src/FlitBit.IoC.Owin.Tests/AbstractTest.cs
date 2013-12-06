using FlitBit.Wireup;

namespace FlitBit.IoC.Owin.Tests
{
    public abstract class AbstractTest
    {
        protected AbstractTest()
        {
            WireupCoordinator.SelfConfigure();
        }
    }
}