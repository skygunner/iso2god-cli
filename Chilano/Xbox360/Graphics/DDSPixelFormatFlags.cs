﻿using System;

namespace Chilano.Xbox360.Graphics
{
   [Flags]
   public enum DdsPixelFormatFlags : uint
    {
        DDPF_ALPHAPIXELS = 1,
        DDPF_FOURCC = 4,
        DDPF_INDEXED = 0x20,
        DDPF_RGB = 0x40
    }
}

