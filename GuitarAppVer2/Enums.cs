using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    public enum InstrumentType
    {
        Guitar,
        Mandolin,
        Banjo,
        Dobro,
        Fiddle,
        Bass,
    }

    public enum Type
    {
        ACOUSTIC,
        ELECTRIC,
    }

    public enum Builder
    {
        FENDER, 
        MARTIN, 
        GIBSON, 
        COLLINGS, 
        OLSON,
        RYAN,
        PRS,
        ANY, 
    }

    public enum Wood
    {
        INDIAN_ROSEWOOD,
        BRAZILIAN_ROSEWOOD,
        MAHOGANY,
        MAPLE,
        EBONY,
        CEDAR,
        OAK,
        ALDER,
        SITKA,
    }

    public enum Style
    {
        A,
        F,
    }
}
