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
            Container.Current.MakeChildContainer(CreationContextOptions.None);
            await Next.Invoke(context);
        }
    }
}