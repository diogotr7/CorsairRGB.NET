namespace CorsairRGB.NET.Enums
{
    /// <summary>
    /// Contains shared list of all errors which could happen during calling of Corsair* functions.
    /// </summary>
    public enum CorsairError
    {
        Success,                     // if previously called function completed successfully.
        ServerNotFound,              // CUE is not running or was shut down or third-party control is disabled in CUE settings(runtime error).
        NoControl,                   // if some other client has or took over exclusive control (runtime error).
        ProtocolHandshakeMissing,    // if developer did not perform protocol handshake(developer error).
        IncompatibleProtocol,        // if developer is calling the function that is not supported by the server(either because protocol has broken by server or client or because the function is new and server is too old. Check CorsairProtocolDetails for details) (developer error).
        InvalidArguments,            // if developer supplied invalid arguments to the function(for specifics look at function descriptions). (developer error).
    };
}
