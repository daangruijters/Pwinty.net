#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line

namespace Pwinty.Net.DTO
{
    using System.Collections.Generic;
    using Pwinty.Net.Enums;

    internal class ImageDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ImageStatus Status { get; set; }
        public uint Copies { get; set; }
        public ImageSizing Sizing { get; set; }
        public int Price { get; set; }
        public int PriceToUser { get; set; }
        public string MD5Hash { get; set; }
        public string PreviewUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string SKU { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public string ErrorMessage { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
