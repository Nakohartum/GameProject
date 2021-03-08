using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Extensions
{
    public static class Extensions
    {
        public static T GetOrAddComponent<T>(this GameObject child) where T : Component
        {
            var component = child.GetComponent<T>();
            if (component == null)
            {
                component = child.AddComponent<T>();
            }
            return component;
        }

        
    }
}
