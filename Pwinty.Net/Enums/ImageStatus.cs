namespace Pwinty.Net.Enums
{
    /// <summary>
    /// Status of an image.
    /// </summary>
    public enum ImageStatus
    {
        /// <summary>
        /// There are two ways of uploading a file to Pwinty. You can either specify a url or you can POST using a
        /// multi-part upload. If you see this status, it means you have yet to do either for this image.
        /// </summary>
        AwaitingUrlOrData,

        /// <summary>
        /// You have specified a url associated with the image, but Pwinty hasn't yet downloaded it. There's nothing
        /// you need to do about this.
        /// </summary>
        NotYetDownloaded,

        /// <summary>
        /// We've received your image and verified it is a valid file format. All is ready to go.
        /// </summary>
        Ok,

        /// <summary>
        /// We tried using the url you specified to grab the image, but we didn't find it there.
        /// </summary>
        FileNotFoundAtUrl,

        /// <summary>
        /// You uploaded a file, but it wasn't in a valid format, or we checked the url you specified and didn't find a
        /// valid image there.
        /// </summary>
        Invalid,
    }
}
