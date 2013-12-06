using FlitBit.Wireup;
using FlitBit.Wireup.Meta;

[assembly: WireupDependency(typeof(FlitBit.IoC.Owin.AssemblyWireup))]
[assembly: Wireup(typeof(FlitBit.IoC.Owin.Tests.AssemblyWireup))]
namespace FlitBit.IoC.Owin.Tests
{
    public class AssemblyWireup : IWireupCommand
    {
        public void Execute(IWireupCoordinator coordinator)
        {
        }
    }
}
