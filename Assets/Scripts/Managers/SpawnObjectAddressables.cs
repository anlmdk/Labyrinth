using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SpawnObjectAddressables : MonoBehaviour
{
    [SerializeField] AssetReference assetReference;
    [SerializeField] AssetLabelReference assetLabelReference;
    
    void Update()
    {
        AddressablesObjects();
    }

    public void AddressablesObjects()
    {
        // Klasorleri ve icindeki objeleri addressable'a ekleme 
        
        Addressables.LoadAssetsAsync<Sprite>(assetLabelReference, (sprite) => {

            Debug.Log(sprite);
        });
    }
}
