using FlitBit.Wireup;
using FlitBit.Wireup.Meta;

[assembly: WireupDependency(typeof(FlitBit.IoC.Web.Common.AssemblyWireup))]
[assembly: Wireup(typeof(FlitBit.IoC.Owin.AssemblyWireup))]
namespace FlitBit.IoC.Owin
{
    public class AssemblyWireup : IWireupCommand
    {
        public void Execute(IWireupCoordinator coordinator)
        {
        }
    }
}
