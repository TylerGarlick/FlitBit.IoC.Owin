using Owin;

namespace FlitBit.IoC.Owin
{
    public static class AppBuilderExtensions
    {
        public static void RegisterPerHttpContainer(this IAppBuilder app, IContainer container)
        {
            app.Use<FlitBitMiddleware>();
        }
    }
}
