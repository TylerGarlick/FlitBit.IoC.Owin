using System.Threading.Tasks;
using Microsoft.Owin;

namespace FlitBit.IoC.Owin
{
    public class FlitBitMiddleware : OwinMiddleware
    {
        public FlitBitMiddleware(OwinMiddleware next)
            : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {

            var container = Container.Current.MakeChildContainer(CreationContextOptions.InstanceTracking);
            OwinContainerHelpers.Current = container;
            await Next.Invoke(context);
        }
    }
}