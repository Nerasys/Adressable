using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Threading.Tasks;



public class FirstLoad : MonoBehaviour
{
    public AssetReference assetReference;
    [SerializeField] private string _label;


    List<GameObject> listObject = new  List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Get(_label);
         for(int i = 0 ; i < listObject.Count;i++)
     {
         Debug.Log(listObject[i].name);


     }
    }
    
    private async void Get(string _label)
    {
         Debug.Log("Get");
        var locations = await Addressables.LoadResourceLocationsAsync(_label).Task;
        foreach (var location in locations)
        {
            listObject.Add((GameObject)location.Data);
        }

    

    }

}
