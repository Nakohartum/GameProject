using UnityEngine;


namespace Extensions
{
    public static class Extensions
    {
        #region Methods

        public static T GetOrAddComponent<T>(this GameObject child) where T : Component
        {
            var component = child.GetComponent<T>();
            if (component == null)
            {
                component = child.AddComponent<T>();
            }
            return component;
        }

        #endregion
    }
}
