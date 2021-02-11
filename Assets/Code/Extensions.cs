using UnityEngine;
using System.Linq;

namespace Extesnsions
{
	public static class Extensions
	{
		public static T GetOrAddComponent<T>(this GameObject child) where T : Component
        {
			var result = child.GetComponent<T>() ?? child.gameObject.AddComponent<T>();
			return result;
        }
	}
}

