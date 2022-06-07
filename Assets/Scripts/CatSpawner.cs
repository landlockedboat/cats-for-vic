using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] private CatColorsSO[] _catColors;
    [SerializeField] private GameObject _catPrefab;
    [SerializeField] private float _explosionForce = 20;

    public void SpawnCat()
    {
        var catObject = Instantiate(_catPrefab, transform.position + Vector3.forward , Random.rotation);
        var catRb = catObject.GetComponent<Rigidbody>();
        catRb.AddForce(Vector3.forward * _explosionForce);

        CatColorsSO randomColor = _catColors[Random.Range(0, _catColors.Length)];
        SkinnedMeshRenderer[] catMaterials = catObject.GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach (var material in catMaterials)
        {
            material.material.SetColor("_BellyColor", randomColor.Base);
            Debug.Log(material.material.name);

            material.material.SetColor("_FurColor", randomColor.Belly);
            material.material.SetColor("_StripesColor", randomColor.Fur);
            material.material.SetColor("_NoseColor", randomColor.Stripes);
            material.material.SetColor("_InnerEarColor", randomColor.Nose);
            material.material.SetColor("_OuterEarColor", randomColor.Stripes);
        }
    }

    public void DeleteAll()
    {
        var catObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (var cat in catObjects)
        {
            Destroy(cat);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
