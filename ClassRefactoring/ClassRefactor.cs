using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            if (Type == SwallowType.African)
            {
                switch(Load) {
                    case SwallowLoad.None:
                     return 22;
                    case SwallowLoad.Coconut:
                    return 18;
                }
            }
            if (Type == SwallowType.European)
            {
               switch(Load) {
                    case SwallowLoad.None:
                     return 20;
                    case SwallowLoad.Coconut:
                    return 16;
                }
            }
            throw new InvalidOperationException();
        }
    }
}
