#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable SA1516 // Elements should be separated by blank line
namespace Pwinty.Net.DTO
{
    using System;
    using System.Collections.Generic;

    internal class OrderValidityDto
    {
        public int Id { get; set; }
        public bool IsValid { get; set; }
        public List<PhotoValidityDto> InvalidPhotos { get; set; }
        public string[] GeneralErrors { get; set; }
    }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore SA1516 // Elements should be separated by blank line
