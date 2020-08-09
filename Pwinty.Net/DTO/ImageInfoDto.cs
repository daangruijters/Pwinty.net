#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line
#pragma warning disable CA1056 // URI properties should not be strings
namespace Pwinty.Net.DTO
{
    using Pwinty.Net.Enums;

    public class ImageInfoDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ImageStatus Status { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
#pragma warning restore CA1056 // URI properties should not be strings
