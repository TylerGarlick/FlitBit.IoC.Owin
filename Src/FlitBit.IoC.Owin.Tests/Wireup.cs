using FlitBit.IoC.Owin.Tests;
using FlitBit.Wireup;
using FlitBit.Wireup.Meta;

[assembly: WireupDependency(typeof(FlitBit.IoC.Owin.AssemblyWireup))]
[assembly: Wireup(typeof(Wireup))]
namespace FlitBit.IoC.Owin.Tests
{
    public class Wireup : IWireupCommand
    {
        public void Execute(IWireupCoordinator coordinator)
        {
        }
    }
}
