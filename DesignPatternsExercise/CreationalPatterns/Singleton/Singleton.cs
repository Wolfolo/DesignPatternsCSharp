using System;

/// <summary>
/// A singleton class which provides only one instance of itself
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.Singleton
{
    class Singleton
    {
        static Singleton instance = new Singleton();

        public int Value { get; set; }

        /// <summary>
        /// A singleton class must not be instanced outside of his own
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// Returns the single instance for this class
        /// </summary>
        /// <returns>Always the same Singleton instance</returns>
        static public Singleton Instance()
        {
            return instance;
        }
    }
}
