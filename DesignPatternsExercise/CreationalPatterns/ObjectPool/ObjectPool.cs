using System.Collections.Generic;

/// <summary>
/// Creates objects and allow to put them at rest and retrieve them again as new
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.ObjectPool
{
    class ObjectPool
    {
        List<PooledObject> available = new List<PooledObject>();
        List<PooledObject> used = new List<PooledObject>();

        public PooledObject GetObject()
        {
            PooledObject obj;

            if (available.Count > 0)
            {
                obj = available[0];

                available.Remove(obj);
                used.Add(obj);
            }
            else
            {
                obj = new PooledObject();
                used.Add(obj);
            }

            return obj;
        }

        public void Release(PooledObject obj)
        {
            Cleanup(obj);

            available.Add(obj);
            used.Remove(obj);
        }

        /// <summary>
        /// Restores the properties of the object like as a new one
        /// </summary>
        /// <param name="obj"></param>
        private void Cleanup(PooledObject obj)
        {
            obj.Property = null;
        }
    }
}
