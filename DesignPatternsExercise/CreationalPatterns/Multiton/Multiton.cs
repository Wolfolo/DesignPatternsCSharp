using System;
using System.Collections.Generic;

/// <summary>
/// The multiton provides single instances of objects, the multiton might even be a singleton on his own
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.Multiton
{
    class Multiton
    {
        public enum Types
        {
            Class1,
            Class2,
        }

        Dictionary<Types, object> instances = new Dictionary<Types, object>();
        Dictionary<Types, Type> knownTypes = new Dictionary<Types, Type>();

        public Multiton()
        {
            KnownTypes();
        }

        protected void KnownTypes()
        {
            knownTypes.Add(Types.Class1, typeof(Class1));
            knownTypes.Add(Types.Class2, typeof(Class2));
        }

        public object GetInstanceOf(Types type)
        {
            if (!instances.ContainsKey(type))
            {
                // Use the Activator instead of a delegate to instance the class so the code is more clean
                instances.Add(type, Activator.CreateInstance(knownTypes[type]));
            }

            return instances[type];
        }
    }
}
