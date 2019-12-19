using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DataDisplay : MonoBehaviour
{

    public DataSorter card;
    // Start is called before the first frame update
    void Start()
    {
        card.Print();
    }

}
