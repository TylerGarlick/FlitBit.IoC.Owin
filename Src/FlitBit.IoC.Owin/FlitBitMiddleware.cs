using System.Threading.Tasks;
using Microsoft.Owin;

namespace FlitBit.IoC.Owin
{
    public class FlitBitMiddleware : OwinMiddleware
    {
        readonly CreationContextOptions _creationContextOptions;

        public FlitBitMiddleware(OwinMiddleware next, CreationContextOptions creationContextOptions = CreationContextOptions.InstanceTracking)
            : base(next)
        {
            _creationContextOptions = creationContextOptions;
        }

        public override async Task Invoke(IOwinContext context)
        {
            Container.Current.MakeChildContainer(_creationContextOptions);
            await Next.Invoke(context);
        }
    }
}