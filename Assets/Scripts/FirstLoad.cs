using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Threading.Tasks;



public class FirstLoad : MonoBehaviour
{
    public AssetReference assetReference;
    [SerializeField] private string _label;
    // Start is called before the first frame update
    void Start()
    {
        Get(_label);
    }
    
    private async void Get(string _label)
    {
         Debug.Log("Get");
        var locations = await Addressables.LoadResourceLocationsAsync(_label).Task;
        foreach (var location in locations)
        {
            Debug.Log("Load");
            await Addressables.InstantiateAsync(location).Task;
        }
    }

}
