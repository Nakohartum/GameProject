using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Interfaces
{
    public interface IQuestAndTextProvider : IController
    {
        event Func<GameObject> OnGameObjectGet;
        event Func<bool> OnBooleanValueGet;
    }
}
