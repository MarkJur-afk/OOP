using System.Diagnostics.Metrics;

namespace ulesanne2;

class Guitar : Instrument
{
    public Guitar(string nimi) : base(nimi) { }

    public override string Play()
    {
        return "Mängib keelpille";
    }
}

