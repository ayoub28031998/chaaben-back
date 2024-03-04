using System;
using System.Collections.Generic;

namespace API_SurveillenceCommerciale.Models
{
    public partial class ImageClient
    {
        public string MatriculeClient { get; set; } = null!;
        public byte[]? ImageCin1 { get; set; }
        public byte[]? ImageCin2 { get; set; }
        public byte[]? Image1 { get; set; }
        public byte[]? Image2 { get; set; }
        public byte[]? Image3 { get; set; }
        public byte[]? Image4 { get; set; }
    }
}
