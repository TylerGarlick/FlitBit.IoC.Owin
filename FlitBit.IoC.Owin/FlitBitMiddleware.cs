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
            var serviceProvider = Container.Root.MakeChildContainer(CreationContextOptions.None);
            context.Set(Constants.ServiceProvider, serviceProvider);
            await Next.Invoke(context);
        }
    }
}