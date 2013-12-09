using Owin;

namespace FlitBit.IoC.Owin
{
    public static class OwinContainerHelpers
    {
        const string PerRequestContainer = "HttpPerRequestContainer";

        public static IContainer Current
        {
            get
            {
                return (IContainer)OwinRequestScopeContext.Current.Items[PerRequestContainer];
            }
            set
            {
                OwinRequestScopeContext.Current.Items[PerRequestContainer] = value;
            }
        }
    }
}