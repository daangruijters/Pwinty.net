#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line
namespace Pwinty.Net.DTO
{
    internal class PhotoValidityDto
    {
        public int Id { get; set; }
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
