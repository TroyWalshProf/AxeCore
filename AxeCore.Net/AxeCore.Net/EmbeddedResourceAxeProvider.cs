namespace AxeCore.Net
{
    internal class EmbeddedResourceAxeProvider : IAxeScriptProvider
    {
        public string GetScript() => EmbeddedResourceProvider.ReadEmbeddedFile("axe.min.js");
    }
}
