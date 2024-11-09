
namespace Zombo.Scripts{
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance
    {
        get {
            return _instance;
        }
        
    }
    private static GameManager _instance;
    private void Awake()
    {
        if(Instance==null)
        {
            _instance=this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(this);
        }
    }
        public void Update()
        {
            
        }
        public void OnDestroy()
        {
            
        }
    }
}
